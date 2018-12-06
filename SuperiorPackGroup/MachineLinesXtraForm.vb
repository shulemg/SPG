Imports System

Public Class MachineLinesXtraForm

    Private m_MachineLines As MachinesLinesBLL

    Private Sub BindGridControl()

        Me.machineLineGridControl.DataSource = m_MachineLines.GetMachineLines

    End Sub

    Private Sub MachineLinesXtraForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        m_MachineLines = New MachinesLinesBLL

        checkpermissions()
        Me.nameGridColumn.FieldName = "MachineLineName"
        Me.idGridColumn.FieldName = "MachineLineID"
        BindGridControl()

    End Sub

    Private Sub deleteSimpleButton_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles deleteSimpleButton.Click

        If machineLineGridView.SelectedRowsCount > 0 Then
            If MessageBox.Show("Are you sure you want to delete this record/s?", "Delete Record", MessageBoxButtons.YesNo, _
                    MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                For i As Integer = 0 To machineLineGridView.SelectedRowsCount - 1
                    Dim row As Integer = machineLineGridView.GetSelectedRows()(i)
                    If row >= 0 Then
                        If m_MachineLines.DeleteMachineLine(CType(machineLineGridView.GetRowCellValue(row, idGridColumn), Integer)) <> True Then
                            MessageBox.Show("The Machine Line/s was not deleted successfully.", "Error Encountered", MessageBoxButtons.OK, _
                                    MessageBoxIcon.Error)
                            Exit Sub
                        End If
                    End If
                Next i
            End If
        End If

        BindGridControl()

    End Sub

    Private Sub saveSimpleButton_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles saveSimpleButton.Click

        Try
            machineLineGridView.SelectAll()
            If machineLineGridView.SelectedRowsCount > 0 Then
                For i As Integer = 0 To machineLineGridView.SelectedRowsCount - 1
                    Dim row As Integer = machineLineGridView.GetSelectedRows()(i)
                    If row >= 0 Then
                        If m_MachineLines.UpdateMachineLine(CType(machineLineGridView.GetRowCellValue(row, idGridColumn), Integer?), machineLineGridView.GetRowCellValue(row, nameGridColumn).ToString) <> True Then
                            MessageBox.Show("The Machine Lines was not updated successfully.", "Error Encountered", MessageBoxButtons.OK, _
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

    Public Function CheckPermissions() As Boolean

        Try
            Dim permission As SPG.UserPermissionsRow = New UserPermissionsBLL().GetUserPermissionsByUserName(My.Settings.UserName, "General Lists")(0)

            Select Case permission.PermissionLevel
                Case "FULL", "Full"
                    Me.machineLineGridView.OptionsBehavior.Editable = True
                    Me.machineLineGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
                    Me.deleteSimpleButton.Visible = True
                Case "ADD", "Add"
                    Me.machineLineGridView.OptionsBehavior.Editable = True
                    Me.machineLineGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
                    Me.deleteSimpleButton.Visible = False
                Case "NONE", "None", "VIEW ASSIGNED", "EDIT ASSIGNED"
                    MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Me.Close()
                    Return False
                Case "VIEW", "View"
                    Me.machineLineGridView.OptionsBehavior.Editable = False
                    Me.machineLineGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
                    Me.deleteSimpleButton.Visible = False
                Case "EDIT", "Edit"
                    Me.machineLineGridView.OptionsBehavior.Editable = True
                    Me.machineLineGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
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