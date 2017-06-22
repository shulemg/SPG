Imports SuperiorPackGroup.SPGTableAdapters

Public Class ReportsBLL

    Private m_ReportsTableAdapter As ReportsTableAdapter = Nothing

    Public ReadOnly Property Adapter() As ReportsTableAdapter
        Get
            If (Me.m_ReportsTableAdapter Is Nothing) Then
                Me.m_ReportsTableAdapter = New ReportsTableAdapter
                Me.m_ReportsTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return Me.m_ReportsTableAdapter
        End Get
    End Property

    Public Function GetReports() As SPG.ReportsDataTable

        Return Adapter.GetReports()

    End Function

    Public Function GetReportsByModule(ByVal ModuleName As String) As SPG.ReportsDataTable

        Return Adapter.GetReportsByModule(ModuleName)

    End Function

End Class
