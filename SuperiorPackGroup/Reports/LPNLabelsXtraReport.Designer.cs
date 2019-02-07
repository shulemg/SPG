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
	public partial class LPNLabelsXtraReport : DevExpress.XtraReports.UI.XtraReport
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
			DevExpress.XtraPrinting.BarCode.Code128Generator Code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
			DevExpress.XtraReports.UI.XRSummary XrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.exprXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.lotXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.qtyXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.exprHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.lotHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.qtyHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemDescXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemCodeXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.tsXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.lpnHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.LPNXrBarCode = new DevExpress.XtraReports.UI.XRBarCode();
			this.ReprintXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.lpnGroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.AllergensXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.lpnGroupFooter = new DevExpress.XtraReports.UI.GroupFooterBand();
			this.XrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.SumQtyXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			((System.ComponentModel.ISupportInitialize)this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.exprXrLabel, this.lotXrLabel, this.qtyXrLabel});
			this.Detail.HeightF = 25.08342F;
			this.Detail.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.Detail.StylePriority.UseTextAlignment = false;
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//exprXrLabel
			//
			this.exprXrLabel.BorderColor = System.Drawing.Color.Gray;
			this.exprXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.exprXrLabel.CanGrow = false;
			this.exprXrLabel.Font = new System.Drawing.Font("Tahoma", 14.0F, System.Drawing.FontStyle.Bold);
			this.exprXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(550.0001F, 0F);
			this.exprXrLabel.Name = "exprXrLabel";
			this.exprXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.exprXrLabel.SizeF = new System.Drawing.SizeF(202.0832F, 25.08342F);
			this.exprXrLabel.StylePriority.UseBorderColor = false;
			this.exprXrLabel.StylePriority.UseBorders = false;
			this.exprXrLabel.StylePriority.UseFont = false;
			this.exprXrLabel.Text = "12/31/2022";
			//
			//lotXrLabel
			//
			this.lotXrLabel.BorderColor = System.Drawing.Color.Gray;
			this.lotXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.lotXrLabel.CanGrow = false;
			this.lotXrLabel.Font = new System.Drawing.Font("Tahoma", 14.0F, System.Drawing.FontStyle.Bold);
			this.lotXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(201.0418F, 0F);
			this.lotXrLabel.Name = "lotXrLabel";
			this.lotXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.lotXrLabel.SizeF = new System.Drawing.SizeF(348.9583F, 25.08342F);
			this.lotXrLabel.StylePriority.UseBorderColor = false;
			this.lotXrLabel.StylePriority.UseBorders = false;
			this.lotXrLabel.StylePriority.UseFont = false;
			this.lotXrLabel.Text = "SP283782053 SP254 20";
			//
			//qtyXrLabel
			//
			this.qtyXrLabel.BorderColor = System.Drawing.Color.Gray;
			this.qtyXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.qtyXrLabel.CanGrow = false;
			this.qtyXrLabel.Font = new System.Drawing.Font("Tahoma", 14.0F, System.Drawing.FontStyle.Bold);
			this.qtyXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(47.91663F, 0F);
			this.qtyXrLabel.Name = "qtyXrLabel";
			this.qtyXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.qtyXrLabel.SizeF = new System.Drawing.SizeF(153.1252F, 25.08342F);
			this.qtyXrLabel.StylePriority.UseBorderColor = false;
			this.qtyXrLabel.StylePriority.UseBorders = false;
			this.qtyXrLabel.StylePriority.UseFont = false;
			this.qtyXrLabel.Text = "80";
			//
			//exprHeaderXrLabel
			//
			this.exprHeaderXrLabel.BorderColor = System.Drawing.Color.Black;
			this.exprHeaderXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.Top;
			this.exprHeaderXrLabel.CanGrow = false;
			this.exprHeaderXrLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
			this.exprHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(550.0F, 167.9583F);
			this.exprHeaderXrLabel.Name = "exprHeaderXrLabel";
			this.exprHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.exprHeaderXrLabel.SizeF = new System.Drawing.SizeF(202.0832F, 25.08342F);
			this.exprHeaderXrLabel.StylePriority.UseBorderColor = false;
			this.exprHeaderXrLabel.StylePriority.UseBorders = false;
			this.exprHeaderXrLabel.StylePriority.UseFont = false;
			this.exprHeaderXrLabel.StylePriority.UseTextAlignment = false;
			this.exprHeaderXrLabel.Text = "Expiration Date";
			this.exprHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//lotHeaderXrLabel
			//
			this.lotHeaderXrLabel.BorderColor = System.Drawing.Color.Black;
			this.lotHeaderXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.Top;
			this.lotHeaderXrLabel.CanGrow = false;
			this.lotHeaderXrLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
			this.lotHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(201.0417F, 167.9583F);
			this.lotHeaderXrLabel.Name = "lotHeaderXrLabel";
			this.lotHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.lotHeaderXrLabel.SizeF = new System.Drawing.SizeF(348.9583F, 25.08342F);
			this.lotHeaderXrLabel.StylePriority.UseBorderColor = false;
			this.lotHeaderXrLabel.StylePriority.UseBorders = false;
			this.lotHeaderXrLabel.StylePriority.UseFont = false;
			this.lotHeaderXrLabel.StylePriority.UseTextAlignment = false;
			this.lotHeaderXrLabel.Text = "Lot#";
			this.lotHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//qtyHeaderXrLabel
			//
			this.qtyHeaderXrLabel.BorderColor = System.Drawing.Color.Black;
			this.qtyHeaderXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.Top;
			this.qtyHeaderXrLabel.CanGrow = false;
			this.qtyHeaderXrLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
			this.qtyHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(47.91667F, 167.9583F);
			this.qtyHeaderXrLabel.Name = "qtyHeaderXrLabel";
			this.qtyHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.qtyHeaderXrLabel.SizeF = new System.Drawing.SizeF(153.1252F, 25.0834F);
			this.qtyHeaderXrLabel.StylePriority.UseBorderColor = false;
			this.qtyHeaderXrLabel.StylePriority.UseBorders = false;
			this.qtyHeaderXrLabel.StylePriority.UseFont = false;
			this.qtyHeaderXrLabel.StylePriority.UseTextAlignment = false;
			this.qtyHeaderXrLabel.Text = "Quantity";
			this.qtyHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//itemDescXrLabel
			//
			this.itemDescXrLabel.BorderColor = System.Drawing.Color.DarkGray;
			this.itemDescXrLabel.Borders = (DevExpress.XtraPrinting.BorderSide)(DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top);
			this.itemDescXrLabel.CanGrow = false;
			this.itemDescXrLabel.Font = new System.Drawing.Font("Tahoma", 12.0F, System.Drawing.FontStyle.Bold);
			this.itemDescXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(307.2917F, 118.375F);
			this.itemDescXrLabel.Name = "itemDescXrLabel";
			this.itemDescXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemDescXrLabel.SizeF = new System.Drawing.SizeF(444.7916F, 49.58331F);
			this.itemDescXrLabel.StylePriority.UseBorderColor = false;
			this.itemDescXrLabel.StylePriority.UseBorders = false;
			this.itemDescXrLabel.StylePriority.UseFont = false;
			this.itemDescXrLabel.Text = "TUXEDO MILK CHOCOLATE ALMONDS 48/35 OZ. BOXES";
			//
			//itemCodeXrLabel
			//
			this.itemCodeXrLabel.BorderColor = System.Drawing.Color.Gray;
			this.itemCodeXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.itemCodeXrLabel.CanGrow = false;
			this.itemCodeXrLabel.Font = new System.Drawing.Font("Tahoma", 14.0F, System.Drawing.FontStyle.Bold);
			this.itemCodeXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(47.91663F, 143.1667F);
			this.itemCodeXrLabel.Name = "itemCodeXrLabel";
			this.itemCodeXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemCodeXrLabel.SizeF = new System.Drawing.SizeF(259.3751F, 24.79165F);
			this.itemCodeXrLabel.StylePriority.UseBorderColor = false;
			this.itemCodeXrLabel.StylePriority.UseBorders = false;
			this.itemCodeXrLabel.StylePriority.UseFont = false;
			this.itemCodeXrLabel.Text = "1234567890123456";
			//
			//itemHeaderXrLabel
			//
			this.itemHeaderXrLabel.BorderColor = System.Drawing.Color.Gray;
			this.itemHeaderXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.Top;
			this.itemHeaderXrLabel.CanGrow = false;
			this.itemHeaderXrLabel.Font = new System.Drawing.Font("Calibri", 10.0F, System.Drawing.FontStyle.Bold);
			this.itemHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(47.91663F, 118.375F);
			this.itemHeaderXrLabel.Name = "itemHeaderXrLabel";
			this.itemHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemHeaderXrLabel.SizeF = new System.Drawing.SizeF(259.3751F, 24.79166F);
			this.itemHeaderXrLabel.StylePriority.UseBorderColor = false;
			this.itemHeaderXrLabel.StylePriority.UseBorders = false;
			this.itemHeaderXrLabel.StylePriority.UseFont = false;
			this.itemHeaderXrLabel.StylePriority.UseTextAlignment = false;
			this.itemHeaderXrLabel.Text = "Item Number - Description";
			this.itemHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//tsXrLabel
			//
			this.tsXrLabel.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Now()")});
			this.tsXrLabel.Font = new System.Drawing.Font("Tahoma", 9.0F);
			this.tsXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(453.1251F, 18.41682F);
			this.tsXrLabel.Name = "tsXrLabel";
			this.tsXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.tsXrLabel.SizeF = new System.Drawing.SizeF(300.0F, 23.74994F);
			this.tsXrLabel.StylePriority.UseFont = false;
			this.tsXrLabel.StylePriority.UseTextAlignment = false;
			this.tsXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//lpnHeaderXrLabel
			//
			this.lpnHeaderXrLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
			this.lpnHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(298.9583F, 0F);
			this.lpnHeaderXrLabel.Name = "lpnHeaderXrLabel";
			this.lpnHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.lpnHeaderXrLabel.SizeF = new System.Drawing.SizeF(203.125F, 13.0F);
			this.lpnHeaderXrLabel.StylePriority.UseFont = false;
			this.lpnHeaderXrLabel.Text = "LICENSE PLATE NUMBER";
			//
			//LPNXrBarCode
			//
			this.LPNXrBarCode.AnchorHorizontal = (DevExpress.XtraReports.UI.HorizontalAnchorStyles)(DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right);
			this.LPNXrBarCode.Font = new System.Drawing.Font("Tahoma", 18.0F, System.Drawing.FontStyle.Bold);
			this.LPNXrBarCode.LocationFloat = new DevExpress.Utils.PointFloat(300.0001F, 13.00001F);
			this.LPNXrBarCode.Name = "LPNXrBarCode";
			this.LPNXrBarCode.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 2, 100.0F);
			this.LPNXrBarCode.SizeF = new System.Drawing.SizeF(453.125F, 105.375F);
			this.LPNXrBarCode.StylePriority.UseFont = false;
			this.LPNXrBarCode.StylePriority.UsePadding = false;
			this.LPNXrBarCode.StylePriority.UseTextAlignment = false;
			this.LPNXrBarCode.Symbology = Code128Generator1;
			this.LPNXrBarCode.Text = "PIM480252";
			this.LPNXrBarCode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//ReprintXrLabel
			//
			this.ReprintXrLabel.AnchorHorizontal = (DevExpress.XtraReports.UI.HorizontalAnchorStyles)(DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left | DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right);
			this.ReprintXrLabel.AnchorVertical = (DevExpress.XtraReports.UI.VerticalAnchorStyles)(DevExpress.XtraReports.UI.VerticalAnchorStyles.Top | DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom);
			this.ReprintXrLabel.Angle = 10.0F;
			this.ReprintXrLabel.CanGrow = false;
			this.ReprintXrLabel.Font = new System.Drawing.Font("Calibri", 48.0F, System.Drawing.FontStyle.Bold);
			this.ReprintXrLabel.ForeColor = System.Drawing.Color.Red;
			this.ReprintXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0.00006357829F, 0F);
			this.ReprintXrLabel.Name = "ReprintXrLabel";
			this.ReprintXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.ReprintXrLabel.SizeF = new System.Drawing.SizeF(288.5417F, 92.33337F);
			this.ReprintXrLabel.StylePriority.UseFont = false;
			this.ReprintXrLabel.StylePriority.UseForeColor = false;
			this.ReprintXrLabel.StylePriority.UseTextAlignment = false;
			this.ReprintXrLabel.Text = "Reprint";
			this.ReprintXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
			//
			//TopMargin
			//
			this.TopMargin.BorderColor = System.Drawing.Color.Transparent;
			this.TopMargin.HeightF = 0F;
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.TopMargin.StylePriority.UseBorderColor = false;
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			this.TopMargin.Visible = false;
			//
			//BottomMargin
			//
			this.BottomMargin.HeightF = 1.0F;
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			this.BottomMargin.Visible = false;
			//
			//lpnGroupHeader
			//
			this.lpnGroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.exprHeaderXrLabel, this.lotHeaderXrLabel, this.qtyHeaderXrLabel, this.itemDescXrLabel, this.itemHeaderXrLabel, this.itemCodeXrLabel, this.LPNXrBarCode, this.lpnHeaderXrLabel, this.ReprintXrLabel});
			this.lpnGroupHeader.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WholePage;
			this.lpnGroupHeader.HeightF = 193.1667F;
			this.lpnGroupHeader.Name = "lpnGroupHeader";
			this.lpnGroupHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.lpnGroupHeader.StylePriority.UsePadding = false;
			//
			//AllergensXrLabel
			//
			this.AllergensXrLabel.BorderColor = System.Drawing.Color.Gray;
			this.AllergensXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.AllergensXrLabel.CanGrow = false;
			this.AllergensXrLabel.Font = new System.Drawing.Font("Tahoma", 10.0F, System.Drawing.FontStyle.Bold);
			this.AllergensXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(47.91641F, 51.25001F);
			this.AllergensXrLabel.Name = "AllergensXrLabel";
			this.AllergensXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.AllergensXrLabel.SizeF = new System.Drawing.SizeF(704.1667F, 24.79164F);
			this.AllergensXrLabel.StylePriority.UseBorderColor = false;
			this.AllergensXrLabel.StylePriority.UseBorders = false;
			this.AllergensXrLabel.StylePriority.UseFont = false;
			this.AllergensXrLabel.StylePriority.UseTextAlignment = false;
			this.AllergensXrLabel.Text = "Allergens: Milk, Soy, etc";
			this.AllergensXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//lpnGroupFooter
			//
			this.lpnGroupFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.AllergensXrLabel, this.XrLabel2, this.SumQtyXrLabel, this.tsXrLabel});
			this.lpnGroupFooter.HeightF = 87.5F;
			this.lpnGroupFooter.KeepTogether = true;
			this.lpnGroupFooter.Name = "lpnGroupFooter";
			this.lpnGroupFooter.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
			this.lpnGroupFooter.PrintAtBottom = true;
			//
			//XrLabel2
			//
			this.XrLabel2.BorderColor = System.Drawing.Color.Gray;
			this.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.XrLabel2.CanGrow = false;
			this.XrLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
			this.XrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(47.91663F, 2.083333F);
			this.XrLabel2.Name = "XrLabel2";
			this.XrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel2.SizeF = new System.Drawing.SizeF(153.1252F, 15.0F);
			this.XrLabel2.StylePriority.UseBorderColor = false;
			this.XrLabel2.StylePriority.UseBorders = false;
			this.XrLabel2.StylePriority.UseFont = false;
			this.XrLabel2.StylePriority.UseTextAlignment = false;
			this.XrLabel2.Text = "Total Quantity";
			this.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//SumQtyXrLabel
			//
			this.SumQtyXrLabel.BorderColor = System.Drawing.Color.Gray;
			this.SumQtyXrLabel.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.SumQtyXrLabel.CanGrow = false;
			this.SumQtyXrLabel.Font = new System.Drawing.Font("Tahoma", 14.0F, System.Drawing.FontStyle.Bold);
			this.SumQtyXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(47.91662F, 17.08333F);
			this.SumQtyXrLabel.Name = "SumQtyXrLabel";
			this.SumQtyXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.SumQtyXrLabel.SizeF = new System.Drawing.SizeF(153.1252F, 25.08342F);
			this.SumQtyXrLabel.StylePriority.UseBorderColor = false;
			this.SumQtyXrLabel.StylePriority.UseBorders = false;
			this.SumQtyXrLabel.StylePriority.UseFont = false;
			XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
			this.SumQtyXrLabel.Summary = XrSummary1;
			this.SumQtyXrLabel.Text = "80";
			//
			//LPNLabelsXtraReport
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.TopMargin, this.BottomMargin, this.lpnGroupHeader, this.lpnGroupFooter});
			this.BorderColor = System.Drawing.Color.Transparent;
			this.Font = new System.Drawing.Font("Tw Cen MT Condensed", 72.0F);
			this.HorizontalContentSplitting = DevExpress.XtraPrinting.HorizontalContentSplitting.Smart;
			this.Landscape = true;
			this.Margins = new System.Drawing.Printing.Margins(0, 0, 0, 1);
			this.PageHeight = 400;
			this.PageWidth = 800;
			this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
			this.Version = "17.2";
			((System.ComponentModel.ISupportInitialize)this).EndInit();

		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMargin;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
		internal DevExpress.XtraReports.UI.XRLabel exprHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel exprXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel lotHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel lotXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel qtyHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel qtyXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemDescXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemCodeXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel lpnHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRBarCode LPNXrBarCode;
		internal DevExpress.XtraReports.UI.XRLabel tsXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel ReprintXrLabel;
		internal DevExpress.XtraReports.UI.GroupHeaderBand lpnGroupHeader;
		internal DevExpress.XtraReports.UI.GroupFooterBand lpnGroupFooter;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel2;
		internal DevExpress.XtraReports.UI.XRLabel SumQtyXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel AllergensXrLabel;
	}

}