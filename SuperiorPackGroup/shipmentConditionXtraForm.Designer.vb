<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class shipmentConditionXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(shipmentConditionXtraForm))
        Me.saveSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.deleteSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.conditionsGridControl = New DevExpress.XtraGrid.GridControl()
        Me.shipmentConditionsXpCollection = New DevExpress.Xpo.XPCollection(Me.components)
        Me.conditionsGridView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colShipmentCondition = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.conditionsGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shipmentConditionsXpCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.conditionsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'saveSimpleButton
        '
        Me.saveSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.saveSimpleButton.Location = New System.Drawing.Point(131, 275)
        Me.saveSimpleButton.Name = "saveSimpleButton"
        Me.saveSimpleButton.Size = New System.Drawing.Size(75, 23)
        Me.saveSimpleButton.TabIndex = 4
        Me.saveSimpleButton.Text = "&Save"
        '
        'deleteSimpleButton
        '
        Me.deleteSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.deleteSimpleButton.Location = New System.Drawing.Point(49, 275)
        Me.deleteSimpleButton.Name = "deleteSimpleButton"
        Me.deleteSimpleButton.Size = New System.Drawing.Size(75, 23)
        Me.deleteSimpleButton.TabIndex = 2
        Me.deleteSimpleButton.TabStop = False
        Me.deleteSimpleButton.Text = "&Delete"
        '
        'conditionsGridControl
        '
        Me.conditionsGridControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.conditionsGridControl.DataSource = Me.shipmentConditionsXpCollection
        Me.conditionsGridControl.Location = New System.Drawing.Point(0, 0)
        Me.conditionsGridControl.MainView = Me.conditionsGridView
        Me.conditionsGridControl.Name = "conditionsGridControl"
        Me.conditionsGridControl.Size = New System.Drawing.Size(280, 268)
        Me.conditionsGridControl.TabIndex = 3
        Me.conditionsGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.conditionsGridView})
        '
        'shipmentConditionsXpCollection
        '
        Me.shipmentConditionsXpCollection.ObjectType = GetType(DXDAL.SPGData.ShipmentConditions)
        Me.shipmentConditionsXpCollection.Sorting.AddRange(New DevExpress.Xpo.SortProperty() {New DevExpress.Xpo.SortProperty("[ShipmentCondition]", DevExpress.Xpo.DB.SortingDirection.Ascending)})
        '
        'conditionsGridView
        '
        Me.conditionsGridView.ActiveFilterEnabled = False
        Me.conditionsGridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colShipmentCondition})
        Me.conditionsGridView.GridControl = Me.conditionsGridControl
        Me.conditionsGridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.conditionsGridView.Name = "conditionsGridView"
        Me.conditionsGridView.OptionsCustomization.AllowGroup = False
        Me.conditionsGridView.OptionsSelection.MultiSelect = True
        Me.conditionsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.conditionsGridView.OptionsView.ShowDetailButtons = False
        Me.conditionsGridView.OptionsView.ShowGroupPanel = False
        Me.conditionsGridView.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll
        '
        'colOid
        '
        Me.colOid.FieldName = "Oid"
        Me.colOid.Name = "colOid"
        Me.colOid.OptionsColumn.ReadOnly = True
        '
        'colShipmentCondition
        '
        Me.colShipmentCondition.FieldName = "ShipmentCondition"
        Me.colShipmentCondition.Name = "colShipmentCondition"
        Me.colShipmentCondition.Visible = True
        Me.colShipmentCondition.VisibleIndex = 0
        '
        'shipmentConditionXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 309)
        Me.Controls.Add(Me.saveSimpleButton)
        Me.Controls.Add(Me.deleteSimpleButton)
        Me.Controls.Add(Me.conditionsGridControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "shipmentConditionXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shipment Conditions"
        CType(Me.conditionsGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shipmentConditionsXpCollection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.conditionsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents saveSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents deleteSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents conditionsGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents shipmentConditionsXpCollection As DevExpress.Xpo.XPCollection
    Friend WithEvents conditionsGridView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colOid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colShipmentCondition As DevExpress.XtraGrid.Columns.GridColumn
End Class
