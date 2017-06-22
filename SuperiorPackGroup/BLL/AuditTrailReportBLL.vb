Imports SuperiorPackGroup.SPGReportsTableAdapters

Public Class AuditTrailReportBLL

    Private m_AuditTrailReportTableAdapter As AuditTrailReportTableAdapter = Nothing

    Public ReadOnly Property Adapter() As AuditTrailReportTableAdapter
        Get
            If (Me.m_AuditTrailReportTableAdapter Is Nothing) Then
                Me.m_AuditTrailReportTableAdapter = New AuditTrailReportTableAdapter
                Me.m_AuditTrailReportTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return Me.m_AuditTrailReportTableAdapter
        End Get
    End Property

    Public Function GetAuditTrailReport(ByVal fromDate As Nullable(Of Date), ByVal toDate As Nullable(Of Date)) As SPGReports.AuditTrailReportDataTable

        Return Adapter.GetAuditTrailReport(fromDate, toDate)

    End Function

End Class
