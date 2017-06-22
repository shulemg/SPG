Imports System.Drawing
Imports SuperiorPackGroup.SPGTableAdapters
Imports System
Imports System.Text
Imports DevExpress.Data.Filtering
Imports DXDAL.SPGData
Imports DevExpress.Xpo

<System.ComponentModel.DataObject()> _
Public Class ShippingsBLL

    Private m_ShippingsTableAdapter As ShippingsTableAdapter = Nothing
    Private changes As New List(Of Change)()

    Public ReadOnly Property Adapter() As ShippingsTableAdapter

        Get
            If m_ShippingsTableAdapter Is Nothing Then
                m_ShippingsTableAdapter = New ShippingsTableAdapter()
                m_ShippingsTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return m_ShippingsTableAdapter
        End Get

    End Property

    Private Sub UpdateAuditTrail()

        Dim builder As New StringBuilder(String.Empty)

        For Each update As Change In changes
            builder.Append(String.Format("{0}:{1}({2}); ", update.PropertyName, update.PrevValue, update.NewValue))
        Next

        If (builder.Length > 2) Then
            builder.Length = (builder.Length - 2)
            AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(changes(0).NewValue, Integer), "Shippings", builder.ToString)
        End If

        changes.Clear()

    End Sub

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetShippingsByCustomerID(ByVal customerID As Integer) As SPG.ShippingsDataTable

        Return Adapter.GetShippingsByCustomerID(customerID)

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function GetShippings() As SPG.ShippingsDataTable

        Return Adapter.GetShippings()

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetIDAndBOLByCustomerAndDate(ByVal customerID As Nullable(Of Integer), ByVal fromDate As Nullable(Of Date), ByVal toDate As Nullable(Of Date)) _
                As SPG.ShippingsDataTable

        Return Adapter.GetIDAndBOLByCustomerAndDate(customerID, fromDate, toDate)

    End Function

    Public Function GetMaxBOL() As Integer

        Try
            If Convert.ToDouble(Adapter.GetMaxBOL) >= 5000 Then
                Return Convert.ToInt32(Adapter.GetMaxBOL)
            Else
                Return 4999
            End If
        Catch
            Return 4999
        End Try

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetShippingByID(ByVal shippingID As Integer) As SPG.ShippingsDataTable

        Return Adapter.GetShippingByID(shippingID)

    End Function

    Private Sub SetField(propertyName As String, oldValue As Object, newValue As Object, ByVal shippingRecord As Shipping)

        If (oldValue IsNot Nothing Or newValue IsNot Nothing) AndAlso
            ((oldValue IsNot Nothing And newValue Is Nothing) OrElse (newValue IsNot Nothing And oldValue Is Nothing) OrElse oldValue.ToString <> newValue.ToString) Then
            shippingRecord.SetMemberValue(propertyName, newValue)
            Dim change As New Change() With {.PropertyName = propertyName, .PrevValue = If(oldValue Is Nothing, "<NULL>", oldValue.ToString()), .NewValue = If(newValue Is Nothing, "<NULL>", newValue.ToString())}
            changes.Add(change)
        End If

    End Sub

    Private Sub SetShippingFields(ByVal shippingDate As Nullable(Of Date), ByVal shippingCarrierID As Nullable(Of Integer), ByVal shippingCustID As Nullable(Of Integer), ByVal shippingBol As Integer, ByVal intDestination As Nullable(Of Integer),
                                  ByVal strPO As String, ByVal strTrailer As String, ByVal sngSkits As Nullable(Of Single), ByVal sngTotalPallets As Nullable(Of Single), ByVal strSeal As String, ByVal strDeliveryNote As String,
                                  ByVal DeliveryNoteNumber As String, ByVal TotalGrossWeight As Nullable(Of Double), ByVal Shipper As Nullable(Of Boolean), ByVal Comments As String, ByVal Shift As Nullable(Of Integer), ByVal Freight As Boolean,
                                  ByVal loadedBy As Integer?, ByVal checkedBy As Integer?, ByVal wheelsChocked As Integer?, ByVal startTime As DateTime?, ByVal finishTime As DateTime?, ByVal temparature As Double?, ByVal physicalCondition As Integer?,
                                  ByVal loadCondition As Integer?, ByVal foreignSubstance As Integer?, ByVal insectActivity As Integer?, ByVal correctPallets As Integer?, ByVal locationID As Integer, ByVal shippingRecord As Shipping)

        SetField(Shipping.Fields.ShipMainDate.PropertyName, shippingRecord.ShipMainDate, If(shippingDate.HasValue, shippingDate.Value, Today), shippingRecord)
        SetField(Shipping.Fields.ShipMainCarrierID.PropertyName, shippingRecord.ShipMainCarrierID, Session.DefaultSession.GetObjectByKey(Of Carriers)(shippingCarrierID.Value), shippingRecord)
        SetField(Shipping.Fields.ShipMainCustID.PropertyName, shippingRecord.ShipMainCustID, Session.DefaultSession.GetObjectByKey(Of Customers)(shippingCustID.Value), shippingRecord)
        SetField(Shipping.Fields.ShipMainBOL.PropertyName, shippingRecord.ShipMainBOL, shippingBol, shippingRecord)
        SetField(Shipping.Fields.intDestination.PropertyName, shippingRecord.intDestination, Session.DefaultSession.GetObjectByKey(Of ShippingAddresses)(intDestination.Value), shippingRecord)
        SetField(Shipping.Fields.strPO.PropertyName, shippingRecord.strPO, If(String.IsNullOrEmpty(strPO), Nothing, strPO), shippingRecord)
        SetField(Shipping.Fields.strTrailer.PropertyName, shippingRecord.strTrailer, If(String.IsNullOrEmpty(strTrailer), Nothing, strTrailer), shippingRecord)
        SetField(Shipping.Fields.sngSkits.PropertyName, shippingRecord.sngSkits, If(sngSkits.HasValue, sngSkits.Value, Nothing), shippingRecord)
        SetField(Shipping.Fields.sngTotalPallets.PropertyName, shippingRecord.sngTotalPallets, If(sngTotalPallets.HasValue, sngTotalPallets.Value, Nothing), shippingRecord)
        SetField(Shipping.Fields.strSeal.PropertyName, shippingRecord.strSeal, If(String.IsNullOrEmpty(strSeal), Nothing, strSeal), shippingRecord)
        SetField(Shipping.Fields.strDeliveryNote.PropertyName, shippingRecord.strDeliveryNote, If(String.IsNullOrEmpty(strDeliveryNote), Nothing, strDeliveryNote), shippingRecord)
        SetField(Shipping.Fields.DeliveryNoteNumber.PropertyName, shippingRecord.DeliveryNoteNumber, If(String.IsNullOrEmpty(DeliveryNoteNumber), Nothing, DeliveryNoteNumber), shippingRecord)
        SetField(Shipping.Fields.TotalGrossWeight.PropertyName, shippingRecord.TotalGrossWeight, If(TotalGrossWeight.HasValue, TotalGrossWeight.Value, Nothing), shippingRecord)
        SetField(Shipping.Fields.Shipper.PropertyName, shippingRecord.Shipper, If(Shipper.HasValue, Shipper.Value, Nothing), shippingRecord)
        SetField(Shipping.Fields.Comments.PropertyName, shippingRecord.Comments, If(String.IsNullOrEmpty(Comments), Nothing, Comments), shippingRecord)
        SetField(Shipping.Fields.Shift.PropertyName, shippingRecord.Shift, If(Shift.HasValue, If(Shift.Value = 0, Nothing, Session.DefaultSession.GetObjectByKey(Of Shifts)(Shift.Value)), Nothing), shippingRecord)
        SetField(Shipping.Fields.Freight.PropertyName, shippingRecord.Freight, Freight, shippingRecord)
        SetField(Shipping.Fields.LoadedBy.PropertyName, shippingRecord.LoadedBy, If(loadedBy.HasValue, If(loadedBy.Value = 0, Nothing, Session.DefaultSession.GetObjectByKey(Of Employees)(loadedBy.Value)), Nothing), shippingRecord)
        SetField(Shipping.Fields.CheckedBy.PropertyName, shippingRecord.CheckedBy, If(checkedBy.HasValue, If(checkedBy.Value = 0, Nothing, Session.DefaultSession.GetObjectByKey(Of Employees)(checkedBy.Value)), Nothing), shippingRecord)
        SetField(Shipping.Fields.WheelsChocked.PropertyName, shippingRecord.WheelsChocked, If(wheelsChocked.HasValue, If(wheelsChocked.Value = 0, Nothing, CType(wheelsChocked.Value, DXDAL.ThreeWayYesNo)), Nothing), shippingRecord)
        SetField(Shipping.Fields.StartTime.PropertyName, shippingRecord.StartTime, If(startTime.HasValue, startTime.Value, Nothing), shippingRecord)
        SetField(Shipping.Fields.FinishTime.PropertyName, shippingRecord.FinishTime, If(finishTime.HasValue, finishTime.Value, Nothing), shippingRecord)
        SetField(Shipping.Fields.Temparature.PropertyName, shippingRecord.Temparature, If(temparature.HasValue, If(temparature.Value = 0, Nothing, temparature.Value), Nothing), shippingRecord)
        SetField(Shipping.Fields.PhysicalCondition.PropertyName, shippingRecord.PhysicalCondition,
                 If(physicalCondition.HasValue, If(physicalCondition.Value = 0, Nothing, Session.DefaultSession.GetObjectByKey(Of ShipmentConditions)(physicalCondition.Value)), Nothing), shippingRecord)
        SetField(Shipping.Fields.LoadCondition.PropertyName, shippingRecord.LoadCondition,
                 If(loadCondition.HasValue, If(loadCondition.Value = 0, Nothing, Session.DefaultSession.GetObjectByKey(Of ShipmentConditions)(loadCondition.Value)), Nothing), shippingRecord)
        SetField(Shipping.Fields.ForeignSubstance.PropertyName, shippingRecord.ForeignSubstance, If(foreignSubstance.HasValue, If(foreignSubstance.Value = 0, Nothing, CType(foreignSubstance.Value, DXDAL.ThreeWayYesNo)), Nothing), shippingRecord)
        SetField(Shipping.Fields.InsectActivity.PropertyName, shippingRecord.InsectActivity, If(insectActivity.HasValue, If(insectActivity.Value = 0, Nothing, CType(insectActivity.Value, DXDAL.ThreeWayYesNo)), Nothing), shippingRecord)
        SetField(Shipping.Fields.CorrectPallets.PropertyName, shippingRecord.CorrectPallets, If(correctPallets.HasValue, If(correctPallets.Value = 0, Nothing, CType(correctPallets.Value, DXDAL.ThreeWayYesNo)), Nothing), shippingRecord)
        SetField(Shipping.Fields.ShippingLocation.PropertyName, shippingRecord.ShippingLocation, Session.DefaultSession.GetObjectByKey(Of Locations)(locationID), shippingRecord)

    End Sub

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateShipping(ByVal shippingID As Integer, ByVal shippingDate As Nullable(Of Date), ByVal shippingCarrierID As Nullable(Of Integer), ByVal shippingCustID As Nullable(Of Integer), _
                               ByVal shippingBol As Integer?, ByVal intDestination As Nullable(Of Integer), ByVal strPO As String, ByVal strTrailer As String, ByVal sngSkits As Nullable(Of Single), _
                               ByVal sngTotalPallets As Nullable(Of Single), ByVal strSeal As String, ByVal strDeliveryNote As String, ByVal DeliveryNoteNumber As String, ByVal TotalGrossWeight As Nullable(Of Double), _
                               ByVal Shipper As Nullable(Of Boolean), ByVal Comments As String, ByVal Shift As Nullable(Of Integer), ByVal Freight As Boolean, ByVal loadedBy As Integer?, ByVal checkedBy As Integer?,
                               ByVal wheelsChocked As Integer?, ByVal startTime As DateTime?, ByVal finishTime As DateTime?, ByVal temparature As Double?, ByVal physicalCondition As Integer?, ByVal loadCondition As Integer?,
                               ByVal foreignSubstance As Integer?, ByVal insectActivity As Integer?, ByVal correctPallets As Integer?, ByVal locationID As Integer) As Boolean

        Dim str As StringBuilder = New StringBuilder(String.Empty)
        If Not shippingCustID.HasValue Then
            str.Append("Customer Name, ")
        End If

        If Not shippingCarrierID.HasValue Then
            str.Append("Carrier Name, ")
        End If

        If Not intDestination.HasValue Then
            str.Append("Destination, ")
        End If

        If str.Length > 0 Then
            Throw New ApplicationException(String.Format("You must provide a {0}.", str.ToString.Substring(0, (str.Length - 2))))
        End If

        Dim change As Change
        Dim shippingRecord As Shipping = Session.DefaultSession.GetObjectByKey(Of Shipping)(shippingID)

        If shippingRecord Is Nothing Then
            'It is a new shipping
            'It must have all the quantity fields filled in
            If temparature.HasValue = False OrElse physicalCondition.HasValue = False OrElse loadCondition.HasValue = False OrElse foreignSubstance.HasValue = False OrElse insectActivity.HasValue = False OrElse correctPallets.HasValue = False _
                        OrElse wheelsChocked.HasValue = False OrElse loadedBy.HasValue = False OrElse checkedBy.HasValue = False OrElse String.IsNullOrEmpty(strTrailer) Then
                Throw New ApplicationException("You must fill in all the quality fields.")
            End If
            change = New Change() With {.PropertyName = Shipping.Fields.ShipMainID.PropertyName, .PrevValue = "<NULL>", .NewValue = shippingID.ToString}
            changes.Add(change)
            Return InsertShipping(shippingID, shippingDate, shippingCarrierID, shippingCustID, shippingBol, intDestination, strPO, strTrailer, sngSkits, sngTotalPallets, strSeal, strDeliveryNote, DeliveryNoteNumber, TotalGrossWeight, Shipper,
                                  Comments, Shift, Freight, loadedBy, checkedBy, wheelsChocked, startTime, finishTime, temparature, physicalCondition, loadCondition, foreignSubstance, insectActivity, correctPallets, locationID)
        End If

        change = New Change() With {.PropertyName = Shipping.Fields.ShipMainID.PropertyName, .PrevValue = shippingRecord.ShipMainID.ToString, .NewValue = shippingRecord.ShipMainID.ToString}
        changes.Add(change)
        SetShippingFields(shippingDate, shippingCarrierID, shippingCustID, shippingBol.Value, intDestination, strPO, strTrailer, sngSkits, sngTotalPallets, strSeal, strDeliveryNote, DeliveryNoteNumber, TotalGrossWeight, Shipper, _
                          Comments, Shift, Freight, loadedBy, checkedBy, wheelsChocked, startTime, finishTime, temparature, physicalCondition, loadCondition, foreignSubstance, insectActivity, correctPallets, locationID, shippingRecord)

        Try
            shippingRecord.Save()
        Catch ex As Exception
            Return False
        End Try

        UpdateAuditTrail()

        Return True

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, True)> _
    Public Function InsertShipping(ByVal shippingID As Integer, ByVal shippingDate As Nullable(Of Date), ByVal shippingCarrierID As Nullable(Of Integer), ByVal shippingCustID As Nullable(Of Integer), _
                                   ByVal shippingBol As Integer?, ByVal intDestination As Nullable(Of Integer), ByVal strPO As String, ByVal strTrailer As String, ByVal sngSkits As Nullable(Of Single), _
                                   ByVal sngTotalPallets As Nullable(Of Single), ByVal strSeal As String, ByVal strDeliveryNote As String, ByVal DeliveryNoteNumber As String, ByVal TotalGrossWeight As Nullable(Of Double), _
                                   ByVal Shipper As Nullable(Of Boolean), ByVal Comments As String, ByVal Shift As Nullable(Of Integer), ByVal Freight As Boolean, ByVal loadedBy As Integer?, ByVal checkedBy As Integer?, ByVal wheelsChocked As Integer?,
                                   ByVal startTime As DateTime?, ByVal finishTime As DateTime?, ByVal temparature As Double?, ByVal physicalCondition As Integer?, ByVal loadCondition As Integer?, ByVal foreignSubstance As Integer?,
                                   ByVal insectActivity As Integer?, ByVal correctPallets As Integer?, ByVal locationID As Integer) As Boolean

       Dim shippingRecord As Shipping = New Shipping(Session.DefaultSession) With {.ShipMainID = shippingID}

        If shippingBol.HasValue = False Then
            shippingBol = GetMaxBOL() + 1
        End If
        SetShippingFields(shippingDate, shippingCarrierID, shippingCustID, shippingBol.Value, intDestination, strPO, strTrailer, sngSkits, sngTotalPallets, strSeal, strDeliveryNote, DeliveryNoteNumber, TotalGrossWeight,
                          Shipper, Comments, Shift, Freight, loadedBy, checkedBy, wheelsChocked, startTime, finishTime, temparature, physicalCondition, loadCondition, foreignSubstance, insectActivity, correctPallets, locationID, shippingRecord)
        shippingRecord.strEnteredBy = My.Settings.UserName
        shippingRecord.dtmEnteredOn = Now

        Try
            shippingRecord.Save()
        Catch ex As Exception
            Return False
        End Try

        Return True

    End Function

    Public Shared Function GetNewItemID() As Integer

        Dim conn As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.UserConnectionString)
        Dim myCommand As New SqlClient.SqlCommand("dbo.spNewIDSafe", conn)
        Dim myNewID As New SqlClient.SqlParameter("@nRetVal", SqlDbType.Int)
        myCommand.CommandType = CommandType.StoredProcedure
        myNewID.Direction = ParameterDirection.Output
        myCommand.Parameters.AddWithValue("@cName", "tblShipMain")
        myCommand.Parameters.AddWithValue("@cPkField", "ShipMainID")
        myCommand.Parameters.Add(myNewID)

        conn.Open()
        myCommand.ExecuteNonQuery()

        Return CType(myNewID.Value, Integer)

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, True)> _
    Public Function DeleteShipping(ByVal shippingID As Integer) As Boolean

        Dim shippings As SPG.ShippingsDataTable = Adapter.GetShippingByID(shippingID)
        Dim rowsAffected As Integer = 0

        If shippings.Count = 1 Then
            Dim shipping As SPG.ShippingsRow = CType(shippings.Rows(0), SPG.ShippingsRow)
            rowsAffected = Adapter.Delete(shippingID, shipping.ts)
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

    Public Shared Function IsLPNShipped(ByVal fullLPNNumber As String, ByVal customerID As Integer, ByVal DXSession As Session) As Boolean

        If Not fullLPNNumber.StartsWith(CustomersBLL.GetLPNPrefix(customerID)) Then
            fullLPNNumber = CustomersBLL.GetLPNPrefix(customerID) & Strings.Right("0000000000" & fullLPNNumber, Len(CustomersBLL.GetCustomer(customerID, DXSession).LastLPNNumber.ToString))
        End If

        Dim filter As New CriteriaOperatorCollection
        filter.Add(New BinaryOperator(ShipDet.Fields.ShipDetMainID.ShipMainCustID.CustomerID.PropertyName, customerID, BinaryOperatorType.Equal))
        filter.Add(New BinaryOperator(ShipDet.Fields.FullLPNNumber.PropertyName, fullLPNNumber, BinaryOperatorType.Equal))

        Dim LPNCount As Integer? =
                CType(XpoDefault.Session.Evaluate(Of ShipDet)(New AggregateOperand("", "FullLPNNumber", Aggregate.Count), New GroupOperator(GroupOperatorType.And, filter)), Integer?)

        If LPNCount.HasValue AndAlso LPNCount.Value >= 1 Then
            Return True
        Else
            Return False
        End If

    End Function

End Class
