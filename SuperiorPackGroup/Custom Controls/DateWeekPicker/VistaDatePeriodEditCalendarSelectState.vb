Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Calendar

Public Class VistaDatePeriodEditCalendarSelectState
    Inherits VistaDateEditCalendarSelectState

    Public Sub New(ByVal control As DateEditCalendarBase)
        MyBase.New(control)

    End Sub

    Protected Overrides Sub FindMinMaxDateInRect(rect As Rectangle, ByRef minDate As Date, ByRef maxDate As Date, inverse As Boolean)

        Dim down, up As Point

        If inverse Then
            down = New Point(rect.Left, rect.Bottom)
            up = New Point(rect.Right, rect.Top)
        Else
            up = rect.Location
            down = New Point(rect.Right, rect.Bottom)
        End If

        Dim minCell As DayNumberCellInfo = GetCellByPoint(down, False)
        Dim maxCell As DayNumberCellInfo = GetCellByPoint(up, False)
        minDate = DateTime.MaxValue
        maxDate = DateTime.MinValue

        If minCell IsNot Nothing AndAlso maxCell IsNot Nothing Then
            If maxCell IsNot minCell Then
                If minCell.Date < maxCell.Date Then
                    minDate = minCell.Date
                    maxDate = maxCell.Date
                Else
                    maxDate = minCell.Date
                    minDate = maxCell.Date
                End If
            End If
        End If

    End Sub

    Protected Overrides Function GetCellByPoint(pt As Point, nearestLeft As Boolean) As DayNumberCellInfo

        For Each cell As DayNumberCellInfo In DatePeriodCalendar.GetDayCells()
            If cell.Bounds.Contains(pt) Then
                Return cell
            End If
        Next

        Return Nothing

    End Function

    Protected Overrides Sub UpdateSelection(e As MouseEventArgs)

        If DatePeriodCalendar.Properties.OptionsSelection.MultiSelectBehavior = MultiSelectBehavior.Disabled Then
            Return
        End If

        Dim oldSelectionCount As Integer = DatePeriodCalendar.Selection.Count

        MyBase.UpdateSelection(e)

        If oldSelectionCount <> DatePeriodCalendar.Selection.Count AndAlso DatePeriodCalendar.Selection.Count = 0 Then
            DatePeriodCalendar.UpdateSelection()
        End If

    End Sub

    Protected Overrides ReadOnly Property ShiftKeyPressed As Boolean
        Get
            Return False
        End Get
    End Property

    Public Overridable ReadOnly Property DatePeriodCalendar() As VistaDatePeriodEditCalendar
        Get
            Return TryCast(VistaCalendar, VistaDatePeriodEditCalendar)
        End Get
    End Property

End Class
