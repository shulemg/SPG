using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DXDAL.SPGData;

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
	public partial class SecurityXtraForm : DevExpress.XtraEditors.XtraForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecurityXtraForm));
			this.sidePanelControl = new DevExpress.XtraEditors.PanelControl();
			this.usersListBoxControl = new DevExpress.XtraEditors.ListBoxControl();
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.confirmTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.passwordTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.userPermissionsGridControl = new DevExpress.XtraGrid.GridControl();
			this.userPermissionsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.permissionObjectGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.permissionLevelGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.permissionsRepositoryItemComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
			this.userNaemGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.permissionIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.BarManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.usersMenuBar = new DevExpress.XtraBars.Bar();
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
			this.securityXtraTabControl = new DevExpress.XtraTab.XtraTabControl();
			this.permissionsXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.customersXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.customersGridControl = new DevExpress.XtraGrid.GridControl();
			this.customersXPCollection = new DevExpress.Xpo.XPCollection(this.components);
			this.customersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.userNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.customerIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.customerRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.customersXPView = new DevExpress.Xpo.XPView(this.components);
			this.locationLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.locationsXpView = new DevExpress.Xpo.XPView(this.components);
			this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.resetSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.LPNPrinterTextEdit = new DevExpress.XtraEditors.TextEdit();
			((System.ComponentModel.ISupportInitialize)this.sidePanelControl).BeginInit();
			this.sidePanelControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.usersListBoxControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.nameTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.confirmTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.passwordTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.userPermissionsGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.userPermissionsGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.permissionsRepositoryItemComboBox).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.BarManager1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.securityXtraTabControl).BeginInit();
			this.securityXtraTabControl.SuspendLayout();
			this.permissionsXtraTabPage.SuspendLayout();
			this.customersXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.customersGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customersXPCollection).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customersGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customerRepositoryItemLookUpEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customersXPView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.locationLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.locationsXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.LPNPrinterTextEdit.Properties).BeginInit();
			this.SuspendLayout();
			//
			//sidePanelControl
			//
			this.sidePanelControl.Controls.Add(this.usersListBoxControl);
			this.sidePanelControl.Dock = System.Windows.Forms.DockStyle.Left;
			this.sidePanelControl.Location = new System.Drawing.Point(0, 49);
			this.sidePanelControl.Name = "sidePanelControl";
			this.sidePanelControl.Size = new System.Drawing.Size(145, 444);
			this.sidePanelControl.TabIndex = 0;
			//
			//usersListBoxControl
			//
			this.usersListBoxControl.Location = new System.Drawing.Point(5, 6);
			this.usersListBoxControl.Name = "usersListBoxControl";
			this.usersListBoxControl.Size = new System.Drawing.Size(135, 432);
			this.usersListBoxControl.TabIndex = 4;
			//
			//LabelControl1
			//
			this.LabelControl1.Location = new System.Drawing.Point(168, 60);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(56, 13);
			this.LabelControl1.TabIndex = 1;
			this.LabelControl1.Text = "User Name:";
			//
			//nameTextEdit
			//
			this.nameTextEdit.Location = new System.Drawing.Point(260, 57);
			this.nameTextEdit.Name = "nameTextEdit";
			this.nameTextEdit.Size = new System.Drawing.Size(140, 20);
			this.nameTextEdit.TabIndex = 2;
			//
			//confirmTextEdit
			//
			this.confirmTextEdit.Location = new System.Drawing.Point(260, 107);
			this.confirmTextEdit.Name = "confirmTextEdit";
			this.confirmTextEdit.Properties.PasswordChar = (char)42;
			this.confirmTextEdit.Size = new System.Drawing.Size(140, 20);
			this.confirmTextEdit.TabIndex = 6;
			//
			//passwordTextEdit
			//
			this.passwordTextEdit.Location = new System.Drawing.Point(260, 82);
			this.passwordTextEdit.Name = "passwordTextEdit";
			this.passwordTextEdit.Properties.PasswordChar = (char)42;
			this.passwordTextEdit.Size = new System.Drawing.Size(140, 20);
			this.passwordTextEdit.TabIndex = 4;
			//
			//LabelControl2
			//
			this.LabelControl2.Location = new System.Drawing.Point(168, 110);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(86, 13);
			this.LabelControl2.TabIndex = 5;
			this.LabelControl2.Text = "Confirm Password";
			//
			//LabelControl3
			//
			this.LabelControl3.Location = new System.Drawing.Point(168, 85);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(50, 13);
			this.LabelControl3.TabIndex = 3;
			this.LabelControl3.Text = "Password:";
			//
			//userPermissionsGridControl
			//
			this.userPermissionsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.userPermissionsGridControl.Location = new System.Drawing.Point(0, 0);
			this.userPermissionsGridControl.MainView = this.userPermissionsGridView;
			this.userPermissionsGridControl.Name = "userPermissionsGridControl";
			this.userPermissionsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {this.permissionsRepositoryItemComboBox});
			this.userPermissionsGridControl.Size = new System.Drawing.Size(258, 234);
			this.userPermissionsGridControl.TabIndex = 8;
			this.userPermissionsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.userPermissionsGridView});
			//
			//userPermissionsGridView
			//
			this.userPermissionsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.permissionObjectGridColumn, this.permissionLevelGridColumn, this.userNaemGridColumn, this.permissionIDGridColumn});
			this.userPermissionsGridView.GridControl = this.userPermissionsGridControl;
			this.userPermissionsGridView.Name = "userPermissionsGridView";
			this.userPermissionsGridView.OptionsSelection.MultiSelect = true;
			this.userPermissionsGridView.OptionsView.ShowGroupPanel = false;
			//
			//permissionObjectGridColumn
			//
			this.permissionObjectGridColumn.Caption = "Object";
			this.permissionObjectGridColumn.Name = "permissionObjectGridColumn";
			this.permissionObjectGridColumn.OptionsColumn.AllowEdit = false;
			this.permissionObjectGridColumn.Visible = true;
			this.permissionObjectGridColumn.VisibleIndex = 0;
			//
			//permissionLevelGridColumn
			//
			this.permissionLevelGridColumn.Caption = "Permission";
			this.permissionLevelGridColumn.ColumnEdit = this.permissionsRepositoryItemComboBox;
			this.permissionLevelGridColumn.Name = "permissionLevelGridColumn";
			this.permissionLevelGridColumn.Visible = true;
			this.permissionLevelGridColumn.VisibleIndex = 1;
			//
			//permissionsRepositoryItemComboBox
			//
			this.permissionsRepositoryItemComboBox.AutoHeight = false;
			this.permissionsRepositoryItemComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.permissionsRepositoryItemComboBox.Items.AddRange(new object[] {"NONE", "VIEW", "EDIT", "ADD", "FULL", "VIEW ASSIGNED", "EDIT ASSIGNED"});
			this.permissionsRepositoryItemComboBox.Name = "permissionsRepositoryItemComboBox";
			//
			//userNaemGridColumn
			//
			this.userNaemGridColumn.Caption = "GridColumn1";
			this.userNaemGridColumn.Name = "userNaemGridColumn";
			this.userNaemGridColumn.OptionsColumn.AllowEdit = false;
			//
			//permissionIDGridColumn
			//
			this.permissionIDGridColumn.Caption = "GridColumn1";
			this.permissionIDGridColumn.Name = "permissionIDGridColumn";
			this.permissionIDGridColumn.OptionsColumn.AllowEdit = false;
			//
			//BarManager1
			//
			this.BarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.usersMenuBar, this.Bar2, this.Bar3});
			this.BarManager1.DockControls.Add(this.barDockControlTop);
			this.BarManager1.DockControls.Add(this.barDockControlBottom);
			this.BarManager1.DockControls.Add(this.barDockControlLeft);
			this.BarManager1.DockControls.Add(this.barDockControlRight);
			this.BarManager1.Form = this;
			this.BarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.addBarButtonItem, this.cancelBarButtonItem, this.saveBarButtonItem, this.deleteBarButtonItem, this.editBarButtonItem});
			this.BarManager1.MainMenu = this.Bar2;
			this.BarManager1.MaxItemId = 5;
			this.BarManager1.StatusBar = this.Bar3;
			//
			//usersMenuBar
			//
			this.usersMenuBar.BarName = "Tools";
			this.usersMenuBar.DockCol = 0;
			this.usersMenuBar.DockRow = 1;
			this.usersMenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.usersMenuBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.addBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.editBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.deleteBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.cancelBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.saveBarButtonItem)
			});
			this.usersMenuBar.OptionsBar.UseWholeRow = true;
			this.usersMenuBar.Text = "Tools";
			//
			//addBarButtonItem
			//
			this.addBarButtonItem.Caption = "&Add User";
			this.addBarButtonItem.Id = 0;
			this.addBarButtonItem.Name = "addBarButtonItem";
			//
			//editBarButtonItem
			//
			this.editBarButtonItem.Caption = "&Edit User";
			this.editBarButtonItem.Id = 4;
			this.editBarButtonItem.Name = "editBarButtonItem";
			//
			//deleteBarButtonItem
			//
			this.deleteBarButtonItem.Caption = "Delete User";
			this.deleteBarButtonItem.Id = 3;
			this.deleteBarButtonItem.Name = "deleteBarButtonItem";
			//
			//cancelBarButtonItem
			//
			this.cancelBarButtonItem.Caption = "&Cancel Changes";
			this.cancelBarButtonItem.Enabled = false;
			this.cancelBarButtonItem.Id = 1;
			this.cancelBarButtonItem.Name = "cancelBarButtonItem";
			//
			//saveBarButtonItem
			//
			this.saveBarButtonItem.Caption = "&Save Changes";
			this.saveBarButtonItem.Enabled = false;
			this.saveBarButtonItem.Id = 2;
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
			this.barDockControlTop.Size = new System.Drawing.Size(427, 49);
			//
			//barDockControlBottom
			//
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 493);
			this.barDockControlBottom.Manager = this.BarManager1;
			this.barDockControlBottom.Size = new System.Drawing.Size(427, 23);
			//
			//barDockControlLeft
			//
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 49);
			this.barDockControlLeft.Manager = this.BarManager1;
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 444);
			//
			//barDockControlRight
			//
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(427, 49);
			this.barDockControlRight.Manager = this.BarManager1;
			this.barDockControlRight.Size = new System.Drawing.Size(0, 444);
			//
			//securityXtraTabControl
			//
			this.securityXtraTabControl.Location = new System.Drawing.Point(151, 223);
			this.securityXtraTabControl.Name = "securityXtraTabControl";
			this.securityXtraTabControl.SelectedTabPage = this.permissionsXtraTabPage;
			this.securityXtraTabControl.Size = new System.Drawing.Size(264, 262);
			this.securityXtraTabControl.TabIndex = 9;
			this.securityXtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {this.permissionsXtraTabPage, this.customersXtraTabPage});
			//
			//permissionsXtraTabPage
			//
			this.permissionsXtraTabPage.Controls.Add(this.userPermissionsGridControl);
			this.permissionsXtraTabPage.Name = "permissionsXtraTabPage";
			this.permissionsXtraTabPage.Size = new System.Drawing.Size(258, 234);
			this.permissionsXtraTabPage.Text = "Permissions";
			//
			//customersXtraTabPage
			//
			this.customersXtraTabPage.Controls.Add(this.customersGridControl);
			this.customersXtraTabPage.Name = "customersXtraTabPage";
			this.customersXtraTabPage.Size = new System.Drawing.Size(258, 234);
			this.customersXtraTabPage.Text = "Customers";
			//
			//customersGridControl
			//
			this.customersGridControl.DataSource = this.customersXPCollection;
			this.customersGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.customersGridControl.Location = new System.Drawing.Point(0, 0);
			this.customersGridControl.MainView = this.customersGridView;
			this.customersGridControl.MenuManager = this.BarManager1;
			this.customersGridControl.Name = "customersGridControl";
			this.customersGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {this.customerRepositoryItemLookUpEdit});
			this.customersGridControl.Size = new System.Drawing.Size(258, 234);
			this.customersGridControl.TabIndex = 0;
			this.customersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.customersGridView});
			//
			//customersXPCollection
			//
			this.customersXPCollection.ObjectType = typeof(DXDAL.SPGData.UsersCustomer);
			//
			//customersGridView
			//
			this.customersGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colOid, this.GridColumn1, this.userNameGridColumn, this.GridColumn3, this.customerIDGridColumn});
			this.customersGridView.GridControl = this.customersGridControl;
			this.customersGridView.Name = "customersGridView";
			this.customersGridView.OptionsDetail.EnableMasterViewMode = false;
			this.customersGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
			this.customersGridView.OptionsView.ShowGroupPanel = false;
			//
			//colOid
			//
			this.colOid.FieldName = "Oid";
			this.colOid.Name = "colOid";
			//
			//GridColumn1
			//
			this.GridColumn1.FieldName = "User!";
			this.GridColumn1.Name = "GridColumn1";
			//
			//userNameGridColumn
			//
			this.userNameGridColumn.FieldName = "User!Key";
			this.userNameGridColumn.Name = "userNameGridColumn";
			//
			//GridColumn3
			//
			this.GridColumn3.FieldName = "Customer!";
			this.GridColumn3.Name = "GridColumn3";
			//
			//customerIDGridColumn
			//
			this.customerIDGridColumn.ColumnEdit = this.customerRepositoryItemLookUpEdit;
			this.customerIDGridColumn.FieldName = "Customer!Key";
			this.customerIDGridColumn.Name = "customerIDGridColumn";
			this.customerIDGridColumn.Visible = true;
			this.customerIDGridColumn.VisibleIndex = 0;
			//
			//customerRepositoryItemLookUpEdit
			//
			this.customerRepositoryItemLookUpEdit.AutoHeight = false;
			this.customerRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.customerRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerID", "Customer ID", 83, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Customer Name", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)
			});
			this.customerRepositoryItemLookUpEdit.DataSource = this.customersXPView;
			this.customerRepositoryItemLookUpEdit.DisplayMember = "CustomerName";
			this.customerRepositoryItemLookUpEdit.Name = "customerRepositoryItemLookUpEdit";
			this.customerRepositoryItemLookUpEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.customerRepositoryItemLookUpEdit.ValueMember = "CustomerID";
			//
			//customersXPView
			//
			this.customersXPView.ObjectType = typeof(DXDAL.SPGData.Customers);
			this.customersXPView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[CustomerID]", false, true),
				new DevExpress.Xpo.ViewProperty("CustomerName", DevExpress.Xpo.SortDirection.None, "[CustomerName]", false, true)
			});
			//
			//locationLookUpEdit
			//
			this.locationLookUpEdit.Location = new System.Drawing.Point(260, 159);
			this.locationLookUpEdit.MenuManager = this.BarManager1;
			this.locationLookUpEdit.Name = "locationLookUpEdit";
			this.locationLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.locationLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationCode", "Location Code", 91, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationName", "Location Name", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationID", "location", 47, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)
			});
			this.locationLookUpEdit.Properties.DataSource = this.locationsXpView;
			this.locationLookUpEdit.Properties.DisplayMember = "LocationCode";
			this.locationLookUpEdit.Properties.NullText = "[Select default location]";
			this.locationLookUpEdit.Properties.ValueMember = "LocationID";
			this.locationLookUpEdit.Size = new System.Drawing.Size(140, 20);
			this.locationLookUpEdit.TabIndex = 14;
			//
			//locationsXpView
			//
			this.locationsXpView.ObjectType = typeof(DXDAL.SPGData.Locations);
			this.locationsXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("LocationCode", DevExpress.Xpo.SortDirection.None, "[LocationCode]", false, true),
				new DevExpress.Xpo.ViewProperty("LocationName", DevExpress.Xpo.SortDirection.None, "[LocationName]", false, true),
				new DevExpress.Xpo.ViewProperty("LocationID", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true)
			});
			//
			//LabelControl4
			//
			this.LabelControl4.Location = new System.Drawing.Point(168, 162);
			this.LabelControl4.Name = "LabelControl4";
			this.LabelControl4.Size = new System.Drawing.Size(78, 13);
			this.LabelControl4.TabIndex = 15;
			this.LabelControl4.Text = "Default Location";
			//
			//resetSimpleButton
			//
			this.resetSimpleButton.Location = new System.Drawing.Point(260, 184);
			this.resetSimpleButton.Name = "resetSimpleButton";
			this.resetSimpleButton.Size = new System.Drawing.Size(100, 23);
			this.resetSimpleButton.TabIndex = 20;
			this.resetSimpleButton.Text = "Reset Permissions";
			//
			//LabelControl5
			//
			this.LabelControl5.Location = new System.Drawing.Point(168, 136);
			this.LabelControl5.Name = "LabelControl5";
			this.LabelControl5.Size = new System.Drawing.Size(53, 13);
			this.LabelControl5.TabIndex = 25;
			this.LabelControl5.Text = "LPN Printer";
			//
			//LPNPrinterTextEdit
			//
			this.LPNPrinterTextEdit.Location = new System.Drawing.Point(260, 133);
			this.LPNPrinterTextEdit.Name = "LPNPrinterTextEdit";
			this.LPNPrinterTextEdit.Size = new System.Drawing.Size(140, 20);
			this.LPNPrinterTextEdit.TabIndex = 26;
			//
			//SecurityXtraForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(427, 516);
			this.Controls.Add(this.LabelControl5);
			this.Controls.Add(this.LPNPrinterTextEdit);
			this.Controls.Add(this.resetSimpleButton);
			this.Controls.Add(this.LabelControl4);
			this.Controls.Add(this.locationLookUpEdit);
			this.Controls.Add(this.securityXtraTabControl);
			this.Controls.Add(this.LabelControl3);
			this.Controls.Add(this.LabelControl2);
			this.Controls.Add(this.passwordTextEdit);
			this.Controls.Add(this.confirmTextEdit);
			this.Controls.Add(this.nameTextEdit);
			this.Controls.Add(this.LabelControl1);
			this.Controls.Add(this.sidePanelControl);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "SecurityXtraForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Security";
			((System.ComponentModel.ISupportInitialize)this.sidePanelControl).EndInit();
			this.sidePanelControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.usersListBoxControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.nameTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.confirmTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.passwordTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.userPermissionsGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.userPermissionsGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.permissionsRepositoryItemComboBox).EndInit();
			((System.ComponentModel.ISupportInitialize)this.BarManager1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.securityXtraTabControl).EndInit();
			this.securityXtraTabControl.ResumeLayout(false);
			this.permissionsXtraTabPage.ResumeLayout(false);
			this.customersXtraTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.customersGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customersXPCollection).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customersGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customerRepositoryItemLookUpEdit).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customersXPView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.locationLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.locationsXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.LPNPrinterTextEdit.Properties).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(SecurityXtraForm_FormClosing);
			base.Load += new System.EventHandler(SecurityXtraForm_Load);
			usersListBoxControl.SelectedValueChanged += new System.EventHandler(usersListBoxControl_SelectedValueChanged);
			saveBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(saveBarButtonItem_ItemClick);
			addBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(addBarButtonItem_ItemClick);
			cancelBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(cancelBarButtonItem_ItemClick);
			deleteBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(deleteBarButtonItem_ItemClick);
			permissionsRepositoryItemComboBox.EditValueChanged += new System.EventHandler(PermissionsRepositoryItemComboBox_EditValueChanged);
			editBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(editBarButtonItem_ItemClick);
			userPermissionsGridView.ShowingEditor += new System.ComponentModel.CancelEventHandler(userPermissionsGridView_ShowingEditor);
			customersGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(customersGridView_InitNewRow);
			customersXPCollection.ResolveSession += new DevExpress.Xpo.ResolveSessionEventHandler(customersXPCollection_ResolveSession);
			customerRepositoryItemLookUpEdit.Closed += new DevExpress.XtraEditors.Controls.ClosedEventHandler(customerRepositoryItemLookUpEdit_Closed);
			resetSimpleButton.Click += new System.EventHandler(resetSimpleButton_Click);
		}
		internal DevExpress.XtraEditors.PanelControl sidePanelControl;
		internal DevExpress.XtraEditors.ListBoxControl usersListBoxControl;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.TextEdit nameTextEdit;
		internal DevExpress.XtraEditors.TextEdit confirmTextEdit;
		internal DevExpress.XtraEditors.TextEdit passwordTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraGrid.GridControl userPermissionsGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView userPermissionsGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn permissionObjectGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn permissionLevelGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn userNaemGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemComboBox permissionsRepositoryItemComboBox;
		internal DevExpress.XtraBars.BarManager BarManager1;
		internal DevExpress.XtraBars.Bar usersMenuBar;
		internal DevExpress.XtraBars.Bar Bar2;
		internal DevExpress.XtraBars.Bar Bar3;
		internal DevExpress.XtraBars.BarDockControl barDockControlTop;
		internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
		internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
		internal DevExpress.XtraBars.BarDockControl barDockControlRight;
		internal DevExpress.XtraBars.BarButtonItem addBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem cancelBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem saveBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem deleteBarButtonItem;
		internal DevExpress.XtraGrid.Columns.GridColumn permissionIDGridColumn;
		internal DevExpress.XtraBars.BarButtonItem editBarButtonItem;
		internal DevExpress.XtraTab.XtraTabControl securityXtraTabControl;
		internal DevExpress.XtraTab.XtraTabPage permissionsXtraTabPage;
		internal DevExpress.XtraTab.XtraTabPage customersXtraTabPage;
		internal DevExpress.XtraGrid.GridControl customersGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView customersGridView;
		internal DevExpress.Xpo.XPCollection customersXPCollection;
		internal DevExpress.XtraGrid.Columns.GridColumn colOid;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
		internal DevExpress.XtraGrid.Columns.GridColumn userNameGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn3;
		internal DevExpress.XtraGrid.Columns.GridColumn customerIDGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit customerRepositoryItemLookUpEdit;
		internal DevExpress.Xpo.XPView customersXPView;
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		internal DevExpress.XtraEditors.LookUpEdit locationLookUpEdit;
		internal DevExpress.Xpo.XPView locationsXpView;
		internal DevExpress.XtraEditors.SimpleButton resetSimpleButton;
		internal DevExpress.XtraEditors.LabelControl LabelControl5;
		internal DevExpress.XtraEditors.TextEdit LPNPrinterTextEdit;
	}

}