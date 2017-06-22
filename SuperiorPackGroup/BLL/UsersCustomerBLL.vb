Imports DXDAL.SPGData
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Public Class UsersCustomerBLL

    Public Shared Function GetAssignedCustomers(ByVal session As Session) As Collections.Generic.List(Of Customers)

        Dim assignedCustomers As New List(Of Customers)

        For Each assignedCustomer As UsersCustomer In New XPCollection(Of UsersCustomer)(session, CriteriaOperator.Parse(String.Format("User.strUserName = '{0}'", My.Settings.UserName)))
            assignedCustomers.Add(assignedCustomer.Customer)
        Next

        Return assignedCustomers

    End Function

    Public Shared Function GetAssignedCustomerIDs(ByVal session As Session) As Collections.Generic.List(Of Integer)

        Dim assignedCustomers As New List(Of Integer)

        For Each assignedCustomer As UsersCustomer In New XPCollection(Of UsersCustomer)(session, CriteriaOperator.Parse(String.Format("User.strUserName = '{0}'", My.Settings.UserName)))
            assignedCustomers.Add(assignedCustomer.Customer.CustomerID)
        Next

        Return assignedCustomers

    End Function

End Class
