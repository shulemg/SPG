Imports System.Text
Public Class BillOfLadingXtraReport

    Private Sub fromXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Printing.PrintEventArgs) Handles fromXrLabel.BeforePrint

        Dim str As StringBuilder = New StringBuilder(String.Empty)
        If Convert.ToBoolean(Me.GetCurrentColumnValue("Shipper")) Then
            str.Append(String.Format("{0}{1}C/O Superior Pack Group", Me.GetCurrentColumnValue("CustomerName").ToString, vbCrLf))
        Else
            str.Append("Superior Pack Group")
        End If

        If locationId.Text = "001" Then
            str.Append(String.Format($"{vbNewLine}2 Bailey Farm Road{vbNewLine}Harriman, N.Y. 10926"))
        ElseIf locationId.Text = "002" Then
            str.Append(String.Format($"{vbNewLine}19 Industry Drive suite #104{vbNewLine}Mountainville, NY 10953"))
        End If

        fromXrLabel.Text = str.ToString

    End Sub

    Private Sub toXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Printing.PrintEventArgs) Handles toXrLabel.BeforePrint

        Try
            toXrLabel.Text = String.Format("{0}{1}{2}{1}{3}", Me.GetCurrentColumnValue("ShippingName").ToString, vbCrLf, Me.GetCurrentColumnValue("ShippingAddress").ToString, _
                                           Me.GetCurrentColumnValue("ShippingAddress2").ToString)
        Catch ex As Exception
            toXrLabel.Text = ""
        End Try

    End Sub

    Private Sub returnsGroupHeader_BeforePrint(ByVal sender As System.Object, ByVal e As Printing.PrintEventArgs) Handles returnsGroupHeader.BeforePrint

        Try
            If Me.GetCurrentColumnValue("ShippingType").ToString = "General" Then
                e.Cancel = True
            Else
                e.Cancel = False
            End If
        Catch ex As Exception
            e.Cancel = True
        End Try

    End Sub

    Private Sub totalPalletWeightXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Printing.PrintEventArgs) Handles totalPalletWeightXrLabel.BeforePrint

        totalPalletWeightXrLabel.Text = (CDbl(GetCurrentColumnValue("sngTotalPallets")) * 65).ToString

    End Sub

    Private Sub itemDescriptionXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Printing.PrintEventArgs) Handles itemDescriptionXrLabel.BeforePrint

        Try
            itemDescriptionXrLabel.Text = CStr(GetCurrentColumnValue("ItemDescription")) & vbCrLf & CStr(GetCurrentColumnValue("Note"))
        Catch
        End Try

    End Sub

End Class