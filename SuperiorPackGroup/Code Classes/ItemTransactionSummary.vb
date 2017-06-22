Public Class ItemTransactionSummary

    ''' <summary>
    ''' Initializes a new instance of the ItemTransactionSummary class.
    ''' </summary>
    Public Sub New(ByVal customerName As String, ByVal itemCode As String, ByVal itemDescription As String, ByVal itemType As String, ByVal produced As Double, ByVal usedInProduction As Double, ByVal shipped As Double, ByVal received As Double,
                   ByVal adjusted As Double)

        Me.CustomerName = customerName
        Me.ItemCode = itemCode
        Me.ItemDescription = itemDescription
        Me.ItemType = itemType
        Me.Produced = produced
        Me.UsedInProduction = usedInProduction
        Me.Shipped = shipped
        Me.Received = received
        Me.Adjusted = adjusted

    End Sub

    Public Sub New()

    End Sub

    Public Property CustomerName() As String
    Public Property ItemCode() As String
    Public Property ItemDescription() As String
    Public Property ItemType() As String
    Public Property Produced() As Double
    Public Property UsedInProduction() As Double
    Public Property Shipped() As Double
    Public Property Received() As Double
    Public Property Adjusted() As Double

End Class
