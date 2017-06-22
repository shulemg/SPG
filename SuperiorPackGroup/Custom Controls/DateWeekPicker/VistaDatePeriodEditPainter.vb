Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Calendar
Imports DevExpress.XtraEditors.ViewInfo

Public Class VistaDatePeriodEditPainter
    Inherits VistaDateEditPainter

    Public Sub New(ByVal calendar As DateEditCalendarBase)
        MyBase.New(calendar)

    End Sub

    Protected Overrides Sub DrawDayCell(info As DevExpress.XtraEditors.Calendar.CalendarObjectInfoArgs, cell As DevExpress.XtraEditors.Calendar.DayNumberCellInfo)

        Dim isDrawn As Boolean
        Dim patchCell As CustomDayNumberCellInfo = TryCast(cell, CustomDayNumberCellInfo)

        If patchCell IsNot Nothing Then
            isDrawn = DrawPatchedCell(info, patchCell)
        Else
            isDrawn = False
        End If

        If isDrawn = False Then
            MyBase.DrawDayCell(info, cell)
        End If

    End Sub

    Protected Overrides Sub DrawHeader(info As CalendarObjectInfoArgs)
        MyBase.DrawHeader(info)

        Dim vdi As VistaDateEditInfoArgs = TryCast(info, VistaDateEditInfoArgs)

        If vdi Is Nothing Then
            Return
        End If

        DrawOk(vdi)
        DrawCancel(vdi)

    End Sub

    Protected Overridable Function DrawPatchedCell(ByVal info As CalendarObjectInfoArgs, ByVal patchedCell As CustomDayNumberCellInfo) As Boolean

        patchedCell.Today = patchedCell.Marked
        MyBase.DrawDayCell(info, patchedCell)

        If Not patchedCell.Marked Then
            If patchedCell.ContainMark Then
                MarkCellContent(info, patchedCell)
            End If
        End If

        Return True

    End Function

    Protected Overrides Sub DrawWeekdaysAbbreviation(info As CalendarObjectInfoArgs)

        If (CType(info.Calendar, VistaDatePeriodEditCalendar)).ViewLevel = ViewLevel.Weeks Then
            Return
        End If

        MyBase.DrawWeekdaysAbbreviation(info)

    End Sub

    Protected Overridable Sub MarkCellContent(ByVal info As CalendarObjectInfoArgs, ByVal cell As DayNumberCellInfo)

        Dim width As Integer = CInt(cell.Bounds.Width / 3)
        Dim height As Integer = CInt(cell.Bounds.Height / 3)
        Dim r As New Rectangle(cell.Bounds.Location, New Size(width, height))
        Dim icon As New DayNumberCellInfo(cell.Date)

        r.Offset(width * 2, height * 2)
        icon.Today = True
        icon.Bounds = r
        icon.Text = String.Empty
        icon.Selected = True

        MyBase.DrawDayCell(info, icon)

    End Sub

End Class
