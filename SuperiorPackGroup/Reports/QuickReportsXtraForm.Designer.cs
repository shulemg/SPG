using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Columns;
using DevExpress.Xpo;
using DXDAL.SPGData;
using DevExpress.Data.Filtering;
using DevExpress.XtraPivotGrid;
using System.Linq;
using DevExpress.XtraEditors;

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
	public partial class QuickReportsXtraForm : DevExpress.XtraEditors.XtraForm
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
			DevExpress.XtraPivotGrid.PivotGridGroup PivotGridGroup1 = new DevExpress.XtraPivotGrid.PivotGridGroup();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickReportsXtraForm));
			this.fieldMachineName1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.BarManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.customersMenuBar = new DevExpress.XtraBars.Bar();
			this.printBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.exportXLSBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.Bar2 = new DevExpress.XtraBars.Bar();
			this.Bar3 = new DevExpress.XtraBars.Bar();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.SplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			this.quickReportsGridControl = new DevExpress.XtraGrid.GridControl();
			this.quickReportsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.reportNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.reportCodeNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.reportTypeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.filterReportGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.dateFilterGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.customerFilterGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.itemFilterGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.lotFilterGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.poFilterGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.machineFilterGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shiftFilterGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.bolFilterGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.dnFilterGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.destinationFilterGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.carrierFilterGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.vendorFilterGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.itemTypeFilterGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.outOfStockFilterGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.reportsXtraTabControl = new DevExpress.XtraTab.XtraTabControl();
			this.filterXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.previewCustoemrsXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.previewGridControl = new DevExpress.XtraGrid.GridControl();
			this.previewGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.nameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.contactNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.addressGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.cityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.stateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.postalGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.phoneGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.faxGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.emailGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.inactiveGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.previewProductionEntriesXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.previewProductionEntriesGridControl = new DevExpress.XtraGrid.GridControl();
			this.previewProductionEntriesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.productionDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.customerNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.itemNumberGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.itemDescriptionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.itemTypeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shiftGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.quantityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.poGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.lotGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.palletNumberGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.lpnNumberGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.expirationDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.expirationDateFormatGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.noteGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.previewLpnStatusXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.previewLpnStatusGridControl = new DevExpress.XtraGrid.GridControl();
			this.previewLpnStatusGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.lpnCustomerNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.fullLpnGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.lpnItemCodeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.lpnItemDescriptionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.lpnQuantityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.lpnProductionDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.lpnShippingDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.lpnShippingBolGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.previewCurrentRMInventoryXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.previewCurrentRMInventoryGridControl = new DevExpress.XtraGrid.GridControl();
			this.previewCurrentRMInventoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.rmInventoryCustomerNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.rmInventoryIemCodeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.rmInventoryItemDescriptionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.rmInventoryLocationGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.rmInventoryQtyOnHandGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.rmInventoryInactiveGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.rmInventoryItemIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.previewCurrentInventoryXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.refreshSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.outOfStockItemsCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.currentInventoryInactiveItemsCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.currentInventoryInactiveCustomersCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.previewCurrentInventoryGridControl = new DevExpress.XtraGrid.GridControl();
			this.previewCurrentInventoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.currentInventoryCustomerNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.currentInventoryItemCodeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.currentInventoryItemDescriptionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.currentInventoryItemTypeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.currentInventoryQuantityOnHandGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.currentInventoryInventoryByPalletsGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.currentInventoryUOMGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.currentInventoryLocationGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.previewLocationTransfersXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.previewLocationTransfersGridControl = new DevExpress.XtraGrid.GridControl();
			this.previewLocationTransfersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.locationTransfersDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.locationTransferFromLocationGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.locationTransferToLocationGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.locationTransferItemCodeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.locationTransferItemDescriptionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.locationTransferNumberGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.locationTransferItemLotGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.locationTransferExpirationDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.locationTransferQuantityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.locationTransferExpirationDateFormatGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.locationTransferPalletsGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.locationTransferUnitsGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.locationTransferCarrierGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.previewShiftScheduleXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.shiftScheduleGridControl = new DevExpress.XtraGrid.GridControl();
			this.shiftScheduleGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.shiftScheduleMachineNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shiftSchedulePeopleGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shiftScheduleOperatorGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shiftScheduleItemCodeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shiftScheduleItemDescriptionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shiftScheduleQuantityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shiftScheduleSchedByQtyGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shiftScheduleNoteGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shiftScheduleMustRunGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shiftSchedulePriorityLevelGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.refreshShiftScheduleSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.shiftScheduleShiftComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
			this.shiftScheduleDateDateEdit = new DevExpress.XtraEditors.DateEdit();
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.previewWeeklyProductionXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.weeklyProductionGridControl = new DevExpress.XtraGrid.GridControl();
			this.weeklyProductionGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.weeklyProductionProductionWeekGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.weeklyProductionItemCodeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.weeklyProductionItemDescriptionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.weeklyProductionCasesRequiredGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.weeklyProductionBagsRequiredGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.weeklyProductionMondayGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.weeklyProductionTuesdayGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.weeklyProductionWednesdayGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.weeklyProductionThursdayGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.weeklyProductionFridayGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.weeklyProductionSaturdayGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.weeklyProductionSundayGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.weeklyProductionTotalProducedWeeklyGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.weeklyProductionTotalProducedGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.weeklyProductionPercentageCompleteGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.previewProjBomAvailXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.lblNededBy = new DevExpress.XtraEditors.LabelControl();
			this.neededBy = new DevExpress.XtraEditors.DateEdit();
			this.ProjBomAvailGridControl = new DevExpress.XtraGrid.GridControl();
			this.ProjBomAvailGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.ProjBomAvailCustPOGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ProjBomAvailCustNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ProjBomAvailItemCodeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ProjBomAvailItemDescriptionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ProjBomAvailItemTypeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ProjBomAvailTotalAmtNeededGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ProjBomAvailLocalQtyGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ProjBomLocalShortageGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ProjBomAvailNonLocalQtyGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ProjBomAvailNonLocalPalletsQtyGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ProjBomAvailQtyOnHndGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ProjBomAvailQtyShortageGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.previewProductionBillingXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.previewProductionBillingGridControl = new DevExpress.XtraGrid.GridControl();
			this.previewProductionBillingGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.productionBillingDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.productionBillingCustomerGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.productionBillingItemCodeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.productionBillingItemDescriptionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.productionBillingItemTypeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.productionBillingShiftGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.productionBillingPOGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.productionBillingUOMGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.productionBillingQuantityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.productionBillingCasesGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.productionBillingPriceGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.previewBaggingXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.baggingReportPivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
			this.baggingReportXpView = new DevExpress.Xpo.XPView(this.components);
			this.fieldProductionDate1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldProductionShift1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldQuantity1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.reasonsPivotGridField = new DevExpress.XtraPivotGrid.PivotGridField();
			this.minutesPivotGridField = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldItemCode = new DevExpress.XtraPivotGrid.PivotGridField();
			this.exportSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)this.BarManager1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.SplitContainerControl1).BeginInit();
			this.SplitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.quickReportsGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.quickReportsGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.reportsXtraTabControl).BeginInit();
			this.reportsXtraTabControl.SuspendLayout();
			this.previewCustoemrsXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.previewGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.previewGridView).BeginInit();
			this.previewProductionEntriesXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.previewProductionEntriesGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.previewProductionEntriesGridView).BeginInit();
			this.previewLpnStatusXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.previewLpnStatusGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.previewLpnStatusGridView).BeginInit();
			this.previewCurrentRMInventoryXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.previewCurrentRMInventoryGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.previewCurrentRMInventoryGridView).BeginInit();
			this.previewCurrentInventoryXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.outOfStockItemsCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.currentInventoryInactiveItemsCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.currentInventoryInactiveCustomersCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.previewCurrentInventoryGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.previewCurrentInventoryGridView).BeginInit();
			this.previewLocationTransfersXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.previewLocationTransfersGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.previewLocationTransfersGridView).BeginInit();
			this.previewShiftScheduleXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.shiftScheduleGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shiftScheduleGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shiftScheduleShiftComboBoxEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shiftScheduleDateDateEdit.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shiftScheduleDateDateEdit.Properties).BeginInit();
			this.previewWeeklyProductionXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.weeklyProductionGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.weeklyProductionGridView).BeginInit();
			this.previewProjBomAvailXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.neededBy.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.neededBy.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.ProjBomAvailGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.ProjBomAvailGridView).BeginInit();
			this.previewProductionBillingXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.previewProductionBillingGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.previewProductionBillingGridView).BeginInit();
			this.previewBaggingXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.baggingReportPivotGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.baggingReportXpView).BeginInit();
			this.SuspendLayout();
			//
			//fieldMachineName1
			//
			this.fieldMachineName1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
			this.fieldMachineName1.AreaIndex = 0;
			this.fieldMachineName1.Caption = "Machine";
			this.fieldMachineName1.FieldName = "MachineName";
			this.fieldMachineName1.Name = "fieldMachineName1";
			//
			//BarManager1
			//
			this.BarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.customersMenuBar, this.Bar2, this.Bar3});
			this.BarManager1.DockControls.Add(this.barDockControlTop);
			this.BarManager1.DockControls.Add(this.barDockControlBottom);
			this.BarManager1.DockControls.Add(this.barDockControlLeft);
			this.BarManager1.DockControls.Add(this.barDockControlRight);
			this.BarManager1.Form = this;
			this.BarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.printBarButtonItem, this.exportXLSBarButtonItem});
			this.BarManager1.MainMenu = this.Bar2;
			this.BarManager1.MaxItemId = 2;
			this.BarManager1.StatusBar = this.Bar3;
			//
			//customersMenuBar
			//
			this.customersMenuBar.BarName = "Tools";
			this.customersMenuBar.DockCol = 0;
			this.customersMenuBar.DockRow = 0;
			this.customersMenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.customersMenuBar.FloatLocation = new System.Drawing.Point(375, 173);
			this.customersMenuBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.printBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.exportXLSBarButtonItem)
			});
			this.customersMenuBar.OptionsBar.UseWholeRow = true;
			this.customersMenuBar.Text = "Tools";
			//
			//printBarButtonItem
			//
			this.printBarButtonItem.Caption = "&Print";
			this.printBarButtonItem.Id = 0;
			this.printBarButtonItem.Name = "printBarButtonItem";
			//
			//exportXLSBarButtonItem
			//
			this.exportXLSBarButtonItem.Caption = "Export to &Excel";
			this.exportXLSBarButtonItem.Id = 1;
			this.exportXLSBarButtonItem.Name = "exportXLSBarButtonItem";
			//
			//Bar2
			//
			this.Bar2.BarName = "Main menu";
			this.Bar2.DockCol = 0;
			this.Bar2.DockRow = 1;
			this.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.Bar2.OptionsBar.MultiLine = true;
			this.Bar2.OptionsBar.UseWholeRow = true;
			this.Bar2.Text = "Main menu";
			this.Bar2.Visible = false;
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
			this.barDockControlTop.Size = new System.Drawing.Size(959, 49);
			//
			//barDockControlBottom
			//
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 661);
			this.barDockControlBottom.Manager = this.BarManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(959, 23);
			//
			//barDockControlLeft
			//
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 49);
			this.barDockControlLeft.Manager = this.BarManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 612);
			//
			//barDockControlRight
			//
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(959, 49);
			this.barDockControlRight.Manager = this.BarManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 612);
			//
			//SplitContainerControl1
			//
			this.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainerControl1.Location = new System.Drawing.Point(0, 49);
			this.SplitContainerControl1.Name = "SplitContainerControl1";
			this.SplitContainerControl1.Panel1.Controls.Add(this.quickReportsGridControl);
			this.SplitContainerControl1.Panel1.MinSize = 300;
			this.SplitContainerControl1.Panel1.Text = "Panel1";
			this.SplitContainerControl1.Panel2.Controls.Add(this.reportsXtraTabControl);
			this.SplitContainerControl1.Panel2.Text = "Panel2";
			this.SplitContainerControl1.Size = new System.Drawing.Size(959, 612);
			this.SplitContainerControl1.TabIndex = 4;
			this.SplitContainerControl1.Text = "SplitContainerControl1";
			//
			//quickReportsGridControl
			//
			this.quickReportsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.quickReportsGridControl.Location = new System.Drawing.Point(0, 0);
			this.quickReportsGridControl.MainView = this.quickReportsGridView;
			this.quickReportsGridControl.Name = "quickReportsGridControl";
			this.quickReportsGridControl.Size = new System.Drawing.Size(300, 612);
			this.quickReportsGridControl.TabIndex = 0;
			this.quickReportsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.quickReportsGridView});
			//
			//quickReportsGridView
			//
			this.quickReportsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.reportNameGridColumn, this.reportCodeNameGridColumn, this.reportTypeGridColumn, this.filterReportGridColumn, this.dateFilterGridColumn, this.customerFilterGridColumn, this.itemFilterGridColumn, this.lotFilterGridColumn, this.poFilterGridColumn, this.machineFilterGridColumn, this.shiftFilterGridColumn, this.bolFilterGridColumn, this.dnFilterGridColumn, this.destinationFilterGridColumn, this.carrierFilterGridColumn, this.vendorFilterGridColumn, this.itemTypeFilterGridColumn, this.outOfStockFilterGridColumn});
			this.quickReportsGridView.GridControl = this.quickReportsGridControl;
			this.quickReportsGridView.Name = "quickReportsGridView";
			this.quickReportsGridView.OptionsBehavior.Editable = false;
			this.quickReportsGridView.OptionsView.ShowGroupPanel = false;
			this.quickReportsGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.reportNameGridColumn, DevExpress.Data.ColumnSortOrder.Ascending)});
			//
			//reportNameGridColumn
			//
			this.reportNameGridColumn.Caption = "Report Name";
			this.reportNameGridColumn.Name = "reportNameGridColumn";
			this.reportNameGridColumn.Visible = true;
			this.reportNameGridColumn.VisibleIndex = 0;
			//
			//reportCodeNameGridColumn
			//
			this.reportCodeNameGridColumn.Caption = "GridColumn1";
			this.reportCodeNameGridColumn.Name = "reportCodeNameGridColumn";
			//
			//reportTypeGridColumn
			//
			this.reportTypeGridColumn.Caption = "GridColumn1";
			this.reportTypeGridColumn.Name = "reportTypeGridColumn";
			//
			//filterReportGridColumn
			//
			this.filterReportGridColumn.Caption = "GridColumn1";
			this.filterReportGridColumn.Name = "filterReportGridColumn";
			//
			//dateFilterGridColumn
			//
			this.dateFilterGridColumn.Caption = "GridColumn1";
			this.dateFilterGridColumn.Name = "dateFilterGridColumn";
			//
			//customerFilterGridColumn
			//
			this.customerFilterGridColumn.Caption = "GridColumn1";
			this.customerFilterGridColumn.Name = "customerFilterGridColumn";
			//
			//itemFilterGridColumn
			//
			this.itemFilterGridColumn.Caption = "GridColumn1";
			this.itemFilterGridColumn.Name = "itemFilterGridColumn";
			//
			//lotFilterGridColumn
			//
			this.lotFilterGridColumn.Caption = "GridColumn1";
			this.lotFilterGridColumn.Name = "lotFilterGridColumn";
			//
			//poFilterGridColumn
			//
			this.poFilterGridColumn.Caption = "GridColumn1";
			this.poFilterGridColumn.Name = "poFilterGridColumn";
			//
			//machineFilterGridColumn
			//
			this.machineFilterGridColumn.Caption = "GridColumn1";
			this.machineFilterGridColumn.Name = "machineFilterGridColumn";
			//
			//shiftFilterGridColumn
			//
			this.shiftFilterGridColumn.Caption = "GridColumn1";
			this.shiftFilterGridColumn.Name = "shiftFilterGridColumn";
			//
			//bolFilterGridColumn
			//
			this.bolFilterGridColumn.Caption = "GridColumn1";
			this.bolFilterGridColumn.Name = "bolFilterGridColumn";
			//
			//dnFilterGridColumn
			//
			this.dnFilterGridColumn.Caption = "GridColumn1";
			this.dnFilterGridColumn.Name = "dnFilterGridColumn";
			//
			//destinationFilterGridColumn
			//
			this.destinationFilterGridColumn.Caption = "GridColumn1";
			this.destinationFilterGridColumn.Name = "destinationFilterGridColumn";
			//
			//carrierFilterGridColumn
			//
			this.carrierFilterGridColumn.Caption = "GridColumn1";
			this.carrierFilterGridColumn.Name = "carrierFilterGridColumn";
			//
			//vendorFilterGridColumn
			//
			this.vendorFilterGridColumn.Caption = "GridColumn1";
			this.vendorFilterGridColumn.Name = "vendorFilterGridColumn";
			//
			//itemTypeFilterGridColumn
			//
			this.itemTypeFilterGridColumn.Caption = "GridColumn1";
			this.itemTypeFilterGridColumn.Name = "itemTypeFilterGridColumn";
			//
			//outOfStockFilterGridColumn
			//
			this.outOfStockFilterGridColumn.Caption = "GridColumn1";
			this.outOfStockFilterGridColumn.Name = "outOfStockFilterGridColumn";
			//
			//reportsXtraTabControl
			//
			this.reportsXtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.reportsXtraTabControl.Location = new System.Drawing.Point(0, 0);
			this.reportsXtraTabControl.Name = "reportsXtraTabControl";
			this.reportsXtraTabControl.SelectedTabPage = this.filterXtraTabPage;
			this.reportsXtraTabControl.Size = new System.Drawing.Size(654, 612);
			this.reportsXtraTabControl.TabIndex = 0;
			this.reportsXtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {this.filterXtraTabPage, this.previewCustoemrsXtraTabPage, this.previewProductionEntriesXtraTabPage, this.previewLpnStatusXtraTabPage, this.previewCurrentRMInventoryXtraTabPage, this.previewCurrentInventoryXtraTabPage, this.previewLocationTransfersXtraTabPage, this.previewShiftScheduleXtraTabPage, this.previewWeeklyProductionXtraTabPage, this.previewProjBomAvailXtraTabPage, this.previewProductionBillingXtraTabPage, this.previewBaggingXtraTabPage});
			this.reportsXtraTabControl.Visible = false;
			//
			//filterXtraTabPage
			//
			this.filterXtraTabPage.Name = "filterXtraTabPage";
			this.filterXtraTabPage.Size = new System.Drawing.Size(648, 584);
			this.filterXtraTabPage.Text = "Filters";
			//
			//previewCustoemrsXtraTabPage
			//
			this.previewCustoemrsXtraTabPage.Controls.Add(this.previewGridControl);
			this.previewCustoemrsXtraTabPage.Name = "previewCustoemrsXtraTabPage";
			this.previewCustoemrsXtraTabPage.Size = new System.Drawing.Size(648, 584);
			this.previewCustoemrsXtraTabPage.Text = "Preview";
			//
			//previewGridControl
			//
			this.previewGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.previewGridControl.Location = new System.Drawing.Point(0, 0);
			this.previewGridControl.MainView = this.previewGridView;
			this.previewGridControl.Name = "previewGridControl";
			this.previewGridControl.Size = new System.Drawing.Size(648, 584);
			this.previewGridControl.TabIndex = 0;
			this.previewGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.previewGridView});
			//
			//previewGridView
			//
			this.previewGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.nameGridColumn, this.contactNameGridColumn, this.addressGridColumn, this.cityGridColumn, this.stateGridColumn, this.postalGridColumn, this.phoneGridColumn, this.faxGridColumn, this.emailGridColumn, this.inactiveGridColumn});
			this.previewGridView.GridControl = this.previewGridControl;
			this.previewGridView.Name = "previewGridView";
			this.previewGridView.OptionsBehavior.Editable = false;
			this.previewGridView.OptionsView.ShowAutoFilterRow = true;
			this.previewGridView.OptionsView.ShowDetailButtons = false;
			//
			//nameGridColumn
			//
			this.nameGridColumn.Caption = "Name";
			this.nameGridColumn.Name = "nameGridColumn";
			this.nameGridColumn.Visible = true;
			this.nameGridColumn.VisibleIndex = 0;
			//
			//contactNameGridColumn
			//
			this.contactNameGridColumn.Caption = "Contact Name";
			this.contactNameGridColumn.Name = "contactNameGridColumn";
			this.contactNameGridColumn.Visible = true;
			this.contactNameGridColumn.VisibleIndex = 1;
			//
			//addressGridColumn
			//
			this.addressGridColumn.Caption = "Address";
			this.addressGridColumn.Name = "addressGridColumn";
			this.addressGridColumn.Visible = true;
			this.addressGridColumn.VisibleIndex = 2;
			//
			//cityGridColumn
			//
			this.cityGridColumn.Caption = "City";
			this.cityGridColumn.Name = "cityGridColumn";
			this.cityGridColumn.Visible = true;
			this.cityGridColumn.VisibleIndex = 3;
			//
			//stateGridColumn
			//
			this.stateGridColumn.Caption = "State";
			this.stateGridColumn.Name = "stateGridColumn";
			this.stateGridColumn.Visible = true;
			this.stateGridColumn.VisibleIndex = 4;
			//
			//postalGridColumn
			//
			this.postalGridColumn.Caption = "Zip Code";
			this.postalGridColumn.Name = "postalGridColumn";
			this.postalGridColumn.Visible = true;
			this.postalGridColumn.VisibleIndex = 5;
			//
			//phoneGridColumn
			//
			this.phoneGridColumn.Caption = "Phone";
			this.phoneGridColumn.Name = "phoneGridColumn";
			this.phoneGridColumn.Visible = true;
			this.phoneGridColumn.VisibleIndex = 6;
			//
			//faxGridColumn
			//
			this.faxGridColumn.Caption = "Fax";
			this.faxGridColumn.Name = "faxGridColumn";
			this.faxGridColumn.Visible = true;
			this.faxGridColumn.VisibleIndex = 7;
			//
			//emailGridColumn
			//
			this.emailGridColumn.Caption = "Email";
			this.emailGridColumn.Name = "emailGridColumn";
			this.emailGridColumn.Visible = true;
			this.emailGridColumn.VisibleIndex = 8;
			//
			//inactiveGridColumn
			//
			this.inactiveGridColumn.Caption = "Inactive";
			this.inactiveGridColumn.Name = "inactiveGridColumn";
			this.inactiveGridColumn.Visible = true;
			this.inactiveGridColumn.VisibleIndex = 9;
			//
			//previewProductionEntriesXtraTabPage
			//
			this.previewProductionEntriesXtraTabPage.Controls.Add(this.previewProductionEntriesGridControl);
			this.previewProductionEntriesXtraTabPage.Name = "previewProductionEntriesXtraTabPage";
			this.previewProductionEntriesXtraTabPage.Size = new System.Drawing.Size(648, 584);
			this.previewProductionEntriesXtraTabPage.Text = "Preview Production";
			//
			//previewProductionEntriesGridControl
			//
			this.previewProductionEntriesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.previewProductionEntriesGridControl.Location = new System.Drawing.Point(0, 0);
			this.previewProductionEntriesGridControl.MainView = this.previewProductionEntriesGridView;
			this.previewProductionEntriesGridControl.Name = "previewProductionEntriesGridControl";
			this.previewProductionEntriesGridControl.Size = new System.Drawing.Size(648, 584);
			this.previewProductionEntriesGridControl.TabIndex = 1;
			this.previewProductionEntriesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.previewProductionEntriesGridView});
			//
			//previewProductionEntriesGridView
			//
			this.previewProductionEntriesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.productionDateGridColumn, this.customerNameGridColumn, this.itemNumberGridColumn, this.itemDescriptionGridColumn, this.itemTypeGridColumn, this.shiftGridColumn, this.quantityGridColumn, this.poGridColumn, this.lotGridColumn, this.palletNumberGridColumn, this.lpnNumberGridColumn, this.expirationDateGridColumn, this.expirationDateFormatGridColumn, this.noteGridColumn});
			this.previewProductionEntriesGridView.GridControl = this.previewProductionEntriesGridControl;
			this.previewProductionEntriesGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", this.quantityGridColumn, "{0:#,##0.######}")});
			this.previewProductionEntriesGridView.Name = "previewProductionEntriesGridView";
			this.previewProductionEntriesGridView.OptionsBehavior.Editable = false;
			this.previewProductionEntriesGridView.OptionsView.ShowAutoFilterRow = true;
			this.previewProductionEntriesGridView.OptionsView.ShowDetailButtons = false;
			this.previewProductionEntriesGridView.OptionsView.ShowFooter = true;
			//
			//productionDateGridColumn
			//
			this.productionDateGridColumn.AppearanceCell.Options.UseTextOptions = true;
			this.productionDateGridColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.productionDateGridColumn.Caption = "Production Date";
			this.productionDateGridColumn.DisplayFormat.FormatString = "d";
			this.productionDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.productionDateGridColumn.Name = "productionDateGridColumn";
			this.productionDateGridColumn.Visible = true;
			this.productionDateGridColumn.VisibleIndex = 0;
			//
			//customerNameGridColumn
			//
			this.customerNameGridColumn.Caption = "Customer Name";
			this.customerNameGridColumn.Name = "customerNameGridColumn";
			this.customerNameGridColumn.Visible = true;
			this.customerNameGridColumn.VisibleIndex = 1;
			//
			//itemNumberGridColumn
			//
			this.itemNumberGridColumn.Caption = "Item #";
			this.itemNumberGridColumn.Name = "itemNumberGridColumn";
			this.itemNumberGridColumn.Visible = true;
			this.itemNumberGridColumn.VisibleIndex = 2;
			//
			//itemDescriptionGridColumn
			//
			this.itemDescriptionGridColumn.Caption = "Item Description";
			this.itemDescriptionGridColumn.Name = "itemDescriptionGridColumn";
			this.itemDescriptionGridColumn.Visible = true;
			this.itemDescriptionGridColumn.VisibleIndex = 3;
			//
			//itemTypeGridColumn
			//
			this.itemTypeGridColumn.Caption = "Item Type";
			this.itemTypeGridColumn.Name = "itemTypeGridColumn";
			this.itemTypeGridColumn.Visible = true;
			this.itemTypeGridColumn.VisibleIndex = 4;
			//
			//shiftGridColumn
			//
			this.shiftGridColumn.Caption = "Shift";
			this.shiftGridColumn.Name = "shiftGridColumn";
			this.shiftGridColumn.Visible = true;
			this.shiftGridColumn.VisibleIndex = 5;
			//
			//quantityGridColumn
			//
			this.quantityGridColumn.AppearanceCell.Options.UseTextOptions = true;
			this.quantityGridColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.quantityGridColumn.Caption = "Quantity";
			this.quantityGridColumn.Name = "quantityGridColumn";
			this.quantityGridColumn.Visible = true;
			this.quantityGridColumn.VisibleIndex = 6;
			//
			//poGridColumn
			//
			this.poGridColumn.Caption = "PO #";
			this.poGridColumn.Name = "poGridColumn";
			this.poGridColumn.Visible = true;
			this.poGridColumn.VisibleIndex = 7;
			//
			//lotGridColumn
			//
			this.lotGridColumn.Caption = "Lot #";
			this.lotGridColumn.Name = "lotGridColumn";
			this.lotGridColumn.Visible = true;
			this.lotGridColumn.VisibleIndex = 8;
			//
			//palletNumberGridColumn
			//
			this.palletNumberGridColumn.AppearanceCell.Options.UseTextOptions = true;
			this.palletNumberGridColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.palletNumberGridColumn.Caption = "Pallet #";
			this.palletNumberGridColumn.Name = "palletNumberGridColumn";
			this.palletNumberGridColumn.Visible = true;
			this.palletNumberGridColumn.VisibleIndex = 10;
			//
			//lpnNumberGridColumn
			//
			this.lpnNumberGridColumn.Caption = "LPN #";
			this.lpnNumberGridColumn.Name = "lpnNumberGridColumn";
			this.lpnNumberGridColumn.Visible = true;
			this.lpnNumberGridColumn.VisibleIndex = 11;
			//
			//expirationDateGridColumn
			//
			this.expirationDateGridColumn.Caption = "Expiration Date";
			this.expirationDateGridColumn.Name = "expirationDateGridColumn";
			this.expirationDateGridColumn.Visible = true;
			this.expirationDateGridColumn.VisibleIndex = 9;
			//
			//expirationDateFormatGridColumn
			//
			this.expirationDateFormatGridColumn.Caption = "GridColumn1";
			this.expirationDateFormatGridColumn.Name = "expirationDateFormatGridColumn";
			this.expirationDateFormatGridColumn.OptionsColumn.AllowShowHide = false;
			this.expirationDateFormatGridColumn.OptionsColumn.ShowInCustomizationForm = false;
			//
			//noteGridColumn
			//
			this.noteGridColumn.Caption = "Note";
			this.noteGridColumn.Name = "noteGridColumn";
			this.noteGridColumn.Visible = true;
			this.noteGridColumn.VisibleIndex = 12;
			//
			//previewLpnStatusXtraTabPage
			//
			this.previewLpnStatusXtraTabPage.Controls.Add(this.previewLpnStatusGridControl);
			this.previewLpnStatusXtraTabPage.Name = "previewLpnStatusXtraTabPage";
			this.previewLpnStatusXtraTabPage.Size = new System.Drawing.Size(648, 584);
			this.previewLpnStatusXtraTabPage.Text = "Preview LPN";
			//
			//previewLpnStatusGridControl
			//
			this.previewLpnStatusGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.previewLpnStatusGridControl.Location = new System.Drawing.Point(0, 0);
			this.previewLpnStatusGridControl.MainView = this.previewLpnStatusGridView;
			this.previewLpnStatusGridControl.Name = "previewLpnStatusGridControl";
			this.previewLpnStatusGridControl.Size = new System.Drawing.Size(648, 584);
			this.previewLpnStatusGridControl.TabIndex = 2;
			this.previewLpnStatusGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.previewLpnStatusGridView});
			//
			//previewLpnStatusGridView
			//
			this.previewLpnStatusGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.lpnCustomerNameGridColumn, this.fullLpnGridColumn, this.lpnItemCodeGridColumn, this.lpnItemDescriptionGridColumn, this.lpnQuantityGridColumn, this.lpnProductionDateGridColumn, this.lpnShippingDateGridColumn, this.lpnShippingBolGridColumn});
			this.previewLpnStatusGridView.GridControl = this.previewLpnStatusGridControl;
			this.previewLpnStatusGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", this.lpnQuantityGridColumn, "{0:#,##0.######}")});
			this.previewLpnStatusGridView.Name = "previewLpnStatusGridView";
			this.previewLpnStatusGridView.OptionsBehavior.Editable = false;
			this.previewLpnStatusGridView.OptionsView.ShowAutoFilterRow = true;
			this.previewLpnStatusGridView.OptionsView.ShowFooter = true;
			//
			//lpnCustomerNameGridColumn
			//
			this.lpnCustomerNameGridColumn.Caption = "Customer Name";
			this.lpnCustomerNameGridColumn.Name = "lpnCustomerNameGridColumn";
			this.lpnCustomerNameGridColumn.Visible = true;
			this.lpnCustomerNameGridColumn.VisibleIndex = 0;
			//
			//fullLpnGridColumn
			//
			this.fullLpnGridColumn.Caption = "Full LPN #";
			this.fullLpnGridColumn.Name = "fullLpnGridColumn";
			this.fullLpnGridColumn.Visible = true;
			this.fullLpnGridColumn.VisibleIndex = 1;
			//
			//lpnItemCodeGridColumn
			//
			this.lpnItemCodeGridColumn.Caption = "Item #";
			this.lpnItemCodeGridColumn.Name = "lpnItemCodeGridColumn";
			this.lpnItemCodeGridColumn.Visible = true;
			this.lpnItemCodeGridColumn.VisibleIndex = 2;
			//
			//lpnItemDescriptionGridColumn
			//
			this.lpnItemDescriptionGridColumn.Caption = "Item Description";
			this.lpnItemDescriptionGridColumn.Name = "lpnItemDescriptionGridColumn";
			this.lpnItemDescriptionGridColumn.Visible = true;
			this.lpnItemDescriptionGridColumn.VisibleIndex = 3;
			//
			//lpnQuantityGridColumn
			//
			this.lpnQuantityGridColumn.AppearanceCell.Options.UseTextOptions = true;
			this.lpnQuantityGridColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.lpnQuantityGridColumn.Caption = "Quantity";
			this.lpnQuantityGridColumn.Name = "lpnQuantityGridColumn";
			this.lpnQuantityGridColumn.Visible = true;
			this.lpnQuantityGridColumn.VisibleIndex = 4;
			//
			//lpnProductionDateGridColumn
			//
			this.lpnProductionDateGridColumn.AppearanceCell.Options.UseTextOptions = true;
			this.lpnProductionDateGridColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.lpnProductionDateGridColumn.Caption = "Production Date";
			this.lpnProductionDateGridColumn.DisplayFormat.FormatString = "d";
			this.lpnProductionDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.lpnProductionDateGridColumn.Name = "lpnProductionDateGridColumn";
			this.lpnProductionDateGridColumn.Visible = true;
			this.lpnProductionDateGridColumn.VisibleIndex = 5;
			//
			//lpnShippingDateGridColumn
			//
			this.lpnShippingDateGridColumn.Caption = "Shipping Date";
			this.lpnShippingDateGridColumn.DisplayFormat.FormatString = "d";
			this.lpnShippingDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.lpnShippingDateGridColumn.Name = "lpnShippingDateGridColumn";
			this.lpnShippingDateGridColumn.Visible = true;
			this.lpnShippingDateGridColumn.VisibleIndex = 6;
			//
			//lpnShippingBolGridColumn
			//
			this.lpnShippingBolGridColumn.Caption = "BOL #";
			this.lpnShippingBolGridColumn.Name = "lpnShippingBolGridColumn";
			this.lpnShippingBolGridColumn.Visible = true;
			this.lpnShippingBolGridColumn.VisibleIndex = 7;
			//
			//previewCurrentRMInventoryXtraTabPage
			//
			this.previewCurrentRMInventoryXtraTabPage.Controls.Add(this.previewCurrentRMInventoryGridControl);
			this.previewCurrentRMInventoryXtraTabPage.Name = "previewCurrentRMInventoryXtraTabPage";
			this.previewCurrentRMInventoryXtraTabPage.Size = new System.Drawing.Size(648, 584);
			this.previewCurrentRMInventoryXtraTabPage.Text = "Preview Current RM Inventory";
			//
			//previewCurrentRMInventoryGridControl
			//
			this.previewCurrentRMInventoryGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.previewCurrentRMInventoryGridControl.Location = new System.Drawing.Point(0, 0);
			this.previewCurrentRMInventoryGridControl.MainView = this.previewCurrentRMInventoryGridView;
			this.previewCurrentRMInventoryGridControl.MenuManager = this.BarManager1;
			this.previewCurrentRMInventoryGridControl.Name = "previewCurrentRMInventoryGridControl";
			this.previewCurrentRMInventoryGridControl.Size = new System.Drawing.Size(648, 584);
			this.previewCurrentRMInventoryGridControl.TabIndex = 0;
			this.previewCurrentRMInventoryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.previewCurrentRMInventoryGridView});
			//
			//previewCurrentRMInventoryGridView
			//
			this.previewCurrentRMInventoryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.rmInventoryCustomerNameGridColumn, this.rmInventoryIemCodeGridColumn, this.rmInventoryItemDescriptionGridColumn, this.rmInventoryLocationGridColumn, this.rmInventoryQtyOnHandGridColumn, this.rmInventoryInactiveGridColumn, this.rmInventoryItemIDGridColumn});
			this.previewCurrentRMInventoryGridView.GridControl = this.previewCurrentRMInventoryGridControl;
			this.previewCurrentRMInventoryGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QuantityOnHand", this.rmInventoryQtyOnHandGridColumn, "{0:#,##0.######}")});
			this.previewCurrentRMInventoryGridView.Name = "previewCurrentRMInventoryGridView";
			this.previewCurrentRMInventoryGridView.OptionsBehavior.Editable = false;
			this.previewCurrentRMInventoryGridView.OptionsView.ShowAutoFilterRow = true;
			this.previewCurrentRMInventoryGridView.OptionsView.ShowDetailButtons = false;
			this.previewCurrentRMInventoryGridView.OptionsView.ShowFooter = true;
			//
			//rmInventoryCustomerNameGridColumn
			//
			this.rmInventoryCustomerNameGridColumn.Caption = "Customer Name";
			this.rmInventoryCustomerNameGridColumn.Name = "rmInventoryCustomerNameGridColumn";
			this.rmInventoryCustomerNameGridColumn.Visible = true;
			this.rmInventoryCustomerNameGridColumn.VisibleIndex = 0;
			//
			//rmInventoryIemCodeGridColumn
			//
			this.rmInventoryIemCodeGridColumn.Caption = "Item Code";
			this.rmInventoryIemCodeGridColumn.Name = "rmInventoryIemCodeGridColumn";
			this.rmInventoryIemCodeGridColumn.Visible = true;
			this.rmInventoryIemCodeGridColumn.VisibleIndex = 1;
			//
			//rmInventoryItemDescriptionGridColumn
			//
			this.rmInventoryItemDescriptionGridColumn.Caption = "Item Description";
			this.rmInventoryItemDescriptionGridColumn.Name = "rmInventoryItemDescriptionGridColumn";
			this.rmInventoryItemDescriptionGridColumn.Visible = true;
			this.rmInventoryItemDescriptionGridColumn.VisibleIndex = 2;
			//
			//rmInventoryLocationGridColumn
			//
			this.rmInventoryLocationGridColumn.Caption = "Location";
			this.rmInventoryLocationGridColumn.Name = "rmInventoryLocationGridColumn";
			this.rmInventoryLocationGridColumn.Visible = true;
			this.rmInventoryLocationGridColumn.VisibleIndex = 3;
			//
			//rmInventoryQtyOnHandGridColumn
			//
			this.rmInventoryQtyOnHandGridColumn.Caption = "Quantity On Hand";
			this.rmInventoryQtyOnHandGridColumn.DisplayFormat.FormatString = "{0:#,##0.00####}";
			this.rmInventoryQtyOnHandGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.rmInventoryQtyOnHandGridColumn.Name = "rmInventoryQtyOnHandGridColumn";
			this.rmInventoryQtyOnHandGridColumn.Visible = true;
			this.rmInventoryQtyOnHandGridColumn.VisibleIndex = 4;
			//
			//rmInventoryInactiveGridColumn
			//
			this.rmInventoryInactiveGridColumn.Caption = "Inactive";
			this.rmInventoryInactiveGridColumn.Name = "rmInventoryInactiveGridColumn";
			//
			//rmInventoryItemIDGridColumn
			//
			this.rmInventoryItemIDGridColumn.Caption = "Item ID";
			this.rmInventoryItemIDGridColumn.Name = "rmInventoryItemIDGridColumn";
			//
			//previewCurrentInventoryXtraTabPage
			//
			this.previewCurrentInventoryXtraTabPage.Controls.Add(this.refreshSimpleButton);
			this.previewCurrentInventoryXtraTabPage.Controls.Add(this.outOfStockItemsCheckEdit);
			this.previewCurrentInventoryXtraTabPage.Controls.Add(this.currentInventoryInactiveItemsCheckEdit);
			this.previewCurrentInventoryXtraTabPage.Controls.Add(this.currentInventoryInactiveCustomersCheckEdit);
			this.previewCurrentInventoryXtraTabPage.Controls.Add(this.LabelControl1);
			this.previewCurrentInventoryXtraTabPage.Controls.Add(this.previewCurrentInventoryGridControl);
			this.previewCurrentInventoryXtraTabPage.Name = "previewCurrentInventoryXtraTabPage";
			this.previewCurrentInventoryXtraTabPage.Size = new System.Drawing.Size(648, 584);
			this.previewCurrentInventoryXtraTabPage.Text = "Preview Current Inventory";
			//
			//refreshSimpleButton
			//
			this.refreshSimpleButton.Location = new System.Drawing.Point(472, 4);
			this.refreshSimpleButton.Name = "refreshSimpleButton";
			this.refreshSimpleButton.Size = new System.Drawing.Size(107, 23);
			this.refreshSimpleButton.TabIndex = 5;
			this.refreshSimpleButton.Text = "Refresh";
			//
			//outOfStockItemsCheckEdit
			//
			this.outOfStockItemsCheckEdit.Location = new System.Drawing.Point(332, 9);
			this.outOfStockItemsCheckEdit.MenuManager = this.BarManager1;
			this.outOfStockItemsCheckEdit.Name = "outOfStockItemsCheckEdit";
			this.outOfStockItemsCheckEdit.Properties.Caption = "Out Of Stock Items";
			this.outOfStockItemsCheckEdit.Size = new System.Drawing.Size(133, 19);
			this.outOfStockItemsCheckEdit.TabIndex = 4;
			//
			//currentInventoryInactiveItemsCheckEdit
			//
			this.currentInventoryInactiveItemsCheckEdit.Location = new System.Drawing.Point(218, 9);
			this.currentInventoryInactiveItemsCheckEdit.MenuManager = this.BarManager1;
			this.currentInventoryInactiveItemsCheckEdit.Name = "currentInventoryInactiveItemsCheckEdit";
			this.currentInventoryInactiveItemsCheckEdit.Properties.Caption = "Inactive Items";
			this.currentInventoryInactiveItemsCheckEdit.Size = new System.Drawing.Size(107, 19);
			this.currentInventoryInactiveItemsCheckEdit.TabIndex = 3;
			//
			//currentInventoryInactiveCustomersCheckEdit
			//
			this.currentInventoryInactiveCustomersCheckEdit.Location = new System.Drawing.Point(86, 9);
			this.currentInventoryInactiveCustomersCheckEdit.MenuManager = this.BarManager1;
			this.currentInventoryInactiveCustomersCheckEdit.Name = "currentInventoryInactiveCustomersCheckEdit";
			this.currentInventoryInactiveCustomersCheckEdit.Properties.Caption = "Inactive Customers";
			this.currentInventoryInactiveCustomersCheckEdit.Size = new System.Drawing.Size(125, 19);
			this.currentInventoryInactiveCustomersCheckEdit.TabIndex = 2;
			//
			//LabelControl1
			//
			this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.0F, System.Drawing.FontStyle.Bold);
			this.LabelControl1.Appearance.Options.UseFont = true;
			this.LabelControl1.Location = new System.Drawing.Point(18, 12);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(52, 16);
			this.LabelControl1.TabIndex = 1;
			this.LabelControl1.Text = "Include:";
			//
			//previewCurrentInventoryGridControl
			//
			this.previewCurrentInventoryGridControl.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.previewCurrentInventoryGridControl.Location = new System.Drawing.Point(0, 34);
			this.previewCurrentInventoryGridControl.MainView = this.previewCurrentInventoryGridView;
			this.previewCurrentInventoryGridControl.MenuManager = this.BarManager1;
			this.previewCurrentInventoryGridControl.Name = "previewCurrentInventoryGridControl";
			this.previewCurrentInventoryGridControl.Size = new System.Drawing.Size(648, 550);
			this.previewCurrentInventoryGridControl.TabIndex = 0;
			this.previewCurrentInventoryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.previewCurrentInventoryGridView});
			//
			//previewCurrentInventoryGridView
			//
			this.previewCurrentInventoryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.currentInventoryCustomerNameGridColumn, this.currentInventoryItemCodeGridColumn, this.currentInventoryItemDescriptionGridColumn, this.currentInventoryItemTypeGridColumn, this.currentInventoryQuantityOnHandGridColumn, this.currentInventoryInventoryByPalletsGridColumn, this.currentInventoryUOMGridColumn, this.currentInventoryLocationGridColumn});
			this.previewCurrentInventoryGridView.GridControl = this.previewCurrentInventoryGridControl;
			this.previewCurrentInventoryGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QuantityOnHand", this.currentInventoryQuantityOnHandGridColumn, "{0:#,##0.######}")});
			this.previewCurrentInventoryGridView.Name = "previewCurrentInventoryGridView";
			this.previewCurrentInventoryGridView.OptionsBehavior.Editable = false;
			this.previewCurrentInventoryGridView.OptionsView.ShowAutoFilterRow = true;
			this.previewCurrentInventoryGridView.OptionsView.ShowDetailButtons = false;
			this.previewCurrentInventoryGridView.OptionsView.ShowFooter = true;
			//
			//currentInventoryCustomerNameGridColumn
			//
			this.currentInventoryCustomerNameGridColumn.Caption = "Customer Name";
			this.currentInventoryCustomerNameGridColumn.Name = "currentInventoryCustomerNameGridColumn";
			this.currentInventoryCustomerNameGridColumn.Visible = true;
			this.currentInventoryCustomerNameGridColumn.VisibleIndex = 0;
			//
			//currentInventoryItemCodeGridColumn
			//
			this.currentInventoryItemCodeGridColumn.Caption = "Item Code";
			this.currentInventoryItemCodeGridColumn.Name = "currentInventoryItemCodeGridColumn";
			this.currentInventoryItemCodeGridColumn.Visible = true;
			this.currentInventoryItemCodeGridColumn.VisibleIndex = 1;
			//
			//currentInventoryItemDescriptionGridColumn
			//
			this.currentInventoryItemDescriptionGridColumn.Caption = "Item Description";
			this.currentInventoryItemDescriptionGridColumn.Name = "currentInventoryItemDescriptionGridColumn";
			this.currentInventoryItemDescriptionGridColumn.Visible = true;
			this.currentInventoryItemDescriptionGridColumn.VisibleIndex = 2;
			//
			//currentInventoryItemTypeGridColumn
			//
			this.currentInventoryItemTypeGridColumn.Caption = "Item Type";
			this.currentInventoryItemTypeGridColumn.Name = "currentInventoryItemTypeGridColumn";
			this.currentInventoryItemTypeGridColumn.Visible = true;
			this.currentInventoryItemTypeGridColumn.VisibleIndex = 3;
			//
			//currentInventoryQuantityOnHandGridColumn
			//
			this.currentInventoryQuantityOnHandGridColumn.Caption = "Quantity On Hand";
			this.currentInventoryQuantityOnHandGridColumn.DisplayFormat.FormatString = "{0:#,##0.00####}";
			this.currentInventoryQuantityOnHandGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.currentInventoryQuantityOnHandGridColumn.Name = "currentInventoryQuantityOnHandGridColumn";
			this.currentInventoryQuantityOnHandGridColumn.Visible = true;
			this.currentInventoryQuantityOnHandGridColumn.VisibleIndex = 5;
			//
			//currentInventoryInventoryByPalletsGridColumn
			//
			this.currentInventoryInventoryByPalletsGridColumn.Caption = "Inventory By Pallets";
			this.currentInventoryInventoryByPalletsGridColumn.DisplayFormat.FormatString = "{0:#,##0.00####}";
			this.currentInventoryInventoryByPalletsGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.currentInventoryInventoryByPalletsGridColumn.GroupFormat.FormatString = "{0:#,##0.00####}";
			this.currentInventoryInventoryByPalletsGridColumn.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.currentInventoryInventoryByPalletsGridColumn.Name = "currentInventoryInventoryByPalletsGridColumn";
			this.currentInventoryInventoryByPalletsGridColumn.Visible = true;
			this.currentInventoryInventoryByPalletsGridColumn.VisibleIndex = 7;
			//
			//currentInventoryUOMGridColumn
			//
			this.currentInventoryUOMGridColumn.Caption = "UOM";
			this.currentInventoryUOMGridColumn.Name = "currentInventoryUOMGridColumn";
			this.currentInventoryUOMGridColumn.Visible = true;
			this.currentInventoryUOMGridColumn.VisibleIndex = 6;
			//
			//currentInventoryLocationGridColumn
			//
			this.currentInventoryLocationGridColumn.Caption = "Location";
			this.currentInventoryLocationGridColumn.Name = "currentInventoryLocationGridColumn";
			this.currentInventoryLocationGridColumn.Visible = true;
			this.currentInventoryLocationGridColumn.VisibleIndex = 4;
			//
			//previewLocationTransfersXtraTabPage
			//
			this.previewLocationTransfersXtraTabPage.Controls.Add(this.previewLocationTransfersGridControl);
			this.previewLocationTransfersXtraTabPage.Name = "previewLocationTransfersXtraTabPage";
			this.previewLocationTransfersXtraTabPage.Size = new System.Drawing.Size(648, 584);
			this.previewLocationTransfersXtraTabPage.Text = "Preview Location Transfers";
			//
			//previewLocationTransfersGridControl
			//
			this.previewLocationTransfersGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.previewLocationTransfersGridControl.Location = new System.Drawing.Point(0, 0);
			this.previewLocationTransfersGridControl.MainView = this.previewLocationTransfersGridView;
			this.previewLocationTransfersGridControl.MenuManager = this.BarManager1;
			this.previewLocationTransfersGridControl.Name = "previewLocationTransfersGridControl";
			this.previewLocationTransfersGridControl.Size = new System.Drawing.Size(648, 584);
			this.previewLocationTransfersGridControl.TabIndex = 0;
			this.previewLocationTransfersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.previewLocationTransfersGridView});
			//
			//previewLocationTransfersGridView
			//
			this.previewLocationTransfersGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.locationTransfersDateGridColumn, this.locationTransferFromLocationGridColumn, this.locationTransferToLocationGridColumn, this.locationTransferItemCodeGridColumn, this.locationTransferItemDescriptionGridColumn, this.locationTransferNumberGridColumn, this.locationTransferItemLotGridColumn, this.locationTransferExpirationDateGridColumn, this.locationTransferQuantityGridColumn, this.locationTransferExpirationDateFormatGridColumn, this.locationTransferPalletsGridColumn, this.locationTransferUnitsGridColumn, this.locationTransferCarrierGridColumn});
			this.previewLocationTransfersGridView.GridControl = this.previewLocationTransfersGridControl;
			this.previewLocationTransfersGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[]
			{
				new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TransferQuantity", this.locationTransferQuantityGridColumn, "{0:#,##0.######}"),
				new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TransferUnits", this.locationTransferUnitsGridColumn, "{0:#,##0.######}"),
				new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TransferPallets", this.locationTransferPalletsGridColumn, "{0:#,##0.######}")
			});
			this.previewLocationTransfersGridView.Name = "previewLocationTransfersGridView";
			this.previewLocationTransfersGridView.OptionsBehavior.Editable = false;
			this.previewLocationTransfersGridView.OptionsView.ShowAutoFilterRow = true;
			this.previewLocationTransfersGridView.OptionsView.ShowDetailButtons = false;
			this.previewLocationTransfersGridView.OptionsView.ShowFooter = true;
			//
			//locationTransfersDateGridColumn
			//
			this.locationTransfersDateGridColumn.Caption = "Transfer Date";
			this.locationTransfersDateGridColumn.Name = "locationTransfersDateGridColumn";
			this.locationTransfersDateGridColumn.Visible = true;
			this.locationTransfersDateGridColumn.VisibleIndex = 0;
			//
			//locationTransferFromLocationGridColumn
			//
			this.locationTransferFromLocationGridColumn.Caption = "From Location";
			this.locationTransferFromLocationGridColumn.Name = "locationTransferFromLocationGridColumn";
			this.locationTransferFromLocationGridColumn.Visible = true;
			this.locationTransferFromLocationGridColumn.VisibleIndex = 2;
			//
			//locationTransferToLocationGridColumn
			//
			this.locationTransferToLocationGridColumn.Caption = "To Location";
			this.locationTransferToLocationGridColumn.Name = "locationTransferToLocationGridColumn";
			this.locationTransferToLocationGridColumn.Visible = true;
			this.locationTransferToLocationGridColumn.VisibleIndex = 3;
			//
			//locationTransferItemCodeGridColumn
			//
			this.locationTransferItemCodeGridColumn.Caption = "Item Code";
			this.locationTransferItemCodeGridColumn.Name = "locationTransferItemCodeGridColumn";
			this.locationTransferItemCodeGridColumn.Visible = true;
			this.locationTransferItemCodeGridColumn.VisibleIndex = 4;
			//
			//locationTransferItemDescriptionGridColumn
			//
			this.locationTransferItemDescriptionGridColumn.Caption = "Item Description";
			this.locationTransferItemDescriptionGridColumn.Name = "locationTransferItemDescriptionGridColumn";
			this.locationTransferItemDescriptionGridColumn.Visible = true;
			this.locationTransferItemDescriptionGridColumn.VisibleIndex = 5;
			//
			//locationTransferNumberGridColumn
			//
			this.locationTransferNumberGridColumn.Caption = "Transfer Number";
			this.locationTransferNumberGridColumn.Name = "locationTransferNumberGridColumn";
			this.locationTransferNumberGridColumn.Visible = true;
			this.locationTransferNumberGridColumn.VisibleIndex = 1;
			//
			//locationTransferItemLotGridColumn
			//
			this.locationTransferItemLotGridColumn.Caption = "Item Lot #";
			this.locationTransferItemLotGridColumn.Name = "locationTransferItemLotGridColumn";
			this.locationTransferItemLotGridColumn.Visible = true;
			this.locationTransferItemLotGridColumn.VisibleIndex = 6;
			//
			//locationTransferExpirationDateGridColumn
			//
			this.locationTransferExpirationDateGridColumn.Caption = "Expiration Date";
			this.locationTransferExpirationDateGridColumn.DisplayFormat.FormatString = "d";
			this.locationTransferExpirationDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.locationTransferExpirationDateGridColumn.Name = "locationTransferExpirationDateGridColumn";
			this.locationTransferExpirationDateGridColumn.Visible = true;
			this.locationTransferExpirationDateGridColumn.VisibleIndex = 7;
			//
			//locationTransferQuantityGridColumn
			//
			this.locationTransferQuantityGridColumn.Caption = "Transfer Quantity";
			this.locationTransferQuantityGridColumn.Name = "locationTransferQuantityGridColumn";
			this.locationTransferQuantityGridColumn.Visible = true;
			this.locationTransferQuantityGridColumn.VisibleIndex = 8;
			//
			//locationTransferExpirationDateFormatGridColumn
			//
			this.locationTransferExpirationDateFormatGridColumn.Caption = "GridColumn10";
			this.locationTransferExpirationDateFormatGridColumn.Name = "locationTransferExpirationDateFormatGridColumn";
			//
			//locationTransferPalletsGridColumn
			//
			this.locationTransferPalletsGridColumn.Caption = "Transfer Pallets";
			this.locationTransferPalletsGridColumn.Name = "locationTransferPalletsGridColumn";
			this.locationTransferPalletsGridColumn.Visible = true;
			this.locationTransferPalletsGridColumn.VisibleIndex = 10;
			//
			//locationTransferUnitsGridColumn
			//
			this.locationTransferUnitsGridColumn.Caption = "Transfer Units";
			this.locationTransferUnitsGridColumn.Name = "locationTransferUnitsGridColumn";
			this.locationTransferUnitsGridColumn.Visible = true;
			this.locationTransferUnitsGridColumn.VisibleIndex = 9;
			//
			//locationTransferCarrierGridColumn
			//
			this.locationTransferCarrierGridColumn.Caption = "Transfer Carrier";
			this.locationTransferCarrierGridColumn.Name = "locationTransferCarrierGridColumn";
			this.locationTransferCarrierGridColumn.Visible = true;
			this.locationTransferCarrierGridColumn.VisibleIndex = 11;
			//
			//previewShiftScheduleXtraTabPage
			//
			this.previewShiftScheduleXtraTabPage.Controls.Add(this.shiftScheduleGridControl);
			this.previewShiftScheduleXtraTabPage.Controls.Add(this.refreshShiftScheduleSimpleButton);
			this.previewShiftScheduleXtraTabPage.Controls.Add(this.shiftScheduleShiftComboBoxEdit);
			this.previewShiftScheduleXtraTabPage.Controls.Add(this.shiftScheduleDateDateEdit);
			this.previewShiftScheduleXtraTabPage.Controls.Add(this.LabelControl2);
			this.previewShiftScheduleXtraTabPage.Name = "previewShiftScheduleXtraTabPage";
			this.previewShiftScheduleXtraTabPage.Size = new System.Drawing.Size(648, 584);
			this.previewShiftScheduleXtraTabPage.Text = "Preview Shift Schedule";
			//
			//shiftScheduleGridControl
			//
			this.shiftScheduleGridControl.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.shiftScheduleGridControl.Location = new System.Drawing.Point(0, 40);
			this.shiftScheduleGridControl.MainView = this.shiftScheduleGridView;
			this.shiftScheduleGridControl.MenuManager = this.BarManager1;
			this.shiftScheduleGridControl.Name = "shiftScheduleGridControl";
			this.shiftScheduleGridControl.Size = new System.Drawing.Size(648, 544);
			this.shiftScheduleGridControl.TabIndex = 4;
			this.shiftScheduleGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.shiftScheduleGridView});
			//
			//shiftScheduleGridView
			//
			this.shiftScheduleGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.shiftScheduleMachineNameGridColumn, this.shiftSchedulePeopleGridColumn, this.shiftScheduleOperatorGridColumn, this.shiftScheduleItemCodeGridColumn, this.shiftScheduleItemDescriptionGridColumn, this.shiftScheduleQuantityGridColumn, this.shiftScheduleSchedByQtyGridColumn, this.shiftScheduleNoteGridColumn, this.shiftScheduleMustRunGridColumn, this.shiftSchedulePriorityLevelGridColumn});
			this.shiftScheduleGridView.GridControl = this.shiftScheduleGridControl;
			this.shiftScheduleGridView.Name = "shiftScheduleGridView";
			this.shiftScheduleGridView.OptionsBehavior.Editable = false;
			this.shiftScheduleGridView.OptionsView.ShowAutoFilterRow = true;
			this.shiftScheduleGridView.OptionsView.ShowDetailButtons = false;
			this.shiftScheduleGridView.OptionsView.ShowFooter = true;
			//
			//shiftScheduleMachineNameGridColumn
			//
			this.shiftScheduleMachineNameGridColumn.Caption = "Machine Name";
			this.shiftScheduleMachineNameGridColumn.Name = "shiftScheduleMachineNameGridColumn";
			this.shiftScheduleMachineNameGridColumn.Visible = true;
			this.shiftScheduleMachineNameGridColumn.VisibleIndex = 0;
			//
			//shiftSchedulePeopleGridColumn
			//
			this.shiftSchedulePeopleGridColumn.Caption = "People";
			this.shiftSchedulePeopleGridColumn.Name = "shiftSchedulePeopleGridColumn";
			this.shiftSchedulePeopleGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "People", "{0:0.##}")});
			this.shiftSchedulePeopleGridColumn.Visible = true;
			this.shiftSchedulePeopleGridColumn.VisibleIndex = 1;
			//
			//shiftScheduleOperatorGridColumn
			//
			this.shiftScheduleOperatorGridColumn.Caption = "Operator";
			this.shiftScheduleOperatorGridColumn.Name = "shiftScheduleOperatorGridColumn";
			this.shiftScheduleOperatorGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Operator", "{0:0.##}")});
			this.shiftScheduleOperatorGridColumn.Visible = true;
			this.shiftScheduleOperatorGridColumn.VisibleIndex = 2;
			//
			//shiftScheduleItemCodeGridColumn
			//
			this.shiftScheduleItemCodeGridColumn.Caption = "Item Code";
			this.shiftScheduleItemCodeGridColumn.Name = "shiftScheduleItemCodeGridColumn";
			this.shiftScheduleItemCodeGridColumn.Visible = true;
			this.shiftScheduleItemCodeGridColumn.VisibleIndex = 3;
			//
			//shiftScheduleItemDescriptionGridColumn
			//
			this.shiftScheduleItemDescriptionGridColumn.Caption = "Item Description";
			this.shiftScheduleItemDescriptionGridColumn.Name = "shiftScheduleItemDescriptionGridColumn";
			this.shiftScheduleItemDescriptionGridColumn.Visible = true;
			this.shiftScheduleItemDescriptionGridColumn.VisibleIndex = 4;
			//
			//shiftScheduleQuantityGridColumn
			//
			this.shiftScheduleQuantityGridColumn.Caption = "Quantity";
			this.shiftScheduleQuantityGridColumn.Name = "shiftScheduleQuantityGridColumn";
			this.shiftScheduleQuantityGridColumn.Visible = true;
			this.shiftScheduleQuantityGridColumn.VisibleIndex = 5;
			//
			//shiftScheduleSchedByQtyGridColumn
			//
			this.shiftScheduleSchedByQtyGridColumn.Caption = "Sched By Qty";
			this.shiftScheduleSchedByQtyGridColumn.Name = "shiftScheduleSchedByQtyGridColumn";
			this.shiftScheduleSchedByQtyGridColumn.Visible = true;
			this.shiftScheduleSchedByQtyGridColumn.VisibleIndex = 6;
			//
			//shiftScheduleNoteGridColumn
			//
			this.shiftScheduleNoteGridColumn.Caption = "Note";
			this.shiftScheduleNoteGridColumn.Name = "shiftScheduleNoteGridColumn";
			this.shiftScheduleNoteGridColumn.Visible = true;
			this.shiftScheduleNoteGridColumn.VisibleIndex = 7;
			//
			//shiftScheduleMustRunGridColumn
			//
			this.shiftScheduleMustRunGridColumn.Caption = "Must Run";
			this.shiftScheduleMustRunGridColumn.Name = "shiftScheduleMustRunGridColumn";
			this.shiftScheduleMustRunGridColumn.Visible = true;
			this.shiftScheduleMustRunGridColumn.VisibleIndex = 8;
			//
			//shiftSchedulePriorityLevelGridColumn
			//
			this.shiftSchedulePriorityLevelGridColumn.Caption = "Priority Level";
			this.shiftSchedulePriorityLevelGridColumn.Name = "shiftSchedulePriorityLevelGridColumn";
			this.shiftSchedulePriorityLevelGridColumn.Visible = true;
			this.shiftSchedulePriorityLevelGridColumn.VisibleIndex = 9;
			//
			//refreshShiftScheduleSimpleButton
			//
			this.refreshShiftScheduleSimpleButton.Location = new System.Drawing.Point(493, 9);
			this.refreshShiftScheduleSimpleButton.Name = "refreshShiftScheduleSimpleButton";
			this.refreshShiftScheduleSimpleButton.Size = new System.Drawing.Size(107, 23);
			this.refreshShiftScheduleSimpleButton.TabIndex = 3;
			this.refreshShiftScheduleSimpleButton.Text = "Refresh";
			//
			//shiftScheduleShiftComboBoxEdit
			//
			this.shiftScheduleShiftComboBoxEdit.Location = new System.Drawing.Point(346, 11);
			this.shiftScheduleShiftComboBoxEdit.MenuManager = this.BarManager1;
			this.shiftScheduleShiftComboBoxEdit.Name = "shiftScheduleShiftComboBoxEdit";
			this.shiftScheduleShiftComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.shiftScheduleShiftComboBoxEdit.Properties.Items.AddRange(new object[] {"Shift 1", "Shift 2", "Shift 3"});
			this.shiftScheduleShiftComboBoxEdit.Size = new System.Drawing.Size(125, 20);
			this.shiftScheduleShiftComboBoxEdit.TabIndex = 2;
			//
			//shiftScheduleDateDateEdit
			//
			this.shiftScheduleDateDateEdit.EditValue = null;
			this.shiftScheduleDateDateEdit.Location = new System.Drawing.Point(177, 11);
			this.shiftScheduleDateDateEdit.MenuManager = this.BarManager1;
			this.shiftScheduleDateDateEdit.Name = "shiftScheduleDateDateEdit";
			this.shiftScheduleDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.shiftScheduleDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.shiftScheduleDateDateEdit.Size = new System.Drawing.Size(147, 20);
			this.shiftScheduleDateDateEdit.TabIndex = 1;
			//
			//LabelControl2
			//
			this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.0F, System.Drawing.FontStyle.Bold);
			this.LabelControl2.Appearance.Options.UseFont = true;
			this.LabelControl2.Location = new System.Drawing.Point(18, 12);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(137, 16);
			this.LabelControl2.TabIndex = 0;
			this.LabelControl2.Text = "Select A Day && Shift:";
			//
			//previewWeeklyProductionXtraTabPage
			//
			this.previewWeeklyProductionXtraTabPage.Controls.Add(this.weeklyProductionGridControl);
			this.previewWeeklyProductionXtraTabPage.Name = "previewWeeklyProductionXtraTabPage";
			this.previewWeeklyProductionXtraTabPage.Size = new System.Drawing.Size(648, 584);
			this.previewWeeklyProductionXtraTabPage.Text = "Preview Weekly Production";
			//
			//weeklyProductionGridControl
			//
			this.weeklyProductionGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.weeklyProductionGridControl.Location = new System.Drawing.Point(0, 0);
			this.weeklyProductionGridControl.MainView = this.weeklyProductionGridView;
			this.weeklyProductionGridControl.MenuManager = this.BarManager1;
			this.weeklyProductionGridControl.Name = "weeklyProductionGridControl";
			this.weeklyProductionGridControl.Size = new System.Drawing.Size(648, 584);
			this.weeklyProductionGridControl.TabIndex = 0;
			this.weeklyProductionGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.weeklyProductionGridView});
			//
			//weeklyProductionGridView
			//
			this.weeklyProductionGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.weeklyProductionProductionWeekGridColumn, this.weeklyProductionItemCodeGridColumn, this.weeklyProductionItemDescriptionGridColumn, this.weeklyProductionCasesRequiredGridColumn, this.weeklyProductionBagsRequiredGridColumn, this.weeklyProductionMondayGridColumn, this.weeklyProductionTuesdayGridColumn, this.weeklyProductionWednesdayGridColumn, this.weeklyProductionThursdayGridColumn, this.weeklyProductionFridayGridColumn, this.weeklyProductionSaturdayGridColumn, this.weeklyProductionSundayGridColumn, this.weeklyProductionTotalProducedWeeklyGridColumn, this.weeklyProductionTotalProducedGridColumn, this.weeklyProductionPercentageCompleteGridColumn});
			this.weeklyProductionGridView.GridControl = this.weeklyProductionGridControl;
			this.weeklyProductionGridView.GroupCount = 1;
			this.weeklyProductionGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalProducedWeek", null, "Produced = {0:0.##}")});
			this.weeklyProductionGridView.Name = "weeklyProductionGridView";
			this.weeklyProductionGridView.OptionsBehavior.Editable = false;
			this.weeklyProductionGridView.OptionsView.ShowAutoFilterRow = true;
			this.weeklyProductionGridView.OptionsView.ShowDetailButtons = false;
			this.weeklyProductionGridView.OptionsView.ShowFooter = true;
			this.weeklyProductionGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.weeklyProductionProductionWeekGridColumn, DevExpress.Data.ColumnSortOrder.Ascending)});
			//
			//weeklyProductionProductionWeekGridColumn
			//
			this.weeklyProductionProductionWeekGridColumn.Caption = "Production Week";
			this.weeklyProductionProductionWeekGridColumn.Name = "weeklyProductionProductionWeekGridColumn";
			this.weeklyProductionProductionWeekGridColumn.Visible = true;
			this.weeklyProductionProductionWeekGridColumn.VisibleIndex = 0;
			//
			//weeklyProductionItemCodeGridColumn
			//
			this.weeklyProductionItemCodeGridColumn.Caption = "Item Code";
			this.weeklyProductionItemCodeGridColumn.Name = "weeklyProductionItemCodeGridColumn";
			this.weeklyProductionItemCodeGridColumn.Visible = true;
			this.weeklyProductionItemCodeGridColumn.VisibleIndex = 0;
			//
			//weeklyProductionItemDescriptionGridColumn
			//
			this.weeklyProductionItemDescriptionGridColumn.Caption = "Item Description";
			this.weeklyProductionItemDescriptionGridColumn.Name = "weeklyProductionItemDescriptionGridColumn";
			this.weeklyProductionItemDescriptionGridColumn.Visible = true;
			this.weeklyProductionItemDescriptionGridColumn.VisibleIndex = 1;
			//
			//weeklyProductionCasesRequiredGridColumn
			//
			this.weeklyProductionCasesRequiredGridColumn.Caption = "Cases Required";
			this.weeklyProductionCasesRequiredGridColumn.Name = "weeklyProductionCasesRequiredGridColumn";
			this.weeklyProductionCasesRequiredGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:0.00}")});
			this.weeklyProductionCasesRequiredGridColumn.Visible = true;
			this.weeklyProductionCasesRequiredGridColumn.VisibleIndex = 2;
			//
			//weeklyProductionBagsRequiredGridColumn
			//
			this.weeklyProductionBagsRequiredGridColumn.Caption = "Bags Required";
			this.weeklyProductionBagsRequiredGridColumn.Name = "weeklyProductionBagsRequiredGridColumn";
			this.weeklyProductionBagsRequiredGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:0.00}")});
			this.weeklyProductionBagsRequiredGridColumn.Visible = true;
			this.weeklyProductionBagsRequiredGridColumn.VisibleIndex = 3;
			//
			//weeklyProductionMondayGridColumn
			//
			this.weeklyProductionMondayGridColumn.Caption = "Monday";
			this.weeklyProductionMondayGridColumn.Name = "weeklyProductionMondayGridColumn";
			this.weeklyProductionMondayGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:0.00}")});
			this.weeklyProductionMondayGridColumn.Visible = true;
			this.weeklyProductionMondayGridColumn.VisibleIndex = 4;
			//
			//weeklyProductionTuesdayGridColumn
			//
			this.weeklyProductionTuesdayGridColumn.Caption = "Tuesday";
			this.weeklyProductionTuesdayGridColumn.Name = "weeklyProductionTuesdayGridColumn";
			this.weeklyProductionTuesdayGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:0.00}")});
			this.weeklyProductionTuesdayGridColumn.Visible = true;
			this.weeklyProductionTuesdayGridColumn.VisibleIndex = 5;
			//
			//weeklyProductionWednesdayGridColumn
			//
			this.weeklyProductionWednesdayGridColumn.Caption = "Wednesday";
			this.weeklyProductionWednesdayGridColumn.Name = "weeklyProductionWednesdayGridColumn";
			this.weeklyProductionWednesdayGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:0.00}")});
			this.weeklyProductionWednesdayGridColumn.Visible = true;
			this.weeklyProductionWednesdayGridColumn.VisibleIndex = 6;
			//
			//weeklyProductionThursdayGridColumn
			//
			this.weeklyProductionThursdayGridColumn.Caption = "Thursday";
			this.weeklyProductionThursdayGridColumn.Name = "weeklyProductionThursdayGridColumn";
			this.weeklyProductionThursdayGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:0.00}")});
			this.weeklyProductionThursdayGridColumn.Visible = true;
			this.weeklyProductionThursdayGridColumn.VisibleIndex = 7;
			//
			//weeklyProductionFridayGridColumn
			//
			this.weeklyProductionFridayGridColumn.Caption = "Friday";
			this.weeklyProductionFridayGridColumn.Name = "weeklyProductionFridayGridColumn";
			this.weeklyProductionFridayGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:0.00}")});
			this.weeklyProductionFridayGridColumn.Visible = true;
			this.weeklyProductionFridayGridColumn.VisibleIndex = 8;
			//
			//weeklyProductionSaturdayGridColumn
			//
			this.weeklyProductionSaturdayGridColumn.Caption = "Saturday";
			this.weeklyProductionSaturdayGridColumn.Name = "weeklyProductionSaturdayGridColumn";
			this.weeklyProductionSaturdayGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:0.00}")});
			this.weeklyProductionSaturdayGridColumn.Visible = true;
			this.weeklyProductionSaturdayGridColumn.VisibleIndex = 9;
			//
			//weeklyProductionSundayGridColumn
			//
			this.weeklyProductionSundayGridColumn.Caption = "Sunday";
			this.weeklyProductionSundayGridColumn.Name = "weeklyProductionSundayGridColumn";
			this.weeklyProductionSundayGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:0.00}")});
			this.weeklyProductionSundayGridColumn.Visible = true;
			this.weeklyProductionSundayGridColumn.VisibleIndex = 10;
			//
			//weeklyProductionTotalProducedWeeklyGridColumn
			//
			this.weeklyProductionTotalProducedWeeklyGridColumn.Caption = "Total Week Production";
			this.weeklyProductionTotalProducedWeeklyGridColumn.Name = "weeklyProductionTotalProducedWeeklyGridColumn";
			this.weeklyProductionTotalProducedWeeklyGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:0.00}")});
			this.weeklyProductionTotalProducedWeeklyGridColumn.Visible = true;
			this.weeklyProductionTotalProducedWeeklyGridColumn.VisibleIndex = 11;
			//
			//weeklyProductionTotalProducedGridColumn
			//
			this.weeklyProductionTotalProducedGridColumn.Caption = "Total Produced";
			this.weeklyProductionTotalProducedGridColumn.Name = "weeklyProductionTotalProducedGridColumn";
			this.weeklyProductionTotalProducedGridColumn.Visible = true;
			this.weeklyProductionTotalProducedGridColumn.VisibleIndex = 12;
			//
			//weeklyProductionPercentageCompleteGridColumn
			//
			this.weeklyProductionPercentageCompleteGridColumn.Caption = "Total Percentage Complete";
			this.weeklyProductionPercentageCompleteGridColumn.DisplayFormat.FormatString = "P";
			this.weeklyProductionPercentageCompleteGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.weeklyProductionPercentageCompleteGridColumn.Name = "weeklyProductionPercentageCompleteGridColumn";
			this.weeklyProductionPercentageCompleteGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "", "{0:P}")});
			this.weeklyProductionPercentageCompleteGridColumn.Visible = true;
			this.weeklyProductionPercentageCompleteGridColumn.VisibleIndex = 13;
			//
			//previewProjBomAvailXtraTabPage
			//
			this.previewProjBomAvailXtraTabPage.Controls.Add(this.lblNededBy);
			this.previewProjBomAvailXtraTabPage.Controls.Add(this.neededBy);
			this.previewProjBomAvailXtraTabPage.Controls.Add(this.ProjBomAvailGridControl);
			this.previewProjBomAvailXtraTabPage.Name = "previewProjBomAvailXtraTabPage";
			this.previewProjBomAvailXtraTabPage.Size = new System.Drawing.Size(648, 584);
			this.previewProjBomAvailXtraTabPage.Text = "Preview Project Bom Availibility";
			//
			//lblNededBy
			//
			this.lblNededBy.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.lblNededBy.Appearance.Options.UseBackColor = true;
			this.lblNededBy.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.lblNededBy.Location = new System.Drawing.Point(282, 6);
			this.lblNededBy.Name = "lblNededBy";
			this.lblNededBy.Size = new System.Drawing.Size(52, 13);
			this.lblNededBy.TabIndex = 2;
			this.lblNededBy.Text = "Needed By";
			//
			//neededBy
			//
			this.neededBy.EditValue = null;
			this.neededBy.Location = new System.Drawing.Point(340, 3);
			this.neededBy.MenuManager = this.BarManager1;
			this.neededBy.Name = "neededBy";
			this.neededBy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.neededBy.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.neededBy.Size = new System.Drawing.Size(100, 20);
			this.neededBy.TabIndex = 1;
			//
			//ProjBomAvailGridControl
			//
			this.ProjBomAvailGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ProjBomAvailGridControl.Location = new System.Drawing.Point(0, 0);
			this.ProjBomAvailGridControl.MainView = this.ProjBomAvailGridView;
			this.ProjBomAvailGridControl.MenuManager = this.BarManager1;
			this.ProjBomAvailGridControl.Name = "ProjBomAvailGridControl";
			this.ProjBomAvailGridControl.Size = new System.Drawing.Size(648, 584);
			this.ProjBomAvailGridControl.TabIndex = 0;
			this.ProjBomAvailGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.ProjBomAvailGridView});
			//
			//ProjBomAvailGridView
			//
			this.ProjBomAvailGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.ProjBomAvailCustPOGridColumn, this.ProjBomAvailCustNameGridColumn, this.ProjBomAvailItemCodeGridColumn, this.ProjBomAvailItemDescriptionGridColumn, this.ProjBomAvailItemTypeGridColumn, this.ProjBomAvailTotalAmtNeededGridColumn, this.ProjBomAvailLocalQtyGridColumn, this.ProjBomLocalShortageGridColumn, this.ProjBomAvailNonLocalQtyGridColumn, this.ProjBomAvailNonLocalPalletsQtyGridColumn, this.ProjBomAvailQtyOnHndGridColumn, this.ProjBomAvailQtyShortageGridColumn});
			this.ProjBomAvailGridView.GridControl = this.ProjBomAvailGridControl;
			this.ProjBomAvailGridView.Name = "ProjBomAvailGridView";
			this.ProjBomAvailGridView.OptionsBehavior.Editable = false;
			this.ProjBomAvailGridView.OptionsView.ShowAutoFilterRow = true;
			this.ProjBomAvailGridView.OptionsView.ShowDetailButtons = false;
			//
			//ProjBomAvailCustPOGridColumn
			//
			this.ProjBomAvailCustPOGridColumn.Caption = "Customer PO";
			this.ProjBomAvailCustPOGridColumn.Name = "ProjBomAvailCustPOGridColumn";
			this.ProjBomAvailCustPOGridColumn.Visible = true;
			this.ProjBomAvailCustPOGridColumn.VisibleIndex = 0;
			this.ProjBomAvailCustPOGridColumn.Width = 90;
			//
			//ProjBomAvailCustNameGridColumn
			//
			this.ProjBomAvailCustNameGridColumn.Caption = "Customer Name";
			this.ProjBomAvailCustNameGridColumn.Name = "ProjBomAvailCustNameGridColumn";
			this.ProjBomAvailCustNameGridColumn.Visible = true;
			this.ProjBomAvailCustNameGridColumn.VisibleIndex = 1;
			//
			//ProjBomAvailItemCodeGridColumn
			//
			this.ProjBomAvailItemCodeGridColumn.Caption = "Item Code";
			this.ProjBomAvailItemCodeGridColumn.Name = "ProjBomAvailItemCodeGridColumn";
			this.ProjBomAvailItemCodeGridColumn.Visible = true;
			this.ProjBomAvailItemCodeGridColumn.VisibleIndex = 2;
			this.ProjBomAvailItemCodeGridColumn.Width = 53;
			//
			//ProjBomAvailItemDescriptionGridColumn
			//
			this.ProjBomAvailItemDescriptionGridColumn.Caption = "Item Description";
			this.ProjBomAvailItemDescriptionGridColumn.Name = "ProjBomAvailItemDescriptionGridColumn";
			this.ProjBomAvailItemDescriptionGridColumn.Visible = true;
			this.ProjBomAvailItemDescriptionGridColumn.VisibleIndex = 3;
			this.ProjBomAvailItemDescriptionGridColumn.Width = 53;
			//
			//ProjBomAvailItemTypeGridColumn
			//
			this.ProjBomAvailItemTypeGridColumn.Caption = "Item Type";
			this.ProjBomAvailItemTypeGridColumn.Name = "ProjBomAvailItemTypeGridColumn";
			this.ProjBomAvailItemTypeGridColumn.Visible = true;
			this.ProjBomAvailItemTypeGridColumn.VisibleIndex = 4;
			this.ProjBomAvailItemTypeGridColumn.Width = 53;
			//
			//ProjBomAvailTotalAmtNeededGridColumn
			//
			this.ProjBomAvailTotalAmtNeededGridColumn.Caption = "Required Qty";
			this.ProjBomAvailTotalAmtNeededGridColumn.DisplayFormat.FormatString = "{0:#,##0.00####}";
			this.ProjBomAvailTotalAmtNeededGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.ProjBomAvailTotalAmtNeededGridColumn.Name = "ProjBomAvailTotalAmtNeededGridColumn";
			this.ProjBomAvailTotalAmtNeededGridColumn.Visible = true;
			this.ProjBomAvailTotalAmtNeededGridColumn.VisibleIndex = 5;
			this.ProjBomAvailTotalAmtNeededGridColumn.Width = 53;
			//
			//ProjBomAvailLocalQtyGridColumn
			//
			this.ProjBomAvailLocalQtyGridColumn.Caption = "LOCAL Qty On Hand";
			this.ProjBomAvailLocalQtyGridColumn.DisplayFormat.FormatString = "{0:#,##0.00####}";
			this.ProjBomAvailLocalQtyGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.ProjBomAvailLocalQtyGridColumn.Name = "ProjBomAvailLocalQtyGridColumn";
			this.ProjBomAvailLocalQtyGridColumn.Visible = true;
			this.ProjBomAvailLocalQtyGridColumn.VisibleIndex = 6;
			this.ProjBomAvailLocalQtyGridColumn.Width = 53;
			//
			//ProjBomLocalShortageGridColumn
			//
			this.ProjBomLocalShortageGridColumn.Caption = "LOCAL Shortage";
			this.ProjBomLocalShortageGridColumn.DisplayFormat.FormatString = "{0:#,##0.00####}";
			this.ProjBomLocalShortageGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.ProjBomLocalShortageGridColumn.Name = "ProjBomLocalShortageGridColumn";
			this.ProjBomLocalShortageGridColumn.Visible = true;
			this.ProjBomLocalShortageGridColumn.VisibleIndex = 7;
			this.ProjBomLocalShortageGridColumn.Width = 53;
			//
			//ProjBomAvailNonLocalQtyGridColumn
			//
			this.ProjBomAvailNonLocalQtyGridColumn.Caption = "NON-LOCAL Qty On Hand";
			this.ProjBomAvailNonLocalQtyGridColumn.DisplayFormat.FormatString = "{0:#,##0.00####}";
			this.ProjBomAvailNonLocalQtyGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.ProjBomAvailNonLocalQtyGridColumn.Name = "ProjBomAvailNonLocalQtyGridColumn";
			this.ProjBomAvailNonLocalQtyGridColumn.Visible = true;
			this.ProjBomAvailNonLocalQtyGridColumn.VisibleIndex = 9;
			this.ProjBomAvailNonLocalQtyGridColumn.Width = 53;
			//
			//ProjBomAvailNonLocalPalletsQtyGridColumn
			//
			this.ProjBomAvailNonLocalPalletsQtyGridColumn.Caption = "LOCAL Shortage - Pallets";
			this.ProjBomAvailNonLocalPalletsQtyGridColumn.DisplayFormat.FormatString = "{0:#,##0.00####}";
			this.ProjBomAvailNonLocalPalletsQtyGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.ProjBomAvailNonLocalPalletsQtyGridColumn.Name = "ProjBomAvailNonLocalPalletsQtyGridColumn";
			this.ProjBomAvailNonLocalPalletsQtyGridColumn.Visible = true;
			this.ProjBomAvailNonLocalPalletsQtyGridColumn.VisibleIndex = 8;
			this.ProjBomAvailNonLocalPalletsQtyGridColumn.Width = 53;
			//
			//ProjBomAvailQtyOnHndGridColumn
			//
			this.ProjBomAvailQtyOnHndGridColumn.Caption = "TOTAL Qty On Hand";
			this.ProjBomAvailQtyOnHndGridColumn.DisplayFormat.FormatString = "{0:#,##0.00####}";
			this.ProjBomAvailQtyOnHndGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.ProjBomAvailQtyOnHndGridColumn.Name = "ProjBomAvailQtyOnHndGridColumn";
			this.ProjBomAvailQtyOnHndGridColumn.Visible = true;
			this.ProjBomAvailQtyOnHndGridColumn.VisibleIndex = 10;
			this.ProjBomAvailQtyOnHndGridColumn.Width = 53;
			//
			//ProjBomAvailQtyShortageGridColumn
			//
			this.ProjBomAvailQtyShortageGridColumn.Caption = "TOTAL Shortage";
			this.ProjBomAvailQtyShortageGridColumn.DisplayFormat.FormatString = "{0:#,##0.00####}";
			this.ProjBomAvailQtyShortageGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.ProjBomAvailQtyShortageGridColumn.Name = "ProjBomAvailQtyShortageGridColumn";
			this.ProjBomAvailQtyShortageGridColumn.Visible = true;
			this.ProjBomAvailQtyShortageGridColumn.VisibleIndex = 11;
			this.ProjBomAvailQtyShortageGridColumn.Width = 63;
			//
			//previewProductionBillingXtraTabPage
			//
			this.previewProductionBillingXtraTabPage.Controls.Add(this.previewProductionBillingGridControl);
			this.previewProductionBillingXtraTabPage.Name = "previewProductionBillingXtraTabPage";
			this.previewProductionBillingXtraTabPage.Size = new System.Drawing.Size(648, 584);
			this.previewProductionBillingXtraTabPage.Text = "Preview Production Billing";
			//
			//previewProductionBillingGridControl
			//
			this.previewProductionBillingGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.previewProductionBillingGridControl.Location = new System.Drawing.Point(0, 0);
			this.previewProductionBillingGridControl.MainView = this.previewProductionBillingGridView;
			this.previewProductionBillingGridControl.MenuManager = this.BarManager1;
			this.previewProductionBillingGridControl.Name = "previewProductionBillingGridControl";
			this.previewProductionBillingGridControl.Size = new System.Drawing.Size(648, 584);
			this.previewProductionBillingGridControl.TabIndex = 0;
			this.previewProductionBillingGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.previewProductionBillingGridView});
			//
			//previewProductionBillingGridView
			//
			this.previewProductionBillingGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.productionBillingDateGridColumn, this.productionBillingCustomerGridColumn, this.productionBillingItemCodeGridColumn, this.productionBillingItemDescriptionGridColumn, this.productionBillingItemTypeGridColumn, this.productionBillingShiftGridColumn, this.productionBillingPOGridColumn, this.productionBillingUOMGridColumn, this.productionBillingQuantityGridColumn, this.productionBillingCasesGridColumn, this.productionBillingPriceGridColumn});
			this.previewProductionBillingGridView.GridControl = this.previewProductionBillingGridControl;
			this.previewProductionBillingGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[]
			{
				new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Price", this.productionBillingPriceGridColumn, "{0:c}"),
				new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cases", this.productionBillingCasesGridColumn, "{0:f2}"),
				new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", this.productionBillingQuantityGridColumn, "{0:#,##0.######}")
			});
			this.previewProductionBillingGridView.Name = "previewProductionBillingGridView";
			this.previewProductionBillingGridView.OptionsBehavior.Editable = false;
			this.previewProductionBillingGridView.OptionsView.ShowAutoFilterRow = true;
			this.previewProductionBillingGridView.OptionsView.ShowDetailButtons = false;
			this.previewProductionBillingGridView.OptionsView.ShowFooter = true;
			//
			//productionBillingDateGridColumn
			//
			this.productionBillingDateGridColumn.Caption = "Production Date";
			this.productionBillingDateGridColumn.DisplayFormat.FormatString = "g";
			this.productionBillingDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.productionBillingDateGridColumn.Name = "productionBillingDateGridColumn";
			this.productionBillingDateGridColumn.Visible = true;
			this.productionBillingDateGridColumn.VisibleIndex = 0;
			this.productionBillingDateGridColumn.Width = 130;
			//
			//productionBillingCustomerGridColumn
			//
			this.productionBillingCustomerGridColumn.Caption = "Customer Name";
			this.productionBillingCustomerGridColumn.Name = "productionBillingCustomerGridColumn";
			this.productionBillingCustomerGridColumn.Visible = true;
			this.productionBillingCustomerGridColumn.VisibleIndex = 1;
			this.productionBillingCustomerGridColumn.Width = 49;
			//
			//productionBillingItemCodeGridColumn
			//
			this.productionBillingItemCodeGridColumn.Caption = "Item Code";
			this.productionBillingItemCodeGridColumn.Name = "productionBillingItemCodeGridColumn";
			this.productionBillingItemCodeGridColumn.Visible = true;
			this.productionBillingItemCodeGridColumn.VisibleIndex = 2;
			this.productionBillingItemCodeGridColumn.Width = 49;
			//
			//productionBillingItemDescriptionGridColumn
			//
			this.productionBillingItemDescriptionGridColumn.Caption = "Item Description";
			this.productionBillingItemDescriptionGridColumn.Name = "productionBillingItemDescriptionGridColumn";
			this.productionBillingItemDescriptionGridColumn.Visible = true;
			this.productionBillingItemDescriptionGridColumn.VisibleIndex = 3;
			this.productionBillingItemDescriptionGridColumn.Width = 49;
			//
			//productionBillingItemTypeGridColumn
			//
			this.productionBillingItemTypeGridColumn.Caption = "Item Type";
			this.productionBillingItemTypeGridColumn.Name = "productionBillingItemTypeGridColumn";
			this.productionBillingItemTypeGridColumn.Visible = true;
			this.productionBillingItemTypeGridColumn.VisibleIndex = 4;
			this.productionBillingItemTypeGridColumn.Width = 49;
			//
			//productionBillingShiftGridColumn
			//
			this.productionBillingShiftGridColumn.Caption = "Shift";
			this.productionBillingShiftGridColumn.Name = "productionBillingShiftGridColumn";
			this.productionBillingShiftGridColumn.Visible = true;
			this.productionBillingShiftGridColumn.VisibleIndex = 5;
			this.productionBillingShiftGridColumn.Width = 49;
			//
			//productionBillingPOGridColumn
			//
			this.productionBillingPOGridColumn.Caption = "PO";
			this.productionBillingPOGridColumn.Name = "productionBillingPOGridColumn";
			this.productionBillingPOGridColumn.Visible = true;
			this.productionBillingPOGridColumn.VisibleIndex = 6;
			this.productionBillingPOGridColumn.Width = 49;
			//
			//productionBillingUOMGridColumn
			//
			this.productionBillingUOMGridColumn.Caption = "UOM";
			this.productionBillingUOMGridColumn.Name = "productionBillingUOMGridColumn";
			this.productionBillingUOMGridColumn.Visible = true;
			this.productionBillingUOMGridColumn.VisibleIndex = 7;
			this.productionBillingUOMGridColumn.Width = 49;
			//
			//productionBillingQuantityGridColumn
			//
			this.productionBillingQuantityGridColumn.Caption = "Quantity";
			this.productionBillingQuantityGridColumn.Name = "productionBillingQuantityGridColumn";
			this.productionBillingQuantityGridColumn.Visible = true;
			this.productionBillingQuantityGridColumn.VisibleIndex = 8;
			this.productionBillingQuantityGridColumn.Width = 49;
			//
			//productionBillingCasesGridColumn
			//
			this.productionBillingCasesGridColumn.Caption = "Cases";
			this.productionBillingCasesGridColumn.DisplayFormat.FormatString = "f2";
			this.productionBillingCasesGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.productionBillingCasesGridColumn.Name = "productionBillingCasesGridColumn";
			this.productionBillingCasesGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cases", "{0:f2}")});
			this.productionBillingCasesGridColumn.Visible = true;
			this.productionBillingCasesGridColumn.VisibleIndex = 9;
			this.productionBillingCasesGridColumn.Width = 49;
			//
			//productionBillingPriceGridColumn
			//
			this.productionBillingPriceGridColumn.Caption = "Price";
			this.productionBillingPriceGridColumn.DisplayFormat.FormatString = "c";
			this.productionBillingPriceGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.productionBillingPriceGridColumn.Name = "productionBillingPriceGridColumn";
			this.productionBillingPriceGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Price", "{0:c}")});
			this.productionBillingPriceGridColumn.Visible = true;
			this.productionBillingPriceGridColumn.VisibleIndex = 10;
			this.productionBillingPriceGridColumn.Width = 59;
			//
			//previewBaggingXtraTabPage
			//
			this.previewBaggingXtraTabPage.Controls.Add(this.baggingReportPivotGridControl);
			this.previewBaggingXtraTabPage.Name = "previewBaggingXtraTabPage";
			this.previewBaggingXtraTabPage.Size = new System.Drawing.Size(648, 584);
			this.previewBaggingXtraTabPage.Text = "Preview Bagging Report";
			//
			//baggingReportPivotGridControl
			//
			this.baggingReportPivotGridControl.ActiveFilterString = "";
			this.baggingReportPivotGridControl.DataSource = this.baggingReportXpView;
			this.baggingReportPivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.baggingReportPivotGridControl.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {this.fieldMachineName1, this.fieldProductionDate1, this.fieldProductionShift1, this.fieldQuantity1, this.reasonsPivotGridField, this.minutesPivotGridField, this.fieldItemCode});
			PivotGridGroup1.Fields.Add(this.fieldMachineName1);
			PivotGridGroup1.Hierarchy = null;
			PivotGridGroup1.ShowNewValues = true;
			this.baggingReportPivotGridControl.Groups.AddRange(new DevExpress.XtraPivotGrid.PivotGridGroup[] {PivotGridGroup1});
			this.baggingReportPivotGridControl.Location = new System.Drawing.Point(0, 0);
			this.baggingReportPivotGridControl.Name = "baggingReportPivotGridControl";
			this.baggingReportPivotGridControl.Size = new System.Drawing.Size(648, 584);
			this.baggingReportPivotGridControl.TabIndex = 0;
			//
			//baggingReportXpView
			//
			this.baggingReportXpView.ObjectType = typeof(DXDAL.SPGData.Production);
			this.baggingReportXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("MachineName", DevExpress.Xpo.SortDirection.None, "[ProdMainMachineLine.MachineLineName]", false, true),
				new DevExpress.Xpo.ViewProperty("ProductionDate", DevExpress.Xpo.SortDirection.None, "[ProdMainDate]", false, true),
				new DevExpress.Xpo.ViewProperty("ProductionShift", DevExpress.Xpo.SortDirection.None, "[ProdMainShift.ShiftName]", false, true),
				new DevExpress.Xpo.ViewProperty("Quantity", DevExpress.Xpo.SortDirection.None, "[ProdMainQuantity] * Iif([ProdMainItemID.intQtyPerUnit] > 0, [ProdMainItemID.intQ" + "tyPerUnit], 1)", false, true),
				new DevExpress.Xpo.ViewProperty("ProductionID", DevExpress.Xpo.SortDirection.None, "[ProdMainID]", false, true),
				new DevExpress.Xpo.ViewProperty("ProductionStartTime", DevExpress.Xpo.SortDirection.None, "[ProdMainTimeStart]", false, true),
				new DevExpress.Xpo.ViewProperty("ProductionStopTime", DevExpress.Xpo.SortDirection.None, "[ProdMainTimeStop]", false, true),
				new DevExpress.Xpo.ViewProperty("ProductionItemID", DevExpress.Xpo.SortDirection.None, "[ProdMainItemID.ItemCode]", false, true)
			});
			//
			//fieldProductionDate1
			//
			this.fieldProductionDate1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldProductionDate1.AreaIndex = 0;
			this.fieldProductionDate1.Caption = "Date";
			this.fieldProductionDate1.CellFormat.FormatString = "d";
			this.fieldProductionDate1.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.fieldProductionDate1.FieldName = "ProductionDate";
			this.fieldProductionDate1.Name = "fieldProductionDate1";
			this.fieldProductionDate1.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending;
			this.fieldProductionDate1.TotalCellFormat.FormatString = "d";
			this.fieldProductionDate1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.fieldProductionDate1.TotalValueFormat.FormatString = "d";
			this.fieldProductionDate1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.fieldProductionDate1.UnboundFieldName = "fieldProductionDate1";
			this.fieldProductionDate1.ValueFormat.FormatString = "d";
			this.fieldProductionDate1.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			//
			//fieldProductionShift1
			//
			this.fieldProductionShift1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldProductionShift1.AreaIndex = 1;
			this.fieldProductionShift1.Caption = "Shift";
			this.fieldProductionShift1.FieldName = "ProductionShift";
			this.fieldProductionShift1.Name = "fieldProductionShift1";
			this.fieldProductionShift1.Width = 75;
			//
			//fieldQuantity1
			//
			this.fieldQuantity1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldQuantity1.AreaIndex = 0;
			this.fieldQuantity1.Caption = "Quantity";
			this.fieldQuantity1.CellFormat.FormatString = "#,#";
			this.fieldQuantity1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldQuantity1.FieldName = "Quantity";
			this.fieldQuantity1.GrandTotalCellFormat.FormatString = "#,#";
			this.fieldQuantity1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldQuantity1.Name = "fieldQuantity1";
			this.fieldQuantity1.TotalCellFormat.FormatString = "#,#";
			this.fieldQuantity1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldQuantity1.TotalValueFormat.FormatString = "#,#";
			this.fieldQuantity1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldQuantity1.ValueFormat.FormatString = "f2";
			this.fieldQuantity1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldQuantity1.Width = 75;
			//
			//reasonsPivotGridField
			//
			this.reasonsPivotGridField.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.reasonsPivotGridField.AreaIndex = 1;
			this.reasonsPivotGridField.Caption = "Reasons";
			this.reasonsPivotGridField.Name = "reasonsPivotGridField";
			this.reasonsPivotGridField.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom;
			this.reasonsPivotGridField.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None;
			this.reasonsPivotGridField.Width = 50;
			//
			//minutesPivotGridField
			//
			this.minutesPivotGridField.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.minutesPivotGridField.AreaIndex = 2;
			this.minutesPivotGridField.Caption = "Minutes";
			this.minutesPivotGridField.CellFormat.FormatString = "#";
			this.minutesPivotGridField.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.minutesPivotGridField.GrandTotalCellFormat.FormatString = "f2";
			this.minutesPivotGridField.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.minutesPivotGridField.Name = "minutesPivotGridField";
			this.minutesPivotGridField.TotalCellFormat.FormatString = "#";
			this.minutesPivotGridField.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.minutesPivotGridField.TotalValueFormat.FormatString = "f2";
			this.minutesPivotGridField.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.minutesPivotGridField.ValueFormat.FormatString = "f2";
			this.minutesPivotGridField.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.minutesPivotGridField.Width = 75;
			//
			//fieldItemCode
			//
			this.fieldItemCode.AreaIndex = 0;
			this.fieldItemCode.Caption = "Item #";
			this.fieldItemCode.FieldName = "ProductionItemID";
			this.fieldItemCode.Name = "fieldItemCode";
			//
			//QuickReportsXtraForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(959, 684);
			this.Controls.Add(this.SplitContainerControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "QuickReportsXtraForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " Reports";
			((System.ComponentModel.ISupportInitialize)this.BarManager1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.SplitContainerControl1).EndInit();
			this.SplitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.quickReportsGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.quickReportsGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.reportsXtraTabControl).EndInit();
			this.reportsXtraTabControl.ResumeLayout(false);
			this.previewCustoemrsXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.previewGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.previewGridView).EndInit();
			this.previewProductionEntriesXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.previewProductionEntriesGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.previewProductionEntriesGridView).EndInit();
			this.previewLpnStatusXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.previewLpnStatusGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.previewLpnStatusGridView).EndInit();
			this.previewCurrentRMInventoryXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.previewCurrentRMInventoryGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.previewCurrentRMInventoryGridView).EndInit();
			this.previewCurrentInventoryXtraTabPage.ResumeLayout(false);
			this.previewCurrentInventoryXtraTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.outOfStockItemsCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.currentInventoryInactiveItemsCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.currentInventoryInactiveCustomersCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.previewCurrentInventoryGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.previewCurrentInventoryGridView).EndInit();
			this.previewLocationTransfersXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.previewLocationTransfersGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.previewLocationTransfersGridView).EndInit();
			this.previewShiftScheduleXtraTabPage.ResumeLayout(false);
			this.previewShiftScheduleXtraTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.shiftScheduleGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shiftScheduleGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shiftScheduleShiftComboBoxEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shiftScheduleDateDateEdit.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shiftScheduleDateDateEdit.Properties).EndInit();
			this.previewWeeklyProductionXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.weeklyProductionGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.weeklyProductionGridView).EndInit();
			this.previewProjBomAvailXtraTabPage.ResumeLayout(false);
			this.previewProjBomAvailXtraTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.neededBy.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.neededBy.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.ProjBomAvailGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.ProjBomAvailGridView).EndInit();
			this.previewProductionBillingXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.previewProductionBillingGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.previewProductionBillingGridView).EndInit();
			this.previewBaggingXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.baggingReportPivotGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.baggingReportXpView).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			this.Load += new System.EventHandler(QuickReportsXtraForm_Load);
			quickReportsGridView.Click += new System.EventHandler(quickReportsGridView_Click);
			reportsXtraTabControl.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(reportsXtraTabControl_SelectedPageChanged);
			printBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(printBarButtonItem_ItemClick);
			exportXLSBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(exportXLSBarButtonItem_ItemClick);
			previewProductionEntriesGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(previewProductionEntriesGridView_CustomColumnDisplayText);
			refreshSimpleButton.Click += new System.EventHandler(refreshSimpleButton_Click);
			previewLocationTransfersGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(previewLocationTransfersGridView_CustomColumnDisplayText);
			refreshShiftScheduleSimpleButton.Click += new System.EventHandler(refreshShiftScheduleSimpleButton_Click);
			baggingReportPivotGridControl.CustomUnboundFieldData += new DevExpress.XtraPivotGrid.CustomFieldDataEventHandler(baggingReportPivotGridControl_CustomUnboundFieldData);
			baggingReportPivotGridControl.CustomSummary += new DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventHandler(baggingReportPivotGridControl_CustomSummary);
			neededBy.Properties.DateTimeChanged += new System.EventHandler(neededBy_Properties_DateTimeChanged);
			lblNededBy.Click += new System.EventHandler(LabelControl3_Click);
			previewProductionBillingGridView.FilterEditorCreated += new DevExpress.XtraGrid.Views.Base.FilterControlEventHandler(previewProductionBillingGridView_FilterEditorCreated);
		}
		internal DevExpress.XtraBars.BarManager BarManager1;
		internal DevExpress.XtraBars.Bar customersMenuBar;
		internal DevExpress.XtraBars.BarButtonItem printBarButtonItem;
		internal DevExpress.XtraBars.Bar Bar2;
		internal DevExpress.XtraBars.Bar Bar3;
		internal DevExpress.XtraBars.BarDockControl barDockControlTop;
		internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
		internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
		internal DevExpress.XtraBars.BarDockControl barDockControlRight;
		internal DevExpress.XtraEditors.SplitContainerControl SplitContainerControl1;
		internal DevExpress.XtraGrid.GridControl quickReportsGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView quickReportsGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn reportNameGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn reportCodeNameGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn reportTypeGridColumn;
		internal DevExpress.XtraTab.XtraTabControl reportsXtraTabControl;
		internal DevExpress.XtraTab.XtraTabPage filterXtraTabPage;
		internal DevExpress.XtraTab.XtraTabPage previewCustoemrsXtraTabPage;
		internal DevExpress.XtraGrid.GridControl previewGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView previewGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn nameGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn contactNameGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn addressGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn cityGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn stateGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn postalGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn phoneGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn faxGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn emailGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn inactiveGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn filterReportGridColumn;
		internal DevExpress.XtraBars.BarButtonItem exportXLSBarButtonItem;
		internal System.Windows.Forms.SaveFileDialog exportSaveFileDialog;
		internal DevExpress.XtraGrid.Columns.GridColumn dateFilterGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn customerFilterGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn itemFilterGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn lotFilterGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn poFilterGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn machineFilterGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn shiftFilterGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn bolFilterGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn dnFilterGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn destinationFilterGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn carrierFilterGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn vendorFilterGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn itemTypeFilterGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn outOfStockFilterGridColumn;
		internal DevExpress.XtraTab.XtraTabPage previewProductionEntriesXtraTabPage;
		internal DevExpress.XtraGrid.GridControl previewProductionEntriesGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView previewProductionEntriesGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn productionDateGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn customerNameGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn itemNumberGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn itemDescriptionGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn shiftGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn quantityGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn poGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn lotGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn palletNumberGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn lpnNumberGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn expirationDateGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn expirationDateFormatGridColumn;
		internal DevExpress.XtraTab.XtraTabPage previewLpnStatusXtraTabPage;
		internal DevExpress.XtraGrid.GridControl previewLpnStatusGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView previewLpnStatusGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn lpnProductionDateGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn lpnCustomerNameGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn lpnItemCodeGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn lpnItemDescriptionGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn lpnQuantityGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn lpnShippingBolGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn fullLpnGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn lpnShippingDateGridColumn;
		internal DevExpress.XtraTab.XtraTabPage previewCurrentRMInventoryXtraTabPage;
		internal DevExpress.XtraGrid.GridControl previewCurrentRMInventoryGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView previewCurrentRMInventoryGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn rmInventoryCustomerNameGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn rmInventoryIemCodeGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn rmInventoryItemDescriptionGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn rmInventoryQtyOnHandGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn rmInventoryInactiveGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn rmInventoryItemIDGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn rmInventoryLocationGridColumn;
		internal DevExpress.XtraTab.XtraTabPage previewCurrentInventoryXtraTabPage;
		internal DevExpress.XtraGrid.GridControl previewCurrentInventoryGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView previewCurrentInventoryGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn currentInventoryCustomerNameGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn currentInventoryItemCodeGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn currentInventoryItemDescriptionGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn currentInventoryItemTypeGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn currentInventoryQuantityOnHandGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn currentInventoryInventoryByPalletsGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn currentInventoryUOMGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn currentInventoryLocationGridColumn;
		internal DevExpress.XtraEditors.SimpleButton refreshSimpleButton;
		internal DevExpress.XtraEditors.CheckEdit outOfStockItemsCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit currentInventoryInactiveItemsCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit currentInventoryInactiveCustomersCheckEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraTab.XtraTabPage previewLocationTransfersXtraTabPage;
		internal DevExpress.XtraGrid.GridControl previewLocationTransfersGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView previewLocationTransfersGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn locationTransfersDateGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn locationTransferFromLocationGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn locationTransferToLocationGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn locationTransferItemCodeGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn locationTransferItemDescriptionGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn locationTransferNumberGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn locationTransferItemLotGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn locationTransferExpirationDateGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn locationTransferQuantityGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn locationTransferExpirationDateFormatGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn locationTransferPalletsGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn locationTransferUnitsGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn locationTransferCarrierGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn noteGridColumn;
		internal DevExpress.XtraTab.XtraTabPage previewShiftScheduleXtraTabPage;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraGrid.GridControl shiftScheduleGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView shiftScheduleGridView;
		internal DevExpress.XtraEditors.SimpleButton refreshShiftScheduleSimpleButton;
		internal DevExpress.XtraEditors.ComboBoxEdit shiftScheduleShiftComboBoxEdit;
		internal DevExpress.XtraEditors.DateEdit shiftScheduleDateDateEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn shiftScheduleMachineNameGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn shiftSchedulePeopleGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn shiftScheduleOperatorGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn shiftScheduleItemCodeGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn shiftScheduleItemDescriptionGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn shiftScheduleNoteGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn shiftScheduleMustRunGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn shiftSchedulePriorityLevelGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn shiftScheduleQuantityGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn shiftScheduleSchedByQtyGridColumn;
		internal DevExpress.XtraTab.XtraTabPage previewWeeklyProductionXtraTabPage;
		internal DevExpress.XtraGrid.GridControl weeklyProductionGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView weeklyProductionGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn weeklyProductionItemCodeGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn weeklyProductionItemDescriptionGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn weeklyProductionCasesRequiredGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn weeklyProductionBagsRequiredGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn weeklyProductionMondayGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn weeklyProductionTuesdayGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn weeklyProductionWednesdayGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn weeklyProductionThursdayGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn weeklyProductionFridayGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn weeklyProductionSaturdayGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn weeklyProductionSundayGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn weeklyProductionTotalProducedGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn weeklyProductionPercentageCompleteGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn itemTypeGridColumn;
		internal DevExpress.XtraTab.XtraTabPage previewProjBomAvailXtraTabPage;
		internal DevExpress.XtraGrid.GridControl ProjBomAvailGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView ProjBomAvailGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn ProjBomAvailCustPOGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn ProjBomAvailItemCodeGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn ProjBomAvailItemDescriptionGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn ProjBomAvailItemTypeGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn ProjBomAvailQtyOnHndGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn ProjBomAvailQtyShortageGridColumn;
		internal DevExpress.XtraTab.XtraTabPage previewProductionBillingXtraTabPage;
		internal DevExpress.XtraGrid.GridControl previewProductionBillingGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView previewProductionBillingGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn productionBillingDateGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn productionBillingCustomerGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn productionBillingItemCodeGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn productionBillingItemDescriptionGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn productionBillingItemTypeGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn productionBillingShiftGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn productionBillingPOGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn productionBillingUOMGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn productionBillingQuantityGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn productionBillingCasesGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn productionBillingPriceGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn weeklyProductionProductionWeekGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn weeklyProductionTotalProducedWeeklyGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn ProjBomAvailTotalAmtNeededGridColumn;
		internal DevExpress.XtraTab.XtraTabPage previewBaggingXtraTabPage;
		internal DevExpress.XtraPivotGrid.PivotGridControl baggingReportPivotGridControl;
		internal DevExpress.Xpo.XPView baggingReportXpView;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldMachineName1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldProductionDate1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldProductionShift1;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldQuantity1;
		internal DevExpress.XtraPivotGrid.PivotGridField reasonsPivotGridField;
		internal DevExpress.XtraPivotGrid.PivotGridField minutesPivotGridField;
		internal DevExpress.XtraGrid.Columns.GridColumn ProjBomAvailLocalQtyGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn ProjBomLocalShortageGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn ProjBomAvailNonLocalQtyGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn ProjBomAvailNonLocalPalletsQtyGridColumn;
		internal DevExpress.XtraEditors.DateEdit neededBy;
		internal DevExpress.XtraEditors.LabelControl lblNededBy;
		internal DevExpress.XtraPivotGrid.PivotGridField fieldItemCode;
		internal DevExpress.XtraGrid.Columns.GridColumn ProjBomAvailCustNameGridColumn;
	}

}