Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Namespace SPGData
    Public Class LocationTransfers
        Inherits AuditableBase

        Dim fFromLocation As Locations
        <Association("Location-TransfersFrom")>
        Public Property FromLocation As Locations
            Get
                Return fFromLocation
            End Get
            Set(value As Locations)
                SetPropertyValue(Of Locations)("FromLocation", fFromLocation, value)
            End Set
        End Property

        Dim fToLocation As Locations
        <Association("Location-TransfersTo")>
        Public Property ToLocation As Locations
            Get
                Return fToLocation
            End Get
            Set(value As Locations)
                SetPropertyValue(Of Locations)("ToLocation", fToLocation, value)
            End Set
        End Property

        Dim fTransferDate As Date
        Public Property TransferDate As Date
            Get
                Return fTransferDate
            End Get
            Set(value As Date)
                SetPropertyValue(Of Date)("TransferDate", fTransferDate, value)
            End Set
        End Property

        Dim fTransferCarrier As Carriers
        Public Property TransferCarrier As Carriers
            Get
                Return fTransferCarrier
            End Get
            Set(value As Carriers)
                SetPropertyValue(Of Carriers)("TransferCarrier", fTransferCarrier, value)
            End Set
        End Property

        Dim fTrailer As String
        <Size(50)>
        Public Property Trailer As String
            Get
                Return fTrailer
            End Get
            Set(value As String)
                SetPropertyValue(Of String)("Trailer", fTrailer, value)
            End Set
        End Property

        Dim fTransferNumber As Integer
        Public Property TransferNumber As Integer
            Get
                Return fTransferNumber
            End Get
            Set(value As Integer)
                SetPropertyValue(Of Integer)("TransferNumber", fTransferNumber, value)
            End Set
        End Property

        Dim fLoadedBy As Employees
        <Association("Employee-LoadedTransfer")>
        Public Property LoadedBy() As Employees
            Get
                Return fLoadedBy
            End Get
            Set(value As Employees)
                SetPropertyValue(Of Employees)("LoadedBy", fLoadedBy, value)
            End Set
        End Property

        Dim fUnloadedBy As Employees
        <Association("Employee-UnloadedTransfer")>
        Public Property UnloadedBy() As Employees
            Get
                Return fUnloadedBy
            End Get
            Set(value As Employees)
                SetPropertyValue(Of Employees)("UnloadedBy", fUnloadedBy, value)
            End Set
        End Property

        Dim fCheckedBy As Employees
        <Association("Employee-CheckedTransfer")>
        Public Property CheckedBy() As Employees
            Get
                Return fCheckedBy
            End Get
            Set(value As Employees)
                SetPropertyValue(Of Employees)("CheckedBy", fCheckedBy, value)
            End Set
        End Property

        <Association("Transfer-Details", GetType(LocationTransferDetails)), Aggregated()>
        Public ReadOnly Property TransferDetails As XPCollection(Of LocationTransferDetails)
            Get
                Return GetCollection(Of LocationTransferDetails)("TransferDetails")
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
            Inherits DevExpress.Xpo.PersistentBase.FieldsClass
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
            Public ReadOnly Property FromLocation() As Locations.FieldsClass
                Get
                    Return New Locations.FieldsClass(GetNestedName("FromLocation"))
                End Get
            End Property
            Public ReadOnly Property ToLocation() As Locations.FieldsClass
                Get
                    Return New Locations.FieldsClass(GetNestedName("ToLocation"))
                End Get
            End Property
            Public ReadOnly Property TransferDate() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("TransferDate"))
                End Get
            End Property
            Public ReadOnly Property TransferCarrier() As Carriers.FieldsClass
                Get
                    Return New Carriers.FieldsClass(GetNestedName("TransferCarrier"))
                End Get
            End Property
            Public ReadOnly Property Trailer() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Trailer"))
                End Get
            End Property
            Public ReadOnly Property TransferNumber() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("TransferNumber"))
                End Get
            End Property
            Public ReadOnly Property LoadedBy() As Employees.FieldsClass
                Get
                    Return New Employees.FieldsClass(GetNestedName("LoadedBy"))
                End Get
            End Property
            Public ReadOnly Property UnloadedBy() As Employees.FieldsClass
                Get
                    Return New Employees.FieldsClass(GetNestedName("UnloadedBy"))
                End Get
            End Property
            Public ReadOnly Property CheckedBy() As Employees.FieldsClass
                Get
                    Return New Employees.FieldsClass(GetNestedName("CheckedBy"))
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
