Imports DXDAL.SPGData

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShippingXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShippingXtraForm))
        Me.shippingXtraTabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.generalXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.locationLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.shippingBar = New DevExpress.XtraBars.Bar()
        Me.addBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.editBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.cancelBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.saveBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.printBOLBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.printPackingListBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.refreshBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Bar3 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.locationXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.freightCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.commentsMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.customerShipperCheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.totalGrossWeightTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.shiftLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.deliveryNoteNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.palletsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.noteMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.destinationMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.destinationLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.carrierLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.poTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.customerLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.customersXPView = New DevExpress.Xpo.XPView(Me.components)
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.skitsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.sealTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.trailerTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.bolTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.shipDateEdit = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.shipmentInfoXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.correctPalletsComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.insectActivityComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.foreignSubstanceComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.wheelsChockedComboBoxEdit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.loadConditionLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.shipmentConditionXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.physicalConditionLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.temparatureSpinEdit = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.finishTimeTimeEdit = New DevExpress.XtraEditors.TimeEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.startTimeTimeEdit = New DevExpress.XtraEditors.TimeEdit()
        Me.checkedByLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.employeeXpView = New DevExpress.Xpo.XPView(Me.components)
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.loadedByLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.detailsXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.lpnNumberTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.shippingGridControl = New DevExpress.XtraGrid.GridControl()
        Me.shippingGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.idGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shippingIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.itemGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.itemRepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.shippingItemXPView = New DevExpress.Xpo.XPView(Me.components)
        Me.descriptionGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lotGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.expirationDateGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.fullLPNNumberGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.quantityGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.palletsGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grossWeightGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.noteGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.noteRepositoryItemMemoExEdit = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.delGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.delRepositoryItemButtonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.returnsXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.returnsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.returnsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.returnIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ShippingMainIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.returnItemGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.returnItemRepositoryItemLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.returnItemXPView = New DevExpress.Xpo.XPView(Me.components)
        Me.returnItemDescGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.returnLotGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.returnExpirationDateGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.returnUnitsGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.returnQuantityGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.returnPalletsGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.returnReasonGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.returnReasonRepositoryItemMemoExEdit = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.returnGrossWeightGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.deleteReturnGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.deleteReturnRepositoryItemButtonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
        Me.shippingSearchGridControl = New DevExpress.XtraGrid.GridControl()
        Me.shippingSearchXPView = New DevExpress.Xpo.XPView(Me.components)
        Me.shippingSearchGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.shippingSearchIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shippingBOLGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shippingCustomerGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shippingDateGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.shippingDateRepositoryItemDateEdit = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        CType(Me.shippingXtraTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.shippingXtraTabControl.SuspendLayout()
        Me.generalXtraTabPage.SuspendLayout()
        CType(Me.locationLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.locationXpView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.freightCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.commentsMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.customerShipperCheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.totalGrossWeightTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shiftLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deliveryNoteNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.palletsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.noteMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.destinationMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.destinationLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carrierLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.poTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.customerLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.customersXPView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skitsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sealTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trailerTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bolTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shipDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shipDateEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.shipmentInfoXtraTabPage.SuspendLayout()
        CType(Me.correctPalletsComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.insectActivityComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.foreignSubstanceComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wheelsChockedComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.loadConditionLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shipmentConditionXpView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.physicalConditionLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.temparatureSpinEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.finishTimeTimeEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.startTimeTimeEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkedByLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.employeeXpView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.loadedByLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.detailsXtraTabPage.SuspendLayout()
        CType(Me.lpnNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shippingGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shippingGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.itemRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shippingItemXPView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.noteRepositoryItemMemoExEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.delRepositoryItemButtonEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.returnsXtraTabPage.SuspendLayout()
        CType(Me.returnsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.returnsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.returnItemRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.returnItemXPView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.returnReasonRepositoryItemMemoExEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deleteReturnRepositoryItemButtonEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerControl1.SuspendLayout()
        CType(Me.shippingSearchGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shippingSearchXPView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shippingSearchGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shippingDateRepositoryItemDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shippingDateRepositoryItemDateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'shippingXtraTabControl
        '
        Me.shippingXtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.shippingXtraTabControl.Location = New System.Drawing.Point(0, 0)
        Me.shippingXtraTabControl.Name = "shippingXtraTabControl"
        Me.shippingXtraTabControl.SelectedTabPage = Me.generalXtraTabPage
        Me.shippingXtraTabControl.Size = New System.Drawing.Size(613, 433)
        Me.shippingXtraTabControl.TabIndex = 4
        Me.shippingXtraTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.generalXtraTabPage, Me.shipmentInfoXtraTabPage, Me.detailsXtraTabPage, Me.returnsXtraTabPage})
        '
        'generalXtraTabPage
        '
        Me.generalXtraTabPage.Controls.Add(Me.locationLookUpEdit)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl28)
        Me.generalXtraTabPage.Controls.Add(Me.freightCheckEdit)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl12)
        Me.generalXtraTabPage.Controls.Add(Me.commentsMemoEdit)
        Me.generalXtraTabPage.Controls.Add(Me.customerShipperCheckEdit)
        Me.generalXtraTabPage.Controls.Add(Me.totalGrossWeightTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl9)
        Me.generalXtraTabPage.Controls.Add(Me.shiftLookUpEdit)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl3)
        Me.generalXtraTabPage.Controls.Add(Me.deliveryNoteNumberTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl1)
        Me.generalXtraTabPage.Controls.Add(Me.palletsTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl16)
        Me.generalXtraTabPage.Controls.Add(Me.noteMemoEdit)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl14)
        Me.generalXtraTabPage.Controls.Add(Me.destinationMemoEdit)
        Me.generalXtraTabPage.Controls.Add(Me.destinationLookUpEdit)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl13)
        Me.generalXtraTabPage.Controls.Add(Me.carrierLookUpEdit)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl11)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl10)
        Me.generalXtraTabPage.Controls.Add(Me.poTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.customerLookUpEdit)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl8)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl7)
        Me.generalXtraTabPage.Controls.Add(Me.skitsTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.sealTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl6)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl5)
        Me.generalXtraTabPage.Controls.Add(Me.trailerTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.bolTextEdit)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl4)
        Me.generalXtraTabPage.Controls.Add(Me.shipDateEdit)
        Me.generalXtraTabPage.Controls.Add(Me.LabelControl2)
        Me.generalXtraTabPage.Name = "generalXtraTabPage"
        Me.generalXtraTabPage.Size = New System.Drawing.Size(607, 405)
        Me.generalXtraTabPage.Text = "General Info"
        '
        'locationLookUpEdit
        '
        Me.locationLookUpEdit.Location = New System.Drawing.Point(387, 189)
        Me.locationLookUpEdit.MenuManager = Me.BarManager1
        Me.locationLookUpEdit.Name = "locationLookUpEdit"
        Me.locationLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.locationLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationID", "Location ID", 77, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationCode", "Location Code", 78, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationName", "Location Name", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.locationLookUpEdit.Properties.DataSource = Me.locationXpView
        Me.locationLookUpEdit.Properties.DisplayMember = "LocationCode"
        Me.locationLookUpEdit.Properties.NullText = "[Select A Location]"
        Me.locationLookUpEdit.Properties.ValueMember = "LocationID"
        Me.locationLookUpEdit.Size = New System.Drawing.Size(190, 20)
        Me.locationLookUpEdit.TabIndex = 44
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.shippingBar, Me.Bar2, Me.Bar3})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.addBarButtonItem, Me.editBarButtonItem, Me.cancelBarButtonItem, Me.saveBarButtonItem, Me.printBOLBarButtonItem, Me.printPackingListBarButtonItem, Me.refreshBarButtonItem})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 7
        Me.BarManager1.StatusBar = Me.Bar3
        '
        'shippingBar
        '
        Me.shippingBar.BarName = "Tools"
        Me.shippingBar.DockCol = 0
        Me.shippingBar.DockRow = 1
        Me.shippingBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.shippingBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.addBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.editBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.cancelBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.saveBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.printBOLBarButtonItem, True), New DevExpress.XtraBars.LinkPersistInfo(Me.printPackingListBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.refreshBarButtonItem, True)})
        Me.shippingBar.OptionsBar.UseWholeRow = True
        Me.shippingBar.Text = "Tools"
        '
        'addBarButtonItem
        '
        Me.addBarButtonItem.Caption = "&Add Shipping"
        Me.addBarButtonItem.Id = 0
        Me.addBarButtonItem.Name = "addBarButtonItem"
        '
        'editBarButtonItem
        '
        Me.editBarButtonItem.Caption = "&Edit Shipping"
        Me.editBarButtonItem.Id = 1
        Me.editBarButtonItem.Name = "editBarButtonItem"
        '
        'cancelBarButtonItem
        '
        Me.cancelBarButtonItem.Caption = "&Cancel Changes"
        Me.cancelBarButtonItem.Id = 2
        Me.cancelBarButtonItem.Name = "cancelBarButtonItem"
        '
        'saveBarButtonItem
        '
        Me.saveBarButtonItem.Caption = "&Save Changes"
        Me.saveBarButtonItem.Id = 3
        Me.saveBarButtonItem.Name = "saveBarButtonItem"
        '
        'printBOLBarButtonItem
        '
        Me.printBOLBarButtonItem.Caption = "Print &BOL"
        Me.printBOLBarButtonItem.Id = 4
        Me.printBOLBarButtonItem.Name = "printBOLBarButtonItem"
        '
        'printPackingListBarButtonItem
        '
        Me.printPackingListBarButtonItem.Caption = "Print &Packing LIst"
        Me.printPackingListBarButtonItem.Id = 5
        Me.printPackingListBarButtonItem.Name = "printPackingListBarButtonItem"
        '
        'refreshBarButtonItem
        '
        Me.refreshBarButtonItem.Caption = "Re&fresh"
        Me.refreshBarButtonItem.Id = 6
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
        Me.barDockControlTop.Size = New System.Drawing.Size(868, 49)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 482)
        Me.barDockControlBottom.Size = New System.Drawing.Size(868, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 49)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 433)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(868, 49)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 433)
        '
        'locationXpView
        '
        Me.locationXpView.CriteriaString = "[CanShip] = True"
        Me.locationXpView.ObjectType = GetType(DXDAL.SPGData.Locations)
        Me.locationXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("LocationID", DevExpress.Xpo.SortDirection.None, "[Oid]", False, True), New DevExpress.Xpo.ViewProperty("LocationCode", DevExpress.Xpo.SortDirection.None, "[LocationCode]", False, True), New DevExpress.Xpo.ViewProperty("LocationName", DevExpress.Xpo.SortDirection.None, "[LocationName]", False, True)})
        '
        'LabelControl28
        '
        Me.LabelControl28.Location = New System.Drawing.Point(286, 193)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(71, 13)
        Me.LabelControl28.TabIndex = 43
        Me.LabelControl28.Text = "Shipping From:"
        '
        'freightCheckEdit
        '
        Me.freightCheckEdit.Location = New System.Drawing.Point(387, 319)
        Me.freightCheckEdit.Name = "freightCheckEdit"
        Me.freightCheckEdit.Properties.Caption = "Charge Freight"
        Me.freightCheckEdit.Size = New System.Drawing.Size(190, 19)
        Me.freightCheckEdit.TabIndex = 42
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(14, 245)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl12.TabIndex = 41
        Me.LabelControl12.Text = "Comments"
        '
        'commentsMemoEdit
        '
        Me.commentsMemoEdit.Location = New System.Drawing.Point(105, 242)
        Me.commentsMemoEdit.Name = "commentsMemoEdit"
        Me.commentsMemoEdit.Size = New System.Drawing.Size(175, 71)
        Me.commentsMemoEdit.TabIndex = 40
        '
        'customerShipperCheckEdit
        '
        Me.customerShipperCheckEdit.Location = New System.Drawing.Point(385, 60)
        Me.customerShipperCheckEdit.Name = "customerShipperCheckEdit"
        Me.customerShipperCheckEdit.Properties.Caption = "Customer is Shipper"
        Me.customerShipperCheckEdit.Size = New System.Drawing.Size(192, 19)
        Me.customerShipperCheckEdit.TabIndex = 39
        '
        'totalGrossWeightTextEdit
        '
        Me.totalGrossWeightTextEdit.Location = New System.Drawing.Point(387, 344)
        Me.totalGrossWeightTextEdit.Name = "totalGrossWeightTextEdit"
        Me.totalGrossWeightTextEdit.Properties.DisplayFormat.FormatString = "f2"
        Me.totalGrossWeightTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.totalGrossWeightTextEdit.Properties.ReadOnly = True
        Me.totalGrossWeightTextEdit.Size = New System.Drawing.Size(190, 20)
        Me.totalGrossWeightTextEdit.TabIndex = 38
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(286, 347)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl9.TabIndex = 37
        Me.LabelControl9.Text = "Total Gross Weight:"
        '
        'shiftLookUpEdit
        '
        Me.shiftLookUpEdit.Location = New System.Drawing.Point(105, 86)
        Me.shiftLookUpEdit.Name = "shiftLookUpEdit"
        Me.shiftLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.shiftLookUpEdit.Properties.NullText = "[Select A Shift]"
        Me.shiftLookUpEdit.Size = New System.Drawing.Size(175, 20)
        Me.shiftLookUpEdit.TabIndex = 36
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(14, 88)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(26, 13)
        Me.LabelControl3.TabIndex = 35
        Me.LabelControl3.Text = "Shift:"
        '
        'deliveryNoteNumberTextEdit
        '
        Me.deliveryNoteNumberTextEdit.Location = New System.Drawing.Point(387, 215)
        Me.deliveryNoteNumberTextEdit.Name = "deliveryNoteNumberTextEdit"
        Me.deliveryNoteNumberTextEdit.Size = New System.Drawing.Size(190, 20)
        Me.deliveryNoteNumberTextEdit.TabIndex = 34
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(286, 218)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(80, 13)
        Me.LabelControl1.TabIndex = 33
        Me.LabelControl1.Text = "Delivery Note #:"
        '
        'palletsTextEdit
        '
        Me.palletsTextEdit.Location = New System.Drawing.Point(105, 345)
        Me.palletsTextEdit.Name = "palletsTextEdit"
        Me.palletsTextEdit.Properties.ReadOnly = True
        Me.palletsTextEdit.Size = New System.Drawing.Size(175, 20)
        Me.palletsTextEdit.TabIndex = 32
        Me.palletsTextEdit.TabStop = False
        '
        'LabelControl16
        '
        Me.LabelControl16.Location = New System.Drawing.Point(15, 350)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(62, 13)
        Me.LabelControl16.TabIndex = 31
        Me.LabelControl16.Text = "Total Pallets:"
        '
        'noteMemoEdit
        '
        Me.noteMemoEdit.Location = New System.Drawing.Point(387, 244)
        Me.noteMemoEdit.Name = "noteMemoEdit"
        Me.noteMemoEdit.Size = New System.Drawing.Size(190, 69)
        Me.noteMemoEdit.TabIndex = 30
        '
        'LabelControl14
        '
        Me.LabelControl14.Location = New System.Drawing.Point(286, 247)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl14.TabIndex = 29
        Me.LabelControl14.Text = "Delivery Note:"
        '
        'destinationMemoEdit
        '
        Me.destinationMemoEdit.Location = New System.Drawing.Point(387, 85)
        Me.destinationMemoEdit.Name = "destinationMemoEdit"
        Me.destinationMemoEdit.Properties.ReadOnly = True
        Me.destinationMemoEdit.Size = New System.Drawing.Size(190, 98)
        Me.destinationMemoEdit.TabIndex = 26
        Me.destinationMemoEdit.TabStop = False
        '
        'destinationLookUpEdit
        '
        Me.destinationLookUpEdit.Location = New System.Drawing.Point(387, 34)
        Me.destinationLookUpEdit.Name = "destinationLookUpEdit"
        Me.destinationLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.destinationLookUpEdit.Properties.NullText = "[Select A Destination]"
        Me.destinationLookUpEdit.Size = New System.Drawing.Size(190, 20)
        Me.destinationLookUpEdit.TabIndex = 25
        '
        'LabelControl13
        '
        Me.LabelControl13.Location = New System.Drawing.Point(286, 37)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl13.TabIndex = 24
        Me.LabelControl13.Text = "Destination:"
        '
        'carrierLookUpEdit
        '
        Me.carrierLookUpEdit.Location = New System.Drawing.Point(105, 164)
        Me.carrierLookUpEdit.Name = "carrierLookUpEdit"
        Me.carrierLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.carrierLookUpEdit.Properties.NullText = "[Select A Carrier]"
        Me.carrierLookUpEdit.Size = New System.Drawing.Size(175, 20)
        Me.carrierLookUpEdit.TabIndex = 15
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(14, 166)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl11.TabIndex = 14
        Me.LabelControl11.Text = "Carrier:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(14, 114)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl10.TabIndex = 8
        Me.LabelControl10.Text = "PO Number:"
        '
        'poTextEdit
        '
        Me.poTextEdit.Location = New System.Drawing.Point(105, 112)
        Me.poTextEdit.Name = "poTextEdit"
        Me.poTextEdit.Size = New System.Drawing.Size(175, 20)
        Me.poTextEdit.TabIndex = 9
        '
        'customerLookUpEdit
        '
        Me.customerLookUpEdit.Location = New System.Drawing.Point(105, 34)
        Me.customerLookUpEdit.Name = "customerLookUpEdit"
        Me.customerLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.customerLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerID", "Customer ID", 83, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Customer Name", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.customerLookUpEdit.Properties.DataSource = Me.customersXPView
        Me.customerLookUpEdit.Properties.DisplayMember = "CustomerName"
        Me.customerLookUpEdit.Properties.NullText = "[Select A Customer]"
        Me.customerLookUpEdit.Properties.ValueMember = "CustomerID"
        Me.customerLookUpEdit.Size = New System.Drawing.Size(175, 20)
        Me.customerLookUpEdit.TabIndex = 5
        '
        'customersXPView
        '
        Me.customersXPView.CriteriaString = "[Inactive] = False"
        Me.customersXPView.ObjectType = GetType(DXDAL.SPGData.Customers)
        Me.customersXPView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[CustomerID]", False, True), New DevExpress.Xpo.ViewProperty("CustomerName", DevExpress.Xpo.SortDirection.Ascending, "[CustomerName]", False, True), New DevExpress.Xpo.ViewProperty("Inactive", DevExpress.Xpo.SortDirection.None, "[Inactive]", False, True)})
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(14, 36)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl8.TabIndex = 4
        Me.LabelControl8.Text = "Customer:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(14, 322)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl7.TabIndex = 22
        Me.LabelControl7.Text = "Additional Pallets:"
        '
        'skitsTextEdit
        '
        Me.skitsTextEdit.Location = New System.Drawing.Point(105, 319)
        Me.skitsTextEdit.Name = "skitsTextEdit"
        Me.skitsTextEdit.Size = New System.Drawing.Size(175, 20)
        Me.skitsTextEdit.TabIndex = 23
        '
        'sealTextEdit
        '
        Me.sealTextEdit.Location = New System.Drawing.Point(105, 216)
        Me.sealTextEdit.Name = "sealTextEdit"
        Me.sealTextEdit.Size = New System.Drawing.Size(175, 20)
        Me.sealTextEdit.TabIndex = 21
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(14, 218)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl6.TabIndex = 20
        Me.LabelControl6.Text = "Seal Number:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(14, 192)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl5.TabIndex = 16
        Me.LabelControl5.Text = "Trailer Number:"
        '
        'trailerTextEdit
        '
        Me.trailerTextEdit.Location = New System.Drawing.Point(105, 190)
        Me.trailerTextEdit.Name = "trailerTextEdit"
        Me.trailerTextEdit.Size = New System.Drawing.Size(175, 20)
        Me.trailerTextEdit.TabIndex = 17
        '
        'bolTextEdit
        '
        Me.bolTextEdit.Location = New System.Drawing.Point(105, 138)
        Me.bolTextEdit.Name = "bolTextEdit"
        Me.bolTextEdit.Properties.NullText = "[Generated when saved]"
        Me.bolTextEdit.Size = New System.Drawing.Size(175, 20)
        Me.bolTextEdit.TabIndex = 11
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(14, 140)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl4.TabIndex = 10
        Me.LabelControl4.Text = "BOL Number:"
        '
        'shipDateEdit
        '
        Me.shipDateEdit.EditValue = Nothing
        Me.shipDateEdit.Location = New System.Drawing.Point(105, 60)
        Me.shipDateEdit.Name = "shipDateEdit"
        Me.shipDateEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.shipDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.shipDateEdit.Properties.Mask.EditMask = "D"
        Me.shipDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret
        Me.shipDateEdit.Properties.NullText = "[Select A Date]"
        Me.shipDateEdit.Size = New System.Drawing.Size(175, 20)
        Me.shipDateEdit.TabIndex = 3
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(14, 62)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Date:"
        '
        'shipmentInfoXtraTabPage
        '
        Me.shipmentInfoXtraTabPage.Controls.Add(Me.correctPalletsComboBoxEdit)
        Me.shipmentInfoXtraTabPage.Controls.Add(Me.LabelControl24)
        Me.shipmentInfoXtraTabPage.Controls.Add(Me.insectActivityComboBoxEdit)
        Me.shipmentInfoXtraTabPage.Controls.Add(Me.LabelControl25)
        Me.shipmentInfoXtraTabPage.Controls.Add(Me.foreignSubstanceComboBoxEdit)
        Me.shipmentInfoXtraTabPage.Controls.Add(Me.LabelControl26)
        Me.shipmentInfoXtraTabPage.Controls.Add(Me.wheelsChockedComboBoxEdit)
        Me.shipmentInfoXtraTabPage.Controls.Add(Me.LabelControl27)
        Me.shipmentInfoXtraTabPage.Controls.Add(Me.loadConditionLookUpEdit)
        Me.shipmentInfoXtraTabPage.Controls.Add(Me.physicalConditionLookUpEdit)
        Me.shipmentInfoXtraTabPage.Controls.Add(Me.LabelControl23)
        Me.shipmentInfoXtraTabPage.Controls.Add(Me.LabelControl22)
        Me.shipmentInfoXtraTabPage.Controls.Add(Me.LabelControl21)
        Me.shipmentInfoXtraTabPage.Controls.Add(Me.temparatureSpinEdit)
        Me.shipmentInfoXtraTabPage.Controls.Add(Me.LabelControl20)
        Me.shipmentInfoXtraTabPage.Controls.Add(Me.finishTimeTimeEdit)
        Me.shipmentInfoXtraTabPage.Controls.Add(Me.LabelControl19)
        Me.shipmentInfoXtraTabPage.Controls.Add(Me.startTimeTimeEdit)
        Me.shipmentInfoXtraTabPage.Controls.Add(Me.checkedByLookUpEdit)
        Me.shipmentInfoXtraTabPage.Controls.Add(Me.LabelControl18)
        Me.shipmentInfoXtraTabPage.Controls.Add(Me.LabelControl17)
        Me.shipmentInfoXtraTabPage.Controls.Add(Me.loadedByLookUpEdit)
        Me.shipmentInfoXtraTabPage.Name = "shipmentInfoXtraTabPage"
        Me.shipmentInfoXtraTabPage.Size = New System.Drawing.Size(607, 405)
        Me.shipmentInfoXtraTabPage.Text = "Shipment Info"
        '
        'correctPalletsComboBoxEdit
        '
        Me.correctPalletsComboBoxEdit.Location = New System.Drawing.Point(126, 275)
        Me.correctPalletsComboBoxEdit.MenuManager = Me.BarManager1
        Me.correctPalletsComboBoxEdit.Name = "correctPalletsComboBoxEdit"
        Me.correctPalletsComboBoxEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.correctPalletsComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.correctPalletsComboBoxEdit.Properties.DropDownRows = 3
        Me.correctPalletsComboBoxEdit.Properties.Items.AddRange(New Object() {"Yes", "No"})
        Me.correctPalletsComboBoxEdit.Size = New System.Drawing.Size(48, 20)
        Me.correctPalletsComboBoxEdit.TabIndex = 57
        '
        'LabelControl24
        '
        Me.LabelControl24.Location = New System.Drawing.Point(46, 277)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl24.TabIndex = 56
        Me.LabelControl24.Text = "Correct Pallets:"
        '
        'insectActivityComboBoxEdit
        '
        Me.insectActivityComboBoxEdit.Location = New System.Drawing.Point(126, 249)
        Me.insectActivityComboBoxEdit.MenuManager = Me.BarManager1
        Me.insectActivityComboBoxEdit.Name = "insectActivityComboBoxEdit"
        Me.insectActivityComboBoxEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.insectActivityComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.insectActivityComboBoxEdit.Properties.DropDownRows = 3
        Me.insectActivityComboBoxEdit.Properties.Items.AddRange(New Object() {"Yes", "No"})
        Me.insectActivityComboBoxEdit.Size = New System.Drawing.Size(48, 20)
        Me.insectActivityComboBoxEdit.TabIndex = 55
        '
        'LabelControl25
        '
        Me.LabelControl25.Location = New System.Drawing.Point(8, 252)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(112, 13)
        Me.LabelControl25.TabIndex = 54
        Me.LabelControl25.Text = "Insect/Rodent Activity:"
        '
        'foreignSubstanceComboBoxEdit
        '
        Me.foreignSubstanceComboBoxEdit.Location = New System.Drawing.Point(126, 223)
        Me.foreignSubstanceComboBoxEdit.MenuManager = Me.BarManager1
        Me.foreignSubstanceComboBoxEdit.Name = "foreignSubstanceComboBoxEdit"
        Me.foreignSubstanceComboBoxEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.foreignSubstanceComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.foreignSubstanceComboBoxEdit.Properties.DropDownRows = 3
        Me.foreignSubstanceComboBoxEdit.Properties.Items.AddRange(New Object() {"Yes", "No"})
        Me.foreignSubstanceComboBoxEdit.Size = New System.Drawing.Size(48, 20)
        Me.foreignSubstanceComboBoxEdit.TabIndex = 53
        '
        'LabelControl26
        '
        Me.LabelControl26.Location = New System.Drawing.Point(27, 226)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl26.TabIndex = 52
        Me.LabelControl26.Text = "Foreign Substance:"
        '
        'wheelsChockedComboBoxEdit
        '
        Me.wheelsChockedComboBoxEdit.Location = New System.Drawing.Point(126, 197)
        Me.wheelsChockedComboBoxEdit.MenuManager = Me.BarManager1
        Me.wheelsChockedComboBoxEdit.Name = "wheelsChockedComboBoxEdit"
        Me.wheelsChockedComboBoxEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.wheelsChockedComboBoxEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.wheelsChockedComboBoxEdit.Properties.DropDownRows = 3
        Me.wheelsChockedComboBoxEdit.Properties.Items.AddRange(New Object() {"Yes", "No"})
        Me.wheelsChockedComboBoxEdit.Size = New System.Drawing.Size(48, 20)
        Me.wheelsChockedComboBoxEdit.TabIndex = 51
        '
        'LabelControl27
        '
        Me.LabelControl27.Location = New System.Drawing.Point(37, 200)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(83, 13)
        Me.LabelControl27.TabIndex = 50
        Me.LabelControl27.Text = "Wheels Chocked:"
        '
        'loadConditionLookUpEdit
        '
        Me.loadConditionLookUpEdit.Location = New System.Drawing.Point(399, 118)
        Me.loadConditionLookUpEdit.MenuManager = Me.BarManager1
        Me.loadConditionLookUpEdit.Name = "loadConditionLookUpEdit"
        Me.loadConditionLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.loadConditionLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.loadConditionLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("recordID", "record ID", 68, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Condition", "Condition", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.loadConditionLookUpEdit.Properties.DataSource = Me.shipmentConditionXpView
        Me.loadConditionLookUpEdit.Properties.DisplayMember = "Condition"
        Me.loadConditionLookUpEdit.Properties.NullText = "[Select Condition]"
        Me.loadConditionLookUpEdit.Properties.ValueMember = "recordID"
        Me.loadConditionLookUpEdit.Size = New System.Drawing.Size(179, 20)
        Me.loadConditionLookUpEdit.TabIndex = 7
        '
        'shipmentConditionXpView
        '
        Me.shipmentConditionXpView.ObjectType = GetType(DXDAL.SPGData.ShipmentConditions)
        Me.shipmentConditionXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("recordID", DevExpress.Xpo.SortDirection.None, "[Oid]", False, True), New DevExpress.Xpo.ViewProperty("Condition", DevExpress.Xpo.SortDirection.None, "[ShipmentCondition]", False, True)})
        '
        'physicalConditionLookUpEdit
        '
        Me.physicalConditionLookUpEdit.Location = New System.Drawing.Point(127, 118)
        Me.physicalConditionLookUpEdit.MenuManager = Me.BarManager1
        Me.physicalConditionLookUpEdit.Name = "physicalConditionLookUpEdit"
        Me.physicalConditionLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.physicalConditionLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.physicalConditionLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("recordID", "record ID", 68, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Condition", "Condition", 55, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.physicalConditionLookUpEdit.Properties.DataSource = Me.shipmentConditionXpView
        Me.physicalConditionLookUpEdit.Properties.DisplayMember = "Condition"
        Me.physicalConditionLookUpEdit.Properties.NullText = "[Select Condition]"
        Me.physicalConditionLookUpEdit.Properties.ValueMember = "recordID"
        Me.physicalConditionLookUpEdit.Size = New System.Drawing.Size(180, 20)
        Me.physicalConditionLookUpEdit.TabIndex = 5
        '
        'LabelControl23
        '
        Me.LabelControl23.Location = New System.Drawing.Point(317, 121)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl23.TabIndex = 6
        Me.LabelControl23.Text = "Load Condition:"
        '
        'LabelControl22
        '
        Me.LabelControl22.Location = New System.Drawing.Point(29, 121)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(90, 13)
        Me.LabelControl22.TabIndex = 4
        Me.LabelControl22.Text = "Physical Condition:"
        '
        'LabelControl21
        '
        Me.LabelControl21.Location = New System.Drawing.Point(53, 174)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl21.TabIndex = 12
        Me.LabelControl21.Text = "Temperature:"
        '
        'temparatureSpinEdit
        '
        Me.temparatureSpinEdit.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.temparatureSpinEdit.Location = New System.Drawing.Point(127, 171)
        Me.temparatureSpinEdit.MenuManager = Me.BarManager1
        Me.temparatureSpinEdit.Name = "temparatureSpinEdit"
        Me.temparatureSpinEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.temparatureSpinEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.temparatureSpinEdit.Properties.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.temparatureSpinEdit.Properties.NullText = "[Enter Temperature]"
        Me.temparatureSpinEdit.Size = New System.Drawing.Size(116, 20)
        Me.temparatureSpinEdit.TabIndex = 13
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(332, 147)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl20.TabIndex = 10
        Me.LabelControl20.Text = "Finish Time:"
        '
        'finishTimeTimeEdit
        '
        Me.finishTimeTimeEdit.EditValue = Nothing
        Me.finishTimeTimeEdit.Location = New System.Drawing.Point(398, 143)
        Me.finishTimeTimeEdit.MenuManager = Me.BarManager1
        Me.finishTimeTimeEdit.Name = "finishTimeTimeEdit"
        Me.finishTimeTimeEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.finishTimeTimeEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.finishTimeTimeEdit.Properties.NullText = "[Enter Finish Time]"
        Me.finishTimeTimeEdit.Size = New System.Drawing.Size(117, 20)
        Me.finishTimeTimeEdit.TabIndex = 11
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(66, 147)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(53, 13)
        Me.LabelControl19.TabIndex = 8
        Me.LabelControl19.Text = "Start Time:"
        '
        'startTimeTimeEdit
        '
        Me.startTimeTimeEdit.EditValue = Nothing
        Me.startTimeTimeEdit.Location = New System.Drawing.Point(126, 144)
        Me.startTimeTimeEdit.MenuManager = Me.BarManager1
        Me.startTimeTimeEdit.Name = "startTimeTimeEdit"
        Me.startTimeTimeEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.startTimeTimeEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.startTimeTimeEdit.Properties.NullText = "[Enter Start Time]"
        Me.startTimeTimeEdit.Size = New System.Drawing.Size(117, 20)
        Me.startTimeTimeEdit.TabIndex = 9
        '
        'checkedByLookUpEdit
        '
        Me.checkedByLookUpEdit.Location = New System.Drawing.Point(398, 92)
        Me.checkedByLookUpEdit.MenuManager = Me.BarManager1
        Me.checkedByLookUpEdit.Name = "checkedByLookUpEdit"
        Me.checkedByLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.checkedByLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.checkedByLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("recordID", "record ID", 68, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Employee Name", "Employee Name", 86, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.checkedByLookUpEdit.Properties.DataSource = Me.employeeXpView
        Me.checkedByLookUpEdit.Properties.DisplayMember = "Employee Name"
        Me.checkedByLookUpEdit.Properties.NullText = "[Select Employee Name]"
        Me.checkedByLookUpEdit.Properties.ValueMember = "recordID"
        Me.checkedByLookUpEdit.Size = New System.Drawing.Size(180, 20)
        Me.checkedByLookUpEdit.TabIndex = 3
        '
        'employeeXpView
        '
        Me.employeeXpView.ObjectType = GetType(DXDAL.SPGData.Employees)
        Me.employeeXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("recordID", DevExpress.Xpo.SortDirection.None, "[Oid]", False, True), New DevExpress.Xpo.ViewProperty("Employee Name", DevExpress.Xpo.SortDirection.Ascending, "[LastName] + ', ' + [FirstName]", False, True)})
        '
        'LabelControl18
        '
        Me.LabelControl18.Location = New System.Drawing.Point(332, 95)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl18.TabIndex = 2
        Me.LabelControl18.Text = "Checked By:"
        '
        'LabelControl17
        '
        Me.LabelControl17.Location = New System.Drawing.Point(66, 95)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl17.TabIndex = 1
        Me.LabelControl17.Text = "Loaded By:"
        '
        'loadedByLookUpEdit
        '
        Me.loadedByLookUpEdit.Location = New System.Drawing.Point(126, 92)
        Me.loadedByLookUpEdit.MenuManager = Me.BarManager1
        Me.loadedByLookUpEdit.Name = "loadedByLookUpEdit"
        Me.loadedByLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.loadedByLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.loadedByLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("recordID", "record ID", 68, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Employee Name", "Employee Name", 86, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.loadedByLookUpEdit.Properties.DataSource = Me.employeeXpView
        Me.loadedByLookUpEdit.Properties.DisplayMember = "Employee Name"
        Me.loadedByLookUpEdit.Properties.NullText = "[Select Employee Name]"
        Me.loadedByLookUpEdit.Properties.ValueMember = "recordID"
        Me.loadedByLookUpEdit.Size = New System.Drawing.Size(180, 20)
        Me.loadedByLookUpEdit.TabIndex = 0
        '
        'detailsXtraTabPage
        '
        Me.detailsXtraTabPage.Controls.Add(Me.lpnNumberTextEdit)
        Me.detailsXtraTabPage.Controls.Add(Me.LabelControl15)
        Me.detailsXtraTabPage.Controls.Add(Me.shippingGridControl)
        Me.detailsXtraTabPage.Name = "detailsXtraTabPage"
        Me.detailsXtraTabPage.Size = New System.Drawing.Size(607, 405)
        Me.detailsXtraTabPage.Text = "Shipping Details"
        '
        'lpnNumberTextEdit
        '
        Me.lpnNumberTextEdit.Location = New System.Drawing.Point(252, 3)
        Me.lpnNumberTextEdit.Name = "lpnNumberTextEdit"
        Me.lpnNumberTextEdit.Size = New System.Drawing.Size(175, 20)
        Me.lpnNumberTextEdit.TabIndex = 10
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(164, 6)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(82, 13)
        Me.LabelControl15.TabIndex = 6
        Me.LabelControl15.Text = "Import from LPN:"
        '
        'shippingGridControl
        '
        Me.shippingGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.shippingGridControl.Location = New System.Drawing.Point(0, 29)
        Me.shippingGridControl.MainView = Me.shippingGridView
        Me.shippingGridControl.Name = "shippingGridControl"
        Me.shippingGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.itemRepositoryItemLookUpEdit, Me.noteRepositoryItemMemoExEdit, Me.RepositoryItemButtonEdit1, Me.delRepositoryItemButtonEdit, Me.RepositoryItemDateEdit1})
        Me.shippingGridControl.Size = New System.Drawing.Size(607, 374)
        Me.shippingGridControl.TabIndex = 0
        Me.shippingGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.shippingGridView})
        '
        'shippingGridView
        '
        Me.shippingGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.idGridColumn, Me.shippingIDGridColumn, Me.itemGridColumn, Me.descriptionGridColumn, Me.lotGridColumn, Me.expirationDateGridColumn, Me.fullLPNNumberGridColumn, Me.quantityGridColumn, Me.palletsGridColumn, Me.grossWeightGridColumn, Me.noteGridColumn, Me.delGridColumn})
        Me.shippingGridView.GridControl = Me.shippingGridControl
        Me.shippingGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ShipDetDetQty", Me.quantityGridColumn, "{0:#,##0.######}")})
        Me.shippingGridView.Name = "shippingGridView"
        Me.shippingGridView.OptionsSelection.MultiSelect = True
        Me.shippingGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        '
        'idGridColumn
        '
        Me.idGridColumn.Caption = "GridColumn1"
        Me.idGridColumn.Name = "idGridColumn"
        '
        'shippingIDGridColumn
        '
        Me.shippingIDGridColumn.Caption = "GridColumn1"
        Me.shippingIDGridColumn.Name = "shippingIDGridColumn"
        '
        'itemGridColumn
        '
        Me.itemGridColumn.Caption = "Item Number"
        Me.itemGridColumn.ColumnEdit = Me.itemRepositoryItemLookUpEdit
        Me.itemGridColumn.Name = "itemGridColumn"
        Me.itemGridColumn.Visible = True
        Me.itemGridColumn.VisibleIndex = 2
        Me.itemGridColumn.Width = 73
        '
        'itemRepositoryItemLookUpEdit
        '
        Me.itemRepositoryItemLookUpEdit.AutoHeight = False
        Me.itemRepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.itemRepositoryItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 59, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.itemRepositoryItemLookUpEdit.DataSource = Me.shippingItemXPView
        Me.itemRepositoryItemLookUpEdit.DisplayMember = "ItemCode"
        Me.itemRepositoryItemLookUpEdit.ImmediatePopup = True
        Me.itemRepositoryItemLookUpEdit.Name = "itemRepositoryItemLookUpEdit"
        Me.itemRepositoryItemLookUpEdit.NullText = ""
        Me.itemRepositoryItemLookUpEdit.NullValuePrompt = "[Select A Item]"
        Me.itemRepositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.itemRepositoryItemLookUpEdit.ValueMember = "ItemID"
        '
        'shippingItemXPView
        '
        Me.shippingItemXPView.CriteriaString = "[ItemType] = 'FG'"
        Me.shippingItemXPView.ObjectType = GetType(DXDAL.SPGData.Items)
        Me.shippingItemXPView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[ItemID]", False, True), New DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[ItemCode]", False, True), New DevExpress.Xpo.ViewProperty("ItemCustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID]", False, True), New DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID.CustomerID]", False, True), New DevExpress.Xpo.ViewProperty("Inactive", DevExpress.Xpo.SortDirection.None, "[Inactive]", False, True)})
        '
        'descriptionGridColumn
        '
        Me.descriptionGridColumn.Caption = "Item Description"
        Me.descriptionGridColumn.FieldName = "descriptionGridColumn"
        Me.descriptionGridColumn.Name = "descriptionGridColumn"
        Me.descriptionGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.descriptionGridColumn.Visible = True
        Me.descriptionGridColumn.VisibleIndex = 3
        Me.descriptionGridColumn.Width = 73
        '
        'lotGridColumn
        '
        Me.lotGridColumn.Caption = "Lot #"
        Me.lotGridColumn.Name = "lotGridColumn"
        Me.lotGridColumn.Visible = True
        Me.lotGridColumn.VisibleIndex = 4
        Me.lotGridColumn.Width = 73
        '
        'expirationDateGridColumn
        '
        Me.expirationDateGridColumn.Caption = "Expiration Date"
        Me.expirationDateGridColumn.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.expirationDateGridColumn.DisplayFormat.FormatString = "d"
        Me.expirationDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.expirationDateGridColumn.Name = "expirationDateGridColumn"
        Me.expirationDateGridColumn.Visible = True
        Me.expirationDateGridColumn.VisibleIndex = 5
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'fullLPNNumberGridColumn
        '
        Me.fullLPNNumberGridColumn.Caption = "LPN Number"
        Me.fullLPNNumberGridColumn.Name = "fullLPNNumberGridColumn"
        Me.fullLPNNumberGridColumn.Visible = True
        Me.fullLPNNumberGridColumn.VisibleIndex = 1
        '
        'quantityGridColumn
        '
        Me.quantityGridColumn.Caption = "Quantity"
        Me.quantityGridColumn.Name = "quantityGridColumn"
        Me.quantityGridColumn.Visible = True
        Me.quantityGridColumn.VisibleIndex = 6
        Me.quantityGridColumn.Width = 73
        '
        'palletsGridColumn
        '
        Me.palletsGridColumn.Caption = "Pallets"
        Me.palletsGridColumn.DisplayFormat.FormatString = "f2"
        Me.palletsGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.palletsGridColumn.Name = "palletsGridColumn"
        Me.palletsGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.palletsGridColumn.Visible = True
        Me.palletsGridColumn.VisibleIndex = 8
        Me.palletsGridColumn.Width = 73
        '
        'grossWeightGridColumn
        '
        Me.grossWeightGridColumn.Caption = "Gross Weight"
        Me.grossWeightGridColumn.DisplayFormat.FormatString = "f2"
        Me.grossWeightGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.grossWeightGridColumn.FieldName = "grossWeightGridColumn"
        Me.grossWeightGridColumn.Name = "grossWeightGridColumn"
        Me.grossWeightGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.grossWeightGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.grossWeightGridColumn.Visible = True
        Me.grossWeightGridColumn.VisibleIndex = 7
        Me.grossWeightGridColumn.Width = 73
        '
        'noteGridColumn
        '
        Me.noteGridColumn.Caption = "Note"
        Me.noteGridColumn.ColumnEdit = Me.noteRepositoryItemMemoExEdit
        Me.noteGridColumn.Name = "noteGridColumn"
        Me.noteGridColumn.Visible = True
        Me.noteGridColumn.VisibleIndex = 9
        Me.noteGridColumn.Width = 73
        '
        'noteRepositoryItemMemoExEdit
        '
        Me.noteRepositoryItemMemoExEdit.AutoHeight = False
        Me.noteRepositoryItemMemoExEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.noteRepositoryItemMemoExEdit.Name = "noteRepositoryItemMemoExEdit"
        '
        'delGridColumn
        '
        Me.delGridColumn.ColumnEdit = Me.delRepositoryItemButtonEdit
        Me.delGridColumn.MaxWidth = 30
        Me.delGridColumn.MinWidth = 25
        Me.delGridColumn.Name = "delGridColumn"
        Me.delGridColumn.Visible = True
        Me.delGridColumn.VisibleIndex = 0
        Me.delGridColumn.Width = 25
        '
        'delRepositoryItemButtonEdit
        '
        Me.delRepositoryItemButtonEdit.AutoHeight = False
        Me.delRepositoryItemButtonEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.delRepositoryItemButtonEdit.Name = "delRepositoryItemButtonEdit"
        Me.delRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        '
        'returnsXtraTabPage
        '
        Me.returnsXtraTabPage.Controls.Add(Me.returnsGridControl)
        Me.returnsXtraTabPage.Name = "returnsXtraTabPage"
        Me.returnsXtraTabPage.Size = New System.Drawing.Size(607, 405)
        Me.returnsXtraTabPage.Text = "Return Details"
        '
        'returnsGridControl
        '
        Me.returnsGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.returnsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.returnsGridControl.MainView = Me.returnsGridView
        Me.returnsGridControl.Name = "returnsGridControl"
        Me.returnsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.returnItemRepositoryItemLookUpEdit, Me.returnReasonRepositoryItemMemoExEdit, Me.deleteReturnRepositoryItemButtonEdit, Me.RepositoryItemDateEdit2})
        Me.returnsGridControl.Size = New System.Drawing.Size(607, 405)
        Me.returnsGridControl.TabIndex = 0
        Me.returnsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.returnsGridView})
        '
        'returnsGridView
        '
        Me.returnsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.returnIDGridColumn, Me.ShippingMainIDGridColumn, Me.returnItemGridColumn, Me.returnItemDescGridColumn, Me.returnLotGridColumn, Me.returnExpirationDateGridColumn, Me.returnUnitsGridColumn, Me.returnQuantityGridColumn, Me.returnPalletsGridColumn, Me.returnReasonGridColumn, Me.returnGrossWeightGridColumn, Me.deleteReturnGridColumn})
        Me.returnsGridView.GridControl = Me.returnsGridControl
        Me.returnsGridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ReturnDetQty", Me.returnQuantityGridColumn, "{0:#,##0.######}")})
        Me.returnsGridView.Name = "returnsGridView"
        Me.returnsGridView.OptionsSelection.MultiSelect = True
        Me.returnsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        '
        'returnIDGridColumn
        '
        Me.returnIDGridColumn.Caption = "GridColumn1"
        Me.returnIDGridColumn.Name = "returnIDGridColumn"
        '
        'ShippingMainIDGridColumn
        '
        Me.ShippingMainIDGridColumn.Caption = "GridColumn1"
        Me.ShippingMainIDGridColumn.Name = "ShippingMainIDGridColumn"
        '
        'returnItemGridColumn
        '
        Me.returnItemGridColumn.Caption = "Item Number"
        Me.returnItemGridColumn.ColumnEdit = Me.returnItemRepositoryItemLookUpEdit
        Me.returnItemGridColumn.Name = "returnItemGridColumn"
        Me.returnItemGridColumn.Visible = True
        Me.returnItemGridColumn.VisibleIndex = 1
        '
        'returnItemRepositoryItemLookUpEdit
        '
        Me.returnItemRepositoryItemLookUpEdit.AutoHeight = False
        Me.returnItemRepositoryItemLookUpEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.returnItemRepositoryItemLookUpEdit.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 59, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCustomerID", "Item Customer ID", 95, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far)})
        Me.returnItemRepositoryItemLookUpEdit.DataSource = Me.returnItemXPView
        Me.returnItemRepositoryItemLookUpEdit.DisplayMember = "ItemCode"
        Me.returnItemRepositoryItemLookUpEdit.ImmediatePopup = True
        Me.returnItemRepositoryItemLookUpEdit.Name = "returnItemRepositoryItemLookUpEdit"
        Me.returnItemRepositoryItemLookUpEdit.NullText = ""
        Me.returnItemRepositoryItemLookUpEdit.NullValuePrompt = "[Select A Item]"
        Me.returnItemRepositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.returnItemRepositoryItemLookUpEdit.ValueMember = "ItemID"
        '
        'returnItemXPView
        '
        Me.returnItemXPView.CriteriaString = "[ItemType] = 'RM' Or [ItemType] = 'IG'"
        Me.returnItemXPView.ObjectType = GetType(DXDAL.SPGData.Items)
        Me.returnItemXPView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[ItemID]", False, True), New DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[ItemCode]", False, True), New DevExpress.Xpo.ViewProperty("ItemCustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID]", False, True), New DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID.CustomerID]", False, True), New DevExpress.Xpo.ViewProperty("Inactive", DevExpress.Xpo.SortDirection.None, "[Inactive]", False, True)})
        '
        'returnItemDescGridColumn
        '
        Me.returnItemDescGridColumn.Caption = "Item Description"
        Me.returnItemDescGridColumn.FieldName = "descriptionGridColumn"
        Me.returnItemDescGridColumn.Name = "returnItemDescGridColumn"
        Me.returnItemDescGridColumn.OptionsColumn.AllowEdit = False
        Me.returnItemDescGridColumn.OptionsColumn.ReadOnly = True
        Me.returnItemDescGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.[String]
        Me.returnItemDescGridColumn.Visible = True
        Me.returnItemDescGridColumn.VisibleIndex = 2
        '
        'returnLotGridColumn
        '
        Me.returnLotGridColumn.Caption = "Lot #"
        Me.returnLotGridColumn.Name = "returnLotGridColumn"
        Me.returnLotGridColumn.Visible = True
        Me.returnLotGridColumn.VisibleIndex = 3
        '
        'returnExpirationDateGridColumn
        '
        Me.returnExpirationDateGridColumn.Caption = "Expiration Date"
        Me.returnExpirationDateGridColumn.ColumnEdit = Me.RepositoryItemDateEdit2
        Me.returnExpirationDateGridColumn.Name = "returnExpirationDateGridColumn"
        Me.returnExpirationDateGridColumn.Visible = True
        Me.returnExpirationDateGridColumn.VisibleIndex = 4
        '
        'RepositoryItemDateEdit2
        '
        Me.RepositoryItemDateEdit2.AutoHeight = False
        Me.RepositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2"
        '
        'returnUnitsGridColumn
        '
        Me.returnUnitsGridColumn.Caption = "Quantity"
        Me.returnUnitsGridColumn.Name = "returnUnitsGridColumn"
        Me.returnUnitsGridColumn.Visible = True
        Me.returnUnitsGridColumn.VisibleIndex = 6
        '
        'returnQuantityGridColumn
        '
        Me.returnQuantityGridColumn.Caption = "Units"
        Me.returnQuantityGridColumn.Name = "returnQuantityGridColumn"
        Me.returnQuantityGridColumn.Visible = True
        Me.returnQuantityGridColumn.VisibleIndex = 5
        '
        'returnPalletsGridColumn
        '
        Me.returnPalletsGridColumn.Caption = "Pallets"
        Me.returnPalletsGridColumn.Name = "returnPalletsGridColumn"
        Me.returnPalletsGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)})
        Me.returnPalletsGridColumn.Visible = True
        Me.returnPalletsGridColumn.VisibleIndex = 8
        '
        'returnReasonGridColumn
        '
        Me.returnReasonGridColumn.Caption = "Reason"
        Me.returnReasonGridColumn.ColumnEdit = Me.returnReasonRepositoryItemMemoExEdit
        Me.returnReasonGridColumn.Name = "returnReasonGridColumn"
        Me.returnReasonGridColumn.Visible = True
        Me.returnReasonGridColumn.VisibleIndex = 9
        '
        'returnReasonRepositoryItemMemoExEdit
        '
        Me.returnReasonRepositoryItemMemoExEdit.AutoHeight = False
        Me.returnReasonRepositoryItemMemoExEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.returnReasonRepositoryItemMemoExEdit.Name = "returnReasonRepositoryItemMemoExEdit"
        '
        'returnGrossWeightGridColumn
        '
        Me.returnGrossWeightGridColumn.Caption = "Gross Weight"
        Me.returnGrossWeightGridColumn.FieldName = "returnGrossWeightGridColumn"
        Me.returnGrossWeightGridColumn.Name = "returnGrossWeightGridColumn"
        Me.returnGrossWeightGridColumn.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)})
        Me.returnGrossWeightGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
        Me.returnGrossWeightGridColumn.Visible = True
        Me.returnGrossWeightGridColumn.VisibleIndex = 7
        '
        'deleteReturnGridColumn
        '
        Me.deleteReturnGridColumn.ColumnEdit = Me.deleteReturnRepositoryItemButtonEdit
        Me.deleteReturnGridColumn.MaxWidth = 30
        Me.deleteReturnGridColumn.MinWidth = 25
        Me.deleteReturnGridColumn.Name = "deleteReturnGridColumn"
        Me.deleteReturnGridColumn.Visible = True
        Me.deleteReturnGridColumn.VisibleIndex = 0
        Me.deleteReturnGridColumn.Width = 30
        '
        'deleteReturnRepositoryItemButtonEdit
        '
        Me.deleteReturnRepositoryItemButtonEdit.AutoHeight = False
        Me.deleteReturnRepositoryItemButtonEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.deleteReturnRepositoryItemButtonEdit.Name = "deleteReturnRepositoryItemButtonEdit"
        Me.deleteReturnRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'SplitContainerControl1
        '
        Me.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 49)
        Me.SplitContainerControl1.Name = "SplitContainerControl1"
        Me.SplitContainerControl1.Panel1.Controls.Add(Me.shippingSearchGridControl)
        Me.SplitContainerControl1.Panel1.MinSize = 250
        Me.SplitContainerControl1.Panel1.Text = "Panel1"
        Me.SplitContainerControl1.Panel2.Controls.Add(Me.shippingXtraTabControl)
        Me.SplitContainerControl1.Panel2.Text = "Panel2"
        Me.SplitContainerControl1.Size = New System.Drawing.Size(868, 433)
        Me.SplitContainerControl1.TabIndex = 5
        Me.SplitContainerControl1.Text = "SplitContainerControl1"
        '
        'shippingSearchGridControl
        '
        Me.shippingSearchGridControl.DataSource = Me.shippingSearchXPView
        Me.shippingSearchGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.shippingSearchGridControl.Location = New System.Drawing.Point(0, 0)
        Me.shippingSearchGridControl.MainView = Me.shippingSearchGridView
        Me.shippingSearchGridControl.Name = "shippingSearchGridControl"
        Me.shippingSearchGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.shippingDateRepositoryItemDateEdit})
        Me.shippingSearchGridControl.Size = New System.Drawing.Size(250, 433)
        Me.shippingSearchGridControl.TabIndex = 0
        Me.shippingSearchGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.shippingSearchGridView})
        '
        'shippingSearchXPView
        '
        Me.shippingSearchXPView.ObjectType = GetType(DXDAL.SPGData.Shipping)
        Me.shippingSearchXPView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("ShippingID", DevExpress.Xpo.SortDirection.None, "[ShipMainID]", False, True), New DevExpress.Xpo.ViewProperty("ShippingBOL", DevExpress.Xpo.SortDirection.None, "[ShipMainBOL]", False, True), New DevExpress.Xpo.ViewProperty("ShippingCustomerID", DevExpress.Xpo.SortDirection.None, "[ShipMainCustID.CustomerID]", False, True), New DevExpress.Xpo.ViewProperty("ShippingCustomerName", DevExpress.Xpo.SortDirection.None, "[ShipMainCustID.CustomerName]", False, True), New DevExpress.Xpo.ViewProperty("ShippingDate", DevExpress.Xpo.SortDirection.None, "[ShipMainDate]", False, True)})
        Me.shippingSearchXPView.Sorting.AddRange(New DevExpress.Xpo.SortProperty() {New DevExpress.Xpo.SortProperty("[ShippingBOL]", DevExpress.Xpo.DB.SortingDirection.Descending)})
        '
        'shippingSearchGridView
        '
        Me.shippingSearchGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.shippingSearchIDGridColumn, Me.shippingBOLGridColumn, Me.shippingCustomerGridColumn, Me.shippingDateGridColumn})
        Me.shippingSearchGridView.GridControl = Me.shippingSearchGridControl
        Me.shippingSearchGridView.Name = "shippingSearchGridView"
        Me.shippingSearchGridView.OptionsBehavior.Editable = False
        Me.shippingSearchGridView.OptionsView.ShowAutoFilterRow = True
        Me.shippingSearchGridView.OptionsView.ShowGroupPanel = False
        '
        'shippingSearchIDGridColumn
        '
        Me.shippingSearchIDGridColumn.Caption = "GridColumn1"
        Me.shippingSearchIDGridColumn.FieldName = "ShippingID"
        Me.shippingSearchIDGridColumn.Name = "shippingSearchIDGridColumn"
        '
        'shippingBOLGridColumn
        '
        Me.shippingBOLGridColumn.Caption = "BOL #"
        Me.shippingBOLGridColumn.FieldName = "ShippingBOL"
        Me.shippingBOLGridColumn.Name = "shippingBOLGridColumn"
        Me.shippingBOLGridColumn.Visible = True
        Me.shippingBOLGridColumn.VisibleIndex = 0
        '
        'shippingCustomerGridColumn
        '
        Me.shippingCustomerGridColumn.Caption = "Customer"
        Me.shippingCustomerGridColumn.FieldName = "ShippingCustomerName"
        Me.shippingCustomerGridColumn.Name = "shippingCustomerGridColumn"
        Me.shippingCustomerGridColumn.Visible = True
        Me.shippingCustomerGridColumn.VisibleIndex = 1
        '
        'shippingDateGridColumn
        '
        Me.shippingDateGridColumn.Caption = "Date"
        Me.shippingDateGridColumn.ColumnEdit = Me.shippingDateRepositoryItemDateEdit
        Me.shippingDateGridColumn.FieldName = "ShippingDate"
        Me.shippingDateGridColumn.Name = "shippingDateGridColumn"
        Me.shippingDateGridColumn.Visible = True
        Me.shippingDateGridColumn.VisibleIndex = 2
        '
        'shippingDateRepositoryItemDateEdit
        '
        Me.shippingDateRepositoryItemDateEdit.AutoHeight = False
        Me.shippingDateRepositoryItemDateEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.shippingDateRepositoryItemDateEdit.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.shippingDateRepositoryItemDateEdit.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista
        Me.shippingDateRepositoryItemDateEdit.Name = "shippingDateRepositoryItemDateEdit"
        Me.shippingDateRepositoryItemDateEdit.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        '
        'ShippingXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 505)
        Me.Controls.Add(Me.SplitContainerControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ShippingXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shipping"
        CType(Me.shippingXtraTabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.shippingXtraTabControl.ResumeLayout(False)
        Me.generalXtraTabPage.ResumeLayout(False)
        Me.generalXtraTabPage.PerformLayout()
        CType(Me.locationLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.locationXpView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.freightCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.commentsMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.customerShipperCheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.totalGrossWeightTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shiftLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deliveryNoteNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.palletsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.noteMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.destinationMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.destinationLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carrierLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.poTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.customerLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.customersXPView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skitsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sealTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trailerTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bolTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shipDateEdit.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shipDateEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.shipmentInfoXtraTabPage.ResumeLayout(False)
        Me.shipmentInfoXtraTabPage.PerformLayout()
        CType(Me.correctPalletsComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.insectActivityComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.foreignSubstanceComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wheelsChockedComboBoxEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.loadConditionLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shipmentConditionXpView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.physicalConditionLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.temparatureSpinEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.finishTimeTimeEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.startTimeTimeEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkedByLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.employeeXpView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.loadedByLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.detailsXtraTabPage.ResumeLayout(False)
        Me.detailsXtraTabPage.PerformLayout()
        CType(Me.lpnNumberTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shippingGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shippingGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.itemRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shippingItemXPView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.noteRepositoryItemMemoExEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.delRepositoryItemButtonEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.returnsXtraTabPage.ResumeLayout(False)
        CType(Me.returnsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.returnsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.returnItemRepositoryItemLookUpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.returnItemXPView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.returnReasonRepositoryItemMemoExEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deleteReturnRepositoryItemButtonEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerControl1.ResumeLayout(False)
        CType(Me.shippingSearchGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shippingSearchXPView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shippingSearchGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shippingDateRepositoryItemDateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shippingDateRepositoryItemDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents shippingXtraTabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents generalXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents detailsXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents shipDateEdit As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents bolTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents skitsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents sealTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents trailerTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents customerLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents poTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents carrierLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents destinationLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents noteMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents destinationMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents palletsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents shippingGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents shippingGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents idGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shippingIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents itemGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents descriptionGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lotGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents quantityGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents palletsGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents itemRepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents shippingBar As DevExpress.XtraBars.Bar
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents shippingSearchGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents shippingSearchGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents addBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents editBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cancelBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents saveBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents shippingSearchIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shippingBOLGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shippingCustomerGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shippingDateGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shippingDateRepositoryItemDateEdit As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents deliveryNoteNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents shiftLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents totalGrossWeightTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents commentsMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents customerShipperCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents freightCheckEdit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents returnsXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents returnsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents returnsGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents returnIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ShippingMainIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents returnItemGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents returnItemRepositoryItemLookUpEdit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents returnItemDescGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents returnLotGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents returnQuantityGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents returnPalletsGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents returnReasonGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents returnReasonRepositoryItemMemoExEdit As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents grossWeightGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents returnGrossWeightGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents printBOLBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents deleteReturnGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents deleteReturnRepositoryItemButtonEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents noteGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents noteRepositoryItemMemoExEdit As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents shippingSearchXPView As DevExpress.Xpo.XPView
    Friend WithEvents customersXPView As DevExpress.Xpo.XPView
    Friend WithEvents shippingItemXPView As DevExpress.Xpo.XPView
    Friend WithEvents returnItemXPView As DevExpress.Xpo.XPView
    Friend WithEvents delGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents delRepositoryItemButtonEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents expirationDateGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents returnExpirationDateGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lpnNumberTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents fullLPNNumberGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents printPackingListBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents shipmentInfoXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents checkedByLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents loadedByLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents temparatureSpinEdit As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents finishTimeTimeEdit As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents startTimeTimeEdit As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents loadConditionLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents physicalConditionLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents shipmentConditionXpView As DevExpress.Xpo.XPView
    Friend WithEvents employeeXpView As DevExpress.Xpo.XPView
    Friend WithEvents correctPalletsComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents insectActivityComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents foreignSubstanceComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents wheelsChockedComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents returnUnitsGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents refreshBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents locationLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents locationXpView As DevExpress.Xpo.XPView
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
End Class
