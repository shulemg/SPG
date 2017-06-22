<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginXtraForm
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
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.userNameTextEdit = New DevExpress.XtraEditors.TextEdit
        Me.passwordTextEdit = New DevExpress.XtraEditors.TextEdit
        CType(Me.userNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.passwordTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cancelSimpleButton
        '
        Me.cancelSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelSimpleButton.Location = New System.Drawing.Point(202, 134)
        Me.cancelSimpleButton.Name = "cancelSimpleButton"
        Me.cancelSimpleButton.Size = New System.Drawing.Size(75, 23)
        Me.cancelSimpleButton.TabIndex = 5
        Me.cancelSimpleButton.Text = "&Cancel"
        '
        'okSimpleButton
        '
        Me.okSimpleButton.Location = New System.Drawing.Point(121, 134)
        Me.okSimpleButton.Name = "okSimpleButton"
        Me.okSimpleButton.Size = New System.Drawing.Size(75, 23)
        Me.okSimpleButton.TabIndex = 4
        Me.okSimpleButton.Text = "&OK"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(89, 32)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "&User Name"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(89, 77)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "&Password"
        '
        'userNameTextEdit
        '
        Me.userNameTextEdit.Location = New System.Drawing.Point(89, 51)
        Me.userNameTextEdit.Name = "userNameTextEdit"
        Me.userNameTextEdit.Size = New System.Drawing.Size(220, 20)
        Me.userNameTextEdit.TabIndex = 1
        '
        'passwordTextEdit
        '
        Me.passwordTextEdit.Location = New System.Drawing.Point(89, 96)
        Me.passwordTextEdit.Name = "passwordTextEdit"
        Me.passwordTextEdit.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordTextEdit.Size = New System.Drawing.Size(220, 20)
        Me.passwordTextEdit.TabIndex = 3
        '
        'LoginXtraForm
        '
        Me.AcceptButton = Me.okSimpleButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cancelSimpleButton
        Me.ClientSize = New System.Drawing.Size(399, 189)
        Me.ControlBox = False
        Me.Controls.Add(Me.passwordTextEdit)
        Me.Controls.Add(Me.userNameTextEdit)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.okSimpleButton)
        Me.Controls.Add(Me.cancelSimpleButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginXtraForm"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Log In"
        CType(Me.userNameTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.passwordTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cancelSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents okSimpleButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents userNameTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents passwordTextEdit As DevExpress.XtraEditors.TextEdit
End Class
