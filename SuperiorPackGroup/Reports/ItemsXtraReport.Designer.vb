<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ItemsXtraReport
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
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.shippedDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.receivedDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.adjustedDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.unitsPerCaseDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.quantityDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.producedDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.itemTypeDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.uomDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.itemDescriptionDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.itemCodeDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.casesPerPalletDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.customerNameDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.headerXrPanel = New DevExpress.XtraReports.UI.XRPanel()
        Me.AdjustedHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.receivedHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.shippedHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.unitsPerCaseHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.quantityHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.producedHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.itemTypeHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.uomHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.itemDescriptionHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.itemCodeHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.casesPerPalletHeadeerXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.customerNameHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.pageNumberXrPageInfo = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.printDateXrPageInfo = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.reportCriteriaXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.reportTitleXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.footerXrPanel = New DevExpress.XtraReports.UI.XRPanel()
        Me.receivedFooterXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.shippedFooterXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.producedFooterXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.adjustedFooterXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.headerXrControlStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.footerXrControlStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.detailOddXrControlStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.detailEvenXrControlStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.usedInProductionHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.usedInProductionDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.usedInProductionFooterXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.usedInProductionDetailXrLabel, Me.shippedDetailXrLabel, Me.receivedDetailXrLabel, Me.adjustedDetailXrLabel, Me.unitsPerCaseDetailXrLabel, Me.quantityDetailXrLabel, Me.producedDetailXrLabel, Me.itemTypeDetailXrLabel, Me.uomDetailXrLabel, Me.itemDescriptionDetailXrLabel, Me.itemCodeDetailXrLabel, Me.casesPerPalletDetailXrLabel, Me.customerNameDetailXrLabel})
        Me.Detail.HeightF = 30.0!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'shippedDetailXrLabel
        '
        Me.shippedDetailXrLabel.CanGrow = False
        Me.shippedDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.shippedDetailXrLabel.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.shippedDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(803.0!, 0.0!)
        Me.shippedDetailXrLabel.Name = "shippedDetailXrLabel"
        Me.shippedDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.shippedDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.shippedDetailXrLabel.SizeF = New System.Drawing.SizeF(81.0!, 30.0!)
        Me.shippedDetailXrLabel.StylePriority.UseFont = False
        Me.shippedDetailXrLabel.StylePriority.UseTextAlignment = False
        Me.shippedDetailXrLabel.Text = "shippedDetailXrLabel"
        Me.shippedDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'receivedDetailXrLabel
        '
        Me.receivedDetailXrLabel.CanGrow = False
        Me.receivedDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.receivedDetailXrLabel.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.receivedDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(884.0!, 0.0!)
        Me.receivedDetailXrLabel.Name = "receivedDetailXrLabel"
        Me.receivedDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.receivedDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.receivedDetailXrLabel.SizeF = New System.Drawing.SizeF(81.0!, 30.0!)
        Me.receivedDetailXrLabel.StylePriority.UseFont = False
        Me.receivedDetailXrLabel.StylePriority.UseTextAlignment = False
        Me.receivedDetailXrLabel.Text = "receivedDetailXrLabel"
        Me.receivedDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'adjustedDetailXrLabel
        '
        Me.adjustedDetailXrLabel.CanGrow = False
        Me.adjustedDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.adjustedDetailXrLabel.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.adjustedDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(965.0!, 0.0!)
        Me.adjustedDetailXrLabel.Name = "adjustedDetailXrLabel"
        Me.adjustedDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.adjustedDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.adjustedDetailXrLabel.SizeF = New System.Drawing.SizeF(81.0!, 30.0!)
        Me.adjustedDetailXrLabel.StylePriority.UseFont = False
        Me.adjustedDetailXrLabel.StylePriority.UseTextAlignment = False
        Me.adjustedDetailXrLabel.Text = "adjustedDetailXrLabel"
        Me.adjustedDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'unitsPerCaseDetailXrLabel
        '
        Me.unitsPerCaseDetailXrLabel.CanGrow = False
        Me.unitsPerCaseDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.unitsPerCaseDetailXrLabel.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.unitsPerCaseDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(560.0!, 0.0!)
        Me.unitsPerCaseDetailXrLabel.Name = "unitsPerCaseDetailXrLabel"
        Me.unitsPerCaseDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.unitsPerCaseDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.unitsPerCaseDetailXrLabel.SizeF = New System.Drawing.SizeF(81.0!, 30.0!)
        Me.unitsPerCaseDetailXrLabel.StylePriority.UseFont = False
        Me.unitsPerCaseDetailXrLabel.StylePriority.UseTextAlignment = False
        Me.unitsPerCaseDetailXrLabel.Text = "unitsPerCaseDetailXrLabel"
        Me.unitsPerCaseDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'quantityDetailXrLabel
        '
        Me.quantityDetailXrLabel.CanGrow = False
        Me.quantityDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.quantityDetailXrLabel.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.quantityDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(479.0!, 0.0!)
        Me.quantityDetailXrLabel.Name = "quantityDetailXrLabel"
        Me.quantityDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.quantityDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.quantityDetailXrLabel.SizeF = New System.Drawing.SizeF(81.0!, 30.0!)
        Me.quantityDetailXrLabel.StylePriority.UseFont = False
        Me.quantityDetailXrLabel.Text = "quantityDetailXrLabel"
        Me.quantityDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'producedDetailXrLabel
        '
        Me.producedDetailXrLabel.CanGrow = False
        Me.producedDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.producedDetailXrLabel.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.producedDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(722.0!, 0.0!)
        Me.producedDetailXrLabel.Name = "producedDetailXrLabel"
        Me.producedDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.producedDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.producedDetailXrLabel.SizeF = New System.Drawing.SizeF(81.0!, 30.0!)
        Me.producedDetailXrLabel.StylePriority.UseFont = False
        Me.producedDetailXrLabel.StylePriority.UseTextAlignment = False
        Me.producedDetailXrLabel.Text = "producedDetailXrLabel"
        Me.producedDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'itemTypeDetailXrLabel
        '
        Me.itemTypeDetailXrLabel.CanGrow = False
        Me.itemTypeDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.itemTypeDetailXrLabel.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.itemTypeDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(295.0!, 0.0!)
        Me.itemTypeDetailXrLabel.Name = "itemTypeDetailXrLabel"
        Me.itemTypeDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.itemTypeDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemTypeDetailXrLabel.SizeF = New System.Drawing.SizeF(103.0!, 30.0!)
        Me.itemTypeDetailXrLabel.StylePriority.UseFont = False
        Me.itemTypeDetailXrLabel.StylePriority.UseTextAlignment = False
        Me.itemTypeDetailXrLabel.Text = "itemTypeDetailXrLabel"
        Me.itemTypeDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'uomDetailXrLabel
        '
        Me.uomDetailXrLabel.CanGrow = False
        Me.uomDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.uomDetailXrLabel.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.uomDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(398.0!, 0.0!)
        Me.uomDetailXrLabel.Name = "uomDetailXrLabel"
        Me.uomDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.uomDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.uomDetailXrLabel.SizeF = New System.Drawing.SizeF(81.0!, 30.0!)
        Me.uomDetailXrLabel.StylePriority.UseFont = False
        Me.uomDetailXrLabel.Text = "uomDetailXrLabel"
        Me.uomDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'itemDescriptionDetailXrLabel
        '
        Me.itemDescriptionDetailXrLabel.CanGrow = False
        Me.itemDescriptionDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.itemDescriptionDetailXrLabel.Font = New System.Drawing.Font("Times New Roman", 9.0!)
        Me.itemDescriptionDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(190.0!, 0.0!)
        Me.itemDescriptionDetailXrLabel.Name = "itemDescriptionDetailXrLabel"
        Me.itemDescriptionDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.itemDescriptionDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemDescriptionDetailXrLabel.SizeF = New System.Drawing.SizeF(105.0!, 30.0!)
        Me.itemDescriptionDetailXrLabel.StylePriority.UseFont = False
        Me.itemDescriptionDetailXrLabel.Text = "itemDescriptionDetailXrLabel"
        Me.itemDescriptionDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'itemCodeDetailXrLabel
        '
        Me.itemCodeDetailXrLabel.CanGrow = False
        Me.itemCodeDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.itemCodeDetailXrLabel.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.itemCodeDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(100.0!, 0.0!)
        Me.itemCodeDetailXrLabel.Name = "itemCodeDetailXrLabel"
        Me.itemCodeDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.itemCodeDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemCodeDetailXrLabel.SizeF = New System.Drawing.SizeF(90.0!, 30.0!)
        Me.itemCodeDetailXrLabel.StylePriority.UseFont = False
        Me.itemCodeDetailXrLabel.Text = "itemCodeDetailXrLabel"
        Me.itemCodeDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'casesPerPalletDetailXrLabel
        '
        Me.casesPerPalletDetailXrLabel.CanGrow = False
        Me.casesPerPalletDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.casesPerPalletDetailXrLabel.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.casesPerPalletDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(641.0!, 0.0!)
        Me.casesPerPalletDetailXrLabel.Name = "casesPerPalletDetailXrLabel"
        Me.casesPerPalletDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.casesPerPalletDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.casesPerPalletDetailXrLabel.SizeF = New System.Drawing.SizeF(81.0!, 30.0!)
        Me.casesPerPalletDetailXrLabel.StylePriority.UseFont = False
        Me.casesPerPalletDetailXrLabel.StylePriority.UseTextAlignment = False
        Me.casesPerPalletDetailXrLabel.Text = "casesPerPalletDetailXrLabel"
        Me.casesPerPalletDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'customerNameDetailXrLabel
        '
        Me.customerNameDetailXrLabel.CanGrow = False
        Me.customerNameDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.customerNameDetailXrLabel.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.customerNameDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.customerNameDetailXrLabel.Name = "customerNameDetailXrLabel"
        Me.customerNameDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.customerNameDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.customerNameDetailXrLabel.SizeF = New System.Drawing.SizeF(100.0!, 30.0!)
        Me.customerNameDetailXrLabel.StylePriority.UseFont = False
        Me.customerNameDetailXrLabel.Text = "customerNameDetailXrLabel"
        Me.customerNameDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.headerXrPanel})
        Me.PageHeader.HeightF = 50.0!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'headerXrPanel
        '
        Me.headerXrPanel.BorderColor = System.Drawing.Color.Black
        Me.headerXrPanel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.headerXrPanel.BorderWidth = 3
        Me.headerXrPanel.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.usedInProductionHeaderXrLabel, Me.AdjustedHeaderXrLabel, Me.receivedHeaderXrLabel, Me.shippedHeaderXrLabel, Me.unitsPerCaseHeaderXrLabel, Me.quantityHeaderXrLabel, Me.producedHeaderXrLabel, Me.itemTypeHeaderXrLabel, Me.uomHeaderXrLabel, Me.itemDescriptionHeaderXrLabel, Me.itemCodeHeaderXrLabel, Me.casesPerPalletHeadeerXrLabel, Me.customerNameHeaderXrLabel})
        Me.headerXrPanel.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.headerXrPanel.Name = "headerXrPanel"
        Me.headerXrPanel.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.headerXrPanel.SizeF = New System.Drawing.SizeF(1050.0!, 50.0!)
        '
        'AdjustedHeaderXrLabel
        '
        Me.AdjustedHeaderXrLabel.CanGrow = False
        Me.AdjustedHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.AdjustedHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(965.0!, 0.0!)
        Me.AdjustedHeaderXrLabel.Name = "AdjustedHeaderXrLabel"
        Me.AdjustedHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.AdjustedHeaderXrLabel.SizeF = New System.Drawing.SizeF(81.0!, 50.0!)
        Me.AdjustedHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.AdjustedHeaderXrLabel.StylePriority.UseFont = False
        Me.AdjustedHeaderXrLabel.Text = "Adjusted"
        Me.AdjustedHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'receivedHeaderXrLabel
        '
        Me.receivedHeaderXrLabel.CanGrow = False
        Me.receivedHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.receivedHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(884.0!, 0.0!)
        Me.receivedHeaderXrLabel.Name = "receivedHeaderXrLabel"
        Me.receivedHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.receivedHeaderXrLabel.SizeF = New System.Drawing.SizeF(81.0!, 50.0!)
        Me.receivedHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.receivedHeaderXrLabel.StylePriority.UseFont = False
        Me.receivedHeaderXrLabel.Text = "Received"
        Me.receivedHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'shippedHeaderXrLabel
        '
        Me.shippedHeaderXrLabel.CanGrow = False
        Me.shippedHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.shippedHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(803.0!, 0.0!)
        Me.shippedHeaderXrLabel.Name = "shippedHeaderXrLabel"
        Me.shippedHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.shippedHeaderXrLabel.SizeF = New System.Drawing.SizeF(81.0!, 50.0!)
        Me.shippedHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.shippedHeaderXrLabel.StylePriority.UseFont = False
        Me.shippedHeaderXrLabel.Text = "Shipped"
        Me.shippedHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'unitsPerCaseHeaderXrLabel
        '
        Me.unitsPerCaseHeaderXrLabel.CanGrow = False
        Me.unitsPerCaseHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.unitsPerCaseHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(560.0!, 0.0!)
        Me.unitsPerCaseHeaderXrLabel.Name = "unitsPerCaseHeaderXrLabel"
        Me.unitsPerCaseHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.unitsPerCaseHeaderXrLabel.SizeF = New System.Drawing.SizeF(81.0!, 50.0!)
        Me.unitsPerCaseHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.unitsPerCaseHeaderXrLabel.StylePriority.UseFont = False
        Me.unitsPerCaseHeaderXrLabel.Text = "Units per Case"
        Me.unitsPerCaseHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'quantityHeaderXrLabel
        '
        Me.quantityHeaderXrLabel.CanGrow = False
        Me.quantityHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.quantityHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(479.0!, 0.0!)
        Me.quantityHeaderXrLabel.Name = "quantityHeaderXrLabel"
        Me.quantityHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.quantityHeaderXrLabel.SizeF = New System.Drawing.SizeF(81.0!, 50.0!)
        Me.quantityHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.quantityHeaderXrLabel.StylePriority.UseFont = False
        Me.quantityHeaderXrLabel.Text = "Qty per Unit"
        Me.quantityHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'producedHeaderXrLabel
        '
        Me.producedHeaderXrLabel.CanGrow = False
        Me.producedHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.producedHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(722.0!, 0.0!)
        Me.producedHeaderXrLabel.Name = "producedHeaderXrLabel"
        Me.producedHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.producedHeaderXrLabel.SizeF = New System.Drawing.SizeF(81.0!, 50.0!)
        Me.producedHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.producedHeaderXrLabel.StylePriority.UseFont = False
        Me.producedHeaderXrLabel.Text = "Produced"
        Me.producedHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'itemTypeHeaderXrLabel
        '
        Me.itemTypeHeaderXrLabel.CanGrow = False
        Me.itemTypeHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.itemTypeHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(295.0!, 0.0!)
        Me.itemTypeHeaderXrLabel.Name = "itemTypeHeaderXrLabel"
        Me.itemTypeHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemTypeHeaderXrLabel.SizeF = New System.Drawing.SizeF(103.0!, 50.0!)
        Me.itemTypeHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.itemTypeHeaderXrLabel.StylePriority.UseFont = False
        Me.itemTypeHeaderXrLabel.Text = "Item Type"
        Me.itemTypeHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'uomHeaderXrLabel
        '
        Me.uomHeaderXrLabel.CanGrow = False
        Me.uomHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.uomHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(398.0!, 0.0!)
        Me.uomHeaderXrLabel.Name = "uomHeaderXrLabel"
        Me.uomHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.uomHeaderXrLabel.SizeF = New System.Drawing.SizeF(81.0!, 50.0!)
        Me.uomHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.uomHeaderXrLabel.StylePriority.UseFont = False
        Me.uomHeaderXrLabel.Text = "Unit of Measure"
        Me.uomHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'itemDescriptionHeaderXrLabel
        '
        Me.itemDescriptionHeaderXrLabel.CanGrow = False
        Me.itemDescriptionHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.itemDescriptionHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(190.0!, 0.0!)
        Me.itemDescriptionHeaderXrLabel.Name = "itemDescriptionHeaderXrLabel"
        Me.itemDescriptionHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemDescriptionHeaderXrLabel.SizeF = New System.Drawing.SizeF(105.0!, 50.0!)
        Me.itemDescriptionHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.itemDescriptionHeaderXrLabel.StylePriority.UseFont = False
        Me.itemDescriptionHeaderXrLabel.Text = "Item Description"
        Me.itemDescriptionHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'itemCodeHeaderXrLabel
        '
        Me.itemCodeHeaderXrLabel.CanGrow = False
        Me.itemCodeHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.itemCodeHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(100.0!, 0.0!)
        Me.itemCodeHeaderXrLabel.Name = "itemCodeHeaderXrLabel"
        Me.itemCodeHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemCodeHeaderXrLabel.SizeF = New System.Drawing.SizeF(90.0!, 50.0!)
        Me.itemCodeHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.itemCodeHeaderXrLabel.StylePriority.UseFont = False
        Me.itemCodeHeaderXrLabel.Text = "Item #"
        Me.itemCodeHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'casesPerPalletHeadeerXrLabel
        '
        Me.casesPerPalletHeadeerXrLabel.CanGrow = False
        Me.casesPerPalletHeadeerXrLabel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.casesPerPalletHeadeerXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(641.0!, 0.0!)
        Me.casesPerPalletHeadeerXrLabel.Name = "casesPerPalletHeadeerXrLabel"
        Me.casesPerPalletHeadeerXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.casesPerPalletHeadeerXrLabel.SizeF = New System.Drawing.SizeF(81.0!, 50.0!)
        Me.casesPerPalletHeadeerXrLabel.StyleName = "headerXrControlStyle"
        Me.casesPerPalletHeadeerXrLabel.StylePriority.UseFont = False
        Me.casesPerPalletHeadeerXrLabel.Text = "Cases per Pallet"
        Me.casesPerPalletHeadeerXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'customerNameHeaderXrLabel
        '
        Me.customerNameHeaderXrLabel.CanGrow = False
        Me.customerNameHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.customerNameHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.customerNameHeaderXrLabel.Name = "customerNameHeaderXrLabel"
        Me.customerNameHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.customerNameHeaderXrLabel.SizeF = New System.Drawing.SizeF(100.0!, 50.0!)
        Me.customerNameHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.customerNameHeaderXrLabel.StylePriority.UseFont = False
        Me.customerNameHeaderXrLabel.Text = "Customer"
        Me.customerNameHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pageNumberXrPageInfo})
        Me.PageFooter.HeightF = 30.0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'pageNumberXrPageInfo
        '
        Me.pageNumberXrPageInfo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic)
        Me.pageNumberXrPageInfo.Format = "Page:  {0} / {1}"
        Me.pageNumberXrPageInfo.LocationFloat = New DevExpress.Utils.PointFloat(950.0!, 0.0!)
        Me.pageNumberXrPageInfo.Name = "pageNumberXrPageInfo"
        Me.pageNumberXrPageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.pageNumberXrPageInfo.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
        Me.pageNumberXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.printDateXrPageInfo, Me.reportCriteriaXrLabel, Me.reportTitleXrLabel})
        Me.ReportHeader.HeightF = 86.0!
        Me.ReportHeader.KeepTogether = True
        Me.ReportHeader.Name = "ReportHeader"
        '
        'printDateXrPageInfo
        '
        Me.printDateXrPageInfo.LocationFloat = New DevExpress.Utils.PointFloat(867.0!, 50.0!)
        Me.printDateXrPageInfo.Name = "printDateXrPageInfo"
        Me.printDateXrPageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.printDateXrPageInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.printDateXrPageInfo.SizeF = New System.Drawing.SizeF(183.0!, 35.0!)
        Me.printDateXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'reportCriteriaXrLabel
        '
        Me.reportCriteriaXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 50.0!)
        Me.reportCriteriaXrLabel.Name = "reportCriteriaXrLabel"
        Me.reportCriteriaXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.reportCriteriaXrLabel.SizeF = New System.Drawing.SizeF(635.0!, 35.0!)
        Me.reportCriteriaXrLabel.Text = "reportCriteriaXrLabel"
        Me.reportCriteriaXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'reportTitleXrLabel
        '
        Me.reportTitleXrLabel.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.reportTitleXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.reportTitleXrLabel.Name = "reportTitleXrLabel"
        Me.reportTitleXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.reportTitleXrLabel.SizeF = New System.Drawing.SizeF(1050.0!, 50.0!)
        Me.reportTitleXrLabel.Text = "reportTitleXrLabel"
        Me.reportTitleXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.footerXrPanel})
        Me.ReportFooter.HeightF = 30.0!
        Me.ReportFooter.KeepTogether = True
        Me.ReportFooter.Name = "ReportFooter"
        '
        'footerXrPanel
        '
        Me.footerXrPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.footerXrPanel.BorderColor = System.Drawing.Color.Black
        Me.footerXrPanel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.footerXrPanel.BorderWidth = 3
        Me.footerXrPanel.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.usedInProductionFooterXrLabel, Me.receivedFooterXrLabel, Me.shippedFooterXrLabel, Me.producedFooterXrLabel, Me.adjustedFooterXrLabel})
        Me.footerXrPanel.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.footerXrPanel.Name = "footerXrPanel"
        Me.footerXrPanel.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.footerXrPanel.SizeF = New System.Drawing.SizeF(1050.0!, 30.0!)
        '
        'receivedFooterXrLabel
        '
        Me.receivedFooterXrLabel.CanGrow = False
        Me.receivedFooterXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.receivedFooterXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(884.0!, 0.0!)
        Me.receivedFooterXrLabel.Name = "receivedFooterXrLabel"
        Me.receivedFooterXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.receivedFooterXrLabel.SizeF = New System.Drawing.SizeF(81.0!, 30.0!)
        Me.receivedFooterXrLabel.StyleName = "footerXrControlStyle"
        Me.receivedFooterXrLabel.StylePriority.UseFont = False
        Me.receivedFooterXrLabel.StylePriority.UseTextAlignment = False
        XrSummary2.FormatString = "{0:#,#}"
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.receivedFooterXrLabel.Summary = XrSummary2
        Me.receivedFooterXrLabel.Text = "receivedFooterXrLabel"
        Me.receivedFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'shippedFooterXrLabel
        '
        Me.shippedFooterXrLabel.CanGrow = False
        Me.shippedFooterXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.shippedFooterXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(803.0!, 0.0!)
        Me.shippedFooterXrLabel.Name = "shippedFooterXrLabel"
        Me.shippedFooterXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.shippedFooterXrLabel.SizeF = New System.Drawing.SizeF(81.0!, 30.0!)
        Me.shippedFooterXrLabel.StyleName = "footerXrControlStyle"
        Me.shippedFooterXrLabel.StylePriority.UseFont = False
        Me.shippedFooterXrLabel.StylePriority.UseTextAlignment = False
        XrSummary3.FormatString = "{0:#,#}"
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.shippedFooterXrLabel.Summary = XrSummary3
        Me.shippedFooterXrLabel.Text = "shippedFooterXrLabel"
        Me.shippedFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'producedFooterXrLabel
        '
        Me.producedFooterXrLabel.CanGrow = False
        Me.producedFooterXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.producedFooterXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(722.0!, 0.0!)
        Me.producedFooterXrLabel.Name = "producedFooterXrLabel"
        Me.producedFooterXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.producedFooterXrLabel.SizeF = New System.Drawing.SizeF(81.0!, 30.0!)
        Me.producedFooterXrLabel.StyleName = "footerXrControlStyle"
        Me.producedFooterXrLabel.StylePriority.UseFont = False
        Me.producedFooterXrLabel.StylePriority.UseTextAlignment = False
        XrSummary4.FormatString = "{0:#,#}"
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.producedFooterXrLabel.Summary = XrSummary4
        Me.producedFooterXrLabel.Text = "producedFooterXrLabel"
        Me.producedFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'adjustedFooterXrLabel
        '
        Me.adjustedFooterXrLabel.CanGrow = False
        Me.adjustedFooterXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.adjustedFooterXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(965.0!, 0.0!)
        Me.adjustedFooterXrLabel.Name = "adjustedFooterXrLabel"
        Me.adjustedFooterXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.adjustedFooterXrLabel.SizeF = New System.Drawing.SizeF(81.0!, 30.0!)
        Me.adjustedFooterXrLabel.StyleName = "footerXrControlStyle"
        Me.adjustedFooterXrLabel.StylePriority.UseFont = False
        Me.adjustedFooterXrLabel.StylePriority.UseTextAlignment = False
        XrSummary5.FormatString = "{0:#,#}"
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.adjustedFooterXrLabel.Summary = XrSummary5
        Me.adjustedFooterXrLabel.Text = "adjustedFooterXrLabel"
        Me.adjustedFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'headerXrControlStyle
        '
        Me.headerXrControlStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.headerXrControlStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.headerXrControlStyle.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.headerXrControlStyle.BorderWidth = 1
        Me.headerXrControlStyle.Font = New System.Drawing.Font("Tahoma", 6.5!, System.Drawing.FontStyle.Bold)
        Me.headerXrControlStyle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.headerXrControlStyle.Name = "headerXrControlStyle"
        '
        'footerXrControlStyle
        '
        Me.footerXrControlStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.footerXrControlStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.footerXrControlStyle.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.footerXrControlStyle.BorderWidth = 1
        Me.footerXrControlStyle.Font = New System.Drawing.Font("Tahoma", 6.5!)
        Me.footerXrControlStyle.ForeColor = System.Drawing.Color.Black
        Me.footerXrControlStyle.Name = "footerXrControlStyle"
        '
        'detailOddXrControlStyle
        '
        Me.detailOddXrControlStyle.BackColor = System.Drawing.Color.LightGray
        Me.detailOddXrControlStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.detailOddXrControlStyle.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.detailOddXrControlStyle.BorderWidth = 1
        Me.detailOddXrControlStyle.Font = New System.Drawing.Font("Tahoma", 6.5!)
        Me.detailOddXrControlStyle.ForeColor = System.Drawing.Color.Black
        Me.detailOddXrControlStyle.Name = "detailOddXrControlStyle"
        '
        'detailEvenXrControlStyle
        '
        Me.detailEvenXrControlStyle.BackColor = System.Drawing.Color.Transparent
        Me.detailEvenXrControlStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(196, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.detailEvenXrControlStyle.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.detailEvenXrControlStyle.BorderWidth = 1
        Me.detailEvenXrControlStyle.Font = New System.Drawing.Font("Tahoma", 6.5!)
        Me.detailEvenXrControlStyle.ForeColor = System.Drawing.Color.Black
        Me.detailEvenXrControlStyle.Name = "detailEvenXrControlStyle"
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
        'usedInProductionHeaderXrLabel
        '
        Me.usedInProductionHeaderXrLabel.CanGrow = False
        Me.usedInProductionHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.usedInProductionHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(487.5!, 0.0!)
        Me.usedInProductionHeaderXrLabel.Name = "usedInProductionHeaderXrLabel"
        Me.usedInProductionHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.usedInProductionHeaderXrLabel.SizeF = New System.Drawing.SizeF(81.0!, 50.0!)
        Me.usedInProductionHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.usedInProductionHeaderXrLabel.StylePriority.UseFont = False
        Me.usedInProductionHeaderXrLabel.Text = "Used In Production"
        Me.usedInProductionHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'usedInProductionDetailXrLabel
        '
        Me.usedInProductionDetailXrLabel.CanGrow = False
        Me.usedInProductionDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.usedInProductionDetailXrLabel.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.usedInProductionDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(487.5!, 0.0!)
        Me.usedInProductionDetailXrLabel.Name = "usedInProductionDetailXrLabel"
        Me.usedInProductionDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.usedInProductionDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.usedInProductionDetailXrLabel.SizeF = New System.Drawing.SizeF(81.0!, 30.0!)
        Me.usedInProductionDetailXrLabel.StylePriority.UseFont = False
        Me.usedInProductionDetailXrLabel.StylePriority.UseTextAlignment = False
        Me.usedInProductionDetailXrLabel.Text = "adjustedDetailXrLabel"
        Me.usedInProductionDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'usedInProductionFooterXrLabel
        '
        Me.usedInProductionFooterXrLabel.CanGrow = False
        Me.usedInProductionFooterXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.usedInProductionFooterXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(487.5!, 0.0!)
        Me.usedInProductionFooterXrLabel.Name = "usedInProductionFooterXrLabel"
        Me.usedInProductionFooterXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.usedInProductionFooterXrLabel.SizeF = New System.Drawing.SizeF(81.0!, 30.0!)
        Me.usedInProductionFooterXrLabel.StyleName = "footerXrControlStyle"
        Me.usedInProductionFooterXrLabel.StylePriority.UseFont = False
        Me.usedInProductionFooterXrLabel.StylePriority.UseTextAlignment = False
        XrSummary1.FormatString = "{0:#,#}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.usedInProductionFooterXrLabel.Summary = XrSummary1
        Me.usedInProductionFooterXrLabel.Text = "adjustedFooterXrLabel"
        Me.usedInProductionFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'ItemsXtraReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.ReportHeader, Me.ReportFooter, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 50, 50)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.headerXrControlStyle, Me.footerXrControlStyle, Me.detailOddXrControlStyle, Me.detailEvenXrControlStyle})
        Me.Version = "10.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents printDateXrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents reportCriteriaXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents reportTitleXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents headerXrControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents footerXrControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents detailOddXrControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents detailEvenXrControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents headerXrPanel As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents AdjustedHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents receivedHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents shippedHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents unitsPerCaseHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents quantityHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents producedHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemTypeHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uomHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemDescriptionHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemCodeHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents casesPerPalletHeadeerXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents customerNameHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents shippedDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents receivedDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents adjustedDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents unitsPerCaseDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents quantityDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents producedDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemTypeDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents uomDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemDescriptionDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemCodeDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents casesPerPalletDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents customerNameDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents footerXrPanel As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents adjustedFooterXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pageNumberXrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents receivedFooterXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents shippedFooterXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents producedFooterXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents usedInProductionDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents usedInProductionHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents usedInProductionFooterXrLabel As DevExpress.XtraReports.UI.XRLabel
End Class
