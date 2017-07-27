Imports System.Text
Imports DXDAL

Public Class PackingListXtraReport

    Private Sub fromXrLabel_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles fromXrLabel.BeforePrint

        If reportTitleXrLabel.Text = "Receiving List" Then
            fromXrLabel.Text = String.Format("{0}{1}{2}{1}{3}", GetCurrentColumnValue("CustomerName").ToString, vbCrLf, GetCurrentColumnValue("Address").ToString,
                                               GetCurrentColumnValue("Address2").ToString)
        Else
            Dim str As StringBuilder = New StringBuilder(String.Empty)

            If Convert.ToBoolean(GetCurrentColumnValue("Shipper")) Then
                Str.Append(String.Format("{0}{1}C/O Superior Pack Group", GetCurrentColumnValue("CustomerName").ToString, vbCrLf))
            Else
                Str.Append("Superior Pack Group")
            End If

            If locationId.Text = "001" Then
                str.Append(String.Format($"{vbNewLine}2 Bailey Farm Road{vbNewLine}Harriman, N.Y. 10926"))
            ElseIf locationId.Text = "002" Then
                str.Append(String.Format($"{vbNewLine}19 Industry Drive suite #104{vbNewLine}Mountainville, NY 10953"))
            End If

            fromXrLabel.Text = str.ToString
        End If
    End Sub

    Private Sub toXrLabel_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles toXrLabel.BeforePrint

        Try
            If reportTitleXrLabel.Text = "Receiving List" Then
                toXrLabel.Text = String.Format("Superior Pack Group{0}2 Bailey Farm Road{0}Harriman, N.Y. 10926", vbCrLf)
            Else
                toXrLabel.Text = String.Format("{0}{1}{2}{1}{3}", GetCurrentColumnValue("ShippingName").ToString, vbCrLf, GetCurrentColumnValue("ShippingAddress").ToString, _
                                               GetCurrentColumnValue("ShippingAddress2").ToString)
            End If
        Catch
            toXrLabel.Text = ""
        End Try

    End Sub

    Private Sub returnsGroupHeader_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles returnsGroupHeader.BeforePrint

        Try
            If GetCurrentColumnValue("ShippingType").ToString = "General" Then
                e.Cancel = True
            Else
                e.Cancel = False
            End If
        Catch
            e.Cancel = True
        End Try

    End Sub

    Private Sub totalPalletWeightXrLabel_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles totalPalletWeightXrLabel.BeforePrint

        totalPalletWeightXrLabel.Text = (CDbl(GetCurrentColumnValue("sngTotalPallets")) * 40).ToString

    End Sub

    Private Sub itemDescriptionXrLabel_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles itemDescriptionXrLabel.BeforePrint

        Try
            itemDescriptionXrLabel.Text = CStr(GetCurrentColumnValue("ItemDescription")) & vbCrLf & CStr(GetCurrentColumnValue("Note"))
        Catch

        End Try

    End Sub

    Private Sub totalWeightXrLabel_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles totalWeightXrLabel.BeforePrint

        If reportTitleXrLabel.Text = "Receiving List" Then
            totalWeightXrLabel.Text = (CDbl(itemTotalWeightXrLabel.Summary.GetResult) + CDbl(GetCurrentColumnValue("sngTotalPallets")) * 40).ToString("n1")
        End If

    End Sub

    Private Sub wheelsChockedXrLabel_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles wheelsChockedXrLabel.BeforePrint

        If Not IsDBNull(GetCurrentColumnValue("WheelsChocked")) Then
            wheelsChockedXrLabel.Text = [Enum].GetName(GetType(ThreeWayYesNo), GetCurrentColumnValue("WheelsChocked"))
        End If
    End Sub

    Private Sub foreignSubstanceXrLabel_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles foreignSubstanceXrLabel.BeforePrint

        If Not IsDBNull(GetCurrentColumnValue("ForeignSubstance")) Then
            foreignSubstanceXrLabel.Text = [Enum].GetName(GetType(ThreeWayYesNo), GetCurrentColumnValue("ForeignSubstance"))
        End If

    End Sub

    Private Sub insectActivityXrLabel_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles insectActivityXrLabel.BeforePrint

        If Not IsDBNull(GetCurrentColumnValue("InsectActivity")) Then
            insectActivityXrLabel.Text = [Enum].GetName(GetType(ThreeWayYesNo), GetCurrentColumnValue("InsectActivity"))
        End If

    End Sub

    Private Sub correctPalletsXrLabel_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles correctPalletsXrLabel.BeforePrint

        If Not IsDBNull(GetCurrentColumnValue("CorrectPallets")) Then
            correctPalletsXrLabel.Text = [Enum].GetName(GetType(ThreeWayYesNo), GetCurrentColumnValue("CorrectPallets"))
        End If

    End Sub

End Class