<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ProductionScheduleXtraSchedulerReport
    Inherits DevExpress.XtraScheduler.Reporting.XtraSchedulerReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TimeScaleYear1 As DevExpress.XtraScheduler.TimeScaleYear = New DevExpress.XtraScheduler.TimeScaleYear()
        Dim TimeScaleQuarter1 As DevExpress.XtraScheduler.TimeScaleQuarter = New DevExpress.XtraScheduler.TimeScaleQuarter()
        Dim TimeScaleMonth1 As DevExpress.XtraScheduler.TimeScaleMonth = New DevExpress.XtraScheduler.TimeScaleMonth()
        Dim TimeScaleWeek1 As DevExpress.XtraScheduler.TimeScaleWeek = New DevExpress.XtraScheduler.TimeScaleWeek()
        Dim TimeScaleDay1 As DevExpress.XtraScheduler.TimeScaleDay = New DevExpress.XtraScheduler.TimeScaleDay()
        Dim TimeScaleHour1 As DevExpress.XtraScheduler.TimeScaleHour = New DevExpress.XtraScheduler.TimeScaleHour()
        Dim TimeScale15Minutes1 As DevExpress.XtraScheduler.TimeScale15Minutes = New DevExpress.XtraScheduler.TimeScale15Minutes()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.ProductionShiftTimelineScaleHeaders = New DevExpress.XtraScheduler.Reporting.TimelineScaleHeaders()
        Me.ProductionScheduleReportTimelineView = New DevExpress.XtraScheduler.Reporting.ReportTimelineView()
        Me.machineLinesVerticalResourceHeaders = New DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders()
        Me.ProductionScheduleTimelineCells = New DevExpress.XtraScheduler.Reporting.TimelineCells()
        Me.TimeIntervalInfo1 = New DevExpress.XtraScheduler.Reporting.TimeIntervalInfo()
        CType(Me.ProductionScheduleReportTimelineView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.TimeIntervalInfo1, Me.ProductionShiftTimelineScaleHeaders, Me.machineLinesVerticalResourceHeaders, Me.ProductionScheduleTimelineCells})
        Me.Detail.HeightF = 900.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ProductionShiftTimelineScaleHeaders
        '
        Me.ProductionShiftTimelineScaleHeaders.LocationFloat = New DevExpress.Utils.PointFloat(98.33336!, 83.00001!)
        Me.ProductionShiftTimelineScaleHeaders.Name = "ProductionShiftTimelineScaleHeaders"
        Me.ProductionShiftTimelineScaleHeaders.SizeF = New System.Drawing.SizeF(541.6666!, 51.99999!)
        Me.ProductionShiftTimelineScaleHeaders.View = Me.ProductionScheduleReportTimelineView
        '
        'ProductionScheduleReportTimelineView
        '
        TimeScaleYear1.Enabled = False
        TimeScaleYear1.Visible = False
        TimeScaleQuarter1.Enabled = False
        TimeScaleQuarter1.Visible = False
        TimeScaleMonth1.Enabled = False
        TimeScaleWeek1.Enabled = False
        TimeScaleWeek1.Visible = False
        TimeScaleHour1.Enabled = False
        TimeScaleHour1.Visible = False
        TimeScale15Minutes1.Enabled = False
        TimeScale15Minutes1.Visible = False
        Me.ProductionScheduleReportTimelineView.Scales.Add(TimeScaleYear1)
        Me.ProductionScheduleReportTimelineView.Scales.Add(TimeScaleQuarter1)
        Me.ProductionScheduleReportTimelineView.Scales.Add(TimeScaleMonth1)
        Me.ProductionScheduleReportTimelineView.Scales.Add(TimeScaleWeek1)
        Me.ProductionScheduleReportTimelineView.Scales.Add(TimeScaleDay1)
        Me.ProductionScheduleReportTimelineView.Scales.Add(TimeScaleHour1)
        Me.ProductionScheduleReportTimelineView.Scales.Add(TimeScale15Minutes1)
        Me.ProductionScheduleReportTimelineView.VisibleResourceCount = 0
        '
        'machineLinesVerticalResourceHeaders
        '
        Me.machineLinesVerticalResourceHeaders.LocationFloat = New DevExpress.Utils.PointFloat(13.54165!, 135.0!)
        Me.machineLinesVerticalResourceHeaders.Name = "machineLinesVerticalResourceHeaders"
        Me.machineLinesVerticalResourceHeaders.Options.RotateCaption = False
        Me.machineLinesVerticalResourceHeaders.SizeF = New System.Drawing.SizeF(84.79171!, 765.0!)
        Me.machineLinesVerticalResourceHeaders.TimeCells = Me.ProductionScheduleTimelineCells
        Me.machineLinesVerticalResourceHeaders.View = Me.ProductionScheduleReportTimelineView
        '
        'ProductionScheduleTimelineCells
        '
        Me.ProductionScheduleTimelineCells.HorizontalHeaders = Me.ProductionShiftTimelineScaleHeaders
        Me.ProductionScheduleTimelineCells.LocationFloat = New DevExpress.Utils.PointFloat(98.33336!, 135.0!)
        Me.ProductionScheduleTimelineCells.Name = "ProductionScheduleTimelineCells"
        Me.ProductionScheduleTimelineCells.SizeF = New System.Drawing.SizeF(541.6666!, 765.0!)
        Me.ProductionScheduleTimelineCells.View = Me.ProductionScheduleReportTimelineView
        '
        'TimeIntervalInfo1
        '
        Me.TimeIntervalInfo1.LocationFloat = New DevExpress.Utils.PointFloat(98.33336!, 0!)
        Me.TimeIntervalInfo1.Name = "TimeIntervalInfo1"
        Me.TimeIntervalInfo1.SizeF = New System.Drawing.SizeF(541.6666!, 83.00001!)
        Me.TimeIntervalInfo1.TimeCells = Me.ProductionScheduleTimelineCells
        '
        'ProductionScheduleXtraSchedulerReport
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail})
        Me.Version = "15.1"
        Me.Views.AddRange(New DevExpress.XtraScheduler.Reporting.ReportViewBase() {Me.ProductionScheduleReportTimelineView})
        CType(Me.ProductionScheduleReportTimelineView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ProductionScheduleTimelineCells As DevExpress.XtraScheduler.Reporting.TimelineCells
    Friend WithEvents ProductionShiftTimelineScaleHeaders As DevExpress.XtraScheduler.Reporting.TimelineScaleHeaders
    Friend WithEvents machineLinesVerticalResourceHeaders As DevExpress.XtraScheduler.Reporting.VerticalResourceHeaders
    Friend WithEvents TimeIntervalInfo1 As DevExpress.XtraScheduler.Reporting.TimeIntervalInfo
    Public WithEvents ProductionScheduleReportTimelineView As DevExpress.XtraScheduler.Reporting.ReportTimelineView
End Class
