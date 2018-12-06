Imports DXDAL.SPGData

Public Class VendorsXtraForm

    Private Sub deleteRepositoryItemButtonEdit_ButtonClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles deleteRepositoryItemButtonEdit.ButtonClick

        If MessageBox.Show("Are you sure you want to delete this Vendor?", "Delete Vendor", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.Yes Then
            If VendorBLL.VendorInUse(CInt(vendorsGridView.GetFocusedRowCellValue(colOid))) = False Then
                vendorsGridView.DeleteRow(vendorsGridView.FocusedRowHandle)
            Else
                MessageBox.Show(String.Format("This vendor is referenced in some records.{0}You can't delete it at this time.", vbCrLf), "Vendor In Use", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End If
        End If

    End Sub

    Private Sub vendorsGridView_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles vendorsGridView.ValidateRow

        If vendorsGridView.GetFocusedRowCellValue(colVendorName) Is Nothing OrElse String.IsNullOrEmpty(vendorsGridView.GetFocusedRowCellValue(colVendorName).ToString) Then
            e.ErrorText = "You must provide a Vendor name."
            e.Valid = False
        Else
            e.ErrorText = Nothing
            e.Valid = True
        End If

    End Sub

    Private Sub VendorsXtraForm_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

        DevExpress.Xpo.XPBaseObject.AutoSaveOnEndEdit = True
        CheckPermissions()

    End Sub

    Public Function CheckPermissions() As Boolean

        Try
            Dim permission As SPG.UserPermissionsRow = New UserPermissionsBLL().GetUserPermissionsByUserName(My.Settings.UserName, "General Lists")(0)

            Select Case permission.PermissionLevel
                Case "FULL", "Full"
                    Me.vendorsGridView.OptionsBehavior.Editable = True
                    Me.vendorsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
                    Me.deleteGridColumn.Visible = True
                Case "ADD", "Add"
                    Me.vendorsGridView.OptionsBehavior.Editable = True
                    Me.vendorsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
                    Me.deleteGridColumn.Visible = False
                Case "NONE", "None", "VIEW ASSIGNED", "EDIT ASSIGNED"
                    MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Me.Close()
                    Return False
                Case "VIEW", "View"
                    Me.vendorsGridView.OptionsBehavior.Editable = False
                    Me.vendorsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
                    Me.deleteGridColumn.Visible = False
                Case "EDIT", "Edit"
                    Me.vendorsGridView.OptionsBehavior.Editable = True
                    Me.vendorsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
                    Me.deleteGridColumn.Visible = False
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

End Class