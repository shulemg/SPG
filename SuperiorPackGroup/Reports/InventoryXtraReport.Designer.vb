<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class InventoryXtraReport
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
        Me.RMitemDescriptionDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.RMitemCodeDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.customerNameDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.quantityDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.itemTypeDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.reasonDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.itemDescriptionDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.itemCodeDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.byPalletDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.dateDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.headerXrPanel = New DevExpress.XtraReports.UI.XRPanel()
        Me.lowestRMDescriptionXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.lowestRMItemCodeXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.quantityHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.itemTypeHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.reasonHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.itemDescriptionHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.itemCodeHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.byPalletHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.customerNameHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.dateHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.pageNumberXrPageInfo = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.headerXrControlStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.footerXrControlStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.detailOddXrControlStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.detailEvenXrControlStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.printDateXrPageInfo = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.reportCriteriaXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.reportTitleXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.UOMHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.UOMDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.UOMDetailXrLabel, Me.RMitemDescriptionDetailXrLabel, Me.RMitemCodeDetailXrLabel, Me.customerNameDetailXrLabel, Me.quantityDetailXrLabel, Me.itemTypeDetailXrLabel, Me.reasonDetailXrLabel, Me.itemDescriptionDetailXrLabel, Me.itemCodeDetailXrLabel, Me.byPalletDetailXrLabel, Me.dateDetailXrLabel})
        Me.Detail.HeightF = 30.0!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'RMitemDescriptionDetailXrLabel
        '
        Me.RMitemDescriptionDetailXrLabel.CanGrow = False
        Me.RMitemDescriptionDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.RMitemDescriptionDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(450.0!, 0.0!)
        Me.RMitemDescriptionDetailXrLabel.Name = "RMitemDescriptionDetailXrLabel"
        Me.RMitemDescriptionDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.RMitemDescriptionDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.RMitemDescriptionDetailXrLabel.SizeF = New System.Drawing.SizeF(149.0!, 30.0!)
        Me.RMitemDescriptionDetailXrLabel.Text = "itemDescriptionDetailXrLabel"
        Me.RMitemDescriptionDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'RMitemCodeDetailXrLabel
        '
        Me.RMitemCodeDetailXrLabel.CanGrow = False
        Me.RMitemCodeDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.RMitemCodeDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(317.0!, 0.0!)
        Me.RMitemCodeDetailXrLabel.Name = "RMitemCodeDetailXrLabel"
        Me.RMitemCodeDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.RMitemCodeDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.RMitemCodeDetailXrLabel.SizeF = New System.Drawing.SizeF(145.0!, 30.0!)
        Me.RMitemCodeDetailXrLabel.Text = "itemCodeDetailXrLabel"
        Me.RMitemCodeDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'customerNameDetailXrLabel
        '
        Me.customerNameDetailXrLabel.CanGrow = False
        Me.customerNameDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.customerNameDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(118.0!, 0.0!)
        Me.customerNameDetailXrLabel.Name = "customerNameDetailXrLabel"
        Me.customerNameDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.customerNameDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.customerNameDetailXrLabel.SizeF = New System.Drawing.SizeF(150.0!, 30.0!)
        Me.customerNameDetailXrLabel.Text = "customerNameDetailXrLabel"
        Me.customerNameDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'quantityDetailXrLabel
        '
        Me.quantityDetailXrLabel.CanGrow = False
        Me.quantityDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.quantityDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(283.0!, 0.0!)
        Me.quantityDetailXrLabel.Name = "quantityDetailXrLabel"
        Me.quantityDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.quantityDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.quantityDetailXrLabel.SizeF = New System.Drawing.SizeF(140.0!, 30.0!)
        Me.quantityDetailXrLabel.Text = "quantityDetailXrLabel"
        Me.quantityDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'itemTypeDetailXrLabel
        '
        Me.itemTypeDetailXrLabel.CanGrow = False
        Me.itemTypeDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.itemTypeDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(483.0!, 0.0!)
        Me.itemTypeDetailXrLabel.Name = "itemTypeDetailXrLabel"
        Me.itemTypeDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.itemTypeDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemTypeDetailXrLabel.SizeF = New System.Drawing.SizeF(100.0!, 30.0!)
        Me.itemTypeDetailXrLabel.StylePriority.UseTextAlignment = False
        Me.itemTypeDetailXrLabel.Text = "itemTypeDetailXrLabel"
        Me.itemTypeDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'reasonDetailXrLabel
        '
        Me.reasonDetailXrLabel.CanGrow = False
        Me.reasonDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.reasonDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(492.0!, 0.0!)
        Me.reasonDetailXrLabel.Name = "reasonDetailXrLabel"
        Me.reasonDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.reasonDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.reasonDetailXrLabel.SizeF = New System.Drawing.SizeF(145.0!, 30.0!)
        Me.reasonDetailXrLabel.StylePriority.UseTextAlignment = False
        Me.reasonDetailXrLabel.Text = "reasonDetailXrLabel"
        Me.reasonDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'itemDescriptionDetailXrLabel
        '
        Me.itemDescriptionDetailXrLabel.CanGrow = False
        Me.itemDescriptionDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.itemDescriptionDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(413.0!, 0.0!)
        Me.itemDescriptionDetailXrLabel.Name = "itemDescriptionDetailXrLabel"
        Me.itemDescriptionDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.itemDescriptionDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemDescriptionDetailXrLabel.SizeF = New System.Drawing.SizeF(149.0!, 30.0!)
        Me.itemDescriptionDetailXrLabel.Text = "itemDescriptionDetailXrLabel"
        Me.itemDescriptionDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'itemCodeDetailXrLabel
        '
        Me.itemCodeDetailXrLabel.CanGrow = False
        Me.itemCodeDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.itemCodeDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(268.0!, 0.0!)
        Me.itemCodeDetailXrLabel.Name = "itemCodeDetailXrLabel"
        Me.itemCodeDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.itemCodeDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemCodeDetailXrLabel.SizeF = New System.Drawing.SizeF(145.0!, 30.0!)
        Me.itemCodeDetailXrLabel.Text = "itemCodeDetailXrLabel"
        Me.itemCodeDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'byPalletDetailXrLabel
        '
        Me.byPalletDetailXrLabel.CanGrow = False
        Me.byPalletDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.byPalletDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(660.0!, 0.0!)
        Me.byPalletDetailXrLabel.Name = "byPalletDetailXrLabel"
        Me.byPalletDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.byPalletDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.byPalletDetailXrLabel.SizeF = New System.Drawing.SizeF(140.0!, 30.0!)
        Me.byPalletDetailXrLabel.StylePriority.UseTextAlignment = False
        Me.byPalletDetailXrLabel.Text = "byPalletDetailXrLabel"
        Me.byPalletDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'dateDetailXrLabel
        '
        Me.dateDetailXrLabel.CanGrow = False
        Me.dateDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.dateDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.dateDetailXrLabel.Name = "dateDetailXrLabel"
        Me.dateDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.dateDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.dateDetailXrLabel.SizeF = New System.Drawing.SizeF(118.0!, 30.0!)
        Me.dateDetailXrLabel.Text = "dateDetailXrLabel"
        Me.dateDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
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
        Me.headerXrPanel.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.UOMHeaderXrLabel, Me.lowestRMDescriptionXrLabel, Me.lowestRMItemCodeXrLabel, Me.quantityHeaderXrLabel, Me.itemTypeHeaderXrLabel, Me.reasonHeaderXrLabel, Me.itemDescriptionHeaderXrLabel, Me.itemCodeHeaderXrLabel, Me.byPalletHeaderXrLabel, Me.customerNameHeaderXrLabel, Me.dateHeaderXrLabel})
        Me.headerXrPanel.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.headerXrPanel.Name = "headerXrPanel"
        Me.headerXrPanel.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.headerXrPanel.SizeF = New System.Drawing.SizeF(800.0!, 50.0!)
        '
        'lowestRMDescriptionXrLabel
        '
        Me.lowestRMDescriptionXrLabel.CanGrow = False
        Me.lowestRMDescriptionXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lowestRMDescriptionXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(325.0!, 0.0!)
        Me.lowestRMDescriptionXrLabel.Name = "lowestRMDescriptionXrLabel"
        Me.lowestRMDescriptionXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lowestRMDescriptionXrLabel.SizeF = New System.Drawing.SizeF(149.0!, 50.0!)
        Me.lowestRMDescriptionXrLabel.StyleName = "headerXrControlStyle"
        Me.lowestRMDescriptionXrLabel.StylePriority.UseFont = False
        Me.lowestRMDescriptionXrLabel.Text = "RM Item Description"
        Me.lowestRMDescriptionXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lowestRMItemCodeXrLabel
        '
        Me.lowestRMItemCodeXrLabel.CanGrow = False
        Me.lowestRMItemCodeXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lowestRMItemCodeXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(325.0!, 0.0!)
        Me.lowestRMItemCodeXrLabel.Name = "lowestRMItemCodeXrLabel"
        Me.lowestRMItemCodeXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lowestRMItemCodeXrLabel.SizeF = New System.Drawing.SizeF(145.0!, 50.0!)
        Me.lowestRMItemCodeXrLabel.StyleName = "headerXrControlStyle"
        Me.lowestRMItemCodeXrLabel.StylePriority.UseFont = False
        Me.lowestRMItemCodeXrLabel.Text = "Lowest RM Item #"
        Me.lowestRMItemCodeXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'quantityHeaderXrLabel
        '
        Me.quantityHeaderXrLabel.CanGrow = False
        Me.quantityHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.quantityHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(283.0!, 0.0!)
        Me.quantityHeaderXrLabel.Name = "quantityHeaderXrLabel"
        Me.quantityHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.quantityHeaderXrLabel.SizeF = New System.Drawing.SizeF(140.0!, 50.0!)
        Me.quantityHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.quantityHeaderXrLabel.StylePriority.UseFont = False
        Me.quantityHeaderXrLabel.Text = "Qty"
        Me.quantityHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'itemTypeHeaderXrLabel
        '
        Me.itemTypeHeaderXrLabel.CanGrow = False
        Me.itemTypeHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.itemTypeHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(483.0!, 0.0!)
        Me.itemTypeHeaderXrLabel.Name = "itemTypeHeaderXrLabel"
        Me.itemTypeHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemTypeHeaderXrLabel.SizeF = New System.Drawing.SizeF(100.0!, 50.0!)
        Me.itemTypeHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.itemTypeHeaderXrLabel.StylePriority.UseFont = False
        Me.itemTypeHeaderXrLabel.Text = "Item Type"
        Me.itemTypeHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'reasonHeaderXrLabel
        '
        Me.reasonHeaderXrLabel.CanGrow = False
        Me.reasonHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.reasonHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(500.0!, 0.0!)
        Me.reasonHeaderXrLabel.Name = "reasonHeaderXrLabel"
        Me.reasonHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.reasonHeaderXrLabel.SizeF = New System.Drawing.SizeF(145.0!, 50.0!)
        Me.reasonHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.reasonHeaderXrLabel.StylePriority.UseFont = False
        Me.reasonHeaderXrLabel.Text = "Reason"
        Me.reasonHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'itemDescriptionHeaderXrLabel
        '
        Me.itemDescriptionHeaderXrLabel.CanGrow = False
        Me.itemDescriptionHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.itemDescriptionHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(413.0!, 0.0!)
        Me.itemDescriptionHeaderXrLabel.Name = "itemDescriptionHeaderXrLabel"
        Me.itemDescriptionHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemDescriptionHeaderXrLabel.SizeF = New System.Drawing.SizeF(149.0!, 50.0!)
        Me.itemDescriptionHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.itemDescriptionHeaderXrLabel.StylePriority.UseFont = False
        Me.itemDescriptionHeaderXrLabel.Text = "Item Description"
        Me.itemDescriptionHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'itemCodeHeaderXrLabel
        '
        Me.itemCodeHeaderXrLabel.CanGrow = False
        Me.itemCodeHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.itemCodeHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(268.0!, 0.0!)
        Me.itemCodeHeaderXrLabel.Name = "itemCodeHeaderXrLabel"
        Me.itemCodeHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemCodeHeaderXrLabel.SizeF = New System.Drawing.SizeF(145.0!, 50.0!)
        Me.itemCodeHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.itemCodeHeaderXrLabel.StylePriority.UseFont = False
        Me.itemCodeHeaderXrLabel.Text = "Item #"
        Me.itemCodeHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'byPalletHeaderXrLabel
        '
        Me.byPalletHeaderXrLabel.CanGrow = False
        Me.byPalletHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.byPalletHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(660.0!, 0.0!)
        Me.byPalletHeaderXrLabel.Name = "byPalletHeaderXrLabel"
        Me.byPalletHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.byPalletHeaderXrLabel.SizeF = New System.Drawing.SizeF(140.0!, 50.0!)
        Me.byPalletHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.byPalletHeaderXrLabel.StylePriority.UseFont = False
        Me.byPalletHeaderXrLabel.Text = "By Pallet"
        Me.byPalletHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'customerNameHeaderXrLabel
        '
        Me.customerNameHeaderXrLabel.CanGrow = False
        Me.customerNameHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.customerNameHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(118.0!, 0.0!)
        Me.customerNameHeaderXrLabel.Name = "customerNameHeaderXrLabel"
        Me.customerNameHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.customerNameHeaderXrLabel.SizeF = New System.Drawing.SizeF(150.0!, 50.0!)
        Me.customerNameHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.customerNameHeaderXrLabel.StylePriority.UseFont = False
        Me.customerNameHeaderXrLabel.Text = "Customer"
        Me.customerNameHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'dateHeaderXrLabel
        '
        Me.dateHeaderXrLabel.CanGrow = False
        Me.dateHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.dateHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.dateHeaderXrLabel.Name = "dateHeaderXrLabel"
        Me.dateHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.dateHeaderXrLabel.SizeF = New System.Drawing.SizeF(118.0!, 50.0!)
        Me.dateHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.dateHeaderXrLabel.StylePriority.UseFont = False
        Me.dateHeaderXrLabel.Text = "Date"
        Me.dateHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
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
        Me.pageNumberXrPageInfo.LocationFloat = New DevExpress.Utils.PointFloat(700.0!, 0.0!)
        Me.pageNumberXrPageInfo.Name = "pageNumberXrPageInfo"
        Me.pageNumberXrPageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.pageNumberXrPageInfo.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
        Me.pageNumberXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
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
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.printDateXrPageInfo, Me.reportCriteriaXrLabel, Me.reportTitleXrLabel})
        Me.ReportHeader.HeightF = 86.0!
        Me.ReportHeader.KeepTogether = True
        Me.ReportHeader.Name = "ReportHeader"
        '
        'printDateXrPageInfo
        '
        Me.printDateXrPageInfo.LocationFloat = New DevExpress.Utils.PointFloat(650.0!, 50.0!)
        Me.printDateXrPageInfo.Name = "printDateXrPageInfo"
        Me.printDateXrPageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.printDateXrPageInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.printDateXrPageInfo.SizeF = New System.Drawing.SizeF(150.0!, 35.0!)
        Me.printDateXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'reportCriteriaXrLabel
        '
        Me.reportCriteriaXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 50.0!)
        Me.reportCriteriaXrLabel.Name = "reportCriteriaXrLabel"
        Me.reportCriteriaXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.reportCriteriaXrLabel.SizeF = New System.Drawing.SizeF(625.0!, 35.0!)
        Me.reportCriteriaXrLabel.Text = "reportCriteriaXrLabel"
        Me.reportCriteriaXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'reportTitleXrLabel
        '
        Me.reportTitleXrLabel.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.reportTitleXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.reportTitleXrLabel.Name = "reportTitleXrLabel"
        Me.reportTitleXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.reportTitleXrLabel.SizeF = New System.Drawing.SizeF(800.0!, 50.0!)
        Me.reportTitleXrLabel.Text = "reportTitleXrLabel"
        Me.reportTitleXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
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
        'UOMHeaderXrLabel
        '
        Me.UOMHeaderXrLabel.CanGrow = False
        Me.UOMHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.UOMHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(325.0!, 0.0!)
        Me.UOMHeaderXrLabel.Name = "UOMHeaderXrLabel"
        Me.UOMHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.UOMHeaderXrLabel.SizeF = New System.Drawing.SizeF(100.0!, 50.0!)
        Me.UOMHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.UOMHeaderXrLabel.StylePriority.UseFont = False
        Me.UOMHeaderXrLabel.Text = "Unit Of Measure"
        Me.UOMHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'UOMDetailXrLabel
        '
        Me.UOMDetailXrLabel.CanGrow = False
        Me.UOMDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.UOMDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(450.0!, 0.0!)
        Me.UOMDetailXrLabel.Name = "UOMDetailXrLabel"
        Me.UOMDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.UOMDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.UOMDetailXrLabel.SizeF = New System.Drawing.SizeF(100.0!, 30.0!)
        Me.UOMDetailXrLabel.Text = "customerNameDetailXrLabel"
        Me.UOMDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'InventoryXtraReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.ReportHeader, Me.TopMarginBand1, Me.BottomMarginBand1})
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
    Friend WithEvents headerXrControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents footerXrControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents detailOddXrControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents detailEvenXrControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents printDateXrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents reportCriteriaXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents reportTitleXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents headerXrPanel As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents quantityHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemTypeHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents reasonHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemDescriptionHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemCodeHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents byPalletHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents customerNameHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents dateHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents quantityDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemTypeDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents reasonDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemDescriptionDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemCodeDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents byPalletDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents dateDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents customerNameDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pageNumberXrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents RMitemCodeDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lowestRMDescriptionXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lowestRMItemCodeXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents RMitemDescriptionDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents UOMDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents UOMHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
End Class
