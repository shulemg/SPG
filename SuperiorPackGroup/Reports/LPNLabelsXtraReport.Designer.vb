<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class LPNLabelsXtraReport
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim Code128Generator1 As DevExpress.XtraPrinting.BarCode.Code128Generator = New DevExpress.XtraPrinting.BarCode.Code128Generator()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.tsXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.exprHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.exprXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.lotHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.lotXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.qtyHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.qtyXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.itemDescXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.itemCodeXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.itemHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.lpnHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.LPNXrBarCode = New DevExpress.XtraReports.UI.XRBarCode()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.ReprintXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.tsXrLabel, Me.exprHeaderXrLabel, Me.exprXrLabel, Me.lotHeaderXrLabel, Me.lotXrLabel, Me.qtyHeaderXrLabel, Me.qtyXrLabel, Me.itemDescXrLabel, Me.itemCodeXrLabel, Me.itemHeaderXrLabel, Me.lpnHeaderXrLabel, Me.LPNXrBarCode, Me.XrLine3, Me.XrLine2, Me.XrLine1, Me.ReprintXrLabel})
        Me.Detail.HeightF = 400.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'tsXrLabel
        '
        Me.tsXrLabel.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Now()")})
        Me.tsXrLabel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tsXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(453.125!, 299.9583!)
        Me.tsXrLabel.Name = "tsXrLabel"
        Me.tsXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.tsXrLabel.SizeF = New System.Drawing.SizeF(300.0!, 23.74994!)
        Me.tsXrLabel.StylePriority.UseFont = False
        Me.tsXrLabel.StylePriority.UseTextAlignment = False
        Me.tsXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'exprHeaderXrLabel
        '
        Me.exprHeaderXrLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.exprHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(550.0001!, 202.4999!)
        Me.exprHeaderXrLabel.Name = "exprHeaderXrLabel"
        Me.exprHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.exprHeaderXrLabel.SizeF = New System.Drawing.SizeF(202.0832!, 13.0!)
        Me.exprHeaderXrLabel.StylePriority.UseFont = False
        Me.exprHeaderXrLabel.Text = "EXPIRATION DATE"
        '
        'exprXrLabel
        '
        Me.exprXrLabel.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Bold)
        Me.exprXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(550.0001!, 215.4999!)
        Me.exprXrLabel.Name = "exprXrLabel"
        Me.exprXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.exprXrLabel.SizeF = New System.Drawing.SizeF(202.0832!, 84.45839!)
        Me.exprXrLabel.StylePriority.UseFont = False
        Me.exprXrLabel.Text = "12/31/2022"
        '
        'lotHeaderXrLabel
        '
        Me.lotHeaderXrLabel.BorderColor = System.Drawing.Color.DimGray
        Me.lotHeaderXrLabel.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.lotHeaderXrLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lotHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(201.0417!, 202.4999!)
        Me.lotHeaderXrLabel.Name = "lotHeaderXrLabel"
        Me.lotHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lotHeaderXrLabel.SizeF = New System.Drawing.SizeF(348.9583!, 13.0!)
        Me.lotHeaderXrLabel.StylePriority.UseBorderColor = False
        Me.lotHeaderXrLabel.StylePriority.UseBorders = False
        Me.lotHeaderXrLabel.StylePriority.UseFont = False
        Me.lotHeaderXrLabel.Text = "LOT CODE"
        '
        'lotXrLabel
        '
        Me.lotXrLabel.BorderColor = System.Drawing.Color.DimGray
        Me.lotXrLabel.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.lotXrLabel.Font = New System.Drawing.Font("Tahoma", 22.0!, System.Drawing.FontStyle.Bold)
        Me.lotXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(201.0417!, 215.4999!)
        Me.lotXrLabel.Name = "lotXrLabel"
        Me.lotXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lotXrLabel.SizeF = New System.Drawing.SizeF(348.9583!, 84.45839!)
        Me.lotXrLabel.StylePriority.UseBorderColor = False
        Me.lotXrLabel.StylePriority.UseBorders = False
        Me.lotXrLabel.StylePriority.UseFont = False
        Me.lotXrLabel.Text = "SP283782053 SP254 20"
        '
        'qtyHeaderXrLabel
        '
        Me.qtyHeaderXrLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.qtyHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(48.95833!, 202.4999!)
        Me.qtyHeaderXrLabel.Name = "qtyHeaderXrLabel"
        Me.qtyHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.qtyHeaderXrLabel.SizeF = New System.Drawing.SizeF(152.0834!, 13.0!)
        Me.qtyHeaderXrLabel.StylePriority.UseFont = False
        Me.qtyHeaderXrLabel.Text = "QUANTITY"
        '
        'qtyXrLabel
        '
        Me.qtyXrLabel.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold)
        Me.qtyXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(48.95833!, 215.4999!)
        Me.qtyXrLabel.Name = "qtyXrLabel"
        Me.qtyXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.qtyXrLabel.SizeF = New System.Drawing.SizeF(152.0834!, 84.45839!)
        Me.qtyXrLabel.StylePriority.UseFont = False
        Me.qtyXrLabel.Text = "80"
        '
        'itemDescXrLabel
        '
        Me.itemDescXrLabel.BorderColor = System.Drawing.Color.DimGray
        Me.itemDescXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.itemDescXrLabel.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.itemDescXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(348.9584!, 152.2083!)
        Me.itemDescXrLabel.Name = "itemDescXrLabel"
        Me.itemDescXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemDescXrLabel.SizeF = New System.Drawing.SizeF(403.1249!, 47.16663!)
        Me.itemDescXrLabel.StylePriority.UseBorderColor = False
        Me.itemDescXrLabel.StylePriority.UseBorders = False
        Me.itemDescXrLabel.StylePriority.UseFont = False
        Me.itemDescXrLabel.Text = "TUXEDO MILK CHOCOLATE ALMONDS 48/35 OZ. BOXES"
        '
        'itemCodeXrLabel
        '
        Me.itemCodeXrLabel.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.itemCodeXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(48.95833!, 165.2084!)
        Me.itemCodeXrLabel.Name = "itemCodeXrLabel"
        Me.itemCodeXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemCodeXrLabel.SizeF = New System.Drawing.SizeF(300.0!, 34.16664!)
        Me.itemCodeXrLabel.StylePriority.UseFont = False
        Me.itemCodeXrLabel.Text = "1234567890123456"
        '
        'itemHeaderXrLabel
        '
        Me.itemHeaderXrLabel.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.itemHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(48.95833!, 152.2083!)
        Me.itemHeaderXrLabel.Name = "itemHeaderXrLabel"
        Me.itemHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemHeaderXrLabel.SizeF = New System.Drawing.SizeF(203.125!, 13.0!)
        Me.itemHeaderXrLabel.StylePriority.UseFont = False
        Me.itemHeaderXrLabel.Text = "MATERIAL NUMBER - DESCRIPTION"
        '
        'lpnHeaderXrLabel
        '
        Me.lpnHeaderXrLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lpnHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(300.0!, 35.0!)
        Me.lpnHeaderXrLabel.Name = "lpnHeaderXrLabel"
        Me.lpnHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lpnHeaderXrLabel.SizeF = New System.Drawing.SizeF(203.125!, 13.0!)
        Me.lpnHeaderXrLabel.StylePriority.UseFont = False
        Me.lpnHeaderXrLabel.Text = "LICENSE PLATE NUMBER"
        '
        'LPNXrBarCode
        '
        Me.LPNXrBarCode.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.LPNXrBarCode.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LPNXrBarCode.LocationFloat = New DevExpress.Utils.PointFloat(300.0!, 50.0!)
        Me.LPNXrBarCode.Name = "LPNXrBarCode"
        Me.LPNXrBarCode.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 2, 100.0!)
        Me.LPNXrBarCode.SizeF = New System.Drawing.SizeF(453.125!, 96.91664!)
        Me.LPNXrBarCode.StylePriority.UseFont = False
        Me.LPNXrBarCode.StylePriority.UsePadding = False
        Me.LPNXrBarCode.StylePriority.UseTextAlignment = False
        Me.LPNXrBarCode.Symbology = Code128Generator1
        Me.LPNXrBarCode.Text = "PIM480252"
        Me.LPNXrBarCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrLine3
        '
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(50.0!, 297.7916!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(703.125!, 2.166687!)
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(48.95833!, 199.3749!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(703.125!, 2.166687!)
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(50.0!, 150.0!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(703.125!, 2.083336!)
        '
        'ReprintXrLabel
        '
        Me.ReprintXrLabel.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.ReprintXrLabel.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.ReprintXrLabel.Angle = 15.0!
        Me.ReprintXrLabel.CanGrow = False
        Me.ReprintXrLabel.Font = New System.Drawing.Font("Calibri", 48.0!, System.Drawing.FontStyle.Bold)
        Me.ReprintXrLabel.ForeColor = System.Drawing.Color.Red
        Me.ReprintXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.ReprintXrLabel.Name = "ReprintXrLabel"
        Me.ReprintXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ReprintXrLabel.SizeF = New System.Drawing.SizeF(300.0!, 146.9166!)
        Me.ReprintXrLabel.StylePriority.UseFont = False
        Me.ReprintXrLabel.StylePriority.UseForeColor = False
        Me.ReprintXrLabel.StylePriority.UseTextAlignment = False
        Me.ReprintXrLabel.Text = "Reprint"
        Me.ReprintXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 1.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'LPNLabelsXtraReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.Font = New System.Drawing.Font("Tw Cen MT Condensed", 72.0!)
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 1)
        Me.PageHeight = 400
        Me.PageWidth = 800
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.Version = "17.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents exprHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents exprXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lotHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lotXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents qtyHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents qtyXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemDescXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemCodeXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lpnHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents LPNXrBarCode As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents tsXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReprintXrLabel As DevExpress.XtraReports.UI.XRLabel
End Class
