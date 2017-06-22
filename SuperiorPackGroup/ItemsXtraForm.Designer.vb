<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemsXtraForm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ItemsXtraForm))
        Me.poolDetailsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.poolBomGridControl = New DevExpress.XtraGrid.GridControl()
        Me.poolBomXpCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.poolBomGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.poolBomDeleteGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.poolBomDeleteRepositoryItemButtonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.poolIdGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.poolsRepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.itemPoolsXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPoolBomQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colScrapFactor = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.itemsMenuBar = New DevExpress.XtraBars.Bar()
        Me.addBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.editBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.deleteBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.cancelBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.saveBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.palletTicketBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.specificationsBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.printGridBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.customerFilterLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.itemsXtraTabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.generalXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl38 = New DevExpress.XtraEditors.LabelControl()
        Me.minutesPerShiftTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.lotCodeFormatLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.lotCodeFormatsXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl()
        Me.requiresExpirationDateCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.requiresLotCodeCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.generateLotCodesCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl36 = New DevExpress.XtraEditors.LabelControl()
        Me.bagsPerCaseTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.inventoryGridControl = New DevExpress.XtraGrid.GridControl()
        Me.inventoryXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.inventoryGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colLocationCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocationName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.upcTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.packersTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.ProjectedPackersLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.inactiveCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.caseGrossWeightTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.qtyOnHandTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.uomLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.qtyPerUnitTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.unitsPerPalletTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.casesPerPalletTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.unitsPerCaseTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.standardProductionTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.codeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.defaultMachineLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.machineLineXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.customerLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.typeLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.descriptionMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.shippingXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.shippingGridControl = New DevExpress.XtraGrid.GridControl()
        Me.shippingGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.shippingDetailIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shippingIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shippingDateGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shippingBOLGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shippingLotGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shippingQuantityGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shippingExpirationDateGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.productionXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.productionGridControl = New DevExpress.XtraGrid.GridControl()
        Me.productionGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.productionDateGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.productionLotGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.productionPOGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.productionQuantityGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.productionExpirationDateGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.receivingXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.receivingsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.receivingsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.receivingDetailIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.receivingIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.receivingLotGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.receivingQuantityGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.receivingDateGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.receivingBOLGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.receivingExpirationDateGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.bomXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.bomGridControl = New DevExpress.XtraGrid.GridControl()
        Me.BOMGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.bomIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.FGItemCodeGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RMItemCodeGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RMRepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.RMItemDescriptionGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RMQuantityGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.scrapFactorGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.deleteGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.deleteRepositoryItemButtonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.availabilityXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.printSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.previewSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.availabilityGridControl = New DevExpress.XtraGrid.GridControl()
        Me.availabilityGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.bomItemCodeGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.bomItemDescriptionGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.quantityOnHandGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.quantityYieldsGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.localQuantityOnHandGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.localQuantityYieldsGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.quantityRequiredGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.availabilityItemIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.scrapPercentageGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.isPoolGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.advancedXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.other5TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.other4TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.other3TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.other2TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.other1TextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.palletsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.stretchWrapTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.boxesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.filmTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.freightTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.rebateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.priceTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.specificationXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl35 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl33 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.palletPatternButtonEdit = New DevExpress.XtraEditors.ButtonEdit()
        Me.instructionsMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.shelfLifeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.layersPerPalletTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.cassesPerLayerTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.mavTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.requiredWeightTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.caseCodeMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.packageCodeMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.shippingReturnXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.shippingReturnGridControl = New DevExpress.XtraGrid.GridControl()
        Me.shippingReturnGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.shippingReturnIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.returnShippingIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shippingReturnDateGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shippingReturnBOLGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shippingReturnLotGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shippingReturnQuantityGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shippingReturnExpirationDateGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.receivingReturnXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.receivingReturnGridControl = New DevExpress.XtraGrid.GridControl()
        Me.receivingReturnGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.receivingReturnIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.returnReceivingIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.receivingReturnLotGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.receivingReturnQuantityGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.receivingReturnDateGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.receivingReturnBolGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.receivingReturnExpirationDateGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.adjustmentXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.adjustmentGridControl = New DevExpress.XtraGrid.GridControl()
        Me.adjustmentGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.adjustmentIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.adjustmentDateGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.adjustmentOriginalQuantityGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.adjustmentNewQtyGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.adjustmentQuantityGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.adjustmentReasonGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.reasonRepositoryItemMemoExEdit = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.transfersXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.transfersGridControl = New DevExpress.XtraGrid.GridControl()
        Me.transfersXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.transfersGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFromLocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colToLocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransferQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnits = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPallets = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemExpirationDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.productionStandardsXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.productionStandardsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.productionStandardsXpCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.productionStandardsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.delProdStdGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.delProdStdRepositoryItemButtonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colOid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHasChanges = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.machineRepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colProductionPerMinute = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMinutesPerShift = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProjectedPackers = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.typeFilterLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.clearFilterSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.patternOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.itemsSearchGridControl = New DevExpress.XtraGrid.GridControl()
        Me.itemSearchXPView = New DevExpress.Xpo.XPView(Me.components)
        Me.itemSearchGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.itemIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.itemCodeGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.itemCustomerGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.itemTypeGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.inactiveSearchCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.poolDetailsGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.poolBomGridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.poolBomXpCollection,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.poolBomGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.poolBomDeleteRepositoryItemButtonEdit,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.poolsRepositoryItemLookUpEdit,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.itemPoolsXpView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BarManager1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.customerFilterLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.itemsXtraTabControl,System.ComponentModel.ISupportInitialize).BeginInit
        Me.itemsXtraTabControl.SuspendLayout
        Me.generalXtraTabPage.SuspendLayout
        CType(Me.minutesPerShiftTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lotCodeFormatLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lotCodeFormatsXpView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.requiresExpirationDateCheckEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.requiresLotCodeCheckEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.generateLotCodesCheckEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.bagsPerCaseTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.inventoryGridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.inventoryXpView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.inventoryGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.upcTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.packersTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.inactiveCheckEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.caseGrossWeightTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.qtyOnHandTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.uomLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.qtyPerUnitTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.unitsPerPalletTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.casesPerPalletTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.unitsPerCaseTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.standardProductionTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.codeTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.defaultMachineLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.machineLineXpView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.customerLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.typeLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.descriptionMemoEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.shippingXtraTabPage.SuspendLayout
        CType(Me.shippingGridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.shippingGridView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.productionXtraTabPage.SuspendLayout
        CType(Me.productionGridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.productionGridView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.receivingXtraTabPage.SuspendLayout
        CType(Me.receivingsGridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.receivingsGridView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.bomXtraTabPage.SuspendLayout
        CType(Me.SplitContainerControl2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainerControl2.SuspendLayout
        CType(Me.bomGridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BOMGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RMRepositoryItemLookUpEdit,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.deleteRepositoryItemButtonEdit,System.ComponentModel.ISupportInitialize).BeginInit
        Me.availabilityXtraTabPage.SuspendLayout
        CType(Me.availabilityGridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.availabilityGridView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.advancedXtraTabPage.SuspendLayout
        CType(Me.other5TextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.other4TextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.other3TextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.other2TextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.other1TextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.palletsTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stretchWrapTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.boxesTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.filmTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.freightTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.rebateTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.priceTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.specificationXtraTabPage.SuspendLayout
        CType(Me.palletPatternButtonEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.instructionsMemoEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.shelfLifeTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.layersPerPalletTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cassesPerLayerTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.mavTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.requiredWeightTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.caseCodeMemoEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.packageCodeMemoEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.shippingReturnXtraTabPage.SuspendLayout
        CType(Me.shippingReturnGridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.shippingReturnGridView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.receivingReturnXtraTabPage.SuspendLayout
        CType(Me.receivingReturnGridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.receivingReturnGridView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.adjustmentXtraTabPage.SuspendLayout
        CType(Me.adjustmentGridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.adjustmentGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.reasonRepositoryItemMemoExEdit,System.ComponentModel.ISupportInitialize).BeginInit
        Me.transfersXtraTabPage.SuspendLayout
        CType(Me.transfersGridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.transfersXpView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.transfersGridView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.productionStandardsXtraTabPage.SuspendLayout
        CType(Me.productionStandardsGridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.productionStandardsXpCollection,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.productionStandardsGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.delProdStdRepositoryItemButtonEdit,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.machineRepositoryItemLookUpEdit,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.typeFilterLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SplitContainerControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainerControl1.SuspendLayout
        CType(Me.itemsSearchGridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.itemSearchXPView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.itemSearchGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.inactiveSearchCheckEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'poolDetailsGridView
        '
        Me.poolDetailsGridView.GridControl = Me.poolBomGridControl
        Me.poolDetailsGridView.Name = "poolDetailsGridView"
        Me.poolDetailsGridView.OptionsBehavior.Editable = false
        '
        'poolBomGridControl
        '
        Me.poolBomGridControl.DataSource = Me.poolBomXpCollection
        Me.poolBomGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode2.LevelTemplate = Me.poolDetailsGridView
        GridLevelNode2.RelationName = "Details"
        GridLevelNode1.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        GridLevelNode1.RelationName = "ItemPoolID"
        Me.poolBomGridControl.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.poolBomGridControl.Location = New System.Drawing.Point(0, 0)
        Me.poolBomGridControl.MainView = Me.poolBomGridView
        Me.poolBomGridControl.MenuManager = Me.BarManager1
        Me.poolBomGridControl.Name = "poolBomGridControl"
        Me.poolBomGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.poolsRepositoryItemLookUpEdit, Me.poolBomDeleteRepositoryItemButtonEdit})
        Me.poolBomGridControl.Size = New System.Drawing.Size(686, 240)
        Me.poolBomGridControl.TabIndex = 2
        Me.poolBomGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.poolBomGridView, Me.poolDetailsGridView})
        '
        'poolBomXpCollection
        '
        Me.poolBomXpCollection.ObjectType = GetType(DXDAL.SPGData.PoolBom)
        '
        'poolBomGridView
        '
        Me.poolBomGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.poolBomDeleteGridColumn, Me.colOid, Me.poolIdGridColumn, Me.GridColumn4, Me.colPoolBomQuantity, Me.colScrapFactor})
        Me.poolBomGridView.GridControl = Me.poolBomGridControl
        Me.poolBomGridView.Name = "poolBomGridView"
        Me.poolBomGridView.OptionsSelection.MultiSelect = true
        Me.poolBomGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.poolBomGridView.OptionsView.ShowDetailButtons = false
        Me.poolBomGridView.OptionsView.ShowGroupPanel = false
        '
        'poolBomDeleteGridColumn
        '
        Me.poolBomDeleteGridColumn.ColumnEdit = Me.poolBomDeleteRepositoryItemButtonEdit
        Me.poolBomDeleteGridColumn.MaxWidth = 25
        Me.poolBomDeleteGridColumn.MinWidth = 25
        Me.poolBomDeleteGridColumn.Name = "poolBomDeleteGridColumn"
        Me.poolBomDeleteGridColumn.OptionsColumn.AllowSize = false
        Me.poolBomDeleteGridColumn.OptionsColumn.FixedWidth = true
        Me.poolBomDeleteGridColumn.Visible = true
        Me.poolBomDeleteGridColumn.VisibleIndex = 0
        Me.poolBomDeleteGridColumn.Width = 38
        '
        'poolBomDeleteRepositoryItemButtonEdit
        '
        Me.poolBomDeleteRepositoryItemButtonEdit.AutoHeight = false
        Me.poolBomDeleteRepositoryItemButtonEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.poolBomDeleteRepositoryItemButtonEdit.Name = "poolBomDeleteRepositoryItemButtonEdit"
        Me.poolBomDeleteRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colOid
        '
        Me.colOid.FieldName = "Oid"
        Me.colOid.Name = "colOid"
        '
        'poolIdGridColumn
        '
        Me.poolIdGridColumn.ColumnEdit = Me.poolsRepositoryItemLookUpEdit
        Me.poolIdGridColumn.FieldName = "ItemPoolID!Key"
        Me.poolIdGridColumn.Name = "poolIdGridColumn"
        Me.poolIdGridColumn.Visible = true
        Me.poolIdGridColumn.VisibleIndex = 1
        Me.poolIdGridColumn.Width = 156
        '
        'poolsRepositoryItemLookUpEdit
        '
        Me.poolsRepositoryItemLookUpEdit.AutoHeight = false
        Me.poolsRepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.poolsRepositoryItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PoolID", "Pool ID", 57, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("PoolCode", "Pool Code", 58, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
        Me.poolsRepositoryItemLookUpEdit.DataSource = Me.itemPoolsXpView
        Me.poolsRepositoryItemLookUpEdit.DisplayMember = "PoolCode"
        Me.poolsRepositoryItemLookUpEdit.Name = "poolsRepositoryItemLookUpEdit"
        Me.poolsRepositoryItemLookUpEdit.NullText = ""
        Me.poolsRepositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup
        Me.poolsRepositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.poolsRepositoryItemLookUpEdit.ValueMember = "PoolID"
        '
        'itemPoolsXpView
        '
        Me.itemPoolsXpView.ObjectType = GetType(DXDAL.SPGData.ItemPool)
        Me.itemPoolsXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("PoolID", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true), New DevExpress.Xpo.ViewProperty("PoolCode", DevExpress.Xpo.SortDirection.None, "[PoolCode]", false, true)})
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "PoolBomFiniGoodID!Key"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'colPoolBomQuantity
        '
        Me.colPoolBomQuantity.FieldName = "PoolBomQuantity"
        Me.colPoolBomQuantity.Name = "colPoolBomQuantity"
        Me.colPoolBomQuantity.Visible = true
        Me.colPoolBomQuantity.VisibleIndex = 2
        Me.colPoolBomQuantity.Width = 156
        '
        'colScrapFactor
        '
        Me.colScrapFactor.DisplayFormat.FormatString = "{0}%"
        Me.colScrapFactor.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colScrapFactor.FieldName = "ScrapFactor"
        Me.colScrapFactor.Name = "colScrapFactor"
        Me.colScrapFactor.Visible = true
        Me.colScrapFactor.VisibleIndex = 3
        Me.colScrapFactor.Width = 200
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.itemsMenuBar, Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.addBarButtonItem, Me.editBarButtonItem, Me.deleteBarButtonItem, Me.cancelBarButtonItem, Me.saveBarButtonItem, Me.palletTicketBarButtonItem, Me.printGridBarButtonItem, Me.specificationsBarButtonItem})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 8
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'itemsMenuBar
        '
        Me.itemsMenuBar.BarName = "Tools"
        Me.itemsMenuBar.DockCol = 0
        Me.itemsMenuBar.DockRow = 1
        Me.itemsMenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.itemsMenuBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.addBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.editBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.cancelBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.saveBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.palletTicketBarButtonItem, true), New DevExpress.XtraBars.LinkPersistInfo(Me.specificationsBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.printGridBarButtonItem)})
        Me.itemsMenuBar.OptionsBar.UseWholeRow = true
        Me.itemsMenuBar.Text = "Tools"
        '
        'addBarButtonItem
        '
        Me.addBarButtonItem.Caption = "&Add Item"
        Me.addBarButtonItem.Id = 0
        Me.addBarButtonItem.Name = "addBarButtonItem"
        '
        'editBarButtonItem
        '
        Me.editBarButtonItem.Caption = "&Edit Item"
        Me.editBarButtonItem.Id = 1
        Me.editBarButtonItem.Name = "editBarButtonItem"
        '
        'deleteBarButtonItem
        '
        Me.deleteBarButtonItem.Caption = "Delete Item"
        Me.deleteBarButtonItem.Id = 2
        Me.deleteBarButtonItem.Name = "deleteBarButtonItem"
        '
        'cancelBarButtonItem
        '
        Me.cancelBarButtonItem.Caption = "&Cancel Changes"
        Me.cancelBarButtonItem.Id = 3
        Me.cancelBarButtonItem.Name = "cancelBarButtonItem"
        '
        'saveBarButtonItem
        '
        Me.saveBarButtonItem.Caption = "&Save Changes"
        Me.saveBarButtonItem.Id = 4
        Me.saveBarButtonItem.Name = "saveBarButtonItem"
        '
        'palletTicketBarButtonItem
        '
        Me.palletTicketBarButtonItem.Caption = "Pallet &Ticket"
        Me.palletTicketBarButtonItem.Id = 5
        Me.palletTicketBarButtonItem.Name = "palletTicketBarButtonItem"
        '
        'specificationsBarButtonItem
        '
        Me.specificationsBarButtonItem.Caption = "Product &Specifications"
        Me.specificationsBarButtonItem.Id = 7
        Me.specificationsBarButtonItem.Name = "specificationsBarButtonItem"
        '
        'printGridBarButtonItem
        '
        Me.printGridBarButtonItem.Caption = "&Print Grid"
        Me.printGridBarButtonItem.Id = 6
        Me.printGridBarButtonItem.Name = "printGridBarButtonItem"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.OptionsBar.MultiLine = true
        Me.Bar2.OptionsBar.UseWholeRow = true
        Me.Bar2.Text = "Main menu"
        Me.Bar2.Visible = false
        '
        'Bar3
        '
        Me.Bar3.BarName = "Status bar"
        Me.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3.DockCol = 0
        Me.Bar3.DockRow = 0
        Me.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3.OptionsBar.AllowQuickCustomization = false
        Me.Bar3.OptionsBar.DrawDragBorder = false
        Me.Bar3.OptionsBar.UseWholeRow = true
        Me.Bar3.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = false
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(947, 49)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = false
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 565)
        Me.barDockControlBottom.Size = New System.Drawing.Size(947, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = false
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 49)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 516)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = false
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(947, 49)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 516)
        '
        'customerFilterLookUpEdit
        '
        Me.customerFilterLookUpEdit.Location = New System.Drawing.Point(39, 3)
        Me.customerFilterLookUpEdit.Name = "customerFilterLookUpEdit"
        Me.customerFilterLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.customerFilterLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.customerFilterLookUpEdit.Properties.NullText = "[Filter by Customer]"
        Me.customerFilterLookUpEdit.Size = New System.Drawing.Size(212, 20)
        Me.customerFilterLookUpEdit.TabIndex = 1
        Me.customerFilterLookUpEdit.Visible = false
        '
        'itemsXtraTabControl
        '
        Me.itemsXtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.itemsXtraTabControl.Location = New System.Drawing.Point(0, 0)
        Me.itemsXtraTabControl.Name = "itemsXtraTabControl"
        Me.itemsXtraTabControl.SelectedTabPage = Me.generalXtraTabPage
        Me.itemsXtraTabControl.Size = New System.Drawing.Size(692, 516)
        Me.itemsXtraTabControl.TabIndex = 2
        Me.itemsXtraTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.generalXtraTabPage, Me.shippingXtraTabPage, Me.productionXtraTabPage, Me.receivingXtraTabPage, Me.bomXtraTabPage, Me.availabilityXtraTabPage, Me.advancedXtraTabPage, Me.specificationXtraTabPage, Me.shippingReturnXtraTabPage, Me.receivingReturnXtraTabPage, Me.adjustmentXtraTabPage, Me.transfersXtraTabPage, Me.productionStandardsXtraTabPage})
        '
        'generalXtraTabPage
        '
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl38)
        Me.generalXtraTabPage.Controls.Add(Me.minutesPerShiftTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.lotCodeFormatLookUpEdit)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl37)
        Me.generalXtraTabPage.Controls.Add(Me.requiresExpirationDateCheckEdit)
        Me.generalXtraTabPage.Controls.Add(Me.requiresLotCodeCheckEdit)
        Me.generalXtraTabPage.Controls.Add(Me.generateLotCodesCheckEdit)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl36)
        Me.generalXtraTabPage.Controls.Add(Me.bagsPerCaseTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.inventoryGridControl)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl1)
        Me.generalXtraTabPage.Controls.Add(Me.upcTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.packersTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.ProjectedPackersLabelControl)
        Me.generalXtraTabPage.Controls.Add(Me.inactiveCheckEdit)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl26)
        Me.generalXtraTabPage.Controls.Add(Me.caseGrossWeightTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.qtyOnHandTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl25)
        Me.generalXtraTabPage.Controls.Add(Me.uomLookUpEdit)
        Me.generalXtraTabPage.Controls.Add(Me.qtyPerUnitTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.unitsPerPalletTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.casesPerPalletTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.unitsPerCaseTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.standardProductionTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.codeTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.defaultMachineLookUpEdit)
        Me.generalXtraTabPage.Controls.Add(Me.customerLookUpEdit)
        Me.generalXtraTabPage.Controls.Add(Me.typeLookUpEdit)
        Me.generalXtraTabPage.Controls.Add(Me.descriptionMemoEdit)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl12)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl11)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl10)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl9)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl8)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl7)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl6)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl5)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl4)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl3)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl2)
        Me.generalXtraTabPage.Name = "generalXtraTabPage"
        Me.generalXtraTabPage.Size = New System.Drawing.Size(686, 488)
        Me.generalXtraTabPage.Text = "General Info"
        '
        'LabelControl38
        '
        Me.LabelControl38.Location = New System.Drawing.Point(265, 189)
        Me.LabelControl38.Name = "LabelControl38"
        Me.LabelControl38.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl38.TabIndex = 38
        Me.LabelControl38.Text = "Minutes per Shift:"
        '
        'minutesPerShiftTextEdit
        '
        Me.minutesPerShiftTextEdit.Location = New System.Drawing.Point(398, 186)
        Me.minutesPerShiftTextEdit.MenuManager = Me.BarManager1
        Me.minutesPerShiftTextEdit.Name = "minutesPerShiftTextEdit"
        Me.minutesPerShiftTextEdit.Size = New System.Drawing.Size(119, 20)
        Me.minutesPerShiftTextEdit.TabIndex = 15
        '
        'lotCodeFormatLookUpEdit
        '
        Me.lotCodeFormatLookUpEdit.Location = New System.Drawing.Point(117, 317)
        Me.lotCodeFormatLookUpEdit.MenuManager = Me.BarManager1
        Me.lotCodeFormatLookUpEdit.Name = "lotCodeFormatLookUpEdit"
        Me.lotCodeFormatLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lotCodeFormatLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FormatID", "Format ID", 71, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FormatName", "Format Name", 74, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
        Me.lotCodeFormatLookUpEdit.Properties.DataSource = Me.lotCodeFormatsXpView
        Me.lotCodeFormatLookUpEdit.Properties.DisplayMember = "FormatName"
        Me.lotCodeFormatLookUpEdit.Properties.NullText = "[Select Lot Code Format]"
        Me.lotCodeFormatLookUpEdit.Properties.ValueMember = "FormatID"
        Me.lotCodeFormatLookUpEdit.Size = New System.Drawing.Size(142, 20)
        Me.lotCodeFormatLookUpEdit.TabIndex = 33
        '
        'lotCodeFormatsXpView
        '
        Me.lotCodeFormatsXpView.ObjectType = GetType(DXDAL.SPGData.LotCodeFormats)
        Me.lotCodeFormatsXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("FormatID", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true), New DevExpress.Xpo.ViewProperty("FormatName", DevExpress.Xpo.SortDirection.Ascending, "[FormatName]", false, true)})
        '
        'LabelControl37
        '
        Me.LabelControl37.Location = New System.Drawing.Point(16, 320)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(84, 13)
        Me.LabelControl37.TabIndex = 37
        Me.LabelControl37.Text = "Lot Code Format:"
        '
        'requiresExpirationDateCheckEdit
        '
        Me.requiresExpirationDateCheckEdit.Location = New System.Drawing.Point(523, 238)
        Me.requiresExpirationDateCheckEdit.MenuManager = Me.BarManager1
        Me.requiresExpirationDateCheckEdit.Name = "requiresExpirationDateCheckEdit"
        Me.requiresExpirationDateCheckEdit.Properties.Caption = "Requires Expiration Date"
        Me.requiresExpirationDateCheckEdit.Size = New System.Drawing.Size(152, 19)
        Me.requiresExpirationDateCheckEdit.TabIndex = 36
        '
        'requiresLotCodeCheckEdit
        '
        Me.requiresLotCodeCheckEdit.Location = New System.Drawing.Point(523, 212)
        Me.requiresLotCodeCheckEdit.MenuManager = Me.BarManager1
        Me.requiresLotCodeCheckEdit.Name = "requiresLotCodeCheckEdit"
        Me.requiresLotCodeCheckEdit.Properties.Caption = "Requires Lot Code"
        Me.requiresLotCodeCheckEdit.Size = New System.Drawing.Size(152, 19)
        Me.requiresLotCodeCheckEdit.TabIndex = 35
        '
        'generateLotCodesCheckEdit
        '
        Me.generateLotCodesCheckEdit.Location = New System.Drawing.Point(523, 186)
        Me.generateLotCodesCheckEdit.MenuManager = Me.BarManager1
        Me.generateLotCodesCheckEdit.Name = "generateLotCodesCheckEdit"
        Me.generateLotCodesCheckEdit.Properties.Caption = "Generate Lot Codes"
        Me.generateLotCodesCheckEdit.Size = New System.Drawing.Size(152, 19)
        Me.generateLotCodesCheckEdit.TabIndex = 34
        '
        'LabelControl36
        '
        Me.LabelControl36.Location = New System.Drawing.Point(265, 267)
        Me.LabelControl36.Name = "LabelControl36"
        Me.LabelControl36.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl36.TabIndex = 33
        Me.LabelControl36.Text = "Bags per Case:"
        '
        'bagsPerCaseTextEdit
        '
        Me.bagsPerCaseTextEdit.Location = New System.Drawing.Point(398, 264)
        Me.bagsPerCaseTextEdit.MenuManager = Me.BarManager1
        Me.bagsPerCaseTextEdit.Name = "bagsPerCaseTextEdit"
        Me.bagsPerCaseTextEdit.Size = New System.Drawing.Size(119, 20)
        Me.bagsPerCaseTextEdit.TabIndex = 27
        '
        'inventoryGridControl
        '
        Me.inventoryGridControl.DataSource = Me.inventoryXpView
        Me.inventoryGridControl.Location = New System.Drawing.Point(16, 343)
        Me.inventoryGridControl.MainView = Me.inventoryGridView
        Me.inventoryGridControl.MenuManager = Me.BarManager1
        Me.inventoryGridControl.Name = "inventoryGridControl"
        Me.inventoryGridControl.Size = New System.Drawing.Size(501, 142)
        Me.inventoryGridControl.TabIndex = 31
        Me.inventoryGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.inventoryGridView})
        '
        'inventoryXpView
        '
        Me.inventoryXpView.ObjectType = GetType(DXDAL.SPGData.LocationInventory)
        Me.inventoryXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("LocationCode", DevExpress.Xpo.SortDirection.None, "[Location.LocationCode]", false, true), New DevExpress.Xpo.ViewProperty("LocationName", DevExpress.Xpo.SortDirection.None, "[Location.LocationName]", false, true), New DevExpress.Xpo.ViewProperty("Quantity", DevExpress.Xpo.SortDirection.None, "[QuantityOnHand]", false, true)})
        '
        'inventoryGridView
        '
        Me.inventoryGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colLocationCode, Me.colLocationName, Me.colQuantity})
        Me.inventoryGridView.GridControl = Me.inventoryGridControl
        Me.inventoryGridView.Name = "inventoryGridView"
        Me.inventoryGridView.OptionsView.ShowFooter = true
        Me.inventoryGridView.OptionsView.ShowGroupPanel = false
        '
        'colLocationCode
        '
        Me.colLocationCode.FieldName = "LocationCode"
        Me.colLocationCode.Name = "colLocationCode"
        Me.colLocationCode.OptionsColumn.ReadOnly = true
        Me.colLocationCode.Visible = true
        Me.colLocationCode.VisibleIndex = 0
        '
        'colLocationName
        '
        Me.colLocationName.FieldName = "LocationName"
        Me.colLocationName.Name = "colLocationName"
        Me.colLocationName.OptionsColumn.ReadOnly = true
        Me.colLocationName.Visible = true
        Me.colLocationName.VisibleIndex = 1
        '
        'colQuantity
        '
        Me.colQuantity.DisplayFormat.FormatString = "{0:#,##0.######}"
        Me.colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.OptionsColumn.ReadOnly = true
        Me.colQuantity.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "{0:#,##0.######}")})
        Me.colQuantity.Visible = true
        Me.colQuantity.VisibleIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(265, 319)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl1.TabIndex = 30
        Me.LabelControl1.Text = "UPC:"
        '
        'upcTextEdit
        '
        Me.upcTextEdit.Location = New System.Drawing.Point(398, 316)
        Me.upcTextEdit.MenuManager = Me.BarManager1
        Me.upcTextEdit.Name = "upcTextEdit"
        Me.upcTextEdit.Size = New System.Drawing.Size(119, 20)
        Me.upcTextEdit.TabIndex = 35
        '
        'packersTextEdit
        '
        Me.packersTextEdit.Location = New System.Drawing.Point(117, 290)
        Me.packersTextEdit.MenuManager = Me.BarManager1
        Me.packersTextEdit.Name = "packersTextEdit"
        Me.packersTextEdit.Size = New System.Drawing.Size(142, 20)
        Me.packersTextEdit.TabIndex = 28
        '
        'ProjectedPackersLabelControl
        '
        Me.ProjectedPackersLabelControl.Location = New System.Drawing.Point(16, 293)
        Me.ProjectedPackersLabelControl.Name = "ProjectedPackersLabelControl"
        Me.ProjectedPackersLabelControl.Size = New System.Drawing.Size(90, 13)
        Me.ProjectedPackersLabelControl.TabIndex = 27
        Me.ProjectedPackersLabelControl.Text = "Projected Packers:"
        '
        'inactiveCheckEdit
        '
        Me.inactiveCheckEdit.Location = New System.Drawing.Point(523, 160)
        Me.inactiveCheckEdit.Name = "inactiveCheckEdit"
        Me.inactiveCheckEdit.Properties.Caption = "Inactive"
        Me.inactiveCheckEdit.Size = New System.Drawing.Size(152, 19)
        Me.inactiveCheckEdit.TabIndex = 32
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(16, 267)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl26.TabIndex = 24
        Me.LabelControl26.Text = "Case Gross Weight:"
        '
        'caseGrossWeightTextEdit
        '
        Me.caseGrossWeightTextEdit.Location = New System.Drawing.Point(117, 264)
        Me.caseGrossWeightTextEdit.Name = "caseGrossWeightTextEdit"
        Me.caseGrossWeightTextEdit.Size = New System.Drawing.Size(142, 20)
        Me.caseGrossWeightTextEdit.TabIndex = 25
        '
        'qtyOnHandTextEdit
        '
        Me.qtyOnHandTextEdit.Location = New System.Drawing.Point(398, 212)
        Me.qtyOnHandTextEdit.Name = "qtyOnHandTextEdit"
        Me.qtyOnHandTextEdit.Properties.DisplayFormat.FormatString = "{0:#,##0.####}"
        Me.qtyOnHandTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.qtyOnHandTextEdit.Properties.ReadOnly = true
        Me.qtyOnHandTextEdit.Size = New System.Drawing.Size(119, 20)
        Me.qtyOnHandTextEdit.TabIndex = 19
        Me.qtyOnHandTextEdit.TabStop = false
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(265, 215)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(91, 13)
        Me.LabelControl25.TabIndex = 14
        Me.LabelControl25.Text = "Quantity On Hand:"
        '
        'uomLookUpEdit
        '
        Me.uomLookUpEdit.Location = New System.Drawing.Point(117, 186)
        Me.uomLookUpEdit.Name = "uomLookUpEdit"
        Me.uomLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.uomLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.uomLookUpEdit.Size = New System.Drawing.Size(142, 20)
        Me.uomLookUpEdit.TabIndex = 13
        '
        'qtyPerUnitTextEdit
        '
        Me.qtyPerUnitTextEdit.Location = New System.Drawing.Point(117, 212)
        Me.qtyPerUnitTextEdit.Name = "qtyPerUnitTextEdit"
        Me.qtyPerUnitTextEdit.Size = New System.Drawing.Size(142, 20)
        Me.qtyPerUnitTextEdit.TabIndex = 17
        '
        'unitsPerPalletTextEdit
        '
        Me.unitsPerPalletTextEdit.Location = New System.Drawing.Point(117, 238)
        Me.unitsPerPalletTextEdit.Name = "unitsPerPalletTextEdit"
        Me.unitsPerPalletTextEdit.Properties.ReadOnly = true
        Me.unitsPerPalletTextEdit.Size = New System.Drawing.Size(142, 20)
        Me.unitsPerPalletTextEdit.TabIndex = 21
        Me.unitsPerPalletTextEdit.TabStop = false
        '
        'casesPerPalletTextEdit
        '
        Me.casesPerPalletTextEdit.Location = New System.Drawing.Point(398, 290)
        Me.casesPerPalletTextEdit.Name = "casesPerPalletTextEdit"
        Me.casesPerPalletTextEdit.Size = New System.Drawing.Size(119, 20)
        Me.casesPerPalletTextEdit.TabIndex = 31
        '
        'unitsPerCaseTextEdit
        '
        Me.unitsPerCaseTextEdit.Location = New System.Drawing.Point(398, 238)
        Me.unitsPerCaseTextEdit.Name = "unitsPerCaseTextEdit"
        Me.unitsPerCaseTextEdit.Size = New System.Drawing.Size(119, 20)
        Me.unitsPerCaseTextEdit.TabIndex = 23
        '
        'standardProductionTextEdit
        '
        Me.standardProductionTextEdit.Location = New System.Drawing.Point(398, 160)
        Me.standardProductionTextEdit.Name = "standardProductionTextEdit"
        Me.standardProductionTextEdit.Size = New System.Drawing.Size(119, 20)
        Me.standardProductionTextEdit.TabIndex = 11
        '
        'codeTextEdit
        '
        Me.codeTextEdit.Location = New System.Drawing.Point(335, 23)
        Me.codeTextEdit.Name = "codeTextEdit"
        Me.codeTextEdit.Size = New System.Drawing.Size(182, 20)
        Me.codeTextEdit.TabIndex = 3
        '
        'defaultMachineLookUpEdit
        '
        Me.defaultMachineLookUpEdit.Location = New System.Drawing.Point(117, 160)
        Me.defaultMachineLookUpEdit.Name = "defaultMachineLookUpEdit"
        Me.defaultMachineLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.defaultMachineLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MachineLineID", "Machine Line ID", 98, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MachineLineName", "Machine Line", 101, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
        Me.defaultMachineLookUpEdit.Properties.DataSource = Me.machineLineXpView
        Me.defaultMachineLookUpEdit.Properties.DisplayMember = "MachineLineName"
        Me.defaultMachineLookUpEdit.Properties.NullText = "[Select a Machine Line]"
        Me.defaultMachineLookUpEdit.Properties.ValueMember = "MachineLineID"
        Me.defaultMachineLookUpEdit.Size = New System.Drawing.Size(142, 20)
        Me.defaultMachineLookUpEdit.TabIndex = 9
        '
        'machineLineXpView
        '
        Me.machineLineXpView.ObjectType = GetType(DXDAL.SPGData.MachineLine)
        Me.machineLineXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("MachineLineID", DevExpress.Xpo.SortDirection.None, "[MachineLineID]", false, true), New DevExpress.Xpo.ViewProperty("MachineLineName", DevExpress.Xpo.SortDirection.None, "[MachineLineName]", false, true)})
        Me.machineLineXpView.Sorting.AddRange(New DevExpress.Xpo.SortProperty() {New DevExpress.Xpo.SortProperty("[MachineLineName]", DevExpress.Xpo.DB.SortingDirection.Ascending)})
        '
        'customerLookUpEdit
        '
        Me.customerLookUpEdit.Location = New System.Drawing.Point(117, 49)
        Me.customerLookUpEdit.Name = "customerLookUpEdit"
        Me.customerLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.customerLookUpEdit.Properties.NullText = "[Select a Customer]"
        Me.customerLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.customerLookUpEdit.Size = New System.Drawing.Size(400, 20)
        Me.customerLookUpEdit.TabIndex = 5
        '
        'typeLookUpEdit
        '
        Me.typeLookUpEdit.Location = New System.Drawing.Point(117, 23)
        Me.typeLookUpEdit.Name = "typeLookUpEdit"
        Me.typeLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.typeLookUpEdit.Properties.NullText = "[Select a Item Type]"
        Me.typeLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.typeLookUpEdit.Size = New System.Drawing.Size(142, 20)
        Me.typeLookUpEdit.TabIndex = 1
        '
        'descriptionMemoEdit
        '
        Me.descriptionMemoEdit.Location = New System.Drawing.Point(117, 75)
        Me.descriptionMemoEdit.Name = "descriptionMemoEdit"
        Me.descriptionMemoEdit.Size = New System.Drawing.Size(400, 72)
        Me.descriptionMemoEdit.TabIndex = 7
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(16, 215)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl12.TabIndex = 16
        Me.LabelControl12.Text = "Quantity per Unit:"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(16, 241)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl11.TabIndex = 20
        Me.LabelControl11.Text = "Units per Pallet:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(265, 293)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl10.TabIndex = 22
        Me.LabelControl10.Text = "Cases per Palet:"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(265, 241)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl9.TabIndex = 18
        Me.LabelControl9.Text = "Units per Case:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(16, 189)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl8.TabIndex = 12
        Me.LabelControl8.Text = "Unit of Measure:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(265, 163)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(111, 13)
        Me.LabelControl7.TabIndex = 10
        Me.LabelControl7.Text = "Default Shift Standard:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(16, 163)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl6.TabIndex = 8
        Me.LabelControl6.Text = "Default Machine:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(16, 52)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Customer:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(16, 26)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl4.TabIndex = 0
        Me.LabelControl4.Text = "Type:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(16, 78)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Description:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(279, 26)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Item #:"
        '
        'shippingXtraTabPage
        '
        Me.shippingXtraTabPage.Controls.Add(Me.shippingGridControl)
        Me.shippingXtraTabPage.Name = "shippingXtraTabPage"
        Me.shippingXtraTabPage.Size = New System.Drawing.Size(686, 488)
        Me.shippingXtraTabPage.Text = "Shippings"
        '
        'shippingGridControl
        '
        Me.shippingGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.shippingGridControl.Location = New System.Drawing.Point(0, 0)
        Me.shippingGridControl.MainView = Me.shippingGridView
        Me.shippingGridControl.Name = "shippingGridControl"
        Me.shippingGridControl.Size = New System.Drawing.Size(686, 488)
        Me.shippingGridControl.TabIndex = 0
        Me.shippingGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.shippingGridView})
        '
        'shippingGridView
        '
        Me.shippingGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.shippingDetailIDGridColumn, Me.shippingIDGridColumn, Me.shippingDateGridColumn, Me.shippingBOLGridColumn, Me.shippingLotGridColumn, Me.shippingQuantityGridColumn, Me.shippingExpirationDateGridColumn})
        Me.shippingGridView.GridControl = Me.shippingGridControl
        Me.shippingGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ShipDetDetQty", Me.shippingQuantityGridColumn, "{0:#,##0.######}")})
        Me.shippingGridView.Name = "shippingGridView"
        Me.shippingGridView.OptionsBehavior.Editable = false
        Me.shippingGridView.OptionsView.ShowAutoFilterRow = true
        Me.shippingGridView.OptionsView.ShowFooter = true
        '
        'shippingDetailIDGridColumn
        '
        Me.shippingDetailIDGridColumn.Caption = "Detail ID"
        Me.shippingDetailIDGridColumn.Name = "shippingDetailIDGridColumn"
        Me.shippingDetailIDGridColumn.OptionsColumn.AllowEdit = false
        Me.shippingDetailIDGridColumn.OptionsColumn.ReadOnly = true
        '
        'shippingIDGridColumn
        '
        Me.shippingIDGridColumn.Caption = "Shipping ID"
        Me.shippingIDGridColumn.Name = "shippingIDGridColumn"
        Me.shippingIDGridColumn.OptionsColumn.AllowEdit = false
        Me.shippingIDGridColumn.OptionsColumn.ReadOnly = true
        '
        'shippingDateGridColumn
        '
        Me.shippingDateGridColumn.Caption = "Date"
        Me.shippingDateGridColumn.Name = "shippingDateGridColumn"
        Me.shippingDateGridColumn.OptionsColumn.AllowEdit = false
        Me.shippingDateGridColumn.OptionsColumn.ReadOnly = true
        Me.shippingDateGridColumn.Visible = true
        Me.shippingDateGridColumn.VisibleIndex = 0
        '
        'shippingBOLGridColumn
        '
        Me.shippingBOLGridColumn.Caption = "BOL #"
        Me.shippingBOLGridColumn.Name = "shippingBOLGridColumn"
        Me.shippingBOLGridColumn.OptionsColumn.AllowEdit = false
        Me.shippingBOLGridColumn.OptionsColumn.ReadOnly = true
        Me.shippingBOLGridColumn.Visible = true
        Me.shippingBOLGridColumn.VisibleIndex = 1
        '
        'shippingLotGridColumn
        '
        Me.shippingLotGridColumn.Caption = "Lot"
        Me.shippingLotGridColumn.Name = "shippingLotGridColumn"
        Me.shippingLotGridColumn.OptionsColumn.AllowEdit = false
        Me.shippingLotGridColumn.OptionsColumn.ReadOnly = true
        Me.shippingLotGridColumn.Visible = true
        Me.shippingLotGridColumn.VisibleIndex = 2
        '
        'shippingQuantityGridColumn
        '
        Me.shippingQuantityGridColumn.Caption = "Quantity"
        Me.shippingQuantityGridColumn.Name = "shippingQuantityGridColumn"
        Me.shippingQuantityGridColumn.OptionsColumn.AllowEdit = false
        Me.shippingQuantityGridColumn.OptionsColumn.ReadOnly = true
        Me.shippingQuantityGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "TOTAL        {0}")})
        Me.shippingQuantityGridColumn.Visible = true
        Me.shippingQuantityGridColumn.VisibleIndex = 4
        '
        'shippingExpirationDateGridColumn
        '
        Me.shippingExpirationDateGridColumn.Caption = "Expiration Date"
        Me.shippingExpirationDateGridColumn.DisplayFormat.FormatString = "d"
        Me.shippingExpirationDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.shippingExpirationDateGridColumn.Name = "shippingExpirationDateGridColumn"
        Me.shippingExpirationDateGridColumn.OptionsColumn.AllowEdit = false
        Me.shippingExpirationDateGridColumn.OptionsColumn.ReadOnly = true
        Me.shippingExpirationDateGridColumn.Visible = true
        Me.shippingExpirationDateGridColumn.VisibleIndex = 3
        '
        'productionXtraTabPage
        '
        Me.productionXtraTabPage.Controls.Add(Me.productionGridControl)
        Me.productionXtraTabPage.Name = "productionXtraTabPage"
        Me.productionXtraTabPage.Size = New System.Drawing.Size(686, 488)
        Me.productionXtraTabPage.Text = "Production"
        '
        'productionGridControl
        '
        Me.productionGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.productionGridControl.Location = New System.Drawing.Point(0, 0)
        Me.productionGridControl.MainView = Me.productionGridView
        Me.productionGridControl.Name = "productionGridControl"
        Me.productionGridControl.Size = New System.Drawing.Size(686, 488)
        Me.productionGridControl.TabIndex = 0
        Me.productionGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.productionGridView})
        '
        'productionGridView
        '
        Me.productionGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.productionDateGridColumn, Me.productionLotGridColumn, Me.productionPOGridColumn, Me.productionQuantityGridColumn, Me.productionExpirationDateGridColumn})
        Me.productionGridView.GridControl = Me.productionGridControl
        Me.productionGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "InventoryQuantity", Me.productionQuantityGridColumn, "{0:#,##0.######}")})
        Me.productionGridView.Name = "productionGridView"
        Me.productionGridView.OptionsBehavior.Editable = false
        Me.productionGridView.OptionsView.ShowAutoFilterRow = true
        Me.productionGridView.OptionsView.ShowFooter = true
        '
        'productionDateGridColumn
        '
        Me.productionDateGridColumn.Caption = "Date"
        Me.productionDateGridColumn.Name = "productionDateGridColumn"
        Me.productionDateGridColumn.OptionsColumn.AllowEdit = false
        Me.productionDateGridColumn.OptionsColumn.ReadOnly = true
        Me.productionDateGridColumn.Visible = true
        Me.productionDateGridColumn.VisibleIndex = 0
        '
        'productionLotGridColumn
        '
        Me.productionLotGridColumn.Caption = "Lot"
        Me.productionLotGridColumn.Name = "productionLotGridColumn"
        Me.productionLotGridColumn.OptionsColumn.AllowEdit = false
        Me.productionLotGridColumn.OptionsColumn.ReadOnly = true
        Me.productionLotGridColumn.Visible = true
        Me.productionLotGridColumn.VisibleIndex = 1
        '
        'productionPOGridColumn
        '
        Me.productionPOGridColumn.Caption = "PO"
        Me.productionPOGridColumn.Name = "productionPOGridColumn"
        Me.productionPOGridColumn.OptionsColumn.AllowEdit = false
        Me.productionPOGridColumn.OptionsColumn.ReadOnly = true
        Me.productionPOGridColumn.Visible = true
        Me.productionPOGridColumn.VisibleIndex = 3
        '
        'productionQuantityGridColumn
        '
        Me.productionQuantityGridColumn.Caption = "Quantity"
        Me.productionQuantityGridColumn.Name = "productionQuantityGridColumn"
        Me.productionQuantityGridColumn.OptionsColumn.AllowEdit = false
        Me.productionQuantityGridColumn.OptionsColumn.ReadOnly = true
        Me.productionQuantityGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "TOTAL        {0}")})
        Me.productionQuantityGridColumn.Visible = true
        Me.productionQuantityGridColumn.VisibleIndex = 4
        '
        'productionExpirationDateGridColumn
        '
        Me.productionExpirationDateGridColumn.Caption = "Expiration Date"
        Me.productionExpirationDateGridColumn.DisplayFormat.FormatString = "d"
        Me.productionExpirationDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.productionExpirationDateGridColumn.Name = "productionExpirationDateGridColumn"
        Me.productionExpirationDateGridColumn.OptionsColumn.AllowEdit = false
        Me.productionExpirationDateGridColumn.OptionsColumn.ReadOnly = true
        Me.productionExpirationDateGridColumn.Visible = true
        Me.productionExpirationDateGridColumn.VisibleIndex = 2
        '
        'receivingXtraTabPage
        '
        Me.receivingXtraTabPage.Controls.Add(Me.receivingsGridControl)
        Me.receivingXtraTabPage.Name = "receivingXtraTabPage"
        Me.receivingXtraTabPage.Size = New System.Drawing.Size(686, 488)
        Me.receivingXtraTabPage.Text = "Receivings"
        '
        'receivingsGridControl
        '
        Me.receivingsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.receivingsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.receivingsGridControl.MainView = Me.receivingsGridView
        Me.receivingsGridControl.Name = "receivingsGridControl"
        Me.receivingsGridControl.Size = New System.Drawing.Size(686, 488)
        Me.receivingsGridControl.TabIndex = 0
        Me.receivingsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.receivingsGridView})
        '
        'receivingsGridView
        '
        Me.receivingsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.receivingDetailIDGridColumn, Me.receivingIDGridColumn, Me.receivingLotGridColumn, Me.receivingQuantityGridColumn, Me.receivingDateGridColumn, Me.receivingBOLGridColumn, Me.receivingExpirationDateGridColumn})
        Me.receivingsGridView.GridControl = Me.receivingsGridControl
        Me.receivingsGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "intUnits", Me.receivingQuantityGridColumn, "{0:#,##0.######}")})
        Me.receivingsGridView.Name = "receivingsGridView"
        Me.receivingsGridView.OptionsBehavior.Editable = false
        Me.receivingsGridView.OptionsView.ShowAutoFilterRow = true
        Me.receivingsGridView.OptionsView.ShowFooter = true
        '
        'receivingDetailIDGridColumn
        '
        Me.receivingDetailIDGridColumn.Caption = "Detail ID"
        Me.receivingDetailIDGridColumn.Name = "receivingDetailIDGridColumn"
        Me.receivingDetailIDGridColumn.OptionsColumn.AllowEdit = false
        Me.receivingDetailIDGridColumn.OptionsColumn.ReadOnly = true
        '
        'receivingIDGridColumn
        '
        Me.receivingIDGridColumn.Caption = "Receiving ID"
        Me.receivingIDGridColumn.Name = "receivingIDGridColumn"
        Me.receivingIDGridColumn.OptionsColumn.AllowEdit = false
        Me.receivingIDGridColumn.OptionsColumn.ReadOnly = true
        '
        'receivingLotGridColumn
        '
        Me.receivingLotGridColumn.Caption = "Lot"
        Me.receivingLotGridColumn.Name = "receivingLotGridColumn"
        Me.receivingLotGridColumn.OptionsColumn.AllowEdit = false
        Me.receivingLotGridColumn.OptionsColumn.ReadOnly = true
        Me.receivingLotGridColumn.Visible = true
        Me.receivingLotGridColumn.VisibleIndex = 1
        '
        'receivingQuantityGridColumn
        '
        Me.receivingQuantityGridColumn.Caption = "Quantity"
        Me.receivingQuantityGridColumn.Name = "receivingQuantityGridColumn"
        Me.receivingQuantityGridColumn.OptionsColumn.AllowEdit = false
        Me.receivingQuantityGridColumn.OptionsColumn.ReadOnly = true
        Me.receivingQuantityGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "TOTAL        {0}")})
        Me.receivingQuantityGridColumn.Visible = true
        Me.receivingQuantityGridColumn.VisibleIndex = 4
        '
        'receivingDateGridColumn
        '
        Me.receivingDateGridColumn.Caption = "Date"
        Me.receivingDateGridColumn.Name = "receivingDateGridColumn"
        Me.receivingDateGridColumn.OptionsColumn.AllowEdit = false
        Me.receivingDateGridColumn.OptionsColumn.ReadOnly = true
        Me.receivingDateGridColumn.Visible = true
        Me.receivingDateGridColumn.VisibleIndex = 0
        '
        'receivingBOLGridColumn
        '
        Me.receivingBOLGridColumn.Caption = "BOL"
        Me.receivingBOLGridColumn.Name = "receivingBOLGridColumn"
        Me.receivingBOLGridColumn.OptionsColumn.AllowEdit = false
        Me.receivingBOLGridColumn.OptionsColumn.ReadOnly = true
        Me.receivingBOLGridColumn.Visible = true
        Me.receivingBOLGridColumn.VisibleIndex = 3
        '
        'receivingExpirationDateGridColumn
        '
        Me.receivingExpirationDateGridColumn.Caption = "Expiration Date"
        Me.receivingExpirationDateGridColumn.DisplayFormat.FormatString = "d"
        Me.receivingExpirationDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.receivingExpirationDateGridColumn.Name = "receivingExpirationDateGridColumn"
        Me.receivingExpirationDateGridColumn.Visible = true
        Me.receivingExpirationDateGridColumn.VisibleIndex = 2
        '
        'bomXtraTabPage
        '
        Me.bomXtraTabPage.Controls.Add(Me.SplitContainerControl2)
        Me.bomXtraTabPage.Name = "bomXtraTabPage"
        Me.bomXtraTabPage.PageVisible = false
        Me.bomXtraTabPage.Size = New System.Drawing.Size(686, 488)
        Me.bomXtraTabPage.Text = "BOM"
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Horizontal = false
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.bomGridControl)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.poolBomGridControl)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(686, 488)
        Me.SplitContainerControl2.SplitterPosition = 243
        Me.SplitContainerControl2.TabIndex = 2
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'bomGridControl
        '
        Me.bomGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bomGridControl.Location = New System.Drawing.Point(0, 0)
        Me.bomGridControl.MainView = Me.BOMGridView
        Me.bomGridControl.Name = "bomGridControl"
        Me.bomGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RMRepositoryItemLookUpEdit, Me.deleteRepositoryItemButtonEdit})
        Me.bomGridControl.Size = New System.Drawing.Size(686, 243)
        Me.bomGridControl.TabIndex = 1
        Me.bomGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.BOMGridView})
        '
        'BOMGridView
        '
        Me.BOMGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.bomIDGridColumn, Me.FGItemCodeGridColumn, Me.RMItemCodeGridColumn, Me.RMItemDescriptionGridColumn, Me.RMQuantityGridColumn, Me.scrapFactorGridColumn, Me.deleteGridColumn})
        Me.BOMGridView.GridControl = Me.bomGridControl
        Me.BOMGridView.Name = "BOMGridView"
        Me.BOMGridView.OptionsSelection.MultiSelect = true
        Me.BOMGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        '
        'bomIDGridColumn
        '
        Me.bomIDGridColumn.Caption = "BOM ID"
        Me.bomIDGridColumn.Name = "bomIDGridColumn"
        '
        'FGItemCodeGridColumn
        '
        Me.FGItemCodeGridColumn.Caption = "FG Item Code"
        Me.FGItemCodeGridColumn.Name = "FGItemCodeGridColumn"
        '
        'RMItemCodeGridColumn
        '
        Me.RMItemCodeGridColumn.Caption = "RM Item #"
        Me.RMItemCodeGridColumn.ColumnEdit = Me.RMRepositoryItemLookUpEdit
        Me.RMItemCodeGridColumn.Name = "RMItemCodeGridColumn"
        Me.RMItemCodeGridColumn.Visible = true
        Me.RMItemCodeGridColumn.VisibleIndex = 1
        '
        'RMRepositoryItemLookUpEdit
        '
        Me.RMRepositoryItemLookUpEdit.AutoHeight = false
        Me.RMRepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RMRepositoryItemLookUpEdit.ImmediatePopup = true
        Me.RMRepositoryItemLookUpEdit.Name = "RMRepositoryItemLookUpEdit"
        Me.RMRepositoryItemLookUpEdit.NullText = ""
        Me.RMRepositoryItemLookUpEdit.NullValuePrompt = "[Select a RM Item]"
        Me.RMRepositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup
        Me.RMRepositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        '
        'RMItemDescriptionGridColumn
        '
        Me.RMItemDescriptionGridColumn.Caption = "Item Description"
        Me.RMItemDescriptionGridColumn.FieldName = "RMItemDescriptionGridColumn"
        Me.RMItemDescriptionGridColumn.Name = "RMItemDescriptionGridColumn"
        Me.RMItemDescriptionGridColumn.OptionsColumn.AllowEdit = false
        Me.RMItemDescriptionGridColumn.OptionsColumn.AllowFocus = false
        Me.RMItemDescriptionGridColumn.OptionsColumn.ReadOnly = true
        Me.RMItemDescriptionGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.RMItemDescriptionGridColumn.Visible = true
        Me.RMItemDescriptionGridColumn.VisibleIndex = 2
        '
        'RMQuantityGridColumn
        '
        Me.RMQuantityGridColumn.Caption = "Quantity"
        Me.RMQuantityGridColumn.Name = "RMQuantityGridColumn"
        Me.RMQuantityGridColumn.Visible = true
        Me.RMQuantityGridColumn.VisibleIndex = 3
        '
        'scrapFactorGridColumn
        '
        Me.scrapFactorGridColumn.Caption = "Scrap Factor"
        Me.scrapFactorGridColumn.DisplayFormat.FormatString = "{0}%"
        Me.scrapFactorGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.scrapFactorGridColumn.Name = "scrapFactorGridColumn"
        Me.scrapFactorGridColumn.Visible = true
        Me.scrapFactorGridColumn.VisibleIndex = 4
        '
        'deleteGridColumn
        '
        Me.deleteGridColumn.Caption = "GridColumn1"
        Me.deleteGridColumn.ColumnEdit = Me.deleteRepositoryItemButtonEdit
        Me.deleteGridColumn.MaxWidth = 25
        Me.deleteGridColumn.MinWidth = 25
        Me.deleteGridColumn.Name = "deleteGridColumn"
        Me.deleteGridColumn.OptionsColumn.AllowSize = false
        Me.deleteGridColumn.OptionsColumn.FixedWidth = true
        Me.deleteGridColumn.Visible = true
        Me.deleteGridColumn.VisibleIndex = 0
        Me.deleteGridColumn.Width = 25
        '
        'deleteRepositoryItemButtonEdit
        '
        Me.deleteRepositoryItemButtonEdit.AutoHeight = false
        Me.deleteRepositoryItemButtonEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.deleteRepositoryItemButtonEdit.Name = "deleteRepositoryItemButtonEdit"
        Me.deleteRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'availabilityXtraTabPage
        '
        Me.availabilityXtraTabPage.Controls.Add(Me.printSimpleButton)
        Me.availabilityXtraTabPage.Controls.Add(Me.previewSimpleButton)
        Me.availabilityXtraTabPage.Controls.Add(Me.availabilityGridControl)
        Me.availabilityXtraTabPage.Name = "availabilityXtraTabPage"
        Me.availabilityXtraTabPage.Size = New System.Drawing.Size(686, 488)
        Me.availabilityXtraTabPage.Text = "Availability"
        '
        'printSimpleButton
        '
        Me.printSimpleButton.Location = New System.Drawing.Point(279, 3)
        Me.printSimpleButton.Name = "printSimpleButton"
        Me.printSimpleButton.Size = New System.Drawing.Size(88, 23)
        Me.printSimpleButton.TabIndex = 2
        Me.printSimpleButton.Text = "&Print"
        Me.printSimpleButton.Visible = false
        '
        'previewSimpleButton
        '
        Me.previewSimpleButton.Location = New System.Drawing.Point(189, 3)
        Me.previewSimpleButton.Name = "previewSimpleButton"
        Me.previewSimpleButton.Size = New System.Drawing.Size(84, 23)
        Me.previewSimpleButton.TabIndex = 1
        Me.previewSimpleButton.Text = "Print P&review"
        Me.previewSimpleButton.Visible = false
        '
        'availabilityGridControl
        '
        Me.availabilityGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.availabilityGridControl.Location = New System.Drawing.Point(0, 0)
        Me.availabilityGridControl.MainView = Me.availabilityGridView
        Me.availabilityGridControl.Name = "availabilityGridControl"
        Me.availabilityGridControl.Size = New System.Drawing.Size(686, 488)
        Me.availabilityGridControl.TabIndex = 0
        Me.availabilityGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.availabilityGridView})
        '
        'availabilityGridView
        '
        Me.availabilityGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.bomItemCodeGridColumn, Me.bomItemDescriptionGridColumn, Me.quantityOnHandGridColumn, Me.quantityYieldsGridColumn, Me.localQuantityOnHandGridColumn, Me.localQuantityYieldsGridColumn, Me.quantityRequiredGridColumn, Me.availabilityItemIDGridColumn, Me.scrapPercentageGridColumn, Me.isPoolGridColumn})
        Me.availabilityGridView.GridControl = Me.availabilityGridControl
        Me.availabilityGridView.Name = "availabilityGridView"
        Me.availabilityGridView.OptionsCustomization.AllowRowSizing = true
        Me.availabilityGridView.OptionsPrint.AutoWidth = false
        Me.availabilityGridView.OptionsPrint.PrintFilterInfo = true
        Me.availabilityGridView.OptionsView.RowAutoHeight = true
        Me.availabilityGridView.OptionsView.ShowFooter = true
        '
        'bomItemCodeGridColumn
        '
        Me.bomItemCodeGridColumn.Caption = "Item Number"
        Me.bomItemCodeGridColumn.Name = "bomItemCodeGridColumn"
        Me.bomItemCodeGridColumn.OptionsColumn.AllowEdit = false
        Me.bomItemCodeGridColumn.OptionsColumn.ReadOnly = true
        Me.bomItemCodeGridColumn.Visible = true
        Me.bomItemCodeGridColumn.VisibleIndex = 0
        Me.bomItemCodeGridColumn.Width = 100
        '
        'bomItemDescriptionGridColumn
        '
        Me.bomItemDescriptionGridColumn.Caption = "Item Description"
        Me.bomItemDescriptionGridColumn.Name = "bomItemDescriptionGridColumn"
        Me.bomItemDescriptionGridColumn.OptionsColumn.AllowEdit = false
        Me.bomItemDescriptionGridColumn.OptionsColumn.ReadOnly = true
        Me.bomItemDescriptionGridColumn.Visible = true
        Me.bomItemDescriptionGridColumn.VisibleIndex = 1
        Me.bomItemDescriptionGridColumn.Width = 200
        '
        'quantityOnHandGridColumn
        '
        Me.quantityOnHandGridColumn.Caption = "Qty On Hand"
        Me.quantityOnHandGridColumn.DisplayFormat.FormatString = "{0:#,##0.####}"
        Me.quantityOnHandGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.quantityOnHandGridColumn.Name = "quantityOnHandGridColumn"
        Me.quantityOnHandGridColumn.OptionsColumn.AllowEdit = false
        Me.quantityOnHandGridColumn.OptionsColumn.ReadOnly = true
        Me.quantityOnHandGridColumn.Visible = true
        Me.quantityOnHandGridColumn.VisibleIndex = 2
        '
        'quantityYieldsGridColumn
        '
        Me.quantityYieldsGridColumn.Caption = "Yield Qty"
        Me.quantityYieldsGridColumn.FieldName = "quantityYieldsGridColumn"
        Me.quantityYieldsGridColumn.Name = "quantityYieldsGridColumn"
        Me.quantityYieldsGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Min)})
        Me.quantityYieldsGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.quantityYieldsGridColumn.Visible = true
        Me.quantityYieldsGridColumn.VisibleIndex = 3
        '
        'localQuantityOnHandGridColumn
        '
        Me.localQuantityOnHandGridColumn.Caption = "Local Qty On Hand"
        Me.localQuantityOnHandGridColumn.DisplayFormat.FormatString = "{0:#,##0.####}"
        Me.localQuantityOnHandGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.localQuantityOnHandGridColumn.Name = "localQuantityOnHandGridColumn"
        Me.localQuantityOnHandGridColumn.OptionsColumn.AllowEdit = false
        Me.localQuantityOnHandGridColumn.OptionsColumn.ReadOnly = true
        Me.localQuantityOnHandGridColumn.Visible = true
        Me.localQuantityOnHandGridColumn.VisibleIndex = 4
        '
        'localQuantityYieldsGridColumn
        '
        Me.localQuantityYieldsGridColumn.Caption = "Local Yield Qty"
        Me.localQuantityYieldsGridColumn.FieldName = "localQuantityYieldsGridColumn"
        Me.localQuantityYieldsGridColumn.Name = "localQuantityYieldsGridColumn"
        Me.localQuantityYieldsGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Min)})
        Me.localQuantityYieldsGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.localQuantityYieldsGridColumn.Visible = true
        Me.localQuantityYieldsGridColumn.VisibleIndex = 5
        '
        'quantityRequiredGridColumn
        '
        Me.quantityRequiredGridColumn.Caption = "GridColumn1"
        Me.quantityRequiredGridColumn.Name = "quantityRequiredGridColumn"
        Me.quantityRequiredGridColumn.OptionsColumn.AllowEdit = false
        Me.quantityRequiredGridColumn.OptionsColumn.ReadOnly = true
        '
        'availabilityItemIDGridColumn
        '
        Me.availabilityItemIDGridColumn.Caption = "GridColumn1"
        Me.availabilityItemIDGridColumn.Name = "availabilityItemIDGridColumn"
        Me.availabilityItemIDGridColumn.OptionsColumn.AllowEdit = false
        Me.availabilityItemIDGridColumn.OptionsColumn.ReadOnly = true
        '
        'scrapPercentageGridColumn
        '
        Me.scrapPercentageGridColumn.Caption = "GridColumn1"
        Me.scrapPercentageGridColumn.Name = "scrapPercentageGridColumn"
        '
        'isPoolGridColumn
        '
        Me.isPoolGridColumn.Caption = "Is Pool"
        Me.isPoolGridColumn.Name = "isPoolGridColumn"
        '
        'advancedXtraTabPage
        '
        Me.advancedXtraTabPage.Controls.Add(Me.other5TextEdit)
        Me.advancedXtraTabPage.Controls.Add(Me.other4TextEdit)
        Me.advancedXtraTabPage.Controls.Add(Me.other3TextEdit)
        Me.advancedXtraTabPage.Controls.Add(Me.other2TextEdit)
        Me.advancedXtraTabPage.Controls.Add(Me.other1TextEdit)
        Me.advancedXtraTabPage.Controls.Add(Me.palletsTextEdit)
        Me.advancedXtraTabPage.Controls.Add(Me.stretchWrapTextEdit)
        Me.advancedXtraTabPage.Controls.Add(Me.boxesTextEdit)
        Me.advancedXtraTabPage.Controls.Add(Me.filmTextEdit)
        Me.advancedXtraTabPage.Controls.Add(Me.freightTextEdit)
        Me.advancedXtraTabPage.Controls.Add(Me.rebateTextEdit)
        Me.advancedXtraTabPage.Controls.Add(Me.priceTextEdit)
        Me.advancedXtraTabPage.Controls.Add(Me.LabelControl24)
        Me.advancedXtraTabPage.Controls.Add(Me.LabelControl23)
        Me.advancedXtraTabPage.Controls.Add(Me.LabelControl22)
        Me.advancedXtraTabPage.Controls.Add(Me.LabelControl21)
        Me.advancedXtraTabPage.Controls.Add(Me.LabelControl20)
        Me.advancedXtraTabPage.Controls.Add(Me.LabelControl19)
        Me.advancedXtraTabPage.Controls.Add(Me.LabelControl18)
        Me.advancedXtraTabPage.Controls.Add(Me.LabelControl17)
        Me.advancedXtraTabPage.Controls.Add(Me.LabelControl16)
        Me.advancedXtraTabPage.Controls.Add(Me.LabelControl15)
        Me.advancedXtraTabPage.Controls.Add(Me.LabelControl14)
        Me.advancedXtraTabPage.Controls.Add(Me.LabelControl13)
        Me.advancedXtraTabPage.Name = "advancedXtraTabPage"
        Me.advancedXtraTabPage.Size = New System.Drawing.Size(686, 488)
        Me.advancedXtraTabPage.Text = "Advanced"
        '
        'other5TextEdit
        '
        Me.other5TextEdit.Location = New System.Drawing.Point(398, 346)
        Me.other5TextEdit.Name = "other5TextEdit"
        Me.other5TextEdit.Properties.DisplayFormat.FormatString = "c"
        Me.other5TextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.other5TextEdit.Size = New System.Drawing.Size(100, 20)
        Me.other5TextEdit.TabIndex = 23
        '
        'other4TextEdit
        '
        Me.other4TextEdit.Location = New System.Drawing.Point(398, 309)
        Me.other4TextEdit.Name = "other4TextEdit"
        Me.other4TextEdit.Properties.DisplayFormat.FormatString = "c"
        Me.other4TextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.other4TextEdit.Size = New System.Drawing.Size(100, 20)
        Me.other4TextEdit.TabIndex = 19
        '
        'other3TextEdit
        '
        Me.other3TextEdit.Location = New System.Drawing.Point(398, 272)
        Me.other3TextEdit.Name = "other3TextEdit"
        Me.other3TextEdit.Properties.DisplayFormat.FormatString = "c"
        Me.other3TextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.other3TextEdit.Size = New System.Drawing.Size(100, 20)
        Me.other3TextEdit.TabIndex = 15
        '
        'other2TextEdit
        '
        Me.other2TextEdit.Location = New System.Drawing.Point(398, 235)
        Me.other2TextEdit.Name = "other2TextEdit"
        Me.other2TextEdit.Properties.DisplayFormat.FormatString = "c"
        Me.other2TextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.other2TextEdit.Size = New System.Drawing.Size(100, 20)
        Me.other2TextEdit.TabIndex = 11
        '
        'other1TextEdit
        '
        Me.other1TextEdit.Location = New System.Drawing.Point(398, 198)
        Me.other1TextEdit.Name = "other1TextEdit"
        Me.other1TextEdit.Properties.DisplayFormat.FormatString = "c"
        Me.other1TextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.other1TextEdit.Size = New System.Drawing.Size(100, 20)
        Me.other1TextEdit.TabIndex = 7
        '
        'palletsTextEdit
        '
        Me.palletsTextEdit.Location = New System.Drawing.Point(208, 346)
        Me.palletsTextEdit.Name = "palletsTextEdit"
        Me.palletsTextEdit.Properties.DisplayFormat.FormatString = "c"
        Me.palletsTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.palletsTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.palletsTextEdit.TabIndex = 21
        '
        'stretchWrapTextEdit
        '
        Me.stretchWrapTextEdit.Location = New System.Drawing.Point(208, 309)
        Me.stretchWrapTextEdit.Name = "stretchWrapTextEdit"
        Me.stretchWrapTextEdit.Properties.DisplayFormat.FormatString = "c"
        Me.stretchWrapTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.stretchWrapTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.stretchWrapTextEdit.TabIndex = 17
        '
        'boxesTextEdit
        '
        Me.boxesTextEdit.Location = New System.Drawing.Point(208, 272)
        Me.boxesTextEdit.Name = "boxesTextEdit"
        Me.boxesTextEdit.Properties.DisplayFormat.FormatString = "c"
        Me.boxesTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.boxesTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.boxesTextEdit.TabIndex = 13
        '
        'filmTextEdit
        '
        Me.filmTextEdit.Location = New System.Drawing.Point(208, 235)
        Me.filmTextEdit.Name = "filmTextEdit"
        Me.filmTextEdit.Properties.DisplayFormat.FormatString = "c"
        Me.filmTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.filmTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.filmTextEdit.TabIndex = 9
        '
        'freightTextEdit
        '
        Me.freightTextEdit.Location = New System.Drawing.Point(208, 198)
        Me.freightTextEdit.Name = "freightTextEdit"
        Me.freightTextEdit.Properties.DisplayFormat.FormatString = "c"
        Me.freightTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.freightTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.freightTextEdit.TabIndex = 5
        '
        'rebateTextEdit
        '
        Me.rebateTextEdit.Location = New System.Drawing.Point(295, 158)
        Me.rebateTextEdit.Name = "rebateTextEdit"
        Me.rebateTextEdit.Properties.DisplayFormat.FormatString = "p"
        Me.rebateTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.rebateTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.rebateTextEdit.TabIndex = 3
        '
        'priceTextEdit
        '
        Me.priceTextEdit.Location = New System.Drawing.Point(295, 122)
        Me.priceTextEdit.Name = "priceTextEdit"
        Me.priceTextEdit.Properties.DisplayFormat.FormatString = "c"
        Me.priceTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.priceTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.priceTextEdit.TabIndex = 1
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(345, 349)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl24.TabIndex = 22
        Me.LabelControl24.Text = "Other:"
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(345, 312)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl23.TabIndex = 18
        Me.LabelControl23.Text = "Other:"
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(345, 275)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl22.TabIndex = 14
        Me.LabelControl22.Text = "Other:"
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(345, 238)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl21.TabIndex = 10
        Me.LabelControl21.Text = "Other:"
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(345, 201)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl20.TabIndex = 6
        Me.LabelControl20.Text = "Other:"
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(130, 349)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl19.TabIndex = 20
        Me.LabelControl19.Text = "Pallets:"
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(130, 312)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl18.TabIndex = 16
        Me.LabelControl18.Text = "Stretch Wrap:"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(130, 275)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl17.TabIndex = 12
        Me.LabelControl17.Text = "Boxes:"
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(130, 238)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(22, 13)
        Me.LabelControl16.TabIndex = 8
        Me.LabelControl16.Text = "Film:"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(130, 201)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl15.TabIndex = 4
        Me.LabelControl15.Text = "Freight:"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(239, 161)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl14.TabIndex = 2
        Me.LabelControl14.Text = "Rebate:"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(239, 129)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl13.TabIndex = 0
        Me.LabelControl13.Text = "Price:"
        '
        'specificationXtraTabPage
        '
        Me.specificationXtraTabPage.Controls.Add(Me.LabelControl35)
        Me.specificationXtraTabPage.Controls.Add(Me.LabelControl34)
        Me.specificationXtraTabPage.Controls.Add(Me.LabelControl33)
        Me.specificationXtraTabPage.Controls.Add(Me.LabelControl32)
        Me.specificationXtraTabPage.Controls.Add(Me.LabelControl31)
        Me.specificationXtraTabPage.Controls.Add(Me.LabelControl30)
        Me.specificationXtraTabPage.Controls.Add(Me.LabelControl29)
        Me.specificationXtraTabPage.Controls.Add(Me.LabelControl28)
        Me.specificationXtraTabPage.Controls.Add(Me.LabelControl27)
        Me.specificationXtraTabPage.Controls.Add(Me.palletPatternButtonEdit)
        Me.specificationXtraTabPage.Controls.Add(Me.instructionsMemoEdit)
        Me.specificationXtraTabPage.Controls.Add(Me.shelfLifeTextEdit)
        Me.specificationXtraTabPage.Controls.Add(Me.layersPerPalletTextEdit)
        Me.specificationXtraTabPage.Controls.Add(Me.cassesPerLayerTextEdit)
        Me.specificationXtraTabPage.Controls.Add(Me.mavTextEdit)
        Me.specificationXtraTabPage.Controls.Add(Me.requiredWeightTextEdit)
        Me.specificationXtraTabPage.Controls.Add(Me.caseCodeMemoEdit)
        Me.specificationXtraTabPage.Controls.Add(Me.packageCodeMemoEdit)
        Me.specificationXtraTabPage.Name = "specificationXtraTabPage"
        Me.specificationXtraTabPage.Size = New System.Drawing.Size(686, 488)
        Me.specificationXtraTabPage.Text = "Specification"
        '
        'LabelControl35
        '
        Me.LabelControl35.Location = New System.Drawing.Point(301, 417)
        Me.LabelControl35.Name = "LabelControl35"
        Me.LabelControl35.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl35.TabIndex = 16
        Me.LabelControl35.Text = "Pallet Pattern"
        '
        'LabelControl34
        '
        Me.LabelControl34.Location = New System.Drawing.Point(301, 390)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl34.TabIndex = 12
        Me.LabelControl34.Text = "Layers per Pallet"
        '
        'LabelControl33
        '
        Me.LabelControl33.Location = New System.Drawing.Point(301, 364)
        Me.LabelControl33.Name = "LabelControl33"
        Me.LabelControl33.Size = New System.Drawing.Size(171, 13)
        Me.LabelControl33.TabIndex = 8
        Me.LabelControl33.Text = "Maximum Allowance Variance (MAV)"
        '
        'LabelControl32
        '
        Me.LabelControl32.Location = New System.Drawing.Point(51, 262)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl32.TabIndex = 4
        Me.LabelControl32.Text = "Special Instructions"
        '
        'LabelControl31
        '
        Me.LabelControl31.Location = New System.Drawing.Point(51, 417)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl31.TabIndex = 14
        Me.LabelControl31.Text = "Shelf Life"
        '
        'LabelControl30
        '
        Me.LabelControl30.Location = New System.Drawing.Point(51, 388)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl30.TabIndex = 10
        Me.LabelControl30.Text = "Cases per Layer"
        '
        'LabelControl29
        '
        Me.LabelControl29.Location = New System.Drawing.Point(51, 362)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(113, 13)
        Me.LabelControl29.TabIndex = 6
        Me.LabelControl29.Text = "Required Weight/Count"
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(51, 160)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(89, 13)
        Me.LabelControl28.TabIndex = 2
        Me.LabelControl28.Text = "Case Code Format"
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(51, 57)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(105, 13)
        Me.LabelControl27.TabIndex = 0
        Me.LabelControl27.Text = "Package Code Format"
        '
        'palletPatternButtonEdit
        '
        Me.palletPatternButtonEdit.Location = New System.Drawing.Point(372, 414)
        Me.palletPatternButtonEdit.Name = "palletPatternButtonEdit"
        Me.palletPatternButtonEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.palletPatternButtonEdit.Properties.NullText = "[Select the Pattern Image]"
        Me.palletPatternButtonEdit.Size = New System.Drawing.Size(206, 20)
        Me.palletPatternButtonEdit.TabIndex = 17
        '
        'instructionsMemoEdit
        '
        Me.instructionsMemoEdit.Location = New System.Drawing.Point(170, 259)
        Me.instructionsMemoEdit.Name = "instructionsMemoEdit"
        Me.instructionsMemoEdit.Size = New System.Drawing.Size(408, 96)
        Me.instructionsMemoEdit.TabIndex = 5
        '
        'shelfLifeTextEdit
        '
        Me.shelfLifeTextEdit.Location = New System.Drawing.Point(170, 414)
        Me.shelfLifeTextEdit.Name = "shelfLifeTextEdit"
        Me.shelfLifeTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.shelfLifeTextEdit.TabIndex = 15
        '
        'layersPerPalletTextEdit
        '
        Me.layersPerPalletTextEdit.Location = New System.Drawing.Point(478, 387)
        Me.layersPerPalletTextEdit.Name = "layersPerPalletTextEdit"
        Me.layersPerPalletTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.layersPerPalletTextEdit.TabIndex = 13
        '
        'cassesPerLayerTextEdit
        '
        Me.cassesPerLayerTextEdit.Location = New System.Drawing.Point(170, 387)
        Me.cassesPerLayerTextEdit.Name = "cassesPerLayerTextEdit"
        Me.cassesPerLayerTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.cassesPerLayerTextEdit.TabIndex = 11
        '
        'mavTextEdit
        '
        Me.mavTextEdit.Location = New System.Drawing.Point(478, 361)
        Me.mavTextEdit.Name = "mavTextEdit"
        Me.mavTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.mavTextEdit.TabIndex = 9
        '
        'requiredWeightTextEdit
        '
        Me.requiredWeightTextEdit.Location = New System.Drawing.Point(170, 359)
        Me.requiredWeightTextEdit.Name = "requiredWeightTextEdit"
        Me.requiredWeightTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.requiredWeightTextEdit.TabIndex = 7
        '
        'caseCodeMemoEdit
        '
        Me.caseCodeMemoEdit.Location = New System.Drawing.Point(170, 157)
        Me.caseCodeMemoEdit.Name = "caseCodeMemoEdit"
        Me.caseCodeMemoEdit.Size = New System.Drawing.Size(408, 96)
        Me.caseCodeMemoEdit.TabIndex = 3
        '
        'packageCodeMemoEdit
        '
        Me.packageCodeMemoEdit.Location = New System.Drawing.Point(170, 54)
        Me.packageCodeMemoEdit.Name = "packageCodeMemoEdit"
        Me.packageCodeMemoEdit.Size = New System.Drawing.Size(408, 96)
        Me.packageCodeMemoEdit.TabIndex = 1
        '
        'shippingReturnXtraTabPage
        '
        Me.shippingReturnXtraTabPage.Controls.Add(Me.shippingReturnGridControl)
        Me.shippingReturnXtraTabPage.Name = "shippingReturnXtraTabPage"
        Me.shippingReturnXtraTabPage.Size = New System.Drawing.Size(686, 488)
        Me.shippingReturnXtraTabPage.Text = "Shipping Returns"
        '
        'shippingReturnGridControl
        '
        Me.shippingReturnGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.shippingReturnGridControl.Location = New System.Drawing.Point(0, 0)
        Me.shippingReturnGridControl.MainView = Me.shippingReturnGridView
        Me.shippingReturnGridControl.Name = "shippingReturnGridControl"
        Me.shippingReturnGridControl.Size = New System.Drawing.Size(686, 488)
        Me.shippingReturnGridControl.TabIndex = 1
        Me.shippingReturnGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.shippingReturnGridView})
        '
        'shippingReturnGridView
        '
        Me.shippingReturnGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.shippingReturnIDGridColumn, Me.returnShippingIDGridColumn, Me.shippingReturnDateGridColumn, Me.shippingReturnBOLGridColumn, Me.shippingReturnLotGridColumn, Me.shippingReturnQuantityGridColumn, Me.shippingReturnExpirationDateGridColumn})
        Me.shippingReturnGridView.GridControl = Me.shippingReturnGridControl
        Me.shippingReturnGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "intUnits", Me.shippingReturnQuantityGridColumn, "{0:#,##0.######}")})
        Me.shippingReturnGridView.Name = "shippingReturnGridView"
        Me.shippingReturnGridView.OptionsBehavior.Editable = false
        Me.shippingReturnGridView.OptionsView.ShowAutoFilterRow = true
        Me.shippingReturnGridView.OptionsView.ShowFooter = true
        '
        'shippingReturnIDGridColumn
        '
        Me.shippingReturnIDGridColumn.Caption = "Detail ID"
        Me.shippingReturnIDGridColumn.Name = "shippingReturnIDGridColumn"
        Me.shippingReturnIDGridColumn.OptionsColumn.AllowEdit = false
        Me.shippingReturnIDGridColumn.OptionsColumn.ReadOnly = true
        '
        'returnShippingIDGridColumn
        '
        Me.returnShippingIDGridColumn.Caption = "Shipping ID"
        Me.returnShippingIDGridColumn.Name = "returnShippingIDGridColumn"
        Me.returnShippingIDGridColumn.OptionsColumn.AllowEdit = false
        Me.returnShippingIDGridColumn.OptionsColumn.ReadOnly = true
        '
        'shippingReturnDateGridColumn
        '
        Me.shippingReturnDateGridColumn.Caption = "Date"
        Me.shippingReturnDateGridColumn.Name = "shippingReturnDateGridColumn"
        Me.shippingReturnDateGridColumn.OptionsColumn.AllowEdit = false
        Me.shippingReturnDateGridColumn.OptionsColumn.ReadOnly = true
        Me.shippingReturnDateGridColumn.Visible = true
        Me.shippingReturnDateGridColumn.VisibleIndex = 0
        '
        'shippingReturnBOLGridColumn
        '
        Me.shippingReturnBOLGridColumn.Caption = "BOL #"
        Me.shippingReturnBOLGridColumn.Name = "shippingReturnBOLGridColumn"
        Me.shippingReturnBOLGridColumn.OptionsColumn.AllowEdit = false
        Me.shippingReturnBOLGridColumn.OptionsColumn.ReadOnly = true
        Me.shippingReturnBOLGridColumn.Visible = true
        Me.shippingReturnBOLGridColumn.VisibleIndex = 1
        '
        'shippingReturnLotGridColumn
        '
        Me.shippingReturnLotGridColumn.Caption = "Lot"
        Me.shippingReturnLotGridColumn.Name = "shippingReturnLotGridColumn"
        Me.shippingReturnLotGridColumn.OptionsColumn.AllowEdit = false
        Me.shippingReturnLotGridColumn.OptionsColumn.ReadOnly = true
        Me.shippingReturnLotGridColumn.Visible = true
        Me.shippingReturnLotGridColumn.VisibleIndex = 2
        '
        'shippingReturnQuantityGridColumn
        '
        Me.shippingReturnQuantityGridColumn.Caption = "Quantity"
        Me.shippingReturnQuantityGridColumn.Name = "shippingReturnQuantityGridColumn"
        Me.shippingReturnQuantityGridColumn.OptionsColumn.AllowEdit = false
        Me.shippingReturnQuantityGridColumn.OptionsColumn.ReadOnly = true
        Me.shippingReturnQuantityGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "TOTAL        {0}")})
        Me.shippingReturnQuantityGridColumn.Visible = true
        Me.shippingReturnQuantityGridColumn.VisibleIndex = 4
        '
        'shippingReturnExpirationDateGridColumn
        '
        Me.shippingReturnExpirationDateGridColumn.Caption = "Expiration Date"
        Me.shippingReturnExpirationDateGridColumn.DisplayFormat.FormatString = "d"
        Me.shippingReturnExpirationDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.shippingReturnExpirationDateGridColumn.Name = "shippingReturnExpirationDateGridColumn"
        Me.shippingReturnExpirationDateGridColumn.OptionsColumn.AllowEdit = false
        Me.shippingReturnExpirationDateGridColumn.OptionsColumn.ReadOnly = true
        Me.shippingReturnExpirationDateGridColumn.Visible = true
        Me.shippingReturnExpirationDateGridColumn.VisibleIndex = 3
        '
        'receivingReturnXtraTabPage
        '
        Me.receivingReturnXtraTabPage.Controls.Add(Me.receivingReturnGridControl)
        Me.receivingReturnXtraTabPage.Name = "receivingReturnXtraTabPage"
        Me.receivingReturnXtraTabPage.Size = New System.Drawing.Size(686, 488)
        Me.receivingReturnXtraTabPage.Text = "Receiving Returns"
        '
        'receivingReturnGridControl
        '
        Me.receivingReturnGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.receivingReturnGridControl.Location = New System.Drawing.Point(0, 0)
        Me.receivingReturnGridControl.MainView = Me.receivingReturnGridView
        Me.receivingReturnGridControl.Name = "receivingReturnGridControl"
        Me.receivingReturnGridControl.Size = New System.Drawing.Size(686, 488)
        Me.receivingReturnGridControl.TabIndex = 1
        Me.receivingReturnGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.receivingReturnGridView})
        '
        'receivingReturnGridView
        '
        Me.receivingReturnGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.receivingReturnIDGridColumn, Me.returnReceivingIDGridColumn, Me.receivingReturnLotGridColumn, Me.receivingReturnQuantityGridColumn, Me.receivingReturnDateGridColumn, Me.receivingReturnBolGridColumn, Me.receivingReturnExpirationDateGridColumn})
        Me.receivingReturnGridView.GridControl = Me.receivingReturnGridControl
        Me.receivingReturnGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ReturnDetQty", Me.receivingReturnQuantityGridColumn, "{0:#,##0.######}")})
        Me.receivingReturnGridView.Name = "receivingReturnGridView"
        Me.receivingReturnGridView.OptionsBehavior.Editable = false
        Me.receivingReturnGridView.OptionsView.ShowAutoFilterRow = true
        Me.receivingReturnGridView.OptionsView.ShowFooter = true
        '
        'receivingReturnIDGridColumn
        '
        Me.receivingReturnIDGridColumn.Caption = "Detail ID"
        Me.receivingReturnIDGridColumn.Name = "receivingReturnIDGridColumn"
        Me.receivingReturnIDGridColumn.OptionsColumn.AllowEdit = false
        Me.receivingReturnIDGridColumn.OptionsColumn.ReadOnly = true
        '
        'returnReceivingIDGridColumn
        '
        Me.returnReceivingIDGridColumn.Caption = "Receiving ID"
        Me.returnReceivingIDGridColumn.Name = "returnReceivingIDGridColumn"
        Me.returnReceivingIDGridColumn.OptionsColumn.AllowEdit = false
        Me.returnReceivingIDGridColumn.OptionsColumn.ReadOnly = true
        '
        'receivingReturnLotGridColumn
        '
        Me.receivingReturnLotGridColumn.Caption = "Lot"
        Me.receivingReturnLotGridColumn.Name = "receivingReturnLotGridColumn"
        Me.receivingReturnLotGridColumn.OptionsColumn.AllowEdit = false
        Me.receivingReturnLotGridColumn.OptionsColumn.ReadOnly = true
        Me.receivingReturnLotGridColumn.Visible = true
        Me.receivingReturnLotGridColumn.VisibleIndex = 1
        '
        'receivingReturnQuantityGridColumn
        '
        Me.receivingReturnQuantityGridColumn.Caption = "Quantity"
        Me.receivingReturnQuantityGridColumn.Name = "receivingReturnQuantityGridColumn"
        Me.receivingReturnQuantityGridColumn.OptionsColumn.AllowEdit = false
        Me.receivingReturnQuantityGridColumn.OptionsColumn.ReadOnly = true
        Me.receivingReturnQuantityGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "TOTAL        {0}")})
        Me.receivingReturnQuantityGridColumn.Visible = true
        Me.receivingReturnQuantityGridColumn.VisibleIndex = 4
        '
        'receivingReturnDateGridColumn
        '
        Me.receivingReturnDateGridColumn.Caption = "Date"
        Me.receivingReturnDateGridColumn.Name = "receivingReturnDateGridColumn"
        Me.receivingReturnDateGridColumn.OptionsColumn.AllowEdit = false
        Me.receivingReturnDateGridColumn.OptionsColumn.ReadOnly = true
        Me.receivingReturnDateGridColumn.Visible = true
        Me.receivingReturnDateGridColumn.VisibleIndex = 0
        '
        'receivingReturnBolGridColumn
        '
        Me.receivingReturnBolGridColumn.Caption = "BOL"
        Me.receivingReturnBolGridColumn.Name = "receivingReturnBolGridColumn"
        Me.receivingReturnBolGridColumn.OptionsColumn.AllowEdit = false
        Me.receivingReturnBolGridColumn.OptionsColumn.ReadOnly = true
        Me.receivingReturnBolGridColumn.Visible = true
        Me.receivingReturnBolGridColumn.VisibleIndex = 3
        '
        'receivingReturnExpirationDateGridColumn
        '
        Me.receivingReturnExpirationDateGridColumn.Caption = "Expiration Date"
        Me.receivingReturnExpirationDateGridColumn.DisplayFormat.FormatString = "d"
        Me.receivingReturnExpirationDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.receivingReturnExpirationDateGridColumn.Name = "receivingReturnExpirationDateGridColumn"
        Me.receivingReturnExpirationDateGridColumn.Visible = true
        Me.receivingReturnExpirationDateGridColumn.VisibleIndex = 2
        '
        'adjustmentXtraTabPage
        '
        Me.adjustmentXtraTabPage.Controls.Add(Me.adjustmentGridControl)
        Me.adjustmentXtraTabPage.Name = "adjustmentXtraTabPage"
        Me.adjustmentXtraTabPage.Size = New System.Drawing.Size(686, 488)
        Me.adjustmentXtraTabPage.Text = "Adjustments"
        '
        'adjustmentGridControl
        '
        Me.adjustmentGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.adjustmentGridControl.Location = New System.Drawing.Point(0, 0)
        Me.adjustmentGridControl.MainView = Me.adjustmentGridView
        Me.adjustmentGridControl.Name = "adjustmentGridControl"
        Me.adjustmentGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.reasonRepositoryItemMemoExEdit})
        Me.adjustmentGridControl.Size = New System.Drawing.Size(686, 488)
        Me.adjustmentGridControl.TabIndex = 5
        Me.adjustmentGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.adjustmentGridView})
        '
        'adjustmentGridView
        '
        Me.adjustmentGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.adjustmentIDGridColumn, Me.adjustmentDateGridColumn, Me.adjustmentOriginalQuantityGridColumn, Me.adjustmentNewQtyGridColumn, Me.adjustmentQuantityGridColumn, Me.adjustmentReasonGridColumn})
        Me.adjustmentGridView.GridControl = Me.adjustmentGridControl
        Me.adjustmentGridView.Name = "adjustmentGridView"
        Me.adjustmentGridView.OptionsBehavior.ReadOnly = true
        Me.adjustmentGridView.OptionsView.ShowAutoFilterRow = true
        Me.adjustmentGridView.OptionsView.ShowFooter = true
        '
        'adjustmentIDGridColumn
        '
        Me.adjustmentIDGridColumn.Caption = "GridColumn1"
        Me.adjustmentIDGridColumn.FieldName = "AdjustmentID"
        Me.adjustmentIDGridColumn.Name = "adjustmentIDGridColumn"
        Me.adjustmentIDGridColumn.OptionsColumn.AllowEdit = false
        Me.adjustmentIDGridColumn.OptionsColumn.ReadOnly = true
        '
        'adjustmentDateGridColumn
        '
        Me.adjustmentDateGridColumn.Caption = "Date"
        Me.adjustmentDateGridColumn.DisplayFormat.FormatString = "D"
        Me.adjustmentDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.adjustmentDateGridColumn.FieldName = "AdjustmentDate"
        Me.adjustmentDateGridColumn.Name = "adjustmentDateGridColumn"
        Me.adjustmentDateGridColumn.OptionsColumn.AllowEdit = false
        Me.adjustmentDateGridColumn.OptionsColumn.ReadOnly = true
        Me.adjustmentDateGridColumn.Visible = true
        Me.adjustmentDateGridColumn.VisibleIndex = 0
        Me.adjustmentDateGridColumn.Width = 98
        '
        'adjustmentOriginalQuantityGridColumn
        '
        Me.adjustmentOriginalQuantityGridColumn.Caption = "Orig. Qty"
        Me.adjustmentOriginalQuantityGridColumn.DisplayFormat.FormatString = "{0:#,##0.######}"
        Me.adjustmentOriginalQuantityGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.adjustmentOriginalQuantityGridColumn.FieldName = "OriginalQuantity"
        Me.adjustmentOriginalQuantityGridColumn.Name = "adjustmentOriginalQuantityGridColumn"
        Me.adjustmentOriginalQuantityGridColumn.OptionsColumn.AllowEdit = false
        Me.adjustmentOriginalQuantityGridColumn.OptionsColumn.FixedWidth = true
        Me.adjustmentOriginalQuantityGridColumn.OptionsColumn.ReadOnly = true
        Me.adjustmentOriginalQuantityGridColumn.Visible = true
        Me.adjustmentOriginalQuantityGridColumn.VisibleIndex = 1
        Me.adjustmentOriginalQuantityGridColumn.Width = 60
        '
        'adjustmentNewQtyGridColumn
        '
        Me.adjustmentNewQtyGridColumn.Caption = "New Qty"
        Me.adjustmentNewQtyGridColumn.FieldName = "NewCount"
        Me.adjustmentNewQtyGridColumn.Name = "adjustmentNewQtyGridColumn"
        Me.adjustmentNewQtyGridColumn.OptionsColumn.AllowEdit = false
        Me.adjustmentNewQtyGridColumn.OptionsColumn.FixedWidth = true
        Me.adjustmentNewQtyGridColumn.OptionsColumn.ReadOnly = true
        Me.adjustmentNewQtyGridColumn.Visible = true
        Me.adjustmentNewQtyGridColumn.VisibleIndex = 2
        Me.adjustmentNewQtyGridColumn.Width = 60
        '
        'adjustmentQuantityGridColumn
        '
        Me.adjustmentQuantityGridColumn.Caption = "Adjustment"
        Me.adjustmentQuantityGridColumn.DisplayFormat.FormatString = "##;-##"
        Me.adjustmentQuantityGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.adjustmentQuantityGridColumn.FieldName = "adjustmentGridColumn"
        Me.adjustmentQuantityGridColumn.Name = "adjustmentQuantityGridColumn"
        Me.adjustmentQuantityGridColumn.OptionsColumn.AllowEdit = false
        Me.adjustmentQuantityGridColumn.OptionsColumn.FixedWidth = true
        Me.adjustmentQuantityGridColumn.OptionsColumn.ReadOnly = true
        Me.adjustmentQuantityGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.adjustmentQuantityGridColumn.Visible = true
        Me.adjustmentQuantityGridColumn.VisibleIndex = 3
        Me.adjustmentQuantityGridColumn.Width = 65
        '
        'adjustmentReasonGridColumn
        '
        Me.adjustmentReasonGridColumn.Caption = "Reason"
        Me.adjustmentReasonGridColumn.ColumnEdit = Me.reasonRepositoryItemMemoExEdit
        Me.adjustmentReasonGridColumn.FieldName = "Reason"
        Me.adjustmentReasonGridColumn.Name = "adjustmentReasonGridColumn"
        Me.adjustmentReasonGridColumn.OptionsColumn.ReadOnly = true
        Me.adjustmentReasonGridColumn.Visible = true
        Me.adjustmentReasonGridColumn.VisibleIndex = 4
        Me.adjustmentReasonGridColumn.Width = 110
        '
        'reasonRepositoryItemMemoExEdit
        '
        Me.reasonRepositoryItemMemoExEdit.AutoHeight = false
        Me.reasonRepositoryItemMemoExEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.reasonRepositoryItemMemoExEdit.Name = "reasonRepositoryItemMemoExEdit"
        '
        'transfersXtraTabPage
        '
        Me.transfersXtraTabPage.Controls.Add(Me.transfersGridControl)
        Me.transfersXtraTabPage.Name = "transfersXtraTabPage"
        Me.transfersXtraTabPage.Size = New System.Drawing.Size(686, 488)
        Me.transfersXtraTabPage.Text = "Transfers"
        '
        'transfersGridControl
        '
        Me.transfersGridControl.DataSource = Me.transfersXpView
        Me.transfersGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.transfersGridControl.Location = New System.Drawing.Point(0, 0)
        Me.transfersGridControl.MainView = Me.transfersGridView
        Me.transfersGridControl.MenuManager = Me.BarManager1
        Me.transfersGridControl.Name = "transfersGridControl"
        Me.transfersGridControl.Size = New System.Drawing.Size(686, 488)
        Me.transfersGridControl.TabIndex = 0
        Me.transfersGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.transfersGridView})
        '
        'transfersXpView
        '
        Me.transfersXpView.CriteriaString = "[TransferItem.ItemID] = 0"
        Me.transfersXpView.ObjectType = GetType(DXDAL.SPGData.LocationTransferDetails)
        Me.transfersXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("Date", DevExpress.Xpo.SortDirection.Ascending, "[Transfer.TransferDate]", false, true), New DevExpress.Xpo.ViewProperty("FromLocation", DevExpress.Xpo.SortDirection.None, "[Transfer.FromLocation.LocationCode]", false, true), New DevExpress.Xpo.ViewProperty("ToLocation", DevExpress.Xpo.SortDirection.None, "[Transfer.ToLocation.LocationCode]", false, true), New DevExpress.Xpo.ViewProperty("Lot", DevExpress.Xpo.SortDirection.None, "[TransferLot]", false, true), New DevExpress.Xpo.ViewProperty("Quantity", DevExpress.Xpo.SortDirection.None, "[TransferQuantity]", false, true), New DevExpress.Xpo.ViewProperty("Units", DevExpress.Xpo.SortDirection.None, "[TransferUnits]", false, true), New DevExpress.Xpo.ViewProperty("Pallets", DevExpress.Xpo.SortDirection.None, "[TransferPallets]", false, true), New DevExpress.Xpo.ViewProperty("ItemExpirationDate", DevExpress.Xpo.SortDirection.None, "[ItemExpirationDate]", false, true)})
        '
        'transfersGridView
        '
        Me.transfersGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDate, Me.colFromLocation, Me.colToLocation, Me.colLot, Me.colTransferQuantity, Me.colUnits, Me.colPallets, Me.colItemExpirationDate})
        Me.transfersGridView.GridControl = Me.transfersGridControl
        Me.transfersGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", Me.colTransferQuantity, "{0:#,##0.######}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Pallets", Me.colPallets, "{0:#,##0.######}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Units", Me.colUnits, "{0:#,##0.######}")})
        Me.transfersGridView.Name = "transfersGridView"
        Me.transfersGridView.OptionsBehavior.Editable = false
        Me.transfersGridView.OptionsView.ShowAutoFilterRow = true
        Me.transfersGridView.OptionsView.ShowDetailButtons = false
        Me.transfersGridView.OptionsView.ShowFooter = true
        '
        'colDate
        '
        Me.colDate.FieldName = "Date"
        Me.colDate.Name = "colDate"
        Me.colDate.OptionsColumn.ReadOnly = true
        Me.colDate.Visible = true
        Me.colDate.VisibleIndex = 0
        '
        'colFromLocation
        '
        Me.colFromLocation.FieldName = "FromLocation"
        Me.colFromLocation.Name = "colFromLocation"
        Me.colFromLocation.OptionsColumn.ReadOnly = true
        Me.colFromLocation.Visible = true
        Me.colFromLocation.VisibleIndex = 1
        '
        'colToLocation
        '
        Me.colToLocation.FieldName = "ToLocation"
        Me.colToLocation.Name = "colToLocation"
        Me.colToLocation.OptionsColumn.ReadOnly = true
        Me.colToLocation.Visible = true
        Me.colToLocation.VisibleIndex = 2
        '
        'colLot
        '
        Me.colLot.FieldName = "Lot"
        Me.colLot.Name = "colLot"
        Me.colLot.OptionsColumn.ReadOnly = true
        Me.colLot.Visible = true
        Me.colLot.VisibleIndex = 3
        '
        'colTransferQuantity
        '
        Me.colTransferQuantity.FieldName = "Quantity"
        Me.colTransferQuantity.Name = "colTransferQuantity"
        Me.colTransferQuantity.OptionsColumn.ReadOnly = true
        Me.colTransferQuantity.Visible = true
        Me.colTransferQuantity.VisibleIndex = 4
        '
        'colUnits
        '
        Me.colUnits.FieldName = "Units"
        Me.colUnits.Name = "colUnits"
        Me.colUnits.OptionsColumn.ReadOnly = true
        Me.colUnits.Visible = true
        Me.colUnits.VisibleIndex = 5
        '
        'colPallets
        '
        Me.colPallets.FieldName = "Pallets"
        Me.colPallets.Name = "colPallets"
        Me.colPallets.OptionsColumn.ReadOnly = true
        Me.colPallets.Visible = true
        Me.colPallets.VisibleIndex = 6
        '
        'colItemExpirationDate
        '
        Me.colItemExpirationDate.Caption = "Item Expiration Date"
        Me.colItemExpirationDate.FieldName = "ItemExpirationDate"
        Me.colItemExpirationDate.Name = "colItemExpirationDate"
        Me.colItemExpirationDate.Visible = true
        Me.colItemExpirationDate.VisibleIndex = 7
        '
        'productionStandardsXtraTabPage
        '
        Me.productionStandardsXtraTabPage.Controls.Add(Me.productionStandardsGridControl)
        Me.productionStandardsXtraTabPage.Name = "productionStandardsXtraTabPage"
        Me.productionStandardsXtraTabPage.Size = New System.Drawing.Size(686, 488)
        Me.productionStandardsXtraTabPage.Text = "Production Standards"
        '
        'productionStandardsGridControl
        '
        Me.productionStandardsGridControl.DataSource = Me.productionStandardsXpCollection
        Me.productionStandardsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.productionStandardsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.productionStandardsGridControl.MainView = Me.productionStandardsGridView
        Me.productionStandardsGridControl.MenuManager = Me.BarManager1
        Me.productionStandardsGridControl.Name = "productionStandardsGridControl"
        Me.productionStandardsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.machineRepositoryItemLookUpEdit, Me.delProdStdRepositoryItemButtonEdit})
        Me.productionStandardsGridControl.Size = New System.Drawing.Size(686, 488)
        Me.productionStandardsGridControl.TabIndex = 0
        Me.productionStandardsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.productionStandardsGridView})
        '
        'productionStandardsXpCollection
        '
        Me.productionStandardsXpCollection.ObjectType = GetType(DXDAL.SPGData.ItemMachineStandards)
        '
        'productionStandardsGridView
        '
        Me.productionStandardsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.delProdStdGridColumn, Me.colOid1, Me.colHasChanges, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn5, Me.colProductionPerMinute, Me.colMinutesPerShift, Me.colProjectedPackers})
        Me.productionStandardsGridView.GridControl = Me.productionStandardsGridControl
        Me.productionStandardsGridView.Name = "productionStandardsGridView"
        Me.productionStandardsGridView.OptionsSelection.MultiSelect = true
        Me.productionStandardsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.productionStandardsGridView.OptionsView.ShowDetailButtons = false
        '
        'delProdStdGridColumn
        '
        Me.delProdStdGridColumn.ColumnEdit = Me.delProdStdRepositoryItemButtonEdit
        Me.delProdStdGridColumn.MaxWidth = 25
        Me.delProdStdGridColumn.Name = "delProdStdGridColumn"
        Me.delProdStdGridColumn.Visible = true
        Me.delProdStdGridColumn.VisibleIndex = 0
        Me.delProdStdGridColumn.Width = 22
        '
        'delProdStdRepositoryItemButtonEdit
        '
        Me.delProdStdRepositoryItemButtonEdit.AutoHeight = false
        Me.delProdStdRepositoryItemButtonEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.delProdStdRepositoryItemButtonEdit.Name = "delProdStdRepositoryItemButtonEdit"
        Me.delProdStdRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colOid1
        '
        Me.colOid1.FieldName = "Oid"
        Me.colOid1.Name = "colOid1"
        '
        'colHasChanges
        '
        Me.colHasChanges.FieldName = "HasChanges"
        Me.colHasChanges.Name = "colHasChanges"
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "ProductionItem!"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "ProductionItem!Key"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "Machine!"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn5
        '
        Me.GridColumn5.ColumnEdit = Me.machineRepositoryItemLookUpEdit
        Me.GridColumn5.FieldName = "Machine!Key"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = true
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 192
        '
        'machineRepositoryItemLookUpEdit
        '
        Me.machineRepositoryItemLookUpEdit.AutoHeight = false
        Me.machineRepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.machineRepositoryItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MachineLineID", "Machine Line ID", 98, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("MachineLineName", "Machine Line Name", 101, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
        Me.machineRepositoryItemLookUpEdit.DataSource = Me.machineLineXpView
        Me.machineRepositoryItemLookUpEdit.DisplayMember = "MachineLineName"
        Me.machineRepositoryItemLookUpEdit.Name = "machineRepositoryItemLookUpEdit"
        Me.machineRepositoryItemLookUpEdit.ValueMember = "MachineLineID"
        '
        'colProductionPerMinute
        '
        Me.colProductionPerMinute.FieldName = "ProductionPerMinute"
        Me.colProductionPerMinute.Name = "colProductionPerMinute"
        Me.colProductionPerMinute.Visible = true
        Me.colProductionPerMinute.VisibleIndex = 2
        Me.colProductionPerMinute.Width = 192
        '
        'colMinutesPerShift
        '
        Me.colMinutesPerShift.FieldName = "MinutesPerShift"
        Me.colMinutesPerShift.Name = "colMinutesPerShift"
        Me.colMinutesPerShift.Visible = true
        Me.colMinutesPerShift.VisibleIndex = 3
        Me.colMinutesPerShift.Width = 193
        '
        'colProjectedPackers
        '
        Me.colProjectedPackers.FieldName = "ProjectedPackers"
        Me.colProjectedPackers.Name = "colProjectedPackers"
        Me.colProjectedPackers.Visible = true
        Me.colProjectedPackers.VisibleIndex = 4
        Me.colProjectedPackers.Width = 180
        '
        'typeFilterLookUpEdit
        '
        Me.typeFilterLookUpEdit.Location = New System.Drawing.Point(267, 3)
        Me.typeFilterLookUpEdit.Name = "typeFilterLookUpEdit"
        Me.typeFilterLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.typeFilterLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.typeFilterLookUpEdit.Properties.NullText = "[Filter By Item Type]"
        Me.typeFilterLookUpEdit.Size = New System.Drawing.Size(162, 20)
        Me.typeFilterLookUpEdit.TabIndex = 2
        Me.typeFilterLookUpEdit.Visible = false
        '
        'clearFilterSimpleButton
        '
        Me.clearFilterSimpleButton.Location = New System.Drawing.Point(443, 0)
        Me.clearFilterSimpleButton.Name = "clearFilterSimpleButton"
        Me.clearFilterSimpleButton.Size = New System.Drawing.Size(75, 23)
        Me.clearFilterSimpleButton.TabIndex = 3
        Me.clearFilterSimpleButton.Text = "Clear Filter"
        Me.clearFilterSimpleButton.Visible = false
        '
        'patternOpenFileDialog
        '
        Me.patternOpenFileDialog.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*"""
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 49)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.itemsSearchGridControl)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.inactiveSearchCheckEdit)
        Me.SplitContainerControl1.Panel1.MinSize = 250
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.itemsXtraTabControl)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.clearFilterSimpleButton)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.customerFilterLookUpEdit)
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.typeFilterLookUpEdit)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(947, 516)
        Me.SplitContainerControl1.TabIndex = 8
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'itemsSearchGridControl
        '
        Me.itemsSearchGridControl.DataSource = Me.itemSearchXPView
        Me.itemsSearchGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.itemsSearchGridControl.Location = New System.Drawing.Point(0, 0)
        Me.itemsSearchGridControl.MainView = Me.itemSearchGridView
        Me.itemsSearchGridControl.Name = "itemsSearchGridControl"
        Me.itemsSearchGridControl.Size = New System.Drawing.Size(250, 497)
        Me.itemsSearchGridControl.TabIndex = 1
        Me.itemsSearchGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.itemSearchGridView})
        '
        'itemSearchXPView
        '
        Me.itemSearchXPView.ObjectType = GetType(DXDAL.SPGData.Items)
        Me.itemSearchXPView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[ItemID]", false, true), New DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.Ascending, "[ItemCode]", false, true), New DevExpress.Xpo.ViewProperty("ItemType", DevExpress.Xpo.SortDirection.None, "[ItemType]", false, true), New DevExpress.Xpo.ViewProperty("Customer", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID.CustomerName]", false, true), New DevExpress.Xpo.ViewProperty("Inactive", DevExpress.Xpo.SortDirection.None, "[Inactive]", false, true)})
        '
        'itemSearchGridView
        '
        Me.itemSearchGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.itemIDGridColumn, Me.itemCodeGridColumn, Me.itemCustomerGridColumn, Me.itemTypeGridColumn})
        Me.itemSearchGridView.GridControl = Me.itemsSearchGridControl
        Me.itemSearchGridView.Name = "itemSearchGridView"
        Me.itemSearchGridView.OptionsBehavior.Editable = false
        Me.itemSearchGridView.OptionsView.ShowAutoFilterRow = true
        Me.itemSearchGridView.OptionsView.ShowGroupPanel = false
        '
        'itemIDGridColumn
        '
        Me.itemIDGridColumn.Caption = "GridColumn1"
        Me.itemIDGridColumn.FieldName = "ItemID"
        Me.itemIDGridColumn.Name = "itemIDGridColumn"
        '
        'itemCodeGridColumn
        '
        Me.itemCodeGridColumn.Caption = "Item #"
        Me.itemCodeGridColumn.FieldName = "ItemCode"
        Me.itemCodeGridColumn.Name = "itemCodeGridColumn"
        Me.itemCodeGridColumn.Visible = true
        Me.itemCodeGridColumn.VisibleIndex = 0
        '
        'itemCustomerGridColumn
        '
        Me.itemCustomerGridColumn.Caption = "Customer"
        Me.itemCustomerGridColumn.FieldName = "Customer"
        Me.itemCustomerGridColumn.Name = "itemCustomerGridColumn"
        Me.itemCustomerGridColumn.Visible = true
        Me.itemCustomerGridColumn.VisibleIndex = 1
        '
        'itemTypeGridColumn
        '
        Me.itemTypeGridColumn.Caption = "Type"
        Me.itemTypeGridColumn.FieldName = "ItemType"
        Me.itemTypeGridColumn.Name = "itemTypeGridColumn"
        Me.itemTypeGridColumn.Visible = true
        Me.itemTypeGridColumn.VisibleIndex = 2
        '
        'inactiveSearchCheckEdit
        '
        Me.inactiveSearchCheckEdit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.inactiveSearchCheckEdit.Location = New System.Drawing.Point(0, 497)
        Me.inactiveSearchCheckEdit.Name = "inactiveSearchCheckEdit"
        Me.inactiveSearchCheckEdit.Properties.Caption = "Include Inactive"
        Me.inactiveSearchCheckEdit.Size = New System.Drawing.Size(250, 19)
        Me.inactiveSearchCheckEdit.TabIndex = 0
        '
        'ItemsXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 588)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "ItemsXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Items Manager"
        CType(Me.poolDetailsGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.poolBomGridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.poolBomXpCollection,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.poolBomGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.poolBomDeleteRepositoryItemButtonEdit,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.poolsRepositoryItemLookUpEdit,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.itemPoolsXpView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BarManager1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.customerFilterLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.itemsXtraTabControl,System.ComponentModel.ISupportInitialize).EndInit
        Me.itemsXtraTabControl.ResumeLayout(false)
        Me.generalXtraTabPage.ResumeLayout(false)
        Me.generalXtraTabPage.PerformLayout
        CType(Me.minutesPerShiftTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lotCodeFormatLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lotCodeFormatsXpView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.requiresExpirationDateCheckEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.requiresLotCodeCheckEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.generateLotCodesCheckEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.bagsPerCaseTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.inventoryGridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.inventoryXpView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.inventoryGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.upcTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.packersTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.inactiveCheckEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.caseGrossWeightTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.qtyOnHandTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.uomLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.qtyPerUnitTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.unitsPerPalletTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.casesPerPalletTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.unitsPerCaseTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.standardProductionTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.codeTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.defaultMachineLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.machineLineXpView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.customerLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.typeLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.descriptionMemoEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.shippingXtraTabPage.ResumeLayout(false)
        CType(Me.shippingGridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.shippingGridView,System.ComponentModel.ISupportInitialize).EndInit
        Me.productionXtraTabPage.ResumeLayout(false)
        CType(Me.productionGridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.productionGridView,System.ComponentModel.ISupportInitialize).EndInit
        Me.receivingXtraTabPage.ResumeLayout(false)
        CType(Me.receivingsGridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.receivingsGridView,System.ComponentModel.ISupportInitialize).EndInit
        Me.bomXtraTabPage.ResumeLayout(false)
        CType(Me.SplitContainerControl2,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainerControl2.ResumeLayout(false)
        CType(Me.bomGridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BOMGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RMRepositoryItemLookUpEdit,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.deleteRepositoryItemButtonEdit,System.ComponentModel.ISupportInitialize).EndInit
        Me.availabilityXtraTabPage.ResumeLayout(false)
        CType(Me.availabilityGridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.availabilityGridView,System.ComponentModel.ISupportInitialize).EndInit
        Me.advancedXtraTabPage.ResumeLayout(false)
        Me.advancedXtraTabPage.PerformLayout
        CType(Me.other5TextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.other4TextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.other3TextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.other2TextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.other1TextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.palletsTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stretchWrapTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.boxesTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.filmTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.freightTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.rebateTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.priceTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.specificationXtraTabPage.ResumeLayout(false)
        Me.specificationXtraTabPage.PerformLayout
        CType(Me.palletPatternButtonEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.instructionsMemoEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.shelfLifeTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.layersPerPalletTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cassesPerLayerTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.mavTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.requiredWeightTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.caseCodeMemoEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.packageCodeMemoEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.shippingReturnXtraTabPage.ResumeLayout(false)
        CType(Me.shippingReturnGridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.shippingReturnGridView,System.ComponentModel.ISupportInitialize).EndInit
        Me.receivingReturnXtraTabPage.ResumeLayout(false)
        CType(Me.receivingReturnGridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.receivingReturnGridView,System.ComponentModel.ISupportInitialize).EndInit
        Me.adjustmentXtraTabPage.ResumeLayout(false)
        CType(Me.adjustmentGridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.adjustmentGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.reasonRepositoryItemMemoExEdit,System.ComponentModel.ISupportInitialize).EndInit
        Me.transfersXtraTabPage.ResumeLayout(false)
        CType(Me.transfersGridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.transfersXpView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.transfersGridView,System.ComponentModel.ISupportInitialize).EndInit
        Me.productionStandardsXtraTabPage.ResumeLayout(false)
        CType(Me.productionStandardsGridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.productionStandardsXpCollection,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.productionStandardsGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.delProdStdRepositoryItemButtonEdit,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.machineRepositoryItemLookUpEdit,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.typeFilterLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SplitContainerControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainerControl1.ResumeLayout(false)
        CType(Me.itemsSearchGridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.itemSearchXPView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.itemSearchGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.inactiveSearchCheckEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents customerFilterLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents itemsXtraTabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents generalXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents shippingXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents productionXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents receivingXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents bomXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents advancedXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents qtyPerUnitTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents unitsPerPalletTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents casesPerPalletTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents unitsPerCaseTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents standardProductionTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents codeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents defaultMachineLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents customerLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents typeLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents descriptionMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents shippingGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents shippingGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents shippingDetailIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shippingIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shippingLotGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shippingQuantityGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents productionGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents productionGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents productionDateGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents productionQuantityGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents receivingsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents receivingsGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents receivingDetailIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents receivingIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents receivingLotGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents receivingQuantityGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents other5TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents other4TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents other3TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents other2TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents other1TextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents palletsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents stretchWrapTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents boxesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents filmTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents freightTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents rebateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents priceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents uomLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents qtyOnHandTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents availabilityXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents availabilityGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents availabilityGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents printSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents previewSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents bomItemCodeGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bomItemDescriptionGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents quantityOnHandGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents quantityYieldsGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents quantityRequiredGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents availabilityItemIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents typeFilterLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents clearFilterSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents caseGrossWeightTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents shippingDateGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shippingBOLGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents productionLotGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents productionPOGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents receivingDateGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents receivingBOLGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents specificationXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl32 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl31 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents palletPatternButtonEdit As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents instructionsMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents shelfLifeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents layersPerPalletTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cassesPerLayerTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents mavTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents requiredWeightTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents caseCodeMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents packageCodeMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl35 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl33 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents patternOpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents inactiveCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents itemsMenuBar As DevExpress.XtraBars.Bar
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents addBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents editBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents deleteBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cancelBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents saveBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents palletTicketBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents printGridBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents itemsSearchGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents itemSearchGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents inactiveSearchCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents itemIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents itemCodeGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents itemCustomerGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents itemTypeGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents specificationsBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents scrapPercentageGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ProjectedPackersLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents packersTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents itemSearchXPView As DevExpress.Xpo.XPView
    Friend WithEvents shippingExpirationDateGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents receivingExpirationDateGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents productionExpirationDateGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shippingReturnXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents shippingReturnGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents shippingReturnGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents shippingReturnIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents returnShippingIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shippingReturnDateGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shippingReturnBOLGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shippingReturnLotGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shippingReturnQuantityGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shippingReturnExpirationDateGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents receivingReturnXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents adjustmentXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents receivingReturnGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents receivingReturnGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents receivingReturnIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents returnReceivingIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents receivingReturnLotGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents receivingReturnQuantityGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents receivingReturnDateGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents receivingReturnBolGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents receivingReturnExpirationDateGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents adjustmentGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents adjustmentGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents adjustmentIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents adjustmentDateGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents adjustmentOriginalQuantityGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents adjustmentNewQtyGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents adjustmentQuantityGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents adjustmentReasonGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents reasonRepositoryItemMemoExEdit As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents bomGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents BOMGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents bomIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents FGItemCodeGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RMItemCodeGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RMRepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RMItemDescriptionGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RMQuantityGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents scrapFactorGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents deleteGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents deleteRepositoryItemButtonEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents poolBomGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents poolBomGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents poolBomXpCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents poolIdGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPoolBomQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colScrapFactor As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents poolBomDeleteGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents poolBomDeleteRepositoryItemButtonEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents poolsRepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents itemPoolsXpView As DevExpress.Xpo.XPView
    Friend WithEvents poolDetailsGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents isPoolGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents upcTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents inventoryGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents inventoryGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents inventoryXpView As DevExpress.Xpo.XPView
    Friend WithEvents colLocationCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocationName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents localQuantityOnHandGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents localQuantityYieldsGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents transfersXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents transfersGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents transfersGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents transfersXpView As DevExpress.Xpo.XPView
    Friend WithEvents colDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFromLocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colToLocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransferQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnits As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPallets As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemExpirationDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl36 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bagsPerCaseTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents machineLineXpView As DevExpress.Xpo.XPView
    Friend WithEvents requiresLotCodeCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents generateLotCodesCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents requiresExpirationDateCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl37 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lotCodeFormatLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lotCodeFormatsXpView As DevExpress.Xpo.XPView
    Friend WithEvents productionStandardsXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents productionStandardsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents productionStandardsXpCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents productionStandardsGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHasChanges As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductionPerMinute As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMinutesPerShift As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents machineRepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents delProdStdGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents delProdStdRepositoryItemButtonEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colProjectedPackers As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl38 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents minutesPerShiftTextEdit As DevExpress.XtraEditors.TextEdit
End Class
