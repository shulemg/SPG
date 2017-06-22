<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatabaseSelectionXtraForm
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
        Me.cancelSimpleButton = New DevExpress.XtraEditors.SimpleButton
        Me.okSimpleButton = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.serverLookUpEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.refreshSimpleButton = New DevExpress.XtraEditors.SimpleButton
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.sqlAuthenticationPanelControl = New DevExpress.XtraEditors.PanelControl
        Me.passwordTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.userNameTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.logOnRadioGroup = New DevExpress.XtraEditors.RadioGroup
        Me.dataBaseLookUpEdit = New DevExpress.XtraEditors.LookUpEdit
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.testConnectionSimpleButton = New DevExpress.XtraEditors.SimpleButton
        Me.refreshDatabasesSimpleButton = New DevExpress.XtraEditors.SimpleButton
        Me.serversBackgroundWorker = New System.ComponentModel.BackgroundWorker
        CType(Me.serverLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.sqlAuthenticationPanelControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sqlAuthenticationPanelControl.SuspendLayout()
        CType(Me.passwordTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.userNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logOnRadioGroup.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataBaseLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cancelSimpleButton
        '
        Me.cancelSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cancelSimpleButton.Location = New System.Drawing.Point(195, 409)
        Me.cancelSimpleButton.Name = "cancelSimpleButton"
        Me.cancelSimpleButton.Size = New System.Drawing.Size(75, 23)
        Me.cancelSimpleButton.TabIndex = 9
        Me.cancelSimpleButton.Text = "&Cancel"
        '
        'okSimpleButton
        '
        Me.okSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.okSimpleButton.Location = New System.Drawing.Point(277, 409)
        Me.okSimpleButton.Name = "okSimpleButton"
        Me.okSimpleButton.Size = New System.Drawing.Size(75, 23)
        Me.okSimpleButton.TabIndex = 8
        Me.okSimpleButton.Text = "&OK"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(28, 42)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(149, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Select or Enter a Server Name:"
        '
        'serverLookUpEdit
        '
        Me.serverLookUpEdit.Location = New System.Drawing.Point(28, 62)
        Me.serverLookUpEdit.Name = "serverLookUpEdit"
        Me.serverLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.serverLookUpEdit.Properties.NullText = "[Select A Server]"
        Me.serverLookUpEdit.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup
        Me.serverLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.serverLookUpEdit.Size = New System.Drawing.Size(223, 20)
        Me.serverLookUpEdit.TabIndex = 2
        '
        'refreshSimpleButton
        '
        Me.refreshSimpleButton.Location = New System.Drawing.Point(257, 59)
        Me.refreshSimpleButton.Name = "refreshSimpleButton"
        Me.refreshSimpleButton.Size = New System.Drawing.Size(95, 23)
        Me.refreshSimpleButton.TabIndex = 0
        Me.refreshSimpleButton.Text = "Refresh"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.sqlAuthenticationPanelControl)
        Me.GroupControl1.Controls.Add(Me.logOnRadioGroup)
        Me.GroupControl1.Location = New System.Drawing.Point(28, 103)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(324, 188)
        Me.GroupControl1.TabIndex = 3
        Me.GroupControl1.Text = "Log on to the server"
        '
        'sqlAuthenticationPanelControl
        '
        Me.sqlAuthenticationPanelControl.Controls.Add(Me.passwordTextEdit)
        Me.sqlAuthenticationPanelControl.Controls.Add(Me.userNameTextEdit)
        Me.sqlAuthenticationPanelControl.Controls.Add(Me.LabelControl3)
        Me.sqlAuthenticationPanelControl.Controls.Add(Me.LabelControl2)
        Me.sqlAuthenticationPanelControl.Enabled = False
        Me.sqlAuthenticationPanelControl.Location = New System.Drawing.Point(23, 85)
        Me.sqlAuthenticationPanelControl.Name = "sqlAuthenticationPanelControl"
        Me.sqlAuthenticationPanelControl.Size = New System.Drawing.Size(276, 85)
        Me.sqlAuthenticationPanelControl.TabIndex = 1
        '
        'passwordTextEdit
        '
        Me.passwordTextEdit.Location = New System.Drawing.Point(102, 46)
        Me.passwordTextEdit.Name = "passwordTextEdit"
        Me.passwordTextEdit.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTextEdit.Size = New System.Drawing.Size(146, 20)
        Me.passwordTextEdit.TabIndex = 3
        '
        'userNameTextEdit
        '
        Me.userNameTextEdit.Location = New System.Drawing.Point(102, 19)
        Me.userNameTextEdit.Name = "userNameTextEdit"
        Me.userNameTextEdit.Size = New System.Drawing.Size(146, 20)
        Me.userNameTextEdit.TabIndex = 1
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(29, 49)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Password"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(29, 22)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "User Name"
        '
        'logOnRadioGroup
        '
        Me.logOnRadioGroup.EditValue = True
        Me.logOnRadioGroup.Location = New System.Drawing.Point(21, 24)
        Me.logOnRadioGroup.Name = "logOnRadioGroup"
        Me.logOnRadioGroup.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Use Windows Authentication"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Use SQL Server Authentication")})
        Me.logOnRadioGroup.Size = New System.Drawing.Size(189, 55)
        Me.logOnRadioGroup.TabIndex = 0
        '
        'dataBaseLookUpEdit
        '
        Me.dataBaseLookUpEdit.Enabled = False
        Me.dataBaseLookUpEdit.Location = New System.Drawing.Point(28, 339)
        Me.dataBaseLookUpEdit.Name = "dataBaseLookUpEdit"
        Me.dataBaseLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dataBaseLookUpEdit.Properties.NullText = "[Select A Database]"
        Me.dataBaseLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.dataBaseLookUpEdit.Size = New System.Drawing.Size(223, 20)
        Me.dataBaseLookUpEdit.TabIndex = 6
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(28, 319)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(163, 13)
        Me.LabelControl4.TabIndex = 5
        Me.LabelControl4.Text = "Select or Enter a Database Name:"
        '
        'testConnectionSimpleButton
        '
        Me.testConnectionSimpleButton.Enabled = False
        Me.testConnectionSimpleButton.Location = New System.Drawing.Point(12, 409)
        Me.testConnectionSimpleButton.Name = "testConnectionSimpleButton"
        Me.testConnectionSimpleButton.Size = New System.Drawing.Size(95, 23)
        Me.testConnectionSimpleButton.TabIndex = 7
        Me.testConnectionSimpleButton.Text = "Test Connection"
        '
        'refreshDatabasesSimpleButton
        '
        Me.refreshDatabasesSimpleButton.Location = New System.Drawing.Point(257, 336)
        Me.refreshDatabasesSimpleButton.Name = "refreshDatabasesSimpleButton"
        Me.refreshDatabasesSimpleButton.Size = New System.Drawing.Size(95, 23)
        Me.refreshDatabasesSimpleButton.TabIndex = 4
        Me.refreshDatabasesSimpleButton.Text = "Refresh"
        '
        'serversBackgroundWorker
        '
        '
        'DatabaseSelectionXtraForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 444)
        Me.ControlBox = False
        Me.Controls.Add(Me.refreshDatabasesSimpleButton)
        Me.Controls.Add(Me.testConnectionSimpleButton)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.dataBaseLookUpEdit)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.refreshSimpleButton)
        Me.Controls.Add(Me.serverLookUpEdit)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.okSimpleButton)
        Me.Controls.Add(Me.cancelSimpleButton)
        Me.Name = "DatabaseSelectionXtraForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Select Database"
        CType(Me.serverLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.sqlAuthenticationPanelControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sqlAuthenticationPanelControl.ResumeLayout(False)
        Me.sqlAuthenticationPanelControl.PerformLayout()
        CType(Me.passwordTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.userNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logOnRadioGroup.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataBaseLookUpEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cancelSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents okSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents serverLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents refreshSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents logOnRadioGroup As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents sqlAuthenticationPanelControl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents passwordTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents userNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dataBaseLookUpEdit As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents testConnectionSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents refreshDatabasesSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents serversBackgroundWorker As System.ComponentModel.BackgroundWorker
End Class
