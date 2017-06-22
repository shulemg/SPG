Imports DevExpress.XtraScheduler

Public Class ShiftsTimeScaleFixedInterval
    Inherits TimeScaleFixedInterval

    Private ReadOnly startDay As TimeSpan = TimeSpan.FromHours(1.0)

    Public Sub New()
        MyBase.New(TimeSpan.FromHours(8.0))

        Width = 250

    End Sub

    Public Sub New(ByVal scaleValue As TimeSpan)
        MyBase.New(scaleValue)

        Width = 250

    End Sub

    Protected Overrides ReadOnly Property DefaultDisplayName As String
        Get
            Return "WorkShift"
        End Get
    End Property

    Protected Overrides ReadOnly Property DefaultMenuCaption As String
        Get
            Return "Work Shift"
        End Get
    End Property

    Public Overrides Function Floor([date] As Date) As Date

        Dim result As DateTime

        If [date] = DateTime.MinValue Then
            result = DateTime.MinValue + startDay
        ElseIf [date].TimeOfDay < startDay Then
            result = [date].Date + startDay ' - Value
        Else
            result = MyBase.Floor([date])
        End If

        If result.TimeOfDay < startDay Then
            result = result.Date + startDay
        ElseIf result.TimeOfDay = TimeSpan.FromHours(8.0) OrElse result.TimeOfDay = TimeSpan.FromHours(16.0) Then
            result += startDay
        End If

        Return result

    End Function

    'Public Overrides Function FormatCaption(start As Date, [end] As Date) As String

    '    Dim tomorrow As Date = start.Date.AddDays(1)
    '    Dim productionDay As String = String.Empty

    '    If start <> DateTime.MinValue Then
    '        If [end] <= New Date(start.Year, start.Month, start.Day, 9, 0, 0) Then
    '            productionDay = String.Format("{0}. ", start.AddDays(-1).ToString("ddd"))
    '        Else
    '            productionDay = String.Format("{0}. ", start.ToString("ddd"))
    '        End If
    '    End If

    '    If start >= New Date(start.Year, start.Month, start.Day, 1, 0, 0) And [end] <= New Date(start.Year, start.Month, start.Day, 9, 0, 0) Then
    '        Return String.Format("{0}Shift 3", productionDay)
    '    ElseIf start >= New Date(start.Year, start.Month, start.Day, 9, 0, 0) And [end] <= New Date(start.Year, start.Month, start.Day, 17, 0, 0) Then
    '        Return String.Format("{0}Shift 1", productionDay)
    '    ElseIf start >= New Date(start.Year, start.Month, start.Day, 17, 0, 0) And [end] <= New Date(tomorrow.Year, tomorrow.Month, tomorrow.Day, 1, 0, 0) Then
    '        Return String.Format("{0}Shift 2", productionDay)
    '    End If
    '    Return MyBase.FormatCaption(start, [end])

    'End Function

    Public Overrides Function GetNextDate([date] As Date) As Date

        Dim result As DateTime = MyBase.GetNextDate([date])

        If result.TimeOfDay < startDay OrElse result.TimeOfDay = TimeSpan.FromHours(8.0) OrElse result.TimeOfDay = TimeSpan.FromHours(16.0) Then
            result += startDay
        End If

        Return result

    End Function

End Class
