Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo.Helpers

Namespace SPGData
    Public Class UsersCustomer

        Inherits XPObject

        Private _user As Users
        <Association("UsersCustomer-User")> _
        Public Property User() As Users
            Get
                Return _user
            End Get
            Set(ByVal Value As Users)
                SetPropertyValue("User", _user, Value)
            End Set
        End Property

        Private _customer As Customers
        <Association("UsersCustomer-Customer")> _
        Public Property Customer() As Customers
            Get
                Return _customer
            End Get
            Set(ByVal Value As Customers)
                SetPropertyValue("Customer", _customer, Value)
            End Set
        End Property

        Public Sub New()
            MyBase.New()
            ' This constructor is used when an object is loaded from a persistent storage.
            ' Do not place any code here.			
        End Sub

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
            ' This constructor is used when an object is loaded from a persistent storage.
            ' Do not place any code here.			
        End Sub

        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
            ' Place here your initialization code.
        End Sub
#Region "XPO nested fields class - don't edit manually"
        Public Shadows Class FieldsClass
            Inherits DevExpress.Xpo.XPObject.FieldsClass
            Public Sub New()
                MyBase.New()
            End Sub
            Public Sub New(ByVal propertyName As String)
                MyBase.New(propertyName)
            End Sub
            Public ReadOnly Property User() As Users.FieldsClass
                Get
                    Return New Users.FieldsClass(GetNestedName("User"))
                End Get
            End Property
            Public ReadOnly Property Customer() As Customers.FieldsClass
                Get
                    Return New Customers.FieldsClass(GetNestedName("Customer"))
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

