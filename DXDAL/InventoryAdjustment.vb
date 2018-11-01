Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports DevExpress.Data.Filtering

Namespace SPGData
    <Persistent("tblInventoryAdjustment")> _
    Public Class InventoryAdjustment
        Inherits XPLiteObject
        Dim fAdjustmentID As Integer
        <Key(True)> _
        Public Property AdjustmentID() As Integer
            Get
                Return fAdjustmentID
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("AdjustmentID", fAdjustmentID, value)
            End Set
        End Property
        Dim fAdjustmentDate As DateTime
        Public Property AdjustmentDate() As DateTime
            Get
                Return fAdjustmentDate
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("AdjustmentDate", fAdjustmentDate, value)
            End Set
        End Property
        Dim fCustomer As customers
        Public Property Customer() As customers
            Get
                Return fCustomer
            End Get
            Set(ByVal value As customers)
                SetPropertyValue("Customer", fCustomer, value)
            End Set
        End Property
        Dim fItem As Items
        <Persistent("Item")>
        Public Property AdjustmentItem() As Items
            Get
                Return fItem
            End Get
            Set(ByVal value As Items)
                SetPropertyValue("AdjustmentItem", fItem, value)
            End Set
        End Property
        Dim fOriginalQuantity As Single
        Public Property OriginalQuantity() As Single
            Get
                Return fOriginalQuantity
            End Get
            Set(ByVal value As Single)
                SetPropertyValue("OriginalQuantity", fOriginalQuantity, value)
            End Set
        End Property
        Dim fNewCount As Single
        Public Property NewCount() As Single
            Get
                Return fNewCount
            End Get
            Set(ByVal value As Single)
                SetPropertyValue("NewCount", fNewCount, value)
            End Set
        End Property
        Dim fOriginalLot As String
        Public Property OriginalLot() As String
            Get
                Return fOriginalLot
            End Get
            Set(ByVal value As String)
                SetPropertyValue("OriginalLot", fOriginalLot, value)
            End Set
        End Property
        Dim fNewLot As String
        Public Property NewLot() As String
            Get
                Return fNewLot
            End Get
            Set(ByVal value As String)
                SetPropertyValue("NewLot", fNewLot, value)
            End Set
        End Property
        Dim fLPN As Integer?
        Public Property LPN() As Integer?
            Get
                Return fLPN
            End Get
            Set(ByVal value As Integer?)
                SetPropertyValue("LPN", fLPN, value)
            End Set
        End Property
        Dim fReason As String
        <Size(150)>
        Public Property Reason() As String
            Get
                Return fReason
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Reason", fReason, value)
            End Set
        End Property
        Dim fstrEnteredBy As String
        <Size(50)>
        Public Property strEnteredBy() As String
            Get
                Return fstrEnteredBy
            End Get
            Set(ByVal value As String)
                SetPropertyValue("strEnteredBy", fstrEnteredBy, value)
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
        Dim fInventoryLocation As Locations
        Public Property InventoryLocation() As Locations
            Get
                Return fInventoryLocation
            End Get
            Set(value As Locations)
                SetPropertyValue("InventoryLocation", fInventoryLocation, value)
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
        Public Shadows Class FieldsClass
            Inherits PersistentBase.FieldsClass
            Public Sub New()
                MyBase.New()
            End Sub
            Public Sub New(ByVal propertyName As String)
                MyBase.New(propertyName)
            End Sub
            Public ReadOnly Property AdjustmentID() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("AdjustmentID"))
                End Get
            End Property
            Public ReadOnly Property AdjustmentDate() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("AdjustmentDate"))
                End Get
            End Property
            Public ReadOnly Property Customer() As Customers.FieldsClass
                Get
                    Return New customers.FieldsClass(GetNestedName("Customer"))
                End Get
            End Property
            Public ReadOnly Property AdjustmentItem() As Items.FieldsClass
                Get
                    Return New Items.FieldsClass(GetNestedName("AdjustmentItem"))
                End Get
            End Property
            Public ReadOnly Property OriginalQuantity() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("OriginalQuantity"))
                End Get
            End Property
            Public ReadOnly Property NewCount() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("NewCount"))
                End Get
            End Property
            Public ReadOnly Property OriginalLot() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("OriginalLot"))
                End Get
            End Property
            Public ReadOnly Property NewLot() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("NewLot"))
                End Get
            End Property
            Public ReadOnly Property LPN() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("LPN"))
                End Get
            End Property
            Public ReadOnly Property Reason() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Reason"))
                End Get
            End Property
            Public ReadOnly Property strEnteredBy() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("strEnteredBy"))
                End Get
            End Property
            Public ReadOnly Property dtmEnteredOn() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("dtmEnteredOn"))
                End Get
            End Property
            Public ReadOnly Property InventoryLocation() As Locations.FieldsClass
                Get
                    Return New Locations.FieldsClass(GetNestedName("InventoryLocation"))
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
