Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo.Helpers

Namespace SPGData

    Public Class BreakTime
        Inherits XPObject

#Region "Constructors"

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
            ' This constructor is used when an object is loaded from a persistent storage.
            ' Do not place any code here.			
        End Sub
#End Region

#Region "Persistent Properties"
        
        Private m_WeekDay As DayOfWeek
        Public Property WeekDay() As DayOfWeek
            Get
                Return m_WeekDay
            End Get
            Set(ByVal value As DayOfWeek)
                SetPropertyValue(Of DayOfWeek)("WeekDay", m_WeekDay, value)
            End Set
        End Property

        Private m_StartTime As DateTime
        Public Property StartTime() As DateTime
            Get
                Return m_StartTime
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("StartTime", m_StartTime, value)
            End Set
        End Property

        Private m_EndTime As DateTime
        Public Property EndTime() As DateTime
            Get
                Return m_EndTime
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("EndTime", m_EndTime, value)
            End Set
        End Property

        Private m_Starting As Date
        Public Property Starting() As Date
            Get
                Return m_Starting
            End Get
            Set(ByVal value As Date)
                SetPropertyValue(Of Date)("Starting", m_Starting, value)
            End Set
        End Property

        Private m_Ending As Date
        Public Property Ending() As Date
            Get
                Return m_Ending
            End Get
            Set(ByVal value As Date)
                SetPropertyValue(Of Date)("Ending", m_Ending, value)
            End Set
        End Property

#End Region








#Region "XPO nested fields class - don't edit manually"
        Public Shadows Class FieldsClass
            Inherits DevExpress.Xpo.XPObject.FieldsClass
            Public Sub New()
                MyBase.New()
            End Sub
            Public Sub New(ByVal propertyName As String)
                MyBase.New(propertyName)
            End Sub
            Public ReadOnly Property WeekDay() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("WeekDay"))
                End Get
            End Property
            Public ReadOnly Property StartTime() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("StartTime"))
                End Get
            End Property
            Public ReadOnly Property EndTime() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("EndTime"))
                End Get
            End Property
            Public ReadOnly Property Starting() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Starting"))
                End Get
            End Property
            Public ReadOnly Property Ending() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Ending"))
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

