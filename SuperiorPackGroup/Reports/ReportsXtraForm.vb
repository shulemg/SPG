Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraEditors
Imports System
Imports System.Text
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Public Class ReportsXtraForm

    Private m_ProductionBLL As ProductionBLL = Nothing
    Private m_CustomersBLL As CustomersBLL = Nothing
    Private m_ShiftsBLL As ShiftsBLL = Nothing
    Private m_ItemsBLL As ItemsBLL = Nothing
    Private m_MachinesBLL As MachinesLinesBLL = Nothing
    Private m_Report As XtraReport = Nothing
    Private m_Production As SPG.ProductionDataTable = Nothing
    Private m_Destinations As ShippingAddressBLL = Nothing
    Private m_Carriers As CarriersBLL = Nothing
    Private m_SelectedReport As String

    Public Sub SelectedReport(ByVal reportName As String)

        Me.Cursor = Cursors.WaitCursor

        m_SelectedReport = reportName

        If m_ProductionBLL Is Nothing Then
            m_ProductionBLL = New ProductionBLL
        End If

        InitiateLookupEditControls()

        Me.fromDateEdit.EditValue = DateAdd(DateInterval.Day, (Weekday(Today) - 1) * -1, Today)
        Me.toDateEdit.EditValue = Today

        Select Case reportName
            Case "ProductionDetailXtraReport"
                columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
                Me.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(Nothing, "FG|IG", False, XpoDefault.Session)
                If m_Report Is Nothing Then
                    m_Report = New ProductionXtraReport
                End If
                m_Report.Landscape = True
                BindReportColumns(reportName)
                SetReportColumns(reportName, 0)

            Case "ProductionMachineXtraReport"
                columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
                Me.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(Nothing, "FG|IG", False, XpoDefault.Session)
                If m_Report Is Nothing Then
                    m_Report = New ProductionMachineXtraReport
                End If
                m_Report.Landscape = True
                BindReportColumns(reportName)
                SetReportColumns(reportName, 0)

            Case "ProductionShiftXtraReport"
                columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
                Me.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(Nothing, "FG|IG", False, XpoDefault.Session)
                If m_Report Is Nothing Then
                    m_Report = New ProductionShiftXtraReport
                End If
                m_Report.Landscape = True
                BindReportColumns(reportName)
                SetReportColumns(reportName, 0)

            Case "ProductionSummaryXtraReport"
                columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                Me.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(Nothing, "FG|IG", False, XpoDefault.Session)
                If m_Report Is Nothing Then
                    m_Report = New ProductionSummaryXtraReport
                End If

            Case "ProductionEntriesXtraReport"
                columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
                Me.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(Nothing, "FG|IG", False, XpoDefault.Session)
                If m_Report Is Nothing Then
                    m_Report = New ProductionXtraReport
                End If
                m_Report.Landscape = False
                BindReportColumns(reportName)
                SetReportColumns(reportName, 38)

            Case "CostingXtraReport", "CostingSmallXtraReport", "FinancialCostingXtraReport"
                columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
                Me.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(Nothing, "FG|IG|RM", False, XpoDefault.Session)
                If m_Report Is Nothing Then
                    m_Report = New CostingXtraReport
                End If
                m_Report.Landscape = True
                BindReportColumns(reportName)
                SetReportColumns(reportName, 0)

            Case "ShippingXtraReport"
                columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
                Me.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(Nothing, "FG|IG", False, XpoDefault.Session)
                If m_Report Is Nothing Then
                    m_Report = New TransportationXtraReport
                End If
                BindReportColumns(reportName)
                SetReportColumns(reportName, 4)

            Case "ShippingReturnsXtraReport"
                columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
                Me.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(Nothing, "RM|IG", False, XpoDefault.Session)
                If m_Report Is Nothing Then
                    m_Report = New TransportationXtraReport
                End If
                BindReportColumns(reportName)
                SetReportColumns(reportName, 4)

            Case "ReceivingXtraReport"
                columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
                Me.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(Nothing, "RM|IG", False, XpoDefault.Session)
                If m_Report Is Nothing Then
                    m_Report = New TransportationXtraReport
                End If
                BindReportColumns(reportName)
                SetReportColumns(reportName, 10)

            Case "ReceivingReturnsXtraReport"
                columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
                Me.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(Nothing, "FG|IG", False, XpoDefault.Session)
                If m_Report Is Nothing Then
                    m_Report = New TransportationXtraReport
                End If
                BindReportColumns(reportName)
                SetReportColumns(reportName, 10)

            Case "InventoryAdjustmentXtraReport"
                columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
                Me.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(Nothing, "FG|IG|RM", False, XpoDefault.Session)
                If m_Report Is Nothing Then
                    m_Report = New InventoryXtraReport
                End If
                BindReportColumns(reportName)
                SetReportColumns(reportName, 20)

            Case "PhysicalInventoryXtraReport"
                columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
                Me.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(Nothing, "FG|IG|RM", False, XpoDefault.Session)
                If m_Report Is Nothing Then
                    m_Report = New InventoryXtraReport
                End If
                BindReportColumns(reportName)
                SetReportColumns(reportName, 43)

            Case "CurrentInventoryXtraReport"
                columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
                Me.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(Nothing, "FG|IG|RM", False, XpoDefault.Session)
                If m_Report Is Nothing Then
                    m_Report = New InventoryXtraReport
                End If
                BindReportColumns(reportName)
                SetReportColumns(reportName, 12)

            Case "FinishedProductAvailabilityXtraReport"
                columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
                Me.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(Nothing, "FG|IG", False, XpoDefault.Session)
                If m_Report Is Nothing Then
                    m_Report = New InventoryXtraReport
                End If
                BindReportColumns(reportName)
                SetReportColumns(reportName, 35)

            Case "ItemsListXtraReport"
                columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
                Me.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(Nothing, "FG|IG|RM", False, XpoDefault.Session)
                If m_Report Is Nothing Then
                    m_Report = New ItemsXtraReport
                End If
                BindReportColumns(reportName)
                SetReportColumns(reportName, 80)

            Case "ItemsTransactionsXtraReport"
                MessageBox.Show("This report has been replaced with the Item Transaction Summary report.")
                Exit Sub
                'columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                'Me.itemCheckedListBoxControl.DataSource = m_ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(Nothing, "FG|IG|RM", False)
                'If m_Report Is Nothing Then
                '    m_Report = New ItemTransactionXtraReport
                'End If
                'BindReportColumns(reportName)
                'SetReportColumns(reportName, 80)

            Case "ItemTransactionSummaryXtraReport"
                columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
                itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(Nothing, "FG|IG|RM", False, XpoDefault.Session)
                If m_Report Is Nothing Then
                    m_Report = New ItemsXtraReport
                End If
                BindReportColumns(reportName)
                SetReportColumns(reportName, 62)

            Case "PalletTransactionXtraReport"
                columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide
                If m_Report Is Nothing Then
                    m_Report = New PalletTransactionXtraReport
                End If
                BindReportColumns(reportName)
                SetReportColumns(reportName, 0)

            Case "PalletControlXtraReport"
                columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                If m_Report Is Nothing Then
                    m_Report = New PalletsXtraReport
                End If
                BindReportColumns(reportName)

            Case "AuditTrailXtraReport"
                columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                If m_Report Is Nothing Then
                    m_Report = New AuditTrailXtraReport
                End If
                BindReportColumns(reportName)

        End Select

        reportsPrintControl.PrintingSystem = m_Report.PrintingSystem
        BindReport()
        'm_Report.CreateDocument()
        If m_SelectedReport <> "PalletControlXtraReport" AndAlso m_SelectedReport <> "ItemsTransactionsXtraReport" AndAlso m_SelectedReport <> "PalletTransactionXtraReport" Then
            m_Report.PrintingSystem.Document.AutoFitToPagesWidth = 1
        End If

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub InitiateLookupEditControls()

        If m_CustomersBLL Is Nothing AndAlso customerLookUpEdit.Enabled = True Then
            m_CustomersBLL = New CustomersBLL
            Me.customerLookUpEdit.Properties.DataSource = m_CustomersBLL.GetCustomerNameAndIDS(Nothing)
            Me.customerLookUpEdit.Properties.Columns.Add(New LookUpColumnInfo)
            Me.customerLookUpEdit.Properties.Columns(0).Caption = "Customer Name"
            Me.customerLookUpEdit.Properties.Columns(0).FieldName = "CustomerName"
            Me.customerLookUpEdit.Properties.DisplayMember = "CustomerName"
            Me.customerLookUpEdit.Properties.ValueMember = "CustomerID"
        End If

        If m_ShiftsBLL Is Nothing AndAlso shiftLookUpEdit.Enabled = True Then
            m_ShiftsBLL = New ShiftsBLL
            Me.shiftLookUpEdit.Properties.DataSource = m_ShiftsBLL.GetShifts()
            Me.shiftLookUpEdit.Properties.Columns.Add(New LookUpColumnInfo)
            Me.shiftLookUpEdit.Properties.Columns(0).Caption = "Shift"
            Me.shiftLookUpEdit.Properties.Columns(0).FieldName = "ShiftName"
            Me.shiftLookUpEdit.Properties.DisplayMember = "ShiftName"
            Me.shiftLookUpEdit.Properties.ValueMember = "ShiftID"
        End If

        If m_ItemsBLL Is Nothing AndAlso (itemCheckedListBoxControl.Enabled = True OrElse itemTypeLookUpEdit.Enabled = True) Then
            m_ItemsBLL = New ItemsBLL
            Me.itemCheckedListBoxControl.DisplayMember = "ItemCode"
            Me.itemCheckedListBoxControl.ValueMember = "ItemID"

            Me.itemTypeLookUpEdit.Properties.DataSource = ItemsBLL.GetItemTypes
            Me.itemTypeLookUpEdit.Properties.DisplayMember = "Description"
            Me.itemTypeLookUpEdit.Properties.ValueMember = "Type"
        End If

        If m_MachinesBLL Is Nothing AndAlso machineLookUpEdit.Enabled = True Then
            m_MachinesBLL = New MachinesLinesBLL
            Me.machineLookUpEdit.Properties.DataSource = m_MachinesBLL.GetMachineLines()
            Me.machineLookUpEdit.Properties.Columns.Add(New LookUpColumnInfo)
            Me.machineLookUpEdit.Properties.Columns(0).Caption = "Machine Line"
            Me.machineLookUpEdit.Properties.Columns(0).FieldName = "MachineLineName"
            Me.machineLookUpEdit.Properties.DisplayMember = "MachineLineName"
            Me.machineLookUpEdit.Properties.ValueMember = "MachineLineID"
        End If

        If m_Destinations Is Nothing AndAlso destinationLookUpEdit.Enabled = True Then
            m_Destinations = New ShippingAddressBLL
            Me.destinationLookUpEdit.Properties.DataSource = m_Destinations.GetAddressNameAndIDS
            Me.destinationLookUpEdit.Properties.Columns.Add(New LookUpColumnInfo)
            Me.destinationLookUpEdit.Properties.Columns(0).FieldName = "ShippingName"
            Me.destinationLookUpEdit.Properties.Columns(0).Caption = "Destination"
            Me.destinationLookUpEdit.Properties.DisplayMember = "ShippingName"
            Me.destinationLookUpEdit.Properties.ValueMember = "AddressID"
        End If

        If m_Carriers Is Nothing AndAlso carrierLookUpEdit.Enabled = True Then
            m_Carriers = New CarriersBLL
            Me.carrierLookUpEdit.Properties.DataSource = m_Carriers.GetCarrierIDAndNames
            Me.carrierLookUpEdit.Properties.Columns.Add(New LookUpColumnInfo)
            Me.carrierLookUpEdit.Properties.Columns(0).FieldName = "CarrierName"
            Me.carrierLookUpEdit.Properties.Columns(0).Caption = "Carrier Name"
            Me.carrierLookUpEdit.Properties.DisplayMember = "CarrierName"
            Me.carrierLookUpEdit.Properties.ValueMember = "CarrierID"
        End If

    End Sub

    Private Sub SetReportColumns(ByVal reportCodeName As String, ByVal additionalWidth As Integer)

        Dim left As Integer = 0

        Select Case reportCodeName
            Case "ProductionDetailXtraReport"
                Dim report As ProductionXtraReport = CType(m_Report, ProductionXtraReport)
                With report
                    If Me.productionDateCheckEdit.Checked = True Then
                        .dateDetailXrLabel.Visible = True
                        .dateHeaderXrLabel.Visible = True
                        .dateHeaderXrLabel.Left = left
                        .dateDetailXrLabel.Left = left
                        left += .dateDetailXrLabel.Width
                    Else
                        .dateHeaderXrLabel.Visible = False
                        .dateDetailXrLabel.Visible = False
                    End If
                    If Me.productionShiftCheckEdit.Checked = True Then
                        .shiftHeaderXrLabel.Visible = True
                        .shiftDetailXrLabel.Visible = True
                        .shiftHeaderXrLabel.Left = left
                        .shiftDetailXrLabel.Left = left
                        left += .shiftDetailXrLabel.Width
                    Else
                        .shiftHeaderXrLabel.Visible = False
                        .shiftDetailXrLabel.Visible = False
                    End If
                    If Me.productionCustomerNameCheckEdit.Checked = True Then
                        .customerNameHeaderXrLabel.Visible = True
                        .customerNameDetailXrLabel.Visible = True
                        .customerNameHeaderXrLabel.Left = left
                        .customerNameDetailXrLabel.Left = left
                        left += .customerNameDetailXrLabel.Width
                    Else
                        .customerNameHeaderXrLabel.Visible = False
                        .customerNameDetailXrLabel.Visible = False
                    End If
                    If Me.productionLotCheckEdit.Checked = True Then
                        .lotHeadeerXrLabel.Visible = True
                        .lotDetailXrLabel.Visible = True
                        .lotHeadeerXrLabel.Left = left
                        .lotDetailXrLabel.Left = left
                        left += .lotDetailXrLabel.Width
                    Else
                        .lotHeadeerXrLabel.Visible = False
                        .lotDetailXrLabel.Visible = False
                    End If
                    If Me.productionItemCodeCheckEdit.Checked = True Then
                        .itemCodeHeaderXrLabel.Visible = True
                        .itemCodeDetailXrLabel.Visible = True
                        .itemCodeHeaderXrLabel.Left = left
                        .itemCodeDetailXrLabel.Left = left
                        left += .itemCodeDetailXrLabel.Width
                    Else
                        .itemCodeHeaderXrLabel.Visible = False
                        .itemCodeDetailXrLabel.Visible = False
                    End If
                    If Me.productionItemDescriptionCheckEdit.Checked = True Then
                        .itemDescriptionHeaderXrLabel.Visible = True
                        .itemDescriptionDetailXrLabel.Visible = True
                        .itemDescriptionHeaderXrLabel.Left = left
                        .itemDescriptionDetailXrLabel.Left = left
                        left += .itemDescriptionDetailXrLabel.Width
                    Else
                        .itemDescriptionHeaderXrLabel.Visible = False
                        .itemDescriptionDetailXrLabel.Visible = False
                    End If
                    If Me.productionStartTimeCheckEdit.Checked = True Then
                        .startTimeHeaderXrLabel.Visible = True
                        .startTimeDetailXrLabel.Visible = True
                        .startTimeHeaderXrLabel.Left = left
                        .startTimeDetailXrLabel.Left = left
                        left += .startTimeDetailXrLabel.Width
                    Else
                        .startTimeHeaderXrLabel.Visible = False
                        .stopTimeDetailXrLabel.Visible = False
                    End If
                    If Me.productionStopTimeCheckEdit.Checked = True Then
                        .stopTimeHeaderXrLabel.Visible = True
                        .stopTimeDetailXrLabel.Visible = True
                        .stopTimeHeaderXrLabel.Left = left
                        .stopTimeDetailXrLabel.Left = left
                        left += .stopTimeDetailXrLabel.Width
                    Else
                        .stopTimeHeaderXrLabel.Visible = False
                        .stopTimeDetailXrLabel.Visible = False
                    End If
                    If Me.productionTotalHoursCheckEdit.Checked = True Then
                        .totalHoursHeaderXrLabel.Visible = True
                        .totalHoursDetailXrLabel.Visible = True
                        .totalHoursFooterXrLabel.Visible = True
                        .totalHoursHeaderXrLabel.Left = left
                        .totalHoursDetailXrLabel.Left = left
                        .totalHoursFooterXrLabel.Left = left - 5
                        left += .totalHoursDetailXrLabel.Width
                    Else
                        .totalHoursHeaderXrLabel.Visible = False
                        .totalHoursDetailXrLabel.Visible = False
                        .totalHoursFooterXrLabel.Visible = False
                    End If
                    If Me.productionTotalMinutesCheckEdit.Checked = True Then
                        .totalMinutesHeaderXrLabel.Visible = True
                        .totalMinutesDetailXrLabel.Visible = True
                        .totalMinutesHeaderXrLabel.Left = left
                        .totalMinutesDetailXrLabel.Left = left
                        left += .totalMinutesDetailXrLabel.Width
                    Else
                        .totalMinutesHeaderXrLabel.Visible = False
                        .totalMinutesDetailXrLabel.Visible = False
                    End If
                    If Me.productionQuantityCheckEdit.Checked = True Then
                        .quantityHeaderXrLabel.Visible = True
                        .quantityDetailXrLabel.Visible = True
                        .quantityFooterXrLabel.Visible = True
                        .quantityHeaderXrLabel.Left = left
                        .quantityDetailXrLabel.Left = left
                        .quantityFooterXrLabel.Left = left - 10
                        left += .quantityDetailXrLabel.Width
                    Else
                        .quantityHeaderXrLabel.Visible = False
                        .quantityDetailXrLabel.Visible = False
                        .quantityFooterXrLabel.Visible = False
                    End If
                    If productionUOMCheckEdit.Checked = True Then
                        .uomHeaderXrLabel.Visible = True
                        .uomDetailXrLabel.Visible = True
                        .uomHeaderXrLabel.Left = left
                        .uomDetailXrLabel.Left = left
                        left += .uomDetailXrLabel.Width
                    Else
                        .uomHeaderXrLabel.Visible = False
                        .uomDetailXrLabel.Visible = False
                    End If   
                    If Me.productionExpectedCheckEdit.Checked = True Then
                        .expectedHeaderXrLabel.Visible = True
                        .expectedDetailXrLabel.Visible = True
                        .expectedFooterXrLabel.Visible = True
                        .expectedHeaderXrLabel.Left = left
                        .expectedDetailXrLabel.Left = left
                        .expectedFooterXrLabel.Left = left
                        left += .expectedDetailXrLabel.Width
                    Else
                        .expectedHeaderXrLabel.Visible = False
                        .expectedDetailXrLabel.Visible = False
                        .expectedFooterXrLabel.Visible = False
                    End If
                    If Me.productionDifferenceCheckEdit.Checked = True Then
                        .differenceHeaderXrLabel.Visible = True
                        .differenceDetailXrLabel.Visible = True
                        .differenceFooterXrLabel.Visible = True
                        .differenceHeaderXrLabel.Left = left
                        .differenceDetailXrLabel.Left = left
                        .differenceFooterXrLabel.Left = left
                        left += .differenceDetailXrLabel.Width
                    Else
                        .differenceHeaderXrLabel.Visible = False
                        .differenceDetailXrLabel.Visible = False
                        .differenceFooterXrLabel.Visible = False
                    End If
                    If Me.productionMachineLineCheckEdit.Checked = True Then
                        .machineLineHeaderXrLabel.Visible = True
                        .machineLineDetailXrLabel.Visible = True
                        .machineLineHeaderXrLabel.Left = left
                        .machineLineDetailXrLabel.Left = left
                        left += .machineLineDetailXrLabel.Width
                    Else
                        .machineLineHeaderXrLabel.Visible = False
                        .machineLineDetailXrLabel.Visible = False
                    End If
                    If Me.productionProjectedSpeedCheckEdit.Checked = True Then
                        .machineSpeedHeaderXrLabel.Visible = True 
                        .machineSpeedDetailXrLabel.Visible = True
                        .machineSpeedHeaderXrLabel.Left = left
                        .machineSpeedDetailXrLabel.Left = left 
                        left += .machineSpeedDetailXrLabel.Width
                    Else
                        .machineSpeedHeaderXrLabel.Visible = False
                        .machineSpeedDetailXrLabel.Visible = False
                    End If
                    If Me.productionActualSpeedCheckEdit.Checked = True Then
                        .actualSpeedHeaderXrLabel.Visible = True
                        .actualSpeedDetailXrLabel.Visible = True
                        .actualSpeedFooterXrLabel.Visible = True
                        .actualSpeedHeaderXrLabel.Left = left
                        .actualSpeedDetailXrLabel.Left = left
                        .actualSpeedFooterXrLabel.Left = left - 5
                        left += .actualSpeedDetailXrLabel.Width
                    Else
                        .actualSpeedHeaderXrLabel.Visible = False
                        .actualSpeedDetailXrLabel.Visible = False
                        .actualSpeedFooterXrLabel.Visible = False
                    End If
                    If Me.productionPOCheckEdit.Checked = True Then
                        .poHeaderXrLabel.Visible = True
                        .poDetailXrLabel.Visible = True
                        .poHeaderXrLabel.Left = left
                        .actualSpeedDetailXrLabel.Left = left
                        left += .poDetailXrLabel.Width
                    Else
                        .poHeaderXrLabel.Visible = False
                        .poDetailXrLabel.Visible = False
                    End If
                    If Me.productionPackersCheckEdit.Checked = True Then
                        .packersHeaderXrLabel.Visible = True
                        .packersDetailXrLabel.Visible = True
                        .packersHeaderXrLabel.Left = left
                        .packersDetailXrLabel.Left = left
                        left += .packersDetailXrLabel.Width
                    Else
                        .packersHeaderXrLabel.Visible = False
                        .packersDetailXrLabel.Visible = False
                    End If
                    If productionProjectedPackersCheckEdit.Checked = True Then
                        .projectedPackersHeaderXrLabel.Visible = True
                        .projectedPackersDetailXrLabel.Visible = True
                        .projectedPackersHeaderXrLabel.Left = left
                        .projectedPackersDetailXrLabel.Left = left
                        left += .projectedPackersDetailXrLabel.Width
                    Else
                        .projectedPackersHeaderXrLabel.Visible = False
                        .projectedPackersDetailXrLabel.Visible = False
                    End If 
                    If productionReasonCodeCheckEdit.Checked = True Then
                        .ReasonCodeHeaderXrLabel.Visible = True
                        .ReasonCodeDetailXrLabel.Visible = True
                        .ReasonCodeHeaderXrLabel.Left = left
                        .ReasonCodeDetailXrLabel.Left = left
                        left += .ReasonCodeDetailXrLabel.Width
                    Else
                        .ReasonCodeHeaderXrLabel.Visible = False
                        .ReasonCodeDetailXrLabel.Visible = False
                    End If                       
                    If Me.productionTotalPayrollCheckEdit.Checked = True Then
                        .totalPayrollHeaderXrLabel.Visible = True
                        .totalPayrollDetailXrLabel.Visible = True
                        .totalPayrollFooterXrLabel.Visible = True
                        .totalPayrollHeaderXrLabel.Left = left
                        .totalPayrollDetailXrLabel.Left = left
                        .totalPayrollFooterXrLabel.Left = left
                        left += .totalPayrollDetailXrLabel.Width
                    Else
                        .totalPayrollHeaderXrLabel.Visible = False
                        .totalPayrollDetailXrLabel.Visible = False
                        .totalPayrollFooterXrLabel.Visible = False
                    End If
                    .printDateXrPageInfo.Left = left - 185
                    .reportCriteriaXrLabel.Width = left - 190
                    .reportTitleXrLabel.Width = left
                    .headerXrPanel.Width = left
                    .footerXrPanel.Width = left
                    .pageNumberXrPageInfo.Left = left - 100
                End With
            Case "ProductionMachineXtraReport"
                Dim report As ProductionMachineXtraReport = CType(m_Report, ProductionMachineXtraReport)
                left = 67
                With report
                    If Me.pmsTotalMinutesCheckEdit.Checked = True Then
                        .minutesHeaderXrLabel.Visible = True
                        .machineTotalMinutesXRLabel.Visible = True
                        .itemMinutesXrLabel.Visible = True
                        .minutesHeaderXrLabel.Left = left
                        .machineTotalMinutesXRLabel.Left = left
                        .itemMinutesXrLabel.Left = left
                        left += .machineTotalMinutesXRLabel.Width
                    Else
                        .minutesHeaderXrLabel.Visible = False
                        .machineTotalMinutesXRLabel.Visible = False
                        .itemMinutesXrLabel.Visible = False
                    End If
                    If Me.pmsQuantityCheckEdit.Checked = True Then
                        .quantityHeaderXrLabel.Visible = True
                        .machineQuantityXrLabel.Visible = True
                        .itemQuantityXrLabel.Visible = True
                        .quantityHeaderXrLabel.Left = left
                        .machineQuantityXrLabel.Left = left
                        .itemQuantityXrLabel.Left = left
                        left += .machineQuantityXrLabel.Width
                    Else
                        .quantityHeaderXrLabel.Visible = False
                        .machineQuantityXrLabel.Visible = False
                        .itemQuantityXrLabel.Visible = False
                    End If
                    If Me.pmsProjectedSpeedCheckEdit.Checked = True Then
                        .machineSpeedHeaderXrLabel.Visible = True
                        .machineProjectedSpeedXrLabel.Visible = True
                        .itemProjectedSpeedXrLabel.Visible = True
                        .machineSpeedHeaderXrLabel.Left = left
                        .machineProjectedSpeedXrLabel.Left = left
                        .itemProjectedSpeedXrLabel.Left = left
                        left += .machineProjectedSpeedXrLabel.Width
                    Else
                        .machineSpeedHeaderXrLabel.Visible = False
                        .machineProjectedSpeedXrLabel.Visible = False
                        .itemProjectedSpeedXrLabel.Left = left
                    End If
                    If Me.pmsAverageSpeedCheckEdit.Checked = True Then
                        .averageSpeedHeadeerXrLabel.Visible = True
                        .machineAverageSpeedXRLabel.Visible = True
                        .itemAverageSpeedXrLabel.Visible = True
                        .averageSpeedHeadeerXrLabel.Left = left
                        .machineAverageSpeedXRLabel.Left = left
                        .itemAverageSpeedXrLabel.Left = left
                        left += .machineAverageSpeedXRLabel.Width
                    Else
                        .averageSpeedHeadeerXrLabel.Visible = False
                        .machineAverageSpeedXRLabel.Visible = False
                        .itemAverageSpeedXrLabel.Left = left
                    End If
                    If Me.pmsSpeedVariationVolCheckEdit.Checked = True Then
                        .speedVariationVolumeHeaderXrLabel.Visible = True
                        .machineSpeedVariationVolumeXrLabel.Visible = True
                        .itemSpeedVariationXrLabel.Visible = True
                        .speedVariationVolumeHeaderXrLabel.Left = left
                        .machineSpeedVariationVolumeXrLabel.Left = left
                        .itemSpeedVariationXrLabel.Left = left
                        left += .machineSpeedVariationVolumeXrLabel.Width
                    Else
                        .speedVariationVolumeHeaderXrLabel.Visible = False
                        .machineSpeedVariationVolumeXrLabel.Visible = False
                        .itemSpeedVariationXrLabel.Visible = False
                    End If
                    If Me.pmsSpeedVariationPerCheckEdit.Checked = True Then
                        .speedVariationPercentageHeaderXrLabel.Visible = True
                        .machineSpeedVariationPercentageXrLabel.Visible = True
                        .itemSpeedVariationPercentageXrLabel.Visible = True
                        .speedVariationPercentageHeaderXrLabel.Left = left
                        .machineSpeedVariationPercentageXrLabel.Left = left
                        .itemSpeedVariationPercentageXrLabel.Left = left
                        left += .machineSpeedVariationPercentageXrLabel.Width
                    Else
                        .speedVariationPercentageHeaderXrLabel.Visible = False
                        .machineSpeedVariationPercentageXrLabel.Visible = False
                        .itemSpeedVariationPercentageXrLabel.Visible = False
                    End If
                    If Me.pmsProjectedPackersCheckEdit.Checked = True Then
                        .projectedPackersHeaderXrLabel.Visible = True
                        .machineProjectedPackersXrLabel.Visible = True
                        .itemProjectedPackersXrLabel.Visible = True
                        .projectedPackersHeaderXrLabel.Left = left
                        .machineProjectedPackersXrLabel.Left = left
                        .itemProjectedPackersXrLabel.Left = left
                        left += .machineProjectedPackersXrLabel.Width
                    Else
                        .projectedPackersHeaderXrLabel.Visible = False
                        .machineProjectedPackersXrLabel.Visible = False
                        .itemProjectedPackersXrLabel.Visible = False
                    End If
                    If Me.pmsPackersCheckEdit.Checked = True Then
                        .packersHeaderXrLabel.Visible = True
                        .machineAverageActualPackersXrLabel.Visible = True
                        .itemAverageActualPackersXrLabel.Visible = True
                        .packersHeaderXrLabel.Left = left
                        .machineAverageActualPackersXrLabel.Left = left
                        .itemAverageActualPackersXrLabel.Left = left
                        left += .machineAverageActualPackersXrLabel.Width
                    Else
                        .packersHeaderXrLabel.Visible = False
                        .machineAverageActualPackersXrLabel.Visible = False
                        .itemAverageActualPackersXrLabel.Visible = False
                    End If
                    If Me.pmsPackersVariationVolCheckEdit.Checked = True Then
                        .packersVariationVolumeHeaderXrLabel.Visible = True
                        .machinePackersVariationVolumeXrLabel.Visible = True
                        .itemPackersVariationVolumeXrLabel.Visible = True
                        .packersVariationVolumeHeaderXrLabel.Left = left
                        .machinePackersVariationVolumeXrLabel.Left = left
                        .itemPackersVariationVolumeXrLabel.Left = left
                        left += .machinePackersVariationVolumeXrLabel.Width
                    Else
                        .packersVariationVolumeHeaderXrLabel.Visible = False
                        .machinePackersVariationVolumeXrLabel.Visible = False
                        .itemPackersVariationVolumeXrLabel.Visible = False
                    End If
                    If Me.pmsPackersVariationPerCheckEdit.Checked = True Then
                        .packersVariationPercentageHeaderXrLabel.Visible = True
                        .machinePackersVariationPercentageXrLabel.Visible = True
                        .itemPackersVariationPercentageXrLabel.Visible = True
                        .packersVariationPercentageHeaderXrLabel.Left = left
                        .machinePackersVariationPercentageXrLabel.Left = left
                        .itemPackersVariationPercentageXrLabel.Left = left
                        left += .machinePackersVariationPercentageXrLabel.Width
                    Else
                        .packersVariationPercentageHeaderXrLabel.Visible = False
                        .machinePackersVariationPercentageXrLabel.Visible = False
                        .itemPackersVariationPercentageXrLabel.Visible = False
                    End If
                    If Me.pmsProjectedCostCheckEdit.Checked = True Then
                        .projectedCostHeaderXrLabel.Visible = True
                        .machineProjectedCostXrLabel.Visible = True
                        .itemProjectedCostXrLabel.Visible = True
                        .projectedCostHeaderXrLabel.Left = left
                        .machineProjectedCostXrLabel.Left = left
                        .itemProjectedCostXrLabel.Left = left
                        left += .machineProjectedCostXrLabel.Width
                    Else
                        .projectedCostHeaderXrLabel.Visible = False
                        .machineProjectedCostXrLabel.Visible = False
                        .itemProjectedCostXrLabel.Visible = False
                    End If
                    If Me.pmsCostCheckEdit.Checked = True Then
                        .averageActualCostHeaderXrLabel.Visible = True
                        .machineAverageCostXrLabel.Visible = True
                        .itemAverageCostXrLabel.Visible = True
                        .averageActualCostHeaderXrLabel.Left = left
                        .machineAverageCostXrLabel.Left = left
                        .itemAverageCostXrLabel.Left = left
                        left += .machineAverageCostXrLabel.Width
                    Else
                        .averageActualCostHeaderXrLabel.Visible = False
                        .machineAverageCostXrLabel.Visible = False
                        .itemAverageCostXrLabel.Visible = False
                    End If
                    If Me.pmsCostVariationCheckEdit.Checked = True Then
                        .costVariationHeaderXrLabel.Visible = True
                        .machineCostVariationXrLabel.Visible = True
                        .itemCostVariationXrLabel.Visible = True
                        .costVariationHeaderXrLabel.Left = left
                        .machineCostVariationXrLabel.Left = left
                        .itemCostVariationXrLabel.Left = left
                        left += .machineCostVariationXrLabel.Width
                    Else
                        .costVariationHeaderXrLabel.Visible = False
                        .machineCostVariationXrLabel.Visible = False
                        .itemCostVariationXrLabel.Visible = False
                    End If
                    If Me.pmsCostVariationPerCheckEdit.Checked = True Then
                        .costVariationPercentageHeaderXrLabel.Visible = True
                        .machineCostVariationPercentageXrLabel.Visible = True
                        .itemCostVariationPercentageXrLabel.Visible = True
                        .costVariationPercentageHeaderXrLabel.Left = left
                        .machineCostVariationPercentageXrLabel.Left = left
                        .itemCostVariationPercentageXrLabel.Left = left
                        left += .machineCostVariationPercentageXrLabel.Width
                    Else
                        .costVariationPercentageHeaderXrLabel.Visible = False
                        .machineCostVariationPercentageXrLabel.Visible = False
                        .itemCostVariationPercentageXrLabel.Visible = False
                    End If
                    If Me.pmsPricePerPieceCheckEdit.Checked = True Then
                        .pricePerPieceHeaderXrLabel.Visible = True
                        .machinePricePerPieceXrLabel.Visible = True
                        .itemPricePerPieceXrLabel.Visible = True
                        .pricePerPieceHeaderXrLabel.Left = left
                        .machinePricePerPieceXrLabel.Left = left
                        .itemPricePerPieceXrLabel.Left = left
                        left += .machinePricePerPieceXrLabel.Width
                    Else
                        .pricePerPieceHeaderXrLabel.Visible = False
                        .machinePricePerPieceXrLabel.Visible = False
                        .itemPricePerPieceXrLabel.Visible = False
                    End If
                    If Me.pmsSalesVsPayrollCheckEdit.Checked = True Then
                        .salesVsPayrollHeaderXrLabel.Visible = True
                        .machineSalesVsPayrollXrLabel.Visible = True
                        .itemSalesVsPayrollXrLabel.Visible = True
                        .salesVsPayrollHeaderXrLabel.Left = left
                        .machineSalesVsPayrollXrLabel.Left = left
                        .itemSalesVsPayrollXrLabel.Left = left
                        left += .machineSalesVsPayrollXrLabel.Width
                    Else
                        .salesVsPayrollHeaderXrLabel.Visible = False
                        .machineSalesVsPayrollXrLabel.Visible = False
                        .itemSalesVsPayrollXrLabel.Visible = False
                    End If
                    If Me.pmsPriceCheckEdit.Checked = True Then
                        .priceHeaderXrLabel.Visible = True
                        .machinePriceXrLabel.Visible = True
                        .itemPriceXrLabel.Visible = True
                        .priceHeaderXrLabel.Left = left
                        .machinePriceXrLabel.Left = left
                        .itemPriceXrLabel.Left = left
                        left += .machinePriceXrLabel.Width
                    Else
                        .priceHeaderXrLabel.Visible = False
                        .machinePriceXrLabel.Visible = False
                        .itemPriceXrLabel.Visible = False
                    End If
                    If Me.pmsTotalSalesCheckEdit.Checked = True Then
                        .totalSalesHeaderXrLabel.Visible = True
                        .machineTotalSalesXrLabel.Visible = True
                        .itemTotalSalesXrLabel.Visible = True
                        .totalSalesHeaderXrLabel.Left = left
                        .machineTotalSalesXrLabel.Left = left
                        .itemTotalSalesXrLabel.Left = left
                        left += .machineTotalSalesXrLabel.Width
                    Else
                        .totalSalesHeaderXrLabel.Visible = False
                        .machineTotalSalesXrLabel.Visible = False
                        .itemTotalSalesXrLabel.Visible = False
                    End If
                    .printDateXrPageInfo.Left = left - 185
                    .reportCriteriaXrLabel.Width = left - 190
                    .reportTitleXrLabel.Width = left
                    .headerXrPanel.Width = left
                    .footerXrPanel.Width = left
                    .itemHeaderXRLine.Width = left - 8
                    .itemDescriptionXrLabel.Width = left - 418
                    .pageNumberXrPageInfo.Left = left - 100
                End With
            Case "ProductionShiftXtraReport"
                Dim report As ProductionShiftXtraReport = CType(m_Report, ProductionShiftXtraReport)
                left = 67
                With report
                    If Me.pmsTotalMinutesCheckEdit.Checked = True Then
                        .minutesHeaderXrLabel.Visible = True
                        .shiftTotalMinutesXRLabel.Visible = True
                        .itemMinutesXrLabel.Visible = True
                        .minutesHeaderXrLabel.Left = left
                        .shiftTotalMinutesXRLabel.Left = left
                        .itemMinutesXrLabel.Left = left
                        left += .shiftTotalMinutesXRLabel.Width
                    Else
                        .minutesHeaderXrLabel.Visible = False
                        .shiftTotalMinutesXRLabel.Visible = False
                        .itemMinutesXrLabel.Visible = False
                    End If
                    If Me.pmsQuantityCheckEdit.Checked = True Then
                        .quantityHeaderXrLabel.Visible = True
                        .shiftQuantityXrLabel.Visible = True
                        .itemQuantityXrLabel.Visible = True
                        .quantityHeaderXrLabel.Left = left
                        .shiftQuantityXrLabel.Left = left
                        .itemQuantityXrLabel.Left = left
                        left += .shiftQuantityXrLabel.Width
                    Else
                        .quantityHeaderXrLabel.Visible = False
                        .shiftQuantityXrLabel.Visible = False
                        .itemQuantityXrLabel.Visible = False
                    End If
                    If Me.pmsProjectedSpeedCheckEdit.Checked = True Then
                        .machineSpeedHeaderXrLabel.Visible = True
                        .shiftProjectedSpeedXrLabel.Visible = True
                        .itemProjectedSpeedXrLabel.Visible = True
                        .machineSpeedHeaderXrLabel.Left = left
                        .shiftProjectedSpeedXrLabel.Left = left
                        .itemProjectedSpeedXrLabel.Left = left
                        left += .shiftProjectedSpeedXrLabel.Width
                    Else
                        .machineSpeedHeaderXrLabel.Visible = False
                        .shiftProjectedSpeedXrLabel.Visible = False
                        .itemProjectedSpeedXrLabel.Left = left
                    End If
                    If Me.pmsAverageSpeedCheckEdit.Checked = True Then
                        .averageSpeedHeadeerXrLabel.Visible = True
                        .shiftAverageSpeedXRLabel.Visible = True
                        .itemAverageSpeedXrLabel.Visible = True
                        .averageSpeedHeadeerXrLabel.Left = left
                        .shiftAverageSpeedXRLabel.Left = left
                        .itemAverageSpeedXrLabel.Left = left
                        left += .shiftAverageSpeedXRLabel.Width
                    Else
                        .averageSpeedHeadeerXrLabel.Visible = False
                        .shiftAverageSpeedXRLabel.Visible = False
                        .itemAverageSpeedXrLabel.Left = left
                    End If
                    If Me.pmsSpeedVariationVolCheckEdit.Checked = True Then
                        .speedVariationVolumeHeaderXrLabel.Visible = True
                        .shiftSpeedVariationVolumeXrLabel.Visible = True
                        .itemSpeedVariationXrLabel.Visible = True
                        .speedVariationVolumeHeaderXrLabel.Left = left
                        .shiftSpeedVariationVolumeXrLabel.Left = left
                        .itemSpeedVariationXrLabel.Left = left
                        left += .shiftSpeedVariationVolumeXrLabel.Width
                    Else
                        .speedVariationVolumeHeaderXrLabel.Visible = False
                        .shiftSpeedVariationVolumeXrLabel.Visible = False
                        .itemSpeedVariationXrLabel.Visible = False
                    End If
                    If Me.pmsSpeedVariationPerCheckEdit.Checked = True Then
                        .speedVariationPercentageHeaderXrLabel.Visible = True
                        .shiftSpeedVariationPercentageXrLabel.Visible = True
                        .itemSpeedVariationPercentageXrLabel.Visible = True
                        .speedVariationPercentageHeaderXrLabel.Left = left
                        .shiftSpeedVariationPercentageXrLabel.Left = left
                        .itemSpeedVariationPercentageXrLabel.Left = left
                        left += .shiftSpeedVariationPercentageXrLabel.Width
                    Else
                        .speedVariationPercentageHeaderXrLabel.Visible = False
                        .shiftSpeedVariationPercentageXrLabel.Visible = False
                        .itemSpeedVariationPercentageXrLabel.Visible = False
                    End If
                    If Me.pmsProjectedPackersCheckEdit.Checked = True Then
                        .projectedPackersHeaderXrLabel.Visible = True
                        .shiftProjectedPackersXrLabel.Visible = True
                        .itemProjectedPackersXrLabel.Visible = True
                        .projectedPackersHeaderXrLabel.Left = left
                        .shiftProjectedPackersXrLabel.Left = left
                        .itemProjectedPackersXrLabel.Left = left
                        left += .shiftProjectedPackersXrLabel.Width
                    Else
                        .projectedPackersHeaderXrLabel.Visible = False
                        .shiftProjectedPackersXrLabel.Visible = False
                        .itemProjectedPackersXrLabel.Visible = False
                    End If
                    If Me.pmsPackersCheckEdit.Checked = True Then
                        .packersHeaderXrLabel.Visible = True
                        .shiftAverageActualPackersXrLabel.Visible = True
                        .itemAverageActualPackersXrLabel.Visible = True
                        .packersHeaderXrLabel.Left = left
                        .shiftAverageActualPackersXrLabel.Left = left
                        .itemAverageActualPackersXrLabel.Left = left
                        left += .shiftAverageActualPackersXrLabel.Width
                    Else
                        .packersHeaderXrLabel.Visible = False
                        .shiftAverageActualPackersXrLabel.Visible = False
                        .itemAverageActualPackersXrLabel.Visible = False
                    End If
                    If Me.pmsPackersVariationVolCheckEdit.Checked = True Then
                        .packersVariationVolumeHeaderXrLabel.Visible = True
                        .shiftPackersVariationVolumeXrLabel.Visible = True
                        .itemPackersVariationVolumeXrLabel.Visible = True
                        .packersVariationVolumeHeaderXrLabel.Left = left
                        .shiftPackersVariationVolumeXrLabel.Left = left
                        .itemPackersVariationVolumeXrLabel.Left = left
                        left += .shiftPackersVariationVolumeXrLabel.Width
                    Else
                        .packersVariationVolumeHeaderXrLabel.Visible = False
                        .shiftPackersVariationVolumeXrLabel.Visible = False
                        .itemPackersVariationVolumeXrLabel.Visible = False
                    End If
                    If Me.pmsPackersVariationPerCheckEdit.Checked = True Then
                        .packersVariationPercentageHeaderXrLabel.Visible = True
                        .shiftPackersVariationPercentageXrLabel.Visible = True
                        .itemPackersVariationPercentageXrLabel.Visible = True
                        .packersVariationPercentageHeaderXrLabel.Left = left
                        .shiftPackersVariationPercentageXrLabel.Left = left
                        .itemPackersVariationPercentageXrLabel.Left = left
                        left += .shiftPackersVariationPercentageXrLabel.Width
                    Else
                        .packersVariationPercentageHeaderXrLabel.Visible = False
                        .shiftPackersVariationPercentageXrLabel.Visible = False
                        .itemPackersVariationPercentageXrLabel.Visible = False
                    End If
                    If Me.pmsProjectedCostCheckEdit.Checked = True Then
                        .projectedCostHeaderXrLabel.Visible = True
                        .shiftProjectedCostXrLabel.Visible = True
                        .itemProjectedCostXrLabel.Visible = True
                        .projectedCostHeaderXrLabel.Left = left
                        .shiftProjectedCostXrLabel.Left = left
                        .itemProjectedCostXrLabel.Left = left
                        left += .shiftProjectedCostXrLabel.Width
                    Else
                        .projectedCostHeaderXrLabel.Visible = False
                        .shiftProjectedCostXrLabel.Visible = False
                        .itemProjectedCostXrLabel.Visible = False
                    End If
                    If Me.pmsCostCheckEdit.Checked = True Then
                        .averageActualCostHeaderXrLabel.Visible = True
                        .shiftAverageCostXrLabel.Visible = True
                        .itemAverageCostXrLabel.Visible = True
                        .averageActualCostHeaderXrLabel.Left = left
                        .shiftAverageCostXrLabel.Left = left
                        .itemAverageCostXrLabel.Left = left
                        left += .shiftAverageCostXrLabel.Width
                    Else
                        .averageActualCostHeaderXrLabel.Visible = False
                        .shiftAverageCostXrLabel.Visible = False
                        .itemAverageCostXrLabel.Visible = False
                    End If
                    If Me.pmsCostVariationCheckEdit.Checked = True Then
                        .costVariationHeaderXrLabel.Visible = True
                        .shiftCostVariationXrLabel.Visible = True
                        .itemCostVariationXrLabel.Visible = True
                        .costVariationHeaderXrLabel.Left = left
                        .shiftCostVariationXrLabel.Left = left
                        .itemCostVariationXrLabel.Left = left
                        left += .shiftCostVariationXrLabel.Width
                    Else
                        .costVariationHeaderXrLabel.Visible = False
                        .shiftCostVariationXrLabel.Visible = False
                        .itemCostVariationXrLabel.Visible = False
                    End If
                    If Me.pmsCostVariationPerCheckEdit.Checked = True Then
                        .costVariationPercentageHeaderXrLabel.Visible = True
                        .shiftCostVariationPercentageXrLabel.Visible = True
                        .itemCostVariationPercentageXrLabel.Visible = True
                        .costVariationPercentageHeaderXrLabel.Left = left
                        .shiftCostVariationPercentageXrLabel.Left = left
                        .itemCostVariationPercentageXrLabel.Left = left
                        left += .shiftCostVariationPercentageXrLabel.Width
                    Else
                        .costVariationPercentageHeaderXrLabel.Visible = False
                        .shiftCostVariationPercentageXrLabel.Visible = False
                        .itemCostVariationPercentageXrLabel.Visible = False
                    End If
                    If Me.pmsPricePerPieceCheckEdit.Checked = True Then
                        .pricePerPieceHeaderXrLabel.Visible = True
                        .shiftPricePerPieceXrLabel.Visible = True
                        .itemPricePerPieceXrLabel.Visible = True
                        .pricePerPieceHeaderXrLabel.Left = left
                        .shiftPricePerPieceXrLabel.Left = left
                        .itemPricePerPieceXrLabel.Left = left
                        left += .shiftPricePerPieceXrLabel.Width
                    Else
                        .pricePerPieceHeaderXrLabel.Visible = False
                        .shiftPricePerPieceXrLabel.Visible = False
                        .itemPricePerPieceXrLabel.Visible = False
                    End If
                    If Me.pmsSalesVsPayrollCheckEdit.Checked = True Then
                        .salesVsPayrollHeaderXrLabel.Visible = True
                        .shiftSalesVsPayrollXrLabel.Visible = True
                        .itemSalesVsPayrollXrLabel.Visible = True
                        .salesVsPayrollHeaderXrLabel.Left = left
                        .shiftSalesVsPayrollXrLabel.Left = left
                        .itemSalesVsPayrollXrLabel.Left = left
                        left += .shiftSalesVsPayrollXrLabel.Width
                    Else
                        .salesVsPayrollHeaderXrLabel.Visible = False
                        .shiftSalesVsPayrollXrLabel.Visible = False
                        .itemSalesVsPayrollXrLabel.Visible = False
                    End If
                    If Me.pmsPriceCheckEdit.Checked = True Then
                        .priceHeaderXrLabel.Visible = True
                        .shiftPriceXrLabel.Visible = True
                        .itemPriceXrLabel.Visible = True
                        .priceHeaderXrLabel.Left = left
                        .shiftPriceXrLabel.Left = left
                        .itemPriceXrLabel.Left = left
                        left += .shiftPriceXrLabel.Width
                    Else
                        .priceHeaderXrLabel.Visible = False
                        .shiftPriceXrLabel.Visible = False
                        .itemPriceXrLabel.Visible = False
                    End If
                    If Me.pmsTotalSalesCheckEdit.Checked = True Then
                        .totalSalesHeaderXrLabel.Visible = True
                        .shiftTotalSalesXrLabel.Visible = True
                        .itemTotalSalesXrLabel.Visible = True
                        .totalSalesHeaderXrLabel.Left = left
                        .shiftTotalSalesXrLabel.Left = left
                        .itemTotalSalesXrLabel.Left = left
                        left += .shiftTotalSalesXrLabel.Width
                    Else
                        .totalSalesHeaderXrLabel.Visible = False
                        .shiftTotalSalesXrLabel.Visible = False
                        .itemTotalSalesXrLabel.Visible = False
                    End If
                    .printDateXrPageInfo.Left = left - 185
                    .reportCriteriaXrLabel.Width = left - 190
                    .reportTitleXrLabel.Width = left
                    .headerXrPanel.Width = left
                    .footerXrPanel.Width = left
                    .itemHeaderXRLine.Width = left - 8
                    .itemDescriptionXrLabel.Width = left - 418
                    .pageNumberXrPageInfo.Left = left - 100
                End With
            Case "ProductionEntriesXtraReport"
                Dim report As ProductionXtraReport = CType(m_Report, ProductionXtraReport)
                With report
                    If Me.productionDateCheckEdit.Checked = True Then
                        .dateDetailXrLabel.Visible = True
                        .dateHeaderXrLabel.Visible = True
                        .dateHeaderXrLabel.Left = left
                        .dateDetailXrLabel.Left = left
                        .dateHeaderXrLabel.Width += additionalWidth
                        .dateDetailXrLabel.Width += additionalWidth
                        left += .dateDetailXrLabel.Width
                    Else
                        .dateHeaderXrLabel.Visible = False
                        .dateDetailXrLabel.Visible = False
                    End If
                    If Me.productionShiftCheckEdit.Checked = True Then
                        .shiftHeaderXrLabel.Visible = True
                        .shiftDetailXrLabel.Visible = True
                        .shiftHeaderXrLabel.Left = left
                        .shiftDetailXrLabel.Left = left
                        left += .shiftDetailXrLabel.Width
                    Else
                        .shiftHeaderXrLabel.Visible = False
                        .shiftDetailXrLabel.Visible = False
                    End If
                    If Me.productionCustomerNameCheckEdit.Checked = True Then
                        .customerNameHeaderXrLabel.Visible = True
                        .customerNameDetailXrLabel.Visible = True
                        .customerNameHeaderXrLabel.Left = left
                        .customerNameDetailXrLabel.Left = left
                        .customerNameDetailXrLabel.Width += additionalWidth
                        .customerNameHeaderXrLabel.Width += additionalWidth
                        left += .customerNameDetailXrLabel.Width
                    Else
                        .customerNameHeaderXrLabel.Visible = False
                        .customerNameDetailXrLabel.Visible = False
                    End If
                    If Me.productionItemCodeCheckEdit.Checked = True Then
                        .itemCodeHeaderXrLabel.Visible = True
                        .itemCodeDetailXrLabel.Visible = True
                        .itemCodeHeaderXrLabel.Left = left
                        .itemCodeDetailXrLabel.Left = left
                        .itemCodeDetailXrLabel.Width += additionalWidth
                        .itemCodeHeaderXrLabel.Width += additionalWidth
                        left += .itemCodeDetailXrLabel.Width
                    Else
                        .itemCodeHeaderXrLabel.Visible = False
                        .itemCodeDetailXrLabel.Visible = False
                    End If
                    If Me.productionItemDescriptionCheckEdit.Checked = True Then
                        .itemDescriptionHeaderXrLabel.Visible = True
                        .itemDescriptionDetailXrLabel.Visible = True
                        .itemDescriptionHeaderXrLabel.Left = left
                        .itemDescriptionDetailXrLabel.Left = left
                        .itemDescriptionDetailXrLabel.Width += additionalWidth
                        .itemDescriptionHeaderXrLabel.Width += additionalWidth
                        left += .itemDescriptionDetailXrLabel.Width
                    Else
                        .itemDescriptionHeaderXrLabel.Visible = False
                        .itemDescriptionDetailXrLabel.Visible = False
                    End If
                    If Me.productionLotCheckEdit.Checked = True Then
                        .lotHeadeerXrLabel.Visible = True
                        .lotDetailXrLabel.Visible = True
                        .lotHeadeerXrLabel.Left = left
                        .lotDetailXrLabel.Left = left
                        .lotDetailXrLabel.Width += additionalWidth
                        .lotHeadeerXrLabel.Width += additionalWidth
                        left += .lotDetailXrLabel.Width
                    Else
                        .lotHeadeerXrLabel.Visible = False
                        .lotDetailXrLabel.Visible = False
                    End If
                    If Me.productionStartTimeCheckEdit.Checked = True Then
                        .startTimeHeaderXrLabel.Visible = True
                        .startTimeDetailXrLabel.Visible = True
                        .startTimeHeaderXrLabel.Left = left
                        .startTimeDetailXrLabel.Left = left
                        left += .startTimeDetailXrLabel.Width
                    Else
                        .startTimeHeaderXrLabel.Visible = False
                        .startTimeDetailXrLabel.Visible = False
                    End If
                    If Me.productionStopTimeCheckEdit.Checked = True Then
                        .stopTimeHeaderXrLabel.Visible = True
                        .stopTimeDetailXrLabel.Visible = True
                        .stopTimeHeaderXrLabel.Left = left
                        .stopTimeDetailXrLabel.Left = left
                        left += .stopTimeDetailXrLabel.Width
                    Else
                        .stopTimeHeaderXrLabel.Visible = False
                        .stopTimeDetailXrLabel.Visible = False
                    End If
                    If Me.productionTotalHoursCheckEdit.Checked = True Then
                        .totalHoursHeaderXrLabel.Visible = True
                        .totalHoursDetailXrLabel.Visible = True
                        .totalHoursFooterXrLabel.Visible = True
                        .totalHoursHeaderXrLabel.Left = left
                        .totalHoursDetailXrLabel.Left = left
                        .totalHoursFooterXrLabel.Left = left - 5
                        left += .totalHoursDetailXrLabel.Width
                    Else
                        .totalHoursHeaderXrLabel.Visible = False
                        .totalHoursDetailXrLabel.Visible = False
                        .totalHoursFooterXrLabel.Visible = False
                    End If
                    If Me.productionTotalMinutesCheckEdit.Checked = True Then
                        .totalMinutesHeaderXrLabel.Visible = True
                        .totalMinutesDetailXrLabel.Visible = True
                        .totalMinutesHeaderXrLabel.Left = left
                        .totalMinutesDetailXrLabel.Left = left
                        left += .totalMinutesDetailXrLabel.Width
                    Else
                        .totalMinutesHeaderXrLabel.Visible = False
                        .totalMinutesDetailXrLabel.Visible = False
                    End If
                    If Me.productionPOCheckEdit.Checked = True Then
                        .poHeaderXrLabel.Visible = True
                        .poDetailXrLabel.Visible = True
                        .poHeaderXrLabel.Left = left
                        .poDetailXrLabel.Left = left
                        .poDetailXrLabel.Width += additionalWidth
                        .poHeaderXrLabel.Width += additionalWidth
                        left += .poDetailXrLabel.Width
                    Else
                        .poHeaderXrLabel.Visible = False
                        .poDetailXrLabel.Visible = False
                    End If
                    If Me.productionQuantityCheckEdit.Checked = True Then
                        .quantityHeaderXrLabel.Visible = True
                        .quantityDetailXrLabel.Visible = True
                        .quantityFooterXrLabel.Visible = True
                        .quantityHeaderXrLabel.Left = left
                        .quantityDetailXrLabel.Left = left
                        .quantityFooterXrLabel.Left = left
                        .quantityDetailXrLabel.Width += additionalWidth
                        .quantityFooterXrLabel.Width = .quantityDetailXrLabel.Width
                        .quantityHeaderXrLabel.Width += additionalWidth
                        left += .quantityDetailXrLabel.Width
                    Else
                        .quantityHeaderXrLabel.Visible = False
                        .quantityDetailXrLabel.Visible = False
                        .quantityFooterXrLabel.Visible = False
                    End If
                    If Me.productionExpectedCheckEdit.Checked = True Then
                        .expectedHeaderXrLabel.Visible = True
                        .expectedDetailXrLabel.Visible = True
                        .expectedFooterXrLabel.Visible = True
                        .expectedHeaderXrLabel.Left = left
                        .expectedDetailXrLabel.Left = left
                        .expectedFooterXrLabel.Left = left
                        left += .expectedDetailXrLabel.Width
                    Else
                        .expectedHeaderXrLabel.Visible = False
                        .expectedDetailXrLabel.Visible = False
                        .expectedFooterXrLabel.Visible = False
                    End If
                    .uomHeaderXrLabel.Visible = False
                    .uomDetailXrLabel.Visible = False
                    If Me.productionDifferenceCheckEdit.Checked = True Then
                        .differenceHeaderXrLabel.Visible = True
                        .differenceDetailXrLabel.Visible = True
                        .differenceFooterXrLabel.Visible = True
                        .differenceHeaderXrLabel.Left = left
                        .differenceDetailXrLabel.Left = left
                        .differenceFooterXrLabel.Left = left
                        left += .differenceDetailXrLabel.Width
                    Else
                        .differenceHeaderXrLabel.Visible = False
                        .differenceDetailXrLabel.Visible = False
                        .differenceFooterXrLabel.Visible = False
                    End If
                    If Me.productionMachineLineCheckEdit.Checked = True Then
                        .machineLineHeaderXrLabel.Visible = True
                        .machineLineDetailXrLabel.Visible = True
                        .machineLineHeaderXrLabel.Left = left
                        .machineLineDetailXrLabel.Left = left
                        left += .machineLineDetailXrLabel.Width
                    Else
                        .machineLineHeaderXrLabel.Visible = False
                        .machineLineDetailXrLabel.Visible = False
                    End If
                    .machineSpeedHeaderXrLabel.Visible = False
                    .machineSpeedDetailXrLabel.Visible = False
                    If Me.productionActualSpeedCheckEdit.Checked = True Then
                        .actualSpeedHeaderXrLabel.Visible = True
                        .actualSpeedDetailXrLabel.Visible = True
                        .actualSpeedFooterXrLabel.Visible = True
                        .actualSpeedHeaderXrLabel.Left = left
                        .actualSpeedDetailXrLabel.Left = left
                        .actualSpeedFooterXrLabel.Left = left - 5
                        left += .actualSpeedDetailXrLabel.Width
                    Else
                        .actualSpeedHeaderXrLabel.Visible = False
                        .actualSpeedDetailXrLabel.Visible = False
                        .actualSpeedFooterXrLabel.Visible = False
                    End If
                    If Me.productionPackersCheckEdit.Checked = True Then
                        .packersHeaderXrLabel.Visible = True
                        .packersDetailXrLabel.Visible = True
                        .packersHeaderXrLabel.Left = left
                        .packersDetailXrLabel.Left = left
                        left += .packersDetailXrLabel.Width
                    Else
                        .packersHeaderXrLabel.Visible = False
                        .packersDetailXrLabel.Visible = False
                    End If
                    .projectedPackersHeaderXrLabel.Visible = False
                    .projectedPackersDetailXrLabel.Visible = False
                    .reasonCodeHeaderXrLabel.Visible = False
                    .reasonCodeDetailXrLabel.Visible = False
                    If Me.productionTotalPayrollCheckEdit.Checked = True Then
                        .totalPayrollHeaderXrLabel.Visible = True
                        .totalPayrollDetailXrLabel.Visible = True
                        .totalPayrollFooterXrLabel.Visible = True
                        .totalPayrollHeaderXrLabel.Left = left
                        .totalPayrollDetailXrLabel.Left = left
                        .totalPayrollFooterXrLabel.Left = left
                        left += .totalPayrollDetailXrLabel.Width
                    Else
                        .totalPayrollHeaderXrLabel.Visible = False
                        .totalPayrollDetailXrLabel.Visible = False
                        .totalPayrollFooterXrLabel.Visible = False
                    End If
                    .printDateXrPageInfo.Left = left - 185
                    .reportCriteriaXrLabel.Width = left - 190
                    .reportTitleXrLabel.Width = left
                    .headerXrPanel.Width = left
                    .footerXrPanel.Width = left
                    .pageNumberXrPageInfo.Left = left - 100
                End With
            Case "CostingXtraReport", "CostingSmallXtraReport", "FinancialCostingXtraReport"
                Dim report As CostingXtraReport = CType(m_Report, CostingXtraReport)
                With report
                    If Me.costingProductionDateCheckEdit.Checked = True Then
                        .dateHeaderXRLabel.Visible = True
                        .dateDetailXrLabel.Visible = True
                        .dateHeaderXRLabel.Left = left
                        .dateDetailXrLabel.Left = left
                        left += .dateDetailXrLabel.Width
                    Else
                        .dateHeaderXRLabel.Visible = False
                        .dateDetailXrLabel.Visible = False
                    End If
                    If Me.costingShiftCheckEdit.Checked = True Then
                        .shiftHeaderXRLabel.Visible = True
                        .shiftDetailXrLabel.Visible = True
                        .shiftHeaderXRLabel.Left = left
                        .shiftDetailXrLabel.Left = left
                        left += .shiftDetailXrLabel.Width
                    Else
                        .shiftHeaderXRLabel.Visible = False
                        .shiftDetailXrLabel.Visible = False
                    End If
                    If Me.costingCustomerCheckEdit.Checked Then
                        .customerNameHeaderXRLabel.Visible = True
                        .customerNameDetailXrLabel.Visible = True
                        .customerNameHeaderXRLabel.Left = left
                        .customerNameDetailXrLabel.Left = left
                        left += .customerNameDetailXrLabel.Width
                    Else
                        .customerNameHeaderXRLabel.Visible = False
                        .customerNameDetailXrLabel.Visible = False
                    End If
                    If Me.costingLotCheckEdit.Checked Then
                        .lotHeaderXRLabel.Visible = True
                        .lotDetailXrLabel.Visible = True
                        .lotHeaderXRLabel.Left = left
                        .lotDetailXrLabel.Left = left
                        left += .lotDetailXrLabel.Width
                    Else
                        .lotHeaderXRLabel.Visible = False
                        .lotDetailXrLabel.Visible = False
                    End If
                    If costingItemCodeCheckEdit.Checked Then
                        .itemCodeHeaderXRLabel.Visible = True
                        .itemCodeDetailXrLabel.Visible = True
                        .itemCodeHeaderXRLabel.Left = left
                        .itemCodeDetailXrLabel.Left = left
                        left += .itemCodeDetailXrLabel.Width
                    Else
                        .itemCodeHeaderXRLabel.Visible = False
                        .itemCodeDetailXrLabel.Visible = False
                    End If
                    If costingItemDescriptionCheckEdit.Checked Then
                        .itemDescriptionHeaderXRLabel.Visible = True
                        .itemDescriptionDetailXrLabel.Visible = True
                        .itemDescriptionHeaderXRLabel.Left = left
                        .itemDescriptionDetailXrLabel.Left = left
                        left += .itemDescriptionDetailXrLabel.Width
                    Else
                        .itemDescriptionHeaderXRLabel.Visible = False
                        .itemDescriptionDetailXrLabel.Visible = False
                    End If
                    If Me.costingStartTimeCheckEdit.Checked = True Then
                        .startTimeHeaderXRLabel.Visible = True
                        .startTimeDetailXrLabel.Visible = True
                        .startTimeHeaderXRLabel.Left = left
                        .startTimeDetailXrLabel.Left = left
                        left += .startTimeDetailXrLabel.Width
                    Else
                        .startTimeHeaderXRLabel.Visible = False
                        .startTimeDetailXrLabel.Visible = False
                    End If
                    If Me.costingStopTimeCheckEdit.Checked = True Then
                        .stopTimeHeaderXRLabel.Visible = True
                        .stopTimeDetailXrLabel.Visible = True
                        .stopTimeHeaderXRLabel.Left = left
                        .stopTimeDetailXrLabel.Left = left
                        left += .stopTimeDetailXrLabel.Width
                    Else
                        .stopTimeHeaderXRLabel.Visible = False
                        .stopTimeDetailXrLabel.Visible = False
                    End If
                    If Me.costingTotalHoursCheckEdit.Checked Then
                        .totalHoursHeaderXRLabel.Visible = True
                        .totalHoursDetailXrLabel.Visible = True
                        .totalHoursFooterXRLabel.Visible = True
                        .totalHoursHeaderXRLabel.Left = left
                        .totalHoursDetailXrLabel.Left = left
                        .totalHoursFooterXRLabel.Left = left
                        left += .totalHoursDetailXrLabel.Width
                    Else
                        .totalHoursHeaderXRLabel.Visible = False
                        .totalHoursDetailXrLabel.Visible = False
                        .totalHoursFooterXRLabel.Visible = False
                    End If
                    If Me.costingTotalMinutesCheckEdit.Checked Then
                        .totalMinutesHeaderXRLabel.Visible = True
                        .totalMinutesDetailXrLabel.Visible = True
                        .totalMinutesFooterXRLabel.Visible = True
                        .totalMinutesHeaderXRLabel.Left = left
                        .totalMinutesDetailXrLabel.Left = left
                        .totalMinutesFooterXRLabel.Left = left
                        left += .totalMinutesDetailXrLabel.Width
                    Else
                        .totalMinutesHeaderXRLabel.Visible = False
                        .totalMinutesDetailXrLabel.Visible = False
                        .totalMinutesFooterXRLabel.Visible = False
                    End If
                    If costingQuantityCheckEdit.Checked Then
                        .quantityHeaderXRLabel.Visible = True
                        .quantityDetailXrLabel.Visible = True
                        .quantityFooterXRLabel.Visible = True
                        .quantityHeaderXRLabel.Left = left
                        .quantityDetailXrLabel.Left = left
                        .quantityFooterXRLabel.Left = left
                        left += .quantityDetailXrLabel.Width
                    Else
                        .quantityHeaderXRLabel.Visible = False
                        .quantityDetailXrLabel.Visible = False
                        .quantityFooterXRLabel.Visible = False
                    End If
                    If costingExpectedCheckEdit.Checked Then
                        .expectedHeaderXRLabel.Visible = True
                        .expectedDetailXrLabel.Visible = True
                        .expectedFooterXRLabel.Visible = True
                        .expectedHeaderXRLabel.Left = left
                        .expectedDetailXrLabel.Left = left
                        .expectedFooterXRLabel.Left = left
                        left += .expectedDetailXrLabel.Width
                    Else
                        .expectedHeaderXRLabel.Visible = False
                        .expectedDetailXrLabel.Visible = False
                        .expectedFooterXRLabel.Visible = False
                    End If
                    If Me.costingDifferenceCheckEdit.Checked = True Then
                        .differenceHeaderXRLabel.Visible = True
                        .differenceDetailXrLabel.Visible = True
                        .differenceFooterXRLabel.Visible = True
                        .differenceHeaderXRLabel.Left = left
                        .differenceDetailXrLabel.Left = left
                        .differenceFooterXRLabel.Left = left
                        left += .differenceDetailXrLabel.Width
                    Else
                        .differenceHeaderXRLabel.Visible = False
                        .differenceDetailXrLabel.Visible = False
                        .differenceFooterXRLabel.Visible = False
                    End If
                    If Me.costingMachineLineCheckEdit.Checked = True Then
                        .machineLineHeaderXRLabel.Visible = True
                        .machineLineDetailXrLabel.Visible = True
                        .machineLineHeaderXRLabel.Left = left
                        .machineLineDetailXrLabel.Left = left
                        left += .machineLineDetailXrLabel.Width
                    Else
                        .machineLineHeaderXRLabel.Visible = False
                        .machineLineDetailXrLabel.Visible = False
                    End If
                    If Me.costingMachineSpeedCheckEdit.Checked Then
                        .speedHeaderXRLabel.Visible = True
                        .speedDetailXrLabel.Visible = True
                        .speedHeaderXRLabel.Left = left
                        .speedDetailXrLabel.Left = left
                        left += .speedDetailXrLabel.Width
                    Else
                        .speedHeaderXRLabel.Visible = False
                        .speedDetailXrLabel.Visible = False
                    End If
                    If Me.costingActualSpeedCheckEdit.Checked Then
                        .actualSpeedHeaderXRLabel.Visible = True
                        .actualSpeedDetailXrLabel.Visible = True
                        .actualSpeedFooterXRLabel.Visible = True
                        .actualSpeedHeaderXRLabel.Left = left
                        .actualSpeedDetailXrLabel.Left = left
                        .actualSpeedFooterXRLabel.Left = left
                        left += .actualSpeedDetailXrLabel.Width
                    Else
                        .actualSpeedHeaderXRLabel.Visible = False
                        .actualSpeedDetailXrLabel.Visible = False
                        .actualSpeedFooterXRLabel.Visible = False
                    End If
                    If costingOperatorsCheckEdit.Checked Then
                        .operatorHeaderXRLabel.Visible = True
                        .operatorDetailXrLabel.Visible = True
                        .operatorHeaderXRLabel.Left = left
                        .operatorDetailXrLabel.Left = left
                        left += .operatorDetailXrLabel.Width
                    Else
                        .operatorHeaderXRLabel.Visible = False
                        .operatorDetailXrLabel.Visible = False
                    End If
                    If costingPackersCheckEdit.Checked Then
                        .packerHeaderXRLabel.Visible = True
                        .packerDetailXrLabel.Visible = True
                        .packerHeaderXRLabel.Left = left
                        .packerDetailXrLabel.Left = left
                        left += .packerDetailXrLabel.Width
                    Else
                        .packerHeaderXRLabel.Visible = False
                        .packerDetailXrLabel.Visible = False
                    End If
                    If Me.costingSupersCheckEdit.Checked = True Then
                        .superHeaderXRLabel.Visible = True
                        .superDetailXrLabel.Visible = True
                        .superHeaderXRLabel.Left = left
                        .superDetailXrLabel.Left = left
                        left += .superDetailXrLabel.Width
                    Else
                        .superHeaderXRLabel.Visible = False
                        .superDetailXrLabel.Visible = False
                    End If
                    If Me.costingPriceCheckEdit.Checked = True Then
                        .priceHeaderXRLabel.Visible = True
                        .priceDetailXrLabel.Visible = True
                        .priceFooterXrLabel.Visible = True
                        .priceHeaderXRLabel.Left = left
                        .priceDetailXrLabel.Left = left
                        .priceFooterXrLabel.Left = left
                        left += .priceDetailXrLabel.Width
                    Else
                        .priceHeaderXRLabel.Visible = False
                        .priceDetailXrLabel.Visible = False
                        .priceFooterXrLabel.Visible = False
                    End If
                    If Me.costingPayrollCheckEdit.Checked Then
                        .payrollHeaderXRLabel.Visible = True
                        .payrollDetailXrLabel.Visible = True
                        .payrollFooterXrLabel.Visible = True
                        .payrollHeaderXRLabel.Left = left
                        .payrollDetailXrLabel.Left = left
                        .payrollFooterXrLabel.Left = left
                        left += .payrollDetailXrLabel.Width
                    Else
                        .payrollHeaderXRLabel.Visible = False
                        .payrollDetailXrLabel.Visible = False
                        .payrollFooterXrLabel.Visible = False
                    End If
                    If Me.costingRebateCheckEdit.Checked Then
                        .rebateHeaderXRLabel.Visible = True
                        .rebateDetailXrLabel.Visible = True
                        .rebateFooterXrLabel.Visible = True
                        .rebateHeaderXRLabel.Left = left
                        .rebateDetailXrLabel.Left = left
                        .rebateFooterXrLabel.Left = left
                        left += .rebateDetailXrLabel.Width
                    Else
                        .rebateHeaderXRLabel.Visible = False
                        .rebateDetailXrLabel.Visible = False
                        .rebateFooterXrLabel.Visible = False
                    End If
                    If costingFreightCheckEdit.Checked Then
                        .freightHeaderXRLabel.Visible = True
                        .freightDetailXrLabel.Visible = True
                        .freightFooterXrLabel.Visible = True
                        .freightHeaderXRLabel.Left = left
                        .freightDetailXrLabel.Left = left
                        .freightFooterXrLabel.Left = left
                        left += .freightDetailXrLabel.Width
                    Else
                        .freightHeaderXRLabel.Visible = False
                        .freightDetailXrLabel.Visible = False
                        .freightFooterXrLabel.Visible = False
                    End If
                    If costingFilmCheckEdit.Checked Then
                        .filmHeaderXRLabel.Visible = True
                        .filmDetailXrLabel.Visible = True
                        .filmFooterXrLabel.Visible = True
                        .filmHeaderXRLabel.Left = left
                        .filmDetailXrLabel.Left = left
                        .filmFooterXrLabel.Left = left
                        left += .filmDetailXrLabel.Width
                    Else
                        .filmHeaderXRLabel.Visible = False
                        .filmDetailXrLabel.Visible = False
                        .filmFooterXrLabel.Visible = False
                    End If
                    If Me.costingBoxesCheckEdit.Checked = True Then
                        .boxesHeaderXRLabel.Visible = True
                        .boxesDetailXrLabel.Visible = True
                        .boxesFooterXrLabel.Visible = True
                        .boxesHeaderXRLabel.Left = left
                        .boxesDetailXrLabel.Left = left
                        .boxesFooterXrLabel.Left = left
                        left += .boxesDetailXrLabel.Width
                    Else
                        .boxesHeaderXRLabel.Visible = False
                        .boxesDetailXrLabel.Visible = False
                        .boxesFooterXrLabel.Visible = False
                    End If
                    If Me.costingStretchWrapCheckEdit.Checked = True Then
                        .stretchWrapHeaderXRLabel.Visible = True
                        .stretchWrapDetailXrLabel.Visible = True
                        .stretchWrapFooterXrLabel.Visible = True
                        .stretchWrapHeaderXRLabel.Left = left
                        .stretchWrapDetailXrLabel.Left = left
                        .stretchWrapFooterXrLabel.Left = left
                        left += .stretchWrapDetailXrLabel.Width
                    Else
                        .stretchWrapHeaderXRLabel.Visible = False
                        .stretchWrapDetailXrLabel.Visible = False
                        .stretchWrapFooterXrLabel.Visible = False
                    End If
                    If Me.costingPalletsCheckEdit.Checked Then
                        .palletsHeaderXRLabel.Visible = True
                        .palletsDetailXrLabel.Visible = True
                        .palletsFooterXrLabel.Visible = True
                        .palletsHeaderXRLabel.Left = left
                        .palletsDetailXrLabel.Left = left
                        .palletsFooterXrLabel.Left = left
                        left += .palletsDetailXrLabel.Width
                    Else
                        .palletsHeaderXRLabel.Visible = False
                        .palletsDetailXrLabel.Visible = False
                        .palletsFooterXrLabel.Visible = False
                    End If
                    If Me.costingTotalOtherCheckEdit.Checked Then
                        .totalOtherHeaderXRLabel.Visible = True
                        .totalOtherDetailXrLabel.Visible = True
                        .totalOtherFooterXrLabel.Visible = True
                        .totalOtherHeaderXRLabel.Left = left
                        .totalOtherDetailXrLabel.Left = left
                        .totalOtherFooterXrLabel.Left = left
                        left += .totalOtherDetailXrLabel.Width
                    Else
                        .totalOtherHeaderXRLabel.Visible = False
                        .totalOtherDetailXrLabel.Visible = False
                        .totalOtherFooterXrLabel.Visible = False
                    End If
                    If costingCostCheckBox.Checked Then
                        .costHeaderXRLabel.Visible = True
                        .costDetailXrLabel.Visible = True
                        .costFooterXrLabel.Visible = True
                        .costHeaderXRLabel.Left = left
                        .costDetailXrLabel.Left = left
                        .costFooterXrLabel.Left = left
                        left += .costDetailXrLabel.Width
                    Else
                        .costHeaderXRLabel.Visible = False
                        .costDetailXrLabel.Visible = False
                        .costFooterXrLabel.Visible = False
                    End If
                    If costingProfitCheckEdit.Checked Then
                        .profitHeaderXRLabel.Visible = True
                        .profitDetailXrLabel.Visible = True
                        .profitFooterXrLabel.Visible = True
                        .profitHeaderXRLabel.Left = left
                        .profitDetailXrLabel.Left = left
                        .profitFooterXrLabel.Left = left
                        left += .profitDetailXrLabel.Width
                    Else
                        .profitHeaderXRLabel.Visible = False
                        .profitDetailXrLabel.Visible = False
                        .profitFooterXrLabel.Visible = False
                    End If
                    If Me.costingCostPerPieceCheckEdit.Checked = True Then
                        .costPerPieceHeaderXRLabel.Visible = True
                        .costPerPieceDetailXrLabel.Visible = True
                        .costPerPieceFooterXrLabel.Visible = True
                        .costPerPieceHeaderXRLabel.Left = left
                        .costPerPieceDetailXrLabel.Left = left
                        .costPerPieceFooterXrLabel.Left = left
                        left += .costPerPieceDetailXrLabel.Width
                    Else
                        .costPerPieceHeaderXRLabel.Visible = False
                        .costPerPieceDetailXrLabel.Visible = False
                        .costPerPieceFooterXrLabel.Visible = False
                    End If
                    If Me.costingPacksPerMinuteCheckEdit.Checked = True Then
                        .packsPerMinuteHeaderXRLabel.Visible = True
                        .packsPerMinuteDetailXrLabel.Visible = True
                        .packsPerMinuteFooterXrLabel.Visible = True
                        .packsPerMinuteHeaderXRLabel.Left = left
                        .packsPerMinuteDetailXrLabel.Left = left
                        .packsPerMinuteFooterXrLabel.Left = left
                        left += .packsPerMinuteDetailXrLabel.Width
                    Else
                        .packsPerMinuteHeaderXRLabel.Visible = False
                        .packsPerMinuteDetailXrLabel.Visible = False
                        .packsPerMinuteFooterXrLabel.Visible = False
                    End If
                    If Me.costingSalesVsPayrollCheckEdit.Checked Then
                        .salesVsPayrollHeaderXRLabel.Visible = True
                        .salesVsPayrollDetailXrLabel.Visible = True
                        .salesVsPayrollFooterXrLabel.Visible = True
                        .salesVsPayrollHeaderXRLabel.Left = left
                        .salesVsPayrollDetailXrLabel.Left = left
                        .salesVsPayrollFooterXrLabel.Left = left
                        left += .salesVsPayrollDetailXrLabel.Width
                    Else
                        .salesVsPayrollHeaderXRLabel.Visible = False
                        .salesVsPayrollDetailXrLabel.Visible = False
                        .salesVsPayrollFooterXrLabel.Visible = False
                    End If
                    If Me.CostingSalesVsCostCheckEdit.Checked Then
                        .salesVsCostHeaderXRLabel.Visible = True
                        .salesVsCostDetailXrLabel.Visible = True
                        .salesVsCostFooterXrLabel.Visible = True
                        .salesVsCostHeaderXRLabel.Left = left
                        .salesVsCostDetailXrLabel.Left = left
                        .salesVsCostFooterXrLabel.Left = left
                        left += .salesVsCostDetailXrLabel.Width
                    Else
                        .salesVsCostHeaderXRLabel.Visible = False
                        .salesVsCostDetailXrLabel.Visible = False
                        .salesVsCostFooterXrLabel.Visible = False
                    End If
                    If costingProfitVsSalesCheckEdit.Checked Then
                        .profitVsSalesHeaderXRLabel.Visible = True
                        .profitVsSalesDetailXrLabel.Visible = True
                        .profitVsSalesDetailXrLabel.Visible = True
                        .profitVsSalesHeaderXRLabel.Left = left
                        .profitVsSalesDetailXrLabel.Left = left
                        .profitVsSalesFooterXrLabel.Left = left
                        left += .profitVsSalesDetailXrLabel.Width
                    Else
                        .profitVsSalesHeaderXRLabel.Visible = False
                        .profitVsSalesDetailXrLabel.Visible = False
                        .profitVsSalesFooterXrLabel.Visible = False
                    End If
                    If costingSalesVsProfitCheckEdit.Checked Then
                        .salesVsProfitHeaderXRLabel.Visible = True
                        .salesVsProfitDetailXrLabel.Visible = True
                        .salesVsProfitFooterXrLabel.Visible = True
                        .salesVsProfitHeaderXRLabel.Left = left
                        .salesVsProfitDetailXrLabel.Left = left
                        .salesVsProfitFooterXrLabel.Left = left
                        left += .salesVsProfitDetailXrLabel.Width
                    Else
                        .salesVsProfitHeaderXRLabel.Visible = False
                        .salesVsProfitDetailXrLabel.Visible = False
                        .salesVsProfitFooterXrLabel.Visible = False
                    End If
                    .printDateXRPageInfo.Left = left - 185
                    .reportCriteriaXrLabel.Width = left - 190
                    .reportTitleXRLabel.Width = left
                    .headerXrPanel.Width = left
                    .footerXrPanel.Width = left
                    .pageNumberXrPageInfo.Left = left - 100
                    If left > 1100 AndAlso reportCodeName = "CostingXtraReport" Then
                        .PaperKind = Printing.PaperKind.Custom
                        .PageWidth = left
                        .PageHeight = 850
                    Else
                        .PaperKind = Printing.PaperKind.Letter
                    End If
                End With
            Case "ShippingXtraReport"
                Dim report As TransportationXtraReport = CType(m_Report, TransportationXtraReport)
                With report
                    If Me.transportationDateCheckEdit.Checked = True Then
                        .dateDetailXrLabel.Visible = True
                        .dateHeaderXrLabel.Visible = True
                        .dateHeaderXrLabel.Left = left
                        .dateDetailXrLabel.Left = left
                        .dateHeaderXrLabel.Width += additionalWidth
                        .dateDetailXrLabel.Width += additionalWidth
                        left += .dateDetailXrLabel.Width
                    Else
                        .dateHeaderXrLabel.Visible = False
                        .dateDetailXrLabel.Visible = False
                    End If
                    If Me.transportationShiftCheckEdit.Checked = True Then
                        .shiftHeaderXrLabel.Visible = True
                        .shiftDetailXrLabel.Visible = True
                        .shiftHeaderXrLabel.Left = left
                        .shiftDetailXrLabel.Left = left
                        .shiftDetailXrLabel.Width += additionalWidth
                        .shiftHeaderXrLabel.Width += additionalWidth
                        left += .shiftDetailXrLabel.Width
                    Else
                        .shiftHeaderXrLabel.Visible = False
                        .shiftDetailXrLabel.Visible = False
                    End If
                    If Me.transportationCustomerCheckEdit.Checked = True Then
                        .customerNameHeaderXrLabel.Visible = True
                        .customerNameDetailXrLabel.Visible = True
                        .customerNameHeaderXrLabel.Left = left
                        .customerNameDetailXrLabel.Left = left
                        .customerNameDetailXrLabel.Width += additionalWidth
                        .customerNameHeaderXrLabel.Width += additionalWidth
                        left += .customerNameDetailXrLabel.Width
                    Else
                        .customerNameHeaderXrLabel.Visible = False
                        .customerNameDetailXrLabel.Visible = False
                    End If
                    If Me.transportationBolCheckEdit.Checked = True Then
                        .bolHeaderXrLabel.Visible = True
                        .bolDetailXrLabel.Visible = True
                        .bolDetailXrLabel.Left = left
                        .bolHeaderXrLabel.Left = left
                        .bolDetailXrLabel.Width += additionalWidth
                        .bolHeaderXrLabel.Width += additionalWidth
                        left += .bolDetailXrLabel.Width
                    Else
                        .bolHeaderXrLabel.Visible = False
                        .bolDetailXrLabel.Visible = False
                    End If
                    If Me.transportationPOCheckEdit.Checked = True Then
                        .poHeaderXrLabel.Visible = True
                        .poDetailXrLabel.Visible = True
                        .poHeaderXrLabel.Left = left
                        .poDetailXrLabel.Left = left
                        .poDetailXrLabel.Width += additionalWidth
                        .poHeaderXrLabel.Width += additionalWidth
                        left += .poDetailXrLabel.Width
                    Else
                        .poHeaderXrLabel.Visible = False
                        .poDetailXrLabel.Visible = False
                    End If
                    If Me.transportationDeliveryNoteCheckEdit.Checked = True Then
                        .deliveryNoteNumberHeaderXrLabel.Visible = True
                        .deliveryNoteNumberDetailXrLabel.Visible = True
                        .deliveryNoteNumberHeaderXrLabel.Left = left
                        .deliveryNoteNumberDetailXrLabel.Left = left
                        .deliveryNoteNumberDetailXrLabel.Width += additionalWidth
                        .deliveryNoteNumberHeaderXrLabel.Width += additionalWidth
                        left += .deliveryNoteNumberDetailXrLabel.Width
                    Else
                        .deliveryNoteNumberHeaderXrLabel.Visible = False
                        .deliveryNoteNumberDetailXrLabel.Visible = False
                    End If
                    If Me.transportationDestinationCheckEdit.Checked = True Then
                        .destinationHeaderXrLabel.Visible = True
                        .destinationDetailXrLabel.Visible = True
                        .destinationHeaderXrLabel.Left = left
                        .destinationDetailXrLabel.Left = left
                        .destinationDetailXrLabel.Width += additionalWidth
                        .destinationHeaderXrLabel.Width += additionalWidth
                        left += .destinationDetailXrLabel.Width
                    Else
                        .destinationHeaderXrLabel.Visible = False
                        .destinationDetailXrLabel.Visible = False
                    End If
                    If Me.transportationItemCheckEdit.Checked = True Then
                        .itemCodeHeaderXrLabel.Visible = True
                        .itemCodeDetailXrLabel.Visible = True
                        .itemCodeHeaderXrLabel.Left = left
                        .itemCodeDetailXrLabel.Left = left
                        .itemCodeDetailXrLabel.Width += additionalWidth
                        .itemCodeHeaderXrLabel.Width += additionalWidth
                        left += .itemCodeDetailXrLabel.Width
                    Else
                        .itemCodeHeaderXrLabel.Visible = False
                        .itemCodeDetailXrLabel.Visible = False
                    End If
                    If Me.transportationItemDescriptionCheckEdit.Checked = True Then
                        .itemDescriptionHeaderXrLabel.Visible = True
                        .itemDescriptionDetailXrLabel.Visible = True
                        .itemDescriptionHeaderXrLabel.Left = left
                        .itemDescriptionDetailXrLabel.Left = left
                        .itemDescriptionDetailXrLabel.Width += additionalWidth
                        .itemDescriptionHeaderXrLabel.Width += additionalWidth
                        left += .itemDescriptionDetailXrLabel.Width
                    Else
                        .itemDescriptionHeaderXrLabel.Visible = False
                        .itemDescriptionDetailXrLabel.Visible = False
                    End If
                    If Me.transportationLpnCheckEdit.Checked = True Then
                        .lpnHeadeerXrLabel.Visible = True
                        .lpnDetailXrLabel.Visible = True
                        .lpnHeadeerXrLabel.Left = left
                        .lpnDetailXrLabel.Left = left
                        .lpnDetailXrLabel.Width += additionalWidth
                        .lpnHeadeerXrLabel.Width += additionalWidth
                        left += .lpnDetailXrLabel.Width
                    Else
                        .lpnHeadeerXrLabel.Visible = False
                        .lpnDetailXrLabel.Visible = False
                    End If
                    If Me.transportationLotCheckEdit.Checked = True Then
                        .lotHeadeerXrLabel.Visible = True
                        .lotDetailXrLabel.Visible = True
                        .lotHeadeerXrLabel.Left = left
                        .lotDetailXrLabel.Left = left
                        .lotDetailXrLabel.Width += additionalWidth
                        .lotHeadeerXrLabel.Width += additionalWidth
                        left += .lotDetailXrLabel.Width
                    Else
                        .lotHeadeerXrLabel.Visible = False
                    .lotDetailXrLabel.Visible = False
                    End If
                    If transportationExpirationDateCheckEdit.Checked = True Then
                        .expirationDateHeaderXrLabel.Visible = True
                        .expirationDateDetailXrLabel.Visible = True
                        .expirationDateHeaderXrLabel.Left = left
                        .expirationDateDetailXrLabel.Left = left
                        .expirationDateHeaderXrLabel.Width += additionalWidth
                        .expirationDateDetailXrLabel.Width += additionalWidth
                        left += .expirationDateDetailXrLabel.Width
                    Else
                        .expirationDateHeaderXrLabel.Visible = False
                        .expirationDateDetailXrLabel.Visible = False
                    End If
                    If Me.transportationQuantityCheckEdit.Checked = True Then
                        .quantityHeaderXrLabel.Visible = True
                        .quantityDetailXrLabel.Visible = True
                        .quantityFooterXrLabel.Visible = True
                        .quantityHeaderXrLabel.Left = left
                        .quantityDetailXrLabel.Left = left
                        .quantityFooterXrLabel.Left = left
                        .quantityDetailXrLabel.Width += additionalWidth
                        .quantityFooterXrLabel.Width += additionalWidth
                        .quantityHeaderXrLabel.Width += additionalWidth
                        left += .quantityDetailXrLabel.Width
                    Else
                        .quantityHeaderXrLabel.Visible = False
                        .quantityDetailXrLabel.Visible = False
                        .quantityFooterXrLabel.Visible = False
                    End If
                    If Me.transportationVendorCheckEdit.Checked = True Then
                        .vendorDetailXrLabel.Visible = True
                        .vendorHeaderXrLabel.Visible = True
                        .vendorHeaderXrLabel.Left = left
                        .vendorDetailXrLabel.Left = left
                        .vendorHeaderXrLabel.Width += additionalWidth
                        .vendorDetailXrLabel.Width += additionalWidth
                        left += .vendorDetailXrLabel.Width
                    Else
                        .vendorHeaderXrLabel.Visible = False
                        .vendorDetailXrLabel.Visible = False
                    End If
                    If Me.transportationCarrierCheckEdit.Checked = True Then
                        .carrierHeaderXrLabel.Visible = True
                        .carrierDetailXrLabel.Visible = True
                        .carrierHeaderXrLabel.Left = left
                        .carrierDetailXrLabel.Left = left
                        .carrierDetailXrLabel.Width += additionalWidth
                        .carrierHeaderXrLabel.Width += additionalWidth
                        left += .carrierDetailXrLabel.Width
                    Else
                        .carrierHeaderXrLabel.Visible = False
                        .carrierDetailXrLabel.Visible = False
                    End If
                    If Me.transportationTrailerCheckEdit.Checked = True Then
                        .trailerHeaderXrLabel.Visible = True
                        .trailerDetailXrLabel.Visible = True
                        .trailerHeaderXrLabel.Left = left
                        .trailerDetailXrLabel.Left = left
                        .trailerDetailXrLabel.Width += additionalWidth
                        .trailerHeaderXrLabel.Width += additionalWidth
                        left += .trailerDetailXrLabel.Width
                    Else
                        .trailerHeaderXrLabel.Visible = False
                        .trailerDetailXrLabel.Visible = False
                    End If
                    If Me.transportationSealCheckEdit.Checked = True Then
                        .sealHeaderXrLabel.Visible = True
                        .sealDetailXrLabel.Visible = True
                        .sealDetailXrLabel.Left = left
                        .sealHeaderXrLabel.Left = left
                        .sealDetailXrLabel.Width += additionalWidth
                        .sealHeaderXrLabel.Width += additionalWidth
                        left += .sealDetailXrLabel.Width
                    Else
                        .sealHeaderXrLabel.Visible = False
                        .sealDetailXrLabel.Visible = False
                    End If
                    .printDateXrPageInfo.Left = left - 185
                    .reportCriteriaXrLabel.Width = left - 190
                    .reportTitleXrLabel.Width = left
                    .headerXrPanel.Width = left
                    .footerXrPanel.Width = left
                    .pageNumberXrPageInfo.Left = left - 100
                End With
            Case "ShippingReturnsXtraReport"
                Dim report As TransportationXtraReport = CType(m_Report, TransportationXtraReport)
                With report
                    If Me.transportationDateCheckEdit.Checked = True Then
                        .dateDetailXrLabel.Visible = True
                        .dateHeaderXrLabel.Visible = True
                        .dateHeaderXrLabel.Left = left
                        .dateDetailXrLabel.Left = left
                        .dateHeaderXrLabel.Width += additionalWidth
                        .dateDetailXrLabel.Width += additionalWidth
                        left += .dateDetailXrLabel.Width
                    Else
                        .dateHeaderXrLabel.Visible = False
                        .dateDetailXrLabel.Visible = False
                    End If
                    If Me.transportationShiftCheckEdit.Checked = True Then
                        .shiftHeaderXrLabel.Visible = True
                        .shiftDetailXrLabel.Visible = True
                        .shiftHeaderXrLabel.Left = left
                        .shiftDetailXrLabel.Left = left
                        .shiftDetailXrLabel.Width += additionalWidth
                        .shiftHeaderXrLabel.Width += additionalWidth
                        left += .shiftDetailXrLabel.Width
                    Else
                        .shiftHeaderXrLabel.Visible = False
                        .shiftDetailXrLabel.Visible = False
                    End If
                    If Me.transportationCustomerCheckEdit.Checked = True Then
                        .customerNameHeaderXrLabel.Visible = True
                        .customerNameDetailXrLabel.Visible = True
                        .customerNameHeaderXrLabel.Left = left
                        .customerNameDetailXrLabel.Left = left
                        .customerNameDetailXrLabel.Width += additionalWidth
                        .customerNameHeaderXrLabel.Width += additionalWidth
                        left += .customerNameDetailXrLabel.Width
                    Else
                        .customerNameHeaderXrLabel.Visible = False
                        .customerNameDetailXrLabel.Visible = False
                    End If
                    If Me.transportationBolCheckEdit.Checked = True Then
                        .bolHeaderXrLabel.Visible = True
                        .bolDetailXrLabel.Visible = True
                        .bolDetailXrLabel.Left = left
                        .bolHeaderXrLabel.Left = left
                        .bolDetailXrLabel.Width += additionalWidth
                        .bolHeaderXrLabel.Width += additionalWidth
                        left += .bolDetailXrLabel.Width
                    Else
                        .bolHeaderXrLabel.Visible = False
                        .bolDetailXrLabel.Visible = False
                    End If
                    If Me.transportationPOCheckEdit.Checked = True Then
                        .poHeaderXrLabel.Visible = True
                        .poDetailXrLabel.Visible = True
                        .poHeaderXrLabel.Left = left
                        .poDetailXrLabel.Left = left
                        .poDetailXrLabel.Width += additionalWidth
                        .poHeaderXrLabel.Width += additionalWidth
                        left += .poDetailXrLabel.Width
                    Else
                        .poHeaderXrLabel.Visible = False
                        .poDetailXrLabel.Visible = False
                    End If
                    If Me.transportationDeliveryNoteCheckEdit.Checked = True Then
                        .deliveryNoteNumberHeaderXrLabel.Visible = True
                        .deliveryNoteNumberDetailXrLabel.Visible = True
                        .deliveryNoteNumberHeaderXrLabel.Left = left
                        .deliveryNoteNumberDetailXrLabel.Left = left
                        .deliveryNoteNumberDetailXrLabel.Width += additionalWidth
                        .deliveryNoteNumberHeaderXrLabel.Width += additionalWidth
                        left += .deliveryNoteNumberDetailXrLabel.Width
                    Else
                        .deliveryNoteNumberHeaderXrLabel.Visible = False
                        .deliveryNoteNumberDetailXrLabel.Visible = False
                    End If
                    If Me.transportationDestinationCheckEdit.Checked = True Then
                        .destinationHeaderXrLabel.Visible = True
                        .destinationDetailXrLabel.Visible = True
                        .destinationHeaderXrLabel.Left = left
                        .destinationDetailXrLabel.Left = left
                        .destinationDetailXrLabel.Width += additionalWidth
                        .destinationHeaderXrLabel.Width += additionalWidth
                        left += .destinationDetailXrLabel.Width
                    Else
                        .destinationHeaderXrLabel.Visible = False
                        .destinationDetailXrLabel.Visible = False
                    End If
                    If Me.transportationItemCheckEdit.Checked = True Then
                        .itemCodeHeaderXrLabel.Visible = True
                        .itemCodeDetailXrLabel.Visible = True
                        .itemCodeHeaderXrLabel.Left = left
                        .itemCodeDetailXrLabel.Left = left
                        .itemCodeDetailXrLabel.Width += additionalWidth
                        .itemCodeHeaderXrLabel.Width += additionalWidth
                        left += .itemCodeDetailXrLabel.Width
                    Else
                        .itemCodeHeaderXrLabel.Visible = False
                        .itemCodeDetailXrLabel.Visible = False
                    End If
                    If Me.transportationItemDescriptionCheckEdit.Checked = True Then
                        .itemDescriptionHeaderXrLabel.Visible = True
                        .itemDescriptionDetailXrLabel.Visible = True
                        .itemDescriptionHeaderXrLabel.Left = left
                        .itemDescriptionDetailXrLabel.Left = left
                        .itemDescriptionDetailXrLabel.Width += additionalWidth
                        .itemDescriptionHeaderXrLabel.Width += additionalWidth
                        left += .itemDescriptionDetailXrLabel.Width
                    Else
                        .itemDescriptionHeaderXrLabel.Visible = False
                        .itemDescriptionDetailXrLabel.Visible = False
                    End If
                    If Me.transportationLotCheckEdit.Checked = True Then
                        .lotHeadeerXrLabel.Visible = True
                        .lotDetailXrLabel.Visible = True
                        .lotHeadeerXrLabel.Left = left
                        .lotDetailXrLabel.Left = left
                        .lotDetailXrLabel.Width += additionalWidth
                        .lotHeadeerXrLabel.Width += additionalWidth
                        left += .lotDetailXrLabel.Width
                    Else
                        .lotHeadeerXrLabel.Visible = False
                        .lotDetailXrLabel.Visible = False
                    End If
                    If transportationExpirationDateCheckEdit.Checked = True Then
                        .expirationDateHeaderXrLabel.Visible = True
                        .expirationDateDetailXrLabel.Visible = True
                        .expirationDateHeaderXrLabel.Left = left
                        .expirationDateDetailXrLabel.Left = left
                        .expirationDateHeaderXrLabel.Width += additionalWidth
                        .expirationDateDetailXrLabel.Width += additionalWidth
                        left += .expirationDateDetailXrLabel.Width
                    Else
                        .expirationDateHeaderXrLabel.Visible = False
                        .expirationDateDetailXrLabel.Visible = False
                    End If
                    If Me.transportationQuantityCheckEdit.Checked = True Then
                        .quantityHeaderXrLabel.Visible = True
                        .quantityDetailXrLabel.Visible = True
                        .quantityFooterXrLabel.Visible = True
                        .quantityHeaderXrLabel.Left = left
                        .quantityDetailXrLabel.Left = left
                        .quantityFooterXrLabel.Left = left
                        .quantityDetailXrLabel.Width += additionalWidth
                        .quantityFooterXrLabel.Width += additionalWidth
                        .quantityHeaderXrLabel.Width += additionalWidth
                        left += .quantityDetailXrLabel.Width
                    Else
                        .quantityHeaderXrLabel.Visible = False
                        .quantityDetailXrLabel.Visible = False
                        .quantityFooterXrLabel.Visible = False
                    End If
                    If Me.transportationVendorCheckEdit.Checked = True Then
                        .vendorDetailXrLabel.Visible = True
                        .vendorHeaderXrLabel.Visible = True
                        .vendorHeaderXrLabel.Left = left
                        .vendorDetailXrLabel.Left = left
                        .vendorHeaderXrLabel.Width += additionalWidth
                        .vendorDetailXrLabel.Width += additionalWidth
                        left += .vendorDetailXrLabel.Width
                    Else
                        .vendorHeaderXrLabel.Visible = False
                        .vendorDetailXrLabel.Visible = False
                    End If
                    If Me.transportationCarrierCheckEdit.Checked = True Then
                        .carrierHeaderXrLabel.Visible = True
                        .carrierDetailXrLabel.Visible = True
                        .carrierHeaderXrLabel.Left = left
                        .carrierDetailXrLabel.Left = left
                        .carrierDetailXrLabel.Width += additionalWidth
                        .carrierHeaderXrLabel.Width += additionalWidth
                        left += .carrierDetailXrLabel.Width
                    Else
                        .carrierHeaderXrLabel.Visible = False
                        .carrierDetailXrLabel.Visible = False
                    End If
                    If Me.transportationTrailerCheckEdit.Checked = True Then
                        .trailerHeaderXrLabel.Visible = True
                        .trailerDetailXrLabel.Visible = True
                        .trailerHeaderXrLabel.Left = left
                        .trailerDetailXrLabel.Left = left
                        .trailerDetailXrLabel.Width += additionalWidth
                        .trailerHeaderXrLabel.Width += additionalWidth
                        left += .trailerDetailXrLabel.Width
                    Else
                        .trailerHeaderXrLabel.Visible = False
                        .trailerDetailXrLabel.Visible = False
                    End If
                    If Me.transportationSealCheckEdit.Checked = True Then
                        .sealHeaderXrLabel.Visible = True
                        .sealDetailXrLabel.Visible = True
                        .sealDetailXrLabel.Left = left
                        .sealHeaderXrLabel.Left = left
                        .sealDetailXrLabel.Width += additionalWidth
                        .sealHeaderXrLabel.Width += additionalWidth
                        left += .sealDetailXrLabel.Width
                    Else
                        .sealHeaderXrLabel.Visible = False
                        .sealDetailXrLabel.Visible = False
                    End If
                    .printDateXrPageInfo.Left = left - 185
                    .reportCriteriaXrLabel.Width = left - 190
                    .reportTitleXrLabel.Width = left
                    .headerXrPanel.Width = left
                    .footerXrPanel.Width = left
                    .pageNumberXrPageInfo.Left = left - 100
                End With
            Case "ReceivingXtraReport"
                Dim report As TransportationXtraReport = CType(m_Report, TransportationXtraReport)
                With report
                    If Me.transportationDateCheckEdit.Checked = True Then
                        .dateDetailXrLabel.Visible = True
                        .dateHeaderXrLabel.Visible = True
                        .dateHeaderXrLabel.Left = left
                        .dateDetailXrLabel.Left = left
                        .dateHeaderXrLabel.Width += additionalWidth
                        .dateDetailXrLabel.Width += additionalWidth
                        left += .dateDetailXrLabel.Width
                    Else
                        .dateHeaderXrLabel.Visible = False
                        .dateDetailXrLabel.Visible = False
                    End If
                    If Me.transportationShiftCheckEdit.Checked = True Then
                        .shiftHeaderXrLabel.Visible = True
                        .shiftDetailXrLabel.Visible = True
                        .shiftHeaderXrLabel.Left = left
                        .shiftDetailXrLabel.Left = left
                        .shiftDetailXrLabel.Width += additionalWidth
                        .shiftHeaderXrLabel.Width += additionalWidth
                        left += .shiftDetailXrLabel.Width
                    Else
                        .shiftHeaderXrLabel.Visible = False
                        .shiftDetailXrLabel.Visible = False
                    End If
                    If transportationCustomerCheckEdit.Checked = True Then
                        .customerNameHeaderXrLabel.Visible = True
                        .customerNameDetailXrLabel.Visible = True
                        .customerNameHeaderXrLabel.Left = left
                        .customerNameDetailXrLabel.Left = left
                        .customerNameDetailXrLabel.Width += additionalWidth
                        .customerNameHeaderXrLabel.Width += additionalWidth
                        left += .customerNameDetailXrLabel.Width
                    Else
                        .customerNameHeaderXrLabel.Visible = False
                        .customerNameDetailXrLabel.Visible = False
                    End If
                    If Me.transportationBolCheckEdit.Checked = True Then
                        .bolHeaderXrLabel.Visible = True
                        .bolDetailXrLabel.Visible = True
                        .bolDetailXrLabel.Left = left
                        .bolHeaderXrLabel.Left = left
                        .bolDetailXrLabel.Width += additionalWidth
                        .bolHeaderXrLabel.Width += additionalWidth
                        left += .bolDetailXrLabel.Width
                    Else
                        .bolHeaderXrLabel.Visible = False
                        .bolDetailXrLabel.Visible = False
                    End If
                    If Me.transportationPOCheckEdit.Checked = True Then
                        .poHeaderXrLabel.Visible = True
                        .poDetailXrLabel.Visible = True
                        .poHeaderXrLabel.Left = left
                        .poDetailXrLabel.Left = left
                        .poDetailXrLabel.Width += additionalWidth
                        .poHeaderXrLabel.Width += additionalWidth
                        left += .poDetailXrLabel.Width
                    Else
                        .poHeaderXrLabel.Visible = False
                        .poDetailXrLabel.Visible = False
                    End If
                    If Me.transportationDeliveryNoteCheckEdit.Checked = True Then
                        .deliveryNoteNumberHeaderXrLabel.Visible = True
                        .deliveryNoteNumberDetailXrLabel.Visible = True
                        .deliveryNoteNumberHeaderXrLabel.Left = left
                        .deliveryNoteNumberDetailXrLabel.Left = left
                        .deliveryNoteNumberDetailXrLabel.Width += additionalWidth
                        .deliveryNoteNumberHeaderXrLabel.Width += additionalWidth
                        left += .deliveryNoteNumberDetailXrLabel.Width
                    Else
                        .deliveryNoteNumberHeaderXrLabel.Visible = False
                        .deliveryNoteNumberDetailXrLabel.Visible = False
                    End If
                    If Me.transportationDestinationCheckEdit.Checked = True Then
                        .destinationHeaderXrLabel.Visible = True
                        .destinationDetailXrLabel.Visible = True
                        .destinationHeaderXrLabel.Left = left
                        .destinationDetailXrLabel.Left = left
                        .destinationDetailXrLabel.Width += additionalWidth
                        .destinationHeaderXrLabel.Width += additionalWidth
                        left += .destinationDetailXrLabel.Width
                    Else
                        .destinationHeaderXrLabel.Visible = False
                        .destinationDetailXrLabel.Visible = False
                    End If
                    If Me.transportationItemCheckEdit.Checked = True Then
                        .itemCodeHeaderXrLabel.Visible = True
                        .itemCodeDetailXrLabel.Visible = True
                        .itemCodeHeaderXrLabel.Left = left
                        .itemCodeDetailXrLabel.Left = left
                        .itemCodeDetailXrLabel.Width += additionalWidth
                        .itemCodeHeaderXrLabel.Width += additionalWidth
                        left += .itemCodeDetailXrLabel.Width
                    Else
                        .itemCodeHeaderXrLabel.Visible = False
                        .itemCodeDetailXrLabel.Visible = False
                    End If
                    If Me.transportationItemDescriptionCheckEdit.Checked = True Then
                        .itemDescriptionHeaderXrLabel.Visible = True
                        .itemDescriptionDetailXrLabel.Visible = True
                        .itemDescriptionHeaderXrLabel.Left = left
                        .itemDescriptionDetailXrLabel.Left = left
                        .itemDescriptionDetailXrLabel.Width += additionalWidth
                        .itemDescriptionHeaderXrLabel.Width += additionalWidth
                        left += .itemDescriptionDetailXrLabel.Width
                    Else
                        .itemDescriptionHeaderXrLabel.Visible = False
                        .itemDescriptionDetailXrLabel.Visible = False
                    End If
                    If Me.transportationLotCheckEdit.Checked = True Then
                        .lotHeadeerXrLabel.Visible = True
                        .lotDetailXrLabel.Visible = True
                        .lotHeadeerXrLabel.Left = left
                        .lotDetailXrLabel.Left = left
                        .lotDetailXrLabel.Width += additionalWidth
                        .lotHeadeerXrLabel.Width += additionalWidth
                        left += .lotDetailXrLabel.Width
                    Else
                        .lotHeadeerXrLabel.Visible = False
                        .lotDetailXrLabel.Visible = False
                    End If
                    If transportationExpirationDateCheckEdit.Checked = True Then
                        .expirationDateHeaderXrLabel.Visible = True
                        .expirationDateDetailXrLabel.Visible = True
                        .expirationDateHeaderXrLabel.Left = left
                        .expirationDateDetailXrLabel.Left = left
                        .expirationDateHeaderXrLabel.Width += additionalWidth
                        .expirationDateDetailXrLabel.Width += additionalWidth
                        left += .expirationDateDetailXrLabel.Width
                    Else
                        .expirationDateHeaderXrLabel.Visible = False
                        .expirationDateDetailXrLabel.Visible = False
                    End If
                    If Me.transportationQuantityCheckEdit.Checked = True Then
                        .quantityHeaderXrLabel.Visible = True
                        .quantityDetailXrLabel.Visible = True
                        .quantityFooterXrLabel.Visible = True
                        .quantityHeaderXrLabel.Left = left
                        .quantityDetailXrLabel.Left = left
                        .quantityFooterXrLabel.Left = left
                        .quantityDetailXrLabel.Width += additionalWidth
                        .quantityFooterXrLabel.Width += additionalWidth
                        .quantityHeaderXrLabel.Width += additionalWidth
                        left += .quantityDetailXrLabel.Width
                    Else
                        .quantityHeaderXrLabel.Visible = False
                        .quantityDetailXrLabel.Visible = False
                        .quantityFooterXrLabel.Visible = False
                    End If
                    If Me.transportationVendorCheckEdit.Checked = True Then
                        .vendorDetailXrLabel.Visible = True
                        .vendorHeaderXrLabel.Visible = True
                        .vendorHeaderXrLabel.Left = left
                        .vendorDetailXrLabel.Left = left
                        .vendorHeaderXrLabel.Width += additionalWidth
                        .vendorDetailXrLabel.Width += additionalWidth
                        left += .vendorDetailXrLabel.Width
                    Else
                        .vendorHeaderXrLabel.Visible = False
                        .vendorDetailXrLabel.Visible = False
                    End If
                    If Me.transportationCarrierCheckEdit.Checked = True Then
                        .carrierHeaderXrLabel.Visible = True
                        .carrierDetailXrLabel.Visible = True
                        .carrierHeaderXrLabel.Left = left
                        .carrierDetailXrLabel.Left = left
                        .carrierDetailXrLabel.Width += additionalWidth
                        .carrierHeaderXrLabel.Width += additionalWidth
                        left += .carrierDetailXrLabel.Width
                    Else
                        .carrierHeaderXrLabel.Visible = False
                        .carrierDetailXrLabel.Visible = False
                    End If
                    If Me.transportationTrailerCheckEdit.Checked = True Then
                        .trailerHeaderXrLabel.Visible = True
                        .trailerDetailXrLabel.Visible = True
                        .trailerHeaderXrLabel.Left = left
                        .trailerDetailXrLabel.Left = left
                        .trailerDetailXrLabel.Width += additionalWidth
                        .trailerHeaderXrLabel.Width += additionalWidth
                        left += .trailerDetailXrLabel.Width
                    Else
                        .trailerHeaderXrLabel.Visible = False
                        .trailerDetailXrLabel.Visible = False
                    End If
                    If Me.transportationSealCheckEdit.Checked = True Then
                        .sealHeaderXrLabel.Visible = True
                        .sealDetailXrLabel.Visible = True
                        .sealDetailXrLabel.Left = left
                        .sealHeaderXrLabel.Left = left
                        .sealDetailXrLabel.Width += additionalWidth
                        .sealHeaderXrLabel.Width += additionalWidth
                        left += .sealDetailXrLabel.Width
                    Else
                        .sealHeaderXrLabel.Visible = False
                        .sealDetailXrLabel.Visible = False
                    End If
                    .printDateXrPageInfo.Left = left - 185
                    .reportCriteriaXrLabel.Width = left - 190
                    .reportTitleXrLabel.Width = left
                    .headerXrPanel.Width = left
                    .footerXrPanel.Width = left
                    .pageNumberXrPageInfo.Left = left - 100
                End With
            Case "ReceivingReturnsXtraReport"
                Dim report As TransportationXtraReport = CType(m_Report, TransportationXtraReport)
                With report
                    If Me.transportationDateCheckEdit.Checked = True Then
                        .dateDetailXrLabel.Visible = True
                        .dateHeaderXrLabel.Visible = True
                        .dateHeaderXrLabel.Left = left
                        .dateDetailXrLabel.Left = left
                        .dateHeaderXrLabel.Width += additionalWidth
                        .dateDetailXrLabel.Width += additionalWidth
                        left += .dateDetailXrLabel.Width
                    Else
                        .dateHeaderXrLabel.Visible = False
                        .dateDetailXrLabel.Visible = False
                    End If
                    If Me.transportationShiftCheckEdit.Checked = True Then
                        .shiftHeaderXrLabel.Visible = True
                        .shiftDetailXrLabel.Visible = True
                        .shiftHeaderXrLabel.Left = left
                        .shiftDetailXrLabel.Left = left
                        .shiftDetailXrLabel.Width += additionalWidth
                        .shiftHeaderXrLabel.Width += additionalWidth
                        left += .shiftDetailXrLabel.Width
                    Else
                        .shiftHeaderXrLabel.Visible = False
                        .shiftDetailXrLabel.Visible = False
                    End If
                    If Me.transportationCustomerCheckEdit.Checked = True Then
                        .customerNameHeaderXrLabel.Visible = True
                        .customerNameDetailXrLabel.Visible = True
                        .customerNameHeaderXrLabel.Left = left
                        .customerNameDetailXrLabel.Left = left
                        .customerNameDetailXrLabel.Width += additionalWidth
                        .customerNameHeaderXrLabel.Width += additionalWidth
                        left += .customerNameDetailXrLabel.Width
                    Else
                        .customerNameHeaderXrLabel.Visible = False
                        .customerNameDetailXrLabel.Visible = False
                    End If
                    If Me.transportationBolCheckEdit.Checked = True Then
                        .bolHeaderXrLabel.Visible = True
                        .bolDetailXrLabel.Visible = True
                        .bolDetailXrLabel.Left = left
                        .bolHeaderXrLabel.Left = left
                        .bolDetailXrLabel.Width += additionalWidth
                        .bolHeaderXrLabel.Width += additionalWidth
                        left += .bolDetailXrLabel.Width
                    Else
                        .bolHeaderXrLabel.Visible = False
                        .bolDetailXrLabel.Visible = False
                    End If
                    If Me.transportationPOCheckEdit.Checked = True Then
                        .poHeaderXrLabel.Visible = True
                        .poDetailXrLabel.Visible = True
                        .poHeaderXrLabel.Left = left
                        .poDetailXrLabel.Left = left
                        .poDetailXrLabel.Width += additionalWidth
                        .poHeaderXrLabel.Width += additionalWidth
                        left += .poDetailXrLabel.Width
                    Else
                        .poHeaderXrLabel.Visible = False
                        .poDetailXrLabel.Visible = False
                    End If
                    If Me.transportationDeliveryNoteCheckEdit.Checked = True Then
                        .deliveryNoteNumberHeaderXrLabel.Visible = True
                        .deliveryNoteNumberDetailXrLabel.Visible = True
                        .deliveryNoteNumberHeaderXrLabel.Left = left
                        .deliveryNoteNumberDetailXrLabel.Left = left
                        .deliveryNoteNumberDetailXrLabel.Width += additionalWidth
                        .deliveryNoteNumberHeaderXrLabel.Width += additionalWidth
                        left += .deliveryNoteNumberDetailXrLabel.Width
                    Else
                        .deliveryNoteNumberHeaderXrLabel.Visible = False
                        .deliveryNoteNumberDetailXrLabel.Visible = False
                    End If
                    If Me.transportationDestinationCheckEdit.Checked = True Then
                        .destinationHeaderXrLabel.Visible = True
                        .destinationDetailXrLabel.Visible = True
                        .destinationHeaderXrLabel.Left = left
                        .destinationDetailXrLabel.Left = left
                        .destinationDetailXrLabel.Width += additionalWidth
                        .destinationHeaderXrLabel.Width += additionalWidth
                        left += .destinationDetailXrLabel.Width
                    Else
                        .destinationHeaderXrLabel.Visible = False
                        .destinationDetailXrLabel.Visible = False
                    End If
                    If Me.transportationItemCheckEdit.Checked = True Then
                        .itemCodeHeaderXrLabel.Visible = True
                        .itemCodeDetailXrLabel.Visible = True
                        .itemCodeHeaderXrLabel.Left = left
                        .itemCodeDetailXrLabel.Left = left
                        .itemCodeDetailXrLabel.Width += additionalWidth
                        .itemCodeHeaderXrLabel.Width += additionalWidth
                        left += .itemCodeDetailXrLabel.Width
                    Else
                        .itemCodeHeaderXrLabel.Visible = False
                        .itemCodeDetailXrLabel.Visible = False
                    End If
                    If Me.transportationItemDescriptionCheckEdit.Checked = True Then
                        .itemDescriptionHeaderXrLabel.Visible = True
                        .itemDescriptionDetailXrLabel.Visible = True
                        .itemDescriptionHeaderXrLabel.Left = left
                        .itemDescriptionDetailXrLabel.Left = left
                        .itemDescriptionDetailXrLabel.Width += additionalWidth
                        .itemDescriptionHeaderXrLabel.Width += additionalWidth
                        left += .itemDescriptionDetailXrLabel.Width
                    Else
                        .itemDescriptionHeaderXrLabel.Visible = False
                        .itemDescriptionDetailXrLabel.Visible = False
                    End If
                    If Me.transportationLotCheckEdit.Checked = True Then
                        .lotHeadeerXrLabel.Visible = True
                        .lotDetailXrLabel.Visible = True
                        .lotHeadeerXrLabel.Left = left
                        .lotDetailXrLabel.Left = left
                        .lotDetailXrLabel.Width += additionalWidth
                        .lotHeadeerXrLabel.Width += additionalWidth
                        left += .lotDetailXrLabel.Width
                    Else
                        .lotHeadeerXrLabel.Visible = False
                        .lotDetailXrLabel.Visible = False
                    End If
                    If transportationExpirationDateCheckEdit.Checked = True Then
                        .expirationDateHeaderXrLabel.Visible = True
                        .expirationDateDetailXrLabel.Visible = True
                        .expirationDateHeaderXrLabel.Left = left
                        .expirationDateDetailXrLabel.Left = left
                        .expirationDateHeaderXrLabel.Width += additionalWidth
                        .expirationDateDetailXrLabel.Width += additionalWidth
                        left += .expirationDateDetailXrLabel.Width
                    Else
                        .expirationDateHeaderXrLabel.Visible = False
                        .expirationDateDetailXrLabel.Visible = False
                    End If
                    If Me.transportationQuantityCheckEdit.Checked = True Then
                        .quantityHeaderXrLabel.Visible = True
                        .quantityDetailXrLabel.Visible = True
                        .quantityFooterXrLabel.Visible = True
                        .quantityHeaderXrLabel.Left = left
                        .quantityDetailXrLabel.Left = left
                        .quantityFooterXrLabel.Left = left
                        .quantityDetailXrLabel.Width += additionalWidth
                        .quantityFooterXrLabel.Width += additionalWidth
                        .quantityHeaderXrLabel.Width += additionalWidth
                        left += .quantityDetailXrLabel.Width
                    Else
                        .quantityHeaderXrLabel.Visible = False
                        .quantityDetailXrLabel.Visible = False
                        .quantityFooterXrLabel.Visible = False
                    End If
                    If Me.transportationVendorCheckEdit.Checked = True Then
                        .vendorDetailXrLabel.Visible = True
                        .vendorHeaderXrLabel.Visible = True
                        .vendorHeaderXrLabel.Left = left
                        .vendorDetailXrLabel.Left = left
                        .vendorHeaderXrLabel.Width += additionalWidth
                        .vendorDetailXrLabel.Width += additionalWidth
                        left += .vendorDetailXrLabel.Width
                    Else
                        .vendorHeaderXrLabel.Visible = False
                        .vendorDetailXrLabel.Visible = False
                    End If
                    If Me.transportationCarrierCheckEdit.Checked = True Then
                        .carrierHeaderXrLabel.Visible = True
                        .carrierDetailXrLabel.Visible = True
                        .carrierHeaderXrLabel.Left = left
                        .carrierDetailXrLabel.Left = left
                        .carrierDetailXrLabel.Width += additionalWidth
                        .carrierHeaderXrLabel.Width += additionalWidth
                        left += .carrierDetailXrLabel.Width
                    Else
                        .carrierHeaderXrLabel.Visible = False
                        .carrierDetailXrLabel.Visible = False
                    End If
                    If Me.transportationTrailerCheckEdit.Checked = True Then
                        .trailerHeaderXrLabel.Visible = True
                        .trailerDetailXrLabel.Visible = True
                        .trailerHeaderXrLabel.Left = left
                        .trailerDetailXrLabel.Left = left
                        .trailerDetailXrLabel.Width += additionalWidth
                        .trailerHeaderXrLabel.Width += additionalWidth
                        left += .trailerDetailXrLabel.Width
                    Else
                        .trailerHeaderXrLabel.Visible = False
                        .trailerDetailXrLabel.Visible = False
                    End If
                    If Me.transportationSealCheckEdit.Checked = True Then
                        .sealHeaderXrLabel.Visible = True
                        .sealDetailXrLabel.Visible = True
                        .sealDetailXrLabel.Left = left
                        .sealHeaderXrLabel.Left = left
                        .sealDetailXrLabel.Width += additionalWidth
                        .sealHeaderXrLabel.Width += additionalWidth
                        left += .sealDetailXrLabel.Width
                    Else
                        .sealHeaderXrLabel.Visible = False
                        .sealDetailXrLabel.Visible = False
                    End If
                    .printDateXrPageInfo.Left = left - 185
                    .reportCriteriaXrLabel.Width = left - 190
                    .reportTitleXrLabel.Width = left
                    .headerXrPanel.Width = left
                    .footerXrPanel.Width = left
                    .pageNumberXrPageInfo.Left = left - 100
                End With
            Case "InventoryAdjustmentXtraReport"
                Dim report As InventoryXtraReport = CType(m_Report, InventoryXtraReport)
                With report
                    If Me.inventoryDateCheckEdit.Checked = True Then
                        .dateDetailXrLabel.Visible = True
                        .dateHeaderXrLabel.Visible = True
                        .dateDetailXrLabel.Left = left
                        .dateHeaderXrLabel.Left = left
                        .dateDetailXrLabel.Width += additionalWidth
                        .dateHeaderXrLabel.Width += additionalWidth
                        left += .dateDetailXrLabel.Width
                    Else
                        .dateHeaderXrLabel.Visible = False
                        .dateDetailXrLabel.Visible = False
                    End If
                    If Me.inventoryCustomerCheckEdit.Checked = True Then
                        .customerNameHeaderXrLabel.Visible = True
                        .customerNameDetailXrLabel.Visible = True
                        .customerNameHeaderXrLabel.Left = left
                        .customerNameDetailXrLabel.Left = left
                        .customerNameDetailXrLabel.Width += additionalWidth
                        .customerNameHeaderXrLabel.Width += additionalWidth
                        left += .customerNameDetailXrLabel.Width
                    Else
                        .customerNameHeaderXrLabel.Visible = False
                        .customerNameDetailXrLabel.Visible = False
                    End If
                    If Me.inventoryItemCheckEdit.Checked = True Then
                        .itemCodeDetailXrLabel.Visible = True
                        .itemCodeHeaderXrLabel.Visible = True
                        .itemCodeHeaderXrLabel.Left = left
                        .itemCodeDetailXrLabel.Left = left
                        .itemCodeDetailXrLabel.Width += additionalWidth
                        .itemCodeHeaderXrLabel.Width += additionalWidth
                        left += .itemCodeDetailXrLabel.Width
                    Else
                        .itemCodeHeaderXrLabel.Visible = False
                        .itemCodeDetailXrLabel.Visible = False
                    End If
                    If Me.inventoryAdjustmentCheckEdit.Checked = True Then
                        .quantityDetailXrLabel.Visible = True
                        .quantityHeaderXrLabel.Visible = True
                        .quantityHeaderXrLabel.Left = left
                        .quantityDetailXrLabel.Left = left
                        .quantityHeaderXrLabel.Width += additionalWidth
                        .quantityDetailXrLabel.Width += additionalWidth
                        left += .quantityDetailXrLabel.Width
                    Else
                        .quantityHeaderXrLabel.Visible = False
                        .quantityDetailXrLabel.Visible = False
                    End If
                    If Me.inventoryAdjustmentReasonCheckEdit.Checked = True Then
                        .reasonHeaderXrLabel.Visible = True
                        .reasonDetailXrLabel.Visible = True
                        .reasonHeaderXrLabel.Left = left
                        .reasonDetailXrLabel.Left = left
                        .reasonDetailXrLabel.Width += additionalWidth
                        .reasonHeaderXrLabel.Width += additionalWidth
                        left += .reasonDetailXrLabel.Width
                    Else
                        .reasonHeaderXrLabel.Visible = False
                        .reasonDetailXrLabel.Visible = False
                    End If
                    If Me.inventoryInventoryByPalletCheckEdit.Checked = True Then
                        .byPalletDetailXrLabel.Visible = True
                        .byPalletHeaderXrLabel.Visible = True
                        .byPalletHeaderXrLabel.Left = left
                        .byPalletDetailXrLabel.Left = left
                        .byPalletDetailXrLabel.Width += additionalWidth
                        .byPalletHeaderXrLabel.Width += additionalWidth
                        left += .byPalletDetailXrLabel.Width
                    Else
                        .byPalletHeaderXrLabel.Visible = False
                        .byPalletDetailXrLabel.Visible = False
                    End If
                    If Me.inventoryItemDescriptionCheckEdit.Checked = True Then
                        .itemDescriptionHeaderXrLabel.Visible = True
                        .itemDescriptionDetailXrLabel.Visible = True
                        .itemDescriptionHeaderXrLabel.Left = left
                        .itemDescriptionDetailXrLabel.Left = left
                        .itemDescriptionDetailXrLabel.Width += additionalWidth
                        .itemDescriptionHeaderXrLabel.Width += additionalWidth
                        left += .itemDescriptionDetailXrLabel.Width
                    Else
                        .itemDescriptionHeaderXrLabel.Visible = False
                        .itemDescriptionDetailXrLabel.Visible = False
                    End If
                    If Me.inventoryItemTypeCheckEdit.Checked = True Then
                        .itemTypeHeaderXrLabel.Visible = True
                        .itemTypeDetailXrLabel.Visible = True
                        .itemTypeHeaderXrLabel.Left = left
                        .itemTypeDetailXrLabel.Left = left
                        .itemTypeDetailXrLabel.Width += additionalWidth
                        .itemTypeHeaderXrLabel.Width += additionalWidth
                        left += .itemTypeDetailXrLabel.Width
                    Else
                        .itemTypeHeaderXrLabel.Visible = False
                        .itemTypeDetailXrLabel.Visible = False
                    End If
                    If Me.RMItemCodeCheckEdit.Checked = True Then
                        .lowestRMItemCodeXrLabel.Visible = True
                        .RMitemCodeDetailXrLabel.Visible = True
                        .lowestRMItemCodeXrLabel.Left = left
                        .RMitemCodeDetailXrLabel.Left = left
                        .RMitemCodeDetailXrLabel.Width += additionalWidth
                        .lowestRMItemCodeXrLabel.Width += additionalWidth
                        left += .RMitemCodeDetailXrLabel.Width
                    Else
                        .lowestRMItemCodeXrLabel.Visible = False
                        .RMitemCodeDetailXrLabel.Visible = False
                    End If
                    If Me.RMItemDescriptionCheckEdit.Checked = True Then
                        .lowestRMDescriptionXrLabel.Visible = True
                        .RMitemDescriptionDetailXrLabel.Visible = True
                        .lowestRMDescriptionXrLabel.Left = left
                        .RMitemDescriptionDetailXrLabel.Left = left
                        .RMitemDescriptionDetailXrLabel.Width += additionalWidth
                        .lowestRMDescriptionXrLabel.Width += additionalWidth
                        left += .RMitemDescriptionDetailXrLabel.Width
                    Else
                        .lowestRMDescriptionXrLabel.Visible = False
                        .RMitemDescriptionDetailXrLabel.Visible = False
                    End If
                    If Me.UOMCheckEdit.Checked Then
                        .UOMHeaderXrLabel.Visible = True
                        .UOMDetailXrLabel.Visible = True
                        .UOMHeaderXrLabel.LeftF = left
                        .UOMDetailXrLabel.LeftF = left
                        .UOMHeaderXrLabel.WidthF += additionalWidth
                        .UOMDetailXrLabel.WidthF += additionalWidth
                        left += .UOMDetailXrLabel.Width
                    Else
                        .UOMHeaderXrLabel.Visible = False
                        .UOMDetailXrLabel.Visible = False
                    End If
                    .printDateXrPageInfo.Left = left - 185
                    .reportCriteriaXrLabel.Width = left - 190
                    .reportTitleXrLabel.Width = left
                    .headerXrPanel.Width = left
                    .pageNumberXrPageInfo.Left = left - 100
                End With
            Case "PhysicalInventoryXtraReport"
                Dim report As InventoryXtraReport = CType(m_Report, InventoryXtraReport)
                With report
                    If Me.inventoryDateCheckEdit.Checked = True Then
                        .dateDetailXrLabel.Visible = True
                        .dateHeaderXrLabel.Visible = True
                        .dateDetailXrLabel.Left = left
                        .dateHeaderXrLabel.Left = left
                        .dateDetailXrLabel.Width += additionalWidth
                        .dateHeaderXrLabel.Width += additionalWidth
                        left += .dateDetailXrLabel.Width
                    Else
                        .dateHeaderXrLabel.Visible = False
                        .dateDetailXrLabel.Visible = False
                    End If
                    If Me.inventoryCustomerCheckEdit.Checked = True Then
                        .customerNameHeaderXrLabel.Visible = True
                        .customerNameDetailXrLabel.Visible = True
                        .customerNameHeaderXrLabel.Left = left
                        .customerNameDetailXrLabel.Left = left
                        .customerNameDetailXrLabel.Width += additionalWidth
                        .customerNameHeaderXrLabel.Width += additionalWidth
                        left += .customerNameDetailXrLabel.Width
                    Else
                        .customerNameHeaderXrLabel.Visible = False
                        .customerNameDetailXrLabel.Visible = False
                    End If
                    If Me.inventoryItemCheckEdit.Checked = True Then
                        .itemCodeDetailXrLabel.Visible = True
                        .itemCodeHeaderXrLabel.Visible = True
                        .itemCodeHeaderXrLabel.Left = left
                        .itemCodeDetailXrLabel.Left = left
                        .itemCodeDetailXrLabel.Width += additionalWidth
                        .itemCodeHeaderXrLabel.Width += additionalWidth
                        left += .itemCodeDetailXrLabel.Width
                    Else
                        .itemCodeHeaderXrLabel.Visible = False
                        .itemCodeDetailXrLabel.Visible = False
                    End If
                    If Me.inventoryItemDescriptionCheckEdit.Checked = True Then
                        .itemDescriptionHeaderXrLabel.Visible = True
                        .itemDescriptionDetailXrLabel.Visible = True
                        .itemDescriptionHeaderXrLabel.Left = left
                        .itemDescriptionDetailXrLabel.Left = left
                        .itemDescriptionDetailXrLabel.Width += additionalWidth
                        .itemDescriptionHeaderXrLabel.Width += additionalWidth
                        left += .itemDescriptionDetailXrLabel.Width
                    Else
                        .itemDescriptionHeaderXrLabel.Visible = False
                        .itemDescriptionDetailXrLabel.Visible = False
                    End If
                    If Me.inventoryItemTypeCheckEdit.Checked = True Then
                        .itemTypeHeaderXrLabel.Visible = True
                        .itemTypeDetailXrLabel.Visible = True
                        .itemTypeHeaderXrLabel.Left = left
                        .itemTypeDetailXrLabel.Left = left
                        .itemTypeDetailXrLabel.Width += additionalWidth
                        .itemTypeHeaderXrLabel.Width += additionalWidth
                        left += .itemTypeDetailXrLabel.Width
                    Else
                        .itemTypeHeaderXrLabel.Visible = False
                        .itemTypeDetailXrLabel.Visible = False
                    End If
                    If Me.inventoryCurrentInventoryCheckEdit.Checked = True Then
                        .quantityDetailXrLabel.Visible = True
                        .quantityHeaderXrLabel.Visible = True
                        .quantityHeaderXrLabel.Left = left
                        .quantityDetailXrLabel.Left = left
                        .quantityHeaderXrLabel.Width += additionalWidth
                        .quantityDetailXrLabel.Width += additionalWidth
                        left += .quantityDetailXrLabel.Width
                    Else
                        .quantityHeaderXrLabel.Visible = False
                        .quantityDetailXrLabel.Visible = False
                    End If
                    If Me.inventoryAdjustmentReasonCheckEdit.Checked = True Then
                        .reasonHeaderXrLabel.Visible = True
                        .reasonDetailXrLabel.Visible = True
                        .reasonHeaderXrLabel.Left = left
                        .reasonDetailXrLabel.Left = left
                        .reasonDetailXrLabel.Width += additionalWidth
                        .reasonHeaderXrLabel.Width += additionalWidth
                        left += .reasonDetailXrLabel.Width
                    Else
                        .reasonHeaderXrLabel.Visible = False
                        .reasonDetailXrLabel.Visible = False
                    End If
                    If Me.inventoryInventoryByPalletCheckEdit.Checked = True Then
                        .byPalletDetailXrLabel.Visible = True
                        .byPalletHeaderXrLabel.Visible = True
                        .byPalletHeaderXrLabel.Left = left
                        .byPalletDetailXrLabel.Left = left
                        .byPalletDetailXrLabel.Width += additionalWidth
                        .byPalletHeaderXrLabel.Width += additionalWidth
                        left += .byPalletDetailXrLabel.Width
                    Else
                        .byPalletHeaderXrLabel.Visible = False
                        .byPalletDetailXrLabel.Visible = False
                    End If
                    If Me.RMItemCodeCheckEdit.Checked = True Then
                        .lowestRMItemCodeXrLabel.Visible = True
                        .RMitemCodeDetailXrLabel.Visible = True
                        .lowestRMItemCodeXrLabel.Left = left
                        .RMitemCodeDetailXrLabel.Left = left
                        .RMitemCodeDetailXrLabel.Width += additionalWidth
                        .lowestRMItemCodeXrLabel.Width += additionalWidth
                        left += .RMitemCodeDetailXrLabel.Width
                    Else
                        .lowestRMItemCodeXrLabel.Visible = False
                        .RMitemCodeDetailXrLabel.Visible = False
                    End If
                    If Me.RMItemDescriptionCheckEdit.Checked = True Then
                        .lowestRMDescriptionXrLabel.Visible = True
                        .RMitemDescriptionDetailXrLabel.Visible = True
                        .lowestRMDescriptionXrLabel.Left = left
                        .RMitemDescriptionDetailXrLabel.Left = left
                        .RMitemDescriptionDetailXrLabel.Width += additionalWidth
                        .lowestRMDescriptionXrLabel.Width += additionalWidth
                        left += .RMitemDescriptionDetailXrLabel.Width
                    Else
                        .lowestRMDescriptionXrLabel.Visible = False
                        .RMitemDescriptionDetailXrLabel.Visible = False
                    End If
                    If Me.UOMCheckEdit.Checked Then
                        .UOMHeaderXrLabel.Visible = True
                        .UOMDetailXrLabel.Visible = True
                        .UOMHeaderXrLabel.LeftF = left
                        .UOMDetailXrLabel.LeftF = left
                        .UOMHeaderXrLabel.WidthF += additionalWidth
                        .UOMDetailXrLabel.WidthF += additionalWidth
                        left += .UOMDetailXrLabel.Width
                    Else
                        .UOMHeaderXrLabel.Visible = False
                        .UOMDetailXrLabel.Visible = False
                    End If
                    .printDateXrPageInfo.Left = left - 185
                    .reportCriteriaXrLabel.Width = left - 190
                    .reportTitleXrLabel.Width = left
                    .headerXrPanel.Width = left
                    .pageNumberXrPageInfo.Left = left - 100
                End With
            Case "CurrentInventoryXtraReport"
                Dim report As InventoryXtraReport = CType(m_Report, InventoryXtraReport)
                With report
                    If Me.inventoryDateCheckEdit.Checked = True Then
                        .dateDetailXrLabel.Visible = True
                        .dateHeaderXrLabel.Visible = True
                        .dateDetailXrLabel.Left = left
                        .dateHeaderXrLabel.Left = left
                        .dateDetailXrLabel.Width += additionalWidth
                        .dateHeaderXrLabel.Width += additionalWidth
                        left += .dateDetailXrLabel.Width
                    Else
                        .dateHeaderXrLabel.Visible = False
                        .dateDetailXrLabel.Visible = False
                    End If
                    If Me.inventoryCustomerCheckEdit.Checked = True Then
                        .customerNameHeaderXrLabel.Visible = True
                        .customerNameDetailXrLabel.Visible = True
                        .customerNameHeaderXrLabel.Left = left
                        .customerNameDetailXrLabel.Left = left
                        .customerNameDetailXrLabel.Width += additionalWidth
                        .customerNameHeaderXrLabel.Width += additionalWidth
                        left += .customerNameDetailXrLabel.Width
                    Else
                        .customerNameHeaderXrLabel.Visible = False
                        .customerNameDetailXrLabel.Visible = False
                    End If
                    If Me.inventoryItemCheckEdit.Checked = True Then
                        .itemCodeDetailXrLabel.Visible = True
                        .itemCodeHeaderXrLabel.Visible = True
                        .itemCodeHeaderXrLabel.Left = left
                        .itemCodeDetailXrLabel.Left = left
                        .itemCodeDetailXrLabel.Width += additionalWidth
                        .itemCodeHeaderXrLabel.Width += additionalWidth
                        left += .itemCodeDetailXrLabel.Width
                    Else
                        .itemCodeHeaderXrLabel.Visible = False
                        .itemCodeDetailXrLabel.Visible = False
                    End If
                    If Me.inventoryItemDescriptionCheckEdit.Checked = True Then
                        .itemDescriptionHeaderXrLabel.Visible = True
                        .itemDescriptionDetailXrLabel.Visible = True
                        .itemDescriptionHeaderXrLabel.Left = left
                        .itemDescriptionDetailXrLabel.Left = left
                        .itemDescriptionDetailXrLabel.Width += additionalWidth
                        .itemDescriptionHeaderXrLabel.Width += additionalWidth
                        left += .itemDescriptionDetailXrLabel.Width
                    Else
                        .itemDescriptionHeaderXrLabel.Visible = False
                        .itemDescriptionDetailXrLabel.Visible = False
                    End If
                    If Me.inventoryItemTypeCheckEdit.Checked = True Then
                        .itemTypeHeaderXrLabel.Visible = True
                        .itemTypeDetailXrLabel.Visible = True
                        .itemTypeHeaderXrLabel.Left = left
                        .itemTypeDetailXrLabel.Left = left
                        .itemTypeDetailXrLabel.Width += additionalWidth
                        .itemTypeHeaderXrLabel.Width += additionalWidth
                        left += .itemTypeDetailXrLabel.Width
                    Else
                        .itemTypeHeaderXrLabel.Visible = False
                        .itemTypeDetailXrLabel.Visible = False
                    End If
                    If Me.inventoryCurrentInventoryCheckEdit.Checked = True Then
                        .quantityDetailXrLabel.Visible = True
                        .quantityHeaderXrLabel.Visible = True
                        .quantityHeaderXrLabel.Left = left
                        .quantityDetailXrLabel.Left = left
                        left += .quantityDetailXrLabel.Width
                    Else
                        .quantityHeaderXrLabel.Visible = False
                        .quantityDetailXrLabel.Visible = False
                    End If
                    If Me.UOMCheckEdit.Checked Then
                        .UOMHeaderXrLabel.Visible = True
                        .UOMDetailXrLabel.Visible = True
                        .UOMHeaderXrLabel.LeftF = left
                        .UOMDetailXrLabel.LeftF = left
                        left += .UOMDetailXrLabel.Width
                    Else
                        .UOMHeaderXrLabel.Visible = False
                        .UOMDetailXrLabel.Visible = False
                    End If
                    If Me.inventoryAdjustmentReasonCheckEdit.Checked = True Then
                        .reasonHeaderXrLabel.Visible = True
                        .reasonDetailXrLabel.Visible = True
                        .reasonHeaderXrLabel.Left = left
                        .reasonDetailXrLabel.Left = left
                        .reasonDetailXrLabel.Width += additionalWidth
                        .reasonHeaderXrLabel.Width += additionalWidth
                        left += .reasonDetailXrLabel.Width
                    Else
                        .reasonHeaderXrLabel.Visible = False
                        .reasonDetailXrLabel.Visible = False
                    End If
                    If Me.inventoryInventoryByPalletCheckEdit.Checked = True Then
                        .byPalletDetailXrLabel.Visible = True
                        .byPalletHeaderXrLabel.Visible = True
                        .byPalletHeaderXrLabel.Left = left
                        .byPalletDetailXrLabel.Left = left
                        left += .byPalletDetailXrLabel.Width
                    Else
                        .byPalletHeaderXrLabel.Visible = False
                        .byPalletDetailXrLabel.Visible = False
                    End If
                    If Me.RMItemCodeCheckEdit.Checked = True Then
                        .lowestRMItemCodeXrLabel.Visible = True
                        .RMitemCodeDetailXrLabel.Visible = True
                        .lowestRMItemCodeXrLabel.Left = left
                        .RMitemCodeDetailXrLabel.Left = left
                        .RMitemCodeDetailXrLabel.Width += additionalWidth
                        .lowestRMItemCodeXrLabel.Width += additionalWidth
                        left += .RMitemCodeDetailXrLabel.Width
                    Else
                        .lowestRMItemCodeXrLabel.Visible = False
                        .RMitemCodeDetailXrLabel.Visible = False
                    End If
                    If Me.RMItemDescriptionCheckEdit.Checked = True Then
                        .lowestRMDescriptionXrLabel.Visible = True
                        .RMitemDescriptionDetailXrLabel.Visible = True
                        .lowestRMDescriptionXrLabel.Left = left
                        .RMitemDescriptionDetailXrLabel.Left = left
                        .RMitemDescriptionDetailXrLabel.Width += additionalWidth
                        .lowestRMDescriptionXrLabel.Width += additionalWidth
                        left += .RMitemDescriptionDetailXrLabel.Width
                    Else
                        .lowestRMDescriptionXrLabel.Visible = False
                        .RMitemDescriptionDetailXrLabel.Visible = False
                    End If
                    .printDateXrPageInfo.Left = left - 185
                    .reportCriteriaXrLabel.Width = left - 190
                    .reportTitleXrLabel.Width = left
                    .headerXrPanel.Width = left
                    .pageNumberXrPageInfo.Left = left - 100
                End With
            Case "FinishedProductAvailabilityXtraReport"
                Dim report As InventoryXtraReport = CType(m_Report, InventoryXtraReport)
                With report
                    If Me.inventoryDateCheckEdit.Checked = True Then
                        .dateDetailXrLabel.Visible = True
                        .dateHeaderXrLabel.Visible = True
                        .dateDetailXrLabel.Left = left
                        .dateHeaderXrLabel.Left = left
                        .dateDetailXrLabel.Width += additionalWidth
                        .dateHeaderXrLabel.Width += additionalWidth
                        left += .dateDetailXrLabel.Width
                    Else
                        .dateHeaderXrLabel.Visible = False
                        .dateDetailXrLabel.Visible = False
                    End If
                    If Me.inventoryCustomerCheckEdit.Checked = True Then
                        .customerNameHeaderXrLabel.Visible = True
                        .customerNameDetailXrLabel.Visible = True
                        .customerNameHeaderXrLabel.Left = left
                        .customerNameDetailXrLabel.Left = left
                        .customerNameDetailXrLabel.Width += additionalWidth
                        .customerNameHeaderXrLabel.Width += additionalWidth
                        left += .customerNameDetailXrLabel.Width
                    Else
                        .customerNameHeaderXrLabel.Visible = False
                        .customerNameDetailXrLabel.Visible = False
                    End If
                    If Me.inventoryItemCheckEdit.Checked = True Then
                        .itemCodeDetailXrLabel.Visible = True
                        .itemCodeHeaderXrLabel.Visible = True
                        .itemCodeHeaderXrLabel.Left = left
                        .itemCodeDetailXrLabel.Left = left
                        .itemCodeDetailXrLabel.Width += additionalWidth
                        .itemCodeHeaderXrLabel.Width += additionalWidth
                        left += .itemCodeDetailXrLabel.Width
                    Else
                        .itemCodeHeaderXrLabel.Visible = False
                        .itemCodeDetailXrLabel.Visible = False
                    End If
                    If Me.inventoryItemDescriptionCheckEdit.Checked = True Then
                        .itemDescriptionHeaderXrLabel.Visible = True
                        .itemDescriptionDetailXrLabel.Visible = True
                        .itemDescriptionHeaderXrLabel.Left = left
                        .itemDescriptionDetailXrLabel.Left = left
                        .itemDescriptionDetailXrLabel.Width += additionalWidth
                        .itemDescriptionHeaderXrLabel.Width += additionalWidth
                        left += .itemDescriptionDetailXrLabel.Width
                    Else
                        .itemDescriptionHeaderXrLabel.Visible = False
                        .itemDescriptionDetailXrLabel.Visible = False
                    End If
                    If Me.inventoryItemTypeCheckEdit.Checked = True Then
                        .itemTypeHeaderXrLabel.Visible = True
                        .itemTypeDetailXrLabel.Visible = True
                        .itemTypeHeaderXrLabel.Left = left
                        .itemTypeDetailXrLabel.Left = left
                        .itemTypeDetailXrLabel.Width += additionalWidth
                        .itemTypeHeaderXrLabel.Width += additionalWidth
                        left += .itemTypeDetailXrLabel.Width
                    Else
                        .itemTypeHeaderXrLabel.Visible = False
                        .itemTypeDetailXrLabel.Visible = False
                    End If
                    If Me.inventoryAvailabilityCheckEdit.Checked = True Then
                        .quantityDetailXrLabel.Visible = True
                        .quantityHeaderXrLabel.Visible = True
                        .quantityHeaderXrLabel.Left = left
                        .quantityDetailXrLabel.Left = left
                        .quantityHeaderXrLabel.Width += additionalWidth
                        .quantityDetailXrLabel.Width += additionalWidth
                        left += .quantityDetailXrLabel.Width
                    Else
                        .quantityHeaderXrLabel.Visible = False
                        .quantityDetailXrLabel.Visible = False
                    End If
                    If Me.inventoryAdjustmentReasonCheckEdit.Checked = True Then
                        .reasonHeaderXrLabel.Visible = True
                        .reasonDetailXrLabel.Visible = True
                        .reasonHeaderXrLabel.Left = left
                        .reasonDetailXrLabel.Left = left
                        .reasonDetailXrLabel.Width += additionalWidth
                        .reasonHeaderXrLabel.Width += additionalWidth
                        left += .reasonDetailXrLabel.Width
                    Else
                        .reasonHeaderXrLabel.Visible = False
                        .reasonDetailXrLabel.Visible = False
                    End If
                    If Me.inventoryPalletAvailabilityCheckEdit.Checked = True Then
                        .byPalletDetailXrLabel.Visible = True
                        .byPalletHeaderXrLabel.Visible = True
                        .byPalletHeaderXrLabel.Left = left
                        .byPalletDetailXrLabel.Left = left
                        .byPalletDetailXrLabel.Width += additionalWidth
                        .byPalletHeaderXrLabel.Width += additionalWidth
                        left += .byPalletDetailXrLabel.Width
                    Else
                        .byPalletHeaderXrLabel.Visible = False
                        .byPalletDetailXrLabel.Visible = False
                    End If
                    If Me.RMItemCodeCheckEdit.Checked = True Then
                        .lowestRMItemCodeXrLabel.Visible = True
                        .RMitemCodeDetailXrLabel.Visible = True
                        .lowestRMItemCodeXrLabel.Left = left
                        .RMitemCodeDetailXrLabel.Left = left
                        .RMitemCodeDetailXrLabel.Width += additionalWidth
                        .lowestRMItemCodeXrLabel.Width += additionalWidth
                        left += .RMitemCodeDetailXrLabel.Width
                    Else
                        .lowestRMItemCodeXrLabel.Visible = False
                        .RMitemCodeDetailXrLabel.Visible = False
                    End If
                    If Me.RMItemDescriptionCheckEdit.Checked = True Then
                        .lowestRMDescriptionXrLabel.Visible = True
                        .RMitemDescriptionDetailXrLabel.Visible = True
                        .lowestRMDescriptionXrLabel.Left = left
                        .RMitemDescriptionDetailXrLabel.Left = left
                        .RMitemDescriptionDetailXrLabel.Width += additionalWidth
                        .lowestRMDescriptionXrLabel.Width += additionalWidth
                        left += .RMitemDescriptionDetailXrLabel.Width
                    Else
                        .lowestRMDescriptionXrLabel.Visible = False
                        .RMitemDescriptionDetailXrLabel.Visible = False
                    End If
                    If Me.UOMCheckEdit.Checked Then
                        .UOMHeaderXrLabel.Visible = True
                        .UOMDetailXrLabel.Visible = True
                        .UOMHeaderXrLabel.LeftF = left
                        .UOMDetailXrLabel.LeftF = left
                        .UOMHeaderXrLabel.WidthF += additionalWidth
                        .UOMDetailXrLabel.WidthF += additionalWidth
                        left += .UOMDetailXrLabel.Width
                    Else
                        .UOMHeaderXrLabel.Visible = False
                        .UOMDetailXrLabel.Visible = False
                    End If
                    .printDateXrPageInfo.Left = left - 185
                    .reportCriteriaXrLabel.Width = left - 190
                    .reportTitleXrLabel.Width = left
                    .headerXrPanel.Width = left
                    .pageNumberXrPageInfo.Left = left - 100
                End With
            Case "ItemsListXtraReport"
                Dim report As ItemsXtraReport = CType(m_Report, ItemsXtraReport)
                With report
                    If Me.itemsCustomerCheckEdit.Checked = True Then
                        .customerNameHeaderXrLabel.Visible = True
                        .customerNameDetailXrLabel.Visible = True
                        .customerNameHeaderXrLabel.Left = left
                        .customerNameDetailXrLabel.Left = left
                        .customerNameDetailXrLabel.Width += additionalWidth
                        .customerNameHeaderXrLabel.Width += additionalWidth
                        left += .customerNameDetailXrLabel.Width
                    Else
                        .customerNameHeaderXrLabel.Visible = False
                        .customerNameDetailXrLabel.Visible = False
                    End If
                    If Me.itemsItemCheckEdit.Checked = True Then
                        .itemCodeHeaderXrLabel.Visible = True
                        .itemCodeDetailXrLabel.Visible = True
                        .itemCodeHeaderXrLabel.Left = left
                        .itemCodeDetailXrLabel.Left = left
                        .itemCodeDetailXrLabel.Width += additionalWidth
                        .itemCodeHeaderXrLabel.Width += additionalWidth
                        left += .itemCodeDetailXrLabel.Width
                    Else
                        .itemCodeHeaderXrLabel.Visible = False
                        .itemCodeDetailXrLabel.Visible = False
                    End If
                    If Me.itemsItemDescriptionCheckEdit.Checked = True Then
                        .itemDescriptionHeaderXrLabel.Visible = True
                        .itemDescriptionDetailXrLabel.Visible = True
                        .itemDescriptionHeaderXrLabel.Left = left
                        .itemDescriptionDetailXrLabel.Left = left
                        .itemDescriptionDetailXrLabel.Width += additionalWidth
                        .itemDescriptionHeaderXrLabel.Width += additionalWidth
                        left += .itemDescriptionDetailXrLabel.Width
                    Else
                        .itemDescriptionHeaderXrLabel.Visible = False
                        .itemDescriptionDetailXrLabel.Visible = False
                    End If
                    If Me.itemsItemTypeCheckEdit.Checked = True Then
                        .itemTypeDetailXrLabel.Visible = True
                        .itemTypeHeaderXrLabel.Visible = True
                        .itemTypeHeaderXrLabel.Left = left
                        .itemTypeDetailXrLabel.Left = left
                        .itemTypeDetailXrLabel.Width += additionalWidth
                        .itemTypeHeaderXrLabel.Width += additionalWidth
                        left += .itemTypeDetailXrLabel.Width
                    Else
                        .itemTypeHeaderXrLabel.Visible = False
                        .itemTypeDetailXrLabel.Visible = False
                    End If
                    If Me.itemsUnitsOfMeasureCheckEdit.Checked = True Then
                        .uomHeaderXrLabel.Visible = True
                        .uomDetailXrLabel.Visible = True
                        .uomHeaderXrLabel.Left = left
                        .uomDetailXrLabel.Left = left
                        left += .uomDetailXrLabel.Width
                    Else
                        .uomHeaderXrLabel.Visible = False
                        .uomDetailXrLabel.Visible = False
                    End If
                    If Me.itemsQtyPerUnitCheckEdit.Checked = True Then
                        .quantityHeaderXrLabel.Visible = True
                        .quantityDetailXrLabel.Visible = True
                        .quantityHeaderXrLabel.Left = left
                        .quantityDetailXrLabel.Left = left
                        left += .quantityDetailXrLabel.Width
                    Else
                        .quantityHeaderXrLabel.Visible = False
                        .quantityDetailXrLabel.Visible = False
                    End If
                    If Me.itemsUnitsPerCaseCheckEdit.Checked = True Then
                        .unitsPerCaseHeaderXrLabel.Visible = True
                        .unitsPerCaseDetailXrLabel.Visible = True
                        .unitsPerCaseHeaderXrLabel.Left = left
                        .unitsPerCaseDetailXrLabel.Left = left
                        left += .unitsPerCaseDetailXrLabel.Width
                    Else
                        .unitsPerCaseHeaderXrLabel.Visible = False
                        .unitsPerCaseDetailXrLabel.Visible = False
                    End If
                    If Me.itemsProducedCheckEdit.Checked = True Then
                        .producedHeaderXrLabel.Visible = True
                        .producedDetailXrLabel.Visible = True
                        .producedFooterXrLabel.Visible = True
                        .producedHeaderXrLabel.Left = left
                        .producedDetailXrLabel.Left = left
                        .producedFooterXrLabel.Left = left
                        left += .producedDetailXrLabel.Width
                    Else
                        .producedHeaderXrLabel.Visible = False
                        .producedDetailXrLabel.Visible = False
                        .producedFooterXrLabel.Visible = False
                    End If
                    If Me.itemsShippedCheckEdit.Checked = True Then
                        .shippedHeaderXrLabel.Visible = True
                        .shippedDetailXrLabel.Visible = True
                        .shippedDetailXrLabel.Left = left
                        .shippedHeaderXrLabel.Left = left
                        .shippedFooterXrLabel.Visible = True
                        .shippedFooterXrLabel.Left = left
                        left += .shippedDetailXrLabel.Width
                    Else
                        .shippedHeaderXrLabel.Visible = False
                        .shippedDetailXrLabel.Visible = False
                        .shippedFooterXrLabel.Visible = False
                    End If
                    If Me.itemsReceivedCheckEdit.Checked = True Then
                        .receivedHeaderXrLabel.Visible = True
                        .receivedDetailXrLabel.Visible = True
                        .receivedHeaderXrLabel.Left = left
                        .receivedDetailXrLabel.Left = left
                        .receivedFooterXrLabel.Visible = True
                        .receivedFooterXrLabel.Left = left
                        left += .receivedDetailXrLabel.Width
                    Else
                        .receivedHeaderXrLabel.Visible = False
                        .receivedDetailXrLabel.Visible = False
                        .receivedFooterXrLabel.Visible = False
                    End If
                    If Me.itemsCasesPerPalletCheckEdit.Checked = True Then
                        .casesPerPalletHeadeerXrLabel.Visible = True
                        .casesPerPalletDetailXrLabel.Visible = True
                        .casesPerPalletHeadeerXrLabel.Left = left
                        .casesPerPalletDetailXrLabel.Left = left
                        left += .casesPerPalletDetailXrLabel.Width
                    Else
                        .casesPerPalletHeadeerXrLabel.Visible = False
                        .casesPerPalletDetailXrLabel.Visible = False
                    End If
                    If Me.itemsAdjustedCheckEdit.Checked = True Then
                        .adjustedDetailXrLabel.Visible = True
                        .AdjustedHeaderXrLabel.Visible = True
                        .AdjustedHeaderXrLabel.Left = left
                        .adjustedDetailXrLabel.Left = left
                        .adjustedFooterXrLabel.Visible = True
                        .adjustedFooterXrLabel.Left = left
                        left += .adjustedDetailXrLabel.Width
                    Else
                        .AdjustedHeaderXrLabel.Visible = False
                        .adjustedDetailXrLabel.Visible = False
                        .adjustedFooterXrLabel.Visible = False
                    End If
                    If Me.itemUsedInProductionCheckEdit.Checked = True Then
                        .usedInProductionDetailXrLabel.Visible = True
                        .usedInProductionHeaderXrLabel.Visible = True
                        .usedInProductionFooterXrLabel.Visible = True
                        .usedInProductionHeaderXrLabel.LeftF = left
                        .usedInProductionDetailXrLabel.LeftF = left
                        .usedInProductionFooterXrLabel.LeftF = left
                        left += .usedInProductionDetailXrLabel.Width
                    Else
                        .usedInProductionDetailXrLabel.Visible = False
                        .usedInProductionHeaderXrLabel.Visible = False
                        .usedInProductionFooterXrLabel.Visible = False
                    End If
                    .printDateXrPageInfo.Left = left - 185
                    .reportCriteriaXrLabel.Width = left - 190
                    .reportTitleXrLabel.Width = left
                    .headerXrPanel.Width = left
                    .footerXrPanel.Width = left
                    .pageNumberXrPageInfo.Left = left - 100
                End With
            Case "ItemTransactionSummaryXtraReport"
                Dim report As ItemsXtraReport = CType(m_Report, ItemsXtraReport)
                With report
                    If Me.itemsCustomerCheckEdit.Checked = True Then
                        .customerNameHeaderXrLabel.Visible = True
                        .customerNameDetailXrLabel.Visible = True
                        .customerNameHeaderXrLabel.Left = left
                        .customerNameDetailXrLabel.Left = left
                        .customerNameDetailXrLabel.Width += additionalWidth
                        .customerNameHeaderXrLabel.Width += additionalWidth
                        left += .customerNameDetailXrLabel.Width
                    Else
                        .customerNameHeaderXrLabel.Visible = False
                        .customerNameDetailXrLabel.Visible = False
                    End If
                    If Me.itemsItemCheckEdit.Checked = True Then
                        .itemCodeHeaderXrLabel.Visible = True
                        .itemCodeDetailXrLabel.Visible = True
                        .itemCodeHeaderXrLabel.Left = left
                        .itemCodeDetailXrLabel.Left = left
                        .itemCodeDetailXrLabel.Width += additionalWidth
                        .itemCodeHeaderXrLabel.Width += additionalWidth
                        left += .itemCodeDetailXrLabel.Width
                    Else
                        .itemCodeHeaderXrLabel.Visible = False
                        .itemCodeDetailXrLabel.Visible = False
                    End If
                    If Me.itemsItemDescriptionCheckEdit.Checked = True Then
                        .itemDescriptionHeaderXrLabel.Visible = True
                        .itemDescriptionDetailXrLabel.Visible = True
                        .itemDescriptionHeaderXrLabel.Left = left
                        .itemDescriptionDetailXrLabel.Left = left
                        .itemDescriptionDetailXrLabel.Width += additionalWidth
                        .itemDescriptionHeaderXrLabel.Width += additionalWidth
                        left += .itemDescriptionDetailXrLabel.Width
                    Else
                        .itemDescriptionHeaderXrLabel.Visible = False
                        .itemDescriptionDetailXrLabel.Visible = False
                    End If
                    If Me.itemsItemTypeCheckEdit.Checked = True Then
                        .itemTypeDetailXrLabel.Visible = True
                        .itemTypeHeaderXrLabel.Visible = True
                        .itemTypeHeaderXrLabel.Left = left
                        .itemTypeDetailXrLabel.Left = left
                        .itemTypeDetailXrLabel.Width += additionalWidth
                        .itemTypeHeaderXrLabel.Width += additionalWidth
                        left += .itemTypeDetailXrLabel.Width
                    Else
                        .itemTypeHeaderXrLabel.Visible = False
                        .itemTypeDetailXrLabel.Visible = False
                    End If
                    If Me.itemsUnitsOfMeasureCheckEdit.Checked = True Then
                        .uomHeaderXrLabel.Visible = True
                        .uomDetailXrLabel.Visible = True
                        .uomHeaderXrLabel.Left = left
                        .uomDetailXrLabel.Left = left
                        left += .uomDetailXrLabel.Width
                    Else
                        .uomHeaderXrLabel.Visible = False
                        .uomDetailXrLabel.Visible = False
                    End If
                    If Me.itemsQtyPerUnitCheckEdit.Checked = True Then
                        .quantityHeaderXrLabel.Visible = True
                        .quantityDetailXrLabel.Visible = True
                        .quantityHeaderXrLabel.Left = left
                        .quantityDetailXrLabel.Left = left
                        left += .quantityDetailXrLabel.Width
                    Else
                        .quantityHeaderXrLabel.Visible = False
                        .quantityDetailXrLabel.Visible = False
                    End If
                    If Me.itemsUnitsPerCaseCheckEdit.Checked = True Then
                        .unitsPerCaseHeaderXrLabel.Visible = True
                        .unitsPerCaseDetailXrLabel.Visible = True
                        .unitsPerCaseHeaderXrLabel.Left = left
                        .unitsPerCaseDetailXrLabel.Left = left
                        left += .unitsPerCaseDetailXrLabel.Width
                    Else
                        .unitsPerCaseHeaderXrLabel.Visible = False
                        .unitsPerCaseDetailXrLabel.Visible = False
                    End If
                    If Me.itemsProducedCheckEdit.Checked = True Then
                        .producedHeaderXrLabel.Visible = True
                        .producedDetailXrLabel.Visible = True
                        .producedFooterXrLabel.Visible = True
                        .producedHeaderXrLabel.Left = left
                        .producedDetailXrLabel.Left = left
                        .producedFooterXrLabel.Left = left
                        left += .producedDetailXrLabel.Width
                    Else
                        .producedHeaderXrLabel.Visible = False
                        .producedDetailXrLabel.Visible = False
                        .producedFooterXrLabel.Visible = False
                    End If
                    If Me.itemUsedInProductionCheckEdit.Checked = True Then
                        .usedInProductionDetailXrLabel.Visible = True
                        .usedInProductionHeaderXrLabel.Visible = True
                        .usedInProductionFooterXrLabel.Visible = True
                        .usedInProductionHeaderXrLabel.LeftF = left
                        .usedInProductionDetailXrLabel.LeftF = left
                        .usedInProductionFooterXrLabel.LeftF = left
                        left += .usedInProductionDetailXrLabel.Width
                    Else
                        .usedInProductionDetailXrLabel.Visible = False
                        .usedInProductionHeaderXrLabel.Visible = False
                        .usedInProductionFooterXrLabel.Visible = False
                    End If
                    If Me.itemsShippedCheckEdit.Checked = True Then
                        .shippedHeaderXrLabel.Visible = True
                        .shippedDetailXrLabel.Visible = True
                        .shippedDetailXrLabel.Left = left
                        .shippedHeaderXrLabel.Left = left
                        .shippedFooterXrLabel.Visible = True
                        .shippedFooterXrLabel.Left = left
                        left += .shippedDetailXrLabel.Width
                    Else
                        .shippedHeaderXrLabel.Visible = False
                        .shippedDetailXrLabel.Visible = False
                        .shippedFooterXrLabel.Visible = False
                    End If
                    If Me.itemsReceivedCheckEdit.Checked = True Then
                        .receivedHeaderXrLabel.Visible = True
                        .receivedDetailXrLabel.Visible = True
                        .receivedHeaderXrLabel.Left = left
                        .receivedDetailXrLabel.Left = left
                        .receivedFooterXrLabel.Visible = True
                        .receivedFooterXrLabel.Left = left
                        left += .receivedDetailXrLabel.Width
                    Else
                        .receivedHeaderXrLabel.Visible = False
                        .receivedDetailXrLabel.Visible = False
                        .receivedFooterXrLabel.Visible = False
                    End If
                    If Me.itemsCasesPerPalletCheckEdit.Checked = True Then
                        .casesPerPalletHeadeerXrLabel.Visible = True
                        .casesPerPalletDetailXrLabel.Visible = True
                        .casesPerPalletHeadeerXrLabel.Left = left
                        .casesPerPalletDetailXrLabel.Left = left
                        left += .casesPerPalletDetailXrLabel.Width
                    Else
                        .casesPerPalletHeadeerXrLabel.Visible = False
                        .casesPerPalletDetailXrLabel.Visible = False
                    End If
                    If Me.itemsAdjustedCheckEdit.Checked = True Then
                        .adjustedDetailXrLabel.Visible = True
                        .AdjustedHeaderXrLabel.Visible = True
                        .AdjustedHeaderXrLabel.Left = left
                        .adjustedDetailXrLabel.Left = left
                        .adjustedFooterXrLabel.Visible = True
                        .adjustedFooterXrLabel.Left = left
                        left += .adjustedDetailXrLabel.Width
                    Else
                        .AdjustedHeaderXrLabel.Visible = False
                        .adjustedDetailXrLabel.Visible = False
                        .adjustedFooterXrLabel.Visible = False
                    End If
                    .printDateXrPageInfo.Left = left - 185
                    .reportCriteriaXrLabel.Width = left - 190
                    .reportTitleXrLabel.Width = left
                    .headerXrPanel.Width = left
                    .footerXrPanel.Width = left
                    .pageNumberXrPageInfo.Left = left - 100
                End With
            Case "PalletTransactionXtraReport"
                Dim report As PalletTransactionXtraReport = CType(m_Report, PalletTransactionXtraReport)
                With report
                    left = 240
                    .totalsXRLabel.Width = 600
                    .totalOverShippedXRLabel.Width = 600
                    If Me.ptVendorCheckEdit.Checked = True Then
                        .vendorHeaderXrLabel.Visible = True
                        .vendorDetailXrLabel.Visible = True
                        .vendorHeaderXrLabel.Left = left
                        .vendorDetailXrLabel.Left = left
                        left += .vendorDetailXrLabel.Width
                    Else
                        .vendorHeaderXrLabel.Visible = False
                        .vendorDetailXrLabel.Visible = False
                        .totalsXRLabel.Width -= .vendorDetailXrLabel.Width
                        .totalOverShippedXRLabel.Width -= .vendorDetailXrLabel.Width
                    End If
                    If Me.ptDestinationCheckEdit.Checked = True Then
                        .destinationHeaderXrLabel.Visible = True
                        .destinationDetailXrLabel.Visible = True
                        .destinationHeaderXrLabel.Left = left
                        .destinationDetailXrLabel.Left = left
                        left += .destinationDetailXrLabel.Width
                    Else
                        .destinationHeaderXrLabel.Visible = False
                        .destinationDetailXrLabel.Visible = False
                        .totalsXRLabel.Width -= .destinationDetailXrLabel.Width
                        .totalOverShippedXRLabel.Width -= .destinationDetailXrLabel.Width
                    End If
                    .bolXrLabel.Left = left
                    .bolDetailXrLabel.Left = left
                    left += .bolDetailXrLabel.Width
                    .xRLOverShippedTotal.Left = left
                    .xRLOverShippedTotal.Width = 200
                    If Me.ptReceivedCheckEdit.Checked = True Then
                        .recieveHeaderXrLabel.Visible = True
                        .receivedDetailXrLabel.Visible = True
                        .receivedTotalXRLabel.Visible = True
                        .recieveHeaderXrLabel.Left = left
                        .receivedDetailXrLabel.Left = left
                        .receivedTotalXRLabel.Left = left
                        left += .receivedDetailXrLabel.Width
                    Else
                        .recieveHeaderXrLabel.Visible = False
                        .receivedDetailXrLabel.Visible = False
                        .receivedTotalXRLabel.Visible = False
                        .xRLOverShippedTotal.Width -= .receivedDetailXrLabel.Width
                    End If
                    If Me.ptShippedCheckEdit.Checked = True Then
                        .shippedHeadeerXrLabel.Visible = True
                        .shippedDetailXrLabel.Visible = True
                        .shippedTotalXrLabel.Visible = True
                        .shippedHeadeerXrLabel.Left = left
                        .shippedDetailXrLabel.Left = left
                        .shippedTotalXrLabel.Left = left
                        left += .shippedDetailXrLabel.Width
                    Else
                        .shippedHeadeerXrLabel.Visible = False
                        .shippedDetailXrLabel.Visible = False
                        .shippedTotalXrLabel.Visible = False
                        .xRLOverShippedTotal.Width -= .shippedDetailXrLabel.Width
                    End If
                    .printDateXrPageInfo.Left = left - 185
                    .reportCriteriaXrLabel.Width = left - 190
                    .headerXrPanel.Width = left
                    .reportTitleXrLabel.Width = left
                    .pageNumberXrPageInfo.Left = left - 100
                End With
        End Select

    End Sub

    Public Sub BindReportColumns(ByVal reportCodeName As String)

        Select Case reportCodeName
            Case "ProductionDetailXtraReport"
                Dim report As ProductionXtraReport = CType(m_Report, ProductionXtraReport)
                With report
                    .dateDetailXrLabel.DataBindings.Add("Text", m_Production, "ProdMainDate", "{0:dddd, MM/dd/yyyy}")
                    .shiftDetailXrLabel.DataBindings.Add("Text", m_Production, "Shift")
                    .customerNameDetailXrLabel.DataBindings.Add("Text", m_Production, "CustomerName")
                    .lotDetailXrLabel.DataBindings.Add("Text", m_Production, "ProdMainLot")
                    .itemCodeDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemCode")
                    .itemDescriptionDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemDescription")
                    .startTimeDetailXrLabel.DataBindings.Add("Text", m_Production, "ProdMainTimeStart", "{0:h:mm tt}")
                    .stopTimeDetailXrLabel.DataBindings.Add("Text", m_Production, "ProdMainTimeStop", "{0:h:mm tt}")
                    .quantityDetailXrLabel.DataBindings.Add("Text", m_Production, "ProdMainQuantity")
                    .quantityFooterXrLabel.DataBindings.Add("Text", m_Production, "ProdMainQuantity")
                    .machineLineDetailXrLabel.DataBindings.Add("Text", m_Production, "MachineLine")
                    .packersDetailXrLabel.DataBindings.Add("Text", m_Production, "ProdMainPackers")
                    .reportTitleXrLabel.Text = ReportTitle
                    Me.Text = ReportTitle
                End With
            Case "ProductionSummaryXtraReport"
                Dim report As ProductionSummaryXtraReport = CType(m_Report, ProductionSummaryXtraReport)
                Me.Text = ReportTitle
            Case "ProductionMachineXtraReport"
                Dim report As ProductionMachineXtraReport = CType(m_Report, ProductionMachineXtraReport)
                Me.Text = ReportTitle
            Case "ProductionShiftXtraReport"
                Dim report As ProductionShiftXtraReport = CType(m_Report, ProductionShiftXtraReport)
                Me.Text = ReportTitle
            Case "ProductionEntriesXtraReport"
                Dim report As ProductionXtraReport = CType(m_Report, ProductionXtraReport)
                With report
                    .dateDetailXrLabel.DataBindings.Add("Text", m_Production, "InventoryDate", "{0:dddd, MM/dd/yyyy}")
                    .customerNameDetailXrLabel.DataBindings.Add("Text", m_Production, "CustomerName")
                    .lotDetailXrLabel.DataBindings.Add("Text", m_Production, "Lot")
                    .itemCodeDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemCode")
                    .itemDescriptionDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemDescription")
                    .quantityDetailXrLabel.DataBindings.Add("Text", m_Production, "InventoryQuantity")
                    .quantityFooterXrLabel.DataBindings.Add("Text", m_Production, "InventoryQuantity")
                    .poDetailXrLabel.DataBindings.Add("Text", m_Production, "PO")
                    .reportTitleXrLabel.Text = ReportTitle
                    Me.Text = ReportTitle
                End With
            Case "CostingXtraReport", "CostingSmallXtraReport", "FinancialCostingXtraReport"
                Dim report As CostingXtraReport = CType(m_Report, CostingXtraReport)
                With report
                    .dateDetailXrLabel.DataBindings.Add("Text", m_Production, "ProdMainDate", "{0:dddd, MMMM dd, yyyy}")
                    .shiftDetailXrLabel.DataBindings.Add("Text", m_Production, "ShiftName", "")
                    .customerNameDetailXrLabel.DataBindings.Add("Text", m_Production, "CustomerName", "")
                    .lotDetailXrLabel.DataBindings.Add("Text", m_Production, "ProdMainLot", "")
                    .itemCodeDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemCode", "")
                    .itemDescriptionDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemDescription", "")
                    .startTimeDetailXrLabel.DataBindings.Add("Text", m_Production, "ProdMainTimeStart", "{0:h:mm tt}")
                    .stopTimeDetailXrLabel.DataBindings.Add("Text", m_Production, "ProdMainTimeStop", "{0:h:mm tt}")
                    .quantityDetailXrLabel.DataBindings.Add("Text", m_Production, "ProdMainQuantity", "")
                    .expectedDetailXrLabel.DataBindings.Add("Text", m_Production, "ExpectedProduction", "{0:#.##}")
                    .differenceDetailXrLabel.DataBindings.Add("Text", m_Production, "ProductionDifference", "{0:#.##}")
                    .machineLineDetailXrLabel.DataBindings.Add("Text", m_Production, "MachineLineName", "")
                    .speedDetailXrLabel.DataBindings.Add("Text", m_Production, "intMachineSpeed", "")
                    .operatorDetailXrLabel.DataBindings.Add("Text", m_Production, "ProdMainOperators", "")
                    .packerDetailXrLabel.DataBindings.Add("Text", m_Production, "ProdMainPackers", "")
                    .superDetailXrLabel.DataBindings.Add("Text", m_Production, "ProdMainSupers", "")
                    .priceDetailXrLabel.DataBindings.Add("Text", m_Production, "TotalPrice", "{0:$0.00}")
                    .rebateDetailXrLabel.DataBindings.Add("Text", m_Production, "Rebate", "{0:$0.00}")
                    .freightDetailXrLabel.DataBindings.Add("Text", m_Production, "Freight", "{0:$0.00}")
                    .filmDetailXrLabel.DataBindings.Add("Text", m_Production, "Film", "{0:$0.00}")
                    .boxesDetailXrLabel.DataBindings.Add("Text", m_Production, "Boxes", "{0:$0.00}")
                    .stretchWrapDetailXrLabel.DataBindings.Add("Text", m_Production, "StretchWrap", "{0:$0.00}")
                    .palletsDetailXrLabel.DataBindings.Add("Text", m_Production, "Pallets", "{0:$0.00}")
                    .totalHoursFooterXRLabel.DataBindings.Add("Text", m_Production, "TotalHours", "")
                    .quantityFooterXRLabel.DataBindings.Add("Text", m_Production, "ProdMainQuantity", "{0:#,#}")
                    .expectedFooterXRLabel.DataBindings.Add("Text", m_Production, "ExpectedProduction", "{0:#.##}")
                    .priceFooterXrLabel.DataBindings.Add("Text", m_Production, "TotalPrice", "")
                    .rebateFooterXrLabel.DataBindings.Add("Text", m_Production, "Rebate", "{0:$0.00}")
                    .freightFooterXrLabel.DataBindings.Add("Text", m_Production, "Freight", "")
                    .filmFooterXrLabel.DataBindings.Add("Text", m_Production, "Film", "{0:$0.00}")
                    .boxesFooterXrLabel.DataBindings.Add("Text", m_Production, "Boxes", "{0:$0.00}")
                    .stretchWrapFooterXrLabel.DataBindings.Add("Text", m_Production, "StretchWrap", "{0:$0.00}")
                    .palletsFooterXrLabel.DataBindings.Add("Text", m_Production, "Pallets", "{0:$0.00}")
                End With
                Me.Text = ReportTitle
            Case "ShippingXtraReport"
                Dim report As TransportationXtraReport = CType(m_Report, TransportationXtraReport)
                With report
                    .dateDetailXrLabel.DataBindings.Add("Text", Nothing, "ShipMainDate", "{0:dddd, MM/dd/yyyy}")
                    .shiftDetailXrLabel.DataBindings.Add("Text", Nothing, "ShiftName")
                    .customerNameDetailXrLabel.DataBindings.Add("Text", Nothing, "CustomerName")
                    .bolDetailXrLabel.DataBindings.Add("Text", Nothing, "ShipMainBOL")
                    .poDetailXrLabel.DataBindings.Add("Text", Nothing, "strPO")
                    .deliveryNoteNumberDetailXrLabel.DataBindings.Add("Text", Nothing, "DeliveryNoteNumber")
                    .destinationDetailXrLabel.DataBindings.Add("Text", Nothing, "ShippingName")
                    .lotDetailXrLabel.DataBindings.Add("Text", Nothing, "ShipDetLot")
                    .lpnDetailXrLabel.DataBindings.Add("Text", Nothing, "FullLPNNumber")
                    .expirationDateDetailXrLabel.DataBindings.Add("Text", Nothing, "ExpirationDate")
                    .expirationDateDetailXrLabel.DataBindings.Add("Tag", Nothing, "ExpirationDateFormat")
                    .itemCodeDetailXrLabel.DataBindings.Add("Text", Nothing, "ItemCode")
                    .itemDescriptionDetailXrLabel.DataBindings.Add("Text", Nothing, "ItemDescription")
                    .quantityDetailXrLabel.DataBindings.Add("Text", Nothing, "ShipDetDetQty")
                    .quantityFooterXrLabel.DataBindings.Add("Text", Nothing, "ShipDetDetQty")
                    .carrierDetailXrLabel.DataBindings.Add("Text", Nothing, "CarrierName")
                    .trailerDetailXrLabel.DataBindings.Add("Text", Nothing, "strTrailer")
                    .sealDetailXrLabel.DataBindings.Add("Text", Nothing, "strSeal")
                    .reportTitleXrLabel.Text = ReportTitle
                    Me.Text = ReportTitle
                End With
            Case "ShippingReturnsXtraReport"
                Dim report As TransportationXtraReport = CType(m_Report, TransportationXtraReport)
                With report
                    .dateDetailXrLabel.DataBindings.Add("Text", Nothing, "ShipMainDate", "{0:dddd, MM/dd/yyyy}")
                    .shiftDetailXrLabel.DataBindings.Add("Text", Nothing, "ShiftName")
                    .customerNameDetailXrLabel.DataBindings.Add("Text", Nothing, "CustomerName")
                    .bolDetailXrLabel.DataBindings.Add("Text", Nothing, "ShipMainBOL")
                    .poDetailXrLabel.DataBindings.Add("Text", Nothing, "strPO")
                    .deliveryNoteNumberDetailXrLabel.DataBindings.Add("Text", Nothing, "DeliveryNoteNumber")
                    .destinationDetailXrLabel.DataBindings.Add("Text", Nothing, "ShippingName")
                    .lotDetailXrLabel.DataBindings.Add("Text", Nothing, "ReturnDetLot")
                    .expirationDateDetailXrLabel.DataBindings.Add("Text", Nothing, "ExpirationDate")
                    .expirationDateDetailXrLabel.DataBindings.Add("Tag", Nothing, "ExpirationDateFormat")
                    .itemCodeDetailXrLabel.DataBindings.Add("Text", Nothing, "ItemCode")
                    .itemDescriptionDetailXrLabel.DataBindings.Add("Text", Nothing, "ItemDescription")
                    .quantityDetailXrLabel.DataBindings.Add("Text", Nothing, "intUnits")
                    .quantityFooterXrLabel.DataBindings.Add("Text", Nothing, "intUits")
                    .carrierDetailXrLabel.DataBindings.Add("Text", Nothing, "CarrierName")
                    .trailerDetailXrLabel.DataBindings.Add("Text", Nothing, "strTrailer")
                    .sealDetailXrLabel.DataBindings.Add("Text", Nothing, "strSeal")
                    .reportTitleXrLabel.Text = ReportTitle
                    Me.Text = ReportTitle
                End With
            Case "ReceivingXtraReport"
                Dim report As TransportationXtraReport = CType(m_Report, TransportationXtraReport)
                With report
                    .dateDetailXrLabel.DataBindings.Add("Text", Nothing, "ReceivDate", "{0:dddd, MM/dd/yyyy}")
                    .shiftDetailXrLabel.DataBindings.Add("Text", Nothing, "ShiftName")
                    .customerNameDetailXrLabel.DataBindings.Add("Text", Nothing, "CustomerName")
                    .bolDetailXrLabel.DataBindings.Add("Text", Nothing, "ReceivBOL")
                    .poDetailXrLabel.DataBindings.Add("Text", Nothing, "strPO")
                    .vendorDetailXrLabel.DataBindings.Add("Text", Nothing, "VendorName")
                    .lotDetailXrLabel.DataBindings.Add("Text", Nothing, "ReceivDetLot")
                    .expirationDateDetailXrLabel.DataBindings.Add("Text", Nothing, "ExpirationDate")
                    .expirationDateDetailXrLabel.DataBindings.Add("Tag", Nothing, "ExpirationDateFormat")
                    .itemCodeDetailXrLabel.DataBindings.Add("Text", Nothing, "ItemCode")
                    .itemDescriptionDetailXrLabel.DataBindings.Add("Text", Nothing, "ItemDescription")
                    .quantityDetailXrLabel.DataBindings.Add("Text", Nothing, "intUnits")
                    .quantityFooterXrLabel.DataBindings.Add("Text", Nothing, "intUnits")
                    .carrierDetailXrLabel.DataBindings.Add("Text", Nothing, "CarrierName")
                    .trailerDetailXrLabel.DataBindings.Add("Text", Nothing, "strTrailer")
                    .sealDetailXrLabel.DataBindings.Add("Text", Nothing, "strSeal")
                    .reportTitleXrLabel.Text = ReportTitle
                    Me.Text = ReportTitle
                End With
            Case "ReceivingReturnsXtraReport"
                Dim report As TransportationXtraReport = CType(m_Report, TransportationXtraReport)
                With report
                    .dateDetailXrLabel.DataBindings.Add("Text", Nothing, "ReceivDate", "{0:dddd, MM/dd/yyyy}")
                    .shiftDetailXrLabel.DataBindings.Add("Text", Nothing, "ShiftName")
                    .customerNameDetailXrLabel.DataBindings.Add("Text", Nothing, "CustomerName")
                    .bolDetailXrLabel.DataBindings.Add("Text", Nothing, "ReceivBOL")
                    .poDetailXrLabel.DataBindings.Add("Text", Nothing, "strPO")
                    .vendorDetailXrLabel.DataBindings.Add("Text", Nothing, "VendorName")
                    .lotDetailXrLabel.DataBindings.Add("Text", Nothing, "ReturnDetLot")
                    .expirationDateDetailXrLabel.DataBindings.Add("Text", Nothing, "ExpirationDate")
                    .expirationDateDetailXrLabel.DataBindings.Add("Tag", Nothing, "ExpirationDateFormat")
                    .itemCodeDetailXrLabel.DataBindings.Add("Text", Nothing, "ItemCode")
                    .itemDescriptionDetailXrLabel.DataBindings.Add("Text", Nothing, "ItemDescription")
                    .quantityDetailXrLabel.DataBindings.Add("Text", Nothing, "ReturnDetQty")
                    .quantityFooterXrLabel.DataBindings.Add("Text", Nothing, "ReturnDetQty")
                    .carrierDetailXrLabel.DataBindings.Add("Text", Nothing, "CarrierName")
                    .trailerDetailXrLabel.DataBindings.Add("Text", Nothing, "strTrailer")
                    .sealDetailXrLabel.DataBindings.Add("Text", Nothing, "strSeal")
                    .reportTitleXrLabel.Text = ReportTitle
                    Me.Text = ReportTitle
                End With
            Case "InventoryAdjustmentXtraReport"
                Dim report As InventoryXtraReport = CType(m_Report, InventoryXtraReport)
                With report
                    .dateDetailXrLabel.DataBindings.Add("Text", m_Production, "AdjustmentDate", "{0:dddd, MM/dd/yyyy}")
                    .customerNameDetailXrLabel.DataBindings.Add("Text", m_Production, "CustomerName")
                    .itemCodeDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemCode")
                    .quantityDetailXrLabel.DataBindings.Add("Text", m_Production, "AdjustmentQTY", "{0:#,##0.######}")
                    .reasonDetailXrLabel.DataBindings.Add("Text", m_Production, "Reason")
                    .reportTitleXrLabel.Text = ReportTitle
                    .quantityHeaderXrLabel.Text = "Adjustment Qty"
                    Me.Text = ReportTitle
                End With
            Case "PhysicalInventoryXtraReport"
                Dim report As InventoryXtraReport = CType(m_Report, InventoryXtraReport)
                With report
                    .customerNameDetailXrLabel.DataBindings.Add("Text", m_Production, "CustomerName")
                    .itemCodeDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemCode")
                    .itemDescriptionDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemDescription")
                    .itemTypeDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemType")
                    .quantityDetailXrLabel.DataBindings.Add("Text", m_Production, "QuantityOnHand", "{0:#,##0.######}")
                    .byPalletDetailXrLabel.DataBindings.Add("Text", m_Production, "InventoryByPallets")
                    .reportTitleXrLabel.Text = ReportTitle
                    .quantityHeaderXrLabel.Text = "Current Inventory"
                End With
            Case "OldCurrentInventoryXtraReport"
                Dim report As InventoryXtraReport = CType(m_Report, InventoryXtraReport)
                With report
                    .customerNameDetailXrLabel.DataBindings.Add("Text", Nothing, "CustomerName")
                    .itemCodeDetailXrLabel.DataBindings.Add("Text", Nothing, "ItemCode")
                    .itemDescriptionDetailXrLabel.DataBindings.Add("Text", Nothing, "ItemDescription")
                    .itemTypeDetailXrLabel.DataBindings.Add("Text", Nothing, "ItemType")
                    .quantityDetailXrLabel.DataBindings.Add("Text", Nothing, "QuantityOnHand", "{0:#,##0.######}")
                    .byPalletDetailXrLabel.DataBindings.Add("Text", Nothing, "InventoryByPallets")
                    .UOMDetailXrLabel.DataBindings.Add("Text", Nothing, "UOM")
                    .reportTitleXrLabel.Text = ReportTitle
                    .quantityHeaderXrLabel.Text = "Current Inventory"
                    .byPalletHeaderXrLabel.Text = "Inventory by Pallet"
                    Me.Text = ReportTitle
                End With
            Case "FinishedProductAvailabilityXtraReport"
                Dim report As InventoryXtraReport = CType(m_Report, InventoryXtraReport)
                With report
                    .customerNameDetailXrLabel.DataBindings.Add("Text", m_Production, "CustomerName")
                    .itemCodeDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemCode")
                    .itemDescriptionDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemDescription")
                    .quantityDetailXrLabel.DataBindings.Add("Text", m_Production, "Availability", "{0:#,##0.######}")
                    .byPalletDetailXrLabel.DataBindings.Add("Text", m_Production, "AvailabilityByPallet")
                    .RMitemCodeDetailXrLabel.DataBindings.Add("Text", m_Production, "RMItemCode")
                    .RMitemDescriptionDetailXrLabel.DataBindings.Add("Text", m_Production, "RMItemDescription")
                    .reportTitleXrLabel.Text = ReportTitle
                    .quantityHeaderXrLabel.Text = "Availability"
                    .byPalletHeaderXrLabel.Text = "Availability by Pallet"
                    Me.Text = ReportTitle
                End With
            Case "ItemsListXtraReport"
                Dim report As ItemsXtraReport = CType(m_Report, ItemsXtraReport)
                With report
                    .customerNameDetailXrLabel.DataBindings.Add("Text", m_Production, "CustomerName")
                    .itemCodeDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemCode")
                    .itemDescriptionDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemDescription")
                    .itemTypeDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemType")
                    .uomDetailXrLabel.DataBindings.Add("Text", m_Production, "strUnitOfMeasure")
                    .quantityDetailXrLabel.DataBindings.Add("Text", m_Production, "intQtyPerUnit")
                    .unitsPerCaseDetailXrLabel.DataBindings.Add("Text", m_Production, "intUnitsPerCase", "{0:N2}")
                    .casesPerPalletDetailXrLabel.DataBindings.Add("Text", m_Production, "intCasesPerPallet")
                    .reportTitleXrLabel.Text = ReportTitle
                    Me.Text = ReportTitle
                End With
            Case "ItemsTransactionsXtraReport"
                MessageBox.Show("This report has been replaced with the Item Transaction Summary report.")
                Exit Sub
                'Dim report As ItemTransactionXtraReport = CType(m_Report, ItemTransactionXtraReport)
                'With report
                '    .reportTitleXrLabel.Text = ReportTitle
                '    Me.Text = ReportTitle
                'End With
            Case "ItemTransactionSummaryXtraReport"
                Dim report As ItemsXtraReport = CType(m_Report, ItemsXtraReport)
                With report
                    .customerNameDetailXrLabel.DataBindings.Add("Text", Nothing, "CustomerName")
                    .itemCodeDetailXrLabel.DataBindings.Add("Text", Nothing, "ItemCode")
                    .itemDescriptionDetailXrLabel.DataBindings.Add("Text", Nothing, "ItemDescription")
                    .itemTypeDetailXrLabel.DataBindings.Add("Text", Nothing, "ItemType")
                    .producedDetailXrLabel.DataBindings.Add("Text", Nothing, "Produced")
                    .shippedDetailXrLabel.DataBindings.Add("Text", Nothing, "Shipped")
                    .receivedDetailXrLabel.DataBindings.Add("Text", Nothing, "Received")
                    .adjustedDetailXrLabel.DataBindings.Add("Text", Nothing, "Adjusted")
                    .producedFooterXrLabel.DataBindings.Add("Text", Nothing, "Produced")
                    .shippedFooterXrLabel.DataBindings.Add("Text", Nothing, "Shipped")
                    .receivedFooterXrLabel.DataBindings.Add("Text", Nothing, "Received")
                    .adjustedFooterXrLabel.DataBindings.Add("Text", Nothing, "Adjusted")
                    .usedInProductionDetailXrLabel.DataBindings.Add("Text", Nothing, "UsedInProduction")
                    .usedInProductionFooterXrLabel.DataBindings.Add("Text", Nothing, "UsedInProduction")
                    .reportTitleXrLabel.Text = ReportTitle
                    Me.Text = ReportTitle
                End With
            Case "PalletTransactionXtraReport"
                Dim report As PalletTransactionXtraReport = CType(m_Report, PalletTransactionXtraReport)
                report.reportTitleXrLabel.Text = ReportTitle
                Me.Text = ReportTitle
            Case "PalletControlXtraReport"
                Dim report As PalletsXtraReport = CType(m_Report, PalletsXtraReport)
                With report
                    .customerNameDetailXrLabel.DataBindings.Add("Text", m_Production, "CustomerName")
                    .byPalletDetailXrLabel.DataBindings.Add("Text", m_Production, "PalletQTY")
                    .reportTitleXrLabel.Text = ReportTitle
                    Me.Text = ReportTitle
                End With
            Case "AuditTrailXtraReport"
                Dim report As AuditTrailXtraReport = CType(m_Report, AuditTrailXtraReport)
                With report
                    .userNameDetailXrLabel.DataBindings.Add("Text", m_Production, "strUserName")
                    .dateDetailXrLabel.DataBindings.Add("Text", m_Production, "ChangeDate")
                    .recordTypeDetailXrLabel.DataBindings.Add("Text", m_Production, "RecordType")
                    .recordChangesDetailXrLabel.DataBindings.Add("Text", m_Production, "RecordChanges")
                    .reportTitleXrLabel.Text = ReportTitle
                    Me.Text = ReportTitle
                End With
        End Select

    End Sub

    Private m_OnlyAssigned As Boolean
    Public Property OnlyAssigned() As Boolean
        Get
            Return m_OnlyAssigned
        End Get
        Set(ByVal value As Boolean)
            m_OnlyAssigned = value
        End Set
    End Property

    Private Sub BindReport()

        Select Case m_SelectedReport
            Case "ProductionDetailXtraReport"
                m_Production = m_ProductionBLL.GetProductionReport(CType(fromDateEdit.EditValue, Date?), CType(toDateEdit.EditValue, Date?), CType(customerLookUpEdit.EditValue, Integer?), _
                                                                   CType(shiftLookUpEdit.EditValue, Integer?), CType(machineLookUpEdit.EditValue, Integer?), GetItemsSelected("|"c), InactiveItemsCheckEdit.Checked, _
                                                                   InactiveCustomersCheckEdit.Checked)
                m_Report.DataSource = m_Production
                If OnlyAssigned Then
                    m_Report.FilterString = New InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session)).ToString
                End If
                CType(m_Report, ProductionXtraReport).Detail.SortFields.AddRange(New GroupField() {New GroupField("ProdMainDate"), New GroupField("ItemCode")})
                CType(m_Report, ProductionXtraReport).reportCriteriaXrLabel.Text = GetFilterUsed(True)

            Case "ProductionSummaryXtraReport"
                m_Production = m_ProductionBLL.GetProductionReport(CType(fromDateEdit.EditValue, Date?), CType(toDateEdit.EditValue, Date?), CType(customerLookUpEdit.EditValue, Integer?), _
                                                                                   CType(shiftLookUpEdit.EditValue, Integer?), CType(machineLookUpEdit.EditValue, Integer?), GetItemsSelected("|"c), _
                                                                                   InactiveItemsCheckEdit.Checked, InactiveCustomersCheckEdit.Checked)
                m_Report.DataSource = m_Production
                If OnlyAssigned Then
                    m_Report.FilterString = New InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session)).ToString
                End If
                CType(m_Report, ProductionSummaryXtraReport).CriteriaLabel.Text = GetFilterUsed(True)

            Case "ProductionEntriesXtraReport"
                m_Report.DataSource = New ProductionEntriesReportBLL().GetProductionEntriesReport(CType(fromDateEdit.EditValue, Date?), CType(toDateEdit.EditValue, Date?), CType(customerLookUpEdit.EditValue, Integer?),
                                                                                                  CStr(lotTextEdit.EditValue), CStr(poTextEdit.EditValue), GetItemsSelected("|"c), InactiveItemsCheckEdit.Checked,
                                                                                                  InactiveCustomersCheckEdit.Checked, CType(shiftLookUpEdit.EditValue, Integer?))
                If OnlyAssigned Then
                    m_Report.FilterString = New InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session)).ToString
                End If
                CType(m_Report, ProductionXtraReport).Detail.SortFields.AddRange(New GroupField() {New GroupField("InventoryDate"), New GroupField("ItemCode")})
                CType(m_Report, ProductionXtraReport).reportCriteriaXrLabel.Text = GetFilterUsed(True)

            Case "CostingXtraReport", "CostingSmallXtraReport", "FinancialCostingXtraReport"
                m_Report.DataSource = New CostingReportsBLL().GetCostingReport(CType(fromDateEdit.EditValue, Date?), CType(toDateEdit.EditValue, Date?), CType(customerLookUpEdit.EditValue, Integer?), _
                                                                                CType(shiftLookUpEdit.EditValue, Integer?), CType(machineLookUpEdit.EditValue, Integer?), GetItemsSelected("|"c), _
                                                                                InactiveItemsCheckEdit.Checked, InactiveCustomersCheckEdit.Checked)
                If OnlyAssigned Then
                    m_Report.FilterString = New InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session)).ToString
                End If
                CType(m_Report, CostingXtraReport).Detail.SortFields.AddRange(New GroupField() {New GroupField("ProdMainDate"), New GroupField("ItemCode")})
                CType(m_Report, CostingXtraReport).reportCriteriaXrLabel.Text = GetFilterUsed(True)

            Case "ShippingXtraReport"
                m_Report.DataSource = ShippingReportBLL.GetShippingReport(CType(fromDateEdit.EditValue, Date?), CType(toDateEdit.EditValue, Date?), CType(shiftLookUpEdit.EditValue, Integer?), _
                                                                                CType(customerLookUpEdit.EditValue, Integer?), CStr(lotTextEdit.EditValue), CStr(poTextEdit.EditValue), _
                                                                                CStr(bolTextEdit.EditValue), CStr(deliveryNoteNumberTextEdit.EditValue), _
                                                                                CType(destinationLookUpEdit.EditValue, Integer?), CType(carrierLookUpEdit.EditValue, Integer?), GetItemsSelected("|"c), _
                                                                                InactiveItemsCheckEdit.Checked, InactiveCustomersCheckEdit.Checked, OnlyAssigned)
                CType(m_Report, TransportationXtraReport).Detail.SortFields.AddRange(New GroupField() {New GroupField("ShipMainDate"), New GroupField("ItemCode")})
                CType(m_Report, TransportationXtraReport).reportCriteriaXrLabel.Text = GetFilterUsed(True)

            Case "ShippingReturnsXtraReport"
                m_Report.DataSource = ShippingReturnsReportBLL.GetShippingReturnsReport(CType(fromDateEdit.EditValue, Date?), CType(toDateEdit.EditValue, Date?), _
                                                                                              CType(shiftLookUpEdit.EditValue, Integer?), CType(customerLookUpEdit.EditValue, Integer?), _
                                                                                              CStr(lotTextEdit.EditValue), CStr(bolTextEdit.EditValue), _
                                                                                              CType(destinationLookUpEdit.EditValue, Integer?), CType(carrierLookUpEdit.EditValue, Integer?), GetItemsSelected("|"c), _
                                                                                              InactiveItemsCheckEdit.Checked, InactiveCustomersCheckEdit.Checked, OnlyAssigned)
                CType(m_Report, TransportationXtraReport).Detail.SortFields.AddRange(New GroupField() {New GroupField("ShipMainDate"), New GroupField("ItemCode")})
                CType(m_Report, TransportationXtraReport).reportCriteriaXrLabel.Text = GetFilterUsed(True)

            Case "ReceivingXtraReport"
                m_Report.DataSource = ReceivingReportBLL.GetReceivingReport(CType(fromDateEdit.EditValue, Date?), CType(toDateEdit.EditValue, Date?), CType(shiftLookUpEdit.EditValue, Integer?), _
                                                                                  CType(customerLookUpEdit.EditValue, Integer?), CStr(lotTextEdit.EditValue), CStr(poTextEdit.EditValue), _
                                                                                  CStr(bolTextEdit.EditValue), CType(vendorLookUpEdit.EditValue, Integer?), CType(carrierLookUpEdit.EditValue, Integer?), _
                                                                                  GetItemsSelected("|"c), InactiveItemsCheckEdit.Checked, OnlyAssigned, InactiveCustomersCheckEdit.Checked)
                CType(m_Report, TransportationXtraReport).Detail.SortFields.AddRange(New GroupField() {New GroupField("ReceivDate"), New GroupField("ItemCode")})
                CType(m_Report, TransportationXtraReport).reportCriteriaXrLabel.Text = GetFilterUsed(True)

            Case "ReceivingReturnsXtraReport"
                m_Report.DataSource = ReceivingReturnsReportBLL.GetReceivingReturnsReport(CType(fromDateEdit.EditValue, Date?), CType(toDateEdit.EditValue, Date?), _
                                                                                                CType(shiftLookUpEdit.EditValue, Integer?), CType(customerLookUpEdit.EditValue, Integer?), _
                                                                                                CStr(lotTextEdit.EditValue), CStr(bolTextEdit.EditValue), CType(vendorLookUpEdit.EditValue, Integer?), _
                                                                                                CType(carrierLookUpEdit.EditValue, Integer?), GetItemsSelected("|"c), InactiveItemsCheckEdit.Checked, _
                                                                                                InactiveCustomersCheckEdit.Checked, OnlyAssigned)
                CType(m_Report, TransportationXtraReport).Detail.SortFields.AddRange(New GroupField() {New GroupField("ReceivDate"), New GroupField("ItemCode")})
                CType(m_Report, TransportationXtraReport).reportCriteriaXrLabel.Text = GetFilterUsed(True)

            Case "InventoryAdjustmentXtraReport"
                m_Report.DataSource = New InventoryAdjustmentReportBLL().GetInventoryAdjustmentReport(CType(fromDateEdit.EditValue, Date?), CType(toDateEdit.EditValue, Date?), _
                                                                                                      CType(customerLookUpEdit.EditValue, Integer?), GetItemsSelected("|"c), InactiveItemsCheckEdit.Checked, _
                                                                                                      InactiveCustomersCheckEdit.Checked)
                If OnlyAssigned Then
                    m_Report.FilterString = New InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session)).ToString
                End If
                CType(m_Report, InventoryXtraReport).Detail.SortFields.AddRange(New GroupField() {New GroupField("AdjustmentDate"), New GroupField("ItemCode")})
                CType(m_Report, InventoryXtraReport).reportCriteriaXrLabel.Text = GetFilterUsed(True)

            Case "PhysicalInventoryXtraReport"
                m_Report.DataSource = New PhysicalInventoryWorksheetBLL().GetPhysicalInventoryWorksheet(CType(customerLookUpEdit.EditValue, Integer?), CStr(itemTypeLookUpEdit.EditValue), _
                                                                                                        GetItemsSelected("|"c), InactiveItemsCheckEdit.Checked, InactiveCustomersCheckEdit.Checked)
                If OnlyAssigned Then
                    m_Report.FilterString = New InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session)).ToString
                End If
                CType(m_Report, InventoryXtraReport).Detail.SortFields.Add(New GroupField("ItemCode"))
                CType(m_Report, InventoryXtraReport).reportCriteriaXrLabel.Text = GetFilterUsed(True)

            Case "CurrentInventoryXtraReport"
                m_Report.DataSource = CurrentInventoryReportBLL.GetCurrentInventoryReport(CType(customerLookUpEdit.EditValue, Integer?), CStr(itemTypeLookUpEdit.EditValue), GetItemsSelected("|"c), _
                                                                                                InactiveItemsCheckEdit.Checked, InactiveCustomersCheckEdit.Checked, outOfStockCheckEdit.Checked, OnlyAssigned, Nothing)
                CType(m_Report, InventoryXtraReport).Detail.SortFields.Add(New GroupField("ItemCode"))
                CType(m_Report, InventoryXtraReport).reportCriteriaXrLabel.Text = GetFilterUsed(True)

            Case "FinishedProductAvailabilityXtraReport"
                m_Report.DataSource = New FinishedProductAvailabilityReportBLL().GetFinishedProductAvailabilityReport(CType(customerLookUpEdit.EditValue, Integer?), InactiveItemsCheckEdit.Checked, _
                                                                                                                      InactiveCustomersCheckEdit.Checked, GetItemsSelected("|"c))
                If OnlyAssigned Then
                    m_Report.FilterString = New InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session)).ToString
                End If
                CType(m_Report, InventoryXtraReport).Detail.SortFields.Add(New GroupField("ItemCode"))
                CType(m_Report, InventoryXtraReport).reportCriteriaXrLabel.Text = GetFilterUsed(True)

            Case "ItemsListXtraReport"
                m_Report.DataSource = New ItemsListBLL().GetItemsList(CType(customerLookUpEdit.EditValue, Integer?), CStr(itemTypeLookUpEdit.EditValue), GetItemsSelected("|"c), InactiveItemsCheckEdit.Checked, _
                                                                      InactiveCustomersCheckEdit.Checked)
                If OnlyAssigned Then
                    m_Report.FilterString = New InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session)).ToString
                End If
                CType(m_Report, ItemsXtraReport).Detail.SortFields.Add(New GroupField("ItemCode"))
                CType(m_Report, ItemsXtraReport).reportCriteriaXrLabel.Text = GetFilterUsed(True)

            Case "ItemsTransactionsXtraReport"
                m_Report.DataSource = New ItemsTransactionsReportBLL().GetItemsTransactionsReport(CType(fromDateEdit.EditValue, Date?), CType(toDateEdit.EditValue, Date?), _
                                                                                                  CType(itemCheckedListBoxControl.SelectedValue, Integer?))
                If OnlyAssigned Then
                    m_Report.FilterString = New InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session)).ToString
                End If
                CType(m_Report, ItemTransactionXtraReport).reportCriteriaXrLabel.Text = GetFilterUsed(True)

            Case "ItemTransactionSummaryXtraReport"
                m_Report.DataSource = New ItemTransactionSummaryReportBLL().GetItemTransactionSummaryReport(CType(fromDateEdit.EditValue, Date?), CType(toDateEdit.EditValue, Date?), CType(customerLookUpEdit.EditValue, Integer?),
                                                                                                            GetItemsSelected("|"c), CType(itemTypeLookUpEdit.EditValue, String), OnlyAssigned)
                CType(m_Report, ItemsXtraReport).Detail.SortFields.Add(New GroupField("ItemCode"))
                CType(m_Report, ItemsXtraReport).reportCriteriaXrLabel.Text = GetFilterUsed(True)

            Case "PalletTransactionXtraReport"
                m_Report.DataSource = New PalletsTransactionReportBLL().GetPalletTransactionReport(CType(fromDateEdit.EditValue, Date?), CType(toDateEdit.EditValue, Date?), _
                                                                                                   CType(customerLookUpEdit.EditValue, Integer?))
                If OnlyAssigned Then
                    m_Report.FilterString = New InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session)).ToString
                End If
                CType(m_Report, PalletTransactionXtraReport).reportCriteriaXrLabel.Text = GetFilterUsed(True)

            Case "PalletControlXtraReport"
                If OnlyAssigned Then
                    m_Report.FilterString = New InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session)).ToString
                End If
                m_Report.DataSource = New PalletControlReportBLL().GetPalletControlReport()

            Case "AuditTrailXtraReport"
                m_Report.DataSource = New AuditTrailReportBLL().GetAuditTrailReport(CType(fromDateEdit.EditValue, Date?), CType(toDateEdit.EditValue, Date?))
                CType(m_Report, AuditTrailXtraReport).reportCriteriaXrLabel.Text = GetFilterUsed(True)

            Case "ProductionMachineXtraReport"
                CType(m_Report, ProductionMachineXtraReport).productionXPView.CriteriaString = GetXPOCriteriaString()
                If OnlyAssigned Then
                    m_Report.FilterString = New InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session)).ToString
                End If
                CType(m_Report, ProductionMachineXtraReport).reportCriteriaXrLabel.Text = GetFilterUsed(True)
            Case "ProductionShiftXtraReport"
                CType(m_Report, ProductionShiftXtraReport).productionXPView.CriteriaString = GetXPOCriteriaString()
                If OnlyAssigned Then
                    m_Report.FilterString = New InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session)).ToString
                End If
                CType(m_Report, ProductionShiftXtraReport).reportCriteriaXrLabel.Text = GetFilterUsed(True)
        End Select

        Try
            m_Report.CreateDocument()


            If TryCast(m_Report.DataSource, XPView) IsNot Nothing Then
                If CType(m_Report.DataSource, XPView).Count <= 0 Then
                    MessageBox.Show("There's no data to display. Try changing your filter.")
                End If
            ElseIf TryCast(m_Report.DataSource, ItemTransactionsList) IsNot Nothing Then
                If CType(m_Report.DataSource, ItemTransactionsList).Count <= 0 Then
                    MessageBox.Show("There's no data to display. Try changing your filter.")
                End If
            ElseIf TryCast(m_Report.DataSource, ItemTransactionSummaryList) IsNot Nothing Then
                If CType(m_Report.DataSource, ItemTransactionSummaryList).Count <= 0 Then
                    MessageBox.Show("There's no data to display. Try changing your filter.")
                End If
            ElseIf TryCast(m_Report.DataSource, PalletTransactionList) IsNot Nothing Then
                If CType(m_Report.DataSource, PalletTransactionList).Count <= 0 Then
                    MessageBox.Show("There's no data to display. Try changing your filter.")
                End If
            Else
                If CType(m_Report.DataSource, DataTable).Rows.Count <= 0 Then
                    MessageBox.Show("There's no data to display. Try changing your filter.")
                End If
            End If
        Catch ex As NullReferenceException
            MessageBox.Show(String.Format("There was an error while trying to generate your report.{0}{1}", vbCrLf, ex.Message))
        End Try

    End Sub

    Private Sub filterRefreshSimpleButton_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles filterRefreshSimpleButton.Click

        If fromDateEdit.DateTime > toDateEdit.DateTime Then
            MessageBox.Show("The from date must be an earlier date than the to date.")
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor
        If m_SelectedReport <> "PalletControlXtraReport" AndAlso m_SelectedReport <> "ItemsTransactionsXtraReport" AndAlso m_SelectedReport <> "PalletTransactionXtraReport" Then
            m_Report.PrintingSystem.Document.AutoFitToPagesWidth = 0
            m_Report.PrintingSystem.Document.ScaleFactor = 1
        End If
        BindReport()
        If m_SelectedReport <> "PalletControlXtraReport" AndAlso m_SelectedReport <> "ItemsTransactionsXtraReport" AndAlso m_SelectedReport <> "PalletTransactionXtraReport" Then
            m_Report.PrintingSystem.Document.AutoFitToPagesWidth = 1
        End If
        Cursor = Cursors.Default

    End Sub

    Public Function GetFilterUsed(ByVal display As Boolean) As String

        Dim strSQL As StringBuilder = New StringBuilder()

        If Not fromDateEdit.EditValue Is Nothing AndAlso fromDateEdit.Enabled = True Then
            strSQL.AppendFormat("Date >= {0} AND ", Format(fromDateEdit.EditValue, "d"))
        End If

        If Not toDateEdit.EditValue Is Nothing AndAlso toDateEdit.Enabled = True Then
            strSQL.AppendFormat("Date <= {0} AND ", Format(toDateEdit.EditValue, "d"))
        End If

        If Not customerLookUpEdit.EditValue Is Nothing Then
            strSQL.AppendFormat("Customer Name = {0} AND ", customerLookUpEdit.Text)
        End If

        If itemCheckedListBoxControl.CheckedItems.Count >= 1 Then
            strSQL.AppendFormat("Item Code IN {0} AND ", GetItemsSelected(","c, True))
        End If

        If Not machineLookUpEdit.EditValue Is Nothing Then
            strSQL.AppendFormat("Machine Line = {0} AND ", machineLookUpEdit.Text)
        End If

        If Not shiftLookUpEdit.EditValue Is Nothing Then
            strSQL.AppendFormat("Shift = '{0}' AND ", shiftLookUpEdit.Text)
        End If

        If Not lotTextEdit.EditValue Is Nothing Then
            strSQL.AppendFormat("Lot # = {0} AND ", lotTextEdit.Text)
        End If

        If Not poTextEdit.EditValue Is Nothing Then
            strSQL.AppendFormat("PO # = {0} AND ", poTextEdit.Text)
        End If

        If Not bolTextEdit.EditValue Is Nothing Then
            strSQL.AppendFormat("BOL # = {0} AND ", bolTextEdit.Text)
        End If

        If Not deliveryNoteNumberTextEdit.EditValue Is Nothing Then
            strSQL.AppendFormat("DN # = {0} AND ", deliveryNoteNumberTextEdit.Text)
        End If

        If Not destinationLookUpEdit.EditValue Is Nothing Then
            strSQL.AppendFormat("Destination = {0} AND ", destinationLookUpEdit.Text)
        End If

        If Not carrierLookUpEdit.EditValue Is Nothing Then
            strSQL.AppendFormat("Carrier = {0} AND ", carrierLookUpEdit.Text)
        End If

        If Not vendorLookUpEdit.EditValue Is Nothing Then
            strSQL.AppendFormat("Vendor = {0} AND ", vendorLookUpEdit.Text)
        End If

        If Not itemTypeLookUpEdit.EditValue Is Nothing Then
            strSQL.AppendFormat("Item Type = {0} AND ", itemTypeLookUpEdit.Text)
        End If

        If InactiveCustomersCheckEdit.Checked Then
            strSQL.Append("Included inactive customers AND ")
        End If

        If InactiveItemsCheckEdit.Checked Then
            strSQL.Append("Included inactive items AND ")
        End If

        If outOfStockCheckEdit.Checked Then
            strSQL.Append("Included out of stock items AND ")
        End If

        If strSQL.Length > 5 Then
            strSQL.Length -= 5
        End If

        Return strSQL.ToString

    End Function

    Public Function GetXPOCriteriaString() As String

        Dim strSQL As StringBuilder = New StringBuilder()

        If Not fromDateEdit.EditValue Is Nothing AndAlso fromDateEdit.Enabled = True Then
            strSQL.AppendFormat("[ProdMainDate] >= #{0}# AND ", Format(fromDateEdit.EditValue, "MM/dd/yyyy"))
        End If

        If Not toDateEdit.EditValue Is Nothing AndAlso toDateEdit.Enabled = True Then
            strSQL.AppendFormat("[ProdMainDate] <= #{0}# AND ", Format(toDateEdit.EditValue, "MM/dd/yyyy"))
        End If

        If Not customerLookUpEdit.EditValue Is Nothing Then
            strSQL.AppendFormat("[ProdMainItemID.ItemCustomerID] = '{0}' AND ", customerLookUpEdit.EditValue)
        End If

        If Not machineLookUpEdit.EditValue Is Nothing Then
            strSQL.AppendFormat("[ProdMainMachineLine] = {0} AND ", machineLookUpEdit.EditValue)
        End If

        If Not shiftLookUpEdit.EditValue Is Nothing Then
            strSQL.AppendFormat("[ProdMainShift] = '{0}' AND ", shiftLookUpEdit.EditValue)
        End If

        If InactiveCustomersCheckEdit.Checked = False Then
            strSQL.Append("[ProdMainItemID.ItemCustomerID.Inactive] = False AND ")
        End If

        If InactiveItemsCheckEdit.Checked = False Then
            strSQL.Append("[ProdMainItemID.Inactive] = False AND ")
        End If

        If itemCheckedListBoxControl.CheckedItems.Count >= 1 Then
            strSQL.Append("(")
            For i As Integer = 0 To itemCheckedListBoxControl.CheckedItems.Count - 1
                If i > 0 Then
                    strSQL.Append(" OR ")
                End If
                strSQL.Append(String.Format("[ProdMainItemID] = {0}", itemCheckedListBoxControl.CheckedItems.Item(i).ToString))
            Next
            strSQL.Append(") AND ")
        End If

        If strSQL.Length > 5 Then
            strSQL.Length -= 5
        End If

        Return strSQL.ToString

    End Function

    Private Function GetItemsSelected(ByVal delimiter As Char) As String

        Dim itemsSelected As StringBuilder = New StringBuilder(String.Empty)
        For i As Integer = 0 To itemCheckedListBoxControl.CheckedItems.Count - 1
            itemsSelected.Append(String.Format("{0}{1}", itemCheckedListBoxControl.CheckedItems.Item(i).ToString, delimiter))
        Next

        Return itemsSelected.ToString.TrimEnd(delimiter)

    End Function

    Private Function GetItemsSelected(ByVal delimiter As Char, ByVal display As Boolean) As String

        Dim itemsSelected As StringBuilder = New StringBuilder(String.Empty)
        For i As Integer = 0 To itemCheckedListBoxControl.CheckedItems.Count - 1
            If display = False Then
                itemsSelected.Append(String.Format("{0}{1}", itemCheckedListBoxControl.CheckedItems.Item(i).ToString, delimiter))
            Else
                itemsSelected.Append(String.Format("{0}{1}", itemCheckedListBoxControl.GetItemText(itemCheckedListBoxControl.CheckedIndices.Item(i)), delimiter))
            End If
        Next

        Return itemsSelected.ToString.TrimEnd(delimiter)

    End Function

    Private Sub columnsRefreshSimpleButton_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles columnsRefreshSimpleButton.Click

        Me.Cursor = Cursors.WaitCursor
        If m_SelectedReport <> "PalletControlXtraReport" AndAlso m_SelectedReport <> "ItemsTransactionsXtraReport" AndAlso m_SelectedReport <> "PalletTransactionXtraReport" Then
            m_Report.PrintingSystem.Document.AutoFitToPagesWidth = 0
            m_Report.PrintingSystem.Document.ScaleFactor = 1
        End If
        SetReportColumns(m_SelectedReport, 0)
        m_Report.CreateDocument()
        If m_SelectedReport <> "PalletControlXtraReport" AndAlso m_SelectedReport <> "ItemsTransactionsXtraReport" AndAlso m_SelectedReport <> "PalletTransactionXtraReport" Then
            m_Report.PrintingSystem.Document.AutoFitToPagesWidth = 1
        End If
        Me.Cursor = Cursors.Default

    End Sub

    Private m_ReportTitle As String
    Public Property ReportTitle() As String
        Get
            If m_ReportTitle = "Physical Inventory Worksheet" OrElse m_ReportTitle = "Items List" Then
                Return m_ReportTitle
            Else
                Return String.Format("{0} Report", m_ReportTitle)
            End If
        End Get
        Set(ByVal value As String)
            m_ReportTitle = value
        End Set
    End Property

    Private Sub ReportsXtraForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        Me.reportColumnsXtraTabControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False

    End Sub

    Private Sub itemCheckedListBoxControl_ItemCheck(ByVal sender As System.Object, ByVal e As ItemCheckEventArgs) Handles itemCheckedListBoxControl.ItemCheck

        If m_Report.Name = "ItemsTransactionsXtraReport" Then
            If e.State = CheckState.Checked Then
                For Each item As CheckedListBoxItem In itemCheckedListBoxControl.Items
                    If item.Value IsNot itemCheckedListBoxControl.Items(e.Index).Value AndAlso item.CheckState = CheckState.Checked Then
                        item.CheckState = CheckState.Unchecked
                    End If
                Next item
            End If
        End If

    End Sub

End Class