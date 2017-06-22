Imports DevExpress.Xpo
Imports DXDAL.SPGData
Imports DevExpress.Data.Filtering

Public Class ShippingReturnsReportBLL

    Public Shared Function GetShippingReturnsReport(ByVal fromDate As Nullable(Of Date), ByVal toDate As Nullable(Of Date), ByVal shiftID As Nullable(Of Integer), ByVal customerID As Nullable(Of Integer), ByVal lot As String, _
                                             ByVal BOL As String, ByVal destinationID As Nullable(Of Integer), ByVal carrierID As Nullable(Of Integer), ByVal items As String, ByVal inactiveItems As Boolean?, _
                                             ByVal inactiveCustomers As Boolean?, ByVal onlyAssignedCustomers As Boolean) As XPView

        Dim ShippingReturnsReportXPView As New XPView(Session.DefaultSession, GetType(ShippedReturns))
        Dim theCriteria As New CriteriaOperatorCollection

        If fromDate.HasValue Then
            theCriteria.Add(New BinaryOperator("ShipMainID.ShipMainDate", fromDate.Value, BinaryOperatorType.GreaterOrEqual))
        End If
        If toDate.HasValue Then
            theCriteria.Add(New BinaryOperator("ShipMainID.ShipMainDate", toDate.Value, BinaryOperatorType.LessOrEqual))
        End If
        If String.IsNullOrEmpty(BOL) = False Then
            theCriteria.Add(New BinaryOperator("ShipMainID.ShipMainBOL", BOL, BinaryOperatorType.Equal))
        End If
        'If String.IsNullOrEmpty(po) = False Then
        '    theCriteria.Add(New BinaryOperator("ShipMainID.strPO", po, BinaryOperatorType.Equal))
        'End If
        'If String.IsNullOrEmpty(deliveryNoteNumber) = False Then
        '    theCriteria.Add(New BinaryOperator("ShipMainID.DeliveryNoteNumber", deliveryNoteNumber, BinaryOperatorType.Equal))
        'End If
        If shiftID.HasValue Then
            theCriteria.Add(New BinaryOperator("ShipMainID.Shift", shiftID.Value, BinaryOperatorType.Equal))
        End If
        If customerID.HasValue Then
            theCriteria.Add(New BinaryOperator("ShipMainID.ShipMainCustID", customerID.Value, BinaryOperatorType.Equal))
        End If
        If carrierID.HasValue Then
            theCriteria.Add(New BinaryOperator("ShipMainID.ShipMainCarrierID", carrierID.Value, BinaryOperatorType.Equal))
        End If
        If destinationID.HasValue Then
            theCriteria.Add(New BinaryOperator("ShipMainID.intDestination", destinationID.Value, BinaryOperatorType.Equal))
        End If
        If String.IsNullOrEmpty(lot) = False Then
            theCriteria.Add(New BinaryOperator("ReturnDetLot", lot, BinaryOperatorType.Equal))
        End If
        If inactiveCustomers.Value = False Then
            theCriteria.Add(New BinaryOperator("ShipMainID.ShipMainCustID.Inactive", False))
        End If
        If inactiveItems.Value = False Then
            theCriteria.Add(New BinaryOperator("ReturnDetItemID.Inactive", False))
        End If
        If String.IsNullOrEmpty(items) = False Then
            theCriteria.Add(New InOperator("ReturnDetItemID", items.Split("|"c)))
        End If
        If onlyAssignedCustomers = True Then
            theCriteria.Add(New InOperator("ShipMainID.ShipMainCustID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session)))
        End If

        Try
            ShippingReturnsReportXPView.Criteria = GroupOperator.And(theCriteria)
            ShippingReturnsReportXPView.Properties.AddRange(New ViewProperty() {New ViewProperty("ShipMainDate", SortDirection.Ascending, "[ShipMainID].[ShipMainDate]", False, True),
                                                                                New ViewProperty("ShiftName", SortDirection.None, "[ShipMainID].[Shift].[ShiftName]", False, True),
                                                                                New ViewProperty("CustomerName", SortDirection.Ascending, "[ShipMainID].[ShipMainCustID].[CustomerName]", False, True),
                                                                                New ViewProperty("ShipMainBOL", SortDirection.None, "[ShipMainID].[ShipMainBOL]", False, True),
                                                                                New ViewProperty("strPO", SortDirection.None, "[ShipMainID].[strPO]", False, True),
                                                                                New ViewProperty("DeliveryNoteNumber", SortDirection.None, "[ShipMainID].[DeliveryNoteNumber]", False, True),
                                                                                New ViewProperty("ShippingName", SortDirection.None, "[ShipMainID].[intDestination].[ShippingName]", False, True),
                                                                                New ViewProperty("ReturnDetLot", SortDirection.None, "[ReturnDetLot]", False, True),
                                                                                New ViewProperty("ItemCode", SortDirection.Ascending, "[ReturnDetItemID].[ItemCode]", False, True),
                                                                                New ViewProperty("ItemDescription", SortDirection.None, "[ReturnDetItemID].[ItemDescription]", False, True),
                                                                                New ViewProperty("intUnits", SortDirection.None, "[intUnits]", False, True),
                                                                                New ViewProperty("CarrierName", SortDirection.None, "[ShipMainID].[ShipMainCarrierID].[CarrierName]", False, True),
                                                                                New ViewProperty("strTrailer", SortDirection.None, "[ShipMainID].[strTrailer]", False, True),
                                                                                New ViewProperty("strSeal", SortDirection.None, "[ShipMainID].[strSeal]", False, True),
                                                                                New ViewProperty("ExpirationDate", SortDirection.None, "[ExpirationDate]", False, True),
                                                                                New ViewProperty("ExpirationDateFormat", SortDirection.None, "[ShipMainID].[ShipMainCustID].[ExpirationDateFormat]", False, True)})
            Return ShippingReturnsReportXPView
        Catch ex As ArgumentException
            MessageBox.Show(String.Format("There was an error while trying to retrieve the data for the report.{0}{1}", vbCrLf, ex.Message))
        End Try

        Return Nothing


    End Function

End Class
