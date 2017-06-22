<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShiftsXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShiftsXtraForm))
        Me.shiftsGridControl = New DevExpress.XtraGrid.GridControl
        Me.shiftsGridView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.idGridColumn = New DevExpress.XtraGrid.Columns.GridColumn
        Me.shiftGridColumn = New DevExpress.XtraGrid.Columns.GridColumn
        Me.deleteSimpleButton = New DevExpress.XtraEditors.SimpleButton
        Me.saveSimpleButton = New DevExpress.XtraEditors.SimpleButton
        Me.deleteRepositoryItemButtonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        CType(Me.shiftsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shiftsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deleteRepositoryItemButtonEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'shiftsGridControl
        '
        Me.shiftsGridControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.shiftsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.shiftsGridControl.MainView = Me.shiftsGridView
        Me.shiftsGridControl.Name = "shiftsGridControl"
        Me.shiftsGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.deleteRepositoryItemButtonEdit})
        Me.shiftsGridControl.Size = New System.Drawing.Size(254, 268)
        Me.shiftsGridControl.TabIndex = 0
        Me.shiftsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.shiftsGridView})
        '
        'shiftsGridView
        '
        Me.shiftsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.idGridColumn, Me.shiftGridColumn})
        Me.shiftsGridView.GridControl = Me.shiftsGridControl
        Me.shiftsGridView.Name = "shiftsGridView"
        Me.shiftsGridView.OptionsSelection.MultiSelect = True
        Me.shiftsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.shiftsGridView.OptionsView.ShowGroupPanel = False
        '
        'idGridColumn
        '
        Me.idGridColumn.Caption = "GridColumn1"
        Me.idGridColumn.Name = "idGridColumn"
        '
        'shiftGridColumn
        '
        Me.shiftGridColumn.Caption = "Shift"
        Me.shiftGridColumn.Name = "shiftGridColumn"
        Me.shiftGridColumn.Visible = True
        Me.shiftGridColumn.VisibleIndex = 0
        '
        'deleteSimpleButton
        '
        Me.deleteSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.deleteSimpleButton.Location = New System.Drawing.Point(49, 274)
        Me.deleteSimpleButton.Name = "deleteSimpleButton"
        Me.deleteSimpleButton.Size = New System.Drawing.Size(75, 23)
        Me.deleteSimpleButton.TabIndex = 1
        Me.deleteSimpleButton.Text = "&Delete"
        '
        'saveSimpleButton
        '
        Me.saveSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.saveSimpleButton.Location = New System.Drawing.Point(131, 274)
        Me.saveSimpleButton.Name = "saveSimpleButton"
        Me.saveSimpleButton.Size = New System.Drawing.Size(75, 23)
        Me.saveSimpleButton.TabIndex = 2
        Me.saveSimpleButton.Text = "&Save"
        '
        'deleteRepositoryItemButtonEdit
        '
        Me.deleteRepositoryItemButtonEdit.AutoHeight = False
        Me.deleteRepositoryItemButtonEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.deleteRepositoryItemButtonEdit.Name = "deleteRepositoryItemButtonEdit"
        Me.deleteRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'ShiftsXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 309)
        Me.Controls.Add(Me.saveSimpleButton)
        Me.Controls.Add(Me.deleteSimpleButton)
        Me.Controls.Add(Me.shiftsGridControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ShiftsXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shifts"
        CType(Me.shiftsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shiftsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deleteRepositoryItemButtonEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents shiftsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents shiftsGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents deleteSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents saveSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents idGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents shiftGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents deleteRepositoryItemButtonEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
