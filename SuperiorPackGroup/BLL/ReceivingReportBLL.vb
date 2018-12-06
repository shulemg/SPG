Imports DevExpress.Xpo
Imports DXDAL.SPGData
Imports DevExpress.Data.Filtering

Public Class ReceivingReportBLL

    Public Shared Function GetReceivingReport(ByVal fromDate As Date?, ByVal toDate As Date?, ByVal shiftID As Integer?, ByVal customerID As Integer?, ByVal lot As String, _
                                      ByVal po As String, ByVal BOL As String, ByVal vendor As Integer?, ByVal carrierID As Integer?, ByVal items As String, ByVal inactiveItems As Boolean?, _
                                      ByVal onlyAssignedCustomers As Boolean, ByVal inactiveCustomers As Boolean?) As XPView

        Dim ReceivingReportXPView As New XPView(Session.DefaultSession, GetType(ReceivingDetail))
        Dim theCriteria As New CriteriaOperatorCollection

        If fromDate.HasValue Then
            theCriteria.Add(New BinaryOperator("ReceivMainID.ReceivDate", fromDate.Value, BinaryOperatorType.GreaterOrEqual))
        End If
        If toDate.HasValue Then
            theCriteria.Add(New BinaryOperator("ReceivMainID.ReceivDate", toDate.Value, BinaryOperatorType.LessOrEqual))
        End If
        If String.IsNullOrEmpty(BOL) = False Then
            theCriteria.Add(New BinaryOperator("ReceivMainID.ReceivBOL", BOL, BinaryOperatorType.Equal))
        End If
        If String.IsNullOrEmpty(po) = False Then
            theCriteria.Add(New BinaryOperator("ReceivMainID.strPO", po, BinaryOperatorType.Equal))
        End If
        If shiftID.HasValue Then
            theCriteria.Add(New BinaryOperator("ReceivMainID.intShiftID", shiftID.Value, BinaryOperatorType.Equal))
        End If
        If customerID.HasValue Then
            theCriteria.Add(New BinaryOperator("ReceivMainID.ReceivCustID", customerID.Value, BinaryOperatorType.Equal))
        End If
        If carrierID.HasValue Then
            theCriteria.Add(New BinaryOperator("ReceivMainID.ReceivCarrierID", carrierID.Value, BinaryOperatorType.Equal))
        End If
        If vendor.HasValue Then
            theCriteria.Add(New BinaryOperator("ReceivMainID.strVendor", vendor.Value, BinaryOperatorType.Equal))
        End If
        If String.IsNullOrEmpty(lot) = False Then
            theCriteria.Add(New BinaryOperator("ReceivDetLot", lot, BinaryOperatorType.Equal))
        End If
        If inactiveCustomers.Value = False Then
            theCriteria.Add(New BinaryOperator("ReceivMainID.ReceivCustID.Inactive", False))
        End If
        If inactiveItems.Value = False Then
            theCriteria.Add(New BinaryOperator("ReceivDetItemID.Inactive", False))
        End If
        If String.IsNullOrEmpty(items) = False Then
            theCriteria.Add(New InOperator("ReceivDetItemID", items.Split("|"c)))
        End If
        If onlyAssignedCustomers = True Then
            theCriteria.Add(New InOperator("ReceivMainID.ReceivCustID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session)))
        End If

        Try
            ReceivingReportXPView.Criteria = CriteriaOperator.And(theCriteria)
            ReceivingReportXPView.Properties.AddRange(New ViewProperty() {New ViewProperty("ReceivDate", SortDirection.Ascending, "[ReceivMainID].[ReceivDate]", False, True),
                                                                          New ViewProperty("ShiftName", SortDirection.None, "[ReceivMainID].[intShiftID].[ShiftName]", False, True),
                                                                          New ViewProperty("CustomerName", SortDirection.Ascending, "[ReceivMainID].[ReceivCustID].[CustomerName]", False, True),
                                                                          New ViewProperty("ReceivBOL", SortDirection.None, "[ReceivMainID].[ReceivBOL]", False, True),
                                                                          New ViewProperty("strPO", SortDirection.None, "[ReceivMainID].[strPO]", False, True),
                                                                          New ViewProperty("VendorName", SortDirection.None, "[ReceivMainID].[strVendor].[VendorName]", False, True),
                                                                          New ViewProperty("ReceivDetLot", SortDirection.None, "[ReceivDetLot]", False, True),
                                                                          New ViewProperty("ItemCode", SortDirection.Ascending, "[ReceivDetItemID].[ItemCode]", False, True),
                                                                          New ViewProperty("ItemDescription", SortDirection.None, "[ReceivDetItemID].[ItemDescription]", False, True),
                                                                          New ViewProperty("intUnits", SortDirection.None, "[intUnits]", False, True),
                                                                          New ViewProperty("CarrierName", SortDirection.None, "[ReceivMainID].[ReceivCarrierID].[CarrierName]", False, True),
                                                                          New ViewProperty("strTrailer", SortDirection.None, "[ReceivMainID].[strTrailer]", False, True),
                                                                          New ViewProperty("strSeal", SortDirection.None, "[ReceivMainID].[strSeal]", False, True),
                                                                          New ViewProperty("ExpirationDate", SortDirection.None, "[ExpirationDate]", False, True),
                                                                          New ViewProperty("ExpirationDateFormat", SortDirection.None, "[ReceivMainID].[ReceivCustID].[ExpirationDateFormat]", False, True)})
            Return ReceivingReportXPView
        Catch ex As ArgumentException
            MessageBox.Show(String.Format("There was an error while trying to retrieve the data for the report.{0}{1}", vbCrLf, ex.Message))
        End Try

        Return Nothing

    End Function

End Class
