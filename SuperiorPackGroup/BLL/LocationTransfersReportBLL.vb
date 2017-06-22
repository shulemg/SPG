Imports DXDAL.SPGData
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Public Class LocationTransfersReportBLL

    Public Shared Function GetLocationTransfersReportView(ByVal onlyAssigned As Boolean) As XPView

        Dim locationTransfersReportView As New XPView(Session.DefaultSession, GetType(LocationTransferDetails))

        Try
            If onlyAssigned Then
                locationTransfersReportView.Criteria = New InOperator(LocationTransferDetails.Fields.TransferItem.ItemCustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session))
            End If

            locationTransfersReportView.Properties.AddRange(New ViewProperty() {New ViewProperty("TransferDate", SortDirection.None, LocationTransferDetails.Fields.Transfer.TransferDate.PropertyName, False, True),
                                                                                New ViewProperty("FromLocation", SortDirection.None, LocationTransferDetails.Fields.Transfer.FromLocation.LocationCode.PropertyName, False, True),
                                                                                New ViewProperty("ToLocation", SortDirection.None, LocationTransferDetails.Fields.Transfer.ToLocation.LocationCode.PropertyName, False, True),
                                                                                New ViewProperty("ItemCode", SortDirection.None, LocationTransferDetails.Fields.TransferItem.ItemCode.PropertyName, False, True),
                                                                                New ViewProperty("ItemDescription", SortDirection.None, LocationTransferDetails.Fields.TransferItem.ItemDescription.PropertyName, False, True),
                                                                                New ViewProperty("TransferNumber", SortDirection.None, LocationTransferDetails.Fields.Transfer.TransferNumber.PropertyName, False, True),
                                                                                New ViewProperty("ItemLot", SortDirection.None, LocationTransferDetails.Fields.TransferLot.PropertyName, False, True),
                                                                                New ViewProperty("ExpirationDate", SortDirection.None, LocationTransferDetails.Fields.ItemExpirationDate.PropertyName, False, True),
                                                                                New ViewProperty("TransferQuantity", SortDirection.None, LocationTransferDetails.Fields.TransferQuantity.PropertyName, False, True),
                                                                                New ViewProperty("ExpirationDateFormat", SortDirection.None, LocationTransferDetails.Fields.TransferItem.ItemCustomerID.ExpirationDateFormat.PropertyName, False, True),
                                                                                New ViewProperty("TransferUnits", SortDirection.None, LocationTransferDetails.Fields.TransferUnits.PropertyName, False, True),
                                                                                New ViewProperty("TransferPallets", SortDirection.None, LocationTransferDetails.Fields.TransferPallets.PropertyName, False, True),
                                                                                New ViewProperty("Carrier", SortDirection.None, LocationTransferDetails.Fields.Transfer.TransferCarrier.CarrierName.PropertyName, False, True)
                                                                               })
            Return locationTransfersReportView
        Catch ex As ArgumentException
            MessageBox.Show(String.Format("There was an error while trying to retrieve the data for the report.{0}{1}", vbCrLf, ex.Message))
        End Try

        Return Nothing

    End Function

End Class
