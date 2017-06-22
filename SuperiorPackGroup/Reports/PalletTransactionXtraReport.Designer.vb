<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class PalletTransactionXtraReport
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
        Me.components = New System.ComponentModel.Container
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.printDateXrPageInfo = New DevExpress.XtraReports.UI.XRPageInfo
        Me.reportCriteriaXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.reportTitleXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.headerXrPanel = New DevExpress.XtraReports.UI.XRPanel
        Me.recieveHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.destinationHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.vendorHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.customerHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.shippedHeadeerXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.transactionDateHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.headerXrControlStyle = New DevExpress.XtraReports.UI.XRControlStyle
        Me.footerXrControlStyle = New DevExpress.XtraReports.UI.XRControlStyle
        Me.detailOddXrControlStyle = New DevExpress.XtraReports.UI.XRControlStyle
        Me.detailEvenXrControlStyle = New DevExpress.XtraReports.UI.XRControlStyle
        Me.bolXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.vendorDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.destinationDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.bolDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.receivedDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.shippedDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
        Me.totalsXRLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.receivedTotalXRLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.shippedTotalXrLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.totalOverShippedXRLabel = New DevExpress.XtraReports.UI.XRLabel
        Me.xRLOverShippedTotal = New DevExpress.XtraReports.UI.XRLabel
        Me.pageNumberXrPageInfo = New DevExpress.XtraReports.UI.XRPageInfo
        Me.palletTransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.palletTransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrLabel2, Me.vendorDetailXrLabel, Me.destinationDetailXrLabel, Me.bolDetailXrLabel, Me.receivedDetailXrLabel, Me.shippedDetailXrLabel})
        Me.Detail.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Detail.Height = 25
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("TransactionDate", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending), New DevExpress.XtraReports.UI.GroupField("CustomerName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.Detail.StylePriority.UseFont = False
        Me.Detail.StylePriority.UseTextAlignment = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
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
        Me.ReportHeader.Height = 93
        Me.ReportHeader.Name = "ReportHeader"
        '
        'printDateXrPageInfo
        '
        Me.printDateXrPageInfo.Location = New System.Drawing.Point(617, 58)
        Me.printDateXrPageInfo.Name = "printDateXrPageInfo"
        Me.printDateXrPageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.printDateXrPageInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
        Me.printDateXrPageInfo.Size = New System.Drawing.Size(183, 35)
        Me.printDateXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'reportCriteriaXrLabel
        '
        Me.reportCriteriaXrLabel.Location = New System.Drawing.Point(0, 58)
        Me.reportCriteriaXrLabel.Name = "reportCriteriaXrLabel"
        Me.reportCriteriaXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.reportCriteriaXrLabel.Size = New System.Drawing.Size(583, 35)
        Me.reportCriteriaXrLabel.Text = "reportCriteriaXrLabel"
        Me.reportCriteriaXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'reportTitleXrLabel
        '
        Me.reportTitleXrLabel.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.reportTitleXrLabel.Location = New System.Drawing.Point(0, 8)
        Me.reportTitleXrLabel.Name = "reportTitleXrLabel"
        Me.reportTitleXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.reportTitleXrLabel.Size = New System.Drawing.Size(800, 50)
        Me.reportTitleXrLabel.Text = "reportTitleXrLabel"
        Me.reportTitleXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'headerXrPanel
        '
        Me.headerXrPanel.BorderColor = System.Drawing.Color.Black
        Me.headerXrPanel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.headerXrPanel.BorderWidth = 3
        Me.headerXrPanel.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.recieveHeaderXrLabel, Me.destinationHeaderXrLabel, Me.vendorHeaderXrLabel, Me.customerHeaderXrLabel, Me.shippedHeadeerXrLabel, Me.transactionDateHeaderXrLabel, Me.bolXrLabel})
        Me.headerXrPanel.Location = New System.Drawing.Point(0, 0)
        Me.headerXrPanel.Name = "headerXrPanel"
        Me.headerXrPanel.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.headerXrPanel.Size = New System.Drawing.Size(800, 50)
        '
        'recieveHeaderXrLabel
        '
        Me.recieveHeaderXrLabel.CanGrow = False
        Me.recieveHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.recieveHeaderXrLabel.Location = New System.Drawing.Point(600, 0)
        Me.recieveHeaderXrLabel.Name = "recieveHeaderXrLabel"
        Me.recieveHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.recieveHeaderXrLabel.Size = New System.Drawing.Size(100, 50)
        Me.recieveHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.recieveHeaderXrLabel.StylePriority.UseFont = False
        Me.recieveHeaderXrLabel.Text = "Received (In)"
        Me.recieveHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'destinationHeaderXrLabel
        '
        Me.destinationHeaderXrLabel.CanGrow = False
        Me.destinationHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.destinationHeaderXrLabel.Location = New System.Drawing.Point(360, 0)
        Me.destinationHeaderXrLabel.Name = "destinationHeaderXrLabel"
        Me.destinationHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.destinationHeaderXrLabel.Size = New System.Drawing.Size(120, 50)
        Me.destinationHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.destinationHeaderXrLabel.StylePriority.UseFont = False
        Me.destinationHeaderXrLabel.Text = "Destination"
        Me.destinationHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'vendorHeaderXrLabel
        '
        Me.vendorHeaderXrLabel.CanGrow = False
        Me.vendorHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.vendorHeaderXrLabel.Location = New System.Drawing.Point(240, 0)
        Me.vendorHeaderXrLabel.Name = "vendorHeaderXrLabel"
        Me.vendorHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vendorHeaderXrLabel.Size = New System.Drawing.Size(120, 50)
        Me.vendorHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.vendorHeaderXrLabel.StylePriority.UseFont = False
        Me.vendorHeaderXrLabel.Text = "Vendor"
        Me.vendorHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'customerHeaderXrLabel
        '
        Me.customerHeaderXrLabel.CanGrow = False
        Me.customerHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.customerHeaderXrLabel.Location = New System.Drawing.Point(120, 0)
        Me.customerHeaderXrLabel.Name = "customerHeaderXrLabel"
        Me.customerHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.customerHeaderXrLabel.Size = New System.Drawing.Size(120, 50)
        Me.customerHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.customerHeaderXrLabel.StylePriority.UseFont = False
        Me.customerHeaderXrLabel.Text = "Customer"
        Me.customerHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'shippedHeadeerXrLabel
        '
        Me.shippedHeadeerXrLabel.CanGrow = False
        Me.shippedHeadeerXrLabel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.shippedHeadeerXrLabel.Location = New System.Drawing.Point(700, 0)
        Me.shippedHeadeerXrLabel.Name = "shippedHeadeerXrLabel"
        Me.shippedHeadeerXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.shippedHeadeerXrLabel.Size = New System.Drawing.Size(100, 50)
        Me.shippedHeadeerXrLabel.StyleName = "headerXrControlStyle"
        Me.shippedHeadeerXrLabel.StylePriority.UseFont = False
        Me.shippedHeadeerXrLabel.Text = "Shipped (Out)"
        Me.shippedHeadeerXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'transactionDateHeaderXrLabel
        '
        Me.transactionDateHeaderXrLabel.CanGrow = False
        Me.transactionDateHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.transactionDateHeaderXrLabel.Location = New System.Drawing.Point(0, 0)
        Me.transactionDateHeaderXrLabel.Name = "transactionDateHeaderXrLabel"
        Me.transactionDateHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.transactionDateHeaderXrLabel.Size = New System.Drawing.Size(120, 50)
        Me.transactionDateHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.transactionDateHeaderXrLabel.StylePriority.UseFont = False
        Me.transactionDateHeaderXrLabel.Text = "Transaction Date"
        Me.transactionDateHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
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
        'bolXrLabel
        '
        Me.bolXrLabel.CanGrow = False
        Me.bolXrLabel.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.bolXrLabel.Location = New System.Drawing.Point(480, 0)
        Me.bolXrLabel.Name = "bolXrLabel"
        Me.bolXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.bolXrLabel.Size = New System.Drawing.Size(120, 50)
        Me.bolXrLabel.StyleName = "headerXrControlStyle"
        Me.bolXrLabel.StylePriority.UseFont = False
        Me.bolXrLabel.Text = "BOL #"
        Me.bolXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel1.CanGrow = False
        Me.XrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TransactionDate", "{0:MMM/dd/yyyy}")})
        Me.XrLabel1.Location = New System.Drawing.Point(0, 0)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.Size = New System.Drawing.Size(120, 25)
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.Text = "XrLabel1"
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel2.CanGrow = False
        Me.XrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CustomerName", "")})
        Me.XrLabel2.Location = New System.Drawing.Point(120, 0)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.Size = New System.Drawing.Size(120, 25)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.Text = "XrLabel2"
        '
        'vendorDetailXrLabel
        '
        Me.vendorDetailXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.vendorDetailXrLabel.CanGrow = False
        Me.vendorDetailXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "VendorName", "")})
        Me.vendorDetailXrLabel.Location = New System.Drawing.Point(240, 0)
        Me.vendorDetailXrLabel.Name = "vendorDetailXrLabel"
        Me.vendorDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.vendorDetailXrLabel.Size = New System.Drawing.Size(120, 25)
        Me.vendorDetailXrLabel.StylePriority.UseBorders = False
        Me.vendorDetailXrLabel.Text = "vendorDetailXrLabel"
        '
        'destinationDetailXrLabel
        '
        Me.destinationDetailXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.destinationDetailXrLabel.CanGrow = False
        Me.destinationDetailXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "ShippingDestinationName", "")})
        Me.destinationDetailXrLabel.Location = New System.Drawing.Point(360, 0)
        Me.destinationDetailXrLabel.Name = "destinationDetailXrLabel"
        Me.destinationDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.destinationDetailXrLabel.Size = New System.Drawing.Size(120, 25)
        Me.destinationDetailXrLabel.StylePriority.UseBorders = False
        Me.destinationDetailXrLabel.Text = "destinationDetailXrLabel"
        '
        'bolDetailXrLabel
        '
        Me.bolDetailXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.bolDetailXrLabel.CanGrow = False
        Me.bolDetailXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TransactionBOL", "")})
        Me.bolDetailXrLabel.Location = New System.Drawing.Point(480, 0)
        Me.bolDetailXrLabel.Name = "bolDetailXrLabel"
        Me.bolDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.bolDetailXrLabel.Size = New System.Drawing.Size(120, 25)
        Me.bolDetailXrLabel.StylePriority.UseBorders = False
        Me.bolDetailXrLabel.Text = "bolDetailXrLabel"
        '
        'receivedDetailXrLabel
        '
        Me.receivedDetailXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.receivedDetailXrLabel.CanGrow = False
        Me.receivedDetailXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Received", "")})
        Me.receivedDetailXrLabel.Location = New System.Drawing.Point(600, 0)
        Me.receivedDetailXrLabel.Name = "receivedDetailXrLabel"
        Me.receivedDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.receivedDetailXrLabel.Size = New System.Drawing.Size(100, 25)
        Me.receivedDetailXrLabel.StylePriority.UseBorders = False
        Me.receivedDetailXrLabel.Text = "receivedDetailXrLabel"
        '
        'shippedDetailXrLabel
        '
        Me.shippedDetailXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.shippedDetailXrLabel.CanGrow = False
        Me.shippedDetailXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Shipped", "")})
        Me.shippedDetailXrLabel.Location = New System.Drawing.Point(700, 0)
        Me.shippedDetailXrLabel.Name = "shippedDetailXrLabel"
        Me.shippedDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.shippedDetailXrLabel.Size = New System.Drawing.Size(100, 25)
        Me.shippedDetailXrLabel.StylePriority.UseBorders = False
        Me.shippedDetailXrLabel.Text = "shippedDetailXrLabel"
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.totalsXRLabel, Me.receivedTotalXRLabel, Me.shippedTotalXrLabel, Me.totalOverShippedXRLabel, Me.xRLOverShippedTotal})
        Me.ReportFooter.Height = 50
        Me.ReportFooter.Name = "ReportFooter"
        '
        'totalsXRLabel
        '
        Me.totalsXRLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.totalsXRLabel.Font = New System.Drawing.Font("Tahoma", 10.75!, System.Drawing.FontStyle.Bold)
        Me.totalsXRLabel.Location = New System.Drawing.Point(0, 0)
        Me.totalsXRLabel.Name = "totalsXRLabel"
        Me.totalsXRLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.totalsXRLabel.Size = New System.Drawing.Size(600, 25)
        Me.totalsXRLabel.StylePriority.UseBorders = False
        Me.totalsXRLabel.StylePriority.UseFont = False
        Me.totalsXRLabel.StylePriority.UseTextAlignment = False
        Me.totalsXRLabel.Text = "Totals"
        Me.totalsXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'receivedTotalXRLabel
        '
        Me.receivedTotalXRLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.receivedTotalXRLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Received", "")})
        Me.receivedTotalXRLabel.Font = New System.Drawing.Font("Tahoma", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.receivedTotalXRLabel.Location = New System.Drawing.Point(600, 0)
        Me.receivedTotalXRLabel.Name = "receivedTotalXRLabel"
        Me.receivedTotalXRLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.receivedTotalXRLabel.Size = New System.Drawing.Size(100, 25)
        Me.receivedTotalXRLabel.StylePriority.UseBorders = False
        Me.receivedTotalXRLabel.StylePriority.UseFont = False
        XrSummary1.IgnoreNullValues = True
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.receivedTotalXRLabel.Summary = XrSummary1
        Me.receivedTotalXRLabel.Text = "receivedTotalXRLabel"
        '
        'shippedTotalXrLabel
        '
        Me.shippedTotalXrLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.shippedTotalXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Shipped", "")})
        Me.shippedTotalXrLabel.Font = New System.Drawing.Font("Tahoma", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shippedTotalXrLabel.Location = New System.Drawing.Point(700, 0)
        Me.shippedTotalXrLabel.Name = "shippedTotalXrLabel"
        Me.shippedTotalXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.shippedTotalXrLabel.Size = New System.Drawing.Size(100, 25)
        Me.shippedTotalXrLabel.StylePriority.UseBorders = False
        Me.shippedTotalXrLabel.StylePriority.UseFont = False
        XrSummary2.IgnoreNullValues = True
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.shippedTotalXrLabel.Summary = XrSummary2
        Me.shippedTotalXrLabel.Text = "shippedTotalXrLabel"
        '
        'totalOverShippedXRLabel
        '
        Me.totalOverShippedXRLabel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.totalOverShippedXRLabel.Font = New System.Drawing.Font("Tahoma", 10.75!, System.Drawing.FontStyle.Bold)
        Me.totalOverShippedXRLabel.Location = New System.Drawing.Point(0, 25)
        Me.totalOverShippedXRLabel.Name = "totalOverShippedXRLabel"
        Me.totalOverShippedXRLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.totalOverShippedXRLabel.Size = New System.Drawing.Size(600, 25)
        Me.totalOverShippedXRLabel.StylePriority.UseBorders = False
        Me.totalOverShippedXRLabel.StylePriority.UseFont = False
        Me.totalOverShippedXRLabel.StylePriority.UseTextAlignment = False
        Me.totalOverShippedXRLabel.Text = "Total Over Shipped"
        Me.totalOverShippedXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'xRLOverShippedTotal
        '
        Me.xRLOverShippedTotal.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.xRLOverShippedTotal.Font = New System.Drawing.Font("Tahoma", 10.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xRLOverShippedTotal.Location = New System.Drawing.Point(600, 25)
        Me.xRLOverShippedTotal.Name = "xRLOverShippedTotal"
        Me.xRLOverShippedTotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xRLOverShippedTotal.Size = New System.Drawing.Size(200, 25)
        Me.xRLOverShippedTotal.StylePriority.UseBorders = False
        Me.xRLOverShippedTotal.StylePriority.UseFont = False
        Me.xRLOverShippedTotal.StylePriority.UseTextAlignment = False
        Me.xRLOverShippedTotal.Text = "xRLOverShippedTotal"
        Me.xRLOverShippedTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'pageNumberXrPageInfo
        '
        Me.pageNumberXrPageInfo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic)
        Me.pageNumberXrPageInfo.Format = "Page:  {0} / {1}"
        Me.pageNumberXrPageInfo.Location = New System.Drawing.Point(692, 0)
        Me.pageNumberXrPageInfo.Name = "pageNumberXrPageInfo"
        Me.pageNumberXrPageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.pageNumberXrPageInfo.Size = New System.Drawing.Size(100, 25)
        Me.pageNumberXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'palletTransactionsBindingSource
        '
        Me.palletTransactionsBindingSource.DataSource = GetType(PalletTransactionList)
        '
        'PalletTransactionXtraReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.ReportHeader, Me.ReportFooter})
        Me.DataSource = Me.palletTransactionsBindingSource
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 50, 50)
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.headerXrControlStyle, Me.footerXrControlStyle, Me.detailOddXrControlStyle, Me.detailEvenXrControlStyle})
        Me.Version = "9.2"
        CType(Me.palletTransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents printDateXrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents reportCriteriaXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents reportTitleXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents palletTransactionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents headerXrPanel As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents recieveHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents destinationHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vendorHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents customerHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents shippedHeadeerXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents transactionDateHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents headerXrControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents footerXrControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents detailOddXrControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents detailEvenXrControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents bolXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents vendorDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents destinationDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents bolDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents receivedDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents shippedDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents totalsXRLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents receivedTotalXRLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents shippedTotalXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents totalOverShippedXRLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents xRLOverShippedTotal As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents pageNumberXrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
End Class
