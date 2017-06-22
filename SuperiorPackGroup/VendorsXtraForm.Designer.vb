<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VendorsXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VendorsXtraForm))
        Me.vendorsXPCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.vendorsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVendorName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.deleteGridColumn = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.deleteRepositoryItemButtonEdit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        CType(Me.vendorsXPCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vendorsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.deleteRepositoryItemButtonEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vendorsXPCollection
        '
        Me.vendorsXPCollection.DeleteObjectOnRemove = True
        Me.vendorsXPCollection.ObjectType = GetType(DXDAL.SPGData.Vendor)
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.vendorsXPCollection
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.vendorsGridView
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.deleteRepositoryItemButtonEdit})
        Me.GridControl1.Size = New System.Drawing.Size(254, 309)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.vendorsGridView})
        '
        'vendorsGridView
        '
        Me.vendorsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colVendorName, Me.deleteGridColumn})
        Me.vendorsGridView.GridControl = Me.GridControl1
        Me.vendorsGridView.Name = "vendorsGridView"
        Me.vendorsGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.vendorsGridView.OptionsDetail.EnableMasterViewMode = False
        Me.vendorsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.vendorsGridView.OptionsView.ShowAutoFilterRow = True
        Me.vendorsGridView.OptionsView.ShowGroupPanel = False
        '
        'colOid
        '
        Me.colOid.FieldName = "Oid"
        Me.colOid.Name = "colOid"
        '
        'colVendorName
        '
        Me.colVendorName.FieldName = "VendorName"
        Me.colVendorName.Name = "colVendorName"
        Me.colVendorName.Visible = True
        Me.colVendorName.VisibleIndex = 1
        '
        'deleteGridColumn
        '
        Me.deleteGridColumn.ColumnEdit = Me.deleteRepositoryItemButtonEdit
        Me.deleteGridColumn.MaxWidth = 25
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
        'VendorsXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 309)
        Me.Controls.Add(Me.GridControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VendorsXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vendors"
        CType(Me.vendorsXPCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vendorsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.deleteRepositoryItemButtonEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vendorsXPCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents vendorsGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVendorName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents deleteGridColumn As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents deleteRepositoryItemButtonEdit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
