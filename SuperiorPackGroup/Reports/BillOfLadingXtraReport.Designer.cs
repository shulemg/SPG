using System.Text;

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
	public partial class BillOfLadingXtraReport : DevExpress.XtraReports.UI.XtraReport
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillOfLadingXtraReport));
			DevExpress.XtraReports.UI.XRSummary XrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.itemDescriptionXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.palletsXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.weightXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemCodeXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.qtyXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.spgLogoXrPictureBox = new DevExpress.XtraReports.UI.XRPictureBox();
			this.XrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
			this.sealXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.trailerXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.carrierXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.deliveryNoteNumberXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.poXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.toXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.fromXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.bolXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.dateXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
			this.totalPalletWeightXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.palletsTotalXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
			this.totalPalletsXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.totalWeightXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLine1 = new DevExpress.XtraReports.UI.XRLine();
			this.returnsGroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.XrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
			this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
			this.billTo = new DevExpress.XtraReports.UI.XRLabel();
			this.XrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
			this.XrPanel3 = new DevExpress.XtraReports.UI.XRPanel();
			this.XrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrPanel2 = new DevExpress.XtraReports.UI.XRPanel();
			this.freightXrCheckBox = new DevExpress.XtraReports.UI.XRCheckBox();
			this.XrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
			this.XrLine2 = new DevExpress.XtraReports.UI.XRLine();
			this.XrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
			this.notesXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrCrossBandLine1XRCrossBandLine = new DevExpress.XtraReports.UI.XRCrossBandLine();
			this.XrCrossBandLine1XRCrossBandLine2 = new DevExpress.XtraReports.UI.XRCrossBandLine();
			this.XrCrossBandLine1XRCrossBandLine3 = new DevExpress.XtraReports.UI.XRCrossBandLine();
			this.XrCrossBandLine1XRCrossBandLine4 = new DevExpress.XtraReports.UI.XRCrossBandLine();
			this.XrCrossBandLine1XRCrossBandLine5 = new DevExpress.XtraReports.UI.XRCrossBandLine();
			this.XrCrossBandLine1 = new DevExpress.XtraReports.UI.XRCrossBandLine();
			this.TopMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.itemsGroupFooter = new DevExpress.XtraReports.UI.GroupFooterBand();
			this.itemTotalWeightXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemTotalPalletsXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.groupItemDescriptionXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.groupItemCodeXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemTotalQuantityXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemGroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.returnsGroupFooter = new DevExpress.XtraReports.UI.GroupFooterBand();
			this.locationId = new DevExpress.XtraReports.UI.XRLabel();
			((System.ComponentModel.ISupportInitialize)this.XrRichText1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.itemDescriptionXrLabel, this.palletsXrLabel, this.weightXrLabel, this.itemCodeXrLabel, this.qtyXrLabel});
			this.Detail.HeightF = 25.0F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			this.Detail.Visible = false;
			//
			//itemDescriptionXrLabel
			//
			this.itemDescriptionXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.itemDescriptionXrLabel.Font = new System.Drawing.Font("Arial", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.itemDescriptionXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(185.0F, 0F);
			this.itemDescriptionXrLabel.Multiline = true;
			this.itemDescriptionXrLabel.Name = "itemDescriptionXrLabel";
			this.itemDescriptionXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemDescriptionXrLabel.SizeF = new System.Drawing.SizeF(390.0F, 25.0F);
			this.itemDescriptionXrLabel.StylePriority.UseBorders = false;
			this.itemDescriptionXrLabel.StylePriority.UseFont = false;
			this.itemDescriptionXrLabel.StylePriority.UseTextAlignment = false;
			this.itemDescriptionXrLabel.Text = "Item Description";
			this.itemDescriptionXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//palletsXrLabel
			//
			this.palletsXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.palletsXrLabel.Font = new System.Drawing.Font("Arial", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.palletsXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(575.0F, 0F);
			this.palletsXrLabel.Name = "palletsXrLabel";
			this.palletsXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.palletsXrLabel.SizeF = new System.Drawing.SizeF(60.0F, 25.0F);
			this.palletsXrLabel.StylePriority.UseBorders = false;
			this.palletsXrLabel.StylePriority.UseFont = false;
			this.palletsXrLabel.StylePriority.UseTextAlignment = false;
			this.palletsXrLabel.Text = "Pallets";
			this.palletsXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//weightXrLabel
			//
			this.weightXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.weightXrLabel.Font = new System.Drawing.Font("Arial", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.weightXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(635.0F, 0F);
			this.weightXrLabel.Name = "weightXrLabel";
			this.weightXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.weightXrLabel.SizeF = new System.Drawing.SizeF(65.0F, 25.0F);
			this.weightXrLabel.StylePriority.UseBorders = false;
			this.weightXrLabel.StylePriority.UseFont = false;
			this.weightXrLabel.StylePriority.UseTextAlignment = false;
			this.weightXrLabel.Text = "Weight";
			this.weightXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemCodeXrLabel
			//
			this.itemCodeXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.itemCodeXrLabel.Font = new System.Drawing.Font("Arial", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.itemCodeXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(60.0F, 0F);
			this.itemCodeXrLabel.Name = "itemCodeXrLabel";
			this.itemCodeXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemCodeXrLabel.SizeF = new System.Drawing.SizeF(125.0F, 25.0F);
			this.itemCodeXrLabel.StylePriority.UseBorders = false;
			this.itemCodeXrLabel.StylePriority.UseFont = false;
			this.itemCodeXrLabel.StylePriority.UseTextAlignment = false;
			this.itemCodeXrLabel.Text = "Item #";
			this.itemCodeXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//qtyXrLabel
			//
			this.qtyXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.qtyXrLabel.Font = new System.Drawing.Font("Arial", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.qtyXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.qtyXrLabel.Name = "qtyXrLabel";
			this.qtyXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.qtyXrLabel.SizeF = new System.Drawing.SizeF(60.0F, 25.0F);
			this.qtyXrLabel.StylePriority.UseBorders = false;
			this.qtyXrLabel.StylePriority.UseFont = false;
			this.qtyXrLabel.StylePriority.UseTextAlignment = false;
			this.qtyXrLabel.Text = "Qty";
			this.qtyXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//ReportHeader
			//
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.locationId, this.spgLogoXrPictureBox, this.XrLabel34, this.XrLabel16, this.XrLabel15, this.XrLabel14, this.XrLabel13, this.XrLabel12, this.sealXrLabel, this.trailerXrLabel, this.carrierXrLabel, this.deliveryNoteNumberXrLabel, this.poXrLabel, this.XrLabel11, this.XrLabel10, this.XrLabel9, this.XrLabel8, this.XrLabel6, this.toXrLabel, this.fromXrLabel, this.XrLabel5, this.XrLabel4, this.bolXrLabel, this.dateXrLabel, this.XrLabel3, this.XrLabel2, this.XrLabel1});
			this.ReportHeader.HeightF = 325.0F;
			this.ReportHeader.KeepTogether = true;
			this.ReportHeader.Name = "ReportHeader";
			//
			//spgLogoXrPictureBox
			//
			this.spgLogoXrPictureBox.Image = (System.Drawing.Image)resources.GetObject("spgLogoXrPictureBox.Image");
			this.spgLogoXrPictureBox.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
			this.spgLogoXrPictureBox.Name = "spgLogoXrPictureBox";
			this.spgLogoXrPictureBox.SizeF = new System.Drawing.SizeF(211.62F, 97.04F);
			this.spgLogoXrPictureBox.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
			//
			//XrLabel34
			//
			this.XrLabel34.Font = new System.Drawing.Font("Arial", 11.0F, System.Drawing.FontStyle.Bold);
			this.XrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
			this.XrLabel34.Multiline = true;
			this.XrLabel34.Name = "XrLabel34";
			this.XrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel34.SizeF = new System.Drawing.SizeF(236.4583F, 72.99998F);
			this.XrLabel34.StylePriority.UseFont = false;
			this.XrLabel34.Text = "Superior Pack Group " + "\r" + "\n" + "2 Bailey Farm Road" + "\r" + "\n" + "Harriman, N.Y. 10926";
			this.XrLabel34.Visible = false;
			//
			//XrLabel16
			//
			this.XrLabel16.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrLabel16.CanGrow = false;
			this.XrLabel16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(187.0F, 300.0F);
			this.XrLabel16.Name = "XrLabel16";
			this.XrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel16.SizeF = new System.Drawing.SizeF(388.0F, 25.0F);
			this.XrLabel16.StylePriority.UseBorders = false;
			this.XrLabel16.StylePriority.UseFont = false;
			this.XrLabel16.StylePriority.UseTextAlignment = false;
			this.XrLabel16.Text = "ITEM DESCRIPTION";
			this.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel15
			//
			this.XrLabel15.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrLabel15.CanGrow = false;
			this.XrLabel15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(575.0F, 300.0F);
			this.XrLabel15.Name = "XrLabel15";
			this.XrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel15.SizeF = new System.Drawing.SizeF(58.0F, 25.0F);
			this.XrLabel15.StylePriority.UseBorders = false;
			this.XrLabel15.StylePriority.UseFont = false;
			this.XrLabel15.StylePriority.UseTextAlignment = false;
			this.XrLabel15.Text = "PALLET";
			this.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel14
			//
			this.XrLabel14.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrLabel14.CanGrow = false;
			this.XrLabel14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(633.0F, 300.0F);
			this.XrLabel14.Name = "XrLabel14";
			this.XrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel14.SizeF = new System.Drawing.SizeF(67.0F, 25.0F);
			this.XrLabel14.StylePriority.UseBorders = false;
			this.XrLabel14.StylePriority.UseFont = false;
			this.XrLabel14.StylePriority.UseTextAlignment = false;
			this.XrLabel14.Text = "WEIGHT";
			this.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel13
			//
			this.XrLabel13.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrLabel13.CanGrow = false;
			this.XrLabel13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(62.0F, 300.0F);
			this.XrLabel13.Name = "XrLabel13";
			this.XrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel13.SizeF = new System.Drawing.SizeF(125.0F, 25.0F);
			this.XrLabel13.StylePriority.UseBorders = false;
			this.XrLabel13.StylePriority.UseFont = false;
			this.XrLabel13.StylePriority.UseTextAlignment = false;
			this.XrLabel13.Text = "ITEM #";
			this.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel12
			//
			this.XrLabel12.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrLabel12.CanGrow = false;
			this.XrLabel12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(0F, 300.0F);
			this.XrLabel12.Name = "XrLabel12";
			this.XrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel12.SizeF = new System.Drawing.SizeF(62.0F, 25.0F);
			this.XrLabel12.StylePriority.UseBorders = false;
			this.XrLabel12.StylePriority.UseFont = false;
			this.XrLabel12.StylePriority.UseTextAlignment = false;
			this.XrLabel12.Text = "QTY";
			this.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//sealXrLabel
			//
			this.sealXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right);
			this.sealXrLabel.CanGrow = false;
			this.sealXrLabel.Font = new System.Drawing.Font("Arial", 9.0F);
			this.sealXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(560.0F, 275.0F);
			this.sealXrLabel.Name = "sealXrLabel";
			this.sealXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.sealXrLabel.SizeF = new System.Drawing.SizeF(140.0F, 25.0F);
			this.sealXrLabel.StylePriority.UseBorders = false;
			this.sealXrLabel.StylePriority.UseFont = false;
			this.sealXrLabel.StylePriority.UseTextAlignment = false;
			this.sealXrLabel.Text = "XrLabel13";
			this.sealXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//trailerXrLabel
			//
			this.trailerXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top);
			this.trailerXrLabel.CanGrow = false;
			this.trailerXrLabel.Font = new System.Drawing.Font("Arial", 9.0F);
			this.trailerXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(420.0F, 275.0F);
			this.trailerXrLabel.Name = "trailerXrLabel";
			this.trailerXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.trailerXrLabel.SizeF = new System.Drawing.SizeF(140.0F, 25.0F);
			this.trailerXrLabel.StylePriority.UseBorders = false;
			this.trailerXrLabel.StylePriority.UseFont = false;
			this.trailerXrLabel.StylePriority.UseTextAlignment = false;
			this.trailerXrLabel.Text = "XrLabel13";
			this.trailerXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//carrierXrLabel
			//
			this.carrierXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top);
			this.carrierXrLabel.CanGrow = false;
			this.carrierXrLabel.Font = new System.Drawing.Font("Arial", 9.0F);
			this.carrierXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(280.0F, 275.0F);
			this.carrierXrLabel.Name = "carrierXrLabel";
			this.carrierXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.carrierXrLabel.SizeF = new System.Drawing.SizeF(140.0F, 25.0F);
			this.carrierXrLabel.StylePriority.UseBorders = false;
			this.carrierXrLabel.StylePriority.UseFont = false;
			this.carrierXrLabel.StylePriority.UseTextAlignment = false;
			this.carrierXrLabel.Text = "XrLabel12";
			this.carrierXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//deliveryNoteNumberXrLabel
			//
			this.deliveryNoteNumberXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top);
			this.deliveryNoteNumberXrLabel.CanGrow = false;
			this.deliveryNoteNumberXrLabel.Font = new System.Drawing.Font("Arial", 9.0F);
			this.deliveryNoteNumberXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(140.0F, 275.0F);
			this.deliveryNoteNumberXrLabel.Name = "deliveryNoteNumberXrLabel";
			this.deliveryNoteNumberXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.deliveryNoteNumberXrLabel.SizeF = new System.Drawing.SizeF(140.0F, 25.0F);
			this.deliveryNoteNumberXrLabel.StylePriority.UseBorders = false;
			this.deliveryNoteNumberXrLabel.StylePriority.UseFont = false;
			this.deliveryNoteNumberXrLabel.StylePriority.UseTextAlignment = false;
			this.deliveryNoteNumberXrLabel.Text = "deliveryNoteNumberXrLabel";
			this.deliveryNoteNumberXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//poXrLabel
			//
			this.poXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top);
			this.poXrLabel.CanGrow = false;
			this.poXrLabel.Font = new System.Drawing.Font("Arial", 9.0F);
			this.poXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 275.0F);
			this.poXrLabel.Name = "poXrLabel";
			this.poXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.poXrLabel.SizeF = new System.Drawing.SizeF(140.0F, 25.0F);
			this.poXrLabel.StylePriority.UseBorders = false;
			this.poXrLabel.StylePriority.UseFont = false;
			this.poXrLabel.StylePriority.UseTextAlignment = false;
			this.poXrLabel.Text = "poXrLabel";
			this.poXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel11
			//
			this.XrLabel11.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right);
			this.XrLabel11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(560.0F, 250.0F);
			this.XrLabel11.Name = "XrLabel11";
			this.XrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel11.SizeF = new System.Drawing.SizeF(140.0F, 25.0F);
			this.XrLabel11.StylePriority.UseBorders = false;
			this.XrLabel11.StylePriority.UseFont = false;
			this.XrLabel11.StylePriority.UseTextAlignment = false;
			this.XrLabel11.Text = "SEAL #";
			this.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel10
			//
			this.XrLabel10.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top);
			this.XrLabel10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(420.0F, 250.0F);
			this.XrLabel10.Name = "XrLabel10";
			this.XrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel10.SizeF = new System.Drawing.SizeF(140.0F, 25.0F);
			this.XrLabel10.StylePriority.UseBorders = false;
			this.XrLabel10.StylePriority.UseFont = false;
			this.XrLabel10.StylePriority.UseTextAlignment = false;
			this.XrLabel10.Text = "TRAILER #";
			this.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel9
			//
			this.XrLabel9.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top);
			this.XrLabel9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(280.0F, 250.0F);
			this.XrLabel9.Name = "XrLabel9";
			this.XrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel9.SizeF = new System.Drawing.SizeF(140.0F, 25.0F);
			this.XrLabel9.StylePriority.UseBorders = false;
			this.XrLabel9.StylePriority.UseFont = false;
			this.XrLabel9.StylePriority.UseTextAlignment = false;
			this.XrLabel9.Text = "CARRIER";
			this.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel8
			//
			this.XrLabel8.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top);
			this.XrLabel8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(140.0F, 250.0F);
			this.XrLabel8.Name = "XrLabel8";
			this.XrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel8.SizeF = new System.Drawing.SizeF(140.0F, 25.0F);
			this.XrLabel8.StylePriority.UseBorders = false;
			this.XrLabel8.StylePriority.UseFont = false;
			this.XrLabel8.StylePriority.UseTextAlignment = false;
			this.XrLabel8.Text = "DELIVERY NOTE #";
			this.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel6
			//
			this.XrLabel6.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top);
			this.XrLabel6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 250.0F);
			this.XrLabel6.Name = "XrLabel6";
			this.XrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel6.SizeF = new System.Drawing.SizeF(140.0F, 25.0F);
			this.XrLabel6.StylePriority.UseBorders = false;
			this.XrLabel6.StylePriority.UseFont = false;
			this.XrLabel6.StylePriority.UseTextAlignment = false;
			this.XrLabel6.Text = "PO #";
			this.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//toXrLabel
			//
			this.toXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.toXrLabel.Font = new System.Drawing.Font("Arial", 10.0F);
			this.toXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(375.0F, 125.0F);
			this.toXrLabel.Multiline = true;
			this.toXrLabel.Name = "toXrLabel";
			this.toXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.toXrLabel.SizeF = new System.Drawing.SizeF(325.0F, 100.0F);
			this.toXrLabel.StylePriority.UseBorders = false;
			this.toXrLabel.StylePriority.UseFont = false;
			this.toXrLabel.Text = "toXrLabel";
			//
			//fromXrLabel
			//
			this.fromXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.fromXrLabel.Font = new System.Drawing.Font("Arial", 10.0F);
			this.fromXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 125.0F);
			this.fromXrLabel.Multiline = true;
			this.fromXrLabel.Name = "fromXrLabel";
			this.fromXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.fromXrLabel.SizeF = new System.Drawing.SizeF(325.0F, 100.0F);
			this.fromXrLabel.StylePriority.UseBorders = false;
			this.fromXrLabel.StylePriority.UseFont = false;
			this.fromXrLabel.Text = "fromXrLabel";
			//
			//XrLabel5
			//
			this.XrLabel5.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right);
			this.XrLabel5.Font = new System.Drawing.Font("Arial", 10.0F, System.Drawing.FontStyle.Bold);
			this.XrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 100.0F);
			this.XrLabel5.Name = "XrLabel5";
			this.XrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel5.SizeF = new System.Drawing.SizeF(325.0F, 25.0F);
			this.XrLabel5.StylePriority.UseBorders = false;
			this.XrLabel5.StylePriority.UseFont = false;
			this.XrLabel5.StylePriority.UseTextAlignment = false;
			this.XrLabel5.Text = "  FROM: (Shipper)";
			this.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//XrLabel4
			//
			this.XrLabel4.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right);
			this.XrLabel4.Font = new System.Drawing.Font("Arial", 10.0F, System.Drawing.FontStyle.Bold);
			this.XrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(375.0F, 100.0F);
			this.XrLabel4.Name = "XrLabel4";
			this.XrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel4.SizeF = new System.Drawing.SizeF(325.0F, 25.0F);
			this.XrLabel4.StylePriority.UseBorders = false;
			this.XrLabel4.StylePriority.UseFont = false;
			this.XrLabel4.StylePriority.UseTextAlignment = false;
			this.XrLabel4.Text = "  TO: (Consignee)";
			this.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//bolXrLabel
			//
			this.bolXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.bolXrLabel.Font = new System.Drawing.Font("Arial", 10.0F);
			this.bolXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(600.0F, 58.0F);
			this.bolXrLabel.Name = "bolXrLabel";
			this.bolXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.bolXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 25.0F);
			this.bolXrLabel.StylePriority.UseBorders = false;
			this.bolXrLabel.StylePriority.UseFont = false;
			this.bolXrLabel.StylePriority.UseTextAlignment = false;
			this.bolXrLabel.Text = "bolXrLabel";
			this.bolXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//dateXrLabel
			//
			this.dateXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.dateXrLabel.Font = new System.Drawing.Font("Arial", 10.0F);
			this.dateXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(500.0F, 58.0F);
			this.dateXrLabel.Name = "dateXrLabel";
			this.dateXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.dateXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 25.0F);
			this.dateXrLabel.StylePriority.UseBorders = false;
			this.dateXrLabel.StylePriority.UseFont = false;
			this.dateXrLabel.StylePriority.UseTextAlignment = false;
			this.dateXrLabel.Text = "dateXrLabel";
			this.dateXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel3
			//
			this.XrLabel3.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top);
			this.XrLabel3.Font = new System.Drawing.Font("Arial", 10.0F, System.Drawing.FontStyle.Bold);
			this.XrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(500.0F, 33.0F);
			this.XrLabel3.Name = "XrLabel3";
			this.XrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel3.SizeF = new System.Drawing.SizeF(100.0F, 25.0F);
			this.XrLabel3.StylePriority.UseBorders = false;
			this.XrLabel3.StylePriority.UseFont = false;
			this.XrLabel3.StylePriority.UseTextAlignment = false;
			this.XrLabel3.Text = "DATE";
			this.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel2
			//
			this.XrLabel2.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right);
			this.XrLabel2.Font = new System.Drawing.Font("Arial", 10.0F, System.Drawing.FontStyle.Bold);
			this.XrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(600.0F, 33.0F);
			this.XrLabel2.Name = "XrLabel2";
			this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel2.SizeF = new System.Drawing.SizeF(100.0F, 25.0F);
			this.XrLabel2.StylePriority.UseBorders = false;
			this.XrLabel2.StylePriority.UseFont = false;
			this.XrLabel2.StylePriority.UseTextAlignment = false;
			this.XrLabel2.Text = "BOL #";
			this.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel1
			//
			this.XrLabel1.Font = new System.Drawing.Font("Arial", 13.0F, System.Drawing.FontStyle.Bold);
			this.XrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(258.0F, 0F);
			this.XrLabel1.Name = "XrLabel1";
			this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel1.SizeF = new System.Drawing.SizeF(442.0F, 25.0F);
			this.XrLabel1.StylePriority.UseFont = false;
			this.XrLabel1.StylePriority.UseTextAlignment = false;
			this.XrLabel1.Text = "STRAIGHT BILL OF LADING - NOT NEGOTIABLE";
			this.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//ReportFooter
			//
			this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.totalPalletWeightXrLabel, this.palletsTotalXrLabel, this.XrLabel33, this.XrLabel23, this.totalPalletsXrLabel, this.totalWeightXrLabel, this.XrLine1});
			this.ReportFooter.HeightF = 54.95834F;
			this.ReportFooter.KeepTogether = true;
			this.ReportFooter.Name = "ReportFooter";
			this.ReportFooter.PrintAtBottom = true;
			//
			//totalPalletWeightXrLabel
			//
			this.totalPalletWeightXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
			this.totalPalletWeightXrLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.totalPalletWeightXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(634.0F, 2.0F);
			this.totalPalletWeightXrLabel.Name = "totalPalletWeightXrLabel";
			this.totalPalletWeightXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.totalPalletWeightXrLabel.SizeF = new System.Drawing.SizeF(65.0F, 25.0F);
			this.totalPalletWeightXrLabel.StylePriority.UseBorders = false;
			this.totalPalletWeightXrLabel.StylePriority.UseFont = false;
			this.totalPalletWeightXrLabel.StylePriority.UseTextAlignment = false;
			this.totalPalletWeightXrLabel.Text = "Weight";
			this.totalPalletWeightXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//palletsTotalXrLabel
			//
			this.palletsTotalXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
			this.palletsTotalXrLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.palletsTotalXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(575.0F, 27.0F);
			this.palletsTotalXrLabel.Name = "palletsTotalXrLabel";
			this.palletsTotalXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.palletsTotalXrLabel.SizeF = new System.Drawing.SizeF(60.0F, 25.0F);
			this.palletsTotalXrLabel.StylePriority.UseBorders = false;
			this.palletsTotalXrLabel.StylePriority.UseFont = false;
			this.palletsTotalXrLabel.StylePriority.UseTextAlignment = false;
			this.palletsTotalXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel33
			//
			this.XrLabel33.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
			this.XrLabel33.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(0F, 2.0F);
			this.XrLabel33.Name = "XrLabel33";
			this.XrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel33.SizeF = new System.Drawing.SizeF(575.0F, 25.0F);
			this.XrLabel33.StylePriority.UseBorders = false;
			this.XrLabel33.StylePriority.UseFont = false;
			this.XrLabel33.StylePriority.UseTextAlignment = false;
			this.XrLabel33.Text = "             Total Pallets    ";
			this.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel23
			//
			this.XrLabel23.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
			this.XrLabel23.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(1.0F, 27.0F);
			this.XrLabel23.Name = "XrLabel23";
			this.XrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel23.SizeF = new System.Drawing.SizeF(575.0F, 25.0F);
			this.XrLabel23.StylePriority.UseBorders = false;
			this.XrLabel23.StylePriority.UseFont = false;
			this.XrLabel23.StylePriority.UseTextAlignment = false;
			this.XrLabel23.Text = "Total";
			this.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//totalPalletsXrLabel
			//
			this.totalPalletsXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
			this.totalPalletsXrLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.totalPalletsXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(576.0F, 2.0F);
			this.totalPalletsXrLabel.Name = "totalPalletsXrLabel";
			this.totalPalletsXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.totalPalletsXrLabel.SizeF = new System.Drawing.SizeF(60.0F, 25.0F);
			this.totalPalletsXrLabel.StylePriority.UseBorders = false;
			this.totalPalletsXrLabel.StylePriority.UseFont = false;
			this.totalPalletsXrLabel.StylePriority.UseTextAlignment = false;
			this.totalPalletsXrLabel.Text = "Pallets";
			this.totalPalletsXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//totalWeightXrLabel
			//
			this.totalWeightXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
			this.totalWeightXrLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.totalWeightXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(634.0F, 27.0F);
			this.totalWeightXrLabel.Name = "totalWeightXrLabel";
			this.totalWeightXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.totalWeightXrLabel.SizeF = new System.Drawing.SizeF(65.0F, 25.0F);
			this.totalWeightXrLabel.StylePriority.UseBorders = false;
			this.totalWeightXrLabel.StylePriority.UseFont = false;
			this.totalWeightXrLabel.StylePriority.UseTextAlignment = false;
			this.totalWeightXrLabel.Text = "Weight";
			this.totalWeightXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLine1
			//
			this.XrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.XrLine1.Name = "XrLine1";
			this.XrLine1.SizeF = new System.Drawing.SizeF(700.0F, 2.0F);
			//
			//returnsGroupHeader
			//
			this.returnsGroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel21, this.XrLabel20, this.XrLabel19, this.XrLabel18, this.XrLabel17});
			this.returnsGroupHeader.HeightF = 25.0F;
			this.returnsGroupHeader.KeepTogether = true;
			this.returnsGroupHeader.Level = 1;
			this.returnsGroupHeader.Name = "returnsGroupHeader";
			//
			//XrLabel21
			//
			this.XrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.XrLabel21.Font = new System.Drawing.Font("Arial", 9.75F, (System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(185.0F, 0F);
			this.XrLabel21.Name = "XrLabel21";
			this.XrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel21.SizeF = new System.Drawing.SizeF(389.0F, 25.0F);
			this.XrLabel21.StylePriority.UseBorders = false;
			this.XrLabel21.StylePriority.UseFont = false;
			this.XrLabel21.StylePriority.UseTextAlignment = false;
			this.XrLabel21.Text = "Returns";
			this.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel20
			//
			this.XrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.XrLabel20.Font = new System.Drawing.Font("Times New Roman", 12.0F);
			this.XrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(575.0F, 0F);
			this.XrLabel20.Name = "XrLabel20";
			this.XrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel20.SizeF = new System.Drawing.SizeF(60.0F, 25.0F);
			this.XrLabel20.StylePriority.UseBorders = false;
			this.XrLabel20.StylePriority.UseFont = false;
			this.XrLabel20.StylePriority.UseTextAlignment = false;
			this.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel19
			//
			this.XrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.XrLabel19.Font = new System.Drawing.Font("Times New Roman", 12.0F);
			this.XrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(635.0F, 0F);
			this.XrLabel19.Name = "XrLabel19";
			this.XrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel19.SizeF = new System.Drawing.SizeF(65.0F, 25.0F);
			this.XrLabel19.StylePriority.UseBorders = false;
			this.XrLabel19.StylePriority.UseFont = false;
			this.XrLabel19.StylePriority.UseTextAlignment = false;
			this.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel18
			//
			this.XrLabel18.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.XrLabel18.Font = new System.Drawing.Font("Times New Roman", 12.0F);
			this.XrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(60.0F, 0F);
			this.XrLabel18.Name = "XrLabel18";
			this.XrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel18.SizeF = new System.Drawing.SizeF(125.0F, 25.0F);
			this.XrLabel18.StylePriority.UseBorders = false;
			this.XrLabel18.StylePriority.UseFont = false;
			this.XrLabel18.StylePriority.UseTextAlignment = false;
			this.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel17
			//
			this.XrLabel17.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.XrLabel17.Font = new System.Drawing.Font("Times New Roman", 12.0F);
			this.XrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.XrLabel17.Name = "XrLabel17";
			this.XrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel17.SizeF = new System.Drawing.SizeF(60.0F, 25.0F);
			this.XrLabel17.StylePriority.UseBorders = false;
			this.XrLabel17.StylePriority.UseFont = false;
			this.XrLabel17.StylePriority.UseTextAlignment = false;
			this.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//PageFooter
			//
			this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.billTo, this.XrRichText1, this.XrPanel3, this.XrPanel2, this.XrPanel1, this.notesXrLabel, this.XrLabel7});
			this.PageFooter.HeightF = 248.0F;
			this.PageFooter.Name = "PageFooter";
			//
			//billTo
			//
			this.billTo.Font = new System.Drawing.Font("Arial", 9.75F);
			this.billTo.LocationFloat = new DevExpress.Utils.PointFloat(61.99999F, 192.0F);
			this.billTo.Multiline = true;
			this.billTo.Name = "billTo";
			this.billTo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.billTo.SizeF = new System.Drawing.SizeF(238.0F, 50.00002F);
			this.billTo.StylePriority.UseFont = false;
			//
			//XrRichText1
			//
			this.XrRichText1.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrRichText1.Font = new System.Drawing.Font("Arial", 6.5F);
			this.XrRichText1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 83.0F);
			this.XrRichText1.Name = "XrRichText1";
			this.XrRichText1.SerializableRtfString = resources.GetString("XrRichText1.SerializableRtfString");
			this.XrRichText1.SizeF = new System.Drawing.SizeF(700.0F, 100.0F);
			this.XrRichText1.StylePriority.UseBorders = false;
			this.XrRichText1.StylePriority.UseFont = false;
			//
			//XrPanel3
			//
			this.XrPanel3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel30, this.XrLabel29, this.XrLabel28});
			this.XrPanel3.LocationFloat = new DevExpress.Utils.PointFloat(400.0F, 192.0F);
			this.XrPanel3.Name = "XrPanel3";
			this.XrPanel3.SizeF = new System.Drawing.SizeF(300.0F, 51.0F);
			//
			//XrLabel30
			//
			this.XrLabel30.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
			this.XrLabel30.Font = new System.Drawing.Font("Arial", 9.75F);
			this.XrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(0F, 34.0F);
			this.XrLabel30.Name = "XrLabel30";
			this.XrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel30.SizeF = new System.Drawing.SizeF(300.0F, 17.0F);
			this.XrLabel30.StylePriority.UseBorders = false;
			this.XrLabel30.StylePriority.UseFont = false;
			this.XrLabel30.StylePriority.UseTextAlignment = false;
			this.XrLabel30.Text = "Date";
			this.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//XrLabel29
			//
			this.XrLabel29.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
			this.XrLabel29.Font = new System.Drawing.Font("Arial", 9.75F);
			this.XrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(0F, 17.0F);
			this.XrLabel29.Name = "XrLabel29";
			this.XrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel29.SizeF = new System.Drawing.SizeF(300.0F, 17.0F);
			this.XrLabel29.StylePriority.UseBorders = false;
			this.XrLabel29.StylePriority.UseFont = false;
			this.XrLabel29.StylePriority.UseTextAlignment = false;
			this.XrLabel29.Text = "Per";
			this.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//XrLabel28
			//
			this.XrLabel28.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
			this.XrLabel28.Font = new System.Drawing.Font("Arial", 9.75F);
			this.XrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.XrLabel28.Name = "XrLabel28";
			this.XrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel28.SizeF = new System.Drawing.SizeF(300.0F, 17.0F);
			this.XrLabel28.StylePriority.UseBorders = false;
			this.XrLabel28.StylePriority.UseFont = false;
			this.XrLabel28.StylePriority.UseTextAlignment = false;
			this.XrLabel28.Text = "Carrier";
			this.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//XrPanel2
			//
			this.XrPanel2.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrPanel2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.freightXrCheckBox, this.XrLabel27, this.XrLabel26, this.XrLabel25});
			this.XrPanel2.LocationFloat = new DevExpress.Utils.PointFloat(500.0F, 0F);
			this.XrPanel2.Name = "XrPanel2";
			this.XrPanel2.SizeF = new System.Drawing.SizeF(200.0F, 75.0F);
			this.XrPanel2.StylePriority.UseBorders = false;
			//
			//freightXrCheckBox
			//
			this.freightXrCheckBox.Font = new System.Drawing.Font("Arial", 8.0F);
			this.freightXrCheckBox.LocationFloat = new DevExpress.Utils.PointFloat(108.0F, 17.0F);
			this.freightXrCheckBox.Name = "freightXrCheckBox";
			this.freightXrCheckBox.SizeF = new System.Drawing.SizeF(92.0F, 58.0F);
			this.freightXrCheckBox.StylePriority.UseFont = false;
			this.freightXrCheckBox.Text = "Check box if charges are to be collected";
			//
			//XrLabel27
			//
			this.XrLabel27.Font = new System.Drawing.Font("Arial", 8.0F);
			this.XrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(0F, 42.0F);
			this.XrLabel27.Multiline = true;
			this.XrLabel27.Name = "XrLabel27";
			this.XrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel27.SizeF = new System.Drawing.SizeF(100.0F, 33.0F);
			this.XrLabel27.StylePriority.UseFont = false;
			this.XrLabel27.Text = "Except when box at right is checked";
			//
			//XrLabel26
			//
			this.XrLabel26.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right);
			this.XrLabel26.Font = new System.Drawing.Font("Arial", 8.0F);
			this.XrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(0F, 17.0F);
			this.XrLabel26.Name = "XrLabel26";
			this.XrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel26.SizeF = new System.Drawing.SizeF(100.0F, 25.0F);
			this.XrLabel26.StylePriority.UseBorders = false;
			this.XrLabel26.StylePriority.UseFont = false;
			this.XrLabel26.StylePriority.UseTextAlignment = false;
			this.XrLabel26.Text = "Freight Prepaid";
			this.XrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel25
			//
			this.XrLabel25.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.XrLabel25.Font = new System.Drawing.Font("Arial", 9.75F);
			this.XrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.XrLabel25.Name = "XrLabel25";
			this.XrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel25.SizeF = new System.Drawing.SizeF(200.0F, 17.0F);
			this.XrLabel25.StylePriority.UseBorders = false;
			this.XrLabel25.StylePriority.UseFont = false;
			this.XrLabel25.StylePriority.UseTextAlignment = false;
			this.XrLabel25.Text = "Freight Charges";
			this.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrPanel1
			//
			this.XrPanel1.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLine2, this.XrLabel24, this.XrLabel22});
			this.XrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(300.0F, 0F);
			this.XrPanel1.Name = "XrPanel1";
			this.XrPanel1.SizeF = new System.Drawing.SizeF(200.0F, 76.0F);
			this.XrPanel1.StylePriority.UseBorders = false;
			//
			//XrLine2
			//
			this.XrLine2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 73.0F);
			this.XrLine2.Name = "XrLine2";
			this.XrLine2.SizeF = new System.Drawing.SizeF(133.0F, 2.0F);
			//
			//XrLabel24
			//
			this.XrLabel24.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.XrLabel24.Font = new System.Drawing.Font("Arial", 9.75F);
			this.XrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(133.0F, 58.0F);
			this.XrLabel24.Name = "XrLabel24";
			this.XrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel24.SizeF = new System.Drawing.SizeF(67.0F, 18.0F);
			this.XrLabel24.StylePriority.UseBorders = false;
			this.XrLabel24.StylePriority.UseFont = false;
			this.XrLabel24.StylePriority.UseTextAlignment = false;
			this.XrLabel24.Text = "Signature";
			this.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomRight;
			//
			//XrLabel22
			//
			this.XrLabel22.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.XrLabel22.Font = new System.Drawing.Font("Arial", 6.5F);
			this.XrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.XrLabel22.Name = "XrLabel22";
			this.XrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel22.SizeF = new System.Drawing.SizeF(199.0F, 57.0F);
			this.XrLabel22.StylePriority.UseBorders = false;
			this.XrLabel22.StylePriority.UseFont = false;
			this.XrLabel22.Text = resources.GetString("XrLabel22.Text");
			//
			//notesXrLabel
			//
			this.notesXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.notesXrLabel.Font = new System.Drawing.Font("Times New Roman", 11.0F);
			this.notesXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.notesXrLabel.Multiline = true;
			this.notesXrLabel.Name = "notesXrLabel";
			this.notesXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.notesXrLabel.SizeF = new System.Drawing.SizeF(300.0F, 75.0F);
			this.notesXrLabel.StylePriority.UseBorders = false;
			this.notesXrLabel.StylePriority.UseFont = false;
			this.notesXrLabel.Text = "notesXrLabel";
			//
			//XrLabel7
			//
			this.XrLabel7.Font = new System.Drawing.Font("Arial", 9.75F);
			this.XrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 192.0F);
			this.XrLabel7.Multiline = true;
			this.XrLabel7.Name = "XrLabel7";
			this.XrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel7.SizeF = new System.Drawing.SizeF(61.99999F, 50.00002F);
			this.XrLabel7.StylePriority.UseFont = false;
			this.XrLabel7.Text = "Bill To:";
			//
			//XrCrossBandLine1XRCrossBandLine
			//
			this.XrCrossBandLine1XRCrossBandLine.EndBand = this.ReportFooter;
			this.XrCrossBandLine1XRCrossBandLine.EndPointFloat = new DevExpress.Utils.PointFloat(575.0F, 25.95833F);
			this.XrCrossBandLine1XRCrossBandLine.LocationFloat = new DevExpress.Utils.PointFloat(575.0F, 0F);
			this.XrCrossBandLine1XRCrossBandLine.Name = "XrCrossBandLine1XRCrossBandLine";
			this.XrCrossBandLine1XRCrossBandLine.StartBand = this.returnsGroupHeader;
			this.XrCrossBandLine1XRCrossBandLine.StartPointFloat = new DevExpress.Utils.PointFloat(575.0F, 0F);
			this.XrCrossBandLine1XRCrossBandLine.WidthF = 1.041687F;
			//
			//XrCrossBandLine1XRCrossBandLine2
			//
			this.XrCrossBandLine1XRCrossBandLine2.EndBand = this.ReportFooter;
			this.XrCrossBandLine1XRCrossBandLine2.EndPointFloat = new DevExpress.Utils.PointFloat(698.9999F, 25.95833F);
			this.XrCrossBandLine1XRCrossBandLine2.LocationFloat = new DevExpress.Utils.PointFloat(698.9999F, 0F);
			this.XrCrossBandLine1XRCrossBandLine2.Name = "XrCrossBandLine1XRCrossBandLine2";
			this.XrCrossBandLine1XRCrossBandLine2.StartBand = this.returnsGroupHeader;
			this.XrCrossBandLine1XRCrossBandLine2.StartPointFloat = new DevExpress.Utils.PointFloat(698.9999F, 0F);
			this.XrCrossBandLine1XRCrossBandLine2.WidthF = 1.041626F;
			//
			//XrCrossBandLine1XRCrossBandLine3
			//
			this.XrCrossBandLine1XRCrossBandLine3.EndBand = this.ReportFooter;
			this.XrCrossBandLine1XRCrossBandLine3.EndPointFloat = new DevExpress.Utils.PointFloat(188.0F, 25.95833F);
			this.XrCrossBandLine1XRCrossBandLine3.LocationFloat = new DevExpress.Utils.PointFloat(188.0F, 0F);
			this.XrCrossBandLine1XRCrossBandLine3.Name = "XrCrossBandLine1XRCrossBandLine3";
			this.XrCrossBandLine1XRCrossBandLine3.StartBand = this.returnsGroupHeader;
			this.XrCrossBandLine1XRCrossBandLine3.StartPointFloat = new DevExpress.Utils.PointFloat(188.0F, 0F);
			this.XrCrossBandLine1XRCrossBandLine3.WidthF = 1.041656F;
			//
			//XrCrossBandLine1XRCrossBandLine4
			//
			this.XrCrossBandLine1XRCrossBandLine4.EndBand = this.ReportFooter;
			this.XrCrossBandLine1XRCrossBandLine4.EndPointFloat = new DevExpress.Utils.PointFloat(61.99999F, 25.95833F);
			this.XrCrossBandLine1XRCrossBandLine4.LocationFloat = new DevExpress.Utils.PointFloat(61.99999F, 0F);
			this.XrCrossBandLine1XRCrossBandLine4.Name = "XrCrossBandLine1XRCrossBandLine4";
			this.XrCrossBandLine1XRCrossBandLine4.StartBand = this.returnsGroupHeader;
			this.XrCrossBandLine1XRCrossBandLine4.StartPointFloat = new DevExpress.Utils.PointFloat(61.99999F, 0F);
			this.XrCrossBandLine1XRCrossBandLine4.WidthF = 1.041668F;
			//
			//XrCrossBandLine1XRCrossBandLine5
			//
			this.XrCrossBandLine1XRCrossBandLine5.EndBand = this.ReportFooter;
			this.XrCrossBandLine1XRCrossBandLine5.EndPointFloat = new DevExpress.Utils.PointFloat(0F, 25.95833F);
			this.XrCrossBandLine1XRCrossBandLine5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.XrCrossBandLine1XRCrossBandLine5.Name = "XrCrossBandLine1XRCrossBandLine5";
			this.XrCrossBandLine1XRCrossBandLine5.StartBand = this.returnsGroupHeader;
			this.XrCrossBandLine1XRCrossBandLine5.StartPointFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.XrCrossBandLine1XRCrossBandLine5.WidthF = 1.041667F;
			//
			//XrCrossBandLine1
			//
			this.XrCrossBandLine1.EndBand = this.ReportFooter;
			this.XrCrossBandLine1.EndPointFloat = new DevExpress.Utils.PointFloat(633.0001F, 25.95833F);
			this.XrCrossBandLine1.LocationFloat = new DevExpress.Utils.PointFloat(633.0001F, 0F);
			this.XrCrossBandLine1.Name = "XrCrossBandLine1";
			this.XrCrossBandLine1.StartBand = this.returnsGroupHeader;
			this.XrCrossBandLine1.StartPointFloat = new DevExpress.Utils.PointFloat(633.0001F, 0F);
			this.XrCrossBandLine1.WidthF = 1.041687F;
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
			//itemsGroupFooter
			//
			this.itemsGroupFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.itemTotalWeightXrLabel, this.itemTotalPalletsXrLabel, this.groupItemDescriptionXrLabel, this.groupItemCodeXrLabel, this.itemTotalQuantityXrLabel});
			this.itemsGroupFooter.HeightF = 25.0F;
			this.itemsGroupFooter.Name = "itemsGroupFooter";
			//
			//itemTotalWeightXrLabel
			//
			this.itemTotalWeightXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.itemTotalWeightXrLabel.Font = new System.Drawing.Font("Arial", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.itemTotalWeightXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(635.0F, 0F);
			this.itemTotalWeightXrLabel.Name = "itemTotalWeightXrLabel";
			this.itemTotalWeightXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemTotalWeightXrLabel.SizeF = new System.Drawing.SizeF(65.0F, 25.0F);
			this.itemTotalWeightXrLabel.StylePriority.UseBorders = false;
			this.itemTotalWeightXrLabel.StylePriority.UseFont = false;
			this.itemTotalWeightXrLabel.StylePriority.UseTextAlignment = false;
			XrSummary1.IgnoreNullValues = true;
			XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
			this.itemTotalWeightXrLabel.Summary = XrSummary1;
			this.itemTotalWeightXrLabel.Text = "Weight";
			this.itemTotalWeightXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemTotalPalletsXrLabel
			//
			this.itemTotalPalletsXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.itemTotalPalletsXrLabel.Font = new System.Drawing.Font("Arial", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.itemTotalPalletsXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(575.0F, 0F);
			this.itemTotalPalletsXrLabel.Name = "itemTotalPalletsXrLabel";
			this.itemTotalPalletsXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemTotalPalletsXrLabel.SizeF = new System.Drawing.SizeF(60.0F, 25.0F);
			this.itemTotalPalletsXrLabel.StylePriority.UseBorders = false;
			this.itemTotalPalletsXrLabel.StylePriority.UseFont = false;
			this.itemTotalPalletsXrLabel.StylePriority.UseTextAlignment = false;
			XrSummary2.FormatString = "{0:#.##}";
			XrSummary2.IgnoreNullValues = true;
			XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
			this.itemTotalPalletsXrLabel.Summary = XrSummary2;
			this.itemTotalPalletsXrLabel.Text = "Pallets";
			this.itemTotalPalletsXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//groupItemDescriptionXrLabel
			//
			this.groupItemDescriptionXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.groupItemDescriptionXrLabel.Font = new System.Drawing.Font("Arial", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.groupItemDescriptionXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(185.0F, 0F);
			this.groupItemDescriptionXrLabel.Multiline = true;
			this.groupItemDescriptionXrLabel.Name = "groupItemDescriptionXrLabel";
			this.groupItemDescriptionXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.groupItemDescriptionXrLabel.SizeF = new System.Drawing.SizeF(390.0F, 25.0F);
			this.groupItemDescriptionXrLabel.StylePriority.UseBorders = false;
			this.groupItemDescriptionXrLabel.StylePriority.UseFont = false;
			this.groupItemDescriptionXrLabel.StylePriority.UseTextAlignment = false;
			this.groupItemDescriptionXrLabel.Text = "Item Description";
			this.groupItemDescriptionXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//groupItemCodeXrLabel
			//
			this.groupItemCodeXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.groupItemCodeXrLabel.Font = new System.Drawing.Font("Arial", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.groupItemCodeXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(60.0F, 0F);
			this.groupItemCodeXrLabel.Name = "groupItemCodeXrLabel";
			this.groupItemCodeXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.groupItemCodeXrLabel.SizeF = new System.Drawing.SizeF(125.0F, 25.0F);
			this.groupItemCodeXrLabel.StylePriority.UseBorders = false;
			this.groupItemCodeXrLabel.StylePriority.UseFont = false;
			this.groupItemCodeXrLabel.StylePriority.UseTextAlignment = false;
			this.groupItemCodeXrLabel.Text = "Item #";
			this.groupItemCodeXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemTotalQuantityXrLabel
			//
			this.itemTotalQuantityXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.itemTotalQuantityXrLabel.Font = new System.Drawing.Font("Arial", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.itemTotalQuantityXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.itemTotalQuantityXrLabel.Name = "itemTotalQuantityXrLabel";
			this.itemTotalQuantityXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemTotalQuantityXrLabel.SizeF = new System.Drawing.SizeF(60.0F, 25.0F);
			this.itemTotalQuantityXrLabel.StylePriority.UseBorders = false;
			this.itemTotalQuantityXrLabel.StylePriority.UseFont = false;
			this.itemTotalQuantityXrLabel.StylePriority.UseTextAlignment = false;
			XrSummary3.IgnoreNullValues = true;
			XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
			this.itemTotalQuantityXrLabel.Summary = XrSummary3;
			this.itemTotalQuantityXrLabel.Text = "Qty";
			this.itemTotalQuantityXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemGroupHeader
			//
			this.itemGroupHeader.HeightF = 0F;
			this.itemGroupHeader.Name = "itemGroupHeader";
			//
			//returnsGroupFooter
			//
			this.returnsGroupFooter.HeightF = 0F;
			this.returnsGroupFooter.Level = 1;
			this.returnsGroupFooter.Name = "returnsGroupFooter";
			//
			//locationId
			//
			this.locationId.LocationFloat = new DevExpress.Utils.PointFloat(188.0F, 102.0F);
			this.locationId.Name = "locationId";
			this.locationId.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.locationId.SizeF = new System.Drawing.SizeF(100.0F, 23.0F);
			this.locationId.Visible = false;
			//
			//BillOfLadingXtraReport
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.ReportHeader, this.ReportFooter, this.returnsGroupHeader, this.PageFooter, this.TopMarginBand1, this.BottomMarginBand1, this.itemsGroupFooter, this.itemGroupHeader, this.returnsGroupFooter});
			this.CrossBandControls.AddRange(new DevExpress.XtraReports.UI.XRCrossBandControl[] {this.XrCrossBandLine1XRCrossBandLine3, this.XrCrossBandLine1XRCrossBandLine4, this.XrCrossBandLine1XRCrossBandLine, this.XrCrossBandLine1XRCrossBandLine2, this.XrCrossBandLine1XRCrossBandLine5, this.XrCrossBandLine1});
			this.Margins = new System.Drawing.Printing.Margins(65, 75, 50, 50);
			this.Version = "17.1";
			((System.ComponentModel.ISupportInitialize)this.XrRichText1).EndInit();
			((System.ComponentModel.ISupportInitialize)this).EndInit();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			fromXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(fromXrLabel_BeforePrint);
			toXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(toXrLabel_BeforePrint);
			returnsGroupHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(returnsGroupHeader_BeforePrint);
			totalPalletWeightXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(totalPalletWeightXrLabel_BeforePrint);
			itemDescriptionXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(itemDescriptionXrLabel_BeforePrint);
		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		internal DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
		internal DevExpress.XtraReports.UI.GroupHeaderBand returnsGroupHeader;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
		internal DevExpress.XtraReports.UI.XRLabel bolXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel dateXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel3;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
		internal DevExpress.XtraReports.UI.XRLabel fromXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel5;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel4;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel10;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel9;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel8;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel6;
		internal DevExpress.XtraReports.UI.XRLabel toXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel sealXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel trailerXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel carrierXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel deliveryNoteNumberXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel poXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel11;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel15;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel14;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel13;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel12;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel16;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel21;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel20;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel19;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel18;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel17;
		internal DevExpress.XtraReports.UI.XRLabel itemDescriptionXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel palletsXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel weightXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemCodeXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel qtyXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel23;
		internal DevExpress.XtraReports.UI.XRLabel totalPalletsXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel totalWeightXrLabel;
		internal DevExpress.XtraReports.UI.XRLine XrLine1;
		internal DevExpress.XtraReports.UI.PageFooterBand PageFooter;
		internal DevExpress.XtraReports.UI.XRRichText XrRichText1;
		internal DevExpress.XtraReports.UI.XRPanel XrPanel3;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel30;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel29;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel28;
		internal DevExpress.XtraReports.UI.XRPanel XrPanel2;
		internal DevExpress.XtraReports.UI.XRCheckBox freightXrCheckBox;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel27;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel26;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel25;
		internal DevExpress.XtraReports.UI.XRPanel XrPanel1;
		internal DevExpress.XtraReports.UI.XRLine XrLine2;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel24;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel22;
		internal DevExpress.XtraReports.UI.XRLabel notesXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel7;
		internal DevExpress.XtraReports.UI.XRCrossBandLine XrCrossBandLine1XRCrossBandLine;
		internal DevExpress.XtraReports.UI.XRCrossBandLine XrCrossBandLine1XRCrossBandLine2;
		internal DevExpress.XtraReports.UI.XRCrossBandLine XrCrossBandLine1XRCrossBandLine3;
		internal DevExpress.XtraReports.UI.XRCrossBandLine XrCrossBandLine1XRCrossBandLine4;
		internal DevExpress.XtraReports.UI.XRCrossBandLine XrCrossBandLine1XRCrossBandLine5;
		internal DevExpress.XtraReports.UI.XRCrossBandLine XrCrossBandLine1;
		internal DevExpress.XtraReports.UI.XRLabel palletsTotalXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel33;
		internal DevExpress.XtraReports.UI.XRLabel totalPalletWeightXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel34;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMarginBand1;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMarginBand1;
		internal DevExpress.XtraReports.UI.XRPictureBox spgLogoXrPictureBox;
		internal DevExpress.XtraReports.UI.GroupFooterBand itemsGroupFooter;
		internal DevExpress.XtraReports.UI.XRLabel itemTotalWeightXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemTotalPalletsXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel groupItemDescriptionXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel groupItemCodeXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemTotalQuantityXrLabel;
		internal DevExpress.XtraReports.UI.GroupHeaderBand itemGroupHeader;
		internal DevExpress.XtraReports.UI.GroupFooterBand returnsGroupFooter;
		internal DevExpress.XtraReports.UI.XRLabel billTo;
		internal DevExpress.XtraReports.UI.XRLabel locationId;
	}

}