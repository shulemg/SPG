Public Class ItemTransactionXtraReport

    Private Sub balacneDetailXrLabel_SummaryCalculated(ByVal sender As System.Object, ByVal e As DevExpress.XtraReports.UI.TextFormatEventArgs) Handles balacneDetailXrLabel.SummaryCalculated

        e.Text = Format(CDbl(e.Value) + CDbl(Me.openingBalanceParameter.Value), "#,##0.00")

    End Sub

    Private Sub ItemTransactionXtraReport_BeforePrint(ByVal sender As Object, ByVal e As Printing.PrintEventArgs) Handles Me.BeforePrint

        If Me.DataSource IsNot Nothing Then
            Me.openingBalanceParameter.Value = CType(Me.DataSource, ItemTransactionsList).OpeningBalance
        End If

    End Sub

End Class