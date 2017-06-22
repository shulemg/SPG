Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports DevExpress.Data.Filtering

Namespace SPGData
    <Persistent("tblShipMain")> _
    Public Class Shipping
        Inherits XPLiteObject
        Dim fShipMainID As Integer
        <Key()> _
        Public Property ShipMainID() As Integer
            Get
                Return fShipMainID
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("ShipMainID", fShipMainID, value)
            End Set
        End Property
        Dim fShipMainDate As DateTime
        Public Property ShipMainDate() As DateTime
            Get
                Return fShipMainDate
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("ShipMainDate", fShipMainDate, value)
            End Set
        End Property
        Dim fShipMainCarrierID As Carriers
        Public Property ShipMainCarrierID() As Carriers
            Get
                Return fShipMainCarrierID
            End Get
            Set(ByVal value As Carriers)
                SetPropertyValue(Of Carriers)("ShipMainCarrierID", fShipMainCarrierID, value)
            End Set
        End Property
        Dim fShipMainCustID As Customers
        Public Property ShipMainCustID() As Customers
            Get
                Return fShipMainCustID
            End Get
            Set(ByVal value As Customers)
                SetPropertyValue(Of Customers)("ShipMainCustID", fShipMainCustID, value)
            End Set
        End Property
        Dim fShipMainBOL As Integer
        Public Property ShipMainBOL() As Integer
            Get
                Return fShipMainBOL
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("ShipMainBOL", fShipMainBOL, value)
            End Set
        End Property
        Dim fstrEnteredBy As String
        <Size(50)> _
        Public Property strEnteredBy() As String
            Get
                Return fstrEnteredBy
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("strEnteredBy", fstrEnteredBy, value)
            End Set
        End Property
        Dim fdtmEnteredOn As DateTime
        Public Property dtmEnteredOn() As DateTime
            Get
                Return fdtmEnteredOn
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("dtmEnteredOn", fdtmEnteredOn, value)
            End Set
        End Property
        Dim fintDestination As ShippingAddresses
        Public Property intDestination() As ShippingAddresses
            Get
                Return fintDestination
            End Get
            Set(ByVal value As ShippingAddresses)
                SetPropertyValue(Of ShippingAddresses)("intDestination", fintDestination, value)
            End Set
        End Property
        Dim fstrPO As String
        <Size(50)> _
        Public Property strPO() As String
            Get
                Return fstrPO
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("strPO", fstrPO, value)
            End Set
        End Property
        Dim fstrTrailer As String
        <Size(50)> _
        Public Property strTrailer() As String
            Get
                Return fstrTrailer
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("strTrailer", fstrTrailer, value)
            End Set
        End Property
        Dim fsngSkits As Single
        Public Property sngSkits() As Single
            Get
                Return fsngSkits
            End Get
            Set(ByVal value As Single)
                SetPropertyValue(Of Single)("sngSkits", fsngSkits, value)
            End Set
        End Property
        Dim fsngTotalPallets As Single
        Public Property sngTotalPallets() As Single
            Get
                Return fsngTotalPallets
            End Get
            Set(ByVal value As Single)
                SetPropertyValue(Of Single)("sngTotalPallets", fsngTotalPallets, value)
            End Set
        End Property
        Dim fstrSeal As String
        <Size(50)> _
        Public Property strSeal() As String
            Get
                Return fstrSeal
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("strSeal", fstrSeal, value)
            End Set
        End Property
        Dim fstrRoute As String
        <Size(50)> _
        Public Property strRoute() As String
            Get
                Return fstrRoute
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("strRoute", fstrRoute, value)
            End Set
        End Property
        Dim fstrDeliveryNote As String
        Public Property strDeliveryNote() As String
            Get
                Return fstrDeliveryNote
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("strDeliveryNote", fstrDeliveryNote, value)
            End Set
        End Property
        Dim fDeliveryNoteNumber As String
        <Size(50)> _
        Public Property DeliveryNoteNumber() As String
            Get
                Return fDeliveryNoteNumber
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("DeliveryNoteNumber", fDeliveryNoteNumber, value)
            End Set
        End Property
        Dim fTotalGrossWeight As Double
        Public Property TotalGrossWeight() As Double
            Get
                Return fTotalGrossWeight
            End Get
            Set(ByVal value As Double)
                SetPropertyValue(Of Double)("TotalGrossWeight", fTotalGrossWeight, value)
            End Set
        End Property
        Dim fShipper As Boolean
        Public Property Shipper() As Boolean
            Get
                Return fShipper
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("Shipper", fShipper, value)
            End Set
        End Property
        Dim fComments As String
        <Size(255)> _
        Public Property Comments() As String
            Get
                Return fComments
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Comments", fComments, value)
            End Set
        End Property
        Dim fShift As Shifts
        Public Property Shift() As Shifts
            Get
                Return fShift
            End Get
            Set(ByVal value As Shifts)
                SetPropertyValue(Of Shifts)("Shift", fShift, value)
            End Set
        End Property
        Dim fFreight As Boolean
        Public Property Freight() As Boolean
            Get
                Return fFreight
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("Freight", fFreight, value)
            End Set
        End Property
        Dim fLoadedBy As Employees
        <Association("Employee-Loaded")>
        Public Property LoadedBy() As Employees
            Get
                Return fLoadedBy
            End Get
            Set(value As Employees)
                SetPropertyValue(Of Employees)("LoadedBy", fLoadedBy, value)
            End Set
        End Property
        Dim fCheckedBy As Employees
        <Association("Employee-CheckedShipping")>
        Public Property CheckedBy() As Employees
            Get
                Return fCheckedBy
            End Get
            Set(value As Employees)
                SetPropertyValue(Of Employees)("CheckedBy", fCheckedBy, value)
            End Set
        End Property
        Dim fPhysicalCondition As ShipmentConditions
        <Association("ShipingPhysicalCondition")>
        Public Property PhysicalCondition As ShipmentConditions
            Get
                Return fPhysicalCondition
            End Get
            Set(value As ShipmentConditions)
                SetPropertyValue(Of ShipmentConditions)("PhysicalCondition", fPhysicalCondition, value)
            End Set
        End Property
        Dim fLoadCondition As ShipmentConditions
        <Association("ShipingLoadCondition")>
        Public Property LoadCondition As ShipmentConditions
            Get
                Return fLoadCondition
            End Get
            Set(value As ShipmentConditions)
                SetPropertyValue(Of ShipmentConditions)("LoadCondition", fLoadCondition, value)
            End Set
        End Property
        Dim fStartTime As DateTime
        Public Property StartTime As DateTime
            Get
                Return fStartTime
            End Get
            Set(value As DateTime)
                SetPropertyValue(Of DateTime)("StartTime", fStartTime, value)
            End Set
        End Property
        Dim fFinishTime As DateTime
        Public Property FinishTime As DateTime
            Get
                Return fFinishTime
            End Get
            Set(value As DateTime)
                SetPropertyValue(Of DateTime)("FinishTime", fFinishTime, value)
            End Set
        End Property
        Dim fTemparature As Double
        Public Property Temparature As Double
            Get
                Return fTemparature
            End Get
            Set(value As Double)
                SetPropertyValue(Of Double)("Temparature", fTemparature, value)
            End Set
        End Property
        Dim fWheelsChocked As ThreeWayYesNo
        Public Property WheelsChocked As ThreeWayYesNo
            Get
                Return fWheelsChocked
            End Get
            Set(value As ThreeWayYesNo)
                SetPropertyValue(Of ThreeWayYesNo)("WheelsChocked", fWheelsChocked, value)
            End Set
        End Property
        Dim fForeignSubstance As ThreeWayYesNo
        Public Property ForeignSubstance As ThreeWayYesNo
            Get
                Return fForeignSubstance
            End Get
            Set(value As ThreeWayYesNo)
                SetPropertyValue(Of ThreeWayYesNo)("ForeignSubstance", fForeignSubstance, value)
            End Set
        End Property
        Dim fInsectActivity As ThreeWayYesNo
        Public Property InsectActivity As ThreeWayYesNo
            Get
                Return fInsectActivity
            End Get
            Set(value As ThreeWayYesNo)
                SetPropertyValue(Of ThreeWayYesNo)("InsectActivity", fInsectActivity, value)
            End Set
        End Property
        Dim fCorrectPallets As ThreeWayYesNo
        Public Property CorrectPallets As ThreeWayYesNo
            Get
                Return fCorrectPallets
            End Get
            Set(value As ThreeWayYesNo)
                SetPropertyValue(Of ThreeWayYesNo)("CorrectPallets", fCorrectPallets, value)
            End Set
        End Property
        Dim fShippingLocation As Locations
        <Association("Location-Shippings")>
        Public Property ShippingLocation As Locations
            Get
                Return fShippingLocation
            End Get
            Set(value As Locations)
                SetPropertyValue(Of Locations)("ShippingLocation", fShippingLocation, value)
            End Set
        End Property

        <Association("Shipping-Details", GetType(ShipDet)), Aggregated()> _
        Public ReadOnly Property ShippingDetails() As XPCollection(Of ShipDet)
            Get
                Return GetCollection(Of ShipDet)("ShippingDetails")
            End Get
        End Property
        <Association("Shippiing-Returns", GetType(ShippedReturns)), Aggregated()> _
        Public ReadOnly Property ShippingReturns() As XPCollection(Of ShippedReturns)
            Get
                Return GetCollection(Of ShippedReturns)("ShippingReturns")
            End Get
        End Property
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Sub New()
            MyBase.New(Session.DefaultSession)
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub
        Private Shared _fields As FieldsClass
        Public Shared Shadows ReadOnly Property Fields() As FieldsClass
            Get
                If ReferenceEquals(_fields, Nothing) Then
                    _fields = New FieldsClass()
                End If
                Return _fields
            End Get
        End Property
        'Created/Updated: Joel-PC\Joel on JOEL-PC at 7/06/10 4:39 PM
        Public Shadows Class FieldsClass
            Inherits DevExpress.Xpo.XPLiteObject.FieldsClass
            Public Sub New()
                MyBase.New()
            End Sub
            Public Sub New(ByVal propertyName As String)
                MyBase.New(propertyName)
            End Sub
            Public ReadOnly Property ShipMainID() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("ShipMainID"))
                End Get
            End Property
            Public ReadOnly Property ShipMainDate() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("ShipMainDate"))
                End Get
            End Property
            Public ReadOnly Property ShipMainCarrierID() As Carriers.FieldsClass
                Get
                    Return New Carriers.FieldsClass(GetNestedName("ShipMainCarrierID"))
                End Get
            End Property
            Public ReadOnly Property ShipMainCustID() As DXDAL.SPGData.Customers.FieldsClass
                Get
                    Return New DXDAL.SPGData.Customers.FieldsClass(GetNestedName("ShipMainCustID"))
                End Get
            End Property
            Public ReadOnly Property ShipMainBOL() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("ShipMainBOL"))
                End Get
            End Property
            Public ReadOnly Property strEnteredBy() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("strEnteredBy"))
                End Get
            End Property
            Public ReadOnly Property dtmEnteredOn() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("dtmEnteredOn"))
                End Get
            End Property
            Public ReadOnly Property intDestination() As DXDAL.SPGData.ShippingAddresses.FieldsClass
                Get
                    Return New DXDAL.SPGData.ShippingAddresses.FieldsClass(GetNestedName("intDestination"))
                End Get
            End Property
            Public ReadOnly Property strPO() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("strPO"))
                End Get
            End Property
            Public ReadOnly Property strTrailer() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("strTrailer"))
                End Get
            End Property
            Public ReadOnly Property sngSkits() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("sngSkits"))
                End Get
            End Property
            Public ReadOnly Property sngTotalPallets() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("sngTotalPallets"))
                End Get
            End Property
            Public ReadOnly Property strSeal() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("strSeal"))
                End Get
            End Property
            Public ReadOnly Property strRoute() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("strRoute"))
                End Get
            End Property
            Public ReadOnly Property strDeliveryNote() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("strDeliveryNote"))
                End Get
            End Property
            Public ReadOnly Property DeliveryNoteNumber() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("DeliveryNoteNumber"))
                End Get
            End Property
            Public ReadOnly Property TotalGrossWeight() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("TotalGrossWeight"))
                End Get
            End Property
            Public ReadOnly Property Shipper() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("Shipper"))
                End Get
            End Property
            Public ReadOnly Property Comments() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("Comments"))
                End Get
            End Property
            Public ReadOnly Property Shift() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("Shift"))
                End Get
            End Property
            Public ReadOnly Property Freight() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("Freight"))
                End Get
            End Property
            Public ReadOnly Property ShippingDetails() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("ShippingDetails"))
                End Get
            End Property
            Public ReadOnly Property ShippingReturns() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("ShippingReturns"))
                End Get
            End Property
            Public ReadOnly Property LoadedBy() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("LoadedBy"))
                End Get
            End Property
            Public ReadOnly Property CheckedBy() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("CheckedBy"))
                End Get
            End Property
            Public ReadOnly Property PhysicalCondition As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("PhysicalCondition"))
                End Get
            End Property
            Public ReadOnly Property LoadCondition As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("LoadCondition"))
                End Get
            End Property
            Public ReadOnly Property StartTime As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("StartTime"))
                End Get
            End Property
            Public ReadOnly Property FinishTime As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("FinishTime"))
                End Get
            End Property
            Public ReadOnly Property Temparature As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Temparature"))
                End Get
            End Property
            Public ReadOnly Property WheelsChocked As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("WheelsChocked"))
                End Get
            End Property
            Public ReadOnly Property ForeignSubstance As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ForeignSubstance"))
                End Get
            End Property
            Public ReadOnly Property InsectActivity As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("InsectActivity"))
                End Get
            End Property
            Public ReadOnly Property CorrectPallets As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("CorrectPallets"))
                End Get
            End Property
            Public ReadOnly Property ShippingLocation As Locations.FieldsClass
                Get
                    Return New Locations.FieldsClass(GetNestedName("ShippingLocation"))
                End Get
            End Property

        End Class
        
    End Class
End Namespace
