Imports SuperiorPackGroup.SPGReportsTableAdapters

Public Class PalletTicketBLL

    Private m_PalletTicketTableAdapter As PalletTicketTableAdapter = Nothing

    Public ReadOnly Property Adapter() As PalletTicketTableAdapter
        Get
            If (Me.m_PalletTicketTableAdapter Is Nothing) Then
                Me.m_PalletTicketTableAdapter = New PalletTicketTableAdapter
                Me.m_PalletTicketTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return Me.m_PalletTicketTableAdapter
        End Get
    End Property

    Public Function GetPalletTicket(ByVal ItemID As Integer) As SPGReports.PalletTicketDataTable

        Return Adapter.GetPalletTicket(ItemID)

    End Function

End Class
