using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.Data.Filtering;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using DXDAL.SPGData;

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
	public partial class ReceivingXtraForm : DevExpress.XtraEditors.XtraForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceivingXtraForm));
            this.receivingsXtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.generalXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.SaveContinueSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.locationLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.BarManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.receivingBar = new DevExpress.XtraBars.Bar();
            this.addBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.editBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.cancelBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.saveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.receivingListBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.LpnLabelsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.Bar2 = new DevExpress.XtraBars.Bar();
            this.Bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.locationXpView = new DevExpress.Xpo.XPView(this.components);
            this.LabelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.correctPalletsComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.insectActivityComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.foreignSubstanceComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.wheelsChockedComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LabelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.loadConditionLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.shipmentConditionXpView = new DevExpress.Xpo.XPView(this.components);
            this.physicalConditionLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.LabelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.temperatureSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.LabelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.finishTimeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.LabelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.startTimeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.checkedByLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.employeeXpView = new DevExpress.Xpo.XPView(this.components);
            this.LabelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.unloadedByLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.vendorLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.vendorLookupXPCollection = new DevExpress.Xpo.XPCollection(this.components);
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.notesMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.customerLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.customersXPView = new DevExpress.Xpo.XPView(this.components);
            this.shiftLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.carrierLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.receiveDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.sealTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.trailerTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bolTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.poTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.detailsXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.BulkEntryGroupControl = new DevExpress.XtraEditors.GroupControl();
            this.label9 = new System.Windows.Forms.Label();
            this.uomTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.duplicateButton = new DevExpress.XtraEditors.SimpleButton();
            this.LabelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.UnitQtyLockCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.AddToPalletButton = new DevExpress.XtraEditors.SimpleButton();
            this.AddEntryButton = new DevExpress.XtraEditors.SimpleButton();
            this.QtyPerPltTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.UnitsPerPltTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.QtyTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.UnitsTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.LotTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ItemDescTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ExpirationDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.ItemLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.receivingItemXPView = new DevExpress.Xpo.XPView(this.components);
            this.receivingGridControl = new DevExpress.XtraGrid.GridControl();
            this.receivingGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.receivingIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itemRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.descriptionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lotGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.expirationDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.quantityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.packagesGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ReceivDetLPNColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.delGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.delRepositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.AddedLotGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AddedLotCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.AddLotRepositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.returnsXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.returnsGridControl = new DevExpress.XtraGrid.GridControl();
            this.returnsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.returnIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ReceiveMainIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.returnItemGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.returnItemRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.returnItemXPView = new DevExpress.Xpo.XPView(this.components);
            this.returnItemDescGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.returnLotGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.returnExpirationDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RepositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.returnQuantityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.returnUnitsGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.returnPalletsGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.returnReasonGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.returnReasonRepositoryItemMemoExEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.deleteGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.deleteReturnRepositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.SplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.receivingSearchGridControl = new DevExpress.XtraGrid.GridControl();
            this.receivingSearchXPView = new DevExpress.Xpo.XPView(this.components);
            this.receivingSearchGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BOLGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customerGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.receivingDateRepositoryItemDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.receivingIDSearchGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customerFilterRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.BarButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FinishedProductAvailabilityReportTableAdapter1 = new SuperiorPackGroup.SPGReportsTableAdapters.FinishedProductAvailabilityReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.receivingsXtraTabControl)).BeginInit();
            this.receivingsXtraTabControl.SuspendLayout();
            this.generalXtraTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationXpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctPalletsComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insectActivityComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foreignSubstanceComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheelsChockedComboBoxEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadConditionLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentConditionXpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.physicalConditionLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishTimeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startTimeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedByLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeXpView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unloadedByLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorLookupXPCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersXPView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrierLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiveDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiveDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sealTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trailerTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poTextEdit.Properties)).BeginInit();
            this.detailsXtraTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BulkEntryGroupControl)).BeginInit();
            this.BulkEntryGroupControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uomTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitQtyLockCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtyPerPltTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsPerPltTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtyTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LotTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDescTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpirationDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpirationDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivingItemXPView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivingGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivingGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delRepositoryItemButtonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddedLotCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddLotRepositoryItemButtonEdit)).BeginInit();
            this.returnsXtraTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.returnsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnItemRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnItemXPView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnReasonRepositoryItemMemoExEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteReturnRepositoryItemButtonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).BeginInit();
            this.SplitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receivingSearchGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivingSearchXPView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivingSearchGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivingDateRepositoryItemDateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivingDateRepositoryItemDateEdit.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerFilterRepositoryItemLookUpEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // receivingsXtraTabControl
            // 
            this.receivingsXtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receivingsXtraTabControl.Location = new System.Drawing.Point(0, 0);
            this.receivingsXtraTabControl.Name = "receivingsXtraTabControl";
            this.receivingsXtraTabControl.SelectedTabPage = this.generalXtraTabPage;
            this.receivingsXtraTabControl.Size = new System.Drawing.Size(1133, 488);
            this.receivingsXtraTabControl.TabIndex = 4;
            this.receivingsXtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.generalXtraTabPage,
            this.detailsXtraTabPage,
            this.returnsXtraTabPage});
            // 
            // generalXtraTabPage
            // 
            this.generalXtraTabPage.Controls.Add(this.SaveContinueSimpleButton);
            this.generalXtraTabPage.Controls.Add(this.locationLookUpEdit);
            this.generalXtraTabPage.Controls.Add(this.LabelControl24);
            this.generalXtraTabPage.Controls.Add(this.correctPalletsComboBoxEdit);
            this.generalXtraTabPage.Controls.Add(this.LabelControl16);
            this.generalXtraTabPage.Controls.Add(this.insectActivityComboBoxEdit);
            this.generalXtraTabPage.Controls.Add(this.LabelControl15);
            this.generalXtraTabPage.Controls.Add(this.foreignSubstanceComboBoxEdit);
            this.generalXtraTabPage.Controls.Add(this.LabelControl14);
            this.generalXtraTabPage.Controls.Add(this.wheelsChockedComboBoxEdit);
            this.generalXtraTabPage.Controls.Add(this.LabelControl13);
            this.generalXtraTabPage.Controls.Add(this.loadConditionLookUpEdit);
            this.generalXtraTabPage.Controls.Add(this.physicalConditionLookUpEdit);
            this.generalXtraTabPage.Controls.Add(this.LabelControl23);
            this.generalXtraTabPage.Controls.Add(this.LabelControl22);
            this.generalXtraTabPage.Controls.Add(this.LabelControl21);
            this.generalXtraTabPage.Controls.Add(this.temperatureSpinEdit);
            this.generalXtraTabPage.Controls.Add(this.LabelControl20);
            this.generalXtraTabPage.Controls.Add(this.finishTimeEdit);
            this.generalXtraTabPage.Controls.Add(this.LabelControl19);
            this.generalXtraTabPage.Controls.Add(this.startTimeEdit);
            this.generalXtraTabPage.Controls.Add(this.checkedByLookUpEdit);
            this.generalXtraTabPage.Controls.Add(this.LabelControl18);
            this.generalXtraTabPage.Controls.Add(this.LabelControl17);
            this.generalXtraTabPage.Controls.Add(this.unloadedByLookUpEdit);
            this.generalXtraTabPage.Controls.Add(this.vendorLookUpEdit);
            this.generalXtraTabPage.Controls.Add(this.LabelControl1);
            this.generalXtraTabPage.Controls.Add(this.notesMemoEdit);
            this.generalXtraTabPage.Controls.Add(this.customerLookUpEdit);
            this.generalXtraTabPage.Controls.Add(this.shiftLookUpEdit);
            this.generalXtraTabPage.Controls.Add(this.carrierLookUpEdit);
            this.generalXtraTabPage.Controls.Add(this.receiveDateEdit);
            this.generalXtraTabPage.Controls.Add(this.sealTextEdit);
            this.generalXtraTabPage.Controls.Add(this.trailerTextEdit);
            this.generalXtraTabPage.Controls.Add(this.bolTextEdit);
            this.generalXtraTabPage.Controls.Add(this.poTextEdit);
            this.generalXtraTabPage.Controls.Add(this.LabelControl12);
            this.generalXtraTabPage.Controls.Add(this.LabelControl11);
            this.generalXtraTabPage.Controls.Add(this.LabelControl10);
            this.generalXtraTabPage.Controls.Add(this.LabelControl9);
            this.generalXtraTabPage.Controls.Add(this.LabelControl7);
            this.generalXtraTabPage.Controls.Add(this.LabelControl5);
            this.generalXtraTabPage.Controls.Add(this.LabelControl4);
            this.generalXtraTabPage.Controls.Add(this.LabelControl3);
            this.generalXtraTabPage.Controls.Add(this.LabelControl2);
            this.generalXtraTabPage.Name = "generalXtraTabPage";
            this.generalXtraTabPage.Size = new System.Drawing.Size(1127, 460);
            this.generalXtraTabPage.Text = "General Info";
            // 
            // SaveContinueSimpleButton
            // 
            this.SaveContinueSimpleButton.Location = new System.Drawing.Point(357, 397);
            this.SaveContinueSimpleButton.Name = "SaveContinueSimpleButton";
            this.SaveContinueSimpleButton.Size = new System.Drawing.Size(128, 23);
            this.SaveContinueSimpleButton.TabIndex = 52;
            this.SaveContinueSimpleButton.Text = "Save && Continue";
            this.SaveContinueSimpleButton.Click += new System.EventHandler(this.SaveContinueSimpleButton_Click);
            // 
            // locationLookUpEdit
            // 
            this.locationLookUpEdit.Location = new System.Drawing.Point(357, 14);
            this.locationLookUpEdit.MenuManager = this.BarManager1;
            this.locationLookUpEdit.Name = "locationLookUpEdit";
            this.locationLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.locationLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationID", "Location ID", 77, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationCode", "Location Code", 78, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationName", "Location Name", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.locationLookUpEdit.Properties.DataSource = this.locationXpView;
            this.locationLookUpEdit.Properties.DisplayMember = "LocationCode";
            this.locationLookUpEdit.Properties.NullText = "[Select A Location]";
            this.locationLookUpEdit.Properties.ValueMember = "LocationID";
            this.locationLookUpEdit.Size = new System.Drawing.Size(129, 20);
            this.locationLookUpEdit.TabIndex = 51;
            // 
            // BarManager1
            // 
            this.BarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.receivingBar,
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
            this.receivingListBarButtonItem,
            this.refreshBarButtonItem,
            this.LpnLabelsBarButtonItem});
            this.BarManager1.MainMenu = this.Bar2;
            this.BarManager1.MaxItemId = 7;
            this.BarManager1.StatusBar = this.Bar3;
            // 
            // receivingBar
            // 
            this.receivingBar.BarName = "Tools";
            this.receivingBar.DockCol = 0;
            this.receivingBar.DockRow = 1;
            this.receivingBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.receivingBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.addBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.editBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.cancelBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.saveBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.receivingListBarButtonItem, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.LpnLabelsBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.refreshBarButtonItem, true)});
            this.receivingBar.OptionsBar.UseWholeRow = true;
            this.receivingBar.Text = "Tools";
            // 
            // addBarButtonItem
            // 
            this.addBarButtonItem.Caption = "&Add Receiving";
            this.addBarButtonItem.Id = 0;
            this.addBarButtonItem.Name = "addBarButtonItem";
            this.addBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBarButtonItem_ItemClick);
            // 
            // editBarButtonItem
            // 
            this.editBarButtonItem.Caption = "&Edit Receiving";
            this.editBarButtonItem.Id = 1;
            this.editBarButtonItem.Name = "editBarButtonItem";
            this.editBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editBarButtonItem_ItemClick);
            // 
            // cancelBarButtonItem
            // 
            this.cancelBarButtonItem.Caption = "&Cancel Changes";
            this.cancelBarButtonItem.Id = 2;
            this.cancelBarButtonItem.Name = "cancelBarButtonItem";
            this.cancelBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.cancelBarButtonItem_ItemClick);
            // 
            // saveBarButtonItem
            // 
            this.saveBarButtonItem.Caption = "&Save Changes";
            this.saveBarButtonItem.Id = 3;
            this.saveBarButtonItem.Name = "saveBarButtonItem";
            this.saveBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveBarButtonItem_ItemClick);
            // 
            // receivingListBarButtonItem
            // 
            this.receivingListBarButtonItem.Caption = "Print &Receiving List";
            this.receivingListBarButtonItem.Id = 4;
            this.receivingListBarButtonItem.Name = "receivingListBarButtonItem";
            this.receivingListBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.receivingListBarButtonItem_ItemClick);
            // 
            // LpnLabelsBarButtonItem
            // 
            this.LpnLabelsBarButtonItem.Caption = "Print LPN";
            this.LpnLabelsBarButtonItem.Id = 6;
            this.LpnLabelsBarButtonItem.Name = "LpnLabelsBarButtonItem";
            this.LpnLabelsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.LpnLabelsBarButtonItem_ItemClick);
            // 
            // refreshBarButtonItem
            // 
            this.refreshBarButtonItem.Caption = "Re&fresh";
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
            this.Bar2.Visible = false;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1388, 49);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 537);
            this.barDockControlBottom.Manager = this.BarManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1388, 23);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 49);
            this.barDockControlLeft.Manager = this.BarManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 488);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1388, 49);
            this.barDockControlRight.Manager = this.BarManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 488);
            // 
            // locationXpView
            // 
            this.locationXpView.CriteriaString = "[CanReceive] = True";
            this.locationXpView.ObjectType = typeof(DXDAL.SPGData.Locations);
            this.locationXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("LocationID", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true),
            new DevExpress.Xpo.ViewProperty("LocationCode", DevExpress.Xpo.SortDirection.None, "[LocationCode]", false, true),
            new DevExpress.Xpo.ViewProperty("LocationName", DevExpress.Xpo.SortDirection.None, "[LocationName]", false, true)});
            // 
            // LabelControl24
            // 
            this.LabelControl24.Location = new System.Drawing.Point(274, 17);
            this.LabelControl24.Name = "LabelControl24";
            this.LabelControl24.Size = new System.Drawing.Size(44, 13);
            this.LabelControl24.TabIndex = 50;
            this.LabelControl24.Text = "Location:";
            // 
            // correctPalletsComboBoxEdit
            // 
            this.correctPalletsComboBoxEdit.Location = new System.Drawing.Point(440, 353);
            this.correctPalletsComboBoxEdit.MenuManager = this.BarManager1;
            this.correctPalletsComboBoxEdit.Name = "correctPalletsComboBoxEdit";
            this.correctPalletsComboBoxEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.correctPalletsComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.correctPalletsComboBoxEdit.Properties.DropDownRows = 3;
            this.correctPalletsComboBoxEdit.Properties.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.correctPalletsComboBoxEdit.Size = new System.Drawing.Size(46, 20);
            this.correctPalletsComboBoxEdit.TabIndex = 49;
            // 
            // LabelControl16
            // 
            this.LabelControl16.Location = new System.Drawing.Point(360, 355);
            this.LabelControl16.Name = "LabelControl16";
            this.LabelControl16.Size = new System.Drawing.Size(74, 13);
            this.LabelControl16.TabIndex = 48;
            this.LabelControl16.Text = "Correct Pallets:";
            // 
            // insectActivityComboBoxEdit
            // 
            this.insectActivityComboBoxEdit.Location = new System.Drawing.Point(306, 352);
            this.insectActivityComboBoxEdit.MenuManager = this.BarManager1;
            this.insectActivityComboBoxEdit.Name = "insectActivityComboBoxEdit";
            this.insectActivityComboBoxEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.insectActivityComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.insectActivityComboBoxEdit.Properties.DropDownRows = 3;
            this.insectActivityComboBoxEdit.Properties.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.insectActivityComboBoxEdit.Size = new System.Drawing.Size(48, 20);
            this.insectActivityComboBoxEdit.TabIndex = 47;
            // 
            // LabelControl15
            // 
            this.LabelControl15.Location = new System.Drawing.Point(188, 355);
            this.LabelControl15.Name = "LabelControl15";
            this.LabelControl15.Size = new System.Drawing.Size(112, 13);
            this.LabelControl15.TabIndex = 46;
            this.LabelControl15.Text = "Insect/Rodent Activity:";
            // 
            // foreignSubstanceComboBoxEdit
            // 
            this.foreignSubstanceComboBoxEdit.Location = new System.Drawing.Point(134, 352);
            this.foreignSubstanceComboBoxEdit.MenuManager = this.BarManager1;
            this.foreignSubstanceComboBoxEdit.Name = "foreignSubstanceComboBoxEdit";
            this.foreignSubstanceComboBoxEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.foreignSubstanceComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.foreignSubstanceComboBoxEdit.Properties.DropDownRows = 3;
            this.foreignSubstanceComboBoxEdit.Properties.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.foreignSubstanceComboBoxEdit.Size = new System.Drawing.Size(48, 20);
            this.foreignSubstanceComboBoxEdit.TabIndex = 45;
            // 
            // LabelControl14
            // 
            this.LabelControl14.Location = new System.Drawing.Point(35, 378);
            this.LabelControl14.Name = "LabelControl14";
            this.LabelControl14.Size = new System.Drawing.Size(93, 13);
            this.LabelControl14.TabIndex = 44;
            this.LabelControl14.Text = "Foreign Substance:";
            // 
            // wheelsChockedComboBoxEdit
            // 
            this.wheelsChockedComboBoxEdit.Location = new System.Drawing.Point(357, 327);
            this.wheelsChockedComboBoxEdit.MenuManager = this.BarManager1;
            this.wheelsChockedComboBoxEdit.Name = "wheelsChockedComboBoxEdit";
            this.wheelsChockedComboBoxEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.wheelsChockedComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.wheelsChockedComboBoxEdit.Properties.DropDownRows = 3;
            this.wheelsChockedComboBoxEdit.Properties.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.wheelsChockedComboBoxEdit.Size = new System.Drawing.Size(129, 20);
            this.wheelsChockedComboBoxEdit.TabIndex = 43;
            // 
            // LabelControl13
            // 
            this.LabelControl13.Location = new System.Drawing.Point(268, 330);
            this.LabelControl13.Name = "LabelControl13";
            this.LabelControl13.Size = new System.Drawing.Size(83, 13);
            this.LabelControl13.TabIndex = 42;
            this.LabelControl13.Text = "Wheels Chocked:";
            // 
            // loadConditionLookUpEdit
            // 
            this.loadConditionLookUpEdit.Location = new System.Drawing.Point(357, 275);
            this.loadConditionLookUpEdit.MenuManager = this.BarManager1;
            this.loadConditionLookUpEdit.Name = "loadConditionLookUpEdit";
            this.loadConditionLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.loadConditionLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.loadConditionLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("recordID", "record ID", 68, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Condition", "Condition", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.loadConditionLookUpEdit.Properties.DataSource = this.shipmentConditionXpView;
            this.loadConditionLookUpEdit.Properties.DisplayMember = "Condition";
            this.loadConditionLookUpEdit.Properties.NullText = "[Select Condition]";
            this.loadConditionLookUpEdit.Properties.ValueMember = "recordID";
            this.loadConditionLookUpEdit.Size = new System.Drawing.Size(129, 20);
            this.loadConditionLookUpEdit.TabIndex = 31;
            // 
            // shipmentConditionXpView
            // 
            this.shipmentConditionXpView.ObjectType = typeof(DXDAL.SPGData.ShipmentConditions);
            this.shipmentConditionXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("recordID", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true),
            new DevExpress.Xpo.ViewProperty("Condition", DevExpress.Xpo.SortDirection.None, "[ShipmentCondition]", false, true)});
            // 
            // physicalConditionLookUpEdit
            // 
            this.physicalConditionLookUpEdit.Location = new System.Drawing.Point(134, 275);
            this.physicalConditionLookUpEdit.MenuManager = this.BarManager1;
            this.physicalConditionLookUpEdit.Name = "physicalConditionLookUpEdit";
            this.physicalConditionLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.physicalConditionLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.physicalConditionLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("recordID", "record ID", 68, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Condition", "Condition", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.physicalConditionLookUpEdit.Properties.DataSource = this.shipmentConditionXpView;
            this.physicalConditionLookUpEdit.Properties.DisplayMember = "Condition";
            this.physicalConditionLookUpEdit.Properties.NullText = "[Select Condition]";
            this.physicalConditionLookUpEdit.Properties.ValueMember = "recordID";
            this.physicalConditionLookUpEdit.Size = new System.Drawing.Size(126, 20);
            this.physicalConditionLookUpEdit.TabIndex = 29;
            // 
            // LabelControl23
            // 
            this.LabelControl23.Location = new System.Drawing.Point(268, 278);
            this.LabelControl23.Name = "LabelControl23";
            this.LabelControl23.Size = new System.Drawing.Size(75, 13);
            this.LabelControl23.TabIndex = 30;
            this.LabelControl23.Text = "Load Condition:";
            // 
            // LabelControl22
            // 
            this.LabelControl22.Location = new System.Drawing.Point(35, 278);
            this.LabelControl22.Name = "LabelControl22";
            this.LabelControl22.Size = new System.Drawing.Size(90, 13);
            this.LabelControl22.TabIndex = 28;
            this.LabelControl22.Text = "Physical Condition:";
            // 
            // LabelControl21
            // 
            this.LabelControl21.Location = new System.Drawing.Point(35, 330);
            this.LabelControl21.Name = "LabelControl21";
            this.LabelControl21.Size = new System.Drawing.Size(66, 13);
            this.LabelControl21.TabIndex = 36;
            this.LabelControl21.Text = "Temperature:";
            // 
            // temperatureSpinEdit
            // 
            this.temperatureSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.temperatureSpinEdit.Location = new System.Drawing.Point(134, 327);
            this.temperatureSpinEdit.MenuManager = this.BarManager1;
            this.temperatureSpinEdit.Name = "temperatureSpinEdit";
            this.temperatureSpinEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.temperatureSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.temperatureSpinEdit.Properties.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.temperatureSpinEdit.Properties.NullText = "[Enter Temperature]";
            this.temperatureSpinEdit.Size = new System.Drawing.Size(126, 20);
            this.temperatureSpinEdit.TabIndex = 37;
            this.temperatureSpinEdit.Validating += new System.ComponentModel.CancelEventHandler(this.temperatureSpinEdit_Validating);
            // 
            // LabelControl20
            // 
            this.LabelControl20.Location = new System.Drawing.Point(268, 303);
            this.LabelControl20.Name = "LabelControl20";
            this.LabelControl20.Size = new System.Drawing.Size(56, 13);
            this.LabelControl20.TabIndex = 34;
            this.LabelControl20.Text = "Finish Time:";
            // 
            // finishTimeEdit
            // 
            this.finishTimeEdit.EditValue = null;
            this.finishTimeEdit.Location = new System.Drawing.Point(357, 300);
            this.finishTimeEdit.MenuManager = this.BarManager1;
            this.finishTimeEdit.Name = "finishTimeEdit";
            this.finishTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.finishTimeEdit.Properties.NullText = "[Enter Finish Time]";
            this.finishTimeEdit.Size = new System.Drawing.Size(129, 20);
            this.finishTimeEdit.TabIndex = 35;
            // 
            // LabelControl19
            // 
            this.LabelControl19.Location = new System.Drawing.Point(35, 304);
            this.LabelControl19.Name = "LabelControl19";
            this.LabelControl19.Size = new System.Drawing.Size(53, 13);
            this.LabelControl19.TabIndex = 32;
            this.LabelControl19.Text = "Start Time:";
            // 
            // startTimeEdit
            // 
            this.startTimeEdit.EditValue = null;
            this.startTimeEdit.Location = new System.Drawing.Point(134, 301);
            this.startTimeEdit.MenuManager = this.BarManager1;
            this.startTimeEdit.Name = "startTimeEdit";
            this.startTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startTimeEdit.Properties.NullText = "[Enter Start Time]";
            this.startTimeEdit.Size = new System.Drawing.Size(126, 20);
            this.startTimeEdit.TabIndex = 33;
            // 
            // checkedByLookUpEdit
            // 
            this.checkedByLookUpEdit.Location = new System.Drawing.Point(357, 249);
            this.checkedByLookUpEdit.MenuManager = this.BarManager1;
            this.checkedByLookUpEdit.Name = "checkedByLookUpEdit";
            this.checkedByLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.checkedByLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedByLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("recordID", "record ID", 68, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Employee Name", "Employee Name", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.checkedByLookUpEdit.Properties.DataSource = this.employeeXpView;
            this.checkedByLookUpEdit.Properties.DisplayMember = "Employee Name";
            this.checkedByLookUpEdit.Properties.NullText = "[Select Employee Name]";
            this.checkedByLookUpEdit.Properties.ValueMember = "recordID";
            this.checkedByLookUpEdit.Size = new System.Drawing.Size(129, 20);
            this.checkedByLookUpEdit.TabIndex = 27;
            // 
            // employeeXpView
            // 
            this.employeeXpView.ObjectType = typeof(DXDAL.SPGData.Employees);
            this.employeeXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("recordID", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true),
            new DevExpress.Xpo.ViewProperty("Employee Name", DevExpress.Xpo.SortDirection.Ascending, "[LastName] + \', \' + [FirstName]", false, true)});
            // 
            // LabelControl18
            // 
            this.LabelControl18.Location = new System.Drawing.Point(268, 252);
            this.LabelControl18.Name = "LabelControl18";
            this.LabelControl18.Size = new System.Drawing.Size(60, 13);
            this.LabelControl18.TabIndex = 26;
            this.LabelControl18.Text = "Checked By:";
            // 
            // LabelControl17
            // 
            this.LabelControl17.Location = new System.Drawing.Point(35, 252);
            this.LabelControl17.Name = "LabelControl17";
            this.LabelControl17.Size = new System.Drawing.Size(64, 13);
            this.LabelControl17.TabIndex = 25;
            this.LabelControl17.Text = "Unloaded By:";
            // 
            // unloadedByLookUpEdit
            // 
            this.unloadedByLookUpEdit.Location = new System.Drawing.Point(134, 249);
            this.unloadedByLookUpEdit.MenuManager = this.BarManager1;
            this.unloadedByLookUpEdit.Name = "unloadedByLookUpEdit";
            this.unloadedByLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.unloadedByLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.unloadedByLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("recordID", "record ID", 68, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Employee Name", "Employee Name", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.unloadedByLookUpEdit.Properties.DataSource = this.employeeXpView;
            this.unloadedByLookUpEdit.Properties.DisplayMember = "Employee Name";
            this.unloadedByLookUpEdit.Properties.NullText = "[Select Employee Name]";
            this.unloadedByLookUpEdit.Properties.ValueMember = "recordID";
            this.unloadedByLookUpEdit.Size = new System.Drawing.Size(126, 20);
            this.unloadedByLookUpEdit.TabIndex = 24;
            // 
            // vendorLookUpEdit
            // 
            this.vendorLookUpEdit.Location = new System.Drawing.Point(357, 92);
            this.vendorLookUpEdit.MenuManager = this.BarManager1;
            this.vendorLookUpEdit.Name = "vendorLookUpEdit";
            this.vendorLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.vendorLookUpEdit.Properties.DataSource = this.vendorLookupXPCollection;
            this.vendorLookUpEdit.Properties.DisplayMember = "VendorName";
            this.vendorLookUpEdit.Properties.NullText = "";
            this.vendorLookUpEdit.Properties.NullValuePrompt = "[Select A Vendor]";
            this.vendorLookUpEdit.Properties.ValueMember = "Oid";
            this.vendorLookUpEdit.Size = new System.Drawing.Size(129, 20);
            this.vendorLookUpEdit.TabIndex = 13;
            // 
            // vendorLookupXPCollection
            // 
            this.vendorLookupXPCollection.ObjectType = typeof(DXDAL.SPGData.Vendor);
            // 
            // LabelControl1
            // 
            this.LabelControl1.Location = new System.Drawing.Point(35, 150);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(32, 13);
            this.LabelControl1.TabIndex = 22;
            this.LabelControl1.Text = "Notes:";
            // 
            // notesMemoEdit
            // 
            this.notesMemoEdit.Location = new System.Drawing.Point(134, 147);
            this.notesMemoEdit.Name = "notesMemoEdit";
            this.notesMemoEdit.Size = new System.Drawing.Size(352, 96);
            this.notesMemoEdit.TabIndex = 23;
            // 
            // customerLookUpEdit
            // 
            this.customerLookUpEdit.Location = new System.Drawing.Point(134, 14);
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
            this.customerLookUpEdit.Properties.ValueMember = "CustomerID";
            this.customerLookUpEdit.Size = new System.Drawing.Size(126, 20);
            this.customerLookUpEdit.TabIndex = 1;
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
            // shiftLookUpEdit
            // 
            this.shiftLookUpEdit.Location = new System.Drawing.Point(357, 40);
            this.shiftLookUpEdit.Name = "shiftLookUpEdit";
            this.shiftLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.shiftLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.shiftLookUpEdit.Properties.NullText = "[Select A Shift]";
            this.shiftLookUpEdit.Size = new System.Drawing.Size(129, 20);
            this.shiftLookUpEdit.TabIndex = 5;
            // 
            // carrierLookUpEdit
            // 
            this.carrierLookUpEdit.Location = new System.Drawing.Point(134, 92);
            this.carrierLookUpEdit.Name = "carrierLookUpEdit";
            this.carrierLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.carrierLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.carrierLookUpEdit.Properties.NullText = "[Select A Carrier]";
            this.carrierLookUpEdit.Size = new System.Drawing.Size(126, 20);
            this.carrierLookUpEdit.TabIndex = 11;
            // 
            // receiveDateEdit
            // 
            this.receiveDateEdit.EditValue = null;
            this.receiveDateEdit.Location = new System.Drawing.Point(134, 40);
            this.receiveDateEdit.Name = "receiveDateEdit";
            this.receiveDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.receiveDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.receiveDateEdit.Properties.Mask.EditMask = "D";
            this.receiveDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.receiveDateEdit.Properties.NullText = "[Select A Date]";
            this.receiveDateEdit.Size = new System.Drawing.Size(126, 20);
            this.receiveDateEdit.TabIndex = 3;
            // 
            // sealTextEdit
            // 
            this.sealTextEdit.Location = new System.Drawing.Point(357, 118);
            this.sealTextEdit.Name = "sealTextEdit";
            this.sealTextEdit.Size = new System.Drawing.Size(129, 20);
            this.sealTextEdit.TabIndex = 17;
            // 
            // trailerTextEdit
            // 
            this.trailerTextEdit.Location = new System.Drawing.Point(134, 118);
            this.trailerTextEdit.Name = "trailerTextEdit";
            this.trailerTextEdit.Size = new System.Drawing.Size(126, 20);
            this.trailerTextEdit.TabIndex = 15;
            // 
            // bolTextEdit
            // 
            this.bolTextEdit.Location = new System.Drawing.Point(134, 66);
            this.bolTextEdit.Name = "bolTextEdit";
            this.bolTextEdit.Size = new System.Drawing.Size(126, 20);
            this.bolTextEdit.TabIndex = 7;
            // 
            // poTextEdit
            // 
            this.poTextEdit.Location = new System.Drawing.Point(357, 66);
            this.poTextEdit.Name = "poTextEdit";
            this.poTextEdit.Size = new System.Drawing.Size(129, 20);
            this.poTextEdit.TabIndex = 9;
            // 
            // LabelControl12
            // 
            this.LabelControl12.Location = new System.Drawing.Point(35, 69);
            this.LabelControl12.Name = "LabelControl12";
            this.LabelControl12.Size = new System.Drawing.Size(63, 13);
            this.LabelControl12.TabIndex = 6;
            this.LabelControl12.Text = "BOL Number:";
            // 
            // LabelControl11
            // 
            this.LabelControl11.Location = new System.Drawing.Point(35, 95);
            this.LabelControl11.Name = "LabelControl11";
            this.LabelControl11.Size = new System.Drawing.Size(37, 13);
            this.LabelControl11.TabIndex = 10;
            this.LabelControl11.Text = "Carrier:";
            // 
            // LabelControl10
            // 
            this.LabelControl10.Location = new System.Drawing.Point(274, 95);
            this.LabelControl10.Name = "LabelControl10";
            this.LabelControl10.Size = new System.Drawing.Size(38, 13);
            this.LabelControl10.TabIndex = 12;
            this.LabelControl10.Text = "Vendor:";
            // 
            // LabelControl9
            // 
            this.LabelControl9.Location = new System.Drawing.Point(35, 121);
            this.LabelControl9.Name = "LabelControl9";
            this.LabelControl9.Size = new System.Drawing.Size(74, 13);
            this.LabelControl9.TabIndex = 14;
            this.LabelControl9.Text = "Trailer Number:";
            // 
            // LabelControl7
            // 
            this.LabelControl7.Location = new System.Drawing.Point(274, 121);
            this.LabelControl7.Name = "LabelControl7";
            this.LabelControl7.Size = new System.Drawing.Size(64, 13);
            this.LabelControl7.TabIndex = 16;
            this.LabelControl7.Text = "Seal Number:";
            // 
            // LabelControl5
            // 
            this.LabelControl5.Location = new System.Drawing.Point(274, 69);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new System.Drawing.Size(58, 13);
            this.LabelControl5.TabIndex = 8;
            this.LabelControl5.Text = "PO Number:";
            // 
            // LabelControl4
            // 
            this.LabelControl4.Location = new System.Drawing.Point(35, 43);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(27, 13);
            this.LabelControl4.TabIndex = 2;
            this.LabelControl4.Text = "Date:";
            // 
            // LabelControl3
            // 
            this.LabelControl3.Location = new System.Drawing.Point(35, 17);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(50, 13);
            this.LabelControl3.TabIndex = 0;
            this.LabelControl3.Text = "Customer:";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Location = new System.Drawing.Point(274, 43);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(26, 13);
            this.LabelControl2.TabIndex = 4;
            this.LabelControl2.Text = "Shift:";
            // 
            // detailsXtraTabPage
            // 
            this.detailsXtraTabPage.Controls.Add(this.BulkEntryGroupControl);
            this.detailsXtraTabPage.Controls.Add(this.receivingGridControl);
            this.detailsXtraTabPage.Name = "detailsXtraTabPage";
            this.detailsXtraTabPage.Size = new System.Drawing.Size(1127, 460);
            this.detailsXtraTabPage.Text = "Receiving Details";
            // 
            // BulkEntryGroupControl
            // 
            this.BulkEntryGroupControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BulkEntryGroupControl.AutoSize = true;
            this.BulkEntryGroupControl.Controls.Add(this.label9);
            this.BulkEntryGroupControl.Controls.Add(this.uomTextEdit);
            this.BulkEntryGroupControl.Controls.Add(this.duplicateButton);
            this.BulkEntryGroupControl.Controls.Add(this.LabelControl25);
            this.BulkEntryGroupControl.Controls.Add(this.UnitQtyLockCheckEdit);
            this.BulkEntryGroupControl.Controls.Add(this.AddToPalletButton);
            this.BulkEntryGroupControl.Controls.Add(this.AddEntryButton);
            this.BulkEntryGroupControl.Controls.Add(this.QtyPerPltTextEdit);
            this.BulkEntryGroupControl.Controls.Add(this.UnitsPerPltTextEdit);
            this.BulkEntryGroupControl.Controls.Add(this.QtyTextEdit);
            this.BulkEntryGroupControl.Controls.Add(this.UnitsTextEdit);
            this.BulkEntryGroupControl.Controls.Add(this.LotTextEdit);
            this.BulkEntryGroupControl.Controls.Add(this.ItemDescTextEdit);
            this.BulkEntryGroupControl.Controls.Add(this.Label8);
            this.BulkEntryGroupControl.Controls.Add(this.Label7);
            this.BulkEntryGroupControl.Controls.Add(this.Label6);
            this.BulkEntryGroupControl.Controls.Add(this.Label5);
            this.BulkEntryGroupControl.Controls.Add(this.Label4);
            this.BulkEntryGroupControl.Controls.Add(this.Label3);
            this.BulkEntryGroupControl.Controls.Add(this.Label2);
            this.BulkEntryGroupControl.Controls.Add(this.Label1);
            this.BulkEntryGroupControl.Controls.Add(this.ExpirationDateEdit);
            this.BulkEntryGroupControl.Controls.Add(this.ItemLookUpEdit);
            this.BulkEntryGroupControl.Location = new System.Drawing.Point(0, 3);
            this.BulkEntryGroupControl.Name = "BulkEntryGroupControl";
            this.BulkEntryGroupControl.ShowCaption = false;
            this.BulkEntryGroupControl.Size = new System.Drawing.Size(1126, 78);
            this.BulkEntryGroupControl.TabIndex = 26;
            this.BulkEntryGroupControl.Text = "GroupControl1";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(616, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "UOM";
            // 
            // uomTextEdit
            // 
            this.uomTextEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uomTextEdit.EditValue = "";
            this.uomTextEdit.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.uomTextEdit.Location = new System.Drawing.Point(619, 50);
            this.uomTextEdit.MenuManager = this.BarManager1;
            this.uomTextEdit.Name = "uomTextEdit";
            this.uomTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.uomTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.uomTextEdit.Properties.ReadOnly = true;
            this.uomTextEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uomTextEdit.Size = new System.Drawing.Size(75, 20);
            this.uomTextEdit.TabIndex = 43;
            this.uomTextEdit.TabStop = false;
            this.uomTextEdit.Tag = "";
            // 
            // duplicateButton
            // 
            this.duplicateButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.duplicateButton.Location = new System.Drawing.Point(960, 6);
            this.duplicateButton.Name = "duplicateButton";
            this.duplicateButton.Size = new System.Drawing.Size(154, 23);
            this.duplicateButton.TabIndex = 42;
            this.duplicateButton.Text = "Duplicate";
            this.duplicateButton.Click += new System.EventHandler(this.DuplicateButton_Click);
            // 
            // LabelControl25
            // 
            this.LabelControl25.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelControl25.Location = new System.Drawing.Point(845, 31);
            this.LabelControl25.Name = "LabelControl25";
            this.LabelControl25.Size = new System.Drawing.Size(32, 13);
            this.LabelControl25.TabIndex = 40;
            this.LabelControl25.Text = "-- 🔒 --";
            // 
            // UnitQtyLockCheckEdit
            // 
            this.UnitQtyLockCheckEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UnitQtyLockCheckEdit.EditValue = true;
            this.UnitQtyLockCheckEdit.Location = new System.Drawing.Point(854, 50);
            this.UnitQtyLockCheckEdit.MenuManager = this.BarManager1;
            this.UnitQtyLockCheckEdit.Name = "UnitQtyLockCheckEdit";
            this.UnitQtyLockCheckEdit.Properties.Caption = "CheckEdit1";
            this.UnitQtyLockCheckEdit.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.UnitQtyLockCheckEdit.Properties.ValueGrayed = false;
            this.UnitQtyLockCheckEdit.Size = new System.Drawing.Size(16, 19);
            this.UnitQtyLockCheckEdit.TabIndex = 32;
            this.UnitQtyLockCheckEdit.TabStop = false;
            this.UnitQtyLockCheckEdit.Tag = "True";
            // 
            // AddToPalletButton
            // 
            this.AddToPalletButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddToPalletButton.Location = new System.Drawing.Point(1041, 48);
            this.AddToPalletButton.Name = "AddToPalletButton";
            this.AddToPalletButton.Size = new System.Drawing.Size(75, 23);
            this.AddToPalletButton.TabIndex = 35;
            this.AddToPalletButton.Text = "Add to Pallet";
            this.AddToPalletButton.Click += new System.EventHandler(this.AddToPalletButton_Click);
            // 
            // AddEntryButton
            // 
            this.AddEntryButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AddEntryButton.Location = new System.Drawing.Point(960, 48);
            this.AddEntryButton.Name = "AddEntryButton";
            this.AddEntryButton.Size = new System.Drawing.Size(75, 23);
            this.AddEntryButton.TabIndex = 34;
            this.AddEntryButton.Text = "Add Pallets";
            this.AddEntryButton.Click += new System.EventHandler(this.AddEntryButton_Click);
            // 
            // QtyPerPltTextEdit
            // 
            this.QtyPerPltTextEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.QtyPerPltTextEdit.EditValue = 0D;
            this.QtyPerPltTextEdit.Location = new System.Drawing.Point(781, 50);
            this.QtyPerPltTextEdit.MenuManager = this.BarManager1;
            this.QtyPerPltTextEdit.Name = "QtyPerPltTextEdit";
            this.QtyPerPltTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.QtyPerPltTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.QtyPerPltTextEdit.Size = new System.Drawing.Size(67, 20);
            this.QtyPerPltTextEdit.TabIndex = 33;
            this.QtyPerPltTextEdit.TabStop = false;
            this.QtyPerPltTextEdit.Tag = "0";
            this.QtyPerPltTextEdit.Validated += new System.EventHandler(this.QtyPerPltTextEdit_Validated);
            // 
            // UnitsPerPltTextEdit
            // 
            this.UnitsPerPltTextEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UnitsPerPltTextEdit.EditValue = 0D;
            this.UnitsPerPltTextEdit.Location = new System.Drawing.Point(876, 49);
            this.UnitsPerPltTextEdit.MenuManager = this.BarManager1;
            this.UnitsPerPltTextEdit.Name = "UnitsPerPltTextEdit";
            this.UnitsPerPltTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.UnitsPerPltTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.UnitsPerPltTextEdit.Size = new System.Drawing.Size(67, 20);
            this.UnitsPerPltTextEdit.TabIndex = 31;
            this.UnitsPerPltTextEdit.TabStop = false;
            this.UnitsPerPltTextEdit.Tag = "0";
            this.UnitsPerPltTextEdit.Validated += new System.EventHandler(this.UnitsPerPltTextEdit_Validated);
            // 
            // QtyTextEdit
            // 
            this.QtyTextEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.QtyTextEdit.EditValue = 0D;
            this.QtyTextEdit.Location = new System.Drawing.Point(538, 50);
            this.QtyTextEdit.MenuManager = this.BarManager1;
            this.QtyTextEdit.Name = "QtyTextEdit";
            this.QtyTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.QtyTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.QtyTextEdit.Size = new System.Drawing.Size(75, 20);
            this.QtyTextEdit.TabIndex = 30;
            this.QtyTextEdit.Tag = "0";
            this.QtyTextEdit.Validated += new System.EventHandler(this.QtyTextEdit_Validated);
            // 
            // UnitsTextEdit
            // 
            this.UnitsTextEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UnitsTextEdit.EditValue = 0D;
            this.UnitsTextEdit.Location = new System.Drawing.Point(700, 50);
            this.UnitsTextEdit.MenuManager = this.BarManager1;
            this.UnitsTextEdit.Name = "UnitsTextEdit";
            this.UnitsTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.UnitsTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.UnitsTextEdit.Properties.ReadOnly = true;
            this.UnitsTextEdit.Size = new System.Drawing.Size(75, 20);
            this.UnitsTextEdit.TabIndex = 29;
            this.UnitsTextEdit.TabStop = false;
            this.UnitsTextEdit.Tag = "0";
            this.UnitsTextEdit.Validated += new System.EventHandler(this.UnitsTextEdit_Validated);
            // 
            // LotTextEdit
            // 
            this.LotTextEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LotTextEdit.Location = new System.Drawing.Point(348, 50);
            this.LotTextEdit.MenuManager = this.BarManager1;
            this.LotTextEdit.Name = "LotTextEdit";
            this.LotTextEdit.Size = new System.Drawing.Size(100, 20);
            this.LotTextEdit.TabIndex = 27;
            this.LotTextEdit.Validated += new System.EventHandler(this.LotTextEdit_Validated);
            // 
            // ItemDescTextEdit
            // 
            this.ItemDescTextEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ItemDescTextEdit.Location = new System.Drawing.Point(166, 50);
            this.ItemDescTextEdit.MenuManager = this.BarManager1;
            this.ItemDescTextEdit.Name = "ItemDescTextEdit";
            this.ItemDescTextEdit.Size = new System.Drawing.Size(176, 20);
            this.ItemDescTextEdit.TabIndex = 38;
            this.ItemDescTextEdit.TabStop = false;
            // 
            // Label8
            // 
            this.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(781, 33);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(61, 13);
            this.Label8.TabIndex = 37;
            this.Label8.Text = "Qty - Pallet";
            // 
            // Label7
            // 
            this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(879, 31);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(67, 13);
            this.Label7.TabIndex = 36;
            this.Label7.Text = "Units - Pallet";
            // 
            // Label6
            // 
            this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(535, 33);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(72, 13);
            this.Label6.TabIndex = 35;
            this.Label6.Text = "Qty Received";
            // 
            // Label5
            // 
            this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(697, 33);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(78, 13);
            this.Label5.TabIndex = 34;
            this.Label5.Text = "Units Received";
            // 
            // Label4
            // 
            this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(451, 32);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(81, 13);
            this.Label4.TabIndex = 33;
            this.Label4.Text = "Expiration Date";
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(345, 32);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(33, 13);
            this.Label3.TabIndex = 32;
            this.Label3.Text = "Lot #";
            // 
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(163, 32);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(85, 13);
            this.Label2.TabIndex = 31;
            this.Label2.Text = "Item Description";
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(2, 32);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(69, 13);
            this.Label1.TabIndex = 30;
            this.Label1.Text = "Item Number";
            // 
            // ExpirationDateEdit
            // 
            this.ExpirationDateEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExpirationDateEdit.EditValue = null;
            this.ExpirationDateEdit.Location = new System.Drawing.Point(454, 50);
            this.ExpirationDateEdit.MenuManager = this.BarManager1;
            this.ExpirationDateEdit.Name = "ExpirationDateEdit";
            this.ExpirationDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ExpirationDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ExpirationDateEdit.Properties.MinValue = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.ExpirationDateEdit.Size = new System.Drawing.Size(78, 20);
            this.ExpirationDateEdit.TabIndex = 28;
            this.ExpirationDateEdit.Tag = "";
            // 
            // ItemLookUpEdit
            // 
            this.ItemLookUpEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ItemLookUpEdit.Location = new System.Drawing.Point(5, 50);
            this.ItemLookUpEdit.MenuManager = this.BarManager1;
            this.ItemLookUpEdit.Name = "ItemLookUpEdit";
            this.ItemLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ItemLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 59, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCustomerID", "Item Customer ID", 95, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.ItemLookUpEdit.Properties.DataSource = this.receivingItemXPView;
            this.ItemLookUpEdit.Properties.DisplayMember = "ItemCode";
            this.ItemLookUpEdit.Properties.NullText = "";
            this.ItemLookUpEdit.Properties.NullValuePrompt = "[Select A Item]";
            this.ItemLookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
            this.ItemLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.ItemLookUpEdit.Properties.ValidateOnEnterKey = true;
            this.ItemLookUpEdit.Properties.ValueMember = "ItemID";
            this.ItemLookUpEdit.Size = new System.Drawing.Size(155, 20);
            this.ItemLookUpEdit.TabIndex = 26;
            this.ItemLookUpEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemLookUpEdit_KeyDown);
            this.ItemLookUpEdit.Validating += new System.ComponentModel.CancelEventHandler(this.ItemLookUpEdit_Validating);
            this.ItemLookUpEdit.Validated += new System.EventHandler(this.ItemLookUpEdit_Validated);
            // 
            // receivingItemXPView
            // 
            this.receivingItemXPView.CriteriaString = "[Inactive] = False";
            this.receivingItemXPView.ObjectType = typeof(DXDAL.SPGData.Items);
            this.receivingItemXPView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[ItemID]", false, true),
            new DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[ItemCode]", false, true),
            new DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID.CustomerID]", false, true),
            new DevExpress.Xpo.ViewProperty("ItemCustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID]", false, true),
            new DevExpress.Xpo.ViewProperty("Inactive", DevExpress.Xpo.SortDirection.None, "[Inactive]", false, true)});
            // 
            // receivingGridControl
            // 
            this.receivingGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.receivingGridControl.Location = new System.Drawing.Point(-1, 78);
            this.receivingGridControl.MainView = this.receivingGridView;
            this.receivingGridControl.Name = "receivingGridControl";
            this.receivingGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.itemRepositoryItemLookUpEdit,
            this.delRepositoryItemButtonEdit,
            this.RepositoryItemDateEdit1,
            this.AddLotRepositoryItemButtonEdit,
            this.AddedLotCheckEdit});
            this.receivingGridControl.Size = new System.Drawing.Size(1128, 382);
            this.receivingGridControl.TabIndex = 0;
            this.receivingGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.receivingGridView});
            // 
            // receivingGridView
            // 
            this.receivingGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idGridColumn,
            this.receivingIDGridColumn,
            this.itemGridColumn,
            this.descriptionGridColumn,
            this.lotGridColumn,
            this.expirationDateGridColumn,
            this.quantityGridColumn,
            this.packagesGridColumn,
            this.ReceivDetLPNColumn,
            this.delGridColumn,
            this.AddedLotGridColumn});
            this.receivingGridView.GridControl = this.receivingGridControl;
            this.receivingGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ReceivDetQty", this.quantityGridColumn, "{0:#,##0.######}")});
            this.receivingGridView.Name = "receivingGridView";
            this.receivingGridView.OptionsSelection.MultiSelect = true;
            this.receivingGridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.receivingGridView.OptionsView.ShowFooter = true;
            this.receivingGridView.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.receivingGridView_CustomSummaryCalculate);
            this.receivingGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.receivingGridView_InitNewRow);
            this.receivingGridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.receivingGridView_CustomUnboundColumnData);
            // 
            // idGridColumn
            // 
            this.idGridColumn.Caption = "GridColumn1";
            this.idGridColumn.Name = "idGridColumn";
            // 
            // receivingIDGridColumn
            // 
            this.receivingIDGridColumn.Caption = "GridColumn1";
            this.receivingIDGridColumn.Name = "receivingIDGridColumn";
            // 
            // itemGridColumn
            // 
            this.itemGridColumn.Caption = "Item Number";
            this.itemGridColumn.ColumnEdit = this.itemRepositoryItemLookUpEdit;
            this.itemGridColumn.Name = "itemGridColumn";
            this.itemGridColumn.Visible = true;
            this.itemGridColumn.VisibleIndex = 1;
            this.itemGridColumn.Width = 149;
            // 
            // itemRepositoryItemLookUpEdit
            // 
            this.itemRepositoryItemLookUpEdit.AutoHeight = false;
            this.itemRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.itemRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 59, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCustomerID", "Item Customer ID", 95, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.itemRepositoryItemLookUpEdit.DataSource = this.receivingItemXPView;
            this.itemRepositoryItemLookUpEdit.DisplayMember = "ItemCode";
            this.itemRepositoryItemLookUpEdit.ImmediatePopup = true;
            this.itemRepositoryItemLookUpEdit.Name = "itemRepositoryItemLookUpEdit";
            this.itemRepositoryItemLookUpEdit.NullText = "";
            this.itemRepositoryItemLookUpEdit.NullValuePrompt = "[Select A Item]";
            this.itemRepositoryItemLookUpEdit.NullValuePromptShowForEmptyValue = true;
            this.itemRepositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.itemRepositoryItemLookUpEdit.ValueMember = "ItemID";
            this.itemRepositoryItemLookUpEdit.ProcessNewValue += new DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(this.itemRepositoryItemLookUpEdit_ProcessNewValue);
            this.itemRepositoryItemLookUpEdit.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.itemRepositoryItemLookUpEdit_Closed);
            this.itemRepositoryItemLookUpEdit.Enter += new System.EventHandler(this.itemRepositoryItemLookUpEdit_Enter);
            // 
            // descriptionGridColumn
            // 
            this.descriptionGridColumn.Caption = "Item Description";
            this.descriptionGridColumn.FieldName = "descriptionGridColumn";
            this.descriptionGridColumn.Name = "descriptionGridColumn";
            this.descriptionGridColumn.OptionsColumn.AllowEdit = false;
            this.descriptionGridColumn.OptionsColumn.ReadOnly = true;
            this.descriptionGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.descriptionGridColumn.Visible = true;
            this.descriptionGridColumn.VisibleIndex = 2;
            this.descriptionGridColumn.Width = 73;
            // 
            // lotGridColumn
            // 
            this.lotGridColumn.Caption = "Lot #";
            this.lotGridColumn.Name = "lotGridColumn";
            this.lotGridColumn.Visible = true;
            this.lotGridColumn.VisibleIndex = 3;
            this.lotGridColumn.Width = 73;
            // 
            // expirationDateGridColumn
            // 
            this.expirationDateGridColumn.Caption = "Expiration Date";
            this.expirationDateGridColumn.ColumnEdit = this.RepositoryItemDateEdit1;
            this.expirationDateGridColumn.DisplayFormat.FormatString = "d";
            this.expirationDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.expirationDateGridColumn.Name = "expirationDateGridColumn";
            this.expirationDateGridColumn.Visible = true;
            this.expirationDateGridColumn.VisibleIndex = 4;
            this.expirationDateGridColumn.Width = 153;
            // 
            // RepositoryItemDateEdit1
            // 
            this.RepositoryItemDateEdit1.AutoHeight = false;
            this.RepositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.RepositoryItemDateEdit1.MinValue = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1";
            // 
            // quantityGridColumn
            // 
            this.quantityGridColumn.Caption = "Quantity";
            this.quantityGridColumn.Name = "quantityGridColumn";
            this.quantityGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "Quantity = {0:0.##}")});
            this.quantityGridColumn.Visible = true;
            this.quantityGridColumn.VisibleIndex = 6;
            this.quantityGridColumn.Width = 73;
            // 
            // packagesGridColumn
            // 
            this.packagesGridColumn.Caption = "Units Received";
            this.packagesGridColumn.Name = "packagesGridColumn";
            this.packagesGridColumn.Visible = true;
            this.packagesGridColumn.VisibleIndex = 5;
            this.packagesGridColumn.Width = 73;
            // 
            // ReceivDetLPNColumn
            // 
            this.ReceivDetLPNColumn.Caption = "LPN";
            this.ReceivDetLPNColumn.FieldName = "ReceivDetLPNColumn";
            this.ReceivDetLPNColumn.Name = "ReceivDetLPNColumn";
            this.ReceivDetLPNColumn.OptionsColumn.ReadOnly = true;
            this.ReceivDetLPNColumn.Visible = true;
            this.ReceivDetLPNColumn.VisibleIndex = 7;
            // 
            // delGridColumn
            // 
            this.delGridColumn.ColumnEdit = this.delRepositoryItemButtonEdit;
            this.delGridColumn.MaxWidth = 30;
            this.delGridColumn.MinWidth = 25;
            this.delGridColumn.Name = "delGridColumn";
            this.delGridColumn.Visible = true;
            this.delGridColumn.VisibleIndex = 0;
            this.delGridColumn.Width = 25;
            // 
            // delRepositoryItemButtonEdit
            // 
            this.delRepositoryItemButtonEdit.AutoHeight = false;
            this.delRepositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.delRepositoryItemButtonEdit.Name = "delRepositoryItemButtonEdit";
            this.delRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.delRepositoryItemButtonEdit.Click += new System.EventHandler(this.delRepositoryItemButtonEdit_Click);
            // 
            // AddedLotGridColumn
            // 
            this.AddedLotGridColumn.Caption = "GridColumn3";
            this.AddedLotGridColumn.ColumnEdit = this.AddedLotCheckEdit;
            this.AddedLotGridColumn.Name = "AddedLotGridColumn";
            // 
            // AddedLotCheckEdit
            // 
            this.AddedLotCheckEdit.AutoHeight = false;
            this.AddedLotCheckEdit.Name = "AddedLotCheckEdit";
            this.AddedLotCheckEdit.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.AddedLotCheckEdit.ValueGrayed = false;
            // 
            // AddLotRepositoryItemButtonEdit
            // 
            this.AddLotRepositoryItemButtonEdit.AutoHeight = false;
            this.AddLotRepositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.AddLotRepositoryItemButtonEdit.Name = "AddLotRepositoryItemButtonEdit";
            this.AddLotRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.AddLotRepositoryItemButtonEdit.Click += new System.EventHandler(this.AddLotRepositoryItemButtonEdit_Click);
            // 
            // returnsXtraTabPage
            // 
            this.returnsXtraTabPage.Controls.Add(this.returnsGridControl);
            this.returnsXtraTabPage.Name = "returnsXtraTabPage";
            this.returnsXtraTabPage.PageVisible = false;
            this.returnsXtraTabPage.Size = new System.Drawing.Size(1127, 460);
            this.returnsXtraTabPage.Text = "Return Details";
            // 
            // returnsGridControl
            // 
            this.returnsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.returnsGridControl.Location = new System.Drawing.Point(0, 0);
            this.returnsGridControl.MainView = this.returnsGridView;
            this.returnsGridControl.Name = "returnsGridControl";
            this.returnsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.returnItemRepositoryItemLookUpEdit,
            this.returnReasonRepositoryItemMemoExEdit,
            this.deleteReturnRepositoryItemButtonEdit,
            this.RepositoryItemDateEdit2});
            this.returnsGridControl.Size = new System.Drawing.Size(1127, 460);
            this.returnsGridControl.TabIndex = 0;
            this.returnsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.returnsGridView});
            // 
            // returnsGridView
            // 
            this.returnsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.returnIDGridColumn,
            this.ReceiveMainIDGridColumn,
            this.returnItemGridColumn,
            this.returnItemDescGridColumn,
            this.returnLotGridColumn,
            this.returnExpirationDateGridColumn,
            this.returnQuantityGridColumn,
            this.returnUnitsGridColumn,
            this.returnPalletsGridColumn,
            this.returnReasonGridColumn,
            this.deleteGridColumn});
            this.returnsGridView.GridControl = this.returnsGridControl;
            this.returnsGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ReturnDetQty", this.returnQuantityGridColumn, "{0:#,##0.######}")});
            this.returnsGridView.Name = "returnsGridView";
            this.returnsGridView.OptionsSelection.MultiSelect = true;
            this.returnsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.returnsGridView.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.returnsGridView_CustomSummaryCalculate);
            this.returnsGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.returnsGridView_InitNewRow);
            this.returnsGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.returnsGridView_CellValueChanged);
            this.returnsGridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.returnsGridView_CustomUnboundColumnData);
            // 
            // returnIDGridColumn
            // 
            this.returnIDGridColumn.Caption = "GridColumn1";
            this.returnIDGridColumn.Name = "returnIDGridColumn";
            // 
            // ReceiveMainIDGridColumn
            // 
            this.ReceiveMainIDGridColumn.Caption = "GridColumn1";
            this.ReceiveMainIDGridColumn.Name = "ReceiveMainIDGridColumn";
            // 
            // returnItemGridColumn
            // 
            this.returnItemGridColumn.Caption = "Item Number";
            this.returnItemGridColumn.ColumnEdit = this.returnItemRepositoryItemLookUpEdit;
            this.returnItemGridColumn.Name = "returnItemGridColumn";
            this.returnItemGridColumn.Visible = true;
            this.returnItemGridColumn.VisibleIndex = 1;
            // 
            // returnItemRepositoryItemLookUpEdit
            // 
            this.returnItemRepositoryItemLookUpEdit.AutoHeight = false;
            this.returnItemRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.returnItemRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 59, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCustomerID", "Item Customer ID", 95, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.returnItemRepositoryItemLookUpEdit.DataSource = this.returnItemXPView;
            this.returnItemRepositoryItemLookUpEdit.DisplayMember = "ItemCode";
            this.returnItemRepositoryItemLookUpEdit.ImmediatePopup = true;
            this.returnItemRepositoryItemLookUpEdit.Name = "returnItemRepositoryItemLookUpEdit";
            this.returnItemRepositoryItemLookUpEdit.NullText = "";
            this.returnItemRepositoryItemLookUpEdit.NullValuePrompt = "[Select A Item]";
            this.returnItemRepositoryItemLookUpEdit.NullValuePromptShowForEmptyValue = true;
            this.returnItemRepositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.returnItemRepositoryItemLookUpEdit.ValueMember = "ItemID";
            this.returnItemRepositoryItemLookUpEdit.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(this.itemRepositoryItemLookUpEdit_Closed);
            this.returnItemRepositoryItemLookUpEdit.Enter += new System.EventHandler(this.itemRepositoryItemLookUpEdit_Enter);
            // 
            // returnItemXPView
            // 
            this.returnItemXPView.CriteriaString = "[ItemType] = \'FG\'";
            this.returnItemXPView.ObjectType = typeof(DXDAL.SPGData.Items);
            this.returnItemXPView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[ItemID]", false, true),
            new DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[ItemCode]", false, true),
            new DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID.CustomerID]", false, true),
            new DevExpress.Xpo.ViewProperty("ItemCustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID]", false, true),
            new DevExpress.Xpo.ViewProperty("Inactive", DevExpress.Xpo.SortDirection.None, "[Inactive]", false, true)});
            // 
            // returnItemDescGridColumn
            // 
            this.returnItemDescGridColumn.Caption = "Item Description";
            this.returnItemDescGridColumn.FieldName = "descriptionGridColumn";
            this.returnItemDescGridColumn.Name = "returnItemDescGridColumn";
            this.returnItemDescGridColumn.OptionsColumn.AllowEdit = false;
            this.returnItemDescGridColumn.OptionsColumn.ReadOnly = true;
            this.returnItemDescGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.returnItemDescGridColumn.Visible = true;
            this.returnItemDescGridColumn.VisibleIndex = 2;
            // 
            // returnLotGridColumn
            // 
            this.returnLotGridColumn.Caption = "Lot #";
            this.returnLotGridColumn.Name = "returnLotGridColumn";
            this.returnLotGridColumn.Visible = true;
            this.returnLotGridColumn.VisibleIndex = 3;
            // 
            // returnExpirationDateGridColumn
            // 
            this.returnExpirationDateGridColumn.Caption = "Expiration Date";
            this.returnExpirationDateGridColumn.ColumnEdit = this.RepositoryItemDateEdit2;
            this.returnExpirationDateGridColumn.DisplayFormat.FormatString = "d";
            this.returnExpirationDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.returnExpirationDateGridColumn.Name = "returnExpirationDateGridColumn";
            this.returnExpirationDateGridColumn.Visible = true;
            this.returnExpirationDateGridColumn.VisibleIndex = 4;
            // 
            // RepositoryItemDateEdit2
            // 
            this.RepositoryItemDateEdit2.AutoHeight = false;
            this.RepositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2";
            // 
            // returnQuantityGridColumn
            // 
            this.returnQuantityGridColumn.Caption = "Quantity";
            this.returnQuantityGridColumn.Name = "returnQuantityGridColumn";
            this.returnQuantityGridColumn.Visible = true;
            this.returnQuantityGridColumn.VisibleIndex = 5;
            // 
            // returnUnitsGridColumn
            // 
            this.returnUnitsGridColumn.Caption = "Units";
            this.returnUnitsGridColumn.Name = "returnUnitsGridColumn";
            this.returnUnitsGridColumn.Visible = true;
            this.returnUnitsGridColumn.VisibleIndex = 6;
            // 
            // returnPalletsGridColumn
            // 
            this.returnPalletsGridColumn.Caption = "Pallets";
            this.returnPalletsGridColumn.Name = "returnPalletsGridColumn";
            this.returnPalletsGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)});
            this.returnPalletsGridColumn.Visible = true;
            this.returnPalletsGridColumn.VisibleIndex = 7;
            // 
            // returnReasonGridColumn
            // 
            this.returnReasonGridColumn.Caption = "Reason";
            this.returnReasonGridColumn.ColumnEdit = this.returnReasonRepositoryItemMemoExEdit;
            this.returnReasonGridColumn.Name = "returnReasonGridColumn";
            this.returnReasonGridColumn.Visible = true;
            this.returnReasonGridColumn.VisibleIndex = 8;
            // 
            // returnReasonRepositoryItemMemoExEdit
            // 
            this.returnReasonRepositoryItemMemoExEdit.AutoHeight = false;
            this.returnReasonRepositoryItemMemoExEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.returnReasonRepositoryItemMemoExEdit.Name = "returnReasonRepositoryItemMemoExEdit";
            // 
            // deleteGridColumn
            // 
            this.deleteGridColumn.ColumnEdit = this.deleteReturnRepositoryItemButtonEdit;
            this.deleteGridColumn.MaxWidth = 30;
            this.deleteGridColumn.MinWidth = 25;
            this.deleteGridColumn.Name = "deleteGridColumn";
            this.deleteGridColumn.Visible = true;
            this.deleteGridColumn.VisibleIndex = 0;
            this.deleteGridColumn.Width = 25;
            // 
            // deleteReturnRepositoryItemButtonEdit
            // 
            this.deleteReturnRepositoryItemButtonEdit.AutoHeight = false;
            this.deleteReturnRepositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.deleteReturnRepositoryItemButtonEdit.Name = "deleteReturnRepositoryItemButtonEdit";
            this.deleteReturnRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.deleteReturnRepositoryItemButtonEdit.Click += new System.EventHandler(this.deleteReturnRepositoryItemButtonEdit_Click);
            // 
            // SplitContainerControl1
            // 
            this.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerControl1.Location = new System.Drawing.Point(0, 49);
            this.SplitContainerControl1.Name = "SplitContainerControl1";
            this.SplitContainerControl1.Panel1.Controls.Add(this.receivingSearchGridControl);
            this.SplitContainerControl1.Panel1.MinSize = 250;
            this.SplitContainerControl1.Panel1.Text = "Panel1";
            this.SplitContainerControl1.Panel2.Controls.Add(this.receivingsXtraTabControl);
            this.SplitContainerControl1.Panel2.Text = "Panel2";
            this.SplitContainerControl1.Size = new System.Drawing.Size(1388, 488);
            this.SplitContainerControl1.SplitterPosition = 200;
            this.SplitContainerControl1.TabIndex = 9;
            this.SplitContainerControl1.Text = "SplitContainerControl1";
            // 
            // receivingSearchGridControl
            // 
            this.receivingSearchGridControl.DataSource = this.receivingSearchXPView;
            this.receivingSearchGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receivingSearchGridControl.Location = new System.Drawing.Point(0, 0);
            this.receivingSearchGridControl.MainView = this.receivingSearchGridView;
            this.receivingSearchGridControl.Name = "receivingSearchGridControl";
            this.receivingSearchGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.customerFilterRepositoryItemLookUpEdit,
            this.receivingDateRepositoryItemDateEdit});
            this.receivingSearchGridControl.Size = new System.Drawing.Size(250, 488);
            this.receivingSearchGridControl.TabIndex = 0;
            this.receivingSearchGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.receivingSearchGridView});
            // 
            // receivingSearchXPView
            // 
            this.receivingSearchXPView.ObjectType = typeof(DXDAL.SPGData.Receiving);
            this.receivingSearchXPView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("ReceivingID", DevExpress.Xpo.SortDirection.None, "[ReceivID]", false, true),
            new DevExpress.Xpo.ViewProperty("ReceivingBOL", DevExpress.Xpo.SortDirection.None, "[ReceivBOL]", false, true),
            new DevExpress.Xpo.ViewProperty("ReceivingCustomerID", DevExpress.Xpo.SortDirection.None, "[ReceivCustID.CustomerID]", false, true),
            new DevExpress.Xpo.ViewProperty("ReceivingCustomerName", DevExpress.Xpo.SortDirection.None, "[ReceivCustID.CustomerName]", false, true),
            new DevExpress.Xpo.ViewProperty("ReceivingDate", DevExpress.Xpo.SortDirection.None, "[ReceivDate]", false, true)});
            // 
            // receivingSearchGridView
            // 
            this.receivingSearchGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BOLGridColumn,
            this.customerGridColumn,
            this.dateGridColumn,
            this.receivingIDSearchGridColumn});
            this.receivingSearchGridView.GridControl = this.receivingSearchGridControl;
            this.receivingSearchGridView.Name = "receivingSearchGridView";
            this.receivingSearchGridView.OptionsBehavior.Editable = false;
            this.receivingSearchGridView.OptionsView.ShowAutoFilterRow = true;
            this.receivingSearchGridView.OptionsView.ShowGroupPanel = false;
            this.receivingSearchGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.BOLGridColumn, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.receivingSearchGridView.Click += new System.EventHandler(this.receivingSearchGridView_Click);
            // 
            // BOLGridColumn
            // 
            this.BOLGridColumn.Caption = "BOL #";
            this.BOLGridColumn.FieldName = "ReceivingBOL";
            this.BOLGridColumn.Name = "BOLGridColumn";
            this.BOLGridColumn.Visible = true;
            this.BOLGridColumn.VisibleIndex = 0;
            // 
            // customerGridColumn
            // 
            this.customerGridColumn.Caption = "Customer";
            this.customerGridColumn.FieldName = "ReceivingCustomerName";
            this.customerGridColumn.Name = "customerGridColumn";
            this.customerGridColumn.Visible = true;
            this.customerGridColumn.VisibleIndex = 1;
            // 
            // dateGridColumn
            // 
            this.dateGridColumn.Caption = "Date";
            this.dateGridColumn.ColumnEdit = this.receivingDateRepositoryItemDateEdit;
            this.dateGridColumn.FieldName = "ReceivingDate";
            this.dateGridColumn.Name = "dateGridColumn";
            this.dateGridColumn.Visible = true;
            this.dateGridColumn.VisibleIndex = 2;
            // 
            // receivingDateRepositoryItemDateEdit
            // 
            this.receivingDateRepositoryItemDateEdit.AutoHeight = false;
            this.receivingDateRepositoryItemDateEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.receivingDateRepositoryItemDateEdit.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.receivingDateRepositoryItemDateEdit.Name = "receivingDateRepositoryItemDateEdit";
            // 
            // receivingIDSearchGridColumn
            // 
            this.receivingIDSearchGridColumn.Caption = "GridColumn1";
            this.receivingIDSearchGridColumn.FieldName = "ReceivingID";
            this.receivingIDSearchGridColumn.Name = "receivingIDSearchGridColumn";
            // 
            // customerFilterRepositoryItemLookUpEdit
            // 
            this.customerFilterRepositoryItemLookUpEdit.AutoHeight = false;
            this.customerFilterRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.customerFilterRepositoryItemLookUpEdit.Name = "customerFilterRepositoryItemLookUpEdit";
            // 
            // BarButtonItem1
            // 
            this.BarButtonItem1.Caption = "Print &Receiving List";
            this.BarButtonItem1.Id = 4;
            this.BarButtonItem1.Name = "BarButtonItem1";
            // 
            // GridColumn1
            // 
            this.GridColumn1.ColumnEdit = this.delRepositoryItemButtonEdit;
            this.GridColumn1.MaxWidth = 30;
            this.GridColumn1.MinWidth = 25;
            this.GridColumn1.Name = "GridColumn1";
            this.GridColumn1.Visible = true;
            this.GridColumn1.VisibleIndex = 0;
            this.GridColumn1.Width = 25;
            // 
            // GridColumn2
            // 
            this.GridColumn2.ColumnEdit = this.delRepositoryItemButtonEdit;
            this.GridColumn2.MaxWidth = 30;
            this.GridColumn2.MinWidth = 25;
            this.GridColumn2.Name = "GridColumn2";
            this.GridColumn2.Visible = true;
            this.GridColumn2.VisibleIndex = 0;
            this.GridColumn2.Width = 25;
            // 
            // FinishedProductAvailabilityReportTableAdapter1
            // 
            this.FinishedProductAvailabilityReportTableAdapter1.ClearBeforeFill = true;
            // 
            // ReceivingXtraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 560);
            this.Controls.Add(this.SplitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReceivingXtraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receiving";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReceivingXtraForm_FormClosing);
            this.Load += new System.EventHandler(this.ReceivingXtraForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.receivingsXtraTabControl)).EndInit();
            this.receivingsXtraTabControl.ResumeLayout(false);
            this.generalXtraTabPage.ResumeLayout(false);
            this.generalXtraTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationXpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.correctPalletsComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insectActivityComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foreignSubstanceComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheelsChockedComboBoxEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadConditionLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipmentConditionXpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.physicalConditionLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finishTimeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startTimeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedByLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeXpView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unloadedByLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorLookupXPCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersXPView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrierLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiveDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiveDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sealTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trailerTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poTextEdit.Properties)).EndInit();
            this.detailsXtraTabPage.ResumeLayout(false);
            this.detailsXtraTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BulkEntryGroupControl)).EndInit();
            this.BulkEntryGroupControl.ResumeLayout(false);
            this.BulkEntryGroupControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uomTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitQtyLockCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtyPerPltTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsPerPltTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtyTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LotTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDescTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpirationDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpirationDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivingItemXPView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivingGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivingGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delRepositoryItemButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddedLotCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddLotRepositoryItemButtonEdit)).EndInit();
            this.returnsXtraTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.returnsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnItemRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnItemXPView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RepositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnReasonRepositoryItemMemoExEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteReturnRepositoryItemButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).EndInit();
            this.SplitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.receivingSearchGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivingSearchXPView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivingSearchGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivingDateRepositoryItemDateEdit.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivingDateRepositoryItemDateEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerFilterRepositoryItemLookUpEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal DevExpress.XtraTab.XtraTabControl receivingsXtraTabControl;
		internal DevExpress.XtraTab.XtraTabPage generalXtraTabPage;
		internal DevExpress.XtraTab.XtraTabPage detailsXtraTabPage;
		internal DevExpress.XtraEditors.LookUpEdit customerLookUpEdit;
		internal DevExpress.XtraEditors.LookUpEdit shiftLookUpEdit;
		internal DevExpress.XtraEditors.LookUpEdit carrierLookUpEdit;
		internal DevExpress.XtraEditors.DateEdit receiveDateEdit;
		internal DevExpress.XtraEditors.TextEdit sealTextEdit;
		internal DevExpress.XtraEditors.TextEdit trailerTextEdit;
		internal DevExpress.XtraEditors.TextEdit bolTextEdit;
		internal DevExpress.XtraEditors.TextEdit poTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl12;
		internal DevExpress.XtraEditors.LabelControl LabelControl11;
		internal DevExpress.XtraEditors.LabelControl LabelControl10;
		internal DevExpress.XtraEditors.LabelControl LabelControl9;
		internal DevExpress.XtraEditors.LabelControl LabelControl7;
		internal DevExpress.XtraEditors.LabelControl LabelControl5;
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraGrid.GridControl receivingGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView receivingGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn idGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn receivingIDGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn itemGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit itemRepositoryItemLookUpEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn descriptionGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn quantityGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn packagesGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn lotGridColumn;
		internal DevExpress.XtraBars.BarManager BarManager1;
		internal DevExpress.XtraBars.Bar receivingBar;
		internal DevExpress.XtraBars.Bar Bar2;
		internal DevExpress.XtraBars.Bar Bar3;
		internal DevExpress.XtraBars.BarDockControl barDockControlTop;
		internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
		internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
		internal DevExpress.XtraBars.BarDockControl barDockControlRight;
		internal DevExpress.XtraEditors.SplitContainerControl SplitContainerControl1;
		internal DevExpress.XtraGrid.GridControl receivingSearchGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView receivingSearchGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn BOLGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn customerGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn dateGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn receivingIDSearchGridColumn;
		internal DevExpress.XtraBars.BarButtonItem addBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem editBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem cancelBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem saveBarButtonItem;
		internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit customerFilterRepositoryItemLookUpEdit;
		internal DevExpress.XtraEditors.Repository.RepositoryItemDateEdit receivingDateRepositoryItemDateEdit;
		internal DevExpress.XtraEditors.MemoEdit notesMemoEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraTab.XtraTabPage returnsXtraTabPage;
		internal DevExpress.XtraGrid.GridControl returnsGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView returnsGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn returnIDGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn ReceiveMainIDGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn returnItemGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit returnItemRepositoryItemLookUpEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn returnItemDescGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn returnLotGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn returnQuantityGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn returnUnitsGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn returnPalletsGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn returnReasonGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit returnReasonRepositoryItemMemoExEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn deleteGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit deleteReturnRepositoryItemButtonEdit;
		internal DevExpress.XtraEditors.LookUpEdit vendorLookUpEdit;
		internal DevExpress.Xpo.XPCollection vendorLookupXPCollection;
		internal DevExpress.Xpo.XPView receivingSearchXPView;
		internal DevExpress.Xpo.XPView customersXPView;
		internal DevExpress.Xpo.XPView receivingItemXPView;
		internal DevExpress.Xpo.XPView returnItemXPView;
		internal DevExpress.XtraGrid.Columns.GridColumn delGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit delRepositoryItemButtonEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn expirationDateGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemDateEdit RepositoryItemDateEdit1;
		internal DevExpress.XtraGrid.Columns.GridColumn returnExpirationDateGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemDateEdit RepositoryItemDateEdit2;
		internal DevExpress.XtraEditors.LookUpEdit loadConditionLookUpEdit;
		internal DevExpress.XtraEditors.LookUpEdit physicalConditionLookUpEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl23;
		internal DevExpress.XtraEditors.LabelControl LabelControl22;
		internal DevExpress.XtraEditors.LabelControl LabelControl21;
		internal DevExpress.XtraEditors.SpinEdit temperatureSpinEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl20;
		internal DevExpress.XtraEditors.TimeEdit finishTimeEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl19;
		internal DevExpress.XtraEditors.TimeEdit startTimeEdit;
		internal DevExpress.XtraEditors.LookUpEdit checkedByLookUpEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl18;
		internal DevExpress.XtraEditors.LabelControl LabelControl17;
		internal DevExpress.XtraEditors.LookUpEdit unloadedByLookUpEdit;
		internal DevExpress.Xpo.XPView shipmentConditionXpView;
		internal DevExpress.Xpo.XPView employeeXpView;
		internal DevExpress.XtraBars.BarButtonItem receivingListBarButtonItem;
		internal DevExpress.XtraEditors.ComboBoxEdit correctPalletsComboBoxEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl16;
		internal DevExpress.XtraEditors.ComboBoxEdit insectActivityComboBoxEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl15;
		internal DevExpress.XtraEditors.ComboBoxEdit foreignSubstanceComboBoxEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl14;
		internal DevExpress.XtraEditors.ComboBoxEdit wheelsChockedComboBoxEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl13;
		internal DevExpress.XtraBars.BarButtonItem refreshBarButtonItem;
		internal DevExpress.XtraEditors.LookUpEdit locationLookUpEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl24;
		internal DevExpress.Xpo.XPView locationXpView;
		internal DevExpress.XtraGrid.Columns.GridColumn ReceivDetLPNColumn;
		internal DevExpress.XtraBars.BarButtonItem LpnLabelsBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem BarButtonItem1;
		internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit AddLotRepositoryItemButtonEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn AddedLotGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit AddedLotCheckEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn2;
		internal DevExpress.XtraEditors.GroupControl BulkEntryGroupControl;
		internal DevExpress.XtraEditors.TextEdit QtyPerPltTextEdit;
		internal DevExpress.XtraEditors.TextEdit UnitsPerPltTextEdit;
		internal DevExpress.XtraEditors.TextEdit QtyTextEdit;
		internal DevExpress.XtraEditors.TextEdit UnitsTextEdit;
		internal DevExpress.XtraEditors.TextEdit LotTextEdit;
		internal DevExpress.XtraEditors.TextEdit ItemDescTextEdit;
		internal Label Label8;
		internal Label Label7;
		internal Label Label6;
		internal Label Label5;
		internal Label Label4;
		internal Label Label3;
		internal Label Label2;
		internal Label Label1;
		internal DevExpress.XtraEditors.DateEdit ExpirationDateEdit;
		internal DevExpress.XtraEditors.LookUpEdit ItemLookUpEdit;
		internal DevExpress.XtraEditors.SimpleButton AddEntryButton;
		internal DevExpress.XtraEditors.SimpleButton AddToPalletButton;
		internal DevExpress.XtraEditors.SimpleButton SaveContinueSimpleButton;
		internal DevExpress.XtraEditors.CheckEdit UnitQtyLockCheckEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl25;
		internal SPGReportsTableAdapters.FinishedProductAvailabilityReportTableAdapter FinishedProductAvailabilityReportTableAdapter1;
        private SimpleButton duplicateButton;
        internal Label label9;
        internal TextEdit uomTextEdit;
    }

}