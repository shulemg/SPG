Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraPrinting
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Xpo
Imports DXDAL.SPGData
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraPivotGrid
Imports System.Linq
Imports DevExpress.XtraEditors

Public Class QuickReportsXtraForm

    Private m_CurrentReport As String
    Private m_Project As Project
    Private m_ProductionWeek As String

    Private Sub QuickReportsXtraForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.reportCodeNameGridColumn.FieldName = "CodeName"
        Me.reportNameGridColumn.FieldName = "Name"
        Me.reportTypeGridColumn.FieldName = "Type"
        Me.filterReportGridColumn.FieldName = "FilterReport"
        Me.dateFilterGridColumn.FieldName = "DateFilter"
        Me.customerFilterGridColumn.FieldName = "CustomerFilter"
        Me.itemFilterGridColumn.FieldName = "ItemFilter"
        Me.lotFilterGridColumn.FieldName = "LotFilter"
        Me.poFilterGridColumn.FieldName = "POFilter"
        Me.machineFilterGridColumn.FieldName = "MachineFilter"
        Me.shiftFilterGridColumn.FieldName = "ShiftFilter"
        Me.bolFilterGridColumn.FieldName = "BOLFilter"
        Me.dnFilterGridColumn.FieldName = "DNFilter"
        Me.destinationFilterGridColumn.FieldName = "DestinationFilter"
        Me.carrierFilterGridColumn.FieldName = "CarrierFilter"
        Me.vendorFilterGridColumn.FieldName = "VendorFilter"
        Me.itemTypeFilterGridColumn.FieldName = "itemtypeFilter"
        Me.outOfStockFilterGridColumn.FieldName = "stockFilter"

    End Sub

    Public Sub FillReports(ByVal moduleName As String)

        If String.IsNullOrEmpty(moduleName) Then
            Me.quickReportsGridControl.DataSource = New ReportsBLL().GetReports
        Else
            Me.quickReportsGridControl.DataSource = New ReportsBLL().GetReportsByModule(moduleName)
        End If

    End Sub

    Private Sub HidePreviewTabPages()

        previewCustoemrsXtraTabPage.PageVisible = False
        previewProductionEntriesXtraTabPage.PageVisible = False
        previewLpnStatusXtraTabPage.PageVisible = False
        previewCurrentRMInventoryXtraTabPage.PageVisible = False
        previewCurrentInventoryXtraTabPage.PageVisible = False
        previewLocationTransfersXtraTabPage.PageVisible = False
        previewShiftScheduleXtraTabPage.PageVisible = False
        previewWeeklyProductionXtraTabPage.PageVisible = False
        previewProjBomAvailXtraTabPage.PageVisible = False
        previewProductionBillingXtraTabPage.PageVisible = False
        previewBaggingXtraTabPage.PageVisible = False

    End Sub

    Private Sub quickReportsGridView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles quickReportsGridView.Click

        If (quickReportsGridView.CalcHitInfo(quickReportsGridControl.PointToClient(Control.MousePosition)).HitTest = GridHitTest.RowCell) Then
            If quickReportsGridView.GetFocusedRowCellValue(Me.reportTypeGridColumn).ToString <> "QuickReport" Then
                SelectReport(False, quickReportsGridView.GetFocusedRowCellValue(reportCodeNameGridColumn).ToString, False)
            Else
                SelectReport(True, quickReportsGridView.GetFocusedRowCellValue(Me.reportCodeNameGridColumn).ToString, Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(Me.filterReportGridColumn)))
            End If
        End If

    End Sub

    Public Sub SelectProjectBomAvailabilityReport(ByVal ProjectID As Project)

        m_Project = ProjectID
        SelectReport(True, "ProjBomAvailXtraReport", False)

    End Sub

    Public Sub SelectWeeklyScheduleReport(ByVal ProjectID As Project, ByVal ProductionWeek As String)

        m_Project = ProjectID
        m_ProductionWeek = ProductionWeek

        SelectReport(True, "WeeklyProductionXtraReport", False)

    End Sub

    Public Sub SelectReport(ByVal QuickReport As Boolean, ByVal ReportCodeName As String, ByVal FilterReport As Boolean)

        reportsXtraTabControl.Visible = True
        HidePreviewTabPages()

        If QuickReport Then
            m_CurrentReport = ReportCodeName
            If FilterReport Then
                reportsXtraTabControl.SelectedTabPage = filterXtraTabPage
            Else
                PreviewReport()
            End If
        Else
            DisplayReportForm(ReportCodeName)
        End If

    End Sub

    Public Sub SetShiftScheduleFilter(ByVal scheduleDate As DateTime?, ByVal scheduleShift As String)

        If scheduleDate.HasValue Then
            shiftScheduleDateDateEdit.EditValue = scheduleDate.Value
        End If
        shiftScheduleShiftComboBoxEdit.EditValue = scheduleShift

    End Sub

    Private Sub DisplayReportForm(ByVal reportCodeName As String)

        Dim reportForm As New ReportsXtraForm
        With reportForm

            .Cursor = Cursors.WaitCursor

            .fromDateEdit.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(Me.dateFilterGridColumn))
            .toDateEdit.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(Me.dateFilterGridColumn))
            .customerLookUpEdit.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(Me.customerFilterGridColumn))
            .itemCheckedListBoxControl.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(Me.itemFilterGridColumn))
            .lotTextEdit.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(Me.lotFilterGridColumn))
            .poTextEdit.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(Me.poFilterGridColumn))
            .machineLookUpEdit.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(Me.machineFilterGridColumn))
            .shiftLookUpEdit.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(Me.shiftFilterGridColumn))
            .bolTextEdit.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(Me.bolFilterGridColumn))
            .deliveryNoteNumberTextEdit.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(Me.dnFilterGridColumn))
            .destinationLookUpEdit.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(Me.destinationFilterGridColumn))
            .carrierLookUpEdit.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(Me.carrierFilterGridColumn))
            .vendorLookUpEdit.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(Me.vendorFilterGridColumn))
            .itemTypeLookUpEdit.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(Me.itemTypeFilterGridColumn))
            .outOfStockCheckEdit.Enabled = Convert.ToBoolean(quickReportsGridView.GetFocusedRowCellValue(Me.outOfStockFilterGridColumn))
            .ReportTitle = quickReportsGridView.GetFocusedRowCellValue(Me.reportNameGridColumn).ToString

            Select Case reportCodeName
                Case "ProductionDetailXtraReport"
                    Dim lShouldReturn As Boolean
                    CheckPermissions(lShouldReturn, "General", .OnlyAssigned)
                    If lShouldReturn Then
                        Return
                    End If
                    .reportColumnsXtraTabControl.SelectedTabPage = .productionXtraTabPage
                    .productionTotalPayrollCheckEdit.Checked = True
                    .productionTotalPayrollCheckEdit.Enabled = True
                    .productionTotalMinutesCheckEdit.Checked = True
                    .productionTotalMinutesCheckEdit.Enabled = True
                    .productionTotalHoursCheckEdit.Checked = True
                    .productionTotalHoursCheckEdit.Enabled = True
                    .productionStopTimeCheckEdit.Checked = True
                    .productionStopTimeCheckEdit.Enabled = True
                    .productionStartTimeCheckEdit.Checked = True
                    .productionStartTimeCheckEdit.Enabled = True
                    .productionShiftCheckEdit.Checked = True
                    .productionShiftCheckEdit.Enabled = True
                    .productionQuantityCheckEdit.Checked = True
                    .productionQuantityCheckEdit.Enabled = True
                    .productionPOCheckEdit.Checked = False
                    .productionPOCheckEdit.Enabled = False
                    .productionPackersCheckEdit.Checked = True
                    .productionPackersCheckEdit.Enabled = True
                    .productionMachineLineCheckEdit.Checked = True
                    .productionMachineLineCheckEdit.Enabled = True
                    .productionLotCheckEdit.Checked = True
                    .productionLotCheckEdit.Enabled = True
                    .productionItemDescriptionCheckEdit.Checked = True
                    .productionItemDescriptionCheckEdit.Enabled = True
                    .productionItemCodeCheckEdit.Checked = True
                    .productionItemCodeCheckEdit.Enabled = True
                    .productionExpectedCheckEdit.Checked = True
                    .productionExpectedCheckEdit.Enabled = True
                    .productionDifferenceCheckEdit.Checked = True
                    .productionDifferenceCheckEdit.Enabled = True
                    .productionDateCheckEdit.Checked = True
                    .productionDateCheckEdit.Enabled = True
                    .productionCustomerNameCheckEdit.Checked = True
                    .productionCustomerNameCheckEdit.Enabled = True
                    .productionActualSpeedCheckEdit.Checked = True
                    .productionActualSpeedCheckEdit.Enabled = True
                    .productionProjectedSpeedCheckEdit.Checked = True
                    .productionProjectedSpeedCheckEdit.Enabled = True
                    .productionProjectedPackersCheckEdit.Checked = True
                    .productionProjectedPackersCheckEdit.Enabled = True
                    .productionUOMCheckEdit.Checked = True
                    .productionUOMCheckEdit.Enabled = True
                    .productionReasonCodeCheckEdit.Checked = True
                    .productionReasonCodeCheckEdit.Enabled = True

                Case "ProductionMachineXtraReport"
                    Dim lShouldReturn As Boolean
                    CheckPermissions(lShouldReturn, "Financial", .OnlyAssigned)
                    If lShouldReturn Then
                        Return
                    End If
                    .reportColumnsXtraTabControl.SelectedTabPage = .productionMachineXtraTabPage
                    .pmsTotalMinutesCheckEdit.Checked = True
                    .pmsQuantityCheckEdit.Checked = True
                    .pmsProjectedSpeedCheckEdit.Checked = True
                    .pmsAverageSpeedCheckEdit.Checked = True
                    .pmsSpeedVariationVolCheckEdit.Checked = True
                    .pmsSpeedVariationPerCheckEdit.Checked = True
                    .pmsProjectedPackersCheckEdit.Checked = True
                    .pmsPackersCheckEdit.Checked = True
                    .pmsPackersVariationVolCheckEdit.Checked = True
                    .pmsPackersVariationPerCheckEdit.Checked = True
                    .pmsProjectedCostCheckEdit.Checked = True
                    .pmsCostCheckEdit.Checked = True
                    .pmsCostVariationCheckEdit.Checked = True
                    .pmsCostVariationPerCheckEdit.Checked = True
                    .pmsPricePerPieceCheckEdit.Checked = True
                    .pmsSalesVsPayrollCheckEdit.Checked = True
                    .pmsPriceCheckEdit.Checked = True
                    .pmsTotalSalesCheckEdit.Checked = True

                Case "ProductionShiftXtraReport"
                    Dim lShouldReturn As Boolean
                    CheckPermissions(lShouldReturn, "Financial", .OnlyAssigned)
                    If lShouldReturn Then
                        Return
                    End If
                    .reportColumnsXtraTabControl.SelectedTabPage = .productionMachineXtraTabPage
                    .pmsTotalMinutesCheckEdit.Checked = True
                    .pmsQuantityCheckEdit.Checked = True
                    .pmsProjectedSpeedCheckEdit.Checked = True
                    .pmsAverageSpeedCheckEdit.Checked = True
                    .pmsSpeedVariationVolCheckEdit.Checked = True
                    .pmsSpeedVariationPerCheckEdit.Checked = True
                    .pmsProjectedPackersCheckEdit.Checked = True
                    .pmsPackersCheckEdit.Checked = True
                    .pmsPackersVariationVolCheckEdit.Checked = True
                    .pmsPackersVariationPerCheckEdit.Checked = True
                    .pmsProjectedCostCheckEdit.Checked = True
                    .pmsCostCheckEdit.Checked = True
                    .pmsCostVariationCheckEdit.Checked = True
                    .pmsCostVariationPerCheckEdit.Checked = True
                    .pmsPricePerPieceCheckEdit.Checked = True
                    .pmsSalesVsPayrollCheckEdit.Checked = True
                    .pmsPriceCheckEdit.Checked = True
                    .pmsTotalSalesCheckEdit.Checked = True

                Case "ProductionSummaryXtraReport"
                    Dim lShouldReturn As Boolean
                    CheckPermissions(lShouldReturn, "General", .OnlyAssigned)
                    If lShouldReturn Then
                        Return
                    End If

                Case "ProductionEntriesXtraReport"
                    Dim lShouldReturn As Boolean
                    CheckPermissions(lShouldReturn, "General", .OnlyAssigned)
                    If lShouldReturn Then
                        Return
                    End If
                    .reportColumnsXtraTabControl.SelectedTabPage = .productionXtraTabPage
                    .productionTotalPayrollCheckEdit.Checked = False
                    .productionTotalPayrollCheckEdit.Enabled = False
                    .productionTotalMinutesCheckEdit.Checked = False
                    .productionTotalMinutesCheckEdit.Enabled = False
                    .productionTotalHoursCheckEdit.Checked = False
                    .productionTotalHoursCheckEdit.Enabled = False
                    .productionStopTimeCheckEdit.Checked = False
                    .productionStopTimeCheckEdit.Enabled = False
                    .productionStartTimeCheckEdit.Checked = False
                    .productionStartTimeCheckEdit.Enabled = False
                    .productionShiftCheckEdit.Checked = False
                    .productionShiftCheckEdit.Enabled = False
                    .productionQuantityCheckEdit.Checked = True
                    .productionQuantityCheckEdit.Enabled = True
                    .productionPOCheckEdit.Checked = True
                    .productionPOCheckEdit.Enabled = True
                    .productionPackersCheckEdit.Checked = False
                    .productionPackersCheckEdit.Enabled = False
                    .productionMachineLineCheckEdit.Checked = False
                    .productionMachineLineCheckEdit.Enabled = False
                    .productionLotCheckEdit.Checked = True
                    .productionLotCheckEdit.Enabled = True
                    .productionItemDescriptionCheckEdit.Checked = True
                    .productionItemDescriptionCheckEdit.Enabled = True
                    .productionItemCodeCheckEdit.Checked = True
                    .productionItemCodeCheckEdit.Enabled = True
                    .productionExpectedCheckEdit.Checked = False
                    .productionExpectedCheckEdit.Enabled = False
                    .productionDifferenceCheckEdit.Checked = False
                    .productionDifferenceCheckEdit.Enabled = False
                    .productionDateCheckEdit.Checked = True
                    .productionDateCheckEdit.Enabled = True
                    .productionCustomerNameCheckEdit.Checked = True
                    .productionCustomerNameCheckEdit.Enabled = True
                    .productionActualSpeedCheckEdit.Checked = False
                    .productionActualSpeedCheckEdit.Enabled = False
                    .productionProjectedSpeedCheckEdit.Checked = False
                    .productionProjectedSpeedCheckEdit.Enabled = False
                    .productionProjectedPackersCheckEdit.Checked = False
                    .productionProjectedPackersCheckEdit.Enabled = False
                    .productionUOMCheckEdit.Checked = False
                    .productionUOMCheckEdit.Enabled = False
                    .productionReasonCodeCheckEdit.Checked = False
                    .productionReasonCodeCheckEdit.Enabled = False

                Case "CostingXtraReport"
                    Dim lShouldReturn As Boolean
                    CheckPermissions(lShouldReturn, "Financial", .OnlyAssigned)
                    If lShouldReturn Then
                        Return
                    End If
                    .reportColumnsXtraTabControl.SelectedTabPage = .costingXtraTabPage
                    .costingActualSpeedCheckEdit.Checked = True
                    .costingActualSpeedCheckEdit.Enabled = True
                    .costingBoxesCheckEdit.Checked = True
                    .costingBoxesCheckEdit.Enabled = True
                    .costingCostCheckBox.Checked = True
                    .costingCostCheckBox.Enabled = True
                    .costingCostPerPieceCheckEdit.Checked = True
                    .costingCostPerPieceCheckEdit.Enabled = True
                    .costingCustomerCheckEdit.Checked = True
                    .costingCustomerCheckEdit.Enabled = True
                    .costingDifferenceCheckEdit.Checked = True
                    .costingDifferenceCheckEdit.Enabled = True
                    .costingExpectedCheckEdit.Checked = True
                    .costingExpectedCheckEdit.Enabled = True
                    .costingFilmCheckEdit.Checked = True
                    .costingFilmCheckEdit.Enabled = True
                    .costingFreightCheckEdit.Checked = True
                    .costingFreightCheckEdit.Enabled = True
                    .costingItemCodeCheckEdit.Checked = True
                    .costingItemCodeCheckEdit.Enabled = True
                    .costingItemDescriptionCheckEdit.Checked = True
                    .costingItemDescriptionCheckEdit.Enabled = True
                    .costingLotCheckEdit.Checked = True
                    .costingLotCheckEdit.Enabled = True
                    .costingMachineLineCheckEdit.Checked = True
                    .costingMachineLineCheckEdit.Enabled = True
                    .costingMachineSpeedCheckEdit.Checked = True
                    .costingMachineSpeedCheckEdit.Enabled = True
                    .costingOperatorsCheckEdit.Checked = True
                    .costingOperatorsCheckEdit.Enabled = True
                    .costingPackersCheckEdit.Checked = True
                    .costingPackersCheckEdit.Enabled = True
                    .costingPacksPerMinuteCheckEdit.Checked = True
                    .costingPacksPerMinuteCheckEdit.Enabled = True
                    .costingPalletsCheckEdit.Checked = True
                    .costingPalletsCheckEdit.Enabled = True
                    .costingPayrollCheckEdit.Checked = True
                    .costingPayrollCheckEdit.Enabled = True
                    .costingPriceCheckEdit.Checked = True
                    .costingPriceCheckEdit.Enabled = True
                    .costingProductionDateCheckEdit.Checked = True
                    .costingProductionDateCheckEdit.Enabled = True
                    .costingProfitCheckEdit.Checked = True
                    .costingProfitCheckEdit.Enabled = True
                    .costingProfitVsSalesCheckEdit.Checked = True
                    .costingProfitVsSalesCheckEdit.Enabled = True
                    .costingQuantityCheckEdit.Checked = True
                    .costingQuantityCheckEdit.Enabled = True
                    .costingRebateCheckEdit.Checked = True
                    .costingRebateCheckEdit.Enabled = True
                    .CostingSalesVsCostCheckEdit.Checked = True
                    .CostingSalesVsCostCheckEdit.Enabled = True
                    .costingSalesVsPayrollCheckEdit.Checked = True
                    .costingSalesVsPayrollCheckEdit.Enabled = True
                    .costingSalesVsProfitCheckEdit.Checked = True
                    .costingSalesVsProfitCheckEdit.Enabled = True
                    .costingShiftCheckEdit.Checked = True
                    .costingShiftCheckEdit.Enabled = True
                    .costingStartTimeCheckEdit.Checked = True
                    .costingStartTimeCheckEdit.Enabled = True
                    .costingStopTimeCheckEdit.Checked = True
                    .costingStopTimeCheckEdit.Enabled = True
                    .costingStretchWrapCheckEdit.Checked = True
                    .costingStretchWrapCheckEdit.Enabled = True
                    .costingSupersCheckEdit.Checked = True
                    .costingSupersCheckEdit.Enabled = True
                    .costingTotalHoursCheckEdit.Checked = True
                    .costingTotalHoursCheckEdit.Enabled = True
                    .costingTotalMinutesCheckEdit.Checked = True
                    .costingTotalMinutesCheckEdit.Enabled = True
                    .costingTotalOtherCheckEdit.Checked = True
                    .costingTotalOtherCheckEdit.Enabled = True

                Case "CostingSmallXtraReport"
                    Dim lShouldReturn As Boolean
                    CheckPermissions(lShouldReturn, "Financial", .OnlyAssigned)
                    If lShouldReturn Then
                        Return
                    End If
                    .reportColumnsXtraTabControl.SelectedTabPage = .costingXtraTabPage
                    .costingActualSpeedCheckEdit.Checked = True
                    .costingActualSpeedCheckEdit.Enabled = True
                    .costingBoxesCheckEdit.Checked = False
                    .costingBoxesCheckEdit.Enabled = True
                    .costingCostCheckBox.Checked = True
                    .costingCostCheckBox.Enabled = True
                    .costingCostPerPieceCheckEdit.Checked = True
                    .costingCostPerPieceCheckEdit.Enabled = True
                    .costingCustomerCheckEdit.Checked = True
                    .costingCustomerCheckEdit.Enabled = True
                    .costingDifferenceCheckEdit.Checked = False
                    .costingDifferenceCheckEdit.Enabled = True
                    .costingExpectedCheckEdit.Checked = False
                    .costingExpectedCheckEdit.Enabled = True
                    .costingFilmCheckEdit.Checked = False
                    .costingFilmCheckEdit.Enabled = True
                    .costingFreightCheckEdit.Checked = False
                    .costingFreightCheckEdit.Enabled = True
                    .costingItemCodeCheckEdit.Checked = True
                    .costingItemCodeCheckEdit.Enabled = True
                    .costingItemDescriptionCheckEdit.Checked = True
                    .costingItemDescriptionCheckEdit.Enabled = True
                    .costingLotCheckEdit.Checked = False
                    .costingLotCheckEdit.Enabled = True
                    .costingMachineLineCheckEdit.Checked = True
                    .costingMachineLineCheckEdit.Enabled = True
                    .costingMachineSpeedCheckEdit.Checked = False
                    .costingMachineSpeedCheckEdit.Enabled = True
                    .costingOperatorsCheckEdit.Checked = True
                    .costingOperatorsCheckEdit.Enabled = True
                    .costingPackersCheckEdit.Checked = True
                    .costingPackersCheckEdit.Enabled = True
                    .costingPacksPerMinuteCheckEdit.Checked = False
                    .costingPacksPerMinuteCheckEdit.Enabled = True
                    .costingPalletsCheckEdit.Checked = False
                    .costingPalletsCheckEdit.Enabled = True
                    .costingPayrollCheckEdit.Checked = True
                    .costingPayrollCheckEdit.Enabled = True
                    .costingPriceCheckEdit.Checked = True
                    .costingPriceCheckEdit.Enabled = True
                    .costingProductionDateCheckEdit.Checked = True
                    .costingProductionDateCheckEdit.Enabled = True
                    .costingProfitCheckEdit.Checked = True
                    .costingProfitCheckEdit.Enabled = True
                    .costingProfitVsSalesCheckEdit.Checked = False
                    .costingProfitVsSalesCheckEdit.Enabled = True
                    .costingQuantityCheckEdit.Checked = True
                    .costingQuantityCheckEdit.Enabled = True
                    .costingRebateCheckEdit.Checked = True
                    .costingRebateCheckEdit.Enabled = True
                    .CostingSalesVsCostCheckEdit.Checked = False
                    .CostingSalesVsCostCheckEdit.Enabled = True
                    .costingSalesVsPayrollCheckEdit.Checked = False
                    .costingSalesVsPayrollCheckEdit.Enabled = True
                    .costingSalesVsProfitCheckEdit.Checked = False
                    .costingSalesVsProfitCheckEdit.Enabled = True
                    .costingShiftCheckEdit.Checked = True
                    .costingShiftCheckEdit.Enabled = True
                    .costingStartTimeCheckEdit.Checked = True
                    .costingStartTimeCheckEdit.Enabled = True
                    .costingStopTimeCheckEdit.Checked = True
                    .costingStopTimeCheckEdit.Enabled = True
                    .costingStretchWrapCheckEdit.Checked = False
                    .costingStretchWrapCheckEdit.Enabled = True
                    .costingSupersCheckEdit.Checked = True
                    .costingSupersCheckEdit.Enabled = True
                    .costingTotalHoursCheckEdit.Checked = True
                    .costingTotalHoursCheckEdit.Enabled = True
                    .costingTotalMinutesCheckEdit.Checked = True
                    .costingTotalMinutesCheckEdit.Enabled = True
                    .costingTotalOtherCheckEdit.Checked = False
                    .costingTotalOtherCheckEdit.Enabled = True

                Case "FinancialCostingXtraReport"
                    Dim lShouldReturn As Boolean
                    CheckPermissions(lShouldReturn, "Financial", .OnlyAssigned)
                    If lShouldReturn Then
                        Return
                    End If
                    .reportColumnsXtraTabControl.SelectedTabPage = .costingXtraTabPage
                    .costingActualSpeedCheckEdit.Checked = False
                    .costingActualSpeedCheckEdit.Enabled = True
                    .costingBoxesCheckEdit.Checked = True
                    .costingBoxesCheckEdit.Enabled = True
                    .costingCostCheckBox.Checked = True
                    .costingCostCheckBox.Enabled = True
                    .costingCostPerPieceCheckEdit.Checked = True
                    .costingCostPerPieceCheckEdit.Enabled = True
                    .costingCustomerCheckEdit.Checked = True
                    .costingCustomerCheckEdit.Enabled = True
                    .costingDifferenceCheckEdit.Checked = False
                    .costingDifferenceCheckEdit.Enabled = True
                    .costingExpectedCheckEdit.Checked = False
                    .costingExpectedCheckEdit.Enabled = True
                    .costingFilmCheckEdit.Checked = True
                    .costingFilmCheckEdit.Enabled = True
                    .costingFreightCheckEdit.Checked = True
                    .costingFreightCheckEdit.Enabled = True
                    .costingItemCodeCheckEdit.Checked = True
                    .costingItemCodeCheckEdit.Enabled = True
                    .costingItemDescriptionCheckEdit.Checked = True
                    .costingItemDescriptionCheckEdit.Enabled = True
                    .costingLotCheckEdit.Checked = False
                    .costingLotCheckEdit.Enabled = True
                    .costingMachineLineCheckEdit.Checked = False
                    .costingMachineLineCheckEdit.Enabled = True
                    .costingMachineSpeedCheckEdit.Checked = False
                    .costingMachineSpeedCheckEdit.Enabled = True
                    .costingOperatorsCheckEdit.Checked = False
                    .costingOperatorsCheckEdit.Enabled = True
                    .costingPackersCheckEdit.Checked = False
                    .costingPackersCheckEdit.Enabled = True
                    .costingPacksPerMinuteCheckEdit.Checked = True
                    .costingPacksPerMinuteCheckEdit.Enabled = True
                    .costingPalletsCheckEdit.Checked = True
                    .costingPalletsCheckEdit.Enabled = True
                    .costingPayrollCheckEdit.Checked = True
                    .costingPayrollCheckEdit.Enabled = True
                    .costingPriceCheckEdit.Checked = True
                    .costingPriceCheckEdit.Enabled = True
                    .costingProductionDateCheckEdit.Checked = True
                    .costingProductionDateCheckEdit.Enabled = True
                    .costingProfitCheckEdit.Checked = True
                    .costingProfitCheckEdit.Enabled = True
                    .costingProfitVsSalesCheckEdit.Checked = False
                    .costingProfitVsSalesCheckEdit.Enabled = True
                    .costingQuantityCheckEdit.Checked = True
                    .costingQuantityCheckEdit.Enabled = True
                    .costingRebateCheckEdit.Checked = True
                    .costingRebateCheckEdit.Enabled = True
                    .CostingSalesVsCostCheckEdit.Checked = False
                    .CostingSalesVsCostCheckEdit.Enabled = True
                    .costingSalesVsPayrollCheckEdit.Checked = False
                    .costingSalesVsPayrollCheckEdit.Enabled = True
                    .costingSalesVsProfitCheckEdit.Checked = False
                    .costingSalesVsProfitCheckEdit.Enabled = True
                    .costingShiftCheckEdit.Checked = False
                    .costingShiftCheckEdit.Enabled = True
                    .costingStartTimeCheckEdit.Checked = False
                    .costingStartTimeCheckEdit.Enabled = True
                    .costingStopTimeCheckEdit.Checked = False
                    .costingStopTimeCheckEdit.Enabled = True
                    .costingStretchWrapCheckEdit.Checked = True
                    .costingStretchWrapCheckEdit.Enabled = True
                    .costingSupersCheckEdit.Checked = False
                    .costingSupersCheckEdit.Enabled = True
                    .costingTotalHoursCheckEdit.Checked = False
                    .costingTotalHoursCheckEdit.Enabled = True
                    .costingTotalMinutesCheckEdit.Checked = False
                    .costingTotalMinutesCheckEdit.Enabled = True
                    .costingTotalOtherCheckEdit.Checked = True
                    .costingTotalOtherCheckEdit.Enabled = True

                Case "ShippingXtraReport"
                    Dim lShouldReturn As Boolean
                    CheckPermissions(lShouldReturn, "General", .OnlyAssigned)
                    If lShouldReturn Then
                        Return
                    End If
                    .reportColumnsXtraTabControl.SelectedTabPage = .transportationXtraTabPage
                    .transportationVendorCheckEdit.Checked = False
                    .transportationVendorCheckEdit.Enabled = False
                    .transportationTrailerCheckEdit.Checked = True
                    .transportationTrailerCheckEdit.Enabled = True
                    .transportationShiftCheckEdit.Checked = True
                    .transportationShiftCheckEdit.Enabled = True
                    .transportationSealCheckEdit.Checked = True
                    .transportationSealCheckEdit.Enabled = True
                    .transportationQuantityCheckEdit.Checked = True
                    .transportationQuantityCheckEdit.Enabled = True
                    .transportationPOCheckEdit.Checked = True
                    .transportationPOCheckEdit.Enabled = True
                    .transportationLotCheckEdit.Checked = True
                    .transportationLotCheckEdit.Enabled = True
                    .transportationItemDescriptionCheckEdit.Checked = True
                    .transportationItemDescriptionCheckEdit.Enabled = True
                    .transportationItemCheckEdit.Checked = True
                    .transportationItemCheckEdit.Enabled = True
                    .transportationDestinationCheckEdit.Checked = True
                    .transportationDestinationCheckEdit.Enabled = True
                    .transportationDeliveryNoteCheckEdit.Checked = True
                    .transportationDeliveryNoteCheckEdit.Enabled = True
                    .transportationDateCheckEdit.Checked = True
                    .transportationDateCheckEdit.Enabled = True
                    .transportationCustomerCheckEdit.Checked = True
                    .transportationCustomerCheckEdit.Enabled = True
                    .transportationCarrierCheckEdit.Checked = True
                    .transportationCarrierCheckEdit.Enabled = True
                    .transportationBolCheckEdit.Checked = True
                    .transportationBolCheckEdit.Enabled = True
                    .transportationExpirationDateCheckEdit.Checked = True
                    .transportationExpirationDateCheckEdit.Enabled = True

                Case "ShippingReturnsXtraReport"
                    Dim lShouldReturn As Boolean
                    CheckPermissions(lShouldReturn, "General", .OnlyAssigned)
                    If lShouldReturn Then
                        Return
                    End If
                    .reportColumnsXtraTabControl.SelectedTabPage = .transportationXtraTabPage
                    .transportationVendorCheckEdit.Checked = False
                    .transportationVendorCheckEdit.Enabled = False
                    .transportationTrailerCheckEdit.Checked = True
                    .transportationTrailerCheckEdit.Enabled = True
                    .transportationShiftCheckEdit.Checked = True
                    .transportationShiftCheckEdit.Enabled = True
                    .transportationSealCheckEdit.Checked = True
                    .transportationSealCheckEdit.Enabled = True
                    .transportationQuantityCheckEdit.Checked = True
                    .transportationQuantityCheckEdit.Enabled = True
                    .transportationPOCheckEdit.Checked = True
                    .transportationPOCheckEdit.Enabled = True
                    .transportationLotCheckEdit.Checked = True
                    .transportationLotCheckEdit.Enabled = True
                    .transportationItemDescriptionCheckEdit.Checked = True
                    .transportationItemDescriptionCheckEdit.Enabled = True
                    .transportationItemCheckEdit.Checked = True
                    .transportationItemCheckEdit.Enabled = True
                    .transportationDestinationCheckEdit.Checked = True
                    .transportationDestinationCheckEdit.Enabled = True
                    .transportationDeliveryNoteCheckEdit.Checked = True
                    .transportationDeliveryNoteCheckEdit.Enabled = True
                    .transportationDateCheckEdit.Checked = True
                    .transportationDateCheckEdit.Enabled = True
                    .transportationCustomerCheckEdit.Checked = True
                    .transportationCustomerCheckEdit.Enabled = True
                    .transportationCarrierCheckEdit.Checked = True
                    .transportationCarrierCheckEdit.Enabled = True
                    .transportationBolCheckEdit.Checked = True
                    .transportationBolCheckEdit.Enabled = True
                    .transportationExpirationDateCheckEdit.Checked = True
                    .transportationExpirationDateCheckEdit.Enabled = True

                Case "ReceivingXtraReport"
                    Dim lShouldReturn As Boolean
                    CheckPermissions(lShouldReturn, "General", .OnlyAssigned)
                    If lShouldReturn Then
                        Return
                    End If
                    .reportColumnsXtraTabControl.SelectedTabPage = .transportationXtraTabPage
                    .transportationVendorCheckEdit.Checked = True
                    .transportationVendorCheckEdit.Enabled = True
                    .transportationTrailerCheckEdit.Checked = True
                    .transportationTrailerCheckEdit.Enabled = True
                    .transportationShiftCheckEdit.Checked = True
                    .transportationShiftCheckEdit.Enabled = True
                    .transportationSealCheckEdit.Checked = True
                    .transportationSealCheckEdit.Enabled = True
                    .transportationQuantityCheckEdit.Checked = True
                    .transportationQuantityCheckEdit.Enabled = True
                    .transportationPOCheckEdit.Checked = True
                    .transportationPOCheckEdit.Enabled = True
                    .transportationLotCheckEdit.Checked = True
                    .transportationLotCheckEdit.Enabled = True
                    .transportationItemDescriptionCheckEdit.Checked = True
                    .transportationItemDescriptionCheckEdit.Enabled = True
                    .transportationItemCheckEdit.Checked = True
                    .transportationItemCheckEdit.Enabled = True
                    .transportationDestinationCheckEdit.Checked = False
                    .transportationDestinationCheckEdit.Enabled = False
                    .transportationDeliveryNoteCheckEdit.Checked = False
                    .transportationDeliveryNoteCheckEdit.Enabled = False
                    .transportationDateCheckEdit.Checked = True
                    .transportationDateCheckEdit.Enabled = True
                    .transportationCustomerCheckEdit.Checked = True
                    .transportationCustomerCheckEdit.Enabled = True
                    .transportationCarrierCheckEdit.Checked = True
                    .transportationCarrierCheckEdit.Enabled = True
                    .transportationBolCheckEdit.Checked = True
                    .transportationBolCheckEdit.Enabled = True
                    .transportationExpirationDateCheckEdit.Checked = True
                    .transportationExpirationDateCheckEdit.Enabled = True

                Case "ReceivingReturnsXtraReport"
                    Dim lShouldReturn As Boolean
                    CheckPermissions(lShouldReturn, "General", .OnlyAssigned)
                    If lShouldReturn Then
                        Return
                    End If
                    .reportColumnsXtraTabControl.SelectedTabPage = .transportationXtraTabPage
                    .transportationVendorCheckEdit.Checked = True
                    .transportationVendorCheckEdit.Enabled = True
                    .transportationTrailerCheckEdit.Checked = True
                    .transportationTrailerCheckEdit.Enabled = True
                    .transportationShiftCheckEdit.Checked = True
                    .transportationShiftCheckEdit.Enabled = True
                    .transportationSealCheckEdit.Checked = True
                    .transportationSealCheckEdit.Enabled = True
                    .transportationQuantityCheckEdit.Checked = True
                    .transportationQuantityCheckEdit.Enabled = True
                    .transportationPOCheckEdit.Checked = True
                    .transportationPOCheckEdit.Enabled = True
                    .transportationLotCheckEdit.Checked = True
                    .transportationLotCheckEdit.Enabled = True
                    .transportationItemDescriptionCheckEdit.Checked = True
                    .transportationItemDescriptionCheckEdit.Enabled = True
                    .transportationItemCheckEdit.Checked = True
                    .transportationItemCheckEdit.Enabled = True
                    .transportationDestinationCheckEdit.Checked = False
                    .transportationDestinationCheckEdit.Enabled = False
                    .transportationDeliveryNoteCheckEdit.Checked = False
                    .transportationDeliveryNoteCheckEdit.Enabled = False
                    .transportationDateCheckEdit.Checked = True
                    .transportationDateCheckEdit.Enabled = True
                    .transportationCustomerCheckEdit.Checked = True
                    .transportationCustomerCheckEdit.Enabled = True
                    .transportationCarrierCheckEdit.Checked = True
                    .transportationCarrierCheckEdit.Enabled = True
                    .transportationBolCheckEdit.Checked = True
                    .transportationBolCheckEdit.Enabled = True
                    .transportationExpirationDateCheckEdit.Checked = True
                    .transportationExpirationDateCheckEdit.Enabled = True

                Case "InventoryAdjustmentXtraReport"
                    Dim lShouldReturn As Boolean
                    CheckPermissions(lShouldReturn, "General", .OnlyAssigned)
                    If lShouldReturn Then
                        Return
                    End If
                    .reportColumnsXtraTabControl.SelectedTabPage = .inventoryXtraTabPage
                    .inventoryPalletAvailabilityCheckEdit.Checked = False
                    .inventoryPalletAvailabilityCheckEdit.Enabled = False
                    .inventoryItemTypeCheckEdit.Checked = False
                    .inventoryItemTypeCheckEdit.Enabled = False
                    .inventoryItemDescriptionCheckEdit.Checked = False
                    .inventoryItemDescriptionCheckEdit.Enabled = False
                    .inventoryItemCheckEdit.Checked = True
                    .inventoryItemCheckEdit.Enabled = True
                    .inventoryInventoryByPalletCheckEdit.Checked = False
                    .inventoryInventoryByPalletCheckEdit.Enabled = False
                    .inventoryDateCheckEdit.Checked = True
                    .inventoryDateCheckEdit.Enabled = True
                    .inventoryCustomerCheckEdit.Checked = True
                    .inventoryCustomerCheckEdit.Enabled = True
                    .inventoryCurrentInventoryCheckEdit.Checked = False
                    .inventoryCurrentInventoryCheckEdit.Enabled = False
                    .inventoryAvailabilityCheckEdit.Checked = False
                    .inventoryAvailabilityCheckEdit.Enabled = False
                    .inventoryAdjustmentReasonCheckEdit.Checked = True
                    .inventoryAdjustmentReasonCheckEdit.Enabled = True
                    .inventoryAdjustmentCheckEdit.Checked = True
                    .inventoryAdjustmentCheckEdit.Enabled = True
                    .RMItemCodeCheckEdit.Checked = False
                    .RMItemCodeCheckEdit.Enabled = False
                    .RMItemDescriptionCheckEdit.Checked = False
                    .RMItemDescriptionCheckEdit.Enabled = False
                    .UOMCheckEdit.Enabled = False
                    .UOMCheckEdit.Checked = False

                Case "PhysicalInventoryXtraReport"
                    Dim lShouldReturn As Boolean
                    CheckPermissions(lShouldReturn, "General", .OnlyAssigned)
                    If lShouldReturn Then
                        Return
                    End If
                    .reportColumnsXtraTabControl.SelectedTabPage = .inventoryXtraTabPage
                    .inventoryPalletAvailabilityCheckEdit.Checked = False
                    .inventoryPalletAvailabilityCheckEdit.Enabled = False
                    .inventoryItemTypeCheckEdit.Checked = True
                    .inventoryItemTypeCheckEdit.Enabled = True
                    .inventoryItemDescriptionCheckEdit.Checked = True
                    .inventoryItemDescriptionCheckEdit.Enabled = True
                    .inventoryItemCheckEdit.Checked = True
                    .inventoryItemCheckEdit.Enabled = True
                    .inventoryInventoryByPalletCheckEdit.Checked = False
                    .inventoryInventoryByPalletCheckEdit.Enabled = False
                    .inventoryDateCheckEdit.Checked = False
                    .inventoryDateCheckEdit.Enabled = False
                    .inventoryCustomerCheckEdit.Checked = True
                    .inventoryCustomerCheckEdit.Enabled = True
                    .inventoryCurrentInventoryCheckEdit.Checked = True
                    .inventoryCurrentInventoryCheckEdit.Enabled = True
                    .inventoryAvailabilityCheckEdit.Checked = False
                    .inventoryAvailabilityCheckEdit.Enabled = False
                    .inventoryAdjustmentReasonCheckEdit.Checked = False
                    .inventoryAdjustmentReasonCheckEdit.Enabled = False
                    .inventoryAdjustmentCheckEdit.Checked = False
                    .inventoryAdjustmentCheckEdit.Enabled = False
                    .RMItemCodeCheckEdit.Checked = False
                    .RMItemCodeCheckEdit.Enabled = False
                    .RMItemDescriptionCheckEdit.Checked = False
                    .RMItemDescriptionCheckEdit.Enabled = False
                    .UOMCheckEdit.Enabled = False
                    .UOMCheckEdit.Checked = False

                Case "OldCurrentInventoryXtraReport"
                    Dim lShouldReturn As Boolean
                    CheckPermissions(lShouldReturn, "General", .OnlyAssigned)
                    If lShouldReturn Then
                        Return
                    End If
                    .reportColumnsXtraTabControl.SelectedTabPage = .inventoryXtraTabPage
                    .inventoryPalletAvailabilityCheckEdit.Checked = False
                    .inventoryPalletAvailabilityCheckEdit.Enabled = False
                    .inventoryItemTypeCheckEdit.Checked = True
                    .inventoryItemTypeCheckEdit.Enabled = True
                    .inventoryItemDescriptionCheckEdit.Checked = True
                    .inventoryItemDescriptionCheckEdit.Enabled = True
                    .inventoryItemCheckEdit.Checked = True
                    .inventoryItemCheckEdit.Enabled = True
                    .inventoryInventoryByPalletCheckEdit.Checked = True
                    .inventoryInventoryByPalletCheckEdit.Enabled = True
                    .inventoryDateCheckEdit.Checked = False
                    .inventoryDateCheckEdit.Enabled = False
                    .inventoryCustomerCheckEdit.Checked = True
                    .inventoryCustomerCheckEdit.Enabled = True
                    .inventoryCurrentInventoryCheckEdit.Checked = True
                    .inventoryCurrentInventoryCheckEdit.Enabled = True
                    .inventoryAvailabilityCheckEdit.Checked = False
                    .inventoryAvailabilityCheckEdit.Enabled = False
                    .inventoryAdjustmentReasonCheckEdit.Checked = False
                    .inventoryAdjustmentReasonCheckEdit.Enabled = False
                    .inventoryAdjustmentCheckEdit.Checked = False
                    .inventoryAdjustmentCheckEdit.Enabled = False
                    .RMItemCodeCheckEdit.Checked = False
                    .RMItemCodeCheckEdit.Enabled = False
                    .RMItemDescriptionCheckEdit.Checked = False
                    .RMItemDescriptionCheckEdit.Enabled = False
                    .UOMCheckEdit.Enabled = True
                    .UOMCheckEdit.Checked = False

                Case "FinishedProductAvailabilityXtraReport"
                    Dim lShouldReturn As Boolean
                    CheckPermissions(lShouldReturn, "General", .OnlyAssigned)
                    If lShouldReturn Then
                        Return
                    End If
                    .reportColumnsXtraTabControl.SelectedTabPage = .inventoryXtraTabPage
                    .inventoryPalletAvailabilityCheckEdit.Checked = True
                    .inventoryPalletAvailabilityCheckEdit.Enabled = True
                    .inventoryItemTypeCheckEdit.Checked = False
                    .inventoryItemTypeCheckEdit.Enabled = False
                    .inventoryItemDescriptionCheckEdit.Checked = True
                    .inventoryItemDescriptionCheckEdit.Enabled = True
                    .inventoryItemCheckEdit.Checked = True
                    .inventoryItemCheckEdit.Enabled = True
                    .inventoryInventoryByPalletCheckEdit.Checked = False
                    .inventoryInventoryByPalletCheckEdit.Enabled = False
                    .inventoryDateCheckEdit.Checked = False
                    .inventoryDateCheckEdit.Enabled = False
                    .inventoryCustomerCheckEdit.Checked = True
                    .inventoryCustomerCheckEdit.Enabled = True
                    .inventoryCurrentInventoryCheckEdit.Checked = False
                    .inventoryCurrentInventoryCheckEdit.Enabled = False
                    .inventoryAvailabilityCheckEdit.Checked = True
                    .inventoryAvailabilityCheckEdit.Enabled = True
                    .inventoryAdjustmentReasonCheckEdit.Checked = False
                    .inventoryAdjustmentReasonCheckEdit.Enabled = False
                    .inventoryAdjustmentCheckEdit.Checked = False
                    .inventoryAdjustmentCheckEdit.Enabled = False
                    .RMItemCodeCheckEdit.Checked = True
                    .RMItemCodeCheckEdit.Enabled = True
                    .RMItemDescriptionCheckEdit.Checked = True
                    .RMItemDescriptionCheckEdit.Enabled = True
                    .UOMCheckEdit.Enabled = False
                    .UOMCheckEdit.Checked = False

                Case "ItemsListXtraReport"
                    Dim lShouldReturn As Boolean
                    CheckPermissions(lShouldReturn, "General", .OnlyAssigned)
                    If lShouldReturn Then
                        Return
                    End If
                    .reportColumnsXtraTabControl.SelectedTabPage = .itemsXtraTabPage
                    .itemsAdjustedCheckEdit.Checked = False
                    .itemsAdjustedCheckEdit.Enabled = False
                    .itemsCasesPerPalletCheckEdit.Checked = True
                    .itemsCasesPerPalletCheckEdit.Enabled = True
                    .itemsCustomerCheckEdit.Checked = True
                    .itemsCustomerCheckEdit.Enabled = True
                    .itemsItemCheckEdit.Checked = True
                    .itemsItemCheckEdit.Enabled = True
                    .itemsItemDescriptionCheckEdit.Checked = True
                    .itemsItemDescriptionCheckEdit.Enabled = True
                    .itemsItemTypeCheckEdit.Checked = True
                    .itemsItemTypeCheckEdit.Enabled = True
                    .itemsProducedCheckEdit.Checked = False
                    .itemsProducedCheckEdit.Enabled = False
                    .itemsQtyPerUnitCheckEdit.Checked = True
                    .itemsQtyPerUnitCheckEdit.Enabled = True
                    .itemsReceivedCheckEdit.Checked = False
                    .itemsReceivedCheckEdit.Enabled = False
                    .itemsShippedCheckEdit.Checked = False
                    .itemsShippedCheckEdit.Enabled = False
                    .itemsUnitsOfMeasureCheckEdit.Checked = True
                    .itemsUnitsOfMeasureCheckEdit.Enabled = True
                    .itemsUnitsPerCaseCheckEdit.Checked = True
                    .itemsUnitsPerCaseCheckEdit.Enabled = True
                    .itemUsedInProductionCheckEdit.Checked = False
                    .itemUsedInProductionCheckEdit.Enabled = False

                Case "PalletTransactionXtraReport"
                    Dim lShouldReturn As Boolean
                    CheckPermissions(lShouldReturn, "General", .OnlyAssigned)
                    If lShouldReturn Then
                        Return
                    End If
                    .reportColumnsXtraTabControl.SelectedTabPage = .palletTransactionXtraTabPage

                Case "ItemsTransactionsXtraReport"
                    'Dim lShouldReturn As Boolean
                    'CheckPermissions(lShouldReturn, "General", .OnlyAssigned)
                    'If lShouldReturn Then
                    '    Return
                    'End If
                    MessageBox.Show("This report has been replaced with the Item Transaction Summary report.")
                    Return

                Case "ItemTransactionSummaryXtraReport"
                    Dim lShouldReturn As Boolean
                    CheckPermissions(lShouldReturn, "General", .OnlyAssigned)
                    If lShouldReturn Then
                        Return
                    End If
                    .reportColumnsXtraTabControl.SelectedTabPage = .itemsXtraTabPage
                    .itemsAdjustedCheckEdit.Checked = True
                    .itemsAdjustedCheckEdit.Enabled = True
                    .itemsCasesPerPalletCheckEdit.Checked = False
                    .itemsCasesPerPalletCheckEdit.Enabled = False
                    .itemsCustomerCheckEdit.Checked = True
                    .itemsCustomerCheckEdit.Enabled = True
                    .itemsItemCheckEdit.Checked = True
                    .itemsItemCheckEdit.Enabled = True
                    .itemsItemDescriptionCheckEdit.Checked = True
                    .itemsItemDescriptionCheckEdit.Enabled = True
                    .itemsItemTypeCheckEdit.Checked = True
                    .itemsItemTypeCheckEdit.Enabled = True
                    .itemsProducedCheckEdit.Checked = True
                    .itemsProducedCheckEdit.Enabled = True
                    .itemsQtyPerUnitCheckEdit.Checked = False
                    .itemsQtyPerUnitCheckEdit.Enabled = False
                    .itemsReceivedCheckEdit.Checked = True
                    .itemsReceivedCheckEdit.Enabled = True
                    .itemsShippedCheckEdit.Checked = True
                    .itemsShippedCheckEdit.Enabled = True
                    .itemsUnitsOfMeasureCheckEdit.Checked = False
                    .itemsUnitsOfMeasureCheckEdit.Enabled = False
                    .itemsUnitsPerCaseCheckEdit.Checked = False
                    .itemsUnitsPerCaseCheckEdit.Enabled = False
                    .itemUsedInProductionCheckEdit.Checked = True
                    .itemUsedInProductionCheckEdit.Enabled = True

                Case "PalletControlXtraReport"
                    Dim lShouldReturn As Boolean
                    CheckPermissions(lShouldReturn, "General", .OnlyAssigned)
                    If lShouldReturn Then
                        Return
                    End If

                Case "AuditTrailXtraReport"
                    If String.Compare(My.Settings.UserName, "Admin", True) <> 0 Then
                        MessageBox.Show("Only Admin has permission to view the Audit Trail Report")
                        Exit Sub
                    End If

            End Select

            .Show()
            .SelectedReport(reportCodeName)

            .Cursor = Cursors.Default
        End With

    End Sub

    Private Sub PreviewReport()

        Me.Cursor = Cursors.WaitCursor
        SetColumnFieldNames()
        DisplayReportColumns()

        Select Case m_CurrentReport
            Case "CustomerListXtraReport"
                Dim lShouldReturn, onlyAssigned As Boolean
                CheckPermissions(lShouldReturn, "General", onlyAssigned)
                If lShouldReturn Then
                    previewGridControl.DataSource = Nothing
                    Exit Sub
                ElseIf onlyAssigned Then
                    previewGridControl.DataSource = New XPCollection(Of Customers)(New InOperator(Customers.Fields.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(XpoDefault.Session)))
                Else
                    previewGridControl.DataSource = New XPCollection(Of Customers)()
                End If
                previewCustoemrsXtraTabPage.PageVisible = True
                reportsXtraTabControl.SelectedTabPage = previewCustoemrsXtraTabPage
                previewGridControl.Text = "Cusotmer List"
            Case "ProductionEntriesXtraReport"
                Dim lShouldReturn, onlyAssigned As Boolean
                CheckPermissions(lShouldReturn, "General", onlyAssigned)
                If lShouldReturn Then
                    previewProductionEntriesGridControl.DataSource = Nothing
                    Exit Sub
                Else
                    previewProductionEntriesGridControl.DataSource = ProductionEntriesReportBLL.GetProductionEntriesReportView(onlyAssigned)
                End If
                previewProductionEntriesXtraTabPage.PageVisible = True
                reportsXtraTabControl.SelectedTabPage = previewProductionEntriesXtraTabPage
                previewProductionEntriesGridControl.Text = "Production Entries"
            Case "LpnStatusXtraReport"
                Dim lShouldReturn, onlyAssigned As Boolean
                CheckPermissions(lShouldReturn, "General", onlyAssigned)
                If lShouldReturn Then
                    previewLpnStatusGridControl.DataSource = Nothing
                    Exit Sub
                Else
                    previewLpnStatusGridControl.DataSource = LPNStatusReportBLL.GetLpnStatusrReportView(onlyAssigned)
                End If
                previewLpnStatusXtraTabPage.PageVisible = True
                reportsXtraTabControl.SelectedTabPage = previewLpnStatusXtraTabPage
                previewLpnStatusGridControl.Text = "LPN Status"
            Case "CurrentRMInventoryXtraReport"
                Dim lShouldReturn, onlyAssigned As Boolean
                CheckPermissions(lShouldReturn, "General", onlyAssigned)
                If lShouldReturn Then
                    previewCurrentRMInventoryGridControl.DataSource = Nothing
                    Exit Sub
                Else
                    previewCurrentRMInventoryGridControl.DataSource = CurrentRMInventoryReport.GetCurrentRmInventoryReport(onlyAssigned)
                End If
                previewCurrentRMInventoryXtraTabPage.PageVisible = True
                reportsXtraTabControl.SelectedTabPage = previewCurrentRMInventoryXtraTabPage
                previewCurrentRMInventoryGridControl.Text = "Current RM Inventory"
            Case "CurrentInventoryXtraReport"
                Dim lShouldReturn, onlyAssigned As Boolean
                CheckPermissions(lShouldReturn, "General", onlyAssigned)
                If lShouldReturn Then
                    previewCurrentInventoryGridControl.DataSource = Nothing
                    Exit Sub
                Else
                    previewCurrentInventoryGridControl.DataSource = CurrentInventoryReportBLL.GetCurrentInventoryReport(Nothing, Nothing, Nothing, currentInventoryInactiveItemsCheckEdit.Checked, currentInventoryInactiveCustomersCheckEdit.Checked,
                                                                                                                        outOfStockItemsCheckEdit.Checked, onlyAssigned, Nothing)
                End If
                previewCurrentInventoryXtraTabPage.PageVisible = True
                reportsXtraTabControl.SelectedTabPage = previewCurrentInventoryXtraTabPage
                previewCurrentInventoryGridControl.Text = "Current Inventory"
            Case "LocationTransfersXtraReport"
                Dim lShouldReturn, onlyAssigned As Boolean
                CheckPermissions(lShouldReturn, "General", onlyAssigned)
                If lShouldReturn Then
                    previewLocationTransfersGridControl.DataSource = Nothing
                    Exit Sub
                Else
                    previewLocationTransfersGridControl.DataSource = LocationTransfersReportBLL.GetLocationTransfersReportView(onlyAssigned)
                End If
                previewLocationTransfersXtraTabPage.PageVisible = True
                reportsXtraTabControl.SelectedTabPage = previewLocationTransfersXtraTabPage
                previewLocationTransfersGridControl.Text = "Location Transfers"
            Case "ShiftScheduleXtraReport"
                Dim lShouldRetun As Boolean
                CheckPermissions(lShouldRetun, "General", False)
                If lShouldRetun Then
                    shiftScheduleGridControl.DataSource = Nothing
                    Exit Sub
                End If
                If Utilities.ChangeType(Of Date?)(shiftScheduleDateDateEdit.EditValue).HasValue = False OrElse CDate(shiftScheduleDateDateEdit.EditValue) = Date.MinValue Then
                    shiftScheduleDateDateEdit.EditValue = Today
                End If
                'If String.IsNullOrEmpty(CStr(shiftScheduleShiftComboBoxEdit.EditValue)) Then
                '    shiftScheduleShiftComboBoxEdit.EditValue = "Shift 1"
                'End If
                shiftScheduleGridControl.DataSource = ShiftScheduleReportBLL.GetShiftScheduleReport(Utilities.ChangeType(Of Date?)(shiftScheduleDateDateEdit.EditValue), CStr(shiftScheduleShiftComboBoxEdit.EditValue))
                previewShiftScheduleXtraTabPage.PageVisible = True
                reportsXtraTabControl.SelectedTabPage = previewShiftScheduleXtraTabPage
                shiftScheduleGridControl.Text = String.Format("{0} - {1}", CDate(shiftScheduleDateDateEdit.EditValue).ToLongDateString, shiftScheduleShiftComboBoxEdit.Text)
            Case "WeeklyProductionXtraReport"
                Dim lShouldRetun As Boolean
                CheckPermissions(lShouldRetun, "General", False)
                If lShouldRetun Then
                    weeklyProductionGridControl.DataSource = Nothing
                    Exit Sub
                End If
                weeklyProductionGridControl.DataSource = New WeeklyProductionReportBLL().GetWeeklyProductionReport(m_Project)
                previewWeeklyProductionXtraTabPage.PageVisible = True
                reportsXtraTabControl.SelectedTabPage = previewWeeklyProductionXtraTabPage
                weeklyProductionGridControl.Text = String.Format("Production for scheduled week of {0}", m_ProductionWeek)
            Case "ProjBomAvailXtraReport"
                Dim lShouldRetun As Boolean
                CheckPermissions(lShouldRetun, "General", False)
                If lShouldRetun Then
                    ProjBomAvailGridControl.DataSource = Nothing
                    Exit Sub
                End If
                ProjBomAvailGridControl.DataSource = BomAvailabilityReportBLL.GetBomAvailabilityDetail(m_Project)
                previewProjBomAvailXtraTabPage.Text = "Preview Project Bom Availability"
                previewProjBomAvailXtraTabPage.PageVisible = True
                reportsXtraTabControl.SelectedTabPage = previewProjBomAvailXtraTabPage
                ProjBomAvailGridControl.Text = String.Format("{0} Bom Availability", m_Project.Project)
            Case "BomDemandSummaryXtraReport"
                Dim lShouldRetun As Boolean
                CheckPermissions(lShouldRetun, "General", False)
                If lShouldRetun Then
                    ProjBomAvailGridControl.DataSource = Nothing
                    Exit Sub
                End If
                ProjBomAvailGridControl.DataSource = BomAvailabilityReportBLL.GetDemandSummary(XpoDefault.Session)
                previewProjBomAvailXtraTabPage.Text = "Preview Bom Demand Summary"
                previewProjBomAvailXtraTabPage.PageVisible = True
                reportsXtraTabControl.SelectedTabPage = previewProjBomAvailXtraTabPage
                ProjBomAvailGridControl.Text = "Bom Demand Summary"
            Case "ProductionBillingXtraReport"
                Dim lShouldReturn, onlyAssigned As Boolean
                CheckPermissions(lShouldReturn, "Financial", onlyAssigned)
                If lShouldReturn Then
                    previewProductionBillingGridControl.DataSource = Nothing
                    Exit Sub
                End If
                previewProductionBillingGridControl.DataSource = ProductionBillingReportBLL.GetProductionBillingReportView(onlyAssigned)
                previewProductionBillingXtraTabPage.PageVisible = True
                reportsXtraTabControl.SelectedTabPage = previewProductionBillingXtraTabPage
                previewProductionBillingGridControl.Text = "Production Billing"
            Case "BaggingXtraReport"
                Dim lShouldReturn As Boolean
                CheckPermissions(lShouldReturn, "General", False)
                If lShouldReturn Then
                    baggingReportPivotGridControl.DataSource = Nothing
                    Exit Sub
                End If
                baggingReportPivotGridControl.DataSource = baggingReportXpView
                baggingReportPivotGridControl.Prefilter.Criteria = New GroupOperator(GroupOperatorType.And, New BinaryOperator("ProductionDate", DateAdd(DateInterval.Day, -14, Today), BinaryOperatorType.GreaterOrEqual),
                                                                                     New BinaryOperator("ProductionDate", DateAdd(DateInterval.Day, 1, Today), BinaryOperatorType.LessOrEqual))
                previewBaggingXtraTabPage.PageVisible = True
                reportsXtraTabControl.SelectedTabPage = previewBaggingXtraTabPage
                baggingReportPivotGridControl.Text = "Bagging"
        End Select

        Me.Cursor = Cursors.Default

    End Sub

    Private Shared Sub CheckPermissions(ByRef shouldReturn As Boolean, ByVal reportType As String, ByRef onlyAssigned As Boolean)

        shouldReturn = False
        onlyAssigned = False
        If reportType = "General" Then
            If MainXtraForm.GeneralReports = "NONE" Then
                MessageBox.Show("You don't have permission to view General Reports")
                shouldReturn = True
            ElseIf MainXtraForm.GeneralReports Like "*ASSIGNED" Then
                onlyAssigned = True
            End If
        Else
            If MainXtraForm.FinancialReports = "NONE" Then
                MessageBox.Show("You don't have permission to view Financial Reports")
                shouldReturn = True
                Exit Sub
            ElseIf MainXtraForm.FinancialReports Like "*ASSIGNED" Then
                onlyAssigned = True
            End If
        End If

    End Sub

    Private Sub SetColumnFieldNames()

        Select Case m_CurrentReport
            Case "CustomerListXtraReport"
                nameGridColumn.FieldName = "CustomerName"
                contactNameGridColumn.FieldName = "CustomerContact"
                Me.addressGridColumn.FieldName = "Address"
                Me.cityGridColumn.FieldName = "City"
                Me.stateGridColumn.FieldName = "State"
                Me.postalGridColumn.FieldName = "ZipCode"
                Me.phoneGridColumn.FieldName = "CustomerPhone"
                Me.faxGridColumn.FieldName = "CustomerFax"
                Me.emailGridColumn.FieldName = "CustomerEmail"
                Me.inactiveGridColumn.FieldName = "Inactive"
            Case "ProductionEntriesXtraReport"
                productionDateGridColumn.FieldName = "Production Date"
                customerNameGridColumn.FieldName = "Customer Name"
                itemNumberGridColumn.FieldName = "Item #"
                itemDescriptionGridColumn.FieldName = "Item Description"
                itemTypeGridColumn.FieldName = "Item Type"
                shiftGridColumn.FieldName = "Shift"
                quantityGridColumn.FieldName = "Quantity"
                poGridColumn.FieldName = "PO #"
                lotGridColumn.FieldName = "Lot #"
                palletNumberGridColumn.FieldName = "Pallet #"
                lpnNumberGridColumn.FieldName = "LPN #"
                expirationDateGridColumn.FieldName = "Expiration Date"
                expirationDateFormatGridColumn.FieldName = "ExpirationDateFormat"
                noteGridColumn.FieldName = "Note"
            Case "LpnStatusXtraReport"
                lpnCustomerNameGridColumn.FieldName = "Customer Name"
                fullLpnGridColumn.FieldName = "Full LPN Number"
                lpnItemCodeGridColumn.FieldName = "Item #"
                'lpnItemDescriptionGridColumn.FieldName = "Item Description"
                lpnQuantityGridColumn.FieldName = "Quantity"
                lpnProductionDateGridColumn.FieldName = "Production Date"
                lpnShippingDateGridColumn.FieldName = "Shipping Date"
                lpnShippingBolGridColumn.FieldName = "BOL #"
            Case "CurrentRMInventoryXtraReport"
                rmInventoryCustomerNameGridColumn.FieldName = "Customer.CustomerName"
                rmInventoryIemCodeGridColumn.FieldName = "ItemCode"
                rmInventoryItemDescriptionGridColumn.FieldName = "ItemDescription"
                rmInventoryQtyOnHandGridColumn.FieldName = "QuantityOnHand"
                rmInventoryInactiveGridColumn.FieldName = "Inactive"
                rmInventoryItemIDGridColumn.FieldName = "ItemId"
                rmInventoryLocationGridColumn.FieldName = "Location"
            Case "CurrentInventoryXtraReport"
                currentInventoryCustomerNameGridColumn.FieldName = "CustomerName"
                currentInventoryItemCodeGridColumn.FieldName = "ItemCode"
                currentInventoryItemDescriptionGridColumn.FieldName = "ItemDescription"
                currentInventoryItemTypeGridColumn.FieldName = "ItemType"
                currentInventoryQuantityOnHandGridColumn.FieldName = "QuantityOnHand"
                currentInventoryInventoryByPalletsGridColumn.FieldName = "InventoryByPallets"
                currentInventoryUOMGridColumn.FieldName = "UOM"
                currentInventoryLocationGridColumn.FieldName = "Location"
            Case "LocationTransfersXtraReport"
                locationTransfersDateGridColumn.FieldName = "TransferDate"
                locationTransferFromLocationGridColumn.FieldName = "FromLocation"
                locationTransferToLocationGridColumn.FieldName = "ToLocation"
                locationTransferItemCodeGridColumn.FieldName = "ItemCode"
                locationTransferItemDescriptionGridColumn.FieldName = "ItemDescription"
                locationTransferNumberGridColumn.FieldName = "TransferNumber"
                locationTransferItemLotGridColumn.FieldName = "ItemLot"
                locationTransferExpirationDateGridColumn.FieldName = "ExpirationDate"
                locationTransferQuantityGridColumn.FieldName = "TransferQuantity"
                locationTransferExpirationDateFormatGridColumn.FieldName = "ExpirationDateFormat"
                locationTransferUnitsGridColumn.FieldName = "TransferUnits"
                locationTransferPalletsGridColumn.FieldName = "TransferPallets"
                locationTransferCarrierGridColumn.FieldName = "Carrier"
            Case "ShiftScheduleXtraReport"
                shiftScheduleMachineNameGridColumn.FieldName = "MachineLineName"
                shiftSchedulePeopleGridColumn.FieldName = "People"
                shiftScheduleOperatorGridColumn.FieldName = "Operator"
                shiftScheduleItemCodeGridColumn.FieldName = "ItemCode"
                shiftScheduleItemDescriptionGridColumn.FieldName = "ItemDescription"
                shiftScheduleQuantityGridColumn.FieldName = "Quantity"
                shiftScheduleSchedByQtyGridColumn.FieldName = "ShedByQty"
                shiftScheduleNoteGridColumn.FieldName = "ShceduleNote"
                shiftScheduleMustRunGridColumn.FieldName = "MustRun"
                shiftSchedulePriorityLevelGridColumn.FieldName = "PriorityLevel"
            Case "WeeklyProductionXtraReport"
                weeklyProductionItemCodeGridColumn.FieldName = "ItemCode"
                weeklyProductionItemDescriptionGridColumn.FieldName = "ItemDescription"
                weeklyProductionCasesRequiredGridColumn.FieldName = "RequiredCases"
                weeklyProductionBagsRequiredGridColumn.FieldName = "RequiredBags"
                weeklyProductionMondayGridColumn.FieldName = "ProducedMonday"
                weeklyProductionTuesdayGridColumn.FieldName = "ProducedTuesday"
                weeklyProductionWednesdayGridColumn.FieldName = "ProducedWednesday"
                weeklyProductionThursdayGridColumn.FieldName = "ProducedThursday"
                weeklyProductionFridayGridColumn.FieldName = "ProducedFriday"
                weeklyProductionSaturdayGridColumn.FieldName = "ProducedSaturday"
                weeklyProductionSundayGridColumn.FieldName = "ProducedSunday"
                weeklyProductionTotalProducedWeeklyGridColumn.FieldName = "TotalProducedWeek"
                weeklyProductionTotalProducedGridColumn.FieldName = "TotalProduced"
                weeklyProductionPercentageCompleteGridColumn.FieldName = "PercentageComplete"
                weeklyProductionProductionWeekGridColumn.FieldName = "ProductionWeek"
            Case "ProjBomAvailXtraReport"
                ProjBomAvailCustPOGridColumn.FieldName = "CustomerPO"
                ProjBomAvailItemCodeGridColumn.FieldName = "ItemCode"
                ProjBomAvailItemDescriptionGridColumn.FieldName = "ItemDescription"
                ProjBomAvailItemTypeGridColumn.FieldName = "ItemType"
                ProjBomAvailLocalQtyGridColumn.FieldName = "QuantityOnHand"
                ProjBomLocalShortageGridColumn.FieldName = "BomDemandShortage"
            Case "BomDemandSummaryXtraReport"
                ProjBomAvailItemCodeGridColumn.FieldName = "ItemCode"
                ProjBomAvailItemDescriptionGridColumn.FieldName = "ItemDescription"
                ProjBomAvailItemTypeGridColumn.FieldName = "ItemType"
                ProjBomAvailLocalQtyGridColumn.FieldName = "LocalQuantityOnHand"
                ProjBomAvailQtyOnHndGridColumn.FieldName = "QuantityOnHand"
                ProjBomAvailNonLocalQtyGridColumn.FieldName = "NonLocalQuantityOnHand"
                ProjBomAvailQtyShortageGridColumn.FieldName = "TotalBomDemandShortage"
                ProjBomAvailTotalAmtNeededGridColumn.FieldName = "TotalBomDemand"
                ProjBomLocalShortageGridColumn.FieldName = "BomDemandLocalShortage"
                ProjBomAvailNonLocalPalletsQtyGridColumn.FieldName = "NonLocalPalletsQuantityOnHand"
            Case "ProductionBillingXtraReport"
                productionBillingDateGridColumn.FieldName = "Production Date"
                productionBillingCustomerGridColumn.FieldName = "Customer Name"
                productionBillingItemCodeGridColumn.FieldName = "Item #"
                productionBillingItemDescriptionGridColumn.FieldName = "Item Description"
                productionBillingItemTypeGridColumn.FieldName = "Item Type"
                productionBillingShiftGridColumn.FieldName = "Shift"
                productionBillingQuantityGridColumn.FieldName = "Quantity"
                productionBillingPOGridColumn.FieldName = "PO #"
                productionBillingUOMGridColumn.FieldName = "UOM"
                productionBillingCasesGridColumn.FieldName = "Cases"
                productionBillingPriceGridColumn.FieldName = "Price"
        End Select

    End Sub

    Private Sub DisplayReportColumns()

        Select Case m_CurrentReport
            Case "CustomerListXtraReport"
                Me.nameGridColumn.Visible = True
                Me.contactNameGridColumn.Visible = True
                Me.addressGridColumn.Visible = True
                Me.cityGridColumn.Visible = True
                Me.stateGridColumn.Visible = True
                Me.postalGridColumn.Visible = True
                Me.phoneGridColumn.Visible = True
                Me.faxGridColumn.Visible = True
                Me.emailGridColumn.Visible = True
                Me.inactiveGridColumn.Visible = True

                Me.nameGridColumn.OptionsColumn.ShowInCustomizationForm = True
                Me.contactNameGridColumn.OptionsColumn.ShowInCustomizationForm = True
                Me.addressGridColumn.OptionsColumn.ShowInCustomizationForm = True
                Me.cityGridColumn.OptionsColumn.ShowInCustomizationForm = True
                Me.stateGridColumn.OptionsColumn.ShowInCustomizationForm = True
                Me.postalGridColumn.OptionsColumn.ShowInCustomizationForm = True
                Me.phoneGridColumn.OptionsColumn.ShowInCustomizationForm = True
                Me.faxGridColumn.OptionsColumn.ShowInCustomizationForm = True
                Me.emailGridColumn.OptionsColumn.ShowInCustomizationForm = True
                Me.inactiveGridColumn.OptionsColumn.ShowInCustomizationForm = True

                Me.inactiveGridColumn.FilterInfo = New ColumnFilterInfo(inactiveGridColumn, False)

                previewGridView.BestFitColumns()
            Case "ProductionEntriesXtraReport"
                productionDateGridColumn.Visible = True
                customerNameGridColumn.Visible = True
                itemNumberGridColumn.Visible = True
                itemDescriptionGridColumn.Visible = True
                itemTypeGridColumn.Visible = True
                shiftGridColumn.Visible = True
                quantityGridColumn.Visible = True
                poGridColumn.Visible = True
                lotGridColumn.Visible = True
                palletNumberGridColumn.Visible = True
                lpnNumberGridColumn.Visible = True
                expirationDateGridColumn.Visible = True
                noteGridColumn.Visible = True

                productionDateGridColumn.OptionsColumn.ShowInCustomizationForm = True
                customerNameGridColumn.OptionsColumn.ShowInCustomizationForm = True
                itemNumberGridColumn.OptionsColumn.ShowInCustomizationForm = True
                itemDescriptionGridColumn.OptionsColumn.ShowInCustomizationForm = True
                itemTypeGridColumn.OptionsColumn.ShowInCustomizationForm = True
                shiftGridColumn.OptionsColumn.ShowInCustomizationForm = True
                quantityGridColumn.OptionsColumn.ShowInCustomizationForm = True
                poGridColumn.OptionsColumn.ShowInCustomizationForm = True
                lotGridColumn.OptionsColumn.ShowInCustomizationForm = True
                palletNumberGridColumn.OptionsColumn.ShowInCustomizationForm = True
                lpnNumberGridColumn.OptionsColumn.ShowInCustomizationForm = True
                expirationDateGridColumn.OptionsColumn.ShowInCustomizationForm = True
                noteGridColumn.OptionsColumn.ShowInCustomizationForm = True

                previewProductionEntriesGridView.BestFitColumns()
            Case "LpnStatusXtraReport"
                lpnCustomerNameGridColumn.Visible = True
                fullLpnGridColumn.Visible = True
                lpnItemCodeGridColumn.Visible = True
                lpnItemDescriptionGridColumn.Visible = False
                lpnQuantityGridColumn.Visible = True
                lpnProductionDateGridColumn.Visible = True
                lpnShippingDateGridColumn.Visible = True
                lpnShippingBolGridColumn.Visible = True

                lpnCustomerNameGridColumn.OptionsColumn.ShowInCustomizationForm = True
                fullLpnGridColumn.OptionsColumn.ShowInCustomizationForm = True
                lpnItemCodeGridColumn.OptionsColumn.ShowInCustomizationForm = True
                lpnItemDescriptionGridColumn.OptionsColumn.ShowInCustomizationForm = False
                lpnQuantityGridColumn.OptionsColumn.ShowInCustomizationForm = True
                lpnProductionDateGridColumn.OptionsColumn.ShowInCustomizationForm = True
                lpnShippingDateGridColumn.OptionsColumn.ShowInCustomizationForm = True
                lpnShippingBolGridColumn.OptionsColumn.ShowInCustomizationForm = True

                previewLpnStatusGridView.BestFitColumns()
            Case "CurrentRMInventoryXtraReport"
                rmInventoryCustomerNameGridColumn.Visible = True
                rmInventoryIemCodeGridColumn.Visible = True
                rmInventoryItemDescriptionGridColumn.Visible = True
                rmInventoryQtyOnHandGridColumn.Visible = True
                rmInventoryInactiveGridColumn.Visible = False
                rmInventoryItemIDGridColumn.Visible = False

                rmInventoryCustomerNameGridColumn.OptionsColumn.ShowInCustomizationForm = True
                rmInventoryIemCodeGridColumn.OptionsColumn.ShowInCustomizationForm = True
                rmInventoryItemDescriptionGridColumn.OptionsColumn.ShowInCustomizationForm = True
                rmInventoryQtyOnHandGridColumn.OptionsColumn.ShowInCustomizationForm = True
                rmInventoryInactiveGridColumn.OptionsColumn.ShowInCustomizationForm = False
                rmInventoryItemIDGridColumn.OptionsColumn.ShowInCustomizationForm = False

                previewCurrentRMInventoryGridView.BestFitColumns()
            Case "CurrentInventoryXtraReport"
                currentInventoryCustomerNameGridColumn.Visible = True
                currentInventoryItemCodeGridColumn.Visible = True
                currentInventoryItemDescriptionGridColumn.Visible = True
                currentInventoryItemTypeGridColumn.Visible = True
                currentInventoryQuantityOnHandGridColumn.Visible = True
                currentInventoryInventoryByPalletsGridColumn.Visible = True
                currentInventoryUOMGridColumn.Visible = True
                currentInventoryLocationGridColumn.Visible = True

                currentInventoryCustomerNameGridColumn.OptionsColumn.ShowInCustomizationForm = True
                currentInventoryItemCodeGridColumn.OptionsColumn.ShowInCustomizationForm = True
                currentInventoryItemDescriptionGridColumn.OptionsColumn.ShowInCustomizationForm = True
                currentInventoryItemTypeGridColumn.OptionsColumn.ShowInCustomizationForm = True
                currentInventoryQuantityOnHandGridColumn.OptionsColumn.ShowInCustomizationForm = True
                currentInventoryInventoryByPalletsGridColumn.OptionsColumn.ShowInCustomizationForm = True
                currentInventoryUOMGridColumn.OptionsColumn.ShowInCustomizationForm = True
                currentInventoryLocationGridColumn.OptionsColumn.ShowInCustomizationForm = True

                previewCurrentInventoryGridView.BestFitColumns()
            Case "LocationTransfersXtraReport"
                locationTransfersDateGridColumn.Visible = True
                locationTransferFromLocationGridColumn.Visible = True
                locationTransferToLocationGridColumn.Visible = True
                locationTransferItemCodeGridColumn.Visible = True
                locationTransferItemDescriptionGridColumn.Visible = True
                locationTransferNumberGridColumn.Visible = True
                locationTransferItemLotGridColumn.Visible = True
                locationTransferExpirationDateGridColumn.Visible = True
                locationTransferQuantityGridColumn.Visible = True
                locationTransferExpirationDateFormatGridColumn.Visible = False
                locationTransferUnitsGridColumn.Visible = True
                locationTransferPalletsGridColumn.Visible = True
                locationTransferCarrierGridColumn.Visible = True

                locationTransfersDateGridColumn.OptionsColumn.ShowInCustomizationForm = True
                locationTransferFromLocationGridColumn.OptionsColumn.ShowInCustomizationForm = True
                locationTransferToLocationGridColumn.OptionsColumn.ShowInCustomizationForm = True
                locationTransferItemCodeGridColumn.OptionsColumn.ShowInCustomizationForm = True
                locationTransferItemDescriptionGridColumn.OptionsColumn.ShowInCustomizationForm = True
                locationTransferNumberGridColumn.OptionsColumn.ShowInCustomizationForm = True
                locationTransferItemLotGridColumn.OptionsColumn.ShowInCustomizationForm = True
                locationTransferExpirationDateGridColumn.OptionsColumn.ShowInCustomizationForm = True
                locationTransferQuantityGridColumn.OptionsColumn.ShowInCustomizationForm = True
                locationTransferExpirationDateFormatGridColumn.OptionsColumn.ShowInCustomizationForm = False
                locationTransferUnitsGridColumn.OptionsColumn.ShowInCustomizationForm = True
                locationTransferPalletsGridColumn.OptionsColumn.ShowInCustomizationForm = True
                locationTransferCarrierGridColumn.OptionsColumn.ShowInCustomizationForm = True

                previewLocationTransfersGridView.BestFitColumns()
            Case "ShiftScheduleXtraReport"
                shiftScheduleMachineNameGridColumn.Visible = True
                shiftSchedulePeopleGridColumn.Visible = True
                shiftScheduleOperatorGridColumn.Visible = True
                shiftScheduleItemCodeGridColumn.Visible = True
                shiftScheduleItemDescriptionGridColumn.Visible = True
                shiftScheduleQuantityGridColumn.Visible = True
                shiftScheduleSchedByQtyGridColumn.Visible = True
                shiftScheduleNoteGridColumn.Visible = True
                shiftScheduleMustRunGridColumn.Visible = True
                shiftSchedulePriorityLevelGridColumn.Visible = True

                shiftScheduleGridView.BestFitColumns()
            Case "WeeklyProductionXtraReport"
                weeklyProductionItemCodeGridColumn.Visible = True
                weeklyProductionItemDescriptionGridColumn.Visible = True
                weeklyProductionCasesRequiredGridColumn.Visible = True
                weeklyProductionBagsRequiredGridColumn.Visible = True
                weeklyProductionMondayGridColumn.Visible = True
                weeklyProductionTuesdayGridColumn.Visible = True
                weeklyProductionWednesdayGridColumn.Visible = True
                weeklyProductionThursdayGridColumn.Visible = True
                weeklyProductionFridayGridColumn.Visible = True
                weeklyProductionSaturdayGridColumn.Visible = True
                weeklyProductionSundayGridColumn.Visible = True
                weeklyProductionTotalProducedGridColumn.Visible = True
                weeklyProductionPercentageCompleteGridColumn.Visible = True
                weeklyProductionProductionWeekGridColumn.Visible = True
                weeklyProductionTotalProducedWeeklyGridColumn.Visible = True

                weeklyProductionGridView.BestFitColumns()
            Case "ProjBomAvailXtraReport"
                ProjBomAvailCustPOGridColumn.Visible = True
                ProjBomAvailItemCodeGridColumn.Visible = True
                ProjBomAvailItemDescriptionGridColumn.Visible = True
                ProjBomAvailItemTypeGridColumn.Visible = True
                ProjBomLocalShortageGridColumn.Visible = True
                ProjBomAvailQtyOnHndGridColumn.Visible = False
                ProjBomAvailLocalQtyGridColumn.Visible = True
                ProjBomAvailNonLocalQtyGridColumn.Visible = False
                ProjBomAvailQtyShortageGridColumn.Visible = False
                ProjBomAvailTotalAmtNeededGridColumn.Visible = False
                ProjBomAvailNonLocalPalletsQtyGridColumn.Visible = False
                neededBy.Visible = False
                lblNededBy.Visible = False

                ProjBomAvailCustPOGridColumn.OptionsColumn.ShowInCustomizationForm = True
                ProjBomAvailItemCodeGridColumn.OptionsColumn.ShowInCustomizationForm = True
                ProjBomAvailItemDescriptionGridColumn.OptionsColumn.ShowInCustomizationForm = True
                ProjBomAvailItemTypeGridColumn.OptionsColumn.ShowInCustomizationForm = True
                ProjBomAvailNonLocalQtyGridColumn.OptionsColumn.ShowInCustomizationForm = False
                ProjBomAvailQtyOnHndGridColumn.OptionsColumn.ShowInCustomizationForm = False
                ProjBomAvailLocalQtyGridColumn.OptionsColumn.ShowInCustomizationForm = True
                ProjBomLocalShortageGridColumn.OptionsColumn.ShowInCustomizationForm = True
                ProjBomAvailQtyShortageGridColumn.OptionsColumn.ShowInCustomizationForm = False
                ProjBomAvailTotalAmtNeededGridColumn.OptionsColumn.ShowInCustomizationForm = False
                ProjBomAvailNonLocalPalletsQtyGridColumn.OptionsColumn.ShowInCustomizationForm = False

                ProjBomAvailGridView.BestFitColumns()
            Case "BomDemandSummaryXtraReport"
                ProjBomAvailCustPOGridColumn.Visible = False
                ProjBomAvailItemCodeGridColumn.Visible = True
                ProjBomAvailItemDescriptionGridColumn.Visible = True
                ProjBomAvailItemTypeGridColumn.Visible = True
                ProjBomAvailLocalQtyGridColumn.Visible = True
                ProjBomAvailQtyOnHndGridColumn.Visible = True
                ProjBomAvailNonLocalQtyGridColumn.Visible = True
                ProjBomAvailQtyShortageGridColumn.Visible = True
                ProjBomAvailTotalAmtNeededGridColumn.Visible = True
                ProjBomLocalShortageGridColumn.Visible = True
                ProjBomAvailNonLocalPalletsQtyGridColumn.Visible = True
                neededBy.Visible = True
                lblNededBy.Visible = True

                ProjBomAvailCustPOGridColumn.OptionsColumn.ShowInCustomizationForm = False
                ProjBomAvailItemCodeGridColumn.OptionsColumn.ShowInCustomizationForm = True
                ProjBomAvailItemDescriptionGridColumn.OptionsColumn.ShowInCustomizationForm = True
                ProjBomAvailItemTypeGridColumn.OptionsColumn.ShowInCustomizationForm = True
                ProjBomLocalShortageGridColumn.OptionsColumn.ShowInCustomizationForm = True
                ProjBomAvailQtyOnHndGridColumn.OptionsColumn.ShowInCustomizationForm = True
                ProjBomAvailNonLocalQtyGridColumn.OptionsColumn.ShowInCustomizationForm = True
                ProjBomAvailLocalQtyGridColumn.OptionsColumn.ShowInCustomizationForm = False
                ProjBomAvailQtyShortageGridColumn.OptionsColumn.ShowInCustomizationForm = True
                ProjBomAvailTotalAmtNeededGridColumn.OptionsColumn.ShowInCustomizationForm = True
                ProjBomAvailNonLocalPalletsQtyGridColumn.OptionsColumn.ShowInCustomizationForm = True

                ProjBomAvailGridView.BestFitColumns()
            Case "ProductionBillingXtraReport"
                productionBillingDateGridColumn.Visible = True
                productionBillingCustomerGridColumn.Visible = True
                productionBillingItemCodeGridColumn.Visible = True
                productionBillingItemDescriptionGridColumn.Visible = True
                productionBillingItemTypeGridColumn.Visible = True
                productionBillingShiftGridColumn.Visible = True
                productionBillingQuantityGridColumn.Visible = True
                productionBillingPOGridColumn.Visible = True
                productionBillingUOMGridColumn.Visible = True
                productionBillingCasesGridColumn.Visible = True
                productionBillingPriceGridColumn.Visible = True

                productionBillingDateGridColumn.OptionsColumn.ShowInCustomizationForm = True
                productionBillingCustomerGridColumn.OptionsColumn.ShowInCustomizationForm = True
                productionBillingItemCodeGridColumn.OptionsColumn.ShowInCustomizationForm = True
                productionBillingItemDescriptionGridColumn.OptionsColumn.ShowInCustomizationForm = True
                productionBillingItemTypeGridColumn.OptionsColumn.ShowInCustomizationForm = True
                productionBillingShiftGridColumn.OptionsColumn.ShowInCustomizationForm = True
                productionBillingQuantityGridColumn.OptionsColumn.ShowInCustomizationForm = True
                productionBillingPOGridColumn.OptionsColumn.ShowInCustomizationForm = True
                productionBillingUOMGridColumn.OptionsColumn.ShowInCustomizationForm = True
                productionBillingCasesGridColumn.OptionsColumn.ShowInCustomizationForm = True
                productionBillingPriceGridColumn.OptionsColumn.ShowInCustomizationForm = True

                previewProductionBillingGridView.BestFitColumns()
            Case "BaggingXtraReport"
                baggingReportPivotGridControl.BestFit()

        End Select

    End Sub

    Private Sub reportsXtraTabControl_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles reportsXtraTabControl.SelectedPageChanged

        Me.printBarButtonItem.Enabled = (e.Page.Name <> filterXtraTabPage.Name)

    End Sub

    Private Sub printBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles printBarButtonItem.ItemClick

        Dim pcl As New PrintableComponentLink(New PrintingSystem())
        AddHandler pcl.CreateReportHeaderArea, AddressOf PrintableComponentLink_CreateReportHeaderArea
        Select Case m_CurrentReport
            Case "CustomerListXtraReport"
                pcl.Component = previewGridControl
                If previewGridView.VisibleColumns.Count > 5 Then
                    pcl.Landscape = True
                    pcl.CreateDocument()
                End If
            Case "ProductionEntriesXtraReport"
                pcl.Component = previewProductionEntriesGridControl
                If previewProductionEntriesGridView.VisibleColumns.Count > 5 Then
                    pcl.Landscape = True
                    pcl.CreateDocument()
                End If
            Case "LpnStatusXtraReport"
                pcl.Component = previewLpnStatusGridControl
                If previewLpnStatusGridView.VisibleColumns.Count > 5 Then
                    pcl.Landscape = True
                    pcl.CreateDocument()
                End If
            Case "CurrentRMInventoryXtraReport"
                pcl.Component = previewCurrentRMInventoryGridControl
                If previewCurrentRMInventoryGridView.VisibleColumns.Count > 5 Then
                    pcl.Landscape = True
                    pcl.CreateDocument()
                End If
            Case "CurrentInventoryXtraReport"
                pcl.Component = previewCurrentInventoryGridControl
                If previewCurrentInventoryGridView.VisibleColumns.Count > 5 Then
                    pcl.Landscape = True
                    pcl.CreateDocument()
                End If
            Case "LocationTransfersXtraReport"
                pcl.Component = previewLocationTransfersGridControl
                If previewLocationTransfersGridView.VisibleColumns.Count > 5 Then
                    pcl.Landscape = True
                    pcl.CreateDocument()
                End If
            Case "ShiftScheduleXtraReport"
                pcl.Component = shiftScheduleGridControl
                If shiftScheduleGridView.VisibleColumns.Count > 5 Then
                    pcl.Landscape = True
                    pcl.CreateDocument()
                End If
            Case "WeeklyProductionXtraReport"
                pcl.Component = weeklyProductionGridControl
                If weeklyProductionGridView.VisibleColumns.Count > 5 Then
                    pcl.Landscape = True
                    pcl.CreateDocument()
                End If
            Case "ProjBomAvailXtraReport"
                pcl.Component = ProjBomAvailGridControl
                If ProjBomAvailGridView.VisibleColumns.Count > 5 Then
                    pcl.Landscape = True
                    pcl.CreateDocument()
                End If
            Case "BomDemandSummaryXtraReport"
                pcl.Component = ProjBomAvailGridControl
                If ProjBomAvailGridView.VisibleColumns.Count > 5 Then
                    pcl.Landscape = True
                    pcl.CreateDocument()
                End If
            Case "ProductionBillingXtraReport"
                pcl.Component = previewProductionBillingGridControl
                If previewProductionBillingGridView.VisibleColumns.Count > 5 Then
                    pcl.Landscape = True
                    pcl.CreateDocument()
                End If
            Case "BaggingXtraReport"
                pcl.Component = baggingReportPivotGridControl
                pcl.Landscape = True
                pcl.CreateDocument()
        End Select

        pcl.ShowPreviewDialog()

    End Sub

    Private Sub PrintableComponentLink_CreateReportHeaderArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)

        Dim brick As TextBrick = Nothing
        Select Case m_CurrentReport
            Case "CustomerListXtraReport"
                brick = e.Graph.DrawString(previewGridControl.Text, Color.Black, New RectangleF(0, 5, 650, 25), BorderSide.None)
            Case "ProductionEntriesXtraReport"
                brick = e.Graph.DrawString(previewProductionEntriesGridControl.Text, Color.Black, New RectangleF(0, 5, 650, 25), BorderSide.None)
            Case "LpnStatusXtraReport"
                brick = e.Graph.DrawString(previewLpnStatusGridControl.Text, Color.Black, New RectangleF(0, 5, 650, 25), BorderSide.None)
            Case "CurrentRMInventoryXtraReport"
                brick = e.Graph.DrawString(previewCurrentRMInventoryGridControl.Text, Color.Black, New Rectangle(0, 5, 650, 25), BorderSide.None)
            Case "CurrentInventoryXtraReport"
                brick = e.Graph.DrawString(previewCurrentInventoryGridControl.Text, Color.Black, New Rectangle(0, 5, 650, 25), BorderSide.None)
            Case "LocationTransfersXtraReport"
                brick = e.Graph.DrawString(previewLocationTransfersGridControl.Text, Color.Black, New Rectangle(0, 5, 650, 25), BorderSide.None)
            Case "ShiftScheduleXtraReport"
                brick = e.Graph.DrawString(shiftScheduleGridControl.Text, Color.Black, New RectangleF(0, 5, 650, 25), BorderSide.None)
            Case "WeeklyProductionXtraReport"
                brick = e.Graph.DrawString(weeklyProductionGridControl.Text, Color.Black, New RectangleF(0, 5, 650, 25), BorderSide.None)
            Case "ProjBomAvailXtraReport"
                brick = e.Graph.DrawString(ProjBomAvailGridControl.Text, Color.Black, New Rectangle(0, 5, 650, 25), BorderSide.None)
            Case "BomDemandSummaryXtraReport"
                brick = e.Graph.DrawString(ProjBomAvailGridControl.Text, Color.Black, New Rectangle(0, 5, 650, 25), BorderSide.None)
            Case "ProductionBillingXtraReport"
                brick = e.Graph.DrawString(previewProductionBillingGridControl.Text, Color.Black, New RectangleF(0, 5, 650, 25), BorderSide.None)
            Case "BaggingXtraReport"
                brick = e.Graph.DrawString(baggingReportPivotGridControl.Text, Color.Black, New RectangleF(0, 5, 650, 25), BorderSide.None)
        End Select
        brick.Font = New Font("Arial", 14, FontStyle.Bold)
        brick.StringFormat = New BrickStringFormat(StringAlignment.Center)

    End Sub

    Private Sub exportXLSBarButtonItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles exportXLSBarButtonItem.ItemClick

        inactiveGridColumn.ColumnEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        exportSaveFileDialog.Filter = "Microsoft Office Excel Workbook(*.xlsx)|*.xlsx|All Files(*.*)|*.*"
        exportSaveFileDialog.DefaultExt = ".xlsx"
        If Me.exportSaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Select m_CurrentReport
                Case "CustomerListXtraReport"
                    previewGridView.ExportToXlsx(Me.exportSaveFileDialog.FileName, New XlsxExportOptions(TextExportMode.Value, True))
                Case "ProductionEntriesXtraReport"
                    previewProductionEntriesGridView.ExportToXlsx(exportSaveFileDialog.FileName, New XlsxExportOptions(TextExportMode.Value, True))
                Case "LpnStatusXtraReport"
                    previewLpnStatusGridView.ExportToXlsx(exportSaveFileDialog.FileName, New XlsxExportOptions(TextExportMode.Value, True))
                Case "CurrentRMInventoryXtraReport"
                    previewCurrentRMInventoryGridView.ExportToXlsx(exportSaveFileDialog.FileName, New XlsxExportOptions(TextExportMode.Value, True))
                Case "CurrentInventoryXtraReport"
                    previewCurrentInventoryGridView.ExportToXlsx(exportSaveFileDialog.FileName, New XlsxExportOptions(TextExportMode.Value, True))
                Case "LocationTransfersXtraReport"
                    previewLocationTransfersGridView.ExportToXlsx(exportSaveFileDialog.FileName, New XlsxExportOptions(TextExportMode.Value, True))
                Case "ShiftScheduleXtraReport"
                    shiftScheduleGridView.ExportToXlsx(exportSaveFileDialog.FileName, New XlsxExportOptions(TextExportMode.Value, True))
                Case "WeeklyProductionXtraReport"
                    weeklyProductionGridView.ExportToXlsx(exportSaveFileDialog.FileName, New XlsxExportOptions(TextExportMode.Value, True))
                Case "ProjBomAvailXtraReport"
                    ProjBomAvailGridView.ExportToXlsx(exportSaveFileDialog.FileName, New XlsxExportOptions(TextExportMode.Value, True))
                Case "BomDemandSummaryXtraReport"
                    ProjBomAvailGridView.ExportToXlsx(exportSaveFileDialog.FileName, New XlsxExportOptions(TextExportMode.Value, True))
                Case "ProductionBillingXtraReport"
                    previewProductionBillingGridView.ExportToXlsx(exportSaveFileDialog.FileName, New XlsxExportOptions(TextExportMode.Value, True))
                Case "BaggingXtraReport"
                    baggingReportPivotGridControl.ExportToXlsx(exportSaveFileDialog.FileName, New XlsxExportOptions(TextExportMode.Value, True))
            End Select
        End If
        inactiveGridColumn.ColumnEdit = Nothing

    End Sub

    Private Sub previewProductionEntriesGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles previewProductionEntriesGridView.CustomColumnDisplayText

        Try
            If e.Column Is expirationDateGridColumn AndAlso IsDate(e.Value) Then
                e.DisplayText = CDate(e.Value).ToString(previewProductionEntriesGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, expirationDateFormatGridColumn).ToString)
            End If
        Catch

        End Try

    End Sub

    Private Sub refreshSimpleButton_Click(sender As Object, e As EventArgs) Handles refreshSimpleButton.Click

        Dim lShouldReturn, onlyAssigned As Boolean
        CheckPermissions(lShouldReturn, "General", onlyAssigned)
        If lShouldReturn Then
            previewCurrentInventoryGridControl.DataSource = Nothing
            Exit Sub
        Else
            previewCurrentInventoryGridControl.DataSource = CurrentInventoryReportBLL.GetCurrentInventoryReport(Nothing, Nothing, Nothing, currentInventoryInactiveItemsCheckEdit.Checked, currentInventoryInactiveCustomersCheckEdit.Checked,
                                                                                                                            outOfStockItemsCheckEdit.Checked, onlyAssigned, Nothing)
        End If

    End Sub

    Private Sub previewLocationTransfersGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles previewLocationTransfersGridView.CustomColumnDisplayText

        If e.Column Is locationTransferExpirationDateGridColumn AndAlso IsDate(e.Value) Then
            e.DisplayText = CDate(e.Value).ToString(previewLocationTransfersGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, locationTransferExpirationDateFormatGridColumn).ToString)
        End If

    End Sub

    Private Sub refreshShiftScheduleSimpleButton_Click(sender As Object, e As EventArgs) Handles refreshShiftScheduleSimpleButton.Click

        If Utilities.ChangeType(Of Date?)(shiftScheduleDateDateEdit.EditValue).HasValue = False OrElse CDate(shiftScheduleDateDateEdit.EditValue) = Date.MinValue Then
            shiftScheduleGridControl.DataSource = Nothing
            Exit Sub
        End If
        shiftScheduleGridControl.DataSource = ShiftScheduleReportBLL.GetShiftScheduleReport(Utilities.ChangeType(Of Date?)(shiftScheduleDateDateEdit.EditValue), CStr(shiftScheduleShiftComboBoxEdit.EditValue))
        previewShiftScheduleXtraTabPage.PageVisible = True
        reportsXtraTabControl.SelectedTabPage = previewShiftScheduleXtraTabPage
        shiftScheduleGridControl.Text = String.Format("{0} - {1}", CDate(shiftScheduleDateDateEdit.EditValue).ToLongDateString, shiftScheduleShiftComboBoxEdit.Text)

    End Sub

    'Private Sub baggingReportPivotGridControl_CustomUnboundFieldData(sender As Object, e As DevExpress.XtraPivotGrid.CustomFieldDataEventArgs) Handles baggingReportPivotGridControl.CustomUnboundFieldData

    '    If e.Field.UnboundFieldName = reasonsPivotGridField.UnboundFieldName Then
    '        e.Value = XpoDefault.Session.GetObjectByKey(Of Production)(e.GetListSourceColumnValue("ProductionID")).Reasons
    '    ElseIf e.Field.UnboundFieldName = minutesPivotGridField.UnboundFieldName Then
    '        'Dim MinPerHour As Integer = MainXtraForm.MinPerHOur
    '        'Dim currentProduction = XpoDefault.Session.GetObjectByKey(Of Production)(e.GetListSourceColumnValue("ProductionID"))
    '        'Dim MachineStandard = currentProduction.ProdMainItemID.MachineStandards.Where(Function(IMS) IMS.Machine.MachineLineID = CurrentProduction.ProdMainMachineLine.MachineLineID).FirstOrDefault()
    '        'If MachineStandard IsNot Nothing Then
    '        '    If MachineStandard.MinutesPerShift > 0 Then
    '        '        MinPerHour = CInt(MachineStandard.MinutesPerShift / 7.16667)
    '        '    Else If CurrentProduction.ProdMainItemID.MinutesPerShift > 0
    '        '        MinPerHour = CInt(CurrentProduction.ProdMainItemID.MinutesPerShift / 7.1667)
    '        '    End If
    '        'Else
    '        '    If CurrentProduction.ProdMainItemID.MinutesPerShift > 0
    '        '        MinPerHour = CInt(CurrentProduction.ProdMainItemID.MinutesPerShift / 7.1667)
    '        '    End If
    '        'End If
    '        Dim Minutes = DateDiff(DateInterval.Minute, CType(e.GetListSourceColumnValue("ProductionStartTime"), DateTime), CType(e.GetListSourceColumnValue("ProductionStopTime"), DateTime))
    '        Dim BreakMinutes = BreakTimeBLL.GetBreakMinutes(Convert.ToDateTime(e.GetListSourceColumnValue("ProductionDate")), Convert.ToDateTime(e.GetListSourceColumnValue("ProductionStartTime")), _
    '                                                  Convert.ToDateTime(e.GetListSourceColumnValue("ProductionStopTime")))
    '        e.Value = Minutes - BreakMinutes
    '    End If

    'End Sub

    Private Sub baggingReportPivotGridControl_CustomSummary(sender As Object, e As DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventArgs) Handles baggingReportPivotGridControl.CustomSummary

        'If e.DataField Is reasonsPivotGridField
        '    Dim currentRow As PivotDrillDownDataRow
        '    Dim reasonSummary As List(Of String) = New List(Of String)
        '    Dim ds = e.CreateDrillDownDataSource()
        '    For i = 0 To ds.RowCount - 1
        '        currentRow = ds(i)
        '        For Each reason In currentRow(reasonsPivotGridField).ToString.Split(";"c)
        '            If reasonSummary.Contains(reason) = False Then
        '                reasonSummary.Add(reason)
        '            End If
        '        Next
        '    Next
        '    e.CustomValue = String.Join(";", reasonSummary)
        'End If

    End Sub

    Private Sub neededBy_Properties_DateTimeChanged(sender As Object, e As EventArgs) Handles neededBy.Properties.DateTimeChanged
        If neededBy.Visible = False Then Exit Sub
        If neededBy IsNot Nothing Then
            ProjBomAvailGridControl.DataSource = BomAvailabilityReportBLL.GetDemandSummary(XpoDefault.Session, neededBy.DateTime)
        Else
            ProjBomAvailGridControl.DataSource = BomAvailabilityReportBLL.GetDemandSummary(XpoDefault.Session)
        End If
        ProjBomAvailGridControl.RefreshDataSource()
    End Sub

    Private Sub LabelControl3_Click(sender As Object, e As EventArgs) Handles lblNededBy.Click

    End Sub

    Private Sub previewProductionBillingGridView_FilterEditorCreated(sender As Object, e As DevExpress.XtraGrid.Views.Base.FilterControlEventArgs) Handles previewProductionBillingGridView.FilterEditorCreated

        AddHandler e.FilterControl.BeforeShowValueEditor, AddressOf FilterControl_BeforeShowValueEditor
    End Sub

    Private Sub FilterControl_BeforeShowValueEditor(sender As Object, e As DevExpress.XtraEditors.Filtering.ShowValueEditorEventArgs)
        If (e.CurrentNode.FirstOperand.PropertyName = "Production Date") Then
            Dim editor As DateEdit
            editor = CType(e.Editor, DateEdit)
            editor.Width = 200
            editor.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True
            editor.Properties.CalendarTimeProperties.Mask.EditMask = "g"
            editor.Properties.TimeEditWidth = 150
        End If
    End Sub
End Class