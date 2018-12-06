Imports System.Linq
Imports DevExpress
Imports DevExpress.Xpo
Imports DXDAL.SPGData

Public Class ReasonCodesXtraForm

    Private Sub deleteSimpleButton_Click(sender As Object, e As EventArgs) Handles deleteSimpleButton.Click

        If reassonCodesGridView.SelectedRowsCount > 0 Then
            If MessageBox.Show("Are you sure you want to delete this record/s?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                For i As Integer = 0 To reassonCodesGridView.SelectedRowsCount - 1
                    Dim row As Integer = reassonCodesGridView.GetSelectedRows()(i)
                    If row >= 0 Then
                        Dim currentReason = Session.DefaultSession.GetObjectByKey(Of ReasonCodes)(CType(reassonCodesGridView.GetRowCellValue(row, colOid), Integer))
                        If currentReason.Production.Any
                            MessageBox.Show("This reason can't be deleted, it's used for a production reason code", "Reason In Use", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        Else
                            currentReason.Delete

                        End If
                    End If
                Next i
                reasonCodesXpCollection.Reload
            End If
        End If

    End Sub

    Private Sub ReasonCodesXtraForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        CheckPermissions()

    End Sub

    Public Function CheckPermissions() As Boolean

        Try
            Dim permission As SPG.UserPermissionsRow = New UserPermissionsBLL().GetUserPermissionsByUserName(My.Settings.UserName, "General Lists")(0)

            Select Case permission.PermissionLevel
                Case "FULL", "Full"
                    reassonCodesGridView.OptionsBehavior.Editable = True
                    reassonCodesGridView.OptionsView.NewItemRowPosition = XtraGrid.Views.Grid.NewItemRowPosition.Bottom
                    Me.deleteSimpleButton.Visible = True
                Case "ADD", "Add"
                    reassonCodesGridView.OptionsBehavior.Editable = True
                    reassonCodesGridView.OptionsView.NewItemRowPosition = XtraGrid.Views.Grid.NewItemRowPosition.Bottom
                    Me.deleteSimpleButton.Visible = False
                Case "NONE", "None", "VIEW ASSIGNED", "EDIT ASSIGNED"
                    MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Me.Close()
                    Return False
                Case "VIEW", "View"
                    reassonCodesGridView.OptionsBehavior.Editable = False
                    reassonCodesGridView.OptionsView.NewItemRowPosition = XtraGrid.Views.Grid.NewItemRowPosition.None
                    Me.deleteSimpleButton.Visible = False
                Case "EDIT", "Edit"
                    reassonCodesGridView.OptionsBehavior.Editable = True
                    reassonCodesGridView.OptionsView.NewItemRowPosition = XtraGrid.Views.Grid.NewItemRowPosition.None
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