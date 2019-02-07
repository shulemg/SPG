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
	public partial class CostingXtraReport
	{

		public CostingXtraReport()
		{
			InitializeComponent();
		}

		private double m_CurrentCost;
		private double m_CurrentPayrollTotal;
		private double m_CurrentQuantity;
		private double m_CurrentTotalPrice;
		private double m_IntervalHours;
		private double m_IntervalHoursMinusBreak;
		private long m_TimeDiffStartToStop;
		private long m_BreakMinutes;
		private int m_MinPerHour = 50;
		private float m_OperatorsPay = 1;
		private float m_SupersPay = 1;
		private float m_PackersPay = 1;
		private int m_Minutes;
		private int m_Totalminutestotal;
		private double m_TotalPayrolltotal = -0.0;
		private double m_TotalCosttotal = -0.0;
		private double m_TotalProfitTotal = 0.0;
		private double m_TotalCostPerPiecetotal = -0.0;
		private double m_TotalPriceTotal = 0.0;
		private int m_TotalQtyProducedTotal = 0;
		private double m_TotalOtherAmountTotal = 0;
		private double m_Expected;
		private double m_TotalExpected;
		private double m_MachineStandard = 0;
		private double m_MachinePackers = 0;
		private Production m_CurrentProduction;

		private void totalMinutesDetailXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			int minOnJob = 0;
			try
			{
				minOnJob = Convert.ToInt32(m_IntervalHoursMinusBreak * m_MinPerHour);
			}
			catch (Exception ex)
			{

			}
			finally
			{
				totalMinutesDetailXrLabel.Text = minOnJob.ToString("#.##");
				m_Totalminutestotal += minOnJob;
			}

		}

		private void actualSpeedDetailXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			try
			{
				actualSpeedDetailXrLabel.Text = (Convert.ToDouble(GetCurrentColumnValue("ActualSpeed")) / Convert.ToInt32((m_IntervalHoursMinusBreak * m_MinPerHour))).ToString("0.00");
			}
			catch (Exception ex)
			{
				actualSpeedDetailXrLabel.Text = null;
			}

		}

		private void CostingXtraReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			m_MinPerHour = MainXtraForm.MinPerHOur;
			m_PackersPay = MainXtraForm.PackersPay;
			m_OperatorsPay = MainXtraForm.OperatorsPay;
			m_SupersPay = MainXtraForm.SupersPay;

		}

		private void payrollDetailXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			try
			{
				m_TotalPayrolltotal += m_CurrentPayrollTotal * -1;
				payrollDetailXrLabel.Text = (m_CurrentPayrollTotal * -1).ToString("$#,##0.00");
			}
			catch (Exception ex)
			{
				payrollDetailXrLabel.Text = "$0.00";
			}

		}

		private void costDetailXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			try
			{
				costDetailXrLabel.Text = m_CurrentCost.ToString("$#,##0.00");
				m_TotalCosttotal += m_CurrentCost;
			}
			catch (Exception ex)
			{

			}

		}

		private void profitDetailXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			try
			{
				double currentAbsoluteCost = Math.Abs(m_CurrentCost);

				profitDetailXrLabel.Text = (m_CurrentTotalPrice - currentAbsoluteCost).ToString("$#,##0.00");
				m_TotalProfitTotal += m_CurrentTotalPrice - currentAbsoluteCost;
			}
			catch (Exception ex)
			{

			}

		}

		private void costPerPieceDetailXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			try
			{
				costPerPieceDetailXrLabel.Text = (Math.Abs(m_CurrentCost / m_CurrentQuantity * -1)).ToString("$#,##0.00");
				m_TotalCostPerPiecetotal += Math.Abs(m_CurrentCost / m_CurrentQuantity * -1);
				m_TotalQtyProducedTotal += Convert.ToInt32(m_CurrentQuantity);
			}
			catch (Exception ex)
			{

			}

		}

		private void packsPerMinuteDetailXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			int interval = Convert.ToInt32(m_IntervalHoursMinusBreak * m_MinPerHour);
			packsPerMinuteDetailXrLabel.Text = (m_CurrentQuantity / interval).ToString("0.00");

		}

		private void salesVsPayrollDetailXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			try
			{
				salesVsPayrollDetailXrLabel.Text = (m_CurrentPayrollTotal / m_CurrentTotalPrice).ToString("$#,##0.00");
			}
			catch (Exception ex)
			{

			}

		}

		private void salesVsCostDetailXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			try
			{
				salesVsCostDetailXrLabel.Text = (Math.Abs(m_CurrentCost) / m_CurrentTotalPrice).ToString("$#,##0.00");
			}
			catch (Exception ex)
			{

			}

		}

		private void profitVsSalesDetailXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			try
			{
				profitVsSalesDetailXrLabel.Text = (m_CurrentTotalPrice / (m_CurrentTotalPrice - Math.Abs(m_CurrentCost))).ToString("$#,##0.00");
			}
			catch (Exception ex)
			{

			}

		}

		private void totalMinutesFooterXRLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			this.totalMinutesFooterXRLabel.Text = m_Totalminutestotal.ToString();

		}

		private void payrollFooterXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			payrollFooterXrLabel.Text = m_TotalPayrolltotal.ToString("$#,##0.00");

		}

		private void costFooterXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			costFooterXrLabel.Text = m_TotalCosttotal.ToString("$#,##0.00");

		}

		private void profitFooterXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			profitFooterXrLabel.Text = m_TotalProfitTotal.ToString("$#,##0.00");

		}

		private void costPerPieceFooterXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			try
			{
				costPerPieceFooterXrLabel.Text = ((Math.Abs(m_TotalCosttotal) / m_TotalQtyProducedTotal) * -1).ToString("$#,##0.00");
			}
			catch (Exception ex)
			{

			}

		}

		private void packsPerMinuteFooterXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			try
			{
				packsPerMinuteFooterXrLabel.Text = (m_TotalQtyProducedTotal / (double)m_Totalminutestotal).ToString("0.00");
			}
			catch (Exception ex)
			{

			}

		}

		private void salesVsPayrollFooterXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			try
			{
				salesVsPayrollFooterXrLabel.Text = (m_TotalPayrolltotal / m_TotalPriceTotal).ToString("$#,##0.00");
			}
			catch (Exception ex)
			{

			}

		}


		private void salesVsCostFooterXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			try
			{
				salesVsCostFooterXrLabel.Text = (m_TotalCosttotal / m_TotalPriceTotal).ToString("$#,##0.00");
			}
			catch (Exception ex)
			{

			}

		}

		private void profitVsSalesFooterXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			try
			{
				profitVsSalesFooterXrLabel.Text = (m_TotalPriceTotal / m_TotalProfitTotal).ToString("$#,##0.00");
			}
			catch (Exception ex)
			{

			}

		}

		private void totalOtherDetailXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			double totalOtherAmount = 0;

			if (!Convert.IsDBNull(GetCurrentColumnValue("Other1")))
			{
				totalOtherAmount += Convert.ToDouble(GetCurrentColumnValue("Other1"));
			}
			if (!Convert.IsDBNull(GetCurrentColumnValue("Other2")))
			{
				totalOtherAmount += Convert.ToDouble(GetCurrentColumnValue("Other2"));
			}
			if (!Convert.IsDBNull(GetCurrentColumnValue("Other3")))
			{
				totalOtherAmount += Convert.ToDouble(GetCurrentColumnValue("Other3"));
			}
			if (!Convert.IsDBNull(GetCurrentColumnValue("Other4")))
			{
				totalOtherAmount += Convert.ToDouble(GetCurrentColumnValue("Other4"));
			}
			if (!Convert.IsDBNull(GetCurrentColumnValue("Other5")))
			{
				totalOtherAmount += Convert.ToDouble(GetCurrentColumnValue("Other5"));
			}

			totalOtherDetailXrLabel.Text = totalOtherAmount.ToString("$#,##0.00");
			m_TotalOtherAmountTotal += totalOtherAmount;

		}

		private void totalOtherFooterXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			totalOtherFooterXrLabel.Text = m_TotalOtherAmountTotal.ToString("$#,##0.00");

		}

		private void salesVsProfitDetailXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			try
			{
				salesVsProfitDetailXrLabel.Text = ((m_CurrentTotalPrice - Math.Abs(m_CurrentCost)) / m_CurrentTotalPrice).ToString("$#,##0.00");
			}
			catch (Exception ex)
			{

			}

		}

		private void salesVsProfitFooterXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			try
			{
				salesVsProfitFooterXrLabel.Text = (m_TotalProfitTotal / m_TotalPriceTotal).ToString("$#,##0.00");
			}
			catch (Exception ex)
			{

			}

		}

		private void differenceFooterXRLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			try
			{
				differenceFooterXRLabel.Text = (m_TotalExpected - Convert.ToDouble(this.quantityFooterXRLabel.Summary.GetResult())).ToString("#,#");
			}
			catch (Exception ex)
			{

			}

		}

		private void actualSpeedFooterXRLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			try
			{
				actualSpeedFooterXRLabel.Text = (Convert.ToDouble(this.actualSpeedSummary.Summary.GetResult()) / m_Totalminutestotal).ToString("0.00");
			}
			catch (Exception ex)
			{

			}

		}

		private void Detail_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			m_TimeDiffStartToStop = DateHelper.DateDiff(DateHelper.DateInterval.Minute, Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStart")), Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStop")));
			m_BreakMinutes = BreakTimeBLL.GetBreakMinutes(Convert.ToDateTime(GetCurrentColumnValue("ProdMainDate")), Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStart")), Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStop")));
			m_IntervalHours = m_TimeDiffStartToStop / 60.0;
			m_IntervalHoursMinusBreak = (m_TimeDiffStartToStop - m_BreakMinutes) / 60.0;
			m_CurrentPayrollTotal = Convert.ToDouble(Convert.IsDBNull(GetCurrentColumnValue("ProdMainOperators")) ? 0 : GetCurrentColumnValue("ProdMainOperators")) * m_IntervalHoursMinusBreak * m_OperatorsPay + Convert.ToDouble(Convert.IsDBNull(GetCurrentColumnValue("ProdMainPackers")) ? 0 : GetCurrentColumnValue("ProdMainPackers")) * m_IntervalHoursMinusBreak * m_PackersPay + Convert.ToDouble(Convert.IsDBNull(GetCurrentColumnValue("ProdMainSupers")) ? 0 : GetCurrentColumnValue("ProdMainSupers")) * m_IntervalHoursMinusBreak * m_SupersPay;
			m_CurrentCost = (m_CurrentPayrollTotal + Convert.ToDouble(GetCurrentColumnValue("Freight")) + Convert.ToDouble(GetCurrentColumnValue("Film")) + Convert.ToDouble(GetCurrentColumnValue("Boxes")) + Convert.ToDouble(GetCurrentColumnValue("StretchWrap")) + Convert.ToDouble(GetCurrentColumnValue("Pallets")) + Convert.ToDouble(GetCurrentColumnValue("Other1")) + Convert.ToDouble(GetCurrentColumnValue("Other2")) + Convert.ToDouble(GetCurrentColumnValue("Other3")) + Convert.ToDouble(GetCurrentColumnValue("Other4")) + Convert.ToDouble(GetCurrentColumnValue("Other5"))) * -1 + Convert.ToDouble(GetCurrentColumnValue("Rebate"));
			m_CurrentQuantity = Convert.ToDouble(GetCurrentColumnValue("ProdMainQuantity"));
			m_CurrentTotalPrice = Convert.ToDouble(GetCurrentColumnValue("TotalPrice"));

			m_TotalPriceTotal += m_CurrentTotalPrice;

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
						m_MinPerHour = MainXtraForm.MinPerHOur;
					}
					m_MachineStandard = 0;
					m_MachinePackers = 0;
				}
			}
			else
			{
				m_MinPerHour = MainXtraForm.MinPerHOur;
				m_MachineStandard = 0;
				m_MachinePackers = 0;
			}

		}

		private void totalHoursDetailXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			totalHoursDetailXrLabel.Text = string.Format("{0}:{1}", ((m_TimeDiffStartToStop - m_BreakMinutes) / 60).ToString("0"), (((m_TimeDiffStartToStop - m_BreakMinutes) % 60) / 1).ToString("00"));

		}

		private void totalMinutesHeaderXRLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

		   // totalMinutesHeaderXRLabel.Text = String.Format("Total Minutes ({0}/Hour)", m_MinPerHour)

		}

		private void totalHoursFooterXRLabel_SummaryReset(System.Object sender, EventArgs e)
		{

			m_Minutes = 0;

		}

		private void totalHoursFooterXRLabel_SummaryRowChanged(System.Object sender, EventArgs e)
		{

			//This runs before Detail_BeforePrint
			m_Minutes += Convert.ToInt32(DateHelper.DateDiff(DateHelper.DateInterval.Minute, Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStart")), Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStop"))) - (BreakTimeBLL.GetBreakMinutes(Convert.ToDateTime(GetCurrentColumnValue("ProdMainDate")), Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStart")), Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStop")))));

		}

		private void totalHoursFooterXRLabel_SummaryGetResult(System.Object sender, DevExpress.XtraReports.UI.SummaryGetResultEventArgs e)
		{

			e.Result = string.Format("{0}:{1}", m_Minutes / 60, (m_Minutes % 60) / 1);
			e.Handled = true;

		}

		private void expectedDetailXrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			//= m_IntervalHoursMinusBreak * Convert.ToDouble(GetCurrentColumnValue("ExpectedProduction"))
			if (m_MachineStandard == 0)
			{
				m_Expected = Convert.ToDouble(GetCurrentColumnValue("ExpectedProduction")) * Convert.ToInt32(m_IntervalHoursMinusBreak * m_MinPerHour) / ItemsBLL.GetQuantityPerUnit(Convert.ToInt32(GetCurrentColumnValue("ProdMainItemID")));
			}
			else
			{
				m_Expected = m_MachineStandard * Convert.ToInt32(m_IntervalHoursMinusBreak * m_MinPerHour) / ItemsBLL.GetQuantityPerUnit(Convert.ToInt32(GetCurrentColumnValue("ProdMainItemID")));
			}

			expectedDetailXrLabel.Text = m_Expected.ToString("#,#");
			m_TotalExpected += m_Expected;

		}

		private void differenceDetailXrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			differenceDetailXrLabel.Text = (m_CurrentQuantity - m_Expected).ToString("#,#");

		}

		private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			m_Totalminutestotal = 0;
			m_TotalPayrolltotal = -0.0;
			m_TotalCosttotal = -0.0;
			m_TotalProfitTotal = 0.0;
			m_TotalCostPerPiecetotal = -0.0;
			m_TotalPriceTotal = 0.0;
			m_TotalQtyProducedTotal = 0;
			m_TotalOtherAmountTotal = 0;
			m_TotalExpected = 0;

		}

		private void expectedFooterXRLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			expectedFooterXRLabel.Text = m_TotalExpected.ToString("#,#");

		}

	}
}