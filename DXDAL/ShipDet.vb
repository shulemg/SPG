Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports DevExpress.Data.Filtering

Namespace SPGData
    <Persistent("tblShipDet")> _
    Public Class ShipDet
        Inherits XPLiteObject
        Dim fShipDetDetID As Integer
        <Key(True)> _
        Public Property ShipDetDetID() As Integer
            Get
                Return fShipDetDetID
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("ShipDetDetID", fShipDetDetID, value)
            End Set
        End Property
        Dim fShipDetMainID As Shipping
        <Association("Shipping-Details")> _
        Public Property ShipDetMainID() As Shipping
            Get
                Return fShipDetMainID
            End Get
            Set(ByVal value As Shipping)
                SetPropertyValue(Of Shipping)("ShipDetMainID", fShipDetMainID, value)
            End Set
        End Property
        Dim fShipDetItemID As Items
        Public Property ShipDetItemID() As Items
            Get
                Return fShipDetItemID
            End Get
            Set(ByVal value As Items)
                SetPropertyValue(Of Items)("ShipDetItemID", fShipDetItemID, value)
            End Set
        End Property
        Dim fShipDetLot As String
        <Size(150)> _
        Public Property ShipDetLot() As String
            Get
                Return fShipDetLot
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ShipDetLot", fShipDetLot, value)
            End Set
        End Property
        Dim fShipDetDetQty As Integer
        Public Property ShipDetDetQty() As Integer
            Get
                Return fShipDetDetQty
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("ShipDetDetQty", fShipDetDetQty, value)
            End Set
        End Property
        Dim fsngPackages As Single
        Public Property sngPackages() As Single
            Get
                Return fsngPackages
            End Get
            Set(ByVal value As Single)
                SetPropertyValue(Of Single)("sngPackages", fsngPackages, value)
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
        Private m_Note As String
        <Size(255)> _
        Public Property Note() As String
            Get
                Return m_Note
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Note", m_Note, Value)
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
        Dim fFullLPNNumber As String
        Public Property FullLPNNumber() As String
            Get
                Return fFullLPNNumber
            End Get
            Set(value As String)
                SetPropertyValue(Of String)("FullLPNNumber", fFullLPNNumber, value)
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

     
        Private Shared _Fields As FieldsClass
        Public Shared Shadows ReadOnly Property Fields() As FieldsClass
            Get
                If ReferenceEquals(_Fields, Nothing) Then
                    _Fields = New FieldsClass()
                End If
                Return _Fields
            End Get
        End Property
        'Created/Updated: Joel-PC\Joel on JOEL-PC at 1/27/2013 5:05 PM
Public Shadows Class FieldsClass
        Inherits XPLiteObject.FieldsClass
        Public Sub New()
            MyBase.New()
        End Sub
        Public Sub New(ByVal propertyName As String)
            MyBase.New(propertyName)
        End Sub
        Public ReadOnly Property ShipDetDetID() As OperandProperty
            Get
                Return New OperandProperty(GetNestedName("ShipDetDetID"))
            End Get
        End Property
        Public ReadOnly Property ShipDetMainID() As DXDAL.SPGData.Shipping.FieldsClass
            Get
                Return New DXDAL.SPGData.Shipping.FieldsClass(GetNestedName("ShipDetMainID"))
            End Get
        End Property
        Public ReadOnly Property ShipDetItemID() As DXDAL.SPGData.Items.FieldsClass
            Get
                Return New DXDAL.SPGData.Items.FieldsClass(GetNestedName("ShipDetItemID"))
            End Get
        End Property
        Public Const ShipDetLotFieldName As String = "ShipDetLot"
        Public ReadOnly Property ShipDetLot() As DevExpress.Data.Filtering.OperandProperty
            Get
                Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("ShipDetLot"))
            End Get
        End Property
        Public ReadOnly Property ShipDetDetQty() As OperandProperty
            Get
                Return New OperandProperty(GetNestedName("ShipDetDetQty"))
            End Get
        End Property
        Public ReadOnly Property sngPackages() As OperandProperty
            Get
                Return New OperandProperty(GetNestedName("sngPackages"))
            End Get
        End Property
        Public ReadOnly Property sngPallets() As OperandProperty
            Get
                Return New OperandProperty(GetNestedName("sngPallets"))
            End Get
        End Property
        Public Const NoteFieldName As String = "Note"
        Public ReadOnly Property Note() As DevExpress.Data.Filtering.OperandProperty
            Get
                Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("Note"))
            End Get
            End Property
            Public Const ExpirationDateFieldName As String = "ExpirationDate"
            Public ReadOnly Property ExpirationDate() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ExpirationDate"))
                End Get
            End Property
            Public Const FullLPNNuvberFieldName As String = "FullLPNNumber"
            Public ReadOnly Property FullLPNNumber() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("FullLPNNumber"))
                End Get
            End Property
    End Class
    End Class
End Namespace
