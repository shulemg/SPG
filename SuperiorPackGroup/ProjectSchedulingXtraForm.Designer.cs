using DevExpress.Data.Filtering;
using DXDAL.SPGData;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;
using DevExpress.XtraScheduler.Native;
using DevExpress.XtraScheduler.Services;
using DevExpress.XtraScheduler.Reporting;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using System.ComponentModel;
using DevExpress.Services;

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
	public partial class ProjectSchedulingXtraForm : DevExpress.XtraEditors.XtraForm
	{
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		//Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			DevExpress.XtraGrid.GridLevelNode GridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
			DevExpress.XtraGrid.GridLevelNode GridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
			DevExpress.XtraScheduler.TimeRuler TimeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
			DevExpress.XtraScheduler.TimeRuler TimeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
			DevExpress.XtraScheduler.TimeScaleYear TimeScaleYear1 = new DevExpress.XtraScheduler.TimeScaleYear();
			DevExpress.XtraScheduler.TimeScaleQuarter TimeScaleQuarter1 = new DevExpress.XtraScheduler.TimeScaleQuarter();
			DevExpress.XtraScheduler.TimeScaleMonth TimeScaleMonth1 = new DevExpress.XtraScheduler.TimeScaleMonth();
			DevExpress.XtraScheduler.TimeScaleWeek TimeScaleWeek1 = new DevExpress.XtraScheduler.TimeScaleWeek();
			DevExpress.XtraScheduler.TimeScaleDay TimeScaleDay1 = new DevExpress.XtraScheduler.TimeScaleDay();
			DevExpress.XtraScheduler.TimeScaleHour TimeScaleHour1 = new DevExpress.XtraScheduler.TimeScaleHour();
			DevExpress.XtraScheduler.TimeScale15Minutes TimeScale15Minutes1 = new DevExpress.XtraScheduler.TimeScale15Minutes();
			DevExpress.XtraScheduler.TimeRuler TimeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectSchedulingXtraForm));
			DevExpress.Utils.SuperToolTip SuperToolTip1 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem ToolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.ToolTipItem ToolTipItem1 = new DevExpress.Utils.ToolTipItem();
			DevExpress.Utils.SuperToolTip SuperToolTip2 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem ToolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.ToolTipItem ToolTipItem2 = new DevExpress.Utils.ToolTipItem();
			DevExpress.Utils.SuperToolTip SuperToolTip3 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem ToolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.ToolTipItem ToolTipItem3 = new DevExpress.Utils.ToolTipItem();
			DevExpress.Utils.SuperToolTip SuperToolTip4 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem ToolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.ToolTipItem ToolTipItem4 = new DevExpress.Utils.ToolTipItem();
			this.locationInventoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colLocationCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQuantityOnHand = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLocationName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.itemReferenceGridControl = new DevExpress.XtraGrid.GridControl();
			this.itemReferenceXpCollection = new DevExpress.Xpo.XPCollection(this.components);
			this.itemGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colItemID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colItemType = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colItemProdStandard = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colintQtyPerUnit = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colstrEnteredBy = new DevExpress.XtraGrid.Columns.GridColumn();
			this.coldtmEnteredOn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colintUnitsPerCase = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colintUnitsPerPallet = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colintCasesPerPallet = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCaseGrossWeight = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPackageCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCaseCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colRequiredWeight = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMAV = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCasesPerLayer = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLayersPerPallet = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShelfLife = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colInstructions = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPalletPattern = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colInactive = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPackers = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUPC = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBagsPerCase = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTotalQuantityOnHand = new DevExpress.XtraGrid.Columns.GridColumn();
			this.projectProductionScheduleGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colStart = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFinish = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colMachineLine = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPeople = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colOperator = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colItem = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.projectsGridControl = new DevExpress.XtraGrid.GridControl();
			this.projectDetailsXpCollection = new DevExpress.Xpo.XPCollection(this.components);
			this.projectDetailsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHasChanges = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCustomerPO = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colProjectItemID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUnitsRequested = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBagsRequested = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPalletsRequested = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colAllowOverrun = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUnitsProduced = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUnitsNeeded = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBagsProduced = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPalletsProduced = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPercentageComplete = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEstimatedShifts = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colItemNumber = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUnitsScheduled = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colUnitsNeededToSchedule = new DevExpress.XtraGrid.Columns.GridColumn();
			this.productionSchedulerControl = new DevExpress.XtraScheduler.SchedulerControl();
			this.BarManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.CommonBar1 = new DevExpress.XtraScheduler.UI.CommonBar();
			this.OpenScheduleItem1 = new DevExpress.XtraScheduler.UI.OpenScheduleItem();
			this.SaveScheduleItem1 = new DevExpress.XtraScheduler.UI.SaveScheduleItem();
			this.PrintBar1 = new DevExpress.XtraScheduler.UI.PrintBar();
			this.reportDateBarEditItem = new DevExpress.XtraBars.BarEditItem();
			this.RepositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.reportShiftBarEditItem = new DevExpress.XtraBars.BarEditItem();
			this.RepositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
			this.openReportBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.AppointmentBar1 = new DevExpress.XtraScheduler.UI.AppointmentBar();
			this.NewAppointmentItem1 = new DevExpress.XtraScheduler.UI.NewAppointmentItem();
			this.NewRecurringAppointmentItem1 = new DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem();
			this.NavigatorBar1 = new DevExpress.XtraScheduler.UI.NavigatorBar();
			this.NavigateViewBackwardItem1 = new DevExpress.XtraScheduler.UI.NavigateViewBackwardItem();
			this.NavigateViewForwardItem1 = new DevExpress.XtraScheduler.UI.NavigateViewForwardItem();
			this.GotoTodayItem1 = new DevExpress.XtraScheduler.UI.GotoTodayItem();
			this.ViewZoomInItem1 = new DevExpress.XtraScheduler.UI.ViewZoomInItem();
			this.ViewZoomOutItem1 = new DevExpress.XtraScheduler.UI.ViewZoomOutItem();
			this.ArrangeBar1 = new DevExpress.XtraScheduler.UI.ArrangeBar();
			this.SwitchToDayViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToDayViewItem();
			this.SwitchToWorkWeekViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem();
			this.SwitchToWeekViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToWeekViewItem();
			this.SwitchToFullWeekViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem();
			this.SwitchToMonthViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToMonthViewItem();
			this.SwitchToTimelineViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem();
			this.SwitchToGanttViewItem1 = new DevExpress.XtraScheduler.UI.SwitchToGanttViewItem();
			this.GroupByBar1 = new DevExpress.XtraScheduler.UI.GroupByBar();
			this.GroupByNoneItem1 = new DevExpress.XtraScheduler.UI.GroupByNoneItem();
			this.GroupByDateItem1 = new DevExpress.XtraScheduler.UI.GroupByDateItem();
			this.GroupByResourceItem1 = new DevExpress.XtraScheduler.UI.GroupByResourceItem();
			this.TimeScaleBar1 = new DevExpress.XtraScheduler.UI.TimeScaleBar();
			this.SwitchTimeScalesItem1 = new DevExpress.XtraScheduler.UI.SwitchTimeScalesItem();
			this.ChangeScaleWidthItem1 = new DevExpress.XtraScheduler.UI.ChangeScaleWidthItem();
			this.RepositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
			this.SwitchTimeScalesCaptionItem1 = new DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem();
			this.LayoutBar1 = new DevExpress.XtraScheduler.UI.LayoutBar();
			this.SwitchCompressWeekendItem1 = new DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem();
			this.SwitchShowWorkTimeOnlyItem1 = new DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem();
			this.SwitchCellsAutoHeightItem1 = new DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem();
			this.ChangeSnapToCellsUIItem1 = new DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem();
			this.ActionsBar1 = new DevExpress.XtraScheduler.UI.ActionsBar();
			this.EditAppointmentQueryItem1 = new DevExpress.XtraScheduler.UI.EditAppointmentQueryItem();
			this.EditOccurrenceUICommandItem1 = new DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem();
			this.EditSeriesUICommandItem1 = new DevExpress.XtraScheduler.UI.EditSeriesUICommandItem();
			this.DeleteAppointmentsItem1 = new DevExpress.XtraScheduler.UI.DeleteAppointmentsItem();
			this.DeleteOccurrenceItem1 = new DevExpress.XtraScheduler.UI.DeleteOccurrenceItem();
			this.DeleteSeriesItem1 = new DevExpress.XtraScheduler.UI.DeleteSeriesItem();
			this.SplitAppointmentItem1 = new DevExpress.XtraScheduler.UI.SplitAppointmentItem();
			this.OptionsBar1 = new DevExpress.XtraScheduler.UI.OptionsBar();
			this.ChangeAppointmentStatusItem1 = new DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem();
			this.ChangeAppointmentLabelItem1 = new DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem();
			this.ToggleRecurrenceItem1 = new DevExpress.XtraScheduler.UI.ToggleRecurrenceItem();
			this.ChangeAppointmentReminderItem1 = new DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem();
			this.RepositoryItemDuration1 = new DevExpress.XtraScheduler.UI.RepositoryItemDuration();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.PrintItem1 = new DevExpress.XtraScheduler.UI.PrintItem();
			this.PrintPageSetupItem1 = new DevExpress.XtraScheduler.UI.PrintPageSetupItem();
			this.SchedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
			this.productionScheduleXpCollection = new DevExpress.Xpo.XPCollection(this.components);
			this.machineLinesXpCollection = new DevExpress.Xpo.XPCollection(this.components);
			this.scheduleProjectsSplitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
			this.scheduleResourcesplitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
			this.SplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			this.DateNavigator1 = new DevExpress.XtraScheduler.DateNavigator();
			this.productionResourcesTree = new DevExpress.XtraScheduler.UI.ResourcesTree();
			this.colMachineLineName = new DevExpress.XtraScheduler.Native.ResourceTreeColumn();
			this.projectsItemReferenceSplitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
			this.SchedulerBarController1 = new DevExpress.XtraScheduler.UI.SchedulerBarController();
			((System.ComponentModel.ISupportInitialize)this.locationInventoryGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemReferenceGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemReferenceXpCollection).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.projectProductionScheduleGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.projectsGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.projectDetailsXpCollection).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.projectDetailsGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionSchedulerControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.BarManager1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemDateEdit1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemDateEdit1.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemComboBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemSpinEdit1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemDuration1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.SchedulerStorage1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionScheduleXpCollection).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.machineLinesXpCollection).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.scheduleProjectsSplitContainerControl).BeginInit();
			this.scheduleProjectsSplitContainerControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.scheduleResourcesplitContainerControl).BeginInit();
			this.scheduleResourcesplitContainerControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.SplitContainerControl1).BeginInit();
			this.SplitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.DateNavigator1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionResourcesTree).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.projectsItemReferenceSplitContainerControl).BeginInit();
			this.projectsItemReferenceSplitContainerControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.SchedulerBarController1).BeginInit();
			this.SuspendLayout();
			//
			//locationInventoryGridView
			//
			this.locationInventoryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colLocationCode, this.colQuantityOnHand, this.colLocationName});
			this.locationInventoryGridView.GridControl = this.itemReferenceGridControl;
			this.locationInventoryGridView.Name = "locationInventoryGridView";
			this.locationInventoryGridView.OptionsView.ShowGroupPanel = false;
			//
			//colLocationCode
			//
			this.colLocationCode.Caption = "Location Code";
			this.colLocationCode.FieldName = "Location.LocationCode";
			this.colLocationCode.Name = "colLocationCode";
			this.colLocationCode.Visible = true;
			this.colLocationCode.VisibleIndex = 0;
			//
			//colQuantityOnHand
			//
			this.colQuantityOnHand.Caption = "Quantity On Hand";
			this.colQuantityOnHand.FieldName = "QuantityOnHand";
			this.colQuantityOnHand.Name = "colQuantityOnHand";
			this.colQuantityOnHand.Visible = true;
			this.colQuantityOnHand.VisibleIndex = 2;
			//
			//colLocationName
			//
			this.colLocationName.Caption = "Location Name";
			this.colLocationName.FieldName = "Location.LocationName";
			this.colLocationName.Name = "colLocationName";
			this.colLocationName.Visible = true;
			this.colLocationName.VisibleIndex = 1;
			//
			//itemReferenceGridControl
			//
			this.itemReferenceGridControl.DataSource = this.itemReferenceXpCollection;
			this.itemReferenceGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			GridLevelNode1.LevelTemplate = this.locationInventoryGridView;
			GridLevelNode1.RelationName = "LocationsInventory";
			this.itemReferenceGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {GridLevelNode1});
			this.itemReferenceGridControl.Location = new System.Drawing.Point(0, 0);
			this.itemReferenceGridControl.MainView = this.itemGridView;
			this.itemReferenceGridControl.Name = "itemReferenceGridControl";
			this.itemReferenceGridControl.ShowOnlyPredefinedDetails = true;
			this.itemReferenceGridControl.Size = new System.Drawing.Size(575, 172);
			this.itemReferenceGridControl.TabIndex = 0;
			this.itemReferenceGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.itemGridView, this.locationInventoryGridView});
			//
			//itemReferenceXpCollection
			//
			this.itemReferenceXpCollection.CriteriaString = "[Inactive] = False And [ItemID] = 0";
			this.itemReferenceXpCollection.ObjectType = typeof(DXDAL.SPGData.Items);
			//
			//itemGridView
			//
			this.itemGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colItemID, this.colItemCode, this.colItemDescription, this.colItemType, this.colCustomerName, this.GridColumn6, this.GridColumn7, this.GridColumn8, this.colItemProdStandard, this.colintQtyPerUnit, this.colstrEnteredBy, this.coldtmEnteredOn, this.colintUnitsPerCase, this.colintUnitsPerPallet, this.colintCasesPerPallet, this.colCaseGrossWeight, this.colPackageCode, this.colCaseCode, this.colRequiredWeight, this.colMAV, this.colCasesPerLayer, this.colLayersPerPallet, this.colShelfLife, this.colInstructions, this.colPalletPattern, this.colInactive, this.colPackers, this.colUPC, this.colBagsPerCase, this.colTotalQuantityOnHand});
			this.itemGridView.GridControl = this.itemReferenceGridControl;
			this.itemGridView.Name = "itemGridView";
			this.itemGridView.OptionsBehavior.Editable = false;
			//
			//colItemID
			//
			this.colItemID.FieldName = "ItemID";
			this.colItemID.Name = "colItemID";
			this.colItemID.Visible = true;
			this.colItemID.VisibleIndex = 0;
			//
			//colItemCode
			//
			this.colItemCode.FieldName = "ItemCode";
			this.colItemCode.Name = "colItemCode";
			this.colItemCode.Visible = true;
			this.colItemCode.VisibleIndex = 1;
			//
			//colItemDescription
			//
			this.colItemDescription.FieldName = "ItemDescription";
			this.colItemDescription.Name = "colItemDescription";
			this.colItemDescription.Visible = true;
			this.colItemDescription.VisibleIndex = 2;
			//
			//colItemType
			//
			this.colItemType.FieldName = "ItemType";
			this.colItemType.Name = "colItemType";
			//
			//colCustomerName
			//
			this.colCustomerName.Caption = "Customer Name";
			this.colCustomerName.FieldName = "ItemCustomerID.CustomerName";
			this.colCustomerName.Name = "colCustomerName";
			this.colCustomerName.Visible = true;
			this.colCustomerName.VisibleIndex = 3;
			//
			//GridColumn6
			//
			this.GridColumn6.FieldName = "ItemCustomerID!Key";
			this.GridColumn6.Name = "GridColumn6";
			//
			//GridColumn7
			//
			this.GridColumn7.FieldName = "ItemDefaultMachine!";
			this.GridColumn7.Name = "GridColumn7";
			//
			//GridColumn8
			//
			this.GridColumn8.FieldName = "ItemDefaultMachine!Key";
			this.GridColumn8.Name = "GridColumn8";
			//
			//colItemProdStandard
			//
			this.colItemProdStandard.Caption = "Production Standard";
			this.colItemProdStandard.FieldName = "ItemProdStandard";
			this.colItemProdStandard.Name = "colItemProdStandard";
			this.colItemProdStandard.Visible = true;
			this.colItemProdStandard.VisibleIndex = 4;
			//
			//colintQtyPerUnit
			//
			this.colintQtyPerUnit.Caption = "Qty Per Unit";
			this.colintQtyPerUnit.FieldName = "intQtyPerUnit";
			this.colintQtyPerUnit.Name = "colintQtyPerUnit";
			//
			//colstrEnteredBy
			//
			this.colstrEnteredBy.FieldName = "strEnteredBy";
			this.colstrEnteredBy.Name = "colstrEnteredBy";
			//
			//coldtmEnteredOn
			//
			this.coldtmEnteredOn.FieldName = "dtmEnteredOn";
			this.coldtmEnteredOn.Name = "coldtmEnteredOn";
			//
			//colintUnitsPerCase
			//
			this.colintUnitsPerCase.Caption = "Units Per Case";
			this.colintUnitsPerCase.FieldName = "intUnitsPerCase";
			this.colintUnitsPerCase.Name = "colintUnitsPerCase";
			this.colintUnitsPerCase.Visible = true;
			this.colintUnitsPerCase.VisibleIndex = 6;
			//
			//colintUnitsPerPallet
			//
			this.colintUnitsPerPallet.Caption = "Units Per Pallet";
			this.colintUnitsPerPallet.FieldName = "intUnitsPerPallet";
			this.colintUnitsPerPallet.Name = "colintUnitsPerPallet";
			//
			//colintCasesPerPallet
			//
			this.colintCasesPerPallet.Caption = "Cases Per Pallet";
			this.colintCasesPerPallet.FieldName = "intCasesPerPallet";
			this.colintCasesPerPallet.Name = "colintCasesPerPallet";
			//
			//colCaseGrossWeight
			//
			this.colCaseGrossWeight.FieldName = "CaseGrossWeight";
			this.colCaseGrossWeight.Name = "colCaseGrossWeight";
			//
			//colPackageCode
			//
			this.colPackageCode.FieldName = "PackageCode";
			this.colPackageCode.Name = "colPackageCode";
			//
			//colCaseCode
			//
			this.colCaseCode.FieldName = "CaseCode";
			this.colCaseCode.Name = "colCaseCode";
			//
			//colRequiredWeight
			//
			this.colRequiredWeight.FieldName = "RequiredWeight";
			this.colRequiredWeight.Name = "colRequiredWeight";
			//
			//colMAV
			//
			this.colMAV.FieldName = "MAV";
			this.colMAV.Name = "colMAV";
			//
			//colCasesPerLayer
			//
			this.colCasesPerLayer.FieldName = "CasesPerLayer";
			this.colCasesPerLayer.Name = "colCasesPerLayer";
			//
			//colLayersPerPallet
			//
			this.colLayersPerPallet.FieldName = "LayersPerPallet";
			this.colLayersPerPallet.Name = "colLayersPerPallet";
			//
			//colShelfLife
			//
			this.colShelfLife.FieldName = "ShelfLife";
			this.colShelfLife.Name = "colShelfLife";
			//
			//colInstructions
			//
			this.colInstructions.FieldName = "Instructions";
			this.colInstructions.Name = "colInstructions";
			//
			//colPalletPattern
			//
			this.colPalletPattern.FieldName = "PalletPattern";
			this.colPalletPattern.Name = "colPalletPattern";
			//
			//colInactive
			//
			this.colInactive.FieldName = "Inactive";
			this.colInactive.Name = "colInactive";
			//
			//colPackers
			//
			this.colPackers.FieldName = "Packers";
			this.colPackers.Name = "colPackers";
			this.colPackers.Visible = true;
			this.colPackers.VisibleIndex = 5;
			//
			//colUPC
			//
			this.colUPC.FieldName = "UPC";
			this.colUPC.Name = "colUPC";
			//
			//colBagsPerCase
			//
			this.colBagsPerCase.FieldName = "BagsPerCase";
			this.colBagsPerCase.Name = "colBagsPerCase";
			this.colBagsPerCase.Visible = true;
			this.colBagsPerCase.VisibleIndex = 7;
			//
			//colTotalQuantityOnHand
			//
			this.colTotalQuantityOnHand.DisplayFormat.FormatString = "{0:#,##0.####}";
			this.colTotalQuantityOnHand.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colTotalQuantityOnHand.FieldName = "TotalQuantityOnHand";
			this.colTotalQuantityOnHand.Name = "colTotalQuantityOnHand";
			this.colTotalQuantityOnHand.Visible = true;
			this.colTotalQuantityOnHand.VisibleIndex = 8;
			//
			//projectProductionScheduleGridView
			//
			this.projectProductionScheduleGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colStart, this.colFinish, this.colMachineLine, this.colPeople, this.colOperator, this.colItem, this.colQuantity});
			this.projectProductionScheduleGridView.GridControl = this.projectsGridControl;
			this.projectProductionScheduleGridView.Name = "projectProductionScheduleGridView";
			this.projectProductionScheduleGridView.OptionsBehavior.Editable = false;
			this.projectProductionScheduleGridView.OptionsView.ShowDetailButtons = false;
			this.projectProductionScheduleGridView.OptionsView.ShowGroupPanel = false;
			//
			//colStart
			//
			this.colStart.Caption = "Start";
			this.colStart.DisplayFormat.FormatString = "g";
			this.colStart.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colStart.FieldName = "Start";
			this.colStart.Name = "colStart";
			this.colStart.Visible = true;
			this.colStart.VisibleIndex = 0;
			//
			//colFinish
			//
			this.colFinish.Caption = "Finish";
			this.colFinish.DisplayFormat.FormatString = "g";
			this.colFinish.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colFinish.FieldName = "Finish";
			this.colFinish.Name = "colFinish";
			this.colFinish.Visible = true;
			this.colFinish.VisibleIndex = 1;
			//
			//colMachineLine
			//
			this.colMachineLine.Caption = "Machine Line";
			this.colMachineLine.FieldName = "MachineLine.MachineLineName";
			this.colMachineLine.Name = "colMachineLine";
			this.colMachineLine.Visible = true;
			this.colMachineLine.VisibleIndex = 2;
			//
			//colPeople
			//
			this.colPeople.FieldName = "People";
			this.colPeople.Name = "colPeople";
			this.colPeople.Visible = true;
			this.colPeople.VisibleIndex = 3;
			//
			//colOperator
			//
			this.colOperator.Caption = "Operator";
			this.colOperator.FieldName = "MachineOperator";
			this.colOperator.Name = "colOperator";
			this.colOperator.Visible = true;
			this.colOperator.VisibleIndex = 4;
			//
			//colItem
			//
			this.colItem.Caption = "Item Code";
			this.colItem.FieldName = "ProductionItem.ItemCode";
			this.colItem.Name = "colItem";
			//
			//colQuantity
			//
			this.colQuantity.FieldName = "Quantity";
			this.colQuantity.Name = "colQuantity";
			this.colQuantity.Visible = true;
			this.colQuantity.VisibleIndex = 5;
			//
			//projectsGridControl
			//
			this.projectsGridControl.DataSource = this.projectDetailsXpCollection;
			this.projectsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			GridLevelNode2.LevelTemplate = this.projectProductionScheduleGridView;
			GridLevelNode2.RelationName = "ProjectProductionSchedule";
			this.projectsGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {GridLevelNode2});
			this.projectsGridControl.Location = new System.Drawing.Point(0, 0);
			this.projectsGridControl.MainView = this.projectDetailsGridView;
			this.projectsGridControl.Name = "projectsGridControl";
			this.projectsGridControl.ShowOnlyPredefinedDetails = true;
			this.projectsGridControl.Size = new System.Drawing.Size(554, 172);
			this.projectsGridControl.TabIndex = 0;
			this.projectsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.projectDetailsGridView, this.projectProductionScheduleGridView});
			//
			//projectDetailsXpCollection
			//
			this.projectDetailsXpCollection.CriteriaString = "[PercentageComplete] < 100.0 And [Project.ProjectStatus] <> 3";
			this.projectDetailsXpCollection.ObjectType = typeof(DXDAL.SPGData.ProjectDetails);
			//
			//projectDetailsGridView
			//
			this.projectDetailsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colOid, this.colHasChanges, this.GridColumn1, this.GridColumn2, this.colCustomerPO, this.GridColumn3, this.colProjectItemID, this.colUnitsRequested, this.colBagsRequested, this.colPalletsRequested, this.colAllowOverrun, this.colUnitsProduced, this.colUnitsNeeded, this.colBagsProduced, this.colPalletsProduced, this.colPercentageComplete, this.colEstimatedShifts, this.colItemNumber, this.colUnitsScheduled, this.colUnitsNeededToSchedule});
			this.projectDetailsGridView.GridControl = this.projectsGridControl;
			this.projectDetailsGridView.Name = "projectDetailsGridView";
			this.projectDetailsGridView.OptionsBehavior.Editable = false;
			this.projectDetailsGridView.OptionsView.ShowAutoFilterRow = true;
			//
			//colOid
			//
			this.colOid.FieldName = "Oid";
			this.colOid.Name = "colOid";
			//
			//colHasChanges
			//
			this.colHasChanges.FieldName = "HasChanges";
			this.colHasChanges.Name = "colHasChanges";
			//
			//GridColumn1
			//
			this.GridColumn1.FieldName = "Project!";
			this.GridColumn1.Name = "GridColumn1";
			//
			//GridColumn2
			//
			this.GridColumn2.FieldName = "Project!Key";
			this.GridColumn2.Name = "GridColumn2";
			//
			//colCustomerPO
			//
			this.colCustomerPO.FieldName = "CustomerPO";
			this.colCustomerPO.Name = "colCustomerPO";
			this.colCustomerPO.Visible = true;
			this.colCustomerPO.VisibleIndex = 0;
			//
			//GridColumn3
			//
			this.GridColumn3.FieldName = "ProjectItem!";
			this.GridColumn3.Name = "GridColumn3";
			//
			//colProjectItemID
			//
			this.colProjectItemID.FieldName = "ProjectItem!Key";
			this.colProjectItemID.Name = "colProjectItemID";
			//
			//colUnitsRequested
			//
			this.colUnitsRequested.FieldName = "UnitsRequested";
			this.colUnitsRequested.Name = "colUnitsRequested";
			this.colUnitsRequested.Visible = true;
			this.colUnitsRequested.VisibleIndex = 2;
			//
			//colBagsRequested
			//
			this.colBagsRequested.FieldName = "BagsRequested";
			this.colBagsRequested.Name = "colBagsRequested";
			this.colBagsRequested.Visible = true;
			this.colBagsRequested.VisibleIndex = 3;
			//
			//colPalletsRequested
			//
			this.colPalletsRequested.FieldName = "PalletsRequested";
			this.colPalletsRequested.Name = "colPalletsRequested";
			//
			//colAllowOverrun
			//
			this.colAllowOverrun.FieldName = "AllowOverrun";
			this.colAllowOverrun.Name = "colAllowOverrun";
			this.colAllowOverrun.Visible = true;
			this.colAllowOverrun.VisibleIndex = 7;
			//
			//colUnitsProduced
			//
			this.colUnitsProduced.FieldName = "UnitsProduced";
			this.colUnitsProduced.Name = "colUnitsProduced";
			this.colUnitsProduced.Visible = true;
			this.colUnitsProduced.VisibleIndex = 4;
			//
			//colUnitsNeeded
			//
			this.colUnitsNeeded.FieldName = "UnitsNeeded";
			this.colUnitsNeeded.Name = "colUnitsNeeded";
			//
			//colBagsProduced
			//
			this.colBagsProduced.FieldName = "BagsProduced";
			this.colBagsProduced.Name = "colBagsProduced";
			this.colBagsProduced.Visible = true;
			this.colBagsProduced.VisibleIndex = 5;
			//
			//colPalletsProduced
			//
			this.colPalletsProduced.FieldName = "PalletsProduced";
			this.colPalletsProduced.Name = "colPalletsProduced";
			//
			//colPercentageComplete
			//
			this.colPercentageComplete.FieldName = "PercentageComplete";
			this.colPercentageComplete.Name = "colPercentageComplete";
			this.colPercentageComplete.Visible = true;
			this.colPercentageComplete.VisibleIndex = 6;
			//
			//colEstimatedShifts
			//
			this.colEstimatedShifts.DisplayFormat.FormatString = "f2";
			this.colEstimatedShifts.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colEstimatedShifts.FieldName = "EstimatedShifts";
			this.colEstimatedShifts.Name = "colEstimatedShifts";
			this.colEstimatedShifts.Visible = true;
			this.colEstimatedShifts.VisibleIndex = 8;
			//
			//colItemNumber
			//
			this.colItemNumber.Caption = "Item #";
			this.colItemNumber.FieldName = "ProjectItem.ItemCode";
			this.colItemNumber.Name = "colItemNumber";
			this.colItemNumber.Visible = true;
			this.colItemNumber.VisibleIndex = 1;
			//
			//colUnitsScheduled
			//
			this.colUnitsScheduled.FieldName = "UnitsScheduled";
			this.colUnitsScheduled.Name = "colUnitsScheduled";
			//
			//colUnitsNeededToSchedule
			//
			this.colUnitsNeededToSchedule.FieldName = "UnitsNeededToSchedule";
			this.colUnitsNeededToSchedule.Name = "colUnitsNeededToSchedule";
			this.colUnitsNeededToSchedule.Visible = true;
			this.colUnitsNeededToSchedule.VisibleIndex = 9;
			//
			//productionSchedulerControl
			//
			this.productionSchedulerControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.productionSchedulerControl.Location = new System.Drawing.Point(0, 0);
			this.productionSchedulerControl.MenuManager = this.BarManager1;
			this.productionSchedulerControl.Name = "productionSchedulerControl";
			this.productionSchedulerControl.OptionsBehavior.ShowRemindersForm = false;
			this.productionSchedulerControl.OptionsCustomization.AllowAppointmentDelete = DevExpress.XtraScheduler.UsedAppointmentType.None;
			this.productionSchedulerControl.OptionsCustomization.AllowInplaceEditor = DevExpress.XtraScheduler.UsedAppointmentType.None;
			this.productionSchedulerControl.OptionsRangeControl.RangeMaximum = new DateTime(2015, 6, 1, 0, 0, 0, 0);
			this.productionSchedulerControl.OptionsRangeControl.RangeMinimum = new DateTime(2015, 3, 1, 0, 0, 0, 0);
			this.productionSchedulerControl.OptionsView.FirstDayOfWeek = DevExpress.XtraScheduler.FirstDayOfWeek.Monday;
			this.productionSchedulerControl.OptionsView.NavigationButtons.Visibility = DevExpress.XtraScheduler.NavigationButtonVisibility.Never;
			this.productionSchedulerControl.OptionsView.ResourceHeaders.RotateCaption = false;
			this.productionSchedulerControl.Size = new System.Drawing.Size(947, 474);
			this.productionSchedulerControl.Start = new DateTime(2015, 12, 28, 0, 0, 0, 0);
			this.productionSchedulerControl.Storage = this.SchedulerStorage1;
			this.productionSchedulerControl.TabIndex = 0;
			this.productionSchedulerControl.Text = "SchedulerControl1";
			this.productionSchedulerControl.Views.DayView.ResourcesPerPage = 10;
			this.productionSchedulerControl.Views.DayView.TimeRulers.Add(TimeRuler1);
			this.productionSchedulerControl.Views.FullWeekView.Enabled = true;
			this.productionSchedulerControl.Views.FullWeekView.ResourcesPerPage = 10;
			this.productionSchedulerControl.Views.FullWeekView.TimeRulers.Add(TimeRuler2);
			this.productionSchedulerControl.Views.GanttView.Enabled = false;
			this.productionSchedulerControl.Views.MonthView.ResourcesPerPage = 10;
			this.productionSchedulerControl.Views.TimelineView.Appearance.HeaderCaptionLine.Options.UseTextOptions = true;
			this.productionSchedulerControl.Views.TimelineView.Appearance.HeaderCaptionLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.productionSchedulerControl.Views.TimelineView.DateTimeScrollbarVisible = false;
			this.productionSchedulerControl.Views.TimelineView.ResourcesPerPage = 10;
			TimeScaleYear1.Enabled = false;
			TimeScaleQuarter1.Enabled = false;
			TimeScaleHour1.Enabled = false;
			TimeScale15Minutes1.Enabled = false;
			this.productionSchedulerControl.Views.TimelineView.Scales.Add(TimeScaleYear1);
			this.productionSchedulerControl.Views.TimelineView.Scales.Add(TimeScaleQuarter1);
			this.productionSchedulerControl.Views.TimelineView.Scales.Add(TimeScaleMonth1);
			this.productionSchedulerControl.Views.TimelineView.Scales.Add(TimeScaleWeek1);
			this.productionSchedulerControl.Views.TimelineView.Scales.Add(TimeScaleDay1);
			this.productionSchedulerControl.Views.TimelineView.Scales.Add(TimeScaleHour1);
			this.productionSchedulerControl.Views.TimelineView.Scales.Add(TimeScale15Minutes1);
			this.productionSchedulerControl.Views.WeekView.ResourcesPerPage = 10;
			this.productionSchedulerControl.Views.WorkWeekView.ResourcesPerPage = 10;
			this.productionSchedulerControl.Views.WorkWeekView.TimeRulers.Add(TimeRuler3);
			//
			//BarManager1
			//
			this.BarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.CommonBar1, this.PrintBar1, this.AppointmentBar1, this.NavigatorBar1, this.ArrangeBar1, this.GroupByBar1, this.TimeScaleBar1, this.LayoutBar1, this.ActionsBar1, this.OptionsBar1});
			this.BarManager1.DockControls.Add(this.barDockControlTop);
			this.BarManager1.DockControls.Add(this.barDockControlBottom);
			this.BarManager1.DockControls.Add(this.barDockControlLeft);
			this.BarManager1.DockControls.Add(this.barDockControlRight);
			this.BarManager1.Form = this;
			this.BarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.OpenScheduleItem1, this.SaveScheduleItem1, this.PrintItem1, this.PrintPageSetupItem1, this.NewAppointmentItem1, this.NewRecurringAppointmentItem1, this.NavigateViewBackwardItem1, this.NavigateViewForwardItem1, this.GotoTodayItem1, this.ViewZoomInItem1, this.ViewZoomOutItem1, this.SwitchToDayViewItem1, this.SwitchToWorkWeekViewItem1, this.SwitchToWeekViewItem1, this.SwitchToFullWeekViewItem1, this.SwitchToMonthViewItem1, this.SwitchToTimelineViewItem1, this.SwitchToGanttViewItem1, this.GroupByNoneItem1, this.GroupByDateItem1, this.GroupByResourceItem1, this.SwitchTimeScalesItem1, this.ChangeScaleWidthItem1, this.SwitchTimeScalesCaptionItem1, this.SwitchCompressWeekendItem1, this.SwitchShowWorkTimeOnlyItem1, this.SwitchCellsAutoHeightItem1, this.ChangeSnapToCellsUIItem1, this.EditAppointmentQueryItem1, this.EditOccurrenceUICommandItem1, this.EditSeriesUICommandItem1, this.DeleteAppointmentsItem1, this.DeleteOccurrenceItem1, this.DeleteSeriesItem1, this.SplitAppointmentItem1, this.ChangeAppointmentStatusItem1, this.ChangeAppointmentLabelItem1, this.ToggleRecurrenceItem1, this.ChangeAppointmentReminderItem1, this.reportDateBarEditItem, this.reportShiftBarEditItem, this.openReportBarButtonItem});
			this.BarManager1.MaxItemId = 43;
			this.BarManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {this.RepositoryItemSpinEdit1, this.RepositoryItemDuration1, this.RepositoryItemDateEdit1, this.RepositoryItemComboBox1});
			//
			//CommonBar1
			//
			this.CommonBar1.Control = this.productionSchedulerControl;
			this.CommonBar1.DockCol = 0;
			this.CommonBar1.DockRow = 0;
			this.CommonBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.CommonBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.OpenScheduleItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.SaveScheduleItem1)
			});
			//
			//OpenScheduleItem1
			//
			this.OpenScheduleItem1.Id = 0;
			this.OpenScheduleItem1.Name = "OpenScheduleItem1";
			//
			//SaveScheduleItem1
			//
			this.SaveScheduleItem1.Id = 1;
			this.SaveScheduleItem1.Name = "SaveScheduleItem1";
			//
			//PrintBar1
			//
			this.PrintBar1.BarName = "";
			this.PrintBar1.Control = this.productionSchedulerControl;
			this.PrintBar1.DockCol = 1;
			this.PrintBar1.DockRow = 0;
			this.PrintBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.PrintBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.reportDateBarEditItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.reportShiftBarEditItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.openReportBarButtonItem)
			});
			this.PrintBar1.Offset = 50;
			this.PrintBar1.Text = "";
			//
			//reportDateBarEditItem
			//
			this.reportDateBarEditItem.Caption = "Report Date";
			this.reportDateBarEditItem.Edit = this.RepositoryItemDateEdit1;
			this.reportDateBarEditItem.EditWidth = 106;
			this.reportDateBarEditItem.Id = 40;
			this.reportDateBarEditItem.Name = "reportDateBarEditItem";
			//
			//RepositoryItemDateEdit1
			//
			this.RepositoryItemDateEdit1.AutoHeight = false;
			this.RepositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1";
			//
			//reportShiftBarEditItem
			//
			this.reportShiftBarEditItem.Caption = "Report Shift";
			this.reportShiftBarEditItem.Edit = this.RepositoryItemComboBox1;
			this.reportShiftBarEditItem.EditWidth = 109;
			this.reportShiftBarEditItem.Id = 41;
			this.reportShiftBarEditItem.Name = "reportShiftBarEditItem";
			//
			//RepositoryItemComboBox1
			//
			this.RepositoryItemComboBox1.AutoHeight = false;
			this.RepositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.RepositoryItemComboBox1.Items.AddRange(new object[] {"Shift 1", "Shift 2", "Shift 3"});
			this.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1";
			//
			//openReportBarButtonItem
			//
			this.openReportBarButtonItem.Caption = "Preview Report";
			this.openReportBarButtonItem.Glyph = (System.Drawing.Image)resources.GetObject("openReportBarButtonItem.Glyph");
			this.openReportBarButtonItem.Id = 42;
			this.openReportBarButtonItem.LargeGlyph = (System.Drawing.Image)resources.GetObject("openReportBarButtonItem.LargeGlyph");
			this.openReportBarButtonItem.Name = "openReportBarButtonItem";
			//
			//AppointmentBar1
			//
			this.AppointmentBar1.Control = this.productionSchedulerControl;
			this.AppointmentBar1.DockCol = 3;
			this.AppointmentBar1.DockRow = 0;
			this.AppointmentBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.AppointmentBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.NewAppointmentItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.NewRecurringAppointmentItem1)
			});
			this.AppointmentBar1.Offset = 215;
			//
			//NewAppointmentItem1
			//
			this.NewAppointmentItem1.Caption = "New Production Schedule";
			this.NewAppointmentItem1.Id = 5;
			this.NewAppointmentItem1.Name = "NewAppointmentItem1";
			ToolTipTitleItem1.Text = "New Production Schedule";
			ToolTipItem1.LeftIndent = 6;
			ToolTipItem1.Text = "Create a new production schedule";
			SuperToolTip1.Items.Add(ToolTipTitleItem1);
			SuperToolTip1.Items.Add(ToolTipItem1);
			this.NewAppointmentItem1.SuperTip = SuperToolTip1;
			//
			//NewRecurringAppointmentItem1
			//
			this.NewRecurringAppointmentItem1.Id = 6;
			this.NewRecurringAppointmentItem1.Name = "NewRecurringAppointmentItem1";
			this.NewRecurringAppointmentItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			//
			//NavigatorBar1
			//
			this.NavigatorBar1.Control = this.productionSchedulerControl;
			this.NavigatorBar1.DockCol = 4;
			this.NavigatorBar1.DockRow = 0;
			this.NavigatorBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.NavigatorBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.NavigateViewBackwardItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.NavigateViewForwardItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.GotoTodayItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.ViewZoomInItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.ViewZoomOutItem1)
			});
			this.NavigatorBar1.Offset = 285;
			//
			//NavigateViewBackwardItem1
			//
			this.NavigateViewBackwardItem1.Id = 7;
			this.NavigateViewBackwardItem1.Name = "NavigateViewBackwardItem1";
			//
			//NavigateViewForwardItem1
			//
			this.NavigateViewForwardItem1.Id = 8;
			this.NavigateViewForwardItem1.Name = "NavigateViewForwardItem1";
			//
			//GotoTodayItem1
			//
			this.GotoTodayItem1.Id = 9;
			this.GotoTodayItem1.Name = "GotoTodayItem1";
			//
			//ViewZoomInItem1
			//
			this.ViewZoomInItem1.Id = 10;
			this.ViewZoomInItem1.Name = "ViewZoomInItem1";
			//
			//ViewZoomOutItem1
			//
			this.ViewZoomOutItem1.Id = 11;
			this.ViewZoomOutItem1.Name = "ViewZoomOutItem1";
			//
			//ArrangeBar1
			//
			this.ArrangeBar1.Control = this.productionSchedulerControl;
			this.ArrangeBar1.DockCol = 2;
			this.ArrangeBar1.DockRow = 1;
			this.ArrangeBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.ArrangeBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.SwitchToDayViewItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.SwitchToWorkWeekViewItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.SwitchToWeekViewItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.SwitchToFullWeekViewItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.SwitchToMonthViewItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.SwitchToTimelineViewItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.SwitchToGanttViewItem1)
			});
			this.ArrangeBar1.Offset = 250;
			//
			//SwitchToDayViewItem1
			//
			this.SwitchToDayViewItem1.Id = 12;
			this.SwitchToDayViewItem1.Name = "SwitchToDayViewItem1";
			//
			//SwitchToWorkWeekViewItem1
			//
			this.SwitchToWorkWeekViewItem1.Id = 13;
			this.SwitchToWorkWeekViewItem1.Name = "SwitchToWorkWeekViewItem1";
			//
			//SwitchToWeekViewItem1
			//
			this.SwitchToWeekViewItem1.Id = 14;
			this.SwitchToWeekViewItem1.Name = "SwitchToWeekViewItem1";
			//
			//SwitchToFullWeekViewItem1
			//
			this.SwitchToFullWeekViewItem1.Id = 15;
			this.SwitchToFullWeekViewItem1.Name = "SwitchToFullWeekViewItem1";
			//
			//SwitchToMonthViewItem1
			//
			this.SwitchToMonthViewItem1.Id = 16;
			this.SwitchToMonthViewItem1.Name = "SwitchToMonthViewItem1";
			//
			//SwitchToTimelineViewItem1
			//
			this.SwitchToTimelineViewItem1.Id = 17;
			this.SwitchToTimelineViewItem1.Name = "SwitchToTimelineViewItem1";
			//
			//SwitchToGanttViewItem1
			//
			this.SwitchToGanttViewItem1.Id = 18;
			this.SwitchToGanttViewItem1.Name = "SwitchToGanttViewItem1";
			this.SwitchToGanttViewItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			//
			//GroupByBar1
			//
			this.GroupByBar1.Control = this.productionSchedulerControl;
			this.GroupByBar1.DockCol = 5;
			this.GroupByBar1.DockRow = 0;
			this.GroupByBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.GroupByBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.GroupByNoneItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.GroupByDateItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.GroupByResourceItem1)
			});
			this.GroupByBar1.Offset = 460;
			//
			//GroupByNoneItem1
			//
			this.GroupByNoneItem1.Id = 19;
			this.GroupByNoneItem1.Name = "GroupByNoneItem1";
			//
			//GroupByDateItem1
			//
			this.GroupByDateItem1.Id = 20;
			this.GroupByDateItem1.Name = "GroupByDateItem1";
			//
			//GroupByResourceItem1
			//
			this.GroupByResourceItem1.Id = 21;
			this.GroupByResourceItem1.Name = "GroupByResourceItem1";
			//
			//TimeScaleBar1
			//
			this.TimeScaleBar1.Control = this.productionSchedulerControl;
			this.TimeScaleBar1.DockCol = 0;
			this.TimeScaleBar1.DockRow = 1;
			this.TimeScaleBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.TimeScaleBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.SwitchTimeScalesItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.ChangeScaleWidthItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.SwitchTimeScalesCaptionItem1)
			});
			//
			//SwitchTimeScalesItem1
			//
			this.SwitchTimeScalesItem1.Id = 22;
			this.SwitchTimeScalesItem1.Name = "SwitchTimeScalesItem1";
			//
			//ChangeScaleWidthItem1
			//
			this.ChangeScaleWidthItem1.Edit = this.RepositoryItemSpinEdit1;
			this.ChangeScaleWidthItem1.Id = 23;
			this.ChangeScaleWidthItem1.Name = "ChangeScaleWidthItem1";
			this.ChangeScaleWidthItem1.UseCommandCaption = true;
			//
			//RepositoryItemSpinEdit1
			//
			this.RepositoryItemSpinEdit1.AutoHeight = false;
			this.RepositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.RepositoryItemSpinEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
			this.RepositoryItemSpinEdit1.MaxValue = new decimal(new int[] {200, 0, 0, 0});
			this.RepositoryItemSpinEdit1.MinValue = new decimal(new int[] {10, 0, 0, 0});
			this.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1";
			//
			//SwitchTimeScalesCaptionItem1
			//
			this.SwitchTimeScalesCaptionItem1.Id = 24;
			this.SwitchTimeScalesCaptionItem1.Name = "SwitchTimeScalesCaptionItem1";
			//
			//LayoutBar1
			//
			this.LayoutBar1.Control = this.productionSchedulerControl;
			this.LayoutBar1.DockCol = 2;
			this.LayoutBar1.DockRow = 0;
			this.LayoutBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.LayoutBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.SwitchCompressWeekendItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.SwitchShowWorkTimeOnlyItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.SwitchCellsAutoHeightItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.ChangeSnapToCellsUIItem1)
			});
			this.LayoutBar1.Offset = 107;
			//
			//SwitchCompressWeekendItem1
			//
			this.SwitchCompressWeekendItem1.Id = 25;
			this.SwitchCompressWeekendItem1.Name = "SwitchCompressWeekendItem1";
			//
			//SwitchShowWorkTimeOnlyItem1
			//
			this.SwitchShowWorkTimeOnlyItem1.Id = 26;
			this.SwitchShowWorkTimeOnlyItem1.Name = "SwitchShowWorkTimeOnlyItem1";
			//
			//SwitchCellsAutoHeightItem1
			//
			this.SwitchCellsAutoHeightItem1.Id = 27;
			this.SwitchCellsAutoHeightItem1.Name = "SwitchCellsAutoHeightItem1";
			//
			//ChangeSnapToCellsUIItem1
			//
			this.ChangeSnapToCellsUIItem1.Id = 28;
			this.ChangeSnapToCellsUIItem1.Name = "ChangeSnapToCellsUIItem1";
			//
			//ActionsBar1
			//
			this.ActionsBar1.Control = this.productionSchedulerControl;
			this.ActionsBar1.DockCol = 1;
			this.ActionsBar1.DockRow = 1;
			this.ActionsBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.ActionsBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.EditAppointmentQueryItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.DeleteAppointmentsItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.SplitAppointmentItem1)
			});
			this.ActionsBar1.Offset = 175;
			//
			//EditAppointmentQueryItem1
			//
			this.EditAppointmentQueryItem1.Id = 29;
			this.EditAppointmentQueryItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.EditOccurrenceUICommandItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.EditSeriesUICommandItem1)
			});
			this.EditAppointmentQueryItem1.Name = "EditAppointmentQueryItem1";
			this.EditAppointmentQueryItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			ToolTipTitleItem2.Text = "&Open";
			ToolTipItem2.LeftIndent = 6;
			ToolTipItem2.Text = "Open the selected production schedule.";
			SuperToolTip2.Items.Add(ToolTipTitleItem2);
			SuperToolTip2.Items.Add(ToolTipItem2);
			this.EditAppointmentQueryItem1.SuperTip = SuperToolTip2;
			//
			//EditOccurrenceUICommandItem1
			//
			this.EditOccurrenceUICommandItem1.Id = 30;
			this.EditOccurrenceUICommandItem1.Name = "EditOccurrenceUICommandItem1";
			//
			//EditSeriesUICommandItem1
			//
			this.EditSeriesUICommandItem1.Id = 31;
			this.EditSeriesUICommandItem1.Name = "EditSeriesUICommandItem1";
			//
			//DeleteAppointmentsItem1
			//
			this.DeleteAppointmentsItem1.Id = 32;
			this.DeleteAppointmentsItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.DeleteOccurrenceItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.DeleteSeriesItem1)
			});
			this.DeleteAppointmentsItem1.Name = "DeleteAppointmentsItem1";
			this.DeleteAppointmentsItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			ToolTipTitleItem3.Text = "&Delete";
			ToolTipItem3.LeftIndent = 6;
			ToolTipItem3.Text = "Delete the selected production schedule(s).";
			SuperToolTip3.Items.Add(ToolTipTitleItem3);
			SuperToolTip3.Items.Add(ToolTipItem3);
			this.DeleteAppointmentsItem1.SuperTip = SuperToolTip3;
			//
			//DeleteOccurrenceItem1
			//
			this.DeleteOccurrenceItem1.Id = 33;
			this.DeleteOccurrenceItem1.Name = "DeleteOccurrenceItem1";
			//
			//DeleteSeriesItem1
			//
			this.DeleteSeriesItem1.Id = 34;
			this.DeleteSeriesItem1.Name = "DeleteSeriesItem1";
			//
			//SplitAppointmentItem1
			//
			this.SplitAppointmentItem1.Id = 35;
			this.SplitAppointmentItem1.Name = "SplitAppointmentItem1";
			ToolTipTitleItem4.Text = "Split";
			ToolTipItem4.LeftIndent = 6;
			ToolTipItem4.Text = "Split the selected production schedule in two by dragging a splitter line.";
			SuperToolTip4.Items.Add(ToolTipTitleItem4);
			SuperToolTip4.Items.Add(ToolTipItem4);
			this.SplitAppointmentItem1.SuperTip = SuperToolTip4;
			this.SplitAppointmentItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			//
			//OptionsBar1
			//
			this.OptionsBar1.Control = this.productionSchedulerControl;
			this.OptionsBar1.DockCol = 3;
			this.OptionsBar1.DockRow = 1;
			this.OptionsBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.OptionsBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.ChangeAppointmentStatusItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.ChangeAppointmentLabelItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.ToggleRecurrenceItem1),
				new DevExpress.XtraBars.LinkPersistInfo(this.ChangeAppointmentReminderItem1)
			});
			this.OptionsBar1.Offset = 450;
			this.OptionsBar1.Visible = false;
			//
			//ChangeAppointmentStatusItem1
			//
			this.ChangeAppointmentStatusItem1.Id = 36;
			this.ChangeAppointmentStatusItem1.Name = "ChangeAppointmentStatusItem1";
			//
			//ChangeAppointmentLabelItem1
			//
			this.ChangeAppointmentLabelItem1.Id = 37;
			this.ChangeAppointmentLabelItem1.Name = "ChangeAppointmentLabelItem1";
			this.ChangeAppointmentLabelItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			//
			//ToggleRecurrenceItem1
			//
			this.ToggleRecurrenceItem1.Id = 38;
			this.ToggleRecurrenceItem1.Name = "ToggleRecurrenceItem1";
			this.ToggleRecurrenceItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			//
			//ChangeAppointmentReminderItem1
			//
			this.ChangeAppointmentReminderItem1.Edit = this.RepositoryItemDuration1;
			this.ChangeAppointmentReminderItem1.Id = 39;
			this.ChangeAppointmentReminderItem1.Name = "ChangeAppointmentReminderItem1";
			this.ChangeAppointmentReminderItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption;
			this.ChangeAppointmentReminderItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			//
			//RepositoryItemDuration1
			//
			this.RepositoryItemDuration1.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
			this.RepositoryItemDuration1.AutoHeight = false;
			this.RepositoryItemDuration1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.RepositoryItemDuration1.DisabledStateText = null;
			this.RepositoryItemDuration1.Name = "RepositoryItemDuration1";
			this.RepositoryItemDuration1.NullValuePromptShowForEmptyValue = true;
			this.RepositoryItemDuration1.ShowEmptyItem = true;
			this.RepositoryItemDuration1.ValidateOnEnterKey = true;
			//
			//barDockControlTop
			//
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Size = new System.Drawing.Size(1134, 62);
			//
			//barDockControlBottom
			//
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 713);
			this.barDockControlBottom.Size = new System.Drawing.Size(1134, 0);
			//
			//barDockControlLeft
			//
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 62);
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 651);
			//
			//barDockControlRight
			//
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(1134, 62);
			this.barDockControlRight.Size = new System.Drawing.Size(0, 651);
			//
			//PrintItem1
			//
			this.PrintItem1.Id = 3;
			this.PrintItem1.Name = "PrintItem1";
			this.PrintItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			//
			//PrintPageSetupItem1
			//
			this.PrintPageSetupItem1.Id = 4;
			this.PrintPageSetupItem1.Name = "PrintPageSetupItem1";
			this.PrintPageSetupItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			//
			//SchedulerStorage1
			//
			this.SchedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("MachineOperator", "MachineOperator"));
			this.SchedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("People", "People"));
			this.SchedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("PriorityLevel", "PriorityLevel"));
			this.SchedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("MustRun", "MustRun"));
			this.SchedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("ProductionItem", "ProductionItem!"));
			this.SchedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("Project", "Project!"));
			this.SchedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("ProjectDetail", "ProjectDetail!"));
			this.SchedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("Quantity", "Quantity"));
			this.SchedulerStorage1.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("ScheduleByQuantity", "ScheduleByQuantity"));
			this.SchedulerStorage1.Appointments.DataSource = this.productionScheduleXpCollection;
			this.SchedulerStorage1.Appointments.Mappings.Description = "ScheduleNote";
			this.SchedulerStorage1.Appointments.Mappings.End = "Finish";
			this.SchedulerStorage1.Appointments.Mappings.ResourceId = "MachineLine!Key";
			this.SchedulerStorage1.Appointments.Mappings.Start = "Start";
			this.SchedulerStorage1.Appointments.Mappings.Subject = "ScheduleTitle";
			this.SchedulerStorage1.Resources.DataSource = this.machineLinesXpCollection;
			this.SchedulerStorage1.Resources.Mappings.Caption = "MachineLineName";
			this.SchedulerStorage1.Resources.Mappings.Id = "MachineLineID";
			//
			//productionScheduleXpCollection
			//
			this.productionScheduleXpCollection.ObjectType = typeof(DXDAL.SPGData.ProductionSchedule);
			//
			//machineLinesXpCollection
			//
			this.machineLinesXpCollection.ObjectType = typeof(DXDAL.SPGData.MachineLine);
			//
			//scheduleProjectsSplitContainerControl
			//
			this.scheduleProjectsSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scheduleProjectsSplitContainerControl.Horizontal = false;
			this.scheduleProjectsSplitContainerControl.Location = new System.Drawing.Point(0, 62);
			this.scheduleProjectsSplitContainerControl.Name = "scheduleProjectsSplitContainerControl";
			this.scheduleProjectsSplitContainerControl.Panel1.Controls.Add(this.scheduleResourcesplitContainerControl);
			this.scheduleProjectsSplitContainerControl.Panel1.Text = "Panel1";
			this.scheduleProjectsSplitContainerControl.Panel2.Controls.Add(this.projectsItemReferenceSplitContainerControl);
			this.scheduleProjectsSplitContainerControl.Panel2.Text = "Panel2";
			this.scheduleProjectsSplitContainerControl.Size = new System.Drawing.Size(1134, 651);
			this.scheduleProjectsSplitContainerControl.SplitterPosition = 474;
			this.scheduleProjectsSplitContainerControl.TabIndex = 0;
			this.scheduleProjectsSplitContainerControl.Text = "SplitContainerControl1";
			//
			//scheduleResourcesplitContainerControl
			//
			this.scheduleResourcesplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scheduleResourcesplitContainerControl.Location = new System.Drawing.Point(0, 0);
			this.scheduleResourcesplitContainerControl.Name = "scheduleResourcesplitContainerControl";
			this.scheduleResourcesplitContainerControl.Panel1.Controls.Add(this.SplitContainerControl1);
			this.scheduleResourcesplitContainerControl.Panel1.Text = "Panel1";
			this.scheduleResourcesplitContainerControl.Panel2.Controls.Add(this.productionSchedulerControl);
			this.scheduleResourcesplitContainerControl.Panel2.Text = "Panel2";
			this.scheduleResourcesplitContainerControl.Size = new System.Drawing.Size(1134, 474);
			this.scheduleResourcesplitContainerControl.SplitterPosition = 182;
			this.scheduleResourcesplitContainerControl.TabIndex = 0;
			this.scheduleResourcesplitContainerControl.Text = "SplitContainerControl1";
			//
			//SplitContainerControl1
			//
			this.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainerControl1.Horizontal = false;
			this.SplitContainerControl1.Location = new System.Drawing.Point(0, 0);
			this.SplitContainerControl1.Name = "SplitContainerControl1";
			this.SplitContainerControl1.Panel1.Controls.Add(this.DateNavigator1);
			this.SplitContainerControl1.Panel1.Text = "Panel1";
			this.SplitContainerControl1.Panel2.Controls.Add(this.productionResourcesTree);
			this.SplitContainerControl1.Panel2.Text = "Panel2";
			this.SplitContainerControl1.Size = new System.Drawing.Size(182, 474);
			this.SplitContainerControl1.SplitterPosition = 171;
			this.SplitContainerControl1.TabIndex = 1;
			this.SplitContainerControl1.Text = "SplitContainerControl1";
			//
			//DateNavigator1
			//
			this.DateNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DateNavigator1.HighlightTodayCell = DevExpress.Utils.DefaultBoolean.Default;
			this.DateNavigator1.HotDate = null;
			this.DateNavigator1.Location = new System.Drawing.Point(0, 0);
			this.DateNavigator1.Name = "DateNavigator1";
			this.DateNavigator1.CellPadding = new System.Windows.Forms.Padding(2);
			this.DateNavigator1.SchedulerControl = this.productionSchedulerControl;
			this.DateNavigator1.Size = new System.Drawing.Size(182, 171);
			this.DateNavigator1.TabIndex = 0;
			//
			//productionResourcesTree
			//
			this.productionResourcesTree.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {this.colMachineLineName});
			this.productionResourcesTree.Dock = System.Windows.Forms.DockStyle.Fill;
			this.productionResourcesTree.Location = new System.Drawing.Point(0, 0);
			this.productionResourcesTree.MenuManager = this.BarManager1;
			this.productionResourcesTree.Name = "productionResourcesTree";
			this.productionResourcesTree.OptionsBehavior.Editable = false;
			this.productionResourcesTree.PreviewFieldName = "MachineLineName";
			this.productionResourcesTree.SchedulerControl = this.productionSchedulerControl;
			this.productionResourcesTree.Size = new System.Drawing.Size(182, 298);
			this.productionResourcesTree.TabIndex = 0;
			this.productionResourcesTree.VertScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Never;
			//
			//colMachineLineName
			//
			this.colMachineLineName.FieldName = "MachineLineName";
			this.colMachineLineName.Name = "colMachineLineName";
			this.colMachineLineName.Visible = true;
			this.colMachineLineName.VisibleIndex = 0;
			//
			//projectsItemReferenceSplitContainerControl
			//
			this.projectsItemReferenceSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.projectsItemReferenceSplitContainerControl.Location = new System.Drawing.Point(0, 0);
			this.projectsItemReferenceSplitContainerControl.Name = "projectsItemReferenceSplitContainerControl";
			this.projectsItemReferenceSplitContainerControl.Panel1.Controls.Add(this.projectsGridControl);
			this.projectsItemReferenceSplitContainerControl.Panel1.Text = "Panel1";
			this.projectsItemReferenceSplitContainerControl.Panel2.Controls.Add(this.itemReferenceGridControl);
			this.projectsItemReferenceSplitContainerControl.Panel2.Text = "Panel2";
			this.projectsItemReferenceSplitContainerControl.Size = new System.Drawing.Size(1134, 172);
			this.projectsItemReferenceSplitContainerControl.SplitterPosition = 554;
			this.projectsItemReferenceSplitContainerControl.TabIndex = 0;
			this.projectsItemReferenceSplitContainerControl.Text = "SplitContainerControl1";
			//
			//SchedulerBarController1
			//
			this.SchedulerBarController1.BarItems.Add(this.OpenScheduleItem1);
			this.SchedulerBarController1.BarItems.Add(this.SaveScheduleItem1);
			this.SchedulerBarController1.BarItems.Add(this.PrintItem1);
			this.SchedulerBarController1.BarItems.Add(this.PrintPageSetupItem1);
			this.SchedulerBarController1.BarItems.Add(this.NewAppointmentItem1);
			this.SchedulerBarController1.BarItems.Add(this.NewRecurringAppointmentItem1);
			this.SchedulerBarController1.BarItems.Add(this.NavigateViewBackwardItem1);
			this.SchedulerBarController1.BarItems.Add(this.NavigateViewForwardItem1);
			this.SchedulerBarController1.BarItems.Add(this.GotoTodayItem1);
			this.SchedulerBarController1.BarItems.Add(this.ViewZoomInItem1);
			this.SchedulerBarController1.BarItems.Add(this.ViewZoomOutItem1);
			this.SchedulerBarController1.BarItems.Add(this.SwitchToDayViewItem1);
			this.SchedulerBarController1.BarItems.Add(this.SwitchToWorkWeekViewItem1);
			this.SchedulerBarController1.BarItems.Add(this.SwitchToWeekViewItem1);
			this.SchedulerBarController1.BarItems.Add(this.SwitchToFullWeekViewItem1);
			this.SchedulerBarController1.BarItems.Add(this.SwitchToMonthViewItem1);
			this.SchedulerBarController1.BarItems.Add(this.SwitchToTimelineViewItem1);
			this.SchedulerBarController1.BarItems.Add(this.SwitchToGanttViewItem1);
			this.SchedulerBarController1.BarItems.Add(this.GroupByNoneItem1);
			this.SchedulerBarController1.BarItems.Add(this.GroupByDateItem1);
			this.SchedulerBarController1.BarItems.Add(this.GroupByResourceItem1);
			this.SchedulerBarController1.BarItems.Add(this.SwitchTimeScalesItem1);
			this.SchedulerBarController1.BarItems.Add(this.ChangeScaleWidthItem1);
			this.SchedulerBarController1.BarItems.Add(this.SwitchTimeScalesCaptionItem1);
			this.SchedulerBarController1.BarItems.Add(this.SwitchCompressWeekendItem1);
			this.SchedulerBarController1.BarItems.Add(this.SwitchShowWorkTimeOnlyItem1);
			this.SchedulerBarController1.BarItems.Add(this.SwitchCellsAutoHeightItem1);
			this.SchedulerBarController1.BarItems.Add(this.ChangeSnapToCellsUIItem1);
			this.SchedulerBarController1.BarItems.Add(this.EditAppointmentQueryItem1);
			this.SchedulerBarController1.BarItems.Add(this.EditOccurrenceUICommandItem1);
			this.SchedulerBarController1.BarItems.Add(this.EditSeriesUICommandItem1);
			this.SchedulerBarController1.BarItems.Add(this.DeleteAppointmentsItem1);
			this.SchedulerBarController1.BarItems.Add(this.DeleteOccurrenceItem1);
			this.SchedulerBarController1.BarItems.Add(this.DeleteSeriesItem1);
			this.SchedulerBarController1.BarItems.Add(this.SplitAppointmentItem1);
			this.SchedulerBarController1.BarItems.Add(this.ChangeAppointmentStatusItem1);
			this.SchedulerBarController1.BarItems.Add(this.ChangeAppointmentLabelItem1);
			this.SchedulerBarController1.BarItems.Add(this.ToggleRecurrenceItem1);
			this.SchedulerBarController1.BarItems.Add(this.ChangeAppointmentReminderItem1);
			this.SchedulerBarController1.Control = this.productionSchedulerControl;
			//
			//ProjectSchedulingXtraForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1134, 713);
			this.Controls.Add(this.scheduleProjectsSplitContainerControl);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Name = "ProjectSchedulingXtraForm";
			this.Text = "Project Scheduling";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)this.locationInventoryGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemReferenceGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemReferenceXpCollection).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.projectProductionScheduleGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.projectsGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.projectDetailsXpCollection).EndInit();
			((System.ComponentModel.ISupportInitialize)this.projectDetailsGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionSchedulerControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.BarManager1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemDateEdit1.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemDateEdit1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemComboBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemSpinEdit1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemDuration1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.SchedulerStorage1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionScheduleXpCollection).EndInit();
			((System.ComponentModel.ISupportInitialize)this.machineLinesXpCollection).EndInit();
			((System.ComponentModel.ISupportInitialize)this.scheduleProjectsSplitContainerControl).EndInit();
			this.scheduleProjectsSplitContainerControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.scheduleResourcesplitContainerControl).EndInit();
			this.scheduleResourcesplitContainerControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.SplitContainerControl1).EndInit();
			this.SplitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.DateNavigator1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionResourcesTree).EndInit();
			((System.ComponentModel.ISupportInitialize)this.projectsItemReferenceSplitContainerControl).EndInit();
			this.projectsItemReferenceSplitContainerControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.SchedulerBarController1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			base.Load += new System.EventHandler(ProjectSchedulingXtraForm_Load);
			productionSchedulerControl.EditAppointmentFormShowing += new DevExpress.XtraScheduler.AppointmentFormEventHandler(productionSchedulerControl_EditAppointmentFormShowing);
			productionSchedulerControl.PopupMenuShowing += new DevExpress.XtraScheduler.PopupMenuShowingEventHandler(productionSchedulerControl_PopupMenuShowing);
			productionSchedulerControl.DateNavigatorQueryActiveViewType += new DevExpress.XtraScheduler.DateNavigatorQueryActiveViewTypeHandler(productionSchedulerControl_DateNavigatorQueryActiveViewType);
			scheduleProjectsSplitContainerControl.Resize += new System.EventHandler(scheduleProjectsSplitContainerControl_Resize);
			projectDetailsGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(projectDetailsGridView_FocusedRowChanged);
			itemGridView.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(itemGridView_PopupMenuShowing);
			productionSchedulerControl.CustomDrawResourceHeader += new DevExpress.XtraScheduler.CustomDrawObjectEventHandler(productionSchedulerControl_CustomDrawResourceHeader);
			openReportBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(openReportBarButtonItem_ItemClick);
			this.Closing += new System.ComponentModel.CancelEventHandler(ProjectSchedulingXtraForm_Closing);
			productionSchedulerControl.GotFocus += new System.EventHandler(productionSchedulerControl_GotFocus);
		}
		internal DevExpress.XtraEditors.SplitContainerControl scheduleProjectsSplitContainerControl;
		internal DevExpress.XtraEditors.SplitContainerControl scheduleResourcesplitContainerControl;
		internal DevExpress.XtraScheduler.UI.ResourcesTree productionResourcesTree;
		internal DevExpress.XtraEditors.SplitContainerControl projectsItemReferenceSplitContainerControl;
		internal DevExpress.XtraGrid.GridControl projectsGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView projectDetailsGridView;
		internal DevExpress.XtraGrid.GridControl itemReferenceGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView itemGridView;
		internal DevExpress.XtraScheduler.SchedulerControl productionSchedulerControl;
		internal DevExpress.XtraScheduler.SchedulerStorage SchedulerStorage1;
		internal DevExpress.XtraBars.BarManager BarManager1;
		internal DevExpress.XtraScheduler.UI.CommonBar CommonBar1;
		internal DevExpress.XtraScheduler.UI.OpenScheduleItem OpenScheduleItem1;
		internal DevExpress.XtraScheduler.UI.SaveScheduleItem SaveScheduleItem1;
		internal DevExpress.XtraScheduler.UI.PrintBar PrintBar1;
		internal DevExpress.XtraScheduler.UI.PrintItem PrintItem1;
		internal DevExpress.XtraScheduler.UI.PrintPageSetupItem PrintPageSetupItem1;
		internal DevExpress.XtraScheduler.UI.AppointmentBar AppointmentBar1;
		internal DevExpress.XtraScheduler.UI.NewAppointmentItem NewAppointmentItem1;
		internal DevExpress.XtraScheduler.UI.NewRecurringAppointmentItem NewRecurringAppointmentItem1;
		internal DevExpress.XtraScheduler.UI.NavigatorBar NavigatorBar1;
		internal DevExpress.XtraScheduler.UI.NavigateViewBackwardItem NavigateViewBackwardItem1;
		internal DevExpress.XtraScheduler.UI.NavigateViewForwardItem NavigateViewForwardItem1;
		internal DevExpress.XtraScheduler.UI.GotoTodayItem GotoTodayItem1;
		internal DevExpress.XtraScheduler.UI.ViewZoomInItem ViewZoomInItem1;
		internal DevExpress.XtraScheduler.UI.ViewZoomOutItem ViewZoomOutItem1;
		internal DevExpress.XtraScheduler.UI.ArrangeBar ArrangeBar1;
		internal DevExpress.XtraScheduler.UI.SwitchToDayViewItem SwitchToDayViewItem1;
		internal DevExpress.XtraScheduler.UI.SwitchToWorkWeekViewItem SwitchToWorkWeekViewItem1;
		internal DevExpress.XtraScheduler.UI.SwitchToWeekViewItem SwitchToWeekViewItem1;
		internal DevExpress.XtraScheduler.UI.SwitchToFullWeekViewItem SwitchToFullWeekViewItem1;
		internal DevExpress.XtraScheduler.UI.SwitchToMonthViewItem SwitchToMonthViewItem1;
		internal DevExpress.XtraScheduler.UI.SwitchToTimelineViewItem SwitchToTimelineViewItem1;
		internal DevExpress.XtraScheduler.UI.SwitchToGanttViewItem SwitchToGanttViewItem1;
		internal DevExpress.XtraScheduler.UI.GroupByBar GroupByBar1;
		internal DevExpress.XtraScheduler.UI.GroupByNoneItem GroupByNoneItem1;
		internal DevExpress.XtraScheduler.UI.GroupByDateItem GroupByDateItem1;
		internal DevExpress.XtraScheduler.UI.GroupByResourceItem GroupByResourceItem1;
		internal DevExpress.XtraScheduler.UI.TimeScaleBar TimeScaleBar1;
		internal DevExpress.XtraScheduler.UI.SwitchTimeScalesItem SwitchTimeScalesItem1;
		internal DevExpress.XtraScheduler.UI.ChangeScaleWidthItem ChangeScaleWidthItem1;
		internal DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit RepositoryItemSpinEdit1;
		internal DevExpress.XtraScheduler.UI.SwitchTimeScalesCaptionItem SwitchTimeScalesCaptionItem1;
		internal DevExpress.XtraScheduler.UI.LayoutBar LayoutBar1;
		internal DevExpress.XtraScheduler.UI.SwitchCompressWeekendItem SwitchCompressWeekendItem1;
		internal DevExpress.XtraScheduler.UI.SwitchShowWorkTimeOnlyItem SwitchShowWorkTimeOnlyItem1;
		internal DevExpress.XtraScheduler.UI.SwitchCellsAutoHeightItem SwitchCellsAutoHeightItem1;
		internal DevExpress.XtraScheduler.UI.ChangeSnapToCellsUIItem ChangeSnapToCellsUIItem1;
		internal DevExpress.XtraScheduler.UI.ActionsBar ActionsBar1;
		internal DevExpress.XtraScheduler.UI.EditAppointmentQueryItem EditAppointmentQueryItem1;
		internal DevExpress.XtraScheduler.UI.EditOccurrenceUICommandItem EditOccurrenceUICommandItem1;
		internal DevExpress.XtraScheduler.UI.EditSeriesUICommandItem EditSeriesUICommandItem1;
		internal DevExpress.XtraScheduler.UI.DeleteAppointmentsItem DeleteAppointmentsItem1;
		internal DevExpress.XtraScheduler.UI.DeleteOccurrenceItem DeleteOccurrenceItem1;
		internal DevExpress.XtraScheduler.UI.DeleteSeriesItem DeleteSeriesItem1;
		internal DevExpress.XtraScheduler.UI.SplitAppointmentItem SplitAppointmentItem1;
		internal DevExpress.XtraScheduler.UI.OptionsBar OptionsBar1;
		internal DevExpress.XtraScheduler.UI.ChangeAppointmentStatusItem ChangeAppointmentStatusItem1;
		internal DevExpress.XtraScheduler.UI.ChangeAppointmentLabelItem ChangeAppointmentLabelItem1;
		internal DevExpress.XtraScheduler.UI.ToggleRecurrenceItem ToggleRecurrenceItem1;
		internal DevExpress.XtraScheduler.UI.ChangeAppointmentReminderItem ChangeAppointmentReminderItem1;
		internal DevExpress.XtraScheduler.UI.RepositoryItemDuration RepositoryItemDuration1;
		internal DevExpress.XtraBars.BarDockControl barDockControlTop;
		internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
		internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
		internal DevExpress.XtraBars.BarDockControl barDockControlRight;
		internal DevExpress.XtraScheduler.DateNavigator DateNavigator1;
		internal DevExpress.XtraScheduler.UI.SchedulerBarController SchedulerBarController1;
		internal DevExpress.Xpo.XPCollection productionScheduleXpCollection;
		internal DevExpress.Xpo.XPCollection machineLinesXpCollection;
		internal DevExpress.XtraScheduler.Native.ResourceTreeColumn colMachineLineName;
		internal DevExpress.XtraEditors.SplitContainerControl SplitContainerControl1;
		internal DevExpress.Xpo.XPCollection projectDetailsXpCollection;
		internal DevExpress.XtraGrid.Columns.GridColumn colOid;
		internal DevExpress.XtraGrid.Columns.GridColumn colHasChanges;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn2;
		internal DevExpress.XtraGrid.Columns.GridColumn colCustomerPO;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn3;
		internal DevExpress.XtraGrid.Columns.GridColumn colProjectItemID;
		internal DevExpress.XtraGrid.Columns.GridColumn colUnitsRequested;
		internal DevExpress.XtraGrid.Columns.GridColumn colBagsRequested;
		internal DevExpress.XtraGrid.Columns.GridColumn colPalletsRequested;
		internal DevExpress.XtraGrid.Columns.GridColumn colAllowOverrun;
		internal DevExpress.XtraGrid.Columns.GridColumn colUnitsProduced;
		internal DevExpress.XtraGrid.Columns.GridColumn colUnitsNeeded;
		internal DevExpress.XtraGrid.Columns.GridColumn colBagsProduced;
		internal DevExpress.XtraGrid.Columns.GridColumn colPalletsProduced;
		internal DevExpress.XtraGrid.Columns.GridColumn colPercentageComplete;
		internal DevExpress.XtraGrid.Columns.GridColumn colEstimatedShifts;
		internal DevExpress.XtraGrid.Columns.GridColumn colItemNumber;
		internal DevExpress.Xpo.XPCollection itemReferenceXpCollection;
		internal DevExpress.XtraGrid.Columns.GridColumn colItemID;
		internal DevExpress.XtraGrid.Columns.GridColumn colItemCode;
		internal DevExpress.XtraGrid.Columns.GridColumn colItemDescription;
		internal DevExpress.XtraGrid.Columns.GridColumn colItemType;
		internal DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn6;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn7;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn8;
		internal DevExpress.XtraGrid.Columns.GridColumn colItemProdStandard;
		internal DevExpress.XtraGrid.Columns.GridColumn colintQtyPerUnit;
		internal DevExpress.XtraGrid.Columns.GridColumn colstrEnteredBy;
		internal DevExpress.XtraGrid.Columns.GridColumn coldtmEnteredOn;
		internal DevExpress.XtraGrid.Columns.GridColumn colintUnitsPerCase;
		internal DevExpress.XtraGrid.Columns.GridColumn colintUnitsPerPallet;
		internal DevExpress.XtraGrid.Columns.GridColumn colintCasesPerPallet;
		internal DevExpress.XtraGrid.Columns.GridColumn colCaseGrossWeight;
		internal DevExpress.XtraGrid.Columns.GridColumn colPackageCode;
		internal DevExpress.XtraGrid.Columns.GridColumn colCaseCode;
		internal DevExpress.XtraGrid.Columns.GridColumn colRequiredWeight;
		internal DevExpress.XtraGrid.Columns.GridColumn colMAV;
		internal DevExpress.XtraGrid.Columns.GridColumn colCasesPerLayer;
		internal DevExpress.XtraGrid.Columns.GridColumn colLayersPerPallet;
		internal DevExpress.XtraGrid.Columns.GridColumn colShelfLife;
		internal DevExpress.XtraGrid.Columns.GridColumn colInstructions;
		internal DevExpress.XtraGrid.Columns.GridColumn colPalletPattern;
		internal DevExpress.XtraGrid.Columns.GridColumn colInactive;
		internal DevExpress.XtraGrid.Columns.GridColumn colPackers;
		internal DevExpress.XtraGrid.Columns.GridColumn colUPC;
		internal DevExpress.XtraGrid.Columns.GridColumn colBagsPerCase;
		internal DevExpress.XtraGrid.Columns.GridColumn colTotalQuantityOnHand;
		internal DevExpress.XtraGrid.Views.Grid.GridView locationInventoryGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn colLocationCode;
		internal DevExpress.XtraGrid.Columns.GridColumn colQuantityOnHand;
		internal DevExpress.XtraGrid.Columns.GridColumn colLocationName;
		internal DevExpress.XtraGrid.Views.Grid.GridView projectProductionScheduleGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn colStart;
		internal DevExpress.XtraGrid.Columns.GridColumn colFinish;
		internal DevExpress.XtraGrid.Columns.GridColumn colMachineLine;
		internal DevExpress.XtraGrid.Columns.GridColumn colPeople;
		internal DevExpress.XtraGrid.Columns.GridColumn colOperator;
		internal DevExpress.XtraGrid.Columns.GridColumn colItem;
		internal DevExpress.XtraGrid.Columns.GridColumn colQuantity;
		internal DevExpress.XtraGrid.Columns.GridColumn colUnitsScheduled;
		internal DevExpress.XtraGrid.Columns.GridColumn colUnitsNeededToSchedule;
		internal DevExpress.XtraBars.BarEditItem reportDateBarEditItem;
		internal DevExpress.XtraEditors.Repository.RepositoryItemDateEdit RepositoryItemDateEdit1;
		internal DevExpress.XtraBars.BarEditItem reportShiftBarEditItem;
		internal DevExpress.XtraEditors.Repository.RepositoryItemComboBox RepositoryItemComboBox1;
		internal DevExpress.XtraBars.BarButtonItem openReportBarButtonItem;
	}

}