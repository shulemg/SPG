Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports DevExpress.Data.Filtering
Imports System.Text

Namespace SPGData
    <Persistent("tblMO")>
    Public Class MO
        Inherits AuditableBase

        <Association("MO-ProjectDetail")>
        Public Property ProjectDetail As ProjectDetails
        <Association("MO-MachineLines", GetType(MoMachineLine)), Aggregated>
        Public ReadOnly Property MoMachineLine As XPCollection(Of MoMachineLine)
            Get
                Return GetCollection(Of MoMachineLine)("MoMachineLine")
            End Get
        End Property
        Public Property Status As MOStatus
        Public Property ScheduledStartDateTime As Date?

#Region ""
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
            Public ReadOnly Property Status() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Status"))
                End Get
            End Property
            Public ReadOnly Property ScheduledStartDateTime() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ScheduledStartDateTime"))
                End Get
            End Property
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
#End Region
    End Class

    Public Enum MOStatus
        Scheduled
        Active
        Finished
    End Enum

End Namespace
