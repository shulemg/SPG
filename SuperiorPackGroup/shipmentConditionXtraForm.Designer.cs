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
	public partial class shipmentConditionXtraForm : DevExpress.XtraEditors.XtraForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shipmentConditionXtraForm));
			this.saveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.deleteSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.conditionsGridControl = new DevExpress.XtraGrid.GridControl();
			this.shipmentConditionsXpCollection = new DevExpress.Xpo.XPCollection(this.components);
			this.conditionsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShipmentCondition = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)this.conditionsGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shipmentConditionsXpCollection).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.conditionsGridView).BeginInit();
			this.SuspendLayout();
			//
			//saveSimpleButton
			//
			this.saveSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.saveSimpleButton.Location = new System.Drawing.Point(131, 275);
			this.saveSimpleButton.Name = "saveSimpleButton";
			this.saveSimpleButton.Size = new System.Drawing.Size(75, 23);
			this.saveSimpleButton.TabIndex = 4;
			this.saveSimpleButton.Text = "&Save";
			//
			//deleteSimpleButton
			//
			this.deleteSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.deleteSimpleButton.Location = new System.Drawing.Point(49, 275);
			this.deleteSimpleButton.Name = "deleteSimpleButton";
			this.deleteSimpleButton.Size = new System.Drawing.Size(75, 23);
			this.deleteSimpleButton.TabIndex = 2;
			this.deleteSimpleButton.TabStop = false;
			this.deleteSimpleButton.Text = "&Delete";
			//
			//conditionsGridControl
			//
			this.conditionsGridControl.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.conditionsGridControl.DataSource = this.shipmentConditionsXpCollection;
			this.conditionsGridControl.Location = new System.Drawing.Point(0, 0);
			this.conditionsGridControl.MainView = this.conditionsGridView;
			this.conditionsGridControl.Name = "conditionsGridControl";
			this.conditionsGridControl.Size = new System.Drawing.Size(280, 268);
			this.conditionsGridControl.TabIndex = 3;
			this.conditionsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.conditionsGridView});
			//
			//shipmentConditionsXpCollection
			//
			this.shipmentConditionsXpCollection.ObjectType = typeof(DXDAL.SPGData.ShipmentConditions);
			this.shipmentConditionsXpCollection.Sorting.AddRange(new DevExpress.Xpo.SortProperty[] {new DevExpress.Xpo.SortProperty("[ShipmentCondition]", DevExpress.Xpo.DB.SortingDirection.Ascending)});
			//
			//conditionsGridView
			//
			this.conditionsGridView.ActiveFilterEnabled = false;
			this.conditionsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colOid, this.colShipmentCondition});
			this.conditionsGridView.GridControl = this.conditionsGridControl;
			this.conditionsGridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
			this.conditionsGridView.Name = "conditionsGridView";
			this.conditionsGridView.OptionsCustomization.AllowGroup = false;
			this.conditionsGridView.OptionsSelection.MultiSelect = true;
			this.conditionsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
			this.conditionsGridView.OptionsView.ShowDetailButtons = false;
			this.conditionsGridView.OptionsView.ShowGroupPanel = false;
			this.conditionsGridView.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.LiveVertScroll;
			//
			//colOid
			//
			this.colOid.FieldName = "Oid";
			this.colOid.Name = "colOid";
			this.colOid.OptionsColumn.ReadOnly = true;
			//
			//colShipmentCondition
			//
			this.colShipmentCondition.FieldName = "ShipmentCondition";
			this.colShipmentCondition.Name = "colShipmentCondition";
			this.colShipmentCondition.Visible = true;
			this.colShipmentCondition.VisibleIndex = 0;
			//
			//shipmentConditionXtraForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 309);
			this.Controls.Add(this.saveSimpleButton);
			this.Controls.Add(this.deleteSimpleButton);
			this.Controls.Add(this.conditionsGridControl);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "shipmentConditionXtraForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Shipment Conditions";
			((System.ComponentModel.ISupportInitialize)this.conditionsGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shipmentConditionsXpCollection).EndInit();
			((System.ComponentModel.ISupportInitialize)this.conditionsGridView).EndInit();
			this.ResumeLayout(false);

//INSTANT C# NOTE: Converted design-time event handler wireups:
			this.Load += new System.EventHandler(shipmentConditionXtraForm_Load);
			deleteSimpleButton.Click += new System.EventHandler(deleteSimpleButton_Click);
		}
		internal DevExpress.XtraEditors.SimpleButton saveSimpleButton;
		internal DevExpress.XtraEditors.SimpleButton deleteSimpleButton;
		internal DevExpress.XtraGrid.GridControl conditionsGridControl;
		internal DevExpress.Xpo.XPCollection shipmentConditionsXpCollection;
		internal DevExpress.XtraGrid.Views.Grid.GridView conditionsGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn colOid;
		internal DevExpress.XtraGrid.Columns.GridColumn colShipmentCondition;
	}

}