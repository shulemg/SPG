Public Class WeeklyProduction

    Public Sub New()

    End Sub

    Public Sub New(ByVal customerName As String, ByVal itemID As Integer, ByVal itemCode As String, ByVal itemDescription As String, ByVal requiredCases As Integer, ByVal requiredBags As Integer, ByVal producedMonday As Integer,
                   ByVal producedTuesday As Integer, ByVal producedWednesday As Integer, ByVal producedThursday As Integer, ByVal producedFriday As Integer, ByVal producedSaturday As Integer, ByVal producedSunday As Integer,
                   ByVal scheduledMonday As Integer, ByVal scheduledTuesday As Integer, ByVal scheduledWednesday As Integer, ByVal scheduledThursday As Integer, ByVal scheduledFriday As Integer, ByVal scheduledSaturday As Integer,
                   ByVal scheduledSunday As Integer, ByVal productionWeek As String)

        Me.CustomerName = customerName
        Me.ItemID = itemID
        Me.ItemCode = itemCode
        Me.ItemDescription = itemDescription
        Me.RequiredCases = requiredCases
        Me.RequiredBags = requiredBags
        Me.ProducedMonday = producedMonday
        Me.ProducedTuesday = producedTuesday
        Me.ProducedWednesday = producedWednesday
        Me.ProducedThursday = producedThursday
        Me.ProducedFriday = producedFriday
        Me.ProducedSaturday = producedSaturday
        Me.ProducedSunday = producedSunday
        Me.ScheduledMonday = scheduledMonday
        Me.ScheduledTuesday = scheduledTuesday
        Me.ScheduledWednesday = scheduledWednesday
        Me.ScheduledThursday = scheduledThursday
        Me.ScheduledFriday = scheduledFriday
        Me.ScheduledSaturday = scheduledSaturday
        Me.ScheduledSunday = scheduledSunday
        Me.ProductionWeek = productionWeek

    End Sub

    Public Sub New(ByVal customerName As String, ByVal itemID As Integer, ByVal itemCode As String, ByVal itemDescription As String, ByVal requiredCases As Integer, ByVal requiredBags As Integer, ByVal producedMonday As Integer,
                   ByVal producedTuesday As Integer, ByVal producedWednesday As Integer, ByVal producedThursday As Integer, ByVal producedFriday As Integer, ByVal producedSaturday As Integer,
                   ByVal producedSunday As Integer, ByVal productionWeek As String)

        Me.CustomerName = customerName
        Me.ItemID = itemID
        Me.ItemCode = itemCode
        Me.ItemDescription = itemDescription
        Me.RequiredCases = requiredCases
        Me.RequiredBags = requiredBags
        Me.ProducedMonday = producedMonday
        Me.ProducedTuesday = producedTuesday
        Me.ProducedWednesday = producedWednesday
        Me.ProducedThursday = producedThursday
        Me.ProducedFriday = producedFriday
        Me.ProducedSaturday = producedSaturday
        Me.ProducedSunday = producedSunday
        Me.ProductionWeek = productionWeek

    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean

        If obj Is Nothing OrElse Me.GetType().Equals(obj.GetType()) = False Then
            Return False
        Else
            Dim WP As WeeklyProduction = CType(obj, WeeklyProduction)
            Return ItemID = WP.ItemID AndAlso ProductionWeek = WP.ProductionWeek
        End If

    End Function

    Public Property RequiredCases As Integer
    Public Property CustomerName As String
    Public Property ItemID As Integer
    Public Property ItemCode As String
        Public Property ItemDescription As String
        Public Property RequiredBags As Integer
        Public Property ProducedMonday As Integer
        Public Property ProducedTuesday As Integer
        Public Property ProducedWednesday As Integer
        Public Property ProducedThursday As Integer
        Public Property ProducedFriday As Integer
        Public Property ProducedSaturday As Integer
        Public Property ProducedSunday As Integer
        Public Property ScheduledMonday As Integer
        Public Property ScheduledTuesday As Integer
        Public Property ScheduledWednesday As Integer
        Public Property ScheduledThursday As Integer
        Public Property ScheduledFriday As Integer
        Public Property ScheduledSaturday As Integer
    Public Property ScheduledSunday As Integer
    Public Property ProductionWeek As String
    Public Property TotalProduced As Integer

    Public ReadOnly Property PercentageComplete As Double
        Get
            Return TotalProduced / RequiredCases
        End Get
    End Property

    Public ReadOnly Property TotalProducedWeek As Integer
        Get
            Return ProducedMonday + ProducedTuesday + ProducedWednesday + ProducedThursday + ProducedFriday + ProducedSaturday + ProducedSunday
        End Get
    End Property

End Class
