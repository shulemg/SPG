//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DXDAL.SPGData;
using Microsoft.VisualBasic;

namespace SuperiorPackGroup
{
	public class BreakTimeBLL
	{

		private static void SetProperDates(BreakTime @break)
		{

			//make sure that the date for start of break is on the same day in the week as the weekday field
			if (@break.StartTime.DayOfWeek != @break.WeekDay)
			{
				@break.StartTime = Microsoft.VisualBasic.DateAndTime.DateAdd(DateInterval.Weekday, (int)@break.WeekDay - (int)@break.StartTime.DayOfWeek, @break.StartTime);
			}

			//Make sure that the break end time has the proper date
			if (@break.StartTime.TimeOfDay < @break.EndTime.TimeOfDay)
			{
				@break.EndTime = new DateTime(@break.StartTime.Year, @break.StartTime.Month, @break.StartTime.Day, @break.EndTime.Hour, @break.EndTime.Minute, 0);
			}
			if (@break.StartTime.TimeOfDay > @break.EndTime.TimeOfDay)
			{
				@break.EndTime = new DateTime(@break.StartTime.Year, @break.StartTime.Month, @break.StartTime.Day + 1, @break.EndTime.Hour, @break.EndTime.Minute, 0);
			}

		}

		private static long TakeDownExtraTimeOfBreak(DateTime workStartTime, DateTime workEndTime, BreakTime @break)
		{

			//take down the time of the break that's not in our work time
			if (workStartTime.TimeOfDay > @break.StartTime.TimeOfDay && @break.WeekDay == workStartTime.DayOfWeek)
			{
				return DateHelper.DateDiff(DateHelper.DateInterval.Minute, Convert.ToDateTime(@break.StartTime.TimeOfDay.ToString()), Convert.ToDateTime(workStartTime.TimeOfDay.ToString()));
			}
			else if (workEndTime.TimeOfDay < @break.EndTime.TimeOfDay && @break.WeekDay == workEndTime.DayOfWeek)
			{
				return DateHelper.DateDiff(DateHelper.DateInterval.Minute, Convert.ToDateTime(workEndTime.TimeOfDay.ToString()), Convert.ToDateTime(@break.EndTime.TimeOfDay.ToString()));
			}

			return 0;

		}

		public static long GetBreakMinutes(DateTime workDate, DateTime workStartTime, DateTime workEndTime)
		{

			if (workDate < new DateTime(1754, 1, 1))
			{
				return 0;
			}

			//Take off the seconds from the work end time
			if (workEndTime.Second != 0)
			{
				workEndTime = new DateTime(workEndTime.Year, workEndTime.Month, workEndTime.Day, workEndTime.Hour, workEndTime.Minute, 0);
			}

			long breakMinutes = 0;
			//Make sure that the work time dates are the same as the production date, and that the work end time is on the correct date

			workStartTime = new DateTime(workDate.Year, workDate.Month, workDate.Day, workStartTime.Hour, workStartTime.Minute, workStartTime.Second);
			workEndTime = new DateTime(workDate.Year, workDate.Month, workDate.Day, workEndTime.Hour, workEndTime.Minute, workEndTime.Second);
			if (DateHelper.DateDiff(DateHelper.DateInterval.Minute, workStartTime, workEndTime) < 1)
			{
				breakMinutes = GetBreakTime(workDate, workStartTime, new DateTime(workDate.Year, workDate.Month, workDate.Day, 23, 59, 59));
				breakMinutes += GetBreakTime(workDate, new DateTime(workDate.Year, workDate.Month, workDate.Day, 0, 00, 00), workEndTime);
			}
			else
			{
				breakMinutes = GetBreakTime(workDate, workStartTime, workEndTime);
			}

			return breakMinutes;

		}

		private static long GetBreakTime(DateTime workDate, DateTime workStartTime, DateTime workEndTime)
		{

			long breakMinutes = 0;

			using (XPCollection<BreakTime> breakTimes = new XPCollection<BreakTime>((new BinaryOperator(BreakTime.Fields.Starting, workDate, BinaryOperatorType.LessOrEqual) & new BinaryOperator(BreakTime.Fields.Ending, workDate, BinaryOperatorType.Greater)) & (new BinaryOperator(BreakTime.Fields.WeekDay, (int)workStartTime.DayOfWeek, BinaryOperatorType.Equal))))
			{
				foreach (BreakTime @break in breakTimes)
				{
					//Make sure that our work time and the break time are at the same time
					SetProperDates(@break);

					if ((@break.StartTime.TimeOfDay > workEndTime.TimeOfDay && @break.StartTime.DayOfWeek == workEndTime.DayOfWeek) || (@break.EndTime.TimeOfDay < workStartTime.TimeOfDay && @break.EndTime.DayOfWeek == workStartTime.DayOfWeek))
					{
						continue;
					}

					//Get the length in minutes of the break time
					long interval = DateHelper.DateDiff(DateHelper.DateInterval.Minute, @break.StartTime, @break.EndTime) - TakeDownExtraTimeOfBreak(workStartTime, workEndTime, @break);

					breakMinutes += interval;
				}
			}

			return breakMinutes;

		}

	}

}