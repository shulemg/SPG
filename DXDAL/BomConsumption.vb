Imports System
Imports DevExpress.Xpo
Imports DXDAL.SPGData

Namespace SPGData
    Public Class BomConsumption
        Inherits AuditableBase

        Dim fRawMatID As Items
        Public Property RawMatID() As Items
            Get
                Return fRawMatID
            End Get
            Set(ByVal value As Items)
                SetPropertyValue(Of Items)("RawMatID", fRawMatID, value)
            End Set
        End Property
        Dim fInventoryID As Inventory
        <Association("Inventory-Consumption")>
        Public Property InventoryID() As Inventory
            Get
                Return fInventoryID
            End Get
            Set(ByVal value As Inventory)
                SetPropertyValue(Of Inventory)("InventoryID", fInventoryID, value)
            End Set
        End Property
        Dim fQuantityUsed As Single
        Public Property QuantityUsed() As Single
            Get
                Return fQuantityUsed
            End Get
            Set(ByVal value As Single)
                SetPropertyValue(Of Single)("QuantityUsed", fQuantityUsed, value)
            End Set
        End Property
        Dim fScrapFactorUsed As Double
        Public Property ScrapFactorUsed() As Double
            Get
                Return fScrapFactorUsed
            End Get
            Set(ByVal value As Double)
                SetPropertyValue(Of Double)("ScrapFactorUsed", fScrapFactorUsed, value)
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
            Inherits XPLiteObject.FieldsClass
            Public Sub New()
                MyBase.New()
            End Sub
            Public Sub New(ByVal propertyName As String)
                MyBase.New(propertyName)
            End Sub
            Public ReadOnly Property RawMatID() As Items.FieldsClass
                Get
                    Return New Items.FieldsClass(GetNestedName("RawMatID"))
                End Get
            End Property
            Public ReadOnly Property InventoryID() As Inventory.FieldsClass
                Get
                    Return New Inventory.FieldsClass(GetNestedName("InventoryID"))
                End Get
            End Property
            Public ReadOnly Property QuantityUsed() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("QuantityUsed"))
                End Get
            End Property
            Public ReadOnly Property ScrapFactorUsed() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("ScrapFactorUsed"))
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