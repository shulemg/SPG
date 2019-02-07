using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using DevExpress.Xpo;
using System.Deployment.Application;

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
	public partial class MainXtraForm : DevExpress.XtraEditors.XtraForm
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
		//<System.Diagnostics.DebuggerStepThrough()> _
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainXtraForm));
			DevExpress.Utils.SuperToolTip SuperToolTip1 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem ToolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.SuperToolTip SuperToolTip2 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipItem ToolTipItem1 = new DevExpress.Utils.ToolTipItem();
			DevExpress.Utils.SuperToolTip SuperToolTip3 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipItem ToolTipItem2 = new DevExpress.Utils.ToolTipItem();
			DevExpress.Utils.SuperToolTip SuperToolTip4 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem ToolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.SuperToolTip SuperToolTip5 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem ToolTipTitleItem3 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.SuperToolTip SuperToolTip6 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem ToolTipTitleItem4 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.SuperToolTip SuperToolTip7 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem ToolTipTitleItem5 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.SuperToolTip SuperToolTip8 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem ToolTipTitleItem6 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.SuperToolTip SuperToolTip9 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem ToolTipTitleItem7 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.SuperToolTip SuperToolTip10 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem ToolTipTitleItem8 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.SuperToolTip SuperToolTip11 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem ToolTipTitleItem9 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.SuperToolTip SuperToolTip12 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem ToolTipTitleItem10 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.SuperToolTip SuperToolTip13 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem ToolTipTitleItem11 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.SuperToolTip SuperToolTip14 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem ToolTipTitleItem12 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.SuperToolTip SuperToolTip15 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem ToolTipTitleItem13 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.SuperToolTip SuperToolTip16 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem ToolTipTitleItem14 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.SuperToolTip SuperToolTip17 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem ToolTipTitleItem15 = new DevExpress.Utils.ToolTipTitleItem();
			this.mainBarManager = new DevExpress.XtraBars.BarManager(this.components);
			this.mainMenuBar = new DevExpress.XtraBars.Bar();
			this.mainMenuFileBarSubItem = new DevExpress.XtraBars.BarSubItem();
			this.databaseBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.fileExitBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.mainMenuListsBarSubItem = new DevExpress.XtraBars.BarSubItem();
			this.listsCustomerBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.listsItemBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.listsItemPoolBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.listLocationsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.listsAddressesBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.listsMachineBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.listsShiftsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.listsCarriersBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.listVendorsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.listsEmployeesBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.listsShipmentConditionsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.lotCodeFormatsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.reasonCodesBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.mainMenuActivitiesBarSubItem = new DevExpress.XtraBars.BarSubItem();
			this.activitesRecieveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.activitiesProductionBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.listsInventoryBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.activitesShipBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.inventoryAdjustmentBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.activitiesLocationTransferBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.activitiesProjectsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.activitiesScheduleBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.mainMenuReportsBarSubItem = new DevExpress.XtraBars.BarSubItem();
			this.reportsCostingBarSubItem = new DevExpress.XtraBars.BarSubItem();
			this.costingDetailBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.costingDetailFullBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.costingSummaryBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.costingFinancialBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.reportsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.mainMenuToolsBarSubItem = new DevExpress.XtraBars.BarSubItem();
			this.toolsOptionsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.toolsSecurityBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.mainMenuWindowBarSubItem = new DevExpress.XtraBars.BarSubItem();
			this.windowCascadeBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.windowVerticalBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.windowHorizontalBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.windowArrangeBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.windowCloseBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.BarMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
			this.helpBarSubItem = new DevExpress.XtraBars.BarSubItem();
			this.mainToolBar = new DevExpress.XtraBars.Bar();
			this.mainToolbarCustomersBarLargeButtonItem = new DevExpress.XtraBars.BarLargeButtonItem();
			this.mainToolbarItemBarLargeButtonItem = new DevExpress.XtraBars.BarLargeButtonItem();
			this.mainToolBarItemPoolBarLargeButtonItem = new DevExpress.XtraBars.BarLargeButtonItem();
			this.mainToolbarProductionBarLargeButtonItem = new DevExpress.XtraBars.BarLargeButtonItem();
			this.mainToolbarInventoryBarLargeButtonItem = new DevExpress.XtraBars.BarLargeButtonItem();
			this.mainToolbarShipBarLargeButtonItem = new DevExpress.XtraBars.BarLargeButtonItem();
			this.mainToolbarReceiveBarLargeButtonItem = new DevExpress.XtraBars.BarLargeButtonItem();
			this.mainToolbarInventoryAdjustmentBarLargeButtonItem = new DevExpress.XtraBars.BarLargeButtonItem();
			this.mainToolbarLocationsBarLargeButtonItem = new DevExpress.XtraBars.BarLargeButtonItem();
			this.mainToolbarLocationTransferBarLargeButtonItem = new DevExpress.XtraBars.BarLargeButtonItem();
			this.mainToolbarProjectsBarLargeButtonItem = new DevExpress.XtraBars.BarLargeButtonItem();
			this.mainToolbarScheduleBarLargeButtonItem = new DevExpress.XtraBars.BarLargeButtonItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.productionDetailBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.productionSummaryBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.mainToolbarAddressesBarLargeButtonItem = new DevExpress.XtraBars.BarLargeButtonItem();
			this.mainToolbarInventoryAdjustmentBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.mainToolbarLocationsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.mainToolbarLocationTransferBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.mainToolbarProjectsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.mainToolbarScheduleBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.BarSubItem1 = new DevExpress.XtraBars.BarSubItem();
			this.DefaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			this.AllergensBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			((System.ComponentModel.ISupportInitialize)this.mainBarManager).BeginInit();
			this.SuspendLayout();
			//
			//mainBarManager
			//
			this.mainBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.mainMenuBar, this.mainToolBar});
			this.mainBarManager.DockControls.Add(this.barDockControlTop);
			this.mainBarManager.DockControls.Add(this.barDockControlBottom);
			this.mainBarManager.DockControls.Add(this.barDockControlLeft);
			this.mainBarManager.DockControls.Add(this.barDockControlRight);
			this.mainBarManager.Form = this;
			this.mainBarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.mainMenuFileBarSubItem, this.mainMenuActivitiesBarSubItem, this.mainMenuReportsBarSubItem, this.mainMenuToolsBarSubItem, this.mainMenuWindowBarSubItem, this.helpBarSubItem, this.fileExitBarButtonItem, this.listsCustomerBarButtonItem, this.listsItemBarButtonItem, this.listsMachineBarButtonItem, this.listsShiftsBarButtonItem, this.listsCarriersBarButtonItem, this.activitesRecieveBarButtonItem, this.activitiesProductionBarButtonItem, this.activitesShipBarButtonItem, this.productionDetailBarButtonItem, this.productionSummaryBarButtonItem, this.reportsCostingBarSubItem, this.costingDetailBarButtonItem, this.costingDetailFullBarButtonItem, this.costingSummaryBarButtonItem, this.costingFinancialBarButtonItem, this.toolsOptionsBarButtonItem, this.toolsSecurityBarButtonItem, this.windowCascadeBarButtonItem, this.windowVerticalBarButtonItem, this.windowHorizontalBarButtonItem, this.windowCloseBarButtonItem, this.windowArrangeBarButtonItem, this.mainToolbarCustomersBarLargeButtonItem, this.mainToolbarItemBarLargeButtonItem, this.mainToolbarProductionBarLargeButtonItem, this.mainToolbarShipBarLargeButtonItem, this.mainToolbarReceiveBarLargeButtonItem, this.BarMdiChildrenListItem1, this.mainMenuListsBarSubItem, this.databaseBarButtonItem, this.listsAddressesBarButtonItem, this.mainToolbarAddressesBarLargeButtonItem, this.listsInventoryBarButtonItem, this.mainToolbarInventoryBarLargeButtonItem, this.inventoryAdjustmentBarButtonItem, this.reportsBarButtonItem, this.mainToolbarInventoryAdjustmentBarButtonItem, this.listVendorsBarButtonItem, this.listsEmployeesBarButtonItem, this.listsShipmentConditionsBarButtonItem, this.listsItemPoolBarButtonItem, this.mainToolBarItemPoolBarLargeButtonItem, this.mainToolbarLocationsBarButtonItem, this.listLocationsBarButtonItem, this.mainToolbarLocationTransferBarButtonItem, this.activitiesLocationTransferBarButtonItem, this.mainToolbarProjectsBarButtonItem, this.mainToolbarScheduleBarButtonItem, this.activitiesProjectsBarButtonItem, this.activitiesScheduleBarButtonItem, this.mainToolbarInventoryAdjustmentBarLargeButtonItem, this.mainToolbarLocationsBarLargeButtonItem, this.mainToolbarLocationTransferBarLargeButtonItem, this.mainToolbarProjectsBarLargeButtonItem, this.mainToolbarScheduleBarLargeButtonItem, this.lotCodeFormatsBarButtonItem, this.reasonCodesBarButtonItem, this.AllergensBarButtonItem});
			this.mainBarManager.MainMenu = this.mainMenuBar;
			this.mainBarManager.MaxItemId = 77;
			//
			//mainMenuBar
			//
			this.mainMenuBar.BarName = "MainMenu";
			this.mainMenuBar.DockCol = 0;
			this.mainMenuBar.DockRow = 0;
			this.mainMenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.mainMenuBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.mainMenuFileBarSubItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.mainMenuListsBarSubItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.mainMenuActivitiesBarSubItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.mainMenuReportsBarSubItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.mainMenuToolsBarSubItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.mainMenuWindowBarSubItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.helpBarSubItem)
			});
			this.mainMenuBar.OptionsBar.AllowQuickCustomization = false;
			this.mainMenuBar.OptionsBar.DisableClose = true;
			this.mainMenuBar.OptionsBar.DisableCustomization = true;
			this.mainMenuBar.OptionsBar.DrawDragBorder = false;
			this.mainMenuBar.OptionsBar.MultiLine = true;
			this.mainMenuBar.OptionsBar.UseWholeRow = true;
			this.mainMenuBar.Text = "Main Menu";
			//
			//mainMenuFileBarSubItem
			//
			this.mainMenuFileBarSubItem.Caption = "&File";
			this.mainMenuFileBarSubItem.Id = 8;
			this.mainMenuFileBarSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.databaseBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.fileExitBarButtonItem, true)
			});
			this.mainMenuFileBarSubItem.Name = "mainMenuFileBarSubItem";
			//
			//databaseBarButtonItem
			//
			this.databaseBarButtonItem.Caption = "&Open Database";
			this.databaseBarButtonItem.Id = 45;
			this.databaseBarButtonItem.Name = "databaseBarButtonItem";
			//
			//fileExitBarButtonItem
			//
			this.fileExitBarButtonItem.Caption = "E&xit";
			this.fileExitBarButtonItem.Id = 11;
			this.fileExitBarButtonItem.Name = "fileExitBarButtonItem";
			//
			//mainMenuListsBarSubItem
			//
			this.mainMenuListsBarSubItem.Caption = "&Lists";
			this.mainMenuListsBarSubItem.Id = 1;
			this.mainMenuListsBarSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.listsCustomerBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.listsItemBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.listsItemPoolBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.listLocationsBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.listsAddressesBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.AllergensBarButtonItem, true),
				new DevExpress.XtraBars.LinkPersistInfo(this.listsMachineBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.listsShiftsBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.listsCarriersBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.listVendorsBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.listsEmployeesBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.listsShipmentConditionsBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.lotCodeFormatsBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.reasonCodesBarButtonItem)
			});
			this.mainMenuListsBarSubItem.Name = "mainMenuListsBarSubItem";
			//
			//listsCustomerBarButtonItem
			//
			this.listsCustomerBarButtonItem.Caption = "&Customer Manager";
			this.listsCustomerBarButtonItem.Id = 12;
			this.listsCustomerBarButtonItem.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("listsCustomerBarButtonItem.ImageOptions.Image");
			this.listsCustomerBarButtonItem.Name = "listsCustomerBarButtonItem";
			//
			//listsItemBarButtonItem
			//
			this.listsItemBarButtonItem.Caption = "&Item Manager";
			this.listsItemBarButtonItem.Id = 13;
			this.listsItemBarButtonItem.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("listsItemBarButtonItem.ImageOptions.Image");
			this.listsItemBarButtonItem.Name = "listsItemBarButtonItem";
			//
			//listsItemPoolBarButtonItem
			//
			this.listsItemPoolBarButtonItem.Caption = "Item &Pool Manager";
			this.listsItemPoolBarButtonItem.Id = 58;
			this.listsItemPoolBarButtonItem.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("listsItemPoolBarButtonItem.ImageOptions.Image");
			this.listsItemPoolBarButtonItem.Name = "listsItemPoolBarButtonItem";
			//
			//listLocationsBarButtonItem
			//
			this.listLocationsBarButtonItem.Caption = "&Locations";
			this.listLocationsBarButtonItem.Id = 62;
			this.listLocationsBarButtonItem.ImageOptions.Image = SuperiorPackGroup.Properties.Resources.WarehouseLocation_24;
			this.listLocationsBarButtonItem.Name = "listLocationsBarButtonItem";
			//
			//listsAddressesBarButtonItem
			//
			this.listsAddressesBarButtonItem.Caption = "Shipping &Destinations";
			this.listsAddressesBarButtonItem.Id = 47;
			this.listsAddressesBarButtonItem.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("listsAddressesBarButtonItem.ImageOptions.Image");
			this.listsAddressesBarButtonItem.Name = "listsAddressesBarButtonItem";
			//
			//listsMachineBarButtonItem
			//
			this.listsMachineBarButtonItem.Caption = "&Machine Line";
			this.listsMachineBarButtonItem.Id = 15;
			this.listsMachineBarButtonItem.Name = "listsMachineBarButtonItem";
			//
			//listsShiftsBarButtonItem
			//
			this.listsShiftsBarButtonItem.Caption = "&Shifts";
			this.listsShiftsBarButtonItem.Id = 16;
			this.listsShiftsBarButtonItem.Name = "listsShiftsBarButtonItem";
			//
			//listsCarriersBarButtonItem
			//
			this.listsCarriersBarButtonItem.Caption = "Ca&rriers";
			this.listsCarriersBarButtonItem.Id = 17;
			this.listsCarriersBarButtonItem.Name = "listsCarriersBarButtonItem";
			//
			//listVendorsBarButtonItem
			//
			this.listVendorsBarButtonItem.Caption = "&Vendors";
			this.listVendorsBarButtonItem.Id = 55;
			this.listVendorsBarButtonItem.Name = "listVendorsBarButtonItem";
			//
			//listsEmployeesBarButtonItem
			//
			this.listsEmployeesBarButtonItem.Caption = "&Employees";
			this.listsEmployeesBarButtonItem.Id = 56;
			this.listsEmployeesBarButtonItem.Name = "listsEmployeesBarButtonItem";
			//
			//listsShipmentConditionsBarButtonItem
			//
			this.listsShipmentConditionsBarButtonItem.Caption = "Shipmen&t Conditions";
			this.listsShipmentConditionsBarButtonItem.Id = 57;
			this.listsShipmentConditionsBarButtonItem.Name = "listsShipmentConditionsBarButtonItem";
			//
			//lotCodeFormatsBarButtonItem
			//
			this.lotCodeFormatsBarButtonItem.Caption = "Lot Code &Formats";
			this.lotCodeFormatsBarButtonItem.Id = 74;
			this.lotCodeFormatsBarButtonItem.Name = "lotCodeFormatsBarButtonItem";
			//
			//reasonCodesBarButtonItem
			//
			this.reasonCodesBarButtonItem.Caption = "Reason Codes";
			this.reasonCodesBarButtonItem.Id = 75;
			this.reasonCodesBarButtonItem.Name = "reasonCodesBarButtonItem";
			//
			//mainMenuActivitiesBarSubItem
			//
			this.mainMenuActivitiesBarSubItem.Caption = "&Activities";
			this.mainMenuActivitiesBarSubItem.Id = 2;
			this.mainMenuActivitiesBarSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.activitesRecieveBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.activitiesProductionBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.listsInventoryBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.activitesShipBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.inventoryAdjustmentBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.activitiesLocationTransferBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.activitiesProjectsBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.activitiesScheduleBarButtonItem)
			});
			this.mainMenuActivitiesBarSubItem.Name = "mainMenuActivitiesBarSubItem";
			//
			//activitesRecieveBarButtonItem
			//
			this.activitesRecieveBarButtonItem.Caption = "&Receive Raw Material";
			this.activitesRecieveBarButtonItem.Id = 18;
			this.activitesRecieveBarButtonItem.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("activitesRecieveBarButtonItem.ImageOptions.Image");
			this.activitesRecieveBarButtonItem.Name = "activitesRecieveBarButtonItem";
			//
			//activitiesProductionBarButtonItem
			//
			this.activitiesProductionBarButtonItem.Caption = "Production &Cost";
			this.activitiesProductionBarButtonItem.Id = 19;
			this.activitiesProductionBarButtonItem.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("activitiesProductionBarButtonItem.ImageOptions.Image");
			this.activitiesProductionBarButtonItem.Name = "activitiesProductionBarButtonItem";
			//
			//listsInventoryBarButtonItem
			//
			this.listsInventoryBarButtonItem.Caption = "&Production Entries";
			this.listsInventoryBarButtonItem.Id = 49;
			this.listsInventoryBarButtonItem.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("listsInventoryBarButtonItem.ImageOptions.Image");
			this.listsInventoryBarButtonItem.Name = "listsInventoryBarButtonItem";
			//
			//activitesShipBarButtonItem
			//
			this.activitesShipBarButtonItem.Caption = "&Ship Finished Goods";
			this.activitesShipBarButtonItem.Id = 20;
			this.activitesShipBarButtonItem.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("activitesShipBarButtonItem.ImageOptions.Image");
			this.activitesShipBarButtonItem.Name = "activitesShipBarButtonItem";
			//
			//inventoryAdjustmentBarButtonItem
			//
			this.inventoryAdjustmentBarButtonItem.Caption = "&Inventory Adjustment";
			this.inventoryAdjustmentBarButtonItem.Id = 52;
			this.inventoryAdjustmentBarButtonItem.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("inventoryAdjustmentBarButtonItem.ImageOptions.Image");
			this.inventoryAdjustmentBarButtonItem.Name = "inventoryAdjustmentBarButtonItem";
			//
			//activitiesLocationTransferBarButtonItem
			//
			this.activitiesLocationTransferBarButtonItem.Caption = "&Location Transfer";
			this.activitiesLocationTransferBarButtonItem.Id = 64;
			this.activitiesLocationTransferBarButtonItem.ImageOptions.Image = SuperiorPackGroup.Properties.Resources.UpdateInventoryWarehouse24;
			this.activitiesLocationTransferBarButtonItem.Name = "activitiesLocationTransferBarButtonItem";
			//
			//activitiesProjectsBarButtonItem
			//
			this.activitiesProjectsBarButtonItem.Caption = "Pro&jects";
			this.activitiesProjectsBarButtonItem.Id = 67;
			this.activitiesProjectsBarButtonItem.ImageOptions.Image = SuperiorPackGroup.Properties.Resources.Project24;
			this.activitiesProjectsBarButtonItem.Name = "activitiesProjectsBarButtonItem";
			//
			//activitiesScheduleBarButtonItem
			//
			this.activitiesScheduleBarButtonItem.Caption = "Sche&dule";
			this.activitiesScheduleBarButtonItem.Enabled = false;
			this.activitiesScheduleBarButtonItem.Id = 68;
			this.activitiesScheduleBarButtonItem.ImageOptions.Image = SuperiorPackGroup.Properties.Resources.Schedule24;
			this.activitiesScheduleBarButtonItem.Name = "activitiesScheduleBarButtonItem";
			//
			//mainMenuReportsBarSubItem
			//
			this.mainMenuReportsBarSubItem.Caption = "&Reports";
			this.mainMenuReportsBarSubItem.Id = 3;
			this.mainMenuReportsBarSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.reportsCostingBarSubItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.reportsBarButtonItem)
			});
			this.mainMenuReportsBarSubItem.Name = "mainMenuReportsBarSubItem";
			//
			//reportsCostingBarSubItem
			//
			this.reportsCostingBarSubItem.Caption = "&Costing";
			this.reportsCostingBarSubItem.Id = 25;
			this.reportsCostingBarSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.costingDetailBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.costingDetailFullBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.costingSummaryBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.costingFinancialBarButtonItem)
			});
			this.reportsCostingBarSubItem.Name = "reportsCostingBarSubItem";
			this.reportsCostingBarSubItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			//
			//costingDetailBarButtonItem
			//
			this.costingDetailBarButtonItem.Caption = "&Detail";
			this.costingDetailBarButtonItem.Id = 26;
			this.costingDetailBarButtonItem.Name = "costingDetailBarButtonItem";
			//
			//costingDetailFullBarButtonItem
			//
			this.costingDetailFullBarButtonItem.Caption = "Detail &Full";
			this.costingDetailFullBarButtonItem.Id = 27;
			this.costingDetailFullBarButtonItem.Name = "costingDetailFullBarButtonItem";
			//
			//costingSummaryBarButtonItem
			//
			this.costingSummaryBarButtonItem.Caption = "&Summary";
			this.costingSummaryBarButtonItem.Id = 28;
			this.costingSummaryBarButtonItem.Name = "costingSummaryBarButtonItem";
			//
			//costingFinancialBarButtonItem
			//
			this.costingFinancialBarButtonItem.Caption = "&Financial";
			this.costingFinancialBarButtonItem.Id = 29;
			this.costingFinancialBarButtonItem.Name = "costingFinancialBarButtonItem";
			//
			//reportsBarButtonItem
			//
			this.reportsBarButtonItem.Caption = "&Reports";
			this.reportsBarButtonItem.Id = 53;
			this.reportsBarButtonItem.Name = "reportsBarButtonItem";
			//
			//mainMenuToolsBarSubItem
			//
			this.mainMenuToolsBarSubItem.Caption = "&Tools";
			this.mainMenuToolsBarSubItem.Id = 4;
			this.mainMenuToolsBarSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.toolsOptionsBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.toolsSecurityBarButtonItem)
			});
			this.mainMenuToolsBarSubItem.Name = "mainMenuToolsBarSubItem";
			//
			//toolsOptionsBarButtonItem
			//
			this.toolsOptionsBarButtonItem.Caption = "&Options...";
			this.toolsOptionsBarButtonItem.Id = 30;
			this.toolsOptionsBarButtonItem.Name = "toolsOptionsBarButtonItem";
			//
			//toolsSecurityBarButtonItem
			//
			this.toolsSecurityBarButtonItem.Caption = "&Security...";
			this.toolsSecurityBarButtonItem.Id = 31;
			this.toolsSecurityBarButtonItem.Name = "toolsSecurityBarButtonItem";
			//
			//mainMenuWindowBarSubItem
			//
			this.mainMenuWindowBarSubItem.Caption = "&Window";
			this.mainMenuWindowBarSubItem.Id = 5;
			this.mainMenuWindowBarSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.windowCascadeBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.windowVerticalBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.windowHorizontalBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.windowArrangeBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.windowCloseBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.BarMdiChildrenListItem1, true)
			});
			this.mainMenuWindowBarSubItem.Name = "mainMenuWindowBarSubItem";
			//
			//windowCascadeBarButtonItem
			//
			this.windowCascadeBarButtonItem.Caption = "&Cascade";
			this.windowCascadeBarButtonItem.Id = 32;
			this.windowCascadeBarButtonItem.Name = "windowCascadeBarButtonItem";
			//
			//windowVerticalBarButtonItem
			//
			this.windowVerticalBarButtonItem.Caption = "Tile &Vertical";
			this.windowVerticalBarButtonItem.Id = 33;
			this.windowVerticalBarButtonItem.Name = "windowVerticalBarButtonItem";
			//
			//windowHorizontalBarButtonItem
			//
			this.windowHorizontalBarButtonItem.Caption = "Tile &Horizontal";
			this.windowHorizontalBarButtonItem.Id = 34;
			this.windowHorizontalBarButtonItem.Name = "windowHorizontalBarButtonItem";
			//
			//windowArrangeBarButtonItem
			//
			this.windowArrangeBarButtonItem.Caption = "&Arrange Icons";
			this.windowArrangeBarButtonItem.Id = 36;
			this.windowArrangeBarButtonItem.Name = "windowArrangeBarButtonItem";
			//
			//windowCloseBarButtonItem
			//
			this.windowCloseBarButtonItem.Caption = "C&lose All";
			this.windowCloseBarButtonItem.Id = 35;
			this.windowCloseBarButtonItem.Name = "windowCloseBarButtonItem";
			//
			//BarMdiChildrenListItem1
			//
			this.BarMdiChildrenListItem1.Caption = "Open Forms/Reports";
			this.BarMdiChildrenListItem1.Id = 44;
			this.BarMdiChildrenListItem1.Name = "BarMdiChildrenListItem1";
			//
			//helpBarSubItem
			//
			this.helpBarSubItem.Caption = "&Help";
			this.helpBarSubItem.Id = 6;
			this.helpBarSubItem.Name = "helpBarSubItem";
			//
			//mainToolBar
			//
			this.mainToolBar.BarName = "MainToolbar";
			this.mainToolBar.DockCol = 0;
			this.mainToolBar.DockRow = 1;
			this.mainToolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.mainToolBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.mainToolbarCustomersBarLargeButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.mainToolbarItemBarLargeButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.mainToolBarItemPoolBarLargeButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.mainToolbarProductionBarLargeButtonItem, true),
				new DevExpress.XtraBars.LinkPersistInfo(this.mainToolbarInventoryBarLargeButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.mainToolbarShipBarLargeButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.mainToolbarReceiveBarLargeButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.mainToolbarInventoryAdjustmentBarLargeButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.mainToolbarLocationsBarLargeButtonItem, true),
				new DevExpress.XtraBars.LinkPersistInfo(this.mainToolbarLocationTransferBarLargeButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.mainToolbarProjectsBarLargeButtonItem, true),
				new DevExpress.XtraBars.LinkPersistInfo(this.mainToolbarScheduleBarLargeButtonItem)
			});
			this.mainToolBar.OptionsBar.AllowQuickCustomization = false;
			this.mainToolBar.OptionsBar.MultiLine = true;
			this.mainToolBar.Text = "Main Toolbar";
			//
			//mainToolbarCustomersBarLargeButtonItem
			//
			this.mainToolbarCustomersBarLargeButtonItem.Caption = "&Customers";
			this.mainToolbarCustomersBarLargeButtonItem.Id = 38;
			this.mainToolbarCustomersBarLargeButtonItem.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("mainToolbarCustomersBarLargeButtonItem.ImageOptions.Image");
			this.mainToolbarCustomersBarLargeButtonItem.Name = "mainToolbarCustomersBarLargeButtonItem";
			this.mainToolbarCustomersBarLargeButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			ToolTipTitleItem1.Text = "Customer Manager";
			SuperToolTip1.Items.Add(ToolTipTitleItem1);
			this.mainToolbarCustomersBarLargeButtonItem.SuperTip = SuperToolTip1;
			//
			//mainToolbarItemBarLargeButtonItem
			//
			this.mainToolbarItemBarLargeButtonItem.Caption = "&Item";
			this.mainToolbarItemBarLargeButtonItem.Id = 39;
			this.mainToolbarItemBarLargeButtonItem.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("mainToolbarItemBarLargeButtonItem.ImageOptions.Image");
			this.mainToolbarItemBarLargeButtonItem.Name = "mainToolbarItemBarLargeButtonItem";
			this.mainToolbarItemBarLargeButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			ToolTipItem1.Text = "Item Manager";
			SuperToolTip2.Items.Add(ToolTipItem1);
			this.mainToolbarItemBarLargeButtonItem.SuperTip = SuperToolTip2;
			//
			//mainToolBarItemPoolBarLargeButtonItem
			//
			this.mainToolBarItemPoolBarLargeButtonItem.Caption = "Item &Pool";
			this.mainToolBarItemPoolBarLargeButtonItem.Id = 60;
			this.mainToolBarItemPoolBarLargeButtonItem.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("mainToolBarItemPoolBarLargeButtonItem.ImageOptions.Image");
			this.mainToolBarItemPoolBarLargeButtonItem.Name = "mainToolBarItemPoolBarLargeButtonItem";
			this.mainToolBarItemPoolBarLargeButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			ToolTipItem2.Text = "Item Pool Manager";
			SuperToolTip3.Items.Add(ToolTipItem2);
			this.mainToolBarItemPoolBarLargeButtonItem.SuperTip = SuperToolTip3;
			//
			//mainToolbarProductionBarLargeButtonItem
			//
			this.mainToolbarProductionBarLargeButtonItem.Caption = "&Production";
			this.mainToolbarProductionBarLargeButtonItem.Id = 40;
			this.mainToolbarProductionBarLargeButtonItem.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("mainToolbarProductionBarLargeButtonItem.ImageOptions.Image");
			this.mainToolbarProductionBarLargeButtonItem.Name = "mainToolbarProductionBarLargeButtonItem";
			this.mainToolbarProductionBarLargeButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			ToolTipTitleItem2.Text = "Production Cost";
			SuperToolTip4.Items.Add(ToolTipTitleItem2);
			this.mainToolbarProductionBarLargeButtonItem.SuperTip = SuperToolTip4;
			//
			//mainToolbarInventoryBarLargeButtonItem
			//
			this.mainToolbarInventoryBarLargeButtonItem.Caption = "In&ventory";
			this.mainToolbarInventoryBarLargeButtonItem.Id = 50;
			this.mainToolbarInventoryBarLargeButtonItem.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("mainToolbarInventoryBarLargeButtonItem.ImageOptions.Image");
			this.mainToolbarInventoryBarLargeButtonItem.Name = "mainToolbarInventoryBarLargeButtonItem";
			this.mainToolbarInventoryBarLargeButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			ToolTipTitleItem3.Text = "Production Entries";
			SuperToolTip5.Items.Add(ToolTipTitleItem3);
			this.mainToolbarInventoryBarLargeButtonItem.SuperTip = SuperToolTip5;
			//
			//mainToolbarShipBarLargeButtonItem
			//
			this.mainToolbarShipBarLargeButtonItem.Caption = "&Ship";
			this.mainToolbarShipBarLargeButtonItem.Id = 42;
			this.mainToolbarShipBarLargeButtonItem.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("mainToolbarShipBarLargeButtonItem.ImageOptions.Image");
			this.mainToolbarShipBarLargeButtonItem.Name = "mainToolbarShipBarLargeButtonItem";
			this.mainToolbarShipBarLargeButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			ToolTipTitleItem4.Text = "Ship Finished Goods";
			SuperToolTip6.Items.Add(ToolTipTitleItem4);
			this.mainToolbarShipBarLargeButtonItem.SuperTip = SuperToolTip6;
			//
			//mainToolbarReceiveBarLargeButtonItem
			//
			this.mainToolbarReceiveBarLargeButtonItem.Caption = "&Receive";
			this.mainToolbarReceiveBarLargeButtonItem.Id = 43;
			this.mainToolbarReceiveBarLargeButtonItem.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("mainToolbarReceiveBarLargeButtonItem.ImageOptions.Image");
			this.mainToolbarReceiveBarLargeButtonItem.Name = "mainToolbarReceiveBarLargeButtonItem";
			this.mainToolbarReceiveBarLargeButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			ToolTipTitleItem5.Text = "Receive Raw Material";
			SuperToolTip7.Items.Add(ToolTipTitleItem5);
			this.mainToolbarReceiveBarLargeButtonItem.SuperTip = SuperToolTip7;
			//
			//mainToolbarInventoryAdjustmentBarLargeButtonItem
			//
			this.mainToolbarInventoryAdjustmentBarLargeButtonItem.Caption = "  Inventory" + "\r" + "\n" + "Adjustment";
			this.mainToolbarInventoryAdjustmentBarLargeButtonItem.Id = 69;
			this.mainToolbarInventoryAdjustmentBarLargeButtonItem.ImageOptions.Image = SuperiorPackGroup.Properties.Resources.InventoryAdjustment32;
			this.mainToolbarInventoryAdjustmentBarLargeButtonItem.Name = "mainToolbarInventoryAdjustmentBarLargeButtonItem";
			this.mainToolbarInventoryAdjustmentBarLargeButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			ToolTipTitleItem6.Text = "Inventory Adjustment";
			SuperToolTip8.Items.Add(ToolTipTitleItem6);
			this.mainToolbarInventoryAdjustmentBarLargeButtonItem.SuperTip = SuperToolTip8;
			//
			//mainToolbarLocationsBarLargeButtonItem
			//
			this.mainToolbarLocationsBarLargeButtonItem.Caption = "Locations";
			this.mainToolbarLocationsBarLargeButtonItem.Id = 70;
			this.mainToolbarLocationsBarLargeButtonItem.ImageOptions.Image = SuperiorPackGroup.Properties.Resources.WarehouseLocation_32;
			this.mainToolbarLocationsBarLargeButtonItem.Name = "mainToolbarLocationsBarLargeButtonItem";
			this.mainToolbarLocationsBarLargeButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			ToolTipTitleItem7.Text = "Locations";
			SuperToolTip9.Items.Add(ToolTipTitleItem7);
			this.mainToolbarLocationsBarLargeButtonItem.SuperTip = SuperToolTip9;
			//
			//mainToolbarLocationTransferBarLargeButtonItem
			//
			this.mainToolbarLocationTransferBarLargeButtonItem.Caption = "Location " + "\r" + "\n" + "Transfer";
			this.mainToolbarLocationTransferBarLargeButtonItem.Id = 71;
			this.mainToolbarLocationTransferBarLargeButtonItem.ImageOptions.Image = SuperiorPackGroup.Properties.Resources.UpdateInventoryWarehouse32;
			this.mainToolbarLocationTransferBarLargeButtonItem.Name = "mainToolbarLocationTransferBarLargeButtonItem";
			this.mainToolbarLocationTransferBarLargeButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			ToolTipTitleItem8.Text = "Location Transfer";
			SuperToolTip10.Items.Add(ToolTipTitleItem8);
			this.mainToolbarLocationTransferBarLargeButtonItem.SuperTip = SuperToolTip10;
			//
			//mainToolbarProjectsBarLargeButtonItem
			//
			this.mainToolbarProjectsBarLargeButtonItem.Caption = "Projects";
			this.mainToolbarProjectsBarLargeButtonItem.Id = 72;
			this.mainToolbarProjectsBarLargeButtonItem.ImageOptions.Image = SuperiorPackGroup.Properties.Resources.Project32;
			this.mainToolbarProjectsBarLargeButtonItem.Name = "mainToolbarProjectsBarLargeButtonItem";
			this.mainToolbarProjectsBarLargeButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			ToolTipTitleItem9.Text = "Projects";
			SuperToolTip11.Items.Add(ToolTipTitleItem9);
			this.mainToolbarProjectsBarLargeButtonItem.SuperTip = SuperToolTip11;
			//
			//mainToolbarScheduleBarLargeButtonItem
			//
			this.mainToolbarScheduleBarLargeButtonItem.Caption = "Schedule";
			this.mainToolbarScheduleBarLargeButtonItem.Id = 73;
			this.mainToolbarScheduleBarLargeButtonItem.ImageOptions.Image = SuperiorPackGroup.Properties.Resources.Schedule32;
			this.mainToolbarScheduleBarLargeButtonItem.Name = "mainToolbarScheduleBarLargeButtonItem";
			this.mainToolbarScheduleBarLargeButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			//
			//barDockControlTop
			//
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.mainBarManager;
			this.barDockControlTop.Size = new System.Drawing.Size(947, 101);
			//
			//barDockControlBottom
			//
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 264);
			this.barDockControlBottom.Manager = this.mainBarManager;
			this.barDockControlBottom.Size = new System.Drawing.Size(947, 0);
			//
			//barDockControlLeft
			//
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 101);
			this.barDockControlLeft.Manager = this.mainBarManager;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 163);
			//
			//barDockControlRight
			//
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(947, 101);
			this.barDockControlRight.Manager = this.mainBarManager;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 163);
			//
			//productionDetailBarButtonItem
			//
			this.productionDetailBarButtonItem.Caption = "&Detail";
			this.productionDetailBarButtonItem.Id = 22;
			this.productionDetailBarButtonItem.Name = "productionDetailBarButtonItem";
			//
			//productionSummaryBarButtonItem
			//
			this.productionSummaryBarButtonItem.Caption = "&Summary";
			this.productionSummaryBarButtonItem.Id = 23;
			this.productionSummaryBarButtonItem.Name = "productionSummaryBarButtonItem";
			//
			//mainToolbarAddressesBarLargeButtonItem
			//
			this.mainToolbarAddressesBarLargeButtonItem.Caption = "Shipping &Addresses";
			this.mainToolbarAddressesBarLargeButtonItem.Id = 48;
			this.mainToolbarAddressesBarLargeButtonItem.Name = "mainToolbarAddressesBarLargeButtonItem";
			ToolTipTitleItem10.Text = "Shipping Addresses";
			SuperToolTip12.Items.Add(ToolTipTitleItem10);
			this.mainToolbarAddressesBarLargeButtonItem.SuperTip = SuperToolTip12;
			this.mainToolbarAddressesBarLargeButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
			//
			//mainToolbarInventoryAdjustmentBarButtonItem
			//
			this.mainToolbarInventoryAdjustmentBarButtonItem.Caption = "Inventory Adjustment";
			this.mainToolbarInventoryAdjustmentBarButtonItem.Id = 54;
			this.mainToolbarInventoryAdjustmentBarButtonItem.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("mainToolbarInventoryAdjustmentBarButtonItem.ImageOptions.Image");
			this.mainToolbarInventoryAdjustmentBarButtonItem.Name = "mainToolbarInventoryAdjustmentBarButtonItem";
			this.mainToolbarInventoryAdjustmentBarButtonItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			ToolTipTitleItem11.Text = "Inventory Adjustment";
			SuperToolTip13.Items.Add(ToolTipTitleItem11);
			this.mainToolbarInventoryAdjustmentBarButtonItem.SuperTip = SuperToolTip13;
			//
			//mainToolbarLocationsBarButtonItem
			//
			this.mainToolbarLocationsBarButtonItem.Caption = "Locations";
			this.mainToolbarLocationsBarButtonItem.Id = 61;
			this.mainToolbarLocationsBarButtonItem.ImageOptions.Image = SuperiorPackGroup.Properties.Resources.WarehouseLocation_32;
			this.mainToolbarLocationsBarButtonItem.Name = "mainToolbarLocationsBarButtonItem";
			ToolTipTitleItem12.Text = "Locations";
			SuperToolTip14.Items.Add(ToolTipTitleItem12);
			this.mainToolbarLocationsBarButtonItem.SuperTip = SuperToolTip14;
			//
			//mainToolbarLocationTransferBarButtonItem
			//
			this.mainToolbarLocationTransferBarButtonItem.Caption = "Location Transfer";
			this.mainToolbarLocationTransferBarButtonItem.Id = 63;
			this.mainToolbarLocationTransferBarButtonItem.ImageOptions.Image = SuperiorPackGroup.Properties.Resources.UpdateInventoryWarehouse32;
			this.mainToolbarLocationTransferBarButtonItem.Name = "mainToolbarLocationTransferBarButtonItem";
			ToolTipTitleItem13.Text = "Location Transfer";
			SuperToolTip15.Items.Add(ToolTipTitleItem13);
			this.mainToolbarLocationTransferBarButtonItem.SuperTip = SuperToolTip15;
			//
			//mainToolbarProjectsBarButtonItem
			//
			this.mainToolbarProjectsBarButtonItem.Caption = "Projects";
			this.mainToolbarProjectsBarButtonItem.Id = 65;
			this.mainToolbarProjectsBarButtonItem.ImageOptions.Image = SuperiorPackGroup.Properties.Resources.Project32;
			this.mainToolbarProjectsBarButtonItem.Name = "mainToolbarProjectsBarButtonItem";
			ToolTipTitleItem14.Text = "Projects";
			SuperToolTip16.Items.Add(ToolTipTitleItem14);
			this.mainToolbarProjectsBarButtonItem.SuperTip = SuperToolTip16;
			//
			//mainToolbarScheduleBarButtonItem
			//
			this.mainToolbarScheduleBarButtonItem.Caption = "Schedule";
			this.mainToolbarScheduleBarButtonItem.Enabled = false;
			this.mainToolbarScheduleBarButtonItem.Id = 66;
			this.mainToolbarScheduleBarButtonItem.ImageOptions.Image = SuperiorPackGroup.Properties.Resources.Schedule32;
			this.mainToolbarScheduleBarButtonItem.Name = "mainToolbarScheduleBarButtonItem";
			ToolTipTitleItem15.Text = "Schedule";
			SuperToolTip17.Items.Add(ToolTipTitleItem15);
			this.mainToolbarScheduleBarButtonItem.SuperTip = SuperToolTip17;
			//
			//BarSubItem1
			//
			this.BarSubItem1.Id = -1;
			this.BarSubItem1.Name = "BarSubItem1";
			//
			//DefaultLookAndFeel1
			//
			this.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Dark";
			//
			//AllergensBarButtonItem
			//
			this.AllergensBarButtonItem.Caption = "Allergens";
			this.AllergensBarButtonItem.Id = 76;
			this.AllergensBarButtonItem.Name = "AllergensBarButtonItem";
			//
			//MainXtraForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(947, 264);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.IsMdiContainer = true;
			this.Name = "MainXtraForm";
			this.Text = "Superior Pack Group - Test";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)this.mainBarManager).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			fileExitBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(fileExitBarButtonItem_ItemClick);
			listsCustomerBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(listsCustomerBarButtonItem_ItemClick);
			mainToolbarCustomersBarLargeButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(listsCustomerBarButtonItem_ItemClick);
			listsItemBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(listsItemBarButtonItem_ItemClick);
			mainToolbarItemBarLargeButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(listsItemBarButtonItem_ItemClick);
			listsMachineBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(listsMachineBarButtonItem_ItemClick);
			listsShiftsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(listsShiftsBarButtonItem_ItemClick);
			listsCarriersBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(listsCarriersBarButtonItem_ItemClick);
			activitesRecieveBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(activitesRecieveBarButtonItem_ItemClick);
			mainToolbarReceiveBarLargeButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(activitesRecieveBarButtonItem_ItemClick);
			activitiesProductionBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(activitiesProductionBarButtonItem_ItemClick);
			mainToolbarProductionBarLargeButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(activitiesProductionBarButtonItem_ItemClick);
			activitesShipBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(activitesShipBarButtonItem_ItemClick);
			mainToolbarShipBarLargeButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(activitesShipBarButtonItem_ItemClick);
			productionDetailBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(productionDetailBarButtonItem_ItemClick);
			toolsOptionsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(toolsOptionsBarButtonItem_ItemClick);
			toolsSecurityBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(toolsSecurityBarButtonItem_ItemClick);
			windowCascadeBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(windowCascadeBarButtonItem_ItemClick);
			windowVerticalBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(windowVerticalBarButtonItem_ItemClick);
			windowHorizontalBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(windowHorizontalBarButtonItem_ItemClick);
			windowCloseBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(windowCloseBarButtonItem_ItemClick);
			windowArrangeBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(windowArrangeBarButtonItem_ItemClick);
			base.Load += new System.EventHandler(MainXtraForm_Load);
			databaseBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(databaseBarButtonItem_ItemClick);
			listsAddressesBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(listsAddressesBarButtonItem_ItemClick);
			mainToolbarAddressesBarLargeButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(listsAddressesBarButtonItem_ItemClick);
			listsInventoryBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(listsInventoryBarButtonItem_ItemClick);
			mainToolbarInventoryBarLargeButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(listsInventoryBarButtonItem_ItemClick);
			inventoryAdjustmentBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(inventoryAdjustmentBarButtonItem_ItemClick);
			mainToolbarInventoryAdjustmentBarLargeButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(inventoryAdjustmentBarButtonItem_ItemClick);
			reportsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(reportsBarButtonItem_ItemClick);
			listVendorsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(listVendorsBarButtonItem_ItemClick);
			listsEmployeesBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(listsEmployeesBarButtonItem_ItemClick);
			listsShipmentConditionsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(listsShipmentConditionsBarButtonItem_ItemClick);
			mainToolBarItemPoolBarLargeButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(mainToolBarItemPoolBarLargeButtonItem_ItemClick);
			listsItemPoolBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(mainToolBarItemPoolBarLargeButtonItem_ItemClick);
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(MainXtraForm_FormClosing);
			mainToolbarLocationsBarLargeButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(LocationsBarButtonItem_ItemClick);
			listLocationsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(LocationsBarButtonItem_ItemClick);
			activitiesLocationTransferBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(activitiesLocationTransferBarButtonItem_ItemClick);
			mainToolbarLocationTransferBarLargeButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(activitiesLocationTransferBarButtonItem_ItemClick);
			activitiesProjectsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(activitiesProjectsBarButtomItem_ItemClick);
			mainToolbarProjectsBarLargeButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(activitiesProjectsBarButtomItem_ItemClick);
			mainToolbarScheduleBarLargeButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(mainToolbarScheduleBarLargeButtonItem_ItemClick);
			activitiesScheduleBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(mainToolbarScheduleBarLargeButtonItem_ItemClick);
			lotCodeFormatsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(lotCodeFormatsBarButtonItem_ItemClick);
			reasonCodesBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(reasonCodesBarButtonItem_ItemClick);
			AllergensBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(AllergensBarButtonItem_ItemClick);
		}
		internal DevExpress.XtraBars.BarManager mainBarManager;
		internal DevExpress.XtraBars.Bar mainMenuBar;
		internal DevExpress.XtraBars.Bar mainToolBar;
		internal DevExpress.XtraBars.BarDockControl barDockControlTop;
		internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
		internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
		internal DevExpress.XtraBars.BarDockControl barDockControlRight;
		internal DevExpress.XtraBars.BarSubItem mainMenuListsBarSubItem;
		internal DevExpress.XtraBars.BarSubItem mainMenuActivitiesBarSubItem;
		internal DevExpress.XtraBars.BarSubItem mainMenuReportsBarSubItem;
		internal DevExpress.XtraBars.BarSubItem mainMenuToolsBarSubItem;
		internal DevExpress.XtraBars.BarSubItem mainMenuWindowBarSubItem;
		internal DevExpress.XtraBars.BarSubItem helpBarSubItem;
		internal DevExpress.XtraBars.BarSubItem mainMenuFileBarSubItem;
		internal DevExpress.XtraBars.BarSubItem BarSubItem1;
		internal DevExpress.XtraBars.BarButtonItem fileExitBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem listsCustomerBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem listsItemBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem listsMachineBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem listsShiftsBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem listsCarriersBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem activitesRecieveBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem activitiesProductionBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem activitesShipBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem productionDetailBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem productionSummaryBarButtonItem;
		internal DevExpress.XtraBars.BarSubItem reportsCostingBarSubItem;
		internal DevExpress.XtraBars.BarButtonItem costingDetailBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem costingDetailFullBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem costingSummaryBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem costingFinancialBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem toolsOptionsBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem toolsSecurityBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem windowCascadeBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem windowVerticalBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem windowHorizontalBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem windowCloseBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem windowArrangeBarButtonItem;
		internal DevExpress.XtraBars.BarLargeButtonItem mainToolbarCustomersBarLargeButtonItem;
		internal DevExpress.XtraBars.BarLargeButtonItem mainToolbarItemBarLargeButtonItem;
		internal DevExpress.XtraBars.BarLargeButtonItem mainToolbarProductionBarLargeButtonItem;
		internal DevExpress.XtraBars.BarLargeButtonItem mainToolbarShipBarLargeButtonItem;
		internal DevExpress.XtraBars.BarLargeButtonItem mainToolbarReceiveBarLargeButtonItem;
		internal DevExpress.XtraBars.BarMdiChildrenListItem BarMdiChildrenListItem1;
		internal DevExpress.XtraBars.BarButtonItem databaseBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem listsAddressesBarButtonItem;
		internal DevExpress.XtraBars.BarLargeButtonItem mainToolbarAddressesBarLargeButtonItem;
		internal DevExpress.XtraBars.BarButtonItem listsInventoryBarButtonItem;
		internal DevExpress.XtraBars.BarLargeButtonItem mainToolbarInventoryBarLargeButtonItem;
		internal DevExpress.XtraBars.BarButtonItem inventoryAdjustmentBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem reportsBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem mainToolbarInventoryAdjustmentBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem listVendorsBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem listsEmployeesBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem listsShipmentConditionsBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem listsItemPoolBarButtonItem;
		internal DevExpress.XtraBars.BarLargeButtonItem mainToolBarItemPoolBarLargeButtonItem;
		internal DevExpress.XtraBars.BarButtonItem mainToolbarLocationsBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem listLocationsBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem mainToolbarLocationTransferBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem activitiesLocationTransferBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem mainToolbarProjectsBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem mainToolbarScheduleBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem activitiesProjectsBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem activitiesScheduleBarButtonItem;
		internal DevExpress.XtraBars.BarLargeButtonItem mainToolbarInventoryAdjustmentBarLargeButtonItem;
		internal DevExpress.XtraBars.BarLargeButtonItem mainToolbarLocationsBarLargeButtonItem;
		internal DevExpress.XtraBars.BarLargeButtonItem mainToolbarLocationTransferBarLargeButtonItem;
		internal DevExpress.XtraBars.BarLargeButtonItem mainToolbarProjectsBarLargeButtonItem;
		internal DevExpress.XtraBars.BarLargeButtonItem mainToolbarScheduleBarLargeButtonItem;
		internal DevExpress.XtraBars.BarButtonItem lotCodeFormatsBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem reasonCodesBarButtonItem;
		internal DevExpress.LookAndFeel.DefaultLookAndFeel DefaultLookAndFeel1;
		internal DevExpress.XtraBars.BarButtonItem AllergensBarButtonItem;
	}

}