//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using SuperiorPackGroup.SPGTableAdapters;
using System.Text;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DXDAL.SPGData;
using System.Collections.ObjectModel;
using System.Linq;

namespace SuperiorPackGroup
{
	[System.ComponentModel.DataObject()]
	public class InventoryBLL
	{

		private InventoryTableAdapter m_InventoryTableAdapter = null;
		private readonly List<Change> changes = new List<Change>();

		public InventoryTableAdapter Adapter
		{

			get
			{
				if (m_InventoryTableAdapter == null)
				{
					m_InventoryTableAdapter = new InventoryTableAdapter();
					m_InventoryTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return m_InventoryTableAdapter;
			}

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.InventoryDataTable GetInventoryView(DateTime? fromDate, DateTime? toDate, int? customer, int? item, string Lot)
		{

			return Adapter.GetInventoryView(fromDate, toDate, customer, item, Lot);

		}

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
				AuditTrailBLL.AddTrailEntry(Properties.Settings.Default.UserName, int.Parse(changes[0].NewValue), "Inventory", builder.ToString());
			}

			changes.Clear();

		}

		//Private Sub UpdateAuditTrail(ByVal ModifiedRecord As SPG.InventoryRow, ByVal originalRecord As Object())

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
		//        AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(ModifiedRecord.Item(0), Integer), "Inventory", builder.ToString)
		//    End If

		//End Sub

		public static int GetNewInventoryID()
		{

			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.UserConnectionString);
			System.Data.SqlClient.SqlCommand myCommand = new System.Data.SqlClient.SqlCommand("dbo.spNewIDSafe", conn);
			System.Data.SqlClient.SqlParameter myNewID = new System.Data.SqlClient.SqlParameter("@nRetVal", SqlDbType.Int);
			myCommand.CommandType = CommandType.StoredProcedure;
			myNewID.Direction = ParameterDirection.Output;
			myCommand.Parameters.AddWithValue("@cName", "tblInventory");
			myCommand.Parameters.AddWithValue("@cPkField", "InventoryID");
			myCommand.Parameters.Add(myNewID);

			conn.Open();
			myCommand.ExecuteNonQuery();

			return Convert.ToInt32(myNewID.Value);

		}

		private void SetField(string propertyName, object oldValue, object newValue, Inventory production)
		{

			if ((oldValue != null || newValue != null) && ((oldValue != null && newValue == null) || (newValue != null && oldValue == null) || oldValue.ToString() != newValue.ToString()))
			{
				production.SetMemberValue(propertyName, newValue);
				Change change = new Change()
				{
					PropertyName = propertyName,
					PrevValue = ((oldValue == null) ? "<NULL>" : oldValue.ToString()),
					NewValue = ((newValue == null) ? "<NULL>" : newValue.ToString())
				};
				changes.Add(change);
			}

		}

		private void SetInventoryFields(Session session, DateTime inventoryDate, int item, int quantity, float? pallets, string po, string lot, int? shift, int? pallet, DateTime? expirationDate, int locationID, string note, Inventory production)
		{

			SetField(Inventory.Fields.InventoryDate.PropertyName, production.InventoryDate, inventoryDate, production);
			SetField(Inventory.Fields.InventoryItemID.PropertyName, production.InventoryItemID, session.GetObjectByKey<Items>(item), production);
			SetField(Inventory.Fields.InventoryQuantity.PropertyName, production.InventoryQuantity, quantity, production);
			SetField(Inventory.Fields.InventoryPallets.PropertyName, production.InventoryPallets, pallets.Value, production);
			SetField(Inventory.Fields.PO.PropertyName, production.PO, po, production);
			SetField(Inventory.Fields.Lot.PropertyName, production.Lot, lot, production);
			SetField(Inventory.Fields.Shift.PropertyName, production.Shift, (shift.HasValue ? ((shift.Value > 0) ? session.GetObjectByKey<Shifts>(shift.Value) : null) : null), production);
			SetField(Inventory.Fields.Pallet.PropertyName, production.Pallet, (pallet.HasValue ? ((pallet.Value > 0) ? pallet : null) : null), production);
			SetField(Inventory.Fields.ExpirationDate.PropertyName, production.ExpirationDate, (expirationDate.HasValue ? expirationDate : null), production);
			SetField(Inventory.Fields.ProductionLocation.PropertyName, production.ProductionLocation, session.GetObjectByKey<Locations>(locationID), production);
			SetField(Inventory.Fields.Note.PropertyName, production.Note, note, production);

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
		public Inventory UpdateInventory(Session session, int inventoryID, DateTime inventoryDate, int item, int quantity, float? pallets, string po, string lot, int? shift, int? pallet, DateTime? expirationDate, int locationID, string note)
		{

			//Dim inventory As SPG.InventoryDataTable = Adapter.GetInventoryByID(inventoryID)

			//If inventory.Count = 0 Then
			Change change = new Change();
			Inventory production = session.GetObjectByKey<Inventory>(inventoryID);

			if (production == null)
			{
				//It is a new Production Record
				change = new Change()
				{
					PropertyName = Inventory.Fields.InventoryID.PropertyName,
					PrevValue = "<NULL>",
					NewValue = inventoryID.ToString()
				};
				changes.Add(change);
				return InsertInventory(session, inventoryID, inventoryDate, item, quantity, pallets, po, lot, shift, pallet, expirationDate, locationID, note);
			}

			//Dim inventoryRecord As SPG.InventoryRow = inventory(0)
			int originalQuantity = 0;
			int newQuantity = 0;
			bool itemChanged = false;

			//Dim originalRecord As Object() = inventoryRecord.ItemArray

			//inventoryRecord.InventoryDate = CDate(Format(inventoryDate, "D"))
			int originalItem = production.InventoryItemID.ItemID;
			if (originalItem != item)
			{
				itemChanged = true;
			}
			else
			{
				itemChanged = false;
			}
			//inventoryRecord.InventoryItemID = item
			originalQuantity = production.InventoryQuantity;
			newQuantity = production.InventoryQuantity - quantity;
			//inventoryRecord.InventoryQuantity = quantity
			//inventoryRecord.InventoryPallets = pallets.Value
			//inventoryRecord.PO = po
			//inventoryRecord.Lot = lot
			//If shift.HasValue AndAlso shift.Value > 0 Then
			//    inventoryRecord.Shift = shift.Value
			//Else
			//    inventoryRecord.SetShiftNull()
			//End If
			//If pallet.HasValue AndAlso pallet.Value > 0 Then
			//    inventoryRecord.Pallet = pallet.Value
			//Else
			//    inventoryRecord.SetPalletNull()
			//End If
			//If expirationDate.HasValue Then
			//    inventoryRecord.ExpirationDate = expirationDate.Value
			//Else
			//    inventoryRecord.SetExpirationDateNull()
			//End If

			change = new Change()
			{
				PropertyName = Inventory.Fields.InventoryID.PropertyName,
				PrevValue = production.InventoryID.ToString(),
				NewValue = production.InventoryID.ToString()
			};
			changes.Add(change);
			SetInventoryFields(session, inventoryDate, item, quantity, pallets, po, lot, shift, pallet, expirationDate, locationID, note, production);

			//If Not IsNothing(originalRecord) Then
			//    Me.UpdateAuditTrail(inventoryRecord, originalRecord)
			//End If

			try
			{
				production.Save();
			}
			catch (Exception ex)
			{
				return null;
			}

			UpdateAuditTrail();

			//Dim rowsAffected As Integer = Adapter.Update(inventoryRecord)

			//If rowsAffected = 1 Then
			ItemsBLL items = new ItemsBLL();
			//Dim inventoryBOM As InventoryBOMsBLL = New InventoryBOMsBLL
			if (itemChanged == true)
			{
				items.UpdateStock(session, originalItem, inventoryID, originalQuantity * -1, true, locationID);
				InventoryBOMsBLL.DeleteInventoryBOMByInventoryID(session, inventoryID);
				InventoryBOMsBLL.AddInventoryBOMByItemID(session, item, production);
				items.UpdateStock(session, item, quantity, true, locationID);
			}
			else
			{
				if (newQuantity != 0) //there was a change in the quantity
				{
					items.UpdateStock(session, item, inventoryID, newQuantity * -1, true, locationID);
				}
			}
			//End If

			//Return rowsAffected = 1
			return production;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
		public Inventory InsertInventory(Session session, int inventoryID, DateTime? inventoryDate, int? item, int? quantity, float? pallets, string po, string lot, int? shift, int? pallet, DateTime? expirationDate, int locationID, string note)
		{

			//Dim inventory As SPG.InventoryDataTable = New SPG.InventoryDataTable
			//Dim inventoryRecord As SPG.InventoryRow = inventory.NewInventoryRow()

			//inventoryRecord.InventoryID = inventoryID

			Inventory production = new Inventory(session)
			{
				InventoryID = inventoryID,
				InventoryItemID = session.GetObjectByKey<Items>(item.Value)
			};

			//inventoryRecord.InventoryDate = CDate(Format(inventoryDate, "D"))
			//inventoryRecord.InventoryItemID = item.Value
			//inventoryRecord.InventoryQuantity = quantity.Value
			//inventoryRecord.InventoryPallets = pallets.Value
			//inventoryRecord.PO = po
			//inventoryRecord.Lot = lot
			//If shift.HasValue AndAlso shift.Value > 0 Then
			//    inventoryRecord.Shift = shift.Value
			//Else
			//    inventoryRecord.SetShiftNull()
			//End If
			if (pallet.HasValue == false || pallet.Value <= 0)
			{
				//    inventoryRecord.Pallet = pallet.Value
				//Else
				pallet = GetNewPalletNumber(session, Convert.ToDateTime(inventoryDate), item.Value, shift.Value);
			}
			//If expirationDate.HasValue() Then
			//    inventoryRecord.ExpirationDate = expirationDate.Value
			//Else
			//    inventoryRecord.SetExpirationDateNull()
			//End If
			SetInventoryFields(session, inventoryDate.Value, item.Value, quantity.Value, pallets, po, lot, shift, pallet, expirationDate, locationID, note, production);
			production.strEnteredBy = Properties.Settings.Default.UserName;
			production.dtmEnteredOn = DateTime.Now;

			try
			{
				production.Save();
			}
			catch (Exception ex)
			{
				return null;
			}

			//inventory.AddInventoryRow(inventoryRecord)
			//Dim rowsAffected As Integer = Adapter.Update(inventory)

			//If rowsAffected = 1 Then
			ItemsBLL items = new ItemsBLL();
			items.UpdateStock(session, item.Value, quantity.Value, true, locationID);
			InventoryBOMsBLL inventoryBOM = new InventoryBOMsBLL();
			InventoryBOMsBLL.AddInventoryBOMByItemID(session, item.Value, production);
			//End If

			//Return rowsAffected = 1

			return production;

		}

		public static Inventory GetInventoryRecord(Session session, int inventoryID, bool getFromDB = false)
		{

			return session.GetObjectByKey<Inventory>(inventoryID, getFromDB);

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.InventoryDataTable GetInventoryByID(int inventoryID)
		{

			return Adapter.GetInventoryByID(inventoryID);

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.InventoryDataTable GetInventoryByItemID(int itemID)
		{

			return Adapter.GetInventoryByItemID(itemID);

		}

		private static void DeleteInventoryConsumption(Inventory productionRecord, Session inventorySession)
		{

			BomConsumption consumption = null;
			LocationInventory inventoryOnHand = null;

			using (XPCollection<BomConsumption> consumptions = productionRecord.InventoryConsumption)
			{
				for (int i = consumptions.Count - 1; i >= 0; i--)
				{
					consumption = consumptions[i];
					inventoryOnHand = inventorySession.FindObject<LocationInventory>(new BinaryOperator(LocationInventory.Fields.LocationInventoryItem.ItemID.PropertyName, consumption.RawMatID.ItemID, BinaryOperatorType.Equal) & new BinaryOperator(LocationInventory.Fields.Location.Oid, UsersBLL.GetUsersLocalLocation(inventorySession, Properties.Settings.Default.UserName).Oid, BinaryOperatorType.Equal));
					inventoryOnHand.QuantityOnHand += (float)(consumption.QuantityUsed + consumption.ScrapFactorUsed);
					inventoryOnHand.Save();
					consumption.Delete();
				}
			}

		}

		private static void DeleteProductionProjectDetails(Session session, Inventory productionRecord)
		{

			//Using ProjectDetails As XPCollection(Of ProductionProjectDetails) = productionRecord.ProductionProject
			//    For i As Integer = ProjectDetails.Count - 1 To 0 Step -1
			//        ProjectDetails(i).Delete()
			//    Next i
			//End Using

			session.Delete(productionRecord.ProductionProject);

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
		public static bool DeleteInventory(Session session, int id)
		{

			//Dim inventory As SPG.InventoryDataTable = Adapter.GetInventoryByID(id)
			//Dim rowsAffected As Integer = 0
			//Dim inventorySession As Session = session
			session.DropIdentityMap();

			int item = 0;
			int quantity = 0;
			int locationID = 0;
			Inventory production = session.GetObjectByKey<Inventory>(id);

			//If inventory.Count = 1 Then
			if (production == null)
			{
				return false;
			}
			else if (production.Shipment != null)
			{
				MessageBox.Show("The selected record can't be deleted, it was already shipped.");
				return true;
			}

			//Dim inventoryRecord As SPG.InventoryRow = CType(Inventory.Rows(0), SPG.InventoryRow)
			InventoryBOMsBLL inventoryBOM = new InventoryBOMsBLL();
			item = production.InventoryItemID.ItemID;
			quantity = production.InventoryQuantity;
			locationID = production.ProductionLocation.Oid;
			InventoryBOMsBLL.DeleteInventoryBOMByInventoryID(session, id);
			DeleteInventoryConsumption(production, session);
			DeleteProductionProjectDetails(session, production);
			//rowsAffected = Adapter.Delete(id, inventoryRecord.ts)
			try
			{
				production.Delete();

				//If rowsAffected = 1 Then
				//If production.IsDeleted Then
				ItemsBLL items = new ItemsBLL();
				items.UpdateStock(session, item, quantity * -1, true, locationID);
				//End If

				//Return true if precisely one row was deleted, otherwise return false.
				//Return rowsAffected = 1

				//Return production.IsDeleted
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}

		}

		public static int GetNewPalletNumber(Session session, DateTime inventoryDate, int itemID, int? shift)
		{

			int? value = null;

			CriteriaOperatorCollection filter = new CriteriaOperatorCollection();
			filter.Add(new BinaryOperator("InventoryDate", inventoryDate.Date, BinaryOperatorType.GreaterOrEqual));
			filter.Add(new BinaryOperator("InventoryDate", inventoryDate.Date.AddDays(1), BinaryOperatorType.Less));
			filter.Add(new BinaryOperator("InventoryItemID", itemID, BinaryOperatorType.Equal));
			if (shift.HasValue)
			{
				filter.Add(new BinaryOperator("Shift", (object)shift, BinaryOperatorType.Equal));
			}
			else
			{
				return 1;
			}


			value = (int?)session.Evaluate<Inventory>(new AggregateOperand("", "Pallet", Aggregate.Max), new GroupOperator(GroupOperatorType.And, filter));

			if (value.HasValue)
			{
				return value.Value + 1;
			}
			else
			{
				return 1;
			}

		}

		public static int? GetLPNQuantity(Session session, int LPNNumber, int customerID, DateTime inventoryDate, Inventory currentRecord)
		{

			CriteriaOperatorCollection filter = new CriteriaOperatorCollection();
			filter.Add(new BinaryOperator("InventoryDate", inventoryDate, BinaryOperatorType.Equal));
			filter.Add(new BinaryOperator(Inventory.Fields.InventoryItemID.ItemCustomerID.CustomerID.PropertyName, customerID, BinaryOperatorType.Equal));
			filter.Add(new BinaryOperator("LPNNumber", LPNNumber, BinaryOperatorType.Equal));
			filter.Add(new BinaryOperator(Inventory.Fields.InventoryID.PropertyName, currentRecord.InventoryID, BinaryOperatorType.NotEqual));

			int? LPNQuantity = (int?)session.Evaluate<Inventory>(new AggregateOperand("", "InventoryQuantity", Aggregate.Sum), new GroupOperator(GroupOperatorType.And, filter));

			if (LPNQuantity.HasValue)
			{
				LPNQuantity += currentRecord.InventoryQuantity;
			}
			else
			{
				LPNQuantity = currentRecord.InventoryQuantity;
			}


			if (LPNQuantity.HasValue)
			{
				return LPNQuantity.Value;
			}
			else
			{
				return 0;
			}

		}

		public static bool IsMultiLPN(Session session, int LPNNumber, int customerID, DateTime inventoryDate)
		{

			CriteriaOperatorCollection filter = new CriteriaOperatorCollection();
			filter.Add(new BinaryOperator("InventoryDate", inventoryDate, BinaryOperatorType.Equal));
			filter.Add(new BinaryOperator(Inventory.Fields.InventoryItemID.ItemCustomerID.CustomerID.PropertyName, customerID, BinaryOperatorType.Equal));
			filter.Add(new BinaryOperator("LPNNumber", LPNNumber, BinaryOperatorType.Equal));

			int? LPNCount = (int?)session.Evaluate<Inventory>(new AggregateOperand("", "InventoryQuantity", Aggregate.Count), new GroupOperator(GroupOperatorType.And, filter));

			if (LPNCount.HasValue && LPNCount.Value > 1)
			{
				return true;
			}
			else
			{
				return false;
			}

		}

		public static XPCollection<Inventory> GetLPNInventoryRecords(Session session, int LPNNumber, int customerID, DateTime inventoryDate)
		{

			return new XPCollection<Inventory>(session, new BinaryOperator("InventoryDate", inventoryDate, BinaryOperatorType.Equal) & new BinaryOperator(Inventory.Fields.InventoryItemID.ItemCustomerID.CustomerID.PropertyName, customerID, BinaryOperatorType.Equal) & new BinaryOperator("LPNNumber", LPNNumber, BinaryOperatorType.Equal));

		}

		public static ICollection<Inventory> GetLPNInventoryRecords(Session session, string fullLPNNumber, int customerID)
		{

			//Dim LPNNumber As Integer = Integer.Parse(fullLPNNumber.Replace(CustomersBLL.GetLPNPrefix(customerID), ""))

			ICollection<Inventory> result = new Collection<Inventory>();
			result = new XPCollection<Inventory>(session, new BinaryOperator(Inventory.Fields.InventoryItemID.ItemCustomerID.CustomerID.PropertyName, customerID, BinaryOperatorType.Equal) & new BinaryOperator("FullLPNNumber", fullLPNNumber, BinaryOperatorType.Equal));

			if (result.Count() == 0 && !fullLPNNumber.StartsWith(CustomersBLL.GetLPNPrefix(7)))
			{
				//If customerID = 7 Then
				//    Dim locationInventorys As XPCollection(Of LocationInventoryByLot) = New XPCollection(Of LocationInventoryByLot)(session,
				//                                                          New BinaryOperator(LocationInventoryByLot.Fields.LPNNumber.PropertyName, Integer.Parse(fullLPNNumber.Replace(CustomersBLL.GetLPNPrefix(customerID), "")), BinaryOperatorType.Equal))
				//    If locationInventorys.Count < 1 Then Return result
				//    Dim locationInventory As LocationInventoryByLot = locationInventorys(0)
				//    Dim convertToInventory As Inventory = New Inventory(session) With {.InventoryItemID = locationInventory.LocationInventoryItem, .InventoryQuantity = CInt(locationInventory.QuantityOnHand),
				//                                                                .Lot = locationInventory.LocationInventoryLot, .FullLPNNumber = fullLPNNumber, .ExpirationDate = locationInventory.ExpirationDate}
				//    result = New Collection(Of Inventory)
				//    result.Add(convertToInventory)
				//Else
				result = new XPCollection<Inventory>(session, new BinaryOperator(Inventory.Fields.InventoryItemID.ItemCustomerID.CustomerID.PropertyName, customerID, BinaryOperatorType.Equal) & new BinaryOperator("LPNNumber", int.Parse(fullLPNNumber.Replace(CustomersBLL.GetLPNPrefix(customerID), "")), BinaryOperatorType.Equal));
				//End If
			}

			return result;

		}

	}

}