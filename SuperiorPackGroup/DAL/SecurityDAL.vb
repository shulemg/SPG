Imports SuperiorPackGroup.SPGTableAdapters

Partial Public Class SecurityDAL

    Private m_SecurityTableAdapter As SecurityTableAdapter
    Public ReadOnly Property Adapter() As SecurityTableAdapter

        Get
            If m_SecurityTableAdapter Is Nothing Then
                m_SecurityTableAdapter = New SecurityTableAdapter
                m_SecurityTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return m_SecurityTableAdapter
        End Get

    End Property

    Public Function GetSecuritySettingsByUserName(ByVal userName As String) As Data.DataTableReader

        Return Adapter.GetSecuritySettingsByUserName(userName).CreateDataReader

    End Function

End Class
