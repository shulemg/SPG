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
	public partial class CarriersXtraForm : DevExpress.XtraEditors.XtraForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarriersXtraForm));
			this.BarManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.carriersMenuBar = new DevExpress.XtraBars.Bar();
			this.addBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.editBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.cancelBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.saveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
			this.Bar2 = new DevExpress.XtraBars.Bar();
			this.Bar3Bar = new DevExpress.XtraBars.Bar();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.carrierSplitContainerControl = new DevExpress.XtraEditors.SplitContainerControl();
			this.carriersSearchGridControl = new DevExpress.XtraGrid.GridControl();
			this.carriersSearchGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.carrierIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.carrierNameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.carrierXtraTabControl = new DevExpress.XtraTab.XtraTabControl();
			this.carriersXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
			this.faxTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.emailTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.phoneTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.postalTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.stateTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.cityTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.addressTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.lastNameTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.firstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.noteMemoEdit = new DevExpress.XtraEditors.MemoEdit();
			this.LabelControl11 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)this.BarManager1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.carrierSplitContainerControl).BeginInit();
			this.carrierSplitContainerControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.carriersSearchGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.carriersSearchGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.carrierXtraTabControl).BeginInit();
			this.carrierXtraTabControl.SuspendLayout();
			this.carriersXtraTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.faxTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.emailTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.phoneTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.postalTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.stateTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.cityTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.addressTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.lastNameTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.firstNameTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.nameTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.noteMemoEdit.Properties).BeginInit();
			this.SuspendLayout();
			//
			//BarManager1
			//
			this.BarManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {this.carriersMenuBar, this.Bar2, this.Bar3Bar});
			this.BarManager1.DockControls.Add(this.barDockControlTop);
			this.BarManager1.DockControls.Add(this.barDockControlBottom);
			this.BarManager1.DockControls.Add(this.barDockControlLeft);
			this.BarManager1.DockControls.Add(this.barDockControlRight);
			this.BarManager1.Form = this;
			this.BarManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {this.addBarButtonItem, this.editBarButtonItem, this.cancelBarButtonItem, this.saveBarButtonItem});
			this.BarManager1.MainMenu = this.Bar2;
			this.BarManager1.MaxItemId = 4;
			this.BarManager1.StatusBar = this.Bar3Bar;
			//
			//carriersMenuBar
			//
			this.carriersMenuBar.BarName = "Tools";
			this.carriersMenuBar.DockCol = 0;
			this.carriersMenuBar.DockRow = 1;
			this.carriersMenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.carriersMenuBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[]
			{
				new DevExpress.XtraBars.LinkPersistInfo(this.addBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.editBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.cancelBarButtonItem),
				new DevExpress.XtraBars.LinkPersistInfo(this.saveBarButtonItem)
			});
			this.carriersMenuBar.OptionsBar.UseWholeRow = true;
			this.carriersMenuBar.Text = "Tools";
			//
			//addBarButtonItem
			//
			this.addBarButtonItem.Caption = "&Add Carrier";
			this.addBarButtonItem.Id = 0;
			this.addBarButtonItem.Name = "addBarButtonItem";
			//
			//editBarButtonItem
			//
			this.editBarButtonItem.Caption = "&Edit Carrier";
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
			//Bar3Bar
			//
			this.Bar3Bar.BarName = "Status bar";
			this.Bar3Bar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			this.Bar3Bar.DockCol = 0;
			this.Bar3Bar.DockRow = 0;
			this.Bar3Bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			this.Bar3Bar.OptionsBar.AllowQuickCustomization = false;
			this.Bar3Bar.OptionsBar.DrawDragBorder = false;
			this.Bar3Bar.OptionsBar.UseWholeRow = true;
			this.Bar3Bar.Text = "Status bar";
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
			//carrierSplitContainerControl
			//
			this.carrierSplitContainerControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.carrierSplitContainerControl.Location = new System.Drawing.Point(0, 51);
			this.carrierSplitContainerControl.Name = "carrierSplitContainerControl";
			this.carrierSplitContainerControl.Panel1.Controls.Add(this.carriersSearchGridControl);
			this.carrierSplitContainerControl.Panel1.MinSize = 200;
			this.carrierSplitContainerControl.Panel1.Text = "Panel1";
			this.carrierSplitContainerControl.Panel2.Controls.Add(this.carrierXtraTabControl);
			this.carrierSplitContainerControl.Panel2.Text = "Panel2";
			this.carrierSplitContainerControl.Size = new System.Drawing.Size(684, 390);
			this.carrierSplitContainerControl.TabIndex = 4;
			this.carrierSplitContainerControl.Text = "SplitContainerControl1";
			//
			//carriersSearchGridControl
			//
			this.carriersSearchGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.carriersSearchGridControl.Location = new System.Drawing.Point(0, 0);
			this.carriersSearchGridControl.MainView = this.carriersSearchGridView;
			this.carriersSearchGridControl.Name = "carriersSearchGridControl";
			this.carriersSearchGridControl.Size = new System.Drawing.Size(200, 390);
			this.carriersSearchGridControl.TabIndex = 0;
			this.carriersSearchGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.carriersSearchGridView});
			//
			//carriersSearchGridView
			//
			this.carriersSearchGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.carrierIDGridColumn, this.carrierNameGridColumn});
			this.carriersSearchGridView.GridControl = this.carriersSearchGridControl;
			this.carriersSearchGridView.Name = "carriersSearchGridView";
			this.carriersSearchGridView.OptionsBehavior.Editable = false;
			this.carriersSearchGridView.OptionsView.ShowAutoFilterRow = true;
			this.carriersSearchGridView.OptionsView.ShowGroupPanel = false;
			//
			//carrierIDGridColumn
			//
			this.carrierIDGridColumn.Caption = "GridColumn1";
			this.carrierIDGridColumn.FieldName = "CarrierID";
			this.carrierIDGridColumn.Name = "carrierIDGridColumn";
			//
			//carrierNameGridColumn
			//
			this.carrierNameGridColumn.Caption = "Carrier";
			this.carrierNameGridColumn.FieldName = "CarrierName";
			this.carrierNameGridColumn.Name = "carrierNameGridColumn";
			this.carrierNameGridColumn.Visible = true;
			this.carrierNameGridColumn.VisibleIndex = 0;
			//
			//carrierXtraTabControl
			//
			this.carrierXtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.carrierXtraTabControl.Location = new System.Drawing.Point(0, 0);
			this.carrierXtraTabControl.Name = "carrierXtraTabControl";
			this.carrierXtraTabControl.SelectedTabPage = this.carriersXtraTabPage;
			this.carrierXtraTabControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
			this.carrierXtraTabControl.Size = new System.Drawing.Size(479, 390);
			this.carrierXtraTabControl.TabIndex = 4;
			this.carrierXtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {this.carriersXtraTabPage});
			//
			//carriersXtraTabPage
			//
			this.carriersXtraTabPage.Controls.Add(this.faxTextEdit);
			this.carriersXtraTabPage.Controls.Add(this.emailTextEdit);
			this.carriersXtraTabPage.Controls.Add(this.phoneTextEdit);
			this.carriersXtraTabPage.Controls.Add(this.postalTextEdit);
			this.carriersXtraTabPage.Controls.Add(this.stateTextEdit);
			this.carriersXtraTabPage.Controls.Add(this.cityTextEdit);
			this.carriersXtraTabPage.Controls.Add(this.addressTextEdit);
			this.carriersXtraTabPage.Controls.Add(this.lastNameTextEdit);
			this.carriersXtraTabPage.Controls.Add(this.firstNameTextEdit);
			this.carriersXtraTabPage.Controls.Add(this.nameTextEdit);
			this.carriersXtraTabPage.Controls.Add(this.noteMemoEdit);
			this.carriersXtraTabPage.Controls.Add(this.LabelControl11);
			this.carriersXtraTabPage.Controls.Add(this.LabelControl8);
			this.carriersXtraTabPage.Controls.Add(this.LabelControl7);
			this.carriersXtraTabPage.Controls.Add(this.LabelControl6);
			this.carriersXtraTabPage.Controls.Add(this.LabelControl5);
			this.carriersXtraTabPage.Controls.Add(this.LabelControl4);
			this.carriersXtraTabPage.Controls.Add(this.LabelControl3);
			this.carriersXtraTabPage.Name = "carriersXtraTabPage";
			this.carriersXtraTabPage.Size = new System.Drawing.Size(473, 384);
			this.carriersXtraTabPage.Text = "XtraTabPage1";
			//
			//faxTextEdit
			//
			this.faxTextEdit.Location = new System.Drawing.Point(274, 183);
			this.faxTextEdit.Name = "faxTextEdit";
			this.faxTextEdit.Properties.NullText = "[Fax]";
			this.faxTextEdit.Size = new System.Drawing.Size(153, 20);
			this.faxTextEdit.TabIndex = 18;
			//
			//emailTextEdit
			//
			this.emailTextEdit.Location = new System.Drawing.Point(115, 209);
			this.emailTextEdit.Name = "emailTextEdit";
			this.emailTextEdit.Size = new System.Drawing.Size(312, 20);
			this.emailTextEdit.TabIndex = 16;
			//
			//phoneTextEdit
			//
			this.phoneTextEdit.Location = new System.Drawing.Point(115, 183);
			this.phoneTextEdit.Name = "phoneTextEdit";
			this.phoneTextEdit.Properties.NullText = "[Phone]";
			this.phoneTextEdit.Size = new System.Drawing.Size(153, 20);
			this.phoneTextEdit.TabIndex = 14;
			//
			//postalTextEdit
			//
			this.postalTextEdit.Location = new System.Drawing.Point(327, 156);
			this.postalTextEdit.Name = "postalTextEdit";
			this.postalTextEdit.Properties.NullText = "[Zip code]";
			this.postalTextEdit.Size = new System.Drawing.Size(100, 20);
			this.postalTextEdit.TabIndex = 12;
			//
			//stateTextEdit
			//
			this.stateTextEdit.Location = new System.Drawing.Point(221, 156);
			this.stateTextEdit.Name = "stateTextEdit";
			this.stateTextEdit.Properties.NullText = "[State]";
			this.stateTextEdit.Size = new System.Drawing.Size(100, 20);
			this.stateTextEdit.TabIndex = 11;
			//
			//cityTextEdit
			//
			this.cityTextEdit.Location = new System.Drawing.Point(115, 157);
			this.cityTextEdit.Name = "cityTextEdit";
			this.cityTextEdit.Properties.NullText = "[City]";
			this.cityTextEdit.Size = new System.Drawing.Size(100, 20);
			this.cityTextEdit.TabIndex = 10;
			//
			//addressTextEdit
			//
			this.addressTextEdit.Location = new System.Drawing.Point(115, 130);
			this.addressTextEdit.Name = "addressTextEdit";
			this.addressTextEdit.Size = new System.Drawing.Size(312, 20);
			this.addressTextEdit.TabIndex = 8;
			//
			//lastNameTextEdit
			//
			this.lastNameTextEdit.Location = new System.Drawing.Point(274, 104);
			this.lastNameTextEdit.Name = "lastNameTextEdit";
			this.lastNameTextEdit.Properties.NullText = "[Last Name]";
			this.lastNameTextEdit.Size = new System.Drawing.Size(153, 20);
			this.lastNameTextEdit.TabIndex = 6;
			//
			//firstNameTextEdit
			//
			this.firstNameTextEdit.Location = new System.Drawing.Point(115, 104);
			this.firstNameTextEdit.Name = "firstNameTextEdit";
			this.firstNameTextEdit.Properties.NullText = "[First Name]";
			this.firstNameTextEdit.Size = new System.Drawing.Size(153, 20);
			this.firstNameTextEdit.TabIndex = 5;
			//
			//nameTextEdit
			//
			this.nameTextEdit.Location = new System.Drawing.Point(115, 78);
			this.nameTextEdit.Name = "nameTextEdit";
			this.nameTextEdit.Size = new System.Drawing.Size(312, 20);
			this.nameTextEdit.TabIndex = 3;
			//
			//noteMemoEdit
			//
			this.noteMemoEdit.Location = new System.Drawing.Point(115, 235);
			this.noteMemoEdit.Name = "noteMemoEdit";
			this.noteMemoEdit.Size = new System.Drawing.Size(312, 68);
			this.noteMemoEdit.TabIndex = 20;
			this.noteMemoEdit.UseOptimizedRendering = true;
			//
			//LabelControl11
			//
			this.LabelControl11.Location = new System.Drawing.Point(37, 238);
			this.LabelControl11.Name = "LabelControl11";
			this.LabelControl11.Size = new System.Drawing.Size(27, 13);
			this.LabelControl11.TabIndex = 19;
			this.LabelControl11.Text = "Note:";
			//
			//LabelControl8
			//
			this.LabelControl8.Location = new System.Drawing.Point(37, 212);
			this.LabelControl8.Name = "LabelControl8";
			this.LabelControl8.Size = new System.Drawing.Size(28, 13);
			this.LabelControl8.TabIndex = 15;
			this.LabelControl8.Text = "Email:";
			//
			//LabelControl7
			//
			this.LabelControl7.Location = new System.Drawing.Point(37, 186);
			this.LabelControl7.Name = "LabelControl7";
			this.LabelControl7.Size = new System.Drawing.Size(56, 13);
			this.LabelControl7.TabIndex = 13;
			this.LabelControl7.Text = "Phone\\Fax:";
			//
			//LabelControl6
			//
			this.LabelControl6.Location = new System.Drawing.Point(37, 160);
			this.LabelControl6.Name = "LabelControl6";
			this.LabelControl6.Size = new System.Drawing.Size(69, 13);
			this.LabelControl6.TabIndex = 9;
			this.LabelControl6.Text = "City State Zip:";
			//
			//LabelControl5
			//
			this.LabelControl5.Location = new System.Drawing.Point(37, 133);
			this.LabelControl5.Name = "LabelControl5";
			this.LabelControl5.Size = new System.Drawing.Size(43, 13);
			this.LabelControl5.TabIndex = 7;
			this.LabelControl5.Text = "Address:";
			//
			//LabelControl4
			//
			this.LabelControl4.Location = new System.Drawing.Point(37, 107);
			this.LabelControl4.Name = "LabelControl4";
			this.LabelControl4.Size = new System.Drawing.Size(72, 13);
			this.LabelControl4.TabIndex = 4;
			this.LabelControl4.Text = "Contact Name:";
			//
			//LabelControl3
			//
			this.LabelControl3.Location = new System.Drawing.Point(37, 81);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(31, 13);
			this.LabelControl3.TabIndex = 2;
			this.LabelControl3.Text = "Name:";
			//
			//CarriersXtraForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 464);
			this.Controls.Add(this.carrierSplitContainerControl);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "CarriersXtraForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Carriers";
			((System.ComponentModel.ISupportInitialize)this.BarManager1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.carrierSplitContainerControl).EndInit();
			this.carrierSplitContainerControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.carriersSearchGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.carriersSearchGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.carrierXtraTabControl).EndInit();
			this.carrierXtraTabControl.ResumeLayout(false);
			this.carriersXtraTabPage.ResumeLayout(false);
			this.carriersXtraTabPage.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.faxTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.emailTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.phoneTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.postalTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.stateTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.cityTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.addressTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.lastNameTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.firstNameTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.nameTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.noteMemoEdit.Properties).EndInit();
			this.ResumeLayout(false);

//INSTANT C# NOTE: Converted design-time event handler wireups:
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(CarriersXtraForm_FormClosing);
			base.Load += new System.EventHandler(CarriersXtraForm_Load);
			carriersSearchGridView.Click += new System.EventHandler(carriersSearchGridView_Click);
			addBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(addBarButtonItem_ItemClick);
			editBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(editBarButtonItem_ItemClick);
			cancelBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(cancelBarButtonItem_ItemClick);
			saveBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(saveBarButtonItem_ItemClick);
		}
		internal DevExpress.XtraBars.BarManager BarManager1;
		internal DevExpress.XtraBars.Bar carriersMenuBar;
		internal DevExpress.XtraBars.BarButtonItem addBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem editBarButtonItem;
		internal DevExpress.XtraBars.BarButtonItem cancelBarButtonItem;
		internal DevExpress.XtraBars.Bar Bar2;
		internal DevExpress.XtraBars.Bar Bar3Bar;
		internal DevExpress.XtraBars.BarDockControl barDockControlTop;
		internal DevExpress.XtraBars.BarDockControl barDockControlBottom;
		internal DevExpress.XtraBars.BarDockControl barDockControlLeft;
		internal DevExpress.XtraBars.BarDockControl barDockControlRight;
		internal DevExpress.XtraBars.BarButtonItem saveBarButtonItem;
		internal DevExpress.XtraEditors.SplitContainerControl carrierSplitContainerControl;
		internal DevExpress.XtraTab.XtraTabControl carrierXtraTabControl;
		internal DevExpress.XtraTab.XtraTabPage carriersXtraTabPage;
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
		internal DevExpress.XtraGrid.GridControl carriersSearchGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView carriersSearchGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn carrierIDGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn carrierNameGridColumn;
	}

}