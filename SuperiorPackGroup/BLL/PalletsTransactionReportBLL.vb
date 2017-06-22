Imports DevExpress.Xpo
Imports DXDAL.SPGData
Imports DevExpress.Data.Filtering

Public Class PalletsTransactionReportBLL

    Private m_PalletTransactionList As PalletTransactionList

    Public Function GetPalletTransactionReport(ByVal fromDate As Date?, ByVal toDate As Date?, ByVal customer As Integer?) As PalletTransactionList

        m_PalletTransactionList = New PalletTransactionList

        AddReceivingToList(fromDate, toDate, customer)
        AddShippingToList(fromDate, toDate, customer)

        Return m_PalletTransactionList

    End Function

    Private Sub AddReceivingToList(ByVal fromDate As Date?, ByVal toDate As Date?, ByVal customer As Integer?)

        Dim theCriteria As GroupOperator = New GroupOperator() With {.OperatorType = GroupOperatorType.And}
        If fromDate.HasValue Then
            theCriteria.Operands.Add(New BinaryOperator(Receiving.Fields.ReceivDate.PropertyName, fromDate.Value, BinaryOperatorType.GreaterOrEqual))
        End If
        If toDate.HasValue Then
            theCriteria.Operands.Add(New BinaryOperator(Receiving.Fields.ReceivDate.PropertyName, toDate.Value, BinaryOperatorType.LessOrEqual))
        End If
        If customer.HasValue Then
            theCriteria.Operands.Add(New BinaryOperator(Receiving.Fields.ReceivCustID.CustomerID.PropertyName, customer.Value, BinaryOperatorType.Equal))
        End If

        Dim vendorName As String = String.Empty

        Using receivedList As XPCollection(Of Receiving) = New XPCollection(Of Receiving)(Session.DefaultSession, theCriteria)
            For Each record As Receiving In receivedList
                With record
                    If .strVendor IsNot Nothing Then
                        vendorName = .strVendor.VendorName
                    End If
                    m_PalletTransactionList.Add(New PalletTransaction(.ReceivDate, .ReceivCustID.CustomerID, .ReceivCustID.CustomerName, vendorName, Nothing, .ReceivBOL, .sngTotalPallets, Nothing))
                End With
            Next
        End Using

    End Sub

    Private Sub AddShippingToList(ByVal fromDate As Date?, ByVal toDate As Date?, ByVal customer As Integer?)

        Dim theCriteria As GroupOperator = New GroupOperator() With {.OperatorType = GroupOperatorType.And}
        If fromDate.HasValue Then
            theCriteria.Operands.Add(New BinaryOperator(Shipping.Fields.ShipMainDate.PropertyName, fromDate.Value, BinaryOperatorType.GreaterOrEqual))
        End If
        If toDate.HasValue Then
            theCriteria.Operands.Add(New BinaryOperator(Shipping.Fields.ShipMainDate.PropertyName, toDate.Value, BinaryOperatorType.LessOrEqual))
        End If
        If customer.HasValue Then
            theCriteria.Operands.Add(New BinaryOperator(Shipping.Fields.ShipMainCustID.CustomerID.PropertyName, customer.Value, BinaryOperatorType.Equal))
        End If

        Using receivedList As XPCollection(Of Shipping) = New XPCollection(Of Shipping)(Session.DefaultSession, theCriteria)
            For Each record As Shipping In receivedList
                With record
                    m_PalletTransactionList.Add(New PalletTransaction(.ShipMainDate, .ShipMainCustID.CustomerID, .ShipMainCustID.CustomerName, Nothing, .intDestination.ShippingName, .ShipMainBOL.ToString, Nothing, _
                                                                      .sngTotalPallets))
                End With
            Next
        End Using

    End Sub


End Class
