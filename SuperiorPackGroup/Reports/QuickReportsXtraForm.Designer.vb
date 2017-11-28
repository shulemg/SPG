<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class QuickReportsXtraForm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim PivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuickReportsXtraForm))
        Me.fieldMachineName1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.customersMenuBar = New DevExpress.XtraBars.Bar()
        Me.printBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.exportXLSBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.quickReportsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.quickReportsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.reportNameGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.reportCodeNameGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.reportTypeGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.filterReportGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dateFilterGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.customerFilterGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.itemFilterGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lotFilterGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.poFilterGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.machineFilterGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shiftFilterGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.bolFilterGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dnFilterGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.destinationFilterGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.carrierFilterGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.vendorFilterGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.itemTypeFilterGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.outOfStockFilterGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.reportsXtraTabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.filterXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.previewCustoemrsXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.previewGridControl = New DevExpress.XtraGrid.GridControl()
        Me.previewGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.nameGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.contactNameGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.addressGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cityGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.stateGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.postalGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.phoneGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.faxGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.emailGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.inactiveGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.previewProductionEntriesXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.previewProductionEntriesGridControl = New DevExpress.XtraGrid.GridControl()
        Me.previewProductionEntriesGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.productionDateGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.customerNameGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.itemNumberGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.itemDescriptionGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.itemTypeGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shiftGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.quantityGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.poGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lotGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.palletNumberGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lpnNumberGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.expirationDateGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.expirationDateFormatGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.noteGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.previewLpnStatusXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.previewLpnStatusGridControl = New DevExpress.XtraGrid.GridControl()
        Me.previewLpnStatusGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lpnCustomerNameGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.fullLpnGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lpnItemCodeGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lpnItemDescriptionGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lpnQuantityGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lpnProductionDateGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lpnShippingDateGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lpnShippingBolGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.previewCurrentRMInventoryXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.previewCurrentRMInventoryGridControl = New DevExpress.XtraGrid.GridControl()
        Me.previewCurrentRMInventoryGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.rmInventoryCustomerNameGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rmInventoryIemCodeGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rmInventoryItemDescriptionGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rmInventoryLocationGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rmInventoryQtyOnHandGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rmInventoryInactiveGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rmInventoryItemIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.previewCurrentInventoryXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.refreshSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.outOfStockItemsCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.currentInventoryInactiveItemsCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.currentInventoryInactiveCustomersCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.previewCurrentInventoryGridControl = New DevExpress.XtraGrid.GridControl()
        Me.previewCurrentInventoryGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.currentInventoryCustomerNameGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.currentInventoryItemCodeGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.currentInventoryItemDescriptionGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.currentInventoryItemTypeGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.currentInventoryQuantityOnHandGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.currentInventoryInventoryByPalletsGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.currentInventoryUOMGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.currentInventoryLocationGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.previewLocationTransfersXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.previewLocationTransfersGridControl = New DevExpress.XtraGrid.GridControl()
        Me.previewLocationTransfersGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.locationTransfersDateGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.locationTransferFromLocationGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.locationTransferToLocationGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.locationTransferItemCodeGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.locationTransferItemDescriptionGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.locationTransferNumberGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.locationTransferItemLotGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.locationTransferExpirationDateGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.locationTransferQuantityGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.locationTransferExpirationDateFormatGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.locationTransferPalletsGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.locationTransferUnitsGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.locationTransferCarrierGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.previewShiftScheduleXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.shiftScheduleGridControl = New DevExpress.XtraGrid.GridControl()
        Me.shiftScheduleGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.shiftScheduleMachineNameGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shiftSchedulePeopleGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shiftScheduleOperatorGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shiftScheduleItemCodeGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shiftScheduleItemDescriptionGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shiftScheduleQuantityGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shiftScheduleSchedByQtyGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shiftScheduleNoteGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shiftScheduleMustRunGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shiftSchedulePriorityLevelGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.refreshShiftScheduleSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.shiftScheduleShiftComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.shiftScheduleDateDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.previewWeeklyProductionXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.weeklyProductionGridControl = New DevExpress.XtraGrid.GridControl()
        Me.weeklyProductionGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.weeklyProductionProductionWeekGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.weeklyProductionItemCodeGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.weeklyProductionItemDescriptionGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.weeklyProductionCasesRequiredGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.weeklyProductionBagsRequiredGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.weeklyProductionMondayGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.weeklyProductionTuesdayGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.weeklyProductionWednesdayGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.weeklyProductionThursdayGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.weeklyProductionFridayGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.weeklyProductionSaturdayGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.weeklyProductionSundayGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.weeklyProductionTotalProducedWeeklyGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.weeklyProductionTotalProducedGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.weeklyProductionPercentageCompleteGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.previewProjBomAvailXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.lblNededBy = New DevExpress.XtraEditors.LabelControl()
        Me.neededBy = New DevExpress.XtraEditors.DateEdit()
        Me.ProjBomAvailGridControl = New DevExpress.XtraGrid.GridControl()
        Me.ProjBomAvailGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ProjBomAvailCustPOGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProjBomAvailItemCodeGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProjBomAvailItemDescriptionGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProjBomAvailItemTypeGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProjBomAvailTotalAmtNeededGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProjBomAvailLocalQtyGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProjBomLocalShortageGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProjBomAvailNonLocalQtyGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProjBomAvailNonLocalPalletsQtyGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProjBomAvailQtyOnHndGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ProjBomAvailQtyShortageGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.previewProductionBillingXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.previewProductionBillingGridControl = New DevExpress.XtraGrid.GridControl()
        Me.previewProductionBillingGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.productionBillingDateGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.productionBillingCustomerGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.productionBillingItemCodeGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.productionBillingItemDescriptionGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.productionBillingItemTypeGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.productionBillingShiftGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.productionBillingPOGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.productionBillingUOMGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.productionBillingQuantityGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.productionBillingCasesGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.productionBillingPriceGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.previewBaggingXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.baggingReportPivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.baggingReportXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.fieldProductionDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldProductionShift1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldQuantity1 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.reasonsPivotGridField = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.minutesPivotGridField = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.fieldItemCode = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.exportSaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.ProjBomAvailCustNameGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.quickReportsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quickReportsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reportsXtraTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.reportsXtraTabControl.SuspendLayout()
        Me.previewCustoemrsXtraTabPage.SuspendLayout()
        CType(Me.previewGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.previewGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.previewProductionEntriesXtraTabPage.SuspendLayout()
        CType(Me.previewProductionEntriesGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.previewProductionEntriesGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.previewLpnStatusXtraTabPage.SuspendLayout()
        CType(Me.previewLpnStatusGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.previewLpnStatusGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.previewCurrentRMInventoryXtraTabPage.SuspendLayout()
        CType(Me.previewCurrentRMInventoryGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.previewCurrentRMInventoryGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.previewCurrentInventoryXtraTabPage.SuspendLayout()
        CType(Me.outOfStockItemsCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.currentInventoryInactiveItemsCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.currentInventoryInactiveCustomersCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.previewCurrentInventoryGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.previewCurrentInventoryGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.previewLocationTransfersXtraTabPage.SuspendLayout()
        CType(Me.previewLocationTransfersGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.previewLocationTransfersGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.previewShiftScheduleXtraTabPage.SuspendLayout()
        CType(Me.shiftScheduleGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shiftScheduleGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shiftScheduleShiftComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shiftScheduleDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shiftScheduleDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.previewWeeklyProductionXtraTabPage.SuspendLayout()
        CType(Me.weeklyProductionGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.weeklyProductionGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.previewProjBomAvailXtraTabPage.SuspendLayout()
        CType(Me.neededBy.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.neededBy.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjBomAvailGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjBomAvailGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.previewProductionBillingXtraTabPage.SuspendLayout()
        CType(Me.previewProductionBillingGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.previewProductionBillingGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.previewBaggingXtraTabPage.SuspendLayout()
        CType(Me.baggingReportPivotGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.baggingReportXpView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fieldMachineName1
        '
        Me.fieldMachineName1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
        Me.fieldMachineName1.AreaIndex = 0
        Me.fieldMachineName1.Caption = "Machine"
        Me.fieldMachineName1.FieldName = "MachineName"
        Me.fieldMachineName1.Name = "fieldMachineName1"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.customersMenuBar, Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.printBarButtonItem, Me.exportXLSBarButtonItem})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 2
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'customersMenuBar
        '
        Me.customersMenuBar.BarName = "Tools"
        Me.customersMenuBar.DockCol = 0
        Me.customersMenuBar.DockRow = 0
        Me.customersMenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.customersMenuBar.FloatLocation = New System.Drawing.Point(375, 173)
        Me.customersMenuBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.printBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.exportXLSBarButtonItem)})
        Me.customersMenuBar.OptionsBar.UseWholeRow = True
        Me.customersMenuBar.Text = "Tools"
        '
        'printBarButtonItem
        '
        Me.printBarButtonItem.Caption = "&Print"
        Me.printBarButtonItem.Id = 0
        Me.printBarButtonItem.Name = "printBarButtonItem"
        '
        'exportXLSBarButtonItem
        '
        Me.exportXLSBarButtonItem.Caption = "Export to &Excel"
        Me.exportXLSBarButtonItem.Id = 1
        Me.exportXLSBarButtonItem.Name = "exportXLSBarButtonItem"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 1
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        Me.Bar2.Visible = False
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = False
        Me.Bar3.OptionsBar.DrawDragBorder = False
        Me.Bar3.OptionsBar.UseWholeRow = True
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(959, 49)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 661)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(959, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 49)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 612)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(959, 49)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 612)
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 49)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.quickReportsGridControl)
        Me.SplitContainerControl1.Panel1.MinSize = 300
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.reportsXtraTabControl)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(959, 612)
        Me.SplitContainerControl1.TabIndex = 4
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'quickReportsGridControl
        '
        Me.quickReportsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.quickReportsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.quickReportsGridControl.MainView = Me.quickReportsGridView
        Me.quickReportsGridControl.Name = "quickReportsGridControl"
        Me.quickReportsGridControl.Size = New System.Drawing.Size(300, 612)
        Me.quickReportsGridControl.TabIndex = 0
        Me.quickReportsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.quickReportsGridView})
        '
        'quickReportsGridView
        '
        Me.quickReportsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.reportNameGridColumn, Me.reportCodeNameGridColumn, Me.reportTypeGridColumn, Me.filterReportGridColumn, Me.dateFilterGridColumn, Me.customerFilterGridColumn, Me.itemFilterGridColumn, Me.lotFilterGridColumn, Me.poFilterGridColumn, Me.machineFilterGridColumn, Me.shiftFilterGridColumn, Me.bolFilterGridColumn, Me.dnFilterGridColumn, Me.destinationFilterGridColumn, Me.carrierFilterGridColumn, Me.vendorFilterGridColumn, Me.itemTypeFilterGridColumn, Me.outOfStockFilterGridColumn})
        Me.quickReportsGridView.GridControl = Me.quickReportsGridControl
        Me.quickReportsGridView.Name = "quickReportsGridView"
        Me.quickReportsGridView.OptionsBehavior.Editable = False
        Me.quickReportsGridView.OptionsView.ShowGroupPanel = False
        Me.quickReportsGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.reportNameGridColumn, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'reportNameGridColumn
        '
        Me.reportNameGridColumn.Caption = "Report Name"
        Me.reportNameGridColumn.Name = "reportNameGridColumn"
        Me.reportNameGridColumn.Visible = True
        Me.reportNameGridColumn.VisibleIndex = 0
        '
        'reportCodeNameGridColumn
        '
        Me.reportCodeNameGridColumn.Caption = "GridColumn1"
        Me.reportCodeNameGridColumn.Name = "reportCodeNameGridColumn"
        '
        'reportTypeGridColumn
        '
        Me.reportTypeGridColumn.Caption = "GridColumn1"
        Me.reportTypeGridColumn.Name = "reportTypeGridColumn"
        '
        'filterReportGridColumn
        '
        Me.filterReportGridColumn.Caption = "GridColumn1"
        Me.filterReportGridColumn.Name = "filterReportGridColumn"
        '
        'dateFilterGridColumn
        '
        Me.dateFilterGridColumn.Caption = "GridColumn1"
        Me.dateFilterGridColumn.Name = "dateFilterGridColumn"
        '
        'customerFilterGridColumn
        '
        Me.customerFilterGridColumn.Caption = "GridColumn1"
        Me.customerFilterGridColumn.Name = "customerFilterGridColumn"
        '
        'itemFilterGridColumn
        '
        Me.itemFilterGridColumn.Caption = "GridColumn1"
        Me.itemFilterGridColumn.Name = "itemFilterGridColumn"
        '
        'lotFilterGridColumn
        '
        Me.lotFilterGridColumn.Caption = "GridColumn1"
        Me.lotFilterGridColumn.Name = "lotFilterGridColumn"
        '
        'poFilterGridColumn
        '
        Me.poFilterGridColumn.Caption = "GridColumn1"
        Me.poFilterGridColumn.Name = "poFilterGridColumn"
        '
        'machineFilterGridColumn
        '
        Me.machineFilterGridColumn.Caption = "GridColumn1"
        Me.machineFilterGridColumn.Name = "machineFilterGridColumn"
        '
        'shiftFilterGridColumn
        '
        Me.shiftFilterGridColumn.Caption = "GridColumn1"
        Me.shiftFilterGridColumn.Name = "shiftFilterGridColumn"
        '
        'bolFilterGridColumn
        '
        Me.bolFilterGridColumn.Caption = "GridColumn1"
        Me.bolFilterGridColumn.Name = "bolFilterGridColumn"
        '
        'dnFilterGridColumn
        '
        Me.dnFilterGridColumn.Caption = "GridColumn1"
        Me.dnFilterGridColumn.Name = "dnFilterGridColumn"
        '
        'destinationFilterGridColumn
        '
        Me.destinationFilterGridColumn.Caption = "GridColumn1"
        Me.destinationFilterGridColumn.Name = "destinationFilterGridColumn"
        '
        'carrierFilterGridColumn
        '
        Me.carrierFilterGridColumn.Caption = "GridColumn1"
        Me.carrierFilterGridColumn.Name = "carrierFilterGridColumn"
        '
        'vendorFilterGridColumn
        '
        Me.vendorFilterGridColumn.Caption = "GridColumn1"
        Me.vendorFilterGridColumn.Name = "vendorFilterGridColumn"
        '
        'itemTypeFilterGridColumn
        '
        Me.itemTypeFilterGridColumn.Caption = "GridColumn1"
        Me.itemTypeFilterGridColumn.Name = "itemTypeFilterGridColumn"
        '
        'outOfStockFilterGridColumn
        '
        Me.outOfStockFilterGridColumn.Caption = "GridColumn1"
        Me.outOfStockFilterGridColumn.Name = "outOfStockFilterGridColumn"
        '
        'reportsXtraTabControl
        '
        Me.reportsXtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reportsXtraTabControl.Location = New System.Drawing.Point(0, 0)
        Me.reportsXtraTabControl.Name = "reportsXtraTabControl"
        Me.reportsXtraTabControl.SelectedTabPage = Me.filterXtraTabPage
        Me.reportsXtraTabControl.Size = New System.Drawing.Size(654, 612)
        Me.reportsXtraTabControl.TabIndex = 0
        Me.reportsXtraTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.filterXtraTabPage, Me.previewCustoemrsXtraTabPage, Me.previewProductionEntriesXtraTabPage, Me.previewLpnStatusXtraTabPage, Me.previewCurrentRMInventoryXtraTabPage, Me.previewCurrentInventoryXtraTabPage, Me.previewLocationTransfersXtraTabPage, Me.previewShiftScheduleXtraTabPage, Me.previewWeeklyProductionXtraTabPage, Me.previewProjBomAvailXtraTabPage, Me.previewProductionBillingXtraTabPage, Me.previewBaggingXtraTabPage})
        Me.reportsXtraTabControl.Visible = False
        '
        'filterXtraTabPage
        '
        Me.filterXtraTabPage.Name = "filterXtraTabPage"
        Me.filterXtraTabPage.Size = New System.Drawing.Size(648, 584)
        Me.filterXtraTabPage.Text = "Filters"
        '
        'previewCustoemrsXtraTabPage
        '
        Me.previewCustoemrsXtraTabPage.Controls.Add(Me.previewGridControl)
        Me.previewCustoemrsXtraTabPage.Name = "previewCustoemrsXtraTabPage"
        Me.previewCustoemrsXtraTabPage.Size = New System.Drawing.Size(648, 584)
        Me.previewCustoemrsXtraTabPage.Text = "Preview"
        '
        'previewGridControl
        '
        Me.previewGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.previewGridControl.Location = New System.Drawing.Point(0, 0)
        Me.previewGridControl.MainView = Me.previewGridView
        Me.previewGridControl.Name = "previewGridControl"
        Me.previewGridControl.Size = New System.Drawing.Size(648, 584)
        Me.previewGridControl.TabIndex = 0
        Me.previewGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.previewGridView})
        '
        'previewGridView
        '
        Me.previewGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nameGridColumn, Me.contactNameGridColumn, Me.addressGridColumn, Me.cityGridColumn, Me.stateGridColumn, Me.postalGridColumn, Me.phoneGridColumn, Me.faxGridColumn, Me.emailGridColumn, Me.inactiveGridColumn})
        Me.previewGridView.GridControl = Me.previewGridControl
        Me.previewGridView.Name = "previewGridView"
        Me.previewGridView.OptionsBehavior.Editable = False
        Me.previewGridView.OptionsView.ShowAutoFilterRow = True
        Me.previewGridView.OptionsView.ShowDetailButtons = False
        '
        'nameGridColumn
        '
        Me.nameGridColumn.Caption = "Name"
        Me.nameGridColumn.Name = "nameGridColumn"
        Me.nameGridColumn.Visible = True
        Me.nameGridColumn.VisibleIndex = 0
        '
        'contactNameGridColumn
        '
        Me.contactNameGridColumn.Caption = "Contact Name"
        Me.contactNameGridColumn.Name = "contactNameGridColumn"
        Me.contactNameGridColumn.Visible = True
        Me.contactNameGridColumn.VisibleIndex = 1
        '
        'addressGridColumn
        '
        Me.addressGridColumn.Caption = "Address"
        Me.addressGridColumn.Name = "addressGridColumn"
        Me.addressGridColumn.Visible = True
        Me.addressGridColumn.VisibleIndex = 2
        '
        'cityGridColumn
        '
        Me.cityGridColumn.Caption = "City"
        Me.cityGridColumn.Name = "cityGridColumn"
        Me.cityGridColumn.Visible = True
        Me.cityGridColumn.VisibleIndex = 3
        '
        'stateGridColumn
        '
        Me.stateGridColumn.Caption = "State"
        Me.stateGridColumn.Name = "stateGridColumn"
        Me.stateGridColumn.Visible = True
        Me.stateGridColumn.VisibleIndex = 4
        '
        'postalGridColumn
        '
        Me.postalGridColumn.Caption = "Zip Code"
        Me.postalGridColumn.Name = "postalGridColumn"
        Me.postalGridColumn.Visible = True
        Me.postalGridColumn.VisibleIndex = 5
        '
        'phoneGridColumn
        '
        Me.phoneGridColumn.Caption = "Phone"
        Me.phoneGridColumn.Name = "phoneGridColumn"
        Me.phoneGridColumn.Visible = True
        Me.phoneGridColumn.VisibleIndex = 6
        '
        'faxGridColumn
        '
        Me.faxGridColumn.Caption = "Fax"
        Me.faxGridColumn.Name = "faxGridColumn"
        Me.faxGridColumn.Visible = True
        Me.faxGridColumn.VisibleIndex = 7
        '
        'emailGridColumn
        '
        Me.emailGridColumn.Caption = "Email"
        Me.emailGridColumn.Name = "emailGridColumn"
        Me.emailGridColumn.Visible = True
        Me.emailGridColumn.VisibleIndex = 8
        '
        'inactiveGridColumn
        '
        Me.inactiveGridColumn.Caption = "Inactive"
        Me.inactiveGridColumn.Name = "inactiveGridColumn"
        Me.inactiveGridColumn.Visible = True
        Me.inactiveGridColumn.VisibleIndex = 9
        '
        'previewProductionEntriesXtraTabPage
        '
        Me.previewProductionEntriesXtraTabPage.Controls.Add(Me.previewProductionEntriesGridControl)
        Me.previewProductionEntriesXtraTabPage.Name = "previewProductionEntriesXtraTabPage"
        Me.previewProductionEntriesXtraTabPage.Size = New System.Drawing.Size(648, 584)
        Me.previewProductionEntriesXtraTabPage.Text = "Preview Production"
        '
        'previewProductionEntriesGridControl
        '
        Me.previewProductionEntriesGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.previewProductionEntriesGridControl.Location = New System.Drawing.Point(0, 0)
        Me.previewProductionEntriesGridControl.MainView = Me.previewProductionEntriesGridView
        Me.previewProductionEntriesGridControl.Name = "previewProductionEntriesGridControl"
        Me.previewProductionEntriesGridControl.Size = New System.Drawing.Size(648, 584)
        Me.previewProductionEntriesGridControl.TabIndex = 1
        Me.previewProductionEntriesGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.previewProductionEntriesGridView})
        '
        'previewProductionEntriesGridView
        '
        Me.previewProductionEntriesGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.productionDateGridColumn, Me.customerNameGridColumn, Me.itemNumberGridColumn, Me.itemDescriptionGridColumn, Me.itemTypeGridColumn, Me.shiftGridColumn, Me.quantityGridColumn, Me.poGridColumn, Me.lotGridColumn, Me.palletNumberGridColumn, Me.lpnNumberGridColumn, Me.expirationDateGridColumn, Me.expirationDateFormatGridColumn, Me.noteGridColumn})
        Me.previewProductionEntriesGridView.GridControl = Me.previewProductionEntriesGridControl
        Me.previewProductionEntriesGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", Me.quantityGridColumn, "{0:#,##0.######}")})
        Me.previewProductionEntriesGridView.Name = "previewProductionEntriesGridView"
        Me.previewProductionEntriesGridView.OptionsBehavior.Editable = False
        Me.previewProductionEntriesGridView.OptionsView.ShowAutoFilterRow = True
        Me.previewProductionEntriesGridView.OptionsView.ShowDetailButtons = False
        Me.previewProductionEntriesGridView.OptionsView.ShowFooter = True
        '
        'productionDateGridColumn
        '
        Me.productionDateGridColumn.AppearanceCell.Options.UseTextOptions = True
        Me.productionDateGridColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.productionDateGridColumn.Caption = "Production Date"
        Me.productionDateGridColumn.DisplayFormat.FormatString = "d"
        Me.productionDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.productionDateGridColumn.Name = "productionDateGridColumn"
        Me.productionDateGridColumn.Visible = True
        Me.productionDateGridColumn.VisibleIndex = 0
        '
        'customerNameGridColumn
        '
        Me.customerNameGridColumn.Caption = "Customer Name"
        Me.customerNameGridColumn.Name = "customerNameGridColumn"
        Me.customerNameGridColumn.Visible = True
        Me.customerNameGridColumn.VisibleIndex = 1
        '
        'itemNumberGridColumn
        '
        Me.itemNumberGridColumn.Caption = "Item #"
        Me.itemNumberGridColumn.Name = "itemNumberGridColumn"
        Me.itemNumberGridColumn.Visible = True
        Me.itemNumberGridColumn.VisibleIndex = 2
        '
        'itemDescriptionGridColumn
        '
        Me.itemDescriptionGridColumn.Caption = "Item Description"
        Me.itemDescriptionGridColumn.Name = "itemDescriptionGridColumn"
        Me.itemDescriptionGridColumn.Visible = True
        Me.itemDescriptionGridColumn.VisibleIndex = 3
        '
        'itemTypeGridColumn
        '
        Me.itemTypeGridColumn.Caption = "Item Type"
        Me.itemTypeGridColumn.Name = "itemTypeGridColumn"
        Me.itemTypeGridColumn.Visible = True
        Me.itemTypeGridColumn.VisibleIndex = 4
        '
        'shiftGridColumn
        '
        Me.shiftGridColumn.Caption = "Shift"
        Me.shiftGridColumn.Name = "shiftGridColumn"
        Me.shiftGridColumn.Visible = True
        Me.shiftGridColumn.VisibleIndex = 5
        '
        'quantityGridColumn
        '
        Me.quantityGridColumn.AppearanceCell.Options.UseTextOptions = True
        Me.quantityGridColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.quantityGridColumn.Caption = "Quantity"
        Me.quantityGridColumn.Name = "quantityGridColumn"
        Me.quantityGridColumn.Visible = True
        Me.quantityGridColumn.VisibleIndex = 6
        '
        'poGridColumn
        '
        Me.poGridColumn.Caption = "PO #"
        Me.poGridColumn.Name = "poGridColumn"
        Me.poGridColumn.Visible = True
        Me.poGridColumn.VisibleIndex = 7
        '
        'lotGridColumn
        '
        Me.lotGridColumn.Caption = "Lot #"
        Me.lotGridColumn.Name = "lotGridColumn"
        Me.lotGridColumn.Visible = True
        Me.lotGridColumn.VisibleIndex = 8
        '
        'palletNumberGridColumn
        '
        Me.palletNumberGridColumn.AppearanceCell.Options.UseTextOptions = True
        Me.palletNumberGridColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.palletNumberGridColumn.Caption = "Pallet #"
        Me.palletNumberGridColumn.Name = "palletNumberGridColumn"
        Me.palletNumberGridColumn.Visible = True
        Me.palletNumberGridColumn.VisibleIndex = 10
        '
        'lpnNumberGridColumn
        '
        Me.lpnNumberGridColumn.Caption = "LPN #"
        Me.lpnNumberGridColumn.Name = "lpnNumberGridColumn"
        Me.lpnNumberGridColumn.Visible = True
        Me.lpnNumberGridColumn.VisibleIndex = 11
        '
        'expirationDateGridColumn
        '
        Me.expirationDateGridColumn.Caption = "Expiration Date"
        Me.expirationDateGridColumn.Name = "expirationDateGridColumn"
        Me.expirationDateGridColumn.Visible = True
        Me.expirationDateGridColumn.VisibleIndex = 9
        '
        'expirationDateFormatGridColumn
        '
        Me.expirationDateFormatGridColumn.Caption = "GridColumn1"
        Me.expirationDateFormatGridColumn.Name = "expirationDateFormatGridColumn"
        Me.expirationDateFormatGridColumn.OptionsColumn.AllowShowHide = False
        Me.expirationDateFormatGridColumn.OptionsColumn.ShowInCustomizationForm = False
        '
        'noteGridColumn
        '
        Me.noteGridColumn.Caption = "Note"
        Me.noteGridColumn.Name = "noteGridColumn"
        Me.noteGridColumn.Visible = True
        Me.noteGridColumn.VisibleIndex = 12
        '
        'previewLpnStatusXtraTabPage
        '
        Me.previewLpnStatusXtraTabPage.Controls.Add(Me.previewLpnStatusGridControl)
        Me.previewLpnStatusXtraTabPage.Name = "previewLpnStatusXtraTabPage"
        Me.previewLpnStatusXtraTabPage.Size = New System.Drawing.Size(648, 584)
        Me.previewLpnStatusXtraTabPage.Text = "Preview LPN"
        '
        'previewLpnStatusGridControl
        '
        Me.previewLpnStatusGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.previewLpnStatusGridControl.Location = New System.Drawing.Point(0, 0)
        Me.previewLpnStatusGridControl.MainView = Me.previewLpnStatusGridView
        Me.previewLpnStatusGridControl.Name = "previewLpnStatusGridControl"
        Me.previewLpnStatusGridControl.Size = New System.Drawing.Size(648, 584)
        Me.previewLpnStatusGridControl.TabIndex = 2
        Me.previewLpnStatusGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.previewLpnStatusGridView})
        '
        'previewLpnStatusGridView
        '
        Me.previewLpnStatusGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.lpnCustomerNameGridColumn, Me.fullLpnGridColumn, Me.lpnItemCodeGridColumn, Me.lpnItemDescriptionGridColumn, Me.lpnQuantityGridColumn, Me.lpnProductionDateGridColumn, Me.lpnShippingDateGridColumn, Me.lpnShippingBolGridColumn})
        Me.previewLpnStatusGridView.GridControl = Me.previewLpnStatusGridControl
        Me.previewLpnStatusGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", Me.lpnQuantityGridColumn, "{0:#,##0.######}")})
        Me.previewLpnStatusGridView.Name = "previewLpnStatusGridView"
        Me.previewLpnStatusGridView.OptionsBehavior.Editable = False
        Me.previewLpnStatusGridView.OptionsView.ShowAutoFilterRow = True
        Me.previewLpnStatusGridView.OptionsView.ShowFooter = True
        '
        'lpnCustomerNameGridColumn
        '
        Me.lpnCustomerNameGridColumn.Caption = "Customer Name"
        Me.lpnCustomerNameGridColumn.Name = "lpnCustomerNameGridColumn"
        Me.lpnCustomerNameGridColumn.Visible = True
        Me.lpnCustomerNameGridColumn.VisibleIndex = 0
        '
        'fullLpnGridColumn
        '
        Me.fullLpnGridColumn.Caption = "Full LPN #"
        Me.fullLpnGridColumn.Name = "fullLpnGridColumn"
        Me.fullLpnGridColumn.Visible = True
        Me.fullLpnGridColumn.VisibleIndex = 1
        '
        'lpnItemCodeGridColumn
        '
        Me.lpnItemCodeGridColumn.Caption = "Item #"
        Me.lpnItemCodeGridColumn.Name = "lpnItemCodeGridColumn"
        Me.lpnItemCodeGridColumn.Visible = True
        Me.lpnItemCodeGridColumn.VisibleIndex = 2
        '
        'lpnItemDescriptionGridColumn
        '
        Me.lpnItemDescriptionGridColumn.Caption = "Item Description"
        Me.lpnItemDescriptionGridColumn.Name = "lpnItemDescriptionGridColumn"
        Me.lpnItemDescriptionGridColumn.Visible = True
        Me.lpnItemDescriptionGridColumn.VisibleIndex = 3
        '
        'lpnQuantityGridColumn
        '
        Me.lpnQuantityGridColumn.AppearanceCell.Options.UseTextOptions = True
        Me.lpnQuantityGridColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lpnQuantityGridColumn.Caption = "Quantity"
        Me.lpnQuantityGridColumn.Name = "lpnQuantityGridColumn"
        Me.lpnQuantityGridColumn.Visible = True
        Me.lpnQuantityGridColumn.VisibleIndex = 4
        '
        'lpnProductionDateGridColumn
        '
        Me.lpnProductionDateGridColumn.AppearanceCell.Options.UseTextOptions = True
        Me.lpnProductionDateGridColumn.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lpnProductionDateGridColumn.Caption = "Production Date"
        Me.lpnProductionDateGridColumn.DisplayFormat.FormatString = "d"
        Me.lpnProductionDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.lpnProductionDateGridColumn.Name = "lpnProductionDateGridColumn"
        Me.lpnProductionDateGridColumn.Visible = True
        Me.lpnProductionDateGridColumn.VisibleIndex = 5
        '
        'lpnShippingDateGridColumn
        '
        Me.lpnShippingDateGridColumn.Caption = "Shipping Date"
        Me.lpnShippingDateGridColumn.DisplayFormat.FormatString = "d"
        Me.lpnShippingDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.lpnShippingDateGridColumn.Name = "lpnShippingDateGridColumn"
        Me.lpnShippingDateGridColumn.Visible = True
        Me.lpnShippingDateGridColumn.VisibleIndex = 6
        '
        'lpnShippingBolGridColumn
        '
        Me.lpnShippingBolGridColumn.Caption = "BOL #"
        Me.lpnShippingBolGridColumn.Name = "lpnShippingBolGridColumn"
        Me.lpnShippingBolGridColumn.Visible = True
        Me.lpnShippingBolGridColumn.VisibleIndex = 7
        '
        'previewCurrentRMInventoryXtraTabPage
        '
        Me.previewCurrentRMInventoryXtraTabPage.Controls.Add(Me.previewCurrentRMInventoryGridControl)
        Me.previewCurrentRMInventoryXtraTabPage.Name = "previewCurrentRMInventoryXtraTabPage"
        Me.previewCurrentRMInventoryXtraTabPage.Size = New System.Drawing.Size(648, 584)
        Me.previewCurrentRMInventoryXtraTabPage.Text = "Preview Current RM Inventory"
        '
        'previewCurrentRMInventoryGridControl
        '
        Me.previewCurrentRMInventoryGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.previewCurrentRMInventoryGridControl.Location = New System.Drawing.Point(0, 0)
        Me.previewCurrentRMInventoryGridControl.MainView = Me.previewCurrentRMInventoryGridView
        Me.previewCurrentRMInventoryGridControl.MenuManager = Me.BarManager1
        Me.previewCurrentRMInventoryGridControl.Name = "previewCurrentRMInventoryGridControl"
        Me.previewCurrentRMInventoryGridControl.Size = New System.Drawing.Size(648, 584)
        Me.previewCurrentRMInventoryGridControl.TabIndex = 0
        Me.previewCurrentRMInventoryGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.previewCurrentRMInventoryGridView})
        '
        'previewCurrentRMInventoryGridView
        '
        Me.previewCurrentRMInventoryGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.rmInventoryCustomerNameGridColumn, Me.rmInventoryIemCodeGridColumn, Me.rmInventoryItemDescriptionGridColumn, Me.rmInventoryLocationGridColumn, Me.rmInventoryQtyOnHandGridColumn, Me.rmInventoryInactiveGridColumn, Me.rmInventoryItemIDGridColumn})
        Me.previewCurrentRMInventoryGridView.GridControl = Me.previewCurrentRMInventoryGridControl
        Me.previewCurrentRMInventoryGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QuantityOnHand", Me.rmInventoryQtyOnHandGridColumn, "{0:#,##0.######}")})
        Me.previewCurrentRMInventoryGridView.Name = "previewCurrentRMInventoryGridView"
        Me.previewCurrentRMInventoryGridView.OptionsBehavior.Editable = False
        Me.previewCurrentRMInventoryGridView.OptionsView.ShowAutoFilterRow = True
        Me.previewCurrentRMInventoryGridView.OptionsView.ShowDetailButtons = False
        Me.previewCurrentRMInventoryGridView.OptionsView.ShowFooter = True
        '
        'rmInventoryCustomerNameGridColumn
        '
        Me.rmInventoryCustomerNameGridColumn.Caption = "Customer Name"
        Me.rmInventoryCustomerNameGridColumn.Name = "rmInventoryCustomerNameGridColumn"
        Me.rmInventoryCustomerNameGridColumn.Visible = True
        Me.rmInventoryCustomerNameGridColumn.VisibleIndex = 0
        '
        'rmInventoryIemCodeGridColumn
        '
        Me.rmInventoryIemCodeGridColumn.Caption = "Item Code"
        Me.rmInventoryIemCodeGridColumn.Name = "rmInventoryIemCodeGridColumn"
        Me.rmInventoryIemCodeGridColumn.Visible = True
        Me.rmInventoryIemCodeGridColumn.VisibleIndex = 1
        '
        'rmInventoryItemDescriptionGridColumn
        '
        Me.rmInventoryItemDescriptionGridColumn.Caption = "Item Description"
        Me.rmInventoryItemDescriptionGridColumn.Name = "rmInventoryItemDescriptionGridColumn"
        Me.rmInventoryItemDescriptionGridColumn.Visible = True
        Me.rmInventoryItemDescriptionGridColumn.VisibleIndex = 2
        '
        'rmInventoryLocationGridColumn
        '
        Me.rmInventoryLocationGridColumn.Caption = "Location"
        Me.rmInventoryLocationGridColumn.Name = "rmInventoryLocationGridColumn"
        Me.rmInventoryLocationGridColumn.Visible = True
        Me.rmInventoryLocationGridColumn.VisibleIndex = 3
        '
        'rmInventoryQtyOnHandGridColumn
        '
        Me.rmInventoryQtyOnHandGridColumn.Caption = "Quantity On Hand"
        Me.rmInventoryQtyOnHandGridColumn.DisplayFormat.FormatString = "{0:#,##0.00####}"
        Me.rmInventoryQtyOnHandGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rmInventoryQtyOnHandGridColumn.Name = "rmInventoryQtyOnHandGridColumn"
        Me.rmInventoryQtyOnHandGridColumn.Visible = True
        Me.rmInventoryQtyOnHandGridColumn.VisibleIndex = 4
        '
        'rmInventoryInactiveGridColumn
        '
        Me.rmInventoryInactiveGridColumn.Caption = "Inactive"
        Me.rmInventoryInactiveGridColumn.Name = "rmInventoryInactiveGridColumn"
        '
        'rmInventoryItemIDGridColumn
        '
        Me.rmInventoryItemIDGridColumn.Caption = "Item ID"
        Me.rmInventoryItemIDGridColumn.Name = "rmInventoryItemIDGridColumn"
        '
        'previewCurrentInventoryXtraTabPage
        '
        Me.previewCurrentInventoryXtraTabPage.Controls.Add(Me.refreshSimpleButton)
        Me.previewCurrentInventoryXtraTabPage.Controls.Add(Me.outOfStockItemsCheckEdit)
        Me.previewCurrentInventoryXtraTabPage.Controls.Add(Me.currentInventoryInactiveItemsCheckEdit)
        Me.previewCurrentInventoryXtraTabPage.Controls.Add(Me.currentInventoryInactiveCustomersCheckEdit)
        Me.previewCurrentInventoryXtraTabPage.Controls.Add(Me.LabelControl1)
        Me.previewCurrentInventoryXtraTabPage.Controls.Add(Me.previewCurrentInventoryGridControl)
        Me.previewCurrentInventoryXtraTabPage.Name = "previewCurrentInventoryXtraTabPage"
        Me.previewCurrentInventoryXtraTabPage.Size = New System.Drawing.Size(648, 584)
        Me.previewCurrentInventoryXtraTabPage.Text = "Preview Current Inventory"
        '
        'refreshSimpleButton
        '
        Me.refreshSimpleButton.Location = New System.Drawing.Point(472, 4)
        Me.refreshSimpleButton.Name = "refreshSimpleButton"
        Me.refreshSimpleButton.Size = New System.Drawing.Size(107, 23)
        Me.refreshSimpleButton.TabIndex = 5
        Me.refreshSimpleButton.Text = "Refresh"
        '
        'outOfStockItemsCheckEdit
        '
        Me.outOfStockItemsCheckEdit.Location = New System.Drawing.Point(332, 9)
        Me.outOfStockItemsCheckEdit.MenuManager = Me.BarManager1
        Me.outOfStockItemsCheckEdit.Name = "outOfStockItemsCheckEdit"
        Me.outOfStockItemsCheckEdit.Properties.Caption = "Out Of Stock Items"
        Me.outOfStockItemsCheckEdit.Size = New System.Drawing.Size(133, 19)
        Me.outOfStockItemsCheckEdit.TabIndex = 4
        '
        'currentInventoryInactiveItemsCheckEdit
        '
        Me.currentInventoryInactiveItemsCheckEdit.Location = New System.Drawing.Point(218, 9)
        Me.currentInventoryInactiveItemsCheckEdit.MenuManager = Me.BarManager1
        Me.currentInventoryInactiveItemsCheckEdit.Name = "currentInventoryInactiveItemsCheckEdit"
        Me.currentInventoryInactiveItemsCheckEdit.Properties.Caption = "Inactive Items"
        Me.currentInventoryInactiveItemsCheckEdit.Size = New System.Drawing.Size(107, 19)
        Me.currentInventoryInactiveItemsCheckEdit.TabIndex = 3
        '
        'currentInventoryInactiveCustomersCheckEdit
        '
        Me.currentInventoryInactiveCustomersCheckEdit.Location = New System.Drawing.Point(86, 9)
        Me.currentInventoryInactiveCustomersCheckEdit.MenuManager = Me.BarManager1
        Me.currentInventoryInactiveCustomersCheckEdit.Name = "currentInventoryInactiveCustomersCheckEdit"
        Me.currentInventoryInactiveCustomersCheckEdit.Properties.Caption = "Inactive Customers"
        Me.currentInventoryInactiveCustomersCheckEdit.Size = New System.Drawing.Size(125, 19)
        Me.currentInventoryInactiveCustomersCheckEdit.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(18, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(52, 16)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Include:"
        '
        'previewCurrentInventoryGridControl
        '
        Me.previewCurrentInventoryGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.previewCurrentInventoryGridControl.Location = New System.Drawing.Point(0, 34)
        Me.previewCurrentInventoryGridControl.MainView = Me.previewCurrentInventoryGridView
        Me.previewCurrentInventoryGridControl.MenuManager = Me.BarManager1
        Me.previewCurrentInventoryGridControl.Name = "previewCurrentInventoryGridControl"
        Me.previewCurrentInventoryGridControl.Size = New System.Drawing.Size(648, 550)
        Me.previewCurrentInventoryGridControl.TabIndex = 0
        Me.previewCurrentInventoryGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.previewCurrentInventoryGridView})
        '
        'previewCurrentInventoryGridView
        '
        Me.previewCurrentInventoryGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.currentInventoryCustomerNameGridColumn, Me.currentInventoryItemCodeGridColumn, Me.currentInventoryItemDescriptionGridColumn, Me.currentInventoryItemTypeGridColumn, Me.currentInventoryQuantityOnHandGridColumn, Me.currentInventoryInventoryByPalletsGridColumn, Me.currentInventoryUOMGridColumn, Me.currentInventoryLocationGridColumn})
        Me.previewCurrentInventoryGridView.GridControl = Me.previewCurrentInventoryGridControl
        Me.previewCurrentInventoryGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QuantityOnHand", Me.currentInventoryQuantityOnHandGridColumn, "{0:#,##0.######}")})
        Me.previewCurrentInventoryGridView.Name = "previewCurrentInventoryGridView"
        Me.previewCurrentInventoryGridView.OptionsBehavior.Editable = False
        Me.previewCurrentInventoryGridView.OptionsView.ShowAutoFilterRow = True
        Me.previewCurrentInventoryGridView.OptionsView.ShowDetailButtons = False
        Me.previewCurrentInventoryGridView.OptionsView.ShowFooter = True
        '
        'currentInventoryCustomerNameGridColumn
        '
        Me.currentInventoryCustomerNameGridColumn.Caption = "Customer Name"
        Me.currentInventoryCustomerNameGridColumn.Name = "currentInventoryCustomerNameGridColumn"
        Me.currentInventoryCustomerNameGridColumn.Visible = True
        Me.currentInventoryCustomerNameGridColumn.VisibleIndex = 0
        '
        'currentInventoryItemCodeGridColumn
        '
        Me.currentInventoryItemCodeGridColumn.Caption = "Item Code"
        Me.currentInventoryItemCodeGridColumn.Name = "currentInventoryItemCodeGridColumn"
        Me.currentInventoryItemCodeGridColumn.Visible = True
        Me.currentInventoryItemCodeGridColumn.VisibleIndex = 1
        '
        'currentInventoryItemDescriptionGridColumn
        '
        Me.currentInventoryItemDescriptionGridColumn.Caption = "Item Description"
        Me.currentInventoryItemDescriptionGridColumn.Name = "currentInventoryItemDescriptionGridColumn"
        Me.currentInventoryItemDescriptionGridColumn.Visible = True
        Me.currentInventoryItemDescriptionGridColumn.VisibleIndex = 2
        '
        'currentInventoryItemTypeGridColumn
        '
        Me.currentInventoryItemTypeGridColumn.Caption = "Item Type"
        Me.currentInventoryItemTypeGridColumn.Name = "currentInventoryItemTypeGridColumn"
        Me.currentInventoryItemTypeGridColumn.Visible = True
        Me.currentInventoryItemTypeGridColumn.VisibleIndex = 3
        '
        'currentInventoryQuantityOnHandGridColumn
        '
        Me.currentInventoryQuantityOnHandGridColumn.Caption = "Quantity On Hand"
        Me.currentInventoryQuantityOnHandGridColumn.DisplayFormat.FormatString = "{0:#,##0.00####}"
        Me.currentInventoryQuantityOnHandGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.currentInventoryQuantityOnHandGridColumn.Name = "currentInventoryQuantityOnHandGridColumn"
        Me.currentInventoryQuantityOnHandGridColumn.Visible = True
        Me.currentInventoryQuantityOnHandGridColumn.VisibleIndex = 5
        '
        'currentInventoryInventoryByPalletsGridColumn
        '
        Me.currentInventoryInventoryByPalletsGridColumn.Caption = "Inventory By Pallets"
        Me.currentInventoryInventoryByPalletsGridColumn.DisplayFormat.FormatString = "{0:#,##0.00####}"
        Me.currentInventoryInventoryByPalletsGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.currentInventoryInventoryByPalletsGridColumn.GroupFormat.FormatString = "{0:#,##0.00####}"
        Me.currentInventoryInventoryByPalletsGridColumn.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.currentInventoryInventoryByPalletsGridColumn.Name = "currentInventoryInventoryByPalletsGridColumn"
        Me.currentInventoryInventoryByPalletsGridColumn.Visible = True
        Me.currentInventoryInventoryByPalletsGridColumn.VisibleIndex = 7
        '
        'currentInventoryUOMGridColumn
        '
        Me.currentInventoryUOMGridColumn.Caption = "UOM"
        Me.currentInventoryUOMGridColumn.Name = "currentInventoryUOMGridColumn"
        Me.currentInventoryUOMGridColumn.Visible = True
        Me.currentInventoryUOMGridColumn.VisibleIndex = 6
        '
        'currentInventoryLocationGridColumn
        '
        Me.currentInventoryLocationGridColumn.Caption = "Location"
        Me.currentInventoryLocationGridColumn.Name = "currentInventoryLocationGridColumn"
        Me.currentInventoryLocationGridColumn.Visible = True
        Me.currentInventoryLocationGridColumn.VisibleIndex = 4
        '
        'previewLocationTransfersXtraTabPage
        '
        Me.previewLocationTransfersXtraTabPage.Controls.Add(Me.previewLocationTransfersGridControl)
        Me.previewLocationTransfersXtraTabPage.Name = "previewLocationTransfersXtraTabPage"
        Me.previewLocationTransfersXtraTabPage.Size = New System.Drawing.Size(648, 584)
        Me.previewLocationTransfersXtraTabPage.Text = "Preview Location Transfers"
        '
        'previewLocationTransfersGridControl
        '
        Me.previewLocationTransfersGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.previewLocationTransfersGridControl.Location = New System.Drawing.Point(0, 0)
        Me.previewLocationTransfersGridControl.MainView = Me.previewLocationTransfersGridView
        Me.previewLocationTransfersGridControl.MenuManager = Me.BarManager1
        Me.previewLocationTransfersGridControl.Name = "previewLocationTransfersGridControl"
        Me.previewLocationTransfersGridControl.Size = New System.Drawing.Size(648, 584)
        Me.previewLocationTransfersGridControl.TabIndex = 0
        Me.previewLocationTransfersGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.previewLocationTransfersGridView})
        '
        'previewLocationTransfersGridView
        '
        Me.previewLocationTransfersGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.locationTransfersDateGridColumn, Me.locationTransferFromLocationGridColumn, Me.locationTransferToLocationGridColumn, Me.locationTransferItemCodeGridColumn, Me.locationTransferItemDescriptionGridColumn, Me.locationTransferNumberGridColumn, Me.locationTransferItemLotGridColumn, Me.locationTransferExpirationDateGridColumn, Me.locationTransferQuantityGridColumn, Me.locationTransferExpirationDateFormatGridColumn, Me.locationTransferPalletsGridColumn, Me.locationTransferUnitsGridColumn, Me.locationTransferCarrierGridColumn})
        Me.previewLocationTransfersGridView.GridControl = Me.previewLocationTransfersGridControl
        Me.previewLocationTransfersGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TransferQuantity", Me.locationTransferQuantityGridColumn, "{0:#,##0.######}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TransferUnits", Me.locationTransferUnitsGridColumn, "{0:#,##0.######}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TransferPallets", Me.locationTransferPalletsGridColumn, "{0:#,##0.######}")})
        Me.previewLocationTransfersGridView.Name = "previewLocationTransfersGridView"
        Me.previewLocationTransfersGridView.OptionsBehavior.Editable = False
        Me.previewLocationTransfersGridView.OptionsView.ShowAutoFilterRow = True
        Me.previewLocationTransfersGridView.OptionsView.ShowDetailButtons = False
        Me.previewLocationTransfersGridView.OptionsView.ShowFooter = True
        '
        'locationTransfersDateGridColumn
        '
        Me.locationTransfersDateGridColumn.Caption = "Transfer Date"
        Me.locationTransfersDateGridColumn.Name = "locationTransfersDateGridColumn"
        Me.locationTransfersDateGridColumn.Visible = True
        Me.locationTransfersDateGridColumn.VisibleIndex = 0
        '
        'locationTransferFromLocationGridColumn
        '
        Me.locationTransferFromLocationGridColumn.Caption = "From Location"
        Me.locationTransferFromLocationGridColumn.Name = "locationTransferFromLocationGridColumn"
        Me.locationTransferFromLocationGridColumn.Visible = True
        Me.locationTransferFromLocationGridColumn.VisibleIndex = 2
        '
        'locationTransferToLocationGridColumn
        '
        Me.locationTransferToLocationGridColumn.Caption = "To Location"
        Me.locationTransferToLocationGridColumn.Name = "locationTransferToLocationGridColumn"
        Me.locationTransferToLocationGridColumn.Visible = True
        Me.locationTransferToLocationGridColumn.VisibleIndex = 3
        '
        'locationTransferItemCodeGridColumn
        '
        Me.locationTransferItemCodeGridColumn.Caption = "Item Code"
        Me.locationTransferItemCodeGridColumn.Name = "locationTransferItemCodeGridColumn"
        Me.locationTransferItemCodeGridColumn.Visible = True
        Me.locationTransferItemCodeGridColumn.VisibleIndex = 4
        '
        'locationTransferItemDescriptionGridColumn
        '
        Me.locationTransferItemDescriptionGridColumn.Caption = "Item Description"
        Me.locationTransferItemDescriptionGridColumn.Name = "locationTransferItemDescriptionGridColumn"
        Me.locationTransferItemDescriptionGridColumn.Visible = True
        Me.locationTransferItemDescriptionGridColumn.VisibleIndex = 5
        '
        'locationTransferNumberGridColumn
        '
        Me.locationTransferNumberGridColumn.Caption = "Transfer Number"
        Me.locationTransferNumberGridColumn.Name = "locationTransferNumberGridColumn"
        Me.locationTransferNumberGridColumn.Visible = True
        Me.locationTransferNumberGridColumn.VisibleIndex = 1
        '
        'locationTransferItemLotGridColumn
        '
        Me.locationTransferItemLotGridColumn.Caption = "Item Lot #"
        Me.locationTransferItemLotGridColumn.Name = "locationTransferItemLotGridColumn"
        Me.locationTransferItemLotGridColumn.Visible = True
        Me.locationTransferItemLotGridColumn.VisibleIndex = 6
        '
        'locationTransferExpirationDateGridColumn
        '
        Me.locationTransferExpirationDateGridColumn.Caption = "Expiration Date"
        Me.locationTransferExpirationDateGridColumn.DisplayFormat.FormatString = "d"
        Me.locationTransferExpirationDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.locationTransferExpirationDateGridColumn.Name = "locationTransferExpirationDateGridColumn"
        Me.locationTransferExpirationDateGridColumn.Visible = True
        Me.locationTransferExpirationDateGridColumn.VisibleIndex = 7
        '
        'locationTransferQuantityGridColumn
        '
        Me.locationTransferQuantityGridColumn.Caption = "Transfer Quantity"
        Me.locationTransferQuantityGridColumn.Name = "locationTransferQuantityGridColumn"
        Me.locationTransferQuantityGridColumn.Visible = True
        Me.locationTransferQuantityGridColumn.VisibleIndex = 8
        '
        'locationTransferExpirationDateFormatGridColumn
        '
        Me.locationTransferExpirationDateFormatGridColumn.Caption = "GridColumn10"
        Me.locationTransferExpirationDateFormatGridColumn.Name = "locationTransferExpirationDateFormatGridColumn"
        '
        'locationTransferPalletsGridColumn
        '
        Me.locationTransferPalletsGridColumn.Caption = "Transfer Pallets"
        Me.locationTransferPalletsGridColumn.Name = "locationTransferPalletsGridColumn"
        Me.locationTransferPalletsGridColumn.Visible = True
        Me.locationTransferPalletsGridColumn.VisibleIndex = 10
        '
        'locationTransferUnitsGridColumn
        '
        Me.locationTransferUnitsGridColumn.Caption = "Transfer Units"
        Me.locationTransferUnitsGridColumn.Name = "locationTransferUnitsGridColumn"
        Me.locationTransferUnitsGridColumn.Visible = True
        Me.locationTransferUnitsGridColumn.VisibleIndex = 9
        '
        'locationTransferCarrierGridColumn
        '
        Me.locationTransferCarrierGridColumn.Caption = "Transfer Carrier"
        Me.locationTransferCarrierGridColumn.Name = "locationTransferCarrierGridColumn"
        Me.locationTransferCarrierGridColumn.Visible = True
        Me.locationTransferCarrierGridColumn.VisibleIndex = 11
        '
        'previewShiftScheduleXtraTabPage
        '
        Me.previewShiftScheduleXtraTabPage.Controls.Add(Me.shiftScheduleGridControl)
        Me.previewShiftScheduleXtraTabPage.Controls.Add(Me.refreshShiftScheduleSimpleButton)
        Me.previewShiftScheduleXtraTabPage.Controls.Add(Me.shiftScheduleShiftComboBoxEdit)
        Me.previewShiftScheduleXtraTabPage.Controls.Add(Me.shiftScheduleDateDateEdit)
        Me.previewShiftScheduleXtraTabPage.Controls.Add(Me.LabelControl2)
        Me.previewShiftScheduleXtraTabPage.Name = "previewShiftScheduleXtraTabPage"
        Me.previewShiftScheduleXtraTabPage.Size = New System.Drawing.Size(648, 584)
        Me.previewShiftScheduleXtraTabPage.Text = "Preview Shift Schedule"
        '
        'shiftScheduleGridControl
        '
        Me.shiftScheduleGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.shiftScheduleGridControl.Location = New System.Drawing.Point(0, 40)
        Me.shiftScheduleGridControl.MainView = Me.shiftScheduleGridView
        Me.shiftScheduleGridControl.MenuManager = Me.BarManager1
        Me.shiftScheduleGridControl.Name = "shiftScheduleGridControl"
        Me.shiftScheduleGridControl.Size = New System.Drawing.Size(648, 544)
        Me.shiftScheduleGridControl.TabIndex = 4
        Me.shiftScheduleGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.shiftScheduleGridView})
        '
        'shiftScheduleGridView
        '
        Me.shiftScheduleGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.shiftScheduleMachineNameGridColumn, Me.shiftSchedulePeopleGridColumn, Me.shiftScheduleOperatorGridColumn, Me.shiftScheduleItemCodeGridColumn, Me.shiftScheduleItemDescriptionGridColumn, Me.shiftScheduleQuantityGridColumn, Me.shiftScheduleSchedByQtyGridColumn, Me.shiftScheduleNoteGridColumn, Me.shiftScheduleMustRunGridColumn, Me.shiftSchedulePriorityLevelGridColumn})
        Me.shiftScheduleGridView.GridControl = Me.shiftScheduleGridControl
        Me.shiftScheduleGridView.Name = "shiftScheduleGridView"
        Me.shiftScheduleGridView.OptionsBehavior.Editable = False
        Me.shiftScheduleGridView.OptionsView.ShowAutoFilterRow = True
        Me.shiftScheduleGridView.OptionsView.ShowDetailButtons = False
        Me.shiftScheduleGridView.OptionsView.ShowFooter = True
        '
        'shiftScheduleMachineNameGridColumn
        '
        Me.shiftScheduleMachineNameGridColumn.Caption = "Machine Name"
        Me.shiftScheduleMachineNameGridColumn.Name = "shiftScheduleMachineNameGridColumn"
        Me.shiftScheduleMachineNameGridColumn.Visible = True
        Me.shiftScheduleMachineNameGridColumn.VisibleIndex = 0
        '
        'shiftSchedulePeopleGridColumn
        '
        Me.shiftSchedulePeopleGridColumn.Caption = "People"
        Me.shiftSchedulePeopleGridColumn.Name = "shiftSchedulePeopleGridColumn"
        Me.shiftSchedulePeopleGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "People", "{0:0.##}")})
        Me.shiftSchedulePeopleGridColumn.Visible = True
        Me.shiftSchedulePeopleGridColumn.VisibleIndex = 1
        '
        'shiftScheduleOperatorGridColumn
        '
        Me.shiftScheduleOperatorGridColumn.Caption = "Operator"
        Me.shiftScheduleOperatorGridColumn.Name = "shiftScheduleOperatorGridColumn"
        Me.shiftScheduleOperatorGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Operator", "{0:0.##}")})
        Me.shiftScheduleOperatorGridColumn.Visible = True
        Me.shiftScheduleOperatorGridColumn.VisibleIndex = 2
        '
        'shiftScheduleItemCodeGridColumn
        '
        Me.shiftScheduleItemCodeGridColumn.Caption = "Item Code"
        Me.shiftScheduleItemCodeGridColumn.Name = "shiftScheduleItemCodeGridColumn"
        Me.shiftScheduleItemCodeGridColumn.Visible = True
        Me.shiftScheduleItemCodeGridColumn.VisibleIndex = 3
        '
        'shiftScheduleItemDescriptionGridColumn
        '
        Me.shiftScheduleItemDescriptionGridColumn.Caption = "Item Description"
        Me.shiftScheduleItemDescriptionGridColumn.Name = "shiftScheduleItemDescriptionGridColumn"
        Me.shiftScheduleItemDescriptionGridColumn.Visible = True
        Me.shiftScheduleItemDescriptionGridColumn.VisibleIndex = 4
        '
        'shiftScheduleQuantityGridColumn
        '
        Me.shiftScheduleQuantityGridColumn.Caption = "Quantity"
        Me.shiftScheduleQuantityGridColumn.Name = "shiftScheduleQuantityGridColumn"
        Me.shiftScheduleQuantityGridColumn.Visible = True
        Me.shiftScheduleQuantityGridColumn.VisibleIndex = 5
        '
        'shiftScheduleSchedByQtyGridColumn
        '
        Me.shiftScheduleSchedByQtyGridColumn.Caption = "Sched By Qty"
        Me.shiftScheduleSchedByQtyGridColumn.Name = "shiftScheduleSchedByQtyGridColumn"
        Me.shiftScheduleSchedByQtyGridColumn.Visible = True
        Me.shiftScheduleSchedByQtyGridColumn.VisibleIndex = 6
        '
        'shiftScheduleNoteGridColumn
        '
        Me.shiftScheduleNoteGridColumn.Caption = "Note"
        Me.shiftScheduleNoteGridColumn.Name = "shiftScheduleNoteGridColumn"
        Me.shiftScheduleNoteGridColumn.Visible = True
        Me.shiftScheduleNoteGridColumn.VisibleIndex = 7
        '
        'shiftScheduleMustRunGridColumn
        '
        Me.shiftScheduleMustRunGridColumn.Caption = "Must Run"
        Me.shiftScheduleMustRunGridColumn.Name = "shiftScheduleMustRunGridColumn"
        Me.shiftScheduleMustRunGridColumn.Visible = True
        Me.shiftScheduleMustRunGridColumn.VisibleIndex = 8
        '
        'shiftSchedulePriorityLevelGridColumn
        '
        Me.shiftSchedulePriorityLevelGridColumn.Caption = "Priority Level"
        Me.shiftSchedulePriorityLevelGridColumn.Name = "shiftSchedulePriorityLevelGridColumn"
        Me.shiftSchedulePriorityLevelGridColumn.Visible = True
        Me.shiftSchedulePriorityLevelGridColumn.VisibleIndex = 9
        '
        'refreshShiftScheduleSimpleButton
        '
        Me.refreshShiftScheduleSimpleButton.Location = New System.Drawing.Point(493, 9)
        Me.refreshShiftScheduleSimpleButton.Name = "refreshShiftScheduleSimpleButton"
        Me.refreshShiftScheduleSimpleButton.Size = New System.Drawing.Size(107, 23)
        Me.refreshShiftScheduleSimpleButton.TabIndex = 3
        Me.refreshShiftScheduleSimpleButton.Text = "Refresh"
        '
        'shiftScheduleShiftComboBoxEdit
        '
        Me.shiftScheduleShiftComboBoxEdit.Location = New System.Drawing.Point(346, 11)
        Me.shiftScheduleShiftComboBoxEdit.MenuManager = Me.BarManager1
        Me.shiftScheduleShiftComboBoxEdit.Name = "shiftScheduleShiftComboBoxEdit"
        Me.shiftScheduleShiftComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.shiftScheduleShiftComboBoxEdit.Properties.Items.AddRange(New Object() {"Shift 1", "Shift 2", "Shift 3"})
        Me.shiftScheduleShiftComboBoxEdit.Size = New System.Drawing.Size(125, 20)
        Me.shiftScheduleShiftComboBoxEdit.TabIndex = 2
        '
        'shiftScheduleDateDateEdit
        '
        Me.shiftScheduleDateDateEdit.EditValue = Nothing
        Me.shiftScheduleDateDateEdit.Location = New System.Drawing.Point(177, 11)
        Me.shiftScheduleDateDateEdit.MenuManager = Me.BarManager1
        Me.shiftScheduleDateDateEdit.Name = "shiftScheduleDateDateEdit"
        Me.shiftScheduleDateDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.shiftScheduleDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.shiftScheduleDateDateEdit.Size = New System.Drawing.Size(147, 20)
        Me.shiftScheduleDateDateEdit.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(18, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(137, 16)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Select A Day && Shift:"
        '
        'previewWeeklyProductionXtraTabPage
        '
        Me.previewWeeklyProductionXtraTabPage.Controls.Add(Me.weeklyProductionGridControl)
        Me.previewWeeklyProductionXtraTabPage.Name = "previewWeeklyProductionXtraTabPage"
        Me.previewWeeklyProductionXtraTabPage.Size = New System.Drawing.Size(648, 584)
        Me.previewWeeklyProductionXtraTabPage.Text = "Preview Weekly Production"
        '
        'weeklyProductionGridControl
        '
        Me.weeklyProductionGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.weeklyProductionGridControl.Location = New System.Drawing.Point(0, 0)
        Me.weeklyProductionGridControl.MainView = Me.weeklyProductionGridView
        Me.weeklyProductionGridControl.MenuManager = Me.BarManager1
        Me.weeklyProductionGridControl.Name = "weeklyProductionGridControl"
        Me.weeklyProductionGridControl.Size = New System.Drawing.Size(648, 584)
        Me.weeklyProductionGridControl.TabIndex = 0
        Me.weeklyProductionGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.weeklyProductionGridView})
        '
        'weeklyProductionGridView
        '
        Me.weeklyProductionGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.weeklyProductionProductionWeekGridColumn, Me.weeklyProductionItemCodeGridColumn, Me.weeklyProductionItemDescriptionGridColumn, Me.weeklyProductionCasesRequiredGridColumn, Me.weeklyProductionBagsRequiredGridColumn, Me.weeklyProductionMondayGridColumn, Me.weeklyProductionTuesdayGridColumn, Me.weeklyProductionWednesdayGridColumn, Me.weeklyProductionThursdayGridColumn, Me.weeklyProductionFridayGridColumn, Me.weeklyProductionSaturdayGridColumn, Me.weeklyProductionSundayGridColumn, Me.weeklyProductionTotalProducedWeeklyGridColumn, Me.weeklyProductionTotalProducedGridColumn, Me.weeklyProductionPercentageCompleteGridColumn})
        Me.weeklyProductionGridView.GridControl = Me.weeklyProductionGridControl
        Me.weeklyProductionGridView.GroupCount = 1
        Me.weeklyProductionGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalProducedWeek", Nothing, "Produced = {0:0.##}")})
        Me.weeklyProductionGridView.Name = "weeklyProductionGridView"
        Me.weeklyProductionGridView.OptionsBehavior.Editable = False
        Me.weeklyProductionGridView.OptionsView.ShowAutoFilterRow = True
        Me.weeklyProductionGridView.OptionsView.ShowDetailButtons = False
        Me.weeklyProductionGridView.OptionsView.ShowFooter = True
        Me.weeklyProductionGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.weeklyProductionProductionWeekGridColumn, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'weeklyProductionProductionWeekGridColumn
        '
        Me.weeklyProductionProductionWeekGridColumn.Caption = "Production Week"
        Me.weeklyProductionProductionWeekGridColumn.Name = "weeklyProductionProductionWeekGridColumn"
        Me.weeklyProductionProductionWeekGridColumn.Visible = True
        Me.weeklyProductionProductionWeekGridColumn.VisibleIndex = 0
        '
        'weeklyProductionItemCodeGridColumn
        '
        Me.weeklyProductionItemCodeGridColumn.Caption = "Item Code"
        Me.weeklyProductionItemCodeGridColumn.Name = "weeklyProductionItemCodeGridColumn"
        Me.weeklyProductionItemCodeGridColumn.Visible = True
        Me.weeklyProductionItemCodeGridColumn.VisibleIndex = 0
        '
        'weeklyProductionItemDescriptionGridColumn
        '
        Me.weeklyProductionItemDescriptionGridColumn.Caption = "Item Description"
        Me.weeklyProductionItemDescriptionGridColumn.Name = "weeklyProductionItemDescriptionGridColumn"
        Me.weeklyProductionItemDescriptionGridColumn.Visible = True
        Me.weeklyProductionItemDescriptionGridColumn.VisibleIndex = 1
        '
        'weeklyProductionCasesRequiredGridColumn
        '
        Me.weeklyProductionCasesRequiredGridColumn.Caption = "Cases Required"
        Me.weeklyProductionCasesRequiredGridColumn.Name = "weeklyProductionCasesRequiredGridColumn"
        Me.weeklyProductionCasesRequiredGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:0.00}")})
        Me.weeklyProductionCasesRequiredGridColumn.Visible = True
        Me.weeklyProductionCasesRequiredGridColumn.VisibleIndex = 2
        '
        'weeklyProductionBagsRequiredGridColumn
        '
        Me.weeklyProductionBagsRequiredGridColumn.Caption = "Bags Required"
        Me.weeklyProductionBagsRequiredGridColumn.Name = "weeklyProductionBagsRequiredGridColumn"
        Me.weeklyProductionBagsRequiredGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:0.00}")})
        Me.weeklyProductionBagsRequiredGridColumn.Visible = True
        Me.weeklyProductionBagsRequiredGridColumn.VisibleIndex = 3
        '
        'weeklyProductionMondayGridColumn
        '
        Me.weeklyProductionMondayGridColumn.Caption = "Monday"
        Me.weeklyProductionMondayGridColumn.Name = "weeklyProductionMondayGridColumn"
        Me.weeklyProductionMondayGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:0.00}")})
        Me.weeklyProductionMondayGridColumn.Visible = True
        Me.weeklyProductionMondayGridColumn.VisibleIndex = 4
        '
        'weeklyProductionTuesdayGridColumn
        '
        Me.weeklyProductionTuesdayGridColumn.Caption = "Tuesday"
        Me.weeklyProductionTuesdayGridColumn.Name = "weeklyProductionTuesdayGridColumn"
        Me.weeklyProductionTuesdayGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:0.00}")})
        Me.weeklyProductionTuesdayGridColumn.Visible = True
        Me.weeklyProductionTuesdayGridColumn.VisibleIndex = 5
        '
        'weeklyProductionWednesdayGridColumn
        '
        Me.weeklyProductionWednesdayGridColumn.Caption = "Wednesday"
        Me.weeklyProductionWednesdayGridColumn.Name = "weeklyProductionWednesdayGridColumn"
        Me.weeklyProductionWednesdayGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:0.00}")})
        Me.weeklyProductionWednesdayGridColumn.Visible = True
        Me.weeklyProductionWednesdayGridColumn.VisibleIndex = 6
        '
        'weeklyProductionThursdayGridColumn
        '
        Me.weeklyProductionThursdayGridColumn.Caption = "Thursday"
        Me.weeklyProductionThursdayGridColumn.Name = "weeklyProductionThursdayGridColumn"
        Me.weeklyProductionThursdayGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:0.00}")})
        Me.weeklyProductionThursdayGridColumn.Visible = True
        Me.weeklyProductionThursdayGridColumn.VisibleIndex = 7
        '
        'weeklyProductionFridayGridColumn
        '
        Me.weeklyProductionFridayGridColumn.Caption = "Friday"
        Me.weeklyProductionFridayGridColumn.Name = "weeklyProductionFridayGridColumn"
        Me.weeklyProductionFridayGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:0.00}")})
        Me.weeklyProductionFridayGridColumn.Visible = True
        Me.weeklyProductionFridayGridColumn.VisibleIndex = 8
        '
        'weeklyProductionSaturdayGridColumn
        '
        Me.weeklyProductionSaturdayGridColumn.Caption = "Saturday"
        Me.weeklyProductionSaturdayGridColumn.Name = "weeklyProductionSaturdayGridColumn"
        Me.weeklyProductionSaturdayGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:0.00}")})
        Me.weeklyProductionSaturdayGridColumn.Visible = True
        Me.weeklyProductionSaturdayGridColumn.VisibleIndex = 9
        '
        'weeklyProductionSundayGridColumn
        '
        Me.weeklyProductionSundayGridColumn.Caption = "Sunday"
        Me.weeklyProductionSundayGridColumn.Name = "weeklyProductionSundayGridColumn"
        Me.weeklyProductionSundayGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:0.00}")})
        Me.weeklyProductionSundayGridColumn.Visible = True
        Me.weeklyProductionSundayGridColumn.VisibleIndex = 10
        '
        'weeklyProductionTotalProducedWeeklyGridColumn
        '
        Me.weeklyProductionTotalProducedWeeklyGridColumn.Caption = "Total Week Production"
        Me.weeklyProductionTotalProducedWeeklyGridColumn.Name = "weeklyProductionTotalProducedWeeklyGridColumn"
        Me.weeklyProductionTotalProducedWeeklyGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:0.00}")})
        Me.weeklyProductionTotalProducedWeeklyGridColumn.Visible = True
        Me.weeklyProductionTotalProducedWeeklyGridColumn.VisibleIndex = 11
        '
        'weeklyProductionTotalProducedGridColumn
        '
        Me.weeklyProductionTotalProducedGridColumn.Caption = "Total Produced"
        Me.weeklyProductionTotalProducedGridColumn.Name = "weeklyProductionTotalProducedGridColumn"
        Me.weeklyProductionTotalProducedGridColumn.Visible = True
        Me.weeklyProductionTotalProducedGridColumn.VisibleIndex = 12
        '
        'weeklyProductionPercentageCompleteGridColumn
        '
        Me.weeklyProductionPercentageCompleteGridColumn.Caption = "Total Percentage Complete"
        Me.weeklyProductionPercentageCompleteGridColumn.DisplayFormat.FormatString = "P"
        Me.weeklyProductionPercentageCompleteGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.weeklyProductionPercentageCompleteGridColumn.Name = "weeklyProductionPercentageCompleteGridColumn"
        Me.weeklyProductionPercentageCompleteGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "", "{0:P}")})
        Me.weeklyProductionPercentageCompleteGridColumn.Visible = True
        Me.weeklyProductionPercentageCompleteGridColumn.VisibleIndex = 13
        '
        'previewProjBomAvailXtraTabPage
        '
        Me.previewProjBomAvailXtraTabPage.Controls.Add(Me.lblNededBy)
        Me.previewProjBomAvailXtraTabPage.Controls.Add(Me.neededBy)
        Me.previewProjBomAvailXtraTabPage.Controls.Add(Me.ProjBomAvailGridControl)
        Me.previewProjBomAvailXtraTabPage.Name = "previewProjBomAvailXtraTabPage"
        Me.previewProjBomAvailXtraTabPage.Size = New System.Drawing.Size(648, 584)
        Me.previewProjBomAvailXtraTabPage.Text = "Preview Project Bom Availibility"
        '
        'lblNededBy
        '
        Me.lblNededBy.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.lblNededBy.Appearance.Options.UseBackColor = True
        Me.lblNededBy.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lblNededBy.Location = New System.Drawing.Point(282, 6)
        Me.lblNededBy.Name = "lblNededBy"
        Me.lblNededBy.Size = New System.Drawing.Size(52, 13)
        Me.lblNededBy.TabIndex = 2
        Me.lblNededBy.Text = "Needed By"
        '
        'neededBy
        '
        Me.neededBy.EditValue = Nothing
        Me.neededBy.Location = New System.Drawing.Point(340, 3)
        Me.neededBy.MenuManager = Me.BarManager1
        Me.neededBy.Name = "neededBy"
        Me.neededBy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.neededBy.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.neededBy.Size = New System.Drawing.Size(100, 20)
        Me.neededBy.TabIndex = 1
        '
        'ProjBomAvailGridControl
        '
        Me.ProjBomAvailGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProjBomAvailGridControl.Location = New System.Drawing.Point(0, 0)
        Me.ProjBomAvailGridControl.MainView = Me.ProjBomAvailGridView
        Me.ProjBomAvailGridControl.MenuManager = Me.BarManager1
        Me.ProjBomAvailGridControl.Name = "ProjBomAvailGridControl"
        Me.ProjBomAvailGridControl.Size = New System.Drawing.Size(648, 584)
        Me.ProjBomAvailGridControl.TabIndex = 0
        Me.ProjBomAvailGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.ProjBomAvailGridView})
        '
        'ProjBomAvailGridView
        '
        Me.ProjBomAvailGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ProjBomAvailCustPOGridColumn, Me.ProjBomAvailCustNameGridColumn, Me.ProjBomAvailItemCodeGridColumn, Me.ProjBomAvailItemDescriptionGridColumn, Me.ProjBomAvailItemTypeGridColumn, Me.ProjBomAvailTotalAmtNeededGridColumn, Me.ProjBomAvailLocalQtyGridColumn, Me.ProjBomLocalShortageGridColumn, Me.ProjBomAvailNonLocalQtyGridColumn, Me.ProjBomAvailNonLocalPalletsQtyGridColumn, Me.ProjBomAvailQtyOnHndGridColumn, Me.ProjBomAvailQtyShortageGridColumn})
        Me.ProjBomAvailGridView.GridControl = Me.ProjBomAvailGridControl
        Me.ProjBomAvailGridView.Name = "ProjBomAvailGridView"
        Me.ProjBomAvailGridView.OptionsBehavior.Editable = False
        Me.ProjBomAvailGridView.OptionsView.ShowAutoFilterRow = True
        Me.ProjBomAvailGridView.OptionsView.ShowDetailButtons = False
        '
        'ProjBomAvailCustPOGridColumn
        '
        Me.ProjBomAvailCustPOGridColumn.Caption = "Customer PO"
        Me.ProjBomAvailCustPOGridColumn.Name = "ProjBomAvailCustPOGridColumn"
        Me.ProjBomAvailCustPOGridColumn.Visible = True
        Me.ProjBomAvailCustPOGridColumn.VisibleIndex = 0
        Me.ProjBomAvailCustPOGridColumn.Width = 90
        '
        'ProjBomAvailItemCodeGridColumn
        '
        Me.ProjBomAvailItemCodeGridColumn.Caption = "Item Code"
        Me.ProjBomAvailItemCodeGridColumn.Name = "ProjBomAvailItemCodeGridColumn"
        Me.ProjBomAvailItemCodeGridColumn.Visible = True
        Me.ProjBomAvailItemCodeGridColumn.VisibleIndex = 2
        Me.ProjBomAvailItemCodeGridColumn.Width = 53
        '
        'ProjBomAvailItemDescriptionGridColumn
        '
        Me.ProjBomAvailItemDescriptionGridColumn.Caption = "Item Description"
        Me.ProjBomAvailItemDescriptionGridColumn.Name = "ProjBomAvailItemDescriptionGridColumn"
        Me.ProjBomAvailItemDescriptionGridColumn.Visible = True
        Me.ProjBomAvailItemDescriptionGridColumn.VisibleIndex = 3
        Me.ProjBomAvailItemDescriptionGridColumn.Width = 53
        '
        'ProjBomAvailItemTypeGridColumn
        '
        Me.ProjBomAvailItemTypeGridColumn.Caption = "Item Type"
        Me.ProjBomAvailItemTypeGridColumn.Name = "ProjBomAvailItemTypeGridColumn"
        Me.ProjBomAvailItemTypeGridColumn.Visible = True
        Me.ProjBomAvailItemTypeGridColumn.VisibleIndex = 4
        Me.ProjBomAvailItemTypeGridColumn.Width = 53
        '
        'ProjBomAvailTotalAmtNeededGridColumn
        '
        Me.ProjBomAvailTotalAmtNeededGridColumn.Caption = "Required Qty"
        Me.ProjBomAvailTotalAmtNeededGridColumn.DisplayFormat.FormatString = "{0:#,##0.00####}"
        Me.ProjBomAvailTotalAmtNeededGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ProjBomAvailTotalAmtNeededGridColumn.Name = "ProjBomAvailTotalAmtNeededGridColumn"
        Me.ProjBomAvailTotalAmtNeededGridColumn.Visible = True
        Me.ProjBomAvailTotalAmtNeededGridColumn.VisibleIndex = 5
        Me.ProjBomAvailTotalAmtNeededGridColumn.Width = 53
        '
        'ProjBomAvailLocalQtyGridColumn
        '
        Me.ProjBomAvailLocalQtyGridColumn.Caption = "LOCAL Qty On Hand"
        Me.ProjBomAvailLocalQtyGridColumn.DisplayFormat.FormatString = "{0:#,##0.00####}"
        Me.ProjBomAvailLocalQtyGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ProjBomAvailLocalQtyGridColumn.Name = "ProjBomAvailLocalQtyGridColumn"
        Me.ProjBomAvailLocalQtyGridColumn.Visible = True
        Me.ProjBomAvailLocalQtyGridColumn.VisibleIndex = 6
        Me.ProjBomAvailLocalQtyGridColumn.Width = 53
        '
        'ProjBomLocalShortageGridColumn
        '
        Me.ProjBomLocalShortageGridColumn.Caption = "LOCAL Shortage"
        Me.ProjBomLocalShortageGridColumn.DisplayFormat.FormatString = "{0:#,##0.00####}"
        Me.ProjBomLocalShortageGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ProjBomLocalShortageGridColumn.Name = "ProjBomLocalShortageGridColumn"
        Me.ProjBomLocalShortageGridColumn.Visible = True
        Me.ProjBomLocalShortageGridColumn.VisibleIndex = 7
        Me.ProjBomLocalShortageGridColumn.Width = 53
        '
        'ProjBomAvailNonLocalQtyGridColumn
        '
        Me.ProjBomAvailNonLocalQtyGridColumn.Caption = "NON-LOCAL Qty On Hand"
        Me.ProjBomAvailNonLocalQtyGridColumn.DisplayFormat.FormatString = "{0:#,##0.00####}"
        Me.ProjBomAvailNonLocalQtyGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ProjBomAvailNonLocalQtyGridColumn.Name = "ProjBomAvailNonLocalQtyGridColumn"
        Me.ProjBomAvailNonLocalQtyGridColumn.Visible = True
        Me.ProjBomAvailNonLocalQtyGridColumn.VisibleIndex = 8
        Me.ProjBomAvailNonLocalQtyGridColumn.Width = 53
        '
        'ProjBomAvailNonLocalPalletsQtyGridColumn
        '
        Me.ProjBomAvailNonLocalPalletsQtyGridColumn.Caption = "LOCAL Shortage - Pallets"
        Me.ProjBomAvailNonLocalPalletsQtyGridColumn.DisplayFormat.FormatString = "{0:#,##0.00####}"
        Me.ProjBomAvailNonLocalPalletsQtyGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ProjBomAvailNonLocalPalletsQtyGridColumn.Name = "ProjBomAvailNonLocalPalletsQtyGridColumn"
        Me.ProjBomAvailNonLocalPalletsQtyGridColumn.Visible = True
        Me.ProjBomAvailNonLocalPalletsQtyGridColumn.VisibleIndex = 9
        Me.ProjBomAvailNonLocalPalletsQtyGridColumn.Width = 53
        '
        'ProjBomAvailQtyOnHndGridColumn
        '
        Me.ProjBomAvailQtyOnHndGridColumn.Caption = "TOTAL Qty On Hand"
        Me.ProjBomAvailQtyOnHndGridColumn.DisplayFormat.FormatString = "{0:#,##0.00####}"
        Me.ProjBomAvailQtyOnHndGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ProjBomAvailQtyOnHndGridColumn.Name = "ProjBomAvailQtyOnHndGridColumn"
        Me.ProjBomAvailQtyOnHndGridColumn.Visible = True
        Me.ProjBomAvailQtyOnHndGridColumn.VisibleIndex = 10
        Me.ProjBomAvailQtyOnHndGridColumn.Width = 53
        '
        'ProjBomAvailQtyShortageGridColumn
        '
        Me.ProjBomAvailQtyShortageGridColumn.Caption = "TOTAL Shortage"
        Me.ProjBomAvailQtyShortageGridColumn.DisplayFormat.FormatString = "{0:#,##0.00####}"
        Me.ProjBomAvailQtyShortageGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ProjBomAvailQtyShortageGridColumn.Name = "ProjBomAvailQtyShortageGridColumn"
        Me.ProjBomAvailQtyShortageGridColumn.Visible = True
        Me.ProjBomAvailQtyShortageGridColumn.VisibleIndex = 11
        Me.ProjBomAvailQtyShortageGridColumn.Width = 63
        '
        'previewProductionBillingXtraTabPage
        '
        Me.previewProductionBillingXtraTabPage.Controls.Add(Me.previewProductionBillingGridControl)
        Me.previewProductionBillingXtraTabPage.Name = "previewProductionBillingXtraTabPage"
        Me.previewProductionBillingXtraTabPage.Size = New System.Drawing.Size(648, 584)
        Me.previewProductionBillingXtraTabPage.Text = "Preview Production Billing"
        '
        'previewProductionBillingGridControl
        '
        Me.previewProductionBillingGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.previewProductionBillingGridControl.Location = New System.Drawing.Point(0, 0)
        Me.previewProductionBillingGridControl.MainView = Me.previewProductionBillingGridView
        Me.previewProductionBillingGridControl.MenuManager = Me.BarManager1
        Me.previewProductionBillingGridControl.Name = "previewProductionBillingGridControl"
        Me.previewProductionBillingGridControl.Size = New System.Drawing.Size(648, 584)
        Me.previewProductionBillingGridControl.TabIndex = 0
        Me.previewProductionBillingGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.previewProductionBillingGridView})
        '
        'previewProductionBillingGridView
        '
        Me.previewProductionBillingGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.productionBillingDateGridColumn, Me.productionBillingCustomerGridColumn, Me.productionBillingItemCodeGridColumn, Me.productionBillingItemDescriptionGridColumn, Me.productionBillingItemTypeGridColumn, Me.productionBillingShiftGridColumn, Me.productionBillingPOGridColumn, Me.productionBillingUOMGridColumn, Me.productionBillingQuantityGridColumn, Me.productionBillingCasesGridColumn, Me.productionBillingPriceGridColumn})
        Me.previewProductionBillingGridView.GridControl = Me.previewProductionBillingGridControl
        Me.previewProductionBillingGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Price", Me.productionBillingPriceGridColumn, "{0:c}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cases", Me.productionBillingCasesGridColumn, "{0:f2}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", Me.productionBillingQuantityGridColumn, "{0:#,##0.######}")})
        Me.previewProductionBillingGridView.Name = "previewProductionBillingGridView"
        Me.previewProductionBillingGridView.OptionsBehavior.Editable = False
        Me.previewProductionBillingGridView.OptionsView.ShowAutoFilterRow = True
        Me.previewProductionBillingGridView.OptionsView.ShowDetailButtons = False
        Me.previewProductionBillingGridView.OptionsView.ShowFooter = True
        '
        'productionBillingDateGridColumn
        '
        Me.productionBillingDateGridColumn.Caption = "Production Date"
        Me.productionBillingDateGridColumn.DisplayFormat.FormatString = "g"
        Me.productionBillingDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.productionBillingDateGridColumn.Name = "productionBillingDateGridColumn"
        Me.productionBillingDateGridColumn.Visible = True
        Me.productionBillingDateGridColumn.VisibleIndex = 0
        Me.productionBillingDateGridColumn.Width = 130
        '
        'productionBillingCustomerGridColumn
        '
        Me.productionBillingCustomerGridColumn.Caption = "Customer Name"
        Me.productionBillingCustomerGridColumn.Name = "productionBillingCustomerGridColumn"
        Me.productionBillingCustomerGridColumn.Visible = True
        Me.productionBillingCustomerGridColumn.VisibleIndex = 1
        Me.productionBillingCustomerGridColumn.Width = 49
        '
        'productionBillingItemCodeGridColumn
        '
        Me.productionBillingItemCodeGridColumn.Caption = "Item Code"
        Me.productionBillingItemCodeGridColumn.Name = "productionBillingItemCodeGridColumn"
        Me.productionBillingItemCodeGridColumn.Visible = True
        Me.productionBillingItemCodeGridColumn.VisibleIndex = 2
        Me.productionBillingItemCodeGridColumn.Width = 49
        '
        'productionBillingItemDescriptionGridColumn
        '
        Me.productionBillingItemDescriptionGridColumn.Caption = "Item Description"
        Me.productionBillingItemDescriptionGridColumn.Name = "productionBillingItemDescriptionGridColumn"
        Me.productionBillingItemDescriptionGridColumn.Visible = True
        Me.productionBillingItemDescriptionGridColumn.VisibleIndex = 3
        Me.productionBillingItemDescriptionGridColumn.Width = 49
        '
        'productionBillingItemTypeGridColumn
        '
        Me.productionBillingItemTypeGridColumn.Caption = "Item Type"
        Me.productionBillingItemTypeGridColumn.Name = "productionBillingItemTypeGridColumn"
        Me.productionBillingItemTypeGridColumn.Visible = True
        Me.productionBillingItemTypeGridColumn.VisibleIndex = 4
        Me.productionBillingItemTypeGridColumn.Width = 49
        '
        'productionBillingShiftGridColumn
        '
        Me.productionBillingShiftGridColumn.Caption = "Shift"
        Me.productionBillingShiftGridColumn.Name = "productionBillingShiftGridColumn"
        Me.productionBillingShiftGridColumn.Visible = True
        Me.productionBillingShiftGridColumn.VisibleIndex = 5
        Me.productionBillingShiftGridColumn.Width = 49
        '
        'productionBillingPOGridColumn
        '
        Me.productionBillingPOGridColumn.Caption = "PO"
        Me.productionBillingPOGridColumn.Name = "productionBillingPOGridColumn"
        Me.productionBillingPOGridColumn.Visible = True
        Me.productionBillingPOGridColumn.VisibleIndex = 6
        Me.productionBillingPOGridColumn.Width = 49
        '
        'productionBillingUOMGridColumn
        '
        Me.productionBillingUOMGridColumn.Caption = "UOM"
        Me.productionBillingUOMGridColumn.Name = "productionBillingUOMGridColumn"
        Me.productionBillingUOMGridColumn.Visible = True
        Me.productionBillingUOMGridColumn.VisibleIndex = 7
        Me.productionBillingUOMGridColumn.Width = 49
        '
        'productionBillingQuantityGridColumn
        '
        Me.productionBillingQuantityGridColumn.Caption = "Quantity"
        Me.productionBillingQuantityGridColumn.Name = "productionBillingQuantityGridColumn"
        Me.productionBillingQuantityGridColumn.Visible = True
        Me.productionBillingQuantityGridColumn.VisibleIndex = 8
        Me.productionBillingQuantityGridColumn.Width = 49
        '
        'productionBillingCasesGridColumn
        '
        Me.productionBillingCasesGridColumn.Caption = "Cases"
        Me.productionBillingCasesGridColumn.DisplayFormat.FormatString = "f2"
        Me.productionBillingCasesGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.productionBillingCasesGridColumn.Name = "productionBillingCasesGridColumn"
        Me.productionBillingCasesGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cases", "{0:f2}")})
        Me.productionBillingCasesGridColumn.Visible = True
        Me.productionBillingCasesGridColumn.VisibleIndex = 9
        Me.productionBillingCasesGridColumn.Width = 49
        '
        'productionBillingPriceGridColumn
        '
        Me.productionBillingPriceGridColumn.Caption = "Price"
        Me.productionBillingPriceGridColumn.DisplayFormat.FormatString = "c"
        Me.productionBillingPriceGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.productionBillingPriceGridColumn.Name = "productionBillingPriceGridColumn"
        Me.productionBillingPriceGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Price", "{0:c}")})
        Me.productionBillingPriceGridColumn.Visible = True
        Me.productionBillingPriceGridColumn.VisibleIndex = 10
        Me.productionBillingPriceGridColumn.Width = 59
        '
        'previewBaggingXtraTabPage
        '
        Me.previewBaggingXtraTabPage.Controls.Add(Me.baggingReportPivotGridControl)
        Me.previewBaggingXtraTabPage.Name = "previewBaggingXtraTabPage"
        Me.previewBaggingXtraTabPage.Size = New System.Drawing.Size(648, 584)
        Me.previewBaggingXtraTabPage.Text = "Preview Bagging Report"
        '
        'baggingReportPivotGridControl
        '
        Me.baggingReportPivotGridControl.DataSource = Me.baggingReportXpView
        Me.baggingReportPivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.baggingReportPivotGridControl.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldMachineName1, Me.fieldProductionDate1, Me.fieldProductionShift1, Me.fieldQuantity1, Me.reasonsPivotGridField, Me.minutesPivotGridField, Me.fieldItemCode})
        PivotGridGroup1.Fields.Add(Me.fieldMachineName1)
        PivotGridGroup1.Hierarchy = Nothing
        PivotGridGroup1.ShowNewValues = True
        Me.baggingReportPivotGridControl.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {PivotGridGroup1})
        Me.baggingReportPivotGridControl.Location = New System.Drawing.Point(0, 0)
        Me.baggingReportPivotGridControl.Name = "baggingReportPivotGridControl"
        Me.baggingReportPivotGridControl.Size = New System.Drawing.Size(648, 584)
        Me.baggingReportPivotGridControl.TabIndex = 0
        '
        'baggingReportXpView
        '
        Me.baggingReportXpView.ObjectType = GetType(DXDAL.SPGData.Production)
        Me.baggingReportXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("MachineName", DevExpress.Xpo.SortDirection.None, "[ProdMainMachineLine.MachineLineName]", False, True), New DevExpress.Xpo.ViewProperty("ProductionDate", DevExpress.Xpo.SortDirection.None, "[ProdMainDate]", False, True), New DevExpress.Xpo.ViewProperty("ProductionShift", DevExpress.Xpo.SortDirection.None, "[ProdMainShift.ShiftName]", False, True), New DevExpress.Xpo.ViewProperty("Quantity", DevExpress.Xpo.SortDirection.None, "[ProdMainQuantity] * Iif([ProdMainItemID.intQtyPerUnit] > 0, [ProdMainItemID.intQ" &
                    "tyPerUnit], 1)", False, True), New DevExpress.Xpo.ViewProperty("ProductionID", DevExpress.Xpo.SortDirection.None, "[ProdMainID]", False, True), New DevExpress.Xpo.ViewProperty("ProductionStartTime", DevExpress.Xpo.SortDirection.None, "[ProdMainTimeStart]", False, True), New DevExpress.Xpo.ViewProperty("ProductionStopTime", DevExpress.Xpo.SortDirection.None, "[ProdMainTimeStop]", False, True), New DevExpress.Xpo.ViewProperty("ProductionItemID", DevExpress.Xpo.SortDirection.None, "[ProdMainItemID.ItemCode]", False, True)})
        '
        'fieldProductionDate1
        '
        Me.fieldProductionDate1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldProductionDate1.AreaIndex = 0
        Me.fieldProductionDate1.Caption = "Date"
        Me.fieldProductionDate1.CellFormat.FormatString = "d"
        Me.fieldProductionDate1.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldProductionDate1.FieldName = "ProductionDate"
        Me.fieldProductionDate1.Name = "fieldProductionDate1"
        Me.fieldProductionDate1.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
        Me.fieldProductionDate1.TotalCellFormat.FormatString = "d"
        Me.fieldProductionDate1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldProductionDate1.TotalValueFormat.FormatString = "d"
        Me.fieldProductionDate1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fieldProductionDate1.UnboundFieldName = "fieldProductionDate1"
        Me.fieldProductionDate1.ValueFormat.FormatString = "d"
        Me.fieldProductionDate1.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        '
        'fieldProductionShift1
        '
        Me.fieldProductionShift1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.fieldProductionShift1.AreaIndex = 1
        Me.fieldProductionShift1.Caption = "Shift"
        Me.fieldProductionShift1.FieldName = "ProductionShift"
        Me.fieldProductionShift1.Name = "fieldProductionShift1"
        Me.fieldProductionShift1.Width = 75
        '
        'fieldQuantity1
        '
        Me.fieldQuantity1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.fieldQuantity1.AreaIndex = 0
        Me.fieldQuantity1.Caption = "Quantity"
        Me.fieldQuantity1.CellFormat.FormatString = "#,#"
        Me.fieldQuantity1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldQuantity1.FieldName = "Quantity"
        Me.fieldQuantity1.GrandTotalCellFormat.FormatString = "#,#"
        Me.fieldQuantity1.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldQuantity1.Name = "fieldQuantity1"
        Me.fieldQuantity1.TotalCellFormat.FormatString = "#,#"
        Me.fieldQuantity1.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldQuantity1.TotalValueFormat.FormatString = "#,#"
        Me.fieldQuantity1.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldQuantity1.ValueFormat.FormatString = "f2"
        Me.fieldQuantity1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.fieldQuantity1.Width = 75
        '
        'reasonsPivotGridField
        '
        Me.reasonsPivotGridField.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.reasonsPivotGridField.AreaIndex = 1
        Me.reasonsPivotGridField.Caption = "Reasons"
        Me.reasonsPivotGridField.Name = "reasonsPivotGridField"
        Me.reasonsPivotGridField.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Custom
        Me.reasonsPivotGridField.TotalsVisibility = DevExpress.XtraPivotGrid.PivotTotalsVisibility.None
        Me.reasonsPivotGridField.UnboundFieldName = "reasons"
        Me.reasonsPivotGridField.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.reasonsPivotGridField.Width = 50
        '
        'minutesPivotGridField
        '
        Me.minutesPivotGridField.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.minutesPivotGridField.AreaIndex = 2
        Me.minutesPivotGridField.Caption = "Minutes"
        Me.minutesPivotGridField.CellFormat.FormatString = "#"
        Me.minutesPivotGridField.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.minutesPivotGridField.GrandTotalCellFormat.FormatString = "f2"
        Me.minutesPivotGridField.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.minutesPivotGridField.Name = "minutesPivotGridField"
        Me.minutesPivotGridField.TotalCellFormat.FormatString = "#"
        Me.minutesPivotGridField.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.minutesPivotGridField.TotalValueFormat.FormatString = "f2"
        Me.minutesPivotGridField.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.minutesPivotGridField.UnboundFieldName = "minutes"
        Me.minutesPivotGridField.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.minutesPivotGridField.ValueFormat.FormatString = "f2"
        Me.minutesPivotGridField.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.minutesPivotGridField.Width = 75
        '
        'fieldItemCode
        '
        Me.fieldItemCode.AreaIndex = 0
        Me.fieldItemCode.Caption = "Item #"
        Me.fieldItemCode.FieldName = "ProductionItemID"
        Me.fieldItemCode.Name = "fieldItemCode"
        '
        'ProjBomAvailCustNameGridColumn
        '
        Me.ProjBomAvailCustNameGridColumn.Caption = "Customer Name"
        Me.ProjBomAvailCustNameGridColumn.Name = "ProjBomAvailCustNameGridColumn"
        Me.ProjBomAvailCustNameGridColumn.Visible = True
        Me.ProjBomAvailCustNameGridColumn.VisibleIndex = 1
        '
        'QuickReportsXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 684)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "QuickReportsXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Reports"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.quickReportsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quickReportsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reportsXtraTabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.reportsXtraTabControl.ResumeLayout(False)
        Me.previewCustoemrsXtraTabPage.ResumeLayout(False)
        CType(Me.previewGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.previewGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.previewProductionEntriesXtraTabPage.ResumeLayout(False)
        CType(Me.previewProductionEntriesGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.previewProductionEntriesGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.previewLpnStatusXtraTabPage.ResumeLayout(False)
        CType(Me.previewLpnStatusGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.previewLpnStatusGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.previewCurrentRMInventoryXtraTabPage.ResumeLayout(False)
        CType(Me.previewCurrentRMInventoryGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.previewCurrentRMInventoryGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.previewCurrentInventoryXtraTabPage.ResumeLayout(False)
        Me.previewCurrentInventoryXtraTabPage.PerformLayout()
        CType(Me.outOfStockItemsCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.currentInventoryInactiveItemsCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.currentInventoryInactiveCustomersCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.previewCurrentInventoryGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.previewCurrentInventoryGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.previewLocationTransfersXtraTabPage.ResumeLayout(False)
        CType(Me.previewLocationTransfersGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.previewLocationTransfersGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.previewShiftScheduleXtraTabPage.ResumeLayout(False)
        Me.previewShiftScheduleXtraTabPage.PerformLayout()
        CType(Me.shiftScheduleGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shiftScheduleGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shiftScheduleShiftComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shiftScheduleDateDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shiftScheduleDateDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.previewWeeklyProductionXtraTabPage.ResumeLayout(False)
        CType(Me.weeklyProductionGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.weeklyProductionGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.previewProjBomAvailXtraTabPage.ResumeLayout(False)
        Me.previewProjBomAvailXtraTabPage.PerformLayout()
        CType(Me.neededBy.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.neededBy.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjBomAvailGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjBomAvailGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.previewProductionBillingXtraTabPage.ResumeLayout(False)
        CType(Me.previewProductionBillingGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.previewProductionBillingGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.previewBaggingXtraTabPage.ResumeLayout(False)
        CType(Me.baggingReportPivotGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.baggingReportXpView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents customersMenuBar As DevExpress.XtraBars.Bar
    Friend WithEvents printBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents quickReportsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents quickReportsGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents reportNameGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents reportCodeNameGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents reportTypeGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents reportsXtraTabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents filterXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents previewCustoemrsXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents previewGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents previewGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nameGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents contactNameGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents addressGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cityGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents stateGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents postalGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents phoneGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents faxGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents emailGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents inactiveGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents filterReportGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents exportXLSBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents exportSaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents dateFilterGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customerFilterGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents itemFilterGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lotFilterGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents poFilterGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents machineFilterGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shiftFilterGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bolFilterGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dnFilterGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents destinationFilterGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents carrierFilterGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents vendorFilterGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents itemTypeFilterGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents outOfStockFilterGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents previewProductionEntriesXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents previewProductionEntriesGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents previewProductionEntriesGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents productionDateGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customerNameGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents itemNumberGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents itemDescriptionGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shiftGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents quantityGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents poGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lotGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents palletNumberGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lpnNumberGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents expirationDateGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents expirationDateFormatGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents previewLpnStatusXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents previewLpnStatusGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents previewLpnStatusGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lpnProductionDateGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lpnCustomerNameGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lpnItemCodeGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lpnItemDescriptionGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lpnQuantityGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lpnShippingBolGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents fullLpnGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lpnShippingDateGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents previewCurrentRMInventoryXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents previewCurrentRMInventoryGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents previewCurrentRMInventoryGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents rmInventoryCustomerNameGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rmInventoryIemCodeGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rmInventoryItemDescriptionGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rmInventoryQtyOnHandGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rmInventoryInactiveGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rmInventoryItemIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rmInventoryLocationGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents previewCurrentInventoryXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents previewCurrentInventoryGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents previewCurrentInventoryGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents currentInventoryCustomerNameGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents currentInventoryItemCodeGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents currentInventoryItemDescriptionGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents currentInventoryItemTypeGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents currentInventoryQuantityOnHandGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents currentInventoryInventoryByPalletsGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents currentInventoryUOMGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents currentInventoryLocationGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents refreshSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents outOfStockItemsCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents currentInventoryInactiveItemsCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents currentInventoryInactiveCustomersCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents previewLocationTransfersXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents previewLocationTransfersGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents previewLocationTransfersGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents locationTransfersDateGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents locationTransferFromLocationGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents locationTransferToLocationGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents locationTransferItemCodeGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents locationTransferItemDescriptionGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents locationTransferNumberGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents locationTransferItemLotGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents locationTransferExpirationDateGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents locationTransferQuantityGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents locationTransferExpirationDateFormatGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents locationTransferPalletsGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents locationTransferUnitsGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents locationTransferCarrierGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents noteGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents previewShiftScheduleXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents shiftScheduleGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents shiftScheduleGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents refreshShiftScheduleSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents shiftScheduleShiftComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents shiftScheduleDateDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents shiftScheduleMachineNameGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shiftSchedulePeopleGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shiftScheduleOperatorGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shiftScheduleItemCodeGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shiftScheduleItemDescriptionGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shiftScheduleNoteGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shiftScheduleMustRunGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shiftSchedulePriorityLevelGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shiftScheduleQuantityGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shiftScheduleSchedByQtyGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents previewWeeklyProductionXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents weeklyProductionGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents weeklyProductionGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents weeklyProductionItemCodeGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents weeklyProductionItemDescriptionGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents weeklyProductionCasesRequiredGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents weeklyProductionBagsRequiredGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents weeklyProductionMondayGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents weeklyProductionTuesdayGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents weeklyProductionWednesdayGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents weeklyProductionThursdayGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents weeklyProductionFridayGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents weeklyProductionSaturdayGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents weeklyProductionSundayGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents weeklyProductionTotalProducedGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents weeklyProductionPercentageCompleteGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents itemTypeGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents previewProjBomAvailXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents ProjBomAvailGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents ProjBomAvailGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ProjBomAvailCustPOGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProjBomAvailItemCodeGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProjBomAvailItemDescriptionGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProjBomAvailItemTypeGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProjBomAvailQtyOnHndGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProjBomAvailQtyShortageGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents previewProductionBillingXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents previewProductionBillingGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents previewProductionBillingGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents productionBillingDateGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents productionBillingCustomerGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents productionBillingItemCodeGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents productionBillingItemDescriptionGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents productionBillingItemTypeGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents productionBillingShiftGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents productionBillingPOGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents productionBillingUOMGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents productionBillingQuantityGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents productionBillingCasesGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents productionBillingPriceGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents weeklyProductionProductionWeekGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents weeklyProductionTotalProducedWeeklyGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProjBomAvailTotalAmtNeededGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents previewBaggingXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents baggingReportPivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents baggingReportXpView As DevExpress.Xpo.XPView
    Friend WithEvents fieldMachineName1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProductionDate1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldProductionShift1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents fieldQuantity1 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents reasonsPivotGridField As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents minutesPivotGridField As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ProjBomAvailLocalQtyGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProjBomLocalShortageGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProjBomAvailNonLocalQtyGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProjBomAvailNonLocalPalletsQtyGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents neededBy As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lblNededBy As DevExpress.XtraEditors.LabelControl
    Friend WithEvents fieldItemCode As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents ProjBomAvailCustNameGridColumn As DevExpress.XtraGrid.Columns.GridColumn
End Class
