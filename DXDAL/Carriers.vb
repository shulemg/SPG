Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports DevExpress.Data.Filtering

Namespace SPGData
    <Persistent("tblCarriers")>
    Public Class Carriers
        Inherits XPLiteObject
        Dim fCarrierID As Integer
        <Key()> _
        Public Property CarrierID() As Integer
            Get
                Return fCarrierID
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("CarrierID", fCarrierID, value)
            End Set
        End Property
        Dim fCarrierName As String
        <Size(50)> _
        Public Property CarrierName() As String
            Get
                Return fCarrierName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("CarrierName", fCarrierName, value)
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
        <Size(50)> _
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
        Dim fPostal As String
        <Size(50)> _
        Public Property Postal() As String
            Get
                Return fPostal
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Postal", fPostal, value)
            End Set
        End Property
        Dim fPhone As String
        <Size(50)> _
        Public Property Phone() As String
            Get
                Return fPhone
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Phone", fPhone, value)
            End Set
        End Property
        Dim fEmail As String
        <Size(50)> _
        Public Property Email() As String
            Get
                Return fEmail
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Email", fEmail, value)
            End Set
        End Property
        Dim fFax As String
        <Size(50)> _
        Public Property Fax() As String
            Get
                Return fFax
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Fax", fFax, value)
            End Set
        End Property
        Dim fNote As String
        <Size(50)> _
        Public Property Note() As String
            Get
                Return fNote
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Note", fNote, value)
            End Set
        End Property
        Dim fEnteredBy As String
        <Size(50)> _
        Public Property EnteredBy() As String
            Get
                Return fEnteredBy
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("EnteredBy", fEnteredBy, value)
            End Set
        End Property
        Dim fEnteredOn As DateTime
        Public Property EnteredOn() As DateTime
            Get
                Return fEnteredOn
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("EnteredOn", fEnteredOn, value)
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

        Public Shadows Class FieldsClass
            Inherits XPLiteObject.FieldsClass
            Public Sub New()
                MyBase.New()
            End Sub
            Public Sub New(ByVal propertyName As String)
                MyBase.New(propertyName)
            End Sub
            Public ReadOnly Property CarrierID() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("CarrierID"))
                End Get
            End Property
            Public ReadOnly Property CarrierName() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("CarrierName"))
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
            Public ReadOnly Property Address() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Address"))
                End Get
            End Property
            Public ReadOnly Property City() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("City"))
                End Get
            End Property
            Public ReadOnly Property State() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("State"))
                End Get
            End Property
            Public ReadOnly Property Postal() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Postal"))
                End Get
            End Property
            Public ReadOnly Property Phone() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Phone"))
                End Get
            End Property
            Public ReadOnly Property Email() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Email"))
                End Get
            End Property
            Public ReadOnly Property Fax() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Fax"))
                End Get
            End Property
            Public ReadOnly Property Note() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Note"))
                End Get
            End Property
            Public ReadOnly Property EnteredBy() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("EnteredBy"))
                End Get
            End Property
            Public ReadOnly Property EnteredOn() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("EnteredOn"))
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

    End Class
End Namespace
