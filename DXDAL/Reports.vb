Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports DevExpress.Data.Filtering

Namespace SPGData
    <Persistent("tblReports")> _
    Public Class Reports
        Inherits XPLiteObject
        Dim fReportID As Integer
        <Key(True)> _
        Public Property ReportID() As Integer
            Get
                Return fReportID
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("ReportID", fReportID, value)
            End Set
        End Property
        Dim fName As String
        <Size(50)> _
        Public Property Name() As String
            Get
                Return fName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Name", fName, value)
            End Set
        End Property
        Dim fCodeName As String
        <Size(50)> _
        Public Property CodeName() As String
            Get
                Return fCodeName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("CodeName", fCodeName, value)
            End Set
        End Property
        Dim f_Module As String
        <Size(50)> _
        <Persistent("Module")> _
        Public Property _Module() As String
            Get
                Return f_Module
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("_Module", f_Module, value)
            End Set
        End Property
        Dim fType As String
        <Size(50)> _
        Public Property Type() As String
            Get
                Return fType
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Type", fType, value)
            End Set
        End Property
        Dim fFilterReport As Boolean
        Public Property FilterReport() As Boolean
            Get
                Return fFilterReport
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("FilterReport", fFilterReport, value)
            End Set
        End Property
        Dim fDateFilter As Boolean
        Public Property DateFilter() As Boolean
            Get
                Return fDateFilter
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("DateFilter", fDateFilter, value)
            End Set
        End Property
        Dim fMachineFilter As Boolean
        Public Property MachineFilter() As Boolean
            Get
                Return fMachineFilter
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("MachineFilter", fMachineFilter, value)
            End Set
        End Property
        Dim fShiftFilter As Boolean
        Public Property ShiftFilter() As Boolean
            Get
                Return fShiftFilter
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("ShiftFilter", fShiftFilter, value)
            End Set
        End Property
        Dim fCustomerFilter As Boolean
        Public Property CustomerFilter() As Boolean
            Get
                Return fCustomerFilter
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("CustomerFilter", fCustomerFilter, value)
            End Set
        End Property
        Dim fLotFilter As Boolean
        Public Property LotFilter() As Boolean
            Get
                Return fLotFilter
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("LotFilter", fLotFilter, value)
            End Set
        End Property
        Dim fPOFilter As Boolean
        Public Property POFilter() As Boolean
            Get
                Return fPOFilter
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("POFilter", fPOFilter, value)
            End Set
        End Property
        Dim fItemFilter As Boolean
        Public Property ItemFilter() As Boolean
            Get
                Return fItemFilter
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("ItemFilter", fItemFilter, value)
            End Set
        End Property
        Dim fBOLFilter As Boolean
        Public Property BOLFilter() As Boolean
            Get
                Return fBOLFilter
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("BOLFilter", fBOLFilter, value)
            End Set
        End Property
        Dim fDNFilter As Boolean
        Public Property DNFilter() As Boolean
            Get
                Return fDNFilter
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("DNFilter", fDNFilter, value)
            End Set
        End Property
        Dim fDestinationFilter As Boolean
        Public Property DestinationFilter() As Boolean
            Get
                Return fDestinationFilter
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("DestinationFilter", fDestinationFilter, value)
            End Set
        End Property
        Dim fCarrierFilter As Boolean
        Public Property CarrierFilter() As Boolean
            Get
                Return fCarrierFilter
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("CarrierFilter", fCarrierFilter, value)
            End Set
        End Property
        Dim fVendorFilter As Boolean
        Public Property VendorFilter() As Boolean
            Get
                Return fVendorFilter
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("VendorFilter", fVendorFilter, value)
            End Set
        End Property
        Dim fitemtypeFilter As Boolean
        Public Property itemtypeFilter() As Boolean
            Get
                Return fitemtypeFilter
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("itemtypeFilter", fitemtypeFilter, value)
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
            Public ReadOnly Property ReportID() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ReportID"))
                End Get
            End Property
            Public ReadOnly Property Name() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Name"))
                End Get
            End Property
            Public ReadOnly Property CodeName() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("CodeName"))
                End Get
            End Property
            Public ReadOnly Property _Module() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("_Module"))
                End Get
            End Property
            Public ReadOnly Property Type() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("Type"))
                End Get
            End Property
            Public ReadOnly Property FilterReport() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("FilterReport"))
                End Get
            End Property
            Public ReadOnly Property DateFilter() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("DateFilter"))
                End Get
            End Property
            Public ReadOnly Property MachineFilter() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("MachineFilter"))
                End Get
            End Property
            Public ReadOnly Property ShiftFilter() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ShiftFilter"))
                End Get
            End Property
            Public ReadOnly Property CustomerFilter() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("CustomerFilter"))
                End Get
            End Property
            Public ReadOnly Property LotFilter() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("LotFilter"))
                End Get
            End Property
            Public ReadOnly Property POFilter() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("POFilter"))
                End Get
            End Property
            Public ReadOnly Property ItemFilter() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ItemFilter"))
                End Get
            End Property
            Public ReadOnly Property BOLFilter() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("BOLFilter"))
                End Get
            End Property
            Public ReadOnly Property DNFilter() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("DNFilter"))
                End Get
            End Property
            Public ReadOnly Property DestinationFilter() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("DestinationFilter"))
                End Get
            End Property
            Public ReadOnly Property CarrierFilter() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("CarrierFilter"))
                End Get
            End Property
            Public ReadOnly Property VendorFilter() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("VendorFilter"))
                End Get
            End Property
            Public ReadOnly Property itemtypeFilter() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("itemtypeFilter"))
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
