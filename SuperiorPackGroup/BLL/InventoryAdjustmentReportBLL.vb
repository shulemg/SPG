Imports SuperiorPackGroup.SPGReportsTableAdapters

Public Class InventoryAdjustmentReportBLL

    Private m_InventoryAdjustmentReportTableAdapter As InventoryAdjustmentReportTableAdapter = Nothing

    Public ReadOnly Property Adapter() As InventoryAdjustmentReportTableAdapter
        Get
            If (Me.m_InventoryAdjustmentReportTableAdapter Is Nothing) Then
                Me.m_InventoryAdjustmentReportTableAdapter = New InventoryAdjustmentReportTableAdapter
                Me.m_InventoryAdjustmentReportTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return Me.m_InventoryAdjustmentReportTableAdapter
        End Get
    End Property

    Public Function GetInventoryAdjustmentReport(ByVal fromDate As Date?, ByVal toDate As Date?, ByVal customerID As Integer?, _
                                                 ByVal items As String, ByVal inactiveItems As Boolean?, ByVal inactiveCustomers As Boolean?) As SPGReports.InventoryAdjustmentReportDataTable

        If inactiveCustomers.Value = True Then
            inactiveCustomers = Nothing
        End If

        If inactiveItems.Value = True Then
            inactiveItems = Nothing
        End If

        If String.IsNullOrEmpty(items) Then
            Return Adapter.GetInventoryAdjustmentReport(fromDate, toDate, customerID, inactiveCustomers, inactiveItems)
        Else
            Return Adapter.GetInventoryAdjustmentReportByItemID(fromDate, toDate, customerID, inactiveCustomers, items)
        End If

    End Function

End Class
