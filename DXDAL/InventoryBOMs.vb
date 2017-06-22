Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports DevExpress.Data.Filtering

Namespace SPGData
    <Persistent("tblInventoryBOMs")> _
    Public Class InventoryBOMs
        Inherits XPLiteObject
        Dim fInventoryBOMID As Integer
        <Key(True)> _
        Public Property InventoryBOMID() As Integer
            Get
                Return fInventoryBOMID
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("InventoryBOMID", fInventoryBOMID, value)
            End Set
        End Property
        Dim fInventoryBOMRawMatID As Items
        Public Property InventoryBOMRawMatID() As Items
            Get
                Return fInventoryBOMRawMatID
            End Get
            Set(ByVal value As Items)
                SetPropertyValue(Of Items)("InventoryBOMRawMatID", fInventoryBOMRawMatID, value)
            End Set
        End Property
        Dim fInventoryBOMInventoryID As Inventory
        Public Property InventoryBOMInventoryID() As Inventory
            Get
                Return fInventoryBOMInventoryID
            End Get
            Set(ByVal value As Inventory)
                SetPropertyValue(Of Inventory)("InventoryBOMInventoryID", fInventoryBOMInventoryID, value)
            End Set
        End Property
        Dim fInventoryBOMQuantity As Single
        Public Property InventoryBOMQuantity() As Single
            Get
                Return fInventoryBOMQuantity
            End Get
            Set(ByVal value As Single)
                SetPropertyValue(Of Single)("InventoryBOMQuantity", fInventoryBOMQuantity, value)
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
        'Created/Updated: Joel-PC\Joel on JOEL-PC at 11/04/10 12:07 PM
        Public Shadows Class FieldsClass
            Inherits DevExpress.Xpo.XPLiteObject.FieldsClass
            Public Sub New()
                MyBase.New()
            End Sub
            Public Sub New(ByVal propertyName As String)
                MyBase.New(propertyName)
            End Sub
            Public ReadOnly Property InventoryBOMID() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("InventoryBOMID"))
                End Get
            End Property
            Public ReadOnly Property InventoryBOMRawMatID() As DXDAL.SPGData.Items.FieldsClass
                Get
                    Return New DXDAL.SPGData.Items.FieldsClass(GetNestedName("InventoryBOMRawMatID"))
                End Get
            End Property
            Public ReadOnly Property InventoryBOMInventoryID() As DXDAL.SPGData.Inventory.FieldsClass
                Get
                    Return New DXDAL.SPGData.Inventory.FieldsClass(GetNestedName("InventoryBOMInventoryID"))
                End Get
            End Property
            Public ReadOnly Property InventoryBOMQuantity() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("InventoryBOMQuantity"))
                End Get
            End Property
            Public ReadOnly Property ScrapFactor() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("ScrapFactor"))
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
