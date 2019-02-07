//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using System.Linq;
using DevExpress;
using DXDAL.SPGData;

namespace SuperiorPackGroup
{
	public partial class ProductionSummaryXtraReport
	{

		public ProductionSummaryXtraReport()
		{
			InitializeComponent();
		}

		private long m_BreakMinutes;
		private int m_Minutes;
		private long m_TimeDiffStartToStop;
		private int m_MinPerHour = 50;
		private Production m_CurrentProduction;

		private void ProductionSummaryXtraReport_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			//m_MinPerHour = My.Forms.MainXtraForm.MinPerHOur

		}

		private void totalMinutes_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			int hours = int.Parse(totalHours.Summary.GetResult().ToString().Substring(0, totalHours.Summary.GetResult().ToString().IndexOf(":"))) * 60;
			int minutes = int.Parse(totalHours.Summary.GetResult().ToString().Substring(totalHours.Summary.GetResult().ToString().IndexOf(":") + 1)) + hours;
			totalMinutes.Text = (((minutes - m_BreakMinutes) / 60.0) * m_MinPerHour).ToString();

		}

		private void averageActualSpeed_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			int hours = int.Parse(totalHours.Summary.GetResult().ToString().Substring(0, totalHours.Summary.GetResult().ToString().IndexOf(":"))) * 60;
			int minutes = int.Parse(totalHours.Summary.GetResult().ToString().Substring(totalHours.Summary.GetResult().ToString().IndexOf(":") + 1)) + hours;
			averageActualSpeed.Text = (Convert.ToDouble(AverageActualSpeedH.Summary.GetResult()) / Convert.ToInt32((((minutes - m_BreakMinutes) / 60.0) * m_MinPerHour))).ToString("0.00");

		}

		private void totalPacksPerMin_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			int hours = int.Parse(totalHours.Summary.GetResult().ToString().Substring(0, totalHours.Summary.GetResult().ToString().IndexOf(":"))) * 60;
			double minutes = ((int.Parse(totalHours.Summary.GetResult().ToString().Substring(totalHours.Summary.GetResult().ToString().IndexOf(":") + 1)) + hours) / 60.0) * m_MinPerHour;
			totalPacksPerMin.Text = (Convert.ToDouble(totalQtyProduced.Summary.GetResult()) / (minutes - m_BreakMinutes)).ToString("0.00");

		}

		private void totalMinutesLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			totalMinutesLabel.Text = string.Format("Total Minutes ({0}/Hour)", m_MinPerHour);

		}

		private void totalHours_SummaryGetResult(System.Object sender, DevExpress.XtraReports.UI.SummaryGetResultEventArgs e)
		{

			e.Result = string.Format("{0}:{1}", m_Minutes / 60, (m_Minutes % 60) / 1);
			e.Handled = true;

		}

		private void totalHours_SummaryReset(System.Object sender, EventArgs e)
		{

			m_Minutes = 0;

		}

		private void totalHours_SummaryRowChanged(System.Object sender, EventArgs e)
		{

			m_Minutes += Convert.ToInt32(DateHelper.DateDiff(DateHelper.DateInterval.Minute, Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStart")), Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStop"))) - (BreakTimeBLL.GetBreakMinutes(Convert.ToDateTime(GetCurrentColumnValue("ProdMainDate")), Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStart")), Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStop")))));

		}

		private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			m_TimeDiffStartToStop = DateHelper.DateDiff(DateHelper.DateInterval.Minute, Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStart")), Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStop")));
			m_BreakMinutes = BreakTimeBLL.GetBreakMinutes(Convert.ToDateTime(GetCurrentColumnValue("ProdMainDate")), Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStart")), Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStop")));

			m_CurrentProduction = DevExpress.Xpo.XpoDefault.Session.GetObjectByKey<Production>(Convert.ToInt32(GetCurrentColumnValue("ProdMainID")));

			ItemMachineStandards MachineStandard = null;
			if (m_CurrentProduction != null)
			{
				MachineStandard = m_CurrentProduction.ProdMainItemID.MachineStandards.Where((IMS) => IMS.Machine.MachineLineID == m_CurrentProduction.ProdMainMachineLine.MachineLineID).FirstOrDefault();
				if (MachineStandard != null)
				{
					if (MachineStandard.MinutesPerShift > 0)
					{
						m_MinPerHour = Convert.ToInt32(MachineStandard.MinutesPerShift / 7.16667);
					}
					else if (m_CurrentProduction.ProdMainItemID.MinutesPerShift > 0)
					{
						m_MinPerHour = Convert.ToInt32(m_CurrentProduction.ProdMainItemID.MinutesPerShift / 7.1667);
					}
					else
					{
						m_MinPerHour = MainXtraForm.MinPerHOur;
					}
				}
				else if (m_CurrentProduction.ProdMainItemID.MinutesPerShift > 0)
				{
					m_MinPerHour = Convert.ToInt32(m_CurrentProduction.ProdMainItemID.MinutesPerShift / 7.1667);
				}
				else
				{
					m_MinPerHour = MainXtraForm.MinPerHOur;
				}
			}
			else
			{
				m_MinPerHour = MainXtraForm.MinPerHOur;
			}

		}

	}
}