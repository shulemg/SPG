<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryXtraForm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If components IsNot Nothing Then
                components.Dispose()
            End If
            If m_InventoryUOW IsNot Nothing Then
                m_InventoryUOW.Dispose()
                m_InventoryUOW = Nothing
            End If
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryXtraForm))
        Me.inventoryGridControl = New DevExpress.XtraGrid.GridControl()
        Me.inventoryXPView = New DevExpress.Xpo.XPView(Me.components)
        Me.inventoryGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.deleteGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.deleteRepositoryItemButtonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.idGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.customerGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dateGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shiftGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.itemGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.descriptionGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.quantityGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.palletsGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.poGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lotGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.palletGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LPNGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.expirationDateGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.expirationDateFormatGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.noteGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.recordGroupControl = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.noteMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.productionDetailsXtraTabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.poolDetailsXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.poolDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.poolDetailsXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.poolDetailsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.itemPoolGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rmItemGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colItemPoolRatio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.itemPoolIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.itemCodeGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.itemQuantityGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.itemQuantityUsedGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rmItemIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.projectDetailsXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.projectDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.productionProjectDetailXpCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.projectDetailsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOid1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHasChanges = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitsProduced = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBagsProduced = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPalletsProduced = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIsOverrun = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomerPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.expirationDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.addLotCodeSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LPNLabelSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.largeLPNSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.palletNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.shiftLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.shiftXPView = New DevExpress.Xpo.XPView(Me.components)
        Me.ShiftLabel = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.onHandTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.lotTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.poTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.cancelSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.editSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.saveSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.descriptionMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.palletsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.quantityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.itemLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.itemsXPView = New DevExpress.Xpo.XPView(Me.components)
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.inventoryDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.poolDetailsXpCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.filtersGroupControl = New DevExpress.XtraEditors.GroupControl()
        Me.filterByPalletSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LPNFilterTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.shiftFilterLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.lotFilterTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.filterSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.clearSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.itemFilterLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.itemsFilterXPView = New DevExpress.Xpo.XPView(Me.components)
        Me.customerFilterLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.customersXPView = New DevExpress.Xpo.XPView(Me.components)
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.toFilterDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.fromFilterDateEdit = New DevExpress.XtraEditors.DateEdit()
        CType(Me.inventoryGridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.inventoryXPView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.inventoryGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.deleteRepositoryItemButtonEdit,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.recordGroupControl,System.ComponentModel.ISupportInitialize).BeginInit
        Me.recordGroupControl.SuspendLayout
        CType(Me.noteMemoEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.productionDetailsXtraTabControl,System.ComponentModel.ISupportInitialize).BeginInit
        Me.productionDetailsXtraTabControl.SuspendLayout
        Me.poolDetailsXtraTabPage.SuspendLayout
        CType(Me.poolDetailsGridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.poolDetailsXpView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.poolDetailsGridView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.projectDetailsXtraTabPage.SuspendLayout
        CType(Me.projectDetailsGridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.productionProjectDetailXpCollection,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.projectDetailsGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.expirationDateEdit.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.expirationDateEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.palletNumberTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.shiftLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.shiftXPView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.onHandTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lotTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.poTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.descriptionMemoEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.palletsTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.quantityTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.itemLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.itemsXPView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.inventoryDateEdit.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.inventoryDateEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.poolDetailsXpCollection,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.filtersGroupControl,System.ComponentModel.ISupportInitialize).BeginInit
        Me.filtersGroupControl.SuspendLayout
        CType(Me.LPNFilterTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.shiftFilterLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.lotFilterTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.itemFilterLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.itemsFilterXPView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.customerFilterLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.customersXPView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.toFilterDateEdit.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.toFilterDateEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.fromFilterDateEdit.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.fromFilterDateEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'inventoryGridControl
        '
        Me.inventoryGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.inventoryGridControl.DataSource = Me.inventoryXPView
        Me.inventoryGridControl.Location = New System.Drawing.Point(12, 335)
        Me.inventoryGridControl.MainView = Me.inventoryGridView
        Me.inventoryGridControl.Name = "inventoryGridControl"
        Me.inventoryGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.deleteRepositoryItemButtonEdit})
        Me.inventoryGridControl.Size = New System.Drawing.Size(1109, 293)
        Me.inventoryGridControl.TabIndex = 27
        Me.inventoryGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.inventoryGridView})
        '
        'inventoryXPView
        '
        Me.inventoryXPView.ObjectType = GetType(DXDAL.SPGData.Inventory)
        Me.inventoryXPView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("InventoryDate", DevExpress.Xpo.SortDirection.None, "[InventoryDate]", false, true), New DevExpress.Xpo.ViewProperty("InventoryID", DevExpress.Xpo.SortDirection.None, "[InventoryID]", false, true), New DevExpress.Xpo.ViewProperty("CustomerName", DevExpress.Xpo.SortDirection.None, "[InventoryItemID.ItemCustomerID.CustomerName]", false, true), New DevExpress.Xpo.ViewProperty("Quantity", DevExpress.Xpo.SortDirection.None, "[InventoryQuantity]", false, true), New DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[InventoryItemID.ItemCode]", false, true), New DevExpress.Xpo.ViewProperty("ItemDescription", DevExpress.Xpo.SortDirection.None, "[InventoryItemID.ItemDescription]", false, true), New DevExpress.Xpo.ViewProperty("Pallets", DevExpress.Xpo.SortDirection.None, "[InventoryPallets]", false, true), New DevExpress.Xpo.ViewProperty("PO", DevExpress.Xpo.SortDirection.None, "[PO]", false, true), New DevExpress.Xpo.ViewProperty("Lot", DevExpress.Xpo.SortDirection.None, "[Lot]", false, true), New DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[InventoryItemID.ItemCustomerID.CustomerID]", false, true), New DevExpress.Xpo.ViewProperty("Shift", DevExpress.Xpo.SortDirection.None, "[Shift.ShiftName]", false, true), New DevExpress.Xpo.ViewProperty("Pallet", DevExpress.Xpo.SortDirection.None, "[Pallet]", false, true), New DevExpress.Xpo.ViewProperty("LPNNumber", DevExpress.Xpo.SortDirection.None, "[LPNNumber]", false, true), New DevExpress.Xpo.ViewProperty("ExpirationDate", DevExpress.Xpo.SortDirection.None, "[ExpirationDate]", false, true), New DevExpress.Xpo.ViewProperty("ExpirationDateFormat", DevExpress.Xpo.SortDirection.None, "[InventoryItemID.ItemCustomerID.ExpirationDateFormat]", false, true), New DevExpress.Xpo.ViewProperty("Note", DevExpress.Xpo.SortDirection.None, "[Note]", false, true)})
        '
        'inventoryGridView
        '
        Me.inventoryGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.deleteGridColumn, Me.idGridColumn, Me.customerGridColumn, Me.dateGridColumn, Me.shiftGridColumn, Me.itemGridColumn, Me.descriptionGridColumn, Me.quantityGridColumn, Me.palletsGridColumn, Me.poGridColumn, Me.lotGridColumn, Me.palletGridColumn, Me.LPNGridColumn, Me.expirationDateGridColumn, Me.expirationDateFormatGridColumn, Me.noteGridColumn})
        Me.inventoryGridView.GridControl = Me.inventoryGridControl
        Me.inventoryGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", Me.quantityGridColumn, "{0:#,###.######}")})
        Me.inventoryGridView.Name = "inventoryGridView"
        '
        'deleteGridColumn
        '
        Me.deleteGridColumn.ColumnEdit = Me.deleteRepositoryItemButtonEdit
        Me.deleteGridColumn.Name = "deleteGridColumn"
        Me.deleteGridColumn.OptionsColumn.AllowSize = false
        Me.deleteGridColumn.OptionsColumn.FixedWidth = true
        Me.deleteGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "")})
        Me.deleteGridColumn.Visible = true
        Me.deleteGridColumn.VisibleIndex = 0
        Me.deleteGridColumn.Width = 22
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
        Me.idGridColumn.FieldName = "InventoryID"
        Me.idGridColumn.Name = "idGridColumn"
        '
        'customerGridColumn
        '
        Me.customerGridColumn.Caption = "Customer Name"
        Me.customerGridColumn.FieldName = "CustomerName"
        Me.customerGridColumn.Name = "customerGridColumn"
        Me.customerGridColumn.OptionsColumn.AllowEdit = false
        Me.customerGridColumn.OptionsColumn.ReadOnly = true
        Me.customerGridColumn.Visible = true
        Me.customerGridColumn.VisibleIndex = 1
        Me.customerGridColumn.Width = 105
        '
        'dateGridColumn
        '
        Me.dateGridColumn.Caption = "Date"
        Me.dateGridColumn.DisplayFormat.FormatString = "g"
        Me.dateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dateGridColumn.FieldName = "InventoryDate"
        Me.dateGridColumn.Name = "dateGridColumn"
        Me.dateGridColumn.OptionsColumn.AllowEdit = False
        Me.dateGridColumn.OptionsColumn.ReadOnly = True
        Me.dateGridColumn.Visible = True
        Me.dateGridColumn.VisibleIndex = 2
        Me.dateGridColumn.Width = 105
        '
        'shiftGridColumn
        '
        Me.shiftGridColumn.Caption = "Shift"
        Me.shiftGridColumn.FieldName = "Shift"
        Me.shiftGridColumn.Name = "shiftGridColumn"
        Me.shiftGridColumn.OptionsColumn.AllowEdit = False
        Me.shiftGridColumn.OptionsColumn.ReadOnly = True
        Me.shiftGridColumn.Visible = True
        Me.shiftGridColumn.VisibleIndex = 4
        '
        'itemGridColumn
        '
        Me.itemGridColumn.Caption = "Item #"
        Me.itemGridColumn.FieldName = "ItemCode"
        Me.itemGridColumn.Name = "itemGridColumn"
        Me.itemGridColumn.OptionsColumn.AllowEdit = False
        Me.itemGridColumn.OptionsColumn.ReadOnly = True
        Me.itemGridColumn.Visible = True
        Me.itemGridColumn.VisibleIndex = 3
        Me.itemGridColumn.Width = 100
        '
        'descriptionGridColumn
        '
        Me.descriptionGridColumn.Caption = "Item Description"
        Me.descriptionGridColumn.FieldName = "ItemDescription"
        Me.descriptionGridColumn.Name = "descriptionGridColumn"
        Me.descriptionGridColumn.OptionsColumn.AllowEdit = False
        Me.descriptionGridColumn.OptionsColumn.ReadOnly = True
        Me.descriptionGridColumn.Visible = True
        Me.descriptionGridColumn.VisibleIndex = 5
        Me.descriptionGridColumn.Width = 190
        '
        'quantityGridColumn
        '
        Me.quantityGridColumn.Caption = "Quantity"
        Me.quantityGridColumn.FieldName = "Quantity"
        Me.quantityGridColumn.Name = "quantityGridColumn"
        Me.quantityGridColumn.OptionsColumn.AllowEdit = False
        Me.quantityGridColumn.OptionsColumn.FixedWidth = True
        Me.quantityGridColumn.OptionsColumn.ReadOnly = True
        Me.quantityGridColumn.Visible = True
        Me.quantityGridColumn.VisibleIndex = 6
        Me.quantityGridColumn.Width = 60
        '
        'palletsGridColumn
        '
        Me.palletsGridColumn.Caption = "Pallets"
        Me.palletsGridColumn.FieldName = "Pallets"
        Me.palletsGridColumn.Name = "palletsGridColumn"
        Me.palletsGridColumn.OptionsColumn.AllowEdit = False
        Me.palletsGridColumn.OptionsColumn.FixedWidth = True
        Me.palletsGridColumn.OptionsColumn.ReadOnly = True
        Me.palletsGridColumn.Visible = True
        Me.palletsGridColumn.VisibleIndex = 7
        Me.palletsGridColumn.Width = 60
        '
        'poGridColumn
        '
        Me.poGridColumn.Caption = "PO #"
        Me.poGridColumn.FieldName = "PO"
        Me.poGridColumn.Name = "poGridColumn"
        Me.poGridColumn.Visible = True
        Me.poGridColumn.VisibleIndex = 8
        '
        'lotGridColumn
        '
        Me.lotGridColumn.Caption = "Lot #"
        Me.lotGridColumn.FieldName = "Lot"
        Me.lotGridColumn.Name = "lotGridColumn"
        Me.lotGridColumn.Visible = True
        Me.lotGridColumn.VisibleIndex = 9
        '
        'palletGridColumn
        '
        Me.palletGridColumn.Caption = "Pallet"
        Me.palletGridColumn.FieldName = "Pallet"
        Me.palletGridColumn.Name = "palletGridColumn"
        Me.palletGridColumn.OptionsColumn.AllowEdit = False
        Me.palletGridColumn.OptionsColumn.ReadOnly = True
        Me.palletGridColumn.Visible = True
        Me.palletGridColumn.VisibleIndex = 11
        '
        'LPNGridColumn
        '
        Me.LPNGridColumn.Caption = "LPN Number"
        Me.LPNGridColumn.FieldName = "LPNNumber"
        Me.LPNGridColumn.Name = "LPNGridColumn"
        Me.LPNGridColumn.OptionsColumn.AllowEdit = False
        Me.LPNGridColumn.OptionsColumn.ReadOnly = True
        Me.LPNGridColumn.Visible = True
        Me.LPNGridColumn.VisibleIndex = 12
        '
        'expirationDateGridColumn
        '
        Me.expirationDateGridColumn.Caption = "Expiration Date"
        Me.expirationDateGridColumn.DisplayFormat.FormatString = "d"
        Me.expirationDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.expirationDateGridColumn.FieldName = "ExpirationDate"
        Me.expirationDateGridColumn.Name = "expirationDateGridColumn"
        Me.expirationDateGridColumn.OptionsColumn.AllowEdit = False
        Me.expirationDateGridColumn.OptionsColumn.ReadOnly = True
        Me.expirationDateGridColumn.Visible = True
        Me.expirationDateGridColumn.VisibleIndex = 10
        '
        'expirationDateFormatGridColumn
        '
        Me.expirationDateFormatGridColumn.Caption = "GridColumn1"
        Me.expirationDateFormatGridColumn.FieldName = "ExpirationDateFormat"
        Me.expirationDateFormatGridColumn.Name = "expirationDateFormatGridColumn"
        Me.expirationDateFormatGridColumn.OptionsColumn.AllowEdit = False
        Me.expirationDateFormatGridColumn.OptionsColumn.AllowShowHide = False
        Me.expirationDateFormatGridColumn.OptionsColumn.ReadOnly = True
        Me.expirationDateFormatGridColumn.OptionsColumn.ShowInCustomizationForm = False
        '
        'noteGridColumn
        '
        Me.noteGridColumn.Caption = "Note"
        Me.noteGridColumn.FieldName = "Note"
        Me.noteGridColumn.Name = "noteGridColumn"
        Me.noteGridColumn.OptionsColumn.ReadOnly = True
        Me.noteGridColumn.Visible = True
        Me.noteGridColumn.VisibleIndex = 13
        '
        'recordGroupControl
        '
        Me.recordGroupControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.recordGroupControl.Controls.Add(Me.LabelControl18)
        Me.recordGroupControl.Controls.Add(Me.noteMemoEdit)
        Me.recordGroupControl.Controls.Add(Me.productionDetailsXtraTabControl)
        Me.recordGroupControl.Controls.Add(Me.LabelControl16)
        Me.recordGroupControl.Controls.Add(Me.expirationDateEdit)
        Me.recordGroupControl.Controls.Add(Me.addLotCodeSimpleButton)
        Me.recordGroupControl.Controls.Add(Me.LPNLabelSimpleButton)
        Me.recordGroupControl.Controls.Add(Me.largeLPNSimpleButton)
        Me.recordGroupControl.Controls.Add(Me.LabelControl14)
        Me.recordGroupControl.Controls.Add(Me.palletNumberTextEdit)
        Me.recordGroupControl.Controls.Add(Me.shiftLookUpEdit)
        Me.recordGroupControl.Controls.Add(Me.ShiftLabel)
        Me.recordGroupControl.Controls.Add(Me.LabelControl13)
        Me.recordGroupControl.Controls.Add(Me.onHandTextEdit)
        Me.recordGroupControl.Controls.Add(Me.lotTextEdit)
        Me.recordGroupControl.Controls.Add(Me.LabelControl11)
        Me.recordGroupControl.Controls.Add(Me.LabelControl10)
        Me.recordGroupControl.Controls.Add(Me.poTextEdit)
        Me.recordGroupControl.Controls.Add(Me.cancelSimpleButton)
        Me.recordGroupControl.Controls.Add(Me.editSimpleButton)
        Me.recordGroupControl.Controls.Add(Me.saveSimpleButton)
        Me.recordGroupControl.Controls.Add(Me.descriptionMemoEdit)
        Me.recordGroupControl.Controls.Add(Me.LabelControl5)
        Me.recordGroupControl.Controls.Add(Me.LabelControl4)
        Me.recordGroupControl.Controls.Add(Me.palletsTextEdit)
        Me.recordGroupControl.Controls.Add(Me.quantityTextEdit)
        Me.recordGroupControl.Controls.Add(Me.LabelControl3)
        Me.recordGroupControl.Controls.Add(Me.LabelControl2)
        Me.recordGroupControl.Controls.Add(Me.itemLookUpEdit)
        Me.recordGroupControl.Controls.Add(Me.LabelControl1)
        Me.recordGroupControl.Controls.Add(Me.inventoryDateEdit)
        Me.recordGroupControl.Location = New System.Drawing.Point(12, 12)
        Me.recordGroupControl.Name = "recordGroupControl"
        Me.recordGroupControl.ShowCaption = False
        Me.recordGroupControl.Size = New System.Drawing.Size(1109, 201)
        Me.recordGroupControl.TabIndex = 0
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(431, 95)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl18.TabIndex = 30
        Me.LabelControl18.Text = "Note:"
        '
        'noteMemoEdit
        '
        Me.noteMemoEdit.Location = New System.Drawing.Point(431, 114)
        Me.noteMemoEdit.Name = "noteMemoEdit"
        Me.noteMemoEdit.Size = New System.Drawing.Size(315, 49)
        Me.noteMemoEdit.TabIndex = 8
        '
        'productionDetailsXtraTabControl
        '
        Me.productionDetailsXtraTabControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.productionDetailsXtraTabControl.Location = New System.Drawing.Point(752, 6)
        Me.productionDetailsXtraTabControl.Name = "productionDetailsXtraTabControl"
        Me.productionDetailsXtraTabControl.SelectedTabPage = Me.poolDetailsXtraTabPage
        Me.productionDetailsXtraTabControl.Size = New System.Drawing.Size(357, 195)
        Me.productionDetailsXtraTabControl.TabIndex = 28
        Me.productionDetailsXtraTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.poolDetailsXtraTabPage, Me.projectDetailsXtraTabPage})
        '
        'poolDetailsXtraTabPage
        '
        Me.poolDetailsXtraTabPage.Controls.Add(Me.poolDetailsGridControl)
        Me.poolDetailsXtraTabPage.Name = "poolDetailsXtraTabPage"
        Me.poolDetailsXtraTabPage.Size = New System.Drawing.Size(351, 167)
        Me.poolDetailsXtraTabPage.Text = "Pool Details"
        '
        'poolDetailsGridControl
        '
        Me.poolDetailsGridControl.DataMember = Nothing
        Me.poolDetailsGridControl.DataSource = Me.poolDetailsXpView
        Me.poolDetailsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.poolDetailsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.poolDetailsGridControl.MainView = Me.poolDetailsGridView
        Me.poolDetailsGridControl.Name = "poolDetailsGridControl"
        Me.poolDetailsGridControl.Size = New System.Drawing.Size(351, 167)
        Me.poolDetailsGridControl.TabIndex = 28
        Me.poolDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.poolDetailsGridView})
        '
        'poolDetailsXpView
        '
        Me.poolDetailsXpView.ObjectType = GetType(DXDAL.SPGData.ItemPoolDetails)
        Me.poolDetailsXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("Oid", DevExpress.Xpo.SortDirection.None, "[Oid]", False, True), New DevExpress.Xpo.ViewProperty("ItemPool", DevExpress.Xpo.SortDirection.None, "[ItemPoolID.PoolCode]", False, True), New DevExpress.Xpo.ViewProperty("RmItem", DevExpress.Xpo.SortDirection.None, "[ItemID]", False, True), New DevExpress.Xpo.ViewProperty("ItemPoolRatio", DevExpress.Xpo.SortDirection.None, "[ItemPoolRatio]", False, True), New DevExpress.Xpo.ViewProperty("ItemPoolID", DevExpress.Xpo.SortDirection.None, "[ItemPoolID.Oid]", False, True), New DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[ItemID.ItemCode]", False, True), New DevExpress.Xpo.ViewProperty("RMItemID", DevExpress.Xpo.SortDirection.None, "[ItemID.ItemID]", False, True)})
        '
        'poolDetailsGridView
        '
        Me.poolDetailsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.itemPoolGridColumn, Me.rmItemGridColumn, Me.colItemPoolRatio, Me.itemPoolIDGridColumn, Me.itemCodeGridColumn, Me.itemQuantityGridColumn, Me.itemQuantityUsedGridColumn, Me.rmItemIDGridColumn})
        Me.poolDetailsGridView.GridControl = Me.poolDetailsGridControl
        Me.poolDetailsGridView.GroupCount = 1
        Me.poolDetailsGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "itemQuantityUsedGridColumn", Nothing, """Pool Quantity Used = {0:N2}""", "1")})
        Me.poolDetailsGridView.Name = "poolDetailsGridView"
        Me.poolDetailsGridView.OptionsSelection.MultiSelect = True
        Me.poolDetailsGridView.OptionsView.ShowDetailButtons = False
        Me.poolDetailsGridView.OptionsView.ShowGroupPanel = False
        Me.poolDetailsGridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.itemPoolGridColumn, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'colOid
        '
        Me.colOid.FieldName = "Oid"
        Me.colOid.Name = "colOid"
        Me.colOid.OptionsColumn.AllowEdit = False
        Me.colOid.OptionsColumn.ReadOnly = True
        '
        'itemPoolGridColumn
        '
        Me.itemPoolGridColumn.Caption = "Pool Code"
        Me.itemPoolGridColumn.FieldName = "ItemPool"
        Me.itemPoolGridColumn.Name = "itemPoolGridColumn"
        Me.itemPoolGridColumn.OptionsColumn.AllowEdit = False
        Me.itemPoolGridColumn.OptionsColumn.ReadOnly = True
        '
        'rmItemGridColumn
        '
        Me.rmItemGridColumn.FieldName = "RmItem"
        Me.rmItemGridColumn.Name = "rmItemGridColumn"
        Me.rmItemGridColumn.OptionsColumn.AllowEdit = False
        Me.rmItemGridColumn.OptionsColumn.ReadOnly = True
        '
        'colItemPoolRatio
        '
        Me.colItemPoolRatio.FieldName = "ItemPoolRatio"
        Me.colItemPoolRatio.Name = "colItemPoolRatio"
        Me.colItemPoolRatio.OptionsColumn.AllowEdit = False
        Me.colItemPoolRatio.OptionsColumn.ReadOnly = True
        '
        'itemPoolIDGridColumn
        '
        Me.itemPoolIDGridColumn.Caption = "GridColumn1"
        Me.itemPoolIDGridColumn.FieldName = "ItemPoolID"
        Me.itemPoolIDGridColumn.Name = "itemPoolIDGridColumn"
        '
        'itemCodeGridColumn
        '
        Me.itemCodeGridColumn.Caption = "Item Code"
        Me.itemCodeGridColumn.FieldName = "ItemCode"
        Me.itemCodeGridColumn.Name = "itemCodeGridColumn"
        Me.itemCodeGridColumn.OptionsColumn.AllowEdit = False
        Me.itemCodeGridColumn.OptionsColumn.ReadOnly = True
        Me.itemCodeGridColumn.Visible = True
        Me.itemCodeGridColumn.VisibleIndex = 0
        '
        'itemQuantityGridColumn
        '
        Me.itemQuantityGridColumn.Caption = "Item Quantity On Hand"
        Me.itemQuantityGridColumn.FieldName = "ItemQuantity"
        Me.itemQuantityGridColumn.Name = "itemQuantityGridColumn"
        Me.itemQuantityGridColumn.OptionsColumn.AllowEdit = False
        Me.itemQuantityGridColumn.OptionsColumn.ReadOnly = True
        Me.itemQuantityGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.itemQuantityGridColumn.Visible = True
        Me.itemQuantityGridColumn.VisibleIndex = 1
        '
        'itemQuantityUsedGridColumn
        '
        Me.itemQuantityUsedGridColumn.Caption = "Item Quantity Used"
        Me.itemQuantityUsedGridColumn.FieldName = "itemQuantityUsedGridColumn"
        Me.itemQuantityUsedGridColumn.Name = "itemQuantityUsedGridColumn"
        Me.itemQuantityUsedGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.itemQuantityUsedGridColumn.Visible = True
        Me.itemQuantityUsedGridColumn.VisibleIndex = 2
        '
        'rmItemIDGridColumn
        '
        Me.rmItemIDGridColumn.Caption = "GridColumn1"
        Me.rmItemIDGridColumn.FieldName = "RMItemID"
        Me.rmItemIDGridColumn.Name = "rmItemIDGridColumn"
        '
        'projectDetailsXtraTabPage
        '
        Me.projectDetailsXtraTabPage.Controls.Add(Me.projectDetailsGridControl)
        Me.projectDetailsXtraTabPage.Name = "projectDetailsXtraTabPage"
        Me.projectDetailsXtraTabPage.Size = New System.Drawing.Size(351, 167)
        Me.projectDetailsXtraTabPage.Text = "Project Details"
        '
        'projectDetailsGridControl
        '
        Me.projectDetailsGridControl.DataSource = Me.productionProjectDetailXpCollection
        Me.projectDetailsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.projectDetailsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.projectDetailsGridControl.MainView = Me.projectDetailsGridView
        Me.projectDetailsGridControl.Name = "projectDetailsGridControl"
        Me.projectDetailsGridControl.Size = New System.Drawing.Size(351, 167)
        Me.projectDetailsGridControl.TabIndex = 0
        Me.projectDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.projectDetailsGridView})
        '
        'productionProjectDetailXpCollection
        '
        Me.productionProjectDetailXpCollection.DisplayableProperties = "This;Oid;HasChanges;ProjectDetail!;ProjectDetail!Key;ProjectDetail;Production!;Pr" &
    "oduction!Key;Production;UnitsProduced;BagsProduced;PalletsProduced;IsOverrun;Pro" &
    "jectDetail.Project.Project"
        Me.productionProjectDetailXpCollection.ObjectType = GetType(DXDAL.SPGData.ProductionProjectDetails)
        '
        'projectDetailsGridView
        '
        Me.projectDetailsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid1, Me.colHasChanges, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.colUnitsProduced, Me.colBagsProduced, Me.colPalletsProduced, Me.colIsOverrun, Me.colProject, Me.colCustomerPO})
        Me.projectDetailsGridView.GridControl = Me.projectDetailsGridControl
        Me.projectDetailsGridView.Name = "projectDetailsGridView"
        Me.projectDetailsGridView.OptionsView.ShowDetailButtons = False
        Me.projectDetailsGridView.OptionsView.ShowFooter = True
        '
        'colOid1
        '
        Me.colOid1.FieldName = "Oid"
        Me.colOid1.Name = "colOid1"
        Me.colOid1.OptionsColumn.ReadOnly = True
        '
        'colHasChanges
        '
        Me.colHasChanges.FieldName = "HasChanges"
        Me.colHasChanges.Name = "colHasChanges"
        Me.colHasChanges.OptionsColumn.ReadOnly = True
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "ProjectDetail!"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsColumn.ReadOnly = True
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "ProjectDetail!Key"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "Production!"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "Production!Key"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        '
        'colUnitsProduced
        '
        Me.colUnitsProduced.FieldName = "UnitsProduced"
        Me.colUnitsProduced.Name = "colUnitsProduced"
        Me.colUnitsProduced.OptionsColumn.ReadOnly = True
        Me.colUnitsProduced.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colUnitsProduced.Visible = True
        Me.colUnitsProduced.VisibleIndex = 2
        '
        'colBagsProduced
        '
        Me.colBagsProduced.FieldName = "BagsProduced"
        Me.colBagsProduced.Name = "colBagsProduced"
        Me.colBagsProduced.OptionsColumn.ReadOnly = True
        Me.colBagsProduced.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colBagsProduced.Visible = True
        Me.colBagsProduced.VisibleIndex = 3
        '
        'colPalletsProduced
        '
        Me.colPalletsProduced.FieldName = "PalletsProduced"
        Me.colPalletsProduced.Name = "colPalletsProduced"
        Me.colPalletsProduced.OptionsColumn.ReadOnly = True
        Me.colPalletsProduced.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.colPalletsProduced.Visible = True
        Me.colPalletsProduced.VisibleIndex = 4
        '
        'colIsOverrun
        '
        Me.colIsOverrun.FieldName = "IsOverrun"
        Me.colIsOverrun.Name = "colIsOverrun"
        Me.colIsOverrun.OptionsColumn.ReadOnly = True
        Me.colIsOverrun.Visible = True
        Me.colIsOverrun.VisibleIndex = 5
        '
        'colProject
        '
        Me.colProject.Caption = "Project"
        Me.colProject.FieldName = "ProjectDetail.Project.Project"
        Me.colProject.Name = "colProject"
        Me.colProject.OptionsColumn.ReadOnly = True
        Me.colProject.Visible = True
        Me.colProject.VisibleIndex = 0
        '
        'colCustomerPO
        '
        Me.colCustomerPO.CustomizationCaption = "Customer PO"
        Me.colCustomerPO.FieldName = "ProjectDetail.CustomerPO"
        Me.colCustomerPO.Name = "colCustomerPO"
        Me.colCustomerPO.OptionsColumn.AllowEdit = False
        Me.colCustomerPO.OptionsColumn.ReadOnly = True
        Me.colCustomerPO.Visible = True
        Me.colCustomerPO.VisibleIndex = 1
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(111, 95)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl16.TabIndex = 26
        Me.LabelControl16.Text = "Expiration Date:"
        '
        'expirationDateEdit
        '
        Me.expirationDateEdit.EditValue = Nothing
        Me.expirationDateEdit.Location = New System.Drawing.Point(110, 114)
        Me.expirationDateEdit.Name = "expirationDateEdit"
        Me.expirationDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.expirationDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.expirationDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.expirationDateEdit.Properties.DisplayFormat.FormatString = "MMMM dd, yyyy"
        Me.expirationDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.expirationDateEdit.Properties.EditFormat.FormatString = "MMMM dd, yyyy"
        Me.expirationDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.expirationDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.expirationDateEdit.Size = New System.Drawing.Size(150, 20)
        Me.expirationDateEdit.TabIndex = 6
        '
        'addLotCodeSimpleButton
        '
        Me.addLotCodeSimpleButton.Location = New System.Drawing.Point(270, 140)
        Me.addLotCodeSimpleButton.Name = "addLotCodeSimpleButton"
        Me.addLotCodeSimpleButton.Size = New System.Drawing.Size(151, 23)
        Me.addLotCodeSimpleButton.TabIndex = 8
        Me.addLotCodeSimpleButton.Text = "&Add Lot Code"
        '
        'LPNLabelSimpleButton
        '
        Me.LPNLabelSimpleButton.Location = New System.Drawing.Point(50, 169)
        Me.LPNLabelSimpleButton.Name = "LPNLabelSimpleButton"
        Me.LPNLabelSimpleButton.Size = New System.Drawing.Size(131, 23)
        Me.LPNLabelSimpleButton.TabIndex = 12
        Me.LPNLabelSimpleButton.Text = "Save && Print Short &LPN"
        '
        'largeLPNSimpleButton
        '
        Me.largeLPNSimpleButton.Location = New System.Drawing.Point(187, 169)
        Me.largeLPNSimpleButton.Name = "largeLPNSimpleButton"
        Me.largeLPNSimpleButton.Size = New System.Drawing.Size(131, 23)
        Me.largeLPNSimpleButton.TabIndex = 13
        Me.largeLPNSimpleButton.Text = "Save && &Print Large LPN"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(325, 5)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl14.TabIndex = 21
        Me.LabelControl14.Text = "Pallet #:"
        '
        'palletNumberTextEdit
        '
        Me.palletNumberTextEdit.Location = New System.Drawing.Point(324, 24)
        Me.palletNumberTextEdit.Name = "palletNumberTextEdit"
        Me.palletNumberTextEdit.Properties.ReadOnly = True
        Me.palletNumberTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.palletNumberTextEdit.TabIndex = 11
        Me.palletNumberTextEdit.TabStop = False
        '
        'shiftLookUpEdit
        '
        Me.shiftLookUpEdit.Location = New System.Drawing.Point(4, 114)
        Me.shiftLookUpEdit.Name = "shiftLookUpEdit"
        Me.shiftLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.shiftLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.shiftLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ShiftID", "Shift ID", 59, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ShiftName", "Shift Name", 62, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.shiftLookUpEdit.Properties.DataSource = Me.shiftXPView
        Me.shiftLookUpEdit.Properties.DisplayMember = "ShiftName"
        Me.shiftLookUpEdit.Properties.NullText = "[Select A Shift]"
        Me.shiftLookUpEdit.Properties.ValueMember = "ShiftID"
        Me.shiftLookUpEdit.Size = New System.Drawing.Size(100, 20)
        Me.shiftLookUpEdit.TabIndex = 5
        Me.shiftLookUpEdit.ToolTip = "Use Ctrl+Del to clear filter"
        '
        'shiftXPView
        '
        Me.shiftXPView.ObjectType = GetType(DXDAL.SPGData.Shifts)
        Me.shiftXPView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("ShiftID", DevExpress.Xpo.SortDirection.None, "[ShiftID]", False, True), New DevExpress.Xpo.ViewProperty("ShiftName", DevExpress.Xpo.SortDirection.None, "[ShiftName]", False, True)})
        '
        'ShiftLabel
        '
        Me.ShiftLabel.Location = New System.Drawing.Point(4, 94)
        Me.ShiftLabel.Name = "ShiftLabel"
        Me.ShiftLabel.Size = New System.Drawing.Size(26, 13)
        Me.ShiftLabel.TabIndex = 19
        Me.ShiftLabel.Text = "Shift:"
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(325, 50)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl13.TabIndex = 17
        Me.LabelControl13.Text = "On Hand:"
        '
        'onHandTextEdit
        '
        Me.onHandTextEdit.Location = New System.Drawing.Point(324, 69)
        Me.onHandTextEdit.Name = "onHandTextEdit"
        Me.onHandTextEdit.Properties.ReadOnly = True
        Me.onHandTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.onHandTextEdit.TabIndex = 10
        Me.onHandTextEdit.TabStop = False
        '
        'lotTextEdit
        '
        Me.lotTextEdit.Location = New System.Drawing.Point(266, 114)
        Me.lotTextEdit.Name = "lotTextEdit"
        Me.lotTextEdit.Size = New System.Drawing.Size(158, 20)
        Me.lotTextEdit.TabIndex = 7
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(266, 95)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl11.TabIndex = 10
        Me.LabelControl11.Text = "Lot:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(218, 50)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(18, 13)
        Me.LabelControl10.TabIndex = 8
        Me.LabelControl10.Text = "PO:"
        '
        'poTextEdit
        '
        Me.poTextEdit.Location = New System.Drawing.Point(218, 69)
        Me.poTextEdit.Name = "poTextEdit"
        Me.poTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.poTextEdit.TabIndex = 4
        '
        'cancelSimpleButton
        '
        Me.cancelSimpleButton.Location = New System.Drawing.Point(598, 169)
        Me.cancelSimpleButton.Name = "cancelSimpleButton"
        Me.cancelSimpleButton.Size = New System.Drawing.Size(131, 23)
        Me.cancelSimpleButton.TabIndex = 16
        Me.cancelSimpleButton.Text = "Ca&ncel"
        '
        'editSimpleButton
        '
        Me.editSimpleButton.Location = New System.Drawing.Point(461, 169)
        Me.editSimpleButton.Name = "editSimpleButton"
        Me.editSimpleButton.Size = New System.Drawing.Size(131, 23)
        Me.editSimpleButton.TabIndex = 15
        Me.editSimpleButton.Text = "&Edit Entry"
        '
        'saveSimpleButton
        '
        Me.saveSimpleButton.Location = New System.Drawing.Point(324, 169)
        Me.saveSimpleButton.Name = "saveSimpleButton"
        Me.saveSimpleButton.Size = New System.Drawing.Size(131, 23)
        Me.saveSimpleButton.TabIndex = 14
        Me.saveSimpleButton.Text = "&Save Entry"
        '
        'descriptionMemoEdit
        '
        Me.descriptionMemoEdit.Location = New System.Drawing.Point(431, 24)
        Me.descriptionMemoEdit.Name = "descriptionMemoEdit"
        Me.descriptionMemoEdit.Size = New System.Drawing.Size(315, 65)
        Me.descriptionMemoEdit.TabIndex = 9
        Me.descriptionMemoEdit.TabStop = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(431, 5)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl5.TabIndex = 12
        Me.LabelControl5.Text = "Item Description:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(5, 50)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "Quantity:"
        '
        'palletsTextEdit
        '
        Me.palletsTextEdit.Location = New System.Drawing.Point(110, 69)
        Me.palletsTextEdit.Name = "palletsTextEdit"
        Me.palletsTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.palletsTextEdit.TabIndex = 3
        '
        'quantityTextEdit
        '
        Me.quantityTextEdit.Location = New System.Drawing.Point(4, 69)
        Me.quantityTextEdit.Name = "quantityTextEdit"
        Me.quantityTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.quantityTextEdit.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(161, 5)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Item #:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(5, 5)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Date:"
        '
        'itemLookUpEdit
        '
        Me.itemLookUpEdit.Location = New System.Drawing.Point(161, 24)
        Me.itemLookUpEdit.Name = "itemLookUpEdit"
        Me.itemLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.itemLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 59, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCustomerID", "Item Customer ID", 95, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.itemLookUpEdit.Properties.DataSource = Me.itemsXPView
        Me.itemLookUpEdit.Properties.DisplayMember = "ItemCode"
        Me.itemLookUpEdit.Properties.NullText = "[Select A Item]"
        Me.itemLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.itemLookUpEdit.Properties.ValueMember = "ItemID"
        Me.itemLookUpEdit.Size = New System.Drawing.Size(157, 20)
        Me.itemLookUpEdit.TabIndex = 1
        '
        'itemsXPView
        '
        Me.itemsXPView.CriteriaString = "([ItemType] = 'FG' Or [ItemType] = 'IG') And [Inactive] = False"
        Me.itemsXPView.ObjectType = GetType(DXDAL.SPGData.Items)
        Me.itemsXPView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[ItemID]", False, True), New DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.Ascending, "[ItemCode]", False, True), New DevExpress.Xpo.ViewProperty("ItemCustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID]", False, True)})
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(111, 50)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Pallets:"
        '
        'inventoryDateEdit
        '
        Me.inventoryDateEdit.EditValue = Nothing
        Me.inventoryDateEdit.Location = New System.Drawing.Point(5, 24)
        Me.inventoryDateEdit.Name = "inventoryDateEdit"
        Me.inventoryDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.inventoryDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.inventoryDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.inventoryDateEdit.Properties.DisplayFormat.FormatString = "g"
        Me.inventoryDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.inventoryDateEdit.Properties.EditFormat.FormatString = "g"
        Me.inventoryDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.inventoryDateEdit.Properties.Mask.EditMask = "g"
        Me.inventoryDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.inventoryDateEdit.Size = New System.Drawing.Size(150, 20)
        Me.inventoryDateEdit.TabIndex = 0
        '
        'poolDetailsXpCollection
        '
        Me.poolDetailsXpCollection.DisplayableProperties = "This;Oid;ItemPoolID!;ItemPoolID!Key;ItemPoolID;PoolBomFiniGoodID!;PoolBomFiniGood" &
    "ID!Key;PoolBomFiniGoodID;PoolBomQuantity;ScrapFactor;ItemPoolID.Details.ItemID.I" &
    "temCode"
        Me.poolDetailsXpCollection.ObjectType = GetType(DXDAL.SPGData.PoolBom)
        '
        'filtersGroupControl
        '
        Me.filtersGroupControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filtersGroupControl.Controls.Add(Me.filterByPalletSimpleButton)
        Me.filtersGroupControl.Controls.Add(Me.LabelControl15)
        Me.filtersGroupControl.Controls.Add(Me.LPNFilterTextEdit)
        Me.filtersGroupControl.Controls.Add(Me.LabelControl17)
        Me.filtersGroupControl.Controls.Add(Me.shiftFilterLookUpEdit)
        Me.filtersGroupControl.Controls.Add(Me.LabelControl12)
        Me.filtersGroupControl.Controls.Add(Me.lotFilterTextEdit)
        Me.filtersGroupControl.Controls.Add(Me.filterSimpleButton)
        Me.filtersGroupControl.Controls.Add(Me.clearSimpleButton)
        Me.filtersGroupControl.Controls.Add(Me.itemFilterLookUpEdit)
        Me.filtersGroupControl.Controls.Add(Me.customerFilterLookUpEdit)
        Me.filtersGroupControl.Controls.Add(Me.LabelControl9)
        Me.filtersGroupControl.Controls.Add(Me.LabelControl8)
        Me.filtersGroupControl.Controls.Add(Me.LabelControl7)
        Me.filtersGroupControl.Controls.Add(Me.LabelControl6)
        Me.filtersGroupControl.Controls.Add(Me.toFilterDateEdit)
        Me.filtersGroupControl.Controls.Add(Me.fromFilterDateEdit)
        Me.filtersGroupControl.Location = New System.Drawing.Point(12, 219)
        Me.filtersGroupControl.Name = "filtersGroupControl"
        Me.filtersGroupControl.Size = New System.Drawing.Size(1109, 110)
        Me.filtersGroupControl.TabIndex = 0
        Me.filtersGroupControl.Text = "Filters and Display"
        '
        'filterByPalletSimpleButton
        '
        Me.filterByPalletSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.filterByPalletSimpleButton.Location = New System.Drawing.Point(611, 82)
        Me.filterByPalletSimpleButton.Name = "filterByPalletSimpleButton"
        Me.filterByPalletSimpleButton.Size = New System.Drawing.Size(102, 23)
        Me.filterByPalletSimpleButton.TabIndex = 26
        Me.filterByPalletSimpleButton.Text = "Filter By &Pallet"
        '
        'LabelControl15
        '
        Me.LabelControl15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl15.Location = New System.Drawing.Point(816, 37)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl15.TabIndex = 15
        Me.LabelControl15.Text = "LPN Number:"
        '
        'LPNFilterTextEdit
        '
        Me.LPNFilterTextEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LPNFilterTextEdit.Location = New System.Drawing.Point(816, 56)
        Me.LPNFilterTextEdit.Name = "LPNFilterTextEdit"
        Me.LPNFilterTextEdit.Size = New System.Drawing.Size(109, 20)
        Me.LPNFilterTextEdit.TabIndex = 24
        '
        'LabelControl17
        '
        Me.LabelControl17.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl17.Location = New System.Drawing.Point(619, 37)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl17.TabIndex = 12
        Me.LabelControl17.Text = "Shift:"
        '
        'shiftFilterLookUpEdit
        '
        Me.shiftFilterLookUpEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.shiftFilterLookUpEdit.Location = New System.Drawing.Point(651, 30)
        Me.shiftFilterLookUpEdit.Name = "shiftFilterLookUpEdit"
        Me.shiftFilterLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.shiftFilterLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.shiftFilterLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ShiftID", "Shift ID", 59, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ShiftName", "Shift Name", 62, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.shiftFilterLookUpEdit.Properties.DataSource = Me.shiftXPView
        Me.shiftFilterLookUpEdit.Properties.DisplayMember = "ShiftName"
        Me.shiftFilterLookUpEdit.Properties.NullText = "[Select A Shift]"
        Me.shiftFilterLookUpEdit.Properties.ValueMember = "ShiftID"
        Me.shiftFilterLookUpEdit.Size = New System.Drawing.Size(159, 20)
        Me.shiftFilterLookUpEdit.TabIndex = 20
        Me.shiftFilterLookUpEdit.ToolTip = "Use Ctrl+Del to clear filter"
        '
        'LabelControl12
        '
        Me.LabelControl12.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl12.Location = New System.Drawing.Point(619, 59)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl12.TabIndex = 8
        Me.LabelControl12.Text = "Lot:"
        '
        'lotFilterTextEdit
        '
        Me.lotFilterTextEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lotFilterTextEdit.Location = New System.Drawing.Point(651, 56)
        Me.lotFilterTextEdit.Name = "lotFilterTextEdit"
        Me.lotFilterTextEdit.Size = New System.Drawing.Size(159, 20)
        Me.lotFilterTextEdit.TabIndex = 22
        '
        'filterSimpleButton
        '
        Me.filterSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.filterSimpleButton.Location = New System.Drawing.Point(503, 82)
        Me.filterSimpleButton.Name = "filterSimpleButton"
        Me.filterSimpleButton.Size = New System.Drawing.Size(102, 23)
        Me.filterSimpleButton.TabIndex = 25
        Me.filterSimpleButton.Text = "&Filter"
        '
        'clearSimpleButton
        '
        Me.clearSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.clearSimpleButton.Location = New System.Drawing.Point(395, 82)
        Me.clearSimpleButton.Name = "clearSimpleButton"
        Me.clearSimpleButton.Size = New System.Drawing.Size(102, 23)
        Me.clearSimpleButton.TabIndex = 23
        Me.clearSimpleButton.Text = "&Clear Filter"
        '
        'itemFilterLookUpEdit
        '
        Me.itemFilterLookUpEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.itemFilterLookUpEdit.Location = New System.Drawing.Point(454, 56)
        Me.itemFilterLookUpEdit.Name = "itemFilterLookUpEdit"
        Me.itemFilterLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.itemFilterLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.itemFilterLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 59, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCustomerID", "Item Customer ID", 95, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.itemFilterLookUpEdit.Properties.DataSource = Me.itemsFilterXPView
        Me.itemFilterLookUpEdit.Properties.DisplayMember = "ItemCode"
        Me.itemFilterLookUpEdit.Properties.NullText = "[Select A Item]"
        Me.itemFilterLookUpEdit.Properties.ValueMember = "ItemID"
        Me.itemFilterLookUpEdit.Size = New System.Drawing.Size(152, 20)
        Me.itemFilterLookUpEdit.TabIndex = 21
        Me.itemFilterLookUpEdit.ToolTip = "Use Ctrl+Del to clear filter"
        '
        'itemsFilterXPView
        '
        Me.itemsFilterXPView.CriteriaString = "[ItemType] = 'FG' Or [ItemType] = 'IG'"
        Me.itemsFilterXPView.ObjectType = GetType(DXDAL.SPGData.Items)
        Me.itemsFilterXPView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[ItemID]", False, True), New DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.Ascending, "[ItemCode]", False, True), New DevExpress.Xpo.ViewProperty("ItemCustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID]", False, True), New DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID.CustomerID]", False, True)})
        '
        'customerFilterLookUpEdit
        '
        Me.customerFilterLookUpEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.customerFilterLookUpEdit.Location = New System.Drawing.Point(240, 56)
        Me.customerFilterLookUpEdit.Name = "customerFilterLookUpEdit"
        Me.customerFilterLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.customerFilterLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.customerFilterLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerID", "Customer ID", 83, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Customer Name", 86, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Inactive", "Inactive", 49, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near)})
        Me.customerFilterLookUpEdit.Properties.DataSource = Me.customersXPView
        Me.customerFilterLookUpEdit.Properties.DisplayMember = "CustomerName"
        Me.customerFilterLookUpEdit.Properties.NullText = "[Select A Customer]"
        Me.customerFilterLookUpEdit.Properties.ValueMember = "CustomerID"
        Me.customerFilterLookUpEdit.Size = New System.Drawing.Size(160, 20)
        Me.customerFilterLookUpEdit.TabIndex = 19
        Me.customerFilterLookUpEdit.ToolTip = "Use Ctrl+Del to clear filter"
        '
        'customersXPView
        '
        Me.customersXPView.CriteriaString = "[Inactive] = False"
        Me.customersXPView.ObjectType = GetType(DXDAL.SPGData.Customers)
        Me.customersXPView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[CustomerID]", False, True), New DevExpress.Xpo.ViewProperty("CustomerName", DevExpress.Xpo.SortDirection.Ascending, "[CustomerName]", False, True), New DevExpress.Xpo.ViewProperty("Inactive", DevExpress.Xpo.SortDirection.None, "[Inactive]", False, True)})
        '
        'LabelControl9
        '
        Me.LabelControl9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl9.Location = New System.Drawing.Point(422, 59)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl9.TabIndex = 6
        Me.LabelControl9.Text = "Item:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl8.Location = New System.Drawing.Point(422, 33)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(16, 13)
        Me.LabelControl8.TabIndex = 2
        Me.LabelControl8.Text = "To:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl7.Location = New System.Drawing.Point(184, 59)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl7.TabIndex = 4
        Me.LabelControl7.Text = "Customer:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelControl6.Location = New System.Drawing.Point(184, 33)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "From:"
        '
        'toFilterDateEdit
        '
        Me.toFilterDateEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.toFilterDateEdit.EditValue = Nothing
        Me.toFilterDateEdit.Location = New System.Drawing.Point(454, 30)
        Me.toFilterDateEdit.Name = "toFilterDateEdit"
        Me.toFilterDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.toFilterDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.toFilterDateEdit.Properties.DisplayFormat.FormatString = "D"
        Me.toFilterDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.toFilterDateEdit.Properties.EditFormat.FormatString = "D"
        Me.toFilterDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.toFilterDateEdit.Properties.Mask.EditMask = "g"
        Me.toFilterDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.toFilterDateEdit.Properties.NullText = "[Select A To Date]"
        Me.toFilterDateEdit.Size = New System.Drawing.Size(152, 20)
        Me.toFilterDateEdit.TabIndex = 18
        '
        'fromFilterDateEdit
        '
        Me.fromFilterDateEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.fromFilterDateEdit.EditValue = Nothing
        Me.fromFilterDateEdit.Location = New System.Drawing.Point(240, 30)
        Me.fromFilterDateEdit.Name = "fromFilterDateEdit"
        Me.fromFilterDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fromFilterDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.fromFilterDateEdit.Properties.DisplayFormat.FormatString = "D"
        Me.fromFilterDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fromFilterDateEdit.Properties.EditFormat.FormatString = "D"
        Me.fromFilterDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fromFilterDateEdit.Properties.Mask.EditMask = "g"
        Me.fromFilterDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.fromFilterDateEdit.Properties.NullText = "[Select A From Date]"
        Me.fromFilterDateEdit.Size = New System.Drawing.Size(160, 20)
        Me.fromFilterDateEdit.TabIndex = 17
        '
        'InventoryXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1133, 640)
        Me.Controls.Add(Me.inventoryGridControl)
        Me.Controls.Add(Me.filtersGroupControl)
        Me.Controls.Add(Me.recordGroupControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "InventoryXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Production Entries"
        CType(Me.inventoryGridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.inventoryXPView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.inventoryGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.deleteRepositoryItemButtonEdit,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.recordGroupControl,System.ComponentModel.ISupportInitialize).EndInit
        Me.recordGroupControl.ResumeLayout(false)
        Me.recordGroupControl.PerformLayout
        CType(Me.noteMemoEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.productionDetailsXtraTabControl,System.ComponentModel.ISupportInitialize).EndInit
        Me.productionDetailsXtraTabControl.ResumeLayout(false)
        Me.poolDetailsXtraTabPage.ResumeLayout(false)
        CType(Me.poolDetailsGridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.poolDetailsXpView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.poolDetailsGridView,System.ComponentModel.ISupportInitialize).EndInit
        Me.projectDetailsXtraTabPage.ResumeLayout(false)
        CType(Me.projectDetailsGridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.productionProjectDetailXpCollection,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.projectDetailsGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.expirationDateEdit.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.expirationDateEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.palletNumberTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.shiftLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.shiftXPView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.onHandTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lotTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.poTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.descriptionMemoEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.palletsTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.quantityTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.itemLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.itemsXPView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.inventoryDateEdit.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.inventoryDateEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.poolDetailsXpCollection,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.filtersGroupControl,System.ComponentModel.ISupportInitialize).EndInit
        Me.filtersGroupControl.ResumeLayout(false)
        Me.filtersGroupControl.PerformLayout
        CType(Me.LPNFilterTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.shiftFilterLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.lotFilterTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.itemFilterLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.itemsFilterXPView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.customerFilterLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.customersXPView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.toFilterDateEdit.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.toFilterDateEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.fromFilterDateEdit.Properties.CalendarTimeProperties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.fromFilterDateEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents recordGroupControl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents filtersGroupControl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cancelSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents editSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents saveSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents descriptionMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents palletsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents quantityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents itemLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents inventoryDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents filterSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents clearSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents itemFilterLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents customerFilterLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents toFilterDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents fromFilterDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents inventoryGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents inventoryGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents deleteGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents deleteRepositoryItemButtonEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents idGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customerGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dateGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents itemGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents descriptionGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents quantityGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents palletsGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents poTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents poGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lotGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lotTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lotFilterTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents inventoryXPView As DevExpress.Xpo.XPView
    Friend WithEvents itemsXPView As DevExpress.Xpo.XPView
    Friend WithEvents itemsFilterXPView As DevExpress.Xpo.XPView
    Friend WithEvents customersXPView As DevExpress.Xpo.XPView
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents onHandTextEdit As DevExpress.XtraEditors.TextEdit
    Private WithEvents ShiftLabel As DevExpress.XtraEditors.LabelControl
    Friend WithEvents shiftLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents shiftFilterLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents shiftXPView As DevExpress.Xpo.XPView
    Friend WithEvents shiftGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents palletNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents palletGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents largeLPNSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LPNLabelSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents addLotCodeSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LPNFilterTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LPNGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents filterByPalletSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents expirationDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents expirationDateGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents expirationDateFormatGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents poolDetailsXpCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents poolDetailsXpView As DevExpress.Xpo.XPView
    Friend WithEvents productionDetailsXtraTabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents poolDetailsXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents poolDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents poolDetailsGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents itemPoolGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rmItemGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colItemPoolRatio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents itemPoolIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents itemCodeGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents itemQuantityGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents itemQuantityUsedGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rmItemIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents projectDetailsXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents projectDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents productionProjectDetailXpCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents projectDetailsGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOid1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHasChanges As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitsProduced As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBagsProduced As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPalletsProduced As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIsOverrun As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomerPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents noteMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents noteGridColumn As DevExpress.XtraGrid.Columns.GridColumn
End Class
