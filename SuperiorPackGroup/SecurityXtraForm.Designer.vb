<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SecurityXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SecurityXtraForm))
        Me.sidePanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.usersListBoxControl = New DevExpress.XtraEditors.ListBoxControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.nameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.confirmTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.passwordTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.userPermissionsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.userPermissionsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.permissionObjectGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.permissionLevelGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.permissionsRepositoryItemComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.userNaemGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.permissionIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.usersMenuBar = New DevExpress.XtraBars.Bar()
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
        Me.securityXtraTabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.permissionsXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.customersXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.customersGridControl = New DevExpress.XtraGrid.GridControl()
        Me.customersXPCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.customersGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.userNameGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.customerIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.customerRepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.customersXPView = New DevExpress.Xpo.XPView(Me.components)
        Me.locationLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.locationsXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.resetSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LPNPrinterTextEdit = New DevExpress.XtraEditors.TextEdit()
        CType(Me.sidePanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sidePanelControl.SuspendLayout()
        CType(Me.usersListBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.confirmTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passwordTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userPermissionsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userPermissionsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.permissionsRepositoryItemComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.securityXtraTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.securityXtraTabControl.SuspendLayout()
        Me.permissionsXtraTabPage.SuspendLayout()
        Me.customersXtraTabPage.SuspendLayout()
        CType(Me.customersGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.customersXPCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.customersGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.customerRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.customersXPView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.locationLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.locationsXpView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LPNPrinterTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sidePanelControl
        '
        Me.sidePanelControl.Controls.Add(Me.usersListBoxControl)
        Me.sidePanelControl.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidePanelControl.Location = New System.Drawing.Point(0, 49)
        Me.sidePanelControl.Name = "sidePanelControl"
        Me.sidePanelControl.Size = New System.Drawing.Size(145, 444)
        Me.sidePanelControl.TabIndex = 0
        '
        'usersListBoxControl
        '
        Me.usersListBoxControl.Location = New System.Drawing.Point(5, 6)
        Me.usersListBoxControl.Name = "usersListBoxControl"
        Me.usersListBoxControl.Size = New System.Drawing.Size(135, 432)
        Me.usersListBoxControl.TabIndex = 4
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(168, 60)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "User Name:"
        '
        'nameTextEdit
        '
        Me.nameTextEdit.Location = New System.Drawing.Point(260, 57)
        Me.nameTextEdit.Name = "nameTextEdit"
        Me.nameTextEdit.Size = New System.Drawing.Size(140, 20)
        Me.nameTextEdit.TabIndex = 2
        '
        'confirmTextEdit
        '
        Me.confirmTextEdit.Location = New System.Drawing.Point(260, 107)
        Me.confirmTextEdit.Name = "confirmTextEdit"
        Me.confirmTextEdit.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirmTextEdit.Size = New System.Drawing.Size(140, 20)
        Me.confirmTextEdit.TabIndex = 6
        '
        'passwordTextEdit
        '
        Me.passwordTextEdit.Location = New System.Drawing.Point(260, 82)
        Me.passwordTextEdit.Name = "passwordTextEdit"
        Me.passwordTextEdit.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTextEdit.Size = New System.Drawing.Size(140, 20)
        Me.passwordTextEdit.TabIndex = 4
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(168, 110)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(86, 13)
        Me.LabelControl2.TabIndex = 5
        Me.LabelControl2.Text = "Confirm Password"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(168, 85)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl3.TabIndex = 3
        Me.LabelControl3.Text = "Password:"
        '
        'userPermissionsGridControl
        '
        Me.userPermissionsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.userPermissionsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.userPermissionsGridControl.MainView = Me.userPermissionsGridView
        Me.userPermissionsGridControl.Name = "userPermissionsGridControl"
        Me.userPermissionsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.permissionsRepositoryItemComboBox})
        Me.userPermissionsGridControl.Size = New System.Drawing.Size(258, 234)
        Me.userPermissionsGridControl.TabIndex = 8
        Me.userPermissionsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.userPermissionsGridView})
        '
        'userPermissionsGridView
        '
        Me.userPermissionsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.permissionObjectGridColumn, Me.permissionLevelGridColumn, Me.userNaemGridColumn, Me.permissionIDGridColumn})
        Me.userPermissionsGridView.GridControl = Me.userPermissionsGridControl
        Me.userPermissionsGridView.Name = "userPermissionsGridView"
        Me.userPermissionsGridView.OptionsSelection.MultiSelect = True
        Me.userPermissionsGridView.OptionsView.ShowGroupPanel = False
        '
        'permissionObjectGridColumn
        '
        Me.permissionObjectGridColumn.Caption = "Object"
        Me.permissionObjectGridColumn.Name = "permissionObjectGridColumn"
        Me.permissionObjectGridColumn.OptionsColumn.AllowEdit = False
        Me.permissionObjectGridColumn.Visible = True
        Me.permissionObjectGridColumn.VisibleIndex = 0
        '
        'permissionLevelGridColumn
        '
        Me.permissionLevelGridColumn.Caption = "Permission"
        Me.permissionLevelGridColumn.ColumnEdit = Me.permissionsRepositoryItemComboBox
        Me.permissionLevelGridColumn.Name = "permissionLevelGridColumn"
        Me.permissionLevelGridColumn.Visible = True
        Me.permissionLevelGridColumn.VisibleIndex = 1
        '
        'permissionsRepositoryItemComboBox
        '
        Me.permissionsRepositoryItemComboBox.AutoHeight = False
        Me.permissionsRepositoryItemComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.permissionsRepositoryItemComboBox.Items.AddRange(New Object() {"NONE", "VIEW", "EDIT", "ADD", "FULL", "VIEW ASSIGNED", "EDIT ASSIGNED"})
        Me.permissionsRepositoryItemComboBox.Name = "permissionsRepositoryItemComboBox"
        '
        'userNaemGridColumn
        '
        Me.userNaemGridColumn.Caption = "GridColumn1"
        Me.userNaemGridColumn.Name = "userNaemGridColumn"
        Me.userNaemGridColumn.OptionsColumn.AllowEdit = False
        '
        'permissionIDGridColumn
        '
        Me.permissionIDGridColumn.Caption = "GridColumn1"
        Me.permissionIDGridColumn.Name = "permissionIDGridColumn"
        Me.permissionIDGridColumn.OptionsColumn.AllowEdit = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.usersMenuBar, Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.addBarButtonItem, Me.cancelBarButtonItem, Me.saveBarButtonItem, Me.deleteBarButtonItem, Me.editBarButtonItem})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 5
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'usersMenuBar
        '
        Me.usersMenuBar.BarName = "Tools"
        Me.usersMenuBar.DockCol = 0
        Me.usersMenuBar.DockRow = 1
        Me.usersMenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.usersMenuBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.addBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.editBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.cancelBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.saveBarButtonItem)})
        Me.usersMenuBar.OptionsBar.UseWholeRow = True
        Me.usersMenuBar.Text = "Tools"
        '
        'addBarButtonItem
        '
        Me.addBarButtonItem.Caption = "&Add User"
        Me.addBarButtonItem.Id = 0
        Me.addBarButtonItem.Name = "addBarButtonItem"
        '
        'editBarButtonItem
        '
        Me.editBarButtonItem.Caption = "&Edit User"
        Me.editBarButtonItem.Id = 4
        Me.editBarButtonItem.Name = "editBarButtonItem"
        '
        'deleteBarButtonItem
        '
        Me.deleteBarButtonItem.Caption = "Delete User"
        Me.deleteBarButtonItem.Id = 3
        Me.deleteBarButtonItem.Name = "deleteBarButtonItem"
        '
        'cancelBarButtonItem
        '
        Me.cancelBarButtonItem.Caption = "&Cancel Changes"
        Me.cancelBarButtonItem.Enabled = False
        Me.cancelBarButtonItem.Id = 1
        Me.cancelBarButtonItem.Name = "cancelBarButtonItem"
        '
        'saveBarButtonItem
        '
        Me.saveBarButtonItem.Caption = "&Save Changes"
        Me.saveBarButtonItem.Enabled = False
        Me.saveBarButtonItem.Id = 2
        Me.saveBarButtonItem.Name = "saveBarButtonItem"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(427, 49)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 493)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(427, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 49)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 444)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(427, 49)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 444)
        '
        'securityXtraTabControl
        '
        Me.securityXtraTabControl.Location = New System.Drawing.Point(151, 223)
        Me.securityXtraTabControl.Name = "securityXtraTabControl"
        Me.securityXtraTabControl.SelectedTabPage = Me.permissionsXtraTabPage
        Me.securityXtraTabControl.Size = New System.Drawing.Size(264, 262)
        Me.securityXtraTabControl.TabIndex = 9
        Me.securityXtraTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.permissionsXtraTabPage, Me.customersXtraTabPage})
        '
        'permissionsXtraTabPage
        '
        Me.permissionsXtraTabPage.Controls.Add(Me.userPermissionsGridControl)
        Me.permissionsXtraTabPage.Name = "permissionsXtraTabPage"
        Me.permissionsXtraTabPage.Size = New System.Drawing.Size(258, 234)
        Me.permissionsXtraTabPage.Text = "Permissions"
        '
        'customersXtraTabPage
        '
        Me.customersXtraTabPage.Controls.Add(Me.customersGridControl)
        Me.customersXtraTabPage.Name = "customersXtraTabPage"
        Me.customersXtraTabPage.Size = New System.Drawing.Size(258, 234)
        Me.customersXtraTabPage.Text = "Customers"
        '
        'customersGridControl
        '
        Me.customersGridControl.DataSource = Me.customersXPCollection
        Me.customersGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.customersGridControl.Location = New System.Drawing.Point(0, 0)
        Me.customersGridControl.MainView = Me.customersGridView
        Me.customersGridControl.MenuManager = Me.BarManager1
        Me.customersGridControl.Name = "customersGridControl"
        Me.customersGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.customerRepositoryItemLookUpEdit})
        Me.customersGridControl.Size = New System.Drawing.Size(258, 234)
        Me.customersGridControl.TabIndex = 0
        Me.customersGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.customersGridView})
        '
        'customersXPCollection
        '
        Me.customersXPCollection.ObjectType = GetType(DXDAL.SPGData.UsersCustomer)
        '
        'customersGridView
        '
        Me.customersGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.GridColumn1, Me.userNameGridColumn, Me.GridColumn3, Me.customerIDGridColumn})
        Me.customersGridView.GridControl = Me.customersGridControl
        Me.customersGridView.Name = "customersGridView"
        Me.customersGridView.OptionsDetail.EnableMasterViewMode = False
        Me.customersGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.customersGridView.OptionsView.ShowGroupPanel = False
        '
        'colOid
        '
        Me.colOid.FieldName = "Oid"
        Me.colOid.Name = "colOid"
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "User!"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'userNameGridColumn
        '
        Me.userNameGridColumn.FieldName = "User!Key"
        Me.userNameGridColumn.Name = "userNameGridColumn"
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "Customer!"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'customerIDGridColumn
        '
        Me.customerIDGridColumn.ColumnEdit = Me.customerRepositoryItemLookUpEdit
        Me.customerIDGridColumn.FieldName = "Customer!Key"
        Me.customerIDGridColumn.Name = "customerIDGridColumn"
        Me.customerIDGridColumn.Visible = True
        Me.customerIDGridColumn.VisibleIndex = 0
        '
        'customerRepositoryItemLookUpEdit
        '
        Me.customerRepositoryItemLookUpEdit.AutoHeight = False
        Me.customerRepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.customerRepositoryItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerID", "Customer ID", 83, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Customer Name", 86, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.customerRepositoryItemLookUpEdit.DataSource = Me.customersXPView
        Me.customerRepositoryItemLookUpEdit.DisplayMember = "CustomerName"
        Me.customerRepositoryItemLookUpEdit.Name = "customerRepositoryItemLookUpEdit"
        Me.customerRepositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.customerRepositoryItemLookUpEdit.ValueMember = "CustomerID"
        '
        'customersXPView
        '
        Me.customersXPView.ObjectType = GetType(DXDAL.SPGData.Customers)
        Me.customersXPView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[CustomerID]", False, True), New DevExpress.Xpo.ViewProperty("CustomerName", DevExpress.Xpo.SortDirection.None, "[CustomerName]", False, True)})
        '
        'locationLookUpEdit
        '
        Me.locationLookUpEdit.Location = New System.Drawing.Point(260, 159)
        Me.locationLookUpEdit.MenuManager = Me.BarManager1
        Me.locationLookUpEdit.Name = "locationLookUpEdit"
        Me.locationLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.locationLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationCode", "Location Code", 91, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationName", "Location Name", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationID", "location", 47, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.locationLookUpEdit.Properties.DataSource = Me.locationsXpView
        Me.locationLookUpEdit.Properties.DisplayMember = "LocationCode"
        Me.locationLookUpEdit.Properties.NullText = "[Select default location]"
        Me.locationLookUpEdit.Properties.ValueMember = "LocationID"
        Me.locationLookUpEdit.Size = New System.Drawing.Size(140, 20)
        Me.locationLookUpEdit.TabIndex = 14
        '
        'locationsXpView
        '
        Me.locationsXpView.ObjectType = GetType(DXDAL.SPGData.Locations)
        Me.locationsXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("LocationCode", DevExpress.Xpo.SortDirection.None, "[LocationCode]", False, True), New DevExpress.Xpo.ViewProperty("LocationName", DevExpress.Xpo.SortDirection.None, "[LocationName]", False, True), New DevExpress.Xpo.ViewProperty("LocationID", DevExpress.Xpo.SortDirection.None, "[Oid]", False, True)})
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(168, 162)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl4.TabIndex = 15
        Me.LabelControl4.Text = "Default Location"
        '
        'resetSimpleButton
        '
        Me.resetSimpleButton.Location = New System.Drawing.Point(260, 184)
        Me.resetSimpleButton.Name = "resetSimpleButton"
        Me.resetSimpleButton.Size = New System.Drawing.Size(100, 23)
        Me.resetSimpleButton.TabIndex = 20
        Me.resetSimpleButton.Text = "Reset Permissions"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(168, 136)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl5.TabIndex = 25
        Me.LabelControl5.Text = "LPN Printer"
        '
        'LPNPrinterTextEdit
        '
        Me.LPNPrinterTextEdit.Location = New System.Drawing.Point(260, 133)
        Me.LPNPrinterTextEdit.Name = "LPNPrinterTextEdit"
        Me.LPNPrinterTextEdit.Size = New System.Drawing.Size(140, 20)
        Me.LPNPrinterTextEdit.TabIndex = 26
        '
        'SecurityXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 516)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LPNPrinterTextEdit)
        Me.Controls.Add(Me.resetSimpleButton)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.locationLookUpEdit)
        Me.Controls.Add(Me.securityXtraTabControl)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.passwordTextEdit)
        Me.Controls.Add(Me.confirmTextEdit)
        Me.Controls.Add(Me.nameTextEdit)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.sidePanelControl)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SecurityXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Security"
        CType(Me.sidePanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sidePanelControl.ResumeLayout(False)
        CType(Me.usersListBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.confirmTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passwordTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userPermissionsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userPermissionsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.permissionsRepositoryItemComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.securityXtraTabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.securityXtraTabControl.ResumeLayout(False)
        Me.permissionsXtraTabPage.ResumeLayout(False)
        Me.customersXtraTabPage.ResumeLayout(False)
        CType(Me.customersGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.customersXPCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.customersGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.customerRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.customersXPView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.locationLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.locationsXpView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LPNPrinterTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sidePanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents usersListBoxControl As DevExpress.XtraEditors.ListBoxControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents confirmTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents passwordTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents userPermissionsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents userPermissionsGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents permissionObjectGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents permissionLevelGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents userNaemGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents permissionsRepositoryItemComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents usersMenuBar As DevExpress.XtraBars.Bar
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents addBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cancelBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents saveBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents deleteBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents permissionIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents editBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents securityXtraTabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents permissionsXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents customersXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents customersGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents customersGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents customersXPCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents userNameGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customerIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents customerRepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents customersXPView As DevExpress.Xpo.XPView
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents locationLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents locationsXpView As DevExpress.Xpo.XPView
    Friend WithEvents resetSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LPNPrinterTextEdit As DevExpress.XtraEditors.TextEdit
End Class
