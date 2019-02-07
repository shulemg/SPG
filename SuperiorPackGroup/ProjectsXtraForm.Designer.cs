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
			this.auditXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.detailHistorySimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.detailHistoryGridControl = new DevExpress.XtraGrid.GridControl();
			this.detailHistoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.RecordIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.DateChangedGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.PropertyNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.PrevValueGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.NewValueGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)this.deleteRepositoryItemButtonEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemLookUpEdit1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.BarManager1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.SplitContainerControl1).BeginInit();
			this.SplitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.projectSearchGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.projectSearchXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.projectSearchGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.projectsXtraTabControl).BeginInit();
			this.projectsXtraTabControl.SuspendLayout();
			this.dataEntryXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dataEntrySplitContainerControl).BeginInit();
			this.dataEntrySplitContainerControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.notesMemoExEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.projectStatusComboBoxEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.reqDeliveryDateEdit.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.reqDeliveryDateEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.reqShipDateEdit.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.reqShipDateEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.reqStartDateEdit.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.reqStartDateEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customerLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customerXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.projectTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.oidTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.projectDetailsGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.projectDetailsXpCollection).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.projectDetailsGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemRepositoryItemLookUpEdit).BeginInit();
			this.auditXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.detailHistoryGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.detailHistoryGridView).BeginInit();
			this.SuspendLayout();
			//
			//deleteRepositoryItemButtonEdit
			//
			this.deleteRepositoryItemButtonEdit.AutoHeight = false;
			this.deleteRepositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
			this.deleteRepositoryItemButtonEdit.Name = "deleteRepositoryItemButtonEdit";
			this.deleteRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			//
			//RepositoryItemLookUpEdit1
			//
			this.RepositoryItemLookUpEdit1.AutoHeight = false;
			this.RepositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.RepositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 59, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CaseQuantity", "Case Quantity", 79, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BagsPerCase", "Bags Per Case", 79, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CasePerPallet", "Case Per Pallet", 82, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)
			});
			this.RepositoryItemLookUpEdit1.DataSource = this.itemXpView;
			this.RepositoryItemLookUpEdit1.DisplayMember = "ItemCode";
			this.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1";
			this.RepositoryItemLookUpEdit1.ValueMember = "ItemID";
			//
			//itemXpView
			//
			this.itemXpView.CriteriaString = "[ItemType] In ('IG', 'FG')";
			this.itemXpView.ObjectType = typeof(DXDAL.SPGData.Items);
			this.itemXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[ItemID]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[ItemCode]", false, true),
				new DevExpress.Xpo.ViewProperty("CaseQuantity", DevExpress.Xpo.SortDirection.None, "[intUnitsPerCase]", false, true),
				new DevExpress.Xpo.ViewProperty("BagsPerCase", DevExpress.Xpo.SortDirection.None, "[BagsPerCase]", false, true),
				new DevExpress.Xpo.ViewProperty("CasePerPallet", DevExpress.Xpo.SortDirection.None, "[intCasesPerPallet]", false, true)
			});
			//
			//BarManager1
			//
			this.BarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.projectsBar, this.Bar2, this.Bar3});
			this.BarManager1.DockControls.Add(this.barDockControlTop);
			this.BarManager1.DockControls.Add(this.barDockControlBottom);
			this.BarManager1.DockControls.Add(this.barDockControlLeft);
			this.BarManager1.DockControls.Add(this.barDockControlRight);
			this.BarManager1.Form = this;
			this.BarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.addBarButtonItem, this.editBarButtonItem, this.deleteBarButtonItem, this.cancelBarButtonItem, this.saveBarButtonItem, this.printProductionReportBarButtonItem, this.printBomAvailabilityBarButtonItem, this.refreshBarButtonItem});
			this.BarManager1.MainMenu = this.Bar2;
			this.BarManager1.MaxItemId = 10;
			this.BarManager1.StatusBar = this.Bar3;
			//
			//projectsBar
			//
			this.projectsBar.BarName = "Tools";
			this.projectsBar.DockCol = 0;
			this.projectsBar.DockRow = 1;
			this.projectsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.projectsBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.addBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.editBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.deleteBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.cancelBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.saveBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.printProductionReportBarButtonItem, true),
				new DevExpress.XtraBars.LinkPersistInfo(this.printBomAvailabilityBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.refreshBarButtonItem, true)
			});
			this.projectsBar.OptionsBar.UseWholeRow = true;
			this.projectsBar.Text = "Tools";
			//
			//addBarButtonItem
			//
			this.addBarButtonItem.Caption = "&Add Project";
			this.addBarButtonItem.Id = 0;
			this.addBarButtonItem.Name = "addBarButtonItem";
			//
			//editBarButtonItem
			//
			this.editBarButtonItem.Caption = "&Edit Project";
			this.editBarButtonItem.Id = 1;
			this.editBarButtonItem.Name = "editBarButtonItem";
			//
			//deleteBarButtonItem
			//
			this.deleteBarButtonItem.Caption = "Delete Project";
			this.deleteBarButtonItem.Id = 2;
			this.deleteBarButtonItem.Name = "deleteBarButtonItem";
			//
			//cancelBarButtonItem
			//
			this.cancelBarButtonItem.Caption = "&Cancel Changes";
			this.cancelBarButtonItem.Id = 3;
			this.cancelBarButtonItem.Name = "cancelBarButtonItem";
			//
			//saveBarButtonItem
			//
			this.saveBarButtonItem.Caption = "&Save Changes";
			this.saveBarButtonItem.Id = 4;
			this.saveBarButtonItem.Name = "saveBarButtonItem";
			//
			//printProductionReportBarButtonItem
			//
			this.printProductionReportBarButtonItem.Caption = "Print &Production Report";
			this.printProductionReportBarButtonItem.Id = 5;
			this.printProductionReportBarButtonItem.Name = "printProductionReportBarButtonItem";
			//
			//printBomAvailabilityBarButtonItem
			//
			this.printBomAvailabilityBarButtonItem.Caption = "Print &Bom Availability";
			this.printBomAvailabilityBarButtonItem.Id = 6;
			this.printBomAvailabilityBarButtonItem.Name = "printBomAvailabilityBarButtonItem";
			//
			//refreshBarButtonItem
			//
			this.refreshBarButtonItem.Caption = "Refresh";
			this.refreshBarButtonItem.Id = 9;
			this.refreshBarButtonItem.Name = "refreshBarButtonItem";
			//
			//Bar2
			//
			this.Bar2.BarName = "Main menu";
			this.Bar2.DockCol = 0;
			this.Bar2.DockRow = 0;
			this.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.Bar2.OptionsBar.MultiLine = true;
			this.Bar2.OptionsBar.UseWholeRow = true;
			this.Bar2.Text = "Main menu";
			//
			//Bar3
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
			//barDockControlTop
			//
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.BarManager1;
			this.barDockControlTop.Size = new System.Drawing.Size(797, 49);
			//
			//barDockControlBottom
			//
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 491);
			this.barDockControlBottom.Manager = this.BarManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(797, 23);
			//
			//barDockControlLeft
			//
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 49);
			this.barDockControlLeft.Manager = this.BarManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 442);
			//
			//barDockControlRight
			//
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(797, 49);
			this.barDockControlRight.Manager = this.BarManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 442);
			//
			//SplitContainerControl1
			//
			this.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainerControl1.Location = new System.Drawing.Point(0, 49);
			this.SplitContainerControl1.Name = "SplitContainerControl1";
			this.SplitContainerControl1.Panel1.Controls.Add(this.projectSearchGridControl);
			this.SplitContainerControl1.Panel1.MinSize = 250;
			this.SplitContainerControl1.Panel1.Text = "Panel1";
			this.SplitContainerControl1.Panel2.Controls.Add(this.projectsXtraTabControl);
			this.SplitContainerControl1.Panel2.Text = "Panel2";
			this.SplitContainerControl1.Size = new System.Drawing.Size(797, 442);
			this.SplitContainerControl1.TabIndex = 4;
			this.SplitContainerControl1.Text = "SplitContainerControl1";
			//
			//projectSearchGridControl
			//
			this.projectSearchGridControl.DataSource = this.projectSearchXpView;
			this.projectSearchGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.projectSearchGridControl.Location = new System.Drawing.Point(0, 0);
			this.projectSearchGridControl.MainView = this.projectSearchGridView;
			this.projectSearchGridControl.MenuManager = this.BarManager1;
			this.projectSearchGridControl.Name = "projectSearchGridControl";
			this.projectSearchGridControl.Size = new System.Drawing.Size(250, 442);
			this.projectSearchGridControl.TabIndex = 0;
			this.projectSearchGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.projectSearchGridView});
			//
			//projectSearchXpView
			//
			this.projectSearchXpView.ObjectType = typeof(DXDAL.SPGData.Project);
			this.projectSearchXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("ProjectID", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true),
				new DevExpress.Xpo.ViewProperty("Project", DevExpress.Xpo.SortDirection.None, "[project]", false, true),
				new DevExpress.Xpo.ViewProperty("Req.StartDate", DevExpress.Xpo.SortDirection.Descending, "[RequestedStartDate]", false, true),
				new DevExpress.Xpo.ViewProperty("Customer", DevExpress.Xpo.SortDirection.None, "[Customer.CustomerName]", false, true)
			});
			//
			//projectSearchGridView
			//
			this.projectSearchGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colProjectID, this.colProject, this.colCustomerGridColumn, this.colReqStartDateGridColumn});
			this.projectSearchGridView.GridControl = this.projectSearchGridControl;
			this.projectSearchGridView.Name = "projectSearchGridView";
			this.projectSearchGridView.OptionsBehavior.Editable = false;
			this.projectSearchGridView.OptionsView.ShowAutoFilterRow = true;
			this.projectSearchGridView.OptionsView.ShowGroupPanel = false;
			//
			//colProjectID
			//
			this.colProjectID.FieldName = "ProjectID";
			this.colProjectID.Name = "colProjectID";
			this.colProjectID.OptionsColumn.ReadOnly = true;
			//
			//colProject
			//
			this.colProject.FieldName = "Project";
			this.colProject.Name = "colProject";
			this.colProject.OptionsColumn.ReadOnly = true;
			this.colProject.Visible = true;
			this.colProject.VisibleIndex = 0;
			//
			//colCustomerGridColumn
			//
			this.colCustomerGridColumn.FieldName = "Customer";
			this.colCustomerGridColumn.Name = "colCustomerGridColumn";
			this.colCustomerGridColumn.Visible = true;
			this.colCustomerGridColumn.VisibleIndex = 1;
			//
			//colReqStartDateGridColumn
			//
			this.colReqStartDateGridColumn.Caption = "Req. Start Date";
			this.colReqStartDateGridColumn.FieldName = "Req.StartDate";
			this.colReqStartDateGridColumn.Name = "colReqStartDateGridColumn";
			this.colReqStartDateGridColumn.OptionsColumn.ReadOnly = true;
			this.colReqStartDateGridColumn.Visible = true;
			this.colReqStartDateGridColumn.VisibleIndex = 2;
			//
			//projectsXtraTabControl
			//
			this.projectsXtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.projectsXtraTabControl.Location = new System.Drawing.Point(0, 0);
			this.projectsXtraTabControl.Name = "projectsXtraTabControl";
			this.projectsXtraTabControl.SelectedTabPage = this.dataEntryXtraTabPage;
			this.projectsXtraTabControl.Size = new System.Drawing.Size(542, 442);
			this.projectsXtraTabControl.TabIndex = 1;
			this.projectsXtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {this.dataEntryXtraTabPage, this.auditXtraTabPage});
			//
			//dataEntryXtraTabPage
			//
			this.dataEntryXtraTabPage.Controls.Add(this.dataEntrySplitContainerControl);
			this.dataEntryXtraTabPage.Name = "dataEntryXtraTabPage";
			this.dataEntryXtraTabPage.Size = new System.Drawing.Size(536, 414);
			this.dataEntryXtraTabPage.Text = "Project";
			//
			//dataEntrySplitContainerControl
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
			this.dataEntrySplitContainerControl.Size = new System.Drawing.Size(536, 414);
			this.dataEntrySplitContainerControl.TabIndex = 0;
			this.dataEntrySplitContainerControl.Text = "SplitContainerControl2";
			//
			//notesMemoExEdit
			//
			this.notesMemoExEdit.Location = new System.Drawing.Point(113, 135);
			this.notesMemoExEdit.MenuManager = this.BarManager1;
			this.notesMemoExEdit.Name = "notesMemoExEdit";
			this.notesMemoExEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.notesMemoExEdit.Size = new System.Drawing.Size(399, 20);
			this.notesMemoExEdit.TabIndex = 17;
			//
			//LabelControl9
			//
			this.LabelControl9.Location = new System.Drawing.Point(31, 135);
			this.LabelControl9.Name = "LabelControl9";
			this.LabelControl9.Size = new System.Drawing.Size(32, 13);
			this.LabelControl9.TabIndex = 16;
			this.LabelControl9.Text = "Notes:";
			//
			//LabelControl8
			//
			this.LabelControl8.Location = new System.Drawing.Point(274, 112);
			this.LabelControl8.Name = "LabelControl8";
			this.LabelControl8.Size = new System.Drawing.Size(83, 13);
			this.LabelControl8.TabIndex = 14;
			this.LabelControl8.Text = "Scheduled Week:";
			//
			//LabelControl7
			//
			this.LabelControl7.Location = new System.Drawing.Point(31, 112);
			this.LabelControl7.Name = "LabelControl7";
			this.LabelControl7.Size = new System.Drawing.Size(72, 13);
			this.LabelControl7.TabIndex = 13;
			this.LabelControl7.Text = "Project Status:";
			//
			//projectStatusComboBoxEdit
			//
			this.projectStatusComboBoxEdit.Location = new System.Drawing.Point(113, 109);
			this.projectStatusComboBoxEdit.MenuManager = this.BarManager1;
			this.projectStatusComboBoxEdit.Name = "projectStatusComboBoxEdit";
			this.projectStatusComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.projectStatusComboBoxEdit.Size = new System.Drawing.Size(132, 20);
			this.projectStatusComboBoxEdit.TabIndex = 12;
			//
			//LabelControl6
			//
			this.LabelControl6.Location = new System.Drawing.Point(274, 85);
			this.LabelControl6.Name = "LabelControl6";
			this.LabelControl6.Size = new System.Drawing.Size(95, 13);
			this.LabelControl6.TabIndex = 11;
			this.LabelControl6.Text = "Req. Delivery Date:";
			//
			//reqDeliveryDateEdit
			//
			this.reqDeliveryDateEdit.EditValue = null;
			this.reqDeliveryDateEdit.Location = new System.Drawing.Point(375, 82);
			this.reqDeliveryDateEdit.MenuManager = this.BarManager1;
			this.reqDeliveryDateEdit.Name = "reqDeliveryDateEdit";
			this.reqDeliveryDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.reqDeliveryDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.reqDeliveryDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.reqDeliveryDateEdit.Properties.Mask.EditMask = "D";
			this.reqDeliveryDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
			this.reqDeliveryDateEdit.Properties.NullText = "[Select A Date]";
			this.reqDeliveryDateEdit.Size = new System.Drawing.Size(137, 20);
			this.reqDeliveryDateEdit.TabIndex = 10;
			//
			//LabelControl5
			//
			this.LabelControl5.Location = new System.Drawing.Point(31, 85);
			this.LabelControl5.Name = "LabelControl5";
			this.LabelControl5.Size = new System.Drawing.Size(76, 13);
			this.LabelControl5.TabIndex = 9;
			this.LabelControl5.Text = "Req. Ship Date:";
			//
			//reqShipDateEdit
			//
			this.reqShipDateEdit.EditValue = null;
			this.reqShipDateEdit.Location = new System.Drawing.Point(113, 82);
			this.reqShipDateEdit.MenuManager = this.BarManager1;
			this.reqShipDateEdit.Name = "reqShipDateEdit";
			this.reqShipDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.reqShipDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.reqShipDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.reqShipDateEdit.Properties.Mask.EditMask = "D";
			this.reqShipDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
			this.reqShipDateEdit.Properties.NullText = "[Select A Date]";
			this.reqShipDateEdit.Size = new System.Drawing.Size(132, 20);
			this.reqShipDateEdit.TabIndex = 8;
			//
			//LabelControl4
			//
			this.LabelControl4.Location = new System.Drawing.Point(274, 58);
			this.LabelControl4.Name = "LabelControl4";
			this.LabelControl4.Size = new System.Drawing.Size(80, 13);
			this.LabelControl4.TabIndex = 7;
			this.LabelControl4.Text = "Req. Start Date:";
			//
			//reqStartDateEdit
			//
			this.reqStartDateEdit.EditValue = null;
			this.reqStartDateEdit.Location = new System.Drawing.Point(375, 55);
			this.reqStartDateEdit.MenuManager = this.BarManager1;
			this.reqStartDateEdit.Name = "reqStartDateEdit";
			this.reqStartDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.reqStartDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.reqStartDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.reqStartDateEdit.Properties.Mask.EditMask = "D";
			this.reqStartDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
			this.reqStartDateEdit.Properties.NullText = "[Select A Date]";
			this.reqStartDateEdit.Size = new System.Drawing.Size(137, 20);
			this.reqStartDateEdit.TabIndex = 6;
			//
			//LabelControl3
			//
			this.LabelControl3.Location = new System.Drawing.Point(31, 58);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(50, 13);
			this.LabelControl3.TabIndex = 5;
			this.LabelControl3.Text = "Customer:";
			//
			//customerLookUpEdit
			//
			this.customerLookUpEdit.Location = new System.Drawing.Point(113, 55);
			this.customerLookUpEdit.MenuManager = this.BarManager1;
			this.customerLookUpEdit.Name = "customerLookUpEdit";
			this.customerLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.customerLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerID", "Customer ID", 83, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Customer Name", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)
			});
			this.customerLookUpEdit.Properties.DataSource = this.customerXpView;
			this.customerLookUpEdit.Properties.DisplayMember = "CustomerName";
			this.customerLookUpEdit.Properties.NullText = "[Select A Customer]";
			this.customerLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.customerLookUpEdit.Properties.ValueMember = "CustomerID";
			this.customerLookUpEdit.Size = new System.Drawing.Size(132, 20);
			this.customerLookUpEdit.TabIndex = 4;
			//
			//customerXpView
			//
			this.customerXpView.CriteriaString = "[Inactive] = False";
			this.customerXpView.ObjectType = typeof(DXDAL.SPGData.Customers);
			this.customerXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[CustomerID]", false, true),
				new DevExpress.Xpo.ViewProperty("CustomerName", DevExpress.Xpo.SortDirection.None, "[CustomerName]", false, true)
			});
			//
			//projectTextEdit
			//
			this.projectTextEdit.Location = new System.Drawing.Point(375, 28);
			this.projectTextEdit.MenuManager = this.BarManager1;
			this.projectTextEdit.Name = "projectTextEdit";
			this.projectTextEdit.Size = new System.Drawing.Size(137, 20);
			this.projectTextEdit.TabIndex = 3;
			//
			//LabelControl2
			//
			this.LabelControl2.Location = new System.Drawing.Point(274, 31);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(38, 13);
			this.LabelControl2.TabIndex = 2;
			this.LabelControl2.Text = "Project:";
			//
			//LabelControl1
			//
			this.LabelControl1.Location = new System.Drawing.Point(31, 31);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(56, 13);
			this.LabelControl1.TabIndex = 1;
			this.LabelControl1.Text = "Internal ID:";
			//
			//oidTextEdit
			//
			this.oidTextEdit.Enabled = false;
			this.oidTextEdit.Location = new System.Drawing.Point(113, 28);
			this.oidTextEdit.MenuManager = this.BarManager1;
			this.oidTextEdit.Name = "oidTextEdit";
			this.oidTextEdit.Properties.ReadOnly = true;
			this.oidTextEdit.Size = new System.Drawing.Size(132, 20);
			this.oidTextEdit.TabIndex = 0;
			//
			//projectDetailsGridControl
			//
			this.projectDetailsGridControl.DataSource = this.projectDetailsXpCollection;
			this.projectDetailsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.projectDetailsGridControl.Location = new System.Drawing.Point(0, 0);
			this.projectDetailsGridControl.MainView = this.projectDetailsGridView;
			this.projectDetailsGridControl.MenuManager = this.BarManager1;
			this.projectDetailsGridControl.Name = "projectDetailsGridControl";
			this.projectDetailsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {this.itemRepositoryItemLookUpEdit});
			this.projectDetailsGridControl.Size = new System.Drawing.Size(536, 234);
			this.projectDetailsGridControl.TabIndex = 0;
			this.projectDetailsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.projectDetailsGridView});
			//
			//projectDetailsXpCollection
			//
			this.projectDetailsXpCollection.ObjectType = typeof(DXDAL.SPGData.ProjectDetails);
			//
			//projectDetailsGridView
			//
			this.projectDetailsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colItemNumber, this.delGridColumn, this.colOid, this.colHasChanges, this.GridColumn1, this.GridColumn2, this.colCustomerPO, this.GridColumn3, this.colUnitsRequested, this.colBagsRequested, this.colPalletsRequested, this.colRemainingBalance, this.colUnitsProduced, this.colBagsProduced, this.colPalletsProduced, this.colPercentageComplete, this.colAllowOverrun, this.colEstimatiedShifts, this.GridColumn4});
			this.projectDetailsGridView.GridControl = this.projectDetailsGridControl;
			this.projectDetailsGridView.Name = "projectDetailsGridView";
			this.projectDetailsGridView.OptionsBehavior.Editable = false;
			this.projectDetailsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
			this.projectDetailsGridView.OptionsView.ShowDetailButtons = false;
			//
			//colItemNumber
			//
			this.colItemNumber.Caption = "Item #";
			this.colItemNumber.ColumnEdit = this.itemRepositoryItemLookUpEdit;
			this.colItemNumber.FieldName = "ProjectItem!Key";
			this.colItemNumber.Name = "colItemNumber";
			this.colItemNumber.Visible = true;
			this.colItemNumber.VisibleIndex = 2;
			//
			//itemRepositoryItemLookUpEdit
			//
			this.itemRepositoryItemLookUpEdit.AutoHeight = false;
			this.itemRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.itemRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 59, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CaseQuantity", "Case Quantity", 79, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BagsPerCase", "Bags Per Case", 79, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CasePerPallet", "Case Per Pallet", 82, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)
			});
			this.itemRepositoryItemLookUpEdit.DataSource = this.itemXpView;
			this.itemRepositoryItemLookUpEdit.DisplayMember = "ItemCode";
			this.itemRepositoryItemLookUpEdit.Name = "itemRepositoryItemLookUpEdit";
			this.itemRepositoryItemLookUpEdit.ValueMember = "ItemID";
			//
			//delGridColumn
			//
			this.delGridColumn.ColumnEdit = this.deleteRepositoryItemButtonEdit;
			this.delGridColumn.Name = "delGridColumn";
			this.delGridColumn.OptionsColumn.AllowSize = false;
			this.delGridColumn.Visible = true;
			this.delGridColumn.VisibleIndex = 0;
			this.delGridColumn.Width = 20;
			//
			//colOid
			//
			this.colOid.FieldName = "Oid";
			this.colOid.Name = "colOid";
			//
			//colHasChanges
			//
			this.colHasChanges.FieldName = "HasChanges";
			this.colHasChanges.Name = "colHasChanges";
			this.colHasChanges.OptionsColumn.ReadOnly = true;
			//
			//GridColumn1
			//
			this.GridColumn1.FieldName = "Project!";
			this.GridColumn1.Name = "GridColumn1";
			//
			//GridColumn2
			//
			this.GridColumn2.FieldName = "Project!Key";
			this.GridColumn2.Name = "GridColumn2";
			//
			//colCustomerPO
			//
			this.colCustomerPO.FieldName = "CustomerPO";
			this.colCustomerPO.Name = "colCustomerPO";
			this.colCustomerPO.Visible = true;
			this.colCustomerPO.VisibleIndex = 1;
			this.colCustomerPO.Width = 49;
			//
			//GridColumn3
			//
			this.GridColumn3.FieldName = "ProjectItem!";
			this.GridColumn3.Name = "GridColumn3";
			//
			//colUnitsRequested
			//
			this.colUnitsRequested.FieldName = "UnitsRequested";
			this.colUnitsRequested.Name = "colUnitsRequested";
			this.colUnitsRequested.Visible = true;
			this.colUnitsRequested.VisibleIndex = 3;
			this.colUnitsRequested.Width = 49;
			//
			//colBagsRequested
			//
			this.colBagsRequested.FieldName = "BagsRequested";
			this.colBagsRequested.Name = "colBagsRequested";
			this.colBagsRequested.Visible = true;
			this.colBagsRequested.VisibleIndex = 4;
			this.colBagsRequested.Width = 49;
			//
			//colPalletsRequested
			//
			this.colPalletsRequested.FieldName = "PalletsRequested";
			this.colPalletsRequested.Name = "colPalletsRequested";
			this.colPalletsRequested.Visible = true;
			this.colPalletsRequested.VisibleIndex = 5;
			this.colPalletsRequested.Width = 49;
			//
			//colRemainingBalance
			//
			this.colRemainingBalance.Caption = "Remaining Balance";
			this.colRemainingBalance.FieldName = "RemainingBalance";
			this.colRemainingBalance.Name = "colRemainingBalance";
			this.colRemainingBalance.Visible = true;
			this.colRemainingBalance.VisibleIndex = 11;
			//
			//colUnitsProduced
			//
			this.colUnitsProduced.FieldName = "UnitsProduced";
			this.colUnitsProduced.Name = "colUnitsProduced";
			this.colUnitsProduced.OptionsColumn.AllowEdit = false;
			this.colUnitsProduced.Visible = true;
			this.colUnitsProduced.VisibleIndex = 6;
			this.colUnitsProduced.Width = 49;
			//
			//colBagsProduced
			//
			this.colBagsProduced.FieldName = "BagsProduced";
			this.colBagsProduced.Name = "colBagsProduced";
			this.colBagsProduced.OptionsColumn.AllowEdit = false;
			this.colBagsProduced.Visible = true;
			this.colBagsProduced.VisibleIndex = 7;
			this.colBagsProduced.Width = 49;
			//
			//colPalletsProduced
			//
			this.colPalletsProduced.FieldName = "PalletsProduced";
			this.colPalletsProduced.Name = "colPalletsProduced";
			this.colPalletsProduced.OptionsColumn.AllowEdit = false;
			this.colPalletsProduced.Visible = true;
			this.colPalletsProduced.VisibleIndex = 8;
			this.colPalletsProduced.Width = 49;
			//
			//colPercentageComplete
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
			//colAllowOverrun
			//
			this.colAllowOverrun.FieldName = "AllowOverrun";
			this.colAllowOverrun.Name = "colAllowOverrun";
			this.colAllowOverrun.Visible = true;
			this.colAllowOverrun.VisibleIndex = 10;
			this.colAllowOverrun.Width = 63;
			//
			//colEstimatiedShifts
			//
			this.colEstimatiedShifts.DisplayFormat.FormatString = "f2";
			this.colEstimatiedShifts.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colEstimatiedShifts.FieldName = "EstimatedShifts";
			this.colEstimatiedShifts.Name = "colEstimatiedShifts";
			this.colEstimatiedShifts.OptionsColumn.AllowEdit = false;
			this.colEstimatiedShifts.Visible = true;
			this.colEstimatiedShifts.VisibleIndex = 12;
			//
			//GridColumn4
			//
			this.GridColumn4.FieldName = "ProjectItem!";
			this.GridColumn4.Name = "GridColumn4";
			this.GridColumn4.Visible = true;
			this.GridColumn4.VisibleIndex = 13;
			//
			//auditXtraTabPage
			//
			this.auditXtraTabPage.Controls.Add(this.detailHistorySimpleButton);
			this.auditXtraTabPage.Controls.Add(this.detailHistoryGridControl);
			this.auditXtraTabPage.Name = "auditXtraTabPage";
			this.auditXtraTabPage.Size = new System.Drawing.Size(536, 414);
			this.auditXtraTabPage.Text = "Project History";
			//
			//detailHistorySimpleButton
			//
			this.detailHistorySimpleButton.Location = new System.Drawing.Point(3, 3);
			this.detailHistorySimpleButton.Name = "detailHistorySimpleButton";
			this.detailHistorySimpleButton.Size = new System.Drawing.Size(147, 23);
			this.detailHistorySimpleButton.TabIndex = 3;
			this.detailHistorySimpleButton.Text = "Retrieve Detail History";
			//
			//detailHistoryGridControl
			//
			this.detailHistoryGridControl.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.detailHistoryGridControl.Location = new System.Drawing.Point(0, 32);
			this.detailHistoryGridControl.MainView = this.detailHistoryGridView;
			this.detailHistoryGridControl.MenuManager = this.BarManager1;
			this.detailHistoryGridControl.Name = "detailHistoryGridControl";
			this.detailHistoryGridControl.Size = new System.Drawing.Size(529, 382);
			this.detailHistoryGridControl.TabIndex = 2;
			this.detailHistoryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.detailHistoryGridView});
			this.detailHistoryGridControl.Visible = false;
			//
			//detailHistoryGridView
			//
			this.detailHistoryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.RecordIDGridColumn, this.DateChangedGridColumn, this.PropertyNameGridColumn, this.PrevValueGridColumn, this.NewValueGridColumn});
			this.detailHistoryGridView.GridControl = this.detailHistoryGridControl;
			this.detailHistoryGridView.Name = "detailHistoryGridView";
			//
			//RecordIDGridColumn
			//
			this.RecordIDGridColumn.FieldName = "RecordID";
			this.RecordIDGridColumn.Name = "RecordIDGridColumn";
			this.RecordIDGridColumn.Visible = true;
			this.RecordIDGridColumn.VisibleIndex = 0;
			//
			//DateChangedGridColumn
			//
			this.DateChangedGridColumn.DisplayFormat.FormatString = "d";
			this.DateChangedGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.DateChangedGridColumn.FieldName = "DateChanged";
			this.DateChangedGridColumn.Name = "DateChangedGridColumn";
			this.DateChangedGridColumn.Visible = true;
			this.DateChangedGridColumn.VisibleIndex = 1;
			//
			//PropertyNameGridColumn
			//
			this.PropertyNameGridColumn.Caption = "Field Name";
			this.PropertyNameGridColumn.FieldName = "PropertyName";
			this.PropertyNameGridColumn.Name = "PropertyNameGridColumn";
			this.PropertyNameGridColumn.Visible = true;
			this.PropertyNameGridColumn.VisibleIndex = 2;
			//
			//PrevValueGridColumn
			//
			this.PrevValueGridColumn.FieldName = "PrevValue";
			this.PrevValueGridColumn.Name = "PrevValueGridColumn";
			this.PrevValueGridColumn.Visible = true;
			this.PrevValueGridColumn.VisibleIndex = 3;
			//
			//NewValueGridColumn
			//
			this.NewValueGridColumn.FieldName = "NewValue";
			this.NewValueGridColumn.Name = "NewValueGridColumn";
			this.NewValueGridColumn.Visible = true;
			this.NewValueGridColumn.VisibleIndex = 4;
			//
			//ProjectsXtraForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(797, 514);
			this.Controls.Add(this.SplitContainerControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "ProjectsXtraForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Projects";
			((System.ComponentModel.ISupportInitialize)this.deleteRepositoryItemButtonEdit).EndInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemLookUpEdit1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.BarManager1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.SplitContainerControl1).EndInit();
			this.SplitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.projectSearchGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.projectSearchXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.projectSearchGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.projectsXtraTabControl).EndInit();
			this.projectsXtraTabControl.ResumeLayout(false);
			this.dataEntryXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dataEntrySplitContainerControl).EndInit();
			this.dataEntrySplitContainerControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.notesMemoExEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.projectStatusComboBoxEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.reqDeliveryDateEdit.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.reqDeliveryDateEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.reqShipDateEdit.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.reqShipDateEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.reqStartDateEdit.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.reqStartDateEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customerLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customerXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.projectTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.oidTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.projectDetailsGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.projectDetailsXpCollection).EndInit();
			((System.ComponentModel.ISupportInitialize)this.projectDetailsGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemRepositoryItemLookUpEdit).EndInit();
			this.auditXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.detailHistoryGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.detailHistoryGridView).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			addBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(addBarButtonItem_ItemClick);
			cancelBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(cancelBarButtonItem_ItemClick);
			customerLookUpEdit.Validated += new System.EventHandler(customerLookUpEdit_Validated);
			deleteBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(deleteBarButtonItem_ItemClick);
			deleteRepositoryItemButtonEdit.Click += new System.EventHandler(deleteRepositoryItemButtonEdit_Click);
			detailHistorySimpleButton.Click += new System.EventHandler(detailHistorySimpleButton_Click);
			editBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(editBarButtonItem_ItemClick);
			RepositoryItemLookUpEdit1.QueryPopUp += new System.ComponentModel.CancelEventHandler(itemRepositoryItemLookUpEdit_QueryPopUp);
			projectDetailsGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(projectDetailsGridView_CellValueChanged);
			projectDetailsGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(projectDetailsGridView_InitNewRow);
			projectSearchGridView.Click += new System.EventHandler(projectSearchGridView_Click);
			projectStatusComboBoxEdit.FormatEditValue += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(projectStatusComboBoxEdit_FormatEditValue);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(ProjectsXtraForm_FormClosing);
			this.Load += new System.EventHandler(ProjectsXtraForm_Load);
			saveBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(saveBarButtonItem_ItemClick);
			printProductionReportBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(printProductionReportBarButtonItem_ItemClick);
			printBomAvailabilityBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(printBomAvailabilityBarButtonItem_ItemClick);
			refreshBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(refreshBarButtonItem_ItemClick);
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
	}

}