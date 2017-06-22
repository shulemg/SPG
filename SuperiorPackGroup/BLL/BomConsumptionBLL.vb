Imports DXDAL.SPGData
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo

Public Class BomConsumptionBLL

    Public Shared Function UpdateBomConsumption(ByVal mySession As Session, ByVal rawMatID As Items, ByVal inventoryID As Inventory, ByVal quantityUsed As Single, ByVal scrapFactorUsed As Single) As Single

        Dim bom As BomConsumption
        Dim originalQuantity As Single = 0
        Dim originalScrap As Single = 0
        Dim consumptionCriteria As CriteriaOperatorCollection = New CriteriaOperatorCollection()

        consumptionCriteria.Add(New BinaryOperator(BomConsumption.Fields.RawMatID.ItemID.PropertyName, rawMatID.ItemID, BinaryOperatorType.Equal))
        consumptionCriteria.Add(New BinaryOperator(BomConsumption.Fields.InventoryID.InventoryID.PropertyName, inventoryID.InventoryID, BinaryOperatorType.Equal))

        bom = mySession.GetObjectByKey(Of BomConsumption)(mySession.Evaluate(Of BomConsumption)(CriteriaOperator.Parse("Oid"), New GroupOperator(GroupOperatorType.And, consumptionCriteria)))

        If bom Is Nothing Then
            bom = New BomConsumption(mySession)
            bom.RawMatID = rawMatID
            bom.InventoryID = inventoryID
        Else
            originalQuantity = bom.QuantityUsed
            originalScrap = CSng(bom.ScrapFactorUsed)
        End If

        bom.QuantityUsed = quantityUsed
        bom.ScrapFactorUsed = scrapFactorUsed

        bom.Save()

        Return CType(bom.QuantityUsed - originalQuantity + bom.ScrapFactorUsed - originalScrap, Single)

    End Function

End Class
