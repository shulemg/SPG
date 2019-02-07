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
	public partial class InventoryXtraReport : DevExpress.XtraReports.UI.XtraReport
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
			this.RMitemDescriptionDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.RMitemCodeDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.customerNameDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.quantityDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemTypeDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.reasonDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemDescriptionDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemCodeDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.byPalletDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.dateDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
			this.headerXrPanel = new DevExpress.XtraReports.UI.XRPanel();
			this.lowestRMDescriptionXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.lowestRMItemCodeXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.quantityHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemTypeHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.reasonHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemDescriptionHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemCodeHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.byPalletHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.customerNameHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
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
			this.TopMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.UOMHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.UOMDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			((System.ComponentModel.ISupportInitialize)this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.UOMDetailXrLabel, this.RMitemDescriptionDetailXrLabel, this.RMitemCodeDetailXrLabel, this.customerNameDetailXrLabel, this.quantityDetailXrLabel, this.itemTypeDetailXrLabel, this.reasonDetailXrLabel, this.itemDescriptionDetailXrLabel, this.itemCodeDetailXrLabel, this.byPalletDetailXrLabel, this.dateDetailXrLabel});
			this.Detail.HeightF = 30.0F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//RMitemDescriptionDetailXrLabel
			//
			this.RMitemDescriptionDetailXrLabel.CanGrow = false;
			this.RMitemDescriptionDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.RMitemDescriptionDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(450.0F, 0.0F);
			this.RMitemDescriptionDetailXrLabel.Name = "RMitemDescriptionDetailXrLabel";
			this.RMitemDescriptionDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.RMitemDescriptionDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.RMitemDescriptionDetailXrLabel.SizeF = new System.Drawing.SizeF(149.0F, 30.0F);
			this.RMitemDescriptionDetailXrLabel.Text = "itemDescriptionDetailXrLabel";
			this.RMitemDescriptionDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//RMitemCodeDetailXrLabel
			//
			this.RMitemCodeDetailXrLabel.CanGrow = false;
			this.RMitemCodeDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.RMitemCodeDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(317.0F, 0.0F);
			this.RMitemCodeDetailXrLabel.Name = "RMitemCodeDetailXrLabel";
			this.RMitemCodeDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.RMitemCodeDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.RMitemCodeDetailXrLabel.SizeF = new System.Drawing.SizeF(145.0F, 30.0F);
			this.RMitemCodeDetailXrLabel.Text = "itemCodeDetailXrLabel";
			this.RMitemCodeDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//customerNameDetailXrLabel
			//
			this.customerNameDetailXrLabel.CanGrow = false;
			this.customerNameDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.customerNameDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(118.0F, 0.0F);
			this.customerNameDetailXrLabel.Name = "customerNameDetailXrLabel";
			this.customerNameDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.customerNameDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.customerNameDetailXrLabel.SizeF = new System.Drawing.SizeF(150.0F, 30.0F);
			this.customerNameDetailXrLabel.Text = "customerNameDetailXrLabel";
			this.customerNameDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//quantityDetailXrLabel
			//
			this.quantityDetailXrLabel.CanGrow = false;
			this.quantityDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.quantityDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(283.0F, 0.0F);
			this.quantityDetailXrLabel.Name = "quantityDetailXrLabel";
			this.quantityDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.quantityDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.quantityDetailXrLabel.SizeF = new System.Drawing.SizeF(140.0F, 30.0F);
			this.quantityDetailXrLabel.Text = "quantityDetailXrLabel";
			this.quantityDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//itemTypeDetailXrLabel
			//
			this.itemTypeDetailXrLabel.CanGrow = false;
			this.itemTypeDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.itemTypeDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(483.0F, 0.0F);
			this.itemTypeDetailXrLabel.Name = "itemTypeDetailXrLabel";
			this.itemTypeDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.itemTypeDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemTypeDetailXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 30.0F);
			this.itemTypeDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.itemTypeDetailXrLabel.Text = "itemTypeDetailXrLabel";
			this.itemTypeDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//reasonDetailXrLabel
			//
			this.reasonDetailXrLabel.CanGrow = false;
			this.reasonDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.reasonDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(492.0F, 0.0F);
			this.reasonDetailXrLabel.Name = "reasonDetailXrLabel";
			this.reasonDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.reasonDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.reasonDetailXrLabel.SizeF = new System.Drawing.SizeF(145.0F, 30.0F);
			this.reasonDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.reasonDetailXrLabel.Text = "reasonDetailXrLabel";
			this.reasonDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//itemDescriptionDetailXrLabel
			//
			this.itemDescriptionDetailXrLabel.CanGrow = false;
			this.itemDescriptionDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.itemDescriptionDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(413.0F, 0.0F);
			this.itemDescriptionDetailXrLabel.Name = "itemDescriptionDetailXrLabel";
			this.itemDescriptionDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.itemDescriptionDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemDescriptionDetailXrLabel.SizeF = new System.Drawing.SizeF(149.0F, 30.0F);
			this.itemDescriptionDetailXrLabel.Text = "itemDescriptionDetailXrLabel";
			this.itemDescriptionDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//itemCodeDetailXrLabel
			//
			this.itemCodeDetailXrLabel.CanGrow = false;
			this.itemCodeDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.itemCodeDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(268.0F, 0.0F);
			this.itemCodeDetailXrLabel.Name = "itemCodeDetailXrLabel";
			this.itemCodeDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.itemCodeDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemCodeDetailXrLabel.SizeF = new System.Drawing.SizeF(145.0F, 30.0F);
			this.itemCodeDetailXrLabel.Text = "itemCodeDetailXrLabel";
			this.itemCodeDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//byPalletDetailXrLabel
			//
			this.byPalletDetailXrLabel.CanGrow = false;
			this.byPalletDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.byPalletDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(660.0F, 0.0F);
			this.byPalletDetailXrLabel.Name = "byPalletDetailXrLabel";
			this.byPalletDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.byPalletDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.byPalletDetailXrLabel.SizeF = new System.Drawing.SizeF(140.0F, 30.0F);
			this.byPalletDetailXrLabel.StylePriority.UseTextAlignment = false;
			this.byPalletDetailXrLabel.Text = "byPalletDetailXrLabel";
			this.byPalletDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//dateDetailXrLabel
			//
			this.dateDetailXrLabel.CanGrow = false;
			this.dateDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.dateDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0.0F, 0.0F);
			this.dateDetailXrLabel.Name = "dateDetailXrLabel";
			this.dateDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.dateDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.dateDetailXrLabel.SizeF = new System.Drawing.SizeF(118.0F, 30.0F);
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
			this.headerXrPanel.BorderWidth = 3;
			this.headerXrPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.UOMHeaderXrLabel, this.lowestRMDescriptionXrLabel, this.lowestRMItemCodeXrLabel, this.quantityHeaderXrLabel, this.itemTypeHeaderXrLabel, this.reasonHeaderXrLabel, this.itemDescriptionHeaderXrLabel, this.itemCodeHeaderXrLabel, this.byPalletHeaderXrLabel, this.customerNameHeaderXrLabel, this.dateHeaderXrLabel});
			this.headerXrPanel.LocationFloat = new DevExpress.Utils.PointFloat(0.0F, 0.0F);
			this.headerXrPanel.Name = "headerXrPanel";
			this.headerXrPanel.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.headerXrPanel.SizeF = new System.Drawing.SizeF(800.0F, 50.0F);
			//
			//lowestRMDescriptionXrLabel
			//
			this.lowestRMDescriptionXrLabel.CanGrow = false;
			this.lowestRMDescriptionXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.lowestRMDescriptionXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(325.0F, 0.0F);
			this.lowestRMDescriptionXrLabel.Name = "lowestRMDescriptionXrLabel";
			this.lowestRMDescriptionXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.lowestRMDescriptionXrLabel.SizeF = new System.Drawing.SizeF(149.0F, 50.0F);
			this.lowestRMDescriptionXrLabel.StyleName = "headerXrControlStyle";
			this.lowestRMDescriptionXrLabel.StylePriority.UseFont = false;
			this.lowestRMDescriptionXrLabel.Text = "RM Item Description";
			this.lowestRMDescriptionXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//lowestRMItemCodeXrLabel
			//
			this.lowestRMItemCodeXrLabel.CanGrow = false;
			this.lowestRMItemCodeXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.lowestRMItemCodeXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(325.0F, 0.0F);
			this.lowestRMItemCodeXrLabel.Name = "lowestRMItemCodeXrLabel";
			this.lowestRMItemCodeXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.lowestRMItemCodeXrLabel.SizeF = new System.Drawing.SizeF(145.0F, 50.0F);
			this.lowestRMItemCodeXrLabel.StyleName = "headerXrControlStyle";
			this.lowestRMItemCodeXrLabel.StylePriority.UseFont = false;
			this.lowestRMItemCodeXrLabel.Text = "Lowest RM Item #";
			this.lowestRMItemCodeXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//quantityHeaderXrLabel
			//
			this.quantityHeaderXrLabel.CanGrow = false;
			this.quantityHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.quantityHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(283.0F, 0.0F);
			this.quantityHeaderXrLabel.Name = "quantityHeaderXrLabel";
			this.quantityHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.quantityHeaderXrLabel.SizeF = new System.Drawing.SizeF(140.0F, 50.0F);
			this.quantityHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.quantityHeaderXrLabel.StylePriority.UseFont = false;
			this.quantityHeaderXrLabel.Text = "Qty";
			this.quantityHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemTypeHeaderXrLabel
			//
			this.itemTypeHeaderXrLabel.CanGrow = false;
			this.itemTypeHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.itemTypeHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(483.0F, 0.0F);
			this.itemTypeHeaderXrLabel.Name = "itemTypeHeaderXrLabel";
			this.itemTypeHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemTypeHeaderXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 50.0F);
			this.itemTypeHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.itemTypeHeaderXrLabel.StylePriority.UseFont = false;
			this.itemTypeHeaderXrLabel.Text = "Item Type";
			this.itemTypeHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//reasonHeaderXrLabel
			//
			this.reasonHeaderXrLabel.CanGrow = false;
			this.reasonHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.reasonHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(500.0F, 0.0F);
			this.reasonHeaderXrLabel.Name = "reasonHeaderXrLabel";
			this.reasonHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.reasonHeaderXrLabel.SizeF = new System.Drawing.SizeF(145.0F, 50.0F);
			this.reasonHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.reasonHeaderXrLabel.StylePriority.UseFont = false;
			this.reasonHeaderXrLabel.Text = "Reason";
			this.reasonHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemDescriptionHeaderXrLabel
			//
			this.itemDescriptionHeaderXrLabel.CanGrow = false;
			this.itemDescriptionHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.itemDescriptionHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(413.0F, 0.0F);
			this.itemDescriptionHeaderXrLabel.Name = "itemDescriptionHeaderXrLabel";
			this.itemDescriptionHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemDescriptionHeaderXrLabel.SizeF = new System.Drawing.SizeF(149.0F, 50.0F);
			this.itemDescriptionHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.itemDescriptionHeaderXrLabel.StylePriority.UseFont = false;
			this.itemDescriptionHeaderXrLabel.Text = "Item Description";
			this.itemDescriptionHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemCodeHeaderXrLabel
			//
			this.itemCodeHeaderXrLabel.CanGrow = false;
			this.itemCodeHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.itemCodeHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(268.0F, 0.0F);
			this.itemCodeHeaderXrLabel.Name = "itemCodeHeaderXrLabel";
			this.itemCodeHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemCodeHeaderXrLabel.SizeF = new System.Drawing.SizeF(145.0F, 50.0F);
			this.itemCodeHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.itemCodeHeaderXrLabel.StylePriority.UseFont = false;
			this.itemCodeHeaderXrLabel.Text = "Item #";
			this.itemCodeHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//byPalletHeaderXrLabel
			//
			this.byPalletHeaderXrLabel.CanGrow = false;
			this.byPalletHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.byPalletHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(660.0F, 0.0F);
			this.byPalletHeaderXrLabel.Name = "byPalletHeaderXrLabel";
			this.byPalletHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.byPalletHeaderXrLabel.SizeF = new System.Drawing.SizeF(140.0F, 50.0F);
			this.byPalletHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.byPalletHeaderXrLabel.StylePriority.UseFont = false;
			this.byPalletHeaderXrLabel.Text = "By Pallet";
			this.byPalletHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//customerNameHeaderXrLabel
			//
			this.customerNameHeaderXrLabel.CanGrow = false;
			this.customerNameHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.customerNameHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(118.0F, 0.0F);
			this.customerNameHeaderXrLabel.Name = "customerNameHeaderXrLabel";
			this.customerNameHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.customerNameHeaderXrLabel.SizeF = new System.Drawing.SizeF(150.0F, 50.0F);
			this.customerNameHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.customerNameHeaderXrLabel.StylePriority.UseFont = false;
			this.customerNameHeaderXrLabel.Text = "Customer";
			this.customerNameHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//dateHeaderXrLabel
			//
			this.dateHeaderXrLabel.CanGrow = false;
			this.dateHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.dateHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0.0F, 0.0F);
			this.dateHeaderXrLabel.Name = "dateHeaderXrLabel";
			this.dateHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.dateHeaderXrLabel.SizeF = new System.Drawing.SizeF(118.0F, 50.0F);
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
			this.pageNumberXrPageInfo.Format = "Page:  {0} / {1}";
			this.pageNumberXrPageInfo.LocationFloat = new DevExpress.Utils.PointFloat(700.0F, 0.0F);
			this.pageNumberXrPageInfo.Name = "pageNumberXrPageInfo";
			this.pageNumberXrPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.pageNumberXrPageInfo.SizeF = new System.Drawing.SizeF(100.0F, 25.0F);
			this.pageNumberXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
			//ReportHeader
			//
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.printDateXrPageInfo, this.reportCriteriaXrLabel, this.reportTitleXrLabel});
			this.ReportHeader.HeightF = 86.0F;
			this.ReportHeader.KeepTogether = true;
			this.ReportHeader.Name = "ReportHeader";
			//
			//printDateXrPageInfo
			//
			this.printDateXrPageInfo.LocationFloat = new DevExpress.Utils.PointFloat(650.0F, 50.0F);
			this.printDateXrPageInfo.Name = "printDateXrPageInfo";
			this.printDateXrPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.printDateXrPageInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
			this.printDateXrPageInfo.SizeF = new System.Drawing.SizeF(150.0F, 35.0F);
			this.printDateXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//reportCriteriaXrLabel
			//
			this.reportCriteriaXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0.0F, 50.0F);
			this.reportCriteriaXrLabel.Name = "reportCriteriaXrLabel";
			this.reportCriteriaXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.reportCriteriaXrLabel.SizeF = new System.Drawing.SizeF(625.0F, 35.0F);
			this.reportCriteriaXrLabel.Text = "reportCriteriaXrLabel";
			this.reportCriteriaXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//reportTitleXrLabel
			//
			this.reportTitleXrLabel.Font = new System.Drawing.Font("Tahoma", 18.0F);
			this.reportTitleXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0.0F, 0.0F);
			this.reportTitleXrLabel.Name = "reportTitleXrLabel";
			this.reportTitleXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.reportTitleXrLabel.SizeF = new System.Drawing.SizeF(800.0F, 50.0F);
			this.reportTitleXrLabel.Text = "reportTitleXrLabel";
			this.reportTitleXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
			//UOMHeaderXrLabel
			//
			this.UOMHeaderXrLabel.CanGrow = false;
			this.UOMHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.UOMHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(325.0F, 0.0F);
			this.UOMHeaderXrLabel.Name = "UOMHeaderXrLabel";
			this.UOMHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.UOMHeaderXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 50.0F);
			this.UOMHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.UOMHeaderXrLabel.StylePriority.UseFont = false;
			this.UOMHeaderXrLabel.Text = "Unit Of Measure";
			this.UOMHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//UOMDetailXrLabel
			//
			this.UOMDetailXrLabel.CanGrow = false;
			this.UOMDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.UOMDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(450.0F, 0.0F);
			this.UOMDetailXrLabel.Name = "UOMDetailXrLabel";
			this.UOMDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.UOMDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.UOMDetailXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 30.0F);
			this.UOMDetailXrLabel.Text = "customerNameDetailXrLabel";
			this.UOMDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//InventoryXtraReport
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.PageHeader, this.PageFooter, this.ReportHeader, this.TopMarginBand1, this.BottomMarginBand1});
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
		internal DevExpress.XtraReports.UI.XRControlStyle headerXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle footerXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle detailOddXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle detailEvenXrControlStyle;
		internal DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		internal DevExpress.XtraReports.UI.XRPageInfo printDateXrPageInfo;
		internal DevExpress.XtraReports.UI.XRLabel reportCriteriaXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel reportTitleXrLabel;
		internal DevExpress.XtraReports.UI.XRPanel headerXrPanel;
		internal DevExpress.XtraReports.UI.XRLabel quantityHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemTypeHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel reasonHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemDescriptionHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemCodeHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel byPalletHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel customerNameHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel dateHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel quantityDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemTypeDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel reasonDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemDescriptionDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemCodeDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel byPalletDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel dateDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel customerNameDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRPageInfo pageNumberXrPageInfo;
		internal DevExpress.XtraReports.UI.XRLabel RMitemCodeDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel lowestRMDescriptionXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel lowestRMItemCodeXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel RMitemDescriptionDetailXrLabel;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMarginBand1;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMarginBand1;
		internal DevExpress.XtraReports.UI.XRLabel UOMDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel UOMHeaderXrLabel;
	}

}