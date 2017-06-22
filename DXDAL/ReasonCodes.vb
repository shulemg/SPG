Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo

Namespace SPGData
    Public Class ReasonCodes
        Inherits AuditableBase

        Dim fReasonType As String
        <Size(50)>
        Public Property ReasonType() As String
            Get
                Return fReasonType
            End Get
            Set(value As String)
                SetPropertyValue("ReasonType", fReasonType, value)
            End Set
        End Property

        Dim fReasonCode As String
        <Size(50)>
        Public Property ReasonCode() As String
            Get
                Return fReasonCode
            End Get
            Set(value As String)
                SetPropertyValue("ReasonCode", fReasonCode, value)
            End Set
        End Property

        Dim fDescription As String
        <Size(150)>
        Public Property Description() As String
            Get
                Return fDescription
            End Get
            Set(value As String)
                SetPropertyValue("Description", fDescription, value)
            End Set
        End Property

        <Association("Production-Reasons")>
        Public ReadOnly Property Production() As XPCollection(Of Production)
            Get
                Return GetCollection(Of Production)("Production")
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
            Inherits XPLiteObject.FieldsClass
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
            Public ReadOnly Property ReasonType() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ReasonType"))
                End Get
            End Property
            Public ReadOnly Property ReasonCode() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ReasonCode"))
                End Get
            End Property
            Public ReadOnly Property Description() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Description"))
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
