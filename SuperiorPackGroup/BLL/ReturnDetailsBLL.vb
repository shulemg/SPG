﻿Imports SuperiorPackGroup.SPGTableAdapters
Imports System.Text
Imports DevExpress.Xpo
Imports DXDAL.SPGData
Imports DevExpress.Data.Filtering

<ComponentModel.DataObject()> _
Public Class ReturnDetailsBLL

    Private m_ReturnDetailsTableAdapter As ReturnDetTableAdapter = Nothing
    Public ReadOnly Property Adapter() As ReturnDetTableAdapter

        Get
            If m_ReturnDetailsTableAdapter Is Nothing Then
                m_ReturnDetailsTableAdapter = New ReturnDetTableAdapter()
                m_ReturnDetailsTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return m_ReturnDetailsTableAdapter
        End Get

    End Property

    Private Sub UpdateAuditTrail(ByVal ModifiedRecord As SPG.ReturnDetRow, ByVal originalRecord As Object())

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
            AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(ModifiedRecord.Item(0), Integer), "ReturnDetails", builder.ToString)
        End If

    End Sub

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetDetailsByReceivingID(ByVal receivingID As Integer) As SPG.ReturnDetDataTable

        Return Adapter.GetReturnDetByReceivingID(receivingID)

    End Function

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateReturnDetails(ByVal session As Session, ByVal detailID As Integer?, ByVal receivingID As Integer, ByVal itemID As Integer?, ByVal lot As String, ByVal quantity As Integer?, _
                                        ByVal units As Integer?, ByVal pallets As Single?, ByVal reason As String, ByVal expirationDate As Date?) As Boolean

        If Not itemID.HasValue Then
            Throw New ApplicationException("You must provide return item.")
        End If

        If Not quantity.HasValue Then
            Throw New ApplicationException("You must provide the Quantity returned.")
        End If

        Dim details As SPG.ReturnDetDataTable = Adapter.GetReturnDetByID(detailID.Value)

        If details.Count = 0 Then
            'It is a new Detail
            Return Me.InsertDetails(session, receivingID, itemID, lot, quantity, units, pallets, reason, expirationDate)
        End If

        Dim returnDetail As SPG.ReturnDetRow = details(0)
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
        originalQuantity = returnDetail.ReturnDetQty
        newQuantity = returnDetail.ReturnDetQty - quantity.Value
        returnDetail.ReturnDetQty = quantity.Value
        If Not units.HasValue Then
            returnDetail.SetintUnitsNull()
        Else
            returnDetail.intUnits = units.Value
        End If
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
            Dim locationID As Integer = session.GetObjectByKey(Of Receiving)(receivingID).ReceivingLocation.Oid
            If itemChanged = True Then
                items.UpdateStock(session, originalItem, originalQuantity * -1, False, locationID)
                items.UpdateStock(session, itemID.Value, quantity.Value, False, locationID)
            Else
                If newQuantity <> 0 Then
                    items.UpdateStock(session, itemID.Value, newQuantity * -1, False, locationID)
                End If
            End If
        End If

        Return rowsAffected = 1

    End Function

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Insert, True)> _
    Public Function InsertDetails(ByVal session As Session, ByVal receivingID As Integer, ByVal itemID As Integer?, ByVal lot As String, ByVal quantity As Integer?, ByVal units As Integer?, _
                                  ByVal pallets As Single?, ByVal reason As String, ByVal expirationDate As Date?) As Boolean

        Dim details As SPG.ReturnDetDataTable = New SPG.ReturnDetDataTable
        Dim returnDetail As SPG.ReturnDetRow = details.NewReturnDetRow()

        returnDetail.ReceiveMainID = receivingID
        returnDetail.ReturnDetItemID = itemID.Value
        If String.IsNullOrEmpty(lot) Then
            returnDetail.SetReturnDetLotNull()
        Else
            returnDetail.ReturnDetLot = lot
        End If
        returnDetail.ReturnDetQty = quantity.Value
        If Not units.HasValue Then
            returnDetail.SetintUnitsNull()
        Else
            returnDetail.intUnits = units.Value
        End If
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

        details.AddReturnDetRow(returnDetail)
        Dim rowsAffected As Integer = Adapter.Update(details)

        If rowsAffected = 1 Then
            Dim items As ItemsBLL = New ItemsBLL
            items.UpdateStock(session, itemID.Value, quantity.Value, False, session.GetObjectByKey(Of Receiving)(receivingID).ReceivingLocation.Oid)
        End If

        Return rowsAffected = 1

    End Function

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Delete, True)> _
    Public Function DeleteReturnDetail(ByVal session As Session, ByVal detailID As Integer) As Boolean

        Dim details As SPG.ReturnDetDataTable = Adapter.GetReturnDetByID(detailID)
        Dim rowsAffected As Integer = 0
        Dim itemID, quantity, locationID As Integer

        If details.Count = 1 Then
            Dim returnDetail As SPG.ReturnDetRow = CType(details.Rows(0), SPG.ReturnDetRow)
            itemID = returnDetail.ReturnDetItemID
            quantity = returnDetail.ReturnDetQty
            locationID = session.GetObjectByKey(Of Receiving)(returnDetail.ReceiveMainID).ReceivingLocation.Oid
            rowsAffected = Adapter.Delete(detailID, returnDetail.ts)
        End If

        If rowsAffected = 1 Then
            Dim items As ItemsBLL = New ItemsBLL
            items.UpdateStock(session, itemID, quantity * -1, False, locationID)
        End If

        'Return true if precisely one row was deleted, otherwise return false.
        Return rowsAffected = 1

    End Function

    Public Shared Function GetReceivingReturnDetailsByItemID(ByVal itemID As Integer) As XPView

        Dim ReceivingReturnXPView As New XPView(Session.DefaultSession, GetType(ReceivingDetail))

        ReceivingReturnXPView.Properties.AddRange(New ViewProperty() {New ViewProperty("ReceiveDetID", SortDirection.None, ReceivingDetail.Fields.ReceivDetID, False, True),
                                                                      New ViewProperty("ReceiveMainID", SortDirection.Ascending, ReceivingDetail.Fields.ReceivMainID.ReceivID, False, True),
                                                                      New ViewProperty("ReceiveDetLot", SortDirection.None, ReceivingDetail.Fields.ReceivDetLot, False, True),
                                                                      New ViewProperty("ReceiveDetLPN", SortDirection.None, ReceivingDetail.Fields.ReceivDetLPN, False, True),
                                                                      New ViewProperty("ExpirationDate", SortDirection.None, ReceivingDetail.Fields.ExpirationDate, False, True),
                                                                      New ViewProperty("ReceiveDetQty", SortDirection.None, ReceivingDetail.Fields.ReceivDetQty, False, True),
                                                                      New ViewProperty("ReceiveBOL", SortDirection.None, ReceivingDetail.Fields.ReceivMainID.ReceivBOL, False, True),
                                                                      New ViewProperty("ReceiveDate", SortDirection.None, ReceivingDetail.Fields.ReceivMainID.ReceivDate, False, True)})

        ReceivingReturnXPView.Criteria = CriteriaOperator.And(New BinaryOperator(ReceivingDetail.Fields.ReceivDetItemID.ItemType.PropertyName, "FG", BinaryOperatorType.Equal),
                                                                New BinaryOperator(ReceivingDetail.Fields.ReceivDetItemID.ItemID.PropertyName, itemID, BinaryOperatorType.Equal))

        Return ReceivingReturnXPView

    End Function

End Class

