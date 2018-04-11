Imports DevExpress.Xpo
Imports DXDAL.SPGData
Imports DevExpress.Data.Filtering

Public Class ShippingReportBLL

    Public Shared Function GetShippingReport(ByVal fromDate As Nullable(Of Date), ByVal toDate As Nullable(Of Date), ByVal shiftID As Nullable(Of Integer), ByVal customerID As Nullable(Of Integer), ByVal lot As String, _
                                      ByVal po As String, ByVal BOL As String, ByVal deliveryNoteNumber As String, ByVal destinationID As Nullable(Of Integer), ByVal carrierID As Nullable(Of Integer), _
                                      ByVal items As String, ByVal inactiveItems As Boolean?, ByVal inactiveCustomers As Boolean?, ByVal onlyAssignedCustomers As Boolean) As XPView

        Dim ShippingReportXPView As New XPView(Session.DefaultSession, GetType(ShipDet))
        Dim theCriteria As New CriteriaOperatorCollection

        If fromDate.HasValue Then
            theCriteria.Add(New BinaryOperator("ShipDetMainID.ShipMainDate", fromDate.Value, BinaryOperatorType.GreaterOrEqual))
        End If
        If toDate.HasValue Then
            theCriteria.Add(New BinaryOperator("ShipDetMainID.ShipMainDate", toDate.Value, BinaryOperatorType.LessOrEqual))
        End If
        If String.IsNullOrEmpty(BOL) = False Then
            theCriteria.Add(New BinaryOperator("ShipDetMainID.ShipMainBOL", BOL, BinaryOperatorType.Equal))
        End If
        If String.IsNullOrEmpty(po) = False Then
            theCriteria.Add(New BinaryOperator("ShipDetMainID.strPO", po, BinaryOperatorType.Equal))
        End If
        If String.IsNullOrEmpty(deliveryNoteNumber) = False Then
            theCriteria.Add(New BinaryOperator("ShipDetMainID.DeliveryNoteNumber", deliveryNoteNumber, BinaryOperatorType.Equal))
        End If
        If shiftID.HasValue Then
            theCriteria.Add(New BinaryOperator("ShipDetMainID.Shift", shiftID.Value, BinaryOperatorType.Equal))
        End If
        If customerID.HasValue Then
            theCriteria.Add(New BinaryOperator("ShipDetMainID.ShipMainCustID", customerID.Value, BinaryOperatorType.Equal))
        End If
        If carrierID.HasValue Then
            theCriteria.Add(New BinaryOperator("ShipDetMainID.ShipMainCarrierID", carrierID.Value, BinaryOperatorType.Equal))
        End If
        If destinationID.HasValue Then
            theCriteria.Add(New BinaryOperator("ShipDetMainID.intDestination", destinationID.Value, BinaryOperatorType.Equal))
        End If
        If String.IsNullOrEmpty(lot) = False Then
            theCriteria.Add(New BinaryOperator("ShipDetLot", lot, BinaryOperatorType.Equal))
        End If
        If inactiveCustomers.Value = False Then
            theCriteria.Add(New BinaryOperator("ShipDetMainID.ShipMainCustID.Inactive", False))
        End If
        If inactiveItems.Value = False Then
            theCriteria.Add(New BinaryOperator("ShipDetItemID.Inactive", False))
        End If
        If String.IsNullOrEmpty(items) = False Then
            theCriteria.Add(New InOperator("ShipDetItemID", items.Split("|"c)))
        End If
        If onlyAssignedCustomers = True Then
            theCriteria.Add(New InOperator("ShipDetMainID.ShipMainCustID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session)))
        End If

        Try
            ShippingReportXPView.Criteria = GroupOperator.And(theCriteria)
            ShippingReportXPView.Properties.AddRange(New ViewProperty() {New ViewProperty("ShipMainDate", SortDirection.Ascending, "[ShipDetMainID].[ShipMainDate]", False, True),
                                                                         New ViewProperty("ShiftName", SortDirection.None, "[ShipDetMainID].[Shift].[ShiftName]", False, True),
                                                                         New ViewProperty("CustomerName", SortDirection.Ascending, "[ShipDetMainID].[ShipMainCustID].[CustomerName]", False, True),
                                                                         New ViewProperty("ShipMainBOL", SortDirection.None, "[ShipDetMainID].[ShipMainBOL]", False, True),
                                                                         New ViewProperty("strPO", SortDirection.None, "[ShipDetMainID].[strPO]", False, True),
                                                                         New ViewProperty("DeliveryNoteNumber", SortDirection.None, "[ShipDetMainID].[DeliveryNoteNumber]", False, True),
                                                                         New ViewProperty("ShippingName", SortDirection.None, "[ShipDetMainID].[intDestination].[ShippingName]", False, True),
                                                                         New ViewProperty("ShipDetLot", SortDirection.None, "[ShipDetLot]", False, True),
                                                                         New ViewProperty("FullLPNNumber", SortDirection.None, "[FullLPNNumber]", False, True),
                                                                         New ViewProperty("ItemCode", SortDirection.Ascending, "[ShipDetItemID].[ItemCode]", False, True),
                                                                         New ViewProperty("ItemDescription", SortDirection.None, "[ShipDetItemID].[ItemDescription]", False, True),
                                                                         New ViewProperty("ShipDetDetQty", SortDirection.None, "[ShipDetDetQty]", False, True),
                                                                         New ViewProperty("CarrierName", SortDirection.None, "[ShipDetMainID].[ShipMainCarrierID].[CarrierName]", False, True),
                                                                         New ViewProperty("strTrailer", SortDirection.None, "[ShipDetMainID].[strTrailer]", False, True),
                                                                         New ViewProperty("strSeal", SortDirection.None, "[ShipDetMainID].[strSeal]", False, True),
                                                                         New ViewProperty("ExpirationDate", SortDirection.None, "[ExpirationDate]", False, True),
                                                                         New ViewProperty("ExpirationDateFormat", SortDirection.None, "[ShipDetMainID].[ShipMainCustID].[ExpirationDateFormat]", False, True)})
            Return ShippingReportXPView
        Catch ex As ArgumentException
            MessageBox.Show(String.Format("There was an error while trying to retrieve the data for the report.{0}{1}", vbCrLf, ex.Message))
        End Try

        Return Nothing

    End Function

End Class
