Imports SuperiorPackGroup.SPGReportsTableAdapters

Public Class FinishedProductAvailabilityReportBLL

    Private m_FinishedProductAvailabilityReportTableAdapter As FinishedProductAvailabilityReportTableAdapter = Nothing

    Public ReadOnly Property Adapter() As FinishedProductAvailabilityReportTableAdapter
        Get
            If (Me.m_FinishedProductAvailabilityReportTableAdapter Is Nothing) Then
                Me.m_FinishedProductAvailabilityReportTableAdapter = New FinishedProductAvailabilityReportTableAdapter
                Me.m_FinishedProductAvailabilityReportTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return Me.m_FinishedProductAvailabilityReportTableAdapter
        End Get
    End Property

    Public Function GetFinishedProductAvailabilityReport(ByVal customerID As Nullable(Of Integer), ByVal inactiveItems As Boolean?, ByVal inactiveCustomers As Boolean?, _
                                                         ByVal items As String) As SPGReports.FinishedProductAvailabilityReportDataTable

        If inactiveCustomers.Value = True Then
            inactiveCustomers = Nothing
        End If

        If inactiveItems.Value = True Then
            inactiveItems = Nothing
        End If

        If String.IsNullOrEmpty(items) Then
            Return Adapter.GetFinishedProductAvailabilityReport(customerID, inactiveCustomers, inactiveItems)
        Else
            Return Adapter.GetFinishedProductAvailabilityByItem(customerID, inactiveCustomers, items)
        End If

    End Function

End Class
