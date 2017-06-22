Imports DXDAL.SPGData
Imports DevExpress.Xpo

Public Class EmployeesBLL

    Public Shared Function DeleteEmployee(ByVal employeeID As Integer) As Boolean

        Dim employee As Employees = Session.DefaultSession.GetObjectByKey(Of Employees)(employeeID)

        If employee.CheckedReceiving.Count > 0 OrElse employee.CheckedShipping.Count > 0 OrElse employee.Loaded.Count > 0 OrElse employee.Unloaded.Count > 0 OrElse employee.CheckedTransfer.Count > 0 OrElse employee.LoadedTransfer.Count > 0 OrElse
                employee.UnloadedTransfer.Count > 0 Then
            MessageBox.Show("You can't delete this employee there are other records associated to it")
        Else
            employee.Delete()
        End If

        Return employee.IsDeleted

    End Function

End Class
