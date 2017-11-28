Imports DXDAL.SPGData

Public Class BomDemandSummary

    Public Property ItemID As Items
    Public Property ItemType As String
    Public Property PoolItemID As ItemPool
    Public Property LocalQuantityOnHand As Double
    Public Property NonLocalQuantityOnHand As Double
    'Public Property NonLocalPalletsQuantityOnHand As Double
    Public Property QuantityOnScheduledProjects As Double
    Public Property QuantityOnUnscheduledProjects As Double
    Public Property CustomerName As String
    Public ReadOnly Property QuantityOnHand As Double
        Get
            Return LocalQuantityOnHand + NonLocalQuantityOnHand
        End Get
    End Property
    Public ReadOnly Property BomDemandShortage As Double
        Get
            Return Math.Max(QuantityOnScheduledProjects - QuantityOnHand, 0)
        End Get
    End Property

    Public ReadOnly Property TotalBomDemand As Double
        Get
            Return QuantityOnScheduledProjects + QuantityOnUnscheduledProjects
        End Get
    End Property
    Public ReadOnly Property BomDemandLocalShortage As Double
        Get
            Return Math.Max(TotalBomDemand - LocalQuantityOnHand, 0)
        End Get
    End Property
    Public ReadOnly Property TotalBomDemandShortage As Double
        Get
            Return Math.Max(TotalBomDemand - QuantityOnHand, 0)
        End Get
    End Property
    Public ReadOnly Property NonLocalPalletsQuantityOnHand As Double
        Get
            Try
                If ItemID.intUnitsPerPallet = 0 Then Return 0
                Return BomDemandLocalShortage / ItemID.intUnitsPerPallet
            Catch
            End Try
        End Get
    End Property


    'used for summary report to find the bom demand in the collection
    Public ReadOnly Property DemandKey As String
        Get
            If ItemID IsNot Nothing Then
                If String.IsNullOrEmpty(ItemType) Then
                    Return String.Format("{0}{1}", ItemID.ItemType, ItemID.ItemID)
                Else
                    Return String.Format("{0}{1}", ItemType, ItemID.ItemID)
                End If
            End If
            If PoolItemID IsNot Nothing Then
                Return String.Format("PI{0}", PoolItemID.Oid)
            End If
            Return String.Empty
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
