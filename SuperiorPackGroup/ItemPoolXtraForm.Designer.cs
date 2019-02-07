using DXDAL.SPGData;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

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
	public partial class ItemPoolXtraForm : DevExpress.XtraEditors.XtraForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemPoolXtraForm));
			this.BarManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.poolMenuBar = new DevExpress.XtraBars.Bar();
			this.addBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.editBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.deleteBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.cancelBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.saveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.Bar2 = new DevExpress.XtraBars.Bar();
			this.Bar3 = new DevExpress.XtraBars.Bar();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.SplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			this.poolSearchGridControl = new DevExpress.XtraGrid.GridControl();
			this.poolSearchXpView = new DevExpress.Xpo.XPView(this.components);
			this.poolSearchGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colPoolID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPoolCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.poolXtraTabControl = new DevExpress.XtraTab.XtraTabControl();
			this.poolXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.poolDetailsGridControl = new DevExpress.XtraGrid.GridControl();
			this.poolDetailsXpCollection = new DevExpress.Xpo.XPCollection(this.components);
			this.poolDetailsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.deleteGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.deleteRepositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.poolIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.itemGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.itemRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.itemXpView = new DevExpress.Xpo.XPView(this.components);
			this.colItemPoolRatio = new DevExpress.XtraGrid.Columns.GridColumn();
			this.itemQtyOnHandGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.poolQuantityOnHandGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.descriptionMemoEdit = new DevExpress.XtraEditors.MemoEdit();
			this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.customerLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.customerXpView = new DevExpress.Xpo.XPView(this.components);
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.codeTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.typeTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)this.BarManager1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.SplitContainerControl1).BeginInit();
			this.SplitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.poolSearchGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.poolSearchXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.poolSearchGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.poolXtraTabControl).BeginInit();
			this.poolXtraTabControl.SuspendLayout();
			this.poolXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.poolDetailsGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.poolDetailsXpCollection).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.poolDetailsGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.deleteRepositoryItemButtonEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemRepositoryItemLookUpEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.descriptionMemoEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customerLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customerXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.codeTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.typeTextEdit.Properties).BeginInit();
			this.SuspendLayout();
			//
			//BarManager1
			//
			this.BarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.poolMenuBar, this.Bar2, this.Bar3});
			this.BarManager1.DockControls.Add(this.barDockControlTop);
			this.BarManager1.DockControls.Add(this.barDockControlBottom);
			this.BarManager1.DockControls.Add(this.barDockControlLeft);
			this.BarManager1.DockControls.Add(this.barDockControlRight);
			this.BarManager1.Form = this;
			this.BarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.addBarButtonItem, this.editBarButtonItem, this.deleteBarButtonItem, this.cancelBarButtonItem, this.saveBarButtonItem});
			this.BarManager1.MainMenu = this.Bar2;
			this.BarManager1.MaxItemId = 5;
			this.BarManager1.StatusBar = this.Bar3;
			//
			//poolMenuBar
			//
			this.poolMenuBar.BarName = "Tools";
			this.poolMenuBar.DockCol = 0;
			this.poolMenuBar.DockRow = 1;
			this.poolMenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.poolMenuBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.addBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.editBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.deleteBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.cancelBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.saveBarButtonItem)
			});
			this.poolMenuBar.OptionsBar.UseWholeRow = true;
			this.poolMenuBar.Text = "Tools";
			//
			//addBarButtonItem
			//
			this.addBarButtonItem.Caption = "&Add Pool";
			this.addBarButtonItem.Id = 0;
			this.addBarButtonItem.Name = "addBarButtonItem";
			//
			//editBarButtonItem
			//
			this.editBarButtonItem.Caption = "&Edit Pool";
			this.editBarButtonItem.Id = 1;
			this.editBarButtonItem.Name = "editBarButtonItem";
			//
			//deleteBarButtonItem
			//
			this.deleteBarButtonItem.Caption = "Delete Pool";
			this.deleteBarButtonItem.Id = 2;
			this.deleteBarButtonItem.Name = "deleteBarButtonItem";
			//
			//cancelBarButtonItem
			//
			this.cancelBarButtonItem.Caption = "&Cancel Changes";
			this.cancelBarButtonItem.Id = 3;
			this.cancelBarButtonItem.Name = "cancelBarButtonItem";
			//
			//saveBarButtonItem
			//
			this.saveBarButtonItem.Caption = "&Save Changes";
			this.saveBarButtonItem.Id = 4;
			this.saveBarButtonItem.Name = "saveBarButtonItem";
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
			this.barDockControlTop.Size = new System.Drawing.Size(824, 49);
			//
			//barDockControlBottom
			//
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 526);
			this.barDockControlBottom.Size = new System.Drawing.Size(824, 23);
			//
			//barDockControlLeft
			//
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 49);
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 477);
			//
			//barDockControlRight
			//
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(824, 49);
			this.barDockControlRight.Size = new System.Drawing.Size(0, 477);
			//
			//SplitContainerControl1
			//
			this.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainerControl1.Location = new System.Drawing.Point(0, 49);
			this.SplitContainerControl1.Name = "SplitContainerControl1";
			this.SplitContainerControl1.Panel1.Controls.Add(this.poolSearchGridControl);
			this.SplitContainerControl1.Panel1.MinSize = 250;
			this.SplitContainerControl1.Panel1.Text = "Panel1";
			this.SplitContainerControl1.Panel2.Controls.Add(this.poolXtraTabControl);
			this.SplitContainerControl1.Panel2.Text = "Panel2";
			this.SplitContainerControl1.Size = new System.Drawing.Size(824, 477);
			this.SplitContainerControl1.TabIndex = 4;
			this.SplitContainerControl1.Text = "SplitContainerControl1";
			//
			//poolSearchGridControl
			//
			this.poolSearchGridControl.DataSource = this.poolSearchXpView;
			this.poolSearchGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.poolSearchGridControl.Location = new System.Drawing.Point(0, 0);
			this.poolSearchGridControl.MainView = this.poolSearchGridView;
			this.poolSearchGridControl.MenuManager = this.BarManager1;
			this.poolSearchGridControl.Name = "poolSearchGridControl";
			this.poolSearchGridControl.Size = new System.Drawing.Size(250, 477);
			this.poolSearchGridControl.TabIndex = 5;
			this.poolSearchGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.poolSearchGridView});
			//
			//poolSearchXpView
			//
			this.poolSearchXpView.ObjectType = typeof(DXDAL.SPGData.ItemPool);
			this.poolSearchXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("PoolID", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true),
				new DevExpress.Xpo.ViewProperty("PoolCode", DevExpress.Xpo.SortDirection.None, "[PoolCode]", false, true)
			});
			//
			//poolSearchGridView
			//
			this.poolSearchGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colPoolID, this.colPoolCode});
			this.poolSearchGridView.GridControl = this.poolSearchGridControl;
			this.poolSearchGridView.Name = "poolSearchGridView";
			this.poolSearchGridView.OptionsBehavior.Editable = false;
			this.poolSearchGridView.OptionsView.ShowAutoFilterRow = true;
			this.poolSearchGridView.OptionsView.ShowGroupPanel = false;
			//
			//colPoolID
			//
			this.colPoolID.FieldName = "PoolID";
			this.colPoolID.Name = "colPoolID";
			this.colPoolID.OptionsColumn.ReadOnly = true;
			//
			//colPoolCode
			//
			this.colPoolCode.FieldName = "PoolCode";
			this.colPoolCode.Name = "colPoolCode";
			this.colPoolCode.OptionsColumn.ReadOnly = true;
			this.colPoolCode.Visible = true;
			this.colPoolCode.VisibleIndex = 0;
			//
			//poolXtraTabControl
			//
			this.poolXtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.poolXtraTabControl.Location = new System.Drawing.Point(0, 0);
			this.poolXtraTabControl.Name = "poolXtraTabControl";
			this.poolXtraTabControl.SelectedTabPage = this.poolXtraTabPage;
			this.poolXtraTabControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
			this.poolXtraTabControl.Size = new System.Drawing.Size(569, 477);
			this.poolXtraTabControl.TabIndex = 0;
			this.poolXtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {this.poolXtraTabPage});
			//
			//poolXtraTabPage
			//
			this.poolXtraTabPage.Controls.Add(this.poolDetailsGridControl);
			this.poolXtraTabPage.Controls.Add(this.descriptionMemoEdit);
			this.poolXtraTabPage.Controls.Add(this.LabelControl4);
			this.poolXtraTabPage.Controls.Add(this.customerLookUpEdit);
			this.poolXtraTabPage.Controls.Add(this.LabelControl3);
			this.poolXtraTabPage.Controls.Add(this.codeTextEdit);
			this.poolXtraTabPage.Controls.Add(this.LabelControl2);
			this.poolXtraTabPage.Controls.Add(this.typeTextEdit);
			this.poolXtraTabPage.Controls.Add(this.LabelControl1);
			this.poolXtraTabPage.Name = "poolXtraTabPage";
			this.poolXtraTabPage.Size = new System.Drawing.Size(563, 471);
			this.poolXtraTabPage.Text = "XtraTabPage1";
			//
			//poolDetailsGridControl
			//
			this.poolDetailsGridControl.DataSource = this.poolDetailsXpCollection;
			this.poolDetailsGridControl.Location = new System.Drawing.Point(3, 210);
			this.poolDetailsGridControl.MainView = this.poolDetailsGridView;
			this.poolDetailsGridControl.MenuManager = this.BarManager1;
			this.poolDetailsGridControl.Name = "poolDetailsGridControl";
			this.poolDetailsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {this.itemRepositoryItemLookUpEdit, this.deleteRepositoryItemButtonEdit});
			this.poolDetailsGridControl.Size = new System.Drawing.Size(553, 256);
			this.poolDetailsGridControl.TabIndex = 8;
			this.poolDetailsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.poolDetailsGridView});
			//
			//poolDetailsXpCollection
			//
			this.poolDetailsXpCollection.ObjectType = typeof(DXDAL.SPGData.ItemPoolDetails);
			//
			//poolDetailsGridView
			//
			this.poolDetailsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.deleteGridColumn, this.colOid, this.poolIDGridColumn, this.itemGridColumn, this.colItemPoolRatio, this.itemQtyOnHandGridColumn, this.poolQuantityOnHandGridColumn});
			this.poolDetailsGridView.GridControl = this.poolDetailsGridControl;
			this.poolDetailsGridView.Name = "poolDetailsGridView";
			this.poolDetailsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
			this.poolDetailsGridView.OptionsView.ShowDetailButtons = false;
			this.poolDetailsGridView.OptionsView.ShowFooter = true;
			this.poolDetailsGridView.OptionsView.ShowGroupPanel = false;
			//
			//deleteGridColumn
			//
			this.deleteGridColumn.ColumnEdit = this.deleteRepositoryItemButtonEdit;
			this.deleteGridColumn.MaxWidth = 25;
			this.deleteGridColumn.MinWidth = 25;
			this.deleteGridColumn.Name = "deleteGridColumn";
			this.deleteGridColumn.OptionsColumn.AllowSize = false;
			this.deleteGridColumn.OptionsColumn.FixedWidth = true;
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
			//colOid
			//
			this.colOid.FieldName = "Oid";
			this.colOid.Name = "colOid";
			//
			//poolIDGridColumn
			//
			this.poolIDGridColumn.Caption = "Pool ID";
			this.poolIDGridColumn.FieldName = "ItemPoolID";
			this.poolIDGridColumn.Name = "poolIDGridColumn";
			//
			//itemGridColumn
			//
			this.itemGridColumn.Caption = "Item Code";
			this.itemGridColumn.ColumnEdit = this.itemRepositoryItemLookUpEdit;
			this.itemGridColumn.FieldName = "ItemID!Key";
			this.itemGridColumn.Name = "itemGridColumn";
			this.itemGridColumn.Visible = true;
			this.itemGridColumn.VisibleIndex = 1;
			this.itemGridColumn.Width = 165;
			//
			//itemRepositoryItemLookUpEdit
			//
			this.itemRepositoryItemLookUpEdit.AutoHeight = false;
			this.itemRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.itemRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 59, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)
			});
			this.itemRepositoryItemLookUpEdit.DataSource = this.itemXpView;
			this.itemRepositoryItemLookUpEdit.DisplayMember = "ItemCode";
			this.itemRepositoryItemLookUpEdit.Name = "itemRepositoryItemLookUpEdit";
			this.itemRepositoryItemLookUpEdit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
			this.itemRepositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.itemRepositoryItemLookUpEdit.ValueMember = "ItemID";
			//
			//itemXpView
			//
			this.itemXpView.ObjectType = typeof(DXDAL.SPGData.Items);
			this.itemXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[ItemID]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[ItemCode]", false, true)
			});
			//
			//colItemPoolRatio
			//
			this.colItemPoolRatio.FieldName = "ItemPoolRatio";
			this.colItemPoolRatio.Name = "colItemPoolRatio";
			this.colItemPoolRatio.Visible = true;
			this.colItemPoolRatio.VisibleIndex = 2;
			this.colItemPoolRatio.Width = 84;
			//
			//itemQtyOnHandGridColumn
			//
			this.itemQtyOnHandGridColumn.Caption = "Item Quantity On Hand";
			this.itemQtyOnHandGridColumn.DisplayFormat.FormatString = "{0:#,##0.####}";
			this.itemQtyOnHandGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.itemQtyOnHandGridColumn.FieldName = "ItemID.sngQuantityOnHand";
			this.itemQtyOnHandGridColumn.Name = "itemQtyOnHandGridColumn";
			this.itemQtyOnHandGridColumn.OptionsColumn.AllowEdit = false;
			this.itemQtyOnHandGridColumn.Visible = true;
			this.itemQtyOnHandGridColumn.VisibleIndex = 3;
			this.itemQtyOnHandGridColumn.Width = 122;
			//
			//poolQuantityOnHandGridColumn
			//
			this.poolQuantityOnHandGridColumn.Caption = "Pool Quantity On Hand";
			this.poolQuantityOnHandGridColumn.DisplayFormat.FormatString = "{0:#,##0.####}";
			this.poolQuantityOnHandGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.poolQuantityOnHandGridColumn.FieldName = "QuantityOnHand";
			this.poolQuantityOnHandGridColumn.Name = "poolQuantityOnHandGridColumn";
			this.poolQuantityOnHandGridColumn.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "QuantityOnHand", "{0:#,##0.####}")});
			this.poolQuantityOnHandGridColumn.Visible = true;
			this.poolQuantityOnHandGridColumn.VisibleIndex = 4;
			this.poolQuantityOnHandGridColumn.Width = 139;
			//
			//descriptionMemoEdit
			//
			this.descriptionMemoEdit.Location = new System.Drawing.Point(122, 77);
			this.descriptionMemoEdit.MenuManager = this.BarManager1;
			this.descriptionMemoEdit.Name = "descriptionMemoEdit";
			this.descriptionMemoEdit.Size = new System.Drawing.Size(381, 96);
			this.descriptionMemoEdit.TabIndex = 7;
			//
			//LabelControl4
			//
			this.LabelControl4.Location = new System.Drawing.Point(59, 80);
			this.LabelControl4.Name = "LabelControl4";
			this.LabelControl4.Size = new System.Drawing.Size(57, 13);
			this.LabelControl4.TabIndex = 6;
			this.LabelControl4.Text = "Description:";
			//
			//customerLookUpEdit
			//
			this.customerLookUpEdit.Location = new System.Drawing.Point(122, 51);
			this.customerLookUpEdit.MenuManager = this.BarManager1;
			this.customerLookUpEdit.Name = "customerLookUpEdit";
			this.customerLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.customerLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerID", "Customer ID", 83, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Customer Name", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Inactive", "Inactive", 49, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)
			});
			this.customerLookUpEdit.Properties.DataSource = this.customerXpView;
			this.customerLookUpEdit.Properties.DisplayMember = "CustomerName";
			this.customerLookUpEdit.Properties.NullText = "[Select A Customer]";
			this.customerLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.customerLookUpEdit.Properties.ValueMember = "CustomerID";
			this.customerLookUpEdit.Size = new System.Drawing.Size(381, 20);
			this.customerLookUpEdit.TabIndex = 5;
			//
			//customerXpView
			//
			this.customerXpView.CriteriaString = "[Inactive] = False";
			this.customerXpView.ObjectType = typeof(DXDAL.SPGData.Customers);
			this.customerXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[CustomerID]", false, true),
				new DevExpress.Xpo.ViewProperty("CustomerName", DevExpress.Xpo.SortDirection.None, "[CustomerName]", false, true),
				new DevExpress.Xpo.ViewProperty("Inactive", DevExpress.Xpo.SortDirection.None, "[Inactive]", false, true)
			});
			//
			//LabelControl3
			//
			this.LabelControl3.Location = new System.Drawing.Point(59, 54);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(50, 13);
			this.LabelControl3.TabIndex = 4;
			this.LabelControl3.Text = "Customer:";
			//
			//codeTextEdit
			//
			this.codeTextEdit.Location = new System.Drawing.Point(353, 20);
			this.codeTextEdit.MenuManager = this.BarManager1;
			this.codeTextEdit.Name = "codeTextEdit";
			this.codeTextEdit.Properties.NullText = "[Enter Pool Code]";
			this.codeTextEdit.Size = new System.Drawing.Size(150, 20);
			this.codeTextEdit.TabIndex = 3;
			//
			//LabelControl2
			//
			this.LabelControl2.Location = new System.Drawing.Point(295, 23);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(52, 13);
			this.LabelControl2.TabIndex = 2;
			this.LabelControl2.Text = "Pool Code:";
			//
			//typeTextEdit
			//
			this.typeTextEdit.EditValue = "BOM Pool";
			this.typeTextEdit.Enabled = false;
			this.typeTextEdit.Location = new System.Drawing.Point(122, 20);
			this.typeTextEdit.MenuManager = this.BarManager1;
			this.typeTextEdit.Name = "typeTextEdit";
			this.typeTextEdit.Properties.ReadOnly = true;
			this.typeTextEdit.Size = new System.Drawing.Size(150, 20);
			this.typeTextEdit.TabIndex = 1;
			//
			//LabelControl1
			//
			this.LabelControl1.Location = new System.Drawing.Point(59, 23);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(28, 13);
			this.LabelControl1.TabIndex = 0;
			this.LabelControl1.Text = "Type:";
			//
			//ItemPoolXtraForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(824, 549);
			this.Controls.Add(this.SplitContainerControl1);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "ItemPoolXtraForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Item Pool";
			((System.ComponentModel.ISupportInitialize)this.BarManager1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.SplitContainerControl1).EndInit();
			this.SplitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.poolSearchGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.poolSearchXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.poolSearchGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.poolXtraTabControl).EndInit();
			this.poolXtraTabControl.ResumeLayout(false);
			this.poolXtraTabPage.ResumeLayout(false);
			this.poolXtraTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.poolDetailsGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.poolDetailsXpCollection).EndInit();
			((System.ComponentModel.ISupportInitialize)this.poolDetailsGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.deleteRepositoryItemButtonEdit).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemRepositoryItemLookUpEdit).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.descriptionMemoEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customerLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customerXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.codeTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.typeTextEdit.Properties).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
		addBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(addBarButtonItem_ItemClick);
		cancelBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(cancelBarButtonItem_ItemClick);
		customerLookUpEdit.EditValueChanged += new System.EventHandler(customerLookUpEdit_EditValueChanged);
		deleteBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(deleteBarButtonItem_ItemClick);
		deleteRepositoryItemButtonEdit.Click += new System.EventHandler(deleteRepositoryItemButtonEdit_Click);
		editBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(editBarButtonItem_ItemClick);
		this.Activated += new System.EventHandler(ItemPoolXtraForm_Activated);
		base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(ItemPoolXtraForm_FormClosing);
		this.Load += new System.EventHandler(ItemPoolXtraForm_Load);
		itemRepositoryItemLookUpEdit.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(itemRepositoryItemLookUpEdit_Closed);
		poolDetailsGridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(poolDetailsGridView_CustomUnboundColumnData);
		poolDetailsGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(poolDetailsGridView_InitNewRow);
		poolSearchGridView.Click += new System.EventHandler(poolSearchGridView_Click);
		saveBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(saveBarButtonItem_ItemClick);
	}
		internal DevExpress.XtraBars.BarManager BarManager1;
		internal DevExpress.XtraBars.Bar poolMenuBar;
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
		internal DevExpress.XtraEditors.SplitContainerControl SplitContainerControl1;
		internal DevExpress.XtraTab.XtraTabControl poolXtraTabControl;
		internal DevExpress.XtraTab.XtraTabPage poolXtraTabPage;
		internal DevExpress.XtraGrid.GridControl poolSearchGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView poolSearchGridView;
		internal DevExpress.Xpo.XPView poolSearchXpView;
		internal DevExpress.XtraGrid.Columns.GridColumn colPoolID;
		internal DevExpress.XtraGrid.Columns.GridColumn colPoolCode;
		internal DevExpress.XtraEditors.TextEdit typeTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.TextEdit codeTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraEditors.LookUpEdit customerLookUpEdit;
		internal DevExpress.Xpo.XPView customerXpView;
		internal DevExpress.XtraGrid.GridControl poolDetailsGridControl;
		internal DevExpress.Xpo.XPCollection poolDetailsXpCollection;
		internal DevExpress.XtraGrid.Views.Grid.GridView poolDetailsGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn colOid;
		internal DevExpress.XtraGrid.Columns.GridColumn poolIDGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn itemGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit itemRepositoryItemLookUpEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn colItemPoolRatio;
		internal DevExpress.XtraEditors.MemoEdit descriptionMemoEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		internal DevExpress.XtraGrid.Columns.GridColumn deleteGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit deleteRepositoryItemButtonEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn itemQtyOnHandGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn poolQuantityOnHandGridColumn;
		internal DevExpress.Xpo.XPView itemXpView;
	}

}