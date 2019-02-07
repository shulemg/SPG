//INSTANT C# NOTE: Formerly VB project-level imports:
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;

using System;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraPrinting;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using DXDAL.SPGData;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;

namespace SuperiorPackGroup
{
	public partial class ItemsXtraForm
	{

		public ItemsXtraForm()
		{
			InitializeComponent();
		}

		protected ItemsBLL m_Items;
		protected CustomersBLL m_CustomerItems;
		protected MachinesLinesBLL m_MachineLines;
		protected ShippingDetailsBLL m_ShippingDetail;
		protected InventoryBLL m_Inventory;
		protected BOMBLL m_BOM;
		private UserPermissionsBLL m_UserPermissions;
		protected ArrayList m_UOMs;
		private string m_GridReportTitle;
		private int? m_CurrentItemID;
		private Session m_ItemsSession;

		private void ItemsXtraForm_FormClosing(object sender, FormClosingEventArgs e)
		{

			if (itemsSearchGridControl.Enabled == false)
			{
				switch (MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
				{
					case DialogResult.Yes:
						if (SaveChanges() == false)
						{
							e.Cancel = true;
						}
						break;
					case DialogResult.No:
						CancelChanges();
						break;
					case DialogResult.Cancel:
						e.Cancel = true;
						break;
				}
			}

		}

		private void ItemsXtraForm_Load(object sender, EventArgs e)
		{

			Cursor = Cursors.WaitCursor;
			m_Items = new ItemsBLL();
			m_CustomerItems = new CustomersBLL();
			m_MachineLines = new MachinesLinesBLL();
			m_ShippingDetail = new ShippingDetailsBLL();
			m_Inventory = new InventoryBLL();
			m_UserPermissions = new UserPermissionsBLL();

			m_ItemsSession = new Session(MyDataLayers.SPGDataLayer)
			{
				TrackPropertiesModifications = true,
				OptimisticLockingReadBehavior = OptimisticLockingReadBehavior.MergeCollisionThrowException
			};

			CheckPermissions();

			for (int i = 0; i < components.Components.Count; i++)
			{
				if ((components.Components[i]) is XPView)
				{
					((XPView)components.Components[i]).Session = m_ItemsSession;
				}
				else if ((components.Components[i]) is XPCollection)
				{
					((XPCollection)components.Components[i]).Session = m_ItemsSession;
				}
			}

			BindItemsSearch();
			XPBaseObject.AutoSaveOnEndEdit = false;

			LookUpColumnInfo customerNameColumn = new LookUpColumnInfo()
			{
				Caption = "Customer Name",
				FieldName = "CustomerName"
			};
			DataTable customerNameAndIDs = m_CustomerItems.GetCustomerNameAndIDS(false);

			customerFilterLookUpEdit.Properties.DataSource = customerNameAndIDs;
			customerFilterLookUpEdit.Properties.Columns.Add(customerNameColumn);
			customerFilterLookUpEdit.Properties.DisplayMember = "CustomerName";
			customerFilterLookUpEdit.Properties.ValueMember = "CustomerID";

			customerLookUpEdit.Properties.DataSource = customerNameAndIDs;
			customerLookUpEdit.Properties.Columns.Add(customerNameColumn);
			customerLookUpEdit.Properties.DisplayMember = "CustomerName";
			customerLookUpEdit.Properties.ValueMember = "CustomerID";

			DataTable itemTypes = ItemsBLL.GetItemTypes();

			typeLookUpEdit.Properties.DataSource = itemTypes;
			this.typeLookUpEdit.Properties.DisplayMember = "Description";
			this.typeLookUpEdit.Properties.ValueMember = "Type";

			this.typeFilterLookUpEdit.Properties.DataSource = itemTypes;
			this.typeFilterLookUpEdit.Properties.DisplayMember = "Description";
			this.typeFilterLookUpEdit.Properties.ValueMember = "Type";

			this.uomLookUpEdit.Properties.DataSource = m_Items.GetItemUOMs();
			this.uomLookUpEdit.Properties.ShowHeader = false;

			//Me.defaultMachineLookUpEdit.Properties.DataSource = m_MachineLines.GetMachineLines
			//Me.defaultMachineLookUpEdit.Properties.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo)
			//Me.defaultMachineLookUpEdit.Properties.Columns(0).FieldName = "MachineLineName"
			//Me.defaultMachineLookUpEdit.Properties.Columns(0).Caption = "Machine Line"
			//Me.defaultMachineLookUpEdit.Properties.DisplayMember = "MachineLineName"
			//Me.defaultMachineLookUpEdit.Properties.ValueMember = "MachineLineID"

			this.RMRepositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo());
			this.RMRepositoryItemLookUpEdit.Columns[0].FieldName = "ItemCode";
			this.RMRepositoryItemLookUpEdit.Columns[0].Caption = "Raw Material";
			this.RMRepositoryItemLookUpEdit.DisplayMember = "ItemCode";
			this.RMRepositoryItemLookUpEdit.ValueMember = "ItemID";

			this.shippingDetailIDGridColumn.FieldName = "ShipDetDetID";
			this.shippingIDGridColumn.FieldName = "ShipDetMainID";
			this.shippingLotGridColumn.FieldName = "ShipDetLot";
			shippingExpirationDateGridColumn.FieldName = "ExpirationDate";
			this.shippingQuantityGridColumn.FieldName = "ShipDetDetQty";
			this.shippingBOLGridColumn.FieldName = "ShipMainBOL";
			this.shippingDateGridColumn.FieldName = "ShipMainDate";

			shippingReturnIDGridColumn.FieldName = "ReturnDetID";
			returnShippingIDGridColumn.FieldName = "ShipMainID";
			shippingReturnLotGridColumn.FieldName = "ReturnDetLot";
			shippingReturnExpirationDateGridColumn.FieldName = "ExpirationDate";
			shippingReturnQuantityGridColumn.FieldName = "intUnits";
			shippingReturnBOLGridColumn.FieldName = "ShipMainBOL";
			shippingReturnDateGridColumn.FieldName = "ShipMainDate";

			this.productionDateGridColumn.FieldName = "InventoryDate";
			this.productionQuantityGridColumn.FieldName = "InventoryQuantity";
			this.productionLotGridColumn.FieldName = "Lot";
			productionExpirationDateGridColumn.FieldName = "ExpirationDate";
			this.productionPOGridColumn.FieldName = "PO";

			this.receivingDetailIDGridColumn.FieldName = "ReceiveDetID";
			this.receivingIDGridColumn.FieldName = "ReceiveMainID";
			this.receivingLpnGridColumn.FieldName = "ReceiveDetLPN";
			this.receivingLotGridColumn.FieldName = "ReceiveDetLot";
			receivingExpirationDateGridColumn.FieldName = "ExpirationDate";
			this.receivingQuantityGridColumn.FieldName = "ReceiveDetQty";
			this.receivingBOLGridColumn.FieldName = "ReceiveBOL";
			this.receivingDateGridColumn.FieldName = "ReceiveDate";

			receivingReturnIDGridColumn.FieldName = "ReceiveDetID";
			returnReceivingIDGridColumn.FieldName = "ReceiveMainID";
			receivingReturnLpnGridColumn.FieldName = "ReceiveDetLPN";
			receivingReturnLotGridColumn.FieldName = "ReceiveDetLot";
			receivingReturnExpirationDateGridColumn.FieldName = "ExpirationDate";
			receivingReturnQuantityGridColumn.FieldName = "ReceiveDetQty";
			receivingReturnBolGridColumn.FieldName = "ReceiveBOL";
			receivingReturnDateGridColumn.FieldName = "ReceiveDate";

			this.bomIDGridColumn.FieldName = "BOMID";
			this.FGItemCodeGridColumn.FieldName = "BOMFiniGoodID";
			this.RMItemCodeGridColumn.FieldName = "BOMRawMatID";
			this.RMQuantityGridColumn.FieldName = "BOMQuantity";
			this.scrapFactorGridColumn.FieldName = "ScrapFactor";

			this.availabilityItemIDGridColumn.FieldName = "BOMRawMatID";
			this.bomItemCodeGridColumn.FieldName = "ItemCode";
			this.bomItemDescriptionGridColumn.FieldName = "ItemDescription";
			this.quantityOnHandGridColumn.FieldName = "TotalQuantityOnHand";
			localQuantityOnHandGridColumn.FieldName = "LocalQuantityOnHand";
			this.quantityRequiredGridColumn.FieldName = "BOMQuantity";
			this.scrapPercentageGridColumn.FieldName = "ScrapFactor";
			//isPoolGridColumn.FieldName = "IsPool"

			adjustmentIDGridColumn.FieldName = "AdjustmentID";
			adjustmentDateGridColumn.FieldName = "AdjustmentDate";
			adjustmentOriginalQuantityGridColumn.FieldName = "OriginalQuantity";
			adjustmentNewQtyGridColumn.FieldName = "NewCount";
			adjustmentQuantityGridColumn.FieldName = "AdjustmentQuantity";
			adjustmentReasonGridColumn.FieldName = "Reason";

			poolBomXpCollection.Criteria = new BinaryOperator(PoolBom.Fields.PoolBomFiniGoodID.ItemID.PropertyName, 0, BinaryOperatorType.Equal);
			poolBomXpCollection.Reload();

			productionStandardsXpCollection.Criteria = new BinaryOperator(ItemMachineStandards.Fields.ProductionItem.ItemID.PropertyName, 0, BinaryOperatorType.Equal);
			productionStandardsXpCollection.Reload();

			inventoryXpView.Criteria = new BinaryOperator(LocationInventory.Fields.LocationInventoryItem.ItemID, 0, BinaryOperatorType.Equal);
			transfersXpView.Criteria = new BinaryOperator(LocationTransferDetails.Fields.TransferItem.ItemID.PropertyName, 0, BinaryOperatorType.Equal);

			Utilities.MakeFormReadOnly(this.generalXtraTabPage, true);
			Utilities.MakeFormReadOnly(this.advancedXtraTabPage, true);
			Utilities.MakeFormReadOnly(this.specificationXtraTabPage, true);
			this.BOMGridView.OptionsBehavior.Editable = false;
			poolBomGridView.OptionsBehavior.Editable = false;
			productionStandardsGridView.OptionsBehavior.Editable = false;
			this.itemsSearchGridControl.Enabled = true;

			this.printGridBarButtonItem.Enabled = false;
			cancelBarButtonItem.Enabled = false;
			saveBarButtonItem.Enabled = false;

			foreach (Allergen Allergen in AllergensBLL.GetAllergens(ref m_ItemsSession))
			{
				this.AllergenInfoCheckedComboBoxEdit.Properties.Items.Add(Allergen.AllergenName);
			}

			this.Cursor = Cursors.Default;


		}

		public void BindItemsSearch()
		{

			if (inactiveSearchCheckEdit.Checked == false)
			{
				itemSearchXPView.Filter = new BinaryOperator(Items.Fields.Inactive.PropertyName, false, BinaryOperatorType.Equal);
			}
			else
			{
				itemSearchXPView.Filter = null;
			}

			itemSearchXPView.Reload();
			//Me.itemsSearchGridControl.DataSource = m_Items.GetItemsSearch(inactiveSearchCheckEdit.Checked)

		}

		private BOMBLL BOM
		{
			get
			{
				if (m_BOM == null)
				{
					m_BOM = new BOMBLL();
				}
				return m_BOM;
			}
		}

		public void BindItemControls(int itemID)
		{

			m_ItemsSession.DropIdentityMap();

			//Dim item As SPG.ItemsRow = CType(m_Items.GetItemBYId(itemID).Rows(0), SPG.ItemsRow)
			Items item = m_ItemsSession.GetObjectByKey<Items>(itemID);
			m_CurrentItemID = item.ItemID;
			this.codeTextEdit.Text = item.ItemCode;
			this.customerLookUpEdit.EditValue = item.ItemCustomerID.CustomerID;
			this.customerLookUpEdit.Enabled = false;
			this.descriptionMemoEdit.Text = item.ItemDescription;
			this.typeLookUpEdit.EditValue = item.ItemType;
			this.typeLookUpEdit.Enabled = false;
			UpdateTypeSensitiveControls();
			this.standardProductionTextEdit.EditValue = item.ItemProdStandard;
			if (item.ItemDefaultMachine != null)
			{
				this.defaultMachineLookUpEdit.EditValue = item.ItemDefaultMachine.MachineLineID;
			}
			else
			{
				this.defaultMachineLookUpEdit.EditValue = null;
			}

			this.uomLookUpEdit.EditValue = item.strUnitOfMeasure;
			this.qtyOnHandTextEdit.EditValue = ItemsBLL.GetQtyOnHandByID(m_ItemsSession, m_CurrentItemID, 0);
			this.qtyPerUnitTextEdit.EditValue = item.intQtyPerUnit;
			if (this.unitsPerCaseTextEdit.Enabled == true)
			{
				this.unitsPerCaseTextEdit.EditValue = item.intUnitsPerCase;
			}
			if (this.unitsPerPalletTextEdit.Enabled == true)
			{
				this.unitsPerPalletTextEdit.EditValue = item.intUnitsPerPallet;
			}
			if (this.casesPerPalletTextEdit.Enabled == true)
			{
				this.casesPerPalletTextEdit.EditValue = item.intCasesPerPallet;
			}
			this.caseGrossWeightTextEdit.EditValue = item.CaseGrossWeight;
			this.inactiveCheckEdit.Checked = item.Inactive;
			this.packersTextEdit.EditValue = item.Packers.HasValue ? item.Packers : null;
			if (string.IsNullOrEmpty(item.UPC))
			{
				upcTextEdit.EditValue = null;
			}
			else
			{
				upcTextEdit.EditValue = item.UPC;
			}
			bagsPerCaseTextEdit.EditValue = item.BagsPerCase.HasValue ? item.BagsPerCase : null;
			lotCodeFormatLookUpEdit.EditValue = item.DefaultLotCodeFormat;
			requiresExpirationDateCheckEdit.Checked = item.RequiresExpirationDates.HasValue ? item.RequiresExpirationDates.Value : false;
			requiresLotCodeCheckEdit.Checked = item.RequiresLotCodes.HasValue ? item.RequiresLotCodes.Value : false;
			generateLotCodesCheckEdit.Checked = item.GenerateLotCodes.HasValue ? item.GenerateLotCodes.Value : false;
			minutesPerShiftTextEdit.EditValue = item.MinutesPerShift;

			shippingExpirationDateGridColumn.DisplayFormat.FormatString = CustomersBLL.GetExpirationDateFormat(item.ItemCustomerID.CustomerID);
			shippingReturnExpirationDateGridColumn.DisplayFormat.FormatString = CustomersBLL.GetExpirationDateFormat(item.ItemCustomerID.CustomerID);
			receivingExpirationDateGridColumn.DisplayFormat.FormatString = CustomersBLL.GetExpirationDateFormat(item.ItemCustomerID.CustomerID);
			receivingReturnExpirationDateGridColumn.DisplayFormat.FormatString = CustomersBLL.GetExpirationDateFormat(item.ItemCustomerID.CustomerID);
			productionExpirationDateGridColumn.DisplayFormat.FormatString = CustomersBLL.GetExpirationDateFormat(item.ItemCustomerID.CustomerID);
			colItemExpirationDate.DisplayFormat.FormatString = CustomersBLL.GetExpirationDateFormat(item.ItemCustomerID.CustomerID);

			this.shippingGridControl.DataSource = ShippingDetailsBLL.GetShippingDetailsByItemID(itemID);
			this.shippingReturnGridControl.DataSource = ShippingReturnDetailsBLL.GetShippingReturnDetailsViewByItemID(itemID);

			this.productionGridControl.DataSource = m_Inventory.GetInventoryByItemID(itemID);

			this.receivingsGridControl.DataSource = ReceivingDetailsBLL.GetReceivingDetailsByItemID(itemID);
			this.receivingReturnGridControl.DataSource = ReturnDetailsBLL.GetReceivingReturnDetailsByItemID(itemID);

			adjustmentGridControl.DataSource = InventoryAdjustmentBLL.GetAdjustmentsByItemID(itemID);

			//bind the BOM tab
			if ((this.customerLookUpEdit.EditValue == null ? null : Convert.ToString(this.customerLookUpEdit.EditValue)) == this.customerLookUpEdit.Properties.NullText)
			{
				this.RMRepositoryItemLookUpEdit.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(null, "RM|IG", true, m_ItemsSession);
				itemPoolsXpView.Criteria = null;
			}
			else
			{
				this.RMRepositoryItemLookUpEdit.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID((int?)this.customerLookUpEdit.EditValue, "RM|IG", true, m_ItemsSession);
				itemPoolsXpView.Criteria = new BinaryOperator(ItemPool.Fields.PoolCustomerID.CustomerID.PropertyName, Convert.ToInt32(customerLookUpEdit.EditValue), BinaryOperatorType.Equal);
			}

			BindBomGridControls(itemID);

			productionStandardsXpCollection.Criteria = new BinaryOperator(ItemMachineStandards.Fields.ProductionItem.ItemID.PropertyName, itemID, BinaryOperatorType.Equal);
			productionStandardsXpCollection.Reload();

			this.priceTextEdit.EditValue = item.dblPrice;
			this.rebateTextEdit.EditValue = item.sngRebate;
			this.freightTextEdit.EditValue = item.dblFreight;
			this.filmTextEdit.EditValue = item.dblFilm;
			this.boxesTextEdit.EditValue = item.dblBoxes;
			this.stretchWrapTextEdit.EditValue = item.dblStretchWrap;
			this.palletsTextEdit.EditValue = item.dblPallets;
			this.other1TextEdit.EditValue = item.dblOther1;
			this.other2TextEdit.EditValue = item.dblOther2;
			this.other3TextEdit.EditValue = item.dblOther3;
			this.other4TextEdit.EditValue = item.dblOther4;
			this.other5TextEdit.EditValue = item.dblOther5;


			this.AllergenInfoCheckedComboBoxEdit.EditValue = item.Allergens;
			this.packageCodeMemoEdit.EditValue = item.PackageCode;
			this.caseCodeMemoEdit.EditValue = item.CaseCode;
			this.requiredWeightTextEdit.EditValue = item.RequiredWeight;
			this.mavTextEdit.EditValue = item.MAV;
			this.cassesPerLayerTextEdit.EditValue = item.CasesPerLayer;
			this.layersPerPalletTextEdit.EditValue = item.LayersPerPallet;
			this.shelfLifeTextEdit.EditValue = item.ShelfLife;
			this.instructionsMemoEdit.EditValue = item.Instructions;
			this.palletPatternButtonEdit.EditValue = item.PalletPattern;

			if (m_CurrentItemID.HasValue)
			{
				inventoryXpView.Criteria = new BinaryOperator(LocationInventory.Fields.LocationInventoryItem.ItemID.PropertyName, m_CurrentItemID.Value, BinaryOperatorType.Equal);
				transfersXpView.Criteria = new BinaryOperator(LocationTransferDetails.Fields.TransferItem.ItemID.PropertyName, m_CurrentItemID.Value, BinaryOperatorType.Equal);
			}
			else
			{
				inventoryXpView.Criteria = new BinaryOperator(LocationInventory.Fields.LocationInventoryItem.ItemID.PropertyName, 0, BinaryOperatorType.Equal);
				transfersXpView.Criteria = new BinaryOperator(LocationTransferDetails.Fields.TransferItem.ItemID.PropertyName, 0, BinaryOperatorType.Equal);
			}


		}

		private void BindBomGridControls(int? itemID)
		{

			if (itemID.HasValue == false)
			{
				itemID = 0;
			}

			if (this.bomXtraTabPage.PageVisible == true)
			{
				SPG.BOMDataTable bomdatasource = BOM.GetBOMBYFGItemID(itemID.Value);
				this.bomGridControl.DataSource = bomdatasource;
				this.availabilityGridControl.DataSource = m_Items.GetAvailabilityByItemID(itemID.Value, UsersBLL.GetUsersLocalLocation(m_ItemsSession, Properties.Settings.Default.UserName).Oid);
				poolBomXpCollection.Criteria = new BinaryOperator(PoolBom.Fields.PoolBomFiniGoodID.ItemID.PropertyName, itemID.Value, BinaryOperatorType.Equal);
				poolBomXpCollection.Reload();
			}

		}

		private void BOMGridView_InitNewRow(object sender, InitNewRowEventArgs e)
		{

			this.BOMGridView.SetRowCellValue(e.RowHandle, this.FGItemCodeGridColumn, m_CurrentItemID);
			this.BOMGridView.SetRowCellValue(e.RowHandle, this.RMQuantityGridColumn, 0);
			this.BOMGridView.SetRowCellValue(e.RowHandle, this.scrapFactorGridColumn, 0);

		}

		private void BOMGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
		{

			if (!Convert.IsDBNull(BOMGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, this.RMItemCodeGridColumn)))
			{
				e.Value = ItemsBLL.GetDescriptionByItemID((int?)BOMGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, this.RMItemCodeGridColumn));
			}

		}

		private void AdvancedTextEditParseEditValue(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
		{

			if (e.Value != null && !string.IsNullOrEmpty((e.Value == null ? null : Convert.ToString(e.Value))))
			{
				e.Value = double.Parse(e.Value.ToString());
			}

		}

		private void rebateTextEdit_ParseEditValue(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
		{

			if (e.Value != null)
			{
				e.Value = float.Parse(e.Value.ToString());
			}


		}

		public int? CurrentItemID
		{
			get
			{
				return m_CurrentItemID;
			}
			set
			{
				m_CurrentItemID = value;
				if (value.HasValue)
				{
					BindItemControls(value.Value);
				}
			}
		}

		private bool SaveChanges()
		{

			//Required to get back to current customer when entering a new customer.
			int selectedID = -1;
			if (m_CurrentItemID.HasValue == false || m_CurrentItemID.Value == -1)
			{
				m_CurrentItemID = ItemsBLL.GetNewItemID();
			}
			else
			{
				selectedID = itemSearchGridView.FocusedRowHandle;
			}

			try
			{
				if (m_Items.UpdateProduct(m_CurrentItemID.Value, codeTextEdit.Text, descriptionMemoEdit.Text, Convert.ToString(typeLookUpEdit.EditValue), (int?)customerLookUpEdit.EditValue, (int?)defaultMachineLookUpEdit.EditValue, Utilities.ChangeType<double?>(standardProductionTextEdit.EditValue), Utilities.ChangeType<double?>(priceTextEdit.EditValue), Utilities.ChangeType<float?>(rebateTextEdit.EditValue), Convert.ToString(uomLookUpEdit.EditValue), Utilities.ChangeType<double?>(qtyPerUnitTextEdit.EditValue), Utilities.ChangeType<double?>(freightTextEdit.EditValue), Utilities.ChangeType<double?>(filmTextEdit.EditValue), Utilities.ChangeType<double?>(boxesTextEdit.EditValue), Utilities.ChangeType<double?>(stretchWrapTextEdit.EditValue), Utilities.ChangeType<double?>(palletsTextEdit.EditValue), Utilities.ChangeType<double?>(other1TextEdit.EditValue), Utilities.ChangeType<double?>(other2TextEdit.EditValue), Utilities.ChangeType<double?>(other3TextEdit.EditValue), Utilities.ChangeType<double?>(other4TextEdit.EditValue), Utilities.ChangeType<double?>(other5TextEdit.EditValue), Utilities.ChangeType<double?>(unitsPerCaseTextEdit.EditValue), Utilities.ChangeType<int?>(unitsPerPalletTextEdit.EditValue), Utilities.ChangeType<int?>(casesPerPalletTextEdit.EditValue), Utilities.ChangeType<float?>(qtyOnHandTextEdit.EditValue), Utilities.ChangeType<double?>(caseGrossWeightTextEdit.EditValue), Convert.ToString(packageCodeMemoEdit.EditValue), Convert.ToString(caseCodeMemoEdit.EditValue), Convert.ToString(requiredWeightTextEdit.EditValue), Convert.ToString(mavTextEdit.EditValue), Convert.ToString(cassesPerLayerTextEdit.EditValue), Convert.ToString(layersPerPalletTextEdit.EditValue), Convert.ToString(shelfLifeTextEdit.EditValue), Convert.ToString(instructionsMemoEdit.EditValue), Convert.ToString(palletPatternButtonEdit.EditValue), inactiveCheckEdit.Checked, Convert.ToDouble(packersTextEdit.EditValue), Convert.ToString(upcTextEdit.EditValue), Utilities.ChangeType<int?>(bagsPerCaseTextEdit.EditValue), Utilities.ChangeType<bool?>(requiresLotCodeCheckEdit.Checked), Utilities.ChangeType<bool?>(requiresExpirationDateCheckEdit.Checked), Utilities.ChangeType<bool?>(generateLotCodesCheckEdit.Checked), Utilities.ChangeType<int?>(lotCodeFormatLookUpEdit.EditValue), Utilities.ChangeType<double?>(minutesPerShiftTextEdit.EditValue), Convert.ToString(AllergenInfoCheckedComboBoxEdit.EditValue), m_ItemsSession) != true)
				{
					MessageBox.Show("The item was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}
			catch (ApplicationException ex)
			{
				MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (this.bomXtraTabPage.PageVisible == true)
			{
				BOMGridView.CloseEditor();
				poolBomGridView.CloseEditor();

				try
				{
					BOMGridView.SelectAll();
					if (BOMGridView.SelectedRowsCount > 0)
					{
						for (int i = 0; i < BOMGridView.SelectedRowsCount; i++)
						{
							int row = BOMGridView.GetSelectedRows()[i];
							if (row >= 0)
							{
								if (BOM.UpdateBOM((int?)BOMGridView.GetRowCellValue(row, bomIDGridColumn), (int?)BOMGridView.GetRowCellValue(row, RMItemCodeGridColumn), m_CurrentItemID.Value, (float?)BOMGridView.GetRowCellValue(row, RMQuantityGridColumn), (double?)BOMGridView.GetRowCellValue(row, scrapFactorGridColumn)) != true)
								{
									MessageBox.Show("The item bom was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
									return false;
								}
							}
						}
					}

					foreach (PoolBom poolItem in poolBomXpCollection)
					{
						if (poolItem.PoolBomFiniGoodID == null || poolItem.PoolBomFiniGoodID.ItemID == -1)
						{
							poolItem.PoolBomFiniGoodID = m_ItemsSession.GetObjectByKey<Items>(m_CurrentItemID.Value);
						}
						poolItem.Save();
					}

				}
				catch (ApplicationException ex)
				{
					MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}

			if (productionStandardsXtraTabPage.PageVisible == true)
			{
				productionStandardsGridView.CloseEditor();

				foreach (ItemMachineStandards itemMachineStandard in productionStandardsXpCollection)
				{
					if (itemMachineStandard.ProductionItem == null || itemMachineStandard.ProductionItem.ItemID == -1)
					{
						itemMachineStandard.ProductionItem = m_ItemsSession.GetObjectByKey<Items>(m_CurrentItemID.Value);
					}
					itemMachineStandard.Save();
				}
			}

			BindItemsSearch();
			BindItemControls(m_CurrentItemID.Value);
			this.itemSearchGridView.FocusedRowHandle = selectedID;
			return true;

		}

		private void customerFilterLookUpEdit_EditValueChanged(object sender, EventArgs e)
		{

			if (this.customerFilterLookUpEdit.EditValue == null || (this.customerFilterLookUpEdit.EditValue == null ? null : Convert.ToString(this.customerFilterLookUpEdit.EditValue)) == this.customerFilterLookUpEdit.Properties.NullText)
			{
				BindItemsSearch();
			}

		}

		public string AdvancedTabs {get; set;}

		private void typeLookUpEdit_Leave(object sender, EventArgs e)
		{

			UpdateTypeSensitiveControls();

		}

		private void UpdateTypeSensitiveControls()
		{

			switch (Convert.ToString(this.typeLookUpEdit.EditValue))
			{
				case "RM":
					this.bomXtraTabPage.PageVisible = false;
					this.availabilityXtraTabPage.PageVisible = false;
					this.shippingXtraTabPage.PageVisible = false;
					this.productionXtraTabPage.PageVisible = false;
					this.receivingXtraTabPage.PageVisible = true;
					shippingReturnXtraTabPage.PageVisible = true;
					receivingReturnXtraTabPage.PageVisible = false;
					adjustmentXtraTabPage.PageVisible = true;
					productionStandardsXtraTabPage.PageVisible = false;
					break;
				case "IG":
					this.bomXtraTabPage.PageVisible = true;
					this.availabilityXtraTabPage.PageVisible = true;
					this.shippingXtraTabPage.PageVisible = false;
					this.receivingXtraTabPage.PageVisible = true;
					this.productionXtraTabPage.PageVisible = true;
					shippingReturnXtraTabPage.PageVisible = true;
					receivingReturnXtraTabPage.PageVisible = false;
					adjustmentXtraTabPage.PageVisible = true;
					productionStandardsXtraTabPage.PageVisible = true;
					BindBomGridControls(m_CurrentItemID);
					break;
				case "FG":
					this.bomXtraTabPage.PageVisible = true;
					this.availabilityXtraTabPage.PageVisible = true;
					this.receivingXtraTabPage.PageVisible = false;
					this.shippingXtraTabPage.PageVisible = true;
					this.productionXtraTabPage.PageVisible = true;
					shippingReturnXtraTabPage.PageVisible = false;
					receivingReturnXtraTabPage.PageVisible = true;
					adjustmentXtraTabPage.PageVisible = true;
					productionStandardsXtraTabPage.PageVisible = true;
					BindBomGridControls(m_CurrentItemID);
					break;
			}

		}

		private void printSimpleButton_Click(object sender, EventArgs e)
		{

			BestFitColumns();
			this.availabilityGridControl.Print();

		}

		private void availabilityGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
		{

			if (!Convert.IsDBNull(availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, this.availabilityItemIDGridColumn)) && availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, this.availabilityItemIDGridColumn) != null && !Convert.IsDBNull(availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, this.quantityOnHandGridColumn)))
			{
				if (e.Column.Name == "quantityYieldsGridColumn" && e.IsGetData)
				{
					e.Value = Math.Floor(Convert.ToDouble(availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, this.quantityOnHandGridColumn)) / (Convert.ToDouble(availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, this.quantityRequiredGridColumn)) + (Convert.ToDouble(availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, this.scrapPercentageGridColumn)) / 100 * Convert.ToDouble(availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, this.quantityRequiredGridColumn)))));
					//e.value = availabilityGridView.GetRowCellValue(e.RowHandle, Me.quantityOnHandGridColumn)
				}
				else if (e.Column.Name == localQuantityYieldsGridColumn.Name && e.IsGetData)
				{
					e.Value = Math.Floor(Convert.ToDouble(availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, localQuantityOnHandGridColumn)) / (Convert.ToDouble(availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, quantityRequiredGridColumn)) + (Convert.ToDouble(availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, scrapPercentageGridColumn)) / 100 * Convert.ToDouble(availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, quantityRequiredGridColumn)))));
				}
			}

		}

		private void itemsXtraTabControl_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
		{

//INSTANT C# NOTE: The following VB 'Select Case' included either a non-ordinal switch expression or non-ordinal, range-type, or non-constant 'Case' expressions and was converted to C# 'if-else' logic:
//			Select Case e.Page.Name
//ORIGINAL LINE: Case "availabilityXtraTabPage"
			if (e.Page.Name == "availabilityXtraTabPage")
			{
					this.availabilityGridView.UpdateTotalSummary();
					this.printGridBarButtonItem.Enabled = true;
					BestFitColumns();
			}
//ORIGINAL LINE: Case Me.generalXtraTabPage.Name
			else if (e.Page.Name == this.generalXtraTabPage.Name)
			{
					this.printGridBarButtonItem.Enabled = false;
			}
//ORIGINAL LINE: Case Me.shippingXtraTabPage.Name
			else if (e.Page.Name == this.shippingXtraTabPage.Name)
			{
					this.printGridBarButtonItem.Enabled = true;
					this.shippingGridView.BestFitColumns();
			}
//ORIGINAL LINE: Case shippingReturnXtraTabPage.Name
			else if (e.Page.Name == shippingReturnXtraTabPage.Name)
			{
					printGridBarButtonItem.Enabled = true;
					shippingReturnGridView.BestFitColumns();
			}
//ORIGINAL LINE: Case Me.receivingXtraTabPage.Name
			else if (e.Page.Name == this.receivingXtraTabPage.Name)
			{
					this.printGridBarButtonItem.Enabled = true;
					this.receivingsGridView.BestFitColumns();
			}
//ORIGINAL LINE: Case receivingReturnXtraTabPage.Name
			else if (e.Page.Name == receivingReturnXtraTabPage.Name)
			{
					printGridBarButtonItem.Enabled = true;
					receivingReturnGridView.BestFitColumns();
			}
//ORIGINAL LINE: Case Me.productionXtraTabPage.Name
			else if (e.Page.Name == this.productionXtraTabPage.Name)
			{
					this.printGridBarButtonItem.Enabled = true;
					this.productionGridView.BestFitColumns();
			}
//ORIGINAL LINE: Case adjustmentXtraTabPage.Name
			else if (e.Page.Name == adjustmentXtraTabPage.Name)
			{
					printGridBarButtonItem.Enabled = true;
					adjustmentGridView.BestFitColumns();
			}
//ORIGINAL LINE: Case Me.transfersXtraTabPage.Name
			else if (e.Page.Name == this.transfersXtraTabPage.Name)
			{
					printGridBarButtonItem.Enabled = true;
					transfersGridView.BestFitColumns();
			}
//ORIGINAL LINE: Case Me.bomXtraTabPage.Name
			else if (e.Page.Name == this.bomXtraTabPage.Name)
			{
					this.printGridBarButtonItem.Enabled = true;
					this.BOMGridView.BestFitColumns();
					if (this.customerLookUpEdit.EditValue != null && (this.customerLookUpEdit.EditValue == null ? null : Convert.ToString(this.customerLookUpEdit.EditValue)) != this.customerLookUpEdit.Properties.NullText)
					{
						this.RMRepositoryItemLookUpEdit.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID((int?)this.customerLookUpEdit.EditValue, "RM|IG", true, m_ItemsSession);
						itemPoolsXpView.Criteria = new BinaryOperator(ItemPool.Fields.PoolCustomerID.CustomerID.PropertyName, Convert.ToInt32(customerLookUpEdit.EditValue), BinaryOperatorType.Equal);
					}
					else
					{
						MessageBox.Show("You must select first a customer.");
						itemsXtraTabControl.SelectedTabPage = e.PrevPage;
					}
			}
//ORIGINAL LINE: Case Me.specificationXtraTabPage.Name
			else if (e.Page.Name == this.specificationXtraTabPage.Name)
			{
					this.printGridBarButtonItem.Enabled = false;
			}
//ORIGINAL LINE: Case Me.advancedXtraTabPage.Name
			else if (e.Page.Name == this.advancedXtraTabPage.Name)
			{
					this.printGridBarButtonItem.Enabled = false;
			}
//ORIGINAL LINE: Case productionStandardsXtraTabPage.Name
			else if (e.Page.Name == productionStandardsXtraTabPage.Name)
			{
					printGridBarButtonItem.Enabled = true;
					productionStandardsGridView.BestFitColumns();
			}

		}

		private void previewSimpleButton_Click(object sender, EventArgs e)
		{

			BestFitColumns();
			this.availabilityGridControl.ShowPrintPreview();

		}

		private void BestFitColumns()
		{

			this.bomItemCodeGridColumn.BestFit();
			this.quantityOnHandGridColumn.BestFit();
			this.quantityYieldsGridColumn.BestFit();
			localQuantityOnHandGridColumn.BestFit();
			localQuantityYieldsGridColumn.BestFit();

		}

		private void typeFilterLookUpEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
		{

			BindItemsSearch();

		}

		private void typeFilterLookUpEdit_EditValueChanged(object sender, EventArgs e)
		{

			if (this.typeFilterLookUpEdit.EditValue == null || (this.typeFilterLookUpEdit.EditValue == null ? null : Convert.ToString(this.typeFilterLookUpEdit.EditValue)) == this.typeFilterLookUpEdit.Properties.NullText)
			{
				BindItemsSearch();
			}

		}

		private void UnitsPerPalletCalculation(object sender, EventArgs e)
		{

			this.unitsPerPalletTextEdit.Text = (Convert.ToDouble(unitsPerCaseTextEdit.EditValue) * Convert.ToDouble(casesPerPalletTextEdit.EditValue)).ToString();

		}

		private void clearFilterSimpleButton_Click(object sender, EventArgs e)
		{

			this.customerFilterLookUpEdit.EditValue = null;
			this.typeFilterLookUpEdit.EditValue = null;

		}

		private void uomLookUpEdit_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
		{

			DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit edit = ((LookUpEdit)sender).Properties;
			if (e.DisplayValue.ToString() == edit.NullText || string.IsNullOrEmpty(e.DisplayValue.ToString()))
			{
				return;
			}

			((ArrayList)uomLookUpEdit.Properties.DataSource).Add(e.DisplayValue.ToString());

			e.Handled = true;

		}

		private void palletPatternButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{

			if (patternOpenFileDialog.ShowDialog() == DialogResult.OK)
			{
				palletPatternButtonEdit.EditValue = patternOpenFileDialog.FileName;
			}

		}

		private void printGridBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			PrintableComponentLink pcl = new PrintableComponentLink(new PrintingSystem());
			PrintableComponentLink pcl2 = null;
			pcl.CreateReportHeaderArea += PrintableComponentLink_CreateReportHeaderArea;

//INSTANT C# NOTE: The following VB 'Select Case' included either a non-ordinal switch expression or non-ordinal, range-type, or non-constant 'Case' expressions and was converted to C# 'if-else' logic:
//			Select Case this.itemsXtraTabControl.SelectedTabPage.Name
//ORIGINAL LINE: Case Me.shippingXtraTabPage.Name
			if (this.itemsXtraTabControl.SelectedTabPage.Name == this.shippingXtraTabPage.Name)
			{
					pcl.Component = shippingGridControl;
					m_GridReportTitle = "Shipping";
			}
//ORIGINAL LINE: Case shippingReturnXtraTabPage.Name
			else if (this.itemsXtraTabControl.SelectedTabPage.Name == shippingReturnXtraTabPage.Name)
			{
					pcl.Component = shippingReturnGridControl;
					m_GridReportTitle = "Shipping Returns";
			}
//ORIGINAL LINE: Case Me.productionXtraTabPage.Name
			else if (this.itemsXtraTabControl.SelectedTabPage.Name == this.productionXtraTabPage.Name)
			{
					pcl.Component = productionGridControl;
					m_GridReportTitle = "Inventory";
			}
//ORIGINAL LINE: Case Me.receivingXtraTabPage.Name
			else if (this.itemsXtraTabControl.SelectedTabPage.Name == this.receivingXtraTabPage.Name)
			{
					pcl.Component = receivingsGridControl;
					m_GridReportTitle = "Receivings";
			}
//ORIGINAL LINE: Case receivingReturnXtraTabPage.Name
			else if (this.itemsXtraTabControl.SelectedTabPage.Name == receivingReturnXtraTabPage.Name)
			{
					pcl.Component = receivingReturnGridControl;
					m_GridReportTitle = "Receiving Returns";
			}
//ORIGINAL LINE: Case transfersXtraTabPage.Name
			else if (this.itemsXtraTabControl.SelectedTabPage.Name == transfersXtraTabPage.Name)
			{
					pcl.Component = transfersGridControl;
					m_GridReportTitle = "Item Transfers";
			}
//ORIGINAL LINE: Case Me.bomXtraTabPage.Name
			else if (this.itemsXtraTabControl.SelectedTabPage.Name == this.bomXtraTabPage.Name)
			{
					pcl.Component = bomGridControl;
					m_GridReportTitle = "BOM";
					pcl2 = new PrintableComponentLink(new PrintingSystem());
					pcl2.CreateReportHeaderArea += PrintableComponentLink_CreateReportHeaderArea;
					pcl2.Component = poolBomGridControl;
			}
//ORIGINAL LINE: Case Me.availabilityXtraTabPage.Name
			else if (this.itemsXtraTabControl.SelectedTabPage.Name == this.availabilityXtraTabPage.Name)
			{
					pcl.Component = availabilityGridControl;
					m_GridReportTitle = "Availability";
			}
//ORIGINAL LINE: Case adjustmentXtraTabPage.Name
			else if (this.itemsXtraTabControl.SelectedTabPage.Name == adjustmentXtraTabPage.Name)
			{
					pcl.Component = adjustmentGridControl;
					m_GridReportTitle = "Inventory Adjustments";
			}
//ORIGINAL LINE: Case productionStandardsXtraTabPage.Name
			else if (this.itemsXtraTabControl.SelectedTabPage.Name == productionStandardsXtraTabPage.Name)
			{
					pcl.Component = productionStandardsGridControl;
					m_GridReportTitle = "Item Machine Standards";
			}

			pcl.CreateDocument();
			pcl.ShowPreviewDialog();

			if (pcl2 != null)
			{
				pcl2.CreateDocument();
				pcl2.ShowPreviewDialog();
			}

		}

		private void PrintableComponentLink_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
		{

			TextBrick brick = e.Graph.DrawString(string.Format("{0} {1} Item # {2}", m_GridReportTitle, Environment.NewLine, m_CurrentItemID), Color.Black, new RectangleF(0, 5, 600, 25), DevExpress.XtraPrinting.BorderSide.None);
			brick.Font = new Font("Arial", 14, FontStyle.Bold);
			brick.StringFormat = new BrickStringFormat(StringAlignment.Center);

		}

		private void itemSearchGridView_Click(object sender, EventArgs e)
		{

			if (itemSearchGridView.FocusedRowHandle == -999997)
			{
				return;
			}

			if (this.itemSearchGridView.CalcHitInfo(this.itemsSearchGridControl.PointToClient(Control.MousePosition)).HitTest == GridHitTest.RowCell)
			{
				this.BindItemControls(Convert.ToInt32(this.itemSearchGridView.GetFocusedRowCellValue(this.itemIDGridColumn)));
			}

		}

		private void addBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			m_CurrentItemID = -1;
			this.codeTextEdit.Text = null;
			this.customerLookUpEdit.EditValue = null;
			this.customerLookUpEdit.Enabled = true;
			this.descriptionMemoEdit.Text = null;
			this.typeLookUpEdit.EditValue = null;
			this.typeLookUpEdit.Enabled = true;
			this.standardProductionTextEdit.EditValue = 0;
			this.defaultMachineLookUpEdit.EditValue = null;
			this.uomLookUpEdit.EditValue = null;
			this.qtyPerUnitTextEdit.EditValue = 1;
			this.unitsPerCaseTextEdit.EditValue = 1;
			this.unitsPerPalletTextEdit.EditValue = 0;
			this.casesPerPalletTextEdit.EditValue = 0;
			this.qtyOnHandTextEdit.EditValue = 0;
			this.caseGrossWeightTextEdit.EditValue = 0;
			this.packersTextEdit.EditValue = 0;
			this.inactiveCheckEdit.Checked = false;
			upcTextEdit.EditValue = null;
			requiresExpirationDateCheckEdit.Checked = false;
			requiresLotCodeCheckEdit.Checked = false;
			generateLotCodesCheckEdit.Checked = false;
			lotCodeFormatLookUpEdit.EditValue = null;
			minutesPerShiftTextEdit.EditValue = 0;

			BindBomGridControls(m_CurrentItemID);

			this.priceTextEdit.EditValue = 0;
			this.rebateTextEdit.EditValue = 0;
			this.freightTextEdit.EditValue = 0;
			this.filmTextEdit.EditValue = 0;
			this.boxesTextEdit.EditValue = 0;
			this.stretchWrapTextEdit.EditValue = 0;
			this.palletsTextEdit.EditValue = 0;
			this.other1TextEdit.EditValue = 0;
			this.other2TextEdit.EditValue = 0;
			this.other3TextEdit.EditValue = 0;
			this.other4TextEdit.EditValue = 0;
			this.other5TextEdit.EditValue = 0;

			this.packageCodeMemoEdit.EditValue = null;
			this.caseCodeMemoEdit.EditValue = null;
			this.requiredWeightTextEdit.EditValue = null;
			this.mavTextEdit.EditValue = null;
			this.cassesPerLayerTextEdit.EditValue = null;
			this.layersPerPalletTextEdit.EditValue = null;
			this.shelfLifeTextEdit.EditValue = null;
			this.instructionsMemoEdit.EditValue = null;
			this.palletPatternButtonEdit.EditValue = null;

			this.shippingGridControl.DataSource = SuperiorPackGroup.ShippingDetailsBLL.GetShippingDetailsByItemID(m_CurrentItemID.Value);
			shippingReturnGridControl.DataSource = ShippingReturnDetailsBLL.GetShippingReturnDetailsViewByItemID(m_CurrentItemID.Value);

			this.productionGridControl.DataSource = m_Inventory.GetInventoryByItemID(m_CurrentItemID.Value);

			this.receivingsGridControl.DataSource = ReceivingDetailsBLL.GetReceivingDetailsByItemID(m_CurrentItemID.Value);
			this.receivingReturnGridControl.DataSource = ReturnDetailsBLL.GetReceivingReturnDetailsByItemID(m_CurrentItemID.Value);

			adjustmentGridControl.DataSource = InventoryAdjustmentBLL.GetAdjustmentsByItemID(m_CurrentItemID.Value);

			inventoryXpView.Criteria = new BinaryOperator(LocationInventory.Fields.LocationInventoryItem.ItemID, m_CurrentItemID.Value, BinaryOperatorType.Equal);
			transfersXpView.Criteria = new BinaryOperator(LocationTransferDetails.Fields.TransferItem.ItemID.PropertyName, m_CurrentItemID.Value, BinaryOperatorType.Equal);

			productionStandardsXpCollection.Criteria = new BinaryOperator(ItemMachineStandards.Fields.ProductionItem.ItemID.PropertyName, -1, BinaryOperatorType.Equal);
			productionStandardsXpCollection.Reload();

			this.itemsXtraTabControl.SelectedTabPage = this.generalXtraTabPage;

			this.itemSearchGridView.FocusedRowHandle = -1;
			Utilities.MakeFormReadOnly(this.generalXtraTabPage, false);
			qtyOnHandTextEdit.Properties.ReadOnly = true;
			unitsPerPalletTextEdit.Properties.ReadOnly = true;
			Utilities.MakeFormReadOnly(this.advancedXtraTabPage, false);
			Utilities.MakeFormReadOnly(this.specificationXtraTabPage, false);
			this.BOMGridView.OptionsBehavior.Editable = true;
			poolBomGridView.OptionsBehavior.Editable = true;
			productionStandardsGridView.OptionsBehavior.Editable = true;
			this.itemsSearchGridControl.Enabled = false;
			CheckPermissions();

			this.cancelBarButtonItem.Enabled = true;
			this.saveBarButtonItem.Enabled = true;
			this.editBarButtonItem.Enabled = false;
			this.addBarButtonItem.Enabled = false;
			this.deleteBarButtonItem.Enabled = false;
			this.deleteGridColumn.Visible = false;
			poolBomDeleteGridColumn.Visible = false;

		}

		private void editBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (m_CurrentItemID == null)
			{
				MessageBox.Show("Please select a item to edit.");
				return;
			}

			if (ItemsBLL.AllowEdit(m_ItemsSession, m_CurrentItemID.Value) == false)
			{
				if (MessageBox.Show("Someone else is editing now this item." + Environment.NewLine + "Do you want to edit anyway?", "Item in use", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
				{
					return;
				}
			}

			Utilities.MakeFormReadOnly(this.generalXtraTabPage, false);
			qtyOnHandTextEdit.Properties.ReadOnly = true;
			unitsPerPalletTextEdit.Properties.ReadOnly = true;
			Utilities.MakeFormReadOnly(this.advancedXtraTabPage, false);
			Utilities.MakeFormReadOnly(this.specificationXtraTabPage, false);
			this.BOMGridView.OptionsBehavior.Editable = true;
			poolBomGridView.OptionsBehavior.Editable = true;
			productionStandardsGridView.OptionsBehavior.Editable = true;
			this.itemsSearchGridControl.Enabled = false;
			CheckPermissions();

			this.cancelBarButtonItem.Enabled = true;
			this.saveBarButtonItem.Enabled = true;
			this.editBarButtonItem.Enabled = false;
			this.addBarButtonItem.Enabled = false;
			this.deleteBarButtonItem.Enabled = false;

		}

		private void deleteBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (MessageBox.Show("Are you sure you want to delete this item.", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
			{
				return;
			}

			try
			{
				if (m_Items.DeleteIem(m_CurrentItemID.Value) == true)
				{
					BindItemsSearch();
				}
				else
				{
					MessageBox.Show("The item was not deleted.");
				}
			}
			catch (ApplicationException ex)
			{
				MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void cancelBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			CancelChanges();

			CheckPermissions();

			Utilities.MakeFormReadOnly(this.generalXtraTabPage, true);
			Utilities.MakeFormReadOnly(this.advancedXtraTabPage, true);
			Utilities.MakeFormReadOnly(this.specificationXtraTabPage, true);
			this.BOMGridView.OptionsBehavior.Editable = false;
			poolBomGridView.OptionsBehavior.Editable = false;
			productionStandardsGridView.OptionsBehavior.Editable = false;
			this.itemsSearchGridControl.Enabled = true;

			cancelBarButtonItem.Enabled = false;
			saveBarButtonItem.Enabled = false;

		}

		private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (SaveChanges())
			{

				CheckPermissions();

				Utilities.MakeFormReadOnly(this.generalXtraTabPage, true);
				Utilities.MakeFormReadOnly(this.advancedXtraTabPage, true);
				Utilities.MakeFormReadOnly(this.specificationXtraTabPage, true);
				this.BOMGridView.OptionsBehavior.Editable = false;
				poolBomGridView.OptionsBehavior.Editable = false;
				productionStandardsGridView.OptionsBehavior.Editable = false;
				this.itemsSearchGridControl.Enabled = true;

				cancelBarButtonItem.Enabled = false;
				saveBarButtonItem.Enabled = false;
			}

		}

		private void specificationsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (m_CurrentItemID == null)
			{
				MessageBox.Show("Select an item first.");
				return;
			}

			ProductSpecificationsXtraReport specifications = new ProductSpecificationsXtraReport();

			specifications.itemCodeXrLabel.DataBindings.Add("Text", null, "ItemCode");
			specifications.itemDescriptionXrLabel.DataBindings.Add("Text", null, "ItemDescription");
			specifications.itemBomsXrLabel.Text = (new BOMBLL()).GetBOMBYFGItemIDString(m_CurrentItemID.Value);
			specifications.requiredWeightXrLabel.DataBindings.Add("Text", null, "RequiredWeight");
			specifications.mavXrLabel.DataBindings.Add("Text", null, "MAV");
			specifications.unitsPerCaseXrLabel.DataBindings.Add("Text", null, "intUnitsPerCase", "{0:N2}");
			specifications.casesPerPalletXrLabel.DataBindings.Add("Text", null, "intCasesPerPallet");
			specifications.casesPerLayerXrLabel.DataBindings.Add("Text", null, "CasesPerLayer");
			specifications.layersPerPalletXrLabel.DataBindings.Add("Text", null, "LayersPerPallet");
			specifications.packageCodeXrLabel.DataBindings.Add("Text", null, "PackageCode");
			specifications.caseCodeXrLabel.DataBindings.Add("Text", null, "CaseCode");
			specifications.shelfLifeXrLabel.DataBindings.Add("Text", null, "ShelfLife");
			specifications.specialInstructionsXrLabel.DataBindings.Add("Text", null, "Instructions");
			specifications.palletPaternXrPictureBox.DataBindings.Add("ImageUrl", null, "PalletPattern");
			specifications.DataSource = m_Items.GetItemBYId(m_CurrentItemID.Value);
			specifications.ShowPreview();

		}

		private void palletTicketBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (m_CurrentItemID == null)
			{
				MessageBox.Show("Select an item first");
				return;
			}

			PalletTicketXtraReport ticket = new PalletTicketXtraReport() {DataSource = (new PalletTicketBLL()).GetPalletTicket(m_CurrentItemID.Value)};
			ticket.customerXrLabel.DataBindings.Add("Text", null, "CustomerName");
			ticket.itemXrLabel.DataBindings.Add("Text", null, "ItemCode");
			ticket.itemDescriptionXrLabel.DataBindings.Add("Text", null, "ItemDescription");
			ticket.itemTypeXrLabel.DataBindings.Add("Text", null, "ItemType");
			ticket.casesPerPalletXrLabel.DataBindings.Add("Text", null, "intCasesPerPallet");
			ticket.ShowPreview();

		}

		public bool CheckPermissions()
		{

			try
			{
				SPG.UserPermissionsRow permission = (new UserPermissionsBLL()).GetUserPermissionsByUserName(Properties.Settings.Default.UserName, "Items Form")[0];

				switch (permission.PermissionLevel)
				{
					case "FULL":
					case "Full":
						this.addBarButtonItem.Enabled = true;
						this.editBarButtonItem.Enabled = true;
						this.deleteBarButtonItem.Enabled = true;
						this.deleteGridColumn.Visible = true;
						this.deleteGridColumn.VisibleIndex = 0;
						poolBomDeleteGridColumn.Visible = true;
						poolBomDeleteGridColumn.VisibleIndex = 0;
						delProdStdGridColumn.Visible = true;
						delProdStdGridColumn.VisibleIndex = 0;
						break;
					case "ADD":
					case "Add":
						this.addBarButtonItem.Enabled = true;
						this.editBarButtonItem.Enabled = true;
						this.deleteBarButtonItem.Enabled = false;
						this.deleteGridColumn.Visible = false;
						poolBomDeleteGridColumn.Visible = false;
						delProdStdGridColumn.Visible = false;
						break;
					case "NONE":
					case "None":
						MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						this.Close();
						return false;
					case "VIEW":
					case "View":
						this.addBarButtonItem.Enabled = false;
						this.editBarButtonItem.Enabled = false;
						this.deleteBarButtonItem.Enabled = false;
						this.deleteGridColumn.Visible = false;
						poolBomDeleteGridColumn.Visible = false;
						delProdStdGridColumn.Visible = false;
						break;
					case "EDIT":
					case "Edit":
						this.addBarButtonItem.Enabled = false;
						this.editBarButtonItem.Enabled = true;
						this.deleteBarButtonItem.Enabled = false;
						this.deleteGridColumn.Visible = false;
						poolBomDeleteGridColumn.Visible = false;
						delProdStdGridColumn.Visible = false;
						break;
					case "VIEW ASSIGNED":
						this.addBarButtonItem.Enabled = false;
						this.editBarButtonItem.Enabled = false;
						this.deleteGridColumn.Visible = false;
						poolBomDeleteGridColumn.Visible = false;
						this.deleteBarButtonItem.Enabled = false;
						delProdStdGridColumn.Visible = false;
						FilterAssignedCustomers();
						break;
					case "EDIT ASSIGNED":
						this.addBarButtonItem.Enabled = false;
						this.editBarButtonItem.Enabled = true;
						this.deleteGridColumn.Visible = false;
						poolBomDeleteGridColumn.Visible = false;
						this.deleteBarButtonItem.Enabled = false;
						delProdStdGridColumn.Visible = false;
						FilterAssignedCustomers();
						break;
					default:
						MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
						this.Close();
						return false;
				}

				switch (this.AdvancedTabs)
				{
					case "FULL":
					case "Full":
						Utilities.MakeFormReadOnly(this.advancedXtraTabPage, false);
						break;
					case "ADD":
					case "Add":
						Utilities.MakeFormReadOnly(this.advancedXtraTabPage, false);
						break;
					case "NONE":
					case "None":
						this.advancedXtraTabPage.PageVisible = false;
						break;
					case "VIEW":
					case "View":
					case "VIEW ASSIGNED":
						Utilities.MakeFormReadOnly(this.advancedXtraTabPage, true);
						break;
					case "EDIT":
					case "Edit":
					case "EDIT ASSIGNED":
						Utilities.MakeFormReadOnly(this.advancedXtraTabPage, false);
						break;
				}
				return true;
			}
			catch (InvalidOperationException ex)
			{
				return false;
			}

		}

		private void FilterAssignedCustomers()
		{

			this.itemSearchXPView.Criteria = new InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ItemsSession));

		}


		private void CancelChanges()
		{

			if (this.m_CurrentItemID.HasValue && this.m_CurrentItemID.Value != -1)
			{
				BindItemControls(m_CurrentItemID.Value);
				m_Items.EndedEdit(m_ItemsSession, m_CurrentItemID.Value);
			}

		}

		private void inactiveSearchCheckEdit_CheckedChanged(object sender, EventArgs e)
		{

			BindItemsSearch();

		}

		private void RMRepositoryItemLookUpEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
		{

			if (e.CloseMode != PopupCloseMode.Cancel)
			{
				GridView view = (GridView)(((GridControl)(((LookUpEdit)sender).Parent)).FocusedView);
				if (view.IsNewItemRow(view.FocusedRowHandle))
				{
					view.CloseEditor();
					view.UpdateCurrentRow();
				}
			}

		}

		private void deleteRepositoryItemButtonEdit_Click(object sender, EventArgs e)
		{

			if (MessageBox.Show("Are you sure you want to delete this BOM item.", "Delete BOM Item", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
			{
				return;
			}

			try
			{
				int BOMID = Convert.ToInt32(this.BOMGridView.GetRowCellValue(this.BOMGridView.FocusedRowHandle, this.bomIDGridColumn));
				if (BOMID < 1 || m_BOM.DeleteBOM(BOMID) == true)
				{
					BindBomGridControls(m_CurrentItemID);
				}
				else
				{
					MessageBox.Show("The BOM item was not deleted.");
				}
			}
			catch (ApplicationException ex)
			{
				MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		//Private Sub adjustmentGridView_CustomUnboundColumnData(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles adjustmentGridView.CustomUnboundColumnData

		//    If e.Column.Name = adjustmentQuantityGridColumn.Name Then
		//        If IsDBNull(adjustmentGridView.GetRowCellValue(e.RowHandle, adjustmentOriginalQuantityGridColumn)) OrElse IsDBNull(adjustmentGridView.GetRowCellValue(e.RowHandle, adjustmentNewQtyGridColumn)) Then
		//            Exit Sub
		//        End If
		//        e.Value = CType(adjustmentGridView.GetRowCellValue(e.RowHandle, adjustmentNewQtyGridColumn), Integer) - CType(adjustmentGridView.GetRowCellValue(e.RowHandle, adjustmentOriginalQuantityGridColumn), Integer)
		//    End If

		//End Sub

		private void adjustmentGridView_RowCellStyle(System.Object sender, RowCellStyleEventArgs e)
		{

			if (e.Column.Name == adjustmentQuantityGridColumn.Name)
			{
				if (Convert.IsDBNull(adjustmentGridView.GetRowCellValue(e.RowHandle, adjustmentQuantityGridColumn)) || Convert.ToInt32(adjustmentGridView.GetRowCellValue(e.RowHandle, adjustmentQuantityGridColumn)) >= 0)
				{
					e.Appearance.ForeColor = Color.Black;
				}
				else
				{
					e.Appearance.ForeColor = Color.Red;
				}
			}

		}

		private void poolBomDeleteRepositoryItemButtonEdit_Click(object sender, EventArgs e)
		{

			if (MessageBox.Show("Are you sure you want to remove this pool item.", "Delete Pool Detail", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
			{
				return;
			}

			PoolBom poolItem = m_ItemsSession.GetObjectByKey<PoolBom>(poolBomGridView.GetFocusedRowCellValue(colOid));
			if (poolItem != null)
			{
				poolItem.Delete();

				if (poolItem.IsDeleted == false)
				{
					MessageBox.Show("The pool item was not removed.");
				}
			}
			else
			{
				poolBomGridView.DeleteRow(poolBomGridView.FocusedRowHandle);
			}

		}

		private void delProdStdRepositoryItemButtonEdit_Click(object sender, EventArgs e)
		{

			if (MessageBox.Show("Are you sure you want to remove this production standard?", "Delete Item-Machine Standard", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
			{
				return;
			}

			ItemMachineStandards productionStandard = m_ItemsSession.GetObjectByKey<ItemMachineStandards>(productionStandardsGridView.GetFocusedRowCellValue(colOid1));
			if (productionStandard != null)
			{
				productionStandard.Delete();

				if (productionStandard.IsDeleted == false)
				{
					MessageBox.Show("The production standard was not removed.");
				}
			}
			else
			{
				productionStandardsGridView.DeleteRow(productionStandardsGridView.FocusedRowHandle);
			}

		}

		private void productionGridView_FilterEditorCreated(object sender, DevExpress.XtraGrid.Views.Base.FilterControlEventArgs e)
		{
			e.FilterControl.BeforeShowValueEditor += FilterControl_BeforeShowValueEditor;
		}

		private void FilterControl_BeforeShowValueEditor(object sender, DevExpress.XtraEditors.Filtering.ShowValueEditorEventArgs e)
		{
			if (e.CurrentNode.FirstOperand.PropertyName == "InventoryDate")
			{
				DateEdit editor = (DateEdit)e.Editor;
				editor.Width = 200;
				editor.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
				editor.Properties.CalendarTimeProperties.Mask.EditMask = "g";
				editor.Properties.TimeEditWidth = 150;
			}
		}

		private void productionGridControl_Click(object sender, EventArgs e)
		{

		}
	}

}