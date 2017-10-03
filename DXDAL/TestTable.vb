Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports DevExpress.Data.Filtering

Namespace SPGData
    <Persistent("tblTest")>
    Public Class Tests
        Inherits XPLiteObject
        Dim fID As Integer
        <Key(True)>
        Public Property ID() As Integer
            Get
                Return fID
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("ID", fID, value)
            End Set
        End Property
        Dim fName As String
        <Size(SizeAttribute.Unlimited)>
        Public Property Name() As String
            Get
                Return fName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Name", fName, value)
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
        Private Shared _fields As FieldsClass
        Public Shared Shadows ReadOnly Property Fields() As FieldsClass
            Get
                If ReferenceEquals(_fields, Nothing) Then
                    _fields = New FieldsClass()
                End If
                Return _fields
            End Get
        End Property
        'Created/Updated: Joel-PC\Joel on JOEL-PC at 7/06/10 4:40 PM
        Public Shadows Class FieldsClass
            Inherits DevExpress.Xpo.XPLiteObject.FieldsClass
            Public Sub New()
                MyBase.New()
            End Sub
            Public Sub New(ByVal propertyName As String)
                MyBase.New(propertyName)
            End Sub
            Public ReadOnly Property ID() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("ID"))
                End Get
            End Property
            Public ReadOnly Property Name() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("Name"))
                End Get
            End Property
        End Class
    End Class
End Namespace
