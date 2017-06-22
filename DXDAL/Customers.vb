Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports DevExpress.Data.Filtering

Namespace SPGData
    <Persistent("tblCustomers")> _
        Public Class Customers
        Inherits XPLiteObject

#Region "Non Persistent Properties"

        <Association("UsersCustomer-Customer", GetType(UsersCustomer)), Aggregated()> _
        Public ReadOnly Property AssignedUser() As XPCollection(Of UsersCustomer)
            Get
                Return GetCollection(Of UsersCustomer)("AssignedUser")
            End Get
        End Property

        <Association("Customer-RelatedCustomers", GetType(RelatedCustomer)), Aggregated()>
        Public ReadOnly Property RelatedCustomers As XPCollection(Of RelatedCustomer)
            Get
                Return GetCollection(Of RelatedCustomer)("RelatedCustomers")
            End Get
        End Property

        <Association("Customer-Projects", GetType(Project)), Aggregated()>
        Public ReadOnly Property Projects As XPCollection(Of Project)
            Get
                Return GetCollection(Of Project)("Projects")
            End Get
        End Property

        Public ReadOnly Property Items As XPCollection(Of Items)
            Get
                Return GetCollection(Of Items)("Items")
            End Get
        End Property

        <Association("Customer-Shifts", GetType(CustomerShifts)), Aggregated()>
        Public ReadOnly Property CustomerShifts As XPCollection(Of CustomerShifts)
            Get
                Return GetCollection(Of CustomerShifts)("CustomerShifts")
            End Get
        End Property

        <Association("Customer-Plants", GetType(CustomerPlants)), Aggregated()>
        Public ReadOnly Property CustomerPlants As XPCollection(Of CustomerPlants)
            Get
                Return GetCollection(Of CustomerPlants)("CustomerPlants")
            End Get
        End Property
#End Region

#Region "Persistent Properties"
        Private _plantCode As String
        Private _nextLPNNumber As Integer
        Private _lastLPNNumber As Integer?
        Private _firstLPNNumber As Integer?
        Private _lPNPrefix As String
        Private _expirationDateFormat As String
        Private _defaultLotCodeFormat As LotCodeFormats

        Dim fCustomerID As Integer
        <Key()> _
        Public Property CustomerID() As Integer
            Get
                Return fCustomerID
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("CustomerID", fCustomerID, value)
            End Set
        End Property
        Dim m_CustomerName As String
        <Size(50)> _
        Public Property CustomerName() As String
            Get
                Return m_CustomerName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("CustomerName", m_CustomerName, value)
            End Set
        End Property
        Dim m_CustomerContact As String
        <Size(50)> _
        Public Property CustomerContact() As String
            Get
                Return m_CustomerContact
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("CustomerContact", m_CustomerContact, value)
            End Set
        End Property
        Dim fCustomerPhone As String
        <Size(50)> _
        Public Property CustomerPhone() As String
            Get
                Return fCustomerPhone
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("CustomerPhone", fCustomerPhone, value)
            End Set
        End Property
        Dim fCustomerEmail As String
        <Size(50)> _
        Public Property CustomerEmail() As String
            Get
                Return fCustomerEmail
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("CustomerEmail", fCustomerEmail, value)
            End Set
        End Property
        Dim fCustomerFax As String
        <Size(50)> _
        Public Property CustomerFax() As String
            Get
                Return fCustomerFax
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("CustomerFax", fCustomerFax, value)
            End Set
        End Property
        Dim fCustomerNote As String
        <Size(250)> _
        Public Property CustomerNote() As String
            Get
                Return fCustomerNote
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("CustomerNote", fCustomerNote, value)
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
        Dim fAddress As String
        <Size(150)> _
        Public Property Address() As String
            Get
                Return fAddress
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Address", fAddress, value)
            End Set
        End Property
        Dim fCity As String
        <Size(150)> _
        Public Property City() As String
            Get
                Return fCity
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("City", fCity, value)
            End Set
        End Property
        Dim fState As String
        <Size(50)> _
        Public Property State() As String
            Get
                Return fState
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("State", fState, value)
            End Set
        End Property
        Dim fZipCode As String
        <Size(50)> _
        Public Property ZipCode() As String
            Get
                Return fZipCode
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ZipCode", fZipCode, value)
            End Set
        End Property
        Dim fInactive As Boolean
        Public Property Inactive() As Boolean
            Get
                Return fInactive
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("Inactive", fInactive, value)
            End Set
        End Property
        Private fEditing As Boolean
        Public Property Editing() As Boolean
            Get
                Return fEditing
            End Get
            Set(ByVal Value As Boolean)
                SetPropertyValue(Of Boolean)("Editing", fEditing, Value)
            End Set
        End Property

        Public Property LPNPrefix As String
            Get
                Return _lPNPrefix
            End Get
            Set(ByVal Value As String)
                SetPropertyValue(Of String)("LPNPrefix", _lPNPrefix, Value)
            End Set
        End Property

        Public Property FirstLPNNumber As Integer?
            Get
                Return _firstLPNNumber
            End Get
            Set(ByVal Value As Integer?)
                SetPropertyValue(Of Integer?)("FirstLPNNumber", _firstLPNNumber, Value)
            End Set
        End Property

        Public Property LastLPNNumber As Integer?
            Get
                Return _lastLPNNumber
            End Get
            Set(ByVal Value As Integer?)
                SetPropertyValue(Of Integer?)("LastLPNNumber", _lastLPNNumber, Value)
            End Set
        End Property

        Public Property NextLPNNumber As Integer
            Get
                Return _nextLPNNumber
            End Get
            Set(ByVal Value As Integer)
                SetPropertyValue(Of Integer)("NextLPNNumber", _nextLPNNumber, Value)
            End Set
        End Property

        Public Property PlantCode As String
            Get
                Return _plantCode
            End Get
            Set(ByVal Value As String)
                SetPropertyValue(Of String)("PlantCode", _plantCode, Value)
            End Set
        End Property

        Public Property ExpirationDateFormat As String
            Get
                If String.IsNullOrEmpty(_expirationDateFormat) Then
                    Return "MM/dd/yyyy"
                End If
                Return _expirationDateFormat
            End Get
            Set(value As String)
                SetPropertyValue(Of String)("ExpirationDateFormat", _expirationDateFormat, value)
            End Set
        End Property

        Public Property DefaultLotCodeFormat As LotCodeFormats
            Get
                Return _defaultLotCodeFormat
            End Get
            Set(value As LotCodeFormats)
                SetPropertyValue("DefaultLotCodeFormat", _defaultLotCodeFormat, value)
            End Set
        End Property
#End Region

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
        'Created/Updated: Joel-PC\Joel on JOEL-PC at 3/8/2013 8:14 AM
        Public Shadows Class FieldsClass
            Inherits XPLiteObject.FieldsClass
            Public Sub New()
                MyBase.New()
            End Sub
            Public Sub New(ByVal propertyName As String)
                MyBase.New(propertyName)
            End Sub
            Public Const AssignedUserFieldName As String = "AssignedUser"
            Public ReadOnly Property AssignedUser() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("AssignedUser"))
                End Get
            End Property
            Public Const RelatedCustomersFieldName As String = "RelatedCustomers"
            Public ReadOnly Property RelatedCustomers() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("RelatedCustomers"))
                End Get
            End Property
            Public ReadOnly Property CustomerID() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("CustomerID"))
                End Get
            End Property
            Public Const CustomerNameFieldName As String = "CustomerName"
            Public ReadOnly Property CustomerName() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("CustomerName"))
                End Get
            End Property
            Public Const CustomerContactFieldName As String = "CustomerContact"
            Public ReadOnly Property CustomerContact() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("CustomerContact"))
                End Get
            End Property
            Public Const CustomerPhoneFieldName As String = "CustomerPhone"
            Public ReadOnly Property CustomerPhone() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("CustomerPhone"))
                End Get
            End Property
            Public Const CustomerEmailFieldName As String = "CustomerEmail"
            Public ReadOnly Property CustomerEmail() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("CustomerEmail"))
                End Get
            End Property
            Public Const CustomerFaxFieldName As String = "CustomerFax"
            Public ReadOnly Property CustomerFax() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("CustomerFax"))
                End Get
            End Property
            Public Const CustomerNoteFieldName As String = "CustomerNote"
            Public ReadOnly Property CustomerNote() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("CustomerNote"))
                End Get
            End Property
            Public Const strEnteredByFieldName As String = "strEnteredBy"
            Public ReadOnly Property strEnteredBy() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("strEnteredBy"))
                End Get
            End Property
            Public ReadOnly Property dtmEnteredOn() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("dtmEnteredOn"))
                End Get
            End Property
            Public Const AddressFieldName As String = "Address"
            Public ReadOnly Property Address() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("Address"))
                End Get
            End Property
            Public Const CityFieldName As String = "City"
            Public ReadOnly Property City() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("City"))
                End Get
            End Property
            Public Const StateFieldName As String = "State"
            Public ReadOnly Property State() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("State"))
                End Get
            End Property
            Public Const ZipCodeFieldName As String = "ZipCode"
            Public ReadOnly Property ZipCode() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("ZipCode"))
                End Get
            End Property
            Public ReadOnly Property Inactive() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Inactive"))
                End Get
            End Property
            Public ReadOnly Property Editing() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Editing"))
                End Get
            End Property
            Public Const LPNPrefixFieldName As String = "LPNPrefix"
            Public ReadOnly Property LPNPrefix() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("LPNPrefix"))
                End Get
            End Property
            Public ReadOnly Property FirstLPNNumber() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("FirstLPNNumber"))
                End Get
            End Property
            Public ReadOnly Property LastLPNNumber() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("LastLPNNumber"))
                End Get
            End Property
            Public ReadOnly Property NextLPNNumber() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("NextLPNNumber"))
                End Get
            End Property
            Public Const PlantCodeFieldName As String = "PlantCode"
            Public ReadOnly Property PlantCode() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("PlantCode"))
                End Get
            End Property
            Public Const ExpirationDateFormatFieldName As String = "ExpirationDateFormat"
            Public ReadOnly Property ExpirationDateFormat() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ExpirationDateFormat"))
                End Get
            End Property
            Public ReadOnly Property DefaultLotCodeFormat() As LotCodeFormats.FieldsClass
                Get
                    Return New LotCodeFormats.FieldsClass(GetNestedName("DefaultLotCodeFormat"))
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
