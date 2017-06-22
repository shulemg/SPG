<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ItemTransactionXtraReport
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
        Me.components = New System.ComponentModel.Container()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary4 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary5 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary6 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary7 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary8 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary9 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary10 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary11 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary12 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary13 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary14 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary15 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary16 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.balacneDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.quantityDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.transactionTypeDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.itemDescriptionDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.itemCodeDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.transactionDateDetailXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.printDateXrPageInfo = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.reportCriteriaXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.reportTitleXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
        Me.pageNumberXrPageInfo = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.itemGroupHeader = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.openingBalanceXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.openingBalanceParameter = New DevExpress.XtraReports.Parameters.Parameter()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.headerXrPanel = New DevExpress.XtraReports.UI.XRPanel()
        Me.quantityHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.tranasctionTypeHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.itemDescriptionHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.itemCodeHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.balanceHeadeerXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.transactionDateHeaderXrLabel = New DevExpress.XtraReports.UI.XRLabel()
        Me.headerXrControlStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.footerXrControlStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.detailOddXrControlStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.detailEvenXrControlStyle = New DevExpress.XtraReports.UI.XRControlStyle()
        Me.TopMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.itemTransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.itemTransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.balacneDetailXrLabel, Me.quantityDetailXrLabel, Me.transactionTypeDetailXrLabel, Me.itemDescriptionDetailXrLabel, Me.itemCodeDetailXrLabel, Me.transactionDateDetailXrLabel})
        Me.Detail.EvenStyleName = "detailOddXrControlStyle"
        Me.Detail.HeightF = 30.0!
        Me.Detail.Name = "Detail"
        Me.Detail.OddStyleName = "detailEvenXrControlStyle"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.None
        Me.Detail.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("TransactionDate", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'balacneDetailXrLabel
        '
        Me.balacneDetailXrLabel.CanGrow = False
        Me.balacneDetailXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Quantity")})
        Me.balacneDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.balacneDetailXrLabel.Font = New System.Drawing.Font("Tahoma", 8.75!)
        Me.balacneDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(692.0!, 0.0!)
        Me.balacneDetailXrLabel.Name = "balacneDetailXrLabel"
        Me.balacneDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.balacneDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.balacneDetailXrLabel.SizeF = New System.Drawing.SizeF(106.0!, 30.0!)
        Me.balacneDetailXrLabel.StylePriority.UseFont = False
        XrSummary1.FormatString = "{0:#.00}"
        XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RunningSum
        XrSummary1.IgnoreNullValues = True
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
        Me.balacneDetailXrLabel.Summary = XrSummary1
        Me.balacneDetailXrLabel.Text = "balacneDetailXrLabel"
        Me.balacneDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'quantityDetailXrLabel
        '
        Me.quantityDetailXrLabel.CanGrow = False
        Me.quantityDetailXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Quantity")})
        Me.quantityDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.quantityDetailXrLabel.Font = New System.Drawing.Font("Tahoma", 8.75!)
        Me.quantityDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(591.0!, 0.0!)
        Me.quantityDetailXrLabel.Name = "quantityDetailXrLabel"
        Me.quantityDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.quantityDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.quantityDetailXrLabel.SizeF = New System.Drawing.SizeF(101.0!, 30.0!)
        Me.quantityDetailXrLabel.StylePriority.UseFont = False
        XrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.None
        Me.quantityDetailXrLabel.Summary = XrSummary2
        Me.quantityDetailXrLabel.Text = "quantityDetailXrLabel"
        Me.quantityDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'transactionTypeDetailXrLabel
        '
        Me.transactionTypeDetailXrLabel.CanGrow = False
        Me.transactionTypeDetailXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TransactionType")})
        Me.transactionTypeDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.transactionTypeDetailXrLabel.Font = New System.Drawing.Font("Tahoma", 8.75!)
        Me.transactionTypeDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(483.0!, 0.0!)
        Me.transactionTypeDetailXrLabel.Name = "transactionTypeDetailXrLabel"
        Me.transactionTypeDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.transactionTypeDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.transactionTypeDetailXrLabel.SizeF = New System.Drawing.SizeF(108.0!, 30.0!)
        Me.transactionTypeDetailXrLabel.StylePriority.UseFont = False
        Me.transactionTypeDetailXrLabel.StylePriority.UseTextAlignment = False
        XrSummary3.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.None
        Me.transactionTypeDetailXrLabel.Summary = XrSummary3
        Me.transactionTypeDetailXrLabel.Text = "transactionTypeDetailXrLabel"
        Me.transactionTypeDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'itemDescriptionDetailXrLabel
        '
        Me.itemDescriptionDetailXrLabel.CanGrow = False
        Me.itemDescriptionDetailXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TransactionItemDescription")})
        Me.itemDescriptionDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.itemDescriptionDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(275.0!, 0.0!)
        Me.itemDescriptionDetailXrLabel.Name = "itemDescriptionDetailXrLabel"
        Me.itemDescriptionDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.itemDescriptionDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemDescriptionDetailXrLabel.SizeF = New System.Drawing.SizeF(208.0!, 30.0!)
        XrSummary4.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum
        XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.None
        Me.itemDescriptionDetailXrLabel.Summary = XrSummary4
        Me.itemDescriptionDetailXrLabel.Text = "itemDescriptionDetailXrLabel"
        Me.itemDescriptionDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'itemCodeDetailXrLabel
        '
        Me.itemCodeDetailXrLabel.CanGrow = False
        Me.itemCodeDetailXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TransactionItemCode")})
        Me.itemCodeDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.itemCodeDetailXrLabel.Font = New System.Drawing.Font("Tahoma", 8.75!)
        Me.itemCodeDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(125.0!, 0.0!)
        Me.itemCodeDetailXrLabel.Name = "itemCodeDetailXrLabel"
        Me.itemCodeDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.itemCodeDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemCodeDetailXrLabel.SizeF = New System.Drawing.SizeF(150.0!, 30.0!)
        Me.itemCodeDetailXrLabel.StylePriority.UseFont = False
        XrSummary5.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum
        XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.None
        Me.itemCodeDetailXrLabel.Summary = XrSummary5
        Me.itemCodeDetailXrLabel.Text = "itemCodeDetailXrLabel"
        Me.itemCodeDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'transactionDateDetailXrLabel
        '
        Me.transactionDateDetailXrLabel.CanGrow = False
        Me.transactionDateDetailXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "TransactionDate", "{0:MM/dd/yyyy}")})
        Me.transactionDateDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.transactionDateDetailXrLabel.Font = New System.Drawing.Font("Tahoma", 8.75!)
        Me.transactionDateDetailXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.transactionDateDetailXrLabel.Name = "transactionDateDetailXrLabel"
        Me.transactionDateDetailXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.transactionDateDetailXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.transactionDateDetailXrLabel.SizeF = New System.Drawing.SizeF(125.0!, 30.0!)
        Me.transactionDateDetailXrLabel.StylePriority.UseFont = False
        XrSummary6.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum
        XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.None
        Me.transactionDateDetailXrLabel.Summary = XrSummary6
        Me.transactionDateDetailXrLabel.Text = "transactionDateDetailXrLabel"
        Me.transactionDateDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.printDateXrPageInfo, Me.reportCriteriaXrLabel, Me.reportTitleXrLabel})
        Me.PageHeader.HeightF = 85.0!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageHeader.PageBreak = DevExpress.XtraReports.UI.PageBreak.None
        Me.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
        Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'printDateXrPageInfo
        '
        Me.printDateXrPageInfo.LocationFloat = New DevExpress.Utils.PointFloat(617.0!, 50.0!)
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
        Me.reportCriteriaXrLabel.SizeF = New System.Drawing.SizeF(583.0!, 35.0!)
        XrSummary7.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum
        XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.None
        Me.reportCriteriaXrLabel.Summary = XrSummary7
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
        XrSummary8.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum
        XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.None
        Me.reportTitleXrLabel.Summary = XrSummary8
        Me.reportTitleXrLabel.Text = "reportTitleXrLabel"
        Me.reportTitleXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'PageFooter
        '
        Me.PageFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.pageNumberXrPageInfo})
        Me.PageFooter.HeightF = 30.0!
        Me.PageFooter.Name = "PageFooter"
        Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.PageFooter.PageBreak = DevExpress.XtraReports.UI.PageBreak.None
        Me.PageFooter.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages
        Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'pageNumberXrPageInfo
        '
        Me.pageNumberXrPageInfo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic)
        Me.pageNumberXrPageInfo.Format = "Page:  {0} / {1}"
        Me.pageNumberXrPageInfo.LocationFloat = New DevExpress.Utils.PointFloat(692.0!, 0.0!)
        Me.pageNumberXrPageInfo.Name = "pageNumberXrPageInfo"
        Me.pageNumberXrPageInfo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.pageNumberXrPageInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.NumberOfTotal
        Me.pageNumberXrPageInfo.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
        Me.pageNumberXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'itemGroupHeader
        '
        Me.itemGroupHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.openingBalanceXrLabel, Me.XrLabel1, Me.headerXrPanel})
        Me.itemGroupHeader.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.None
        Me.itemGroupHeader.HeightF = 83.0!
        Me.itemGroupHeader.Name = "itemGroupHeader"
        Me.itemGroupHeader.PageBreak = DevExpress.XtraReports.UI.PageBreak.None
        '
        'openingBalanceXrLabel
        '
        Me.openingBalanceXrLabel.CanGrow = False
        Me.openingBalanceXrLabel.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding(Me.openingBalanceParameter, "Text", "{0:#.00}")})
        Me.openingBalanceXrLabel.EvenStyleName = "detailEvenXrControlStyle"
        Me.openingBalanceXrLabel.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.openingBalanceXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(692.0!, 50.0!)
        Me.openingBalanceXrLabel.Name = "openingBalanceXrLabel"
        Me.openingBalanceXrLabel.OddStyleName = "detailOddXrControlStyle"
        Me.openingBalanceXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.openingBalanceXrLabel.SizeF = New System.Drawing.SizeF(106.0!, 30.0!)
        Me.openingBalanceXrLabel.StylePriority.UseFont = False
        XrSummary9.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum
        XrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.None
        Me.openingBalanceXrLabel.Summary = XrSummary9
        Me.openingBalanceXrLabel.Text = "openingBalanceXrLabel"
        Me.openingBalanceXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'openingBalanceParameter
        '
        Me.openingBalanceParameter.Name = "openingBalanceParameter"
        Me.openingBalanceParameter.Type = GetType(Double)
        Me.openingBalanceParameter.Value = 0
        '
        'XrLabel1
        '
        Me.XrLabel1.CanGrow = False
        Me.XrLabel1.EvenStyleName = "detailEvenXrControlStyle"
        Me.XrLabel1.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(275.0!, 50.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.OddStyleName = "detailOddXrControlStyle"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(208.0!, 30.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        XrSummary10.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum
        XrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.None
        Me.XrLabel1.Summary = XrSummary10
        Me.XrLabel1.Text = "Opening Balance"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'headerXrPanel
        '
        Me.headerXrPanel.BorderColor = System.Drawing.Color.Black
        Me.headerXrPanel.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.headerXrPanel.BorderWidth = 3
        Me.headerXrPanel.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.quantityHeaderXrLabel, Me.tranasctionTypeHeaderXrLabel, Me.itemDescriptionHeaderXrLabel, Me.itemCodeHeaderXrLabel, Me.balanceHeadeerXrLabel, Me.transactionDateHeaderXrLabel})
        Me.headerXrPanel.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.headerXrPanel.Name = "headerXrPanel"
        Me.headerXrPanel.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.headerXrPanel.SizeF = New System.Drawing.SizeF(800.0!, 83.0!)
        '
        'quantityHeaderXrLabel
        '
        Me.quantityHeaderXrLabel.CanGrow = False
        Me.quantityHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.quantityHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(591.0!, 0.0!)
        Me.quantityHeaderXrLabel.Name = "quantityHeaderXrLabel"
        Me.quantityHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.quantityHeaderXrLabel.SizeF = New System.Drawing.SizeF(101.0!, 50.0!)
        Me.quantityHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.quantityHeaderXrLabel.StylePriority.UseFont = False
        XrSummary11.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum
        XrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.None
        Me.quantityHeaderXrLabel.Summary = XrSummary11
        Me.quantityHeaderXrLabel.Text = "Quantity"
        Me.quantityHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'tranasctionTypeHeaderXrLabel
        '
        Me.tranasctionTypeHeaderXrLabel.CanGrow = False
        Me.tranasctionTypeHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.tranasctionTypeHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(483.0!, 0.0!)
        Me.tranasctionTypeHeaderXrLabel.Name = "tranasctionTypeHeaderXrLabel"
        Me.tranasctionTypeHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.tranasctionTypeHeaderXrLabel.SizeF = New System.Drawing.SizeF(108.0!, 50.0!)
        Me.tranasctionTypeHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.tranasctionTypeHeaderXrLabel.StylePriority.UseFont = False
        XrSummary12.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum
        XrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.None
        Me.tranasctionTypeHeaderXrLabel.Summary = XrSummary12
        Me.tranasctionTypeHeaderXrLabel.Text = "Transaction Type"
        Me.tranasctionTypeHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'itemDescriptionHeaderXrLabel
        '
        Me.itemDescriptionHeaderXrLabel.CanGrow = False
        Me.itemDescriptionHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.itemDescriptionHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(275.0!, 0.0!)
        Me.itemDescriptionHeaderXrLabel.Name = "itemDescriptionHeaderXrLabel"
        Me.itemDescriptionHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemDescriptionHeaderXrLabel.SizeF = New System.Drawing.SizeF(208.0!, 50.0!)
        Me.itemDescriptionHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.itemDescriptionHeaderXrLabel.StylePriority.UseFont = False
        XrSummary13.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum
        XrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.None
        Me.itemDescriptionHeaderXrLabel.Summary = XrSummary13
        Me.itemDescriptionHeaderXrLabel.Text = "Item Description"
        Me.itemDescriptionHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'itemCodeHeaderXrLabel
        '
        Me.itemCodeHeaderXrLabel.CanGrow = False
        Me.itemCodeHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.itemCodeHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(125.0!, 0.0!)
        Me.itemCodeHeaderXrLabel.Name = "itemCodeHeaderXrLabel"
        Me.itemCodeHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.itemCodeHeaderXrLabel.SizeF = New System.Drawing.SizeF(150.0!, 50.0!)
        Me.itemCodeHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.itemCodeHeaderXrLabel.StylePriority.UseFont = False
        XrSummary14.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum
        XrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.None
        Me.itemCodeHeaderXrLabel.Summary = XrSummary14
        Me.itemCodeHeaderXrLabel.Text = "Item #"
        Me.itemCodeHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'balanceHeadeerXrLabel
        '
        Me.balanceHeadeerXrLabel.CanGrow = False
        Me.balanceHeadeerXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.balanceHeadeerXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(692.0!, 0.0!)
        Me.balanceHeadeerXrLabel.Name = "balanceHeadeerXrLabel"
        Me.balanceHeadeerXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.balanceHeadeerXrLabel.SizeF = New System.Drawing.SizeF(106.0!, 50.0!)
        Me.balanceHeadeerXrLabel.StyleName = "headerXrControlStyle"
        Me.balanceHeadeerXrLabel.StylePriority.UseFont = False
        XrSummary15.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum
        XrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.None
        Me.balanceHeadeerXrLabel.Summary = XrSummary15
        Me.balanceHeadeerXrLabel.Text = "Balance"
        Me.balanceHeadeerXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'transactionDateHeaderXrLabel
        '
        Me.transactionDateHeaderXrLabel.CanGrow = False
        Me.transactionDateHeaderXrLabel.Font = New System.Drawing.Font("Tahoma", 7.5!, System.Drawing.FontStyle.Bold)
        Me.transactionDateHeaderXrLabel.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.transactionDateHeaderXrLabel.Name = "transactionDateHeaderXrLabel"
        Me.transactionDateHeaderXrLabel.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.transactionDateHeaderXrLabel.SizeF = New System.Drawing.SizeF(125.0!, 50.0!)
        Me.transactionDateHeaderXrLabel.StyleName = "headerXrControlStyle"
        Me.transactionDateHeaderXrLabel.StylePriority.UseFont = False
        XrSummary16.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum
        XrSummary16.Running = DevExpress.XtraReports.UI.SummaryRunning.None
        Me.transactionDateHeaderXrLabel.Summary = XrSummary16
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
        'TopMarginBand1
        '
        Me.TopMarginBand1.HeightF = 50.0!
        Me.TopMarginBand1.Name = "TopMarginBand1"
        Me.TopMarginBand1.PageBreak = DevExpress.XtraReports.UI.PageBreak.None
        '
        'BottomMarginBand1
        '
        Me.BottomMarginBand1.HeightF = 50.0!
        Me.BottomMarginBand1.Name = "BottomMarginBand1"
        Me.BottomMarginBand1.PageBreak = DevExpress.XtraReports.UI.PageBreak.None
        '
        'itemTransactionsBindingSource
        '
        Me.itemTransactionsBindingSource.DataSource = GetType(ItemTransactionsList)
        '
        'ItemTransactionXtraReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.itemGroupHeader, Me.TopMarginBand1, Me.BottomMarginBand1})
        Me.DataSource = Me.itemTransactionsBindingSource
        Me.Margins = New System.Drawing.Printing.Margins(25, 25, 50, 50)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.openingBalanceParameter})
        Me.RequestParameters = False
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.headerXrControlStyle, Me.footerXrControlStyle, Me.detailOddXrControlStyle, Me.detailEvenXrControlStyle})
        Me.Version = "10.1"
        CType(Me.itemTransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents printDateXrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents reportCriteriaXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents reportTitleXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemGroupHeader As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents headerXrPanel As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents quantityHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents tranasctionTypeHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemDescriptionHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemCodeHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents balanceHeadeerXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents transactionDateHeaderXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents balacneDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents quantityDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents transactionTypeDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemDescriptionDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemCodeDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents transactionDateDetailXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents openingBalanceXrLabel As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents itemTransactionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents headerXrControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents footerXrControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents detailOddXrControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents detailEvenXrControlStyle As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents openingBalanceParameter As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents pageNumberXrPageInfo As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents TopMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
End Class
