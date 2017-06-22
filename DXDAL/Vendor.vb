Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo.Helpers

Namespace SPGData

    Public Class Vendor
        Inherits XPObject

#Region "Constructors"

        Public Sub New(ByVal session As Session)

            MyBase.New(session)

        End Sub
#End Region

#Region "Persistent Properties"

        Private m_VendorName As String
        <Size(150)> _
        Public Property VendorName() As String
            Get
                Return m_VendorName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("VendorName", m_VendorName, value)
            End Set
        End Property

#End Region

#Region "Nonpersistent Properties"

        <Association("Receiving-Vendor", GetType(Receiving)), Aggregated()> _
        Public ReadOnly Property Receivings() As XPCollection(Of Receiving)
            Get
                Return GetCollection(Of Receiving)("Receivings")
            End Get
        End Property

#End Region









#Region "XPO nested fields class - don't edit manually"
        Public Shadows Class FieldsClass
            Inherits DevExpress.Xpo.XPObject.FieldsClass
            Public Sub New()
                MyBase.New()
            End Sub
            Public Sub New(ByVal propertyName As String)
                MyBase.New(propertyName)
            End Sub
            Public ReadOnly Property VendorName() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("VendorName"))
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

