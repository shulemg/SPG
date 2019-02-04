Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Namespace SPGData
    <Persistent("tblMoMachineLine")>
    Public Class MoMachineLine
        Inherits AuditableBase
        <Association("MO-MachineLines")>
        Public Property Mo As MO
        Public Property MachineLine As MachineLine
        Public Property StartTime As Date?
        Public Property EndTime As Date?

        Public Sub New()
            MyBase.New()
        End Sub
        Public Sub New(session As Session)
            MyBase.New(session)
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
            Public ReadOnly Property MO() As MO.FieldsClass
                Get
                    Return New MO.FieldsClass(GetNestedName("MO"))
                End Get
            End Property
            Public ReadOnly Property MachineLine() As MachineLine.FieldsClass
                Get
                    Return New MachineLine.FieldsClass(GetNestedName("MachineLine"))
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
        End Class
    End Class
End Namespace
