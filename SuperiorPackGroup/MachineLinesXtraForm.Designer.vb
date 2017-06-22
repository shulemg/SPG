<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MachineLinesXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MachineLinesXtraForm))
        Me.deleteSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.saveSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.machineLineGridControl = New DevExpress.XtraGrid.GridControl()
        Me.machineLineGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.idGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.nameGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.machineLineGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.machineLineGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.saveSimpleButton.Text = "&Save"
        '
        'machineLineGridControl
        '
        Me.machineLineGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.machineLineGridControl.Location = New System.Drawing.Point(0, -2)
        Me.machineLineGridControl.MainView = Me.machineLineGridView
        Me.machineLineGridControl.Name = "machineLineGridControl"
        Me.machineLineGridControl.Size = New System.Drawing.Size(254, 268)
        Me.machineLineGridControl.TabIndex = 2
        Me.machineLineGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.machineLineGridView})
        '
        'machineLineGridView
        '
        Me.machineLineGridView.ActiveFilterEnabled = False
        Me.machineLineGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.idGridColumn, Me.nameGridColumn})
        Me.machineLineGridView.GridControl = Me.machineLineGridControl
        Me.machineLineGridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.machineLineGridView.Name = "machineLineGridView"
        Me.machineLineGridView.OptionsCustomization.AllowGroup = False
        Me.machineLineGridView.OptionsSelection.MultiSelect = True
        Me.machineLineGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.machineLineGridView.OptionsView.ShowGroupPanel = False
        Me.machineLineGridView.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'idGridColumn
        '
        Me.idGridColumn.Caption = "GridColumn1"
        Me.idGridColumn.Name = "idGridColumn"
        '
        'nameGridColumn
        '
        Me.nameGridColumn.Caption = "Machine Line"
        Me.nameGridColumn.Name = "nameGridColumn"
        Me.nameGridColumn.Visible = True
        Me.nameGridColumn.VisibleIndex = 0
        '
        'MachineLinesXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 309)
        Me.Controls.Add(Me.machineLineGridControl)
        Me.Controls.Add(Me.saveSimpleButton)
        Me.Controls.Add(Me.deleteSimpleButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MachineLinesXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Machine Lines"
        CType(Me.machineLineGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.machineLineGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents deleteSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents saveSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents machineLineGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents machineLineGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents idGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nameGridColumn As DevExpress.XtraGrid.Columns.GridColumn
End Class
