Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports DevExpress.Data.Filtering
Imports System.Text

Namespace SPGData
    <Persistent("tblProdMain")> _
    Public Class Production
        Inherits XPLiteObject
        Dim fProdMainID As Integer
        <Key()> _
        Public Property ProdMainID() As Integer
            Get
                Return fProdMainID
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("ProdMainID", fProdMainID, value)
            End Set
        End Property
        Dim fProdMainDate As DateTime
        Public Property ProdMainDate() As DateTime
            Get
                Return fProdMainDate
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("ProdMainDate", fProdMainDate, value)
            End Set
        End Property
        Dim fProdMainShift As Shifts
        Public Property ProdMainShift() As Shifts
            Get
                Return fProdMainShift
            End Get
            Set(ByVal value As Shifts)
                SetPropertyValue(Of Shifts)("ProdMainShift", fProdMainShift, value)
            End Set
        End Property
        Dim fProdMainItemID As Items
        Public Property ProdMainItemID() As Items
            Get
                Return fProdMainItemID
            End Get
            Set(ByVal value As Items)
                SetPropertyValue(Of Items)("ProdMainItemID", fProdMainItemID, value)
            End Set
        End Property
        Dim fProdMainLot As String
        <Size(150)> _
        Public Property ProdMainLot() As String
            Get
                Return fProdMainLot
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ProdMainLot", fProdMainLot, value)
            End Set
        End Property
        Dim fProdMainQuantity As Single
        Public Property ProdMainQuantity() As Single
            Get
                Return fProdMainQuantity
            End Get
            Set(ByVal value As Single)
                SetPropertyValue(Of Single)("ProdMainQuantity", fProdMainQuantity, value)
            End Set
        End Property
        Dim fProdMainMachineLine As MachineLine
        Public Property ProdMainMachineLine() As MachineLine
            Get
                Return fProdMainMachineLine
            End Get
            Set(ByVal value As MachineLine)
                SetPropertyValue(Of MachineLine)("ProdMainMachineLine", fProdMainMachineLine, value)
            End Set
        End Property
        Dim fProdMainTimeStart As DateTime
        Public Property ProdMainTimeStart() As DateTime
            Get
                Return fProdMainTimeStart
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("ProdMainTimeStart", fProdMainTimeStart, value)
            End Set
        End Property
        Dim fProdMainTimeStop As DateTime
        Public Property ProdMainTimeStop() As DateTime
            Get
                Return fProdMainTimeStop
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("ProdMainTimeStop", fProdMainTimeStop, value)
            End Set
        End Property
        Dim fProdMainPackers As Single
        Public Property ProdMainPackers() As Single
            Get
                Return fProdMainPackers
            End Get
            Set(ByVal value As Single)
                SetPropertyValue(Of Single)("ProdMainPackers", fProdMainPackers, value)
            End Set
        End Property
        Dim fProdMainOperators As Single
        Public Property ProdMainOperators() As Single
            Get
                Return fProdMainOperators
            End Get
            Set(ByVal value As Single)
                SetPropertyValue(Of Single)("ProdMainOperators", fProdMainOperators, value)
            End Set
        End Property
        Dim fProdMainSupers As Single
        Public Property ProdMainSupers() As Single
            Get
                Return fProdMainSupers
            End Get
            Set(ByVal value As Single)
                SetPropertyValue(Of Single)("ProdMainSupers", fProdMainSupers, value)
            End Set
        End Property
        Dim fintMachineSpeed As Integer
        Public Property intMachineSpeed() As Integer
            Get
                Return fintMachineSpeed
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("intMachineSpeed", fintMachineSpeed, value)
            End Set
        End Property
        Dim fstrEnteredBy As String
        <Size(50)> _
        Public Property strEnteredBy() As String
            Get
                Return fstrEnteredBy
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("strEnteredBy", fstrEnteredBy, value)
            End Set
        End Property
        Dim fdtmEnteredOn As DateTime
        Public Property dtmEnteredOn() As DateTime
            Get
                Return fdtmEnteredOn
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("dtmEnteredOn", fdtmEnteredOn, value)
            End Set
        End Property
        <Association("Production-Reasons")>
        Public ReadOnly Property ReasonCodes() As XPCollection(Of ReasonCodes)
            Get
                Return GetCollection(Of ReasonCodes)("ReasonCodes")
            End Get
        End Property
        Public ReadOnly Property Reasons() As String
            Get
                Dim result As New StringBuilder(String.Empty)

                For Each reason In ReasonCodes
                    If Len(reason.ReasonCode) > 0 Then
                        If result.Length < 1 Then
                            result.Append(reason.ReasonCode)
                        Else
                            result.AppendFormat("; {0}", reason.ReasonCode)
                        End If
                    End If
                Next

                Return result.ToString
            End Get
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
        'Created/Updated: Joel-PC\Joel on JOEL-PC at 1/27/2013 4:54 PM
        Public Shadows Class FieldsClass
            Inherits XPLiteObject.FieldsClass
            Public Sub New()
                MyBase.New()
            End Sub
            Public Sub New(ByVal propertyName As String)
                MyBase.New(propertyName)
            End Sub
            Public ReadOnly Property ProdMainID() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ProdMainID"))
                End Get
            End Property
            Public ReadOnly Property ProdMainDate() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ProdMainDate"))
                End Get
            End Property
            Public ReadOnly Property ProdMainShift() As DXDAL.SPGData.Shifts.FieldsClass
                Get
                    Return New DXDAL.SPGData.Shifts.FieldsClass(GetNestedName("ProdMainShift"))
                End Get
            End Property
            Public ReadOnly Property ProdMainItemID() As DXDAL.SPGData.Items.FieldsClass
                Get
                    Return New DXDAL.SPGData.Items.FieldsClass(GetNestedName("ProdMainItemID"))
                End Get
            End Property
            Public Const ProdMainLotFieldName As String = "ProdMainLot"
            Public ReadOnly Property ProdMainLot() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("ProdMainLot"))
                End Get
            End Property
            Public ReadOnly Property ProdMainQuantity() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ProdMainQuantity"))
                End Get
            End Property
            Public ReadOnly Property ProdMainMachineLine() As DXDAL.SPGData.MachineLine.FieldsClass
                Get
                    Return New DXDAL.SPGData.MachineLine.FieldsClass(GetNestedName("ProdMainMachineLine"))
                End Get
            End Property
            Public ReadOnly Property ProdMainTimeStart() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ProdMainTimeStart"))
                End Get
            End Property
            Public ReadOnly Property ProdMainTimeStop() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ProdMainTimeStop"))
                End Get
            End Property
            Public ReadOnly Property ProdMainPackers() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ProdMainPackers"))
                End Get
            End Property
            Public ReadOnly Property ProdMainOperators() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ProdMainOperators"))
                End Get
            End Property
            Public ReadOnly Property ProdMainSupers() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ProdMainSupers"))
                End Get
            End Property
            Public ReadOnly Property intMachineSpeed() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("intMachineSpeed"))
                End Get
            End Property
            Public Const strEnteredByFieldName As String = "strEnteredBy"
            Public ReadOnly Property strEnteredBy() As DevExpress.Data.Filtering.OperandProperty
                Get
                    Return New DevExpress.Data.Filtering.OperandProperty(GetNestedName("strEnteredBy"))
                End Get
            End Property
            Public ReadOnly Property dtmEnteredOn() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("dtmEnteredOn"))
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
