Imports DXDAL.SPGData

Public Class BomDemand

    Public Property ItemID As Items
    Public Property ItemType As String
    Public Property PoolItemID As ItemPool
    Public Property ProjectDetailID As ProjectDetails
    Public Property ProjectID As Project
    Public property QuantityOnHand As Double
    Public property QuantityOnScheduledProjects As Double
    Public Property QuantityOnUnscheduledProjects As Double
    Public Property QuantityRequiredForProject As Double

    Public ReadOnly Property BomDemandShortage As Double
        Get
            Return Math.Max(QuantityRequiredForProject - (QuantityOnHand - QuantityOnScheduledProjects), 0)
        End Get
    End Property

    Public ReadOnly Property CustomerPO As String
        Get
            If ProjectDetailID Is Nothing Then
                Return String.Empty
            Else
                Return ProjectDetailID.CustomerPO
            End If
        End Get
    End Property

    Public ReadOnly Property ItemCode As String
        Get
            If ItemID IsNot Nothing Then
                Return ItemID.ItemCode
            End If
            If PoolItemID IsNot Nothing Then
                Return PoolItemID.PoolCode
            End If
            Return String.Empty
        End Get
    End Property

    Public ReadOnly Property ItemDescription As String
        Get
            If ItemID IsNot Nothing Then
                Return ItemID.ItemDescription
            End If
            If PoolItemID IsNot Nothing Then
                Return PoolItemID.PoolDescription
            End If
            Return String.Empty
        End Get
    End Property

End Class
