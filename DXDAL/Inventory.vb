Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo.Helpers
Imports DXDAL.SPGData

Namespace SPGData
    <Persistent("tblInventory")> _
        Public Class Inventory
        Inherits XPLiteObject
        Dim fInventoryID As Integer
        <Key(False)> _
        Public Property InventoryID() As Integer
            Get
                Return fInventoryID
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("InventoryID", fInventoryID, value)
            End Set
        End Property
        Dim fInventoryDate As DateTime
        Public Property InventoryDate() As DateTime
            Get
                Return fInventoryDate
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("InventoryDate", fInventoryDate, value)
            End Set
        End Property

        Dim fInventoryItemID As Items
        Public Property InventoryItemID() As Items
            Get
                Return fInventoryItemID
            End Get
            Set(ByVal value As Items)
                SetPropertyValue(Of Items)("InventoryItemID", fInventoryItemID, value)
            End Set
        End Property
        Dim fInventoryQuantity As Integer
        Public Property InventoryQuantity() As Integer
            Get
                Return fInventoryQuantity
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("InventoryQuantity", fInventoryQuantity, value)
            End Set
        End Property
        Dim fInventoryPallets As Single
        Public Property InventoryPallets() As Single
            Get
                Return fInventoryPallets
            End Get
            Set(ByVal value As Single)
                SetPropertyValue(Of Single)("InventoryPallets", fInventoryPallets, value)
            End Set
        End Property
        Dim fstrEnteredBy As String
        <Size(50)> _
        Public Property strEnteredBy() As String
            Get
                Return fstrEnteredBy
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("strEnteredBy", fstrEnteredBy, value)
            End Set
        End Property
        Dim fdtmEnteredOn As DateTime
        Public Property dtmEnteredOn() As DateTime
            Get
                Return fdtmEnteredOn
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("dtmEnteredOn", fdtmEnteredOn, value)
            End Set
        End Property
        Dim fPO As String
        <Size(50)> _
        Public Property PO() As String
            Get
                Return fPO
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("PO", fPO, value)
            End Set
        End Property
        Dim fLot As String
        <Size(150)> _
        Public Property Lot() As String
            Get
                Return fLot
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Lot", fLot, value)
            End Set
        End Property
        Private fShift As Shifts
        Public Property Shift As Shifts
            Get
                Return fShift
            End Get
            Set(ByVal Value As Shifts)
                SetPropertyValue(Of Shifts)("Shift", fShift, Value)
            End Set
        End Property
        Private fPallet As Integer?
        Public Property Pallet As Integer?
            Get
                Return fPallet
            End Get
            Set(ByVal Value As Integer?)
                SetPropertyValue(Of Integer?)("Pallet", fPallet, Value)
            End Set
        End Property
        Private fLPNNumber As Integer?
        Public Property LPNNumber As Integer?
            Get
                Return fLPNNumber
            End Get
            Set(value As Integer?)
                SetPropertyValue(Of Integer?)("LPNNumber", fLPNNumber, value)
            End Set
        End Property
        Private fExpirationDate As Date?
        Public Property ExpirationDate As Date?
            Get
                Return fExpirationDate
            End Get
            Set(value As Date?)
                If value < #1/1/1990# Then
                    value = Nothing
                End If
                SetPropertyValue(Of Date?)("ExpirationDate", fExpirationDate, value)
            End Set
        End Property
        Private fFullLPNNumber As String
        Public Property FullLPNNumber As String
            Get
                If String.IsNullOrEmpty(fFullLPNNumber) AndAlso LPNNumber.HasValue AndAlso LPNNumber.Value > 0 Then
                    Return InventoryItemID.ItemCustomerID.LPNPrefix & Right("0000000000" & LPNNumber.Value.ToString, Len(InventoryItemID.ItemCustomerID.LastLPNNumber.ToString))
                Else
                    Return fFullLPNNumber
                End If
            End Get
            Set(value As String)
                SetPropertyValue(Of String)("FullLPNNumber", fFullLPNNumber, value)
            End Set
        End Property
        Private fShipment As Shipping
        Public Property Shipment As Shipping
            Get
                Return fShipment
            End Get
            Set(value As Shipping)
                SetPropertyValue(Of Shipping)("Shipment", fShipment, value)
            End Set
        End Property
        Private fProductionLocation As Locations
        <Association("Production-Location")>
        Public Property ProductionLocation As Locations
            Get
                Return fProductionLocation
            End Get
            Set(value As Locations)
                SetPropertyValue(Of Locations)("ProductionLocation", fProductionLocation, value)
            End Set
        End Property
        Private fLocationTransfer As LocationTransfers
        Public Property LocationTransfer As LocationTransfers
            Get
                Return fLocationTransfer
            End Get
            Set(value As LocationTransfers)
                SetPropertyValue(Of LocationTransfers)("LocationTransfer", fLocationTransfer, value)
            End Set
        End Property
        Private fNote As String
        <Size(1073741823)> _
        Public Property Note() As String
            Get
                Return fNote
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Note", fNote, value)
            End Set
        End Property

        <Association("Inventory-Consumption", GetType(BomConsumption)), Aggregated()>
        Public ReadOnly Property InventoryConsumption() As XPCollection(Of BomConsumption)
            Get
                Return GetCollection(Of BomConsumption)("InventoryConsumption")
            End Get
        End Property

        <Association("ProjectDetails-Production", GetType(ProductionProjectDetails)), Aggregated()>
        Public ReadOnly Property ProductionProject As XPCollection(Of ProductionProjectDetails)
            Get
                Return GetCollection(Of ProductionProjectDetails)("ProductionProject")
            End Get
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
        'Created/Updated: Joel-PC\Joel on JOEL-PC at 3/10/2013 5:17 PM
        Public Shadows Class FieldsClass
            Inherits XPLiteObject.FieldsClass
            Public Sub New()
                MyBase.New()
            End Sub
            Public Sub New(ByVal propertyName As String)
                MyBase.New(propertyName)
            End Sub
            Public ReadOnly Property InventoryID() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("InventoryID"))
                End Get
            End Property
            Public ReadOnly Property InventoryDate() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("InventoryDate"))
                End Get
            End Property
            Public ReadOnly Property InventoryItemID() As DXDAL.SPGData.Items.FieldsClass
                Get
                    Return New DXDAL.SPGData.Items.FieldsClass(GetNestedName("InventoryItemID"))
                End Get
            End Property
            Public ReadOnly Property InventoryQuantity() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("InventoryQuantity"))
                End Get
            End Property
            Public ReadOnly Property InventoryPallets() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("InventoryPallets"))
                End Get
            End Property
            Public Const strEnteredByFieldName As String = "strEnteredBy"
            Public ReadOnly Property strEnteredBy() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("strEnteredBy"))
                End Get
            End Property
            Public ReadOnly Property dtmEnteredOn() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("dtmEnteredOn"))
                End Get
            End Property
            Public Const POFieldName As String = "PO"
            Public ReadOnly Property PO() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("PO"))
                End Get
            End Property
            Public Const LotFieldName As String = "Lot"
            Public ReadOnly Property Lot() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("Lot"))
                End Get
            End Property
            Public ReadOnly Property Shift() As DXDAL.SPGData.Shifts.FieldsClass
                Get
                    Return New DXDAL.SPGData.Shifts.FieldsClass(GetNestedName("Shift"))
                End Get
            End Property
            Public ReadOnly Property Pallet() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Pallet"))
                End Get
            End Property
            Public ReadOnly Property LPNNumber() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("LPNNumber"))
                End Get
            End Property
            Public ReadOnly Property ExpirationDate() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ExpirationDate"))
                End Get
            End Property
            Public ReadOnly Property FullLPNNumber() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("FullLPNNumber"))
                End Get
            End Property
            Public ReadOnly Property Shipment() As DXDAL.SPGData.Shipping.FieldsClass
                Get
                    Return New DXDAL.SPGData.Shipping.FieldsClass(GetNestedName("Shipment"))
                End Get
            End Property
            Public ReadOnly Property ProductionLocation As Locations.FieldsClass
                Get
                    Return New Locations.FieldsClass(GetNestedName("ProductionLocation"))
                End Get
            End Property
            Public ReadOnly Property LocationTransfer() As LocationTransfers.FieldsClass
                Get
                    Return New LocationTransfers.FieldsClass(GetNestedName("LocationTransfer"))
                End Get
            End Property
            Public ReadOnly Property Note() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Note"))
                End Get
            End Property
        End Class
        Public Shared Shadows ReadOnly Property Fields() As FieldsClass
            Get
                If ReferenceEquals(_Fields, Nothing) Then
                    _Fields = New FieldsClass()
                End If
                Return _Fields
            End Get
        End Property
        Private Shared _Fields As FieldsClass
    End Class
End Namespace
