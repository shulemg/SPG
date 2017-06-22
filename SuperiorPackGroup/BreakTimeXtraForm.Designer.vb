<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BreakTimeXtraForm
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
        Me.breakTimeGridControl = New DevExpress.XtraGrid.GridControl
        Me.breakTimeXPCollection = New DevExpress.Xpo.XPCollection
        Me.breakTimeGridView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.deleteGridColumn = New DevExpress.XtraGrid.Columns.GridColumn
        Me.deleteRepositoryItemButtonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colWeekDay = New DevExpress.XtraGrid.Columns.GridColumn
        Me.weekDayRepositoryItemComboBox = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.colStartTime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.startRepositoryItemTimeEdit = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
        Me.colEndTime = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colStarting = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colEnding = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.breakTimeGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.breakTimeXPCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.breakTimeGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deleteRepositoryItemButtonEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.weekDayRepositoryItemComboBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.startRepositoryItemTimeEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'breakTimeGridControl
        '
        Me.breakTimeGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.breakTimeGridControl.DataSource = Me.breakTimeXPCollection
        Me.breakTimeGridControl.Location = New System.Drawing.Point(12, 12)
        Me.breakTimeGridControl.MainView = Me.breakTimeGridView
        Me.breakTimeGridControl.Name = "breakTimeGridControl"
        Me.breakTimeGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.weekDayRepositoryItemComboBox, Me.startRepositoryItemTimeEdit, Me.deleteRepositoryItemButtonEdit})
        Me.breakTimeGridControl.Size = New System.Drawing.Size(466, 240)
        Me.breakTimeGridControl.TabIndex = 0
        Me.breakTimeGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.breakTimeGridView})
        '
        'breakTimeXPCollection
        '
        Me.breakTimeXPCollection.DeleteObjectOnRemove = True
        Me.breakTimeXPCollection.ObjectType = GetType(DXDAL.SPGData.BreakTime)
        '
        'breakTimeGridView
        '
        Me.breakTimeGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.deleteGridColumn, Me.colOid, Me.colWeekDay, Me.colStartTime, Me.colEndTime, Me.colStarting, Me.colEnding})
        Me.breakTimeGridView.GridControl = Me.breakTimeGridControl
        Me.breakTimeGridView.Name = "breakTimeGridView"
        Me.breakTimeGridView.OptionsBehavior.AllowIncrementalSearch = True
        Me.breakTimeGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.breakTimeGridView.OptionsView.ShowAutoFilterRow = True
        '
        'deleteGridColumn
        '
        Me.deleteGridColumn.ColumnEdit = Me.deleteRepositoryItemButtonEdit
        Me.deleteGridColumn.Name = "deleteGridColumn"
        Me.deleteGridColumn.Visible = True
        Me.deleteGridColumn.VisibleIndex = 0
        Me.deleteGridColumn.Width = 25
        '
        'deleteRepositoryItemButtonEdit
        '
        Me.deleteRepositoryItemButtonEdit.AutoHeight = False
        Me.deleteRepositoryItemButtonEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)})
        Me.deleteRepositoryItemButtonEdit.Name = "deleteRepositoryItemButtonEdit"
        Me.deleteRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'colOid
        '
        Me.colOid.FieldName = "Oid"
        Me.colOid.Name = "colOid"
        '
        'colWeekDay
        '
        Me.colWeekDay.ColumnEdit = Me.weekDayRepositoryItemComboBox
        Me.colWeekDay.FieldName = "WeekDay"
        Me.colWeekDay.Name = "colWeekDay"
        Me.colWeekDay.Visible = True
        Me.colWeekDay.VisibleIndex = 1
        Me.colWeekDay.Width = 83
        '
        'weekDayRepositoryItemComboBox
        '
        Me.weekDayRepositoryItemComboBox.AutoHeight = False
        Me.weekDayRepositoryItemComboBox.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.weekDayRepositoryItemComboBox.Items.AddRange(New Object() {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"})
        Me.weekDayRepositoryItemComboBox.Name = "weekDayRepositoryItemComboBox"
        Me.weekDayRepositoryItemComboBox.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'colStartTime
        '
        Me.colStartTime.ColumnEdit = Me.startRepositoryItemTimeEdit
        Me.colStartTime.FieldName = "StartTime"
        Me.colStartTime.Name = "colStartTime"
        Me.colStartTime.Visible = True
        Me.colStartTime.VisibleIndex = 2
        Me.colStartTime.Width = 83
        '
        'startRepositoryItemTimeEdit
        '
        Me.startRepositoryItemTimeEdit.AutoHeight = False
        Me.startRepositoryItemTimeEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.startRepositoryItemTimeEdit.Name = "startRepositoryItemTimeEdit"
        '
        'colEndTime
        '
        Me.colEndTime.ColumnEdit = Me.startRepositoryItemTimeEdit
        Me.colEndTime.FieldName = "EndTime"
        Me.colEndTime.Name = "colEndTime"
        Me.colEndTime.Visible = True
        Me.colEndTime.VisibleIndex = 3
        Me.colEndTime.Width = 83
        '
        'colStarting
        '
        Me.colStarting.FieldName = "Starting"
        Me.colStarting.Name = "colStarting"
        Me.colStarting.Visible = True
        Me.colStarting.VisibleIndex = 4
        Me.colStarting.Width = 83
        '
        'colEnding
        '
        Me.colEnding.FieldName = "Ending"
        Me.colEnding.Name = "colEnding"
        Me.colEnding.Visible = True
        Me.colEnding.VisibleIndex = 5
        Me.colEnding.Width = 88
        '
        'BreakTimeXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 264)
        Me.Controls.Add(Me.breakTimeGridControl)
        Me.Name = "BreakTimeXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Break Time"
        CType(Me.breakTimeGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.breakTimeXPCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.breakTimeGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deleteRepositoryItemButtonEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.weekDayRepositoryItemComboBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.startRepositoryItemTimeEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents breakTimeGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents breakTimeGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents breakTimeXPCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colWeekDay As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStartTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEndTime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStarting As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEnding As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents weekDayRepositoryItemComboBox As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents startRepositoryItemTimeEdit As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    Friend WithEvents deleteGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents deleteRepositoryItemButtonEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
