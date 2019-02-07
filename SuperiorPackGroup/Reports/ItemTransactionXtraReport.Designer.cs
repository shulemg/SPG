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
	public partial class ItemTransactionXtraReport : DevExpress.XtraReports.UI.XtraReport
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
			DevExpress.XtraReports.UI.XRSummary XrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary4 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary5 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary6 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary7 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary8 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary9 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary10 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary11 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary12 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary13 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary14 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary15 = new DevExpress.XtraReports.UI.XRSummary();
			DevExpress.XtraReports.UI.XRSummary XrSummary16 = new DevExpress.XtraReports.UI.XRSummary();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.balacneDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.quantityDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.transactionTypeDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemDescriptionDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemCodeDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.transactionDateDetailXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
			this.printDateXrPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
			this.reportCriteriaXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.reportTitleXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
			this.pageNumberXrPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
			this.itemGroupHeader = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.openingBalanceXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.openingBalanceParameter = new DevExpress.XtraReports.Parameters.Parameter();
			this.XrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.headerXrPanel = new DevExpress.XtraReports.UI.XRPanel();
			this.quantityHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.tranasctionTypeHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemDescriptionHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.itemCodeHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.balanceHeadeerXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.transactionDateHeaderXrLabel = new DevExpress.XtraReports.UI.XRLabel();
			this.headerXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.footerXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.detailOddXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.detailEvenXrControlStyle = new DevExpress.XtraReports.UI.XRControlStyle();
			this.TopMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.itemTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)this.itemTransactionsBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.balacneDetailXrLabel, this.quantityDetailXrLabel, this.transactionTypeDetailXrLabel, this.itemDescriptionDetailXrLabel, this.itemCodeDetailXrLabel, this.transactionDateDetailXrLabel});
			this.Detail.EvenStyleName = "detailOddXrControlStyle";
			this.Detail.HeightF = 30.0F;
			this.Detail.Name = "Detail";
			this.Detail.OddStyleName = "detailEvenXrControlStyle";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.None;
			this.Detail.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {new DevExpress.XtraReports.UI.GroupField("TransactionDate", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//balacneDetailXrLabel
			//
			this.balacneDetailXrLabel.CanGrow = false;
			this.balacneDetailXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "Quantity")});
			this.balacneDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.balacneDetailXrLabel.Font = new System.Drawing.Font("Tahoma", 8.75F);
			this.balacneDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(692.0F, 0.0F);
			this.balacneDetailXrLabel.Name = "balacneDetailXrLabel";
			this.balacneDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.balacneDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.balacneDetailXrLabel.SizeF = new System.Drawing.SizeF(106.0F, 30.0F);
			this.balacneDetailXrLabel.StylePriority.UseFont = false;
			XrSummary1.FormatString = "{0:#.00}";
			XrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RunningSum;
			XrSummary1.IgnoreNullValues = true;
			XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
			this.balacneDetailXrLabel.Summary = XrSummary1;
			this.balacneDetailXrLabel.Text = "balacneDetailXrLabel";
			this.balacneDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//quantityDetailXrLabel
			//
			this.quantityDetailXrLabel.CanGrow = false;
			this.quantityDetailXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "Quantity")});
			this.quantityDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.quantityDetailXrLabel.Font = new System.Drawing.Font("Tahoma", 8.75F);
			this.quantityDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(591.0F, 0.0F);
			this.quantityDetailXrLabel.Name = "quantityDetailXrLabel";
			this.quantityDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.quantityDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.quantityDetailXrLabel.SizeF = new System.Drawing.SizeF(101.0F, 30.0F);
			this.quantityDetailXrLabel.StylePriority.UseFont = false;
			XrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum;
			XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.None;
			this.quantityDetailXrLabel.Summary = XrSummary2;
			this.quantityDetailXrLabel.Text = "quantityDetailXrLabel";
			this.quantityDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//transactionTypeDetailXrLabel
			//
			this.transactionTypeDetailXrLabel.CanGrow = false;
			this.transactionTypeDetailXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "TransactionType")});
			this.transactionTypeDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.transactionTypeDetailXrLabel.Font = new System.Drawing.Font("Tahoma", 8.75F);
			this.transactionTypeDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(483.0F, 0.0F);
			this.transactionTypeDetailXrLabel.Name = "transactionTypeDetailXrLabel";
			this.transactionTypeDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.transactionTypeDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.transactionTypeDetailXrLabel.SizeF = new System.Drawing.SizeF(108.0F, 30.0F);
			this.transactionTypeDetailXrLabel.StylePriority.UseFont = false;
			this.transactionTypeDetailXrLabel.StylePriority.UseTextAlignment = false;
			XrSummary3.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum;
			XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.None;
			this.transactionTypeDetailXrLabel.Summary = XrSummary3;
			this.transactionTypeDetailXrLabel.Text = "transactionTypeDetailXrLabel";
			this.transactionTypeDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//itemDescriptionDetailXrLabel
			//
			this.itemDescriptionDetailXrLabel.CanGrow = false;
			this.itemDescriptionDetailXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "TransactionItemDescription")});
			this.itemDescriptionDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.itemDescriptionDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(275.0F, 0.0F);
			this.itemDescriptionDetailXrLabel.Name = "itemDescriptionDetailXrLabel";
			this.itemDescriptionDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.itemDescriptionDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemDescriptionDetailXrLabel.SizeF = new System.Drawing.SizeF(208.0F, 30.0F);
			XrSummary4.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum;
			XrSummary4.Running = DevExpress.XtraReports.UI.SummaryRunning.None;
			this.itemDescriptionDetailXrLabel.Summary = XrSummary4;
			this.itemDescriptionDetailXrLabel.Text = "itemDescriptionDetailXrLabel";
			this.itemDescriptionDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//itemCodeDetailXrLabel
			//
			this.itemCodeDetailXrLabel.CanGrow = false;
			this.itemCodeDetailXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "TransactionItemCode")});
			this.itemCodeDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.itemCodeDetailXrLabel.Font = new System.Drawing.Font("Tahoma", 8.75F);
			this.itemCodeDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(125.0F, 0.0F);
			this.itemCodeDetailXrLabel.Name = "itemCodeDetailXrLabel";
			this.itemCodeDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.itemCodeDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemCodeDetailXrLabel.SizeF = new System.Drawing.SizeF(150.0F, 30.0F);
			this.itemCodeDetailXrLabel.StylePriority.UseFont = false;
			XrSummary5.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum;
			XrSummary5.Running = DevExpress.XtraReports.UI.SummaryRunning.None;
			this.itemCodeDetailXrLabel.Summary = XrSummary5;
			this.itemCodeDetailXrLabel.Text = "itemCodeDetailXrLabel";
			this.itemCodeDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//transactionDateDetailXrLabel
			//
			this.transactionDateDetailXrLabel.CanGrow = false;
			this.transactionDateDetailXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding("Text", null, "TransactionDate", "{0:MM/dd/yyyy}")});
			this.transactionDateDetailXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.transactionDateDetailXrLabel.Font = new System.Drawing.Font("Tahoma", 8.75F);
			this.transactionDateDetailXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0.0F, 0.0F);
			this.transactionDateDetailXrLabel.Name = "transactionDateDetailXrLabel";
			this.transactionDateDetailXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.transactionDateDetailXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.transactionDateDetailXrLabel.SizeF = new System.Drawing.SizeF(125.0F, 30.0F);
			this.transactionDateDetailXrLabel.StylePriority.UseFont = false;
			XrSummary6.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum;
			XrSummary6.Running = DevExpress.XtraReports.UI.SummaryRunning.None;
			this.transactionDateDetailXrLabel.Summary = XrSummary6;
			this.transactionDateDetailXrLabel.Text = "transactionDateDetailXrLabel";
			this.transactionDateDetailXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//PageHeader
			//
			this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.printDateXrPageInfo, this.reportCriteriaXrLabel, this.reportTitleXrLabel});
			this.PageHeader.HeightF = 85.0F;
			this.PageHeader.Name = "PageHeader";
			this.PageHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.PageHeader.PageBreak = DevExpress.XtraReports.UI.PageBreak.None;
			this.PageHeader.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages;
			this.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//printDateXrPageInfo
			//
			this.printDateXrPageInfo.LocationFloat = new DevExpress.Utils.PointFloat(617.0F, 50.0F);
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
			this.reportCriteriaXrLabel.SizeF = new System.Drawing.SizeF(583.0F, 35.0F);
			XrSummary7.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum;
			XrSummary7.Running = DevExpress.XtraReports.UI.SummaryRunning.None;
			this.reportCriteriaXrLabel.Summary = XrSummary7;
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
			XrSummary8.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum;
			XrSummary8.Running = DevExpress.XtraReports.UI.SummaryRunning.None;
			this.reportTitleXrLabel.Summary = XrSummary8;
			this.reportTitleXrLabel.Text = "reportTitleXrLabel";
			this.reportTitleXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//PageFooter
			//
			this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.pageNumberXrPageInfo});
			this.PageFooter.HeightF = 30.0F;
			this.PageFooter.Name = "PageFooter";
			this.PageFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.PageFooter.PageBreak = DevExpress.XtraReports.UI.PageBreak.None;
			this.PageFooter.PrintOn = DevExpress.XtraReports.UI.PrintOnPages.AllPages;
			this.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//pageNumberXrPageInfo
			//
			this.pageNumberXrPageInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic);
			this.pageNumberXrPageInfo.Format = "Page:  {0} / {1}";
			this.pageNumberXrPageInfo.LocationFloat = new DevExpress.Utils.PointFloat(692.0F, 0.0F);
			this.pageNumberXrPageInfo.Name = "pageNumberXrPageInfo";
			this.pageNumberXrPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.pageNumberXrPageInfo.PageInfo = DevExpress.XtraPrinting.PageInfo.NumberOfTotal;
			this.pageNumberXrPageInfo.SizeF = new System.Drawing.SizeF(100.0F, 25.0F);
			this.pageNumberXrPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//itemGroupHeader
			//
			this.itemGroupHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.openingBalanceXrLabel, this.XrLabel1, this.headerXrPanel});
			this.itemGroupHeader.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.None;
			this.itemGroupHeader.HeightF = 83.0F;
			this.itemGroupHeader.Name = "itemGroupHeader";
			this.itemGroupHeader.PageBreak = DevExpress.XtraReports.UI.PageBreak.None;
			//
			//openingBalanceXrLabel
			//
			this.openingBalanceXrLabel.CanGrow = false;
			this.openingBalanceXrLabel.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {new DevExpress.XtraReports.UI.XRBinding(this.openingBalanceParameter, "Text", "{0:#.00}")});
			this.openingBalanceXrLabel.EvenStyleName = "detailEvenXrControlStyle";
			this.openingBalanceXrLabel.Font = new System.Drawing.Font("Tahoma", 9.75F);
			this.openingBalanceXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(692.0F, 50.0F);
			this.openingBalanceXrLabel.Name = "openingBalanceXrLabel";
			this.openingBalanceXrLabel.OddStyleName = "detailOddXrControlStyle";
			this.openingBalanceXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.openingBalanceXrLabel.SizeF = new System.Drawing.SizeF(106.0F, 30.0F);
			this.openingBalanceXrLabel.StylePriority.UseFont = false;
			XrSummary9.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum;
			XrSummary9.Running = DevExpress.XtraReports.UI.SummaryRunning.None;
			this.openingBalanceXrLabel.Summary = XrSummary9;
			this.openingBalanceXrLabel.Text = "openingBalanceXrLabel";
			this.openingBalanceXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			//
			//openingBalanceParameter
			//
			this.openingBalanceParameter.Name = "openingBalanceParameter";
			this.openingBalanceParameter.Type = typeof(double);
			this.openingBalanceParameter.Value = 0;
			//
			//XrLabel1
			//
			this.XrLabel1.CanGrow = false;
			this.XrLabel1.EvenStyleName = "detailEvenXrControlStyle";
			this.XrLabel1.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.XrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(275.0F, 50.0F);
			this.XrLabel1.Name = "XrLabel1";
			this.XrLabel1.OddStyleName = "detailOddXrControlStyle";
			this.XrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.XrLabel1.SizeF = new System.Drawing.SizeF(208.0F, 30.0F);
			this.XrLabel1.StylePriority.UseFont = false;
			XrSummary10.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum;
			XrSummary10.Running = DevExpress.XtraReports.UI.SummaryRunning.None;
			this.XrLabel1.Summary = XrSummary10;
			this.XrLabel1.Text = "Opening Balance";
			this.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			//
			//headerXrPanel
			//
			this.headerXrPanel.BorderColor = System.Drawing.Color.Black;
			this.headerXrPanel.Borders = (DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) | DevExpress.XtraPrinting.BorderSide.Right) | DevExpress.XtraPrinting.BorderSide.Bottom);
			this.headerXrPanel.BorderWidth = 3;
			this.headerXrPanel.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.quantityHeaderXrLabel, this.tranasctionTypeHeaderXrLabel, this.itemDescriptionHeaderXrLabel, this.itemCodeHeaderXrLabel, this.balanceHeadeerXrLabel, this.transactionDateHeaderXrLabel});
			this.headerXrPanel.LocationFloat = new DevExpress.Utils.PointFloat(0.0F, 0.0F);
			this.headerXrPanel.Name = "headerXrPanel";
			this.headerXrPanel.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.headerXrPanel.SizeF = new System.Drawing.SizeF(800.0F, 83.0F);
			//
			//quantityHeaderXrLabel
			//
			this.quantityHeaderXrLabel.CanGrow = false;
			this.quantityHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.quantityHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(591.0F, 0.0F);
			this.quantityHeaderXrLabel.Name = "quantityHeaderXrLabel";
			this.quantityHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.quantityHeaderXrLabel.SizeF = new System.Drawing.SizeF(101.0F, 50.0F);
			this.quantityHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.quantityHeaderXrLabel.StylePriority.UseFont = false;
			XrSummary11.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum;
			XrSummary11.Running = DevExpress.XtraReports.UI.SummaryRunning.None;
			this.quantityHeaderXrLabel.Summary = XrSummary11;
			this.quantityHeaderXrLabel.Text = "Quantity";
			this.quantityHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//tranasctionTypeHeaderXrLabel
			//
			this.tranasctionTypeHeaderXrLabel.CanGrow = false;
			this.tranasctionTypeHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.tranasctionTypeHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(483.0F, 0.0F);
			this.tranasctionTypeHeaderXrLabel.Name = "tranasctionTypeHeaderXrLabel";
			this.tranasctionTypeHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.tranasctionTypeHeaderXrLabel.SizeF = new System.Drawing.SizeF(108.0F, 50.0F);
			this.tranasctionTypeHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.tranasctionTypeHeaderXrLabel.StylePriority.UseFont = false;
			XrSummary12.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum;
			XrSummary12.Running = DevExpress.XtraReports.UI.SummaryRunning.None;
			this.tranasctionTypeHeaderXrLabel.Summary = XrSummary12;
			this.tranasctionTypeHeaderXrLabel.Text = "Transaction Type";
			this.tranasctionTypeHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemDescriptionHeaderXrLabel
			//
			this.itemDescriptionHeaderXrLabel.CanGrow = false;
			this.itemDescriptionHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.itemDescriptionHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(275.0F, 0.0F);
			this.itemDescriptionHeaderXrLabel.Name = "itemDescriptionHeaderXrLabel";
			this.itemDescriptionHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemDescriptionHeaderXrLabel.SizeF = new System.Drawing.SizeF(208.0F, 50.0F);
			this.itemDescriptionHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.itemDescriptionHeaderXrLabel.StylePriority.UseFont = false;
			XrSummary13.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum;
			XrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.None;
			this.itemDescriptionHeaderXrLabel.Summary = XrSummary13;
			this.itemDescriptionHeaderXrLabel.Text = "Item Description";
			this.itemDescriptionHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//itemCodeHeaderXrLabel
			//
			this.itemCodeHeaderXrLabel.CanGrow = false;
			this.itemCodeHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.itemCodeHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(125.0F, 0.0F);
			this.itemCodeHeaderXrLabel.Name = "itemCodeHeaderXrLabel";
			this.itemCodeHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.itemCodeHeaderXrLabel.SizeF = new System.Drawing.SizeF(150.0F, 50.0F);
			this.itemCodeHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.itemCodeHeaderXrLabel.StylePriority.UseFont = false;
			XrSummary14.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum;
			XrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.None;
			this.itemCodeHeaderXrLabel.Summary = XrSummary14;
			this.itemCodeHeaderXrLabel.Text = "Item #";
			this.itemCodeHeaderXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//balanceHeadeerXrLabel
			//
			this.balanceHeadeerXrLabel.CanGrow = false;
			this.balanceHeadeerXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.balanceHeadeerXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(692.0F, 0.0F);
			this.balanceHeadeerXrLabel.Name = "balanceHeadeerXrLabel";
			this.balanceHeadeerXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.balanceHeadeerXrLabel.SizeF = new System.Drawing.SizeF(106.0F, 50.0F);
			this.balanceHeadeerXrLabel.StyleName = "headerXrControlStyle";
			this.balanceHeadeerXrLabel.StylePriority.UseFont = false;
			XrSummary15.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum;
			XrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.None;
			this.balanceHeadeerXrLabel.Summary = XrSummary15;
			this.balanceHeadeerXrLabel.Text = "Balance";
			this.balanceHeadeerXrLabel.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			//
			//transactionDateHeaderXrLabel
			//
			this.transactionDateHeaderXrLabel.CanGrow = false;
			this.transactionDateHeaderXrLabel.Font = new System.Drawing.Font("Tahoma", 7.5F, System.Drawing.FontStyle.Bold);
			this.transactionDateHeaderXrLabel.LocationFloat = new DevExpress.Utils.PointFloat(0.0F, 0.0F);
			this.transactionDateHeaderXrLabel.Name = "transactionDateHeaderXrLabel";
			this.transactionDateHeaderXrLabel.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0F);
			this.transactionDateHeaderXrLabel.SizeF = new System.Drawing.SizeF(125.0F, 50.0F);
			this.transactionDateHeaderXrLabel.StyleName = "headerXrControlStyle";
			this.transactionDateHeaderXrLabel.StylePriority.UseFont = false;
			XrSummary16.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum;
			XrSummary16.Running = DevExpress.XtraReports.UI.SummaryRunning.None;
			this.transactionDateHeaderXrLabel.Summary = XrSummary16;
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
			//TopMarginBand1
			//
			this.TopMarginBand1.HeightF = 50.0F;
			this.TopMarginBand1.Name = "TopMarginBand1";
			this.TopMarginBand1.PageBreak = DevExpress.XtraReports.UI.PageBreak.None;
			//
			//BottomMarginBand1
			//
			this.BottomMarginBand1.HeightF = 50.0F;
			this.BottomMarginBand1.Name = "BottomMarginBand1";
			this.BottomMarginBand1.PageBreak = DevExpress.XtraReports.UI.PageBreak.None;
			//
			//itemTransactionsBindingSource
			//
			this.itemTransactionsBindingSource.DataSource = typeof(ItemTransactionsList);
			//
			//ItemTransactionXtraReport
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail, this.PageHeader, this.PageFooter, this.itemGroupHeader, this.TopMarginBand1, this.BottomMarginBand1});
			this.DataSource = this.itemTransactionsBindingSource;
			this.Margins = new System.Drawing.Printing.Margins(25, 25, 50, 50);
			this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {this.openingBalanceParameter});
			this.RequestParameters = false;
			this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {this.headerXrControlStyle, this.footerXrControlStyle, this.detailOddXrControlStyle, this.detailEvenXrControlStyle});
			this.Version = "10.1";
			((System.ComponentModel.ISupportInitialize)this.itemTransactionsBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)this).EndInit();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			balacneDetailXrLabel.SummaryCalculated += new DevExpress.XtraReports.UI.TextFormatEventHandler(balacneDetailXrLabel_SummaryCalculated);
			this.BeforePrint += new System.Drawing.Printing.PrintEventHandler(ItemTransactionXtraReport_BeforePrint);
		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
		internal DevExpress.XtraReports.UI.PageFooterBand PageFooter;
		internal DevExpress.XtraReports.UI.XRPageInfo printDateXrPageInfo;
		internal DevExpress.XtraReports.UI.XRLabel reportCriteriaXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel reportTitleXrLabel;
		internal DevExpress.XtraReports.UI.GroupHeaderBand itemGroupHeader;
		internal DevExpress.XtraReports.UI.XRPanel headerXrPanel;
		internal DevExpress.XtraReports.UI.XRLabel quantityHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel tranasctionTypeHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemDescriptionHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemCodeHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel balanceHeadeerXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel transactionDateHeaderXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel balacneDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel quantityDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel transactionTypeDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemDescriptionDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel itemCodeDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel transactionDateDetailXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel openingBalanceXrLabel;
		internal DevExpress.XtraReports.UI.XRLabel XrLabel1;
		internal System.Windows.Forms.BindingSource itemTransactionsBindingSource;
		internal DevExpress.XtraReports.UI.XRControlStyle headerXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle footerXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle detailOddXrControlStyle;
		internal DevExpress.XtraReports.UI.XRControlStyle detailEvenXrControlStyle;
		internal DevExpress.XtraReports.Parameters.Parameter openingBalanceParameter;
		internal DevExpress.XtraReports.UI.XRPageInfo pageNumberXrPageInfo;
		internal DevExpress.XtraReports.UI.TopMarginBand TopMarginBand1;
		internal DevExpress.XtraReports.UI.BottomMarginBand BottomMarginBand1;
	}

}