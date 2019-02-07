using System.Text;
using DXDAL;

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
	public partial class PackingListXtraReport : DevExpress.XtraReports.UI.XtraReport
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackingListXtraReport));
			DevExpress.XtraReports.UI.XRSummary XrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.lpnXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.lotXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.expirationDateXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemDescriptionXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.palletsXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.weightXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemCodeXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.qtyXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.XrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.correctPalletsXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.insectActivityXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			this.foreignSubstanceXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.wheelsChockedXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.temperatureXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.finishTimeXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
			this.loadedByLabelXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
			this.loadedByXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.checkedByXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.physicalConditionXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.loadConditionXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.startTimeXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.lpnLabelXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
			this.spgLogoXrPictureBox = new DevExpress.XtraReports.UI.XRPictureBox();
			this.XrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
			this.qtyLabelXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.sealXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.trailerXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.carrierXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.deliveryNoteNumberXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.poXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.deliveryNoteLabelXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.toXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.fromXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.bolXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.dateXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.reportTitleXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.locationId = new DevExpress.XtraReports.UI.XRLabel();
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
			this.XrCrossBandLine1XRCrossBandLine2 = new DevExpress.XtraReports.UI.XRCrossBandLine();
			this.XrCrossBandLine1XRCrossBandLine5 = new DevExpress.XtraReports.UI.XRCrossBandLine();
			this.TopMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.XrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.itemsGroupFooter = new DevExpress.XtraReports.UI.GroupFooterBand();
			this.itemTotalWeightXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemTotalPalletsXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.groupItemDescriptionXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.groupItemCodeXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemTotalQuantityXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.groupItemLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemGroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
			this.packingListpageinfo = new DevExpress.XtraReports.UI.XRPageInfo();
			this.lotGroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
			((System.ComponentModel.ISupportInitialize)this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.lpnXrLabel, this.lotXrLabel, this.expirationDateXrLabel, this.itemDescriptionXrLabel, this.palletsXrLabel, this.weightXrLabel, this.itemCodeXrLabel, this.qtyXrLabel});
			this.Detail.HeightF = 25.0F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//lpnXrLabel
			//
			this.lpnXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.lpnXrLabel.Font = new System.Drawing.Font("Arial", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.lpnXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(377.1667F, 0F);
			this.lpnXrLabel.Multiline = true;
			this.lpnXrLabel.Name = "lpnXrLabel";
			this.lpnXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.lpnXrLabel.SizeF = new System.Drawing.SizeF(107.8334F, 25.0F);
			this.lpnXrLabel.StylePriority.UseBorders = false;
			this.lpnXrLabel.StylePriority.UseFont = false;
			this.lpnXrLabel.StylePriority.UseTextAlignment = false;
			this.lpnXrLabel.Text = "LPN";
			this.lpnXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//lotXrLabel
			//
			this.lotXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.lotXrLabel.Font = new System.Drawing.Font("Arial", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.lotXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(485.0F, 0F);
			this.lotXrLabel.Multiline = true;
			this.lotXrLabel.Name = "lotXrLabel";
			this.lotXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.lotXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 25.0F);
			this.lotXrLabel.StylePriority.UseBorders = false;
			this.lotXrLabel.StylePriority.UseFont = false;
			this.lotXrLabel.StylePriority.UseTextAlignment = false;
			this.lotXrLabel.Text = "Lot";
			this.lotXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//expirationDateXrLabel
			//
			this.expirationDateXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.expirationDateXrLabel.Font = new System.Drawing.Font("Arial", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.expirationDateXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(585.0F, 0F);
			this.expirationDateXrLabel.Multiline = true;
			this.expirationDateXrLabel.Name = "expirationDateXrLabel";
			this.expirationDateXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.expirationDateXrLabel.SizeF = new System.Drawing.SizeF(74.0F, 25.0F);
			this.expirationDateXrLabel.StylePriority.UseBorders = false;
			this.expirationDateXrLabel.StylePriority.UseFont = false;
			this.expirationDateXrLabel.StylePriority.UseTextAlignment = false;
			this.expirationDateXrLabel.Text = "Exp. Date";
			this.expirationDateXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemDescriptionXrLabel
			//
			this.itemDescriptionXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.itemDescriptionXrLabel.Font = new System.Drawing.Font("Arial", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.itemDescriptionXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(148.0F, 0F);
			this.itemDescriptionXrLabel.Multiline = true;
			this.itemDescriptionXrLabel.Name = "itemDescriptionXrLabel";
			this.itemDescriptionXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemDescriptionXrLabel.SizeF = new System.Drawing.SizeF(229.1667F, 25.0F);
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
			this.palletsXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(659.0F, 0F);
			this.palletsXrLabel.Name = "palletsXrLabel";
			this.palletsXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.palletsXrLabel.SizeF = new System.Drawing.SizeF(58.0F, 25.0F);
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
			this.weightXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(717.0F, 0F);
			this.weightXrLabel.Name = "weightXrLabel";
			this.weightXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.weightXrLabel.SizeF = new System.Drawing.SizeF(61.0F, 25.0F);
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
			this.itemCodeXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(48.0F, 0F);
			this.itemCodeXrLabel.Name = "itemCodeXrLabel";
			this.itemCodeXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemCodeXrLabel.SizeF = new System.Drawing.SizeF(100.0F, 25.0F);
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
			this.qtyXrLabel.SizeF = new System.Drawing.SizeF(48.0F, 25.0F);
			this.qtyXrLabel.StylePriority.UseBorders = false;
			this.qtyXrLabel.StylePriority.UseFont = false;
			this.qtyXrLabel.StylePriority.UseTextAlignment = false;
			this.qtyXrLabel.Text = "Qty";
			this.qtyXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//ReportHeader
			//
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel8, this.correctPalletsXrLabel, this.insectActivityXrLabel, this.XrLabel17, this.XrLabel7, this.foreignSubstanceXrLabel, this.wheelsChockedXrLabel, this.XrLabel1, this.temperatureXrLabel, this.finishTimeXrLabel, this.XrLabel28, this.XrLabel29, this.loadedByLabelXrLabel, this.XrLabel20, this.XrLabel22, this.XrLabel24, this.XrLabel25, this.loadedByXrLabel, this.checkedByXrLabel, this.physicalConditionXrLabel, this.loadConditionXrLabel, this.startTimeXrLabel, this.lpnLabelXrLabel, this.XrLabel19, this.XrLabel18, this.spgLogoXrPictureBox, this.XrLabel34, this.XrLabel16, this.XrLabel15, this.XrLabel14, this.XrLabel13, this.qtyLabelXrLabel, this.sealXrLabel, this.trailerXrLabel, this.carrierXrLabel, this.deliveryNoteNumberXrLabel, this.poXrLabel, this.XrLabel11, this.XrLabel10, this.XrLabel9, this.deliveryNoteLabelXrLabel, this.XrLabel6, this.toXrLabel, this.fromXrLabel, this.XrLabel5, this.XrLabel4, this.bolXrLabel, this.dateXrLabel, this.XrLabel3, this.XrLabel2, this.reportTitleXrLabel, this.locationId});
			this.ReportHeader.HeightF = 400.0F;
			this.ReportHeader.KeepTogether = true;
			this.ReportHeader.Name = "ReportHeader";
			//
			//XrLabel8
			//
			this.XrLabel8.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top);
			this.XrLabel8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(574.5F, 350.0F);
			this.XrLabel8.Name = "XrLabel8";
			this.XrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel8.SizeF = new System.Drawing.SizeF(142.5F, 25.0F);
			this.XrLabel8.StylePriority.UseBorders = false;
			this.XrLabel8.StylePriority.UseFont = false;
			this.XrLabel8.StylePriority.UseTextAlignment = false;
			this.XrLabel8.Text = "Correct Pallets";
			this.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//correctPalletsXrLabel
			//
			this.correctPalletsXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right);
			this.correctPalletsXrLabel.CanGrow = false;
			this.correctPalletsXrLabel.Font = new System.Drawing.Font("Arial", 9.0F);
			this.correctPalletsXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(717.0F, 350.0F);
			this.correctPalletsXrLabel.Name = "correctPalletsXrLabel";
			this.correctPalletsXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.correctPalletsXrLabel.SizeF = new System.Drawing.SizeF(60.125F, 25.0F);
			this.correctPalletsXrLabel.StylePriority.UseBorders = false;
			this.correctPalletsXrLabel.StylePriority.UseFont = false;
			this.correctPalletsXrLabel.StylePriority.UseTextAlignment = false;
			this.correctPalletsXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//insectActivityXrLabel
			//
			this.insectActivityXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right);
			this.insectActivityXrLabel.CanGrow = false;
			this.insectActivityXrLabel.Font = new System.Drawing.Font("Arial", 9.0F);
			this.insectActivityXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(514.5F, 350.0F);
			this.insectActivityXrLabel.Name = "insectActivityXrLabel";
			this.insectActivityXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.insectActivityXrLabel.SizeF = new System.Drawing.SizeF(60.0F, 25.0F);
			this.insectActivityXrLabel.StylePriority.UseBorders = false;
			this.insectActivityXrLabel.StylePriority.UseFont = false;
			this.insectActivityXrLabel.StylePriority.UseTextAlignment = false;
			this.insectActivityXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel17
			//
			this.XrLabel17.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top);
			this.XrLabel17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(366.0001F, 350.0F);
			this.XrLabel17.Name = "XrLabel17";
			this.XrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel17.SizeF = new System.Drawing.SizeF(148.5F, 25.0F);
			this.XrLabel17.StylePriority.UseBorders = false;
			this.XrLabel17.StylePriority.UseFont = false;
			this.XrLabel17.StylePriority.UseTextAlignment = false;
			this.XrLabel17.Text = "Insect/Rodent Activity";
			this.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//XrLabel7
			//
			this.XrLabel7.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top);
			this.XrLabel7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(177.5F, 350.0F);
			this.XrLabel7.Name = "XrLabel7";
			this.XrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel7.SizeF = new System.Drawing.SizeF(128.5F, 25.0F);
			this.XrLabel7.StylePriority.UseBorders = false;
			this.XrLabel7.StylePriority.UseFont = false;
			this.XrLabel7.StylePriority.UseTextAlignment = false;
			this.XrLabel7.Text = "Foreign Substance";
			this.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//foreignSubstanceXrLabel
			//
			this.foreignSubstanceXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right);
			this.foreignSubstanceXrLabel.CanGrow = false;
			this.foreignSubstanceXrLabel.Font = new System.Drawing.Font("Arial", 9.0F);
			this.foreignSubstanceXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(306.0F, 350.0F);
			this.foreignSubstanceXrLabel.Name = "foreignSubstanceXrLabel";
			this.foreignSubstanceXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.foreignSubstanceXrLabel.SizeF = new System.Drawing.SizeF(60.0F, 25.0F);
			this.foreignSubstanceXrLabel.StylePriority.UseBorders = false;
			this.foreignSubstanceXrLabel.StylePriority.UseFont = false;
			this.foreignSubstanceXrLabel.StylePriority.UseTextAlignment = false;
			this.foreignSubstanceXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//wheelsChockedXrLabel
			//
			this.wheelsChockedXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right);
			this.wheelsChockedXrLabel.CanGrow = false;
			this.wheelsChockedXrLabel.Font = new System.Drawing.Font("Arial", 9.0F);
			this.wheelsChockedXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(117.5F, 350.0F);
			this.wheelsChockedXrLabel.Name = "wheelsChockedXrLabel";
			this.wheelsChockedXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.wheelsChockedXrLabel.SizeF = new System.Drawing.SizeF(60.0F, 25.0F);
			this.wheelsChockedXrLabel.StylePriority.UseBorders = false;
			this.wheelsChockedXrLabel.StylePriority.UseFont = false;
			this.wheelsChockedXrLabel.StylePriority.UseTextAlignment = false;
			this.wheelsChockedXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel1
			//
			this.XrLabel1.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top);
			this.XrLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 350.0F);
			this.XrLabel1.Name = "XrLabel1";
			this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel1.SizeF = new System.Drawing.SizeF(117.5F, 25.0F);
			this.XrLabel1.StylePriority.UseBorders = false;
			this.XrLabel1.StylePriority.UseFont = false;
			this.XrLabel1.StylePriority.UseTextAlignment = false;
			this.XrLabel1.Text = "Wheels Chocked";
			this.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//temperatureXrLabel
			//
			this.temperatureXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right);
			this.temperatureXrLabel.CanGrow = false;
			this.temperatureXrLabel.Font = new System.Drawing.Font("Arial", 9.0F);
			this.temperatureXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(670.505F, 325.0F);
			this.temperatureXrLabel.Name = "temperatureXrLabel";
			this.temperatureXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.temperatureXrLabel.SizeF = new System.Drawing.SizeF(106.62F, 25.0F);
			this.temperatureXrLabel.StylePriority.UseBorders = false;
			this.temperatureXrLabel.StylePriority.UseFont = false;
			this.temperatureXrLabel.StylePriority.UseTextAlignment = false;
			this.temperatureXrLabel.Text = "XrLabel13";
			this.temperatureXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//finishTimeXrLabel
			//
			this.finishTimeXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top);
			this.finishTimeXrLabel.CanGrow = false;
			this.finishTimeXrLabel.Font = new System.Drawing.Font("Arial", 9.0F);
			this.finishTimeXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(565.505F, 325.0F);
			this.finishTimeXrLabel.Name = "finishTimeXrLabel";
			this.finishTimeXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.finishTimeXrLabel.SizeF = new System.Drawing.SizeF(105.0F, 25.0F);
			this.finishTimeXrLabel.StylePriority.UseBorders = false;
			this.finishTimeXrLabel.StylePriority.UseFont = false;
			this.finishTimeXrLabel.StylePriority.UseTextAlignment = false;
			this.finishTimeXrLabel.Text = "XrLabel13";
			this.finishTimeXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel28
			//
			this.XrLabel28.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right);
			this.XrLabel28.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(670.5049F, 300.0F);
			this.XrLabel28.Name = "XrLabel28";
			this.XrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel28.SizeF = new System.Drawing.SizeF(106.6201F, 25.0F);
			this.XrLabel28.StylePriority.UseBorders = false;
			this.XrLabel28.StylePriority.UseFont = false;
			this.XrLabel28.StylePriority.UseTextAlignment = false;
			this.XrLabel28.Text = "Temperature";
			this.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel29
			//
			this.XrLabel29.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top);
			this.XrLabel29.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(565.505F, 300.0F);
			this.XrLabel29.Name = "XrLabel29";
			this.XrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel29.SizeF = new System.Drawing.SizeF(105.0F, 25.0F);
			this.XrLabel29.StylePriority.UseBorders = false;
			this.XrLabel29.StylePriority.UseFont = false;
			this.XrLabel29.StylePriority.UseTextAlignment = false;
			this.XrLabel29.Text = "Finish Time";
			this.XrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//loadedByLabelXrLabel
			//
			this.loadedByLabelXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top);
			this.loadedByLabelXrLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.loadedByLabelXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 300.0F);
			this.loadedByLabelXrLabel.Name = "loadedByLabelXrLabel";
			this.loadedByLabelXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.loadedByLabelXrLabel.SizeF = new System.Drawing.SizeF(105.0F, 25.0F);
			this.loadedByLabelXrLabel.StylePriority.UseBorders = false;
			this.loadedByLabelXrLabel.StylePriority.UseFont = false;
			this.loadedByLabelXrLabel.StylePriority.UseTextAlignment = false;
			this.loadedByLabelXrLabel.Text = "Loaded By";
			this.loadedByLabelXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel20
			//
			this.XrLabel20.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top);
			this.XrLabel20.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(105.0F, 300.0F);
			this.XrLabel20.Name = "XrLabel20";
			this.XrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel20.SizeF = new System.Drawing.SizeF(105.0F, 25.0F);
			this.XrLabel20.StylePriority.UseBorders = false;
			this.XrLabel20.StylePriority.UseFont = false;
			this.XrLabel20.StylePriority.UseTextAlignment = false;
			this.XrLabel20.Text = "Checked By";
			this.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel22
			//
			this.XrLabel22.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top);
			this.XrLabel22.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(210.0F, 300.0F);
			this.XrLabel22.Name = "XrLabel22";
			this.XrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel22.SizeF = new System.Drawing.SizeF(130.505F, 25.0F);
			this.XrLabel22.StylePriority.UseBorders = false;
			this.XrLabel22.StylePriority.UseFont = false;
			this.XrLabel22.StylePriority.UseTextAlignment = false;
			this.XrLabel22.Text = "Physical Condition";
			this.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel24
			//
			this.XrLabel24.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top);
			this.XrLabel24.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(340.505F, 300.0F);
			this.XrLabel24.Name = "XrLabel24";
			this.XrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel24.SizeF = new System.Drawing.SizeF(120.0F, 25.0F);
			this.XrLabel24.StylePriority.UseBorders = false;
			this.XrLabel24.StylePriority.UseFont = false;
			this.XrLabel24.StylePriority.UseTextAlignment = false;
			this.XrLabel24.Text = "Load Condition";
			this.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel25
			//
			this.XrLabel25.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right);
			this.XrLabel25.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(460.505F, 300.0F);
			this.XrLabel25.Name = "XrLabel25";
			this.XrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel25.SizeF = new System.Drawing.SizeF(105.0F, 25.0F);
			this.XrLabel25.StylePriority.UseBorders = false;
			this.XrLabel25.StylePriority.UseFont = false;
			this.XrLabel25.StylePriority.UseTextAlignment = false;
			this.XrLabel25.Text = "Start Time";
			this.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//loadedByXrLabel
			//
			this.loadedByXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top);
			this.loadedByXrLabel.CanGrow = false;
			this.loadedByXrLabel.Font = new System.Drawing.Font("Arial", 9.0F);
			this.loadedByXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 325.0F);
			this.loadedByXrLabel.Name = "loadedByXrLabel";
			this.loadedByXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.loadedByXrLabel.SizeF = new System.Drawing.SizeF(105.0F, 25.0F);
			this.loadedByXrLabel.StylePriority.UseBorders = false;
			this.loadedByXrLabel.StylePriority.UseFont = false;
			this.loadedByXrLabel.StylePriority.UseTextAlignment = false;
			this.loadedByXrLabel.Text = "poXrLabel";
			this.loadedByXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//checkedByXrLabel
			//
			this.checkedByXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top);
			this.checkedByXrLabel.CanGrow = false;
			this.checkedByXrLabel.Font = new System.Drawing.Font("Arial", 9.0F);
			this.checkedByXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(105.0F, 325.0F);
			this.checkedByXrLabel.Name = "checkedByXrLabel";
			this.checkedByXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.checkedByXrLabel.SizeF = new System.Drawing.SizeF(105.0F, 25.0F);
			this.checkedByXrLabel.StylePriority.UseBorders = false;
			this.checkedByXrLabel.StylePriority.UseFont = false;
			this.checkedByXrLabel.StylePriority.UseTextAlignment = false;
			this.checkedByXrLabel.Text = "deliveryNoteNumberXrLabel";
			this.checkedByXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//physicalConditionXrLabel
			//
			this.physicalConditionXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top);
			this.physicalConditionXrLabel.CanGrow = false;
			this.physicalConditionXrLabel.Font = new System.Drawing.Font("Arial", 9.0F);
			this.physicalConditionXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(210.0F, 325.0F);
			this.physicalConditionXrLabel.Name = "physicalConditionXrLabel";
			this.physicalConditionXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.physicalConditionXrLabel.SizeF = new System.Drawing.SizeF(130.505F, 25.0F);
			this.physicalConditionXrLabel.StylePriority.UseBorders = false;
			this.physicalConditionXrLabel.StylePriority.UseFont = false;
			this.physicalConditionXrLabel.StylePriority.UseTextAlignment = false;
			this.physicalConditionXrLabel.Text = "XrLabel12";
			this.physicalConditionXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//loadConditionXrLabel
			//
			this.loadConditionXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top);
			this.loadConditionXrLabel.CanGrow = false;
			this.loadConditionXrLabel.Font = new System.Drawing.Font("Arial", 9.0F);
			this.loadConditionXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(340.505F, 325.0F);
			this.loadConditionXrLabel.Name = "loadConditionXrLabel";
			this.loadConditionXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.loadConditionXrLabel.SizeF = new System.Drawing.SizeF(120.0F, 25.0F);
			this.loadConditionXrLabel.StylePriority.UseBorders = false;
			this.loadConditionXrLabel.StylePriority.UseFont = false;
			this.loadConditionXrLabel.StylePriority.UseTextAlignment = false;
			this.loadConditionXrLabel.Text = "XrLabel13";
			this.loadConditionXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//startTimeXrLabel
			//
			this.startTimeXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right);
			this.startTimeXrLabel.CanGrow = false;
			this.startTimeXrLabel.Font = new System.Drawing.Font("Arial", 9.0F);
			this.startTimeXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(460.505F, 325.0F);
			this.startTimeXrLabel.Name = "startTimeXrLabel";
			this.startTimeXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.startTimeXrLabel.SizeF = new System.Drawing.SizeF(105.0F, 25.0F);
			this.startTimeXrLabel.StylePriority.UseBorders = false;
			this.startTimeXrLabel.StylePriority.UseFont = false;
			this.startTimeXrLabel.StylePriority.UseTextAlignment = false;
			this.startTimeXrLabel.Text = "XrLabel13";
			this.startTimeXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//lpnLabelXrLabel
			//
			this.lpnLabelXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.lpnLabelXrLabel.CanGrow = false;
			this.lpnLabelXrLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.lpnLabelXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(377.1667F, 375.0F);
			this.lpnLabelXrLabel.Name = "lpnLabelXrLabel";
			this.lpnLabelXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.lpnLabelXrLabel.SizeF = new System.Drawing.SizeF(107.8334F, 25.0F);
			this.lpnLabelXrLabel.StylePriority.UseBorders = false;
			this.lpnLabelXrLabel.StylePriority.UseFont = false;
			this.lpnLabelXrLabel.StylePriority.UseTextAlignment = false;
			this.lpnLabelXrLabel.Text = "LPN";
			this.lpnLabelXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel19
			//
			this.XrLabel19.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrLabel19.CanGrow = false;
			this.XrLabel19.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(485.0F, 375.0F);
			this.XrLabel19.Name = "XrLabel19";
			this.XrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel19.SizeF = new System.Drawing.SizeF(100.0F, 25.0F);
			this.XrLabel19.StylePriority.UseBorders = false;
			this.XrLabel19.StylePriority.UseFont = false;
			this.XrLabel19.StylePriority.UseTextAlignment = false;
			this.XrLabel19.Text = "LOT";
			this.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel18
			//
			this.XrLabel18.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrLabel18.CanGrow = false;
			this.XrLabel18.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(585.0F, 375.0F);
			this.XrLabel18.Name = "XrLabel18";
			this.XrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel18.SizeF = new System.Drawing.SizeF(74.0F, 25.0F);
			this.XrLabel18.StylePriority.UseBorders = false;
			this.XrLabel18.StylePriority.UseFont = false;
			this.XrLabel18.StylePriority.UseTextAlignment = false;
			this.XrLabel18.Text = "EXP. DATE";
			this.XrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
			this.XrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(148.0F, 375.0F);
			this.XrLabel16.Name = "XrLabel16";
			this.XrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel16.SizeF = new System.Drawing.SizeF(229.1667F, 25.0F);
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
			this.XrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(659.0F, 375.0F);
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
			this.XrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(717.0F, 375.0F);
			this.XrLabel14.Name = "XrLabel14";
			this.XrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel14.SizeF = new System.Drawing.SizeF(61.0F, 25.0F);
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
			this.XrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(48.0F, 375.0F);
			this.XrLabel13.Name = "XrLabel13";
			this.XrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel13.SizeF = new System.Drawing.SizeF(100.0F, 25.0F);
			this.XrLabel13.StylePriority.UseBorders = false;
			this.XrLabel13.StylePriority.UseFont = false;
			this.XrLabel13.StylePriority.UseTextAlignment = false;
			this.XrLabel13.Text = "ITEM #";
			this.XrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//qtyLabelXrLabel
			//
			this.qtyLabelXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.qtyLabelXrLabel.CanGrow = false;
			this.qtyLabelXrLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.qtyLabelXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 375.0F);
			this.qtyLabelXrLabel.Name = "qtyLabelXrLabel";
			this.qtyLabelXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.qtyLabelXrLabel.SizeF = new System.Drawing.SizeF(48.0F, 25.0F);
			this.qtyLabelXrLabel.StylePriority.UseBorders = false;
			this.qtyLabelXrLabel.StylePriority.UseFont = false;
			this.qtyLabelXrLabel.StylePriority.UseTextAlignment = false;
			this.qtyLabelXrLabel.Text = "QTY";
			this.qtyLabelXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//sealXrLabel
			//
			this.sealXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right);
			this.sealXrLabel.CanGrow = false;
			this.sealXrLabel.Font = new System.Drawing.Font("Arial", 9.0F);
			this.sealXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(623.0F, 275.0F);
			this.sealXrLabel.Name = "sealXrLabel";
			this.sealXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.sealXrLabel.SizeF = new System.Drawing.SizeF(155.0F, 25.0F);
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
			this.trailerXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(467.0F, 275.0F);
			this.trailerXrLabel.Name = "trailerXrLabel";
			this.trailerXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.trailerXrLabel.SizeF = new System.Drawing.SizeF(156.0F, 25.0F);
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
			this.carrierXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(311.0F, 275.0F);
			this.carrierXrLabel.Name = "carrierXrLabel";
			this.carrierXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.carrierXrLabel.SizeF = new System.Drawing.SizeF(156.0F, 25.0F);
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
			this.deliveryNoteNumberXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(155.0F, 275.0F);
			this.deliveryNoteNumberXrLabel.Name = "deliveryNoteNumberXrLabel";
			this.deliveryNoteNumberXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.deliveryNoteNumberXrLabel.SizeF = new System.Drawing.SizeF(156.0F, 25.0F);
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
			this.poXrLabel.SizeF = new System.Drawing.SizeF(155.0F, 25.0F);
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
			this.XrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(623.0F, 250.0F);
			this.XrLabel11.Name = "XrLabel11";
			this.XrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel11.SizeF = new System.Drawing.SizeF(155.0F, 25.0F);
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
			this.XrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(467.0F, 250.0F);
			this.XrLabel10.Name = "XrLabel10";
			this.XrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel10.SizeF = new System.Drawing.SizeF(156.0F, 25.0F);
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
			this.XrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(311.0F, 250.0F);
			this.XrLabel9.Name = "XrLabel9";
			this.XrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel9.SizeF = new System.Drawing.SizeF(156.0F, 25.0F);
			this.XrLabel9.StylePriority.UseBorders = false;
			this.XrLabel9.StylePriority.UseFont = false;
			this.XrLabel9.StylePriority.UseTextAlignment = false;
			this.XrLabel9.Text = "CARRIER";
			this.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//deliveryNoteLabelXrLabel
			//
			this.deliveryNoteLabelXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top);
			this.deliveryNoteLabelXrLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.deliveryNoteLabelXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(155.0F, 250.0F);
			this.deliveryNoteLabelXrLabel.Name = "deliveryNoteLabelXrLabel";
			this.deliveryNoteLabelXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.deliveryNoteLabelXrLabel.SizeF = new System.Drawing.SizeF(156.0F, 25.0F);
			this.deliveryNoteLabelXrLabel.StylePriority.UseBorders = false;
			this.deliveryNoteLabelXrLabel.StylePriority.UseFont = false;
			this.deliveryNoteLabelXrLabel.StylePriority.UseTextAlignment = false;
			this.deliveryNoteLabelXrLabel.Text = "DELIVERY NOTE #";
			this.deliveryNoteLabelXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel6
			//
			this.XrLabel6.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top);
			this.XrLabel6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 250.0F);
			this.XrLabel6.Name = "XrLabel6";
			this.XrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel6.SizeF = new System.Drawing.SizeF(155.0F, 25.0F);
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
			this.toXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(433.0F, 125.0F);
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
			this.XrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(433.0F, 100.0F);
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
			this.bolXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(658.0F, 57.99999F);
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
			this.dateXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(558.0F, 57.99999F);
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
			this.XrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(558.0F, 32.99999F);
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
			this.XrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(658.0F, 32.99999F);
			this.XrLabel2.Name = "XrLabel2";
			this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel2.SizeF = new System.Drawing.SizeF(100.0F, 25.0F);
			this.XrLabel2.StylePriority.UseBorders = false;
			this.XrLabel2.StylePriority.UseFont = false;
			this.XrLabel2.StylePriority.UseTextAlignment = false;
			this.XrLabel2.Text = "BOL #";
			this.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//reportTitleXrLabel
			//
			this.reportTitleXrLabel.Font = new System.Drawing.Font("Arial", 13.0F, System.Drawing.FontStyle.Bold);
			this.reportTitleXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(312.5F, 0F);
			this.reportTitleXrLabel.Name = "reportTitleXrLabel";
			this.reportTitleXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.reportTitleXrLabel.SizeF = new System.Drawing.SizeF(146.1667F, 25.0F);
			this.reportTitleXrLabel.StylePriority.UseFont = false;
			this.reportTitleXrLabel.StylePriority.UseTextAlignment = false;
			this.reportTitleXrLabel.Text = "PACKING LIST";
			this.reportTitleXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//locationId
			//
			this.locationId.LocationFloat = new DevExpress.Utils.PointFloat(194.2083F, 100.0F);
			this.locationId.Name = "locationId";
			this.locationId.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.locationId.SizeF = new System.Drawing.SizeF(100.0F, 23.0F);
			this.locationId.Visible = false;
			//
			//ReportFooter
			//
			this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.totalPalletWeightXrLabel, this.palletsTotalXrLabel, this.XrLabel33, this.XrLabel23, this.totalPalletsXrLabel, this.totalWeightXrLabel, this.XrLine1});
			this.ReportFooter.HeightF = 52.0F;
			this.ReportFooter.KeepTogether = true;
			this.ReportFooter.Name = "ReportFooter";
			this.ReportFooter.PrintAtBottom = true;
			//
			//totalPalletWeightXrLabel
			//
			this.totalPalletWeightXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
			this.totalPalletWeightXrLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.totalPalletWeightXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(717.0F, 2.0F);
			this.totalPalletWeightXrLabel.Name = "totalPalletWeightXrLabel";
			this.totalPalletWeightXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.totalPalletWeightXrLabel.SizeF = new System.Drawing.SizeF(61.0F, 25.0F);
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
			this.palletsTotalXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(659.0F, 27.0F);
			this.palletsTotalXrLabel.Name = "palletsTotalXrLabel";
			this.palletsTotalXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.palletsTotalXrLabel.SizeF = new System.Drawing.SizeF(58.0F, 25.0F);
			this.palletsTotalXrLabel.StylePriority.UseBorders = false;
			this.palletsTotalXrLabel.StylePriority.UseFont = false;
			this.palletsTotalXrLabel.StylePriority.UseTextAlignment = false;
			this.palletsTotalXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel33
			//
			this.XrLabel33.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
			this.XrLabel33.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(399.0F, 2.0F);
			this.XrLabel33.Name = "XrLabel33";
			this.XrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel33.SizeF = new System.Drawing.SizeF(260.0F, 25.0F);
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
			this.XrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(398.0F, 27.0F);
			this.XrLabel23.Name = "XrLabel23";
			this.XrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel23.SizeF = new System.Drawing.SizeF(261.9999F, 25.0F);
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
			this.totalPalletsXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(659.0F, 2.0F);
			this.totalPalletsXrLabel.Name = "totalPalletsXrLabel";
			this.totalPalletsXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.totalPalletsXrLabel.SizeF = new System.Drawing.SizeF(58.0F, 25.0F);
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
			this.totalWeightXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(717.0F, 27.0F);
			this.totalWeightXrLabel.Name = "totalWeightXrLabel";
			this.totalWeightXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.totalWeightXrLabel.SizeF = new System.Drawing.SizeF(61.0F, 25.0F);
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
			this.XrLine1.SizeF = new System.Drawing.SizeF(777.125F, 2.0F);
			//
			//returnsGroupHeader
			//
			this.returnsGroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel21});
			this.returnsGroupHeader.HeightF = 25.0F;
			this.returnsGroupHeader.KeepTogether = true;
			this.returnsGroupHeader.Level = 2;
			this.returnsGroupHeader.Name = "returnsGroupHeader";
			//
			//XrLabel21
			//
			this.XrLabel21.BackColor = System.Drawing.Color.White;
			this.XrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.XrLabel21.Font = new System.Drawing.Font("Arial", 9.75F, (System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, (byte)0);
			this.XrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(340.505F, 0F);
			this.XrLabel21.Name = "XrLabel21";
			this.XrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel21.SizeF = new System.Drawing.SizeF(111.5F, 25.0F);
			this.XrLabel21.StylePriority.UseBackColor = false;
			this.XrLabel21.StylePriority.UseBorders = false;
			this.XrLabel21.StylePriority.UseFont = false;
			this.XrLabel21.StylePriority.UseTextAlignment = false;
			this.XrLabel21.Text = "Returns";
			this.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrCrossBandLine1XRCrossBandLine2
			//
			this.XrCrossBandLine1XRCrossBandLine2.EndBand = this.ReportFooter;
			this.XrCrossBandLine1XRCrossBandLine2.EndPointFloat = new DevExpress.Utils.PointFloat(777.125F, 28.99998F);
			this.XrCrossBandLine1XRCrossBandLine2.LocationFloat = new DevExpress.Utils.PointFloat(777.125F, 1.041667F);
			this.XrCrossBandLine1XRCrossBandLine2.Name = "XrCrossBandLine1XRCrossBandLine2";
			this.XrCrossBandLine1XRCrossBandLine2.StartBand = this.returnsGroupHeader;
			this.XrCrossBandLine1XRCrossBandLine2.StartPointFloat = new DevExpress.Utils.PointFloat(777.125F, 1.041667F);
			this.XrCrossBandLine1XRCrossBandLine2.WidthF = 1.041626F;
			//
			//XrCrossBandLine1XRCrossBandLine5
			//
			this.XrCrossBandLine1XRCrossBandLine5.EndBand = this.ReportFooter;
			this.XrCrossBandLine1XRCrossBandLine5.EndPointFloat = new DevExpress.Utils.PointFloat(0F, 2.0F);
			this.XrCrossBandLine1XRCrossBandLine5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.XrCrossBandLine1XRCrossBandLine5.Name = "XrCrossBandLine1XRCrossBandLine5";
			this.XrCrossBandLine1XRCrossBandLine5.StartBand = this.returnsGroupHeader;
			this.XrCrossBandLine1XRCrossBandLine5.StartPointFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.XrCrossBandLine1XRCrossBandLine5.WidthF = 1.0F;
			//
			//TopMarginBand1
			//
			this.TopMarginBand1.HeightF = 50.0F;
			this.TopMarginBand1.Name = "TopMarginBand1";
			//
			//BottomMarginBand1
			//
			this.BottomMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrPageInfo1});
			this.BottomMarginBand1.HeightF = 50.0F;
			this.BottomMarginBand1.Name = "BottomMarginBand1";
			//
			//XrPageInfo1
			//
			this.XrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(670.0F, 9.999974F);
			this.XrPageInfo1.Name = "XrPageInfo1";
			this.XrPageInfo1.SizeF = new System.Drawing.SizeF(100.0F, 23.0F);
			this.XrPageInfo1.TextFormatString = "Page {0} of {1}";
			//
			//itemsGroupFooter
			//
			this.itemsGroupFooter.BackColor = System.Drawing.Color.Gray;
			this.itemsGroupFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.itemTotalWeightXrLabel, this.itemTotalPalletsXrLabel, this.groupItemDescriptionXrLabel, this.groupItemCodeXrLabel, this.itemTotalQuantityXrLabel, this.groupItemLabel});
			this.itemsGroupFooter.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
			this.itemsGroupFooter.HeightF = 25.0F;
			this.itemsGroupFooter.Level = 1;
			this.itemsGroupFooter.Name = "itemsGroupFooter";
			this.itemsGroupFooter.StylePriority.UseBackColor = false;
			this.itemsGroupFooter.StylePriority.UseFont = false;
			//
			//itemTotalWeightXrLabel
			//
			this.itemTotalWeightXrLabel.BackColor = System.Drawing.Color.FromArgb((int)((byte)148), (int)((byte)148), (int)((byte)148));
			this.itemTotalWeightXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.itemTotalWeightXrLabel.Font = new System.Drawing.Font("Arial", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.itemTotalWeightXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(712.125F, 0F);
			this.itemTotalWeightXrLabel.Name = "itemTotalWeightXrLabel";
			this.itemTotalWeightXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemTotalWeightXrLabel.SizeF = new System.Drawing.SizeF(65.0F, 25.0F);
			this.itemTotalWeightXrLabel.StylePriority.UseBackColor = false;
			this.itemTotalWeightXrLabel.StylePriority.UseBorders = false;
			this.itemTotalWeightXrLabel.StylePriority.UseFont = false;
			this.itemTotalWeightXrLabel.StylePriority.UseTextAlignment = false;
			XrSummary1.FormatString = "{0:#0.00}";
			XrSummary1.IgnoreNullValues = true;
			XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
			this.itemTotalWeightXrLabel.Summary = XrSummary1;
			this.itemTotalWeightXrLabel.Text = "Weight";
			this.itemTotalWeightXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemTotalPalletsXrLabel
			//
			this.itemTotalPalletsXrLabel.BackColor = System.Drawing.Color.FromArgb((int)((byte)148), (int)((byte)148), (int)((byte)148));
			this.itemTotalPalletsXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.itemTotalPalletsXrLabel.Font = new System.Drawing.Font("Arial", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.itemTotalPalletsXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(652.1251F, 0F);
			this.itemTotalPalletsXrLabel.Name = "itemTotalPalletsXrLabel";
			this.itemTotalPalletsXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemTotalPalletsXrLabel.SizeF = new System.Drawing.SizeF(60.0F, 25.0F);
			this.itemTotalPalletsXrLabel.StylePriority.UseBackColor = false;
			this.itemTotalPalletsXrLabel.StylePriority.UseBorders = false;
			this.itemTotalPalletsXrLabel.StylePriority.UseFont = false;
			this.itemTotalPalletsXrLabel.StylePriority.UseTextAlignment = false;
			XrSummary2.FormatString = "{0:#,###.00}";
			XrSummary2.IgnoreNullValues = true;
			XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
			this.itemTotalPalletsXrLabel.Summary = XrSummary2;
			this.itemTotalPalletsXrLabel.Text = "Pallets";
			this.itemTotalPalletsXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//groupItemDescriptionXrLabel
			//
			this.groupItemDescriptionXrLabel.BackColor = System.Drawing.Color.FromArgb((int)((byte)148), (int)((byte)148), (int)((byte)148));
			this.groupItemDescriptionXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.groupItemDescriptionXrLabel.Font = new System.Drawing.Font("Arial", 9.0F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.groupItemDescriptionXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(650.0417F, 0F);
			this.groupItemDescriptionXrLabel.Multiline = true;
			this.groupItemDescriptionXrLabel.Name = "groupItemDescriptionXrLabel";
			this.groupItemDescriptionXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.groupItemDescriptionXrLabel.SizeF = new System.Drawing.SizeF(2.083374F, 25.0F);
			this.groupItemDescriptionXrLabel.StylePriority.UseBackColor = false;
			this.groupItemDescriptionXrLabel.StylePriority.UseBorders = false;
			this.groupItemDescriptionXrLabel.StylePriority.UseFont = false;
			this.groupItemDescriptionXrLabel.StylePriority.UseTextAlignment = false;
			this.groupItemDescriptionXrLabel.Text = "Item Description";
			this.groupItemDescriptionXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			this.groupItemDescriptionXrLabel.Visible = false;
			//
			//groupItemCodeXrLabel
			//
			this.groupItemCodeXrLabel.BackColor = System.Drawing.Color.FromArgb((int)((byte)148), (int)((byte)148), (int)((byte)148));
			this.groupItemCodeXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.groupItemCodeXrLabel.Font = new System.Drawing.Font("Arial", 11.0F, System.Drawing.FontStyle.Bold);
			this.groupItemCodeXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(155.0F, 0F);
			this.groupItemCodeXrLabel.Name = "groupItemCodeXrLabel";
			this.groupItemCodeXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.groupItemCodeXrLabel.SizeF = new System.Drawing.SizeF(497.1251F, 25.0F);
			this.groupItemCodeXrLabel.StylePriority.UseBackColor = false;
			this.groupItemCodeXrLabel.StylePriority.UseBorders = false;
			this.groupItemCodeXrLabel.StylePriority.UseFont = false;
			this.groupItemCodeXrLabel.StylePriority.UseTextAlignment = false;
			this.groupItemCodeXrLabel.Text = "Item #";
			this.groupItemCodeXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//itemTotalQuantityXrLabel
			//
			this.itemTotalQuantityXrLabel.BackColor = System.Drawing.Color.FromArgb((int)((byte)148), (int)((byte)148), (int)((byte)148));
			this.itemTotalQuantityXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.itemTotalQuantityXrLabel.Font = new System.Drawing.Font("Arial", 9.0F, System.Drawing.FontStyle.Bold);
			this.itemTotalQuantityXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.itemTotalQuantityXrLabel.Name = "itemTotalQuantityXrLabel";
			this.itemTotalQuantityXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemTotalQuantityXrLabel.SizeF = new System.Drawing.SizeF(47.99998F, 25.0F);
			this.itemTotalQuantityXrLabel.StylePriority.UseBackColor = false;
			this.itemTotalQuantityXrLabel.StylePriority.UseBorders = false;
			this.itemTotalQuantityXrLabel.StylePriority.UseFont = false;
			this.itemTotalQuantityXrLabel.StylePriority.UseTextAlignment = false;
			XrSummary3.IgnoreNullValues = true;
			XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
			this.itemTotalQuantityXrLabel.Summary = XrSummary3;
			this.itemTotalQuantityXrLabel.Text = "Qty";
			this.itemTotalQuantityXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//groupItemLabel
			//
			this.groupItemLabel.BackColor = System.Drawing.Color.FromArgb((int)((byte)148), (int)((byte)148), (int)((byte)148));
			this.groupItemLabel.Borders = (DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.groupItemLabel.Font = new System.Drawing.Font("Arial", 10.0F, System.Drawing.FontStyle.Bold);
			this.groupItemLabel.LocationFloat = new DevExpress.Utils.PointFloat(48.00002F, 0F);
			this.groupItemLabel.Name = "groupItemLabel";
			this.groupItemLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.groupItemLabel.SizeF = new System.Drawing.SizeF(107.0F, 25.0F);
			this.groupItemLabel.StylePriority.UseBackColor = false;
			this.groupItemLabel.StylePriority.UseBorders = false;
			this.groupItemLabel.StylePriority.UseFont = false;
			this.groupItemLabel.StylePriority.UseTextAlignment = false;
			this.groupItemLabel.Text = "Subtotal Item # ";
			this.groupItemLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemGroupHeader
			//
			this.itemGroupHeader.HeightF = 0F;
			this.itemGroupHeader.Level = 1;
			this.itemGroupHeader.Name = "itemGroupHeader";
			//
			//PageFooter
			//
			this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.packingListpageinfo});
			this.PageFooter.HeightF = 23.0F;
			this.PageFooter.Name = "PageFooter";
			//
			//packingListpageinfo
			//
			this.packingListpageinfo.LocationFloat = new DevExpress.Utils.PointFloat(670.0F, 0F);
			this.packingListpageinfo.Name = "packingListpageinfo";
			this.packingListpageinfo.SizeF = new System.Drawing.SizeF(100.0F, 23.0F);
			this.packingListpageinfo.TextFormatString = "Page {0} of {1}";
			this.packingListpageinfo.Visible = false;
			//
			//lotGroupHeader
			//
			this.lotGroupHeader.Expanded = false;
			this.lotGroupHeader.HeightF = 0F;
			this.lotGroupHeader.Name = "lotGroupHeader";
			//
			//PackingListXtraReport
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.ReportHeader, this.ReportFooter, this.returnsGroupHeader, this.TopMarginBand1, this.BottomMarginBand1, this.itemsGroupFooter, this.itemGroupHeader, this.PageFooter, this.lotGroupHeader});
			this.CrossBandControls.AddRange(new DevExpress.XtraReports.UI.XRCrossBandControl[] {this.XrCrossBandLine1XRCrossBandLine2, this.XrCrossBandLine1XRCrossBandLine5});
			this.Margins = new System.Drawing.Printing.Margins(36, 35, 50, 50);
			this.Version = "17.2";
			((System.ComponentModel.ISupportInitialize)this).EndInit();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			fromXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(fromXrLabel_BeforePrint);
			toXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(toXrLabel_BeforePrint);
			returnsGroupHeader.BeforePrint += new System.Drawing.Printing.PrintEventHandler(returnsGroupHeader_BeforePrint);
			totalPalletWeightXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(totalPalletWeightXrLabel_BeforePrint);
			itemDescriptionXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(itemDescriptionXrLabel_BeforePrint);
			totalWeightXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(totalWeightXrLabel_BeforePrint);
			wheelsChockedXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(wheelsChockedXrLabel_BeforePrint);
			foreignSubstanceXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(foreignSubstanceXrLabel_BeforePrint);
			insectActivityXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(insectActivityXrLabel_BeforePrint);
			correctPalletsXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(correctPalletsXrLabel_BeforePrint);
		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
		internal DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
		internal DevExpress.XtraReports.UI.GroupHeaderBand returnsGroupHeader;
		internal DevExpress.XtraReports.UI.XRLabel reportTitleXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel bolXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel dateXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel3;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
		internal DevExpress.XtraReports.UI.XRLabel fromXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel5;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel4;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel10;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel9;
		internal DevExpress.XtraReports.UI.XRLabel deliveryNoteLabelXrLabel;
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
		internal DevExpress.XtraReports.UI.XRLabel qtyLabelXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel16;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel21;
		internal DevExpress.XtraReports.UI.XRLabel itemDescriptionXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel palletsXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel weightXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemCodeXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel qtyXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel23;
		internal DevExpress.XtraReports.UI.XRLabel totalPalletsXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel totalWeightXrLabel;
		internal DevExpress.XtraReports.UI.XRLine XrLine1;
		internal DevExpress.XtraReports.UI.XRCrossBandLine XrCrossBandLine1XRCrossBandLine2;
		internal DevExpress.XtraReports.UI.XRCrossBandLine XrCrossBandLine1XRCrossBandLine5;
		internal DevExpress.XtraReports.UI.XRLabel palletsTotalXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel33;
		internal DevExpress.XtraReports.UI.XRLabel totalPalletWeightXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel34;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMarginBand1;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMarginBand1;
		internal DevExpress.XtraReports.UI.XRPictureBox spgLogoXrPictureBox;
		internal DevExpress.XtraReports.UI.GroupFooterBand itemsGroupFooter;
		internal DevExpress.XtraReports.UI.XRLabel groupItemCodeXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemTotalQuantityXrLabel;
		internal DevExpress.XtraReports.UI.GroupHeaderBand itemGroupHeader;
		internal DevExpress.XtraReports.UI.XRLabel lpnXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel lotXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel expirationDateXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel lpnLabelXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel19;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel18;
		internal DevExpress.XtraReports.UI.PageFooterBand PageFooter;
		internal DevExpress.XtraReports.UI.XRPageInfo packingListpageinfo;
		internal DevExpress.XtraReports.UI.XRPageInfo XrPageInfo1;
		internal DevExpress.XtraReports.UI.XRLabel temperatureXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel finishTimeXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel28;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel29;
		internal DevExpress.XtraReports.UI.XRLabel loadedByLabelXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel20;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel22;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel24;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel25;
		internal DevExpress.XtraReports.UI.XRLabel loadedByXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel checkedByXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel physicalConditionXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel loadConditionXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel startTimeXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel wheelsChockedXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel7;
		internal DevExpress.XtraReports.UI.XRLabel foreignSubstanceXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel insectActivityXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel17;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel8;
		internal DevExpress.XtraReports.UI.XRLabel correctPalletsXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemTotalWeightXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemTotalPalletsXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel groupItemDescriptionXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel groupItemLabel;
		internal DevExpress.XtraReports.UI.XRLabel locationId;
		internal DevExpress.XtraReports.UI.GroupHeaderBand lotGroupHeader;
	}

}