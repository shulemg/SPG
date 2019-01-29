Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports DevExpress.Data.Filtering

Namespace SPGData
    <Persistent("tblUsers")> _
    Public Class Users
        Inherits XPLiteObject

#Region "Non Persistent Properties"

        <Association("UsersCustomer-User", GetType(UsersCustomer)), Aggregated()> _
        Public ReadOnly Property AssignedCustomer() As XPCollection(Of UsersCustomer)
            Get
                Return GetCollection(Of UsersCustomer)("AssignedCustomer")
            End Get
        End Property

#End Region
#Region "Persistent Properties"
        Dim fstrUserName As String
        <Key()> _
        <Size(50)> _
        Public Property strUserName() As String
            Get
                Return fstrUserName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("strUserName", fstrUserName, value)
            End Set
        End Property
        Dim fstrPassword As String
        <Size(50)> _
        Public Property strPassword() As String
            Get
                Return fstrPassword
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("strPassword", fstrPassword, value)
            End Set
        End Property
        Dim fstrSecurityLevel As String
        <Size(50)>
        Public Property strSecurityLevel() As String
            Get
                Return fstrSecurityLevel
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("strSecurityLevel", fstrSecurityLevel, value)
            End Set
        End Property
        Dim fLPNPrinterName As String
        Public Property LPNPrinterName() As String
            Get
                Return fLPNPrinterName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("LPNPrinterName", fLPNPrinterName, value)
            End Set
        End Property

        Dim fDefaultLocation As Locations
        Public Property DefaultLocation() As Locations
            Get
                Return fDefaultLocation
            End Get
            Set(value As Locations)
                SetPropertyValue(Of Locations)("DefaultLocation", fDefaultLocation, value)
            End Set
        End Property
#End Region
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
            Public ReadOnly Property strUserName() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("strUserName"))
                End Get
            End Property
            Public ReadOnly Property strPassword() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("strPassword"))
                End Get
            End Property
            Public ReadOnly Property strSecurityLevel() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("strSecurityLevel"))
                End Get
            End Property
            Public ReadOnly Property LPNPrinterName() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("LPNPrinterName"))
                End Get
            End Property
            Public ReadOnly Property DefaultLocation() As Locations.FieldsClass
                Get
                    Return New Locations.FieldsClass(GetNestedName("DefaultLocation"))
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
