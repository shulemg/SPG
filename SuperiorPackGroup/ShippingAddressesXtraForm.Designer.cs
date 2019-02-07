using DevExpress.XtraGrid.Views.Grid.ViewInfo;

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
	public partial class ShippingAddressesXtraForm : DevExpress.XtraEditors.XtraForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShippingAddressesXtraForm));
			this.BarManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.shippingDestinationsMenuBar = new DevExpress.XtraBars.Bar();
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
			this.ShippingDestinationsSplitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
			this.destinationsSearchGridControl = new DevExpress.XtraGrid.GridControl();
			this.destinationsSearchGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.destinationIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.destinationsGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.destinationsPanelControl = new DevExpress.XtraEditors.PanelControl();
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.faxTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.emailTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.phoneTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.postalTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.stateTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.cityTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl11 = new DevExpress.XtraEditors.LabelControl();
			this.addressTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.noteMemoEdit = new DevExpress.XtraEditors.MemoEdit();
			this.lastNameTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.firstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
			((System.ComponentModel.ISupportInitialize)this.BarManager1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.ShippingDestinationsSplitContainerControl).BeginInit();
			this.ShippingDestinationsSplitContainerControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.destinationsSearchGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.destinationsSearchGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.destinationsPanelControl).BeginInit();
			this.destinationsPanelControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.faxTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.emailTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.phoneTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.postalTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.stateTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.cityTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.addressTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.noteMemoEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.lastNameTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.nameTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.firstNameTextEdit.Properties).BeginInit();
			this.SuspendLayout();
			//
			//BarManager1
			//
			this.BarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.shippingDestinationsMenuBar, this.Bar2, this.Bar3});
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
			//shippingDestinationsMenuBar
			//
			this.shippingDestinationsMenuBar.BarName = "Tools";
			this.shippingDestinationsMenuBar.DockCol = 0;
			this.shippingDestinationsMenuBar.DockRow = 1;
			this.shippingDestinationsMenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.shippingDestinationsMenuBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.addBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.editBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.deleteBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.cancelBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.saveBarButtonItem)
			});
			this.shippingDestinationsMenuBar.OptionsBar.UseWholeRow = true;
			this.shippingDestinationsMenuBar.Text = "Tools";
			//
			//addBarButtonItem
			//
			this.addBarButtonItem.Caption = "&Add Destination";
			this.addBarButtonItem.Id = 0;
			this.addBarButtonItem.Name = "addBarButtonItem";
			//
			//editBarButtonItem
			//
			this.editBarButtonItem.Caption = "&Edit Destination";
			this.editBarButtonItem.Id = 1;
			this.editBarButtonItem.Name = "editBarButtonItem";
			//
			//deleteBarButtonItem
			//
			this.deleteBarButtonItem.Caption = "Delete Destination";
			this.deleteBarButtonItem.Id = 2;
			this.deleteBarButtonItem.Name = "deleteBarButtonItem";
			this.deleteBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
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
			this.barDockControlTop.Size = new System.Drawing.Size(684, 51);
			//
			//barDockControlBottom
			//
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 441);
			this.barDockControlBottom.Size = new System.Drawing.Size(684, 23);
			//
			//barDockControlLeft
			//
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 390);
			//
			//barDockControlRight
			//
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(684, 51);
			this.barDockControlRight.Size = new System.Drawing.Size(0, 390);
			//
			//ShippingDestinationsSplitContainerControl
			//
			this.ShippingDestinationsSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ShippingDestinationsSplitContainerControl.Location = new System.Drawing.Point(0, 51);
			this.ShippingDestinationsSplitContainerControl.Name = "ShippingDestinationsSplitContainerControl";
			this.ShippingDestinationsSplitContainerControl.Panel1.Controls.Add(this.destinationsSearchGridControl);
			this.ShippingDestinationsSplitContainerControl.Panel1.MinSize = 200;
			this.ShippingDestinationsSplitContainerControl.Panel1.Text = "Panel1";
			this.ShippingDestinationsSplitContainerControl.Panel2.Controls.Add(this.destinationsPanelControl);
			this.ShippingDestinationsSplitContainerControl.Panel2.Text = "Panel2";
			this.ShippingDestinationsSplitContainerControl.Size = new System.Drawing.Size(684, 390);
			this.ShippingDestinationsSplitContainerControl.TabIndex = 6;
			this.ShippingDestinationsSplitContainerControl.Text = "ShippingDestinations";
			//
			//destinationsSearchGridControl
			//
			this.destinationsSearchGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.destinationsSearchGridControl.Location = new System.Drawing.Point(0, 0);
			this.destinationsSearchGridControl.MainView = this.destinationsSearchGridView;
			this.destinationsSearchGridControl.Name = "destinationsSearchGridControl";
			this.destinationsSearchGridControl.Size = new System.Drawing.Size(200, 390);
			this.destinationsSearchGridControl.TabIndex = 0;
			this.destinationsSearchGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.destinationsSearchGridView});
			//
			//destinationsSearchGridView
			//
			this.destinationsSearchGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.destinationIDGridColumn, this.destinationsGridColumn});
			this.destinationsSearchGridView.GridControl = this.destinationsSearchGridControl;
			this.destinationsSearchGridView.Name = "destinationsSearchGridView";
			this.destinationsSearchGridView.OptionsBehavior.Editable = false;
			this.destinationsSearchGridView.OptionsView.ShowAutoFilterRow = true;
			this.destinationsSearchGridView.OptionsView.ShowGroupPanel = false;
			//
			//destinationIDGridColumn
			//
			this.destinationIDGridColumn.Caption = "GridColumn1";
			this.destinationIDGridColumn.FieldName = "AddressID";
			this.destinationIDGridColumn.Name = "destinationIDGridColumn";
			//
			//destinationsGridColumn
			//
			this.destinationsGridColumn.Caption = "Destination";
			this.destinationsGridColumn.FieldName = "ShippingName";
			this.destinationsGridColumn.Name = "destinationsGridColumn";
			this.destinationsGridColumn.Visible = true;
			this.destinationsGridColumn.VisibleIndex = 0;
			//
			//destinationsPanelControl
			//
			this.destinationsPanelControl.Controls.Add(this.LabelControl3);
			this.destinationsPanelControl.Controls.Add(this.faxTextEdit);
			this.destinationsPanelControl.Controls.Add(this.LabelControl4);
			this.destinationsPanelControl.Controls.Add(this.emailTextEdit);
			this.destinationsPanelControl.Controls.Add(this.LabelControl5);
			this.destinationsPanelControl.Controls.Add(this.phoneTextEdit);
			this.destinationsPanelControl.Controls.Add(this.LabelControl6);
			this.destinationsPanelControl.Controls.Add(this.postalTextEdit);
			this.destinationsPanelControl.Controls.Add(this.LabelControl7);
			this.destinationsPanelControl.Controls.Add(this.stateTextEdit);
			this.destinationsPanelControl.Controls.Add(this.LabelControl8);
			this.destinationsPanelControl.Controls.Add(this.cityTextEdit);
			this.destinationsPanelControl.Controls.Add(this.LabelControl11);
			this.destinationsPanelControl.Controls.Add(this.addressTextEdit);
			this.destinationsPanelControl.Controls.Add(this.noteMemoEdit);
			this.destinationsPanelControl.Controls.Add(this.lastNameTextEdit);
			this.destinationsPanelControl.Controls.Add(this.nameTextEdit);
			this.destinationsPanelControl.Controls.Add(this.firstNameTextEdit);
			this.destinationsPanelControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.destinationsPanelControl.Location = new System.Drawing.Point(0, 0);
			this.destinationsPanelControl.Name = "destinationsPanelControl";
			this.destinationsPanelControl.Size = new System.Drawing.Size(479, 390);
			this.destinationsPanelControl.TabIndex = 40;
			//
			//LabelControl3
			//
			this.LabelControl3.Location = new System.Drawing.Point(42, 85);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(31, 13);
			this.LabelControl3.TabIndex = 21;
			this.LabelControl3.Text = "Name:";
			//
			//faxTextEdit
			//
			this.faxTextEdit.Location = new System.Drawing.Point(279, 187);
			this.faxTextEdit.Name = "faxTextEdit";
			this.faxTextEdit.Properties.NullText = "[Fax]";
			this.faxTextEdit.Size = new System.Drawing.Size(153, 20);
			this.faxTextEdit.TabIndex = 37;
			//
			//LabelControl4
			//
			this.LabelControl4.Location = new System.Drawing.Point(42, 111);
			this.LabelControl4.Name = "LabelControl4";
			this.LabelControl4.Size = new System.Drawing.Size(72, 13);
			this.LabelControl4.TabIndex = 23;
			this.LabelControl4.Text = "Contact Name:";
			//
			//emailTextEdit
			//
			this.emailTextEdit.Location = new System.Drawing.Point(120, 213);
			this.emailTextEdit.Name = "emailTextEdit";
			this.emailTextEdit.Size = new System.Drawing.Size(312, 20);
			this.emailTextEdit.TabIndex = 35;
			//
			//LabelControl5
			//
			this.LabelControl5.Location = new System.Drawing.Point(42, 137);
			this.LabelControl5.Name = "LabelControl5";
			this.LabelControl5.Size = new System.Drawing.Size(43, 13);
			this.LabelControl5.TabIndex = 26;
			this.LabelControl5.Text = "Address:";
			//
			//phoneTextEdit
			//
			this.phoneTextEdit.Location = new System.Drawing.Point(120, 187);
			this.phoneTextEdit.Name = "phoneTextEdit";
			this.phoneTextEdit.Properties.NullText = "[Phone]";
			this.phoneTextEdit.Size = new System.Drawing.Size(153, 20);
			this.phoneTextEdit.TabIndex = 33;
			//
			//LabelControl6
			//
			this.LabelControl6.Location = new System.Drawing.Point(42, 164);
			this.LabelControl6.Name = "LabelControl6";
			this.LabelControl6.Size = new System.Drawing.Size(69, 13);
			this.LabelControl6.TabIndex = 28;
			this.LabelControl6.Text = "City State Zip:";
			//
			//postalTextEdit
			//
			this.postalTextEdit.Location = new System.Drawing.Point(332, 160);
			this.postalTextEdit.Name = "postalTextEdit";
			this.postalTextEdit.Properties.NullText = "[Zip Code]";
			this.postalTextEdit.Size = new System.Drawing.Size(100, 20);
			this.postalTextEdit.TabIndex = 31;
			//
			//LabelControl7
			//
			this.LabelControl7.Location = new System.Drawing.Point(42, 190);
			this.LabelControl7.Name = "LabelControl7";
			this.LabelControl7.Size = new System.Drawing.Size(56, 13);
			this.LabelControl7.TabIndex = 32;
			this.LabelControl7.Text = "Phone\\Fax:";
			//
			//stateTextEdit
			//
			this.stateTextEdit.Location = new System.Drawing.Point(226, 160);
			this.stateTextEdit.Name = "stateTextEdit";
			this.stateTextEdit.Properties.NullText = "[State]";
			this.stateTextEdit.Size = new System.Drawing.Size(100, 20);
			this.stateTextEdit.TabIndex = 30;
			//
			//LabelControl8
			//
			this.LabelControl8.Location = new System.Drawing.Point(42, 216);
			this.LabelControl8.Name = "LabelControl8";
			this.LabelControl8.Size = new System.Drawing.Size(28, 13);
			this.LabelControl8.TabIndex = 34;
			this.LabelControl8.Text = "Email:";
			//
			//cityTextEdit
			//
			this.cityTextEdit.Location = new System.Drawing.Point(120, 161);
			this.cityTextEdit.Name = "cityTextEdit";
			this.cityTextEdit.Properties.NullText = "[City]";
			this.cityTextEdit.Size = new System.Drawing.Size(100, 20);
			this.cityTextEdit.TabIndex = 29;
			//
			//LabelControl11
			//
			this.LabelControl11.Location = new System.Drawing.Point(42, 242);
			this.LabelControl11.Name = "LabelControl11";
			this.LabelControl11.Size = new System.Drawing.Size(27, 13);
			this.LabelControl11.TabIndex = 38;
			this.LabelControl11.Text = "Note:";
			//
			//addressTextEdit
			//
			this.addressTextEdit.Location = new System.Drawing.Point(120, 134);
			this.addressTextEdit.Name = "addressTextEdit";
			this.addressTextEdit.Size = new System.Drawing.Size(312, 20);
			this.addressTextEdit.TabIndex = 27;
			//
			//noteMemoEdit
			//
			this.noteMemoEdit.Location = new System.Drawing.Point(120, 239);
			this.noteMemoEdit.Name = "noteMemoEdit";
			this.noteMemoEdit.Size = new System.Drawing.Size(312, 68);
			this.noteMemoEdit.TabIndex = 39;
			//
			//lastNameTextEdit
			//
			this.lastNameTextEdit.Location = new System.Drawing.Point(279, 108);
			this.lastNameTextEdit.Name = "lastNameTextEdit";
			this.lastNameTextEdit.Properties.NullText = "[Last Name]";
			this.lastNameTextEdit.Size = new System.Drawing.Size(153, 20);
			this.lastNameTextEdit.TabIndex = 25;
			//
			//nameTextEdit
			//
			this.nameTextEdit.Location = new System.Drawing.Point(120, 82);
			this.nameTextEdit.Name = "nameTextEdit";
			this.nameTextEdit.Size = new System.Drawing.Size(312, 20);
			this.nameTextEdit.TabIndex = 22;
			//
			//firstNameTextEdit
			//
			this.firstNameTextEdit.Location = new System.Drawing.Point(120, 108);
			this.firstNameTextEdit.Name = "firstNameTextEdit";
			this.firstNameTextEdit.Properties.NullText = "[First Name]";
			this.firstNameTextEdit.Size = new System.Drawing.Size(153, 20);
			this.firstNameTextEdit.TabIndex = 24;
			//
			//ShippingAddressesXtraForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 464);
			this.Controls.Add(this.ShippingDestinationsSplitContainerControl);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "ShippingAddressesXtraForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Shipping Destinations";
			((System.ComponentModel.ISupportInitialize)this.BarManager1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.ShippingDestinationsSplitContainerControl).EndInit();
			this.ShippingDestinationsSplitContainerControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.destinationsSearchGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.destinationsSearchGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.destinationsPanelControl).EndInit();
			this.destinationsPanelControl.ResumeLayout(false);
			this.destinationsPanelControl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.faxTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.emailTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.phoneTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.postalTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.stateTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.cityTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.addressTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.noteMemoEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.lastNameTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.nameTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.firstNameTextEdit.Properties).EndInit();
			this.ResumeLayout(false);

//INSTANT C# NOTE: Converted design-time event handler wireups:
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(ShippingAddressesXtraForm_FormClosing);
			this.Load += new System.EventHandler(ShippingAddressesXtraForm_Load);
			destinationsSearchGridView.Click += new System.EventHandler(destinationsSearchGridView_Click);
			addBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(addBarButtonItem_ItemClick);
			editBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(editBarButtonItem_ItemClick);
			deleteBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(deleteBarButtonItem_ItemClick);
			cancelBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(cancelBarButtonItem_ItemClick);
			saveBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(saveBarButtonItem_ItemClick);
		}
		internal DevExpress.XtraBars.BarManager BarManager1;
		internal DevExpress.XtraBars.Bar shippingDestinationsMenuBar;
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
		internal DevExpress.XtraEditors.SplitContainerControl ShippingDestinationsSplitContainerControl;
		internal DevExpress.XtraEditors.TextEdit faxTextEdit;
		internal DevExpress.XtraEditors.TextEdit emailTextEdit;
		internal DevExpress.XtraEditors.TextEdit phoneTextEdit;
		internal DevExpress.XtraEditors.TextEdit postalTextEdit;
		internal DevExpress.XtraEditors.TextEdit stateTextEdit;
		internal DevExpress.XtraEditors.TextEdit cityTextEdit;
		internal DevExpress.XtraEditors.TextEdit addressTextEdit;
		internal DevExpress.XtraEditors.TextEdit lastNameTextEdit;
		internal DevExpress.XtraEditors.TextEdit firstNameTextEdit;
		internal DevExpress.XtraEditors.TextEdit nameTextEdit;
		internal DevExpress.XtraEditors.MemoEdit noteMemoEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl11;
		internal DevExpress.XtraEditors.LabelControl LabelControl8;
		internal DevExpress.XtraEditors.LabelControl LabelControl7;
		internal DevExpress.XtraEditors.LabelControl LabelControl6;
		internal DevExpress.XtraEditors.LabelControl LabelControl5;
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraGrid.GridControl destinationsSearchGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView destinationsSearchGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn destinationIDGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn destinationsGridColumn;
		internal DevExpress.XtraEditors.PanelControl destinationsPanelControl;
	}

}