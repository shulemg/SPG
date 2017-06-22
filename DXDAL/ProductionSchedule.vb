Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Namespace SPGData
    Public Class ProductionSchedule
        Inherits AuditableBase

        Private _finish As DateTime
        Private _start As DateTime
        Private _machineLine As MachineLine
        Private _people As Double?
        Private _machineOperator As Double?
        Private _productionItem As Items
        Private _mustRun As Boolean?
        Private _priorityLevel As Integer?
        Private _project As Project
        Private _projectDetail As ProjectDetails
        Private _scheduleNote As String
        Private _Quantity As Double
        Private _scheduleByQuantity As Boolean

        Public Property Finish() As DateTime
            Get
                Return _finish
            End Get
            Set(value As DateTime)
                SetPropertyValue(Of DateTime)("Finish", _finish, value)
            End Set
        End Property

        Public Property Start() As DateTime
            Get
                Return _start
            End Get
            Set(value As DateTime)
                SetPropertyValue(Of DateTime)("Start", _start, value)
            End Set
        End Property

        Public Property MachineLine() As MachineLine
            Get
                Return _machineLine
            End Get
            Set(value As MachineLine)
                SetPropertyValue(Of MachineLine)("MachineLine", _machineLine, value)
            End Set
        End Property

        Public Property People As Double?
            Get
                Return _people
            End Get
            Set(value As Double?)
                SetPropertyValue(Of Double?)("People", _people, value)
            End Set
        End Property

        Public Property MachineOperator As Double?
            Get
                Return _machineOperator
            End Get
            Set(value As Double?)
                SetPropertyValue(Of Double?)("MachineOperator", _machineOperator, value)
            End Set
        End Property

        Public Property ProductionItem As Items
            Get
                Return _productionItem
            End Get
            Set(value As Items)
                SetPropertyValue(Of Items)("ProductionItem", _productionItem, value)
            End Set
        End Property

        Public Property MustRun As Boolean?
            Get
                Return _mustRun
            End Get
            Set(value As Boolean?)
                SetPropertyValue(Of Boolean?)("MustRun", _mustRun, value)
            End Set
        End Property

        Public Property PriorityLevel As Integer?
            Get
                Return _priorityLevel
            End Get
            Set(value As Integer?)
                SetPropertyValue(Of Integer?)("PriorityLevel", _priorityLevel, value)
            End Set
        End Property

        Public Property Project As Project
            Get
                Return _project
            End Get
            Set(value As Project)
                SetPropertyValue(Of Project)("Project", _project, value)
            End Set
        End Property

        <Association("Project-ProductionSchedule")>
        Public Property ProjectDetail As ProjectDetails
            Get
                Return _projectDetail
            End Get
            Set(value As ProjectDetails)
                SetPropertyValue(Of ProjectDetails)("ProjectDetail", _projectDetail, value)
            End Set
        End Property

        <Size(SizeAttribute.Unlimited)>
        Public Property ScheduleNote As String
            Get
                Return _ScheduleNote
            End Get
            Set(value As String)
                SetPropertyValue(Of String)("ScheduleNote", _scheduleNote, value)
            End Set
        End Property

        Public Property Quantity As Double
            Get
                Return _Quantity
            End Get
            Set(value As Double)
                SetPropertyValue(Of Double)("Quantity", _Quantity, value)
            End Set
        End Property

        Public Property ScheduleByQuantity As Boolean
            Get
                Return _scheduleByQuantity
            End Get
            Set(value As Boolean)
                SetPropertyValue(Of Boolean)("ScheduleByQuantity", _scheduleByQuantity, value)
            End Set
        End Property

        Public ReadOnly Property ScheduleTitle As String
            Get
                If Project IsNot Nothing AndAlso ProductionItem IsNot Nothing Then
                    Return String.Format("{0} - {1}", Project.Project, ProductionItem.ItemCode)
                ElseIf ProductionItem IsNot Nothing Then
                    Return ProductionItem.ItemCode
                ElseIf Project IsNot Nothing Then
                    Return Project.Project
                Else
                    Return String.Empty
                End If
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
            Public ReadOnly Property Finish As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Finish"))
                End Get
            End Property
            Public ReadOnly Property Start As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Start"))
                End Get
            End Property
            Public ReadOnly Property MachineLine As MachineLine.FieldsClass
                Get
                    Return New MachineLine.FieldsClass(GetNestedName("MachineLine"))
                End Get
            End Property
            Public ReadOnly Property People As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("People"))
                End Get
            End Property
            Public ReadOnly Property MachineOperator As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("MachineOperator"))
                End Get
            End Property
            Public ReadOnly Property ProductionItem As Items.FieldsClass
                Get
                    Return New Items.FieldsClass(GetNestedName("ProductionItem"))
                End Get
            End Property
            Public ReadOnly Property MustRun As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("MustRun"))
                End Get
            End Property
            Public ReadOnly Property PriorityLevel As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("PriorityLevel"))
                End Get
            End Property
            Public ReadOnly Property Project As Project.FieldsClass
                Get
                    Return New Project.FieldsClass(GetNestedName("Project"))
                End Get
            End Property
            Public ReadOnly Property ProjectDetail As ProjectDetails.FieldsClass
                Get
                    Return New ProjectDetails.FieldsClass(GetNestedName("ProjectDetail"))
                End Get
            End Property
            Public ReadOnly Property ScheduleNote As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ScheduleNote"))
                End Get
            End Property
            Public ReadOnly Property Quantity As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Quantity"))
                End Get
            End Property
            Public ReadOnly Property ScheduleByQuantity As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ScheduleByQuantity"))
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