Imports SuperiorPackGroup.SPGReportsTableAdapters

Imports DXDAL.SPGData
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Text
Imports System.Linq

Public Class ItemsTransactionsReportBLL

    Private m_ItemsTransactionsReportTableAdapter As ItemsTransactionsReportTableAdapter = Nothing
    Private m_ItemsTransactionList As ItemTransactionsList

    Public ReadOnly Property Adapter() As ItemsTransactionsReportTableAdapter
        Get
            If (Me.m_ItemsTransactionsReportTableAdapter Is Nothing) Then
                Me.m_ItemsTransactionsReportTableAdapter = New ItemsTransactionsReportTableAdapter
                Me.m_ItemsTransactionsReportTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return Me.m_ItemsTransactionsReportTableAdapter
        End Get
    End Property

    Public Function GetItemsTransactionsReport(ByVal fromDate As Nullable(Of Date), ByVal toDate As Nullable(Of Date), ByVal customerID As Nullable(Of Integer), ByVal itemType As String,
                                               ByVal items As String, ByVal inactiveItems As Boolean?, ByVal inactiveCustomers As Boolean?) As SPGReports.ItemsTransactionsReportDataTable

        If inactiveCustomers.Value = True Then
            inactiveCustomers = Nothing
        End If

        If inactiveItems.Value = True Then
            inactiveItems = Nothing
        End If

        If String.IsNullOrEmpty(items) Then
            Return Adapter.GetItemsTransactionsReport(customerID, itemType, inactiveCustomers, inactiveItems, fromDate, toDate)
        Else
            Return Adapter.GetItemsTransactionsReportByItemID(customerID, itemType, inactiveCustomers, fromDate, toDate, items)
        End If

    End Function

    Public Function GetItemsTransactionsReport(ByVal fromDate As Nullable(Of Date), ByVal toDate As Nullable(Of Date), ByVal item As Integer?) As ItemTransactionsList

        If item.HasValue = False OrElse toDate.HasValue = False OrElse fromDate.HasValue = False Then
            Return Nothing
        End If

        m_ItemsTransactionList = New ItemTransactionsList

        AddReceivingsToList(fromDate.Value, toDate.Value, item.Value)
        AddShippingsToList(fromDate.Value, toDate.Value, item.Value)
        AddReceivedReturnsToList(fromDate.Value, toDate.Value, item.Value)
        AddShippedReturnsToList(fromDate.Value, toDate.Value, item.Value)
        AddAdjustedToList(fromDate.Value, toDate.Value, item.Value)
        AddProducedToList(fromDate.Value, toDate.Value, item.Value)
        AddUsedInProductionToList(fromDate.Value, toDate.Value, item.Value)

        Return m_ItemsTransactionList

    End Function

    Private Sub AddReceivingsToList(ByVal fromDate As Date, ByVal toDate As Date, ByVal item As Integer)

        Dim openingBalance As Double = CType(Session.DefaultSession.Evaluate(GetType(ReceivingDetail), CriteriaOperator.Parse("Sum(intUnits)"), _
                                                                             New BinaryOperator(ReceivingDetail.Fields.ReceivMainID.ReceivDate, fromDate, BinaryOperatorType.Less) And _
                                                                             New BinaryOperator(ReceivingDetail.Fields.ReceivDetItemID, item, BinaryOperatorType.Equal)), Double)
        m_ItemsTransactionList.OpeningBalance += openingBalance

        Using ReceivedList As XPCollection(Of ReceivingDetail) = New XPCollection(Of ReceivingDetail)(Session.DefaultSession, _
                                                                                                      New BinaryOperator(ReceivingDetail.Fields.ReceivMainID.ReceivDate, fromDate, BinaryOperatorType.GreaterOrEqual) And _
                                                                                                      New BinaryOperator(ReceivingDetail.Fields.ReceivMainID.ReceivDate, toDate, BinaryOperatorType.LessOrEqual) And _
                                                                                                      New BinaryOperator(ReceivingDetail.Fields.ReceivDetItemID, item, BinaryOperatorType.Equal))
            For Each receiving As ReceivingDetail In ReceivedList
                With receiving
                    m_ItemsTransactionList.Add(New ItemTransaction(.ReceivMainID.ReceivDate, .ReceivDetItemID.ItemCode, .ReceivDetItemID.ItemDescription, ItemTransactionType.Received, .intUnits))
                End With
            Next
        End Using

    End Sub

    Private Sub AddShippingsToList(ByVal fromDate As Date, ByVal toDate As Date, ByVal item As Integer)

        Dim openingBalance As Double = CType(Session.DefaultSession.Evaluate(GetType(ShipDet), CriteriaOperator.Parse("Sum(ShipDetDetQty)"), _
                                                                             New BinaryOperator(ShipDet.Fields.ShipDetMainID.ShipMainDate, fromDate, BinaryOperatorType.Less) And _
                                                                             New BinaryOperator(ShipDet.Fields.ShipDetItemID, item, BinaryOperatorType.Equal)), Double) * -1
        m_ItemsTransactionList.OpeningBalance += openingBalance

        Using shippingList As XPCollection(Of ShipDet) = New XPCollection(Of ShipDet)(Session.DefaultSession, _
                                                                                      New BinaryOperator(ShipDet.Fields.ShipDetMainID.ShipMainDate, fromDate, BinaryOperatorType.GreaterOrEqual) And _
                                                                                      New BinaryOperator(ShipDet.Fields.ShipDetMainID.ShipMainDate, toDate, BinaryOperatorType.LessOrEqual) And _
                                                                                      New BinaryOperator(ShipDet.Fields.ShipDetItemID, item, BinaryOperatorType.Equal))
            For Each shipping As ShipDet In shippingList
                With shipping
                    m_ItemsTransactionList.Add(New ItemTransaction(.ShipDetMainID.ShipMainDate, .ShipDetItemID.ItemCode, .ShipDetItemID.ItemDescription, ItemTransactionType.Shipped, .ShipDetDetQty * -1))
                End With
            Next
        End Using

    End Sub

    Private Sub AddReceivedReturnsToList(ByVal fromDate As Date, ByVal toDate As Date, ByVal item As Integer)

        Dim openingBalance As Double = CType(Session.DefaultSession.Evaluate(GetType(ReceivedReturns), CriteriaOperator.Parse("Sum(ReturnDetQty)"), _
                                                                             New BinaryOperator(ReceivedReturns.Fields.ReceiveMainID.ReceivDate, fromDate, BinaryOperatorType.Less) And _
                                                                             New BinaryOperator(ReceivedReturns.Fields.ReturnDetItemID, item, BinaryOperatorType.Equal)), Double)
        m_ItemsTransactionList.OpeningBalance += openingBalance

        Using receivedReturnsList As XPCollection(Of ReceivedReturns) = New XPCollection(Of ReceivedReturns)(Session.DefaultSession, _
                                                                                                             New BinaryOperator(ReceivedReturns.Fields.ReceiveMainID.ReceivDate, fromDate, _
                                                                                                                                BinaryOperatorType.GreaterOrEqual) And _
                                                                                                             New BinaryOperator(ReceivedReturns.Fields.ReceiveMainID.ReceivDate, toDate, BinaryOperatorType.LessOrEqual) And _
                                                                                                             New BinaryOperator(ReceivedReturns.Fields.ReturnDetItemID, item, BinaryOperatorType.Equal))
            For Each receivingReturn As ReceivedReturns In receivedReturnsList
                With receivingReturn
                    m_ItemsTransactionList.Add(New ItemTransaction(.ReceiveMainID.ReceivDate, .ReturnDetItemID.ItemCode, .ReturnDetItemID.ItemDescription, ItemTransactionType.ReceivedReturn, .ReturnDetQty))
                End With
            Next
        End Using

    End Sub

    Private Sub AddShippedReturnsToList(ByVal fromDate As Date, ByVal toDate As Date, ByVal item As Integer)

        Dim openingBalance As Double = CType(Session.DefaultSession.Evaluate(GetType(ShippedReturns), CriteriaOperator.Parse("Sum(intUnits)"), _
                                                                             New BinaryOperator(ShippedReturns.Fields.ShipMainID.ShipMainDate, fromDate, BinaryOperatorType.Less) And _
                                                                             New BinaryOperator(ShippedReturns.Fields.ReturnDetItemID, item, BinaryOperatorType.Equal)), Double) * -1
        m_ItemsTransactionList.OpeningBalance += openingBalance

        Using ShippedReturnsList As XPCollection(Of ShippedReturns) = New XPCollection(Of ShippedReturns)(Session.DefaultSession, _
                                                                                                          New BinaryOperator(ShippedReturns.Fields.ShipMainID.ShipMainDate, fromDate, BinaryOperatorType.GreaterOrEqual) And _
                                                                                                          New BinaryOperator(ShippedReturns.Fields.ShipMainID.ShipMainDate, toDate, BinaryOperatorType.LessOrEqual) And _
                                                                                                          New BinaryOperator(ShippedReturns.Fields.ReturnDetItemID, item, BinaryOperatorType.Equal))
            For Each shippingReturn As ShippedReturns In ShippedReturnsList
                With shippingReturn
                    m_ItemsTransactionList.Add(New ItemTransaction(.ShipMainID.ShipMainDate, .ReturnDetItemID.ItemCode, .ReturnDetItemID.ItemDescription, ItemTransactionType.ShippedReturn, .intUnits * -1))
                End With
            Next
        End Using

    End Sub

    Private Sub AddAdjustedToList(ByVal fromDate As Date, ByVal toDate As Date, ByVal item As Integer)

        Dim openingBalance As Double = CType(Session.DefaultSession.Evaluate(GetType(InventoryAdjustment), CriteriaOperator.Parse("Sum(NewCount) - Sum(OriginalQuantity)"), _
                                                                             New BinaryOperator(InventoryAdjustment.Fields.AdjustmentDate, fromDate, BinaryOperatorType.Less) And _
                                                                             New BinaryOperator(InventoryAdjustment.Fields.AdjustmentItem, item, BinaryOperatorType.Equal)), Double)
        m_ItemsTransactionList.OpeningBalance += openingBalance

        Using AdjustedList As XPCollection(Of InventoryAdjustment) = New XPCollection(Of InventoryAdjustment)(Session.DefaultSession, _
                                                                                                              New BinaryOperator(InventoryAdjustment.Fields.AdjustmentDate, fromDate, BinaryOperatorType.GreaterOrEqual) And _
                                                                                                              New BinaryOperator(InventoryAdjustment.Fields.AdjustmentDate, toDate, BinaryOperatorType.LessOrEqual) And _
                                                                                                              New BinaryOperator(InventoryAdjustment.Fields.AdjustmentItem, item, BinaryOperatorType.Equal))
            For Each adjustment As InventoryAdjustment In AdjustedList
                With adjustment
                    m_ItemsTransactionList.Add(New ItemTransaction(.AdjustmentDate, .AdjustmentItem.ItemCode, .AdjustmentItem.ItemDescription, ItemTransactionType.Adjusted, .NewCount - .OriginalQuantity))
                End With
            Next
        End Using

    End Sub

    Private Sub AddProducedToList(ByVal fromDate As Date, ByVal toDate As Date, ByVal item As Integer)

        Dim openingBalance As Double = CType(Session.DefaultSession.Evaluate(GetType(Inventory), CriteriaOperator.Parse("Sum(InventoryQuantity)"), _
                                                                             New BinaryOperator(Inventory.Fields.InventoryDate, fromDate, BinaryOperatorType.Less) And _
                                                                             New BinaryOperator(Inventory.Fields.InventoryItemID, item, BinaryOperatorType.Equal)), Double)
        m_ItemsTransactionList.OpeningBalance += openingBalance

        Using producedList As XPCollection(Of Inventory) = New XPCollection(Of Inventory)(Session.DefaultSession, _
                                                                                          New BinaryOperator(Inventory.Fields.InventoryDate, fromDate, BinaryOperatorType.GreaterOrEqual) And _
                                                                                          New BinaryOperator(Inventory.Fields.InventoryDate, toDate, BinaryOperatorType.LessOrEqual) And _
                                                                                          New BinaryOperator(Inventory.Fields.InventoryItemID, item, BinaryOperatorType.Equal))
            For Each production As Inventory In producedList
                With production
                    m_ItemsTransactionList.Add(New ItemTransaction(.InventoryDate, .InventoryItemID.ItemCode, .InventoryItemID.ItemDescription, ItemTransactionType.Produced, .InventoryQuantity))
                End With
            Next
        End Using

    End Sub

    Private Sub AddUsedInProductionToList(ByVal fromDate As Date, ByVal toDate As Date, ByVal item As Integer)

        Dim openingBalance As Double = CType(Session.DefaultSession.Evaluate(GetType(InventoryBOMs), CriteriaOperator.Parse( _
                                                                             "Sum((InventoryBOMQuantity + InventoryBOMQuantity * (ScrapFactor)) * InventoryBOMInventoryID.InventoryQuantity * -1)"), _
                                                                             New BinaryOperator(InventoryBOMs.Fields.InventoryBOMInventoryID.InventoryDate, fromDate, BinaryOperatorType.Less) And _
                                                                             New BinaryOperator(InventoryBOMs.Fields.InventoryBOMRawMatID, item, BinaryOperatorType.Equal)), Double)
        m_ItemsTransactionList.OpeningBalance += openingBalance

        Using usedInProductionList As XPCollection(Of InventoryBOMs) = New XPCollection(Of InventoryBOMs)(Session.DefaultSession, _
                                                                                                          New BinaryOperator(InventoryBOMs.Fields.InventoryBOMInventoryID.InventoryDate, fromDate, _
                                                                                                                             BinaryOperatorType.GreaterOrEqual) And _
                                                                                                          New BinaryOperator(InventoryBOMs.Fields.InventoryBOMInventoryID.InventoryDate, toDate, _
                                                                                                                             BinaryOperatorType.LessOrEqual) And _
                                                                                                          New BinaryOperator(InventoryBOMs.Fields.InventoryBOMRawMatID, item, BinaryOperatorType.Equal))
            For Each productionRM As InventoryBOMs In usedInProductionList
                With productionRM
                    Dim qty As Double = (.InventoryBOMQuantity + .InventoryBOMQuantity * (.ScrapFactor)) * .InventoryBOMInventoryID.InventoryQuantity * -1
                    m_ItemsTransactionList.Add(New ItemTransaction(.InventoryBOMInventoryID.InventoryDate, String.Format("{0} (In {1})", .InventoryBOMRawMatID.ItemCode, .InventoryBOMInventoryID.InventoryItemID.ItemCode), _
                                                                   .InventoryBOMRawMatID.ItemDescription, ItemTransactionType.UsedInProduction, qty))
                End With
            Next
        End Using

    End Sub

End Class
