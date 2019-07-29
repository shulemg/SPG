using DevExpress.XtraEditors;
using DevExpress.Data.Filtering;
using DXDAL.SPGData;
using DevExpress.Xpo;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;

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
	public partial class InventoryAdjustmentXtraForm : DevExpress.XtraEditors.XtraForm
	{
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryAdjustmentXtraForm));
            this.adjustmentGridControl = new DevExpress.XtraGrid.GridControl();
            this.inventoryXPView = new DevExpress.Xpo.XPView(this.components);
            this.adjustmentGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.deleteGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deleteRepositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.idGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customerGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.descriptionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.locationCodeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.originalQuantityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.newQtyGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOriginalLot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNewLot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.adjustmentGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reasonGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.reasonRepositoryItemMemoExEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.itemIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customerIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.locationGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.filtersGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.filterSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.clearSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.itemFilterLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.itemsFilterXPView = new DevExpress.Xpo.XPView(this.components);
            this.customerFilterLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.customersFilterXPView = new DevExpress.Xpo.XPView(this.components);
            this.LabelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.toFilterDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.fromFilterDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.recordGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.LPNgroupControl = new DevExpress.XtraEditors.GroupControl();
            this.LPNTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ExprationDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.AddToPalletSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.AddPalletsSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.LotTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.QtyTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AddLpnSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.LabelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.locationLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.locationsXpView = new DevExpress.Xpo.XPView(this.components);
            this.LabelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.newLotTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.lpnLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.lpnXpView = new DevExpress.Xpo.XPView(this.components);
            this.LabelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.reasonMemoExEdit = new DevExpress.XtraEditors.MemoExEdit();
            this.LabelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.newQtyTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.originalQtyTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.customerLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.customersXPView = new DevExpress.Xpo.XPView(this.components);
            this.cancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.editSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.descriptionMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.itemLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.itemsXPView = new DevExpress.Xpo.XPView(this.components);
            this.adjustmentDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.originalLotLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.LotXpView = new DevExpress.Xpo.XPView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.adjustmentGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryXPView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustmentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteRepositoryItemButtonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonRepositoryItemMemoExEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtersGroupControl)).BeginInit();
            this.filtersGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemFilterLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsFilterXPView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerFilterLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersFilterXPView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toFilterDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toFilterDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromFilterDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromFilterDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordGroupControl)).BeginInit();
            this.recordGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LPNgroupControl)).BeginInit();
            this.LPNgroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LPNTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExprationDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExprationDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LotTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtyTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsXpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newLotTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpnLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpnXpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonMemoExEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newQtyTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalQtyTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersXPView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsXPView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustmentDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustmentDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalLotLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LotXpView)).BeginInit();
            this.SuspendLayout();
            // 
            // adjustmentGridControl
            // 
            this.adjustmentGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adjustmentGridControl.DataSource = this.inventoryXPView;
            this.adjustmentGridControl.Location = new System.Drawing.Point(13, 324);
            this.adjustmentGridControl.MainView = this.adjustmentGridView;
            this.adjustmentGridControl.Name = "adjustmentGridControl";
            this.adjustmentGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.deleteRepositoryItemButtonEdit,
            this.reasonRepositoryItemMemoExEdit});
            this.adjustmentGridControl.Size = new System.Drawing.Size(768, 243);
            this.adjustmentGridControl.TabIndex = 4;
            this.adjustmentGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.adjustmentGridView});
            // 
            // inventoryXPView
            // 
            this.inventoryXPView.ObjectType = typeof(DXDAL.SPGData.InventoryAdjustment);
            this.inventoryXPView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("AdjustmentDate", DevExpress.Xpo.SortDirection.None, "[AdjustmentDate]", false, true),
            new DevExpress.Xpo.ViewProperty("AdjustmentID", DevExpress.Xpo.SortDirection.None, "[AdjustmentID]", false, true),
            new DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[AdjustmentItem.ItemCode]", false, true),
            new DevExpress.Xpo.ViewProperty("ItemDescription", DevExpress.Xpo.SortDirection.None, "[AdjustmentItem.ItemDescription]", false, true),
            new DevExpress.Xpo.ViewProperty("OriginalQuantity", DevExpress.Xpo.SortDirection.None, "[OriginalQuantity]", false, true),
            new DevExpress.Xpo.ViewProperty("NewCount", DevExpress.Xpo.SortDirection.None, "[NewCount]", false, true),
            new DevExpress.Xpo.ViewProperty("OriginalLot", DevExpress.Xpo.SortDirection.None, "[OriginalLot]", false, true),
            new DevExpress.Xpo.ViewProperty("NewLot", DevExpress.Xpo.SortDirection.None, "[NewLot]", false, true),
            new DevExpress.Xpo.ViewProperty("LPN", DevExpress.Xpo.SortDirection.None, "[LPN]", false, true),
            new DevExpress.Xpo.ViewProperty("Reason", DevExpress.Xpo.SortDirection.None, "[Reason]", false, true),
            new DevExpress.Xpo.ViewProperty("CustomerName", DevExpress.Xpo.SortDirection.None, "[Customer.CustomerName]", false, true),
            new DevExpress.Xpo.ViewProperty("InventoryLocation", DevExpress.Xpo.SortDirection.None, "[InventoryLocation.LocationCode]", false, true),
            new DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[AdjustmentItem.ItemID]", false, true),
            new DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[AdjustmentItem.ItemCustomerID.CustomerID]", false, true),
            new DevExpress.Xpo.ViewProperty("LocationID", DevExpress.Xpo.SortDirection.None, "[InventoryLocation.Oid]", false, true)});
            // 
            // adjustmentGridView
            // 
            this.adjustmentGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.deleteGridColumn,
            this.idGridColumn,
            this.customerGridColumn,
            this.dateGridColumn,
            this.itemGridColumn,
            this.descriptionGridColumn,
            this.colLPN,
            this.locationCodeGridColumn,
            this.originalQuantityGridColumn,
            this.newQtyGridColumn,
            this.colOriginalLot,
            this.colNewLot,
            this.adjustmentGridColumn,
            this.reasonGridColumn,
            this.itemIDGridColumn,
            this.customerIDGridColumn,
            this.locationGridColumn});
            this.adjustmentGridView.GridControl = this.adjustmentGridControl;
            this.adjustmentGridView.Name = "adjustmentGridView";
            this.adjustmentGridView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.adjustmentGridView_RowCellStyle);
            this.adjustmentGridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.adjustmentGridView_CustomUnboundColumnData);
            // 
            // deleteGridColumn
            // 
            this.deleteGridColumn.ColumnEdit = this.deleteRepositoryItemButtonEdit;
            this.deleteGridColumn.Name = "deleteGridColumn";
            this.deleteGridColumn.OptionsColumn.AllowSize = false;
            this.deleteGridColumn.OptionsColumn.FixedWidth = true;
            this.deleteGridColumn.Visible = true;
            this.deleteGridColumn.VisibleIndex = 0;
            this.deleteGridColumn.Width = 22;
            // 
            // deleteRepositoryItemButtonEdit
            // 
            this.deleteRepositoryItemButtonEdit.AutoHeight = false;
            this.deleteRepositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.deleteRepositoryItemButtonEdit.Name = "deleteRepositoryItemButtonEdit";
            this.deleteRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.deleteRepositoryItemButtonEdit.Click += new System.EventHandler(this.deleteRepositoryItemButtonEdit_Click);
            // 
            // idGridColumn
            // 
            this.idGridColumn.Caption = "GridColumn1";
            this.idGridColumn.FieldName = "AdjustmentID";
            this.idGridColumn.Name = "idGridColumn";
            this.idGridColumn.OptionsColumn.AllowEdit = false;
            this.idGridColumn.OptionsColumn.ReadOnly = true;
            // 
            // customerGridColumn
            // 
            this.customerGridColumn.Caption = "Customer Name";
            this.customerGridColumn.FieldName = "CustomerName";
            this.customerGridColumn.Name = "customerGridColumn";
            this.customerGridColumn.OptionsColumn.ReadOnly = true;
            this.customerGridColumn.Visible = true;
            this.customerGridColumn.VisibleIndex = 1;
            this.customerGridColumn.Width = 98;
            // 
            // dateGridColumn
            // 
            this.dateGridColumn.Caption = "Date";
            this.dateGridColumn.DisplayFormat.FormatString = "D";
            this.dateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateGridColumn.FieldName = "AdjustmentDate";
            this.dateGridColumn.Name = "dateGridColumn";
            this.dateGridColumn.OptionsColumn.AllowEdit = false;
            this.dateGridColumn.OptionsColumn.ReadOnly = true;
            this.dateGridColumn.Visible = true;
            this.dateGridColumn.VisibleIndex = 2;
            this.dateGridColumn.Width = 98;
            // 
            // itemGridColumn
            // 
            this.itemGridColumn.Caption = "Item #";
            this.itemGridColumn.FieldName = "ItemCode";
            this.itemGridColumn.Name = "itemGridColumn";
            this.itemGridColumn.OptionsColumn.ReadOnly = true;
            this.itemGridColumn.Visible = true;
            this.itemGridColumn.VisibleIndex = 3;
            this.itemGridColumn.Width = 93;
            // 
            // descriptionGridColumn
            // 
            this.descriptionGridColumn.Caption = "Item Description";
            this.descriptionGridColumn.FieldName = "ItemDescription";
            this.descriptionGridColumn.Name = "descriptionGridColumn";
            this.descriptionGridColumn.OptionsColumn.AllowEdit = false;
            this.descriptionGridColumn.OptionsColumn.ReadOnly = true;
            this.descriptionGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.descriptionGridColumn.Visible = true;
            this.descriptionGridColumn.VisibleIndex = 4;
            this.descriptionGridColumn.Width = 180;
            // 
            // colLPN
            // 
            this.colLPN.FieldName = "LPN";
            this.colLPN.Name = "colLPN";
            this.colLPN.Visible = true;
            this.colLPN.VisibleIndex = 5;
            // 
            // locationCodeGridColumn
            // 
            this.locationCodeGridColumn.Caption = "Location";
            this.locationCodeGridColumn.FieldName = "InventoryLocation";
            this.locationCodeGridColumn.Name = "locationCodeGridColumn";
            this.locationCodeGridColumn.Visible = true;
            this.locationCodeGridColumn.VisibleIndex = 6;
            // 
            // originalQuantityGridColumn
            // 
            this.originalQuantityGridColumn.Caption = "Orig. Qty";
            this.originalQuantityGridColumn.DisplayFormat.FormatString = "{0:#,##0.######}";
            this.originalQuantityGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.originalQuantityGridColumn.FieldName = "OriginalQuantity";
            this.originalQuantityGridColumn.Name = "originalQuantityGridColumn";
            this.originalQuantityGridColumn.OptionsColumn.AllowEdit = false;
            this.originalQuantityGridColumn.OptionsColumn.FixedWidth = true;
            this.originalQuantityGridColumn.OptionsColumn.ReadOnly = true;
            this.originalQuantityGridColumn.Visible = true;
            this.originalQuantityGridColumn.VisibleIndex = 7;
            this.originalQuantityGridColumn.Width = 60;
            // 
            // newQtyGridColumn
            // 
            this.newQtyGridColumn.Caption = "New Qty";
            this.newQtyGridColumn.DisplayFormat.FormatString = "{0:#,##0.######}";
            this.newQtyGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.newQtyGridColumn.FieldName = "NewCount";
            this.newQtyGridColumn.Name = "newQtyGridColumn";
            this.newQtyGridColumn.OptionsColumn.AllowEdit = false;
            this.newQtyGridColumn.OptionsColumn.FixedWidth = true;
            this.newQtyGridColumn.OptionsColumn.ReadOnly = true;
            this.newQtyGridColumn.Visible = true;
            this.newQtyGridColumn.VisibleIndex = 8;
            this.newQtyGridColumn.Width = 60;
            // 
            // colOriginalLot
            // 
            this.colOriginalLot.Caption = "Orig. Lot#";
            this.colOriginalLot.FieldName = "OriginalLot";
            this.colOriginalLot.Name = "colOriginalLot";
            this.colOriginalLot.Visible = true;
            this.colOriginalLot.VisibleIndex = 10;
            // 
            // colNewLot
            // 
            this.colNewLot.FieldName = "NewLot";
            this.colNewLot.Name = "colNewLot";
            this.colNewLot.Visible = true;
            this.colNewLot.VisibleIndex = 11;
            // 
            // adjustmentGridColumn
            // 
            this.adjustmentGridColumn.Caption = "Adjustment";
            this.adjustmentGridColumn.DisplayFormat.FormatString = "##;-##";
            this.adjustmentGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.adjustmentGridColumn.FieldName = "adjustmentGridColumn";
            this.adjustmentGridColumn.Name = "adjustmentGridColumn";
            this.adjustmentGridColumn.OptionsColumn.AllowEdit = false;
            this.adjustmentGridColumn.OptionsColumn.FixedWidth = true;
            this.adjustmentGridColumn.OptionsColumn.ReadOnly = true;
            this.adjustmentGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.adjustmentGridColumn.Visible = true;
            this.adjustmentGridColumn.VisibleIndex = 9;
            this.adjustmentGridColumn.Width = 65;
            // 
            // reasonGridColumn
            // 
            this.reasonGridColumn.Caption = "Reason";
            this.reasonGridColumn.ColumnEdit = this.reasonRepositoryItemMemoExEdit;
            this.reasonGridColumn.FieldName = "Reason";
            this.reasonGridColumn.Name = "reasonGridColumn";
            this.reasonGridColumn.OptionsColumn.ReadOnly = true;
            this.reasonGridColumn.Visible = true;
            this.reasonGridColumn.VisibleIndex = 12;
            this.reasonGridColumn.Width = 110;
            // 
            // reasonRepositoryItemMemoExEdit
            // 
            this.reasonRepositoryItemMemoExEdit.AutoHeight = false;
            this.reasonRepositoryItemMemoExEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reasonRepositoryItemMemoExEdit.Name = "reasonRepositoryItemMemoExEdit";
            // 
            // itemIDGridColumn
            // 
            this.itemIDGridColumn.Caption = "Item ID";
            this.itemIDGridColumn.FieldName = "ItemID";
            this.itemIDGridColumn.Name = "itemIDGridColumn";
            // 
            // customerIDGridColumn
            // 
            this.customerIDGridColumn.Caption = "Customer ID";
            this.customerIDGridColumn.FieldName = "CustomerID";
            this.customerIDGridColumn.Name = "customerIDGridColumn";
            // 
            // locationGridColumn
            // 
            this.locationGridColumn.Caption = "Location ID";
            this.locationGridColumn.FieldName = "LocationID";
            this.locationGridColumn.Name = "locationGridColumn";
            // 
            // filtersGroupControl
            // 
            this.filtersGroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.filtersGroupControl.Location = new System.Drawing.Point(13, 229);
            this.filtersGroupControl.Name = "filtersGroupControl";
            this.filtersGroupControl.Size = new System.Drawing.Size(768, 89);
            this.filtersGroupControl.TabIndex = 3;
            this.filtersGroupControl.Text = "Filters and Display";
            // 
            // filterSimpleButton
            // 
            this.filterSimpleButton.Location = new System.Drawing.Point(547, 55);
            this.filterSimpleButton.Name = "filterSimpleButton";
            this.filterSimpleButton.Size = new System.Drawing.Size(102, 23);
            this.filterSimpleButton.TabIndex = 11;
            this.filterSimpleButton.Text = "&Filter";
            this.filterSimpleButton.Click += new System.EventHandler(this.filterSimpleButton_Click);
            // 
            // clearSimpleButton
            // 
            this.clearSimpleButton.Location = new System.Drawing.Point(547, 26);
            this.clearSimpleButton.Name = "clearSimpleButton";
            this.clearSimpleButton.Size = new System.Drawing.Size(102, 23);
            this.clearSimpleButton.TabIndex = 10;
            this.clearSimpleButton.Text = "&Clear Filter";
            this.clearSimpleButton.Click += new System.EventHandler(this.clearSimpleButton_Click);
            // 
            // itemFilterLookUpEdit
            // 
            this.itemFilterLookUpEdit.Location = new System.Drawing.Point(386, 55);
            this.itemFilterLookUpEdit.Name = "itemFilterLookUpEdit";
            this.itemFilterLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.itemFilterLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 59, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCustomerID", "Item Customer ID", 95, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.itemFilterLookUpEdit.Properties.DataSource = this.itemsFilterXPView;
            this.itemFilterLookUpEdit.Properties.DisplayMember = "ItemCode";
            this.itemFilterLookUpEdit.Properties.NullText = "[Select A Item]";
            this.itemFilterLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.itemFilterLookUpEdit.Properties.ValueMember = "ItemID";
            this.itemFilterLookUpEdit.Size = new System.Drawing.Size(152, 20);
            this.itemFilterLookUpEdit.TabIndex = 7;
            // 
            // itemsFilterXPView
            // 
            this.itemsFilterXPView.ObjectType = typeof(DXDAL.SPGData.Items);
            this.itemsFilterXPView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[ItemID]", false, true),
            new DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.Ascending, "[ItemCode]", false, true),
            new DevExpress.Xpo.ViewProperty("ItemCustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID]", false, true),
            new DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID.CustomerID]", false, true)});
            // 
            // customerFilterLookUpEdit
            // 
            this.customerFilterLookUpEdit.Location = new System.Drawing.Point(172, 55);
            this.customerFilterLookUpEdit.Name = "customerFilterLookUpEdit";
            this.customerFilterLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.customerFilterLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.customerFilterLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerID", "Customer ID", 83, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Customer Name", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Inactive", "Inactive", 49, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.customerFilterLookUpEdit.Properties.DataSource = this.customersFilterXPView;
            this.customerFilterLookUpEdit.Properties.DisplayMember = "CustomerName";
            this.customerFilterLookUpEdit.Properties.NullText = "[Select A Customer]";
            this.customerFilterLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.customerFilterLookUpEdit.Properties.ValueMember = "CustomerID";
            this.customerFilterLookUpEdit.Size = new System.Drawing.Size(160, 20);
            this.customerFilterLookUpEdit.TabIndex = 5;
            this.customerFilterLookUpEdit.Validated += new System.EventHandler(this.customerFilterLookUpEdit_Validated);
            // 
            // customersFilterXPView
            // 
            this.customersFilterXPView.CriteriaString = "[Inactive] = False";
            this.customersFilterXPView.ObjectType = typeof(DXDAL.SPGData.Customers);
            this.customersFilterXPView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[CustomerID]", false, true),
            new DevExpress.Xpo.ViewProperty("CustomerName", DevExpress.Xpo.SortDirection.Ascending, "[CustomerName]", false, true),
            new DevExpress.Xpo.ViewProperty("Inactive", DevExpress.Xpo.SortDirection.None, "[Inactive]", false, true)});
            // 
            // LabelControl9
            // 
            this.LabelControl9.Location = new System.Drawing.Point(354, 58);
            this.LabelControl9.Name = "LabelControl9";
            this.LabelControl9.Size = new System.Drawing.Size(26, 13);
            this.LabelControl9.TabIndex = 6;
            this.LabelControl9.Text = "Item:";
            // 
            // LabelControl8
            // 
            this.LabelControl8.Location = new System.Drawing.Point(354, 32);
            this.LabelControl8.Name = "LabelControl8";
            this.LabelControl8.Size = new System.Drawing.Size(16, 13);
            this.LabelControl8.TabIndex = 2;
            this.LabelControl8.Text = "To:";
            // 
            // LabelControl7
            // 
            this.LabelControl7.Location = new System.Drawing.Point(116, 58);
            this.LabelControl7.Name = "LabelControl7";
            this.LabelControl7.Size = new System.Drawing.Size(50, 13);
            this.LabelControl7.TabIndex = 4;
            this.LabelControl7.Text = "Customer:";
            // 
            // LabelControl6
            // 
            this.LabelControl6.Location = new System.Drawing.Point(116, 32);
            this.LabelControl6.Name = "LabelControl6";
            this.LabelControl6.Size = new System.Drawing.Size(28, 13);
            this.LabelControl6.TabIndex = 0;
            this.LabelControl6.Text = "From:";
            // 
            // toFilterDateEdit
            // 
            this.toFilterDateEdit.EditValue = null;
            this.toFilterDateEdit.Location = new System.Drawing.Point(386, 29);
            this.toFilterDateEdit.Name = "toFilterDateEdit";
            this.toFilterDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toFilterDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.toFilterDateEdit.Properties.DisplayFormat.FormatString = "D";
            this.toFilterDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.toFilterDateEdit.Properties.EditFormat.FormatString = "D";
            this.toFilterDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.toFilterDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.toFilterDateEdit.Properties.NullText = "[Select A To Date]";
            this.toFilterDateEdit.Size = new System.Drawing.Size(152, 20);
            this.toFilterDateEdit.TabIndex = 3;
            // 
            // fromFilterDateEdit
            // 
            this.fromFilterDateEdit.EditValue = null;
            this.fromFilterDateEdit.Location = new System.Drawing.Point(172, 29);
            this.fromFilterDateEdit.Name = "fromFilterDateEdit";
            this.fromFilterDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fromFilterDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fromFilterDateEdit.Properties.DisplayFormat.FormatString = "D";
            this.fromFilterDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fromFilterDateEdit.Properties.EditFormat.FormatString = "D";
            this.fromFilterDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.fromFilterDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.fromFilterDateEdit.Properties.NullText = "[Select A From Date]";
            this.fromFilterDateEdit.Size = new System.Drawing.Size(160, 20);
            this.fromFilterDateEdit.TabIndex = 1;
            // 
            // recordGroupControl
            // 
            this.recordGroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recordGroupControl.Controls.Add(this.LPNgroupControl);
            this.recordGroupControl.Controls.Add(this.AddLpnSimpleButton);
            this.recordGroupControl.Controls.Add(this.LabelControl15);
            this.recordGroupControl.Controls.Add(this.locationLookUpEdit);
            this.recordGroupControl.Controls.Add(this.LabelControl13);
            this.recordGroupControl.Controls.Add(this.LabelControl14);
            this.recordGroupControl.Controls.Add(this.newLotTextEdit);
            this.recordGroupControl.Controls.Add(this.LabelControl12);
            this.recordGroupControl.Controls.Add(this.lpnLookUpEdit);
            this.recordGroupControl.Controls.Add(this.LabelControl11);
            this.recordGroupControl.Controls.Add(this.reasonMemoExEdit);
            this.recordGroupControl.Controls.Add(this.LabelControl10);
            this.recordGroupControl.Controls.Add(this.LabelControl4);
            this.recordGroupControl.Controls.Add(this.newQtyTextEdit);
            this.recordGroupControl.Controls.Add(this.originalQtyTextEdit);
            this.recordGroupControl.Controls.Add(this.LabelControl1);
            this.recordGroupControl.Controls.Add(this.customerLookUpEdit);
            this.recordGroupControl.Controls.Add(this.cancelSimpleButton);
            this.recordGroupControl.Controls.Add(this.editSimpleButton);
            this.recordGroupControl.Controls.Add(this.saveSimpleButton);
            this.recordGroupControl.Controls.Add(this.descriptionMemoEdit);
            this.recordGroupControl.Controls.Add(this.LabelControl5);
            this.recordGroupControl.Controls.Add(this.LabelControl3);
            this.recordGroupControl.Controls.Add(this.LabelControl2);
            this.recordGroupControl.Controls.Add(this.itemLookUpEdit);
            this.recordGroupControl.Controls.Add(this.adjustmentDateEdit);
            this.recordGroupControl.Controls.Add(this.originalLotLookUpEdit);
            this.recordGroupControl.Location = new System.Drawing.Point(13, 11);
            this.recordGroupControl.Name = "recordGroupControl";
            this.recordGroupControl.ShowCaption = false;
            this.recordGroupControl.Size = new System.Drawing.Size(768, 212);
            this.recordGroupControl.TabIndex = 2;
            // 
            // LPNgroupControl
            // 
            this.LPNgroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LPNgroupControl.ContentImageAlignment = System.Drawing.ContentAlignment.BottomRight;
            this.LPNgroupControl.Controls.Add(this.LPNTextEdit);
            this.LPNgroupControl.Controls.Add(this.ExprationDateEdit);
            this.LPNgroupControl.Controls.Add(this.AddToPalletSimpleButton);
            this.LPNgroupControl.Controls.Add(this.AddPalletsSimpleButton);
            this.LPNgroupControl.Controls.Add(this.LotTextEdit);
            this.LPNgroupControl.Controls.Add(this.QtyTextEdit);
            this.LPNgroupControl.Location = new System.Drawing.Point(440, 133);
            this.LPNgroupControl.Name = "LPNgroupControl";
            this.LPNgroupControl.Size = new System.Drawing.Size(328, 74);
            this.LPNgroupControl.TabIndex = 27;
            this.LPNgroupControl.Text = "Add LPN";
            // 
            // LPNTextEdit
            // 
            this.LPNTextEdit.Location = new System.Drawing.Point(110, 45);
            this.LPNTextEdit.Name = "LPNTextEdit";
            this.LPNTextEdit.Properties.NullText = "LPN #";
            this.LPNTextEdit.Properties.ReadOnly = true;
            this.LPNTextEdit.Size = new System.Drawing.Size(100, 20);
            this.LPNTextEdit.TabIndex = 5;
            // 
            // ExprationDateEdit
            // 
            this.ExprationDateEdit.EditValue = null;
            this.ExprationDateEdit.Location = new System.Drawing.Point(6, 45);
            this.ExprationDateEdit.Name = "ExprationDateEdit";
            this.ExprationDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ExprationDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ExprationDateEdit.Size = new System.Drawing.Size(100, 20);
            this.ExprationDateEdit.TabIndex = 4;
            // 
            // AddToPalletSimpleButton
            // 
            this.AddToPalletSimpleButton.Enabled = false;
            this.AddToPalletSimpleButton.Location = new System.Drawing.Point(216, 43);
            this.AddToPalletSimpleButton.Name = "AddToPalletSimpleButton";
            this.AddToPalletSimpleButton.Size = new System.Drawing.Size(102, 23);
            this.AddToPalletSimpleButton.TabIndex = 3;
            this.AddToPalletSimpleButton.Text = "Add To Pallet";
            this.AddToPalletSimpleButton.Click += new System.EventHandler(this.AddToPalletSimpleButton_Click);
            // 
            // AddPalletsSimpleButton
            // 
            this.AddPalletsSimpleButton.Location = new System.Drawing.Point(216, 17);
            this.AddPalletsSimpleButton.Name = "AddPalletsSimpleButton";
            this.AddPalletsSimpleButton.Size = new System.Drawing.Size(102, 23);
            this.AddPalletsSimpleButton.TabIndex = 2;
            this.AddPalletsSimpleButton.Text = "Add Pallet";
            this.AddPalletsSimpleButton.Click += new System.EventHandler(this.AddPalletsSimpleButton_Click);
            // 
            // LotTextEdit
            // 
            this.LotTextEdit.Location = new System.Drawing.Point(110, 19);
            this.LotTextEdit.Name = "LotTextEdit";
            this.LotTextEdit.Properties.NullText = "Lot #";
            this.LotTextEdit.Size = new System.Drawing.Size(100, 20);
            this.LotTextEdit.TabIndex = 1;
            // 
            // QtyTextEdit
            // 
            this.QtyTextEdit.Location = new System.Drawing.Point(6, 19);
            this.QtyTextEdit.Name = "QtyTextEdit";
            this.QtyTextEdit.Properties.NullText = "Qty";
            this.QtyTextEdit.Size = new System.Drawing.Size(100, 20);
            this.QtyTextEdit.TabIndex = 0;
            // 
            // AddLpnSimpleButton
            // 
            this.AddLpnSimpleButton.Location = new System.Drawing.Point(172, 82);
            this.AddLpnSimpleButton.Name = "AddLpnSimpleButton";
            this.AddLpnSimpleButton.Size = new System.Drawing.Size(52, 22);
            this.AddLpnSimpleButton.TabIndex = 26;
            this.AddLpnSimpleButton.Text = "Add LPN";
            this.AddLpnSimpleButton.Click += new System.EventHandler(this.AddLpnSimpleButton_Click);
            // 
            // LabelControl15
            // 
            this.LabelControl15.Location = new System.Drawing.Point(230, 9);
            this.LabelControl15.Name = "LabelControl15";
            this.LabelControl15.Size = new System.Drawing.Size(44, 13);
            this.LabelControl15.TabIndex = 24;
            this.LabelControl15.Text = "Location:";
            // 
            // locationLookUpEdit
            // 
            this.locationLookUpEdit.Location = new System.Drawing.Point(230, 26);
            this.locationLookUpEdit.Name = "locationLookUpEdit";
            this.locationLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.locationLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationID", "Location ID", 77, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationCode", "Location Code", 78, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationName", "Location Name", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.locationLookUpEdit.Properties.DataSource = this.locationsXpView;
            this.locationLookUpEdit.Properties.DisplayMember = "LocationCode";
            this.locationLookUpEdit.Properties.NullText = "[Select A Location]";
            this.locationLookUpEdit.Properties.ValueMember = "LocationID";
            this.locationLookUpEdit.Size = new System.Drawing.Size(198, 20);
            this.locationLookUpEdit.TabIndex = 23;
            this.locationLookUpEdit.Validated += new System.EventHandler(this.locationLookupEdit_Validated);
            // 
            // locationsXpView
            // 
            this.locationsXpView.ObjectType = typeof(DXDAL.SPGData.Locations);
            this.locationsXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("LocationID", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true),
            new DevExpress.Xpo.ViewProperty("LocationCode", DevExpress.Xpo.SortDirection.None, "[LocationCode]", false, true),
            new DevExpress.Xpo.ViewProperty("LocationName", DevExpress.Xpo.SortDirection.None, "[LocationName]", false, true)});
            // 
            // LabelControl13
            // 
            this.LabelControl13.Location = new System.Drawing.Point(118, 129);
            this.LabelControl13.Name = "LabelControl13";
            this.LabelControl13.Size = new System.Drawing.Size(76, 13);
            this.LabelControl13.TabIndex = 21;
            this.LabelControl13.Text = "Change to Lot#";
            // 
            // LabelControl14
            // 
            this.LabelControl14.Location = new System.Drawing.Point(10, 129);
            this.LabelControl14.Name = "LabelControl14";
            this.LabelControl14.Size = new System.Drawing.Size(23, 13);
            this.LabelControl14.TabIndex = 19;
            this.LabelControl14.Text = "Lot#";
            // 
            // newLotTextEdit
            // 
            this.newLotTextEdit.Location = new System.Drawing.Point(118, 148);
            this.newLotTextEdit.Name = "newLotTextEdit";
            this.newLotTextEdit.Size = new System.Drawing.Size(100, 20);
            this.newLotTextEdit.TabIndex = 22;
            // 
            // LabelControl12
            // 
            this.LabelControl12.Location = new System.Drawing.Point(10, 87);
            this.LabelControl12.Name = "LabelControl12";
            this.LabelControl12.Size = new System.Drawing.Size(33, 13);
            this.LabelControl12.TabIndex = 18;
            this.LabelControl12.Text = "LPN #:";
            // 
            // lpnLookUpEdit
            // 
            this.lpnLookUpEdit.Location = new System.Drawing.Point(10, 104);
            this.lpnLookUpEdit.Name = "lpnLookUpEdit";
            this.lpnLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lpnLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationID", "Location ID", 77, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationCode", "Location Code", 78, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LPN", "LPN", 28, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 46, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lpnLookUpEdit.Properties.DataSource = this.lpnXpView;
            this.lpnLookUpEdit.Properties.DisplayMember = "LPN";
            this.lpnLookUpEdit.Properties.NullText = "[Select A LPN]";
            this.lpnLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lpnLookUpEdit.Properties.ValueMember = "LPN";
            this.lpnLookUpEdit.Size = new System.Drawing.Size(214, 20);
            this.lpnLookUpEdit.TabIndex = 17;
            this.lpnLookUpEdit.Validated += new System.EventHandler(this.lpnLookUpEdit_Validated);
            // 
            // lpnXpView
            // 
            this.lpnXpView.ObjectType = typeof(DXDAL.SPGData.LocationInventoryByLot);
            this.lpnXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("LocationID", DevExpress.Xpo.SortDirection.None, "[Location.Oid]", true, true),
            new DevExpress.Xpo.ViewProperty("LocationCode", DevExpress.Xpo.SortDirection.None, "[Location.LocationCode]", true, true),
            new DevExpress.Xpo.ViewProperty("LPN", DevExpress.Xpo.SortDirection.None, "[LPNNumber]", true, true),
            new DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[LocationInventoryItem.ItemID]", true, true),
            new DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[LocationInventoryItem.ItemCode]", true, true)});
            // 
            // LabelControl11
            // 
            this.LabelControl11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelControl11.Location = new System.Drawing.Point(442, 87);
            this.LabelControl11.Name = "LabelControl11";
            this.LabelControl11.Size = new System.Drawing.Size(94, 13);
            this.LabelControl11.TabIndex = 10;
            this.LabelControl11.Text = "Adjustment Reason";
            // 
            // reasonMemoExEdit
            // 
            this.reasonMemoExEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reasonMemoExEdit.Location = new System.Drawing.Point(440, 104);
            this.reasonMemoExEdit.Name = "reasonMemoExEdit";
            this.reasonMemoExEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reasonMemoExEdit.Size = new System.Drawing.Size(208, 20);
            this.reasonMemoExEdit.TabIndex = 11;
            // 
            // LabelControl10
            // 
            this.LabelControl10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelControl10.Location = new System.Drawing.Point(550, 47);
            this.LabelControl10.Name = "LabelControl10";
            this.LabelControl10.Size = new System.Drawing.Size(42, 13);
            this.LabelControl10.TabIndex = 8;
            this.LabelControl10.Text = "New Qty";
            // 
            // LabelControl4
            // 
            this.LabelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelControl4.Location = new System.Drawing.Point(442, 47);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(18, 13);
            this.LabelControl4.TabIndex = 6;
            this.LabelControl4.Text = "Qty";
            // 
            // newQtyTextEdit
            // 
            this.newQtyTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newQtyTextEdit.Location = new System.Drawing.Point(550, 63);
            this.newQtyTextEdit.Name = "newQtyTextEdit";
            this.newQtyTextEdit.Size = new System.Drawing.Size(100, 20);
            this.newQtyTextEdit.TabIndex = 9;
            // 
            // originalQtyTextEdit
            // 
            this.originalQtyTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.originalQtyTextEdit.Location = new System.Drawing.Point(442, 63);
            this.originalQtyTextEdit.Name = "originalQtyTextEdit";
            this.originalQtyTextEdit.Properties.DisplayFormat.FormatString = "{0:#,##0.######}";
            this.originalQtyTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.originalQtyTextEdit.Properties.ReadOnly = true;
            this.originalQtyTextEdit.Size = new System.Drawing.Size(100, 20);
            this.originalQtyTextEdit.TabIndex = 7;
            // 
            // LabelControl1
            // 
            this.LabelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelControl1.Location = new System.Drawing.Point(442, 9);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(46, 13);
            this.LabelControl1.TabIndex = 4;
            this.LabelControl1.Text = "Customer";
            // 
            // customerLookUpEdit
            // 
            this.customerLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customerLookUpEdit.Location = new System.Drawing.Point(442, 26);
            this.customerLookUpEdit.Name = "customerLookUpEdit";
            this.customerLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.customerLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerID", "Customer ID", 83, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Customer Name", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Inactive", "Inactive", 49, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.customerLookUpEdit.Properties.DataSource = this.customersXPView;
            this.customerLookUpEdit.Properties.DisplayMember = "CustomerName";
            this.customerLookUpEdit.Properties.NullText = "[Select A Customer]";
            this.customerLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.customerLookUpEdit.Properties.ValueMember = "CustomerID";
            this.customerLookUpEdit.Size = new System.Drawing.Size(208, 20);
            this.customerLookUpEdit.TabIndex = 5;
            this.customerLookUpEdit.Validated += new System.EventHandler(this.customerLookUpEdit_Validated);
            // 
            // customersXPView
            // 
            this.customersXPView.CriteriaString = "[Inactive] = False";
            this.customersXPView.ObjectType = typeof(DXDAL.SPGData.Customers);
            this.customersXPView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[CustomerID]", false, true),
            new DevExpress.Xpo.ViewProperty("CustomerName", DevExpress.Xpo.SortDirection.Ascending, "[CustomerName]", false, true),
            new DevExpress.Xpo.ViewProperty("Inactive", DevExpress.Xpo.SortDirection.None, "[Inactive]", false, true)});
            // 
            // cancelSimpleButton
            // 
            this.cancelSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelSimpleButton.Location = new System.Drawing.Point(656, 82);
            this.cancelSimpleButton.Name = "cancelSimpleButton";
            this.cancelSimpleButton.Size = new System.Drawing.Size(102, 23);
            this.cancelSimpleButton.TabIndex = 16;
            this.cancelSimpleButton.Text = "Ca&ncel";
            this.cancelSimpleButton.Click += new System.EventHandler(this.cancelSimpleButton_Click);
            // 
            // editSimpleButton
            // 
            this.editSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editSimpleButton.Location = new System.Drawing.Point(656, 53);
            this.editSimpleButton.Name = "editSimpleButton";
            this.editSimpleButton.Size = new System.Drawing.Size(102, 23);
            this.editSimpleButton.TabIndex = 15;
            this.editSimpleButton.Text = "&Edit Entry";
            this.editSimpleButton.Click += new System.EventHandler(this.editSimpleButton_Click);
            // 
            // saveSimpleButton
            // 
            this.saveSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveSimpleButton.Location = new System.Drawing.Point(656, 24);
            this.saveSimpleButton.Name = "saveSimpleButton";
            this.saveSimpleButton.Size = new System.Drawing.Size(102, 23);
            this.saveSimpleButton.TabIndex = 14;
            this.saveSimpleButton.Text = "&Save Entry";
            this.saveSimpleButton.Click += new System.EventHandler(this.saveSimpleButton_Click);
            // 
            // descriptionMemoEdit
            // 
            this.descriptionMemoEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionMemoEdit.Location = new System.Drawing.Point(230, 67);
            this.descriptionMemoEdit.Name = "descriptionMemoEdit";
            this.descriptionMemoEdit.Size = new System.Drawing.Size(198, 101);
            this.descriptionMemoEdit.TabIndex = 13;
            // 
            // LabelControl5
            // 
            this.LabelControl5.Location = new System.Drawing.Point(230, 47);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new System.Drawing.Size(78, 13);
            this.LabelControl5.TabIndex = 12;
            this.LabelControl5.Text = "Item Description";
            // 
            // LabelControl3
            // 
            this.LabelControl3.Location = new System.Drawing.Point(10, 47);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(37, 13);
            this.LabelControl3.TabIndex = 2;
            this.LabelControl3.Text = "Item #:";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Location = new System.Drawing.Point(10, 9);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(27, 13);
            this.LabelControl2.TabIndex = 0;
            this.LabelControl2.Text = "Date:";
            // 
            // itemLookUpEdit
            // 
            this.itemLookUpEdit.Location = new System.Drawing.Point(10, 63);
            this.itemLookUpEdit.Name = "itemLookUpEdit";
            this.itemLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.itemLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 59, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCustomerID", "Item Customer ID", 95, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.itemLookUpEdit.Properties.DataSource = this.itemsXPView;
            this.itemLookUpEdit.Properties.DisplayMember = "ItemCode";
            this.itemLookUpEdit.Properties.NullText = "[Select A Item]";
            this.itemLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.itemLookUpEdit.Properties.ValueMember = "ItemID";
            this.itemLookUpEdit.Size = new System.Drawing.Size(214, 20);
            this.itemLookUpEdit.TabIndex = 3;
            this.itemLookUpEdit.Validated += new System.EventHandler(this.itemLookUpEdit_Validated);
            // 
            // itemsXPView
            // 
            this.itemsXPView.CriteriaString = "[Inactive] = False";
            this.itemsXPView.ObjectType = typeof(DXDAL.SPGData.Items);
            this.itemsXPView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[ItemID]", false, true),
            new DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.Ascending, "[ItemCode]", false, true),
            new DevExpress.Xpo.ViewProperty("ItemCustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID]", false, true),
            new DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID.CustomerID]", false, true)});
            // 
            // adjustmentDateEdit
            // 
            this.adjustmentDateEdit.EditValue = null;
            this.adjustmentDateEdit.Location = new System.Drawing.Point(10, 26);
            this.adjustmentDateEdit.Name = "adjustmentDateEdit";
            this.adjustmentDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.adjustmentDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.adjustmentDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.adjustmentDateEdit.Properties.DisplayFormat.FormatString = "D";
            this.adjustmentDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.adjustmentDateEdit.Properties.EditFormat.FormatString = "D";
            this.adjustmentDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.adjustmentDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.adjustmentDateEdit.Size = new System.Drawing.Size(214, 20);
            this.adjustmentDateEdit.TabIndex = 1;
            // 
            // originalLotLookUpEdit
            // 
            this.originalLotLookUpEdit.Location = new System.Drawing.Point(10, 148);
            this.originalLotLookUpEdit.Name = "originalLotLookUpEdit";
            this.originalLotLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.originalLotLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationID", "Location ID", 77, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationCode", "Location Code", 78, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LPN", "LPN", 28, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 46, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("lot", "lot", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Qty", "Qty", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Expr", "Expr", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.originalLotLookUpEdit.Properties.DataSource = this.LotXpView;
            this.originalLotLookUpEdit.Properties.DisplayMember = "lot";
            this.originalLotLookUpEdit.Properties.NullText = "[Select A Lot#]";
            this.originalLotLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.originalLotLookUpEdit.Properties.ValueMember = "lot";
            this.originalLotLookUpEdit.Size = new System.Drawing.Size(100, 20);
            this.originalLotLookUpEdit.TabIndex = 20;
            this.originalLotLookUpEdit.GetNotInListValue += new DevExpress.XtraEditors.Controls.GetNotInListValueEventHandler(this.originalLotLookUpEdit_GetNotInListValue);
            this.originalLotLookUpEdit.Validated += new System.EventHandler(this.originalLotLookUpEdit_Validated);
            // 
            // LotXpView
            // 
            this.LotXpView.ObjectType = typeof(DXDAL.SPGData.LocationInventoryByLot);
            this.LotXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("LocationID", DevExpress.Xpo.SortDirection.None, "[Location.Oid]", false, true),
            new DevExpress.Xpo.ViewProperty("LocationCode", DevExpress.Xpo.SortDirection.None, "[Location.LocationCode]", false, true),
            new DevExpress.Xpo.ViewProperty("LPN", DevExpress.Xpo.SortDirection.None, "[LPNNumber]", false, true),
            new DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[LocationInventoryItem.ItemID]", false, true),
            new DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[LocationInventoryItem.ItemCode]", false, true),
            new DevExpress.Xpo.ViewProperty("lot", DevExpress.Xpo.SortDirection.None, "[LocationInventoryLot]", false, true),
            new DevExpress.Xpo.ViewProperty("Qty", DevExpress.Xpo.SortDirection.None, "[QuantityOnHand]", false, true),
            new DevExpress.Xpo.ViewProperty("Expr", DevExpress.Xpo.SortDirection.None, "[ExpirationDate]", false, true)});
            // 
            // InventoryAdjustmentXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 579);
            this.Controls.Add(this.adjustmentGridControl);
            this.Controls.Add(this.filtersGroupControl);
            this.Controls.Add(this.recordGroupControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventoryAdjustmentXtraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Adjustment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.InventoryAdjustmentXtraForm_FormClosing);
            this.Load += new System.EventHandler(this.InventoryAdjustmentXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adjustmentGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryXPView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustmentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteRepositoryItemButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonRepositoryItemMemoExEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filtersGroupControl)).EndInit();
            this.filtersGroupControl.ResumeLayout(false);
            this.filtersGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemFilterLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsFilterXPView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerFilterLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersFilterXPView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toFilterDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toFilterDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromFilterDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromFilterDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recordGroupControl)).EndInit();
            this.recordGroupControl.ResumeLayout(false);
            this.recordGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LPNgroupControl)).EndInit();
            this.LPNgroupControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LPNTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExprationDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExprationDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LotTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtyTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsXpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newLotTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpnLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpnXpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonMemoExEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newQtyTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalQtyTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersXPView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsXPView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustmentDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustmentDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalLotLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LotXpView)).EndInit();
            this.ResumeLayout(false);

		}
		internal DevExpress.XtraGrid.GridControl adjustmentGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView adjustmentGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn deleteGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit deleteRepositoryItemButtonEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn idGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn customerGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn dateGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn itemGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn descriptionGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn originalQuantityGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn newQtyGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn adjustmentGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn reasonGridColumn;
		internal DevExpress.XtraEditors.GroupControl filtersGroupControl;
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
		internal DevExpress.XtraEditors.GroupControl recordGroupControl;
		internal DevExpress.XtraEditors.SimpleButton cancelSimpleButton;
		internal DevExpress.XtraEditors.SimpleButton editSimpleButton;
		internal DevExpress.XtraEditors.SimpleButton saveSimpleButton;
		internal DevExpress.XtraEditors.MemoEdit descriptionMemoEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl5;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.LookUpEdit itemLookUpEdit;
		internal DevExpress.XtraEditors.DateEdit adjustmentDateEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl10;
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		internal DevExpress.XtraEditors.TextEdit newQtyTextEdit;
		internal DevExpress.XtraEditors.TextEdit originalQtyTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.LookUpEdit customerLookUpEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl11;
		internal DevExpress.XtraEditors.MemoExEdit reasonMemoExEdit;
		internal DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit reasonRepositoryItemMemoExEdit;
		internal DevExpress.Xpo.XPView inventoryXPView;
		internal DevExpress.Xpo.XPView customersFilterXPView;
		internal DevExpress.Xpo.XPView itemsFilterXPView;
		internal DevExpress.Xpo.XPView itemsXPView;
		internal DevExpress.Xpo.XPView customersXPView;
		internal DevExpress.XtraGrid.Columns.GridColumn itemIDGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn customerIDGridColumn;
		internal DevExpress.XtraEditors.LabelControl LabelControl12;
		internal DevExpress.XtraEditors.LookUpEdit lpnLookUpEdit;
		internal DevExpress.Xpo.XPView locationsXpView;
		internal DevExpress.XtraGrid.Columns.GridColumn locationGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn locationCodeGridColumn;
		internal DevExpress.XtraEditors.LabelControl LabelControl13;
		internal DevExpress.XtraEditors.LabelControl LabelControl14;
		internal DevExpress.XtraEditors.TextEdit newLotTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl15;
		internal DevExpress.XtraEditors.LookUpEdit locationLookUpEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn colLPN;
		internal DevExpress.XtraGrid.Columns.GridColumn colOriginalLot;
		internal DevExpress.XtraGrid.Columns.GridColumn colNewLot;
		internal DevExpress.Xpo.XPView lpnXpView;
		internal DevExpress.XtraEditors.LookUpEdit originalLotLookUpEdit;
		internal DevExpress.Xpo.XPView LotXpView;
		internal DevExpress.XtraEditors.SimpleButton AddLpnSimpleButton;
        private GroupControl LPNgroupControl;
        private TextEdit LotTextEdit;
        private TextEdit QtyTextEdit;
        private SimpleButton AddToPalletSimpleButton;
        private SimpleButton AddPalletsSimpleButton;
        private DateEdit ExprationDateEdit;
        private TextEdit LPNTextEdit;
    }

}