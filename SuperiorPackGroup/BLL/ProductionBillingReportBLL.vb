Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DXDAL.SPGData

Public Class ProductionBillingReportBLL

    Public Shared Function GetProductionBillingReportView(ByVal onlyAssigned As Boolean) As XPView

        Dim productionBillingReportXPView As New XPView(Session.DefaultSession, GetType(Inventory))

        Try
            If onlyAssigned Then
                productionBillingReportXPView.Criteria = New InOperator(Inventory.Fields.InventoryItemID.ItemCustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session))
            End If
            productionBillingReportXPView.Properties.AddRange(New ViewProperty() {New ViewProperty("Production Date", SortDirection.Ascending, Inventory.Fields.InventoryDate, True, True),
                                                                                  New ViewProperty("Customer Name", SortDirection.Ascending, Inventory.Fields.InventoryItemID.ItemCustomerID.CustomerName,
                                                                                                   True, True),
                                                                                  New ViewProperty("Item #", SortDirection.Ascending, Inventory.Fields.InventoryItemID.ItemCode, True, True),
                                                                                  New ViewProperty("Item Description", SortDirection.None, Inventory.Fields.InventoryItemID.ItemDescription, True, True),
                                                                                  New ViewProperty("Item Type", SortDirection.None,
                                                                                                   CriteriaOperator.Parse(String.Format("IIF({0} = 'RM', 'Raw Material', IIF({0} = 'IG', 'Intermediate Goods', 'Finished Goods'))",
                                                                                                                                        Inventory.Fields.InventoryItemID.ItemType.PropertyName)), True, True),
                                                                                  New ViewProperty("Shift", SortDirection.Ascending, Inventory.Fields.Shift.ShiftName, True, True),
                                                                                  New ViewProperty("PO #", SortDirection.Ascending, Inventory.Fields.PO, True, True),
                                                                                  New ViewProperty("UOM", SortDirection.Ascending, Inventory.Fields.InventoryItemID.strUnitOfMeasure, True, True),
                                                                                  New ViewProperty("Quantity", SortDirection.None,
                                                                                                   CriteriaOperator.Parse(String.Format("Sum({0})", Inventory.Fields.InventoryQuantity.PropertyName)),
                                                                                                                          False, True),
                                                                                  New ViewProperty("Cases", SortDirection.Ascending,
                                                                                                   CriteriaOperator.Parse(String.Format("Sum({0}/{1})", Inventory.Fields.InventoryQuantity.PropertyName,
                                                                                                                                        Inventory.Fields.InventoryItemID.intUnitsPerCase.PropertyName)),
                                                                                                                          False, True),
                                                                                  New ViewProperty("Price", SortDirection.Ascending,
                                                                                                   CriteriaOperator.Parse(String.Format("Sum({0}*{1})", Inventory.Fields.InventoryQuantity.PropertyName,
                                                                                                                                        Inventory.Fields.InventoryItemID.dblPrice.PropertyName)),
                                                                                                                          False, True)})
            Return productionBillingReportXPView
        Catch ex As ArgumentException
            MessageBox.Show(String.Format("There was an error while trying to retrieve the data for the report.{0}{1}", vbCrLf, ex.Message))
        End Try

        Return Nothing

    End Function

End Class
