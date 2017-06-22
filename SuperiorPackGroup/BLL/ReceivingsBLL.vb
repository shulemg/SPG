Imports SuperiorPackGroup.SPGTableAdapters
Imports System.Text
Imports DXDAL.SPGData
Imports DevExpress.Xpo

<System.ComponentModel.DataObject()> _
Public Class ReceivingsBLL

    Private m_ReceivingsTableAdapter As ReceivingsTableAdapter = Nothing
    Private changes As New List(Of Change)()

    Public ReadOnly Property Adapter() As ReceivingsTableAdapter

        Get
            If m_ReceivingsTableAdapter Is Nothing Then
                m_ReceivingsTableAdapter = New ReceivingsTableAdapter()
                m_ReceivingsTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return m_ReceivingsTableAdapter
        End Get

    End Property

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetReceivingsByCustomerID(ByVal customerID As Integer) As SPG.ReceivingsDataTable

        Return Adapter.GetReceivingsByCustomerID(customerID)

    End Function

    Private Sub UpdateAuditTrail()

        Dim builder As New StringBuilder(String.Empty)

        For Each update As Change In changes
            builder.Append(String.Format("{0}:{1}({2}); ", update.PropertyName, update.PrevValue, update.NewValue))
        Next

        If (builder.Length > 2) Then
            builder.Length = (builder.Length - 2)
            AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(changes(0).NewValue, Integer), "Receivings", builder.ToString)
        End If

        changes.Clear()

    End Sub

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetIDAndBOLByCustomerAndDate(ByVal customerID As Nullable(Of Integer), ByVal fromDate As Nullable(Of Date), ByVal toDate As Nullable(Of Date)) _
            As SPG.ReceivingsDataTable

        Return Adapter.GetIDAndBOLByCustomerAndDate(customerID, fromDate, toDate)

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function GetReceivings() As SPG.ReceivingsDataTable

        Return Adapter.GetReceivings()

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetReceivingsByID(ByVal receiveID As Integer) As SPG.ReceivingsDataTable

        Return Adapter.GetReceivingsByID(receiveID)

    End Function

    Private Sub SetField(propertyName As String, oldValue As Object, newValue As Object, ByVal receivingRecord As Receiving)

        If (oldValue IsNot Nothing Or newValue IsNot Nothing) AndAlso
            ((oldValue IsNot Nothing And newValue Is Nothing) OrElse (newValue IsNot Nothing And oldValue Is Nothing) OrElse oldValue.ToString <> newValue.ToString) Then
            receivingRecord.SetMemberValue(propertyName, newValue)
            Dim change As New Change() With {.PropertyName = propertyName, .PrevValue = If(oldValue Is Nothing, "<NULL>", oldValue.ToString()), .NewValue = If(newValue Is Nothing, "<NULL>", newValue.ToString())}
            changes.Add(change)
        End If

    End Sub

    Private Sub SetReceivingFields(ByVal receivDate As Nullable(Of Date), ByVal receivCarrierID As Nullable(Of Integer), ByVal receivCustID As Nullable(Of Integer), ByVal receivBol As String, _
                                          ByVal strVendor As Integer?, ByVal sngSkits As Nullable(Of Single), ByVal sngTotalPallets As Nullable(Of Single), ByVal strPO As String, ByVal intShiftID As Nullable(Of Integer), _
                                          ByVal strTrailer As String, ByVal strSeal As String, ByVal notes As String, ByVal unloadedBy As Integer?, ByVal checkedBy As Integer?, ByVal wheelsChocked As Integer?,
                                          ByVal startTime As DateTime?, ByVal finishTime As DateTime?, ByVal temparature As Double?, ByVal physicalCondition As Integer?, ByVal loadCondition As Integer?, ByVal foreignSubstance As Integer?,
                                          ByVal insectActivity As Integer?, ByVal correctPallets As Integer?, ByVal locationID As Integer, ByVal receivingRecord As Receiving)

        SetField(Receiving.Fields.ReceivDate.PropertyName, receivingRecord.ReceivDate, If(receivDate.HasValue, receivDate.Value, Today), receivingRecord)
        SetField(Receiving.Fields.ReceivCarrierID.PropertyName, receivingRecord.ReceivCarrierID, Session.DefaultSession.GetObjectByKey(Of Carriers)(receivCarrierID.Value), receivingRecord)
        SetField(Receiving.Fields.ReceivCustID.PropertyName, receivingRecord.ReceivCustID, Session.DefaultSession.GetObjectByKey(Of Customers)(receivCustID.Value), receivingRecord)
        SetField(Receiving.Fields.ReceivBOL.PropertyName, receivingRecord.ReceivBOL, receivBol, receivingRecord)
        SetField(Receiving.Fields.strVendor.PropertyName, receivingRecord.strVendor, If(strVendor.HasValue, Session.DefaultSession.GetObjectByKey(Of Vendor)(strVendor.Value), Nothing), receivingRecord)
        SetField(Receiving.Fields.sngSkits.PropertyName, receivingRecord.sngSkits, If(sngSkits.HasValue, sngSkits.Value, Nothing), receivingRecord)
        SetField(Receiving.Fields.sngTotalPallets.PropertyName, receivingRecord.sngTotalPallets, If(sngTotalPallets.HasValue, sngTotalPallets.Value, Nothing), receivingRecord)
        SetField(Receiving.Fields.strPO.PropertyName, receivingRecord.strPO, If(String.IsNullOrEmpty(strPO), Nothing, strPO), receivingRecord)
        SetField(Receiving.Fields.intShiftID.PropertyName, receivingRecord.intShiftID, Session.DefaultSession.GetObjectByKey(Of Shifts)(intShiftID.Value), receivingRecord)
        SetField(Receiving.Fields.strTrailer.PropertyName, receivingRecord.strTrailer, If(String.IsNullOrEmpty(strTrailer), Nothing, strTrailer), receivingRecord)
        SetField(Receiving.Fields.strSeal.PropertyName, receivingRecord.strSeal, If(String.IsNullOrEmpty(strSeal), Nothing, strSeal), receivingRecord)
        SetField(Receiving.Fields.Notes.PropertyName, receivingRecord.Notes, If(String.IsNullOrEmpty(notes), Nothing, notes), receivingRecord)
        SetField(Receiving.Fields.UnloadedBy.PropertyName, receivingRecord.UnloadedBy, If(unloadedBy.HasValue, If(unloadedBy.Value = 0, Nothing, Session.DefaultSession.GetObjectByKey(Of Employees)(unloadedBy.Value)), Nothing), receivingRecord)
        SetField(Receiving.Fields.CheckedBy.PropertyName, receivingRecord.CheckedBy, If(checkedBy.HasValue, If(checkedBy.Value = 0, Nothing, Session.DefaultSession.GetObjectByKey(Of Employees)(checkedBy.Value)), Nothing), receivingRecord)
        SetField(Receiving.Fields.WheelsChocked.PropertyName, receivingRecord.WheelsChocked, If(wheelsChocked.HasValue, If(wheelsChocked.Value = 0, Nothing, CType(wheelsChocked.Value, DXDAL.ThreeWayYesNo)), Nothing), receivingRecord)
        SetField(Receiving.Fields.StartTime.PropertyName, receivingRecord.StartTime, If(startTime.HasValue, startTime.Value, Nothing), receivingRecord)
        SetField(Receiving.Fields.FinishTime.PropertyName, receivingRecord.FinishTime, If(finishTime.HasValue, finishTime.Value, Nothing), receivingRecord)
        SetField(Receiving.Fields.Temparature.PropertyName, receivingRecord.Temparature, If(temparature.HasValue, If(temparature.Value = 0, Nothing, temparature.Value), Nothing), receivingRecord)
        SetField(Receiving.Fields.PhysicalCondition.PropertyName, receivingRecord.PhysicalCondition,
                 If(physicalCondition.HasValue, If(physicalCondition.Value = 0, Nothing, Session.DefaultSession.GetObjectByKey(Of ShipmentConditions)(physicalCondition.Value)), Nothing), receivingRecord)
        SetField(Receiving.Fields.LoadCondition.PropertyName, receivingRecord.LoadCondition,
                If(loadCondition.HasValue, If(loadCondition.Value = 0, Nothing, Session.DefaultSession.GetObjectByKey(Of ShipmentConditions)(loadCondition.Value)), Nothing), receivingRecord)
        SetField(Receiving.Fields.ForeignSubstance.PropertyName, receivingRecord.ForeignSubstance, If(foreignSubstance.HasValue, If(foreignSubstance.Value = 0, Nothing, CType(foreignSubstance.Value, DXDAL.ThreeWayYesNo)), Nothing), receivingRecord)
        SetField(Receiving.Fields.InsectActivity.PropertyName, receivingRecord.InsectActivity, If(insectActivity.HasValue, If(insectActivity.Value = 0, Nothing, CType(insectActivity.Value, DXDAL.ThreeWayYesNo)), Nothing), receivingRecord)
        SetField(Receiving.Fields.CorrectPallets.PropertyName, receivingRecord.CorrectPallets, If(correctPallets.HasValue, If(correctPallets.Value = 0, Nothing, CType(correctPallets.Value, DXDAL.ThreeWayYesNo)), Nothing), receivingRecord)
        SetField(Receiving.Fields.ReceivingLocation.PropertyName, receivingRecord.ReceivingLocation, Session.DefaultSession.GetObjectByKey(Of Locations)(locationID), receivingRecord)

    End Sub
    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateReceiving(ByVal receivID As Integer, ByVal receivDate As Nullable(Of Date), ByVal receivCarrierID As Nullable(Of Integer), ByVal receivCustID As Nullable(Of Integer), ByVal receivBol As String, ByVal strVendor As Integer?,
                                    ByVal sngSkits As Nullable(Of Single), ByVal sngTotalPallets As Nullable(Of Single), ByVal strPO As String, ByVal intShiftID As Nullable(Of Integer), ByVal strTrailer As String, ByVal strSeal As String,
                                    ByVal notes As String, ByVal unloadedBy As Integer?, ByVal checkedBy As Integer?, ByVal wheelsChocked As Integer?, ByVal startTime As DateTime?, ByVal finishTime As DateTime?, ByVal temparature As Double?,
                                    ByVal physicalCondition As Integer?, ByVal loadCondition As Integer?, ByVal foreignSubstance As Integer?, ByVal insectActivity As Integer?, ByVal correctPallets As Integer?, ByVal locationID As Integer) As Boolean

        Dim str As StringBuilder = New StringBuilder(String.Empty)
        If Not receivCustID.HasValue Then
            str.Append("Customer Name, ")
        End If

        If Not receivCarrierID.HasValue Then
            str.Append("Carrier Name, ")
        End If

        If Not intShiftID.HasValue Then
            str.Append("Receiving Shift, ")
        End If

        If String.IsNullOrEmpty(receivBol) Then
            str.Append("Receiving BOL, ")
        End If

        If str.Length > 0 Then
            Throw New ApplicationException(String.Format("You must provide a {0}.", str.ToString.Substring(0, (str.Length - 2))))
        End If

        Dim change As Change
        Dim receivingRecord As Receiving = Session.DefaultSession.GetObjectByKey(Of Receiving)(receivID)

        If receivingRecord Is Nothing Then
            'It is a new Receiving
            'It must have all the quality fields filled in
            If temparature.HasValue = False OrElse physicalCondition.HasValue = False OrElse loadCondition.HasValue = False OrElse foreignSubstance.HasValue = False OrElse insectActivity.HasValue = False OrElse correctPallets.HasValue = False _
                    OrElse wheelsChocked.HasValue = False OrElse unloadedBy.HasValue = False OrElse checkedBy.HasValue = False OrElse String.IsNullOrEmpty(strTrailer) Then
                Throw New ApplicationException("You must fill in all the quality fields.")
            End If
            change = New Change() With {.PropertyName = receiving.Fields.ReceivID.PropertyName, .PrevValue = "<NULL>", .NewValue = receivID.ToString}
            changes.Add(change)
            Return InsertReceiving(receivID, receivDate, receivCarrierID, receivCustID, receivBol, strVendor, sngSkits, sngTotalPallets, strPO, intShiftID, _
            strTrailer, strSeal, notes, unloadedBy, checkedBy, wheelsChocked, startTime, finishTime, temparature, physicalCondition, loadCondition, foreignSubstance, insectActivity, correctPallets, locationID)
        End If

        'Dim receiving As SPG.ReceivingsRow = receivings(0)

        'Dim originalRecord As Object() = Nothing
        'originalRecord = receiving.ItemArray

        change = New Change() With {.PropertyName = Receiving.Fields.ReceivID.PropertyName, .PrevValue = receivingRecord.ReceivID.ToString, .NewValue = receivingRecord.ReceivID.ToString}
        changes.Add(change)
        SetReceivingFields(receivDate, receivCarrierID, receivCustID, receivBol, strVendor, sngSkits, sngTotalPallets, strPO, intShiftID, strTrailer, strSeal, notes, unloadedBy, checkedBy, wheelsChocked, startTime, finishTime, temparature,
                           physicalCondition, loadCondition, foreignSubstance, insectActivity, correctPallets, locationID, receivingRecord)

        'If Not IsNothing(originalRecord) Then
        '    Me.UpdateAuditTrail(receiving, originalRecord)
        'End If

        'Dim rowsAffected As Integer = Adapter.Update(receiving)

        'Return rowsAffected = 1

        Try
            receivingRecord.Save()
        Catch ex As Exception
            Return False
        End Try

        UpdateAuditTrail()

        Return True

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, True)> _
    Public Function InsertReceiving(ByVal receivID As Integer, ByVal receivDate As Nullable(Of Date), ByVal receivCarrierID As Nullable(Of Integer), ByVal receivCustID As Nullable(Of Integer), ByVal receivBol As String, ByVal strVendor As Integer?,
                                    ByVal sngSkits As Nullable(Of Single), ByVal sngTotalPallets As Nullable(Of Single), ByVal strPO As String, ByVal intShiftID As Nullable(Of Integer), ByVal strTrailer As String, ByVal strSeal As String,
                                    ByVal notes As String, ByVal unloadedBy As Integer?, ByVal checkedBy As Integer?, ByVal wheelsChocked As Integer?, ByVal startTime As DateTime?, ByVal finishTime As DateTime?, ByVal temparature As Double?,
                                    ByVal physicalCondition As Integer?, ByVal loadCondition As Integer?, ByVal foreignSubstance As Integer?, ByVal insectActivity As Integer?, ByVal correctPallets As Integer?, ByVal locationID As Integer) As Boolean

        'Dim receivings As SPG.ReceivingsDataTable = New SPG.ReceivingsDataTable
        'Dim receiving As SPG.ReceivingsRow = receivings.NewReceivingsRow()

        'receiving.ReceivID = receivID

        Dim receivingRecord As Receiving = New Receiving(Session.DefaultSession) With {.ReceivID = receivID}

        SetReceivingFields(receivDate, receivCarrierID, receivCustID, receivBol, strVendor, sngSkits, sngTotalPallets, strPO, intShiftID, strTrailer, strSeal, notes, unloadedBy, checkedBy, wheelsChocked, startTime, finishTime, temparature,
                           physicalCondition, loadCondition, foreignSubstance, insectActivity, correctPallets, locationID, receivingRecord)
        receivingRecord.strEnteredBy = My.Settings.UserName
        receivingRecord.dtmEnteredOn = Now

        'receivings.AddReceivingsRow(receiving)
        'Dim rowsAffected As Integer = Adapter.Update(receivings)

        'Return rowsAffected = 1

        Try
            receivingRecord.Save()
        Catch ex As Exception
            Return False
        End Try

        UpdateAuditTrail()

        Return True

    End Function

    Public Shared Function GetNewReceivingID() As Integer

        Dim conn As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.UserConnectionString)
        Dim myCommand As New SqlClient.SqlCommand("dbo.spNewIDSafe", conn)
        Dim myNewID As New SqlClient.SqlParameter("@nRetVal", SqlDbType.Int)
        myCommand.CommandType = CommandType.StoredProcedure
        myNewID.Direction = ParameterDirection.Output
        myCommand.Parameters.AddWithValue("@cName", "tblReceivMain")
        myCommand.Parameters.AddWithValue("@cPkField", "ReceivID")
        myCommand.Parameters.Add(myNewID)

        conn.Open()
        myCommand.ExecuteNonQuery()

        Return CType(myNewID.Value, Integer)

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, True)> _
    Public Function DeleteReceiving(ByVal receivingID As Integer) As Boolean

        Dim receivings As SPG.ReceivingsDataTable = Adapter.GetReceivingsByID(receivingID)
        Dim rowsAffected As Integer = 0

        If receivings.Count = 1 Then
            Dim receiving As SPG.ReceivingsRow = CType(receivings.Rows(0), SPG.ReceivingsRow)
            rowsAffected = Adapter.Delete(receivingID, receiving.ts)
        End If

        'Return true if precisely one row was deleted, otherwise return false.
        Return rowsAffected = 1

    End Function

    Public Function GetTotalPalletsByCustomerID(ByVal customerID As Integer) As Single

        Dim total As Object = Adapter.GetTotalPalletsByCustomerID(customerID)
        If total Is Nothing Then
            Return 0
        Else
            Return Convert.ToSingle(total)
        End If

    End Function

End Class
