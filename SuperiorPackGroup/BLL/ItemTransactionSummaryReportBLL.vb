Imports DXDAL.SPGData
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Public Class ItemTransactionSummaryReportBLL

    Private transactionSummary As ItemTransactionSummary

    Public Function GetItemTransactionSummaryReport(ByVal fromDate As Date?, ByVal toDate As Date?, ByVal itemCustomerID As Integer?, ByVal items As String, ByVal itemType As String, ByVal onlyAssigned As Boolean) As ItemTransactionSummaryList

        If fromDate.HasValue = False AndAlso toDate.HasValue = False AndAlso itemCustomerID.HasValue = False AndAlso String.IsNullOrEmpty(items) Then
            Return Nothing
        End If

        Dim transactionsSummaryList As New ItemTransactionSummaryList

        Try
            Dim itemsXPView As XPView
            Dim theCriteria As New CriteriaOperatorCollection

            If itemCustomerID.HasValue Then
                theCriteria.Add(New BinaryOperator("ItemCustomerID", itemCustomerID.Value, BinaryOperatorType.Equal))
            End If
            If onlyAssigned Then
                theCriteria.Add(New InOperator("ItemCustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session)))
            End If
            If String.IsNullOrEmpty(itemType) = False Then
                theCriteria.Add(New BinaryOperator("ItemType", itemType, BinaryOperatorType.Equal))
            End If
            If String.IsNullOrEmpty(items) = False Then
                theCriteria.Add(New InOperator("ItemID", items.Split("|"c)))
            End If

            itemsXPView = New XPView(Session.DefaultSession, GetType(Items)) With {.Criteria = GroupOperator.And(theCriteria)}
            itemsXPView.Properties.Add(New ViewProperty("ItemID", SortDirection.None, "ItemID", False, True))

            For Each item As ViewRecord In itemsXPView
                transactionSummary = New ItemTransactionSummary
                Dim currentItem As Items = Session.DefaultSession.GetObjectByKey(Of Items)(item("ItemID"))
                transactionSummary.CustomerName = currentItem.ItemCustomerID.CustomerName
                transactionSummary.ItemCode = currentItem.ItemCode
                transactionSummary.ItemDescription = currentItem.ItemDescription
                transactionSummary.ItemType = IIf(currentItem.ItemType = "RM", "Raw Material", IIf(currentItem.ItemType = "IG", "Intermediate Goods", "Finished Goods")).ToString
                AddReceivingsToSumary(fromDate, toDate, currentItem.ItemID)
                AddShippingsToSummary(fromDate, toDate, currentItem.ItemID)
                AddAdjustmentsToSummary(fromDate, toDate, currentItem.ItemID)
                AddProductionToSummary(fromDate, toDate, currentItem.ItemID)
                AddUsedInProductiontoSummary(fromDate, toDate, currentItem.ItemID)
                If transactionSummary.Received <> 0 OrElse transactionSummary.Produced <> 0 OrElse transactionSummary.Adjusted <> 0 OrElse transactionSummary.Shipped <> 0 OrElse transactionSummary.UsedInProduction <> 0 Then
                    transactionsSummaryList.Add(transactionSummary)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(String.Format("There was an error while trying to retrieve the data for the report.{0}{1}", vbCrLf, ex.Message))
            Return Nothing
        End Try

        Return transactionsSummaryList

    End Function

    Private Sub AddReceivingsToSumary(ByVal fromDate As Date?, ByVal toDate As Date?, ByVal currentItem As Integer)

        Dim total As Double
        Dim theCriteria As New CriteriaOperatorCollection

        If fromDate.HasValue Then
            theCriteria.Add(New BinaryOperator("ReceivMainID.ReceivDate", fromDate.Value, BinaryOperatorType.GreaterOrEqual))
        End If
        If toDate.HasValue Then
            theCriteria.Add(New BinaryOperator("ReceivMainID.ReceivDate", toDate.Value, BinaryOperatorType.LessOrEqual))
        End If

        theCriteria.Add(New BinaryOperator("ReceivDetItemID", currentItem, BinaryOperatorType.Equal))
        total = CType(Session.DefaultSession.Evaluate(GetType(ReceivingDetail), CriteriaOperator.Parse("Sum(intUnits)"), GroupOperator.And(theCriteria)), Double)

        theCriteria.Clear()

        If fromDate.HasValue Then
            theCriteria.Add(New BinaryOperator("ReceiveMainID.ReceivDate", fromDate.Value, BinaryOperatorType.GreaterOrEqual))
        End If
        If toDate.HasValue Then
            theCriteria.Add(New BinaryOperator("ReceiveMainID.ReceivDate", toDate.Value, BinaryOperatorType.LessOrEqual))
        End If
        theCriteria.Add(New BinaryOperator("ReturnDetItemID", currentItem, BinaryOperatorType.Equal))
        total += CType(Session.DefaultSession.Evaluate(GetType(ReceivedReturns), CriteriaOperator.Parse("Sum(ReturnDetQty)"), GroupOperator.And(theCriteria)), Double)

        transactionSummary.Received = total

    End Sub

    Private Sub AddShippingsToSummary(ByVal fromDate As Date?, ByVal toDate As Date?, ByVal currentItem As Integer)

        Dim total As Double
        Dim theCriteria As New CriteriaOperatorCollection

        If fromDate.HasValue Then
            theCriteria.Add(New BinaryOperator("ShipDetMainID.ShipMainDate", fromDate.Value, BinaryOperatorType.GreaterOrEqual))
        End If
        If toDate.HasValue Then
            theCriteria.Add(New BinaryOperator("ShipDetMainID.ShipMainDate", toDate.Value, BinaryOperatorType.LessOrEqual))
        End If
        theCriteria.Add(New BinaryOperator("ShipDetItemID", currentItem, BinaryOperatorType.Equal))
        total = CType(Session.DefaultSession.Evaluate(GetType(ShipDet), CriteriaOperator.Parse("Sum(ShipDetDetQty)"), GroupOperator.And(theCriteria)), Double)

        theCriteria.Clear()

        If fromDate.HasValue Then
            theCriteria.Add(New BinaryOperator("ShipMainID.ShipMainDate", fromDate.Value, BinaryOperatorType.GreaterOrEqual))
        End If
        If toDate.HasValue Then
            theCriteria.Add(New BinaryOperator("ShipMainID.ShipMainDate", toDate.Value, BinaryOperatorType.LessOrEqual))
        End If
        theCriteria.Add(New BinaryOperator("ReturnDetItemID", currentItem, BinaryOperatorType.Equal))
        total += CType(Session.DefaultSession.Evaluate(GetType(ShippedReturns), CriteriaOperator.Parse("Sum(intUnits)"), GroupOperator.And(theCriteria)), Double)

        transactionSummary.Shipped = total

    End Sub

    Private Sub AddAdjustmentsToSummary(ByVal fromDate As Date?, ByVal toDate As Date?, ByVal currentItem As Integer)

        Dim theCriteria As New CriteriaOperatorCollection

        If fromDate.HasValue Then
            theCriteria.Add(New BinaryOperator("AdjustmentDate", fromDate.Value, BinaryOperatorType.GreaterOrEqual))
        End If
        If toDate.HasValue Then
            theCriteria.Add(New BinaryOperator("AdjustmentDate", toDate.Value, BinaryOperatorType.LessOrEqual))
        End If
        theCriteria.Add(New BinaryOperator("AdjustmentItem", currentItem, BinaryOperatorType.Equal))
        transactionSummary.Adjusted = CType(Session.DefaultSession.Evaluate(GetType(InventoryAdjustment), CriteriaOperator.Parse("Sum(NewCount) - Sum(OriginalQuantity)"), GroupOperator.And(theCriteria)), Double)

    End Sub

    Private Sub AddProductionToSummary(ByVal fromDate As Date?, ByVal toDate As Date?, ByVal currentItem As Integer)

        Dim theCriteria As New CriteriaOperatorCollection

        If fromDate.HasValue Then
            theCriteria.Add(New BinaryOperator("InventoryDate", fromDate.Value, BinaryOperatorType.GreaterOrEqual))
        End If
        If toDate.HasValue Then
            theCriteria.Add(New BinaryOperator("InventoryDate", toDate.Value, BinaryOperatorType.LessOrEqual))
        End If
        theCriteria.Add(New BinaryOperator("InventoryItemID", currentItem, BinaryOperatorType.Equal))
        transactionSummary.Produced = CType(Session.DefaultSession.Evaluate(GetType(Inventory), CriteriaOperator.Parse("Sum(InventoryQuantity)"), GroupOperator.And(theCriteria)), Double)

    End Sub

    Private Sub AddUsedInProductiontoSummary(ByVal fromDate As Date?, ByVal toDate As Date?, ByVal currentItem As Integer)

        Dim theCriteria As New CriteriaOperatorCollection

        If fromDate.HasValue Then
            theCriteria.Add(New BinaryOperator("InventoryBOMInventoryID.InventoryDate", fromDate.Value, BinaryOperatorType.GreaterOrEqual))
        End If
        If toDate.HasValue Then
            theCriteria.Add(New BinaryOperator("InventoryBOMInventoryID.InventoryDate", toDate.Value, BinaryOperatorType.LessOrEqual))
        End If
        theCriteria.Add(New BinaryOperator("InventoryBOMRawMatID", currentItem, BinaryOperatorType.Equal))
        transactionSummary.UsedInProduction = CType(Session.DefaultSession.Evaluate(GetType(InventoryBOMs), CriteriaOperator.Parse("Sum((InventoryBOMQuantity + InventoryBOMQuantity * (ScrapFactor)) * InventoryBOMInventoryID.InventoryQuantity * -1)"),
                                                                                    GroupOperator.And(theCriteria)), Double)

    End Sub

End Class
