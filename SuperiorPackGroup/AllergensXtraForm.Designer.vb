<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AllergensXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AllergensXtraForm))
        Me.deleteSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.saveSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.machineLineGridControl = New DevExpress.XtraGrid.GridControl()
        Me.AllergenXpCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.allergenGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.idGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.nameGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.AllergenXpView = New DevExpress.Xpo.XPView(Me.components)
        CType(Me.machineLineGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllergenXpCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.allergenGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AllergenXpView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'deleteSimpleButton
        '
        Me.deleteSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.deleteSimpleButton.Location = New System.Drawing.Point(49, 273)
        Me.deleteSimpleButton.Name = "deleteSimpleButton"
        Me.deleteSimpleButton.Size = New System.Drawing.Size(75, 23)
        Me.deleteSimpleButton.TabIndex = 0
        Me.deleteSimpleButton.Text = "&Delete"
        '
        'saveSimpleButton
        '
        Me.saveSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.saveSimpleButton.Location = New System.Drawing.Point(131, 272)
        Me.saveSimpleButton.Name = "saveSimpleButton"
        Me.saveSimpleButton.Size = New System.Drawing.Size(75, 23)
        Me.saveSimpleButton.TabIndex = 1
        Me.saveSimpleButton.Text = "&Save && Close"
        '
        'machineLineGridControl
        '
        Me.machineLineGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.machineLineGridControl.DataSource = Me.AllergenXpCollection
        Me.machineLineGridControl.Location = New System.Drawing.Point(0, -2)
        Me.machineLineGridControl.MainView = Me.allergenGridView
        Me.machineLineGridControl.Name = "machineLineGridControl"
        Me.machineLineGridControl.Size = New System.Drawing.Size(254, 268)
        Me.machineLineGridControl.TabIndex = 2
        Me.machineLineGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.allergenGridView})
        '
        'AllergenXpCollection
        '
        Me.AllergenXpCollection.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNew
        Me.AllergenXpCollection.ObjectType = GetType(DXDAL.SPGData.Allergen)
        '
        'allergenGridView
        '
        Me.allergenGridView.ActiveFilterEnabled = False
        Me.allergenGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.idGridColumn, Me.nameGridColumn})
        Me.allergenGridView.GridControl = Me.machineLineGridControl
        Me.allergenGridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.allergenGridView.Name = "allergenGridView"
        Me.allergenGridView.OptionsCustomization.AllowGroup = False
        Me.allergenGridView.OptionsSelection.MultiSelect = True
        Me.allergenGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.allergenGridView.OptionsView.ShowGroupPanel = False
        Me.allergenGridView.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'idGridColumn
        '
        Me.idGridColumn.Caption = "GridColumn1"
        Me.idGridColumn.FieldName = "AllergenID"
        Me.idGridColumn.Name = "idGridColumn"
        '
        'nameGridColumn
        '
        Me.nameGridColumn.Caption = "Allergen "
        Me.nameGridColumn.FieldName = "AllergenName"
        Me.nameGridColumn.Name = "nameGridColumn"
        Me.nameGridColumn.Visible = True
        Me.nameGridColumn.VisibleIndex = 0
        '
        'AllergenXpView
        '
        Me.AllergenXpView.ObjectType = GetType(DXDAL.SPGData.Allergen)
        Me.AllergenXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("AllergenID", DevExpress.Xpo.SortDirection.None, "[AllergenID]", False, True), New DevExpress.Xpo.ViewProperty("AllergenName", DevExpress.Xpo.SortDirection.Ascending, "[AllergenName]", False, True)})
        '
        'AllergensXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 309)
        Me.Controls.Add(Me.machineLineGridControl)
        Me.Controls.Add(Me.saveSimpleButton)
        Me.Controls.Add(Me.deleteSimpleButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AllergensXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Allergens"
        CType(Me.machineLineGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllergenXpCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.allergenGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AllergenXpView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents deleteSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents saveSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents machineLineGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents allergenGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents idGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nameGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AllergenXpView As DevExpress.Xpo.XPView
    Friend WithEvents AllergenXpCollection As DevExpress.Xpo.XPCollection
End Class
