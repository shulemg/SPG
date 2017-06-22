<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class CostingSummaryXtraReport
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
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.reportTitleXRLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.reportCriteriaXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.printDateXRPageInfo = New DevExpress.XtraReports.UI.XRPageInfo
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.printDateXRPageInfo, Me.reportCriteriaXrLabel, Me.reportTitleXRLabel})
        Me.PageHeader.Height = 86
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageFooter
        '
        Me.PageFooter.Height = 30
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'reportTitleXRLabel
        '
        Me.reportTitleXRLabel.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.reportTitleXRLabel.Location = New System.Drawing.Point(0, 0)
        Me.reportTitleXRLabel.Name = "reportTitleXRLabel"
        Me.reportTitleXRLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.reportTitleXRLabel.Size = New System.Drawing.Size(800, 50)
        Me.reportTitleXRLabel.Text = "Production Costing Report"
        Me.reportTitleXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'reportCriteriaXrLabel
        '
        Me.reportCriteriaXrLabel.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.reportCriteriaXrLabel.Location = New System.Drawing.Point(0, 50)
        Me.reportCriteriaXrLabel.Multiline = True
        Me.reportCriteriaXrLabel.Name = "reportCriteriaXrLabel"
        Me.reportCriteriaXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.reportCriteriaXrLabel.Size = New System.Drawing.Size(500, 35)
        Me.reportCriteriaXrLabel.StylePriority.UseTextAlignment = False
        Me.reportCriteriaXrLabel.Text = "reportCriteriaXrLabel"
        Me.reportCriteriaXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'printDateXRPageInfo
        '
        Me.printDateXRPageInfo.Location = New System.Drawing.Point(617, 50)
        Me.printDateXRPageInfo.Name = "printDateXRPageInfo"
        Me.printDateXRPageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.printDateXRPageInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.printDateXRPageInfo.Size = New System.Drawing.Size(183, 35)
        Me.printDateXRPageInfo.StylePriority.UseTextAlignment = False
        Me.printDateXRPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'ReportFooter
        '
        Me.ReportFooter.Height = 425
        Me.ReportFooter.Name = "ReportFooter"
        '
        'CostingSummaryXtraReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.ReportFooter})
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 50, 50)
        Me.Version = "8.3"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents reportCriteriaXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents reportTitleXRLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents printDateXRPageInfo As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
End Class
