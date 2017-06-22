Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Calendar

Public Class VistaDatePeriodEditCalendar
    Inherits VistaDateEditCalendar

#Region "Fields"
    Private totalPeriodsCopy As PeriodSet
    Private _viewLevel As ViewLevel
    Private allowMark As Boolean
    Private isNeedDateChanged As Boolean = True
#End Region
#Region "Constructors"
    Public Sub New(ByVal item As RepositoryItemDateEdit, ByVal editDate As Object)

        MyBase.New(item, editDate)

        Selection.Clear()
        Multiselect = True
        TotalPeriods = New PeriodSet
        _viewLevel = GetNewLevel(Properties.OptionsSelection.DefaultLevel, Properties.OptionsSelection.DefaultLevel)
        CreatePrevImage(False)

    End Sub
#End Region
#Region "Protected Methods"
    Protected Overridable Sub ChangeDateOnItemClick(ByVal cell As DayNumberCellInfo)

        If _viewLevel = SuperiorPackGroup.ViewLevel.Weeks Then
            Return
        End If

        Dim maxDate As DateTime = DateTime

        If cell.Date.Month <> DateTime.Month Then
            maxDate = cell.Date
        Else
            maxDate = CalcPeriodEndDateTime(cell.Date, ViewLevel)
        End If

        If _viewLevel < SuperiorPackGroup.ViewLevel.Months Then
            If DateTime.Month < maxDate.Month Then
                If DateTime.Year = maxDate.Year Then
                    OnRightArrowClick()
                Else
                    OnLeftArrowClick()
                End If
            ElseIf DateTime.Month > maxDate.Month Then
                If DateTime.Year = maxDate.Year Then
                    OnLeftArrowClick()
                Else
                    OnRightArrowClick()
                End If
            End If

            Return
        End If

        If ViewLevel = SuperiorPackGroup.ViewLevel.Days Then
            DateTime = New DateTime(cell.Date.Year, cell.Date.Month, CorrectDay(DateTime.Year, cell.Date.Month, cell.Date.Day), 0, 0, 0)
        ElseIf ViewLevel = SuperiorPackGroup.ViewLevel.Weeks Then
            DateTime = New DateTime(cell.Date.Year, cell.Date.Month, CorrectDay(DateTime.Year, cell.Date.Month, DateTime.Day), 0, 0, 0)
        ElseIf ViewLevel = SuperiorPackGroup.ViewLevel.Months Then
            DateTime = New DateTime(DateTime.Year, cell.Date.Month, CorrectDay(DateTime.Year, cell.Date.Month, DateTime.Day), 0, 0, 0)
        ElseIf ViewLevel = SuperiorPackGroup.ViewLevel.Years Then
            DateTime = New DateTime(cell.Date.Year, DateTime.Month, CorrectDay(cell.Date.Year, DateTime.Month, cell.Date.Day), 0, 0, 0)
        End If

    End Sub

    Protected Overridable Function ConvertViewLevelToView(ByVal level As ViewLevel) As DateEditCalendarViewType

        If level = SuperiorPackGroup.ViewLevel.Days OrElse level = SuperiorPackGroup.ViewLevel.Weeks Then
            Return DateEditCalendarViewType.MonthInfo
        End If

        If level = SuperiorPackGroup.ViewLevel.Months Then
            Return DateEditCalendarViewType.YearInfo
        End If

        Return DateEditCalendarViewType.YearsInfo

    End Function

    Protected Overrides Function CreateInfoArgs() As DateEditInfoArgs

        Return New VistaDatePeriodEditInfoArgs(Me)

    End Function

    Protected Overrides Function CreatePainter() As DateEditPainter

        Return New VistaDatePeriodEditPainter(Me)

    End Function

    Protected Overrides Function CreateSelectionState() As DateEditCalendarStateBase

        Return New VistaDatePeriodEditCalendarSelectState(Me)

    End Function

    Protected Friend Overridable Function GetDayCells() As DayNumberCellInfoCollection

        Return Calendars(0).DayCells

    End Function

    Protected Overrides Function GetEndSelectionByState(dt As Date) As Date

        If ViewLevel = SuperiorPackGroup.ViewLevel.Weeks Then
            Return GetLastDayOfTheWeek(dt)
        End If

        Return MyBase.GetEndSelectionByState(dt)
    End Function

    Protected Overridable Function GetFirstDayOfTheWeek(ByVal selectedDate As DateTime) As DateTime

        Dim dt As New DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, 0, 0, 0)

        Do While dt.DayOfWeek <> FirstDayOfWeek
            dt = dt.AddDays(-1)
        Loop

        Return dt

    End Function

    Protected Overridable Function GetLastDayOfTheWeek(ByVal selectDate As DateTime) As DateTime

        Dim dt As DateTime = GetFirstDayOfTheWeek(selectDate)

        dt.AddDays(7).AddSeconds(-1)

        Return dt

    End Function

    Protected Overrides Function GetStartSelectionByState([date] As Date) As Date

        If ViewLevel = SuperiorPackGroup.ViewLevel.Weeks Then
            Return GetFirstDayOfTheWeek([date])
        End If

        Return MyBase.GetStartSelectionByState([date])
    End Function

    Protected Friend Overridable Function GetSwitchState() As Boolean

        Return SwitchState

    End Function

    Protected Overrides Sub IncView()

        ViewLevelUp()

    End Sub

    Protected Overridable Sub MarkItemOnClick(ByVal cell As DayNumberCellInfo)

        Dim begin As DateTime = CalcPeriodBeginDateTime(cell.Date)

        If ViewLevel = SuperiorPackGroup.ViewLevel.Days Then
            Dim weekBegin As DateTime = begin.AddDays(-begin.DayOfWeek + FirstDayOfWeek)
            Dim weekEnd As DateTime = begin.AddDays(6 - begin.DayOfWeek + FirstDayOfWeek)

            MarkPeriod(weekBegin, weekEnd)
        ElseIf ViewLevel = SuperiorPackGroup.ViewLevel.Weeks OrElse ViewLevel = SuperiorPackGroup.ViewLevel.Months OrElse ViewLevel = SuperiorPackGroup.ViewLevel.Years Then
            MarkPeriod(begin, CalcPeriodEndDateTime(begin, ViewLevel))
        End If

    End Sub

    Protected Overridable Sub MarkPeriod(ByVal beginDate As DateTime, ByVal endDate As DateTime)

        If Properties.OptionsSelection.MultiSelectBehavior = MultiSelectBehavior.Merging Then
            TotalPeriods.MergeWith(beginDate, endDate)
        ElseIf Properties.OptionsSelection.MultiSelectBehavior = MultiSelectBehavior.Intersection Then
            TotalPeriods.IntersectsWith(beginDate, endDate)
        ElseIf Properties.OptionsSelection.MultiSelectBehavior = MultiSelectBehavior.Disabled Then
            If Not TotalPeriods.ContainPeriod(beginDate, endDate) Then
                TotalPeriods.Periods.Clear()
            End If
            TotalPeriods.IntersectsWith(beginDate, endDate)
        End If

        UpdateSelection()
        Selection.Clear()

    End Sub

    Protected Overridable Sub MarkSelectedDay()

        If Selection.Count = 0 Then
            Return
        End If

        MarkPeriod(Selection(0), Selection(1))

    End Sub

    Protected Overrides Sub OnCancelClick()

        Properties.OwnerEdit.CancelPopup()

    End Sub

    Protected Overrides Sub OnClearClick()

        TotalPeriods.Periods.Clear()
        UpdateExistingCellsState()
        Invalidate()

    End Sub

    Protected Overrides Sub OnDateTimeChanged(value As Date)

        If isNeedDateChanged Then
            MyBase.OnDateTimeChanged(value)
        End If

    End Sub

    Protected Overrides Sub OnDateTimeCommit(value As Object, cleared As Boolean)

    End Sub

    Protected Overrides Sub OnItemClick(hitInfo As CalendarHitInfo)

        Dim cell As DayNumberCellInfo = TryCast(hitInfo.HitObject, DayNumberCellInfo)

        If cell IsNot Nothing Then
            ChangeDateOnItemClick(cell)

            If ViewLevel = Properties.OptionsSelection.LowLevel OrElse (CtrlKeyPressed AndAlso Properties.OptionsSelection.MultiSelectBehavior <> MultiSelectBehavior.Disabled) Then
                MarkItemOnClick(cell)
            Else
                TotalPeriods = totalPeriodsCopy.GetCopy
                ViewLevelDown()
            End If
        End If

    End Sub

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        MyBase.OnMouseDown(e)

        Dim hit As CalendarHitInfo = GetHitInfo(e)

        totalPeriodsCopy = TotalPeriods.GetCopy

        If Not CtrlKeyPressed Then
            If hit.InfoType = CalendarHitInfoType.Item OrElse hit.InfoType = CalendarHitInfoType.WeekNumber OrElse hit.InfoType = CalendarHitInfoType.Unknown Then
                TotalPeriods.Periods.Clear()
            End If
        End If

    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)

        allowMark = True

        MyBase.OnMouseUp(e)

        If Not allowMark Then
            Return
        End If

        MarkSelectedDay()

    End Sub

    Protected Overrides Sub OnMoveHorizontal(dir As Integer)

    End Sub

    Protected Overrides Sub OnMoveVertical(dir As Integer)

    End Sub

    Protected Overridable Sub OnWeekNumberClick(ByVal hit As CalendarHitInfo)

        Dim week As DayNumberCellInfo = TryCast(hit.HitObject, DayNumberCellInfo)

        If week IsNot Nothing AndAlso Properties.OptionsSelection.MultiSelectBehavior <> MultiSelectBehavior.Disabled Then
            MarkPeriod(week.Date, week.Date.AddDays(7).AddSeconds(-1))
        End If

    End Sub

    Protected Overrides Sub ProcessClick(hit As CalendarHitInfo)

        allowMark = False

        MyBase.ProcessClick(hit)

        If hit.InfoType = CalendarHitInfoType.WeekNumber Then
            OnWeekNumberClick(hit)
        End If

    End Sub

    Protected Friend Overridable Sub UpdateSelection()

        UpdateExistingCellsState()
        Invalidate()

    End Sub

    Protected Overridable Sub UpdateTotalPeriods(ByVal value As Object)

        Dim editValue As PeriodSet = TryCast(value, PeriodSet)

        TotalPeriods.Periods.Clear()

        If editValue IsNot Nothing Then
            TotalPeriods = editValue.GetCopy()
        Else
            If TypeOf value Is String Then
                TotalPeriods = PeriodSet.Parse(CStr(value))
            End If
        End If

    End Sub
#End Region
#Region "Protected Properties"
    Protected Overridable ReadOnly Property CtrlKeyPressed() As Boolean
        Get
            Return (Control.ModifierKeys And Keys.Control) <> 0
        End Get
    End Property

    Protected Friend Overridable Shadows ReadOnly Property Properties() As RepositoryItemDatePeriodEdit
        Get
            Return TryCast(MyBase.Properties, RepositoryItemDatePeriodEdit)
        End Get
    End Property

    Protected Overrides Sub SetSelection([date] As Date)

    End Sub

    Protected Overrides Sub SetSelectionRange([date] As Date)

    End Sub
#End Region
#Region "Public Methods"
    Public Overridable Function CalcPeriodBeginDateTime(ByVal begin As DateTime) As DateTime

        Return begin.Date

    End Function

    Public Overridable Function CalcPeriodEndDateTime(ByVal begin As DateTime, ByVal level As ViewLevel) As DateTime

        Dim endDate As DateTime = begin

        If level = SuperiorPackGroup.ViewLevel.Days Then
            endDate = endDate.AddDays(1).AddSeconds(-1)
        ElseIf level = SuperiorPackGroup.ViewLevel.Weeks Then
            endDate = endDate.AddDays(7).AddSeconds(-1)
        ElseIf level = SuperiorPackGroup.ViewLevel.Months Then
            endDate = endDate.AddMonths(1).AddSeconds(-1)
        ElseIf level = SuperiorPackGroup.ViewLevel.Years Then
            endDate = endDate.AddYears(1).AddSeconds(-1)
        End If

        Return endDate

    End Function

    Public Overridable Function GetNewLevel(ByVal newLevel As ViewLevel, ByVal currentLevel As ViewLevel) As ViewLevel

        Dim lowLevel As ViewLevel = Properties.OptionsSelection.LowLevel
        Dim highLevel As ViewLevel = Properties.OptionsSelection.HighLevel

        If Properties.OptionsSelection.ShowWeekLevel = False Then
            If lowLevel = SuperiorPackGroup.ViewLevel.Weeks Then
                lowLevel = SuperiorPackGroup.ViewLevel.Months
            End If
            If highLevel = SuperiorPackGroup.ViewLevel.Weeks Then
                highLevel = SuperiorPackGroup.ViewLevel.Days
            End If
        End If

        If lowLevel > highLevel Then
            Return currentLevel
        End If

        If newLevel < lowLevel Then
            Return lowLevel
        End If

        If newLevel > highLevel Then
            Return highLevel
        End If

        Return newLevel

    End Function

    Public Overrides Sub ResetState(editDate As Object, dt As Date)

        UpdateTotalPeriods(editDate)
        MyBase.ResetState(editDate, dt)
        isNeedDateChanged = False

        If TotalPeriods.Periods.Count = 0 Then
            DateTime = Date.Now
        Else
            DateTime = TotalPeriods(0).BeginDate
        End If

        isNeedDateChanged = True
        ViewLevel = GetNewLevel(ViewLevel, ViewLevel)

    End Sub

    Public Overridable Sub ViewLevelDown()

        If ViewLevel = SuperiorPackGroup.ViewLevel.Years Then
            ViewLevel = SuperiorPackGroup.ViewLevel.Months
        ElseIf ViewLevel = SuperiorPackGroup.ViewLevel.Months Then
            If Properties.OptionsSelection.ShowWeekLevel Then
                ViewLevel = SuperiorPackGroup.ViewLevel.Weeks
            Else
                ViewLevel = SuperiorPackGroup.ViewLevel.Days
            End If
        Else
            ViewLevel = SuperiorPackGroup.ViewLevel.Days
        End If

    End Sub

    Public Overridable Sub ViewLevelUp()

        If ViewLevel = SuperiorPackGroup.ViewLevel.Days Then
            If Properties.OptionsSelection.ShowWeekLevel Then
                ViewLevel = SuperiorPackGroup.ViewLevel.Weeks
            Else
                ViewLevel = SuperiorPackGroup.ViewLevel.Months
            End If
        ElseIf ViewLevel = SuperiorPackGroup.ViewLevel.Weeks Then
            ViewLevel = SuperiorPackGroup.ViewLevel.Months
        Else
            ViewLevel = SuperiorPackGroup.ViewLevel.Years
        End If

    End Sub
#End Region
#Region "Public Properties"
    Public Overridable Shadows Property DateTime() As DateTime
        Get
            Return MyBase.DateTime.Date
        End Get
        Set(value As DateTime)
            MyBase.DateTime = value.Date
        End Set
    End Property

    Public Overrides ReadOnly Property FirstDayOfWeek As DayOfWeek
        Get
            Return Properties.OptionsSelection.FirstDayOfWeek
        End Get
    End Property

    Public Overridable Property TotalPeriods() As PeriodSet

    Public Overrides Property View() As DateEditCalendarViewType
        Get
            Return ConvertViewLevelToView(ViewLevel)
        End Get
        Set(value As DateEditCalendarViewType)

        End Set
    End Property

    Public Overridable Property ViewLevel() As ViewLevel
        Get
            Return _viewLevel
        End Get
        Set(value As ViewLevel)
            Dim newValue As ViewLevel = GetNewLevel(value, ViewLevel)
            Dim oldValue As ViewLevel = ViewLevel

            If oldValue = newValue Then
                Return
            End If

            Dim oldView, newView As DateEditCalendarViewType

            If oldValue = SuperiorPackGroup.ViewLevel.Days AndAlso newValue = SuperiorPackGroup.ViewLevel.Weeks Then
                oldView = DateEditCalendarViewType.MonthInfo
                newView = DateEditCalendarViewType.YearInfo
            Else
                oldView = ConvertViewLevelToView(oldValue)
                newView = ConvertViewLevelToView(newValue)
            End If

            OnViewChanging(oldView, newView)
            _viewLevel = newValue
            OnViewChanged(oldView, newView)
        End Set
    End Property
#End Region
End Class
