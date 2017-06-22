<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShippingAddressesXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShippingAddressesXtraForm))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.shippingDestinationsMenuBar = New DevExpress.XtraBars.Bar()
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
        Me.ShippingDestinationsSplitContainerControl = New DevExpress.XtraEditors.SplitContainerControl()
        Me.destinationsSearchGridControl = New DevExpress.XtraGrid.GridControl()
        Me.destinationsSearchGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.destinationIDGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.destinationsGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.destinationsPanelControl = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.faxTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.emailTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.phoneTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.postalTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.stateTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.cityTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.addressTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.noteMemoEdit = New DevExpress.XtraEditors.MemoEdit()
        Me.lastNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.nameTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.firstNameTextEdit = New DevExpress.XtraEditors.TextEdit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShippingDestinationsSplitContainerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ShippingDestinationsSplitContainerControl.SuspendLayout()
        CType(Me.destinationsSearchGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.destinationsSearchGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.destinationsPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.destinationsPanelControl.SuspendLayout()
        CType(Me.faxTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emailTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.phoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.postalTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stateTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cityTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addressTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.noteMemoEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lastNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.firstNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.shippingDestinationsMenuBar, Me.Bar2, Me.Bar3})
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
        'shippingDestinationsMenuBar
        '
        Me.shippingDestinationsMenuBar.BarName = "Tools"
        Me.shippingDestinationsMenuBar.DockCol = 0
        Me.shippingDestinationsMenuBar.DockRow = 1
        Me.shippingDestinationsMenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.shippingDestinationsMenuBar.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.addBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.editBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.deleteBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.cancelBarButtonItem), New DevExpress.XtraBars.LinkPersistInfo(Me.saveBarButtonItem)})
        Me.shippingDestinationsMenuBar.OptionsBar.UseWholeRow = True
        Me.shippingDestinationsMenuBar.Text = "Tools"
        '
        'addBarButtonItem
        '
        Me.addBarButtonItem.Caption = "&Add Destination"
        Me.addBarButtonItem.Id = 0
        Me.addBarButtonItem.Name = "addBarButtonItem"
        '
        'editBarButtonItem
        '
        Me.editBarButtonItem.Caption = "&Edit Destination"
        Me.editBarButtonItem.Id = 1
        Me.editBarButtonItem.Name = "editBarButtonItem"
        '
        'deleteBarButtonItem
        '
        Me.deleteBarButtonItem.Caption = "Delete Destination"
        Me.deleteBarButtonItem.Id = 2
        Me.deleteBarButtonItem.Name = "deleteBarButtonItem"
        Me.deleteBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
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
        'ShippingDestinationsSplitContainerControl
        '
        Me.ShippingDestinationsSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ShippingDestinationsSplitContainerControl.Location = New System.Drawing.Point(0, 51)
        Me.ShippingDestinationsSplitContainerControl.Name = "ShippingDestinationsSplitContainerControl"
        Me.ShippingDestinationsSplitContainerControl.Panel1.Controls.Add(Me.destinationsSearchGridControl)
        Me.ShippingDestinationsSplitContainerControl.Panel1.MinSize = 200
        Me.ShippingDestinationsSplitContainerControl.Panel1.Text = "Panel1"
        Me.ShippingDestinationsSplitContainerControl.Panel2.Controls.Add(Me.destinationsPanelControl)
        Me.ShippingDestinationsSplitContainerControl.Panel2.Text = "Panel2"
        Me.ShippingDestinationsSplitContainerControl.Size = New System.Drawing.Size(684, 390)
        Me.ShippingDestinationsSplitContainerControl.TabIndex = 6
        Me.ShippingDestinationsSplitContainerControl.Text = "ShippingDestinations"
        '
        'destinationsSearchGridControl
        '
        Me.destinationsSearchGridControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.destinationsSearchGridControl.Location = New System.Drawing.Point(0, 0)
        Me.destinationsSearchGridControl.MainView = Me.destinationsSearchGridView
        Me.destinationsSearchGridControl.Name = "destinationsSearchGridControl"
        Me.destinationsSearchGridControl.Size = New System.Drawing.Size(200, 390)
        Me.destinationsSearchGridControl.TabIndex = 0
        Me.destinationsSearchGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.destinationsSearchGridView})
        '
        'destinationsSearchGridView
        '
        Me.destinationsSearchGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.destinationIDGridColumn, Me.destinationsGridColumn})
        Me.destinationsSearchGridView.GridControl = Me.destinationsSearchGridControl
        Me.destinationsSearchGridView.Name = "destinationsSearchGridView"
        Me.destinationsSearchGridView.OptionsBehavior.Editable = False
        Me.destinationsSearchGridView.OptionsView.ShowAutoFilterRow = True
        Me.destinationsSearchGridView.OptionsView.ShowGroupPanel = False
        '
        'destinationIDGridColumn
        '
        Me.destinationIDGridColumn.Caption = "GridColumn1"
        Me.destinationIDGridColumn.FieldName = "AddressID"
        Me.destinationIDGridColumn.Name = "destinationIDGridColumn"
        '
        'destinationsGridColumn
        '
        Me.destinationsGridColumn.Caption = "Destination"
        Me.destinationsGridColumn.FieldName = "ShippingName"
        Me.destinationsGridColumn.Name = "destinationsGridColumn"
        Me.destinationsGridColumn.Visible = True
        Me.destinationsGridColumn.VisibleIndex = 0
        '
        'destinationsPanelControl
        '
        Me.destinationsPanelControl.Controls.Add(Me.LabelControl3)
        Me.destinationsPanelControl.Controls.Add(Me.faxTextEdit)
        Me.destinationsPanelControl.Controls.Add(Me.LabelControl4)
        Me.destinationsPanelControl.Controls.Add(Me.emailTextEdit)
        Me.destinationsPanelControl.Controls.Add(Me.LabelControl5)
        Me.destinationsPanelControl.Controls.Add(Me.phoneTextEdit)
        Me.destinationsPanelControl.Controls.Add(Me.LabelControl6)
        Me.destinationsPanelControl.Controls.Add(Me.postalTextEdit)
        Me.destinationsPanelControl.Controls.Add(Me.LabelControl7)
        Me.destinationsPanelControl.Controls.Add(Me.stateTextEdit)
        Me.destinationsPanelControl.Controls.Add(Me.LabelControl8)
        Me.destinationsPanelControl.Controls.Add(Me.cityTextEdit)
        Me.destinationsPanelControl.Controls.Add(Me.LabelControl11)
        Me.destinationsPanelControl.Controls.Add(Me.addressTextEdit)
        Me.destinationsPanelControl.Controls.Add(Me.noteMemoEdit)
        Me.destinationsPanelControl.Controls.Add(Me.lastNameTextEdit)
        Me.destinationsPanelControl.Controls.Add(Me.nameTextEdit)
        Me.destinationsPanelControl.Controls.Add(Me.firstNameTextEdit)
        Me.destinationsPanelControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.destinationsPanelControl.Location = New System.Drawing.Point(0, 0)
        Me.destinationsPanelControl.Name = "destinationsPanelControl"
        Me.destinationsPanelControl.Size = New System.Drawing.Size(479, 390)
        Me.destinationsPanelControl.TabIndex = 40
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(42, 85)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(31, 13)
        Me.LabelControl3.TabIndex = 21
        Me.LabelControl3.Text = "Name:"
        '
        'faxTextEdit
        '
        Me.faxTextEdit.Location = New System.Drawing.Point(279, 187)
        Me.faxTextEdit.Name = "faxTextEdit"
        Me.faxTextEdit.Properties.NullText = "[Fax]"
        Me.faxTextEdit.Size = New System.Drawing.Size(153, 20)
        Me.faxTextEdit.TabIndex = 37
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(42, 111)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(72, 13)
        Me.LabelControl4.TabIndex = 23
        Me.LabelControl4.Text = "Contact Name:"
        '
        'emailTextEdit
        '
        Me.emailTextEdit.Location = New System.Drawing.Point(120, 213)
        Me.emailTextEdit.Name = "emailTextEdit"
        Me.emailTextEdit.Size = New System.Drawing.Size(312, 20)
        Me.emailTextEdit.TabIndex = 35
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(42, 137)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl5.TabIndex = 26
        Me.LabelControl5.Text = "Address:"
        '
        'phoneTextEdit
        '
        Me.phoneTextEdit.Location = New System.Drawing.Point(120, 187)
        Me.phoneTextEdit.Name = "phoneTextEdit"
        Me.phoneTextEdit.Properties.NullText = "[Phone]"
        Me.phoneTextEdit.Size = New System.Drawing.Size(153, 20)
        Me.phoneTextEdit.TabIndex = 33
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(42, 164)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl6.TabIndex = 28
        Me.LabelControl6.Text = "City State Zip:"
        '
        'postalTextEdit
        '
        Me.postalTextEdit.Location = New System.Drawing.Point(332, 160)
        Me.postalTextEdit.Name = "postalTextEdit"
        Me.postalTextEdit.Properties.NullText = "[Zip Code]"
        Me.postalTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.postalTextEdit.TabIndex = 31
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(42, 190)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl7.TabIndex = 32
        Me.LabelControl7.Text = "Phone\Fax:"
        '
        'stateTextEdit
        '
        Me.stateTextEdit.Location = New System.Drawing.Point(226, 160)
        Me.stateTextEdit.Name = "stateTextEdit"
        Me.stateTextEdit.Properties.NullText = "[State]"
        Me.stateTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.stateTextEdit.TabIndex = 30
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(42, 216)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl8.TabIndex = 34
        Me.LabelControl8.Text = "Email:"
        '
        'cityTextEdit
        '
        Me.cityTextEdit.Location = New System.Drawing.Point(120, 161)
        Me.cityTextEdit.Name = "cityTextEdit"
        Me.cityTextEdit.Properties.NullText = "[City]"
        Me.cityTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.cityTextEdit.TabIndex = 29
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(42, 242)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(27, 13)
        Me.LabelControl11.TabIndex = 38
        Me.LabelControl11.Text = "Note:"
        '
        'addressTextEdit
        '
        Me.addressTextEdit.Location = New System.Drawing.Point(120, 134)
        Me.addressTextEdit.Name = "addressTextEdit"
        Me.addressTextEdit.Size = New System.Drawing.Size(312, 20)
        Me.addressTextEdit.TabIndex = 27
        '
        'noteMemoEdit
        '
        Me.noteMemoEdit.Location = New System.Drawing.Point(120, 239)
        Me.noteMemoEdit.Name = "noteMemoEdit"
        Me.noteMemoEdit.Size = New System.Drawing.Size(312, 68)
        Me.noteMemoEdit.TabIndex = 39
        '
        'lastNameTextEdit
        '
        Me.lastNameTextEdit.Location = New System.Drawing.Point(279, 108)
        Me.lastNameTextEdit.Name = "lastNameTextEdit"
        Me.lastNameTextEdit.Properties.NullText = "[Last Name]"
        Me.lastNameTextEdit.Size = New System.Drawing.Size(153, 20)
        Me.lastNameTextEdit.TabIndex = 25
        '
        'nameTextEdit
        '
        Me.nameTextEdit.Location = New System.Drawing.Point(120, 82)
        Me.nameTextEdit.Name = "nameTextEdit"
        Me.nameTextEdit.Size = New System.Drawing.Size(312, 20)
        Me.nameTextEdit.TabIndex = 22
        '
        'firstNameTextEdit
        '
        Me.firstNameTextEdit.Location = New System.Drawing.Point(120, 108)
        Me.firstNameTextEdit.Name = "firstNameTextEdit"
        Me.firstNameTextEdit.Properties.NullText = "[First Name]"
        Me.firstNameTextEdit.Size = New System.Drawing.Size(153, 20)
        Me.firstNameTextEdit.TabIndex = 24
        '
        'ShippingAddressesXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 464)
        Me.Controls.Add(Me.ShippingDestinationsSplitContainerControl)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ShippingAddressesXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shipping Destinations"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShippingDestinationsSplitContainerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ShippingDestinationsSplitContainerControl.ResumeLayout(False)
        CType(Me.destinationsSearchGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.destinationsSearchGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.destinationsPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.destinationsPanelControl.ResumeLayout(False)
        Me.destinationsPanelControl.PerformLayout()
        CType(Me.faxTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emailTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.phoneTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.postalTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stateTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cityTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addressTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.noteMemoEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lastNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.firstNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents shippingDestinationsMenuBar As DevExpress.XtraBars.Bar
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
    Friend WithEvents ShippingDestinationsSplitContainerControl As DevExpress.XtraEditors.SplitContainerControl
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
    Friend WithEvents destinationsSearchGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents destinationsSearchGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents destinationIDGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents destinationsGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents destinationsPanelControl As DevExpress.XtraEditors.PanelControl
End Class
