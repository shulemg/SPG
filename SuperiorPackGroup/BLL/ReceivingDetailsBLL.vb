Imports SuperiorPackGroup.SPGTableAdapters
Imports System.Text
Imports DevExpress.Xpo
Imports DXDAL.SPGData

<System.ComponentModel.DataObject()> _
Public Class ReceivingDetailsBLL

    Private m_ReceivingDetailsTableAdapter As ReceivingDetailsTableAdapter = Nothing
    Public ReadOnly Property Adapter() As ReceivingDetailsTableAdapter

        Get
            If m_ReceivingDetailsTableAdapter Is Nothing Then
                m_ReceivingDetailsTableAdapter = New ReceivingDetailsTableAdapter()
                m_ReceivingDetailsTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return m_ReceivingDetailsTableAdapter
        End Get

    End Property

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetReceivingDetailsByItemID(ByVal itemID As Integer) As SPG.ReceivingDetailsDataTable

        Return Adapter.GetReceivingDetailsByItemID(itemID)

    End Function

    Private Sub UpdateAuditTrail(ByVal ModifiedRecord As SPG.ReceivingDetailsRow, ByVal originalRecord As Object())

        Dim builder As New StringBuilder(String.Empty)
        Dim recordFields As Integer = (ModifiedRecord.ItemArray.Length - 1)
        Dim i As Integer = 0
        Do While (i <= recordFields)
            Try
                If IsDBNull(originalRecord(i)) Then
                    If Not IsDBNull(ModifiedRecord.Item(i)) Then
                        builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, "NULL", ModifiedRecord.Item(i)))
                    End If
                ElseIf Information.IsDBNull(ModifiedRecord.Item(i)) Then
                    If Not Information.IsDBNull(originalRecord(i)) Then
                        builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, originalRecord(i), "NULL"))
                    End If
                ElseIf CStr(ModifiedRecord.Item(i)) <> CStr(originalRecord(i)) Then
                    builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, originalRecord(i), ModifiedRecord.Item(i)))
                End If
            Catch
            End Try
            i += 1
        Loop
        If (builder.Length > 2) Then
            builder.Length = (builder.Length - 2)
            AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(ModifiedRecord.Item(0), Integer), "ReceivingDetails", builder.ToString)
        End If

    End Sub

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetDetailsByReceivingID(ByVal receivingID As Integer) As SPG.ReceivingDetailsDataTable

        Return Adapter.GetDetailsByReceivingID(receivingID)

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateReceivingDetails(ByVal session As Session, ByVal detailID As Nullable(Of Integer), ByVal receivingID As Integer, ByVal itemID As Nullable(Of Integer), _
            ByVal lot As String, ByVal quantity As Nullable(Of Integer), ByVal units As Nullable(Of Integer), ByVal pallets As Nullable(Of Single), ByVal expirationDate As Date?) As Boolean

        If Not itemID.HasValue Then
            Throw New ApplicationException("You must provide receiving item.")
        End If

        If Not quantity.HasValue OrElse Not units.HasValue Then
            Throw New ApplicationException("You must provide the amount of quamtity\units received.")
        End If

        Dim details As SPG.ReceivingDetailsDataTable = Adapter.GetDetailsByDetailID(detailID.Value)

        If details.Count = 0 Then
            'It is a new Detail
            Return Me.InsertDetails(session, receivingID, itemID, lot, quantity, units, pallets, expirationDate)
        End If

        Dim receivingDetail As SPG.ReceivingDetailsRow = details(0)
        Dim originalItem, originalQuantity, newQuantity As Integer
        Dim itemChanged As Boolean = False

        Dim originalRecord As Object() = Nothing
        originalRecord = receivingDetail.ItemArray

        originalItem = receivingDetail.ReceivDetItemID
        If originalItem <> itemID.Value Then
            itemChanged = True
        End If
        receivingDetail.ReceivDetItemID = itemID.Value
        If String.IsNullOrEmpty(lot) Then
            receivingDetail.SetReceivDetLotNull()
        Else
            receivingDetail.ReceivDetLot = lot
        End If
        receivingDetail.ReceivDetQty = quantity.Value

        originalQuantity = receivingDetail.intUnits
        newQuantity = receivingDetail.intUnits - units.Value
        receivingDetail.intUnits = units.Value
        If Not pallets.HasValue Then
            receivingDetail.SetsngPalletsNull()
        Else
            receivingDetail.sngPallets = pallets.Value
        End If
        If expirationDate.HasValue Then
            receivingDetail.ExpirationDate = expirationDate.Value
        Else
            receivingDetail.SetExpirationDateNull()
        End If

        If Not IsNothing(originalRecord) Then
            Me.UpdateAuditTrail(receivingDetail, originalRecord)
        End If

        Dim rowsAffected As Integer = Adapter.Update(receivingDetail)

        If rowsAffected = 1 Then
            Dim items As ItemsBLL = New ItemsBLL
            Dim locationID As Integer = session.GetObjectByKey(Of Receiving)(receivingID).ReceivingLocation.Oid
            If itemChanged = True Then
                items.UpdateStock(session, originalItem, originalQuantity * -1, False, locationID)
                items.UpdateStock(session, itemID.Value, units.Value, False, locationID)
            Else
                If newQuantity <> 0 Then
                    items.UpdateStock(session, itemID.Value, newQuantity * -1, False, locationID)
                End If
            End If
        End If

        Return rowsAffected = 1

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, True)> _
    Public Function InsertDetails(ByVal session As Session, ByVal receivingID As Integer, ByVal itemID As Nullable(Of Integer), ByVal lot As String, ByVal quantity As Nullable(Of Integer), _
            ByVal units As Nullable(Of Integer), ByVal pallets As Nullable(Of Single), ByVal expirationDate As Date?) As Boolean

        Dim details As SPG.ReceivingDetailsDataTable = New SPG.ReceivingDetailsDataTable
        Dim receivingDetail As SPG.ReceivingDetailsRow = details.NewReceivingDetailsRow()

        receivingDetail.ReceivMainID = receivingID
        receivingDetail.ReceivDetItemID = itemID.Value
        If String.IsNullOrEmpty(lot) Then
            receivingDetail.SetReceivDetLotNull()
        Else
            receivingDetail.ReceivDetLot = lot
        End If
        receivingDetail.ReceivDetQty = quantity.Value
        receivingDetail.intUnits = units.Value
        If Not pallets.HasValue Then
            receivingDetail.SetsngPalletsNull()
        Else
            receivingDetail.sngPallets = pallets.Value
        End If
        If expirationDate.HasValue Then
            receivingDetail.ExpirationDate = expirationDate.Value
        Else
            receivingDetail.SetExpirationDateNull()
        End If
        details.AddReceivingDetailsRow(receivingDetail)
        Dim rowsAffected As Integer = Adapter.Update(details)

        If rowsAffected = 1 Then
            Dim items As ItemsBLL = New ItemsBLL
            items.UpdateStock(session, itemID.Value, units.Value, False, session.GetObjectByKey(Of Receiving)(receivingID).ReceivingLocation.Oid)
        End If

        Return rowsAffected = 1

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, True)> _
    Public Function DeleteReceivingDetail(ByVal session As Session, ByVal detailID As Integer) As Boolean

        Dim details As SPG.ReceivingDetailsDataTable = Adapter.GetDetailsByDetailID(detailID)
        Dim rowsAffected As Integer = 0
        Dim itemID, quantity, locationID As Integer

        If details.Count = 1 Then
            Dim receivingDetail As SPG.ReceivingDetailsRow = CType(details.Rows(0), SPG.ReceivingDetailsRow)
            itemID = receivingDetail.ReceivDetItemID
            quantity = receivingDetail.intUnits
            locationID = session.GetObjectByKey(Of Receiving)(receivingDetail.ReceivMainID).ReceivingLocation.Oid
            rowsAffected = Adapter.Delete(detailID, receivingDetail.ts)
        End If

        If rowsAffected = 1 Then
            Dim items As ItemsBLL = New ItemsBLL
            items.UpdateStock(session, itemID, quantity * -1, False, locationID)
        End If

        'Return true if precisely one row was deleted, otherwise return false.
        Return rowsAffected = 1

    End Function

End Class
