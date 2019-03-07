//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.XtraScheduler;

namespace SuperiorPackGroup
{
	public class ShiftsTimeScaleFixedInterval : TimeScaleFixedInterval
	{
		private readonly TimeSpan startDay = TimeSpan.FromHours(1.0);

		public ShiftsTimeScaleFixedInterval() : base(TimeSpan.FromHours(8.0))
		{

			Width = 250;

		}

		public ShiftsTimeScaleFixedInterval(TimeSpan scaleValue) : base(scaleValue)
		{

			Width = 250;

		}

        protected override string DefaultDisplayName => "WorkShift";

        protected override string DefaultMenuCaption => "Work Shift";

        public override DateTime Floor(DateTime date)
		{

			DateTime result = default(DateTime);

			if (date == DateTime.MinValue)
			{
				result = DateTime.MinValue + startDay;
			}
			else if (date.TimeOfDay < startDay)
			{
				result = date.Date + startDay; // - Value
			}
			else
			{
				result = base.Floor(date);
			}

			if (result.TimeOfDay < startDay)
			{
				result = result.Date + startDay;
			}
			else if (result.TimeOfDay == TimeSpan.FromHours(8.0) || result.TimeOfDay == TimeSpan.FromHours(16.0))
			{
				result += startDay;
			}

			return result;

		}

		//Public Overrides Function FormatCaption(start As Date, [end] As Date) As String

		//    Dim tomorrow As Date = start.Date.AddDays(1)
		//    Dim productionDay As String = String.Empty

		//    If start <> DateTime.MinValue Then
		//        If [end] <= New Date(start.Year, start.Month, start.Day, 9, 0, 0) Then
		//            productionDay = String.Format("{0}. ", start.AddDays(-1).ToString("ddd"))
		//        Else
		//            productionDay = String.Format("{0}. ", start.ToString("ddd"))
		//        End If
		//    End If

		//    If start >= New Date(start.Year, start.Month, start.Day, 1, 0, 0) And [end] <= New Date(start.Year, start.Month, start.Day, 9, 0, 0) Then
		//        Return String.Format("{0}Shift 3", productionDay)
		//    ElseIf start >= New Date(start.Year, start.Month, start.Day, 9, 0, 0) And [end] <= New Date(start.Year, start.Month, start.Day, 17, 0, 0) Then
		//        Return String.Format("{0}Shift 1", productionDay)
		//    ElseIf start >= New Date(start.Year, start.Month, start.Day, 17, 0, 0) And [end] <= New Date(tomorrow.Year, tomorrow.Month, tomorrow.Day, 1, 0, 0) Then
		//        Return String.Format("{0}Shift 2", productionDay)
		//    End If
		//    Return MyBase.FormatCaption(start, [end])

		//End Function

		public override DateTime GetNextDate(DateTime date)
		{

			DateTime result = base.GetNextDate(date);

			if (result.TimeOfDay < startDay || result.TimeOfDay == TimeSpan.FromHours(8.0) || result.TimeOfDay == TimeSpan.FromHours(16.0))
			{
				result += startDay;
			}

			return result;

		}

	}

}