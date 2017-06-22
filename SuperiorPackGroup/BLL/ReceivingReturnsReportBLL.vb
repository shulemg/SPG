Imports DXDAL.SPGData
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Public Class ReceivingReturnsReportBLL

    Public Shared Function GetReceivingReturnsReport(ByVal fromDate As Nullable(Of Date), ByVal toDate As Nullable(Of Date), ByVal shiftID As Nullable(Of Integer), ByVal customerID As Nullable(Of Integer), ByVal lot As String, _
                                                ByVal BOL As String, ByVal vendor As Integer?, ByVal carrierID As Nullable(Of Integer), ByVal items As String, ByVal inactiveItems As Boolean?, _
                                                ByVal inactiveCustomers As Boolean?, ByVal onlyAssignedCustomers As Boolean) As XPView

        Dim ReceivingReturnsReportXPView As New XPView(Session.DefaultSession, GetType(ReceivedReturns))
        Dim theCriteria As New CriteriaOperatorCollection

        If fromDate.HasValue Then
            theCriteria.Add(New BinaryOperator("ReceiveMainID.ReceivDate", fromDate.Value, BinaryOperatorType.GreaterOrEqual))
        End If
        If toDate.HasValue Then
            theCriteria.Add(New BinaryOperator("ReceiveMainID.ReceivDate", toDate.Value, BinaryOperatorType.LessOrEqual))
        End If
        If String.IsNullOrEmpty(BOL) = False Then
            theCriteria.Add(New BinaryOperator("ReceiveMainID.ReceivBOL", BOL, BinaryOperatorType.Equal))
        End If
        If shiftID.HasValue Then
            theCriteria.Add(New BinaryOperator("ReceiveMainID.intShiftID", shiftID.Value, BinaryOperatorType.Equal))
        End If
        If customerID.HasValue Then
            theCriteria.Add(New BinaryOperator("ReceiveMainID.ReceivCustID", customerID.Value, BinaryOperatorType.Equal))
        End If
        If carrierID.HasValue Then
            theCriteria.Add(New BinaryOperator("ReceiveMainID.ReceivCarrierID", carrierID.Value, BinaryOperatorType.Equal))
        End If
        If vendor.HasValue Then
            theCriteria.Add(New BinaryOperator("ReceiveMainID.strVendor", vendor.Value, BinaryOperatorType.Equal))
        End If
        If String.IsNullOrEmpty(lot) = False Then
            theCriteria.Add(New BinaryOperator("ReturnDetLot", lot, BinaryOperatorType.Equal))
        End If
        If inactiveCustomers.Value = False Then
            theCriteria.Add(New BinaryOperator("ReceiveMainID.ReceivCustID.Inactive", False))
        End If
        If inactiveItems.Value = False Then
            theCriteria.Add(New BinaryOperator("ReturnDetItemID.Inactive", False))
        End If
        If String.IsNullOrEmpty(items) = False Then
            theCriteria.Add(New InOperator("ReturnDetItemID", items.Split("|"c)))
        End If
        If onlyAssignedCustomers = True Then
            theCriteria.Add(New InOperator("ReceiveMainID.ReceivCustID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session)))
        End If

        Try
            ReceivingReturnsReportXPView.Criteria = GroupOperator.And(theCriteria)
            ReceivingReturnsReportXPView.Properties.AddRange(New ViewProperty() {New ViewProperty("ReceivDate", SortDirection.Ascending, "[ReceiveMainID].[ReceivDate]", False, True),
                                                                                 New ViewProperty("ShiftName", SortDirection.None, "[ReceiveMainID].[intShiftID].[ShiftName]", False, True),
                                                                                 New ViewProperty("CustomerName", SortDirection.Ascending, "[ReceiveMainID].[ReceivCustID].[CustomerName]", False, True),
                                                                                 New ViewProperty("ReceivBOL", SortDirection.None, "[ReceiveMainID].[ReceivBOL]", False, True),
                                                                                 New ViewProperty("strPO", SortDirection.None, "[ReceiveMainID].[strPO]", False, True),
                                                                                 New ViewProperty("VendorName", SortDirection.None, "[ReceiveMainID].[strVendor].[VendorName]", False, True),
                                                                                 New ViewProperty("ReturnDetLot", SortDirection.None, "[ReturnDetLot]", False, True),
                                                                                 New ViewProperty("ItemCode", SortDirection.Ascending, "[ReturnDetItemID].[ItemCode]", False, True),
                                                                                 New ViewProperty("ItemDescription", SortDirection.None, "[ReturnDetItemID].[ItemDescription]", False, True),
                                                                                 New ViewProperty("ReturnDetQty", SortDirection.None, "[ReturnDetQty]", False, True),
                                                                                 New ViewProperty("CarrierName", SortDirection.None, "[ReceiveMainID].[ReceivCarrierID].[CarrierName]", False, True),
                                                                                 New ViewProperty("strTrailer", SortDirection.None, "[ReceiveMainID].[strTrailer]", False, True),
                                                                                 New ViewProperty("strSeal", SortDirection.None, "[ReceiveMainID].[strSeal]", False, True),
                                                                                 New ViewProperty("ExpirationDate", SortDirection.None, "[ExpirationDate]", False, True),
                                                                                 New ViewProperty("ExpirationDateFormat", SortDirection.None, "[ReceiveMainID].[ReceivCustID].[ExpirationDateFormat]", False, True)})
            Return ReceivingReturnsReportXPView
        Catch ex As Exception
            MessageBox.Show(String.Format("There was an error while trying to retrieve the data for the report.{0}{1}", vbCrLf, ex.Message))
        End Try

        Return Nothing

    End Function

End Class
