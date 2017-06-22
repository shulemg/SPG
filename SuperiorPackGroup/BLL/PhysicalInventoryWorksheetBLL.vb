Imports SuperiorPackGroup.SPGReportsTableAdapters

Public Class PhysicalInventoryWorksheetBLL

    Private m_PhysicalInventoryWorksheetTableAdapter As PhysicalInventoryWorksheetTableAdapter = Nothing

    Public ReadOnly Property Adapter() As PhysicalInventoryWorksheetTableAdapter
        Get
            If (Me.m_PhysicalInventoryWorksheetTableAdapter Is Nothing) Then
                Me.m_PhysicalInventoryWorksheetTableAdapter = New PhysicalInventoryWorksheetTableAdapter
                Me.m_PhysicalInventoryWorksheetTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return Me.m_PhysicalInventoryWorksheetTableAdapter
        End Get
    End Property

    Public Function GetPhysicalInventoryWorksheet(ByVal customerID As Nullable(Of Integer), ByVal itemType As String, ByVal items As String, ByVal inactiveItems As Boolean?, _
                                                  ByVal inactiveCustomers As Boolean?) As SPGReports.PhysicalInventoryWorksheetDataTable

        If inactiveCustomers.Value = True Then
            inactiveCustomers = Nothing
        End If

        If inactiveItems.Value = True Then
            inactiveItems = Nothing
        End If

        If String.IsNullOrEmpty(items) Then
            Return Adapter.GetPhysicalInventoryWorksheet(customerID, itemType, inactiveCustomers, inactiveItems)
        Else
            Return Adapter.GetPhysicalInventoryWorksheetByItemID(customerID, itemType, inactiveCustomers, items)
        End If

    End Function

End Class
