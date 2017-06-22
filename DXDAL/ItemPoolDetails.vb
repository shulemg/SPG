Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Namespace SPGData
    Public Class ItemPoolDetails
        Inherits AuditableBase

        Private _itemPoolID As ItemPool
        Private _itemID As Items
        Private _itemPoolRatio As Double

        <Association("ItemPool-Details")>
        Public Property ItemPoolID As ItemPool
            Get
                Return _itemPoolID
            End Get
            Set(value As ItemPool)
                SetPropertyValue(Of ItemPool)("ItemPoolID", _itemPoolID, value)
            End Set
        End Property

        Public Property ItemID As Items
            Get
                Return _itemID
            End Get
            Set(value As Items)
                SetPropertyValue(Of Items)("ItemID", _itemID, value)
            End Set
        End Property

        Public Property ItemPoolRatio As Double
            Get
                Return _itemPoolRatio
            End Get
            Set(value As Double)
                SetPropertyValue(Of Double)("ItemPoolRatio", _itemPoolRatio, value)
            End Set
        End Property

        Public ReadOnly Property QuantityOnHand As Double
            Get
                Return ItemID.TotalQuantityOnHand * ItemPoolRatio
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
            Public ReadOnly Property ItemPoolID() As ItemPool.FieldsClass
                Get
                    Return New ItemPool.FieldsClass(GetNestedName("ItemPoolID"))
                End Get
            End Property
            Public ReadOnly Property ItemID() As Items.FieldsClass
                Get
                    Return New Items.FieldsClass(GetNestedName("ItemID"))
                End Get
            End Property
            Public ReadOnly Property ItemPoolRatio() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ItemPoolRatio"))
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
