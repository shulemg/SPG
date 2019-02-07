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
	public partial class AuditTrailXtraReport : DevExpress.XtraReports.UI.XtraReport
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
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.reportTitleXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.reportCriteriaXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.printDateXrPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
			this.headerXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.footerXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.detailOddXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.detailEvenXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.headerXrPanel = new DevExpress.XtraReports.UI.XRPanel();
			this.itemDescriptionHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.recordTypeHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.userNameHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.dateHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.dateDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.recordTypeDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.recordChangesDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.userNameDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.pageNumberXrPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
			((System.ComponentModel.ISupportInitialize)this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.userNameDetailXrLabel, this.recordChangesDetailXrLabel, this.recordTypeDetailXrLabel, this.dateDetailXrLabel});
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//PageHeader
			//
			this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.headerXrPanel});
			this.PageHeader.Height = 50;
			this.PageHeader.Name = "PageHeader";
			this.PageHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//PageFooter
			//
			this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.pageNumberXrPageInfo});
			this.PageFooter.Height = 30;
			this.PageFooter.Name = "PageFooter";
			this.PageFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//ReportHeader
			//
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.printDateXrPageInfo, this.reportCriteriaXrLabel, this.reportTitleXrLabel});
			this.ReportHeader.Height = 86;
			this.ReportHeader.Name = "ReportHeader";
			//
			//reportTitleXrLabel
			//
			this.reportTitleXrLabel.Font = new System.Drawing.Font("Tahoma", 18.0F);
			this.reportTitleXrLabel.Location = new System.Drawing.Point(0, 0);
			this.reportTitleXrLabel.Name = "reportTitleXrLabel";
			this.reportTitleXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.reportTitleXrLabel.Size = new System.Drawing.Size(800, 50);
			this.reportTitleXrLabel.Text = "reportTitleXrLabel";
			this.reportTitleXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//reportCriteriaXrLabel
			//
			this.reportCriteriaXrLabel.Location = new System.Drawing.Point(0, 50);
			this.reportCriteriaXrLabel.Name = "reportCriteriaXrLabel";
			this.reportCriteriaXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.reportCriteriaXrLabel.Size = new System.Drawing.Size(625, 35);
			this.reportCriteriaXrLabel.Text = "reportCriteriaXrLabel";
			this.reportCriteriaXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//printDateXrPageInfo
			//
			this.printDateXrPageInfo.Location = new System.Drawing.Point(650, 50);
			this.printDateXrPageInfo.Name = "printDateXrPageInfo";
			this.printDateXrPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.printDateXrPageInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
			this.printDateXrPageInfo.Size = new System.Drawing.Size(150, 35);
			this.printDateXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
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
			//headerXrPanel
			//
			this.headerXrPanel.BorderColor = System.Drawing.Color.Black;
			this.headerXrPanel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.headerXrPanel.BorderWidth = 3;
			this.headerXrPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.itemDescriptionHeaderXrLabel, this.recordTypeHeaderXrLabel, this.userNameHeaderXrLabel, this.dateHeaderXrLabel});
			this.headerXrPanel.Location = new System.Drawing.Point(0, 0);
			this.headerXrPanel.Name = "headerXrPanel";
			this.headerXrPanel.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.headerXrPanel.Size = new System.Drawing.Size(800, 50);
			//
			//itemDescriptionHeaderXrLabel
			//
			this.itemDescriptionHeaderXrLabel.CanGrow = false;
			this.itemDescriptionHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 10.0F, System.Drawing.FontStyle.Bold);
			this.itemDescriptionHeaderXrLabel.Location = new System.Drawing.Point(413, 0);
			this.itemDescriptionHeaderXrLabel.Name = "itemDescriptionHeaderXrLabel";
			this.itemDescriptionHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemDescriptionHeaderXrLabel.Size = new System.Drawing.Size(386, 50);
			this.itemDescriptionHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.itemDescriptionHeaderXrLabel.StylePriority.UseFont = false;
			this.itemDescriptionHeaderXrLabel.Text = "Record Changes";
			this.itemDescriptionHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//recordTypeHeaderXrLabel
			//
			this.recordTypeHeaderXrLabel.CanGrow = false;
			this.recordTypeHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 10.0F, System.Drawing.FontStyle.Bold);
			this.recordTypeHeaderXrLabel.Location = new System.Drawing.Point(268, 0);
			this.recordTypeHeaderXrLabel.Name = "recordTypeHeaderXrLabel";
			this.recordTypeHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.recordTypeHeaderXrLabel.Size = new System.Drawing.Size(145, 50);
			this.recordTypeHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.recordTypeHeaderXrLabel.StylePriority.UseFont = false;
			this.recordTypeHeaderXrLabel.Text = "Record Type";
			this.recordTypeHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//userNameHeaderXrLabel
			//
			this.userNameHeaderXrLabel.CanGrow = false;
			this.userNameHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 10.0F, System.Drawing.FontStyle.Bold);
			this.userNameHeaderXrLabel.Location = new System.Drawing.Point(118, 0);
			this.userNameHeaderXrLabel.Name = "userNameHeaderXrLabel";
			this.userNameHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.userNameHeaderXrLabel.Size = new System.Drawing.Size(150, 50);
			this.userNameHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.userNameHeaderXrLabel.StylePriority.UseFont = false;
			this.userNameHeaderXrLabel.Text = "User Name";
			this.userNameHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//dateHeaderXrLabel
			//
			this.dateHeaderXrLabel.CanGrow = false;
			this.dateHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 10.0F, System.Drawing.FontStyle.Bold);
			this.dateHeaderXrLabel.Location = new System.Drawing.Point(0, 0);
			this.dateHeaderXrLabel.Name = "dateHeaderXrLabel";
			this.dateHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.dateHeaderXrLabel.Size = new System.Drawing.Size(118, 50);
			this.dateHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.dateHeaderXrLabel.StylePriority.UseFont = false;
			this.dateHeaderXrLabel.Text = "Date";
			this.dateHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//dateDetailXrLabel
			//
			this.dateDetailXrLabel.CanGrow = false;
			this.dateDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.dateDetailXrLabel.Font = new System.Drawing.Font("Times New Roman", 10.0F);
			this.dateDetailXrLabel.Location = new System.Drawing.Point(0, 0);
			this.dateDetailXrLabel.Name = "dateDetailXrLabel";
			this.dateDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.dateDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.dateDetailXrLabel.Size = new System.Drawing.Size(118, 100);
			this.dateDetailXrLabel.StylePriority.UseFont = false;
			this.dateDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.dateDetailXrLabel.Text = "dateDetailXrLabel";
			this.dateDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//recordTypeDetailXrLabel
			//
			this.recordTypeDetailXrLabel.CanGrow = false;
			this.recordTypeDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.recordTypeDetailXrLabel.Font = new System.Drawing.Font("Times New Roman", 10.0F);
			this.recordTypeDetailXrLabel.Location = new System.Drawing.Point(268, 0);
			this.recordTypeDetailXrLabel.Name = "recordTypeDetailXrLabel";
			this.recordTypeDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.recordTypeDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.recordTypeDetailXrLabel.Size = new System.Drawing.Size(145, 100);
			this.recordTypeDetailXrLabel.StylePriority.UseFont = false;
			this.recordTypeDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.recordTypeDetailXrLabel.Text = "recordTypeDetailXrLabel";
			this.recordTypeDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//recordChangesDetailXrLabel
			//
			this.recordChangesDetailXrLabel.CanGrow = false;
			this.recordChangesDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.recordChangesDetailXrLabel.Font = new System.Drawing.Font("Times New Roman", 10.0F);
			this.recordChangesDetailXrLabel.Location = new System.Drawing.Point(413, 0);
			this.recordChangesDetailXrLabel.Name = "recordChangesDetailXrLabel";
			this.recordChangesDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.recordChangesDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.recordChangesDetailXrLabel.Size = new System.Drawing.Size(386, 100);
			this.recordChangesDetailXrLabel.StylePriority.UseFont = false;
			this.recordChangesDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.recordChangesDetailXrLabel.Text = "recordChangesDetailXrLabel";
			this.recordChangesDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//userNameDetailXrLabel
			//
			this.userNameDetailXrLabel.CanGrow = false;
			this.userNameDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.userNameDetailXrLabel.Font = new System.Drawing.Font("Times New Roman", 10.0F);
			this.userNameDetailXrLabel.Location = new System.Drawing.Point(118, 0);
			this.userNameDetailXrLabel.Name = "userNameDetailXrLabel";
			this.userNameDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.userNameDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.userNameDetailXrLabel.Size = new System.Drawing.Size(150, 100);
			this.userNameDetailXrLabel.StylePriority.UseFont = false;
			this.userNameDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.userNameDetailXrLabel.Text = "userNameDetailXrLabel";
			this.userNameDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//pageNumberXrPageInfo
			//
			this.pageNumberXrPageInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic);
			this.pageNumberXrPageInfo.Format = "Page:  {0} / {1}";
			this.pageNumberXrPageInfo.Location = new System.Drawing.Point(700, 0);
			this.pageNumberXrPageInfo.Name = "pageNumberXrPageInfo";
			this.pageNumberXrPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.pageNumberXrPageInfo.Size = new System.Drawing.Size(100, 25);
			this.pageNumberXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//AuditTrailXtraReport
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.PageHeader, this.PageFooter, this.ReportHeader});
			this.Margins = new System.Drawing.Printing.Margins(25, 25, 50, 50);
			this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {this.headerXrControlStyle, this.footerXrControlStyle, this.detailOddXrControlStyle, this.detailEvenXrControlStyle});
			this.Version = "8.3";
			((System.ComponentModel.ISupportInitialize)this).EndInit();

		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
		internal DevExpress.XtraReports.UI.PageFooterBand PageFooter;
		internal DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		internal DevExpress.XtraReports.UI.XRPageInfo printDateXrPageInfo;
		internal DevExpress.XtraReports.UI.XRLabel reportCriteriaXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel reportTitleXrLabel;
		internal DevExpress.XtraReports.UI.XRControlStyle headerXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle footerXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle detailOddXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle detailEvenXrControlStyle;
		internal DevExpress.XtraReports.UI.XRPanel headerXrPanel;
		internal DevExpress.XtraReports.UI.XRLabel itemDescriptionHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel recordTypeHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel userNameHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel dateHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel userNameDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel recordChangesDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel recordTypeDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel dateDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRPageInfo pageNumberXrPageInfo;
	}

}