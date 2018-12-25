<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LocationXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LocationXtraForm))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.locationMenuBar = New DevExpress.XtraBars.Bar()
        Me.addBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.editBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.deleteBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.cancelBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.saveBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.printGridBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.locationSearchGridControl = New DevExpress.XtraGrid.GridControl()
        Me.locationSearchXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.locationSearchGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLocationID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.locationsXtraTabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.generalXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.defaultWarehouseCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.inventoryAvailableCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.warehousingCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.productionCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.shippingCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.receivingCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.faxTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.phoneTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.zipCodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.stateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.cityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.addressTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.nameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.codeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.oidTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.inventoryXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.inventoryGridControl = New DevExpress.XtraGrid.GridControl()
        Me.locationInventoryXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.inventoryGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.inventoryByLotXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.PrintLpnSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.inventoryByLotGridControl = New DevExpress.XtraGrid.GridControl()
        Me.locationInventoryByLotXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.inventoryByLotGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemCode1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemDescription1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExpirationDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLPNNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuantity1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.transfersXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.transfersToGroupControl = New DevExpress.XtraEditors.GroupControl()
        Me.transfersToGridControl = New DevExpress.XtraGrid.GridControl()
        Me.transfersToXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.transfersToGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTransferToDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFromLocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransferToItemCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransferToItemDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransferToNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransferToItemLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransferToExpirationDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransferToQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.transferToExpirationDateFormatGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.transfersFromGroupControl = New DevExpress.XtraEditors.GroupControl()
        Me.transfersFromGridControl = New DevExpress.XtraGrid.GridControl()
        Me.transfersFromXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.transfersFromGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colTransferDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colToLocation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTansferFromItemCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransferFromItemDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransferNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExpirationDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransferQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTransferFromExpirationDateFormat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.receivingXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.receivingsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.receivingsXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.receivingsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colReceivingDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceivingItemCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceivingItemDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceivingItemType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceivingBOL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceivingLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceivingItemExpirationDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceivingQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceivingExpirationDateFormat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.receivingReturnsXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.receivingReturnsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.receivingReturnXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.receivingReturnsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colReceivingReturnDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceivingReturnItemCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceivingReturnItemDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceivingReturnBOL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceivingReturnLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceivingReturnItemExpirationDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceivingReturnQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReceivingReturnExpirationDateFormat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.productionXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.productionGridControl = New DevExpress.XtraGrid.GridControl()
        Me.productionXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.productionGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProductionDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductionItemCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductionItemDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductionPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductionLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPrdouctionExpirationDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductionQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProductionExpirationDateFormat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shippingsXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.shippingsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.shippingsXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.shippingsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colShippingDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShippingItemCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShippingItemDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShippingBOL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShippingLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShippingExpirationDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShippingQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShippingExpirationDateFormat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shippingReturnsXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.shippingReturnsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.shippingReturnsXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.shippingReturnsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colShippingReturnDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShippingReturnItemCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShippingReturnItemDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShippingReturnBOL = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShippingReturnLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShippingReturnExpirationDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShippingReturnQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShippingReturnExpirationDateFormat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShippingItemType = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.locationSearchGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.locationSearchXpView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.locationSearchGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.locationsXtraTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.locationsXtraTabControl.SuspendLayout()
        Me.generalXtraTabPage.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.defaultWarehouseCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inventoryAvailableCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.warehousingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productionCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shippingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.receivingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.faxTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.phoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zipCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addressTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.codeTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oidTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.inventoryXtraTabPage.SuspendLayout()
        CType(Me.inventoryGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.locationInventoryXpView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inventoryGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.inventoryByLotXtraTabPage.SuspendLayout()
        CType(Me.inventoryByLotGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.locationInventoryByLotXpView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inventoryByLotGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.transfersXtraTabPage.SuspendLayout()
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl2.SuspendLayout()
        CType(Me.transfersToGroupControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.transfersToGroupControl.SuspendLayout()
        CType(Me.transfersToGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.transfersToXpView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.transfersToGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.transfersFromGroupControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.transfersFromGroupControl.SuspendLayout()
        CType(Me.transfersFromGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.transfersFromXpView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.transfersFromGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.receivingXtraTabPage.SuspendLayout()
        CType(Me.receivingsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.receivingsXpView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.receivingsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.receivingReturnsXtraTabPage.SuspendLayout()
        CType(Me.receivingReturnsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.receivingReturnXpView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.receivingReturnsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.productionXtraTabPage.SuspendLayout()
        CType(Me.productionGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productionXpView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.productionGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.shippingsXtraTabPage.SuspendLayout()
        CType(Me.shippingsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shippingsXpView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shippingsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.shippingReturnsXtraTabPage.SuspendLayout()
        CType(Me.shippingReturnsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shippingReturnsXpView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shippingReturnsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.locationMenuBar, Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.addBarButtonItem, Me.editBarButtonItem, Me.deleteBarButtonItem, Me.cancelBarButtonItem, Me.saveBarButtonItem, Me.printGridBarButtonItem})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 6
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'locationMenuBar
        '
        Me.locationMenuBar.BarName = "Tools"
        Me.locationMenuBar.DockCol = 0
        Me.locationMenuBar.DockRow = 1
        Me.locationMenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.locationMenuBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.addBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.editBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.cancelBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.saveBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.printGridBarButtonItem, True)})
        Me.locationMenuBar.OptionsBar.UseWholeRow = True
        Me.locationMenuBar.Text = "Tools"
        '
        'addBarButtonItem
        '
        Me.addBarButtonItem.Caption = "&Add Location"
        Me.addBarButtonItem.Id = 0
        Me.addBarButtonItem.Name = "addBarButtonItem"
        '
        'editBarButtonItem
        '
        Me.editBarButtonItem.Caption = "&Edit Location"
        Me.editBarButtonItem.Id = 1
        Me.editBarButtonItem.Name = "editBarButtonItem"
        '
        'deleteBarButtonItem
        '
        Me.deleteBarButtonItem.Caption = "Delete Location"
        Me.deleteBarButtonItem.Id = 2
        Me.deleteBarButtonItem.Name = "deleteBarButtonItem"
        '
        'cancelBarButtonItem
        '
        Me.cancelBarButtonItem.Caption = "&Cancel Changes"
        Me.cancelBarButtonItem.Enabled = False
        Me.cancelBarButtonItem.Id = 3
        Me.cancelBarButtonItem.Name = "cancelBarButtonItem"
        '
        'saveBarButtonItem
        '
        Me.saveBarButtonItem.Caption = "&Save Changes"
        Me.saveBarButtonItem.Enabled = False
        Me.saveBarButtonItem.Id = 4
        Me.saveBarButtonItem.Name = "saveBarButtonItem"
        '
        'printGridBarButtonItem
        '
        Me.printGridBarButtonItem.Caption = "&Print Grid"
        Me.printGridBarButtonItem.Id = 5
        Me.printGridBarButtonItem.Name = "printGridBarButtonItem"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(824, 49)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 538)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 49)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 489)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 49)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 489)
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 49)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.locationSearchGridControl)
        Me.SplitContainerControl1.Panel1.MinSize = 250
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.locationsXtraTabControl)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(824, 489)
        Me.SplitContainerControl1.TabIndex = 4
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'locationSearchGridControl
        '
        Me.locationSearchGridControl.DataSource = Me.locationSearchXpView
        Me.locationSearchGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.locationSearchGridControl.Location = New System.Drawing.Point(0, 0)
        Me.locationSearchGridControl.MainView = Me.locationSearchGridView
        Me.locationSearchGridControl.MenuManager = Me.BarManager1
        Me.locationSearchGridControl.Name = "locationSearchGridControl"
        Me.locationSearchGridControl.Size = New System.Drawing.Size(250, 489)
        Me.locationSearchGridControl.TabIndex = 0
        Me.locationSearchGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.locationSearchGridView})
        '
        'locationSearchXpView
        '
        Me.locationSearchXpView.ObjectType = GetType(DXDAL.SPGData.Locations)
        Me.locationSearchXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("Code", DevExpress.Xpo.SortDirection.None, "[LocationCode]", False, True), New DevExpress.Xpo.ViewProperty("Name", DevExpress.Xpo.SortDirection.Ascending, "[LocationName]", False, True), New DevExpress.Xpo.ViewProperty("LocationID", DevExpress.Xpo.SortDirection.None, "[Oid]", False, True)})
        '
        'locationSearchGridView
        '
        Me.locationSearchGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCode, Me.colName, Me.colLocationID})
        Me.locationSearchGridView.GridControl = Me.locationSearchGridControl
        Me.locationSearchGridView.Name = "locationSearchGridView"
        Me.locationSearchGridView.OptionsBehavior.Editable = False
        Me.locationSearchGridView.OptionsView.ShowAutoFilterRow = True
        Me.locationSearchGridView.OptionsView.ShowGroupPanel = False
        '
        'colCode
        '
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.OptionsColumn.ReadOnly = True
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 0
        '
        'colName
        '
        Me.colName.FieldName = "Name"
        Me.colName.Name = "colName"
        Me.colName.OptionsColumn.ReadOnly = True
        Me.colName.Visible = True
        Me.colName.VisibleIndex = 1
        '
        'colLocationID
        '
        Me.colLocationID.FieldName = "LocationID"
        Me.colLocationID.Name = "colLocationID"
        Me.colLocationID.OptionsColumn.ReadOnly = True
        '
        'locationsXtraTabControl
        '
        Me.locationsXtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.locationsXtraTabControl.Location = New System.Drawing.Point(0, 0)
        Me.locationsXtraTabControl.Name = "locationsXtraTabControl"
        Me.locationsXtraTabControl.SelectedTabPage = Me.generalXtraTabPage
        Me.locationsXtraTabControl.Size = New System.Drawing.Size(569, 489)
        Me.locationsXtraTabControl.TabIndex = 0
        Me.locationsXtraTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.generalXtraTabPage, Me.inventoryXtraTabPage, Me.inventoryByLotXtraTabPage, Me.transfersXtraTabPage, Me.receivingXtraTabPage, Me.receivingReturnsXtraTabPage, Me.productionXtraTabPage, Me.shippingsXtraTabPage, Me.shippingReturnsXtraTabPage})
        '
        'generalXtraTabPage
        '
        Me.generalXtraTabPage.Controls.Add(Me.GroupControl1)
        Me.generalXtraTabPage.Controls.Add(Me.faxTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.phoneTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl6)
        Me.generalXtraTabPage.Controls.Add(Me.zipCodeTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.stateTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.cityTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl5)
        Me.generalXtraTabPage.Controls.Add(Me.addressTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl4)
        Me.generalXtraTabPage.Controls.Add(Me.nameTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl3)
        Me.generalXtraTabPage.Controls.Add(Me.codeTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl2)
        Me.generalXtraTabPage.Controls.Add(Me.oidTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl1)
        Me.generalXtraTabPage.Name = "generalXtraTabPage"
        Me.generalXtraTabPage.Size = New System.Drawing.Size(563, 461)
        Me.generalXtraTabPage.Text = "General Info"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.defaultWarehouseCheckEdit)
        Me.GroupControl1.Controls.Add(Me.inventoryAvailableCheckEdit)
        Me.GroupControl1.Controls.Add(Me.warehousingCheckEdit)
        Me.GroupControl1.Controls.Add(Me.productionCheckEdit)
        Me.GroupControl1.Controls.Add(Me.shippingCheckEdit)
        Me.GroupControl1.Controls.Add(Me.receivingCheckEdit)
        Me.GroupControl1.Location = New System.Drawing.Point(173, 267)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(312, 103)
        Me.GroupControl1.TabIndex = 15
        Me.GroupControl1.Text = "Location Functions"
        '
        'defaultWarehouseCheckEdit
        '
        Me.defaultWarehouseCheckEdit.Enabled = False
        Me.defaultWarehouseCheckEdit.Location = New System.Drawing.Point(145, 75)
        Me.defaultWarehouseCheckEdit.MenuManager = Me.BarManager1
        Me.defaultWarehouseCheckEdit.Name = "defaultWarehouseCheckEdit"
        Me.defaultWarehouseCheckEdit.Properties.Caption = "Default Warehouse"
        Me.defaultWarehouseCheckEdit.Size = New System.Drawing.Size(133, 19)
        Me.defaultWarehouseCheckEdit.TabIndex = 5
        '
        'inventoryAvailableCheckEdit
        '
        Me.inventoryAvailableCheckEdit.Location = New System.Drawing.Point(8, 75)
        Me.inventoryAvailableCheckEdit.MenuManager = Me.BarManager1
        Me.inventoryAvailableCheckEdit.Name = "inventoryAvailableCheckEdit"
        Me.inventoryAvailableCheckEdit.Properties.Caption = "Inventory Available"
        Me.inventoryAvailableCheckEdit.Size = New System.Drawing.Size(131, 19)
        Me.inventoryAvailableCheckEdit.TabIndex = 4
        '
        'warehousingCheckEdit
        '
        Me.warehousingCheckEdit.Location = New System.Drawing.Point(143, 49)
        Me.warehousingCheckEdit.MenuManager = Me.BarManager1
        Me.warehousingCheckEdit.Name = "warehousingCheckEdit"
        Me.warehousingCheckEdit.Properties.Caption = "Warehousing"
        Me.warehousingCheckEdit.Size = New System.Drawing.Size(121, 19)
        Me.warehousingCheckEdit.TabIndex = 3
        '
        'productionCheckEdit
        '
        Me.productionCheckEdit.Location = New System.Drawing.Point(6, 49)
        Me.productionCheckEdit.MenuManager = Me.BarManager1
        Me.productionCheckEdit.Name = "productionCheckEdit"
        Me.productionCheckEdit.Properties.Caption = "Production"
        Me.productionCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.productionCheckEdit.TabIndex = 2
        '
        'shippingCheckEdit
        '
        Me.shippingCheckEdit.Location = New System.Drawing.Point(143, 24)
        Me.shippingCheckEdit.MenuManager = Me.BarManager1
        Me.shippingCheckEdit.Name = "shippingCheckEdit"
        Me.shippingCheckEdit.Properties.Caption = "Shipping"
        Me.shippingCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.shippingCheckEdit.TabIndex = 1
        '
        'receivingCheckEdit
        '
        Me.receivingCheckEdit.Location = New System.Drawing.Point(6, 24)
        Me.receivingCheckEdit.MenuManager = Me.BarManager1
        Me.receivingCheckEdit.Name = "receivingCheckEdit"
        Me.receivingCheckEdit.Properties.Caption = "Receiving"
        Me.receivingCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.receivingCheckEdit.TabIndex = 0
        '
        'faxTextEdit
        '
        Me.faxTextEdit.Location = New System.Drawing.Point(332, 229)
        Me.faxTextEdit.MenuManager = Me.BarManager1
        Me.faxTextEdit.Name = "faxTextEdit"
        Me.faxTextEdit.Properties.NullText = "[Fax]"
        Me.faxTextEdit.Size = New System.Drawing.Size(153, 20)
        Me.faxTextEdit.TabIndex = 14
        '
        'phoneTextEdit
        '
        Me.phoneTextEdit.Location = New System.Drawing.Point(173, 229)
        Me.phoneTextEdit.MenuManager = Me.BarManager1
        Me.phoneTextEdit.Name = "phoneTextEdit"
        Me.phoneTextEdit.Properties.NullText = "[Phone]"
        Me.phoneTextEdit.Size = New System.Drawing.Size(153, 20)
        Me.phoneTextEdit.TabIndex = 13
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(77, 233)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(55, 13)
        Me.LabelControl6.TabIndex = 12
        Me.LabelControl6.Text = "Phone Fax:"
        '
        'zipCodeTextEdit
        '
        Me.zipCodeTextEdit.Location = New System.Drawing.Point(385, 194)
        Me.zipCodeTextEdit.MenuManager = Me.BarManager1
        Me.zipCodeTextEdit.Name = "zipCodeTextEdit"
        Me.zipCodeTextEdit.Properties.NullText = "[Zip Code]"
        Me.zipCodeTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.zipCodeTextEdit.TabIndex = 11
        '
        'stateTextEdit
        '
        Me.stateTextEdit.Location = New System.Drawing.Point(279, 194)
        Me.stateTextEdit.MenuManager = Me.BarManager1
        Me.stateTextEdit.Name = "stateTextEdit"
        Me.stateTextEdit.Properties.NullText = "[State]"
        Me.stateTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.stateTextEdit.TabIndex = 10
        '
        'cityTextEdit
        '
        Me.cityTextEdit.Location = New System.Drawing.Point(173, 194)
        Me.cityTextEdit.MenuManager = Me.BarManager1
        Me.cityTextEdit.Name = "cityTextEdit"
        Me.cityTextEdit.Properties.NullText = "[City]"
        Me.cityTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.cityTextEdit.TabIndex = 9
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(77, 197)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "City State Zip:"
        '
        'addressTextEdit
        '
        Me.addressTextEdit.Location = New System.Drawing.Point(173, 159)
        Me.addressTextEdit.MenuManager = Me.BarManager1
        Me.addressTextEdit.Name = "addressTextEdit"
        Me.addressTextEdit.Size = New System.Drawing.Size(312, 20)
        Me.addressTextEdit.TabIndex = 7
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(77, 162)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Address:"
        '
        'nameTextEdit
        '
        Me.nameTextEdit.Location = New System.Drawing.Point(173, 124)
        Me.nameTextEdit.MenuManager = Me.BarManager1
        Me.nameTextEdit.Name = "nameTextEdit"
        Me.nameTextEdit.Size = New System.Drawing.Size(312, 20)
        Me.nameTextEdit.TabIndex = 5
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(77, 127)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Name:"
        '
        'codeTextEdit
        '
        Me.codeTextEdit.Location = New System.Drawing.Point(385, 89)
        Me.codeTextEdit.MenuManager = Me.BarManager1
        Me.codeTextEdit.Name = "codeTextEdit"
        Me.codeTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.codeTextEdit.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(329, 92)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Code:"
        '
        'oidTextEdit
        '
        Me.oidTextEdit.Enabled = False
        Me.oidTextEdit.Location = New System.Drawing.Point(173, 89)
        Me.oidTextEdit.MenuManager = Me.BarManager1
        Me.oidTextEdit.Name = "oidTextEdit"
        Me.oidTextEdit.Properties.ReadOnly = True
        Me.oidTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.oidTextEdit.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(77, 92)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Internal ID:"
        '
        'inventoryXtraTabPage
        '
        Me.inventoryXtraTabPage.Controls.Add(Me.inventoryGridControl)
        Me.inventoryXtraTabPage.Name = "inventoryXtraTabPage"
        Me.inventoryXtraTabPage.Size = New System.Drawing.Size(563, 461)
        Me.inventoryXtraTabPage.Text = "Inventory"
        '
        'inventoryGridControl
        '
        Me.inventoryGridControl.DataSource = Me.locationInventoryXpView
        Me.inventoryGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inventoryGridControl.Location = New System.Drawing.Point(0, 0)
        Me.inventoryGridControl.MainView = Me.inventoryGridView
        Me.inventoryGridControl.MenuManager = Me.BarManager1
        Me.inventoryGridControl.Name = "inventoryGridControl"
        Me.inventoryGridControl.Size = New System.Drawing.Size(563, 461)
        Me.inventoryGridControl.TabIndex = 0
        Me.inventoryGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.inventoryGridView})
        '
        'locationInventoryXpView
        '
        Me.locationInventoryXpView.CriteriaString = "[Location] Is Null"
        Me.locationInventoryXpView.ObjectType = GetType(DXDAL.SPGData.LocationInventory)
        Me.locationInventoryXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.Ascending, "[LocationInventoryItem.ItemCode]", False, True), New DevExpress.Xpo.ViewProperty("ItemDescription", DevExpress.Xpo.SortDirection.None, "[LocationInventoryItem.ItemDescription]", False, True), New DevExpress.Xpo.ViewProperty("Quantity", DevExpress.Xpo.SortDirection.None, "[QuantityOnHand]", False, True)})
        '
        'inventoryGridView
        '
        Me.inventoryGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemCode, Me.colItemDescription, Me.colQuantity})
        Me.inventoryGridView.GridControl = Me.inventoryGridControl
        Me.inventoryGridView.Name = "inventoryGridView"
        Me.inventoryGridView.OptionsBehavior.Editable = False
        Me.inventoryGridView.OptionsView.ShowAutoFilterRow = True
        '
        'colItemCode
        '
        Me.colItemCode.FieldName = "ItemCode"
        Me.colItemCode.Name = "colItemCode"
        Me.colItemCode.OptionsColumn.ReadOnly = True
        Me.colItemCode.Visible = True
        Me.colItemCode.VisibleIndex = 0
        '
        'colItemDescription
        '
        Me.colItemDescription.FieldName = "ItemDescription"
        Me.colItemDescription.Name = "colItemDescription"
        Me.colItemDescription.OptionsColumn.ReadOnly = True
        Me.colItemDescription.Visible = True
        Me.colItemDescription.VisibleIndex = 1
        '
        'colQuantity
        '
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.OptionsColumn.ReadOnly = True
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 2
        '
        'inventoryByLotXtraTabPage
        '
        Me.inventoryByLotXtraTabPage.Controls.Add(Me.PrintLpnSimpleButton)
        Me.inventoryByLotXtraTabPage.Controls.Add(Me.inventoryByLotGridControl)
        Me.inventoryByLotXtraTabPage.Name = "inventoryByLotXtraTabPage"
        Me.inventoryByLotXtraTabPage.Size = New System.Drawing.Size(563, 461)
        Me.inventoryByLotXtraTabPage.Text = "Inventory-Lot"
        '
        'PrintLpnSimpleButton
        '
        Me.PrintLpnSimpleButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintLpnSimpleButton.Location = New System.Drawing.Point(481, 3)
        Me.PrintLpnSimpleButton.Name = "PrintLpnSimpleButton"
        Me.PrintLpnSimpleButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintLpnSimpleButton.TabIndex = 2
        Me.PrintLpnSimpleButton.Text = "Print LPN`s"
        '
        'inventoryByLotGridControl
        '
        Me.inventoryByLotGridControl.DataSource = Me.locationInventoryByLotXpView
        Me.inventoryByLotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.inventoryByLotGridControl.Location = New System.Drawing.Point(0, 0)
        Me.inventoryByLotGridControl.MainView = Me.inventoryByLotGridView
        Me.inventoryByLotGridControl.MenuManager = Me.BarManager1
        Me.inventoryByLotGridControl.Name = "inventoryByLotGridControl"
        Me.inventoryByLotGridControl.Size = New System.Drawing.Size(563, 461)
        Me.inventoryByLotGridControl.TabIndex = 1
        Me.inventoryByLotGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.inventoryByLotGridView})
        '
        'locationInventoryByLotXpView
        '
        Me.locationInventoryByLotXpView.CriteriaString = "[Location] Is Null"
        Me.locationInventoryByLotXpView.ObjectType = GetType(DXDAL.SPGData.LocationInventoryByLot)
        Me.locationInventoryByLotXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.Ascending, "[LocationInventoryItem.ItemCode]", False, True), New DevExpress.Xpo.ViewProperty("ItemDescription", DevExpress.Xpo.SortDirection.None, "[LocationInventoryItem.ItemDescription]", False, True), New DevExpress.Xpo.ViewProperty("ExpirationDate", DevExpress.Xpo.SortDirection.None, "[ExpirationDate]", False, True), New DevExpress.Xpo.ViewProperty("Lot", DevExpress.Xpo.SortDirection.None, "[LocationInventoryLot]", False, True), New DevExpress.Xpo.ViewProperty("LPNNumber", DevExpress.Xpo.SortDirection.None, "[LPNNumber]", False, True), New DevExpress.Xpo.ViewProperty("Quantity", DevExpress.Xpo.SortDirection.None, "[QuantityOnHand]", False, True)})
        '
        'inventoryByLotGridView
        '
        Me.inventoryByLotGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemCode1, Me.colItemDescription1, Me.colExpirationDate1, Me.colLot, Me.colLPNNumber, Me.colQuantity1})
        Me.inventoryByLotGridView.GridControl = Me.inventoryByLotGridControl
        Me.inventoryByLotGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", Me.colQuantity1, "TOTAL        {0:#,##0.##}")})
        Me.inventoryByLotGridView.Name = "inventoryByLotGridView"
        Me.inventoryByLotGridView.OptionsBehavior.Editable = False
        Me.inventoryByLotGridView.OptionsView.ShowAutoFilterRow = True
        Me.inventoryByLotGridView.OptionsView.ShowFooter = True
        '
        'colItemCode1
        '
        Me.colItemCode1.FieldName = "ItemCode"
        Me.colItemCode1.Name = "colItemCode1"
        Me.colItemCode1.Visible = True
        Me.colItemCode1.VisibleIndex = 0
        '
        'colItemDescription1
        '
        Me.colItemDescription1.FieldName = "ItemDescription"
        Me.colItemDescription1.Name = "colItemDescription1"
        Me.colItemDescription1.Visible = True
        Me.colItemDescription1.VisibleIndex = 1
        '
        'colExpirationDate1
        '
        Me.colExpirationDate1.FieldName = "ExpirationDate"
        Me.colExpirationDate1.Name = "colExpirationDate1"
        Me.colExpirationDate1.Visible = True
        Me.colExpirationDate1.VisibleIndex = 4
        '
        'colLot
        '
        Me.colLot.FieldName = "Lot"
        Me.colLot.Name = "colLot"
        Me.colLot.Visible = True
        Me.colLot.VisibleIndex = 2
        '
        'colLPNNumber
        '
        Me.colLPNNumber.FieldName = "LPNNumber"
        Me.colLPNNumber.Name = "colLPNNumber"
        Me.colLPNNumber.Visible = True
        Me.colLPNNumber.VisibleIndex = 3
        '
        'colQuantity1
        '
        Me.colQuantity1.FieldName = "Quantity"
        Me.colQuantity1.Name = "colQuantity1"
        Me.colQuantity1.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "TOTAL        {0:#,##0.##}")})
        Me.colQuantity1.Visible = True
        Me.colQuantity1.VisibleIndex = 5
        '
        'transfersXtraTabPage
        '
        Me.transfersXtraTabPage.Controls.Add(Me.SplitContainerControl2)
        Me.transfersXtraTabPage.Name = "transfersXtraTabPage"
        Me.transfersXtraTabPage.Size = New System.Drawing.Size(563, 461)
        Me.transfersXtraTabPage.Text = "Transfers"
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Horizontal = False
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.transfersToGroupControl)
        Me.SplitContainerControl2.Panel1.Text = "Transactions To"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.transfersFromGroupControl)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(563, 461)
        Me.SplitContainerControl2.SplitterPosition = 252
        Me.SplitContainerControl2.TabIndex = 2
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'transfersToGroupControl
        '
        Me.transfersToGroupControl.Controls.Add(Me.transfersToGridControl)
        Me.transfersToGroupControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.transfersToGroupControl.Location = New System.Drawing.Point(0, 0)
        Me.transfersToGroupControl.Name = "transfersToGroupControl"
        Me.transfersToGroupControl.Size = New System.Drawing.Size(563, 252)
        Me.transfersToGroupControl.TabIndex = 0
        Me.transfersToGroupControl.Text = "Location Transfers To"
        '
        'transfersToGridControl
        '
        Me.transfersToGridControl.DataSource = Me.transfersToXpView
        Me.transfersToGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.transfersToGridControl.Location = New System.Drawing.Point(2, 20)
        Me.transfersToGridControl.MainView = Me.transfersToGridView
        Me.transfersToGridControl.MenuManager = Me.BarManager1
        Me.transfersToGridControl.Name = "transfersToGridControl"
        Me.transfersToGridControl.Size = New System.Drawing.Size(559, 230)
        Me.transfersToGridControl.TabIndex = 1
        Me.transfersToGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.transfersToGridView})
        '
        'transfersToXpView
        '
        Me.transfersToXpView.CriteriaString = "[Transfer.ToLocation] Is Null"
        Me.transfersToXpView.ObjectType = GetType(DXDAL.SPGData.LocationTransferDetails)
        Me.transfersToXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("TransferDate", DevExpress.Xpo.SortDirection.None, "[Transfer.TransferDate]", False, True), New DevExpress.Xpo.ViewProperty("FromLocation", DevExpress.Xpo.SortDirection.None, "[Transfer.FromLocation.LocationCode]", False, True), New DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[TransferItem.ItemCode]", False, True), New DevExpress.Xpo.ViewProperty("ItemDescription", DevExpress.Xpo.SortDirection.None, "[TransferItem.ItemDescription]", False, True), New DevExpress.Xpo.ViewProperty("TransferNumber", DevExpress.Xpo.SortDirection.None, "[Transfer.TransferNumber]", False, True), New DevExpress.Xpo.ViewProperty("ItemLot", DevExpress.Xpo.SortDirection.None, "[TransferLot]", False, True), New DevExpress.Xpo.ViewProperty("ExpirationDate", DevExpress.Xpo.SortDirection.None, "[ItemExpirationDate]", False, True), New DevExpress.Xpo.ViewProperty("TransferQuantity", DevExpress.Xpo.SortDirection.None, "[TransferQuantity]", False, True), New DevExpress.Xpo.ViewProperty("ExpirationDateFormat", DevExpress.Xpo.SortDirection.None, "[TransferItem.ItemCustomerID.ExpirationDateFormat]", False, True)})
        '
        'transfersToGridView
        '
        Me.transfersToGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTransferToDate, Me.colFromLocation, Me.colTransferToItemCode, Me.colTransferToItemDescription, Me.colTransferToNumber, Me.colTransferToItemLot, Me.colTransferToExpirationDate, Me.colTransferToQuantity, Me.transferToExpirationDateFormatGridColumn})
        Me.transfersToGridView.GridControl = Me.transfersToGridControl
        Me.transfersToGridView.Name = "transfersToGridView"
        Me.transfersToGridView.OptionsBehavior.Editable = False
        Me.transfersToGridView.OptionsView.ShowAutoFilterRow = True
        '
        'colTransferToDate
        '
        Me.colTransferToDate.Caption = "Date"
        Me.colTransferToDate.FieldName = "TransferDate"
        Me.colTransferToDate.Name = "colTransferToDate"
        Me.colTransferToDate.OptionsColumn.ReadOnly = True
        Me.colTransferToDate.Visible = True
        Me.colTransferToDate.VisibleIndex = 0
        '
        'colFromLocation
        '
        Me.colFromLocation.FieldName = "FromLocation"
        Me.colFromLocation.Name = "colFromLocation"
        Me.colFromLocation.OptionsColumn.ReadOnly = True
        Me.colFromLocation.Visible = True
        Me.colFromLocation.VisibleIndex = 1
        '
        'colTransferToItemCode
        '
        Me.colTransferToItemCode.FieldName = "ItemCode"
        Me.colTransferToItemCode.Name = "colTransferToItemCode"
        Me.colTransferToItemCode.OptionsColumn.ReadOnly = True
        Me.colTransferToItemCode.Visible = True
        Me.colTransferToItemCode.VisibleIndex = 2
        '
        'colTransferToItemDescription
        '
        Me.colTransferToItemDescription.FieldName = "ItemDescription"
        Me.colTransferToItemDescription.Name = "colTransferToItemDescription"
        Me.colTransferToItemDescription.OptionsColumn.ReadOnly = True
        Me.colTransferToItemDescription.Visible = True
        Me.colTransferToItemDescription.VisibleIndex = 3
        '
        'colTransferToNumber
        '
        Me.colTransferToNumber.Caption = "Transfer #"
        Me.colTransferToNumber.FieldName = "TransferNumber"
        Me.colTransferToNumber.Name = "colTransferToNumber"
        Me.colTransferToNumber.OptionsColumn.ReadOnly = True
        Me.colTransferToNumber.Visible = True
        Me.colTransferToNumber.VisibleIndex = 4
        '
        'colTransferToItemLot
        '
        Me.colTransferToItemLot.FieldName = "ItemLot"
        Me.colTransferToItemLot.Name = "colTransferToItemLot"
        Me.colTransferToItemLot.OptionsColumn.ReadOnly = True
        Me.colTransferToItemLot.Visible = True
        Me.colTransferToItemLot.VisibleIndex = 5
        '
        'colTransferToExpirationDate
        '
        Me.colTransferToExpirationDate.DisplayFormat.FormatString = "d"
        Me.colTransferToExpirationDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.colTransferToExpirationDate.FieldName = "ExpirationDate"
        Me.colTransferToExpirationDate.Name = "colTransferToExpirationDate"
        Me.colTransferToExpirationDate.OptionsColumn.ReadOnly = True
        Me.colTransferToExpirationDate.Visible = True
        Me.colTransferToExpirationDate.VisibleIndex = 6
        '
        'colTransferToQuantity
        '
        Me.colTransferToQuantity.Caption = "Quantity"
        Me.colTransferToQuantity.FieldName = "TransferQuantity"
        Me.colTransferToQuantity.Name = "colTransferToQuantity"
        Me.colTransferToQuantity.OptionsColumn.ReadOnly = True
        Me.colTransferToQuantity.Visible = True
        Me.colTransferToQuantity.VisibleIndex = 7
        '
        'transferToExpirationDateFormatGridColumn
        '
        Me.transferToExpirationDateFormatGridColumn.Caption = "GridColumn1"
        Me.transferToExpirationDateFormatGridColumn.FieldName = "ExpirationDateFormat"
        Me.transferToExpirationDateFormatGridColumn.Name = "transferToExpirationDateFormatGridColumn"
        '
        'transfersFromGroupControl
        '
        Me.transfersFromGroupControl.Controls.Add(Me.transfersFromGridControl)
        Me.transfersFromGroupControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.transfersFromGroupControl.Location = New System.Drawing.Point(0, 0)
        Me.transfersFromGroupControl.Name = "transfersFromGroupControl"
        Me.transfersFromGroupControl.Size = New System.Drawing.Size(563, 204)
        Me.transfersFromGroupControl.TabIndex = 1
        Me.transfersFromGroupControl.Text = "Location Transfers From"
        '
        'transfersFromGridControl
        '
        Me.transfersFromGridControl.DataSource = Me.transfersFromXpView
        Me.transfersFromGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.transfersFromGridControl.Location = New System.Drawing.Point(2, 20)
        Me.transfersFromGridControl.MainView = Me.transfersFromGridView
        Me.transfersFromGridControl.MenuManager = Me.BarManager1
        Me.transfersFromGridControl.Name = "transfersFromGridControl"
        Me.transfersFromGridControl.Size = New System.Drawing.Size(559, 182)
        Me.transfersFromGridControl.TabIndex = 1
        Me.transfersFromGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.transfersFromGridView})
        '
        'transfersFromXpView
        '
        Me.transfersFromXpView.CriteriaString = "[Transfer.FromLocation] Is Null"
        Me.transfersFromXpView.ObjectType = GetType(DXDAL.SPGData.LocationTransferDetails)
        Me.transfersFromXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("TransferDate", DevExpress.Xpo.SortDirection.None, "[Transfer.TransferDate]", False, True), New DevExpress.Xpo.ViewProperty("ToLocation", DevExpress.Xpo.SortDirection.None, "[Transfer.ToLocation.LocationCode]", False, True), New DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[TransferItem.ItemCode]", False, True), New DevExpress.Xpo.ViewProperty("ItemDescription", DevExpress.Xpo.SortDirection.None, "[TransferItem.ItemDescription]", False, True), New DevExpress.Xpo.ViewProperty("TransferNumber", DevExpress.Xpo.SortDirection.None, "[Transfer.TransferNumber]", False, True), New DevExpress.Xpo.ViewProperty("ItemLot", DevExpress.Xpo.SortDirection.None, "[TransferLot]", False, True), New DevExpress.Xpo.ViewProperty("ExpirationDate", DevExpress.Xpo.SortDirection.None, "[ItemExpirationDate]", False, True), New DevExpress.Xpo.ViewProperty("TransferQuantity", DevExpress.Xpo.SortDirection.None, "[TransferQuantity]", False, True), New DevExpress.Xpo.ViewProperty("ExpirationDateFormat", DevExpress.Xpo.SortDirection.None, "[TransferItem.ItemCustomerID.ExpirationDateFormat]", False, True)})
        '
        'transfersFromGridView
        '
        Me.transfersFromGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTransferDate, Me.colToLocation, Me.colTansferFromItemCode, Me.colTransferFromItemDescription, Me.colTransferNumber, Me.colItemLot, Me.colExpirationDate, Me.colTransferQuantity, Me.colTransferFromExpirationDateFormat})
        Me.transfersFromGridView.GridControl = Me.transfersFromGridControl
        Me.transfersFromGridView.Name = "transfersFromGridView"
        Me.transfersFromGridView.OptionsBehavior.Editable = False
        Me.transfersFromGridView.OptionsView.ShowAutoFilterRow = True
        '
        'colTransferDate
        '
        Me.colTransferDate.Caption = "Date"
        Me.colTransferDate.FieldName = "TransferDate"
        Me.colTransferDate.Name = "colTransferDate"
        Me.colTransferDate.OptionsColumn.ReadOnly = True
        Me.colTransferDate.Visible = True
        Me.colTransferDate.VisibleIndex = 0
        '
        'colToLocation
        '
        Me.colToLocation.FieldName = "ToLocation"
        Me.colToLocation.Name = "colToLocation"
        Me.colToLocation.OptionsColumn.ReadOnly = True
        Me.colToLocation.Visible = True
        Me.colToLocation.VisibleIndex = 1
        '
        'colTansferFromItemCode
        '
        Me.colTansferFromItemCode.FieldName = "ItemCode"
        Me.colTansferFromItemCode.Name = "colTansferFromItemCode"
        Me.colTansferFromItemCode.OptionsColumn.ReadOnly = True
        Me.colTansferFromItemCode.Visible = True
        Me.colTansferFromItemCode.VisibleIndex = 2
        '
        'colTransferFromItemDescription
        '
        Me.colTransferFromItemDescription.FieldName = "ItemDescription"
        Me.colTransferFromItemDescription.Name = "colTransferFromItemDescription"
        Me.colTransferFromItemDescription.OptionsColumn.ReadOnly = True
        Me.colTransferFromItemDescription.Visible = True
        Me.colTransferFromItemDescription.VisibleIndex = 3
        '
        'colTransferNumber
        '
        Me.colTransferNumber.Caption = "Transfer #"
        Me.colTransferNumber.FieldName = "TransferNumber"
        Me.colTransferNumber.Name = "colTransferNumber"
        Me.colTransferNumber.OptionsColumn.ReadOnly = True
        Me.colTransferNumber.Visible = True
        Me.colTransferNumber.VisibleIndex = 4
        '
        'colItemLot
        '
        Me.colItemLot.FieldName = "ItemLot"
        Me.colItemLot.Name = "colItemLot"
        Me.colItemLot.OptionsColumn.ReadOnly = True
        Me.colItemLot.Visible = True
        Me.colItemLot.VisibleIndex = 5
        '
        'colExpirationDate
        '
        Me.colExpirationDate.FieldName = "ExpirationDate"
        Me.colExpirationDate.Name = "colExpirationDate"
        Me.colExpirationDate.OptionsColumn.ReadOnly = True
        Me.colExpirationDate.Visible = True
        Me.colExpirationDate.VisibleIndex = 6
        '
        'colTransferQuantity
        '
        Me.colTransferQuantity.Caption = "Quantity"
        Me.colTransferQuantity.FieldName = "TransferQuantity"
        Me.colTransferQuantity.Name = "colTransferQuantity"
        Me.colTransferQuantity.OptionsColumn.ReadOnly = True
        Me.colTransferQuantity.Visible = True
        Me.colTransferQuantity.VisibleIndex = 7
        '
        'colTransferFromExpirationDateFormat
        '
        Me.colTransferFromExpirationDateFormat.Caption = "GridColumn1"
        Me.colTransferFromExpirationDateFormat.FieldName = "ExpirationDateFormat"
        Me.colTransferFromExpirationDateFormat.Name = "colTransferFromExpirationDateFormat"
        '
        'receivingXtraTabPage
        '
        Me.receivingXtraTabPage.Controls.Add(Me.receivingsGridControl)
        Me.receivingXtraTabPage.Name = "receivingXtraTabPage"
        Me.receivingXtraTabPage.PageVisible = False
        Me.receivingXtraTabPage.Size = New System.Drawing.Size(563, 461)
        Me.receivingXtraTabPage.Text = "Receivings"
        '
        'receivingsGridControl
        '
        Me.receivingsGridControl.DataSource = Me.receivingsXpView
        Me.receivingsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.receivingsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.receivingsGridControl.MainView = Me.receivingsGridView
        Me.receivingsGridControl.MenuManager = Me.BarManager1
        Me.receivingsGridControl.Name = "receivingsGridControl"
        Me.receivingsGridControl.Size = New System.Drawing.Size(563, 461)
        Me.receivingsGridControl.TabIndex = 2
        Me.receivingsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.receivingsGridView})
        '
        'receivingsXpView
        '
        Me.receivingsXpView.CriteriaString = "[ReceivMainID.ReceivingLocation] Is Null"
        Me.receivingsXpView.ObjectType = GetType(DXDAL.SPGData.ReceivingDetail)
        Me.receivingsXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("ReceivingDate", DevExpress.Xpo.SortDirection.None, "[ReceivMainID.ReceivDate]", False, True), New DevExpress.Xpo.ViewProperty("ReceivingItemCode", DevExpress.Xpo.SortDirection.None, "[ReceivDetItemID.ItemCode]", False, True), New DevExpress.Xpo.ViewProperty("ReceivingItemDescription", DevExpress.Xpo.SortDirection.None, "[ReceivDetItemID.ItemDescription]", False, True), New DevExpress.Xpo.ViewProperty("ReceivingBOL", DevExpress.Xpo.SortDirection.None, "[ReceivMainID.ReceivBOL]", False, True), New DevExpress.Xpo.ViewProperty("ReceivingLot", DevExpress.Xpo.SortDirection.None, "[ReceivDetLot]", False, True), New DevExpress.Xpo.ViewProperty("ReceivingItemExpirationDate", DevExpress.Xpo.SortDirection.None, "[ExpirationDate]", False, True), New DevExpress.Xpo.ViewProperty("ReceivingQuantity", DevExpress.Xpo.SortDirection.None, "[ReceivDetQty]", False, True), New DevExpress.Xpo.ViewProperty("receivingExpirationDateFormat", DevExpress.Xpo.SortDirection.None, "[ReceivDetItemID.ItemCustomerID.ExpirationDateFormat]", False, True), New DevExpress.Xpo.ViewProperty("ReceivingItemType", DevExpress.Xpo.SortDirection.None, "[ReceivDetItemID.ItemType]", False, True)})
        '
        'receivingsGridView
        '
        Me.receivingsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colReceivingDate, Me.colReceivingItemCode, Me.colReceivingItemDescription, Me.colReceivingItemType, Me.colReceivingBOL, Me.colReceivingLot, Me.colReceivingItemExpirationDate, Me.colReceivingQuantity, Me.colReceivingExpirationDateFormat})
        Me.receivingsGridView.GridControl = Me.receivingsGridControl
        Me.receivingsGridView.Name = "receivingsGridView"
        Me.receivingsGridView.OptionsBehavior.Editable = False
        Me.receivingsGridView.OptionsView.ShowAutoFilterRow = True
        '
        'colReceivingDate
        '
        Me.colReceivingDate.Caption = "Date"
        Me.colReceivingDate.FieldName = "ReceivingDate"
        Me.colReceivingDate.Name = "colReceivingDate"
        Me.colReceivingDate.OptionsColumn.ReadOnly = True
        Me.colReceivingDate.Visible = True
        Me.colReceivingDate.VisibleIndex = 0
        '
        'colReceivingItemCode
        '
        Me.colReceivingItemCode.Caption = "Item Code"
        Me.colReceivingItemCode.FieldName = "ReceivingItemCode"
        Me.colReceivingItemCode.Name = "colReceivingItemCode"
        Me.colReceivingItemCode.OptionsColumn.ReadOnly = True
        Me.colReceivingItemCode.Visible = True
        Me.colReceivingItemCode.VisibleIndex = 1
        '
        'colReceivingItemDescription
        '
        Me.colReceivingItemDescription.Caption = "Item Description"
        Me.colReceivingItemDescription.FieldName = "ReceivingItemDescription"
        Me.colReceivingItemDescription.Name = "colReceivingItemDescription"
        Me.colReceivingItemDescription.OptionsColumn.ReadOnly = True
        Me.colReceivingItemDescription.Visible = True
        Me.colReceivingItemDescription.VisibleIndex = 2
        '
        'colReceivingItemType
        '
        Me.colReceivingItemType.Caption = "Item Type"
        Me.colReceivingItemType.FieldName = "ReceivingItemType"
        Me.colReceivingItemType.Name = "colReceivingItemType"
        Me.colReceivingItemType.Visible = True
        Me.colReceivingItemType.VisibleIndex = 3
        '
        'colReceivingBOL
        '
        Me.colReceivingBOL.Caption = "BOL #"
        Me.colReceivingBOL.FieldName = "ReceivingBOL"
        Me.colReceivingBOL.Name = "colReceivingBOL"
        Me.colReceivingBOL.OptionsColumn.ReadOnly = True
        Me.colReceivingBOL.Visible = True
        Me.colReceivingBOL.VisibleIndex = 4
        '
        'colReceivingLot
        '
        Me.colReceivingLot.Caption = "Lot #"
        Me.colReceivingLot.FieldName = "ReceivingLot"
        Me.colReceivingLot.Name = "colReceivingLot"
        Me.colReceivingLot.OptionsColumn.ReadOnly = True
        Me.colReceivingLot.Visible = True
        Me.colReceivingLot.VisibleIndex = 5
        '
        'colReceivingItemExpirationDate
        '
        Me.colReceivingItemExpirationDate.Caption = "Expiration Date"
        Me.colReceivingItemExpirationDate.FieldName = "ReceivingItemExpirationDate"
        Me.colReceivingItemExpirationDate.Name = "colReceivingItemExpirationDate"
        Me.colReceivingItemExpirationDate.OptionsColumn.ReadOnly = True
        Me.colReceivingItemExpirationDate.Visible = True
        Me.colReceivingItemExpirationDate.VisibleIndex = 6
        '
        'colReceivingQuantity
        '
        Me.colReceivingQuantity.Caption = "Quantity"
        Me.colReceivingQuantity.FieldName = "ReceivingQuantity"
        Me.colReceivingQuantity.Name = "colReceivingQuantity"
        Me.colReceivingQuantity.OptionsColumn.ReadOnly = True
        Me.colReceivingQuantity.Visible = True
        Me.colReceivingQuantity.VisibleIndex = 7
        '
        'colReceivingExpirationDateFormat
        '
        Me.colReceivingExpirationDateFormat.Caption = "GridColumn1"
        Me.colReceivingExpirationDateFormat.FieldName = "receivingExpirationDateFormat"
        Me.colReceivingExpirationDateFormat.Name = "colReceivingExpirationDateFormat"
        '
        'receivingReturnsXtraTabPage
        '
        Me.receivingReturnsXtraTabPage.Controls.Add(Me.receivingReturnsGridControl)
        Me.receivingReturnsXtraTabPage.Name = "receivingReturnsXtraTabPage"
        Me.receivingReturnsXtraTabPage.PageVisible = False
        Me.receivingReturnsXtraTabPage.Size = New System.Drawing.Size(563, 461)
        Me.receivingReturnsXtraTabPage.Text = "Receiving Returns"
        '
        'receivingReturnsGridControl
        '
        Me.receivingReturnsGridControl.DataSource = Me.receivingReturnXpView
        Me.receivingReturnsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.receivingReturnsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.receivingReturnsGridControl.MainView = Me.receivingReturnsGridView
        Me.receivingReturnsGridControl.MenuManager = Me.BarManager1
        Me.receivingReturnsGridControl.Name = "receivingReturnsGridControl"
        Me.receivingReturnsGridControl.Size = New System.Drawing.Size(563, 461)
        Me.receivingReturnsGridControl.TabIndex = 2
        Me.receivingReturnsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.receivingReturnsGridView})
        '
        'receivingReturnXpView
        '
        Me.receivingReturnXpView.CriteriaString = "[ReceiveMainID.ReceivingLocation] Is Null"
        Me.receivingReturnXpView.ObjectType = GetType(DXDAL.SPGData.ReceivedReturns)
        Me.receivingReturnXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("ReceivingReturnDate", DevExpress.Xpo.SortDirection.None, "[ReceiveMainID.ReceivDate]", False, True), New DevExpress.Xpo.ViewProperty("ReceivingReturnItemCode", DevExpress.Xpo.SortDirection.None, "[ReturnDetItemID.ItemCode]", False, True), New DevExpress.Xpo.ViewProperty("ReceivingReturnItemDescription", DevExpress.Xpo.SortDirection.None, "[ReturnDetItemID.ItemDescription]", False, True), New DevExpress.Xpo.ViewProperty("ReceivingReturnBOL", DevExpress.Xpo.SortDirection.None, "[ReceiveMainID.ReceivBOL]", False, True), New DevExpress.Xpo.ViewProperty("ReceivingReturnLot", DevExpress.Xpo.SortDirection.None, "[ReturnDetLot]", False, True), New DevExpress.Xpo.ViewProperty("ReceivingReturnItemExpirationDate", DevExpress.Xpo.SortDirection.None, "[ExpirationDate]", False, True), New DevExpress.Xpo.ViewProperty("ReceivingReturnQuantity", DevExpress.Xpo.SortDirection.None, "[ReturnDetQty]", False, True), New DevExpress.Xpo.ViewProperty("ReceivingReturnExpirationDateFromat", DevExpress.Xpo.SortDirection.None, "[ReturnDetItemID.ItemCustomerID.ExpirationDateFormat]", False, True)})
        '
        'receivingReturnsGridView
        '
        Me.receivingReturnsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colReceivingReturnDate, Me.colReceivingReturnItemCode, Me.colReceivingReturnItemDescription, Me.colReceivingReturnBOL, Me.colReceivingReturnLot, Me.colReceivingReturnItemExpirationDate, Me.colReceivingReturnQuantity, Me.colReceivingReturnExpirationDateFormat})
        Me.receivingReturnsGridView.GridControl = Me.receivingReturnsGridControl
        Me.receivingReturnsGridView.Name = "receivingReturnsGridView"
        Me.receivingReturnsGridView.OptionsBehavior.Editable = False
        Me.receivingReturnsGridView.OptionsView.ShowAutoFilterRow = True
        '
        'colReceivingReturnDate
        '
        Me.colReceivingReturnDate.Caption = "Date"
        Me.colReceivingReturnDate.FieldName = "ReceivingReturnDate"
        Me.colReceivingReturnDate.Name = "colReceivingReturnDate"
        Me.colReceivingReturnDate.OptionsColumn.ReadOnly = True
        Me.colReceivingReturnDate.Visible = True
        Me.colReceivingReturnDate.VisibleIndex = 0
        '
        'colReceivingReturnItemCode
        '
        Me.colReceivingReturnItemCode.Caption = "Item Code"
        Me.colReceivingReturnItemCode.FieldName = "ReceivingReturnItemCode"
        Me.colReceivingReturnItemCode.Name = "colReceivingReturnItemCode"
        Me.colReceivingReturnItemCode.OptionsColumn.ReadOnly = True
        Me.colReceivingReturnItemCode.Visible = True
        Me.colReceivingReturnItemCode.VisibleIndex = 1
        '
        'colReceivingReturnItemDescription
        '
        Me.colReceivingReturnItemDescription.Caption = "Item Description"
        Me.colReceivingReturnItemDescription.FieldName = "ReceivingReturnItemDescription"
        Me.colReceivingReturnItemDescription.Name = "colReceivingReturnItemDescription"
        Me.colReceivingReturnItemDescription.OptionsColumn.ReadOnly = True
        Me.colReceivingReturnItemDescription.Visible = True
        Me.colReceivingReturnItemDescription.VisibleIndex = 2
        '
        'colReceivingReturnBOL
        '
        Me.colReceivingReturnBOL.Caption = "BOL #"
        Me.colReceivingReturnBOL.FieldName = "ReceivingReturnBOL"
        Me.colReceivingReturnBOL.Name = "colReceivingReturnBOL"
        Me.colReceivingReturnBOL.OptionsColumn.ReadOnly = True
        Me.colReceivingReturnBOL.Visible = True
        Me.colReceivingReturnBOL.VisibleIndex = 3
        '
        'colReceivingReturnLot
        '
        Me.colReceivingReturnLot.Caption = "Lot #"
        Me.colReceivingReturnLot.FieldName = "ReceivingReturnLot"
        Me.colReceivingReturnLot.Name = "colReceivingReturnLot"
        Me.colReceivingReturnLot.OptionsColumn.ReadOnly = True
        Me.colReceivingReturnLot.Visible = True
        Me.colReceivingReturnLot.VisibleIndex = 4
        '
        'colReceivingReturnItemExpirationDate
        '
        Me.colReceivingReturnItemExpirationDate.Caption = "Expiration Date"
        Me.colReceivingReturnItemExpirationDate.FieldName = "ReceivingReturnItemExpirationDate"
        Me.colReceivingReturnItemExpirationDate.Name = "colReceivingReturnItemExpirationDate"
        Me.colReceivingReturnItemExpirationDate.OptionsColumn.ReadOnly = True
        Me.colReceivingReturnItemExpirationDate.Visible = True
        Me.colReceivingReturnItemExpirationDate.VisibleIndex = 5
        '
        'colReceivingReturnQuantity
        '
        Me.colReceivingReturnQuantity.Caption = "Quantity"
        Me.colReceivingReturnQuantity.FieldName = "ReceivingReturnQuantity"
        Me.colReceivingReturnQuantity.Name = "colReceivingReturnQuantity"
        Me.colReceivingReturnQuantity.OptionsColumn.ReadOnly = True
        Me.colReceivingReturnQuantity.Visible = True
        Me.colReceivingReturnQuantity.VisibleIndex = 6
        '
        'colReceivingReturnExpirationDateFormat
        '
        Me.colReceivingReturnExpirationDateFormat.Caption = "GridColumn1"
        Me.colReceivingReturnExpirationDateFormat.FieldName = "ReceivingReturnExpirationDateFromat"
        Me.colReceivingReturnExpirationDateFormat.Name = "colReceivingReturnExpirationDateFormat"
        '
        'productionXtraTabPage
        '
        Me.productionXtraTabPage.Controls.Add(Me.productionGridControl)
        Me.productionXtraTabPage.Name = "productionXtraTabPage"
        Me.productionXtraTabPage.PageVisible = False
        Me.productionXtraTabPage.Size = New System.Drawing.Size(563, 461)
        Me.productionXtraTabPage.Text = "Production"
        '
        'productionGridControl
        '
        Me.productionGridControl.DataSource = Me.productionXpView
        Me.productionGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.productionGridControl.Location = New System.Drawing.Point(0, 0)
        Me.productionGridControl.MainView = Me.productionGridView
        Me.productionGridControl.MenuManager = Me.BarManager1
        Me.productionGridControl.Name = "productionGridControl"
        Me.productionGridControl.Size = New System.Drawing.Size(563, 461)
        Me.productionGridControl.TabIndex = 2
        Me.productionGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.productionGridView})
        '
        'productionXpView
        '
        Me.productionXpView.CriteriaString = "[ProductionLocation] Is Null"
        Me.productionXpView.ObjectType = GetType(DXDAL.SPGData.Inventory)
        Me.productionXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("ProductionDate", DevExpress.Xpo.SortDirection.None, "[InventoryDate]", False, True), New DevExpress.Xpo.ViewProperty("ProductionItemCode", DevExpress.Xpo.SortDirection.None, "[InventoryItemID.ItemCode]", False, True), New DevExpress.Xpo.ViewProperty("ProductionItemDescription", DevExpress.Xpo.SortDirection.None, "[InventoryItemID.ItemDescription]", False, True), New DevExpress.Xpo.ViewProperty("ProductionPO", DevExpress.Xpo.SortDirection.None, "[PO]", False, True), New DevExpress.Xpo.ViewProperty("ProductionLot", DevExpress.Xpo.SortDirection.None, "[Lot]", False, True), New DevExpress.Xpo.ViewProperty("PrdouctionExpirationDate", DevExpress.Xpo.SortDirection.None, "[ExpirationDate]", False, True), New DevExpress.Xpo.ViewProperty("ProductionQuantity", DevExpress.Xpo.SortDirection.None, "[InventoryQuantity]", False, True), New DevExpress.Xpo.ViewProperty("PrdouctionExpirationDateFormat", DevExpress.Xpo.SortDirection.None, "[InventoryItemID.ItemCustomerID.ExpirationDateFormat]", False, True)})
        '
        'productionGridView
        '
        Me.productionGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductionDate, Me.colProductionItemCode, Me.colProductionItemDescription, Me.colProductionPO, Me.colProductionLot, Me.colPrdouctionExpirationDate, Me.colProductionQuantity, Me.colProductionExpirationDateFormat})
        Me.productionGridView.GridControl = Me.productionGridControl
        Me.productionGridView.Name = "productionGridView"
        Me.productionGridView.OptionsBehavior.Editable = False
        Me.productionGridView.OptionsView.ShowAutoFilterRow = True
        '
        'colProductionDate
        '
        Me.colProductionDate.Caption = "Date"
        Me.colProductionDate.FieldName = "ProductionDate"
        Me.colProductionDate.Name = "colProductionDate"
        Me.colProductionDate.OptionsColumn.ReadOnly = True
        Me.colProductionDate.Visible = True
        Me.colProductionDate.VisibleIndex = 0
        '
        'colProductionItemCode
        '
        Me.colProductionItemCode.Caption = "Item Code"
        Me.colProductionItemCode.FieldName = "ProductionItemCode"
        Me.colProductionItemCode.Name = "colProductionItemCode"
        Me.colProductionItemCode.OptionsColumn.ReadOnly = True
        Me.colProductionItemCode.Visible = True
        Me.colProductionItemCode.VisibleIndex = 1
        '
        'colProductionItemDescription
        '
        Me.colProductionItemDescription.Caption = "Item Description"
        Me.colProductionItemDescription.FieldName = "ProductionItemDescription"
        Me.colProductionItemDescription.Name = "colProductionItemDescription"
        Me.colProductionItemDescription.OptionsColumn.ReadOnly = True
        Me.colProductionItemDescription.Visible = True
        Me.colProductionItemDescription.VisibleIndex = 2
        '
        'colProductionPO
        '
        Me.colProductionPO.Caption = "PO #"
        Me.colProductionPO.FieldName = "ProductionPO"
        Me.colProductionPO.Name = "colProductionPO"
        Me.colProductionPO.OptionsColumn.ReadOnly = True
        Me.colProductionPO.Visible = True
        Me.colProductionPO.VisibleIndex = 3
        '
        'colProductionLot
        '
        Me.colProductionLot.Caption = "Lot #"
        Me.colProductionLot.FieldName = "ProductionLot"
        Me.colProductionLot.Name = "colProductionLot"
        Me.colProductionLot.OptionsColumn.ReadOnly = True
        Me.colProductionLot.Visible = True
        Me.colProductionLot.VisibleIndex = 4
        '
        'colPrdouctionExpirationDate
        '
        Me.colPrdouctionExpirationDate.Caption = "Expiration Date"
        Me.colPrdouctionExpirationDate.FieldName = "PrdouctionExpirationDate"
        Me.colPrdouctionExpirationDate.Name = "colPrdouctionExpirationDate"
        Me.colPrdouctionExpirationDate.OptionsColumn.ReadOnly = True
        Me.colPrdouctionExpirationDate.Visible = True
        Me.colPrdouctionExpirationDate.VisibleIndex = 5
        '
        'colProductionQuantity
        '
        Me.colProductionQuantity.Caption = "Quantity"
        Me.colProductionQuantity.FieldName = "ProductionQuantity"
        Me.colProductionQuantity.Name = "colProductionQuantity"
        Me.colProductionQuantity.OptionsColumn.ReadOnly = True
        Me.colProductionQuantity.Visible = True
        Me.colProductionQuantity.VisibleIndex = 6
        '
        'colProductionExpirationDateFormat
        '
        Me.colProductionExpirationDateFormat.Caption = "GridColumn1"
        Me.colProductionExpirationDateFormat.FieldName = "PrdouctionExpirationDateFormat"
        Me.colProductionExpirationDateFormat.Name = "colProductionExpirationDateFormat"
        '
        'shippingsXtraTabPage
        '
        Me.shippingsXtraTabPage.Controls.Add(Me.shippingsGridControl)
        Me.shippingsXtraTabPage.Name = "shippingsXtraTabPage"
        Me.shippingsXtraTabPage.PageVisible = False
        Me.shippingsXtraTabPage.Size = New System.Drawing.Size(563, 461)
        Me.shippingsXtraTabPage.Text = "Shippings"
        '
        'shippingsGridControl
        '
        Me.shippingsGridControl.DataSource = Me.shippingsXpView
        Me.shippingsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.shippingsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.shippingsGridControl.MainView = Me.shippingsGridView
        Me.shippingsGridControl.MenuManager = Me.BarManager1
        Me.shippingsGridControl.Name = "shippingsGridControl"
        Me.shippingsGridControl.Size = New System.Drawing.Size(563, 461)
        Me.shippingsGridControl.TabIndex = 2
        Me.shippingsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.shippingsGridView})
        '
        'shippingsXpView
        '
        Me.shippingsXpView.CriteriaString = "[ShipDetMainID.ShippingLocation] Is Null"
        Me.shippingsXpView.ObjectType = GetType(DXDAL.SPGData.ShipDet)
        Me.shippingsXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("ShippingDate", DevExpress.Xpo.SortDirection.None, "[ShipDetMainID.ShipMainDate]", False, True), New DevExpress.Xpo.ViewProperty("ShippingItemCode", DevExpress.Xpo.SortDirection.None, "[ShipDetItemID.ItemCode]", False, True), New DevExpress.Xpo.ViewProperty("ShippingItemDescription", DevExpress.Xpo.SortDirection.None, "[ShipDetItemID.ItemDescription]", False, True), New DevExpress.Xpo.ViewProperty("ShippingBOL", DevExpress.Xpo.SortDirection.None, "[ShipDetMainID.ShipMainBOL]", False, True), New DevExpress.Xpo.ViewProperty("ShippingLot", DevExpress.Xpo.SortDirection.None, "[ShipDetLot]", False, True), New DevExpress.Xpo.ViewProperty("ShippingExpirationDate", DevExpress.Xpo.SortDirection.None, "[ExpirationDate]", False, True), New DevExpress.Xpo.ViewProperty("ShippingQuantity", DevExpress.Xpo.SortDirection.None, "[ShipDetDetQty]", False, True), New DevExpress.Xpo.ViewProperty("ShippingExpirationDateFormat", DevExpress.Xpo.SortDirection.None, "[ShipDetItemID.ItemCustomerID.ExpirationDateFormat]", False, True), New DevExpress.Xpo.ViewProperty("ShipDetItemType", DevExpress.Xpo.SortDirection.None, "[ShipDetItemID.ItemType]", False, True)})
        '
        'shippingsGridView
        '
        Me.shippingsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colShippingDate, Me.colShippingItemCode, Me.colShippingItemDescription, Me.colShippingBOL, Me.colShippingLot, Me.colShippingExpirationDate, Me.colShippingQuantity, Me.colShippingExpirationDateFormat, Me.colShippingItemType})
        Me.shippingsGridView.GridControl = Me.shippingsGridControl
        Me.shippingsGridView.Name = "shippingsGridView"
        Me.shippingsGridView.OptionsBehavior.Editable = False
        Me.shippingsGridView.OptionsView.ShowAutoFilterRow = True
        '
        'colShippingDate
        '
        Me.colShippingDate.Caption = "Date"
        Me.colShippingDate.FieldName = "ShippingDate"
        Me.colShippingDate.Name = "colShippingDate"
        Me.colShippingDate.OptionsColumn.ReadOnly = True
        Me.colShippingDate.Visible = True
        Me.colShippingDate.VisibleIndex = 0
        '
        'colShippingItemCode
        '
        Me.colShippingItemCode.Caption = "Item Code"
        Me.colShippingItemCode.FieldName = "ShippingItemCode"
        Me.colShippingItemCode.Name = "colShippingItemCode"
        Me.colShippingItemCode.OptionsColumn.ReadOnly = True
        Me.colShippingItemCode.Visible = True
        Me.colShippingItemCode.VisibleIndex = 1
        '
        'colShippingItemDescription
        '
        Me.colShippingItemDescription.Caption = "Item Description"
        Me.colShippingItemDescription.FieldName = "ShippingItemDescription"
        Me.colShippingItemDescription.Name = "colShippingItemDescription"
        Me.colShippingItemDescription.OptionsColumn.ReadOnly = True
        Me.colShippingItemDescription.Visible = True
        Me.colShippingItemDescription.VisibleIndex = 2
        '
        'colShippingBOL
        '
        Me.colShippingBOL.Caption = "BOL #"
        Me.colShippingBOL.FieldName = "ShippingBOL"
        Me.colShippingBOL.Name = "colShippingBOL"
        Me.colShippingBOL.OptionsColumn.ReadOnly = True
        Me.colShippingBOL.Visible = True
        Me.colShippingBOL.VisibleIndex = 4
        '
        'colShippingLot
        '
        Me.colShippingLot.Caption = "Lot #"
        Me.colShippingLot.FieldName = "ShippingLot"
        Me.colShippingLot.Name = "colShippingLot"
        Me.colShippingLot.OptionsColumn.ReadOnly = True
        Me.colShippingLot.Visible = True
        Me.colShippingLot.VisibleIndex = 5
        '
        'colShippingExpirationDate
        '
        Me.colShippingExpirationDate.Caption = "Expiration Date"
        Me.colShippingExpirationDate.FieldName = "ShippingExpirationDate"
        Me.colShippingExpirationDate.Name = "colShippingExpirationDate"
        Me.colShippingExpirationDate.OptionsColumn.ReadOnly = True
        Me.colShippingExpirationDate.Visible = True
        Me.colShippingExpirationDate.VisibleIndex = 6
        '
        'colShippingQuantity
        '
        Me.colShippingQuantity.Caption = "Quantity"
        Me.colShippingQuantity.FieldName = "ShippingQuantity"
        Me.colShippingQuantity.Name = "colShippingQuantity"
        Me.colShippingQuantity.OptionsColumn.ReadOnly = True
        Me.colShippingQuantity.Visible = True
        Me.colShippingQuantity.VisibleIndex = 7
        '
        'colShippingExpirationDateFormat
        '
        Me.colShippingExpirationDateFormat.Caption = "GridColumn1"
        Me.colShippingExpirationDateFormat.FieldName = "ShippingExpirationDateFormat"
        Me.colShippingExpirationDateFormat.Name = "colShippingExpirationDateFormat"
        '
        'shippingReturnsXtraTabPage
        '
        Me.shippingReturnsXtraTabPage.Controls.Add(Me.shippingReturnsGridControl)
        Me.shippingReturnsXtraTabPage.Name = "shippingReturnsXtraTabPage"
        Me.shippingReturnsXtraTabPage.PageVisible = False
        Me.shippingReturnsXtraTabPage.Size = New System.Drawing.Size(563, 461)
        Me.shippingReturnsXtraTabPage.Text = "Shipping Returns"
        '
        'shippingReturnsGridControl
        '
        Me.shippingReturnsGridControl.DataSource = Me.shippingReturnsXpView
        Me.shippingReturnsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.shippingReturnsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.shippingReturnsGridControl.MainView = Me.shippingReturnsGridView
        Me.shippingReturnsGridControl.MenuManager = Me.BarManager1
        Me.shippingReturnsGridControl.Name = "shippingReturnsGridControl"
        Me.shippingReturnsGridControl.Size = New System.Drawing.Size(563, 461)
        Me.shippingReturnsGridControl.TabIndex = 2
        Me.shippingReturnsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.shippingReturnsGridView})
        '
        'shippingReturnsXpView
        '
        Me.shippingReturnsXpView.CriteriaString = "[ShipMainID.ShippingLocation] Is Null"
        Me.shippingReturnsXpView.ObjectType = GetType(DXDAL.SPGData.ShippedReturns)
        Me.shippingReturnsXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("ShippingReturnDate", DevExpress.Xpo.SortDirection.None, "[ShipMainID.ShipMainDate]", False, True), New DevExpress.Xpo.ViewProperty("ShippingReturnItemCode", DevExpress.Xpo.SortDirection.None, "[ReturnDetItemID.ItemCode]", False, True), New DevExpress.Xpo.ViewProperty("ShippingReturnItemDescription", DevExpress.Xpo.SortDirection.None, "[ReturnDetItemID.ItemDescription]", False, True), New DevExpress.Xpo.ViewProperty("ShippingReturnBOL", DevExpress.Xpo.SortDirection.None, "[ShipMainID.ShipMainBOL]", False, True), New DevExpress.Xpo.ViewProperty("ShippingReturnLot", DevExpress.Xpo.SortDirection.None, "[ReturnDetLot]", False, True), New DevExpress.Xpo.ViewProperty("ShippingReturnExpirationDate", DevExpress.Xpo.SortDirection.None, "[ExpirationDate]", False, True), New DevExpress.Xpo.ViewProperty("ShippingReturnQuantity", DevExpress.Xpo.SortDirection.None, "[ReturnDetQty]", False, True), New DevExpress.Xpo.ViewProperty("ShippingReturnExpirationDateFormat", DevExpress.Xpo.SortDirection.None, "[ReturnDetItemID.ItemCustomerID.ExpirationDateFormat]", False, True)})
        '
        'shippingReturnsGridView
        '
        Me.shippingReturnsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colShippingReturnDate, Me.colShippingReturnItemCode, Me.colShippingReturnItemDescription, Me.colShippingReturnBOL, Me.colShippingReturnLot, Me.colShippingReturnExpirationDate, Me.colShippingReturnQuantity, Me.colShippingReturnExpirationDateFormat})
        Me.shippingReturnsGridView.GridControl = Me.shippingReturnsGridControl
        Me.shippingReturnsGridView.Name = "shippingReturnsGridView"
        Me.shippingReturnsGridView.OptionsBehavior.Editable = False
        Me.shippingReturnsGridView.OptionsView.ShowAutoFilterRow = True
        '
        'colShippingReturnDate
        '
        Me.colShippingReturnDate.Caption = "Date"
        Me.colShippingReturnDate.FieldName = "ShippingReturnDate"
        Me.colShippingReturnDate.Name = "colShippingReturnDate"
        Me.colShippingReturnDate.OptionsColumn.ReadOnly = True
        Me.colShippingReturnDate.Visible = True
        Me.colShippingReturnDate.VisibleIndex = 0
        '
        'colShippingReturnItemCode
        '
        Me.colShippingReturnItemCode.Caption = "Item Code"
        Me.colShippingReturnItemCode.FieldName = "ShippingReturnItemCode"
        Me.colShippingReturnItemCode.Name = "colShippingReturnItemCode"
        Me.colShippingReturnItemCode.OptionsColumn.ReadOnly = True
        Me.colShippingReturnItemCode.Visible = True
        Me.colShippingReturnItemCode.VisibleIndex = 1
        '
        'colShippingReturnItemDescription
        '
        Me.colShippingReturnItemDescription.Caption = "Item Description"
        Me.colShippingReturnItemDescription.FieldName = "ShippingReturnItemDescription"
        Me.colShippingReturnItemDescription.Name = "colShippingReturnItemDescription"
        Me.colShippingReturnItemDescription.OptionsColumn.ReadOnly = True
        Me.colShippingReturnItemDescription.Visible = True
        Me.colShippingReturnItemDescription.VisibleIndex = 2
        '
        'colShippingReturnBOL
        '
        Me.colShippingReturnBOL.Caption = "BOL #"
        Me.colShippingReturnBOL.FieldName = "ShippingReturnBOL"
        Me.colShippingReturnBOL.Name = "colShippingReturnBOL"
        Me.colShippingReturnBOL.OptionsColumn.ReadOnly = True
        Me.colShippingReturnBOL.Visible = True
        Me.colShippingReturnBOL.VisibleIndex = 3
        '
        'colShippingReturnLot
        '
        Me.colShippingReturnLot.Caption = "Lot #"
        Me.colShippingReturnLot.FieldName = "ShippingReturnLot"
        Me.colShippingReturnLot.Name = "colShippingReturnLot"
        Me.colShippingReturnLot.OptionsColumn.ReadOnly = True
        Me.colShippingReturnLot.Visible = True
        Me.colShippingReturnLot.VisibleIndex = 4
        '
        'colShippingReturnExpirationDate
        '
        Me.colShippingReturnExpirationDate.Caption = "Expiration Date"
        Me.colShippingReturnExpirationDate.FieldName = "ShippingReturnExpirationDate"
        Me.colShippingReturnExpirationDate.Name = "colShippingReturnExpirationDate"
        Me.colShippingReturnExpirationDate.OptionsColumn.ReadOnly = True
        Me.colShippingReturnExpirationDate.Visible = True
        Me.colShippingReturnExpirationDate.VisibleIndex = 5
        '
        'colShippingReturnQuantity
        '
        Me.colShippingReturnQuantity.Caption = "Quantity"
        Me.colShippingReturnQuantity.FieldName = "ShippingReturnQuantity"
        Me.colShippingReturnQuantity.Name = "colShippingReturnQuantity"
        Me.colShippingReturnQuantity.OptionsColumn.ReadOnly = True
        Me.colShippingReturnQuantity.Visible = True
        Me.colShippingReturnQuantity.VisibleIndex = 6
        '
        'colShippingReturnExpirationDateFormat
        '
        Me.colShippingReturnExpirationDateFormat.Caption = "GridColumn1"
        Me.colShippingReturnExpirationDateFormat.FieldName = "ShippingReturnExpirationDateFormat"
        Me.colShippingReturnExpirationDateFormat.Name = "colShippingReturnExpirationDateFormat"
        '
        'colShippingItemType
        '
        Me.colShippingItemType.Caption = "Item Type"
        Me.colShippingItemType.FieldName = "ShipDetItemType"
        Me.colShippingItemType.Name = "colShippingItemType"
        Me.colShippingItemType.Visible = True
        Me.colShippingItemType.VisibleIndex = 3
        '
        'LocationXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 561)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LocationXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Location Manager"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.locationSearchGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.locationSearchXpView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.locationSearchGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.locationsXtraTabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.locationsXtraTabControl.ResumeLayout(False)
        Me.generalXtraTabPage.ResumeLayout(False)
        Me.generalXtraTabPage.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.defaultWarehouseCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inventoryAvailableCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.warehousingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productionCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shippingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.receivingCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.faxTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.phoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zipCodeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addressTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.codeTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.oidTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.inventoryXtraTabPage.ResumeLayout(False)
        CType(Me.inventoryGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.locationInventoryXpView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inventoryGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.inventoryByLotXtraTabPage.ResumeLayout(False)
        CType(Me.inventoryByLotGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.locationInventoryByLotXpView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inventoryByLotGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.transfersXtraTabPage.ResumeLayout(False)
        CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl2.ResumeLayout(False)
        CType(Me.transfersToGroupControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.transfersToGroupControl.ResumeLayout(False)
        CType(Me.transfersToGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.transfersToXpView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.transfersToGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.transfersFromGroupControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.transfersFromGroupControl.ResumeLayout(False)
        CType(Me.transfersFromGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.transfersFromXpView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.transfersFromGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.receivingXtraTabPage.ResumeLayout(False)
        CType(Me.receivingsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.receivingsXpView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.receivingsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.receivingReturnsXtraTabPage.ResumeLayout(False)
        CType(Me.receivingReturnsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.receivingReturnXpView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.receivingReturnsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.productionXtraTabPage.ResumeLayout(False)
        CType(Me.productionGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productionXpView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.productionGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.shippingsXtraTabPage.ResumeLayout(False)
        CType(Me.shippingsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shippingsXpView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shippingsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.shippingReturnsXtraTabPage.ResumeLayout(False)
        CType(Me.shippingReturnsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shippingReturnsXpView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shippingReturnsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents locationMenuBar As DevExpress.XtraBars.Bar
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents addBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents editBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents deleteBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cancelBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents saveBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents printGridBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents locationSearchGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents locationSearchGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents locationSearchXpView As DevExpress.Xpo.XPView
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLocationID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents locationsXtraTabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents generalXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents inventoryXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents receivingXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents receivingReturnsXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents productionXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents shippingsXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents shippingReturnsXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents transfersXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents codeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents oidTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents addressTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents defaultWarehouseCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents inventoryAvailableCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents warehousingCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents productionCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents shippingCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents receivingCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents faxTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents phoneTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents zipCodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents stateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents inventoryGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents inventoryGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents transfersToGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents transfersToGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents receivingsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents receivingsGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents receivingReturnsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents receivingReturnsGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents productionGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents productionGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents shippingsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents shippingsGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents shippingReturnsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents shippingReturnsGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents locationInventoryXpView As DevExpress.Xpo.XPView
    Friend WithEvents colItemCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents transfersToGroupControl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents transfersFromGroupControl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents transfersFromGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents transfersFromGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents transfersFromXpView As DevExpress.Xpo.XPView
    Friend WithEvents transfersToXpView As DevExpress.Xpo.XPView
    Friend WithEvents colTransferToDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFromLocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransferToItemCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransferToItemDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransferToNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransferToItemLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransferToExpirationDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransferToQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransferDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colToLocation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTansferFromItemCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransferFromItemDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransferNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExpirationDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransferQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents receivingsXpView As DevExpress.Xpo.XPView
    Friend WithEvents colReceivingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceivingItemCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceivingItemDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceivingBOL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceivingLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceivingItemExpirationDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceivingQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents receivingReturnXpView As DevExpress.Xpo.XPView
    Friend WithEvents colReceivingReturnDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceivingReturnItemCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceivingReturnItemDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceivingReturnBOL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceivingReturnLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceivingReturnItemExpirationDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceivingReturnQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents productionXpView As DevExpress.Xpo.XPView
    Friend WithEvents colProductionDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductionItemCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductionItemDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductionPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductionLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPrdouctionExpirationDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductionQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shippingsXpView As DevExpress.Xpo.XPView
    Friend WithEvents colShippingDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShippingItemCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShippingItemDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShippingBOL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShippingLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShippingExpirationDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShippingQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shippingReturnsXpView As DevExpress.Xpo.XPView
    Friend WithEvents colShippingReturnDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShippingReturnItemCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShippingReturnItemDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShippingReturnBOL As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShippingReturnLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShippingReturnExpirationDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShippingReturnQuantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents transferToExpirationDateFormatGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTransferFromExpirationDateFormat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceivingExpirationDateFormat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReceivingReturnExpirationDateFormat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProductionExpirationDateFormat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShippingExpirationDateFormat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShippingReturnExpirationDateFormat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents inventoryByLotXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents inventoryByLotGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents locationInventoryByLotXpView As DevExpress.Xpo.XPView
    Friend WithEvents inventoryByLotGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colItemCode1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemDescription1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLPNNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuantity1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExpirationDate1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrintLpnSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colReceivingItemType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShippingItemType As DevExpress.XtraGrid.Columns.GridColumn
End Class
