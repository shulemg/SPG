using System.Linq;
using DevExpress;
using DevExpress.Xpo;
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
	public partial class ReasonCodesXtraForm : DevExpress.XtraEditors.XtraForm
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
			this.reasonCodesXpCollection = new DevExpress.Xpo.XPCollection(this.components);
			this.reasonCodesGridControl = new DevExpress.XtraGrid.GridControl();
			this.reassonCodesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReasonType = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReasonCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.saveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.deleteSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)this.reasonCodesXpCollection).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.reasonCodesGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.reassonCodesGridView).BeginInit();
			this.SuspendLayout();
			//
			//reasonCodesXpCollection
			//
			this.reasonCodesXpCollection.ObjectType = typeof(DXDAL.SPGData.ReasonCodes);
			//
			//reasonCodesGridControl
			//
			this.reasonCodesGridControl.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.reasonCodesGridControl.DataSource = this.reasonCodesXpCollection;
			this.reasonCodesGridControl.Location = new System.Drawing.Point(13, 13);
			this.reasonCodesGridControl.MainView = this.reassonCodesGridView;
			this.reasonCodesGridControl.Name = "reasonCodesGridControl";
			this.reasonCodesGridControl.Size = new System.Drawing.Size(519, 320);
			this.reasonCodesGridControl.TabIndex = 0;
			this.reasonCodesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.reassonCodesGridView});
			//
			//reassonCodesGridView
			//
			this.reassonCodesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colOid, this.colReasonType, this.colReasonCode, this.colDescription});
			this.reassonCodesGridView.GridControl = this.reasonCodesGridControl;
			this.reassonCodesGridView.Name = "reassonCodesGridView";
			this.reassonCodesGridView.OptionsView.ShowDetailButtons = false;
			//
			//colOid
			//
			this.colOid.FieldName = "Oid";
			this.colOid.Name = "colOid";
			//
			//colReasonType
			//
			this.colReasonType.FieldName = "ReasonType";
			this.colReasonType.Name = "colReasonType";
			this.colReasonType.Visible = true;
			this.colReasonType.VisibleIndex = 0;
			this.colReasonType.Width = 100;
			//
			//colReasonCode
			//
			this.colReasonCode.FieldName = "ReasonCode";
			this.colReasonCode.Name = "colReasonCode";
			this.colReasonCode.Visible = true;
			this.colReasonCode.VisibleIndex = 1;
			this.colReasonCode.Width = 90;
			//
			//colDescription
			//
			this.colDescription.FieldName = "Description";
			this.colDescription.Name = "colDescription";
			this.colDescription.Visible = true;
			this.colDescription.VisibleIndex = 2;
			this.colDescription.Width = 311;
			//
			//saveSimpleButton
			//
			this.saveSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.saveSimpleButton.Location = new System.Drawing.Point(275, 339);
			this.saveSimpleButton.Name = "saveSimpleButton";
			this.saveSimpleButton.Size = new System.Drawing.Size(95, 32);
			this.saveSimpleButton.TabIndex = 1;
			this.saveSimpleButton.Text = "Save";
			//
			//deleteSimpleButton
			//
			this.deleteSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.deleteSimpleButton.Location = new System.Drawing.Point(174, 339);
			this.deleteSimpleButton.Name = "deleteSimpleButton";
			this.deleteSimpleButton.Size = new System.Drawing.Size(95, 32);
			this.deleteSimpleButton.TabIndex = 2;
			this.deleteSimpleButton.Text = "Delete";
			//
			//ReasonCodesXtraForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 384);
			this.Controls.Add(this.deleteSimpleButton);
			this.Controls.Add(this.saveSimpleButton);
			this.Controls.Add(this.reasonCodesGridControl);
			this.Name = "ReasonCodesXtraForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ReasonCodesXtraForm";
			((System.ComponentModel.ISupportInitialize)this.reasonCodesXpCollection).EndInit();
			((System.ComponentModel.ISupportInitialize)this.reasonCodesGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.reassonCodesGridView).EndInit();
			this.ResumeLayout(false);

//INSTANT C# NOTE: Converted design-time event handler wireups:
		deleteSimpleButton.Click += new System.EventHandler(deleteSimpleButton_Click);
		this.Load += new System.EventHandler(ReasonCodesXtraForm_Load);
	}

		internal DevExpress.Xpo.XPCollection reasonCodesXpCollection;
		internal DevExpress.XtraGrid.GridControl reasonCodesGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView reassonCodesGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn colOid;
		internal DevExpress.XtraGrid.Columns.GridColumn colReasonType;
		internal DevExpress.XtraGrid.Columns.GridColumn colReasonCode;
		internal DevExpress.XtraGrid.Columns.GridColumn colDescription;
		internal DevExpress.XtraEditors.SimpleButton saveSimpleButton;
		internal DevExpress.XtraEditors.SimpleButton deleteSimpleButton;
	}

}