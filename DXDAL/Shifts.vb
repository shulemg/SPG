Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports DevExpress.Data.Filtering

Namespace SPGData
    <Persistent("tblShifts")> _
    Public Class Shifts
        Inherits XPLiteObject
        Dim fShiftID As Integer
        <Key(True)> _
        Public Property ShiftID() As Integer
            Get
                Return fShiftID
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("ShiftID", fShiftID, value)
            End Set
        End Property
        Dim fShiftName As String
        <Size(50)> _
        Public Property ShiftName() As String
            Get
                Return fShiftName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ShiftName", fShiftName, value)
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
            Public ReadOnly Property ShiftID() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("ShiftID"))
                End Get
            End Property
            Public ReadOnly Property ShiftName() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("ShiftName"))
                End Get
            End Property
        End Class
    End Class
End Namespace
