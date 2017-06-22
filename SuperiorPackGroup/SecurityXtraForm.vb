Imports System.Drawing
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DXDAL.SPGData

Public Class SecurityXtraForm

    Private m_Users As UsersBLL
    Private m_UserPermissions As UserPermissionsBLL
    Private m_CustomersUOW As UnitOfWork

    Private Sub SecurityXtraForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Me.usersListBoxControl.Enabled = False Then
            Select Case MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                Case Windows.Forms.DialogResult.Yes
                    If SaveChanges() = False Then
                        e.Cancel = True
                    End If
                Case Windows.Forms.DialogResult.No
                    CancelChanges()
                Case Windows.Forms.DialogResult.Cancel
                    e.Cancel = True
            End Select
        End If

    End Sub

    Private Sub SecurityXtraForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        m_Users = New UsersBLL
        m_UserPermissions = New UserPermissionsBLL

        CheckPermissions()

        Me.usersListBoxControl.ValueMember = "strUserName"
        usersListBoxControl.DisplayMember = "strUserName"
        BindUsersListBox()

        Me.permissionIDGridColumn.FieldName = "UserPermissionID"
        Me.permissionLevelGridColumn.FieldName = "PermissionLevel"
        Me.permissionObjectGridColumn.FieldName = "PermissionObject"
        Me.userNaemGridColumn.FieldName = "UserName"

        Me.passwordTextEdit.Properties.ReadOnly = True
        Me.confirmTextEdit.Properties.ReadOnly = True
        locationLookUpEdit.Properties.ReadOnly = True
        resetSimpleButton.Enabled = False
        Me.usersListBoxControl.Enabled = True
        Me.userPermissionsGridView.OptionsBehavior.Editable = False
        Me.customersGridView.OptionsBehavior.Editable = False

        m_CustomersUOW = New UnitOfWork(SPGDataLayer)

    End Sub

    Public Sub BindUsersListBox()

        Me.usersListBoxControl.DataSource = m_Users.GetUsers

    End Sub

    Private Sub usersListBoxControl_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usersListBoxControl.SelectedValueChanged

        If Me.usersListBoxControl.SelectedIndex <> -1 Then
            BindSecurityControls(Me.usersListBoxControl.SelectedValue.ToString)
        End If

    End Sub

    Public Sub BindSecurityControls(ByVal user As String)

        Dim userPassword As String = m_Users.GetUserPassword(user)
        Me.nameTextEdit.EditValue = Me.usersListBoxControl.SelectedValue
        Me.nameTextEdit.Enabled = False
        Me.passwordTextEdit.EditValue = userPassword
        Me.confirmTextEdit.EditValue = userPassword
        Try
            locationLookUpEdit.EditValue = UsersBLL.GetUserByName(m_CustomersUOW, user).DefaultLocation.Oid
        Catch
            locationLookUpEdit.EditValue = Nothing
        End Try

        Me.userPermissionsGridControl.DataSource = m_UserPermissions.GetUserPermissionsByUserName(user, Nothing)
        If user = "Admin" Then
            Me.customersXtraTabPage.PageVisible = False
        Else
            Me.customersXtraTabPage.PageVisible = True
            Me.customersXPCollection.Criteria = CriteriaOperator.Parse(String.Format("User.strUserName = '{0}'", user))
        End If

    End Sub

    Public Function CheckPermissions() As Boolean

        Try
            Dim permission As SPG.UserPermissionsRow = New UserPermissionsBLL().GetUserPermissionsByUserName(My.Settings.UserName, "Security Settings")(0)

            Select Case permission.PermissionLevel
                Case "FULL", "Full"
                    Me.passwordTextEdit.Properties.PasswordChar = CChar("")
                    Me.confirmTextEdit.Properties.PasswordChar = CChar("")
                    Me.addBarButtonItem.Enabled = True
                    Me.editBarButtonItem.Enabled = True
                    Me.deleteBarButtonItem.Enabled = True
                Case "ADD", "Add"
                    Me.passwordTextEdit.Properties.PasswordChar = "*"c
                    Me.confirmTextEdit.Properties.PasswordChar = "*"c
                    Me.addBarButtonItem.Enabled = True
                    Me.editBarButtonItem.Enabled = True
                    Me.deleteBarButtonItem.Enabled = False
                Case "NONE", "None", "VIEW ASSIGNED", "EDIT ASSIGNED"
                    MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Me.Close()
                    Return False
                Case "VIEW", "View"
                    Me.passwordTextEdit.Properties.PasswordChar = "*"c
                    Me.confirmTextEdit.Properties.PasswordChar = "*"c
                    Me.addBarButtonItem.Enabled = False
                    Me.editBarButtonItem.Enabled = False
                    Me.deleteBarButtonItem.Enabled = False
                Case "EDIT", "Edit"
                    Me.passwordTextEdit.Properties.PasswordChar = "*"c
                    Me.confirmTextEdit.Properties.PasswordChar = "*"c
                    Me.addBarButtonItem.Enabled = False
                    Me.editBarButtonItem.Enabled = True
                    Me.deleteBarButtonItem.Enabled = False
                Case Else
                    MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Me.Close()
                    Return False
            End Select
            Return True
        Catch ex As InvalidOperationException
            Return False
        End Try

    End Function

    Private Function SaveChanges() As Boolean

        Dim selectedUser As String = Me.nameTextEdit.Text

        Dim location As Locations
        If locationLookUpEdit.EditValue IsNot Nothing Then
            location = Session.DefaultSession.GetObjectByKey(Of Locations)(locationLookUpEdit.EditValue)
        Else
            location = Nothing
        End If

        Try
            If m_Users.UpdateUser(selectedUser, Me.passwordTextEdit.Text, Me.confirmTextEdit.Text, location) <> True Then
                MessageBox.Show("The user was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        Try
            Me.userPermissionsGridView.SelectAll()
            If Me.userPermissionsGridView.SelectedRowsCount > 0 Then
                Dim permissions As Integer = Me.userPermissionsGridView.SelectedRowsCount
                Dim i As Integer = 0
                Do While i < permissions
                    Dim permission As Integer = Me.userPermissionsGridView.GetSelectedRows(i)
                    If permission >= 0 Then
                        If m_UserPermissions.UpdateUserPermissions(CType(userPermissionsGridView.GetRowCellValue(permission, permissionIDGridColumn), Integer?), _
                                                                   userPermissionsGridView.GetRowCellValue(permission, permissionObjectGridColumn).ToString, _
                                                                   userPermissionsGridView.GetRowCellValue(permission, permissionLevelGridColumn).ToString, selectedUser) <> True Then
                            MessageBox.Show("The user permissions was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return False
                        End If
                    End If
                    i += 1
                Loop
            End If
            m_CustomersUOW.CommitChanges()
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        BindUsersListBox()
        Me.usersListBoxControl.SelectedValue = selectedUser

        Me.passwordTextEdit.Properties.ReadOnly = True
        Me.confirmTextEdit.Properties.ReadOnly = True
        locationLookUpEdit.Properties.ReadOnly = True
        resetSimpleButton.Enabled = False
        Me.usersListBoxControl.Enabled = True
        Me.userPermissionsGridView.OptionsBehavior.Editable = False
        Me.customersGridView.OptionsBehavior.Editable = False
        Return True

    End Function

    Private Sub saveBarButtonItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles saveBarButtonItem.ItemClick

        If SaveChanges() Then
            CheckPermissions()
            cancelBarButtonItem.Enabled = False
            saveBarButtonItem.Enabled = False
        End If

    End Sub

    Private Sub addBarButtonItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles addBarButtonItem.ItemClick

        Me.nameTextEdit.Text = Nothing
        Me.nameTextEdit.Enabled = True
        Me.passwordTextEdit.EditValue = Nothing
        Me.confirmTextEdit.EditValue = Nothing
        locationLookUpEdit.EditValue = Nothing

        Me.userPermissionsGridControl.DataSource = m_UserPermissions.GetUserPermissionsByUserName("", Nothing)
        Me.customersXPCollection.Criteria = CriteriaOperator.Parse("User.strUserName IS NULL")

        Me.passwordTextEdit.Properties.ReadOnly = False
        Me.confirmTextEdit.Properties.ReadOnly = False
        locationLookUpEdit.Properties.ReadOnly = False
        resetSimpleButton.Enabled = True
        Me.usersListBoxControl.Enabled = False
        Me.userPermissionsGridView.OptionsBehavior.Editable = True
        Me.customersGridView.OptionsBehavior.Editable = True

        Me.cancelBarButtonItem.Enabled = True
        Me.saveBarButtonItem.Enabled = True
        Me.editBarButtonItem.Enabled = False
        Me.addBarButtonItem.Enabled = False
        Me.deleteBarButtonItem.Enabled = False

    End Sub

    Private Sub CancelChanges()

        If Me.usersListBoxControl.SelectedIndex <> -1 Then
            If m_CustomersUOW.InTransaction = True Then
                m_CustomersUOW.RollbackTransaction()
            End If
            BindSecurityControls(Me.usersListBoxControl.SelectedValue.ToString)
        End If

        Me.passwordTextEdit.Properties.ReadOnly = True
        Me.confirmTextEdit.Properties.ReadOnly = True
        locationLookUpEdit.Properties.ReadOnly = True
        resetSimpleButton.Enabled = False
        Me.usersListBoxControl.Enabled = True
        Me.userPermissionsGridView.OptionsBehavior.Editable = False
        Me.customersGridView.OptionsBehavior.Editable = False

    End Sub

    Private Sub cancelBarButtonItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cancelBarButtonItem.ItemClick

        CancelChanges()
        CheckPermissions()
        cancelBarButtonItem.Enabled = False
        saveBarButtonItem.Enabled = False

    End Sub

    Private Sub deleteBarButtonItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles deleteBarButtonItem.ItemClick

        If Me.nameTextEdit.Text.ToLower = "admin" Then
            MessageBox.Show("You can't Delete the Admin User")
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to delete this user?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If m_UserPermissions.DeleteUserPermissions(Me.nameTextEdit.Text) <> True Then
                MessageBox.Show("The user permissions was not deleted succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            'The assigned customers will be deleted by XPO it's aggregated to the user
            If m_Users.DeleteUser(Me.nameTextEdit.Text) <> True Then
                MessageBox.Show("The user was not deleted succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        BindUsersListBox()

        Me.passwordTextEdit.Properties.ReadOnly = True
        Me.confirmTextEdit.Properties.ReadOnly = True
        locationLookUpEdit.Properties.ReadOnly = True
        resetSimpleButton.Enabled = False
        Me.usersListBoxControl.Enabled = True
        Me.userPermissionsGridView.OptionsBehavior.Editable = False
        Me.customersGridView.OptionsBehavior.Editable = False

    End Sub

    Private Sub PermissionsRepositoryItemComboBox_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles permissionsRepositoryItemComboBox.EditValueChanged

        Me.userPermissionsGridView.PostEditor()

    End Sub

    Private Sub editBarButtonItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles editBarButtonItem.ItemClick

        Me.passwordTextEdit.Properties.ReadOnly = False
        Me.confirmTextEdit.Properties.ReadOnly = False
        locationLookUpEdit.Properties.ReadOnly = False
        resetSimpleButton.Enabled = True
        Me.usersListBoxControl.Enabled = False
        Me.userPermissionsGridView.OptionsBehavior.Editable = True
        Me.customersGridView.OptionsBehavior.Editable = True

        Me.cancelBarButtonItem.Enabled = True
        Me.saveBarButtonItem.Enabled = True
        Me.editBarButtonItem.Enabled = False
        Me.addBarButtonItem.Enabled = False
        Me.deleteBarButtonItem.Enabled = False

    End Sub

    Private Sub userPermissionsGridView_ShowingEditor(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles userPermissionsGridView.ShowingEditor

        If userPermissionsGridView.GetFocusedRowCellValue(permissionObjectGridColumn).ToString = "Financial Tabs" OrElse userPermissionsGridView.GetFocusedRowCellValue(permissionObjectGridColumn).ToString = "Advanced Tabs" _
                OrElse userPermissionsGridView.GetFocusedRowCellValue(permissionObjectGridColumn).ToString = "Security Settings" Then
            If My.Settings.UserSecurityLevel <> "Admin" Then
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub customersGridView_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles customersGridView.InitNewRow

        Me.customersGridView.SetFocusedRowCellValue("User!Key", usersListBoxControl.SelectedValue.ToString)

    End Sub

    Private Sub customersXPCollection_ResolveSession(ByVal sender As System.Object, ByVal e As DevExpress.Xpo.ResolveSessionEventArgs) Handles customersXPCollection.ResolveSession

        e.Session = m_CustomersUOW

    End Sub

    Private Sub customerRepositoryItemLookUpEdit_Closed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles customerRepositoryItemLookUpEdit.Closed

        If e.CloseMode <> PopupCloseMode.Cancel Then
            Dim view As GridView = CType(CType(CType(sender, LookUpEdit).Parent, GridControl).FocusedView, GridView)
            If view.IsNewItemRow(view.FocusedRowHandle) Then
                view.CloseEditor()
                view.UpdateCurrentRow()
            End If
        End If

    End Sub

    Private Sub resetSimpleButton_Click(sender As Object, e As EventArgs) Handles resetSimpleButton.Click

        m_UserPermissions.DeleteUserPermissions(Me.nameTextEdit.Text)
        If m_UserPermissions.CreateNewUserPermissions(nameTextEdit.Text) = False Then
            MessageBox.Show("The permissions were not created succesfuly.")
        End If

    End Sub

End Class