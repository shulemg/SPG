Imports DXDAL.SPGData
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Public Class LocationInventoryBLL

    Public Shared Sub UpdateStock(ByVal session As Session, ByVal ItemID As Integer, ByVal LocationID As Integer, ByVal Quantity As Single, Optional ByVal lot As String = "", Optional ByVal LPNNumber As Integer? = Nothing, Optional ByVal ExpirationDate As Date? = Nothing)

        Dim inventory As LocationInventory = session.FindObject(Of LocationInventory)(New BinaryOperator(LocationInventory.Fields.LocationInventoryItem.ItemID.PropertyName, ItemID, BinaryOperatorType.Equal) And
                                                                                                     New BinaryOperator(LocationInventory.Fields.Location.Oid.PropertyName, LocationID, BinaryOperatorType.Equal))

        If inventory Is Nothing Then
            inventory = New LocationInventory(session)
            inventory.LocationInventoryItem = session.GetObjectByKey(Of Items)(ItemID)
            inventory.Location = session.GetObjectByKey(Of Locations)(LocationID)
            inventory.QuantityOnHand = Quantity
        Else
            inventory.QuantityOnHand += Quantity
        End If

        inventory.Save()

        If (IsNothing(lot) OrElse lot = "") AndAlso (IsNothing(LPNNumber) OrElse LPNNumber = 0) Then Return

        Dim inventoryByLot As LocationInventoryByLot = session.FindObject(Of LocationInventoryByLot)(New BinaryOperator(LocationInventoryByLot.Fields.LocationInventoryItem.ItemID.PropertyName, ItemID, BinaryOperatorType.Equal) And
                                                                                                     New BinaryOperator(LocationInventoryByLot.Fields.Location.Oid.PropertyName, LocationID, BinaryOperatorType.Equal) And
                                                                                                     New BinaryOperator(LocationInventoryByLot.Fields.LocationInventoryLot, lot, BinaryOperatorType.Equal) And
                                                                                                     New BinaryOperator(LocationInventoryByLot.Fields.LPNNumber, If(LPNNumber, 0), BinaryOperatorType.Equal))

        If inventoryByLot Is Nothing Then
            If Quantity >= 0 Then
                inventoryByLot = New LocationInventoryByLot(session)
                inventoryByLot.LocationInventoryItem = session.GetObjectByKey(Of Items)(ItemID)
                inventoryByLot.Location = session.GetObjectByKey(Of Locations)(LocationID)
                inventoryByLot.LocationInventoryLot = lot
                inventoryByLot.LPNNumber = LPNNumber
                inventoryByLot.QuantityOnHand = Quantity
                If ExpirationDate IsNot Nothing Then inventoryByLot.ExpirationDate = ExpirationDate
            Else
                Exit Sub
            End If
        Else
            inventoryByLot.QuantityOnHand += Quantity
        End If

        inventoryByLot.Save()

    End Sub

End Class
