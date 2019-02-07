using DevExpress.XtraEditors;
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
	public partial class SettingsXtraForm : DevExpress.XtraEditors.XtraForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsXtraForm));
			this.cancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.saveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.packersTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.operatorsTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.supersTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.minutesTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.customerLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.SetUpBreakTimesSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.LPNCopiesTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LPNMoveDownTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LPNMoveRightTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LPNPrinterTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.locationLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.locationsXpView = new DevExpress.Xpo.XPView(this.components);
			((System.ComponentModel.ISupportInitialize)this.packersTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.operatorsTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.supersTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.minutesTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customerLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.LPNCopiesTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.LPNMoveDownTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.LPNMoveRightTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.LPNPrinterTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.locationLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.locationsXpView).BeginInit();
			this.SuspendLayout();
			//
			//cancelSimpleButton
			//
			this.cancelSimpleButton.Location = new System.Drawing.Point(156, 198);
			this.cancelSimpleButton.Name = "cancelSimpleButton";
			this.cancelSimpleButton.Size = new System.Drawing.Size(75, 23);
			this.cancelSimpleButton.TabIndex = 0;
			this.cancelSimpleButton.Text = "&Cancel";
			//
			//saveSimpleButton
			//
			this.saveSimpleButton.Location = new System.Drawing.Point(237, 198);
			this.saveSimpleButton.Name = "saveSimpleButton";
			this.saveSimpleButton.Size = new System.Drawing.Size(75, 23);
			this.saveSimpleButton.TabIndex = 1;
			this.saveSimpleButton.Text = "&Save";
			//
			//LabelControl1
			//
			this.LabelControl1.Location = new System.Drawing.Point(32, 82);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(64, 13);
			this.LabelControl1.TabIndex = 2;
			this.LabelControl1.Text = "Packer's Pay:";
			//
			//LabelControl2
			//
			this.LabelControl2.Location = new System.Drawing.Point(32, 108);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(76, 13);
			this.LabelControl2.TabIndex = 3;
			this.LabelControl2.Text = "Operator's Pay:";
			//
			//LabelControl3
			//
			this.LabelControl3.Location = new System.Drawing.Point(32, 134);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(60, 13);
			this.LabelControl3.TabIndex = 4;
			this.LabelControl3.Text = "Super's Pay:";
			//
			//LabelControl4
			//
			this.LabelControl4.Location = new System.Drawing.Point(32, 160);
			this.LabelControl4.Name = "LabelControl4";
			this.LabelControl4.Size = new System.Drawing.Size(69, 13);
			this.LabelControl4.TabIndex = 5;
			this.LabelControl4.Text = "Min. per Hour:";
			//
			//packersTextEdit
			//
			this.packersTextEdit.Location = new System.Drawing.Point(131, 79);
			this.packersTextEdit.Name = "packersTextEdit";
			this.packersTextEdit.Properties.DisplayFormat.FormatString = "c";
			this.packersTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.packersTextEdit.Size = new System.Drawing.Size(100, 20);
			this.packersTextEdit.TabIndex = 6;
			//
			//operatorsTextEdit
			//
			this.operatorsTextEdit.Location = new System.Drawing.Point(131, 105);
			this.operatorsTextEdit.Name = "operatorsTextEdit";
			this.operatorsTextEdit.Properties.DisplayFormat.FormatString = "c";
			this.operatorsTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.operatorsTextEdit.Size = new System.Drawing.Size(100, 20);
			this.operatorsTextEdit.TabIndex = 7;
			//
			//supersTextEdit
			//
			this.supersTextEdit.Location = new System.Drawing.Point(131, 131);
			this.supersTextEdit.Name = "supersTextEdit";
			this.supersTextEdit.Properties.DisplayFormat.FormatString = "c";
			this.supersTextEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.supersTextEdit.Size = new System.Drawing.Size(100, 20);
			this.supersTextEdit.TabIndex = 8;
			//
			//minutesTextEdit
			//
			this.minutesTextEdit.Location = new System.Drawing.Point(131, 157);
			this.minutesTextEdit.Name = "minutesTextEdit";
			this.minutesTextEdit.Size = new System.Drawing.Size(100, 20);
			this.minutesTextEdit.TabIndex = 9;
			//
			//customerLookUpEdit
			//
			this.customerLookUpEdit.Location = new System.Drawing.Point(131, 46);
			this.customerLookUpEdit.Name = "customerLookUpEdit";
			this.customerLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.customerLookUpEdit.Properties.NullText = "[Select A Customer]";
			this.customerLookUpEdit.Size = new System.Drawing.Size(100, 20);
			this.customerLookUpEdit.TabIndex = 10;
			//
			//LabelControl5
			//
			this.LabelControl5.Location = new System.Drawing.Point(32, 49);
			this.LabelControl5.Name = "LabelControl5";
			this.LabelControl5.Size = new System.Drawing.Size(93, 13);
			this.LabelControl5.TabIndex = 11;
			this.LabelControl5.Text = "Universal Customer";
			//
			//SetUpBreakTimesSimpleButton
			//
			this.SetUpBreakTimesSimpleButton.Location = new System.Drawing.Point(280, 12);
			this.SetUpBreakTimesSimpleButton.Name = "SetUpBreakTimesSimpleButton";
			this.SetUpBreakTimesSimpleButton.Size = new System.Drawing.Size(156, 23);
			this.SetUpBreakTimesSimpleButton.TabIndex = 12;
			this.SetUpBreakTimesSimpleButton.Text = "Set Up Break Times";
			//
			//LPNCopiesTextEdit
			//
			this.LPNCopiesTextEdit.Location = new System.Drawing.Point(336, 157);
			this.LPNCopiesTextEdit.Name = "LPNCopiesTextEdit";
			this.LPNCopiesTextEdit.Size = new System.Drawing.Size(100, 20);
			this.LPNCopiesTextEdit.TabIndex = 20;
			//
			//LPNMoveDownTextEdit
			//
			this.LPNMoveDownTextEdit.Location = new System.Drawing.Point(336, 131);
			this.LPNMoveDownTextEdit.Name = "LPNMoveDownTextEdit";
			this.LPNMoveDownTextEdit.Size = new System.Drawing.Size(100, 20);
			this.LPNMoveDownTextEdit.TabIndex = 19;
			//
			//LPNMoveRightTextEdit
			//
			this.LPNMoveRightTextEdit.Location = new System.Drawing.Point(336, 105);
			this.LPNMoveRightTextEdit.Name = "LPNMoveRightTextEdit";
			this.LPNMoveRightTextEdit.Size = new System.Drawing.Size(100, 20);
			this.LPNMoveRightTextEdit.TabIndex = 18;
			//
			//LPNPrinterTextEdit
			//
			this.LPNPrinterTextEdit.Location = new System.Drawing.Point(336, 79);
			this.LPNPrinterTextEdit.Name = "LPNPrinterTextEdit";
			this.LPNPrinterTextEdit.Size = new System.Drawing.Size(100, 20);
			this.LPNPrinterTextEdit.TabIndex = 17;
			//
			//LabelControl6
			//
			this.LabelControl6.Location = new System.Drawing.Point(249, 160);
			this.LabelControl6.Name = "LabelControl6";
			this.LabelControl6.Size = new System.Drawing.Size(57, 13);
			this.LabelControl6.TabIndex = 16;
			this.LabelControl6.Text = "LPN Copies:";
			//
			//LabelControl7
			//
			this.LabelControl7.Location = new System.Drawing.Point(249, 134);
			this.LabelControl7.Name = "LabelControl7";
			this.LabelControl7.Size = new System.Drawing.Size(81, 13);
			this.LabelControl7.TabIndex = 15;
			this.LabelControl7.Text = "LPN Move Down:";
			//
			//LabelControl8
			//
			this.LabelControl8.Location = new System.Drawing.Point(249, 108);
			this.LabelControl8.Name = "LabelControl8";
			this.LabelControl8.Size = new System.Drawing.Size(79, 13);
			this.LabelControl8.TabIndex = 14;
			this.LabelControl8.Text = "LPN Move Right:";
			//
			//LabelControl9
			//
			this.LabelControl9.Location = new System.Drawing.Point(249, 82);
			this.LabelControl9.Name = "LabelControl9";
			this.LabelControl9.Size = new System.Drawing.Size(57, 13);
			this.LabelControl9.TabIndex = 13;
			this.LabelControl9.Text = "LPN Printer:";
			//
			//LabelControl10
			//
			this.LabelControl10.Location = new System.Drawing.Point(249, 49);
			this.LabelControl10.Name = "LabelControl10";
			this.LabelControl10.Size = new System.Drawing.Size(78, 13);
			this.LabelControl10.TabIndex = 21;
			this.LabelControl10.Text = "Default Location";
			//
			//locationLookUpEdit
			//
			this.locationLookUpEdit.Location = new System.Drawing.Point(336, 46);
			this.locationLookUpEdit.Name = "locationLookUpEdit";
			this.locationLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.locationLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationId", "Location Id", 76, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationCode", "Location Code", 78, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LocationName", "Location Name", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)
			});
			this.locationLookUpEdit.Properties.DataSource = this.locationsXpView;
			this.locationLookUpEdit.Properties.DisplayMember = "LocationCode";
			this.locationLookUpEdit.Properties.NullText = "[Select default location]";
			this.locationLookUpEdit.Properties.ValueMember = "LocationId";
			this.locationLookUpEdit.Size = new System.Drawing.Size(100, 20);
			this.locationLookUpEdit.TabIndex = 22;
			//
			//locationsXpView
			//
			this.locationsXpView.ObjectType = typeof(DXDAL.SPGData.Locations);
			this.locationsXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("LocationId", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true),
				new DevExpress.Xpo.ViewProperty("LocationCode", DevExpress.Xpo.SortDirection.None, "[LocationCode]", false, true),
				new DevExpress.Xpo.ViewProperty("LocationName", DevExpress.Xpo.SortDirection.None, "[LocationName]", false, true)
			});
			//
			//SettingsXtraForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(468, 264);
			this.Controls.Add(this.locationLookUpEdit);
			this.Controls.Add(this.LabelControl10);
			this.Controls.Add(this.LPNCopiesTextEdit);
			this.Controls.Add(this.LPNMoveDownTextEdit);
			this.Controls.Add(this.LPNMoveRightTextEdit);
			this.Controls.Add(this.LPNPrinterTextEdit);
			this.Controls.Add(this.LabelControl6);
			this.Controls.Add(this.LabelControl7);
			this.Controls.Add(this.LabelControl8);
			this.Controls.Add(this.LabelControl9);
			this.Controls.Add(this.SetUpBreakTimesSimpleButton);
			this.Controls.Add(this.LabelControl5);
			this.Controls.Add(this.customerLookUpEdit);
			this.Controls.Add(this.minutesTextEdit);
			this.Controls.Add(this.supersTextEdit);
			this.Controls.Add(this.operatorsTextEdit);
			this.Controls.Add(this.packersTextEdit);
			this.Controls.Add(this.LabelControl4);
			this.Controls.Add(this.LabelControl3);
			this.Controls.Add(this.LabelControl2);
			this.Controls.Add(this.LabelControl1);
			this.Controls.Add(this.saveSimpleButton);
			this.Controls.Add(this.cancelSimpleButton);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "SettingsXtraForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Company Settings";
			((System.ComponentModel.ISupportInitialize)this.packersTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.operatorsTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.supersTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.minutesTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customerLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.LPNCopiesTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.LPNMoveDownTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.LPNMoveRightTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.LPNPrinterTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.locationLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.locationsXpView).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			base.Load += new System.EventHandler(SettingsXtraForm_Load);
			packersTextEdit.ParseEditValue += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(payTextEditParseEditValue);
			operatorsTextEdit.ParseEditValue += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(payTextEditParseEditValue);
			supersTextEdit.ParseEditValue += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(payTextEditParseEditValue);
			saveSimpleButton.Click += new System.EventHandler(saveSimpleButton_Click);
			cancelSimpleButton.Click += new System.EventHandler(cancelSimpleButton_Click);
			SetUpBreakTimesSimpleButton.Click += new System.EventHandler(SetUpBreakTimesSimpleButton_Click);
		}
		internal DevExpress.XtraEditors.SimpleButton cancelSimpleButton;
		internal DevExpress.XtraEditors.SimpleButton saveSimpleButton;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		internal DevExpress.XtraEditors.TextEdit packersTextEdit;
		internal DevExpress.XtraEditors.TextEdit operatorsTextEdit;
		internal DevExpress.XtraEditors.TextEdit supersTextEdit;
		internal DevExpress.XtraEditors.TextEdit minutesTextEdit;
		internal DevExpress.XtraEditors.LookUpEdit customerLookUpEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl5;
		internal DevExpress.XtraEditors.SimpleButton SetUpBreakTimesSimpleButton;
		internal DevExpress.XtraEditors.TextEdit LPNCopiesTextEdit;
		internal DevExpress.XtraEditors.TextEdit LPNMoveDownTextEdit;
		internal DevExpress.XtraEditors.TextEdit LPNMoveRightTextEdit;
		internal DevExpress.XtraEditors.TextEdit LPNPrinterTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl6;
		internal DevExpress.XtraEditors.LabelControl LabelControl7;
		internal DevExpress.XtraEditors.LabelControl LabelControl8;
		internal DevExpress.XtraEditors.LabelControl LabelControl9;
		internal DevExpress.XtraEditors.LabelControl LabelControl10;
		internal DevExpress.XtraEditors.LookUpEdit locationLookUpEdit;
		internal DevExpress.Xpo.XPView locationsXpView;
	}

}