Imports System
Imports SuperiorPackGroup.Utilities

Public Class LoginXtraForm 

    Private m_Wrong As Integer = 0
    Protected m_Users As UsersBLL

    Private Sub okSimpleButton_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles okSimpleButton.Click

        Try
            m_Users = New UsersBLL

            Dim securityLevel As String = m_Users.GetUserSecurityLevel(FilterQuote(userNameTextEdit.Text), FilterQuote(passwordTextEdit.Text))

            If String.IsNullOrEmpty(securityLevel) Then
                m_Wrong += 1
                If m_Wrong >= 4 Then
                    MessageBox.Show("Wrong User Name or Password", "Incorrect Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    Exit Sub
                Else
                    MessageBox.Show("Wrong User Name or Password", "Incorrect Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    passwordTextEdit.Text = ""
                    userNameTextEdit.Focus()
                    userNameTextEdit.SelectionLength = userNameTextEdit.Text.Length
                    Exit Sub
                End If
            Else
                My.Settings.UserName = userNameTextEdit.Text
                My.Settings.UserSecurityLevel = securityLevel
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Encounterd", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub cancelSimpleButton_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles cancelSimpleButton.Click

        Me.Close()

    End Sub

End Class