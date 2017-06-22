Imports DXDAL.SPGData
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Public Class CurrentRMInventoryReport


    Private Shared ReadOnly CurrentRMInventoryDictionary As Dictionary(Of VRMItemKey, VRMItem) = New Dictionary(Of VRMItemKey, VRMItem)()

    Private Shared Sub AddIGStockAsRM(ByVal ReportSession As Session, ByVal OnlyAssignedCustomers As Boolean)

        Dim igCollection As XPCollection(Of LocationInventory)
        Dim theCriteria As New CriteriaOperatorCollection
        Dim VRMKey As New VRMItemKey()

        theCriteria.Add(New BinaryOperator(LocationInventory.Fields.LocationInventoryItem.ItemType.PropertyName, "IG", BinaryOperatorType.Equal))

        If OnlyAssignedCustomers Then
            theCriteria.Add(New InOperator(LocationInventory.Fields.LocationInventoryItem.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomerIDs(ReportSession)))
        End If

        igCollection = New XPCollection(Of LocationInventory)(ReportSession, New GroupOperator(GroupOperatorType.And, theCriteria))

        For Each item As LocationInventory In igCollection
            For Each bom As BOMs In item.LocationInventoryItem.ItemBOM
                VRMKey.ItemCode = bom.BOMRawMatID.ItemCode
                VRMKey.Location = item.Location.LocationCode

                If CurrentRMInventoryDictionary.ContainsKey(VRMKey) Then
                    CurrentRMInventoryDictionary(VRMKey).QuantityOnHand += Convert.ToSingle(item.QuantityOnHand * (bom.BOMQuantity + (bom.BOMQuantity * (bom.ScrapFactor / 100))))
                Else
                    If bom.BOMRawMatID.ItemType = "RM" Then
                        CurrentRMInventoryDictionary.Add(VRMKey, New VRMItem() With {.Item = ReportSession.FindObject(Of LocationInventory)(
                                                         New BinaryOperator(LocationInventory.Fields.LocationInventoryItem.PropertyName, bom.BOMRawMatID, BinaryOperatorType.Equal) And
                                                         New BinaryOperator(LocationInventory.Fields.Location.PropertyName, item.Location, BinaryOperatorType.Equal))})
                        CurrentRMInventoryDictionary(VRMKey).QuantityOnHand += Convert.ToSingle(item.QuantityOnHand * (bom.BOMQuantity + (bom.BOMQuantity * (bom.ScrapFactor / 100))))
                    Else
                        For Each IGbom As BOMs In bom.BOMRawMatID.ItemBOM
                            VRMKey.ItemCode = IGbom.BOMRawMatID.ItemCode
                            If CurrentRMInventoryDictionary.ContainsKey(VRMKey) Then
                                CurrentRMInventoryDictionary(VRMKey).QuantityOnHand += Convert.ToSingle((item.QuantityOnHand * (bom.BOMQuantity + (bom.BOMQuantity * (bom.ScrapFactor / 100)))) *
                                                                                                                            (IGbom.BOMQuantity + (IGbom.BOMQuantity * (IGbom.ScrapFactor / 100))))
                            Else
                                If IGbom.BOMRawMatID.ItemType = "RM" Then
                                    CurrentRMInventoryDictionary.Add(VRMKey, New VRMItem() With {.Item = ReportSession.FindObject(Of LocationInventory)(
                                                                     New BinaryOperator(LocationInventory.Fields.LocationInventoryItem.PropertyName, IGbom.BOMRawMatID, BinaryOperatorType.Equal) And
                                                                     New BinaryOperator(LocationInventory.Fields.Location.PropertyName, item.Location, BinaryOperatorType.Equal))})
                                    CurrentRMInventoryDictionary(VRMKey).QuantityOnHand += Convert.ToSingle((item.QuantityOnHand * (bom.BOMQuantity + (bom.BOMQuantity * (bom.ScrapFactor / 100)))) *
                                                                                                                                (IGbom.BOMQuantity + (IGbom.BOMQuantity * (IGbom.ScrapFactor / 100))))
                                End If
                            End If
                        Next
                    End If

                End If
            Next

            For Each pool As PoolBom In item.LocationInventoryItem.ItemPoolBom
                VRMKey.ItemCode = pool.ItemPoolID.PoolCode
                VRMKey.Location = item.Location.LocationCode


                If CurrentRMInventoryDictionary.ContainsKey(VRMKey) Then
                    'this should always be true, the else is not needed.
                    CurrentRMInventoryDictionary(VRMKey).QuantityOnHand += Convert.ToSingle(item.QuantityOnHand * (pool.PoolBomQuantity + (pool.PoolBomQuantity * (pool.ScrapFactor / 100))))
                    'Else
                    '    CurrentRMInventoryDictionary.Add(VRMKey, New VRMItem() With {.Customer = pool.ItemPoolID.PoolCustomerID, .ItemCode = pool.ItemPoolID.PoolCode, .ItemDescription = pool.ItemPoolID.PoolDescription,
                    '                                                                                   .QuantityOnHand = CSng(pool.ItemPoolID.QuantityOnHand), .ItemId = pool.ItemPoolID.Oid})
                    '    CurrentRMInventoryDictionary(VRMKey).QuantityOnHand += Convert.ToSingle(item.QuantityOnHand * (pool.PoolBomQuantity + (pool.PoolBomQuantity * (pool.ScrapFactor / 100))))
                End If
            Next
        Next

    End Sub

    Private Shared Sub AddRMItems(ByVal ReportSession As Session, ByVal OnlyAssignedCustomers As Boolean)

        Dim itemCollection As XPCollection(Of LocationInventory)
        Dim theCriteria As New CriteriaOperatorCollection
        Dim VRMKey As New VRMItemKey

        theCriteria.Add(New BinaryOperator(LocationInventory.Fields.LocationInventoryItem.ItemType.PropertyName, "RM", BinaryOperatorType.Equal))

        If OnlyAssignedCustomers Then
            theCriteria.Add(New InOperator(LocationInventory.Fields.LocationInventoryItem.ItemCustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomerIDs(ReportSession)))
        End If

        itemCollection = New XPCollection(Of LocationInventory)(ReportSession, New GroupOperator(GroupOperatorType.And, theCriteria))

        For Each item As LocationInventory In itemCollection
            VRMKey.ItemCode = item.LocationInventoryItem.ItemCode
            VRMKey.Location = item.Location.LocationCode

            If CurrentRMInventoryDictionary.ContainsKey(VRMKey) Then
                CurrentRMInventoryDictionary(VRMKey).QuantityOnHand += item.QuantityOnHand
            Else
                CurrentRMInventoryDictionary.Add(VRMKey, New VRMItem() With {.Item = item})
            End If
        Next

    End Sub

    Private Shared Sub AddPoolItems(ByVal ReportSession As Session, ByVal OnlyAssignedCustomers As Boolean)

        Dim poolCollection As XPCollection(Of ItemPool)
        Dim VRMKey As New VRMItemKey
        Dim Quantity As Single

        If OnlyAssignedCustomers Then
            poolCollection = New XPCollection(Of ItemPool)(ReportSession, New InOperator(ItemPool.Fields.PoolCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomerIDs(ReportSession)))
        Else
            poolCollection = New XPCollection(Of ItemPool)(ReportSession)
        End If

        For Each pool As ItemPool In poolCollection
            For Each location As Locations In New XPCollection(Of Locations)(ReportSession)
                VRMKey.Location = location.LocationCode

                For Each poolDetail As ItemPoolDetails In pool.Details
                    VRMKey.ItemCode = poolDetail.ItemID.ItemCode

                    If CurrentRMInventoryDictionary.ContainsKey(VRMKey) Then
                        Quantity = CSng(Quantity + (CurrentRMInventoryDictionary(VRMKey).QuantityOnHand * poolDetail.ItemPoolRatio))
                        CurrentRMInventoryDictionary.Remove(VRMKey)
                    End If
                Next

                VRMKey.ItemCode = pool.PoolCode

                If CurrentRMInventoryDictionary.ContainsKey(VRMKey) Then
                    'CurrentRMInventoryDictionary(VRMKey).QuantityOnHand = CSng(CurrentRMInventoryDictionary(pool.PoolCode).QuantityOnHand + pool.QuantityOnHand)
                Else
                    CurrentRMInventoryDictionary.Add(VRMKey, New VRMItem() With {.Customer = pool.PoolCustomerID, .ItemCode = pool.PoolCode, .ItemDescription = pool.PoolDescription, .QuantityOnHand = Quantity, .ItemId = pool.Oid})
                End If
                Quantity = 0
            Next
        Next

    End Sub

    Public Shared Function GetCurrentRmInventoryReport(ByVal onlyAssignedCustomers As Boolean) As List(Of VRMItem)

        Dim rmInvSession As Session = New Session(SPGDataLayer)
        Dim CurrentRMInventoryList As List(Of VRMItem) = New List(Of VRMItem)()
        CurrentRMInventoryDictionary.Clear()
        rmInvSession.DropIdentityMap()

        AddRMItems(rmInvSession, onlyAssignedCustomers)
        AddPoolItems(rmInvSession, onlyAssignedCustomers)
        AddIGStockAsRM(rmInvSession, onlyAssignedCustomers)

        For Each item As KeyValuePair(Of VRMItemKey, VRMItem) In CurrentRMInventoryDictionary
            CurrentRMInventoryList.Add(item.Value)
        Next

        Return CurrentRMInventoryList

    End Function

    Public Class VRMItem

        Private _Item As LocationInventory
        Private _Inactive As Boolean

        Public Property Customer As Customers

        Public Property Inactive As Boolean
            Get
                If _Inactive = Nothing Then
                    Return False
                Else
                    Return _Inactive
                End If
            End Get
            Set(value As Boolean)
                _Inactive = value
            End Set
        End Property

        Public Property Item As LocationInventory
            Get
                Return _Item
            End Get
            Set(value As LocationInventory)
                If value IsNot Nothing Then
                    Customer = value.LocationInventoryItem.ItemCustomerID
                    Inactive = value.LocationInventoryItem.Inactive
                    ItemCode = value.LocationInventoryItem.ItemCode
                    ItemDescription = value.LocationInventoryItem.ItemDescription
                    ItemId = value.LocationInventoryItem.ItemID
                    QuantityOnHand = value.QuantityOnHand
                    Location = value.Location.LocationCode
                End If
                _Item = value
            End Set
        End Property

        Public Property ItemCode As String
        Public Property ItemDescription As String
        Public Property ItemId As Integer
        Public Property Location As String
        Public Property QuantityOnHand As Single

    End Class

    Public Structure VRMItemKey
        Public Property ItemCode As String
        Public Property Location As String
    End Structure
End Class
