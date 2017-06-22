Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Namespace SPGData
    <Persistent("tblBOMs")>
    Public Class BOMs
        Inherits XPLiteObject
        Dim fBOMID As Integer
        <Key(True)> _
        Public Property BOMID() As Integer
            Get
                Return fBOMID
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("BOMID", fBOMID, value)
            End Set
        End Property
        Dim fBOMRawMatID As Items
        Public Property BOMRawMatID() As Items
            Get
                Return fBOMRawMatID
            End Get
            Set(ByVal value As Items)
                SetPropertyValue(Of Items)("BOMRawMatID", fBOMRawMatID, value)
            End Set
        End Property
        Dim fBOMFiniGoodID As Items
        <Association("Item-BOM")>
        Public Property BOMFiniGoodID() As Items
            Get
                Return fBOMFiniGoodID
            End Get
            Set(ByVal value As Items)
                SetPropertyValue(Of Items)("BOMFiniGoodID", fBOMFiniGoodID, value)
            End Set
        End Property
        Dim fBOMQuantity As Single
        Public Property BOMQuantity() As Single
            Get
                Return fBOMQuantity
            End Get
            Set(ByVal value As Single)
                SetPropertyValue(Of Single)("BOMQuantity", fBOMQuantity, value)
            End Set
        End Property
        Dim fScrapFactor As Double
        Public Property ScrapFactor() As Double
            Get
                Return fScrapFactor
            End Get
            Set(ByVal value As Double)
                SetPropertyValue(Of Double)("ScrapFactor", fScrapFactor, value)
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
        Private Shared _Fields As FieldsClass
        Public Shared Shadows ReadOnly Property Fields() As FieldsClass
            Get
                If ReferenceEquals(_Fields, Nothing) Then
                    _Fields = New FieldsClass()
                End If
                Return _Fields
            End Get
        End Property
        'Created/Updated: Joel-PC\Joel on JOEL-PC at 28/03/2012 11:55 PM
        Public Shadows Class FieldsClass
            Inherits DevExpress.Xpo.XPLiteObject.FieldsClass
            Public Sub New()
                MyBase.New()

            End Sub
            Public Sub New(ByVal propertyName As String)
                MyBase.New(propertyName)
            End Sub

            Public ReadOnly Property BOMID() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("BOMID"))
                End Get
            End Property
            Public ReadOnly Property BOMRawMatID() As Items.FieldsClass
                Get
                    Return New Items.FieldsClass(GetNestedName("BOMRawMatID"))
                End Get
            End Property
            Public ReadOnly Property BOMFiniGoodID() As Items.FieldsClass
                Get
                    Return New Items.FieldsClass(GetNestedName("BOMFiniGoodID"))
                End Get
            End Property
            Public ReadOnly Property BOMQuantity() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("BOMQuantity"))
                End Get
            End Property
            Public ReadOnly Property ScrapFactor() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ScrapFactor"))
                End Get
            End Property
        End Class
    End Class

End Namespace
