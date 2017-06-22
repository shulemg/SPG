Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Namespace SPGData
    Public Class LocationTransferDetails
        Inherits AuditableBase

        Dim fTransfer As LocationTransfers
        <Association("Transfer-Details")>
        Public Property Transfer As LocationTransfers
            Get
                Return fTransfer
            End Get
            Set(value As LocationTransfers)
                SetPropertyValue(Of LocationTransfers)("Transfer", fTransfer, value)
            End Set
        End Property

        Dim fTransferItem As Items
        <Association("Transfer-Item")>
        Public Property TransferItem As Items
            Get
                Return fTransferItem
            End Get
            Set(value As Items)
                SetPropertyValue(Of Items)("TransferItem", fTransferItem, value)
            End Set
        End Property

        Dim fTransferlot As String
        <Size(150)>
        Public Property TransferLot As String
            Get
                Return fTransferlot
            End Get
            Set(value As String)
                SetPropertyValue(Of String)("Transferlot", fTransferlot, value)
            End Set
        End Property

        Dim fTransferQuantity As Integer
        Public Property TransferQuantity As Integer
            Get
                Return fTransferQuantity
            End Get
            Set(value As Integer)
                SetPropertyValue(Of Integer)("TransferQuantity", fTransferQuantity, value)
            End Set
        End Property

        Dim fTransferUnits As Integer?
        Public Property TransferUnits As Integer?
            Get
                Return fTransferUnits
            End Get
            Set(value As Integer?)
                SetPropertyValue(Of Integer?)("TransferUnits", fTransferUnits, value)
            End Set
        End Property

        Dim fTransferPallets As Single
        Public Property TransferPallets As Single
            Get
                Return fTransferPallets
            End Get
            Set(value As Single)
                SetPropertyValue(Of Single)("TransferPallets", fTransferPallets, value)
            End Set
        End Property

        Dim fItemExpirationDate As Date
        Public Property ItemExpirationDate As Date
            Get
                Return fItemExpirationDate
            End Get
            Set(value As Date)
                SetPropertyValue(Of Date)("ItemExpirationDate", fItemExpirationDate, value)
            End Set
        End Property

        Dim fFullLpnNumber As String
        Public Property FullLpnNumber As String
            Get
                Return fFullLpnNumber
            End Get
            Set(value As String)
                SetPropertyValue(Of String)("FullLpnNumber", fFullLpnNumber, value)
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
            Inherits DevExpress.Xpo.PersistentBase.FieldsClass
            Public Sub New()
                MyBase.New()
            End Sub
            Public Sub New(ByVal propertyName As String)
                MyBase.New(propertyName)
            End Sub
            Public ReadOnly Property Transfer() As LocationTransfers.FieldsClass
                Get
                    Return New LocationTransfers.FieldsClass(GetNestedName("Transfer"))
                End Get
            End Property
            Public ReadOnly Property TransferItem() As Items.FieldsClass
                Get
                    Return New Items.FieldsClass(GetNestedName("TransferItem"))
                End Get
            End Property
            Public ReadOnly Property TransferLot() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("TransferLot"))
                End Get
            End Property
            Public ReadOnly Property TransferQuantity() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("TransferQuantity"))
                End Get
            End Property
            Public ReadOnly Property TransferUnits() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("TransferUnits"))
                End Get
            End Property
            Public ReadOnly Property TransferPallets() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("TransferPallets"))
                End Get
            End Property
            Public ReadOnly Property ItemExpirationDate() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ItemExpirationDate"))
                End Get
            End Property
            Public ReadOnly Property FullLpnNumber() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("FullLpnNumber"))
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
