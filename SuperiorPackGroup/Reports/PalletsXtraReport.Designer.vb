<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class PalletsXtraReport
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
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.customerNameDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.byPalletDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.headerXrPanel = New DevExpress.XtraReports.UI.XRPanel
        Me.byPalletHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.customerNameHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.pageNumberXrPageInfo = New DevExpress.XtraReports.UI.XRPageInfo
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.printDateXrPageInfo = New DevExpress.XtraReports.UI.XRPageInfo
        Me.reportTitleXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.headerXrControlStyle = New DevExpress.XtraReports.UI.XRControlStyle
        Me.footerXrControlStyle = New DevExpress.XtraReports.UI.XRControlStyle
        Me.detailOddXrControlStyle = New DevExpress.XtraReports.UI.XRControlStyle
        Me.detailEvenXrControlStyle = New DevExpress.XtraReports.UI.XRControlStyle
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.customerNameDetailXrLabel, Me.byPalletDetailXrLabel})
        Me.Detail.Height = 30
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'customerNameDetailXrLabel
        '
        Me.customerNameDetailXrLabel.CanGrow = False
        Me.customerNameDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.customerNameDetailXrLabel.Location = New System.Drawing.Point(250, 0)
        Me.customerNameDetailXrLabel.Name = "customerNameDetailXrLabel"
        Me.customerNameDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.customerNameDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.customerNameDetailXrLabel.Size = New System.Drawing.Size(160, 30)
        Me.customerNameDetailXrLabel.StylePriority.UseFont = False
        Me.customerNameDetailXrLabel.Text = "customerNameDetailXrLabel"
        Me.customerNameDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'byPalletDetailXrLabel
        '
        Me.byPalletDetailXrLabel.CanGrow = False
        Me.byPalletDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.byPalletDetailXrLabel.Location = New System.Drawing.Point(410, 0)
        Me.byPalletDetailXrLabel.Name = "byPalletDetailXrLabel"
        Me.byPalletDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.byPalletDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.byPalletDetailXrLabel.Size = New System.Drawing.Size(140, 30)
        Me.byPalletDetailXrLabel.StylePriority.UseTextAlignment = False
        Me.byPalletDetailXrLabel.Text = "byPalletDetailXrLabel"
        Me.byPalletDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.headerXrPanel})
        Me.PageHeader.Height = 50
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
        Me.headerXrPanel.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.byPalletHeaderXrLabel, Me.customerNameHeaderXrLabel})
        Me.headerXrPanel.Location = New System.Drawing.Point(250, 0)
        Me.headerXrPanel.Name = "headerXrPanel"
        Me.headerXrPanel.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.headerXrPanel.Size = New System.Drawing.Size(300, 50)
        '
        'byPalletHeaderXrLabel
        '
        Me.byPalletHeaderXrLabel.CanGrow = False
        Me.byPalletHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.byPalletHeaderXrLabel.Location = New System.Drawing.Point(160, 0)
        Me.byPalletHeaderXrLabel.Name = "byPalletHeaderXrLabel"
        Me.byPalletHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.byPalletHeaderXrLabel.Size = New System.Drawing.Size(140, 50)
        Me.byPalletHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.byPalletHeaderXrLabel.StylePriority.UseFont = False
        Me.byPalletHeaderXrLabel.Text = "Pallet Qty"
        Me.byPalletHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'customerNameHeaderXrLabel
        '
        Me.customerNameHeaderXrLabel.CanGrow = False
        Me.customerNameHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.customerNameHeaderXrLabel.Location = New System.Drawing.Point(0, 0)
        Me.customerNameHeaderXrLabel.Name = "customerNameHeaderXrLabel"
        Me.customerNameHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.customerNameHeaderXrLabel.Size = New System.Drawing.Size(160, 50)
        Me.customerNameHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.customerNameHeaderXrLabel.StylePriority.UseFont = False
        Me.customerNameHeaderXrLabel.Text = "Customer"
        Me.customerNameHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pageNumberXrPageInfo})
        Me.PageFooter.Height = 30
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'pageNumberXrPageInfo
        '
        Me.pageNumberXrPageInfo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic)
        Me.pageNumberXrPageInfo.Format = "Page:  {0} / {1}"
        Me.pageNumberXrPageInfo.Location = New System.Drawing.Point(700, 0)
        Me.pageNumberXrPageInfo.Name = "pageNumberXrPageInfo"
        Me.pageNumberXrPageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.pageNumberXrPageInfo.Size = New System.Drawing.Size(100, 25)
        Me.pageNumberXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.printDateXrPageInfo, Me.reportTitleXrLabel})
        Me.ReportHeader.Height = 86
        Me.ReportHeader.KeepTogether = True
        Me.ReportHeader.Name = "ReportHeader"
        '
        'printDateXrPageInfo
        '
        Me.printDateXrPageInfo.Location = New System.Drawing.Point(650, 50)
        Me.printDateXrPageInfo.Name = "printDateXrPageInfo"
        Me.printDateXrPageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.printDateXrPageInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.printDateXrPageInfo.Size = New System.Drawing.Size(150, 35)
        Me.printDateXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'reportTitleXrLabel
        '
        Me.reportTitleXrLabel.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.reportTitleXrLabel.Location = New System.Drawing.Point(0, 0)
        Me.reportTitleXrLabel.Name = "reportTitleXrLabel"
        Me.reportTitleXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.reportTitleXrLabel.Size = New System.Drawing.Size(800, 50)
        Me.reportTitleXrLabel.Text = "reportTitleXrLabel"
        Me.reportTitleXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
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
        'PalletsXtraReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.ReportHeader})
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 50, 50)
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.headerXrControlStyle, Me.footerXrControlStyle, Me.detailOddXrControlStyle, Me.detailEvenXrControlStyle})
        Me.Version = "8.3"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents headerXrControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents footerXrControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents detailOddXrControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents detailEvenXrControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents printDateXrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents reportTitleXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents headerXrPanel As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents byPalletHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents customerNameHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents customerNameDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents byPalletDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pageNumberXrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
End Class
