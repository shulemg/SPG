<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomersXtraForm
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
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomersXtraForm))
        Me.locationInventoryGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.locationCodeGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.locationNameGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.quantityOnHandGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.itemsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.customerItemsXpCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.itemsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.codeGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.descriptionGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.onHandGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.palletsOnHandGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.customersXtraTabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.generalXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.lotCodeFormatLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.customersMenuBar = New DevExpress.XtraBars.Bar()
        Me.addBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.editBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.deleteBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.cancelBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.saveBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.reportsBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.lotCodeFormatsXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.expirationDateFormatComboBox = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lpnGroupControl = New DevExpress.XtraEditors.GroupControl()
        Me.resetLPNSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.plantCodeLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.plantCodeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.lastNumberLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.lastLPNNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.firsstNumberLabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.firstLPNNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.lpnPrefixlabelControl = New DevExpress.XtraEditors.LabelControl()
        Me.lpnPrefixTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.inactiveCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.postalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.stateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.cityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.addressTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.noteMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.faxTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.emailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.phoneTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.contactTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.nameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.itemsXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.relatedCustomersXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.addRelatedCustomerGroupControl = New DevExpress.XtraEditors.GroupControl()
        Me.relatedCustomerLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.customersXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.addBothWaysSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.addOneWaySimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.relatedCustomersGridControl = New DevExpress.XtraGrid.GridControl()
        Me.relatedCustomerXpCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.relatedCustomersGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.relatedCustomerNameGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBidirectional = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.deleteGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.deleteRepositoryItemButtonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.idGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.locationsXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.customerPlantsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.customerPlantsXpCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.customerPlantsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.deleteCustomerPlantGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.deleteCustomerPlantRepositoryItemButtonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHasChanges = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlantName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPlantCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.spgLocationsRepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.spgLocationsXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.customerShiftsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.customerShiftsXpCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.customerShiftsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.deleteCustomerShiftGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.deleteCustomerShiftRepositoryItemButtonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colOid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHasChanges1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShiftName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShiftCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.spgShiftRepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.spgShiftsXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.inactiveSearchCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.customerSearchGridControl = New DevExpress.XtraGrid.GridControl()
        Me.customerSearchXPView = New DevExpress.Xpo.XPView(Me.components)
        Me.customerSearchGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.customerIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.nameGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.locationInventoryGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.itemsGridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.customerItemsXpCollection,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.itemsGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.customersXtraTabControl,System.ComponentModel.ISupportInitialize).BeginInit
        Me.customersXtraTabControl.SuspendLayout
        Me.generalXtraTabPage.SuspendLayout
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl1.SuspendLayout
        CType(Me.lotCodeFormatLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.BarManager1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lotCodeFormatsXpView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.expirationDateFormatComboBox.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lpnGroupControl,System.ComponentModel.ISupportInitialize).BeginInit
        Me.lpnGroupControl.SuspendLayout
        CType(Me.plantCodeTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lastLPNNumberTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.firstLPNNumberTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lpnPrefixTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.inactiveCheckEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.postalTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.stateTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cityTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.addressTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.noteMemoEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.faxTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.emailTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.phoneTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.contactTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.nameTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.itemsXtraTabPage.SuspendLayout
        Me.relatedCustomersXtraTabPage.SuspendLayout
        CType(Me.addRelatedCustomerGroupControl,System.ComponentModel.ISupportInitialize).BeginInit
        Me.addRelatedCustomerGroupControl.SuspendLayout
        CType(Me.relatedCustomerLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.customersXpView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.relatedCustomersGridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.relatedCustomerXpCollection,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.relatedCustomersGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.deleteRepositoryItemButtonEdit,System.ComponentModel.ISupportInitialize).BeginInit
        Me.locationsXtraTabPage.SuspendLayout
        CType(Me.SplitContainerControl2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainerControl2.SuspendLayout
        CType(Me.customerPlantsGridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.customerPlantsXpCollection,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.customerPlantsGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.deleteCustomerPlantRepositoryItemButtonEdit,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.spgLocationsRepositoryItemLookUpEdit,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.spgLocationsXpView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.customerShiftsGridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.customerShiftsXpCollection,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.customerShiftsGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.deleteCustomerShiftRepositoryItemButtonEdit,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.spgShiftRepositoryItemLookUpEdit,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.spgShiftsXpView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SplitContainerControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainerControl1.SuspendLayout
        CType(Me.inactiveSearchCheckEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.customerSearchGridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.customerSearchXPView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.customerSearchGridView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'locationInventoryGridView
        '
        Me.locationInventoryGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.locationCodeGridColumn, Me.locationNameGridColumn, Me.quantityOnHandGridColumn})
        Me.locationInventoryGridView.GridControl = Me.itemsGridControl
        Me.locationInventoryGridView.Name = "locationInventoryGridView"
        Me.locationInventoryGridView.OptionsBehavior.Editable = false
        Me.locationInventoryGridView.OptionsView.ShowGroupPanel = false
        '
        'locationCodeGridColumn
        '
        Me.locationCodeGridColumn.Caption = "Location Code"
        Me.locationCodeGridColumn.FieldName = "Location.LocationCode"
        Me.locationCodeGridColumn.Name = "locationCodeGridColumn"
        Me.locationCodeGridColumn.Visible = true
        Me.locationCodeGridColumn.VisibleIndex = 0
        '
        'locationNameGridColumn
        '
        Me.locationNameGridColumn.Caption = "Location Name"
        Me.locationNameGridColumn.FieldName = "Location.LocationName"
        Me.locationNameGridColumn.Name = "locationNameGridColumn"
        Me.locationNameGridColumn.Visible = true
        Me.locationNameGridColumn.VisibleIndex = 1
        '
        'quantityOnHandGridColumn
        '
        Me.quantityOnHandGridColumn.Caption = "Quantity On Hand"
        Me.quantityOnHandGridColumn.FieldName = "QuantityOnHand"
        Me.quantityOnHandGridColumn.Name = "quantityOnHandGridColumn"
        Me.quantityOnHandGridColumn.Visible = true
        Me.quantityOnHandGridColumn.VisibleIndex = 2
        '
        'itemsGridControl
        '
        Me.itemsGridControl.DataSource = Me.customerItemsXpCollection
        Me.itemsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode2.LevelTemplate = Me.locationInventoryGridView
        GridLevelNode2.RelationName = "LocationsInventory"
        Me.itemsGridControl.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.itemsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.itemsGridControl.MainView = Me.itemsGridView
        Me.itemsGridControl.Name = "itemsGridControl"
        Me.itemsGridControl.ShowOnlyPredefinedDetails = true
        Me.itemsGridControl.Size = New System.Drawing.Size(573, 437)
        Me.itemsGridControl.TabIndex = 0
        Me.itemsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.itemsGridView, Me.locationInventoryGridView})
        '
        'customerItemsXpCollection
        '
        Me.customerItemsXpCollection.ObjectType = GetType(DXDAL.SPGData.Items)
        '
        'itemsGridView
        '
        Me.itemsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.codeGridColumn, Me.descriptionGridColumn, Me.onHandGridColumn, Me.palletsOnHandGridColumn})
        Me.itemsGridView.GridControl = Me.itemsGridControl
        Me.itemsGridView.Name = "itemsGridView"
        Me.itemsGridView.OptionsBehavior.Editable = false
        Me.itemsGridView.OptionsView.ShowAutoFilterRow = true
        Me.itemsGridView.OptionsView.ShowFooter = true
        '
        'codeGridColumn
        '
        Me.codeGridColumn.Caption = "Item Number"
        Me.codeGridColumn.FieldName = "ItemCode"
        Me.codeGridColumn.Name = "codeGridColumn"
        Me.codeGridColumn.OptionsColumn.ReadOnly = true
        Me.codeGridColumn.Visible = true
        Me.codeGridColumn.VisibleIndex = 0
        '
        'descriptionGridColumn
        '
        Me.descriptionGridColumn.Caption = "Description"
        Me.descriptionGridColumn.FieldName = "ItemDescription"
        Me.descriptionGridColumn.Name = "descriptionGridColumn"
        Me.descriptionGridColumn.OptionsColumn.ReadOnly = true
        Me.descriptionGridColumn.Visible = true
        Me.descriptionGridColumn.VisibleIndex = 1
        '
        'onHandGridColumn
        '
        Me.onHandGridColumn.Caption = "On Hand"
        Me.onHandGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.onHandGridColumn.FieldName = "TotalQuantityOnHand"
        Me.onHandGridColumn.Name = "onHandGridColumn"
        Me.onHandGridColumn.OptionsColumn.ReadOnly = true
        Me.onHandGridColumn.Visible = true
        Me.onHandGridColumn.VisibleIndex = 2
        '
        'palletsOnHandGridColumn
        '
        Me.palletsOnHandGridColumn.Caption = "Pallets On Hand"
        Me.palletsOnHandGridColumn.DisplayFormat.FormatString = "{0:#,##0.######}"
        Me.palletsOnHandGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.palletsOnHandGridColumn.FieldName = "palletsOnHandGridColumn"
        Me.palletsOnHandGridColumn.Name = "palletsOnHandGridColumn"
        Me.palletsOnHandGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "palletsOnHandGridColumn", "{0:#,##0.######}")})
        Me.palletsOnHandGridColumn.UnboundExpression = "[TotalQuantityOnHand]/[intUnitsPerPallet]"
        Me.palletsOnHandGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.palletsOnHandGridColumn.Visible = true
        Me.palletsOnHandGridColumn.VisibleIndex = 3
        '
        'customersXtraTabControl
        '
        Me.customersXtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.customersXtraTabControl.Location = New System.Drawing.Point(0, 0)
        Me.customersXtraTabControl.Name = "customersXtraTabControl"
        Me.customersXtraTabControl.SelectedTabPage = Me.generalXtraTabPage
        Me.customersXtraTabControl.Size = New System.Drawing.Size(579, 465)
        Me.customersXtraTabControl.TabIndex = 0
        Me.customersXtraTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.generalXtraTabPage, Me.itemsXtraTabPage, Me.relatedCustomersXtraTabPage, Me.locationsXtraTabPage})
        '
        'generalXtraTabPage
        '
        Me.generalXtraTabPage.Controls.Add(Me.GroupControl1)
        Me.generalXtraTabPage.Controls.Add(Me.lpnGroupControl)
        Me.generalXtraTabPage.Controls.Add(Me.inactiveCheckEdit)
        Me.generalXtraTabPage.Controls.Add(Me.postalTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.stateTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.cityTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.addressTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl10)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl9)
        Me.generalXtraTabPage.Controls.Add(Me.noteMemoEdit)
        Me.generalXtraTabPage.Controls.Add(Me.faxTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.emailTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.phoneTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.contactTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.nameTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl7)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl5)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl4)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl3)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl2)
        Me.generalXtraTabPage.Name = "generalXtraTabPage"
        Me.generalXtraTabPage.Size = New System.Drawing.Size(573, 437)
        Me.generalXtraTabPage.Text = "General Info"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.lotCodeFormatLookUpEdit)
        Me.GroupControl1.Controls.Add(Me.SimpleButton1)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.expirationDateFormatComboBox)
        Me.GroupControl1.Location = New System.Drawing.Point(31, 356)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(523, 73)
        Me.GroupControl1.TabIndex = 23
        Me.GroupControl1.Text = "Other Settings"
        '
        'lotCodeFormatLookUpEdit
        '
        Me.lotCodeFormatLookUpEdit.Location = New System.Drawing.Point(217, 44)
        Me.lotCodeFormatLookUpEdit.MenuManager = Me.BarManager1
        Me.lotCodeFormatLookUpEdit.Name = "lotCodeFormatLookUpEdit"
        Me.lotCodeFormatLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lotCodeFormatLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FormatID", "Format ID", 71, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FormatName", "Format Name", 74, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
        Me.lotCodeFormatLookUpEdit.Properties.DataSource = Me.lotCodeFormatsXpView
        Me.lotCodeFormatLookUpEdit.Properties.DisplayMember = "FormatName"
        Me.lotCodeFormatLookUpEdit.Properties.NullText = "[Select A Lot Code Format]"
        Me.lotCodeFormatLookUpEdit.Properties.ValueMember = "FormatID"
        Me.lotCodeFormatLookUpEdit.Size = New System.Drawing.Size(206, 20)
        Me.lotCodeFormatLookUpEdit.TabIndex = 9
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.customersMenuBar, Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.addBarButtonItem, Me.editBarButtonItem, Me.deleteBarButtonItem, Me.cancelBarButtonItem, Me.saveBarButtonItem, Me.reportsBarButtonItem})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 6
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'customersMenuBar
        '
        Me.customersMenuBar.BarName = "Tools"
        Me.customersMenuBar.DockCol = 0
        Me.customersMenuBar.DockRow = 1
        Me.customersMenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.customersMenuBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.addBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.editBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.cancelBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.saveBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.reportsBarButtonItem, true)})
        Me.customersMenuBar.OptionsBar.UseWholeRow = true
        Me.customersMenuBar.Text = "Tools"
        '
        'addBarButtonItem
        '
        Me.addBarButtonItem.Caption = "&Add Customer"
        Me.addBarButtonItem.Id = 0
        Me.addBarButtonItem.Name = "addBarButtonItem"
        '
        'editBarButtonItem
        '
        Me.editBarButtonItem.Caption = "&Edit Customer"
        Me.editBarButtonItem.Id = 1
        Me.editBarButtonItem.Name = "editBarButtonItem"
        '
        'deleteBarButtonItem
        '
        Me.deleteBarButtonItem.Caption = "Delete Customer"
        Me.deleteBarButtonItem.Id = 2
        Me.deleteBarButtonItem.Name = "deleteBarButtonItem"
        '
        'cancelBarButtonItem
        '
        Me.cancelBarButtonItem.Caption = "&Cancel Changes"
        Me.cancelBarButtonItem.Enabled = false
        Me.cancelBarButtonItem.Id = 3
        Me.cancelBarButtonItem.Name = "cancelBarButtonItem"
        '
        'saveBarButtonItem
        '
        Me.saveBarButtonItem.Caption = "&Save Changes"
        Me.saveBarButtonItem.Enabled = false
        Me.saveBarButtonItem.Id = 4
        Me.saveBarButtonItem.Name = "saveBarButtonItem"
        '
        'reportsBarButtonItem
        '
        Me.reportsBarButtonItem.Caption = "&Reports"
        Me.reportsBarButtonItem.Id = 5
        Me.reportsBarButtonItem.Name = "reportsBarButtonItem"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(784, 49)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = false
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 514)
        Me.barDockControlBottom.Size = New System.Drawing.Size(784, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = false
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 49)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 465)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = false
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(784, 49)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 465)
        '
        'lotCodeFormatsXpView
        '
        Me.lotCodeFormatsXpView.ObjectType = GetType(DXDAL.SPGData.LotCodeFormats)
        Me.lotCodeFormatsXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("FormatID", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true), New DevExpress.Xpo.ViewProperty("FormatName", DevExpress.Xpo.SortDirection.Ascending, "[FormatName]", false, true)})
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(430, 25)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 39)
        Me.SimpleButton1.TabIndex = 8
        Me.SimpleButton1.Text = "Reset LPN "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Number"
        Me.SimpleButton1.Visible = false
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(217, 23)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = "Lot Code Format"
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(5, 24)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(111, 13)
        Me.LabelControl11.TabIndex = 1
        Me.LabelControl11.Text = "Expiration Date Format"
        '
        'expirationDateFormatComboBox
        '
        Me.expirationDateFormatComboBox.EditValue = ""
        Me.expirationDateFormatComboBox.Location = New System.Drawing.Point(5, 43)
        Me.expirationDateFormatComboBox.MenuManager = Me.BarManager1
        Me.expirationDateFormatComboBox.Name = "expirationDateFormatComboBox"
        Me.expirationDateFormatComboBox.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.expirationDateFormatComboBox.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.expirationDateFormatComboBox.Properties.Items.AddRange(New Object() {"MM/dd/yyyy", "MM/yyyy"})
        Me.expirationDateFormatComboBox.Size = New System.Drawing.Size(206, 20)
        Me.expirationDateFormatComboBox.TabIndex = 0
        '
        'lpnGroupControl
        '
        Me.lpnGroupControl.Controls.Add(Me.resetLPNSimpleButton)
        Me.lpnGroupControl.Controls.Add(Me.plantCodeLabelControl)
        Me.lpnGroupControl.Controls.Add(Me.plantCodeTextEdit)
        Me.lpnGroupControl.Controls.Add(Me.lastNumberLabelControl)
        Me.lpnGroupControl.Controls.Add(Me.lastLPNNumberTextEdit)
        Me.lpnGroupControl.Controls.Add(Me.firsstNumberLabelControl)
        Me.lpnGroupControl.Controls.Add(Me.firstLPNNumberTextEdit)
        Me.lpnGroupControl.Controls.Add(Me.lpnPrefixlabelControl)
        Me.lpnGroupControl.Controls.Add(Me.lpnPrefixTextEdit)
        Me.lpnGroupControl.Location = New System.Drawing.Point(31, 277)
        Me.lpnGroupControl.Name = "lpnGroupControl"
        Me.lpnGroupControl.Size = New System.Drawing.Size(523, 73)
        Me.lpnGroupControl.TabIndex = 22
        Me.lpnGroupControl.Text = "LPN Settings"
        '
        'resetLPNSimpleButton
        '
        Me.resetLPNSimpleButton.Location = New System.Drawing.Point(430, 25)
        Me.resetLPNSimpleButton.Name = "resetLPNSimpleButton"
        Me.resetLPNSimpleButton.Size = New System.Drawing.Size(75, 39)
        Me.resetLPNSimpleButton.TabIndex = 8
        Me.resetLPNSimpleButton.Text = "Reset LPN "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"Number"
        '
        'plantCodeLabelControl
        '
        Me.plantCodeLabelControl.Location = New System.Drawing.Point(323, 25)
        Me.plantCodeLabelControl.Name = "plantCodeLabelControl"
        Me.plantCodeLabelControl.Size = New System.Drawing.Size(52, 13)
        Me.plantCodeLabelControl.TabIndex = 7
        Me.plantCodeLabelControl.Text = "Plant Code"
        '
        'plantCodeTextEdit
        '
        Me.plantCodeTextEdit.Location = New System.Drawing.Point(323, 44)
        Me.plantCodeTextEdit.MenuManager = Me.BarManager1
        Me.plantCodeTextEdit.Name = "plantCodeTextEdit"
        Me.plantCodeTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.plantCodeTextEdit.TabIndex = 6
        '
        'lastNumberLabelControl
        '
        Me.lastNumberLabelControl.Location = New System.Drawing.Point(217, 24)
        Me.lastNumberLabelControl.Name = "lastNumberLabelControl"
        Me.lastNumberLabelControl.Size = New System.Drawing.Size(60, 13)
        Me.lastNumberLabelControl.TabIndex = 5
        Me.lastNumberLabelControl.Text = "Last Number"
        '
        'lastLPNNumberTextEdit
        '
        Me.lastLPNNumberTextEdit.Location = New System.Drawing.Point(217, 43)
        Me.lastLPNNumberTextEdit.MenuManager = Me.BarManager1
        Me.lastLPNNumberTextEdit.Name = "lastLPNNumberTextEdit"
        Me.lastLPNNumberTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.lastLPNNumberTextEdit.TabIndex = 4
        '
        'firsstNumberLabelControl
        '
        Me.firsstNumberLabelControl.Location = New System.Drawing.Point(111, 24)
        Me.firsstNumberLabelControl.Name = "firsstNumberLabelControl"
        Me.firsstNumberLabelControl.Size = New System.Drawing.Size(61, 13)
        Me.firsstNumberLabelControl.TabIndex = 3
        Me.firsstNumberLabelControl.Text = "First Number"
        '
        'firstLPNNumberTextEdit
        '
        Me.firstLPNNumberTextEdit.EditValue = ""
        Me.firstLPNNumberTextEdit.Location = New System.Drawing.Point(111, 43)
        Me.firstLPNNumberTextEdit.MenuManager = Me.BarManager1
        Me.firstLPNNumberTextEdit.Name = "firstLPNNumberTextEdit"
        Me.firstLPNNumberTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.firstLPNNumberTextEdit.TabIndex = 2
        '
        'lpnPrefixlabelControl
        '
        Me.lpnPrefixlabelControl.Location = New System.Drawing.Point(5, 24)
        Me.lpnPrefixlabelControl.Name = "lpnPrefixlabelControl"
        Me.lpnPrefixlabelControl.Size = New System.Drawing.Size(49, 13)
        Me.lpnPrefixlabelControl.TabIndex = 1
        Me.lpnPrefixlabelControl.Text = "LPN Prefix"
        '
        'lpnPrefixTextEdit
        '
        Me.lpnPrefixTextEdit.EditValue = ""
        Me.lpnPrefixTextEdit.Location = New System.Drawing.Point(5, 43)
        Me.lpnPrefixTextEdit.MenuManager = Me.BarManager1
        Me.lpnPrefixTextEdit.Name = "lpnPrefixTextEdit"
        Me.lpnPrefixTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.lpnPrefixTextEdit.TabIndex = 0
        '
        'inactiveCheckEdit
        '
        Me.inactiveCheckEdit.Location = New System.Drawing.Point(151, 252)
        Me.inactiveCheckEdit.Name = "inactiveCheckEdit"
        Me.inactiveCheckEdit.Properties.Caption = "Inactive"
        Me.inactiveCheckEdit.Size = New System.Drawing.Size(75, 19)
        Me.inactiveCheckEdit.TabIndex = 21
        '
        'postalTextEdit
        '
        Me.postalTextEdit.Location = New System.Drawing.Point(395, 99)
        Me.postalTextEdit.Name = "postalTextEdit"
        Me.postalTextEdit.Properties.NullText = "[Postal]"
        Me.postalTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.postalTextEdit.TabIndex = 9
        '
        'stateTextEdit
        '
        Me.stateTextEdit.Location = New System.Drawing.Point(289, 99)
        Me.stateTextEdit.Name = "stateTextEdit"
        Me.stateTextEdit.Properties.NullText = "[State]"
        Me.stateTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.stateTextEdit.TabIndex = 8
        '
        'cityTextEdit
        '
        Me.cityTextEdit.Location = New System.Drawing.Point(153, 99)
        Me.cityTextEdit.Name = "cityTextEdit"
        Me.cityTextEdit.Properties.NullText = "[City]"
        Me.cityTextEdit.Size = New System.Drawing.Size(130, 20)
        Me.cityTextEdit.TabIndex = 7
        '
        'addressTextEdit
        '
        Me.addressTextEdit.Location = New System.Drawing.Point(153, 73)
        Me.addressTextEdit.Name = "addressTextEdit"
        Me.addressTextEdit.Size = New System.Drawing.Size(342, 20)
        Me.addressTextEdit.TabIndex = 5
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(66, 102)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(67, 13)
        Me.LabelControl10.TabIndex = 6
        Me.LabelControl10.Text = "City\State\Zip"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(66, 76)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl9.TabIndex = 4
        Me.LabelControl9.Text = "Address"
        '
        'noteMemoEdit
        '
        Me.noteMemoEdit.Location = New System.Drawing.Point(153, 177)
        Me.noteMemoEdit.Name = "noteMemoEdit"
        Me.noteMemoEdit.Size = New System.Drawing.Size(342, 69)
        Me.noteMemoEdit.TabIndex = 16
        '
        'faxTextEdit
        '
        Me.faxTextEdit.Location = New System.Drawing.Point(327, 125)
        Me.faxTextEdit.Name = "faxTextEdit"
        Me.faxTextEdit.Properties.NullText = "[Fax Number]"
        Me.faxTextEdit.Size = New System.Drawing.Size(168, 20)
        Me.faxTextEdit.TabIndex = 12
        '
        'emailTextEdit
        '
        Me.emailTextEdit.Location = New System.Drawing.Point(153, 151)
        Me.emailTextEdit.Name = "emailTextEdit"
        Me.emailTextEdit.Size = New System.Drawing.Size(342, 20)
        Me.emailTextEdit.TabIndex = 14
        '
        'phoneTextEdit
        '
        Me.phoneTextEdit.Location = New System.Drawing.Point(153, 125)
        Me.phoneTextEdit.Name = "phoneTextEdit"
        Me.phoneTextEdit.Properties.NullText = "[Phone Number]"
        Me.phoneTextEdit.Size = New System.Drawing.Size(168, 20)
        Me.phoneTextEdit.TabIndex = 11
        '
        'contactTextEdit
        '
        Me.contactTextEdit.Location = New System.Drawing.Point(153, 46)
        Me.contactTextEdit.Name = "contactTextEdit"
        Me.contactTextEdit.Size = New System.Drawing.Size(342, 20)
        Me.contactTextEdit.TabIndex = 3
        '
        'nameTextEdit
        '
        Me.nameTextEdit.Location = New System.Drawing.Point(153, 20)
        Me.nameTextEdit.Name = "nameTextEdit"
        Me.nameTextEdit.Size = New System.Drawing.Size(342, 20)
        Me.nameTextEdit.TabIndex = 1
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(66, 180)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl7.TabIndex = 15
        Me.LabelControl7.Text = "Note"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(66, 154)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl5.TabIndex = 13
        Me.LabelControl5.Text = "Email Address"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(66, 128)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl4.TabIndex = 10
        Me.LabelControl4.Text = "Phone\Fax"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(66, 49)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(68, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Contact Name"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(66, 23)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Name"
        '
        'itemsXtraTabPage
        '
        Me.itemsXtraTabPage.Controls.Add(Me.itemsGridControl)
        Me.itemsXtraTabPage.Name = "itemsXtraTabPage"
        Me.itemsXtraTabPage.Size = New System.Drawing.Size(573, 437)
        Me.itemsXtraTabPage.Text = "Items"
        '
        'relatedCustomersXtraTabPage
        '
        Me.relatedCustomersXtraTabPage.Controls.Add(Me.addRelatedCustomerGroupControl)
        Me.relatedCustomersXtraTabPage.Controls.Add(Me.relatedCustomersGridControl)
        Me.relatedCustomersXtraTabPage.Name = "relatedCustomersXtraTabPage"
        Me.relatedCustomersXtraTabPage.Size = New System.Drawing.Size(573, 437)
        Me.relatedCustomersXtraTabPage.Text = "Related Customers"
        '
        'addRelatedCustomerGroupControl
        '
        Me.addRelatedCustomerGroupControl.Controls.Add(Me.relatedCustomerLookUpEdit)
        Me.addRelatedCustomerGroupControl.Controls.Add(Me.addBothWaysSimpleButton)
        Me.addRelatedCustomerGroupControl.Controls.Add(Me.addOneWaySimpleButton)
        Me.addRelatedCustomerGroupControl.Location = New System.Drawing.Point(3, 10)
        Me.addRelatedCustomerGroupControl.Name = "addRelatedCustomerGroupControl"
        Me.addRelatedCustomerGroupControl.Size = New System.Drawing.Size(561, 75)
        Me.addRelatedCustomerGroupControl.TabIndex = 4
        Me.addRelatedCustomerGroupControl.Text = "Add related Customers"
        '
        'relatedCustomerLookUpEdit
        '
        Me.relatedCustomerLookUpEdit.Location = New System.Drawing.Point(31, 37)
        Me.relatedCustomerLookUpEdit.MenuManager = Me.BarManager1
        Me.relatedCustomerLookUpEdit.Name = "relatedCustomerLookUpEdit"
        Me.relatedCustomerLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.relatedCustomerLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Customer Name", 99, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerID", "Customer ID", 70, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)})
        Me.relatedCustomerLookUpEdit.Properties.DataSource = Me.customersXpView
        Me.relatedCustomerLookUpEdit.Properties.DisplayMember = "CustomerName"
        Me.relatedCustomerLookUpEdit.Properties.NullValuePrompt = "[Select a related customer]"
        Me.relatedCustomerLookUpEdit.Properties.ValueMember = "CustomerID"
        Me.relatedCustomerLookUpEdit.Size = New System.Drawing.Size(278, 20)
        Me.relatedCustomerLookUpEdit.TabIndex = 6
        '
        'customersXpView
        '
        Me.customersXpView.CriteriaString = "[Inactive] = False"
        Me.customersXpView.ObjectType = GetType(DXDAL.SPGData.Customers)
        Me.customersXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[CustomerID]", false, true), New DevExpress.Xpo.ViewProperty("CustomerName", DevExpress.Xpo.SortDirection.Ascending, "[CustomerName]", false, true), New DevExpress.Xpo.ViewProperty("Inactive", DevExpress.Xpo.SortDirection.None, "[Inactive]", false, true)})
        '
        'addBothWaysSimpleButton
        '
        Me.addBothWaysSimpleButton.Location = New System.Drawing.Point(425, 37)
        Me.addBothWaysSimpleButton.Name = "addBothWaysSimpleButton"
        Me.addBothWaysSimpleButton.Size = New System.Drawing.Size(104, 23)
        Me.addBothWaysSimpleButton.TabIndex = 5
        Me.addBothWaysSimpleButton.Text = "Add Both Ways"
        '
        'addOneWaySimpleButton
        '
        Me.addOneWaySimpleButton.Location = New System.Drawing.Point(315, 37)
        Me.addOneWaySimpleButton.Name = "addOneWaySimpleButton"
        Me.addOneWaySimpleButton.Size = New System.Drawing.Size(104, 23)
        Me.addOneWaySimpleButton.TabIndex = 4
        Me.addOneWaySimpleButton.Text = "Add One Way"
        '
        'relatedCustomersGridControl
        '
        Me.relatedCustomersGridControl.DataSource = Me.relatedCustomerXpCollection
        Me.relatedCustomersGridControl.Location = New System.Drawing.Point(3, 91)
        Me.relatedCustomersGridControl.MainView = Me.relatedCustomersGridView
        Me.relatedCustomersGridControl.MenuManager = Me.BarManager1
        Me.relatedCustomersGridControl.Name = "relatedCustomersGridControl"
        Me.relatedCustomersGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.deleteRepositoryItemButtonEdit})
        Me.relatedCustomersGridControl.Size = New System.Drawing.Size(565, 270)
        Me.relatedCustomersGridControl.TabIndex = 0
        Me.relatedCustomersGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.relatedCustomersGridView})
        '
        'relatedCustomerXpCollection
        '
        Me.relatedCustomerXpCollection.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowRemove
        Me.relatedCustomerXpCollection.DisplayableProperties = "This;Oid;MainCustomer!;MainCustomer!Key;MainCustomer;RelatedCustomer!;RelatedCust"& _ 
    "omer!Key;RelatedCustomer;Bidirectional;RelatedCustomer.CustomerName"
        Me.relatedCustomerXpCollection.ObjectType = GetType(DXDAL.SPGData.RelatedCustomer)
        '
        'relatedCustomersGridView
        '
        Me.relatedCustomersGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.relatedCustomerNameGridColumn, Me.colBidirectional, Me.deleteGridColumn, Me.idGridColumn})
        Me.relatedCustomersGridView.GridControl = Me.relatedCustomersGridControl
        Me.relatedCustomersGridView.Name = "relatedCustomersGridView"
        Me.relatedCustomersGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.relatedCustomersGridView.OptionsView.ShowDetailButtons = false
        '
        'relatedCustomerNameGridColumn
        '
        Me.relatedCustomerNameGridColumn.Caption = "Related Customer"
        Me.relatedCustomerNameGridColumn.FieldName = "RelatedCustomer.CustomerName"
        Me.relatedCustomerNameGridColumn.Name = "relatedCustomerNameGridColumn"
        Me.relatedCustomerNameGridColumn.OptionsColumn.AllowEdit = false
        Me.relatedCustomerNameGridColumn.OptionsColumn.ReadOnly = true
        Me.relatedCustomerNameGridColumn.Visible = true
        Me.relatedCustomerNameGridColumn.VisibleIndex = 1
        Me.relatedCustomerNameGridColumn.Width = 257
        '
        'colBidirectional
        '
        Me.colBidirectional.Caption = "Both Directions"
        Me.colBidirectional.FieldName = "Bidirectional"
        Me.colBidirectional.Name = "colBidirectional"
        Me.colBidirectional.OptionsColumn.AllowEdit = false
        Me.colBidirectional.Visible = true
        Me.colBidirectional.VisibleIndex = 2
        Me.colBidirectional.Width = 262
        '
        'deleteGridColumn
        '
        Me.deleteGridColumn.ColumnEdit = Me.deleteRepositoryItemButtonEdit
        Me.deleteGridColumn.MaxWidth = 25
        Me.deleteGridColumn.Name = "deleteGridColumn"
        Me.deleteGridColumn.OptionsColumn.AllowSize = false
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
        'idGridColumn
        '
        Me.idGridColumn.Caption = "GridColumn1"
        Me.idGridColumn.FieldName = "Oid"
        Me.idGridColumn.Name = "idGridColumn"
        '
        'locationsXtraTabPage
        '
        Me.locationsXtraTabPage.Controls.Add(Me.SplitContainerControl2)
        Me.locationsXtraTabPage.Name = "locationsXtraTabPage"
        Me.locationsXtraTabPage.Size = New System.Drawing.Size(573, 437)
        Me.locationsXtraTabPage.Text = "Plants && Shifts"
        '
        'SplitContainerControl2
        '
        Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl2.Horizontal = false
        Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerControl2.Name = "SplitContainerControl2"
        Me.SplitContainerControl2.Panel1.Controls.Add(Me.customerPlantsGridControl)
        Me.SplitContainerControl2.Panel1.Text = "Panel1"
        Me.SplitContainerControl2.Panel2.Controls.Add(Me.customerShiftsGridControl)
        Me.SplitContainerControl2.Panel2.Text = "Panel2"
        Me.SplitContainerControl2.Size = New System.Drawing.Size(573, 437)
        Me.SplitContainerControl2.SplitterPosition = 209
        Me.SplitContainerControl2.TabIndex = 0
        Me.SplitContainerControl2.Text = "SplitContainerControl2"
        '
        'customerPlantsGridControl
        '
        Me.customerPlantsGridControl.DataSource = Me.customerPlantsXpCollection
        Me.customerPlantsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.customerPlantsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.customerPlantsGridControl.MainView = Me.customerPlantsGridView
        Me.customerPlantsGridControl.MenuManager = Me.BarManager1
        Me.customerPlantsGridControl.Name = "customerPlantsGridControl"
        Me.customerPlantsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.spgLocationsRepositoryItemLookUpEdit, Me.deleteCustomerPlantRepositoryItemButtonEdit})
        Me.customerPlantsGridControl.Size = New System.Drawing.Size(573, 209)
        Me.customerPlantsGridControl.TabIndex = 0
        Me.customerPlantsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.customerPlantsGridView})
        '
        'customerPlantsXpCollection
        '
        Me.customerPlantsXpCollection.ObjectType = GetType(DXDAL.SPGData.CustomerPlants)
        '
        'customerPlantsGridView
        '
        Me.customerPlantsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.deleteCustomerPlantGridColumn, Me.colOid, Me.colHasChanges, Me.GridColumn1, Me.GridColumn2, Me.colPlantName, Me.colPlantCode, Me.GridColumn3, Me.GridColumn4})
        Me.customerPlantsGridView.GridControl = Me.customerPlantsGridControl
        Me.customerPlantsGridView.Name = "customerPlantsGridView"
        Me.customerPlantsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.customerPlantsGridView.OptionsView.ShowDetailButtons = false
        Me.customerPlantsGridView.OptionsView.ShowGroupPanel = false
        '
        'deleteCustomerPlantGridColumn
        '
        Me.deleteCustomerPlantGridColumn.ColumnEdit = Me.deleteCustomerPlantRepositoryItemButtonEdit
        Me.deleteCustomerPlantGridColumn.MaxWidth = 25
        Me.deleteCustomerPlantGridColumn.Name = "deleteCustomerPlantGridColumn"
        Me.deleteCustomerPlantGridColumn.OptionsColumn.AllowSize = false
        Me.deleteCustomerPlantGridColumn.Visible = true
        Me.deleteCustomerPlantGridColumn.VisibleIndex = 0
        Me.deleteCustomerPlantGridColumn.Width = 25
        '
        'deleteCustomerPlantRepositoryItemButtonEdit
        '
        Me.deleteCustomerPlantRepositoryItemButtonEdit.AutoHeight = false
        Me.deleteCustomerPlantRepositoryItemButtonEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.deleteCustomerPlantRepositoryItemButtonEdit.Name = "deleteCustomerPlantRepositoryItemButtonEdit"
        Me.deleteCustomerPlantRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colOid
        '
        Me.colOid.FieldName = "Oid"
        Me.colOid.Name = "colOid"
        '
        'colHasChanges
        '
        Me.colHasChanges.FieldName = "HasChanges"
        Me.colHasChanges.Name = "colHasChanges"
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "Customer!"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "Customer!Key"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'colPlantName
        '
        Me.colPlantName.FieldName = "PlantName"
        Me.colPlantName.Name = "colPlantName"
        Me.colPlantName.Visible = true
        Me.colPlantName.VisibleIndex = 1
        Me.colPlantName.Width = 175
        '
        'colPlantCode
        '
        Me.colPlantCode.FieldName = "PlantCode"
        Me.colPlantCode.Name = "colPlantCode"
        Me.colPlantCode.Visible = true
        Me.colPlantCode.VisibleIndex = 2
        Me.colPlantCode.Width = 175
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "SPGLocation!"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.ColumnEdit = Me.spgLocationsRepositoryItemLookUpEdit
        Me.GridColumn4.FieldName = "SPGLocation!Key"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = true
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 180
        '
        'spgLocationsRepositoryItemLookUpEdit
        '
        Me.spgLocationsRepositoryItemLookUpEdit.AutoHeight = false
        Me.spgLocationsRepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spgLocationsRepositoryItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationID", "Location ID", 77, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationName", "Location Name", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
        Me.spgLocationsRepositoryItemLookUpEdit.DataSource = Me.spgLocationsXpView
        Me.spgLocationsRepositoryItemLookUpEdit.DisplayMember = "LocationName"
        Me.spgLocationsRepositoryItemLookUpEdit.Name = "spgLocationsRepositoryItemLookUpEdit"
        Me.spgLocationsRepositoryItemLookUpEdit.ValueMember = "LocationID"
        '
        'spgLocationsXpView
        '
        Me.spgLocationsXpView.ObjectType = GetType(DXDAL.SPGData.Locations)
        Me.spgLocationsXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("LocationID", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true), New DevExpress.Xpo.ViewProperty("LocationName", DevExpress.Xpo.SortDirection.None, "[LocationName]", false, true)})
        '
        'customerShiftsGridControl
        '
        Me.customerShiftsGridControl.DataSource = Me.customerShiftsXpCollection
        Me.customerShiftsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.customerShiftsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.customerShiftsGridControl.MainView = Me.customerShiftsGridView
        Me.customerShiftsGridControl.MenuManager = Me.BarManager1
        Me.customerShiftsGridControl.Name = "customerShiftsGridControl"
        Me.customerShiftsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.deleteCustomerShiftRepositoryItemButtonEdit, Me.spgShiftRepositoryItemLookUpEdit})
        Me.customerShiftsGridControl.Size = New System.Drawing.Size(573, 223)
        Me.customerShiftsGridControl.TabIndex = 0
        Me.customerShiftsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.customerShiftsGridView})
        '
        'customerShiftsXpCollection
        '
        Me.customerShiftsXpCollection.ObjectType = GetType(DXDAL.SPGData.CustomerShifts)
        '
        'customerShiftsGridView
        '
        Me.customerShiftsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.deleteCustomerShiftGridColumn, Me.colOid1, Me.colHasChanges1, Me.GridColumn5, Me.GridColumn6, Me.colShiftName, Me.colShiftCode, Me.GridColumn7, Me.GridColumn8})
        Me.customerShiftsGridView.GridControl = Me.customerShiftsGridControl
        Me.customerShiftsGridView.Name = "customerShiftsGridView"
        Me.customerShiftsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.customerShiftsGridView.OptionsView.ShowDetailButtons = false
        Me.customerShiftsGridView.OptionsView.ShowGroupPanel = false
        '
        'deleteCustomerShiftGridColumn
        '
        Me.deleteCustomerShiftGridColumn.ColumnEdit = Me.deleteCustomerShiftRepositoryItemButtonEdit
        Me.deleteCustomerShiftGridColumn.MaxWidth = 25
        Me.deleteCustomerShiftGridColumn.Name = "deleteCustomerShiftGridColumn"
        Me.deleteCustomerShiftGridColumn.OptionsColumn.AllowSize = false
        Me.deleteCustomerShiftGridColumn.Visible = true
        Me.deleteCustomerShiftGridColumn.VisibleIndex = 0
        Me.deleteCustomerShiftGridColumn.Width = 25
        '
        'deleteCustomerShiftRepositoryItemButtonEdit
        '
        Me.deleteCustomerShiftRepositoryItemButtonEdit.AutoHeight = false
        Me.deleteCustomerShiftRepositoryItemButtonEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.deleteCustomerShiftRepositoryItemButtonEdit.Name = "deleteCustomerShiftRepositoryItemButtonEdit"
        Me.deleteCustomerShiftRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colOid1
        '
        Me.colOid1.FieldName = "Oid"
        Me.colOid1.Name = "colOid1"
        Me.colOid1.Width = 65
        '
        'colHasChanges1
        '
        Me.colHasChanges1.FieldName = "HasChanges"
        Me.colHasChanges1.Name = "colHasChanges1"
        Me.colHasChanges1.Width = 65
        '
        'GridColumn5
        '
        Me.GridColumn5.FieldName = "Customer!"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Width = 65
        '
        'GridColumn6
        '
        Me.GridColumn6.FieldName = "Customer!Key"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Width = 65
        '
        'colShiftName
        '
        Me.colShiftName.FieldName = "ShiftName"
        Me.colShiftName.Name = "colShiftName"
        Me.colShiftName.Visible = true
        Me.colShiftName.VisibleIndex = 1
        Me.colShiftName.Width = 65
        '
        'colShiftCode
        '
        Me.colShiftCode.FieldName = "ShiftCode"
        Me.colShiftCode.Name = "colShiftCode"
        Me.colShiftCode.Visible = true
        Me.colShiftCode.VisibleIndex = 2
        Me.colShiftCode.Width = 65
        '
        'GridColumn7
        '
        Me.GridColumn7.FieldName = "SPGShift!"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Width = 65
        '
        'GridColumn8
        '
        Me.GridColumn8.ColumnEdit = Me.spgShiftRepositoryItemLookUpEdit
        Me.GridColumn8.FieldName = "SPGShift!Key"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = true
        Me.GridColumn8.VisibleIndex = 3
        '
        'spgShiftRepositoryItemLookUpEdit
        '
        Me.spgShiftRepositoryItemLookUpEdit.AutoHeight = false
        Me.spgShiftRepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spgShiftRepositoryItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ShiftID", "Shift ID", 59, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Shift", "Shift", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
        Me.spgShiftRepositoryItemLookUpEdit.DataSource = Me.spgShiftsXpView
        Me.spgShiftRepositoryItemLookUpEdit.DisplayMember = "Shift"
        Me.spgShiftRepositoryItemLookUpEdit.Name = "spgShiftRepositoryItemLookUpEdit"
        Me.spgShiftRepositoryItemLookUpEdit.ValueMember = "ShiftID"
        '
        'spgShiftsXpView
        '
        Me.spgShiftsXpView.ObjectType = GetType(DXDAL.SPGData.Shifts)
        Me.spgShiftsXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("ShiftID", DevExpress.Xpo.SortDirection.None, "[ShiftID]", false, true), New DevExpress.Xpo.ViewProperty("Shift", DevExpress.Xpo.SortDirection.None, "[ShiftName]", false, true)})
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 49)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.inactiveSearchCheckEdit)
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.customerSearchGridControl)
        Me.SplitContainerControl1.Panel1.MinSize = 200
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.customersXtraTabControl)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(784, 465)
        Me.SplitContainerControl1.SplitterPosition = 200
        Me.SplitContainerControl1.TabIndex = 6
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'inactiveSearchCheckEdit
        '
        Me.inactiveSearchCheckEdit.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.inactiveSearchCheckEdit.Location = New System.Drawing.Point(0, 446)
        Me.inactiveSearchCheckEdit.Name = "inactiveSearchCheckEdit"
        Me.inactiveSearchCheckEdit.Properties.Caption = "Include inactive"
        Me.inactiveSearchCheckEdit.Size = New System.Drawing.Size(200, 19)
        Me.inactiveSearchCheckEdit.TabIndex = 1
        '
        'customerSearchGridControl
        '
        Me.customerSearchGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.customerSearchGridControl.DataSource = Me.customerSearchXPView
        Me.customerSearchGridControl.Location = New System.Drawing.Point(0, 0)
        Me.customerSearchGridControl.MainView = Me.customerSearchGridView
        Me.customerSearchGridControl.Name = "customerSearchGridControl"
        Me.customerSearchGridControl.Size = New System.Drawing.Size(196, 436)
        Me.customerSearchGridControl.TabIndex = 0
        Me.customerSearchGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.customerSearchGridView})
        '
        'customerSearchXPView
        '
        Me.customerSearchXPView.ObjectType = GetType(DXDAL.SPGData.Customers)
        Me.customerSearchXPView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[CustomerID]", false, true), New DevExpress.Xpo.ViewProperty("CustomerName", DevExpress.Xpo.SortDirection.None, "[CustomerName]", false, true), New DevExpress.Xpo.ViewProperty("Inactive", DevExpress.Xpo.SortDirection.None, "[Inactive]", false, true)})
        '
        'customerSearchGridView
        '
        Me.customerSearchGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.customerIDGridColumn, Me.nameGridColumn})
        Me.customerSearchGridView.GridControl = Me.customerSearchGridControl
        Me.customerSearchGridView.Name = "customerSearchGridView"
        Me.customerSearchGridView.OptionsBehavior.Editable = false
        Me.customerSearchGridView.OptionsView.ShowAutoFilterRow = true
        Me.customerSearchGridView.OptionsView.ShowGroupPanel = false
        Me.customerSearchGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.nameGridColumn, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'customerIDGridColumn
        '
        Me.customerIDGridColumn.Caption = "GridColumn1"
        Me.customerIDGridColumn.FieldName = "CustomerID"
        Me.customerIDGridColumn.Name = "customerIDGridColumn"
        '
        'nameGridColumn
        '
        Me.nameGridColumn.Caption = "Name"
        Me.nameGridColumn.FieldName = "CustomerName"
        Me.nameGridColumn.Name = "nameGridColumn"
        Me.nameGridColumn.Visible = true
        Me.nameGridColumn.VisibleIndex = 0
        '
        'CustomersXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 537)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "CustomersXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customers Manager"
        CType(Me.locationInventoryGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.itemsGridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.customerItemsXpCollection,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.itemsGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.customersXtraTabControl,System.ComponentModel.ISupportInitialize).EndInit
        Me.customersXtraTabControl.ResumeLayout(false)
        Me.generalXtraTabPage.ResumeLayout(false)
        Me.generalXtraTabPage.PerformLayout
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl1.ResumeLayout(false)
        Me.GroupControl1.PerformLayout
        CType(Me.lotCodeFormatLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.BarManager1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lotCodeFormatsXpView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.expirationDateFormatComboBox.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lpnGroupControl,System.ComponentModel.ISupportInitialize).EndInit
        Me.lpnGroupControl.ResumeLayout(false)
        Me.lpnGroupControl.PerformLayout
        CType(Me.plantCodeTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lastLPNNumberTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.firstLPNNumberTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lpnPrefixTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.inactiveCheckEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.postalTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.stateTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cityTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.addressTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.noteMemoEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.faxTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.emailTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.phoneTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.contactTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.nameTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.itemsXtraTabPage.ResumeLayout(false)
        Me.relatedCustomersXtraTabPage.ResumeLayout(false)
        CType(Me.addRelatedCustomerGroupControl,System.ComponentModel.ISupportInitialize).EndInit
        Me.addRelatedCustomerGroupControl.ResumeLayout(false)
        CType(Me.relatedCustomerLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.customersXpView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.relatedCustomersGridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.relatedCustomerXpCollection,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.relatedCustomersGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.deleteRepositoryItemButtonEdit,System.ComponentModel.ISupportInitialize).EndInit
        Me.locationsXtraTabPage.ResumeLayout(false)
        CType(Me.SplitContainerControl2,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainerControl2.ResumeLayout(false)
        CType(Me.customerPlantsGridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.customerPlantsXpCollection,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.customerPlantsGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.deleteCustomerPlantRepositoryItemButtonEdit,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.spgLocationsRepositoryItemLookUpEdit,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.spgLocationsXpView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.customerShiftsGridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.customerShiftsXpCollection,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.customerShiftsGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.deleteCustomerShiftRepositoryItemButtonEdit,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.spgShiftRepositoryItemLookUpEdit,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.spgShiftsXpView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SplitContainerControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainerControl1.ResumeLayout(false)
        CType(Me.inactiveSearchCheckEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.customerSearchGridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.customerSearchXPView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.customerSearchGridView,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents customersXtraTabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents generalXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents itemsXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents faxTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents emailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents phoneTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents contactTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents nameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents noteMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents itemsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents itemsGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents codeGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents descriptionGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents postalTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents stateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents addressTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents inactiveCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents onHandGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents customersMenuBar As DevExpress.XtraBars.Bar
    Friend WithEvents addBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents editBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents deleteBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cancelBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents saveBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents inactiveSearchCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents customerSearchGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents customerSearchGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents customerIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nameGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents reportsBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents customerSearchXPView As DevExpress.Xpo.XPView
    Friend WithEvents relatedCustomersXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents addRelatedCustomerGroupControl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents relatedCustomerLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents addBothWaysSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents addOneWaySimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents relatedCustomersGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents relatedCustomersGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents relatedCustomerXpCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents relatedCustomerNameGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBidirectional As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customersXpView As DevExpress.Xpo.XPView
    Friend WithEvents deleteGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents deleteRepositoryItemButtonEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents idGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lpnGroupControl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents resetLPNSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents plantCodeLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents plantCodeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lastNumberLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lastLPNNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents firsstNumberLabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents firstLPNNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Private WithEvents lpnPrefixlabelControl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lpnPrefixTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Private WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents expirationDateFormatComboBox As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents palletsOnHandGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customerItemsXpCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents locationInventoryGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents locationCodeGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents locationNameGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents quantityOnHandGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents locationsXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents customerPlantsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents customerPlantsGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents customerShiftsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents customerShiftsGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents lotCodeFormatLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lotCodeFormatsXpView As DevExpress.Xpo.XPView
    Friend WithEvents customerPlantsXpCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHasChanges As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlantName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPlantCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents spgLocationsXpView As DevExpress.Xpo.XPView
    Friend WithEvents spgLocationsRepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents deleteCustomerPlantGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents deleteCustomerPlantRepositoryItemButtonEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents customerShiftsXpCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents deleteCustomerShiftGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents deleteCustomerShiftRepositoryItemButtonEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents colOid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHasChanges1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShiftName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShiftCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents spgShiftRepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents spgShiftsXpView As DevExpress.Xpo.XPView
End Class
