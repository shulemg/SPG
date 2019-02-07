//INSTANT C# NOTE: Formerly VB project-level imports:
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using System;
using SuperiorPackGroup.SPGTableAdapters;
using System.Text;
using DXDAL.SPGData;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Linq;

namespace SuperiorPackGroup
{
	[System.ComponentModel.DataObject()]
	public class ItemsBLL
	{

		private List<Change> changes = new List<Change>();

		private ItemsTableAdapter m_ItemsTableAdapter = null;
		public ItemsTableAdapter Adapter
		{

			get
			{
				if (m_ItemsTableAdapter != null)
				{
					return m_ItemsTableAdapter;
				}

				m_ItemsTableAdapter = new ItemsTableAdapter();
				m_ItemsTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;

				return m_ItemsTableAdapter;
			}

		}

		public static bool AllowEdit(Session session, int itemID)
		{

			Items item = (Items)session.GetObjectByKey<Items>(itemID, true);
			if (item.Editing)
			{
				return false;
			}
			else
			{
				item.Editing = true;
				item.Save();
				return true;
			}

		}

		public bool DeleteIem(int itemID)
		{

			SPG.ItemsDataTable items = Adapter.GetItemByID(itemID);
			int rowsAffected = 0;

			if (items.Count() == 1)
			{
				if ((new ProductionBLL()).GetProductionByItemID(itemID).Count != 0 || (new InventoryBLL()).GetInventoryView(null, null, null, itemID, null).Count != 0 || ReceivingDetailsBLL.GetReceivingDetailsByItemID(itemID).Count != 0 || SuperiorPackGroup.ShippingDetailsBLL.GetShippingDetailsByItemID(itemID).Count != 0 || ReturnDetailsBLL.GetReceivingReturnDetailsByItemID(itemID).Count != 0 || (new ShippingReturnDetailsBLL()).GetShippingReturnDetailsByItemID(itemID).Count != 0)
				{
					if (MessageBox.Show("You can't delete this item because there are production, inventory, Receiving's, or Shipping's assigned to it. Do you want ot mark it as inactive?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
					{
						Adapter.InactivateItem(itemID);
						return true;
					}
					else
					{
						return true;
					}
				}
				rowsAffected = Convert.ToInt32((new BOMBLL()).DeleteBOMByFGItemID(itemID));
				rowsAffected = Adapter.Delete(itemID, items[0].ts);
			}

			return Convert.ToBoolean(rowsAffected);

		}

		public void EndedEdit(Session session, int itemID)
		{

			try
			{
				Items item = (Items)session.GetObjectByKey<Items>(itemID, true);
				item.Editing = false;
				item.Save();
			}
			catch
			{

			}

		}

		/// <summary>
		/// Returns a list of all required material with their availability at the specified location.
		/// </summary>
		/// <param name="itemID">The item we're looking for</param>
		/// <param name="localLocation">The location we're looking for</param>
		/// <returns></returns>
		/// <remarks></remarks>
		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.ItemsDataTable GetAvailabilityByItemID(int itemID, int localLocation)
		{

			return Adapter.GetAvailabilityByItemID(itemID, localLocation);

		}

		/// <summary>
		/// Returns a formatted string of the BOM that's not available for the production or an empty string if all material is available.
		/// When the new amount being used is less than the old amount it will return an empty string.
		/// </summary>
		/// <param name="itemID">The item ID of the product we want to produce.</param>
		/// <param name="quantity">The quantity we want to produce.</param>
		/// <param name="oldQuantity">The old quantity that was used, when modifying records the message should only give the amount that's needed more than before.</param>
		/// <returns></returns>
		/// <remarks></remarks>
		public static string GetAvailabilityByItemID(Session session, int itemID, int quantity, int? oldQuantity, int localLocation)
		{

			StringBuilder lUnavailableBOM = new StringBuilder();
			float availableQuantity = 0;
			lUnavailableBOM.Append(string.Empty);

			int newQuantity = 0;
			if (oldQuantity.HasValue && oldQuantity.Value > 0)
			{
				newQuantity = quantity - oldQuantity.Value;
				if (newQuantity < 1)
				{
					return lUnavailableBOM.ToString();
				}
			}
			else
			{
				newQuantity = quantity;
			}

			using (XPView itemBomXPView = new XPView(session, typeof(BOMs)))
			{
				CriteriaOperator criteria = CriteriaOperator.Parse("BOMFiniGoodID = ?", itemID);
				try
				{
					itemBomXPView.Criteria = criteria;
					itemBomXPView.Properties.AddRange(new ViewProperty[]
					{
						new ViewProperty("RawMaterialCode", SortDirection.Ascending, "[BOMRawMatID].[ItemCode]", false, true),
						new ViewProperty("RawMaterialID", SortDirection.None, "[BOMRawMatID]", false, true),
						new ViewProperty("RawMaterialNeeded", SortDirection.None, CriteriaOperator.Parse("(BOMQuantity + (ScrapFactor / 100 * BOMQuantity)) * ?", newQuantity), false, true)
					});
					foreach (ViewRecord bomRecord in itemBomXPView)
					{
						availableQuantity = GetQtyOnHandByID(session, Convert.ToInt32(bomRecord["RawMaterialID"]), localLocation);

						if (Convert.ToSingle(bomRecord["RawMaterialNeeded"]) > availableQuantity)
						{
							lUnavailableBOM.Append(string.Format("You need to use {0} of {1}, but you have only {2} on hand.{3}", bomRecord["RawMaterialNeeded"], bomRecord["RawMaterialCode"], availableQuantity, Environment.NewLine));
						}

					}
				}
				catch (ArgumentException ex)
				{
					return "There was an error while trying to verify available raw material.";
				}
			}

			return lUnavailableBOM.ToString();

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public double GetCaseGrossWeight(int itemID)
		{

			double? weight = Adapter.GetCaseGrossWeight(itemID);
			if (weight.HasValue)
			{
				return weight.Value;
			}
			else
			{
				return 0;
			}

		}

		public static double GetCaseQuantity(int itemID)
		{

			//Returns units per case
			try
			{
				Items item = (Items)Session.DefaultSession.GetObjectByKey<Items>(itemID, true);
				return item.intUnitsPerCase * item.intQtyPerUnit;
			}
			catch (Exception ex)
			{
				return 0;
			}

		}

		public int GetCasesPerPallet(int itemID)
		{

			return Convert.ToInt32(Adapter.GetCasesPerPallet(itemID));

		}

		public int GetCustomerIDByItemID(int itemID)
		{

			return Convert.ToInt32(Adapter.GetItemsCustomer(itemID).Rows[0]["CustomerID"]);

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public static string GetDescriptionByItemID(int? itemID)
		{

			if (!itemID.HasValue)
			{
				return null;
			}

			try
			{
				Items item = (Items)Session.DefaultSession.GetObjectByKey<Items>(itemID.Value, true);
				return item.ItemDescription;
			}
			catch (Exception ex)
			{
				return null;
			}

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.ItemsDataTable GetItemBYId(int itemID)
		{

			return Adapter.GetItemByID(itemID);

		}

		public static Items GetItemByUpc(string upc)
		{

			XPCollection<Items> itemCollection = new XPCollection<Items>(Session.DefaultSession, new BinaryOperator(Items.Fields.UPC.PropertyName, upc, BinaryOperatorType.Equal));

			if (itemCollection.Count > 0)
			{
				return itemCollection[0];
			}
			else
			{
				return null;
			}

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public static XPView GetItemCodeAndIDsByTypesAndCustomerID(int? customerID, string types, bool universal, Session DXSession)
		{

			XPView ItemCodesXPView = new XPView(Session.DefaultSession, typeof(Items));
			ItemCodesXPView.Properties.AddRange(new ViewProperty[]
			{
				new ViewProperty("ItemID", SortDirection.None, "[ItemID]", false, true),
				new ViewProperty("ItemCode", SortDirection.Ascending, "[ItemCode]", false, true),
				new ViewProperty("ItemCustomerID", SortDirection.None, "[ItemCustomerID]", false, true),
				new ViewProperty("ItemType", SortDirection.None, "[ItemType]", false, true)
			});
			if (universal == true)
			{
				int universalCustomer = CompanySettingsBLL.GetUniversalCustomer();
				if (customerID.HasValue)
				{
					ItemCodesXPView.Criteria = CriteriaOperator.And(CriteriaOperator.Or(new BinaryOperator(Items.Fields.ItemCustomerID.PropertyName, customerID.Value, BinaryOperatorType.Equal), new BinaryOperator(Items.Fields.ItemCustomerID.PropertyName, universalCustomer, BinaryOperatorType.Equal), new InOperator(Items.Fields.ItemCustomerID.PropertyName, CustomersBLL.GetRelatedCustomerIDs(CustomersBLL.GetCustomer(customerID.Value, DXSession)))), new InOperator(Items.Fields.ItemType.PropertyName, types.Split('|')));
				}
				else
				{
					ItemCodesXPView.Criteria = new InOperator(Items.Fields.ItemType.PropertyName, types.Split('|'));
				}
			}
			else
			{
				if (customerID.HasValue)
				{
					ItemCodesXPView.Criteria = CriteriaOperator.And(new BinaryOperator(Items.Fields.ItemCustomerID.PropertyName, customerID.Value, BinaryOperatorType.Equal), new InOperator(Items.Fields.ItemType.PropertyName, types.Split('|')));
				}
				else
				{
					ItemCodesXPView.Criteria = new InOperator(Items.Fields.ItemType.PropertyName, types.Split('|'));
				}
			}

			return ItemCodesXPView;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.ItemsDataTable GetItemsByCustomerID(int customerID)
		{

			return Adapter.GetItemsByCustomerID(customerID);

		}

		public static XPView GetItemsByCustomerIDAndType(int customerID, string types)
		{

			XPView CustomersItems = new XPView(Session.DefaultSession, typeof(Items));
			CustomersItems.Properties.AddRange(new ViewProperty[]
			{
				new ViewProperty("ItemCode", SortDirection.Ascending, Items.Fields.ItemCode.PropertyName, false, true),
				new ViewProperty("ItemDescription", SortDirection.None, Items.Fields.ItemDescription.PropertyName, false, true),
				new ViewProperty("QuantityOnHand", SortDirection.None, Items.Fields.TotalQuantityOnHand.PropertyName, false, true),
				new ViewProperty("intUnitsPerPallet", SortDirection.None, Items.Fields.intUnitsPerPallet.PropertyName, false, true)
			});

			if (string.IsNullOrEmpty(types))
			{
				CustomersItems.Criteria = new BinaryOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, customerID, BinaryOperatorType.Equal);
			}
			else
			{
				CustomersItems.Criteria = new GroupOperator(GroupOperatorType.And, new BinaryOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, customerID, BinaryOperatorType.Equal), new InOperator(Items.Fields.ItemType.PropertyName, types.Split('|')));
			}

			return CustomersItems;

		}

		//<System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
		//Public Function GetItemsByCustomerIDAndType(ByVal customerID As Integer, ByVal types As String) As SPG.ItemsDataTable

		//    If String.IsNullOrEmpty(types) Then
		//        Return GetItemsByCustomerID(customerID)
		//    End If

		//    Return Adapter.GetItemsByCustomerIdAndType(customerID, types)

		//End Function

		public static DataTable GetItemTypes()
		{

			DataTable itemTypesTable = new DataTable("ItemTypes");

			DataColumn name = new DataColumn("Type") {DataType = Type.GetType("System.String")};
			itemTypesTable.Columns.Add(name);
			name = new DataColumn()
			{
				ColumnName = "Description",
				DataType = Type.GetType("System.String")
			};
			itemTypesTable.Columns.Add(name);

			DataRow row = itemTypesTable.NewRow();
			row["Type"] = "RM";
			row["Description"] = "Raw Material";
			itemTypesTable.Rows.Add(row);
			row = itemTypesTable.NewRow();
			row["Type"] = "IG";
			row["Description"] = "Intermediate Goods";
			itemTypesTable.Rows.Add(row);
			row = itemTypesTable.NewRow();
			row["Type"] = "FG";
			row["Description"] = "Finished Goods";
			itemTypesTable.Rows.Add(row);

			return itemTypesTable;

		}

		public ArrayList GetItemUOMs()
		{

			ArrayList itemUOMs = new ArrayList();

			try
			{
//INSTANT C# NOTE: Commented this declaration since looping variables in 'foreach' loops are declared in the 'foreach' header in C#:
//				Dim row As SPG.ItemsRow
				foreach (SPG.ItemsRow row in this.Adapter.GetItemUOMs())
				{
					string uom = row.strUnitOfMeasure;
					if (!itemUOMs.Contains(uom))
					{
						itemUOMs.Add(uom);
					}
				}
			}
			finally
			{

			}

			return itemUOMs;

		}

		public static int GetNewItemID()
		{

			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.UserConnectionString);
			System.Data.SqlClient.SqlCommand myCommand = new System.Data.SqlClient.SqlCommand("dbo.spNewIDSafe", conn);
			System.Data.SqlClient.SqlParameter myNewID = new System.Data.SqlClient.SqlParameter("@nRetVal", SqlDbType.Int);
			myCommand.CommandType = CommandType.StoredProcedure;
			myNewID.Direction = ParameterDirection.Output;
			myCommand.Parameters.AddWithValue("@cName", "tblItems");
			myCommand.Parameters.AddWithValue("@cPkField", "ItemID");
			myCommand.Parameters.Add(myNewID);

			conn.Open();
			myCommand.ExecuteNonQuery();

			return Convert.ToInt32(myNewID.Value);

		}

		public int GetPallets(int itemID)
		{

			return Adapter.GetPallets(itemID).Value;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public static float GetQtyOnHandByID(Session session, int? itemID, int locationID, string lot = null, int? LPNNumber = null)
		{

			if (itemID.HasValue == false)
			{
				return 0;
			}

			if (!(LPNNumber == null))
			{
				return GetQtyOnHandByIDAndLot(session, itemID, locationID, lot, LPNNumber);
			}

			//If locationID.HasValue = False Then
			//    locationID = UsersBLL.GetUsersLocalLocation(My.Settings.UserName).Oid
			//End If

			try
			{
				if (locationID == 0)
				{
					return Convert.ToSingle(session.Evaluate<LocationInventory>(new AggregateOperand("", LocationInventory.Fields.QuantityOnHand.PropertyName, Aggregate.Sum), new BinaryOperator(LocationInventory.Fields.LocationInventoryItem.ItemID, itemID.Value, BinaryOperatorType.Equal)));
				}
				else
				{
					LocationInventory quantity = session.FindObject<LocationInventory>(new GroupOperator(new BinaryOperator(LocationInventory.Fields.LocationInventoryItem.ItemID, itemID.Value, BinaryOperatorType.Equal) & new BinaryOperator(LocationInventory.Fields.Location.Oid.PropertyName, locationID, BinaryOperatorType.Equal)));
					//Dim item As Items = Session.DefaultSession.GetObjectByKey(Of Items)(itemID, True)
					//Return item.s ngQuantityOnHand
					return quantity.QuantityOnHand;
				}
			}
			catch (Exception ex)
			{
				return 0;
			}

		}
		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public static float GetQtyOnHandByIDAndLot(Session session, int? itemID, int locationID, string lot, int? LPNNumber)
		{

			if (itemID.HasValue == false || (LPNNumber == null))
			{
				return 0;
			}

			//If locationID.HasValue = False Then
			//    locationID = UsersBLL.GetUsersLocalLocation(My.Settings.UserName).Oid
			//End If

			try
			{
				if ((lot == null))
				{
					if (locationID == 0)
					{
						return Convert.ToSingle(session.Evaluate<LocationInventoryByLot>(new AggregateOperand("", LocationInventoryByLot.Fields.QuantityOnHand.PropertyName, Aggregate.Sum), new GroupOperator(GroupOperatorType.And, new BinaryOperator(LocationInventoryByLot.Fields.LocationInventoryItem.ItemID, itemID.Value, BinaryOperatorType.Equal), new BinaryOperator(LocationInventoryByLot.Fields.LPNNumber, LPNNumber.Value, BinaryOperatorType.Equal))));
					}
					else
					{
						LocationInventoryByLot quantity = session.FindObject<LocationInventoryByLot>(new GroupOperator(new BinaryOperator(LocationInventoryByLot.Fields.LocationInventoryItem.ItemID, itemID.Value, BinaryOperatorType.Equal) & new BinaryOperator(LocationInventoryByLot.Fields.Location.Oid.PropertyName, locationID, BinaryOperatorType.Equal) & new BinaryOperator(LocationInventoryByLot.Fields.LPNNumber, LPNNumber.Value, BinaryOperatorType.Equal)));
						//Dim item As Items = Session.DefaultSession.GetObjectByKey(Of Items)(itemID, True)
						//Return item.s ngQuantityOnHand
						return quantity.QuantityOnHand;
					}
				}
				else
				{
					if (locationID == 0)
					{
						return Convert.ToSingle(session.Evaluate<LocationInventoryByLot>(new AggregateOperand("", LocationInventoryByLot.Fields.QuantityOnHand.PropertyName, Aggregate.Sum), new GroupOperator(GroupOperatorType.And, new BinaryOperator(LocationInventoryByLot.Fields.LocationInventoryItem.ItemID, itemID.Value, BinaryOperatorType.Equal), new BinaryOperator(LocationInventoryByLot.Fields.LocationInventoryLot, lot, BinaryOperatorType.Equal), new BinaryOperator(LocationInventoryByLot.Fields.LPNNumber, LPNNumber.Value, BinaryOperatorType.Equal))));
					}
					else
					{
						LocationInventoryByLot quantity = session.FindObject<LocationInventoryByLot>(new GroupOperator(new BinaryOperator(LocationInventoryByLot.Fields.LocationInventoryItem.ItemID, itemID.Value, BinaryOperatorType.Equal) & new BinaryOperator(LocationInventoryByLot.Fields.Location.Oid.PropertyName, locationID, BinaryOperatorType.Equal) & new BinaryOperator(LocationInventoryByLot.Fields.LocationInventoryLot, lot, BinaryOperatorType.Equal) & new BinaryOperator(LocationInventoryByLot.Fields.LPNNumber, LPNNumber.Value, BinaryOperatorType.Equal)));
						//Dim item As Items = Session.DefaultSession.GetObjectByKey(Of Items)(itemID, True)
						//Return item.s ngQuantityOnHand
						return quantity.QuantityOnHand;
					}
				}
			}
			catch (Exception ex)
			{
				return 0;
			}

		}

		public static double GetQuantityPerUnit(int itemID)
		{

			//Returns units per case
			try
			{
				Items item = (Items)Session.DefaultSession.GetObjectByKey<Items>(itemID, true);
				return item.intQtyPerUnit;
			}
			catch (Exception ex)
			{
				return 0;
			}

		}

		public int GetUnits(int itemID)
		{

			//Returns units per case
			try
			{
				return Adapter.GetUnits(itemID).Value;
			}
			catch (Exception ex)
			{
				return 0;
			}

		}

		public static string GetUOMByItemID(int? itemID)
		{

			if (!itemID.HasValue)
			{
				return null;
			}

			try
			{
				Items item = (Items)Session.DefaultSession.GetObjectByKey<Items>(itemID.Value, true);
				return item.strUnitOfMeasure;
			}
			catch (Exception ex)
			{
				return null;
			}

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
		private bool InsertProduct(int itemID, string itemCode, string itemDescription, string itemType, int? itemCustomerID, int? itemDefaultMachine, double? itemProdStandard, double? dblPrice, float? sngRebate, string strUnitOfMeasure, double? intQtyPerUnit, double? dblFreight, double? dblFilm, double? dblBoxes, double? dblPallets, double? dblStretchWrap, double? dblOther1, double? dblOther2, double? dblOther3, double? dblOther4, double? dblOther5, double? intUnitsPerCase, int? intUnitsPerPallet, int? intCasesPerPallet, float? sngQtyOnHand, double? CaseGrossWeight, string PackageCode, string CaseCode, string RequiredWeight, string MAV, string CasesPerLayer, string LayersPerPallet, string ShelfLife, string Instructions, string PalletPattern, bool inactive, double? packers, string upc, int? bagsPerCase, bool? RequiresLotCode, bool? RequiresExpirationDate, bool? GenerateLotCodes, int? DefaultLotCodeFormat, double? MinutesPerShift, string AllergenInfo, Session dxSession)
		{

			//Dim products As SPG.ItemsDataTable = New SPG.ItemsDataTable
			//Dim product As SPG.ItemsRow = products.NewItemsRow()

			//product.ItemID = itemID
			Items product = new Items(dxSession) {ItemID = itemID};
			SetProductFields(itemCode, itemDescription, itemType, itemCustomerID, itemDefaultMachine, itemProdStandard, dblPrice, sngRebate, strUnitOfMeasure, intQtyPerUnit, dblFreight, dblFilm, dblBoxes, dblStretchWrap, dblPallets, dblOther1, dblOther2, dblOther3, dblOther4, dblOther5, intUnitsPerCase, intUnitsPerPallet, intCasesPerPallet, sngQtyOnHand, CaseGrossWeight, PackageCode, CaseCode, RequiredWeight, MAV, CasesPerLayer, LayersPerPallet, ShelfLife, Instructions, PalletPattern, inactive, packers, upc, bagsPerCase, RequiresLotCode, RequiresExpirationDate, GenerateLotCodes, DefaultLotCodeFormat, MinutesPerShift, AllergenInfo, product, dxSession);
			product.strEnteredBy = Properties.Settings.Default.UserName;
			product.dtmEnteredOn = DateTime.Now;

			//products.AddItemsRow(product)
			//Dim rowsAffected As Integer = Adapter.Update(products)

			//Return rowsAffected = 1

			try
			{
				product.Save();
			}
			catch (Exception ex)
			{
				return false;
			}

			return true;

		}

		private void SetField(string propertyName, object oldValue, object newValue, Items product)
		{

			if ((oldValue != null || newValue != null) && ((oldValue != null && newValue == null) || (newValue != null && oldValue == null) || oldValue.ToString() != newValue.ToString()))
			{
				product.SetMemberValue(propertyName, newValue);
				Change change = new Change()
				{
					PropertyName = propertyName,
					PrevValue = ((oldValue == null) ? "<NULL>" : oldValue.ToString()),
					NewValue = ((newValue == null) ? "<NULL>" : newValue.ToString())
				};
				changes.Add(change);
			}

		}

		private void SetProductFields(string itemCode, string itemDescription, string itemType, int? itemCustomerID, int? itemDefaultMachine, double? itemProdStandard, double? dblPrice, float? sngRebate, string strUnitOfMeasure, double? intQtyPerUnit, double? dblFreight, double? dblFilm, double? dblBoxes, double? dblStretchWrap, double? dblPallets, double? dblOther1, double? dblOther2, double? dblOther3, double? dblOther4, double? dblOther5, double? intUnitsPerCase, int? intUnitsPerPallet, int? intCasesPerPallet, float? sngQtyOnHand, double? CaseGrossWeight, string PackageCode, string CaseCode, string RequiredWeight, string MAV, string CasesPerLayer, string LayersPerPallet, string ShelfLife, string Instructions, string PalletPattern, bool inactive, double? packers, string upc, int? bagsPerCase, bool? RequiresLotCode, bool? RequiresExpirationDate, bool? GenerateLotCodes, int? DefaultLotCodeFormat, double? MinutesPerShift, string AllergenInfo, Items product, Session dxSession)
		{

			SetField(Items.Fields.ItemCode.PropertyName, product.ItemCode, itemCode, product);
			SetField(Items.Fields.ItemDescription.PropertyName, product.ItemDescription, (string.IsNullOrEmpty(itemDescription) ? null : itemDescription), product);
			SetField(Items.Fields.ItemType.PropertyName, product.ItemType, itemType, product);
			SetField(Items.Fields.ItemCustomerID.PropertyName, product.ItemCustomerID, (itemCustomerID.HasValue ? dxSession.GetObjectByKey<Customers>(itemCustomerID) : null), product);
			SetField(Items.Fields.ItemDefaultMachine.PropertyName, product.ItemDefaultMachine, (itemDefaultMachine.HasValue ? dxSession.GetObjectByKey<MachineLine>(itemDefaultMachine.Value) : null), product);
			SetField(Items.Fields.ItemProdStandard.PropertyName, product.ItemProdStandard, (itemProdStandard.HasValue ? itemProdStandard : null), product);
			SetField(Items.Fields.dblPrice.PropertyName, product.dblPrice, (dblPrice.HasValue ? dblPrice : null), product);
			SetField(Items.Fields.sngRebate.PropertyName, product.sngRebate, (sngRebate.HasValue ? sngRebate : null), product);
			SetField(Items.Fields.strUnitOfMeasure.PropertyName, product.strUnitOfMeasure, (string.IsNullOrEmpty(strUnitOfMeasure) ? null : strUnitOfMeasure), product);
			SetField(Items.Fields.intQtyPerUnit.PropertyName, product.intQtyPerUnit, (intQtyPerUnit.HasValue ? intQtyPerUnit : null), product);
			SetField(Items.Fields.dblFreight.PropertyName, product.dblFreight, (dblFreight.HasValue ? dblFreight : null), product);
			SetField(Items.Fields.dblFilm.PropertyName, product.dblFilm, (dblFilm.HasValue ? dblFilm : null), product);
			SetField(Items.Fields.dblBoxes.PropertyName, product.dblBoxes, (dblBoxes.HasValue ? dblBoxes : null), product);
			SetField(Items.Fields.dblStretchWrap.PropertyName, product.dblStretchWrap, (dblStretchWrap.HasValue ? dblStretchWrap : null), product);
			SetField(Items.Fields.dblPallets.PropertyName, product.dblPallets, (dblPallets.HasValue ? dblPallets : null), product);
			SetField(Items.Fields.dblOther1.PropertyName, product.dblOther1, (dblOther1.HasValue ? dblOther1 : null), product);
			SetField(Items.Fields.dblOther2.PropertyName, product.dblOther2, (dblOther2.HasValue ? dblOther2 : null), product);
			SetField(Items.Fields.dblOther3.PropertyName, product.dblOther3, (dblOther3.HasValue ? dblOther3 : null), product);
			SetField(Items.Fields.dblOther4.PropertyName, product.dblOther4, (dblOther4.HasValue ? dblOther4 : null), product);
			SetField(Items.Fields.dblOther5.PropertyName, product.dblOther5, (dblOther5.HasValue ? dblOther5 : null), product);
			SetField(Items.Fields.intUnitsPerCase.PropertyName, product.intUnitsPerCase, (intUnitsPerCase.HasValue ? intUnitsPerCase : null), product);
			SetField(Items.Fields.intUnitsPerPallet.PropertyName, product.intUnitsPerPallet, (intUnitsPerPallet.HasValue ? intUnitsPerPallet : null), product);
			SetField(Items.Fields.intCasesPerPallet.PropertyName, product.intCasesPerPallet, (intCasesPerPallet.HasValue ? intCasesPerPallet : null), product);
			SetField(Items.Fields.BagsPerCase.PropertyName, product.BagsPerCase, (bagsPerCase.HasValue ? bagsPerCase : null), product);
			SetField(Items.Fields.CaseGrossWeight.PropertyName, product.CaseGrossWeight, (CaseGrossWeight.HasValue ? CaseGrossWeight : null), product);
			SetField(Items.Fields.PackageCode.PropertyName, product.PackageCode, (string.IsNullOrEmpty(PackageCode) ? null : PackageCode), product);
			SetField(Items.Fields.CaseCode.PropertyName, product.CaseCode, (string.IsNullOrEmpty(CaseCode) ? null : CaseCode), product);
			SetField(Items.Fields.RequiredWeight.PropertyName, product.RequiredWeight, (string.IsNullOrEmpty(RequiredWeight) ? null : RequiredWeight), product);
			SetField(Items.Fields.MAV.PropertyName, product.MAV, (string.IsNullOrEmpty(MAV) ? null : MAV), product);
			SetField(Items.Fields.CasesPerLayer.PropertyName, product.CasesPerLayer, (string.IsNullOrEmpty(CasesPerLayer) ? null : CasesPerLayer), product);
			SetField(Items.Fields.LayersPerPallet.PropertyName, product.LayersPerPallet, (string.IsNullOrEmpty(LayersPerPallet) ? null : LayersPerPallet), product);
			SetField(Items.Fields.ShelfLife.PropertyName, product.ShelfLife, (string.IsNullOrEmpty(ShelfLife) ? null : ShelfLife), product);
			SetField(Items.Fields.Instructions.PropertyName, product.Instructions, (string.IsNullOrEmpty(Instructions) ? null : Instructions), product);
			SetField(Items.Fields.PalletPattern.PropertyName, product.PalletPattern, (string.IsNullOrEmpty(PalletPattern) ? null : PalletPattern), product);
			SetField(Items.Fields.Inactive.PropertyName, product.Inactive, inactive, product);
			SetField(Items.Fields.Packers.PropertyName, product.Packers, (packers.HasValue ? packers : null), product);
			SetField(Items.Fields.UPC.PropertyName, product.UPC, (string.IsNullOrEmpty(upc) ? null : upc), product);
			SetField(Items.Fields.RequiresLotCodes.PropertyName, product.RequiresLotCodes, (RequiresLotCode.HasValue ? RequiresLotCode : null), product);
			SetField(Items.Fields.RequiresExpirationDates.PropertyName, product.RequiresExpirationDates, (RequiresExpirationDate.HasValue ? RequiresExpirationDate : null), product);
			SetField(Items.Fields.GenerateLotCodes.PropertyName, product.GenerateLotCodes, (GenerateLotCodes.HasValue ? GenerateLotCodes : null), product);
			SetField(Items.Fields.DefaultLotCodeFormat.PropertyName, product.DefaultLotCodeFormat, (DefaultLotCodeFormat.HasValue ? dxSession.GetObjectByKey<LotCodeFormats>(DefaultLotCodeFormat.Value) : null), product);
			SetField(Items.Fields.MinutesPerShift.PropertyName, product.MinutesPerShift, (MinutesPerShift.HasValue ? MinutesPerShift : null), product);
			SetField(Items.Fields.Allergens.PropertyName, product.Allergens, (string.IsNullOrEmpty(AllergenInfo) ? null : AllergenInfo), product);

		}

		//Private Shared Sub UpdateAuditTrail(ByVal ModifiedRecord As SPG.ItemsRow, ByVal originalRecord As Object())

		//    Dim builder As New StringBuilder(String.Empty)
		//    Dim recordFields As Integer = (ModifiedRecord.ItemArray.Length - 1)
		//    Dim i As Integer = 0
		//    Do While (i <= recordFields)
		//        Try
		//            If IsDBNull(originalRecord(i)) Then
		//                If Not IsDBNull(ModifiedRecord.Item(i)) Then
		//                    builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, "NULL", ModifiedRecord.Item(i)))
		//                End If
		//            ElseIf Information.IsDBNull(ModifiedRecord.Item(i)) Then
		//                If Not Information.IsDBNull(originalRecord(i)) Then
		//                    builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, originalRecord(i), "NULL"))
		//                End If
		//            ElseIf ModifiedRecord.Item(i) IsNot originalRecord(i) Then
		//                builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, originalRecord(i), ModifiedRecord.Item(i)))
		//            End If
		//        Catch
		//        End Try
		//        i += 1
		//    Loop
		//    If (builder.Length > 2) Then
		//        builder.Length = (builder.Length - 2)
		//        AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(ModifiedRecord.Item(0), Integer), "Items", builder.ToString)
		//    End If

		//End Sub

		private void UpdateAuditTrail()
		{

			StringBuilder builder = new StringBuilder(string.Empty);

			foreach (Change update in changes)
			{
				builder.Append(string.Format("{0}:{1}({2}); ", update.PropertyName, update.PrevValue, update.NewValue));
			}

			if (builder.Length > 2)
			{
				builder.Length = (builder.Length - 2);
				AuditTrailBLL.AddTrailEntry(Properties.Settings.Default.UserName, int.Parse(changes[0].NewValue), "Items", builder.ToString());
			}

			changes.Clear();

		}


		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
		public bool UpdateProduct(int itemID, string itemCode, string itemDescription, string itemType, int? itemCustomerID, int? itemDefaultMachine, double? itemProdStandard, double? dblPrice, float? sngRebate, string strUnitOfMeasure, double? intQtyPerUnit, double? dblFreight, double? dblFilm, double? dblBoxes, double? dblStretchWrap, double? dblPallets, double? dblOther1, double? dblOther2, double? dblOther3, double? dblOther4, double? dblOther5, double? intUnitsPerCase, int? intUnitsPerPallet, int? intCasesPerPallet, float? sngQtyOnHand, double? CaseGrossWeight, string PackageCode, string CaseCode, string RequiredWeight, string MAV, string CasesPerLayer, string LayersPerPallet, string ShelfLife, string Instructions, string PalletPattern, bool inactive, double? packers, string upc, int? bagsPerCase, bool? RequiresLotCode, bool? RequiresExpirationDate, bool? GenerateLotCodes, int? DefaultLotCodeFormat, double? MinutesPerSift, string AllergenInfo, Session dxSession)
		{

			StringBuilder str = new StringBuilder(string.Empty);
			if (string.IsNullOrEmpty(itemCode))
			{
				str.Append("Item Code, ");
			}
			if (string.IsNullOrEmpty(itemType))
			{
				str.Append("Item Type, ");
			}
			if (!itemCustomerID.HasValue)
			{
				str.Append("Customer name, ");
			}
			if (!DefaultLotCodeFormat.HasValue && RequiresLotCode.HasValue == true && RequiresLotCode == true && itemCustomerID.HasValue && dxSession.GetObjectByKey<Customers>(itemCustomerID.Value).DefaultLotCodeFormat == null)
			{
				str.Append("Default Lot Code Format, ");
			}

			if (str.Length > 0)
			{
				throw new ApplicationException(string.Format("You must provide a {0}.", str.ToString().Substring(0, (str.Length - 2))));
			}

			if (!string.IsNullOrEmpty(upc))
			{
				CriteriaOperatorCollection theCriteria = new CriteriaOperatorCollection();
				theCriteria.Add(new BinaryOperator(Items.Fields.UPC.PropertyName, upc, BinaryOperatorType.Equal));
				theCriteria.Add(new BinaryOperator(Items.Fields.ItemID.PropertyName, itemID, BinaryOperatorType.NotEqual));

				if (dxSession.GetObjects(dxSession.GetClassInfo<Items>(), new GroupOperator(GroupOperatorType.And, theCriteria), null, 1, false, true).Count > 0)
				{
					throw new ApplicationException("UPC must be unique.");
				}
			}

			//Dim products As SPG.ItemsDataTable = Adapter.GetItemByID(itemID)

			//If products.Count = 0 Then
			Change change = new Change();
			Items product = dxSession.GetObjectByKey<Items>(itemID);

			if (product == null)
			{
				//It is a new Customer
				change = new Change()
				{
					PropertyName = Items.Fields.ItemID.PropertyName,
					PrevValue = "<NULL>",
					NewValue = itemID.ToString()
				};
				changes.Add(change);
				//It is a new Product
				return InsertProduct(itemID, itemCode, itemDescription, itemType, itemCustomerID, itemDefaultMachine, itemProdStandard, dblPrice, sngRebate, strUnitOfMeasure, intQtyPerUnit, dblFreight, dblFilm, dblBoxes, dblStretchWrap, dblPallets, dblOther1, dblOther2, dblOther3, dblOther4, dblOther5, intUnitsPerCase, intUnitsPerPallet, intCasesPerPallet, sngQtyOnHand, CaseGrossWeight, PackageCode, CaseCode, RequiredWeight, MAV, CasesPerLayer, LayersPerPallet, ShelfLife, Instructions, PalletPattern, inactive, packers, upc, bagsPerCase, RequiresLotCode, RequiresExpirationDate, GenerateLotCodes, DefaultLotCodeFormat, MinutesPerSift, AllergenInfo, dxSession);
			}

			//Dim product As SPG.ItemsRow = products(0)

			//Dim originalRecord As Object() = Nothing
			//originalRecord = product.ItemArray

			change = new Change()
			{
				PropertyName = Items.Fields.ItemID.PropertyName,
				PrevValue = product.ItemID.ToString(),
				NewValue = product.ItemID.ToString()
			};
			changes.Add(change);

			SetProductFields(itemCode, itemDescription, itemType, itemCustomerID, itemDefaultMachine, itemProdStandard, dblPrice, sngRebate, strUnitOfMeasure, intQtyPerUnit, dblFreight, dblFilm, dblBoxes, dblStretchWrap, dblPallets, dblOther1, dblOther2, dblOther3, dblOther4, dblOther5, intUnitsPerCase, intUnitsPerPallet, intCasesPerPallet, sngQtyOnHand, CaseGrossWeight, PackageCode, CaseCode, RequiredWeight, MAV, CasesPerLayer, LayersPerPallet, ShelfLife, Instructions, PalletPattern, inactive, packers, upc, bagsPerCase, RequiresLotCode, RequiresExpirationDate, GenerateLotCodes, DefaultLotCodeFormat, MinutesPerSift, AllergenInfo, product, dxSession);

			try
			{
				product.Editing = false;
				product.Save();
			}
			catch (Exception ex)
			{
				return false;
			}

			//If Not IsNothing(originalRecord) Then
			//    ItemsBLL.UpdateAuditTrail(product, originalRecord)
			//End If

			//Dim rowsAffected As Integer = Adapter.Update(product)

			UpdateAuditTrail();

			//Return rowsAffected = 1

			return true;

		}

		public void UpdateStock(Session session, int itemID, int? inventoryID, float quantity, bool updateBOM, int locationID, string lot = "", int? LPNNumber = null, DateTime? ExpirationDate = null)
		{

			double scrapfactor = 0;
			//To do update the stock for the item and bom's associated with it
			if (updateBOM == true)
			{
				if (inventoryID.HasValue)
				{
					//Dim inventoryBOMs As InventoryBOMsBLL = New InventoryBOMsBLL
					//Dim inventoryItemBOM As SPG.InventoryBOMsDataTable = inventoryBOMs.GetInventoryBOMsBYInventoryID(inventoryID.Value)
					XPCollection<InventoryBOMs> inventoryItemBOM = InventoryBOMsBLL.GetInventoryBOMsByInventoryID(session, inventoryID.Value);
					//If inventoryItemBOM.Rows.Count <> 0 Then
					if (inventoryItemBOM.Count != 0)
					{
						//Dim itemsBOM As SPG.InventoryBOMsRow
						InventoryBOMs itemsBOM = null;
						for (int i = 0; i < inventoryItemBOM.Count; i++)
						{
							//itemsBOM = CType(inventoryItemBOM.Rows(i), SPG.InventoryBOMsRow)
							itemsBOM = inventoryItemBOM[i];
							if (itemsBOM.IsDeleted == false)
							{
								//updates the raw material
								if (itemsBOM.ScrapFactor > 0)
								{
									scrapfactor = itemsBOM.InventoryBOMQuantity * itemsBOM.ScrapFactor;
								}
								else
								{
									scrapfactor = 0;
								}
								UpdateStock(session, itemsBOM.InventoryBOMRawMatID.ItemID, (Convert.ToSingle(quantity * (itemsBOM.InventoryBOMQuantity + scrapfactor)) * -1), false, locationID);
							}
						}
						updateBOM = false;
					}
				}
			}

			if (updateBOM == true)
			{
				//The item has a bom attached to it
				BOMBLL boms = new BOMBLL();
				//Dim itemsBOMs As SPG.BOMDataTable = boms.GetBOMBYFGItemID(itemID)
				XPCollection<BOMs> itemsBOMs = BOMBLL.GetBOMByFGItemID(session, itemID);

				//If itemsBOMs.Rows.Count <> 0 Then
				if (itemsBOMs.Count != 0)
				{
					//Dim itemsBOM As SPG.BOMRow
					BOMs itemsBOM = null;
					//For i As Integer = 0 To itemsBOMs.Rows.Count - 1
					for (int i = 0; i < itemsBOMs.Count; i++)
					{
						//itemsBOM = CType(itemsBOMs.Rows(i), SPG.BOMRow)
						itemsBOM = itemsBOMs[i];
						//updates the raw material
						if (itemsBOM.BOMRawMatID.ItemID != itemID)
						{
							if (itemsBOM.ScrapFactor > 0)
							{
								scrapfactor = itemsBOM.BOMQuantity * (itemsBOM.ScrapFactor / 100);
							}
							else
							{
								scrapfactor = 0;
							}
							UpdateStock(session, itemsBOM.BOMRawMatID.ItemID, (Convert.ToSingle(quantity * (itemsBOM.BOMQuantity + scrapfactor)) * -1), false, locationID);
						}
					}
				}
			}

			LocationInventoryBLL.UpdateStock(session, itemID, locationID, quantity, lot, LPNNumber, ExpirationDate);

			//Dim item As SPG.ItemsRow = CType(GetItemBYId(itemID).Rows(0), SPG.ItemsRow)
			//item.s ngQuantityOnHand += quantity
			//Adapter.Update(item)

		}

		public void UpdateStock(Session session, int itemID, float quantity, bool updateBOM, int locationID, string lot = "", int? LPNNumber = null, DateTime? ExpirationDate = null)
		{

			UpdateStock(session, itemID, null, quantity, updateBOM, locationID, lot, LPNNumber, ExpirationDate);

		}





		//<System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
		//Public Function GetItemsSearch(ByVal inactive As Boolean) As SPG.ItemsDataTable

		//    If inactive Then
		//        Return Adapter.GetItemsSearch(Nothing)
		//    End If
		//    'will return only those that are active
		//    Return Adapter.GetItemsSearch(inactive)

		//End Function



























		//Public Function GetCustomerNameByItemID(ByVal itemID As Integer) As String

		//    Return Adapter.GetItemsCustomer(itemID).Rows(0)("CustomerName").ToString

		//End Function

















	}

}