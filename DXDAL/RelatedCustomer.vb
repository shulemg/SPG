Imports System
Imports DevExpress.Xpo
Imports DXDAL.SPGData

Namespace SPGData

    Public Class RelatedCustomer
        Inherits XPObject

#Region "Constructors"

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
            ' This constructor is used when an object is loaded from a persistent storage.
            ' Do not place any code here.			
        End Sub
#End Region

#Region "Persistent Properties"

        Private m_MainCustomer As Customers

        Sub New()
            ' TODO: Complete member initialization 
        End Sub

        <Association("Customer-RelatedCustomers")>
        Public Property MainCustomer As Customers
            Get
                Return m_MainCustomer
            End Get
            Set(ByVal Value As Customers)
                SetPropertyValue(Of Customers)("MainCustomer", m_MainCustomer, Value)
            End Set
        End Property

        Private m_RelatedCustomer As Customers
        Public Property RelatedCustomer As Customers
            Get
                Return m_RelatedCustomer
            End Get
            Set(ByVal Value As Customers)
                SetPropertyValue(Of Customers)("RelatedCustomer", m_RelatedCustomer, Value)
            End Set
        End Property

        Private m_Bidirectional As Boolean
        Public Property Bidirectional As Boolean
            Get
                Return m_Bidirectional
            End Get
            Set(ByVal Value As Boolean)
                SetPropertyValue(Of Boolean)("Bidirectional", m_Bidirectional, Value)
            End Set
        End Property

#End Region

        Private Shared _fields As FieldsClass
        Public Shared Shadows ReadOnly Property Fields() As FieldsClass
            Get
                If ReferenceEquals(_fields, Nothing) Then
                    _fields = New FieldsClass()
                End If
                Return _fields
            End Get
        End Property
        'Created/Updated: Joel-PC\Joel on JOEL-PC at 11/08/10 6:50 PM
        Public Shadows Class FieldsClass
            Inherits DevExpress.Xpo.XPObject.FieldsClass
            Public Sub New()
                MyBase.New()
            End Sub
            Public Sub New(ByVal propertyName As String)
                MyBase.New(propertyName)
            End Sub
            Public ReadOnly Property MainCustomer() As DXDAL.SPGData.Customers.FieldsClass
                Get
                    Return New DXDAL.SPGData.Customers.FieldsClass(GetNestedName("MainCustomer"))
                End Get
            End Property
            Public ReadOnly Property RelatedCustomer() As DXDAL.SPGData.Customers.FieldsClass
                Get
                    Return New DXDAL.SPGData.Customers.FieldsClass(GetNestedName("RelatedCustomer"))
                End Get
            End Property
            Public ReadOnly Property Bidirectional() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("Bidirectional"))
                End Get
            End Property
        End Class
    End Class

End Namespace
