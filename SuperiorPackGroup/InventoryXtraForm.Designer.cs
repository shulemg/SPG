using DevExpress.XtraEditors;
using System.Text;
using DevExpress.Data.Filtering;
using DXDAL.SPGData;
using DevExpress.Xpo;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace SuperiorPackGroup
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class InventoryXtraForm : DevExpress.XtraEditors.XtraForm
	{
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
				if (m_InventoryUOW != null)
				{
					m_InventoryUOW.Dispose();
					m_InventoryUOW = null;
				}
			}
			base.Dispose(disposing);
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryXtraForm));
			this.inventoryGridControl = new DevExpress.XtraGrid.GridControl();
			this.inventoryXPView = new DevExpress.Xpo.XPView(this.components);
			this.inventoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.deleteGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.deleteRepositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			this.idGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.customerGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.dateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shiftGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.itemGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.descriptionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.quantityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.palletsGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.poGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.lotGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.palletGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.LPNGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.expirationDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.expirationDateFormatGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.noteGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.recordGroupControl = new DevExpress.XtraEditors.GroupControl();
			this.LabelControl18 = new DevExpress.XtraEditors.LabelControl();
			this.noteMemoEdit = new DevExpress.XtraEditors.MemoEdit();
			this.productionDetailsXtraTabControl = new DevExpress.XtraTab.XtraTabControl();
			this.poolDetailsXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.poolDetailsGridControl = new DevExpress.XtraGrid.GridControl();
			this.poolDetailsXpView = new DevExpress.Xpo.XPView(this.components);
			this.poolDetailsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.itemPoolGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.rmItemGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colItemPoolRatio = new DevExpress.XtraGrid.Columns.GridColumn();
			this.itemPoolIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.itemCodeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.itemQuantityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.itemQuantityUsedGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.rmItemIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.projectDetailsXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.projectDetailsGridControl = new DevExpress.XtraGrid.GridControl();
			this.productionProjectDetailXpCollection = new DevExpress.Xpo.XPCollection(this.components);
			this.projectDetailsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colOid1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHasChanges = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUnitsProduced = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBagsProduced = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPalletsProduced = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIsOverrun = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colProject = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCustomerPO = new DevExpress.XtraGrid.Columns.GridColumn();
			this.LabelControl16 = new DevExpress.XtraEditors.LabelControl();
			this.expirationDateEdit = new DevExpress.XtraEditors.DateEdit();
			this.addLotCodeSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.LPNLabelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.largeLPNSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.LabelControl14 = new DevExpress.XtraEditors.LabelControl();
			this.palletNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.shiftLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.shiftXPView = new DevExpress.Xpo.XPView(this.components);
			this.ShiftLabel = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl13 = new DevExpress.XtraEditors.LabelControl();
			this.onHandTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.lotTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl11 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.poTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.cancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.editSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.saveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.descriptionMemoEdit = new DevExpress.XtraEditors.MemoEdit();
			this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.palletsTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.quantityTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.itemLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.itemsXPView = new DevExpress.Xpo.XPView(this.components);
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.inventoryDateEdit = new DevExpress.XtraEditors.DateEdit();
			this.poolDetailsXpCollection = new DevExpress.Xpo.XPCollection(this.components);
			this.filtersGroupControl = new DevExpress.XtraEditors.GroupControl();
			this.filterByPalletSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.LabelControl15 = new DevExpress.XtraEditors.LabelControl();
			this.LPNFilterTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl17 = new DevExpress.XtraEditors.LabelControl();
			this.shiftFilterLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.LabelControl12 = new DevExpress.XtraEditors.LabelControl();
			this.lotFilterTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.filterSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.clearSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.itemFilterLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.itemsFilterXPView = new DevExpress.Xpo.XPView(this.components);
			this.customerFilterLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.customersXPView = new DevExpress.Xpo.XPView(this.components);
			this.LabelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.toFilterDateEdit = new DevExpress.XtraEditors.DateEdit();
			this.fromFilterDateEdit = new DevExpress.XtraEditors.DateEdit();
			((System.ComponentModel.ISupportInitialize)this.inventoryGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryXPView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.deleteRepositoryItemButtonEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.recordGroupControl).BeginInit();
			this.recordGroupControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.noteMemoEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionDetailsXtraTabControl).BeginInit();
			this.productionDetailsXtraTabControl.SuspendLayout();
			this.poolDetailsXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.poolDetailsGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.poolDetailsXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.poolDetailsGridView).BeginInit();
			this.projectDetailsXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.projectDetailsGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionProjectDetailXpCollection).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.projectDetailsGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.expirationDateEdit.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.expirationDateEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.palletNumberTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shiftLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shiftXPView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.onHandTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.lotTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.poTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.descriptionMemoEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.palletsTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.quantityTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemsXPView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryDateEdit.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryDateEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.poolDetailsXpCollection).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.filtersGroupControl).BeginInit();
			this.filtersGroupControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.LPNFilterTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shiftFilterLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.lotFilterTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemFilterLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemsFilterXPView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customerFilterLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customersXPView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.toFilterDateEdit.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.toFilterDateEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.fromFilterDateEdit.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.fromFilterDateEdit.Properties).BeginInit();
			this.SuspendLayout();
			//
			//inventoryGridControl
			//
			this.inventoryGridControl.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.inventoryGridControl.DataSource = this.inventoryXPView;
			this.inventoryGridControl.Location = new System.Drawing.Point(12, 335);
			this.inventoryGridControl.MainView = this.inventoryGridView;
			this.inventoryGridControl.Name = "inventoryGridControl";
			this.inventoryGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {this.deleteRepositoryItemButtonEdit});
			this.inventoryGridControl.Size = new System.Drawing.Size(1109, 293);
			this.inventoryGridControl.TabIndex = 27;
			this.inventoryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.inventoryGridView});
			//
			//inventoryXPView
			//
			this.inventoryXPView.ObjectType = typeof(DXDAL.SPGData.Inventory);
			this.inventoryXPView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("InventoryDate", DevExpress.Xpo.SortDirection.None, "[InventoryDate]", false, true),
				new DevExpress.Xpo.ViewProperty("InventoryID", DevExpress.Xpo.SortDirection.None, "[InventoryID]", false, true),
				new DevExpress.Xpo.ViewProperty("CustomerName", DevExpress.Xpo.SortDirection.None, "[InventoryItemID.ItemCustomerID.CustomerName]", false, true),
				new DevExpress.Xpo.ViewProperty("Quantity", DevExpress.Xpo.SortDirection.None, "[InventoryQuantity]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[InventoryItemID.ItemCode]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemDescription", DevExpress.Xpo.SortDirection.None, "[InventoryItemID.ItemDescription]", false, true),
				new DevExpress.Xpo.ViewProperty("Pallets", DevExpress.Xpo.SortDirection.None, "[InventoryPallets]", false, true),
				new DevExpress.Xpo.ViewProperty("PO", DevExpress.Xpo.SortDirection.None, "[PO]", false, true),
				new DevExpress.Xpo.ViewProperty("Lot", DevExpress.Xpo.SortDirection.None, "[Lot]", false, true),
				new DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[InventoryItemID.ItemCustomerID.CustomerID]", false, true),
				new DevExpress.Xpo.ViewProperty("Shift", DevExpress.Xpo.SortDirection.None, "[Shift.ShiftName]", false, true),
				new DevExpress.Xpo.ViewProperty("Pallet", DevExpress.Xpo.SortDirection.None, "[Pallet]", false, true),
				new DevExpress.Xpo.ViewProperty("LPNNumber", DevExpress.Xpo.SortDirection.None, "[LPNNumber]", false, true),
				new DevExpress.Xpo.ViewProperty("ExpirationDate", DevExpress.Xpo.SortDirection.None, "[ExpirationDate]", false, true),
				new DevExpress.Xpo.ViewProperty("ExpirationDateFormat", DevExpress.Xpo.SortDirection.None, "[InventoryItemID.ItemCustomerID.ExpirationDateFormat]", false, true),
				new DevExpress.Xpo.ViewProperty("Note", DevExpress.Xpo.SortDirection.None, "[Note]", false, true)
			});
			//
			//inventoryGridView
			//
			this.inventoryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.deleteGridColumn, this.idGridColumn, this.customerGridColumn, this.dateGridColumn, this.shiftGridColumn, this.itemGridColumn, this.descriptionGridColumn, this.quantityGridColumn, this.palletsGridColumn, this.poGridColumn, this.lotGridColumn, this.palletGridColumn, this.LPNGridColumn, this.expirationDateGridColumn, this.expirationDateFormatGridColumn, this.noteGridColumn});
			this.inventoryGridView.GridControl = this.inventoryGridControl;
			this.inventoryGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", this.quantityGridColumn, "{0:#,###.######}")});
			this.inventoryGridView.Name = "inventoryGridView";
			//
			//deleteGridColumn
			//
			this.deleteGridColumn.ColumnEdit = this.deleteRepositoryItemButtonEdit;
			this.deleteGridColumn.Name = "deleteGridColumn";
			this.deleteGridColumn.OptionsColumn.AllowSize = false;
			this.deleteGridColumn.OptionsColumn.FixedWidth = true;
			this.deleteGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "")});
			this.deleteGridColumn.Visible = true;
			this.deleteGridColumn.VisibleIndex = 0;
			this.deleteGridColumn.Width = 22;
			//
			//deleteRepositoryItemButtonEdit
			//
			this.deleteRepositoryItemButtonEdit.AutoHeight = false;
			this.deleteRepositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
			this.deleteRepositoryItemButtonEdit.Name = "deleteRepositoryItemButtonEdit";
			this.deleteRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			//
			//idGridColumn
			//
			this.idGridColumn.Caption = "GridColumn1";
			this.idGridColumn.FieldName = "InventoryID";
			this.idGridColumn.Name = "idGridColumn";
			//
			//customerGridColumn
			//
			this.customerGridColumn.Caption = "Customer Name";
			this.customerGridColumn.FieldName = "CustomerName";
			this.customerGridColumn.Name = "customerGridColumn";
			this.customerGridColumn.OptionsColumn.AllowEdit = false;
			this.customerGridColumn.OptionsColumn.ReadOnly = true;
			this.customerGridColumn.Visible = true;
			this.customerGridColumn.VisibleIndex = 1;
			this.customerGridColumn.Width = 105;
			//
			//dateGridColumn
			//
			this.dateGridColumn.Caption = "Date";
			this.dateGridColumn.DisplayFormat.FormatString = "g";
			this.dateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.dateGridColumn.FieldName = "InventoryDate";
			this.dateGridColumn.Name = "dateGridColumn";
			this.dateGridColumn.OptionsColumn.AllowEdit = false;
			this.dateGridColumn.OptionsColumn.ReadOnly = true;
			this.dateGridColumn.Visible = true;
			this.dateGridColumn.VisibleIndex = 2;
			this.dateGridColumn.Width = 105;
			//
			//shiftGridColumn
			//
			this.shiftGridColumn.Caption = "Shift";
			this.shiftGridColumn.FieldName = "Shift";
			this.shiftGridColumn.Name = "shiftGridColumn";
			this.shiftGridColumn.OptionsColumn.AllowEdit = false;
			this.shiftGridColumn.OptionsColumn.ReadOnly = true;
			this.shiftGridColumn.Visible = true;
			this.shiftGridColumn.VisibleIndex = 4;
			//
			//itemGridColumn
			//
			this.itemGridColumn.Caption = "Item #";
			this.itemGridColumn.FieldName = "ItemCode";
			this.itemGridColumn.Name = "itemGridColumn";
			this.itemGridColumn.OptionsColumn.AllowEdit = false;
			this.itemGridColumn.OptionsColumn.ReadOnly = true;
			this.itemGridColumn.Visible = true;
			this.itemGridColumn.VisibleIndex = 3;
			this.itemGridColumn.Width = 100;
			//
			//descriptionGridColumn
			//
			this.descriptionGridColumn.Caption = "Item Description";
			this.descriptionGridColumn.FieldName = "ItemDescription";
			this.descriptionGridColumn.Name = "descriptionGridColumn";
			this.descriptionGridColumn.OptionsColumn.AllowEdit = false;
			this.descriptionGridColumn.OptionsColumn.ReadOnly = true;
			this.descriptionGridColumn.Visible = true;
			this.descriptionGridColumn.VisibleIndex = 5;
			this.descriptionGridColumn.Width = 190;
			//
			//quantityGridColumn
			//
			this.quantityGridColumn.Caption = "Quantity";
			this.quantityGridColumn.FieldName = "Quantity";
			this.quantityGridColumn.Name = "quantityGridColumn";
			this.quantityGridColumn.OptionsColumn.AllowEdit = false;
			this.quantityGridColumn.OptionsColumn.FixedWidth = true;
			this.quantityGridColumn.OptionsColumn.ReadOnly = true;
			this.quantityGridColumn.Visible = true;
			this.quantityGridColumn.VisibleIndex = 6;
			this.quantityGridColumn.Width = 60;
			//
			//palletsGridColumn
			//
			this.palletsGridColumn.Caption = "Pallets";
			this.palletsGridColumn.FieldName = "Pallets";
			this.palletsGridColumn.Name = "palletsGridColumn";
			this.palletsGridColumn.OptionsColumn.AllowEdit = false;
			this.palletsGridColumn.OptionsColumn.FixedWidth = true;
			this.palletsGridColumn.OptionsColumn.ReadOnly = true;
			this.palletsGridColumn.Visible = true;
			this.palletsGridColumn.VisibleIndex = 7;
			this.palletsGridColumn.Width = 60;
			//
			//poGridColumn
			//
			this.poGridColumn.Caption = "PO #";
			this.poGridColumn.FieldName = "PO";
			this.poGridColumn.Name = "poGridColumn";
			this.poGridColumn.Visible = true;
			this.poGridColumn.VisibleIndex = 8;
			//
			//lotGridColumn
			//
			this.lotGridColumn.Caption = "Lot #";
			this.lotGridColumn.FieldName = "Lot";
			this.lotGridColumn.Name = "lotGridColumn";
			this.lotGridColumn.Visible = true;
			this.lotGridColumn.VisibleIndex = 9;
			//
			//palletGridColumn
			//
			this.palletGridColumn.Caption = "Pallet";
			this.palletGridColumn.FieldName = "Pallet";
			this.palletGridColumn.Name = "palletGridColumn";
			this.palletGridColumn.OptionsColumn.AllowEdit = false;
			this.palletGridColumn.OptionsColumn.ReadOnly = true;
			this.palletGridColumn.Visible = true;
			this.palletGridColumn.VisibleIndex = 11;
			//
			//LPNGridColumn
			//
			this.LPNGridColumn.Caption = "LPN Number";
			this.LPNGridColumn.FieldName = "LPNNumber";
			this.LPNGridColumn.Name = "LPNGridColumn";
			this.LPNGridColumn.OptionsColumn.AllowEdit = false;
			this.LPNGridColumn.OptionsColumn.ReadOnly = true;
			this.LPNGridColumn.Visible = true;
			this.LPNGridColumn.VisibleIndex = 12;
			//
			//expirationDateGridColumn
			//
			this.expirationDateGridColumn.Caption = "Expiration Date";
			this.expirationDateGridColumn.DisplayFormat.FormatString = "d";
			this.expirationDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.expirationDateGridColumn.FieldName = "ExpirationDate";
			this.expirationDateGridColumn.Name = "expirationDateGridColumn";
			this.expirationDateGridColumn.OptionsColumn.AllowEdit = false;
			this.expirationDateGridColumn.OptionsColumn.ReadOnly = true;
			this.expirationDateGridColumn.Visible = true;
			this.expirationDateGridColumn.VisibleIndex = 10;
			//
			//expirationDateFormatGridColumn
			//
			this.expirationDateFormatGridColumn.Caption = "GridColumn1";
			this.expirationDateFormatGridColumn.FieldName = "ExpirationDateFormat";
			this.expirationDateFormatGridColumn.Name = "expirationDateFormatGridColumn";
			this.expirationDateFormatGridColumn.OptionsColumn.AllowEdit = false;
			this.expirationDateFormatGridColumn.OptionsColumn.AllowShowHide = false;
			this.expirationDateFormatGridColumn.OptionsColumn.ReadOnly = true;
			this.expirationDateFormatGridColumn.OptionsColumn.ShowInCustomizationForm = false;
			//
			//noteGridColumn
			//
			this.noteGridColumn.Caption = "Note";
			this.noteGridColumn.FieldName = "Note";
			this.noteGridColumn.Name = "noteGridColumn";
			this.noteGridColumn.OptionsColumn.ReadOnly = true;
			this.noteGridColumn.Visible = true;
			this.noteGridColumn.VisibleIndex = 13;
			//
			//recordGroupControl
			//
			this.recordGroupControl.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.recordGroupControl.Controls.Add(this.LabelControl18);
			this.recordGroupControl.Controls.Add(this.noteMemoEdit);
			this.recordGroupControl.Controls.Add(this.productionDetailsXtraTabControl);
			this.recordGroupControl.Controls.Add(this.LabelControl16);
			this.recordGroupControl.Controls.Add(this.expirationDateEdit);
			this.recordGroupControl.Controls.Add(this.addLotCodeSimpleButton);
			this.recordGroupControl.Controls.Add(this.LPNLabelSimpleButton);
			this.recordGroupControl.Controls.Add(this.largeLPNSimpleButton);
			this.recordGroupControl.Controls.Add(this.LabelControl14);
			this.recordGroupControl.Controls.Add(this.palletNumberTextEdit);
			this.recordGroupControl.Controls.Add(this.shiftLookUpEdit);
			this.recordGroupControl.Controls.Add(this.ShiftLabel);
			this.recordGroupControl.Controls.Add(this.LabelControl13);
			this.recordGroupControl.Controls.Add(this.onHandTextEdit);
			this.recordGroupControl.Controls.Add(this.lotTextEdit);
			this.recordGroupControl.Controls.Add(this.LabelControl11);
			this.recordGroupControl.Controls.Add(this.LabelControl10);
			this.recordGroupControl.Controls.Add(this.poTextEdit);
			this.recordGroupControl.Controls.Add(this.cancelSimpleButton);
			this.recordGroupControl.Controls.Add(this.editSimpleButton);
			this.recordGroupControl.Controls.Add(this.saveSimpleButton);
			this.recordGroupControl.Controls.Add(this.descriptionMemoEdit);
			this.recordGroupControl.Controls.Add(this.LabelControl5);
			this.recordGroupControl.Controls.Add(this.LabelControl4);
			this.recordGroupControl.Controls.Add(this.palletsTextEdit);
			this.recordGroupControl.Controls.Add(this.quantityTextEdit);
			this.recordGroupControl.Controls.Add(this.LabelControl3);
			this.recordGroupControl.Controls.Add(this.LabelControl2);
			this.recordGroupControl.Controls.Add(this.itemLookUpEdit);
			this.recordGroupControl.Controls.Add(this.LabelControl1);
			this.recordGroupControl.Controls.Add(this.inventoryDateEdit);
			this.recordGroupControl.Location = new System.Drawing.Point(12, 12);
			this.recordGroupControl.Name = "recordGroupControl";
			this.recordGroupControl.ShowCaption = false;
			this.recordGroupControl.Size = new System.Drawing.Size(1109, 201);
			this.recordGroupControl.TabIndex = 0;
			//
			//LabelControl18
			//
			this.LabelControl18.Location = new System.Drawing.Point(431, 95);
			this.LabelControl18.Name = "LabelControl18";
			this.LabelControl18.Size = new System.Drawing.Size(27, 13);
			this.LabelControl18.TabIndex = 30;
			this.LabelControl18.Text = "Note:";
			//
			//noteMemoEdit
			//
			this.noteMemoEdit.Location = new System.Drawing.Point(431, 114);
			this.noteMemoEdit.Name = "noteMemoEdit";
			this.noteMemoEdit.Size = new System.Drawing.Size(315, 49);
			this.noteMemoEdit.TabIndex = 8;
			//
			//productionDetailsXtraTabControl
			//
			this.productionDetailsXtraTabControl.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.productionDetailsXtraTabControl.Location = new System.Drawing.Point(752, 6);
			this.productionDetailsXtraTabControl.Name = "productionDetailsXtraTabControl";
			this.productionDetailsXtraTabControl.SelectedTabPage = this.poolDetailsXtraTabPage;
			this.productionDetailsXtraTabControl.Size = new System.Drawing.Size(357, 195);
			this.productionDetailsXtraTabControl.TabIndex = 28;
			this.productionDetailsXtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {this.poolDetailsXtraTabPage, this.projectDetailsXtraTabPage});
			//
			//poolDetailsXtraTabPage
			//
			this.poolDetailsXtraTabPage.Controls.Add(this.poolDetailsGridControl);
			this.poolDetailsXtraTabPage.Name = "poolDetailsXtraTabPage";
			this.poolDetailsXtraTabPage.Size = new System.Drawing.Size(351, 167);
			this.poolDetailsXtraTabPage.Text = "Pool Details";
			//
			//poolDetailsGridControl
			//
			this.poolDetailsGridControl.DataMember = null;
			this.poolDetailsGridControl.DataSource = this.poolDetailsXpView;
			this.poolDetailsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.poolDetailsGridControl.Location = new System.Drawing.Point(0, 0);
			this.poolDetailsGridControl.MainView = this.poolDetailsGridView;
			this.poolDetailsGridControl.Name = "poolDetailsGridControl";
			this.poolDetailsGridControl.Size = new System.Drawing.Size(351, 167);
			this.poolDetailsGridControl.TabIndex = 28;
			this.poolDetailsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.poolDetailsGridView});
			//
			//poolDetailsXpView
			//
			this.poolDetailsXpView.ObjectType = typeof(DXDAL.SPGData.ItemPoolDetails);
			this.poolDetailsXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("Oid", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemPool", DevExpress.Xpo.SortDirection.None, "[ItemPoolID.PoolCode]", false, true),
				new DevExpress.Xpo.ViewProperty("RmItem", DevExpress.Xpo.SortDirection.None, "[ItemID]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemPoolRatio", DevExpress.Xpo.SortDirection.None, "[ItemPoolRatio]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemPoolID", DevExpress.Xpo.SortDirection.None, "[ItemPoolID.Oid]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[ItemID.ItemCode]", false, true),
				new DevExpress.Xpo.ViewProperty("RMItemID", DevExpress.Xpo.SortDirection.None, "[ItemID.ItemID]", false, true)
			});
			//
			//poolDetailsGridView
			//
			this.poolDetailsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colOid, this.itemPoolGridColumn, this.rmItemGridColumn, this.colItemPoolRatio, this.itemPoolIDGridColumn, this.itemCodeGridColumn, this.itemQuantityGridColumn, this.itemQuantityUsedGridColumn, this.rmItemIDGridColumn});
			this.poolDetailsGridView.GridControl = this.poolDetailsGridControl;
			this.poolDetailsGridView.GroupCount = 1;
			this.poolDetailsGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "itemQuantityUsedGridColumn", null, "\"Pool Quantity Used = {0:N2}\"", "1")});
			this.poolDetailsGridView.Name = "poolDetailsGridView";
			this.poolDetailsGridView.OptionsSelection.MultiSelect = true;
			this.poolDetailsGridView.OptionsView.ShowDetailButtons = false;
			this.poolDetailsGridView.OptionsView.ShowGroupPanel = false;
			this.poolDetailsGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.itemPoolGridColumn, DevExpress.Data.ColumnSortOrder.Ascending)});
			//
			//colOid
			//
			this.colOid.FieldName = "Oid";
			this.colOid.Name = "colOid";
			this.colOid.OptionsColumn.AllowEdit = false;
			this.colOid.OptionsColumn.ReadOnly = true;
			//
			//itemPoolGridColumn
			//
			this.itemPoolGridColumn.Caption = "Pool Code";
			this.itemPoolGridColumn.FieldName = "ItemPool";
			this.itemPoolGridColumn.Name = "itemPoolGridColumn";
			this.itemPoolGridColumn.OptionsColumn.AllowEdit = false;
			this.itemPoolGridColumn.OptionsColumn.ReadOnly = true;
			//
			//rmItemGridColumn
			//
			this.rmItemGridColumn.FieldName = "RmItem";
			this.rmItemGridColumn.Name = "rmItemGridColumn";
			this.rmItemGridColumn.OptionsColumn.AllowEdit = false;
			this.rmItemGridColumn.OptionsColumn.ReadOnly = true;
			//
			//colItemPoolRatio
			//
			this.colItemPoolRatio.FieldName = "ItemPoolRatio";
			this.colItemPoolRatio.Name = "colItemPoolRatio";
			this.colItemPoolRatio.OptionsColumn.AllowEdit = false;
			this.colItemPoolRatio.OptionsColumn.ReadOnly = true;
			//
			//itemPoolIDGridColumn
			//
			this.itemPoolIDGridColumn.Caption = "GridColumn1";
			this.itemPoolIDGridColumn.FieldName = "ItemPoolID";
			this.itemPoolIDGridColumn.Name = "itemPoolIDGridColumn";
			//
			//itemCodeGridColumn
			//
			this.itemCodeGridColumn.Caption = "Item Code";
			this.itemCodeGridColumn.FieldName = "ItemCode";
			this.itemCodeGridColumn.Name = "itemCodeGridColumn";
			this.itemCodeGridColumn.OptionsColumn.AllowEdit = false;
			this.itemCodeGridColumn.OptionsColumn.ReadOnly = true;
			this.itemCodeGridColumn.Visible = true;
			this.itemCodeGridColumn.VisibleIndex = 0;
			//
			//itemQuantityGridColumn
			//
			this.itemQuantityGridColumn.Caption = "Item Quantity On Hand";
			this.itemQuantityGridColumn.FieldName = "ItemQuantity";
			this.itemQuantityGridColumn.Name = "itemQuantityGridColumn";
			this.itemQuantityGridColumn.OptionsColumn.AllowEdit = false;
			this.itemQuantityGridColumn.OptionsColumn.ReadOnly = true;
			this.itemQuantityGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
			this.itemQuantityGridColumn.Visible = true;
			this.itemQuantityGridColumn.VisibleIndex = 1;
			//
			//itemQuantityUsedGridColumn
			//
			this.itemQuantityUsedGridColumn.Caption = "Item Quantity Used";
			this.itemQuantityUsedGridColumn.FieldName = "itemQuantityUsedGridColumn";
			this.itemQuantityUsedGridColumn.Name = "itemQuantityUsedGridColumn";
			this.itemQuantityUsedGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
			this.itemQuantityUsedGridColumn.Visible = true;
			this.itemQuantityUsedGridColumn.VisibleIndex = 2;
			//
			//rmItemIDGridColumn
			//
			this.rmItemIDGridColumn.Caption = "GridColumn1";
			this.rmItemIDGridColumn.FieldName = "RMItemID";
			this.rmItemIDGridColumn.Name = "rmItemIDGridColumn";
			//
			//projectDetailsXtraTabPage
			//
			this.projectDetailsXtraTabPage.Controls.Add(this.projectDetailsGridControl);
			this.projectDetailsXtraTabPage.Name = "projectDetailsXtraTabPage";
			this.projectDetailsXtraTabPage.Size = new System.Drawing.Size(351, 167);
			this.projectDetailsXtraTabPage.Text = "Project Details";
			//
			//projectDetailsGridControl
			//
			this.projectDetailsGridControl.DataSource = this.productionProjectDetailXpCollection;
			this.projectDetailsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.projectDetailsGridControl.Location = new System.Drawing.Point(0, 0);
			this.projectDetailsGridControl.MainView = this.projectDetailsGridView;
			this.projectDetailsGridControl.Name = "projectDetailsGridControl";
			this.projectDetailsGridControl.Size = new System.Drawing.Size(351, 167);
			this.projectDetailsGridControl.TabIndex = 0;
			this.projectDetailsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.projectDetailsGridView});
			//
			//productionProjectDetailXpCollection
			//
			this.productionProjectDetailXpCollection.DisplayableProperties = "This;Oid;HasChanges;ProjectDetail!;ProjectDetail!Key;ProjectDetail;Production!;Pr" +
		"oduction!Key;Production;UnitsProduced;BagsProduced;PalletsProduced;IsOverrun;Pro" +
		"jectDetail.Project.Project";
			this.productionProjectDetailXpCollection.ObjectType = typeof(DXDAL.SPGData.ProductionProjectDetails);
			//
			//projectDetailsGridView
			//
			this.projectDetailsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colOid1, this.colHasChanges, this.GridColumn1, this.GridColumn2, this.GridColumn3, this.GridColumn4, this.colUnitsProduced, this.colBagsProduced, this.colPalletsProduced, this.colIsOverrun, this.colProject, this.colCustomerPO});
			this.projectDetailsGridView.GridControl = this.projectDetailsGridControl;
			this.projectDetailsGridView.Name = "projectDetailsGridView";
			this.projectDetailsGridView.OptionsView.ShowDetailButtons = false;
			this.projectDetailsGridView.OptionsView.ShowFooter = true;
			//
			//colOid1
			//
			this.colOid1.FieldName = "Oid";
			this.colOid1.Name = "colOid1";
			this.colOid1.OptionsColumn.ReadOnly = true;
			//
			//colHasChanges
			//
			this.colHasChanges.FieldName = "HasChanges";
			this.colHasChanges.Name = "colHasChanges";
			this.colHasChanges.OptionsColumn.ReadOnly = true;
			//
			//GridColumn1
			//
			this.GridColumn1.FieldName = "ProjectDetail!";
			this.GridColumn1.Name = "GridColumn1";
			this.GridColumn1.OptionsColumn.ReadOnly = true;
			//
			//GridColumn2
			//
			this.GridColumn2.FieldName = "ProjectDetail!Key";
			this.GridColumn2.Name = "GridColumn2";
			this.GridColumn2.OptionsColumn.ReadOnly = true;
			//
			//GridColumn3
			//
			this.GridColumn3.FieldName = "Production!";
			this.GridColumn3.Name = "GridColumn3";
			this.GridColumn3.OptionsColumn.ReadOnly = true;
			//
			//GridColumn4
			//
			this.GridColumn4.FieldName = "Production!Key";
			this.GridColumn4.Name = "GridColumn4";
			this.GridColumn4.OptionsColumn.ReadOnly = true;
			//
			//colUnitsProduced
			//
			this.colUnitsProduced.FieldName = "UnitsProduced";
			this.colUnitsProduced.Name = "colUnitsProduced";
			this.colUnitsProduced.OptionsColumn.ReadOnly = true;
			this.colUnitsProduced.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
			this.colUnitsProduced.Visible = true;
			this.colUnitsProduced.VisibleIndex = 2;
			//
			//colBagsProduced
			//
			this.colBagsProduced.FieldName = "BagsProduced";
			this.colBagsProduced.Name = "colBagsProduced";
			this.colBagsProduced.OptionsColumn.ReadOnly = true;
			this.colBagsProduced.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
			this.colBagsProduced.Visible = true;
			this.colBagsProduced.VisibleIndex = 3;
			//
			//colPalletsProduced
			//
			this.colPalletsProduced.FieldName = "PalletsProduced";
			this.colPalletsProduced.Name = "colPalletsProduced";
			this.colPalletsProduced.OptionsColumn.ReadOnly = true;
			this.colPalletsProduced.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
			this.colPalletsProduced.Visible = true;
			this.colPalletsProduced.VisibleIndex = 4;
			//
			//colIsOverrun
			//
			this.colIsOverrun.FieldName = "IsOverrun";
			this.colIsOverrun.Name = "colIsOverrun";
			this.colIsOverrun.OptionsColumn.ReadOnly = true;
			this.colIsOverrun.Visible = true;
			this.colIsOverrun.VisibleIndex = 5;
			//
			//colProject
			//
			this.colProject.Caption = "Project";
			this.colProject.FieldName = "ProjectDetail.Project.Project";
			this.colProject.Name = "colProject";
			this.colProject.OptionsColumn.ReadOnly = true;
			this.colProject.Visible = true;
			this.colProject.VisibleIndex = 0;
			//
			//colCustomerPO
			//
			this.colCustomerPO.CustomizationCaption = "Customer PO";
			this.colCustomerPO.FieldName = "ProjectDetail.CustomerPO";
			this.colCustomerPO.Name = "colCustomerPO";
			this.colCustomerPO.OptionsColumn.AllowEdit = false;
			this.colCustomerPO.OptionsColumn.ReadOnly = true;
			this.colCustomerPO.Visible = true;
			this.colCustomerPO.VisibleIndex = 1;
			//
			//LabelControl16
			//
			this.LabelControl16.Location = new System.Drawing.Point(111, 95);
			this.LabelControl16.Name = "LabelControl16";
			this.LabelControl16.Size = new System.Drawing.Size(78, 13);
			this.LabelControl16.TabIndex = 26;
			this.LabelControl16.Text = "Expiration Date:";
			//
			//expirationDateEdit
			//
			this.expirationDateEdit.EditValue = null;
			this.expirationDateEdit.Location = new System.Drawing.Point(110, 114);
			this.expirationDateEdit.Name = "expirationDateEdit";
			this.expirationDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
			this.expirationDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.expirationDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton()});
			this.expirationDateEdit.Properties.DisplayFormat.FormatString = "MMMM dd, yyyy";
			this.expirationDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.expirationDateEdit.Properties.EditFormat.FormatString = "MMMM dd, yyyy";
			this.expirationDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.expirationDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
			this.expirationDateEdit.Size = new System.Drawing.Size(150, 20);
			this.expirationDateEdit.TabIndex = 6;
			//
			//addLotCodeSimpleButton
			//
			this.addLotCodeSimpleButton.Location = new System.Drawing.Point(270, 140);
			this.addLotCodeSimpleButton.Name = "addLotCodeSimpleButton";
			this.addLotCodeSimpleButton.Size = new System.Drawing.Size(151, 23);
			this.addLotCodeSimpleButton.TabIndex = 8;
			this.addLotCodeSimpleButton.Text = "&Add Lot Code";
			//
			//LPNLabelSimpleButton
			//
			this.LPNLabelSimpleButton.Location = new System.Drawing.Point(50, 169);
			this.LPNLabelSimpleButton.Name = "LPNLabelSimpleButton";
			this.LPNLabelSimpleButton.Size = new System.Drawing.Size(131, 23);
			this.LPNLabelSimpleButton.TabIndex = 12;
			this.LPNLabelSimpleButton.Text = "Save && Print Short &LPN";
			//
			//largeLPNSimpleButton
			//
			this.largeLPNSimpleButton.Location = new System.Drawing.Point(187, 169);
			this.largeLPNSimpleButton.Name = "largeLPNSimpleButton";
			this.largeLPNSimpleButton.Size = new System.Drawing.Size(131, 23);
			this.largeLPNSimpleButton.TabIndex = 13;
			this.largeLPNSimpleButton.Text = "Save && &Print Large LPN";
			//
			//LabelControl14
			//
			this.LabelControl14.Location = new System.Drawing.Point(325, 5);
			this.LabelControl14.Name = "LabelControl14";
			this.LabelControl14.Size = new System.Drawing.Size(41, 13);
			this.LabelControl14.TabIndex = 21;
			this.LabelControl14.Text = "Pallet #:";
			//
			//palletNumberTextEdit
			//
			this.palletNumberTextEdit.Location = new System.Drawing.Point(324, 24);
			this.palletNumberTextEdit.Name = "palletNumberTextEdit";
			this.palletNumberTextEdit.Properties.ReadOnly = true;
			this.palletNumberTextEdit.Size = new System.Drawing.Size(100, 20);
			this.palletNumberTextEdit.TabIndex = 11;
			this.palletNumberTextEdit.TabStop = false;
			//
			//shiftLookUpEdit
			//
			this.shiftLookUpEdit.Location = new System.Drawing.Point(4, 114);
			this.shiftLookUpEdit.Name = "shiftLookUpEdit";
			this.shiftLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.shiftLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.shiftLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ShiftID", "Shift ID", 59, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ShiftName", "Shift Name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)
			});
			this.shiftLookUpEdit.Properties.DataSource = this.shiftXPView;
			this.shiftLookUpEdit.Properties.DisplayMember = "ShiftName";
			this.shiftLookUpEdit.Properties.NullText = "[Select A Shift]";
			this.shiftLookUpEdit.Properties.ValueMember = "ShiftID";
			this.shiftLookUpEdit.Size = new System.Drawing.Size(100, 20);
			this.shiftLookUpEdit.TabIndex = 5;
			this.shiftLookUpEdit.ToolTip = "Use Ctrl+Del to clear filter";
			//
			//shiftXPView
			//
			this.shiftXPView.ObjectType = typeof(DXDAL.SPGData.Shifts);
			this.shiftXPView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("ShiftID", DevExpress.Xpo.SortDirection.None, "[ShiftID]", false, true),
				new DevExpress.Xpo.ViewProperty("ShiftName", DevExpress.Xpo.SortDirection.None, "[ShiftName]", false, true)
			});
			//
			//ShiftLabel
			//
			this.ShiftLabel.Location = new System.Drawing.Point(4, 94);
			this.ShiftLabel.Name = "ShiftLabel";
			this.ShiftLabel.Size = new System.Drawing.Size(26, 13);
			this.ShiftLabel.TabIndex = 19;
			this.ShiftLabel.Text = "Shift:";
			//
			//LabelControl13
			//
			this.LabelControl13.Location = new System.Drawing.Point(325, 50);
			this.LabelControl13.Name = "LabelControl13";
			this.LabelControl13.Size = new System.Drawing.Size(46, 13);
			this.LabelControl13.TabIndex = 17;
			this.LabelControl13.Text = "On Hand:";
			//
			//onHandTextEdit
			//
			this.onHandTextEdit.Location = new System.Drawing.Point(324, 69);
			this.onHandTextEdit.Name = "onHandTextEdit";
			this.onHandTextEdit.Properties.ReadOnly = true;
			this.onHandTextEdit.Size = new System.Drawing.Size(100, 20);
			this.onHandTextEdit.TabIndex = 10;
			this.onHandTextEdit.TabStop = false;
			//
			//lotTextEdit
			//
			this.lotTextEdit.Location = new System.Drawing.Point(266, 114);
			this.lotTextEdit.Name = "lotTextEdit";
			this.lotTextEdit.Size = new System.Drawing.Size(158, 20);
			this.lotTextEdit.TabIndex = 7;
			//
			//LabelControl11
			//
			this.LabelControl11.Location = new System.Drawing.Point(266, 95);
			this.LabelControl11.Name = "LabelControl11";
			this.LabelControl11.Size = new System.Drawing.Size(19, 13);
			this.LabelControl11.TabIndex = 10;
			this.LabelControl11.Text = "Lot:";
			//
			//LabelControl10
			//
			this.LabelControl10.Location = new System.Drawing.Point(218, 50);
			this.LabelControl10.Name = "LabelControl10";
			this.LabelControl10.Size = new System.Drawing.Size(18, 13);
			this.LabelControl10.TabIndex = 8;
			this.LabelControl10.Text = "PO:";
			//
			//poTextEdit
			//
			this.poTextEdit.Location = new System.Drawing.Point(218, 69);
			this.poTextEdit.Name = "poTextEdit";
			this.poTextEdit.Size = new System.Drawing.Size(100, 20);
			this.poTextEdit.TabIndex = 4;
			//
			//cancelSimpleButton
			//
			this.cancelSimpleButton.Location = new System.Drawing.Point(598, 169);
			this.cancelSimpleButton.Name = "cancelSimpleButton";
			this.cancelSimpleButton.Size = new System.Drawing.Size(131, 23);
			this.cancelSimpleButton.TabIndex = 16;
			this.cancelSimpleButton.Text = "Ca&ncel";
			//
			//editSimpleButton
			//
			this.editSimpleButton.Location = new System.Drawing.Point(461, 169);
			this.editSimpleButton.Name = "editSimpleButton";
			this.editSimpleButton.Size = new System.Drawing.Size(131, 23);
			this.editSimpleButton.TabIndex = 15;
			this.editSimpleButton.Text = "&Edit Entry";
			//
			//saveSimpleButton
			//
			this.saveSimpleButton.Location = new System.Drawing.Point(324, 169);
			this.saveSimpleButton.Name = "saveSimpleButton";
			this.saveSimpleButton.Size = new System.Drawing.Size(131, 23);
			this.saveSimpleButton.TabIndex = 14;
			this.saveSimpleButton.Text = "&Save Entry";
			//
			//descriptionMemoEdit
			//
			this.descriptionMemoEdit.Location = new System.Drawing.Point(431, 24);
			this.descriptionMemoEdit.Name = "descriptionMemoEdit";
			this.descriptionMemoEdit.Size = new System.Drawing.Size(315, 65);
			this.descriptionMemoEdit.TabIndex = 9;
			this.descriptionMemoEdit.TabStop = false;
			//
			//LabelControl5
			//
			this.LabelControl5.Location = new System.Drawing.Point(431, 5);
			this.LabelControl5.Name = "LabelControl5";
			this.LabelControl5.Size = new System.Drawing.Size(82, 13);
			this.LabelControl5.TabIndex = 12;
			this.LabelControl5.Text = "Item Description:";
			//
			//LabelControl4
			//
			this.LabelControl4.Location = new System.Drawing.Point(5, 50);
			this.LabelControl4.Name = "LabelControl4";
			this.LabelControl4.Size = new System.Drawing.Size(46, 13);
			this.LabelControl4.TabIndex = 4;
			this.LabelControl4.Text = "Quantity:";
			//
			//palletsTextEdit
			//
			this.palletsTextEdit.Location = new System.Drawing.Point(110, 69);
			this.palletsTextEdit.Name = "palletsTextEdit";
			this.palletsTextEdit.Size = new System.Drawing.Size(100, 20);
			this.palletsTextEdit.TabIndex = 3;
			//
			//quantityTextEdit
			//
			this.quantityTextEdit.Location = new System.Drawing.Point(4, 69);
			this.quantityTextEdit.Name = "quantityTextEdit";
			this.quantityTextEdit.Size = new System.Drawing.Size(100, 20);
			this.quantityTextEdit.TabIndex = 2;
			//
			//LabelControl3
			//
			this.LabelControl3.Location = new System.Drawing.Point(161, 5);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(37, 13);
			this.LabelControl3.TabIndex = 2;
			this.LabelControl3.Text = "Item #:";
			//
			//LabelControl2
			//
			this.LabelControl2.Location = new System.Drawing.Point(5, 5);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(27, 13);
			this.LabelControl2.TabIndex = 0;
			this.LabelControl2.Text = "Date:";
			//
			//itemLookUpEdit
			//
			this.itemLookUpEdit.Location = new System.Drawing.Point(161, 24);
			this.itemLookUpEdit.Name = "itemLookUpEdit";
			this.itemLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.itemLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 59, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCustomerID", "Item Customer ID", 95, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)
			});
			this.itemLookUpEdit.Properties.DataSource = this.itemsXPView;
			this.itemLookUpEdit.Properties.DisplayMember = "ItemCode";
			this.itemLookUpEdit.Properties.NullText = "[Select A Item]";
			this.itemLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.itemLookUpEdit.Properties.ValueMember = "ItemID";
			this.itemLookUpEdit.Size = new System.Drawing.Size(157, 20);
			this.itemLookUpEdit.TabIndex = 1;
			//
			//itemsXPView
			//
			this.itemsXPView.CriteriaString = "([ItemType] = 'FG' Or [ItemType] = 'IG') And [Inactive] = False";
			this.itemsXPView.ObjectType = typeof(DXDAL.SPGData.Items);
			this.itemsXPView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[ItemID]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.Ascending, "[ItemCode]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemCustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID]", false, true)
			});
			//
			//LabelControl1
			//
			this.LabelControl1.Location = new System.Drawing.Point(111, 50);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(35, 13);
			this.LabelControl1.TabIndex = 6;
			this.LabelControl1.Text = "Pallets:";
			//
			//inventoryDateEdit
			//
			this.inventoryDateEdit.EditValue = null;
			this.inventoryDateEdit.Location = new System.Drawing.Point(5, 24);
			this.inventoryDateEdit.Name = "inventoryDateEdit";
			this.inventoryDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
			this.inventoryDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.inventoryDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton()});
			this.inventoryDateEdit.Properties.DisplayFormat.FormatString = "g";
			this.inventoryDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.inventoryDateEdit.Properties.EditFormat.FormatString = "g";
			this.inventoryDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.inventoryDateEdit.Properties.Mask.EditMask = "g";
			this.inventoryDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
			this.inventoryDateEdit.Size = new System.Drawing.Size(150, 20);
			this.inventoryDateEdit.TabIndex = 0;
			//
			//poolDetailsXpCollection
			//
			this.poolDetailsXpCollection.DisplayableProperties = "This;Oid;ItemPoolID!;ItemPoolID!Key;ItemPoolID;PoolBomFiniGoodID!;PoolBomFiniGood" +
		"ID!Key;PoolBomFiniGoodID;PoolBomQuantity;ScrapFactor;ItemPoolID.Details.ItemID.I" +
		"temCode";
			this.poolDetailsXpCollection.ObjectType = typeof(DXDAL.SPGData.PoolBom);
			//
			//filtersGroupControl
			//
			this.filtersGroupControl.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.filtersGroupControl.Controls.Add(this.filterByPalletSimpleButton);
			this.filtersGroupControl.Controls.Add(this.LabelControl15);
			this.filtersGroupControl.Controls.Add(this.LPNFilterTextEdit);
			this.filtersGroupControl.Controls.Add(this.LabelControl17);
			this.filtersGroupControl.Controls.Add(this.shiftFilterLookUpEdit);
			this.filtersGroupControl.Controls.Add(this.LabelControl12);
			this.filtersGroupControl.Controls.Add(this.lotFilterTextEdit);
			this.filtersGroupControl.Controls.Add(this.filterSimpleButton);
			this.filtersGroupControl.Controls.Add(this.clearSimpleButton);
			this.filtersGroupControl.Controls.Add(this.itemFilterLookUpEdit);
			this.filtersGroupControl.Controls.Add(this.customerFilterLookUpEdit);
			this.filtersGroupControl.Controls.Add(this.LabelControl9);
			this.filtersGroupControl.Controls.Add(this.LabelControl8);
			this.filtersGroupControl.Controls.Add(this.LabelControl7);
			this.filtersGroupControl.Controls.Add(this.LabelControl6);
			this.filtersGroupControl.Controls.Add(this.toFilterDateEdit);
			this.filtersGroupControl.Controls.Add(this.fromFilterDateEdit);
			this.filtersGroupControl.Location = new System.Drawing.Point(12, 219);
			this.filtersGroupControl.Name = "filtersGroupControl";
			this.filtersGroupControl.Size = new System.Drawing.Size(1109, 110);
			this.filtersGroupControl.TabIndex = 0;
			this.filtersGroupControl.Text = "Filters and Display";
			//
			//filterByPalletSimpleButton
			//
			this.filterByPalletSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.filterByPalletSimpleButton.Location = new System.Drawing.Point(611, 82);
			this.filterByPalletSimpleButton.Name = "filterByPalletSimpleButton";
			this.filterByPalletSimpleButton.Size = new System.Drawing.Size(102, 23);
			this.filterByPalletSimpleButton.TabIndex = 26;
			this.filterByPalletSimpleButton.Text = "Filter By &Pallet";
			//
			//LabelControl15
			//
			this.LabelControl15.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LabelControl15.Location = new System.Drawing.Point(816, 37);
			this.LabelControl15.Name = "LabelControl15";
			this.LabelControl15.Size = new System.Drawing.Size(62, 13);
			this.LabelControl15.TabIndex = 15;
			this.LabelControl15.Text = "LPN Number:";
			//
			//LPNFilterTextEdit
			//
			this.LPNFilterTextEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LPNFilterTextEdit.Location = new System.Drawing.Point(816, 56);
			this.LPNFilterTextEdit.Name = "LPNFilterTextEdit";
			this.LPNFilterTextEdit.Size = new System.Drawing.Size(109, 20);
			this.LPNFilterTextEdit.TabIndex = 24;
			//
			//LabelControl17
			//
			this.LabelControl17.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LabelControl17.Location = new System.Drawing.Point(619, 37);
			this.LabelControl17.Name = "LabelControl17";
			this.LabelControl17.Size = new System.Drawing.Size(26, 13);
			this.LabelControl17.TabIndex = 12;
			this.LabelControl17.Text = "Shift:";
			//
			//shiftFilterLookUpEdit
			//
			this.shiftFilterLookUpEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.shiftFilterLookUpEdit.Location = new System.Drawing.Point(651, 30);
			this.shiftFilterLookUpEdit.Name = "shiftFilterLookUpEdit";
			this.shiftFilterLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.shiftFilterLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.shiftFilterLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ShiftID", "Shift ID", 59, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ShiftName", "Shift Name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)
			});
			this.shiftFilterLookUpEdit.Properties.DataSource = this.shiftXPView;
			this.shiftFilterLookUpEdit.Properties.DisplayMember = "ShiftName";
			this.shiftFilterLookUpEdit.Properties.NullText = "[Select A Shift]";
			this.shiftFilterLookUpEdit.Properties.ValueMember = "ShiftID";
			this.shiftFilterLookUpEdit.Size = new System.Drawing.Size(159, 20);
			this.shiftFilterLookUpEdit.TabIndex = 20;
			this.shiftFilterLookUpEdit.ToolTip = "Use Ctrl+Del to clear filter";
			//
			//LabelControl12
			//
			this.LabelControl12.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LabelControl12.Location = new System.Drawing.Point(619, 59);
			this.LabelControl12.Name = "LabelControl12";
			this.LabelControl12.Size = new System.Drawing.Size(19, 13);
			this.LabelControl12.TabIndex = 8;
			this.LabelControl12.Text = "Lot:";
			//
			//lotFilterTextEdit
			//
			this.lotFilterTextEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lotFilterTextEdit.Location = new System.Drawing.Point(651, 56);
			this.lotFilterTextEdit.Name = "lotFilterTextEdit";
			this.lotFilterTextEdit.Size = new System.Drawing.Size(159, 20);
			this.lotFilterTextEdit.TabIndex = 22;
			//
			//filterSimpleButton
			//
			this.filterSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.filterSimpleButton.Location = new System.Drawing.Point(503, 82);
			this.filterSimpleButton.Name = "filterSimpleButton";
			this.filterSimpleButton.Size = new System.Drawing.Size(102, 23);
			this.filterSimpleButton.TabIndex = 25;
			this.filterSimpleButton.Text = "&Filter";
			//
			//clearSimpleButton
			//
			this.clearSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.clearSimpleButton.Location = new System.Drawing.Point(395, 82);
			this.clearSimpleButton.Name = "clearSimpleButton";
			this.clearSimpleButton.Size = new System.Drawing.Size(102, 23);
			this.clearSimpleButton.TabIndex = 23;
			this.clearSimpleButton.Text = "&Clear Filter";
			//
			//itemFilterLookUpEdit
			//
			this.itemFilterLookUpEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.itemFilterLookUpEdit.Location = new System.Drawing.Point(454, 56);
			this.itemFilterLookUpEdit.Name = "itemFilterLookUpEdit";
			this.itemFilterLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.itemFilterLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.itemFilterLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 59, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCustomerID", "Item Customer ID", 95, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)
			});
			this.itemFilterLookUpEdit.Properties.DataSource = this.itemsFilterXPView;
			this.itemFilterLookUpEdit.Properties.DisplayMember = "ItemCode";
			this.itemFilterLookUpEdit.Properties.NullText = "[Select A Item]";
			this.itemFilterLookUpEdit.Properties.ValueMember = "ItemID";
			this.itemFilterLookUpEdit.Size = new System.Drawing.Size(152, 20);
			this.itemFilterLookUpEdit.TabIndex = 21;
			this.itemFilterLookUpEdit.ToolTip = "Use Ctrl+Del to clear filter";
			//
			//itemsFilterXPView
			//
			this.itemsFilterXPView.CriteriaString = "[ItemType] = 'FG' Or [ItemType] = 'IG'";
			this.itemsFilterXPView.ObjectType = typeof(DXDAL.SPGData.Items);
			this.itemsFilterXPView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[ItemID]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.Ascending, "[ItemCode]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemCustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID]", false, true),
				new DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID.CustomerID]", false, true)
			});
			//
			//customerFilterLookUpEdit
			//
			this.customerFilterLookUpEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.customerFilterLookUpEdit.Location = new System.Drawing.Point(240, 56);
			this.customerFilterLookUpEdit.Name = "customerFilterLookUpEdit";
			this.customerFilterLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.customerFilterLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.customerFilterLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerID", "Customer ID", 83, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Customer Name", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Inactive", "Inactive", 49, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)
			});
			this.customerFilterLookUpEdit.Properties.DataSource = this.customersXPView;
			this.customerFilterLookUpEdit.Properties.DisplayMember = "CustomerName";
			this.customerFilterLookUpEdit.Properties.NullText = "[Select A Customer]";
			this.customerFilterLookUpEdit.Properties.ValueMember = "CustomerID";
			this.customerFilterLookUpEdit.Size = new System.Drawing.Size(160, 20);
			this.customerFilterLookUpEdit.TabIndex = 19;
			this.customerFilterLookUpEdit.ToolTip = "Use Ctrl+Del to clear filter";
			//
			//customersXPView
			//
			this.customersXPView.CriteriaString = "[Inactive] = False";
			this.customersXPView.ObjectType = typeof(DXDAL.SPGData.Customers);
			this.customersXPView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[CustomerID]", false, true),
				new DevExpress.Xpo.ViewProperty("CustomerName", DevExpress.Xpo.SortDirection.Ascending, "[CustomerName]", false, true),
				new DevExpress.Xpo.ViewProperty("Inactive", DevExpress.Xpo.SortDirection.None, "[Inactive]", false, true)
			});
			//
			//LabelControl9
			//
			this.LabelControl9.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LabelControl9.Location = new System.Drawing.Point(422, 59);
			this.LabelControl9.Name = "LabelControl9";
			this.LabelControl9.Size = new System.Drawing.Size(26, 13);
			this.LabelControl9.TabIndex = 6;
			this.LabelControl9.Text = "Item:";
			//
			//LabelControl8
			//
			this.LabelControl8.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LabelControl8.Location = new System.Drawing.Point(422, 33);
			this.LabelControl8.Name = "LabelControl8";
			this.LabelControl8.Size = new System.Drawing.Size(16, 13);
			this.LabelControl8.TabIndex = 2;
			this.LabelControl8.Text = "To:";
			//
			//LabelControl7
			//
			this.LabelControl7.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LabelControl7.Location = new System.Drawing.Point(184, 59);
			this.LabelControl7.Name = "LabelControl7";
			this.LabelControl7.Size = new System.Drawing.Size(50, 13);
			this.LabelControl7.TabIndex = 4;
			this.LabelControl7.Text = "Customer:";
			//
			//LabelControl6
			//
			this.LabelControl6.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LabelControl6.Location = new System.Drawing.Point(184, 33);
			this.LabelControl6.Name = "LabelControl6";
			this.LabelControl6.Size = new System.Drawing.Size(28, 13);
			this.LabelControl6.TabIndex = 0;
			this.LabelControl6.Text = "From:";
			//
			//toFilterDateEdit
			//
			this.toFilterDateEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.toFilterDateEdit.EditValue = null;
			this.toFilterDateEdit.Location = new System.Drawing.Point(454, 30);
			this.toFilterDateEdit.Name = "toFilterDateEdit";
			this.toFilterDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.toFilterDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton()});
			this.toFilterDateEdit.Properties.DisplayFormat.FormatString = "D";
			this.toFilterDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.toFilterDateEdit.Properties.EditFormat.FormatString = "D";
			this.toFilterDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.toFilterDateEdit.Properties.Mask.EditMask = "g";
			this.toFilterDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
			this.toFilterDateEdit.Properties.NullText = "[Select A To Date]";
			this.toFilterDateEdit.Size = new System.Drawing.Size(152, 20);
			this.toFilterDateEdit.TabIndex = 18;
			//
			//fromFilterDateEdit
			//
			this.fromFilterDateEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.fromFilterDateEdit.EditValue = null;
			this.fromFilterDateEdit.Location = new System.Drawing.Point(240, 30);
			this.fromFilterDateEdit.Name = "fromFilterDateEdit";
			this.fromFilterDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.fromFilterDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton()});
			this.fromFilterDateEdit.Properties.DisplayFormat.FormatString = "D";
			this.fromFilterDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.fromFilterDateEdit.Properties.EditFormat.FormatString = "D";
			this.fromFilterDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.fromFilterDateEdit.Properties.Mask.EditMask = "g";
			this.fromFilterDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
			this.fromFilterDateEdit.Properties.NullText = "[Select A From Date]";
			this.fromFilterDateEdit.Size = new System.Drawing.Size(160, 20);
			this.fromFilterDateEdit.TabIndex = 17;
			//
			//InventoryXtraForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1133, 640);
			this.Controls.Add(this.inventoryGridControl);
			this.Controls.Add(this.filtersGroupControl);
			this.Controls.Add(this.recordGroupControl);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "InventoryXtraForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Production Entries";
			((System.ComponentModel.ISupportInitialize)this.inventoryGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryXPView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.deleteRepositoryItemButtonEdit).EndInit();
			((System.ComponentModel.ISupportInitialize)this.recordGroupControl).EndInit();
			this.recordGroupControl.ResumeLayout(false);
			this.recordGroupControl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.noteMemoEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionDetailsXtraTabControl).EndInit();
			this.productionDetailsXtraTabControl.ResumeLayout(false);
			this.poolDetailsXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.poolDetailsGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.poolDetailsXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.poolDetailsGridView).EndInit();
			this.projectDetailsXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.projectDetailsGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionProjectDetailXpCollection).EndInit();
			((System.ComponentModel.ISupportInitialize)this.projectDetailsGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.expirationDateEdit.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.expirationDateEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.palletNumberTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shiftLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shiftXPView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.onHandTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.lotTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.poTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.descriptionMemoEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.palletsTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.quantityTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemsXPView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryDateEdit.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryDateEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.poolDetailsXpCollection).EndInit();
			((System.ComponentModel.ISupportInitialize)this.filtersGroupControl).EndInit();
			this.filtersGroupControl.ResumeLayout(false);
			this.filtersGroupControl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.LPNFilterTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shiftFilterLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.lotFilterTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemFilterLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemsFilterXPView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customerFilterLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customersXPView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.toFilterDateEdit.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.toFilterDateEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.fromFilterDateEdit.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.fromFilterDateEdit.Properties).EndInit();
			this.ResumeLayout(false);

//INSTANT C# NOTE: Converted design-time event handler wireups:
		addLotCodeSimpleButton.Click += new System.EventHandler(addLotCodeSimpleButton_Click);
		cancelSimpleButton.Click += new System.EventHandler(cancelSimpleButton_Click);
		clearSimpleButton.Click += new System.EventHandler(clearSimpleButton_Click);
		customerFilterLookUpEdit.Validated += new System.EventHandler(customerFilterLookUpEdit_Validated);
		deleteRepositoryItemButtonEdit.Click += new System.EventHandler(deleteRepositoryItemButtonEdit_Click);
		editSimpleButton.Click += new System.EventHandler(editSimpleButton_Click);
		filterByPalletSimpleButton.Click += new System.EventHandler(filterByPalletSimpleButton_Click);
		filterSimpleButton.Click += new System.EventHandler(filterSimpleButton_Click);
		inventoryGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(inventoryGridView_CustomColumnDisplayText);
		this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(InventoryXtraForm_FormClosing);
		base.Load += new System.EventHandler(InventoryXtraForm_Load);
		itemLookUpEdit.ProcessNewValue += new DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(itemLookUpEdit_ProcessNewValue);
		itemLookUpEdit.Validated += new System.EventHandler(itemLookUpEdit_Validated);
		largeLPNSimpleButton.Click += new System.EventHandler(largeLPNSimpleButton_Click);
		poolDetailsGridView.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(poolDetailsGridView_CustomDrawGroupRow);
		poolDetailsGridView.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(poolDetailsGridView_CustomSummaryCalculate);
		poolDetailsGridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(poolDetailsGridView_CustomUnboundColumnData);
		poolDetailsGridView.ShownEditor += new System.EventHandler(poolDetailsGridView_ShownEditor);
		projectDetailsGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(projectDetailsGridView_CellValueChanged);
		quantityTextEdit.Validated += new System.EventHandler(quantityTextEdit_Validated);
		saveSimpleButton.Click += new System.EventHandler(saveSimpleButton_Click);
		LPNLabelSimpleButton.Click += new System.EventHandler(ShortLPNLabelSimpleButton_Click);
		inventoryGridView.FilterEditorCreated += new DevExpress.XtraGrid.Views.Base.FilterControlEventHandler(inventoryGridView_FilterEditorCreated);
	}
		internal DevExpress.XtraEditors.GroupControl recordGroupControl;
		internal DevExpress.XtraEditors.GroupControl filtersGroupControl;
		internal DevExpress.XtraEditors.SimpleButton cancelSimpleButton;
		internal DevExpress.XtraEditors.SimpleButton editSimpleButton;
		internal DevExpress.XtraEditors.SimpleButton saveSimpleButton;
		internal DevExpress.XtraEditors.MemoEdit descriptionMemoEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl5;
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		internal DevExpress.XtraEditors.TextEdit palletsTextEdit;
		internal DevExpress.XtraEditors.TextEdit quantityTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.LookUpEdit itemLookUpEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.DateEdit inventoryDateEdit;
		internal DevExpress.XtraEditors.SimpleButton filterSimpleButton;
		internal DevExpress.XtraEditors.SimpleButton clearSimpleButton;
		internal DevExpress.XtraEditors.LookUpEdit itemFilterLookUpEdit;
		internal DevExpress.XtraEditors.LookUpEdit customerFilterLookUpEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl9;
		internal DevExpress.XtraEditors.LabelControl LabelControl8;
		internal DevExpress.XtraEditors.LabelControl LabelControl7;
		internal DevExpress.XtraEditors.LabelControl LabelControl6;
		internal DevExpress.XtraEditors.DateEdit toFilterDateEdit;
		internal DevExpress.XtraEditors.DateEdit fromFilterDateEdit;
		internal DevExpress.XtraGrid.GridControl inventoryGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView inventoryGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn deleteGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit deleteRepositoryItemButtonEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn idGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn customerGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn dateGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn itemGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn descriptionGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn quantityGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn palletsGridColumn;
		internal DevExpress.XtraEditors.TextEdit poTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl10;
		internal DevExpress.XtraGrid.Columns.GridColumn poGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn lotGridColumn;
		internal DevExpress.XtraEditors.TextEdit lotTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl11;
		internal DevExpress.XtraEditors.LabelControl LabelControl12;
		internal DevExpress.XtraEditors.TextEdit lotFilterTextEdit;
		internal DevExpress.Xpo.XPView inventoryXPView;
		internal DevExpress.Xpo.XPView itemsXPView;
		internal DevExpress.Xpo.XPView itemsFilterXPView;
		internal DevExpress.Xpo.XPView customersXPView;
		internal DevExpress.XtraEditors.LabelControl LabelControl13;
		internal DevExpress.XtraEditors.TextEdit onHandTextEdit;
		private DevExpress.XtraEditors.LabelControl ShiftLabel;
		internal DevExpress.XtraEditors.LookUpEdit shiftLookUpEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl17;
		internal DevExpress.XtraEditors.LookUpEdit shiftFilterLookUpEdit;
		internal DevExpress.Xpo.XPView shiftXPView;
		internal DevExpress.XtraGrid.Columns.GridColumn shiftGridColumn;
		internal DevExpress.XtraEditors.LabelControl LabelControl14;
		internal DevExpress.XtraEditors.TextEdit palletNumberTextEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn palletGridColumn;
		internal DevExpress.XtraEditors.SimpleButton largeLPNSimpleButton;
		internal DevExpress.XtraEditors.SimpleButton LPNLabelSimpleButton;
		internal DevExpress.XtraEditors.SimpleButton addLotCodeSimpleButton;
		internal DevExpress.XtraEditors.LabelControl LabelControl15;
		internal DevExpress.XtraEditors.TextEdit LPNFilterTextEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn LPNGridColumn;
		internal DevExpress.XtraEditors.SimpleButton filterByPalletSimpleButton;
		internal DevExpress.XtraEditors.LabelControl LabelControl16;
		internal DevExpress.XtraEditors.DateEdit expirationDateEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn expirationDateGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn expirationDateFormatGridColumn;
		internal DevExpress.Xpo.XPCollection poolDetailsXpCollection;
		internal DevExpress.Xpo.XPView poolDetailsXpView;
		internal DevExpress.XtraTab.XtraTabControl productionDetailsXtraTabControl;
		internal DevExpress.XtraTab.XtraTabPage poolDetailsXtraTabPage;
		internal DevExpress.XtraGrid.GridControl poolDetailsGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView poolDetailsGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn colOid;
		internal DevExpress.XtraGrid.Columns.GridColumn itemPoolGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn rmItemGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn colItemPoolRatio;
		internal DevExpress.XtraGrid.Columns.GridColumn itemPoolIDGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn itemCodeGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn itemQuantityGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn itemQuantityUsedGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn rmItemIDGridColumn;
		internal DevExpress.XtraTab.XtraTabPage projectDetailsXtraTabPage;
		internal DevExpress.XtraGrid.GridControl projectDetailsGridControl;
		internal DevExpress.Xpo.XPCollection productionProjectDetailXpCollection;
		internal DevExpress.XtraGrid.Views.Grid.GridView projectDetailsGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn colOid1;
		internal DevExpress.XtraGrid.Columns.GridColumn colHasChanges;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn2;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn3;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn4;
		internal DevExpress.XtraGrid.Columns.GridColumn colUnitsProduced;
		internal DevExpress.XtraGrid.Columns.GridColumn colBagsProduced;
		internal DevExpress.XtraGrid.Columns.GridColumn colPalletsProduced;
		internal DevExpress.XtraGrid.Columns.GridColumn colIsOverrun;
		internal DevExpress.XtraGrid.Columns.GridColumn colProject;
		internal DevExpress.XtraGrid.Columns.GridColumn colCustomerPO;
		internal DevExpress.XtraEditors.LabelControl LabelControl18;
		internal DevExpress.XtraEditors.MemoEdit noteMemoEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn noteGridColumn;
	}

}