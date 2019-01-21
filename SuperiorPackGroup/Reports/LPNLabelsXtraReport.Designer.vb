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
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.exprXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.lotXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.qtyXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.exprHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.lotHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.qtyHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.itemDescXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.itemCodeXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.itemHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.tsXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.lpnHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.LPNXrBarCode = New DevExpress.XtraReports.UI.XRBarCode()
        Me.ReprintXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.lpnGroupHeader = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.AllergensXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.lpnGroupFooter = New DevExpress.XtraReports.UI.GroupFooterBand()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.SumQtyXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.exprXrLabel, Me.lotXrLabel, Me.qtyXrLabel})
        Me.Detail.HeightF = 25.08342!
        Me.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StylePriority.UseTextAlignment = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'exprXrLabel
        '
        Me.exprXrLabel.BorderColor = System.Drawing.Color.Gray
        Me.exprXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.exprXrLabel.CanGrow = False
        Me.exprXrLabel.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.exprXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(550.0001!, 0!)
        Me.exprXrLabel.Name = "exprXrLabel"
        Me.exprXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.exprXrLabel.SizeF = New System.Drawing.SizeF(202.0832!, 25.08342!)
        Me.exprXrLabel.StylePriority.UseBorderColor = False
        Me.exprXrLabel.StylePriority.UseBorders = False
        Me.exprXrLabel.StylePriority.UseFont = False
        Me.exprXrLabel.Text = "12/31/2022"
        '
        'lotXrLabel
        '
        Me.lotXrLabel.BorderColor = System.Drawing.Color.Gray
        Me.lotXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.lotXrLabel.CanGrow = False
        Me.lotXrLabel.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lotXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(201.0418!, 0!)
        Me.lotXrLabel.Name = "lotXrLabel"
        Me.lotXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lotXrLabel.SizeF = New System.Drawing.SizeF(348.9583!, 25.08342!)
        Me.lotXrLabel.StylePriority.UseBorderColor = False
        Me.lotXrLabel.StylePriority.UseBorders = False
        Me.lotXrLabel.StylePriority.UseFont = False
        Me.lotXrLabel.Text = "SP283782053 SP254 20"
        '
        'qtyXrLabel
        '
        Me.qtyXrLabel.BorderColor = System.Drawing.Color.Gray
        Me.qtyXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.qtyXrLabel.CanGrow = False
        Me.qtyXrLabel.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.qtyXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(47.91663!, 0!)
        Me.qtyXrLabel.Name = "qtyXrLabel"
        Me.qtyXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.qtyXrLabel.SizeF = New System.Drawing.SizeF(153.1252!, 25.08342!)
        Me.qtyXrLabel.StylePriority.UseBorderColor = False
        Me.qtyXrLabel.StylePriority.UseBorders = False
        Me.qtyXrLabel.StylePriority.UseFont = False
        Me.qtyXrLabel.Text = "80"
        '
        'exprHeaderXrLabel
        '
        Me.exprHeaderXrLabel.BorderColor = System.Drawing.Color.Black
        Me.exprHeaderXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.exprHeaderXrLabel.CanGrow = False
        Me.exprHeaderXrLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.exprHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(550.0!, 167.9583!)
        Me.exprHeaderXrLabel.Name = "exprHeaderXrLabel"
        Me.exprHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.exprHeaderXrLabel.SizeF = New System.Drawing.SizeF(202.0832!, 25.08342!)
        Me.exprHeaderXrLabel.StylePriority.UseBorderColor = False
        Me.exprHeaderXrLabel.StylePriority.UseBorders = False
        Me.exprHeaderXrLabel.StylePriority.UseFont = False
        Me.exprHeaderXrLabel.StylePriority.UseTextAlignment = False
        Me.exprHeaderXrLabel.Text = "Expiration Date"
        Me.exprHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lotHeaderXrLabel
        '
        Me.lotHeaderXrLabel.BorderColor = System.Drawing.Color.Black
        Me.lotHeaderXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.lotHeaderXrLabel.CanGrow = False
        Me.lotHeaderXrLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lotHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(201.0417!, 167.9583!)
        Me.lotHeaderXrLabel.Name = "lotHeaderXrLabel"
        Me.lotHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lotHeaderXrLabel.SizeF = New System.Drawing.SizeF(348.9583!, 25.08342!)
        Me.lotHeaderXrLabel.StylePriority.UseBorderColor = False
        Me.lotHeaderXrLabel.StylePriority.UseBorders = False
        Me.lotHeaderXrLabel.StylePriority.UseFont = False
        Me.lotHeaderXrLabel.StylePriority.UseTextAlignment = False
        Me.lotHeaderXrLabel.Text = "Lot#"
        Me.lotHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'qtyHeaderXrLabel
        '
        Me.qtyHeaderXrLabel.BorderColor = System.Drawing.Color.Black
        Me.qtyHeaderXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.qtyHeaderXrLabel.CanGrow = False
        Me.qtyHeaderXrLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.qtyHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(47.91667!, 167.9583!)
        Me.qtyHeaderXrLabel.Name = "qtyHeaderXrLabel"
        Me.qtyHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.qtyHeaderXrLabel.SizeF = New System.Drawing.SizeF(153.1252!, 25.0834!)
        Me.qtyHeaderXrLabel.StylePriority.UseBorderColor = False
        Me.qtyHeaderXrLabel.StylePriority.UseBorders = False
        Me.qtyHeaderXrLabel.StylePriority.UseFont = False
        Me.qtyHeaderXrLabel.StylePriority.UseTextAlignment = False
        Me.qtyHeaderXrLabel.Text = "Quantity"
        Me.qtyHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'itemDescXrLabel
        '
        Me.itemDescXrLabel.BorderColor = System.Drawing.Color.DarkGray
        Me.itemDescXrLabel.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.itemDescXrLabel.CanGrow = False
        Me.itemDescXrLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.itemDescXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(307.2917!, 118.375!)
        Me.itemDescXrLabel.Name = "itemDescXrLabel"
        Me.itemDescXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemDescXrLabel.SizeF = New System.Drawing.SizeF(444.7916!, 49.58331!)
        Me.itemDescXrLabel.StylePriority.UseBorderColor = False
        Me.itemDescXrLabel.StylePriority.UseBorders = False
        Me.itemDescXrLabel.StylePriority.UseFont = False
        Me.itemDescXrLabel.Text = "TUXEDO MILK CHOCOLATE ALMONDS 48/35 OZ. BOXES"
        '
        'itemCodeXrLabel
        '
        Me.itemCodeXrLabel.BorderColor = System.Drawing.Color.Gray
        Me.itemCodeXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.itemCodeXrLabel.CanGrow = False
        Me.itemCodeXrLabel.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.itemCodeXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(47.91663!, 143.1667!)
        Me.itemCodeXrLabel.Name = "itemCodeXrLabel"
        Me.itemCodeXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemCodeXrLabel.SizeF = New System.Drawing.SizeF(259.3751!, 24.79165!)
        Me.itemCodeXrLabel.StylePriority.UseBorderColor = False
        Me.itemCodeXrLabel.StylePriority.UseBorders = False
        Me.itemCodeXrLabel.StylePriority.UseFont = False
        Me.itemCodeXrLabel.Text = "1234567890123456"
        '
        'itemHeaderXrLabel
        '
        Me.itemHeaderXrLabel.BorderColor = System.Drawing.Color.Gray
        Me.itemHeaderXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.itemHeaderXrLabel.CanGrow = False
        Me.itemHeaderXrLabel.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.itemHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(47.91663!, 118.375!)
        Me.itemHeaderXrLabel.Name = "itemHeaderXrLabel"
        Me.itemHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemHeaderXrLabel.SizeF = New System.Drawing.SizeF(259.3751!, 24.79166!)
        Me.itemHeaderXrLabel.StylePriority.UseBorderColor = False
        Me.itemHeaderXrLabel.StylePriority.UseBorders = False
        Me.itemHeaderXrLabel.StylePriority.UseFont = False
        Me.itemHeaderXrLabel.StylePriority.UseTextAlignment = False
        Me.itemHeaderXrLabel.Text = "Item Number - Description"
        Me.itemHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'tsXrLabel
        '
        Me.tsXrLabel.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Now()")})
        Me.tsXrLabel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tsXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(453.1251!, 18.41682!)
        Me.tsXrLabel.Name = "tsXrLabel"
        Me.tsXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.tsXrLabel.SizeF = New System.Drawing.SizeF(300.0!, 23.74994!)
        Me.tsXrLabel.StylePriority.UseFont = False
        Me.tsXrLabel.StylePriority.UseTextAlignment = False
        Me.tsXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lpnHeaderXrLabel
        '
        Me.lpnHeaderXrLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lpnHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(298.9583!, 0!)
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
        Me.LPNXrBarCode.LocationFloat = New DevExpress.Utils.PointFloat(300.0001!, 13.00001!)
        Me.LPNXrBarCode.Name = "LPNXrBarCode"
        Me.LPNXrBarCode.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 2, 100.0!)
        Me.LPNXrBarCode.SizeF = New System.Drawing.SizeF(453.125!, 105.375!)
        Me.LPNXrBarCode.StylePriority.UseFont = False
        Me.LPNXrBarCode.StylePriority.UsePadding = False
        Me.LPNXrBarCode.StylePriority.UseTextAlignment = False
        Me.LPNXrBarCode.Symbology = Code128Generator1
        Me.LPNXrBarCode.Text = "PIM480252"
        Me.LPNXrBarCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReprintXrLabel
        '
        Me.ReprintXrLabel.AnchorHorizontal = CType((DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left Or DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right), DevExpress.XtraReports.UI.HorizontalAnchorStyles)
        Me.ReprintXrLabel.AnchorVertical = CType((DevExpress.XtraReports.UI.VerticalAnchorStyles.Top Or DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom), DevExpress.XtraReports.UI.VerticalAnchorStyles)
        Me.ReprintXrLabel.Angle = 10.0!
        Me.ReprintXrLabel.CanGrow = False
        Me.ReprintXrLabel.Font = New System.Drawing.Font("Calibri", 48.0!, System.Drawing.FontStyle.Bold)
        Me.ReprintXrLabel.ForeColor = System.Drawing.Color.Red
        Me.ReprintXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0.00006357829!, 0!)
        Me.ReprintXrLabel.Name = "ReprintXrLabel"
        Me.ReprintXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.ReprintXrLabel.SizeF = New System.Drawing.SizeF(288.5417!, 92.33337!)
        Me.ReprintXrLabel.StylePriority.UseFont = False
        Me.ReprintXrLabel.StylePriority.UseForeColor = False
        Me.ReprintXrLabel.StylePriority.UseTextAlignment = False
        Me.ReprintXrLabel.Text = "Reprint"
        Me.ReprintXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'TopMargin
        '
        Me.TopMargin.BorderColor = System.Drawing.Color.Transparent
        Me.TopMargin.HeightF = 0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.StylePriority.UseBorderColor = False
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.TopMargin.Visible = False
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 1.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.BottomMargin.Visible = False
        '
        'lpnGroupHeader
        '
        Me.lpnGroupHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.exprHeaderXrLabel, Me.lotHeaderXrLabel, Me.qtyHeaderXrLabel, Me.itemDescXrLabel, Me.itemHeaderXrLabel, Me.itemCodeXrLabel, Me.LPNXrBarCode, Me.lpnHeaderXrLabel, Me.ReprintXrLabel})
        Me.lpnGroupHeader.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage
        Me.lpnGroupHeader.HeightF = 193.1667!
        Me.lpnGroupHeader.Name = "lpnGroupHeader"
        Me.lpnGroupHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.lpnGroupHeader.StylePriority.UsePadding = False
        '
        'AllergensXrLabel
        '
        Me.AllergensXrLabel.BorderColor = System.Drawing.Color.Gray
        Me.AllergensXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.AllergensXrLabel.CanGrow = False
        Me.AllergensXrLabel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.AllergensXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(47.91641!, 51.25001!)
        Me.AllergensXrLabel.Name = "AllergensXrLabel"
        Me.AllergensXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.AllergensXrLabel.SizeF = New System.Drawing.SizeF(704.1667!, 24.79164!)
        Me.AllergensXrLabel.StylePriority.UseBorderColor = False
        Me.AllergensXrLabel.StylePriority.UseBorders = False
        Me.AllergensXrLabel.StylePriority.UseFont = False
        Me.AllergensXrLabel.StylePriority.UseTextAlignment = False
        Me.AllergensXrLabel.Text = "Allergens: Milk, Soy, etc"
        Me.AllergensXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lpnGroupFooter
        '
        Me.lpnGroupFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.AllergensXrLabel, Me.XrLabel2, Me.SumQtyXrLabel, Me.tsXrLabel})
        Me.lpnGroupFooter.HeightF = 87.5!
        Me.lpnGroupFooter.KeepTogether = True
        Me.lpnGroupFooter.Name = "lpnGroupFooter"
        Me.lpnGroupFooter.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
        Me.lpnGroupFooter.PrintAtBottom = True
        '
        'XrLabel2
        '
        Me.XrLabel2.BorderColor = System.Drawing.Color.Gray
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel2.CanGrow = False
        Me.XrLabel2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(47.91663!, 2.083333!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(153.1252!, 15.0!)
        Me.XrLabel2.StylePriority.UseBorderColor = False
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Total Quantity"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'SumQtyXrLabel
        '
        Me.SumQtyXrLabel.BorderColor = System.Drawing.Color.Gray
        Me.SumQtyXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.SumQtyXrLabel.CanGrow = False
        Me.SumQtyXrLabel.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.SumQtyXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(47.91662!, 17.08333!)
        Me.SumQtyXrLabel.Name = "SumQtyXrLabel"
        Me.SumQtyXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.SumQtyXrLabel.SizeF = New System.Drawing.SizeF(153.1252!, 25.08342!)
        Me.SumQtyXrLabel.StylePriority.UseBorderColor = False
        Me.SumQtyXrLabel.StylePriority.UseBorders = False
        Me.SumQtyXrLabel.StylePriority.UseFont = False
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.SumQtyXrLabel.Summary = XrSummary1
        Me.SumQtyXrLabel.Text = "80"
        '
        'LPNLabelsXtraReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.lpnGroupHeader, Me.lpnGroupFooter})
        Me.BorderColor = System.Drawing.Color.Transparent
        Me.Font = New System.Drawing.Font("Tw Cen MT Condensed", 72.0!)
        Me.HorizontalContentSplitting = DevExpress.XtraPrinting.HorizontalContentSplitting.Smart
        Me.Landscape = True
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
    Friend WithEvents lpnGroupHeader As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents lpnGroupFooter As DevExpress.XtraReports.UI.GroupFooterBand
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SumQtyXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents AllergensXrLabel As DevExpress.XtraReports.UI.XRLabel
End Class
