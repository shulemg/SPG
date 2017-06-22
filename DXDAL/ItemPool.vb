Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Namespace SPGData
    Public Class ItemPool
        Inherits AuditableBase

        ' Fields...
        Private _poolType As String
        Private _poolDescription As String
        Private _poolCode As String
        Private _poolCustomerID As Customers
        <Size(50)>
        Public Property PoolCode As String
            Get
                Return _poolCode
            End Get
            Set(ByVal Value As String)
                SetPropertyValue(Of String)("PoolCode", _poolCode, Value)
            End Set
        End Property

        <Size(1073741823)>
        Public Property PoolDescription As String
            Get
                Return _poolDescription
            End Get
            Set(ByVal Value As String)
                SetPropertyValue(Of String)("PoolDescription", _poolDescription, Value)
            End Set
        End Property

        <Size(50)>
        Public Property PoolType As String
            Get
                Return _poolType
            End Get
            Set(ByVal Value As String)
                SetPropertyValue(Of String)("PoolType", _poolType, Value)
            End Set
        End Property

        Public Property PoolCustomerID As Customers
            Get
                Return _poolCustomerID
            End Get
            Set(Value As Customers)
                SetPropertyValue(Of Customers)("PoolCustomerID", _poolCustomerID, Value)
            End Set
        End Property

        <Association("ItemPool-Details", GetType(ItemPoolDetails)), Aggregated()>
        Public ReadOnly Property Details() As XPCollection(Of ItemPoolDetails)
            Get
                Return GetCollection(Of ItemPoolDetails)("Details")
            End Get
        End Property

        <PersistentAlias("Details.Sum(QuantityOnHand)")>
        Public ReadOnly Property QuantityOnHand As Double
            Get
                Return Convert.ToDouble(EvaluateAlias("QuantityOnHand"))
            End Get
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

        Public Shadows Class FieldsClass
            Inherits DevExpress.Xpo.PersistentBase.FieldsClass
            Public Sub New()
                MyBase.New()
            End Sub
            Public Sub New(ByVal propertyName As String)
                MyBase.New(propertyName)
            End Sub
            Public ReadOnly Property PoolCode() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("PoolCode"))
                End Get
            End Property
            Public ReadOnly Property PoolDescription() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("PoolDescription"))
                End Get
            End Property
            Public ReadOnly Property PoolType() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("PoolType"))
                End Get
            End Property
            Public ReadOnly Property PoolCustomerID() As Customers.FieldsClass
                Get
                    Return New Customers.FieldsClass(GetNestedName("PoolCustomerID"))
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
