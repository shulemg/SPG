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
	public partial class AllergensXtraForm : DevExpress.XtraEditors.XtraForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllergensXtraForm));
			this.deleteSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.saveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.machineLineGridControl = new DevExpress.XtraGrid.GridControl();
			this.AllergenXpCollection = new DevExpress.Xpo.XPCollection(this.components);
			this.allergenGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.idGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.nameGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)this.machineLineGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.AllergenXpCollection).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.allergenGridView).BeginInit();
			this.SuspendLayout();
			//
			//deleteSimpleButton
			//
			this.deleteSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.deleteSimpleButton.Location = new System.Drawing.Point(49, 273);
			this.deleteSimpleButton.Name = "deleteSimpleButton";
			this.deleteSimpleButton.Size = new System.Drawing.Size(75, 23);
			this.deleteSimpleButton.TabIndex = 0;
			this.deleteSimpleButton.Text = "&Delete";
			//
			//saveSimpleButton
			//
			this.saveSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.saveSimpleButton.Location = new System.Drawing.Point(131, 272);
			this.saveSimpleButton.Name = "saveSimpleButton";
			this.saveSimpleButton.Size = new System.Drawing.Size(75, 23);
			this.saveSimpleButton.TabIndex = 1;
			this.saveSimpleButton.Text = "&Save && Close";
			//
			//machineLineGridControl
			//
			this.machineLineGridControl.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.machineLineGridControl.DataSource = this.AllergenXpCollection;
			this.machineLineGridControl.Location = new System.Drawing.Point(0, -2);
			this.machineLineGridControl.MainView = this.allergenGridView;
			this.machineLineGridControl.Name = "machineLineGridControl";
			this.machineLineGridControl.Size = new System.Drawing.Size(254, 268);
			this.machineLineGridControl.TabIndex = 2;
			this.machineLineGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.allergenGridView});
			//
			//AllergenXpCollection
			//
			this.AllergenXpCollection.BindingBehavior = DevExpress.Xpo.CollectionBindingBehavior.AllowNew;
			this.AllergenXpCollection.ObjectType = typeof(DXDAL.SPGData.Allergen);
			//
			//allergenGridView
			//
			this.allergenGridView.ActiveFilterEnabled = false;
			this.allergenGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.idGridColumn, this.nameGridColumn});
			this.allergenGridView.GridControl = this.machineLineGridControl;
			this.allergenGridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
			this.allergenGridView.Name = "allergenGridView";
			this.allergenGridView.OptionsCustomization.AllowGroup = false;
			this.allergenGridView.OptionsSelection.MultiSelect = true;
			this.allergenGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
			this.allergenGridView.OptionsView.ShowGroupPanel = false;
			this.allergenGridView.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll;
			//
			//idGridColumn
			//
			this.idGridColumn.Caption = "GridColumn1";
			this.idGridColumn.FieldName = "AllergenID";
			this.idGridColumn.Name = "idGridColumn";
			//
			//nameGridColumn
			//
			this.nameGridColumn.Caption = "Allergen ";
			this.nameGridColumn.FieldName = "AllergenName";
			this.nameGridColumn.Name = "nameGridColumn";
			this.nameGridColumn.Visible = true;
			this.nameGridColumn.VisibleIndex = 0;
			//
			//AllergensXtraForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(254, 309);
			this.Controls.Add(this.machineLineGridControl);
			this.Controls.Add(this.saveSimpleButton);
			this.Controls.Add(this.deleteSimpleButton);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "AllergensXtraForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Allergens";
			((System.ComponentModel.ISupportInitialize)this.machineLineGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.AllergenXpCollection).EndInit();
			((System.ComponentModel.ISupportInitialize)this.allergenGridView).EndInit();
			this.ResumeLayout(false);

//INSTANT C# NOTE: Converted design-time event handler wireups:
			this.Load += new System.EventHandler(AllergensXtraForm_Load);
			deleteSimpleButton.Click += new System.EventHandler(deleteSimpleButton_Click);
			saveSimpleButton.Click += new System.EventHandler(saveSimpleButton_Click);
		}
		internal DevExpress.XtraEditors.SimpleButton deleteSimpleButton;
		internal DevExpress.XtraEditors.SimpleButton saveSimpleButton;
		internal DevExpress.XtraGrid.GridControl machineLineGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView allergenGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn idGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn nameGridColumn;
		internal DevExpress.Xpo.XPCollection AllergenXpCollection;
	}

}