Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports DevExpress.Data.Filtering

Namespace SPGData
    <Persistent("tblAllergen")>
    Public Class Allergen
        Inherits XPLiteObject
        Dim fAllergenID As Integer
        <Key(True)>
        Public Property AllergenID() As Integer
            Get
                Return fAllergenID
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("AllergenID", fAllergenID, value)
            End Set
        End Property
        Dim fAllergenName As String
        <Size(50)>
        Public Property AllergenName() As String
            Get
                Return fAllergenName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("AllergenName", fAllergenName, value)
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
            Public ReadOnly Property AllergenID() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("AllergenID"))
                End Get
            End Property
            Public ReadOnly Property AllergenName() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("AllergenName"))
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
