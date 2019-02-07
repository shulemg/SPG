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
	public partial class TransportationXtraReport : DevExpress.XtraReports.UI.XtraReport
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
			this.lpnDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.expirationDateDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.carrierDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.trailerDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.sealDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.poDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.quantityDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.vendorDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.destinationDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.deliveryNoteNumberDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.bolDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemDescriptionDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemCodeDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.lotDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.customerNameDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.shiftDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.dateDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
			this.headerXrPanel = new DevExpress.XtraReports.UI.XRPanel();
			this.lpnHeadeerXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.expirationDateHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.sealHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.trailerHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.carrierHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.poHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.quantityHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.vendorHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.destinationHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.deliveryNoteNumberHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.bolHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemDescriptionHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemCodeHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.lotHeadeerXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.customerNameHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.shiftHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.dateHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
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
			this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
			this.footerXrPanel = new DevExpress.XtraReports.UI.XRPanel();
			this.quantityFooterXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.TopMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
			((System.ComponentModel.ISupportInitialize)this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.lpnDetailXrLabel, this.expirationDateDetailXrLabel, this.carrierDetailXrLabel, this.trailerDetailXrLabel, this.sealDetailXrLabel, this.poDetailXrLabel, this.quantityDetailXrLabel, this.vendorDetailXrLabel, this.destinationDetailXrLabel, this.deliveryNoteNumberDetailXrLabel, this.bolDetailXrLabel, this.itemDescriptionDetailXrLabel, this.itemCodeDetailXrLabel, this.lotDetailXrLabel, this.customerNameDetailXrLabel, this.shiftDetailXrLabel, this.dateDetailXrLabel});
			this.Detail.HeightF = 30.0F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//lpnDetailXrLabel
			//
			this.lpnDetailXrLabel.CanGrow = false;
			this.lpnDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.lpnDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(614.0F, 0F);
			this.lpnDetailXrLabel.Name = "lpnDetailXrLabel";
			this.lpnDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.lpnDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.lpnDetailXrLabel.SizeF = new System.Drawing.SizeF(54.04169F, 30.0F);
			this.lpnDetailXrLabel.Text = "lpnDetailXrLabel";
			this.lpnDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.lpnDetailXrLabel.Visible = false;
			//
			//expirationDateDetailXrLabel
			//
			this.expirationDateDetailXrLabel.CanGrow = false;
			this.expirationDateDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.expirationDateDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(729.0416F, 0F);
			this.expirationDateDetailXrLabel.Name = "expirationDateDetailXrLabel";
			this.expirationDateDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.expirationDateDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.expirationDateDetailXrLabel.SizeF = new System.Drawing.SizeF(60.0F, 30.0F);
			this.expirationDateDetailXrLabel.Text = "dateDetailXrLabel";
			this.expirationDateDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//carrierDetailXrLabel
			//
			this.carrierDetailXrLabel.CanGrow = false;
			this.carrierDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.carrierDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(898.1667F, 0F);
			this.carrierDetailXrLabel.Name = "carrierDetailXrLabel";
			this.carrierDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.carrierDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.carrierDetailXrLabel.SizeF = new System.Drawing.SizeF(51.33337F, 30.0F);
			this.carrierDetailXrLabel.Text = "carrierDetailXrLabel";
			this.carrierDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//trailerDetailXrLabel
			//
			this.trailerDetailXrLabel.CanGrow = false;
			this.trailerDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.trailerDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(949.5001F, 0F);
			this.trailerDetailXrLabel.Name = "trailerDetailXrLabel";
			this.trailerDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.trailerDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.trailerDetailXrLabel.SizeF = new System.Drawing.SizeF(52.58331F, 30.0F);
			this.trailerDetailXrLabel.Text = "trailerDetailXrLabel";
			this.trailerDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//sealDetailXrLabel
			//
			this.sealDetailXrLabel.CanGrow = false;
			this.sealDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.sealDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1002.083F, 0F);
			this.sealDetailXrLabel.Name = "sealDetailXrLabel";
			this.sealDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.sealDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.sealDetailXrLabel.SizeF = new System.Drawing.SizeF(43.0F, 30.0F);
			this.sealDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.sealDetailXrLabel.Text = "sealDetailXrLabel";
			this.sealDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//poDetailXrLabel
			//
			this.poDetailXrLabel.CanGrow = false;
			this.poDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.poDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(248.0F, 0F);
			this.poDetailXrLabel.Name = "poDetailXrLabel";
			this.poDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.poDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.poDetailXrLabel.SizeF = new System.Drawing.SizeF(51.0F, 30.0F);
			this.poDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.poDetailXrLabel.Text = "poDetailXrLabel";
			this.poDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//quantityDetailXrLabel
			//
			this.quantityDetailXrLabel.CanGrow = false;
			this.quantityDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.quantityDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(789.0416F, 0F);
			this.quantityDetailXrLabel.Name = "quantityDetailXrLabel";
			this.quantityDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.quantityDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.quantityDetailXrLabel.SizeF = new System.Drawing.SizeF(36.12506F, 30.0F);
			this.quantityDetailXrLabel.Text = "quantityDetailXrLabel";
			this.quantityDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//vendorDetailXrLabel
			//
			this.vendorDetailXrLabel.CanGrow = false;
			this.vendorDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.vendorDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(825.1667F, 0F);
			this.vendorDetailXrLabel.Name = "vendorDetailXrLabel";
			this.vendorDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.vendorDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.vendorDetailXrLabel.SizeF = new System.Drawing.SizeF(73.0F, 30.0F);
			this.vendorDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.vendorDetailXrLabel.Text = "vendorDetailXrLabel";
			this.vendorDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//destinationDetailXrLabel
			//
			this.destinationDetailXrLabel.CanGrow = false;
			this.destinationDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.destinationDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(352.0F, 0F);
			this.destinationDetailXrLabel.Name = "destinationDetailXrLabel";
			this.destinationDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.destinationDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.destinationDetailXrLabel.SizeF = new System.Drawing.SizeF(98.0F, 30.0F);
			this.destinationDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.destinationDetailXrLabel.Text = "destinationDetailXrLabel";
			this.destinationDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//deliveryNoteNumberDetailXrLabel
			//
			this.deliveryNoteNumberDetailXrLabel.CanGrow = false;
			this.deliveryNoteNumberDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.deliveryNoteNumberDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(299.0F, 0F);
			this.deliveryNoteNumberDetailXrLabel.Name = "deliveryNoteNumberDetailXrLabel";
			this.deliveryNoteNumberDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.deliveryNoteNumberDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.deliveryNoteNumberDetailXrLabel.SizeF = new System.Drawing.SizeF(53.0F, 30.0F);
			this.deliveryNoteNumberDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.deliveryNoteNumberDetailXrLabel.Text = "deliveryNoteNumberDetailXrLabel";
			this.deliveryNoteNumberDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//bolDetailXrLabel
			//
			this.bolDetailXrLabel.CanGrow = false;
			this.bolDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.bolDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(192.0F, 0F);
			this.bolDetailXrLabel.Name = "bolDetailXrLabel";
			this.bolDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.bolDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.bolDetailXrLabel.SizeF = new System.Drawing.SizeF(56.0F, 30.0F);
			this.bolDetailXrLabel.Text = "bolDetailXrLabel";
			this.bolDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//itemDescriptionDetailXrLabel
			//
			this.itemDescriptionDetailXrLabel.CanGrow = false;
			this.itemDescriptionDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.itemDescriptionDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(511.0F, 0F);
			this.itemDescriptionDetailXrLabel.Name = "itemDescriptionDetailXrLabel";
			this.itemDescriptionDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.itemDescriptionDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemDescriptionDetailXrLabel.SizeF = new System.Drawing.SizeF(103.0F, 30.0F);
			this.itemDescriptionDetailXrLabel.Text = "itemDescriptionDetailXrLabel";
			this.itemDescriptionDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//itemCodeDetailXrLabel
			//
			this.itemCodeDetailXrLabel.CanGrow = false;
			this.itemCodeDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.itemCodeDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(450.0F, 0F);
			this.itemCodeDetailXrLabel.Name = "itemCodeDetailXrLabel";
			this.itemCodeDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.itemCodeDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemCodeDetailXrLabel.SizeF = new System.Drawing.SizeF(61.0F, 30.0F);
			this.itemCodeDetailXrLabel.Text = "itemCodeDetailXrLabel";
			this.itemCodeDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//lotDetailXrLabel
			//
			this.lotDetailXrLabel.CanGrow = false;
			this.lotDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.lotDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(668.0416F, 0F);
			this.lotDetailXrLabel.Name = "lotDetailXrLabel";
			this.lotDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.lotDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.lotDetailXrLabel.SizeF = new System.Drawing.SizeF(60.99994F, 30.0F);
			this.lotDetailXrLabel.Text = "lotDetailXrLabel";
			this.lotDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//customerNameDetailXrLabel
			//
			this.customerNameDetailXrLabel.CanGrow = false;
			this.customerNameDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.customerNameDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(108.0F, 0F);
			this.customerNameDetailXrLabel.Name = "customerNameDetailXrLabel";
			this.customerNameDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.customerNameDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.customerNameDetailXrLabel.SizeF = new System.Drawing.SizeF(84.0F, 30.0F);
			this.customerNameDetailXrLabel.Text = "customerNameDetailXrLabel";
			this.customerNameDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//shiftDetailXrLabel
			//
			this.shiftDetailXrLabel.CanGrow = false;
			this.shiftDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.shiftDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(56.0F, 0F);
			this.shiftDetailXrLabel.Name = "shiftDetailXrLabel";
			this.shiftDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.shiftDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.shiftDetailXrLabel.SizeF = new System.Drawing.SizeF(52.0F, 30.0F);
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
			this.dateDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.dateDetailXrLabel.SizeF = new System.Drawing.SizeF(56.0F, 30.0F);
			this.dateDetailXrLabel.Text = "dateDetailXrLabel";
			this.dateDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
			this.headerXrPanel.BorderWidth = 3.0F;
			this.headerXrPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.lpnHeadeerXrLabel, this.expirationDateHeaderXrLabel, this.sealHeaderXrLabel, this.trailerHeaderXrLabel, this.carrierHeaderXrLabel, this.poHeaderXrLabel, this.quantityHeaderXrLabel, this.vendorHeaderXrLabel, this.destinationHeaderXrLabel, this.deliveryNoteNumberHeaderXrLabel, this.bolHeaderXrLabel, this.itemDescriptionHeaderXrLabel, this.itemCodeHeaderXrLabel, this.lotHeadeerXrLabel, this.customerNameHeaderXrLabel, this.shiftHeaderXrLabel, this.dateHeaderXrLabel});
			this.headerXrPanel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.headerXrPanel.Name = "headerXrPanel";
			this.headerXrPanel.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.headerXrPanel.SizeF = new System.Drawing.SizeF(1050.0F, 50.0F);
			//
			//lpnHeadeerXrLabel
			//
			this.lpnHeadeerXrLabel.CanGrow = false;
			this.lpnHeadeerXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.lpnHeadeerXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(614.0F, 0F);
			this.lpnHeadeerXrLabel.Name = "lpnHeadeerXrLabel";
			this.lpnHeadeerXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.lpnHeadeerXrLabel.SizeF = new System.Drawing.SizeF(54.04163F, 50.0F);
			this.lpnHeadeerXrLabel.StyleName = "headerXrControlStyle";
			this.lpnHeadeerXrLabel.StylePriority.UseFont = false;
			this.lpnHeadeerXrLabel.Text = "LPN";
			this.lpnHeadeerXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.lpnHeadeerXrLabel.Visible = false;
			//
			//expirationDateHeaderXrLabel
			//
			this.expirationDateHeaderXrLabel.CanGrow = false;
			this.expirationDateHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.expirationDateHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(729.0416F, 0F);
			this.expirationDateHeaderXrLabel.Name = "expirationDateHeaderXrLabel";
			this.expirationDateHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.expirationDateHeaderXrLabel.SizeF = new System.Drawing.SizeF(60.0F, 50.0F);
			this.expirationDateHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.expirationDateHeaderXrLabel.StylePriority.UseFont = false;
			this.expirationDateHeaderXrLabel.Text = "Expiration Date";
			this.expirationDateHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//sealHeaderXrLabel
			//
			this.sealHeaderXrLabel.CanGrow = false;
			this.sealHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.sealHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(1002.083F, 0F);
			this.sealHeaderXrLabel.Name = "sealHeaderXrLabel";
			this.sealHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.sealHeaderXrLabel.SizeF = new System.Drawing.SizeF(43.0F, 50.0F);
			this.sealHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.sealHeaderXrLabel.StylePriority.UseFont = false;
			this.sealHeaderXrLabel.Text = "Seal #";
			this.sealHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//trailerHeaderXrLabel
			//
			this.trailerHeaderXrLabel.CanGrow = false;
			this.trailerHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.trailerHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(949.5001F, 0F);
			this.trailerHeaderXrLabel.Name = "trailerHeaderXrLabel";
			this.trailerHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.trailerHeaderXrLabel.SizeF = new System.Drawing.SizeF(52.58331F, 50.0F);
			this.trailerHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.trailerHeaderXrLabel.StylePriority.UseFont = false;
			this.trailerHeaderXrLabel.Text = "Trailer #";
			this.trailerHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//carrierHeaderXrLabel
			//
			this.carrierHeaderXrLabel.CanGrow = false;
			this.carrierHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.carrierHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(898.1667F, 0F);
			this.carrierHeaderXrLabel.Name = "carrierHeaderXrLabel";
			this.carrierHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.carrierHeaderXrLabel.SizeF = new System.Drawing.SizeF(51.3335F, 50.0F);
			this.carrierHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.carrierHeaderXrLabel.StylePriority.UseFont = false;
			this.carrierHeaderXrLabel.Text = "Carrier";
			this.carrierHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//poHeaderXrLabel
			//
			this.poHeaderXrLabel.CanGrow = false;
			this.poHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.poHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(248.0F, 0F);
			this.poHeaderXrLabel.Name = "poHeaderXrLabel";
			this.poHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.poHeaderXrLabel.SizeF = new System.Drawing.SizeF(51.0F, 50.0F);
			this.poHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.poHeaderXrLabel.StylePriority.UseFont = false;
			this.poHeaderXrLabel.Text = "PO #";
			this.poHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//quantityHeaderXrLabel
			//
			this.quantityHeaderXrLabel.CanGrow = false;
			this.quantityHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.quantityHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(789.0416F, 0F);
			this.quantityHeaderXrLabel.Name = "quantityHeaderXrLabel";
			this.quantityHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.quantityHeaderXrLabel.SizeF = new System.Drawing.SizeF(36.12506F, 50.0F);
			this.quantityHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.quantityHeaderXrLabel.StylePriority.UseFont = false;
			this.quantityHeaderXrLabel.Text = "Qty";
			this.quantityHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//vendorHeaderXrLabel
			//
			this.vendorHeaderXrLabel.CanGrow = false;
			this.vendorHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.vendorHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(825.1667F, 0F);
			this.vendorHeaderXrLabel.Name = "vendorHeaderXrLabel";
			this.vendorHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.vendorHeaderXrLabel.SizeF = new System.Drawing.SizeF(73.0F, 50.0F);
			this.vendorHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.vendorHeaderXrLabel.StylePriority.UseFont = false;
			this.vendorHeaderXrLabel.Text = "Vendor";
			this.vendorHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//destinationHeaderXrLabel
			//
			this.destinationHeaderXrLabel.CanGrow = false;
			this.destinationHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.destinationHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(352.0F, 0F);
			this.destinationHeaderXrLabel.Name = "destinationHeaderXrLabel";
			this.destinationHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.destinationHeaderXrLabel.SizeF = new System.Drawing.SizeF(98.0F, 50.0F);
			this.destinationHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.destinationHeaderXrLabel.StylePriority.UseFont = false;
			this.destinationHeaderXrLabel.Text = "Destination";
			this.destinationHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//deliveryNoteNumberHeaderXrLabel
			//
			this.deliveryNoteNumberHeaderXrLabel.CanGrow = false;
			this.deliveryNoteNumberHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.deliveryNoteNumberHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(299.0F, 0F);
			this.deliveryNoteNumberHeaderXrLabel.Name = "deliveryNoteNumberHeaderXrLabel";
			this.deliveryNoteNumberHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.deliveryNoteNumberHeaderXrLabel.SizeF = new System.Drawing.SizeF(53.0F, 50.0F);
			this.deliveryNoteNumberHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.deliveryNoteNumberHeaderXrLabel.StylePriority.UseFont = false;
			this.deliveryNoteNumberHeaderXrLabel.Text = "DN #";
			this.deliveryNoteNumberHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//bolHeaderXrLabel
			//
			this.bolHeaderXrLabel.CanGrow = false;
			this.bolHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.bolHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(192.0F, 0F);
			this.bolHeaderXrLabel.Name = "bolHeaderXrLabel";
			this.bolHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.bolHeaderXrLabel.SizeF = new System.Drawing.SizeF(56.0F, 50.0F);
			this.bolHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.bolHeaderXrLabel.StylePriority.UseFont = false;
			this.bolHeaderXrLabel.Text = "BOL #";
			this.bolHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemDescriptionHeaderXrLabel
			//
			this.itemDescriptionHeaderXrLabel.CanGrow = false;
			this.itemDescriptionHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.itemDescriptionHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(511.0F, 0F);
			this.itemDescriptionHeaderXrLabel.Name = "itemDescriptionHeaderXrLabel";
			this.itemDescriptionHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemDescriptionHeaderXrLabel.SizeF = new System.Drawing.SizeF(103.0F, 50.0F);
			this.itemDescriptionHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.itemDescriptionHeaderXrLabel.StylePriority.UseFont = false;
			this.itemDescriptionHeaderXrLabel.Text = "Item Description";
			this.itemDescriptionHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemCodeHeaderXrLabel
			//
			this.itemCodeHeaderXrLabel.CanGrow = false;
			this.itemCodeHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.itemCodeHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(450.0F, 0F);
			this.itemCodeHeaderXrLabel.Name = "itemCodeHeaderXrLabel";
			this.itemCodeHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemCodeHeaderXrLabel.SizeF = new System.Drawing.SizeF(61.0F, 50.0F);
			this.itemCodeHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.itemCodeHeaderXrLabel.StylePriority.UseFont = false;
			this.itemCodeHeaderXrLabel.Text = "Item #";
			this.itemCodeHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//lotHeadeerXrLabel
			//
			this.lotHeadeerXrLabel.CanGrow = false;
			this.lotHeadeerXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.lotHeadeerXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(668.0416F, 0F);
			this.lotHeadeerXrLabel.Name = "lotHeadeerXrLabel";
			this.lotHeadeerXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.lotHeadeerXrLabel.SizeF = new System.Drawing.SizeF(61.0F, 50.0F);
			this.lotHeadeerXrLabel.StyleName = "headerXrControlStyle";
			this.lotHeadeerXrLabel.StylePriority.UseFont = false;
			this.lotHeadeerXrLabel.Text = "Lot";
			this.lotHeadeerXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//customerNameHeaderXrLabel
			//
			this.customerNameHeaderXrLabel.CanGrow = false;
			this.customerNameHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.customerNameHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(108.0F, 0F);
			this.customerNameHeaderXrLabel.Name = "customerNameHeaderXrLabel";
			this.customerNameHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.customerNameHeaderXrLabel.SizeF = new System.Drawing.SizeF(84.0F, 50.0F);
			this.customerNameHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.customerNameHeaderXrLabel.StylePriority.UseFont = false;
			this.customerNameHeaderXrLabel.Text = "Customer";
			this.customerNameHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//shiftHeaderXrLabel
			//
			this.shiftHeaderXrLabel.CanGrow = false;
			this.shiftHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.shiftHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(56.0F, 0F);
			this.shiftHeaderXrLabel.Name = "shiftHeaderXrLabel";
			this.shiftHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.shiftHeaderXrLabel.SizeF = new System.Drawing.SizeF(52.0F, 50.0F);
			this.shiftHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.shiftHeaderXrLabel.StylePriority.UseFont = false;
			this.shiftHeaderXrLabel.Text = "Shift";
			this.shiftHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//dateHeaderXrLabel
			//
			this.dateHeaderXrLabel.CanGrow = false;
			this.dateHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.dateHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.dateHeaderXrLabel.Name = "dateHeaderXrLabel";
			this.dateHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.dateHeaderXrLabel.SizeF = new System.Drawing.SizeF(56.0F, 50.0F);
			this.dateHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.dateHeaderXrLabel.StylePriority.UseFont = false;
			this.dateHeaderXrLabel.Text = "Date";
			this.dateHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
			this.pageNumberXrPageInfo.LocationFloat = new DevExpress.Utils.PointFloat(950.0F, 0F);
			this.pageNumberXrPageInfo.Name = "pageNumberXrPageInfo";
			this.pageNumberXrPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.pageNumberXrPageInfo.SizeF = new System.Drawing.SizeF(100.0F, 25.0F);
			this.pageNumberXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			this.pageNumberXrPageInfo.TextFormatString = "Page:  {0} / {1}";
			//
			//headerXrControlStyle
			//
			this.headerXrControlStyle.BackColor = System.Drawing.Color.FromArgb((int)((byte)230), (int)((byte)235), (int)((byte)247));
			this.headerXrControlStyle.BorderColor = System.Drawing.Color.FromArgb((int)((byte)194), (int)((byte)202), (int)((byte)213));
			this.headerXrControlStyle.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.headerXrControlStyle.BorderWidth = 1.0F;
			this.headerXrControlStyle.Font = new System.Drawing.Font("Tahoma", 6.5F, System.Drawing.FontStyle.Bold);
			this.headerXrControlStyle.ForeColor = System.Drawing.SystemColors.ControlText;
			this.headerXrControlStyle.Name = "headerXrControlStyle";
			//
			//footerXrControlStyle
			//
			this.footerXrControlStyle.BackColor = System.Drawing.Color.FromArgb((int)((byte)230), (int)((byte)235), (int)((byte)247));
			this.footerXrControlStyle.BorderColor = System.Drawing.Color.FromArgb((int)((byte)194), (int)((byte)202), (int)((byte)213));
			this.footerXrControlStyle.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.footerXrControlStyle.BorderWidth = 1.0F;
			this.footerXrControlStyle.Font = new System.Drawing.Font("Tahoma", 6.5F);
			this.footerXrControlStyle.ForeColor = System.Drawing.Color.Black;
			this.footerXrControlStyle.Name = "footerXrControlStyle";
			//
			//detailOddXrControlStyle
			//
			this.detailOddXrControlStyle.BackColor = System.Drawing.Color.LightGray;
			this.detailOddXrControlStyle.BorderColor = System.Drawing.Color.FromArgb((int)((byte)176), (int)((byte)187), (int)((byte)169));
			this.detailOddXrControlStyle.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.detailOddXrControlStyle.BorderWidth = 1.0F;
			this.detailOddXrControlStyle.Font = new System.Drawing.Font("Tahoma", 6.5F);
			this.detailOddXrControlStyle.ForeColor = System.Drawing.Color.Black;
			this.detailOddXrControlStyle.Name = "detailOddXrControlStyle";
			//
			//detailEvenXrControlStyle
			//
			this.detailEvenXrControlStyle.BackColor = System.Drawing.Color.Transparent;
			this.detailEvenXrControlStyle.BorderColor = System.Drawing.Color.FromArgb((int)((byte)196), (int)((byte)207), (int)((byte)189));
			this.detailEvenXrControlStyle.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.detailEvenXrControlStyle.BorderWidth = 1.0F;
			this.detailEvenXrControlStyle.Font = new System.Drawing.Font("Tahoma", 6.5F);
			this.detailEvenXrControlStyle.ForeColor = System.Drawing.Color.Black;
			this.detailEvenXrControlStyle.Name = "detailEvenXrControlStyle";
			//
			//ReportHeader
			//
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.printDateXrPageInfo, this.reportCriteriaXrLabel, this.reportTitleXrLabel});
			this.ReportHeader.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.ReportHeader.HeightF = 86.0F;
			this.ReportHeader.KeepTogether = true;
			this.ReportHeader.Name = "ReportHeader";
			this.ReportHeader.StylePriority.UseFont = false;
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
			this.reportCriteriaXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 50.0F);
			this.reportCriteriaXrLabel.Name = "reportCriteriaXrLabel";
			this.reportCriteriaXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.reportCriteriaXrLabel.SizeF = new System.Drawing.SizeF(635.0F, 35.0F);
			this.reportCriteriaXrLabel.Text = "reportCriteriaXrLabel";
			this.reportCriteriaXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//reportTitleXrLabel
			//
			this.reportTitleXrLabel.Font = new System.Drawing.Font("Tahoma", 18.0F);
			this.reportTitleXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.reportTitleXrLabel.Name = "reportTitleXrLabel";
			this.reportTitleXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.reportTitleXrLabel.SizeF = new System.Drawing.SizeF(1050.0F, 50.0F);
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
			this.footerXrPanel.BorderWidth = 3.0F;
			this.footerXrPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.quantityFooterXrLabel});
			this.footerXrPanel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.footerXrPanel.Name = "footerXrPanel";
			this.footerXrPanel.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.footerXrPanel.SizeF = new System.Drawing.SizeF(1050.0F, 30.0F);
			//
			//quantityFooterXrLabel
			//
			this.quantityFooterXrLabel.CanGrow = false;
			this.quantityFooterXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(777.5834F, 0F);
			this.quantityFooterXrLabel.Name = "quantityFooterXrLabel";
			this.quantityFooterXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.quantityFooterXrLabel.SizeF = new System.Drawing.SizeF(47.58325F, 30.0F);
			this.quantityFooterXrLabel.StyleName = "footerXrControlStyle";
			XrSummary1.FormatString = "{0:#,#}";
			XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
			this.quantityFooterXrLabel.Summary = XrSummary1;
			this.quantityFooterXrLabel.Text = "quantityFooterXrLabel";
			this.quantityFooterXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
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
			//TransportationXtraReport
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.PageHeader, this.PageFooter, this.ReportHeader, this.ReportFooter, this.TopMarginBand1, this.BottomMarginBand1});
			this.Landscape = true;
			this.Margins = new System.Drawing.Printing.Margins(25, 25, 50, 50);
			this.PageHeight = 850;
			this.PageWidth = 1100;
			this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {this.headerXrControlStyle, this.footerXrControlStyle, this.detailOddXrControlStyle, this.detailEvenXrControlStyle});
			this.Version = "17.2";
			((System.ComponentModel.ISupportInitialize)this).EndInit();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			expirationDateDetailXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(expirationDateDetailXrLabel_BeforePrint);
		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
		internal DevExpress.XtraReports.UI.PageFooterBand PageFooter;
		internal DevExpress.XtraReports.UI.XRControlStyle headerXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle footerXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle detailOddXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle detailEvenXrControlStyle;
		internal DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		internal DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
		internal DevExpress.XtraReports.UI.XRPageInfo printDateXrPageInfo;
		internal DevExpress.XtraReports.UI.XRLabel reportCriteriaXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel reportTitleXrLabel;
		internal DevExpress.XtraReports.UI.XRPanel headerXrPanel;
		internal DevExpress.XtraReports.UI.XRLabel sealHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel trailerHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel carrierHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel poHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel quantityHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel vendorHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel destinationHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel deliveryNoteNumberHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel bolHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemDescriptionHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemCodeHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel lotHeadeerXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel customerNameHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel shiftHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel dateHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel carrierDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel trailerDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel sealDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel poDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel quantityDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel vendorDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel destinationDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel deliveryNoteNumberDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel bolDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemDescriptionDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemCodeDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel lotDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel customerNameDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel shiftDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel dateDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRPanel footerXrPanel;
		internal DevExpress.XtraReports.UI.XRLabel quantityFooterXrLabel;
		internal DevExpress.XtraReports.UI.XRPageInfo pageNumberXrPageInfo;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMarginBand1;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMarginBand1;
		internal DevExpress.XtraReports.UI.XRLabel expirationDateDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel expirationDateHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel lpnDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel lpnHeadeerXrLabel;
	}

}