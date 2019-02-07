using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Data.Filtering;
using DXDAL.SPGData;
using DevExpress.Xpo;

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
	public partial class CustomersXtraForm : DevExpress.XtraEditors.XtraForm
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
			DevExpress.XtraGrid.GridLevelNode GridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersXtraForm));
			this.locationInventoryGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.locationCodeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.locationNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.quantityOnHandGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.itemsGridControl = new DevExpress.XtraGrid.GridControl();
			this.customerItemsXpCollection = new DevExpress.Xpo.XPCollection(this.components);
			this.itemsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.codeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.descriptionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.onHandGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.palletsOnHandGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.customersXtraTabControl = new DevExpress.XtraTab.XtraTabControl();
			this.generalXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.lotCodeFormatLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.BarManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.customersMenuBar = new DevExpress.XtraBars.Bar();
			this.addBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.editBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.deleteBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.cancelBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.saveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.reportsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.Bar2 = new DevExpress.XtraBars.Bar();
			this.Bar3 = new DevExpress.XtraBars.Bar();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.lotCodeFormatsXpView = new DevExpress.Xpo.XPView(this.components);
			this.SimpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl11 = new DevExpress.XtraEditors.LabelControl();
			this.expirationDateFormatComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
			this.lpnGroupControl = new DevExpress.XtraEditors.GroupControl();
			this.resetLPNSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.plantCodeLabelControl = new DevExpress.XtraEditors.LabelControl();
			this.plantCodeTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.lastNumberLabelControl = new DevExpress.XtraEditors.LabelControl();
			this.lastLPNNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.firsstNumberLabelControl = new DevExpress.XtraEditors.LabelControl();
			this.firstLPNNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.lpnPrefixlabelControl = new DevExpress.XtraEditors.LabelControl();
			this.lpnPrefixTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.inactiveCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.postalTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.stateTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.cityTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.addressTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.noteMemoEdit = new DevExpress.XtraEditors.MemoEdit();
			this.faxTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.emailTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.phoneTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.contactTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.itemsXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.relatedCustomersXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.addRelatedCustomerGroupControl = new DevExpress.XtraEditors.GroupControl();
			this.relatedCustomerLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.customersXpView = new DevExpress.Xpo.XPView(this.components);
			this.addBothWaysSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.addOneWaySimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.relatedCustomersGridControl = new DevExpress.XtraGrid.GridControl();
			this.relatedCustomerXpCollection = new DevExpress.Xpo.XPCollection(this.components);
			this.relatedCustomersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.relatedCustomerNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colBidirectional = new DevExpress.XtraGrid.Columns.GridColumn();
			this.deleteGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.deleteRepositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			this.idGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.locationsXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.SplitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
			this.customerPlantsGridControl = new DevExpress.XtraGrid.GridControl();
			this.customerPlantsXpCollection = new DevExpress.Xpo.XPCollection(this.components);
			this.customerPlantsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.deleteCustomerPlantGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.deleteCustomerPlantRepositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHasChanges = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPlantName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPlantCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.spgLocationsRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.spgLocationsXpView = new DevExpress.Xpo.XPView(this.components);
			this.customerShiftsGridControl = new DevExpress.XtraGrid.GridControl();
			this.customerShiftsXpCollection = new DevExpress.Xpo.XPCollection(this.components);
			this.customerShiftsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.deleteCustomerShiftGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.deleteCustomerShiftRepositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			this.colOid1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colHasChanges1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShiftName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShiftCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.spgShiftRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.spgShiftsXpView = new DevExpress.Xpo.XPView(this.components);
			this.SplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			this.inactiveSearchCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.customerSearchGridControl = new DevExpress.XtraGrid.GridControl();
			this.customerSearchXPView = new DevExpress.Xpo.XPView(this.components);
			this.customerSearchGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.customerIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.nameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)this.locationInventoryGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemsGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customerItemsXpCollection).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemsGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customersXtraTabControl).BeginInit();
			this.customersXtraTabControl.SuspendLayout();
			this.generalXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
			this.GroupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.lotCodeFormatLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.BarManager1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.lotCodeFormatsXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.expirationDateFormatComboBox.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.lpnGroupControl).BeginInit();
			this.lpnGroupControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.plantCodeTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.lastLPNNumberTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.firstLPNNumberTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.lpnPrefixTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.inactiveCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.postalTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.stateTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.cityTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.addressTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.noteMemoEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.faxTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.emailTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.phoneTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.contactTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.nameTextEdit.Properties).BeginInit();
			this.itemsXtraTabPage.SuspendLayout();
			this.relatedCustomersXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.addRelatedCustomerGroupControl).BeginInit();
			this.addRelatedCustomerGroupControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.relatedCustomerLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customersXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.relatedCustomersGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.relatedCustomerXpCollection).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.relatedCustomersGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.deleteRepositoryItemButtonEdit).BeginInit();
			this.locationsXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.SplitContainerControl2).BeginInit();
			this.SplitContainerControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.customerPlantsGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customerPlantsXpCollection).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customerPlantsGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.deleteCustomerPlantRepositoryItemButtonEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.spgLocationsRepositoryItemLookUpEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.spgLocationsXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customerShiftsGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customerShiftsXpCollection).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customerShiftsGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.deleteCustomerShiftRepositoryItemButtonEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.spgShiftRepositoryItemLookUpEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.spgShiftsXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.SplitContainerControl1).BeginInit();
			this.SplitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.inactiveSearchCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customerSearchGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customerSearchXPView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customerSearchGridView).BeginInit();
			this.SuspendLayout();
			//
			//locationInventoryGridView
			//
			this.locationInventoryGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.locationCodeGridColumn, this.locationNameGridColumn, this.quantityOnHandGridColumn});
			this.locationInventoryGridView.GridControl = this.itemsGridControl;
			this.locationInventoryGridView.Name = "locationInventoryGridView";
			this.locationInventoryGridView.OptionsBehavior.Editable = false;
			this.locationInventoryGridView.OptionsView.ShowGroupPanel = false;
			//
			//locationCodeGridColumn
			//
			this.locationCodeGridColumn.Caption = "Location Code";
			this.locationCodeGridColumn.FieldName = "Location.LocationCode";
			this.locationCodeGridColumn.Name = "locationCodeGridColumn";
			this.locationCodeGridColumn.Visible = true;
			this.locationCodeGridColumn.VisibleIndex = 0;
			//
			//locationNameGridColumn
			//
			this.locationNameGridColumn.Caption = "Location Name";
			this.locationNameGridColumn.FieldName = "Location.LocationName";
			this.locationNameGridColumn.Name = "locationNameGridColumn";
			this.locationNameGridColumn.Visible = true;
			this.locationNameGridColumn.VisibleIndex = 1;
			//
			//quantityOnHandGridColumn
			//
			this.quantityOnHandGridColumn.Caption = "Quantity On Hand";
			this.quantityOnHandGridColumn.FieldName = "QuantityOnHand";
			this.quantityOnHandGridColumn.Name = "quantityOnHandGridColumn";
			this.quantityOnHandGridColumn.Visible = true;
			this.quantityOnHandGridColumn.VisibleIndex = 2;
			//
			//itemsGridControl
			//
			this.itemsGridControl.DataSource = this.customerItemsXpCollection;
			this.itemsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			GridLevelNode2.LevelTemplate = this.locationInventoryGridView;
			GridLevelNode2.RelationName = "LocationsInventory";
			this.itemsGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {GridLevelNode2});
			this.itemsGridControl.Location = new System.Drawing.Point(0, 0);
			this.itemsGridControl.MainView = this.itemsGridView;
			this.itemsGridControl.Name = "itemsGridControl";
			this.itemsGridControl.ShowOnlyPredefinedDetails = true;
			this.itemsGridControl.Size = new System.Drawing.Size(573, 437);
			this.itemsGridControl.TabIndex = 0;
			this.itemsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.itemsGridView, this.locationInventoryGridView});
			//
			//customerItemsXpCollection
			//
			this.customerItemsXpCollection.ObjectType = typeof(DXDAL.SPGData.Items);
			//
			//itemsGridView
			//
			this.itemsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.codeGridColumn, this.descriptionGridColumn, this.onHandGridColumn, this.palletsOnHandGridColumn});
			this.itemsGridView.GridControl = this.itemsGridControl;
			this.itemsGridView.Name = "itemsGridView";
			this.itemsGridView.OptionsBehavior.Editable = false;
			this.itemsGridView.OptionsView.ShowAutoFilterRow = true;
			this.itemsGridView.OptionsView.ShowFooter = true;
			//
			//codeGridColumn
			//
			this.codeGridColumn.Caption = "Item Number";
			this.codeGridColumn.FieldName = "ItemCode";
			this.codeGridColumn.Name = "codeGridColumn";
			this.codeGridColumn.OptionsColumn.ReadOnly = true;
			this.codeGridColumn.Visible = true;
			this.codeGridColumn.VisibleIndex = 0;
			//
			//descriptionGridColumn
			//
			this.descriptionGridColumn.Caption = "Description";
			this.descriptionGridColumn.FieldName = "ItemDescription";
			this.descriptionGridColumn.Name = "descriptionGridColumn";
			this.descriptionGridColumn.OptionsColumn.ReadOnly = true;
			this.descriptionGridColumn.Visible = true;
			this.descriptionGridColumn.VisibleIndex = 1;
			//
			//onHandGridColumn
			//
			this.onHandGridColumn.Caption = "On Hand";
			this.onHandGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.onHandGridColumn.FieldName = "TotalQuantityOnHand";
			this.onHandGridColumn.Name = "onHandGridColumn";
			this.onHandGridColumn.OptionsColumn.ReadOnly = true;
			this.onHandGridColumn.Visible = true;
			this.onHandGridColumn.VisibleIndex = 2;
			//
			//palletsOnHandGridColumn
			//
			this.palletsOnHandGridColumn.Caption = "Pallets On Hand";
			this.palletsOnHandGridColumn.DisplayFormat.FormatString = "{0:#,##0.######}";
			this.palletsOnHandGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.palletsOnHandGridColumn.FieldName = "palletsOnHandGridColumn";
			this.palletsOnHandGridColumn.Name = "palletsOnHandGridColumn";
			this.palletsOnHandGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "palletsOnHandGridColumn", "{0:#,##0.######}")});
			this.palletsOnHandGridColumn.UnboundExpression = "[TotalQuantityOnHand]/[intUnitsPerPallet]";
			this.palletsOnHandGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
			this.palletsOnHandGridColumn.Visible = true;
			this.palletsOnHandGridColumn.VisibleIndex = 3;
			//
			//customersXtraTabControl
			//
			this.customersXtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.customersXtraTabControl.Location = new System.Drawing.Point(0, 0);
			this.customersXtraTabControl.Name = "customersXtraTabControl";
			this.customersXtraTabControl.SelectedTabPage = this.generalXtraTabPage;
			this.customersXtraTabControl.Size = new System.Drawing.Size(579, 465);
			this.customersXtraTabControl.TabIndex = 0;
			this.customersXtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {this.generalXtraTabPage, this.itemsXtraTabPage, this.relatedCustomersXtraTabPage, this.locationsXtraTabPage});
			//
			//generalXtraTabPage
			//
			this.generalXtraTabPage.Controls.Add(this.GroupControl1);
			this.generalXtraTabPage.Controls.Add(this.lpnGroupControl);
			this.generalXtraTabPage.Controls.Add(this.inactiveCheckEdit);
			this.generalXtraTabPage.Controls.Add(this.postalTextEdit);
			this.generalXtraTabPage.Controls.Add(this.stateTextEdit);
			this.generalXtraTabPage.Controls.Add(this.cityTextEdit);
			this.generalXtraTabPage.Controls.Add(this.addressTextEdit);
			this.generalXtraTabPage.Controls.Add(this.LabelControl10);
			this.generalXtraTabPage.Controls.Add(this.LabelControl9);
			this.generalXtraTabPage.Controls.Add(this.noteMemoEdit);
			this.generalXtraTabPage.Controls.Add(this.faxTextEdit);
			this.generalXtraTabPage.Controls.Add(this.emailTextEdit);
			this.generalXtraTabPage.Controls.Add(this.phoneTextEdit);
			this.generalXtraTabPage.Controls.Add(this.contactTextEdit);
			this.generalXtraTabPage.Controls.Add(this.nameTextEdit);
			this.generalXtraTabPage.Controls.Add(this.LabelControl7);
			this.generalXtraTabPage.Controls.Add(this.LabelControl5);
			this.generalXtraTabPage.Controls.Add(this.LabelControl4);
			this.generalXtraTabPage.Controls.Add(this.LabelControl3);
			this.generalXtraTabPage.Controls.Add(this.LabelControl2);
			this.generalXtraTabPage.Name = "generalXtraTabPage";
			this.generalXtraTabPage.Size = new System.Drawing.Size(573, 437);
			this.generalXtraTabPage.Text = "General Info";
			//
			//GroupControl1
			//
			this.GroupControl1.Controls.Add(this.lotCodeFormatLookUpEdit);
			this.GroupControl1.Controls.Add(this.SimpleButton1);
			this.GroupControl1.Controls.Add(this.LabelControl6);
			this.GroupControl1.Controls.Add(this.LabelControl11);
			this.GroupControl1.Controls.Add(this.expirationDateFormatComboBox);
			this.GroupControl1.Location = new System.Drawing.Point(31, 356);
			this.GroupControl1.Name = "GroupControl1";
			this.GroupControl1.Size = new System.Drawing.Size(523, 73);
			this.GroupControl1.TabIndex = 23;
			this.GroupControl1.Text = "Other Settings";
			//
			//lotCodeFormatLookUpEdit
			//
			this.lotCodeFormatLookUpEdit.Location = new System.Drawing.Point(217, 44);
			this.lotCodeFormatLookUpEdit.MenuManager = this.BarManager1;
			this.lotCodeFormatLookUpEdit.Name = "lotCodeFormatLookUpEdit";
			this.lotCodeFormatLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.lotCodeFormatLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FormatID", "Format ID", 71, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FormatName", "Format Name", 74, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)
			});
			this.lotCodeFormatLookUpEdit.Properties.DataSource = this.lotCodeFormatsXpView;
			this.lotCodeFormatLookUpEdit.Properties.DisplayMember = "FormatName";
			this.lotCodeFormatLookUpEdit.Properties.NullText = "[Select A Lot Code Format]";
			this.lotCodeFormatLookUpEdit.Properties.ValueMember = "FormatID";
			this.lotCodeFormatLookUpEdit.Size = new System.Drawing.Size(206, 20);
			this.lotCodeFormatLookUpEdit.TabIndex = 9;
			//
			//BarManager1
			//
			this.BarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.customersMenuBar, this.Bar2, this.Bar3});
			this.BarManager1.DockControls.Add(this.barDockControlTop);
			this.BarManager1.DockControls.Add(this.barDockControlBottom);
			this.BarManager1.DockControls.Add(this.barDockControlLeft);
			this.BarManager1.DockControls.Add(this.barDockControlRight);
			this.BarManager1.Form = this;
			this.BarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.addBarButtonItem, this.editBarButtonItem, this.deleteBarButtonItem, this.cancelBarButtonItem, this.saveBarButtonItem, this.reportsBarButtonItem});
			this.BarManager1.MainMenu = this.Bar2;
			this.BarManager1.MaxItemId = 6;
			this.BarManager1.StatusBar = this.Bar3;
			//
			//customersMenuBar
			//
			this.customersMenuBar.BarName = "Tools";
			this.customersMenuBar.DockCol = 0;
			this.customersMenuBar.DockRow = 1;
			this.customersMenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.customersMenuBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.addBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.editBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.deleteBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.cancelBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.saveBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.reportsBarButtonItem, true)
			});
			this.customersMenuBar.OptionsBar.UseWholeRow = true;
			this.customersMenuBar.Text = "Tools";
			//
			//addBarButtonItem
			//
			this.addBarButtonItem.Caption = "&Add Customer";
			this.addBarButtonItem.Id = 0;
			this.addBarButtonItem.Name = "addBarButtonItem";
			//
			//editBarButtonItem
			//
			this.editBarButtonItem.Caption = "&Edit Customer";
			this.editBarButtonItem.Id = 1;
			this.editBarButtonItem.Name = "editBarButtonItem";
			//
			//deleteBarButtonItem
			//
			this.deleteBarButtonItem.Caption = "Delete Customer";
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
			//reportsBarButtonItem
			//
			this.reportsBarButtonItem.Caption = "&Reports";
			this.reportsBarButtonItem.Id = 5;
			this.reportsBarButtonItem.Name = "reportsBarButtonItem";
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
			this.barDockControlTop.Size = new System.Drawing.Size(784, 49);
			//
			//barDockControlBottom
			//
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 514);
			this.barDockControlBottom.Size = new System.Drawing.Size(784, 23);
			//
			//barDockControlLeft
			//
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 49);
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 465);
			//
			//barDockControlRight
			//
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(784, 49);
			this.barDockControlRight.Size = new System.Drawing.Size(0, 465);
			//
			//lotCodeFormatsXpView
			//
			this.lotCodeFormatsXpView.ObjectType = typeof(DXDAL.SPGData.LotCodeFormats);
			this.lotCodeFormatsXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("FormatID", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true),
				new DevExpress.Xpo.ViewProperty("FormatName", DevExpress.Xpo.SortDirection.Ascending, "[FormatName]", false, true)
			});
			//
			//SimpleButton1
			//
			this.SimpleButton1.Location = new System.Drawing.Point(430, 25);
			this.SimpleButton1.Name = "SimpleButton1";
			this.SimpleButton1.Size = new System.Drawing.Size(75, 39);
			this.SimpleButton1.TabIndex = 8;
			this.SimpleButton1.Text = "Reset LPN " + "\r" + "\n" + "Number";
			this.SimpleButton1.Visible = false;
			//
			//LabelControl6
			//
			this.LabelControl6.Location = new System.Drawing.Point(217, 23);
			this.LabelControl6.Name = "LabelControl6";
			this.LabelControl6.Size = new System.Drawing.Size(80, 13);
			this.LabelControl6.TabIndex = 5;
			this.LabelControl6.Text = "Lot Code Format";
			//
			//LabelControl11
			//
			this.LabelControl11.Location = new System.Drawing.Point(5, 24);
			this.LabelControl11.Name = "LabelControl11";
			this.LabelControl11.Size = new System.Drawing.Size(111, 13);
			this.LabelControl11.TabIndex = 1;
			this.LabelControl11.Text = "Expiration Date Format";
			//
			//expirationDateFormatComboBox
			//
			this.expirationDateFormatComboBox.EditValue = "";
			this.expirationDateFormatComboBox.Location = new System.Drawing.Point(5, 43);
			this.expirationDateFormatComboBox.MenuManager = this.BarManager1;
			this.expirationDateFormatComboBox.Name = "expirationDateFormatComboBox";
			this.expirationDateFormatComboBox.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.expirationDateFormatComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.expirationDateFormatComboBox.Properties.Items.AddRange(new object[] {"MM/dd/yyyy", "MM/yyyy"});
			this.expirationDateFormatComboBox.Size = new System.Drawing.Size(206, 20);
			this.expirationDateFormatComboBox.TabIndex = 0;
			//
			//lpnGroupControl
			//
			this.lpnGroupControl.Controls.Add(this.resetLPNSimpleButton);
			this.lpnGroupControl.Controls.Add(this.plantCodeLabelControl);
			this.lpnGroupControl.Controls.Add(this.plantCodeTextEdit);
			this.lpnGroupControl.Controls.Add(this.lastNumberLabelControl);
			this.lpnGroupControl.Controls.Add(this.lastLPNNumberTextEdit);
			this.lpnGroupControl.Controls.Add(this.firsstNumberLabelControl);
			this.lpnGroupControl.Controls.Add(this.firstLPNNumberTextEdit);
			this.lpnGroupControl.Controls.Add(this.lpnPrefixlabelControl);
			this.lpnGroupControl.Controls.Add(this.lpnPrefixTextEdit);
			this.lpnGroupControl.Location = new System.Drawing.Point(31, 277);
			this.lpnGroupControl.Name = "lpnGroupControl";
			this.lpnGroupControl.Size = new System.Drawing.Size(523, 73);
			this.lpnGroupControl.TabIndex = 22;
			this.lpnGroupControl.Text = "LPN Settings";
			//
			//resetLPNSimpleButton
			//
			this.resetLPNSimpleButton.Location = new System.Drawing.Point(430, 25);
			this.resetLPNSimpleButton.Name = "resetLPNSimpleButton";
			this.resetLPNSimpleButton.Size = new System.Drawing.Size(75, 39);
			this.resetLPNSimpleButton.TabIndex = 8;
			this.resetLPNSimpleButton.Text = "Reset LPN " + "\r" + "\n" + "Number";
			//
			//plantCodeLabelControl
			//
			this.plantCodeLabelControl.Location = new System.Drawing.Point(323, 25);
			this.plantCodeLabelControl.Name = "plantCodeLabelControl";
			this.plantCodeLabelControl.Size = new System.Drawing.Size(52, 13);
			this.plantCodeLabelControl.TabIndex = 7;
			this.plantCodeLabelControl.Text = "Plant Code";
			//
			//plantCodeTextEdit
			//
			this.plantCodeTextEdit.Location = new System.Drawing.Point(323, 44);
			this.plantCodeTextEdit.MenuManager = this.BarManager1;
			this.plantCodeTextEdit.Name = "plantCodeTextEdit";
			this.plantCodeTextEdit.Size = new System.Drawing.Size(100, 20);
			this.plantCodeTextEdit.TabIndex = 6;
			//
			//lastNumberLabelControl
			//
			this.lastNumberLabelControl.Location = new System.Drawing.Point(217, 24);
			this.lastNumberLabelControl.Name = "lastNumberLabelControl";
			this.lastNumberLabelControl.Size = new System.Drawing.Size(60, 13);
			this.lastNumberLabelControl.TabIndex = 5;
			this.lastNumberLabelControl.Text = "Last Number";
			//
			//lastLPNNumberTextEdit
			//
			this.lastLPNNumberTextEdit.Location = new System.Drawing.Point(217, 43);
			this.lastLPNNumberTextEdit.MenuManager = this.BarManager1;
			this.lastLPNNumberTextEdit.Name = "lastLPNNumberTextEdit";
			this.lastLPNNumberTextEdit.Size = new System.Drawing.Size(100, 20);
			this.lastLPNNumberTextEdit.TabIndex = 4;
			//
			//firsstNumberLabelControl
			//
			this.firsstNumberLabelControl.Location = new System.Drawing.Point(111, 24);
			this.firsstNumberLabelControl.Name = "firsstNumberLabelControl";
			this.firsstNumberLabelControl.Size = new System.Drawing.Size(61, 13);
			this.firsstNumberLabelControl.TabIndex = 3;
			this.firsstNumberLabelControl.Text = "First Number";
			//
			//firstLPNNumberTextEdit
			//
			this.firstLPNNumberTextEdit.EditValue = "";
			this.firstLPNNumberTextEdit.Location = new System.Drawing.Point(111, 43);
			this.firstLPNNumberTextEdit.MenuManager = this.BarManager1;
			this.firstLPNNumberTextEdit.Name = "firstLPNNumberTextEdit";
			this.firstLPNNumberTextEdit.Size = new System.Drawing.Size(100, 20);
			this.firstLPNNumberTextEdit.TabIndex = 2;
			//
			//lpnPrefixlabelControl
			//
			this.lpnPrefixlabelControl.Location = new System.Drawing.Point(5, 24);
			this.lpnPrefixlabelControl.Name = "lpnPrefixlabelControl";
			this.lpnPrefixlabelControl.Size = new System.Drawing.Size(49, 13);
			this.lpnPrefixlabelControl.TabIndex = 1;
			this.lpnPrefixlabelControl.Text = "LPN Prefix";
			//
			//lpnPrefixTextEdit
			//
			this.lpnPrefixTextEdit.EditValue = "";
			this.lpnPrefixTextEdit.Location = new System.Drawing.Point(5, 43);
			this.lpnPrefixTextEdit.MenuManager = this.BarManager1;
			this.lpnPrefixTextEdit.Name = "lpnPrefixTextEdit";
			this.lpnPrefixTextEdit.Size = new System.Drawing.Size(100, 20);
			this.lpnPrefixTextEdit.TabIndex = 0;
			//
			//inactiveCheckEdit
			//
			this.inactiveCheckEdit.Location = new System.Drawing.Point(151, 252);
			this.inactiveCheckEdit.Name = "inactiveCheckEdit";
			this.inactiveCheckEdit.Properties.Caption = "Inactive";
			this.inactiveCheckEdit.Size = new System.Drawing.Size(75, 19);
			this.inactiveCheckEdit.TabIndex = 21;
			//
			//postalTextEdit
			//
			this.postalTextEdit.Location = new System.Drawing.Point(395, 99);
			this.postalTextEdit.Name = "postalTextEdit";
			this.postalTextEdit.Properties.NullText = "[Postal]";
			this.postalTextEdit.Size = new System.Drawing.Size(100, 20);
			this.postalTextEdit.TabIndex = 9;
			//
			//stateTextEdit
			//
			this.stateTextEdit.Location = new System.Drawing.Point(289, 99);
			this.stateTextEdit.Name = "stateTextEdit";
			this.stateTextEdit.Properties.NullText = "[State]";
			this.stateTextEdit.Size = new System.Drawing.Size(100, 20);
			this.stateTextEdit.TabIndex = 8;
			//
			//cityTextEdit
			//
			this.cityTextEdit.Location = new System.Drawing.Point(153, 99);
			this.cityTextEdit.Name = "cityTextEdit";
			this.cityTextEdit.Properties.NullText = "[City]";
			this.cityTextEdit.Size = new System.Drawing.Size(130, 20);
			this.cityTextEdit.TabIndex = 7;
			//
			//addressTextEdit
			//
			this.addressTextEdit.Location = new System.Drawing.Point(153, 73);
			this.addressTextEdit.Name = "addressTextEdit";
			this.addressTextEdit.Size = new System.Drawing.Size(342, 20);
			this.addressTextEdit.TabIndex = 5;
			//
			//LabelControl10
			//
			this.LabelControl10.Location = new System.Drawing.Point(66, 102);
			this.LabelControl10.Name = "LabelControl10";
			this.LabelControl10.Size = new System.Drawing.Size(67, 13);
			this.LabelControl10.TabIndex = 6;
			this.LabelControl10.Text = "City\\State\\Zip";
			//
			//LabelControl9
			//
			this.LabelControl9.Location = new System.Drawing.Point(66, 76);
			this.LabelControl9.Name = "LabelControl9";
			this.LabelControl9.Size = new System.Drawing.Size(39, 13);
			this.LabelControl9.TabIndex = 4;
			this.LabelControl9.Text = "Address";
			//
			//noteMemoEdit
			//
			this.noteMemoEdit.Location = new System.Drawing.Point(153, 177);
			this.noteMemoEdit.Name = "noteMemoEdit";
			this.noteMemoEdit.Size = new System.Drawing.Size(342, 69);
			this.noteMemoEdit.TabIndex = 16;
			//
			//faxTextEdit
			//
			this.faxTextEdit.Location = new System.Drawing.Point(327, 125);
			this.faxTextEdit.Name = "faxTextEdit";
			this.faxTextEdit.Properties.NullText = "[Fax Number]";
			this.faxTextEdit.Size = new System.Drawing.Size(168, 20);
			this.faxTextEdit.TabIndex = 12;
			//
			//emailTextEdit
			//
			this.emailTextEdit.Location = new System.Drawing.Point(153, 151);
			this.emailTextEdit.Name = "emailTextEdit";
			this.emailTextEdit.Size = new System.Drawing.Size(342, 20);
			this.emailTextEdit.TabIndex = 14;
			//
			//phoneTextEdit
			//
			this.phoneTextEdit.Location = new System.Drawing.Point(153, 125);
			this.phoneTextEdit.Name = "phoneTextEdit";
			this.phoneTextEdit.Properties.NullText = "[Phone Number]";
			this.phoneTextEdit.Size = new System.Drawing.Size(168, 20);
			this.phoneTextEdit.TabIndex = 11;
			//
			//contactTextEdit
			//
			this.contactTextEdit.Location = new System.Drawing.Point(153, 46);
			this.contactTextEdit.Name = "contactTextEdit";
			this.contactTextEdit.Size = new System.Drawing.Size(342, 20);
			this.contactTextEdit.TabIndex = 3;
			//
			//nameTextEdit
			//
			this.nameTextEdit.Location = new System.Drawing.Point(153, 20);
			this.nameTextEdit.Name = "nameTextEdit";
			this.nameTextEdit.Size = new System.Drawing.Size(342, 20);
			this.nameTextEdit.TabIndex = 1;
			//
			//LabelControl7
			//
			this.LabelControl7.Location = new System.Drawing.Point(66, 180);
			this.LabelControl7.Name = "LabelControl7";
			this.LabelControl7.Size = new System.Drawing.Size(23, 13);
			this.LabelControl7.TabIndex = 15;
			this.LabelControl7.Text = "Note";
			//
			//LabelControl5
			//
			this.LabelControl5.Location = new System.Drawing.Point(66, 154);
			this.LabelControl5.Name = "LabelControl5";
			this.LabelControl5.Size = new System.Drawing.Size(66, 13);
			this.LabelControl5.TabIndex = 13;
			this.LabelControl5.Text = "Email Address";
			//
			//LabelControl4
			//
			this.LabelControl4.Location = new System.Drawing.Point(66, 128);
			this.LabelControl4.Name = "LabelControl4";
			this.LabelControl4.Size = new System.Drawing.Size(52, 13);
			this.LabelControl4.TabIndex = 10;
			this.LabelControl4.Text = "Phone\\Fax";
			//
			//LabelControl3
			//
			this.LabelControl3.Location = new System.Drawing.Point(66, 49);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(68, 13);
			this.LabelControl3.TabIndex = 2;
			this.LabelControl3.Text = "Contact Name";
			//
			//LabelControl2
			//
			this.LabelControl2.Location = new System.Drawing.Point(66, 23);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(27, 13);
			this.LabelControl2.TabIndex = 0;
			this.LabelControl2.Text = "Name";
			//
			//itemsXtraTabPage
			//
			this.itemsXtraTabPage.Controls.Add(this.itemsGridControl);
			this.itemsXtraTabPage.Name = "itemsXtraTabPage";
			this.itemsXtraTabPage.Size = new System.Drawing.Size(573, 437);
			this.itemsXtraTabPage.Text = "Items";
			//
			//relatedCustomersXtraTabPage
			//
			this.relatedCustomersXtraTabPage.Controls.Add(this.addRelatedCustomerGroupControl);
			this.relatedCustomersXtraTabPage.Controls.Add(this.relatedCustomersGridControl);
			this.relatedCustomersXtraTabPage.Name = "relatedCustomersXtraTabPage";
			this.relatedCustomersXtraTabPage.Size = new System.Drawing.Size(573, 437);
			this.relatedCustomersXtraTabPage.Text = "Related Customers";
			//
			//addRelatedCustomerGroupControl
			//
			this.addRelatedCustomerGroupControl.Controls.Add(this.relatedCustomerLookUpEdit);
			this.addRelatedCustomerGroupControl.Controls.Add(this.addBothWaysSimpleButton);
			this.addRelatedCustomerGroupControl.Controls.Add(this.addOneWaySimpleButton);
			this.addRelatedCustomerGroupControl.Location = new System.Drawing.Point(3, 10);
			this.addRelatedCustomerGroupControl.Name = "addRelatedCustomerGroupControl";
			this.addRelatedCustomerGroupControl.Size = new System.Drawing.Size(561, 75);
			this.addRelatedCustomerGroupControl.TabIndex = 4;
			this.addRelatedCustomerGroupControl.Text = "Add related Customers";
			//
			//relatedCustomerLookUpEdit
			//
			this.relatedCustomerLookUpEdit.Location = new System.Drawing.Point(31, 37);
			this.relatedCustomerLookUpEdit.MenuManager = this.BarManager1;
			this.relatedCustomerLookUpEdit.Name = "relatedCustomerLookUpEdit";
			this.relatedCustomerLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.relatedCustomerLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Customer Name", 99, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerID", "Customer ID", 70, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)
			});
			this.relatedCustomerLookUpEdit.Properties.DataSource = this.customersXpView;
			this.relatedCustomerLookUpEdit.Properties.DisplayMember = "CustomerName";
			this.relatedCustomerLookUpEdit.Properties.NullValuePrompt = "[Select a related customer]";
			this.relatedCustomerLookUpEdit.Properties.ValueMember = "CustomerID";
			this.relatedCustomerLookUpEdit.Size = new System.Drawing.Size(278, 20);
			this.relatedCustomerLookUpEdit.TabIndex = 6;
			//
			//customersXpView
			//
			this.customersXpView.CriteriaString = "[Inactive] = False";
			this.customersXpView.ObjectType = typeof(DXDAL.SPGData.Customers);
			this.customersXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[CustomerID]", false, true),
				new DevExpress.Xpo.ViewProperty("CustomerName", DevExpress.Xpo.SortDirection.Ascending, "[CustomerName]", false, true),
				new DevExpress.Xpo.ViewProperty("Inactive", DevExpress.Xpo.SortDirection.None, "[Inactive]", false, true)
			});
			//
			//addBothWaysSimpleButton
			//
			this.addBothWaysSimpleButton.Location = new System.Drawing.Point(425, 37);
			this.addBothWaysSimpleButton.Name = "addBothWaysSimpleButton";
			this.addBothWaysSimpleButton.Size = new System.Drawing.Size(104, 23);
			this.addBothWaysSimpleButton.TabIndex = 5;
			this.addBothWaysSimpleButton.Text = "Add Both Ways";
			//
			//addOneWaySimpleButton
			//
			this.addOneWaySimpleButton.Location = new System.Drawing.Point(315, 37);
			this.addOneWaySimpleButton.Name = "addOneWaySimpleButton";
			this.addOneWaySimpleButton.Size = new System.Drawing.Size(104, 23);
			this.addOneWaySimpleButton.TabIndex = 4;
			this.addOneWaySimpleButton.Text = "Add One Way";
			//
			//relatedCustomersGridControl
			//
			this.relatedCustomersGridControl.DataSource = this.relatedCustomerXpCollection;
			this.relatedCustomersGridControl.Location = new System.Drawing.Point(3, 91);
			this.relatedCustomersGridControl.MainView = this.relatedCustomersGridView;
			this.relatedCustomersGridControl.MenuManager = this.BarManager1;
			this.relatedCustomersGridControl.Name = "relatedCustomersGridControl";
			this.relatedCustomersGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {this.deleteRepositoryItemButtonEdit});
			this.relatedCustomersGridControl.Size = new System.Drawing.Size(565, 270);
			this.relatedCustomersGridControl.TabIndex = 0;
			this.relatedCustomersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.relatedCustomersGridView});
			//
			//relatedCustomerXpCollection
			//
			this.relatedCustomerXpCollection.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowRemove;
			this.relatedCustomerXpCollection.DisplayableProperties = "This;Oid;MainCustomer!;MainCustomer!Key;MainCustomer;RelatedCustomer!;RelatedCust"+
		"omer!Key;RelatedCustomer;Bidirectional;RelatedCustomer.CustomerName";
			this.relatedCustomerXpCollection.ObjectType = typeof(DXDAL.SPGData.RelatedCustomer);
			//
			//relatedCustomersGridView
			//
			this.relatedCustomersGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.relatedCustomerNameGridColumn, this.colBidirectional, this.deleteGridColumn, this.idGridColumn});
			this.relatedCustomersGridView.GridControl = this.relatedCustomersGridControl;
			this.relatedCustomersGridView.Name = "relatedCustomersGridView";
			this.relatedCustomersGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
			this.relatedCustomersGridView.OptionsView.ShowDetailButtons = false;
			//
			//relatedCustomerNameGridColumn
			//
			this.relatedCustomerNameGridColumn.Caption = "Related Customer";
			this.relatedCustomerNameGridColumn.FieldName = "RelatedCustomer.CustomerName";
			this.relatedCustomerNameGridColumn.Name = "relatedCustomerNameGridColumn";
			this.relatedCustomerNameGridColumn.OptionsColumn.AllowEdit = false;
			this.relatedCustomerNameGridColumn.OptionsColumn.ReadOnly = true;
			this.relatedCustomerNameGridColumn.Visible = true;
			this.relatedCustomerNameGridColumn.VisibleIndex = 1;
			this.relatedCustomerNameGridColumn.Width = 257;
			//
			//colBidirectional
			//
			this.colBidirectional.Caption = "Both Directions";
			this.colBidirectional.FieldName = "Bidirectional";
			this.colBidirectional.Name = "colBidirectional";
			this.colBidirectional.OptionsColumn.AllowEdit = false;
			this.colBidirectional.Visible = true;
			this.colBidirectional.VisibleIndex = 2;
			this.colBidirectional.Width = 262;
			//
			//deleteGridColumn
			//
			this.deleteGridColumn.ColumnEdit = this.deleteRepositoryItemButtonEdit;
			this.deleteGridColumn.MaxWidth = 25;
			this.deleteGridColumn.Name = "deleteGridColumn";
			this.deleteGridColumn.OptionsColumn.AllowSize = false;
			this.deleteGridColumn.Visible = true;
			this.deleteGridColumn.VisibleIndex = 0;
			this.deleteGridColumn.Width = 25;
			//
			//deleteRepositoryItemButtonEdit
			//
			this.deleteRepositoryItemButtonEdit.AutoHeight = false;
			this.deleteRepositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
			this.deleteRepositoryItemButtonEdit.Name = "deleteRepositoryItemButtonEdit";
			this.deleteRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			//
			//idGridColumn
			//
			this.idGridColumn.Caption = "GridColumn1";
			this.idGridColumn.FieldName = "Oid";
			this.idGridColumn.Name = "idGridColumn";
			//
			//locationsXtraTabPage
			//
			this.locationsXtraTabPage.Controls.Add(this.SplitContainerControl2);
			this.locationsXtraTabPage.Name = "locationsXtraTabPage";
			this.locationsXtraTabPage.Size = new System.Drawing.Size(573, 437);
			this.locationsXtraTabPage.Text = "Plants && Shifts";
			//
			//SplitContainerControl2
			//
			this.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainerControl2.Horizontal = false;
			this.SplitContainerControl2.Location = new System.Drawing.Point(0, 0);
			this.SplitContainerControl2.Name = "SplitContainerControl2";
			this.SplitContainerControl2.Panel1.Controls.Add(this.customerPlantsGridControl);
			this.SplitContainerControl2.Panel1.Text = "Panel1";
			this.SplitContainerControl2.Panel2.Controls.Add(this.customerShiftsGridControl);
			this.SplitContainerControl2.Panel2.Text = "Panel2";
			this.SplitContainerControl2.Size = new System.Drawing.Size(573, 437);
			this.SplitContainerControl2.SplitterPosition = 209;
			this.SplitContainerControl2.TabIndex = 0;
			this.SplitContainerControl2.Text = "SplitContainerControl2";
			//
			//customerPlantsGridControl
			//
			this.customerPlantsGridControl.DataSource = this.customerPlantsXpCollection;
			this.customerPlantsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.customerPlantsGridControl.Location = new System.Drawing.Point(0, 0);
			this.customerPlantsGridControl.MainView = this.customerPlantsGridView;
			this.customerPlantsGridControl.MenuManager = this.BarManager1;
			this.customerPlantsGridControl.Name = "customerPlantsGridControl";
			this.customerPlantsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {this.spgLocationsRepositoryItemLookUpEdit, this.deleteCustomerPlantRepositoryItemButtonEdit});
			this.customerPlantsGridControl.Size = new System.Drawing.Size(573, 209);
			this.customerPlantsGridControl.TabIndex = 0;
			this.customerPlantsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.customerPlantsGridView});
			//
			//customerPlantsXpCollection
			//
			this.customerPlantsXpCollection.ObjectType = typeof(DXDAL.SPGData.CustomerPlants);
			//
			//customerPlantsGridView
			//
			this.customerPlantsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.deleteCustomerPlantGridColumn, this.colOid, this.colHasChanges, this.GridColumn1, this.GridColumn2, this.colPlantName, this.colPlantCode, this.GridColumn3, this.GridColumn4});
			this.customerPlantsGridView.GridControl = this.customerPlantsGridControl;
			this.customerPlantsGridView.Name = "customerPlantsGridView";
			this.customerPlantsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
			this.customerPlantsGridView.OptionsView.ShowDetailButtons = false;
			this.customerPlantsGridView.OptionsView.ShowGroupPanel = false;
			//
			//deleteCustomerPlantGridColumn
			//
			this.deleteCustomerPlantGridColumn.ColumnEdit = this.deleteCustomerPlantRepositoryItemButtonEdit;
			this.deleteCustomerPlantGridColumn.MaxWidth = 25;
			this.deleteCustomerPlantGridColumn.Name = "deleteCustomerPlantGridColumn";
			this.deleteCustomerPlantGridColumn.OptionsColumn.AllowSize = false;
			this.deleteCustomerPlantGridColumn.Visible = true;
			this.deleteCustomerPlantGridColumn.VisibleIndex = 0;
			this.deleteCustomerPlantGridColumn.Width = 25;
			//
			//deleteCustomerPlantRepositoryItemButtonEdit
			//
			this.deleteCustomerPlantRepositoryItemButtonEdit.AutoHeight = false;
			this.deleteCustomerPlantRepositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
			this.deleteCustomerPlantRepositoryItemButtonEdit.Name = "deleteCustomerPlantRepositoryItemButtonEdit";
			this.deleteCustomerPlantRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
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
			this.GridColumn1.FieldName = "Customer!";
			this.GridColumn1.Name = "GridColumn1";
			//
			//GridColumn2
			//
			this.GridColumn2.FieldName = "Customer!Key";
			this.GridColumn2.Name = "GridColumn2";
			//
			//colPlantName
			//
			this.colPlantName.FieldName = "PlantName";
			this.colPlantName.Name = "colPlantName";
			this.colPlantName.Visible = true;
			this.colPlantName.VisibleIndex = 1;
			this.colPlantName.Width = 175;
			//
			//colPlantCode
			//
			this.colPlantCode.FieldName = "PlantCode";
			this.colPlantCode.Name = "colPlantCode";
			this.colPlantCode.Visible = true;
			this.colPlantCode.VisibleIndex = 2;
			this.colPlantCode.Width = 175;
			//
			//GridColumn3
			//
			this.GridColumn3.FieldName = "SPGLocation!";
			this.GridColumn3.Name = "GridColumn3";
			//
			//GridColumn4
			//
			this.GridColumn4.ColumnEdit = this.spgLocationsRepositoryItemLookUpEdit;
			this.GridColumn4.FieldName = "SPGLocation!Key";
			this.GridColumn4.Name = "GridColumn4";
			this.GridColumn4.Visible = true;
			this.GridColumn4.VisibleIndex = 3;
			this.GridColumn4.Width = 180;
			//
			//spgLocationsRepositoryItemLookUpEdit
			//
			this.spgLocationsRepositoryItemLookUpEdit.AutoHeight = false;
			this.spgLocationsRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.spgLocationsRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationID", "Location ID", 77, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationName", "Location Name", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)
			});
			this.spgLocationsRepositoryItemLookUpEdit.DataSource = this.spgLocationsXpView;
			this.spgLocationsRepositoryItemLookUpEdit.DisplayMember = "LocationName";
			this.spgLocationsRepositoryItemLookUpEdit.Name = "spgLocationsRepositoryItemLookUpEdit";
			this.spgLocationsRepositoryItemLookUpEdit.ValueMember = "LocationID";
			//
			//spgLocationsXpView
			//
			this.spgLocationsXpView.ObjectType = typeof(DXDAL.SPGData.Locations);
			this.spgLocationsXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("LocationID", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true),
				new DevExpress.Xpo.ViewProperty("LocationName", DevExpress.Xpo.SortDirection.None, "[LocationName]", false, true)
			});
			//
			//customerShiftsGridControl
			//
			this.customerShiftsGridControl.DataSource = this.customerShiftsXpCollection;
			this.customerShiftsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.customerShiftsGridControl.Location = new System.Drawing.Point(0, 0);
			this.customerShiftsGridControl.MainView = this.customerShiftsGridView;
			this.customerShiftsGridControl.MenuManager = this.BarManager1;
			this.customerShiftsGridControl.Name = "customerShiftsGridControl";
			this.customerShiftsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {this.deleteCustomerShiftRepositoryItemButtonEdit, this.spgShiftRepositoryItemLookUpEdit});
			this.customerShiftsGridControl.Size = new System.Drawing.Size(573, 223);
			this.customerShiftsGridControl.TabIndex = 0;
			this.customerShiftsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.customerShiftsGridView});
			//
			//customerShiftsXpCollection
			//
			this.customerShiftsXpCollection.ObjectType = typeof(DXDAL.SPGData.CustomerShifts);
			//
			//customerShiftsGridView
			//
			this.customerShiftsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.deleteCustomerShiftGridColumn, this.colOid1, this.colHasChanges1, this.GridColumn5, this.GridColumn6, this.colShiftName, this.colShiftCode, this.GridColumn7, this.GridColumn8});
			this.customerShiftsGridView.GridControl = this.customerShiftsGridControl;
			this.customerShiftsGridView.Name = "customerShiftsGridView";
			this.customerShiftsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
			this.customerShiftsGridView.OptionsView.ShowDetailButtons = false;
			this.customerShiftsGridView.OptionsView.ShowGroupPanel = false;
			//
			//deleteCustomerShiftGridColumn
			//
			this.deleteCustomerShiftGridColumn.ColumnEdit = this.deleteCustomerShiftRepositoryItemButtonEdit;
			this.deleteCustomerShiftGridColumn.MaxWidth = 25;
			this.deleteCustomerShiftGridColumn.Name = "deleteCustomerShiftGridColumn";
			this.deleteCustomerShiftGridColumn.OptionsColumn.AllowSize = false;
			this.deleteCustomerShiftGridColumn.Visible = true;
			this.deleteCustomerShiftGridColumn.VisibleIndex = 0;
			this.deleteCustomerShiftGridColumn.Width = 25;
			//
			//deleteCustomerShiftRepositoryItemButtonEdit
			//
			this.deleteCustomerShiftRepositoryItemButtonEdit.AutoHeight = false;
			this.deleteCustomerShiftRepositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
			this.deleteCustomerShiftRepositoryItemButtonEdit.Name = "deleteCustomerShiftRepositoryItemButtonEdit";
			this.deleteCustomerShiftRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			//
			//colOid1
			//
			this.colOid1.FieldName = "Oid";
			this.colOid1.Name = "colOid1";
			this.colOid1.Width = 65;
			//
			//colHasChanges1
			//
			this.colHasChanges1.FieldName = "HasChanges";
			this.colHasChanges1.Name = "colHasChanges1";
			this.colHasChanges1.Width = 65;
			//
			//GridColumn5
			//
			this.GridColumn5.FieldName = "Customer!";
			this.GridColumn5.Name = "GridColumn5";
			this.GridColumn5.Width = 65;
			//
			//GridColumn6
			//
			this.GridColumn6.FieldName = "Customer!Key";
			this.GridColumn6.Name = "GridColumn6";
			this.GridColumn6.Width = 65;
			//
			//colShiftName
			//
			this.colShiftName.FieldName = "ShiftName";
			this.colShiftName.Name = "colShiftName";
			this.colShiftName.Visible = true;
			this.colShiftName.VisibleIndex = 1;
			this.colShiftName.Width = 65;
			//
			//colShiftCode
			//
			this.colShiftCode.FieldName = "ShiftCode";
			this.colShiftCode.Name = "colShiftCode";
			this.colShiftCode.Visible = true;
			this.colShiftCode.VisibleIndex = 2;
			this.colShiftCode.Width = 65;
			//
			//GridColumn7
			//
			this.GridColumn7.FieldName = "SPGShift!";
			this.GridColumn7.Name = "GridColumn7";
			this.GridColumn7.Width = 65;
			//
			//GridColumn8
			//
			this.GridColumn8.ColumnEdit = this.spgShiftRepositoryItemLookUpEdit;
			this.GridColumn8.FieldName = "SPGShift!Key";
			this.GridColumn8.Name = "GridColumn8";
			this.GridColumn8.Visible = true;
			this.GridColumn8.VisibleIndex = 3;
			//
			//spgShiftRepositoryItemLookUpEdit
			//
			this.spgShiftRepositoryItemLookUpEdit.AutoHeight = false;
			this.spgShiftRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.spgShiftRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ShiftID", "Shift ID", 59, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Shift", "Shift", 32, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)
			});
			this.spgShiftRepositoryItemLookUpEdit.DataSource = this.spgShiftsXpView;
			this.spgShiftRepositoryItemLookUpEdit.DisplayMember = "Shift";
			this.spgShiftRepositoryItemLookUpEdit.Name = "spgShiftRepositoryItemLookUpEdit";
			this.spgShiftRepositoryItemLookUpEdit.ValueMember = "ShiftID";
			//
			//spgShiftsXpView
			//
			this.spgShiftsXpView.ObjectType = typeof(DXDAL.SPGData.Shifts);
			this.spgShiftsXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("ShiftID", DevExpress.Xpo.SortDirection.None, "[ShiftID]", false, true),
				new DevExpress.Xpo.ViewProperty("Shift", DevExpress.Xpo.SortDirection.None, "[ShiftName]", false, true)
			});
			//
			//SplitContainerControl1
			//
			this.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainerControl1.Location = new System.Drawing.Point(0, 49);
			this.SplitContainerControl1.Name = "SplitContainerControl1";
			this.SplitContainerControl1.Panel1.Controls.Add(this.inactiveSearchCheckEdit);
			this.SplitContainerControl1.Panel1.Controls.Add(this.customerSearchGridControl);
			this.SplitContainerControl1.Panel1.MinSize = 200;
			this.SplitContainerControl1.Panel1.Text = "Panel1";
			this.SplitContainerControl1.Panel2.Controls.Add(this.customersXtraTabControl);
			this.SplitContainerControl1.Panel2.Text = "Panel2";
			this.SplitContainerControl1.Size = new System.Drawing.Size(784, 465);
			this.SplitContainerControl1.SplitterPosition = 200;
			this.SplitContainerControl1.TabIndex = 6;
			this.SplitContainerControl1.Text = "SplitContainerControl1";
			//
			//inactiveSearchCheckEdit
			//
			this.inactiveSearchCheckEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.inactiveSearchCheckEdit.Location = new System.Drawing.Point(0, 446);
			this.inactiveSearchCheckEdit.Name = "inactiveSearchCheckEdit";
			this.inactiveSearchCheckEdit.Properties.Caption = "Include inactive";
			this.inactiveSearchCheckEdit.Size = new System.Drawing.Size(200, 19);
			this.inactiveSearchCheckEdit.TabIndex = 1;
			//
			//customerSearchGridControl
			//
			this.customerSearchGridControl.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.customerSearchGridControl.DataSource = this.customerSearchXPView;
			this.customerSearchGridControl.Location = new System.Drawing.Point(0, 0);
			this.customerSearchGridControl.MainView = this.customerSearchGridView;
			this.customerSearchGridControl.Name = "customerSearchGridControl";
			this.customerSearchGridControl.Size = new System.Drawing.Size(196, 436);
			this.customerSearchGridControl.TabIndex = 0;
			this.customerSearchGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.customerSearchGridView});
			//
			//customerSearchXPView
			//
			this.customerSearchXPView.ObjectType = typeof(DXDAL.SPGData.Customers);
			this.customerSearchXPView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[CustomerID]", false, true),
				new DevExpress.Xpo.ViewProperty("CustomerName", DevExpress.Xpo.SortDirection.None, "[CustomerName]", false, true),
				new DevExpress.Xpo.ViewProperty("Inactive", DevExpress.Xpo.SortDirection.None, "[Inactive]", false, true)
			});
			//
			//customerSearchGridView
			//
			this.customerSearchGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.customerIDGridColumn, this.nameGridColumn});
			this.customerSearchGridView.GridControl = this.customerSearchGridControl;
			this.customerSearchGridView.Name = "customerSearchGridView";
			this.customerSearchGridView.OptionsBehavior.Editable = false;
			this.customerSearchGridView.OptionsView.ShowAutoFilterRow = true;
			this.customerSearchGridView.OptionsView.ShowGroupPanel = false;
			this.customerSearchGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.nameGridColumn, DevExpress.Data.ColumnSortOrder.Ascending)});
			//
			//customerIDGridColumn
			//
			this.customerIDGridColumn.Caption = "GridColumn1";
			this.customerIDGridColumn.FieldName = "CustomerID";
			this.customerIDGridColumn.Name = "customerIDGridColumn";
			//
			//nameGridColumn
			//
			this.nameGridColumn.Caption = "Name";
			this.nameGridColumn.FieldName = "CustomerName";
			this.nameGridColumn.Name = "nameGridColumn";
			this.nameGridColumn.Visible = true;
			this.nameGridColumn.VisibleIndex = 0;
			//
			//CustomersXtraForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 537);
			this.Controls.Add(this.SplitContainerControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "CustomersXtraForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Customers Manager";
			((System.ComponentModel.ISupportInitialize)this.locationInventoryGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemsGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customerItemsXpCollection).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemsGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customersXtraTabControl).EndInit();
			this.customersXtraTabControl.ResumeLayout(false);
			this.generalXtraTabPage.ResumeLayout(false);
			this.generalXtraTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
			this.GroupControl1.ResumeLayout(false);
			this.GroupControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.lotCodeFormatLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.BarManager1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.lotCodeFormatsXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.expirationDateFormatComboBox.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.lpnGroupControl).EndInit();
			this.lpnGroupControl.ResumeLayout(false);
			this.lpnGroupControl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.plantCodeTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.lastLPNNumberTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.firstLPNNumberTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.lpnPrefixTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.inactiveCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.postalTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.stateTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.cityTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.addressTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.noteMemoEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.faxTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.emailTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.phoneTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.contactTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.nameTextEdit.Properties).EndInit();
			this.itemsXtraTabPage.ResumeLayout(false);
			this.relatedCustomersXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.addRelatedCustomerGroupControl).EndInit();
			this.addRelatedCustomerGroupControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.relatedCustomerLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customersXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.relatedCustomersGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.relatedCustomerXpCollection).EndInit();
			((System.ComponentModel.ISupportInitialize)this.relatedCustomersGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.deleteRepositoryItemButtonEdit).EndInit();
			this.locationsXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.SplitContainerControl2).EndInit();
			this.SplitContainerControl2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.customerPlantsGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customerPlantsXpCollection).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customerPlantsGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.deleteCustomerPlantRepositoryItemButtonEdit).EndInit();
			((System.ComponentModel.ISupportInitialize)this.spgLocationsRepositoryItemLookUpEdit).EndInit();
			((System.ComponentModel.ISupportInitialize)this.spgLocationsXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customerShiftsGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customerShiftsXpCollection).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customerShiftsGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.deleteCustomerShiftRepositoryItemButtonEdit).EndInit();
			((System.ComponentModel.ISupportInitialize)this.spgShiftRepositoryItemLookUpEdit).EndInit();
			((System.ComponentModel.ISupportInitialize)this.spgShiftsXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.SplitContainerControl1).EndInit();
			this.SplitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.inactiveSearchCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customerSearchGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customerSearchXPView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customerSearchGridView).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
		this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(CustomersXtraForm_FormClosing);
		this.Load += new System.EventHandler(CustomersXtraForm_Load);
		customerSearchGridView.Click += new System.EventHandler(customerSearchGridView_Click);
		saveBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(saveBarButtonItem_ItemClick);
		addBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(addBarButtonItem_ItemClick);
		cancelBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(cancelBarButtonItem_ItemClick);
		deleteBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(deleteBarButtonItem_ItemClick);
		deleteCustomerPlantRepositoryItemButtonEdit.Click += new System.EventHandler(deleteCustomerPlantRepositoryItemButtonEdit_Click);
		deleteCustomerShiftRepositoryItemButtonEdit.Click += new System.EventHandler(deleteCustomerShiftRepositoryItemButtonEdit_Click);
		editBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(editBarButtonItem_ItemClick);
		inactiveSearchCheckEdit.CheckedChanged += new System.EventHandler(inactiveSearchCheckEdit_CheckedChanged);
		reportsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(reportsBarButtonItem_ItemClick);
		addOneWaySimpleButton.Click += new System.EventHandler(addOneWaySimpleButton_Click);
		addBothWaysSimpleButton.Click += new System.EventHandler(addBothWaysSimpleButton_Click);
		deleteRepositoryItemButtonEdit.Click += new System.EventHandler(deleteRepositoryItemButtonEdit_Click);
		resetLPNSimpleButton.Click += new System.EventHandler(resetLPNSimpleButton_Click);
	}
		internal DevExpress.XtraTab.XtraTabControl customersXtraTabControl;
		internal DevExpress.XtraTab.XtraTabPage generalXtraTabPage;
		internal DevExpress.XtraTab.XtraTabPage itemsXtraTabPage;
		internal DevExpress.XtraEditors.TextEdit faxTextEdit;
		internal DevExpress.XtraEditors.TextEdit emailTextEdit;
		internal DevExpress.XtraEditors.TextEdit phoneTextEdit;
		internal DevExpress.XtraEditors.TextEdit contactTextEdit;
		internal DevExpress.XtraEditors.TextEdit nameTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl7;
		internal DevExpress.XtraEditors.LabelControl LabelControl5;
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.MemoEdit noteMemoEdit;
		internal DevExpress.XtraGrid.GridControl itemsGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView itemsGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn codeGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn descriptionGridColumn;
		internal DevExpress.XtraEditors.TextEdit postalTextEdit;
		internal DevExpress.XtraEditors.TextEdit stateTextEdit;
		internal DevExpress.XtraEditors.TextEdit cityTextEdit;
		internal DevExpress.XtraEditors.TextEdit addressTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl10;
		internal DevExpress.XtraEditors.LabelControl LabelControl9;
		internal DevExpress.XtraEditors.CheckEdit inactiveCheckEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn onHandGridColumn;
		internal DevExpress.XtraBars.BarManager BarManager1;
		internal DevExpress.XtraBars.Bar customersMenuBar;
		internal DevExpress.XtraBars.BarButtonItem addBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem editBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem deleteBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem cancelBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem saveBarButtonItem;
		internal DevExpress.XtraBars.Bar Bar2;
		internal DevExpress.XtraBars.Bar Bar3;
		internal DevExpress.XtraBars.BarDockControl barDockControlTop;
		internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
		internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
		internal DevExpress.XtraBars.BarDockControl barDockControlRight;
		internal DevExpress.XtraEditors.SplitContainerControl SplitContainerControl1;
		internal DevExpress.XtraEditors.CheckEdit inactiveSearchCheckEdit;
		internal DevExpress.XtraGrid.GridControl customerSearchGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView customerSearchGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn customerIDGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn nameGridColumn;
		internal DevExpress.XtraBars.BarButtonItem reportsBarButtonItem;
		internal DevExpress.Xpo.XPView customerSearchXPView;
		internal DevExpress.XtraTab.XtraTabPage relatedCustomersXtraTabPage;
		internal DevExpress.XtraEditors.GroupControl addRelatedCustomerGroupControl;
		internal DevExpress.XtraEditors.LookUpEdit relatedCustomerLookUpEdit;
		internal DevExpress.XtraEditors.SimpleButton addBothWaysSimpleButton;
		internal DevExpress.XtraEditors.SimpleButton addOneWaySimpleButton;
		internal DevExpress.XtraGrid.GridControl relatedCustomersGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView relatedCustomersGridView;
		internal DevExpress.Xpo.XPCollection relatedCustomerXpCollection;
		internal DevExpress.XtraGrid.Columns.GridColumn relatedCustomerNameGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn colBidirectional;
		internal DevExpress.Xpo.XPView customersXpView;
		internal DevExpress.XtraGrid.Columns.GridColumn deleteGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit deleteRepositoryItemButtonEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn idGridColumn;
		internal DevExpress.XtraEditors.GroupControl lpnGroupControl;
		internal DevExpress.XtraEditors.SimpleButton resetLPNSimpleButton;
		internal DevExpress.XtraEditors.LabelControl plantCodeLabelControl;
		internal DevExpress.XtraEditors.TextEdit plantCodeTextEdit;
		internal DevExpress.XtraEditors.LabelControl lastNumberLabelControl;
		internal DevExpress.XtraEditors.TextEdit lastLPNNumberTextEdit;
		internal DevExpress.XtraEditors.LabelControl firsstNumberLabelControl;
		internal DevExpress.XtraEditors.TextEdit firstLPNNumberTextEdit;
		private DevExpress.XtraEditors.LabelControl lpnPrefixlabelControl;
		internal DevExpress.XtraEditors.TextEdit lpnPrefixTextEdit;
		internal DevExpress.XtraEditors.GroupControl GroupControl1;
		internal DevExpress.XtraEditors.SimpleButton SimpleButton1;
		internal DevExpress.XtraEditors.LabelControl LabelControl6;
		private DevExpress.XtraEditors.LabelControl LabelControl11;
		internal DevExpress.XtraEditors.ComboBoxEdit expirationDateFormatComboBox;
		internal DevExpress.XtraGrid.Columns.GridColumn palletsOnHandGridColumn;
		internal DevExpress.Xpo.XPCollection customerItemsXpCollection;
		internal DevExpress.XtraGrid.Views.Grid.GridView locationInventoryGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn locationCodeGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn locationNameGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn quantityOnHandGridColumn;
		internal DevExpress.XtraTab.XtraTabPage locationsXtraTabPage;
		internal DevExpress.XtraEditors.SplitContainerControl SplitContainerControl2;
		internal DevExpress.XtraGrid.GridControl customerPlantsGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView customerPlantsGridView;
		internal DevExpress.XtraGrid.GridControl customerShiftsGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView customerShiftsGridView;
		internal DevExpress.XtraEditors.LookUpEdit lotCodeFormatLookUpEdit;
		internal DevExpress.Xpo.XPView lotCodeFormatsXpView;
		internal DevExpress.Xpo.XPCollection customerPlantsXpCollection;
		internal DevExpress.XtraGrid.Columns.GridColumn colOid;
		internal DevExpress.XtraGrid.Columns.GridColumn colHasChanges;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn2;
		internal DevExpress.XtraGrid.Columns.GridColumn colPlantName;
		internal DevExpress.XtraGrid.Columns.GridColumn colPlantCode;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn3;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn4;
		internal DevExpress.Xpo.XPView spgLocationsXpView;
		internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit spgLocationsRepositoryItemLookUpEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn deleteCustomerPlantGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit deleteCustomerPlantRepositoryItemButtonEdit;
		internal DevExpress.Xpo.XPCollection customerShiftsXpCollection;
		internal DevExpress.XtraGrid.Columns.GridColumn deleteCustomerShiftGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit deleteCustomerShiftRepositoryItemButtonEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn colOid1;
		internal DevExpress.XtraGrid.Columns.GridColumn colHasChanges1;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn5;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn6;
		internal DevExpress.XtraGrid.Columns.GridColumn colShiftName;
		internal DevExpress.XtraGrid.Columns.GridColumn colShiftCode;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn7;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn8;
		internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit spgShiftRepositoryItemLookUpEdit;
		internal DevExpress.Xpo.XPView spgShiftsXpView;
	}

}