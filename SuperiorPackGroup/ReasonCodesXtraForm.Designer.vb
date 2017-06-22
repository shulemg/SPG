<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReasonCodesXtraForm
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
        Me.reasonCodesXpCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.reasonCodesGridControl = New DevExpress.XtraGrid.GridControl()
        Me.reassonCodesGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReasonType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReasonCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.saveSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.deleteSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.reasonCodesXpCollection,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.reasonCodesGridControl,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.reassonCodesGridView,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'reasonCodesXpCollection
        '
        Me.reasonCodesXpCollection.ObjectType = GetType(DXDAL.SPGData.ReasonCodes)
        '
        'reasonCodesGridControl
        '
        Me.reasonCodesGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.reasonCodesGridControl.DataSource = Me.reasonCodesXpCollection
        Me.reasonCodesGridControl.Location = New System.Drawing.Point(13, 13)
        Me.reasonCodesGridControl.MainView = Me.reassonCodesGridView
        Me.reasonCodesGridControl.Name = "reasonCodesGridControl"
        Me.reasonCodesGridControl.Size = New System.Drawing.Size(519, 320)
        Me.reasonCodesGridControl.TabIndex = 0
        Me.reasonCodesGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.reassonCodesGridView})
        '
        'reassonCodesGridView
        '
        Me.reassonCodesGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colReasonType, Me.colReasonCode, Me.colDescription})
        Me.reassonCodesGridView.GridControl = Me.reasonCodesGridControl
        Me.reassonCodesGridView.Name = "reassonCodesGridView"
        Me.reassonCodesGridView.OptionsView.ShowDetailButtons = false
        '
        'colOid
        '
        Me.colOid.FieldName = "Oid"
        Me.colOid.Name = "colOid"
        '
        'colReasonType
        '
        Me.colReasonType.FieldName = "ReasonType"
        Me.colReasonType.Name = "colReasonType"
        Me.colReasonType.Visible = true
        Me.colReasonType.VisibleIndex = 0
        Me.colReasonType.Width = 100
        '
        'colReasonCode
        '
        Me.colReasonCode.FieldName = "ReasonCode"
        Me.colReasonCode.Name = "colReasonCode"
        Me.colReasonCode.Visible = true
        Me.colReasonCode.VisibleIndex = 1
        Me.colReasonCode.Width = 90
        '
        'colDescription
        '
        Me.colDescription.FieldName = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.Visible = true
        Me.colDescription.VisibleIndex = 2
        Me.colDescription.Width = 311
        '
        'saveSimpleButton
        '
        Me.saveSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.saveSimpleButton.Location = New System.Drawing.Point(275, 339)
        Me.saveSimpleButton.Name = "saveSimpleButton"
        Me.saveSimpleButton.Size = New System.Drawing.Size(95, 32)
        Me.saveSimpleButton.TabIndex = 1
        Me.saveSimpleButton.Text = "Save"
        '
        'deleteSimpleButton
        '
        Me.deleteSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.deleteSimpleButton.Location = New System.Drawing.Point(174, 339)
        Me.deleteSimpleButton.Name = "deleteSimpleButton"
        Me.deleteSimpleButton.Size = New System.Drawing.Size(95, 32)
        Me.deleteSimpleButton.TabIndex = 2
        Me.deleteSimpleButton.Text = "Delete"
        '
        'ReasonCodesXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 384)
        Me.Controls.Add(Me.deleteSimpleButton)
        Me.Controls.Add(Me.saveSimpleButton)
        Me.Controls.Add(Me.reasonCodesGridControl)
        Me.Name = "ReasonCodesXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReasonCodesXtraForm"
        CType(Me.reasonCodesXpCollection,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.reasonCodesGridControl,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.reassonCodesGridView,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents reasonCodesXpCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents reasonCodesGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents reassonCodesGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReasonType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReasonCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescription As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents saveSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents deleteSimpleButton As DevExpress.XtraEditors.SimpleButton
End Class
