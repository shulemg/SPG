Imports System
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo

Namespace SPGData
    Public Class CustomerPlants
        Inherits AuditableBase

        Dim fCustomer As Customers
        <Association("Customer-Plants")>
        Public Property Customer() As Customers
            Get
                Return fCustomer
            End Get
            Set(value As Customers)
                SetPropertyValue("Customer", fCustomer, value)
            End Set
        End Property

        Dim fPlantName As String
        <Size(150)>
        Public Property PlantName() As String
            Get
                Return fPlantName
            End Get
            Set(value As String)
                SetPropertyValue("PlantName", fPlantName, value)
            End Set
        End Property

        Dim fPlantCode As String
        <Size(10)>
        Public Property PlantCode As String
            Get
                Return fPlantCode
            End Get
            Set(value As String)
                SetPropertyValue("PlantCode", fPlantCode, value)
            End Set
        End Property

        Dim fSPGLocation As Locations
        Public Property SPGLocation As Locations
            Get
                Return fSPGLocation
            End Get
            Set(value As Locations)
                SetPropertyValue("SPGLocation", fSPGLocation, value)
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
            Public ReadOnly Property PlantName As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("PlantName"))
                End Get
            End Property
            Public ReadOnly Property PlantCode As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("PlantCode"))
                End Get
            End Property
            Public ReadOnly Property SPGLocation As Locations.FieldsClass
                Get
                    Return New Locations.FieldsClass(GetNestedName("SPGLocation"))
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
