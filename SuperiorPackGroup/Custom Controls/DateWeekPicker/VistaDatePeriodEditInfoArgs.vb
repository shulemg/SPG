Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Calendar

Public Class VistaDatePeriodEditInfoArgs
    Inherits VistaDateEditInfoArgs

#Region "Constructors"
    Public Sub New(ByVal calendar As DateEditCalendarBase)

        MyBase.New(calendar)

    End Sub
#End Region
#Region "Protected Methods"
    Protected Overrides Sub CalcHeaderInfo()
        MyBase.CalcHeaderInfo()

        Dim indent As Integer = CInt(GetButtonRect(Rectangle.Empty).Width / 2)

        ClearRect = New Rectangle(LeftArrowInfo.Bounds.Right + indent, Content.Bottom + IndentFromDateInfoToClearText, ClearRect.Width, ClearRect.Height)
        OkRect = New Rectangle(CInt(LeftArrowInfo.Bounds.Right + (RightArrowInfo.Bounds.X - LeftArrowInfo.Bounds.Right - OkRect.Width) / 2), Content.Bottom + IndentFromDateInfoToClearText, OkRect.Width, OkRect.Height)
        CancelRect = New Rectangle(RightArrowInfo.Bounds.X - indent - CancelRect.Right, Content.Bottom + IndentFromDateInfoToClearText, CancelRect.Width, CancelRect.Height)

        OkButtonRect = GetButtonRect(OkRect)
        CancelButtonRect = GetButtonRect(CancelRect)
        ClearButtonRect = GetButtonRect(ClearRect)

    End Sub

    Protected Overrides Sub CalcItemsInfo()

        If Calendar.ViewLevel = ViewLevel.Weeks Then
            CalcWeekItemsInfo()
        Else
            MyBase.CalcItemsInfo()
        End If

    End Sub

    Protected Overridable Sub CalcWeekItemsInfo()

        DayCells.Clear()
        WeekCells.Clear()

        Dim rect As New Rectangle(New Point(DateClientRect.X + DistanceFromLeftToCell, DateClientRect.Y), New Size(CInt((DateClientRect.Width - 4) / 2), CInt(DateClientRect.Height / 3)))
        Dim currInfo As DayNumberCellInfo

        For row As Integer = 0 To 2
            For col As Integer = 0 To 1
                currInfo = CreateWeekCellInfo(row, col)

                If currInfo IsNot Nothing Then
                    currInfo.SetAppearance(Appearance)
                    currInfo.TextBounds = CalcCellTextRect(currInfo.Text, rect)
                    currInfo.Bounds = rect
                    DayCells.Add(currInfo)
                End If

                rect.Offset(rect.Width, 0)
            Next col

            rect.X = DateClientRect.X + DistanceFromLeftToCell
            rect.Offset(0, rect.Height)
        Next row

        UpdateExistingCellsState()

    End Sub

    Protected Overrides Function CreateDayCell([date] As Date) As DayNumberCellInfo

        Return New CustomDayNumberCellInfo([date])

    End Function

    Protected Overrides Function CreateMonthCellInfo(row As Integer, col As Integer) As DayNumberCellInfo

        Dim oldInfo As DayNumberCellInfo = MyBase.CreateMonthCellInfo(row, col)

        If oldInfo Is Nothing Then
            Return oldInfo
        End If

        Dim patchedInfo As New CustomDayNumberCellInfo(oldInfo.Date) With {.Text = oldInfo.Text}

        Return patchedInfo

    End Function

    Protected Overridable Function CreateWeekCellInfo(ByVal row As Integer, ByVal col As Integer) As DayNumberCellInfo

        Dim currInfo As DayNumberCellInfo
        Dim dt As DateTime = FirstVisibleDate.AddDays(14 + row * 7 + col)
        currInfo = New CustomDayNumberCellInfo(dt)

        Dim endDay As DateTime = currInfo.Date.AddDays(6)
        currInfo.Text = String.Format("{0} {1} - {0} {2}", Calendar.DateFormat.GetAbbreviatedMonthName(currInfo.Date.Month), currInfo.Date.Day, endDay.Day)

        Return currInfo

    End Function

    Protected Overrides Function CreateYearCellInfo(row As Integer, col As Integer) As DayNumberCellInfo

        Dim oldInfo As DayNumberCellInfo = MyBase.CreateYearCellInfo(row, col)

        If oldInfo Is Nothing Then
            Return oldInfo
        End If

        Dim patchedInfo As New CustomDayNumberCellInfo(oldInfo.Date) With {.Text = oldInfo.Text}

        Return patchedInfo

    End Function

    Protected Overrides Function IsDateActive(cell As DayNumberCellInfo) As Boolean

        If Calendar.ViewLevel = ViewLevel.Weeks Then
            Return True
        End If

        Return MyBase.IsDateActive(cell)

    End Function

    Protected Overrides Function IsMultiselectDateSelected(cell As DayNumberCellInfo) As Boolean

        Dim selected As Boolean = MyBase.IsMultiselectDateSelected(cell)
        Dim patchCell As CustomDayNumberCellInfo = TryCast(cell, CustomDayNumberCellInfo)

        If patchCell IsNot Nothing Then
            Dim endDate As DateTime = Calendar.CalcPeriodEndDateTime(cell.Date, Calendar.ViewLevel)

            patchCell.Marked = Calendar.TotalPeriods.ContainPeriod(cell.Date, endDate)
            patchCell.ContainMark = Calendar.TotalPeriods.ContainPartOfPeriod(cell.Date, endDate)

            If selected Then
                If Calendar.Properties.OptionsSelection.MultiSelectBehavior = MultiSelectBehavior.Merging OrElse
                    (Calendar.Properties.OptionsSelection.MultiSelectBehavior = MultiSelectBehavior.Intersection AndAlso patchCell.Marked = True) Then

                    patchCell.ContainMark = False
                End If

                If patchCell.Marked AndAlso Calendar.Properties.OptionsSelection.MultiSelectBehavior = MultiSelectBehavior.Intersection Then
                    selected = False
                End If

                patchCell.Marked = False
            End If
        End If

        Return selected

    End Function
#End Region
#Region "Public Methods"
    Public Overrides Function GetHitInfo(e As MouseEventArgs) As CalendarHitInfo

        Dim baseHitInfo As CalendarHitInfo = MyBase.GetHitInfo(e)

        If baseHitInfo.InfoType <> CalendarHitInfoType.Unknown Then
            Return baseHitInfo
        End If

        If OkButtonRect.Contains(e.Location) Then
            baseHitInfo.InfoType = CalendarHitInfoType.Ok
            baseHitInfo.Bounds = OkButtonRect
        ElseIf CancelButtonRect.Contains(e.Location) Then
            baseHitInfo.InfoType = CalendarHitInfoType.Cancel
            baseHitInfo.Bounds = CancelButtonRect
        End If

        If ShowWeekNumbers Then
            For i As Integer = 0 To WeekCells.Count - 1
                If WeekCells(i).Bounds.Contains(e.Location) Then
                    Dim cellDate As New DateTime(DayCells(0).Date.Year, DayCells(0).Date.Month, DayCells(0).Date.Day, 0, 0, 0)
                    cellDate = cellDate.AddDays(7 * i)

                    Dim cell As New DayNumberCellInfo(cellDate)
                    baseHitInfo.InfoType = CalendarHitInfoType.WeekNumber
                    baseHitInfo.HitObject = cell
                End If
            Next i
        End If

        Return baseHitInfo

    End Function
#End Region
#Region "Public Properties"
    Public Overridable Shadows ReadOnly Property Calendar() As VistaDatePeriodEditCalendar
        Get
            Return TryCast(MyBase.Calendar, VistaDatePeriodEditCalendar)
        End Get
    End Property
#End Region
End Class
