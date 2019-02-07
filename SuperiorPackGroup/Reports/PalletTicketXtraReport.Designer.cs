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
	public partial class PalletTicketXtraReport : DevExpress.XtraReports.UI.XtraReport
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
			this.palletXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.shiftXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.dateXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.casesPerPalletXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.lotCodeXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.itemTypeXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemDescriptionXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
			this.itemXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.XrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.customerXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
			this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
			this.TopMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
			((System.ComponentModel.ISupportInitialize)this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.palletXrLabel, this.shiftXrLabel, this.dateXrLabel, this.XrLabel8, this.XrLabel7, this.XrLabel6, this.casesPerPalletXrLabel, this.XrLabel5, this.lotCodeXrLabel, this.XrLabel3, this.itemTypeXrLabel, this.itemDescriptionXrLabel, this.XrPanel1, this.customerXrLabel});
			this.Detail.Font = new System.Drawing.Font("Times New Roman", 12F);
			this.Detail.HeightF = 800.7916F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.Detail.StylePriority.UseFont = false;
			this.Detail.StylePriority.UseTextAlignment = false;
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//palletXrLabel
			//
			this.palletXrLabel.Font = new System.Drawing.Font("Times New Roman", 24F);
			this.palletXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(433F, 707F);
			this.palletXrLabel.Name = "palletXrLabel";
			this.palletXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.palletXrLabel.SizeF = new System.Drawing.SizeF(217F, 93F);
			this.palletXrLabel.StylePriority.UseFont = false;
			this.palletXrLabel.Visible = false;
			//
			//shiftXrLabel
			//
			this.shiftXrLabel.Font = new System.Drawing.Font("Times New Roman", 24F);
			this.shiftXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(217F, 707F);
			this.shiftXrLabel.Name = "shiftXrLabel";
			this.shiftXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.shiftXrLabel.SizeF = new System.Drawing.SizeF(217F, 93F);
			this.shiftXrLabel.StylePriority.UseFont = false;
			this.shiftXrLabel.Visible = false;
			//
			//dateXrLabel
			//
			this.dateXrLabel.CanGrow = false;
			this.dateXrLabel.Font = new System.Drawing.Font("Times New Roman", 24F);
			this.dateXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 707F);
			this.dateXrLabel.Multiline = true;
			this.dateXrLabel.Name = "dateXrLabel";
			this.dateXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.dateXrLabel.SizeF = new System.Drawing.SizeF(217F, 93F);
			this.dateXrLabel.StylePriority.UseFont = false;
			this.dateXrLabel.Visible = false;
			//
			//XrLabel8
			//
			this.XrLabel8.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrLabel8.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
			this.XrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(433F, 675F);
			this.XrLabel8.Name = "XrLabel8";
			this.XrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.XrLabel8.SizeF = new System.Drawing.SizeF(217F, 125F);
			this.XrLabel8.StylePriority.UseBorders = false;
			this.XrLabel8.StylePriority.UseFont = false;
			this.XrLabel8.StylePriority.UseTextAlignment = false;
			this.XrLabel8.Text = "PALLET:";
			this.XrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel7
			//
			this.XrLabel7.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrLabel7.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
			this.XrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(217F, 675F);
			this.XrLabel7.Name = "XrLabel7";
			this.XrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.XrLabel7.SizeF = new System.Drawing.SizeF(217F, 125F);
			this.XrLabel7.StylePriority.UseBorders = false;
			this.XrLabel7.StylePriority.UseFont = false;
			this.XrLabel7.StylePriority.UseTextAlignment = false;
			this.XrLabel7.Text = "SHIFT:";
			this.XrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//XrLabel6
			//
			this.XrLabel6.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrLabel6.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
			this.XrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 675F);
			this.XrLabel6.Name = "XrLabel6";
			this.XrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.XrLabel6.SizeF = new System.Drawing.SizeF(217F, 125F);
			this.XrLabel6.StylePriority.UseBorders = false;
			this.XrLabel6.StylePriority.UseFont = false;
			this.XrLabel6.StylePriority.UseTextAlignment = false;
			this.XrLabel6.Text = "DATE:";
			this.XrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//casesPerPalletXrLabel
			//
			this.casesPerPalletXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.casesPerPalletXrLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
			this.casesPerPalletXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(433F, 550F);
			this.casesPerPalletXrLabel.Name = "casesPerPalletXrLabel";
			this.casesPerPalletXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.casesPerPalletXrLabel.SizeF = new System.Drawing.SizeF(217F, 125F);
			this.casesPerPalletXrLabel.StylePriority.UseBorders = false;
			this.casesPerPalletXrLabel.StylePriority.UseFont = false;
			this.casesPerPalletXrLabel.Text = "casesPerPalletXrLabel";
			//
			//XrLabel5
			//
			this.XrLabel5.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrLabel5.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold);
			this.XrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 550F);
			this.XrLabel5.Name = "XrLabel5";
			this.XrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.XrLabel5.SizeF = new System.Drawing.SizeF(433F, 125F);
			this.XrLabel5.StylePriority.UseBorders = false;
			this.XrLabel5.StylePriority.UseFont = false;
			this.XrLabel5.Text = "CASES PER PALLET:";
			//
			//lotCodeXrLabel
			//
			this.lotCodeXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.lotCodeXrLabel.Font = new System.Drawing.Font("Times New Roman", 24F);
			this.lotCodeXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(250F, 425F);
			this.lotCodeXrLabel.Name = "lotCodeXrLabel";
			this.lotCodeXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.lotCodeXrLabel.SizeF = new System.Drawing.SizeF(400F, 125F);
			this.lotCodeXrLabel.StylePriority.UseBorders = false;
			this.lotCodeXrLabel.StylePriority.UseFont = false;
			//
			//XrLabel3
			//
			this.XrLabel3.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrLabel3.Font = new System.Drawing.Font("Times New Roman", 28F, System.Drawing.FontStyle.Bold);
			this.XrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 425F);
			this.XrLabel3.Name = "XrLabel3";
			this.XrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.XrLabel3.SizeF = new System.Drawing.SizeF(250F, 125F);
			this.XrLabel3.StylePriority.UseBorders = false;
			this.XrLabel3.StylePriority.UseFont = false;
			this.XrLabel3.Text = "CODE:";
			//
			//itemTypeXrLabel
			//
			this.itemTypeXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.itemTypeXrLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold);
			this.itemTypeXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 350F);
			this.itemTypeXrLabel.Name = "itemTypeXrLabel";
			this.itemTypeXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.itemTypeXrLabel.SizeF = new System.Drawing.SizeF(650F, 75F);
			this.itemTypeXrLabel.StylePriority.UseBorders = false;
			this.itemTypeXrLabel.StylePriority.UseFont = false;
			this.itemTypeXrLabel.Text = "itemTypeXrLabel";
			//
			//itemDescriptionXrLabel
			//
			this.itemDescriptionXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.itemDescriptionXrLabel.Font = new System.Drawing.Font("Times New Roman", 20F);
			this.itemDescriptionXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 225F);
			this.itemDescriptionXrLabel.Name = "itemDescriptionXrLabel";
			this.itemDescriptionXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.itemDescriptionXrLabel.SizeF = new System.Drawing.SizeF(650F, 125F);
			this.itemDescriptionXrLabel.StylePriority.UseBorders = false;
			this.itemDescriptionXrLabel.StylePriority.UseFont = false;
			this.itemDescriptionXrLabel.Text = "itemDescriptionXrLabel";
			//
			//XrPanel1
			//
			this.XrPanel1.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.XrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.itemXrLabel, this.XrLabel2});
			this.XrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 100F);
			this.XrPanel1.Name = "XrPanel1";
			this.XrPanel1.SizeF = new System.Drawing.SizeF(650F, 125F);
			this.XrPanel1.StylePriority.UseBorders = false;
			//
			//itemXrLabel
			//
			this.itemXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.itemXrLabel.Font = new System.Drawing.Font("Times New Roman", 36.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.itemXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0.0F, 50.0F);
			this.itemXrLabel.Name = "itemXrLabel";
			this.itemXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemXrLabel.SizeF = new System.Drawing.SizeF(650.0F, 75.0F);
			this.itemXrLabel.StylePriority.UseBorders = false;
			this.itemXrLabel.StylePriority.UseFont = false;
			this.itemXrLabel.Text = "itemXrLabel";
			//
			//XrLabel2
			//
			this.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.XrLabel2.Font = new System.Drawing.Font("Times New Roman", 20.0F, System.Drawing.FontStyle.Bold);
			this.XrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0.0F, 0.0F);
			this.XrLabel2.Name = "XrLabel2";
			this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel2.SizeF = new System.Drawing.SizeF(650.0F, 50.0F);
			this.XrLabel2.StylePriority.UseBorders = false;
			this.XrLabel2.StylePriority.UseFont = false;
			this.XrLabel2.Text = "Product #";
			//
			//customerXrLabel
			//
			this.customerXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.customerXrLabel.Font = new System.Drawing.Font("Times New Roman", 36.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (byte)0);
			this.customerXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.customerXrLabel.Name = "customerXrLabel";
			this.customerXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.customerXrLabel.SizeF = new System.Drawing.SizeF(650F, 100F);
			this.customerXrLabel.StylePriority.UseBorders = false;
			this.customerXrLabel.StylePriority.UseFont = false;
			this.customerXrLabel.Text = "customerXrLabel";
			//
			//PageHeader
			//
			this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.XrLabel1});
			this.PageHeader.HeightF = 50F;
			this.PageHeader.Name = "PageHeader";
			this.PageHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//XrLabel1
			//
			this.XrLabel1.Font = new System.Drawing.Font("Times New Roman", 24F);
			this.XrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.XrLabel1.Name = "XrLabel1";
			this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.XrLabel1.SizeF = new System.Drawing.SizeF(650F, 50F);
			this.XrLabel1.StylePriority.UseFont = false;
			this.XrLabel1.StylePriority.UseTextAlignment = false;
			this.XrLabel1.Text = "Pallet Ticket";
			this.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//PageFooter
			//
			this.PageFooter.HeightF = 30F;
			this.PageFooter.Name = "PageFooter";
			this.PageFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//TopMarginBand1
			//
			this.TopMarginBand1.Name = "TopMarginBand1";
			//
			//BottomMarginBand1
			//
			this.BottomMarginBand1.Name = "BottomMarginBand1";
			//
			//PalletTicketXtraReport
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.PageHeader, this.PageFooter, this.TopMarginBand1, this.BottomMarginBand1});
			this.Margins = new System.Drawing.Printing.Margins(90, 100, 100, 100);
			this.Version = "11.2";
			((System.ComponentModel.ISupportInitialize)this).EndInit();

	}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
		internal DevExpress.XtraReports.UI.PageFooterBand PageFooter;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
		internal DevExpress.XtraReports.UI.XRPanel XrPanel1;
		internal DevExpress.XtraReports.UI.XRLabel customerXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemTypeXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemDescriptionXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
		internal DevExpress.XtraReports.UI.XRLabel casesPerPalletXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel5;
		internal DevExpress.XtraReports.UI.XRLabel lotCodeXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel3;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel8;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel7;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel6;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMarginBand1;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMarginBand1;
		internal DevExpress.XtraReports.UI.XRLabel palletXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel shiftXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel dateXrLabel;
	}

}