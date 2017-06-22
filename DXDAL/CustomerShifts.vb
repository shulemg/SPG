Imports System
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo

Namespace SPGData
    Public Class CustomerShifts
        Inherits AuditableBase

        Dim fCustomer As Customers
        <Association("Customer-Shifts")>
        Public Property Customer() As Customers
            Get
                Return fCustomer
            End Get
            Set(value As Customers)
                SetPropertyValue("Customer", fCustomer, value)
            End Set
        End Property

        Dim fShiftName As String
        <Size(150)>
        Public Property ShiftName() As String
            Get
                Return fShiftName
            End Get
            Set(value As String)
                SetPropertyValue("ShiftName", fShiftName, value)
            End Set
        End Property

        Dim fShiftCode As String
        <Size(10)>
        Public Property ShiftCode As String
            Get
                Return fShiftCode
            End Get
            Set(value As String)
                SetPropertyValue("ShiftCode", fShiftCode, value)
            End Set
        End Property

        Dim fSPGShift As Shifts
        Public Property SPGShift As Shifts
            Get
                Return fSPGShift
            End Get
            Set(value As Shifts)
                SetPropertyValue("SPGShift", fSPGShift, value)
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
            Public ReadOnly Property Customer() As Customers.FieldsClass
                Get
                    Return New Customers.FieldsClass(GetNestedName("Customer"))
                End Get
            End Property
            Public ReadOnly Property ShiftName As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ShiftName"))
                End Get
            End Property
            Public ReadOnly Property ShiftCode As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ShiftCode"))
                End Get
            End Property
            Public ReadOnly Property SPGShift As Shifts.FieldsClass
                Get
                    Return New Shifts.FieldsClass(GetNestedName("SPGShift"))
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