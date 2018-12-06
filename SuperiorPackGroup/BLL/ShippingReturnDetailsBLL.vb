Imports SuperiorPackGroup.SPGTableAdapters
Imports System.Text
Imports DevExpress.Xpo
Imports DXDAL.SPGData
Imports DevExpress.Data.Filtering

<ComponentModel.DataObject()> _
Public Class ShippingReturnDetailsBLL

    Private m_ShippingReturnDetailsTableAdapter As ShippingReturnDetailsTableAdapter = Nothing
    Public ReadOnly Property Adapter() As ShippingReturnDetailsTableAdapter

        Get
            If m_ShippingReturnDetailsTableAdapter Is Nothing Then
                m_ShippingReturnDetailsTableAdapter = New ShippingReturnDetailsTableAdapter()
                m_ShippingReturnDetailsTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return m_ShippingReturnDetailsTableAdapter
        End Get

    End Property

    Private Sub UpdateAuditTrail(ByVal ModifiedRecord As SPG.ShippingReturnDetailsRow, ByVal originalRecord As Object())

        Dim builder As New StringBuilder(String.Empty)
        Dim recordFields As Integer = (ModifiedRecord.ItemArray.Length - 1)
        Dim i As Integer = 0
        Do While (i <= recordFields)
            Try
                If IsDBNull(originalRecord(i)) Then
                    If Not IsDBNull(ModifiedRecord.Item(i)) Then
                        builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, "NULL", ModifiedRecord.Item(i)))
                    End If
                ElseIf IsDBNull(ModifiedRecord.Item(i)) Then
                    If Not IsDBNull(originalRecord(i)) Then
                        builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, originalRecord(i), "NULL"))
                    End If
                ElseIf ModifiedRecord.Item(i) IsNot originalRecord(i) Then
                    builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, originalRecord(i), ModifiedRecord.Item(i)))
                End If
            Catch
            End Try
            i += 1
        Loop
        If (builder.Length > 2) Then
            builder.Length = (builder.Length - 2)
            AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(ModifiedRecord.Item(0), Integer), "ShippingReturnDetails", builder.ToString)
        End If

    End Sub

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetShippingReturnDetailsByItemID(ByVal itemID As Integer) As SPG.ShippingReturnDetailsDataTable

        Return Adapter.GetShippingReturnDetailsByItemID(itemID)

    End Function

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetShippingReturnDetailsByShippingID(ByVal shippingID As Integer) As SPG.ShippingReturnDetailsDataTable

        Return Adapter.GetShippingReturnDetailsByShippingID(shippingID)

    End Function

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateShippingReturnDetails(ByVal session As Session, ByVal detailID As Integer?, ByVal receivingID As Integer, ByVal itemID As Integer?, ByVal lot As String, ByVal quantity As Integer?, ByVal units As Integer?,
                                            ByVal pallets As Single?, ByVal reason As String, ByVal expirationDate As Date?) As Boolean

        If Not itemID.HasValue Then
            Throw New ApplicationException("You must provide return item.")
        End If

        If Not quantity.HasValue OrElse Not units.HasValue Then
            Throw New ApplicationException("You must provide the Quantity\Units returned.")
        End If

        Dim details As SPG.ShippingReturnDetailsDataTable = Adapter.GetShippingReturnDetailByID(detailID.Value)

        If details.Count = 0 Then
            'It is a new Detail
            Return Me.InsertDetails(session, receivingID, itemID, lot, quantity, units, pallets, reason, expirationDate)
        End If

        Dim returnDetail As SPG.ShippingReturnDetailsRow = details(0)
        Dim originalItem, originalQuantity, newQuantity As Integer
        Dim itemChanged As Boolean = False

        Dim originalRecord As Object() = Nothing
        originalRecord = returnDetail.ItemArray

        originalItem = returnDetail.ReturnDetItemID
        If originalItem <> itemID.Value Then
            itemChanged = True
        End If
        returnDetail.ReturnDetItemID = itemID.Value
        If String.IsNullOrEmpty(lot) Then
            returnDetail.SetReturnDetLotNull()
        Else
            returnDetail.ReturnDetLot = lot
        End If
        returnDetail.ReturnDetQty = quantity.Value
        originalQuantity = returnDetail.intUnits
        newQuantity = returnDetail.intUnits - units.Value
        returnDetail.intUnits = units.Value
        If Not pallets.HasValue Then
            returnDetail.SetsngPalletsNull()
        Else
            returnDetail.sngPallets = pallets.Value
        End If
        If String.IsNullOrEmpty(reason) Then
            returnDetail.SetReasonNull()
        Else
            returnDetail.Reason = reason
        End If
        If expirationDate.HasValue Then
            returnDetail.ExpirationDate = expirationDate.Value
        Else
            returnDetail.SetExpirationDateNull()
        End If

        If Not IsNothing(originalRecord) Then
            Me.UpdateAuditTrail(returnDetail, originalRecord)
        End If

        Dim rowsAffected As Integer = Adapter.Update(returnDetail)

        If rowsAffected = 1 Then
            Dim items As ItemsBLL = New ItemsBLL
            Dim locationID As Integer = session.GetObjectByKey(Of Shipping)(receivingID).ShippingLocation.Oid
            If itemChanged = True Then
                items.UpdateStock(session, originalItem, originalQuantity, False, locationID)
                items.UpdateStock(session, itemID.Value, units.Value * -1, False, locationID)
            Else
                If newQuantity <> 0 Then
                    items.UpdateStock(session, itemID.Value, newQuantity, False, locationID)
                End If
            End If
        End If

        Return rowsAffected = 1

    End Function

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Insert, True)> _
    Public Function InsertDetails(ByVal session As Session, ByVal shippingID As Integer, ByVal itemID As Integer?, ByVal lot As String, ByVal quantity As Integer?, ByVal units As Integer?, ByVal pallets As Single?, _
                                  ByVal reason As String, ByVal expirationDate As Date?) As Boolean

        Dim details As SPG.ShippingReturnDetailsDataTable = New SPG.ShippingReturnDetailsDataTable
        Dim returnDetail As SPG.ShippingReturnDetailsRow = details.NewShippingReturnDetailsRow()

        returnDetail.ShipMainID = shippingID
        returnDetail.ReturnDetItemID = itemID.Value
        If String.IsNullOrEmpty(lot) Then
            returnDetail.SetReturnDetLotNull()
        Else
            returnDetail.ReturnDetLot = lot
        End If
        returnDetail.ReturnDetQty = quantity.Value
        returnDetail.intUnits = units.Value
        If Not pallets.HasValue Then
            returnDetail.SetsngPalletsNull()
        Else
            returnDetail.sngPallets = pallets.Value
        End If
        If String.IsNullOrEmpty(reason) Then
            returnDetail.SetReasonNull()
        Else
            returnDetail.Reason = reason
        End If
        If expirationDate.HasValue Then
            returnDetail.ExpirationDate = expirationDate.Value
        Else
            returnDetail.SetExpirationDateNull()
        End If

        details.AddShippingReturnDetailsRow(returnDetail)
        Dim rowsAffected As Integer = Adapter.Update(details)

        If rowsAffected = 1 Then
            Dim items As ItemsBLL = New ItemsBLL
            items.UpdateStock(session, itemID.Value, units.Value * -1, False, session.GetObjectByKey(Of Shipping)(shippingID).ShippingLocation.Oid)
        End If

        Return rowsAffected = 1

    End Function

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Delete, True)> _
    Public Function DeleteReturnDetail(ByVal session As Session, ByVal detailID As Integer) As Boolean

        Dim details As SPG.ShippingReturnDetailsDataTable = Adapter.GetShippingReturnDetailByID(detailID)
        Dim rowsAffected As Integer = 0
        Dim itemID, quantity, locationID As Integer

        If details.Count = 1 Then
            Dim returnDetail As SPG.ShippingReturnDetailsRow = CType(details.Rows(0), SPG.ShippingReturnDetailsRow)
            itemID = returnDetail.ReturnDetItemID
            quantity = returnDetail.intUnits
            locationID = session.GetObjectByKey(Of Shipping)(returnDetail.ShipMainID).ShippingLocation.Oid
            rowsAffected = Adapter.Delete(detailID, returnDetail.ts)
        End If

        If rowsAffected = 1 Then
            Dim items As ItemsBLL = New ItemsBLL
            items.UpdateStock(session, itemID, quantity, False, locationID)
        End If

        'Return true if precisely one row was deleted, otherwise return false.
        Return rowsAffected = 1

    End Function

    Public Shared Function GetShippingReturnDetailsViewByItemID(ByVal itemID As Integer) As XPView

        Dim ShippingReturnXPView As New XPView(Session.DefaultSession, GetType(ShippedReturns))

        ShippingReturnXPView.Properties.AddRange(New ViewProperty() {New ViewProperty("ReturnDetID", SortDirection.None, ShippedReturns.Fields.ReturnDetID, False, True),
                                                                     New ViewProperty("ShipMainID", SortDirection.Ascending, ShippedReturns.Fields.ShipMainID.ShipMainID, False, True),
                                                                     New ViewProperty("ReturnDetLot", SortDirection.None, ShippedReturns.Fields.ReturnDetLot, False, True),
                                                                     New ViewProperty("ExpirationDate", SortDirection.None, ShippedReturns.Fields.ExpirationDate, False, True),
                                                                     New ViewProperty("intUnits", SortDirection.None, ShippedReturns.Fields.intUnits, False, True),
                                                                     New ViewProperty("ShipMainBOL", SortDirection.None, ShippedReturns.Fields.ShipMainID.ShipMainBOL, False, True),
                                                                     New ViewProperty("ShipMainDate", SortDirection.None, ShippedReturns.Fields.ShipMainID.ShipMainDate, False, True)})

        ShippingReturnXPView.Criteria = New BinaryOperator(ShippedReturns.Fields.ReturnDetItemID.ItemID.PropertyName, itemID, BinaryOperatorType.Equal)

        Return ShippingReturnXPView

    End Function

End Class
