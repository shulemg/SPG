Imports System
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo

Namespace SPGData
    Public Class LotCodeFormats
        Inherits AuditableBase

        Dim fFormatName As String
        <Size(50)>
        Public Property FormatName() As String
            Get
                Return fFormatName
            End Get
            Set(value As String)
                SetPropertyValue(Of String)("FormatName", fFormatName, value)
            End Set
        End Property

        Dim fSections As Integer
        Public Property Sections() As Integer
            Get
                Return fSections
            End Get
            Set(value As Integer)
                SetPropertyValue(Of Integer)("Sections", fSections, value)
            End Set
        End Property

        <Association("Format-Sections", GetType(LotCodeFormatSections)), Aggregated()>
        Public ReadOnly Property FormatSections As XPCollection(Of LotCodeFormatSections)
            Get
                Return GetCollection(Of LotCodeFormatSections)("FormatSections")
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
            Public ReadOnly Property FormatName() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("FormatName"))
                End Get
            End Property
            Public ReadOnly Property Sections() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Sections"))
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