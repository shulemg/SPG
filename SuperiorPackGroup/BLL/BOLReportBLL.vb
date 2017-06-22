Imports SuperiorPackGroup.SPGReportsTableAdapters

Public Class BOLReportBLL

    Private m_BOLReportTableAdapter As BOLReportTableAdapter = Nothing

    Public ReadOnly Property Adapter() As BOLReportTableAdapter
        Get
            If (Me.m_BOLReportTableAdapter Is Nothing) Then
                Me.m_BOLReportTableAdapter = New BOLReportTableAdapter
                Me.m_BOLReportTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return Me.m_BOLReportTableAdapter
        End Get
    End Property

    Public Function Getbolreport(ByVal ShippingID As Integer) As SPGReports.BOLReportDataTable

        Try
            Return Adapter.GetBOL(ShippingID)
        Catch ex As Exception
            MessageBox.Show(String.Format("There was an error while retrieving the information to print{0}{1}", vbCrLf, ex.Message))
            Return Nothing
        End Try

    End Function

End Class
