Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Namespace SPGData
    Public Class PoolBom
        Inherits AuditableBase

        Dim fItemPoolId As ItemPool
        Public Property ItemPoolID() As ItemPool
            Get
                Return fItemPoolId
            End Get
            Set(value As ItemPool)
                SetPropertyValue(Of ItemPool)("ItemPoolID", fItemPoolId, value)
            End Set
        End Property
        Dim fPoolBomFiniGoodID As Items
        <Association("Item-PoolBom")>
        Public Property PoolBomFiniGoodID() As Items
            Get
                Return fPoolBomFiniGoodID
            End Get
            Set(ByVal value As Items)
                SetPropertyValue(Of Items)("PoolBomFiniGoodID", fPoolBomFiniGoodID, value)
            End Set
        End Property
        Dim fPoolBomQuantity As Single
        Public Property PoolBomQuantity() As Single
            Get
                Return fPoolBomQuantity
            End Get
            Set(ByVal value As Single)
                SetPropertyValue(Of Single)("PoolBomQuantity", fPoolBomQuantity, value)
            End Set
        End Property
        Dim fScrapFactor As Double
        Public Property ScrapFactor() As Double
            Get
                Return fScrapFactor
            End Get
            Set(ByVal value As Double)
                SetPropertyValue(Of Double)("ScrapFactor", fScrapFactor, value)
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

        Private Shared _Fields As FieldsClass
        Public Shared Shadows ReadOnly Property Fields() As FieldsClass
            Get
                If ReferenceEquals(_Fields, Nothing) Then
                    _Fields = New FieldsClass()
                End If
                Return _Fields
            End Get
        End Property

        Public Shadows Class FieldsClass
            Inherits DevExpress.Xpo.XPLiteObject.FieldsClass
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
            Public ReadOnly Property PoolBomFiniGoodID() As Items.FieldsClass
                Get
                    Return New Items.FieldsClass(GetNestedName("PoolBomFiniGoodID"))
                End Get
            End Property
            Public ReadOnly Property PoolBomQuantity() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("PoolBomQuantity"))
                End Get
            End Property
            Public ReadOnly Property ScrapFactor() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ScrapFactor"))
                End Get
            End Property
        End Class

    End Class
End Namespace
