Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo.Helpers

Namespace SPGData
    <Persistent("tblReceivMain")> _
    Public Class Receiving
        Inherits XPLiteObject
        Dim fReceivID As Integer
        <Key()> _
        Public Property ReceivID() As Integer
            Get
                Return fReceivID
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("ReceivID", fReceivID, value)
            End Set
        End Property
        Dim fReceivDate As DateTime
        Public Property ReceivDate() As DateTime
            Get
                Return fReceivDate
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("ReceivDate", fReceivDate, value)
            End Set
        End Property
        Dim fReceivCarrierID As Carriers
        Public Property ReceivCarrierID() As Carriers
            Get
                Return fReceivCarrierID
            End Get
            Set(ByVal value As Carriers)
                SetPropertyValue(Of Carriers)("ReceivCarrierID", fReceivCarrierID, value)
            End Set
        End Property
        Dim fReceivCustID As Customers
        Public Property ReceivCustID() As Customers
            Get
                Return fReceivCustID
            End Get
            Set(ByVal value As Customers)
                SetPropertyValue(Of Customers)("ReceivCustID", fReceivCustID, value)
            End Set
        End Property
        Dim fReceivBOL As String
        <Size(50)> _
        Public Property ReceivBOL() As String
            Get
                Return fReceivBOL
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ReceivBOL", fReceivBOL, value)
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
        Dim fstrVendor As Vendor
        <Association("Receiving-Vendor")> _
        Public Property strVendor() As vendor
            Get
                Return fstrVendor
            End Get
            Set(ByVal value As Vendor)
                SetPropertyValue(Of Vendor)("strVendor", fstrVendor, value)
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
        Dim fintShiftID As Shifts
        Public Property intShiftID() As Shifts
            Get
                Return fintShiftID
            End Get
            Set(ByVal value As Shifts)
                SetPropertyValue(Of Shifts)("intShiftID", fintShiftID, value)
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
        Dim fNotes As String
        <Size(255)> _
        Public Property Notes() As String
            Get
                Return fNotes
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Notes", fNotes, value)
            End Set
        End Property
        Dim fUnloadedBy As Employees
        <Association("Employee-Unloaded")>
        Public Property UnloadedBy() As Employees
            Get
                Return fUnloadedBy
            End Get
            Set(value As Employees)
                SetPropertyValue(Of Employees)("UnloadedBy", fUnloadedBy, value)
            End Set
        End Property
        Dim fCheckedBy As Employees
        <Association("Employee-CheckedReceiving")>
        Public Property CheckedBy() As Employees
            Get
                Return fCheckedBy
            End Get
            Set(value As Employees)
                SetPropertyValue(Of Employees)("CheckedBy", fCheckedBy, value)
            End Set
        End Property
        Dim fPhysicalCondition As ShipmentConditions
        <Association("ReceivingPhysicalCondition")>
        Public Property PhysicalCondition As ShipmentConditions
            Get
                Return fPhysicalCondition
            End Get
            Set(value As ShipmentConditions)
                SetPropertyValue(Of ShipmentConditions)("PhysicalCondition", fPhysicalCondition, value)
            End Set
        End Property
        Dim fLoadCondition As ShipmentConditions
        <Association("ReceivingLoadCondition")>
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
        Dim fReceivingLocation As Locations
        <Association("Location-Receivings")>
        Public Property ReceivingLocation As Locations
            Get
                Return fReceivingLocation
            End Get
            Set(value As Locations)
                SetPropertyValue(Of Locations)("ReceivingLocation", fReceivingLocation, value)
            End Set
        End Property

        <Association("Receiving-Details", GetType(ReceivingDetail)), Aggregated()> _
        Public ReadOnly Property ReceivingDetails() As XPCollection(Of ReceivingDetail)
            Get
                Return GetCollection(Of ReceivingDetail)("ReceivingDetails")
            End Get
        End Property
        <Association("Receiving-Returns", GetType(ReceivedReturns)), Aggregated()> _
        Public ReadOnly Property ReceivingReturns() As XPCollection(Of ReceivedReturns)
            Get
                Return GetCollection(Of ReceivedReturns)("ReceivingReturns")
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
#Region "XPO nested fields class - don't edit manually"
        Public Shadows Class FieldsClass
            Inherits DevExpress.Xpo.PersistentBase.FieldsClass
            Public Sub New()
                MyBase.New()
            End Sub
            Public Sub New(ByVal propertyName As String)
                MyBase.New(propertyName)
            End Sub
            Public ReadOnly Property ReceivID() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ReceivID"))
                End Get
            End Property
            Public ReadOnly Property ReceivDate() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ReceivDate"))
                End Get
            End Property
            Public ReadOnly Property ReceivCarrierID() As Carriers.FieldsClass
                Get
                    Return New Carriers.FieldsClass(GetNestedName("ReceivCarrierID"))
                End Get
            End Property
            Public ReadOnly Property ReceivCustID() As Customers.FieldsClass
                Get
                    Return New Customers.FieldsClass(GetNestedName("ReceivCustID"))
                End Get
            End Property
            Public ReadOnly Property ReceivBOL() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ReceivBOL"))
                End Get
            End Property
            Public ReadOnly Property strEnteredBy() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("strEnteredBy"))
                End Get
            End Property
            Public ReadOnly Property dtmEnteredOn() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("dtmEnteredOn"))
                End Get
            End Property
            Public ReadOnly Property strVendor() As Vendor.FieldsClass
                Get
                    Return New vendor.FieldsClass(GetNestedName("strVendor"))
                End Get
            End Property
            Public ReadOnly Property sngSkits() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("sngSkits"))
                End Get
            End Property
            Public ReadOnly Property sngTotalPallets() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("sngTotalPallets"))
                End Get
            End Property
            Public ReadOnly Property strPO() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("strPO"))
                End Get
            End Property
            Public ReadOnly Property intShiftID() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("intShiftID"))
                End Get
            End Property
            Public ReadOnly Property strTrailer() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("strTrailer"))
                End Get
            End Property
            Public ReadOnly Property strSeal() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("strSeal"))
                End Get
            End Property
            Public ReadOnly Property Notes() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Notes"))
                End Get
            End Property
            Public ReadOnly Property UnloadedBy() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("UnloadedBy"))
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
            Public ReadOnly Property ReceivingLocation As Locations.FieldsClass
                Get
                    Return New Locations.FieldsClass(GetNestedName("ReceivingLocation"))
                End Get
            End Property
        End Class
        Private Shared _fields As FieldsClass
        Public Shared Shadows ReadOnly Property Fields() As FieldsClass
            Get
                If ReferenceEquals(_fields, Nothing) Then
                    _fields = New FieldsClass()
                End If
                Return _fields
            End Get
        End Property
#End Region
    End Class
End Namespace
