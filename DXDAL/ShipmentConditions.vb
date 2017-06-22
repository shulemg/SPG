Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Namespace SPGData
    Public Class ShipmentConditions
        Inherits AuditableBase

#Region "Non Persistent Properties"
        <Association("ReceivingLoadCondition", GetType(Receiving)), Aggregated()>
        Public ReadOnly Property ReceivingLoadCondition As XPCollection(Of Receiving)
            Get
                Return GetCollection(Of Receiving)("ReceivingLoadCondition")
            End Get
        End Property

        <Association("ReceivingPhysicalCondition", GetType(Receiving)), Aggregated()>
        Public ReadOnly Property ReceivingPhysicalCondition As XPCollection(Of Receiving)
            Get
                Return GetCollection(Of Receiving)("ReceivingPhysicalCondition")
            End Get
        End Property

        <Association("ShipingLoadCondition", GetType(Shipping)), Aggregated()>
        Public ReadOnly Property ShipingLoadCondition As XPCollection(Of Shipping)
            Get
                Return GetCollection(Of Shipping)("ShipingLoadCondition")
            End Get
        End Property

        <Association("ShipingPhysicalCondition", GetType(Shipping)), Aggregated()>
        Public ReadOnly Property ShipingPhysicalCondition As XPCollection(Of Shipping)
            Get
                Return GetCollection(Of Shipping)("ShipingPhysicalCondition")
            End Get
        End Property
#End Region

        ' Fields...
        Private _shipmentCondition As String
        Public Property ShipmentCondition As String
            Get
                Return _shipmentCondition
            End Get
            Set(ByVal Value As String)
                SetPropertyValue(Of String)("ShipmentCondition", _shipmentCondition, Value)
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

        Public Shadows Class FieldClass
            Inherits PersistentBase.FieldsClass

            Public Sub New()
                MyBase.New()
            End Sub
            Public Sub New(ByVal propertyName As String)
                MyBase.New(propertyName)
            End Sub
            Public ReadOnly Property ShipmentCondition() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ShipmentCondition"))
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
