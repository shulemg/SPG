Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Namespace SPGData
    Public Class Employees
        Inherits AuditableBase

#Region "Non Persistent Properties"
        Public ReadOnly Property FullName As String
            Get
                Return String.Format("{0} {1}", FirstName, LastName)
            End Get
        End Property

        <Association("Employee-Unloaded", GetType(Receiving)), Aggregated()>
        Public ReadOnly Property Unloaded As XPCollection(Of Receiving)
            Get
                Return GetCollection(Of Receiving)("Unloaded")
            End Get
        End Property

        <Association("Employee-CheckedReceiving", GetType(Receiving)), Aggregated()>
        Public ReadOnly Property CheckedReceiving As XPCollection(Of Receiving)
            Get
                Return GetCollection(Of Receiving)("CheckedReceiving")
            End Get
        End Property

        <Association("Employee-Loaded", GetType(Shipping)), Aggregated()>
        Public ReadOnly Property Loaded As XPCollection(Of Shipping)
            Get
                Return GetCollection(Of Shipping)("Loaded")
            End Get
        End Property

        <Association("Employee-CheckedShipping", GetType(Shipping)), Aggregated()>
        Public ReadOnly Property CheckedShipping As XPCollection(Of Shipping)
            Get
                Return GetCollection(Of Shipping)("CheckedShipping")
            End Get
        End Property

        <Association("Employee-UnloadedTransfer", GetType(LocationTransfers)), Aggregated()>
        Public ReadOnly Property UnloadedTransfer As XPCollection(Of LocationTransfers)
            Get
                Return GetCollection(Of LocationTransfers)("UnloadedTransfer")
            End Get
        End Property

        <Association("Employee-CheckedTransfer", GetType(LocationTransfers)), Aggregated()>
        Public ReadOnly Property CheckedTransfer As XPCollection(Of LocationTransfers)
            Get
                Return GetCollection(Of LocationTransfers)("CheckedTransfer")
            End Get
        End Property

        <Association("Employee-LoadedTransfer", GetType(LocationTransfers)), Aggregated()>
        Public ReadOnly Property LoadedTransfer As XPCollection(Of LocationTransfers)
            Get
                Return GetCollection(Of LocationTransfers)("LoadedTransfer")
            End Get
        End Property
#End Region
#Region "Persistent Properties"
        ' Fields...
        Private _lastName As String
        Private _firstName As String

        <Size(50)>
        Public Property FirstName As String
            Get
                Return _firstName
            End Get
            Set(ByVal Value As String)
                SetPropertyValue(Of String)("FirstName", _firstName, Value)
            End Set
        End Property

        <Size(50)>
        Public Property LastName As String
            Get
                Return _lastName
            End Get
            Set(ByVal Value As String)
                SetPropertyValue(Of String)("LastName", _lastName, Value)
            End Set
        End Property
#End Region

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

        Public Shadows Class FieldClass
            Inherits PersistentBase.FieldsClass

            Public Sub New()
                MyBase.New()
            End Sub
            Public Sub New(ByVal propertyName As String)
                MyBase.New(propertyName)
            End Sub
            Public ReadOnly Property FirstName() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("FirstName"))
                End Get
            End Property
            Public ReadOnly Property LastName() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("LastName"))
                End Get
            End Property
            Public ReadOnly Property FullName() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("FullName"))
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
