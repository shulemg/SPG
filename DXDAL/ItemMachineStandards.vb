Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo

Namespace SPGData
    Public Class ItemMachineStandards
        Inherits AuditableBase

        Dim fItem As Items
        <Association("Item-Machines")>
        Public Property ProductionItem() As Items
            Get
                Return fItem
            End Get
            Set(value As Items)
                SetPropertyValue("ProductionItem", fItem, value)
            End Set
        End Property

        Dim fMachineLine As MachineLine
        <Association("Machine-Items")>
        Public Property Machine() As MachineLine
            Get
                Return fMachineLine
            End Get
            Set(value As MachineLine)
                SetPropertyValue("Machine", fMachineLine, value)
            End Set
        End Property

        Dim fProductionPerMinute As Double
        Public Property ProductionPerMinute() As Double
            Get
                Return fProductionPerMinute
            End Get
            Set(value As Double)
                SetPropertyValue("ProductionPerMinute", fProductionPerMinute, value)
            End Set
        End Property

        Dim fMinutesPerShift As Double
        Public Property MinutesPerShift() As Double
            Get
                Return fMinutesPerShift
            End Get
            Set(value As Double)
                SetPropertyValue("MinutesPerShift", fMinutesPerShift, value)
            End Set
        End Property

        Dim fProjectedPackeres As Double
        Public Property ProjectedPackers() As Double
            Get
                If IsDBNull(ProjectedPackers) Then
                    Return 0R
                End If

                Return fProjectedPackeres
            End Get
            Set(value As Double)
                SetPropertyValue("ProjectedPackers", fProjectedPackeres, value)
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

            Public ReadOnly Property ProductionItem() As Items.FieldsClass
                Get
                    Return New Items.FieldsClass(GetNestedName("ProductionItem"))
                End Get
            End Property

            Public ReadOnly Property Machine() As MachineLine.FieldsClass
                Get
                    Return New MachineLine.FieldsClass(GetNestedName("Machine"))
                End Get
            End Property

            Public ReadOnly Property ProductionPerMinute() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ProductionPerMinute"))
                End Get
            End Property
            Public ReadOnly Property MinutesPerShift() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("MinutesPerShift"))
                End Get
            End Property
            
            Public ReadOnly Property ProjectedPackers() As OperandProperty
                Get
                    Return New OperandProperty(GetNestedName("ProjectedPackers"))
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
