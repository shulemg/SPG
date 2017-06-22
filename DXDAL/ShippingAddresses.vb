Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports DevExpress.Data.Filtering

Namespace SPGData
    <Persistent("tblShippingAddresses")> _
    Public Class ShippingAddresses
        Inherits XPLiteObject
        Dim fAddressID As Integer
        <Key()> _
        Public Property AddressID() As Integer
            Get
                Return fAddressID
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("AddressID", fAddressID, value)
            End Set
        End Property
        Dim fShippingName As String
        <Size(50)> _
        Public Property ShippingName() As String
            Get
                Return fShippingName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ShippingName", fShippingName, value)
            End Set
        End Property
        Dim fContactFirstName As String
        <Size(50)> _
        Public Property ContactFirstName() As String
            Get
                Return fContactFirstName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ContactFirstName", fContactFirstName, value)
            End Set
        End Property
        Dim fContactLastName As String
        <Size(50)> _
        Public Property ContactLastName() As String
            Get
                Return fContactLastName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ContactLastName", fContactLastName, value)
            End Set
        End Property
        Dim fShippingAddress As String
        <Size(150)> _
        Public Property ShippingAddress() As String
            Get
                Return fShippingAddress
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ShippingAddress", fShippingAddress, value)
            End Set
        End Property
        Dim fShippingCity As String
        <Size(50)> _
        Public Property ShippingCity() As String
            Get
                Return fShippingCity
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ShippingCity", fShippingCity, value)
            End Set
        End Property
        Dim fShippingState As String
        <Size(50)> _
        Public Property ShippingState() As String
            Get
                Return fShippingState
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ShippingState", fShippingState, value)
            End Set
        End Property
        Dim fShippingPostal As String
        <Size(50)> _
        Public Property ShippingPostal() As String
            Get
                Return fShippingPostal
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ShippingPostal", fShippingPostal, value)
            End Set
        End Property
        Dim fShippingPhone As String
        <Size(50)> _
        Public Property ShippingPhone() As String
            Get
                Return fShippingPhone
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ShippingPhone", fShippingPhone, value)
            End Set
        End Property
        Dim fShippingEmail As String
        <Size(50)> _
        Public Property ShippingEmail() As String
            Get
                Return fShippingEmail
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ShippingEmail", fShippingEmail, value)
            End Set
        End Property
        Dim fShippingFax As String
        <Size(50)> _
        Public Property ShippingFax() As String
            Get
                Return fShippingFax
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ShippingFax", fShippingFax, value)
            End Set
        End Property
        Dim fShippingNote As String
        <Size(50)> _
        Public Property ShippingNote() As String
            Get
                Return fShippingNote
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ShippingNote", fShippingNote, value)
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
            Public ReadOnly Property AddressID() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("AddressID"))
                End Get
            End Property
            Public ReadOnly Property ShippingName() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ShippingName"))
                End Get
            End Property
            Public ReadOnly Property ContactFirstName() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ContactFirstName"))
                End Get
            End Property
            Public ReadOnly Property ContactLastName() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ContactLastName"))
                End Get
            End Property
            Public ReadOnly Property ShippingAddress() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ShippingAddress"))
                End Get
            End Property
            Public ReadOnly Property ShippingCity() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ShippingCity"))
                End Get
            End Property
            Public ReadOnly Property ShippingState() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ShippingState"))
                End Get
            End Property
            Public ReadOnly Property ShippingPostal() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ShippingPostal"))
                End Get
            End Property
            Public ReadOnly Property ShippingPhone() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ShippingPhone"))
                End Get
            End Property
            Public ReadOnly Property ShippingEmail() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ShippingEmail"))
                End Get
            End Property
            Public ReadOnly Property ShippingFax() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ShippingFax"))
                End Get
            End Property
            Public ReadOnly Property ShippingNote() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ShippingNote"))
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
