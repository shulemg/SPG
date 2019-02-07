using System.Linq;
using DevExpress;
using DXDAL.SPGData;

//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace SuperiorPackGroup
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class CostingXtraReport : DevExpress.XtraReports.UI.XtraReport
	{
		//XtraReport overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		//Required by the Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Designer
		//It can be modified using the Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			DevExpress.XtraReports.UI.XRSummary XrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary6 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary7 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary8 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary9 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary10 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary11 = new DevExpress.XtraReports.UI.XRSummary();
			this.Style1 = new DevExpress.XtraReports.UI.XRControlStyle();
			this.Style2 = new DevExpress.XtraReports.UI.XRControlStyle();
			this.Style3 = new DevExpress.XtraReports.UI.XRControlStyle();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.salesVsProfitDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.profitVsSalesDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.salesVsCostDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.salesVsPayrollDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.packsPerMinuteDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.costPerPieceDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.profitDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.costDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.totalOtherDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.palletsDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.stretchWrapDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.boxesDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.filmDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.freightDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.rebateDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.payrollDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.priceDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.superDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.packerDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.operatorDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.actualSpeedDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.speedDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.machineLineDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.differenceDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.expectedDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.quantityDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.totalMinutesDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.totalHoursDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.stopTimeDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.startTimeDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemDescriptionDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemCodeDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.lotDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.customerNameDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.shiftDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.dateDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
			this.headerXrPanel = new DevExpress.XtraReports.UI.XRPanel();
			this.profitVsSalesHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.salesVsCostHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.salesVsProfitHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.salesVsPayrollHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.packsPerMinuteHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.costPerPieceHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.profitHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.costHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.totalOtherHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.palletsHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.stretchWrapHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.boxesHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.filmHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.freightHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.rebateHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.payrollHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.priceHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.superHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.packerHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.operatorHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.actualSpeedHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.speedHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.machineLineHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.differenceHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.expectedHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.quantityHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.totalMinutesHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.totalHoursHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.stopTimeHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.startTimeHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemDescriptionHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemCodeHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.lotHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.customerNameHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.shiftHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.dateHeaderXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.printDateXRPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
			this.reportCriteriaXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.reportTitleXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
			this.footerXrPanel = new DevExpress.XtraReports.UI.XRPanel();
			this.salesVsProfitFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.profitVsSalesFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.salesVsCostFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.salesVsPayrollFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.packsPerMinuteFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.costPerPieceFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.profitFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.costFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.totalOtherFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.palletsFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.stretchWrapFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.boxesFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.filmFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.freightFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.rebateFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.payrollFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.priceFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.actualSpeedSummary = new DevExpress.XtraReports.UI.XRLabel();
			this.actualSpeedFooterXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.differenceFooterXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.expectedFooterXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.quantityFooterXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.totalMinutesFooterXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.totalHoursFooterXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.headerXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.footerXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.detailOddXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.detailEvenXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
			this.pageNumberXrPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
			this.TopMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
			((System.ComponentModel.ISupportInitialize)this).BeginInit();
			//
			//Style1
			//
			this.Style1.BackColor = System.Drawing.Color.LightGray;
			this.Style1.BorderColor = System.Drawing.Color.FromArgb((int)((byte)176), (int)((byte)187), (int)((byte)169));
			this.Style1.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.Style1.BorderWidth = 1;
			this.Style1.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.Style1.ForeColor = System.Drawing.Color.Black;
			this.Style1.Name = "Style1";
			//
			//Style2
			//
			this.Style2.BackColor = System.Drawing.Color.Transparent;
			this.Style2.BorderColor = System.Drawing.Color.FromArgb((int)((byte)196), (int)((byte)207), (int)((byte)189));
			this.Style2.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.Style2.BorderWidth = 1;
			this.Style2.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.Style2.ForeColor = System.Drawing.Color.Black;
			this.Style2.Name = "Style2";
			//
			//Style3
			//
			this.Style3.BackColor = System.Drawing.Color.FromArgb((int)((byte)210), (int)((byte)215), (int)((byte)227));
			this.Style3.BorderColor = System.Drawing.Color.FromArgb((int)((byte)174), (int)((byte)182), (int)((byte)193));
			this.Style3.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.Style3.BorderWidth = 1;
			this.Style3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
			this.Style3.ForeColor = System.Drawing.Color.Black;
			this.Style3.Name = "Style3";
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.salesVsProfitDetailXrLabel, this.profitVsSalesDetailXrLabel, this.salesVsCostDetailXrLabel, this.salesVsPayrollDetailXrLabel, this.packsPerMinuteDetailXrLabel, this.costPerPieceDetailXrLabel, this.profitDetailXrLabel, this.costDetailXrLabel, this.totalOtherDetailXrLabel, this.palletsDetailXrLabel, this.stretchWrapDetailXrLabel, this.boxesDetailXrLabel, this.filmDetailXrLabel, this.freightDetailXrLabel, this.rebateDetailXrLabel, this.payrollDetailXrLabel, this.priceDetailXrLabel, this.superDetailXrLabel, this.packerDetailXrLabel, this.operatorDetailXrLabel, this.actualSpeedDetailXrLabel, this.speedDetailXrLabel, this.machineLineDetailXrLabel, this.differenceDetailXrLabel, this.expectedDetailXrLabel, this.quantityDetailXrLabel, this.totalMinutesDetailXrLabel, this.totalHoursDetailXrLabel, this.stopTimeDetailXrLabel, this.startTimeDetailXrLabel, this.itemDescriptionDetailXrLabel, this.itemCodeDetailXrLabel, this.lotDetailXrLabel, this.customerNameDetailXrLabel, this.shiftDetailXrLabel, this.dateDetailXrLabel});
			this.Detail.EvenStyleName = "Style2";
			this.Detail.HeightF = 50.0F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.OddStyleName = "Style1";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//salesVsProfitDetailXrLabel
			//
			this.salesVsProfitDetailXrLabel.CanGrow = false;
			this.salesVsProfitDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.salesVsProfitDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(2958.0F, 0.0F);
			this.salesVsProfitDetailXrLabel.Name = "salesVsProfitDetailXrLabel";
			this.salesVsProfitDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.salesVsProfitDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.salesVsProfitDetailXrLabel.SizeF = new System.Drawing.SizeF(76.0F, 50.0F);
			this.salesVsProfitDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.salesVsProfitDetailXrLabel.Text = "Sales vs. Profit";
			this.salesVsProfitDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//profitVsSalesDetailXrLabel
			//
			this.profitVsSalesDetailXrLabel.CanGrow = false;
			this.profitVsSalesDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.profitVsSalesDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(2883.0F, 0.0F);
			this.profitVsSalesDetailXrLabel.Name = "profitVsSalesDetailXrLabel";
			this.profitVsSalesDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.profitVsSalesDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.profitVsSalesDetailXrLabel.SizeF = new System.Drawing.SizeF(75.0F, 50.0F);
			this.profitVsSalesDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.profitVsSalesDetailXrLabel.Text = "Profit vs. Sales";
			this.profitVsSalesDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//salesVsCostDetailXrLabel
			//
			this.salesVsCostDetailXrLabel.CanGrow = false;
			this.salesVsCostDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.salesVsCostDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(2808.0F, 0.0F);
			this.salesVsCostDetailXrLabel.Name = "salesVsCostDetailXrLabel";
			this.salesVsCostDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.salesVsCostDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.salesVsCostDetailXrLabel.SizeF = new System.Drawing.SizeF(75.0F, 50.0F);
			this.salesVsCostDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.salesVsCostDetailXrLabel.Text = "Sales vs. Cost";
			this.salesVsCostDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//salesVsPayrollDetailXrLabel
			//
			this.salesVsPayrollDetailXrLabel.CanGrow = false;
			this.salesVsPayrollDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.salesVsPayrollDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(2729.0F, 0.0F);
			this.salesVsPayrollDetailXrLabel.Name = "salesVsPayrollDetailXrLabel";
			this.salesVsPayrollDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.salesVsPayrollDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.salesVsPayrollDetailXrLabel.SizeF = new System.Drawing.SizeF(79.0F, 50.0F);
			this.salesVsPayrollDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.salesVsPayrollDetailXrLabel.Text = "Sales vs. Payroll";
			this.salesVsPayrollDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//packsPerMinuteDetailXrLabel
			//
			this.packsPerMinuteDetailXrLabel.CanGrow = false;
			this.packsPerMinuteDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.packsPerMinuteDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(2654.0F, 0.0F);
			this.packsPerMinuteDetailXrLabel.Name = "packsPerMinuteDetailXrLabel";
			this.packsPerMinuteDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.packsPerMinuteDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.packsPerMinuteDetailXrLabel.SizeF = new System.Drawing.SizeF(75.0F, 50.0F);
			this.packsPerMinuteDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.packsPerMinuteDetailXrLabel.Text = "Packs Per Minute";
			this.packsPerMinuteDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//costPerPieceDetailXrLabel
			//
			this.costPerPieceDetailXrLabel.CanGrow = false;
			this.costPerPieceDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.costPerPieceDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(2579.0F, 0.0F);
			this.costPerPieceDetailXrLabel.Name = "costPerPieceDetailXrLabel";
			this.costPerPieceDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.costPerPieceDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.costPerPieceDetailXrLabel.SizeF = new System.Drawing.SizeF(75.0F, 50.0F);
			this.costPerPieceDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.costPerPieceDetailXrLabel.Text = "Cost Per Piece";
			this.costPerPieceDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//profitDetailXrLabel
			//
			this.profitDetailXrLabel.CanGrow = false;
			this.profitDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.profitDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(2479.0F, 0.0F);
			this.profitDetailXrLabel.Name = "profitDetailXrLabel";
			this.profitDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.profitDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.profitDetailXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 50.0F);
			this.profitDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.profitDetailXrLabel.Text = "Profit";
			this.profitDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//costDetailXrLabel
			//
			this.costDetailXrLabel.CanGrow = false;
			this.costDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.costDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(2379.0F, 0.0F);
			this.costDetailXrLabel.Name = "costDetailXrLabel";
			this.costDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.costDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.costDetailXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 50.0F);
			this.costDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.costDetailXrLabel.Text = "Cost";
			this.costDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//totalOtherDetailXrLabel
			//
			this.totalOtherDetailXrLabel.CanGrow = false;
			this.totalOtherDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.totalOtherDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(2279.0F, 0.0F);
			this.totalOtherDetailXrLabel.Name = "totalOtherDetailXrLabel";
			this.totalOtherDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.totalOtherDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.totalOtherDetailXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 50.0F);
			this.totalOtherDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.totalOtherDetailXrLabel.Text = "Total Other";
			this.totalOtherDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//palletsDetailXrLabel
			//
			this.palletsDetailXrLabel.CanGrow = false;
			this.palletsDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.palletsDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(2179.0F, 0.0F);
			this.palletsDetailXrLabel.Name = "palletsDetailXrLabel";
			this.palletsDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.palletsDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.palletsDetailXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 50.0F);
			this.palletsDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.palletsDetailXrLabel.Text = "Pallets";
			this.palletsDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//stretchWrapDetailXrLabel
			//
			this.stretchWrapDetailXrLabel.CanGrow = false;
			this.stretchWrapDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.stretchWrapDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(2079.0F, 0.0F);
			this.stretchWrapDetailXrLabel.Name = "stretchWrapDetailXrLabel";
			this.stretchWrapDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.stretchWrapDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.stretchWrapDetailXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 50.0F);
			this.stretchWrapDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.stretchWrapDetailXrLabel.Text = "Sretch Wrap";
			this.stretchWrapDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//boxesDetailXrLabel
			//
			this.boxesDetailXrLabel.CanGrow = false;
			this.boxesDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.boxesDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1979.0F, 0.0F);
			this.boxesDetailXrLabel.Name = "boxesDetailXrLabel";
			this.boxesDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.boxesDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.boxesDetailXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 50.0F);
			this.boxesDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.boxesDetailXrLabel.Text = "Boxes";
			this.boxesDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//filmDetailXrLabel
			//
			this.filmDetailXrLabel.CanGrow = false;
			this.filmDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.filmDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1879.0F, 0.0F);
			this.filmDetailXrLabel.Name = "filmDetailXrLabel";
			this.filmDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.filmDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.filmDetailXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 50.0F);
			this.filmDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.filmDetailXrLabel.Text = "Film";
			this.filmDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//freightDetailXrLabel
			//
			this.freightDetailXrLabel.CanGrow = false;
			this.freightDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.freightDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1779.0F, 0.0F);
			this.freightDetailXrLabel.Name = "freightDetailXrLabel";
			this.freightDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.freightDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.freightDetailXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 50.0F);
			this.freightDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.freightDetailXrLabel.Text = "Freight";
			this.freightDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//rebateDetailXrLabel
			//
			this.rebateDetailXrLabel.CanGrow = false;
			this.rebateDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.rebateDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1679.0F, 0.0F);
			this.rebateDetailXrLabel.Name = "rebateDetailXrLabel";
			this.rebateDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.rebateDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.rebateDetailXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 50.0F);
			this.rebateDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.rebateDetailXrLabel.Text = "Rebate";
			this.rebateDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//payrollDetailXrLabel
			//
			this.payrollDetailXrLabel.CanGrow = false;
			this.payrollDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.payrollDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1579.0F, 0.0F);
			this.payrollDetailXrLabel.Name = "payrollDetailXrLabel";
			this.payrollDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.payrollDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.payrollDetailXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 50.0F);
			this.payrollDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.payrollDetailXrLabel.Text = "Payroll";
			this.payrollDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//priceDetailXrLabel
			//
			this.priceDetailXrLabel.CanGrow = false;
			this.priceDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.priceDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1479.0F, 0.0F);
			this.priceDetailXrLabel.Name = "priceDetailXrLabel";
			this.priceDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.priceDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.priceDetailXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 50.0F);
			this.priceDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.priceDetailXrLabel.Text = "Price";
			this.priceDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//superDetailXrLabel
			//
			this.superDetailXrLabel.CanGrow = false;
			this.superDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.superDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1430.0F, 0.0F);
			this.superDetailXrLabel.Name = "superDetailXrLabel";
			this.superDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.superDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.superDetailXrLabel.SizeF = new System.Drawing.SizeF(49.0F, 50.0F);
			this.superDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.superDetailXrLabel.Text = "Super";
			this.superDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//packerDetailXrLabel
			//
			this.packerDetailXrLabel.CanGrow = false;
			this.packerDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.packerDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1373.0F, 0.0F);
			this.packerDetailXrLabel.Name = "packerDetailXrLabel";
			this.packerDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.packerDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.packerDetailXrLabel.SizeF = new System.Drawing.SizeF(57.0F, 50.0F);
			this.packerDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.packerDetailXrLabel.Text = "Packer";
			this.packerDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//operatorDetailXrLabel
			//
			this.operatorDetailXrLabel.CanGrow = false;
			this.operatorDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.operatorDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1307.0F, 0.0F);
			this.operatorDetailXrLabel.Name = "operatorDetailXrLabel";
			this.operatorDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.operatorDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.operatorDetailXrLabel.SizeF = new System.Drawing.SizeF(66.0F, 50.0F);
			this.operatorDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.operatorDetailXrLabel.Text = "Operator";
			this.operatorDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//actualSpeedDetailXrLabel
			//
			this.actualSpeedDetailXrLabel.CanGrow = false;
			this.actualSpeedDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.actualSpeedDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1250.0F, 0.0F);
			this.actualSpeedDetailXrLabel.Name = "actualSpeedDetailXrLabel";
			this.actualSpeedDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.actualSpeedDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.actualSpeedDetailXrLabel.SizeF = new System.Drawing.SizeF(57.0F, 50.0F);
			this.actualSpeedDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.actualSpeedDetailXrLabel.Text = "Actual Speed";
			this.actualSpeedDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//speedDetailXrLabel
			//
			this.speedDetailXrLabel.CanGrow = false;
			this.speedDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.speedDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1193.0F, 0.0F);
			this.speedDetailXrLabel.Name = "speedDetailXrLabel";
			this.speedDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.speedDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.speedDetailXrLabel.SizeF = new System.Drawing.SizeF(57.0F, 50.0F);
			this.speedDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.speedDetailXrLabel.Text = "Speed";
			this.speedDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//machineLineDetailXrLabel
			//
			this.machineLineDetailXrLabel.CanGrow = false;
			this.machineLineDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.machineLineDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1122.0F, 0.0F);
			this.machineLineDetailXrLabel.Name = "machineLineDetailXrLabel";
			this.machineLineDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.machineLineDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.machineLineDetailXrLabel.SizeF = new System.Drawing.SizeF(71.0F, 50.0F);
			this.machineLineDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.machineLineDetailXrLabel.Text = "Machine Line";
			this.machineLineDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//differenceDetailXrLabel
			//
			this.differenceDetailXrLabel.CanGrow = false;
			this.differenceDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.differenceDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1053.0F, 0.0F);
			this.differenceDetailXrLabel.Name = "differenceDetailXrLabel";
			this.differenceDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.differenceDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.differenceDetailXrLabel.SizeF = new System.Drawing.SizeF(69.0F, 50.0F);
			this.differenceDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.differenceDetailXrLabel.Text = "Difference";
			this.differenceDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//expectedDetailXrLabel
			//
			this.expectedDetailXrLabel.CanGrow = false;
			this.expectedDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.expectedDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1004.0F, 0.0F);
			this.expectedDetailXrLabel.Name = "expectedDetailXrLabel";
			this.expectedDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.expectedDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.expectedDetailXrLabel.SizeF = new System.Drawing.SizeF(49.0F, 50.0F);
			this.expectedDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.expectedDetailXrLabel.Text = "Expected";
			this.expectedDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//quantityDetailXrLabel
			//
			this.quantityDetailXrLabel.CanGrow = false;
			this.quantityDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.quantityDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(914.0F, 0.0F);
			this.quantityDetailXrLabel.Name = "quantityDetailXrLabel";
			this.quantityDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.quantityDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.quantityDetailXrLabel.SizeF = new System.Drawing.SizeF(90.0F, 50.0F);
			this.quantityDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.quantityDetailXrLabel.Text = "Quantity";
			this.quantityDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//totalMinutesDetailXrLabel
			//
			this.totalMinutesDetailXrLabel.CanGrow = false;
			this.totalMinutesDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.totalMinutesDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(855.0F, 0.0F);
			this.totalMinutesDetailXrLabel.Name = "totalMinutesDetailXrLabel";
			this.totalMinutesDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.totalMinutesDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.totalMinutesDetailXrLabel.SizeF = new System.Drawing.SizeF(59.0F, 50.0F);
			this.totalMinutesDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.totalMinutesDetailXrLabel.Text = "Total Minutes";
			this.totalMinutesDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//totalHoursDetailXrLabel
			//
			this.totalHoursDetailXrLabel.CanGrow = false;
			this.totalHoursDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.totalHoursDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(800.0F, 0.0F);
			this.totalHoursDetailXrLabel.Name = "totalHoursDetailXrLabel";
			this.totalHoursDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.totalHoursDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.totalHoursDetailXrLabel.SizeF = new System.Drawing.SizeF(55.0F, 50.0F);
			this.totalHoursDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.totalHoursDetailXrLabel.Text = "Total Hours";
			this.totalHoursDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//stopTimeDetailXrLabel
			//
			this.stopTimeDetailXrLabel.CanGrow = false;
			this.stopTimeDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.stopTimeDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(725.0F, 0.0F);
			this.stopTimeDetailXrLabel.Name = "stopTimeDetailXrLabel";
			this.stopTimeDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.stopTimeDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.stopTimeDetailXrLabel.SizeF = new System.Drawing.SizeF(74.0F, 50.0F);
			this.stopTimeDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.stopTimeDetailXrLabel.Text = "Stop Time";
			this.stopTimeDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//startTimeDetailXrLabel
			//
			this.startTimeDetailXrLabel.CanGrow = false;
			this.startTimeDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.startTimeDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(633.0F, 0.0F);
			this.startTimeDetailXrLabel.Name = "startTimeDetailXrLabel";
			this.startTimeDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.startTimeDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.startTimeDetailXrLabel.SizeF = new System.Drawing.SizeF(92.0F, 50.0F);
			this.startTimeDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.startTimeDetailXrLabel.Text = "Start Time";
			this.startTimeDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//itemDescriptionDetailXrLabel
			//
			this.itemDescriptionDetailXrLabel.CanGrow = false;
			this.itemDescriptionDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.itemDescriptionDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(451.0F, 0.0F);
			this.itemDescriptionDetailXrLabel.Name = "itemDescriptionDetailXrLabel";
			this.itemDescriptionDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.itemDescriptionDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemDescriptionDetailXrLabel.SizeF = new System.Drawing.SizeF(182.0F, 50.0F);
			this.itemDescriptionDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.itemDescriptionDetailXrLabel.Text = "Item Description";
			this.itemDescriptionDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//itemCodeDetailXrLabel
			//
			this.itemCodeDetailXrLabel.CanGrow = false;
			this.itemCodeDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.itemCodeDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(369.0F, 0.0F);
			this.itemCodeDetailXrLabel.Name = "itemCodeDetailXrLabel";
			this.itemCodeDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.itemCodeDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemCodeDetailXrLabel.SizeF = new System.Drawing.SizeF(82.0F, 50.0F);
			this.itemCodeDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.itemCodeDetailXrLabel.Text = "Item Code";
			this.itemCodeDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//lotDetailXrLabel
			//
			this.lotDetailXrLabel.CanGrow = false;
			this.lotDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.lotDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(321.0F, 0.0F);
			this.lotDetailXrLabel.Name = "lotDetailXrLabel";
			this.lotDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.lotDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.lotDetailXrLabel.SizeF = new System.Drawing.SizeF(48.0F, 50.0F);
			this.lotDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.lotDetailXrLabel.Text = "Lot";
			this.lotDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//customerNameDetailXrLabel
			//
			this.customerNameDetailXrLabel.CanGrow = false;
			this.customerNameDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.customerNameDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(195.0F, 0.0F);
			this.customerNameDetailXrLabel.Name = "customerNameDetailXrLabel";
			this.customerNameDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.customerNameDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.customerNameDetailXrLabel.SizeF = new System.Drawing.SizeF(126.0F, 50.0F);
			this.customerNameDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.customerNameDetailXrLabel.Text = "Customer Name";
			this.customerNameDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//shiftDetailXrLabel
			//
			this.shiftDetailXrLabel.CanGrow = false;
			this.shiftDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.shiftDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(125.0F, 0.0F);
			this.shiftDetailXrLabel.Name = "shiftDetailXrLabel";
			this.shiftDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.shiftDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.shiftDetailXrLabel.SizeF = new System.Drawing.SizeF(70.0F, 50.0F);
			this.shiftDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.shiftDetailXrLabel.Text = "Shift";
			this.shiftDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//dateDetailXrLabel
			//
			this.dateDetailXrLabel.CanGrow = false;
			this.dateDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.dateDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0.0F, 0.0F);
			this.dateDetailXrLabel.Name = "dateDetailXrLabel";
			this.dateDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.dateDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.dateDetailXrLabel.SizeF = new System.Drawing.SizeF(125.0F, 50.0F);
			this.dateDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.dateDetailXrLabel.Text = "Production Date";
			this.dateDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//PageHeader
			//
			this.PageHeader.BackColor = System.Drawing.Color.Transparent;
			this.PageHeader.BorderColor = System.Drawing.SystemColors.ControlText;
			this.PageHeader.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.PageHeader.BorderWidth = 1;
			this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.headerXrPanel});
			this.PageHeader.HeightF = 50.0F;
			this.PageHeader.Name = "PageHeader";
			this.PageHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//headerXrPanel
			//
			this.headerXrPanel.BorderColor = System.Drawing.Color.Black;
			this.headerXrPanel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.headerXrPanel.BorderWidth = 3;
			this.headerXrPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.profitVsSalesHeaderXRLabel, this.salesVsCostHeaderXRLabel, this.salesVsProfitHeaderXRLabel, this.salesVsPayrollHeaderXRLabel, this.packsPerMinuteHeaderXRLabel, this.costPerPieceHeaderXRLabel, this.profitHeaderXRLabel, this.costHeaderXRLabel, this.totalOtherHeaderXRLabel, this.palletsHeaderXRLabel, this.stretchWrapHeaderXRLabel, this.boxesHeaderXRLabel, this.filmHeaderXRLabel, this.freightHeaderXRLabel, this.rebateHeaderXRLabel, this.payrollHeaderXRLabel, this.priceHeaderXRLabel, this.superHeaderXRLabel, this.packerHeaderXRLabel, this.operatorHeaderXRLabel, this.actualSpeedHeaderXRLabel, this.speedHeaderXRLabel, this.machineLineHeaderXRLabel, this.differenceHeaderXRLabel, this.expectedHeaderXRLabel, this.quantityHeaderXRLabel, this.totalMinutesHeaderXRLabel, this.totalHoursHeaderXRLabel, this.stopTimeHeaderXRLabel, this.startTimeHeaderXRLabel, this.itemDescriptionHeaderXRLabel, this.itemCodeHeaderXRLabel, this.lotHeaderXRLabel, this.customerNameHeaderXRLabel, this.shiftHeaderXRLabel, this.dateHeaderXRLabel});
			this.headerXrPanel.LocationFloat = new DevExpress.Utils.PointFloat(0.0F, 0.0F);
			this.headerXrPanel.Name = "headerXrPanel";
			this.headerXrPanel.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.headerXrPanel.SizeF = new System.Drawing.SizeF(3035.0F, 50.0F);
			this.headerXrPanel.StylePriority.UseBorders = false;
			//
			//profitVsSalesHeaderXRLabel
			//
			this.profitVsSalesHeaderXRLabel.CanGrow = false;
			this.profitVsSalesHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(2883.0F, 0.0F);
			this.profitVsSalesHeaderXRLabel.Name = "profitVsSalesHeaderXRLabel";
			this.profitVsSalesHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.profitVsSalesHeaderXRLabel.SizeF = new System.Drawing.SizeF(75.0F, 50.0F);
			this.profitVsSalesHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.profitVsSalesHeaderXRLabel.Text = "Profit vs. Sales";
			this.profitVsSalesHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//salesVsCostHeaderXRLabel
			//
			this.salesVsCostHeaderXRLabel.CanGrow = false;
			this.salesVsCostHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(2808.0F, 0.0F);
			this.salesVsCostHeaderXRLabel.Name = "salesVsCostHeaderXRLabel";
			this.salesVsCostHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.salesVsCostHeaderXRLabel.SizeF = new System.Drawing.SizeF(75.0F, 50.0F);
			this.salesVsCostHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.salesVsCostHeaderXRLabel.Text = "Sales vs. Cost";
			this.salesVsCostHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//salesVsProfitHeaderXRLabel
			//
			this.salesVsProfitHeaderXRLabel.CanGrow = false;
			this.salesVsProfitHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(2958.0F, 0.0F);
			this.salesVsProfitHeaderXRLabel.Name = "salesVsProfitHeaderXRLabel";
			this.salesVsProfitHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.salesVsProfitHeaderXRLabel.SizeF = new System.Drawing.SizeF(76.0F, 50.0F);
			this.salesVsProfitHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.salesVsProfitHeaderXRLabel.Text = "Sales vs. Profit";
			this.salesVsProfitHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//salesVsPayrollHeaderXRLabel
			//
			this.salesVsPayrollHeaderXRLabel.CanGrow = false;
			this.salesVsPayrollHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(2729.0F, 0.0F);
			this.salesVsPayrollHeaderXRLabel.Name = "salesVsPayrollHeaderXRLabel";
			this.salesVsPayrollHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.salesVsPayrollHeaderXRLabel.SizeF = new System.Drawing.SizeF(79.0F, 50.0F);
			this.salesVsPayrollHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.salesVsPayrollHeaderXRLabel.Text = "Sales vs. Payroll";
			this.salesVsPayrollHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//packsPerMinuteHeaderXRLabel
			//
			this.packsPerMinuteHeaderXRLabel.CanGrow = false;
			this.packsPerMinuteHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(2654.0F, 0.0F);
			this.packsPerMinuteHeaderXRLabel.Name = "packsPerMinuteHeaderXRLabel";
			this.packsPerMinuteHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.packsPerMinuteHeaderXRLabel.SizeF = new System.Drawing.SizeF(75.0F, 50.0F);
			this.packsPerMinuteHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.packsPerMinuteHeaderXRLabel.Text = "Packs Per Minute";
			this.packsPerMinuteHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//costPerPieceHeaderXRLabel
			//
			this.costPerPieceHeaderXRLabel.CanGrow = false;
			this.costPerPieceHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(2579.0F, 0.0F);
			this.costPerPieceHeaderXRLabel.Name = "costPerPieceHeaderXRLabel";
			this.costPerPieceHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.costPerPieceHeaderXRLabel.SizeF = new System.Drawing.SizeF(75.0F, 50.0F);
			this.costPerPieceHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.costPerPieceHeaderXRLabel.Text = "Cost Per Piece";
			this.costPerPieceHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//profitHeaderXRLabel
			//
			this.profitHeaderXRLabel.CanGrow = false;
			this.profitHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(2479.0F, 0.0F);
			this.profitHeaderXRLabel.Name = "profitHeaderXRLabel";
			this.profitHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.profitHeaderXRLabel.SizeF = new System.Drawing.SizeF(100.0F, 50.0F);
			this.profitHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.profitHeaderXRLabel.Text = "Profit";
			this.profitHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//costHeaderXRLabel
			//
			this.costHeaderXRLabel.CanGrow = false;
			this.costHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(2379.0F, 0.0F);
			this.costHeaderXRLabel.Name = "costHeaderXRLabel";
			this.costHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.costHeaderXRLabel.SizeF = new System.Drawing.SizeF(100.0F, 50.0F);
			this.costHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.costHeaderXRLabel.Text = "Cost";
			this.costHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//totalOtherHeaderXRLabel
			//
			this.totalOtherHeaderXRLabel.CanGrow = false;
			this.totalOtherHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(2279.0F, 0.0F);
			this.totalOtherHeaderXRLabel.Name = "totalOtherHeaderXRLabel";
			this.totalOtherHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.totalOtherHeaderXRLabel.SizeF = new System.Drawing.SizeF(100.0F, 50.0F);
			this.totalOtherHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.totalOtherHeaderXRLabel.Text = "Total Other";
			this.totalOtherHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//palletsHeaderXRLabel
			//
			this.palletsHeaderXRLabel.CanGrow = false;
			this.palletsHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(2179.0F, 0.0F);
			this.palletsHeaderXRLabel.Name = "palletsHeaderXRLabel";
			this.palletsHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.palletsHeaderXRLabel.SizeF = new System.Drawing.SizeF(100.0F, 50.0F);
			this.palletsHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.palletsHeaderXRLabel.Text = "Pallets";
			this.palletsHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//stretchWrapHeaderXRLabel
			//
			this.stretchWrapHeaderXRLabel.CanGrow = false;
			this.stretchWrapHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(2079.0F, 0.0F);
			this.stretchWrapHeaderXRLabel.Name = "stretchWrapHeaderXRLabel";
			this.stretchWrapHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.stretchWrapHeaderXRLabel.SizeF = new System.Drawing.SizeF(100.0F, 50.0F);
			this.stretchWrapHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.stretchWrapHeaderXRLabel.Text = "Stretch Wrap";
			this.stretchWrapHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//boxesHeaderXRLabel
			//
			this.boxesHeaderXRLabel.CanGrow = false;
			this.boxesHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(1979.0F, 0.0F);
			this.boxesHeaderXRLabel.Name = "boxesHeaderXRLabel";
			this.boxesHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.boxesHeaderXRLabel.SizeF = new System.Drawing.SizeF(100.0F, 50.0F);
			this.boxesHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.boxesHeaderXRLabel.Text = "Boxes";
			this.boxesHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//filmHeaderXRLabel
			//
			this.filmHeaderXRLabel.CanGrow = false;
			this.filmHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(1879.0F, 0.0F);
			this.filmHeaderXRLabel.Name = "filmHeaderXRLabel";
			this.filmHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.filmHeaderXRLabel.SizeF = new System.Drawing.SizeF(100.0F, 50.0F);
			this.filmHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.filmHeaderXRLabel.Text = "Film";
			this.filmHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//freightHeaderXRLabel
			//
			this.freightHeaderXRLabel.CanGrow = false;
			this.freightHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(1779.0F, 0.0F);
			this.freightHeaderXRLabel.Name = "freightHeaderXRLabel";
			this.freightHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.freightHeaderXRLabel.SizeF = new System.Drawing.SizeF(100.0F, 50.0F);
			this.freightHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.freightHeaderXRLabel.Text = "Freight";
			this.freightHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//rebateHeaderXRLabel
			//
			this.rebateHeaderXRLabel.CanGrow = false;
			this.rebateHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(1679.0F, 0.0F);
			this.rebateHeaderXRLabel.Name = "rebateHeaderXRLabel";
			this.rebateHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.rebateHeaderXRLabel.SizeF = new System.Drawing.SizeF(100.0F, 50.0F);
			this.rebateHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.rebateHeaderXRLabel.Text = "Rebate";
			this.rebateHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//payrollHeaderXRLabel
			//
			this.payrollHeaderXRLabel.CanGrow = false;
			this.payrollHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(1579.0F, 0.0F);
			this.payrollHeaderXRLabel.Name = "payrollHeaderXRLabel";
			this.payrollHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.payrollHeaderXRLabel.SizeF = new System.Drawing.SizeF(100.0F, 50.0F);
			this.payrollHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.payrollHeaderXRLabel.Text = "Payroll";
			this.payrollHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//priceHeaderXRLabel
			//
			this.priceHeaderXRLabel.CanGrow = false;
			this.priceHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(1479.0F, 0.0F);
			this.priceHeaderXRLabel.Name = "priceHeaderXRLabel";
			this.priceHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.priceHeaderXRLabel.SizeF = new System.Drawing.SizeF(100.0F, 50.0F);
			this.priceHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.priceHeaderXRLabel.Text = "Price";
			this.priceHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//superHeaderXRLabel
			//
			this.superHeaderXRLabel.CanGrow = false;
			this.superHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(1430.0F, 0.0F);
			this.superHeaderXRLabel.Name = "superHeaderXRLabel";
			this.superHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.superHeaderXRLabel.SizeF = new System.Drawing.SizeF(49.0F, 50.0F);
			this.superHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.superHeaderXRLabel.Text = "Super";
			this.superHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//packerHeaderXRLabel
			//
			this.packerHeaderXRLabel.CanGrow = false;
			this.packerHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(1373.0F, 0.0F);
			this.packerHeaderXRLabel.Name = "packerHeaderXRLabel";
			this.packerHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.packerHeaderXRLabel.SizeF = new System.Drawing.SizeF(57.0F, 50.0F);
			this.packerHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.packerHeaderXRLabel.Text = "Packer";
			this.packerHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//operatorHeaderXRLabel
			//
			this.operatorHeaderXRLabel.CanGrow = false;
			this.operatorHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(1307.0F, 0.0F);
			this.operatorHeaderXRLabel.Name = "operatorHeaderXRLabel";
			this.operatorHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.operatorHeaderXRLabel.SizeF = new System.Drawing.SizeF(66.0F, 50.0F);
			this.operatorHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.operatorHeaderXRLabel.Text = "Operator";
			this.operatorHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//actualSpeedHeaderXRLabel
			//
			this.actualSpeedHeaderXRLabel.CanGrow = false;
			this.actualSpeedHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(1250.0F, 0.0F);
			this.actualSpeedHeaderXRLabel.Name = "actualSpeedHeaderXRLabel";
			this.actualSpeedHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.actualSpeedHeaderXRLabel.SizeF = new System.Drawing.SizeF(57.0F, 50.0F);
			this.actualSpeedHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.actualSpeedHeaderXRLabel.Text = "Actual Speed";
			this.actualSpeedHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//speedHeaderXRLabel
			//
			this.speedHeaderXRLabel.CanGrow = false;
			this.speedHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(1193.0F, 0.0F);
			this.speedHeaderXRLabel.Name = "speedHeaderXRLabel";
			this.speedHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.speedHeaderXRLabel.SizeF = new System.Drawing.SizeF(57.0F, 50.0F);
			this.speedHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.speedHeaderXRLabel.Text = "Speed";
			this.speedHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//machineLineHeaderXRLabel
			//
			this.machineLineHeaderXRLabel.CanGrow = false;
			this.machineLineHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(1122.0F, 0.0F);
			this.machineLineHeaderXRLabel.Name = "machineLineHeaderXRLabel";
			this.machineLineHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.machineLineHeaderXRLabel.SizeF = new System.Drawing.SizeF(71.0F, 50.0F);
			this.machineLineHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.machineLineHeaderXRLabel.Text = "Machine Line";
			this.machineLineHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//differenceHeaderXRLabel
			//
			this.differenceHeaderXRLabel.CanGrow = false;
			this.differenceHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(1053.0F, 0.0F);
			this.differenceHeaderXRLabel.Name = "differenceHeaderXRLabel";
			this.differenceHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.differenceHeaderXRLabel.SizeF = new System.Drawing.SizeF(69.0F, 50.0F);
			this.differenceHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.differenceHeaderXRLabel.Text = "Difference";
			this.differenceHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//expectedHeaderXRLabel
			//
			this.expectedHeaderXRLabel.CanGrow = false;
			this.expectedHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(1004.0F, 0.0F);
			this.expectedHeaderXRLabel.Name = "expectedHeaderXRLabel";
			this.expectedHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.expectedHeaderXRLabel.SizeF = new System.Drawing.SizeF(49.0F, 50.0F);
			this.expectedHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.expectedHeaderXRLabel.Text = "Expected";
			this.expectedHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//quantityHeaderXRLabel
			//
			this.quantityHeaderXRLabel.CanGrow = false;
			this.quantityHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(914.0F, 0.0F);
			this.quantityHeaderXRLabel.Name = "quantityHeaderXRLabel";
			this.quantityHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.quantityHeaderXRLabel.SizeF = new System.Drawing.SizeF(90.0F, 50.0F);
			this.quantityHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.quantityHeaderXRLabel.Text = "Quantity";
			this.quantityHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//totalMinutesHeaderXRLabel
			//
			this.totalMinutesHeaderXRLabel.CanGrow = false;
			this.totalMinutesHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(855.0F, 0.0F);
			this.totalMinutesHeaderXRLabel.Name = "totalMinutesHeaderXRLabel";
			this.totalMinutesHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.totalMinutesHeaderXRLabel.SizeF = new System.Drawing.SizeF(59.0F, 50.0F);
			this.totalMinutesHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.totalMinutesHeaderXRLabel.Text = "Total Minutes";
			this.totalMinutesHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//totalHoursHeaderXRLabel
			//
			this.totalHoursHeaderXRLabel.CanGrow = false;
			this.totalHoursHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(800.0F, 0.0F);
			this.totalHoursHeaderXRLabel.Name = "totalHoursHeaderXRLabel";
			this.totalHoursHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.totalHoursHeaderXRLabel.SizeF = new System.Drawing.SizeF(55.0F, 50.0F);
			this.totalHoursHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.totalHoursHeaderXRLabel.Text = "Total Hours";
			this.totalHoursHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//stopTimeHeaderXRLabel
			//
			this.stopTimeHeaderXRLabel.CanGrow = false;
			this.stopTimeHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(725.0F, 0.0F);
			this.stopTimeHeaderXRLabel.Name = "stopTimeHeaderXRLabel";
			this.stopTimeHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.stopTimeHeaderXRLabel.SizeF = new System.Drawing.SizeF(74.0F, 50.0F);
			this.stopTimeHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.stopTimeHeaderXRLabel.Text = "Stop Time";
			this.stopTimeHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//startTimeHeaderXRLabel
			//
			this.startTimeHeaderXRLabel.CanGrow = false;
			this.startTimeHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(633.0F, 0.0F);
			this.startTimeHeaderXRLabel.Name = "startTimeHeaderXRLabel";
			this.startTimeHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.startTimeHeaderXRLabel.SizeF = new System.Drawing.SizeF(92.0F, 50.0F);
			this.startTimeHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.startTimeHeaderXRLabel.Text = "Start Time";
			this.startTimeHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemDescriptionHeaderXRLabel
			//
			this.itemDescriptionHeaderXRLabel.CanGrow = false;
			this.itemDescriptionHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(451.0F, 0.0F);
			this.itemDescriptionHeaderXRLabel.Name = "itemDescriptionHeaderXRLabel";
			this.itemDescriptionHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemDescriptionHeaderXRLabel.SizeF = new System.Drawing.SizeF(182.0F, 50.0F);
			this.itemDescriptionHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.itemDescriptionHeaderXRLabel.Text = "Item Description";
			this.itemDescriptionHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemCodeHeaderXRLabel
			//
			this.itemCodeHeaderXRLabel.CanGrow = false;
			this.itemCodeHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(369.0F, 0.0F);
			this.itemCodeHeaderXRLabel.Name = "itemCodeHeaderXRLabel";
			this.itemCodeHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemCodeHeaderXRLabel.SizeF = new System.Drawing.SizeF(82.0F, 50.0F);
			this.itemCodeHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.itemCodeHeaderXRLabel.Text = "Item Code";
			this.itemCodeHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//lotHeaderXRLabel
			//
			this.lotHeaderXRLabel.CanGrow = false;
			this.lotHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(321.0F, 0.0F);
			this.lotHeaderXRLabel.Name = "lotHeaderXRLabel";
			this.lotHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.lotHeaderXRLabel.SizeF = new System.Drawing.SizeF(48.0F, 50.0F);
			this.lotHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.lotHeaderXRLabel.Text = "Lot";
			this.lotHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//customerNameHeaderXRLabel
			//
			this.customerNameHeaderXRLabel.CanGrow = false;
			this.customerNameHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(195.0F, 0.0F);
			this.customerNameHeaderXRLabel.Name = "customerNameHeaderXRLabel";
			this.customerNameHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.customerNameHeaderXRLabel.SizeF = new System.Drawing.SizeF(126.0F, 50.0F);
			this.customerNameHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.customerNameHeaderXRLabel.Text = "Customer Name";
			this.customerNameHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//shiftHeaderXRLabel
			//
			this.shiftHeaderXRLabel.CanGrow = false;
			this.shiftHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(125.0F, 0.0F);
			this.shiftHeaderXRLabel.Name = "shiftHeaderXRLabel";
			this.shiftHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.shiftHeaderXRLabel.SizeF = new System.Drawing.SizeF(70.0F, 50.0F);
			this.shiftHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.shiftHeaderXRLabel.Text = "Shift";
			this.shiftHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//dateHeaderXRLabel
			//
			this.dateHeaderXRLabel.CanGrow = false;
			this.dateHeaderXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(0.0F, 0.0F);
			this.dateHeaderXRLabel.Name = "dateHeaderXRLabel";
			this.dateHeaderXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.dateHeaderXRLabel.SizeF = new System.Drawing.SizeF(125.0F, 50.0F);
			this.dateHeaderXRLabel.StyleName = "headerXrControlStyle";
			this.dateHeaderXRLabel.Text = "Production Date";
			this.dateHeaderXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//ReportHeader
			//
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.printDateXRPageInfo, this.reportCriteriaXrLabel, this.reportTitleXRLabel});
			this.ReportHeader.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.ReportHeader.HeightF = 86.0F;
			this.ReportHeader.KeepTogether = true;
			this.ReportHeader.Name = "ReportHeader";
			this.ReportHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//printDateXRPageInfo
			//
			this.printDateXRPageInfo.LocationFloat = new DevExpress.Utils.PointFloat(2852.0F, 51.0F);
			this.printDateXRPageInfo.Name = "printDateXRPageInfo";
			this.printDateXRPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.printDateXRPageInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
			this.printDateXRPageInfo.SizeF = new System.Drawing.SizeF(183.0F, 35.0F);
			this.printDateXRPageInfo.StylePriority.UseTextAlignment = false;
			this.printDateXRPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//reportCriteriaXrLabel
			//
			this.reportCriteriaXrLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.reportCriteriaXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0.0F, 51.0F);
			this.reportCriteriaXrLabel.Multiline = true;
			this.reportCriteriaXrLabel.Name = "reportCriteriaXrLabel";
			this.reportCriteriaXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.reportCriteriaXrLabel.SizeF = new System.Drawing.SizeF(2620.0F, 35.0F);
			this.reportCriteriaXrLabel.StylePriority.UseTextAlignment = false;
			this.reportCriteriaXrLabel.Text = "reportCriteriaXrLabel";
			this.reportCriteriaXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//reportTitleXRLabel
			//
			this.reportTitleXRLabel.Font = new System.Drawing.Font("Tahoma", 18.0F);
			this.reportTitleXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(0.0F, 0.0F);
			this.reportTitleXRLabel.Name = "reportTitleXRLabel";
			this.reportTitleXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.reportTitleXRLabel.SizeF = new System.Drawing.SizeF(3035.0F, 50.0F);
			this.reportTitleXRLabel.Text = "Production Costing Report";
			this.reportTitleXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//ReportFooter
			//
			this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.footerXrPanel});
			this.ReportFooter.HeightF = 30.0F;
			this.ReportFooter.KeepTogether = true;
			this.ReportFooter.Name = "ReportFooter";
			this.ReportFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.ReportFooter.StyleName = "Style2";
			this.ReportFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//footerXrPanel
			//
			this.footerXrPanel.BackColor = System.Drawing.Color.FromArgb((int)((byte)230), (int)((byte)235), (int)((byte)247));
			this.footerXrPanel.BorderColor = System.Drawing.Color.Black;
			this.footerXrPanel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.footerXrPanel.BorderWidth = 3;
			this.footerXrPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.salesVsProfitFooterXrLabel, this.profitVsSalesFooterXrLabel, this.salesVsCostFooterXrLabel, this.salesVsPayrollFooterXrLabel, this.packsPerMinuteFooterXrLabel, this.costPerPieceFooterXrLabel, this.profitFooterXrLabel, this.costFooterXrLabel, this.totalOtherFooterXrLabel, this.palletsFooterXrLabel, this.stretchWrapFooterXrLabel, this.boxesFooterXrLabel, this.filmFooterXrLabel, this.freightFooterXrLabel, this.rebateFooterXrLabel, this.payrollFooterXrLabel, this.priceFooterXrLabel, this.actualSpeedSummary, this.actualSpeedFooterXRLabel, this.differenceFooterXRLabel, this.expectedFooterXRLabel, this.quantityFooterXRLabel, this.totalMinutesFooterXRLabel, this.totalHoursFooterXRLabel});
			this.footerXrPanel.LocationFloat = new DevExpress.Utils.PointFloat(0.0F, 0.0F);
			this.footerXrPanel.Name = "footerXrPanel";
			this.footerXrPanel.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.footerXrPanel.SizeF = new System.Drawing.SizeF(3034.0F, 30.0F);
			this.footerXrPanel.StylePriority.UseBackColor = false;
			//
			//salesVsProfitFooterXrLabel
			//
			this.salesVsProfitFooterXrLabel.CanGrow = false;
			this.salesVsProfitFooterXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.salesVsProfitFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(2958.0F, 0.0F);
			this.salesVsProfitFooterXrLabel.Name = "salesVsProfitFooterXrLabel";
			this.salesVsProfitFooterXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.salesVsProfitFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.salesVsProfitFooterXrLabel.SizeF = new System.Drawing.SizeF(76.0F, 30.0F);
			this.salesVsProfitFooterXrLabel.StyleName = "footerXrControlStyle";
			this.salesVsProfitFooterXrLabel.StylePriority.UseTextAlignment = false;
			this.salesVsProfitFooterXrLabel.Text = "Sales vs. Profit";
			this.salesVsProfitFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//profitVsSalesFooterXrLabel
			//
			this.profitVsSalesFooterXrLabel.CanGrow = false;
			this.profitVsSalesFooterXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.profitVsSalesFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(2883.0F, 0.0F);
			this.profitVsSalesFooterXrLabel.Name = "profitVsSalesFooterXrLabel";
			this.profitVsSalesFooterXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.profitVsSalesFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.profitVsSalesFooterXrLabel.SizeF = new System.Drawing.SizeF(75.0F, 30.0F);
			this.profitVsSalesFooterXrLabel.StyleName = "footerXrControlStyle";
			this.profitVsSalesFooterXrLabel.StylePriority.UseTextAlignment = false;
			this.profitVsSalesFooterXrLabel.Text = "Profit vs. Sales";
			this.profitVsSalesFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//salesVsCostFooterXrLabel
			//
			this.salesVsCostFooterXrLabel.CanGrow = false;
			this.salesVsCostFooterXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.salesVsCostFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(2808.0F, 0.0F);
			this.salesVsCostFooterXrLabel.Name = "salesVsCostFooterXrLabel";
			this.salesVsCostFooterXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.salesVsCostFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.salesVsCostFooterXrLabel.SizeF = new System.Drawing.SizeF(75.0F, 30.0F);
			this.salesVsCostFooterXrLabel.StyleName = "footerXrControlStyle";
			this.salesVsCostFooterXrLabel.StylePriority.UseTextAlignment = false;
			this.salesVsCostFooterXrLabel.Text = "Sales vs. Cost";
			this.salesVsCostFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//salesVsPayrollFooterXrLabel
			//
			this.salesVsPayrollFooterXrLabel.CanGrow = false;
			this.salesVsPayrollFooterXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.salesVsPayrollFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(2729.0F, 0.0F);
			this.salesVsPayrollFooterXrLabel.Name = "salesVsPayrollFooterXrLabel";
			this.salesVsPayrollFooterXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.salesVsPayrollFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.salesVsPayrollFooterXrLabel.SizeF = new System.Drawing.SizeF(79.0F, 30.0F);
			this.salesVsPayrollFooterXrLabel.StyleName = "footerXrControlStyle";
			this.salesVsPayrollFooterXrLabel.StylePriority.UseTextAlignment = false;
			this.salesVsPayrollFooterXrLabel.Text = "Sales vs. Payroll";
			this.salesVsPayrollFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//packsPerMinuteFooterXrLabel
			//
			this.packsPerMinuteFooterXrLabel.CanGrow = false;
			this.packsPerMinuteFooterXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.packsPerMinuteFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(2654.0F, 0.0F);
			this.packsPerMinuteFooterXrLabel.Name = "packsPerMinuteFooterXrLabel";
			this.packsPerMinuteFooterXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.packsPerMinuteFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.packsPerMinuteFooterXrLabel.SizeF = new System.Drawing.SizeF(75.0F, 30.0F);
			this.packsPerMinuteFooterXrLabel.StyleName = "footerXrControlStyle";
			this.packsPerMinuteFooterXrLabel.StylePriority.UseTextAlignment = false;
			this.packsPerMinuteFooterXrLabel.Text = "Packs Per Minute";
			this.packsPerMinuteFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//costPerPieceFooterXrLabel
			//
			this.costPerPieceFooterXrLabel.CanGrow = false;
			this.costPerPieceFooterXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.costPerPieceFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(2579.0F, 0.0F);
			this.costPerPieceFooterXrLabel.Name = "costPerPieceFooterXrLabel";
			this.costPerPieceFooterXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.costPerPieceFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.costPerPieceFooterXrLabel.SizeF = new System.Drawing.SizeF(75.0F, 30.0F);
			this.costPerPieceFooterXrLabel.StyleName = "footerXrControlStyle";
			this.costPerPieceFooterXrLabel.StylePriority.UseTextAlignment = false;
			this.costPerPieceFooterXrLabel.Text = "Cost Per Piece";
			this.costPerPieceFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//profitFooterXrLabel
			//
			this.profitFooterXrLabel.CanGrow = false;
			this.profitFooterXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.profitFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(2479.0F, 0.0F);
			this.profitFooterXrLabel.Name = "profitFooterXrLabel";
			this.profitFooterXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.profitFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.profitFooterXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 30.0F);
			this.profitFooterXrLabel.StyleName = "footerXrControlStyle";
			this.profitFooterXrLabel.StylePriority.UseTextAlignment = false;
			this.profitFooterXrLabel.Text = "Profit";
			this.profitFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//costFooterXrLabel
			//
			this.costFooterXrLabel.CanGrow = false;
			this.costFooterXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.costFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(2379.0F, 0.0F);
			this.costFooterXrLabel.Name = "costFooterXrLabel";
			this.costFooterXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.costFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.costFooterXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 30.0F);
			this.costFooterXrLabel.StyleName = "footerXrControlStyle";
			this.costFooterXrLabel.StylePriority.UseTextAlignment = false;
			this.costFooterXrLabel.Text = "Cost";
			this.costFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//totalOtherFooterXrLabel
			//
			this.totalOtherFooterXrLabel.CanGrow = false;
			this.totalOtherFooterXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.totalOtherFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(2279.0F, 0.0F);
			this.totalOtherFooterXrLabel.Name = "totalOtherFooterXrLabel";
			this.totalOtherFooterXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.totalOtherFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.totalOtherFooterXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 30.0F);
			this.totalOtherFooterXrLabel.StyleName = "footerXrControlStyle";
			this.totalOtherFooterXrLabel.StylePriority.UseTextAlignment = false;
			this.totalOtherFooterXrLabel.Text = "Total Other";
			this.totalOtherFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//palletsFooterXrLabel
			//
			this.palletsFooterXrLabel.CanGrow = false;
			this.palletsFooterXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.palletsFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(2179.0F, 0.0F);
			this.palletsFooterXrLabel.Name = "palletsFooterXrLabel";
			this.palletsFooterXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.palletsFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.palletsFooterXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 30.0F);
			this.palletsFooterXrLabel.StyleName = "footerXrControlStyle";
			this.palletsFooterXrLabel.StylePriority.UseTextAlignment = false;
			XrSummary1.FormatString = "{0:$#,##0.00}";
			XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.palletsFooterXrLabel.Summary = XrSummary1;
			this.palletsFooterXrLabel.Text = "Pallets";
			this.palletsFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//stretchWrapFooterXrLabel
			//
			this.stretchWrapFooterXrLabel.CanGrow = false;
			this.stretchWrapFooterXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.stretchWrapFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(2079.0F, 0.0F);
			this.stretchWrapFooterXrLabel.Name = "stretchWrapFooterXrLabel";
			this.stretchWrapFooterXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.stretchWrapFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.stretchWrapFooterXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 30.0F);
			this.stretchWrapFooterXrLabel.StyleName = "footerXrControlStyle";
			this.stretchWrapFooterXrLabel.StylePriority.UseTextAlignment = false;
			XrSummary2.FormatString = "{0:$#,##0.00}";
			XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.stretchWrapFooterXrLabel.Summary = XrSummary2;
			this.stretchWrapFooterXrLabel.Text = "Sretch Wrap";
			this.stretchWrapFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//boxesFooterXrLabel
			//
			this.boxesFooterXrLabel.CanGrow = false;
			this.boxesFooterXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.boxesFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1979.0F, 0.0F);
			this.boxesFooterXrLabel.Name = "boxesFooterXrLabel";
			this.boxesFooterXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.boxesFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.boxesFooterXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 30.0F);
			this.boxesFooterXrLabel.StyleName = "footerXrControlStyle";
			this.boxesFooterXrLabel.StylePriority.UseTextAlignment = false;
			XrSummary3.FormatString = "{0:$#,##0.00}";
			XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.boxesFooterXrLabel.Summary = XrSummary3;
			this.boxesFooterXrLabel.Text = "Boxes";
			this.boxesFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//filmFooterXrLabel
			//
			this.filmFooterXrLabel.CanGrow = false;
			this.filmFooterXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.filmFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1879.0F, 0.0F);
			this.filmFooterXrLabel.Name = "filmFooterXrLabel";
			this.filmFooterXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.filmFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.filmFooterXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 30.0F);
			this.filmFooterXrLabel.StyleName = "footerXrControlStyle";
			this.filmFooterXrLabel.StylePriority.UseTextAlignment = false;
			XrSummary4.FormatString = "{0:$#,##0.00}";
			XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.filmFooterXrLabel.Summary = XrSummary4;
			this.filmFooterXrLabel.Text = "Film";
			this.filmFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//freightFooterXrLabel
			//
			this.freightFooterXrLabel.CanGrow = false;
			this.freightFooterXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.freightFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1779.0F, 0.0F);
			this.freightFooterXrLabel.Name = "freightFooterXrLabel";
			this.freightFooterXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.freightFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.freightFooterXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 30.0F);
			this.freightFooterXrLabel.StyleName = "footerXrControlStyle";
			this.freightFooterXrLabel.StylePriority.UseTextAlignment = false;
			XrSummary5.FormatString = "{0:$#,##0.00}";
			XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.freightFooterXrLabel.Summary = XrSummary5;
			this.freightFooterXrLabel.Text = "Freight";
			this.freightFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//rebateFooterXrLabel
			//
			this.rebateFooterXrLabel.CanGrow = false;
			this.rebateFooterXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.rebateFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1679.0F, 0.0F);
			this.rebateFooterXrLabel.Name = "rebateFooterXrLabel";
			this.rebateFooterXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.rebateFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.rebateFooterXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 30.0F);
			this.rebateFooterXrLabel.StyleName = "footerXrControlStyle";
			this.rebateFooterXrLabel.StylePriority.UseTextAlignment = false;
			XrSummary6.FormatString = "{0:$#,##0.00}";
			XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.rebateFooterXrLabel.Summary = XrSummary6;
			this.rebateFooterXrLabel.Text = "Rebate";
			this.rebateFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//payrollFooterXrLabel
			//
			this.payrollFooterXrLabel.CanGrow = false;
			this.payrollFooterXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.payrollFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1579.0F, 0.0F);
			this.payrollFooterXrLabel.Name = "payrollFooterXrLabel";
			this.payrollFooterXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.payrollFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.payrollFooterXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 30.0F);
			this.payrollFooterXrLabel.StyleName = "footerXrControlStyle";
			this.payrollFooterXrLabel.StylePriority.UseTextAlignment = false;
			this.payrollFooterXrLabel.Text = "Payroll";
			this.payrollFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//priceFooterXrLabel
			//
			this.priceFooterXrLabel.CanGrow = false;
			this.priceFooterXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.priceFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1479.0F, 0.0F);
			this.priceFooterXrLabel.Name = "priceFooterXrLabel";
			this.priceFooterXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.priceFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.priceFooterXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 30.0F);
			this.priceFooterXrLabel.StyleName = "footerXrControlStyle";
			this.priceFooterXrLabel.StylePriority.UseTextAlignment = false;
			XrSummary7.FormatString = "{0:$#,##0.00}";
			XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.priceFooterXrLabel.Summary = XrSummary7;
			this.priceFooterXrLabel.Text = "Price";
			this.priceFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//actualSpeedSummary
			//
			this.actualSpeedSummary.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "actualSpeed", "0.00")});
			this.actualSpeedSummary.LocationFloat = new DevExpress.Utils.PointFloat(8.0F, 0.0F);
			this.actualSpeedSummary.Name = "actualSpeedSummary";
			this.actualSpeedSummary.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.actualSpeedSummary.SizeF = new System.Drawing.SizeF(100.0F, 25.0F);
			this.actualSpeedSummary.StyleName = "footerXrControlStyle";
			XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.actualSpeedSummary.Summary = XrSummary8;
			this.actualSpeedSummary.Text = "actualSpeedSummary";
			this.actualSpeedSummary.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			this.actualSpeedSummary.Visible = false;
			//
			//actualSpeedFooterXRLabel
			//
			this.actualSpeedFooterXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(1250.0F, 0.0F);
			this.actualSpeedFooterXRLabel.Name = "actualSpeedFooterXRLabel";
			this.actualSpeedFooterXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.actualSpeedFooterXRLabel.SizeF = new System.Drawing.SizeF(57.0F, 30.0F);
			this.actualSpeedFooterXRLabel.StyleName = "footerXrControlStyle";
			this.actualSpeedFooterXRLabel.StylePriority.UseTextAlignment = false;
			this.actualSpeedFooterXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//differenceFooterXRLabel
			//
			this.differenceFooterXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(1053.0F, 0.0F);
			this.differenceFooterXRLabel.Name = "differenceFooterXRLabel";
			this.differenceFooterXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.differenceFooterXRLabel.SizeF = new System.Drawing.SizeF(69.0F, 30.0F);
			this.differenceFooterXRLabel.StyleName = "footerXrControlStyle";
			this.differenceFooterXRLabel.StylePriority.UseTextAlignment = false;
			this.differenceFooterXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//expectedFooterXRLabel
			//
			this.expectedFooterXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(1004.0F, 0.0F);
			this.expectedFooterXRLabel.Name = "expectedFooterXRLabel";
			this.expectedFooterXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.expectedFooterXRLabel.SizeF = new System.Drawing.SizeF(49.0F, 30.0F);
			this.expectedFooterXRLabel.StyleName = "footerXrControlStyle";
			this.expectedFooterXRLabel.StylePriority.UseTextAlignment = false;
			XrSummary9.FormatString = "{0:#,#}";
			this.expectedFooterXRLabel.Summary = XrSummary9;
			this.expectedFooterXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//quantityFooterXRLabel
			//
			this.quantityFooterXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(914.0F, 0.0F);
			this.quantityFooterXRLabel.Name = "quantityFooterXRLabel";
			this.quantityFooterXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.quantityFooterXRLabel.SizeF = new System.Drawing.SizeF(90.0F, 30.0F);
			this.quantityFooterXRLabel.StyleName = "footerXrControlStyle";
			this.quantityFooterXRLabel.StylePriority.UseTextAlignment = false;
			XrSummary10.FormatString = "{0:#,#}";
			XrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.quantityFooterXRLabel.Summary = XrSummary10;
			this.quantityFooterXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//totalMinutesFooterXRLabel
			//
			this.totalMinutesFooterXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(855.0F, 0.0F);
			this.totalMinutesFooterXRLabel.Name = "totalMinutesFooterXRLabel";
			this.totalMinutesFooterXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.totalMinutesFooterXRLabel.SizeF = new System.Drawing.SizeF(59.0F, 30.0F);
			this.totalMinutesFooterXRLabel.StyleName = "footerXrControlStyle";
			this.totalMinutesFooterXRLabel.StylePriority.UseTextAlignment = false;
			this.totalMinutesFooterXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//totalHoursFooterXRLabel
			//
			this.totalHoursFooterXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(800.0F, 0.0F);
			this.totalHoursFooterXRLabel.Name = "totalHoursFooterXRLabel";
			this.totalHoursFooterXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.totalHoursFooterXRLabel.SizeF = new System.Drawing.SizeF(55.0F, 30.0F);
			this.totalHoursFooterXRLabel.StyleName = "footerXrControlStyle";
			this.totalHoursFooterXRLabel.StylePriority.UseTextAlignment = false;
			XrSummary11.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
			XrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.totalHoursFooterXRLabel.Summary = XrSummary11;
			this.totalHoursFooterXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//headerXrControlStyle
			//
			this.headerXrControlStyle.BackColor = System.Drawing.Color.FromArgb((int)((byte)230), (int)((byte)235), (int)((byte)247));
			this.headerXrControlStyle.BorderColor = System.Drawing.Color.FromArgb((int)((byte)194), (int)((byte)202), (int)((byte)213));
			this.headerXrControlStyle.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.headerXrControlStyle.BorderWidth = 1;
			this.headerXrControlStyle.Font = new System.Drawing.Font("Tahoma", 6.5F, System.Drawing.FontStyle.Bold);
			this.headerXrControlStyle.ForeColor = System.Drawing.SystemColors.ControlText;
			this.headerXrControlStyle.Name = "headerXrControlStyle";
			//
			//footerXrControlStyle
			//
			this.footerXrControlStyle.BackColor = System.Drawing.Color.FromArgb((int)((byte)230), (int)((byte)235), (int)((byte)247));
			this.footerXrControlStyle.BorderColor = System.Drawing.Color.FromArgb((int)((byte)194), (int)((byte)202), (int)((byte)213));
			this.footerXrControlStyle.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.footerXrControlStyle.BorderWidth = 1;
			this.footerXrControlStyle.Font = new System.Drawing.Font("Tahoma", 6.5F);
			this.footerXrControlStyle.ForeColor = System.Drawing.Color.Black;
			this.footerXrControlStyle.Name = "footerXrControlStyle";
			//
			//detailOddXrControlStyle
			//
			this.detailOddXrControlStyle.BackColor = System.Drawing.Color.LightGray;
			this.detailOddXrControlStyle.BorderColor = System.Drawing.Color.FromArgb((int)((byte)176), (int)((byte)187), (int)((byte)169));
			this.detailOddXrControlStyle.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.detailOddXrControlStyle.BorderWidth = 1;
			this.detailOddXrControlStyle.Font = new System.Drawing.Font("Tahoma", 6.5F);
			this.detailOddXrControlStyle.ForeColor = System.Drawing.Color.Black;
			this.detailOddXrControlStyle.Name = "detailOddXrControlStyle";
			//
			//detailEvenXrControlStyle
			//
			this.detailEvenXrControlStyle.BackColor = System.Drawing.Color.Transparent;
			this.detailEvenXrControlStyle.BorderColor = System.Drawing.Color.FromArgb((int)((byte)196), (int)((byte)207), (int)((byte)189));
			this.detailEvenXrControlStyle.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.detailEvenXrControlStyle.BorderWidth = 1;
			this.detailEvenXrControlStyle.Font = new System.Drawing.Font("Tahoma", 6.5F);
			this.detailEvenXrControlStyle.ForeColor = System.Drawing.Color.Black;
			this.detailEvenXrControlStyle.Name = "detailEvenXrControlStyle";
			//
			//PageFooter
			//
			this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.pageNumberXrPageInfo});
			this.PageFooter.HeightF = 25.0F;
			this.PageFooter.Name = "PageFooter";
			//
			//pageNumberXrPageInfo
			//
			this.pageNumberXrPageInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic);
			this.pageNumberXrPageInfo.Format = "Page:  {0} / {1}";
			this.pageNumberXrPageInfo.LocationFloat = new DevExpress.Utils.PointFloat(2925.0F, 0.0F);
			this.pageNumberXrPageInfo.Name = "pageNumberXrPageInfo";
			this.pageNumberXrPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.pageNumberXrPageInfo.SizeF = new System.Drawing.SizeF(100.0F, 25.0F);
			this.pageNumberXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//TopMarginBand1
			//
			this.TopMarginBand1.HeightF = 50.0F;
			this.TopMarginBand1.Name = "TopMarginBand1";
			//
			//BottomMarginBand1
			//
			this.BottomMarginBand1.HeightF = 50.0F;
			this.BottomMarginBand1.Name = "BottomMarginBand1";
			//
			//CostingXtraReport
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.PageHeader, this.ReportHeader, this.ReportFooter, this.PageFooter, this.TopMarginBand1, this.BottomMarginBand1});
			this.Landscape = true;
			this.Margins = new System.Drawing.Printing.Margins(25, 25, 50, 50);
			this.PageHeight = 850;
			this.PageWidth = 3085;
			this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
			this.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic;
			this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {this.Style1, this.Style2, this.Style3, this.headerXrControlStyle, this.footerXrControlStyle, this.detailOddXrControlStyle, this.detailEvenXrControlStyle});
			this.Version = "11.2";
			((System.ComponentModel.ISupportInitialize)this).EndInit();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			totalMinutesDetailXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(totalMinutesDetailXrLabel_BeforePrint);
			actualSpeedDetailXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(actualSpeedDetailXrLabel_BeforePrint);
			this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(CostingXtraReport_BeforePrint);
			payrollDetailXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(payrollDetailXrLabel_BeforePrint);
			costDetailXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(costDetailXrLabel_BeforePrint);
			profitDetailXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(profitDetailXrLabel_BeforePrint);
			costPerPieceDetailXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(costPerPieceDetailXrLabel_BeforePrint);
			packsPerMinuteDetailXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(packsPerMinuteDetailXrLabel_BeforePrint);
			salesVsPayrollDetailXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(salesVsPayrollDetailXrLabel_BeforePrint);
			salesVsCostDetailXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(salesVsCostDetailXrLabel_BeforePrint);
			profitVsSalesDetailXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(profitVsSalesDetailXrLabel_BeforePrint);
			totalMinutesFooterXRLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(totalMinutesFooterXRLabel_BeforePrint);
			payrollFooterXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(payrollFooterXrLabel_BeforePrint);
			costFooterXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(costFooterXrLabel_BeforePrint);
			profitFooterXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(profitFooterXrLabel_BeforePrint);
			costPerPieceFooterXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(costPerPieceFooterXrLabel_BeforePrint);
			packsPerMinuteFooterXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(packsPerMinuteFooterXrLabel_BeforePrint);
			salesVsPayrollFooterXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(salesVsPayrollFooterXrLabel_BeforePrint);
			salesVsCostFooterXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(salesVsCostFooterXrLabel_BeforePrint);
			profitVsSalesFooterXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(profitVsSalesFooterXrLabel_BeforePrint);
			totalOtherDetailXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(totalOtherDetailXrLabel_BeforePrint);
			totalOtherFooterXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(totalOtherFooterXrLabel_BeforePrint);
			salesVsProfitDetailXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(salesVsProfitDetailXrLabel_BeforePrint);
			salesVsProfitFooterXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(salesVsProfitFooterXrLabel_BeforePrint);
			differenceFooterXRLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(differenceFooterXRLabel_BeforePrint);
			actualSpeedFooterXRLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(actualSpeedFooterXRLabel_BeforePrint);
			Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(Detail_BeforePrint);
			totalHoursDetailXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(totalHoursDetailXrLabel_BeforePrint);
			totalMinutesHeaderXRLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(totalMinutesHeaderXRLabel_BeforePrint);
			totalHoursFooterXRLabel.SummaryReset += new System.EventHandler(totalHoursFooterXRLabel_SummaryReset);
			totalHoursFooterXRLabel.SummaryRowChanged += new System.EventHandler(totalHoursFooterXRLabel_SummaryRowChanged);
			totalHoursFooterXRLabel.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(totalHoursFooterXRLabel_SummaryGetResult);
			expectedDetailXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(expectedDetailXrLabel_BeforePrint);
			differenceDetailXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(differenceDetailXrLabel_BeforePrint);
			ReportHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(ReportHeader_BeforePrint);
			expectedFooterXRLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(expectedFooterXRLabel_BeforePrint);
		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
		internal DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		internal DevExpress.XtraReports.UI.XRLabel reportTitleXRLabel;
		internal DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
		internal DevExpress.XtraReports.UI.XRPanel headerXrPanel;
		internal DevExpress.XtraReports.UI.XRPanel footerXrPanel;
		internal DevExpress.XtraReports.UI.XRLabel reportCriteriaXrLabel;
		internal DevExpress.XtraReports.UI.XRControlStyle Style1;
		internal DevExpress.XtraReports.UI.XRControlStyle Style2;
		internal DevExpress.XtraReports.UI.XRControlStyle Style3;
		internal DevExpress.XtraReports.UI.XRControlStyle headerXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle footerXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle detailOddXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle detailEvenXrControlStyle;
		internal DevExpress.XtraReports.UI.XRPageInfo printDateXRPageInfo;
		internal DevExpress.XtraReports.UI.XRLabel dateHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel shiftHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemCodeHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel lotHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel customerNameHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel startTimeHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemDescriptionHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel differenceHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel expectedHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel quantityHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel totalMinutesHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel totalHoursHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel stopTimeHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel packerHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel operatorHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel actualSpeedHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel speedHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel machineLineHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel superHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel boxesHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel filmHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel freightHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel rebateHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel payrollHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel priceHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel salesVsPayrollHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel packsPerMinuteHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel costPerPieceHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel profitHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel costHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel totalOtherHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel palletsHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel stretchWrapHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel profitVsSalesHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel salesVsCostHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel salesVsProfitHeaderXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel salesVsProfitDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel profitVsSalesDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel salesVsCostDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel salesVsPayrollDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel packsPerMinuteDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel costPerPieceDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel profitDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel costDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel totalOtherDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel palletsDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel stretchWrapDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel boxesDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel filmDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel freightDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel rebateDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel payrollDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel priceDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel superDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel packerDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel operatorDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel actualSpeedDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel speedDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel machineLineDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel differenceDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel expectedDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel quantityDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel totalMinutesDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel totalHoursDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel stopTimeDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel startTimeDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemDescriptionDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemCodeDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel lotDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel customerNameDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel shiftDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel dateDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel totalHoursFooterXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel totalMinutesFooterXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel quantityFooterXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel expectedFooterXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel differenceFooterXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel actualSpeedFooterXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel actualSpeedSummary;
		internal DevExpress.XtraReports.UI.XRLabel salesVsProfitFooterXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel profitVsSalesFooterXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel salesVsCostFooterXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel salesVsPayrollFooterXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel packsPerMinuteFooterXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel costPerPieceFooterXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel profitFooterXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel costFooterXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel totalOtherFooterXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel palletsFooterXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel stretchWrapFooterXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel boxesFooterXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel filmFooterXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel freightFooterXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel rebateFooterXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel payrollFooterXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel priceFooterXrLabel;
		internal DevExpress.XtraReports.UI.PageFooterBand PageFooter;
		internal DevExpress.XtraReports.UI.XRPageInfo pageNumberXrPageInfo;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMarginBand1;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMarginBand1;
	}

}