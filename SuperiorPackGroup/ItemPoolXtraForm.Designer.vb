<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemPoolXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ItemPoolXtraForm))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.poolMenuBar = New DevExpress.XtraBars.Bar()
        Me.addBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.editBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.deleteBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.cancelBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.saveBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.poolSearchGridControl = New DevExpress.XtraGrid.GridControl()
        Me.poolSearchXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.poolSearchGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPoolID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPoolCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.poolXtraTabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.poolXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.poolDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.poolDetailsXpCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.poolDetailsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.deleteGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.deleteRepositoryItemButtonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.poolIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.itemGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.itemRepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.itemXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.colItemPoolRatio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.itemQtyOnHandGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.poolQuantityOnHandGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.descriptionMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.customerLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.customerXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.codeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.typeTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.BarManager1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.SplitContainerControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainerControl1.SuspendLayout
        CType(Me.poolSearchGridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.poolSearchXpView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.poolSearchGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.poolXtraTabControl,System.ComponentModel.ISupportInitialize).BeginInit
        Me.poolXtraTabControl.SuspendLayout
        Me.poolXtraTabPage.SuspendLayout
        CType(Me.poolDetailsGridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.poolDetailsXpCollection,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.poolDetailsGridView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.deleteRepositoryItemButtonEdit,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.itemRepositoryItemLookUpEdit,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.itemXpView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.descriptionMemoEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.customerLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.customerXpView,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.codeTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.typeTextEdit.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.poolMenuBar, Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.addBarButtonItem, Me.editBarButtonItem, Me.deleteBarButtonItem, Me.cancelBarButtonItem, Me.saveBarButtonItem})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 5
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'poolMenuBar
        '
        Me.poolMenuBar.BarName = "Tools"
        Me.poolMenuBar.DockCol = 0
        Me.poolMenuBar.DockRow = 1
        Me.poolMenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.poolMenuBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.addBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.editBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.cancelBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.saveBarButtonItem)})
        Me.poolMenuBar.OptionsBar.UseWholeRow = true
        Me.poolMenuBar.Text = "Tools"
        '
        'addBarButtonItem
        '
        Me.addBarButtonItem.Caption = "&Add Pool"
        Me.addBarButtonItem.Id = 0
        Me.addBarButtonItem.Name = "addBarButtonItem"
        '
        'editBarButtonItem
        '
        Me.editBarButtonItem.Caption = "&Edit Pool"
        Me.editBarButtonItem.Id = 1
        Me.editBarButtonItem.Name = "editBarButtonItem"
        '
        'deleteBarButtonItem
        '
        Me.deleteBarButtonItem.Caption = "Delete Pool"
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
        'Bar2
        '
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.OptionsBar.MultiLine = true
        Me.Bar2.OptionsBar.UseWholeRow = true
        Me.Bar2.Text = "Main menu"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(824, 49)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = false
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 526)
        Me.barDockControlBottom.Size = New System.Drawing.Size(824, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = false
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 49)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 477)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = false
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(824, 49)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 477)
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 49)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.poolSearchGridControl)
        Me.SplitContainerControl1.Panel1.MinSize = 250
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.poolXtraTabControl)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(824, 477)
        Me.SplitContainerControl1.TabIndex = 4
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'poolSearchGridControl
        '
        Me.poolSearchGridControl.DataSource = Me.poolSearchXpView
        Me.poolSearchGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.poolSearchGridControl.Location = New System.Drawing.Point(0, 0)
        Me.poolSearchGridControl.MainView = Me.poolSearchGridView
        Me.poolSearchGridControl.MenuManager = Me.BarManager1
        Me.poolSearchGridControl.Name = "poolSearchGridControl"
        Me.poolSearchGridControl.Size = New System.Drawing.Size(250, 477)
        Me.poolSearchGridControl.TabIndex = 5
        Me.poolSearchGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.poolSearchGridView})
        '
        'poolSearchXpView
        '
        Me.poolSearchXpView.ObjectType = GetType(DXDAL.SPGData.ItemPool)
        Me.poolSearchXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("PoolID", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true), New DevExpress.Xpo.ViewProperty("PoolCode", DevExpress.Xpo.SortDirection.None, "[PoolCode]", false, true)})
        '
        'poolSearchGridView
        '
        Me.poolSearchGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPoolID, Me.colPoolCode})
        Me.poolSearchGridView.GridControl = Me.poolSearchGridControl
        Me.poolSearchGridView.Name = "poolSearchGridView"
        Me.poolSearchGridView.OptionsBehavior.Editable = false
        Me.poolSearchGridView.OptionsView.ShowAutoFilterRow = true
        Me.poolSearchGridView.OptionsView.ShowGroupPanel = false
        '
        'colPoolID
        '
        Me.colPoolID.FieldName = "PoolID"
        Me.colPoolID.Name = "colPoolID"
        Me.colPoolID.OptionsColumn.ReadOnly = true
        '
        'colPoolCode
        '
        Me.colPoolCode.FieldName = "PoolCode"
        Me.colPoolCode.Name = "colPoolCode"
        Me.colPoolCode.OptionsColumn.ReadOnly = true
        Me.colPoolCode.Visible = true
        Me.colPoolCode.VisibleIndex = 0
        '
        'poolXtraTabControl
        '
        Me.poolXtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.poolXtraTabControl.Location = New System.Drawing.Point(0, 0)
        Me.poolXtraTabControl.Name = "poolXtraTabControl"
        Me.poolXtraTabControl.SelectedTabPage = Me.poolXtraTabPage
        Me.poolXtraTabControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.poolXtraTabControl.Size = New System.Drawing.Size(569, 477)
        Me.poolXtraTabControl.TabIndex = 0
        Me.poolXtraTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.poolXtraTabPage})
        '
        'poolXtraTabPage
        '
        Me.poolXtraTabPage.Controls.Add(Me.poolDetailsGridControl)
        Me.poolXtraTabPage.Controls.Add(Me.descriptionMemoEdit)
        Me.poolXtraTabPage.Controls.Add(Me.LabelControl4)
        Me.poolXtraTabPage.Controls.Add(Me.customerLookUpEdit)
        Me.poolXtraTabPage.Controls.Add(Me.LabelControl3)
        Me.poolXtraTabPage.Controls.Add(Me.codeTextEdit)
        Me.poolXtraTabPage.Controls.Add(Me.LabelControl2)
        Me.poolXtraTabPage.Controls.Add(Me.typeTextEdit)
        Me.poolXtraTabPage.Controls.Add(Me.LabelControl1)
        Me.poolXtraTabPage.Name = "poolXtraTabPage"
        Me.poolXtraTabPage.Size = New System.Drawing.Size(563, 471)
        Me.poolXtraTabPage.Text = "XtraTabPage1"
        '
        'poolDetailsGridControl
        '
        Me.poolDetailsGridControl.DataSource = Me.poolDetailsXpCollection
        Me.poolDetailsGridControl.Location = New System.Drawing.Point(3, 210)
        Me.poolDetailsGridControl.MainView = Me.poolDetailsGridView
        Me.poolDetailsGridControl.MenuManager = Me.BarManager1
        Me.poolDetailsGridControl.Name = "poolDetailsGridControl"
        Me.poolDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.itemRepositoryItemLookUpEdit, Me.deleteRepositoryItemButtonEdit})
        Me.poolDetailsGridControl.Size = New System.Drawing.Size(553, 256)
        Me.poolDetailsGridControl.TabIndex = 8
        Me.poolDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.poolDetailsGridView})
        '
        'poolDetailsXpCollection
        '
        Me.poolDetailsXpCollection.ObjectType = GetType(DXDAL.SPGData.ItemPoolDetails)
        '
        'poolDetailsGridView
        '
        Me.poolDetailsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.deleteGridColumn, Me.colOid, Me.poolIDGridColumn, Me.itemGridColumn, Me.colItemPoolRatio, Me.itemQtyOnHandGridColumn, Me.poolQuantityOnHandGridColumn})
        Me.poolDetailsGridView.GridControl = Me.poolDetailsGridControl
        Me.poolDetailsGridView.Name = "poolDetailsGridView"
        Me.poolDetailsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.poolDetailsGridView.OptionsView.ShowDetailButtons = false
        Me.poolDetailsGridView.OptionsView.ShowFooter = true
        Me.poolDetailsGridView.OptionsView.ShowGroupPanel = false
        '
        'deleteGridColumn
        '
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
        'colOid
        '
        Me.colOid.FieldName = "Oid"
        Me.colOid.Name = "colOid"
        '
        'poolIDGridColumn
        '
        Me.poolIDGridColumn.Caption = "Pool ID"
        Me.poolIDGridColumn.FieldName = "ItemPoolID"
        Me.poolIDGridColumn.Name = "poolIDGridColumn"
        '
        'itemGridColumn
        '
        Me.itemGridColumn.Caption = "Item Code"
        Me.itemGridColumn.ColumnEdit = Me.itemRepositoryItemLookUpEdit
        Me.itemGridColumn.FieldName = "ItemID!Key"
        Me.itemGridColumn.Name = "itemGridColumn"
        Me.itemGridColumn.Visible = true
        Me.itemGridColumn.VisibleIndex = 1
        Me.itemGridColumn.Width = 165
        '
        'itemRepositoryItemLookUpEdit
        '
        Me.itemRepositoryItemLookUpEdit.AutoHeight = false
        Me.itemRepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.itemRepositoryItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 59, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)})
        Me.itemRepositoryItemLookUpEdit.DataSource = Me.itemXpView
        Me.itemRepositoryItemLookUpEdit.DisplayMember = "ItemCode"
        Me.itemRepositoryItemLookUpEdit.Name = "itemRepositoryItemLookUpEdit"
        Me.itemRepositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup
        Me.itemRepositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.itemRepositoryItemLookUpEdit.ValueMember = "ItemID"
        '
        'itemXpView
        '
        Me.itemXpView.ObjectType = GetType(DXDAL.SPGData.Items)
        Me.itemXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[ItemID]", false, true), New DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[ItemCode]", false, true)})
        '
        'colItemPoolRatio
        '
        Me.colItemPoolRatio.FieldName = "ItemPoolRatio"
        Me.colItemPoolRatio.Name = "colItemPoolRatio"
        Me.colItemPoolRatio.Visible = true
        Me.colItemPoolRatio.VisibleIndex = 2
        Me.colItemPoolRatio.Width = 84
        '
        'itemQtyOnHandGridColumn
        '
        Me.itemQtyOnHandGridColumn.Caption = "Item Quantity On Hand"
        Me.itemQtyOnHandGridColumn.DisplayFormat.FormatString = "{0:#,##0.####}"
        Me.itemQtyOnHandGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.itemQtyOnHandGridColumn.FieldName = "ItemID.sngQuantityOnHand"
        Me.itemQtyOnHandGridColumn.Name = "itemQtyOnHandGridColumn"
        Me.itemQtyOnHandGridColumn.OptionsColumn.AllowEdit = false
        Me.itemQtyOnHandGridColumn.Visible = true
        Me.itemQtyOnHandGridColumn.VisibleIndex = 3
        Me.itemQtyOnHandGridColumn.Width = 122
        '
        'poolQuantityOnHandGridColumn
        '
        Me.poolQuantityOnHandGridColumn.Caption = "Pool Quantity On Hand"
        Me.poolQuantityOnHandGridColumn.DisplayFormat.FormatString = "{0:#,##0.####}"
        Me.poolQuantityOnHandGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.poolQuantityOnHandGridColumn.FieldName = "QuantityOnHand"
        Me.poolQuantityOnHandGridColumn.Name = "poolQuantityOnHandGridColumn"
        Me.poolQuantityOnHandGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QuantityOnHand", "{0:#,##0.####}")})
        Me.poolQuantityOnHandGridColumn.Visible = true
        Me.poolQuantityOnHandGridColumn.VisibleIndex = 4
        Me.poolQuantityOnHandGridColumn.Width = 139
        '
        'descriptionMemoEdit
        '
        Me.descriptionMemoEdit.Location = New System.Drawing.Point(122, 77)
        Me.descriptionMemoEdit.MenuManager = Me.BarManager1
        Me.descriptionMemoEdit.Name = "descriptionMemoEdit"
        Me.descriptionMemoEdit.Size = New System.Drawing.Size(381, 96)
        Me.descriptionMemoEdit.TabIndex = 7
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(59, 80)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Description:"
        '
        'customerLookUpEdit
        '
        Me.customerLookUpEdit.Location = New System.Drawing.Point(122, 51)
        Me.customerLookUpEdit.MenuManager = Me.BarManager1
        Me.customerLookUpEdit.Name = "customerLookUpEdit"
        Me.customerLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.customerLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerID", "Customer ID", 83, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Customer Name", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Inactive", "Inactive", 49, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)})
        Me.customerLookUpEdit.Properties.DataSource = Me.customerXpView
        Me.customerLookUpEdit.Properties.DisplayMember = "CustomerName"
        Me.customerLookUpEdit.Properties.NullText = "[Select A Customer]"
        Me.customerLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.customerLookUpEdit.Properties.ValueMember = "CustomerID"
        Me.customerLookUpEdit.Size = New System.Drawing.Size(381, 20)
        Me.customerLookUpEdit.TabIndex = 5
        '
        'customerXpView
        '
        Me.customerXpView.CriteriaString = "[Inactive] = False"
        Me.customerXpView.ObjectType = GetType(DXDAL.SPGData.Customers)
        Me.customerXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[CustomerID]", false, true), New DevExpress.Xpo.ViewProperty("CustomerName", DevExpress.Xpo.SortDirection.None, "[CustomerName]", false, true), New DevExpress.Xpo.ViewProperty("Inactive", DevExpress.Xpo.SortDirection.None, "[Inactive]", false, true)})
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(59, 54)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Customer:"
        '
        'codeTextEdit
        '
        Me.codeTextEdit.Location = New System.Drawing.Point(353, 20)
        Me.codeTextEdit.MenuManager = Me.BarManager1
        Me.codeTextEdit.Name = "codeTextEdit"
        Me.codeTextEdit.Properties.NullText = "[Enter Pool Code]"
        Me.codeTextEdit.Size = New System.Drawing.Size(150, 20)
        Me.codeTextEdit.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(295, 23)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Pool Code:"
        '
        'typeTextEdit
        '
        Me.typeTextEdit.EditValue = "BOM Pool"
        Me.typeTextEdit.Enabled = false
        Me.typeTextEdit.Location = New System.Drawing.Point(122, 20)
        Me.typeTextEdit.MenuManager = Me.BarManager1
        Me.typeTextEdit.Name = "typeTextEdit"
        Me.typeTextEdit.Properties.ReadOnly = true
        Me.typeTextEdit.Size = New System.Drawing.Size(150, 20)
        Me.typeTextEdit.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(59, 23)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Type:"
        '
        'ItemPoolXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 549)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "ItemPoolXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Item Pool"
        CType(Me.BarManager1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.SplitContainerControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainerControl1.ResumeLayout(false)
        CType(Me.poolSearchGridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.poolSearchXpView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.poolSearchGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.poolXtraTabControl,System.ComponentModel.ISupportInitialize).EndInit
        Me.poolXtraTabControl.ResumeLayout(false)
        Me.poolXtraTabPage.ResumeLayout(false)
        Me.poolXtraTabPage.PerformLayout
        CType(Me.poolDetailsGridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.poolDetailsXpCollection,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.poolDetailsGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.deleteRepositoryItemButtonEdit,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.itemRepositoryItemLookUpEdit,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.itemXpView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.descriptionMemoEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.customerLookUpEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.customerXpView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.codeTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.typeTextEdit.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents poolMenuBar As DevExpress.XtraBars.Bar
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
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents poolXtraTabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents poolXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents poolSearchGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents poolSearchGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents poolSearchXpView As DevExpress.Xpo.XPView
    Friend WithEvents colPoolID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPoolCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents typeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents codeTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents customerLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents customerXpView As DevExpress.Xpo.XPView
    Friend WithEvents poolDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents poolDetailsXpCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents poolDetailsGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents poolIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents itemGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents itemRepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colItemPoolRatio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents descriptionMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents deleteGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents deleteRepositoryItemButtonEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents itemQtyOnHandGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents poolQuantityOnHandGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents itemXpView As DevExpress.Xpo.XPView
End Class
