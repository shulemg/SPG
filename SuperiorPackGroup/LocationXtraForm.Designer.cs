using DXDAL.SPGData;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Views.Grid;

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
	public partial class LocationXtraForm : DevExpress.XtraEditors.XtraForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocationXtraForm));
			this.BarManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.locationMenuBar = new DevExpress.XtraBars.Bar();
			this.addBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.editBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.deleteBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.cancelBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.saveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.printGridBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.Bar2 = new DevExpress.XtraBars.Bar();
			this.Bar3 = new DevExpress.XtraBars.Bar();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.SplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			this.locationSearchGridControl = new DevExpress.XtraGrid.GridControl();
			this.locationSearchXpView = new DevExpress.Xpo.XPView(this.components);
			this.locationSearchGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLocationID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.locationsXtraTabControl = new DevExpress.XtraTab.XtraTabControl();
			this.generalXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.defaultWarehouseCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.inventoryAvailableCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.warehousingCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.productionCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.shippingCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.receivingCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.faxTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.phoneTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.zipCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.stateTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.cityTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.addressTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.codeTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.oidTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.inventoryXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.inventoryGridControl = new DevExpress.XtraGrid.GridControl();
			this.locationInventoryXpView = new DevExpress.Xpo.XPView(this.components);
			this.inventoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.inventoryByLotXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.PrintLpnSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.inventoryByLotGridControl = new DevExpress.XtraGrid.GridControl();
			this.locationInventoryByLotXpView = new DevExpress.Xpo.XPView(this.components);
			this.inventoryByLotGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colItemCode1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colItemDescription1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colExpirationDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLot = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLPNNumber = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colQuantity1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.transfersXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.SplitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
			this.transfersToGroupControl = new DevExpress.XtraEditors.GroupControl();
			this.transfersToGridControl = new DevExpress.XtraGrid.GridControl();
			this.transfersToXpView = new DevExpress.Xpo.XPView(this.components);
			this.transfersToGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colTransferToDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFromLocation = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTransferToItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTransferToItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTransferToNumber = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTransferToItemLot = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTransferToExpirationDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTransferToQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.transferToExpirationDateFormatGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.transfersFromGroupControl = new DevExpress.XtraEditors.GroupControl();
			this.transfersFromGridControl = new DevExpress.XtraGrid.GridControl();
			this.transfersFromXpView = new DevExpress.Xpo.XPView(this.components);
			this.transfersFromGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colTransferDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colToLocation = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTansferFromItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTransferFromItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTransferNumber = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colItemLot = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colExpirationDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTransferQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTransferFromExpirationDateFormat = new DevExpress.XtraGrid.Columns.GridColumn();
			this.receivingXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.receivingsGridControl = new DevExpress.XtraGrid.GridControl();
			this.receivingsXpView = new DevExpress.Xpo.XPView(this.components);
			this.receivingsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colReceivingDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReceivingItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReceivingItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReceivingItemType = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReceivingBOL = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReceivingLot = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReceivingItemExpirationDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReceivingQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReceivingExpirationDateFormat = new DevExpress.XtraGrid.Columns.GridColumn();
			this.receivingReturnsXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.receivingReturnsGridControl = new DevExpress.XtraGrid.GridControl();
			this.receivingReturnXpView = new DevExpress.Xpo.XPView(this.components);
			this.receivingReturnsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colReceivingReturnDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReceivingReturnItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReceivingReturnItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReceivingReturnBOL = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReceivingReturnLot = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReceivingReturnItemExpirationDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReceivingReturnQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReceivingReturnExpirationDateFormat = new DevExpress.XtraGrid.Columns.GridColumn();
			this.productionXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.productionGridControl = new DevExpress.XtraGrid.GridControl();
			this.productionXpView = new DevExpress.Xpo.XPView(this.components);
			this.productionGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colProductionDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colProductionItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colProductionItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colProductionPO = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colProductionLot = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPrdouctionExpirationDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colProductionQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colProductionExpirationDateFormat = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shippingsXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.shippingsGridControl = new DevExpress.XtraGrid.GridControl();
			this.shippingsXpView = new DevExpress.Xpo.XPView(this.components);
			this.shippingsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colShippingDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShippingItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShippingItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShippingBOL = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShippingLot = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShippingExpirationDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShippingQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShippingExpirationDateFormat = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shippingReturnsXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.shippingReturnsGridControl = new DevExpress.XtraGrid.GridControl();
			this.shippingReturnsXpView = new DevExpress.Xpo.XPView(this.components);
			this.shippingReturnsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colShippingReturnDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShippingReturnItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShippingReturnItemDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShippingReturnBOL = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShippingReturnLot = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShippingReturnExpirationDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShippingReturnQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShippingReturnExpirationDateFormat = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShippingItemType = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)this.BarManager1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.SplitContainerControl1).BeginInit();
			this.SplitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.locationSearchGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.locationSearchXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.locationSearchGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.locationsXtraTabControl).BeginInit();
			this.locationsXtraTabControl.SuspendLayout();
			this.generalXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
			this.GroupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.defaultWarehouseCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryAvailableCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.warehousingCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shippingCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.receivingCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.faxTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.phoneTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.zipCodeTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.stateTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.cityTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.addressTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.nameTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.codeTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.oidTextEdit.Properties).BeginInit();
			this.inventoryXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.inventoryGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.locationInventoryXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryGridView).BeginInit();
			this.inventoryByLotXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.inventoryByLotGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.locationInventoryByLotXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryByLotGridView).BeginInit();
			this.transfersXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.SplitContainerControl2).BeginInit();
			this.SplitContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.transfersToGroupControl).BeginInit();
			this.transfersToGroupControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.transfersToGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.transfersToXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.transfersToGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.transfersFromGroupControl).BeginInit();
			this.transfersFromGroupControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.transfersFromGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.transfersFromXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.transfersFromGridView).BeginInit();
			this.receivingXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.receivingsGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.receivingsXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.receivingsGridView).BeginInit();
			this.receivingReturnsXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.receivingReturnsGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.receivingReturnXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.receivingReturnsGridView).BeginInit();
			this.productionXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.productionGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionGridView).BeginInit();
			this.shippingsXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.shippingsGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shippingsXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shippingsGridView).BeginInit();
			this.shippingReturnsXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.shippingReturnsGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shippingReturnsXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shippingReturnsGridView).BeginInit();
			this.SuspendLayout();
			//
			//BarManager1
			//
			this.BarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.locationMenuBar, this.Bar2, this.Bar3});
			this.BarManager1.DockControls.Add(this.barDockControlTop);
			this.BarManager1.DockControls.Add(this.barDockControlBottom);
			this.BarManager1.DockControls.Add(this.barDockControlLeft);
			this.BarManager1.DockControls.Add(this.barDockControlRight);
			this.BarManager1.Form = this;
			this.BarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.addBarButtonItem, this.editBarButtonItem, this.deleteBarButtonItem, this.cancelBarButtonItem, this.saveBarButtonItem, this.printGridBarButtonItem});
			this.BarManager1.MainMenu = this.Bar2;
			this.BarManager1.MaxItemId = 6;
			this.BarManager1.StatusBar = this.Bar3;
			//
			//locationMenuBar
			//
			this.locationMenuBar.BarName = "Tools";
			this.locationMenuBar.DockCol = 0;
			this.locationMenuBar.DockRow = 1;
			this.locationMenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.locationMenuBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.addBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.editBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.deleteBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.cancelBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.saveBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.printGridBarButtonItem, true)
			});
			this.locationMenuBar.OptionsBar.UseWholeRow = true;
			this.locationMenuBar.Text = "Tools";
			//
			//addBarButtonItem
			//
			this.addBarButtonItem.Caption = "&Add Location";
			this.addBarButtonItem.Id = 0;
			this.addBarButtonItem.Name = "addBarButtonItem";
			//
			//editBarButtonItem
			//
			this.editBarButtonItem.Caption = "&Edit Location";
			this.editBarButtonItem.Id = 1;
			this.editBarButtonItem.Name = "editBarButtonItem";
			//
			//deleteBarButtonItem
			//
			this.deleteBarButtonItem.Caption = "Delete Location";
			this.deleteBarButtonItem.Id = 2;
			this.deleteBarButtonItem.Name = "deleteBarButtonItem";
			//
			//cancelBarButtonItem
			//
			this.cancelBarButtonItem.Caption = "&Cancel Changes";
			this.cancelBarButtonItem.Enabled = false;
			this.cancelBarButtonItem.Id = 3;
			this.cancelBarButtonItem.Name = "cancelBarButtonItem";
			//
			//saveBarButtonItem
			//
			this.saveBarButtonItem.Caption = "&Save Changes";
			this.saveBarButtonItem.Enabled = false;
			this.saveBarButtonItem.Id = 4;
			this.saveBarButtonItem.Name = "saveBarButtonItem";
			//
			//printGridBarButtonItem
			//
			this.printGridBarButtonItem.Caption = "&Print Grid";
			this.printGridBarButtonItem.Id = 5;
			this.printGridBarButtonItem.Name = "printGridBarButtonItem";
			//
			//Bar2
			//
			this.Bar2.BarName = "Main menu";
			this.Bar2.DockCol = 0;
			this.Bar2.DockRow = 0;
			this.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.Bar2.OptionsBar.MultiLine = true;
			this.Bar2.OptionsBar.UseWholeRow = true;
			this.Bar2.Text = "Main menu";
			//
			//Bar3
			//
			this.Bar3.BarName = "Status bar";
			this.Bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			this.Bar3.DockCol = 0;
			this.Bar3.DockRow = 0;
			this.Bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			this.Bar3.OptionsBar.AllowQuickCustomization = false;
			this.Bar3.OptionsBar.DrawDragBorder = false;
			this.Bar3.OptionsBar.UseWholeRow = true;
			this.Bar3.Text = "Status bar";
			//
			//barDockControlTop
			//
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.BarManager1;
			this.barDockControlTop.Size = new System.Drawing.Size(824, 49);
			//
			//barDockControlBottom
			//
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 538);
			this.barDockControlBottom.Manager = this.BarManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(824, 23);
			//
			//barDockControlLeft
			//
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 49);
			this.barDockControlLeft.Manager = this.BarManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 489);
			//
			//barDockControlRight
			//
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(824, 49);
			this.barDockControlRight.Manager = this.BarManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 489);
			//
			//SplitContainerControl1
			//
			this.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainerControl1.Location = new System.Drawing.Point(0, 49);
			this.SplitContainerControl1.Name = "SplitContainerControl1";
			this.SplitContainerControl1.Panel1.Controls.Add(this.locationSearchGridControl);
			this.SplitContainerControl1.Panel1.MinSize = 250;
			this.SplitContainerControl1.Panel1.Text = "Panel1";
			this.SplitContainerControl1.Panel2.Controls.Add(this.locationsXtraTabControl);
			this.SplitContainerControl1.Panel2.Text = "Panel2";
			this.SplitContainerControl1.Size = new System.Drawing.Size(824, 489);
			this.SplitContainerControl1.TabIndex = 4;
			this.SplitContainerControl1.Text = "SplitContainerControl1";
			//
			//locationSearchGridControl
			//
			this.locationSearchGridControl.DataSource = this.locationSearchXpView;
			this.locationSearchGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.locationSearchGridControl.Location = new System.Drawing.Point(0, 0);
			this.locationSearchGridControl.MainView = this.locationSearchGridView;
			this.locationSearchGridControl.MenuManager = this.BarManager1;
			this.locationSearchGridControl.Name = "locationSearchGridControl";
			this.locationSearchGridControl.Size = new System.Drawing.Size(250, 489);
			this.locationSearchGridControl.TabIndex = 0;
			this.locationSearchGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.locationSearchGridView});
			//
			//locationSearchXpView
			//
			this.locationSearchXpView.ObjectType = typeof(DXDAL.SPGData.Locations);
			this.locationSearchXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("Code", DevExpress.Xpo.SortDirection.None, "[LocationCode]", false, true),
				new DevExpress.Xpo.ViewProperty("Name", DevExpress.Xpo.SortDirection.Ascending, "[LocationName]", false, true),
				new DevExpress.Xpo.ViewProperty("LocationID", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true)
			});
			//
			//locationSearchGridView
			//
			this.locationSearchGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colCode, this.colName, this.colLocationID});
			this.locationSearchGridView.GridControl = this.locationSearchGridControl;
			this.locationSearchGridView.Name = "locationSearchGridView";
			this.locationSearchGridView.OptionsBehavior.Editable = false;
			this.locationSearchGridView.OptionsView.ShowAutoFilterRow = true;
			this.locationSearchGridView.OptionsView.ShowGroupPanel = false;
			//
			//colCode
			//
			this.colCode.FieldName = "Code";
			this.colCode.Name = "colCode";
			this.colCode.OptionsColumn.ReadOnly = true;
			this.colCode.Visible = true;
			this.colCode.VisibleIndex = 0;
			//
			//colName
			//
			this.colName.FieldName = "Name";
			this.colName.Name = "colName";
			this.colName.OptionsColumn.ReadOnly = true;
			this.colName.Visible = true;
			this.colName.VisibleIndex = 1;
			//
			//colLocationID
			//
			this.colLocationID.FieldName = "LocationID";
			this.colLocationID.Name = "colLocationID";
			this.colLocationID.OptionsColumn.ReadOnly = true;
			//
			//locationsXtraTabControl
			//
			this.locationsXtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.locationsXtraTabControl.Location = new System.Drawing.Point(0, 0);
			this.locationsXtraTabControl.Name = "locationsXtraTabControl";
			this.locationsXtraTabControl.SelectedTabPage = this.generalXtraTabPage;
			this.locationsXtraTabControl.Size = new System.Drawing.Size(569, 489);
			this.locationsXtraTabControl.TabIndex = 0;
			this.locationsXtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {this.generalXtraTabPage, this.inventoryXtraTabPage, this.inventoryByLotXtraTabPage, this.transfersXtraTabPage, this.receivingXtraTabPage, this.receivingReturnsXtraTabPage, this.productionXtraTabPage, this.shippingsXtraTabPage, this.shippingReturnsXtraTabPage});
			//
			//generalXtraTabPage
			//
			this.generalXtraTabPage.Controls.Add(this.GroupControl1);
			this.generalXtraTabPage.Controls.Add(this.faxTextEdit);
			this.generalXtraTabPage.Controls.Add(this.phoneTextEdit);
			this.generalXtraTabPage.Controls.Add(this.LabelControl6);
			this.generalXtraTabPage.Controls.Add(this.zipCodeTextEdit);
			this.generalXtraTabPage.Controls.Add(this.stateTextEdit);
			this.generalXtraTabPage.Controls.Add(this.cityTextEdit);
			this.generalXtraTabPage.Controls.Add(this.LabelControl5);
			this.generalXtraTabPage.Controls.Add(this.addressTextEdit);
			this.generalXtraTabPage.Controls.Add(this.LabelControl4);
			this.generalXtraTabPage.Controls.Add(this.nameTextEdit);
			this.generalXtraTabPage.Controls.Add(this.LabelControl3);
			this.generalXtraTabPage.Controls.Add(this.codeTextEdit);
			this.generalXtraTabPage.Controls.Add(this.LabelControl2);
			this.generalXtraTabPage.Controls.Add(this.oidTextEdit);
			this.generalXtraTabPage.Controls.Add(this.LabelControl1);
			this.generalXtraTabPage.Name = "generalXtraTabPage";
			this.generalXtraTabPage.Size = new System.Drawing.Size(563, 461);
			this.generalXtraTabPage.Text = "General Info";
			//
			//GroupControl1
			//
			this.GroupControl1.Controls.Add(this.defaultWarehouseCheckEdit);
			this.GroupControl1.Controls.Add(this.inventoryAvailableCheckEdit);
			this.GroupControl1.Controls.Add(this.warehousingCheckEdit);
			this.GroupControl1.Controls.Add(this.productionCheckEdit);
			this.GroupControl1.Controls.Add(this.shippingCheckEdit);
			this.GroupControl1.Controls.Add(this.receivingCheckEdit);
			this.GroupControl1.Location = new System.Drawing.Point(173, 267);
			this.GroupControl1.Name = "GroupControl1";
			this.GroupControl1.Size = new System.Drawing.Size(312, 103);
			this.GroupControl1.TabIndex = 15;
			this.GroupControl1.Text = "Location Functions";
			//
			//defaultWarehouseCheckEdit
			//
			this.defaultWarehouseCheckEdit.Enabled = false;
			this.defaultWarehouseCheckEdit.Location = new System.Drawing.Point(145, 75);
			this.defaultWarehouseCheckEdit.MenuManager = this.BarManager1;
			this.defaultWarehouseCheckEdit.Name = "defaultWarehouseCheckEdit";
			this.defaultWarehouseCheckEdit.Properties.Caption = "Default Warehouse";
			this.defaultWarehouseCheckEdit.Size = new System.Drawing.Size(133, 19);
			this.defaultWarehouseCheckEdit.TabIndex = 5;
			//
			//inventoryAvailableCheckEdit
			//
			this.inventoryAvailableCheckEdit.Location = new System.Drawing.Point(8, 75);
			this.inventoryAvailableCheckEdit.MenuManager = this.BarManager1;
			this.inventoryAvailableCheckEdit.Name = "inventoryAvailableCheckEdit";
			this.inventoryAvailableCheckEdit.Properties.Caption = "Inventory Available";
			this.inventoryAvailableCheckEdit.Size = new System.Drawing.Size(131, 19);
			this.inventoryAvailableCheckEdit.TabIndex = 4;
			//
			//warehousingCheckEdit
			//
			this.warehousingCheckEdit.Location = new System.Drawing.Point(143, 49);
			this.warehousingCheckEdit.MenuManager = this.BarManager1;
			this.warehousingCheckEdit.Name = "warehousingCheckEdit";
			this.warehousingCheckEdit.Properties.Caption = "Warehousing";
			this.warehousingCheckEdit.Size = new System.Drawing.Size(121, 19);
			this.warehousingCheckEdit.TabIndex = 3;
			//
			//productionCheckEdit
			//
			this.productionCheckEdit.Location = new System.Drawing.Point(6, 49);
			this.productionCheckEdit.MenuManager = this.BarManager1;
			this.productionCheckEdit.Name = "productionCheckEdit";
			this.productionCheckEdit.Properties.Caption = "Production";
			this.productionCheckEdit.Size = new System.Drawing.Size(75, 19);
			this.productionCheckEdit.TabIndex = 2;
			//
			//shippingCheckEdit
			//
			this.shippingCheckEdit.Location = new System.Drawing.Point(143, 24);
			this.shippingCheckEdit.MenuManager = this.BarManager1;
			this.shippingCheckEdit.Name = "shippingCheckEdit";
			this.shippingCheckEdit.Properties.Caption = "Shipping";
			this.shippingCheckEdit.Size = new System.Drawing.Size(75, 19);
			this.shippingCheckEdit.TabIndex = 1;
			//
			//receivingCheckEdit
			//
			this.receivingCheckEdit.Location = new System.Drawing.Point(6, 24);
			this.receivingCheckEdit.MenuManager = this.BarManager1;
			this.receivingCheckEdit.Name = "receivingCheckEdit";
			this.receivingCheckEdit.Properties.Caption = "Receiving";
			this.receivingCheckEdit.Size = new System.Drawing.Size(75, 19);
			this.receivingCheckEdit.TabIndex = 0;
			//
			//faxTextEdit
			//
			this.faxTextEdit.Location = new System.Drawing.Point(332, 229);
			this.faxTextEdit.MenuManager = this.BarManager1;
			this.faxTextEdit.Name = "faxTextEdit";
			this.faxTextEdit.Properties.NullText = "[Fax]";
			this.faxTextEdit.Size = new System.Drawing.Size(153, 20);
			this.faxTextEdit.TabIndex = 14;
			//
			//phoneTextEdit
			//
			this.phoneTextEdit.Location = new System.Drawing.Point(173, 229);
			this.phoneTextEdit.MenuManager = this.BarManager1;
			this.phoneTextEdit.Name = "phoneTextEdit";
			this.phoneTextEdit.Properties.NullText = "[Phone]";
			this.phoneTextEdit.Size = new System.Drawing.Size(153, 20);
			this.phoneTextEdit.TabIndex = 13;
			//
			//LabelControl6
			//
			this.LabelControl6.Location = new System.Drawing.Point(77, 233);
			this.LabelControl6.Name = "LabelControl6";
			this.LabelControl6.Size = new System.Drawing.Size(55, 13);
			this.LabelControl6.TabIndex = 12;
			this.LabelControl6.Text = "Phone Fax:";
			//
			//zipCodeTextEdit
			//
			this.zipCodeTextEdit.Location = new System.Drawing.Point(385, 194);
			this.zipCodeTextEdit.MenuManager = this.BarManager1;
			this.zipCodeTextEdit.Name = "zipCodeTextEdit";
			this.zipCodeTextEdit.Properties.NullText = "[Zip Code]";
			this.zipCodeTextEdit.Size = new System.Drawing.Size(100, 20);
			this.zipCodeTextEdit.TabIndex = 11;
			//
			//stateTextEdit
			//
			this.stateTextEdit.Location = new System.Drawing.Point(279, 194);
			this.stateTextEdit.MenuManager = this.BarManager1;
			this.stateTextEdit.Name = "stateTextEdit";
			this.stateTextEdit.Properties.NullText = "[State]";
			this.stateTextEdit.Size = new System.Drawing.Size(100, 20);
			this.stateTextEdit.TabIndex = 10;
			//
			//cityTextEdit
			//
			this.cityTextEdit.Location = new System.Drawing.Point(173, 194);
			this.cityTextEdit.MenuManager = this.BarManager1;
			this.cityTextEdit.Name = "cityTextEdit";
			this.cityTextEdit.Properties.NullText = "[City]";
			this.cityTextEdit.Size = new System.Drawing.Size(100, 20);
			this.cityTextEdit.TabIndex = 9;
			//
			//LabelControl5
			//
			this.LabelControl5.Location = new System.Drawing.Point(77, 197);
			this.LabelControl5.Name = "LabelControl5";
			this.LabelControl5.Size = new System.Drawing.Size(69, 13);
			this.LabelControl5.TabIndex = 8;
			this.LabelControl5.Text = "City State Zip:";
			//
			//addressTextEdit
			//
			this.addressTextEdit.Location = new System.Drawing.Point(173, 159);
			this.addressTextEdit.MenuManager = this.BarManager1;
			this.addressTextEdit.Name = "addressTextEdit";
			this.addressTextEdit.Size = new System.Drawing.Size(312, 20);
			this.addressTextEdit.TabIndex = 7;
			//
			//LabelControl4
			//
			this.LabelControl4.Location = new System.Drawing.Point(77, 162);
			this.LabelControl4.Name = "LabelControl4";
			this.LabelControl4.Size = new System.Drawing.Size(43, 13);
			this.LabelControl4.TabIndex = 6;
			this.LabelControl4.Text = "Address:";
			//
			//nameTextEdit
			//
			this.nameTextEdit.Location = new System.Drawing.Point(173, 124);
			this.nameTextEdit.MenuManager = this.BarManager1;
			this.nameTextEdit.Name = "nameTextEdit";
			this.nameTextEdit.Size = new System.Drawing.Size(312, 20);
			this.nameTextEdit.TabIndex = 5;
			//
			//LabelControl3
			//
			this.LabelControl3.Location = new System.Drawing.Point(77, 127);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(31, 13);
			this.LabelControl3.TabIndex = 4;
			this.LabelControl3.Text = "Name:";
			//
			//codeTextEdit
			//
			this.codeTextEdit.Location = new System.Drawing.Point(385, 89);
			this.codeTextEdit.MenuManager = this.BarManager1;
			this.codeTextEdit.Name = "codeTextEdit";
			this.codeTextEdit.Size = new System.Drawing.Size(100, 20);
			this.codeTextEdit.TabIndex = 3;
			//
			//LabelControl2
			//
			this.LabelControl2.Location = new System.Drawing.Point(329, 92);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(29, 13);
			this.LabelControl2.TabIndex = 2;
			this.LabelControl2.Text = "Code:";
			//
			//oidTextEdit
			//
			this.oidTextEdit.Enabled = false;
			this.oidTextEdit.Location = new System.Drawing.Point(173, 89);
			this.oidTextEdit.MenuManager = this.BarManager1;
			this.oidTextEdit.Name = "oidTextEdit";
			this.oidTextEdit.Properties.ReadOnly = true;
			this.oidTextEdit.Size = new System.Drawing.Size(100, 20);
			this.oidTextEdit.TabIndex = 1;
			//
			//LabelControl1
			//
			this.LabelControl1.Location = new System.Drawing.Point(77, 92);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(56, 13);
			this.LabelControl1.TabIndex = 0;
			this.LabelControl1.Text = "Internal ID:";
			//
			//inventoryXtraTabPage
			//
			this.inventoryXtraTabPage.Controls.Add(this.inventoryGridControl);
			this.inventoryXtraTabPage.Name = "inventoryXtraTabPage";
			this.inventoryXtraTabPage.Size = new System.Drawing.Size(563, 461);
			this.inventoryXtraTabPage.Text = "Inventory";
			//
			//inventoryGridControl
			//
			this.inventoryGridControl.DataSource = this.locationInventoryXpView;
			this.inventoryGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inventoryGridControl.Location = new System.Drawing.Point(0, 0);
			this.inventoryGridControl.MainView = this.inventoryGridView;
			this.inventoryGridControl.MenuManager = this.BarManager1;
			this.inventoryGridControl.Name = "inventoryGridControl";
			this.inventoryGridControl.Size = new System.Drawing.Size(563, 461);
			this.inventoryGridControl.TabIndex = 0;
			this.inventoryGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.inventoryGridView});
			//
			//locationInventoryXpView
			//
			this.locationInventoryXpView.CriteriaString = "[Location] Is Null";
			this.locationInventoryXpView.ObjectType = typeof(DXDAL.SPGData.LocationInventory);
			this.locationInventoryXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.Ascending, "[LocationInventoryItem.ItemCode]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemDescription", DevExpress.Xpo.SortDirection.None, "[LocationInventoryItem.ItemDescription]", false, true),
				new DevExpress.Xpo.ViewProperty("Quantity", DevExpress.Xpo.SortDirection.None, "[QuantityOnHand]", false, true)
			});
			//
			//inventoryGridView
			//
			this.inventoryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colItemCode, this.colItemDescription, this.colQuantity});
			this.inventoryGridView.GridControl = this.inventoryGridControl;
			this.inventoryGridView.Name = "inventoryGridView";
			this.inventoryGridView.OptionsBehavior.Editable = false;
			this.inventoryGridView.OptionsView.ShowAutoFilterRow = true;
			//
			//colItemCode
			//
			this.colItemCode.FieldName = "ItemCode";
			this.colItemCode.Name = "colItemCode";
			this.colItemCode.OptionsColumn.ReadOnly = true;
			this.colItemCode.Visible = true;
			this.colItemCode.VisibleIndex = 0;
			//
			//colItemDescription
			//
			this.colItemDescription.FieldName = "ItemDescription";
			this.colItemDescription.Name = "colItemDescription";
			this.colItemDescription.OptionsColumn.ReadOnly = true;
			this.colItemDescription.Visible = true;
			this.colItemDescription.VisibleIndex = 1;
			//
			//colQuantity
			//
			this.colQuantity.FieldName = "Quantity";
			this.colQuantity.Name = "colQuantity";
			this.colQuantity.OptionsColumn.ReadOnly = true;
			this.colQuantity.Visible = true;
			this.colQuantity.VisibleIndex = 2;
			//
			//inventoryByLotXtraTabPage
			//
			this.inventoryByLotXtraTabPage.Controls.Add(this.PrintLpnSimpleButton);
			this.inventoryByLotXtraTabPage.Controls.Add(this.inventoryByLotGridControl);
			this.inventoryByLotXtraTabPage.Name = "inventoryByLotXtraTabPage";
			this.inventoryByLotXtraTabPage.Size = new System.Drawing.Size(563, 461);
			this.inventoryByLotXtraTabPage.Text = "Inventory-Lot";
			//
			//PrintLpnSimpleButton
			//
			this.PrintLpnSimpleButton.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.PrintLpnSimpleButton.Location = new System.Drawing.Point(481, 3);
			this.PrintLpnSimpleButton.Name = "PrintLpnSimpleButton";
			this.PrintLpnSimpleButton.Size = new System.Drawing.Size(75, 23);
			this.PrintLpnSimpleButton.TabIndex = 2;
			this.PrintLpnSimpleButton.Text = "Print LPN`s";
			//
			//inventoryByLotGridControl
			//
			this.inventoryByLotGridControl.DataSource = this.locationInventoryByLotXpView;
			this.inventoryByLotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.inventoryByLotGridControl.Location = new System.Drawing.Point(0, 0);
			this.inventoryByLotGridControl.MainView = this.inventoryByLotGridView;
			this.inventoryByLotGridControl.MenuManager = this.BarManager1;
			this.inventoryByLotGridControl.Name = "inventoryByLotGridControl";
			this.inventoryByLotGridControl.Size = new System.Drawing.Size(563, 461);
			this.inventoryByLotGridControl.TabIndex = 1;
			this.inventoryByLotGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.inventoryByLotGridView});
			//
			//locationInventoryByLotXpView
			//
			this.locationInventoryByLotXpView.CriteriaString = "[Location] Is Null";
			this.locationInventoryByLotXpView.ObjectType = typeof(DXDAL.SPGData.LocationInventoryByLot);
			this.locationInventoryByLotXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.Ascending, "[LocationInventoryItem.ItemCode]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemDescription", DevExpress.Xpo.SortDirection.None, "[LocationInventoryItem.ItemDescription]", false, true),
				new DevExpress.Xpo.ViewProperty("ExpirationDate", DevExpress.Xpo.SortDirection.None, "[ExpirationDate]", false, true),
				new DevExpress.Xpo.ViewProperty("Lot", DevExpress.Xpo.SortDirection.None, "[LocationInventoryLot]", false, true),
				new DevExpress.Xpo.ViewProperty("LPNNumber", DevExpress.Xpo.SortDirection.None, "[LPNNumber]", false, true),
				new DevExpress.Xpo.ViewProperty("Quantity", DevExpress.Xpo.SortDirection.None, "[QuantityOnHand]", false, true)
			});
			//
			//inventoryByLotGridView
			//
			this.inventoryByLotGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colItemCode1, this.colItemDescription1, this.colExpirationDate1, this.colLot, this.colLPNNumber, this.colQuantity1});
			this.inventoryByLotGridView.GridControl = this.inventoryByLotGridControl;
			this.inventoryByLotGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", this.colQuantity1, "TOTAL        {0:#,##0.##}")});
			this.inventoryByLotGridView.Name = "inventoryByLotGridView";
			this.inventoryByLotGridView.OptionsBehavior.Editable = false;
			this.inventoryByLotGridView.OptionsView.ShowAutoFilterRow = true;
			this.inventoryByLotGridView.OptionsView.ShowFooter = true;
			//
			//colItemCode1
			//
			this.colItemCode1.FieldName = "ItemCode";
			this.colItemCode1.Name = "colItemCode1";
			this.colItemCode1.Visible = true;
			this.colItemCode1.VisibleIndex = 0;
			//
			//colItemDescription1
			//
			this.colItemDescription1.FieldName = "ItemDescription";
			this.colItemDescription1.Name = "colItemDescription1";
			this.colItemDescription1.Visible = true;
			this.colItemDescription1.VisibleIndex = 1;
			//
			//colExpirationDate1
			//
			this.colExpirationDate1.FieldName = "ExpirationDate";
			this.colExpirationDate1.Name = "colExpirationDate1";
			this.colExpirationDate1.Visible = true;
			this.colExpirationDate1.VisibleIndex = 4;
			//
			//colLot
			//
			this.colLot.FieldName = "Lot";
			this.colLot.Name = "colLot";
			this.colLot.Visible = true;
			this.colLot.VisibleIndex = 2;
			//
			//colLPNNumber
			//
			this.colLPNNumber.FieldName = "LPNNumber";
			this.colLPNNumber.Name = "colLPNNumber";
			this.colLPNNumber.Visible = true;
			this.colLPNNumber.VisibleIndex = 3;
			//
			//colQuantity1
			//
			this.colQuantity1.FieldName = "Quantity";
			this.colQuantity1.Name = "colQuantity1";
			this.colQuantity1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", "TOTAL        {0:#,##0.##}")});
			this.colQuantity1.Visible = true;
			this.colQuantity1.VisibleIndex = 5;
			//
			//transfersXtraTabPage
			//
			this.transfersXtraTabPage.Controls.Add(this.SplitContainerControl2);
			this.transfersXtraTabPage.Name = "transfersXtraTabPage";
			this.transfersXtraTabPage.Size = new System.Drawing.Size(563, 461);
			this.transfersXtraTabPage.Text = "Transfers";
			//
			//SplitContainerControl2
			//
			this.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainerControl2.Horizontal = false;
			this.SplitContainerControl2.Location = new System.Drawing.Point(0, 0);
			this.SplitContainerControl2.Name = "SplitContainerControl2";
			this.SplitContainerControl2.Panel1.Controls.Add(this.transfersToGroupControl);
			this.SplitContainerControl2.Panel1.Text = "Transactions To";
			this.SplitContainerControl2.Panel2.Controls.Add(this.transfersFromGroupControl);
			this.SplitContainerControl2.Panel2.Text = "Panel2";
			this.SplitContainerControl2.Size = new System.Drawing.Size(563, 461);
			this.SplitContainerControl2.SplitterPosition = 252;
			this.SplitContainerControl2.TabIndex = 2;
			this.SplitContainerControl2.Text = "SplitContainerControl2";
			//
			//transfersToGroupControl
			//
			this.transfersToGroupControl.Controls.Add(this.transfersToGridControl);
			this.transfersToGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.transfersToGroupControl.Location = new System.Drawing.Point(0, 0);
			this.transfersToGroupControl.Name = "transfersToGroupControl";
			this.transfersToGroupControl.Size = new System.Drawing.Size(563, 252);
			this.transfersToGroupControl.TabIndex = 0;
			this.transfersToGroupControl.Text = "Location Transfers To";
			//
			//transfersToGridControl
			//
			this.transfersToGridControl.DataSource = this.transfersToXpView;
			this.transfersToGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.transfersToGridControl.Location = new System.Drawing.Point(2, 20);
			this.transfersToGridControl.MainView = this.transfersToGridView;
			this.transfersToGridControl.MenuManager = this.BarManager1;
			this.transfersToGridControl.Name = "transfersToGridControl";
			this.transfersToGridControl.Size = new System.Drawing.Size(559, 230);
			this.transfersToGridControl.TabIndex = 1;
			this.transfersToGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.transfersToGridView});
			//
			//transfersToXpView
			//
			this.transfersToXpView.CriteriaString = "[Transfer.ToLocation] Is Null";
			this.transfersToXpView.ObjectType = typeof(DXDAL.SPGData.LocationTransferDetails);
			this.transfersToXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("TransferDate", DevExpress.Xpo.SortDirection.None, "[Transfer.TransferDate]", false, true),
				new DevExpress.Xpo.ViewProperty("FromLocation", DevExpress.Xpo.SortDirection.None, "[Transfer.FromLocation.LocationCode]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[TransferItem.ItemCode]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemDescription", DevExpress.Xpo.SortDirection.None, "[TransferItem.ItemDescription]", false, true),
				new DevExpress.Xpo.ViewProperty("TransferNumber", DevExpress.Xpo.SortDirection.None, "[Transfer.TransferNumber]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemLot", DevExpress.Xpo.SortDirection.None, "[TransferLot]", false, true),
				new DevExpress.Xpo.ViewProperty("ExpirationDate", DevExpress.Xpo.SortDirection.None, "[ItemExpirationDate]", false, true),
				new DevExpress.Xpo.ViewProperty("TransferQuantity", DevExpress.Xpo.SortDirection.None, "[TransferQuantity]", false, true),
				new DevExpress.Xpo.ViewProperty("ExpirationDateFormat", DevExpress.Xpo.SortDirection.None, "[TransferItem.ItemCustomerID.ExpirationDateFormat]", false, true)
			});
			//
			//transfersToGridView
			//
			this.transfersToGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colTransferToDate, this.colFromLocation, this.colTransferToItemCode, this.colTransferToItemDescription, this.colTransferToNumber, this.colTransferToItemLot, this.colTransferToExpirationDate, this.colTransferToQuantity, this.transferToExpirationDateFormatGridColumn});
			this.transfersToGridView.GridControl = this.transfersToGridControl;
			this.transfersToGridView.Name = "transfersToGridView";
			this.transfersToGridView.OptionsBehavior.Editable = false;
			this.transfersToGridView.OptionsView.ShowAutoFilterRow = true;
			//
			//colTransferToDate
			//
			this.colTransferToDate.Caption = "Date";
			this.colTransferToDate.FieldName = "TransferDate";
			this.colTransferToDate.Name = "colTransferToDate";
			this.colTransferToDate.OptionsColumn.ReadOnly = true;
			this.colTransferToDate.Visible = true;
			this.colTransferToDate.VisibleIndex = 0;
			//
			//colFromLocation
			//
			this.colFromLocation.FieldName = "FromLocation";
			this.colFromLocation.Name = "colFromLocation";
			this.colFromLocation.OptionsColumn.ReadOnly = true;
			this.colFromLocation.Visible = true;
			this.colFromLocation.VisibleIndex = 1;
			//
			//colTransferToItemCode
			//
			this.colTransferToItemCode.FieldName = "ItemCode";
			this.colTransferToItemCode.Name = "colTransferToItemCode";
			this.colTransferToItemCode.OptionsColumn.ReadOnly = true;
			this.colTransferToItemCode.Visible = true;
			this.colTransferToItemCode.VisibleIndex = 2;
			//
			//colTransferToItemDescription
			//
			this.colTransferToItemDescription.FieldName = "ItemDescription";
			this.colTransferToItemDescription.Name = "colTransferToItemDescription";
			this.colTransferToItemDescription.OptionsColumn.ReadOnly = true;
			this.colTransferToItemDescription.Visible = true;
			this.colTransferToItemDescription.VisibleIndex = 3;
			//
			//colTransferToNumber
			//
			this.colTransferToNumber.Caption = "Transfer #";
			this.colTransferToNumber.FieldName = "TransferNumber";
			this.colTransferToNumber.Name = "colTransferToNumber";
			this.colTransferToNumber.OptionsColumn.ReadOnly = true;
			this.colTransferToNumber.Visible = true;
			this.colTransferToNumber.VisibleIndex = 4;
			//
			//colTransferToItemLot
			//
			this.colTransferToItemLot.FieldName = "ItemLot";
			this.colTransferToItemLot.Name = "colTransferToItemLot";
			this.colTransferToItemLot.OptionsColumn.ReadOnly = true;
			this.colTransferToItemLot.Visible = true;
			this.colTransferToItemLot.VisibleIndex = 5;
			//
			//colTransferToExpirationDate
			//
			this.colTransferToExpirationDate.DisplayFormat.FormatString = "d";
			this.colTransferToExpirationDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.colTransferToExpirationDate.FieldName = "ExpirationDate";
			this.colTransferToExpirationDate.Name = "colTransferToExpirationDate";
			this.colTransferToExpirationDate.OptionsColumn.ReadOnly = true;
			this.colTransferToExpirationDate.Visible = true;
			this.colTransferToExpirationDate.VisibleIndex = 6;
			//
			//colTransferToQuantity
			//
			this.colTransferToQuantity.Caption = "Quantity";
			this.colTransferToQuantity.FieldName = "TransferQuantity";
			this.colTransferToQuantity.Name = "colTransferToQuantity";
			this.colTransferToQuantity.OptionsColumn.ReadOnly = true;
			this.colTransferToQuantity.Visible = true;
			this.colTransferToQuantity.VisibleIndex = 7;
			//
			//transferToExpirationDateFormatGridColumn
			//
			this.transferToExpirationDateFormatGridColumn.Caption = "GridColumn1";
			this.transferToExpirationDateFormatGridColumn.FieldName = "ExpirationDateFormat";
			this.transferToExpirationDateFormatGridColumn.Name = "transferToExpirationDateFormatGridColumn";
			//
			//transfersFromGroupControl
			//
			this.transfersFromGroupControl.Controls.Add(this.transfersFromGridControl);
			this.transfersFromGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.transfersFromGroupControl.Location = new System.Drawing.Point(0, 0);
			this.transfersFromGroupControl.Name = "transfersFromGroupControl";
			this.transfersFromGroupControl.Size = new System.Drawing.Size(563, 204);
			this.transfersFromGroupControl.TabIndex = 1;
			this.transfersFromGroupControl.Text = "Location Transfers From";
			//
			//transfersFromGridControl
			//
			this.transfersFromGridControl.DataSource = this.transfersFromXpView;
			this.transfersFromGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.transfersFromGridControl.Location = new System.Drawing.Point(2, 20);
			this.transfersFromGridControl.MainView = this.transfersFromGridView;
			this.transfersFromGridControl.MenuManager = this.BarManager1;
			this.transfersFromGridControl.Name = "transfersFromGridControl";
			this.transfersFromGridControl.Size = new System.Drawing.Size(559, 182);
			this.transfersFromGridControl.TabIndex = 1;
			this.transfersFromGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.transfersFromGridView});
			//
			//transfersFromXpView
			//
			this.transfersFromXpView.CriteriaString = "[Transfer.FromLocation] Is Null";
			this.transfersFromXpView.ObjectType = typeof(DXDAL.SPGData.LocationTransferDetails);
			this.transfersFromXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("TransferDate", DevExpress.Xpo.SortDirection.None, "[Transfer.TransferDate]", false, true),
				new DevExpress.Xpo.ViewProperty("ToLocation", DevExpress.Xpo.SortDirection.None, "[Transfer.ToLocation.LocationCode]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[TransferItem.ItemCode]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemDescription", DevExpress.Xpo.SortDirection.None, "[TransferItem.ItemDescription]", false, true),
				new DevExpress.Xpo.ViewProperty("TransferNumber", DevExpress.Xpo.SortDirection.None, "[Transfer.TransferNumber]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemLot", DevExpress.Xpo.SortDirection.None, "[TransferLot]", false, true),
				new DevExpress.Xpo.ViewProperty("ExpirationDate", DevExpress.Xpo.SortDirection.None, "[ItemExpirationDate]", false, true),
				new DevExpress.Xpo.ViewProperty("TransferQuantity", DevExpress.Xpo.SortDirection.None, "[TransferQuantity]", false, true),
				new DevExpress.Xpo.ViewProperty("ExpirationDateFormat", DevExpress.Xpo.SortDirection.None, "[TransferItem.ItemCustomerID.ExpirationDateFormat]", false, true)
			});
			//
			//transfersFromGridView
			//
			this.transfersFromGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colTransferDate, this.colToLocation, this.colTansferFromItemCode, this.colTransferFromItemDescription, this.colTransferNumber, this.colItemLot, this.colExpirationDate, this.colTransferQuantity, this.colTransferFromExpirationDateFormat});
			this.transfersFromGridView.GridControl = this.transfersFromGridControl;
			this.transfersFromGridView.Name = "transfersFromGridView";
			this.transfersFromGridView.OptionsBehavior.Editable = false;
			this.transfersFromGridView.OptionsView.ShowAutoFilterRow = true;
			//
			//colTransferDate
			//
			this.colTransferDate.Caption = "Date";
			this.colTransferDate.FieldName = "TransferDate";
			this.colTransferDate.Name = "colTransferDate";
			this.colTransferDate.OptionsColumn.ReadOnly = true;
			this.colTransferDate.Visible = true;
			this.colTransferDate.VisibleIndex = 0;
			//
			//colToLocation
			//
			this.colToLocation.FieldName = "ToLocation";
			this.colToLocation.Name = "colToLocation";
			this.colToLocation.OptionsColumn.ReadOnly = true;
			this.colToLocation.Visible = true;
			this.colToLocation.VisibleIndex = 1;
			//
			//colTansferFromItemCode
			//
			this.colTansferFromItemCode.FieldName = "ItemCode";
			this.colTansferFromItemCode.Name = "colTansferFromItemCode";
			this.colTansferFromItemCode.OptionsColumn.ReadOnly = true;
			this.colTansferFromItemCode.Visible = true;
			this.colTansferFromItemCode.VisibleIndex = 2;
			//
			//colTransferFromItemDescription
			//
			this.colTransferFromItemDescription.FieldName = "ItemDescription";
			this.colTransferFromItemDescription.Name = "colTransferFromItemDescription";
			this.colTransferFromItemDescription.OptionsColumn.ReadOnly = true;
			this.colTransferFromItemDescription.Visible = true;
			this.colTransferFromItemDescription.VisibleIndex = 3;
			//
			//colTransferNumber
			//
			this.colTransferNumber.Caption = "Transfer #";
			this.colTransferNumber.FieldName = "TransferNumber";
			this.colTransferNumber.Name = "colTransferNumber";
			this.colTransferNumber.OptionsColumn.ReadOnly = true;
			this.colTransferNumber.Visible = true;
			this.colTransferNumber.VisibleIndex = 4;
			//
			//colItemLot
			//
			this.colItemLot.FieldName = "ItemLot";
			this.colItemLot.Name = "colItemLot";
			this.colItemLot.OptionsColumn.ReadOnly = true;
			this.colItemLot.Visible = true;
			this.colItemLot.VisibleIndex = 5;
			//
			//colExpirationDate
			//
			this.colExpirationDate.FieldName = "ExpirationDate";
			this.colExpirationDate.Name = "colExpirationDate";
			this.colExpirationDate.OptionsColumn.ReadOnly = true;
			this.colExpirationDate.Visible = true;
			this.colExpirationDate.VisibleIndex = 6;
			//
			//colTransferQuantity
			//
			this.colTransferQuantity.Caption = "Quantity";
			this.colTransferQuantity.FieldName = "TransferQuantity";
			this.colTransferQuantity.Name = "colTransferQuantity";
			this.colTransferQuantity.OptionsColumn.ReadOnly = true;
			this.colTransferQuantity.Visible = true;
			this.colTransferQuantity.VisibleIndex = 7;
			//
			//colTransferFromExpirationDateFormat
			//
			this.colTransferFromExpirationDateFormat.Caption = "GridColumn1";
			this.colTransferFromExpirationDateFormat.FieldName = "ExpirationDateFormat";
			this.colTransferFromExpirationDateFormat.Name = "colTransferFromExpirationDateFormat";
			//
			//receivingXtraTabPage
			//
			this.receivingXtraTabPage.Controls.Add(this.receivingsGridControl);
			this.receivingXtraTabPage.Name = "receivingXtraTabPage";
			this.receivingXtraTabPage.PageVisible = false;
			this.receivingXtraTabPage.Size = new System.Drawing.Size(563, 461);
			this.receivingXtraTabPage.Text = "Receivings";
			//
			//receivingsGridControl
			//
			this.receivingsGridControl.DataSource = this.receivingsXpView;
			this.receivingsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.receivingsGridControl.Location = new System.Drawing.Point(0, 0);
			this.receivingsGridControl.MainView = this.receivingsGridView;
			this.receivingsGridControl.MenuManager = this.BarManager1;
			this.receivingsGridControl.Name = "receivingsGridControl";
			this.receivingsGridControl.Size = new System.Drawing.Size(563, 461);
			this.receivingsGridControl.TabIndex = 2;
			this.receivingsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.receivingsGridView});
			//
			//receivingsXpView
			//
			this.receivingsXpView.CriteriaString = "[ReceivMainID.ReceivingLocation] Is Null";
			this.receivingsXpView.ObjectType = typeof(DXDAL.SPGData.ReceivingDetail);
			this.receivingsXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("ReceivingDate", DevExpress.Xpo.SortDirection.None, "[ReceivMainID.ReceivDate]", false, true),
				new DevExpress.Xpo.ViewProperty("ReceivingItemCode", DevExpress.Xpo.SortDirection.None, "[ReceivDetItemID.ItemCode]", false, true),
				new DevExpress.Xpo.ViewProperty("ReceivingItemDescription", DevExpress.Xpo.SortDirection.None, "[ReceivDetItemID.ItemDescription]", false, true),
				new DevExpress.Xpo.ViewProperty("ReceivingBOL", DevExpress.Xpo.SortDirection.None, "[ReceivMainID.ReceivBOL]", false, true),
				new DevExpress.Xpo.ViewProperty("ReceivingLot", DevExpress.Xpo.SortDirection.None, "[ReceivDetLot]", false, true),
				new DevExpress.Xpo.ViewProperty("ReceivingItemExpirationDate", DevExpress.Xpo.SortDirection.None, "[ExpirationDate]", false, true),
				new DevExpress.Xpo.ViewProperty("ReceivingQuantity", DevExpress.Xpo.SortDirection.None, "[ReceivDetQty]", false, true),
				new DevExpress.Xpo.ViewProperty("receivingExpirationDateFormat", DevExpress.Xpo.SortDirection.None, "[ReceivDetItemID.ItemCustomerID.ExpirationDateFormat]", false, true),
				new DevExpress.Xpo.ViewProperty("ReceivingItemType", DevExpress.Xpo.SortDirection.None, "[ReceivDetItemID.ItemType]", false, true)
			});
			//
			//receivingsGridView
			//
			this.receivingsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colReceivingDate, this.colReceivingItemCode, this.colReceivingItemDescription, this.colReceivingItemType, this.colReceivingBOL, this.colReceivingLot, this.colReceivingItemExpirationDate, this.colReceivingQuantity, this.colReceivingExpirationDateFormat});
			this.receivingsGridView.GridControl = this.receivingsGridControl;
			this.receivingsGridView.Name = "receivingsGridView";
			this.receivingsGridView.OptionsBehavior.Editable = false;
			this.receivingsGridView.OptionsView.ShowAutoFilterRow = true;
			//
			//colReceivingDate
			//
			this.colReceivingDate.Caption = "Date";
			this.colReceivingDate.FieldName = "ReceivingDate";
			this.colReceivingDate.Name = "colReceivingDate";
			this.colReceivingDate.OptionsColumn.ReadOnly = true;
			this.colReceivingDate.Visible = true;
			this.colReceivingDate.VisibleIndex = 0;
			//
			//colReceivingItemCode
			//
			this.colReceivingItemCode.Caption = "Item Code";
			this.colReceivingItemCode.FieldName = "ReceivingItemCode";
			this.colReceivingItemCode.Name = "colReceivingItemCode";
			this.colReceivingItemCode.OptionsColumn.ReadOnly = true;
			this.colReceivingItemCode.Visible = true;
			this.colReceivingItemCode.VisibleIndex = 1;
			//
			//colReceivingItemDescription
			//
			this.colReceivingItemDescription.Caption = "Item Description";
			this.colReceivingItemDescription.FieldName = "ReceivingItemDescription";
			this.colReceivingItemDescription.Name = "colReceivingItemDescription";
			this.colReceivingItemDescription.OptionsColumn.ReadOnly = true;
			this.colReceivingItemDescription.Visible = true;
			this.colReceivingItemDescription.VisibleIndex = 2;
			//
			//colReceivingItemType
			//
			this.colReceivingItemType.Caption = "Item Type";
			this.colReceivingItemType.FieldName = "ReceivingItemType";
			this.colReceivingItemType.Name = "colReceivingItemType";
			this.colReceivingItemType.Visible = true;
			this.colReceivingItemType.VisibleIndex = 3;
			//
			//colReceivingBOL
			//
			this.colReceivingBOL.Caption = "BOL #";
			this.colReceivingBOL.FieldName = "ReceivingBOL";
			this.colReceivingBOL.Name = "colReceivingBOL";
			this.colReceivingBOL.OptionsColumn.ReadOnly = true;
			this.colReceivingBOL.Visible = true;
			this.colReceivingBOL.VisibleIndex = 4;
			//
			//colReceivingLot
			//
			this.colReceivingLot.Caption = "Lot #";
			this.colReceivingLot.FieldName = "ReceivingLot";
			this.colReceivingLot.Name = "colReceivingLot";
			this.colReceivingLot.OptionsColumn.ReadOnly = true;
			this.colReceivingLot.Visible = true;
			this.colReceivingLot.VisibleIndex = 5;
			//
			//colReceivingItemExpirationDate
			//
			this.colReceivingItemExpirationDate.Caption = "Expiration Date";
			this.colReceivingItemExpirationDate.FieldName = "ReceivingItemExpirationDate";
			this.colReceivingItemExpirationDate.Name = "colReceivingItemExpirationDate";
			this.colReceivingItemExpirationDate.OptionsColumn.ReadOnly = true;
			this.colReceivingItemExpirationDate.Visible = true;
			this.colReceivingItemExpirationDate.VisibleIndex = 6;
			//
			//colReceivingQuantity
			//
			this.colReceivingQuantity.Caption = "Quantity";
			this.colReceivingQuantity.FieldName = "ReceivingQuantity";
			this.colReceivingQuantity.Name = "colReceivingQuantity";
			this.colReceivingQuantity.OptionsColumn.ReadOnly = true;
			this.colReceivingQuantity.Visible = true;
			this.colReceivingQuantity.VisibleIndex = 7;
			//
			//colReceivingExpirationDateFormat
			//
			this.colReceivingExpirationDateFormat.Caption = "GridColumn1";
			this.colReceivingExpirationDateFormat.FieldName = "receivingExpirationDateFormat";
			this.colReceivingExpirationDateFormat.Name = "colReceivingExpirationDateFormat";
			//
			//receivingReturnsXtraTabPage
			//
			this.receivingReturnsXtraTabPage.Controls.Add(this.receivingReturnsGridControl);
			this.receivingReturnsXtraTabPage.Name = "receivingReturnsXtraTabPage";
			this.receivingReturnsXtraTabPage.PageVisible = false;
			this.receivingReturnsXtraTabPage.Size = new System.Drawing.Size(563, 461);
			this.receivingReturnsXtraTabPage.Text = "Receiving Returns";
			//
			//receivingReturnsGridControl
			//
			this.receivingReturnsGridControl.DataSource = this.receivingReturnXpView;
			this.receivingReturnsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.receivingReturnsGridControl.Location = new System.Drawing.Point(0, 0);
			this.receivingReturnsGridControl.MainView = this.receivingReturnsGridView;
			this.receivingReturnsGridControl.MenuManager = this.BarManager1;
			this.receivingReturnsGridControl.Name = "receivingReturnsGridControl";
			this.receivingReturnsGridControl.Size = new System.Drawing.Size(563, 461);
			this.receivingReturnsGridControl.TabIndex = 2;
			this.receivingReturnsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.receivingReturnsGridView});
			//
			//receivingReturnXpView
			//
			this.receivingReturnXpView.CriteriaString = "[ReceiveMainID.ReceivingLocation] Is Null";
			this.receivingReturnXpView.ObjectType = typeof(DXDAL.SPGData.ReceivedReturns);
			this.receivingReturnXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("ReceivingReturnDate", DevExpress.Xpo.SortDirection.None, "[ReceiveMainID.ReceivDate]", false, true),
				new DevExpress.Xpo.ViewProperty("ReceivingReturnItemCode", DevExpress.Xpo.SortDirection.None, "[ReturnDetItemID.ItemCode]", false, true),
				new DevExpress.Xpo.ViewProperty("ReceivingReturnItemDescription", DevExpress.Xpo.SortDirection.None, "[ReturnDetItemID.ItemDescription]", false, true),
				new DevExpress.Xpo.ViewProperty("ReceivingReturnBOL", DevExpress.Xpo.SortDirection.None, "[ReceiveMainID.ReceivBOL]", false, true),
				new DevExpress.Xpo.ViewProperty("ReceivingReturnLot", DevExpress.Xpo.SortDirection.None, "[ReturnDetLot]", false, true),
				new DevExpress.Xpo.ViewProperty("ReceivingReturnItemExpirationDate", DevExpress.Xpo.SortDirection.None, "[ExpirationDate]", false, true),
				new DevExpress.Xpo.ViewProperty("ReceivingReturnQuantity", DevExpress.Xpo.SortDirection.None, "[ReturnDetQty]", false, true),
				new DevExpress.Xpo.ViewProperty("ReceivingReturnExpirationDateFromat", DevExpress.Xpo.SortDirection.None, "[ReturnDetItemID.ItemCustomerID.ExpirationDateFormat]", false, true)
			});
			//
			//receivingReturnsGridView
			//
			this.receivingReturnsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colReceivingReturnDate, this.colReceivingReturnItemCode, this.colReceivingReturnItemDescription, this.colReceivingReturnBOL, this.colReceivingReturnLot, this.colReceivingReturnItemExpirationDate, this.colReceivingReturnQuantity, this.colReceivingReturnExpirationDateFormat});
			this.receivingReturnsGridView.GridControl = this.receivingReturnsGridControl;
			this.receivingReturnsGridView.Name = "receivingReturnsGridView";
			this.receivingReturnsGridView.OptionsBehavior.Editable = false;
			this.receivingReturnsGridView.OptionsView.ShowAutoFilterRow = true;
			//
			//colReceivingReturnDate
			//
			this.colReceivingReturnDate.Caption = "Date";
			this.colReceivingReturnDate.FieldName = "ReceivingReturnDate";
			this.colReceivingReturnDate.Name = "colReceivingReturnDate";
			this.colReceivingReturnDate.OptionsColumn.ReadOnly = true;
			this.colReceivingReturnDate.Visible = true;
			this.colReceivingReturnDate.VisibleIndex = 0;
			//
			//colReceivingReturnItemCode
			//
			this.colReceivingReturnItemCode.Caption = "Item Code";
			this.colReceivingReturnItemCode.FieldName = "ReceivingReturnItemCode";
			this.colReceivingReturnItemCode.Name = "colReceivingReturnItemCode";
			this.colReceivingReturnItemCode.OptionsColumn.ReadOnly = true;
			this.colReceivingReturnItemCode.Visible = true;
			this.colReceivingReturnItemCode.VisibleIndex = 1;
			//
			//colReceivingReturnItemDescription
			//
			this.colReceivingReturnItemDescription.Caption = "Item Description";
			this.colReceivingReturnItemDescription.FieldName = "ReceivingReturnItemDescription";
			this.colReceivingReturnItemDescription.Name = "colReceivingReturnItemDescription";
			this.colReceivingReturnItemDescription.OptionsColumn.ReadOnly = true;
			this.colReceivingReturnItemDescription.Visible = true;
			this.colReceivingReturnItemDescription.VisibleIndex = 2;
			//
			//colReceivingReturnBOL
			//
			this.colReceivingReturnBOL.Caption = "BOL #";
			this.colReceivingReturnBOL.FieldName = "ReceivingReturnBOL";
			this.colReceivingReturnBOL.Name = "colReceivingReturnBOL";
			this.colReceivingReturnBOL.OptionsColumn.ReadOnly = true;
			this.colReceivingReturnBOL.Visible = true;
			this.colReceivingReturnBOL.VisibleIndex = 3;
			//
			//colReceivingReturnLot
			//
			this.colReceivingReturnLot.Caption = "Lot #";
			this.colReceivingReturnLot.FieldName = "ReceivingReturnLot";
			this.colReceivingReturnLot.Name = "colReceivingReturnLot";
			this.colReceivingReturnLot.OptionsColumn.ReadOnly = true;
			this.colReceivingReturnLot.Visible = true;
			this.colReceivingReturnLot.VisibleIndex = 4;
			//
			//colReceivingReturnItemExpirationDate
			//
			this.colReceivingReturnItemExpirationDate.Caption = "Expiration Date";
			this.colReceivingReturnItemExpirationDate.FieldName = "ReceivingReturnItemExpirationDate";
			this.colReceivingReturnItemExpirationDate.Name = "colReceivingReturnItemExpirationDate";
			this.colReceivingReturnItemExpirationDate.OptionsColumn.ReadOnly = true;
			this.colReceivingReturnItemExpirationDate.Visible = true;
			this.colReceivingReturnItemExpirationDate.VisibleIndex = 5;
			//
			//colReceivingReturnQuantity
			//
			this.colReceivingReturnQuantity.Caption = "Quantity";
			this.colReceivingReturnQuantity.FieldName = "ReceivingReturnQuantity";
			this.colReceivingReturnQuantity.Name = "colReceivingReturnQuantity";
			this.colReceivingReturnQuantity.OptionsColumn.ReadOnly = true;
			this.colReceivingReturnQuantity.Visible = true;
			this.colReceivingReturnQuantity.VisibleIndex = 6;
			//
			//colReceivingReturnExpirationDateFormat
			//
			this.colReceivingReturnExpirationDateFormat.Caption = "GridColumn1";
			this.colReceivingReturnExpirationDateFormat.FieldName = "ReceivingReturnExpirationDateFromat";
			this.colReceivingReturnExpirationDateFormat.Name = "colReceivingReturnExpirationDateFormat";
			//
			//productionXtraTabPage
			//
			this.productionXtraTabPage.Controls.Add(this.productionGridControl);
			this.productionXtraTabPage.Name = "productionXtraTabPage";
			this.productionXtraTabPage.PageVisible = false;
			this.productionXtraTabPage.Size = new System.Drawing.Size(563, 461);
			this.productionXtraTabPage.Text = "Production";
			//
			//productionGridControl
			//
			this.productionGridControl.DataSource = this.productionXpView;
			this.productionGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.productionGridControl.Location = new System.Drawing.Point(0, 0);
			this.productionGridControl.MainView = this.productionGridView;
			this.productionGridControl.MenuManager = this.BarManager1;
			this.productionGridControl.Name = "productionGridControl";
			this.productionGridControl.Size = new System.Drawing.Size(563, 461);
			this.productionGridControl.TabIndex = 2;
			this.productionGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.productionGridView});
			//
			//productionXpView
			//
			this.productionXpView.CriteriaString = "[ProductionLocation] Is Null";
			this.productionXpView.ObjectType = typeof(DXDAL.SPGData.Inventory);
			this.productionXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("ProductionDate", DevExpress.Xpo.SortDirection.None, "[InventoryDate]", false, true),
				new DevExpress.Xpo.ViewProperty("ProductionItemCode", DevExpress.Xpo.SortDirection.None, "[InventoryItemID.ItemCode]", false, true),
				new DevExpress.Xpo.ViewProperty("ProductionItemDescription", DevExpress.Xpo.SortDirection.None, "[InventoryItemID.ItemDescription]", false, true),
				new DevExpress.Xpo.ViewProperty("ProductionPO", DevExpress.Xpo.SortDirection.None, "[PO]", false, true),
				new DevExpress.Xpo.ViewProperty("ProductionLot", DevExpress.Xpo.SortDirection.None, "[Lot]", false, true),
				new DevExpress.Xpo.ViewProperty("PrdouctionExpirationDate", DevExpress.Xpo.SortDirection.None, "[ExpirationDate]", false, true),
				new DevExpress.Xpo.ViewProperty("ProductionQuantity", DevExpress.Xpo.SortDirection.None, "[InventoryQuantity]", false, true),
				new DevExpress.Xpo.ViewProperty("PrdouctionExpirationDateFormat", DevExpress.Xpo.SortDirection.None, "[InventoryItemID.ItemCustomerID.ExpirationDateFormat]", false, true)
			});
			//
			//productionGridView
			//
			this.productionGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colProductionDate, this.colProductionItemCode, this.colProductionItemDescription, this.colProductionPO, this.colProductionLot, this.colPrdouctionExpirationDate, this.colProductionQuantity, this.colProductionExpirationDateFormat});
			this.productionGridView.GridControl = this.productionGridControl;
			this.productionGridView.Name = "productionGridView";
			this.productionGridView.OptionsBehavior.Editable = false;
			this.productionGridView.OptionsView.ShowAutoFilterRow = true;
			//
			//colProductionDate
			//
			this.colProductionDate.Caption = "Date";
			this.colProductionDate.FieldName = "ProductionDate";
			this.colProductionDate.Name = "colProductionDate";
			this.colProductionDate.OptionsColumn.ReadOnly = true;
			this.colProductionDate.Visible = true;
			this.colProductionDate.VisibleIndex = 0;
			//
			//colProductionItemCode
			//
			this.colProductionItemCode.Caption = "Item Code";
			this.colProductionItemCode.FieldName = "ProductionItemCode";
			this.colProductionItemCode.Name = "colProductionItemCode";
			this.colProductionItemCode.OptionsColumn.ReadOnly = true;
			this.colProductionItemCode.Visible = true;
			this.colProductionItemCode.VisibleIndex = 1;
			//
			//colProductionItemDescription
			//
			this.colProductionItemDescription.Caption = "Item Description";
			this.colProductionItemDescription.FieldName = "ProductionItemDescription";
			this.colProductionItemDescription.Name = "colProductionItemDescription";
			this.colProductionItemDescription.OptionsColumn.ReadOnly = true;
			this.colProductionItemDescription.Visible = true;
			this.colProductionItemDescription.VisibleIndex = 2;
			//
			//colProductionPO
			//
			this.colProductionPO.Caption = "PO #";
			this.colProductionPO.FieldName = "ProductionPO";
			this.colProductionPO.Name = "colProductionPO";
			this.colProductionPO.OptionsColumn.ReadOnly = true;
			this.colProductionPO.Visible = true;
			this.colProductionPO.VisibleIndex = 3;
			//
			//colProductionLot
			//
			this.colProductionLot.Caption = "Lot #";
			this.colProductionLot.FieldName = "ProductionLot";
			this.colProductionLot.Name = "colProductionLot";
			this.colProductionLot.OptionsColumn.ReadOnly = true;
			this.colProductionLot.Visible = true;
			this.colProductionLot.VisibleIndex = 4;
			//
			//colPrdouctionExpirationDate
			//
			this.colPrdouctionExpirationDate.Caption = "Expiration Date";
			this.colPrdouctionExpirationDate.FieldName = "PrdouctionExpirationDate";
			this.colPrdouctionExpirationDate.Name = "colPrdouctionExpirationDate";
			this.colPrdouctionExpirationDate.OptionsColumn.ReadOnly = true;
			this.colPrdouctionExpirationDate.Visible = true;
			this.colPrdouctionExpirationDate.VisibleIndex = 5;
			//
			//colProductionQuantity
			//
			this.colProductionQuantity.Caption = "Quantity";
			this.colProductionQuantity.FieldName = "ProductionQuantity";
			this.colProductionQuantity.Name = "colProductionQuantity";
			this.colProductionQuantity.OptionsColumn.ReadOnly = true;
			this.colProductionQuantity.Visible = true;
			this.colProductionQuantity.VisibleIndex = 6;
			//
			//colProductionExpirationDateFormat
			//
			this.colProductionExpirationDateFormat.Caption = "GridColumn1";
			this.colProductionExpirationDateFormat.FieldName = "PrdouctionExpirationDateFormat";
			this.colProductionExpirationDateFormat.Name = "colProductionExpirationDateFormat";
			//
			//shippingsXtraTabPage
			//
			this.shippingsXtraTabPage.Controls.Add(this.shippingsGridControl);
			this.shippingsXtraTabPage.Name = "shippingsXtraTabPage";
			this.shippingsXtraTabPage.PageVisible = false;
			this.shippingsXtraTabPage.Size = new System.Drawing.Size(563, 461);
			this.shippingsXtraTabPage.Text = "Shippings";
			//
			//shippingsGridControl
			//
			this.shippingsGridControl.DataSource = this.shippingsXpView;
			this.shippingsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.shippingsGridControl.Location = new System.Drawing.Point(0, 0);
			this.shippingsGridControl.MainView = this.shippingsGridView;
			this.shippingsGridControl.MenuManager = this.BarManager1;
			this.shippingsGridControl.Name = "shippingsGridControl";
			this.shippingsGridControl.Size = new System.Drawing.Size(563, 461);
			this.shippingsGridControl.TabIndex = 2;
			this.shippingsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.shippingsGridView});
			//
			//shippingsXpView
			//
			this.shippingsXpView.CriteriaString = "[ShipDetMainID.ShippingLocation] Is Null";
			this.shippingsXpView.ObjectType = typeof(DXDAL.SPGData.ShipDet);
			this.shippingsXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("ShippingDate", DevExpress.Xpo.SortDirection.None, "[ShipDetMainID.ShipMainDate]", false, true),
				new DevExpress.Xpo.ViewProperty("ShippingItemCode", DevExpress.Xpo.SortDirection.None, "[ShipDetItemID.ItemCode]", false, true),
				new DevExpress.Xpo.ViewProperty("ShippingItemDescription", DevExpress.Xpo.SortDirection.None, "[ShipDetItemID.ItemDescription]", false, true),
				new DevExpress.Xpo.ViewProperty("ShippingBOL", DevExpress.Xpo.SortDirection.None, "[ShipDetMainID.ShipMainBOL]", false, true),
				new DevExpress.Xpo.ViewProperty("ShippingLot", DevExpress.Xpo.SortDirection.None, "[ShipDetLot]", false, true),
				new DevExpress.Xpo.ViewProperty("ShippingExpirationDate", DevExpress.Xpo.SortDirection.None, "[ExpirationDate]", false, true),
				new DevExpress.Xpo.ViewProperty("ShippingQuantity", DevExpress.Xpo.SortDirection.None, "[ShipDetDetQty]", false, true),
				new DevExpress.Xpo.ViewProperty("ShippingExpirationDateFormat", DevExpress.Xpo.SortDirection.None, "[ShipDetItemID.ItemCustomerID.ExpirationDateFormat]", false, true),
				new DevExpress.Xpo.ViewProperty("ShipDetItemType", DevExpress.Xpo.SortDirection.None, "[ShipDetItemID.ItemType]", false, true)
			});
			//
			//shippingsGridView
			//
			this.shippingsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colShippingDate, this.colShippingItemCode, this.colShippingItemDescription, this.colShippingBOL, this.colShippingLot, this.colShippingExpirationDate, this.colShippingQuantity, this.colShippingExpirationDateFormat, this.colShippingItemType});
			this.shippingsGridView.GridControl = this.shippingsGridControl;
			this.shippingsGridView.Name = "shippingsGridView";
			this.shippingsGridView.OptionsBehavior.Editable = false;
			this.shippingsGridView.OptionsView.ShowAutoFilterRow = true;
			//
			//colShippingDate
			//
			this.colShippingDate.Caption = "Date";
			this.colShippingDate.FieldName = "ShippingDate";
			this.colShippingDate.Name = "colShippingDate";
			this.colShippingDate.OptionsColumn.ReadOnly = true;
			this.colShippingDate.Visible = true;
			this.colShippingDate.VisibleIndex = 0;
			//
			//colShippingItemCode
			//
			this.colShippingItemCode.Caption = "Item Code";
			this.colShippingItemCode.FieldName = "ShippingItemCode";
			this.colShippingItemCode.Name = "colShippingItemCode";
			this.colShippingItemCode.OptionsColumn.ReadOnly = true;
			this.colShippingItemCode.Visible = true;
			this.colShippingItemCode.VisibleIndex = 1;
			//
			//colShippingItemDescription
			//
			this.colShippingItemDescription.Caption = "Item Description";
			this.colShippingItemDescription.FieldName = "ShippingItemDescription";
			this.colShippingItemDescription.Name = "colShippingItemDescription";
			this.colShippingItemDescription.OptionsColumn.ReadOnly = true;
			this.colShippingItemDescription.Visible = true;
			this.colShippingItemDescription.VisibleIndex = 2;
			//
			//colShippingBOL
			//
			this.colShippingBOL.Caption = "BOL #";
			this.colShippingBOL.FieldName = "ShippingBOL";
			this.colShippingBOL.Name = "colShippingBOL";
			this.colShippingBOL.OptionsColumn.ReadOnly = true;
			this.colShippingBOL.Visible = true;
			this.colShippingBOL.VisibleIndex = 4;
			//
			//colShippingLot
			//
			this.colShippingLot.Caption = "Lot #";
			this.colShippingLot.FieldName = "ShippingLot";
			this.colShippingLot.Name = "colShippingLot";
			this.colShippingLot.OptionsColumn.ReadOnly = true;
			this.colShippingLot.Visible = true;
			this.colShippingLot.VisibleIndex = 5;
			//
			//colShippingExpirationDate
			//
			this.colShippingExpirationDate.Caption = "Expiration Date";
			this.colShippingExpirationDate.FieldName = "ShippingExpirationDate";
			this.colShippingExpirationDate.Name = "colShippingExpirationDate";
			this.colShippingExpirationDate.OptionsColumn.ReadOnly = true;
			this.colShippingExpirationDate.Visible = true;
			this.colShippingExpirationDate.VisibleIndex = 6;
			//
			//colShippingQuantity
			//
			this.colShippingQuantity.Caption = "Quantity";
			this.colShippingQuantity.FieldName = "ShippingQuantity";
			this.colShippingQuantity.Name = "colShippingQuantity";
			this.colShippingQuantity.OptionsColumn.ReadOnly = true;
			this.colShippingQuantity.Visible = true;
			this.colShippingQuantity.VisibleIndex = 7;
			//
			//colShippingExpirationDateFormat
			//
			this.colShippingExpirationDateFormat.Caption = "GridColumn1";
			this.colShippingExpirationDateFormat.FieldName = "ShippingExpirationDateFormat";
			this.colShippingExpirationDateFormat.Name = "colShippingExpirationDateFormat";
			//
			//shippingReturnsXtraTabPage
			//
			this.shippingReturnsXtraTabPage.Controls.Add(this.shippingReturnsGridControl);
			this.shippingReturnsXtraTabPage.Name = "shippingReturnsXtraTabPage";
			this.shippingReturnsXtraTabPage.PageVisible = false;
			this.shippingReturnsXtraTabPage.Size = new System.Drawing.Size(563, 461);
			this.shippingReturnsXtraTabPage.Text = "Shipping Returns";
			//
			//shippingReturnsGridControl
			//
			this.shippingReturnsGridControl.DataSource = this.shippingReturnsXpView;
			this.shippingReturnsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.shippingReturnsGridControl.Location = new System.Drawing.Point(0, 0);
			this.shippingReturnsGridControl.MainView = this.shippingReturnsGridView;
			this.shippingReturnsGridControl.MenuManager = this.BarManager1;
			this.shippingReturnsGridControl.Name = "shippingReturnsGridControl";
			this.shippingReturnsGridControl.Size = new System.Drawing.Size(563, 461);
			this.shippingReturnsGridControl.TabIndex = 2;
			this.shippingReturnsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.shippingReturnsGridView});
			//
			//shippingReturnsXpView
			//
			this.shippingReturnsXpView.CriteriaString = "[ShipMainID.ShippingLocation] Is Null";
			this.shippingReturnsXpView.ObjectType = typeof(DXDAL.SPGData.ShippedReturns);
			this.shippingReturnsXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("ShippingReturnDate", DevExpress.Xpo.SortDirection.None, "[ShipMainID.ShipMainDate]", false, true),
				new DevExpress.Xpo.ViewProperty("ShippingReturnItemCode", DevExpress.Xpo.SortDirection.None, "[ReturnDetItemID.ItemCode]", false, true),
				new DevExpress.Xpo.ViewProperty("ShippingReturnItemDescription", DevExpress.Xpo.SortDirection.None, "[ReturnDetItemID.ItemDescription]", false, true),
				new DevExpress.Xpo.ViewProperty("ShippingReturnBOL", DevExpress.Xpo.SortDirection.None, "[ShipMainID.ShipMainBOL]", false, true),
				new DevExpress.Xpo.ViewProperty("ShippingReturnLot", DevExpress.Xpo.SortDirection.None, "[ReturnDetLot]", false, true),
				new DevExpress.Xpo.ViewProperty("ShippingReturnExpirationDate", DevExpress.Xpo.SortDirection.None, "[ExpirationDate]", false, true),
				new DevExpress.Xpo.ViewProperty("ShippingReturnQuantity", DevExpress.Xpo.SortDirection.None, "[ReturnDetQty]", false, true),
				new DevExpress.Xpo.ViewProperty("ShippingReturnExpirationDateFormat", DevExpress.Xpo.SortDirection.None, "[ReturnDetItemID.ItemCustomerID.ExpirationDateFormat]", false, true)
			});
			//
			//shippingReturnsGridView
			//
			this.shippingReturnsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colShippingReturnDate, this.colShippingReturnItemCode, this.colShippingReturnItemDescription, this.colShippingReturnBOL, this.colShippingReturnLot, this.colShippingReturnExpirationDate, this.colShippingReturnQuantity, this.colShippingReturnExpirationDateFormat});
			this.shippingReturnsGridView.GridControl = this.shippingReturnsGridControl;
			this.shippingReturnsGridView.Name = "shippingReturnsGridView";
			this.shippingReturnsGridView.OptionsBehavior.Editable = false;
			this.shippingReturnsGridView.OptionsView.ShowAutoFilterRow = true;
			//
			//colShippingReturnDate
			//
			this.colShippingReturnDate.Caption = "Date";
			this.colShippingReturnDate.FieldName = "ShippingReturnDate";
			this.colShippingReturnDate.Name = "colShippingReturnDate";
			this.colShippingReturnDate.OptionsColumn.ReadOnly = true;
			this.colShippingReturnDate.Visible = true;
			this.colShippingReturnDate.VisibleIndex = 0;
			//
			//colShippingReturnItemCode
			//
			this.colShippingReturnItemCode.Caption = "Item Code";
			this.colShippingReturnItemCode.FieldName = "ShippingReturnItemCode";
			this.colShippingReturnItemCode.Name = "colShippingReturnItemCode";
			this.colShippingReturnItemCode.OptionsColumn.ReadOnly = true;
			this.colShippingReturnItemCode.Visible = true;
			this.colShippingReturnItemCode.VisibleIndex = 1;
			//
			//colShippingReturnItemDescription
			//
			this.colShippingReturnItemDescription.Caption = "Item Description";
			this.colShippingReturnItemDescription.FieldName = "ShippingReturnItemDescription";
			this.colShippingReturnItemDescription.Name = "colShippingReturnItemDescription";
			this.colShippingReturnItemDescription.OptionsColumn.ReadOnly = true;
			this.colShippingReturnItemDescription.Visible = true;
			this.colShippingReturnItemDescription.VisibleIndex = 2;
			//
			//colShippingReturnBOL
			//
			this.colShippingReturnBOL.Caption = "BOL #";
			this.colShippingReturnBOL.FieldName = "ShippingReturnBOL";
			this.colShippingReturnBOL.Name = "colShippingReturnBOL";
			this.colShippingReturnBOL.OptionsColumn.ReadOnly = true;
			this.colShippingReturnBOL.Visible = true;
			this.colShippingReturnBOL.VisibleIndex = 3;
			//
			//colShippingReturnLot
			//
			this.colShippingReturnLot.Caption = "Lot #";
			this.colShippingReturnLot.FieldName = "ShippingReturnLot";
			this.colShippingReturnLot.Name = "colShippingReturnLot";
			this.colShippingReturnLot.OptionsColumn.ReadOnly = true;
			this.colShippingReturnLot.Visible = true;
			this.colShippingReturnLot.VisibleIndex = 4;
			//
			//colShippingReturnExpirationDate
			//
			this.colShippingReturnExpirationDate.Caption = "Expiration Date";
			this.colShippingReturnExpirationDate.FieldName = "ShippingReturnExpirationDate";
			this.colShippingReturnExpirationDate.Name = "colShippingReturnExpirationDate";
			this.colShippingReturnExpirationDate.OptionsColumn.ReadOnly = true;
			this.colShippingReturnExpirationDate.Visible = true;
			this.colShippingReturnExpirationDate.VisibleIndex = 5;
			//
			//colShippingReturnQuantity
			//
			this.colShippingReturnQuantity.Caption = "Quantity";
			this.colShippingReturnQuantity.FieldName = "ShippingReturnQuantity";
			this.colShippingReturnQuantity.Name = "colShippingReturnQuantity";
			this.colShippingReturnQuantity.OptionsColumn.ReadOnly = true;
			this.colShippingReturnQuantity.Visible = true;
			this.colShippingReturnQuantity.VisibleIndex = 6;
			//
			//colShippingReturnExpirationDateFormat
			//
			this.colShippingReturnExpirationDateFormat.Caption = "GridColumn1";
			this.colShippingReturnExpirationDateFormat.FieldName = "ShippingReturnExpirationDateFormat";
			this.colShippingReturnExpirationDateFormat.Name = "colShippingReturnExpirationDateFormat";
			//
			//colShippingItemType
			//
			this.colShippingItemType.Caption = "Item Type";
			this.colShippingItemType.FieldName = "ShipDetItemType";
			this.colShippingItemType.Name = "colShippingItemType";
			this.colShippingItemType.Visible = true;
			this.colShippingItemType.VisibleIndex = 3;
			//
			//LocationXtraForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(824, 561);
			this.Controls.Add(this.SplitContainerControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "LocationXtraForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Location Manager";
			((System.ComponentModel.ISupportInitialize)this.BarManager1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.SplitContainerControl1).EndInit();
			this.SplitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.locationSearchGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.locationSearchXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.locationSearchGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.locationsXtraTabControl).EndInit();
			this.locationsXtraTabControl.ResumeLayout(false);
			this.generalXtraTabPage.ResumeLayout(false);
			this.generalXtraTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
			this.GroupControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.defaultWarehouseCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryAvailableCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.warehousingCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shippingCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.receivingCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.faxTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.phoneTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.zipCodeTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.stateTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.cityTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.addressTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.nameTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.codeTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.oidTextEdit.Properties).EndInit();
			this.inventoryXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.inventoryGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.locationInventoryXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryGridView).EndInit();
			this.inventoryByLotXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.inventoryByLotGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.locationInventoryByLotXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.inventoryByLotGridView).EndInit();
			this.transfersXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.SplitContainerControl2).EndInit();
			this.SplitContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.transfersToGroupControl).EndInit();
			this.transfersToGroupControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.transfersToGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.transfersToXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.transfersToGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.transfersFromGroupControl).EndInit();
			this.transfersFromGroupControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.transfersFromGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.transfersFromXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.transfersFromGridView).EndInit();
			this.receivingXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.receivingsGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.receivingsXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.receivingsGridView).EndInit();
			this.receivingReturnsXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.receivingReturnsGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.receivingReturnXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.receivingReturnsGridView).EndInit();
			this.productionXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.productionGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionGridView).EndInit();
			this.shippingsXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.shippingsGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shippingsXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shippingsGridView).EndInit();
			this.shippingReturnsXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.shippingReturnsGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shippingReturnsXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shippingReturnsGridView).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			addBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(addBarButtonItem_ItemClick);
			cancelBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(cancelBarButtonItem_ItemClick);
			deleteBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(deleteBarButtonItem_ItemClick);
			editBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(editBarButtonItem_ItemClick);
			locationSearchGridView.Click += new System.EventHandler(locationSearchGridView_Click);
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(LocationXtraForm_FormClosing);
			this.Load += new System.EventHandler(LocationXtraForm_Load);
			printGridBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(printGridBarButtonItem_ItemClick);
			productionGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(productionGridView_CustomColumnDisplayText);
			receivingsGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(receivingsGridView_CustomColumnDisplayText);
			receivingReturnsGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(receivingReturnsGridView_CustomColumnDisplayText);
			saveBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(saveBarButtonItem_ItemClick);
			shippingsGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(shippingsGridView_CustomColumnDisplayText);
			shippingReturnsGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(shippingReturnsGridView_CustomColumnDisplayText);
			transfersFromGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(transfersFromGridView_CustomColumnDisplayText);
			transfersToGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(transfersToGridView_CustomColumnDisplayText);
			PrintLpnSimpleButton.Click += new System.EventHandler(PrintLpnSimpleButton_Click);
		}
		internal DevExpress.XtraBars.BarManager BarManager1;
		internal DevExpress.XtraBars.Bar locationMenuBar;
		internal DevExpress.XtraBars.Bar Bar2;
		internal DevExpress.XtraBars.Bar Bar3;
		internal DevExpress.XtraBars.BarDockControl barDockControlTop;
		internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
		internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
		internal DevExpress.XtraBars.BarDockControl barDockControlRight;
		internal DevExpress.XtraBars.BarButtonItem addBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem editBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem deleteBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem cancelBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem saveBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem printGridBarButtonItem;
		internal DevExpress.XtraEditors.SplitContainerControl SplitContainerControl1;
		internal DevExpress.XtraGrid.GridControl locationSearchGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView locationSearchGridView;
		internal DevExpress.Xpo.XPView locationSearchXpView;
		internal DevExpress.XtraGrid.Columns.GridColumn colCode;
		internal DevExpress.XtraGrid.Columns.GridColumn colName;
		internal DevExpress.XtraGrid.Columns.GridColumn colLocationID;
		internal DevExpress.XtraTab.XtraTabControl locationsXtraTabControl;
		internal DevExpress.XtraTab.XtraTabPage generalXtraTabPage;
		internal DevExpress.XtraTab.XtraTabPage inventoryXtraTabPage;
		internal DevExpress.XtraTab.XtraTabPage receivingXtraTabPage;
		internal DevExpress.XtraTab.XtraTabPage receivingReturnsXtraTabPage;
		internal DevExpress.XtraTab.XtraTabPage productionXtraTabPage;
		internal DevExpress.XtraTab.XtraTabPage shippingsXtraTabPage;
		internal DevExpress.XtraTab.XtraTabPage shippingReturnsXtraTabPage;
		internal DevExpress.XtraTab.XtraTabPage transfersXtraTabPage;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraEditors.TextEdit codeTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.TextEdit oidTextEdit;
		internal DevExpress.XtraEditors.TextEdit addressTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		internal DevExpress.XtraEditors.TextEdit nameTextEdit;
		internal DevExpress.XtraEditors.TextEdit cityTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl5;
		internal DevExpress.XtraEditors.GroupControl GroupControl1;
		internal DevExpress.XtraEditors.CheckEdit defaultWarehouseCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit inventoryAvailableCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit warehousingCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit productionCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit shippingCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit receivingCheckEdit;
		internal DevExpress.XtraEditors.TextEdit faxTextEdit;
		internal DevExpress.XtraEditors.TextEdit phoneTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl6;
		internal DevExpress.XtraEditors.TextEdit zipCodeTextEdit;
		internal DevExpress.XtraEditors.TextEdit stateTextEdit;
		internal DevExpress.XtraGrid.GridControl inventoryGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView inventoryGridView;
		internal DevExpress.XtraGrid.GridControl transfersToGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView transfersToGridView;
		internal DevExpress.XtraGrid.GridControl receivingsGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView receivingsGridView;
		internal DevExpress.XtraGrid.GridControl receivingReturnsGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView receivingReturnsGridView;
		internal DevExpress.XtraGrid.GridControl productionGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView productionGridView;
		internal DevExpress.XtraGrid.GridControl shippingsGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView shippingsGridView;
		internal DevExpress.XtraGrid.GridControl shippingReturnsGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView shippingReturnsGridView;
		internal DevExpress.Xpo.XPView locationInventoryXpView;
		internal DevExpress.XtraGrid.Columns.GridColumn colItemCode;
		internal DevExpress.XtraGrid.Columns.GridColumn colItemDescription;
		internal DevExpress.XtraGrid.Columns.GridColumn colQuantity;
		internal DevExpress.XtraEditors.SplitContainerControl SplitContainerControl2;
		internal DevExpress.XtraEditors.GroupControl transfersToGroupControl;
		internal DevExpress.XtraEditors.GroupControl transfersFromGroupControl;
		internal DevExpress.XtraGrid.GridControl transfersFromGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView transfersFromGridView;
		internal DevExpress.Xpo.XPView transfersFromXpView;
		internal DevExpress.Xpo.XPView transfersToXpView;
		internal DevExpress.XtraGrid.Columns.GridColumn colTransferToDate;
		internal DevExpress.XtraGrid.Columns.GridColumn colFromLocation;
		internal DevExpress.XtraGrid.Columns.GridColumn colTransferToItemCode;
		internal DevExpress.XtraGrid.Columns.GridColumn colTransferToItemDescription;
		internal DevExpress.XtraGrid.Columns.GridColumn colTransferToNumber;
		internal DevExpress.XtraGrid.Columns.GridColumn colTransferToItemLot;
		internal DevExpress.XtraGrid.Columns.GridColumn colTransferToExpirationDate;
		internal DevExpress.XtraGrid.Columns.GridColumn colTransferToQuantity;
		internal DevExpress.XtraGrid.Columns.GridColumn colTransferDate;
		internal DevExpress.XtraGrid.Columns.GridColumn colToLocation;
		internal DevExpress.XtraGrid.Columns.GridColumn colTansferFromItemCode;
		internal DevExpress.XtraGrid.Columns.GridColumn colTransferFromItemDescription;
		internal DevExpress.XtraGrid.Columns.GridColumn colTransferNumber;
		internal DevExpress.XtraGrid.Columns.GridColumn colItemLot;
		internal DevExpress.XtraGrid.Columns.GridColumn colExpirationDate;
		internal DevExpress.XtraGrid.Columns.GridColumn colTransferQuantity;
		internal DevExpress.Xpo.XPView receivingsXpView;
		internal DevExpress.XtraGrid.Columns.GridColumn colReceivingDate;
		internal DevExpress.XtraGrid.Columns.GridColumn colReceivingItemCode;
		internal DevExpress.XtraGrid.Columns.GridColumn colReceivingItemDescription;
		internal DevExpress.XtraGrid.Columns.GridColumn colReceivingBOL;
		internal DevExpress.XtraGrid.Columns.GridColumn colReceivingLot;
		internal DevExpress.XtraGrid.Columns.GridColumn colReceivingItemExpirationDate;
		internal DevExpress.XtraGrid.Columns.GridColumn colReceivingQuantity;
		internal DevExpress.Xpo.XPView receivingReturnXpView;
		internal DevExpress.XtraGrid.Columns.GridColumn colReceivingReturnDate;
		internal DevExpress.XtraGrid.Columns.GridColumn colReceivingReturnItemCode;
		internal DevExpress.XtraGrid.Columns.GridColumn colReceivingReturnItemDescription;
		internal DevExpress.XtraGrid.Columns.GridColumn colReceivingReturnBOL;
		internal DevExpress.XtraGrid.Columns.GridColumn colReceivingReturnLot;
		internal DevExpress.XtraGrid.Columns.GridColumn colReceivingReturnItemExpirationDate;
		internal DevExpress.XtraGrid.Columns.GridColumn colReceivingReturnQuantity;
		internal DevExpress.Xpo.XPView productionXpView;
		internal DevExpress.XtraGrid.Columns.GridColumn colProductionDate;
		internal DevExpress.XtraGrid.Columns.GridColumn colProductionItemCode;
		internal DevExpress.XtraGrid.Columns.GridColumn colProductionItemDescription;
		internal DevExpress.XtraGrid.Columns.GridColumn colProductionPO;
		internal DevExpress.XtraGrid.Columns.GridColumn colProductionLot;
		internal DevExpress.XtraGrid.Columns.GridColumn colPrdouctionExpirationDate;
		internal DevExpress.XtraGrid.Columns.GridColumn colProductionQuantity;
		internal DevExpress.Xpo.XPView shippingsXpView;
		internal DevExpress.XtraGrid.Columns.GridColumn colShippingDate;
		internal DevExpress.XtraGrid.Columns.GridColumn colShippingItemCode;
		internal DevExpress.XtraGrid.Columns.GridColumn colShippingItemDescription;
		internal DevExpress.XtraGrid.Columns.GridColumn colShippingBOL;
		internal DevExpress.XtraGrid.Columns.GridColumn colShippingLot;
		internal DevExpress.XtraGrid.Columns.GridColumn colShippingExpirationDate;
		internal DevExpress.XtraGrid.Columns.GridColumn colShippingQuantity;
		internal DevExpress.Xpo.XPView shippingReturnsXpView;
		internal DevExpress.XtraGrid.Columns.GridColumn colShippingReturnDate;
		internal DevExpress.XtraGrid.Columns.GridColumn colShippingReturnItemCode;
		internal DevExpress.XtraGrid.Columns.GridColumn colShippingReturnItemDescription;
		internal DevExpress.XtraGrid.Columns.GridColumn colShippingReturnBOL;
		internal DevExpress.XtraGrid.Columns.GridColumn colShippingReturnLot;
		internal DevExpress.XtraGrid.Columns.GridColumn colShippingReturnExpirationDate;
		internal DevExpress.XtraGrid.Columns.GridColumn colShippingReturnQuantity;
		internal DevExpress.XtraGrid.Columns.GridColumn transferToExpirationDateFormatGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn colTransferFromExpirationDateFormat;
		internal DevExpress.XtraGrid.Columns.GridColumn colReceivingExpirationDateFormat;
		internal DevExpress.XtraGrid.Columns.GridColumn colReceivingReturnExpirationDateFormat;
		internal DevExpress.XtraGrid.Columns.GridColumn colProductionExpirationDateFormat;
		internal DevExpress.XtraGrid.Columns.GridColumn colShippingExpirationDateFormat;
		internal DevExpress.XtraGrid.Columns.GridColumn colShippingReturnExpirationDateFormat;
		internal DevExpress.XtraTab.XtraTabPage inventoryByLotXtraTabPage;
		internal DevExpress.XtraGrid.GridControl inventoryByLotGridControl;
		internal DevExpress.Xpo.XPView locationInventoryByLotXpView;
		internal DevExpress.XtraGrid.Views.Grid.GridView inventoryByLotGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn colItemCode1;
		internal DevExpress.XtraGrid.Columns.GridColumn colItemDescription1;
		internal DevExpress.XtraGrid.Columns.GridColumn colLot;
		internal DevExpress.XtraGrid.Columns.GridColumn colLPNNumber;
		internal DevExpress.XtraGrid.Columns.GridColumn colQuantity1;
		internal DevExpress.XtraGrid.Columns.GridColumn colExpirationDate1;
		internal DevExpress.XtraEditors.SimpleButton PrintLpnSimpleButton;
		internal DevExpress.XtraGrid.Columns.GridColumn colReceivingItemType;
		internal DevExpress.XtraGrid.Columns.GridColumn colShippingItemType;
	}

}