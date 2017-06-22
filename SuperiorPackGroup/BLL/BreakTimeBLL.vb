Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DXDAL.SPGData

Public Class BreakTimeBLL

    Private Shared Sub SetProperDates(ByVal break As BreakTime)

        'make sure that the date for start of break is on the same day in the week as the weekday field
        If break.StartTime.DayOfWeek <> break.WeekDay Then
            break.StartTime = DateAdd(DateInterval.Weekday, break.WeekDay - break.StartTime.DayOfWeek, break.StartTime)
        End If

        'Make sure that the break end time has the proper date
        If break.StartTime.TimeOfDay < break.EndTime.TimeOfDay Then
            break.EndTime = New Date(break.StartTime.Year, break.StartTime.Month, break.StartTime.Day, break.EndTime.Hour, break.EndTime.Minute, 0)
        End If
        If break.StartTime.TimeOfDay > break.EndTime.TimeOfDay Then
            break.EndTime = New Date(break.StartTime.Year, break.StartTime.Month, break.StartTime.Day + 1, break.EndTime.Hour, break.EndTime.Minute, 0)
        End If

    End Sub

    Private Shared Function TakeDownExtraTimeOfBreak(ByVal workStartTime As DateTime, ByVal workEndTime As DateTime, ByVal break As BreakTime) As Long

        'take down the time of the break that's not in our work time
        If workStartTime.TimeOfDay > break.StartTime.TimeOfDay AndAlso break.WeekDay = workStartTime.DayOfWeek Then
            Return DateDiff(DateInterval.Minute, Convert.ToDateTime(break.StartTime.TimeOfDay.ToString), Convert.ToDateTime(workStartTime.TimeOfDay.ToString))
        ElseIf workEndTime.TimeOfDay < break.EndTime.TimeOfDay AndAlso break.WeekDay = workEndTime.DayOfWeek Then
            Return DateDiff(DateInterval.Minute, Convert.ToDateTime(workEndTime.TimeOfDay.ToString), Convert.ToDateTime(break.EndTime.TimeOfDay.ToString))
        End If

        Return 0

    End Function

    Public Shared Function GetBreakMinutes(ByVal workDate As Date, ByVal workStartTime As DateTime, ByVal workEndTime As DateTime) As Long

        If workDate < #1/1/1754# Then
            Return 0
        End If

        'Take off the seconds from the work end time
        If workEndTime.Second <> 0 Then
            workEndTime = New Date(workEndTime.Year, workEndTime.Month, workEndTime.Day, workEndTime.Hour, workEndTime.Minute, 0)
        End If

        Dim breakMinutes As Long = 0
        'Make sure that the work time dates are the same as the production date, and that the work end time is on the correct date
        
        workStartTime = New Date(workDate.Year, workDate.Month, workDate.Day, workStartTime.Hour, workStartTime.Minute, workStartTime.Second)
        workEndTime = New Date(workDate.Year, workDate.Month, workDate.Day, workEndTime.Hour, workEndTime.Minute, workEndTime.Second)
        If DateDiff(DateInterval.Minute, workStartTime, workEndTime) < 1 Then
            breakMinutes = GetBreakTime(workDate, workStartTime, New Date(workDate.Year, workDate.Month, workDate.Day, 23, 59, 59))
            breakMinutes += GetBreakTime(workDate, New Date(workDate.Year, workDate.Month, workDate.Day, 0, 00, 00), workEndTime)
        Else
            breakMinutes = GetBreakTime(workDate, workStartTime, workEndTime)
        End If        

        Return breakMinutes

    End Function

    Private Shared Function GetBreakTime(workDate As Date, workStartTime As Date, workEndTime As Date) As Long

        Dim breakMinutes As Long = 0

        Using breakTimes As XPCollection(Of BreakTime) = New XPCollection(Of BreakTime)(Session.DefaultSession, (New BinaryOperator(BreakTime.Fields.Starting, workDate, BinaryOperatorType.LessOrEqual) And _
                                                                                                New BinaryOperator(BreakTime.Fields.Ending, workDate, BinaryOperatorType.Greater)) And _
                                                                                                (New BinaryOperator(BreakTime.Fields.WeekDay, workStartTime.DayOfWeek, BinaryOperatorType.Equal)))
            For Each break As BreakTime In breakTimes
                'Make sure that our work time and the break time are at the same time
                SetProperDates(break)

                If (break.StartTime.TimeOfDay > workEndTime.TimeOfDay AndAlso break.StartTime.DayOfWeek = workEndTime.DayOfWeek) OrElse _
                        (break.EndTime.TimeOfDay < workStartTime.TimeOfDay AndAlso break.EndTime.DayOfWeek = workStartTime.DayOfWeek) Then
                    Continue For
                End If

                'Get the length in minutes of the break time
                Dim interval As Long = DateDiff(DateInterval.Minute, break.StartTime, break.EndTime) - TakeDownExtraTimeOfBreak(workStartTime, workEndTime, break)

                breakMinutes += interval
            Next
        End Using

        Return breakMinutes

    End Function

End Class
