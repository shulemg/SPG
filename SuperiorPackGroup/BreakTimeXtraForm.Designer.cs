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
	public partial class BreakTimeXtraForm : DevExpress.XtraEditors.XtraForm
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
			this.breakTimeGridControl = new DevExpress.XtraGrid.GridControl();
			this.breakTimeXPCollection = new DevExpress.Xpo.XPCollection();
			this.breakTimeGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.deleteGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.deleteRepositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colWeekDay = new DevExpress.XtraGrid.Columns.GridColumn();
			this.weekDayRepositoryItemComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
			this.colStartTime = new DevExpress.XtraGrid.Columns.GridColumn();
			this.startRepositoryItemTimeEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
			this.colEndTime = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colStarting = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEnding = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)this.breakTimeGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.breakTimeXPCollection).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.breakTimeGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.deleteRepositoryItemButtonEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.weekDayRepositoryItemComboBox).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.startRepositoryItemTimeEdit).BeginInit();
			this.SuspendLayout();
			//
			//breakTimeGridControl
			//
			this.breakTimeGridControl.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.breakTimeGridControl.DataSource = this.breakTimeXPCollection;
			this.breakTimeGridControl.Location = new System.Drawing.Point(12, 12);
			this.breakTimeGridControl.MainView = this.breakTimeGridView;
			this.breakTimeGridControl.Name = "breakTimeGridControl";
			this.breakTimeGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {this.weekDayRepositoryItemComboBox, this.startRepositoryItemTimeEdit, this.deleteRepositoryItemButtonEdit});
			this.breakTimeGridControl.Size = new System.Drawing.Size(466, 240);
			this.breakTimeGridControl.TabIndex = 0;
			this.breakTimeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.breakTimeGridView});
			//
			//breakTimeXPCollection
			//
			this.breakTimeXPCollection.DeleteObjectOnRemove = true;
			this.breakTimeXPCollection.ObjectType = typeof(DXDAL.SPGData.BreakTime);
			//
			//breakTimeGridView
			//
			this.breakTimeGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.deleteGridColumn, this.colOid, this.colWeekDay, this.colStartTime, this.colEndTime, this.colStarting, this.colEnding});
			this.breakTimeGridView.GridControl = this.breakTimeGridControl;
			this.breakTimeGridView.Name = "breakTimeGridView";
			this.breakTimeGridView.OptionsBehavior.AllowIncrementalSearch = true;
			this.breakTimeGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
			this.breakTimeGridView.OptionsView.ShowAutoFilterRow = true;
			//
			//deleteGridColumn
			//
			this.deleteGridColumn.ColumnEdit = this.deleteRepositoryItemButtonEdit;
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
			//colOid
			//
			this.colOid.FieldName = "Oid";
			this.colOid.Name = "colOid";
			//
			//colWeekDay
			//
			this.colWeekDay.ColumnEdit = this.weekDayRepositoryItemComboBox;
			this.colWeekDay.FieldName = "WeekDay";
			this.colWeekDay.Name = "colWeekDay";
			this.colWeekDay.Visible = true;
			this.colWeekDay.VisibleIndex = 1;
			this.colWeekDay.Width = 83;
			//
			//weekDayRepositoryItemComboBox
			//
			this.weekDayRepositoryItemComboBox.AutoHeight = false;
			this.weekDayRepositoryItemComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.weekDayRepositoryItemComboBox.Items.AddRange(new object[] {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"});
			this.weekDayRepositoryItemComboBox.Name = "weekDayRepositoryItemComboBox";
			this.weekDayRepositoryItemComboBox.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			//
			//colStartTime
			//
			this.colStartTime.ColumnEdit = this.startRepositoryItemTimeEdit;
			this.colStartTime.FieldName = "StartTime";
			this.colStartTime.Name = "colStartTime";
			this.colStartTime.Visible = true;
			this.colStartTime.VisibleIndex = 2;
			this.colStartTime.Width = 83;
			//
			//startRepositoryItemTimeEdit
			//
			this.startRepositoryItemTimeEdit.AutoHeight = false;
			this.startRepositoryItemTimeEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton()});
			this.startRepositoryItemTimeEdit.Name = "startRepositoryItemTimeEdit";
			//
			//colEndTime
			//
			this.colEndTime.ColumnEdit = this.startRepositoryItemTimeEdit;
			this.colEndTime.FieldName = "EndTime";
			this.colEndTime.Name = "colEndTime";
			this.colEndTime.Visible = true;
			this.colEndTime.VisibleIndex = 3;
			this.colEndTime.Width = 83;
			//
			//colStarting
			//
			this.colStarting.FieldName = "Starting";
			this.colStarting.Name = "colStarting";
			this.colStarting.Visible = true;
			this.colStarting.VisibleIndex = 4;
			this.colStarting.Width = 83;
			//
			//colEnding
			//
			this.colEnding.FieldName = "Ending";
			this.colEnding.Name = "colEnding";
			this.colEnding.Visible = true;
			this.colEnding.VisibleIndex = 5;
			this.colEnding.Width = 88;
			//
			//BreakTimeXtraForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(490, 264);
			this.Controls.Add(this.breakTimeGridControl);
			this.Name = "BreakTimeXtraForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Break Time";
			((System.ComponentModel.ISupportInitialize)this.breakTimeGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.breakTimeXPCollection).EndInit();
			((System.ComponentModel.ISupportInitialize)this.breakTimeGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.deleteRepositoryItemButtonEdit).EndInit();
			((System.ComponentModel.ISupportInitialize)this.weekDayRepositoryItemComboBox).EndInit();
			((System.ComponentModel.ISupportInitialize)this.startRepositoryItemTimeEdit).EndInit();
			this.ResumeLayout(false);

//INSTANT C# NOTE: Converted design-time event handler wireups:
			deleteRepositoryItemButtonEdit.Click += new System.EventHandler(deleteRepositoryItemButtonEdit_Click);
			breakTimeGridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(breakTimeGridView_ValidateRow);
		}
		internal DevExpress.XtraGrid.GridControl breakTimeGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView breakTimeGridView;
		internal DevExpress.Xpo.XPCollection breakTimeXPCollection;
		internal DevExpress.XtraGrid.Columns.GridColumn colOid;
		internal DevExpress.XtraGrid.Columns.GridColumn colWeekDay;
		internal DevExpress.XtraGrid.Columns.GridColumn colStartTime;
		internal DevExpress.XtraGrid.Columns.GridColumn colEndTime;
		internal DevExpress.XtraGrid.Columns.GridColumn colStarting;
		internal DevExpress.XtraGrid.Columns.GridColumn colEnding;
		internal DevExpress.XtraEditors.Repository.RepositoryItemComboBox weekDayRepositoryItemComboBox;
		internal DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit startRepositoryItemTimeEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn deleteGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit deleteRepositoryItemButtonEdit;
	}

}