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
	public partial class ShiftsXtraForm : DevExpress.XtraEditors.XtraForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShiftsXtraForm));
			this.shiftsGridControl = new DevExpress.XtraGrid.GridControl();
			this.shiftsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.idGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.shiftGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.deleteSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.saveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.deleteRepositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			((System.ComponentModel.ISupportInitialize)this.shiftsGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shiftsGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.deleteRepositoryItemButtonEdit).BeginInit();
			this.SuspendLayout();
			//
			//shiftsGridControl
			//
			this.shiftsGridControl.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.shiftsGridControl.Location = new System.Drawing.Point(0, 0);
			this.shiftsGridControl.MainView = this.shiftsGridView;
			this.shiftsGridControl.Name = "shiftsGridControl";
			this.shiftsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {this.deleteRepositoryItemButtonEdit});
			this.shiftsGridControl.Size = new System.Drawing.Size(254, 268);
			this.shiftsGridControl.TabIndex = 0;
			this.shiftsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.shiftsGridView});
			//
			//shiftsGridView
			//
			this.shiftsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.idGridColumn, this.shiftGridColumn});
			this.shiftsGridView.GridControl = this.shiftsGridControl;
			this.shiftsGridView.Name = "shiftsGridView";
			this.shiftsGridView.OptionsSelection.MultiSelect = true;
			this.shiftsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
			this.shiftsGridView.OptionsView.ShowGroupPanel = false;
			//
			//idGridColumn
			//
			this.idGridColumn.Caption = "GridColumn1";
			this.idGridColumn.Name = "idGridColumn";
			//
			//shiftGridColumn
			//
			this.shiftGridColumn.Caption = "Shift";
			this.shiftGridColumn.Name = "shiftGridColumn";
			this.shiftGridColumn.Visible = true;
			this.shiftGridColumn.VisibleIndex = 0;
			//
			//deleteSimpleButton
			//
			this.deleteSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.deleteSimpleButton.Location = new System.Drawing.Point(49, 274);
			this.deleteSimpleButton.Name = "deleteSimpleButton";
			this.deleteSimpleButton.Size = new System.Drawing.Size(75, 23);
			this.deleteSimpleButton.TabIndex = 1;
			this.deleteSimpleButton.Text = "&Delete";
			//
			//saveSimpleButton
			//
			this.saveSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.saveSimpleButton.Location = new System.Drawing.Point(131, 274);
			this.saveSimpleButton.Name = "saveSimpleButton";
			this.saveSimpleButton.Size = new System.Drawing.Size(75, 23);
			this.saveSimpleButton.TabIndex = 2;
			this.saveSimpleButton.Text = "&Save";
			//
			//deleteRepositoryItemButtonEdit
			//
			this.deleteRepositoryItemButtonEdit.AutoHeight = false;
			this.deleteRepositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
			this.deleteRepositoryItemButtonEdit.Name = "deleteRepositoryItemButtonEdit";
			this.deleteRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			//
			//ShiftsXtraForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(254, 309);
			this.Controls.Add(this.saveSimpleButton);
			this.Controls.Add(this.deleteSimpleButton);
			this.Controls.Add(this.shiftsGridControl);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "ShiftsXtraForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Shifts";
			((System.ComponentModel.ISupportInitialize)this.shiftsGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shiftsGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.deleteRepositoryItemButtonEdit).EndInit();
			this.ResumeLayout(false);

//INSTANT C# NOTE: Converted design-time event handler wireups:
			deleteSimpleButton.Click += new System.EventHandler(deleteSimpleButton_Click);
			saveSimpleButton.Click += new System.EventHandler(saveSimpleButton_Click);
			this.Load += new System.EventHandler(ShiftsXtraForm_Load);
		}
		internal DevExpress.XtraGrid.GridControl shiftsGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView shiftsGridView;
		internal DevExpress.XtraEditors.SimpleButton deleteSimpleButton;
		internal DevExpress.XtraEditors.SimpleButton saveSimpleButton;
		internal DevExpress.XtraGrid.Columns.GridColumn idGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn shiftGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit deleteRepositoryItemButtonEdit;
	}

}