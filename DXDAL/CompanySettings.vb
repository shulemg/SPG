Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports DevExpress.Data.Filtering

Namespace SPGData
    <Persistent("tblCompanySettings")>
    Public Class CompanySettings
        Inherits XPLiteObject
        Private _lPNPrintCopies As Byte = 2
        Private _lPNVerticalAdjustment As Byte = 0
        Private _lPNRightAdjustment As Byte = 0
        Private _lPNPrinterName As String
        Private _defaultLocation As Locations

        Dim fPK_ID As Integer
        <Key(True)> _
        Public Property PK_ID() As Integer
            Get
                Return fPK_ID
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("PK_ID", fPK_ID, value)
            End Set
        End Property
        Dim fdblPackersPay As Single
        Public Property dblPackersPay() As Single
            Get
                Return fdblPackersPay
            End Get
            Set(ByVal value As Single)
                SetPropertyValue(Of Single)("dblPackersPay", fdblPackersPay, value)
            End Set
        End Property
        Dim fdblOperatorsPay As Single
        Public Property dblOperatorsPay() As Single
            Get
                Return fdblOperatorsPay
            End Get
            Set(ByVal value As Single)
                SetPropertyValue(Of Single)("dblOperatorsPay", fdblOperatorsPay, value)
            End Set
        End Property
        Dim fdblSupersPay As Single
        Public Property dblSupersPay() As Single
            Get
                Return fdblSupersPay
            End Get
            Set(ByVal value As Single)
                SetPropertyValue(Of Single)("dblSupersPay", fdblSupersPay, value)
            End Set
        End Property
        Dim fintMinPerHour As Short
        Public Property intMinPerHour() As Short
            Get
                Return fintMinPerHour
            End Get
            Set(ByVal value As Short)
                SetPropertyValue(Of Short)("intMinPerHour", fintMinPerHour, value)
            End Set
        End Property
        Dim fUniversalCustomer As Integer
        Public Property UniversalCustomer() As Integer
            Get
                Return fUniversalCustomer
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("UniversalCustomer", fUniversalCustomer, value)
            End Set
        End Property
        Dim fdbVersion As String
        <Size(50)> _
        Public Property dbVersion() As String
            Get
                Return fdbVersion
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("dbVersion", fdbVersion, value)
            End Set
        End Property

        Public Property LPNPrinterName As String
            Get
                Return _lPNPrinterName
            End Get
            Set(ByVal Value As String)
                SetPropertyValue(Of String)("LPNPrinterName", _lPNPrinterName, Value)
            End Set
        End Property

        Public Property LPNHorizontalAdjustment As Byte
            Get
                Return _lPNRightAdjustment
            End Get
            Set(ByVal Value As Byte)
                SetPropertyValue(Of Byte)("LPNHorizontalAdjustment", _lPNRightAdjustment, Value)
            End Set
        End Property

        Public Property LPNVerticalAdjustment As Byte
            Get
                Return _lPNVerticalAdjustment
            End Get
            Set(ByVal Value As Byte)
                SetPropertyValue(Of Byte)("LPNVerticalAdjustment", _lPNVerticalAdjustment, Value)
            End Set
        End Property

        Public Property LPNPrintCopies As Byte
            Get
                Return _lPNPrintCopies
            End Get
            Set(ByVal Value As Byte)
                SetPropertyValue(Of Byte)("LPNPrintCopies", _lPNPrintCopies, Value)
            End Set
        End Property

        Public Property DefaultLocation As Locations
            Get
                Return _defaultLocation
            End Get
            Set(value As Locations)
                SetPropertyValue(Of Locations)("DefaultLocation", _defaultLocation, value)
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
        'Created/Updated: Joel-PC\Joel on JOEL-PC at 3/3/2013 5:48 PM
        Public Shadows Class FieldsClass
            Inherits XPLiteObject.FieldsClass
            Public Sub New()
                MyBase.New()
            End Sub
            Public Sub New(ByVal propertyName As String)
                MyBase.New(propertyName)
            End Sub
            Public ReadOnly Property PK_ID() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("PK_ID"))
                End Get
            End Property
            Public ReadOnly Property dblPackersPay() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("dblPackersPay"))
                End Get
            End Property
            Public ReadOnly Property dblOperatorsPay() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("dblOperatorsPay"))
                End Get
            End Property
            Public ReadOnly Property dblSupersPay() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("dblSupersPay"))
                End Get
            End Property
            Public ReadOnly Property intMinPerHour() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("intMinPerHour"))
                End Get
            End Property
            Public ReadOnly Property UniversalCustomer() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("UniversalCustomer"))
                End Get
            End Property
            Public Const dbVersionFieldName As String = "dbVersion"
            Public ReadOnly Property dbVersion() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("dbVersion"))
                End Get
            End Property
            Public Const LPNPrinterNameFieldName As String = "LPNPrinterName"
            Public ReadOnly Property LPNPrinterName() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("LPNPrinterName"))
                End Get
            End Property
            Public ReadOnly Property LPNHorizontalAdjustment() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("LPNHorizontalAdjustment"))
                End Get
            End Property
            Public ReadOnly Property LPNVerticalAdjustment() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("LPNVerticalAdjustment"))
                End Get
            End Property
            Public ReadOnly Property LPNPrintCopies() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("LPNPrintCopies"))
                End Get
            End Property
            Public ReadOnly Property DefaultLocation() As Locations.FieldsClass
                Get
                    Return New Locations.FieldsClass(GetNestedName("DefaultLocation"))
                End Get
            End Property
        End Class
        Public Shared Shadows ReadOnly Property Fields() As FieldsClass
            Get
                If ReferenceEquals(_Fields, Nothing) Then
                    _Fields = New FieldsClass()
                End If
                Return _Fields
            End Get
        End Property
        Private Shared _Fields As FieldsClass
    End Class
End Namespace
