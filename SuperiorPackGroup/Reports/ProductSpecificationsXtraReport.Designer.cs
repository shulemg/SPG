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
	public partial class ProductSpecificationsXtraReport : DevExpress.XtraReports.UI.XtraReport
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
			this.XrPanel2 = new DevExpress.XtraReports.UI.XRPanel();
			this.specialInstructionsXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrPanel3 = new DevExpress.XtraReports.UI.XRPanel();
			this.XrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
			this.palletPaternXrPictureBox = new DevExpress.XtraReports.UI.XRPictureBox();
			this.shelfLifeXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
			this.caseCodeXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
			this.packageCodeXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.layersPerPalletXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.casesPerLayerXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			this.casesPerPalletXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.unitsPerCaseXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.mavXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.requiredWeightXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.itemBomsXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
			this.itemDescriptionXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemCodeXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			((System.ComponentModel.ISupportInitialize)this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrPanel2, this.shelfLifeXrLabel, this.XrLabel11, this.caseCodeXrLabel, this.XrLabel10, this.packageCodeXrLabel, this.XrLabel9, this.layersPerPalletXrLabel, this.XrLabel8, this.casesPerLayerXrLabel, this.XrLabel7, this.casesPerPalletXrLabel, this.XrLabel6, this.unitsPerCaseXrLabel, this.XrLabel5, this.mavXrLabel, this.XrLabel4, this.requiredWeightXrLabel, this.XrLabel3, this.itemBomsXrLabel, this.XrLabel2, this.XrPanel1});
			this.Detail.Height = 842;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrPanel2
			//
			this.XrPanel2.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrPanel2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.specialInstructionsXrLabel, this.XrLabel13, this.XrPanel3});
			this.XrPanel2.Location = new System.Drawing.Point(0, 425);
			this.XrPanel2.Name = "XrPanel2";
			this.XrPanel2.Size = new System.Drawing.Size(650, 400);
			this.XrPanel2.StylePriority.UseBorders = false;
			//
			//specialInstructionsXrLabel
			//
			this.specialInstructionsXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.specialInstructionsXrLabel.Font = new System.Drawing.Font("Times New Roman", 12.0F);
			this.specialInstructionsXrLabel.Location = new System.Drawing.Point(0, 25);
			this.specialInstructionsXrLabel.Name = "specialInstructionsXrLabel";
			this.specialInstructionsXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.specialInstructionsXrLabel.Size = new System.Drawing.Size(650, 200);
			this.specialInstructionsXrLabel.StylePriority.UseBorders = false;
			this.specialInstructionsXrLabel.StylePriority.UseFont = false;
			this.specialInstructionsXrLabel.StylePriority.UseTextAlignment = false;
			this.specialInstructionsXrLabel.Text = "specialInstructionsXrLabel";
			this.specialInstructionsXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel13
			//
			this.XrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.XrLabel13.Font = new System.Drawing.Font("Times New Roman", 12.0F, System.Drawing.FontStyle.Bold);
			this.XrLabel13.Location = new System.Drawing.Point(0, 0);
			this.XrLabel13.Name = "XrLabel13";
			this.XrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel13.Size = new System.Drawing.Size(650, 25);
			this.XrLabel13.StylePriority.UseBorders = false;
			this.XrLabel13.StylePriority.UseFont = false;
			this.XrLabel13.Text = "Special Instructions";
			//
			//XrPanel3
			//
			this.XrPanel3.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel12, this.palletPaternXrPictureBox});
			this.XrPanel3.Location = new System.Drawing.Point(500, 225);
			this.XrPanel3.Name = "XrPanel3";
			this.XrPanel3.Size = new System.Drawing.Size(150, 175);
			//
			//XrLabel12
			//
			this.XrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.XrLabel12.Font = new System.Drawing.Font("Times New Roman", 12.0F, System.Drawing.FontStyle.Bold);
			this.XrLabel12.Location = new System.Drawing.Point(0, 0);
			this.XrLabel12.Name = "XrLabel12";
			this.XrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel12.Size = new System.Drawing.Size(150, 25);
			this.XrLabel12.StylePriority.UseBorders = false;
			this.XrLabel12.StylePriority.UseFont = false;
			this.XrLabel12.StylePriority.UseTextAlignment = false;
			this.XrLabel12.Text = "Pallet Patern";
			this.XrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//palletPaternXrPictureBox
			//
			this.palletPaternXrPictureBox.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.palletPaternXrPictureBox.Location = new System.Drawing.Point(0, 25);
			this.palletPaternXrPictureBox.Name = "palletPaternXrPictureBox";
			this.palletPaternXrPictureBox.Size = new System.Drawing.Size(150, 150);
			this.palletPaternXrPictureBox.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
			this.palletPaternXrPictureBox.StylePriority.UseBorders = false;
			//
			//shelfLifeXrLabel
			//
			this.shelfLifeXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.shelfLifeXrLabel.Font = new System.Drawing.Font("Times New Roman", 12.0F);
			this.shelfLifeXrLabel.Location = new System.Drawing.Point(100, 400);
			this.shelfLifeXrLabel.Name = "shelfLifeXrLabel";
			this.shelfLifeXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.shelfLifeXrLabel.Size = new System.Drawing.Size(550, 25);
			this.shelfLifeXrLabel.StylePriority.UseBorders = false;
			this.shelfLifeXrLabel.StylePriority.UseFont = false;
			this.shelfLifeXrLabel.StylePriority.UseTextAlignment = false;
			this.shelfLifeXrLabel.Text = "shelfLifeXrLabel";
			this.shelfLifeXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel11
			//
			this.XrLabel11.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrLabel11.Font = new System.Drawing.Font("Times New Roman", 12.0F, System.Drawing.FontStyle.Bold);
			this.XrLabel11.Location = new System.Drawing.Point(0, 400);
			this.XrLabel11.Name = "XrLabel11";
			this.XrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel11.Size = new System.Drawing.Size(100, 25);
			this.XrLabel11.StylePriority.UseBorders = false;
			this.XrLabel11.StylePriority.UseFont = false;
			this.XrLabel11.StylePriority.UseTextAlignment = false;
			this.XrLabel11.Text = "Shelf Life";
			this.XrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
			//
			//caseCodeXrLabel
			//
			this.caseCodeXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.caseCodeXrLabel.Font = new System.Drawing.Font("Times New Roman", 12.0F);
			this.caseCodeXrLabel.Location = new System.Drawing.Point(100, 350);
			this.caseCodeXrLabel.Name = "caseCodeXrLabel";
			this.caseCodeXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.caseCodeXrLabel.Size = new System.Drawing.Size(550, 50);
			this.caseCodeXrLabel.StylePriority.UseBorders = false;
			this.caseCodeXrLabel.StylePriority.UseFont = false;
			this.caseCodeXrLabel.StylePriority.UseTextAlignment = false;
			this.caseCodeXrLabel.Text = "caseCodeXrLabel";
			this.caseCodeXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel10
			//
			this.XrLabel10.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrLabel10.Font = new System.Drawing.Font("Times New Roman", 12.0F, System.Drawing.FontStyle.Bold);
			this.XrLabel10.Location = new System.Drawing.Point(0, 350);
			this.XrLabel10.Name = "XrLabel10";
			this.XrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel10.Size = new System.Drawing.Size(100, 50);
			this.XrLabel10.StylePriority.UseBorders = false;
			this.XrLabel10.StylePriority.UseFont = false;
			this.XrLabel10.StylePriority.UseTextAlignment = false;
			this.XrLabel10.Text = "Case Code Format";
			this.XrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
			//
			//packageCodeXrLabel
			//
			this.packageCodeXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.packageCodeXrLabel.Font = new System.Drawing.Font("Times New Roman", 12.0F);
			this.packageCodeXrLabel.Location = new System.Drawing.Point(100, 300);
			this.packageCodeXrLabel.Name = "packageCodeXrLabel";
			this.packageCodeXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.packageCodeXrLabel.Size = new System.Drawing.Size(550, 50);
			this.packageCodeXrLabel.StylePriority.UseBorders = false;
			this.packageCodeXrLabel.StylePriority.UseFont = false;
			this.packageCodeXrLabel.StylePriority.UseTextAlignment = false;
			this.packageCodeXrLabel.Text = "packageCodeXrLabel";
			this.packageCodeXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel9
			//
			this.XrLabel9.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrLabel9.Font = new System.Drawing.Font("Times New Roman", 11.0F, System.Drawing.FontStyle.Bold);
			this.XrLabel9.Location = new System.Drawing.Point(0, 300);
			this.XrLabel9.Name = "XrLabel9";
			this.XrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel9.Size = new System.Drawing.Size(100, 50);
			this.XrLabel9.StylePriority.UseBorders = false;
			this.XrLabel9.StylePriority.UseFont = false;
			this.XrLabel9.StylePriority.UseTextAlignment = false;
			this.XrLabel9.Text = "Package Code Format";
			this.XrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
			//
			//layersPerPalletXrLabel
			//
			this.layersPerPalletXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.layersPerPalletXrLabel.Font = new System.Drawing.Font("Times New Roman", 12.0F);
			this.layersPerPalletXrLabel.Location = new System.Drawing.Point(425, 250);
			this.layersPerPalletXrLabel.Name = "layersPerPalletXrLabel";
			this.layersPerPalletXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.layersPerPalletXrLabel.Size = new System.Drawing.Size(225, 50);
			this.layersPerPalletXrLabel.StylePriority.UseBorders = false;
			this.layersPerPalletXrLabel.StylePriority.UseFont = false;
			this.layersPerPalletXrLabel.StylePriority.UseTextAlignment = false;
			this.layersPerPalletXrLabel.Text = "layersPerPalletXrLabel";
			this.layersPerPalletXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel8
			//
			this.XrLabel8.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrLabel8.Font = new System.Drawing.Font("Times New Roman", 12.0F, System.Drawing.FontStyle.Bold);
			this.XrLabel8.Location = new System.Drawing.Point(292, 250);
			this.XrLabel8.Name = "XrLabel8";
			this.XrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel8.Size = new System.Drawing.Size(133, 50);
			this.XrLabel8.StylePriority.UseBorders = false;
			this.XrLabel8.StylePriority.UseFont = false;
			this.XrLabel8.StylePriority.UseTextAlignment = false;
			this.XrLabel8.Text = "Layers Per Pallet";
			this.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
			//
			//casesPerLayerXrLabel
			//
			this.casesPerLayerXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.casesPerLayerXrLabel.Font = new System.Drawing.Font("Times New Roman", 10.0F);
			this.casesPerLayerXrLabel.Location = new System.Drawing.Point(225, 250);
			this.casesPerLayerXrLabel.Name = "casesPerLayerXrLabel";
			this.casesPerLayerXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.casesPerLayerXrLabel.Size = new System.Drawing.Size(67, 50);
			this.casesPerLayerXrLabel.StylePriority.UseBorders = false;
			this.casesPerLayerXrLabel.StylePriority.UseFont = false;
			this.casesPerLayerXrLabel.StylePriority.UseTextAlignment = false;
			this.casesPerLayerXrLabel.Text = "casesPerLayerXrLabel";
			this.casesPerLayerXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel7
			//
			this.XrLabel7.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrLabel7.Font = new System.Drawing.Font("Times New Roman", 12.0F, System.Drawing.FontStyle.Bold);
			this.XrLabel7.Location = new System.Drawing.Point(0, 250);
			this.XrLabel7.Name = "XrLabel7";
			this.XrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel7.Size = new System.Drawing.Size(225, 50);
			this.XrLabel7.StylePriority.UseBorders = false;
			this.XrLabel7.StylePriority.UseFont = false;
			this.XrLabel7.StylePriority.UseTextAlignment = false;
			this.XrLabel7.Text = "Cases Per Layer";
			this.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
			//
			//casesPerPalletXrLabel
			//
			this.casesPerPalletXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.casesPerPalletXrLabel.Font = new System.Drawing.Font("Times New Roman", 12.0F);
			this.casesPerPalletXrLabel.Location = new System.Drawing.Point(425, 200);
			this.casesPerPalletXrLabel.Name = "casesPerPalletXrLabel";
			this.casesPerPalletXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.casesPerPalletXrLabel.Size = new System.Drawing.Size(225, 50);
			this.casesPerPalletXrLabel.StylePriority.UseBorders = false;
			this.casesPerPalletXrLabel.StylePriority.UseFont = false;
			this.casesPerPalletXrLabel.StylePriority.UseTextAlignment = false;
			this.casesPerPalletXrLabel.Text = "casesPerPalletXrLabel";
			this.casesPerPalletXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel6
			//
			this.XrLabel6.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrLabel6.Font = new System.Drawing.Font("Times New Roman", 12.0F, System.Drawing.FontStyle.Bold);
			this.XrLabel6.Location = new System.Drawing.Point(292, 200);
			this.XrLabel6.Name = "XrLabel6";
			this.XrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel6.Size = new System.Drawing.Size(133, 50);
			this.XrLabel6.StylePriority.UseBorders = false;
			this.XrLabel6.StylePriority.UseFont = false;
			this.XrLabel6.StylePriority.UseTextAlignment = false;
			this.XrLabel6.Text = "Cases Per Pallet";
			this.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
			//
			//unitsPerCaseXrLabel
			//
			this.unitsPerCaseXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.unitsPerCaseXrLabel.Font = new System.Drawing.Font("Times New Roman", 10.0F);
			this.unitsPerCaseXrLabel.Location = new System.Drawing.Point(225, 200);
			this.unitsPerCaseXrLabel.Name = "unitsPerCaseXrLabel";
			this.unitsPerCaseXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.unitsPerCaseXrLabel.Size = new System.Drawing.Size(67, 50);
			this.unitsPerCaseXrLabel.StylePriority.UseBorders = false;
			this.unitsPerCaseXrLabel.StylePriority.UseFont = false;
			this.unitsPerCaseXrLabel.StylePriority.UseTextAlignment = false;
			this.unitsPerCaseXrLabel.Text = "unitsPerCaseXrLabel";
			this.unitsPerCaseXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel5
			//
			this.XrLabel5.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrLabel5.Font = new System.Drawing.Font("Times New Roman", 12.0F, System.Drawing.FontStyle.Bold);
			this.XrLabel5.Location = new System.Drawing.Point(0, 200);
			this.XrLabel5.Name = "XrLabel5";
			this.XrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel5.Size = new System.Drawing.Size(225, 50);
			this.XrLabel5.StylePriority.UseBorders = false;
			this.XrLabel5.StylePriority.UseFont = false;
			this.XrLabel5.StylePriority.UseTextAlignment = false;
			this.XrLabel5.Text = "Units Per Case";
			this.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
			//
			//mavXrLabel
			//
			this.mavXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.mavXrLabel.Font = new System.Drawing.Font("Times New Roman", 12.0F);
			this.mavXrLabel.Location = new System.Drawing.Point(492, 150);
			this.mavXrLabel.Name = "mavXrLabel";
			this.mavXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.mavXrLabel.Size = new System.Drawing.Size(158, 50);
			this.mavXrLabel.StylePriority.UseBorders = false;
			this.mavXrLabel.StylePriority.UseFont = false;
			this.mavXrLabel.StylePriority.UseTextAlignment = false;
			this.mavXrLabel.Text = "mavXrLabel";
			this.mavXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel4
			//
			this.XrLabel4.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrLabel4.Font = new System.Drawing.Font("Times New Roman", 12.0F, System.Drawing.FontStyle.Bold);
			this.XrLabel4.Location = new System.Drawing.Point(292, 150);
			this.XrLabel4.Name = "XrLabel4";
			this.XrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel4.Size = new System.Drawing.Size(200, 50);
			this.XrLabel4.StylePriority.UseBorders = false;
			this.XrLabel4.StylePriority.UseFont = false;
			this.XrLabel4.StylePriority.UseTextAlignment = false;
			this.XrLabel4.Text = "Maximum Allowance Variance (MAV)";
			this.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
			//
			//requiredWeightXrLabel
			//
			this.requiredWeightXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.requiredWeightXrLabel.Font = new System.Drawing.Font("Times New Roman", 12.0F);
			this.requiredWeightXrLabel.Location = new System.Drawing.Point(167, 150);
			this.requiredWeightXrLabel.Name = "requiredWeightXrLabel";
			this.requiredWeightXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.requiredWeightXrLabel.Size = new System.Drawing.Size(125, 50);
			this.requiredWeightXrLabel.StylePriority.UseBorders = false;
			this.requiredWeightXrLabel.StylePriority.UseFont = false;
			this.requiredWeightXrLabel.StylePriority.UseTextAlignment = false;
			this.requiredWeightXrLabel.Text = "requiredWeightXrLabel";
			this.requiredWeightXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel3
			//
			this.XrLabel3.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrLabel3.Font = new System.Drawing.Font("Times New Roman", 12.0F, System.Drawing.FontStyle.Bold);
			this.XrLabel3.Location = new System.Drawing.Point(0, 150);
			this.XrLabel3.Name = "XrLabel3";
			this.XrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel3.Size = new System.Drawing.Size(167, 50);
			this.XrLabel3.StylePriority.UseBorders = false;
			this.XrLabel3.StylePriority.UseFont = false;
			this.XrLabel3.StylePriority.UseTextAlignment = false;
			this.XrLabel3.Text = "Required Wsight/Count";
			this.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
			//
			//itemBomsXrLabel
			//
			this.itemBomsXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.itemBomsXrLabel.Font = new System.Drawing.Font("Times New Roman", 12.0F);
			this.itemBomsXrLabel.Location = new System.Drawing.Point(167, 100);
			this.itemBomsXrLabel.Name = "itemBomsXrLabel";
			this.itemBomsXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemBomsXrLabel.Size = new System.Drawing.Size(483, 50);
			this.itemBomsXrLabel.StylePriority.UseBorders = false;
			this.itemBomsXrLabel.StylePriority.UseFont = false;
			this.itemBomsXrLabel.StylePriority.UseTextAlignment = false;
			this.itemBomsXrLabel.Text = "itemBomsXrLabel";
			this.itemBomsXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel2
			//
			this.XrLabel2.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrLabel2.Font = new System.Drawing.Font("Times New Roman", 12.0F, System.Drawing.FontStyle.Bold);
			this.XrLabel2.Location = new System.Drawing.Point(0, 100);
			this.XrLabel2.Multiline = true;
			this.XrLabel2.Name = "XrLabel2";
			this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel2.Size = new System.Drawing.Size(167, 50);
			this.XrLabel2.StylePriority.UseBorders = false;
			this.XrLabel2.StylePriority.UseFont = false;
			this.XrLabel2.StylePriority.UseTextAlignment = false;
			this.XrLabel2.Text = "Raw Material Component Numbers";
			this.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//XrPanel1
			//
			this.XrPanel1.BackColor = System.Drawing.Color.Black;
			this.XrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.itemDescriptionXrLabel, this.itemCodeXrLabel, this.XrLabel1});
			this.XrPanel1.Location = new System.Drawing.Point(0, 0);
			this.XrPanel1.Name = "XrPanel1";
			this.XrPanel1.Size = new System.Drawing.Size(650, 100);
			this.XrPanel1.StylePriority.UseBackColor = false;
			//
			//itemDescriptionXrLabel
			//
			this.itemDescriptionXrLabel.Font = new System.Drawing.Font("Times New Roman", 14.0F);
			this.itemDescriptionXrLabel.ForeColor = System.Drawing.Color.White;
			this.itemDescriptionXrLabel.Location = new System.Drawing.Point(0, 67);
			this.itemDescriptionXrLabel.Name = "itemDescriptionXrLabel";
			this.itemDescriptionXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemDescriptionXrLabel.Size = new System.Drawing.Size(650, 33);
			this.itemDescriptionXrLabel.StylePriority.UseFont = false;
			this.itemDescriptionXrLabel.StylePriority.UseForeColor = false;
			this.itemDescriptionXrLabel.StylePriority.UseTextAlignment = false;
			this.itemDescriptionXrLabel.Text = "itemDescriptionXrLabel";
			this.itemDescriptionXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemCodeXrLabel
			//
			this.itemCodeXrLabel.Font = new System.Drawing.Font("Times New Roman", 18.0F);
			this.itemCodeXrLabel.ForeColor = System.Drawing.Color.White;
			this.itemCodeXrLabel.Location = new System.Drawing.Point(0, 33);
			this.itemCodeXrLabel.Name = "itemCodeXrLabel";
			this.itemCodeXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemCodeXrLabel.Size = new System.Drawing.Size(650, 33);
			this.itemCodeXrLabel.StylePriority.UseFont = false;
			this.itemCodeXrLabel.StylePriority.UseForeColor = false;
			this.itemCodeXrLabel.StylePriority.UseTextAlignment = false;
			this.itemCodeXrLabel.Text = "itemCodeXrLabel";
			this.itemCodeXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//XrLabel1
			//
			this.XrLabel1.Font = new System.Drawing.Font("Times New Roman", 18.0F, System.Drawing.FontStyle.Underline);
			this.XrLabel1.ForeColor = System.Drawing.Color.White;
			this.XrLabel1.Location = new System.Drawing.Point(0, 0);
			this.XrLabel1.Name = "XrLabel1";
			this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel1.Size = new System.Drawing.Size(650, 33);
			this.XrLabel1.StylePriority.UseFont = false;
			this.XrLabel1.StylePriority.UseForeColor = false;
			this.XrLabel1.StylePriority.UseTextAlignment = false;
			this.XrLabel1.Text = "Produt Specifications";
			this.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//ProductSpecificationsXtraReport
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail});
			this.Margins = new System.Drawing.Printing.Margins(90, 100, 100, 100);
			this.Version = "8.3";
			((System.ComponentModel.ISupportInitialize)this).EndInit();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			itemBomsXrLabel.BeforePrint += new System.Drawing.Printing.PrintEventHandler(itemBomsXrLabel_BeforePrint);
		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.XRPanel XrPanel1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
		internal DevExpress.XtraReports.UI.XRLabel itemDescriptionXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemCodeXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemBomsXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel requiredWeightXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel3;
		internal DevExpress.XtraReports.UI.XRLabel unitsPerCaseXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel5;
		internal DevExpress.XtraReports.UI.XRLabel mavXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel4;
		internal DevExpress.XtraReports.UI.XRLabel layersPerPalletXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel8;
		internal DevExpress.XtraReports.UI.XRLabel casesPerLayerXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel7;
		internal DevExpress.XtraReports.UI.XRLabel casesPerPalletXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel6;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel10;
		internal DevExpress.XtraReports.UI.XRLabel packageCodeXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel9;
		internal DevExpress.XtraReports.UI.XRPanel XrPanel2;
		internal DevExpress.XtraReports.UI.XRPanel XrPanel3;
		internal DevExpress.XtraReports.UI.XRLabel shelfLifeXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel11;
		internal DevExpress.XtraReports.UI.XRLabel caseCodeXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel12;
		internal DevExpress.XtraReports.UI.XRPictureBox palletPaternXrPictureBox;
		internal DevExpress.XtraReports.UI.XRLabel specialInstructionsXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel13;
	}

}