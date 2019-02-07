//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;
using DevExpress.XtraScheduler.Services;

namespace SuperiorPackGroup
{
	public class ShiftsTimeScaleFixedIntervalCaptionService : HeaderCaptionServiceWrapper
	{
		public ShiftsTimeScaleFixedIntervalCaptionService(IHeaderCaptionService service, SchedulerControl provider) : base(service)
		{

			this.Provider = provider;

		}

		public override string GetTimeScaleHeaderCaption(TimeScaleHeader header)
		{

			//Return MyBase.GetTimeScaleHeaderCaption(header)
			if (header.Scale is ShiftsTimeScaleFixedInterval)
			{
				double assignedPeople = 0;
				if (Provider.Storage == null)
				{
					return "";
				}
				AppointmentBaseCollection scheduledProduction = Provider.Storage.GetAppointments(header.Interval);

//INSTANT C# NOTE: There is no C# equivalent to VB's implicit 'once only' variable initialization within loops, so the following variable declaration has been placed prior to the loop:
				double assignedQuantity = 0;
//INSTANT C# NOTE: There is no C# equivalent to VB's implicit 'once only' variable initialization within loops, so the following variable declaration has been placed prior to the loop:
				//double assignedQuantity = 0;
				foreach (Appointment productionSchedule in scheduledProduction)
				{
					if (productionSchedule.CustomFields["People"] != null)
					{
	//					Dim assignedQuantity As Double
						double.TryParse(productionSchedule.CustomFields["People"].ToString(), out assignedQuantity);
						assignedPeople += assignedQuantity;
					}
					if (productionSchedule.CustomFields["MachineOperator"] != null)
					{
	//					Dim assignedQuantity As Double
						double.TryParse(productionSchedule.CustomFields["MachineOperator"].ToString(), out assignedQuantity);
						assignedPeople += assignedQuantity;
					}
				}

				string caption = base.GetTimeScaleHeaderCaption(header);

				DateTime today = header.Interval.Start;
				DateTime tomorrow = header.Interval.Start.Date.AddDays(1);
				string productionDay = string.Empty;

				if (today != DateTime.MinValue)
				{
					if (header.Interval.End <= new DateTime(today.Year, today.Month, today.Day, 9, 0, 0))
					{
						productionDay = string.Format("{0}. ", today.AddDays(-1).ToString("ddd"));
					}
					else
					{
						productionDay = string.Format("{0}. ", today.ToString("ddd"));
					}
				}

				if (today >= new DateTime(today.Year, today.Month, today.Day, 1, 0, 0) && header.Interval.End <= new DateTime(today.Year, today.Month, today.Day, 9, 0, 0))
				{
					caption = string.Format("{0}Shift 3", productionDay);
				}
				else if (today >= new DateTime(today.Year, today.Month, today.Day, 9, 0, 0) && header.Interval.End <= new DateTime(today.Year, today.Month, today.Day, 17, 0, 0))
				{
					caption = string.Format("{0}Shift 1", productionDay);
				}
				else if (today >= new DateTime(today.Year, today.Month, today.Day, 17, 0, 0) && header.Interval.End <= new DateTime(tomorrow.Year, tomorrow.Month, tomorrow.Day, 1, 0, 0))
				{
					caption = string.Format("{0}Shift 2", productionDay);
				}

				caption = string.Format("{0} - People\\Operators Assigned {1}", caption, assignedPeople);

				return caption;
			}
			else
			{
				return base.GetTimeScaleHeaderCaption(header);
			}

		}

		public SchedulerControl Provider {get; set;}

	}

}