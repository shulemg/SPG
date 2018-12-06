Imports SuperiorPackGroup.SPGTableAdapters
Imports System.Text
Imports DevExpress.Xpo
Imports DXDAL.SPGData
Imports DevExpress.Persistent.Base
Imports DevExpress.Data.Filtering

<ComponentModel.DataObject()>
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

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Select, False)>
    Public Function GetReceivingDetailsByItemIDold(ByVal itemID As Integer) As SPG.ReceivingDetailsDataTable

        Return Adapter.GetReceivingDetailsByItemID(itemID)

    End Function
    Public Shared Function GetReceivingDetailsByItemID(ByVal itemID As Integer) As XPView


        Dim ReceivingXPView As New XPView(Session.DefaultSession, GetType(ReceivingDetail))

        ReceivingXPView.Properties.AddRange(New ViewProperty() {New ViewProperty("ReceiveDetID", SortDirection.None, ReceivingDetail.Fields.ReceivDetID, False, True),
                                                                      New ViewProperty("ReceiveMainID", SortDirection.Ascending, ReceivingDetail.Fields.ReceivMainID.ReceivID, False, True),
                                                                      New ViewProperty("ReceiveDetLot", SortDirection.None, ReceivingDetail.Fields.ReceivDetLot, False, True),
                                                                      New ViewProperty("ReceiveDetLPN", SortDirection.None, ReceivingDetail.Fields.ReceivDetLPN, False, True),
                                                                      New ViewProperty("ExpirationDate", SortDirection.None, ReceivingDetail.Fields.ExpirationDate, False, True),
                                                                      New ViewProperty("ReceiveDetQty", SortDirection.None, ReceivingDetail.Fields.ReceivDetQty, False, True),
                                                                      New ViewProperty("ReceiveBOL", SortDirection.None, ReceivingDetail.Fields.ReceivMainID.ReceivBOL, False, True),
                                                                      New ViewProperty("ReceiveDate", SortDirection.None, ReceivingDetail.Fields.ReceivMainID.ReceivDate, False, True)})

        ReceivingXPView.Criteria = CriteriaOperator.And(New BinaryOperator(ReceivingDetail.Fields.ReceivDetItemID.ItemType.PropertyName, "FG", BinaryOperatorType.NotEqual),
                                                                New BinaryOperator(ReceivingDetail.Fields.ReceivDetItemID.ItemID.PropertyName, itemID, BinaryOperatorType.Equal))

        Return ReceivingXPView
    End Function

    Private Sub UpdateAuditTrail(ByVal ModifiedRecord As ReceivingDetail, ByVal originalRecord As ReceivingDetail)

        'Dim builder As New StringBuilder(String.Empty)
        'Dim recordFields As Integer = (ModifiedRecord.ItemArray.Length - 1)
        'Dim i As Integer = 0
        'Do While (i <= recordFields)
        '    Try
        '        If IsDBNull(originalRecord(i)) Then
        '            If Not IsDBNull(ModifiedRecord.Item(i)) Then
        '                builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, "NULL", ModifiedRecord.Item(i)))
        '            End If
        '        ElseIf IsDBNull(ModifiedRecord.Item(i)) Then
        '            If Not IsDBNull(originalRecord(i)) Then
        '                builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, originalRecord(i), "NULL"))
        '            End If
        '        ElseIf CStr(ModifiedRecord.Item(i)) <> CStr(originalRecord(i)) Then
        '            builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, originalRecord(i), ModifiedRecord.Item(i)))
        '        End If
        '    Catch
        '    End Try
        '    i += 1
        'Loop
        'If (builder.Length > 2) Then
        '    builder.Length = (builder.Length - 2)
        '    AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(ModifiedRecord.Item(0), Integer), "ReceivingDetails", builder.ToString)
        'End If

    End Sub

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Select, False)>
    Public Function GetDetailsByReceivingID(ByVal receivingID As Integer) As SPG.ReceivingDetailsDataTable

        Return Adapter.GetDetailsByReceivingID(receivingID)

    End Function

    Public Function UpdateReceivingDetails(ByVal session As Session, ByVal detailID As Integer?, ByVal receivingID As Integer, ByVal itemID As Integer?, ByVal lot As String, ByVal quantity As Integer?,
             ByVal units As Integer?, ByVal LPN As Integer?, ByVal expirationDate As Date?) As Integer

        If Not itemID.HasValue Then
            Throw New ApplicationException("You must provide receiving item.")
        End If

        If Not quantity.HasValue OrElse Not units.HasValue Then
            Throw New ApplicationException("You must provide the amount of quamtity\units received.")
        End If

        If LPN Is Nothing Then
            Throw New ApplicationException("LPN is blank.")
        End If

        Dim item As Items = session.GetObjectByKey(Of Items)(itemID.Value, True)

        If Not LotCodeValidator.ValidateByItem(item, lot, True) Then
            Throw New ApplicationException("Item " & item.ItemCode & " & lot # " & lot & " is invalid" & vbNewLine & "You must provide a valid lot.")
        End If


        Dim detail As ReceivingDetail = session.GetObjectByKey(Of ReceivingDetail)(detailID)

        If detail Is Nothing Then
            'It is a new Detail
            Return Me.InsertDetails(session, receivingID, item, lot, quantity, units, LPN, expirationDate)
        End If

        Dim itemChanged As Boolean = False

        Dim originalDetail As ReceivingDetail
        Dim cloner As New Cloner
        originalDetail = CType(cloner.CloneTo(detail, GetType(ReceivingDetail)), ReceivingDetail)

        If originalDetail.ReceivDetItemID.ItemID <> itemID Then
            itemChanged = True
        End If

        detail.ReceivDetItemID = item
        detail.intUnits = units.Value
        detail.ReceivDetQty = quantity.Value
        detail.ExpirationDate = expirationDate
        detail.ReceivDetLPN = LPN
        detail.ReceivDetLot = lot


        If Not IsNothing(originalDetail) Then
            Me.UpdateAuditTrail(detail, originalDetail)
        End If

        session.Save(detail)

        If Not detail.Equals(originalDetail) Then
            Dim items As ItemsBLL = New ItemsBLL
            Dim locationID As Integer = session.GetObjectByKey(Of Receiving)(receivingID).ReceivingLocation.Oid
            items.UpdateStock(session, originalDetail.ReceivDetItemID.ItemID, Nothing, originalDetail.ReceivDetQty * -1, False, locationID, lot, LPN)

            items.UpdateStock(session, itemID.Value, quantity.Value, False, locationID, lot, LPN, expirationDate)
        End If

        Return detail.ReceivDetID

    End Function

    Public Function InsertDetails(ByVal session As Session, ByVal receivingID As Integer, ByVal item As Items, ByVal lot As String, ByVal quantity As Integer?,
             ByVal units As Integer?, ByVal LPN As Integer?, ByVal expirationDate As Date?) As Integer

        Dim detail As ReceivingDetail = New ReceivingDetail(session)

        detail.ReceivMainID = session.GetObjectByKey(Of Receiving)(receivingID)
        detail.ReceivDetItemID = item
        detail.intUnits = units.Value
        detail.ReceivDetQty = quantity.Value
        detail.ExpirationDate = expirationDate
        detail.ReceivDetLPN = LPN
        detail.ReceivDetLot = lot

        detail.Save()


        Dim items As ItemsBLL = New ItemsBLL
        Dim locationID As Integer = session.GetObjectByKey(Of Receiving)(receivingID).ReceivingLocation.Oid

        items.UpdateStock(session, item.ItemID, quantity.Value, False, locationID, lot, LPN, expirationDate)

        Return detail.ReceivDetID

    End Function

    Public Function DeleteReceivingDetail(ByVal session As Session, ByVal detailID As Integer) As Boolean

        Dim detail As ReceivingDetail = session.GetObjectByKey(Of ReceivingDetail)(detailID)
        Dim rowsAffected As Integer = 0
        Dim itemID, quantity, locationID, units As Integer
        Dim lpn As Integer?
        Dim lot As String

        If Not detail Is Nothing Then
            itemID = detail.ReceivDetItemID.ItemID
            units = detail.intUnits
            quantity = detail.ReceivDetQty
            locationID = session.GetObjectByKey(Of Receiving)(detail.ReceivMainID.ReceivID).ReceivingLocation.Oid
            lpn = detail.ReceivDetLPN
            lot = detail.ReceivDetLot
            session.Delete(detail)
        End If

        Dim items As ItemsBLL = New ItemsBLL
        items.UpdateStock(session, itemID, quantity * -1, False, locationID, lot, lpn)

        Return True

    End Function

    Private Function GetNextLPN(LPNcount As Integer) As Integer
        Dim nextLPN As Integer = 0
        Dim customer As Customers = Session.DefaultSession.GetObjectByKey(Of Customers)(7)

        customer.Reload()
        If customer.NextLPNNumber > 0 Then
            nextLPN = customer.NextLPNNumber
            customer.NextLPNNumber += LPNcount
            customer.Save()
        Else
            If customer.FirstLPNNumber.HasValue Then
                nextLPN = customer.FirstLPNNumber.Value
                customer.NextLPNNumber = nextLPN + LPNcount
                customer.Save()
            End If
        End If

        If nextLPN > customer.LastLPNNumber Then
            MessageBox.Show("You ran out of LPN numbers, you must provide a different range of numbers before creating a new LPN number")
            nextLPN = 0
        End If

        If nextLPN = customer.LastLPNNumber Then
            MessageBox.Show("You used now your last LPN number, please provide a different range of numbers before creating a new LPN number")
        End If

        Return nextLPN

    End Function

End Class
