Public Class ShiftsXtraForm 

    Private m_Shift As ShiftsBLL

    Private Sub BindGridControl()

        Me.shiftsGridControl.DataSource = m_Shift.GetShifts

    End Sub

    Private Sub deleteSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteSimpleButton.Click

        If shiftsGridView.SelectedRowsCount > 0 Then
            If MessageBox.Show("Are you sure you want to delete this record/s?", "Delete Record", MessageBoxButtons.YesNo, _
                    MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                For i As Integer = 0 To shiftsGridView.SelectedRowsCount - 1
                    Dim row As Integer = shiftsGridView.GetSelectedRows()(i)
                    If row >= 0 Then
                        If m_Shift.DeleteShift(CType(shiftsGridView.GetRowCellValue(row, idGridColumn), Integer)) <> True Then
                            MessageBox.Show("The Shift/s was not deleted succesfully.", "Error Encountered", MessageBoxButtons.OK, _
                                    MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If
                Next i
            End If
        End If

        BindGridControl()

    End Sub

    Private Sub saveSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveSimpleButton.Click

        Try
            shiftsGridView.SelectAll()
            If shiftsGridView.SelectedRowsCount > 0 Then
                For i As Integer = 0 To shiftsGridView.SelectedRowsCount - 1
                    Dim row As Integer = shiftsGridView.GetSelectedRows()(i)
                    If row >= 0 Then
                        If m_Shift.UpdateShift(CType(shiftsGridView.GetRowCellValue(row, idGridColumn), Integer?), _
                                shiftsGridView.GetRowCellValue(row, shiftGridColumn).ToString) <> True Then
                            MessageBox.Show("The Shift was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, _
                                    MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If
                Next
            End If
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        BindGridControl()

    End Sub

    Private Sub ShiftsXtraForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        m_Shift = New ShiftsBLL

        CheckPermissions()
        Me.shiftGridColumn.FieldName = "ShiftName"
        Me.idGridColumn.FieldName = "ShiftID"
        BindGridControl()

    End Sub

    Public Function CheckPermissions() As Boolean

        Try
            Dim permission As SPG.UserPermissionsRow = New UserPermissionsBLL().GetUserPermissionsByUserName(My.Settings.UserName, "General Lists")(0)

            Select Case permission.PermissionLevel
                Case "FULL", "Full"
                    Me.shiftsGridView.OptionsBehavior.Editable = True
                    Me.shiftsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
                    Me.deleteSimpleButton.Visible = True
                Case "ADD", "Add"
                    Me.shiftsGridView.OptionsBehavior.Editable = True
                    Me.shiftsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
                    Me.deleteSimpleButton.Visible = False
                Case "NONE", "None", "VIEW ASSIGNED", "EDIT ASSIGNED"
                    MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Me.Close()
                    Return False
                Case "VIEW", "View"
                    Me.shiftsGridView.OptionsBehavior.Editable = False
                    Me.shiftsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
                    Me.deleteSimpleButton.Visible = False
                Case "EDIT", "Edit"
                    Me.shiftsGridView.OptionsBehavior.Editable = True
                    Me.shiftsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
                    Me.deleteSimpleButton.Visible = False
            End Select

            Return True
        Catch ex As InvalidOperationException
            Return False
        End Try

    End Function

End Class