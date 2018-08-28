Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Namespace SPGData
    Public Class Locations
        Inherits AuditableBase

        Dim fLocationCode As String
        <Size(25)>
        Public Property LocationCode() As String
            Get
                Return fLocationCode
            End Get
            Set(value As String)
                SetPropertyValue(Of String)("LocationCode", fLocationCode, value)
            End Set
        End Property

        Dim fLocationName As String
        <Size(50)>
        Public Property LocationName() As String
            Get
                Return fLocationName
            End Get
            Set(value As String)
                SetPropertyValue(Of String)("LocationName", fLocationName, value)
            End Set
        End Property

        Dim fLocationAddress As String
        <Size(150)>
        Public Property LocationAddress() As String
            Get
                Return fLocationAddress
            End Get
            Set(value As String)
                SetPropertyValue(Of String)("LocationAddress", fLocationAddress, value)
            End Set
        End Property

        Dim fLocationCity As String
        <Size(150)>
        Public Property LocationCity() As String
            Get
                Return fLocationCity
            End Get
            Set(value As String)
                SetPropertyValue(Of String)("LocationCity", fLocationCity, value)
            End Set
        End Property

        Dim fLocationState As String
        <Size(50)>
        Public Property LocationState() As String
            Get
                Return fLocationState
            End Get
            Set(value As String)
                SetPropertyValue(Of String)("LocationState", fLocationState, value)
            End Set
        End Property

        Dim fLocationZipCode As String
        <Size(50)>
        Public Property LocationZipCode() As String
            Get
                Return fLocationZipCode
            End Get
            Set(value As String)
                SetPropertyValue(Of String)("LocationZipCode", fLocationZipCode, value)
            End Set
        End Property

        Dim fLocationPhone As String
        <Size(50)>
        Public Property LocationPhone() As String
            Get
                Return fLocationPhone
            End Get
            Set(value As String)
                SetPropertyValue(Of String)("LocationPhone", fLocationPhone, value)
            End Set
        End Property

        Dim fLocationFax As String
        <Size(50)>
        Public Property LocationFax() As String
            Get
                Return fLocationFax
            End Get
            Set(value As String)
                SetPropertyValue(Of String)("LocationFax", fLocationFax, value)
            End Set
        End Property

        Dim fCanReceive As Boolean
        Public Property CanReceive As Boolean
            Get
                Return fCanReceive
            End Get
            Set(value As Boolean)
                SetPropertyValue(Of Boolean)("CanReceive", fCanReceive, value)
            End Set
        End Property

        Dim fCanProduce As Boolean
        Public Property CanProduce As Boolean
            Get
                Return fCanProduce
            End Get
            Set(value As Boolean)
                SetPropertyValue(Of Boolean)("CanProduce", fCanProduce, value)
            End Set
        End Property

        Dim fCanShip As Boolean
        Public Property CanShip As Boolean
            Get
                Return fCanShip
            End Get
            Set(value As Boolean)
                SetPropertyValue(Of Boolean)("CanShip", fCanShip, value)
            End Set
        End Property

        Dim fCanWarehouse As Boolean
        Public Property CanWarehouse As Boolean
            Get
                Return fCanWarehouse
            End Get
            Set(value As Boolean)
                SetPropertyValue(Of Boolean)("CanWarehouse", fCanWarehouse, value)
            End Set
        End Property

        Dim fInventoryAvailable As Boolean
        Public Property InventoryAvailable As Boolean
            Get
                Return fInventoryAvailable
            End Get
            Set(value As Boolean)
                SetPropertyValue(Of Boolean)("InventoryAvailable", fInventoryAvailable, value)
            End Set
        End Property

        <Association("Location-Inventory", GetType(LocationInventory)), Aggregated()>
        Public ReadOnly Property LocationsInventory As XPCollection(Of LocationInventory)
            Get
                Return GetCollection(Of LocationInventory)("LocationsInventory")
            End Get
        End Property

        <Association("Location-InventoryByLot", GetType(LocationInventoryByLot)), Aggregated()>
        Public ReadOnly Property LocationsInventoryByLot As XPCollection(Of LocationInventoryByLot)
            Get
                Return GetCollection(Of LocationInventoryByLot)("LocationsInventoryByLot")
            End Get
        End Property

        <Association("Location-TransfersFrom", GetType(LocationTransfers)), Aggregated()>
        Public ReadOnly Property LocationTransfersFrom As XPCollection(Of LocationTransfers)
            Get
                Return GetCollection(Of LocationTransfers)("LocationTransfersFrom")
            End Get
        End Property

        <Association("Location-TransfersTo", GetType(LocationTransfers)), Aggregated()>
        Public ReadOnly Property LocationTransfersTo As XPCollection(Of LocationTransfers)
            Get
                Return GetCollection(Of LocationTransfers)("LocationTransfersTo")
            End Get
        End Property

        <Association("Location-Receivings", GetType(Receiving)), Aggregated()>
        Public ReadOnly Property LocationReceivings As XPCollection(Of Receiving)
            Get
                Return GetCollection(Of Receiving)("LocationReceivings")
            End Get
        End Property

        <Association("Location-Shippings", GetType(Shipping)), Aggregated()>
        Public ReadOnly Property LocationShippings As XPCollection(Of Shipping)
            Get
                Return GetCollection(Of Shipping)("LocationShippings")
            End Get
        End Property

        <Association("Production-Location", GetType(Inventory)), Aggregated()>
        Public ReadOnly Property LocationProduction As XPCollection(Of Inventory)
            Get
                Return GetCollection(Of Inventory)("LocationProduction")
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
            Inherits XPLiteObject.FieldsClass
            Public Sub New()
                MyBase.New()
            End Sub
            Public Sub New(ByVal propertyName As String)
                MyBase.New(propertyName)
            End Sub
            Public ReadOnly Property Oid() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Oid"))
                End Get
            End Property
            Public ReadOnly Property LocationCode() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("LocationCode"))
                End Get
            End Property
            Public ReadOnly Property LocationName() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("LocationName"))
                End Get
            End Property
            Public ReadOnly Property LocationAddress() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("LocationAddress"))
                End Get
            End Property
            Public ReadOnly Property LocationCity() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("LocationCity"))
                End Get
            End Property
            Public ReadOnly Property LocationState() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("LocationState"))
                End Get
            End Property
            Public ReadOnly Property LocationZipCode() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("LocationZipCode"))
                End Get
            End Property
            Public ReadOnly Property LocationPhone() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("LocationPhone"))
                End Get
            End Property
            Public ReadOnly Property LocationFax() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("LocationFax"))
                End Get
            End Property
            Public ReadOnly Property CanReceive() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("CanReceive"))
                End Get
            End Property
            Public ReadOnly Property CanProduce() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("CanProduce"))
                End Get
            End Property
            Public ReadOnly Property CanShip() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("CanShip"))
                End Get
            End Property
            Public ReadOnly Property CanWarehouse() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("CanWarehouse"))
                End Get
            End Property
            Public ReadOnly Property InventoryAvailable() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("InventoryAvailable"))
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
