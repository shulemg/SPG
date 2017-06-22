Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports DevExpress.Data.Filtering

Namespace SPGData
    <Persistent("tblShipReturnDet")> _
    Public Class ShippedReturns
        Inherits XPLiteObject
        Dim fReturnDetID As Integer
        <Key(True)> _
        Public Property ReturnDetID() As Integer
            Get
                Return fReturnDetID
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("ReturnDetID", fReturnDetID, value)
            End Set
        End Property
        Dim fShipMainID As Shipping
        <Association("Shippiing-Returns")> _
        Public Property ShipMainID() As Shipping
            Get
                Return fShipMainID
            End Get
            Set(ByVal value As Shipping)
                SetPropertyValue(Of Shipping)("ShipMainID", fShipMainID, value)
            End Set
        End Property
        Dim fReturnDetItemID As Items
        Public Property ReturnDetItemID() As Items
            Get
                Return fReturnDetItemID
            End Get
            Set(ByVal value As Items)
                SetPropertyValue(Of Items)("ReturnDetItemID", fReturnDetItemID, value)
            End Set
        End Property
        Dim fReturnDetLot As String
        <Size(150)> _
        Public Property ReturnDetLot() As String
            Get
                Return fReturnDetLot
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ReturnDetLot", fReturnDetLot, value)
            End Set
        End Property
        Dim fReturnDetQty As Integer
        Public Property ReturnDetQty() As Integer
            Get
                Return fReturnDetQty
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("ReturnDetQty", fReturnDetQty, value)
            End Set
        End Property
        Dim fintUnits As Integer
        Public Property intUnits() As Integer
            Get
                Return fintUnits
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("intUnits", fintUnits, value)
            End Set
        End Property
        Dim fsngPallets As Single
        Public Property sngPallets() As Single
            Get
                Return fsngPallets
            End Get
            Set(ByVal value As Single)
                SetPropertyValue(Of Single)("sngPallets", fsngPallets, value)
            End Set
        End Property
        Dim fReason As String
        <Size(255)> _
        Public Property Reason() As String
            Get
                Return fReason
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Reason", fReason, value)
            End Set
        End Property
        Dim fExpirationDate As Date
        Public Property ExpirationDate() As Date
            Get
                Return fExpirationDate
            End Get
            Set(value As Date)
                SetPropertyValue(Of Date)("ExpirationDate", fExpirationDate, value)
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
        'Created/Updated: Joel-PC\Joel on JOEL-PC at 1/27/2013 5:06 PM
Public Shadows Class FieldsClass
        Inherits XPLiteObject.FieldsClass
        Public Sub New()
            MyBase.New()
        End Sub
        Public Sub New(ByVal propertyName As String)
            MyBase.New(propertyName)
        End Sub
        Public ReadOnly Property ReturnDetID() As OperandProperty
            Get
                Return New OperandProperty(GetNestedName("ReturnDetID"))
            End Get
        End Property
        Public ReadOnly Property ShipMainID() As DXDAL.SPGData.Shipping.FieldsClass
            Get
                Return New DXDAL.SPGData.Shipping.FieldsClass(GetNestedName("ShipMainID"))
            End Get
        End Property
        Public ReadOnly Property ReturnDetItemID() As DXDAL.SPGData.Items.FieldsClass
            Get
                Return New DXDAL.SPGData.Items.FieldsClass(GetNestedName("ReturnDetItemID"))
            End Get
        End Property
        Public Const ReturnDetLotFieldName As String = "ReturnDetLot"
        Public ReadOnly Property ReturnDetLot() As DevExpress.Data.Filtering.OperandProperty
            Get
                Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("ReturnDetLot"))
            End Get
        End Property
        Public ReadOnly Property ReturnDetQty() As OperandProperty
            Get
                Return New OperandProperty(GetNestedName("ReturnDetQty"))
            End Get
        End Property
        Public ReadOnly Property intUnits() As OperandProperty
            Get
                Return New OperandProperty(GetNestedName("intUnits"))
            End Get
        End Property
        Public ReadOnly Property sngPallets() As OperandProperty
            Get
                Return New OperandProperty(GetNestedName("sngPallets"))
            End Get
        End Property
        Public Const ReasonFieldName As String = "Reason"
        Public ReadOnly Property Reason() As DevExpress.Data.Filtering.OperandProperty
            Get
                Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("Reason"))
            End Get
            End Property
            Public Const ExpirationDateFieldName As String = "ExpirationDate"
            Public ReadOnly Property ExpirationDate() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ExpirationDate"))
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
