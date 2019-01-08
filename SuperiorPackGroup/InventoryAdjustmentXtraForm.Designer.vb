<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryAdjustmentXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryAdjustmentXtraForm))
        Me.adjustmentGridControl = New DevExpress.XtraGrid.GridControl()
        Me.inventoryXPView = New DevExpress.Xpo.XPView(Me.components)
        Me.adjustmentGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.deleteGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.deleteRepositoryItemButtonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.idGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.customerGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dateGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.itemGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.descriptionGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLPN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.locationCodeGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.originalQuantityGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.newQtyGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOriginalLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNewLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.adjustmentGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.reasonGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.reasonRepositoryItemMemoExEdit = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.itemIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.customerIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.locationGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.filtersGroupControl = New DevExpress.XtraEditors.GroupControl()
        Me.filterSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.clearSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.itemFilterLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.itemsFilterXPView = New DevExpress.Xpo.XPView(Me.components)
        Me.customerFilterLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.customersFilterXPView = New DevExpress.Xpo.XPView(Me.components)
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.toFilterDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.fromFilterDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.recordGroupControl = New DevExpress.XtraEditors.GroupControl()
        Me.AddLpnSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.locationLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.locationsXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.newLotTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.lpnLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.lpnXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.reasonMemoExEdit = New DevExpress.XtraEditors.MemoExEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.newQtyTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.originalQtyTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.customerLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.customersXPView = New DevExpress.Xpo.XPView(Me.components)
        Me.cancelSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.editSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.saveSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.descriptionMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.itemLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.itemsXPView = New DevExpress.Xpo.XPView(Me.components)
        Me.adjustmentDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.originalLotLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.LotXpView = New DevExpress.Xpo.XPView(Me.components)
        CType(Me.adjustmentGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inventoryXPView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.adjustmentGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deleteRepositoryItemButtonEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reasonRepositoryItemMemoExEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.filtersGroupControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.filtersGroupControl.SuspendLayout()
        CType(Me.itemFilterLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemsFilterXPView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.customerFilterLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.customersFilterXPView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.toFilterDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.toFilterDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fromFilterDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fromFilterDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.recordGroupControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.recordGroupControl.SuspendLayout()
        CType(Me.locationLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.locationsXpView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.newLotTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lpnLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lpnXpView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reasonMemoExEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.newQtyTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.originalQtyTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.customerLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.customersXPView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.descriptionMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemsXPView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.adjustmentDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.adjustmentDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.originalLotLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LotXpView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'adjustmentGridControl
        '
        Me.adjustmentGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.adjustmentGridControl.DataSource = Me.inventoryXPView
        Me.adjustmentGridControl.Location = New System.Drawing.Point(13, 291)
        Me.adjustmentGridControl.MainView = Me.adjustmentGridView
        Me.adjustmentGridControl.Name = "adjustmentGridControl"
        Me.adjustmentGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.deleteRepositoryItemButtonEdit, Me.reasonRepositoryItemMemoExEdit})
        Me.adjustmentGridControl.Size = New System.Drawing.Size(768, 276)
        Me.adjustmentGridControl.TabIndex = 4
        Me.adjustmentGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.adjustmentGridView})
        '
        'inventoryXPView
        '
        Me.inventoryXPView.ObjectType = GetType(DXDAL.SPGData.InventoryAdjustment)
        Me.inventoryXPView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("AdjustmentDate", DevExpress.Xpo.SortDirection.None, "[AdjustmentDate]", False, True), New DevExpress.Xpo.ViewProperty("AdjustmentID", DevExpress.Xpo.SortDirection.None, "[AdjustmentID]", False, True), New DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[AdjustmentItem.ItemCode]", False, True), New DevExpress.Xpo.ViewProperty("ItemDescription", DevExpress.Xpo.SortDirection.None, "[AdjustmentItem.ItemDescription]", False, True), New DevExpress.Xpo.ViewProperty("OriginalQuantity", DevExpress.Xpo.SortDirection.None, "[OriginalQuantity]", False, True), New DevExpress.Xpo.ViewProperty("NewCount", DevExpress.Xpo.SortDirection.None, "[NewCount]", False, True), New DevExpress.Xpo.ViewProperty("OriginalLot", DevExpress.Xpo.SortDirection.None, "[OriginalLot]", False, True), New DevExpress.Xpo.ViewProperty("NewLot", DevExpress.Xpo.SortDirection.None, "[NewLot]", False, True), New DevExpress.Xpo.ViewProperty("LPN", DevExpress.Xpo.SortDirection.None, "[LPN]", False, True), New DevExpress.Xpo.ViewProperty("Reason", DevExpress.Xpo.SortDirection.None, "[Reason]", False, True), New DevExpress.Xpo.ViewProperty("CustomerName", DevExpress.Xpo.SortDirection.None, "[Customer.CustomerName]", False, True), New DevExpress.Xpo.ViewProperty("InventoryLocation", DevExpress.Xpo.SortDirection.None, "[InventoryLocation.LocationCode]", False, True), New DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[AdjustmentItem.ItemID]", False, True), New DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[AdjustmentItem.ItemCustomerID.CustomerID]", False, True), New DevExpress.Xpo.ViewProperty("LocationID", DevExpress.Xpo.SortDirection.None, "[InventoryLocation.Oid]", False, True)})
        '
        'adjustmentGridView
        '
        Me.adjustmentGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.deleteGridColumn, Me.idGridColumn, Me.customerGridColumn, Me.dateGridColumn, Me.itemGridColumn, Me.descriptionGridColumn, Me.colLPN, Me.locationCodeGridColumn, Me.originalQuantityGridColumn, Me.newQtyGridColumn, Me.colOriginalLot, Me.colNewLot, Me.adjustmentGridColumn, Me.reasonGridColumn, Me.itemIDGridColumn, Me.customerIDGridColumn, Me.locationGridColumn})
        Me.adjustmentGridView.GridControl = Me.adjustmentGridControl
        Me.adjustmentGridView.Name = "adjustmentGridView"
        '
        'deleteGridColumn
        '
        Me.deleteGridColumn.ColumnEdit = Me.deleteRepositoryItemButtonEdit
        Me.deleteGridColumn.Name = "deleteGridColumn"
        Me.deleteGridColumn.OptionsColumn.AllowSize = False
        Me.deleteGridColumn.OptionsColumn.FixedWidth = True
        Me.deleteGridColumn.Visible = True
        Me.deleteGridColumn.VisibleIndex = 0
        Me.deleteGridColumn.Width = 22
        '
        'deleteRepositoryItemButtonEdit
        '
        Me.deleteRepositoryItemButtonEdit.AutoHeight = False
        Me.deleteRepositoryItemButtonEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.deleteRepositoryItemButtonEdit.Name = "deleteRepositoryItemButtonEdit"
        Me.deleteRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'idGridColumn
        '
        Me.idGridColumn.Caption = "GridColumn1"
        Me.idGridColumn.FieldName = "AdjustmentID"
        Me.idGridColumn.Name = "idGridColumn"
        Me.idGridColumn.OptionsColumn.AllowEdit = False
        Me.idGridColumn.OptionsColumn.ReadOnly = True
        '
        'customerGridColumn
        '
        Me.customerGridColumn.Caption = "Customer Name"
        Me.customerGridColumn.FieldName = "CustomerName"
        Me.customerGridColumn.Name = "customerGridColumn"
        Me.customerGridColumn.OptionsColumn.ReadOnly = True
        Me.customerGridColumn.Visible = True
        Me.customerGridColumn.VisibleIndex = 1
        Me.customerGridColumn.Width = 98
        '
        'dateGridColumn
        '
        Me.dateGridColumn.Caption = "Date"
        Me.dateGridColumn.DisplayFormat.FormatString = "D"
        Me.dateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dateGridColumn.FieldName = "AdjustmentDate"
        Me.dateGridColumn.Name = "dateGridColumn"
        Me.dateGridColumn.OptionsColumn.AllowEdit = False
        Me.dateGridColumn.OptionsColumn.ReadOnly = True
        Me.dateGridColumn.Visible = True
        Me.dateGridColumn.VisibleIndex = 2
        Me.dateGridColumn.Width = 98
        '
        'itemGridColumn
        '
        Me.itemGridColumn.Caption = "Item #"
        Me.itemGridColumn.FieldName = "ItemCode"
        Me.itemGridColumn.Name = "itemGridColumn"
        Me.itemGridColumn.OptionsColumn.ReadOnly = True
        Me.itemGridColumn.Visible = True
        Me.itemGridColumn.VisibleIndex = 3
        Me.itemGridColumn.Width = 93
        '
        'descriptionGridColumn
        '
        Me.descriptionGridColumn.Caption = "Item Description"
        Me.descriptionGridColumn.FieldName = "ItemDescription"
        Me.descriptionGridColumn.Name = "descriptionGridColumn"
        Me.descriptionGridColumn.OptionsColumn.AllowEdit = False
        Me.descriptionGridColumn.OptionsColumn.ReadOnly = True
        Me.descriptionGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.descriptionGridColumn.Visible = True
        Me.descriptionGridColumn.VisibleIndex = 4
        Me.descriptionGridColumn.Width = 180
        '
        'colLPN
        '
        Me.colLPN.FieldName = "LPN"
        Me.colLPN.Name = "colLPN"
        Me.colLPN.Visible = True
        Me.colLPN.VisibleIndex = 5
        '
        'locationCodeGridColumn
        '
        Me.locationCodeGridColumn.Caption = "Location"
        Me.locationCodeGridColumn.FieldName = "InventoryLocation"
        Me.locationCodeGridColumn.Name = "locationCodeGridColumn"
        Me.locationCodeGridColumn.Visible = True
        Me.locationCodeGridColumn.VisibleIndex = 6
        '
        'originalQuantityGridColumn
        '
        Me.originalQuantityGridColumn.Caption = "Orig. Qty"
        Me.originalQuantityGridColumn.DisplayFormat.FormatString = "{0:#,##0.######}"
        Me.originalQuantityGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.originalQuantityGridColumn.FieldName = "OriginalQuantity"
        Me.originalQuantityGridColumn.Name = "originalQuantityGridColumn"
        Me.originalQuantityGridColumn.OptionsColumn.AllowEdit = False
        Me.originalQuantityGridColumn.OptionsColumn.FixedWidth = True
        Me.originalQuantityGridColumn.OptionsColumn.ReadOnly = True
        Me.originalQuantityGridColumn.Visible = True
        Me.originalQuantityGridColumn.VisibleIndex = 7
        Me.originalQuantityGridColumn.Width = 60
        '
        'newQtyGridColumn
        '
        Me.newQtyGridColumn.Caption = "New Qty"
        Me.newQtyGridColumn.DisplayFormat.FormatString = "{0:#,##0.######}"
        Me.newQtyGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.newQtyGridColumn.FieldName = "NewCount"
        Me.newQtyGridColumn.Name = "newQtyGridColumn"
        Me.newQtyGridColumn.OptionsColumn.AllowEdit = False
        Me.newQtyGridColumn.OptionsColumn.FixedWidth = True
        Me.newQtyGridColumn.OptionsColumn.ReadOnly = True
        Me.newQtyGridColumn.Visible = True
        Me.newQtyGridColumn.VisibleIndex = 8
        Me.newQtyGridColumn.Width = 60
        '
        'colOriginalLot
        '
        Me.colOriginalLot.Caption = "Orig. Lot#"
        Me.colOriginalLot.FieldName = "OriginalLot"
        Me.colOriginalLot.Name = "colOriginalLot"
        Me.colOriginalLot.Visible = True
        Me.colOriginalLot.VisibleIndex = 10
        '
        'colNewLot
        '
        Me.colNewLot.FieldName = "NewLot"
        Me.colNewLot.Name = "colNewLot"
        Me.colNewLot.Visible = True
        Me.colNewLot.VisibleIndex = 11
        '
        'adjustmentGridColumn
        '
        Me.adjustmentGridColumn.Caption = "Adjustment"
        Me.adjustmentGridColumn.DisplayFormat.FormatString = "##;-##"
        Me.adjustmentGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.adjustmentGridColumn.FieldName = "adjustmentGridColumn"
        Me.adjustmentGridColumn.Name = "adjustmentGridColumn"
        Me.adjustmentGridColumn.OptionsColumn.AllowEdit = False
        Me.adjustmentGridColumn.OptionsColumn.FixedWidth = True
        Me.adjustmentGridColumn.OptionsColumn.ReadOnly = True
        Me.adjustmentGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.adjustmentGridColumn.Visible = True
        Me.adjustmentGridColumn.VisibleIndex = 9
        Me.adjustmentGridColumn.Width = 65
        '
        'reasonGridColumn
        '
        Me.reasonGridColumn.Caption = "Reason"
        Me.reasonGridColumn.ColumnEdit = Me.reasonRepositoryItemMemoExEdit
        Me.reasonGridColumn.FieldName = "Reason"
        Me.reasonGridColumn.Name = "reasonGridColumn"
        Me.reasonGridColumn.OptionsColumn.ReadOnly = True
        Me.reasonGridColumn.Visible = True
        Me.reasonGridColumn.VisibleIndex = 12
        Me.reasonGridColumn.Width = 110
        '
        'reasonRepositoryItemMemoExEdit
        '
        Me.reasonRepositoryItemMemoExEdit.AutoHeight = False
        Me.reasonRepositoryItemMemoExEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.reasonRepositoryItemMemoExEdit.Name = "reasonRepositoryItemMemoExEdit"
        '
        'itemIDGridColumn
        '
        Me.itemIDGridColumn.Caption = "Item ID"
        Me.itemIDGridColumn.FieldName = "ItemID"
        Me.itemIDGridColumn.Name = "itemIDGridColumn"
        '
        'customerIDGridColumn
        '
        Me.customerIDGridColumn.Caption = "Customer ID"
        Me.customerIDGridColumn.FieldName = "CustomerID"
        Me.customerIDGridColumn.Name = "customerIDGridColumn"
        '
        'locationGridColumn
        '
        Me.locationGridColumn.Caption = "Location ID"
        Me.locationGridColumn.FieldName = "LocationID"
        Me.locationGridColumn.Name = "locationGridColumn"
        '
        'filtersGroupControl
        '
        Me.filtersGroupControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.filtersGroupControl.Location = New System.Drawing.Point(13, 198)
        Me.filtersGroupControl.Name = "filtersGroupControl"
        Me.filtersGroupControl.Size = New System.Drawing.Size(768, 87)
        Me.filtersGroupControl.TabIndex = 3
        Me.filtersGroupControl.Text = "Filters and Display"
        '
        'filterSimpleButton
        '
        Me.filterSimpleButton.Location = New System.Drawing.Point(547, 55)
        Me.filterSimpleButton.Name = "filterSimpleButton"
        Me.filterSimpleButton.Size = New System.Drawing.Size(102, 23)
        Me.filterSimpleButton.TabIndex = 11
        Me.filterSimpleButton.Text = "&Filter"
        '
        'clearSimpleButton
        '
        Me.clearSimpleButton.Location = New System.Drawing.Point(547, 26)
        Me.clearSimpleButton.Name = "clearSimpleButton"
        Me.clearSimpleButton.Size = New System.Drawing.Size(102, 23)
        Me.clearSimpleButton.TabIndex = 10
        Me.clearSimpleButton.Text = "&Clear Filter"
        '
        'itemFilterLookUpEdit
        '
        Me.itemFilterLookUpEdit.Location = New System.Drawing.Point(386, 55)
        Me.itemFilterLookUpEdit.Name = "itemFilterLookUpEdit"
        Me.itemFilterLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.itemFilterLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 59, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCustomerID", "Item Customer ID", 95, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.itemFilterLookUpEdit.Properties.DataSource = Me.itemsFilterXPView
        Me.itemFilterLookUpEdit.Properties.DisplayMember = "ItemCode"
        Me.itemFilterLookUpEdit.Properties.NullText = "[Select A Item]"
        Me.itemFilterLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.itemFilterLookUpEdit.Properties.ValueMember = "ItemID"
        Me.itemFilterLookUpEdit.Size = New System.Drawing.Size(152, 20)
        Me.itemFilterLookUpEdit.TabIndex = 7
        '
        'itemsFilterXPView
        '
        Me.itemsFilterXPView.ObjectType = GetType(DXDAL.SPGData.Items)
        Me.itemsFilterXPView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[ItemID]", False, True), New DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.Ascending, "[ItemCode]", False, True), New DevExpress.Xpo.ViewProperty("ItemCustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID]", False, True), New DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID.CustomerID]", False, True)})
        '
        'customerFilterLookUpEdit
        '
        Me.customerFilterLookUpEdit.Location = New System.Drawing.Point(172, 55)
        Me.customerFilterLookUpEdit.Name = "customerFilterLookUpEdit"
        Me.customerFilterLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.customerFilterLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.customerFilterLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerID", "Customer ID", 83, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Customer Name", 86, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Inactive", "Inactive", 49, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.customerFilterLookUpEdit.Properties.DataSource = Me.customersFilterXPView
        Me.customerFilterLookUpEdit.Properties.DisplayMember = "CustomerName"
        Me.customerFilterLookUpEdit.Properties.NullText = "[Select A Customer]"
        Me.customerFilterLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.customerFilterLookUpEdit.Properties.ValueMember = "CustomerID"
        Me.customerFilterLookUpEdit.Size = New System.Drawing.Size(160, 20)
        Me.customerFilterLookUpEdit.TabIndex = 5
        '
        'customersFilterXPView
        '
        Me.customersFilterXPView.CriteriaString = "[Inactive] = False"
        Me.customersFilterXPView.ObjectType = GetType(DXDAL.SPGData.Customers)
        Me.customersFilterXPView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[CustomerID]", False, True), New DevExpress.Xpo.ViewProperty("CustomerName", DevExpress.Xpo.SortDirection.Ascending, "[CustomerName]", False, True), New DevExpress.Xpo.ViewProperty("Inactive", DevExpress.Xpo.SortDirection.None, "[Inactive]", False, True)})
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(354, 58)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl9.TabIndex = 6
        Me.LabelControl9.Text = "Item:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(354, 32)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(16, 13)
        Me.LabelControl8.TabIndex = 2
        Me.LabelControl8.Text = "To:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(116, 58)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl7.TabIndex = 4
        Me.LabelControl7.Text = "Customer:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(116, 32)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl6.TabIndex = 0
        Me.LabelControl6.Text = "From:"
        '
        'toFilterDateEdit
        '
        Me.toFilterDateEdit.EditValue = Nothing
        Me.toFilterDateEdit.Location = New System.Drawing.Point(386, 29)
        Me.toFilterDateEdit.Name = "toFilterDateEdit"
        Me.toFilterDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.toFilterDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.toFilterDateEdit.Properties.DisplayFormat.FormatString = "D"
        Me.toFilterDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.toFilterDateEdit.Properties.EditFormat.FormatString = "D"
        Me.toFilterDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.toFilterDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.toFilterDateEdit.Properties.NullText = "[Select A To Date]"
        Me.toFilterDateEdit.Size = New System.Drawing.Size(152, 20)
        Me.toFilterDateEdit.TabIndex = 3
        '
        'fromFilterDateEdit
        '
        Me.fromFilterDateEdit.EditValue = Nothing
        Me.fromFilterDateEdit.Location = New System.Drawing.Point(172, 29)
        Me.fromFilterDateEdit.Name = "fromFilterDateEdit"
        Me.fromFilterDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fromFilterDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.fromFilterDateEdit.Properties.DisplayFormat.FormatString = "D"
        Me.fromFilterDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fromFilterDateEdit.Properties.EditFormat.FormatString = "D"
        Me.fromFilterDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.fromFilterDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.fromFilterDateEdit.Properties.NullText = "[Select A From Date]"
        Me.fromFilterDateEdit.Size = New System.Drawing.Size(160, 20)
        Me.fromFilterDateEdit.TabIndex = 1
        '
        'recordGroupControl
        '
        Me.recordGroupControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.recordGroupControl.Controls.Add(Me.AddLpnSimpleButton)
        Me.recordGroupControl.Controls.Add(Me.LabelControl15)
        Me.recordGroupControl.Controls.Add(Me.locationLookUpEdit)
        Me.recordGroupControl.Controls.Add(Me.LabelControl13)
        Me.recordGroupControl.Controls.Add(Me.LabelControl14)
        Me.recordGroupControl.Controls.Add(Me.newLotTextEdit)
        Me.recordGroupControl.Controls.Add(Me.LabelControl12)
        Me.recordGroupControl.Controls.Add(Me.lpnLookUpEdit)
        Me.recordGroupControl.Controls.Add(Me.LabelControl11)
        Me.recordGroupControl.Controls.Add(Me.reasonMemoExEdit)
        Me.recordGroupControl.Controls.Add(Me.LabelControl10)
        Me.recordGroupControl.Controls.Add(Me.LabelControl4)
        Me.recordGroupControl.Controls.Add(Me.newQtyTextEdit)
        Me.recordGroupControl.Controls.Add(Me.originalQtyTextEdit)
        Me.recordGroupControl.Controls.Add(Me.LabelControl1)
        Me.recordGroupControl.Controls.Add(Me.customerLookUpEdit)
        Me.recordGroupControl.Controls.Add(Me.cancelSimpleButton)
        Me.recordGroupControl.Controls.Add(Me.editSimpleButton)
        Me.recordGroupControl.Controls.Add(Me.saveSimpleButton)
        Me.recordGroupControl.Controls.Add(Me.descriptionMemoEdit)
        Me.recordGroupControl.Controls.Add(Me.LabelControl5)
        Me.recordGroupControl.Controls.Add(Me.LabelControl3)
        Me.recordGroupControl.Controls.Add(Me.LabelControl2)
        Me.recordGroupControl.Controls.Add(Me.itemLookUpEdit)
        Me.recordGroupControl.Controls.Add(Me.adjustmentDateEdit)
        Me.recordGroupControl.Controls.Add(Me.originalLotLookUpEdit)
        Me.recordGroupControl.Location = New System.Drawing.Point(13, 11)
        Me.recordGroupControl.Name = "recordGroupControl"
        Me.recordGroupControl.ShowCaption = False
        Me.recordGroupControl.Size = New System.Drawing.Size(768, 181)
        Me.recordGroupControl.TabIndex = 2
        '
        'AddLpnSimpleButton
        '
        Me.AddLpnSimpleButton.Location = New System.Drawing.Point(172, 82)
        Me.AddLpnSimpleButton.Name = "AddLpnSimpleButton"
        Me.AddLpnSimpleButton.Size = New System.Drawing.Size(52, 22)
        Me.AddLpnSimpleButton.TabIndex = 26
        Me.AddLpnSimpleButton.Text = "Add LPN"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(230, 9)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl15.TabIndex = 24
        Me.LabelControl15.Text = "Location:"
        '
        'locationLookUpEdit
        '
        Me.locationLookUpEdit.Location = New System.Drawing.Point(230, 26)
        Me.locationLookUpEdit.Name = "locationLookUpEdit"
        Me.locationLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.locationLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationID", "Location ID", 77, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationCode", "Location Code", 78, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationName", "Location Name", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.locationLookUpEdit.Properties.DataSource = Me.locationsXpView
        Me.locationLookUpEdit.Properties.DisplayMember = "LocationCode"
        Me.locationLookUpEdit.Properties.NullText = "[Select A Location]"
        Me.locationLookUpEdit.Properties.ValueMember = "LocationID"
        Me.locationLookUpEdit.Size = New System.Drawing.Size(198, 20)
        Me.locationLookUpEdit.TabIndex = 23
        '
        'locationsXpView
        '
        Me.locationsXpView.ObjectType = GetType(DXDAL.SPGData.Locations)
        Me.locationsXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("LocationID", DevExpress.Xpo.SortDirection.None, "[Oid]", False, True), New DevExpress.Xpo.ViewProperty("LocationCode", DevExpress.Xpo.SortDirection.None, "[LocationCode]", False, True), New DevExpress.Xpo.ViewProperty("LocationName", DevExpress.Xpo.SortDirection.None, "[LocationName]", False, True)})
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(118, 129)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl13.TabIndex = 21
        Me.LabelControl13.Text = "Change to Lot#"
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(10, 129)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl14.TabIndex = 19
        Me.LabelControl14.Text = "Lot#"
        '
        'newLotTextEdit
        '
        Me.newLotTextEdit.Location = New System.Drawing.Point(118, 148)
        Me.newLotTextEdit.Name = "newLotTextEdit"
        Me.newLotTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.newLotTextEdit.TabIndex = 22
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(10, 87)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl12.TabIndex = 18
        Me.LabelControl12.Text = "LPN #:"
        '
        'lpnLookUpEdit
        '
        Me.lpnLookUpEdit.Location = New System.Drawing.Point(10, 104)
        Me.lpnLookUpEdit.Name = "lpnLookUpEdit"
        Me.lpnLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lpnLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationID", "Location ID", 77, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationCode", "Location Code", 78, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LPN", "LPN", 28, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 46, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.lpnLookUpEdit.Properties.DataSource = Me.lpnXpView
        Me.lpnLookUpEdit.Properties.DisplayMember = "LPN"
        Me.lpnLookUpEdit.Properties.NullText = "[Select A LPN]"
        Me.lpnLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.lpnLookUpEdit.Properties.ValueMember = "LPN"
        Me.lpnLookUpEdit.Size = New System.Drawing.Size(214, 20)
        Me.lpnLookUpEdit.TabIndex = 17
        '
        'lpnXpView
        '
        Me.lpnXpView.ObjectType = GetType(DXDAL.SPGData.LocationInventoryByLot)
        Me.lpnXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("LocationID", DevExpress.Xpo.SortDirection.None, "[Location.Oid]", True, True), New DevExpress.Xpo.ViewProperty("LocationCode", DevExpress.Xpo.SortDirection.None, "[Location.LocationCode]", True, True), New DevExpress.Xpo.ViewProperty("LPN", DevExpress.Xpo.SortDirection.None, "[LPNNumber]", True, True), New DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[LocationInventoryItem.ItemID]", True, True), New DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[LocationInventoryItem.ItemCode]", True, True)})
        '
        'LabelControl11
        '
        Me.LabelControl11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl11.Location = New System.Drawing.Point(442, 87)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(94, 13)
        Me.LabelControl11.TabIndex = 10
        Me.LabelControl11.Text = "Adjustment Reason"
        '
        'reasonMemoExEdit
        '
        Me.reasonMemoExEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.reasonMemoExEdit.Location = New System.Drawing.Point(440, 104)
        Me.reasonMemoExEdit.Name = "reasonMemoExEdit"
        Me.reasonMemoExEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.reasonMemoExEdit.Size = New System.Drawing.Size(208, 20)
        Me.reasonMemoExEdit.TabIndex = 11
        '
        'LabelControl10
        '
        Me.LabelControl10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl10.Location = New System.Drawing.Point(550, 47)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl10.TabIndex = 8
        Me.LabelControl10.Text = "New Qty"
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Location = New System.Drawing.Point(442, 47)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(18, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Qty"
        '
        'newQtyTextEdit
        '
        Me.newQtyTextEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.newQtyTextEdit.Location = New System.Drawing.Point(550, 63)
        Me.newQtyTextEdit.Name = "newQtyTextEdit"
        Me.newQtyTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.newQtyTextEdit.TabIndex = 9
        '
        'originalQtyTextEdit
        '
        Me.originalQtyTextEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.originalQtyTextEdit.Location = New System.Drawing.Point(442, 63)
        Me.originalQtyTextEdit.Name = "originalQtyTextEdit"
        Me.originalQtyTextEdit.Properties.DisplayFormat.FormatString = "{0:#,##0.######}"
        Me.originalQtyTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.originalQtyTextEdit.Properties.ReadOnly = True
        Me.originalQtyTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.originalQtyTextEdit.TabIndex = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Location = New System.Drawing.Point(442, 9)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl1.TabIndex = 4
        Me.LabelControl1.Text = "Customer"
        '
        'customerLookUpEdit
        '
        Me.customerLookUpEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.customerLookUpEdit.Location = New System.Drawing.Point(442, 26)
        Me.customerLookUpEdit.Name = "customerLookUpEdit"
        Me.customerLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.customerLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerID", "Customer ID", 83, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Customer Name", 86, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Inactive", "Inactive", 49, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.customerLookUpEdit.Properties.DataSource = Me.customersXPView
        Me.customerLookUpEdit.Properties.DisplayMember = "CustomerName"
        Me.customerLookUpEdit.Properties.NullText = "[Select A Customer]"
        Me.customerLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.customerLookUpEdit.Properties.ValueMember = "CustomerID"
        Me.customerLookUpEdit.Size = New System.Drawing.Size(208, 20)
        Me.customerLookUpEdit.TabIndex = 5
        '
        'customersXPView
        '
        Me.customersXPView.CriteriaString = "[Inactive] = False"
        Me.customersXPView.ObjectType = GetType(DXDAL.SPGData.Customers)
        Me.customersXPView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[CustomerID]", False, True), New DevExpress.Xpo.ViewProperty("CustomerName", DevExpress.Xpo.SortDirection.Ascending, "[CustomerName]", False, True), New DevExpress.Xpo.ViewProperty("Inactive", DevExpress.Xpo.SortDirection.None, "[Inactive]", False, True)})
        '
        'cancelSimpleButton
        '
        Me.cancelSimpleButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancelSimpleButton.Location = New System.Drawing.Point(656, 82)
        Me.cancelSimpleButton.Name = "cancelSimpleButton"
        Me.cancelSimpleButton.Size = New System.Drawing.Size(102, 23)
        Me.cancelSimpleButton.TabIndex = 16
        Me.cancelSimpleButton.Text = "Ca&ncel"
        '
        'editSimpleButton
        '
        Me.editSimpleButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editSimpleButton.Location = New System.Drawing.Point(656, 53)
        Me.editSimpleButton.Name = "editSimpleButton"
        Me.editSimpleButton.Size = New System.Drawing.Size(102, 23)
        Me.editSimpleButton.TabIndex = 15
        Me.editSimpleButton.Text = "&Edit Entry"
        '
        'saveSimpleButton
        '
        Me.saveSimpleButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.saveSimpleButton.Location = New System.Drawing.Point(656, 24)
        Me.saveSimpleButton.Name = "saveSimpleButton"
        Me.saveSimpleButton.Size = New System.Drawing.Size(102, 23)
        Me.saveSimpleButton.TabIndex = 14
        Me.saveSimpleButton.Text = "&Save Entry"
        '
        'descriptionMemoEdit
        '
        Me.descriptionMemoEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.descriptionMemoEdit.Location = New System.Drawing.Point(230, 67)
        Me.descriptionMemoEdit.Name = "descriptionMemoEdit"
        Me.descriptionMemoEdit.Size = New System.Drawing.Size(198, 101)
        Me.descriptionMemoEdit.TabIndex = 13
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(230, 47)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl5.TabIndex = 12
        Me.LabelControl5.Text = "Item Description"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(10, 47)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Item #:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(10, 9)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "Date:"
        '
        'itemLookUpEdit
        '
        Me.itemLookUpEdit.Location = New System.Drawing.Point(10, 63)
        Me.itemLookUpEdit.Name = "itemLookUpEdit"
        Me.itemLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.itemLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 59, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCustomerID", "Item Customer ID", 95, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.itemLookUpEdit.Properties.DataSource = Me.itemsXPView
        Me.itemLookUpEdit.Properties.DisplayMember = "ItemCode"
        Me.itemLookUpEdit.Properties.NullText = "[Select A Item]"
        Me.itemLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.itemLookUpEdit.Properties.ValueMember = "ItemID"
        Me.itemLookUpEdit.Size = New System.Drawing.Size(214, 20)
        Me.itemLookUpEdit.TabIndex = 3
        '
        'itemsXPView
        '
        Me.itemsXPView.CriteriaString = "[Inactive] = False"
        Me.itemsXPView.ObjectType = GetType(DXDAL.SPGData.Items)
        Me.itemsXPView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[ItemID]", False, True), New DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.Ascending, "[ItemCode]", False, True), New DevExpress.Xpo.ViewProperty("ItemCustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID]", False, True), New DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID.CustomerID]", False, True)})
        '
        'adjustmentDateEdit
        '
        Me.adjustmentDateEdit.EditValue = Nothing
        Me.adjustmentDateEdit.Location = New System.Drawing.Point(10, 26)
        Me.adjustmentDateEdit.Name = "adjustmentDateEdit"
        Me.adjustmentDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.adjustmentDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.adjustmentDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.adjustmentDateEdit.Properties.DisplayFormat.FormatString = "D"
        Me.adjustmentDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.adjustmentDateEdit.Properties.EditFormat.FormatString = "D"
        Me.adjustmentDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.adjustmentDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.adjustmentDateEdit.Size = New System.Drawing.Size(214, 20)
        Me.adjustmentDateEdit.TabIndex = 1
        '
        'originalLotLookUpEdit
        '
        Me.originalLotLookUpEdit.Location = New System.Drawing.Point(10, 148)
        Me.originalLotLookUpEdit.Name = "originalLotLookUpEdit"
        Me.originalLotLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.originalLotLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationID", "Location ID", 77, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationCode", "Location Code", 78, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LPN", "LPN", 28, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 46, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("lot", "lot", 100, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Qty", "Qty", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Expr", "Expr", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.originalLotLookUpEdit.Properties.DataSource = Me.LotXpView
        Me.originalLotLookUpEdit.Properties.DisplayMember = "lot"
        Me.originalLotLookUpEdit.Properties.NullText = "[Select A Lot#]"
        Me.originalLotLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.originalLotLookUpEdit.Properties.ValueMember = "lot"
        Me.originalLotLookUpEdit.Size = New System.Drawing.Size(100, 20)
        Me.originalLotLookUpEdit.TabIndex = 20
        '
        'LotXpView
        '
        Me.LotXpView.ObjectType = GetType(DXDAL.SPGData.LocationInventoryByLot)
        Me.LotXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("LocationID", DevExpress.Xpo.SortDirection.None, "[Location.Oid]", False, True), New DevExpress.Xpo.ViewProperty("LocationCode", DevExpress.Xpo.SortDirection.None, "[Location.LocationCode]", False, True), New DevExpress.Xpo.ViewProperty("LPN", DevExpress.Xpo.SortDirection.None, "[LPNNumber]", False, True), New DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[LocationInventoryItem.ItemID]", False, True), New DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[LocationInventoryItem.ItemCode]", False, True), New DevExpress.Xpo.ViewProperty("lot", DevExpress.Xpo.SortDirection.None, "[LocationInventoryLot]", False, True), New DevExpress.Xpo.ViewProperty("Qty", DevExpress.Xpo.SortDirection.None, "[QuantityOnHand]", False, True), New DevExpress.Xpo.ViewProperty("Expr", DevExpress.Xpo.SortDirection.None, "[ExpirationDate]", False, True)})
        '
        'InventoryAdjustmentXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 579)
        Me.Controls.Add(Me.adjustmentGridControl)
        Me.Controls.Add(Me.filtersGroupControl)
        Me.Controls.Add(Me.recordGroupControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InventoryAdjustmentXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Adjustment"
        CType(Me.adjustmentGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inventoryXPView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.adjustmentGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deleteRepositoryItemButtonEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reasonRepositoryItemMemoExEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.filtersGroupControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.filtersGroupControl.ResumeLayout(False)
        Me.filtersGroupControl.PerformLayout()
        CType(Me.itemFilterLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemsFilterXPView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.customerFilterLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.customersFilterXPView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.toFilterDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.toFilterDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fromFilterDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fromFilterDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.recordGroupControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.recordGroupControl.ResumeLayout(False)
        Me.recordGroupControl.PerformLayout()
        CType(Me.locationLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.locationsXpView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.newLotTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lpnLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lpnXpView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reasonMemoExEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.newQtyTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.originalQtyTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.customerLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.customersXPView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.descriptionMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemsXPView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.adjustmentDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.adjustmentDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.originalLotLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LotXpView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents adjustmentGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents adjustmentGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents deleteGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents deleteRepositoryItemButtonEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents idGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customerGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dateGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents itemGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents descriptionGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents originalQuantityGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents newQtyGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents adjustmentGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents reasonGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents filtersGroupControl As DevExpress.XtraEditors.GroupControl
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
    Friend WithEvents recordGroupControl As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cancelSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents editSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents saveSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents descriptionMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents itemLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents adjustmentDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents newQtyTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents originalQtyTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents customerLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents reasonMemoExEdit As DevExpress.XtraEditors.MemoExEdit
    Friend WithEvents reasonRepositoryItemMemoExEdit As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents inventoryXPView As DevExpress.Xpo.XPView
    Friend WithEvents customersFilterXPView As DevExpress.Xpo.XPView
    Friend WithEvents itemsFilterXPView As DevExpress.Xpo.XPView
    Friend WithEvents itemsXPView As DevExpress.Xpo.XPView
    Friend WithEvents customersXPView As DevExpress.Xpo.XPView
    Friend WithEvents itemIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customerIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lpnLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents locationsXpView As DevExpress.Xpo.XPView
    Friend WithEvents locationGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents locationCodeGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents newLotTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents locationLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents colLPN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOriginalLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNewLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lpnXpView As DevExpress.Xpo.XPView
    Friend WithEvents originalLotLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LotXpView As DevExpress.Xpo.XPView
    Friend WithEvents AddLpnSimpleButton As DevExpress.XtraEditors.SimpleButton
End Class
