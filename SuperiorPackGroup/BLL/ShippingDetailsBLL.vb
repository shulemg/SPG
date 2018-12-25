Imports SuperiorPackGroup.SPGTableAdapters
Imports System.Text
Imports DevExpress.Xpo
Imports DXDAL.SPGData

<ComponentModel.DataObject()> _
Public Class ShippingDetailsBLL

    Private m_ShippingDetailsTableAdapter As ShippingDetailsTableAdapter = Nothing
    Public ReadOnly Property Adapter() As ShippingDetailsTableAdapter

        Get
            If m_ShippingDetailsTableAdapter Is Nothing Then
                m_ShippingDetailsTableAdapter = New ShippingDetailsTableAdapter()
                m_ShippingDetailsTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return m_ShippingDetailsTableAdapter
        End Get

    End Property

    Private Sub UpdateAuditTrail(ByVal ModifiedRecord As SPG.ShippingDetailsRow, ByVal originalRecord As Object())

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
            AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(ModifiedRecord.Item(0), Integer), "ShippingDetails", builder.ToString)
        End If

    End Sub

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetShippingDetailsByItemID(ByVal itemId As Integer) As SPG.ShippingDetailsDataTable

        Return Adapter.GetShippingDetailsByItemID(itemId)

    End Function

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetDetailsByShippingID(ByVal shippingID As Integer) As SPG.ShippingDetailsDataTable

        Return Adapter.GetDetailsByShippingID(shippingID)

    End Function

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateShippingDetails(ByVal session As Session, ByVal detailID As Integer?, ByVal shippingID As Integer, ByVal itemID As Integer?, ByVal lot As String, ByVal quantity As Integer?, _
                                          ByVal pallets As Single?, ByVal note As String, ByVal expirationDate As Date?, ByVal fullLPNNumber As String) As Boolean

        If Not itemID.HasValue Then
            Throw New ApplicationException("You must provide shipping item.")
        End If

        If Not quantity.HasValue Then
            Throw New ApplicationException("You must provide the Quantity shipped.")
        End If

        Dim details As SPG.ShippingDetailsDataTable = Adapter.GetDetailsByDetailID(detailID.Value)

        If details.Count = 0 Then
            'It is a new Detail
            Return Me.InsertDetails(session, shippingID, itemID, lot, quantity, pallets, note, expirationDate, fullLPNNumber)
        End If

        Dim shippingDetail As SPG.ShippingDetailsRow = details(0)
        Dim originalItem, originalQuantity, newQuantity As Integer
        Dim itemChanged As Boolean = False

        Dim originalRecord As Object() = Nothing
        originalRecord = shippingDetail.ItemArray

        Dim originalDetail As SPG.ShippingDetailsRow = details.NewShippingDetailsRow()
        originalDetail.ItemArray = CType(originalRecord.Clone(), Object())

        originalItem = shippingDetail.ShipDetItemID
        If originalItem <> itemID.Value Then
            itemChanged = True
        End If
        shippingDetail.ShipDetItemID = itemID.Value
        If String.IsNullOrEmpty(lot) Then
            shippingDetail.SetShipDetLotNull()
        Else
            shippingDetail.ShipDetLot = lot
        End If
        originalQuantity = shippingDetail.ShipDetDetQty
        newQuantity = quantity.Value - shippingDetail.ShipDetDetQty
        shippingDetail.ShipDetDetQty = quantity.Value
        shippingDetail.SetsngPackagesNull()
        If Not pallets.HasValue Then
            shippingDetail.SetsngPalletsNull()
        Else
            shippingDetail.sngPallets = pallets.Value
        End If
        If String.IsNullOrEmpty(note) Then
            shippingDetail.SetNoteNull()
        Else
            shippingDetail.Note = note
        End If
        If expirationDate.HasValue Then
            shippingDetail.ExpirationDate = expirationDate.Value
        Else
            shippingDetail.SetExpirationDateNull()
        End If
        If String.IsNullOrEmpty(fullLPNNumber) Then
            shippingDetail.SetFullLPNNumberNull()
        Else
            shippingDetail.FullLPNNumber = fullLPNNumber
        End If

        If Not IsNothing(originalRecord) Then
            Me.UpdateAuditTrail(shippingDetail, originalRecord)
        End If

        Dim rowsAffected As Integer = Adapter.Update(shippingDetail)

        If rowsAffected = 1 Then
            Dim items As ItemsBLL = New ItemsBLL
            Dim locationID As Integer = session.GetObjectByKey(Of Shipping)(shippingID).ShippingLocation.Oid
            'If itemChanged = True Then
            If originalDetail.FullLPNNumber.StartsWith(CustomersBLL.GetLPNPrefix(7)) Then
                items.UpdateStock(session, originalItem, originalQuantity, False, locationID, originalDetail.ShipDetLot, Integer.Parse(originalDetail.FullLPNNumber.Replace(CustomersBLL.GetLPNPrefix(7), "")))
            Else
                items.UpdateStock(session, originalItem, originalQuantity, False, locationID)
                End If
                If fullLPNNumber.StartsWith(CustomersBLL.GetLPNPrefix(7)) Then
                    items.UpdateStock(session, itemID.Value, quantity.Value * -1, False, locationID, lot, Integer.Parse(fullLPNNumber.Replace(CustomersBLL.GetLPNPrefix(7), "")))
                Else
                    items.UpdateStock(session, itemID.Value, quantity.Value * -1, False, locationID)
                End If
                'Else
                '    If newQuantity <> 0 Then
                '        items.UpdateStock(session, itemID.Value, newQuantity * -1, False, locationID)
                '    End If
                'End If
            End If

        Return rowsAffected = 1

    End Function

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Insert, True)> _
    Public Function InsertDetails(ByVal session As Session, ByVal shippingID As Integer, ByVal itemID As Integer?, ByVal lot As String, ByVal quantity As Integer?, ByVal pallets As Single?, _
                                  ByVal note As String, ByVal expirationDate As Date?, ByVal fullLPNNumber As String) As Boolean

        Dim details As SPG.ShippingDetailsDataTable = New SPG.ShippingDetailsDataTable
        Dim shippingDetail As SPG.ShippingDetailsRow = details.NewShippingDetailsRow()

        shippingDetail.ShipDetMainID = shippingID
        shippingDetail.ShipDetItemID = itemID.Value
        If String.IsNullOrEmpty(lot) Then
            shippingDetail.SetShipDetLotNull()
        Else
            shippingDetail.ShipDetLot = lot
        End If
        shippingDetail.ShipDetDetQty = quantity.Value
        shippingDetail.SetsngPackagesNull()
        If Not pallets.HasValue Then
            shippingDetail.SetsngPalletsNull()
        Else
            shippingDetail.sngPallets = pallets.Value
        End If
        If String.IsNullOrEmpty(note) Then
            shippingDetail.SetNoteNull()
        Else
            shippingDetail.Note = note
        End If
        If expirationDate.HasValue Then
            shippingDetail.ExpirationDate = expirationDate.Value
        Else
            shippingDetail.SetExpirationDateNull()
        End If
        If String.IsNullOrEmpty(fullLPNNumber) Then
            shippingDetail.SetFullLPNNumberNull()
        Else
            shippingDetail.FullLPNNumber = fullLPNNumber
        End If

        details.AddShippingDetailsRow(shippingDetail)
        Dim rowsAffected As Integer = Adapter.Update(details)

        If rowsAffected = 1 Then
            Dim items As ItemsBLL = New ItemsBLL
            If fullLPNNumber.StartsWith(CustomersBLL.GetLPNPrefix(7)) Then
                items.UpdateStock(session, itemID.Value, quantity.Value * -1, False, session.GetObjectByKey(Of Shipping)(shippingID).ShippingLocation.Oid, lot, Integer.Parse(fullLPNNumber.Replace(CustomersBLL.GetLPNPrefix(7), "")))
            Else
                items.UpdateStock(session, itemID.Value, quantity.Value * -1, False, session.GetObjectByKey(Of Shipping)(shippingID).ShippingLocation.Oid)
            End If
        End If

        Return rowsAffected = 1

    End Function

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Delete, True)> _
    Public Function DeleteShippingDetail(ByVal session As Session, ByVal detailID As Integer) As Boolean

        Dim details As SPG.ShippingDetailsDataTable = Adapter.GetDetailsByDetailID(detailID)
        Dim rowsAffected As Integer = 0
        Dim itemID, quantity, locationID As Integer
        Dim lot, fullLPNNumber As String

        If details.Count = 1 Then
            Dim shippingDetail As SPG.ShippingDetailsRow = CType(details.Rows(0), SPG.ShippingDetailsRow)
            itemID = shippingDetail.ShipDetItemID
            quantity = shippingDetail.ShipDetDetQty
            lot = shippingDetail.ShipDetLot
            fullLPNNumber = shippingDetail.FullLPNNumber
            locationID = session.GetObjectByKey(Of Shipping)(shippingDetail.ShipDetMainID).ShippingLocation.Oid
            rowsAffected = Adapter.Delete(detailID, shippingDetail.ts)
        End If

        If rowsAffected = 1 Then
            Dim items As ItemsBLL = New ItemsBLL
            If fullLPNNumber.StartsWith(CustomersBLL.GetLPNPrefix(7)) Then
                items.UpdateStock(session, itemID, quantity, False, locationID, lot, Integer.Parse(fullLPNNumber.Replace(CustomersBLL.GetLPNPrefix(7), "")))
            Else
                items.UpdateStock(session, itemID, quantity, False, locationID)
            End If
        End If

        'Return true if precisely one row was deleted, otherwise return false.
        Return rowsAffected = 1

    End Function

End Class
