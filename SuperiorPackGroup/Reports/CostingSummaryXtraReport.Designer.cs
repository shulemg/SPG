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
	public partial class CostingSummaryXtraReport : DevExpress.XtraReports.UI.XtraReport
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
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
			this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
			this.reportTitleXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.reportCriteriaXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.printDateXRPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
			this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
			((System.ComponentModel.ISupportInitialize)this).BeginInit();
			//
			//Detail
			//
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//PageHeader
			//
			this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.printDateXRPageInfo, this.reportCriteriaXrLabel, this.reportTitleXRLabel});
			this.PageHeader.Height = 86;
			this.PageHeader.Name = "PageHeader";
			this.PageHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//PageFooter
			//
			this.PageFooter.Height = 30;
			this.PageFooter.Name = "PageFooter";
			this.PageFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//reportTitleXRLabel
			//
			this.reportTitleXRLabel.Font = new System.Drawing.Font("Tahoma", 18.0F);
			this.reportTitleXRLabel.Location = new System.Drawing.Point(0, 0);
			this.reportTitleXRLabel.Name = "reportTitleXRLabel";
			this.reportTitleXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.reportTitleXRLabel.Size = new System.Drawing.Size(800, 50);
			this.reportTitleXRLabel.Text = "Production Costing Report";
			this.reportTitleXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//reportCriteriaXrLabel
			//
			this.reportCriteriaXrLabel.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.reportCriteriaXrLabel.Location = new System.Drawing.Point(0, 50);
			this.reportCriteriaXrLabel.Multiline = true;
			this.reportCriteriaXrLabel.Name = "reportCriteriaXrLabel";
			this.reportCriteriaXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.reportCriteriaXrLabel.Size = new System.Drawing.Size(500, 35);
			this.reportCriteriaXrLabel.StylePriority.UseTextAlignment = false;
			this.reportCriteriaXrLabel.Text = "reportCriteriaXrLabel";
			this.reportCriteriaXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//printDateXRPageInfo
			//
			this.printDateXRPageInfo.Location = new System.Drawing.Point(617, 50);
			this.printDateXRPageInfo.Name = "printDateXRPageInfo";
			this.printDateXRPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.printDateXRPageInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
			this.printDateXRPageInfo.Size = new System.Drawing.Size(183, 35);
			this.printDateXRPageInfo.StylePriority.UseTextAlignment = false;
			this.printDateXRPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//ReportFooter
			//
			this.ReportFooter.Height = 425;
			this.ReportFooter.Name = "ReportFooter";
			//
			//CostingSummaryXtraReport
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.PageHeader, this.PageFooter, this.ReportFooter});
			this.Margins = new System.Drawing.Printing.Margins(25, 25, 50, 50);
			this.Version = "8.3";
			((System.ComponentModel.ISupportInitialize)this).EndInit();

		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
		internal DevExpress.XtraReports.UI.PageFooterBand PageFooter;
		internal DevExpress.XtraReports.UI.XRLabel reportCriteriaXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel reportTitleXRLabel;
		internal DevExpress.XtraReports.UI.XRPageInfo printDateXRPageInfo;
		internal DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
	}

}