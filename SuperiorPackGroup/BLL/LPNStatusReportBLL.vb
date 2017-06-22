Imports DXDAL.SPGData
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Public Class LPNStatusReportBLL

    Public Shared Function GetLpnStatusrReportView(ByVal onlyAssigned As Boolean) As XPView

        Dim lpnStatusReportView As New XPView(Session.DefaultSession, GetType(Inventory))

        Try
            If onlyAssigned Then
                lpnStatusReportView.GroupCriteria = GroupOperator.And(New InOperator(Inventory.Fields.InventoryItemID.ItemCustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session)),
                                                                      New BinaryOperator(Inventory.Fields.InventoryDate.PropertyName, CDate("Aug/4/2013"), BinaryOperatorType.GreaterOrEqual),
                                                                      CriteriaOperator.Parse("[FullLPNNumber] Is Not NULL"))
            Else
                lpnStatusReportView.GroupCriteria = GroupOperator.And(New BinaryOperator(Inventory.Fields.InventoryDate.PropertyName, CDate("Aug/4/2013"), BinaryOperatorType.GreaterOrEqual),
                                                                      CriteriaOperator.Parse("[FullLPNNumber] Is Not NULL"))
            End If

            lpnStatusReportView.Properties.AddRange(New ViewProperty() {New ViewProperty("Full LPN Number", SortDirection.Ascending, Inventory.Fields.FullLPNNumber, True, True),
                                                                        New ViewProperty("Item #", SortDirection.Ascending, Inventory.Fields.InventoryItemID.ItemCode, True, True),
                                                                        New ViewProperty("Quantity", SortDirection.None, "Sum([InventoryQuantity])", False, True),
                                                                        New ViewProperty("Production Date", SortDirection.Ascending, Inventory.Fields.InventoryDate, True, True),
                                                                        New ViewProperty("Shipping Date", SortDirection.Ascending, Inventory.Fields.Shipment.ShipMainDate, True, True),
                                                                        New ViewProperty("BOL #", SortDirection.Ascending, Inventory.Fields.Shipment.ShipMainBOL, True, True),
                                                                        New ViewProperty("Customer Name", SortDirection.None, Inventory.Fields.InventoryItemID.ItemCustomerID.CustomerName, True, True),
                                                                        New ViewProperty("ShippingID", SortDirection.None, Inventory.Fields.Shipment.ShipMainID, True, True)
                                                                       })
            Return lpnStatusReportView
        Catch ex As ArgumentException
            MessageBox.Show(String.Format("There was an error while trying to retrieve the data for the report.{0}{1}", vbCrLf, ex.Message))
        End Try

        Return Nothing

    End Function

End Class
