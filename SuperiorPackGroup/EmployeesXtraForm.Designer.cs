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
	public partial class employeesXtraForm : DevExpress.XtraEditors.XtraForm
	{
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeesXtraForm));
			this.employeeGridControl = new DevExpress.XtraGrid.GridControl();
			this.employeesXpCollection = new DevExpress.Xpo.XPCollection(this.components);
			this.employeeGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.deleteSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.saveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)this.employeeGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.employeesXpCollection).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.employeeGridView).BeginInit();
			this.SuspendLayout();
			//
			//employeeGridControl
			//
			this.employeeGridControl.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.employeeGridControl.DataSource = this.employeesXpCollection;
			this.employeeGridControl.Location = new System.Drawing.Point(0, 0);
			this.employeeGridControl.MainView = this.employeeGridView;
			this.employeeGridControl.Name = "employeeGridControl";
			this.employeeGridControl.Size = new System.Drawing.Size(280, 268);
			this.employeeGridControl.TabIndex = 0;
			this.employeeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.employeeGridView});
			//
			//employeesXpCollection
			//
			this.employeesXpCollection.ObjectType = typeof(DXDAL.SPGData.Employees);
			this.employeesXpCollection.Sorting.AddRange(new DevExpress.Xpo.SortProperty[] {new DevExpress.Xpo.SortProperty("[FullName]", DevExpress.Xpo.DB.SortingDirection.Ascending)});
			//
			//employeeGridView
			//
			this.employeeGridView.ActiveFilterEnabled = false;
			this.employeeGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colOid, this.colFullName, this.colFirstName, this.colLastName});
			this.employeeGridView.GridControl = this.employeeGridControl;
			this.employeeGridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
			this.employeeGridView.Name = "employeeGridView";
			this.employeeGridView.OptionsCustomization.AllowGroup = false;
			this.employeeGridView.OptionsSelection.MultiSelect = true;
			this.employeeGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
			this.employeeGridView.OptionsView.ShowDetailButtons = false;
			this.employeeGridView.OptionsView.ShowGroupPanel = false;
			this.employeeGridView.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll;
			//
			//colOid
			//
			this.colOid.FieldName = "Oid";
			this.colOid.Name = "colOid";
			this.colOid.OptionsColumn.ReadOnly = true;
			//
			//colFullName
			//
			this.colFullName.FieldName = "FullName";
			this.colFullName.Name = "colFullName";
			this.colFullName.OptionsColumn.ReadOnly = true;
			//
			//colFirstName
			//
			this.colFirstName.FieldName = "FirstName";
			this.colFirstName.Name = "colFirstName";
			this.colFirstName.Visible = true;
			this.colFirstName.VisibleIndex = 0;
			//
			//colLastName
			//
			this.colLastName.FieldName = "LastName";
			this.colLastName.Name = "colLastName";
			this.colLastName.Visible = true;
			this.colLastName.VisibleIndex = 1;
			//
			//deleteSimpleButton
			//
			this.deleteSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.deleteSimpleButton.Location = new System.Drawing.Point(49, 275);
			this.deleteSimpleButton.Name = "deleteSimpleButton";
			this.deleteSimpleButton.Size = new System.Drawing.Size(75, 23);
			this.deleteSimpleButton.TabIndex = 0;
			this.deleteSimpleButton.TabStop = false;
			this.deleteSimpleButton.Text = "&Delete";
			//
			//saveSimpleButton
			//
			this.saveSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.saveSimpleButton.Location = new System.Drawing.Point(131, 275);
			this.saveSimpleButton.Name = "saveSimpleButton";
			this.saveSimpleButton.Size = new System.Drawing.Size(75, 23);
			this.saveSimpleButton.TabIndex = 1;
			this.saveSimpleButton.Text = "&Save";
			//
			//employeesXtraForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 309);
			this.Controls.Add(this.saveSimpleButton);
			this.Controls.Add(this.deleteSimpleButton);
			this.Controls.Add(this.employeeGridControl);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "employeesXtraForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Employees";
			((System.ComponentModel.ISupportInitialize)this.employeeGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.employeesXpCollection).EndInit();
			((System.ComponentModel.ISupportInitialize)this.employeeGridView).EndInit();
			this.ResumeLayout(false);

//INSTANT C# NOTE: Converted design-time event handler wireups:
			this.Load += new System.EventHandler(EmployeesXtraForm_Load);
			deleteSimpleButton.Click += new System.EventHandler(deleteSimpleButton_Click);
		}
		internal DevExpress.XtraGrid.GridControl employeeGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView employeeGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn colOid;
		internal DevExpress.XtraGrid.Columns.GridColumn colFullName;
		internal DevExpress.XtraGrid.Columns.GridColumn colFirstName;
		internal DevExpress.XtraGrid.Columns.GridColumn colLastName;
		internal DevExpress.XtraEditors.SimpleButton deleteSimpleButton;
		internal DevExpress.XtraEditors.SimpleButton saveSimpleButton;
		internal DevExpress.Xpo.XPCollection employeesXpCollection;
	}

}