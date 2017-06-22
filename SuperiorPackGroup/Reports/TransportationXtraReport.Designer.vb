<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class TransportationXtraReport
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
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.carrierDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.trailerDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.sealDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.poDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.quantityDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vendorDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.destinationDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.deliveryNoteNumberDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.bolDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.itemDescriptionDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.itemCodeDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.lotDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.customerNameDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.shiftDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.dateDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.headerXrPanel = New DevExpress.XtraReports.UI.XRPanel()
        Me.sealHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.trailerHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.carrierHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.poHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.quantityHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.vendorHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.destinationHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.deliveryNoteNumberHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.bolHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.itemDescriptionHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.itemCodeHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.lotHeadeerXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.customerNameHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.shiftHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
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
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.footerXrPanel = New DevExpress.XtraReports.UI.XRPanel()
        Me.quantityFooterXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.expirationDateHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.expirationDateDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.expirationDateDetailXrLabel, Me.carrierDetailXrLabel, Me.trailerDetailXrLabel, Me.sealDetailXrLabel, Me.poDetailXrLabel, Me.quantityDetailXrLabel, Me.vendorDetailXrLabel, Me.destinationDetailXrLabel, Me.deliveryNoteNumberDetailXrLabel, Me.bolDetailXrLabel, Me.itemDescriptionDetailXrLabel, Me.itemCodeDetailXrLabel, Me.lotDetailXrLabel, Me.customerNameDetailXrLabel, Me.shiftDetailXrLabel, Me.dateDetailXrLabel})
        Me.Detail.HeightF = 30.0!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'carrierDetailXrLabel
        '
        Me.carrierDetailXrLabel.CanGrow = False
        Me.carrierDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.carrierDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(866.0!, 0.0!)
        Me.carrierDetailXrLabel.Name = "carrierDetailXrLabel"
        Me.carrierDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.carrierDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.carrierDetailXrLabel.SizeF = New System.Drawing.SizeF(68.0!, 30.0!)
        Me.carrierDetailXrLabel.Text = "carrierDetailXrLabel"
        Me.carrierDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'trailerDetailXrLabel
        '
        Me.trailerDetailXrLabel.CanGrow = False
        Me.trailerDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.trailerDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(934.0!, 0.0!)
        Me.trailerDetailXrLabel.Name = "trailerDetailXrLabel"
        Me.trailerDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.trailerDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.trailerDetailXrLabel.SizeF = New System.Drawing.SizeF(63.0!, 30.0!)
        Me.trailerDetailXrLabel.Text = "trailerDetailXrLabel"
        Me.trailerDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'sealDetailXrLabel
        '
        Me.sealDetailXrLabel.CanGrow = False
        Me.sealDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.sealDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(997.0!, 0.0!)
        Me.sealDetailXrLabel.Name = "sealDetailXrLabel"
        Me.sealDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.sealDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.sealDetailXrLabel.SizeF = New System.Drawing.SizeF(53.0!, 30.0!)
        Me.sealDetailXrLabel.StylePriority.UseTextAlignment = False
        Me.sealDetailXrLabel.Text = "sealDetailXrLabel"
        Me.sealDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'poDetailXrLabel
        '
        Me.poDetailXrLabel.CanGrow = False
        Me.poDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.poDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(248.0!, 0.0!)
        Me.poDetailXrLabel.Name = "poDetailXrLabel"
        Me.poDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.poDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.poDetailXrLabel.SizeF = New System.Drawing.SizeF(51.0!, 30.0!)
        Me.poDetailXrLabel.StylePriority.UseTextAlignment = False
        Me.poDetailXrLabel.Text = "poDetailXrLabel"
        Me.poDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'quantityDetailXrLabel
        '
        Me.quantityDetailXrLabel.CanGrow = False
        Me.quantityDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.quantityDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(735.0!, 0.0!)
        Me.quantityDetailXrLabel.Name = "quantityDetailXrLabel"
        Me.quantityDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.quantityDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.quantityDetailXrLabel.SizeF = New System.Drawing.SizeF(58.0!, 30.0!)
        Me.quantityDetailXrLabel.Text = "quantityDetailXrLabel"
        Me.quantityDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'vendorDetailXrLabel
        '
        Me.vendorDetailXrLabel.CanGrow = False
        Me.vendorDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.vendorDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(793.0!, 0.0!)
        Me.vendorDetailXrLabel.Name = "vendorDetailXrLabel"
        Me.vendorDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.vendorDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vendorDetailXrLabel.SizeF = New System.Drawing.SizeF(73.0!, 30.0!)
        Me.vendorDetailXrLabel.StylePriority.UseTextAlignment = False
        Me.vendorDetailXrLabel.Text = "vendorDetailXrLabel"
        Me.vendorDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'destinationDetailXrLabel
        '
        Me.destinationDetailXrLabel.CanGrow = False
        Me.destinationDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.destinationDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(352.0!, 0.0!)
        Me.destinationDetailXrLabel.Name = "destinationDetailXrLabel"
        Me.destinationDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.destinationDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.destinationDetailXrLabel.SizeF = New System.Drawing.SizeF(98.0!, 30.0!)
        Me.destinationDetailXrLabel.StylePriority.UseTextAlignment = False
        Me.destinationDetailXrLabel.Text = "destinationDetailXrLabel"
        Me.destinationDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'deliveryNoteNumberDetailXrLabel
        '
        Me.deliveryNoteNumberDetailXrLabel.CanGrow = False
        Me.deliveryNoteNumberDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.deliveryNoteNumberDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(299.0!, 0.0!)
        Me.deliveryNoteNumberDetailXrLabel.Name = "deliveryNoteNumberDetailXrLabel"
        Me.deliveryNoteNumberDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.deliveryNoteNumberDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.deliveryNoteNumberDetailXrLabel.SizeF = New System.Drawing.SizeF(53.0!, 30.0!)
        Me.deliveryNoteNumberDetailXrLabel.StylePriority.UseTextAlignment = False
        Me.deliveryNoteNumberDetailXrLabel.Text = "deliveryNoteNumberDetailXrLabel"
        Me.deliveryNoteNumberDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'bolDetailXrLabel
        '
        Me.bolDetailXrLabel.CanGrow = False
        Me.bolDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.bolDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(192.0!, 0.0!)
        Me.bolDetailXrLabel.Name = "bolDetailXrLabel"
        Me.bolDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.bolDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.bolDetailXrLabel.SizeF = New System.Drawing.SizeF(56.0!, 30.0!)
        Me.bolDetailXrLabel.Text = "bolDetailXrLabel"
        Me.bolDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'itemDescriptionDetailXrLabel
        '
        Me.itemDescriptionDetailXrLabel.CanGrow = False
        Me.itemDescriptionDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.itemDescriptionDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(511.0!, 0.0!)
        Me.itemDescriptionDetailXrLabel.Name = "itemDescriptionDetailXrLabel"
        Me.itemDescriptionDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.itemDescriptionDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemDescriptionDetailXrLabel.SizeF = New System.Drawing.SizeF(103.0!, 30.0!)
        Me.itemDescriptionDetailXrLabel.Text = "itemDescriptionDetailXrLabel"
        Me.itemDescriptionDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'itemCodeDetailXrLabel
        '
        Me.itemCodeDetailXrLabel.CanGrow = False
        Me.itemCodeDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.itemCodeDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(450.0!, 0.0!)
        Me.itemCodeDetailXrLabel.Name = "itemCodeDetailXrLabel"
        Me.itemCodeDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.itemCodeDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemCodeDetailXrLabel.SizeF = New System.Drawing.SizeF(61.0!, 30.0!)
        Me.itemCodeDetailXrLabel.Text = "itemCodeDetailXrLabel"
        Me.itemCodeDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lotDetailXrLabel
        '
        Me.lotDetailXrLabel.CanGrow = False
        Me.lotDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.lotDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(614.0!, 0.0!)
        Me.lotDetailXrLabel.Name = "lotDetailXrLabel"
        Me.lotDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.lotDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lotDetailXrLabel.SizeF = New System.Drawing.SizeF(61.0!, 30.0!)
        Me.lotDetailXrLabel.Text = "lotDetailXrLabel"
        Me.lotDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'customerNameDetailXrLabel
        '
        Me.customerNameDetailXrLabel.CanGrow = False
        Me.customerNameDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.customerNameDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(108.0!, 0.0!)
        Me.customerNameDetailXrLabel.Name = "customerNameDetailXrLabel"
        Me.customerNameDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.customerNameDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.customerNameDetailXrLabel.SizeF = New System.Drawing.SizeF(84.0!, 30.0!)
        Me.customerNameDetailXrLabel.Text = "customerNameDetailXrLabel"
        Me.customerNameDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'shiftDetailXrLabel
        '
        Me.shiftDetailXrLabel.CanGrow = False
        Me.shiftDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.shiftDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(56.0!, 0.0!)
        Me.shiftDetailXrLabel.Name = "shiftDetailXrLabel"
        Me.shiftDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.shiftDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.shiftDetailXrLabel.SizeF = New System.Drawing.SizeF(52.0!, 30.0!)
        Me.shiftDetailXrLabel.Text = "shiftDetailXrLabel"
        Me.shiftDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'dateDetailXrLabel
        '
        Me.dateDetailXrLabel.CanGrow = False
        Me.dateDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.dateDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.dateDetailXrLabel.Name = "dateDetailXrLabel"
        Me.dateDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.dateDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.dateDetailXrLabel.SizeF = New System.Drawing.SizeF(56.0!, 30.0!)
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
        Me.headerXrPanel.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.expirationDateHeaderXrLabel, Me.sealHeaderXrLabel, Me.trailerHeaderXrLabel, Me.carrierHeaderXrLabel, Me.poHeaderXrLabel, Me.quantityHeaderXrLabel, Me.vendorHeaderXrLabel, Me.destinationHeaderXrLabel, Me.deliveryNoteNumberHeaderXrLabel, Me.bolHeaderXrLabel, Me.itemDescriptionHeaderXrLabel, Me.itemCodeHeaderXrLabel, Me.lotHeadeerXrLabel, Me.customerNameHeaderXrLabel, Me.shiftHeaderXrLabel, Me.dateHeaderXrLabel})
        Me.headerXrPanel.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.headerXrPanel.Name = "headerXrPanel"
        Me.headerXrPanel.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.headerXrPanel.SizeF = New System.Drawing.SizeF(1050.0!, 50.0!)
        '
        'sealHeaderXrLabel
        '
        Me.sealHeaderXrLabel.CanGrow = False
        Me.sealHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.sealHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(997.0!, 0.0!)
        Me.sealHeaderXrLabel.Name = "sealHeaderXrLabel"
        Me.sealHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.sealHeaderXrLabel.SizeF = New System.Drawing.SizeF(53.0!, 50.0!)
        Me.sealHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.sealHeaderXrLabel.StylePriority.UseFont = False
        Me.sealHeaderXrLabel.Text = "Seal #"
        Me.sealHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'trailerHeaderXrLabel
        '
        Me.trailerHeaderXrLabel.CanGrow = False
        Me.trailerHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.trailerHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(934.0!, 0.0!)
        Me.trailerHeaderXrLabel.Name = "trailerHeaderXrLabel"
        Me.trailerHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.trailerHeaderXrLabel.SizeF = New System.Drawing.SizeF(63.0!, 50.0!)
        Me.trailerHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.trailerHeaderXrLabel.StylePriority.UseFont = False
        Me.trailerHeaderXrLabel.Text = "Trailer #"
        Me.trailerHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'carrierHeaderXrLabel
        '
        Me.carrierHeaderXrLabel.CanGrow = False
        Me.carrierHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.carrierHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(866.0!, 0.0!)
        Me.carrierHeaderXrLabel.Name = "carrierHeaderXrLabel"
        Me.carrierHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.carrierHeaderXrLabel.SizeF = New System.Drawing.SizeF(68.0!, 50.0!)
        Me.carrierHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.carrierHeaderXrLabel.StylePriority.UseFont = False
        Me.carrierHeaderXrLabel.Text = "Carrier"
        Me.carrierHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'poHeaderXrLabel
        '
        Me.poHeaderXrLabel.CanGrow = False
        Me.poHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.poHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(248.0!, 0.0!)
        Me.poHeaderXrLabel.Name = "poHeaderXrLabel"
        Me.poHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.poHeaderXrLabel.SizeF = New System.Drawing.SizeF(51.0!, 50.0!)
        Me.poHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.poHeaderXrLabel.StylePriority.UseFont = False
        Me.poHeaderXrLabel.Text = "PO #"
        Me.poHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'quantityHeaderXrLabel
        '
        Me.quantityHeaderXrLabel.CanGrow = False
        Me.quantityHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.quantityHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(735.0!, 0.0!)
        Me.quantityHeaderXrLabel.Name = "quantityHeaderXrLabel"
        Me.quantityHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.quantityHeaderXrLabel.SizeF = New System.Drawing.SizeF(58.0!, 50.0!)
        Me.quantityHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.quantityHeaderXrLabel.StylePriority.UseFont = False
        Me.quantityHeaderXrLabel.Text = "Qty"
        Me.quantityHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'vendorHeaderXrLabel
        '
        Me.vendorHeaderXrLabel.CanGrow = False
        Me.vendorHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.vendorHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(793.0!, 0.0!)
        Me.vendorHeaderXrLabel.Name = "vendorHeaderXrLabel"
        Me.vendorHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vendorHeaderXrLabel.SizeF = New System.Drawing.SizeF(73.0!, 50.0!)
        Me.vendorHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.vendorHeaderXrLabel.StylePriority.UseFont = False
        Me.vendorHeaderXrLabel.Text = "Vendor"
        Me.vendorHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'destinationHeaderXrLabel
        '
        Me.destinationHeaderXrLabel.CanGrow = False
        Me.destinationHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.destinationHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(352.0!, 0.0!)
        Me.destinationHeaderXrLabel.Name = "destinationHeaderXrLabel"
        Me.destinationHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.destinationHeaderXrLabel.SizeF = New System.Drawing.SizeF(98.0!, 50.0!)
        Me.destinationHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.destinationHeaderXrLabel.StylePriority.UseFont = False
        Me.destinationHeaderXrLabel.Text = "Destination"
        Me.destinationHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'deliveryNoteNumberHeaderXrLabel
        '
        Me.deliveryNoteNumberHeaderXrLabel.CanGrow = False
        Me.deliveryNoteNumberHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.deliveryNoteNumberHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(299.0!, 0.0!)
        Me.deliveryNoteNumberHeaderXrLabel.Name = "deliveryNoteNumberHeaderXrLabel"
        Me.deliveryNoteNumberHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.deliveryNoteNumberHeaderXrLabel.SizeF = New System.Drawing.SizeF(53.0!, 50.0!)
        Me.deliveryNoteNumberHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.deliveryNoteNumberHeaderXrLabel.StylePriority.UseFont = False
        Me.deliveryNoteNumberHeaderXrLabel.Text = "DN #"
        Me.deliveryNoteNumberHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'bolHeaderXrLabel
        '
        Me.bolHeaderXrLabel.CanGrow = False
        Me.bolHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.bolHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(192.0!, 0.0!)
        Me.bolHeaderXrLabel.Name = "bolHeaderXrLabel"
        Me.bolHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.bolHeaderXrLabel.SizeF = New System.Drawing.SizeF(56.0!, 50.0!)
        Me.bolHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.bolHeaderXrLabel.StylePriority.UseFont = False
        Me.bolHeaderXrLabel.Text = "BOL #"
        Me.bolHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'itemDescriptionHeaderXrLabel
        '
        Me.itemDescriptionHeaderXrLabel.CanGrow = False
        Me.itemDescriptionHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.itemDescriptionHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(511.0!, 0.0!)
        Me.itemDescriptionHeaderXrLabel.Name = "itemDescriptionHeaderXrLabel"
        Me.itemDescriptionHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemDescriptionHeaderXrLabel.SizeF = New System.Drawing.SizeF(103.0!, 50.0!)
        Me.itemDescriptionHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.itemDescriptionHeaderXrLabel.StylePriority.UseFont = False
        Me.itemDescriptionHeaderXrLabel.Text = "Item Description"
        Me.itemDescriptionHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'itemCodeHeaderXrLabel
        '
        Me.itemCodeHeaderXrLabel.CanGrow = False
        Me.itemCodeHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.itemCodeHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(450.0!, 0.0!)
        Me.itemCodeHeaderXrLabel.Name = "itemCodeHeaderXrLabel"
        Me.itemCodeHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemCodeHeaderXrLabel.SizeF = New System.Drawing.SizeF(61.0!, 50.0!)
        Me.itemCodeHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.itemCodeHeaderXrLabel.StylePriority.UseFont = False
        Me.itemCodeHeaderXrLabel.Text = "Item #"
        Me.itemCodeHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'lotHeadeerXrLabel
        '
        Me.lotHeadeerXrLabel.CanGrow = False
        Me.lotHeadeerXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.lotHeadeerXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(614.0!, 0.0!)
        Me.lotHeadeerXrLabel.Name = "lotHeadeerXrLabel"
        Me.lotHeadeerXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lotHeadeerXrLabel.SizeF = New System.Drawing.SizeF(61.0!, 50.0!)
        Me.lotHeadeerXrLabel.StyleName = "headerXrControlStyle"
        Me.lotHeadeerXrLabel.StylePriority.UseFont = False
        Me.lotHeadeerXrLabel.Text = "Lot"
        Me.lotHeadeerXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'customerNameHeaderXrLabel
        '
        Me.customerNameHeaderXrLabel.CanGrow = False
        Me.customerNameHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.customerNameHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(108.0!, 0.0!)
        Me.customerNameHeaderXrLabel.Name = "customerNameHeaderXrLabel"
        Me.customerNameHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.customerNameHeaderXrLabel.SizeF = New System.Drawing.SizeF(84.0!, 50.0!)
        Me.customerNameHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.customerNameHeaderXrLabel.StylePriority.UseFont = False
        Me.customerNameHeaderXrLabel.Text = "Customer"
        Me.customerNameHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'shiftHeaderXrLabel
        '
        Me.shiftHeaderXrLabel.CanGrow = False
        Me.shiftHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.shiftHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(56.0!, 0.0!)
        Me.shiftHeaderXrLabel.Name = "shiftHeaderXrLabel"
        Me.shiftHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.shiftHeaderXrLabel.SizeF = New System.Drawing.SizeF(52.0!, 50.0!)
        Me.shiftHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.shiftHeaderXrLabel.StylePriority.UseFont = False
        Me.shiftHeaderXrLabel.Text = "Shift"
        Me.shiftHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'dateHeaderXrLabel
        '
        Me.dateHeaderXrLabel.CanGrow = False
        Me.dateHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.dateHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.dateHeaderXrLabel.Name = "dateHeaderXrLabel"
        Me.dateHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.dateHeaderXrLabel.SizeF = New System.Drawing.SizeF(56.0!, 50.0!)
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
        Me.pageNumberXrPageInfo.LocationFloat = New DevExpress.Utils.PointFloat(950.0!, 0.0!)
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
        Me.ReportHeader.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.ReportHeader.HeightF = 86.0!
        Me.ReportHeader.KeepTogether = True
        Me.ReportHeader.Name = "ReportHeader"
        Me.ReportHeader.StylePriority.UseFont = False
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
        Me.footerXrPanel.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.quantityFooterXrLabel})
        Me.footerXrPanel.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.footerXrPanel.Name = "footerXrPanel"
        Me.footerXrPanel.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.footerXrPanel.SizeF = New System.Drawing.SizeF(1050.0!, 30.0!)
        '
        'quantityFooterXrLabel
        '
        Me.quantityFooterXrLabel.CanGrow = False
        Me.quantityFooterXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(735.0!, 0.0!)
        Me.quantityFooterXrLabel.Name = "quantityFooterXrLabel"
        Me.quantityFooterXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.quantityFooterXrLabel.SizeF = New System.Drawing.SizeF(58.0!, 30.0!)
        Me.quantityFooterXrLabel.StyleName = "footerXrControlStyle"
        XrSummary1.FormatString = "{0:#,#}"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.quantityFooterXrLabel.Summary = XrSummary1
        Me.quantityFooterXrLabel.Text = "quantityFooterXrLabel"
        Me.quantityFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
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
        'expirationDateHeaderXrLabel
        '
        Me.expirationDateHeaderXrLabel.CanGrow = False
        Me.expirationDateHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.expirationDateHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(675.0!, 0.0!)
        Me.expirationDateHeaderXrLabel.Name = "expirationDateHeaderXrLabel"
        Me.expirationDateHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.expirationDateHeaderXrLabel.SizeF = New System.Drawing.SizeF(60.0!, 50.0!)
        Me.expirationDateHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.expirationDateHeaderXrLabel.StylePriority.UseFont = False
        Me.expirationDateHeaderXrLabel.Text = "Expiration Date"
        Me.expirationDateHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'expirationDateDetailXrLabel
        '
        Me.expirationDateDetailXrLabel.CanGrow = False
        Me.expirationDateDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.expirationDateDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(675.0!, 0.0!)
        Me.expirationDateDetailXrLabel.Name = "expirationDateDetailXrLabel"
        Me.expirationDateDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.expirationDateDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.expirationDateDetailXrLabel.SizeF = New System.Drawing.SizeF(60.0!, 30.0!)
        Me.expirationDateDetailXrLabel.Text = "dateDetailXrLabel"
        Me.expirationDateDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'TransportationXtraReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.ReportHeader, Me.ReportFooter, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.Landscape = True
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 50, 50)
        Me.PageHeight = 850
        Me.PageWidth = 1100
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.headerXrControlStyle, Me.footerXrControlStyle, Me.detailOddXrControlStyle, Me.detailEvenXrControlStyle})
        Me.Version = "11.2"
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
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents printDateXrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents reportCriteriaXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents reportTitleXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents headerXrPanel As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents sealHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents trailerHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents carrierHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents poHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents quantityHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vendorHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents destinationHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents deliveryNoteNumberHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents bolHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemDescriptionHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemCodeHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lotHeadeerXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents customerNameHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents shiftHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents dateHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents carrierDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents trailerDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents sealDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents poDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents quantityDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vendorDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents destinationDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents deliveryNoteNumberDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents bolDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemDescriptionDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemCodeDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lotDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents customerNameDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents shiftDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents dateDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents footerXrPanel As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents quantityFooterXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pageNumberXrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents expirationDateDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents expirationDateHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
End Class
