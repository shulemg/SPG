using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using DevExpress.XtraEditors;
using System.Text;
using DevExpress.XtraEditors.Controls;
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
	public partial class ReportsXtraForm : DevExpress.XtraEditors.XtraForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsXtraForm));
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.reportsDockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
			this.hideContainerLeft = new DevExpress.XtraBars.Docking.AutoHideContainer();
			this.columnsDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
			this.DockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
			this.reportColumnsXtraTabControl = new DevExpress.XtraTab.XtraTabControl();
			this.productionXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.productionColumnsXtraScrollableControl = new DevExpress.XtraEditors.XtraScrollableControl();
			this.productionReasonCodeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.reportsPrintBarManager = new DevExpress.XtraPrinting.Preview.PrintBarManager(this.components);
			this.PreviewBar1 = new DevExpress.XtraPrinting.Preview.PreviewBar();
			this.PrintPreviewBarItem1 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
			this.PrintPreviewBarItem2 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
			this.PrintPreviewBarItem3 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
			this.PrintPreviewBarItem4 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
			this.PrintPreviewBarItem5 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
			this.PrintPreviewBarItem6 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
			this.PrintPreviewBarItem7 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
			this.PrintPreviewBarItem8 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
			this.PrintPreviewBarItem9 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
			this.PrintPreviewBarItem10 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
			this.PrintPreviewBarItem11 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
			this.PrintPreviewBarItem12 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
			this.PrintPreviewBarItem13 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
			this.PrintPreviewBarItem14 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
			this.ZoomBarEditItem1 = new DevExpress.XtraPrinting.Preview.ZoomBarEditItem();
			this.PrintPreviewRepositoryItemComboBox1 = new DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox();
			this.PrintPreviewBarItem15 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
			this.PrintPreviewBarItem16 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
			this.PrintPreviewBarItem17 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
			this.PrintPreviewBarItem18 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
			this.PrintPreviewBarItem19 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
			this.PrintPreviewBarItem20 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
			this.PrintPreviewBarItem21 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
			this.PrintPreviewBarItem22 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
			this.PrintPreviewBarItem23 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
			this.PrintPreviewBarItem24 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
			this.PrintPreviewBarItem25 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
			this.PreviewBar2 = new DevExpress.XtraPrinting.Preview.PreviewBar();
			this.PrintPreviewStaticItem1 = new DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem();
			this.PrintPreviewStaticItem2 = new DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem();
			this.PrintPreviewStaticItem3 = new DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem();
			this.PreviewBar3 = new DevExpress.XtraPrinting.Preview.PreviewBar();
			this.PrintPreviewSubItem1 = new DevExpress.XtraPrinting.Preview.PrintPreviewSubItem();
			this.PrintPreviewSubItem2 = new DevExpress.XtraPrinting.Preview.PrintPreviewSubItem();
			this.PrintPreviewSubItem4 = new DevExpress.XtraPrinting.Preview.PrintPreviewSubItem();
			this.PrintPreviewBarItem26 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
			this.PrintPreviewBarItem27 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarItem();
			this.BarToolbarsListItem1 = new DevExpress.XtraBars.BarToolbarsListItem();
			this.PrintPreviewSubItem3 = new DevExpress.XtraPrinting.Preview.PrintPreviewSubItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.PrintPreviewBarCheckItem1 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
			this.PrintPreviewBarCheckItem2 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
			this.PrintPreviewBarCheckItem3 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
			this.PrintPreviewBarCheckItem4 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
			this.PrintPreviewBarCheckItem5 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
			this.PrintPreviewBarCheckItem6 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
			this.PrintPreviewBarCheckItem7 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
			this.PrintPreviewBarCheckItem8 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
			this.PrintPreviewBarCheckItem9 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
			this.PrintPreviewBarCheckItem10 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
			this.PrintPreviewBarCheckItem11 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
			this.PrintPreviewBarCheckItem12 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
			this.PrintPreviewBarCheckItem13 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
			this.PrintPreviewBarCheckItem14 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
			this.PrintPreviewBarCheckItem15 = new DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem();
			this.reportsPrintControl = new DevExpress.XtraPrinting.Control.PrintControl();
			this.productionUOMCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.productionProjectedPackersCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.productionProjectedSpeedCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.productionPOCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.productionTotalPayrollCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.productionShiftCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.productionCustomerNameCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.productionLotCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.productionItemCodeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.productionItemDescriptionCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.productionStartTimeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.productionStopTimeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.productionTotalHoursCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.productionTotalMinutesCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.productionPackersCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.productionActualSpeedCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.productionDifferenceCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.productionExpectedCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.productionQuantityCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.productionMachineLineCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.productionDateCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.transportationXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.transportationXtraScrollableControl = new DevExpress.XtraEditors.XtraScrollableControl();
			this.transportationLpnCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.transportationExpirationDateCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.transportationVendorCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.transportationBolCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.transportationSealCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.transportationTrailerCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.transportationCarrierCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.transportationDestinationCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.transportationDeliveryNoteCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.transportationPOCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.transportationShiftCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.transportationCustomerCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.transportationLotCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.transportationItemCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.transportationItemDescriptionCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.transportationQuantityCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.transportationDateCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.inventoryXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.inventoryXtraScrollableControl = new DevExpress.XtraEditors.XtraScrollableControl();
			this.UOMCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.RMItemDescriptionCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.RMItemCodeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.inventoryPalletAvailabilityCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.inventoryAvailabilityCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.inventoryInventoryByPalletCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.inventoryCurrentInventoryCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.inventoryItemTypeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.inventoryAdjustmentReasonCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.inventoryAdjustmentCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.inventoryCustomerCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.inventoryItemCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.inventoryItemDescriptionCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.inventoryDateCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.itemsXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.itemsXtraScrollableControl = new DevExpress.XtraEditors.XtraScrollableControl();
			this.itemUsedInProductionCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.itemsCustomerCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.itemsItemCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.itemsItemDescriptionCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.itemsItemTypeCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.itemsUnitsOfMeasureCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.itemsQtyPerUnitCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.itemsUnitsPerCaseCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.itemsAdjustedCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.itemsShippedCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.itemsProducedCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.itemsCasesPerPalletCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.itemsReceivedCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.costingXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.costingXtraScrollableControl = new DevExpress.XtraEditors.XtraScrollableControl();
			this.costingProductionDateCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingShiftCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingCustomerCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingLotCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingItemCodeCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingItemDescriptionCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingStartTimeCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingStopTimeCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingTotalHoursCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingTotalMinutesCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingQuantityCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingExpectedCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingDifferenceCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingMachineLineCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingMachineSpeedCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingActualSpeedCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingOperatorsCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingPackersCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingSupersCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingPriceCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingPayrollCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingRebateCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingFreightCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingFilmCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingBoxesCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingStretchWrapCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingPalletsCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingTotalOtherCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingCostCheckBox = new System.Windows.Forms.CheckBox();
			this.costingProfitCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingCostPerPieceCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingPacksPerMinuteCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingSalesVsPayrollCheckEdit = new System.Windows.Forms.CheckBox();
			this.CostingSalesVsCostCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingProfitVsSalesCheckEdit = new System.Windows.Forms.CheckBox();
			this.costingSalesVsProfitCheckEdit = new System.Windows.Forms.CheckBox();
			this.productionMachineXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.productionMachineXtraScrollableControl = new DevExpress.XtraEditors.XtraScrollableControl();
			this.pmsTotalSalesCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.pmsPriceCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.pmsQuantityCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.pmsProjectedSpeedCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.pmsAverageSpeedCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.pmsSpeedVariationVolCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.pmsSpeedVariationPerCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.pmsProjectedPackersCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.pmsPackersCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.pmsPackersVariationVolCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.pmsPackersVariationPerCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.pmsSalesVsPayrollCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.pmsPricePerPieceCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.pmsCostVariationCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.pmsCostCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.pmsProjectedCostCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.pmsCostVariationPerCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.pmsTotalMinutesCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.palletTransactionXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.XtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
			this.ptReceivedCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.ptDestinationCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.ptShippedCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.ptVendorCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.columnsRefreshSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.filterDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
			this.ControlContainer1 = new DevExpress.XtraBars.Docking.ControlContainer();
			this.outOfStockCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.vendorLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.InactiveCustomersCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.InactiveItemsCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.LabelControl14 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl13 = new DevExpress.XtraEditors.LabelControl();
			this.itemTypeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.carrierLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.LabelControl12 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl11 = new DevExpress.XtraEditors.LabelControl();
			this.destinationLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.deliveryNoteNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.poTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.lotTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.bolTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.customerLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.shiftLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.machineLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.itemCheckedListBoxControl = new DevExpress.XtraEditors.CheckedListBoxControl();
			this.toDateEdit = new DevExpress.XtraEditors.DateEdit();
			this.fromDateEdit = new DevExpress.XtraEditors.DateEdit();
			this.detailSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.filterRefreshSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)this.reportsDockManager).BeginInit();
			this.hideContainerLeft.SuspendLayout();
			this.columnsDockPanel.SuspendLayout();
			this.DockPanel1_Container.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.reportColumnsXtraTabControl).BeginInit();
			this.reportColumnsXtraTabControl.SuspendLayout();
			this.productionXtraTabPage.SuspendLayout();
			this.productionColumnsXtraScrollableControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.productionReasonCodeCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.reportsPrintBarManager).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.PrintPreviewRepositoryItemComboBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionUOMCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionProjectedPackersCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionProjectedSpeedCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionPOCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionTotalPayrollCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionShiftCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionCustomerNameCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionLotCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionItemCodeCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionItemDescriptionCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionStartTimeCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionStopTimeCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionTotalHoursCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionTotalMinutesCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionPackersCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionActualSpeedCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionDifferenceCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionExpectedCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionQuantityCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionMachineLineCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionDateCheckEdit.Properties).BeginInit();
			this.transportationXtraTabPage.SuspendLayout();
			this.transportationXtraScrollableControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.transportationLpnCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.transportationExpirationDateCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.transportationVendorCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.transportationBolCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.transportationSealCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.transportationTrailerCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.transportationCarrierCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.transportationDestinationCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.transportationDeliveryNoteCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.transportationPOCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.transportationShiftCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.transportationCustomerCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.transportationLotCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.transportationItemCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.transportationItemDescriptionCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.transportationQuantityCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.transportationDateCheckEdit.Properties).BeginInit();
			this.inventoryXtraTabPage.SuspendLayout();
			this.inventoryXtraScrollableControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.UOMCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.RMItemDescriptionCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.RMItemCodeCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryPalletAvailabilityCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryAvailabilityCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryInventoryByPalletCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryCurrentInventoryCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryItemTypeCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryAdjustmentReasonCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryAdjustmentCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryCustomerCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryItemCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryItemDescriptionCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryDateCheckEdit.Properties).BeginInit();
			this.itemsXtraTabPage.SuspendLayout();
			this.itemsXtraScrollableControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.itemUsedInProductionCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemsCustomerCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemsItemCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemsItemDescriptionCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemsItemTypeCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemsUnitsOfMeasureCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemsQtyPerUnitCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemsUnitsPerCaseCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemsAdjustedCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemsShippedCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemsProducedCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemsCasesPerPalletCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemsReceivedCheckEdit.Properties).BeginInit();
			this.costingXtraTabPage.SuspendLayout();
			this.costingXtraScrollableControl.SuspendLayout();
			this.productionMachineXtraTabPage.SuspendLayout();
			this.productionMachineXtraScrollableControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.pmsTotalSalesCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pmsPriceCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pmsQuantityCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pmsProjectedSpeedCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pmsAverageSpeedCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pmsSpeedVariationVolCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pmsSpeedVariationPerCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pmsProjectedPackersCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pmsPackersCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pmsPackersVariationVolCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pmsPackersVariationPerCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pmsSalesVsPayrollCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pmsPricePerPieceCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pmsCostVariationCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pmsCostCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pmsProjectedCostCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pmsCostVariationPerCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.pmsTotalMinutesCheckEdit.Properties).BeginInit();
			this.palletTransactionXtraTabPage.SuspendLayout();
			this.XtraScrollableControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.ptReceivedCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.ptDestinationCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.ptShippedCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.ptVendorCheckEdit.Properties).BeginInit();
			this.filterDockPanel.SuspendLayout();
			this.ControlContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.outOfStockCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.vendorLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.InactiveCustomersCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.InactiveItemsCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemTypeLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.carrierLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.destinationLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.deliveryNoteNumberTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.poTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.lotTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.bolTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customerLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shiftLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.machineLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemCheckedListBoxControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.toDateEdit.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.toDateEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.fromDateEdit.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.fromDateEdit.Properties).BeginInit();
			this.SuspendLayout();
			//
			//LabelControl2
			//
			this.LabelControl2.Location = new System.Drawing.Point(4, 64);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(28, 13);
			this.LabelControl2.TabIndex = 6;
			this.LabelControl2.Text = "From:";
			//
			//LabelControl6
			//
			this.LabelControl6.Location = new System.Drawing.Point(4, 192);
			this.LabelControl6.Name = "LabelControl6";
			this.LabelControl6.Size = new System.Drawing.Size(50, 13);
			this.LabelControl6.TabIndex = 10;
			this.LabelControl6.Text = "Customer:";
			//
			//LabelControl5
			//
			this.LabelControl5.Location = new System.Drawing.Point(3, 472);
			this.LabelControl5.Name = "LabelControl5";
			this.LabelControl5.Size = new System.Drawing.Size(26, 13);
			this.LabelControl5.TabIndex = 9;
			this.LabelControl5.Text = "Item:";
			//
			//LabelControl4
			//
			this.LabelControl4.Location = new System.Drawing.Point(4, 142);
			this.LabelControl4.Name = "LabelControl4";
			this.LabelControl4.Size = new System.Drawing.Size(26, 13);
			this.LabelControl4.TabIndex = 8;
			this.LabelControl4.Text = "Shift:";
			//
			//LabelControl3
			//
			this.LabelControl3.Location = new System.Drawing.Point(4, 116);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(43, 13);
			this.LabelControl3.TabIndex = 7;
			this.LabelControl3.Text = "Machine:";
			//
			//LabelControl1
			//
			this.LabelControl1.Location = new System.Drawing.Point(4, 91);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(16, 13);
			this.LabelControl1.TabIndex = 5;
			this.LabelControl1.Text = "To:";
			//
			//reportsDockManager
			//
			this.reportsDockManager.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {this.hideContainerLeft});
			this.reportsDockManager.DockingOptions.ShowCloseButton = false;
			this.reportsDockManager.DockingOptions.ShowMaximizeButton = false;
			this.reportsDockManager.Form = this;
			this.reportsDockManager.MenuManager = this.reportsPrintBarManager;
			this.reportsDockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {this.filterDockPanel});
			this.reportsDockManager.TopZIndexControls.AddRange(new string[] {"DevExpress.XtraBars.BarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"});
			//
			//hideContainerLeft
			//
			this.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb((int)((byte)235), (int)((byte)236), (int)((byte)239));
			this.hideContainerLeft.Controls.Add(this.columnsDockPanel);
			this.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.hideContainerLeft.Location = new System.Drawing.Point(0, 53);
			this.hideContainerLeft.Name = "hideContainerLeft";
			this.hideContainerLeft.Size = new System.Drawing.Size(19, 526);
			//
			//columnsDockPanel
			//
			this.columnsDockPanel.AutoScroll = true;
			this.columnsDockPanel.Controls.Add(this.DockPanel1_Container);
			this.columnsDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
			this.columnsDockPanel.ID = new System.Guid("08c3238e-2314-48e1-bd63-74c1aaf39076");
			this.columnsDockPanel.Location = new System.Drawing.Point(0, 0);
			this.columnsDockPanel.Name = "columnsDockPanel";
			this.columnsDockPanel.Options.AllowDockBottom = false;
			this.columnsDockPanel.Options.AllowDockFill = false;
			this.columnsDockPanel.Options.AllowDockTop = false;
			this.columnsDockPanel.Options.ShowCloseButton = false;
			this.columnsDockPanel.Options.ShowMaximizeButton = false;
			this.columnsDockPanel.OriginalSize = new System.Drawing.Size(200, 200);
			this.columnsDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
			this.columnsDockPanel.SavedIndex = 0;
			this.columnsDockPanel.Size = new System.Drawing.Size(200, 526);
			this.columnsDockPanel.Text = "Show/Hide Columns";
			this.columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
			//
			//DockPanel1_Container
			//
			this.DockPanel1_Container.Controls.Add(this.reportColumnsXtraTabControl);
			this.DockPanel1_Container.Controls.Add(this.columnsRefreshSimpleButton);
			this.DockPanel1_Container.Location = new System.Drawing.Point(4, 23);
			this.DockPanel1_Container.Name = "DockPanel1_Container";
			this.DockPanel1_Container.Size = new System.Drawing.Size(191, 499);
			this.DockPanel1_Container.TabIndex = 0;
			//
			//reportColumnsXtraTabControl
			//
			this.reportColumnsXtraTabControl.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.reportColumnsXtraTabControl.Location = new System.Drawing.Point(0, 33);
			this.reportColumnsXtraTabControl.Name = "reportColumnsXtraTabControl";
			this.reportColumnsXtraTabControl.SelectedTabPage = this.productionXtraTabPage;
			this.reportColumnsXtraTabControl.Size = new System.Drawing.Size(191, 499);
			this.reportColumnsXtraTabControl.TabIndex = 2;
			this.reportColumnsXtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {this.productionXtraTabPage, this.transportationXtraTabPage, this.inventoryXtraTabPage, this.itemsXtraTabPage, this.costingXtraTabPage, this.productionMachineXtraTabPage, this.palletTransactionXtraTabPage});
			//
			//productionXtraTabPage
			//
			this.productionXtraTabPage.Controls.Add(this.productionColumnsXtraScrollableControl);
			this.productionXtraTabPage.Name = "productionXtraTabPage";
			this.productionXtraTabPage.Size = new System.Drawing.Size(185, 471);
			this.productionXtraTabPage.Text = "Production";
			//
			//productionColumnsXtraScrollableControl
			//
			this.productionColumnsXtraScrollableControl.Controls.Add(this.productionReasonCodeCheckEdit);
			this.productionColumnsXtraScrollableControl.Controls.Add(this.productionUOMCheckEdit);
			this.productionColumnsXtraScrollableControl.Controls.Add(this.productionProjectedPackersCheckEdit);
			this.productionColumnsXtraScrollableControl.Controls.Add(this.productionProjectedSpeedCheckEdit);
			this.productionColumnsXtraScrollableControl.Controls.Add(this.productionPOCheckEdit);
			this.productionColumnsXtraScrollableControl.Controls.Add(this.productionTotalPayrollCheckEdit);
			this.productionColumnsXtraScrollableControl.Controls.Add(this.productionShiftCheckEdit);
			this.productionColumnsXtraScrollableControl.Controls.Add(this.productionCustomerNameCheckEdit);
			this.productionColumnsXtraScrollableControl.Controls.Add(this.productionLotCheckEdit);
			this.productionColumnsXtraScrollableControl.Controls.Add(this.productionItemCodeCheckEdit);
			this.productionColumnsXtraScrollableControl.Controls.Add(this.productionItemDescriptionCheckEdit);
			this.productionColumnsXtraScrollableControl.Controls.Add(this.productionStartTimeCheckEdit);
			this.productionColumnsXtraScrollableControl.Controls.Add(this.productionStopTimeCheckEdit);
			this.productionColumnsXtraScrollableControl.Controls.Add(this.productionTotalHoursCheckEdit);
			this.productionColumnsXtraScrollableControl.Controls.Add(this.productionTotalMinutesCheckEdit);
			this.productionColumnsXtraScrollableControl.Controls.Add(this.productionPackersCheckEdit);
			this.productionColumnsXtraScrollableControl.Controls.Add(this.productionActualSpeedCheckEdit);
			this.productionColumnsXtraScrollableControl.Controls.Add(this.productionDifferenceCheckEdit);
			this.productionColumnsXtraScrollableControl.Controls.Add(this.productionExpectedCheckEdit);
			this.productionColumnsXtraScrollableControl.Controls.Add(this.productionQuantityCheckEdit);
			this.productionColumnsXtraScrollableControl.Controls.Add(this.productionMachineLineCheckEdit);
			this.productionColumnsXtraScrollableControl.Controls.Add(this.productionDateCheckEdit);
			this.productionColumnsXtraScrollableControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.productionColumnsXtraScrollableControl.Location = new System.Drawing.Point(0, 0);
			this.productionColumnsXtraScrollableControl.Name = "productionColumnsXtraScrollableControl";
			this.productionColumnsXtraScrollableControl.Size = new System.Drawing.Size(185, 471);
			this.productionColumnsXtraScrollableControl.TabIndex = 1;
			//
			//productionReasonCodeCheckEdit
			//
			this.productionReasonCodeCheckEdit.EditValue = true;
			this.productionReasonCodeCheckEdit.Location = new System.Drawing.Point(4, 365);
			this.productionReasonCodeCheckEdit.MenuManager = this.reportsPrintBarManager;
			this.productionReasonCodeCheckEdit.Name = "productionReasonCodeCheckEdit";
			this.productionReasonCodeCheckEdit.Properties.Caption = "Reason Codes";
			this.productionReasonCodeCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.productionReasonCodeCheckEdit.TabIndex = 24;
			//
			//reportsPrintBarManager
			//
			this.reportsPrintBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.PreviewBar1, this.PreviewBar2, this.PreviewBar3});
			this.reportsPrintBarManager.DockControls.Add(this.barDockControlTop);
			this.reportsPrintBarManager.DockControls.Add(this.barDockControlBottom);
			this.reportsPrintBarManager.DockControls.Add(this.barDockControlLeft);
			this.reportsPrintBarManager.DockControls.Add(this.barDockControlRight);
			this.reportsPrintBarManager.DockManager = this.reportsDockManager;
			this.reportsPrintBarManager.Form = this;
			this.reportsPrintBarManager.ImageStream = (DevExpress.Utils.ImageCollectionStreamer)resources.GetObject("reportsPrintBarManager.ImageStream");
			this.reportsPrintBarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.PrintPreviewStaticItem1, this.PrintPreviewStaticItem2, this.PrintPreviewStaticItem3, this.PrintPreviewBarItem1, this.PrintPreviewBarItem2, this.PrintPreviewBarItem3, this.PrintPreviewBarItem4, this.PrintPreviewBarItem5, this.PrintPreviewBarItem6, this.PrintPreviewBarItem7, this.PrintPreviewBarItem8, this.PrintPreviewBarItem9, this.PrintPreviewBarItem10, this.PrintPreviewBarItem11, this.PrintPreviewBarItem12, this.PrintPreviewBarItem13, this.PrintPreviewBarItem14, this.ZoomBarEditItem1, this.PrintPreviewBarItem15, this.PrintPreviewBarItem16, this.PrintPreviewBarItem17, this.PrintPreviewBarItem18, this.PrintPreviewBarItem19, this.PrintPreviewBarItem20, this.PrintPreviewBarItem21, this.PrintPreviewBarItem22, this.PrintPreviewBarItem23, this.PrintPreviewBarItem24, this.PrintPreviewBarItem25, this.PrintPreviewSubItem1, this.PrintPreviewSubItem2, this.PrintPreviewSubItem3, this.PrintPreviewSubItem4, this.PrintPreviewBarItem26, this.PrintPreviewBarItem27, this.BarToolbarsListItem1, this.PrintPreviewBarCheckItem1, this.PrintPreviewBarCheckItem2, this.PrintPreviewBarCheckItem3, this.PrintPreviewBarCheckItem4, this.PrintPreviewBarCheckItem5, this.PrintPreviewBarCheckItem6, this.PrintPreviewBarCheckItem7, this.PrintPreviewBarCheckItem8, this.PrintPreviewBarCheckItem9, this.PrintPreviewBarCheckItem10, this.PrintPreviewBarCheckItem11, this.PrintPreviewBarCheckItem12, this.PrintPreviewBarCheckItem13, this.PrintPreviewBarCheckItem14, this.PrintPreviewBarCheckItem15});
			this.reportsPrintBarManager.MainMenu = this.PreviewBar3;
			this.reportsPrintBarManager.MaxItemId = 51;
			this.reportsPrintBarManager.PreviewBar = this.PreviewBar1;
			this.reportsPrintBarManager.PrintControl = this.reportsPrintControl;
			this.reportsPrintBarManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {this.PrintPreviewRepositoryItemComboBox1});
			this.reportsPrintBarManager.StatusBar = this.PreviewBar2;
			//
			//PreviewBar1
			//
			this.PreviewBar1.BarName = "Toolbar";
			this.PreviewBar1.DockCol = 0;
			this.PreviewBar1.DockRow = 1;
			this.PreviewBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.PreviewBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem2),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem3),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem4, true),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem5, true),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem6),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem7, true),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem8),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem9),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem10),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem11),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem12, true),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem13),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem14, true),
				new DevExpress.XtraBars.LinkPersistInfo(this.ZoomBarEditItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem15),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem16, true),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem17),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem18),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem19),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem20, true),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem21),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem22),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem23, true),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem24),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem25, true)
			});
			this.PreviewBar1.Text = "Toolbar";
			//
			//PrintPreviewBarItem1
			//
			this.PrintPreviewBarItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
			this.PrintPreviewBarItem1.Caption = "Document Map";
			this.PrintPreviewBarItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.DocumentMap;
			this.PrintPreviewBarItem1.Enabled = false;
			this.PrintPreviewBarItem1.Hint = "Document Map";
			this.PrintPreviewBarItem1.Id = 3;
			this.PrintPreviewBarItem1.ImageOptions.ImageIndex = 19;
			this.PrintPreviewBarItem1.Name = "PrintPreviewBarItem1";
			//
			//PrintPreviewBarItem2
			//
			this.PrintPreviewBarItem2.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
			this.PrintPreviewBarItem2.Caption = "Parameters";
			this.PrintPreviewBarItem2.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Parameters;
			this.PrintPreviewBarItem2.Enabled = false;
			this.PrintPreviewBarItem2.Hint = "Parameters";
			this.PrintPreviewBarItem2.Id = 4;
			this.PrintPreviewBarItem2.ImageOptions.ImageIndex = 22;
			this.PrintPreviewBarItem2.Name = "PrintPreviewBarItem2";
			//
			//PrintPreviewBarItem3
			//
			this.PrintPreviewBarItem3.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
			this.PrintPreviewBarItem3.Caption = "Search";
			this.PrintPreviewBarItem3.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Find;
			this.PrintPreviewBarItem3.Enabled = false;
			this.PrintPreviewBarItem3.Hint = "Search";
			this.PrintPreviewBarItem3.Id = 5;
			this.PrintPreviewBarItem3.ImageOptions.ImageIndex = 20;
			this.PrintPreviewBarItem3.Name = "PrintPreviewBarItem3";
			//
			//PrintPreviewBarItem4
			//
			this.PrintPreviewBarItem4.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
			this.PrintPreviewBarItem4.Caption = "Customize";
			this.PrintPreviewBarItem4.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Customize;
			this.PrintPreviewBarItem4.Enabled = false;
			this.PrintPreviewBarItem4.Hint = "Customize";
			this.PrintPreviewBarItem4.Id = 6;
			this.PrintPreviewBarItem4.ImageOptions.ImageIndex = 14;
			this.PrintPreviewBarItem4.Name = "PrintPreviewBarItem4";
			//
			//PrintPreviewBarItem5
			//
			this.PrintPreviewBarItem5.Caption = "Open";
			this.PrintPreviewBarItem5.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Open;
			this.PrintPreviewBarItem5.Enabled = false;
			this.PrintPreviewBarItem5.Hint = "Open a document";
			this.PrintPreviewBarItem5.Id = 7;
			this.PrintPreviewBarItem5.ImageOptions.ImageIndex = 23;
			this.PrintPreviewBarItem5.Name = "PrintPreviewBarItem5";
			//
			//PrintPreviewBarItem6
			//
			this.PrintPreviewBarItem6.Caption = "Save";
			this.PrintPreviewBarItem6.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Save;
			this.PrintPreviewBarItem6.Enabled = false;
			this.PrintPreviewBarItem6.Hint = "Save the document";
			this.PrintPreviewBarItem6.Id = 8;
			this.PrintPreviewBarItem6.ImageOptions.ImageIndex = 24;
			this.PrintPreviewBarItem6.Name = "PrintPreviewBarItem6";
			//
			//PrintPreviewBarItem7
			//
			this.PrintPreviewBarItem7.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
			this.PrintPreviewBarItem7.Caption = "&Print...";
			this.PrintPreviewBarItem7.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Print;
			this.PrintPreviewBarItem7.Enabled = false;
			this.PrintPreviewBarItem7.Hint = "Print";
			this.PrintPreviewBarItem7.Id = 9;
			this.PrintPreviewBarItem7.ImageOptions.ImageIndex = 0;
			this.PrintPreviewBarItem7.Name = "PrintPreviewBarItem7";
			//
			//PrintPreviewBarItem8
			//
			this.PrintPreviewBarItem8.Caption = "P&rint";
			this.PrintPreviewBarItem8.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect;
			this.PrintPreviewBarItem8.Enabled = false;
			this.PrintPreviewBarItem8.Hint = "Quick Print";
			this.PrintPreviewBarItem8.Id = 10;
			this.PrintPreviewBarItem8.ImageOptions.ImageIndex = 1;
			this.PrintPreviewBarItem8.Name = "PrintPreviewBarItem8";
			//
			//PrintPreviewBarItem9
			//
			this.PrintPreviewBarItem9.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
			this.PrintPreviewBarItem9.Caption = "Page Set&up...";
			this.PrintPreviewBarItem9.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageSetup;
			this.PrintPreviewBarItem9.Enabled = false;
			this.PrintPreviewBarItem9.Hint = "Page Setup";
			this.PrintPreviewBarItem9.Id = 11;
			this.PrintPreviewBarItem9.ImageOptions.ImageIndex = 2;
			this.PrintPreviewBarItem9.Name = "PrintPreviewBarItem9";
			//
			//PrintPreviewBarItem10
			//
			this.PrintPreviewBarItem10.Caption = "Header And Footer";
			this.PrintPreviewBarItem10.Command = DevExpress.XtraPrinting.PrintingSystemCommand.EditPageHF;
			this.PrintPreviewBarItem10.Enabled = false;
			this.PrintPreviewBarItem10.Hint = "Header And Footer";
			this.PrintPreviewBarItem10.Id = 12;
			this.PrintPreviewBarItem10.ImageOptions.ImageIndex = 15;
			this.PrintPreviewBarItem10.Name = "PrintPreviewBarItem10";
			//
			//PrintPreviewBarItem11
			//
			this.PrintPreviewBarItem11.ActAsDropDown = true;
			this.PrintPreviewBarItem11.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
			this.PrintPreviewBarItem11.Caption = "Scale";
			this.PrintPreviewBarItem11.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Scale;
			this.PrintPreviewBarItem11.Enabled = false;
			this.PrintPreviewBarItem11.Hint = "Scale";
			this.PrintPreviewBarItem11.Id = 13;
			this.PrintPreviewBarItem11.ImageOptions.ImageIndex = 25;
			this.PrintPreviewBarItem11.Name = "PrintPreviewBarItem11";
			//
			//PrintPreviewBarItem12
			//
			this.PrintPreviewBarItem12.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
			this.PrintPreviewBarItem12.Caption = "Hand Tool";
			this.PrintPreviewBarItem12.Command = DevExpress.XtraPrinting.PrintingSystemCommand.HandTool;
			this.PrintPreviewBarItem12.Enabled = false;
			this.PrintPreviewBarItem12.Hint = "Hand Tool";
			this.PrintPreviewBarItem12.Id = 14;
			this.PrintPreviewBarItem12.ImageOptions.ImageIndex = 16;
			this.PrintPreviewBarItem12.Name = "PrintPreviewBarItem12";
			//
			//PrintPreviewBarItem13
			//
			this.PrintPreviewBarItem13.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
			this.PrintPreviewBarItem13.Caption = "Magnifier";
			this.PrintPreviewBarItem13.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Magnifier;
			this.PrintPreviewBarItem13.Enabled = false;
			this.PrintPreviewBarItem13.Hint = "Magnifier";
			this.PrintPreviewBarItem13.Id = 15;
			this.PrintPreviewBarItem13.ImageOptions.ImageIndex = 3;
			this.PrintPreviewBarItem13.Name = "PrintPreviewBarItem13";
			//
			//PrintPreviewBarItem14
			//
			this.PrintPreviewBarItem14.Caption = "Zoom Out";
			this.PrintPreviewBarItem14.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomOut;
			this.PrintPreviewBarItem14.Enabled = false;
			this.PrintPreviewBarItem14.Hint = "Zoom Out";
			this.PrintPreviewBarItem14.Id = 16;
			this.PrintPreviewBarItem14.ImageOptions.ImageIndex = 5;
			this.PrintPreviewBarItem14.Name = "PrintPreviewBarItem14";
			//
			//ZoomBarEditItem1
			//
			this.ZoomBarEditItem1.Caption = "Zoom";
			this.ZoomBarEditItem1.Edit = this.PrintPreviewRepositoryItemComboBox1;
			this.ZoomBarEditItem1.EditValue = "100%";
			this.ZoomBarEditItem1.EditWidth = 70;
			this.ZoomBarEditItem1.Enabled = false;
			this.ZoomBarEditItem1.Hint = "Zoom";
			this.ZoomBarEditItem1.Id = 17;
			this.ZoomBarEditItem1.Name = "ZoomBarEditItem1";
			//
			//PrintPreviewRepositoryItemComboBox1
			//
			this.PrintPreviewRepositoryItemComboBox1.AutoComplete = false;
			this.PrintPreviewRepositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.PrintPreviewRepositoryItemComboBox1.DropDownRows = 11;
			this.PrintPreviewRepositoryItemComboBox1.Name = "PrintPreviewRepositoryItemComboBox1";
			//
			//PrintPreviewBarItem15
			//
			this.PrintPreviewBarItem15.Caption = "Zoom In";
			this.PrintPreviewBarItem15.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ZoomIn;
			this.PrintPreviewBarItem15.Enabled = false;
			this.PrintPreviewBarItem15.Hint = "Zoom In";
			this.PrintPreviewBarItem15.Id = 18;
			this.PrintPreviewBarItem15.ImageOptions.ImageIndex = 4;
			this.PrintPreviewBarItem15.Name = "PrintPreviewBarItem15";
			//
			//PrintPreviewBarItem16
			//
			this.PrintPreviewBarItem16.Caption = "First Page";
			this.PrintPreviewBarItem16.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowFirstPage;
			this.PrintPreviewBarItem16.Enabled = false;
			this.PrintPreviewBarItem16.Hint = "First Page";
			this.PrintPreviewBarItem16.Id = 19;
			this.PrintPreviewBarItem16.ImageOptions.ImageIndex = 7;
			this.PrintPreviewBarItem16.Name = "PrintPreviewBarItem16";
			//
			//PrintPreviewBarItem17
			//
			this.PrintPreviewBarItem17.Caption = "Previous Page";
			this.PrintPreviewBarItem17.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowPrevPage;
			this.PrintPreviewBarItem17.Enabled = false;
			this.PrintPreviewBarItem17.Hint = "Previous Page";
			this.PrintPreviewBarItem17.Id = 20;
			this.PrintPreviewBarItem17.ImageOptions.ImageIndex = 8;
			this.PrintPreviewBarItem17.Name = "PrintPreviewBarItem17";
			//
			//PrintPreviewBarItem18
			//
			this.PrintPreviewBarItem18.Caption = "Next Page";
			this.PrintPreviewBarItem18.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowNextPage;
			this.PrintPreviewBarItem18.Enabled = false;
			this.PrintPreviewBarItem18.Hint = "Next Page";
			this.PrintPreviewBarItem18.Id = 21;
			this.PrintPreviewBarItem18.ImageOptions.ImageIndex = 9;
			this.PrintPreviewBarItem18.Name = "PrintPreviewBarItem18";
			//
			//PrintPreviewBarItem19
			//
			this.PrintPreviewBarItem19.Caption = "Last Page";
			this.PrintPreviewBarItem19.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ShowLastPage;
			this.PrintPreviewBarItem19.Enabled = false;
			this.PrintPreviewBarItem19.Hint = "Last Page";
			this.PrintPreviewBarItem19.Id = 22;
			this.PrintPreviewBarItem19.ImageOptions.ImageIndex = 10;
			this.PrintPreviewBarItem19.Name = "PrintPreviewBarItem19";
			//
			//PrintPreviewBarItem20
			//
			this.PrintPreviewBarItem20.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
			this.PrintPreviewBarItem20.Caption = "Multiple Pages";
			this.PrintPreviewBarItem20.Command = DevExpress.XtraPrinting.PrintingSystemCommand.MultiplePages;
			this.PrintPreviewBarItem20.Enabled = false;
			this.PrintPreviewBarItem20.Hint = "Multiple Pages";
			this.PrintPreviewBarItem20.Id = 23;
			this.PrintPreviewBarItem20.ImageOptions.ImageIndex = 11;
			this.PrintPreviewBarItem20.Name = "PrintPreviewBarItem20";
			//
			//PrintPreviewBarItem21
			//
			this.PrintPreviewBarItem21.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
			this.PrintPreviewBarItem21.Caption = "&Color...";
			this.PrintPreviewBarItem21.Command = DevExpress.XtraPrinting.PrintingSystemCommand.FillBackground;
			this.PrintPreviewBarItem21.Enabled = false;
			this.PrintPreviewBarItem21.Hint = "Background";
			this.PrintPreviewBarItem21.Id = 24;
			this.PrintPreviewBarItem21.ImageOptions.ImageIndex = 12;
			this.PrintPreviewBarItem21.Name = "PrintPreviewBarItem21";
			//
			//PrintPreviewBarItem22
			//
			this.PrintPreviewBarItem22.Caption = "&Watermark...";
			this.PrintPreviewBarItem22.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Watermark;
			this.PrintPreviewBarItem22.Enabled = false;
			this.PrintPreviewBarItem22.Hint = "Watermark";
			this.PrintPreviewBarItem22.Id = 25;
			this.PrintPreviewBarItem22.ImageOptions.ImageIndex = 21;
			this.PrintPreviewBarItem22.Name = "PrintPreviewBarItem22";
			//
			//PrintPreviewBarItem23
			//
			this.PrintPreviewBarItem23.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
			this.PrintPreviewBarItem23.Caption = "Export Document...";
			this.PrintPreviewBarItem23.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportFile;
			this.PrintPreviewBarItem23.Enabled = false;
			this.PrintPreviewBarItem23.Hint = "Export Document...";
			this.PrintPreviewBarItem23.Id = 26;
			this.PrintPreviewBarItem23.ImageOptions.ImageIndex = 18;
			this.PrintPreviewBarItem23.Name = "PrintPreviewBarItem23";
			//
			//PrintPreviewBarItem24
			//
			this.PrintPreviewBarItem24.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
			this.PrintPreviewBarItem24.Caption = "Send via E-Mail...";
			this.PrintPreviewBarItem24.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendFile;
			this.PrintPreviewBarItem24.Enabled = false;
			this.PrintPreviewBarItem24.Hint = "Send via E-Mail...";
			this.PrintPreviewBarItem24.Id = 27;
			this.PrintPreviewBarItem24.ImageOptions.ImageIndex = 17;
			this.PrintPreviewBarItem24.Name = "PrintPreviewBarItem24";
			//
			//PrintPreviewBarItem25
			//
			this.PrintPreviewBarItem25.Caption = "E&xit";
			this.PrintPreviewBarItem25.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ClosePreview;
			this.PrintPreviewBarItem25.Enabled = false;
			this.PrintPreviewBarItem25.Hint = "Close Preview";
			this.PrintPreviewBarItem25.Id = 28;
			this.PrintPreviewBarItem25.ImageOptions.ImageIndex = 13;
			this.PrintPreviewBarItem25.Name = "PrintPreviewBarItem25";
			//
			//PreviewBar2
			//
			this.PreviewBar2.BarName = "Status Bar";
			this.PreviewBar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			this.PreviewBar2.DockCol = 0;
			this.PreviewBar2.DockRow = 0;
			this.PreviewBar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			this.PreviewBar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewStaticItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewStaticItem2),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewStaticItem3)
			});
			this.PreviewBar2.OptionsBar.AllowQuickCustomization = false;
			this.PreviewBar2.OptionsBar.DrawDragBorder = false;
			this.PreviewBar2.OptionsBar.UseWholeRow = true;
			this.PreviewBar2.Text = "Status Bar";
			//
			//PrintPreviewStaticItem1
			//
			this.PrintPreviewStaticItem1.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
			this.PrintPreviewStaticItem1.Caption = "Current Page: none";
			this.PrintPreviewStaticItem1.Id = 0;
			this.PrintPreviewStaticItem1.Name = "PrintPreviewStaticItem1";
			this.PrintPreviewStaticItem1.Size = new System.Drawing.Size(200, 0);
			this.PrintPreviewStaticItem1.Type = "CurrentPageNo";
			this.PrintPreviewStaticItem1.Width = 200;
			//
			//PrintPreviewStaticItem2
			//
			this.PrintPreviewStaticItem2.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
			this.PrintPreviewStaticItem2.Caption = "Total Pages: 0";
			this.PrintPreviewStaticItem2.Id = 1;
			this.PrintPreviewStaticItem2.Name = "PrintPreviewStaticItem2";
			this.PrintPreviewStaticItem2.Size = new System.Drawing.Size(200, 0);
			this.PrintPreviewStaticItem2.Type = "TotalPageNo";
			this.PrintPreviewStaticItem2.Width = 200;
			//
			//PrintPreviewStaticItem3
			//
			this.PrintPreviewStaticItem3.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
			this.PrintPreviewStaticItem3.Caption = "100%";
			this.PrintPreviewStaticItem3.Id = 2;
			this.PrintPreviewStaticItem3.Name = "PrintPreviewStaticItem3";
			this.PrintPreviewStaticItem3.Size = new System.Drawing.Size(200, 0);
			this.PrintPreviewStaticItem3.Type = "ZoomFactor";
			this.PrintPreviewStaticItem3.Width = 200;
			//
			//PreviewBar3
			//
			this.PreviewBar3.BarName = "Main Menu";
			this.PreviewBar3.DockCol = 0;
			this.PreviewBar3.DockRow = 0;
			this.PreviewBar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.PreviewBar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewSubItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewSubItem2),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewSubItem3)
			});
			this.PreviewBar3.OptionsBar.MultiLine = true;
			this.PreviewBar3.OptionsBar.UseWholeRow = true;
			this.PreviewBar3.Text = "Main Menu";
			//
			//PrintPreviewSubItem1
			//
			this.PrintPreviewSubItem1.Caption = "&File";
			this.PrintPreviewSubItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.File;
			this.PrintPreviewSubItem1.Id = 29;
			this.PrintPreviewSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem9),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem7),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem8),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem23, true),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem24),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem25, true)
			});
			this.PrintPreviewSubItem1.Name = "PrintPreviewSubItem1";
			//
			//PrintPreviewSubItem2
			//
			this.PrintPreviewSubItem2.Caption = "&View";
			this.PrintPreviewSubItem2.Command = DevExpress.XtraPrinting.PrintingSystemCommand.View;
			this.PrintPreviewSubItem2.Id = 30;
			this.PrintPreviewSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewSubItem4, true),
				new DevExpress.XtraBars.LinkPersistInfo(this.BarToolbarsListItem1, true)
			});
			this.PrintPreviewSubItem2.Name = "PrintPreviewSubItem2";
			//
			//PrintPreviewSubItem4
			//
			this.PrintPreviewSubItem4.Caption = "&Page Layout";
			this.PrintPreviewSubItem4.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayout;
			this.PrintPreviewSubItem4.Id = 32;
			this.PrintPreviewSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem26),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem27)
			});
			this.PrintPreviewSubItem4.Name = "PrintPreviewSubItem4";
			//
			//PrintPreviewBarItem26
			//
			this.PrintPreviewBarItem26.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
			this.PrintPreviewBarItem26.Caption = "&Facing";
			this.PrintPreviewBarItem26.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayoutFacing;
			this.PrintPreviewBarItem26.Enabled = false;
			this.PrintPreviewBarItem26.GroupIndex = 100;
			this.PrintPreviewBarItem26.Id = 33;
			this.PrintPreviewBarItem26.Name = "PrintPreviewBarItem26";
			//
			//PrintPreviewBarItem27
			//
			this.PrintPreviewBarItem27.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
			this.PrintPreviewBarItem27.Caption = "&Continuous";
			this.PrintPreviewBarItem27.Command = DevExpress.XtraPrinting.PrintingSystemCommand.PageLayoutContinuous;
			this.PrintPreviewBarItem27.Enabled = false;
			this.PrintPreviewBarItem27.GroupIndex = 100;
			this.PrintPreviewBarItem27.Id = 34;
			this.PrintPreviewBarItem27.Name = "PrintPreviewBarItem27";
			//
			//BarToolbarsListItem1
			//
			this.BarToolbarsListItem1.Caption = "Bars";
			this.BarToolbarsListItem1.Id = 35;
			this.BarToolbarsListItem1.Name = "BarToolbarsListItem1";
			//
			//PrintPreviewSubItem3
			//
			this.PrintPreviewSubItem3.Caption = "&Background";
			this.PrintPreviewSubItem3.Command = DevExpress.XtraPrinting.PrintingSystemCommand.Background;
			this.PrintPreviewSubItem3.Id = 31;
			this.PrintPreviewSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem21),
				new DevExpress.XtraBars.LinkPersistInfo(this.PrintPreviewBarItem22)
			});
			this.PrintPreviewSubItem3.Name = "PrintPreviewSubItem3";
			//
			//barDockControlTop
			//
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.reportsPrintBarManager;
			this.barDockControlTop.Size = new System.Drawing.Size(734, 53);
			//
			//barDockControlBottom
			//
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 579);
			this.barDockControlBottom.Manager = this.reportsPrintBarManager;
			this.barDockControlBottom.Size = new System.Drawing.Size(734, 25);
			//
			//barDockControlLeft
			//
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 53);
			this.barDockControlLeft.Manager = this.reportsPrintBarManager;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 526);
			//
			//barDockControlRight
			//
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(734, 53);
			this.barDockControlRight.Manager = this.reportsPrintBarManager;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 526);
			//
			//PrintPreviewBarCheckItem1
			//
			this.PrintPreviewBarCheckItem1.BindableChecked = true;
			this.PrintPreviewBarCheckItem1.Caption = "PDF File";
			this.PrintPreviewBarCheckItem1.Checked = true;
			this.PrintPreviewBarCheckItem1.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportPdf;
			this.PrintPreviewBarCheckItem1.Enabled = false;
			this.PrintPreviewBarCheckItem1.GroupIndex = 2;
			this.PrintPreviewBarCheckItem1.Hint = "PDF File";
			this.PrintPreviewBarCheckItem1.Id = 36;
			this.PrintPreviewBarCheckItem1.Name = "PrintPreviewBarCheckItem1";
			//
			//PrintPreviewBarCheckItem2
			//
			this.PrintPreviewBarCheckItem2.Caption = "HTML File";
			this.PrintPreviewBarCheckItem2.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportHtm;
			this.PrintPreviewBarCheckItem2.Enabled = false;
			this.PrintPreviewBarCheckItem2.GroupIndex = 2;
			this.PrintPreviewBarCheckItem2.Hint = "HTML File";
			this.PrintPreviewBarCheckItem2.Id = 37;
			this.PrintPreviewBarCheckItem2.Name = "PrintPreviewBarCheckItem2";
			//
			//PrintPreviewBarCheckItem3
			//
			this.PrintPreviewBarCheckItem3.Caption = "MHT File";
			this.PrintPreviewBarCheckItem3.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportMht;
			this.PrintPreviewBarCheckItem3.Enabled = false;
			this.PrintPreviewBarCheckItem3.GroupIndex = 2;
			this.PrintPreviewBarCheckItem3.Hint = "MHT File";
			this.PrintPreviewBarCheckItem3.Id = 38;
			this.PrintPreviewBarCheckItem3.Name = "PrintPreviewBarCheckItem3";
			//
			//PrintPreviewBarCheckItem4
			//
			this.PrintPreviewBarCheckItem4.Caption = "RTF File";
			this.PrintPreviewBarCheckItem4.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportRtf;
			this.PrintPreviewBarCheckItem4.Enabled = false;
			this.PrintPreviewBarCheckItem4.GroupIndex = 2;
			this.PrintPreviewBarCheckItem4.Hint = "RTF File";
			this.PrintPreviewBarCheckItem4.Id = 39;
			this.PrintPreviewBarCheckItem4.Name = "PrintPreviewBarCheckItem4";
			//
			//PrintPreviewBarCheckItem5
			//
			this.PrintPreviewBarCheckItem5.Caption = "Excel File";
			this.PrintPreviewBarCheckItem5.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportXls;
			this.PrintPreviewBarCheckItem5.Enabled = false;
			this.PrintPreviewBarCheckItem5.GroupIndex = 2;
			this.PrintPreviewBarCheckItem5.Hint = "Excel File";
			this.PrintPreviewBarCheckItem5.Id = 40;
			this.PrintPreviewBarCheckItem5.Name = "PrintPreviewBarCheckItem5";
			//
			//PrintPreviewBarCheckItem6
			//
			this.PrintPreviewBarCheckItem6.Caption = "CSV File";
			this.PrintPreviewBarCheckItem6.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportCsv;
			this.PrintPreviewBarCheckItem6.Enabled = false;
			this.PrintPreviewBarCheckItem6.GroupIndex = 2;
			this.PrintPreviewBarCheckItem6.Hint = "CSV File";
			this.PrintPreviewBarCheckItem6.Id = 41;
			this.PrintPreviewBarCheckItem6.Name = "PrintPreviewBarCheckItem6";
			//
			//PrintPreviewBarCheckItem7
			//
			this.PrintPreviewBarCheckItem7.Caption = "Text File";
			this.PrintPreviewBarCheckItem7.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportTxt;
			this.PrintPreviewBarCheckItem7.Enabled = false;
			this.PrintPreviewBarCheckItem7.GroupIndex = 2;
			this.PrintPreviewBarCheckItem7.Hint = "Text File";
			this.PrintPreviewBarCheckItem7.Id = 42;
			this.PrintPreviewBarCheckItem7.Name = "PrintPreviewBarCheckItem7";
			//
			//PrintPreviewBarCheckItem8
			//
			this.PrintPreviewBarCheckItem8.Caption = "Image File";
			this.PrintPreviewBarCheckItem8.Command = DevExpress.XtraPrinting.PrintingSystemCommand.ExportGraphic;
			this.PrintPreviewBarCheckItem8.Enabled = false;
			this.PrintPreviewBarCheckItem8.GroupIndex = 2;
			this.PrintPreviewBarCheckItem8.Hint = "Image File";
			this.PrintPreviewBarCheckItem8.Id = 43;
			this.PrintPreviewBarCheckItem8.Name = "PrintPreviewBarCheckItem8";
			//
			//PrintPreviewBarCheckItem9
			//
			this.PrintPreviewBarCheckItem9.BindableChecked = true;
			this.PrintPreviewBarCheckItem9.Caption = "PDF File";
			this.PrintPreviewBarCheckItem9.Checked = true;
			this.PrintPreviewBarCheckItem9.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendPdf;
			this.PrintPreviewBarCheckItem9.Enabled = false;
			this.PrintPreviewBarCheckItem9.GroupIndex = 1;
			this.PrintPreviewBarCheckItem9.Hint = "PDF File";
			this.PrintPreviewBarCheckItem9.Id = 44;
			this.PrintPreviewBarCheckItem9.Name = "PrintPreviewBarCheckItem9";
			//
			//PrintPreviewBarCheckItem10
			//
			this.PrintPreviewBarCheckItem10.Caption = "MHT File";
			this.PrintPreviewBarCheckItem10.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendMht;
			this.PrintPreviewBarCheckItem10.Enabled = false;
			this.PrintPreviewBarCheckItem10.GroupIndex = 1;
			this.PrintPreviewBarCheckItem10.Hint = "MHT File";
			this.PrintPreviewBarCheckItem10.Id = 45;
			this.PrintPreviewBarCheckItem10.Name = "PrintPreviewBarCheckItem10";
			//
			//PrintPreviewBarCheckItem11
			//
			this.PrintPreviewBarCheckItem11.Caption = "RTF File";
			this.PrintPreviewBarCheckItem11.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendRtf;
			this.PrintPreviewBarCheckItem11.Enabled = false;
			this.PrintPreviewBarCheckItem11.GroupIndex = 1;
			this.PrintPreviewBarCheckItem11.Hint = "RTF File";
			this.PrintPreviewBarCheckItem11.Id = 46;
			this.PrintPreviewBarCheckItem11.Name = "PrintPreviewBarCheckItem11";
			//
			//PrintPreviewBarCheckItem12
			//
			this.PrintPreviewBarCheckItem12.Caption = "Excel File";
			this.PrintPreviewBarCheckItem12.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendXls;
			this.PrintPreviewBarCheckItem12.Enabled = false;
			this.PrintPreviewBarCheckItem12.GroupIndex = 1;
			this.PrintPreviewBarCheckItem12.Hint = "Excel File";
			this.PrintPreviewBarCheckItem12.Id = 47;
			this.PrintPreviewBarCheckItem12.Name = "PrintPreviewBarCheckItem12";
			//
			//PrintPreviewBarCheckItem13
			//
			this.PrintPreviewBarCheckItem13.Caption = "CSV File";
			this.PrintPreviewBarCheckItem13.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendCsv;
			this.PrintPreviewBarCheckItem13.Enabled = false;
			this.PrintPreviewBarCheckItem13.GroupIndex = 1;
			this.PrintPreviewBarCheckItem13.Hint = "CSV File";
			this.PrintPreviewBarCheckItem13.Id = 48;
			this.PrintPreviewBarCheckItem13.Name = "PrintPreviewBarCheckItem13";
			//
			//PrintPreviewBarCheckItem14
			//
			this.PrintPreviewBarCheckItem14.Caption = "Text File";
			this.PrintPreviewBarCheckItem14.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendTxt;
			this.PrintPreviewBarCheckItem14.Enabled = false;
			this.PrintPreviewBarCheckItem14.GroupIndex = 1;
			this.PrintPreviewBarCheckItem14.Hint = "Text File";
			this.PrintPreviewBarCheckItem14.Id = 49;
			this.PrintPreviewBarCheckItem14.Name = "PrintPreviewBarCheckItem14";
			//
			//PrintPreviewBarCheckItem15
			//
			this.PrintPreviewBarCheckItem15.Caption = "Image File";
			this.PrintPreviewBarCheckItem15.Command = DevExpress.XtraPrinting.PrintingSystemCommand.SendGraphic;
			this.PrintPreviewBarCheckItem15.Enabled = false;
			this.PrintPreviewBarCheckItem15.GroupIndex = 1;
			this.PrintPreviewBarCheckItem15.Hint = "Image File";
			this.PrintPreviewBarCheckItem15.Id = 50;
			this.PrintPreviewBarCheckItem15.Name = "PrintPreviewBarCheckItem15";
			//
			//reportsPrintControl
			//
			this.reportsPrintControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.reportsPrintControl.IsMetric = false;
			this.reportsPrintControl.Location = new System.Drawing.Point(219, 53);
			this.reportsPrintControl.Name = "reportsPrintControl";
			this.reportsPrintControl.Size = new System.Drawing.Size(515, 526);
			this.reportsPrintControl.TabIndex = 4;
			//
			//productionUOMCheckEdit
			//
			this.productionUOMCheckEdit.EditValue = true;
			this.productionUOMCheckEdit.Location = new System.Drawing.Point(4, 347);
			this.productionUOMCheckEdit.MenuManager = this.reportsPrintBarManager;
			this.productionUOMCheckEdit.Name = "productionUOMCheckEdit";
			this.productionUOMCheckEdit.Properties.Caption = "Unit Of Measure";
			this.productionUOMCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.productionUOMCheckEdit.TabIndex = 23;
			//
			//productionProjectedPackersCheckEdit
			//
			this.productionProjectedPackersCheckEdit.EditValue = true;
			this.productionProjectedPackersCheckEdit.Location = new System.Drawing.Point(4, 329);
			this.productionProjectedPackersCheckEdit.MenuManager = this.reportsPrintBarManager;
			this.productionProjectedPackersCheckEdit.Name = "productionProjectedPackersCheckEdit";
			this.productionProjectedPackersCheckEdit.Properties.Caption = "Projected Packers";
			this.productionProjectedPackersCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.productionProjectedPackersCheckEdit.TabIndex = 22;
			//
			//productionProjectedSpeedCheckEdit
			//
			this.productionProjectedSpeedCheckEdit.EditValue = true;
			this.productionProjectedSpeedCheckEdit.Location = new System.Drawing.Point(4, 311);
			this.productionProjectedSpeedCheckEdit.MenuManager = this.reportsPrintBarManager;
			this.productionProjectedSpeedCheckEdit.Name = "productionProjectedSpeedCheckEdit";
			this.productionProjectedSpeedCheckEdit.Properties.Caption = "Projected Speed";
			this.productionProjectedSpeedCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.productionProjectedSpeedCheckEdit.TabIndex = 21;
			//
			//productionPOCheckEdit
			//
			this.productionPOCheckEdit.EditValue = true;
			this.productionPOCheckEdit.Location = new System.Drawing.Point(4, 293);
			this.productionPOCheckEdit.Name = "productionPOCheckEdit";
			this.productionPOCheckEdit.Properties.Caption = "PO #";
			this.productionPOCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.productionPOCheckEdit.TabIndex = 20;
			//
			//productionTotalPayrollCheckEdit
			//
			this.productionTotalPayrollCheckEdit.EditValue = true;
			this.productionTotalPayrollCheckEdit.Location = new System.Drawing.Point(4, 275);
			this.productionTotalPayrollCheckEdit.Name = "productionTotalPayrollCheckEdit";
			this.productionTotalPayrollCheckEdit.Properties.Caption = "Total Payroll";
			this.productionTotalPayrollCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.productionTotalPayrollCheckEdit.TabIndex = 19;
			//
			//productionShiftCheckEdit
			//
			this.productionShiftCheckEdit.EditValue = true;
			this.productionShiftCheckEdit.Location = new System.Drawing.Point(4, 20);
			this.productionShiftCheckEdit.Name = "productionShiftCheckEdit";
			this.productionShiftCheckEdit.Properties.Caption = "Shift";
			this.productionShiftCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.productionShiftCheckEdit.TabIndex = 18;
			//
			//productionCustomerNameCheckEdit
			//
			this.productionCustomerNameCheckEdit.EditValue = true;
			this.productionCustomerNameCheckEdit.Location = new System.Drawing.Point(4, 37);
			this.productionCustomerNameCheckEdit.Name = "productionCustomerNameCheckEdit";
			this.productionCustomerNameCheckEdit.Properties.Caption = "Customer Name";
			this.productionCustomerNameCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.productionCustomerNameCheckEdit.TabIndex = 17;
			//
			//productionLotCheckEdit
			//
			this.productionLotCheckEdit.EditValue = true;
			this.productionLotCheckEdit.Location = new System.Drawing.Point(4, 54);
			this.productionLotCheckEdit.Name = "productionLotCheckEdit";
			this.productionLotCheckEdit.Properties.Caption = "Lot #";
			this.productionLotCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.productionLotCheckEdit.TabIndex = 16;
			//
			//productionItemCodeCheckEdit
			//
			this.productionItemCodeCheckEdit.EditValue = true;
			this.productionItemCodeCheckEdit.Location = new System.Drawing.Point(4, 71);
			this.productionItemCodeCheckEdit.Name = "productionItemCodeCheckEdit";
			this.productionItemCodeCheckEdit.Properties.Caption = "Item Code";
			this.productionItemCodeCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.productionItemCodeCheckEdit.TabIndex = 15;
			//
			//productionItemDescriptionCheckEdit
			//
			this.productionItemDescriptionCheckEdit.EditValue = true;
			this.productionItemDescriptionCheckEdit.Location = new System.Drawing.Point(4, 88);
			this.productionItemDescriptionCheckEdit.Name = "productionItemDescriptionCheckEdit";
			this.productionItemDescriptionCheckEdit.Properties.Caption = "Item Description";
			this.productionItemDescriptionCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.productionItemDescriptionCheckEdit.TabIndex = 14;
			//
			//productionStartTimeCheckEdit
			//
			this.productionStartTimeCheckEdit.EditValue = true;
			this.productionStartTimeCheckEdit.Location = new System.Drawing.Point(4, 105);
			this.productionStartTimeCheckEdit.Name = "productionStartTimeCheckEdit";
			this.productionStartTimeCheckEdit.Properties.Caption = "Start Time";
			this.productionStartTimeCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.productionStartTimeCheckEdit.TabIndex = 13;
			//
			//productionStopTimeCheckEdit
			//
			this.productionStopTimeCheckEdit.EditValue = true;
			this.productionStopTimeCheckEdit.Location = new System.Drawing.Point(4, 122);
			this.productionStopTimeCheckEdit.Name = "productionStopTimeCheckEdit";
			this.productionStopTimeCheckEdit.Properties.Caption = "Stop Time";
			this.productionStopTimeCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.productionStopTimeCheckEdit.TabIndex = 12;
			//
			//productionTotalHoursCheckEdit
			//
			this.productionTotalHoursCheckEdit.EditValue = true;
			this.productionTotalHoursCheckEdit.Location = new System.Drawing.Point(4, 139);
			this.productionTotalHoursCheckEdit.Name = "productionTotalHoursCheckEdit";
			this.productionTotalHoursCheckEdit.Properties.Caption = "Total Hours";
			this.productionTotalHoursCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.productionTotalHoursCheckEdit.TabIndex = 11;
			//
			//productionTotalMinutesCheckEdit
			//
			this.productionTotalMinutesCheckEdit.EditValue = true;
			this.productionTotalMinutesCheckEdit.Location = new System.Drawing.Point(4, 156);
			this.productionTotalMinutesCheckEdit.Name = "productionTotalMinutesCheckEdit";
			this.productionTotalMinutesCheckEdit.Properties.Caption = "Total Minutes";
			this.productionTotalMinutesCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.productionTotalMinutesCheckEdit.TabIndex = 10;
			//
			//productionPackersCheckEdit
			//
			this.productionPackersCheckEdit.EditValue = true;
			this.productionPackersCheckEdit.Location = new System.Drawing.Point(4, 258);
			this.productionPackersCheckEdit.Name = "productionPackersCheckEdit";
			this.productionPackersCheckEdit.Properties.Caption = "Packers";
			this.productionPackersCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.productionPackersCheckEdit.TabIndex = 8;
			//
			//productionActualSpeedCheckEdit
			//
			this.productionActualSpeedCheckEdit.EditValue = true;
			this.productionActualSpeedCheckEdit.Location = new System.Drawing.Point(4, 241);
			this.productionActualSpeedCheckEdit.Name = "productionActualSpeedCheckEdit";
			this.productionActualSpeedCheckEdit.Properties.Caption = "Actual Speed";
			this.productionActualSpeedCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.productionActualSpeedCheckEdit.TabIndex = 7;
			//
			//productionDifferenceCheckEdit
			//
			this.productionDifferenceCheckEdit.EditValue = true;
			this.productionDifferenceCheckEdit.Location = new System.Drawing.Point(4, 207);
			this.productionDifferenceCheckEdit.Name = "productionDifferenceCheckEdit";
			this.productionDifferenceCheckEdit.Properties.Caption = "Difference";
			this.productionDifferenceCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.productionDifferenceCheckEdit.TabIndex = 5;
			//
			//productionExpectedCheckEdit
			//
			this.productionExpectedCheckEdit.EditValue = true;
			this.productionExpectedCheckEdit.Location = new System.Drawing.Point(4, 190);
			this.productionExpectedCheckEdit.Name = "productionExpectedCheckEdit";
			this.productionExpectedCheckEdit.Properties.Caption = "Expected";
			this.productionExpectedCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.productionExpectedCheckEdit.TabIndex = 4;
			//
			//productionQuantityCheckEdit
			//
			this.productionQuantityCheckEdit.EditValue = true;
			this.productionQuantityCheckEdit.Location = new System.Drawing.Point(4, 173);
			this.productionQuantityCheckEdit.Name = "productionQuantityCheckEdit";
			this.productionQuantityCheckEdit.Properties.Caption = "Quantity";
			this.productionQuantityCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.productionQuantityCheckEdit.TabIndex = 3;
			//
			//productionMachineLineCheckEdit
			//
			this.productionMachineLineCheckEdit.EditValue = true;
			this.productionMachineLineCheckEdit.Location = new System.Drawing.Point(4, 224);
			this.productionMachineLineCheckEdit.Name = "productionMachineLineCheckEdit";
			this.productionMachineLineCheckEdit.Properties.Caption = "Machine Line";
			this.productionMachineLineCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.productionMachineLineCheckEdit.TabIndex = 1;
			//
			//productionDateCheckEdit
			//
			this.productionDateCheckEdit.EditValue = true;
			this.productionDateCheckEdit.Location = new System.Drawing.Point(4, 3);
			this.productionDateCheckEdit.Name = "productionDateCheckEdit";
			this.productionDateCheckEdit.Properties.Caption = "Date";
			this.productionDateCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.productionDateCheckEdit.TabIndex = 0;
			//
			//transportationXtraTabPage
			//
			this.transportationXtraTabPage.Controls.Add(this.transportationXtraScrollableControl);
			this.transportationXtraTabPage.Name = "transportationXtraTabPage";
			this.transportationXtraTabPage.Size = new System.Drawing.Size(185, 471);
			this.transportationXtraTabPage.Text = "Transportation";
			//
			//transportationXtraScrollableControl
			//
			this.transportationXtraScrollableControl.Controls.Add(this.transportationLpnCheckEdit);
			this.transportationXtraScrollableControl.Controls.Add(this.transportationExpirationDateCheckEdit);
			this.transportationXtraScrollableControl.Controls.Add(this.transportationVendorCheckEdit);
			this.transportationXtraScrollableControl.Controls.Add(this.transportationBolCheckEdit);
			this.transportationXtraScrollableControl.Controls.Add(this.transportationSealCheckEdit);
			this.transportationXtraScrollableControl.Controls.Add(this.transportationTrailerCheckEdit);
			this.transportationXtraScrollableControl.Controls.Add(this.transportationCarrierCheckEdit);
			this.transportationXtraScrollableControl.Controls.Add(this.transportationDestinationCheckEdit);
			this.transportationXtraScrollableControl.Controls.Add(this.transportationDeliveryNoteCheckEdit);
			this.transportationXtraScrollableControl.Controls.Add(this.transportationPOCheckEdit);
			this.transportationXtraScrollableControl.Controls.Add(this.transportationShiftCheckEdit);
			this.transportationXtraScrollableControl.Controls.Add(this.transportationCustomerCheckEdit);
			this.transportationXtraScrollableControl.Controls.Add(this.transportationLotCheckEdit);
			this.transportationXtraScrollableControl.Controls.Add(this.transportationItemCheckEdit);
			this.transportationXtraScrollableControl.Controls.Add(this.transportationItemDescriptionCheckEdit);
			this.transportationXtraScrollableControl.Controls.Add(this.transportationQuantityCheckEdit);
			this.transportationXtraScrollableControl.Controls.Add(this.transportationDateCheckEdit);
			this.transportationXtraScrollableControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.transportationXtraScrollableControl.Location = new System.Drawing.Point(0, 0);
			this.transportationXtraScrollableControl.Name = "transportationXtraScrollableControl";
			this.transportationXtraScrollableControl.Size = new System.Drawing.Size(185, 471);
			this.transportationXtraScrollableControl.TabIndex = 2;
			//
			//transportationLpnCheckEdit
			//
			this.transportationLpnCheckEdit.EditValue = true;
			this.transportationLpnCheckEdit.Location = new System.Drawing.Point(3, 300);
			this.transportationLpnCheckEdit.Name = "transportationLpnCheckEdit";
			this.transportationLpnCheckEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.transportationLpnCheckEdit.Properties.Appearance.Options.UseBackColor = true;
			this.transportationLpnCheckEdit.Properties.Caption = "LPN #";
			this.transportationLpnCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.transportationLpnCheckEdit.TabIndex = 36;
			//
			//transportationExpirationDateCheckEdit
			//
			this.transportationExpirationDateCheckEdit.EditValue = true;
			this.transportationExpirationDateCheckEdit.Location = new System.Drawing.Point(3, 282);
			this.transportationExpirationDateCheckEdit.Name = "transportationExpirationDateCheckEdit";
			this.transportationExpirationDateCheckEdit.Properties.Caption = "Expiration Date";
			this.transportationExpirationDateCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.transportationExpirationDateCheckEdit.TabIndex = 35;
			//
			//transportationVendorCheckEdit
			//
			this.transportationVendorCheckEdit.EditValue = true;
			this.transportationVendorCheckEdit.Location = new System.Drawing.Point(3, 264);
			this.transportationVendorCheckEdit.Name = "transportationVendorCheckEdit";
			this.transportationVendorCheckEdit.Properties.Caption = "Vendor";
			this.transportationVendorCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.transportationVendorCheckEdit.TabIndex = 34;
			//
			//transportationBolCheckEdit
			//
			this.transportationBolCheckEdit.EditValue = true;
			this.transportationBolCheckEdit.Location = new System.Drawing.Point(3, 245);
			this.transportationBolCheckEdit.Name = "transportationBolCheckEdit";
			this.transportationBolCheckEdit.Properties.Caption = "BOL #";
			this.transportationBolCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.transportationBolCheckEdit.TabIndex = 33;
			//
			//transportationSealCheckEdit
			//
			this.transportationSealCheckEdit.EditValue = true;
			this.transportationSealCheckEdit.Location = new System.Drawing.Point(3, 226);
			this.transportationSealCheckEdit.Name = "transportationSealCheckEdit";
			this.transportationSealCheckEdit.Properties.Caption = "Seal #";
			this.transportationSealCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.transportationSealCheckEdit.TabIndex = 32;
			//
			//transportationTrailerCheckEdit
			//
			this.transportationTrailerCheckEdit.EditValue = true;
			this.transportationTrailerCheckEdit.Location = new System.Drawing.Point(3, 207);
			this.transportationTrailerCheckEdit.Name = "transportationTrailerCheckEdit";
			this.transportationTrailerCheckEdit.Properties.Caption = "Trailer #";
			this.transportationTrailerCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.transportationTrailerCheckEdit.TabIndex = 31;
			//
			//transportationCarrierCheckEdit
			//
			this.transportationCarrierCheckEdit.EditValue = true;
			this.transportationCarrierCheckEdit.Location = new System.Drawing.Point(3, 188);
			this.transportationCarrierCheckEdit.Name = "transportationCarrierCheckEdit";
			this.transportationCarrierCheckEdit.Properties.Caption = "Carrier";
			this.transportationCarrierCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.transportationCarrierCheckEdit.TabIndex = 30;
			//
			//transportationDestinationCheckEdit
			//
			this.transportationDestinationCheckEdit.EditValue = true;
			this.transportationDestinationCheckEdit.Location = new System.Drawing.Point(3, 169);
			this.transportationDestinationCheckEdit.Name = "transportationDestinationCheckEdit";
			this.transportationDestinationCheckEdit.Properties.Caption = "Destination";
			this.transportationDestinationCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.transportationDestinationCheckEdit.TabIndex = 29;
			//
			//transportationDeliveryNoteCheckEdit
			//
			this.transportationDeliveryNoteCheckEdit.EditValue = true;
			this.transportationDeliveryNoteCheckEdit.Location = new System.Drawing.Point(3, 151);
			this.transportationDeliveryNoteCheckEdit.Name = "transportationDeliveryNoteCheckEdit";
			this.transportationDeliveryNoteCheckEdit.Properties.Caption = "Delivery Note #";
			this.transportationDeliveryNoteCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.transportationDeliveryNoteCheckEdit.TabIndex = 28;
			//
			//transportationPOCheckEdit
			//
			this.transportationPOCheckEdit.EditValue = true;
			this.transportationPOCheckEdit.Location = new System.Drawing.Point(3, 133);
			this.transportationPOCheckEdit.Name = "transportationPOCheckEdit";
			this.transportationPOCheckEdit.Properties.Caption = "PO #";
			this.transportationPOCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.transportationPOCheckEdit.TabIndex = 26;
			//
			//transportationShiftCheckEdit
			//
			this.transportationShiftCheckEdit.EditValue = true;
			this.transportationShiftCheckEdit.Location = new System.Drawing.Point(3, 22);
			this.transportationShiftCheckEdit.Name = "transportationShiftCheckEdit";
			this.transportationShiftCheckEdit.Properties.Caption = "Shift";
			this.transportationShiftCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.transportationShiftCheckEdit.TabIndex = 25;
			//
			//transportationCustomerCheckEdit
			//
			this.transportationCustomerCheckEdit.EditValue = true;
			this.transportationCustomerCheckEdit.Location = new System.Drawing.Point(3, 41);
			this.transportationCustomerCheckEdit.Name = "transportationCustomerCheckEdit";
			this.transportationCustomerCheckEdit.Properties.Caption = "Customer Name";
			this.transportationCustomerCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.transportationCustomerCheckEdit.TabIndex = 24;
			//
			//transportationLotCheckEdit
			//
			this.transportationLotCheckEdit.EditValue = true;
			this.transportationLotCheckEdit.Location = new System.Drawing.Point(3, 60);
			this.transportationLotCheckEdit.Name = "transportationLotCheckEdit";
			this.transportationLotCheckEdit.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.transportationLotCheckEdit.Properties.Appearance.Options.UseBackColor = true;
			this.transportationLotCheckEdit.Properties.Caption = "Lot #";
			this.transportationLotCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.transportationLotCheckEdit.TabIndex = 23;
			//
			//transportationItemCheckEdit
			//
			this.transportationItemCheckEdit.EditValue = true;
			this.transportationItemCheckEdit.Location = new System.Drawing.Point(3, 78);
			this.transportationItemCheckEdit.Name = "transportationItemCheckEdit";
			this.transportationItemCheckEdit.Properties.Caption = "Item Code";
			this.transportationItemCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.transportationItemCheckEdit.TabIndex = 22;
			//
			//transportationItemDescriptionCheckEdit
			//
			this.transportationItemDescriptionCheckEdit.EditValue = true;
			this.transportationItemDescriptionCheckEdit.Location = new System.Drawing.Point(3, 96);
			this.transportationItemDescriptionCheckEdit.Name = "transportationItemDescriptionCheckEdit";
			this.transportationItemDescriptionCheckEdit.Properties.Caption = "Item Description";
			this.transportationItemDescriptionCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.transportationItemDescriptionCheckEdit.TabIndex = 21;
			//
			//transportationQuantityCheckEdit
			//
			this.transportationQuantityCheckEdit.EditValue = true;
			this.transportationQuantityCheckEdit.Location = new System.Drawing.Point(3, 115);
			this.transportationQuantityCheckEdit.Name = "transportationQuantityCheckEdit";
			this.transportationQuantityCheckEdit.Properties.Caption = "Quantity";
			this.transportationQuantityCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.transportationQuantityCheckEdit.TabIndex = 20;
			//
			//transportationDateCheckEdit
			//
			this.transportationDateCheckEdit.EditValue = true;
			this.transportationDateCheckEdit.Location = new System.Drawing.Point(3, 3);
			this.transportationDateCheckEdit.Name = "transportationDateCheckEdit";
			this.transportationDateCheckEdit.Properties.Caption = "Date";
			this.transportationDateCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.transportationDateCheckEdit.TabIndex = 19;
			//
			//inventoryXtraTabPage
			//
			this.inventoryXtraTabPage.Controls.Add(this.inventoryXtraScrollableControl);
			this.inventoryXtraTabPage.Name = "inventoryXtraTabPage";
			this.inventoryXtraTabPage.Size = new System.Drawing.Size(185, 471);
			this.inventoryXtraTabPage.Text = "Inventory";
			//
			//inventoryXtraScrollableControl
			//
			this.inventoryXtraScrollableControl.Controls.Add(this.UOMCheckEdit);
			this.inventoryXtraScrollableControl.Controls.Add(this.RMItemDescriptionCheckEdit);
			this.inventoryXtraScrollableControl.Controls.Add(this.RMItemCodeCheckEdit);
			this.inventoryXtraScrollableControl.Controls.Add(this.inventoryPalletAvailabilityCheckEdit);
			this.inventoryXtraScrollableControl.Controls.Add(this.inventoryAvailabilityCheckEdit);
			this.inventoryXtraScrollableControl.Controls.Add(this.inventoryInventoryByPalletCheckEdit);
			this.inventoryXtraScrollableControl.Controls.Add(this.inventoryCurrentInventoryCheckEdit);
			this.inventoryXtraScrollableControl.Controls.Add(this.inventoryItemTypeCheckEdit);
			this.inventoryXtraScrollableControl.Controls.Add(this.inventoryAdjustmentReasonCheckEdit);
			this.inventoryXtraScrollableControl.Controls.Add(this.inventoryAdjustmentCheckEdit);
			this.inventoryXtraScrollableControl.Controls.Add(this.inventoryCustomerCheckEdit);
			this.inventoryXtraScrollableControl.Controls.Add(this.inventoryItemCheckEdit);
			this.inventoryXtraScrollableControl.Controls.Add(this.inventoryItemDescriptionCheckEdit);
			this.inventoryXtraScrollableControl.Controls.Add(this.inventoryDateCheckEdit);
			this.inventoryXtraScrollableControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inventoryXtraScrollableControl.Location = new System.Drawing.Point(0, 0);
			this.inventoryXtraScrollableControl.Name = "inventoryXtraScrollableControl";
			this.inventoryXtraScrollableControl.Size = new System.Drawing.Size(185, 471);
			this.inventoryXtraScrollableControl.TabIndex = 0;
			//
			//UOMCheckEdit
			//
			this.UOMCheckEdit.EditValue = true;
			this.UOMCheckEdit.Location = new System.Drawing.Point(3, 262);
			this.UOMCheckEdit.MenuManager = this.reportsPrintBarManager;
			this.UOMCheckEdit.Name = "UOMCheckEdit";
			this.UOMCheckEdit.Properties.Caption = "Unit Of Measure";
			this.UOMCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.UOMCheckEdit.TabIndex = 40;
			//
			//RMItemDescriptionCheckEdit
			//
			this.RMItemDescriptionCheckEdit.EditValue = true;
			this.RMItemDescriptionCheckEdit.Location = new System.Drawing.Point(3, 240);
			this.RMItemDescriptionCheckEdit.Name = "RMItemDescriptionCheckEdit";
			this.RMItemDescriptionCheckEdit.Properties.Caption = "RM Item Description";
			this.RMItemDescriptionCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.RMItemDescriptionCheckEdit.TabIndex = 39;
			//
			//RMItemCodeCheckEdit
			//
			this.RMItemCodeCheckEdit.EditValue = true;
			this.RMItemCodeCheckEdit.Location = new System.Drawing.Point(3, 219);
			this.RMItemCodeCheckEdit.Name = "RMItemCodeCheckEdit";
			this.RMItemCodeCheckEdit.Properties.Caption = "RM Item Code";
			this.RMItemCodeCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.RMItemCodeCheckEdit.TabIndex = 38;
			//
			//inventoryPalletAvailabilityCheckEdit
			//
			this.inventoryPalletAvailabilityCheckEdit.EditValue = true;
			this.inventoryPalletAvailabilityCheckEdit.Location = new System.Drawing.Point(3, 201);
			this.inventoryPalletAvailabilityCheckEdit.Name = "inventoryPalletAvailabilityCheckEdit";
			this.inventoryPalletAvailabilityCheckEdit.Properties.Caption = "Pallet Availability";
			this.inventoryPalletAvailabilityCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.inventoryPalletAvailabilityCheckEdit.TabIndex = 37;
			//
			//inventoryAvailabilityCheckEdit
			//
			this.inventoryAvailabilityCheckEdit.EditValue = true;
			this.inventoryAvailabilityCheckEdit.Location = new System.Drawing.Point(3, 180);
			this.inventoryAvailabilityCheckEdit.Name = "inventoryAvailabilityCheckEdit";
			this.inventoryAvailabilityCheckEdit.Properties.Caption = "Availability";
			this.inventoryAvailabilityCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.inventoryAvailabilityCheckEdit.TabIndex = 36;
			//
			//inventoryInventoryByPalletCheckEdit
			//
			this.inventoryInventoryByPalletCheckEdit.EditValue = true;
			this.inventoryInventoryByPalletCheckEdit.Location = new System.Drawing.Point(3, 160);
			this.inventoryInventoryByPalletCheckEdit.Name = "inventoryInventoryByPalletCheckEdit";
			this.inventoryInventoryByPalletCheckEdit.Properties.Caption = "Inventory By Pallet";
			this.inventoryInventoryByPalletCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.inventoryInventoryByPalletCheckEdit.TabIndex = 35;
			//
			//inventoryCurrentInventoryCheckEdit
			//
			this.inventoryCurrentInventoryCheckEdit.EditValue = true;
			this.inventoryCurrentInventoryCheckEdit.Location = new System.Drawing.Point(3, 139);
			this.inventoryCurrentInventoryCheckEdit.Name = "inventoryCurrentInventoryCheckEdit";
			this.inventoryCurrentInventoryCheckEdit.Properties.Caption = "Current Inventory";
			this.inventoryCurrentInventoryCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.inventoryCurrentInventoryCheckEdit.TabIndex = 34;
			//
			//inventoryItemTypeCheckEdit
			//
			this.inventoryItemTypeCheckEdit.EditValue = true;
			this.inventoryItemTypeCheckEdit.Location = new System.Drawing.Point(3, 119);
			this.inventoryItemTypeCheckEdit.Name = "inventoryItemTypeCheckEdit";
			this.inventoryItemTypeCheckEdit.Properties.Caption = "Item Type";
			this.inventoryItemTypeCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.inventoryItemTypeCheckEdit.TabIndex = 33;
			//
			//inventoryAdjustmentReasonCheckEdit
			//
			this.inventoryAdjustmentReasonCheckEdit.EditValue = true;
			this.inventoryAdjustmentReasonCheckEdit.Location = new System.Drawing.Point(3, 99);
			this.inventoryAdjustmentReasonCheckEdit.Name = "inventoryAdjustmentReasonCheckEdit";
			this.inventoryAdjustmentReasonCheckEdit.Properties.Caption = "Adjustment Reason";
			this.inventoryAdjustmentReasonCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.inventoryAdjustmentReasonCheckEdit.TabIndex = 32;
			//
			//inventoryAdjustmentCheckEdit
			//
			this.inventoryAdjustmentCheckEdit.EditValue = true;
			this.inventoryAdjustmentCheckEdit.Location = new System.Drawing.Point(3, 80);
			this.inventoryAdjustmentCheckEdit.Name = "inventoryAdjustmentCheckEdit";
			this.inventoryAdjustmentCheckEdit.Properties.Caption = "Adjustment";
			this.inventoryAdjustmentCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.inventoryAdjustmentCheckEdit.TabIndex = 31;
			//
			//inventoryCustomerCheckEdit
			//
			this.inventoryCustomerCheckEdit.EditValue = true;
			this.inventoryCustomerCheckEdit.Location = new System.Drawing.Point(3, 22);
			this.inventoryCustomerCheckEdit.Name = "inventoryCustomerCheckEdit";
			this.inventoryCustomerCheckEdit.Properties.Caption = "Customer Name";
			this.inventoryCustomerCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.inventoryCustomerCheckEdit.TabIndex = 28;
			//
			//inventoryItemCheckEdit
			//
			this.inventoryItemCheckEdit.EditValue = true;
			this.inventoryItemCheckEdit.Location = new System.Drawing.Point(3, 42);
			this.inventoryItemCheckEdit.Name = "inventoryItemCheckEdit";
			this.inventoryItemCheckEdit.Properties.Caption = "Item Code";
			this.inventoryItemCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.inventoryItemCheckEdit.TabIndex = 27;
			//
			//inventoryItemDescriptionCheckEdit
			//
			this.inventoryItemDescriptionCheckEdit.EditValue = true;
			this.inventoryItemDescriptionCheckEdit.Location = new System.Drawing.Point(3, 60);
			this.inventoryItemDescriptionCheckEdit.Name = "inventoryItemDescriptionCheckEdit";
			this.inventoryItemDescriptionCheckEdit.Properties.Caption = "Item Description";
			this.inventoryItemDescriptionCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.inventoryItemDescriptionCheckEdit.TabIndex = 26;
			//
			//inventoryDateCheckEdit
			//
			this.inventoryDateCheckEdit.EditValue = true;
			this.inventoryDateCheckEdit.Location = new System.Drawing.Point(3, 3);
			this.inventoryDateCheckEdit.Name = "inventoryDateCheckEdit";
			this.inventoryDateCheckEdit.Properties.Caption = "Date";
			this.inventoryDateCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.inventoryDateCheckEdit.TabIndex = 25;
			//
			//itemsXtraTabPage
			//
			this.itemsXtraTabPage.Controls.Add(this.itemsXtraScrollableControl);
			this.itemsXtraTabPage.Name = "itemsXtraTabPage";
			this.itemsXtraTabPage.Size = new System.Drawing.Size(185, 471);
			this.itemsXtraTabPage.Text = "Items";
			//
			//itemsXtraScrollableControl
			//
			this.itemsXtraScrollableControl.Controls.Add(this.itemUsedInProductionCheckEdit);
			this.itemsXtraScrollableControl.Controls.Add(this.itemsCustomerCheckEdit);
			this.itemsXtraScrollableControl.Controls.Add(this.itemsItemCheckEdit);
			this.itemsXtraScrollableControl.Controls.Add(this.itemsItemDescriptionCheckEdit);
			this.itemsXtraScrollableControl.Controls.Add(this.itemsItemTypeCheckEdit);
			this.itemsXtraScrollableControl.Controls.Add(this.itemsUnitsOfMeasureCheckEdit);
			this.itemsXtraScrollableControl.Controls.Add(this.itemsQtyPerUnitCheckEdit);
			this.itemsXtraScrollableControl.Controls.Add(this.itemsUnitsPerCaseCheckEdit);
			this.itemsXtraScrollableControl.Controls.Add(this.itemsAdjustedCheckEdit);
			this.itemsXtraScrollableControl.Controls.Add(this.itemsShippedCheckEdit);
			this.itemsXtraScrollableControl.Controls.Add(this.itemsProducedCheckEdit);
			this.itemsXtraScrollableControl.Controls.Add(this.itemsCasesPerPalletCheckEdit);
			this.itemsXtraScrollableControl.Controls.Add(this.itemsReceivedCheckEdit);
			this.itemsXtraScrollableControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.itemsXtraScrollableControl.Location = new System.Drawing.Point(0, 0);
			this.itemsXtraScrollableControl.Name = "itemsXtraScrollableControl";
			this.itemsXtraScrollableControl.Size = new System.Drawing.Size(185, 471);
			this.itemsXtraScrollableControl.TabIndex = 0;
			//
			//itemUsedInProductionCheckEdit
			//
			this.itemUsedInProductionCheckEdit.EditValue = true;
			this.itemUsedInProductionCheckEdit.Location = new System.Drawing.Point(3, 231);
			this.itemUsedInProductionCheckEdit.MenuManager = this.reportsPrintBarManager;
			this.itemUsedInProductionCheckEdit.Name = "itemUsedInProductionCheckEdit";
			this.itemUsedInProductionCheckEdit.Properties.Caption = "Used In Production";
			this.itemUsedInProductionCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.itemUsedInProductionCheckEdit.TabIndex = 30;
			//
			//itemsCustomerCheckEdit
			//
			this.itemsCustomerCheckEdit.EditValue = true;
			this.itemsCustomerCheckEdit.Location = new System.Drawing.Point(3, 3);
			this.itemsCustomerCheckEdit.Name = "itemsCustomerCheckEdit";
			this.itemsCustomerCheckEdit.Properties.Caption = "Customer Name";
			this.itemsCustomerCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.itemsCustomerCheckEdit.TabIndex = 29;
			//
			//itemsItemCheckEdit
			//
			this.itemsItemCheckEdit.EditValue = true;
			this.itemsItemCheckEdit.Location = new System.Drawing.Point(3, 22);
			this.itemsItemCheckEdit.Name = "itemsItemCheckEdit";
			this.itemsItemCheckEdit.Properties.Caption = "Item Code";
			this.itemsItemCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.itemsItemCheckEdit.TabIndex = 28;
			//
			//itemsItemDescriptionCheckEdit
			//
			this.itemsItemDescriptionCheckEdit.EditValue = true;
			this.itemsItemDescriptionCheckEdit.Location = new System.Drawing.Point(3, 41);
			this.itemsItemDescriptionCheckEdit.Name = "itemsItemDescriptionCheckEdit";
			this.itemsItemDescriptionCheckEdit.Properties.Caption = "Item Description";
			this.itemsItemDescriptionCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.itemsItemDescriptionCheckEdit.TabIndex = 27;
			//
			//itemsItemTypeCheckEdit
			//
			this.itemsItemTypeCheckEdit.EditValue = true;
			this.itemsItemTypeCheckEdit.Location = new System.Drawing.Point(3, 60);
			this.itemsItemTypeCheckEdit.Name = "itemsItemTypeCheckEdit";
			this.itemsItemTypeCheckEdit.Properties.Caption = "Item Type";
			this.itemsItemTypeCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.itemsItemTypeCheckEdit.TabIndex = 26;
			//
			//itemsUnitsOfMeasureCheckEdit
			//
			this.itemsUnitsOfMeasureCheckEdit.EditValue = true;
			this.itemsUnitsOfMeasureCheckEdit.Location = new System.Drawing.Point(3, 79);
			this.itemsUnitsOfMeasureCheckEdit.Name = "itemsUnitsOfMeasureCheckEdit";
			this.itemsUnitsOfMeasureCheckEdit.Properties.Caption = "Units of Measure";
			this.itemsUnitsOfMeasureCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.itemsUnitsOfMeasureCheckEdit.TabIndex = 25;
			//
			//itemsQtyPerUnitCheckEdit
			//
			this.itemsQtyPerUnitCheckEdit.EditValue = true;
			this.itemsQtyPerUnitCheckEdit.Location = new System.Drawing.Point(3, 98);
			this.itemsQtyPerUnitCheckEdit.Name = "itemsQtyPerUnitCheckEdit";
			this.itemsQtyPerUnitCheckEdit.Properties.Caption = "QTY per Unit";
			this.itemsQtyPerUnitCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.itemsQtyPerUnitCheckEdit.TabIndex = 24;
			//
			//itemsUnitsPerCaseCheckEdit
			//
			this.itemsUnitsPerCaseCheckEdit.EditValue = true;
			this.itemsUnitsPerCaseCheckEdit.Location = new System.Drawing.Point(3, 117);
			this.itemsUnitsPerCaseCheckEdit.Name = "itemsUnitsPerCaseCheckEdit";
			this.itemsUnitsPerCaseCheckEdit.Properties.Caption = "Units per Case";
			this.itemsUnitsPerCaseCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.itemsUnitsPerCaseCheckEdit.TabIndex = 23;
			//
			//itemsAdjustedCheckEdit
			//
			this.itemsAdjustedCheckEdit.EditValue = true;
			this.itemsAdjustedCheckEdit.Location = new System.Drawing.Point(3, 212);
			this.itemsAdjustedCheckEdit.Name = "itemsAdjustedCheckEdit";
			this.itemsAdjustedCheckEdit.Properties.Caption = "Adjusted";
			this.itemsAdjustedCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.itemsAdjustedCheckEdit.TabIndex = 22;
			//
			//itemsShippedCheckEdit
			//
			this.itemsShippedCheckEdit.EditValue = true;
			this.itemsShippedCheckEdit.Location = new System.Drawing.Point(3, 174);
			this.itemsShippedCheckEdit.Name = "itemsShippedCheckEdit";
			this.itemsShippedCheckEdit.Properties.Caption = "Shipped";
			this.itemsShippedCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.itemsShippedCheckEdit.TabIndex = 21;
			//
			//itemsProducedCheckEdit
			//
			this.itemsProducedCheckEdit.EditValue = true;
			this.itemsProducedCheckEdit.Location = new System.Drawing.Point(3, 155);
			this.itemsProducedCheckEdit.Name = "itemsProducedCheckEdit";
			this.itemsProducedCheckEdit.Properties.Caption = "Produced";
			this.itemsProducedCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.itemsProducedCheckEdit.TabIndex = 20;
			//
			//itemsCasesPerPalletCheckEdit
			//
			this.itemsCasesPerPalletCheckEdit.EditValue = true;
			this.itemsCasesPerPalletCheckEdit.Location = new System.Drawing.Point(3, 136);
			this.itemsCasesPerPalletCheckEdit.Name = "itemsCasesPerPalletCheckEdit";
			this.itemsCasesPerPalletCheckEdit.Properties.Caption = "Cases per Pallet";
			this.itemsCasesPerPalletCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.itemsCasesPerPalletCheckEdit.TabIndex = 19;
			//
			//itemsReceivedCheckEdit
			//
			this.itemsReceivedCheckEdit.EditValue = true;
			this.itemsReceivedCheckEdit.Location = new System.Drawing.Point(3, 193);
			this.itemsReceivedCheckEdit.Name = "itemsReceivedCheckEdit";
			this.itemsReceivedCheckEdit.Properties.Caption = "Received";
			this.itemsReceivedCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.itemsReceivedCheckEdit.TabIndex = 18;
			//
			//costingXtraTabPage
			//
			this.costingXtraTabPage.Controls.Add(this.costingXtraScrollableControl);
			this.costingXtraTabPage.Name = "costingXtraTabPage";
			this.costingXtraTabPage.Size = new System.Drawing.Size(185, 471);
			this.costingXtraTabPage.Text = "Costing";
			//
			//costingXtraScrollableControl
			//
			this.costingXtraScrollableControl.Controls.Add(this.costingProductionDateCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingShiftCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingCustomerCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingLotCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingItemCodeCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingItemDescriptionCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingStartTimeCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingStopTimeCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingTotalHoursCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingTotalMinutesCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingQuantityCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingExpectedCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingDifferenceCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingMachineLineCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingMachineSpeedCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingActualSpeedCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingOperatorsCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingPackersCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingSupersCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingPriceCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingPayrollCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingRebateCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingFreightCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingFilmCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingBoxesCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingStretchWrapCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingPalletsCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingTotalOtherCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingCostCheckBox);
			this.costingXtraScrollableControl.Controls.Add(this.costingProfitCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingCostPerPieceCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingPacksPerMinuteCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingSalesVsPayrollCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.CostingSalesVsCostCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingProfitVsSalesCheckEdit);
			this.costingXtraScrollableControl.Controls.Add(this.costingSalesVsProfitCheckEdit);
			this.costingXtraScrollableControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.costingXtraScrollableControl.Location = new System.Drawing.Point(0, 0);
			this.costingXtraScrollableControl.Name = "costingXtraScrollableControl";
			this.costingXtraScrollableControl.Size = new System.Drawing.Size(185, 471);
			this.costingXtraScrollableControl.TabIndex = 0;
			//
			//costingProductionDateCheckEdit
			//
			this.costingProductionDateCheckEdit.AutoSize = true;
			this.costingProductionDateCheckEdit.Checked = true;
			this.costingProductionDateCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingProductionDateCheckEdit.Location = new System.Drawing.Point(3, 3);
			this.costingProductionDateCheckEdit.Name = "costingProductionDateCheckEdit";
			this.costingProductionDateCheckEdit.Size = new System.Drawing.Size(103, 17);
			this.costingProductionDateCheckEdit.TabIndex = 36;
			this.costingProductionDateCheckEdit.Text = "Production Date";
			this.costingProductionDateCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingShiftCheckEdit
			//
			this.costingShiftCheckEdit.AutoSize = true;
			this.costingShiftCheckEdit.Checked = true;
			this.costingShiftCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingShiftCheckEdit.Location = new System.Drawing.Point(3, 26);
			this.costingShiftCheckEdit.Name = "costingShiftCheckEdit";
			this.costingShiftCheckEdit.Size = new System.Drawing.Size(48, 17);
			this.costingShiftCheckEdit.TabIndex = 37;
			this.costingShiftCheckEdit.Text = "Shift";
			this.costingShiftCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingCustomerCheckEdit
			//
			this.costingCustomerCheckEdit.AutoSize = true;
			this.costingCustomerCheckEdit.Checked = true;
			this.costingCustomerCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingCustomerCheckEdit.Location = new System.Drawing.Point(3, 49);
			this.costingCustomerCheckEdit.Name = "costingCustomerCheckEdit";
			this.costingCustomerCheckEdit.Size = new System.Drawing.Size(102, 17);
			this.costingCustomerCheckEdit.TabIndex = 38;
			this.costingCustomerCheckEdit.Text = "Customer Name";
			this.costingCustomerCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingLotCheckEdit
			//
			this.costingLotCheckEdit.AutoSize = true;
			this.costingLotCheckEdit.Checked = true;
			this.costingLotCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingLotCheckEdit.Location = new System.Drawing.Point(3, 72);
			this.costingLotCheckEdit.Name = "costingLotCheckEdit";
			this.costingLotCheckEdit.Size = new System.Drawing.Size(41, 17);
			this.costingLotCheckEdit.TabIndex = 39;
			this.costingLotCheckEdit.Text = "Lot";
			this.costingLotCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingItemCodeCheckEdit
			//
			this.costingItemCodeCheckEdit.AutoSize = true;
			this.costingItemCodeCheckEdit.Checked = true;
			this.costingItemCodeCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingItemCodeCheckEdit.Location = new System.Drawing.Point(3, 95);
			this.costingItemCodeCheckEdit.Name = "costingItemCodeCheckEdit";
			this.costingItemCodeCheckEdit.Size = new System.Drawing.Size(76, 17);
			this.costingItemCodeCheckEdit.TabIndex = 40;
			this.costingItemCodeCheckEdit.Text = "Item Code";
			this.costingItemCodeCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingItemDescriptionCheckEdit
			//
			this.costingItemDescriptionCheckEdit.AutoSize = true;
			this.costingItemDescriptionCheckEdit.Checked = true;
			this.costingItemDescriptionCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingItemDescriptionCheckEdit.Location = new System.Drawing.Point(3, 118);
			this.costingItemDescriptionCheckEdit.Name = "costingItemDescriptionCheckEdit";
			this.costingItemDescriptionCheckEdit.Size = new System.Drawing.Size(104, 17);
			this.costingItemDescriptionCheckEdit.TabIndex = 41;
			this.costingItemDescriptionCheckEdit.Text = "Item Description";
			this.costingItemDescriptionCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingStartTimeCheckEdit
			//
			this.costingStartTimeCheckEdit.AutoSize = true;
			this.costingStartTimeCheckEdit.Checked = true;
			this.costingStartTimeCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingStartTimeCheckEdit.Location = new System.Drawing.Point(3, 141);
			this.costingStartTimeCheckEdit.Name = "costingStartTimeCheckEdit";
			this.costingStartTimeCheckEdit.Size = new System.Drawing.Size(75, 17);
			this.costingStartTimeCheckEdit.TabIndex = 42;
			this.costingStartTimeCheckEdit.Text = "Start Time";
			this.costingStartTimeCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingStopTimeCheckEdit
			//
			this.costingStopTimeCheckEdit.AutoSize = true;
			this.costingStopTimeCheckEdit.Checked = true;
			this.costingStopTimeCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingStopTimeCheckEdit.Location = new System.Drawing.Point(3, 164);
			this.costingStopTimeCheckEdit.Name = "costingStopTimeCheckEdit";
			this.costingStopTimeCheckEdit.Size = new System.Drawing.Size(73, 17);
			this.costingStopTimeCheckEdit.TabIndex = 43;
			this.costingStopTimeCheckEdit.Text = "Stop Time";
			this.costingStopTimeCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingTotalHoursCheckEdit
			//
			this.costingTotalHoursCheckEdit.AutoSize = true;
			this.costingTotalHoursCheckEdit.Checked = true;
			this.costingTotalHoursCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingTotalHoursCheckEdit.Location = new System.Drawing.Point(3, 187);
			this.costingTotalHoursCheckEdit.Name = "costingTotalHoursCheckEdit";
			this.costingTotalHoursCheckEdit.Size = new System.Drawing.Size(81, 17);
			this.costingTotalHoursCheckEdit.TabIndex = 44;
			this.costingTotalHoursCheckEdit.Text = "Total Hours";
			this.costingTotalHoursCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingTotalMinutesCheckEdit
			//
			this.costingTotalMinutesCheckEdit.AutoSize = true;
			this.costingTotalMinutesCheckEdit.Checked = true;
			this.costingTotalMinutesCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingTotalMinutesCheckEdit.Location = new System.Drawing.Point(3, 210);
			this.costingTotalMinutesCheckEdit.Name = "costingTotalMinutesCheckEdit";
			this.costingTotalMinutesCheckEdit.Size = new System.Drawing.Size(90, 17);
			this.costingTotalMinutesCheckEdit.TabIndex = 45;
			this.costingTotalMinutesCheckEdit.Text = "Total Minutes";
			this.costingTotalMinutesCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingQuantityCheckEdit
			//
			this.costingQuantityCheckEdit.AutoSize = true;
			this.costingQuantityCheckEdit.Checked = true;
			this.costingQuantityCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingQuantityCheckEdit.Location = new System.Drawing.Point(3, 233);
			this.costingQuantityCheckEdit.Name = "costingQuantityCheckEdit";
			this.costingQuantityCheckEdit.Size = new System.Drawing.Size(68, 17);
			this.costingQuantityCheckEdit.TabIndex = 46;
			this.costingQuantityCheckEdit.Text = "Quantity";
			this.costingQuantityCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingExpectedCheckEdit
			//
			this.costingExpectedCheckEdit.AutoSize = true;
			this.costingExpectedCheckEdit.Checked = true;
			this.costingExpectedCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingExpectedCheckEdit.Location = new System.Drawing.Point(3, 256);
			this.costingExpectedCheckEdit.Name = "costingExpectedCheckEdit";
			this.costingExpectedCheckEdit.Size = new System.Drawing.Size(71, 17);
			this.costingExpectedCheckEdit.TabIndex = 47;
			this.costingExpectedCheckEdit.Text = "Expected";
			this.costingExpectedCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingDifferenceCheckEdit
			//
			this.costingDifferenceCheckEdit.AutoSize = true;
			this.costingDifferenceCheckEdit.Checked = true;
			this.costingDifferenceCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingDifferenceCheckEdit.Location = new System.Drawing.Point(3, 279);
			this.costingDifferenceCheckEdit.Name = "costingDifferenceCheckEdit";
			this.costingDifferenceCheckEdit.Size = new System.Drawing.Size(76, 17);
			this.costingDifferenceCheckEdit.TabIndex = 48;
			this.costingDifferenceCheckEdit.Text = "Difference";
			this.costingDifferenceCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingMachineLineCheckEdit
			//
			this.costingMachineLineCheckEdit.AutoSize = true;
			this.costingMachineLineCheckEdit.Checked = true;
			this.costingMachineLineCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingMachineLineCheckEdit.Location = new System.Drawing.Point(3, 302);
			this.costingMachineLineCheckEdit.Name = "costingMachineLineCheckEdit";
			this.costingMachineLineCheckEdit.Size = new System.Drawing.Size(87, 17);
			this.costingMachineLineCheckEdit.TabIndex = 49;
			this.costingMachineLineCheckEdit.Text = "Machine Line";
			this.costingMachineLineCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingMachineSpeedCheckEdit
			//
			this.costingMachineSpeedCheckEdit.AutoSize = true;
			this.costingMachineSpeedCheckEdit.Checked = true;
			this.costingMachineSpeedCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingMachineSpeedCheckEdit.Location = new System.Drawing.Point(3, 325);
			this.costingMachineSpeedCheckEdit.Name = "costingMachineSpeedCheckEdit";
			this.costingMachineSpeedCheckEdit.Size = new System.Drawing.Size(98, 17);
			this.costingMachineSpeedCheckEdit.TabIndex = 50;
			this.costingMachineSpeedCheckEdit.Text = "Machine Speed";
			this.costingMachineSpeedCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingActualSpeedCheckEdit
			//
			this.costingActualSpeedCheckEdit.AutoSize = true;
			this.costingActualSpeedCheckEdit.Checked = true;
			this.costingActualSpeedCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingActualSpeedCheckEdit.Location = new System.Drawing.Point(3, 348);
			this.costingActualSpeedCheckEdit.Name = "costingActualSpeedCheckEdit";
			this.costingActualSpeedCheckEdit.Size = new System.Drawing.Size(89, 17);
			this.costingActualSpeedCheckEdit.TabIndex = 51;
			this.costingActualSpeedCheckEdit.Text = "Actual Speed";
			this.costingActualSpeedCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingOperatorsCheckEdit
			//
			this.costingOperatorsCheckEdit.AutoSize = true;
			this.costingOperatorsCheckEdit.Checked = true;
			this.costingOperatorsCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingOperatorsCheckEdit.Location = new System.Drawing.Point(3, 371);
			this.costingOperatorsCheckEdit.Name = "costingOperatorsCheckEdit";
			this.costingOperatorsCheckEdit.Size = new System.Drawing.Size(75, 17);
			this.costingOperatorsCheckEdit.TabIndex = 52;
			this.costingOperatorsCheckEdit.Text = "Operators";
			this.costingOperatorsCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingPackersCheckEdit
			//
			this.costingPackersCheckEdit.AutoSize = true;
			this.costingPackersCheckEdit.Checked = true;
			this.costingPackersCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingPackersCheckEdit.Location = new System.Drawing.Point(3, 394);
			this.costingPackersCheckEdit.Name = "costingPackersCheckEdit";
			this.costingPackersCheckEdit.Size = new System.Drawing.Size(63, 17);
			this.costingPackersCheckEdit.TabIndex = 53;
			this.costingPackersCheckEdit.Text = "Packers";
			this.costingPackersCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingSupersCheckEdit
			//
			this.costingSupersCheckEdit.AutoSize = true;
			this.costingSupersCheckEdit.Checked = true;
			this.costingSupersCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingSupersCheckEdit.Location = new System.Drawing.Point(3, 417);
			this.costingSupersCheckEdit.Name = "costingSupersCheckEdit";
			this.costingSupersCheckEdit.Size = new System.Drawing.Size(59, 17);
			this.costingSupersCheckEdit.TabIndex = 54;
			this.costingSupersCheckEdit.Text = "Supers";
			this.costingSupersCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingPriceCheckEdit
			//
			this.costingPriceCheckEdit.AutoSize = true;
			this.costingPriceCheckEdit.Checked = true;
			this.costingPriceCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingPriceCheckEdit.Location = new System.Drawing.Point(3, 440);
			this.costingPriceCheckEdit.Name = "costingPriceCheckEdit";
			this.costingPriceCheckEdit.Size = new System.Drawing.Size(49, 17);
			this.costingPriceCheckEdit.TabIndex = 56;
			this.costingPriceCheckEdit.Text = "Price";
			this.costingPriceCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingPayrollCheckEdit
			//
			this.costingPayrollCheckEdit.AutoSize = true;
			this.costingPayrollCheckEdit.Checked = true;
			this.costingPayrollCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingPayrollCheckEdit.Location = new System.Drawing.Point(112, 3);
			this.costingPayrollCheckEdit.Name = "costingPayrollCheckEdit";
			this.costingPayrollCheckEdit.Size = new System.Drawing.Size(58, 17);
			this.costingPayrollCheckEdit.TabIndex = 55;
			this.costingPayrollCheckEdit.Text = "Payroll";
			this.costingPayrollCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingRebateCheckEdit
			//
			this.costingRebateCheckEdit.AutoSize = true;
			this.costingRebateCheckEdit.Checked = true;
			this.costingRebateCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingRebateCheckEdit.Location = new System.Drawing.Point(112, 26);
			this.costingRebateCheckEdit.Name = "costingRebateCheckEdit";
			this.costingRebateCheckEdit.Size = new System.Drawing.Size(61, 17);
			this.costingRebateCheckEdit.TabIndex = 57;
			this.costingRebateCheckEdit.Text = "Rebate";
			this.costingRebateCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingFreightCheckEdit
			//
			this.costingFreightCheckEdit.AutoSize = true;
			this.costingFreightCheckEdit.Checked = true;
			this.costingFreightCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingFreightCheckEdit.Location = new System.Drawing.Point(112, 49);
			this.costingFreightCheckEdit.Name = "costingFreightCheckEdit";
			this.costingFreightCheckEdit.Size = new System.Drawing.Size(60, 17);
			this.costingFreightCheckEdit.TabIndex = 65;
			this.costingFreightCheckEdit.Text = "Freight";
			this.costingFreightCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingFilmCheckEdit
			//
			this.costingFilmCheckEdit.AutoSize = true;
			this.costingFilmCheckEdit.Checked = true;
			this.costingFilmCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingFilmCheckEdit.Location = new System.Drawing.Point(112, 72);
			this.costingFilmCheckEdit.Name = "costingFilmCheckEdit";
			this.costingFilmCheckEdit.Size = new System.Drawing.Size(44, 17);
			this.costingFilmCheckEdit.TabIndex = 66;
			this.costingFilmCheckEdit.Text = "Film";
			this.costingFilmCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingBoxesCheckEdit
			//
			this.costingBoxesCheckEdit.AutoSize = true;
			this.costingBoxesCheckEdit.Checked = true;
			this.costingBoxesCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingBoxesCheckEdit.Location = new System.Drawing.Point(112, 95);
			this.costingBoxesCheckEdit.Name = "costingBoxesCheckEdit";
			this.costingBoxesCheckEdit.Size = new System.Drawing.Size(55, 17);
			this.costingBoxesCheckEdit.TabIndex = 67;
			this.costingBoxesCheckEdit.Text = "Boxes";
			this.costingBoxesCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingStretchWrapCheckEdit
			//
			this.costingStretchWrapCheckEdit.AutoSize = true;
			this.costingStretchWrapCheckEdit.Checked = true;
			this.costingStretchWrapCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingStretchWrapCheckEdit.Location = new System.Drawing.Point(112, 118);
			this.costingStretchWrapCheckEdit.Name = "costingStretchWrapCheckEdit";
			this.costingStretchWrapCheckEdit.Size = new System.Drawing.Size(90, 17);
			this.costingStretchWrapCheckEdit.TabIndex = 68;
			this.costingStretchWrapCheckEdit.Text = "Stretch Wrap";
			this.costingStretchWrapCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingPalletsCheckEdit
			//
			this.costingPalletsCheckEdit.AutoSize = true;
			this.costingPalletsCheckEdit.Checked = true;
			this.costingPalletsCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingPalletsCheckEdit.Location = new System.Drawing.Point(112, 141);
			this.costingPalletsCheckEdit.Name = "costingPalletsCheckEdit";
			this.costingPalletsCheckEdit.Size = new System.Drawing.Size(57, 17);
			this.costingPalletsCheckEdit.TabIndex = 69;
			this.costingPalletsCheckEdit.Text = "Pallets";
			this.costingPalletsCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingTotalOtherCheckEdit
			//
			this.costingTotalOtherCheckEdit.AutoSize = true;
			this.costingTotalOtherCheckEdit.Checked = true;
			this.costingTotalOtherCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingTotalOtherCheckEdit.Location = new System.Drawing.Point(112, 164);
			this.costingTotalOtherCheckEdit.Name = "costingTotalOtherCheckEdit";
			this.costingTotalOtherCheckEdit.Size = new System.Drawing.Size(81, 17);
			this.costingTotalOtherCheckEdit.TabIndex = 70;
			this.costingTotalOtherCheckEdit.Text = "Total Other";
			this.costingTotalOtherCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingCostCheckBox
			//
			this.costingCostCheckBox.AutoSize = true;
			this.costingCostCheckBox.Checked = true;
			this.costingCostCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingCostCheckBox.Location = new System.Drawing.Point(112, 187);
			this.costingCostCheckBox.Name = "costingCostCheckBox";
			this.costingCostCheckBox.Size = new System.Drawing.Size(48, 17);
			this.costingCostCheckBox.TabIndex = 58;
			this.costingCostCheckBox.Text = "Cost";
			this.costingCostCheckBox.UseVisualStyleBackColor = true;
			//
			//costingProfitCheckEdit
			//
			this.costingProfitCheckEdit.AutoSize = true;
			this.costingProfitCheckEdit.Checked = true;
			this.costingProfitCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingProfitCheckEdit.Location = new System.Drawing.Point(112, 210);
			this.costingProfitCheckEdit.Name = "costingProfitCheckEdit";
			this.costingProfitCheckEdit.Size = new System.Drawing.Size(52, 17);
			this.costingProfitCheckEdit.TabIndex = 59;
			this.costingProfitCheckEdit.Text = "Profit";
			this.costingProfitCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingCostPerPieceCheckEdit
			//
			this.costingCostPerPieceCheckEdit.AutoSize = true;
			this.costingCostPerPieceCheckEdit.Checked = true;
			this.costingCostPerPieceCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingCostPerPieceCheckEdit.Location = new System.Drawing.Point(112, 233);
			this.costingCostPerPieceCheckEdit.Name = "costingCostPerPieceCheckEdit";
			this.costingCostPerPieceCheckEdit.Size = new System.Drawing.Size(95, 17);
			this.costingCostPerPieceCheckEdit.TabIndex = 60;
			this.costingCostPerPieceCheckEdit.Text = "Cost Per Piece";
			this.costingCostPerPieceCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingPacksPerMinuteCheckEdit
			//
			this.costingPacksPerMinuteCheckEdit.AutoSize = true;
			this.costingPacksPerMinuteCheckEdit.Checked = true;
			this.costingPacksPerMinuteCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingPacksPerMinuteCheckEdit.Location = new System.Drawing.Point(112, 256);
			this.costingPacksPerMinuteCheckEdit.Name = "costingPacksPerMinuteCheckEdit";
			this.costingPacksPerMinuteCheckEdit.Size = new System.Drawing.Size(107, 17);
			this.costingPacksPerMinuteCheckEdit.TabIndex = 61;
			this.costingPacksPerMinuteCheckEdit.Text = "Packs Per Minute";
			this.costingPacksPerMinuteCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingSalesVsPayrollCheckEdit
			//
			this.costingSalesVsPayrollCheckEdit.AutoSize = true;
			this.costingSalesVsPayrollCheckEdit.Checked = true;
			this.costingSalesVsPayrollCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingSalesVsPayrollCheckEdit.Location = new System.Drawing.Point(112, 279);
			this.costingSalesVsPayrollCheckEdit.Name = "costingSalesVsPayrollCheckEdit";
			this.costingSalesVsPayrollCheckEdit.Size = new System.Drawing.Size(104, 17);
			this.costingSalesVsPayrollCheckEdit.TabIndex = 62;
			this.costingSalesVsPayrollCheckEdit.Text = "Sales vs. Payroll";
			this.costingSalesVsPayrollCheckEdit.UseVisualStyleBackColor = true;
			//
			//CostingSalesVsCostCheckEdit
			//
			this.CostingSalesVsCostCheckEdit.AutoSize = true;
			this.CostingSalesVsCostCheckEdit.Checked = true;
			this.CostingSalesVsCostCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.CostingSalesVsCostCheckEdit.Location = new System.Drawing.Point(112, 302);
			this.CostingSalesVsCostCheckEdit.Name = "CostingSalesVsCostCheckEdit";
			this.CostingSalesVsCostCheckEdit.Size = new System.Drawing.Size(94, 17);
			this.CostingSalesVsCostCheckEdit.TabIndex = 63;
			this.CostingSalesVsCostCheckEdit.Text = "Sales vs. Cost";
			this.CostingSalesVsCostCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingProfitVsSalesCheckEdit
			//
			this.costingProfitVsSalesCheckEdit.AutoSize = true;
			this.costingProfitVsSalesCheckEdit.Checked = true;
			this.costingProfitVsSalesCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingProfitVsSalesCheckEdit.Location = new System.Drawing.Point(112, 325);
			this.costingProfitVsSalesCheckEdit.Name = "costingProfitVsSalesCheckEdit";
			this.costingProfitVsSalesCheckEdit.Size = new System.Drawing.Size(98, 17);
			this.costingProfitVsSalesCheckEdit.TabIndex = 64;
			this.costingProfitVsSalesCheckEdit.Text = "Profit vs. Sales";
			this.costingProfitVsSalesCheckEdit.UseVisualStyleBackColor = true;
			//
			//costingSalesVsProfitCheckEdit
			//
			this.costingSalesVsProfitCheckEdit.AutoSize = true;
			this.costingSalesVsProfitCheckEdit.Checked = true;
			this.costingSalesVsProfitCheckEdit.CheckState = System.Windows.Forms.CheckState.Checked;
			this.costingSalesVsProfitCheckEdit.Location = new System.Drawing.Point(112, 348);
			this.costingSalesVsProfitCheckEdit.Name = "costingSalesVsProfitCheckEdit";
			this.costingSalesVsProfitCheckEdit.Size = new System.Drawing.Size(98, 17);
			this.costingSalesVsProfitCheckEdit.TabIndex = 71;
			this.costingSalesVsProfitCheckEdit.Text = "Sales vs. Profit";
			this.costingSalesVsProfitCheckEdit.UseVisualStyleBackColor = true;
			//
			//productionMachineXtraTabPage
			//
			this.productionMachineXtraTabPage.Controls.Add(this.productionMachineXtraScrollableControl);
			this.productionMachineXtraTabPage.Name = "productionMachineXtraTabPage";
			this.productionMachineXtraTabPage.Size = new System.Drawing.Size(185, 471);
			this.productionMachineXtraTabPage.Text = "Production Machine";
			//
			//productionMachineXtraScrollableControl
			//
			this.productionMachineXtraScrollableControl.Controls.Add(this.pmsTotalSalesCheckEdit);
			this.productionMachineXtraScrollableControl.Controls.Add(this.pmsPriceCheckEdit);
			this.productionMachineXtraScrollableControl.Controls.Add(this.pmsQuantityCheckEdit);
			this.productionMachineXtraScrollableControl.Controls.Add(this.pmsProjectedSpeedCheckEdit);
			this.productionMachineXtraScrollableControl.Controls.Add(this.pmsAverageSpeedCheckEdit);
			this.productionMachineXtraScrollableControl.Controls.Add(this.pmsSpeedVariationVolCheckEdit);
			this.productionMachineXtraScrollableControl.Controls.Add(this.pmsSpeedVariationPerCheckEdit);
			this.productionMachineXtraScrollableControl.Controls.Add(this.pmsProjectedPackersCheckEdit);
			this.productionMachineXtraScrollableControl.Controls.Add(this.pmsPackersCheckEdit);
			this.productionMachineXtraScrollableControl.Controls.Add(this.pmsPackersVariationVolCheckEdit);
			this.productionMachineXtraScrollableControl.Controls.Add(this.pmsPackersVariationPerCheckEdit);
			this.productionMachineXtraScrollableControl.Controls.Add(this.pmsSalesVsPayrollCheckEdit);
			this.productionMachineXtraScrollableControl.Controls.Add(this.pmsPricePerPieceCheckEdit);
			this.productionMachineXtraScrollableControl.Controls.Add(this.pmsCostVariationCheckEdit);
			this.productionMachineXtraScrollableControl.Controls.Add(this.pmsCostCheckEdit);
			this.productionMachineXtraScrollableControl.Controls.Add(this.pmsProjectedCostCheckEdit);
			this.productionMachineXtraScrollableControl.Controls.Add(this.pmsCostVariationPerCheckEdit);
			this.productionMachineXtraScrollableControl.Controls.Add(this.pmsTotalMinutesCheckEdit);
			this.productionMachineXtraScrollableControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.productionMachineXtraScrollableControl.Location = new System.Drawing.Point(0, 0);
			this.productionMachineXtraScrollableControl.Name = "productionMachineXtraScrollableControl";
			this.productionMachineXtraScrollableControl.Size = new System.Drawing.Size(185, 471);
			this.productionMachineXtraScrollableControl.TabIndex = 2;
			//
			//pmsTotalSalesCheckEdit
			//
			this.pmsTotalSalesCheckEdit.EditValue = true;
			this.pmsTotalSalesCheckEdit.Location = new System.Drawing.Point(4, 293);
			this.pmsTotalSalesCheckEdit.Name = "pmsTotalSalesCheckEdit";
			this.pmsTotalSalesCheckEdit.Properties.Caption = "Total Sales";
			this.pmsTotalSalesCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.pmsTotalSalesCheckEdit.TabIndex = 20;
			//
			//pmsPriceCheckEdit
			//
			this.pmsPriceCheckEdit.EditValue = true;
			this.pmsPriceCheckEdit.Location = new System.Drawing.Point(4, 275);
			this.pmsPriceCheckEdit.Name = "pmsPriceCheckEdit";
			this.pmsPriceCheckEdit.Properties.Caption = "Sales Price per Case";
			this.pmsPriceCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.pmsPriceCheckEdit.TabIndex = 19;
			//
			//pmsQuantityCheckEdit
			//
			this.pmsQuantityCheckEdit.EditValue = true;
			this.pmsQuantityCheckEdit.Location = new System.Drawing.Point(4, 20);
			this.pmsQuantityCheckEdit.Name = "pmsQuantityCheckEdit";
			this.pmsQuantityCheckEdit.Properties.Caption = "Quantity";
			this.pmsQuantityCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.pmsQuantityCheckEdit.TabIndex = 18;
			//
			//pmsProjectedSpeedCheckEdit
			//
			this.pmsProjectedSpeedCheckEdit.EditValue = true;
			this.pmsProjectedSpeedCheckEdit.Location = new System.Drawing.Point(4, 37);
			this.pmsProjectedSpeedCheckEdit.Name = "pmsProjectedSpeedCheckEdit";
			this.pmsProjectedSpeedCheckEdit.Properties.Caption = "Projected Speed";
			this.pmsProjectedSpeedCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.pmsProjectedSpeedCheckEdit.TabIndex = 17;
			//
			//pmsAverageSpeedCheckEdit
			//
			this.pmsAverageSpeedCheckEdit.EditValue = true;
			this.pmsAverageSpeedCheckEdit.Location = new System.Drawing.Point(4, 54);
			this.pmsAverageSpeedCheckEdit.Name = "pmsAverageSpeedCheckEdit";
			this.pmsAverageSpeedCheckEdit.Properties.Caption = "Average Actual Speed";
			this.pmsAverageSpeedCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.pmsAverageSpeedCheckEdit.TabIndex = 16;
			//
			//pmsSpeedVariationVolCheckEdit
			//
			this.pmsSpeedVariationVolCheckEdit.EditValue = true;
			this.pmsSpeedVariationVolCheckEdit.Location = new System.Drawing.Point(4, 71);
			this.pmsSpeedVariationVolCheckEdit.Name = "pmsSpeedVariationVolCheckEdit";
			this.pmsSpeedVariationVolCheckEdit.Properties.Caption = "Speed Variation Volume";
			this.pmsSpeedVariationVolCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.pmsSpeedVariationVolCheckEdit.TabIndex = 15;
			//
			//pmsSpeedVariationPerCheckEdit
			//
			this.pmsSpeedVariationPerCheckEdit.EditValue = true;
			this.pmsSpeedVariationPerCheckEdit.Location = new System.Drawing.Point(4, 88);
			this.pmsSpeedVariationPerCheckEdit.Name = "pmsSpeedVariationPerCheckEdit";
			this.pmsSpeedVariationPerCheckEdit.Properties.Caption = "Speed Variation %";
			this.pmsSpeedVariationPerCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.pmsSpeedVariationPerCheckEdit.TabIndex = 14;
			//
			//pmsProjectedPackersCheckEdit
			//
			this.pmsProjectedPackersCheckEdit.EditValue = true;
			this.pmsProjectedPackersCheckEdit.Location = new System.Drawing.Point(4, 105);
			this.pmsProjectedPackersCheckEdit.Name = "pmsProjectedPackersCheckEdit";
			this.pmsProjectedPackersCheckEdit.Properties.Caption = "Projected Packers";
			this.pmsProjectedPackersCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.pmsProjectedPackersCheckEdit.TabIndex = 13;
			//
			//pmsPackersCheckEdit
			//
			this.pmsPackersCheckEdit.EditValue = true;
			this.pmsPackersCheckEdit.Location = new System.Drawing.Point(4, 122);
			this.pmsPackersCheckEdit.Name = "pmsPackersCheckEdit";
			this.pmsPackersCheckEdit.Properties.Caption = "Average Actual Packers";
			this.pmsPackersCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.pmsPackersCheckEdit.TabIndex = 12;
			//
			//pmsPackersVariationVolCheckEdit
			//
			this.pmsPackersVariationVolCheckEdit.EditValue = true;
			this.pmsPackersVariationVolCheckEdit.Location = new System.Drawing.Point(4, 139);
			this.pmsPackersVariationVolCheckEdit.Name = "pmsPackersVariationVolCheckEdit";
			this.pmsPackersVariationVolCheckEdit.Properties.Caption = "Packers Variation Volume";
			this.pmsPackersVariationVolCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.pmsPackersVariationVolCheckEdit.TabIndex = 11;
			//
			//pmsPackersVariationPerCheckEdit
			//
			this.pmsPackersVariationPerCheckEdit.EditValue = true;
			this.pmsPackersVariationPerCheckEdit.Location = new System.Drawing.Point(4, 156);
			this.pmsPackersVariationPerCheckEdit.Name = "pmsPackersVariationPerCheckEdit";
			this.pmsPackersVariationPerCheckEdit.Properties.Caption = "Packers Variation %";
			this.pmsPackersVariationPerCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.pmsPackersVariationPerCheckEdit.TabIndex = 10;
			//
			//pmsSalesVsPayrollCheckEdit
			//
			this.pmsSalesVsPayrollCheckEdit.EditValue = true;
			this.pmsSalesVsPayrollCheckEdit.Location = new System.Drawing.Point(4, 258);
			this.pmsSalesVsPayrollCheckEdit.Name = "pmsSalesVsPayrollCheckEdit";
			this.pmsSalesVsPayrollCheckEdit.Properties.Caption = "Sales vs Payroll";
			this.pmsSalesVsPayrollCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.pmsSalesVsPayrollCheckEdit.TabIndex = 8;
			//
			//pmsPricePerPieceCheckEdit
			//
			this.pmsPricePerPieceCheckEdit.EditValue = true;
			this.pmsPricePerPieceCheckEdit.Location = new System.Drawing.Point(4, 241);
			this.pmsPricePerPieceCheckEdit.Name = "pmsPricePerPieceCheckEdit";
			this.pmsPricePerPieceCheckEdit.Properties.Caption = "Sales Price per Piece";
			this.pmsPricePerPieceCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.pmsPricePerPieceCheckEdit.TabIndex = 7;
			//
			//pmsCostVariationCheckEdit
			//
			this.pmsCostVariationCheckEdit.EditValue = true;
			this.pmsCostVariationCheckEdit.Location = new System.Drawing.Point(4, 207);
			this.pmsCostVariationCheckEdit.Name = "pmsCostVariationCheckEdit";
			this.pmsCostVariationCheckEdit.Properties.Caption = "Cost Variation";
			this.pmsCostVariationCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.pmsCostVariationCheckEdit.TabIndex = 5;
			//
			//pmsCostCheckEdit
			//
			this.pmsCostCheckEdit.EditValue = true;
			this.pmsCostCheckEdit.Location = new System.Drawing.Point(4, 190);
			this.pmsCostCheckEdit.Name = "pmsCostCheckEdit";
			this.pmsCostCheckEdit.Properties.Caption = "Average Actual Cost";
			this.pmsCostCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.pmsCostCheckEdit.TabIndex = 4;
			//
			//pmsProjectedCostCheckEdit
			//
			this.pmsProjectedCostCheckEdit.EditValue = true;
			this.pmsProjectedCostCheckEdit.Location = new System.Drawing.Point(4, 173);
			this.pmsProjectedCostCheckEdit.Name = "pmsProjectedCostCheckEdit";
			this.pmsProjectedCostCheckEdit.Properties.Caption = "Projected Cost";
			this.pmsProjectedCostCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.pmsProjectedCostCheckEdit.TabIndex = 3;
			//
			//pmsCostVariationPerCheckEdit
			//
			this.pmsCostVariationPerCheckEdit.EditValue = true;
			this.pmsCostVariationPerCheckEdit.Location = new System.Drawing.Point(4, 224);
			this.pmsCostVariationPerCheckEdit.Name = "pmsCostVariationPerCheckEdit";
			this.pmsCostVariationPerCheckEdit.Properties.Caption = "Cost Variation %";
			this.pmsCostVariationPerCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.pmsCostVariationPerCheckEdit.TabIndex = 1;
			//
			//pmsTotalMinutesCheckEdit
			//
			this.pmsTotalMinutesCheckEdit.EditValue = true;
			this.pmsTotalMinutesCheckEdit.Location = new System.Drawing.Point(4, 3);
			this.pmsTotalMinutesCheckEdit.Name = "pmsTotalMinutesCheckEdit";
			this.pmsTotalMinutesCheckEdit.Properties.Caption = "Total Minutes";
			this.pmsTotalMinutesCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.pmsTotalMinutesCheckEdit.TabIndex = 0;
			//
			//palletTransactionXtraTabPage
			//
			this.palletTransactionXtraTabPage.Controls.Add(this.XtraScrollableControl1);
			this.palletTransactionXtraTabPage.Name = "palletTransactionXtraTabPage";
			this.palletTransactionXtraTabPage.Size = new System.Drawing.Size(185, 471);
			this.palletTransactionXtraTabPage.Text = "Pallet Transaction";
			//
			//XtraScrollableControl1
			//
			this.XtraScrollableControl1.Controls.Add(this.ptReceivedCheckEdit);
			this.XtraScrollableControl1.Controls.Add(this.ptDestinationCheckEdit);
			this.XtraScrollableControl1.Controls.Add(this.ptShippedCheckEdit);
			this.XtraScrollableControl1.Controls.Add(this.ptVendorCheckEdit);
			this.XtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.XtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
			this.XtraScrollableControl1.Name = "XtraScrollableControl1";
			this.XtraScrollableControl1.Size = new System.Drawing.Size(185, 471);
			this.XtraScrollableControl1.TabIndex = 3;
			//
			//ptReceivedCheckEdit
			//
			this.ptReceivedCheckEdit.EditValue = true;
			this.ptReceivedCheckEdit.Location = new System.Drawing.Point(4, 20);
			this.ptReceivedCheckEdit.Name = "ptReceivedCheckEdit";
			this.ptReceivedCheckEdit.Properties.Caption = "Received";
			this.ptReceivedCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.ptReceivedCheckEdit.TabIndex = 18;
			//
			//ptDestinationCheckEdit
			//
			this.ptDestinationCheckEdit.EditValue = true;
			this.ptDestinationCheckEdit.Location = new System.Drawing.Point(4, 37);
			this.ptDestinationCheckEdit.Name = "ptDestinationCheckEdit";
			this.ptDestinationCheckEdit.Properties.Caption = "Destination";
			this.ptDestinationCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.ptDestinationCheckEdit.TabIndex = 17;
			//
			//ptShippedCheckEdit
			//
			this.ptShippedCheckEdit.EditValue = true;
			this.ptShippedCheckEdit.Location = new System.Drawing.Point(4, 54);
			this.ptShippedCheckEdit.Name = "ptShippedCheckEdit";
			this.ptShippedCheckEdit.Properties.Caption = "Shipped";
			this.ptShippedCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.ptShippedCheckEdit.TabIndex = 16;
			//
			//ptVendorCheckEdit
			//
			this.ptVendorCheckEdit.EditValue = true;
			this.ptVendorCheckEdit.Location = new System.Drawing.Point(4, 3);
			this.ptVendorCheckEdit.Name = "ptVendorCheckEdit";
			this.ptVendorCheckEdit.Properties.Caption = "Vendor";
			this.ptVendorCheckEdit.Size = new System.Drawing.Size(158, 19);
			this.ptVendorCheckEdit.TabIndex = 0;
			//
			//columnsRefreshSimpleButton
			//
			this.columnsRefreshSimpleButton.Location = new System.Drawing.Point(3, 3);
			this.columnsRefreshSimpleButton.Name = "columnsRefreshSimpleButton";
			this.columnsRefreshSimpleButton.Size = new System.Drawing.Size(188, 23);
			this.columnsRefreshSimpleButton.TabIndex = 0;
			this.columnsRefreshSimpleButton.Text = "Refresh Report";
			//
			//filterDockPanel
			//
			this.filterDockPanel.AutoScroll = true;
			this.filterDockPanel.Controls.Add(this.ControlContainer1);
			this.filterDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
			this.filterDockPanel.ID = new System.Guid("5c939b8d-89a3-4217-974e-a7b7550ec50b");
			this.filterDockPanel.Location = new System.Drawing.Point(19, 53);
			this.filterDockPanel.Name = "filterDockPanel";
			this.filterDockPanel.OriginalSize = new System.Drawing.Size(200, 200);
			this.filterDockPanel.Size = new System.Drawing.Size(200, 526);
			this.filterDockPanel.Text = "Filter";
			//
			//ControlContainer1
			//
			this.ControlContainer1.Controls.Add(this.outOfStockCheckEdit);
			this.ControlContainer1.Controls.Add(this.vendorLookUpEdit);
			this.ControlContainer1.Controls.Add(this.InactiveCustomersCheckEdit);
			this.ControlContainer1.Controls.Add(this.InactiveItemsCheckEdit);
			this.ControlContainer1.Controls.Add(this.LabelControl14);
			this.ControlContainer1.Controls.Add(this.LabelControl13);
			this.ControlContainer1.Controls.Add(this.itemTypeLookUpEdit);
			this.ControlContainer1.Controls.Add(this.carrierLookUpEdit);
			this.ControlContainer1.Controls.Add(this.LabelControl12);
			this.ControlContainer1.Controls.Add(this.LabelControl11);
			this.ControlContainer1.Controls.Add(this.destinationLookUpEdit);
			this.ControlContainer1.Controls.Add(this.deliveryNoteNumberTextEdit);
			this.ControlContainer1.Controls.Add(this.LabelControl10);
			this.ControlContainer1.Controls.Add(this.poTextEdit);
			this.ControlContainer1.Controls.Add(this.lotTextEdit);
			this.ControlContainer1.Controls.Add(this.LabelControl9);
			this.ControlContainer1.Controls.Add(this.bolTextEdit);
			this.ControlContainer1.Controls.Add(this.LabelControl8);
			this.ControlContainer1.Controls.Add(this.LabelControl7);
			this.ControlContainer1.Controls.Add(this.customerLookUpEdit);
			this.ControlContainer1.Controls.Add(this.shiftLookUpEdit);
			this.ControlContainer1.Controls.Add(this.machineLookUpEdit);
			this.ControlContainer1.Controls.Add(this.LabelControl6);
			this.ControlContainer1.Controls.Add(this.LabelControl5);
			this.ControlContainer1.Controls.Add(this.LabelControl4);
			this.ControlContainer1.Controls.Add(this.LabelControl3);
			this.ControlContainer1.Controls.Add(this.LabelControl2);
			this.ControlContainer1.Controls.Add(this.LabelControl1);
			this.ControlContainer1.Controls.Add(this.itemCheckedListBoxControl);
			this.ControlContainer1.Controls.Add(this.toDateEdit);
			this.ControlContainer1.Controls.Add(this.fromDateEdit);
			this.ControlContainer1.Controls.Add(this.detailSimpleButton);
			this.ControlContainer1.Controls.Add(this.filterRefreshSimpleButton);
			this.ControlContainer1.Location = new System.Drawing.Point(4, 23);
			this.ControlContainer1.Name = "ControlContainer1";
			this.ControlContainer1.Size = new System.Drawing.Size(191, 499);
			this.ControlContainer1.TabIndex = 0;
			//
			//outOfStockCheckEdit
			//
			this.outOfStockCheckEdit.Location = new System.Drawing.Point(62, 448);
			this.outOfStockCheckEdit.MenuManager = this.reportsPrintBarManager;
			this.outOfStockCheckEdit.Name = "outOfStockCheckEdit";
			this.outOfStockCheckEdit.Properties.Caption = "Include Out Of Stock Items";
			this.outOfStockCheckEdit.Size = new System.Drawing.Size(157, 19);
			this.outOfStockCheckEdit.TabIndex = 35;
			//
			//vendorLookUpEdit
			//
			this.vendorLookUpEdit.Location = new System.Drawing.Point(64, 379);
			this.vendorLookUpEdit.MenuManager = this.reportsPrintBarManager;
			this.vendorLookUpEdit.Name = "vendorLookUpEdit";
			this.vendorLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.vendorLookUpEdit.Properties.NullText = "";
			this.vendorLookUpEdit.Size = new System.Drawing.Size(154, 20);
			this.vendorLookUpEdit.TabIndex = 34;
			//
			//InactiveCustomersCheckEdit
			//
			this.InactiveCustomersCheckEdit.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.InactiveCustomersCheckEdit.Location = new System.Drawing.Point(64, 165);
			this.InactiveCustomersCheckEdit.MenuManager = this.reportsPrintBarManager;
			this.InactiveCustomersCheckEdit.Name = "InactiveCustomersCheckEdit";
			this.InactiveCustomersCheckEdit.Properties.Caption = "Include Inactive Customers";
			this.InactiveCustomersCheckEdit.Size = new System.Drawing.Size(124, 19);
			this.InactiveCustomersCheckEdit.TabIndex = 33;
			//
			//InactiveItemsCheckEdit
			//
			this.InactiveItemsCheckEdit.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.InactiveItemsCheckEdit.Location = new System.Drawing.Point(62, 431);
			this.InactiveItemsCheckEdit.MenuManager = this.reportsPrintBarManager;
			this.InactiveItemsCheckEdit.Name = "InactiveItemsCheckEdit";
			this.InactiveItemsCheckEdit.Properties.Caption = "Include Inactive Items";
			this.InactiveItemsCheckEdit.Size = new System.Drawing.Size(112, 19);
			this.InactiveItemsCheckEdit.TabIndex = 32;
			//
			//LabelControl14
			//
			this.LabelControl14.Location = new System.Drawing.Point(4, 408);
			this.LabelControl14.Name = "LabelControl14";
			this.LabelControl14.Size = new System.Drawing.Size(53, 13);
			this.LabelControl14.TabIndex = 31;
			this.LabelControl14.Text = "Item Type:";
			//
			//LabelControl13
			//
			this.LabelControl13.Location = new System.Drawing.Point(4, 381);
			this.LabelControl13.Name = "LabelControl13";
			this.LabelControl13.Size = new System.Drawing.Size(38, 13);
			this.LabelControl13.TabIndex = 30;
			this.LabelControl13.Text = "Vendor:";
			//
			//itemTypeLookUpEdit
			//
			this.itemTypeLookUpEdit.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.itemTypeLookUpEdit.Location = new System.Drawing.Point(64, 405);
			this.itemTypeLookUpEdit.Name = "itemTypeLookUpEdit";
			this.itemTypeLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.itemTypeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.itemTypeLookUpEdit.Properties.NullText = "[Select A Item Type]";
			this.itemTypeLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.itemTypeLookUpEdit.Size = new System.Drawing.Size(124, 20);
			this.itemTypeLookUpEdit.TabIndex = 29;
			this.itemTypeLookUpEdit.ToolTip = "Use Ctrl+Del to clear filter";
			//
			//carrierLookUpEdit
			//
			this.carrierLookUpEdit.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.carrierLookUpEdit.Location = new System.Drawing.Point(64, 351);
			this.carrierLookUpEdit.Name = "carrierLookUpEdit";
			this.carrierLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.carrierLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.carrierLookUpEdit.Properties.NullText = "[Select A Carrier]";
			this.carrierLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.carrierLookUpEdit.Size = new System.Drawing.Size(124, 20);
			this.carrierLookUpEdit.TabIndex = 27;
			this.carrierLookUpEdit.ToolTip = "Use Ctrl+Del to clear filter";
			//
			//LabelControl12
			//
			this.LabelControl12.Location = new System.Drawing.Point(4, 354);
			this.LabelControl12.Name = "LabelControl12";
			this.LabelControl12.Size = new System.Drawing.Size(37, 13);
			this.LabelControl12.TabIndex = 26;
			this.LabelControl12.Text = "Carrier:";
			//
			//LabelControl11
			//
			this.LabelControl11.Location = new System.Drawing.Point(4, 327);
			this.LabelControl11.Name = "LabelControl11";
			this.LabelControl11.Size = new System.Drawing.Size(58, 13);
			this.LabelControl11.TabIndex = 25;
			this.LabelControl11.Text = "Destination:";
			//
			//destinationLookUpEdit
			//
			this.destinationLookUpEdit.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.destinationLookUpEdit.Location = new System.Drawing.Point(64, 324);
			this.destinationLookUpEdit.Name = "destinationLookUpEdit";
			this.destinationLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.destinationLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.destinationLookUpEdit.Properties.NullText = "[Select A Destination]";
			this.destinationLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.destinationLookUpEdit.Size = new System.Drawing.Size(124, 20);
			this.destinationLookUpEdit.TabIndex = 24;
			this.destinationLookUpEdit.ToolTip = "Use Ctrl+Del to clear filter";
			//
			//deliveryNoteNumberTextEdit
			//
			this.deliveryNoteNumberTextEdit.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.deliveryNoteNumberTextEdit.Location = new System.Drawing.Point(64, 297);
			this.deliveryNoteNumberTextEdit.Name = "deliveryNoteNumberTextEdit";
			this.deliveryNoteNumberTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.deliveryNoteNumberTextEdit.Properties.NullText = "[Enter A Delivery Note #]";
			this.deliveryNoteNumberTextEdit.Size = new System.Drawing.Size(124, 20);
			this.deliveryNoteNumberTextEdit.TabIndex = 23;
			//
			//LabelControl10
			//
			this.LabelControl10.Location = new System.Drawing.Point(4, 300);
			this.LabelControl10.Name = "LabelControl10";
			this.LabelControl10.Size = new System.Drawing.Size(29, 13);
			this.LabelControl10.TabIndex = 22;
			this.LabelControl10.Text = "DN #:";
			//
			//poTextEdit
			//
			this.poTextEdit.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.poTextEdit.Location = new System.Drawing.Point(64, 243);
			this.poTextEdit.Name = "poTextEdit";
			this.poTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.poTextEdit.Properties.NullText = "[Enter A PO #]";
			this.poTextEdit.Size = new System.Drawing.Size(124, 20);
			this.poTextEdit.TabIndex = 21;
			//
			//lotTextEdit
			//
			this.lotTextEdit.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.lotTextEdit.Location = new System.Drawing.Point(64, 216);
			this.lotTextEdit.Name = "lotTextEdit";
			this.lotTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.lotTextEdit.Properties.NullText = "[Enter A Lot #]";
			this.lotTextEdit.Size = new System.Drawing.Size(124, 20);
			this.lotTextEdit.TabIndex = 20;
			//
			//LabelControl9
			//
			this.LabelControl9.Location = new System.Drawing.Point(4, 273);
			this.LabelControl9.Name = "LabelControl9";
			this.LabelControl9.Size = new System.Drawing.Size(34, 13);
			this.LabelControl9.TabIndex = 19;
			this.LabelControl9.Text = "BOL #:";
			//
			//bolTextEdit
			//
			this.bolTextEdit.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.bolTextEdit.Location = new System.Drawing.Point(64, 270);
			this.bolTextEdit.Name = "bolTextEdit";
			this.bolTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.bolTextEdit.Properties.NullText = "[Enter A BOL #]";
			this.bolTextEdit.Size = new System.Drawing.Size(124, 20);
			this.bolTextEdit.TabIndex = 18;
			//
			//LabelControl8
			//
			this.LabelControl8.Location = new System.Drawing.Point(4, 246);
			this.LabelControl8.Name = "LabelControl8";
			this.LabelControl8.Size = new System.Drawing.Size(29, 13);
			this.LabelControl8.TabIndex = 17;
			this.LabelControl8.Text = "PO #:";
			//
			//LabelControl7
			//
			this.LabelControl7.Location = new System.Drawing.Point(4, 219);
			this.LabelControl7.Name = "LabelControl7";
			this.LabelControl7.Size = new System.Drawing.Size(30, 13);
			this.LabelControl7.TabIndex = 16;
			this.LabelControl7.Text = "Lot #:";
			//
			//customerLookUpEdit
			//
			this.customerLookUpEdit.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.customerLookUpEdit.Location = new System.Drawing.Point(64, 189);
			this.customerLookUpEdit.Name = "customerLookUpEdit";
			this.customerLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.customerLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.customerLookUpEdit.Properties.NullText = "[Select A Customer]";
			this.customerLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.customerLookUpEdit.Size = new System.Drawing.Size(124, 20);
			this.customerLookUpEdit.TabIndex = 13;
			this.customerLookUpEdit.ToolTip = "Use Ctrl+Del to clear filter";
			//
			//shiftLookUpEdit
			//
			this.shiftLookUpEdit.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.shiftLookUpEdit.Location = new System.Drawing.Point(64, 139);
			this.shiftLookUpEdit.Name = "shiftLookUpEdit";
			this.shiftLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.shiftLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.shiftLookUpEdit.Properties.NullText = "[Select A Shift]";
			this.shiftLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.shiftLookUpEdit.Size = new System.Drawing.Size(124, 20);
			this.shiftLookUpEdit.TabIndex = 12;
			this.shiftLookUpEdit.ToolTip = "Use Ctrl+Del to clear filter";
			//
			//machineLookUpEdit
			//
			this.machineLookUpEdit.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.machineLookUpEdit.Location = new System.Drawing.Point(64, 113);
			this.machineLookUpEdit.Name = "machineLookUpEdit";
			this.machineLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.machineLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.machineLookUpEdit.Properties.NullText = "[Select A Machine]";
			this.machineLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.machineLookUpEdit.Size = new System.Drawing.Size(124, 20);
			this.machineLookUpEdit.TabIndex = 11;
			this.machineLookUpEdit.ToolTip = "Use Ctrl+Del to clear filter";
			//
			//itemCheckedListBoxControl
			//
			this.itemCheckedListBoxControl.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.itemCheckedListBoxControl.CheckOnClick = true;
			this.itemCheckedListBoxControl.Location = new System.Drawing.Point(64, 472);
			this.itemCheckedListBoxControl.Name = "itemCheckedListBoxControl";
			this.itemCheckedListBoxControl.Size = new System.Drawing.Size(125, 24);
			this.itemCheckedListBoxControl.TabIndex = 4;
			//
			//toDateEdit
			//
			this.toDateEdit.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.toDateEdit.EditValue = null;
			this.toDateEdit.Location = new System.Drawing.Point(64, 88);
			this.toDateEdit.Name = "toDateEdit";
			this.toDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.toDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.toDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton()});
			this.toDateEdit.Properties.DisplayFormat.FormatString = "D";
			this.toDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.toDateEdit.Properties.EditFormat.FormatString = "D";
			this.toDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.toDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
			this.toDateEdit.Properties.MaxValue = new DateTime(2109, 12, 31, 0, 0, 0, 0);
			this.toDateEdit.Properties.MinValue = new DateTime(1980, 1, 1, 0, 0, 0, 0);
			this.toDateEdit.Properties.NullText = "[Select A To Date]";
			this.toDateEdit.Size = new System.Drawing.Size(124, 20);
			this.toDateEdit.TabIndex = 3;
			//
			//fromDateEdit
			//
			this.fromDateEdit.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.fromDateEdit.EditValue = null;
			this.fromDateEdit.Location = new System.Drawing.Point(64, 61);
			this.fromDateEdit.Name = "fromDateEdit";
			this.fromDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.fromDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.fromDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton()});
			this.fromDateEdit.Properties.DisplayFormat.FormatString = "D";
			this.fromDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.fromDateEdit.Properties.EditFormat.FormatString = "D";
			this.fromDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.fromDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
			this.fromDateEdit.Properties.MaxValue = new DateTime(2109, 12, 31, 0, 0, 0, 0);
			this.fromDateEdit.Properties.MinValue = new DateTime(1980, 1, 1, 0, 0, 0, 0);
			this.fromDateEdit.Properties.NullText = "[Select A From Date]";
			this.fromDateEdit.Size = new System.Drawing.Size(124, 20);
			this.fromDateEdit.TabIndex = 2;
			//
			//detailSimpleButton
			//
			this.detailSimpleButton.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.detailSimpleButton.Location = new System.Drawing.Point(5, 3);
			this.detailSimpleButton.Name = "detailSimpleButton";
			this.detailSimpleButton.Size = new System.Drawing.Size(183, 23);
			this.detailSimpleButton.TabIndex = 1;
			this.detailSimpleButton.Text = "Back To &Detail";
			this.detailSimpleButton.Visible = false;
			//
			//filterRefreshSimpleButton
			//
			this.filterRefreshSimpleButton.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.filterRefreshSimpleButton.Location = new System.Drawing.Point(5, 32);
			this.filterRefreshSimpleButton.Name = "filterRefreshSimpleButton";
			this.filterRefreshSimpleButton.Size = new System.Drawing.Size(183, 23);
			this.filterRefreshSimpleButton.TabIndex = 0;
			this.filterRefreshSimpleButton.Text = "&Refresh Report";
			//
			//ReportsXtraForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(734, 604);
			this.Controls.Add(this.reportsPrintControl);
			this.Controls.Add(this.filterDockPanel);
			this.Controls.Add(this.hideContainerLeft);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "ReportsXtraForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reports";
			((System.ComponentModel.ISupportInitialize)this.reportsDockManager).EndInit();
			this.hideContainerLeft.ResumeLayout(false);
			this.columnsDockPanel.ResumeLayout(false);
			this.DockPanel1_Container.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.reportColumnsXtraTabControl).EndInit();
			this.reportColumnsXtraTabControl.ResumeLayout(false);
			this.productionXtraTabPage.ResumeLayout(false);
			this.productionColumnsXtraScrollableControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.productionReasonCodeCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.reportsPrintBarManager).EndInit();
			((System.ComponentModel.ISupportInitialize)this.PrintPreviewRepositoryItemComboBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionUOMCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionProjectedPackersCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionProjectedSpeedCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionPOCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionTotalPayrollCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionShiftCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionCustomerNameCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionLotCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionItemCodeCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionItemDescriptionCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionStartTimeCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionStopTimeCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionTotalHoursCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionTotalMinutesCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionPackersCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionActualSpeedCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionDifferenceCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionExpectedCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionQuantityCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionMachineLineCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionDateCheckEdit.Properties).EndInit();
			this.transportationXtraTabPage.ResumeLayout(false);
			this.transportationXtraScrollableControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.transportationLpnCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.transportationExpirationDateCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.transportationVendorCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.transportationBolCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.transportationSealCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.transportationTrailerCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.transportationCarrierCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.transportationDestinationCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.transportationDeliveryNoteCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.transportationPOCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.transportationShiftCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.transportationCustomerCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.transportationLotCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.transportationItemCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.transportationItemDescriptionCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.transportationQuantityCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.transportationDateCheckEdit.Properties).EndInit();
			this.inventoryXtraTabPage.ResumeLayout(false);
			this.inventoryXtraScrollableControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.UOMCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.RMItemDescriptionCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.RMItemCodeCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryPalletAvailabilityCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryAvailabilityCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryInventoryByPalletCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryCurrentInventoryCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryItemTypeCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryAdjustmentReasonCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryAdjustmentCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryCustomerCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryItemCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryItemDescriptionCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryDateCheckEdit.Properties).EndInit();
			this.itemsXtraTabPage.ResumeLayout(false);
			this.itemsXtraScrollableControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.itemUsedInProductionCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemsCustomerCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemsItemCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemsItemDescriptionCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemsItemTypeCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemsUnitsOfMeasureCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemsQtyPerUnitCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemsUnitsPerCaseCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemsAdjustedCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemsShippedCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemsProducedCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemsCasesPerPalletCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemsReceivedCheckEdit.Properties).EndInit();
			this.costingXtraTabPage.ResumeLayout(false);
			this.costingXtraScrollableControl.ResumeLayout(false);
			this.costingXtraScrollableControl.PerformLayout();
			this.productionMachineXtraTabPage.ResumeLayout(false);
			this.productionMachineXtraScrollableControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.pmsTotalSalesCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pmsPriceCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pmsQuantityCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pmsProjectedSpeedCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pmsAverageSpeedCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pmsSpeedVariationVolCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pmsSpeedVariationPerCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pmsProjectedPackersCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pmsPackersCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pmsPackersVariationVolCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pmsPackersVariationPerCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pmsSalesVsPayrollCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pmsPricePerPieceCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pmsCostVariationCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pmsCostCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pmsProjectedCostCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pmsCostVariationPerCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.pmsTotalMinutesCheckEdit.Properties).EndInit();
			this.palletTransactionXtraTabPage.ResumeLayout(false);
			this.XtraScrollableControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.ptReceivedCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.ptDestinationCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.ptShippedCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.ptVendorCheckEdit.Properties).EndInit();
			this.filterDockPanel.ResumeLayout(false);
			this.ControlContainer1.ResumeLayout(false);
			this.ControlContainer1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.outOfStockCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.vendorLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.InactiveCustomersCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.InactiveItemsCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemTypeLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.carrierLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.destinationLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.deliveryNoteNumberTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.poTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.lotTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.bolTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customerLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shiftLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.machineLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemCheckedListBoxControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.toDateEdit.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.toDateEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.fromDateEdit.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.fromDateEdit.Properties).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
		filterRefreshSimpleButton.Click += new System.EventHandler(filterRefreshSimpleButton_Click);
		columnsRefreshSimpleButton.Click += new System.EventHandler(columnsRefreshSimpleButton_Click);
		this.Load += new System.EventHandler(ReportsXtraForm_Load);
		itemCheckedListBoxControl.ItemCheck += new DevExpress.XtraEditors.Controls.ItemCheckEventHandler(itemCheckedListBoxControl_ItemCheck);
	}
		internal DevExpress.XtraBars.Docking.DockManager reportsDockManager;
		internal DevExpress.XtraPrinting.Control.PrintControl reportsPrintControl;
		internal DevExpress.XtraBars.Docking.DockPanel columnsDockPanel;
		internal DevExpress.XtraBars.Docking.ControlContainer DockPanel1_Container;
		internal DevExpress.XtraBars.Docking.DockPanel filterDockPanel;
		internal DevExpress.XtraBars.Docking.ControlContainer ControlContainer1;
		internal DevExpress.XtraEditors.SimpleButton detailSimpleButton;
		internal DevExpress.XtraEditors.SimpleButton filterRefreshSimpleButton;
		internal DevExpress.XtraEditors.LookUpEdit customerLookUpEdit;
		internal DevExpress.XtraEditors.LookUpEdit shiftLookUpEdit;
		internal DevExpress.XtraEditors.LookUpEdit machineLookUpEdit;
		internal DevExpress.XtraEditors.CheckedListBoxControl itemCheckedListBoxControl;
		internal DevExpress.XtraEditors.DateEdit toDateEdit;
		internal DevExpress.XtraEditors.DateEdit fromDateEdit;
		internal DevExpress.XtraEditors.SimpleButton columnsRefreshSimpleButton;
		internal DevExpress.XtraEditors.XtraScrollableControl productionColumnsXtraScrollableControl;
		internal DevExpress.XtraEditors.CheckEdit productionShiftCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit productionCustomerNameCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit productionLotCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit productionItemCodeCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit productionItemDescriptionCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit productionStartTimeCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit productionStopTimeCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit productionTotalHoursCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit productionTotalMinutesCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit productionPackersCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit productionActualSpeedCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit productionDifferenceCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit productionExpectedCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit productionQuantityCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit productionMachineLineCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit productionDateCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit productionTotalPayrollCheckEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.LabelControl LabelControl6;
		internal DevExpress.XtraEditors.LabelControl LabelControl5;
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
		internal DevExpress.XtraBars.BarDockControl barDockControlRight;
		internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
		internal DevExpress.XtraBars.BarDockControl barDockControlTop;
		internal DevExpress.XtraPrinting.Preview.PrintBarManager reportsPrintBarManager;
		internal DevExpress.XtraPrinting.Preview.PreviewBar PreviewBar1;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarItem PrintPreviewBarItem1;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarItem PrintPreviewBarItem2;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarItem PrintPreviewBarItem3;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarItem PrintPreviewBarItem4;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarItem PrintPreviewBarItem5;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarItem PrintPreviewBarItem6;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarItem PrintPreviewBarItem7;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarItem PrintPreviewBarItem8;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarItem PrintPreviewBarItem9;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarItem PrintPreviewBarItem10;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarItem PrintPreviewBarItem11;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarItem PrintPreviewBarItem12;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarItem PrintPreviewBarItem13;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarItem PrintPreviewBarItem14;
		internal DevExpress.XtraPrinting.Preview.ZoomBarEditItem ZoomBarEditItem1;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewRepositoryItemComboBox PrintPreviewRepositoryItemComboBox1;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarItem PrintPreviewBarItem15;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarItem PrintPreviewBarItem16;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarItem PrintPreviewBarItem17;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarItem PrintPreviewBarItem18;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarItem PrintPreviewBarItem19;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarItem PrintPreviewBarItem20;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarItem PrintPreviewBarItem21;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarItem PrintPreviewBarItem22;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarItem PrintPreviewBarItem23;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarItem PrintPreviewBarItem24;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarItem PrintPreviewBarItem25;
		internal DevExpress.XtraPrinting.Preview.PreviewBar PreviewBar2;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem PrintPreviewStaticItem1;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem PrintPreviewStaticItem2;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewStaticItem PrintPreviewStaticItem3;
		internal DevExpress.XtraPrinting.Preview.PreviewBar PreviewBar3;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewSubItem PrintPreviewSubItem1;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewSubItem PrintPreviewSubItem2;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewSubItem PrintPreviewSubItem4;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarItem PrintPreviewBarItem26;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarItem PrintPreviewBarItem27;
		internal DevExpress.XtraBars.BarToolbarsListItem BarToolbarsListItem1;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewSubItem PrintPreviewSubItem3;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem PrintPreviewBarCheckItem1;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem PrintPreviewBarCheckItem2;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem PrintPreviewBarCheckItem3;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem PrintPreviewBarCheckItem4;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem PrintPreviewBarCheckItem5;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem PrintPreviewBarCheckItem6;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem PrintPreviewBarCheckItem7;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem PrintPreviewBarCheckItem8;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem PrintPreviewBarCheckItem9;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem PrintPreviewBarCheckItem10;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem PrintPreviewBarCheckItem11;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem PrintPreviewBarCheckItem12;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem PrintPreviewBarCheckItem13;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem PrintPreviewBarCheckItem14;
		internal DevExpress.XtraPrinting.Preview.PrintPreviewBarCheckItem PrintPreviewBarCheckItem15;
		internal DevExpress.XtraEditors.LabelControl LabelControl8;
		internal DevExpress.XtraEditors.LabelControl LabelControl7;
		internal DevExpress.XtraEditors.LabelControl LabelControl9;
		internal DevExpress.XtraEditors.TextEdit bolTextEdit;
		internal DevExpress.XtraEditors.TextEdit poTextEdit;
		internal DevExpress.XtraEditors.TextEdit lotTextEdit;
		internal DevExpress.XtraEditors.TextEdit deliveryNoteNumberTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl10;
		internal DevExpress.XtraEditors.LabelControl LabelControl11;
		internal DevExpress.XtraEditors.LookUpEdit destinationLookUpEdit;
		internal DevExpress.XtraEditors.LookUpEdit carrierLookUpEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl12;
		internal DevExpress.XtraEditors.LookUpEdit itemTypeLookUpEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl14;
		internal DevExpress.XtraEditors.LabelControl LabelControl13;
		internal DevExpress.XtraTab.XtraTabControl reportColumnsXtraTabControl;
		internal DevExpress.XtraTab.XtraTabPage productionXtraTabPage;
		internal DevExpress.XtraEditors.XtraScrollableControl transportationXtraScrollableControl;
		internal DevExpress.XtraTab.XtraTabPage transportationXtraTabPage;
		internal DevExpress.XtraEditors.CheckEdit transportationPOCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit transportationShiftCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit transportationCustomerCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit transportationLotCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit transportationItemCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit transportationItemDescriptionCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit transportationQuantityCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit transportationDateCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit productionPOCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit transportationVendorCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit transportationBolCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit transportationSealCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit transportationTrailerCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit transportationCarrierCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit transportationDestinationCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit transportationDeliveryNoteCheckEdit;
		internal DevExpress.XtraTab.XtraTabPage inventoryXtraTabPage;
		internal DevExpress.XtraEditors.XtraScrollableControl inventoryXtraScrollableControl;
		internal DevExpress.XtraEditors.CheckEdit inventoryItemTypeCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit inventoryAdjustmentReasonCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit inventoryAdjustmentCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit inventoryCustomerCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit inventoryItemCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit inventoryItemDescriptionCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit inventoryDateCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit inventoryPalletAvailabilityCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit inventoryAvailabilityCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit inventoryInventoryByPalletCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit inventoryCurrentInventoryCheckEdit;
		internal DevExpress.XtraTab.XtraTabPage itemsXtraTabPage;
		internal DevExpress.XtraEditors.XtraScrollableControl itemsXtraScrollableControl;
		internal DevExpress.XtraEditors.CheckEdit itemsCustomerCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit itemsItemCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit itemsItemDescriptionCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit itemsItemTypeCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit itemsUnitsOfMeasureCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit itemsQtyPerUnitCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit itemsUnitsPerCaseCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit itemsAdjustedCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit itemsShippedCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit itemsProducedCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit itemsCasesPerPalletCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit itemsReceivedCheckEdit;
		internal DevExpress.XtraTab.XtraTabPage costingXtraTabPage;
		internal DevExpress.XtraEditors.XtraScrollableControl costingXtraScrollableControl;
		internal System.Windows.Forms.CheckBox costingProductionDateCheckEdit;
		internal System.Windows.Forms.CheckBox costingShiftCheckEdit;
		internal System.Windows.Forms.CheckBox costingCustomerCheckEdit;
		internal System.Windows.Forms.CheckBox costingLotCheckEdit;
		internal System.Windows.Forms.CheckBox costingItemCodeCheckEdit;
		internal System.Windows.Forms.CheckBox costingItemDescriptionCheckEdit;
		internal System.Windows.Forms.CheckBox costingStartTimeCheckEdit;
		internal System.Windows.Forms.CheckBox costingStopTimeCheckEdit;
		internal System.Windows.Forms.CheckBox costingTotalHoursCheckEdit;
		internal System.Windows.Forms.CheckBox costingTotalMinutesCheckEdit;
		internal System.Windows.Forms.CheckBox costingQuantityCheckEdit;
		internal System.Windows.Forms.CheckBox costingExpectedCheckEdit;
		internal System.Windows.Forms.CheckBox costingDifferenceCheckEdit;
		internal System.Windows.Forms.CheckBox costingMachineLineCheckEdit;
		internal System.Windows.Forms.CheckBox costingMachineSpeedCheckEdit;
		internal System.Windows.Forms.CheckBox costingActualSpeedCheckEdit;
		internal System.Windows.Forms.CheckBox costingOperatorsCheckEdit;
		internal System.Windows.Forms.CheckBox costingPackersCheckEdit;
		internal System.Windows.Forms.CheckBox costingSupersCheckEdit;
		internal System.Windows.Forms.CheckBox costingPriceCheckEdit;
		internal System.Windows.Forms.CheckBox costingPayrollCheckEdit;
		internal System.Windows.Forms.CheckBox costingRebateCheckEdit;
		internal System.Windows.Forms.CheckBox costingFreightCheckEdit;
		internal System.Windows.Forms.CheckBox costingFilmCheckEdit;
		internal System.Windows.Forms.CheckBox costingBoxesCheckEdit;
		internal System.Windows.Forms.CheckBox costingStretchWrapCheckEdit;
		internal System.Windows.Forms.CheckBox costingPalletsCheckEdit;
		internal System.Windows.Forms.CheckBox costingTotalOtherCheckEdit;
		internal System.Windows.Forms.CheckBox costingCostCheckBox;
		internal System.Windows.Forms.CheckBox costingProfitCheckEdit;
		internal System.Windows.Forms.CheckBox costingCostPerPieceCheckEdit;
		internal System.Windows.Forms.CheckBox costingPacksPerMinuteCheckEdit;
		internal System.Windows.Forms.CheckBox costingSalesVsPayrollCheckEdit;
		internal System.Windows.Forms.CheckBox CostingSalesVsCostCheckEdit;
		internal System.Windows.Forms.CheckBox costingProfitVsSalesCheckEdit;
		internal System.Windows.Forms.CheckBox costingSalesVsProfitCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit InactiveCustomersCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit InactiveItemsCheckEdit;
		internal DevExpress.XtraEditors.LookUpEdit vendorLookUpEdit;
		internal DevExpress.XtraEditors.CheckEdit outOfStockCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit RMItemDescriptionCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit RMItemCodeCheckEdit;
		internal DevExpress.XtraTab.XtraTabPage productionMachineXtraTabPage;
		internal DevExpress.XtraEditors.XtraScrollableControl productionMachineXtraScrollableControl;
		internal DevExpress.XtraEditors.CheckEdit pmsTotalSalesCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit pmsPriceCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit pmsQuantityCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit pmsProjectedSpeedCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit pmsAverageSpeedCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit pmsSpeedVariationVolCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit pmsSpeedVariationPerCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit pmsProjectedPackersCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit pmsPackersCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit pmsPackersVariationVolCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit pmsPackersVariationPerCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit pmsSalesVsPayrollCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit pmsPricePerPieceCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit pmsCostVariationCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit pmsCostCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit pmsProjectedCostCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit pmsCostVariationPerCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit pmsTotalMinutesCheckEdit;
		internal DevExpress.XtraBars.Docking.AutoHideContainer hideContainerLeft;
		internal DevExpress.XtraTab.XtraTabPage palletTransactionXtraTabPage;
		internal DevExpress.XtraEditors.XtraScrollableControl XtraScrollableControl1;
		internal DevExpress.XtraEditors.CheckEdit ptReceivedCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit ptDestinationCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit ptShippedCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit ptVendorCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit itemUsedInProductionCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit UOMCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit transportationExpirationDateCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit productionProjectedSpeedCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit productionProjectedPackersCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit productionUOMCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit productionReasonCodeCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit transportationLpnCheckEdit;
	}

}