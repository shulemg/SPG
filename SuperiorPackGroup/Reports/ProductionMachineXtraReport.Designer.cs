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
	public partial class ProductionMachineXtraReport : DevExpress.XtraReports.UI.XtraReport
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
			this.components = new System.ComponentModel.Container();
			DevExpress.XtraReports.UI.XRSummary XrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
			this.headerXrPanel = new DevExpress.XtraReports.UI.XRPanel();
			this.totalSalesHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.packersHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.priceHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.salesVsPayrollHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.machineSpeedHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.pricePerPieceHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.costVariationPercentageHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.costVariationHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.quantityHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.projectedCostHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.packersVariationPercentageHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.packersVariationVolumeHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.projectedPackersHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.speedVariationPercentageHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.speedVariationVolumeHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.averageSpeedHeadeerXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.averageActualCostHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.minutesHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.machineHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
			this.pageNumberXrPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
			this.headerXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.footerXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.detailOddXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.detailEvenXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.printDateXrPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
			this.reportCriteriaXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.reportTitleXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.customerGroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.CustomerNameXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.itemGroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.itemHeaderXRLine = new DevExpress.XtraReports.UI.XRLine();
			this.itemDescriptionXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.DescriptionXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.ItemXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemGroupFooter = new DevExpress.XtraReports.UI.GroupFooterBand();
			this.footerXrPanel = new DevExpress.XtraReports.UI.XRPanel();
			this.itemPriceXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemPricePerPieceXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemPackersVariationPercentageXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemPackersVariationVolumeXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemAverageActualPackersXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemSpeedVariationPercentageXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemSpeedVariationXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemAverageSpeedXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemProjectedSpeedXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemQuantityXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemMinutesXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemTotalSalesXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemSalesVsPayrollXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemCostVariationPercentageXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemCostVariationXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemAverageCostXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemProjectedCostXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemProjectedPackersXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.machineGroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.machineGroupFooter = new DevExpress.XtraReports.UI.GroupFooterBand();
			this.machineTotalSalesXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.machinePriceXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.machineSalesVsPayrollXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.machinePricePerPieceXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.machineCostVariationPercentageXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.machineCostVariationXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.machineAverageCostXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.machineProjectedCostXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.machinePackersVariationPercentageXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.machinePackersVariationVolumeXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.machineAverageActualPackersXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.machineProjectedPackersXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.machineSpeedVariationPercentageXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.machineSpeedVariationVolumeXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.machineAverageSpeedXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.machineProjectedSpeedXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.machineQuantityXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.machineTotalMinutesXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.pricePerPieceCalculatedField = new DevExpress.XtraReports.UI.CalculatedField();
			this.productionXPView = new DevExpress.Xpo.XPView(this.components);
			this.totalSalesCalculatedField = new DevExpress.XtraReports.UI.CalculatedField();
			this.TopMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.customerGroupFooter = new DevExpress.XtraReports.UI.GroupFooterBand();
			this.XrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
			this.XrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.customerPackersVariationPercentageXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.customerSpeedVariationPercentageXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.customerCostVariationPercentageXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
			this.XrPanel2 = new DevExpress.XtraReports.UI.XRPanel();
			this.XrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.reportPackersVariationPercentageXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.reportSpeedVariationPercentageXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.reportCostVariationPercentageXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			((System.ComponentModel.ISupportInitialize)this.productionXPView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this).BeginInit();
			//
			//Detail
			//
			this.Detail.HeightF = 0F;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//PageHeader
			//
			this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.headerXrPanel});
			this.PageHeader.HeightF = 50F;
			this.PageHeader.Name = "PageHeader";
			this.PageHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//headerXrPanel
			//
			this.headerXrPanel.BorderColor = System.Drawing.Color.Black;
			this.headerXrPanel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.headerXrPanel.BorderWidth = 3F;
			this.headerXrPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.totalSalesHeaderXrLabel, this.packersHeaderXrLabel, this.priceHeaderXrLabel, this.salesVsPayrollHeaderXrLabel, this.machineSpeedHeaderXrLabel, this.pricePerPieceHeaderXrLabel, this.costVariationPercentageHeaderXrLabel, this.costVariationHeaderXrLabel, this.quantityHeaderXrLabel, this.projectedCostHeaderXrLabel, this.packersVariationPercentageHeaderXrLabel, this.packersVariationVolumeHeaderXrLabel, this.projectedPackersHeaderXrLabel, this.speedVariationPercentageHeaderXrLabel, this.speedVariationVolumeHeaderXrLabel, this.averageSpeedHeadeerXrLabel, this.averageActualCostHeaderXrLabel, this.minutesHeaderXrLabel, this.machineHeaderXrLabel});
			this.headerXrPanel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.headerXrPanel.Name = "headerXrPanel";
			this.headerXrPanel.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.headerXrPanel.SizeF = new System.Drawing.SizeF(1050F, 50F);
			//
			//totalSalesHeaderXrLabel
			//
			this.totalSalesHeaderXrLabel.CanGrow = false;
			this.totalSalesHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(995F, 0F);
			this.totalSalesHeaderXrLabel.Name = "totalSalesHeaderXrLabel";
			this.totalSalesHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.totalSalesHeaderXrLabel.SizeF = new System.Drawing.SizeF(55F, 50F);
			this.totalSalesHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.totalSalesHeaderXrLabel.Text = "Total Sales";
			this.totalSalesHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//packersHeaderXrLabel
			//
			this.packersHeaderXrLabel.CanGrow = false;
			this.packersHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(445F, 0F);
			this.packersHeaderXrLabel.Name = "packersHeaderXrLabel";
			this.packersHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.packersHeaderXrLabel.SizeF = new System.Drawing.SizeF(55F, 50F);
			this.packersHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.packersHeaderXrLabel.Text = "Average Actual Packers";
			this.packersHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//priceHeaderXrLabel
			//
			this.priceHeaderXrLabel.CanGrow = false;
			this.priceHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(940F, 0F);
			this.priceHeaderXrLabel.Name = "priceHeaderXrLabel";
			this.priceHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.priceHeaderXrLabel.SizeF = new System.Drawing.SizeF(55F, 50F);
			this.priceHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.priceHeaderXrLabel.Text = "Sales Price Per Case";
			this.priceHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//salesVsPayrollHeaderXrLabel
			//
			this.salesVsPayrollHeaderXrLabel.CanGrow = false;
			this.salesVsPayrollHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(885F, 0F);
			this.salesVsPayrollHeaderXrLabel.Name = "salesVsPayrollHeaderXrLabel";
			this.salesVsPayrollHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.salesVsPayrollHeaderXrLabel.SizeF = new System.Drawing.SizeF(55F, 50F);
			this.salesVsPayrollHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.salesVsPayrollHeaderXrLabel.Text = "Sales vs. Payroll";
			this.salesVsPayrollHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//machineSpeedHeaderXrLabel
			//
			this.machineSpeedHeaderXrLabel.CanGrow = false;
			this.machineSpeedHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(170F, 0F);
			this.machineSpeedHeaderXrLabel.Name = "machineSpeedHeaderXrLabel";
			this.machineSpeedHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.machineSpeedHeaderXrLabel.SizeF = new System.Drawing.SizeF(55F, 50F);
			this.machineSpeedHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.machineSpeedHeaderXrLabel.Text = "Projected Speed";
			this.machineSpeedHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//pricePerPieceHeaderXrLabel
			//
			this.pricePerPieceHeaderXrLabel.CanGrow = false;
			this.pricePerPieceHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(830F, 0F);
			this.pricePerPieceHeaderXrLabel.Name = "pricePerPieceHeaderXrLabel";
			this.pricePerPieceHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.pricePerPieceHeaderXrLabel.SizeF = new System.Drawing.SizeF(55F, 50F);
			this.pricePerPieceHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.pricePerPieceHeaderXrLabel.Text = "Sales Price Per Piece";
			this.pricePerPieceHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//costVariationPercentageHeaderXrLabel
			//
			this.costVariationPercentageHeaderXrLabel.CanGrow = false;
			this.costVariationPercentageHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(775F, 0F);
			this.costVariationPercentageHeaderXrLabel.Name = "costVariationPercentageHeaderXrLabel";
			this.costVariationPercentageHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.costVariationPercentageHeaderXrLabel.SizeF = new System.Drawing.SizeF(55F, 50F);
			this.costVariationPercentageHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.costVariationPercentageHeaderXrLabel.Text = "Cost Variation %";
			this.costVariationPercentageHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//costVariationHeaderXrLabel
			//
			this.costVariationHeaderXrLabel.CanGrow = false;
			this.costVariationHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(720F, 0F);
			this.costVariationHeaderXrLabel.Name = "costVariationHeaderXrLabel";
			this.costVariationHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.costVariationHeaderXrLabel.SizeF = new System.Drawing.SizeF(55F, 50F);
			this.costVariationHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.costVariationHeaderXrLabel.Text = "Cost Variation";
			this.costVariationHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//quantityHeaderXrLabel
			//
			this.quantityHeaderXrLabel.CanGrow = false;
			this.quantityHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(117F, 0F);
			this.quantityHeaderXrLabel.Name = "quantityHeaderXrLabel";
			this.quantityHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.quantityHeaderXrLabel.SizeF = new System.Drawing.SizeF(53F, 50F);
			this.quantityHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.quantityHeaderXrLabel.Text = "Total Qty";
			this.quantityHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//projectedCostHeaderXrLabel
			//
			this.projectedCostHeaderXrLabel.CanGrow = false;
			this.projectedCostHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(610F, 0F);
			this.projectedCostHeaderXrLabel.Name = "projectedCostHeaderXrLabel";
			this.projectedCostHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.projectedCostHeaderXrLabel.SizeF = new System.Drawing.SizeF(55F, 50F);
			this.projectedCostHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.projectedCostHeaderXrLabel.Text = "Projected Cost";
			this.projectedCostHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//packersVariationPercentageHeaderXrLabel
			//
			this.packersVariationPercentageHeaderXrLabel.CanGrow = false;
			this.packersVariationPercentageHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(555F, 0F);
			this.packersVariationPercentageHeaderXrLabel.Name = "packersVariationPercentageHeaderXrLabel";
			this.packersVariationPercentageHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.packersVariationPercentageHeaderXrLabel.SizeF = new System.Drawing.SizeF(55F, 50F);
			this.packersVariationPercentageHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.packersVariationPercentageHeaderXrLabel.Text = "Packers Variation %";
			this.packersVariationPercentageHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//packersVariationVolumeHeaderXrLabel
			//
			this.packersVariationVolumeHeaderXrLabel.CanGrow = false;
			this.packersVariationVolumeHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(500F, 0F);
			this.packersVariationVolumeHeaderXrLabel.Name = "packersVariationVolumeHeaderXrLabel";
			this.packersVariationVolumeHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.packersVariationVolumeHeaderXrLabel.SizeF = new System.Drawing.SizeF(55F, 50F);
			this.packersVariationVolumeHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.packersVariationVolumeHeaderXrLabel.Text = "Packers Variation Volume";
			this.packersVariationVolumeHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//projectedPackersHeaderXrLabel
			//
			this.projectedPackersHeaderXrLabel.CanGrow = false;
			this.projectedPackersHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(390F, 0F);
			this.projectedPackersHeaderXrLabel.Name = "projectedPackersHeaderXrLabel";
			this.projectedPackersHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.projectedPackersHeaderXrLabel.SizeF = new System.Drawing.SizeF(55F, 50F);
			this.projectedPackersHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.projectedPackersHeaderXrLabel.Text = "Projected Packers";
			this.projectedPackersHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//speedVariationPercentageHeaderXrLabel
			//
			this.speedVariationPercentageHeaderXrLabel.CanGrow = false;
			this.speedVariationPercentageHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(335F, 0F);
			this.speedVariationPercentageHeaderXrLabel.Name = "speedVariationPercentageHeaderXrLabel";
			this.speedVariationPercentageHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.speedVariationPercentageHeaderXrLabel.SizeF = new System.Drawing.SizeF(55F, 50F);
			this.speedVariationPercentageHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.speedVariationPercentageHeaderXrLabel.Text = "Speed Variation %";
			this.speedVariationPercentageHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//speedVariationVolumeHeaderXrLabel
			//
			this.speedVariationVolumeHeaderXrLabel.CanGrow = false;
			this.speedVariationVolumeHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(280F, 0F);
			this.speedVariationVolumeHeaderXrLabel.Name = "speedVariationVolumeHeaderXrLabel";
			this.speedVariationVolumeHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.speedVariationVolumeHeaderXrLabel.SizeF = new System.Drawing.SizeF(55F, 50F);
			this.speedVariationVolumeHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.speedVariationVolumeHeaderXrLabel.Text = "Speed Variation Volume";
			this.speedVariationVolumeHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//averageSpeedHeadeerXrLabel
			//
			this.averageSpeedHeadeerXrLabel.CanGrow = false;
			this.averageSpeedHeadeerXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(225F, 0F);
			this.averageSpeedHeadeerXrLabel.Name = "averageSpeedHeadeerXrLabel";
			this.averageSpeedHeadeerXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.averageSpeedHeadeerXrLabel.SizeF = new System.Drawing.SizeF(55F, 50F);
			this.averageSpeedHeadeerXrLabel.StyleName = "headerXrControlStyle";
			this.averageSpeedHeadeerXrLabel.Text = "Average Actual Speed";
			this.averageSpeedHeadeerXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//averageActualCostHeaderXrLabel
			//
			this.averageActualCostHeaderXrLabel.CanGrow = false;
			this.averageActualCostHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(665F, 0F);
			this.averageActualCostHeaderXrLabel.Name = "averageActualCostHeaderXrLabel";
			this.averageActualCostHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.averageActualCostHeaderXrLabel.SizeF = new System.Drawing.SizeF(55F, 50F);
			this.averageActualCostHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.averageActualCostHeaderXrLabel.Text = "Average Actual Cost";
			this.averageActualCostHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//minutesHeaderXrLabel
			//
			this.minutesHeaderXrLabel.CanGrow = false;
			this.minutesHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(67F, 0F);
			this.minutesHeaderXrLabel.Name = "minutesHeaderXrLabel";
			this.minutesHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.minutesHeaderXrLabel.SizeF = new System.Drawing.SizeF(50F, 50F);
			this.minutesHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.minutesHeaderXrLabel.Text = "Total Minutes";
			this.minutesHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//machineHeaderXrLabel
			//
			this.machineHeaderXrLabel.CanGrow = false;
			this.machineHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.machineHeaderXrLabel.Name = "machineHeaderXrLabel";
			this.machineHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.machineHeaderXrLabel.SizeF = new System.Drawing.SizeF(67F, 50F);
			this.machineHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.machineHeaderXrLabel.Text = "Machine Line";
			this.machineHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//PageFooter
			//
			this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.pageNumberXrPageInfo});
			this.PageFooter.HeightF = 30F;
			this.PageFooter.Name = "PageFooter";
			this.PageFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//pageNumberXrPageInfo
			//
			this.pageNumberXrPageInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic);
			this.pageNumberXrPageInfo.Format = "Page:  {0} / {1}";
			this.pageNumberXrPageInfo.LocationFloat = new DevExpress.Utils.PointFloat(950F, 0F);
			this.pageNumberXrPageInfo.Name = "pageNumberXrPageInfo";
			this.pageNumberXrPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.pageNumberXrPageInfo.SizeF = new System.Drawing.SizeF(100F, 25F);
			this.pageNumberXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//headerXrControlStyle
			//
			this.headerXrControlStyle.BackColor = System.Drawing.Color.FromArgb((int)((byte)230), (int)((byte)235), (int)((byte)247));
			this.headerXrControlStyle.BorderColor = System.Drawing.Color.FromArgb((int)((byte)194), (int)((byte)202), (int)((byte)213));
			this.headerXrControlStyle.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.headerXrControlStyle.BorderWidth = 1F;
			this.headerXrControlStyle.Font = new System.Drawing.Font("Tahoma", 6.5F, System.Drawing.FontStyle.Bold);
			this.headerXrControlStyle.ForeColor = System.Drawing.SystemColors.ControlText;
			this.headerXrControlStyle.Name = "headerXrControlStyle";
			//
			//footerXrControlStyle
			//
			this.footerXrControlStyle.BackColor = System.Drawing.Color.FromArgb((int)((byte)230), (int)((byte)235), (int)((byte)247));
			this.footerXrControlStyle.BorderColor = System.Drawing.Color.FromArgb((int)((byte)194), (int)((byte)202), (int)((byte)213));
			this.footerXrControlStyle.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.footerXrControlStyle.BorderWidth = 1F;
			this.footerXrControlStyle.Font = new System.Drawing.Font("Tahoma", 6.5F);
			this.footerXrControlStyle.ForeColor = System.Drawing.Color.Black;
			this.footerXrControlStyle.Name = "footerXrControlStyle";
			//
			//detailOddXrControlStyle
			//
			this.detailOddXrControlStyle.BackColor = System.Drawing.Color.LightGray;
			this.detailOddXrControlStyle.BorderColor = System.Drawing.Color.FromArgb((int)((byte)176), (int)((byte)187), (int)((byte)169));
			this.detailOddXrControlStyle.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.detailOddXrControlStyle.BorderWidth = 1F;
			this.detailOddXrControlStyle.Font = new System.Drawing.Font("Tahoma", 6.5F);
			this.detailOddXrControlStyle.ForeColor = System.Drawing.Color.Black;
			this.detailOddXrControlStyle.Name = "detailOddXrControlStyle";
			//
			//detailEvenXrControlStyle
			//
			this.detailEvenXrControlStyle.BackColor = System.Drawing.Color.Transparent;
			this.detailEvenXrControlStyle.BorderColor = System.Drawing.Color.FromArgb((int)((byte)196), (int)((byte)207), (int)((byte)189));
			this.detailEvenXrControlStyle.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.detailEvenXrControlStyle.BorderWidth = 1F;
			this.detailEvenXrControlStyle.Font = new System.Drawing.Font("Tahoma", 6.5F);
			this.detailEvenXrControlStyle.ForeColor = System.Drawing.Color.Black;
			this.detailEvenXrControlStyle.Name = "detailEvenXrControlStyle";
			//
			//ReportHeader
			//
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.printDateXrPageInfo, this.reportCriteriaXrLabel, this.reportTitleXrLabel});
			this.ReportHeader.HeightF = 85F;
			this.ReportHeader.Name = "ReportHeader";
			//
			//printDateXrPageInfo
			//
			this.printDateXrPageInfo.LocationFloat = new DevExpress.Utils.PointFloat(867F, 50F);
			this.printDateXrPageInfo.Name = "printDateXrPageInfo";
			this.printDateXrPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.printDateXrPageInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
			this.printDateXrPageInfo.SizeF = new System.Drawing.SizeF(183F, 35F);
			this.printDateXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//reportCriteriaXrLabel
			//
			this.reportCriteriaXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 50F);
			this.reportCriteriaXrLabel.Name = "reportCriteriaXrLabel";
			this.reportCriteriaXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.reportCriteriaXrLabel.SizeF = new System.Drawing.SizeF(635F, 35F);
			this.reportCriteriaXrLabel.Text = "reportCriteriaXrLabel";
			this.reportCriteriaXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//reportTitleXrLabel
			//
			this.reportTitleXrLabel.Font = new System.Drawing.Font("Tahoma", 18F);
			this.reportTitleXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.reportTitleXrLabel.Name = "reportTitleXrLabel";
			this.reportTitleXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.reportTitleXrLabel.SizeF = new System.Drawing.SizeF(1050F, 50F);
			this.reportTitleXrLabel.Text = "Production Summary Report";
			this.reportTitleXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//customerGroupHeader
			//
			this.customerGroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.CustomerNameXRLabel, this.XrLabel1});
			this.customerGroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {new DevExpress.XtraReports.UI.GroupField("CustomerName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
			this.customerGroupHeader.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
			this.customerGroupHeader.HeightF = 25F;
			this.customerGroupHeader.KeepTogether = true;
			this.customerGroupHeader.Level = 2;
			this.customerGroupHeader.Name = "customerGroupHeader";
			//
			//CustomerNameXRLabel
			//
			this.CustomerNameXRLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
			this.CustomerNameXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.CustomerNameXRLabel.Name = "CustomerNameXRLabel";
			this.CustomerNameXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.CustomerNameXRLabel.SizeF = new System.Drawing.SizeF(100F, 25F);
			this.CustomerNameXRLabel.StylePriority.UseFont = false;
			this.CustomerNameXRLabel.StylePriority.UseTextAlignment = false;
			this.CustomerNameXRLabel.Text = "Customer Name";
			this.CustomerNameXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//XrLabel1
			//
			this.XrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomerName")});
			this.XrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(100F, 0F);
			this.XrLabel1.Name = "XrLabel1";
			this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.XrLabel1.SizeF = new System.Drawing.SizeF(267F, 25F);
			this.XrLabel1.StylePriority.UseTextAlignment = false;
			this.XrLabel1.Text = "XrLabel1";
			this.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//itemGroupHeader
			//
			this.itemGroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.itemHeaderXRLine, this.itemDescriptionXrLabel, this.XrLabel2, this.DescriptionXRLabel, this.ItemXRLabel});
			this.itemGroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {new DevExpress.XtraReports.UI.GroupField("ItemCode", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
			this.itemGroupHeader.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
			this.itemGroupHeader.HeightF = 33F;
			this.itemGroupHeader.KeepTogether = true;
			this.itemGroupHeader.Level = 1;
			this.itemGroupHeader.Name = "itemGroupHeader";
			//
			//itemHeaderXRLine
			//
			this.itemHeaderXRLine.LocationFloat = new DevExpress.Utils.PointFloat(8F, 25F);
			this.itemHeaderXRLine.Name = "itemHeaderXRLine";
			this.itemHeaderXRLine.SizeF = new System.Drawing.SizeF(1042F, 8F);
			//
			//itemDescriptionXrLabel
			//
			this.itemDescriptionXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "ItemDescription")});
			this.itemDescriptionXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(418F, 0F);
			this.itemDescriptionXrLabel.Multiline = true;
			this.itemDescriptionXrLabel.Name = "itemDescriptionXrLabel";
			this.itemDescriptionXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.itemDescriptionXrLabel.SizeF = new System.Drawing.SizeF(625F, 25F);
			this.itemDescriptionXrLabel.StylePriority.UseTextAlignment = false;
			this.itemDescriptionXrLabel.Text = "itemDescriptionXrLabel";
			this.itemDescriptionXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//XrLabel2
			//
			this.XrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "ItemCode")});
			this.XrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(100F, 0F);
			this.XrLabel2.Name = "XrLabel2";
			this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.XrLabel2.SizeF = new System.Drawing.SizeF(217F, 25F);
			this.XrLabel2.StylePriority.UseTextAlignment = false;
			this.XrLabel2.Text = "XrLabel2";
			this.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//DescriptionXRLabel
			//
			this.DescriptionXRLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
			this.DescriptionXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(317F, 0F);
			this.DescriptionXRLabel.Name = "DescriptionXRLabel";
			this.DescriptionXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.DescriptionXRLabel.SizeF = new System.Drawing.SizeF(100F, 25F);
			this.DescriptionXRLabel.StylePriority.UseFont = false;
			this.DescriptionXRLabel.StylePriority.UseTextAlignment = false;
			this.DescriptionXRLabel.Text = "Description";
			this.DescriptionXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//ItemXRLabel
			//
			this.ItemXRLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
			this.ItemXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(8F, 0F);
			this.ItemXRLabel.Name = "ItemXRLabel";
			this.ItemXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.ItemXRLabel.SizeF = new System.Drawing.SizeF(92F, 25F);
			this.ItemXRLabel.StylePriority.UseFont = false;
			this.ItemXRLabel.StylePriority.UseTextAlignment = false;
			this.ItemXRLabel.Text = "Item";
			this.ItemXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//itemGroupFooter
			//
			this.itemGroupFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.footerXrPanel});
			this.itemGroupFooter.HeightF = 30F;
			this.itemGroupFooter.Level = 1;
			this.itemGroupFooter.Name = "itemGroupFooter";
			//
			//footerXrPanel
			//
			this.footerXrPanel.BackColor = System.Drawing.Color.FromArgb((int)((byte)230), (int)((byte)235), (int)((byte)247));
			this.footerXrPanel.BorderColor = System.Drawing.Color.Black;
			this.footerXrPanel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.footerXrPanel.BorderWidth = 3F;
			this.footerXrPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.itemPriceXrLabel, this.itemPricePerPieceXrLabel, this.itemPackersVariationPercentageXrLabel, this.itemPackersVariationVolumeXrLabel, this.itemAverageActualPackersXrLabel, this.itemSpeedVariationPercentageXrLabel, this.itemSpeedVariationXrLabel, this.itemAverageSpeedXrLabel, this.itemProjectedSpeedXrLabel, this.itemQuantityXrLabel, this.itemMinutesXrLabel, this.itemTotalSalesXrLabel, this.itemSalesVsPayrollXrLabel, this.itemCostVariationPercentageXrLabel, this.itemCostVariationXrLabel, this.itemAverageCostXrLabel, this.itemProjectedCostXrLabel, this.itemProjectedPackersXrLabel});
			this.footerXrPanel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.footerXrPanel.Name = "footerXrPanel";
			this.footerXrPanel.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.footerXrPanel.SizeF = new System.Drawing.SizeF(1050F, 30F);
			//
			//itemPriceXrLabel
			//
			this.itemPriceXrLabel.CanGrow = false;
			this.itemPriceXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "Price", "{0:$0.00}")});
			this.itemPriceXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(940F, 0F);
			this.itemPriceXrLabel.Name = "itemPriceXrLabel";
			this.itemPriceXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.itemPriceXrLabel.SizeF = new System.Drawing.SizeF(55F, 30F);
			this.itemPriceXrLabel.StyleName = "footerXrControlStyle";
			this.itemPriceXrLabel.StylePriority.UseTextAlignment = false;
			this.itemPriceXrLabel.Text = "itemPriceXrLabel";
			this.itemPriceXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//itemPricePerPieceXrLabel
			//
			this.itemPricePerPieceXrLabel.CanGrow = false;
			this.itemPricePerPieceXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "pricePerPieceCalculatedField", "{0:$0.0000}")});
			this.itemPricePerPieceXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(830F, 0F);
			this.itemPricePerPieceXrLabel.Name = "itemPricePerPieceXrLabel";
			this.itemPricePerPieceXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.itemPricePerPieceXrLabel.SizeF = new System.Drawing.SizeF(55F, 30F);
			this.itemPricePerPieceXrLabel.StyleName = "footerXrControlStyle";
			this.itemPricePerPieceXrLabel.StylePriority.UseTextAlignment = false;
			this.itemPricePerPieceXrLabel.Text = "itemPricePerPieceXrLabel";
			this.itemPricePerPieceXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//itemPackersVariationPercentageXrLabel
			//
			this.itemPackersVariationPercentageXrLabel.CanGrow = false;
			this.itemPackersVariationPercentageXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(555F, 0F);
			this.itemPackersVariationPercentageXrLabel.Name = "itemPackersVariationPercentageXrLabel";
			this.itemPackersVariationPercentageXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.itemPackersVariationPercentageXrLabel.SizeF = new System.Drawing.SizeF(55F, 30F);
			this.itemPackersVariationPercentageXrLabel.StyleName = "footerXrControlStyle";
			this.itemPackersVariationPercentageXrLabel.Text = " ";
			this.itemPackersVariationPercentageXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemPackersVariationVolumeXrLabel
			//
			this.itemPackersVariationVolumeXrLabel.CanGrow = false;
			this.itemPackersVariationVolumeXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(500F, 0F);
			this.itemPackersVariationVolumeXrLabel.Name = "itemPackersVariationVolumeXrLabel";
			this.itemPackersVariationVolumeXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.itemPackersVariationVolumeXrLabel.SizeF = new System.Drawing.SizeF(55F, 30F);
			this.itemPackersVariationVolumeXrLabel.StyleName = "footerXrControlStyle";
			this.itemPackersVariationVolumeXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemAverageActualPackersXrLabel
			//
			this.itemAverageActualPackersXrLabel.CanGrow = false;
			this.itemAverageActualPackersXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(445F, 0F);
			this.itemAverageActualPackersXrLabel.Name = "itemAverageActualPackersXrLabel";
			this.itemAverageActualPackersXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.itemAverageActualPackersXrLabel.SizeF = new System.Drawing.SizeF(55F, 30F);
			this.itemAverageActualPackersXrLabel.StyleName = "footerXrControlStyle";
			this.itemAverageActualPackersXrLabel.Text = " ";
			this.itemAverageActualPackersXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemSpeedVariationPercentageXrLabel
			//
			this.itemSpeedVariationPercentageXrLabel.CanGrow = false;
			this.itemSpeedVariationPercentageXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(335F, 0F);
			this.itemSpeedVariationPercentageXrLabel.Name = "itemSpeedVariationPercentageXrLabel";
			this.itemSpeedVariationPercentageXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.itemSpeedVariationPercentageXrLabel.SizeF = new System.Drawing.SizeF(55F, 30F);
			this.itemSpeedVariationPercentageXrLabel.StyleName = "footerXrControlStyle";
			this.itemSpeedVariationPercentageXrLabel.Text = " ";
			this.itemSpeedVariationPercentageXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemSpeedVariationXrLabel
			//
			this.itemSpeedVariationXrLabel.CanGrow = false;
			this.itemSpeedVariationXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(280F, 0F);
			this.itemSpeedVariationXrLabel.Name = "itemSpeedVariationXrLabel";
			this.itemSpeedVariationXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.itemSpeedVariationXrLabel.SizeF = new System.Drawing.SizeF(55F, 30F);
			this.itemSpeedVariationXrLabel.StyleName = "footerXrControlStyle";
			this.itemSpeedVariationXrLabel.Text = " ";
			this.itemSpeedVariationXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemAverageSpeedXrLabel
			//
			this.itemAverageSpeedXrLabel.CanGrow = false;
			this.itemAverageSpeedXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(225F, 0F);
			this.itemAverageSpeedXrLabel.Name = "itemAverageSpeedXrLabel";
			this.itemAverageSpeedXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.itemAverageSpeedXrLabel.SizeF = new System.Drawing.SizeF(55F, 30F);
			this.itemAverageSpeedXrLabel.StyleName = "footerXrControlStyle";
			this.itemAverageSpeedXrLabel.Text = " ";
			this.itemAverageSpeedXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemProjectedSpeedXrLabel
			//
			this.itemProjectedSpeedXrLabel.CanGrow = false;
			this.itemProjectedSpeedXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(170F, 0F);
			this.itemProjectedSpeedXrLabel.Name = "itemProjectedSpeedXrLabel";
			this.itemProjectedSpeedXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.itemProjectedSpeedXrLabel.SizeF = new System.Drawing.SizeF(55F, 30F);
			this.itemProjectedSpeedXrLabel.StyleName = "footerXrControlStyle";
			this.itemProjectedSpeedXrLabel.Text = "itemProjectedSpeedXrLabel";
			this.itemProjectedSpeedXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemQuantityXrLabel
			//
			this.itemQuantityXrLabel.CanGrow = false;
			this.itemQuantityXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "Quantity")});
			this.itemQuantityXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(117F, 0F);
			this.itemQuantityXrLabel.Name = "itemQuantityXrLabel";
			this.itemQuantityXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.itemQuantityXrLabel.SizeF = new System.Drawing.SizeF(53F, 30F);
			this.itemQuantityXrLabel.StyleName = "footerXrControlStyle";
			XrSummary1.FormatString = "{0:#,#}";
			XrSummary1.IgnoreNullValues = true;
			XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
			this.itemQuantityXrLabel.Summary = XrSummary1;
			this.itemQuantityXrLabel.Text = "itemQuantityXrLabel";
			this.itemQuantityXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemMinutesXrLabel
			//
			this.itemMinutesXrLabel.CanGrow = false;
			this.itemMinutesXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(67F, 0F);
			this.itemMinutesXrLabel.Name = "itemMinutesXrLabel";
			this.itemMinutesXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.itemMinutesXrLabel.SizeF = new System.Drawing.SizeF(50F, 30F);
			this.itemMinutesXrLabel.StyleName = "footerXrControlStyle";
			this.itemMinutesXrLabel.Text = " ";
			this.itemMinutesXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemTotalSalesXrLabel
			//
			this.itemTotalSalesXrLabel.CanGrow = false;
			this.itemTotalSalesXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "totalSalesCalculatedField")});
			this.itemTotalSalesXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(995F, 0F);
			this.itemTotalSalesXrLabel.Name = "itemTotalSalesXrLabel";
			this.itemTotalSalesXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.itemTotalSalesXrLabel.SizeF = new System.Drawing.SizeF(55F, 30F);
			this.itemTotalSalesXrLabel.StyleName = "footerXrControlStyle";
			this.itemTotalSalesXrLabel.StylePriority.UseTextAlignment = false;
			XrSummary2.FormatString = "{0:$0.00}";
			XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
			this.itemTotalSalesXrLabel.Summary = XrSummary2;
			this.itemTotalSalesXrLabel.Text = "itemTotalSalesXrLabel";
			this.itemTotalSalesXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//itemSalesVsPayrollXrLabel
			//
			this.itemSalesVsPayrollXrLabel.CanGrow = false;
			this.itemSalesVsPayrollXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(885F, 0F);
			this.itemSalesVsPayrollXrLabel.Name = "itemSalesVsPayrollXrLabel";
			this.itemSalesVsPayrollXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.itemSalesVsPayrollXrLabel.SizeF = new System.Drawing.SizeF(55F, 30F);
			this.itemSalesVsPayrollXrLabel.StyleName = "footerXrControlStyle";
			this.itemSalesVsPayrollXrLabel.StylePriority.UseTextAlignment = false;
			this.itemSalesVsPayrollXrLabel.Text = " ";
			this.itemSalesVsPayrollXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//itemCostVariationPercentageXrLabel
			//
			this.itemCostVariationPercentageXrLabel.CanGrow = false;
			this.itemCostVariationPercentageXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(775F, 0F);
			this.itemCostVariationPercentageXrLabel.Name = "itemCostVariationPercentageXrLabel";
			this.itemCostVariationPercentageXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.itemCostVariationPercentageXrLabel.SizeF = new System.Drawing.SizeF(55F, 30F);
			this.itemCostVariationPercentageXrLabel.StyleName = "footerXrControlStyle";
			this.itemCostVariationPercentageXrLabel.Text = " ";
			this.itemCostVariationPercentageXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemCostVariationXrLabel
			//
			this.itemCostVariationXrLabel.CanGrow = false;
			this.itemCostVariationXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(720F, 0F);
			this.itemCostVariationXrLabel.Name = "itemCostVariationXrLabel";
			this.itemCostVariationXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.itemCostVariationXrLabel.SizeF = new System.Drawing.SizeF(55F, 30F);
			this.itemCostVariationXrLabel.StyleName = "footerXrControlStyle";
			this.itemCostVariationXrLabel.StylePriority.UseTextAlignment = false;
			this.itemCostVariationXrLabel.Text = " ";
			this.itemCostVariationXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//itemAverageCostXrLabel
			//
			this.itemAverageCostXrLabel.CanGrow = false;
			this.itemAverageCostXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(665F, 0F);
			this.itemAverageCostXrLabel.Name = "itemAverageCostXrLabel";
			this.itemAverageCostXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.itemAverageCostXrLabel.SizeF = new System.Drawing.SizeF(55F, 30F);
			this.itemAverageCostXrLabel.StyleName = "footerXrControlStyle";
			this.itemAverageCostXrLabel.StylePriority.UseTextAlignment = false;
			this.itemAverageCostXrLabel.Text = " ";
			this.itemAverageCostXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//itemProjectedCostXrLabel
			//
			this.itemProjectedCostXrLabel.CanGrow = false;
			this.itemProjectedCostXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(610F, 0F);
			this.itemProjectedCostXrLabel.Name = "itemProjectedCostXrLabel";
			this.itemProjectedCostXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.itemProjectedCostXrLabel.SizeF = new System.Drawing.SizeF(55F, 30F);
			this.itemProjectedCostXrLabel.StyleName = "footerXrControlStyle";
			this.itemProjectedCostXrLabel.StylePriority.UseTextAlignment = false;
			this.itemProjectedCostXrLabel.Text = " ";
			this.itemProjectedCostXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//itemProjectedPackersXrLabel
			//
			this.itemProjectedPackersXrLabel.CanGrow = false;
			this.itemProjectedPackersXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(390F, 0F);
			this.itemProjectedPackersXrLabel.Name = "itemProjectedPackersXrLabel";
			this.itemProjectedPackersXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.itemProjectedPackersXrLabel.SizeF = new System.Drawing.SizeF(55F, 30F);
			this.itemProjectedPackersXrLabel.StyleName = "footerXrControlStyle";
			this.itemProjectedPackersXrLabel.Text = "itemProjectedPackersXrLabel";
			this.itemProjectedPackersXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//machineGroupHeader
			//
			this.machineGroupHeader.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {new DevExpress.XtraReports.UI.GroupField("MachineName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
			this.machineGroupHeader.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage;
			this.machineGroupHeader.HeightF = 0F;
			this.machineGroupHeader.KeepTogether = true;
			this.machineGroupHeader.Name = "machineGroupHeader";
			//
			//machineGroupFooter
			//
			this.machineGroupFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.machineTotalSalesXrLabel, this.machinePriceXrLabel, this.machineSalesVsPayrollXrLabel, this.machinePricePerPieceXrLabel, this.machineCostVariationPercentageXrLabel, this.machineCostVariationXrLabel, this.machineAverageCostXrLabel, this.machineProjectedCostXrLabel, this.machinePackersVariationPercentageXrLabel, this.machinePackersVariationVolumeXrLabel, this.machineAverageActualPackersXrLabel, this.machineProjectedPackersXrLabel, this.machineSpeedVariationPercentageXrLabel, this.machineSpeedVariationVolumeXrLabel, this.machineAverageSpeedXRLabel, this.machineProjectedSpeedXrLabel, this.machineQuantityXrLabel, this.machineTotalMinutesXRLabel, this.XrLabel4});
			this.machineGroupFooter.HeightF = 25F;
			this.machineGroupFooter.Name = "machineGroupFooter";
			this.machineGroupFooter.StyleName = "detailEvenXrControlStyle";
			this.machineGroupFooter.StylePriority.UseTextAlignment = false;
			this.machineGroupFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//machineTotalSalesXrLabel
			//
			this.machineTotalSalesXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "totalSalesCalculatedField")});
			this.machineTotalSalesXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(995F, 0F);
			this.machineTotalSalesXrLabel.Name = "machineTotalSalesXrLabel";
			this.machineTotalSalesXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.machineTotalSalesXrLabel.SizeF = new System.Drawing.SizeF(55F, 25F);
			this.machineTotalSalesXrLabel.StylePriority.UseTextAlignment = false;
			XrSummary3.FormatString = "{0:$0.00}";
			XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
			this.machineTotalSalesXrLabel.Summary = XrSummary3;
			this.machineTotalSalesXrLabel.Text = "machineTotalSalesXrLabel";
			this.machineTotalSalesXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//machinePriceXrLabel
			//
			this.machinePriceXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "Price", "{0:$0.00}")});
			this.machinePriceXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(940F, 0F);
			this.machinePriceXrLabel.Name = "machinePriceXrLabel";
			this.machinePriceXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.machinePriceXrLabel.SizeF = new System.Drawing.SizeF(55F, 25F);
			this.machinePriceXrLabel.StylePriority.UseTextAlignment = false;
			this.machinePriceXrLabel.Text = "machinePriceXrLabel";
			this.machinePriceXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//machineSalesVsPayrollXrLabel
			//
			this.machineSalesVsPayrollXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(885F, 0F);
			this.machineSalesVsPayrollXrLabel.Name = "machineSalesVsPayrollXrLabel";
			this.machineSalesVsPayrollXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.machineSalesVsPayrollXrLabel.SizeF = new System.Drawing.SizeF(55F, 25F);
			this.machineSalesVsPayrollXrLabel.StylePriority.UseTextAlignment = false;
			this.machineSalesVsPayrollXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//machinePricePerPieceXrLabel
			//
			this.machinePricePerPieceXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "pricePerPieceCalculatedField", "{0:$0.0000}")});
			this.machinePricePerPieceXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(830F, 0F);
			this.machinePricePerPieceXrLabel.Name = "machinePricePerPieceXrLabel";
			this.machinePricePerPieceXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.machinePricePerPieceXrLabel.SizeF = new System.Drawing.SizeF(55F, 25F);
			this.machinePricePerPieceXrLabel.StylePriority.UseTextAlignment = false;
			this.machinePricePerPieceXrLabel.Text = "machinePricePerPieceXrLabel";
			this.machinePricePerPieceXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//machineCostVariationPercentageXrLabel
			//
			this.machineCostVariationPercentageXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(775F, 0F);
			this.machineCostVariationPercentageXrLabel.Name = "machineCostVariationPercentageXrLabel";
			this.machineCostVariationPercentageXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.machineCostVariationPercentageXrLabel.SizeF = new System.Drawing.SizeF(55F, 25F);
			//
			//machineCostVariationXrLabel
			//
			this.machineCostVariationXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(720F, 0F);
			this.machineCostVariationXrLabel.Name = "machineCostVariationXrLabel";
			this.machineCostVariationXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.machineCostVariationXrLabel.SizeF = new System.Drawing.SizeF(55F, 25F);
			this.machineCostVariationXrLabel.StylePriority.UseTextAlignment = false;
			this.machineCostVariationXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//machineAverageCostXrLabel
			//
			this.machineAverageCostXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(665F, 0F);
			this.machineAverageCostXrLabel.Name = "machineAverageCostXrLabel";
			this.machineAverageCostXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.machineAverageCostXrLabel.SizeF = new System.Drawing.SizeF(55F, 25F);
			this.machineAverageCostXrLabel.StylePriority.UseTextAlignment = false;
			this.machineAverageCostXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//machineProjectedCostXrLabel
			//
			this.machineProjectedCostXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(610F, 0F);
			this.machineProjectedCostXrLabel.Name = "machineProjectedCostXrLabel";
			this.machineProjectedCostXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.machineProjectedCostXrLabel.SizeF = new System.Drawing.SizeF(55F, 25F);
			this.machineProjectedCostXrLabel.StylePriority.UseTextAlignment = false;
			this.machineProjectedCostXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//machinePackersVariationPercentageXrLabel
			//
			this.machinePackersVariationPercentageXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(555F, 0F);
			this.machinePackersVariationPercentageXrLabel.Name = "machinePackersVariationPercentageXrLabel";
			this.machinePackersVariationPercentageXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.machinePackersVariationPercentageXrLabel.SizeF = new System.Drawing.SizeF(55F, 25F);
			//
			//machinePackersVariationVolumeXrLabel
			//
			this.machinePackersVariationVolumeXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(500F, 0F);
			this.machinePackersVariationVolumeXrLabel.Name = "machinePackersVariationVolumeXrLabel";
			this.machinePackersVariationVolumeXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.machinePackersVariationVolumeXrLabel.SizeF = new System.Drawing.SizeF(55F, 25F);
			//
			//machineAverageActualPackersXrLabel
			//
			this.machineAverageActualPackersXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(445F, 0F);
			this.machineAverageActualPackersXrLabel.Name = "machineAverageActualPackersXrLabel";
			this.machineAverageActualPackersXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.machineAverageActualPackersXrLabel.SizeF = new System.Drawing.SizeF(55F, 25F);
			//
			//machineProjectedPackersXrLabel
			//
			this.machineProjectedPackersXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(390F, 0F);
			this.machineProjectedPackersXrLabel.Name = "machineProjectedPackersXrLabel";
			this.machineProjectedPackersXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.machineProjectedPackersXrLabel.SizeF = new System.Drawing.SizeF(55F, 25F);
			this.machineProjectedPackersXrLabel.Text = "machineProjectedPackersXrLabel";
			//
			//machineSpeedVariationPercentageXrLabel
			//
			this.machineSpeedVariationPercentageXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(335F, 0F);
			this.machineSpeedVariationPercentageXrLabel.Name = "machineSpeedVariationPercentageXrLabel";
			this.machineSpeedVariationPercentageXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.machineSpeedVariationPercentageXrLabel.SizeF = new System.Drawing.SizeF(55F, 25F);
			//
			//machineSpeedVariationVolumeXrLabel
			//
			this.machineSpeedVariationVolumeXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(280F, 0F);
			this.machineSpeedVariationVolumeXrLabel.Name = "machineSpeedVariationVolumeXrLabel";
			this.machineSpeedVariationVolumeXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.machineSpeedVariationVolumeXrLabel.SizeF = new System.Drawing.SizeF(55F, 25F);
			//
			//machineAverageSpeedXRLabel
			//
			this.machineAverageSpeedXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(225F, 0F);
			this.machineAverageSpeedXRLabel.Name = "machineAverageSpeedXRLabel";
			this.machineAverageSpeedXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.machineAverageSpeedXRLabel.SizeF = new System.Drawing.SizeF(55F, 25F);
			//
			//machineProjectedSpeedXrLabel
			//
			this.machineProjectedSpeedXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(170F, 0F);
			this.machineProjectedSpeedXrLabel.Name = "machineProjectedSpeedXrLabel";
			this.machineProjectedSpeedXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.machineProjectedSpeedXrLabel.SizeF = new System.Drawing.SizeF(55F, 25F);
			this.machineProjectedSpeedXrLabel.Text = "machineProjectedSpeedXrLabel";
			//
			//machineQuantityXrLabel
			//
			this.machineQuantityXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "Quantity")});
			this.machineQuantityXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(117F, 0F);
			this.machineQuantityXrLabel.Name = "machineQuantityXrLabel";
			this.machineQuantityXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.machineQuantityXrLabel.SizeF = new System.Drawing.SizeF(53F, 25F);
			XrSummary4.FormatString = "{0:#,#}";
			XrSummary4.IgnoreNullValues = true;
			XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
			this.machineQuantityXrLabel.Summary = XrSummary4;
			this.machineQuantityXrLabel.Text = "machineQuantityXrLabel";
			//
			//machineTotalMinutesXRLabel
			//
			this.machineTotalMinutesXRLabel.LocationFloat = new DevExpress.Utils.PointFloat(67F, 0F);
			this.machineTotalMinutesXRLabel.Name = "machineTotalMinutesXRLabel";
			this.machineTotalMinutesXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.machineTotalMinutesXRLabel.SizeF = new System.Drawing.SizeF(50F, 25F);
			this.machineTotalMinutesXRLabel.StylePriority.UseTextAlignment = false;
			this.machineTotalMinutesXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel4
			//
			this.XrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "MachineName")});
			this.XrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.XrLabel4.Name = "XrLabel4";
			this.XrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.XrLabel4.SizeF = new System.Drawing.SizeF(67F, 25F);
			this.XrLabel4.Text = "XrLabel4";
			//
			//pricePerPieceCalculatedField
			//
			this.pricePerPieceCalculatedField.Expression = "[Price] / [QtyPerUnit]";
			this.pricePerPieceCalculatedField.Name = "pricePerPieceCalculatedField";
			//
			//productionXPView
			//
			this.productionXPView.ObjectType = typeof(DXDAL.SPGData.Production);
			this.productionXPView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("CustomerName", DevExpress.Xpo.SortDirection.Ascending, "[ProdMainItemID.ItemCustomerID.CustomerName]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.Ascending, "[ProdMainItemID.ItemCode]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemDescription", DevExpress.Xpo.SortDirection.None, "[ProdMainItemID.ItemDescription]", false, true),
				new DevExpress.Xpo.ViewProperty("MachineName", DevExpress.Xpo.SortDirection.Ascending, "[ProdMainMachineLine.MachineLineName]", false, true),
				new DevExpress.Xpo.ViewProperty("TimeStart", DevExpress.Xpo.SortDirection.None, "[ProdMainTimeStart]", false, true),
				new DevExpress.Xpo.ViewProperty("TimeStop", DevExpress.Xpo.SortDirection.None, "[ProdMainTimeStop]", false, true),
				new DevExpress.Xpo.ViewProperty("ProductionDate", DevExpress.Xpo.SortDirection.None, "[ProdMainDate]", false, true),
				new DevExpress.Xpo.ViewProperty("Quantity", DevExpress.Xpo.SortDirection.None, "[ProdMainQuantity]", false, true),
				new DevExpress.Xpo.ViewProperty("ProjectedSpeed", DevExpress.Xpo.SortDirection.None, "[ProdMainItemID.ItemProdStandard]", false, true),
				new DevExpress.Xpo.ViewProperty("QtyPerUnit", DevExpress.Xpo.SortDirection.None, "[ProdMainItemID.intQtyPerUnit]", false, true),
				new DevExpress.Xpo.ViewProperty("ProjectedPackers", DevExpress.Xpo.SortDirection.None, "[ProdMainItemID.Packers]", false, true),
				new DevExpress.Xpo.ViewProperty("ProductionPackers", DevExpress.Xpo.SortDirection.None, "[ProdMainPackers]", false, true),
				new DevExpress.Xpo.ViewProperty("Price", DevExpress.Xpo.SortDirection.None, "[ProdMainItemID.dblPrice]", false, true),
				new DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[ProdMainItemID.ItemCustomerID]", false, true),
				new DevExpress.Xpo.ViewProperty("MachineLineID", DevExpress.Xpo.SortDirection.None, "[ProdMainMachineLine.MachineLineID]", false, true),
				new DevExpress.Xpo.ViewProperty("InactiveCustomer", DevExpress.Xpo.SortDirection.None, "[ProdMainItemID.ItemCustomerID.Inactive]", false, true),
				new DevExpress.Xpo.ViewProperty("InactiveItem", DevExpress.Xpo.SortDirection.None, "[ProdMainItemID.Inactive]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[ProdMainItemID.ItemID]", false, true),
				new DevExpress.Xpo.ViewProperty("ProductionID", DevExpress.Xpo.SortDirection.None, "[ProdMainID]", false, true)
			});
			//
			//totalSalesCalculatedField
			//
			this.totalSalesCalculatedField.Expression = "[Price] * [Quantity]";
			this.totalSalesCalculatedField.Name = "totalSalesCalculatedField";
			//
			//TopMarginBand1
			//
			this.TopMarginBand1.HeightF = 50F;
			this.TopMarginBand1.Name = "TopMarginBand1";
			//
			//BottomMarginBand1
			//
			this.BottomMarginBand1.HeightF = 50F;
			this.BottomMarginBand1.Name = "BottomMarginBand1";
			//
			//customerGroupFooter
			//
			this.customerGroupFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrPanel1});
			this.customerGroupFooter.GroupUnion = DevExpress.XtraReports.UI.GroupFooterUnion.WithLastDetail;
			this.customerGroupFooter.HeightF = 30F;
			this.customerGroupFooter.KeepTogether = true;
			this.customerGroupFooter.Level = 2;
			this.customerGroupFooter.Name = "customerGroupFooter";
			//
			//XrPanel1
			//
			this.XrPanel1.BackColor = System.Drawing.Color.FromArgb((int)((byte)230), (int)((byte)235), (int)((byte)247));
			this.XrPanel1.BorderColor = System.Drawing.Color.Black;
			this.XrPanel1.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrPanel1.BorderWidth = 3F;
			this.XrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel3, this.customerPackersVariationPercentageXrLabel, this.customerSpeedVariationPercentageXrLabel, this.customerCostVariationPercentageXrLabel});
			this.XrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.XrPanel1.Name = "XrPanel1";
			this.XrPanel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.XrPanel1.SizeF = new System.Drawing.SizeF(1050F, 30F);
			//
			//XrLabel3
			//
			this.XrLabel3.BorderColor = System.Drawing.Color.FromArgb((int)((byte)194), (int)((byte)202), (int)((byte)213));
			this.XrLabel3.BorderWidth = 1F;
			this.XrLabel3.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.XrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(17.00001F, 0F);
			this.XrLabel3.Name = "XrLabel3";
			this.XrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.XrLabel3.SizeF = new System.Drawing.SizeF(100F, 30F);
			this.XrLabel3.StylePriority.UseBorderColor = false;
			this.XrLabel3.StylePriority.UseBorderWidth = false;
			this.XrLabel3.StylePriority.UseFont = false;
			this.XrLabel3.StylePriority.UseTextAlignment = false;
			this.XrLabel3.Text = "Customer Total";
			this.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//customerPackersVariationPercentageXrLabel
			//
			this.customerPackersVariationPercentageXrLabel.CanGrow = false;
			this.customerPackersVariationPercentageXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(555F, 0F);
			this.customerPackersVariationPercentageXrLabel.Name = "customerPackersVariationPercentageXrLabel";
			this.customerPackersVariationPercentageXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.customerPackersVariationPercentageXrLabel.SizeF = new System.Drawing.SizeF(55F, 30F);
			this.customerPackersVariationPercentageXrLabel.StyleName = "footerXrControlStyle";
			this.customerPackersVariationPercentageXrLabel.Text = " ";
			this.customerPackersVariationPercentageXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//customerSpeedVariationPercentageXrLabel
			//
			this.customerSpeedVariationPercentageXrLabel.CanGrow = false;
			this.customerSpeedVariationPercentageXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(335F, 0F);
			this.customerSpeedVariationPercentageXrLabel.Name = "customerSpeedVariationPercentageXrLabel";
			this.customerSpeedVariationPercentageXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.customerSpeedVariationPercentageXrLabel.SizeF = new System.Drawing.SizeF(55F, 30F);
			this.customerSpeedVariationPercentageXrLabel.StyleName = "footerXrControlStyle";
			this.customerSpeedVariationPercentageXrLabel.Text = " ";
			this.customerSpeedVariationPercentageXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//customerCostVariationPercentageXrLabel
			//
			this.customerCostVariationPercentageXrLabel.CanGrow = false;
			this.customerCostVariationPercentageXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(775F, 0F);
			this.customerCostVariationPercentageXrLabel.Name = "customerCostVariationPercentageXrLabel";
			this.customerCostVariationPercentageXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.customerCostVariationPercentageXrLabel.SizeF = new System.Drawing.SizeF(55F, 30F);
			this.customerCostVariationPercentageXrLabel.StyleName = "footerXrControlStyle";
			this.customerCostVariationPercentageXrLabel.Text = " ";
			this.customerCostVariationPercentageXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//ReportFooter
			//
			this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrPanel2});
			this.ReportFooter.HeightF = 30F;
			this.ReportFooter.Name = "ReportFooter";
			//
			//XrPanel2
			//
			this.XrPanel2.BackColor = System.Drawing.Color.FromArgb((int)((byte)230), (int)((byte)235), (int)((byte)247));
			this.XrPanel2.BorderColor = System.Drawing.Color.Black;
			this.XrPanel2.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrPanel2.BorderWidth = 3F;
			this.XrPanel2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel5, this.reportPackersVariationPercentageXrLabel, this.reportSpeedVariationPercentageXrLabel, this.reportCostVariationPercentageXrLabel});
			this.XrPanel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.XrPanel2.Name = "XrPanel2";
			this.XrPanel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.XrPanel2.SizeF = new System.Drawing.SizeF(1050F, 30F);
			//
			//XrLabel5
			//
			this.XrLabel5.BorderColor = System.Drawing.Color.FromArgb((int)((byte)194), (int)((byte)202), (int)((byte)213));
			this.XrLabel5.BorderWidth = 1F;
			this.XrLabel5.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.XrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(17.00001F, 0F);
			this.XrLabel5.Name = "XrLabel5";
			this.XrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.XrLabel5.SizeF = new System.Drawing.SizeF(100F, 30F);
			this.XrLabel5.StylePriority.UseBorderColor = false;
			this.XrLabel5.StylePriority.UseBorderWidth = false;
			this.XrLabel5.StylePriority.UseFont = false;
			this.XrLabel5.StylePriority.UseTextAlignment = false;
			this.XrLabel5.Text = "Report Total";
			this.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//reportPackersVariationPercentageXrLabel
			//
			this.reportPackersVariationPercentageXrLabel.CanGrow = false;
			this.reportPackersVariationPercentageXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(555F, 0F);
			this.reportPackersVariationPercentageXrLabel.Name = "reportPackersVariationPercentageXrLabel";
			this.reportPackersVariationPercentageXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.reportPackersVariationPercentageXrLabel.SizeF = new System.Drawing.SizeF(55F, 30F);
			this.reportPackersVariationPercentageXrLabel.StyleName = "footerXrControlStyle";
			this.reportPackersVariationPercentageXrLabel.Text = " ";
			this.reportPackersVariationPercentageXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//reportSpeedVariationPercentageXrLabel
			//
			this.reportSpeedVariationPercentageXrLabel.CanGrow = false;
			this.reportSpeedVariationPercentageXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(335F, 0F);
			this.reportSpeedVariationPercentageXrLabel.Name = "reportSpeedVariationPercentageXrLabel";
			this.reportSpeedVariationPercentageXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.reportSpeedVariationPercentageXrLabel.SizeF = new System.Drawing.SizeF(55F, 30F);
			this.reportSpeedVariationPercentageXrLabel.StyleName = "footerXrControlStyle";
			this.reportSpeedVariationPercentageXrLabel.Text = " ";
			this.reportSpeedVariationPercentageXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//reportCostVariationPercentageXrLabel
			//
			this.reportCostVariationPercentageXrLabel.CanGrow = false;
			this.reportCostVariationPercentageXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(775F, 0F);
			this.reportCostVariationPercentageXrLabel.Name = "reportCostVariationPercentageXrLabel";
			this.reportCostVariationPercentageXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.reportCostVariationPercentageXrLabel.SizeF = new System.Drawing.SizeF(55F, 30F);
			this.reportCostVariationPercentageXrLabel.StyleName = "footerXrControlStyle";
			this.reportCostVariationPercentageXrLabel.Text = " ";
			this.reportCostVariationPercentageXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//ProductionMachineXtraReport
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.PageHeader, this.PageFooter, this.ReportHeader, this.customerGroupHeader, this.itemGroupHeader, this.itemGroupFooter, this.machineGroupHeader, this.machineGroupFooter, this.TopMarginBand1, this.BottomMarginBand1, this.customerGroupFooter, this.ReportFooter});
			this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {this.pricePerPieceCalculatedField, this.totalSalesCalculatedField});
			this.DataSource = this.productionXPView;
			this.Landscape = true;
			this.Margins = new System.Drawing.Printing.Margins(25, 25, 50, 50);
			this.PageHeight = 850;
			this.PageWidth = 1100;
			this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {this.headerXrControlStyle, this.footerXrControlStyle, this.detailOddXrControlStyle, this.detailEvenXrControlStyle});
			this.Version = "15.1";
			((System.ComponentModel.ISupportInitialize)this.productionXPView).EndInit();
			((System.ComponentModel.ISupportInitialize)this).EndInit();

//INSTANT C# NOTE: Converted design-time event handler wireups:
		machineGroupHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(machineGroupHeader_BeforePrint);
		itemGroupHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(itemGroupHeader_BeforePrint);
		customerGroupHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(customerGroupHeader_BeforePrint);
		Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(Detail_BeforePrint);
		base.BeforePrint += new System.Drawing.Printing.PrintEventHandler(ProductionMachineXtraReport_BeforePrint);
		machineTotalMinutesXRLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(machineTotalMinutesXRLabel_BeforePrint);
		itemMinutesXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(itemMinutesXrLabel_BeforePrint);
		machineAverageSpeedXRLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(machineAverageSpeedXRLabel_BeforePrint);
		itemAverageSpeedXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(itemAverageSpeedXrLabel_BeforePrint);
		machineSpeedVariationVolumeXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(machineSpeedVariationVolumeXrLabel_BeforePrint);
		itemSpeedVariationXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(itemSpeedVariationXrLabel_BeforePrint);
		itemSpeedVariationPercentageXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(itemSpeedVariationPercentageXrLabel_BeforePrint);
		machineSpeedVariationPercentageXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(machineSpeedVariationPercentageXrLabel_BeforePrint);
		customerSpeedVariationPercentageXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(customerSpeedVariationPercentageXrLabel_BeforePrint);
		reportSpeedVariationPercentageXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(companySpeedVariationPercentageXrLabel_BeforePrint);
		machineAverageActualPackersXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(machineAverageActualPackersXrLabel_BeforePrint);
		machinePackersVariationVolumeXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(machinePackersVariationVolumeXrLabel_BeforePrint);
		machinePackersVariationPercentageXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(machinePackersVariationPercentageXrLabel_BeforePrint);
		itemAverageActualPackersXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(itemAverageActualPackersXrLabel_BeforePrint);
		itemPackersVariationVolumeXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(itemPackersVariationVolumeXrLabel_BeforePrint);
		itemPackersVariationPercentageXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(itemPackersVariationPercentageXrLabel_BeforePrint);
		customerPackersVariationPercentageXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(customerPackersVariationPercentageXrLabel_BeforePrint);
		reportPackersVariationPercentageXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(reportPackersVariationPercentageXrLabel_BeforePrint);
		machineProjectedCostXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(machineProjectedCostXrLabel_BeforePrint);
		machineAverageCostXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(machineAverageCostXrLabel_BeforePrint);
		machineCostVariationXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(machineCostVariationXrLabel_BeforePrint);
		machineCostVariationPercentageXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(machineCostVariationPercentageXrLabel_BeforePrint);
		itemProjectedCostXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(itemProjectedCostXrLabel_BeforePrint);
		itemAverageCostXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(itemAverageCostXrLabel_BeforePrint);
		itemCostVariationXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(itemCostVariationXrLabel_BeforePrint);
		itemCostVariationPercentageXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(itemCostVariationPercentageXrLabel_BeforePrint);
		customerCostVariationPercentageXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(customerCostVariationPercentageXrLabel_BeforePrint);
		reportCostVariationPercentageXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(reportCostVariationPercentageXrLabel_BeforePrint);
		machineSalesVsPayrollXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(machineSalesVsPayrollXrLabel_BeforePrint);
		itemSalesVsPayrollXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(itemSalesVsPayrollXrLabel_BeforePrint);
		ReportHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(ReportHeader_BeforePrint);
		itemProjectedSpeedXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(itemProjectedSpeedXrLabel_BeforePrint);
		machineProjectedSpeedXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(machineProjectedSpeedXrLabel_BeforePrint);
		itemProjectedPackersXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(itemProjectedPackersXrLabel_BeforePrint);
		machineProjectedPackersXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(machineProjectedPackersXrLabel_BeforePrint);
	}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
		internal DevExpress.XtraReports.UI.PageFooterBand PageFooter;
		internal DevExpress.XtraReports.UI.XRControlStyle headerXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle footerXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle detailOddXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle detailEvenXrControlStyle;
		internal DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		internal DevExpress.XtraReports.UI.GroupHeaderBand customerGroupHeader;
		internal DevExpress.XtraReports.UI.GroupHeaderBand itemGroupHeader;
		internal DevExpress.XtraReports.UI.GroupFooterBand itemGroupFooter;
		internal DevExpress.Xpo.XPView productionXPView;
		internal DevExpress.XtraReports.UI.GroupHeaderBand machineGroupHeader;
		internal DevExpress.XtraReports.UI.GroupFooterBand machineGroupFooter;
		internal DevExpress.XtraReports.UI.XRPageInfo printDateXrPageInfo;
		internal DevExpress.XtraReports.UI.XRLabel reportCriteriaXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel reportTitleXrLabel;
		internal DevExpress.XtraReports.UI.XRPanel headerXrPanel;
		internal DevExpress.XtraReports.UI.XRLabel totalSalesHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel packersHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel priceHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel salesVsPayrollHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel machineSpeedHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel pricePerPieceHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel costVariationPercentageHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel costVariationHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel quantityHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel projectedCostHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel packersVariationPercentageHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel packersVariationVolumeHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel projectedPackersHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel speedVariationPercentageHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel speedVariationVolumeHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel averageSpeedHeadeerXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel averageActualCostHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel minutesHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel machineHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel CustomerNameXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
		internal DevExpress.XtraReports.UI.XRLabel itemDescriptionXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
		internal DevExpress.XtraReports.UI.XRLabel DescriptionXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel ItemXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel4;
		internal DevExpress.XtraReports.UI.XRLabel machineTotalMinutesXRLabel;
		internal DevExpress.XtraReports.UI.XRPanel footerXrPanel;
		internal DevExpress.XtraReports.UI.XRLabel itemMinutesXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemTotalSalesXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemSalesVsPayrollXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemCostVariationPercentageXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemCostVariationXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemAverageCostXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemProjectedCostXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemQuantityXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel machineQuantityXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel machineProjectedSpeedXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemProjectedSpeedXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel machineAverageSpeedXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemAverageSpeedXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemSpeedVariationXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel machineSpeedVariationVolumeXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemSpeedVariationPercentageXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel machineSpeedVariationPercentageXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel machinePackersVariationPercentageXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel machinePackersVariationVolumeXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel machineAverageActualPackersXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel machineProjectedPackersXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemPackersVariationPercentageXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemPackersVariationVolumeXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemAverageActualPackersXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel machineCostVariationPercentageXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel machineCostVariationXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel machineAverageCostXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel machineProjectedCostXrLabel;
		internal DevExpress.XtraReports.UI.CalculatedField pricePerPieceCalculatedField;
		internal DevExpress.XtraReports.UI.XRLabel itemPricePerPieceXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel machinePricePerPieceXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel machineSalesVsPayrollXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemPriceXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel machinePriceXrLabel;
		internal DevExpress.XtraReports.UI.CalculatedField totalSalesCalculatedField;
		internal DevExpress.XtraReports.UI.XRLabel machineTotalSalesXrLabel;
		internal DevExpress.XtraReports.UI.XRPageInfo pageNumberXrPageInfo;
		internal DevExpress.XtraReports.UI.XRLine itemHeaderXRLine;
		internal DevExpress.XtraReports.UI.XRLabel itemProjectedPackersXrLabel;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMarginBand1;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMarginBand1;
		internal DevExpress.XtraReports.UI.GroupFooterBand customerGroupFooter;
		internal DevExpress.XtraReports.UI.XRPanel XrPanel1;
		internal DevExpress.XtraReports.UI.XRLabel customerPackersVariationPercentageXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel customerSpeedVariationPercentageXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel customerCostVariationPercentageXrLabel;
		internal DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
		internal DevExpress.XtraReports.UI.XRPanel XrPanel2;
		internal DevExpress.XtraReports.UI.XRLabel reportPackersVariationPercentageXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel reportSpeedVariationPercentageXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel reportCostVariationPercentageXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel3;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel5;
	}

}