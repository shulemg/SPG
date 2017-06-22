<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class PalletTicketXtraReport
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
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.palletXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.shiftXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.dateXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.casesPerPalletXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lotCodeXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.itemTypeXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.itemDescriptionXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me.itemXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.customerXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me,System.ComponentModel.ISupportInitialize).BeginInit
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.palletXrLabel, Me.shiftXrLabel, Me.dateXrLabel, Me.XrLabel8, Me.XrLabel7, Me.XrLabel6, Me.casesPerPalletXrLabel, Me.XrLabel5, Me.lotCodeXrLabel, Me.XrLabel3, Me.itemTypeXrLabel, Me.itemDescriptionXrLabel, Me.XrPanel1, Me.customerXrLabel})
        Me.Detail.Font = New System.Drawing.Font("Times New Roman", 12!)
        Me.Detail.HeightF = 800.7916!
        Me.Detail.KeepTogether = true
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.Detail.StylePriority.UseFont = false
        Me.Detail.StylePriority.UseTextAlignment = false
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'palletXrLabel
        '
        Me.palletXrLabel.Font = New System.Drawing.Font("Times New Roman", 24!)
        Me.palletXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(433!, 707!)
        Me.palletXrLabel.Name = "palletXrLabel"
        Me.palletXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.palletXrLabel.SizeF = New System.Drawing.SizeF(217!, 93!)
        Me.palletXrLabel.StylePriority.UseFont = false
        Me.palletXrLabel.Visible = false
        '
        'shiftXrLabel
        '
        Me.shiftXrLabel.Font = New System.Drawing.Font("Times New Roman", 24!)
        Me.shiftXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(217!, 707!)
        Me.shiftXrLabel.Name = "shiftXrLabel"
        Me.shiftXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.shiftXrLabel.SizeF = New System.Drawing.SizeF(217!, 93!)
        Me.shiftXrLabel.StylePriority.UseFont = false
        Me.shiftXrLabel.Visible = false
        '
        'dateXrLabel
        '
        Me.dateXrLabel.CanGrow = false
        Me.dateXrLabel.Font = New System.Drawing.Font("Times New Roman", 24!)
        Me.dateXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0!, 707!)
        Me.dateXrLabel.Multiline = true
        Me.dateXrLabel.Name = "dateXrLabel"
        Me.dateXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.dateXrLabel.SizeF = New System.Drawing.SizeF(217!, 93!)
        Me.dateXrLabel.StylePriority.UseFont = false
        Me.dateXrLabel.Visible = false
        '
        'XrLabel8
        '
        Me.XrLabel8.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel8.Font = New System.Drawing.Font("Times New Roman", 20!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(433!, 675!)
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(217!, 125!)
        Me.XrLabel8.StylePriority.UseBorders = false
        Me.XrLabel8.StylePriority.UseFont = false
        Me.XrLabel8.StylePriority.UseTextAlignment = false
        Me.XrLabel8.Text = "PALLET:"
        Me.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel7
        '
        Me.XrLabel7.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel7.Font = New System.Drawing.Font("Times New Roman", 20!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(217!, 675!)
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(217!, 125!)
        Me.XrLabel7.StylePriority.UseBorders = false
        Me.XrLabel7.StylePriority.UseFont = false
        Me.XrLabel7.StylePriority.UseTextAlignment = false
        Me.XrLabel7.Text = "SHIFT:"
        Me.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'XrLabel6
        '
        Me.XrLabel6.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel6.Font = New System.Drawing.Font("Times New Roman", 20!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0!, 675!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(217!, 125!)
        Me.XrLabel6.StylePriority.UseBorders = false
        Me.XrLabel6.StylePriority.UseFont = false
        Me.XrLabel6.StylePriority.UseTextAlignment = false
        Me.XrLabel6.Text = "DATE:"
        Me.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'casesPerPalletXrLabel
        '
        Me.casesPerPalletXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.casesPerPalletXrLabel.Font = New System.Drawing.Font("Times New Roman", 24!, System.Drawing.FontStyle.Bold)
        Me.casesPerPalletXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(433!, 550!)
        Me.casesPerPalletXrLabel.Name = "casesPerPalletXrLabel"
        Me.casesPerPalletXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.casesPerPalletXrLabel.SizeF = New System.Drawing.SizeF(217!, 125!)
        Me.casesPerPalletXrLabel.StylePriority.UseBorders = false
        Me.casesPerPalletXrLabel.StylePriority.UseFont = false
        Me.casesPerPalletXrLabel.Text = "casesPerPalletXrLabel"
        '
        'XrLabel5
        '
        Me.XrLabel5.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel5.Font = New System.Drawing.Font("Times New Roman", 28!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(0!, 550!)
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(433!, 125!)
        Me.XrLabel5.StylePriority.UseBorders = false
        Me.XrLabel5.StylePriority.UseFont = false
        Me.XrLabel5.Text = "CASES PER PALLET:"
        '
        'lotCodeXrLabel
        '
        Me.lotCodeXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.lotCodeXrLabel.Font = New System.Drawing.Font("Times New Roman", 24!)
        Me.lotCodeXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(250!, 425!)
        Me.lotCodeXrLabel.Name = "lotCodeXrLabel"
        Me.lotCodeXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.lotCodeXrLabel.SizeF = New System.Drawing.SizeF(400!, 125!)
        Me.lotCodeXrLabel.StylePriority.UseBorders = false
        Me.lotCodeXrLabel.StylePriority.UseFont = false
        '
        'XrLabel3
        '
        Me.XrLabel3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 28!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 425!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(250!, 125!)
        Me.XrLabel3.StylePriority.UseBorders = false
        Me.XrLabel3.StylePriority.UseFont = false
        Me.XrLabel3.Text = "CODE:"
        '
        'itemTypeXrLabel
        '
        Me.itemTypeXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.itemTypeXrLabel.Font = New System.Drawing.Font("Times New Roman", 24!, System.Drawing.FontStyle.Bold)
        Me.itemTypeXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0!, 350!)
        Me.itemTypeXrLabel.Name = "itemTypeXrLabel"
        Me.itemTypeXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.itemTypeXrLabel.SizeF = New System.Drawing.SizeF(650!, 75!)
        Me.itemTypeXrLabel.StylePriority.UseBorders = false
        Me.itemTypeXrLabel.StylePriority.UseFont = false
        Me.itemTypeXrLabel.Text = "itemTypeXrLabel"
        '
        'itemDescriptionXrLabel
        '
        Me.itemDescriptionXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.itemDescriptionXrLabel.Font = New System.Drawing.Font("Times New Roman", 20!)
        Me.itemDescriptionXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0!, 225!)
        Me.itemDescriptionXrLabel.Name = "itemDescriptionXrLabel"
        Me.itemDescriptionXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.itemDescriptionXrLabel.SizeF = New System.Drawing.SizeF(650!, 125!)
        Me.itemDescriptionXrLabel.StylePriority.UseBorders = false
        Me.itemDescriptionXrLabel.StylePriority.UseFont = false
        Me.itemDescriptionXrLabel.Text = "itemDescriptionXrLabel"
        '
        'XrPanel1
        '
        Me.XrPanel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top)  _
            Or DevExpress.XtraPrinting.BorderSide.Right)  _
            Or DevExpress.XtraPrinting.BorderSide.Bottom),DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.itemXrLabel, Me.XrLabel2})
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 100!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(650!, 125!)
        Me.XrPanel1.StylePriority.UseBorders = false
        '
        'itemXrLabel
        '
        Me.itemXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.itemXrLabel.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 50.0!)
        Me.itemXrLabel.Name = "itemXrLabel"
        Me.itemXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemXrLabel.SizeF = New System.Drawing.SizeF(650.0!, 75.0!)
        Me.itemXrLabel.StylePriority.UseBorders = False
        Me.itemXrLabel.StylePriority.UseFont = False
        Me.itemXrLabel.Text = "itemXrLabel"
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(650.0!, 50.0!)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.Text = "Product #"
        '
        'customerXrLabel
        '
        Me.customerXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.customerXrLabel.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customerXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.customerXrLabel.Name = "customerXrLabel"
        Me.customerXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.customerXrLabel.SizeF = New System.Drawing.SizeF(650!, 100!)
        Me.customerXrLabel.StylePriority.UseBorders = false
        Me.customerXrLabel.StylePriority.UseFont = false
        Me.customerXrLabel.Text = "customerXrLabel"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1})
        Me.PageHeader.HeightF = 50!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 24!)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(650!, 50!)
        Me.XrLabel1.StylePriority.UseFont = false
        Me.XrLabel1.StylePriority.UseTextAlignment = false
        Me.XrLabel1.Text = "Pallet Ticket"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageFooter
        '
        Me.PageFooter.HeightF = 30!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100!)
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMarginBand1
        '
        Me.TopMarginBand1.Name = "TopMarginBand1"
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        '
        'PalletTicketXtraReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.Margins = New System.Drawing.Printing.Margins(90, 100, 100, 100)
        Me.Version = "11.2"
        CType(Me,System.ComponentModel.ISupportInitialize).EndInit

End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents customerXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemTypeXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemDescriptionXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents casesPerPalletXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lotCodeXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents palletXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents shiftXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents dateXrLabel As DevExpress.XtraReports.UI.XRLabel
End Class
