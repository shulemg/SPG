//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using DXDAL.SPGData;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace SuperiorPackGroup
{
	public class ShiftScheduleReportBLL
	{

		public static XPView GetShiftScheduleReport(DateTime? scheduleDate, string scheduleShift)
		{

			if (scheduleDate.HasValue == false)
			{
				scheduleDate = DateTime.Today;
			}

			//If String.IsNullOrEmpty(scheduleShift) Then
			//    scheduleShift = "Shift 1"
			//End If

			XPView shiftScheduleReportXPview = new XPView(Session.DefaultSession, typeof(ProductionSchedule));

			try
			{
				shiftScheduleReportXPview.Criteria = GetShiftScheduleReportCriteria(scheduleDate, scheduleShift);

				shiftScheduleReportXPview.Properties.AddRange(new ViewProperty[]
				{
					new ViewProperty("MachineLineName", SortDirection.None, ProductionSchedule.Fields.MachineLine.MachineLineName.PropertyName, false, true),
					new ViewProperty("People", SortDirection.None, ProductionSchedule.Fields.People.PropertyName, false, true),
					new ViewProperty("Operator", SortDirection.None, ProductionSchedule.Fields.MachineOperator.PropertyName, false, true),
					new ViewProperty("ItemCode", SortDirection.None, ProductionSchedule.Fields.ProductionItem.ItemCode.PropertyName, false, true),
					new ViewProperty("ItemDescription", SortDirection.None, ProductionSchedule.Fields.ProductionItem.ItemDescription.PropertyName, false, true),
					new ViewProperty("Quantity", SortDirection.None, ProductionSchedule.Fields.Quantity.PropertyName, false, true),
					new ViewProperty("ShedByQty", SortDirection.None, ProductionSchedule.Fields.ScheduleByQuantity.PropertyName, false, true),
					new ViewProperty("ShceduleNote", SortDirection.None, ProductionSchedule.Fields.ScheduleNote.PropertyName, false, true),
					new ViewProperty("MustRun", SortDirection.None, ProductionSchedule.Fields.MustRun.PropertyName, false, true),
					new ViewProperty("PriorityLevel", SortDirection.None, ProductionSchedule.Fields.PriorityLevel.PropertyName, false, true),
					new ViewProperty("Start", SortDirection.None, ProductionSchedule.Fields.Start.PropertyName, false, true),
					new ViewProperty("Finish", SortDirection.None, ProductionSchedule.Fields.Finish.PropertyName, false, true)
				});
				return shiftScheduleReportXPview;
			}
			catch (ArgumentException ex)
			{
				MessageBox.Show(string.Format("There was an error while trying to retrieve the data for the report.{{1}", Environment.NewLine, ex.Message));
			}

			return null;

		}

		private static CriteriaOperator GetShiftScheduleReportCriteria(DateTime? scheduleDate, string scheduleShift)
		{

			switch (scheduleShift)
			{
				case "Shift 1":
					return new GroupOperator(GroupOperatorType.Or, new GroupOperator(GroupOperatorType.And, new BinaryOperator(ProductionSchedule.Fields.Start.PropertyName, DateTime.Parse(string.Format("{0} 9:00", scheduleDate.Value.ToShortDateString())), BinaryOperatorType.GreaterOrEqual), new BinaryOperator(ProductionSchedule.Fields.Finish.PropertyName, DateTime.Parse(string.Format("{0} 5:00 PM", scheduleDate.Value.ToShortDateString())), BinaryOperatorType.LessOrEqual)), new GroupOperator(GroupOperatorType.And, new BinaryOperator(ProductionSchedule.Fields.Start.PropertyName, DateTime.Parse(string.Format("{0} 9:00", scheduleDate.Value.ToShortDateString())), BinaryOperatorType.Less), new BinaryOperator(ProductionSchedule.Fields.Finish.PropertyName, DateTime.Parse(string.Format("{0} 9:00", scheduleDate.Value.ToShortDateString())), BinaryOperatorType.Greater)), new GroupOperator(GroupOperatorType.And, new BinaryOperator(ProductionSchedule.Fields.Start.PropertyName, DateTime.Parse(string.Format("{0} 5:00 PM", scheduleDate.Value.ToShortDateString())), BinaryOperatorType.Less), new BinaryOperator(ProductionSchedule.Fields.Finish.PropertyName, DateTime.Parse(string.Format("{0} 5:00 PM", scheduleDate.Value.ToShortDateString())), BinaryOperatorType.Greater)));
				case "Shift 2":
					return new GroupOperator(GroupOperatorType.Or, new GroupOperator(GroupOperatorType.And, new BinaryOperator(ProductionSchedule.Fields.Start.PropertyName, DateTime.Parse(string.Format("{0} 5:00 PM", scheduleDate.Value.ToShortDateString())), BinaryOperatorType.GreaterOrEqual), new BinaryOperator(ProductionSchedule.Fields.Finish.PropertyName, DateTime.Parse(string.Format("{0} 1:00", scheduleDate.Value.AddDays(1).ToShortDateString())), BinaryOperatorType.LessOrEqual)), new GroupOperator(GroupOperatorType.And, new BinaryOperator(ProductionSchedule.Fields.Start.PropertyName, DateTime.Parse(string.Format("{0} 5:00 PM", scheduleDate.Value.ToShortDateString())), BinaryOperatorType.Less), new BinaryOperator(ProductionSchedule.Fields.Finish.PropertyName, DateTime.Parse(string.Format("{0} 5:00 PM", scheduleDate.Value.ToShortDateString())), BinaryOperatorType.Greater)), new GroupOperator(GroupOperatorType.And, new BinaryOperator(ProductionSchedule.Fields.Start.PropertyName, DateTime.Parse(string.Format("{0} 1:00", scheduleDate.Value.AddDays(1).ToShortDateString())), BinaryOperatorType.Less), new BinaryOperator(ProductionSchedule.Fields.Finish.PropertyName, DateTime.Parse(string.Format("{0} 1:00", scheduleDate.Value.AddDays(1).ToShortDateString())), BinaryOperatorType.Greater)));
				case "Shift 3":
					return new GroupOperator(GroupOperatorType.Or, new GroupOperator(GroupOperatorType.And, new BinaryOperator(ProductionSchedule.Fields.Start.PropertyName, DateTime.Parse(string.Format("{0} 1:00", scheduleDate.Value.AddDays(1).ToShortDateString())), BinaryOperatorType.GreaterOrEqual), new BinaryOperator(ProductionSchedule.Fields.Finish.PropertyName, DateTime.Parse(string.Format("{0} 9:00", scheduleDate.Value.AddDays(1).ToShortDateString())), BinaryOperatorType.LessOrEqual)), new GroupOperator(GroupOperatorType.And, new BinaryOperator(ProductionSchedule.Fields.Start.PropertyName, DateTime.Parse(string.Format("{0} 1:00", scheduleDate.Value.AddDays(1).ToShortDateString())), BinaryOperatorType.Less), new BinaryOperator(ProductionSchedule.Fields.Finish.PropertyName, DateTime.Parse(string.Format("{0} 1:00", scheduleDate.Value.AddDays(1).ToShortDateString())), BinaryOperatorType.Greater)), new GroupOperator(GroupOperatorType.And, new BinaryOperator(ProductionSchedule.Fields.Start.PropertyName, DateTime.Parse(string.Format("{0} 9:00", scheduleDate.Value.AddDays(1).ToShortDateString())), BinaryOperatorType.Less), new BinaryOperator(ProductionSchedule.Fields.Finish.PropertyName, DateTime.Parse(string.Format("{0} 9:00", scheduleDate.Value.AddDays(1).ToShortDateString())), BinaryOperatorType.Greater)));
				default:
					return new GroupOperator(GroupOperatorType.Or, new GroupOperator(GroupOperatorType.And, new BinaryOperator(ProductionSchedule.Fields.Start.PropertyName, DateTime.Parse(string.Format("{0} 9:00", scheduleDate.Value.ToShortDateString())), BinaryOperatorType.GreaterOrEqual), new BinaryOperator(ProductionSchedule.Fields.Finish.PropertyName, DateTime.Parse(string.Format("{0} 9:00", scheduleDate.Value.AddDays(1).ToShortDateString())), BinaryOperatorType.LessOrEqual)), new GroupOperator(GroupOperatorType.And, new BinaryOperator(ProductionSchedule.Fields.Start.PropertyName, DateTime.Parse(string.Format("{0} 9:00", scheduleDate.Value.ToShortDateString())), BinaryOperatorType.Less), new BinaryOperator(ProductionSchedule.Fields.Finish.PropertyName, DateTime.Parse(string.Format("{0} 9:00", scheduleDate.Value.ToShortDateString())), BinaryOperatorType.Greater)), new GroupOperator(GroupOperatorType.And, new BinaryOperator(ProductionSchedule.Fields.Start.PropertyName, DateTime.Parse(string.Format("{0} 9:00", scheduleDate.Value.AddDays(1).ToShortDateString())), BinaryOperatorType.Less), new BinaryOperator(ProductionSchedule.Fields.Finish.PropertyName, DateTime.Parse(string.Format("{0} 9:00", scheduleDate.Value.AddDays(1).ToShortDateString())), BinaryOperatorType.Greater)));
			}

		}

	}

}