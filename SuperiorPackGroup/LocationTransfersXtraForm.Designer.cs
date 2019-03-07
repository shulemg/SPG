using DXDAL.SPGData;
using DevExpress.Xpo;
using DevExpress.Xpo.Helpers;
using DevExpress.Data.Filtering;
using DevExpress.XtraEditors.Controls;

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
	public partial class LocationTransfersXtraForm : DevExpress.XtraEditors.XtraForm
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocationTransfersXtraForm));
            this.BarManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.transfersBar = new DevExpress.XtraBars.Bar();
            this.addBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.editBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.cancelBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.saveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.Bar2 = new DevExpress.XtraBars.Bar();
            this.Bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.SplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.transferSearchGridControl = new DevExpress.XtraGrid.GridControl();
            this.transferSearchXpView = new DevExpress.Xpo.XPView(this.components);
            this.transferSearchGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransferID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransferNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransferDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataEntrySplitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.unloadedByLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.employeesXpView = new DevExpress.Xpo.XPView(this.components);
            this.LabelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.loadedByLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.LabelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.trailerTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.checkedByLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.carrierLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.carrierXpView = new DevExpress.Xpo.XPView(this.components);
            this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.transferDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.toLocationLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.locationsXpView = new DevExpress.Xpo.XPView(this.components);
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.fromLocationLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.transferNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.oidTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lpnNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.transferDetailsGridControl = new DevExpress.XtraGrid.GridControl();
            this.transferDetailsXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.transferDetailsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.delGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deleteRepositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.transferIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.transferItemGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.itemXpView = new DevExpress.Xpo.XPView(this.components);
            this.fullLpnNumberGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lpnRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LPNxpView = new DevExpress.Xpo.XPView(this.components);
            this.colTransferLot = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LotRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.LotXpView = new DevExpress.Xpo.XPView(this.components);
            this.noteGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoExEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.colItemExpirationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransferQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransferUnits = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransferPallets = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).BeginInit();
            this.SplitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transferSearchGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferSearchXpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferSearchGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEntrySplitContainerControl)).BeginInit();
            this.dataEntrySplitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.unloadedByLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesXpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadedByLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trailerTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedByLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrierLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrierXpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toLocationLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsXpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromLocationLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oidTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpnNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferDetailsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferDetailsXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferDetailsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteRepositoryItemButtonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemXpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpnRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LPNxpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LotRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LotXpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarManager1
            // 
            this.BarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.transfersBar,
            this.Bar2,
            this.Bar3});
            this.BarManager1.DockControls.Add(this.barDockControlTop);
            this.BarManager1.DockControls.Add(this.barDockControlBottom);
            this.BarManager1.DockControls.Add(this.barDockControlLeft);
            this.BarManager1.DockControls.Add(this.barDockControlRight);
            this.BarManager1.Form = this;
            this.BarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.addBarButtonItem,
            this.editBarButtonItem,
            this.cancelBarButtonItem,
            this.saveBarButtonItem,
            this.deleteBarButtonItem,
            this.refreshBarButtonItem});
            this.BarManager1.MainMenu = this.Bar2;
            this.BarManager1.MaxItemId = 6;
            this.BarManager1.StatusBar = this.Bar3;
            // 
            // transfersBar
            // 
            this.transfersBar.BarName = "Tools";
            this.transfersBar.DockCol = 0;
            this.transfersBar.DockRow = 1;
            this.transfersBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.transfersBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.addBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.editBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.cancelBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.saveBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.refreshBarButtonItem)});
            this.transfersBar.OptionsBar.UseWholeRow = true;
            this.transfersBar.Text = "Tools";
            // 
            // addBarButtonItem
            // 
            this.addBarButtonItem.Caption = "&Add Transfer";
            this.addBarButtonItem.Id = 0;
            this.addBarButtonItem.Name = "addBarButtonItem";
            this.addBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBarButtonItem_ItemClick);
            // 
            // editBarButtonItem
            // 
            this.editBarButtonItem.Caption = "&Edit Transfer";
            this.editBarButtonItem.Id = 1;
            this.editBarButtonItem.Name = "editBarButtonItem";
            this.editBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editBarButtonItem_ItemClick);
            // 
            // deleteBarButtonItem
            // 
            this.deleteBarButtonItem.Caption = "Delete Transfer";
            this.deleteBarButtonItem.Id = 4;
            this.deleteBarButtonItem.Name = "deleteBarButtonItem";
            this.deleteBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBarButtonItem_ItemClick);
            // 
            // cancelBarButtonItem
            // 
            this.cancelBarButtonItem.Caption = "&Cancel Changes";
            this.cancelBarButtonItem.Enabled = false;
            this.cancelBarButtonItem.Id = 2;
            this.cancelBarButtonItem.Name = "cancelBarButtonItem";
            this.cancelBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cancelBarButtonItem_ItemClick);
            // 
            // saveBarButtonItem
            // 
            this.saveBarButtonItem.Caption = "&Save Changes";
            this.saveBarButtonItem.Enabled = false;
            this.saveBarButtonItem.Id = 3;
            this.saveBarButtonItem.Name = "saveBarButtonItem";
            this.saveBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveBarButtonItem_ItemClick);
            // 
            // refreshBarButtonItem
            // 
            this.refreshBarButtonItem.Caption = "Refresh";
            this.refreshBarButtonItem.Id = 5;
            this.refreshBarButtonItem.Name = "refreshBarButtonItem";
            this.refreshBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refreshBarButtonItem_ItemClick);
            // 
            // Bar2
            // 
            this.Bar2.BarName = "Main menu";
            this.Bar2.DockCol = 0;
            this.Bar2.DockRow = 0;
            this.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.Bar2.OptionsBar.MultiLine = true;
            this.Bar2.OptionsBar.UseWholeRow = true;
            this.Bar2.Text = "Main menu";
            // 
            // Bar3
            // 
            this.Bar3.BarName = "Status bar";
            this.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.Bar3.DockCol = 0;
            this.Bar3.DockRow = 0;
            this.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.Bar3.OptionsBar.AllowQuickCustomization = false;
            this.Bar3.OptionsBar.DrawDragBorder = false;
            this.Bar3.OptionsBar.UseWholeRow = true;
            this.Bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.BarManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(947, 49);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 491);
            this.barDockControlBottom.Manager = this.BarManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(947, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 49);
            this.barDockControlLeft.Manager = this.BarManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 442);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(947, 49);
            this.barDockControlRight.Manager = this.BarManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 442);
            // 
            // SplitContainerControl1
            // 
            this.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerControl1.Location = new System.Drawing.Point(0, 49);
            this.SplitContainerControl1.Name = "SplitContainerControl1";
            this.SplitContainerControl1.Panel1.Controls.Add(this.transferSearchGridControl);
            this.SplitContainerControl1.Panel1.MinSize = 250;
            this.SplitContainerControl1.Panel1.Text = "Panel1";
            this.SplitContainerControl1.Panel2.Controls.Add(this.dataEntrySplitContainerControl);
            this.SplitContainerControl1.Panel2.Text = "Panel2";
            this.SplitContainerControl1.Size = new System.Drawing.Size(947, 442);
            this.SplitContainerControl1.SplitterPosition = 150;
            this.SplitContainerControl1.TabIndex = 4;
            this.SplitContainerControl1.Text = "SplitContainerControl1";
            // 
            // transferSearchGridControl
            // 
            this.transferSearchGridControl.DataSource = this.transferSearchXpView;
            this.transferSearchGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transferSearchGridControl.Location = new System.Drawing.Point(0, 0);
            this.transferSearchGridControl.MainView = this.transferSearchGridView;
            this.transferSearchGridControl.MenuManager = this.BarManager1;
            this.transferSearchGridControl.Name = "transferSearchGridControl";
            this.transferSearchGridControl.Size = new System.Drawing.Size(250, 442);
            this.transferSearchGridControl.TabIndex = 0;
            this.transferSearchGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.transferSearchGridView});
            // 
            // transferSearchXpView
            // 
            this.transferSearchXpView.ObjectType = typeof(DXDAL.SPGData.LocationTransfers);
            this.transferSearchXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("TransferID", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true),
            new DevExpress.Xpo.ViewProperty("TransferNumber", DevExpress.Xpo.SortDirection.Ascending, "[TransferNumber]", false, true),
            new DevExpress.Xpo.ViewProperty("TransferDate", DevExpress.Xpo.SortDirection.None, "[TransferDate]", false, true)});
            // 
            // transferSearchGridView
            // 
            this.transferSearchGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransferID,
            this.colTransferNumber,
            this.colTransferDate});
            this.transferSearchGridView.GridControl = this.transferSearchGridControl;
            this.transferSearchGridView.Name = "transferSearchGridView";
            this.transferSearchGridView.OptionsBehavior.Editable = false;
            this.transferSearchGridView.OptionsView.ShowAutoFilterRow = true;
            this.transferSearchGridView.OptionsView.ShowGroupPanel = false;
            this.transferSearchGridView.Click += new System.EventHandler(this.transferSearchGridView_Click);
            // 
            // colTransferID
            // 
            this.colTransferID.FieldName = "TransferID";
            this.colTransferID.Name = "colTransferID";
            this.colTransferID.OptionsColumn.ReadOnly = true;
            // 
            // colTransferNumber
            // 
            this.colTransferNumber.FieldName = "TransferNumber";
            this.colTransferNumber.Name = "colTransferNumber";
            this.colTransferNumber.OptionsColumn.ReadOnly = true;
            this.colTransferNumber.Visible = true;
            this.colTransferNumber.VisibleIndex = 0;
            // 
            // colTransferDate
            // 
            this.colTransferDate.FieldName = "TransferDate";
            this.colTransferDate.Name = "colTransferDate";
            this.colTransferDate.OptionsColumn.ReadOnly = true;
            this.colTransferDate.Visible = true;
            this.colTransferDate.VisibleIndex = 1;
            // 
            // dataEntrySplitContainerControl
            // 
            this.dataEntrySplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataEntrySplitContainerControl.Horizontal = false;
            this.dataEntrySplitContainerControl.Location = new System.Drawing.Point(0, 0);
            this.dataEntrySplitContainerControl.Name = "dataEntrySplitContainerControl";
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.unloadedByLookUpEdit);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.LabelControl10);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.loadedByLookUpEdit);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.LabelControl9);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.LabelControl8);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.trailerTextEdit);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.checkedByLookUpEdit);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.LabelControl7);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.carrierLookUpEdit);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.LabelControl6);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.transferDateDateEdit);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.LabelControl5);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.toLocationLookUpEdit);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.LabelControl4);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.LabelControl3);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.fromLocationLookUpEdit);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.transferNumberTextEdit);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.LabelControl2);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.oidTextEdit);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.LabelControl1);
            this.dataEntrySplitContainerControl.Panel1.MinSize = 175;
            this.dataEntrySplitContainerControl.Panel1.Text = "Header";
            this.dataEntrySplitContainerControl.Panel2.Controls.Add(this.lpnNumberTextEdit);
            this.dataEntrySplitContainerControl.Panel2.Controls.Add(this.LabelControl11);
            this.dataEntrySplitContainerControl.Panel2.Controls.Add(this.transferDetailsGridControl);
            this.dataEntrySplitContainerControl.Panel2.Text = "Details";
            this.dataEntrySplitContainerControl.Size = new System.Drawing.Size(692, 442);
            this.dataEntrySplitContainerControl.SplitterPosition = 175;
            this.dataEntrySplitContainerControl.TabIndex = 0;
            this.dataEntrySplitContainerControl.Text = "SplitContainerControl2";
            // 
            // unloadedByLookUpEdit
            // 
            this.unloadedByLookUpEdit.Location = new System.Drawing.Point(362, 131);
            this.unloadedByLookUpEdit.MenuManager = this.BarManager1;
            this.unloadedByLookUpEdit.Name = "unloadedByLookUpEdit";
            this.unloadedByLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.unloadedByLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeID", "Employee ID", 83, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Employee Name", "Employee Name", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.unloadedByLookUpEdit.Properties.DataSource = this.employeesXpView;
            this.unloadedByLookUpEdit.Properties.DisplayMember = "Employee Name";
            this.unloadedByLookUpEdit.Properties.NullText = "[Select An Employee]";
            this.unloadedByLookUpEdit.Properties.ValueMember = "EmployeeID";
            this.unloadedByLookUpEdit.Size = new System.Drawing.Size(137, 20);
            this.unloadedByLookUpEdit.TabIndex = 19;
            // 
            // employeesXpView
            // 
            this.employeesXpView.ObjectType = typeof(DXDAL.SPGData.Employees);
            this.employeesXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("EmployeeID", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true),
            new DevExpress.Xpo.ViewProperty("Employee Name", DevExpress.Xpo.SortDirection.Ascending, "[LastName] + \', \' + [FirstName]", false, true)});
            // 
            // LabelControl10
            // 
            this.LabelControl10.Location = new System.Drawing.Point(275, 134);
            this.LabelControl10.Name = "LabelControl10";
            this.LabelControl10.Size = new System.Drawing.Size(64, 13);
            this.LabelControl10.TabIndex = 18;
            this.LabelControl10.Text = "Unloaded By:";
            // 
            // loadedByLookUpEdit
            // 
            this.loadedByLookUpEdit.Location = new System.Drawing.Point(120, 131);
            this.loadedByLookUpEdit.MenuManager = this.BarManager1;
            this.loadedByLookUpEdit.Name = "loadedByLookUpEdit";
            this.loadedByLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.loadedByLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeID", "Employee ID", 83, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Employee Name", "Employee Name", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.loadedByLookUpEdit.Properties.DataSource = this.employeesXpView;
            this.loadedByLookUpEdit.Properties.DisplayMember = "Employee Name";
            this.loadedByLookUpEdit.Properties.NullText = "[Select An Employee]";
            this.loadedByLookUpEdit.Properties.ValueMember = "EmployeeID";
            this.loadedByLookUpEdit.Size = new System.Drawing.Size(132, 20);
            this.loadedByLookUpEdit.TabIndex = 17;
            // 
            // LabelControl9
            // 
            this.LabelControl9.Location = new System.Drawing.Point(43, 134);
            this.LabelControl9.Name = "LabelControl9";
            this.LabelControl9.Size = new System.Drawing.Size(54, 13);
            this.LabelControl9.TabIndex = 16;
            this.LabelControl9.Text = "Loaded By:";
            // 
            // LabelControl8
            // 
            this.LabelControl8.Location = new System.Drawing.Point(275, 108);
            this.LabelControl8.Name = "LabelControl8";
            this.LabelControl8.Size = new System.Drawing.Size(34, 13);
            this.LabelControl8.TabIndex = 15;
            this.LabelControl8.Text = "Trailer:";
            // 
            // trailerTextEdit
            // 
            this.trailerTextEdit.Location = new System.Drawing.Point(362, 105);
            this.trailerTextEdit.MenuManager = this.BarManager1;
            this.trailerTextEdit.Name = "trailerTextEdit";
            this.trailerTextEdit.Size = new System.Drawing.Size(137, 20);
            this.trailerTextEdit.TabIndex = 14;
            // 
            // checkedByLookUpEdit
            // 
            this.checkedByLookUpEdit.Location = new System.Drawing.Point(120, 105);
            this.checkedByLookUpEdit.MenuManager = this.BarManager1;
            this.checkedByLookUpEdit.Name = "checkedByLookUpEdit";
            this.checkedByLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedByLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeID", "Employee ID", 83, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Employee Name", "Employee Name", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.checkedByLookUpEdit.Properties.DataSource = this.employeesXpView;
            this.checkedByLookUpEdit.Properties.DisplayMember = "Employee Name";
            this.checkedByLookUpEdit.Properties.NullText = "[Select An Employee]";
            this.checkedByLookUpEdit.Properties.ValueMember = "EmployeeID";
            this.checkedByLookUpEdit.Size = new System.Drawing.Size(132, 20);
            this.checkedByLookUpEdit.TabIndex = 13;
            // 
            // LabelControl7
            // 
            this.LabelControl7.Location = new System.Drawing.Point(43, 108);
            this.LabelControl7.Name = "LabelControl7";
            this.LabelControl7.Size = new System.Drawing.Size(60, 13);
            this.LabelControl7.TabIndex = 12;
            this.LabelControl7.Text = "Checked By:";
            // 
            // carrierLookUpEdit
            // 
            this.carrierLookUpEdit.Location = new System.Drawing.Point(362, 78);
            this.carrierLookUpEdit.MenuManager = this.BarManager1;
            this.carrierLookUpEdit.Name = "carrierLookUpEdit";
            this.carrierLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.carrierLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierID", "Carrier ID", 70, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CarrierName", "Carrier Name", 73, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.carrierLookUpEdit.Properties.DataSource = this.carrierXpView;
            this.carrierLookUpEdit.Properties.DisplayMember = "CarrierName";
            this.carrierLookUpEdit.Properties.NullText = "[Select A Carrier]";
            this.carrierLookUpEdit.Properties.ValueMember = "CarrierID";
            this.carrierLookUpEdit.Size = new System.Drawing.Size(137, 20);
            this.carrierLookUpEdit.TabIndex = 11;
            // 
            // carrierXpView
            // 
            this.carrierXpView.ObjectType = typeof(DXDAL.SPGData.Carriers);
            this.carrierXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("CarrierID", DevExpress.Xpo.SortDirection.None, "[CarrierID]", false, true),
            new DevExpress.Xpo.ViewProperty("CarrierName", DevExpress.Xpo.SortDirection.None, "[CarrierName]", false, true)});
            // 
            // LabelControl6
            // 
            this.LabelControl6.Location = new System.Drawing.Point(275, 81);
            this.LabelControl6.Name = "LabelControl6";
            this.LabelControl6.Size = new System.Drawing.Size(37, 13);
            this.LabelControl6.TabIndex = 10;
            this.LabelControl6.Text = "Carrier:";
            // 
            // transferDateDateEdit
            // 
            this.transferDateDateEdit.EditValue = null;
            this.transferDateDateEdit.Location = new System.Drawing.Point(120, 78);
            this.transferDateDateEdit.MenuManager = this.BarManager1;
            this.transferDateDateEdit.Name = "transferDateDateEdit";
            this.transferDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.transferDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.transferDateDateEdit.Properties.Mask.EditMask = "D";
            this.transferDateDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.transferDateDateEdit.Properties.NullText = "[Select A Date]";
            this.transferDateDateEdit.Size = new System.Drawing.Size(132, 20);
            this.transferDateDateEdit.TabIndex = 9;
            // 
            // LabelControl5
            // 
            this.LabelControl5.Location = new System.Drawing.Point(43, 81);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new System.Drawing.Size(27, 13);
            this.LabelControl5.TabIndex = 8;
            this.LabelControl5.Text = "Date:";
            // 
            // toLocationLookUpEdit
            // 
            this.toLocationLookUpEdit.Enabled = false;
            this.toLocationLookUpEdit.Location = new System.Drawing.Point(362, 51);
            this.toLocationLookUpEdit.MenuManager = this.BarManager1;
            this.toLocationLookUpEdit.Name = "toLocationLookUpEdit";
            this.toLocationLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toLocationLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationID", "Location ID", 77, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationCode", "Location Code", 78, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationName", "Location Name", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.toLocationLookUpEdit.Properties.DataSource = this.locationsXpView;
            this.toLocationLookUpEdit.Properties.DisplayMember = "LocationCode";
            this.toLocationLookUpEdit.Properties.NullText = "[Select To Location]";
            this.toLocationLookUpEdit.Properties.ValueMember = "LocationID";
            this.toLocationLookUpEdit.Size = new System.Drawing.Size(137, 20);
            this.toLocationLookUpEdit.TabIndex = 7;
            // 
            // locationsXpView
            // 
            this.locationsXpView.ObjectType = typeof(DXDAL.SPGData.Locations);
            this.locationsXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("LocationID", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true),
            new DevExpress.Xpo.ViewProperty("LocationCode", DevExpress.Xpo.SortDirection.None, "[LocationCode]", false, true),
            new DevExpress.Xpo.ViewProperty("LocationName", DevExpress.Xpo.SortDirection.None, "[LocationName]", false, true)});
            // 
            // LabelControl4
            // 
            this.LabelControl4.Location = new System.Drawing.Point(275, 54);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(59, 13);
            this.LabelControl4.TabIndex = 6;
            this.LabelControl4.Text = "To Location:";
            // 
            // LabelControl3
            // 
            this.LabelControl3.Location = new System.Drawing.Point(43, 54);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(71, 13);
            this.LabelControl3.TabIndex = 5;
            this.LabelControl3.Text = "From Location:";
            // 
            // fromLocationLookUpEdit
            // 
            this.fromLocationLookUpEdit.Enabled = false;
            this.fromLocationLookUpEdit.Location = new System.Drawing.Point(120, 51);
            this.fromLocationLookUpEdit.MenuManager = this.BarManager1;
            this.fromLocationLookUpEdit.Name = "fromLocationLookUpEdit";
            this.fromLocationLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fromLocationLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationID", "Location ID", 77, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationCode", "Location Code", 78, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationName", "Location Name", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.fromLocationLookUpEdit.Properties.DataSource = this.locationsXpView;
            this.fromLocationLookUpEdit.Properties.DisplayMember = "LocationCode";
            this.fromLocationLookUpEdit.Properties.NullText = "[Select From Location]";
            this.fromLocationLookUpEdit.Properties.ValueMember = "LocationID";
            this.fromLocationLookUpEdit.Size = new System.Drawing.Size(132, 20);
            this.fromLocationLookUpEdit.TabIndex = 4;
            this.fromLocationLookUpEdit.Validated += new System.EventHandler(this.fromLocationLookUpEdit_Validated);
            // 
            // transferNumberTextEdit
            // 
            this.transferNumberTextEdit.Enabled = false;
            this.transferNumberTextEdit.Location = new System.Drawing.Point(362, 24);
            this.transferNumberTextEdit.MenuManager = this.BarManager1;
            this.transferNumberTextEdit.Name = "transferNumberTextEdit";
            this.transferNumberTextEdit.Properties.NullText = "[Generated when saved]";
            this.transferNumberTextEdit.Size = new System.Drawing.Size(137, 20);
            this.transferNumberTextEdit.TabIndex = 3;
            // 
            // LabelControl2
            // 
            this.LabelControl2.Location = new System.Drawing.Point(275, 27);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(81, 13);
            this.LabelControl2.TabIndex = 2;
            this.LabelControl2.Text = "Transfer Number";
            // 
            // oidTextEdit
            // 
            this.oidTextEdit.Enabled = false;
            this.oidTextEdit.Location = new System.Drawing.Point(120, 24);
            this.oidTextEdit.MenuManager = this.BarManager1;
            this.oidTextEdit.Name = "oidTextEdit";
            this.oidTextEdit.Properties.ReadOnly = true;
            this.oidTextEdit.Size = new System.Drawing.Size(132, 20);
            this.oidTextEdit.TabIndex = 1;
            // 
            // LabelControl1
            // 
            this.LabelControl1.Location = new System.Drawing.Point(43, 27);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(56, 13);
            this.LabelControl1.TabIndex = 0;
            this.LabelControl1.Text = "Internal ID:";
            // 
            // lpnNumberTextEdit
            // 
            this.lpnNumberTextEdit.EditValue = "";
            this.lpnNumberTextEdit.Location = new System.Drawing.Point(248, 6);
            this.lpnNumberTextEdit.MenuManager = this.BarManager1;
            this.lpnNumberTextEdit.Name = "lpnNumberTextEdit";
            this.lpnNumberTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.lpnNumberTextEdit.Properties.MaxLength = 15;
            this.lpnNumberTextEdit.Properties.ValidateOnEnterKey = true;
            this.lpnNumberTextEdit.Size = new System.Drawing.Size(134, 20);
            this.lpnNumberTextEdit.TabIndex = 2;
            this.lpnNumberTextEdit.Validating += new System.ComponentModel.CancelEventHandler(this.lpnNumberTextEdit_Validating);
            // 
            // LabelControl11
            // 
            this.LabelControl11.Location = new System.Drawing.Point(160, 9);
            this.LabelControl11.Name = "LabelControl11";
            this.LabelControl11.Size = new System.Drawing.Size(82, 13);
            this.LabelControl11.TabIndex = 1;
            this.LabelControl11.Text = "Import from LPN:";
            // 
            // transferDetailsGridControl
            // 
            this.transferDetailsGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.transferDetailsGridControl.DataSource = this.transferDetailsXpCollection;
            this.transferDetailsGridControl.Location = new System.Drawing.Point(0, 33);
            this.transferDetailsGridControl.MainView = this.transferDetailsGridView;
            this.transferDetailsGridControl.MenuManager = this.BarManager1;
            this.transferDetailsGridControl.Name = "transferDetailsGridControl";
            this.transferDetailsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.itemRepositoryItemLookUpEdit,
            this.deleteRepositoryItemButtonEdit,
            this.LotRepositoryItemLookUpEdit,
            this.repositoryItemMemoExEdit1,
            this.repositoryItemLookUpEdit1,
            this.lpnRepositoryItemLookUpEdit});
            this.transferDetailsGridControl.Size = new System.Drawing.Size(692, 229);
            this.transferDetailsGridControl.TabIndex = 0;
            this.transferDetailsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.transferDetailsGridView});
            // 
            // transferDetailsXpCollection
            // 
            this.transferDetailsXpCollection.ObjectType = typeof(DXDAL.SPGData.LocationTransferDetails);
            // 
            // transferDetailsGridView
            // 
            this.transferDetailsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.delGridColumn,
            this.colOid,
            this.GridColumn1,
            this.transferIDGridColumn,
            this.GridColumn3,
            this.transferItemGridColumn,
            this.fullLpnNumberGridColumn,
            this.colTransferLot,
            this.noteGridColumn,
            this.colItemExpirationDate,
            this.colTransferQuantity,
            this.colTransferUnits,
            this.colTransferPallets});
            this.transferDetailsGridView.GridControl = this.transferDetailsGridControl;
            this.transferDetailsGridView.Name = "transferDetailsGridView";
            this.transferDetailsGridView.OptionsBehavior.Editable = false;
            this.transferDetailsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.transferDetailsGridView.OptionsView.ShowDetailButtons = false;
            this.transferDetailsGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.transferDetailsGridView_InitNewRow);
            this.transferDetailsGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.transferDetailsGridView_FocusedRowChanged);
            this.transferDetailsGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.transferDetailsGridView_CellValueChanged);
            this.transferDetailsGridView.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.transferDetailsGridView_InvalidRowException);
            this.transferDetailsGridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.transferDetailsGridView_ValidateRow);
            // 
            // delGridColumn
            // 
            this.delGridColumn.ColumnEdit = this.deleteRepositoryItemButtonEdit;
            this.delGridColumn.Name = "delGridColumn";
            this.delGridColumn.OptionsColumn.AllowSize = false;
            this.delGridColumn.Visible = true;
            this.delGridColumn.VisibleIndex = 0;
            this.delGridColumn.Width = 20;
            // 
            // deleteRepositoryItemButtonEdit
            // 
            this.deleteRepositoryItemButtonEdit.AutoHeight = false;
            this.deleteRepositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, false, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.deleteRepositoryItemButtonEdit.Name = "deleteRepositoryItemButtonEdit";
            this.deleteRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.deleteRepositoryItemButtonEdit.Click += new System.EventHandler(this.deleteRepositoryItemButtonEdit_Click);
            // 
            // colOid
            // 
            this.colOid.FieldName = "Oid";
            this.colOid.Name = "colOid";
            // 
            // GridColumn1
            // 
            this.GridColumn1.FieldName = "Transfer!";
            this.GridColumn1.Name = "GridColumn1";
            // 
            // transferIDGridColumn
            // 
            this.transferIDGridColumn.FieldName = "Transfer!Key";
            this.transferIDGridColumn.Name = "transferIDGridColumn";
            // 
            // GridColumn3
            // 
            this.GridColumn3.FieldName = "TransferItem!";
            this.GridColumn3.Name = "GridColumn3";
            // 
            // transferItemGridColumn
            // 
            this.transferItemGridColumn.ColumnEdit = this.itemRepositoryItemLookUpEdit;
            this.transferItemGridColumn.FieldName = "TransferItem!Key";
            this.transferItemGridColumn.Name = "transferItemGridColumn";
            this.transferItemGridColumn.Visible = true;
            this.transferItemGridColumn.VisibleIndex = 1;
            this.transferItemGridColumn.Width = 100;
            // 
            // itemRepositoryItemLookUpEdit
            // 
            this.itemRepositoryItemLookUpEdit.AutoHeight = false;
            this.itemRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.itemRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 59, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AvailableQuantity", "Available Quantity", 98, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CasePerPallet", "Cases Per Pallet", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.itemRepositoryItemLookUpEdit.DataSource = this.itemXpView;
            this.itemRepositoryItemLookUpEdit.DisplayMember = "ItemCode";
            this.itemRepositoryItemLookUpEdit.Name = "itemRepositoryItemLookUpEdit";
            this.itemRepositoryItemLookUpEdit.ValueMember = "ItemID";
            // 
            // itemXpView
            // 
            this.itemXpView.ObjectType = typeof(DXDAL.SPGData.LocationInventory);
            this.itemXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[LocationInventoryItem.ItemID]", false, true),
            new DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[LocationInventoryItem.ItemCode]", false, true),
            new DevExpress.Xpo.ViewProperty("AvailableQuantity", DevExpress.Xpo.SortDirection.None, "[QuantityOnHand]", false, true),
            new DevExpress.Xpo.ViewProperty("CasePerPallet", DevExpress.Xpo.SortDirection.None, "[LocationInventoryItem.intCasesPerPallet]", false, true)});
            // 
            // fullLpnNumberGridColumn
            // 
            this.fullLpnNumberGridColumn.Caption = "LPN Number";
            this.fullLpnNumberGridColumn.ColumnEdit = this.lpnRepositoryItemLookUpEdit;
            this.fullLpnNumberGridColumn.FieldName = "FullLpnNumber";
            this.fullLpnNumberGridColumn.Name = "fullLpnNumberGridColumn";
            this.fullLpnNumberGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.fullLpnNumberGridColumn.Visible = true;
            this.fullLpnNumberGridColumn.VisibleIndex = 2;
            // 
            // lpnRepositoryItemLookUpEdit
            // 
            this.lpnRepositoryItemLookUpEdit.AutoHeight = false;
            this.lpnRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lpnRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LPN", "LPN", 41, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lpnRepositoryItemLookUpEdit.DataSource = this.LPNxpView;
            this.lpnRepositoryItemLookUpEdit.DisplayMember = "LPN";
            this.lpnRepositoryItemLookUpEdit.Name = "lpnRepositoryItemLookUpEdit";
            this.lpnRepositoryItemLookUpEdit.NullText = "";
            this.lpnRepositoryItemLookUpEdit.ValueMember = "LPN";
            // 
            // LPNxpView
            // 
            this.LPNxpView.ObjectType = typeof(DXDAL.SPGData.LocationInventoryByLot);
            this.LPNxpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("LPN", DevExpress.Xpo.SortDirection.None, "[LPNNumber]", true, true)});
            // 
            // colTransferLot
            // 
            this.colTransferLot.ColumnEdit = this.LotRepositoryItemLookUpEdit;
            this.colTransferLot.FieldName = "TransferLot";
            this.colTransferLot.Name = "colTransferLot";
            this.colTransferLot.Visible = true;
            this.colTransferLot.VisibleIndex = 3;
            this.colTransferLot.Width = 100;
            // 
            // LotRepositoryItemLookUpEdit
            // 
            this.LotRepositoryItemLookUpEdit.AcceptEditorTextAsNewValue = DevExpress.Utils.DefaultBoolean.True;
            this.LotRepositoryItemLookUpEdit.AutoHeight = false;
            this.LotRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LotRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Lot", "Lot", 38, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.LotRepositoryItemLookUpEdit.DataSource = this.LotXpView;
            this.LotRepositoryItemLookUpEdit.DisplayMember = "Lot";
            this.LotRepositoryItemLookUpEdit.Name = "LotRepositoryItemLookUpEdit";
            this.LotRepositoryItemLookUpEdit.NullText = "";
            this.LotRepositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LotRepositoryItemLookUpEdit.UseReadOnlyAppearance = false;
            this.LotRepositoryItemLookUpEdit.ValueMember = "Lot";
            // 
            // LotXpView
            // 
            this.LotXpView.ObjectType = typeof(DXDAL.SPGData.LocationInventoryByLot);
            this.LotXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("Lot", DevExpress.Xpo.SortDirection.None, "[LocationInventoryLot]", true, true)});
            // 
            // noteGridColumn
            // 
            this.noteGridColumn.Caption = "Note";
            this.noteGridColumn.ColumnEdit = this.repositoryItemMemoExEdit1;
            this.noteGridColumn.FieldName = "Note";
            this.noteGridColumn.Name = "noteGridColumn";
            this.noteGridColumn.Visible = true;
            this.noteGridColumn.VisibleIndex = 4;
            // 
            // repositoryItemMemoExEdit1
            // 
            this.repositoryItemMemoExEdit1.AutoHeight = false;
            this.repositoryItemMemoExEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1";
            // 
            // colItemExpirationDate
            // 
            this.colItemExpirationDate.FieldName = "ItemExpirationDate";
            this.colItemExpirationDate.Name = "colItemExpirationDate";
            this.colItemExpirationDate.Visible = true;
            this.colItemExpirationDate.VisibleIndex = 5;
            this.colItemExpirationDate.Width = 100;
            // 
            // colTransferQuantity
            // 
            this.colTransferQuantity.DisplayFormat.FormatString = "{0:#,##0.######}";
            this.colTransferQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTransferQuantity.FieldName = "TransferQuantity";
            this.colTransferQuantity.Name = "colTransferQuantity";
            this.colTransferQuantity.Visible = true;
            this.colTransferQuantity.VisibleIndex = 7;
            this.colTransferQuantity.Width = 100;
            // 
            // colTransferUnits
            // 
            this.colTransferUnits.DisplayFormat.FormatString = "{0:#,##0.######}";
            this.colTransferUnits.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTransferUnits.FieldName = "TransferUnits";
            this.colTransferUnits.Name = "colTransferUnits";
            this.colTransferUnits.Visible = true;
            this.colTransferUnits.VisibleIndex = 6;
            // 
            // colTransferPallets
            // 
            this.colTransferPallets.DisplayFormat.FormatString = "{0:#,##0.######}";
            this.colTransferPallets.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTransferPallets.FieldName = "TransferPallets";
            this.colTransferPallets.Name = "colTransferPallets";
            this.colTransferPallets.Visible = true;
            this.colTransferPallets.VisibleIndex = 8;
            this.colTransferPallets.Width = 104;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // LocationTransfersXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 514);
            this.Controls.Add(this.SplitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LocationTransfersXtraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Location Transfer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LocationTransfersXtraForm_FormClosing);
            this.Load += new System.EventHandler(this.LocationTransfersXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).EndInit();
            this.SplitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transferSearchGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferSearchXpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferSearchGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEntrySplitContainerControl)).EndInit();
            this.dataEntrySplitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.unloadedByLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesXpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadedByLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trailerTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedByLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrierLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrierXpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toLocationLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationsXpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromLocationLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oidTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpnNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferDetailsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferDetailsXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferDetailsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteRepositoryItemButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemXpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lpnRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LPNxpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LotRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LotXpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoExEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal DevExpress.XtraBars.BarManager BarManager1;
		internal DevExpress.XtraBars.Bar transfersBar;
		internal DevExpress.XtraBars.Bar Bar2;
		internal DevExpress.XtraBars.Bar Bar3;
		internal DevExpress.XtraBars.BarDockControl barDockControlTop;
		internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
		internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
		internal DevExpress.XtraBars.BarDockControl barDockControlRight;
		internal DevExpress.XtraBars.BarButtonItem addBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem editBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem cancelBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem saveBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem deleteBarButtonItem;
		internal DevExpress.XtraEditors.SplitContainerControl SplitContainerControl1;
		internal DevExpress.Xpo.XPView transferSearchXpView;
		internal DevExpress.XtraGrid.GridControl transferSearchGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView transferSearchGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn colTransferID;
		internal DevExpress.XtraGrid.Columns.GridColumn colTransferNumber;
		internal DevExpress.XtraGrid.Columns.GridColumn colTransferDate;
		internal DevExpress.XtraEditors.SplitContainerControl dataEntrySplitContainerControl;
		internal DevExpress.XtraEditors.TextEdit oidTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.TextEdit transferNumberTextEdit;
		internal DevExpress.XtraEditors.LookUpEdit toLocationLookUpEdit;
		internal DevExpress.Xpo.XPView locationsXpView;
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraEditors.LookUpEdit fromLocationLookUpEdit;
		internal DevExpress.XtraEditors.DateEdit transferDateDateEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl5;
		internal DevExpress.XtraEditors.LookUpEdit carrierLookUpEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl6;
		internal DevExpress.Xpo.XPView carrierXpView;
		internal DevExpress.Xpo.XPView employeesXpView;
		internal DevExpress.XtraEditors.TextEdit trailerTextEdit;
		internal DevExpress.XtraEditors.LookUpEdit checkedByLookUpEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl7;
		internal DevExpress.XtraEditors.LabelControl LabelControl8;
		internal DevExpress.XtraEditors.LookUpEdit unloadedByLookUpEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl10;
		internal DevExpress.XtraEditors.LookUpEdit loadedByLookUpEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl9;
		internal DevExpress.XtraGrid.GridControl transferDetailsGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView transferDetailsGridView;
		internal DevExpress.Xpo.XPCollection transferDetailsXpCollection;
		internal DevExpress.XtraGrid.Columns.GridColumn colOid;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
		internal DevExpress.XtraGrid.Columns.GridColumn transferIDGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn3;
		internal DevExpress.XtraGrid.Columns.GridColumn transferItemGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn colTransferLot;
		internal DevExpress.XtraGrid.Columns.GridColumn colTransferQuantity;
		internal DevExpress.XtraGrid.Columns.GridColumn colTransferUnits;
		internal DevExpress.XtraGrid.Columns.GridColumn colTransferPallets;
		internal DevExpress.XtraGrid.Columns.GridColumn colItemExpirationDate;
		internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit itemRepositoryItemLookUpEdit;
		internal DevExpress.Xpo.XPView itemXpView;
		internal DevExpress.XtraGrid.Columns.GridColumn delGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit deleteRepositoryItemButtonEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl11;
		internal DevExpress.XtraEditors.TextEdit lpnNumberTextEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn fullLpnNumberGridColumn;
		internal DevExpress.XtraBars.BarButtonItem refreshBarButtonItem;
		internal DevExpress.Xpo.XPView LotXpView;
		internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit LotRepositoryItemLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn noteGridColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit repositoryItemMemoExEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lpnRepositoryItemLookUpEdit;
        internal XPView LPNxpView;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    }

}