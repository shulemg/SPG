Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports DevExpress.Data.Filtering

Namespace SPGData
    <Persistent("tblSecurity")> _
    Public Class Security
        Inherits XPLiteObject
        Dim fAdvancedTabs As Boolean
        Public Property AdvancedTabs() As Boolean
            Get
                Return fAdvancedTabs
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("AdvancedTabs", fAdvancedTabs, value)
            End Set
        End Property
        Dim fProductionReport As Boolean
        Public Property ProductionReport() As Boolean
            Get
                Return fProductionReport
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("ProductionReport", fProductionReport, value)
            End Set
        End Property
        Dim fstrUser As String
        <Key()> _
        <Size(50)> _
        Public Property strUser() As String
            Get
                Return fstrUser
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("strUser", fstrUser, value)
            End Set
        End Property
        Dim fCostingReport As Boolean
        Public Property CostingReport() As Boolean
            Get
                Return fCostingReport
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("CostingReport", fCostingReport, value)
            End Set
        End Property
        Dim fItemsForm As Boolean
        Public Property ItemsForm() As Boolean
            Get
                Return fItemsForm
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("ItemsForm", fItemsForm, value)
            End Set
        End Property
        Dim fProductionForm As Boolean
        Public Property ProductionForm() As Boolean
            Get
                Return fProductionForm
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("ProductionForm", fProductionForm, value)
            End Set
        End Property
        Dim fCustomersForm As Boolean
        Public Property CustomersForm() As Boolean
            Get
                Return fCustomersForm
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("CustomersForm", fCustomersForm, value)
            End Set
        End Property
        Dim fShippingForm As Boolean
        Public Property ShippingForm() As Boolean
            Get
                Return fShippingForm
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("ShippingForm", fShippingForm, value)
            End Set
        End Property
        Dim fReceivingForm As Boolean
        Public Property ReceivingForm() As Boolean
            Get
                Return fReceivingForm
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("ReceivingForm", fReceivingForm, value)
            End Set
        End Property
        Dim fFinancialTabs As Boolean
        Public Property FinancialTabs() As Boolean
            Get
                Return fFinancialTabs
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("FinancialTabs", fFinancialTabs, value)
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
            Public ReadOnly Property AdvancedTabs() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("AdvancedTabs"))
                End Get
            End Property
            Public ReadOnly Property ProductionReport() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ProductionReport"))
                End Get
            End Property
            Public ReadOnly Property strUser() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("strUser"))
                End Get
            End Property
            Public ReadOnly Property CostingReport() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("CostingReport"))
                End Get
            End Property
            Public ReadOnly Property ItemsForm() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ItemsForm"))
                End Get
            End Property
            Public ReadOnly Property ProductionForm() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ProductionForm"))
                End Get
            End Property
            Public ReadOnly Property CustomersForm() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("CustomersForm"))
                End Get
            End Property
            Public ReadOnly Property ShippingForm() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ShippingForm"))
                End Get
            End Property
            Public ReadOnly Property ReceivingForm() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ReceivingForm"))
                End Get
            End Property
            Public ReadOnly Property FinancialTabs() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("FinancialTabs"))
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
