Imports DevExpress.Xpo
Imports DXDAL.SPGData
Imports DevExpress.Data.Filtering

Public Class CurrentInventoryReportBLL

    Public Shared Function GetCurrentInventoryReport(ByVal customerID As Integer?, ByVal itemType As String, ByVal items As String, ByVal inactiveItems As Boolean?, ByVal inactiveCustomers As Boolean?, ByVal outOfStockItems As Boolean?,
                                                     ByVal onlyAssignedCustomers As Boolean, ByVal locationID As Integer?) As XPView

        Dim CurrentInventoryReportXPView As New XPView(Session.DefaultSession, GetType(LocationInventory))
        Dim theCriteria As New CriteriaOperatorCollection

        If customerID.HasValue Then
            theCriteria.Add(New BinaryOperator(LocationInventory.Fields.LocationInventoryItem.ItemCustomerID.CustomerID.PropertyName, customerID.Value, BinaryOperatorType.Equal))
        End If
        If String.IsNullOrEmpty(itemType) = False Then
            theCriteria.Add(New BinaryOperator(LocationInventory.Fields.LocationInventoryItem.ItemType.PropertyName, itemType, BinaryOperatorType.Equal))
        End If
        If inactiveCustomers.Value = False Then
            theCriteria.Add(New BinaryOperator(LocationInventory.Fields.LocationInventoryItem.ItemCustomerID.Inactive.PropertyName, False))
        End If
        If inactiveItems.Value = False Then
            theCriteria.Add(New BinaryOperator(LocationInventory.Fields.LocationInventoryItem.Inactive.PropertyName, False))
        End If
        If String.IsNullOrEmpty(items) = False Then
            theCriteria.Add(New InOperator(LocationInventory.Fields.LocationInventoryItem.ItemID.PropertyName, items.Split("|"c)))
        End If
        If outOfStockItems.HasValue = False OrElse outOfStockItems.Value = False Then
            theCriteria.Add(New BinaryOperator(LocationInventory.Fields.QuantityOnHand.PropertyName, 1, BinaryOperatorType.GreaterOrEqual))
        End If
        If onlyAssignedCustomers = True Then
            theCriteria.Add(New InOperator(LocationInventory.Fields.LocationInventoryItem.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session)))
        End If
        If locationID.HasValue Then
            theCriteria.Add(New BinaryOperator(LocationInventory.Fields.Location.Oid.PropertyName, locationID.Value, BinaryOperatorType.Equal))
        End If

        Try
            CurrentInventoryReportXPView.Criteria = CriteriaOperator.And(theCriteria)
            CurrentInventoryReportXPView.Properties.AddRange(New ViewProperty() {New ViewProperty("CustomerName", SortDirection.Ascending, LocationInventory.Fields.LocationInventoryItem.ItemCustomerID.CustomerName.PropertyName, False, True),
                                                                                 New ViewProperty("ItemCode", SortDirection.Ascending, LocationInventory.Fields.LocationInventoryItem.ItemCode.PropertyName, False, True),
                                                                                 New ViewProperty("ItemDescription", SortDirection.None, LocationInventory.Fields.LocationInventoryItem.ItemDescription.PropertyName, False, True),
                                                                                 New ViewProperty("ItemType", SortDirection.None,
                                                                                                  CriteriaOperator.Parse(String.Format("IIF({0} = 'RM', 'Raw Material', IIF({0} = 'IG', 'Intermediate Goods', 'Finished Goods'))",
                                                                                                                                       LocationInventory.Fields.LocationInventoryItem.ItemType.PropertyName)), False, True),
                                                                                 New ViewProperty("QuantityOnHand", SortDirection.None, LocationInventory.Fields.QuantityOnHand.PropertyName, False, True),
                                                                                 New ViewProperty("InventoryByPallets", SortDirection.None,
                                                                                                  CriteriaOperator.Parse(String.Format("IIF({1} = 0, 0, {0} / {1})",
                                                                                                                                       LocationInventory.Fields.QuantityOnHand.PropertyName,
                                                                                                                                       LocationInventory.Fields.LocationInventoryItem.intUnitsPerPallet.PropertyName)), False, True),
                                                                                 New ViewProperty("UOM", SortDirection.None, LocationInventory.Fields.LocationInventoryItem.strUnitOfMeasure.PropertyName, False, True),
                                                                                 New ViewProperty("Location", SortDirection.None, LocationInventory.Fields.Location.LocationCode.PropertyName, False, True),
                                                                                 New ViewProperty("InactiveCustomer", SortDirection.None, LocationInventory.Fields.LocationInventoryItem.ItemCustomerID.Inactive.PropertyName, False, True),
                                                                                 New ViewProperty("InactiveItem", SortDirection.None, LocationInventory.Fields.LocationInventoryItem.Inactive.PropertyName, False, True)})
            Return CurrentInventoryReportXPView
        Catch ex As ArgumentException
            MessageBox.Show(String.Format("There was an error while trying to retrieve the data for the report.{0}{1}", vbCrLf, ex.Message))
        End Try

        Return Nothing

    End Function

End Class
