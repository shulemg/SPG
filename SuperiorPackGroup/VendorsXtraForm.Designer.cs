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
	public partial class VendorsXtraForm : DevExpress.XtraEditors.XtraForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendorsXtraForm));
			this.vendorsXPCollection = new DevExpress.Xpo.XPCollection(this.components);
			this.GridControl1 = new DevExpress.XtraGrid.GridControl();
			this.vendorsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colVendorName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.deleteGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.deleteRepositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			((System.ComponentModel.ISupportInitialize)this.vendorsXPCollection).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.GridControl1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.vendorsGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.deleteRepositoryItemButtonEdit).BeginInit();
			this.SuspendLayout();
			//
			//vendorsXPCollection
			//
			this.vendorsXPCollection.DeleteObjectOnRemove = true;
			this.vendorsXPCollection.ObjectType = typeof(DXDAL.SPGData.Vendor);
			//
			//GridControl1
			//
			this.GridControl1.DataSource = this.vendorsXPCollection;
			this.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GridControl1.Location = new System.Drawing.Point(0, 0);
			this.GridControl1.MainView = this.vendorsGridView;
			this.GridControl1.Name = "GridControl1";
			this.GridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {this.deleteRepositoryItemButtonEdit});
			this.GridControl1.Size = new System.Drawing.Size(254, 309);
			this.GridControl1.TabIndex = 0;
			this.GridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.vendorsGridView});
			//
			//vendorsGridView
			//
			this.vendorsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colOid, this.colVendorName, this.deleteGridColumn});
			this.vendorsGridView.GridControl = this.GridControl1;
			this.vendorsGridView.Name = "vendorsGridView";
			this.vendorsGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
			this.vendorsGridView.OptionsDetail.EnableMasterViewMode = false;
			this.vendorsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
			this.vendorsGridView.OptionsView.ShowAutoFilterRow = true;
			this.vendorsGridView.OptionsView.ShowGroupPanel = false;
			//
			//colOid
			//
			this.colOid.FieldName = "Oid";
			this.colOid.Name = "colOid";
			//
			//colVendorName
			//
			this.colVendorName.FieldName = "VendorName";
			this.colVendorName.Name = "colVendorName";
			this.colVendorName.Visible = true;
			this.colVendorName.VisibleIndex = 1;
			//
			//deleteGridColumn
			//
			this.deleteGridColumn.ColumnEdit = this.deleteRepositoryItemButtonEdit;
			this.deleteGridColumn.MaxWidth = 25;
			this.deleteGridColumn.Name = "deleteGridColumn";
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
			//VendorsXtraForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(254, 309);
			this.Controls.Add(this.GridControl1);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "VendorsXtraForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Vendors";
			((System.ComponentModel.ISupportInitialize)this.vendorsXPCollection).EndInit();
			((System.ComponentModel.ISupportInitialize)this.GridControl1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.vendorsGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.deleteRepositoryItemButtonEdit).EndInit();
			this.ResumeLayout(false);

//INSTANT C# NOTE: Converted design-time event handler wireups:
			deleteRepositoryItemButtonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(deleteRepositoryItemButtonEdit_ButtonClick);
			vendorsGridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(vendorsGridView_ValidateRow);
			base.Load += new System.EventHandler(VendorsXtraForm_Load);
		}
		internal DevExpress.Xpo.XPCollection vendorsXPCollection;
		internal DevExpress.XtraGrid.GridControl GridControl1;
		internal DevExpress.XtraGrid.Views.Grid.GridView vendorsGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn colOid;
		internal DevExpress.XtraGrid.Columns.GridColumn colVendorName;
		internal DevExpress.XtraGrid.Columns.GridColumn deleteGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit deleteRepositoryItemButtonEdit;
	}

}