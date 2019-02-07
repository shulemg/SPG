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
	public partial class ProductionXtraReport : DevExpress.XtraReports.UI.XtraReport
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
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.packersDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.projectedPackersDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.totalPayrollDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.poDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.actualSpeedDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.machineSpeedDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
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
			this.totalPayrollHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.projectedPackersHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.packersHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.poHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.actualSpeedHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.machineSpeedHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.machineLineHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.differenceHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.expectedHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.quantityHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.totalMinutesHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.totalHoursHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.stopTimeHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.startTimeHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemDescriptionHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemCodeHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.lotHeadeerXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.customerNameHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.shiftHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.dateHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
			this.pageNumberXrPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.printDateXrPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
			this.reportCriteriaXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.reportTitleXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
			this.footerXrPanel = new DevExpress.XtraReports.UI.XRPanel();
			this.totalPayrollFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.actualSpeedFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.differenceFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.expectedFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.quantityFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.totalHoursFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.headerXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.footerXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.detailOddXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.detailEvenXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.TopMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.uomHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.uomDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.reasonCodeHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.reasonCodeDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			((System.ComponentModel.ISupportInitialize)this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.reasonCodeDetailXrLabel, this.uomDetailXrLabel, this.packersDetailXrLabel, this.projectedPackersDetailXrLabel, this.totalPayrollDetailXrLabel, this.poDetailXrLabel, this.actualSpeedDetailXrLabel, this.machineSpeedDetailXrLabel, this.machineLineDetailXrLabel, this.differenceDetailXrLabel, this.expectedDetailXrLabel, this.quantityDetailXrLabel, this.totalMinutesDetailXrLabel, this.totalHoursDetailXrLabel, this.stopTimeDetailXrLabel, this.startTimeDetailXrLabel, this.itemDescriptionDetailXrLabel, this.itemCodeDetailXrLabel, this.lotDetailXrLabel, this.customerNameDetailXrLabel, this.shiftDetailXrLabel, this.dateDetailXrLabel});
			this.Detail.HeightF = 30F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//packersDetailXrLabel
			//
			this.packersDetailXrLabel.CanGrow = false;
			this.packersDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.packersDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(989F, 0F);
			this.packersDetailXrLabel.Name = "packersDetailXrLabel";
			this.packersDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.packersDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.packersDetailXrLabel.SizeF = new System.Drawing.SizeF(35F, 30F);
			this.packersDetailXrLabel.Text = "packersDetailXrLabel";
			this.packersDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//projectedPackersDetailXrLabel
			//
			this.projectedPackersDetailXrLabel.CanGrow = false;
			this.projectedPackersDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.projectedPackersDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1024F, 0F);
			this.projectedPackersDetailXrLabel.Name = "projectedPackersDetailXrLabel";
			this.projectedPackersDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.projectedPackersDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.projectedPackersDetailXrLabel.SizeF = new System.Drawing.SizeF(51F, 30F);
			this.projectedPackersDetailXrLabel.Text = "projectedPackersDetailXrLabel";
			this.projectedPackersDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//totalPayrollDetailXrLabel
			//
			this.totalPayrollDetailXrLabel.CanGrow = false;
			this.totalPayrollDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.totalPayrollDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1160F, 0F);
			this.totalPayrollDetailXrLabel.Name = "totalPayrollDetailXrLabel";
			this.totalPayrollDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.totalPayrollDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.totalPayrollDetailXrLabel.SizeF = new System.Drawing.SizeF(50F, 30F);
			this.totalPayrollDetailXrLabel.Text = "totalPayrollDetailXrLabel";
			this.totalPayrollDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//poDetailXrLabel
			//
			this.poDetailXrLabel.CanGrow = false;
			this.poDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.poDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(954F, 0F);
			this.poDetailXrLabel.Name = "poDetailXrLabel";
			this.poDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.poDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.poDetailXrLabel.SizeF = new System.Drawing.SizeF(35F, 30F);
			this.poDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.poDetailXrLabel.Text = "poDetailXrLabel";
			this.poDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//actualSpeedDetailXrLabel
			//
			this.actualSpeedDetailXrLabel.CanGrow = false;
			this.actualSpeedDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.actualSpeedDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(919F, 0F);
			this.actualSpeedDetailXrLabel.Name = "actualSpeedDetailXrLabel";
			this.actualSpeedDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.actualSpeedDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.actualSpeedDetailXrLabel.SizeF = new System.Drawing.SizeF(35F, 30F);
			this.actualSpeedDetailXrLabel.Text = "actualSpeedDetailXrLabel";
			this.actualSpeedDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//machineSpeedDetailXrLabel
			//
			this.machineSpeedDetailXrLabel.CanGrow = false;
			this.machineSpeedDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.machineSpeedDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(865F, 0F);
			this.machineSpeedDetailXrLabel.Name = "machineSpeedDetailXrLabel";
			this.machineSpeedDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.machineSpeedDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.machineSpeedDetailXrLabel.SizeF = new System.Drawing.SizeF(54F, 30F);
			this.machineSpeedDetailXrLabel.Text = "machineSpeedDetailXrLabel";
			this.machineSpeedDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//machineLineDetailXrLabel
			//
			this.machineLineDetailXrLabel.CanGrow = false;
			this.machineLineDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.machineLineDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(815F, 0F);
			this.machineLineDetailXrLabel.Name = "machineLineDetailXrLabel";
			this.machineLineDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.machineLineDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.machineLineDetailXrLabel.SizeF = new System.Drawing.SizeF(50F, 30F);
			this.machineLineDetailXrLabel.Text = "machineLineDetailXrLabel";
			this.machineLineDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//differenceDetailXrLabel
			//
			this.differenceDetailXrLabel.CanGrow = false;
			this.differenceDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.differenceDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(775F, 0F);
			this.differenceDetailXrLabel.Name = "differenceDetailXrLabel";
			this.differenceDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.differenceDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.differenceDetailXrLabel.SizeF = new System.Drawing.SizeF(40F, 30F);
			this.differenceDetailXrLabel.Text = "differenceDetailXrLabel";
			this.differenceDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//expectedDetailXrLabel
			//
			this.expectedDetailXrLabel.CanGrow = false;
			this.expectedDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.expectedDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(740F, 0F);
			this.expectedDetailXrLabel.Name = "expectedDetailXrLabel";
			this.expectedDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.expectedDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.expectedDetailXrLabel.SizeF = new System.Drawing.SizeF(35F, 30F);
			this.expectedDetailXrLabel.Text = "expectedDetailXrLabel";
			this.expectedDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//quantityDetailXrLabel
			//
			this.quantityDetailXrLabel.CanGrow = false;
			this.quantityDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.quantityDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(660F, 0F);
			this.quantityDetailXrLabel.Name = "quantityDetailXrLabel";
			this.quantityDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.quantityDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.quantityDetailXrLabel.SizeF = new System.Drawing.SizeF(40F, 30F);
			this.quantityDetailXrLabel.Text = "quantityDetailXrLabel";
			this.quantityDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//totalMinutesDetailXrLabel
			//
			this.totalMinutesDetailXrLabel.CanGrow = false;
			this.totalMinutesDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.totalMinutesDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(615F, 0F);
			this.totalMinutesDetailXrLabel.Name = "totalMinutesDetailXrLabel";
			this.totalMinutesDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.totalMinutesDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.totalMinutesDetailXrLabel.SizeF = new System.Drawing.SizeF(45F, 30F);
			this.totalMinutesDetailXrLabel.Text = "totalMinutesDetailXrLabel";
			this.totalMinutesDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//totalHoursDetailXrLabel
			//
			this.totalHoursDetailXrLabel.CanGrow = false;
			this.totalHoursDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.totalHoursDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(565F, 0F);
			this.totalHoursDetailXrLabel.Name = "totalHoursDetailXrLabel";
			this.totalHoursDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.totalHoursDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.totalHoursDetailXrLabel.SizeF = new System.Drawing.SizeF(50F, 30F);
			this.totalHoursDetailXrLabel.Text = "totalHoursDetailXrLabel";
			this.totalHoursDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//stopTimeDetailXrLabel
			//
			this.stopTimeDetailXrLabel.CanGrow = false;
			this.stopTimeDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.stopTimeDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(510F, 0F);
			this.stopTimeDetailXrLabel.Name = "stopTimeDetailXrLabel";
			this.stopTimeDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.stopTimeDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.stopTimeDetailXrLabel.SizeF = new System.Drawing.SizeF(55F, 30F);
			this.stopTimeDetailXrLabel.Text = "stopTimeDetailXrLabel";
			this.stopTimeDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//startTimeDetailXrLabel
			//
			this.startTimeDetailXrLabel.CanGrow = false;
			this.startTimeDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.startTimeDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(455F, 0F);
			this.startTimeDetailXrLabel.Name = "startTimeDetailXrLabel";
			this.startTimeDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.startTimeDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.startTimeDetailXrLabel.SizeF = new System.Drawing.SizeF(55F, 30F);
			this.startTimeDetailXrLabel.Text = "startTimeDetailXrLabel";
			this.startTimeDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemDescriptionDetailXrLabel
			//
			this.itemDescriptionDetailXrLabel.CanGrow = false;
			this.itemDescriptionDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.itemDescriptionDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(305F, 0F);
			this.itemDescriptionDetailXrLabel.Name = "itemDescriptionDetailXrLabel";
			this.itemDescriptionDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.itemDescriptionDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.itemDescriptionDetailXrLabel.SizeF = new System.Drawing.SizeF(150F, 30F);
			this.itemDescriptionDetailXrLabel.Text = "itemDescriptionDetailXrLabel";
			this.itemDescriptionDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//itemCodeDetailXrLabel
			//
			this.itemCodeDetailXrLabel.CanGrow = false;
			this.itemCodeDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.itemCodeDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(245F, 0F);
			this.itemCodeDetailXrLabel.Name = "itemCodeDetailXrLabel";
			this.itemCodeDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.itemCodeDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.itemCodeDetailXrLabel.SizeF = new System.Drawing.SizeF(60F, 30F);
			this.itemCodeDetailXrLabel.Text = "itemCodeDetailXrLabel";
			this.itemCodeDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//lotDetailXrLabel
			//
			this.lotDetailXrLabel.CanGrow = false;
			this.lotDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.lotDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(195F, 0F);
			this.lotDetailXrLabel.Name = "lotDetailXrLabel";
			this.lotDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.lotDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lotDetailXrLabel.SizeF = new System.Drawing.SizeF(50F, 30F);
			this.lotDetailXrLabel.Text = "lotDetailXrLabel";
			this.lotDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//customerNameDetailXrLabel
			//
			this.customerNameDetailXrLabel.CanGrow = false;
			this.customerNameDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.customerNameDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(110F, 0F);
			this.customerNameDetailXrLabel.Name = "customerNameDetailXrLabel";
			this.customerNameDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.customerNameDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.customerNameDetailXrLabel.SizeF = new System.Drawing.SizeF(85F, 30F);
			this.customerNameDetailXrLabel.Text = "customerNameDetailXrLabel";
			this.customerNameDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//shiftDetailXrLabel
			//
			this.shiftDetailXrLabel.CanGrow = false;
			this.shiftDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.shiftDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(60F, 0F);
			this.shiftDetailXrLabel.Name = "shiftDetailXrLabel";
			this.shiftDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.shiftDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.shiftDetailXrLabel.SizeF = new System.Drawing.SizeF(50F, 30F);
			this.shiftDetailXrLabel.Text = "shiftDetailXrLabel";
			this.shiftDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//dateDetailXrLabel
			//
			this.dateDetailXrLabel.CanGrow = false;
			this.dateDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.dateDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.dateDetailXrLabel.Name = "dateDetailXrLabel";
			this.dateDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.dateDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.dateDetailXrLabel.SizeF = new System.Drawing.SizeF(60F, 30F);
			this.dateDetailXrLabel.Text = "dateDetailXrLabel";
			this.dateDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
			this.headerXrPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.reasonCodeHeaderXrLabel, this.uomHeaderXrLabel, this.totalPayrollHeaderXrLabel, this.projectedPackersHeaderXrLabel, this.packersHeaderXrLabel, this.poHeaderXrLabel, this.actualSpeedHeaderXrLabel, this.machineSpeedHeaderXrLabel, this.machineLineHeaderXrLabel, this.differenceHeaderXrLabel, this.expectedHeaderXrLabel, this.quantityHeaderXrLabel, this.totalMinutesHeaderXrLabel, this.totalHoursHeaderXrLabel, this.stopTimeHeaderXrLabel, this.startTimeHeaderXrLabel, this.itemDescriptionHeaderXrLabel, this.itemCodeHeaderXrLabel, this.lotHeadeerXrLabel, this.customerNameHeaderXrLabel, this.shiftHeaderXrLabel, this.dateHeaderXrLabel});
			this.headerXrPanel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.headerXrPanel.Name = "headerXrPanel";
			this.headerXrPanel.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.headerXrPanel.SizeF = new System.Drawing.SizeF(1650F, 50F);
			//
			//totalPayrollHeaderXrLabel
			//
			this.totalPayrollHeaderXrLabel.CanGrow = false;
			this.totalPayrollHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1160F, 0F);
			this.totalPayrollHeaderXrLabel.Name = "totalPayrollHeaderXrLabel";
			this.totalPayrollHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.totalPayrollHeaderXrLabel.SizeF = new System.Drawing.SizeF(50F, 50F);
			this.totalPayrollHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.totalPayrollHeaderXrLabel.Text = "Total Payroll";
			this.totalPayrollHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//projectedPackersHeaderXrLabel
			//
			this.projectedPackersHeaderXrLabel.CanGrow = false;
			this.projectedPackersHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1024F, 0F);
			this.projectedPackersHeaderXrLabel.Name = "projectedPackersHeaderXrLabel";
			this.projectedPackersHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.projectedPackersHeaderXrLabel.SizeF = new System.Drawing.SizeF(51F, 50F);
			this.projectedPackersHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.projectedPackersHeaderXrLabel.Text = "Projected Packers";
			this.projectedPackersHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//packersHeaderXrLabel
			//
			this.packersHeaderXrLabel.CanGrow = false;
			this.packersHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(989F, 0F);
			this.packersHeaderXrLabel.Name = "packersHeaderXrLabel";
			this.packersHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.packersHeaderXrLabel.SizeF = new System.Drawing.SizeF(35F, 50F);
			this.packersHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.packersHeaderXrLabel.Text = "Pack.";
			this.packersHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//poHeaderXrLabel
			//
			this.poHeaderXrLabel.CanGrow = false;
			this.poHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(954F, 0F);
			this.poHeaderXrLabel.Name = "poHeaderXrLabel";
			this.poHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.poHeaderXrLabel.SizeF = new System.Drawing.SizeF(35F, 50F);
			this.poHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.poHeaderXrLabel.Text = "PO #";
			this.poHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//actualSpeedHeaderXrLabel
			//
			this.actualSpeedHeaderXrLabel.CanGrow = false;
			this.actualSpeedHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(919F, 0F);
			this.actualSpeedHeaderXrLabel.Name = "actualSpeedHeaderXrLabel";
			this.actualSpeedHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.actualSpeedHeaderXrLabel.SizeF = new System.Drawing.SizeF(35F, 50F);
			this.actualSpeedHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.actualSpeedHeaderXrLabel.Text = "Actual Speed";
			this.actualSpeedHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//machineSpeedHeaderXrLabel
			//
			this.machineSpeedHeaderXrLabel.CanGrow = false;
			this.machineSpeedHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(865F, 0F);
			this.machineSpeedHeaderXrLabel.Name = "machineSpeedHeaderXrLabel";
			this.machineSpeedHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.machineSpeedHeaderXrLabel.SizeF = new System.Drawing.SizeF(54F, 50F);
			this.machineSpeedHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.machineSpeedHeaderXrLabel.Text = "Projected Speed";
			this.machineSpeedHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//machineLineHeaderXrLabel
			//
			this.machineLineHeaderXrLabel.CanGrow = false;
			this.machineLineHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(815F, 0F);
			this.machineLineHeaderXrLabel.Name = "machineLineHeaderXrLabel";
			this.machineLineHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.machineLineHeaderXrLabel.SizeF = new System.Drawing.SizeF(50F, 50F);
			this.machineLineHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.machineLineHeaderXrLabel.Text = "Machine Line";
			this.machineLineHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//differenceHeaderXrLabel
			//
			this.differenceHeaderXrLabel.CanGrow = false;
			this.differenceHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(775F, 0F);
			this.differenceHeaderXrLabel.Name = "differenceHeaderXrLabel";
			this.differenceHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.differenceHeaderXrLabel.SizeF = new System.Drawing.SizeF(40F, 50F);
			this.differenceHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.differenceHeaderXrLabel.Text = "Diff.";
			this.differenceHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//expectedHeaderXrLabel
			//
			this.expectedHeaderXrLabel.CanGrow = false;
			this.expectedHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(740F, 0F);
			this.expectedHeaderXrLabel.Name = "expectedHeaderXrLabel";
			this.expectedHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.expectedHeaderXrLabel.SizeF = new System.Drawing.SizeF(35F, 50F);
			this.expectedHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.expectedHeaderXrLabel.Text = "Expe.";
			this.expectedHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//quantityHeaderXrLabel
			//
			this.quantityHeaderXrLabel.CanGrow = false;
			this.quantityHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(660F, 0F);
			this.quantityHeaderXrLabel.Name = "quantityHeaderXrLabel";
			this.quantityHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.quantityHeaderXrLabel.SizeF = new System.Drawing.SizeF(40F, 50F);
			this.quantityHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.quantityHeaderXrLabel.Text = "Qty";
			this.quantityHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//totalMinutesHeaderXrLabel
			//
			this.totalMinutesHeaderXrLabel.CanGrow = false;
			this.totalMinutesHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(615F, 0F);
			this.totalMinutesHeaderXrLabel.Name = "totalMinutesHeaderXrLabel";
			this.totalMinutesHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.totalMinutesHeaderXrLabel.SizeF = new System.Drawing.SizeF(45F, 50F);
			this.totalMinutesHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.totalMinutesHeaderXrLabel.Text = "Total Minutes";
			this.totalMinutesHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//totalHoursHeaderXrLabel
			//
			this.totalHoursHeaderXrLabel.CanGrow = false;
			this.totalHoursHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(565F, 0F);
			this.totalHoursHeaderXrLabel.Name = "totalHoursHeaderXrLabel";
			this.totalHoursHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.totalHoursHeaderXrLabel.SizeF = new System.Drawing.SizeF(50F, 50F);
			this.totalHoursHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.totalHoursHeaderXrLabel.Text = "Total Hours";
			this.totalHoursHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//stopTimeHeaderXrLabel
			//
			this.stopTimeHeaderXrLabel.CanGrow = false;
			this.stopTimeHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(510F, 0F);
			this.stopTimeHeaderXrLabel.Name = "stopTimeHeaderXrLabel";
			this.stopTimeHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.stopTimeHeaderXrLabel.SizeF = new System.Drawing.SizeF(55F, 50F);
			this.stopTimeHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.stopTimeHeaderXrLabel.Text = "Stop Time";
			this.stopTimeHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//startTimeHeaderXrLabel
			//
			this.startTimeHeaderXrLabel.CanGrow = false;
			this.startTimeHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(455F, 0F);
			this.startTimeHeaderXrLabel.Name = "startTimeHeaderXrLabel";
			this.startTimeHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.startTimeHeaderXrLabel.SizeF = new System.Drawing.SizeF(55F, 50F);
			this.startTimeHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.startTimeHeaderXrLabel.Text = "Start Time";
			this.startTimeHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemDescriptionHeaderXrLabel
			//
			this.itemDescriptionHeaderXrLabel.CanGrow = false;
			this.itemDescriptionHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(305F, 0F);
			this.itemDescriptionHeaderXrLabel.Name = "itemDescriptionHeaderXrLabel";
			this.itemDescriptionHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.itemDescriptionHeaderXrLabel.SizeF = new System.Drawing.SizeF(150F, 50F);
			this.itemDescriptionHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.itemDescriptionHeaderXrLabel.Text = "Item Description";
			this.itemDescriptionHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemCodeHeaderXrLabel
			//
			this.itemCodeHeaderXrLabel.CanGrow = false;
			this.itemCodeHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(245F, 0F);
			this.itemCodeHeaderXrLabel.Name = "itemCodeHeaderXrLabel";
			this.itemCodeHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.itemCodeHeaderXrLabel.SizeF = new System.Drawing.SizeF(60F, 50F);
			this.itemCodeHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.itemCodeHeaderXrLabel.Text = "Item Code";
			this.itemCodeHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//lotHeadeerXrLabel
			//
			this.lotHeadeerXrLabel.CanGrow = false;
			this.lotHeadeerXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(195F, 0F);
			this.lotHeadeerXrLabel.Name = "lotHeadeerXrLabel";
			this.lotHeadeerXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lotHeadeerXrLabel.SizeF = new System.Drawing.SizeF(50F, 50F);
			this.lotHeadeerXrLabel.StyleName = "headerXrControlStyle";
			this.lotHeadeerXrLabel.Text = "Lot";
			this.lotHeadeerXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//customerNameHeaderXrLabel
			//
			this.customerNameHeaderXrLabel.CanGrow = false;
			this.customerNameHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(110F, 0F);
			this.customerNameHeaderXrLabel.Name = "customerNameHeaderXrLabel";
			this.customerNameHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.customerNameHeaderXrLabel.SizeF = new System.Drawing.SizeF(85F, 50F);
			this.customerNameHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.customerNameHeaderXrLabel.Text = "Customer Name";
			this.customerNameHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//shiftHeaderXrLabel
			//
			this.shiftHeaderXrLabel.CanGrow = false;
			this.shiftHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(60F, 0F);
			this.shiftHeaderXrLabel.Name = "shiftHeaderXrLabel";
			this.shiftHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.shiftHeaderXrLabel.SizeF = new System.Drawing.SizeF(50F, 50F);
			this.shiftHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.shiftHeaderXrLabel.Text = "Shift";
			this.shiftHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//dateHeaderXrLabel
			//
			this.dateHeaderXrLabel.CanGrow = false;
			this.dateHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.dateHeaderXrLabel.Name = "dateHeaderXrLabel";
			this.dateHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.dateHeaderXrLabel.SizeF = new System.Drawing.SizeF(60F, 50F);
			this.dateHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.dateHeaderXrLabel.Text = "Production Date";
			this.dateHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
			this.pageNumberXrPageInfo.LocationFloat = new DevExpress.Utils.PointFloat(1550F, 0F);
			this.pageNumberXrPageInfo.Name = "pageNumberXrPageInfo";
			this.pageNumberXrPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.pageNumberXrPageInfo.SizeF = new System.Drawing.SizeF(100F, 25F);
			this.pageNumberXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//ReportHeader
			//
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.printDateXrPageInfo, this.reportCriteriaXrLabel, this.reportTitleXrLabel});
			this.ReportHeader.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.ReportHeader.HeightF = 86F;
			this.ReportHeader.KeepTogether = true;
			this.ReportHeader.Name = "ReportHeader";
			this.ReportHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//printDateXrPageInfo
			//
			this.printDateXrPageInfo.LocationFloat = new DevExpress.Utils.PointFloat(1467F, 50F);
			this.printDateXrPageInfo.Name = "printDateXrPageInfo";
			this.printDateXrPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.printDateXrPageInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
			this.printDateXrPageInfo.SizeF = new System.Drawing.SizeF(183F, 35F);
			this.printDateXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//reportCriteriaXrLabel
			//
			this.reportCriteriaXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 51F);
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
			this.reportTitleXrLabel.SizeF = new System.Drawing.SizeF(1650F, 50F);
			this.reportTitleXrLabel.Text = "Production Details Report";
			this.reportTitleXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//ReportFooter
			//
			this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.footerXrPanel});
			this.ReportFooter.HeightF = 30F;
			this.ReportFooter.KeepTogether = true;
			this.ReportFooter.Name = "ReportFooter";
			this.ReportFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.ReportFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//footerXrPanel
			//
			this.footerXrPanel.BackColor = System.Drawing.Color.FromArgb((int)((byte)230), (int)((byte)235), (int)((byte)247));
			this.footerXrPanel.BorderColor = System.Drawing.Color.Black;
			this.footerXrPanel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.footerXrPanel.BorderWidth = 3F;
			this.footerXrPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.totalPayrollFooterXrLabel, this.actualSpeedFooterXrLabel, this.differenceFooterXrLabel, this.expectedFooterXrLabel, this.quantityFooterXrLabel, this.totalHoursFooterXrLabel});
			this.footerXrPanel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.footerXrPanel.Name = "footerXrPanel";
			this.footerXrPanel.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.footerXrPanel.SizeF = new System.Drawing.SizeF(1650F, 30F);
			//
			//totalPayrollFooterXrLabel
			//
			this.totalPayrollFooterXrLabel.CanGrow = false;
			this.totalPayrollFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1160F, 0F);
			this.totalPayrollFooterXrLabel.Name = "totalPayrollFooterXrLabel";
			this.totalPayrollFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.totalPayrollFooterXrLabel.SizeF = new System.Drawing.SizeF(50F, 30F);
			this.totalPayrollFooterXrLabel.StyleName = "footerXrControlStyle";
			this.totalPayrollFooterXrLabel.Text = "totalPayrollFooterXrLabel";
			this.totalPayrollFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//actualSpeedFooterXrLabel
			//
			this.actualSpeedFooterXrLabel.CanGrow = false;
			this.actualSpeedFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(914F, 0F);
			this.actualSpeedFooterXrLabel.Name = "actualSpeedFooterXrLabel";
			this.actualSpeedFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.actualSpeedFooterXrLabel.SizeF = new System.Drawing.SizeF(45F, 30F);
			this.actualSpeedFooterXrLabel.StyleName = "footerXrControlStyle";
			this.actualSpeedFooterXrLabel.Text = "actualSpeedFooterXrLabel";
			this.actualSpeedFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//differenceFooterXrLabel
			//
			this.differenceFooterXrLabel.CanGrow = false;
			this.differenceFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(775F, 0F);
			this.differenceFooterXrLabel.Name = "differenceFooterXrLabel";
			this.differenceFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.differenceFooterXrLabel.SizeF = new System.Drawing.SizeF(50F, 30F);
			this.differenceFooterXrLabel.StyleName = "footerXrControlStyle";
			this.differenceFooterXrLabel.Text = "differenceFooterXrLabel";
			this.differenceFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//expectedFooterXrLabel
			//
			this.expectedFooterXrLabel.CanGrow = false;
			this.expectedFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(740F, 0F);
			this.expectedFooterXrLabel.Name = "expectedFooterXrLabel";
			this.expectedFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.expectedFooterXrLabel.SizeF = new System.Drawing.SizeF(35F, 30F);
			this.expectedFooterXrLabel.StyleName = "footerXrControlStyle";
			this.expectedFooterXrLabel.Text = "expectedFooterXrLabel";
			this.expectedFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//quantityFooterXrLabel
			//
			this.quantityFooterXrLabel.CanGrow = false;
			this.quantityFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(650F, 0F);
			this.quantityFooterXrLabel.Name = "quantityFooterXrLabel";
			this.quantityFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.quantityFooterXrLabel.SizeF = new System.Drawing.SizeF(50F, 30F);
			this.quantityFooterXrLabel.StyleName = "footerXrControlStyle";
			XrSummary1.FormatString = "{0:#,#}";
			XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.quantityFooterXrLabel.Summary = XrSummary1;
			this.quantityFooterXrLabel.Text = "quantityFooterXrLabel";
			this.quantityFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//totalHoursFooterXrLabel
			//
			this.totalHoursFooterXrLabel.CanGrow = false;
			this.totalHoursFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(560F, 0F);
			this.totalHoursFooterXrLabel.Name = "totalHoursFooterXrLabel";
			this.totalHoursFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.totalHoursFooterXrLabel.SizeF = new System.Drawing.SizeF(60F, 30F);
			this.totalHoursFooterXrLabel.StyleName = "footerXrControlStyle";
			this.totalHoursFooterXrLabel.Text = "totalHoursFooterXrLabel";
			this.totalHoursFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
			//uomHeaderXrLabel
			//
			this.uomHeaderXrLabel.CanGrow = false;
			this.uomHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(700F, 0F);
			this.uomHeaderXrLabel.Name = "uomHeaderXrLabel";
			this.uomHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.uomHeaderXrLabel.SizeF = new System.Drawing.SizeF(40F, 50F);
			this.uomHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.uomHeaderXrLabel.Text = "UOM";
			this.uomHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//uomDetailXrLabel
			//
			this.uomDetailXrLabel.CanGrow = false;
			this.uomDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.uomDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(700F, 0F);
			this.uomDetailXrLabel.Name = "uomDetailXrLabel";
			this.uomDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.uomDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.uomDetailXrLabel.SizeF = new System.Drawing.SizeF(40F, 30F);
			this.uomDetailXrLabel.Text = "uomDetailXrLabel";
			this.uomDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//reasonCodeHeaderXrLabel
			//
			this.reasonCodeHeaderXrLabel.CanGrow = false;
			this.reasonCodeHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1075F, 0F);
			this.reasonCodeHeaderXrLabel.Name = "reasonCodeHeaderXrLabel";
			this.reasonCodeHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.reasonCodeHeaderXrLabel.SizeF = new System.Drawing.SizeF(85F, 50F);
			this.reasonCodeHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.reasonCodeHeaderXrLabel.Text = "Reason Codes";
			this.reasonCodeHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//reasonCodeDetailXrLabel
			//
			this.reasonCodeDetailXrLabel.CanGrow = false;
			this.reasonCodeDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.reasonCodeDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1075F, 0F);
			this.reasonCodeDetailXrLabel.Name = "reasonCodeDetailXrLabel";
			this.reasonCodeDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.reasonCodeDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.reasonCodeDetailXrLabel.SizeF = new System.Drawing.SizeF(85F, 30F);
			this.reasonCodeDetailXrLabel.Text = "reasonCodeDetailXrLabel";
			this.reasonCodeDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//ProductionXtraReport
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.PageHeader, this.PageFooter, this.ReportHeader, this.ReportFooter, this.TopMarginBand1, this.BottomMarginBand1});
			this.Landscape = true;
			this.Margins = new System.Drawing.Printing.Margins(25, 25, 50, 50);
			this.PageWidth = 1700;
			this.PaperKind = System.Drawing.Printing.PaperKind.Tabloid;
			this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {this.headerXrControlStyle, this.footerXrControlStyle, this.detailOddXrControlStyle, this.detailEvenXrControlStyle});
			this.Version = "15.1";
			((System.ComponentModel.ISupportInitialize)this).EndInit();

//INSTANT C# NOTE: Converted design-time event handler wireups:
		totalHoursDetailXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(totalHoursDetailXrLabel_BeforePrint);
		totalMinutesDetailXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(totalMinutesDetailXrLabel_BeforePrint);
		expectedDetailXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(expectedDetailXrLabel_BeforePrint);
		differenceDetailXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(differenceDetailXrLabel_BeforePrint);
		actualSpeedDetailXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(actualSpeedDetailXrLabel_BeforePrint);
		Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(Detail_BeforePrint);
		totalPayrollDetailXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(totalPayrollDetailXrLabel_BeforePrint);
		totalHoursFooterXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(totalHoursFooterXrLabel_BeforePrint);
		expectedFooterXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(expectedFooterXrLabel_BeforePrint);
		differenceFooterXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(differenceFooterXrLabel_BeforePrint);
		actualSpeedFooterXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(actualSpeedFooterXrLabel_BeforePrint);
		totalPayrollFooterXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(totalPayrollFooterXrLabel_BeforePrint);
		ReportHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(ReportHeader_BeforePrint);
		uomDetailXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(uomDetailXrLabel_BeforePrint);
		machineSpeedDetailXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(machineSpeedDetailXrLabel_BeforePrint);
		projectedPackersDetailXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(projectedPackersDetailXrLabel_BeforePrint);
		reasonCodeDetailXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(reasonCodeDetailXrLabel_BeforePrint);
	}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
		internal DevExpress.XtraReports.UI.PageFooterBand PageFooter;
		internal DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		internal DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
		internal DevExpress.XtraReports.UI.XRControlStyle headerXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle footerXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle detailOddXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle detailEvenXrControlStyle;
		internal DevExpress.XtraReports.UI.XRLabel reportCriteriaXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel reportTitleXrLabel;
		internal DevExpress.XtraReports.UI.XRPageInfo printDateXrPageInfo;
		internal DevExpress.XtraReports.UI.XRPanel headerXrPanel;
		internal DevExpress.XtraReports.UI.XRLabel dateDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel dateHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRPanel footerXrPanel;
		internal DevExpress.XtraReports.UI.XRLabel shiftDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel shiftHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel customerNameDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel customerNameHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel lotDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemCodeHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel lotHeadeerXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemDescriptionDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemCodeDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemDescriptionHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel startTimeDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel startTimeHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel stopTimeDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel stopTimeHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel totalHoursDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel totalHoursHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel totalHoursFooterXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel totalMinutesDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel totalMinutesHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel quantityDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel quantityHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel quantityFooterXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel expectedDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel expectedHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel expectedFooterXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel differenceDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel differenceHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel machineLineHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel differenceFooterXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel machineLineDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel machineSpeedHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel machineSpeedDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel actualSpeedDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel actualSpeedHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel actualSpeedFooterXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel poHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel poDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel packersHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel totalPayrollHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel projectedPackersHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel packersDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel projectedPackersDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel totalPayrollDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel totalPayrollFooterXrLabel;
		internal DevExpress.XtraReports.UI.XRPageInfo pageNumberXrPageInfo;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMarginBand1;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMarginBand1;
		internal DevExpress.XtraReports.UI.XRLabel reasonCodeDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel uomDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel reasonCodeHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel uomHeaderXrLabel;
	}

}