Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports DevExpress.Data.Filtering

Namespace SPGData
    <Persistent("tblReceivDet")> _
    Public Class ReceivingDetail
        Inherits XPLiteObject
        Dim fReceivDetID As Integer
        <Key(True)> _
        Public Property ReceivDetID() As Integer
            Get
                Return fReceivDetID
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("ReceivDetID", fReceivDetID, value)
            End Set
        End Property
        Dim fReceivMainID As Receiving
        <Association("Receiving-Details")> _
        Public Property ReceivMainID() As Receiving
            Get
                Return fReceivMainID
            End Get
            Set(ByVal value As Receiving)
                SetPropertyValue("ReceivMainID", fReceivMainID, value)
            End Set
        End Property
        Dim fReceivDetItemID As Items
        Public Property ReceivDetItemID() As Items
            Get
                Return fReceivDetItemID
            End Get
            Set(ByVal value As Items)
                SetPropertyValue("ReceivDetItemID", fReceivDetItemID, value)
            End Set
        End Property
        Dim fReceivDetLot As String
        <Size(150)>
        Public Property ReceivDetLot() As String
            Get
                Return fReceivDetLot
            End Get
            Set(ByVal value As String)
                SetPropertyValue("ReceivDetLot", fReceivDetLot, value)
            End Set
        End Property
        Dim fReceivDetLPN As Integer?
        Public Property ReceivDetLPN() As Integer?
            Get
                Return fReceivDetLPN
            End Get
            Set(ByVal value As Integer?)
                SetPropertyValue("ReceivDetLPN", fReceivDetLPN, value)
            End Set
        End Property
        Dim fReceivDetQty As Integer
        Public Property ReceivDetQty() As Integer
            Get
                Return fReceivDetQty
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("ReceivDetQty", fReceivDetQty, value)
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
        Dim fExpirationDate As Date?
        Public Property ExpirationDate() As Date?
            Get
                Return fExpirationDate
            End Get
            Set(value As Date?)
                SetPropertyValue(Of Date?)("ExpirationDate", fExpirationDate, value)
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
        'Created/Updated: Joel-PC\Joel on JOEL-PC at 1/27/2013 4:56 PM
        Public Shadows Class FieldsClass
            Inherits PersistentBase.FieldsClass
            Public Sub New()
                MyBase.New()
            End Sub
            Public Sub New(ByVal propertyName As String)
                MyBase.New(propertyName)
            End Sub
            Public ReadOnly Property ReceivDetID() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ReceivDetID"))
                End Get
            End Property
            Public ReadOnly Property ReceivMainID() As Receiving.FieldsClass
                Get
                    Return New Receiving.FieldsClass(GetNestedName("ReceivMainID"))
                End Get
            End Property
            Public ReadOnly Property ReceivDetItemID() As Items.FieldsClass
                Get
                    Return New Items.FieldsClass(GetNestedName("ReceivDetItemID"))
                End Get
            End Property
            Public Const ReceivDetLotFieldName As String = "ReceivDetLot"
            Public ReadOnly Property ReceivDetLot() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ReceivDetLot"))
                End Get
            End Property
            Public ReadOnly Property ReceivDetLPN() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ReceivDetLPN"))
                End Get
            End Property
            Public ReadOnly Property ReceivDetQty() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ReceivDetQty"))
                End Get
            End Property
            Public ReadOnly Property intUnits() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("intUnits"))
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
