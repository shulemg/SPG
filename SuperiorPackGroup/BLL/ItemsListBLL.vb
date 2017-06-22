Imports SuperiorPackGroup.SPGReportsTableAdapters

Public Class ItemsListBLL

    Private m_ItemsListTableAdapter As ItemsListTableAdapter = Nothing

    Public ReadOnly Property Adapter() As ItemsListTableAdapter
        Get
            If (Me.m_ItemsListTableAdapter Is Nothing) Then
                Me.m_ItemsListTableAdapter = New ItemsListTableAdapter
                Me.m_ItemsListTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return Me.m_ItemsListTableAdapter
        End Get
    End Property

    Public Function GetItemsList(ByVal customerID As Nullable(Of Integer), ByVal itemType As String, ByVal items As String, ByVal inactiveItems As Boolean?, _
                                 ByVal inactiveCustomers As Boolean?) As SPGReports.ItemsListDataTable

        If inactiveCustomers.Value = True Then
            inactiveCustomers = Nothing
        End If

        If inactiveItems.Value = True Then
            inactiveItems = Nothing
        End If

        If String.IsNullOrEmpty(items) Then
            Return Adapter.GetItemsList(customerID, itemType, inactiveCustomers, inactiveItems)
        Else
            Return Adapter.GetItemsListByItemID(customerID, itemType, inactiveCustomers, items)
        End If

    End Function

End Class
