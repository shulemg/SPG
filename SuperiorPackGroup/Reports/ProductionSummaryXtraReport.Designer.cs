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
	public partial class ProductionSummaryXtraReport : DevExpress.XtraReports.UI.XtraReport
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
			this.Style1 = new DevExpress.XtraReports.UI.XRControlStyle();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.detailTable = new DevExpress.XtraReports.UI.XRTable();
			this.XrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
			this.productionDate = new DevExpress.XtraReports.UI.XRTableCell();
			this.productionShift = new DevExpress.XtraReports.UI.XRTableCell();
			this.productionCustomer = new DevExpress.XtraReports.UI.XRTableCell();
			this.productionItemCode = new DevExpress.XtraReports.UI.XRTableCell();
			this.productionStartTime = new DevExpress.XtraReports.UI.XRTableCell();
			this.productionEndtime = new DevExpress.XtraReports.UI.XRTableCell();
			this.totalProductionHours = new DevExpress.XtraReports.UI.XRTableCell();
			this.qtyProduced = new DevExpress.XtraReports.UI.XRTableCell();
			this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
			this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.XrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.CriteriaLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
			this.AverageActualSpeedH = new DevExpress.XtraReports.UI.XRLabel();
			this.XrTable3 = new DevExpress.XtraReports.UI.XRTable();
			this.XrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
			this.XrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
			this.totalHours = new DevExpress.XtraReports.UI.XRTableCell();
			this.XrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
			this.totalMinutesLabel = new DevExpress.XtraReports.UI.XRTableCell();
			this.totalMinutes = new DevExpress.XtraReports.UI.XRTableCell();
			this.XrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
			this.XrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
			this.totalQtyProduced = new DevExpress.XtraReports.UI.XRTableCell();
			this.XrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
			this.XrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
			this.averageActualSpeed = new DevExpress.XtraReports.UI.XRTableCell();
			this.XrTableRow17 = new DevExpress.XtraReports.UI.XRTableRow();
			this.XrTableCell49 = new DevExpress.XtraReports.UI.XRTableCell();
			this.totalPacksPerMin = new DevExpress.XtraReports.UI.XRTableCell();
			this.TopMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
			((System.ComponentModel.ISupportInitialize)this.detailTable).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.XrTable3).BeginInit();
			((System.ComponentModel.ISupportInitialize)this).BeginInit();
			//
			//Style1
			//
			this.Style1.BackColor = System.Drawing.Color.FromArgb((int)((byte)230), (int)((byte)235), (int)((byte)247));
			this.Style1.BorderColor = System.Drawing.SystemColors.ControlText;
			this.Style1.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.Style1.BorderWidth = 1;
			this.Style1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
			this.Style1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Style1.Name = "Style1";
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.detailTable});
			this.Detail.HeightF = 25.0F;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			this.Detail.Visible = false;
			//
			//detailTable
			//
			this.detailTable.LocationFloat = new DevExpress.Utils.PointFloat(0.0F, 0.0F);
			this.detailTable.Name = "detailTable";
			this.detailTable.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.detailTable.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {this.XrTableRow1});
			this.detailTable.SizeF = new System.Drawing.SizeF(1050.0F, 25.0F);
			this.detailTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrTableRow1
			//
			this.XrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {this.productionDate, this.productionShift, this.productionCustomer, this.productionItemCode, this.productionStartTime, this.productionEndtime, this.totalProductionHours, this.qtyProduced});
			this.XrTableRow1.Name = "XrTableRow1";
			this.XrTableRow1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.XrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			this.XrTableRow1.Weight = 1.0D;
			//
			//productionDate
			//
			this.productionDate.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "qrptProduction.ProdMainDate", "{0:dddd, MMMM dd, yyyy}")});
			this.productionDate.Font = new System.Drawing.Font("Arial", 9.75F);
			this.productionDate.Name = "productionDate";
			this.productionDate.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.productionDate.Text = "productionDate";
			this.productionDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.productionDate.Weight = 0.11714285714285715D;
			//
			//productionShift
			//
			this.productionShift.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "qrptProduction.ShiftName")});
			this.productionShift.Font = new System.Drawing.Font("Arial", 9.75F);
			this.productionShift.Name = "productionShift";
			this.productionShift.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.productionShift.Text = "productionShift";
			this.productionShift.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.productionShift.Weight = 0.07047619047619047D;
			//
			//productionCustomer
			//
			this.productionCustomer.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "qrptProduction.CustomerName")});
			this.productionCustomer.Font = new System.Drawing.Font("Arial", 9.75F);
			this.productionCustomer.Name = "productionCustomer";
			this.productionCustomer.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.productionCustomer.Text = "productionCustomer";
			this.productionCustomer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.productionCustomer.Weight = 0.16380952380952382D;
			//
			//productionItemCode
			//
			this.productionItemCode.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "qrptProduction.ItemCode")});
			this.productionItemCode.Font = new System.Drawing.Font("Arial", 9.75F);
			this.productionItemCode.Name = "productionItemCode";
			this.productionItemCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.productionItemCode.Text = "productionItemCode";
			this.productionItemCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.productionItemCode.Weight = 0.24952380952380954D;
			//
			//productionStartTime
			//
			this.productionStartTime.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "qrptProduction.ProdMainTimeStart", "{0:h:mm tt}")});
			this.productionStartTime.Font = new System.Drawing.Font("Arial", 9.75F);
			this.productionStartTime.Name = "productionStartTime";
			this.productionStartTime.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.productionStartTime.Text = "productionStartTime";
			this.productionStartTime.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.productionStartTime.Weight = 0.078095238095238093D;
			//
			//productionEndtime
			//
			this.productionEndtime.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "qrptProduction.ProdMainTimeStop", "{0:h:mm tt}")});
			this.productionEndtime.Font = new System.Drawing.Font("Arial", 9.75F);
			this.productionEndtime.Name = "productionEndtime";
			this.productionEndtime.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.productionEndtime.Text = "productionEndtime";
			this.productionEndtime.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.productionEndtime.Weight = 0.07047619047619047D;
			//
			//totalProductionHours
			//
			this.totalProductionHours.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "qrptProduction.TotalHours")});
			this.totalProductionHours.Font = new System.Drawing.Font("Arial", 9.75F);
			this.totalProductionHours.Name = "totalProductionHours";
			this.totalProductionHours.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.totalProductionHours.Text = "totalProductionHours";
			this.totalProductionHours.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.totalProductionHours.Weight = 0.10857142857142857D;
			//
			//qtyProduced
			//
			this.qtyProduced.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "qrptProduction.ProdMainQuantity")});
			this.qtyProduced.Font = new System.Drawing.Font("Arial", 9.75F);
			this.qtyProduced.Name = "qtyProduced";
			this.qtyProduced.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.qtyProduced.Text = "qtyProduced";
			this.qtyProduced.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.qtyProduced.Weight = 0.14190476190476189D;
			//
			//PageHeader
			//
			this.PageHeader.HeightF = 30.0F;
			this.PageHeader.Name = "PageHeader";
			this.PageHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//PageFooter
			//
			this.PageFooter.HeightF = 30.0F;
			this.PageFooter.Name = "PageFooter";
			this.PageFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//ReportHeader
			//
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrPageInfo2, this.CriteriaLabel, this.XrLabel1});
			this.ReportHeader.HeightF = 98.0F;
			this.ReportHeader.KeepTogether = true;
			this.ReportHeader.Name = "ReportHeader";
			this.ReportHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrPageInfo2
			//
			this.XrPageInfo2.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.XrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(833.0F, 67.0F);
			this.XrPageInfo2.Name = "XrPageInfo2";
			this.XrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
			this.XrPageInfo2.SizeF = new System.Drawing.SizeF(200.0F, 25.0F);
			this.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//CriteriaLabel
			//
			this.CriteriaLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.CriteriaLabel.LocationFloat = new DevExpress.Utils.PointFloat(8.0F, 58.0F);
			this.CriteriaLabel.Name = "CriteriaLabel";
			this.CriteriaLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.CriteriaLabel.SizeF = new System.Drawing.SizeF(634.0F, 34.0F);
			this.CriteriaLabel.Text = "CriteriaLabel";
			this.CriteriaLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//XrLabel1
			//
			this.XrLabel1.Font = new System.Drawing.Font("Tahoma", 18.0F);
			this.XrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0.0F, 8.0F);
			this.XrLabel1.Name = "XrLabel1";
			this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel1.SizeF = new System.Drawing.SizeF(1050.0F, 50.0F);
			this.XrLabel1.Text = "Production Summary Report";
			this.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//ReportFooter
			//
			this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.AverageActualSpeedH, this.XrTable3});
			this.ReportFooter.HeightF = 151.0F;
			this.ReportFooter.KeepTogether = true;
			this.ReportFooter.Name = "ReportFooter";
			this.ReportFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.ReportFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//AverageActualSpeedH
			//
			this.AverageActualSpeedH.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "qrptProduction.ActualSpeed")});
			this.AverageActualSpeedH.LocationFloat = new DevExpress.Utils.PointFloat(17.0F, 8.0F);
			this.AverageActualSpeedH.Name = "AverageActualSpeedH";
			this.AverageActualSpeedH.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.AverageActualSpeedH.SizeF = new System.Drawing.SizeF(100.0F, 25.0F);
			XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.AverageActualSpeedH.Summary = XrSummary1;
			this.AverageActualSpeedH.Text = "AverageActualSpeedH";
			this.AverageActualSpeedH.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			this.AverageActualSpeedH.Visible = false;
			//
			//XrTable3
			//
			this.XrTable3.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrTable3.LocationFloat = new DevExpress.Utils.PointFloat(242.0F, 17.0F);
			this.XrTable3.Name = "XrTable3";
			this.XrTable3.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.XrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {this.XrTableRow7, this.XrTableRow8, this.XrTableRow9, this.XrTableRow10, this.XrTableRow17});
			this.XrTable3.SizeF = new System.Drawing.SizeF(567.0F, 125.0F);
			this.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrTableRow7
			//
			this.XrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {this.XrTableCell32, this.totalHours});
			this.XrTableRow7.Name = "XrTableRow7";
			this.XrTableRow7.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.XrTableRow7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			this.XrTableRow7.Weight = 0.2D;
			//
			//XrTableCell32
			//
			this.XrTableCell32.BackColor = System.Drawing.Color.FromArgb((int)((byte)230), (int)((byte)235), (int)((byte)247));
			this.XrTableCell32.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrTableCell32.Name = "XrTableCell32";
			this.XrTableCell32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrTableCell32.StyleName = "Style1";
			this.XrTableCell32.Text = "Total Hours";
			this.XrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.XrTableCell32.Weight = 0.5149911816578483D;
			//
			//totalHours
			//
			this.totalHours.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "qrptProduction.TotalHours")});
			this.totalHours.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.totalHours.Name = "totalHours";
			this.totalHours.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			XrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Custom;
			XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.totalHours.Summary = XrSummary2;
			this.totalHours.Text = "totalHours";
			this.totalHours.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.totalHours.Weight = 0.48500881834215165D;
			//
			//XrTableRow8
			//
			this.XrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {this.totalMinutesLabel, this.totalMinutes});
			this.XrTableRow8.Name = "XrTableRow8";
			this.XrTableRow8.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.XrTableRow8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			this.XrTableRow8.Weight = 0.2D;
			//
			//totalMinutesLabel
			//
			this.totalMinutesLabel.Name = "totalMinutesLabel";
			this.totalMinutesLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.totalMinutesLabel.StyleName = "Style1";
			this.totalMinutesLabel.Text = "Total Minutes";
			this.totalMinutesLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.totalMinutesLabel.Weight = 0.5149911816578483D;
			//
			//totalMinutes
			//
			this.totalMinutes.BackColor = System.Drawing.Color.Transparent;
			this.totalMinutes.Font = new System.Drawing.Font("Arial", 9.75F);
			this.totalMinutes.Name = "totalMinutes";
			this.totalMinutes.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.totalMinutes.Text = "XrTableCell35";
			this.totalMinutes.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.totalMinutes.Weight = 0.48500881834215165D;
			//
			//XrTableRow9
			//
			this.XrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {this.XrTableCell36, this.totalQtyProduced});
			this.XrTableRow9.Name = "XrTableRow9";
			this.XrTableRow9.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.XrTableRow9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			this.XrTableRow9.Weight = 0.2D;
			//
			//XrTableCell36
			//
			this.XrTableCell36.Name = "XrTableCell36";
			this.XrTableCell36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrTableCell36.StyleName = "Style1";
			this.XrTableCell36.Text = "Total Quantity Produced";
			this.XrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.XrTableCell36.Weight = 0.5149911816578483D;
			//
			//totalQtyProduced
			//
			this.totalQtyProduced.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "qrptProduction.ProdMainQuantity")});
			this.totalQtyProduced.Font = new System.Drawing.Font("Arial", 9.75F);
			this.totalQtyProduced.Name = "totalQtyProduced";
			this.totalQtyProduced.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.totalQtyProduced.Summary = XrSummary3;
			this.totalQtyProduced.Text = "totalQtyProduced";
			this.totalQtyProduced.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.totalQtyProduced.Weight = 0.48500881834215165D;
			//
			//XrTableRow10
			//
			this.XrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {this.XrTableCell33, this.averageActualSpeed});
			this.XrTableRow10.Name = "XrTableRow10";
			this.XrTableRow10.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.XrTableRow10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			this.XrTableRow10.Weight = 0.2D;
			//
			//XrTableCell33
			//
			this.XrTableCell33.Name = "XrTableCell33";
			this.XrTableCell33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrTableCell33.StyleName = "Style1";
			this.XrTableCell33.Text = "Average Actual Speed";
			this.XrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.XrTableCell33.Weight = 0.5149911816578483D;
			//
			//averageActualSpeed
			//
			this.averageActualSpeed.Font = new System.Drawing.Font("Arial", 9.75F);
			this.averageActualSpeed.Name = "averageActualSpeed";
			this.averageActualSpeed.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.averageActualSpeed.Text = "averageActualSpeed";
			this.averageActualSpeed.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.averageActualSpeed.Weight = 0.48500881834215165D;
			//
			//XrTableRow17
			//
			this.XrTableRow17.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {this.XrTableCell49, this.totalPacksPerMin});
			this.XrTableRow17.Name = "XrTableRow17";
			this.XrTableRow17.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.XrTableRow17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			this.XrTableRow17.Weight = 0.2D;
			//
			//XrTableCell49
			//
			this.XrTableCell49.Name = "XrTableCell49";
			this.XrTableCell49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrTableCell49.StyleName = "Style1";
			this.XrTableCell49.Text = "Average Packs Per Minute";
			this.XrTableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.XrTableCell49.Weight = 0.5149911816578483D;
			//
			//totalPacksPerMin
			//
			this.totalPacksPerMin.Font = new System.Drawing.Font("Arial", 9.75F);
			this.totalPacksPerMin.Name = "totalPacksPerMin";
			this.totalPacksPerMin.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.totalPacksPerMin.Text = "totalPacksPerMin";
			this.totalPacksPerMin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.totalPacksPerMin.Weight = 0.48500881834215165D;
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
			//ProductionSummaryXtraReport
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.PageHeader, this.PageFooter, this.ReportHeader, this.ReportFooter, this.TopMarginBand1, this.BottomMarginBand1});
			this.Landscape = true;
			this.Margins = new System.Drawing.Printing.Margins(25, 25, 50, 50);
			this.PageHeight = 850;
			this.PageWidth = 1100;
			this.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic;
			this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {this.Style1});
			this.Version = "11.2";
			((System.ComponentModel.ISupportInitialize)this.detailTable).EndInit();
			((System.ComponentModel.ISupportInitialize)this.XrTable3).EndInit();
			((System.ComponentModel.ISupportInitialize)this).EndInit();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			base.BeforePrint += new System.Drawing.Printing.PrintEventHandler(ProductionSummaryXtraReport_BeforePrint);
			totalMinutes.BeforePrint += new System.Drawing.Printing.PrintEventHandler(totalMinutes_BeforePrint);
			averageActualSpeed.BeforePrint += new System.Drawing.Printing.PrintEventHandler(averageActualSpeed_BeforePrint);
			totalPacksPerMin.BeforePrint += new System.Drawing.Printing.PrintEventHandler(totalPacksPerMin_BeforePrint);
			totalMinutesLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(totalMinutesLabel_BeforePrint);
			totalHours.SummaryGetResult += new DevExpress.XtraReports.UI.SummaryGetResultHandler(totalHours_SummaryGetResult);
			totalHours.SummaryReset += new System.EventHandler(totalHours_SummaryReset);
			totalHours.SummaryRowChanged += new System.EventHandler(totalHours_SummaryRowChanged);
			Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(Detail_BeforePrint);
		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
		internal DevExpress.XtraReports.UI.PageFooterBand PageFooter;
		internal DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		internal DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
		internal DevExpress.XtraReports.UI.XRPageInfo XrPageInfo2;
		internal DevExpress.XtraReports.UI.XRLabel CriteriaLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
		internal DevExpress.XtraReports.UI.XRTable detailTable;
		internal DevExpress.XtraReports.UI.XRTableRow XrTableRow1;
		internal DevExpress.XtraReports.UI.XRTableCell productionDate;
		internal DevExpress.XtraReports.UI.XRTableCell productionShift;
		internal DevExpress.XtraReports.UI.XRTableCell productionCustomer;
		internal DevExpress.XtraReports.UI.XRTableCell productionItemCode;
		internal DevExpress.XtraReports.UI.XRTableCell productionStartTime;
		internal DevExpress.XtraReports.UI.XRTableCell productionEndtime;
		internal DevExpress.XtraReports.UI.XRTableCell totalProductionHours;
		internal DevExpress.XtraReports.UI.XRTableCell qtyProduced;
		internal DevExpress.XtraReports.UI.XRTable XrTable3;
		internal DevExpress.XtraReports.UI.XRTableRow XrTableRow7;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell32;
		internal DevExpress.XtraReports.UI.XRTableCell totalHours;
		internal DevExpress.XtraReports.UI.XRTableRow XrTableRow8;
		internal DevExpress.XtraReports.UI.XRTableCell totalMinutesLabel;
		internal DevExpress.XtraReports.UI.XRTableCell totalMinutes;
		internal DevExpress.XtraReports.UI.XRTableRow XrTableRow9;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell36;
		internal DevExpress.XtraReports.UI.XRTableCell totalQtyProduced;
		internal DevExpress.XtraReports.UI.XRTableRow XrTableRow10;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell33;
		internal DevExpress.XtraReports.UI.XRTableCell averageActualSpeed;
		internal DevExpress.XtraReports.UI.XRTableRow XrTableRow17;
		internal DevExpress.XtraReports.UI.XRTableCell XrTableCell49;
		internal DevExpress.XtraReports.UI.XRTableCell totalPacksPerMin;
		internal DevExpress.XtraReports.UI.XRLabel AverageActualSpeedH;
		internal DevExpress.XtraReports.UI.XRControlStyle Style1;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMarginBand1;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMarginBand1;
	}

}