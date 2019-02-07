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
	public partial class ItemsXtraReport : DevExpress.XtraReports.UI.XtraReport
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
			DevExpress.XtraReports.UI.XRSummary XrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.shippedDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.receivedDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.adjustedDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.unitsPerCaseDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.quantityDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.producedDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemTypeDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.uomDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemDescriptionDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemCodeDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.casesPerPalletDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.customerNameDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
			this.headerXrPanel = new DevExpress.XtraReports.UI.XRPanel();
			this.AdjustedHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.receivedHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.shippedHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.unitsPerCaseHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.quantityHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.producedHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemTypeHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.uomHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemDescriptionHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemCodeHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.casesPerPalletHeadeerXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.customerNameHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
			this.pageNumberXrPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.printDateXrPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
			this.reportCriteriaXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.reportTitleXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
			this.footerXrPanel = new DevExpress.XtraReports.UI.XRPanel();
			this.receivedFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.shippedFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.producedFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.adjustedFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.headerXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.footerXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.detailOddXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.detailEvenXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.TopMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.usedInProductionHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.usedInProductionDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.usedInProductionFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			((System.ComponentModel.ISupportInitialize)this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.usedInProductionDetailXrLabel, this.shippedDetailXrLabel, this.receivedDetailXrLabel, this.adjustedDetailXrLabel, this.unitsPerCaseDetailXrLabel, this.quantityDetailXrLabel, this.producedDetailXrLabel, this.itemTypeDetailXrLabel, this.uomDetailXrLabel, this.itemDescriptionDetailXrLabel, this.itemCodeDetailXrLabel, this.casesPerPalletDetailXrLabel, this.customerNameDetailXrLabel});
			this.Detail.HeightF = 30.0F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//shippedDetailXrLabel
			//
			this.shippedDetailXrLabel.CanGrow = false;
			this.shippedDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.shippedDetailXrLabel.Font = new System.Drawing.Font("Times New Roman", 10.0F);
			this.shippedDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(803.0F, 0.0F);
			this.shippedDetailXrLabel.Name = "shippedDetailXrLabel";
			this.shippedDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.shippedDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.shippedDetailXrLabel.SizeF = new System.Drawing.SizeF(81.0F, 30.0F);
			this.shippedDetailXrLabel.StylePriority.UseFont = false;
			this.shippedDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.shippedDetailXrLabel.Text = "shippedDetailXrLabel";
			this.shippedDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//receivedDetailXrLabel
			//
			this.receivedDetailXrLabel.CanGrow = false;
			this.receivedDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.receivedDetailXrLabel.Font = new System.Drawing.Font("Times New Roman", 10.0F);
			this.receivedDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(884.0F, 0.0F);
			this.receivedDetailXrLabel.Name = "receivedDetailXrLabel";
			this.receivedDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.receivedDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.receivedDetailXrLabel.SizeF = new System.Drawing.SizeF(81.0F, 30.0F);
			this.receivedDetailXrLabel.StylePriority.UseFont = false;
			this.receivedDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.receivedDetailXrLabel.Text = "receivedDetailXrLabel";
			this.receivedDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//adjustedDetailXrLabel
			//
			this.adjustedDetailXrLabel.CanGrow = false;
			this.adjustedDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.adjustedDetailXrLabel.Font = new System.Drawing.Font("Times New Roman", 10.0F);
			this.adjustedDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(965.0F, 0.0F);
			this.adjustedDetailXrLabel.Name = "adjustedDetailXrLabel";
			this.adjustedDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.adjustedDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.adjustedDetailXrLabel.SizeF = new System.Drawing.SizeF(81.0F, 30.0F);
			this.adjustedDetailXrLabel.StylePriority.UseFont = false;
			this.adjustedDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.adjustedDetailXrLabel.Text = "adjustedDetailXrLabel";
			this.adjustedDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//unitsPerCaseDetailXrLabel
			//
			this.unitsPerCaseDetailXrLabel.CanGrow = false;
			this.unitsPerCaseDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.unitsPerCaseDetailXrLabel.Font = new System.Drawing.Font("Times New Roman", 10.0F);
			this.unitsPerCaseDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(560.0F, 0.0F);
			this.unitsPerCaseDetailXrLabel.Name = "unitsPerCaseDetailXrLabel";
			this.unitsPerCaseDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.unitsPerCaseDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.unitsPerCaseDetailXrLabel.SizeF = new System.Drawing.SizeF(81.0F, 30.0F);
			this.unitsPerCaseDetailXrLabel.StylePriority.UseFont = false;
			this.unitsPerCaseDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.unitsPerCaseDetailXrLabel.Text = "unitsPerCaseDetailXrLabel";
			this.unitsPerCaseDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//quantityDetailXrLabel
			//
			this.quantityDetailXrLabel.CanGrow = false;
			this.quantityDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.quantityDetailXrLabel.Font = new System.Drawing.Font("Times New Roman", 10.0F);
			this.quantityDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(479.0F, 0.0F);
			this.quantityDetailXrLabel.Name = "quantityDetailXrLabel";
			this.quantityDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.quantityDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.quantityDetailXrLabel.SizeF = new System.Drawing.SizeF(81.0F, 30.0F);
			this.quantityDetailXrLabel.StylePriority.UseFont = false;
			this.quantityDetailXrLabel.Text = "quantityDetailXrLabel";
			this.quantityDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//producedDetailXrLabel
			//
			this.producedDetailXrLabel.CanGrow = false;
			this.producedDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.producedDetailXrLabel.Font = new System.Drawing.Font("Times New Roman", 10.0F);
			this.producedDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(722.0F, 0.0F);
			this.producedDetailXrLabel.Name = "producedDetailXrLabel";
			this.producedDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.producedDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.producedDetailXrLabel.SizeF = new System.Drawing.SizeF(81.0F, 30.0F);
			this.producedDetailXrLabel.StylePriority.UseFont = false;
			this.producedDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.producedDetailXrLabel.Text = "producedDetailXrLabel";
			this.producedDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//itemTypeDetailXrLabel
			//
			this.itemTypeDetailXrLabel.CanGrow = false;
			this.itemTypeDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.itemTypeDetailXrLabel.Font = new System.Drawing.Font("Times New Roman", 10.0F);
			this.itemTypeDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(295.0F, 0.0F);
			this.itemTypeDetailXrLabel.Name = "itemTypeDetailXrLabel";
			this.itemTypeDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.itemTypeDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemTypeDetailXrLabel.SizeF = new System.Drawing.SizeF(103.0F, 30.0F);
			this.itemTypeDetailXrLabel.StylePriority.UseFont = false;
			this.itemTypeDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.itemTypeDetailXrLabel.Text = "itemTypeDetailXrLabel";
			this.itemTypeDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//uomDetailXrLabel
			//
			this.uomDetailXrLabel.CanGrow = false;
			this.uomDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.uomDetailXrLabel.Font = new System.Drawing.Font("Times New Roman", 10.0F);
			this.uomDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(398.0F, 0.0F);
			this.uomDetailXrLabel.Name = "uomDetailXrLabel";
			this.uomDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.uomDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.uomDetailXrLabel.SizeF = new System.Drawing.SizeF(81.0F, 30.0F);
			this.uomDetailXrLabel.StylePriority.UseFont = false;
			this.uomDetailXrLabel.Text = "uomDetailXrLabel";
			this.uomDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//itemDescriptionDetailXrLabel
			//
			this.itemDescriptionDetailXrLabel.CanGrow = false;
			this.itemDescriptionDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.itemDescriptionDetailXrLabel.Font = new System.Drawing.Font("Times New Roman", 9.0F);
			this.itemDescriptionDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(190.0F, 0.0F);
			this.itemDescriptionDetailXrLabel.Name = "itemDescriptionDetailXrLabel";
			this.itemDescriptionDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.itemDescriptionDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemDescriptionDetailXrLabel.SizeF = new System.Drawing.SizeF(105.0F, 30.0F);
			this.itemDescriptionDetailXrLabel.StylePriority.UseFont = false;
			this.itemDescriptionDetailXrLabel.Text = "itemDescriptionDetailXrLabel";
			this.itemDescriptionDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//itemCodeDetailXrLabel
			//
			this.itemCodeDetailXrLabel.CanGrow = false;
			this.itemCodeDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.itemCodeDetailXrLabel.Font = new System.Drawing.Font("Times New Roman", 10.0F);
			this.itemCodeDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(100.0F, 0.0F);
			this.itemCodeDetailXrLabel.Name = "itemCodeDetailXrLabel";
			this.itemCodeDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.itemCodeDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemCodeDetailXrLabel.SizeF = new System.Drawing.SizeF(90.0F, 30.0F);
			this.itemCodeDetailXrLabel.StylePriority.UseFont = false;
			this.itemCodeDetailXrLabel.Text = "itemCodeDetailXrLabel";
			this.itemCodeDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//casesPerPalletDetailXrLabel
			//
			this.casesPerPalletDetailXrLabel.CanGrow = false;
			this.casesPerPalletDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.casesPerPalletDetailXrLabel.Font = new System.Drawing.Font("Times New Roman", 10.0F);
			this.casesPerPalletDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(641.0F, 0.0F);
			this.casesPerPalletDetailXrLabel.Name = "casesPerPalletDetailXrLabel";
			this.casesPerPalletDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.casesPerPalletDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.casesPerPalletDetailXrLabel.SizeF = new System.Drawing.SizeF(81.0F, 30.0F);
			this.casesPerPalletDetailXrLabel.StylePriority.UseFont = false;
			this.casesPerPalletDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.casesPerPalletDetailXrLabel.Text = "casesPerPalletDetailXrLabel";
			this.casesPerPalletDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//customerNameDetailXrLabel
			//
			this.customerNameDetailXrLabel.CanGrow = false;
			this.customerNameDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.customerNameDetailXrLabel.Font = new System.Drawing.Font("Times New Roman", 10.0F);
			this.customerNameDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0.0F, 0.0F);
			this.customerNameDetailXrLabel.Name = "customerNameDetailXrLabel";
			this.customerNameDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.customerNameDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.customerNameDetailXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 30.0F);
			this.customerNameDetailXrLabel.StylePriority.UseFont = false;
			this.customerNameDetailXrLabel.Text = "customerNameDetailXrLabel";
			this.customerNameDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//PageHeader
			//
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
			this.headerXrPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.usedInProductionHeaderXrLabel, this.AdjustedHeaderXrLabel, this.receivedHeaderXrLabel, this.shippedHeaderXrLabel, this.unitsPerCaseHeaderXrLabel, this.quantityHeaderXrLabel, this.producedHeaderXrLabel, this.itemTypeHeaderXrLabel, this.uomHeaderXrLabel, this.itemDescriptionHeaderXrLabel, this.itemCodeHeaderXrLabel, this.casesPerPalletHeadeerXrLabel, this.customerNameHeaderXrLabel});
			this.headerXrPanel.LocationFloat = new DevExpress.Utils.PointFloat(0.0F, 0.0F);
			this.headerXrPanel.Name = "headerXrPanel";
			this.headerXrPanel.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.headerXrPanel.SizeF = new System.Drawing.SizeF(1050.0F, 50.0F);
			//
			//AdjustedHeaderXrLabel
			//
			this.AdjustedHeaderXrLabel.CanGrow = false;
			this.AdjustedHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.AdjustedHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(965.0F, 0.0F);
			this.AdjustedHeaderXrLabel.Name = "AdjustedHeaderXrLabel";
			this.AdjustedHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.AdjustedHeaderXrLabel.SizeF = new System.Drawing.SizeF(81.0F, 50.0F);
			this.AdjustedHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.AdjustedHeaderXrLabel.StylePriority.UseFont = false;
			this.AdjustedHeaderXrLabel.Text = "Adjusted";
			this.AdjustedHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//receivedHeaderXrLabel
			//
			this.receivedHeaderXrLabel.CanGrow = false;
			this.receivedHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.receivedHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(884.0F, 0.0F);
			this.receivedHeaderXrLabel.Name = "receivedHeaderXrLabel";
			this.receivedHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.receivedHeaderXrLabel.SizeF = new System.Drawing.SizeF(81.0F, 50.0F);
			this.receivedHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.receivedHeaderXrLabel.StylePriority.UseFont = false;
			this.receivedHeaderXrLabel.Text = "Received";
			this.receivedHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//shippedHeaderXrLabel
			//
			this.shippedHeaderXrLabel.CanGrow = false;
			this.shippedHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.shippedHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(803.0F, 0.0F);
			this.shippedHeaderXrLabel.Name = "shippedHeaderXrLabel";
			this.shippedHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.shippedHeaderXrLabel.SizeF = new System.Drawing.SizeF(81.0F, 50.0F);
			this.shippedHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.shippedHeaderXrLabel.StylePriority.UseFont = false;
			this.shippedHeaderXrLabel.Text = "Shipped";
			this.shippedHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//unitsPerCaseHeaderXrLabel
			//
			this.unitsPerCaseHeaderXrLabel.CanGrow = false;
			this.unitsPerCaseHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.unitsPerCaseHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(560.0F, 0.0F);
			this.unitsPerCaseHeaderXrLabel.Name = "unitsPerCaseHeaderXrLabel";
			this.unitsPerCaseHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.unitsPerCaseHeaderXrLabel.SizeF = new System.Drawing.SizeF(81.0F, 50.0F);
			this.unitsPerCaseHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.unitsPerCaseHeaderXrLabel.StylePriority.UseFont = false;
			this.unitsPerCaseHeaderXrLabel.Text = "Units per Case";
			this.unitsPerCaseHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//quantityHeaderXrLabel
			//
			this.quantityHeaderXrLabel.CanGrow = false;
			this.quantityHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.quantityHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(479.0F, 0.0F);
			this.quantityHeaderXrLabel.Name = "quantityHeaderXrLabel";
			this.quantityHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.quantityHeaderXrLabel.SizeF = new System.Drawing.SizeF(81.0F, 50.0F);
			this.quantityHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.quantityHeaderXrLabel.StylePriority.UseFont = false;
			this.quantityHeaderXrLabel.Text = "Qty per Unit";
			this.quantityHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//producedHeaderXrLabel
			//
			this.producedHeaderXrLabel.CanGrow = false;
			this.producedHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.producedHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(722.0F, 0.0F);
			this.producedHeaderXrLabel.Name = "producedHeaderXrLabel";
			this.producedHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.producedHeaderXrLabel.SizeF = new System.Drawing.SizeF(81.0F, 50.0F);
			this.producedHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.producedHeaderXrLabel.StylePriority.UseFont = false;
			this.producedHeaderXrLabel.Text = "Produced";
			this.producedHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemTypeHeaderXrLabel
			//
			this.itemTypeHeaderXrLabel.CanGrow = false;
			this.itemTypeHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.itemTypeHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(295.0F, 0.0F);
			this.itemTypeHeaderXrLabel.Name = "itemTypeHeaderXrLabel";
			this.itemTypeHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemTypeHeaderXrLabel.SizeF = new System.Drawing.SizeF(103.0F, 50.0F);
			this.itemTypeHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.itemTypeHeaderXrLabel.StylePriority.UseFont = false;
			this.itemTypeHeaderXrLabel.Text = "Item Type";
			this.itemTypeHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//uomHeaderXrLabel
			//
			this.uomHeaderXrLabel.CanGrow = false;
			this.uomHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.uomHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(398.0F, 0.0F);
			this.uomHeaderXrLabel.Name = "uomHeaderXrLabel";
			this.uomHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.uomHeaderXrLabel.SizeF = new System.Drawing.SizeF(81.0F, 50.0F);
			this.uomHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.uomHeaderXrLabel.StylePriority.UseFont = false;
			this.uomHeaderXrLabel.Text = "Unit of Measure";
			this.uomHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemDescriptionHeaderXrLabel
			//
			this.itemDescriptionHeaderXrLabel.CanGrow = false;
			this.itemDescriptionHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.itemDescriptionHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(190.0F, 0.0F);
			this.itemDescriptionHeaderXrLabel.Name = "itemDescriptionHeaderXrLabel";
			this.itemDescriptionHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemDescriptionHeaderXrLabel.SizeF = new System.Drawing.SizeF(105.0F, 50.0F);
			this.itemDescriptionHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.itemDescriptionHeaderXrLabel.StylePriority.UseFont = false;
			this.itemDescriptionHeaderXrLabel.Text = "Item Description";
			this.itemDescriptionHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemCodeHeaderXrLabel
			//
			this.itemCodeHeaderXrLabel.CanGrow = false;
			this.itemCodeHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.itemCodeHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(100.0F, 0.0F);
			this.itemCodeHeaderXrLabel.Name = "itemCodeHeaderXrLabel";
			this.itemCodeHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemCodeHeaderXrLabel.SizeF = new System.Drawing.SizeF(90.0F, 50.0F);
			this.itemCodeHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.itemCodeHeaderXrLabel.StylePriority.UseFont = false;
			this.itemCodeHeaderXrLabel.Text = "Item #";
			this.itemCodeHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//casesPerPalletHeadeerXrLabel
			//
			this.casesPerPalletHeadeerXrLabel.CanGrow = false;
			this.casesPerPalletHeadeerXrLabel.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.casesPerPalletHeadeerXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(641.0F, 0.0F);
			this.casesPerPalletHeadeerXrLabel.Name = "casesPerPalletHeadeerXrLabel";
			this.casesPerPalletHeadeerXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.casesPerPalletHeadeerXrLabel.SizeF = new System.Drawing.SizeF(81.0F, 50.0F);
			this.casesPerPalletHeadeerXrLabel.StyleName = "headerXrControlStyle";
			this.casesPerPalletHeadeerXrLabel.StylePriority.UseFont = false;
			this.casesPerPalletHeadeerXrLabel.Text = "Cases per Pallet";
			this.casesPerPalletHeadeerXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//customerNameHeaderXrLabel
			//
			this.customerNameHeaderXrLabel.CanGrow = false;
			this.customerNameHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.customerNameHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0.0F, 0.0F);
			this.customerNameHeaderXrLabel.Name = "customerNameHeaderXrLabel";
			this.customerNameHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.customerNameHeaderXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 50.0F);
			this.customerNameHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.customerNameHeaderXrLabel.StylePriority.UseFont = false;
			this.customerNameHeaderXrLabel.Text = "Customer";
			this.customerNameHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//PageFooter
			//
			this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.pageNumberXrPageInfo});
			this.PageFooter.HeightF = 30.0F;
			this.PageFooter.Name = "PageFooter";
			this.PageFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//pageNumberXrPageInfo
			//
			this.pageNumberXrPageInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic);
			this.pageNumberXrPageInfo.Format = "Page:  {0} / {1}";
			this.pageNumberXrPageInfo.LocationFloat = new DevExpress.Utils.PointFloat(950.0F, 0.0F);
			this.pageNumberXrPageInfo.Name = "pageNumberXrPageInfo";
			this.pageNumberXrPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.pageNumberXrPageInfo.SizeF = new System.Drawing.SizeF(100.0F, 25.0F);
			this.pageNumberXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//ReportHeader
			//
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.printDateXrPageInfo, this.reportCriteriaXrLabel, this.reportTitleXrLabel});
			this.ReportHeader.HeightF = 86.0F;
			this.ReportHeader.KeepTogether = true;
			this.ReportHeader.Name = "ReportHeader";
			//
			//printDateXrPageInfo
			//
			this.printDateXrPageInfo.LocationFloat = new DevExpress.Utils.PointFloat(867.0F, 50.0F);
			this.printDateXrPageInfo.Name = "printDateXrPageInfo";
			this.printDateXrPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.printDateXrPageInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
			this.printDateXrPageInfo.SizeF = new System.Drawing.SizeF(183.0F, 35.0F);
			this.printDateXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//reportCriteriaXrLabel
			//
			this.reportCriteriaXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0.0F, 50.0F);
			this.reportCriteriaXrLabel.Name = "reportCriteriaXrLabel";
			this.reportCriteriaXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.reportCriteriaXrLabel.SizeF = new System.Drawing.SizeF(635.0F, 35.0F);
			this.reportCriteriaXrLabel.Text = "reportCriteriaXrLabel";
			this.reportCriteriaXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//reportTitleXrLabel
			//
			this.reportTitleXrLabel.Font = new System.Drawing.Font("Tahoma", 18.0F);
			this.reportTitleXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0.0F, 0.0F);
			this.reportTitleXrLabel.Name = "reportTitleXrLabel";
			this.reportTitleXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.reportTitleXrLabel.SizeF = new System.Drawing.SizeF(1050.0F, 50.0F);
			this.reportTitleXrLabel.Text = "reportTitleXrLabel";
			this.reportTitleXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//ReportFooter
			//
			this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.footerXrPanel});
			this.ReportFooter.HeightF = 30.0F;
			this.ReportFooter.KeepTogether = true;
			this.ReportFooter.Name = "ReportFooter";
			//
			//footerXrPanel
			//
			this.footerXrPanel.BackColor = System.Drawing.Color.FromArgb((int)((byte)230), (int)((byte)235), (int)((byte)247));
			this.footerXrPanel.BorderColor = System.Drawing.Color.Black;
			this.footerXrPanel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.footerXrPanel.BorderWidth = 3;
			this.footerXrPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.usedInProductionFooterXrLabel, this.receivedFooterXrLabel, this.shippedFooterXrLabel, this.producedFooterXrLabel, this.adjustedFooterXrLabel});
			this.footerXrPanel.LocationFloat = new DevExpress.Utils.PointFloat(0.0F, 0.0F);
			this.footerXrPanel.Name = "footerXrPanel";
			this.footerXrPanel.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.footerXrPanel.SizeF = new System.Drawing.SizeF(1050.0F, 30.0F);
			//
			//receivedFooterXrLabel
			//
			this.receivedFooterXrLabel.CanGrow = false;
			this.receivedFooterXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F);
			this.receivedFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(884.0F, 0.0F);
			this.receivedFooterXrLabel.Name = "receivedFooterXrLabel";
			this.receivedFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.receivedFooterXrLabel.SizeF = new System.Drawing.SizeF(81.0F, 30.0F);
			this.receivedFooterXrLabel.StyleName = "footerXrControlStyle";
			this.receivedFooterXrLabel.StylePriority.UseFont = false;
			this.receivedFooterXrLabel.StylePriority.UseTextAlignment = false;
			XrSummary2.FormatString = "{0:#,#}";
			XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.receivedFooterXrLabel.Summary = XrSummary2;
			this.receivedFooterXrLabel.Text = "receivedFooterXrLabel";
			this.receivedFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//shippedFooterXrLabel
			//
			this.shippedFooterXrLabel.CanGrow = false;
			this.shippedFooterXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F);
			this.shippedFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(803.0F, 0.0F);
			this.shippedFooterXrLabel.Name = "shippedFooterXrLabel";
			this.shippedFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.shippedFooterXrLabel.SizeF = new System.Drawing.SizeF(81.0F, 30.0F);
			this.shippedFooterXrLabel.StyleName = "footerXrControlStyle";
			this.shippedFooterXrLabel.StylePriority.UseFont = false;
			this.shippedFooterXrLabel.StylePriority.UseTextAlignment = false;
			XrSummary3.FormatString = "{0:#,#}";
			XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.shippedFooterXrLabel.Summary = XrSummary3;
			this.shippedFooterXrLabel.Text = "shippedFooterXrLabel";
			this.shippedFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//producedFooterXrLabel
			//
			this.producedFooterXrLabel.CanGrow = false;
			this.producedFooterXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F);
			this.producedFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(722.0F, 0.0F);
			this.producedFooterXrLabel.Name = "producedFooterXrLabel";
			this.producedFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.producedFooterXrLabel.SizeF = new System.Drawing.SizeF(81.0F, 30.0F);
			this.producedFooterXrLabel.StyleName = "footerXrControlStyle";
			this.producedFooterXrLabel.StylePriority.UseFont = false;
			this.producedFooterXrLabel.StylePriority.UseTextAlignment = false;
			XrSummary4.FormatString = "{0:#,#}";
			XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.producedFooterXrLabel.Summary = XrSummary4;
			this.producedFooterXrLabel.Text = "producedFooterXrLabel";
			this.producedFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//adjustedFooterXrLabel
			//
			this.adjustedFooterXrLabel.CanGrow = false;
			this.adjustedFooterXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F);
			this.adjustedFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(965.0F, 0.0F);
			this.adjustedFooterXrLabel.Name = "adjustedFooterXrLabel";
			this.adjustedFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.adjustedFooterXrLabel.SizeF = new System.Drawing.SizeF(81.0F, 30.0F);
			this.adjustedFooterXrLabel.StyleName = "footerXrControlStyle";
			this.adjustedFooterXrLabel.StylePriority.UseFont = false;
			this.adjustedFooterXrLabel.StylePriority.UseTextAlignment = false;
			XrSummary5.FormatString = "{0:#,#}";
			XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.adjustedFooterXrLabel.Summary = XrSummary5;
			this.adjustedFooterXrLabel.Text = "adjustedFooterXrLabel";
			this.adjustedFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
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
			//usedInProductionHeaderXrLabel
			//
			this.usedInProductionHeaderXrLabel.CanGrow = false;
			this.usedInProductionHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 8.0F, System.Drawing.FontStyle.Bold);
			this.usedInProductionHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(487.5F, 0.0F);
			this.usedInProductionHeaderXrLabel.Name = "usedInProductionHeaderXrLabel";
			this.usedInProductionHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.usedInProductionHeaderXrLabel.SizeF = new System.Drawing.SizeF(81.0F, 50.0F);
			this.usedInProductionHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.usedInProductionHeaderXrLabel.StylePriority.UseFont = false;
			this.usedInProductionHeaderXrLabel.Text = "Used In Production";
			this.usedInProductionHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//usedInProductionDetailXrLabel
			//
			this.usedInProductionDetailXrLabel.CanGrow = false;
			this.usedInProductionDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.usedInProductionDetailXrLabel.Font = new System.Drawing.Font("Times New Roman", 10.0F);
			this.usedInProductionDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(487.5F, 0.0F);
			this.usedInProductionDetailXrLabel.Name = "usedInProductionDetailXrLabel";
			this.usedInProductionDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.usedInProductionDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.usedInProductionDetailXrLabel.SizeF = new System.Drawing.SizeF(81.0F, 30.0F);
			this.usedInProductionDetailXrLabel.StylePriority.UseFont = false;
			this.usedInProductionDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.usedInProductionDetailXrLabel.Text = "adjustedDetailXrLabel";
			this.usedInProductionDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//usedInProductionFooterXrLabel
			//
			this.usedInProductionFooterXrLabel.CanGrow = false;
			this.usedInProductionFooterXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F);
			this.usedInProductionFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(487.5F, 0.0F);
			this.usedInProductionFooterXrLabel.Name = "usedInProductionFooterXrLabel";
			this.usedInProductionFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.usedInProductionFooterXrLabel.SizeF = new System.Drawing.SizeF(81.0F, 30.0F);
			this.usedInProductionFooterXrLabel.StyleName = "footerXrControlStyle";
			this.usedInProductionFooterXrLabel.StylePriority.UseFont = false;
			this.usedInProductionFooterXrLabel.StylePriority.UseTextAlignment = false;
			XrSummary1.FormatString = "{0:#,#}";
			XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.usedInProductionFooterXrLabel.Summary = XrSummary1;
			this.usedInProductionFooterXrLabel.Text = "adjustedFooterXrLabel";
			this.usedInProductionFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//ItemsXtraReport
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.PageHeader, this.PageFooter, this.ReportHeader, this.ReportFooter, this.TopMarginBand1, this.BottomMarginBand1});
			this.Landscape = true;
			this.Margins = new System.Drawing.Printing.Margins(25, 25, 50, 50);
			this.PageHeight = 850;
			this.PageWidth = 1100;
			this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {this.headerXrControlStyle, this.footerXrControlStyle, this.detailOddXrControlStyle, this.detailEvenXrControlStyle});
			this.Version = "10.2";
			((System.ComponentModel.ISupportInitialize)this).EndInit();

		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
		internal DevExpress.XtraReports.UI.PageFooterBand PageFooter;
		internal DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		internal DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
		internal DevExpress.XtraReports.UI.XRPageInfo printDateXrPageInfo;
		internal DevExpress.XtraReports.UI.XRLabel reportCriteriaXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel reportTitleXrLabel;
		internal DevExpress.XtraReports.UI.XRControlStyle headerXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle footerXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle detailOddXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle detailEvenXrControlStyle;
		internal DevExpress.XtraReports.UI.XRPanel headerXrPanel;
		internal DevExpress.XtraReports.UI.XRLabel AdjustedHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel receivedHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel shippedHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel unitsPerCaseHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel quantityHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel producedHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemTypeHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel uomHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemDescriptionHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemCodeHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel casesPerPalletHeadeerXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel customerNameHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel shippedDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel receivedDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel adjustedDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel unitsPerCaseDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel quantityDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel producedDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemTypeDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel uomDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemDescriptionDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemCodeDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel casesPerPalletDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel customerNameDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRPanel footerXrPanel;
		internal DevExpress.XtraReports.UI.XRLabel adjustedFooterXrLabel;
		internal DevExpress.XtraReports.UI.XRPageInfo pageNumberXrPageInfo;
		internal DevExpress.XtraReports.UI.XRLabel receivedFooterXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel shippedFooterXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel producedFooterXrLabel;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMarginBand1;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMarginBand1;
		internal DevExpress.XtraReports.UI.XRLabel usedInProductionDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel usedInProductionHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel usedInProductionFooterXrLabel;
	}

}