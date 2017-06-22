Public Class TransportationXtraReport

    Private Sub expirationDateDetailXrLabel_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles expirationDateDetailXrLabel.BeforePrint

        If expirationDateDetailXrLabel.Tag Is Nothing Then
            expirationDateDetailXrLabel.Text = Format(GetCurrentColumnValue("ExpirationDate"), "MM/dd/yyyy")
        Else
            expirationDateDetailXrLabel.Text = Format(GetCurrentColumnValue("ExpirationDate"), expirationDateDetailXrLabel.Tag.ToString)
        End If

    End Sub

End Class