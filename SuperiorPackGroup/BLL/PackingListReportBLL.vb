Imports SuperiorPackGroup.SPGReportsTableAdapters

Public Class PackingListReportBLL

    Private m_PackingListReportTableAdapter As PackingListReportTableAdapter = Nothing

    Public ReadOnly Property Adapter() As PackingListReportTableAdapter
        Get
            If (m_PackingListReportTableAdapter Is Nothing) Then
                m_PackingListReportTableAdapter = New PackingListReportTableAdapter
                m_PackingListReportTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return m_PackingListReportTableAdapter
        End Get
    End Property

    Public Function GetPackingListreport(ByVal ShippingID As Integer) As SPGReports.PackingLIstReportDataTable

        Try
            Return Adapter.GetPackingList(ShippingID)
        Catch ex As Exception
            MessageBox.Show(String.Format("There was an error while retrieving the information to print{0}{1}", vbCrLf, ex.Message))
            Return Nothing
        End Try

    End Function

End Class
