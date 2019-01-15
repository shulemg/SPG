Imports System
Imports DevExpress.Xpo

Public Class AllergensXtraForm

    Private m_Allergen As AllergensBLL
    Private m_AllergenSession As Session

    Private Sub BindGridControl()

        'Me.machineLineGridControl.DataSource = m_Allergen.GetAllergens(m_AllergenSession)

    End Sub

    Private Sub AllergensXtraForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        m_AllergenSession = New Session(SPGDataLayer) With {.TrackPropertiesModifications = True, .OptimisticLockingReadBehavior = OptimisticLockingReadBehavior.MergeCollisionThrowException}
        m_Allergen = New AllergensBLL

        CheckPermissions()
        ' Me.nameGridColumn.FieldName = "AllergenName"
        'Me.idGridColumn.FieldName = "AllergenName"
        'AllergenXpView.Reload()

    End Sub

    Private Sub deleteSimpleButton_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles deleteSimpleButton.Click

        If allergenGridView.SelectedRowsCount > 0 Then
            If MessageBox.Show("Are you sure you want to delete this record/s?", "Delete Record", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                For i As Integer = 0 To allergenGridView.SelectedRowsCount - 1
                    Dim row As Integer = allergenGridView.GetSelectedRows()(i)
                    If row >= 0 Then
                        If m_Allergen.DeleteAllergens(m_AllergenSession, CType(allergenGridView.GetRowCellValue(row, idGridColumn), Integer)) <> True Then
                            MessageBox.Show("The Allergen was not deleted successfully.", "Error Encountered", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If
                Next i
            End If
        End If

        AllergenXpCollection.Reload()
        allergenGridView.RefreshData()

    End Sub

    Private Sub saveSimpleButton_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles saveSimpleButton.Click

        Me.allergenGridView.CloseEditor()
        Me.Close()
        'Try
        '    allergenGridView.SelectAll()
        '    If allergenGridView.SelectedRowsCount > 0 Then
        '        For i As Integer = 0 To allergenGridView.SelectedRowsCount - 1
        '            Dim row As Integer = allergenGridView.GetSelectedRows()(i)
        '            If row >= 0 Then
        '                If m_Allergen.UpdateAllergen(m_AllergenSession, CType(allergenGridView.GetRowCellValue(row, idGridColumn), Integer?), allergenGridView.GetRowCellValue(row, nameGridColumn).ToString) <> True Then
        '                    MessageBox.Show("The Allergen was not updated successfully.", "Error Encountered", MessageBoxButtons.OK,
        '                            MessageBoxIcon.Error)
        '                    Exit Sub
        '                End If
        '            End If
        '        Next
        '    End If
        'Catch ex As ApplicationException
        '    MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'End Try

        'AllergenXpView.Reload()

    End Sub

    Public Function CheckPermissions() As Boolean

        Try
            Dim permission As SPG.UserPermissionsRow = New UserPermissionsBLL().GetUserPermissionsByUserName(My.Settings.UserName, "General Lists")(0)

            Select Case permission.PermissionLevel
                Case "FULL", "Full"
                    Me.allergenGridView.OptionsBehavior.Editable = True
                    Me.allergenGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
                    Me.deleteSimpleButton.Visible = True
                Case "ADD", "Add"
                    Me.allergenGridView.OptionsBehavior.Editable = True
                    Me.allergenGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
                    Me.deleteSimpleButton.Visible = False
                Case "NONE", "None", "VIEW ASSIGNED", "EDIT ASSIGNED"
                    MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Me.Close()
                    Return False
                Case "VIEW", "View"
                    Me.allergenGridView.OptionsBehavior.Editable = False
                    Me.allergenGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
                    Me.deleteSimpleButton.Visible = False
                Case "EDIT", "Edit"
                    Me.allergenGridView.OptionsBehavior.Editable = True
                    Me.allergenGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
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