Imports System
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo

Namespace SPGData
    Public Class LotCodeSectionSettings
        Inherits AuditableBase

        Dim fLotCodeSection As LotCodeFormatSections
        <Association("Section-Settings")>
        Public Property LotCodeSection() As LotCodeFormatSections
            Get
                Return fLotCodeSection
            End Get
            Set(value As LotCodeFormatSections)
                SetPropertyValue("LotCodeSection", fLotCodeSection, value)
            End Set
        End Property

        Dim fSettingName As String
        <Size(50)>
        Public Property SettingName() As String
            Get
                Return fSettingName
            End Get
            Set(value As String)
                SetPropertyValue("SettingName", fSettingName, value)
            End Set
        End Property

        Dim fSettingValue As String
        <Size(100)>
        Public Property SettingValue() As String
            Get
                Return fSettingValue
            End Get
            Set(value As String)
                SetPropertyValue("SettingValue", fSettingValue, value)
            End Set
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
            Public ReadOnly Property LotCodeSection() As LotCodeFormatSections.FieldsClass
                Get
                    Return New LotCodeFormatSections.FieldsClass(GetNestedName("LotCodeSection"))
                End Get
            End Property
            Public ReadOnly Property SettingName() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("SettingName"))
                End Get
            End Property
            Public ReadOnly Property SettingValue() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("SettingValue"))
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