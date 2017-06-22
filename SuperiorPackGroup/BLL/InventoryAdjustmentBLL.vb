Imports SuperiorPackGroup.SPGTableAdapters
Imports System.Text
Imports DevExpress.Xpo
Imports DXDAL.SPGData
Imports DevExpress.Data.Filtering

<System.ComponentModel.DataObject()> _
Public Class InventoryAdjustmentBLL

    Private m_InventoryAdjustmentTableAdapter As InventoryAdjustmentTableAdapter
    Private ReadOnly changes As New List(Of Change)()

    Public ReadOnly Property Adapter() As InventoryAdjustmentTableAdapter

        Get
            If m_InventoryAdjustmentTableAdapter Is Nothing Then
                m_InventoryAdjustmentTableAdapter = New InventoryAdjustmentTableAdapter()
                m_InventoryAdjustmentTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return m_InventoryAdjustmentTableAdapter
        End Get

    End Property

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetAdjustmentView(ByVal fromDate As Nullable(Of Date), ByVal toDate As Nullable(Of Date), ByVal customer As Nullable(Of Integer), _
            ByVal item As Nullable(Of Integer)) As SPG.InventoryAdjustmentDataTable

        Return Adapter.GetAdjustmentView(fromDate, toDate, customer, item)

    End Function

    Private Sub UpdateAuditTrail()

        Dim builder As New StringBuilder(String.Empty)

        For Each update As Change In changes
            builder.Append(String.Format("{0}:{1}({2}); ", update.PropertyName, update.PrevValue, update.NewValue))
        Next

        If (builder.Length > 2) Then
            builder.Length = (builder.Length - 2)
            AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(changes(0).NewValue, Integer), "InventoryAdjustment", builder.ToString)
        End If

        changes.Clear()

    End Sub

    'Private Sub UpdateAuditTrail(ByVal ModifiedRecord As SPG.InventoryAdjustmentRow, ByVal originalRecord As Object())

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
    '        AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(ModifiedRecord.Item(0), Integer), "InventoryAdjustment", builder.ToString)
    '    End If

    'End Sub

    Public Shared Function GetNewInventoryAdjustmentID() As Integer

        Using conn As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.UserConnectionString)
            Dim myCommand As New SqlClient.SqlCommand("dbo.spNewIDSafe", conn)
            Dim myNewID As New SqlClient.SqlParameter("@nRetVal", SqlDbType.Int)
            myCommand.CommandType = CommandType.StoredProcedure
            myNewID.Direction = ParameterDirection.Output
            myCommand.Parameters.AddWithValue("@cName", "tblInventoryAdjustment")
            myCommand.Parameters.AddWithValue("@cPkField", "AdjustmentID")
            myCommand.Parameters.Add(myNewID)
            conn.Open()
            myCommand.ExecuteNonQuery()
            Return CType(myNewID.Value, Integer)
        End Using

    End Function

    Private Sub SetField(propertyName As String, oldValue As Object, newValue As Object, ByVal adjustment As InventoryAdjustment)

        If (oldValue IsNot Nothing Or newValue IsNot Nothing) AndAlso
            ((oldValue IsNot Nothing And newValue Is Nothing) OrElse (newValue IsNot Nothing And oldValue Is Nothing) OrElse oldValue.ToString <> newValue.ToString) Then
            adjustment.SetMemberValue(propertyName, newValue)
            Dim change As New Change() With {.PropertyName = propertyName, .PrevValue = If(oldValue Is Nothing, "<NULL>", oldValue.ToString()), .NewValue = If(newValue Is Nothing, "<NULL>", newValue.ToString())}
            changes.Add(change)
        End If

    End Sub

    Private Sub SetInventoryAdjustmentFields(ByVal adjustmentDate As Date, ByVal customer As Integer, ByVal item As Integer, ByVal originalQuantity As Single, ByVal newQuantity As Single, ByVal reason As String,
                                             ByVal locationID As Integer, ByVal adjustment As InventoryAdjustment)

        SetField(InventoryAdjustment.Fields.AdjustmentDate.PropertyName, adjustment.AdjustmentDate, CDate(Format(adjustmentDate, "D")), adjustment)
        SetField(InventoryAdjustment.Fields.Customer.PropertyName, adjustment.Customer, Session.DefaultSession.GetObjectByKey(Of Customers)(customer), adjustment)
        SetField(InventoryAdjustment.Fields.AdjustmentItem.PropertyName, adjustment.AdjustmentItem, Session.DefaultSession.GetObjectByKey(Of Items)(item), adjustment)
        SetField(InventoryAdjustment.Fields.OriginalQuantity.PropertyName, adjustment.OriginalQuantity, originalQuantity, adjustment)
        SetField(InventoryAdjustment.Fields.NewCount.PropertyName, adjustment.NewCount, newQuantity, adjustment)
        SetField(InventoryAdjustment.Fields.Reason.PropertyName, adjustment.Reason, reason, adjustment)
        SetField(InventoryAdjustment.Fields.InventoryLocation.PropertyName, adjustment.InventoryLocation, Session.DefaultSession.GetObjectByKey(Of Locations)(locationID), adjustment)

    End Sub

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateInventoryAdjustment(ByVal adjustmentID As Integer, ByVal adjustmentDate As Date, ByVal customer As Integer, ByVal item As Integer, ByVal originalQuantity As Single, ByVal newQuantity As Single, ByVal reason As String,
                                              ByVal locationID As Integer) As Boolean

        'Dim adjustments As SPG.InventoryAdjustmentDataTable = Adapter.GetInventoryAdjustmentByID(adjustmentID)

        'If adjustments.Count = 0 Then
        Dim change As Change
        Dim adjustment As InventoryAdjustment = Session.DefaultSession.GetObjectByKey(Of InventoryAdjustment)(adjustmentID)

        If adjustment Is Nothing Then
            'It is a new Production Record
            change = New Change() With {.PropertyName = InventoryAdjustment.Fields.AdjustmentID.PropertyName, .PrevValue = "<NULL>", .NewValue = adjustmentID.ToString}
            changes.Add(change)
            Return InsertInventoryAdjustment(adjustmentID, adjustmentDate, customer, item, originalQuantity, newQuantity, reason, locationID)
        End If

        'Dim adjustment As SPG.InventoryAdjustmentRow = adjustments(0)
        Dim originalItem As Integer = adjustment.AdjustmentItem.ItemID
        Dim originalNewQuantity, newNewQuantity As Single
        Dim itemChanged As Boolean

        'Dim originalRecord As Object() = adjustment.ItemArray

        'adjustment.AdjustmentDate = CDate(Format(adjustmentDate, "D"))
        'adjustment.Customer = customer
        If originalItem <> item Then
            itemChanged = True
        Else
            itemChanged = False
        End If
        'adjustment.ItemID = item
        Dim originalOriginalQuantity As Single = adjustment.OriginalQuantity
        originalNewQuantity = adjustment.NewCount
        newNewQuantity = newQuantity - originalNewQuantity
        'adjustment.OriginalQuantity = originalQuantity
        'adjustment.NewCount = newQuantity
        'adjustment.Reason = reason

        change = New Change() With {.PropertyName = InventoryAdjustment.Fields.AdjustmentID.PropertyName, .PrevValue = adjustment.AdjustmentID.ToString, .NewValue = adjustment.AdjustmentID.ToString}
        changes.Add(change)
        SetInventoryAdjustmentFields(adjustmentDate, customer, item, originalQuantity, newQuantity, reason, locationID, adjustment)

        Try
            adjustment.Save()
        Catch ex As Exception
            Return False
        End Try

        UpdateAuditTrail()

        'If Not IsNothing(originalRecord) Then
        '    UpdateAuditTrail(adjustment, originalRecord)
        'End If

        'Dim rowsAffected As Integer = Adapter.Update(adjustment)

        'If rowsAffected = 1 Then
        Dim items As ItemsBLL = New ItemsBLL
        If itemChanged = True Then
            items.UpdateStock(Session.DefaultSession, originalItem, (originalNewQuantity - originalOriginalQuantity) * -1, False, locationID)
            items.UpdateStock(Session.DefaultSession, item, newQuantity - originalQuantity, False, locationID)
        Else
            If newNewQuantity <> 0 Then    'there was a change in the quantity
                items.UpdateStock(Session.DefaultSession, item, newNewQuantity, False, locationID)
            End If
        End If
        'End If

        'Return rowsAffected = 1
        Return True

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, True)> _
    Public Function InsertInventoryAdjustment(ByVal adjustmentID As Integer, ByVal adjustmentDate As Date, ByVal customer As Integer, ByVal item As Integer, ByVal originalQuantity As Single, ByVal newQuantity As Single, ByVal reason As String,
                                              ByVal locationID As Integer) As Boolean

        'Dim adjustments As SPG.InventoryAdjustmentDataTable = New SPG.InventoryAdjustmentDataTable
        'Dim adjustment As SPG.InventoryAdjustmentRow = adjustments.NewInventoryAdjustmentRow()

        'adjustment.AdjustmentID = adjustmentID

        Dim adjustment As InventoryAdjustment = New InventoryAdjustment(Session.DefaultSession) With {.AdjustmentID = adjustmentID}

        'adjustment.AdjustmentDate = CDate(Format(adjustmentDate, "D"))
        'adjustment.Customer = customer
        'adjustment.ItemID = item
        'adjustment.OriginalQuantity = originalQuantity
        'adjustment.NewCount = newQuantity
        'adjustment.Reason = reason

        SetInventoryAdjustmentFields(adjustmentDate, customer, item, originalQuantity, newQuantity, reason, locationID, adjustment)
        adjustment.strEnteredBy = My.Settings.UserName
        adjustment.dtmEnteredOn = Now

        Try
            adjustment.Save()
        Catch ex As Exception
            Return False
        End Try

        'adjustments.AddInventoryAdjustmentRow(adjustment)
        'Dim rowsAffected As Integer = Adapter.Update(adjustments)

        'If rowsAffected = 1 Then
        Dim items As ItemsBLL = New ItemsBLL
        items.UpdateStock(Session.DefaultSession, item, newQuantity - originalQuantity, False, locationID)
        'End If

        'Return rowsAffected = 1
        Return True

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetAdjustmentByID(ByVal adjustmentID As Integer) As SPG.InventoryAdjustmentDataTable

        Return Adapter.GetInventoryAdjustmentByID(adjustmentID)

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, True)> _
    Public Shared Function DeleteInventoryAdjustment(ByVal id As Integer) As Boolean

        'Dim adjustments As SPG.InventoryAdjustmentDataTable = Adapter.GetInventoryAdjustmentByID(id)
        'Dim rowsAffected As Integer = 0
        Dim item, locationID As Integer
        Dim quantity As Single

        'If adjustments.Count = 1 Then
        '    Dim adjustment As SPG.InventoryAdjustmentRow = CType(adjustments.Rows(0), SPG.InventoryAdjustmentRow)

        Dim adjustment As InventoryAdjustment = Session.DefaultSession.GetObjectByKey(Of InventoryAdjustment)(id)

        If adjustment Is Nothing Then
            Return False
        End If
        item = adjustment.AdjustmentItem.ItemID
        quantity = adjustment.OriginalQuantity - adjustment.NewCount
        locationID = adjustment.InventoryLocation.Oid
        'rowsAffected = Adapter.Delete(id, adjustment.rv)
        'End If

        Try
            adjustment.Delete()
            Dim items As ItemsBLL = New ItemsBLL
            items.UpdateStock(Session.DefaultSession, item, quantity, False, locationID)
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Shared Function GetAdjustmentsByItemID(ByVal itemID As Integer) As XPView

        Dim AdjustmentXPView As New XPView(Session.DefaultSession, GetType(InventoryAdjustment))

        AdjustmentXPView.Properties.AddRange(New ViewProperty() {New ViewProperty("AdjustmentID", SortDirection.None, InventoryAdjustment.Fields.AdjustmentID, False, True),
                                                                 New ViewProperty("AdjustmentDate", SortDirection.Ascending, InventoryAdjustment.Fields.AdjustmentDate, False, True),
                                                                 New ViewProperty("OriginalQuantity", SortDirection.None, InventoryAdjustment.Fields.OriginalQuantity, False, True),
                                                                 New ViewProperty("NewCount", SortDirection.None, InventoryAdjustment.Fields.NewCount, False, True),
                                                                 New ViewProperty("AdjustmentQuantity", SortDirection.None, InventoryAdjustment.Fields.NewCount - InventoryAdjustment.Fields.OriginalQuantity, False, True),
                                                                 New ViewProperty("Reason", SortDirection.None, InventoryAdjustment.Fields.Reason, False, True)})

        AdjustmentXPView.Criteria = New BinaryOperator(InventoryAdjustment.Fields.AdjustmentItem.ItemID.PropertyName, itemID, BinaryOperatorType.Equal)

        Return AdjustmentXPView

    End Function

End Class
