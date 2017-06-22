Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Namespace SPGData
    Public Class ProductionProjectDetails
        Inherits AuditableBase

        Private _ProjectDetail As ProjectDetails
        Private _Production As Inventory
        Private _unitsProduced As Integer
        Private _bagsProduced As Integer
        Private _palletsProduced As Integer
        Private _IsOverrun As Boolean

        <Association("Production-ProjectDetail")>
        Public Property ProjectDetail As ProjectDetails
            Get
                Return _ProjectDetail
            End Get
            Set(value As ProjectDetails)
                SetPropertyValue(Of ProjectDetails)("ProjectDetail", _ProjectDetail, value)
            End Set
        End Property

        <Association("ProjectDetails-Production")>
        Public Property Production As Inventory
            Get
                Return _Production
            End Get
            Set(value As Inventory)
                SetPropertyValue(Of Inventory)("Production", _Production, value)
            End Set
        End Property

        Public Property UnitsProduced As Integer
            Get
                Return _unitsProduced
            End Get
            Set(ByVal Value As Integer)
                SetPropertyValue(Of Integer)("UnitsProduced", _unitsProduced, Value)
            End Set
        End Property

        Public Property BagsProduced As Integer
            Get
                Return _bagsProduced
            End Get
            Set(ByVal Value As Integer)
                SetPropertyValue(Of Integer)("BagsProduced", _bagsProduced, Value)
            End Set
        End Property

        Public Property PalletsProduced As Integer
            Get
                Return _palletsProduced
            End Get
            Set(ByVal Value As Integer)
                SetPropertyValue(Of Integer)("PalletsProduced", _palletsProduced, Value)
            End Set
        End Property

        Public Property IsOverrun As Boolean
            Get
                Return _IsOverrun
            End Get
            Set(ByVal Value As Boolean)
                SetPropertyValue(Of Boolean)("IsOverrun", _IsOverrun, Value)
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
            Public ReadOnly Property Oid() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Oid"))
                End Get
            End Property
            Public ReadOnly Property ProjectDetail As ProjectDetails.FieldsClass
                Get
                    Return New ProjectDetails.FieldsClass(GetNestedName("ProjectDetail"))
                End Get
            End Property
            Public ReadOnly Property Production As Inventory.FieldsClass
                Get
                    Return New Inventory.FieldsClass(GetNestedName("Production"))
                End Get
            End Property
            Public ReadOnly Property UnitsProduced As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("UnitsProduced"))
                End Get
            End Property
            Public ReadOnly Property BagsProduced As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("BagsProduced"))
                End Get
            End Property
            Public ReadOnly Property PalletsProduced As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("PalletsProduced"))
                End Get
            End Property
            Public ReadOnly Property IsOverrun As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("PalletsProduced"))
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