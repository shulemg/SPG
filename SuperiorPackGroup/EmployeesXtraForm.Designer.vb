Imports DXDAL.SPGData

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employeesXtraForm
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(employeesXtraForm))
        Me.employeeGridControl = New DevExpress.XtraGrid.GridControl()
        Me.employeesXpCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.employeeGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFullName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLastName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.deleteSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.saveSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.employeeGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.employeesXpCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.employeeGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'employeeGridControl
        '
        Me.employeeGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.employeeGridControl.DataSource = Me.employeesXpCollection
        Me.employeeGridControl.Location = New System.Drawing.Point(0, 0)
        Me.employeeGridControl.MainView = Me.employeeGridView
        Me.employeeGridControl.Name = "employeeGridControl"
        Me.employeeGridControl.Size = New System.Drawing.Size(280, 268)
        Me.employeeGridControl.TabIndex = 0
        Me.employeeGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.employeeGridView})
        '
        'employeesXpCollection
        '
        Me.employeesXpCollection.ObjectType = GetType(DXDAL.SPGData.Employees)
        Me.employeesXpCollection.Sorting.AddRange(New DevExpress.Xpo.SortProperty() {New DevExpress.Xpo.SortProperty("[FullName]", DevExpress.Xpo.DB.SortingDirection.Ascending)})
        '
        'employeeGridView
        '
        Me.employeeGridView.ActiveFilterEnabled = False
        Me.employeeGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colFullName, Me.colFirstName, Me.colLastName})
        Me.employeeGridView.GridControl = Me.employeeGridControl
        Me.employeeGridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.employeeGridView.Name = "employeeGridView"
        Me.employeeGridView.OptionsCustomization.AllowGroup = False
        Me.employeeGridView.OptionsSelection.MultiSelect = True
        Me.employeeGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.employeeGridView.OptionsView.ShowDetailButtons = False
        Me.employeeGridView.OptionsView.ShowGroupPanel = False
        Me.employeeGridView.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colOid
        '
        Me.colOid.FieldName = "Oid"
        Me.colOid.Name = "colOid"
        Me.colOid.OptionsColumn.ReadOnly = True
        '
        'colFullName
        '
        Me.colFullName.FieldName = "FullName"
        Me.colFullName.Name = "colFullName"
        Me.colFullName.OptionsColumn.ReadOnly = True
        '
        'colFirstName
        '
        Me.colFirstName.FieldName = "FirstName"
        Me.colFirstName.Name = "colFirstName"
        Me.colFirstName.Visible = True
        Me.colFirstName.VisibleIndex = 0
        '
        'colLastName
        '
        Me.colLastName.FieldName = "LastName"
        Me.colLastName.Name = "colLastName"
        Me.colLastName.Visible = True
        Me.colLastName.VisibleIndex = 1
        '
        'deleteSimpleButton
        '
        Me.deleteSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.deleteSimpleButton.Location = New System.Drawing.Point(49, 275)
        Me.deleteSimpleButton.Name = "deleteSimpleButton"
        Me.deleteSimpleButton.Size = New System.Drawing.Size(75, 23)
        Me.deleteSimpleButton.TabIndex = 0
        Me.deleteSimpleButton.TabStop = False
        Me.deleteSimpleButton.Text = "&Delete"
        '
        'saveSimpleButton
        '
        Me.saveSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.saveSimpleButton.Location = New System.Drawing.Point(131, 275)
        Me.saveSimpleButton.Name = "saveSimpleButton"
        Me.saveSimpleButton.Size = New System.Drawing.Size(75, 23)
        Me.saveSimpleButton.TabIndex = 1
        Me.saveSimpleButton.Text = "&Save"
        '
        'employeesXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 309)
        Me.Controls.Add(Me.saveSimpleButton)
        Me.Controls.Add(Me.deleteSimpleButton)
        Me.Controls.Add(Me.employeeGridControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "employeesXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employees"
        CType(Me.employeeGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.employeesXpCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.employeeGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents employeeGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents employeeGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFullName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFirstName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLastName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents deleteSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents saveSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents employeesXpCollection As DevExpress.Xpo.XPCollection
End Class
