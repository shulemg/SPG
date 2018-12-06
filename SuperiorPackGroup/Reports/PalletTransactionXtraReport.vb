Public Class PalletTransactionXtraReport

    Private Sub xRLOverShippedTotal_BeforePrint(ByVal sender As System.Object, ByVal e As Printing.PrintEventArgs) Handles xRLOverShippedTotal.BeforePrint

        xRLOverShippedTotal.Text = (CDbl(shippedTotalXrLabel.Summary.GetResult) - CDbl(receivedTotalXRLabel.Summary.GetResult)).ToString

    End Sub

End Class