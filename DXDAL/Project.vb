Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Namespace SPGData
    Public Class Project
        Inherits AuditableBase

        Private _actualStartDate As Date?
        Private _scheduledDate As Date?
        Private _scheduledWeek As String
        Private _projectStatus As ProjectStatus
        Private _requestedDeliveryDate As Date?
        Private _requestedShippingDate As Date?
        Private _requestedStartDate As Date?
        Private _notes As String
        Private _customer As Customers
        Private _project As String

        Public Property Project As String
            Get
                Return _project
            End Get
            Set(ByVal Value As String)
                SetPropertyValue("Project", _project, Value)
            End Set
        End Property

        <Association("Customer-Projects")>
        Public Property Customer As Customers
            Get
                Return _customer
            End Get
            Set(ByVal Value As Customers)
                SetPropertyValue("Customer", _customer, Value)
            End Set
        End Property

        Public Property Notes As String
            Get
                Return _notes
            End Get
            Set(ByVal Value As String)
                SetPropertyValue("Notes", _notes, Value)
            End Set
        End Property

        Public Property RequestedStartDate As Date?
            Get
                Return _requestedStartDate
            End Get
            Set(ByVal Value As Date?)
                SetPropertyValue("RequestedStartDate", _requestedStartDate, Value)
            End Set
        End Property

        Public Property RequestedShippingDate As Date?
            Get
                Return _requestedShippingDate
            End Get
            Set(ByVal Value As Date?)
                SetPropertyValue("RequestedShippingDate", _requestedShippingDate, Value)
            End Set
        End Property

        Public Property RequestedDeliveryDate As Date?
            Get
                Return _requestedDeliveryDate
            End Get
            Set(ByVal Value As Date?)
                SetPropertyValue("RequestedDeliveryDate", _requestedDeliveryDate, Value)
            End Set
        End Property

        Public Property ProjectStatus As ProjectStatus
            Get
                If _projectStatus <> ProjectStatus.Completed Then
                    If CInt(Evaluate("ProjectDetails.Sum(UnitsNeeded)")) <> CInt(Evaluate("ProjectDetails.Sum(UnitsRequested)")) Then
                        Return ProjectStatus.Started
                    End If
                    If CInt(Evaluate("ProjectDetails.Sum(UnitsNeededToSchedule)")) <= 0 Then
                        Return ProjectStatus.Scheduled
                    End If
                    Return ProjectStatus.Open
                End If

                Return _projectStatus
            End Get
            Set(ByVal Value As ProjectStatus)
                SetPropertyValue("ProjectStatus", _projectStatus, Value)
            End Set
        End Property

        Public Property ScheduledDate As Date?
            Get
                Return _scheduledDate
            End Get
            Set(ByVal Value As Date?)
                SetPropertyValue("ScheduledDate", _scheduledDate, Value)
            End Set
        End Property

        Public Property ScheduledWeek As String
            Get
                Return _scheduledWeek
            End Get
            Set(value As String)
                SetPropertyValue("ScheduledWeek", _scheduledWeek, value)
            End Set
        End Property

        Public Property ActualStartDate As Date?
            Get
                Return _actualStartDate
            End Get
            Set(ByVal Value As Date?)
                SetPropertyValue("ActualStartDate", _actualStartDate, Value)
            End Set
        End Property

        <Association("Project-Details", GetType(ProjectDetails)), Aggregated()>
        Public ReadOnly Property ProjectDetails As XPCollection(Of ProjectDetails)
            Get
                Return GetCollection(Of ProjectDetails)("ProjectDetails")
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

        Public Overrides Function ToString() As String

            Return String.Format("{0} - {1}", Oid, Project)

        End Function

        Public Shadows Class FieldsClass
            Inherits PersistentBase.FieldsClass
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
            Public ReadOnly Property Project() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Project"))
                End Get
            End Property
            Public ReadOnly Property Customer() As Customers.FieldsClass
                Get
                    Return New Customers.FieldsClass(GetNestedName("Customer"))
                End Get
            End Property
            Public ReadOnly Property Notes() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Notes"))
                End Get
            End Property
            Public ReadOnly Property RequestedStartDate() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("RequestedStartDate"))
                End Get
            End Property
            Public ReadOnly Property RequestedShippingDate() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("RequestedShippingDate"))
                End Get
            End Property
            Public ReadOnly Property RequestedDeliveryDate() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("RequestedDeliveryDate"))
                End Get
            End Property
            Public ReadOnly Property ProjectStatus() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ProjectStatus"))
                End Get
            End Property
            Public ReadOnly Property ScheduledWeek() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ScheduledWeek"))
                End Get
            End Property
            Public ReadOnly Property ScheduledDate() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ScheduledDate"))
                End Get
            End Property
            Public ReadOnly Property ActualStartDate() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ActualStartDate"))
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
