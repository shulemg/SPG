Public Class WeeklyProductionList
    Inherits List(Of WeeklyProduction)
    Public Sub New()
        
    End Sub
    Public Sub New(ByVal capacity As Integer)
        MyBase.New(capacity)
        
    End Sub
    Public Sub New(ByVal collection As IEnumerable(Of WeeklyProduction))
        MyBase.New(collection)
        
    End Sub

End Class
