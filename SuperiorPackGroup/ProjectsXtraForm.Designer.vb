<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectsXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProjectsXtraForm))
        Me.deleteRepositoryItemButtonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.itemXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.projectsBar = New DevExpress.XtraBars.Bar()
        Me.addBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.editBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.deleteBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.cancelBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.saveBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.printProductionReportBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.printBomAvailabilityBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.refreshBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.projectSearchGridControl = New DevExpress.XtraGrid.GridControl()
        Me.projectSearchXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.projectSearchGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colProjectID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomerGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReqStartDateGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.projectsXtraTabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.dataEntryXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.dataEntrySplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.notesMemoExEdit = New DevExpress.XtraEditors.MemoExEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.projectStatusComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.reqDeliveryDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.reqShipDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.reqStartDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.customerLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.customerXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.projectTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.oidTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.projectDetailsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.projectDetailsXpCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.projectDetailsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colItemNumber = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.itemRepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.delGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colHasChanges = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCustomerPO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitsRequested = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBagsRequested = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPalletsRequested = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colRemainingBalance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUnitsProduced = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colBagsProduced = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPalletsProduced = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPercentageComplete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAllowOverrun = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEstimatiedShifts = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.auditXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.detailHistorySimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.detailHistoryGridControl = New DevExpress.XtraGrid.GridControl()
        Me.detailHistoryGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RecordIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DateChangedGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PropertyNameGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PrevValueGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.NewValueGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.deleteRepositoryItemButtonEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemXpView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.projectSearchGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.projectSearchXpView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.projectSearchGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.projectsXtraTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.projectsXtraTabControl.SuspendLayout()
        Me.dataEntryXtraTabPage.SuspendLayout()
        CType(Me.dataEntrySplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dataEntrySplitContainerControl.SuspendLayout()
        CType(Me.notesMemoExEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.projectStatusComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reqDeliveryDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reqDeliveryDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reqShipDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reqShipDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reqStartDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reqStartDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.customerLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.customerXpView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.projectTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oidTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.projectDetailsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.projectDetailsXpCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.projectDetailsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.auditXtraTabPage.SuspendLayout()
        CType(Me.detailHistoryGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.detailHistoryGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'deleteRepositoryItemButtonEdit
        '
        Me.deleteRepositoryItemButtonEdit.AutoHeight = False
        Me.deleteRepositoryItemButtonEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.deleteRepositoryItemButtonEdit.Name = "deleteRepositoryItemButtonEdit"
        Me.deleteRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 59, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CaseQuantity", "Case Quantity", 79, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BagsPerCase", "Bags Per Case", 79, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CasePerPallet", "Case Per Pallet", 82, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.itemXpView
        Me.RepositoryItemLookUpEdit1.DisplayMember = "ItemCode"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "ItemID"
        '
        'itemXpView
        '
        Me.itemXpView.CriteriaString = "[ItemType] In ('IG', 'FG')"
        Me.itemXpView.ObjectType = GetType(DXDAL.SPGData.Items)
        Me.itemXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[ItemID]", False, True), New DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[ItemCode]", False, True), New DevExpress.Xpo.ViewProperty("CaseQuantity", DevExpress.Xpo.SortDirection.None, "[intUnitsPerCase]", False, True), New DevExpress.Xpo.ViewProperty("BagsPerCase", DevExpress.Xpo.SortDirection.None, "[BagsPerCase]", False, True), New DevExpress.Xpo.ViewProperty("CasePerPallet", DevExpress.Xpo.SortDirection.None, "[intCasesPerPallet]", False, True)})
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.projectsBar, Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.addBarButtonItem, Me.editBarButtonItem, Me.deleteBarButtonItem, Me.cancelBarButtonItem, Me.saveBarButtonItem, Me.printProductionReportBarButtonItem, Me.printBomAvailabilityBarButtonItem, Me.refreshBarButtonItem})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 10
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'projectsBar
        '
        Me.projectsBar.BarName = "Tools"
        Me.projectsBar.DockCol = 0
        Me.projectsBar.DockRow = 1
        Me.projectsBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.projectsBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.addBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.editBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.cancelBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.saveBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.printProductionReportBarButtonItem, True), New DevExpress.XtraBars.LinkPersistInfo(Me.printBomAvailabilityBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.refreshBarButtonItem, True)})
        Me.projectsBar.OptionsBar.UseWholeRow = True
        Me.projectsBar.Text = "Tools"
        '
        'addBarButtonItem
        '
        Me.addBarButtonItem.Caption = "&Add Project"
        Me.addBarButtonItem.Id = 0
        Me.addBarButtonItem.Name = "addBarButtonItem"
        '
        'editBarButtonItem
        '
        Me.editBarButtonItem.Caption = "&Edit Project"
        Me.editBarButtonItem.Id = 1
        Me.editBarButtonItem.Name = "editBarButtonItem"
        '
        'deleteBarButtonItem
        '
        Me.deleteBarButtonItem.Caption = "Delete Project"
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
        'printProductionReportBarButtonItem
        '
        Me.printProductionReportBarButtonItem.Caption = "Print &Production Report"
        Me.printProductionReportBarButtonItem.Id = 5
        Me.printProductionReportBarButtonItem.Name = "printProductionReportBarButtonItem"
        '
        'printBomAvailabilityBarButtonItem
        '
        Me.printBomAvailabilityBarButtonItem.Caption = "Print &Bom Availability"
        Me.printBomAvailabilityBarButtonItem.Id = 6
        Me.printBomAvailabilityBarButtonItem.Name = "printBomAvailabilityBarButtonItem"
        '
        'refreshBarButtonItem
        '
        Me.refreshBarButtonItem.Caption = "Refresh"
        Me.refreshBarButtonItem.Id = 9
        Me.refreshBarButtonItem.Name = "refreshBarButtonItem"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(797, 49)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 491)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(797, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 49)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 442)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(797, 49)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 442)
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 49)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.projectSearchGridControl)
        Me.SplitContainerControl1.Panel1.MinSize = 250
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.projectsXtraTabControl)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(797, 442)
        Me.SplitContainerControl1.TabIndex = 4
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'projectSearchGridControl
        '
        Me.projectSearchGridControl.DataSource = Me.projectSearchXpView
        Me.projectSearchGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.projectSearchGridControl.Location = New System.Drawing.Point(0, 0)
        Me.projectSearchGridControl.MainView = Me.projectSearchGridView
        Me.projectSearchGridControl.MenuManager = Me.BarManager1
        Me.projectSearchGridControl.Name = "projectSearchGridControl"
        Me.projectSearchGridControl.Size = New System.Drawing.Size(250, 442)
        Me.projectSearchGridControl.TabIndex = 0
        Me.projectSearchGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.projectSearchGridView})
        '
        'projectSearchXpView
        '
        Me.projectSearchXpView.ObjectType = GetType(DXDAL.SPGData.Project)
        Me.projectSearchXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("ProjectID", DevExpress.Xpo.SortDirection.None, "[Oid]", False, True), New DevExpress.Xpo.ViewProperty("Project", DevExpress.Xpo.SortDirection.None, "[Project]", False, True), New DevExpress.Xpo.ViewProperty("Req.StartDate", DevExpress.Xpo.SortDirection.Descending, "[RequestedStartDate]", False, True), New DevExpress.Xpo.ViewProperty("Customer", DevExpress.Xpo.SortDirection.None, "[Customer.CustomerName]", False, True)})
        '
        'projectSearchGridView
        '
        Me.projectSearchGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProjectID, Me.colProject, Me.colCustomerGridColumn, Me.colReqStartDateGridColumn})
        Me.projectSearchGridView.GridControl = Me.projectSearchGridControl
        Me.projectSearchGridView.Name = "projectSearchGridView"
        Me.projectSearchGridView.OptionsBehavior.Editable = False
        Me.projectSearchGridView.OptionsView.ShowAutoFilterRow = True
        Me.projectSearchGridView.OptionsView.ShowGroupPanel = False
        '
        'colProjectID
        '
        Me.colProjectID.FieldName = "ProjectID"
        Me.colProjectID.Name = "colProjectID"
        Me.colProjectID.OptionsColumn.ReadOnly = True
        '
        'colProject
        '
        Me.colProject.FieldName = "Project"
        Me.colProject.Name = "colProject"
        Me.colProject.OptionsColumn.ReadOnly = True
        Me.colProject.Visible = True
        Me.colProject.VisibleIndex = 0
        '
        'colCustomerGridColumn
        '
        Me.colCustomerGridColumn.FieldName = "Customer"
        Me.colCustomerGridColumn.Name = "colCustomerGridColumn"
        Me.colCustomerGridColumn.Visible = True
        Me.colCustomerGridColumn.VisibleIndex = 1
        '
        'colReqStartDateGridColumn
        '
        Me.colReqStartDateGridColumn.Caption = "Req. Start Date"
        Me.colReqStartDateGridColumn.FieldName = "Req.StartDate"
        Me.colReqStartDateGridColumn.Name = "colReqStartDateGridColumn"
        Me.colReqStartDateGridColumn.OptionsColumn.ReadOnly = True
        Me.colReqStartDateGridColumn.Visible = True
        Me.colReqStartDateGridColumn.VisibleIndex = 2
        '
        'projectsXtraTabControl
        '
        Me.projectsXtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.projectsXtraTabControl.Location = New System.Drawing.Point(0, 0)
        Me.projectsXtraTabControl.Name = "projectsXtraTabControl"
        Me.projectsXtraTabControl.SelectedTabPage = Me.dataEntryXtraTabPage
        Me.projectsXtraTabControl.Size = New System.Drawing.Size(542, 442)
        Me.projectsXtraTabControl.TabIndex = 1
        Me.projectsXtraTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.dataEntryXtraTabPage, Me.auditXtraTabPage})
        '
        'dataEntryXtraTabPage
        '
        Me.dataEntryXtraTabPage.Controls.Add(Me.dataEntrySplitContainerControl)
        Me.dataEntryXtraTabPage.Name = "dataEntryXtraTabPage"
        Me.dataEntryXtraTabPage.Size = New System.Drawing.Size(536, 414)
        Me.dataEntryXtraTabPage.Text = "Project"
        '
        'dataEntrySplitContainerControl
        '
        Me.dataEntrySplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataEntrySplitContainerControl.Horizontal = False
        Me.dataEntrySplitContainerControl.Location = New System.Drawing.Point(0, 0)
        Me.dataEntrySplitContainerControl.Name = "dataEntrySplitContainerControl"
        Me.dataEntrySplitContainerControl.Panel1.Controls.Add(Me.notesMemoExEdit)
        Me.dataEntrySplitContainerControl.Panel1.Controls.Add(Me.LabelControl9)
        Me.dataEntrySplitContainerControl.Panel1.Controls.Add(Me.LabelControl8)
        Me.dataEntrySplitContainerControl.Panel1.Controls.Add(Me.LabelControl7)
        Me.dataEntrySplitContainerControl.Panel1.Controls.Add(Me.projectStatusComboBoxEdit)
        Me.dataEntrySplitContainerControl.Panel1.Controls.Add(Me.LabelControl6)
        Me.dataEntrySplitContainerControl.Panel1.Controls.Add(Me.reqDeliveryDateEdit)
        Me.dataEntrySplitContainerControl.Panel1.Controls.Add(Me.LabelControl5)
        Me.dataEntrySplitContainerControl.Panel1.Controls.Add(Me.reqShipDateEdit)
        Me.dataEntrySplitContainerControl.Panel1.Controls.Add(Me.LabelControl4)
        Me.dataEntrySplitContainerControl.Panel1.Controls.Add(Me.reqStartDateEdit)
        Me.dataEntrySplitContainerControl.Panel1.Controls.Add(Me.LabelControl3)
        Me.dataEntrySplitContainerControl.Panel1.Controls.Add(Me.customerLookUpEdit)
        Me.dataEntrySplitContainerControl.Panel1.Controls.Add(Me.projectTextEdit)
        Me.dataEntrySplitContainerControl.Panel1.Controls.Add(Me.LabelControl2)
        Me.dataEntrySplitContainerControl.Panel1.Controls.Add(Me.LabelControl1)
        Me.dataEntrySplitContainerControl.Panel1.Controls.Add(Me.oidTextEdit)
        Me.dataEntrySplitContainerControl.Panel1.MinSize = 175
        Me.dataEntrySplitContainerControl.Panel1.Text = "Header"
        Me.dataEntrySplitContainerControl.Panel2.Controls.Add(Me.projectDetailsGridControl)
        Me.dataEntrySplitContainerControl.Panel2.Text = "Details"
        Me.dataEntrySplitContainerControl.Size = New System.Drawing.Size(536, 414)
        Me.dataEntrySplitContainerControl.TabIndex = 0
        Me.dataEntrySplitContainerControl.Text = "SplitContainerControl2"
        '
        'notesMemoExEdit
        '
        Me.notesMemoExEdit.Location = New System.Drawing.Point(113, 135)
        Me.notesMemoExEdit.MenuManager = Me.BarManager1
        Me.notesMemoExEdit.Name = "notesMemoExEdit"
        Me.notesMemoExEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.notesMemoExEdit.Size = New System.Drawing.Size(399, 20)
        Me.notesMemoExEdit.TabIndex = 17
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(31, 135)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(32, 13)
        Me.LabelControl9.TabIndex = 16
        Me.LabelControl9.Text = "Notes:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(274, 112)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl8.TabIndex = 14
        Me.LabelControl8.Text = "Scheduled Week:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(31, 112)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl7.TabIndex = 13
        Me.LabelControl7.Text = "Project Status:"
        '
        'projectStatusComboBoxEdit
        '
        Me.projectStatusComboBoxEdit.Location = New System.Drawing.Point(113, 109)
        Me.projectStatusComboBoxEdit.MenuManager = Me.BarManager1
        Me.projectStatusComboBoxEdit.Name = "projectStatusComboBoxEdit"
        Me.projectStatusComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.projectStatusComboBoxEdit.Size = New System.Drawing.Size(132, 20)
        Me.projectStatusComboBoxEdit.TabIndex = 12
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(274, 85)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl6.TabIndex = 11
        Me.LabelControl6.Text = "Req. Delivery Date:"
        '
        'reqDeliveryDateEdit
        '
        Me.reqDeliveryDateEdit.EditValue = Nothing
        Me.reqDeliveryDateEdit.Location = New System.Drawing.Point(375, 82)
        Me.reqDeliveryDateEdit.MenuManager = Me.BarManager1
        Me.reqDeliveryDateEdit.Name = "reqDeliveryDateEdit"
        Me.reqDeliveryDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.reqDeliveryDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.reqDeliveryDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.reqDeliveryDateEdit.Properties.Mask.EditMask = "D"
        Me.reqDeliveryDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.reqDeliveryDateEdit.Properties.NullText = "[Select A Date]"
        Me.reqDeliveryDateEdit.Size = New System.Drawing.Size(137, 20)
        Me.reqDeliveryDateEdit.TabIndex = 10
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(31, 85)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl5.TabIndex = 9
        Me.LabelControl5.Text = "Req. Ship Date:"
        '
        'reqShipDateEdit
        '
        Me.reqShipDateEdit.EditValue = Nothing
        Me.reqShipDateEdit.Location = New System.Drawing.Point(113, 82)
        Me.reqShipDateEdit.MenuManager = Me.BarManager1
        Me.reqShipDateEdit.Name = "reqShipDateEdit"
        Me.reqShipDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.reqShipDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.reqShipDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.reqShipDateEdit.Properties.Mask.EditMask = "D"
        Me.reqShipDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.reqShipDateEdit.Properties.NullText = "[Select A Date]"
        Me.reqShipDateEdit.Size = New System.Drawing.Size(132, 20)
        Me.reqShipDateEdit.TabIndex = 8
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(274, 58)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Req. Start Date:"
        '
        'reqStartDateEdit
        '
        Me.reqStartDateEdit.EditValue = Nothing
        Me.reqStartDateEdit.Location = New System.Drawing.Point(375, 55)
        Me.reqStartDateEdit.MenuManager = Me.BarManager1
        Me.reqStartDateEdit.Name = "reqStartDateEdit"
        Me.reqStartDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.reqStartDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.reqStartDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.reqStartDateEdit.Properties.Mask.EditMask = "D"
        Me.reqStartDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.reqStartDateEdit.Properties.NullText = "[Select A Date]"
        Me.reqStartDateEdit.Size = New System.Drawing.Size(137, 20)
        Me.reqStartDateEdit.TabIndex = 6
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(31, 58)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Customer:"
        '
        'customerLookUpEdit
        '
        Me.customerLookUpEdit.Location = New System.Drawing.Point(113, 55)
        Me.customerLookUpEdit.MenuManager = Me.BarManager1
        Me.customerLookUpEdit.Name = "customerLookUpEdit"
        Me.customerLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.customerLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerID", "Customer ID", 83, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Customer Name", 86, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.customerLookUpEdit.Properties.DataSource = Me.customerXpView
        Me.customerLookUpEdit.Properties.DisplayMember = "CustomerName"
        Me.customerLookUpEdit.Properties.NullText = "[Select A Customer]"
        Me.customerLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.customerLookUpEdit.Properties.ValueMember = "CustomerID"
        Me.customerLookUpEdit.Size = New System.Drawing.Size(132, 20)
        Me.customerLookUpEdit.TabIndex = 4
        '
        'customerXpView
        '
        Me.customerXpView.CriteriaString = "[Inactive] = False"
        Me.customerXpView.ObjectType = GetType(DXDAL.SPGData.Customers)
        Me.customerXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[CustomerID]", False, True), New DevExpress.Xpo.ViewProperty("CustomerName", DevExpress.Xpo.SortDirection.None, "[CustomerName]", False, True)})
        '
        'projectTextEdit
        '
        Me.projectTextEdit.Location = New System.Drawing.Point(375, 28)
        Me.projectTextEdit.MenuManager = Me.BarManager1
        Me.projectTextEdit.Name = "projectTextEdit"
        Me.projectTextEdit.Size = New System.Drawing.Size(137, 20)
        Me.projectTextEdit.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(274, 31)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Project:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(31, 31)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Internal ID:"
        '
        'oidTextEdit
        '
        Me.oidTextEdit.Enabled = False
        Me.oidTextEdit.Location = New System.Drawing.Point(113, 28)
        Me.oidTextEdit.MenuManager = Me.BarManager1
        Me.oidTextEdit.Name = "oidTextEdit"
        Me.oidTextEdit.Properties.ReadOnly = True
        Me.oidTextEdit.Size = New System.Drawing.Size(132, 20)
        Me.oidTextEdit.TabIndex = 0
        '
        'projectDetailsGridControl
        '
        Me.projectDetailsGridControl.DataSource = Me.projectDetailsXpCollection
        Me.projectDetailsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.projectDetailsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.projectDetailsGridControl.MainView = Me.projectDetailsGridView
        Me.projectDetailsGridControl.MenuManager = Me.BarManager1
        Me.projectDetailsGridControl.Name = "projectDetailsGridControl"
        Me.projectDetailsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.itemRepositoryItemLookUpEdit})
        Me.projectDetailsGridControl.Size = New System.Drawing.Size(536, 234)
        Me.projectDetailsGridControl.TabIndex = 0
        Me.projectDetailsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.projectDetailsGridView})
        '
        'projectDetailsXpCollection
        '
        Me.projectDetailsXpCollection.ObjectType = GetType(DXDAL.SPGData.ProjectDetails)
        '
        'projectDetailsGridView
        '
        Me.projectDetailsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colItemNumber, Me.delGridColumn, Me.colOid, Me.colHasChanges, Me.GridColumn1, Me.GridColumn2, Me.colCustomerPO, Me.GridColumn3, Me.colUnitsRequested, Me.colBagsRequested, Me.colPalletsRequested, Me.colRemainingBalance, Me.colUnitsProduced, Me.colBagsProduced, Me.colPalletsProduced, Me.colPercentageComplete, Me.colAllowOverrun, Me.colEstimatiedShifts, Me.GridColumn4})
        Me.projectDetailsGridView.GridControl = Me.projectDetailsGridControl
        Me.projectDetailsGridView.Name = "projectDetailsGridView"
        Me.projectDetailsGridView.OptionsBehavior.Editable = False
        Me.projectDetailsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.projectDetailsGridView.OptionsView.ShowDetailButtons = False
        '
        'colItemNumber
        '
        Me.colItemNumber.Caption = "Item #"
        Me.colItemNumber.ColumnEdit = Me.itemRepositoryItemLookUpEdit
        Me.colItemNumber.FieldName = "ProjectItem!Key"
        Me.colItemNumber.Name = "colItemNumber"
        Me.colItemNumber.Visible = True
        Me.colItemNumber.VisibleIndex = 2
        '
        'itemRepositoryItemLookUpEdit
        '
        Me.itemRepositoryItemLookUpEdit.AutoHeight = False
        Me.itemRepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.itemRepositoryItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 59, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CaseQuantity", "Case Quantity", 79, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BagsPerCase", "Bags Per Case", 79, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CasePerPallet", "Case Per Pallet", 82, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.[Default])})
        Me.itemRepositoryItemLookUpEdit.DataSource = Me.itemXpView
        Me.itemRepositoryItemLookUpEdit.DisplayMember = "ItemCode"
        Me.itemRepositoryItemLookUpEdit.Name = "itemRepositoryItemLookUpEdit"
        Me.itemRepositoryItemLookUpEdit.ValueMember = "ItemID"
        '
        'delGridColumn
        '
        Me.delGridColumn.ColumnEdit = Me.deleteRepositoryItemButtonEdit
        Me.delGridColumn.Name = "delGridColumn"
        Me.delGridColumn.OptionsColumn.AllowSize = False
        Me.delGridColumn.Visible = True
        Me.delGridColumn.VisibleIndex = 0
        Me.delGridColumn.Width = 20
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
        Me.colHasChanges.OptionsColumn.ReadOnly = True
        '
        'GridColumn1
        '
        Me.GridColumn1.FieldName = "Project!"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "Project!Key"
        Me.GridColumn2.Name = "GridColumn2"
        '
        'colCustomerPO
        '
        Me.colCustomerPO.FieldName = "CustomerPO"
        Me.colCustomerPO.Name = "colCustomerPO"
        Me.colCustomerPO.Visible = True
        Me.colCustomerPO.VisibleIndex = 1
        Me.colCustomerPO.Width = 49
        '
        'GridColumn3
        '
        Me.GridColumn3.FieldName = "ProjectItem!"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'colUnitsRequested
        '
        Me.colUnitsRequested.FieldName = "UnitsRequested"
        Me.colUnitsRequested.Name = "colUnitsRequested"
        Me.colUnitsRequested.Visible = True
        Me.colUnitsRequested.VisibleIndex = 3
        Me.colUnitsRequested.Width = 49
        '
        'colBagsRequested
        '
        Me.colBagsRequested.FieldName = "BagsRequested"
        Me.colBagsRequested.Name = "colBagsRequested"
        Me.colBagsRequested.Visible = True
        Me.colBagsRequested.VisibleIndex = 4
        Me.colBagsRequested.Width = 49
        '
        'colPalletsRequested
        '
        Me.colPalletsRequested.FieldName = "PalletsRequested"
        Me.colPalletsRequested.Name = "colPalletsRequested"
        Me.colPalletsRequested.Visible = True
        Me.colPalletsRequested.VisibleIndex = 5
        Me.colPalletsRequested.Width = 49
        '
        'colRemainingBalance
        '
        Me.colRemainingBalance.Caption = "Remaining Balance"
        Me.colRemainingBalance.FieldName = "RemainingBalance"
        Me.colRemainingBalance.Name = "colRemainingBalance"
        Me.colRemainingBalance.Visible = True
        Me.colRemainingBalance.VisibleIndex = 11
        '
        'colUnitsProduced
        '
        Me.colUnitsProduced.FieldName = "UnitsProduced"
        Me.colUnitsProduced.Name = "colUnitsProduced"
        Me.colUnitsProduced.OptionsColumn.AllowEdit = False
        Me.colUnitsProduced.Visible = True
        Me.colUnitsProduced.VisibleIndex = 6
        Me.colUnitsProduced.Width = 49
        '
        'colBagsProduced
        '
        Me.colBagsProduced.FieldName = "BagsProduced"
        Me.colBagsProduced.Name = "colBagsProduced"
        Me.colBagsProduced.OptionsColumn.AllowEdit = False
        Me.colBagsProduced.Visible = True
        Me.colBagsProduced.VisibleIndex = 7
        Me.colBagsProduced.Width = 49
        '
        'colPalletsProduced
        '
        Me.colPalletsProduced.FieldName = "PalletsProduced"
        Me.colPalletsProduced.Name = "colPalletsProduced"
        Me.colPalletsProduced.OptionsColumn.AllowEdit = False
        Me.colPalletsProduced.Visible = True
        Me.colPalletsProduced.VisibleIndex = 8
        Me.colPalletsProduced.Width = 49
        '
        'colPercentageComplete
        '
        Me.colPercentageComplete.DisplayFormat.FormatString = "F2"
        Me.colPercentageComplete.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colPercentageComplete.FieldName = "PercentageComplete"
        Me.colPercentageComplete.Name = "colPercentageComplete"
        Me.colPercentageComplete.OptionsColumn.AllowEdit = False
        Me.colPercentageComplete.Visible = True
        Me.colPercentageComplete.VisibleIndex = 9
        Me.colPercentageComplete.Width = 49
        '
        'colAllowOverrun
        '
        Me.colAllowOverrun.FieldName = "AllowOverrun"
        Me.colAllowOverrun.Name = "colAllowOverrun"
        Me.colAllowOverrun.Visible = True
        Me.colAllowOverrun.VisibleIndex = 10
        Me.colAllowOverrun.Width = 63
        '
        'colEstimatiedShifts
        '
        Me.colEstimatiedShifts.DisplayFormat.FormatString = "f2"
        Me.colEstimatiedShifts.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colEstimatiedShifts.FieldName = "EstimatedShifts"
        Me.colEstimatiedShifts.Name = "colEstimatiedShifts"
        Me.colEstimatiedShifts.OptionsColumn.AllowEdit = False
        Me.colEstimatiedShifts.Visible = True
        Me.colEstimatiedShifts.VisibleIndex = 12
        '
        'auditXtraTabPage
        '
        Me.auditXtraTabPage.Controls.Add(Me.detailHistorySimpleButton)
        Me.auditXtraTabPage.Controls.Add(Me.detailHistoryGridControl)
        Me.auditXtraTabPage.Name = "auditXtraTabPage"
        Me.auditXtraTabPage.Size = New System.Drawing.Size(536, 414)
        Me.auditXtraTabPage.Text = "Project History"
        '
        'detailHistorySimpleButton
        '
        Me.detailHistorySimpleButton.Location = New System.Drawing.Point(3, 3)
        Me.detailHistorySimpleButton.Name = "detailHistorySimpleButton"
        Me.detailHistorySimpleButton.Size = New System.Drawing.Size(147, 23)
        Me.detailHistorySimpleButton.TabIndex = 3
        Me.detailHistorySimpleButton.Text = "Retrieve Detail History"
        '
        'detailHistoryGridControl
        '
        Me.detailHistoryGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.detailHistoryGridControl.Location = New System.Drawing.Point(0, 32)
        Me.detailHistoryGridControl.MainView = Me.detailHistoryGridView
        Me.detailHistoryGridControl.MenuManager = Me.BarManager1
        Me.detailHistoryGridControl.Name = "detailHistoryGridControl"
        Me.detailHistoryGridControl.Size = New System.Drawing.Size(529, 382)
        Me.detailHistoryGridControl.TabIndex = 2
        Me.detailHistoryGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.detailHistoryGridView})
        Me.detailHistoryGridControl.Visible = False
        '
        'detailHistoryGridView
        '
        Me.detailHistoryGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.RecordIDGridColumn, Me.DateChangedGridColumn, Me.PropertyNameGridColumn, Me.PrevValueGridColumn, Me.NewValueGridColumn})
        Me.detailHistoryGridView.GridControl = Me.detailHistoryGridControl
        Me.detailHistoryGridView.Name = "detailHistoryGridView"
        '
        'RecordIDGridColumn
        '
        Me.RecordIDGridColumn.FieldName = "RecordID"
        Me.RecordIDGridColumn.Name = "RecordIDGridColumn"
        Me.RecordIDGridColumn.Visible = True
        Me.RecordIDGridColumn.VisibleIndex = 0
        '
        'DateChangedGridColumn
        '
        Me.DateChangedGridColumn.DisplayFormat.FormatString = "d"
        Me.DateChangedGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateChangedGridColumn.FieldName = "DateChanged"
        Me.DateChangedGridColumn.Name = "DateChangedGridColumn"
        Me.DateChangedGridColumn.Visible = True
        Me.DateChangedGridColumn.VisibleIndex = 1
        '
        'PropertyNameGridColumn
        '
        Me.PropertyNameGridColumn.Caption = "Field Name"
        Me.PropertyNameGridColumn.FieldName = "PropertyName"
        Me.PropertyNameGridColumn.Name = "PropertyNameGridColumn"
        Me.PropertyNameGridColumn.Visible = True
        Me.PropertyNameGridColumn.VisibleIndex = 2
        '
        'PrevValueGridColumn
        '
        Me.PrevValueGridColumn.FieldName = "PrevValue"
        Me.PrevValueGridColumn.Name = "PrevValueGridColumn"
        Me.PrevValueGridColumn.Visible = True
        Me.PrevValueGridColumn.VisibleIndex = 3
        '
        'NewValueGridColumn
        '
        Me.NewValueGridColumn.FieldName = "NewValue"
        Me.NewValueGridColumn.Name = "NewValueGridColumn"
        Me.NewValueGridColumn.Visible = True
        Me.NewValueGridColumn.VisibleIndex = 4
        '
        'GridColumn4
        '
        Me.GridColumn4.FieldName = "ProjectItem!"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 13
        '
        'ProjectsXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 514)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ProjectsXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Projects"
        CType(Me.deleteRepositoryItemButtonEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemXpView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.projectSearchGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.projectSearchXpView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.projectSearchGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.projectsXtraTabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.projectsXtraTabControl.ResumeLayout(False)
        Me.dataEntryXtraTabPage.ResumeLayout(False)
        CType(Me.dataEntrySplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dataEntrySplitContainerControl.ResumeLayout(False)
        CType(Me.notesMemoExEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.projectStatusComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reqDeliveryDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reqDeliveryDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reqShipDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reqShipDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reqStartDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reqStartDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.customerLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.customerXpView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.projectTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.oidTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.projectDetailsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.projectDetailsXpCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.projectDetailsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.auditXtraTabPage.ResumeLayout(False)
        CType(Me.detailHistoryGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.detailHistoryGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents projectsBar As DevExpress.XtraBars.Bar
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
    Friend WithEvents dataEntrySplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents projectSearchGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents projectSearchGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents projectSearchXpView As DevExpress.Xpo.XPView
    Friend WithEvents colProjectID As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReqStartDateGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomerGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents oidTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents projectTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents customerLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents customerXpView As DevExpress.Xpo.XPView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents reqStartDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents reqDeliveryDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents reqShipDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents projectStatusComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    'Friend WithEvents scheduledWeekDatePeriodEdit As SuperiorPackGroup.DatePeriodEdit
    Friend WithEvents notesMemoExEdit As DevExpress.XtraEditors.MemoExEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents projectDetailsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents projectDetailsGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents projectDetailsXpCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colHasChanges As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCustomerPO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitsRequested As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBagsRequested As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPalletsRequested As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUnitsProduced As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBagsProduced As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPalletsProduced As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPercentageComplete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAllowOverrun As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents delGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents itemXpView As DevExpress.Xpo.XPView
    Friend WithEvents colEstimatiedShifts As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents projectsXtraTabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents dataEntryXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents auditXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents deleteRepositoryItemButtonEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colItemNumber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents itemRepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents detailHistorySimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents detailHistoryGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents detailHistoryGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RecordIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DateChangedGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PropertyNameGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PrevValueGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NewValueGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents printProductionReportBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents printBomAvailabilityBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents refreshBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents colRemainingBalance As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
End Class
