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
	public partial class ProductionShiftXtraReport
	{

		public ProductionShiftXtraReport()
		{
			InitializeComponent();
		}

		private double m_IntervalHours;
		private int m_ShiftMinutes;
		private double m_ShiftHours;
		private double m_ItemHours;
		private int m_ItemMinutes;
		private double m_IntervalHoursMinusBreak;
		private int m_MinPerHour;
		private long m_TimeDiffStartToStop;
		private long m_BreakMinutes;
		private double m_ShiftAverageSpeed;
		private double m_ItemAverageSpeed;
		private double m_PackersPay;
		private double m_CurrentPayrollTotal;
		private double m_ShiftAveragePackers;
		private double m_ItemAveragePackers;
		private double m_ShiftPayroll;
		private double m_ItemPayroll;
		private double m_ShiftProjectedCost;
		private double m_ItemProjectedCost;
		private double m_ShiftAverageCost;
		private double m_ItemAverageCost;
		private double m_CustomerQuantity;
		private double m_CustomerProjectedQuantity;
		private double m_CompanyQuantity = 0;
		private double m_CompanyProjectedQuantity = 0;
		private double m_CustomerPackersCost;
		private double m_CustomerProjectedPackersCost;
		private double m_CompanyPackersCost = 0;
		private double m_CompanyProjectedPackersCost = 0;
		private double m_CustomerCost;
		private double m_CustomerProjectedCost;
		private double m_CompanyCost = 0;
		private double m_CompanyProjectedCost = 0;
		private double m_MachineStandard = 0;
		private double m_MachinePackers = 0;
		private Production m_CurrentProduction;

		private void ReportHeader_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			m_CompanyQuantity = 0;
			m_CompanyProjectedQuantity = 0;
			m_CompanyPackersCost = 0;
			m_CompanyProjectedPackersCost = 0;
			m_CompanyCost = 0;
			m_CompanyProjectedCost = 0;

		}

		private void ShiftGroupHeader_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			m_ShiftMinutes = 0;
			m_ShiftHours = 0;
			m_ShiftAverageSpeed = 0;
			m_ShiftAveragePackers = 0;
			m_ShiftPayroll = 0;
			m_ShiftProjectedCost = 0;
			m_ShiftAverageCost = 0;

		}

		private void itemGroupHeader_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			m_ItemMinutes = 0;
			m_ItemHours = 0;
			m_ItemAverageSpeed = 0;
			m_ItemAveragePackers = 0;
			m_ItemPayroll = 0;
			m_ItemProjectedCost = 0;
			m_ItemAverageCost = 0;

		}

		private void customerGroupHeader_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			m_CustomerQuantity = 0;
			m_CustomerProjectedQuantity = 0;
			m_CustomerPackersCost = 0;
			m_CustomerProjectedPackersCost = 0;
			m_CustomerCost = 0;
			m_CustomerProjectedCost = 0;

		}

		private void Detail_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			m_CurrentProduction = DevExpress.Xpo.XpoDefault.Session.GetObjectByKey<Production>(Convert.ToInt32(GetCurrentColumnValue("ProductionID")));

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
				m_MinPerHour = 
                    MainXtraForm.MinPerHOur;
				m_MachineStandard = 0;
				m_MachinePackers = 0;
			}

			m_TimeDiffStartToStop = DateHelper.DateDiff(DateHelper.DateInterval.Minute, Convert.ToDateTime(GetCurrentColumnValue("TimeStart")), Convert.ToDateTime(GetCurrentColumnValue("TimeStop")));
			m_BreakMinutes = BreakTimeBLL.GetBreakMinutes(Convert.ToDateTime(GetCurrentColumnValue("ProductionDate")), Convert.ToDateTime(GetCurrentColumnValue("TimeStart")), Convert.ToDateTime(GetCurrentColumnValue("TimeStop")));
			m_IntervalHoursMinusBreak = (m_TimeDiffStartToStop - m_BreakMinutes) / 60.0;
			m_IntervalHours = m_TimeDiffStartToStop / 60.0;
			m_CurrentPayrollTotal = Convert.ToDouble(Convert.IsDBNull(GetCurrentColumnValue("ProductionPackers")) ? 0 : GetCurrentColumnValue("ProductionPackers")) * m_IntervalHoursMinusBreak * m_PackersPay;

			m_ShiftMinutes += Convert.ToInt32(m_IntervalHoursMinusBreak * m_MinPerHour);
			m_ShiftHours += m_IntervalHours;
			m_ShiftPayroll += m_CurrentPayrollTotal;

			if (Convert.ToDouble(GetCurrentColumnValue("ProjectedPackers")) > 0 || m_MachinePackers > 0)
			{
				m_CustomerPackersCost += Convert.ToDouble(Convert.IsDBNull(GetCurrentColumnValue("ProductionPackers")) ? 0 : GetCurrentColumnValue("ProductionPackers")) * m_IntervalHoursMinusBreak * m_PackersPay;
				m_CompanyPackersCost += Convert.ToDouble(Convert.IsDBNull(GetCurrentColumnValue("ProductionPackers")) ? 0 : GetCurrentColumnValue("ProductionPackers")) * m_IntervalHoursMinusBreak * m_PackersPay;
			}

			if (Convert.ToDouble(GetCurrentColumnValue("ProjectedPackers")) > 0 || m_MachinePackers > 0)
			{
				if (m_MachineStandard > 0)
				{
					m_CustomerCost += (Convert.ToDouble(Convert.IsDBNull(GetCurrentColumnValue("ProductionPackers")) ? 0 : GetCurrentColumnValue("ProductionPackers")) * m_IntervalHoursMinusBreak * m_PackersPay) / Convert.ToDouble(Convert.IsDBNull(GetCurrentColumnValue("Quantity")) ? 0 : GetCurrentColumnValue("Quantity"));
					m_CompanyCost += (Convert.ToDouble(Convert.IsDBNull(GetCurrentColumnValue("ProductionPackers")) ? 0 : GetCurrentColumnValue("ProductionPackers")) * m_IntervalHoursMinusBreak * m_PackersPay) / Convert.ToDouble(Convert.IsDBNull(GetCurrentColumnValue("Quantity")) ? 0 : GetCurrentColumnValue("Quantity"));
					if (m_MachinePackers == 0)
					{
						m_CustomerProjectedCost += (Convert.ToDouble(GetCurrentColumnValue("ProjectedPackers")) * m_IntervalHoursMinusBreak * m_PackersPay) / ((m_MachineStandard / Convert.ToDouble(GetCurrentColumnValue("QtyPerUnit"))) * Convert.ToInt32(m_IntervalHoursMinusBreak * m_MinPerHour));
						m_CompanyProjectedCost += (Convert.ToDouble(GetCurrentColumnValue("ProjectedPackers")) * m_IntervalHoursMinusBreak * m_PackersPay) / ((m_MachineStandard / Convert.ToDouble(GetCurrentColumnValue("QtyPerUnit"))) * Convert.ToInt32(m_IntervalHoursMinusBreak * m_MinPerHour));
					}
					else
					{
						m_CustomerProjectedCost += (m_MachinePackers * m_IntervalHoursMinusBreak * m_PackersPay) / ((m_MachineStandard / Convert.ToDouble(GetCurrentColumnValue("QtyPerUnit"))) * Convert.ToInt32(m_IntervalHoursMinusBreak * m_MinPerHour));
						m_CompanyProjectedCost += (m_MachinePackers * m_IntervalHoursMinusBreak * m_PackersPay) / ((m_MachineStandard / Convert.ToDouble(GetCurrentColumnValue("QtyPerUnit"))) * Convert.ToInt32(m_IntervalHoursMinusBreak * m_MinPerHour));
					}
				}
				else if (Convert.ToDouble(GetCurrentColumnValue("ProjectedSpeed")) > 0)
				{
					m_CustomerCost += (Convert.ToDouble(Convert.IsDBNull(GetCurrentColumnValue("ProductionPackers")) ? 0 : GetCurrentColumnValue("ProductionPackers")) * m_IntervalHoursMinusBreak * m_PackersPay) / Convert.ToDouble(Convert.IsDBNull(GetCurrentColumnValue("Quantity")) ? 0 : GetCurrentColumnValue("Quantity"));
					m_CompanyCost += (Convert.ToDouble(Convert.IsDBNull(GetCurrentColumnValue("ProductionPackers")) ? 0 : GetCurrentColumnValue("ProductionPackers")) * m_IntervalHoursMinusBreak * m_PackersPay) / Convert.ToDouble(Convert.IsDBNull(GetCurrentColumnValue("Quantity")) ? 0 : GetCurrentColumnValue("Quantity"));
					if (m_MachinePackers == 0)
					{
						m_CustomerProjectedCost += (Convert.ToDouble(GetCurrentColumnValue("ProjectedPackers")) * m_IntervalHoursMinusBreak * m_PackersPay) / ((Convert.ToDouble(GetCurrentColumnValue("ProjectedSpeed")) / Convert.ToDouble(GetCurrentColumnValue("QtyPerUnit"))) * Convert.ToInt32(m_IntervalHoursMinusBreak * m_MinPerHour));
						m_CompanyProjectedCost += (Convert.ToDouble(GetCurrentColumnValue("ProjectedPackers")) * m_IntervalHoursMinusBreak * m_PackersPay) / ((Convert.ToDouble(GetCurrentColumnValue("ProjectedSpeed")) / Convert.ToDouble(GetCurrentColumnValue("QtyPerUnit"))) * Convert.ToInt32(m_IntervalHoursMinusBreak * m_MinPerHour));
					}
					else
					{
						m_CustomerProjectedCost += (m_MachinePackers * m_IntervalHoursMinusBreak * m_PackersPay) / ((Convert.ToDouble(GetCurrentColumnValue("ProjectedSpeed")) / Convert.ToDouble(GetCurrentColumnValue("QtyPerUnit"))) * Convert.ToInt32(m_IntervalHoursMinusBreak * m_MinPerHour));
						m_CompanyProjectedCost += (m_MachinePackers * m_IntervalHoursMinusBreak * m_PackersPay) / ((Convert.ToDouble(GetCurrentColumnValue("ProjectedSpeed")) / Convert.ToDouble(GetCurrentColumnValue("QtyPerUnit"))) * Convert.ToInt32(m_IntervalHoursMinusBreak * m_MinPerHour));
					}
				}
			}

		}

		private void ProductionShiftXtraReport_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			//m_MinPerHour = If(MainXtraForm.MinPerHOur <> 0, MainXtraForm.MinPerHOur, 50)
			m_PackersPay = (MainXtraForm.PackersPay != 0) ? MainXtraForm.PackersPay : 1;

		}

		private void ShiftTotalMinutesXRLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			shiftTotalMinutesXRLabel.Text = m_ShiftMinutes.ToString("#.##");
			m_ItemMinutes += m_ShiftMinutes;
			m_ItemHours += m_ShiftHours;

		}

		private void itemMinutesXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			itemMinutesXrLabel.Text = m_ItemMinutes.ToString("#.##");

		}

		private void ShiftAverageSpeedXRLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			m_ShiftAverageSpeed = Convert.ToDouble(shiftQuantityXrLabel.Summary.GetResult()) * Convert.ToDouble(GetCurrentColumnValue("QtyPerUnit")) / m_ShiftMinutes;
			shiftAverageSpeedXRLabel.Text = m_ShiftAverageSpeed.ToString("#,##0.00");

		}

		private void itemAverageSpeedXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			m_ItemAverageSpeed = Convert.ToDouble(itemQuantityXrLabel.Summary.GetResult()) * Convert.ToDouble(GetCurrentColumnValue("QtyPerUnit")) / m_ItemMinutes;
			itemAverageSpeedXrLabel.Text = m_ItemAverageSpeed.ToString("#,##0.00");

		}

		private void ShiftSpeedVariationVolumeXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (m_MachineStandard > 0)
			{
				shiftSpeedVariationVolumeXrLabel.Text = (m_ShiftAverageSpeed - m_MachineStandard).ToString("#,##0.00");
			}
			else
			{
				shiftSpeedVariationVolumeXrLabel.Text = (m_ShiftAverageSpeed - Convert.ToDouble(GetCurrentColumnValue("ProjectedSpeed"))).ToString("#,##0.00");
			}

		}

		private void itemSpeedVariationXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (m_MachineStandard > 0)
			{
				itemSpeedVariationXrLabel.Text = (m_ItemAverageSpeed - m_MachineStandard).ToString("#,##0.00");
			}
			else
			{
				itemSpeedVariationXrLabel.Text = (m_ItemAverageSpeed - Convert.ToDouble(GetCurrentColumnValue("ProjectedSpeed"))).ToString("#,##0.00");
			}

		}

		private void itemSpeedVariationPercentageXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			m_ItemAverageSpeed = Convert.ToDouble(itemQuantityXrLabel.Summary.GetResult()) * Convert.ToDouble(GetCurrentColumnValue("QtyPerUnit")) / m_ItemMinutes;
			double speedVariation = 0;
			if (m_MachineStandard > 0)
			{
				speedVariation = (m_ItemAverageSpeed - m_MachineStandard) / m_MachineStandard;
			}
			else
			{
				speedVariation = (m_ItemAverageSpeed - Convert.ToDouble(GetCurrentColumnValue("ProjectedSpeed"))) / Convert.ToDouble(GetCurrentColumnValue("ProjectedSpeed"));
			}

			if (double.IsNaN(speedVariation) | double.IsInfinity(speedVariation))
			{
				speedVariation = 0;
			}
			else
			{
				if (m_MachineStandard > 0)
				{
					m_CustomerProjectedQuantity += (m_MachineStandard / Convert.ToDouble(GetCurrentColumnValue("QtyPerUnit"))) * m_ItemMinutes;
					m_CompanyProjectedQuantity += (m_MachineStandard / Convert.ToDouble(GetCurrentColumnValue("QtyPerUnit"))) * m_ItemMinutes;
				}
				else
				{
					m_CustomerProjectedQuantity += (Convert.ToDouble(GetCurrentColumnValue("ProjectedSpeed")) / Convert.ToDouble(GetCurrentColumnValue("QtyPerUnit"))) * m_ItemMinutes;
					m_CompanyProjectedQuantity += (Convert.ToDouble(GetCurrentColumnValue("ProjectedSpeed")) / Convert.ToDouble(GetCurrentColumnValue("QtyPerUnit"))) * m_ItemMinutes;
				}

				m_CustomerQuantity += Convert.ToDouble(itemQuantityXrLabel.Summary.GetResult());
				m_CompanyQuantity += Convert.ToDouble(itemQuantityXrLabel.Summary.GetResult());
			}
			itemSpeedVariationPercentageXrLabel.Text = speedVariation.ToString("%0.00");

		}

		private void ShiftSpeedVariationPercentageXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			double speedVariation = 0;
			if (m_MachineStandard > 0)
			{
				speedVariation = (m_ShiftAverageSpeed - m_MachineStandard) / m_MachineStandard;
			}
			else
			{
				speedVariation = (m_ShiftAverageSpeed - Convert.ToDouble(GetCurrentColumnValue("ProjectedSpeed"))) / Convert.ToDouble(GetCurrentColumnValue("ProjectedSpeed"));
			}

			if (double.IsNaN(speedVariation) | double.IsInfinity(speedVariation))
			{
				speedVariation = 0;
			}
			shiftSpeedVariationPercentageXrLabel.Text = speedVariation.ToString("%0.00");

		}

		private void customerSpeedVariationPercentageXrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			customerSpeedVariationPercentageXrLabel.Text = ((m_CustomerQuantity - m_CustomerProjectedQuantity) / m_CustomerProjectedQuantity).ToString("%0.00");

		}


		private void companySpeedVariationPercentageXrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			reportSpeedVariationPercentageXrLabel.Text = ((m_CompanyQuantity - m_CompanyProjectedQuantity) / m_CompanyProjectedQuantity).ToString("%0.00");

		}

		private void ShiftAverageActualPackersXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			m_ItemPayroll += m_ShiftPayroll;
			m_ShiftAveragePackers = (m_ShiftPayroll / m_PackersPay) / m_ShiftHours;
			shiftAverageActualPackersXrLabel.Text = m_ShiftAveragePackers.ToString("#,##0.00");

		}

		private void ShiftPackersVariationVolumeXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (m_MachinePackers == 0)
			{
				shiftPackersVariationVolumeXrLabel.Text = (m_ShiftAveragePackers - Convert.ToDouble(GetCurrentColumnValue("ProjectedPackers"))).ToString("#,##0.00");
			}
			else
			{
				shiftPackersVariationVolumeXrLabel.Text = (m_ShiftAveragePackers - m_MachinePackers).ToString("#,##0.00");
			}

		}

		private void ShiftPackersVariationPercentageXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			double packersVariation = 0;
			if (m_MachinePackers == 0)
			{
				packersVariation = (m_ShiftAveragePackers - Convert.ToDouble(GetCurrentColumnValue("ProjectedPackers"))) / Convert.ToDouble(GetCurrentColumnValue("ProjectedPackers"));
			}
			else
			{
				packersVariation = (m_ShiftAveragePackers - m_MachinePackers) / m_MachinePackers;
			}
			if (double.IsNaN(packersVariation) | double.IsInfinity(packersVariation))
			{
				packersVariation = 0;
			}
			shiftPackersVariationPercentageXrLabel.Text = packersVariation.ToString("%0.00");

		}

		private void itemAverageActualPackersXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			m_ItemAveragePackers = (m_ItemPayroll / m_PackersPay) / m_ItemHours;
			itemAverageActualPackersXrLabel.Text = m_ItemAveragePackers.ToString("#,##0.00");

		}

		private void itemPackersVariationVolumeXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (m_MachinePackers == 0)
			{
				itemPackersVariationVolumeXrLabel.Text = (m_ItemAveragePackers - Convert.ToDouble(GetCurrentColumnValue("ProjectedPackers"))).ToString("#,##0.00");
			}
			else
			{
				itemPackersVariationVolumeXrLabel.Text = (m_ItemAveragePackers - m_MachinePackers).ToString("#,##0.00");
			}

		}

		private void itemPackersVariationPercentageXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			m_ItemAveragePackers = (m_ItemPayroll / m_PackersPay) / m_ItemHours;
			double packersVariation = 0;
			if (m_MachinePackers == 0)
			{
				packersVariation = (m_ItemAveragePackers - Convert.ToDouble(GetCurrentColumnValue("ProjectedPackers"))) / Convert.ToDouble(GetCurrentColumnValue("ProjectedPackers"));
			}
			else
			{
				packersVariation = (m_ItemAveragePackers - m_MachinePackers) / m_MachinePackers;
			}
			if (double.IsNaN(packersVariation) | double.IsInfinity(packersVariation))
			{
				packersVariation = 0;
			}
			else
			{
				if (m_MachinePackers == 0)
				{
					m_CustomerProjectedPackersCost += Convert.ToDouble(GetCurrentColumnValue("ProjectedPackers")) * m_ItemHours * m_PackersPay;
					m_CompanyProjectedPackersCost += Convert.ToDouble(GetCurrentColumnValue("ProjectedPackers")) * m_ItemHours * m_PackersPay;
				}
				else
				{
					m_CustomerProjectedPackersCost += m_MachinePackers * m_ItemHours * m_PackersPay;
					m_CompanyProjectedPackersCost += m_MachinePackers * m_ItemHours * m_PackersPay;
				}
			}
			itemPackersVariationPercentageXrLabel.Text = packersVariation.ToString("%0.00");

		}

		private void customerPackersVariationPercentageXrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			customerPackersVariationPercentageXrLabel.Text = ((m_CustomerPackersCost - m_CustomerProjectedPackersCost) / m_CustomerProjectedPackersCost).ToString("%0.00");

		}

		private void reportPackersVariationPercentageXrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			reportPackersVariationPercentageXrLabel.Text = ((m_CompanyPackersCost - m_CompanyProjectedPackersCost) / m_CompanyProjectedPackersCost).ToString("%0.00");

		}

		private void ShiftProjectedCostXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			//m_ShiftProjectedCost = CDbl(IIf(IsDBNull(GetCurrentColumnValue("ProjectedPackers")), 0, GetCurrentColumnValue("ProjectedPackers"))) * m_IntervalHours * m_PackersPay / _
			//                            (CDbl(ShiftQuantityXrLabel.Summary.GetResult()) * CDbl(GetCurrentColumnValue("QtyPerUnit")))
			if (m_MachineStandard > 0)
			{
				if (m_MachinePackers == 0)
				{
					m_ShiftProjectedCost = 8 * m_PackersPay * Convert.ToDouble(Convert.IsDBNull(GetCurrentColumnValue("ProjectedPackers")) ? 0 : GetCurrentColumnValue("ProjectedPackers")) / (m_MachineStandard * m_MinPerHour * 7);
				}
				else
				{
					m_ShiftProjectedCost = 8 * m_PackersPay * m_MachinePackers / (m_MachineStandard * m_MinPerHour * 7);
				}
			}
			else
			{
				if (m_MachinePackers == 0)
				{
					m_ShiftProjectedCost = 8 * m_PackersPay * Convert.ToDouble(Convert.IsDBNull(GetCurrentColumnValue("ProjectedPackers")) ? 0 : GetCurrentColumnValue("ProjectedPackers")) / (Convert.ToDouble(GetCurrentColumnValue("ProjectedSpeed")) * m_MinPerHour * 7);
				}
				else
				{
					m_ShiftProjectedCost = 8 * m_PackersPay * m_MachinePackers / (Convert.ToDouble(GetCurrentColumnValue("ProjectedSpeed")) * m_MinPerHour * 7);
				}
			}

			if (double.IsNaN(m_ShiftProjectedCost) | double.IsInfinity(m_ShiftProjectedCost))
			{
				m_ShiftProjectedCost = 0;
			}
			shiftProjectedCostXrLabel.Text = (m_ShiftProjectedCost * -1).ToString("$#,##0.0000");

		}

		private void ShiftAverageCostXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			m_ShiftAverageCost = m_ShiftPayroll / (Convert.ToDouble(shiftQuantityXrLabel.Summary.GetResult()) * Convert.ToDouble(GetCurrentColumnValue("QtyPerUnit")));
			shiftAverageCostXrLabel.Text = (m_ShiftAverageCost * -1).ToString("$#,##0.0000");

		}

		private void ShiftCostVariationXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			shiftCostVariationXrLabel.Text = (m_ShiftAverageCost - m_ShiftProjectedCost).ToString("$#,##0.0000");

		}

		private void ShiftCostVariationPercentageXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			double costVariation = (m_ShiftAverageCost - m_ShiftProjectedCost) / m_ShiftProjectedCost;
			if (double.IsNaN(costVariation) | double.IsInfinity(costVariation))
			{
				costVariation = 0;
			}
			shiftCostVariationPercentageXrLabel.Text = costVariation.ToString("%0.00");

		}

		private void itemProjectedCostXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			//m_ItemProjectedCost = CDbl(IIf(IsDBNull(GetCurrentColumnValue("ProjectedPackers")), 0, GetCurrentColumnValue("ProjectedPackers"))) * m_IntervalHours * m_PackersPay / _
			//                            (CDbl(itemQuantityXrLabel.Summary.GetResult()) * CDbl(GetCurrentColumnValue("QtyPerUnit")))
			if (m_MachineStandard > 0)
			{
				if (m_MachinePackers == 0)
				{
					m_ItemProjectedCost = 8 * m_PackersPay * Convert.ToDouble(Convert.IsDBNull(GetCurrentColumnValue("ProjectedPackers")) ? 0 : GetCurrentColumnValue("ProjectedPackers")) / (m_MachineStandard * m_MinPerHour * 7);
				}
				else
				{
					m_ItemProjectedCost = 8 * m_PackersPay * m_MachinePackers / (m_MachineStandard * m_MinPerHour * 7);
				}
			}
			else
			{
				if (m_MachinePackers == 0)
				{
					m_ItemProjectedCost = 8 * m_PackersPay * Convert.ToDouble(Convert.IsDBNull(GetCurrentColumnValue("ProjectedPackers")) ? 0 : GetCurrentColumnValue("ProjectedPackers")) / (Convert.ToDouble(GetCurrentColumnValue("ProjectedSpeed")) * m_MinPerHour * 7);
				}
				else
				{
					m_ItemProjectedCost = 8 * m_PackersPay * m_MachinePackers / (Convert.ToDouble(GetCurrentColumnValue("ProjectedSpeed")) * m_MinPerHour * 7);
				}
			}

			if (double.IsNaN(m_ItemProjectedCost) | double.IsInfinity(m_ItemProjectedCost))
			{
				m_ItemProjectedCost = 0;
			}
			itemProjectedCostXrLabel.Text = (m_ItemProjectedCost * -1).ToString("$#,##0.0000");

		}

		private void itemAverageCostXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			m_ItemAverageCost = m_ItemPayroll / (Convert.ToDouble(itemQuantityXrLabel.Summary.GetResult()) * Convert.ToDouble(GetCurrentColumnValue("QtyPerUnit")));
			itemAverageCostXrLabel.Text = (m_ItemAverageCost * -1).ToString("$#,##0.0000");

		}

		private void itemCostVariationXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (double.IsNaN(m_ItemProjectedCost) | double.IsInfinity(m_ItemProjectedCost))
			{
				m_ItemProjectedCost = 0;
			}
			itemCostVariationXrLabel.Text = (m_ItemAverageCost - m_ItemProjectedCost).ToString("$#,##0.0000");

		}

		private void itemCostVariationPercentageXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			m_ItemAverageCost = m_ItemPayroll / (Convert.ToDouble(itemQuantityXrLabel.Summary.GetResult()) * Convert.ToDouble(GetCurrentColumnValue("QtyPerUnit")));
			if (m_MachineStandard > 0)
			{
				if (m_MachinePackers == 0)
				{
					m_ItemProjectedCost = 8 * m_PackersPay * Convert.ToDouble(Convert.IsDBNull(GetCurrentColumnValue("ProjectedPackers")) ? 0 : GetCurrentColumnValue("ProjectedPackers")) / (m_MachineStandard * m_MinPerHour * 7);
				}
				else
				{
					m_ItemProjectedCost = 8 * m_PackersPay * m_MachinePackers / (m_MachineStandard * m_MinPerHour * 7);
				}
			}
			else
			{
				if (m_MachinePackers == 0)
				{
					m_ItemProjectedCost = 8 * m_PackersPay * Convert.ToDouble(Convert.IsDBNull(GetCurrentColumnValue("ProjectedPackers")) ? 0 : GetCurrentColumnValue("ProjectedPackers")) / (Convert.ToDouble(GetCurrentColumnValue("ProjectedSpeed")) * m_MinPerHour * 7);
				}
				else
				{
					m_ItemProjectedCost = 8 * m_PackersPay * m_MachinePackers / (Convert.ToDouble(GetCurrentColumnValue("ProjectedSpeed")) * m_MinPerHour * 7);
				}
			}

			double costVariation = (m_ItemAverageCost - m_ItemProjectedCost) / m_ItemProjectedCost;
			if (double.IsNaN(costVariation) | double.IsInfinity(costVariation))
			{
				costVariation = 0;
			}
			itemCostVariationPercentageXrLabel.Text = costVariation.ToString("%0.00");

		}

		private void customerCostVariationPercentageXrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			customerCostVariationPercentageXrLabel.Text = ((m_CustomerCost - m_CustomerProjectedCost) / m_CustomerProjectedCost).ToString("%0.00");

		}

		private void reportCostVariationPercentageXrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			reportCostVariationPercentageXrLabel.Text = ((m_CompanyCost - m_CompanyProjectedCost) / m_CompanyProjectedCost).ToString("%0.00");

		}

		private void ShiftSalesVsPayrollXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			shiftSalesVsPayrollXrLabel.Text = (Convert.ToDouble(GetCurrentColumnValue("pricePerPieceCalculatedField")) / m_ShiftAverageCost).ToString("#,##0.00");

		}

		private void itemSalesVsPayrollXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			m_ItemAverageCost = m_ItemPayroll / (Convert.ToDouble(itemQuantityXrLabel.Summary.GetResult()) * Convert.ToDouble(GetCurrentColumnValue("QtyPerUnit")));
			double salesVsPayroll = Convert.ToDouble(GetCurrentColumnValue("pricePerPieceCalculatedField")) / m_ItemAverageCost;
			if (double.IsNaN(salesVsPayroll) | double.IsInfinity(salesVsPayroll))
			{
				salesVsPayroll = 0;
			}
			itemSalesVsPayrollXrLabel.Text = salesVsPayroll.ToString("#,##0.00");

		}

		private void shiftProjectedSpeedXrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (m_MachineStandard > 0)
			{
				shiftProjectedSpeedXrLabel.Text = m_MachineStandard.ToString("#,##0.00");
			}
			else
			{
				shiftProjectedSpeedXrLabel.Text = Convert.ToDouble(GetCurrentColumnValue("ProjectedSpeed")).ToString("#,##0.00");
			}

		}

		private void itemProjectedSpeedXrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (m_MachineStandard > 0)
			{
				itemProjectedSpeedXrLabel.Text = m_MachineStandard.ToString("#,##0.00");
			}
			else
			{
				itemProjectedSpeedXrLabel.Text = Convert.ToDouble(GetCurrentColumnValue("ProjectedSpeed")).ToString("#,##0.00");
			}

		}

		private void itemProjectedPackersXrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (m_MachinePackers > 0)
			{
				itemProjectedPackersXrLabel.Text = m_MachinePackers.ToString("#,##0.00");
			}
			else
			{
				itemProjectedPackersXrLabel.Text = Convert.ToDouble(GetCurrentColumnValue("ProjectedPackers")).ToString("#,##0.00");
			}

		}

		private void shiftmachineProjectedPackersXrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (m_MachinePackers > 0)
			{
				shiftProjectedPackersXrLabel.Text = m_MachinePackers.ToString("#,##0.00");
			}
			else
			{
				shiftProjectedPackersXrLabel.Text = Convert.ToDouble(GetCurrentColumnValue("ProjectedPackers")).ToString("#,##0.00");
			}

		}

	}
}