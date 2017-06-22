Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports DevExpress.Data.Filtering

Namespace SPGData
    <Persistent("tblAuditTrail")>
    Public Class AuditTrail
        Inherits XPLiteObject
        Dim fPK_ID As Integer
        <Key(True)> _
        Public Property PK_ID() As Integer
            Get
                Return fPK_ID
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("PK_ID", fPK_ID, value)
            End Set
        End Property
        Dim fUserID As String
        <Size(50)> _
        Public Property UserID() As String
            Get
                Return fUserID
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("UserID", fUserID, value)
            End Set
        End Property
        Dim fRecordID As Integer
        Public Property RecordID() As Integer
            Get
                Return fRecordID
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("RecordID", fRecordID, value)
            End Set
        End Property
        Dim fRecordType As String
        <Size(50)> _
        Public Property RecordType() As String
            Get
                Return fRecordType
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("RecordType", fRecordType, value)
            End Set
        End Property
        Dim fRecordChanges As String
        <Size(SizeAttribute.Unlimited)> _
        Public Property RecordChanges() As String
            Get
                Return fRecordChanges
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("RecordChanges", fRecordChanges, value)
            End Set
        End Property
        Dim fChangeDate As DateTime
        Public Property ChangeDate() As DateTime
            Get
                Return fChangeDate
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("ChangeDate", fChangeDate, value)
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
        'Created/Updated: Joel-PC\Joel on JOEL-PC at 3/7/2013 9:11 PM
        Public Shadows Class FieldsClass
            Inherits DevExpress.Xpo.PersistentBase.FieldsClass
            Public Sub New()
                MyBase.New()
            End Sub
            Public Sub New(ByVal propertyName As String)
                MyBase.New(propertyName)
            End Sub
            Public ReadOnly Property PK_ID() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("PK_ID"))
                End Get
            End Property
            Public Const UserIDFieldName As String = "UserID"
            Public ReadOnly Property UserID() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("UserID"))
                End Get
            End Property
            Public ReadOnly Property RecordID() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("RecordID"))
                End Get
            End Property
            Public Const RecordTypeFieldName As String = "RecordType"
            Public ReadOnly Property RecordType() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("RecordType"))
                End Get
            End Property
            Public Const RecordChangesFieldName As String = "RecordChanges"
            Public ReadOnly Property RecordChanges() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("RecordChanges"))
                End Get
            End Property
            Public ReadOnly Property ChangeDate() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ChangeDate"))
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
    End Class
End Namespace
