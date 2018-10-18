Imports SuperiorPackGroup.SPGTableAdapters
Imports System.Text
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DXDAL.SPGData
Imports System.Collections.ObjectModel

<System.ComponentModel.DataObject()>
Public Class InventoryBLL

    Private m_InventoryTableAdapter As InventoryTableAdapter = Nothing
    Private ReadOnly changes As New List(Of Change)()

    Public ReadOnly Property Adapter() As InventoryTableAdapter

        Get
            If m_InventoryTableAdapter Is Nothing Then
                m_InventoryTableAdapter = New InventoryTableAdapter()
                m_InventoryTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return m_InventoryTableAdapter
        End Get

    End Property

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function GetInventoryView(ByVal fromDate As Nullable(Of Date), ByVal toDate As Nullable(Of Date), ByVal customer As Nullable(Of Integer),
            ByVal item As Nullable(Of Integer), ByVal Lot As String) As SPG.InventoryDataTable

        Return Adapter.GetInventoryView(fromDate, toDate, customer, item, Lot)

    End Function

    Private Sub UpdateAuditTrail()

        Dim builder As New StringBuilder(String.Empty)

        For Each update As Change In changes
            builder.Append(String.Format("{0}:{1}({2}); ", update.PropertyName, update.PrevValue, update.NewValue))
        Next

        If (builder.Length > 2) Then
            builder.Length = (builder.Length - 2)
            AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(changes(0).NewValue, Integer), "Inventory", builder.ToString)
        End If

        changes.Clear()

    End Sub

    'Private Sub UpdateAuditTrail(ByVal ModifiedRecord As SPG.InventoryRow, ByVal originalRecord As Object())

    '    Dim builder As New StringBuilder(String.Empty)
    '    Dim recordFields As Integer = (ModifiedRecord.ItemArray.Length - 1)
    '    Dim i As Integer = 0
    '    Do While (i <= recordFields)
    '        Try
    '            If IsDBNull(originalRecord(i)) Then
    '                If Not IsDBNull(ModifiedRecord.Item(i)) Then
    '                    builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, "NULL", ModifiedRecord.Item(i)))
    '                End If
    '            ElseIf Information.IsDBNull(ModifiedRecord.Item(i)) Then
    '                If Not Information.IsDBNull(originalRecord(i)) Then
    '                    builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, originalRecord(i), "NULL"))
    '                End If
    '            ElseIf ModifiedRecord.Item(i) IsNot originalRecord(i) Then
    '                builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, originalRecord(i), ModifiedRecord.Item(i)))
    '            End If
    '        Catch
    '        End Try
    '        i += 1
    '    Loop
    '    If (builder.Length > 2) Then
    '        builder.Length = (builder.Length - 2)
    '        AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(ModifiedRecord.Item(0), Integer), "Inventory", builder.ToString)
    '    End If

    'End Sub

    Public Shared Function GetNewInventoryID() As Integer

        Dim conn As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.UserConnectionString)
        Dim myCommand As New SqlClient.SqlCommand("dbo.spNewIDSafe", conn)
        Dim myNewID As New SqlClient.SqlParameter("@nRetVal", SqlDbType.Int)
        myCommand.CommandType = CommandType.StoredProcedure
        myNewID.Direction = ParameterDirection.Output
        myCommand.Parameters.AddWithValue("@cName", "tblInventory")
        myCommand.Parameters.AddWithValue("@cPkField", "InventoryID")
        myCommand.Parameters.Add(myNewID)

        conn.Open()
        myCommand.ExecuteNonQuery()

        Return CType(myNewID.Value, Integer)

    End Function

    Private Sub SetField(propertyName As String, oldValue As Object, newValue As Object, ByVal production As Inventory)

        If (oldValue IsNot Nothing Or newValue IsNot Nothing) AndAlso
            ((oldValue IsNot Nothing And newValue Is Nothing) OrElse (newValue IsNot Nothing And oldValue Is Nothing) OrElse oldValue.ToString <> newValue.ToString) Then
            production.SetMemberValue(propertyName, newValue)
            Dim change As New Change() With {.PropertyName = propertyName, .PrevValue = If(oldValue Is Nothing, "<NULL>", oldValue.ToString()), .NewValue = If(newValue Is Nothing, "<NULL>", newValue.ToString())}
            changes.Add(change)
        End If

    End Sub

    Private Sub SetInventoryFields(ByVal session As Session, ByVal inventoryDate As Date, ByVal item As Integer, ByVal quantity As Integer, ByVal pallets As Nullable(Of Single), ByVal po As String, ByVal lot As String, ByVal shift As Integer?, ByVal pallet As Integer?,
                                   ByVal expirationDate As Date?, ByVal locationID As Integer, ByVal note As String, ByVal production As Inventory)

        SetField(Inventory.Fields.InventoryDate.PropertyName, production.InventoryDate, inventoryDate, production)
        SetField(Inventory.Fields.InventoryItemID.PropertyName, production.InventoryItemID, session.GetObjectByKey(Of Items)(item), production)
        SetField(Inventory.Fields.InventoryQuantity.PropertyName, production.InventoryQuantity, quantity, production)
        SetField(Inventory.Fields.InventoryPallets.PropertyName, production.InventoryPallets, pallets.Value, production)
        SetField(Inventory.Fields.PO.PropertyName, production.PO, po, production)
        SetField(Inventory.Fields.Lot.PropertyName, production.Lot, lot, production)
        SetField(Inventory.Fields.Shift.PropertyName, production.Shift, If(shift.HasValue, If(shift.Value > 0, session.GetObjectByKey(Of Shifts)(shift.Value), Nothing), Nothing), production)
        SetField(Inventory.Fields.Pallet.PropertyName, production.Pallet, If(pallet.HasValue, If(pallet.Value > 0, pallet.Value, Nothing), Nothing), production)
        SetField(Inventory.Fields.ExpirationDate.PropertyName, production.ExpirationDate, If(expirationDate.HasValue, expirationDate.Value, Nothing), production)
        SetField(Inventory.Fields.ProductionLocation.PropertyName, production.ProductionLocation, session.GetObjectByKey(Of Locations)(locationID), production)
        SetField(Inventory.Fields.Note.PropertyName, production.Note, note, production)

    End Sub

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, True)>
    Public Function UpdateInventory(ByVal session As Session, ByVal inventoryID As Integer, ByVal inventoryDate As Date, ByVal item As Integer, ByVal quantity As Integer, ByVal pallets As Nullable(Of Single), ByVal po As String, ByVal lot As String, ByVal shift As Integer?,
                                    ByVal pallet As Integer?, ByVal expirationDate As Date?, ByVal locationID As Integer, ByVal note As String) As Inventory

        'Dim inventory As SPG.InventoryDataTable = Adapter.GetInventoryByID(inventoryID)

        'If inventory.Count = 0 Then
        Dim change As Change
        Dim production As Inventory = session.GetObjectByKey(Of Inventory)(inventoryID)

        If production Is Nothing Then
            'It is a new Production Record
            change = New Change() With {.PropertyName = Inventory.Fields.InventoryID.PropertyName, .PrevValue = "<NULL>", .NewValue = inventoryID.ToString}
            changes.Add(change)
            Return InsertInventory(session, inventoryID, inventoryDate, item, quantity, pallets, po, lot, shift, pallet, expirationDate, locationID, note)
        End If

        'Dim inventoryRecord As SPG.InventoryRow = inventory(0)
        Dim originalQuantity, newQuantity As Integer
        Dim itemChanged As Boolean

        'Dim originalRecord As Object() = inventoryRecord.ItemArray

        'inventoryRecord.InventoryDate = CDate(Format(inventoryDate, "D"))
        Dim originalItem As Integer = production.InventoryItemID.ItemID
        If originalItem <> item Then
            itemChanged = True
        Else
            itemChanged = False
        End If
        'inventoryRecord.InventoryItemID = item
        originalQuantity = production.InventoryQuantity
        newQuantity = production.InventoryQuantity - quantity
        'inventoryRecord.InventoryQuantity = quantity
        'inventoryRecord.InventoryPallets = pallets.Value
        'inventoryRecord.PO = po
        'inventoryRecord.Lot = lot
        'If shift.HasValue AndAlso shift.Value > 0 Then
        '    inventoryRecord.Shift = shift.Value
        'Else
        '    inventoryRecord.SetShiftNull()
        'End If
        'If pallet.HasValue AndAlso pallet.Value > 0 Then
        '    inventoryRecord.Pallet = pallet.Value
        'Else
        '    inventoryRecord.SetPalletNull()
        'End If
        'If expirationDate.HasValue Then
        '    inventoryRecord.ExpirationDate = expirationDate.Value
        'Else
        '    inventoryRecord.SetExpirationDateNull()
        'End If

        change = New Change() With {.PropertyName = Inventory.Fields.InventoryID.PropertyName, .PrevValue = production.InventoryID.ToString, .NewValue = production.InventoryID.ToString}
        changes.Add(change)
        SetInventoryFields(session, inventoryDate, item, quantity, pallets, po, lot, shift, pallet, expirationDate, locationID, note, production)

        'If Not IsNothing(originalRecord) Then
        '    Me.UpdateAuditTrail(inventoryRecord, originalRecord)
        'End If

        Try
            production.Save()
        Catch ex As Exception
            Return Nothing
        End Try

        UpdateAuditTrail()

        'Dim rowsAffected As Integer = Adapter.Update(inventoryRecord)

        'If rowsAffected = 1 Then
        Dim items As ItemsBLL = New ItemsBLL
        'Dim inventoryBOM As InventoryBOMsBLL = New InventoryBOMsBLL
        If itemChanged = True Then
            items.UpdateStock(session, originalItem, inventoryID, originalQuantity * -1, True, locationID)
            InventoryBOMsBLL.DeleteInventoryBOMByInventoryID(session, inventoryID)
            InventoryBOMsBLL.AddInventoryBOMByItemID(session, item, production)
            items.UpdateStock(session, item, quantity, True, locationID)
        Else
            If newQuantity <> 0 Then    'there was a change in the quantity
                items.UpdateStock(session, item, inventoryID, newQuantity * -1, True, locationID)
            End If
        End If
        'End If

        'Return rowsAffected = 1
        Return production

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, True)>
    Public Function InsertInventory(ByVal session As Session, ByVal inventoryID As Integer, ByVal inventoryDate As Nullable(Of Date), ByVal item As Nullable(Of Integer), ByVal quantity As Nullable(Of Integer), ByVal pallets As Nullable(Of Single), ByVal po As String,
                                    ByVal lot As String, ByVal shift As Integer?, ByVal pallet As Integer?, ByVal expirationDate As Date?, ByVal locationID As Integer, ByVal note As String) As Inventory

        'Dim inventory As SPG.InventoryDataTable = New SPG.InventoryDataTable
        'Dim inventoryRecord As SPG.InventoryRow = inventory.NewInventoryRow()

        'inventoryRecord.InventoryID = inventoryID

        Dim production As Inventory = New Inventory(session) With {.InventoryID = inventoryID, .InventoryItemID = session.GetObjectByKey(Of Items)(item.Value)}

        'inventoryRecord.InventoryDate = CDate(Format(inventoryDate, "D"))
        'inventoryRecord.InventoryItemID = item.Value
        'inventoryRecord.InventoryQuantity = quantity.Value
        'inventoryRecord.InventoryPallets = pallets.Value
        'inventoryRecord.PO = po
        'inventoryRecord.Lot = lot
        'If shift.HasValue AndAlso shift.Value > 0 Then
        '    inventoryRecord.Shift = shift.Value
        'Else
        '    inventoryRecord.SetShiftNull()
        'End If
        If pallet.HasValue = False OrElse pallet.Value <= 0 Then
            '    inventoryRecord.Pallet = pallet.Value
            'Else
            pallet = GetNewPalletNumber(session, CDate(Format(inventoryDate, "D")), item.Value, shift.Value)
        End If
        'If expirationDate.HasValue() Then
        '    inventoryRecord.ExpirationDate = expirationDate.Value
        'Else
        '    inventoryRecord.SetExpirationDateNull()
        'End If
        SetInventoryFields(session, inventoryDate.Value, item.Value, quantity.Value, pallets, po, lot, shift, pallet, expirationDate, locationID, note, production)
        production.strEnteredBy = My.Settings.UserName
        production.dtmEnteredOn = Now

        Try
            production.Save()
        Catch ex As Exception
            Return Nothing
        End Try

        'inventory.AddInventoryRow(inventoryRecord)
        'Dim rowsAffected As Integer = Adapter.Update(inventory)

        'If rowsAffected = 1 Then
        Dim items As ItemsBLL = New ItemsBLL
        items.UpdateStock(session, item.Value, quantity.Value, True, locationID)
        Dim inventoryBOM As InventoryBOMsBLL = New InventoryBOMsBLL
        InventoryBOMsBLL.AddInventoryBOMByItemID(session, item.Value, production)
        'End If

        'Return rowsAffected = 1

        Return production

    End Function

    Public Shared Function GetInventoryRecord(ByVal session As Session, ByVal inventoryID As Integer, Optional getFromDB As Boolean = False) As Inventory

        Return session.GetObjectByKey(Of Inventory)(inventoryID, getFromDB)

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function GetInventoryByID(ByVal inventoryID As Integer) As SPG.InventoryDataTable

        Return Adapter.GetInventoryByID(inventoryID)

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)>
    Public Function GetInventoryByItemID(ByVal itemID As Integer) As SPG.InventoryDataTable

        Return Adapter.GetInventoryByItemID(itemID)

    End Function

    Private Shared Sub DeleteInventoryConsumption(ByVal productionRecord As Inventory, ByVal inventorySession As Session)

        Dim consumption As BomConsumption
        Dim inventoryOnHand As LocationInventory

        Using consumptions As XPCollection(Of BomConsumption) = productionRecord.InventoryConsumption
            For i As Integer = consumptions.Count - 1 To 0 Step -1
                consumption = consumptions(i)
                inventoryOnHand = inventorySession.FindObject(Of LocationInventory)(New BinaryOperator(LocationInventory.Fields.LocationInventoryItem.ItemID.PropertyName, consumption.RawMatID.ItemID, BinaryOperatorType.Equal) And
                                                                                    New BinaryOperator(LocationInventory.Fields.Location.Oid, UsersBLL.GetUsersLocalLocation(inventorySession, My.Settings.UserName).Oid, BinaryOperatorType.Equal))
                inventoryOnHand.QuantityOnHand += CSng(consumption.QuantityUsed + consumption.ScrapFactorUsed)
                inventoryOnHand.Save()
                consumption.Delete()
            Next i
        End Using

    End Sub

    Private Shared Sub DeleteProductionProjectDetails(ByVal session As Session, ByVal productionRecord As Inventory)

        'Using ProjectDetails As XPCollection(Of ProductionProjectDetails) = productionRecord.ProductionProject
        '    For i As Integer = ProjectDetails.Count - 1 To 0 Step -1
        '        ProjectDetails(i).Delete()
        '    Next i
        'End Using

        session.Delete(productionRecord.ProductionProject)

    End Sub

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, True)>
    Public Shared Function DeleteInventory(ByVal session As Session, ByVal id As Integer) As Boolean

        'Dim inventory As SPG.InventoryDataTable = Adapter.GetInventoryByID(id)
        'Dim rowsAffected As Integer = 0
        'Dim inventorySession As Session = session
        session.DropIdentityMap()

        Dim item, quantity, locationID As Integer
        Dim production As Inventory = session.GetObjectByKey(Of Inventory)(id)

        'If inventory.Count = 1 Then
        If production Is Nothing Then
            Return False
        ElseIf production.Shipment IsNot Nothing Then
            MessageBox.Show("The selected record can't be deleted, it was already shipped.")
            Return True
        End If

        'Dim inventoryRecord As SPG.InventoryRow = CType(Inventory.Rows(0), SPG.InventoryRow)
        Dim inventoryBOM As InventoryBOMsBLL = New InventoryBOMsBLL
        item = production.InventoryItemID.ItemID
        quantity = production.InventoryQuantity
        locationID = production.ProductionLocation.Oid
        InventoryBOMsBLL.DeleteInventoryBOMByInventoryID(session, id)
        DeleteInventoryConsumption(production, session)
        DeleteProductionProjectDetails(session, production)
        'rowsAffected = Adapter.Delete(id, inventoryRecord.ts)
        Try
            production.Delete()

            'If rowsAffected = 1 Then
            'If production.IsDeleted Then
            Dim items As ItemsBLL = New ItemsBLL
            items.UpdateStock(session, item, quantity * -1, True, locationID)
            'End If

            'Return true if precisely one row was deleted, otherwise return false.
            'Return rowsAffected = 1

            'Return production.IsDeleted
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Shared Function GetNewPalletNumber(ByVal session As Session, ByVal inventoryDate As Date, ByVal itemID As Integer, ByVal shift As Integer?) As Integer

        Dim value As Integer?

        Dim filter As New CriteriaOperatorCollection
        filter.Add(New BinaryOperator("InventoryDate", inventoryDate.Date, BinaryOperatorType.GreaterOrEqual))
        filter.Add(New BinaryOperator("InventoryDate", DateAdd("d", 1, inventoryDate.Date), BinaryOperatorType.Less))
        filter.Add(New BinaryOperator("InventoryItemID", itemID, BinaryOperatorType.Equal))
        If shift.HasValue Then
            filter.Add(New BinaryOperator("Shift", shift, BinaryOperatorType.Equal))
        Else
            Return 1
        End If


        value = CType(session.Evaluate(Of Inventory)(New AggregateOperand("", "Pallet", Aggregate.Max), New GroupOperator(GroupOperatorType.And, filter)), Integer?)

        If value.HasValue Then
            Return value.Value + 1
        Else
            Return 1
        End If

    End Function

    Public Shared Function GetLPNQuantity(ByVal session As Session, ByVal LPNNumber As Integer, ByVal customerID As Integer, ByVal inventoryDate As Date, ByVal currentRecord As Inventory) As Integer?

        Dim filter As New CriteriaOperatorCollection
        filter.Add(New BinaryOperator("InventoryDate", inventoryDate, BinaryOperatorType.Equal))
        filter.Add(New BinaryOperator(Inventory.Fields.InventoryItemID.ItemCustomerID.CustomerID.PropertyName, customerID, BinaryOperatorType.Equal))
        filter.Add(New BinaryOperator("LPNNumber", LPNNumber, BinaryOperatorType.Equal))
        filter.Add(New BinaryOperator(Inventory.Fields.InventoryID.PropertyName, currentRecord.InventoryID, BinaryOperatorType.NotEqual))

        Dim LPNQuantity As Integer? =
            CType(session.Evaluate(Of Inventory)(New AggregateOperand("", "InventoryQuantity", Aggregate.Sum), New GroupOperator(GroupOperatorType.And, filter)), Integer?)

        If LPNQuantity.HasValue Then
            LPNQuantity += currentRecord.InventoryQuantity
        Else
            LPNQuantity = currentRecord.InventoryQuantity
        End If


        If LPNQuantity.HasValue Then
            Return LPNQuantity.Value
        Else
            Return 0
        End If

    End Function

    Public Shared Function IsMultiLPN(ByVal session As Session, ByVal LPNNumber As Integer, ByVal customerID As Integer, ByVal inventoryDate As Date) As Boolean

        Dim filter As New CriteriaOperatorCollection
        filter.Add(New BinaryOperator("InventoryDate", inventoryDate, BinaryOperatorType.Equal))
        filter.Add(New BinaryOperator(Inventory.Fields.InventoryItemID.ItemCustomerID.CustomerID.PropertyName, customerID, BinaryOperatorType.Equal))
        filter.Add(New BinaryOperator("LPNNumber", LPNNumber, BinaryOperatorType.Equal))

        Dim LPNCount As Integer? =
             CType(session.Evaluate(Of Inventory)(New AggregateOperand("", "InventoryQuantity", Aggregate.Count), New GroupOperator(GroupOperatorType.And, filter)), Integer?)

        If LPNCount.HasValue AndAlso LPNCount.Value > 1 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Shared Function GetLPNInventoryRecords(ByVal session As Session, ByVal LPNNumber As Integer, ByVal customerID As Integer, ByVal inventoryDate As Date) As XPCollection(Of Inventory)

        Return New XPCollection(Of Inventory)(session, New BinaryOperator("InventoryDate", inventoryDate, BinaryOperatorType.Equal) And
                                                                    New BinaryOperator(Inventory.Fields.InventoryItemID.ItemCustomerID.CustomerID.PropertyName, customerID, BinaryOperatorType.Equal) And
                                                                    New BinaryOperator("LPNNumber", LPNNumber, BinaryOperatorType.Equal))

    End Function

    Public Shared Function GetLPNInventoryRecords(ByVal session As Session, ByVal fullLPNNumber As String, ByVal customerID As Integer) As ICollection(Of Inventory)

        'Dim LPNNumber As Integer = Integer.Parse(fullLPNNumber.Replace(CustomersBLL.GetLPNPrefix(customerID), ""))

        Dim result As ICollection(Of Inventory) = New Collection(Of Inventory)
        result = New XPCollection(Of Inventory)(session,
                                                                                  New BinaryOperator(Inventory.Fields.InventoryItemID.ItemCustomerID.CustomerID.PropertyName, customerID, BinaryOperatorType.Equal) And
                                                                                  New BinaryOperator("FullLPNNumber", fullLPNNumber, BinaryOperatorType.Equal))

        If result.Count = 0 Then
            'If customerID = 7 Then
            '    Dim locationInventorys As XPCollection(Of LocationInventoryByLot) = New XPCollection(Of LocationInventoryByLot)(session,
            '                                                          New BinaryOperator(LocationInventoryByLot.Fields.LPNNumber.PropertyName, Integer.Parse(fullLPNNumber.Replace(CustomersBLL.GetLPNPrefix(customerID), "")), BinaryOperatorType.Equal))
            '    If locationInventorys.Count < 1 Then Return result
            '    Dim locationInventory As LocationInventoryByLot = locationInventorys(0)
            '    Dim convertToInventory As Inventory = New Inventory(session) With {.InventoryItemID = locationInventory.LocationInventoryItem, .InventoryQuantity = CInt(locationInventory.QuantityOnHand),
            '                                                                .Lot = locationInventory.LocationInventoryLot, .FullLPNNumber = fullLPNNumber, .ExpirationDate = locationInventory.ExpirationDate}
            '    result = New Collection(Of Inventory)
            '    result.Add(convertToInventory)
            'Else
            result = New XPCollection(Of Inventory)(session, New BinaryOperator(Inventory.Fields.InventoryItemID.ItemCustomerID.CustomerID.PropertyName, customerID, BinaryOperatorType.Equal) And
                                                                      New BinaryOperator("LPNNumber", Integer.Parse(fullLPNNumber.Replace(CustomersBLL.GetLPNPrefix(customerID), "")), BinaryOperatorType.Equal))
            'End If
        End If

        Return result

    End Function

End Class
