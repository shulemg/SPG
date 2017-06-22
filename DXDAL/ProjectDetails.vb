Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Namespace SPGData

    Public Class ProjectDetails
        Inherits AuditableBase

        ' Fields...
        Private _allowOverrun As Boolean
        'Private _percentageComplete As Decimal
        'Private _palletsProduced As Integer
        'Private _bagsProduced As Integer
        'Private _unitsProduced As Integer
        Private _palletsRequested As Integer
        Private _bagsRequested As Integer
        Private _unitsRequested As Integer
        Private _projectItem As Items
        Private _customerPO As String
        Private _project As Project

        <Association("Project-Details")>
        Public Property Project As Project
            Get
                Return _project
            End Get
            Set(ByVal Value As Project)
                SetPropertyValue(Of Project)("Project", _project, Value)
            End Set
        End Property

        Public Property CustomerPO As String
            Get
                Return _customerPO
            End Get
            Set(ByVal Value As String)
                SetPropertyValue(Of String)("CustomerPO", _customerPO, Value)
            End Set
        End Property

        Public Property ProjectItem As Items
            Get
                Return _projectItem
            End Get
            Set(ByVal Value As Items)
                SetPropertyValue(Of Items)("ProjectItem", _projectItem, Value)
            End Set
        End Property

        Public Property UnitsRequested As Integer
            Get
                Return _unitsRequested
            End Get
            Set(ByVal Value As Integer)
                SetPropertyValue(Of Integer)("UnitsRequested", _unitsRequested, Value)
            End Set
        End Property

        Public Property BagsRequested As Integer
            Get
                Return _bagsRequested
            End Get
            Set(ByVal Value As Integer)
                SetPropertyValue(Of Integer)("BagsRequested", _bagsRequested, Value)
            End Set
        End Property

        Public Property PalletsRequested As Integer
            Get
                Return _palletsRequested
            End Get
            Set(ByVal Value As Integer)
                SetPropertyValue(Of Integer)("PalletsRequested", _palletsRequested, Value)
            End Set
        End Property

        Public Property AllowOverrun As Boolean
            Get
                Return _allowOverrun
            End Get
            Set(ByVal Value As Boolean)
                SetPropertyValue(Of Boolean)("AllowOverrun", _allowOverrun, Value)
            End Set
        End Property
        
        <Association("Production-ProjectDetail", GetType(ProductionProjectDetails)), Aggregated()>
        Public ReadOnly Property ProjectProduction As XPCollection(Of ProductionProjectDetails)
            Get
                Return GetCollection(Of ProductionProjectDetails)("ProjectProduction")
            End Get
        End Property

        <Association("Project-ProductionSchedule", GetType(ProductionSchedule)), Aggregated()>
        Public ReadOnly Property ProjectProductionSchedule As XPCollection(Of ProductionSchedule)
            Get
                Return GetCollection(Of ProductionSchedule)("ProjectProductionSchedule")
            End Get
        End Property

        <PersistentAlias("IsNull(ProjectProduction.Sum(UnitsProduced), 0)")>
        Public ReadOnly Property UnitsProduced As Integer
            Get
                Return Convert.ToInt32(EvaluateAlias("UnitsProduced"))
            End Get
        End Property

        <PersistentAlias("IsNull(ProjectProductionSchedule.Sum(Quantity), 0)")>
        Public ReadOnly Property UnitsScheduled As Integer
            Get
                Return Convert.ToInt32(EvaluateAlias("UnitsScheduled"))
            End Get
        End Property

        'used to identify if there's still units needed to produce
        Public ReadOnly Property UnitsNeeded As Integer
            Get
                Return Math.Max(UnitsRequested - UnitsProduced, 0)
            End Get
        End Property

        'Used to identify if there's still units needed to be scheduled
        Public ReadOnly Property UnitsNeededToSchedule As Integer
            Get
                Return Math.Max(UnitsRequested - Math.Max(UnitsProduced, UnitsScheduled), 0)
            End Get
        End Property

        <PersistentAlias("ProjectProduction.Sum(BagsProduced)")>
        Public ReadOnly Property BagsProduced As Integer
            Get
                Return Convert.ToInt32(EvaluateAlias("BagsProduced"))
            End Get
        End Property

        <PersistentAlias("ProjectProduction.Sum(PalletsProduced)")>
        Public ReadOnly Property PalletsProduced As Integer
            Get
                Return Convert.ToInt32(EvaluateAlias("PalletsProduced"))
            End Get
        End Property

        Public ReadOnly Property PercentageComplete As Double
            Get
                If UnitsProduced = 0 OrElse UnitsRequested = 0 Then
                    Return 0
                End If

                Return UnitsProduced / UnitsRequested * 100
            End Get
        End Property

        Public ReadOnly Property EstimatedShifts As Double?
            Get
                If ProjectItem Is Nothing OrElse UnitsRequested = 0 OrElse ProjectItem.ItemProdStandard.HasValue = False OrElse ProjectItem.ItemProdStandard.Value = 0 Then
                    Return Nothing
                End If

                Return (UnitsRequested * ProjectItem.intQtyPerUnit) / (ProjectItem.ItemProdStandard.Value * 358.3333)     '7:10 * 50 min per hour
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
            Public ReadOnly Property Project() As Project.FieldsClass
                Get
                    Return New Project.FieldsClass(GetNestedName("Project"))
                End Get
            End Property
            Public ReadOnly Property CustomerPO() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("CustomerPO"))
                End Get
            End Property
            Public ReadOnly Property ProjectItem() As Items.FieldsClass
                Get
                    Return New Items.FieldsClass(GetNestedName("ProjectItem"))
                End Get
            End Property
            Public ReadOnly Property UnitsRequested() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("UnitsRequested"))
                End Get
            End Property
            Public ReadOnly Property BagsRequested() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("BagsRequested"))
                End Get
            End Property
            Public ReadOnly Property PalletsRequested() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("PalletsRequested"))
                End Get
            End Property
            Public ReadOnly Property UnitsProduced() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("UnitsProduced"))
                End Get
            End Property
            Public ReadOnly Property BagsProduced() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("BagsProduced"))
                End Get
            End Property
            Public ReadOnly Property PalletsProduced() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("PalletsProduced"))
                End Get
            End Property
            Public ReadOnly Property PercentageComplete() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("PercentageComplete"))
                End Get
            End Property
            Public ReadOnly Property AllowOverrun() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("AllowOverrun"))
                End Get
            End Property
            Public ReadOnly Property EstimatedShifts() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("EstimatedShifts"))
                End Get
            End Property
            Public ReadOnly Property UnitsScheduled() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("UnitsScheduled"))
                End Get
            End Property
            Public ReadOnly Property UnitsNeeded As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("UnitsNeeded"))
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
