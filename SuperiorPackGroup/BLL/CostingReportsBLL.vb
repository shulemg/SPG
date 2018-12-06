Imports SuperiorPackGroup.SPGReportsTableAdapters

Public Class CostingReportsBLL

    Private m_CostingReportsTableAdapter As CostingReportsTableAdapter = Nothing

    Public ReadOnly Property Adapter() As CostingReportsTableAdapter
        Get
            If (Me.m_CostingReportsTableAdapter Is Nothing) Then
                Me.m_CostingReportsTableAdapter = New CostingReportsTableAdapter
                Me.m_CostingReportsTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return Me.m_CostingReportsTableAdapter
        End Get
    End Property

    Public Function GetCostingReport(ByVal fromDate As Date?, ByVal toDate As Date?, ByVal customer As Integer?, ByVal shift As Integer?, _
                                     ByVal machine As Integer?, ByVal items As String, ByVal inactiveItems As Boolean?, ByVal inactiveCustomers As Boolean?) As SPGReports.CostingReportsDataTable

        If inactiveCustomers.Value = True Then
            inactiveCustomers = Nothing
        End If

        If inactiveItems.Value = True Then
            inactiveItems = Nothing
        End If

        If String.IsNullOrEmpty(items) Then
            Return Adapter.GetCostingReports(fromDate, toDate, shift, machine, customer, inactiveCustomers, inactiveItems)
        End If

        Return Adapter.GetCostingReportsByItems(fromDate, toDate, shift, machine, customer, inactiveCustomers, items)

    End Function

End Class
