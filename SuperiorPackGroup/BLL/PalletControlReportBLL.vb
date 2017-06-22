Imports SuperiorPackGroup.SPGReportsTableAdapters

Public Class PalletControlReportBLL

    Private m_PalletControlReportTableAdapter As PalletControlReportTableAdapter = Nothing

    Public ReadOnly Property Adapter() As PalletControlReportTableAdapter
        Get
            If (Me.m_PalletControlReportTableAdapter Is Nothing) Then
                Me.m_PalletControlReportTableAdapter = New PalletControlReportTableAdapter
                Me.m_PalletControlReportTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return Me.m_PalletControlReportTableAdapter
        End Get
    End Property

    Public Function GetPalletControlReport() As SPGReports.PalletControlReportDataTable

        Return Adapter.GetPalletControlReport()
        
    End Function

End Class
