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
			typeLookUpEdit.Properties.DisplayMember = "Description";
			typeLookUpEdit.Properties.ValueMember = "Type";

			typeFilterLookUpEdit.Properties.DataSource = itemTypes;
			typeFilterLookUpEdit.Properties.DisplayMember = "Description";
			typeFilterLookUpEdit.Properties.ValueMember = "Type";

			uomLookUpEdit.Properties.DataSource = m_Items.GetItemUOMs();
			uomLookUpEdit.Properties.ShowHeader = false;

			//Me.defaultMachineLookUpEdit.Properties.DataSource = m_MachineLines.GetMachineLines
			//Me.defaultMachineLookUpEdit.Properties.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo)
			//Me.defaultMachineLookUpEdit.Properties.Columns(0).FieldName = "MachineLineName"
			//Me.defaultMachineLookUpEdit.Properties.Columns(0).Caption = "Machine Line"
			//Me.defaultMachineLookUpEdit.Properties.DisplayMember = "MachineLineName"
			//Me.defaultMachineLookUpEdit.Properties.ValueMember = "MachineLineID"

			RMRepositoryItemLookUpEdit.Columns.Add(new LookUpColumnInfo());
			RMRepositoryItemLookUpEdit.Columns[0].FieldName = "ItemCode";
			RMRepositoryItemLookUpEdit.Columns[0].Caption = "Raw Material";
			RMRepositoryItemLookUpEdit.DisplayMember = "ItemCode";
			RMRepositoryItemLookUpEdit.ValueMember = "ItemID";

			shippingDetailIDGridColumn.FieldName = "ShipDetDetID";
			shippingIDGridColumn.FieldName = "ShipDetMainID";
			shippingLotGridColumn.FieldName = "ShipDetLot";
			shippingExpirationDateGridColumn.FieldName = "ExpirationDate";
			shippingQuantityGridColumn.FieldName = "ShipDetDetQty";
			shippingBOLGridColumn.FieldName = "ShipMainBOL";
			shippingDateGridColumn.FieldName = "ShipMainDate";

			shippingReturnIDGridColumn.FieldName = "ReturnDetID";
			returnShippingIDGridColumn.FieldName = "ShipMainID";
			shippingReturnLotGridColumn.FieldName = "ReturnDetLot";
			shippingReturnExpirationDateGridColumn.FieldName = "ExpirationDate";
			shippingReturnQuantityGridColumn.FieldName = "intUnits";
			shippingReturnBOLGridColumn.FieldName = "ShipMainBOL";
			shippingReturnDateGridColumn.FieldName = "ShipMainDate";

			productionDateGridColumn.FieldName = "InventoryDate";
			productionQuantityGridColumn.FieldName = "InventoryQuantity";
			productionLotGridColumn.FieldName = "Lot";
			productionExpirationDateGridColumn.FieldName = "ExpirationDate";
			productionPOGridColumn.FieldName = "PO";

			receivingDetailIDGridColumn.FieldName = "ReceiveDetID";
			receivingIDGridColumn.FieldName = "ReceiveMainID";
			receivingLpnGridColumn.FieldName = "ReceiveDetLPN";
			receivingLotGridColumn.FieldName = "ReceiveDetLot";
			receivingExpirationDateGridColumn.FieldName = "ExpirationDate";
			receivingQuantityGridColumn.FieldName = "ReceiveDetQty";
			receivingBOLGridColumn.FieldName = "ReceiveBOL";
			receivingDateGridColumn.FieldName = "ReceiveDate";

			receivingReturnIDGridColumn.FieldName = "ReceiveDetID";
			returnReceivingIDGridColumn.FieldName = "ReceiveMainID";
			receivingReturnLpnGridColumn.FieldName = "ReceiveDetLPN";
			receivingReturnLotGridColumn.FieldName = "ReceiveDetLot";
			receivingReturnExpirationDateGridColumn.FieldName = "ExpirationDate";
			receivingReturnQuantityGridColumn.FieldName = "ReceiveDetQty";
			receivingReturnBolGridColumn.FieldName = "ReceiveBOL";
			receivingReturnDateGridColumn.FieldName = "ReceiveDate";

			bomIDGridColumn.FieldName = "BOMID";
			FGItemCodeGridColumn.FieldName = "BOMFiniGoodID";
			RMItemCodeGridColumn.FieldName = "BOMRawMatID";
			RMQuantityGridColumn.FieldName = "BOMQuantity";
			scrapFactorGridColumn.FieldName = "ScrapFactor";

			availabilityItemIDGridColumn.FieldName = "BOMRawMatID";
			bomItemCodeGridColumn.FieldName = "ItemCode";
			bomItemDescriptionGridColumn.FieldName = "ItemDescription";
			quantityOnHandGridColumn.FieldName = "TotalQuantityOnHand";
			localQuantityOnHandGridColumn.FieldName = "LocalQuantityOnHand";
			quantityRequiredGridColumn.FieldName = "BOMQuantity";
			scrapPercentageGridColumn.FieldName = "ScrapFactor";
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

			Utilities.MakeFormReadOnly(generalXtraTabPage, true);
			Utilities.MakeFormReadOnly(advancedXtraTabPage, true);
			Utilities.MakeFormReadOnly(specificationXtraTabPage, true);
			BOMGridView.OptionsBehavior.Editable = false;
			poolBomGridView.OptionsBehavior.Editable = false;
			productionStandardsGridView.OptionsBehavior.Editable = false;
			itemsSearchGridControl.Enabled = true;

			printGridBarButtonItem.Enabled = false;
			cancelBarButtonItem.Enabled = false;
			saveBarButtonItem.Enabled = false;

			foreach (Allergen Allergen in AllergensBLL.GetAllergens(ref m_ItemsSession))
			{
				AllergenInfoCheckedComboBoxEdit.Properties.Items.Add(Allergen.AllergenName);
			}

			Cursor = Cursors.Default;


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
			codeTextEdit.Text = item.ItemCode;
			customerLookUpEdit.EditValue = item.ItemCustomerID.CustomerID;
			customerLookUpEdit.Enabled = false;
			descriptionMemoEdit.Text = item.ItemDescription;
			typeLookUpEdit.EditValue = item.ItemType;
			typeLookUpEdit.Enabled = false;
			UpdateTypeSensitiveControls();
			standardProductionTextEdit.EditValue = item.ItemProdStandard;
			if (item.ItemDefaultMachine != null)
			{
				defaultMachineLookUpEdit.EditValue = item.ItemDefaultMachine.MachineLineID;
			}
			else
			{
				defaultMachineLookUpEdit.EditValue = null;
			}

			uomLookUpEdit.EditValue = item.strUnitOfMeasure;
			qtyOnHandTextEdit.EditValue = ItemsBLL.GetQtyOnHandByID(m_ItemsSession, m_CurrentItemID, 0);
			qtyPerUnitTextEdit.EditValue = item.intQtyPerUnit;
			if (unitsPerCaseTextEdit.Enabled == true)
			{
				unitsPerCaseTextEdit.EditValue = item.intUnitsPerCase;
			}
			if (unitsPerPalletTextEdit.Enabled == true)
			{
				unitsPerPalletTextEdit.EditValue = item.intUnitsPerPallet;
			}
			if (casesPerPalletTextEdit.Enabled == true)
			{
				casesPerPalletTextEdit.EditValue = item.intCasesPerPallet;
			}
			caseGrossWeightTextEdit.EditValue = item.CaseGrossWeight;
			inactiveCheckEdit.Checked = item.Inactive;
			packersTextEdit.EditValue = item.Packers.HasValue ? item.Packers : null;
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

			shippingGridControl.DataSource = ShippingDetailsBLL.GetShippingDetailsByItemID(itemID);
			shippingReturnGridControl.DataSource = ShippingReturnDetailsBLL.GetShippingReturnDetailsViewByItemID(itemID);

			productionGridControl.DataSource = m_Inventory.GetInventoryByItemID(itemID);

			receivingsGridControl.DataSource = ReceivingDetailsBLL.GetReceivingDetailsByItemID(itemID);
			receivingReturnGridControl.DataSource = ReturnDetailsBLL.GetReceivingReturnDetailsByItemID(itemID);

			adjustmentGridControl.DataSource = InventoryAdjustmentBLL.GetAdjustmentsByItemID(itemID);

			//bind the BOM tab
			if ((customerLookUpEdit.EditValue == null ? null : Convert.ToString(customerLookUpEdit.EditValue)) == customerLookUpEdit.Properties.NullText)
			{
				RMRepositoryItemLookUpEdit.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(null, "RM|IG", true, m_ItemsSession);
				itemPoolsXpView.Criteria = null;
			}
			else
			{
				RMRepositoryItemLookUpEdit.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID((int?)customerLookUpEdit.EditValue, "RM|IG", true, m_ItemsSession);
				itemPoolsXpView.Criteria = new BinaryOperator(ItemPool.Fields.PoolCustomerID.CustomerID.PropertyName, Convert.ToInt32(customerLookUpEdit.EditValue), BinaryOperatorType.Equal);
			}

			BindBomGridControls(itemID);

			productionStandardsXpCollection.Criteria = new BinaryOperator(ItemMachineStandards.Fields.ProductionItem.ItemID.PropertyName, itemID, BinaryOperatorType.Equal);
			productionStandardsXpCollection.Reload();

			priceTextEdit.EditValue = item.dblPrice;
			rebateTextEdit.EditValue = item.sngRebate;
			freightTextEdit.EditValue = item.dblFreight;
			filmTextEdit.EditValue = item.dblFilm;
			boxesTextEdit.EditValue = item.dblBoxes;
			stretchWrapTextEdit.EditValue = item.dblStretchWrap;
			palletsTextEdit.EditValue = item.dblPallets;
			other1TextEdit.EditValue = item.dblOther1;
			other2TextEdit.EditValue = item.dblOther2;
			other3TextEdit.EditValue = item.dblOther3;
			other4TextEdit.EditValue = item.dblOther4;
			other5TextEdit.EditValue = item.dblOther5;


			AllergenInfoCheckedComboBoxEdit.EditValue = item.Allergens;
			packageCodeMemoEdit.EditValue = item.PackageCode;
			caseCodeMemoEdit.EditValue = item.CaseCode;
			requiredWeightTextEdit.EditValue = item.RequiredWeight;
			mavTextEdit.EditValue = item.MAV;
			cassesPerLayerTextEdit.EditValue = item.CasesPerLayer;
			layersPerPalletTextEdit.EditValue = item.LayersPerPallet;
			shelfLifeTextEdit.EditValue = item.ShelfLife;
			instructionsMemoEdit.EditValue = item.Instructions;
			palletPatternButtonEdit.EditValue = item.PalletPattern;

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

			if (bomXtraTabPage.PageVisible == true)
			{
				SPG.BOMDataTable bomdatasource = BOM.GetBOMBYFGItemID(itemID.Value);
				bomGridControl.DataSource = bomdatasource;
				availabilityGridControl.DataSource = m_Items.GetAvailabilityByItemID(itemID.Value, UsersBLL.GetUsersLocalLocation(m_ItemsSession, Properties.Settings.Default.UserName).Oid);
				poolBomXpCollection.Criteria = new BinaryOperator(PoolBom.Fields.PoolBomFiniGoodID.ItemID.PropertyName, itemID.Value, BinaryOperatorType.Equal);
				poolBomXpCollection.Reload();
			}

		}

		private void BOMGridView_InitNewRow(object sender, InitNewRowEventArgs e)
		{

			BOMGridView.SetRowCellValue(e.RowHandle, FGItemCodeGridColumn, m_CurrentItemID);
			BOMGridView.SetRowCellValue(e.RowHandle, RMQuantityGridColumn, 0);
			BOMGridView.SetRowCellValue(e.RowHandle, scrapFactorGridColumn, 0);

		}

		private void BOMGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
		{

			if (!Convert.IsDBNull(BOMGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, RMItemCodeGridColumn)))
			{
				e.Value = ItemsBLL.GetDescriptionByItemID((int?)BOMGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, RMItemCodeGridColumn));
			}

		}

		private void AdvancedTextEditParseEditValue(object sender, ConvertEditValueEventArgs e)
		{

			if (e.Value != null && !string.IsNullOrEmpty((e.Value == null ? null : Convert.ToString(e.Value))))
			{
				e.Value = double.Parse(e.Value.ToString());
			}

		}

		private void rebateTextEdit_ParseEditValue(object sender, ConvertEditValueEventArgs e)
		{

			if (e.Value != null)
			{
				e.Value = float.Parse(e.Value.ToString());
			}


		}

		public int? CurrentItemID
        {
            get => m_CurrentItemID;
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

			if (bomXtraTabPage.PageVisible == true)
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
			itemSearchGridView.FocusedRowHandle = selectedID;
			return true;

		}

		private void customerFilterLookUpEdit_EditValueChanged(object sender, EventArgs e)
		{

			if (customerFilterLookUpEdit.EditValue == null || (customerFilterLookUpEdit.EditValue == null ? null : Convert.ToString(customerFilterLookUpEdit.EditValue)) == customerFilterLookUpEdit.Properties.NullText)
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

			switch (Convert.ToString(typeLookUpEdit.EditValue))
			{
				case "RM":
					bomXtraTabPage.PageVisible = false;
					availabilityXtraTabPage.PageVisible = false;
					shippingXtraTabPage.PageVisible = false;
					productionXtraTabPage.PageVisible = false;
					receivingXtraTabPage.PageVisible = true;
					shippingReturnXtraTabPage.PageVisible = true;
					receivingReturnXtraTabPage.PageVisible = false;
					adjustmentXtraTabPage.PageVisible = true;
					productionStandardsXtraTabPage.PageVisible = false;
					break;
				case "IG":
					bomXtraTabPage.PageVisible = true;
					availabilityXtraTabPage.PageVisible = true;
					shippingXtraTabPage.PageVisible = false;
					receivingXtraTabPage.PageVisible = true;
					productionXtraTabPage.PageVisible = true;
					shippingReturnXtraTabPage.PageVisible = true;
					receivingReturnXtraTabPage.PageVisible = false;
					adjustmentXtraTabPage.PageVisible = true;
					productionStandardsXtraTabPage.PageVisible = true;
					BindBomGridControls(m_CurrentItemID);
					break;
				case "FG":
					bomXtraTabPage.PageVisible = true;
					availabilityXtraTabPage.PageVisible = true;
					receivingXtraTabPage.PageVisible = false;
					shippingXtraTabPage.PageVisible = true;
					productionXtraTabPage.PageVisible = true;
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
			availabilityGridControl.Print();

		}

		private void availabilityGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
		{

			if (!Convert.IsDBNull(availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, availabilityItemIDGridColumn)) && availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, availabilityItemIDGridColumn) != null && !Convert.IsDBNull(availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, quantityOnHandGridColumn)))
			{
				if (e.Column.Name == "quantityYieldsGridColumn" && e.IsGetData)
				{
					e.Value = Math.Floor(Convert.ToDouble(availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, quantityOnHandGridColumn)) / (Convert.ToDouble(availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, quantityRequiredGridColumn)) + (Convert.ToDouble(availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, scrapPercentageGridColumn)) / 100 * Convert.ToDouble(availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, quantityRequiredGridColumn)))));
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
					availabilityGridView.UpdateTotalSummary();
					printGridBarButtonItem.Enabled = true;
					BestFitColumns();
			}
//ORIGINAL LINE: Case Me.generalXtraTabPage.Name
			else if (e.Page.Name == generalXtraTabPage.Name)
			{
					printGridBarButtonItem.Enabled = false;
			}
//ORIGINAL LINE: Case Me.shippingXtraTabPage.Name
			else if (e.Page.Name == shippingXtraTabPage.Name)
			{
					printGridBarButtonItem.Enabled = true;
					shippingGridView.BestFitColumns();
			}
//ORIGINAL LINE: Case shippingReturnXtraTabPage.Name
			else if (e.Page.Name == shippingReturnXtraTabPage.Name)
			{
					printGridBarButtonItem.Enabled = true;
					shippingReturnGridView.BestFitColumns();
			}
//ORIGINAL LINE: Case Me.receivingXtraTabPage.Name
			else if (e.Page.Name == receivingXtraTabPage.Name)
			{
					printGridBarButtonItem.Enabled = true;
					receivingsGridView.BestFitColumns();
			}
//ORIGINAL LINE: Case receivingReturnXtraTabPage.Name
			else if (e.Page.Name == receivingReturnXtraTabPage.Name)
			{
					printGridBarButtonItem.Enabled = true;
					receivingReturnGridView.BestFitColumns();
			}
//ORIGINAL LINE: Case Me.productionXtraTabPage.Name
			else if (e.Page.Name == productionXtraTabPage.Name)
			{
					printGridBarButtonItem.Enabled = true;
					productionGridView.BestFitColumns();
			}
//ORIGINAL LINE: Case adjustmentXtraTabPage.Name
			else if (e.Page.Name == adjustmentXtraTabPage.Name)
			{
					printGridBarButtonItem.Enabled = true;
					adjustmentGridView.BestFitColumns();
			}
//ORIGINAL LINE: Case Me.transfersXtraTabPage.Name
			else if (e.Page.Name == transfersXtraTabPage.Name)
			{
					printGridBarButtonItem.Enabled = true;
					transfersGridView.BestFitColumns();
			}
//ORIGINAL LINE: Case Me.bomXtraTabPage.Name
			else if (e.Page.Name == bomXtraTabPage.Name)
			{
					printGridBarButtonItem.Enabled = true;
					BOMGridView.BestFitColumns();
					if (customerLookUpEdit.EditValue != null && (customerLookUpEdit.EditValue == null ? null : Convert.ToString(customerLookUpEdit.EditValue)) != customerLookUpEdit.Properties.NullText)
					{
						RMRepositoryItemLookUpEdit.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID((int?)customerLookUpEdit.EditValue, "RM|IG", true, m_ItemsSession);
						itemPoolsXpView.Criteria = new BinaryOperator(ItemPool.Fields.PoolCustomerID.CustomerID.PropertyName, Convert.ToInt32(customerLookUpEdit.EditValue), BinaryOperatorType.Equal);
					}
					else
					{
						MessageBox.Show("You must select first a customer.");
						itemsXtraTabControl.SelectedTabPage = e.PrevPage;
					}
			}
//ORIGINAL LINE: Case Me.specificationXtraTabPage.Name
			else if (e.Page.Name == specificationXtraTabPage.Name)
			{
					printGridBarButtonItem.Enabled = false;
			}
//ORIGINAL LINE: Case Me.advancedXtraTabPage.Name
			else if (e.Page.Name == advancedXtraTabPage.Name)
			{
					printGridBarButtonItem.Enabled = false;
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
			availabilityGridControl.ShowPrintPreview();

		}

		private void BestFitColumns()
		{

			bomItemCodeGridColumn.BestFit();
			quantityOnHandGridColumn.BestFit();
			quantityYieldsGridColumn.BestFit();
			localQuantityOnHandGridColumn.BestFit();
			localQuantityYieldsGridColumn.BestFit();

		}

		private void typeFilterLookUpEdit_Closed(object sender, ClosedEventArgs e)
		{

			BindItemsSearch();

		}

		private void typeFilterLookUpEdit_EditValueChanged(object sender, EventArgs e)
		{

			if (typeFilterLookUpEdit.EditValue == null || (typeFilterLookUpEdit.EditValue == null ? null : Convert.ToString(typeFilterLookUpEdit.EditValue)) == typeFilterLookUpEdit.Properties.NullText)
			{
				BindItemsSearch();
			}

		}

		private void UnitsPerPalletCalculation(object sender, EventArgs e)
		{

			unitsPerPalletTextEdit.Text = (Convert.ToDouble(unitsPerCaseTextEdit.EditValue) * Convert.ToDouble(casesPerPalletTextEdit.EditValue)).ToString();

		}

		private void clearFilterSimpleButton_Click(object sender, EventArgs e)
		{

			customerFilterLookUpEdit.EditValue = null;
			typeFilterLookUpEdit.EditValue = null;

		}

		private void uomLookUpEdit_ProcessNewValue(object sender, ProcessNewValueEventArgs e)
		{

			DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit edit = ((LookUpEdit)sender).Properties;
			if (e.DisplayValue.ToString() == edit.NullText || string.IsNullOrEmpty(e.DisplayValue.ToString()))
			{
				return;
			}

			((ArrayList)uomLookUpEdit.Properties.DataSource).Add(e.DisplayValue.ToString());

			e.Handled = true;

		}

		private void palletPatternButtonEdit_ButtonClick(object sender, ButtonPressedEventArgs e)
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
			if (itemsXtraTabControl.SelectedTabPage.Name == shippingXtraTabPage.Name)
			{
					pcl.Component = shippingGridControl;
					m_GridReportTitle = "Shipping";
			}
//ORIGINAL LINE: Case shippingReturnXtraTabPage.Name
			else if (itemsXtraTabControl.SelectedTabPage.Name == shippingReturnXtraTabPage.Name)
			{
					pcl.Component = shippingReturnGridControl;
					m_GridReportTitle = "Shipping Returns";
			}
//ORIGINAL LINE: Case Me.productionXtraTabPage.Name
			else if (itemsXtraTabControl.SelectedTabPage.Name == productionXtraTabPage.Name)
			{
					pcl.Component = productionGridControl;
					m_GridReportTitle = "Inventory";
			}
//ORIGINAL LINE: Case Me.receivingXtraTabPage.Name
			else if (itemsXtraTabControl.SelectedTabPage.Name == receivingXtraTabPage.Name)
			{
					pcl.Component = receivingsGridControl;
					m_GridReportTitle = "Receivings";
			}
//ORIGINAL LINE: Case receivingReturnXtraTabPage.Name
			else if (itemsXtraTabControl.SelectedTabPage.Name == receivingReturnXtraTabPage.Name)
			{
					pcl.Component = receivingReturnGridControl;
					m_GridReportTitle = "Receiving Returns";
			}
//ORIGINAL LINE: Case transfersXtraTabPage.Name
			else if (itemsXtraTabControl.SelectedTabPage.Name == transfersXtraTabPage.Name)
			{
					pcl.Component = transfersGridControl;
					m_GridReportTitle = "Item Transfers";
			}
//ORIGINAL LINE: Case Me.bomXtraTabPage.Name
			else if (itemsXtraTabControl.SelectedTabPage.Name == bomXtraTabPage.Name)
			{
					pcl.Component = bomGridControl;
					m_GridReportTitle = "BOM";
					pcl2 = new PrintableComponentLink(new PrintingSystem());
					pcl2.CreateReportHeaderArea += PrintableComponentLink_CreateReportHeaderArea;
					pcl2.Component = poolBomGridControl;
			}
//ORIGINAL LINE: Case Me.availabilityXtraTabPage.Name
			else if (itemsXtraTabControl.SelectedTabPage.Name == availabilityXtraTabPage.Name)
			{
					pcl.Component = availabilityGridControl;
					m_GridReportTitle = "Availability";
			}
//ORIGINAL LINE: Case adjustmentXtraTabPage.Name
			else if (itemsXtraTabControl.SelectedTabPage.Name == adjustmentXtraTabPage.Name)
			{
					pcl.Component = adjustmentGridControl;
					m_GridReportTitle = "Inventory Adjustments";
			}
//ORIGINAL LINE: Case productionStandardsXtraTabPage.Name
			else if (itemsXtraTabControl.SelectedTabPage.Name == productionStandardsXtraTabPage.Name)
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

			if (itemSearchGridView.CalcHitInfo(itemsSearchGridControl.PointToClient(Control.MousePosition)).HitTest == GridHitTest.RowCell)
			{
				BindItemControls(Convert.ToInt32(itemSearchGridView.GetFocusedRowCellValue(itemIDGridColumn)));
			}

		}

		private void addBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			m_CurrentItemID = -1;
			codeTextEdit.Text = null;
			customerLookUpEdit.EditValue = null;
			customerLookUpEdit.Enabled = true;
			descriptionMemoEdit.Text = null;
			typeLookUpEdit.EditValue = null;
			typeLookUpEdit.Enabled = true;
			standardProductionTextEdit.EditValue = 0;
			defaultMachineLookUpEdit.EditValue = null;
			uomLookUpEdit.EditValue = null;
			qtyPerUnitTextEdit.EditValue = 1;
			unitsPerCaseTextEdit.EditValue = 1;
			unitsPerPalletTextEdit.EditValue = 0;
			casesPerPalletTextEdit.EditValue = 0;
			qtyOnHandTextEdit.EditValue = 0;
			caseGrossWeightTextEdit.EditValue = 0;
			packersTextEdit.EditValue = 0;
			inactiveCheckEdit.Checked = false;
			upcTextEdit.EditValue = null;
			requiresExpirationDateCheckEdit.Checked = false;
			requiresLotCodeCheckEdit.Checked = false;
			generateLotCodesCheckEdit.Checked = false;
			lotCodeFormatLookUpEdit.EditValue = null;
			minutesPerShiftTextEdit.EditValue = 0;

			BindBomGridControls(m_CurrentItemID);

			priceTextEdit.EditValue = 0;
			rebateTextEdit.EditValue = 0;
			freightTextEdit.EditValue = 0;
			filmTextEdit.EditValue = 0;
			boxesTextEdit.EditValue = 0;
			stretchWrapTextEdit.EditValue = 0;
			palletsTextEdit.EditValue = 0;
			other1TextEdit.EditValue = 0;
			other2TextEdit.EditValue = 0;
			other3TextEdit.EditValue = 0;
			other4TextEdit.EditValue = 0;
			other5TextEdit.EditValue = 0;

			packageCodeMemoEdit.EditValue = null;
			caseCodeMemoEdit.EditValue = null;
			requiredWeightTextEdit.EditValue = null;
			mavTextEdit.EditValue = null;
			cassesPerLayerTextEdit.EditValue = null;
			layersPerPalletTextEdit.EditValue = null;
			shelfLifeTextEdit.EditValue = null;
			instructionsMemoEdit.EditValue = null;
			palletPatternButtonEdit.EditValue = null;

			shippingGridControl.DataSource = SuperiorPackGroup.ShippingDetailsBLL.GetShippingDetailsByItemID(m_CurrentItemID.Value);
			shippingReturnGridControl.DataSource = ShippingReturnDetailsBLL.GetShippingReturnDetailsViewByItemID(m_CurrentItemID.Value);

			productionGridControl.DataSource = m_Inventory.GetInventoryByItemID(m_CurrentItemID.Value);

			receivingsGridControl.DataSource = ReceivingDetailsBLL.GetReceivingDetailsByItemID(m_CurrentItemID.Value);
			receivingReturnGridControl.DataSource = ReturnDetailsBLL.GetReceivingReturnDetailsByItemID(m_CurrentItemID.Value);

			adjustmentGridControl.DataSource = InventoryAdjustmentBLL.GetAdjustmentsByItemID(m_CurrentItemID.Value);

			inventoryXpView.Criteria = new BinaryOperator(LocationInventory.Fields.LocationInventoryItem.ItemID, m_CurrentItemID.Value, BinaryOperatorType.Equal);
			transfersXpView.Criteria = new BinaryOperator(LocationTransferDetails.Fields.TransferItem.ItemID.PropertyName, m_CurrentItemID.Value, BinaryOperatorType.Equal);

			productionStandardsXpCollection.Criteria = new BinaryOperator(ItemMachineStandards.Fields.ProductionItem.ItemID.PropertyName, -1, BinaryOperatorType.Equal);
			productionStandardsXpCollection.Reload();

			itemsXtraTabControl.SelectedTabPage = generalXtraTabPage;

			itemSearchGridView.FocusedRowHandle = -1;
			Utilities.MakeFormReadOnly(generalXtraTabPage, false);
			qtyOnHandTextEdit.Properties.ReadOnly = true;
			unitsPerPalletTextEdit.Properties.ReadOnly = true;
			Utilities.MakeFormReadOnly(advancedXtraTabPage, false);
			Utilities.MakeFormReadOnly(specificationXtraTabPage, false);
			BOMGridView.OptionsBehavior.Editable = true;
			poolBomGridView.OptionsBehavior.Editable = true;
			productionStandardsGridView.OptionsBehavior.Editable = true;
			itemsSearchGridControl.Enabled = false;
			CheckPermissions();

			cancelBarButtonItem.Enabled = true;
			saveBarButtonItem.Enabled = true;
			editBarButtonItem.Enabled = false;
			addBarButtonItem.Enabled = false;
			deleteBarButtonItem.Enabled = false;
			deleteGridColumn.Visible = false;
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

			Utilities.MakeFormReadOnly(generalXtraTabPage, false);
			qtyOnHandTextEdit.Properties.ReadOnly = true;
			unitsPerPalletTextEdit.Properties.ReadOnly = true;
			Utilities.MakeFormReadOnly(advancedXtraTabPage, false);
			Utilities.MakeFormReadOnly(specificationXtraTabPage, false);
			BOMGridView.OptionsBehavior.Editable = true;
			poolBomGridView.OptionsBehavior.Editable = true;
			productionStandardsGridView.OptionsBehavior.Editable = true;
			itemsSearchGridControl.Enabled = false;
			CheckPermissions();

			cancelBarButtonItem.Enabled = true;
			saveBarButtonItem.Enabled = true;
			editBarButtonItem.Enabled = false;
			addBarButtonItem.Enabled = false;
			deleteBarButtonItem.Enabled = false;

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

			Utilities.MakeFormReadOnly(generalXtraTabPage, true);
			Utilities.MakeFormReadOnly(advancedXtraTabPage, true);
			Utilities.MakeFormReadOnly(specificationXtraTabPage, true);
			BOMGridView.OptionsBehavior.Editable = false;
			poolBomGridView.OptionsBehavior.Editable = false;
			productionStandardsGridView.OptionsBehavior.Editable = false;
			itemsSearchGridControl.Enabled = true;

			cancelBarButtonItem.Enabled = false;
			saveBarButtonItem.Enabled = false;

		}

		private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (SaveChanges())
			{

				CheckPermissions();

				Utilities.MakeFormReadOnly(generalXtraTabPage, true);
				Utilities.MakeFormReadOnly(advancedXtraTabPage, true);
				Utilities.MakeFormReadOnly(specificationXtraTabPage, true);
				BOMGridView.OptionsBehavior.Editable = false;
				poolBomGridView.OptionsBehavior.Editable = false;
				productionStandardsGridView.OptionsBehavior.Editable = false;
				itemsSearchGridControl.Enabled = true;

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
						addBarButtonItem.Enabled = true;
						editBarButtonItem.Enabled = true;
						deleteBarButtonItem.Enabled = true;
						deleteGridColumn.Visible = true;
						deleteGridColumn.VisibleIndex = 0;
						poolBomDeleteGridColumn.Visible = true;
						poolBomDeleteGridColumn.VisibleIndex = 0;
						delProdStdGridColumn.Visible = true;
						delProdStdGridColumn.VisibleIndex = 0;
						break;
					case "ADD":
					case "Add":
						addBarButtonItem.Enabled = true;
						editBarButtonItem.Enabled = true;
						deleteBarButtonItem.Enabled = false;
						deleteGridColumn.Visible = false;
						poolBomDeleteGridColumn.Visible = false;
						delProdStdGridColumn.Visible = false;
						break;
					case "NONE":
					case "None":
						MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						Close();
						return false;
					case "VIEW":
					case "View":
						addBarButtonItem.Enabled = false;
						editBarButtonItem.Enabled = false;
						deleteBarButtonItem.Enabled = false;
						deleteGridColumn.Visible = false;
						poolBomDeleteGridColumn.Visible = false;
						delProdStdGridColumn.Visible = false;
						break;
					case "EDIT":
					case "Edit":
						addBarButtonItem.Enabled = false;
						editBarButtonItem.Enabled = true;
						deleteBarButtonItem.Enabled = false;
						deleteGridColumn.Visible = false;
						poolBomDeleteGridColumn.Visible = false;
						delProdStdGridColumn.Visible = false;
						break;
					case "VIEW ASSIGNED":
						addBarButtonItem.Enabled = false;
						editBarButtonItem.Enabled = false;
						deleteGridColumn.Visible = false;
						poolBomDeleteGridColumn.Visible = false;
						deleteBarButtonItem.Enabled = false;
						delProdStdGridColumn.Visible = false;
						FilterAssignedCustomers();
						break;
					case "EDIT ASSIGNED":
						addBarButtonItem.Enabled = false;
						editBarButtonItem.Enabled = true;
						deleteGridColumn.Visible = false;
						poolBomDeleteGridColumn.Visible = false;
						deleteBarButtonItem.Enabled = false;
						delProdStdGridColumn.Visible = false;
						FilterAssignedCustomers();
						break;
					default:
						MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
						Close();
						return false;
				}

				switch (AdvancedTabs)
				{
					case "FULL":
					case "Full":
						Utilities.MakeFormReadOnly(advancedXtraTabPage, false);
						break;
					case "ADD":
					case "Add":
						Utilities.MakeFormReadOnly(advancedXtraTabPage, false);
						break;
					case "NONE":
					case "None":
						advancedXtraTabPage.PageVisible = false;
						break;
					case "VIEW":
					case "View":
					case "VIEW ASSIGNED":
						Utilities.MakeFormReadOnly(advancedXtraTabPage, true);
						break;
					case "EDIT":
					case "Edit":
					case "EDIT ASSIGNED":
						Utilities.MakeFormReadOnly(advancedXtraTabPage, false);
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

			itemSearchXPView.Criteria = new InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ItemsSession));

		}


		private void CancelChanges()
		{

			if (m_CurrentItemID.HasValue && m_CurrentItemID.Value != -1)
			{
				BindItemControls(m_CurrentItemID.Value);
				m_Items.EndedEdit(m_ItemsSession, m_CurrentItemID.Value);
			}

		}

		private void inactiveSearchCheckEdit_CheckedChanged(object sender, EventArgs e)
		{

			BindItemsSearch();

		}

		private void RMRepositoryItemLookUpEdit_Closed(object sender, ClosedEventArgs e)
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
				int BOMID = Convert.ToInt32(BOMGridView.GetRowCellValue(BOMGridView.FocusedRowHandle, bomIDGridColumn));
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