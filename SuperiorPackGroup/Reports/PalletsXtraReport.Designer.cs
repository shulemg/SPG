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
	public partial class PalletsXtraReport : DevExpress.XtraReports.UI.XtraReport
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
			this.customerNameDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.byPalletDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
			this.headerXrPanel = new DevExpress.XtraReports.UI.XRPanel();
			this.byPalletHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.customerNameHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
			this.pageNumberXrPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.printDateXrPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
			this.reportTitleXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.headerXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.footerXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.detailOddXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.detailEvenXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			((System.ComponentModel.ISupportInitialize)this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.customerNameDetailXrLabel, this.byPalletDetailXrLabel});
			this.Detail.Height = 30;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//customerNameDetailXrLabel
			//
			this.customerNameDetailXrLabel.CanGrow = false;
			this.customerNameDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.customerNameDetailXrLabel.Location = new System.Drawing.Point(250, 0);
			this.customerNameDetailXrLabel.Name = "customerNameDetailXrLabel";
			this.customerNameDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.customerNameDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.customerNameDetailXrLabel.Size = new System.Drawing.Size(160, 30);
			this.customerNameDetailXrLabel.StylePriority.UseFont = false;
			this.customerNameDetailXrLabel.Text = "customerNameDetailXrLabel";
			this.customerNameDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//byPalletDetailXrLabel
			//
			this.byPalletDetailXrLabel.CanGrow = false;
			this.byPalletDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.byPalletDetailXrLabel.Location = new System.Drawing.Point(410, 0);
			this.byPalletDetailXrLabel.Name = "byPalletDetailXrLabel";
			this.byPalletDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.byPalletDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.byPalletDetailXrLabel.Size = new System.Drawing.Size(140, 30);
			this.byPalletDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.byPalletDetailXrLabel.Text = "byPalletDetailXrLabel";
			this.byPalletDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//PageHeader
			//
			this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.headerXrPanel});
			this.PageHeader.Height = 50;
			this.PageHeader.Name = "PageHeader";
			this.PageHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//headerXrPanel
			//
			this.headerXrPanel.BorderColor = System.Drawing.Color.Black;
			this.headerXrPanel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.headerXrPanel.BorderWidth = 3;
			this.headerXrPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.byPalletHeaderXrLabel, this.customerNameHeaderXrLabel});
			this.headerXrPanel.Location = new System.Drawing.Point(250, 0);
			this.headerXrPanel.Name = "headerXrPanel";
			this.headerXrPanel.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.headerXrPanel.Size = new System.Drawing.Size(300, 50);
			//
			//byPalletHeaderXrLabel
			//
			this.byPalletHeaderXrLabel.CanGrow = false;
			this.byPalletHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 10.0F, System.Drawing.FontStyle.Bold);
			this.byPalletHeaderXrLabel.Location = new System.Drawing.Point(160, 0);
			this.byPalletHeaderXrLabel.Name = "byPalletHeaderXrLabel";
			this.byPalletHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.byPalletHeaderXrLabel.Size = new System.Drawing.Size(140, 50);
			this.byPalletHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.byPalletHeaderXrLabel.StylePriority.UseFont = false;
			this.byPalletHeaderXrLabel.Text = "Pallet Qty";
			this.byPalletHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//customerNameHeaderXrLabel
			//
			this.customerNameHeaderXrLabel.CanGrow = false;
			this.customerNameHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 10.0F, System.Drawing.FontStyle.Bold);
			this.customerNameHeaderXrLabel.Location = new System.Drawing.Point(0, 0);
			this.customerNameHeaderXrLabel.Name = "customerNameHeaderXrLabel";
			this.customerNameHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.customerNameHeaderXrLabel.Size = new System.Drawing.Size(160, 50);
			this.customerNameHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.customerNameHeaderXrLabel.StylePriority.UseFont = false;
			this.customerNameHeaderXrLabel.Text = "Customer";
			this.customerNameHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//PageFooter
			//
			this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.pageNumberXrPageInfo});
			this.PageFooter.Height = 30;
			this.PageFooter.Name = "PageFooter";
			this.PageFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
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
			//ReportHeader
			//
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.printDateXrPageInfo, this.reportTitleXrLabel});
			this.ReportHeader.Height = 86;
			this.ReportHeader.KeepTogether = true;
			this.ReportHeader.Name = "ReportHeader";
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
			//PalletsXtraReport
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
		internal DevExpress.XtraReports.UI.XRControlStyle headerXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle footerXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle detailOddXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle detailEvenXrControlStyle;
		internal DevExpress.XtraReports.UI.XRPageInfo printDateXrPageInfo;
		internal DevExpress.XtraReports.UI.XRLabel reportTitleXrLabel;
		internal DevExpress.XtraReports.UI.XRPanel headerXrPanel;
		internal DevExpress.XtraReports.UI.XRLabel byPalletHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel customerNameHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel customerNameDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel byPalletDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRPageInfo pageNumberXrPageInfo;
	}

}