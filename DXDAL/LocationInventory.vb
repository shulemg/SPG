Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Namespace SPGData
    Public Class LocationInventory
        Inherits AuditableBase

        Dim fLocation As Locations
        <Association("Location-Inventory")>
        Public Property Location As Locations
            Get
                Return fLocation
            End Get
            Set(value As Locations)
                SetPropertyValue(Of Locations)("Location", fLocation, value)
            End Set
        End Property

        Dim fItem As Items
        <Association("LocationInventory-Item")>
        Public Property LocationInventoryItem As Items
            Get
                Return fItem
            End Get
            Set(value As Items)
                SetPropertyValue(Of Items)("LocationInventoryItem", fItem, value)
            End Set
        End Property

        Dim fQuantityOnHand As Single
        Public Property QuantityOnHand As Single
            Get
                Return fQuantityOnHand
            End Get
            Set(value As Single)
                SetPropertyValue(Of Single)("QuantityOnHand", fQuantityOnHand, value)
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

        Public Shadows Class FieldsClass
            Inherits DevExpress.Xpo.PersistentBase.FieldsClass
            Public Sub New()
                MyBase.New()
            End Sub
            Public Sub New(ByVal propertyName As String)
                MyBase.New(propertyName)
            End Sub
            Public ReadOnly Property Location() As Locations.FieldsClass
                Get
                    Return New Locations.FieldsClass(GetNestedName("Location"))
                End Get
            End Property
            Public ReadOnly Property LocationInventoryItem() As Items.FieldsClass
                Get
                    Return New Items.FieldsClass(GetNestedName("LocationInventoryItem"))
                End Get
            End Property
            Public ReadOnly Property QuantityOnHand() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("QuantityOnHand"))
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
