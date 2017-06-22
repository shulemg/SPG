Imports SuperiorPackGroup.SPGReportsTableAdapters
Imports DevExpress.Xpo
Imports DXDAL.SPGData
Imports DevExpress.Data.Filtering

Public Class ProductionEntriesReportBLL

    Private m_ProductionEntriesReportTableAdapter As ProductionEntriesReportTableAdapter = Nothing

    Public ReadOnly Property Adapter() As ProductionEntriesReportTableAdapter
        Get
            If (Me.m_ProductionEntriesReportTableAdapter Is Nothing) Then
                Me.m_ProductionEntriesReportTableAdapter = New ProductionEntriesReportTableAdapter
                Me.m_ProductionEntriesReportTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return Me.m_ProductionEntriesReportTableAdapter
        End Get
    End Property

    Public Function GetProductionEntriesReport(ByVal fromDate As Nullable(Of Date), ByVal toDate As Nullable(Of Date), ByVal customerID As Nullable(Of Integer), ByVal lot As String, ByVal po As String, _
                                               ByVal items As String, ByVal inactiveItems As Boolean?, ByVal inactiveCustomers As Boolean?, ByVal shift As Integer?) As SPGReports.ProductionEntriesReportDataTable

        If inactiveCustomers.Value = True Then
            inactiveCustomers = Nothing
        End If

        If inactiveItems.Value = True Then
            inactiveItems = Nothing
        End If

        If String.IsNullOrEmpty(items) Then
            Return Adapter.GetProductionEntriesReport(fromDate, toDate, customerID, lot, po, inactiveCustomers, inactiveItems, shift)
        Else
            Return Adapter.GetProductionEntriesReportByItem(fromDate, toDate, customerID, lot, po, inactiveCustomers, shift, items)
        End If

    End Function

    Public Shared Function GetProductionEntriesReportView(ByVal onlyAssigned As Boolean) As XPView

        Dim productionEntriesReportXPView As New XPView(Session.DefaultSession, GetType(Inventory))
        'Dim theCriteria As New CriteriaOperatorCollection

        'If customerID.HasValue Then
        '    theCriteria.Add(New BinaryOperator("ItemCustomerID", customerID.Value, BinaryOperatorType.Equal))
        'End If
        'If String.IsNullOrEmpty(itemType) = False Then
        '    theCriteria.Add(New BinaryOperator("ItemType", itemType, BinaryOperatorType.Equal))
        'End If
        'If inactiveCustomers.Value = False Then
        '    theCriteria.Add(New BinaryOperator("ItemCustomerID.Inactive", False))
        'End If
        'If inactiveItems.Value = False Then
        '    theCriteria.Add(New BinaryOperator("Inactive", False))
        'End If
        'If String.IsNullOrEmpty(Items) = False Then
        '    theCriteria.Add(New InOperator("ItemID", Items.Split("|"c)))
        'End If
        'If outOfStockItems.HasValue = False OrElse outOfStockItems.Value = False Then
        '    theCriteria.Add(New BinaryOperator("sngQuantityOnHand", 1, BinaryOperatorType.GreaterOrEqual))
        'End If     
        'If onlyAssignedCustomers = True Then
        '    theCriteria.Add(New InOperator("ItemCustomerID", UsersCustomerBLL.GetAssignedCustomerIDs))
        'End If

        Try
            If onlyAssigned Then
                productionEntriesReportXPView.Criteria = New InOperator(Inventory.Fields.InventoryItemID.ItemCustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session))
            End If
            'productionEntriesReportXPView.Criteria = GroupOperator.And(theCriteria)
            productionEntriesReportXPView.Properties.AddRange(New ViewProperty() {New ViewProperty("Production Date", SortDirection.Ascending, Inventory.Fields.InventoryDate, False, True),
                                                                                  New ViewProperty("Customer Name", SortDirection.Ascending, Inventory.Fields.InventoryItemID.ItemCustomerID.CustomerName,
                                                                                                   False, True),
                                                                                  New ViewProperty("Item #", SortDirection.Ascending, Inventory.Fields.InventoryItemID.ItemCode, False, True),
                                                                                  New ViewProperty("Item Description", SortDirection.None, Inventory.Fields.InventoryItemID.ItemDescription, False, True),
                                                                                  New ViewProperty("Item Type", SortDirection.None,
                                                                                                   CriteriaOperator.Parse(String.Format("IIF({0} = 'RM', 'Raw Material', IIF({0} = 'IG', 'Intermediate Goods', 'Finished Goods'))",
                                                                                                                                        Inventory.Fields.InventoryItemID.ItemType.PropertyName)), False, True),
                                                                                  New ViewProperty("Shift", SortDirection.Ascending, Inventory.Fields.Shift.ShiftName, False, True),
                                                                                  New ViewProperty("Quantity", SortDirection.None, Inventory.Fields.InventoryQuantity, False, True),
                                                                                  New ViewProperty("PO #", SortDirection.Ascending, Inventory.Fields.PO, False, True),
                                                                                  New ViewProperty("Lot #", SortDirection.Ascending, Inventory.Fields.Lot, False, True),
                                                                                  New ViewProperty("Pallet #", SortDirection.None, Inventory.Fields.Pallet, False, True),
                                                                                  New ViewProperty("LPN #", SortDirection.Ascending, Inventory.Fields.LPNNumber, False, True),
                                                                                  New ViewProperty("Expiration Date", SortDirection.None, Inventory.Fields.ExpirationDate, False, True),
                                                                                  New ViewProperty("ExpirationDateFormat", SortDirection.None,
                                                                                                   Inventory.Fields.InventoryItemID.ItemCustomerID.ExpirationDateFormat, False, True),
                                                                                  New ViewProperty("Note", SortDirection.None, Inventory.Fields.Note, False, True)})
            Return productionEntriesReportXPView
        Catch ex As ArgumentException
            MessageBox.Show(String.Format("There was an error while trying to retrieve the data for the report.{0}{1}", vbCrLf, ex.Message))
        End Try

        Return Nothing

    End Function

End Class
