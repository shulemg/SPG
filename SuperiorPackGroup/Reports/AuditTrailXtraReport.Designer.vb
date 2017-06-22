<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class AuditTrailXtraReport
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
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.reportTitleXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.reportCriteriaXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.printDateXrPageInfo = New DevExpress.XtraReports.UI.XRPageInfo
        Me.headerXrControlStyle = New DevExpress.XtraReports.UI.XRControlStyle
        Me.footerXrControlStyle = New DevExpress.XtraReports.UI.XRControlStyle
        Me.detailOddXrControlStyle = New DevExpress.XtraReports.UI.XRControlStyle
        Me.detailEvenXrControlStyle = New DevExpress.XtraReports.UI.XRControlStyle
        Me.headerXrPanel = New DevExpress.XtraReports.UI.XRPanel
        Me.itemDescriptionHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.recordTypeHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.userNameHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.dateHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.dateDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.recordTypeDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.recordChangesDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.userNameDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.pageNumberXrPageInfo = New DevExpress.XtraReports.UI.XRPageInfo
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.userNameDetailXrLabel, Me.recordChangesDetailXrLabel, Me.recordTypeDetailXrLabel, Me.dateDetailXrLabel})
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.headerXrPanel})
        Me.PageHeader.Height = 50
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pageNumberXrPageInfo})
        Me.PageFooter.Height = 30
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.printDateXrPageInfo, Me.reportCriteriaXrLabel, Me.reportTitleXrLabel})
        Me.ReportHeader.Height = 86
        Me.ReportHeader.Name = "ReportHeader"
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
        'reportCriteriaXrLabel
        '
        Me.reportCriteriaXrLabel.Location = New System.Drawing.Point(0, 50)
        Me.reportCriteriaXrLabel.Name = "reportCriteriaXrLabel"
        Me.reportCriteriaXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.reportCriteriaXrLabel.Size = New System.Drawing.Size(625, 35)
        Me.reportCriteriaXrLabel.Text = "reportCriteriaXrLabel"
        Me.reportCriteriaXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
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
        'headerXrPanel
        '
        Me.headerXrPanel.BorderColor = System.Drawing.Color.Black
        Me.headerXrPanel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.headerXrPanel.BorderWidth = 3
        Me.headerXrPanel.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.itemDescriptionHeaderXrLabel, Me.recordTypeHeaderXrLabel, Me.userNameHeaderXrLabel, Me.dateHeaderXrLabel})
        Me.headerXrPanel.Location = New System.Drawing.Point(0, 0)
        Me.headerXrPanel.Name = "headerXrPanel"
        Me.headerXrPanel.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.headerXrPanel.Size = New System.Drawing.Size(800, 50)
        '
        'itemDescriptionHeaderXrLabel
        '
        Me.itemDescriptionHeaderXrLabel.CanGrow = False
        Me.itemDescriptionHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.itemDescriptionHeaderXrLabel.Location = New System.Drawing.Point(413, 0)
        Me.itemDescriptionHeaderXrLabel.Name = "itemDescriptionHeaderXrLabel"
        Me.itemDescriptionHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemDescriptionHeaderXrLabel.Size = New System.Drawing.Size(386, 50)
        Me.itemDescriptionHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.itemDescriptionHeaderXrLabel.StylePriority.UseFont = False
        Me.itemDescriptionHeaderXrLabel.Text = "Record Changes"
        Me.itemDescriptionHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'recordTypeHeaderXrLabel
        '
        Me.recordTypeHeaderXrLabel.CanGrow = False
        Me.recordTypeHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.recordTypeHeaderXrLabel.Location = New System.Drawing.Point(268, 0)
        Me.recordTypeHeaderXrLabel.Name = "recordTypeHeaderXrLabel"
        Me.recordTypeHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.recordTypeHeaderXrLabel.Size = New System.Drawing.Size(145, 50)
        Me.recordTypeHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.recordTypeHeaderXrLabel.StylePriority.UseFont = False
        Me.recordTypeHeaderXrLabel.Text = "Record Type"
        Me.recordTypeHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'userNameHeaderXrLabel
        '
        Me.userNameHeaderXrLabel.CanGrow = False
        Me.userNameHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.userNameHeaderXrLabel.Location = New System.Drawing.Point(118, 0)
        Me.userNameHeaderXrLabel.Name = "userNameHeaderXrLabel"
        Me.userNameHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.userNameHeaderXrLabel.Size = New System.Drawing.Size(150, 50)
        Me.userNameHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.userNameHeaderXrLabel.StylePriority.UseFont = False
        Me.userNameHeaderXrLabel.Text = "User Name"
        Me.userNameHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'dateHeaderXrLabel
        '
        Me.dateHeaderXrLabel.CanGrow = False
        Me.dateHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.dateHeaderXrLabel.Location = New System.Drawing.Point(0, 0)
        Me.dateHeaderXrLabel.Name = "dateHeaderXrLabel"
        Me.dateHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.dateHeaderXrLabel.Size = New System.Drawing.Size(118, 50)
        Me.dateHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.dateHeaderXrLabel.StylePriority.UseFont = False
        Me.dateHeaderXrLabel.Text = "Date"
        Me.dateHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'dateDetailXrLabel
        '
        Me.dateDetailXrLabel.CanGrow = False
        Me.dateDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.dateDetailXrLabel.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.dateDetailXrLabel.Location = New System.Drawing.Point(0, 0)
        Me.dateDetailXrLabel.Name = "dateDetailXrLabel"
        Me.dateDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.dateDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.dateDetailXrLabel.Size = New System.Drawing.Size(118, 100)
        Me.dateDetailXrLabel.StylePriority.UseFont = False
        Me.dateDetailXrLabel.StylePriority.UseTextAlignment = False
        Me.dateDetailXrLabel.Text = "dateDetailXrLabel"
        Me.dateDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'recordTypeDetailXrLabel
        '
        Me.recordTypeDetailXrLabel.CanGrow = False
        Me.recordTypeDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.recordTypeDetailXrLabel.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.recordTypeDetailXrLabel.Location = New System.Drawing.Point(268, 0)
        Me.recordTypeDetailXrLabel.Name = "recordTypeDetailXrLabel"
        Me.recordTypeDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.recordTypeDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.recordTypeDetailXrLabel.Size = New System.Drawing.Size(145, 100)
        Me.recordTypeDetailXrLabel.StylePriority.UseFont = False
        Me.recordTypeDetailXrLabel.StylePriority.UseTextAlignment = False
        Me.recordTypeDetailXrLabel.Text = "recordTypeDetailXrLabel"
        Me.recordTypeDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'recordChangesDetailXrLabel
        '
        Me.recordChangesDetailXrLabel.CanGrow = False
        Me.recordChangesDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.recordChangesDetailXrLabel.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.recordChangesDetailXrLabel.Location = New System.Drawing.Point(413, 0)
        Me.recordChangesDetailXrLabel.Name = "recordChangesDetailXrLabel"
        Me.recordChangesDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.recordChangesDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.recordChangesDetailXrLabel.Size = New System.Drawing.Size(386, 100)
        Me.recordChangesDetailXrLabel.StylePriority.UseFont = False
        Me.recordChangesDetailXrLabel.StylePriority.UseTextAlignment = False
        Me.recordChangesDetailXrLabel.Text = "recordChangesDetailXrLabel"
        Me.recordChangesDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'userNameDetailXrLabel
        '
        Me.userNameDetailXrLabel.CanGrow = False
        Me.userNameDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.userNameDetailXrLabel.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.userNameDetailXrLabel.Location = New System.Drawing.Point(118, 0)
        Me.userNameDetailXrLabel.Name = "userNameDetailXrLabel"
        Me.userNameDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.userNameDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.userNameDetailXrLabel.Size = New System.Drawing.Size(150, 100)
        Me.userNameDetailXrLabel.StylePriority.UseFont = False
        Me.userNameDetailXrLabel.StylePriority.UseTextAlignment = False
        Me.userNameDetailXrLabel.Text = "userNameDetailXrLabel"
        Me.userNameDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        'AuditTrailXtraReport
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
    Friend WithEvents printDateXrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents reportCriteriaXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents reportTitleXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents headerXrControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents footerXrControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents detailOddXrControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents detailEvenXrControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents headerXrPanel As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents itemDescriptionHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents recordTypeHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents userNameHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents dateHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents userNameDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents recordChangesDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents recordTypeDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents dateDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pageNumberXrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
End Class
