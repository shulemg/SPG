Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports DevExpress.Data.Filtering

Namespace SPGData
    <Persistent("tblUserPermissions")> _
    Public Class UserPermissions
        Inherits XPLiteObject
        Dim fUserPermissionID As Integer
        <Key(True)> _
        Public Property UserPermissionID() As Integer
            Get
                Return fUserPermissionID
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("UserPermissionID", fUserPermissionID, value)
            End Set
        End Property
        Dim fUserName As String
        <Size(50)> _
        Public Property UserName() As String
            Get
                Return fUserName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("UserName", fUserName, value)
            End Set
        End Property
        Dim fPermissionObject As String
        <Size(50)> _
        Public Property PermissionObject() As String
            Get
                Return fPermissionObject
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("PermissionObject", fPermissionObject, value)
            End Set
        End Property
        Dim fPermissionLevel As String
        <Size(50)> _
        Public Property PermissionLevel() As String
            Get
                Return fPermissionLevel
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("PermissionLevel", fPermissionLevel, value)
            End Set
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
            Public ReadOnly Property UserPermissionID() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("UserPermissionID"))
                End Get
            End Property
            Public ReadOnly Property UserName() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("UserName"))
                End Get
            End Property
            Public ReadOnly Property PermissionObject() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("PermissionObject"))
                End Get
            End Property
            Public ReadOnly Property PermissionLevel() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("PermissionLevel"))
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
