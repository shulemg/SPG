Imports SuperiorPackGroup.SPGReportsTableAdapters

Public Class ReceivingListReportBLL

    Private m_ReceivingListReportTableAdapter As ReceivingListReportTableAdapter = Nothing

    Public ReadOnly Property Adapter() As ReceivingListReportTableAdapter
        Get
            If (m_ReceivingListReportTableAdapter Is Nothing) Then
                m_ReceivingListReportTableAdapter = New ReceivingListReportTableAdapter
                m_ReceivingListReportTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return m_ReceivingListReportTableAdapter
        End Get
    End Property

    Public Function GetReceivingListreport(ByVal ReceivingID As Integer) As SPGReports.ReceivingListReportDataTable

        Try
            Return Adapter.GetReceivingList(ReceivingID)
        Catch ex As Exception
            MessageBox.Show(String.Format("There was an error while retrieving the information to print{0}{1}", vbCrLf, ex.Message))
            Return Nothing
        End Try

    End Function

End Class
