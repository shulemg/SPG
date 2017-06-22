Imports System
Imports SuperiorPackGroup.SPGTableAdapters
Imports System.Text
Imports DXDAL.SPGData
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

<System.ComponentModel.DataObject()> _
Public Class ItemsBLL

    Private changes As New List(Of Change)()

    Private m_ItemsTableAdapter As ItemsTableAdapter = Nothing
    Public ReadOnly Property Adapter() As ItemsTableAdapter

        Get
            If m_ItemsTableAdapter IsNot Nothing Then
                Return m_ItemsTableAdapter
            End If

            m_ItemsTableAdapter = New ItemsTableAdapter()
            m_ItemsTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString

            Return m_ItemsTableAdapter
        End Get

    End Property

    Public Shared Function AllowEdit(ByVal session As Session, ByVal itemID As Integer) As Boolean

        Dim item As Items = session.GetObjectByKey(Of Items)(itemID, True)
        If item.Editing Then
            Return False
        Else
            item.Editing = True
            item.Save()
            Return True
        End If

    End Function

    Public Function DeleteIem(ByVal itemID As Integer) As Boolean

        Dim items As SPG.ItemsDataTable = Adapter.GetItemByID(itemID)
        Dim rowsAffected As Integer = 0

        If items.Count = 1 Then
            If New ProductionBLL().GetProductionByItemID(itemID).Count <> 0 OrElse New InventoryBLL().GetInventoryView(Nothing, Nothing, Nothing, itemID, Nothing).Count <> 0 _
                    OrElse New ReceivingDetailsBLL().GetReceivingDetailsByItemID(itemID).Count <> 0 OrElse New ShippingDetailsBLL().GetShippingDetailsByItemID(itemID).Count <> 0 _
                    OrElse New ReturnDetailsBLL().GetReturnDetailsByItemID(itemID).Count <> 0 OrElse New ShippingReturnDetailsBLL().GetShippingReturnDetailsByItemID(itemID).Count <> 0 Then
                If MessageBox.Show("You can't delete this item because there are production, inventory, Receiving's, or Shipping's assigned to it. Do you want ot mark it as inactive?", "Delete Item", MessageBoxButtons.YesNo, _
                                MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    Adapter.InactivateItem(itemID)
                    Return True
                Else
                    Return True
                End If
            End If
            rowsAffected = CInt(New BOMBLL().DeleteBOMByFGItemID(itemID))
            rowsAffected = Adapter.Delete(itemID, items(0).ts)
        End If

        Return Convert.ToBoolean(rowsAffected)

    End Function

    Public Sub EndedEdit(ByVal session As Session, ByVal itemID As Integer)

        Try
            Dim item As Items = session.GetObjectByKey(Of Items)(itemID, True)
            item.Editing = False
            item.Save()
        Catch

        End Try

    End Sub

    ''' <summary>
    ''' Returns a list of all required material with their availability at the specified location.
    ''' </summary>
    ''' <param name="itemID">The item we're looking for</param>
    ''' <param name="localLocation">The location we're looking for</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetAvailabilityByItemID(ByVal itemID As Integer, ByVal localLocation As Integer) As SPG.ItemsDataTable

        Return Adapter.GetAvailabilityByItemID(itemID, localLocation)

    End Function

    ''' <summary>
    ''' Returns a formatted string of the BOM that's not available for the production or an empty string if all material is available.
    ''' When the new amount being used is less than the old amount it will return an empty string.
    ''' </summary>
    ''' <param name="itemID">The item ID of the product we want to produce.</param>
    ''' <param name="quantity">The quantity we want to produce.</param>
    ''' <param name="oldQuantity">The old quantity that was used, when modifying records the message should only give the amount that's needed more than before.</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetAvailabilityByItemID(ByVal session As Session, ByVal itemID As Integer, ByVal quantity As Integer, ByVal oldQuantity As Integer?, ByVal localLocation As Integer) As String

        Dim lUnavailableBOM As New StringBuilder
        Dim availableQuantity As Single
        lUnavailableBOM.Append(String.Empty)

        Dim newQuantity As Integer
        If oldQuantity.HasValue AndAlso oldQuantity.Value > 0 Then
            newQuantity = quantity - oldQuantity.Value
            If newQuantity < 1 Then
                Return lUnavailableBOM.ToString
            End If
        Else
            newQuantity = quantity
        End If

        Using itemBomXPView As New XPView(session, GetType(BOMs))
            Dim criteria As CriteriaOperator = CriteriaOperator.Parse("BOMFiniGoodID = ?", itemID)
            Try
                itemBomXPView.Criteria = criteria
                itemBomXPView.Properties.AddRange(New ViewProperty() {New ViewProperty("RawMaterialCode", SortDirection.Ascending, "[BOMRawMatID].[ItemCode]", False, True),
                                                                      New ViewProperty("RawMaterialID", SortDirection.None, "[BOMRawMatID]", False, True),
                                                                      New ViewProperty("RawMaterialNeeded", SortDirection.None,
                                                                                       CriteriaOperator.Parse("(BOMQuantity + (ScrapFactor / 100 * BOMQuantity)) * ?", newQuantity), False, True)})
                For Each bomRecord As ViewRecord In itemBomXPView
                    availableQuantity = GetQtyOnHandByID(session, CInt(bomRecord("RawMaterialID")), localLocation)

                    If CSng(bomRecord("RawMaterialNeeded")) > availableQuantity Then
                        lUnavailableBOM.Append(String.Format("You need to use {0} of {1}, but you have only {2} on hand.{3}", bomRecord("RawMaterialNeeded"), bomRecord("RawMaterialCode"), availableQuantity, vbCrLf))
                    End If

                Next
            Catch ex As ArgumentException
                Return "There was an error while trying to verify available raw material."
            End Try
        End Using

        Return lUnavailableBOM.ToString

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetCaseGrossWeight(ByVal itemID As Integer) As Double

        Dim weight As Double? = Adapter.GetCaseGrossWeight(itemID)
        If weight.HasValue Then
            Return weight.Value
        Else
            Return 0
        End If

    End Function

    Public Shared Function GetCaseQuantity(ByVal itemID As Integer) As Double

        'Returns units per case
        Try
            Dim item As Items = Session.DefaultSession.GetObjectByKey(Of Items)(itemID, True)
            Return item.intUnitsPerCase * item.intQtyPerUnit
        Catch ex As Exception
            Return 0
        End Try

    End Function

    Public Function GetCasesPerPallet(ByVal itemID As Integer) As Integer

        Return Convert.ToInt32(Adapter.GetCasesPerPallet(itemID))

    End Function

    Public Function GetCustomerIDByItemID(ByVal itemID As Integer) As Integer

        Return Convert.ToInt32(Adapter.GetItemsCustomer(itemID).Rows(0)("CustomerID"))

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Shared Function GetDescriptionByItemID(ByVal itemID As Nullable(Of Integer)) As String

        If Not itemID.HasValue Then
            Return Nothing
        End If

        Try
            Dim item As Items = Session.DefaultSession.GetObjectByKey(Of Items)(itemID.Value, True)
            Return item.ItemDescription
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetItemBYId(ByVal itemID As Integer) As SPG.ItemsDataTable

        Return Adapter.GetItemByID(itemID)

    End Function

    Public Shared Function GetItemByUpc(ByVal upc As String) As Items

        Dim itemCollection As XPCollection(Of Items) = New XPCollection(Of Items)(Session.DefaultSession, New BinaryOperator(Items.Fields.UPC.PropertyName, upc, BinaryOperatorType.Equal))

        If itemCollection.Count > 0 Then
            Return itemCollection(0)
        Else
            Return Nothing
        End If

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Shared Function GetItemCodeAndIDsByTypesAndCustomerID(ByVal customerID As Nullable(Of Integer), ByVal types As String, ByVal universal As Boolean, ByVal DXSession As Session) As XPView

        Dim ItemCodesXPView As New XPView(Session.DefaultSession, GetType(Items))
        ItemCodesXPView.Properties.AddRange(New ViewProperty() {New ViewProperty("ItemID", SortDirection.None, "[ItemID]", False, True),
                                                                New ViewProperty("ItemCode", SortDirection.Ascending, "[ItemCode]", False, True),
                                                                New ViewProperty("ItemCustomerID", SortDirection.None, "[ItemCustomerID]", False, True),
                                                                New ViewProperty("ItemType", SortDirection.None, "[ItemType]", False, True)})
        If universal = True Then
            Dim universalCustomer As Integer = CompanySettingsBLL.GetUniversalCustomer
            If customerID.HasValue Then
                ItemCodesXPView.Criteria = GroupOperator.And(GroupOperator.Or(New BinaryOperator(Items.Fields.ItemCustomerID.PropertyName, customerID.Value, BinaryOperatorType.Equal),
                                                                            New BinaryOperator(Items.Fields.ItemCustomerID.PropertyName, universalCustomer, BinaryOperatorType.Equal),
                                                                            New InOperator(Items.Fields.ItemCustomerID.PropertyName, CustomersBLL.GetRelatedCustomerIDs(CustomersBLL.GetCustomer(customerID.Value, DXSession)))),
                                                                        New InOperator(Items.Fields.ItemType.PropertyName, types.Split("|"c)))
            Else
                ItemCodesXPView.Criteria = New InOperator(Items.Fields.ItemType.PropertyName, types.Split("|"c))
            End If
        Else
            If customerID.HasValue Then
                ItemCodesXPView.Criteria = GroupOperator.And(New BinaryOperator(Items.Fields.ItemCustomerID.PropertyName, customerID.Value, BinaryOperatorType.Equal),
                                                           New InOperator(Items.Fields.ItemType.PropertyName, types.Split("|"c)))
            Else
                ItemCodesXPView.Criteria = New InOperator(Items.Fields.ItemType.PropertyName, types.Split("|"c))
            End If
        End If

        Return ItemCodesXPView

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetItemsByCustomerID(ByVal customerID As Integer) As SPG.ItemsDataTable

        Return Adapter.GetItemsByCustomerID(customerID)

    End Function

    Public Shared Function GetItemsByCustomerIDAndType(ByVal customerID As Integer, ByVal types As String) As XPView

        Dim CustomersItems As New XPView(Session.DefaultSession, GetType(Items))
        CustomersItems.Properties.AddRange(New ViewProperty() {New ViewProperty("ItemCode", SortDirection.Ascending, Items.Fields.ItemCode.PropertyName, False, True),
                                                               New ViewProperty("ItemDescription", SortDirection.None, Items.Fields.ItemDescription.PropertyName, False, True),
                                                               New ViewProperty("QuantityOnHand", SortDirection.None, Items.Fields.TotalQuantityOnHand.PropertyName, False, True),
                                                               New ViewProperty("intUnitsPerPallet", SortDirection.None, Items.Fields.intUnitsPerPallet.PropertyName, False, True)})

        If String.IsNullOrEmpty(types) Then
            CustomersItems.Criteria = New BinaryOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, customerID, BinaryOperatorType.Equal)
        Else
            CustomersItems.Criteria = New GroupOperator(GroupOperatorType.And, New BinaryOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, customerID, BinaryOperatorType.Equal),
                                                        New InOperator(Items.Fields.ItemType.PropertyName, types.Split("|"c)))
        End If

        Return CustomersItems

    End Function

    '<System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    'Public Function GetItemsByCustomerIDAndType(ByVal customerID As Integer, ByVal types As String) As SPG.ItemsDataTable

    '    If String.IsNullOrEmpty(types) Then
    '        Return GetItemsByCustomerID(customerID)
    '    End If

    '    Return Adapter.GetItemsByCustomerIdAndType(customerID, types)

    'End Function

    Public Shared Function GetItemTypes() As DataTable

        Dim itemTypesTable As DataTable = New DataTable("ItemTypes")

        Dim name As DataColumn = New DataColumn("Type") With {.DataType = Type.GetType("System.String")}
        itemTypesTable.Columns.Add(name)
        name = New DataColumn() With {.ColumnName = "Description", .DataType = Type.GetType("System.String")}
        itemTypesTable.Columns.Add(name)

        Dim row As DataRow = itemTypesTable.NewRow()
        row("Type") = "RM"
        row("Description") = "Raw Material"
        itemTypesTable.Rows.Add(row)
        row = itemTypesTable.NewRow()
        row("Type") = "IG"
        row("Description") = "Intermediate Goods"
        itemTypesTable.Rows.Add(row)
        row = itemTypesTable.NewRow()
        row("Type") = "FG"
        row("Description") = "Finished Goods"
        itemTypesTable.Rows.Add(row)

        Return itemTypesTable

    End Function

    Public Function GetItemUOMs() As ArrayList

        Dim itemUOMs As ArrayList = New ArrayList

        Try
            Dim row As SPG.ItemsRow
            For Each row In Me.Adapter.GetItemUOMs
                Dim uom As String = row.strUnitOfMeasure
                If Not itemUOMs.Contains(uom) Then
                    itemUOMs.Add(uom)
                End If
            Next
        Finally

        End Try

        Return itemUOMs

    End Function

    Public Shared Function GetNewItemID() As Integer

        Dim conn As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.UserConnectionString)
        Dim myCommand As New SqlClient.SqlCommand("dbo.spNewIDSafe", conn)
        Dim myNewID As New SqlClient.SqlParameter("@nRetVal", SqlDbType.Int)
        myCommand.CommandType = CommandType.StoredProcedure
        myNewID.Direction = ParameterDirection.Output
        myCommand.Parameters.AddWithValue("@cName", "tblItems")
        myCommand.Parameters.AddWithValue("@cPkField", "ItemID")
        myCommand.Parameters.Add(myNewID)

        conn.Open()
        myCommand.ExecuteNonQuery()

        Return CType(myNewID.Value, Integer)

    End Function

    Public Function GetPallets(ByVal itemID As Integer) As Integer

        Return Adapter.GetPallets(itemID).Value

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Shared Function GetQtyOnHandByID(ByVal session As Session, ByVal itemID As Integer?, ByVal locationID As Integer) As Single

        If itemID.HasValue = False Then
            Return 0
        End If

        'If locationID.HasValue = False Then
        '    locationID = UsersBLL.GetUsersLocalLocation(My.Settings.UserName).Oid
        'End If

        Try
            If locationID = 0 Then
                Return CSng(session.Evaluate(Of LocationInventory)(New AggregateOperand("", LocationInventory.Fields.QuantityOnHand.PropertyName, Aggregate.Sum),
                                                                                  New BinaryOperator(LocationInventory.Fields.LocationInventoryItem.ItemID, itemID.Value, BinaryOperatorType.Equal)))
            Else
                Dim quantity As LocationInventory = session.FindObject(Of LocationInventory)(New GroupOperator(New BinaryOperator(LocationInventory.Fields.LocationInventoryItem.ItemID, itemID.Value, BinaryOperatorType.Equal) And
                                                                                          New BinaryOperator(LocationInventory.Fields.Location.Oid.PropertyName, locationID, BinaryOperatorType.Equal)))
                'Dim item As Items = Session.DefaultSession.GetObjectByKey(Of Items)(itemID, True)
                'Return item.s ngQuantityOnHand
                Return quantity.QuantityOnHand
            End If
        Catch ex As Exception
            Return 0
        End Try

    End Function

    Public Shared Function GetQuantityPerUnit(ByVal itemID As Integer) As Double

        'Returns units per case
        Try
            Dim item As Items = Session.DefaultSession.GetObjectByKey(Of Items)(itemID, True)
            Return item.intQtyPerUnit
        Catch ex As Exception
            Return 0
        End Try

    End Function

    Public Function GetUnits(ByVal itemID As Integer) As Integer

        'Returns units per case
        Try
            Return Adapter.GetUnits(itemID).Value
        Catch ex As Exception
            Return 0
        End Try

    End Function

    Public Shared Function GetUOMByItemID(ByVal itemID As Nullable(Of Integer)) As String

        If Not itemID.HasValue Then
            Return Nothing
        End If

        Try
            Dim item As Items = Session.DefaultSession.GetObjectByKey(Of Items)(itemID.Value, True)
            Return item.strUnitOfMeasure
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, True)> _
    Private Function InsertProduct(ByVal itemID As Integer, ByVal itemCode As String, ByVal itemDescription As String, ByVal itemType As String, ByVal itemCustomerID As Nullable(Of Integer), ByVal itemDefaultMachine As Nullable(Of Integer),
                                   ByVal itemProdStandard As Nullable(Of Double), ByVal dblPrice As Nullable(Of Double), ByVal sngRebate As Nullable(Of Single), ByVal strUnitOfMeasure As String, ByVal intQtyPerUnit As Nullable(Of Double),
                                   ByVal dblFreight As Nullable(Of Double), ByVal dblFilm As Nullable(Of Double), ByVal dblBoxes As Nullable(Of Double), ByVal dblPallets As Nullable(Of Double), ByVal dblStretchWrap As Nullable(Of Double),
                                   ByVal dblOther1 As Nullable(Of Double), ByVal dblOther2 As Nullable(Of Double), ByVal dblOther3 As Nullable(Of Double), ByVal dblOther4 As Nullable(Of Double), ByVal dblOther5 As Nullable(Of Double),
                                   ByVal intUnitsPerCase As Nullable(Of Double), ByVal intUnitsPerPallet As Nullable(Of Integer), ByVal intCasesPerPallet As Nullable(Of Integer), ByVal sngQtyOnHand As Nullable(Of Single),
                                   ByVal CaseGrossWeight As Nullable(Of Double), ByVal PackageCode As String, ByVal CaseCode As String, ByVal RequiredWeight As String, ByVal MAV As String, ByVal CasesPerLayer As String,
                                   ByVal LayersPerPallet As String, ByVal ShelfLife As String, ByVal Instructions As String, ByVal PalletPattern As String, ByVal inactive As Boolean, ByVal packers As Double?, ByVal upc As String,
                                   ByVal bagsPerCase As Integer?, ByVal RequiresLotCode As Boolean?, ByVal RequiresExpirationDate As Boolean?, ByVal GenerateLotCodes As Boolean?, ByVal DefaultLotCodeFormat As Integer?, byval MinutesPerShift As Double?,
                                   ByVal dxSession As Session) As Boolean

        'Dim products As SPG.ItemsDataTable = New SPG.ItemsDataTable
        'Dim product As SPG.ItemsRow = products.NewItemsRow()

        'product.ItemID = itemID
        Dim product As Items = New Items(dxSession) With {.ItemID = itemID}
        SetProductFields(itemCode, itemDescription, itemType, itemCustomerID, itemDefaultMachine, itemProdStandard, dblPrice, sngRebate, strUnitOfMeasure, intQtyPerUnit, dblFreight, dblFilm, dblBoxes, dblStretchWrap, _
                         dblPallets, dblOther1, dblOther2, dblOther3, dblOther4, dblOther5, intUnitsPerCase, intUnitsPerPallet, intCasesPerPallet, sngQtyOnHand, CaseGrossWeight, PackageCode, CaseCode, RequiredWeight, MAV, _
                         CasesPerLayer, LayersPerPallet, ShelfLife, Instructions, PalletPattern, inactive, packers, upc, bagsPerCase, RequiresLotCode, RequiresExpirationDate, GenerateLotCodes, DefaultLotCodeFormat, MinutesPerShift, product, dxSession)
        product.strEnteredBy = My.Settings.UserName
        product.dtmEnteredOn = Now

        'products.AddItemsRow(product)
        'Dim rowsAffected As Integer = Adapter.Update(products)

        'Return rowsAffected = 1

        Try
            product.Save()
        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function

    Private Sub SetField(propertyName As String, oldValue As Object, newValue As Object, ByVal product As Items)

        If (oldValue IsNot Nothing Or newValue IsNot Nothing) AndAlso
            ((oldValue IsNot Nothing And newValue Is Nothing) OrElse (newValue IsNot Nothing And oldValue Is Nothing) OrElse oldValue.ToString <> newValue.ToString) Then
            product.SetMemberValue(propertyName, newValue)
            Dim change As New Change() With {.PropertyName = propertyName, .PrevValue = If(oldValue Is Nothing, "<NULL>", oldValue.ToString()), .NewValue = If(newValue Is Nothing, "<NULL>", newValue.ToString())}
            changes.Add(change)
        End If

    End Sub

    Private Sub SetProductFields(ByVal itemCode As String, ByVal itemDescription As String, ByVal itemType As String, ByVal itemCustomerID As Nullable(Of Integer), ByVal itemDefaultMachine As Nullable(Of Integer),
                                 ByVal itemProdStandard As Nullable(Of Double), ByVal dblPrice As Nullable(Of Double), ByVal sngRebate As Nullable(Of Single), ByVal strUnitOfMeasure As String, ByVal intQtyPerUnit As Nullable(Of Double),
                                 ByVal dblFreight As Nullable(Of Double), ByVal dblFilm As Nullable(Of Double), ByVal dblBoxes As Nullable(Of Double), ByVal dblStretchWrap As Nullable(Of Double), ByVal dblPallets As Nullable(Of Double),
                                 ByVal dblOther1 As Nullable(Of Double), ByVal dblOther2 As Nullable(Of Double), ByVal dblOther3 As Nullable(Of Double), ByVal dblOther4 As Nullable(Of Double), ByVal dblOther5 As Nullable(Of Double),
                                 ByVal intUnitsPerCase As Nullable(Of Double), ByVal intUnitsPerPallet As Nullable(Of Integer), ByVal intCasesPerPallet As Nullable(Of Integer), ByVal sngQtyOnHand As Nullable(Of Single),
                                 ByVal CaseGrossWeight As Nullable(Of Double), ByVal PackageCode As String, ByVal CaseCode As String, ByVal RequiredWeight As String, ByVal MAV As String, ByVal CasesPerLayer As String,
                                 ByVal LayersPerPallet As String, ByVal ShelfLife As String, ByVal Instructions As String, ByVal PalletPattern As String, ByVal inactive As Boolean, ByVal packers As Double?, ByVal upc As String,
                                 ByVal bagsPerCase As Integer?, ByVal RequiresLotCode As Boolean?, ByVal RequiresExpirationDate As Boolean?, ByVal GenerateLotCodes As Boolean?, ByVal DefaultLotCodeFormat As Integer?, ByVal MinutesPerShift As Double?, 
                                 ByVal product As Items, ByVal dxSession As Session)

        SetField(Items.Fields.ItemCode.PropertyName, product.ItemCode, itemCode, product)
        SetField(Items.Fields.ItemDescription.PropertyName, product.ItemDescription, If(String.IsNullOrEmpty(itemDescription), Nothing, itemDescription), product)
        SetField(Items.Fields.ItemType.PropertyName, product.ItemType, itemType, product)
        SetField(Items.Fields.ItemCustomerID.PropertyName, product.ItemCustomerID, If(itemCustomerID.HasValue, dxSession.GetObjectByKey(Of Customers)(itemCustomerID), Nothing), product)
        SetField(Items.Fields.ItemDefaultMachine.PropertyName, product.ItemDefaultMachine, If(itemDefaultMachine.HasValue, dxSession.GetObjectByKey(Of MachineLine)(itemDefaultMachine.Value), Nothing), product)
        SetField(Items.Fields.ItemProdStandard.PropertyName, product.ItemProdStandard, If(itemProdStandard.HasValue, itemProdStandard.Value, Nothing), product)
        SetField(Items.Fields.dblPrice.PropertyName, product.dblPrice, If(dblPrice.HasValue, dblPrice.Value, Nothing), product)
        SetField(Items.Fields.sngRebate.PropertyName, product.sngRebate, If(sngRebate.HasValue, sngRebate.Value, Nothing), product)
        SetField(Items.Fields.strUnitOfMeasure.PropertyName, product.strUnitOfMeasure, If(String.IsNullOrEmpty(strUnitOfMeasure), Nothing, strUnitOfMeasure), product)
        SetField(Items.Fields.intQtyPerUnit.PropertyName, product.intQtyPerUnit, If(intQtyPerUnit.HasValue, intQtyPerUnit.Value, Nothing), product)
        SetField(Items.Fields.dblFreight.PropertyName, product.dblFreight, If(dblFreight.HasValue, dblFreight.Value, Nothing), product)
        SetField(Items.Fields.dblFilm.PropertyName, product.dblFilm, If(dblFilm.HasValue, dblFilm.Value, Nothing), product)
        SetField(Items.Fields.dblBoxes.PropertyName, product.dblBoxes, If(dblBoxes.HasValue, dblBoxes.Value, Nothing), product)
        SetField(Items.Fields.dblStretchWrap.PropertyName, product.dblStretchWrap, If(dblStretchWrap.HasValue, dblStretchWrap.Value, Nothing), product)
        SetField(Items.Fields.dblPallets.PropertyName, product.dblPallets, If(dblPallets.HasValue, dblPallets.Value, Nothing), product)
        SetField(Items.Fields.dblOther1.PropertyName, product.dblOther1, If(dblOther1.HasValue, dblOther1.Value, Nothing), product)
        SetField(Items.Fields.dblOther2.PropertyName, product.dblOther2, If(dblOther2.HasValue, dblOther2.Value, Nothing), product)
        SetField(Items.Fields.dblOther3.PropertyName, product.dblOther3, If(dblOther3.HasValue, dblOther3.Value, Nothing), product)
        SetField(Items.Fields.dblOther4.PropertyName, product.dblOther4, If(dblOther4.HasValue, dblOther4.Value, Nothing), product)
        SetField(Items.Fields.dblOther5.PropertyName, product.dblOther5, If(dblOther5.HasValue, dblOther5.Value, Nothing), product)
        SetField(Items.Fields.intUnitsPerCase.PropertyName, product.intUnitsPerCase, If(intUnitsPerCase.HasValue, intUnitsPerCase.Value, Nothing), product)
        SetField(Items.Fields.intUnitsPerPallet.PropertyName, product.intUnitsPerPallet, If(intUnitsPerPallet.HasValue, intUnitsPerPallet.Value, Nothing), product)
        SetField(Items.Fields.intCasesPerPallet.PropertyName, product.intCasesPerPallet, If(intCasesPerPallet.HasValue, intCasesPerPallet.Value, Nothing), product)
        SetField(Items.Fields.BagsPerCase.PropertyName, product.BagsPerCase, If(bagsPerCase.HasValue, bagsPerCase.Value, Nothing), product)
        SetField(Items.Fields.CaseGrossWeight.PropertyName, product.CaseGrossWeight, If(CaseGrossWeight.HasValue, CaseGrossWeight.Value, Nothing), product)
        SetField(Items.Fields.PackageCode.PropertyName, product.PackageCode, If(String.IsNullOrEmpty(PackageCode), Nothing, PackageCode), product)
        SetField(Items.Fields.CaseCode.PropertyName, product.CaseCode, If(String.IsNullOrEmpty(CaseCode), Nothing, CaseCode), product)
        SetField(Items.Fields.RequiredWeight.PropertyName, product.RequiredWeight, If(String.IsNullOrEmpty(RequiredWeight), Nothing, RequiredWeight), product)
        SetField(Items.Fields.MAV.PropertyName, product.MAV, If(String.IsNullOrEmpty(MAV), Nothing, MAV), product)
        SetField(Items.Fields.CasesPerLayer.PropertyName, product.CasesPerLayer, If(String.IsNullOrEmpty(CasesPerLayer), Nothing, CasesPerLayer), product)
        SetField(Items.Fields.LayersPerPallet.PropertyName, product.LayersPerPallet, If(String.IsNullOrEmpty(LayersPerPallet), Nothing, LayersPerPallet), product)
        SetField(Items.Fields.ShelfLife.PropertyName, product.ShelfLife, If(String.IsNullOrEmpty(ShelfLife), Nothing, ShelfLife), product)
        SetField(Items.Fields.Instructions.PropertyName, product.Instructions, If(String.IsNullOrEmpty(Instructions), Nothing, Instructions), product)
        SetField(Items.Fields.PalletPattern.PropertyName, product.PalletPattern, If(String.IsNullOrEmpty(PalletPattern), Nothing, PalletPattern), product)
        SetField(Items.Fields.Inactive.PropertyName, product.Inactive, inactive, product)
        SetField(Items.Fields.Packers.PropertyName, product.Packers, If(packers.HasValue, packers.Value, Nothing), product)
        SetField(Items.Fields.UPC.PropertyName, product.UPC, If(String.IsNullOrEmpty(upc), Nothing, upc), product)
        SetField(Items.Fields.RequiresLotCodes.PropertyName, product.RequiresLotCodes, If(RequiresLotCode.HasValue, RequiresLotCode.Value, Nothing), product)
        SetField(Items.Fields.RequiresExpirationDates.PropertyName, product.RequiresExpirationDates, If(RequiresExpirationDate.HasValue, RequiresExpirationDate.Value, Nothing), product)
        SetField(Items.Fields.GenerateLotCodes.PropertyName, product.GenerateLotCodes, If(GenerateLotCodes.HasValue, GenerateLotCodes.Value, Nothing), product)
        SetField(Items.Fields.DefaultLotCodeFormat.PropertyName, product.DefaultLotCodeFormat, If(DefaultLotCodeFormat.HasValue, dxSession.GetObjectByKey(Of LotCodeFormats)(DefaultLotCodeFormat.Value), Nothing), product)
        SetField(Items.Fields.MinutesPerShift.PropertyName, product.MinutesPerShift, If(MinutesPerShift.HasValue, MinutesPerShift.Value, Nothing), product)

    End Sub

    'Private Shared Sub UpdateAuditTrail(ByVal ModifiedRecord As SPG.ItemsRow, ByVal originalRecord As Object())

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
    '        AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(ModifiedRecord.Item(0), Integer), "Items", builder.ToString)
    '    End If

    'End Sub

    Private Sub UpdateAuditTrail()

        Dim builder As New StringBuilder(String.Empty)

        For Each update As Change In changes
            builder.Append(String.Format("{0}:{1}({2}); ", update.PropertyName, update.PrevValue, update.NewValue))
        Next

        If (builder.Length > 2) Then
            builder.Length = (builder.Length - 2)
            AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(changes(0).NewValue, Integer), "Items", builder.ToString)
        End If

        changes.Clear()

    End Sub


    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateProduct(ByVal itemID As Integer, ByVal itemCode As String, ByVal itemDescription As String, ByVal itemType As String, ByVal itemCustomerID As Nullable(Of Integer), ByVal itemDefaultMachine As Nullable(Of Integer),
                                  ByVal itemProdStandard As Nullable(Of Double), ByVal dblPrice As Nullable(Of Double), ByVal sngRebate As Nullable(Of Single), ByVal strUnitOfMeasure As String, ByVal intQtyPerUnit As Nullable(Of Double),
                                  ByVal dblFreight As Nullable(Of Double), ByVal dblFilm As Nullable(Of Double), ByVal dblBoxes As Nullable(Of Double), ByVal dblStretchWrap As Nullable(Of Double), ByVal dblPallets As Nullable(Of Double),
                                  ByVal dblOther1 As Nullable(Of Double), ByVal dblOther2 As Nullable(Of Double), ByVal dblOther3 As Nullable(Of Double), ByVal dblOther4 As Nullable(Of Double), ByVal dblOther5 As Nullable(Of Double),
                                  ByVal intUnitsPerCase As Nullable(Of Double), ByVal intUnitsPerPallet As Nullable(Of Integer), ByVal intCasesPerPallet As Nullable(Of Integer), ByVal sngQtyOnHand As Nullable(Of Single),
                                  ByVal CaseGrossWeight As Nullable(Of Double), ByVal PackageCode As String, ByVal CaseCode As String, ByVal RequiredWeight As String, ByVal MAV As String, ByVal CasesPerLayer As String, 
                                  ByVal LayersPerPallet As String, ByVal ShelfLife As String, ByVal Instructions As String, ByVal PalletPattern As String, ByVal inactive As Boolean, ByVal packers As Double?, ByVal upc As String, 
                                  ByVal bagsPerCase As Integer?, byval RequiresLotCode As Boolean?, byval RequiresExpirationDate As Boolean?, ByVal GenerateLotCodes As Boolean?, ByVal DefaultLotCodeFormat As Integer?, ByVal MinutesPerSift As Double?,
                                  ByVal dxSession As Session) As Boolean

        Dim str As StringBuilder = New StringBuilder(String.Empty)
        If String.IsNullOrEmpty(itemCode) Then
            str.Append("Item Code, ")
        End If
        If String.IsNullOrEmpty(itemType) Then
            str.Append("Item Type, ")
        End If
        If Not itemCustomerID.HasValue Then
            str.Append("Customer name, ")
        End If
        If Not DefaultLotCodeFormat.HasValue AndAlso RequiresLotCode.HasValue AndAlso RequiresLotCode.Value AndAlso itemCustomerID.HasValue AndAlso dxSession.GetObjectByKey(Of Customers)(itemCustomerID.Value).DefaultLotCodeFormat Is Nothing Then
            str.Append("Default Lot Code Format, ")
        End If

        If str.Length > 0 Then
            Throw New ApplicationException(String.Format("You must provide a {0}.", str.ToString.Substring(0, (str.Length - 2))))
        End If

        If Not String.IsNullOrEmpty(upc) Then
            Dim theCriteria As New CriteriaOperatorCollection
            theCriteria.Add(New BinaryOperator(Items.Fields.UPC.PropertyName, upc, BinaryOperatorType.Equal))
            theCriteria.Add(New BinaryOperator(Items.Fields.ItemID.PropertyName, itemID, BinaryOperatorType.NotEqual))

            If dxSession.GetObjects(dxSession.GetClassInfo(Of Items)(), New GroupOperator(GroupOperatorType.And, theCriteria), Nothing, 1, False, True).Count > 0 Then
                Throw New ApplicationException("UPC must be unique.")
            End If
        End If

        'Dim products As SPG.ItemsDataTable = Adapter.GetItemByID(itemID)

        'If products.Count = 0 Then
        Dim change As Change
        Dim product As Items = dxSession.GetObjectByKey(Of Items)(itemID)

        If product Is Nothing Then
            'It is a new Customer
            change = New Change() With {.PropertyName = Items.Fields.ItemID.PropertyName, .PrevValue = "<NULL>", .NewValue = itemID.ToString}
            changes.Add(change)
            'It is a new Product
            Return InsertProduct(itemID, itemCode, itemDescription, itemType, itemCustomerID, itemDefaultMachine, itemProdStandard, dblPrice, sngRebate, strUnitOfMeasure, intQtyPerUnit, dblFreight, dblFilm, dblBoxes, dblStretchWrap, dblPallets,
                                 dblOther1, dblOther2, dblOther3, dblOther4, dblOther5, intUnitsPerCase, intUnitsPerPallet, intCasesPerPallet, sngQtyOnHand, CaseGrossWeight, PackageCode, CaseCode, RequiredWeight, MAV, CasesPerLayer, LayersPerPallet,
                                 ShelfLife, Instructions, PalletPattern, inactive, packers, upc, bagsPerCase, RequiresLotCode, RequiresExpirationDate, GenerateLotCodes, DefaultLotCodeFormat, MinutesPerSift, dxSession)
        End If

        'Dim product As SPG.ItemsRow = products(0)

        'Dim originalRecord As Object() = Nothing
        'originalRecord = product.ItemArray

        change = New Change() With {.PropertyName = Items.Fields.ItemID.PropertyName, .PrevValue = product.ItemID.ToString, .NewValue = product.ItemID.ToString}
        changes.Add(change)

        SetProductFields(itemCode, itemDescription, itemType, itemCustomerID, itemDefaultMachine, itemProdStandard, dblPrice, sngRebate, strUnitOfMeasure, intQtyPerUnit, dblFreight, dblFilm, dblBoxes, dblStretchWrap, _
                         dblPallets, dblOther1, dblOther2, dblOther3, dblOther4, dblOther5, intUnitsPerCase, intUnitsPerPallet, intCasesPerPallet, sngQtyOnHand, CaseGrossWeight, PackageCode, CaseCode, RequiredWeight, MAV, _
                         CasesPerLayer, LayersPerPallet, ShelfLife, Instructions, PalletPattern, inactive, packers, upc, bagsPerCase, RequiresLotCode, RequiresExpirationDate, GenerateLotCodes, DefaultLotCodeFormat, MinutesPerSift, product, dxSession)

        Try
            product.Editing = False
            product.Save()
        Catch ex As Exception
            Return False
        End Try

        'If Not IsNothing(originalRecord) Then
        '    ItemsBLL.UpdateAuditTrail(product, originalRecord)
        'End If

        'Dim rowsAffected As Integer = Adapter.Update(product)

        UpdateAuditTrail()

        'Return rowsAffected = 1

        Return True

    End Function

    Public Sub UpdateStock(ByVal session As Session, ByVal itemID As Integer, ByVal inventoryID As Nullable(Of Integer), ByVal quantity As Single, ByVal updateBOM As Boolean, ByVal locationID As Integer)

        Dim scrapfactor As Double
        'To do update the stock for the item and bom's associated with it
        If updateBOM = True Then
            If inventoryID.HasValue Then
                'Dim inventoryBOMs As InventoryBOMsBLL = New InventoryBOMsBLL
                'Dim inventoryItemBOM As SPG.InventoryBOMsDataTable = inventoryBOMs.GetInventoryBOMsBYInventoryID(inventoryID.Value)
                Dim inventoryItemBOM As XPCollection(Of InventoryBOMs) = InventoryBOMsBLL.GetInventoryBOMsBYInventoryID(session, inventoryID.Value)
                'If inventoryItemBOM.Rows.Count <> 0 Then
                If inventoryItemBOM.Count <> 0 Then
                    'Dim itemsBOM As SPG.InventoryBOMsRow
                    Dim itemsBOM As InventoryBOMs
                    For i As Integer = 0 To inventoryItemBOM.Count - 1
                        'itemsBOM = CType(inventoryItemBOM.Rows(i), SPG.InventoryBOMsRow)
                        itemsBOM = inventoryItemBOM(i)
                        If itemsBOM.IsDeleted = False Then
                            'updates the raw material
                            If itemsBOM.ScrapFactor > 0 Then
                                scrapfactor = itemsBOM.InventoryBOMQuantity * itemsBOM.ScrapFactor
                            Else
                                scrapfactor = 0
                            End If
                            UpdateStock(session, itemsBOM.InventoryBOMRawMatID.ItemID, (Convert.ToSingle(quantity * (itemsBOM.InventoryBOMQuantity + scrapfactor)) * -1), False, locationID)
                        End If
                    Next i
                    updateBOM = False
                End If
            End If
        End If

        If updateBOM = True Then
            'The item has a bom attached to it
            Dim boms As BOMBLL = New BOMBLL
            'Dim itemsBOMs As SPG.BOMDataTable = boms.GetBOMBYFGItemID(itemID)
            Dim itemsBOMs As XPCollection(Of BOMs) = BOMBLL.GetBOMBYFGItemID(session, itemID)

            'If itemsBOMs.Rows.Count <> 0 Then
            If itemsBOMs.Count <> 0 Then
                'Dim itemsBOM As SPG.BOMRow
                Dim itemsBOM As BOMs
                'For i As Integer = 0 To itemsBOMs.Rows.Count - 1
                For i As Integer = 0 To itemsBOMs.Count - 1
                    'itemsBOM = CType(itemsBOMs.Rows(i), SPG.BOMRow)
                    itemsBOM = itemsBOMs(i)
                    'updates the raw material
                    If itemsBOM.BOMRawMatID.ItemID <> itemID Then
                        If itemsBOM.ScrapFactor > 0 Then
                            scrapfactor = itemsBOM.BOMQuantity * (itemsBOM.ScrapFactor / 100)
                        Else
                            scrapfactor = 0
                        End If
                        UpdateStock(session, itemsBOM.BOMRawMatID.ItemID, (Convert.ToSingle(quantity * (itemsBOM.BOMQuantity + scrapfactor)) * -1), False, locationID)
                    End If
                Next i
            End If
        End If

        LocationInventoryBLL.UpdateStock(session, itemID, locationID, quantity)

        'Dim item As SPG.ItemsRow = CType(GetItemBYId(itemID).Rows(0), SPG.ItemsRow)
        'item.s ngQuantityOnHand += quantity
        'Adapter.Update(item)

    End Sub

    Public Sub UpdateStock(ByVal session As Session, ByVal itemID As Integer, ByVal quantity As Single, ByVal updateBOM As Boolean, ByVal locationID As Integer)

        UpdateStock(session, itemID, Nothing, quantity, updateBOM, locationID)

    End Sub





    '<System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    'Public Function GetItemsSearch(ByVal inactive As Boolean) As SPG.ItemsDataTable

    '    If inactive Then
    '        Return Adapter.GetItemsSearch(Nothing)
    '    End If
    '    'will return only those that are active
    '    Return Adapter.GetItemsSearch(inactive)

    'End Function



























    'Public Function GetCustomerNameByItemID(ByVal itemID As Integer) As String

    '    Return Adapter.GetItemsCustomer(itemID).Rows(0)("CustomerName").ToString

    'End Function

















End Class
