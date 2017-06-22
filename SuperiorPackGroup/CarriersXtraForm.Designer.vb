<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarriersXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CarriersXtraForm))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.carriersMenuBar = New DevExpress.XtraBars.Bar()
        Me.addBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.editBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.cancelBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.saveBarButtonItem = New DevExpress.XtraBars.BarButtonItem()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.Bar3Bar = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.carrierSplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.carriersSearchGridControl = New DevExpress.XtraGrid.GridControl()
        Me.carriersSearchGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.carrierIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.carrierNameGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.carrierXtraTabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.carriersXtraTabPage = New DevExpress.XtraTab.XtraTabPage()
        Me.faxTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.emailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.phoneTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.postalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.stateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.cityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.addressTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.lastNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.firstNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.nameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.noteMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carrierSplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.carrierSplitContainerControl.SuspendLayout()
        CType(Me.carriersSearchGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carriersSearchGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.carrierXtraTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.carrierXtraTabControl.SuspendLayout()
        Me.carriersXtraTabPage.SuspendLayout()
        CType(Me.faxTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.phoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.postalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addressTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lastNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.firstNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.noteMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.carriersMenuBar, Me.Bar2, Me.Bar3Bar})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.addBarButtonItem, Me.editBarButtonItem, Me.cancelBarButtonItem, Me.saveBarButtonItem})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 4
        Me.BarManager1.StatusBar = Me.Bar3Bar
        '
        'carriersMenuBar
        '
        Me.carriersMenuBar.BarName = "Tools"
        Me.carriersMenuBar.DockCol = 0
        Me.carriersMenuBar.DockRow = 1
        Me.carriersMenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.carriersMenuBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.addBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.editBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.cancelBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.saveBarButtonItem)})
        Me.carriersMenuBar.OptionsBar.UseWholeRow = True
        Me.carriersMenuBar.Text = "Tools"
        '
        'addBarButtonItem
        '
        Me.addBarButtonItem.Caption = "&Add Carrier"
        Me.addBarButtonItem.Id = 0
        Me.addBarButtonItem.Name = "addBarButtonItem"
        '
        'editBarButtonItem
        '
        Me.editBarButtonItem.Caption = "&Edit Carrier"
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
        'Bar3Bar
        '
        Me.Bar3Bar.BarName = "Status bar"
        Me.Bar3Bar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.Bar3Bar.DockCol = 0
        Me.Bar3Bar.DockRow = 0
        Me.Bar3Bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.Bar3Bar.OptionsBar.AllowQuickCustomization = False
        Me.Bar3Bar.OptionsBar.DrawDragBorder = False
        Me.Bar3Bar.OptionsBar.UseWholeRow = True
        Me.Bar3Bar.Text = "Status bar"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(684, 51)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 441)
        Me.barDockControlBottom.Size = New System.Drawing.Size(684, 23)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 51)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 390)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(684, 51)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 390)
        '
        'carrierSplitContainerControl
        '
        Me.carrierSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.carrierSplitContainerControl.Location = New System.Drawing.Point(0, 51)
        Me.carrierSplitContainerControl.Name = "carrierSplitContainerControl"
        Me.carrierSplitContainerControl.Panel1.Controls.Add(Me.carriersSearchGridControl)
        Me.carrierSplitContainerControl.Panel1.MinSize = 200
        Me.carrierSplitContainerControl.Panel1.Text = "Panel1"
        Me.carrierSplitContainerControl.Panel2.Controls.Add(Me.carrierXtraTabControl)
        Me.carrierSplitContainerControl.Panel2.Text = "Panel2"
        Me.carrierSplitContainerControl.Size = New System.Drawing.Size(684, 390)
        Me.carrierSplitContainerControl.TabIndex = 4
        Me.carrierSplitContainerControl.Text = "SplitContainerControl1"
        '
        'carriersSearchGridControl
        '
        Me.carriersSearchGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.carriersSearchGridControl.Location = New System.Drawing.Point(0, 0)
        Me.carriersSearchGridControl.MainView = Me.carriersSearchGridView
        Me.carriersSearchGridControl.Name = "carriersSearchGridControl"
        Me.carriersSearchGridControl.Size = New System.Drawing.Size(200, 390)
        Me.carriersSearchGridControl.TabIndex = 0
        Me.carriersSearchGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.carriersSearchGridView})
        '
        'carriersSearchGridView
        '
        Me.carriersSearchGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.carrierIDGridColumn, Me.carrierNameGridColumn})
        Me.carriersSearchGridView.GridControl = Me.carriersSearchGridControl
        Me.carriersSearchGridView.Name = "carriersSearchGridView"
        Me.carriersSearchGridView.OptionsBehavior.Editable = False
        Me.carriersSearchGridView.OptionsView.ShowAutoFilterRow = True
        Me.carriersSearchGridView.OptionsView.ShowGroupPanel = False
        '
        'carrierIDGridColumn
        '
        Me.carrierIDGridColumn.Caption = "GridColumn1"
        Me.carrierIDGridColumn.FieldName = "CarrierID"
        Me.carrierIDGridColumn.Name = "carrierIDGridColumn"
        '
        'carrierNameGridColumn
        '
        Me.carrierNameGridColumn.Caption = "Carrier"
        Me.carrierNameGridColumn.FieldName = "CarrierName"
        Me.carrierNameGridColumn.Name = "carrierNameGridColumn"
        Me.carrierNameGridColumn.Visible = True
        Me.carrierNameGridColumn.VisibleIndex = 0
        '
        'carrierXtraTabControl
        '
        Me.carrierXtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.carrierXtraTabControl.Location = New System.Drawing.Point(0, 0)
        Me.carrierXtraTabControl.Name = "carrierXtraTabControl"
        Me.carrierXtraTabControl.SelectedTabPage = Me.carriersXtraTabPage
        Me.carrierXtraTabControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[False]
        Me.carrierXtraTabControl.Size = New System.Drawing.Size(479, 390)
        Me.carrierXtraTabControl.TabIndex = 4
        Me.carrierXtraTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.carriersXtraTabPage})
        '
        'carriersXtraTabPage
        '
        Me.carriersXtraTabPage.Controls.Add(Me.faxTextEdit)
        Me.carriersXtraTabPage.Controls.Add(Me.emailTextEdit)
        Me.carriersXtraTabPage.Controls.Add(Me.phoneTextEdit)
        Me.carriersXtraTabPage.Controls.Add(Me.postalTextEdit)
        Me.carriersXtraTabPage.Controls.Add(Me.stateTextEdit)
        Me.carriersXtraTabPage.Controls.Add(Me.cityTextEdit)
        Me.carriersXtraTabPage.Controls.Add(Me.addressTextEdit)
        Me.carriersXtraTabPage.Controls.Add(Me.lastNameTextEdit)
        Me.carriersXtraTabPage.Controls.Add(Me.firstNameTextEdit)
        Me.carriersXtraTabPage.Controls.Add(Me.nameTextEdit)
        Me.carriersXtraTabPage.Controls.Add(Me.noteMemoEdit)
        Me.carriersXtraTabPage.Controls.Add(Me.LabelControl11)
        Me.carriersXtraTabPage.Controls.Add(Me.LabelControl8)
        Me.carriersXtraTabPage.Controls.Add(Me.LabelControl7)
        Me.carriersXtraTabPage.Controls.Add(Me.LabelControl6)
        Me.carriersXtraTabPage.Controls.Add(Me.LabelControl5)
        Me.carriersXtraTabPage.Controls.Add(Me.LabelControl4)
        Me.carriersXtraTabPage.Controls.Add(Me.LabelControl3)
        Me.carriersXtraTabPage.Name = "carriersXtraTabPage"
        Me.carriersXtraTabPage.Size = New System.Drawing.Size(473, 384)
        Me.carriersXtraTabPage.Text = "XtraTabPage1"
        '
        'faxTextEdit
        '
        Me.faxTextEdit.Location = New System.Drawing.Point(274, 183)
        Me.faxTextEdit.Name = "faxTextEdit"
        Me.faxTextEdit.Properties.NullText = "[Fax]"
        Me.faxTextEdit.Size = New System.Drawing.Size(153, 20)
        Me.faxTextEdit.TabIndex = 18
        '
        'emailTextEdit
        '
        Me.emailTextEdit.Location = New System.Drawing.Point(115, 209)
        Me.emailTextEdit.Name = "emailTextEdit"
        Me.emailTextEdit.Size = New System.Drawing.Size(312, 20)
        Me.emailTextEdit.TabIndex = 16
        '
        'phoneTextEdit
        '
        Me.phoneTextEdit.Location = New System.Drawing.Point(115, 183)
        Me.phoneTextEdit.Name = "phoneTextEdit"
        Me.phoneTextEdit.Properties.NullText = "[Phone]"
        Me.phoneTextEdit.Size = New System.Drawing.Size(153, 20)
        Me.phoneTextEdit.TabIndex = 14
        '
        'postalTextEdit
        '
        Me.postalTextEdit.Location = New System.Drawing.Point(327, 156)
        Me.postalTextEdit.Name = "postalTextEdit"
        Me.postalTextEdit.Properties.NullText = "[Zip code]"
        Me.postalTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.postalTextEdit.TabIndex = 12
        '
        'stateTextEdit
        '
        Me.stateTextEdit.Location = New System.Drawing.Point(221, 156)
        Me.stateTextEdit.Name = "stateTextEdit"
        Me.stateTextEdit.Properties.NullText = "[State]"
        Me.stateTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.stateTextEdit.TabIndex = 11
        '
        'cityTextEdit
        '
        Me.cityTextEdit.Location = New System.Drawing.Point(115, 157)
        Me.cityTextEdit.Name = "cityTextEdit"
        Me.cityTextEdit.Properties.NullText = "[City]"
        Me.cityTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.cityTextEdit.TabIndex = 10
        '
        'addressTextEdit
        '
        Me.addressTextEdit.Location = New System.Drawing.Point(115, 130)
        Me.addressTextEdit.Name = "addressTextEdit"
        Me.addressTextEdit.Size = New System.Drawing.Size(312, 20)
        Me.addressTextEdit.TabIndex = 8
        '
        'lastNameTextEdit
        '
        Me.lastNameTextEdit.Location = New System.Drawing.Point(274, 104)
        Me.lastNameTextEdit.Name = "lastNameTextEdit"
        Me.lastNameTextEdit.Properties.NullText = "[Last Name]"
        Me.lastNameTextEdit.Size = New System.Drawing.Size(153, 20)
        Me.lastNameTextEdit.TabIndex = 6
        '
        'firstNameTextEdit
        '
        Me.firstNameTextEdit.Location = New System.Drawing.Point(115, 104)
        Me.firstNameTextEdit.Name = "firstNameTextEdit"
        Me.firstNameTextEdit.Properties.NullText = "[First Name]"
        Me.firstNameTextEdit.Size = New System.Drawing.Size(153, 20)
        Me.firstNameTextEdit.TabIndex = 5
        '
        'nameTextEdit
        '
        Me.nameTextEdit.Location = New System.Drawing.Point(115, 78)
        Me.nameTextEdit.Name = "nameTextEdit"
        Me.nameTextEdit.Size = New System.Drawing.Size(312, 20)
        Me.nameTextEdit.TabIndex = 3
        '
        'noteMemoEdit
        '
        Me.noteMemoEdit.Location = New System.Drawing.Point(115, 235)
        Me.noteMemoEdit.Name = "noteMemoEdit"
        Me.noteMemoEdit.Size = New System.Drawing.Size(312, 68)
        Me.noteMemoEdit.TabIndex = 20
        Me.noteMemoEdit.UseOptimizedRendering = True
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(37, 238)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl11.TabIndex = 19
        Me.LabelControl11.Text = "Note:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(37, 212)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl8.TabIndex = 15
        Me.LabelControl8.Text = "Email:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(37, 186)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl7.TabIndex = 13
        Me.LabelControl7.Text = "Phone\Fax:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(37, 160)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl6.TabIndex = 9
        Me.LabelControl6.Text = "City State Zip:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(37, 133)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl5.TabIndex = 7
        Me.LabelControl5.Text = "Address:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(37, 107)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "Contact Name:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(37, 81)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Name:"
        '
        'CarriersXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 464)
        Me.Controls.Add(Me.carrierSplitContainerControl)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CarriersXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carriers"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carrierSplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.carrierSplitContainerControl.ResumeLayout(False)
        CType(Me.carriersSearchGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carriersSearchGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.carrierXtraTabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.carrierXtraTabControl.ResumeLayout(False)
        Me.carriersXtraTabPage.ResumeLayout(False)
        Me.carriersXtraTabPage.PerformLayout()
        CType(Me.faxTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.phoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.postalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addressTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lastNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.firstNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.noteMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents carriersMenuBar As DevExpress.XtraBars.Bar
    Friend WithEvents addBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents editBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cancelBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents Bar3Bar As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents saveBarButtonItem As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents carrierSplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents carrierXtraTabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents carriersXtraTabPage As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents faxTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents emailTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents phoneTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents postalTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents stateTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cityTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents addressTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lastNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents firstNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents nameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents noteMemoEdit As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents carriersSearchGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents carriersSearchGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents carrierIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents carrierNameGridColumn As DevExpress.XtraGrid.Columns.GridColumn
End Class
