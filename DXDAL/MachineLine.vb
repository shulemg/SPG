Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports DevExpress.Data.Filtering

Namespace SPGData
    <Persistent("tblMachineLine")> _
    Public Class MachineLine
        Inherits XPLiteObject
        Dim fMachineLineID As Integer
        <Key(True)> _
        Public Property MachineLineID() As Integer
            Get
                Return fMachineLineID
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("MachineLineID", fMachineLineID, value)
            End Set
        End Property
        Dim fMachineLineName As String
        <Size(50)> _
        Public Property MachineLineName() As String
            Get
                Return fMachineLineName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("MachineLineName", fMachineLineName, value)
            End Set
        End Property

        <Association("Machine-Items", GetType(ItemMachineStandards)), Aggregated()>
        Public ReadOnly Property MachineItems As XPCollection(Of ItemMachineStandards)
            Get
                Return GetCollection(Of ItemMachineStandards)("MachineItems")
            End Get
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
        Public Shadows Class FieldsClass
            Inherits DevExpress.Xpo.PersistentBase.FieldsClass
            Public Sub New()
                MyBase.New()
            End Sub
            Public Sub New(ByVal propertyName As String)
                MyBase.New(propertyName)
            End Sub
            Public ReadOnly Property fMachineLineID() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("fMachineLineID"))
                End Get
            End Property
            Public ReadOnly Property MachineLineID() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("MachineLineID"))
                End Get
            End Property
            Public ReadOnly Property fMachineLineName() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("fMachineLineName"))
                End Get
            End Property
            Public ReadOnly Property MachineLineName() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("MachineLineName"))
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
