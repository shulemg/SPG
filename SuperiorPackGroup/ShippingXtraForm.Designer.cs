using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraReports.UI;

//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using DXDAL.SPGData;

namespace SuperiorPackGroup
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	public partial class ShippingXtraForm : DevExpress.XtraEditors.XtraForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShippingXtraForm));
			this.shippingXtraTabControl = new DevExpress.XtraTab.XtraTabControl();
			this.generalXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.locationLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.BarManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.shippingBar = new DevExpress.XtraBars.Bar();
			this.addBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.editBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.cancelBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.saveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.printBOLBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.printPackingListBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.refreshBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.Bar2 = new DevExpress.XtraBars.Bar();
			this.Bar3 = new DevExpress.XtraBars.Bar();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.locationXpView = new DevExpress.Xpo.XPView(this.components);
			this.LabelControl28 = new DevExpress.XtraEditors.LabelControl();
			this.freightCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.LabelControl12 = new DevExpress.XtraEditors.LabelControl();
			this.commentsMemoEdit = new DevExpress.XtraEditors.MemoEdit();
			this.customerShipperCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.totalGrossWeightTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.shiftLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.deliveryNoteNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.palletsTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl16 = new DevExpress.XtraEditors.LabelControl();
			this.noteMemoEdit = new DevExpress.XtraEditors.MemoEdit();
			this.LabelControl14 = new DevExpress.XtraEditors.LabelControl();
			this.destinationMemoEdit = new DevExpress.XtraEditors.MemoEdit();
			this.destinationLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.LabelControl13 = new DevExpress.XtraEditors.LabelControl();
			this.carrierLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.LabelControl11 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.poTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.customerLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.customersXPView = new DevExpress.Xpo.XPView(this.components);
			this.LabelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.skitsTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.sealTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.trailerTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.bolTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.shipDateEdit = new DevExpress.XtraEditors.DateEdit();
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.shipmentInfoXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.correctPalletsComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
			this.LabelControl24 = new DevExpress.XtraEditors.LabelControl();
			this.insectActivityComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
			this.LabelControl25 = new DevExpress.XtraEditors.LabelControl();
			this.foreignSubstanceComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
			this.LabelControl26 = new DevExpress.XtraEditors.LabelControl();
			this.wheelsChockedComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
			this.LabelControl27 = new DevExpress.XtraEditors.LabelControl();
			this.loadConditionLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.shipmentConditionXpView = new DevExpress.Xpo.XPView(this.components);
			this.physicalConditionLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.LabelControl23 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl22 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl21 = new DevExpress.XtraEditors.LabelControl();
			this.temparatureSpinEdit = new DevExpress.XtraEditors.SpinEdit();
			this.LabelControl20 = new DevExpress.XtraEditors.LabelControl();
			this.finishTimeTimeEdit = new DevExpress.XtraEditors.TimeEdit();
			this.LabelControl19 = new DevExpress.XtraEditors.LabelControl();
			this.startTimeTimeEdit = new DevExpress.XtraEditors.TimeEdit();
			this.checkedByLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.employeeXpView = new DevExpress.Xpo.XPView(this.components);
			this.LabelControl18 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl17 = new DevExpress.XtraEditors.LabelControl();
			this.loadedByLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.detailsXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.lpnNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl15 = new DevExpress.XtraEditors.LabelControl();
			this.shippingGridControl = new DevExpress.XtraGrid.GridControl();
			this.shippingGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.idGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shippingIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.itemGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.itemRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.shippingItemXPView = new DevExpress.Xpo.XPView(this.components);
			this.descriptionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.lotGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.expirationDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.RepositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.fullLPNNumberGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.quantityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.palletsGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.grossWeightGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.noteGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.noteRepositoryItemMemoExEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
			this.delGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.delRepositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			this.RepositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			this.returnsXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.returnsGridControl = new DevExpress.XtraGrid.GridControl();
			this.returnsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.returnIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ShippingMainIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.returnItemGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.returnItemRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.returnItemXPView = new DevExpress.Xpo.XPView(this.components);
			this.returnItemDescGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.returnLotGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.returnExpirationDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.RepositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			this.returnUnitsGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.returnQuantityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.returnPalletsGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.returnReasonGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.returnReasonRepositoryItemMemoExEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
			this.returnGrossWeightGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.deleteReturnGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.deleteReturnRepositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			this.SplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			this.shippingSearchGridControl = new DevExpress.XtraGrid.GridControl();
			this.shippingSearchXPView = new DevExpress.Xpo.XPView(this.components);
			this.shippingSearchGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.shippingSearchIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shippingBOLGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shippingCustomerGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shippingDateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shippingDateRepositoryItemDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
			((System.ComponentModel.ISupportInitialize)this.shippingXtraTabControl).BeginInit();
			this.shippingXtraTabControl.SuspendLayout();
			this.generalXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.locationLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.BarManager1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.locationXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.freightCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.commentsMemoEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customerShipperCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.totalGrossWeightTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shiftLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.deliveryNoteNumberTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.palletsTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.noteMemoEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.destinationMemoEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.destinationLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.carrierLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.poTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customerLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customersXPView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.skitsTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.sealTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.trailerTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.bolTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shipDateEdit.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shipDateEdit.Properties).BeginInit();
			this.shipmentInfoXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.correctPalletsComboBoxEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.insectActivityComboBoxEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.foreignSubstanceComboBoxEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.wheelsChockedComboBoxEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.loadConditionLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shipmentConditionXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.physicalConditionLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.temparatureSpinEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.finishTimeTimeEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.startTimeTimeEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.checkedByLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.employeeXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.loadedByLookUpEdit.Properties).BeginInit();
			this.detailsXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.lpnNumberTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shippingGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shippingGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemRepositoryItemLookUpEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shippingItemXPView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemDateEdit1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemDateEdit1.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.noteRepositoryItemMemoExEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.delRepositoryItemButtonEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemButtonEdit1).BeginInit();
			this.returnsXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.returnsGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.returnsGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.returnItemRepositoryItemLookUpEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.returnItemXPView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemDateEdit2).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemDateEdit2.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.returnReasonRepositoryItemMemoExEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.deleteReturnRepositoryItemButtonEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.SplitContainerControl1).BeginInit();
			this.SplitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.shippingSearchGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shippingSearchXPView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shippingSearchGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shippingDateRepositoryItemDateEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shippingDateRepositoryItemDateEdit.CalendarTimeProperties).BeginInit();
			this.SuspendLayout();
			//
			//shippingXtraTabControl
			//
			this.shippingXtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.shippingXtraTabControl.Location = new System.Drawing.Point(0, 0);
			this.shippingXtraTabControl.Name = "shippingXtraTabControl";
			this.shippingXtraTabControl.SelectedTabPage = this.generalXtraTabPage;
			this.shippingXtraTabControl.Size = new System.Drawing.Size(613, 433);
			this.shippingXtraTabControl.TabIndex = 4;
			this.shippingXtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {this.generalXtraTabPage, this.shipmentInfoXtraTabPage, this.detailsXtraTabPage, this.returnsXtraTabPage});
			//
			//generalXtraTabPage
			//
			this.generalXtraTabPage.Controls.Add(this.locationLookUpEdit);
			this.generalXtraTabPage.Controls.Add(this.LabelControl28);
			this.generalXtraTabPage.Controls.Add(this.freightCheckEdit);
			this.generalXtraTabPage.Controls.Add(this.LabelControl12);
			this.generalXtraTabPage.Controls.Add(this.commentsMemoEdit);
			this.generalXtraTabPage.Controls.Add(this.customerShipperCheckEdit);
			this.generalXtraTabPage.Controls.Add(this.totalGrossWeightTextEdit);
			this.generalXtraTabPage.Controls.Add(this.LabelControl9);
			this.generalXtraTabPage.Controls.Add(this.shiftLookUpEdit);
			this.generalXtraTabPage.Controls.Add(this.LabelControl3);
			this.generalXtraTabPage.Controls.Add(this.deliveryNoteNumberTextEdit);
			this.generalXtraTabPage.Controls.Add(this.LabelControl1);
			this.generalXtraTabPage.Controls.Add(this.palletsTextEdit);
			this.generalXtraTabPage.Controls.Add(this.LabelControl16);
			this.generalXtraTabPage.Controls.Add(this.noteMemoEdit);
			this.generalXtraTabPage.Controls.Add(this.LabelControl14);
			this.generalXtraTabPage.Controls.Add(this.destinationMemoEdit);
			this.generalXtraTabPage.Controls.Add(this.destinationLookUpEdit);
			this.generalXtraTabPage.Controls.Add(this.LabelControl13);
			this.generalXtraTabPage.Controls.Add(this.carrierLookUpEdit);
			this.generalXtraTabPage.Controls.Add(this.LabelControl11);
			this.generalXtraTabPage.Controls.Add(this.LabelControl10);
			this.generalXtraTabPage.Controls.Add(this.poTextEdit);
			this.generalXtraTabPage.Controls.Add(this.customerLookUpEdit);
			this.generalXtraTabPage.Controls.Add(this.LabelControl8);
			this.generalXtraTabPage.Controls.Add(this.LabelControl7);
			this.generalXtraTabPage.Controls.Add(this.skitsTextEdit);
			this.generalXtraTabPage.Controls.Add(this.sealTextEdit);
			this.generalXtraTabPage.Controls.Add(this.LabelControl6);
			this.generalXtraTabPage.Controls.Add(this.LabelControl5);
			this.generalXtraTabPage.Controls.Add(this.trailerTextEdit);
			this.generalXtraTabPage.Controls.Add(this.bolTextEdit);
			this.generalXtraTabPage.Controls.Add(this.LabelControl4);
			this.generalXtraTabPage.Controls.Add(this.shipDateEdit);
			this.generalXtraTabPage.Controls.Add(this.LabelControl2);
			this.generalXtraTabPage.Name = "generalXtraTabPage";
			this.generalXtraTabPage.Size = new System.Drawing.Size(607, 405);
			this.generalXtraTabPage.Text = "General Info";
			//
			//locationLookUpEdit
			//
			this.locationLookUpEdit.Location = new System.Drawing.Point(387, 189);
			this.locationLookUpEdit.MenuManager = this.BarManager1;
			this.locationLookUpEdit.Name = "locationLookUpEdit";
			this.locationLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.locationLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationID", "Location ID", 77, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationCode", "Location Code", 78, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationName", "Location Name", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)
			});
			this.locationLookUpEdit.Properties.DataSource = this.locationXpView;
			this.locationLookUpEdit.Properties.DisplayMember = "LocationCode";
			this.locationLookUpEdit.Properties.NullText = "[Select A Location]";
			this.locationLookUpEdit.Properties.ValueMember = "LocationID";
			this.locationLookUpEdit.Size = new System.Drawing.Size(190, 20);
			this.locationLookUpEdit.TabIndex = 44;
			//
			//BarManager1
			//
			this.BarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.shippingBar, this.Bar2, this.Bar3});
			this.BarManager1.DockControls.Add(this.barDockControlTop);
			this.BarManager1.DockControls.Add(this.barDockControlBottom);
			this.BarManager1.DockControls.Add(this.barDockControlLeft);
			this.BarManager1.DockControls.Add(this.barDockControlRight);
			this.BarManager1.Form = this;
			this.BarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.addBarButtonItem, this.editBarButtonItem, this.cancelBarButtonItem, this.saveBarButtonItem, this.printBOLBarButtonItem, this.printPackingListBarButtonItem, this.refreshBarButtonItem});
			this.BarManager1.MainMenu = this.Bar2;
			this.BarManager1.MaxItemId = 7;
			this.BarManager1.StatusBar = this.Bar3;
			//
			//shippingBar
			//
			this.shippingBar.BarName = "Tools";
			this.shippingBar.DockCol = 0;
			this.shippingBar.DockRow = 1;
			this.shippingBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.shippingBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.addBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.editBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.cancelBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.saveBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.printBOLBarButtonItem, true),
				new DevExpress.XtraBars.LinkPersistInfo(this.printPackingListBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.refreshBarButtonItem, true)
			});
			this.shippingBar.OptionsBar.UseWholeRow = true;
			this.shippingBar.Text = "Tools";
			//
			//addBarButtonItem
			//
			this.addBarButtonItem.Caption = "&Add Shipping";
			this.addBarButtonItem.Id = 0;
			this.addBarButtonItem.Name = "addBarButtonItem";
			//
			//editBarButtonItem
			//
			this.editBarButtonItem.Caption = "&Edit Shipping";
			this.editBarButtonItem.Id = 1;
			this.editBarButtonItem.Name = "editBarButtonItem";
			//
			//cancelBarButtonItem
			//
			this.cancelBarButtonItem.Caption = "&Cancel Changes";
			this.cancelBarButtonItem.Id = 2;
			this.cancelBarButtonItem.Name = "cancelBarButtonItem";
			//
			//saveBarButtonItem
			//
			this.saveBarButtonItem.Caption = "&Save Changes";
			this.saveBarButtonItem.Id = 3;
			this.saveBarButtonItem.Name = "saveBarButtonItem";
			//
			//printBOLBarButtonItem
			//
			this.printBOLBarButtonItem.Caption = "Print &BOL";
			this.printBOLBarButtonItem.Id = 4;
			this.printBOLBarButtonItem.Name = "printBOLBarButtonItem";
			//
			//printPackingListBarButtonItem
			//
			this.printPackingListBarButtonItem.Caption = "Print &Packing LIst";
			this.printPackingListBarButtonItem.Id = 5;
			this.printPackingListBarButtonItem.Name = "printPackingListBarButtonItem";
			//
			//refreshBarButtonItem
			//
			this.refreshBarButtonItem.Caption = "Re&fresh";
			this.refreshBarButtonItem.Id = 6;
			this.refreshBarButtonItem.Name = "refreshBarButtonItem";
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
			this.Bar2.Visible = false;
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
			this.barDockControlTop.Size = new System.Drawing.Size(868, 49);
			//
			//barDockControlBottom
			//
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 482);
			this.barDockControlBottom.Manager = this.BarManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(868, 23);
			//
			//barDockControlLeft
			//
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 49);
			this.barDockControlLeft.Manager = this.BarManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 433);
			//
			//barDockControlRight
			//
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(868, 49);
			this.barDockControlRight.Manager = this.BarManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 433);
			//
			//locationXpView
			//
			this.locationXpView.CriteriaString = "[CanShip] = True";
			this.locationXpView.ObjectType = typeof(DXDAL.SPGData.Locations);
			this.locationXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("LocationID", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true),
				new DevExpress.Xpo.ViewProperty("LocationCode", DevExpress.Xpo.SortDirection.None, "[LocationCode]", false, true),
				new DevExpress.Xpo.ViewProperty("LocationName", DevExpress.Xpo.SortDirection.None, "[LocationName]", false, true)
			});
			//
			//LabelControl28
			//
			this.LabelControl28.Location = new System.Drawing.Point(286, 193);
			this.LabelControl28.Name = "LabelControl28";
			this.LabelControl28.Size = new System.Drawing.Size(71, 13);
			this.LabelControl28.TabIndex = 43;
			this.LabelControl28.Text = "Shipping From:";
			//
			//freightCheckEdit
			//
			this.freightCheckEdit.Location = new System.Drawing.Point(387, 319);
			this.freightCheckEdit.Name = "freightCheckEdit";
			this.freightCheckEdit.Properties.Caption = "Charge Freight";
			this.freightCheckEdit.Size = new System.Drawing.Size(190, 19);
			this.freightCheckEdit.TabIndex = 42;
			//
			//LabelControl12
			//
			this.LabelControl12.Location = new System.Drawing.Point(14, 245);
			this.LabelControl12.Name = "LabelControl12";
			this.LabelControl12.Size = new System.Drawing.Size(50, 13);
			this.LabelControl12.TabIndex = 41;
			this.LabelControl12.Text = "Comments";
			//
			//commentsMemoEdit
			//
			this.commentsMemoEdit.Location = new System.Drawing.Point(105, 242);
			this.commentsMemoEdit.Name = "commentsMemoEdit";
			this.commentsMemoEdit.Size = new System.Drawing.Size(175, 71);
			this.commentsMemoEdit.TabIndex = 40;
			//
			//customerShipperCheckEdit
			//
			this.customerShipperCheckEdit.Location = new System.Drawing.Point(385, 60);
			this.customerShipperCheckEdit.Name = "customerShipperCheckEdit";
			this.customerShipperCheckEdit.Properties.Caption = "Customer is Shipper";
			this.customerShipperCheckEdit.Size = new System.Drawing.Size(192, 19);
			this.customerShipperCheckEdit.TabIndex = 39;
			//
			//totalGrossWeightTextEdit
			//
			this.totalGrossWeightTextEdit.Location = new System.Drawing.Point(387, 344);
			this.totalGrossWeightTextEdit.Name = "totalGrossWeightTextEdit";
			this.totalGrossWeightTextEdit.Properties.DisplayFormat.FormatString = "f2";
			this.totalGrossWeightTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.totalGrossWeightTextEdit.Properties.ReadOnly = true;
			this.totalGrossWeightTextEdit.Size = new System.Drawing.Size(190, 20);
			this.totalGrossWeightTextEdit.TabIndex = 38;
			//
			//LabelControl9
			//
			this.LabelControl9.Location = new System.Drawing.Point(286, 347);
			this.LabelControl9.Name = "LabelControl9";
			this.LabelControl9.Size = new System.Drawing.Size(95, 13);
			this.LabelControl9.TabIndex = 37;
			this.LabelControl9.Text = "Total Gross Weight:";
			//
			//shiftLookUpEdit
			//
			this.shiftLookUpEdit.Location = new System.Drawing.Point(105, 86);
			this.shiftLookUpEdit.Name = "shiftLookUpEdit";
			this.shiftLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.shiftLookUpEdit.Properties.NullText = "[Select A Shift]";
			this.shiftLookUpEdit.Size = new System.Drawing.Size(175, 20);
			this.shiftLookUpEdit.TabIndex = 36;
			//
			//LabelControl3
			//
			this.LabelControl3.Location = new System.Drawing.Point(14, 88);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(26, 13);
			this.LabelControl3.TabIndex = 35;
			this.LabelControl3.Text = "Shift:";
			//
			//deliveryNoteNumberTextEdit
			//
			this.deliveryNoteNumberTextEdit.Location = new System.Drawing.Point(387, 215);
			this.deliveryNoteNumberTextEdit.Name = "deliveryNoteNumberTextEdit";
			this.deliveryNoteNumberTextEdit.Size = new System.Drawing.Size(190, 20);
			this.deliveryNoteNumberTextEdit.TabIndex = 34;
			//
			//LabelControl1
			//
			this.LabelControl1.Location = new System.Drawing.Point(286, 218);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(80, 13);
			this.LabelControl1.TabIndex = 33;
			this.LabelControl1.Text = "Delivery Note #:";
			//
			//palletsTextEdit
			//
			this.palletsTextEdit.Location = new System.Drawing.Point(105, 345);
			this.palletsTextEdit.Name = "palletsTextEdit";
			this.palletsTextEdit.Properties.ReadOnly = true;
			this.palletsTextEdit.Size = new System.Drawing.Size(175, 20);
			this.palletsTextEdit.TabIndex = 32;
			this.palletsTextEdit.TabStop = false;
			//
			//LabelControl16
			//
			this.LabelControl16.Location = new System.Drawing.Point(15, 350);
			this.LabelControl16.Name = "LabelControl16";
			this.LabelControl16.Size = new System.Drawing.Size(62, 13);
			this.LabelControl16.TabIndex = 31;
			this.LabelControl16.Text = "Total Pallets:";
			//
			//noteMemoEdit
			//
			this.noteMemoEdit.EditValue = "";
			this.noteMemoEdit.Location = new System.Drawing.Point(387, 244);
			this.noteMemoEdit.Name = "noteMemoEdit";
			this.noteMemoEdit.Size = new System.Drawing.Size(190, 69);
			this.noteMemoEdit.TabIndex = 30;
			//
			//LabelControl14
			//
			this.LabelControl14.Location = new System.Drawing.Point(286, 247);
			this.LabelControl14.Name = "LabelControl14";
			this.LabelControl14.Size = new System.Drawing.Size(97, 13);
			this.LabelControl14.TabIndex = 29;
			this.LabelControl14.Text = "Special Instructions:";
			//
			//destinationMemoEdit
			//
			this.destinationMemoEdit.Location = new System.Drawing.Point(387, 85);
			this.destinationMemoEdit.Name = "destinationMemoEdit";
			this.destinationMemoEdit.Properties.ReadOnly = true;
			this.destinationMemoEdit.Size = new System.Drawing.Size(190, 98);
			this.destinationMemoEdit.TabIndex = 26;
			this.destinationMemoEdit.TabStop = false;
			//
			//destinationLookUpEdit
			//
			this.destinationLookUpEdit.Location = new System.Drawing.Point(387, 34);
			this.destinationLookUpEdit.Name = "destinationLookUpEdit";
			this.destinationLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.destinationLookUpEdit.Properties.NullText = "[Select A Destination]";
			this.destinationLookUpEdit.Size = new System.Drawing.Size(190, 20);
			this.destinationLookUpEdit.TabIndex = 25;
			//
			//LabelControl13
			//
			this.LabelControl13.Location = new System.Drawing.Point(286, 37);
			this.LabelControl13.Name = "LabelControl13";
			this.LabelControl13.Size = new System.Drawing.Size(58, 13);
			this.LabelControl13.TabIndex = 24;
			this.LabelControl13.Text = "Destination:";
			//
			//carrierLookUpEdit
			//
			this.carrierLookUpEdit.Location = new System.Drawing.Point(105, 164);
			this.carrierLookUpEdit.Name = "carrierLookUpEdit";
			this.carrierLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.carrierLookUpEdit.Properties.NullText = "[Select A Carrier]";
			this.carrierLookUpEdit.Size = new System.Drawing.Size(175, 20);
			this.carrierLookUpEdit.TabIndex = 15;
			//
			//LabelControl11
			//
			this.LabelControl11.Location = new System.Drawing.Point(14, 166);
			this.LabelControl11.Name = "LabelControl11";
			this.LabelControl11.Size = new System.Drawing.Size(37, 13);
			this.LabelControl11.TabIndex = 14;
			this.LabelControl11.Text = "Carrier:";
			//
			//LabelControl10
			//
			this.LabelControl10.Location = new System.Drawing.Point(14, 114);
			this.LabelControl10.Name = "LabelControl10";
			this.LabelControl10.Size = new System.Drawing.Size(58, 13);
			this.LabelControl10.TabIndex = 8;
			this.LabelControl10.Text = "PO Number:";
			//
			//poTextEdit
			//
			this.poTextEdit.Location = new System.Drawing.Point(105, 112);
			this.poTextEdit.Name = "poTextEdit";
			this.poTextEdit.Size = new System.Drawing.Size(175, 20);
			this.poTextEdit.TabIndex = 9;
			//
			//customerLookUpEdit
			//
			this.customerLookUpEdit.Location = new System.Drawing.Point(105, 34);
			this.customerLookUpEdit.Name = "customerLookUpEdit";
			this.customerLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.customerLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerID", "Customer ID", 83, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Customer Name", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default)
			});
			this.customerLookUpEdit.Properties.DataSource = this.customersXPView;
			this.customerLookUpEdit.Properties.DisplayMember = "CustomerName";
			this.customerLookUpEdit.Properties.NullText = "[Select A Customer]";
			this.customerLookUpEdit.Properties.ValueMember = "CustomerID";
			this.customerLookUpEdit.Size = new System.Drawing.Size(175, 20);
			this.customerLookUpEdit.TabIndex = 5;
			//
			//customersXPView
			//
			this.customersXPView.CriteriaString = "[Inactive] = False";
			this.customersXPView.ObjectType = typeof(DXDAL.SPGData.Customers);
			this.customersXPView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[CustomerID]", false, true),
				new DevExpress.Xpo.ViewProperty("CustomerName", DevExpress.Xpo.SortDirection.Ascending, "[CustomerName]", false, true),
				new DevExpress.Xpo.ViewProperty("Inactive", DevExpress.Xpo.SortDirection.None, "[Inactive]", false, true)
			});
			//
			//LabelControl8
			//
			this.LabelControl8.Location = new System.Drawing.Point(14, 36);
			this.LabelControl8.Name = "LabelControl8";
			this.LabelControl8.Size = new System.Drawing.Size(50, 13);
			this.LabelControl8.TabIndex = 4;
			this.LabelControl8.Text = "Customer:";
			//
			//LabelControl7
			//
			this.LabelControl7.Location = new System.Drawing.Point(14, 322);
			this.LabelControl7.Name = "LabelControl7";
			this.LabelControl7.Size = new System.Drawing.Size(85, 13);
			this.LabelControl7.TabIndex = 22;
			this.LabelControl7.Text = "Additional Pallets:";
			//
			//skitsTextEdit
			//
			this.skitsTextEdit.Location = new System.Drawing.Point(105, 319);
			this.skitsTextEdit.Name = "skitsTextEdit";
			this.skitsTextEdit.Size = new System.Drawing.Size(175, 20);
			this.skitsTextEdit.TabIndex = 23;
			//
			//sealTextEdit
			//
			this.sealTextEdit.Location = new System.Drawing.Point(105, 216);
			this.sealTextEdit.Name = "sealTextEdit";
			this.sealTextEdit.Size = new System.Drawing.Size(175, 20);
			this.sealTextEdit.TabIndex = 21;
			//
			//LabelControl6
			//
			this.LabelControl6.Location = new System.Drawing.Point(14, 218);
			this.LabelControl6.Name = "LabelControl6";
			this.LabelControl6.Size = new System.Drawing.Size(64, 13);
			this.LabelControl6.TabIndex = 20;
			this.LabelControl6.Text = "Seal Number:";
			//
			//LabelControl5
			//
			this.LabelControl5.Location = new System.Drawing.Point(14, 192);
			this.LabelControl5.Name = "LabelControl5";
			this.LabelControl5.Size = new System.Drawing.Size(74, 13);
			this.LabelControl5.TabIndex = 16;
			this.LabelControl5.Text = "Trailer Number:";
			//
			//trailerTextEdit
			//
			this.trailerTextEdit.Location = new System.Drawing.Point(105, 190);
			this.trailerTextEdit.Name = "trailerTextEdit";
			this.trailerTextEdit.Size = new System.Drawing.Size(175, 20);
			this.trailerTextEdit.TabIndex = 17;
			//
			//bolTextEdit
			//
			this.bolTextEdit.Location = new System.Drawing.Point(105, 138);
			this.bolTextEdit.Name = "bolTextEdit";
			this.bolTextEdit.Properties.NullText = "[Generated when saved]";
			this.bolTextEdit.Size = new System.Drawing.Size(175, 20);
			this.bolTextEdit.TabIndex = 11;
			//
			//LabelControl4
			//
			this.LabelControl4.Location = new System.Drawing.Point(14, 140);
			this.LabelControl4.Name = "LabelControl4";
			this.LabelControl4.Size = new System.Drawing.Size(63, 13);
			this.LabelControl4.TabIndex = 10;
			this.LabelControl4.Text = "BOL Number:";
			//
			//shipDateEdit
			//
			this.shipDateEdit.EditValue = null;
			this.shipDateEdit.Location = new System.Drawing.Point(105, 60);
			this.shipDateEdit.Name = "shipDateEdit";
			this.shipDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.shipDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton()});
			this.shipDateEdit.Properties.Mask.EditMask = "D";
			this.shipDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
			this.shipDateEdit.Properties.NullText = "[Select A Date]";
			this.shipDateEdit.Size = new System.Drawing.Size(175, 20);
			this.shipDateEdit.TabIndex = 3;
			//
			//LabelControl2
			//
			this.LabelControl2.Location = new System.Drawing.Point(14, 62);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(27, 13);
			this.LabelControl2.TabIndex = 2;
			this.LabelControl2.Text = "Date:";
			//
			//shipmentInfoXtraTabPage
			//
			this.shipmentInfoXtraTabPage.Controls.Add(this.correctPalletsComboBoxEdit);
			this.shipmentInfoXtraTabPage.Controls.Add(this.LabelControl24);
			this.shipmentInfoXtraTabPage.Controls.Add(this.insectActivityComboBoxEdit);
			this.shipmentInfoXtraTabPage.Controls.Add(this.LabelControl25);
			this.shipmentInfoXtraTabPage.Controls.Add(this.foreignSubstanceComboBoxEdit);
			this.shipmentInfoXtraTabPage.Controls.Add(this.LabelControl26);
			this.shipmentInfoXtraTabPage.Controls.Add(this.wheelsChockedComboBoxEdit);
			this.shipmentInfoXtraTabPage.Controls.Add(this.LabelControl27);
			this.shipmentInfoXtraTabPage.Controls.Add(this.loadConditionLookUpEdit);
			this.shipmentInfoXtraTabPage.Controls.Add(this.physicalConditionLookUpEdit);
			this.shipmentInfoXtraTabPage.Controls.Add(this.LabelControl23);
			this.shipmentInfoXtraTabPage.Controls.Add(this.LabelControl22);
			this.shipmentInfoXtraTabPage.Controls.Add(this.LabelControl21);
			this.shipmentInfoXtraTabPage.Controls.Add(this.temparatureSpinEdit);
			this.shipmentInfoXtraTabPage.Controls.Add(this.LabelControl20);
			this.shipmentInfoXtraTabPage.Controls.Add(this.finishTimeTimeEdit);
			this.shipmentInfoXtraTabPage.Controls.Add(this.LabelControl19);
			this.shipmentInfoXtraTabPage.Controls.Add(this.startTimeTimeEdit);
			this.shipmentInfoXtraTabPage.Controls.Add(this.checkedByLookUpEdit);
			this.shipmentInfoXtraTabPage.Controls.Add(this.LabelControl18);
			this.shipmentInfoXtraTabPage.Controls.Add(this.LabelControl17);
			this.shipmentInfoXtraTabPage.Controls.Add(this.loadedByLookUpEdit);
			this.shipmentInfoXtraTabPage.Name = "shipmentInfoXtraTabPage";
			this.shipmentInfoXtraTabPage.Size = new System.Drawing.Size(607, 405);
			this.shipmentInfoXtraTabPage.Text = "Shipment Info";
			//
			//correctPalletsComboBoxEdit
			//
			this.correctPalletsComboBoxEdit.Location = new System.Drawing.Point(126, 275);
			this.correctPalletsComboBoxEdit.MenuManager = this.BarManager1;
			this.correctPalletsComboBoxEdit.Name = "correctPalletsComboBoxEdit";
			this.correctPalletsComboBoxEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.correctPalletsComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.correctPalletsComboBoxEdit.Properties.DropDownRows = 3;
			this.correctPalletsComboBoxEdit.Properties.Items.AddRange(new object[] {"Yes", "No"});
			this.correctPalletsComboBoxEdit.Size = new System.Drawing.Size(48, 20);
			this.correctPalletsComboBoxEdit.TabIndex = 57;
			//
			//LabelControl24
			//
			this.LabelControl24.Location = new System.Drawing.Point(46, 277);
			this.LabelControl24.Name = "LabelControl24";
			this.LabelControl24.Size = new System.Drawing.Size(74, 13);
			this.LabelControl24.TabIndex = 56;
			this.LabelControl24.Text = "Correct Pallets:";
			//
			//insectActivityComboBoxEdit
			//
			this.insectActivityComboBoxEdit.Location = new System.Drawing.Point(126, 249);
			this.insectActivityComboBoxEdit.MenuManager = this.BarManager1;
			this.insectActivityComboBoxEdit.Name = "insectActivityComboBoxEdit";
			this.insectActivityComboBoxEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.insectActivityComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.insectActivityComboBoxEdit.Properties.DropDownRows = 3;
			this.insectActivityComboBoxEdit.Properties.Items.AddRange(new object[] {"Yes", "No"});
			this.insectActivityComboBoxEdit.Size = new System.Drawing.Size(48, 20);
			this.insectActivityComboBoxEdit.TabIndex = 55;
			//
			//LabelControl25
			//
			this.LabelControl25.Location = new System.Drawing.Point(8, 252);
			this.LabelControl25.Name = "LabelControl25";
			this.LabelControl25.Size = new System.Drawing.Size(112, 13);
			this.LabelControl25.TabIndex = 54;
			this.LabelControl25.Text = "Insect/Rodent Activity:";
			//
			//foreignSubstanceComboBoxEdit
			//
			this.foreignSubstanceComboBoxEdit.Location = new System.Drawing.Point(126, 223);
			this.foreignSubstanceComboBoxEdit.MenuManager = this.BarManager1;
			this.foreignSubstanceComboBoxEdit.Name = "foreignSubstanceComboBoxEdit";
			this.foreignSubstanceComboBoxEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.foreignSubstanceComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.foreignSubstanceComboBoxEdit.Properties.DropDownRows = 3;
			this.foreignSubstanceComboBoxEdit.Properties.Items.AddRange(new object[] {"Yes", "No"});
			this.foreignSubstanceComboBoxEdit.Size = new System.Drawing.Size(48, 20);
			this.foreignSubstanceComboBoxEdit.TabIndex = 53;
			//
			//LabelControl26
			//
			this.LabelControl26.Location = new System.Drawing.Point(27, 226);
			this.LabelControl26.Name = "LabelControl26";
			this.LabelControl26.Size = new System.Drawing.Size(93, 13);
			this.LabelControl26.TabIndex = 52;
			this.LabelControl26.Text = "Foreign Substance:";
			//
			//wheelsChockedComboBoxEdit
			//
			this.wheelsChockedComboBoxEdit.Location = new System.Drawing.Point(126, 197);
			this.wheelsChockedComboBoxEdit.MenuManager = this.BarManager1;
			this.wheelsChockedComboBoxEdit.Name = "wheelsChockedComboBoxEdit";
			this.wheelsChockedComboBoxEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.wheelsChockedComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.wheelsChockedComboBoxEdit.Properties.DropDownRows = 3;
			this.wheelsChockedComboBoxEdit.Properties.Items.AddRange(new object[] {"Yes", "No"});
			this.wheelsChockedComboBoxEdit.Size = new System.Drawing.Size(48, 20);
			this.wheelsChockedComboBoxEdit.TabIndex = 51;
			//
			//LabelControl27
			//
			this.LabelControl27.Location = new System.Drawing.Point(37, 200);
			this.LabelControl27.Name = "LabelControl27";
			this.LabelControl27.Size = new System.Drawing.Size(83, 13);
			this.LabelControl27.TabIndex = 50;
			this.LabelControl27.Text = "Wheels Chocked:";
			//
			//loadConditionLookUpEdit
			//
			this.loadConditionLookUpEdit.Location = new System.Drawing.Point(399, 118);
			this.loadConditionLookUpEdit.MenuManager = this.BarManager1;
			this.loadConditionLookUpEdit.Name = "loadConditionLookUpEdit";
			this.loadConditionLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.loadConditionLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.loadConditionLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("recordID", "record ID", 68, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Condition", "Condition", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)
			});
			this.loadConditionLookUpEdit.Properties.DataSource = this.shipmentConditionXpView;
			this.loadConditionLookUpEdit.Properties.DisplayMember = "Condition";
			this.loadConditionLookUpEdit.Properties.NullText = "[Select Condition]";
			this.loadConditionLookUpEdit.Properties.ValueMember = "recordID";
			this.loadConditionLookUpEdit.Size = new System.Drawing.Size(179, 20);
			this.loadConditionLookUpEdit.TabIndex = 7;
			//
			//shipmentConditionXpView
			//
			this.shipmentConditionXpView.ObjectType = typeof(DXDAL.SPGData.ShipmentConditions);
			this.shipmentConditionXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("recordID", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true),
				new DevExpress.Xpo.ViewProperty("Condition", DevExpress.Xpo.SortDirection.None, "[ShipmentCondition]", false, true)
			});
			//
			//physicalConditionLookUpEdit
			//
			this.physicalConditionLookUpEdit.Location = new System.Drawing.Point(127, 118);
			this.physicalConditionLookUpEdit.MenuManager = this.BarManager1;
			this.physicalConditionLookUpEdit.Name = "physicalConditionLookUpEdit";
			this.physicalConditionLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.physicalConditionLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.physicalConditionLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("recordID", "record ID", 68, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Condition", "Condition", 55, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)
			});
			this.physicalConditionLookUpEdit.Properties.DataSource = this.shipmentConditionXpView;
			this.physicalConditionLookUpEdit.Properties.DisplayMember = "Condition";
			this.physicalConditionLookUpEdit.Properties.NullText = "[Select Condition]";
			this.physicalConditionLookUpEdit.Properties.ValueMember = "recordID";
			this.physicalConditionLookUpEdit.Size = new System.Drawing.Size(180, 20);
			this.physicalConditionLookUpEdit.TabIndex = 5;
			//
			//LabelControl23
			//
			this.LabelControl23.Location = new System.Drawing.Point(317, 121);
			this.LabelControl23.Name = "LabelControl23";
			this.LabelControl23.Size = new System.Drawing.Size(75, 13);
			this.LabelControl23.TabIndex = 6;
			this.LabelControl23.Text = "Load Condition:";
			//
			//LabelControl22
			//
			this.LabelControl22.Location = new System.Drawing.Point(29, 121);
			this.LabelControl22.Name = "LabelControl22";
			this.LabelControl22.Size = new System.Drawing.Size(90, 13);
			this.LabelControl22.TabIndex = 4;
			this.LabelControl22.Text = "Physical Condition:";
			//
			//LabelControl21
			//
			this.LabelControl21.Location = new System.Drawing.Point(53, 174);
			this.LabelControl21.Name = "LabelControl21";
			this.LabelControl21.Size = new System.Drawing.Size(66, 13);
			this.LabelControl21.TabIndex = 12;
			this.LabelControl21.Text = "Temperature:";
			//
			//temparatureSpinEdit
			//
			this.temparatureSpinEdit.EditValue = new decimal(new int[] {0, 0, 0, 0});
			this.temparatureSpinEdit.Location = new System.Drawing.Point(127, 171);
			this.temparatureSpinEdit.MenuManager = this.BarManager1;
			this.temparatureSpinEdit.Name = "temparatureSpinEdit";
			this.temparatureSpinEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.temparatureSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.temparatureSpinEdit.Properties.Increment = new decimal(new int[] {5, 0, 0, 65536});
			this.temparatureSpinEdit.Properties.NullText = "[Enter Temperature]";
			this.temparatureSpinEdit.Size = new System.Drawing.Size(116, 20);
			this.temparatureSpinEdit.TabIndex = 13;
			//
			//LabelControl20
			//
			this.LabelControl20.Location = new System.Drawing.Point(332, 147);
			this.LabelControl20.Name = "LabelControl20";
			this.LabelControl20.Size = new System.Drawing.Size(56, 13);
			this.LabelControl20.TabIndex = 10;
			this.LabelControl20.Text = "Finish Time:";
			//
			//finishTimeTimeEdit
			//
			this.finishTimeTimeEdit.EditValue = null;
			this.finishTimeTimeEdit.Location = new System.Drawing.Point(398, 143);
			this.finishTimeTimeEdit.MenuManager = this.BarManager1;
			this.finishTimeTimeEdit.Name = "finishTimeTimeEdit";
			this.finishTimeTimeEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.finishTimeTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.finishTimeTimeEdit.Properties.NullText = "[Enter Finish Time]";
			this.finishTimeTimeEdit.Size = new System.Drawing.Size(117, 20);
			this.finishTimeTimeEdit.TabIndex = 11;
			//
			//LabelControl19
			//
			this.LabelControl19.Location = new System.Drawing.Point(66, 147);
			this.LabelControl19.Name = "LabelControl19";
			this.LabelControl19.Size = new System.Drawing.Size(53, 13);
			this.LabelControl19.TabIndex = 8;
			this.LabelControl19.Text = "Start Time:";
			//
			//startTimeTimeEdit
			//
			this.startTimeTimeEdit.EditValue = null;
			this.startTimeTimeEdit.Location = new System.Drawing.Point(126, 144);
			this.startTimeTimeEdit.MenuManager = this.BarManager1;
			this.startTimeTimeEdit.Name = "startTimeTimeEdit";
			this.startTimeTimeEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.startTimeTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.startTimeTimeEdit.Properties.NullText = "[Enter Start Time]";
			this.startTimeTimeEdit.Size = new System.Drawing.Size(117, 20);
			this.startTimeTimeEdit.TabIndex = 9;
			//
			//checkedByLookUpEdit
			//
			this.checkedByLookUpEdit.Location = new System.Drawing.Point(398, 92);
			this.checkedByLookUpEdit.MenuManager = this.BarManager1;
			this.checkedByLookUpEdit.Name = "checkedByLookUpEdit";
			this.checkedByLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.checkedByLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.checkedByLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("recordID", "record ID", 68, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Employee Name", "Employee Name", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)
			});
			this.checkedByLookUpEdit.Properties.DataSource = this.employeeXpView;
			this.checkedByLookUpEdit.Properties.DisplayMember = "Employee Name";
			this.checkedByLookUpEdit.Properties.NullText = "[Select Employee Name]";
			this.checkedByLookUpEdit.Properties.ValueMember = "recordID";
			this.checkedByLookUpEdit.Size = new System.Drawing.Size(180, 20);
			this.checkedByLookUpEdit.TabIndex = 3;
			//
			//employeeXpView
			//
			this.employeeXpView.ObjectType = typeof(DXDAL.SPGData.Employees);
			this.employeeXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("recordID", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true),
				new DevExpress.Xpo.ViewProperty("Employee Name", DevExpress.Xpo.SortDirection.Ascending, "[LastName] + ', ' + [FirstName]", false, true)
			});
			//
			//LabelControl18
			//
			this.LabelControl18.Location = new System.Drawing.Point(332, 95);
			this.LabelControl18.Name = "LabelControl18";
			this.LabelControl18.Size = new System.Drawing.Size(60, 13);
			this.LabelControl18.TabIndex = 2;
			this.LabelControl18.Text = "Checked By:";
			//
			//LabelControl17
			//
			this.LabelControl17.Location = new System.Drawing.Point(66, 95);
			this.LabelControl17.Name = "LabelControl17";
			this.LabelControl17.Size = new System.Drawing.Size(54, 13);
			this.LabelControl17.TabIndex = 1;
			this.LabelControl17.Text = "Loaded By:";
			//
			//loadedByLookUpEdit
			//
			this.loadedByLookUpEdit.Location = new System.Drawing.Point(126, 92);
			this.loadedByLookUpEdit.MenuManager = this.BarManager1;
			this.loadedByLookUpEdit.Name = "loadedByLookUpEdit";
			this.loadedByLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.loadedByLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.loadedByLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("recordID", "record ID", 68, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Employee Name", "Employee Name", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)
			});
			this.loadedByLookUpEdit.Properties.DataSource = this.employeeXpView;
			this.loadedByLookUpEdit.Properties.DisplayMember = "Employee Name";
			this.loadedByLookUpEdit.Properties.NullText = "[Select Employee Name]";
			this.loadedByLookUpEdit.Properties.ValueMember = "recordID";
			this.loadedByLookUpEdit.Size = new System.Drawing.Size(180, 20);
			this.loadedByLookUpEdit.TabIndex = 0;
			//
			//detailsXtraTabPage
			//
			this.detailsXtraTabPage.Controls.Add(this.lpnNumberTextEdit);
			this.detailsXtraTabPage.Controls.Add(this.LabelControl15);
			this.detailsXtraTabPage.Controls.Add(this.shippingGridControl);
			this.detailsXtraTabPage.Name = "detailsXtraTabPage";
			this.detailsXtraTabPage.Size = new System.Drawing.Size(607, 405);
			this.detailsXtraTabPage.Text = "Shipping Details";
			//
			//lpnNumberTextEdit
			//
			this.lpnNumberTextEdit.Location = new System.Drawing.Point(252, 3);
			this.lpnNumberTextEdit.Name = "lpnNumberTextEdit";
			this.lpnNumberTextEdit.Size = new System.Drawing.Size(175, 20);
			this.lpnNumberTextEdit.TabIndex = 10;
			//
			//LabelControl15
			//
			this.LabelControl15.Location = new System.Drawing.Point(164, 6);
			this.LabelControl15.Name = "LabelControl15";
			this.LabelControl15.Size = new System.Drawing.Size(82, 13);
			this.LabelControl15.TabIndex = 6;
			this.LabelControl15.Text = "Import from LPN:";
			//
			//shippingGridControl
			//
			this.shippingGridControl.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.shippingGridControl.Location = new System.Drawing.Point(0, 29);
			this.shippingGridControl.MainView = this.shippingGridView;
			this.shippingGridControl.Name = "shippingGridControl";
			this.shippingGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {this.itemRepositoryItemLookUpEdit, this.noteRepositoryItemMemoExEdit, this.RepositoryItemButtonEdit1, this.delRepositoryItemButtonEdit, this.RepositoryItemDateEdit1});
			this.shippingGridControl.Size = new System.Drawing.Size(607, 374);
			this.shippingGridControl.TabIndex = 0;
			this.shippingGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.shippingGridView});
			//
			//shippingGridView
			//
			this.shippingGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.idGridColumn, this.shippingIDGridColumn, this.itemGridColumn, this.descriptionGridColumn, this.lotGridColumn, this.expirationDateGridColumn, this.fullLPNNumberGridColumn, this.quantityGridColumn, this.palletsGridColumn, this.grossWeightGridColumn, this.noteGridColumn, this.delGridColumn});
			this.shippingGridView.GridControl = this.shippingGridControl;
			this.shippingGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ShipDetDetQty", this.quantityGridColumn, "{0:#,##0.######}")});
			this.shippingGridView.Name = "shippingGridView";
			this.shippingGridView.OptionsSelection.MultiSelect = true;
			this.shippingGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
			//
			//idGridColumn
			//
			this.idGridColumn.Caption = "GridColumn1";
			this.idGridColumn.Name = "idGridColumn";
			//
			//shippingIDGridColumn
			//
			this.shippingIDGridColumn.Caption = "GridColumn1";
			this.shippingIDGridColumn.Name = "shippingIDGridColumn";
			//
			//itemGridColumn
			//
			this.itemGridColumn.Caption = "Item Number";
			this.itemGridColumn.ColumnEdit = this.itemRepositoryItemLookUpEdit;
			this.itemGridColumn.Name = "itemGridColumn";
			this.itemGridColumn.Visible = true;
			this.itemGridColumn.VisibleIndex = 2;
			this.itemGridColumn.Width = 73;
			//
			//itemRepositoryItemLookUpEdit
			//
			this.itemRepositoryItemLookUpEdit.AutoHeight = false;
			this.itemRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.itemRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 59, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default)
			});
			this.itemRepositoryItemLookUpEdit.DataSource = this.shippingItemXPView;
			this.itemRepositoryItemLookUpEdit.DisplayMember = "ItemCode";
			this.itemRepositoryItemLookUpEdit.ImmediatePopup = true;
			this.itemRepositoryItemLookUpEdit.Name = "itemRepositoryItemLookUpEdit";
			this.itemRepositoryItemLookUpEdit.NullText = "";
			this.itemRepositoryItemLookUpEdit.NullValuePrompt = "[Select A Item]";
			this.itemRepositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.itemRepositoryItemLookUpEdit.ValueMember = "ItemID";
			//
			//shippingItemXPView
			//
			this.shippingItemXPView.ObjectType = typeof(DXDAL.SPGData.Items);
			this.shippingItemXPView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[ItemID]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[ItemCode]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemCustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID]", false, true),
				new DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID.CustomerID]", false, true),
				new DevExpress.Xpo.ViewProperty("Inactive", DevExpress.Xpo.SortDirection.None, "[Inactive]", false, true)
			});
			//
			//descriptionGridColumn
			//
			this.descriptionGridColumn.Caption = "Item Description";
			this.descriptionGridColumn.FieldName = "descriptionGridColumn";
			this.descriptionGridColumn.Name = "descriptionGridColumn";
			this.descriptionGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.String;
			this.descriptionGridColumn.Visible = true;
			this.descriptionGridColumn.VisibleIndex = 3;
			this.descriptionGridColumn.Width = 73;
			//
			//lotGridColumn
			//
			this.lotGridColumn.Caption = "Lot #";
			this.lotGridColumn.Name = "lotGridColumn";
			this.lotGridColumn.Visible = true;
			this.lotGridColumn.VisibleIndex = 4;
			this.lotGridColumn.Width = 73;
			//
			//expirationDateGridColumn
			//
			this.expirationDateGridColumn.Caption = "Expiration Date";
			this.expirationDateGridColumn.ColumnEdit = this.RepositoryItemDateEdit1;
			this.expirationDateGridColumn.DisplayFormat.FormatString = "d";
			this.expirationDateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.expirationDateGridColumn.Name = "expirationDateGridColumn";
			this.expirationDateGridColumn.Visible = true;
			this.expirationDateGridColumn.VisibleIndex = 5;
			//
			//RepositoryItemDateEdit1
			//
			this.RepositoryItemDateEdit1.AutoHeight = false;
			this.RepositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton()});
			this.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1";
			//
			//fullLPNNumberGridColumn
			//
			this.fullLPNNumberGridColumn.Caption = "LPN Number";
			this.fullLPNNumberGridColumn.Name = "fullLPNNumberGridColumn";
			this.fullLPNNumberGridColumn.Visible = true;
			this.fullLPNNumberGridColumn.VisibleIndex = 1;
			//
			//quantityGridColumn
			//
			this.quantityGridColumn.Caption = "Quantity";
			this.quantityGridColumn.Name = "quantityGridColumn";
			this.quantityGridColumn.Visible = true;
			this.quantityGridColumn.VisibleIndex = 6;
			this.quantityGridColumn.Width = 73;
			//
			//palletsGridColumn
			//
			this.palletsGridColumn.Caption = "Pallets";
			this.palletsGridColumn.DisplayFormat.FormatString = "f2";
			this.palletsGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.palletsGridColumn.Name = "palletsGridColumn";
			this.palletsGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)});
			this.palletsGridColumn.Visible = true;
			this.palletsGridColumn.VisibleIndex = 8;
			this.palletsGridColumn.Width = 73;
			//
			//grossWeightGridColumn
			//
			this.grossWeightGridColumn.Caption = "Gross Weight";
			this.grossWeightGridColumn.DisplayFormat.FormatString = "f2";
			this.grossWeightGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.grossWeightGridColumn.FieldName = "grossWeightGridColumn";
			this.grossWeightGridColumn.Name = "grossWeightGridColumn";
			this.grossWeightGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
			this.grossWeightGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
			this.grossWeightGridColumn.Visible = true;
			this.grossWeightGridColumn.VisibleIndex = 7;
			this.grossWeightGridColumn.Width = 73;
			//
			//noteGridColumn
			//
			this.noteGridColumn.Caption = "Note";
			this.noteGridColumn.ColumnEdit = this.noteRepositoryItemMemoExEdit;
			this.noteGridColumn.Name = "noteGridColumn";
			this.noteGridColumn.Visible = true;
			this.noteGridColumn.VisibleIndex = 9;
			this.noteGridColumn.Width = 73;
			//
			//noteRepositoryItemMemoExEdit
			//
			this.noteRepositoryItemMemoExEdit.AutoHeight = false;
			this.noteRepositoryItemMemoExEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.noteRepositoryItemMemoExEdit.Name = "noteRepositoryItemMemoExEdit";
			//
			//delGridColumn
			//
			this.delGridColumn.ColumnEdit = this.delRepositoryItemButtonEdit;
			this.delGridColumn.MaxWidth = 30;
			this.delGridColumn.MinWidth = 25;
			this.delGridColumn.Name = "delGridColumn";
			this.delGridColumn.Visible = true;
			this.delGridColumn.VisibleIndex = 0;
			this.delGridColumn.Width = 25;
			//
			//delRepositoryItemButtonEdit
			//
			this.delRepositoryItemButtonEdit.AutoHeight = false;
			this.delRepositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
			this.delRepositoryItemButtonEdit.Name = "delRepositoryItemButtonEdit";
			this.delRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			//
			//RepositoryItemButtonEdit1
			//
			this.RepositoryItemButtonEdit1.AutoHeight = false;
			this.RepositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton()});
			this.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1";
			//
			//returnsXtraTabPage
			//
			this.returnsXtraTabPage.Controls.Add(this.returnsGridControl);
			this.returnsXtraTabPage.Name = "returnsXtraTabPage";
			this.returnsXtraTabPage.PageVisible = false;
			this.returnsXtraTabPage.Size = new System.Drawing.Size(607, 405);
			this.returnsXtraTabPage.Text = "Return Details";
			//
			//returnsGridControl
			//
			this.returnsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.returnsGridControl.Location = new System.Drawing.Point(0, 0);
			this.returnsGridControl.MainView = this.returnsGridView;
			this.returnsGridControl.Name = "returnsGridControl";
			this.returnsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {this.returnItemRepositoryItemLookUpEdit, this.returnReasonRepositoryItemMemoExEdit, this.deleteReturnRepositoryItemButtonEdit, this.RepositoryItemDateEdit2});
			this.returnsGridControl.Size = new System.Drawing.Size(607, 405);
			this.returnsGridControl.TabIndex = 0;
			this.returnsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.returnsGridView});
			//
			//returnsGridView
			//
			this.returnsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.returnIDGridColumn, this.ShippingMainIDGridColumn, this.returnItemGridColumn, this.returnItemDescGridColumn, this.returnLotGridColumn, this.returnExpirationDateGridColumn, this.returnUnitsGridColumn, this.returnQuantityGridColumn, this.returnPalletsGridColumn, this.returnReasonGridColumn, this.returnGrossWeightGridColumn, this.deleteReturnGridColumn});
			this.returnsGridView.GridControl = this.returnsGridControl;
			this.returnsGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ReturnDetQty", this.returnQuantityGridColumn, "{0:#,##0.######}")});
			this.returnsGridView.Name = "returnsGridView";
			this.returnsGridView.OptionsSelection.MultiSelect = true;
			this.returnsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
			//
			//returnIDGridColumn
			//
			this.returnIDGridColumn.Caption = "GridColumn1";
			this.returnIDGridColumn.Name = "returnIDGridColumn";
			//
			//ShippingMainIDGridColumn
			//
			this.ShippingMainIDGridColumn.Caption = "GridColumn1";
			this.ShippingMainIDGridColumn.Name = "ShippingMainIDGridColumn";
			//
			//returnItemGridColumn
			//
			this.returnItemGridColumn.Caption = "Item Number";
			this.returnItemGridColumn.ColumnEdit = this.returnItemRepositoryItemLookUpEdit;
			this.returnItemGridColumn.Name = "returnItemGridColumn";
			this.returnItemGridColumn.Visible = true;
			this.returnItemGridColumn.VisibleIndex = 1;
			//
			//returnItemRepositoryItemLookUpEdit
			//
			this.returnItemRepositoryItemLookUpEdit.AutoHeight = false;
			this.returnItemRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.returnItemRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 59, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCustomerID", "Item Customer ID", 95, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)
			});
			this.returnItemRepositoryItemLookUpEdit.DataSource = this.returnItemXPView;
			this.returnItemRepositoryItemLookUpEdit.DisplayMember = "ItemCode";
			this.returnItemRepositoryItemLookUpEdit.ImmediatePopup = true;
			this.returnItemRepositoryItemLookUpEdit.Name = "returnItemRepositoryItemLookUpEdit";
			this.returnItemRepositoryItemLookUpEdit.NullText = "";
			this.returnItemRepositoryItemLookUpEdit.NullValuePrompt = "[Select A Item]";
			this.returnItemRepositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.returnItemRepositoryItemLookUpEdit.ValueMember = "ItemID";
			//
			//returnItemXPView
			//
			this.returnItemXPView.CriteriaString = "[ItemType] = 'RM' Or [ItemType] = 'IG'";
			this.returnItemXPView.ObjectType = typeof(DXDAL.SPGData.Items);
			this.returnItemXPView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[ItemID]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[ItemCode]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemCustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID]", false, true),
				new DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID.CustomerID]", false, true),
				new DevExpress.Xpo.ViewProperty("Inactive", DevExpress.Xpo.SortDirection.None, "[Inactive]", false, true)
			});
			//
			//returnItemDescGridColumn
			//
			this.returnItemDescGridColumn.Caption = "Item Description";
			this.returnItemDescGridColumn.FieldName = "descriptionGridColumn";
			this.returnItemDescGridColumn.Name = "returnItemDescGridColumn";
			this.returnItemDescGridColumn.OptionsColumn.AllowEdit = false;
			this.returnItemDescGridColumn.OptionsColumn.ReadOnly = true;
			this.returnItemDescGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.String;
			this.returnItemDescGridColumn.Visible = true;
			this.returnItemDescGridColumn.VisibleIndex = 2;
			//
			//returnLotGridColumn
			//
			this.returnLotGridColumn.Caption = "Lot #";
			this.returnLotGridColumn.Name = "returnLotGridColumn";
			this.returnLotGridColumn.Visible = true;
			this.returnLotGridColumn.VisibleIndex = 3;
			//
			//returnExpirationDateGridColumn
			//
			this.returnExpirationDateGridColumn.Caption = "Expiration Date";
			this.returnExpirationDateGridColumn.ColumnEdit = this.RepositoryItemDateEdit2;
			this.returnExpirationDateGridColumn.Name = "returnExpirationDateGridColumn";
			this.returnExpirationDateGridColumn.Visible = true;
			this.returnExpirationDateGridColumn.VisibleIndex = 4;
			//
			//RepositoryItemDateEdit2
			//
			this.RepositoryItemDateEdit2.AutoHeight = false;
			this.RepositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.RepositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton()});
			this.RepositoryItemDateEdit2.Name = "RepositoryItemDateEdit2";
			//
			//returnUnitsGridColumn
			//
			this.returnUnitsGridColumn.Caption = "Quantity";
			this.returnUnitsGridColumn.Name = "returnUnitsGridColumn";
			this.returnUnitsGridColumn.Visible = true;
			this.returnUnitsGridColumn.VisibleIndex = 6;
			//
			//returnQuantityGridColumn
			//
			this.returnQuantityGridColumn.Caption = "Units";
			this.returnQuantityGridColumn.Name = "returnQuantityGridColumn";
			this.returnQuantityGridColumn.Visible = true;
			this.returnQuantityGridColumn.VisibleIndex = 5;
			//
			//returnPalletsGridColumn
			//
			this.returnPalletsGridColumn.Caption = "Pallets";
			this.returnPalletsGridColumn.Name = "returnPalletsGridColumn";
			this.returnPalletsGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)});
			this.returnPalletsGridColumn.Visible = true;
			this.returnPalletsGridColumn.VisibleIndex = 8;
			//
			//returnReasonGridColumn
			//
			this.returnReasonGridColumn.Caption = "Reason";
			this.returnReasonGridColumn.ColumnEdit = this.returnReasonRepositoryItemMemoExEdit;
			this.returnReasonGridColumn.Name = "returnReasonGridColumn";
			this.returnReasonGridColumn.Visible = true;
			this.returnReasonGridColumn.VisibleIndex = 9;
			//
			//returnReasonRepositoryItemMemoExEdit
			//
			this.returnReasonRepositoryItemMemoExEdit.AutoHeight = false;
			this.returnReasonRepositoryItemMemoExEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.returnReasonRepositoryItemMemoExEdit.Name = "returnReasonRepositoryItemMemoExEdit";
			//
			//returnGrossWeightGridColumn
			//
			this.returnGrossWeightGridColumn.Caption = "Gross Weight";
			this.returnGrossWeightGridColumn.FieldName = "returnGrossWeightGridColumn";
			this.returnGrossWeightGridColumn.Name = "returnGrossWeightGridColumn";
			this.returnGrossWeightGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
			this.returnGrossWeightGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
			this.returnGrossWeightGridColumn.Visible = true;
			this.returnGrossWeightGridColumn.VisibleIndex = 7;
			//
			//deleteReturnGridColumn
			//
			this.deleteReturnGridColumn.ColumnEdit = this.deleteReturnRepositoryItemButtonEdit;
			this.deleteReturnGridColumn.MaxWidth = 30;
			this.deleteReturnGridColumn.MinWidth = 25;
			this.deleteReturnGridColumn.Name = "deleteReturnGridColumn";
			this.deleteReturnGridColumn.Visible = true;
			this.deleteReturnGridColumn.VisibleIndex = 0;
			this.deleteReturnGridColumn.Width = 30;
			//
			//deleteReturnRepositoryItemButtonEdit
			//
			this.deleteReturnRepositoryItemButtonEdit.AutoHeight = false;
			this.deleteReturnRepositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
			this.deleteReturnRepositoryItemButtonEdit.Name = "deleteReturnRepositoryItemButtonEdit";
			this.deleteReturnRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			//
			//SplitContainerControl1
			//
			this.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainerControl1.Location = new System.Drawing.Point(0, 49);
			this.SplitContainerControl1.Name = "SplitContainerControl1";
			this.SplitContainerControl1.Panel1.Controls.Add(this.shippingSearchGridControl);
			this.SplitContainerControl1.Panel1.MinSize = 250;
			this.SplitContainerControl1.Panel1.Text = "Panel1";
			this.SplitContainerControl1.Panel2.Controls.Add(this.shippingXtraTabControl);
			this.SplitContainerControl1.Panel2.Text = "Panel2";
			this.SplitContainerControl1.Size = new System.Drawing.Size(868, 433);
			this.SplitContainerControl1.TabIndex = 5;
			this.SplitContainerControl1.Text = "SplitContainerControl1";
			//
			//shippingSearchGridControl
			//
			this.shippingSearchGridControl.DataSource = this.shippingSearchXPView;
			this.shippingSearchGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.shippingSearchGridControl.Location = new System.Drawing.Point(0, 0);
			this.shippingSearchGridControl.MainView = this.shippingSearchGridView;
			this.shippingSearchGridControl.Name = "shippingSearchGridControl";
			this.shippingSearchGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {this.shippingDateRepositoryItemDateEdit});
			this.shippingSearchGridControl.Size = new System.Drawing.Size(250, 433);
			this.shippingSearchGridControl.TabIndex = 0;
			this.shippingSearchGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.shippingSearchGridView});
			//
			//shippingSearchXPView
			//
			this.shippingSearchXPView.ObjectType = typeof(DXDAL.SPGData.Shipping);
			this.shippingSearchXPView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("ShippingID", DevExpress.Xpo.SortDirection.None, "[ShipMainID]", false, true),
				new DevExpress.Xpo.ViewProperty("ShippingBOL", DevExpress.Xpo.SortDirection.None, "[ShipMainBOL]", false, true),
				new DevExpress.Xpo.ViewProperty("ShippingCustomerID", DevExpress.Xpo.SortDirection.None, "[ShipMainCustID.CustomerID]", false, true),
				new DevExpress.Xpo.ViewProperty("ShippingCustomerName", DevExpress.Xpo.SortDirection.None, "[ShipMainCustID.CustomerName]", false, true),
				new DevExpress.Xpo.ViewProperty("ShippingDate", DevExpress.Xpo.SortDirection.None, "[ShipMainDate]", false, true)
			});
			this.shippingSearchXPView.Sorting.AddRange(new DevExpress.Xpo.SortProperty[] {new DevExpress.Xpo.SortProperty("[ShippingBOL]", DevExpress.Xpo.DB.SortingDirection.Descending)});
			//
			//shippingSearchGridView
			//
			this.shippingSearchGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.shippingSearchIDGridColumn, this.shippingBOLGridColumn, this.shippingCustomerGridColumn, this.shippingDateGridColumn});
			this.shippingSearchGridView.GridControl = this.shippingSearchGridControl;
			this.shippingSearchGridView.Name = "shippingSearchGridView";
			this.shippingSearchGridView.OptionsBehavior.Editable = false;
			this.shippingSearchGridView.OptionsView.ShowAutoFilterRow = true;
			this.shippingSearchGridView.OptionsView.ShowGroupPanel = false;
			//
			//shippingSearchIDGridColumn
			//
			this.shippingSearchIDGridColumn.Caption = "GridColumn1";
			this.shippingSearchIDGridColumn.FieldName = "ShippingID";
			this.shippingSearchIDGridColumn.Name = "shippingSearchIDGridColumn";
			//
			//shippingBOLGridColumn
			//
			this.shippingBOLGridColumn.Caption = "BOL #";
			this.shippingBOLGridColumn.FieldName = "ShippingBOL";
			this.shippingBOLGridColumn.Name = "shippingBOLGridColumn";
			this.shippingBOLGridColumn.Visible = true;
			this.shippingBOLGridColumn.VisibleIndex = 0;
			//
			//shippingCustomerGridColumn
			//
			this.shippingCustomerGridColumn.Caption = "Customer";
			this.shippingCustomerGridColumn.FieldName = "ShippingCustomerName";
			this.shippingCustomerGridColumn.Name = "shippingCustomerGridColumn";
			this.shippingCustomerGridColumn.Visible = true;
			this.shippingCustomerGridColumn.VisibleIndex = 1;
			//
			//shippingDateGridColumn
			//
			this.shippingDateGridColumn.Caption = "Date";
			this.shippingDateGridColumn.ColumnEdit = this.shippingDateRepositoryItemDateEdit;
			this.shippingDateGridColumn.FieldName = "ShippingDate";
			this.shippingDateGridColumn.Name = "shippingDateGridColumn";
			this.shippingDateGridColumn.Visible = true;
			this.shippingDateGridColumn.VisibleIndex = 2;
			//
			//shippingDateRepositoryItemDateEdit
			//
			this.shippingDateRepositoryItemDateEdit.AutoHeight = false;
			this.shippingDateRepositoryItemDateEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.shippingDateRepositoryItemDateEdit.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton()});
			this.shippingDateRepositoryItemDateEdit.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
			this.shippingDateRepositoryItemDateEdit.Name = "shippingDateRepositoryItemDateEdit";
			this.shippingDateRepositoryItemDateEdit.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
			//
			//ShippingXtraForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(868, 505);
			this.Controls.Add(this.SplitContainerControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "ShippingXtraForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Shipping";
			((System.ComponentModel.ISupportInitialize)this.shippingXtraTabControl).EndInit();
			this.shippingXtraTabControl.ResumeLayout(false);
			this.generalXtraTabPage.ResumeLayout(false);
			this.generalXtraTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.locationLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.BarManager1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.locationXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.freightCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.commentsMemoEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customerShipperCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.totalGrossWeightTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shiftLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.deliveryNoteNumberTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.palletsTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.noteMemoEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.destinationMemoEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.destinationLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.carrierLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.poTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customerLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customersXPView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.skitsTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.sealTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.trailerTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.bolTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shipDateEdit.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shipDateEdit.Properties).EndInit();
			this.shipmentInfoXtraTabPage.ResumeLayout(false);
			this.shipmentInfoXtraTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.correctPalletsComboBoxEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.insectActivityComboBoxEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.foreignSubstanceComboBoxEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.wheelsChockedComboBoxEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.loadConditionLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shipmentConditionXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.physicalConditionLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.temparatureSpinEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.finishTimeTimeEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.startTimeTimeEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.checkedByLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.employeeXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.loadedByLookUpEdit.Properties).EndInit();
			this.detailsXtraTabPage.ResumeLayout(false);
			this.detailsXtraTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.lpnNumberTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shippingGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shippingGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemRepositoryItemLookUpEdit).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shippingItemXPView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemDateEdit1.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemDateEdit1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.noteRepositoryItemMemoExEdit).EndInit();
			((System.ComponentModel.ISupportInitialize)this.delRepositoryItemButtonEdit).EndInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemButtonEdit1).EndInit();
			this.returnsXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.returnsGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.returnsGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.returnItemRepositoryItemLookUpEdit).EndInit();
			((System.ComponentModel.ISupportInitialize)this.returnItemXPView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemDateEdit2.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemDateEdit2).EndInit();
			((System.ComponentModel.ISupportInitialize)this.returnReasonRepositoryItemMemoExEdit).EndInit();
			((System.ComponentModel.ISupportInitialize)this.deleteReturnRepositoryItemButtonEdit).EndInit();
			((System.ComponentModel.ISupportInitialize)this.SplitContainerControl1).EndInit();
			this.SplitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.shippingSearchGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shippingSearchXPView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shippingSearchGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shippingDateRepositoryItemDateEdit.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shippingDateRepositoryItemDateEdit).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(ShippingXtraForm_FormClosing);
			base.Load += new System.EventHandler(ShippingXtraForm_Load);
			skitsTextEdit.Validated += new System.EventHandler(skitsTextEdit_Validated);
			customerLookUpEdit.Validated += new System.EventHandler(customerLookUpEdit_Validated);
			shippingGridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(shippingGridView_CustomUnboundColumnData);
			returnsGridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(returnsGridView_CustomUnboundColumnData);
			shippingGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(shippingGridView_InitNewRow);
			returnsGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(returnsGridView_InitNewRow);
			shippingGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(shippingGridView_CellValueChanged);
			returnsGridView.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(returnsGridView_CellValueChanged);
			destinationLookUpEdit.Validated += new System.EventHandler(destinationLookUpEdit_Validated);
			shippingSearchGridView.Click += new System.EventHandler(shippingSearchGridView_Click);
			addBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(addBarButtonItem_ItemClick);
			editBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(editBarButtonItem_ItemClick);
			cancelBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(cancelBarButtonItem_ItemClick);
			saveBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(saveBarButtonItem_ItemClick);
			shippingGridView.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(shippingGridView_CustomSummaryCalculate);
			returnsGridView.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(returnsGridView_CustomSummaryCalculate);
			printBOLBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(printBOLBarButtonItem_ItemClick);
			returnsGridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(returnsGridView_ValidateRow);
			deleteReturnRepositoryItemButtonEdit.Click += new System.EventHandler(deleteReturnRepositoryItemButtonEdit_Click);
			delRepositoryItemButtonEdit.Click += new System.EventHandler(delRepositoryItemButtonEdit_Click);
			itemRepositoryItemLookUpEdit.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(itemRepositoryItemLookUpEdit_Closed);
			returnItemRepositoryItemLookUpEdit.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(itemRepositoryItemLookUpEdit_Closed);
			itemRepositoryItemLookUpEdit.Enter += new System.EventHandler(itemRepositoryItemLookUpEdit_Enter);
			returnItemRepositoryItemLookUpEdit.Enter += new System.EventHandler(itemRepositoryItemLookUpEdit_Enter);
			shippingGridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(shippingGridView_ValidateRow);
			shippingGridView.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(shippingGridView_InvalidRowException);
			returnsGridView.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(returnsGridView_InvalidRowException);
			lpnNumberTextEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(LPNNumber_KeyDown);
			printPackingListBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(printPackingListBarButtonItem_ItemClick);
			temparatureSpinEdit.Validating += new System.ComponentModel.CancelEventHandler(temparatureSpinEdit_Validating);
			refreshBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(refreshBarButtonItem_ItemClick);
			LabelControl14.Click += new System.EventHandler(LabelControl14_Click);
		}
		internal DevExpress.XtraTab.XtraTabControl shippingXtraTabControl;
		internal DevExpress.XtraTab.XtraTabPage generalXtraTabPage;
		internal DevExpress.XtraTab.XtraTabPage detailsXtraTabPage;
		internal DevExpress.XtraEditors.DateEdit shipDateEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.TextEdit bolTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		internal DevExpress.XtraEditors.LabelControl LabelControl7;
		internal DevExpress.XtraEditors.TextEdit skitsTextEdit;
		internal DevExpress.XtraEditors.TextEdit sealTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl6;
		internal DevExpress.XtraEditors.LabelControl LabelControl5;
		internal DevExpress.XtraEditors.TextEdit trailerTextEdit;
		internal DevExpress.XtraEditors.LookUpEdit customerLookUpEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl8;
		internal DevExpress.XtraEditors.LabelControl LabelControl10;
		internal DevExpress.XtraEditors.TextEdit poTextEdit;
		internal DevExpress.XtraEditors.LookUpEdit carrierLookUpEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl11;
		internal DevExpress.XtraEditors.LookUpEdit destinationLookUpEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl13;
		internal DevExpress.XtraEditors.MemoEdit noteMemoEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl14;
		internal DevExpress.XtraEditors.MemoEdit destinationMemoEdit;
		internal DevExpress.XtraEditors.TextEdit palletsTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl16;
		internal DevExpress.XtraGrid.GridControl shippingGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView shippingGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn idGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn shippingIDGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn itemGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn descriptionGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn lotGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn quantityGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn palletsGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit itemRepositoryItemLookUpEdit;
		internal DevExpress.XtraEditors.SplitContainerControl SplitContainerControl1;
		internal DevExpress.XtraBars.BarManager BarManager1;
		internal DevExpress.XtraBars.Bar shippingBar;
		internal DevExpress.XtraBars.Bar Bar2;
		internal DevExpress.XtraBars.Bar Bar3;
		internal DevExpress.XtraBars.BarDockControl barDockControlTop;
		internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
		internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
		internal DevExpress.XtraBars.BarDockControl barDockControlRight;
		internal DevExpress.XtraGrid.GridControl shippingSearchGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView shippingSearchGridView;
		internal DevExpress.XtraBars.BarButtonItem addBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem editBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem cancelBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem saveBarButtonItem;
		internal DevExpress.XtraGrid.Columns.GridColumn shippingSearchIDGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn shippingBOLGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn shippingCustomerGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn shippingDateGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemDateEdit shippingDateRepositoryItemDateEdit;
		internal DevExpress.XtraEditors.TextEdit deliveryNoteNumberTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.LookUpEdit shiftLookUpEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraEditors.TextEdit totalGrossWeightTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl9;
		internal DevExpress.XtraEditors.LabelControl LabelControl12;
		internal DevExpress.XtraEditors.MemoEdit commentsMemoEdit;
		internal DevExpress.XtraEditors.CheckEdit customerShipperCheckEdit;
		internal DevExpress.XtraEditors.CheckEdit freightCheckEdit;
		internal DevExpress.XtraTab.XtraTabPage returnsXtraTabPage;
		internal DevExpress.XtraGrid.GridControl returnsGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView returnsGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn returnIDGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn ShippingMainIDGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn returnItemGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit returnItemRepositoryItemLookUpEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn returnItemDescGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn returnLotGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn returnQuantityGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn returnPalletsGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn returnReasonGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit returnReasonRepositoryItemMemoExEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn grossWeightGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn returnGrossWeightGridColumn;
		internal DevExpress.XtraBars.BarButtonItem printBOLBarButtonItem;
		internal DevExpress.XtraGrid.Columns.GridColumn deleteReturnGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit deleteReturnRepositoryItemButtonEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn noteGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit noteRepositoryItemMemoExEdit;
		internal DevExpress.Xpo.XPView shippingSearchXPView;
		internal DevExpress.Xpo.XPView customersXPView;
		internal DevExpress.Xpo.XPView shippingItemXPView;
		internal DevExpress.Xpo.XPView returnItemXPView;
		internal DevExpress.XtraGrid.Columns.GridColumn delGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit delRepositoryItemButtonEdit;
		internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RepositoryItemButtonEdit1;
		internal DevExpress.XtraGrid.Columns.GridColumn expirationDateGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemDateEdit RepositoryItemDateEdit1;
		internal DevExpress.XtraGrid.Columns.GridColumn returnExpirationDateGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemDateEdit RepositoryItemDateEdit2;
		internal DevExpress.XtraEditors.LabelControl LabelControl15;
		internal DevExpress.XtraEditors.TextEdit lpnNumberTextEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn fullLPNNumberGridColumn;
		internal DevExpress.XtraBars.BarButtonItem printPackingListBarButtonItem;
		internal DevExpress.XtraTab.XtraTabPage shipmentInfoXtraTabPage;
		internal DevExpress.XtraEditors.LookUpEdit checkedByLookUpEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl18;
		internal DevExpress.XtraEditors.LabelControl LabelControl17;
		internal DevExpress.XtraEditors.LookUpEdit loadedByLookUpEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl21;
		internal DevExpress.XtraEditors.SpinEdit temparatureSpinEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl20;
		internal DevExpress.XtraEditors.TimeEdit finishTimeTimeEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl19;
		internal DevExpress.XtraEditors.TimeEdit startTimeTimeEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl23;
		internal DevExpress.XtraEditors.LabelControl LabelControl22;
		internal DevExpress.XtraEditors.LookUpEdit loadConditionLookUpEdit;
		internal DevExpress.XtraEditors.LookUpEdit physicalConditionLookUpEdit;
		internal DevExpress.Xpo.XPView shipmentConditionXpView;
		internal DevExpress.Xpo.XPView employeeXpView;
		internal DevExpress.XtraEditors.ComboBoxEdit correctPalletsComboBoxEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl24;
		internal DevExpress.XtraEditors.ComboBoxEdit insectActivityComboBoxEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl25;
		internal DevExpress.XtraEditors.ComboBoxEdit foreignSubstanceComboBoxEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl26;
		internal DevExpress.XtraEditors.ComboBoxEdit wheelsChockedComboBoxEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl27;
		internal DevExpress.XtraGrid.Columns.GridColumn returnUnitsGridColumn;
		internal DevExpress.XtraBars.BarButtonItem refreshBarButtonItem;
		internal DevExpress.XtraEditors.LookUpEdit locationLookUpEdit;
		internal DevExpress.Xpo.XPView locationXpView;
		internal DevExpress.XtraEditors.LabelControl LabelControl28;
	}

}