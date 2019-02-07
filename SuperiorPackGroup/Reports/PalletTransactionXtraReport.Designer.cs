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
	public partial class PalletTransactionXtraReport : DevExpress.XtraReports.UI.XtraReport
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
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
			this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.printDateXrPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
			this.reportCriteriaXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.reportTitleXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.headerXrPanel = new DevExpress.XtraReports.UI.XRPanel();
			this.recieveHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.destinationHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.vendorHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.customerHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.shippedHeadeerXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.transactionDateHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.headerXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.footerXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.detailOddXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.detailEvenXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.bolXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.vendorDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.destinationDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.bolDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.receivedDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.shippedDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
			this.totalsXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.receivedTotalXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.shippedTotalXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.totalOverShippedXRLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.xRLOverShippedTotal = new DevExpress.XtraReports.UI.XRLabel();
			this.pageNumberXrPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
			this.palletTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)this.palletTransactionsBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel1, this.XrLabel2, this.vendorDetailXrLabel, this.destinationDetailXrLabel, this.bolDetailXrLabel, this.receivedDetailXrLabel, this.shippedDetailXrLabel});
			this.Detail.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.Detail.Height = 25;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[]
			{
				new DevExpress.XtraReports.UI.GroupField("TransactionDate", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending),
				new DevExpress.XtraReports.UI.GroupField("CustomerName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)
			});
			this.Detail.StylePriority.UseFont = false;
			this.Detail.StylePriority.UseTextAlignment = false;
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
			this.ReportHeader.Height = 93;
			this.ReportHeader.Name = "ReportHeader";
			//
			//printDateXrPageInfo
			//
			this.printDateXrPageInfo.Location = new System.Drawing.Point(617, 58);
			this.printDateXrPageInfo.Name = "printDateXrPageInfo";
			this.printDateXrPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.printDateXrPageInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
			this.printDateXrPageInfo.Size = new System.Drawing.Size(183, 35);
			this.printDateXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//reportCriteriaXrLabel
			//
			this.reportCriteriaXrLabel.Location = new System.Drawing.Point(0, 58);
			this.reportCriteriaXrLabel.Name = "reportCriteriaXrLabel";
			this.reportCriteriaXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.reportCriteriaXrLabel.Size = new System.Drawing.Size(583, 35);
			this.reportCriteriaXrLabel.Text = "reportCriteriaXrLabel";
			this.reportCriteriaXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//reportTitleXrLabel
			//
			this.reportTitleXrLabel.Font = new System.Drawing.Font("Tahoma", 18.0F);
			this.reportTitleXrLabel.Location = new System.Drawing.Point(0, 8);
			this.reportTitleXrLabel.Name = "reportTitleXrLabel";
			this.reportTitleXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.reportTitleXrLabel.Size = new System.Drawing.Size(800, 50);
			this.reportTitleXrLabel.Text = "reportTitleXrLabel";
			this.reportTitleXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//headerXrPanel
			//
			this.headerXrPanel.BorderColor = System.Drawing.Color.Black;
			this.headerXrPanel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.headerXrPanel.BorderWidth = 3;
			this.headerXrPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.recieveHeaderXrLabel, this.destinationHeaderXrLabel, this.vendorHeaderXrLabel, this.customerHeaderXrLabel, this.shippedHeadeerXrLabel, this.transactionDateHeaderXrLabel, this.bolXrLabel});
			this.headerXrPanel.Location = new System.Drawing.Point(0, 0);
			this.headerXrPanel.Name = "headerXrPanel";
			this.headerXrPanel.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.headerXrPanel.Size = new System.Drawing.Size(800, 50);
			//
			//recieveHeaderXrLabel
			//
			this.recieveHeaderXrLabel.CanGrow = false;
			this.recieveHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 10.0F, System.Drawing.FontStyle.Bold);
			this.recieveHeaderXrLabel.Location = new System.Drawing.Point(600, 0);
			this.recieveHeaderXrLabel.Name = "recieveHeaderXrLabel";
			this.recieveHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.recieveHeaderXrLabel.Size = new System.Drawing.Size(100, 50);
			this.recieveHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.recieveHeaderXrLabel.StylePriority.UseFont = false;
			this.recieveHeaderXrLabel.Text = "Received (In)";
			this.recieveHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//destinationHeaderXrLabel
			//
			this.destinationHeaderXrLabel.CanGrow = false;
			this.destinationHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 10.0F, System.Drawing.FontStyle.Bold);
			this.destinationHeaderXrLabel.Location = new System.Drawing.Point(360, 0);
			this.destinationHeaderXrLabel.Name = "destinationHeaderXrLabel";
			this.destinationHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.destinationHeaderXrLabel.Size = new System.Drawing.Size(120, 50);
			this.destinationHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.destinationHeaderXrLabel.StylePriority.UseFont = false;
			this.destinationHeaderXrLabel.Text = "Destination";
			this.destinationHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//vendorHeaderXrLabel
			//
			this.vendorHeaderXrLabel.CanGrow = false;
			this.vendorHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 10.0F, System.Drawing.FontStyle.Bold);
			this.vendorHeaderXrLabel.Location = new System.Drawing.Point(240, 0);
			this.vendorHeaderXrLabel.Name = "vendorHeaderXrLabel";
			this.vendorHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.vendorHeaderXrLabel.Size = new System.Drawing.Size(120, 50);
			this.vendorHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.vendorHeaderXrLabel.StylePriority.UseFont = false;
			this.vendorHeaderXrLabel.Text = "Vendor";
			this.vendorHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//customerHeaderXrLabel
			//
			this.customerHeaderXrLabel.CanGrow = false;
			this.customerHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 10.0F, System.Drawing.FontStyle.Bold);
			this.customerHeaderXrLabel.Location = new System.Drawing.Point(120, 0);
			this.customerHeaderXrLabel.Name = "customerHeaderXrLabel";
			this.customerHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.customerHeaderXrLabel.Size = new System.Drawing.Size(120, 50);
			this.customerHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.customerHeaderXrLabel.StylePriority.UseFont = false;
			this.customerHeaderXrLabel.Text = "Customer";
			this.customerHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//shippedHeadeerXrLabel
			//
			this.shippedHeadeerXrLabel.CanGrow = false;
			this.shippedHeadeerXrLabel.Font = new System.Drawing.Font("Tahoma", 10.0F, System.Drawing.FontStyle.Bold);
			this.shippedHeadeerXrLabel.Location = new System.Drawing.Point(700, 0);
			this.shippedHeadeerXrLabel.Name = "shippedHeadeerXrLabel";
			this.shippedHeadeerXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.shippedHeadeerXrLabel.Size = new System.Drawing.Size(100, 50);
			this.shippedHeadeerXrLabel.StyleName = "headerXrControlStyle";
			this.shippedHeadeerXrLabel.StylePriority.UseFont = false;
			this.shippedHeadeerXrLabel.Text = "Shipped (Out)";
			this.shippedHeadeerXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//transactionDateHeaderXrLabel
			//
			this.transactionDateHeaderXrLabel.CanGrow = false;
			this.transactionDateHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 10.0F, System.Drawing.FontStyle.Bold);
			this.transactionDateHeaderXrLabel.Location = new System.Drawing.Point(0, 0);
			this.transactionDateHeaderXrLabel.Name = "transactionDateHeaderXrLabel";
			this.transactionDateHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.transactionDateHeaderXrLabel.Size = new System.Drawing.Size(120, 50);
			this.transactionDateHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.transactionDateHeaderXrLabel.StylePriority.UseFont = false;
			this.transactionDateHeaderXrLabel.Text = "Transaction Date";
			this.transactionDateHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
			//bolXrLabel
			//
			this.bolXrLabel.CanGrow = false;
			this.bolXrLabel.Font = new System.Drawing.Font("Tahoma", 10.0F, System.Drawing.FontStyle.Bold);
			this.bolXrLabel.Location = new System.Drawing.Point(480, 0);
			this.bolXrLabel.Name = "bolXrLabel";
			this.bolXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.bolXrLabel.Size = new System.Drawing.Size(120, 50);
			this.bolXrLabel.StyleName = "headerXrControlStyle";
			this.bolXrLabel.StylePriority.UseFont = false;
			this.bolXrLabel.Text = "BOL #";
			this.bolXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel1
			//
			this.XrLabel1.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrLabel1.CanGrow = false;
			this.XrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "TransactionDate", "{0:MMM/dd/yyyy}")});
			this.XrLabel1.Location = new System.Drawing.Point(0, 0);
			this.XrLabel1.Name = "XrLabel1";
			this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel1.Size = new System.Drawing.Size(120, 25);
			this.XrLabel1.StylePriority.UseBorders = false;
			this.XrLabel1.Text = "XrLabel1";
			//
			//XrLabel2
			//
			this.XrLabel2.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrLabel2.CanGrow = false;
			this.XrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "CustomerName", "")});
			this.XrLabel2.Location = new System.Drawing.Point(120, 0);
			this.XrLabel2.Name = "XrLabel2";
			this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel2.Size = new System.Drawing.Size(120, 25);
			this.XrLabel2.StylePriority.UseBorders = false;
			this.XrLabel2.Text = "XrLabel2";
			//
			//vendorDetailXrLabel
			//
			this.vendorDetailXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.vendorDetailXrLabel.CanGrow = false;
			this.vendorDetailXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "VendorName", "")});
			this.vendorDetailXrLabel.Location = new System.Drawing.Point(240, 0);
			this.vendorDetailXrLabel.Name = "vendorDetailXrLabel";
			this.vendorDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.vendorDetailXrLabel.Size = new System.Drawing.Size(120, 25);
			this.vendorDetailXrLabel.StylePriority.UseBorders = false;
			this.vendorDetailXrLabel.Text = "vendorDetailXrLabel";
			//
			//destinationDetailXrLabel
			//
			this.destinationDetailXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.destinationDetailXrLabel.CanGrow = false;
			this.destinationDetailXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "ShippingDestinationName", "")});
			this.destinationDetailXrLabel.Location = new System.Drawing.Point(360, 0);
			this.destinationDetailXrLabel.Name = "destinationDetailXrLabel";
			this.destinationDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.destinationDetailXrLabel.Size = new System.Drawing.Size(120, 25);
			this.destinationDetailXrLabel.StylePriority.UseBorders = false;
			this.destinationDetailXrLabel.Text = "destinationDetailXrLabel";
			//
			//bolDetailXrLabel
			//
			this.bolDetailXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.bolDetailXrLabel.CanGrow = false;
			this.bolDetailXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "TransactionBOL", "")});
			this.bolDetailXrLabel.Location = new System.Drawing.Point(480, 0);
			this.bolDetailXrLabel.Name = "bolDetailXrLabel";
			this.bolDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.bolDetailXrLabel.Size = new System.Drawing.Size(120, 25);
			this.bolDetailXrLabel.StylePriority.UseBorders = false;
			this.bolDetailXrLabel.Text = "bolDetailXrLabel";
			//
			//receivedDetailXrLabel
			//
			this.receivedDetailXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.receivedDetailXrLabel.CanGrow = false;
			this.receivedDetailXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "Received", "")});
			this.receivedDetailXrLabel.Location = new System.Drawing.Point(600, 0);
			this.receivedDetailXrLabel.Name = "receivedDetailXrLabel";
			this.receivedDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.receivedDetailXrLabel.Size = new System.Drawing.Size(100, 25);
			this.receivedDetailXrLabel.StylePriority.UseBorders = false;
			this.receivedDetailXrLabel.Text = "receivedDetailXrLabel";
			//
			//shippedDetailXrLabel
			//
			this.shippedDetailXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.shippedDetailXrLabel.CanGrow = false;
			this.shippedDetailXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "Shipped", "")});
			this.shippedDetailXrLabel.Location = new System.Drawing.Point(700, 0);
			this.shippedDetailXrLabel.Name = "shippedDetailXrLabel";
			this.shippedDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.shippedDetailXrLabel.Size = new System.Drawing.Size(100, 25);
			this.shippedDetailXrLabel.StylePriority.UseBorders = false;
			this.shippedDetailXrLabel.Text = "shippedDetailXrLabel";
			//
			//ReportFooter
			//
			this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.totalsXRLabel, this.receivedTotalXRLabel, this.shippedTotalXrLabel, this.totalOverShippedXRLabel, this.xRLOverShippedTotal});
			this.ReportFooter.Height = 50;
			this.ReportFooter.Name = "ReportFooter";
			//
			//totalsXRLabel
			//
			this.totalsXRLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.totalsXRLabel.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold);
			this.totalsXRLabel.Location = new System.Drawing.Point(0, 0);
			this.totalsXRLabel.Name = "totalsXRLabel";
			this.totalsXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.totalsXRLabel.Size = new System.Drawing.Size(600, 25);
			this.totalsXRLabel.StylePriority.UseBorders = false;
			this.totalsXRLabel.StylePriority.UseFont = false;
			this.totalsXRLabel.StylePriority.UseTextAlignment = false;
			this.totalsXRLabel.Text = "Totals";
			this.totalsXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//receivedTotalXRLabel
			//
			this.receivedTotalXRLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.receivedTotalXRLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "Received", "")});
			this.receivedTotalXRLabel.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.receivedTotalXRLabel.Location = new System.Drawing.Point(600, 0);
			this.receivedTotalXRLabel.Name = "receivedTotalXRLabel";
			this.receivedTotalXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.receivedTotalXRLabel.Size = new System.Drawing.Size(100, 25);
			this.receivedTotalXRLabel.StylePriority.UseBorders = false;
			this.receivedTotalXRLabel.StylePriority.UseFont = false;
			XrSummary1.IgnoreNullValues = true;
			XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.receivedTotalXRLabel.Summary = XrSummary1;
			this.receivedTotalXRLabel.Text = "receivedTotalXRLabel";
			//
			//shippedTotalXrLabel
			//
			this.shippedTotalXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.shippedTotalXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "Shipped", "")});
			this.shippedTotalXrLabel.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.shippedTotalXrLabel.Location = new System.Drawing.Point(700, 0);
			this.shippedTotalXrLabel.Name = "shippedTotalXrLabel";
			this.shippedTotalXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.shippedTotalXrLabel.Size = new System.Drawing.Size(100, 25);
			this.shippedTotalXrLabel.StylePriority.UseBorders = false;
			this.shippedTotalXrLabel.StylePriority.UseFont = false;
			XrSummary2.IgnoreNullValues = true;
			XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.shippedTotalXrLabel.Summary = XrSummary2;
			this.shippedTotalXrLabel.Text = "shippedTotalXrLabel";
			//
			//totalOverShippedXRLabel
			//
			this.totalOverShippedXRLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.totalOverShippedXRLabel.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Bold);
			this.totalOverShippedXRLabel.Location = new System.Drawing.Point(0, 25);
			this.totalOverShippedXRLabel.Name = "totalOverShippedXRLabel";
			this.totalOverShippedXRLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.totalOverShippedXRLabel.Size = new System.Drawing.Size(600, 25);
			this.totalOverShippedXRLabel.StylePriority.UseBorders = false;
			this.totalOverShippedXRLabel.StylePriority.UseFont = false;
			this.totalOverShippedXRLabel.StylePriority.UseTextAlignment = false;
			this.totalOverShippedXRLabel.Text = "Total Over Shipped";
			this.totalOverShippedXRLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
			//
			//xRLOverShippedTotal
			//
			this.xRLOverShippedTotal.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.xRLOverShippedTotal.Font = new System.Drawing.Font("Tahoma", 10.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.xRLOverShippedTotal.Location = new System.Drawing.Point(600, 25);
			this.xRLOverShippedTotal.Name = "xRLOverShippedTotal";
			this.xRLOverShippedTotal.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.xRLOverShippedTotal.Size = new System.Drawing.Size(200, 25);
			this.xRLOverShippedTotal.StylePriority.UseBorders = false;
			this.xRLOverShippedTotal.StylePriority.UseFont = false;
			this.xRLOverShippedTotal.StylePriority.UseTextAlignment = false;
			this.xRLOverShippedTotal.Text = "xRLOverShippedTotal";
			this.xRLOverShippedTotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
			//
			//pageNumberXrPageInfo
			//
			this.pageNumberXrPageInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic);
			this.pageNumberXrPageInfo.Format = "Page:  {0} / {1}";
			this.pageNumberXrPageInfo.Location = new System.Drawing.Point(692, 0);
			this.pageNumberXrPageInfo.Name = "pageNumberXrPageInfo";
			this.pageNumberXrPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.pageNumberXrPageInfo.Size = new System.Drawing.Size(100, 25);
			this.pageNumberXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//palletTransactionsBindingSource
			//
			this.palletTransactionsBindingSource.DataSource = typeof(PalletTransactionList);
			//
			//PalletTransactionXtraReport
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.PageHeader, this.PageFooter, this.ReportHeader, this.ReportFooter});
			this.DataSource = this.palletTransactionsBindingSource;
			this.Margins = new System.Drawing.Printing.Margins(25, 25, 50, 50);
			this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {this.headerXrControlStyle, this.footerXrControlStyle, this.detailOddXrControlStyle, this.detailEvenXrControlStyle});
			this.Version = "9.2";
			((System.ComponentModel.ISupportInitialize)this.palletTransactionsBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)this).EndInit();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			xRLOverShippedTotal.BeforePrint += new System.Drawing.Printing.PrintEventHandler(xRLOverShippedTotal_BeforePrint);
		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
		internal DevExpress.XtraReports.UI.PageFooterBand PageFooter;
		internal DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		internal DevExpress.XtraReports.UI.XRPageInfo printDateXrPageInfo;
		internal DevExpress.XtraReports.UI.XRLabel reportCriteriaXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel reportTitleXrLabel;
		internal System.Windows.Forms.BindingSource palletTransactionsBindingSource;
		internal DevExpress.XtraReports.UI.XRPanel headerXrPanel;
		internal DevExpress.XtraReports.UI.XRLabel recieveHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel destinationHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel vendorHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel customerHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel shippedHeadeerXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel transactionDateHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRControlStyle headerXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle footerXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle detailOddXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle detailEvenXrControlStyle;
		internal DevExpress.XtraReports.UI.XRLabel bolXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
		internal DevExpress.XtraReports.UI.XRLabel vendorDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel destinationDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel bolDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel receivedDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel shippedDetailXrLabel;
		internal DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
		internal DevExpress.XtraReports.UI.XRLabel totalsXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel receivedTotalXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel shippedTotalXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel totalOverShippedXRLabel;
		internal DevExpress.XtraReports.UI.XRLabel xRLOverShippedTotal;
		internal DevExpress.XtraReports.UI.XRPageInfo pageNumberXrPageInfo;
	}

}