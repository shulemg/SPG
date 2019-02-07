//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;

using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraPrinting;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.Xpo;
using DXDAL.SPGData;
using DevExpress.Data.Filtering;
using DevExpress.XtraPivotGrid;
using System.Linq;
using DevExpress.XtraEditors;

namespace SuperiorPackGroup
{
	public partial class QuickReportsXtraForm
	{

		public QuickReportsXtraForm()
		{
			InitializeComponent();
		}

		private string m_CurrentReport;
		private Project m_Project;
		private string m_ProductionWeek;

		private void QuickReportsXtraForm_Load(object sender, EventArgs e)
		{

			this.reportCodeNameGridColumn.FieldName = "CodeName";
			this.reportNameGridColumn.FieldName = "Name";
			this.reportTypeGridColumn.FieldName = "Type";
			this.filterReportGridColumn.FieldName = "FilterReport";
			this.dateFilterGridColumn.FieldName = "DateFilter";
			this.customerFilterGridColumn.FieldName = "CustomerFilter";
			this.itemFilterGridColumn.FieldName = "ItemFilter";
			this.lotFilterGridColumn.FieldName = "LotFilter";
			this.poFilterGridColumn.FieldName = "POFilter";
			this.machineFilterGridColumn.FieldName = "MachineFilter";
			this.shiftFilterGridColumn.FieldName = "ShiftFilter";
			this.bolFilterGridColumn.FieldName = "BOLFilter";
			this.dnFilterGridColumn.FieldName = "DNFilter";
			this.destinationFilterGridColumn.FieldName = "DestinationFilter";
			this.carrierFilterGridColumn.FieldName = "CarrierFilter";
			this.vendorFilterGridColumn.FieldName = "VendorFilter";
			this.itemTypeFilterGridColumn.FieldName = "itemtypeFilter";
			this.outOfStockFilterGridColumn.FieldName = "stockFilter";

		}

		public void FillReports(string moduleName)
		{

			if (string.IsNullOrEmpty(moduleName))
			{
				this.quickReportsGridControl.DataSource = (new ReportsBLL()).GetReports();
			}
			else
			{
				this.quickReportsGridControl.DataSource = (new ReportsBLL()).GetReportsByModule(moduleName);
			}

		}

		private void HidePreviewTabPages()
		{

			previewCustoemrsXtraTabPage.PageVisible = false;
			previewProductionEntriesXtraTabPage.PageVisible = false;
			previewLpnStatusXtraTabPage.PageVisible = false;
			previewCurrentRMInventoryXtraTabPage.PageVisible = false;
			previewCurrentInventoryXtraTabPage.PageVisible = false;
			previewLocationTransfersXtraTabPage.PageVisible = false;
			previewShiftScheduleXtraTabPage.PageVisible = false;
			previewWeeklyProductionXtraTabPage.PageVisible = false;
			previewProjBomAvailXtraTabPage.PageVisible = false;
			previewProductionBillingXtraTabPage.PageVisible = false;
			previewBaggingXtraTabPage.PageVisible = false;

		}

		private void quickReportsGridView_Click(object sender, EventArgs e)
		{

			if (quickReportsGridView.CalcHitInfo(quickReportsGridControl.PointToClient(Control.MousePosition)).HitTest == GridHitTest.RowCell)
			{
				if (quickReportsGridView.GetFocusedRowCellValue(this.reportTypeGridColumn).ToString() != "QuickReport")
				{
					SelectReport(false, quickReportsGridView.GetFocusedRowCellValue(reportCodeNameGridColumn).ToString(), false);
				}
				else
				{
					SelectReport(true, quickReportsGridView.GetFocusedRowCellValue(this.reportCodeNameGridColumn).ToString(), Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(this.filterReportGridColumn)));
				}
			}

		}

		public void SelectProjectBomAvailabilityReport(Project ProjectID)
		{

			m_Project = ProjectID;
			SelectReport(true, "ProjBomAvailXtraReport", false);

		}

		public void SelectWeeklyScheduleReport(Project ProjectID, string ProductionWeek)
		{

			m_Project = ProjectID;
			m_ProductionWeek = ProductionWeek;

			SelectReport(true, "WeeklyProductionXtraReport", false);

		}

		public void SelectReport(bool QuickReport, string ReportCodeName, bool FilterReport)
		{

			reportsXtraTabControl.Visible = true;
			HidePreviewTabPages();

			if (QuickReport)
			{
				m_CurrentReport = ReportCodeName;
				if (FilterReport)
				{
					reportsXtraTabControl.SelectedTabPage = filterXtraTabPage;
				}
				else
				{
					PreviewReport();
				}
			}
			else
			{
				DisplayReportForm(ReportCodeName);
			}

		}

		public void SetShiftScheduleFilter(DateTime? scheduleDate, string scheduleShift)
		{

			if (scheduleDate.HasValue)
			{
				shiftScheduleDateDateEdit.EditValue = scheduleDate.Value;
			}
			shiftScheduleShiftComboBoxEdit.EditValue = scheduleShift;

		}

		private void DisplayReportForm(string reportCodeName)
		{

			ReportsXtraForm reportForm = new ReportsXtraForm();

			reportForm.Cursor = Cursors.WaitCursor;

			reportForm.fromDateEdit.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(this.dateFilterGridColumn));
			reportForm.toDateEdit.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(this.dateFilterGridColumn));
			reportForm.customerLookUpEdit.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(this.customerFilterGridColumn));
			reportForm.itemCheckedListBoxControl.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(this.itemFilterGridColumn));
			reportForm.lotTextEdit.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(this.lotFilterGridColumn));
			reportForm.poTextEdit.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(this.poFilterGridColumn));
			reportForm.machineLookUpEdit.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(this.machineFilterGridColumn));
			reportForm.shiftLookUpEdit.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(this.shiftFilterGridColumn));
			reportForm.bolTextEdit.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(this.bolFilterGridColumn));
			reportForm.deliveryNoteNumberTextEdit.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(this.dnFilterGridColumn));
			reportForm.destinationLookUpEdit.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(this.destinationFilterGridColumn));
			reportForm.carrierLookUpEdit.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(this.carrierFilterGridColumn));
			reportForm.vendorLookUpEdit.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(this.vendorFilterGridColumn));
			reportForm.itemTypeLookUpEdit.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(this.itemTypeFilterGridColumn));
			reportForm.outOfStockCheckEdit.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(this.outOfStockFilterGridColumn));
			reportForm.ReportTitle = quickReportsGridView.GetFocusedRowCellValue(this.reportNameGridColumn).ToString();

			switch (reportCodeName)
			{
				case "ProductionDetailXtraReport":
				{
					bool lShouldReturn = false;
					bool tempVar = reportForm.OnlyAssigned;
					CheckPermissions(ref lShouldReturn, "General", ref tempVar);
					reportForm.OnlyAssigned = tempVar;
					if (lShouldReturn)
					{
						return;
					}
					reportForm.reportColumnsXtraTabControl.SelectedTabPage = reportForm.productionXtraTabPage;
					reportForm.productionTotalPayrollCheckEdit.Checked = true;
					reportForm.productionTotalPayrollCheckEdit.Enabled = true;
					reportForm.productionTotalMinutesCheckEdit.Checked = true;
					reportForm.productionTotalMinutesCheckEdit.Enabled = true;
					reportForm.productionTotalHoursCheckEdit.Checked = true;
					reportForm.productionTotalHoursCheckEdit.Enabled = true;
					reportForm.productionStopTimeCheckEdit.Checked = true;
					reportForm.productionStopTimeCheckEdit.Enabled = true;
					reportForm.productionStartTimeCheckEdit.Checked = true;
					reportForm.productionStartTimeCheckEdit.Enabled = true;
					reportForm.productionShiftCheckEdit.Checked = true;
					reportForm.productionShiftCheckEdit.Enabled = true;
					reportForm.productionQuantityCheckEdit.Checked = true;
					reportForm.productionQuantityCheckEdit.Enabled = true;
					reportForm.productionPOCheckEdit.Checked = false;
					reportForm.productionPOCheckEdit.Enabled = false;
					reportForm.productionPackersCheckEdit.Checked = true;
					reportForm.productionPackersCheckEdit.Enabled = true;
					reportForm.productionMachineLineCheckEdit.Checked = true;
					reportForm.productionMachineLineCheckEdit.Enabled = true;
					reportForm.productionLotCheckEdit.Checked = true;
					reportForm.productionLotCheckEdit.Enabled = true;
					reportForm.productionItemDescriptionCheckEdit.Checked = true;
					reportForm.productionItemDescriptionCheckEdit.Enabled = true;
					reportForm.productionItemCodeCheckEdit.Checked = true;
					reportForm.productionItemCodeCheckEdit.Enabled = true;
					reportForm.productionExpectedCheckEdit.Checked = true;
					reportForm.productionExpectedCheckEdit.Enabled = true;
					reportForm.productionDifferenceCheckEdit.Checked = true;
					reportForm.productionDifferenceCheckEdit.Enabled = true;
					reportForm.productionDateCheckEdit.Checked = true;
					reportForm.productionDateCheckEdit.Enabled = true;
					reportForm.productionCustomerNameCheckEdit.Checked = true;
					reportForm.productionCustomerNameCheckEdit.Enabled = true;
					reportForm.productionActualSpeedCheckEdit.Checked = true;
					reportForm.productionActualSpeedCheckEdit.Enabled = true;
					reportForm.productionProjectedSpeedCheckEdit.Checked = true;
					reportForm.productionProjectedSpeedCheckEdit.Enabled = true;
					reportForm.productionProjectedPackersCheckEdit.Checked = true;
					reportForm.productionProjectedPackersCheckEdit.Enabled = true;
					reportForm.productionUOMCheckEdit.Checked = true;
					reportForm.productionUOMCheckEdit.Enabled = true;
					reportForm.productionReasonCodeCheckEdit.Checked = true;
					reportForm.productionReasonCodeCheckEdit.Enabled = true;

					break;
				}
				case "ProductionMachineXtraReport":
				{
					bool lShouldReturn = false;
					bool tempVar2 = reportForm.OnlyAssigned;
					CheckPermissions(ref lShouldReturn, "Financial", ref tempVar2);
					reportForm.OnlyAssigned = tempVar2;
					if (lShouldReturn)
					{
						return;
					}
					reportForm.reportColumnsXtraTabControl.SelectedTabPage = reportForm.productionMachineXtraTabPage;
					reportForm.pmsTotalMinutesCheckEdit.Checked = true;
					reportForm.pmsQuantityCheckEdit.Checked = true;
					reportForm.pmsProjectedSpeedCheckEdit.Checked = true;
					reportForm.pmsAverageSpeedCheckEdit.Checked = true;
					reportForm.pmsSpeedVariationVolCheckEdit.Checked = true;
					reportForm.pmsSpeedVariationPerCheckEdit.Checked = true;
					reportForm.pmsProjectedPackersCheckEdit.Checked = true;
					reportForm.pmsPackersCheckEdit.Checked = true;
					reportForm.pmsPackersVariationVolCheckEdit.Checked = true;
					reportForm.pmsPackersVariationPerCheckEdit.Checked = true;
					reportForm.pmsProjectedCostCheckEdit.Checked = true;
					reportForm.pmsCostCheckEdit.Checked = true;
					reportForm.pmsCostVariationCheckEdit.Checked = true;
					reportForm.pmsCostVariationPerCheckEdit.Checked = true;
					reportForm.pmsPricePerPieceCheckEdit.Checked = true;
					reportForm.pmsSalesVsPayrollCheckEdit.Checked = true;
					reportForm.pmsPriceCheckEdit.Checked = true;
					reportForm.pmsTotalSalesCheckEdit.Checked = true;

					break;
				}
				case "ProductionShiftXtraReport":
				{
					bool lShouldReturn = false;
					bool tempVar3 = reportForm.OnlyAssigned;
					CheckPermissions(ref lShouldReturn, "Financial", ref tempVar3);
					reportForm.OnlyAssigned = tempVar3;
					if (lShouldReturn)
					{
						return;
					}
					reportForm.reportColumnsXtraTabControl.SelectedTabPage = reportForm.productionMachineXtraTabPage;
					reportForm.pmsTotalMinutesCheckEdit.Checked = true;
					reportForm.pmsQuantityCheckEdit.Checked = true;
					reportForm.pmsProjectedSpeedCheckEdit.Checked = true;
					reportForm.pmsAverageSpeedCheckEdit.Checked = true;
					reportForm.pmsSpeedVariationVolCheckEdit.Checked = true;
					reportForm.pmsSpeedVariationPerCheckEdit.Checked = true;
					reportForm.pmsProjectedPackersCheckEdit.Checked = true;
					reportForm.pmsPackersCheckEdit.Checked = true;
					reportForm.pmsPackersVariationVolCheckEdit.Checked = true;
					reportForm.pmsPackersVariationPerCheckEdit.Checked = true;
					reportForm.pmsProjectedCostCheckEdit.Checked = true;
					reportForm.pmsCostCheckEdit.Checked = true;
					reportForm.pmsCostVariationCheckEdit.Checked = true;
					reportForm.pmsCostVariationPerCheckEdit.Checked = true;
					reportForm.pmsPricePerPieceCheckEdit.Checked = true;
					reportForm.pmsSalesVsPayrollCheckEdit.Checked = true;
					reportForm.pmsPriceCheckEdit.Checked = true;
					reportForm.pmsTotalSalesCheckEdit.Checked = true;

					break;
				}
				case "ProductionSummaryXtraReport":
				{
					bool lShouldReturn = false;
					bool tempVar4 = reportForm.OnlyAssigned;
					CheckPermissions(ref lShouldReturn, "General", ref tempVar4);
					reportForm.OnlyAssigned = tempVar4;
					if (lShouldReturn)
					{
						return;
					}

					break;
				}
				case "ProductionEntriesXtraReport":
				{
					bool lShouldReturn = false;
					bool tempVar5 = reportForm.OnlyAssigned;
					CheckPermissions(ref lShouldReturn, "General", ref tempVar5);
					reportForm.OnlyAssigned = tempVar5;
					if (lShouldReturn)
					{
						return;
					}
					reportForm.reportColumnsXtraTabControl.SelectedTabPage = reportForm.productionXtraTabPage;
					reportForm.productionTotalPayrollCheckEdit.Checked = false;
					reportForm.productionTotalPayrollCheckEdit.Enabled = false;
					reportForm.productionTotalMinutesCheckEdit.Checked = false;
					reportForm.productionTotalMinutesCheckEdit.Enabled = false;
					reportForm.productionTotalHoursCheckEdit.Checked = false;
					reportForm.productionTotalHoursCheckEdit.Enabled = false;
					reportForm.productionStopTimeCheckEdit.Checked = false;
					reportForm.productionStopTimeCheckEdit.Enabled = false;
					reportForm.productionStartTimeCheckEdit.Checked = false;
					reportForm.productionStartTimeCheckEdit.Enabled = false;
					reportForm.productionShiftCheckEdit.Checked = false;
					reportForm.productionShiftCheckEdit.Enabled = false;
					reportForm.productionQuantityCheckEdit.Checked = true;
					reportForm.productionQuantityCheckEdit.Enabled = true;
					reportForm.productionPOCheckEdit.Checked = true;
					reportForm.productionPOCheckEdit.Enabled = true;
					reportForm.productionPackersCheckEdit.Checked = false;
					reportForm.productionPackersCheckEdit.Enabled = false;
					reportForm.productionMachineLineCheckEdit.Checked = false;
					reportForm.productionMachineLineCheckEdit.Enabled = false;
					reportForm.productionLotCheckEdit.Checked = true;
					reportForm.productionLotCheckEdit.Enabled = true;
					reportForm.productionItemDescriptionCheckEdit.Checked = true;
					reportForm.productionItemDescriptionCheckEdit.Enabled = true;
					reportForm.productionItemCodeCheckEdit.Checked = true;
					reportForm.productionItemCodeCheckEdit.Enabled = true;
					reportForm.productionExpectedCheckEdit.Checked = false;
					reportForm.productionExpectedCheckEdit.Enabled = false;
					reportForm.productionDifferenceCheckEdit.Checked = false;
					reportForm.productionDifferenceCheckEdit.Enabled = false;
					reportForm.productionDateCheckEdit.Checked = true;
					reportForm.productionDateCheckEdit.Enabled = true;
					reportForm.productionCustomerNameCheckEdit.Checked = true;
					reportForm.productionCustomerNameCheckEdit.Enabled = true;
					reportForm.productionActualSpeedCheckEdit.Checked = false;
					reportForm.productionActualSpeedCheckEdit.Enabled = false;
					reportForm.productionProjectedSpeedCheckEdit.Checked = false;
					reportForm.productionProjectedSpeedCheckEdit.Enabled = false;
					reportForm.productionProjectedPackersCheckEdit.Checked = false;
					reportForm.productionProjectedPackersCheckEdit.Enabled = false;
					reportForm.productionUOMCheckEdit.Checked = false;
					reportForm.productionUOMCheckEdit.Enabled = false;
					reportForm.productionReasonCodeCheckEdit.Checked = false;
					reportForm.productionReasonCodeCheckEdit.Enabled = false;

					break;
				}
				case "CostingXtraReport":
				{
					bool lShouldReturn = false;
					bool tempVar6 = reportForm.OnlyAssigned;
					CheckPermissions(ref lShouldReturn, "Financial", ref tempVar6);
					reportForm.OnlyAssigned = tempVar6;
					if (lShouldReturn)
					{
						return;
					}
					reportForm.reportColumnsXtraTabControl.SelectedTabPage = reportForm.costingXtraTabPage;
					reportForm.costingActualSpeedCheckEdit.Checked = true;
					reportForm.costingActualSpeedCheckEdit.Enabled = true;
					reportForm.costingBoxesCheckEdit.Checked = true;
					reportForm.costingBoxesCheckEdit.Enabled = true;
					reportForm.costingCostCheckBox.Checked = true;
					reportForm.costingCostCheckBox.Enabled = true;
					reportForm.costingCostPerPieceCheckEdit.Checked = true;
					reportForm.costingCostPerPieceCheckEdit.Enabled = true;
					reportForm.costingCustomerCheckEdit.Checked = true;
					reportForm.costingCustomerCheckEdit.Enabled = true;
					reportForm.costingDifferenceCheckEdit.Checked = true;
					reportForm.costingDifferenceCheckEdit.Enabled = true;
					reportForm.costingExpectedCheckEdit.Checked = true;
					reportForm.costingExpectedCheckEdit.Enabled = true;
					reportForm.costingFilmCheckEdit.Checked = true;
					reportForm.costingFilmCheckEdit.Enabled = true;
					reportForm.costingFreightCheckEdit.Checked = true;
					reportForm.costingFreightCheckEdit.Enabled = true;
					reportForm.costingItemCodeCheckEdit.Checked = true;
					reportForm.costingItemCodeCheckEdit.Enabled = true;
					reportForm.costingItemDescriptionCheckEdit.Checked = true;
					reportForm.costingItemDescriptionCheckEdit.Enabled = true;
					reportForm.costingLotCheckEdit.Checked = true;
					reportForm.costingLotCheckEdit.Enabled = true;
					reportForm.costingMachineLineCheckEdit.Checked = true;
					reportForm.costingMachineLineCheckEdit.Enabled = true;
					reportForm.costingMachineSpeedCheckEdit.Checked = true;
					reportForm.costingMachineSpeedCheckEdit.Enabled = true;
					reportForm.costingOperatorsCheckEdit.Checked = true;
					reportForm.costingOperatorsCheckEdit.Enabled = true;
					reportForm.costingPackersCheckEdit.Checked = true;
					reportForm.costingPackersCheckEdit.Enabled = true;
					reportForm.costingPacksPerMinuteCheckEdit.Checked = true;
					reportForm.costingPacksPerMinuteCheckEdit.Enabled = true;
					reportForm.costingPalletsCheckEdit.Checked = true;
					reportForm.costingPalletsCheckEdit.Enabled = true;
					reportForm.costingPayrollCheckEdit.Checked = true;
					reportForm.costingPayrollCheckEdit.Enabled = true;
					reportForm.costingPriceCheckEdit.Checked = true;
					reportForm.costingPriceCheckEdit.Enabled = true;
					reportForm.costingProductionDateCheckEdit.Checked = true;
					reportForm.costingProductionDateCheckEdit.Enabled = true;
					reportForm.costingProfitCheckEdit.Checked = true;
					reportForm.costingProfitCheckEdit.Enabled = true;
					reportForm.costingProfitVsSalesCheckEdit.Checked = true;
					reportForm.costingProfitVsSalesCheckEdit.Enabled = true;
					reportForm.costingQuantityCheckEdit.Checked = true;
					reportForm.costingQuantityCheckEdit.Enabled = true;
					reportForm.costingRebateCheckEdit.Checked = true;
					reportForm.costingRebateCheckEdit.Enabled = true;
					reportForm.CostingSalesVsCostCheckEdit.Checked = true;
					reportForm.CostingSalesVsCostCheckEdit.Enabled = true;
					reportForm.costingSalesVsPayrollCheckEdit.Checked = true;
					reportForm.costingSalesVsPayrollCheckEdit.Enabled = true;
					reportForm.costingSalesVsProfitCheckEdit.Checked = true;
					reportForm.costingSalesVsProfitCheckEdit.Enabled = true;
					reportForm.costingShiftCheckEdit.Checked = true;
					reportForm.costingShiftCheckEdit.Enabled = true;
					reportForm.costingStartTimeCheckEdit.Checked = true;
					reportForm.costingStartTimeCheckEdit.Enabled = true;
					reportForm.costingStopTimeCheckEdit.Checked = true;
					reportForm.costingStopTimeCheckEdit.Enabled = true;
					reportForm.costingStretchWrapCheckEdit.Checked = true;
					reportForm.costingStretchWrapCheckEdit.Enabled = true;
					reportForm.costingSupersCheckEdit.Checked = true;
					reportForm.costingSupersCheckEdit.Enabled = true;
					reportForm.costingTotalHoursCheckEdit.Checked = true;
					reportForm.costingTotalHoursCheckEdit.Enabled = true;
					reportForm.costingTotalMinutesCheckEdit.Checked = true;
					reportForm.costingTotalMinutesCheckEdit.Enabled = true;
					reportForm.costingTotalOtherCheckEdit.Checked = true;
					reportForm.costingTotalOtherCheckEdit.Enabled = true;

					break;
				}
				case "CostingSmallXtraReport":
				{
					bool lShouldReturn = false;
					bool tempVar7 = reportForm.OnlyAssigned;
					CheckPermissions(ref lShouldReturn, "Financial", ref tempVar7);
					reportForm.OnlyAssigned = tempVar7;
					if (lShouldReturn)
					{
						return;
					}
					reportForm.reportColumnsXtraTabControl.SelectedTabPage = reportForm.costingXtraTabPage;
					reportForm.costingActualSpeedCheckEdit.Checked = true;
					reportForm.costingActualSpeedCheckEdit.Enabled = true;
					reportForm.costingBoxesCheckEdit.Checked = false;
					reportForm.costingBoxesCheckEdit.Enabled = true;
					reportForm.costingCostCheckBox.Checked = true;
					reportForm.costingCostCheckBox.Enabled = true;
					reportForm.costingCostPerPieceCheckEdit.Checked = true;
					reportForm.costingCostPerPieceCheckEdit.Enabled = true;
					reportForm.costingCustomerCheckEdit.Checked = true;
					reportForm.costingCustomerCheckEdit.Enabled = true;
					reportForm.costingDifferenceCheckEdit.Checked = false;
					reportForm.costingDifferenceCheckEdit.Enabled = true;
					reportForm.costingExpectedCheckEdit.Checked = false;
					reportForm.costingExpectedCheckEdit.Enabled = true;
					reportForm.costingFilmCheckEdit.Checked = false;
					reportForm.costingFilmCheckEdit.Enabled = true;
					reportForm.costingFreightCheckEdit.Checked = false;
					reportForm.costingFreightCheckEdit.Enabled = true;
					reportForm.costingItemCodeCheckEdit.Checked = true;
					reportForm.costingItemCodeCheckEdit.Enabled = true;
					reportForm.costingItemDescriptionCheckEdit.Checked = true;
					reportForm.costingItemDescriptionCheckEdit.Enabled = true;
					reportForm.costingLotCheckEdit.Checked = false;
					reportForm.costingLotCheckEdit.Enabled = true;
					reportForm.costingMachineLineCheckEdit.Checked = true;
					reportForm.costingMachineLineCheckEdit.Enabled = true;
					reportForm.costingMachineSpeedCheckEdit.Checked = false;
					reportForm.costingMachineSpeedCheckEdit.Enabled = true;
					reportForm.costingOperatorsCheckEdit.Checked = true;
					reportForm.costingOperatorsCheckEdit.Enabled = true;
					reportForm.costingPackersCheckEdit.Checked = true;
					reportForm.costingPackersCheckEdit.Enabled = true;
					reportForm.costingPacksPerMinuteCheckEdit.Checked = false;
					reportForm.costingPacksPerMinuteCheckEdit.Enabled = true;
					reportForm.costingPalletsCheckEdit.Checked = false;
					reportForm.costingPalletsCheckEdit.Enabled = true;
					reportForm.costingPayrollCheckEdit.Checked = true;
					reportForm.costingPayrollCheckEdit.Enabled = true;
					reportForm.costingPriceCheckEdit.Checked = true;
					reportForm.costingPriceCheckEdit.Enabled = true;
					reportForm.costingProductionDateCheckEdit.Checked = true;
					reportForm.costingProductionDateCheckEdit.Enabled = true;
					reportForm.costingProfitCheckEdit.Checked = true;
					reportForm.costingProfitCheckEdit.Enabled = true;
					reportForm.costingProfitVsSalesCheckEdit.Checked = false;
					reportForm.costingProfitVsSalesCheckEdit.Enabled = true;
					reportForm.costingQuantityCheckEdit.Checked = true;
					reportForm.costingQuantityCheckEdit.Enabled = true;
					reportForm.costingRebateCheckEdit.Checked = true;
					reportForm.costingRebateCheckEdit.Enabled = true;
					reportForm.CostingSalesVsCostCheckEdit.Checked = false;
					reportForm.CostingSalesVsCostCheckEdit.Enabled = true;
					reportForm.costingSalesVsPayrollCheckEdit.Checked = false;
					reportForm.costingSalesVsPayrollCheckEdit.Enabled = true;
					reportForm.costingSalesVsProfitCheckEdit.Checked = false;
					reportForm.costingSalesVsProfitCheckEdit.Enabled = true;
					reportForm.costingShiftCheckEdit.Checked = true;
					reportForm.costingShiftCheckEdit.Enabled = true;
					reportForm.costingStartTimeCheckEdit.Checked = true;
					reportForm.costingStartTimeCheckEdit.Enabled = true;
					reportForm.costingStopTimeCheckEdit.Checked = true;
					reportForm.costingStopTimeCheckEdit.Enabled = true;
					reportForm.costingStretchWrapCheckEdit.Checked = false;
					reportForm.costingStretchWrapCheckEdit.Enabled = true;
					reportForm.costingSupersCheckEdit.Checked = true;
					reportForm.costingSupersCheckEdit.Enabled = true;
					reportForm.costingTotalHoursCheckEdit.Checked = true;
					reportForm.costingTotalHoursCheckEdit.Enabled = true;
					reportForm.costingTotalMinutesCheckEdit.Checked = true;
					reportForm.costingTotalMinutesCheckEdit.Enabled = true;
					reportForm.costingTotalOtherCheckEdit.Checked = false;
					reportForm.costingTotalOtherCheckEdit.Enabled = true;

					break;
				}
				case "FinancialCostingXtraReport":
				{
					bool lShouldReturn = false;
					bool tempVar8 = reportForm.OnlyAssigned;
					CheckPermissions(ref lShouldReturn, "Financial", ref tempVar8);
					reportForm.OnlyAssigned = tempVar8;
					if (lShouldReturn)
					{
						return;
					}
					reportForm.reportColumnsXtraTabControl.SelectedTabPage = reportForm.costingXtraTabPage;
					reportForm.costingActualSpeedCheckEdit.Checked = false;
					reportForm.costingActualSpeedCheckEdit.Enabled = true;
					reportForm.costingBoxesCheckEdit.Checked = true;
					reportForm.costingBoxesCheckEdit.Enabled = true;
					reportForm.costingCostCheckBox.Checked = true;
					reportForm.costingCostCheckBox.Enabled = true;
					reportForm.costingCostPerPieceCheckEdit.Checked = true;
					reportForm.costingCostPerPieceCheckEdit.Enabled = true;
					reportForm.costingCustomerCheckEdit.Checked = true;
					reportForm.costingCustomerCheckEdit.Enabled = true;
					reportForm.costingDifferenceCheckEdit.Checked = false;
					reportForm.costingDifferenceCheckEdit.Enabled = true;
					reportForm.costingExpectedCheckEdit.Checked = false;
					reportForm.costingExpectedCheckEdit.Enabled = true;
					reportForm.costingFilmCheckEdit.Checked = true;
					reportForm.costingFilmCheckEdit.Enabled = true;
					reportForm.costingFreightCheckEdit.Checked = true;
					reportForm.costingFreightCheckEdit.Enabled = true;
					reportForm.costingItemCodeCheckEdit.Checked = true;
					reportForm.costingItemCodeCheckEdit.Enabled = true;
					reportForm.costingItemDescriptionCheckEdit.Checked = true;
					reportForm.costingItemDescriptionCheckEdit.Enabled = true;
					reportForm.costingLotCheckEdit.Checked = false;
					reportForm.costingLotCheckEdit.Enabled = true;
					reportForm.costingMachineLineCheckEdit.Checked = false;
					reportForm.costingMachineLineCheckEdit.Enabled = true;
					reportForm.costingMachineSpeedCheckEdit.Checked = false;
					reportForm.costingMachineSpeedCheckEdit.Enabled = true;
					reportForm.costingOperatorsCheckEdit.Checked = false;
					reportForm.costingOperatorsCheckEdit.Enabled = true;
					reportForm.costingPackersCheckEdit.Checked = false;
					reportForm.costingPackersCheckEdit.Enabled = true;
					reportForm.costingPacksPerMinuteCheckEdit.Checked = true;
					reportForm.costingPacksPerMinuteCheckEdit.Enabled = true;
					reportForm.costingPalletsCheckEdit.Checked = true;
					reportForm.costingPalletsCheckEdit.Enabled = true;
					reportForm.costingPayrollCheckEdit.Checked = true;
					reportForm.costingPayrollCheckEdit.Enabled = true;
					reportForm.costingPriceCheckEdit.Checked = true;
					reportForm.costingPriceCheckEdit.Enabled = true;
					reportForm.costingProductionDateCheckEdit.Checked = true;
					reportForm.costingProductionDateCheckEdit.Enabled = true;
					reportForm.costingProfitCheckEdit.Checked = true;
					reportForm.costingProfitCheckEdit.Enabled = true;
					reportForm.costingProfitVsSalesCheckEdit.Checked = false;
					reportForm.costingProfitVsSalesCheckEdit.Enabled = true;
					reportForm.costingQuantityCheckEdit.Checked = true;
					reportForm.costingQuantityCheckEdit.Enabled = true;
					reportForm.costingRebateCheckEdit.Checked = true;
					reportForm.costingRebateCheckEdit.Enabled = true;
					reportForm.CostingSalesVsCostCheckEdit.Checked = false;
					reportForm.CostingSalesVsCostCheckEdit.Enabled = true;
					reportForm.costingSalesVsPayrollCheckEdit.Checked = false;
					reportForm.costingSalesVsPayrollCheckEdit.Enabled = true;
					reportForm.costingSalesVsProfitCheckEdit.Checked = false;
					reportForm.costingSalesVsProfitCheckEdit.Enabled = true;
					reportForm.costingShiftCheckEdit.Checked = false;
					reportForm.costingShiftCheckEdit.Enabled = true;
					reportForm.costingStartTimeCheckEdit.Checked = false;
					reportForm.costingStartTimeCheckEdit.Enabled = true;
					reportForm.costingStopTimeCheckEdit.Checked = false;
					reportForm.costingStopTimeCheckEdit.Enabled = true;
					reportForm.costingStretchWrapCheckEdit.Checked = true;
					reportForm.costingStretchWrapCheckEdit.Enabled = true;
					reportForm.costingSupersCheckEdit.Checked = false;
					reportForm.costingSupersCheckEdit.Enabled = true;
					reportForm.costingTotalHoursCheckEdit.Checked = false;
					reportForm.costingTotalHoursCheckEdit.Enabled = true;
					reportForm.costingTotalMinutesCheckEdit.Checked = false;
					reportForm.costingTotalMinutesCheckEdit.Enabled = true;
					reportForm.costingTotalOtherCheckEdit.Checked = true;
					reportForm.costingTotalOtherCheckEdit.Enabled = true;

					break;
				}
				case "ShippingXtraReport":
				{
					bool lShouldReturn = false;
					bool tempVar9 = reportForm.OnlyAssigned;
					CheckPermissions(ref lShouldReturn, "General", ref tempVar9);
					reportForm.OnlyAssigned = tempVar9;
					if (lShouldReturn)
					{
						return;
					}
					reportForm.reportColumnsXtraTabControl.SelectedTabPage = reportForm.transportationXtraTabPage;
					reportForm.transportationVendorCheckEdit.Checked = false;
					reportForm.transportationVendorCheckEdit.Enabled = false;
					reportForm.transportationTrailerCheckEdit.Checked = true;
					reportForm.transportationTrailerCheckEdit.Enabled = true;
					reportForm.transportationShiftCheckEdit.Checked = true;
					reportForm.transportationShiftCheckEdit.Enabled = true;
					reportForm.transportationSealCheckEdit.Checked = true;
					reportForm.transportationSealCheckEdit.Enabled = true;
					reportForm.transportationQuantityCheckEdit.Checked = true;
					reportForm.transportationQuantityCheckEdit.Enabled = true;
					reportForm.transportationPOCheckEdit.Checked = true;
					reportForm.transportationPOCheckEdit.Enabled = true;
					reportForm.transportationLotCheckEdit.Checked = true;
					reportForm.transportationLotCheckEdit.Enabled = true;
					reportForm.transportationItemDescriptionCheckEdit.Checked = true;
					reportForm.transportationItemDescriptionCheckEdit.Enabled = true;
					reportForm.transportationItemCheckEdit.Checked = true;
					reportForm.transportationItemCheckEdit.Enabled = true;
					reportForm.transportationDestinationCheckEdit.Checked = true;
					reportForm.transportationDestinationCheckEdit.Enabled = true;
					reportForm.transportationDeliveryNoteCheckEdit.Checked = true;
					reportForm.transportationDeliveryNoteCheckEdit.Enabled = true;
					reportForm.transportationDateCheckEdit.Checked = true;
					reportForm.transportationDateCheckEdit.Enabled = true;
					reportForm.transportationCustomerCheckEdit.Checked = true;
					reportForm.transportationCustomerCheckEdit.Enabled = true;
					reportForm.transportationCarrierCheckEdit.Checked = true;
					reportForm.transportationCarrierCheckEdit.Enabled = true;
					reportForm.transportationBolCheckEdit.Checked = true;
					reportForm.transportationBolCheckEdit.Enabled = true;
					reportForm.transportationExpirationDateCheckEdit.Checked = true;
					reportForm.transportationExpirationDateCheckEdit.Enabled = true;

					break;
				}
				case "ShippingReturnsXtraReport":
				{
					bool lShouldReturn = false;
					bool tempVar10 = reportForm.OnlyAssigned;
					CheckPermissions(ref lShouldReturn, "General", ref tempVar10);
					reportForm.OnlyAssigned = tempVar10;
					if (lShouldReturn)
					{
						return;
					}
					reportForm.reportColumnsXtraTabControl.SelectedTabPage = reportForm.transportationXtraTabPage;
					reportForm.transportationVendorCheckEdit.Checked = false;
					reportForm.transportationVendorCheckEdit.Enabled = false;
					reportForm.transportationTrailerCheckEdit.Checked = true;
					reportForm.transportationTrailerCheckEdit.Enabled = true;
					reportForm.transportationShiftCheckEdit.Checked = true;
					reportForm.transportationShiftCheckEdit.Enabled = true;
					reportForm.transportationSealCheckEdit.Checked = true;
					reportForm.transportationSealCheckEdit.Enabled = true;
					reportForm.transportationQuantityCheckEdit.Checked = true;
					reportForm.transportationQuantityCheckEdit.Enabled = true;
					reportForm.transportationPOCheckEdit.Checked = true;
					reportForm.transportationPOCheckEdit.Enabled = true;
					reportForm.transportationLotCheckEdit.Checked = true;
					reportForm.transportationLotCheckEdit.Enabled = true;
					reportForm.transportationItemDescriptionCheckEdit.Checked = true;
					reportForm.transportationItemDescriptionCheckEdit.Enabled = true;
					reportForm.transportationItemCheckEdit.Checked = true;
					reportForm.transportationItemCheckEdit.Enabled = true;
					reportForm.transportationDestinationCheckEdit.Checked = true;
					reportForm.transportationDestinationCheckEdit.Enabled = true;
					reportForm.transportationDeliveryNoteCheckEdit.Checked = true;
					reportForm.transportationDeliveryNoteCheckEdit.Enabled = true;
					reportForm.transportationDateCheckEdit.Checked = true;
					reportForm.transportationDateCheckEdit.Enabled = true;
					reportForm.transportationCustomerCheckEdit.Checked = true;
					reportForm.transportationCustomerCheckEdit.Enabled = true;
					reportForm.transportationCarrierCheckEdit.Checked = true;
					reportForm.transportationCarrierCheckEdit.Enabled = true;
					reportForm.transportationBolCheckEdit.Checked = true;
					reportForm.transportationBolCheckEdit.Enabled = true;
					reportForm.transportationExpirationDateCheckEdit.Checked = true;
					reportForm.transportationExpirationDateCheckEdit.Enabled = true;

					break;
				}
				case "ReceivingXtraReport":
				{
					bool lShouldReturn = false;
					bool tempVar11 = reportForm.OnlyAssigned;
					CheckPermissions(ref lShouldReturn, "General", ref tempVar11);
					reportForm.OnlyAssigned = tempVar11;
					if (lShouldReturn)
					{
						return;
					}
					reportForm.reportColumnsXtraTabControl.SelectedTabPage = reportForm.transportationXtraTabPage;
					reportForm.transportationVendorCheckEdit.Checked = true;
					reportForm.transportationVendorCheckEdit.Enabled = true;
					reportForm.transportationTrailerCheckEdit.Checked = true;
					reportForm.transportationTrailerCheckEdit.Enabled = true;
					reportForm.transportationShiftCheckEdit.Checked = true;
					reportForm.transportationShiftCheckEdit.Enabled = true;
					reportForm.transportationSealCheckEdit.Checked = true;
					reportForm.transportationSealCheckEdit.Enabled = true;
					reportForm.transportationQuantityCheckEdit.Checked = true;
					reportForm.transportationQuantityCheckEdit.Enabled = true;
					reportForm.transportationPOCheckEdit.Checked = true;
					reportForm.transportationPOCheckEdit.Enabled = true;
					reportForm.transportationLotCheckEdit.Checked = true;
					reportForm.transportationLotCheckEdit.Enabled = true;
					reportForm.transportationItemDescriptionCheckEdit.Checked = true;
					reportForm.transportationItemDescriptionCheckEdit.Enabled = true;
					reportForm.transportationItemCheckEdit.Checked = true;
					reportForm.transportationItemCheckEdit.Enabled = true;
					reportForm.transportationDestinationCheckEdit.Checked = false;
					reportForm.transportationDestinationCheckEdit.Enabled = false;
					reportForm.transportationDeliveryNoteCheckEdit.Checked = false;
					reportForm.transportationDeliveryNoteCheckEdit.Enabled = false;
					reportForm.transportationDateCheckEdit.Checked = true;
					reportForm.transportationDateCheckEdit.Enabled = true;
					reportForm.transportationCustomerCheckEdit.Checked = true;
					reportForm.transportationCustomerCheckEdit.Enabled = true;
					reportForm.transportationCarrierCheckEdit.Checked = true;
					reportForm.transportationCarrierCheckEdit.Enabled = true;
					reportForm.transportationBolCheckEdit.Checked = true;
					reportForm.transportationBolCheckEdit.Enabled = true;
					reportForm.transportationExpirationDateCheckEdit.Checked = true;
					reportForm.transportationExpirationDateCheckEdit.Enabled = true;

					break;
				}
				case "ReceivingReturnsXtraReport":
				{
					bool lShouldReturn = false;
					bool tempVar12 = reportForm.OnlyAssigned;
					CheckPermissions(ref lShouldReturn, "General", ref tempVar12);
					reportForm.OnlyAssigned = tempVar12;
					if (lShouldReturn)
					{
						return;
					}
					reportForm.reportColumnsXtraTabControl.SelectedTabPage = reportForm.transportationXtraTabPage;
					reportForm.transportationVendorCheckEdit.Checked = true;
					reportForm.transportationVendorCheckEdit.Enabled = true;
					reportForm.transportationTrailerCheckEdit.Checked = true;
					reportForm.transportationTrailerCheckEdit.Enabled = true;
					reportForm.transportationShiftCheckEdit.Checked = true;
					reportForm.transportationShiftCheckEdit.Enabled = true;
					reportForm.transportationSealCheckEdit.Checked = true;
					reportForm.transportationSealCheckEdit.Enabled = true;
					reportForm.transportationQuantityCheckEdit.Checked = true;
					reportForm.transportationQuantityCheckEdit.Enabled = true;
					reportForm.transportationPOCheckEdit.Checked = true;
					reportForm.transportationPOCheckEdit.Enabled = true;
					reportForm.transportationLotCheckEdit.Checked = true;
					reportForm.transportationLotCheckEdit.Enabled = true;
					reportForm.transportationItemDescriptionCheckEdit.Checked = true;
					reportForm.transportationItemDescriptionCheckEdit.Enabled = true;
					reportForm.transportationItemCheckEdit.Checked = true;
					reportForm.transportationItemCheckEdit.Enabled = true;
					reportForm.transportationDestinationCheckEdit.Checked = false;
					reportForm.transportationDestinationCheckEdit.Enabled = false;
					reportForm.transportationDeliveryNoteCheckEdit.Checked = false;
					reportForm.transportationDeliveryNoteCheckEdit.Enabled = false;
					reportForm.transportationDateCheckEdit.Checked = true;
					reportForm.transportationDateCheckEdit.Enabled = true;
					reportForm.transportationCustomerCheckEdit.Checked = true;
					reportForm.transportationCustomerCheckEdit.Enabled = true;
					reportForm.transportationCarrierCheckEdit.Checked = true;
					reportForm.transportationCarrierCheckEdit.Enabled = true;
					reportForm.transportationBolCheckEdit.Checked = true;
					reportForm.transportationBolCheckEdit.Enabled = true;
					reportForm.transportationExpirationDateCheckEdit.Checked = true;
					reportForm.transportationExpirationDateCheckEdit.Enabled = true;

					break;
				}
				case "InventoryAdjustmentXtraReport":
				{
					bool lShouldReturn = false;
					bool tempVar13 = reportForm.OnlyAssigned;
					CheckPermissions(ref lShouldReturn, "General", ref tempVar13);
					reportForm.OnlyAssigned = tempVar13;
					if (lShouldReturn)
					{
						return;
					}
					reportForm.reportColumnsXtraTabControl.SelectedTabPage = reportForm.inventoryXtraTabPage;
					reportForm.inventoryPalletAvailabilityCheckEdit.Checked = false;
					reportForm.inventoryPalletAvailabilityCheckEdit.Enabled = false;
					reportForm.inventoryItemTypeCheckEdit.Checked = false;
					reportForm.inventoryItemTypeCheckEdit.Enabled = false;
					reportForm.inventoryItemDescriptionCheckEdit.Checked = false;
					reportForm.inventoryItemDescriptionCheckEdit.Enabled = false;
					reportForm.inventoryItemCheckEdit.Checked = true;
					reportForm.inventoryItemCheckEdit.Enabled = true;
					reportForm.inventoryInventoryByPalletCheckEdit.Checked = false;
					reportForm.inventoryInventoryByPalletCheckEdit.Enabled = false;
					reportForm.inventoryDateCheckEdit.Checked = true;
					reportForm.inventoryDateCheckEdit.Enabled = true;
					reportForm.inventoryCustomerCheckEdit.Checked = true;
					reportForm.inventoryCustomerCheckEdit.Enabled = true;
					reportForm.inventoryCurrentInventoryCheckEdit.Checked = false;
					reportForm.inventoryCurrentInventoryCheckEdit.Enabled = false;
					reportForm.inventoryAvailabilityCheckEdit.Checked = false;
					reportForm.inventoryAvailabilityCheckEdit.Enabled = false;
					reportForm.inventoryAdjustmentReasonCheckEdit.Checked = true;
					reportForm.inventoryAdjustmentReasonCheckEdit.Enabled = true;
					reportForm.inventoryAdjustmentCheckEdit.Checked = true;
					reportForm.inventoryAdjustmentCheckEdit.Enabled = true;
					reportForm.RMItemCodeCheckEdit.Checked = false;
					reportForm.RMItemCodeCheckEdit.Enabled = false;
					reportForm.RMItemDescriptionCheckEdit.Checked = false;
					reportForm.RMItemDescriptionCheckEdit.Enabled = false;
					reportForm.UOMCheckEdit.Enabled = false;
					reportForm.UOMCheckEdit.Checked = false;

					break;
				}
				case "PhysicalInventoryXtraReport":
				{
					bool lShouldReturn = false;
					bool tempVar14 = reportForm.OnlyAssigned;
					CheckPermissions(ref lShouldReturn, "General", ref tempVar14);
					reportForm.OnlyAssigned = tempVar14;
					if (lShouldReturn)
					{
						return;
					}
					reportForm.reportColumnsXtraTabControl.SelectedTabPage = reportForm.inventoryXtraTabPage;
					reportForm.inventoryPalletAvailabilityCheckEdit.Checked = false;
					reportForm.inventoryPalletAvailabilityCheckEdit.Enabled = false;
					reportForm.inventoryItemTypeCheckEdit.Checked = true;
					reportForm.inventoryItemTypeCheckEdit.Enabled = true;
					reportForm.inventoryItemDescriptionCheckEdit.Checked = true;
					reportForm.inventoryItemDescriptionCheckEdit.Enabled = true;
					reportForm.inventoryItemCheckEdit.Checked = true;
					reportForm.inventoryItemCheckEdit.Enabled = true;
					reportForm.inventoryInventoryByPalletCheckEdit.Checked = false;
					reportForm.inventoryInventoryByPalletCheckEdit.Enabled = false;
					reportForm.inventoryDateCheckEdit.Checked = false;
					reportForm.inventoryDateCheckEdit.Enabled = false;
					reportForm.inventoryCustomerCheckEdit.Checked = true;
					reportForm.inventoryCustomerCheckEdit.Enabled = true;
					reportForm.inventoryCurrentInventoryCheckEdit.Checked = true;
					reportForm.inventoryCurrentInventoryCheckEdit.Enabled = true;
					reportForm.inventoryAvailabilityCheckEdit.Checked = false;
					reportForm.inventoryAvailabilityCheckEdit.Enabled = false;
					reportForm.inventoryAdjustmentReasonCheckEdit.Checked = false;
					reportForm.inventoryAdjustmentReasonCheckEdit.Enabled = false;
					reportForm.inventoryAdjustmentCheckEdit.Checked = false;
					reportForm.inventoryAdjustmentCheckEdit.Enabled = false;
					reportForm.RMItemCodeCheckEdit.Checked = false;
					reportForm.RMItemCodeCheckEdit.Enabled = false;
					reportForm.RMItemDescriptionCheckEdit.Checked = false;
					reportForm.RMItemDescriptionCheckEdit.Enabled = false;
					reportForm.UOMCheckEdit.Enabled = false;
					reportForm.UOMCheckEdit.Checked = false;

					break;
				}
				case "OldCurrentInventoryXtraReport":
				{
					bool lShouldReturn = false;
					bool tempVar15 = reportForm.OnlyAssigned;
					CheckPermissions(ref lShouldReturn, "General", ref tempVar15);
					reportForm.OnlyAssigned = tempVar15;
					if (lShouldReturn)
					{
						return;
					}
					reportForm.reportColumnsXtraTabControl.SelectedTabPage = reportForm.inventoryXtraTabPage;
					reportForm.inventoryPalletAvailabilityCheckEdit.Checked = false;
					reportForm.inventoryPalletAvailabilityCheckEdit.Enabled = false;
					reportForm.inventoryItemTypeCheckEdit.Checked = true;
					reportForm.inventoryItemTypeCheckEdit.Enabled = true;
					reportForm.inventoryItemDescriptionCheckEdit.Checked = true;
					reportForm.inventoryItemDescriptionCheckEdit.Enabled = true;
					reportForm.inventoryItemCheckEdit.Checked = true;
					reportForm.inventoryItemCheckEdit.Enabled = true;
					reportForm.inventoryInventoryByPalletCheckEdit.Checked = true;
					reportForm.inventoryInventoryByPalletCheckEdit.Enabled = true;
					reportForm.inventoryDateCheckEdit.Checked = false;
					reportForm.inventoryDateCheckEdit.Enabled = false;
					reportForm.inventoryCustomerCheckEdit.Checked = true;
					reportForm.inventoryCustomerCheckEdit.Enabled = true;
					reportForm.inventoryCurrentInventoryCheckEdit.Checked = true;
					reportForm.inventoryCurrentInventoryCheckEdit.Enabled = true;
					reportForm.inventoryAvailabilityCheckEdit.Checked = false;
					reportForm.inventoryAvailabilityCheckEdit.Enabled = false;
					reportForm.inventoryAdjustmentReasonCheckEdit.Checked = false;
					reportForm.inventoryAdjustmentReasonCheckEdit.Enabled = false;
					reportForm.inventoryAdjustmentCheckEdit.Checked = false;
					reportForm.inventoryAdjustmentCheckEdit.Enabled = false;
					reportForm.RMItemCodeCheckEdit.Checked = false;
					reportForm.RMItemCodeCheckEdit.Enabled = false;
					reportForm.RMItemDescriptionCheckEdit.Checked = false;
					reportForm.RMItemDescriptionCheckEdit.Enabled = false;
					reportForm.UOMCheckEdit.Enabled = true;
					reportForm.UOMCheckEdit.Checked = false;

					break;
				}
				case "FinishedProductAvailabilityXtraReport":
				{
					bool lShouldReturn = false;
					bool tempVar16 = reportForm.OnlyAssigned;
					CheckPermissions(ref lShouldReturn, "General", ref tempVar16);
					reportForm.OnlyAssigned = tempVar16;
					if (lShouldReturn)
					{
						return;
					}
					reportForm.reportColumnsXtraTabControl.SelectedTabPage = reportForm.inventoryXtraTabPage;
					reportForm.inventoryPalletAvailabilityCheckEdit.Checked = true;
					reportForm.inventoryPalletAvailabilityCheckEdit.Enabled = true;
					reportForm.inventoryItemTypeCheckEdit.Checked = false;
					reportForm.inventoryItemTypeCheckEdit.Enabled = false;
					reportForm.inventoryItemDescriptionCheckEdit.Checked = true;
					reportForm.inventoryItemDescriptionCheckEdit.Enabled = true;
					reportForm.inventoryItemCheckEdit.Checked = true;
					reportForm.inventoryItemCheckEdit.Enabled = true;
					reportForm.inventoryInventoryByPalletCheckEdit.Checked = false;
					reportForm.inventoryInventoryByPalletCheckEdit.Enabled = false;
					reportForm.inventoryDateCheckEdit.Checked = false;
					reportForm.inventoryDateCheckEdit.Enabled = false;
					reportForm.inventoryCustomerCheckEdit.Checked = true;
					reportForm.inventoryCustomerCheckEdit.Enabled = true;
					reportForm.inventoryCurrentInventoryCheckEdit.Checked = false;
					reportForm.inventoryCurrentInventoryCheckEdit.Enabled = false;
					reportForm.inventoryAvailabilityCheckEdit.Checked = true;
					reportForm.inventoryAvailabilityCheckEdit.Enabled = true;
					reportForm.inventoryAdjustmentReasonCheckEdit.Checked = false;
					reportForm.inventoryAdjustmentReasonCheckEdit.Enabled = false;
					reportForm.inventoryAdjustmentCheckEdit.Checked = false;
					reportForm.inventoryAdjustmentCheckEdit.Enabled = false;
					reportForm.RMItemCodeCheckEdit.Checked = true;
					reportForm.RMItemCodeCheckEdit.Enabled = true;
					reportForm.RMItemDescriptionCheckEdit.Checked = true;
					reportForm.RMItemDescriptionCheckEdit.Enabled = true;
					reportForm.UOMCheckEdit.Enabled = false;
					reportForm.UOMCheckEdit.Checked = false;

					break;
				}
				case "ItemsListXtraReport":
				{
					bool lShouldReturn = false;
					bool tempVar17 = reportForm.OnlyAssigned;
					CheckPermissions(ref lShouldReturn, "General", ref tempVar17);
					reportForm.OnlyAssigned = tempVar17;
					if (lShouldReturn)
					{
						return;
					}
					reportForm.reportColumnsXtraTabControl.SelectedTabPage = reportForm.itemsXtraTabPage;
					reportForm.itemsAdjustedCheckEdit.Checked = false;
					reportForm.itemsAdjustedCheckEdit.Enabled = false;
					reportForm.itemsCasesPerPalletCheckEdit.Checked = true;
					reportForm.itemsCasesPerPalletCheckEdit.Enabled = true;
					reportForm.itemsCustomerCheckEdit.Checked = true;
					reportForm.itemsCustomerCheckEdit.Enabled = true;
					reportForm.itemsItemCheckEdit.Checked = true;
					reportForm.itemsItemCheckEdit.Enabled = true;
					reportForm.itemsItemDescriptionCheckEdit.Checked = true;
					reportForm.itemsItemDescriptionCheckEdit.Enabled = true;
					reportForm.itemsItemTypeCheckEdit.Checked = true;
					reportForm.itemsItemTypeCheckEdit.Enabled = true;
					reportForm.itemsProducedCheckEdit.Checked = false;
					reportForm.itemsProducedCheckEdit.Enabled = false;
					reportForm.itemsQtyPerUnitCheckEdit.Checked = true;
					reportForm.itemsQtyPerUnitCheckEdit.Enabled = true;
					reportForm.itemsReceivedCheckEdit.Checked = false;
					reportForm.itemsReceivedCheckEdit.Enabled = false;
					reportForm.itemsShippedCheckEdit.Checked = false;
					reportForm.itemsShippedCheckEdit.Enabled = false;
					reportForm.itemsUnitsOfMeasureCheckEdit.Checked = true;
					reportForm.itemsUnitsOfMeasureCheckEdit.Enabled = true;
					reportForm.itemsUnitsPerCaseCheckEdit.Checked = true;
					reportForm.itemsUnitsPerCaseCheckEdit.Enabled = true;
					reportForm.itemUsedInProductionCheckEdit.Checked = false;
					reportForm.itemUsedInProductionCheckEdit.Enabled = false;

					break;
				}
				case "PalletTransactionXtraReport":
				{
					bool lShouldReturn = false;
					bool tempVar18 = reportForm.OnlyAssigned;
					CheckPermissions(ref lShouldReturn, "General", ref tempVar18);
					reportForm.OnlyAssigned = tempVar18;
					if (lShouldReturn)
					{
						return;
					}
					reportForm.reportColumnsXtraTabControl.SelectedTabPage = reportForm.palletTransactionXtraTabPage;

					break;
				}
				case "ItemsTransactionsXtraReport":
				{
					//Dim lShouldReturn As Boolean
					//CheckPermissions(lShouldReturn, "General", .OnlyAssigned)
					//If lShouldReturn Then
					//    Return
					//End If
					MessageBox.Show("This report has been replaced with the Item Transaction Summary report.");
					return;

				}
				case "ItemTransactionSummaryXtraReport":
				{
					bool lShouldReturn = false;
					bool tempVar19 = reportForm.OnlyAssigned;
					CheckPermissions(ref lShouldReturn, "General", ref tempVar19);
					reportForm.OnlyAssigned = tempVar19;
					if (lShouldReturn)
					{
						return;
					}
					reportForm.reportColumnsXtraTabControl.SelectedTabPage = reportForm.itemsXtraTabPage;
					reportForm.itemsAdjustedCheckEdit.Checked = true;
					reportForm.itemsAdjustedCheckEdit.Enabled = true;
					reportForm.itemsCasesPerPalletCheckEdit.Checked = false;
					reportForm.itemsCasesPerPalletCheckEdit.Enabled = false;
					reportForm.itemsCustomerCheckEdit.Checked = true;
					reportForm.itemsCustomerCheckEdit.Enabled = true;
					reportForm.itemsItemCheckEdit.Checked = true;
					reportForm.itemsItemCheckEdit.Enabled = true;
					reportForm.itemsItemDescriptionCheckEdit.Checked = true;
					reportForm.itemsItemDescriptionCheckEdit.Enabled = true;
					reportForm.itemsItemTypeCheckEdit.Checked = true;
					reportForm.itemsItemTypeCheckEdit.Enabled = true;
					reportForm.itemsProducedCheckEdit.Checked = true;
					reportForm.itemsProducedCheckEdit.Enabled = true;
					reportForm.itemsQtyPerUnitCheckEdit.Checked = false;
					reportForm.itemsQtyPerUnitCheckEdit.Enabled = false;
					reportForm.itemsReceivedCheckEdit.Checked = true;
					reportForm.itemsReceivedCheckEdit.Enabled = true;
					reportForm.itemsShippedCheckEdit.Checked = true;
					reportForm.itemsShippedCheckEdit.Enabled = true;
					reportForm.itemsUnitsOfMeasureCheckEdit.Checked = false;
					reportForm.itemsUnitsOfMeasureCheckEdit.Enabled = false;
					reportForm.itemsUnitsPerCaseCheckEdit.Checked = false;
					reportForm.itemsUnitsPerCaseCheckEdit.Enabled = false;
					reportForm.itemUsedInProductionCheckEdit.Checked = true;
					reportForm.itemUsedInProductionCheckEdit.Enabled = true;

					break;
				}
				case "PalletControlXtraReport":
				{
					bool lShouldReturn = false;
					bool tempVar20 = reportForm.OnlyAssigned;
					CheckPermissions(ref lShouldReturn, "General", ref tempVar20);
					reportForm.OnlyAssigned = tempVar20;
					if (lShouldReturn)
					{
						return;
					}

					break;
				}
				case "AuditTrailXtraReport":
				{
					if (string.Compare(Properties.Settings.Default.UserName, "Admin", true) != 0)
					{
						MessageBox.Show("Only Admin has permission to view the Audit Trail Report");
						return;
					}

					break;
				}
			}

			reportForm.Show();
			reportForm.SelectedReport(reportCodeName);

			reportForm.Cursor = Cursors.Default;

		}

		private void PreviewReport()
		{

			this.Cursor = Cursors.WaitCursor;
			SetColumnFieldNames();
			DisplayReportColumns();

			switch (m_CurrentReport)
			{
				case "CustomerListXtraReport":
				{
					bool lShouldReturn = false;
					bool onlyAssigned = false;
					CheckPermissions(ref lShouldReturn, "General", ref onlyAssigned);
					if (lShouldReturn)
					{
						previewGridControl.DataSource = null;
						return;
					}
					else if (onlyAssigned)
					{
						previewGridControl.DataSource = new XPCollection<Customers>(new InOperator(Customers.Fields.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(XpoDefault.Session)));
					}
					else
					{
						previewGridControl.DataSource = new XPCollection<Customers>();
					}
					previewCustoemrsXtraTabPage.PageVisible = true;
					reportsXtraTabControl.SelectedTabPage = previewCustoemrsXtraTabPage;
					previewGridControl.Text = "Cusotmer List";
					break;
				}
				case "ProductionEntriesXtraReport":
				{
					bool lShouldReturn = false;
					bool onlyAssigned = false;
					CheckPermissions(ref lShouldReturn, "General", ref onlyAssigned);
					if (lShouldReturn)
					{
						previewProductionEntriesGridControl.DataSource = null;
						return;
					}
					else
					{
						previewProductionEntriesGridControl.DataSource = ProductionEntriesReportBLL.GetProductionEntriesReportView(onlyAssigned);
					}
					previewProductionEntriesXtraTabPage.PageVisible = true;
					reportsXtraTabControl.SelectedTabPage = previewProductionEntriesXtraTabPage;
					previewProductionEntriesGridControl.Text = "Production Entries";
					break;
				}
				case "LpnStatusXtraReport":
				{
					bool lShouldReturn = false;
					bool onlyAssigned = false;
					CheckPermissions(ref lShouldReturn, "General", ref onlyAssigned);
					if (lShouldReturn)
					{
						previewLpnStatusGridControl.DataSource = null;
						return;
					}
					else
					{
						previewLpnStatusGridControl.DataSource = LPNStatusReportBLL.GetLpnStatusrReportView(onlyAssigned);
					}
					previewLpnStatusXtraTabPage.PageVisible = true;
					reportsXtraTabControl.SelectedTabPage = previewLpnStatusXtraTabPage;
					previewLpnStatusGridControl.Text = "LPN Status";
					break;
				}
				case "CurrentRMInventoryXtraReport":
				{
					bool lShouldReturn = false;
					bool onlyAssigned = false;
					CheckPermissions(ref lShouldReturn, "General", ref onlyAssigned);
					if (lShouldReturn)
					{
						previewCurrentRMInventoryGridControl.DataSource = null;
						return;
					}
					else
					{
						previewCurrentRMInventoryGridControl.DataSource = CurrentRMInventoryReport.GetCurrentRmInventoryReport(onlyAssigned);
					}
					previewCurrentRMInventoryXtraTabPage.PageVisible = true;
					reportsXtraTabControl.SelectedTabPage = previewCurrentRMInventoryXtraTabPage;
					previewCurrentRMInventoryGridControl.Text = "Current RM Inventory";
					break;
				}
				case "CurrentInventoryXtraReport":
				{
					bool lShouldReturn = false;
					bool onlyAssigned = false;
					CheckPermissions(ref lShouldReturn, "General", ref onlyAssigned);
					if (lShouldReturn)
					{
						previewCurrentInventoryGridControl.DataSource = null;
						return;
					}
					else
					{
						previewCurrentInventoryGridControl.DataSource = CurrentInventoryReportBLL.GetCurrentInventoryReport(null, null, null, currentInventoryInactiveItemsCheckEdit.Checked, currentInventoryInactiveCustomersCheckEdit.Checked, outOfStockItemsCheckEdit.Checked, onlyAssigned, null);
					}
					previewCurrentInventoryXtraTabPage.PageVisible = true;
					reportsXtraTabControl.SelectedTabPage = previewCurrentInventoryXtraTabPage;
					previewCurrentInventoryGridControl.Text = "Current Inventory";
					break;
				}
				case "LocationTransfersXtraReport":
				{
					bool lShouldReturn = false;
					bool onlyAssigned = false;
					CheckPermissions(ref lShouldReturn, "General", ref onlyAssigned);
					if (lShouldReturn)
					{
						previewLocationTransfersGridControl.DataSource = null;
						return;
					}
					else
					{
						previewLocationTransfersGridControl.DataSource = LocationTransfersReportBLL.GetLocationTransfersReportView(onlyAssigned);
					}
					previewLocationTransfersXtraTabPage.PageVisible = true;
					reportsXtraTabControl.SelectedTabPage = previewLocationTransfersXtraTabPage;
					previewLocationTransfersGridControl.Text = "Location Transfers";
					break;
				}
				case "ShiftScheduleXtraReport":
				{
					bool lShouldRetun = false;
					bool tempVar = false;
					CheckPermissions(ref lShouldRetun, "General", ref tempVar);
					if (lShouldRetun)
					{
						shiftScheduleGridControl.DataSource = null;
						return;
					}
					if (Utilities.ChangeType<DateTime?>(shiftScheduleDateDateEdit.EditValue).HasValue == false || Convert.ToDateTime(shiftScheduleDateDateEdit.EditValue) == DateTime.MinValue)
					{
						shiftScheduleDateDateEdit.EditValue = DateTime.Today;
					}
					//If String.IsNullOrEmpty(CStr(shiftScheduleShiftComboBoxEdit.EditValue)) Then
					//    shiftScheduleShiftComboBoxEdit.EditValue = "Shift 1"
					//End If
					shiftScheduleGridControl.DataSource = ShiftScheduleReportBLL.GetShiftScheduleReport(Utilities.ChangeType<DateTime?>(shiftScheduleDateDateEdit.EditValue), (shiftScheduleShiftComboBoxEdit.EditValue == null ? null : Convert.ToString(shiftScheduleShiftComboBoxEdit.EditValue)));
					previewShiftScheduleXtraTabPage.PageVisible = true;
					reportsXtraTabControl.SelectedTabPage = previewShiftScheduleXtraTabPage;
					shiftScheduleGridControl.Text = string.Format("{0} - {1}", Convert.ToDateTime(shiftScheduleDateDateEdit.EditValue).ToLongDateString(), shiftScheduleShiftComboBoxEdit.Text);
					break;
				}
				case "WeeklyProductionXtraReport":
				{
					bool lShouldRetun = false;
					bool tempVar2 = false;
					CheckPermissions(ref lShouldRetun, "General", ref tempVar2);
					if (lShouldRetun)
					{
						weeklyProductionGridControl.DataSource = null;
						return;
					}
					weeklyProductionGridControl.DataSource = (new WeeklyProductionReportBLL()).GetWeeklyProductionReport(m_Project);
					previewWeeklyProductionXtraTabPage.PageVisible = true;
					reportsXtraTabControl.SelectedTabPage = previewWeeklyProductionXtraTabPage;
					weeklyProductionGridControl.Text = string.Format("Production for scheduled week of {0}", m_ProductionWeek);
					break;
				}
				case "ProjBomAvailXtraReport":
				{
					bool lShouldRetun = false;
					bool tempVar3 = false;
					CheckPermissions(ref lShouldRetun, "General", ref tempVar3);
					if (lShouldRetun)
					{
						ProjBomAvailGridControl.DataSource = null;
						return;
					}
					ProjBomAvailGridControl.DataSource = BomAvailabilityReportBLL.GetBomAvailabilityDetail(m_Project);
					previewProjBomAvailXtraTabPage.Text = "Preview Project Bom Availability";
					previewProjBomAvailXtraTabPage.PageVisible = true;
					reportsXtraTabControl.SelectedTabPage = previewProjBomAvailXtraTabPage;
					ProjBomAvailGridControl.Text = string.Format("{0} Bom Availability", m_Project.project);
					break;
				}
				case "BomDemandSummaryXtraReport":
				{
					bool lShouldRetun = false;
					bool tempVar4 = false;
					CheckPermissions(ref lShouldRetun, "General", ref tempVar4);
					if (lShouldRetun)
					{
						ProjBomAvailGridControl.DataSource = null;
						return;
					}
					ProjBomAvailGridControl.DataSource = BomAvailabilityReportBLL.GetDemandSummary(XpoDefault.Session);
					previewProjBomAvailXtraTabPage.Text = "Preview Bom Demand Summary";
					previewProjBomAvailXtraTabPage.PageVisible = true;
					reportsXtraTabControl.SelectedTabPage = previewProjBomAvailXtraTabPage;
					ProjBomAvailGridControl.Text = "Bom Demand Summary";
					break;
				}
				case "ProductionBillingXtraReport":
				{
					bool lShouldReturn = false;
					bool onlyAssigned = false;
					CheckPermissions(ref lShouldReturn, "Financial", ref onlyAssigned);
					if (lShouldReturn)
					{
						previewProductionBillingGridControl.DataSource = null;
						return;
					}
					previewProductionBillingGridControl.DataSource = ProductionBillingReportBLL.GetProductionBillingReportView(onlyAssigned);
					previewProductionBillingXtraTabPage.PageVisible = true;
					reportsXtraTabControl.SelectedTabPage = previewProductionBillingXtraTabPage;
					previewProductionBillingGridControl.Text = "Production Billing";
					break;
				}
				case "BaggingXtraReport":
				{
					bool lShouldReturn = false;
					bool tempVar5 = false;
					CheckPermissions(ref lShouldReturn, "General", ref tempVar5);
					if (lShouldReturn)
					{
						baggingReportPivotGridControl.DataSource = null;
						return;
					}
					baggingReportPivotGridControl.DataSource = baggingReportXpView;
					baggingReportPivotGridControl.Prefilter.Criteria = new GroupOperator(GroupOperatorType.And, new BinaryOperator("ProductionDate", DateTime.Today.AddDays(-14), BinaryOperatorType.GreaterOrEqual), new BinaryOperator("ProductionDate", DateTime.Today.AddDays(1), BinaryOperatorType.LessOrEqual));
					previewBaggingXtraTabPage.PageVisible = true;
					reportsXtraTabControl.SelectedTabPage = previewBaggingXtraTabPage;
					baggingReportPivotGridControl.Text = "Bagging";
					break;
				}
			}

			this.Cursor = Cursors.Default;

		}

		private static void CheckPermissions(ref bool shouldReturn, string reportType, ref bool onlyAssigned)
		{

			shouldReturn = false;
			onlyAssigned = false;
			if (reportType == "General")
			{
				if ( MainXtraForm.GeneralReports == "NONE")
				{
					MessageBox.Show("You don't have permission to view General Reports");
					shouldReturn = true;
				}
				else if (Microsoft.VisualBasic.CompilerServices.StringType.StrLike( MainXtraForm.GeneralReports, "*ASSIGNED", Microsoft.VisualBasic.CompareMethod.Binary))
				{
					onlyAssigned = true;
				}
			}
			else
			{
				if ( MainXtraForm.FinancialReports == "NONE")
				{
					MessageBox.Show("You don't have permission to view Financial Reports");
					shouldReturn = true;
					return;
				}
				else if (Microsoft.VisualBasic.CompilerServices.StringType.StrLike( MainXtraForm.FinancialReports, "*ASSIGNED", Microsoft.VisualBasic.CompareMethod.Binary))
				{
					onlyAssigned = true;
				}
			}

		}

		private void SetColumnFieldNames()
		{

			switch (m_CurrentReport)
			{
				case "CustomerListXtraReport":
					nameGridColumn.FieldName = "CustomerName";
					contactNameGridColumn.FieldName = "CustomerContact";
					this.addressGridColumn.FieldName = "Address";
					this.cityGridColumn.FieldName = "City";
					this.stateGridColumn.FieldName = "State";
					this.postalGridColumn.FieldName = "ZipCode";
					this.phoneGridColumn.FieldName = "CustomerPhone";
					this.faxGridColumn.FieldName = "CustomerFax";
					this.emailGridColumn.FieldName = "CustomerEmail";
					this.inactiveGridColumn.FieldName = "Inactive";
					break;
				case "ProductionEntriesXtraReport":
					productionDateGridColumn.FieldName = "Production Date";
					customerNameGridColumn.FieldName = "Customer Name";
					itemNumberGridColumn.FieldName = "Item #";
					itemDescriptionGridColumn.FieldName = "Item Description";
					itemTypeGridColumn.FieldName = "Item Type";
					shiftGridColumn.FieldName = "Shift";
					quantityGridColumn.FieldName = "Quantity";
					poGridColumn.FieldName = "PO #";
					lotGridColumn.FieldName = "Lot #";
					palletNumberGridColumn.FieldName = "Pallet #";
					lpnNumberGridColumn.FieldName = "LPN #";
					expirationDateGridColumn.FieldName = "Expiration Date";
					expirationDateFormatGridColumn.FieldName = "ExpirationDateFormat";
					noteGridColumn.FieldName = "Note";
					break;
				case "LpnStatusXtraReport":
					lpnCustomerNameGridColumn.FieldName = "Customer Name";
					fullLpnGridColumn.FieldName = "Full LPN Number";
					lpnItemCodeGridColumn.FieldName = "Item #";
					//lpnItemDescriptionGridColumn.FieldName = "Item Description"
					lpnQuantityGridColumn.FieldName = "Quantity";
					lpnProductionDateGridColumn.FieldName = "Production Date";
					lpnShippingDateGridColumn.FieldName = "Shipping Date";
					lpnShippingBolGridColumn.FieldName = "BOL #";
					break;
				case "CurrentRMInventoryXtraReport":
					rmInventoryCustomerNameGridColumn.FieldName = "Customer.CustomerName";
					rmInventoryIemCodeGridColumn.FieldName = "ItemCode";
					rmInventoryItemDescriptionGridColumn.FieldName = "ItemDescription";
					rmInventoryQtyOnHandGridColumn.FieldName = "QuantityOnHand";
					rmInventoryInactiveGridColumn.FieldName = "Inactive";
					rmInventoryItemIDGridColumn.FieldName = "ItemId";
					rmInventoryLocationGridColumn.FieldName = "Location";
					break;
				case "CurrentInventoryXtraReport":
					currentInventoryCustomerNameGridColumn.FieldName = "CustomerName";
					currentInventoryItemCodeGridColumn.FieldName = "ItemCode";
					currentInventoryItemDescriptionGridColumn.FieldName = "ItemDescription";
					currentInventoryItemTypeGridColumn.FieldName = "ItemType";
					currentInventoryQuantityOnHandGridColumn.FieldName = "QuantityOnHand";
					currentInventoryInventoryByPalletsGridColumn.FieldName = "InventoryByPallets";
					currentInventoryUOMGridColumn.FieldName = "UOM";
					currentInventoryLocationGridColumn.FieldName = "Location";
					break;
				case "LocationTransfersXtraReport":
					locationTransfersDateGridColumn.FieldName = "TransferDate";
					locationTransferFromLocationGridColumn.FieldName = "FromLocation";
					locationTransferToLocationGridColumn.FieldName = "ToLocation";
					locationTransferItemCodeGridColumn.FieldName = "ItemCode";
					locationTransferItemDescriptionGridColumn.FieldName = "ItemDescription";
					locationTransferNumberGridColumn.FieldName = "TransferNumber";
					locationTransferItemLotGridColumn.FieldName = "ItemLot";
					locationTransferExpirationDateGridColumn.FieldName = "ExpirationDate";
					locationTransferQuantityGridColumn.FieldName = "TransferQuantity";
					locationTransferExpirationDateFormatGridColumn.FieldName = "ExpirationDateFormat";
					locationTransferUnitsGridColumn.FieldName = "TransferUnits";
					locationTransferPalletsGridColumn.FieldName = "TransferPallets";
					locationTransferCarrierGridColumn.FieldName = "Carrier";
					break;
				case "ShiftScheduleXtraReport":
					shiftScheduleMachineNameGridColumn.FieldName = "MachineLineName";
					shiftSchedulePeopleGridColumn.FieldName = "People";
					shiftScheduleOperatorGridColumn.FieldName = "Operator";
					shiftScheduleItemCodeGridColumn.FieldName = "ItemCode";
					shiftScheduleItemDescriptionGridColumn.FieldName = "ItemDescription";
					shiftScheduleQuantityGridColumn.FieldName = "Quantity";
					shiftScheduleSchedByQtyGridColumn.FieldName = "ShedByQty";
					shiftScheduleNoteGridColumn.FieldName = "ShceduleNote";
					shiftScheduleMustRunGridColumn.FieldName = "MustRun";
					shiftSchedulePriorityLevelGridColumn.FieldName = "PriorityLevel";
					break;
				case "WeeklyProductionXtraReport":
					weeklyProductionItemCodeGridColumn.FieldName = "ItemCode";
					weeklyProductionItemDescriptionGridColumn.FieldName = "ItemDescription";
					weeklyProductionCasesRequiredGridColumn.FieldName = "RequiredCases";
					weeklyProductionBagsRequiredGridColumn.FieldName = "RequiredBags";
					weeklyProductionMondayGridColumn.FieldName = "ProducedMonday";
					weeklyProductionTuesdayGridColumn.FieldName = "ProducedTuesday";
					weeklyProductionWednesdayGridColumn.FieldName = "ProducedWednesday";
					weeklyProductionThursdayGridColumn.FieldName = "ProducedThursday";
					weeklyProductionFridayGridColumn.FieldName = "ProducedFriday";
					weeklyProductionSaturdayGridColumn.FieldName = "ProducedSaturday";
					weeklyProductionSundayGridColumn.FieldName = "ProducedSunday";
					weeklyProductionTotalProducedWeeklyGridColumn.FieldName = "TotalProducedWeek";
					weeklyProductionTotalProducedGridColumn.FieldName = "TotalProduced";
					weeklyProductionPercentageCompleteGridColumn.FieldName = "PercentageComplete";
					weeklyProductionProductionWeekGridColumn.FieldName = "ProductionWeek";
					break;
				case "ProjBomAvailXtraReport":
					ProjBomAvailCustPOGridColumn.FieldName = "CustomerPO";
					ProjBomAvailItemCodeGridColumn.FieldName = "ItemCode";
					ProjBomAvailItemDescriptionGridColumn.FieldName = "ItemDescription";
					ProjBomAvailItemTypeGridColumn.FieldName = "ItemType";
					ProjBomAvailLocalQtyGridColumn.FieldName = "QuantityOnHand";
					ProjBomLocalShortageGridColumn.FieldName = "BomDemandShortage";
					break;
				case "BomDemandSummaryXtraReport":
					ProjBomAvailItemCodeGridColumn.FieldName = "ItemCode";
					ProjBomAvailItemDescriptionGridColumn.FieldName = "ItemDescription";
					ProjBomAvailItemTypeGridColumn.FieldName = "ItemType";
					ProjBomAvailLocalQtyGridColumn.FieldName = "LocalQuantityOnHand";
					ProjBomAvailQtyOnHndGridColumn.FieldName = "QuantityOnHand";
					ProjBomAvailNonLocalQtyGridColumn.FieldName = "NonLocalQuantityOnHand";
					ProjBomAvailQtyShortageGridColumn.FieldName = "TotalBomDemandShortage";
					ProjBomAvailTotalAmtNeededGridColumn.FieldName = "TotalBomDemand";
					ProjBomLocalShortageGridColumn.FieldName = "BomDemandLocalShortage";
					ProjBomAvailNonLocalPalletsQtyGridColumn.FieldName = "NonLocalPalletsQuantityOnHand";
					ProjBomAvailCustNameGridColumn.FieldName = "CustomerName";
					break;
				case "ProductionBillingXtraReport":
					productionBillingDateGridColumn.FieldName = "Production Date";
					productionBillingCustomerGridColumn.FieldName = "Customer Name";
					productionBillingItemCodeGridColumn.FieldName = "Item #";
					productionBillingItemDescriptionGridColumn.FieldName = "Item Description";
					productionBillingItemTypeGridColumn.FieldName = "Item Type";
					productionBillingShiftGridColumn.FieldName = "Shift";
					productionBillingQuantityGridColumn.FieldName = "Quantity";
					productionBillingPOGridColumn.FieldName = "PO #";
					productionBillingUOMGridColumn.FieldName = "UOM";
					productionBillingCasesGridColumn.FieldName = "Cases";
					productionBillingPriceGridColumn.FieldName = "Price";
					break;
				case "BaggingXtraReport":
					reasonsPivotGridField.UnboundFieldName = "reasons";
					reasonsPivotGridField.UnboundType = DevExpress.Data.UnboundColumnType.String;
					minutesPivotGridField.UnboundFieldName = "reasons";
					minutesPivotGridField.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
					break;
			}

		}

		private void DisplayReportColumns()
		{

			switch (m_CurrentReport)
			{
				case "CustomerListXtraReport":
					this.nameGridColumn.Visible = true;
					this.contactNameGridColumn.Visible = true;
					this.addressGridColumn.Visible = true;
					this.cityGridColumn.Visible = true;
					this.stateGridColumn.Visible = true;
					this.postalGridColumn.Visible = true;
					this.phoneGridColumn.Visible = true;
					this.faxGridColumn.Visible = true;
					this.emailGridColumn.Visible = true;
					this.inactiveGridColumn.Visible = true;

					this.nameGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					this.contactNameGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					this.addressGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					this.cityGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					this.stateGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					this.postalGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					this.phoneGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					this.faxGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					this.emailGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					this.inactiveGridColumn.OptionsColumn.ShowInCustomizationForm = true;

					this.inactiveGridColumn.FilterInfo = new ColumnFilterInfo(inactiveGridColumn, false);

					previewGridView.BestFitColumns();
					break;
				case "ProductionEntriesXtraReport":
					productionDateGridColumn.Visible = true;
					customerNameGridColumn.Visible = true;
					itemNumberGridColumn.Visible = true;
					itemDescriptionGridColumn.Visible = true;
					itemTypeGridColumn.Visible = true;
					shiftGridColumn.Visible = true;
					quantityGridColumn.Visible = true;
					poGridColumn.Visible = true;
					lotGridColumn.Visible = true;
					palletNumberGridColumn.Visible = true;
					lpnNumberGridColumn.Visible = true;
					expirationDateGridColumn.Visible = true;
					noteGridColumn.Visible = true;

					productionDateGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					customerNameGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					itemNumberGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					itemDescriptionGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					itemTypeGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					shiftGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					quantityGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					poGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					lotGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					palletNumberGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					lpnNumberGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					expirationDateGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					noteGridColumn.OptionsColumn.ShowInCustomizationForm = true;

					previewProductionEntriesGridView.BestFitColumns();
					break;
				case "LpnStatusXtraReport":
					lpnCustomerNameGridColumn.Visible = true;
					fullLpnGridColumn.Visible = true;
					lpnItemCodeGridColumn.Visible = true;
					lpnItemDescriptionGridColumn.Visible = false;
					lpnQuantityGridColumn.Visible = true;
					lpnProductionDateGridColumn.Visible = true;
					lpnShippingDateGridColumn.Visible = true;
					lpnShippingBolGridColumn.Visible = true;

					lpnCustomerNameGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					fullLpnGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					lpnItemCodeGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					lpnItemDescriptionGridColumn.OptionsColumn.ShowInCustomizationForm = false;
					lpnQuantityGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					lpnProductionDateGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					lpnShippingDateGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					lpnShippingBolGridColumn.OptionsColumn.ShowInCustomizationForm = true;

					previewLpnStatusGridView.BestFitColumns();
					break;
				case "CurrentRMInventoryXtraReport":
					rmInventoryCustomerNameGridColumn.Visible = true;
					rmInventoryIemCodeGridColumn.Visible = true;
					rmInventoryItemDescriptionGridColumn.Visible = true;
					rmInventoryQtyOnHandGridColumn.Visible = true;
					rmInventoryInactiveGridColumn.Visible = false;
					rmInventoryItemIDGridColumn.Visible = false;

					rmInventoryCustomerNameGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					rmInventoryIemCodeGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					rmInventoryItemDescriptionGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					rmInventoryQtyOnHandGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					rmInventoryInactiveGridColumn.OptionsColumn.ShowInCustomizationForm = false;
					rmInventoryItemIDGridColumn.OptionsColumn.ShowInCustomizationForm = false;

					previewCurrentRMInventoryGridView.BestFitColumns();
					break;
				case "CurrentInventoryXtraReport":
					currentInventoryCustomerNameGridColumn.Visible = true;
					currentInventoryItemCodeGridColumn.Visible = true;
					currentInventoryItemDescriptionGridColumn.Visible = true;
					currentInventoryItemTypeGridColumn.Visible = true;
					currentInventoryQuantityOnHandGridColumn.Visible = true;
					currentInventoryInventoryByPalletsGridColumn.Visible = true;
					currentInventoryUOMGridColumn.Visible = true;
					currentInventoryLocationGridColumn.Visible = true;

					currentInventoryCustomerNameGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					currentInventoryItemCodeGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					currentInventoryItemDescriptionGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					currentInventoryItemTypeGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					currentInventoryQuantityOnHandGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					currentInventoryInventoryByPalletsGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					currentInventoryUOMGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					currentInventoryLocationGridColumn.OptionsColumn.ShowInCustomizationForm = true;

					previewCurrentInventoryGridView.BestFitColumns();
					break;
				case "LocationTransfersXtraReport":
					locationTransfersDateGridColumn.Visible = true;
					locationTransferFromLocationGridColumn.Visible = true;
					locationTransferToLocationGridColumn.Visible = true;
					locationTransferItemCodeGridColumn.Visible = true;
					locationTransferItemDescriptionGridColumn.Visible = true;
					locationTransferNumberGridColumn.Visible = true;
					locationTransferItemLotGridColumn.Visible = true;
					locationTransferExpirationDateGridColumn.Visible = true;
					locationTransferQuantityGridColumn.Visible = true;
					locationTransferExpirationDateFormatGridColumn.Visible = false;
					locationTransferUnitsGridColumn.Visible = true;
					locationTransferPalletsGridColumn.Visible = true;
					locationTransferCarrierGridColumn.Visible = true;

					locationTransfersDateGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					locationTransferFromLocationGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					locationTransferToLocationGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					locationTransferItemCodeGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					locationTransferItemDescriptionGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					locationTransferNumberGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					locationTransferItemLotGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					locationTransferExpirationDateGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					locationTransferQuantityGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					locationTransferExpirationDateFormatGridColumn.OptionsColumn.ShowInCustomizationForm = false;
					locationTransferUnitsGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					locationTransferPalletsGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					locationTransferCarrierGridColumn.OptionsColumn.ShowInCustomizationForm = true;

					previewLocationTransfersGridView.BestFitColumns();
					break;
				case "ShiftScheduleXtraReport":
					shiftScheduleMachineNameGridColumn.Visible = true;
					shiftSchedulePeopleGridColumn.Visible = true;
					shiftScheduleOperatorGridColumn.Visible = true;
					shiftScheduleItemCodeGridColumn.Visible = true;
					shiftScheduleItemDescriptionGridColumn.Visible = true;
					shiftScheduleQuantityGridColumn.Visible = true;
					shiftScheduleSchedByQtyGridColumn.Visible = true;
					shiftScheduleNoteGridColumn.Visible = true;
					shiftScheduleMustRunGridColumn.Visible = true;
					shiftSchedulePriorityLevelGridColumn.Visible = true;

					shiftScheduleGridView.BestFitColumns();
					break;
				case "WeeklyProductionXtraReport":
					weeklyProductionItemCodeGridColumn.Visible = true;
					weeklyProductionItemDescriptionGridColumn.Visible = true;
					weeklyProductionCasesRequiredGridColumn.Visible = true;
					weeklyProductionBagsRequiredGridColumn.Visible = true;
					weeklyProductionMondayGridColumn.Visible = true;
					weeklyProductionTuesdayGridColumn.Visible = true;
					weeklyProductionWednesdayGridColumn.Visible = true;
					weeklyProductionThursdayGridColumn.Visible = true;
					weeklyProductionFridayGridColumn.Visible = true;
					weeklyProductionSaturdayGridColumn.Visible = true;
					weeklyProductionSundayGridColumn.Visible = true;
					weeklyProductionTotalProducedGridColumn.Visible = true;
					weeklyProductionPercentageCompleteGridColumn.Visible = true;
					weeklyProductionProductionWeekGridColumn.Visible = true;
					weeklyProductionTotalProducedWeeklyGridColumn.Visible = true;

					weeklyProductionGridView.BestFitColumns();
					break;
				case "ProjBomAvailXtraReport":
					ProjBomAvailCustPOGridColumn.Visible = true;
					ProjBomAvailItemCodeGridColumn.Visible = true;
					ProjBomAvailItemDescriptionGridColumn.Visible = true;
					ProjBomAvailItemTypeGridColumn.Visible = true;
					ProjBomLocalShortageGridColumn.Visible = true;
					ProjBomAvailQtyOnHndGridColumn.Visible = false;
					ProjBomAvailLocalQtyGridColumn.Visible = true;
					ProjBomAvailNonLocalQtyGridColumn.Visible = false;
					ProjBomAvailQtyShortageGridColumn.Visible = false;
					ProjBomAvailTotalAmtNeededGridColumn.Visible = false;
					ProjBomAvailNonLocalPalletsQtyGridColumn.Visible = false;
					ProjBomAvailCustNameGridColumn.Visible = false;
					neededBy.Visible = false;
					lblNededBy.Visible = false;

					ProjBomAvailCustPOGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					ProjBomAvailItemCodeGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					ProjBomAvailItemDescriptionGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					ProjBomAvailItemTypeGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					ProjBomAvailNonLocalQtyGridColumn.OptionsColumn.ShowInCustomizationForm = false;
					ProjBomAvailQtyOnHndGridColumn.OptionsColumn.ShowInCustomizationForm = false;
					ProjBomAvailLocalQtyGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					ProjBomLocalShortageGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					ProjBomAvailQtyShortageGridColumn.OptionsColumn.ShowInCustomizationForm = false;
					ProjBomAvailTotalAmtNeededGridColumn.OptionsColumn.ShowInCustomizationForm = false;
					ProjBomAvailNonLocalPalletsQtyGridColumn.OptionsColumn.ShowInCustomizationForm = false;
					ProjBomAvailCustNameGridColumn.OptionsColumn.ShowInCustomizationForm = false;

					ProjBomAvailGridView.BestFitColumns();
					break;
				case "BomDemandSummaryXtraReport":
					ProjBomAvailCustPOGridColumn.Visible = false;
					ProjBomAvailItemCodeGridColumn.Visible = true;
					ProjBomAvailItemDescriptionGridColumn.Visible = true;
					ProjBomAvailItemTypeGridColumn.Visible = true;
					ProjBomAvailLocalQtyGridColumn.Visible = true;
					ProjBomAvailQtyOnHndGridColumn.Visible = true;
					ProjBomAvailNonLocalQtyGridColumn.Visible = true;
					ProjBomAvailQtyShortageGridColumn.Visible = true;
					ProjBomAvailTotalAmtNeededGridColumn.Visible = true;
					ProjBomLocalShortageGridColumn.Visible = true;
					ProjBomAvailNonLocalPalletsQtyGridColumn.Visible = true;
					neededBy.Visible = true;
					lblNededBy.Visible = true;
					ProjBomAvailCustNameGridColumn.Visible = true;

					ProjBomAvailCustPOGridColumn.OptionsColumn.ShowInCustomizationForm = false;
					ProjBomAvailItemCodeGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					ProjBomAvailItemDescriptionGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					ProjBomAvailItemTypeGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					ProjBomLocalShortageGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					ProjBomAvailQtyOnHndGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					ProjBomAvailNonLocalQtyGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					ProjBomAvailLocalQtyGridColumn.OptionsColumn.ShowInCustomizationForm = false;
					ProjBomAvailQtyShortageGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					ProjBomAvailTotalAmtNeededGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					ProjBomAvailNonLocalPalletsQtyGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					ProjBomAvailCustNameGridColumn.OptionsColumn.ShowInCustomizationForm = true;

					ProjBomAvailGridView.BestFitColumns();
					break;
				case "ProductionBillingXtraReport":
					productionBillingDateGridColumn.Visible = true;
					productionBillingCustomerGridColumn.Visible = true;
					productionBillingItemCodeGridColumn.Visible = true;
					productionBillingItemDescriptionGridColumn.Visible = true;
					productionBillingItemTypeGridColumn.Visible = true;
					productionBillingShiftGridColumn.Visible = true;
					productionBillingQuantityGridColumn.Visible = true;
					productionBillingPOGridColumn.Visible = true;
					productionBillingUOMGridColumn.Visible = true;
					productionBillingCasesGridColumn.Visible = true;
					productionBillingPriceGridColumn.Visible = true;

					productionBillingDateGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					productionBillingCustomerGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					productionBillingItemCodeGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					productionBillingItemDescriptionGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					productionBillingItemTypeGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					productionBillingShiftGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					productionBillingQuantityGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					productionBillingPOGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					productionBillingUOMGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					productionBillingCasesGridColumn.OptionsColumn.ShowInCustomizationForm = true;
					productionBillingPriceGridColumn.OptionsColumn.ShowInCustomizationForm = true;

					previewProductionBillingGridView.BestFitColumns();
					break;
				case "BaggingXtraReport":
					baggingReportPivotGridControl.BestFit();

					break;
			}

		}

		private void reportsXtraTabControl_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
		{

			this.printBarButtonItem.Enabled = (e.Page.Name != filterXtraTabPage.Name);

		}

		private void printBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			PrintableComponentLink pcl = new PrintableComponentLink(new PrintingSystem());
			pcl.CreateReportHeaderArea += PrintableComponentLink_CreateReportHeaderArea;
			switch (m_CurrentReport)
			{
				case "CustomerListXtraReport":
					pcl.Component = previewGridControl;
					if (previewGridView.VisibleColumns.Count > 5)
					{
						pcl.Landscape = true;
						pcl.CreateDocument();
					}
					break;
				case "ProductionEntriesXtraReport":
					pcl.Component = previewProductionEntriesGridControl;
					if (previewProductionEntriesGridView.VisibleColumns.Count > 5)
					{
						pcl.Landscape = true;
						pcl.CreateDocument();
					}
					break;
				case "LpnStatusXtraReport":
					pcl.Component = previewLpnStatusGridControl;
					if (previewLpnStatusGridView.VisibleColumns.Count > 5)
					{
						pcl.Landscape = true;
						pcl.CreateDocument();
					}
					break;
				case "CurrentRMInventoryXtraReport":
					pcl.Component = previewCurrentRMInventoryGridControl;
					if (previewCurrentRMInventoryGridView.VisibleColumns.Count > 5)
					{
						pcl.Landscape = true;
						pcl.CreateDocument();
					}
					break;
				case "CurrentInventoryXtraReport":
					pcl.Component = previewCurrentInventoryGridControl;
					if (previewCurrentInventoryGridView.VisibleColumns.Count > 5)
					{
						pcl.Landscape = true;
						pcl.CreateDocument();
					}
					break;
				case "LocationTransfersXtraReport":
					pcl.Component = previewLocationTransfersGridControl;
					if (previewLocationTransfersGridView.VisibleColumns.Count > 5)
					{
						pcl.Landscape = true;
						pcl.CreateDocument();
					}
					break;
				case "ShiftScheduleXtraReport":
					pcl.Component = shiftScheduleGridControl;
					if (shiftScheduleGridView.VisibleColumns.Count > 5)
					{
						pcl.Landscape = true;
						pcl.CreateDocument();
					}
					break;
				case "WeeklyProductionXtraReport":
					pcl.Component = weeklyProductionGridControl;
					if (weeklyProductionGridView.VisibleColumns.Count > 5)
					{
						pcl.Landscape = true;
						pcl.CreateDocument();
					}
					break;
				case "ProjBomAvailXtraReport":
					pcl.Component = ProjBomAvailGridControl;
					if (ProjBomAvailGridView.VisibleColumns.Count > 5)
					{
						pcl.Landscape = true;
						pcl.CreateDocument();
					}
					break;
				case "BomDemandSummaryXtraReport":
					pcl.Component = ProjBomAvailGridControl;
					if (ProjBomAvailGridView.VisibleColumns.Count > 5)
					{
						pcl.Landscape = true;
						pcl.CreateDocument();
					}
					break;
				case "ProductionBillingXtraReport":
					pcl.Component = previewProductionBillingGridControl;
					if (previewProductionBillingGridView.VisibleColumns.Count > 5)
					{
						pcl.Landscape = true;
						pcl.CreateDocument();
					}
					break;
				case "BaggingXtraReport":
					pcl.Component = baggingReportPivotGridControl;
					pcl.Landscape = true;
					pcl.CreateDocument();
					break;
			}

			pcl.ShowPreviewDialog();

		}

		private void PrintableComponentLink_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
		{

			TextBrick brick = null;
			switch (m_CurrentReport)
			{
				case "CustomerListXtraReport":
					brick = e.Graph.DrawString(previewGridControl.Text, Color.Black, new RectangleF(0, 5, 650, 25), BorderSide.None);
					break;
				case "ProductionEntriesXtraReport":
					brick = e.Graph.DrawString(previewProductionEntriesGridControl.Text, Color.Black, new RectangleF(0, 5, 650, 25), BorderSide.None);
					break;
				case "LpnStatusXtraReport":
					brick = e.Graph.DrawString(previewLpnStatusGridControl.Text, Color.Black, new RectangleF(0, 5, 650, 25), BorderSide.None);
					break;
				case "CurrentRMInventoryXtraReport":
					brick = e.Graph.DrawString(previewCurrentRMInventoryGridControl.Text, Color.Black, new Rectangle(0, 5, 650, 25), BorderSide.None);
					break;
				case "CurrentInventoryXtraReport":
					brick = e.Graph.DrawString(previewCurrentInventoryGridControl.Text, Color.Black, new Rectangle(0, 5, 650, 25), BorderSide.None);
					break;
				case "LocationTransfersXtraReport":
					brick = e.Graph.DrawString(previewLocationTransfersGridControl.Text, Color.Black, new Rectangle(0, 5, 650, 25), BorderSide.None);
					break;
				case "ShiftScheduleXtraReport":
					brick = e.Graph.DrawString(shiftScheduleGridControl.Text, Color.Black, new RectangleF(0, 5, 650, 25), BorderSide.None);
					break;
				case "WeeklyProductionXtraReport":
					brick = e.Graph.DrawString(weeklyProductionGridControl.Text, Color.Black, new RectangleF(0, 5, 650, 25), BorderSide.None);
					break;
				case "ProjBomAvailXtraReport":
					brick = e.Graph.DrawString(ProjBomAvailGridControl.Text, Color.Black, new Rectangle(0, 5, 650, 25), BorderSide.None);
					break;
				case "BomDemandSummaryXtraReport":
					brick = e.Graph.DrawString(ProjBomAvailGridControl.Text, Color.Black, new Rectangle(0, 5, 650, 25), BorderSide.None);
					break;
				case "ProductionBillingXtraReport":
					brick = e.Graph.DrawString(previewProductionBillingGridControl.Text, Color.Black, new RectangleF(0, 5, 650, 25), BorderSide.None);
					break;
				case "BaggingXtraReport":
					brick = e.Graph.DrawString(baggingReportPivotGridControl.Text, Color.Black, new RectangleF(0, 5, 650, 25), BorderSide.None);
					break;
			}
			brick.Font = new Font("Arial", 14, FontStyle.Bold);
			brick.StringFormat = new BrickStringFormat(StringAlignment.Center);

		}

		private void exportXLSBarButtonItem_ItemClick(System.Object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			inactiveGridColumn.ColumnEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			exportSaveFileDialog.Filter = "Microsoft Office Excel Workbook(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
			exportSaveFileDialog.DefaultExt = ".xlsx";
			if (this.exportSaveFileDialog.ShowDialog() == DialogResult.OK)
			{
				switch (m_CurrentReport)
				{
					case "CustomerListXtraReport":
						previewGridView.ExportToXlsx(this.exportSaveFileDialog.FileName, new XlsxExportOptions(TextExportMode.Value, true));
						break;
					case "ProductionEntriesXtraReport":
						previewProductionEntriesGridView.ExportToXlsx(exportSaveFileDialog.FileName, new XlsxExportOptions(TextExportMode.Value, true));
						break;
					case "LpnStatusXtraReport":
						previewLpnStatusGridView.ExportToXlsx(exportSaveFileDialog.FileName, new XlsxExportOptions(TextExportMode.Value, true));
						break;
					case "CurrentRMInventoryXtraReport":
						previewCurrentRMInventoryGridView.ExportToXlsx(exportSaveFileDialog.FileName, new XlsxExportOptions(TextExportMode.Value, true));
						break;
					case "CurrentInventoryXtraReport":
						previewCurrentInventoryGridView.ExportToXlsx(exportSaveFileDialog.FileName, new XlsxExportOptions(TextExportMode.Value, true));
						break;
					case "LocationTransfersXtraReport":
						previewLocationTransfersGridView.ExportToXlsx(exportSaveFileDialog.FileName, new XlsxExportOptions(TextExportMode.Value, true));
						break;
					case "ShiftScheduleXtraReport":
						shiftScheduleGridView.ExportToXlsx(exportSaveFileDialog.FileName, new XlsxExportOptions(TextExportMode.Value, true));
						break;
					case "WeeklyProductionXtraReport":
						weeklyProductionGridView.ExportToXlsx(exportSaveFileDialog.FileName, new XlsxExportOptions(TextExportMode.Value, true));
						break;
					case "ProjBomAvailXtraReport":
						ProjBomAvailGridView.ExportToXlsx(exportSaveFileDialog.FileName, new XlsxExportOptions(TextExportMode.Value, true));
						break;
					case "BomDemandSummaryXtraReport":
						ProjBomAvailGridView.ExportToXlsx(exportSaveFileDialog.FileName, new XlsxExportOptions(TextExportMode.Value, true));
						break;
					case "ProductionBillingXtraReport":
						previewProductionBillingGridView.ExportToXlsx(exportSaveFileDialog.FileName, new XlsxExportOptions(TextExportMode.Value, true));
						break;
					case "BaggingXtraReport":
						baggingReportPivotGridControl.ExportToXlsx(exportSaveFileDialog.FileName, new XlsxExportOptions(TextExportMode.Value, true));
						break;
				}
			}
			inactiveGridColumn.ColumnEdit = null;

		}

		private void previewProductionEntriesGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
		{

			try
			{
				if (e.Column == expirationDateGridColumn && DateHelper.IsDate(e.Value))
				{
					e.DisplayText = Convert.ToDateTime(e.Value).ToString(previewProductionEntriesGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, expirationDateFormatGridColumn).ToString());
				}
			}
			catch
			{

			}

		}

		private void refreshSimpleButton_Click(object sender, EventArgs e)
		{

			bool lShouldReturn = false;
			bool onlyAssigned = false;
			CheckPermissions(ref lShouldReturn, "General", ref onlyAssigned);
			if (lShouldReturn)
			{
				previewCurrentInventoryGridControl.DataSource = null;
				return;
			}
			else
			{
				previewCurrentInventoryGridControl.DataSource = CurrentInventoryReportBLL.GetCurrentInventoryReport(null, null, null, currentInventoryInactiveItemsCheckEdit.Checked, currentInventoryInactiveCustomersCheckEdit.Checked, outOfStockItemsCheckEdit.Checked, onlyAssigned, null);
			}

		}

		private void previewLocationTransfersGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
		{

			if (e.Column == locationTransferExpirationDateGridColumn && DateHelper.IsDate(e.Value))
			{
				e.DisplayText = Convert.ToDateTime(e.Value).ToString(previewLocationTransfersGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, locationTransferExpirationDateFormatGridColumn).ToString());
			}

		}

		private void refreshShiftScheduleSimpleButton_Click(object sender, EventArgs e)
		{

			if (Utilities.ChangeType<DateTime?>(shiftScheduleDateDateEdit.EditValue).HasValue == false || Convert.ToDateTime(shiftScheduleDateDateEdit.EditValue) == DateTime.MinValue)
			{
				shiftScheduleGridControl.DataSource = null;
				return;
			}
			shiftScheduleGridControl.DataSource = ShiftScheduleReportBLL.GetShiftScheduleReport(Utilities.ChangeType<DateTime?>(shiftScheduleDateDateEdit.EditValue), (shiftScheduleShiftComboBoxEdit.EditValue == null ? null : Convert.ToString(shiftScheduleShiftComboBoxEdit.EditValue)));
			previewShiftScheduleXtraTabPage.PageVisible = true;
			reportsXtraTabControl.SelectedTabPage = previewShiftScheduleXtraTabPage;
			shiftScheduleGridControl.Text = string.Format("{0} - {1}", Convert.ToDateTime(shiftScheduleDateDateEdit.EditValue).ToLongDateString(), shiftScheduleShiftComboBoxEdit.Text);

		}

		private void baggingReportPivotGridControl_CustomUnboundFieldData(object sender, CustomFieldDataEventArgs e)
		{

			if (e.Field.UnboundFieldName == "reasons") //reasonsPivotGridField.UnboundFieldName Then
			{
				e.Value = XpoDefault.Session.GetObjectByKey<Production>(e.GetListSourceColumnValue("ProductionID")).Reasons;
			}
			else if (e.Field.UnboundFieldName == "minutes") //PivotGridField.UnboundFieldName Then
			{
				//Dim MinPerHour As Integer = MainXtraForm.MinPerHOur
				//Dim currentProduction = XpoDefault.Session.GetObjectByKey(Of Production)(e.GetListSourceColumnValue("ProductionID"))
				//Dim MachineStandard = currentProduction.ProdMainItemID.MachineStandards.Where(Function(IMS) IMS.Machine.MachineLineID = CurrentProduction.ProdMainMachineLine.MachineLineID).FirstOrDefault()
				//If MachineStandard IsNot Nothing Then
				//    If MachineStandard.MinutesPerShift > 0 Then
				//        MinPerHour = CInt(MachineStandard.MinutesPerShift / 7.16667)
				//    Else If CurrentProduction.ProdMainItemID.MinutesPerShift > 0
				//        MinPerHour = CInt(CurrentProduction.ProdMainItemID.MinutesPerShift / 7.1667)
				//    End If
				//Else
				//    If CurrentProduction.ProdMainItemID.MinutesPerShift > 0
				//        MinPerHour = CInt(CurrentProduction.ProdMainItemID.MinutesPerShift / 7.1667)
				//    End If
				//End If
				var Minutes = DateHelper.DateDiff(DateHelper.DateInterval.Minute, Convert.ToDateTime(e.GetListSourceColumnValue("ProductionStartTime")), Convert.ToDateTime(e.GetListSourceColumnValue("ProductionStopTime")));
				var BreakMinutes = BreakTimeBLL.GetBreakMinutes(Convert.ToDateTime(e.GetListSourceColumnValue("ProductionDate")), Convert.ToDateTime(e.GetListSourceColumnValue("ProductionStartTime")), Convert.ToDateTime(e.GetListSourceColumnValue("ProductionStopTime")));
				e.Value = Minutes - BreakMinutes;
			}

		}

		private void baggingReportPivotGridControl_CustomSummary(object sender, PivotGridCustomSummaryEventArgs e)
		{
			if (e.DataField == reasonsPivotGridField)
			{
				// This is a Grand Total cell.
				if (ReferenceEquals(e.ColumnField, null) || ReferenceEquals(e.RowField, null))
				{
					//e.CustomValue = ""
					return;
				}
				PivotGridControl pivot = sender as PivotGridControl;
				int lastRowFieldIndex = pivot.Fields.GetVisibleFieldCount(PivotArea.RowArea) - 1;
				int lastColumnFieldIndex = pivot.Fields.GetVisibleFieldCount(PivotArea.ColumnArea) - 1;

				// This is a Total cell.
				if (!(e.RowField.AreaIndex == lastRowFieldIndex && e.ColumnField.AreaIndex == lastColumnFieldIndex))
				{
					//e.CustomValue = ""
					return;
				}
				//Dim currentRow As PivotDrillDownDataRow
				//Dim reasonSummary As List(Of String) = New List(Of String)
				//Dim ds = e.CreateDrillDownDataSource()
				//'If ds.RowCount > 10 Then
				//'    e.CustomValue = ds.RowCount
				//'    Exit Sub
				//'End If
				//For i = 0 To ds.RowCount - 1
				//    currentRow = ds(i)
				//    For Each reason In currentRow(reasonsPivotGridField).ToString.Split(";"c)
				//        If Len(reason) > 0 AndAlso reasonSummary.Contains(reason) = False Then
				//            reasonSummary.Add(reason)
				//        End If
				//    Next
				//Next
				//e.CustomValue = String.Join(";", reasonSummary)
				e.CustomValue = e.SummaryValue.Max;
			}

		}

		private void neededBy_Properties_DateTimeChanged(object sender, EventArgs e)
		{
			if (neededBy.Visible == false)
			{
				return;
			}
			if (neededBy != null)
			{
				ProjBomAvailGridControl.DataSource = BomAvailabilityReportBLL.GetDemandSummary(XpoDefault.Session, neededBy.DateTime);
			}
			else
			{
				ProjBomAvailGridControl.DataSource = BomAvailabilityReportBLL.GetDemandSummary(XpoDefault.Session);
			}
			ProjBomAvailGridControl.RefreshDataSource();
		}

		private void LabelControl3_Click(object sender, EventArgs e)
		{

		}

		private void previewProductionBillingGridView_FilterEditorCreated(object sender, DevExpress.XtraGrid.Views.Base.FilterControlEventArgs e)
		{

			e.FilterControl.BeforeShowValueEditor += FilterControl_BeforeShowValueEditor;
		}

		private void FilterControl_BeforeShowValueEditor(object sender, DevExpress.XtraEditors.Filtering.ShowValueEditorEventArgs e)
		{
			if (e.CurrentNode.FirstOperand.PropertyName == "Production Date")
			{
				DateEdit editor = (DateEdit)e.Editor;
				editor.Width = 200;
				editor.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
				editor.Properties.CalendarTimeProperties.Mask.EditMask = "g";
				editor.Properties.TimeEditWidth = 150;
			}
		}
	}
}