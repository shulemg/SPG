Public Class shipmentConditionXtraForm 

    Private Sub shipmentConditionXtraForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        checkpermissions()

    End Sub

    Private Sub deleteSimpleButton_Click(sender As Object, e As EventArgs) Handles deleteSimpleButton.Click

        If conditionsGridView.SelectedRowsCount > 0 Then
            If MessageBox.Show("Are you sure you want to delete this record/s?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                For i As Integer = 0 To conditionsGridView.SelectedRowsCount - 1
                    Dim row As Integer = conditionsGridView.GetSelectedRows()(i)
                    If row >= 0 Then
                        If ShipmentConditionsBLL.DeleteCondition(CType(conditionsGridView.GetRowCellValue(row, colOid), Integer)) <> True Then
                            MessageBox.Show("The Condition/s was not deleted succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If
                Next i
            End If
        End If

        shipmentConditionsXpCollection.Reload()
        conditionsGridView.RefreshData()

    End Sub

    Public Function CheckPermissions() As Boolean

        Try
            Dim permission As SPG.UserPermissionsRow = New UserPermissionsBLL().GetUserPermissionsByUserName(My.Settings.UserName, "General Lists")(0)

            Select Case permission.PermissionLevel
                Case "FULL", "Full"
                    conditionsGridView.OptionsBehavior.Editable = True
                    conditionsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
                    Me.deleteSimpleButton.Visible = True
                Case "ADD", "Add"
                    conditionsGridView.OptionsBehavior.Editable = True
                    conditionsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
                    Me.deleteSimpleButton.Visible = False
                Case "NONE", "None", "VIEW ASSIGNED", "EDIT ASSIGNED"
                    MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Me.Close()
                    Return False
                Case "VIEW", "View"
                    conditionsGridView.OptionsBehavior.Editable = False
                    conditionsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
                    Me.deleteSimpleButton.Visible = False
                Case "EDIT", "Edit"
                    conditionsGridView.OptionsBehavior.Editable = True
                    conditionsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
                    Me.deleteSimpleButton.Visible = False
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