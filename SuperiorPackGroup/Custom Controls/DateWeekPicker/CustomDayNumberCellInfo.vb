Imports DevExpress.XtraEditors.Calendar

Public Class CustomDayNumberCellInfo
    Inherits DayNumberCellInfo

    Public Sub New(ByVal val As DateTime)
        MyBase.New(val)

        ContainMark = False
        Marked = False

    End Sub

    Public Property ContainMark() As Boolean
    Public Property Marked() As Boolean

End Class
