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
	public partial class ProductionScheduleXtraSchedulerReport : DevExpress.XtraScheduler.Reporting.XtraSchedulerReport
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
			DevExpress.XtraScheduler.TimeScaleYear TimeScaleYear1 = new DevExpress.XtraScheduler.TimeScaleYear();
			DevExpress.XtraScheduler.TimeScaleQuarter TimeScaleQuarter1 = new DevExpress.XtraScheduler.TimeScaleQuarter();
			DevExpress.XtraScheduler.TimeScaleMonth TimeScaleMonth1 = new DevExpress.XtraScheduler.TimeScaleMonth();
			DevExpress.XtraScheduler.TimeScaleWeek TimeScaleWeek1 = new DevExpress.XtraScheduler.TimeScaleWeek();
			DevExpress.XtraScheduler.TimeScaleDay TimeScaleDay1 = new DevExpress.XtraScheduler.TimeScaleDay();
			DevExpress.XtraScheduler.TimeScaleHour TimeScaleHour1 = new DevExpress.XtraScheduler.TimeScaleHour();
			DevExpress.XtraScheduler.TimeScale15Minutes TimeScale15Minutes1 = new DevExpress.XtraScheduler.TimeScale15Minutes();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.ProductionShiftTimelineScaleHeaders = new DevExpress.XtraScheduler.Reporting.TimelineScaleHeaders();
			this.ProductionScheduleReportTimelineView = new DevExpress.XtraScheduler.Reporting.ReportTimelineView();
			this.machineLinesVerticalResourceHeaders = new DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders();
			this.ProductionScheduleTimelineCells = new DevExpress.XtraScheduler.Reporting.TimelineCells();
			this.TimeIntervalInfo1 = new DevExpress.XtraScheduler.Reporting.TimeIntervalInfo();
			((System.ComponentModel.ISupportInitialize)this.ProductionScheduleReportTimelineView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this).BeginInit();
			//
			//Detail
			//
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {this.TimeIntervalInfo1, this.ProductionShiftTimelineScaleHeaders, this.machineLinesVerticalResourceHeaders, this.ProductionScheduleTimelineCells});
			this.Detail.HeightF = 900.0F;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0F);
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			//
			//ProductionShiftTimelineScaleHeaders
			//
			this.ProductionShiftTimelineScaleHeaders.LocationFloat = new DevExpress.Utils.PointFloat(98.33336F, 83.00001F);
			this.ProductionShiftTimelineScaleHeaders.Name = "ProductionShiftTimelineScaleHeaders";
			this.ProductionShiftTimelineScaleHeaders.SizeF = new System.Drawing.SizeF(541.6666F, 51.99999F);
			this.ProductionShiftTimelineScaleHeaders.View = this.ProductionScheduleReportTimelineView;
			//
			//ProductionScheduleReportTimelineView
			//
			TimeScaleYear1.Enabled = false;
			TimeScaleYear1.Visible = false;
			TimeScaleQuarter1.Enabled = false;
			TimeScaleQuarter1.Visible = false;
			TimeScaleMonth1.Enabled = false;
			TimeScaleWeek1.Enabled = false;
			TimeScaleWeek1.Visible = false;
			TimeScaleHour1.Enabled = false;
			TimeScaleHour1.Visible = false;
			TimeScale15Minutes1.Enabled = false;
			TimeScale15Minutes1.Visible = false;
			this.ProductionScheduleReportTimelineView.Scales.Add(TimeScaleYear1);
			this.ProductionScheduleReportTimelineView.Scales.Add(TimeScaleQuarter1);
			this.ProductionScheduleReportTimelineView.Scales.Add(TimeScaleMonth1);
			this.ProductionScheduleReportTimelineView.Scales.Add(TimeScaleWeek1);
			this.ProductionScheduleReportTimelineView.Scales.Add(TimeScaleDay1);
			this.ProductionScheduleReportTimelineView.Scales.Add(TimeScaleHour1);
			this.ProductionScheduleReportTimelineView.Scales.Add(TimeScale15Minutes1);
			this.ProductionScheduleReportTimelineView.VisibleResourceCount = 0;
			//
			//machineLinesVerticalResourceHeaders
			//
			this.machineLinesVerticalResourceHeaders.LocationFloat = new DevExpress.Utils.PointFloat(13.54165F, 135.0F);
			this.machineLinesVerticalResourceHeaders.Name = "machineLinesVerticalResourceHeaders";
			this.machineLinesVerticalResourceHeaders.Options.RotateCaption = false;
			this.machineLinesVerticalResourceHeaders.SizeF = new System.Drawing.SizeF(84.79171F, 765.0F);
			this.machineLinesVerticalResourceHeaders.TimeCells = this.ProductionScheduleTimelineCells;
			this.machineLinesVerticalResourceHeaders.View = this.ProductionScheduleReportTimelineView;
			//
			//ProductionScheduleTimelineCells
			//
			this.ProductionScheduleTimelineCells.HorizontalHeaders = this.ProductionShiftTimelineScaleHeaders;
			this.ProductionScheduleTimelineCells.LocationFloat = new DevExpress.Utils.PointFloat(98.33336F, 135.0F);
			this.ProductionScheduleTimelineCells.Name = "ProductionScheduleTimelineCells";
			this.ProductionScheduleTimelineCells.SizeF = new System.Drawing.SizeF(541.6666F, 765.0F);
			this.ProductionScheduleTimelineCells.View = this.ProductionScheduleReportTimelineView;
			//
			//TimeIntervalInfo1
			//
			this.TimeIntervalInfo1.LocationFloat = new DevExpress.Utils.PointFloat(98.33336F, 0F);
			this.TimeIntervalInfo1.Name = "TimeIntervalInfo1";
			this.TimeIntervalInfo1.SizeF = new System.Drawing.SizeF(541.6666F, 83.00001F);
			this.TimeIntervalInfo1.TimeCells = this.ProductionScheduleTimelineCells;
			//
			//ProductionScheduleXtraSchedulerReport
			//
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {this.Detail});
			this.Version = "15.1";
			this.Views.AddRange(new DevExpress.XtraScheduler.Reporting.ReportViewBase[] {this.ProductionScheduleReportTimelineView});
			((System.ComponentModel.ISupportInitialize)this.ProductionScheduleReportTimelineView).EndInit();
			((System.ComponentModel.ISupportInitialize)this).EndInit();

		}
		internal DevExpress.XtraReports.UI.DetailBand Detail;
		internal DevExpress.XtraScheduler.Reporting.TimelineCells ProductionScheduleTimelineCells;
		internal DevExpress.XtraScheduler.Reporting.TimelineScaleHeaders ProductionShiftTimelineScaleHeaders;
		internal DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders machineLinesVerticalResourceHeaders;
		internal DevExpress.XtraScheduler.Reporting.TimeIntervalInfo TimeIntervalInfo1;
		public DevExpress.XtraScheduler.Reporting.ReportTimelineView ProductionScheduleReportTimelineView;
	}

}