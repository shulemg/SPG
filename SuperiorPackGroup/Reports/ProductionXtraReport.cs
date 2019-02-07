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
	public partial class ProductionXtraReport
	{

		public ProductionXtraReport()
		{
			InitializeComponent();
		}

		private long m_Minutes;
		private long m_BreakMinutes;
		private long m_TotalMinutes = 0;
		private float m_Expected;
		private float m_TotalExpected = 0;
		private float m_TotalDifference = 0;
		private float m_TotalActualSpeed = 0;
		private double m_TotalPayroll = 0;
		private Production m_CurrentProduction;
		private int m_MinPerHour;
		private double m_MachineStandard;
		private double m_MachinePackers;

		private void totalHoursDetailXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (totalHoursDetailXrLabel.Visible)
			{
				totalHoursDetailXrLabel.Text = string.Format("{0}:{1}", ((m_Minutes - m_BreakMinutes) / 60).ToString("0"), (((m_Minutes - m_BreakMinutes) % 60) / 1).ToString("00"));
			}

		}

		private void totalMinutesDetailXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (totalMinutesDetailXrLabel.Visible)
			{
				totalMinutesDetailXrLabel.Text = (((m_Minutes - m_BreakMinutes) / 60.0) * m_MinPerHour).ToString("#.##");
			}

		}

		private void expectedDetailXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (expectedDetailXrLabel.Visible)
			{
				//= Convert.ToSingle(((m_Minutes - m_BreakMinutes) / 60)  * Convert.ToSingle(Me.GetCurrentColumnValue("ItemProdStandard")))
				if (m_MachineStandard == 0)
				{
					m_Expected = Convert.ToSingle(GetCurrentColumnValue("ItemProdStandard")) * Convert.ToInt32((m_Minutes - m_BreakMinutes) / (double)60 * m_MinPerHour) / Convert.ToInt32(GetCurrentColumnValue("intQtyPerUnit"));
				}
				else
				{
					m_Expected = (float)(m_MachineStandard * Convert.ToInt32((m_Minutes - m_BreakMinutes) / (double)60 * m_MinPerHour) / Convert.ToInt32(GetCurrentColumnValue("intQtyPerUnit")));
				}

					expectedDetailXrLabel.Text = m_Expected.ToString("#.##");
				m_TotalExpected += m_Expected;
			}

		}

		private void differenceDetailXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (differenceDetailXrLabel.Visible)
			{
				float difference = Convert.ToSingle(Convert.ToSingle(this.GetCurrentColumnValue("ProdMainQuantity")) - m_Expected);

				differenceDetailXrLabel.Text = difference.ToString("#.##");
				m_TotalDifference += difference;
			}

		}

		private void actualSpeedDetailXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (actualSpeedDetailXrLabel.Visible)
			{
				float actualSpeed = ((Convert.ToSingle(this.GetCurrentColumnValue("ProdMainQuantity")) * Convert.ToSingle(this.GetCurrentColumnValue("intQtyPerUnit"))) / Convert.ToInt32(((m_Minutes - m_BreakMinutes) / 60.0) * m_MinPerHour));

				if (float.IsInfinity(actualSpeed) || float.IsNaN(actualSpeed))
				{

				}
				else
				{
					actualSpeedDetailXrLabel.Text = actualSpeed.ToString("#.##");
					m_TotalActualSpeed += actualSpeed;
				}
			}

		}

		private void Detail_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			m_Minutes = DateHelper.DateDiff(DateHelper.DateInterval.Minute, Convert.ToDateTime(this.GetCurrentColumnValue("ProdMainTimeStart")), Convert.ToDateTime(this.GetCurrentColumnValue("ProdMainTimeStop")));
			m_BreakMinutes = BreakTimeBLL.GetBreakMinutes(Convert.ToDateTime(GetCurrentColumnValue("ProdMainDate")), Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStart")), Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStop")));
			m_TotalMinutes += m_Minutes - m_BreakMinutes;

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
						m_MinPerHour =  MainXtraForm.MinPerHOur;
					}
					if (MachineStandard.ProductionPerMinute > 0)
					{
						m_MachineStandard = MachineStandard.ProductionPerMinute;
					}
					else
					{
						m_MachineStandard = 0;
					}
					if (MachineStandard.ProjectedPackers > 0)
					{
						m_MachinePackers = MachineStandard.ProjectedPackers;
					}
					else
					{
						m_MachinePackers = 0;
					}
				}
				else
				{
					if (m_CurrentProduction.ProdMainItemID.MinutesPerShift > 0)
					{
						m_MinPerHour = Convert.ToInt32(m_CurrentProduction.ProdMainItemID.MinutesPerShift / 7.1667);
					}
					else
					{
						m_MinPerHour =  MainXtraForm.MinPerHOur;
					}
					m_MachineStandard = 0;
					m_MachinePackers = 0;
				}
			}
			else
			{
				m_MinPerHour =  MainXtraForm.MinPerHOur;
				m_MachineStandard = 0;
				m_MachinePackers = 0;
			}

		}

		private void totalPayrollDetailXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (totalPayrollDetailXrLabel.Visible)
			{
				double totalPayroll = Convert.ToDouble(GetCurrentColumnValue("ProdMainPackers")) * (m_Minutes - m_BreakMinutes) / 60 *  MainXtraForm.PackersPay;
				this.totalPayrollDetailXrLabel.Text = totalPayroll.ToString("$0.00");
				m_TotalPayroll += totalPayroll;
			}

		}

		private void totalHoursFooterXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (totalHoursFooterXrLabel.Visible)
			{
				totalHoursFooterXrLabel.Text = string.Format("{0}:{1}", m_TotalMinutes / 60, (m_TotalMinutes % 60) / 1);
			}

		}

		private void expectedFooterXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (expectedFooterXrLabel.Visible)
			{
				expectedFooterXrLabel.Text = m_TotalExpected.ToString("#,#");
			}

		}

		private void differenceFooterXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (differenceFooterXrLabel.Visible)
			{
				differenceFooterXrLabel.Text = m_TotalDifference.ToString("#,#");
			}

		}

		private void actualSpeedFooterXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (actualSpeedFooterXrLabel.Visible)
			{
				actualSpeedFooterXrLabel.Text = (m_TotalActualSpeed / m_TotalMinutes).ToString("0.00");
			}

		}

		private void totalPayrollFooterXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (totalPayrollFooterXrLabel.Visible)
			{
				totalPayrollFooterXrLabel.Text = m_TotalPayroll.ToString("$#,##0.00");
			}

		}

		private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			m_Minutes = 0;
			m_TotalMinutes = 0;
			m_TotalExpected = 0;
			m_TotalDifference = 0;
			m_TotalActualSpeed = 0;
			m_TotalPayroll = 0;

		}

		private void uomDetailXrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (m_CurrentProduction != null)
			{
				uomDetailXrLabel.Text = m_CurrentProduction.ProdMainItemID.strUnitOfMeasure;
			}

		}

		private void machineSpeedDetailXrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (m_MachineStandard == 0)
			{
				if (m_CurrentProduction != null)
				{
					machineSpeedDetailXrLabel.Text = Convert.ToString(m_CurrentProduction.ProdMainItemID.ItemProdStandard);
				}
			}
			else
			{
				machineSpeedDetailXrLabel.Text = m_MachineStandard.ToString();
			}

		}

		private void projectedPackersDetailXrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (m_MachinePackers == 0)
			{
				if (m_CurrentProduction != null)
				{
					projectedPackersDetailXrLabel.Text = Convert.ToString(m_CurrentProduction.ProdMainItemID.Packers);
				}
			}
			else
			{
				projectedPackersDetailXrLabel.Text = m_MachinePackers.ToString();
			}

		}

		private void reasonCodeDetailXrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (m_CurrentProduction != null)
			{
				reasonCodeDetailXrLabel.Text = m_CurrentProduction.Reasons;
			}

		}

	}
}