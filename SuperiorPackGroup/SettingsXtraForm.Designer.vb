<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsXtraForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsXtraForm))
        Me.cancelSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.saveSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.packersTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.operatorsTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.supersTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.minutesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.customerLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.SetUpBreakTimesSimpleButton = New DevExpress.XtraEditors.SimpleButton()
        Me.LPNCopiesTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LPNMoveDownTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LPNMoveRightTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LPNPrinterTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.locationLookUpEdit = New DevExpress.XtraEditors.LookUpEdit()
        Me.locationsXpView = New DevExpress.Xpo.XPView(Me.components)
        CType(Me.packersTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.operatorsTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.supersTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minutesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.customerLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LPNCopiesTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LPNMoveDownTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LPNMoveRightTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LPNPrinterTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.locationLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.locationsXpView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cancelSimpleButton
        '
        Me.cancelSimpleButton.Location = New System.Drawing.Point(156, 198)
        Me.cancelSimpleButton.Name = "cancelSimpleButton"
        Me.cancelSimpleButton.Size = New System.Drawing.Size(75, 23)
        Me.cancelSimpleButton.TabIndex = 0
        Me.cancelSimpleButton.Text = "&Cancel"
        '
        'saveSimpleButton
        '
        Me.saveSimpleButton.Location = New System.Drawing.Point(237, 198)
        Me.saveSimpleButton.Name = "saveSimpleButton"
        Me.saveSimpleButton.Size = New System.Drawing.Size(75, 23)
        Me.saveSimpleButton.TabIndex = 1
        Me.saveSimpleButton.Text = "&Save"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(32, 82)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Packer's Pay:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(32, 108)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(76, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Operator's Pay:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(32, 134)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Super's Pay:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(32, 160)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl4.TabIndex = 5
        Me.LabelControl4.Text = "Min. per Hour:"
        '
        'packersTextEdit
        '
        Me.packersTextEdit.Location = New System.Drawing.Point(131, 79)
        Me.packersTextEdit.Name = "packersTextEdit"
        Me.packersTextEdit.Properties.DisplayFormat.FormatString = "c"
        Me.packersTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.packersTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.packersTextEdit.TabIndex = 6
        '
        'operatorsTextEdit
        '
        Me.operatorsTextEdit.Location = New System.Drawing.Point(131, 105)
        Me.operatorsTextEdit.Name = "operatorsTextEdit"
        Me.operatorsTextEdit.Properties.DisplayFormat.FormatString = "c"
        Me.operatorsTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.operatorsTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.operatorsTextEdit.TabIndex = 7
        '
        'supersTextEdit
        '
        Me.supersTextEdit.Location = New System.Drawing.Point(131, 131)
        Me.supersTextEdit.Name = "supersTextEdit"
        Me.supersTextEdit.Properties.DisplayFormat.FormatString = "c"
        Me.supersTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.supersTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.supersTextEdit.TabIndex = 8
        '
        'minutesTextEdit
        '
        Me.minutesTextEdit.Location = New System.Drawing.Point(131, 157)
        Me.minutesTextEdit.Name = "minutesTextEdit"
        Me.minutesTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.minutesTextEdit.TabIndex = 9
        '
        'customerLookUpEdit
        '
        Me.customerLookUpEdit.Location = New System.Drawing.Point(131, 46)
        Me.customerLookUpEdit.Name = "customerLookUpEdit"
        Me.customerLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.customerLookUpEdit.Properties.NullText = "[Select A Customer]"
        Me.customerLookUpEdit.Size = New System.Drawing.Size(100, 20)
        Me.customerLookUpEdit.TabIndex = 10
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(32, 49)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(93, 13)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "Universal Customer"
        '
        'SetUpBreakTimesSimpleButton
        '
        Me.SetUpBreakTimesSimpleButton.Location = New System.Drawing.Point(280, 12)
        Me.SetUpBreakTimesSimpleButton.Name = "SetUpBreakTimesSimpleButton"
        Me.SetUpBreakTimesSimpleButton.Size = New System.Drawing.Size(156, 23)
        Me.SetUpBreakTimesSimpleButton.TabIndex = 12
        Me.SetUpBreakTimesSimpleButton.Text = "Set Up Break Times"
        '
        'LPNCopiesTextEdit
        '
        Me.LPNCopiesTextEdit.Location = New System.Drawing.Point(336, 157)
        Me.LPNCopiesTextEdit.Name = "LPNCopiesTextEdit"
        Me.LPNCopiesTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.LPNCopiesTextEdit.TabIndex = 20
        '
        'LPNMoveDownTextEdit
        '
        Me.LPNMoveDownTextEdit.Location = New System.Drawing.Point(336, 131)
        Me.LPNMoveDownTextEdit.Name = "LPNMoveDownTextEdit"
        Me.LPNMoveDownTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.LPNMoveDownTextEdit.TabIndex = 19
        '
        'LPNMoveRightTextEdit
        '
        Me.LPNMoveRightTextEdit.Location = New System.Drawing.Point(336, 105)
        Me.LPNMoveRightTextEdit.Name = "LPNMoveRightTextEdit"
        Me.LPNMoveRightTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.LPNMoveRightTextEdit.TabIndex = 18
        '
        'LPNPrinterTextEdit
        '
        Me.LPNPrinterTextEdit.Location = New System.Drawing.Point(336, 79)
        Me.LPNPrinterTextEdit.Name = "LPNPrinterTextEdit"
        Me.LPNPrinterTextEdit.Size = New System.Drawing.Size(100, 20)
        Me.LPNPrinterTextEdit.TabIndex = 17
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(249, 160)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl6.TabIndex = 16
        Me.LabelControl6.Text = "LPN Copies:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(249, 134)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(81, 13)
        Me.LabelControl7.TabIndex = 15
        Me.LabelControl7.Text = "LPN Move Down:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(249, 108)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(79, 13)
        Me.LabelControl8.TabIndex = 14
        Me.LabelControl8.Text = "LPN Move Right:"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(249, 82)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl9.TabIndex = 13
        Me.LabelControl9.Text = "LPN Printer:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(249, 49)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(78, 13)
        Me.LabelControl10.TabIndex = 21
        Me.LabelControl10.Text = "Default Location"
        '
        'locationLookUpEdit
        '
        Me.locationLookUpEdit.Location = New System.Drawing.Point(336, 46)
        Me.locationLookUpEdit.Name = "locationLookUpEdit"
        Me.locationLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.locationLookUpEdit.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationId", "Location Id", 76, DevExpress.Utils.FormatType.Numeric, "", False, DevExpress.Utils.HorzAlignment.Far), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationCode", "Location Code", 78, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationName", "Location Name", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.locationLookUpEdit.Properties.DataSource = Me.locationsXpView
        Me.locationLookUpEdit.Properties.DisplayMember = "LocationCode"
        Me.locationLookUpEdit.Properties.NullText = "[Select default location]"
        Me.locationLookUpEdit.Properties.ValueMember = "LocationId"
        Me.locationLookUpEdit.Size = New System.Drawing.Size(100, 20)
        Me.locationLookUpEdit.TabIndex = 22
        '
        'locationsXpView
        '
        Me.locationsXpView.ObjectType = GetType(DXDAL.SPGData.Locations)
        Me.locationsXpView.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {New DevExpress.Xpo.ViewProperty("LocationId", DevExpress.Xpo.SortDirection.None, "[Oid]", False, True), New DevExpress.Xpo.ViewProperty("LocationCode", DevExpress.Xpo.SortDirection.None, "[LocationCode]", False, True), New DevExpress.Xpo.ViewProperty("LocationName", DevExpress.Xpo.SortDirection.None, "[LocationName]", False, True)})
        '
        'SettingsXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 264)
        Me.Controls.Add(Me.locationLookUpEdit)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.LPNCopiesTextEdit)
        Me.Controls.Add(Me.LPNMoveDownTextEdit)
        Me.Controls.Add(Me.LPNMoveRightTextEdit)
        Me.Controls.Add(Me.LPNPrinterTextEdit)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.SetUpBreakTimesSimpleButton)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.customerLookUpEdit)
        Me.Controls.Add(Me.minutesTextEdit)
        Me.Controls.Add(Me.supersTextEdit)
        Me.Controls.Add(Me.operatorsTextEdit)
        Me.Controls.Add(Me.packersTextEdit)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.saveSimpleButton)
        Me.Controls.Add(Me.cancelSimpleButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SettingsXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Company Settings"
        CType(Me.packersTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.operatorsTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.supersTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minutesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.customerLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LPNCopiesTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LPNMoveDownTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LPNMoveRightTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LPNPrinterTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.locationLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.locationsXpView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cancelSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents saveSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents packersTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents operatorsTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents supersTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents minutesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents customerLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SetUpBreakTimesSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LPNCopiesTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LPNMoveDownTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LPNMoveRightTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LPNPrinterTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents locationLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents locationsXpView As DevExpress.Xpo.XPView
End Class
