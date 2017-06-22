Imports System
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo

Namespace SPGData
    Public Class LotCodeFormatSections
        Inherits AuditableBase

        Dim fLotCodeFormat As LotCodeFormats
        <Association("Format-Sections")>
        Public Property LotCodeFormat() As LotCodeFormats
            Get
                Return fLotCodeFormat
            End Get
            Set(value As LotCodeFormats)
                SetPropertyValue("LotCodeFormat", fLotCodeFormat, value)
            End Set
        End Property

        Dim fSectionName As String
        <Size(50)>
        Public Property SectionName() As String
            Get
                Return fSectionName
            End Get
            Set(value As String)
                SetPropertyValue("SectionName", fSectionName, value)
            End Set
        End Property

        Dim fSectionType As LotCodeSectionType
        Public Property SectionType() As LotCodeSectionType
            Get
                Return fSectionType
            End Get
            Set(value As LotCodeSectionType)
                SetPropertyValue("SectionType", fSectionType, value)
            End Set
        End Property

        Dim fSectionLength As Integer
        Public Property SectionLength() As Integer
            Get
                Return fSectionLength
            End Get
            Set(value As Integer)
                SetPropertyValue(Of Integer)("SectionLength", fSectionLength, value)
            End Set
        End Property

        Dim fSectionPosition As Integer
        Public Property SectionPosition() As Integer
            Get
                Return fSectionPosition
            End Get
            Set(value As Integer)
                SetPropertyValue(Of Integer)("SectionPosition", fSectionPosition, value)
            End Set
        End Property
        
        <Association("Section-Settings", GetType(LotCodeSectionSettings)), Aggregated()>
        Public ReadOnly Property SectionSettings() As XPCollection(Of LotCodeSectionSettings)
            Get
                Return GetCollection(Of LotCodeSectionSettings)("SectionSettings")
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
            Public ReadOnly Property LotCodeFormat() As LotCodeFormats.FieldsClass
                Get
                    Return New LotCodeFormats.FieldsClass(GetNestedName("LotCodeFormat"))
                End Get
            End Property
            Public ReadOnly Property SectionName() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("SectionName"))
                End Get
            End Property
            Public ReadOnly Property SectionType() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("SectionType"))
                End Get
            End Property
            Public ReadOnly Property SectionLength() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("SectionLength"))
                End Get
            End Property
            Public ReadOnly Property SectionPosition() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("SectionPosition"))
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