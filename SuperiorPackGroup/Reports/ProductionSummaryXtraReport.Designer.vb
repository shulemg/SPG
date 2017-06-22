<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ProductionSummaryXtraReport
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Style1 = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.detailTable = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.productionDate = New DevExpress.XtraReports.UI.XRTableCell()
        Me.productionShift = New DevExpress.XtraReports.UI.XRTableCell()
        Me.productionCustomer = New DevExpress.XtraReports.UI.XRTableCell()
        Me.productionItemCode = New DevExpress.XtraReports.UI.XRTableCell()
        Me.productionStartTime = New DevExpress.XtraReports.UI.XRTableCell()
        Me.productionEndtime = New DevExpress.XtraReports.UI.XRTableCell()
        Me.totalProductionHours = New DevExpress.XtraReports.UI.XRTableCell()
        Me.qtyProduced = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.CriteriaLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.AverageActualSpeedH = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.totalHours = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow8 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.totalMinutesLabel = New DevExpress.XtraReports.UI.XRTableCell()
        Me.totalMinutes = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell36 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.totalQtyProduced = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow10 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.averageActualSpeed = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow17 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell49 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.totalPacksPerMin = New DevExpress.XtraReports.UI.XRTableCell()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me.detailTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Style1
        '
        Me.Style1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Style1.BorderColor = System.Drawing.SystemColors.ControlText
        Me.Style1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Style1.BorderWidth = 1
        Me.Style1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Style1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Style1.Name = "Style1"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.detailTable})
        Me.Detail.HeightF = 25.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.Detail.Visible = False
        '
        'detailTable
        '
        Me.detailTable.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.detailTable.Name = "detailTable"
        Me.detailTable.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.detailTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.detailTable.SizeF = New System.Drawing.SizeF(1050.0!, 25.0!)
        Me.detailTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.productionDate, Me.productionShift, Me.productionCustomer, Me.productionItemCode, Me.productionStartTime, Me.productionEndtime, Me.totalProductionHours, Me.qtyProduced})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableRow1.Weight = 1.0R
        '
        'productionDate
        '
        Me.productionDate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qrptProduction.ProdMainDate", "{0:dddd, MMMM dd, yyyy}")})
        Me.productionDate.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.productionDate.Name = "productionDate"
        Me.productionDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.productionDate.Text = "productionDate"
        Me.productionDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.productionDate.Weight = 0.11714285714285715R
        '
        'productionShift
        '
        Me.productionShift.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qrptProduction.ShiftName")})
        Me.productionShift.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.productionShift.Name = "productionShift"
        Me.productionShift.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.productionShift.Text = "productionShift"
        Me.productionShift.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.productionShift.Weight = 0.07047619047619047R
        '
        'productionCustomer
        '
        Me.productionCustomer.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qrptProduction.CustomerName")})
        Me.productionCustomer.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.productionCustomer.Name = "productionCustomer"
        Me.productionCustomer.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.productionCustomer.Text = "productionCustomer"
        Me.productionCustomer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.productionCustomer.Weight = 0.16380952380952382R
        '
        'productionItemCode
        '
        Me.productionItemCode.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qrptProduction.ItemCode")})
        Me.productionItemCode.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.productionItemCode.Name = "productionItemCode"
        Me.productionItemCode.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.productionItemCode.Text = "productionItemCode"
        Me.productionItemCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.productionItemCode.Weight = 0.24952380952380954R
        '
        'productionStartTime
        '
        Me.productionStartTime.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qrptProduction.ProdMainTimeStart", "{0:h:mm tt}")})
        Me.productionStartTime.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.productionStartTime.Name = "productionStartTime"
        Me.productionStartTime.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.productionStartTime.Text = "productionStartTime"
        Me.productionStartTime.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.productionStartTime.Weight = 0.078095238095238093R
        '
        'productionEndtime
        '
        Me.productionEndtime.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qrptProduction.ProdMainTimeStop", "{0:h:mm tt}")})
        Me.productionEndtime.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.productionEndtime.Name = "productionEndtime"
        Me.productionEndtime.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.productionEndtime.Text = "productionEndtime"
        Me.productionEndtime.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.productionEndtime.Weight = 0.07047619047619047R
        '
        'totalProductionHours
        '
        Me.totalProductionHours.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qrptProduction.TotalHours")})
        Me.totalProductionHours.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.totalProductionHours.Name = "totalProductionHours"
        Me.totalProductionHours.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.totalProductionHours.Text = "totalProductionHours"
        Me.totalProductionHours.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.totalProductionHours.Weight = 0.10857142857142857R
        '
        'qtyProduced
        '
        Me.qtyProduced.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qrptProduction.ProdMainQuantity")})
        Me.qtyProduced.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.qtyProduced.Name = "qtyProduced"
        Me.qtyProduced.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.qtyProduced.Text = "qtyProduced"
        Me.qtyProduced.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.qtyProduced.Weight = 0.14190476190476189R
        '
        'PageHeader
        '
        Me.PageHeader.HeightF = 30.0!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 30.0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo2, Me.CriteriaLabel, Me.XrLabel1})
        Me.ReportHeader.HeightF = 98.0!
        Me.ReportHeader.KeepTogether = True
        Me.ReportHeader.Name = "ReportHeader"
        Me.ReportHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrPageInfo2
        '
        Me.XrPageInfo2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(833.0!, 67.0!)
        Me.XrPageInfo2.Name = "XrPageInfo2"
        Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(200.0!, 25.0!)
        Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'CriteriaLabel
        '
        Me.CriteriaLabel.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.CriteriaLabel.LocationFloat = New DevExpress.Utils.PointFloat(8.0!, 58.0!)
        Me.CriteriaLabel.Name = "CriteriaLabel"
        Me.CriteriaLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.CriteriaLabel.SizeF = New System.Drawing.SizeF(634.0!, 34.0!)
        Me.CriteriaLabel.Text = "CriteriaLabel"
        Me.CriteriaLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 8.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(1050.0!, 50.0!)
        Me.XrLabel1.Text = "Production Summary Report"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.AverageActualSpeedH, Me.XrTable3})
        Me.ReportFooter.HeightF = 151.0!
        Me.ReportFooter.KeepTogether = True
        Me.ReportFooter.Name = "ReportFooter"
        Me.ReportFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.ReportFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'AverageActualSpeedH
        '
        Me.AverageActualSpeedH.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qrptProduction.ActualSpeed")})
        Me.AverageActualSpeedH.LocationFloat = New DevExpress.Utils.PointFloat(17.0!, 8.0!)
        Me.AverageActualSpeedH.Name = "AverageActualSpeedH"
        Me.AverageActualSpeedH.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.AverageActualSpeedH.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.AverageActualSpeedH.Summary = XrSummary1
        Me.AverageActualSpeedH.Text = "AverageActualSpeedH"
        Me.AverageActualSpeedH.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.AverageActualSpeedH.Visible = False
        '
        'XrTable3
        '
        Me.XrTable3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(242.0!, 17.0!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow7, Me.XrTableRow8, Me.XrTableRow9, Me.XrTableRow10, Me.XrTableRow17})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(567.0!, 125.0!)
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell32, Me.totalHours})
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableRow7.Weight = 0.2R
        '
        'XrTableCell32
        '
        Me.XrTableCell32.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.XrTableCell32.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell32.StyleName = "Style1"
        Me.XrTableCell32.Text = "Total Hours"
        Me.XrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell32.Weight = 0.5149911816578483R
        '
        'totalHours
        '
        Me.totalHours.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qrptProduction.TotalHours")})
        Me.totalHours.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalHours.Name = "totalHours"
        Me.totalHours.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        XrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.totalHours.Summary = XrSummary2
        Me.totalHours.Text = "totalHours"
        Me.totalHours.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.totalHours.Weight = 0.48500881834215165R
        '
        'XrTableRow8
        '
        Me.XrTableRow8.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.totalMinutesLabel, Me.totalMinutes})
        Me.XrTableRow8.Name = "XrTableRow8"
        Me.XrTableRow8.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableRow8.Weight = 0.2R
        '
        'totalMinutesLabel
        '
        Me.totalMinutesLabel.Name = "totalMinutesLabel"
        Me.totalMinutesLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.totalMinutesLabel.StyleName = "Style1"
        Me.totalMinutesLabel.Text = "Total Minutes"
        Me.totalMinutesLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.totalMinutesLabel.Weight = 0.5149911816578483R
        '
        'totalMinutes
        '
        Me.totalMinutes.BackColor = System.Drawing.Color.Transparent
        Me.totalMinutes.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.totalMinutes.Name = "totalMinutes"
        Me.totalMinutes.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.totalMinutes.Text = "XrTableCell35"
        Me.totalMinutes.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.totalMinutes.Weight = 0.48500881834215165R
        '
        'XrTableRow9
        '
        Me.XrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell36, Me.totalQtyProduced})
        Me.XrTableRow9.Name = "XrTableRow9"
        Me.XrTableRow9.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableRow9.Weight = 0.2R
        '
        'XrTableCell36
        '
        Me.XrTableCell36.Name = "XrTableCell36"
        Me.XrTableCell36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell36.StyleName = "Style1"
        Me.XrTableCell36.Text = "Total Quantity Produced"
        Me.XrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell36.Weight = 0.5149911816578483R
        '
        'totalQtyProduced
        '
        Me.totalQtyProduced.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "qrptProduction.ProdMainQuantity")})
        Me.totalQtyProduced.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.totalQtyProduced.Name = "totalQtyProduced"
        Me.totalQtyProduced.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.totalQtyProduced.Summary = XrSummary3
        Me.totalQtyProduced.Text = "totalQtyProduced"
        Me.totalQtyProduced.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.totalQtyProduced.Weight = 0.48500881834215165R
        '
        'XrTableRow10
        '
        Me.XrTableRow10.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell33, Me.averageActualSpeed})
        Me.XrTableRow10.Name = "XrTableRow10"
        Me.XrTableRow10.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableRow10.Weight = 0.2R
        '
        'XrTableCell33
        '
        Me.XrTableCell33.Name = "XrTableCell33"
        Me.XrTableCell33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell33.StyleName = "Style1"
        Me.XrTableCell33.Text = "Average Actual Speed"
        Me.XrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell33.Weight = 0.5149911816578483R
        '
        'averageActualSpeed
        '
        Me.averageActualSpeed.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.averageActualSpeed.Name = "averageActualSpeed"
        Me.averageActualSpeed.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.averageActualSpeed.Text = "averageActualSpeed"
        Me.averageActualSpeed.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.averageActualSpeed.Weight = 0.48500881834215165R
        '
        'XrTableRow17
        '
        Me.XrTableRow17.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell49, Me.totalPacksPerMin})
        Me.XrTableRow17.Name = "XrTableRow17"
        Me.XrTableRow17.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.XrTableRow17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableRow17.Weight = 0.2R
        '
        'XrTableCell49
        '
        Me.XrTableCell49.Name = "XrTableCell49"
        Me.XrTableCell49.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTableCell49.StyleName = "Style1"
        Me.XrTableCell49.Text = "Average Packs Per Minute"
        Me.XrTableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell49.Weight = 0.5149911816578483R
        '
        'totalPacksPerMin
        '
        Me.totalPacksPerMin.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.totalPacksPerMin.Name = "totalPacksPerMin"
        Me.totalPacksPerMin.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.totalPacksPerMin.Text = "totalPacksPerMin"
        Me.totalPacksPerMin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.totalPacksPerMin.Weight = 0.48500881834215165R
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 50.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 50.0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'ProductionSummaryXtraReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.ReportHeader, Me.ReportFooter, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 50, 50)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Style1})
        Me.Version = "11.2"
        CType(Me.detailTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents CriteriaLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents detailTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents productionDate As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents productionShift As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents productionCustomer As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents productionItemCode As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents productionStartTime As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents productionEndtime As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents totalProductionHours As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents qtyProduced As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents totalHours As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow8 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents totalMinutesLabel As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents totalMinutes As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell36 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents totalQtyProduced As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow10 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents averageActualSpeed As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow17 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell49 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents totalPacksPerMin As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents AverageActualSpeedH As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Style1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
End Class
