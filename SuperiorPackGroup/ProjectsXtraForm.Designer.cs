using DXDAL;
using DXDAL.SPGData;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

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
	public partial class ProjectsXtraForm : DevExpress.XtraEditors.XtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectsXtraForm));
            this.deleteRepositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.RepositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.itemXpView = new DevExpress.Xpo.XPView(this.components);
            this.BarManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.projectsBar = new DevExpress.XtraBars.Bar();
            this.addBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.editBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.cancelBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.saveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.printProductionReportBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.printBomAvailabilityBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.Bar2 = new DevExpress.XtraBars.Bar();
            this.Bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.SplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.projectSearchGridControl = new DevExpress.XtraGrid.GridControl();
            this.projectSearchXpView = new DevExpress.Xpo.XPView(this.components);
            this.projectSearchGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProjectID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReqStartDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.projectsXtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.dataEntryXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.dataEntrySplitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.notesMemoExEdit = new DevExpress.XtraEditors.MemoExEdit();
            this.LabelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.projectStatusComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.reqDeliveryDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.reqShipDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.reqStartDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.customerLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.customerXpView = new DevExpress.Xpo.XPView(this.components);
            this.projectTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.oidTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.projectDetailsGridControl = new DevExpress.XtraGrid.GridControl();
            this.projectDetailsXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.projectDetailsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.delGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHasChanges = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerPO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitsRequested = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBagsRequested = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPalletsRequested = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemainingBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitsProduced = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBagsProduced = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPalletsProduced = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPercentageComplete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAllowOverrun = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstimatiedShifts = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.moXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.moSearchGridControl = new DevExpress.XtraGrid.GridControl();
            this.moSearchXpView = new DevExpress.Xpo.XPView(this.components);
            this.moSearchGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colScheduledStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoProjectId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.moDataEntrySplitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
            this.saveMoSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.addMoSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.delMoSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.moStatusComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.moScheduledStartDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.moProjectTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.moProjectDetailLookupEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.moMachineLineGridControl = new DevExpress.XtraGrid.GridControl();
            this.moMachineLineGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.moIdGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.machineLineNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.machineLineXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.startTimeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.endTimeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.auditXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.detailHistorySimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.detailHistoryGridControl = new DevExpress.XtraGrid.GridControl();
            this.detailHistoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RecordIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateChangedGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PropertyNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PrevValueGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NewValueGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.moMachineLineXpCollection = new DevExpress.Xpo.XPCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.deleteRepositoryItemButtonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemXpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).BeginInit();
            this.SplitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectSearchGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectSearchXpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectSearchGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsXtraTabControl)).BeginInit();
            this.projectsXtraTabControl.SuspendLayout();
            this.dataEntryXtraTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEntrySplitContainerControl)).BeginInit();
            this.dataEntrySplitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notesMemoExEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectStatusComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqDeliveryDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqDeliveryDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqShipDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqShipDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqStartDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqStartDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerXpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oidTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDetailsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDetailsXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDetailsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemRepositoryItemLookUpEdit)).BeginInit();
            this.moXtraTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moSearchGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moSearchXpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moSearchGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moDataEntrySplitContainerControl)).BeginInit();
            this.moDataEntrySplitContainerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moStatusComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moScheduledStartDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moScheduledStartDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moProjectTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moProjectDetailLookupEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moMachineLineGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moMachineLineGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machineLineXpCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.auditXtraTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailHistoryGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailHistoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moMachineLineXpCollection)).BeginInit();
            this.SuspendLayout();
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
            // RepositoryItemLookUpEdit1
            // 
            this.RepositoryItemLookUpEdit1.AutoHeight = false;
            this.RepositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 59, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CaseQuantity", "Case Quantity", 79, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BagsPerCase", "Bags Per Case", 79, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CasePerPallet", "Case Per Pallet", 82, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.RepositoryItemLookUpEdit1.DataSource = this.itemXpView;
            this.RepositoryItemLookUpEdit1.DisplayMember = "ItemCode";
            this.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1";
            this.RepositoryItemLookUpEdit1.ValueMember = "ItemID";
            this.RepositoryItemLookUpEdit1.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.itemRepositoryItemLookUpEdit_QueryPopUp);
            // 
            // itemXpView
            // 
            this.itemXpView.CriteriaString = "[ItemType] In (\'IG\', \'FG\')";
            this.itemXpView.ObjectType = typeof(DXDAL.SPGData.Items);
            this.itemXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[ItemID]", false, true),
            new DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[ItemCode]", false, true),
            new DevExpress.Xpo.ViewProperty("CaseQuantity", DevExpress.Xpo.SortDirection.None, "[intUnitsPerCase]", false, true),
            new DevExpress.Xpo.ViewProperty("BagsPerCase", DevExpress.Xpo.SortDirection.None, "[BagsPerCase]", false, true),
            new DevExpress.Xpo.ViewProperty("CasePerPallet", DevExpress.Xpo.SortDirection.None, "[intCasesPerPallet]", false, true)});
            // 
            // BarManager1
            // 
            this.BarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.projectsBar,
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
            this.deleteBarButtonItem,
            this.cancelBarButtonItem,
            this.saveBarButtonItem,
            this.printProductionReportBarButtonItem,
            this.printBomAvailabilityBarButtonItem,
            this.refreshBarButtonItem});
            this.BarManager1.MainMenu = this.Bar2;
            this.BarManager1.MaxItemId = 10;
            this.BarManager1.StatusBar = this.Bar3;
            // 
            // projectsBar
            // 
            this.projectsBar.BarName = "Tools";
            this.projectsBar.DockCol = 0;
            this.projectsBar.DockRow = 1;
            this.projectsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.projectsBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.addBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.editBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.deleteBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.cancelBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.saveBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.printProductionReportBarButtonItem, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.printBomAvailabilityBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.refreshBarButtonItem, true)});
            this.projectsBar.OptionsBar.UseWholeRow = true;
            this.projectsBar.Text = "Tools";
            // 
            // addBarButtonItem
            // 
            this.addBarButtonItem.Caption = "&Add Project";
            this.addBarButtonItem.Id = 0;
            this.addBarButtonItem.Name = "addBarButtonItem";
            this.addBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBarButtonItem_ItemClick);
            // 
            // editBarButtonItem
            // 
            this.editBarButtonItem.Caption = "&Edit Project";
            this.editBarButtonItem.Id = 1;
            this.editBarButtonItem.Name = "editBarButtonItem";
            this.editBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editBarButtonItem_ItemClick);
            // 
            // deleteBarButtonItem
            // 
            this.deleteBarButtonItem.Caption = "Delete Project";
            this.deleteBarButtonItem.Id = 2;
            this.deleteBarButtonItem.Name = "deleteBarButtonItem";
            this.deleteBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBarButtonItem_ItemClick);
            // 
            // cancelBarButtonItem
            // 
            this.cancelBarButtonItem.Caption = "&Cancel Changes";
            this.cancelBarButtonItem.Id = 3;
            this.cancelBarButtonItem.Name = "cancelBarButtonItem";
            this.cancelBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cancelBarButtonItem_ItemClick);
            // 
            // saveBarButtonItem
            // 
            this.saveBarButtonItem.Caption = "&Save Changes";
            this.saveBarButtonItem.Id = 4;
            this.saveBarButtonItem.Name = "saveBarButtonItem";
            this.saveBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveBarButtonItem_ItemClick);
            // 
            // printProductionReportBarButtonItem
            // 
            this.printProductionReportBarButtonItem.Caption = "Print &Production Report";
            this.printProductionReportBarButtonItem.Id = 5;
            this.printProductionReportBarButtonItem.Name = "printProductionReportBarButtonItem";
            this.printProductionReportBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.printProductionReportBarButtonItem_ItemClick);
            // 
            // printBomAvailabilityBarButtonItem
            // 
            this.printBomAvailabilityBarButtonItem.Caption = "Print &Bom Availability";
            this.printBomAvailabilityBarButtonItem.Id = 6;
            this.printBomAvailabilityBarButtonItem.Name = "printBomAvailabilityBarButtonItem";
            this.printBomAvailabilityBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.printBomAvailabilityBarButtonItem_ItemClick);
            // 
            // refreshBarButtonItem
            // 
            this.refreshBarButtonItem.Caption = "Refresh";
            this.refreshBarButtonItem.Id = 9;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1117, 49);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 491);
            this.barDockControlBottom.Manager = this.BarManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1117, 23);
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
            this.barDockControlRight.Location = new System.Drawing.Point(1117, 49);
            this.barDockControlRight.Manager = this.BarManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 442);
            // 
            // SplitContainerControl1
            // 
            this.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerControl1.Location = new System.Drawing.Point(0, 49);
            this.SplitContainerControl1.Name = "SplitContainerControl1";
            this.SplitContainerControl1.Panel1.Controls.Add(this.projectSearchGridControl);
            this.SplitContainerControl1.Panel1.MinSize = 250;
            this.SplitContainerControl1.Panel1.Text = "Panel1";
            this.SplitContainerControl1.Panel2.Controls.Add(this.projectsXtraTabControl);
            this.SplitContainerControl1.Panel2.Text = "Panel2";
            this.SplitContainerControl1.Size = new System.Drawing.Size(1117, 442);
            this.SplitContainerControl1.TabIndex = 4;
            this.SplitContainerControl1.Text = "SplitContainerControl1";
            // 
            // projectSearchGridControl
            // 
            this.projectSearchGridControl.DataSource = this.projectSearchXpView;
            this.projectSearchGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectSearchGridControl.Location = new System.Drawing.Point(0, 0);
            this.projectSearchGridControl.MainView = this.projectSearchGridView;
            this.projectSearchGridControl.MenuManager = this.BarManager1;
            this.projectSearchGridControl.Name = "projectSearchGridControl";
            this.projectSearchGridControl.Size = new System.Drawing.Size(250, 442);
            this.projectSearchGridControl.TabIndex = 0;
            this.projectSearchGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.projectSearchGridView});
            // 
            // projectSearchXpView
            // 
            this.projectSearchXpView.ObjectType = typeof(DXDAL.SPGData.Project);
            this.projectSearchXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("ProjectID", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true),
            new DevExpress.Xpo.ViewProperty("Project", DevExpress.Xpo.SortDirection.None, "[project]", false, true),
            new DevExpress.Xpo.ViewProperty("Req.StartDate", DevExpress.Xpo.SortDirection.Descending, "[RequestedStartDate]", false, true),
            new DevExpress.Xpo.ViewProperty("Customer", DevExpress.Xpo.SortDirection.None, "[Customer.CustomerName]", false, true)});
            // 
            // projectSearchGridView
            // 
            this.projectSearchGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProjectID,
            this.colProject,
            this.colCustomerGridColumn,
            this.colReqStartDateGridColumn});
            this.projectSearchGridView.GridControl = this.projectSearchGridControl;
            this.projectSearchGridView.Name = "projectSearchGridView";
            this.projectSearchGridView.OptionsBehavior.Editable = false;
            this.projectSearchGridView.OptionsView.ShowAutoFilterRow = true;
            this.projectSearchGridView.OptionsView.ShowGroupPanel = false;
            this.projectSearchGridView.Click += new System.EventHandler(this.projectSearchGridView_Click);
            // 
            // colProjectID
            // 
            this.colProjectID.FieldName = "ProjectID";
            this.colProjectID.Name = "colProjectID";
            this.colProjectID.OptionsColumn.ReadOnly = true;
            // 
            // colProject
            // 
            this.colProject.FieldName = "Project";
            this.colProject.Name = "colProject";
            this.colProject.OptionsColumn.ReadOnly = true;
            this.colProject.Visible = true;
            this.colProject.VisibleIndex = 0;
            // 
            // colCustomerGridColumn
            // 
            this.colCustomerGridColumn.FieldName = "Customer";
            this.colCustomerGridColumn.Name = "colCustomerGridColumn";
            this.colCustomerGridColumn.Visible = true;
            this.colCustomerGridColumn.VisibleIndex = 1;
            // 
            // colReqStartDateGridColumn
            // 
            this.colReqStartDateGridColumn.Caption = "Req. Start Date";
            this.colReqStartDateGridColumn.FieldName = "Req.StartDate";
            this.colReqStartDateGridColumn.Name = "colReqStartDateGridColumn";
            this.colReqStartDateGridColumn.OptionsColumn.ReadOnly = true;
            this.colReqStartDateGridColumn.Visible = true;
            this.colReqStartDateGridColumn.VisibleIndex = 2;
            // 
            // projectsXtraTabControl
            // 
            this.projectsXtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectsXtraTabControl.Location = new System.Drawing.Point(0, 0);
            this.projectsXtraTabControl.Name = "projectsXtraTabControl";
            this.projectsXtraTabControl.SelectedTabPage = this.dataEntryXtraTabPage;
            this.projectsXtraTabControl.Size = new System.Drawing.Size(862, 442);
            this.projectsXtraTabControl.TabIndex = 1;
            this.projectsXtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.dataEntryXtraTabPage,
            this.moXtraTabPage,
            this.auditXtraTabPage});
            // 
            // dataEntryXtraTabPage
            // 
            this.dataEntryXtraTabPage.Controls.Add(this.dataEntrySplitContainerControl);
            this.dataEntryXtraTabPage.Name = "dataEntryXtraTabPage";
            this.dataEntryXtraTabPage.Size = new System.Drawing.Size(856, 414);
            this.dataEntryXtraTabPage.Text = "Project";
            // 
            // dataEntrySplitContainerControl
            // 
            this.dataEntrySplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataEntrySplitContainerControl.Horizontal = false;
            this.dataEntrySplitContainerControl.Location = new System.Drawing.Point(0, 0);
            this.dataEntrySplitContainerControl.Name = "dataEntrySplitContainerControl";
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.notesMemoExEdit);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.LabelControl9);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.LabelControl8);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.LabelControl7);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.projectStatusComboBoxEdit);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.LabelControl6);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.reqDeliveryDateEdit);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.LabelControl5);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.reqShipDateEdit);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.LabelControl4);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.reqStartDateEdit);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.LabelControl3);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.customerLookUpEdit);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.projectTextEdit);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.LabelControl2);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.LabelControl1);
            this.dataEntrySplitContainerControl.Panel1.Controls.Add(this.oidTextEdit);
            this.dataEntrySplitContainerControl.Panel1.MinSize = 175;
            this.dataEntrySplitContainerControl.Panel1.Text = "Header";
            this.dataEntrySplitContainerControl.Panel2.Controls.Add(this.projectDetailsGridControl);
            this.dataEntrySplitContainerControl.Panel2.Text = "Details";
            this.dataEntrySplitContainerControl.Size = new System.Drawing.Size(856, 414);
            this.dataEntrySplitContainerControl.TabIndex = 0;
            this.dataEntrySplitContainerControl.Text = "SplitContainerControl2";
            // 
            // notesMemoExEdit
            // 
            this.notesMemoExEdit.Location = new System.Drawing.Point(113, 135);
            this.notesMemoExEdit.MenuManager = this.BarManager1;
            this.notesMemoExEdit.Name = "notesMemoExEdit";
            this.notesMemoExEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.notesMemoExEdit.Size = new System.Drawing.Size(399, 20);
            this.notesMemoExEdit.TabIndex = 17;
            // 
            // LabelControl9
            // 
            this.LabelControl9.Location = new System.Drawing.Point(31, 135);
            this.LabelControl9.Name = "LabelControl9";
            this.LabelControl9.Size = new System.Drawing.Size(32, 13);
            this.LabelControl9.TabIndex = 16;
            this.LabelControl9.Text = "Notes:";
            // 
            // LabelControl8
            // 
            this.LabelControl8.Location = new System.Drawing.Point(274, 112);
            this.LabelControl8.Name = "LabelControl8";
            this.LabelControl8.Size = new System.Drawing.Size(83, 13);
            this.LabelControl8.TabIndex = 14;
            this.LabelControl8.Text = "Scheduled Week:";
            // 
            // LabelControl7
            // 
            this.LabelControl7.Location = new System.Drawing.Point(31, 112);
            this.LabelControl7.Name = "LabelControl7";
            this.LabelControl7.Size = new System.Drawing.Size(72, 13);
            this.LabelControl7.TabIndex = 13;
            this.LabelControl7.Text = "Project Status:";
            // 
            // projectStatusComboBoxEdit
            // 
            this.projectStatusComboBoxEdit.Location = new System.Drawing.Point(113, 109);
            this.projectStatusComboBoxEdit.MenuManager = this.BarManager1;
            this.projectStatusComboBoxEdit.Name = "projectStatusComboBoxEdit";
            this.projectStatusComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.projectStatusComboBoxEdit.Size = new System.Drawing.Size(132, 20);
            this.projectStatusComboBoxEdit.TabIndex = 12;
            this.projectStatusComboBoxEdit.FormatEditValue += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(this.projectStatusComboBoxEdit_FormatEditValue);
            // 
            // LabelControl6
            // 
            this.LabelControl6.Location = new System.Drawing.Point(274, 85);
            this.LabelControl6.Name = "LabelControl6";
            this.LabelControl6.Size = new System.Drawing.Size(95, 13);
            this.LabelControl6.TabIndex = 11;
            this.LabelControl6.Text = "Req. Delivery Date:";
            // 
            // reqDeliveryDateEdit
            // 
            this.reqDeliveryDateEdit.EditValue = null;
            this.reqDeliveryDateEdit.Location = new System.Drawing.Point(375, 82);
            this.reqDeliveryDateEdit.MenuManager = this.BarManager1;
            this.reqDeliveryDateEdit.Name = "reqDeliveryDateEdit";
            this.reqDeliveryDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.reqDeliveryDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reqDeliveryDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reqDeliveryDateEdit.Properties.Mask.EditMask = "D";
            this.reqDeliveryDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.reqDeliveryDateEdit.Properties.NullText = "[Select A Date]";
            this.reqDeliveryDateEdit.Size = new System.Drawing.Size(137, 20);
            this.reqDeliveryDateEdit.TabIndex = 10;
            // 
            // LabelControl5
            // 
            this.LabelControl5.Location = new System.Drawing.Point(31, 85);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new System.Drawing.Size(76, 13);
            this.LabelControl5.TabIndex = 9;
            this.LabelControl5.Text = "Req. Ship Date:";
            // 
            // reqShipDateEdit
            // 
            this.reqShipDateEdit.EditValue = null;
            this.reqShipDateEdit.Location = new System.Drawing.Point(113, 82);
            this.reqShipDateEdit.MenuManager = this.BarManager1;
            this.reqShipDateEdit.Name = "reqShipDateEdit";
            this.reqShipDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.reqShipDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reqShipDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reqShipDateEdit.Properties.Mask.EditMask = "D";
            this.reqShipDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.reqShipDateEdit.Properties.NullText = "[Select A Date]";
            this.reqShipDateEdit.Size = new System.Drawing.Size(132, 20);
            this.reqShipDateEdit.TabIndex = 8;
            // 
            // LabelControl4
            // 
            this.LabelControl4.Location = new System.Drawing.Point(274, 58);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(80, 13);
            this.LabelControl4.TabIndex = 7;
            this.LabelControl4.Text = "Req. Start Date:";
            // 
            // reqStartDateEdit
            // 
            this.reqStartDateEdit.EditValue = null;
            this.reqStartDateEdit.Location = new System.Drawing.Point(375, 55);
            this.reqStartDateEdit.MenuManager = this.BarManager1;
            this.reqStartDateEdit.Name = "reqStartDateEdit";
            this.reqStartDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.reqStartDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reqStartDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.reqStartDateEdit.Properties.Mask.EditMask = "D";
            this.reqStartDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.reqStartDateEdit.Properties.NullText = "[Select A Date]";
            this.reqStartDateEdit.Size = new System.Drawing.Size(137, 20);
            this.reqStartDateEdit.TabIndex = 6;
            // 
            // LabelControl3
            // 
            this.LabelControl3.Location = new System.Drawing.Point(31, 58);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(50, 13);
            this.LabelControl3.TabIndex = 5;
            this.LabelControl3.Text = "Customer:";
            // 
            // customerLookUpEdit
            // 
            this.customerLookUpEdit.Location = new System.Drawing.Point(113, 55);
            this.customerLookUpEdit.MenuManager = this.BarManager1;
            this.customerLookUpEdit.Name = "customerLookUpEdit";
            this.customerLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.customerLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerID", "Customer ID", 83, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Customer Name", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.customerLookUpEdit.Properties.DataSource = this.customerXpView;
            this.customerLookUpEdit.Properties.DisplayMember = "CustomerName";
            this.customerLookUpEdit.Properties.NullText = "[Select A Customer]";
            this.customerLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.customerLookUpEdit.Properties.ValueMember = "CustomerID";
            this.customerLookUpEdit.Size = new System.Drawing.Size(132, 20);
            this.customerLookUpEdit.TabIndex = 4;
            this.customerLookUpEdit.Validated += new System.EventHandler(this.customerLookUpEdit_Validated);
            // 
            // customerXpView
            // 
            this.customerXpView.CriteriaString = "[Inactive] = False";
            this.customerXpView.ObjectType = typeof(DXDAL.SPGData.Customers);
            this.customerXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[CustomerID]", false, true),
            new DevExpress.Xpo.ViewProperty("CustomerName", DevExpress.Xpo.SortDirection.None, "[CustomerName]", false, true)});
            // 
            // projectTextEdit
            // 
            this.projectTextEdit.Location = new System.Drawing.Point(375, 28);
            this.projectTextEdit.MenuManager = this.BarManager1;
            this.projectTextEdit.Name = "projectTextEdit";
            this.projectTextEdit.Size = new System.Drawing.Size(137, 20);
            this.projectTextEdit.TabIndex = 3;
            // 
            // LabelControl2
            // 
            this.LabelControl2.Location = new System.Drawing.Point(274, 31);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(38, 13);
            this.LabelControl2.TabIndex = 2;
            this.LabelControl2.Text = "Project:";
            // 
            // LabelControl1
            // 
            this.LabelControl1.Location = new System.Drawing.Point(31, 31);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(56, 13);
            this.LabelControl1.TabIndex = 1;
            this.LabelControl1.Text = "Internal ID:";
            // 
            // oidTextEdit
            // 
            this.oidTextEdit.Enabled = false;
            this.oidTextEdit.Location = new System.Drawing.Point(113, 28);
            this.oidTextEdit.MenuManager = this.BarManager1;
            this.oidTextEdit.Name = "oidTextEdit";
            this.oidTextEdit.Properties.ReadOnly = true;
            this.oidTextEdit.Size = new System.Drawing.Size(132, 20);
            this.oidTextEdit.TabIndex = 0;
            // 
            // projectDetailsGridControl
            // 
            this.projectDetailsGridControl.DataSource = this.projectDetailsXpCollection;
            this.projectDetailsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectDetailsGridControl.Location = new System.Drawing.Point(0, 0);
            this.projectDetailsGridControl.MainView = this.projectDetailsGridView;
            this.projectDetailsGridControl.MenuManager = this.BarManager1;
            this.projectDetailsGridControl.Name = "projectDetailsGridControl";
            this.projectDetailsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.itemRepositoryItemLookUpEdit});
            this.projectDetailsGridControl.Size = new System.Drawing.Size(856, 234);
            this.projectDetailsGridControl.TabIndex = 0;
            this.projectDetailsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.projectDetailsGridView});
            // 
            // projectDetailsXpCollection
            // 
            this.projectDetailsXpCollection.ObjectType = typeof(DXDAL.SPGData.ProjectDetails);
            // 
            // projectDetailsGridView
            // 
            this.projectDetailsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemNumber,
            this.delGridColumn,
            this.colOid,
            this.colHasChanges,
            this.GridColumn1,
            this.GridColumn2,
            this.colCustomerPO,
            this.GridColumn3,
            this.colUnitsRequested,
            this.colBagsRequested,
            this.colPalletsRequested,
            this.colRemainingBalance,
            this.colUnitsProduced,
            this.colBagsProduced,
            this.colPalletsProduced,
            this.colPercentageComplete,
            this.colAllowOverrun,
            this.colEstimatiedShifts,
            this.GridColumn4});
            this.projectDetailsGridView.GridControl = this.projectDetailsGridControl;
            this.projectDetailsGridView.Name = "projectDetailsGridView";
            this.projectDetailsGridView.OptionsBehavior.Editable = false;
            this.projectDetailsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.projectDetailsGridView.OptionsView.ShowDetailButtons = false;
            this.projectDetailsGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.projectDetailsGridView_InitNewRow);
            this.projectDetailsGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.projectDetailsGridView_CellValueChanged);
            // 
            // colItemNumber
            // 
            this.colItemNumber.Caption = "Item #";
            this.colItemNumber.ColumnEdit = this.itemRepositoryItemLookUpEdit;
            this.colItemNumber.FieldName = "ProjectItem!Key";
            this.colItemNumber.Name = "colItemNumber";
            this.colItemNumber.Visible = true;
            this.colItemNumber.VisibleIndex = 2;
            // 
            // itemRepositoryItemLookUpEdit
            // 
            this.itemRepositoryItemLookUpEdit.AutoHeight = false;
            this.itemRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.itemRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 59, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CaseQuantity", "Case Quantity", 79, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BagsPerCase", "Bags Per Case", 79, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CasePerPallet", "Case Per Pallet", 82, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.itemRepositoryItemLookUpEdit.DataSource = this.itemXpView;
            this.itemRepositoryItemLookUpEdit.DisplayMember = "ItemCode";
            this.itemRepositoryItemLookUpEdit.Name = "itemRepositoryItemLookUpEdit";
            this.itemRepositoryItemLookUpEdit.ValueMember = "ItemID";
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
            // colOid
            // 
            this.colOid.FieldName = "Oid";
            this.colOid.Name = "colOid";
            // 
            // colHasChanges
            // 
            this.colHasChanges.FieldName = "HasChanges";
            this.colHasChanges.Name = "colHasChanges";
            this.colHasChanges.OptionsColumn.ReadOnly = true;
            // 
            // GridColumn1
            // 
            this.GridColumn1.FieldName = "Project!";
            this.GridColumn1.Name = "GridColumn1";
            // 
            // GridColumn2
            // 
            this.GridColumn2.FieldName = "Project!Key";
            this.GridColumn2.Name = "GridColumn2";
            // 
            // colCustomerPO
            // 
            this.colCustomerPO.FieldName = "CustomerPO";
            this.colCustomerPO.Name = "colCustomerPO";
            this.colCustomerPO.Visible = true;
            this.colCustomerPO.VisibleIndex = 1;
            this.colCustomerPO.Width = 49;
            // 
            // GridColumn3
            // 
            this.GridColumn3.FieldName = "ProjectItem!";
            this.GridColumn3.Name = "GridColumn3";
            // 
            // colUnitsRequested
            // 
            this.colUnitsRequested.FieldName = "UnitsRequested";
            this.colUnitsRequested.Name = "colUnitsRequested";
            this.colUnitsRequested.Visible = true;
            this.colUnitsRequested.VisibleIndex = 3;
            this.colUnitsRequested.Width = 49;
            // 
            // colBagsRequested
            // 
            this.colBagsRequested.FieldName = "BagsRequested";
            this.colBagsRequested.Name = "colBagsRequested";
            this.colBagsRequested.Visible = true;
            this.colBagsRequested.VisibleIndex = 4;
            this.colBagsRequested.Width = 49;
            // 
            // colPalletsRequested
            // 
            this.colPalletsRequested.FieldName = "PalletsRequested";
            this.colPalletsRequested.Name = "colPalletsRequested";
            this.colPalletsRequested.Visible = true;
            this.colPalletsRequested.VisibleIndex = 5;
            this.colPalletsRequested.Width = 49;
            // 
            // colRemainingBalance
            // 
            this.colRemainingBalance.Caption = "Remaining Balance";
            this.colRemainingBalance.FieldName = "RemainingBalance";
            this.colRemainingBalance.Name = "colRemainingBalance";
            this.colRemainingBalance.Visible = true;
            this.colRemainingBalance.VisibleIndex = 11;
            // 
            // colUnitsProduced
            // 
            this.colUnitsProduced.FieldName = "UnitsProduced";
            this.colUnitsProduced.Name = "colUnitsProduced";
            this.colUnitsProduced.OptionsColumn.AllowEdit = false;
            this.colUnitsProduced.Visible = true;
            this.colUnitsProduced.VisibleIndex = 6;
            this.colUnitsProduced.Width = 49;
            // 
            // colBagsProduced
            // 
            this.colBagsProduced.FieldName = "BagsProduced";
            this.colBagsProduced.Name = "colBagsProduced";
            this.colBagsProduced.OptionsColumn.AllowEdit = false;
            this.colBagsProduced.Visible = true;
            this.colBagsProduced.VisibleIndex = 7;
            this.colBagsProduced.Width = 49;
            // 
            // colPalletsProduced
            // 
            this.colPalletsProduced.FieldName = "PalletsProduced";
            this.colPalletsProduced.Name = "colPalletsProduced";
            this.colPalletsProduced.OptionsColumn.AllowEdit = false;
            this.colPalletsProduced.Visible = true;
            this.colPalletsProduced.VisibleIndex = 8;
            this.colPalletsProduced.Width = 49;
            // 
            // colPercentageComplete
            // 
            this.colPercentageComplete.DisplayFormat.FormatString = "F2";
            this.colPercentageComplete.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colPercentageComplete.FieldName = "PercentageComplete";
            this.colPercentageComplete.Name = "colPercentageComplete";
            this.colPercentageComplete.OptionsColumn.AllowEdit = false;
            this.colPercentageComplete.Visible = true;
            this.colPercentageComplete.VisibleIndex = 9;
            this.colPercentageComplete.Width = 49;
            // 
            // colAllowOverrun
            // 
            this.colAllowOverrun.FieldName = "AllowOverrun";
            this.colAllowOverrun.Name = "colAllowOverrun";
            this.colAllowOverrun.Visible = true;
            this.colAllowOverrun.VisibleIndex = 10;
            this.colAllowOverrun.Width = 63;
            // 
            // colEstimatiedShifts
            // 
            this.colEstimatiedShifts.DisplayFormat.FormatString = "f2";
            this.colEstimatiedShifts.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colEstimatiedShifts.FieldName = "EstimatedShifts";
            this.colEstimatiedShifts.Name = "colEstimatiedShifts";
            this.colEstimatiedShifts.OptionsColumn.AllowEdit = false;
            this.colEstimatiedShifts.Visible = true;
            this.colEstimatiedShifts.VisibleIndex = 12;
            // 
            // GridColumn4
            // 
            this.GridColumn4.FieldName = "ProjectItem!";
            this.GridColumn4.Name = "GridColumn4";
            this.GridColumn4.Visible = true;
            this.GridColumn4.VisibleIndex = 13;
            // 
            // moXtraTabPage
            // 
            this.moXtraTabPage.Controls.Add(this.splitContainerControl2);
            this.moXtraTabPage.Name = "moXtraTabPage";
            this.moXtraTabPage.Size = new System.Drawing.Size(856, 414);
            this.moXtraTabPage.Text = "Manufacturing Orders";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.moSearchGridControl);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.moDataEntrySplitContainerControl);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(856, 414);
            this.splitContainerControl2.SplitterPosition = 297;
            this.splitContainerControl2.TabIndex = 0;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // moSearchGridControl
            // 
            this.moSearchGridControl.DataSource = this.moSearchXpView;
            this.moSearchGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moSearchGridControl.Location = new System.Drawing.Point(0, 0);
            this.moSearchGridControl.MainView = this.moSearchGridView;
            this.moSearchGridControl.MenuManager = this.BarManager1;
            this.moSearchGridControl.Name = "moSearchGridControl";
            this.moSearchGridControl.Size = new System.Drawing.Size(297, 414);
            this.moSearchGridControl.TabIndex = 2;
            this.moSearchGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.moSearchGridView});
            // 
            // moSearchXpView
            // 
            this.moSearchXpView.ObjectType = typeof(DXDAL.SPGData.MO);
            this.moSearchXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("Item", DevExpress.Xpo.SortDirection.None, "[ProjectDetail.ProjectItem.ItemCode]", false, true),
            new DevExpress.Xpo.ViewProperty("Scheduled Start", DevExpress.Xpo.SortDirection.None, "[ScheduledStartDateTime]", false, true),
            new DevExpress.Xpo.ViewProperty("Status", DevExpress.Xpo.SortDirection.None, "[Status]", false, true),
            new DevExpress.Xpo.ViewProperty("MoId", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true),
            new DevExpress.Xpo.ViewProperty("ProjectId", DevExpress.Xpo.SortDirection.None, "[ProjectDetail.Project.Oid]", false, true)});
            // 
            // moSearchGridView
            // 
            this.moSearchGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItem,
            this.colScheduledStart,
            this.colStatus,
            this.colMoId,
            this.colMoProjectId});
            this.moSearchGridView.GridControl = this.moSearchGridControl;
            this.moSearchGridView.Name = "moSearchGridView";
            this.moSearchGridView.OptionsBehavior.Editable = false;
            this.moSearchGridView.OptionsView.ShowAutoFilterRow = true;
            this.moSearchGridView.OptionsView.ShowGroupPanel = false;
            this.moSearchGridView.Click += new System.EventHandler(this.moSearchGridView_Click);
            // 
            // colItem
            // 
            this.colItem.FieldName = "Item";
            this.colItem.Name = "colItem";
            this.colItem.Visible = true;
            this.colItem.VisibleIndex = 0;
            // 
            // colScheduledStart
            // 
            this.colScheduledStart.FieldName = "Scheduled Start";
            this.colScheduledStart.Name = "colScheduledStart";
            this.colScheduledStart.Visible = true;
            this.colScheduledStart.VisibleIndex = 1;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 2;
            // 
            // colMoId
            // 
            this.colMoId.FieldName = "MoId";
            this.colMoId.Name = "colMoId";
            // 
            // colMoProjectId
            // 
            this.colMoProjectId.FieldName = "ProjectId";
            this.colMoProjectId.Name = "colMoProjectId";
            // 
            // moDataEntrySplitContainerControl
            // 
            this.moDataEntrySplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moDataEntrySplitContainerControl.Horizontal = false;
            this.moDataEntrySplitContainerControl.Location = new System.Drawing.Point(0, 0);
            this.moDataEntrySplitContainerControl.Name = "moDataEntrySplitContainerControl";
            this.moDataEntrySplitContainerControl.Panel1.Controls.Add(this.saveMoSimpleButton);
            this.moDataEntrySplitContainerControl.Panel1.Controls.Add(this.addMoSimpleButton);
            this.moDataEntrySplitContainerControl.Panel1.Controls.Add(this.delMoSimpleButton);
            this.moDataEntrySplitContainerControl.Panel1.Controls.Add(this.labelControl13);
            this.moDataEntrySplitContainerControl.Panel1.Controls.Add(this.labelControl10);
            this.moDataEntrySplitContainerControl.Panel1.Controls.Add(this.moStatusComboBoxEdit);
            this.moDataEntrySplitContainerControl.Panel1.Controls.Add(this.labelControl11);
            this.moDataEntrySplitContainerControl.Panel1.Controls.Add(this.moScheduledStartDateEdit);
            this.moDataEntrySplitContainerControl.Panel1.Controls.Add(this.moProjectTextEdit);
            this.moDataEntrySplitContainerControl.Panel1.Controls.Add(this.labelControl12);
            this.moDataEntrySplitContainerControl.Panel1.Controls.Add(this.moProjectDetailLookupEdit);
            this.moDataEntrySplitContainerControl.Panel1.Text = "Panel1";
            this.moDataEntrySplitContainerControl.Panel2.Controls.Add(this.moMachineLineGridControl);
            this.moDataEntrySplitContainerControl.Panel2.Text = "Panel2";
            this.moDataEntrySplitContainerControl.Size = new System.Drawing.Size(554, 414);
            this.moDataEntrySplitContainerControl.SplitterPosition = 222;
            this.moDataEntrySplitContainerControl.TabIndex = 0;
            this.moDataEntrySplitContainerControl.Text = "splitContainerControl3";
            // 
            // saveMoSimpleButton
            // 
            this.saveMoSimpleButton.Location = new System.Drawing.Point(200, 3);
            this.saveMoSimpleButton.Name = "saveMoSimpleButton";
            this.saveMoSimpleButton.Size = new System.Drawing.Size(75, 23);
            this.saveMoSimpleButton.TabIndex = 24;
            this.saveMoSimpleButton.Text = "Save MO";
            // 
            // addMoSimpleButton
            // 
            this.addMoSimpleButton.Location = new System.Drawing.Point(37, 3);
            this.addMoSimpleButton.Name = "addMoSimpleButton";
            this.addMoSimpleButton.Size = new System.Drawing.Size(75, 23);
            this.addMoSimpleButton.TabIndex = 23;
            this.addMoSimpleButton.Text = "Add MO";
            // 
            // delMoSimpleButton
            // 
            this.delMoSimpleButton.Location = new System.Drawing.Point(118, 3);
            this.delMoSimpleButton.Name = "delMoSimpleButton";
            this.delMoSimpleButton.Size = new System.Drawing.Size(75, 23);
            this.delMoSimpleButton.TabIndex = 22;
            this.delMoSimpleButton.Text = "Delete MO";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(37, 93);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(68, 13);
            this.labelControl13.TabIndex = 20;
            this.labelControl13.Text = "Project Detail:";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(37, 178);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(54, 13);
            this.labelControl10.TabIndex = 19;
            this.labelControl10.Text = "MO Status:";
            // 
            // moStatusComboBoxEdit
            // 
            this.moStatusComboBoxEdit.Location = new System.Drawing.Point(138, 175);
            this.moStatusComboBoxEdit.MenuManager = this.BarManager1;
            this.moStatusComboBoxEdit.Name = "moStatusComboBoxEdit";
            this.moStatusComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.moStatusComboBoxEdit.Properties.DropDownRows = 4;
            this.moStatusComboBoxEdit.Size = new System.Drawing.Size(179, 20);
            this.moStatusComboBoxEdit.TabIndex = 18;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(37, 152);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(80, 13);
            this.labelControl11.TabIndex = 17;
            this.labelControl11.Text = "Scheduled Start:";
            // 
            // moScheduledStartDateEdit
            // 
            this.moScheduledStartDateEdit.EditValue = null;
            this.moScheduledStartDateEdit.Location = new System.Drawing.Point(138, 149);
            this.moScheduledStartDateEdit.MenuManager = this.BarManager1;
            this.moScheduledStartDateEdit.Name = "moScheduledStartDateEdit";
            this.moScheduledStartDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.moScheduledStartDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.moScheduledStartDateEdit.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.moScheduledStartDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.moScheduledStartDateEdit.Properties.CalendarTimeProperties.Mask.EditMask = "g";
            this.moScheduledStartDateEdit.Properties.DisplayFormat.FormatString = "g";
            this.moScheduledStartDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.moScheduledStartDateEdit.Properties.EditFormat.FormatString = "g";
            this.moScheduledStartDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.moScheduledStartDateEdit.Properties.Mask.BeepOnError = true;
            this.moScheduledStartDateEdit.Properties.Mask.EditMask = "g";
            this.moScheduledStartDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.moScheduledStartDateEdit.Properties.Mask.PlaceHolder = '0';
            this.moScheduledStartDateEdit.Properties.Name = "dateEdit1";
            this.moScheduledStartDateEdit.Properties.NullText = "[Select A Date]";
            this.moScheduledStartDateEdit.Properties.TimeEditWidth = 150;
            this.moScheduledStartDateEdit.Size = new System.Drawing.Size(179, 20);
            this.moScheduledStartDateEdit.TabIndex = 16;
            // 
            // moProjectTextEdit
            // 
            this.moProjectTextEdit.Location = new System.Drawing.Point(138, 71);
            this.moProjectTextEdit.MenuManager = this.BarManager1;
            this.moProjectTextEdit.Name = "moProjectTextEdit";
            this.moProjectTextEdit.Properties.ReadOnly = true;
            this.moProjectTextEdit.Size = new System.Drawing.Size(179, 20);
            this.moProjectTextEdit.TabIndex = 15;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(37, 74);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(38, 13);
            this.labelControl12.TabIndex = 14;
            this.labelControl12.Text = "Project:";
            // 
            // moProjectDetailLookupEdit
            // 
            this.moProjectDetailLookupEdit.Location = new System.Drawing.Point(37, 123);
            this.moProjectDetailLookupEdit.MenuManager = this.BarManager1;
            this.moProjectDetailLookupEdit.Name = "moProjectDetailLookupEdit";
            this.moProjectDetailLookupEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.moProjectDetailLookupEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerPO", "Customer PO", 73, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProjectItem.ItemCode", "Item Code", 123, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Center, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("UnitsRequested", "Units Requested", 89, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BagsRequested", "Bags Requested", 88, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.moProjectDetailLookupEdit.Properties.DataSource = this.projectDetailsXpCollection;
            this.moProjectDetailLookupEdit.Properties.DisplayMember = "ProjectItem!Key";
            this.moProjectDetailLookupEdit.Properties.NullText = "";
            this.moProjectDetailLookupEdit.Properties.PopupWidthMode = DevExpress.XtraEditors.PopupWidthMode.ContentWidth;
            this.moProjectDetailLookupEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.moProjectDetailLookupEdit.Properties.ValueMember = "Oid";
            this.moProjectDetailLookupEdit.Size = new System.Drawing.Size(413, 20);
            this.moProjectDetailLookupEdit.TabIndex = 21;
            // 
            // moMachineLineGridControl
            // 
            this.moMachineLineGridControl.DataSource = this.moSearchXpView;
            this.moMachineLineGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moMachineLineGridControl.Location = new System.Drawing.Point(0, 0);
            this.moMachineLineGridControl.MainView = this.moMachineLineGridView;
            this.moMachineLineGridControl.MenuManager = this.BarManager1;
            this.moMachineLineGridControl.Name = "moMachineLineGridControl";
            this.moMachineLineGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit2,
            this.repositoryItemButtonEdit1});
            this.moMachineLineGridControl.Size = new System.Drawing.Size(554, 187);
            this.moMachineLineGridControl.TabIndex = 0;
            this.moMachineLineGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.moMachineLineGridView});
            // 
            // moMachineLineGridView
            // 
            this.moMachineLineGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idGridColumn,
            this.moIdGridColumn,
            this.machineLineNameGridColumn,
            this.startTimeGridColumn,
            this.endTimeGridColumn,
            this.gridColumn5});
            this.moMachineLineGridView.GridControl = this.moMachineLineGridControl;
            this.moMachineLineGridView.Name = "moMachineLineGridView";
            this.moMachineLineGridView.OptionsView.ShowAutoFilterRow = true;
            this.moMachineLineGridView.OptionsView.ShowGroupPanel = false;
            this.moMachineLineGridView.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.moMachineLineGridView_RowDeleting);
            // 
            // idGridColumn
            // 
            this.idGridColumn.FieldName = "Oid";
            this.idGridColumn.Name = "idGridColumn";
            // 
            // moIdGridColumn
            // 
            this.moIdGridColumn.FieldName = "Mo.Oid";
            this.moIdGridColumn.Name = "moIdGridColumn";
            // 
            // machineLineNameGridColumn
            // 
            this.machineLineNameGridColumn.Caption = "Machine Line";
            this.machineLineNameGridColumn.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.machineLineNameGridColumn.Name = "machineLineNameGridColumn";
            this.machineLineNameGridColumn.Visible = true;
            this.machineLineNameGridColumn.VisibleIndex = 1;
            this.machineLineNameGridColumn.Width = 172;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MachineLineID", "Machine Line ID", 98, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MachineLineName", "Machine Line Name", 101, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.repositoryItemLookUpEdit2.DataSource = this.machineLineXpCollection;
            this.repositoryItemLookUpEdit2.DisplayMember = "MachineLineName";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.ValueMember = "MachineLineID";
            // 
            // machineLineXpCollection
            // 
            this.machineLineXpCollection.ObjectType = typeof(DXDAL.SPGData.MachineLine);
            // 
            // startTimeGridColumn
            // 
            this.startTimeGridColumn.DisplayFormat.FormatString = "g";
            this.startTimeGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.startTimeGridColumn.FieldName = "StartTime";
            this.startTimeGridColumn.Name = "startTimeGridColumn";
            this.startTimeGridColumn.Visible = true;
            this.startTimeGridColumn.VisibleIndex = 2;
            this.startTimeGridColumn.Width = 172;
            // 
            // endTimeGridColumn
            // 
            this.endTimeGridColumn.DisplayFormat.FormatString = "g";
            this.endTimeGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.endTimeGridColumn.FieldName = "EndTime";
            this.endTimeGridColumn.Name = "endTimeGridColumn";
            this.endTimeGridColumn.Visible = true;
            this.endTimeGridColumn.VisibleIndex = 3;
            this.endTimeGridColumn.Width = 172;
            // 
            // gridColumn5
            // 
            this.gridColumn5.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowSize = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 20;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // auditXtraTabPage
            // 
            this.auditXtraTabPage.Controls.Add(this.detailHistorySimpleButton);
            this.auditXtraTabPage.Controls.Add(this.detailHistoryGridControl);
            this.auditXtraTabPage.Name = "auditXtraTabPage";
            this.auditXtraTabPage.Size = new System.Drawing.Size(856, 414);
            this.auditXtraTabPage.Text = "Project History";
            // 
            // detailHistorySimpleButton
            // 
            this.detailHistorySimpleButton.Location = new System.Drawing.Point(3, 3);
            this.detailHistorySimpleButton.Name = "detailHistorySimpleButton";
            this.detailHistorySimpleButton.Size = new System.Drawing.Size(147, 23);
            this.detailHistorySimpleButton.TabIndex = 3;
            this.detailHistorySimpleButton.Text = "Retrieve Detail History";
            this.detailHistorySimpleButton.Click += new System.EventHandler(this.detailHistorySimpleButton_Click);
            // 
            // detailHistoryGridControl
            // 
            this.detailHistoryGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailHistoryGridControl.Location = new System.Drawing.Point(0, 32);
            this.detailHistoryGridControl.MainView = this.detailHistoryGridView;
            this.detailHistoryGridControl.MenuManager = this.BarManager1;
            this.detailHistoryGridControl.Name = "detailHistoryGridControl";
            this.detailHistoryGridControl.Size = new System.Drawing.Size(529, 382);
            this.detailHistoryGridControl.TabIndex = 2;
            this.detailHistoryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.detailHistoryGridView});
            this.detailHistoryGridControl.Visible = false;
            // 
            // detailHistoryGridView
            // 
            this.detailHistoryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RecordIDGridColumn,
            this.DateChangedGridColumn,
            this.PropertyNameGridColumn,
            this.PrevValueGridColumn,
            this.NewValueGridColumn});
            this.detailHistoryGridView.GridControl = this.detailHistoryGridControl;
            this.detailHistoryGridView.Name = "detailHistoryGridView";
            // 
            // RecordIDGridColumn
            // 
            this.RecordIDGridColumn.FieldName = "RecordID";
            this.RecordIDGridColumn.Name = "RecordIDGridColumn";
            this.RecordIDGridColumn.Visible = true;
            this.RecordIDGridColumn.VisibleIndex = 0;
            // 
            // DateChangedGridColumn
            // 
            this.DateChangedGridColumn.DisplayFormat.FormatString = "d";
            this.DateChangedGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DateChangedGridColumn.FieldName = "DateChanged";
            this.DateChangedGridColumn.Name = "DateChangedGridColumn";
            this.DateChangedGridColumn.Visible = true;
            this.DateChangedGridColumn.VisibleIndex = 1;
            // 
            // PropertyNameGridColumn
            // 
            this.PropertyNameGridColumn.Caption = "Field Name";
            this.PropertyNameGridColumn.FieldName = "PropertyName";
            this.PropertyNameGridColumn.Name = "PropertyNameGridColumn";
            this.PropertyNameGridColumn.Visible = true;
            this.PropertyNameGridColumn.VisibleIndex = 2;
            // 
            // PrevValueGridColumn
            // 
            this.PrevValueGridColumn.FieldName = "PrevValue";
            this.PrevValueGridColumn.Name = "PrevValueGridColumn";
            this.PrevValueGridColumn.Visible = true;
            this.PrevValueGridColumn.VisibleIndex = 3;
            // 
            // NewValueGridColumn
            // 
            this.NewValueGridColumn.FieldName = "NewValue";
            this.NewValueGridColumn.Name = "NewValueGridColumn";
            this.NewValueGridColumn.Visible = true;
            this.NewValueGridColumn.VisibleIndex = 4;
            // 
            // moMachineLineXpCollection
            // 
            this.moMachineLineXpCollection.DisplayableProperties = "Oid;Mo.Oid;MachineLine.MachineLineID;MachineLine.MachineLineName;StartTime;EndTim" +
    "e";
            this.moMachineLineXpCollection.ObjectType = typeof(DXDAL.SPGData.MoMachineLine);
            // 
            // ProjectsXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 514);
            this.Controls.Add(this.SplitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProjectsXtraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projects";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjectsXtraForm_FormClosing);
            this.Load += new System.EventHandler(this.ProjectsXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deleteRepositoryItemButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemXpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).EndInit();
            this.SplitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.projectSearchGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectSearchXpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectSearchGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsXtraTabControl)).EndInit();
            this.projectsXtraTabControl.ResumeLayout(false);
            this.dataEntryXtraTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataEntrySplitContainerControl)).EndInit();
            this.dataEntrySplitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.notesMemoExEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectStatusComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqDeliveryDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqDeliveryDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqShipDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqShipDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqStartDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reqStartDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerXpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oidTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDetailsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDetailsXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDetailsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemRepositoryItemLookUpEdit)).EndInit();
            this.moXtraTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moSearchGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moSearchXpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moSearchGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moDataEntrySplitContainerControl)).EndInit();
            this.moDataEntrySplitContainerControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.moStatusComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moScheduledStartDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moScheduledStartDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moProjectTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moProjectDetailLookupEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moMachineLineGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moMachineLineGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machineLineXpCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.auditXtraTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detailHistoryGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailHistoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moMachineLineXpCollection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal DevExpress.XtraBars.BarManager BarManager1;
		internal DevExpress.XtraBars.Bar projectsBar;
		internal DevExpress.XtraBars.Bar Bar2;
		internal DevExpress.XtraBars.Bar Bar3;
		internal DevExpress.XtraBars.BarDockControl barDockControlTop;
		internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
		internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
		internal DevExpress.XtraBars.BarDockControl barDockControlRight;
		internal DevExpress.XtraBars.BarButtonItem addBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem editBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem deleteBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem cancelBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem saveBarButtonItem;
		internal DevExpress.XtraEditors.SplitContainerControl SplitContainerControl1;
		internal DevExpress.XtraEditors.SplitContainerControl dataEntrySplitContainerControl;
		internal DevExpress.XtraGrid.GridControl projectSearchGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView projectSearchGridView;
		internal DevExpress.Xpo.XPView projectSearchXpView;
		internal DevExpress.XtraGrid.Columns.GridColumn colProjectID;
		internal DevExpress.XtraGrid.Columns.GridColumn colProject;
		internal DevExpress.XtraGrid.Columns.GridColumn colReqStartDateGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn colCustomerGridColumn;
		internal DevExpress.XtraEditors.TextEdit oidTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.TextEdit projectTextEdit;
		internal DevExpress.XtraEditors.LookUpEdit customerLookUpEdit;
		internal DevExpress.Xpo.XPView customerXpView;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraEditors.DateEdit reqStartDateEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		internal DevExpress.XtraEditors.LabelControl LabelControl6;
		internal DevExpress.XtraEditors.DateEdit reqDeliveryDateEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl5;
		internal DevExpress.XtraEditors.DateEdit reqShipDateEdit;
		internal DevExpress.XtraEditors.ComboBoxEdit projectStatusComboBoxEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl7;
		internal DevExpress.XtraEditors.LabelControl LabelControl8;
		//Friend WithEvents scheduledWeekDatePeriodEdit As SuperiorPackGroup.DatePeriodEdit
		internal DevExpress.XtraEditors.MemoExEdit notesMemoExEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl9;
		internal DevExpress.XtraGrid.GridControl projectDetailsGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView projectDetailsGridView;
		internal DevExpress.Xpo.XPCollection projectDetailsXpCollection;
		internal DevExpress.XtraGrid.Columns.GridColumn colOid;
		internal DevExpress.XtraGrid.Columns.GridColumn colHasChanges;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn2;
		internal DevExpress.XtraGrid.Columns.GridColumn colCustomerPO;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn3;
		internal DevExpress.XtraGrid.Columns.GridColumn colUnitsRequested;
		internal DevExpress.XtraGrid.Columns.GridColumn colBagsRequested;
		internal DevExpress.XtraGrid.Columns.GridColumn colPalletsRequested;
		internal DevExpress.XtraGrid.Columns.GridColumn colUnitsProduced;
		internal DevExpress.XtraGrid.Columns.GridColumn colBagsProduced;
		internal DevExpress.XtraGrid.Columns.GridColumn colPalletsProduced;
		internal DevExpress.XtraGrid.Columns.GridColumn colPercentageComplete;
		internal DevExpress.XtraGrid.Columns.GridColumn colAllowOverrun;
		internal DevExpress.XtraGrid.Columns.GridColumn delGridColumn;
		internal DevExpress.Xpo.XPView itemXpView;
		internal DevExpress.XtraGrid.Columns.GridColumn colEstimatiedShifts;
		internal DevExpress.XtraTab.XtraTabControl projectsXtraTabControl;
		internal DevExpress.XtraTab.XtraTabPage dataEntryXtraTabPage;
		internal DevExpress.XtraTab.XtraTabPage auditXtraTabPage;
		internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit deleteRepositoryItemButtonEdit;
		internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit RepositoryItemLookUpEdit1;
		internal DevExpress.XtraGrid.Columns.GridColumn colItemNumber;
		internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit itemRepositoryItemLookUpEdit;
		internal DevExpress.XtraEditors.SimpleButton detailHistorySimpleButton;
		internal DevExpress.XtraGrid.GridControl detailHistoryGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView detailHistoryGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn RecordIDGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn DateChangedGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn PropertyNameGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn PrevValueGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn NewValueGridColumn;
		internal DevExpress.XtraBars.BarButtonItem printProductionReportBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem printBomAvailabilityBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem refreshBarButtonItem;
		internal DevExpress.XtraGrid.Columns.GridColumn colRemainingBalance;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn4;
        private DevExpress.XtraTab.XtraTabPage moXtraTabPage;
        private XPView moSearchXpView;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraGrid.GridControl moSearchGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colItem;
        private DevExpress.XtraGrid.Columns.GridColumn colScheduledStart;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colMoId;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectId1;
        private DevExpress.XtraEditors.SplitContainerControl moDataEntrySplitContainerControl;
        private DevExpress.XtraGrid.GridControl moMachineLineGridControl;
        private XPCollection moMachineLineXpCollection;
        private DevExpress.XtraGrid.Views.Grid.GridView moMachineLineGridView;
        private DevExpress.XtraGrid.Columns.GridColumn idGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn moIdGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn machineLineNameGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn startTimeGridColumn;
        private DevExpress.XtraGrid.Columns.GridColumn endTimeGridColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private XPCollection machineLineXpCollection;
        internal DevExpress.XtraEditors.LabelControl labelControl13;
        internal DevExpress.XtraEditors.LabelControl labelControl10;
        internal DevExpress.XtraEditors.ComboBoxEdit moStatusComboBoxEdit;
        internal DevExpress.XtraEditors.LabelControl labelControl11;
        internal DevExpress.XtraEditors.DateEdit moScheduledStartDateEdit;
        internal DevExpress.XtraEditors.TextEdit moProjectTextEdit;
        internal DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LookUpEdit moProjectDetailLookupEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.SimpleButton saveMoSimpleButton;
        private DevExpress.XtraEditors.SimpleButton addMoSimpleButton;
        private DevExpress.XtraEditors.SimpleButton delMoSimpleButton;
        private DevExpress.XtraGrid.Views.Grid.GridView moSearchGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colMoProjectId;
    }

}