using System.Data.Sql;
using DevExpress.XtraEditors;

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
	public partial class DatabaseSelectionXtraForm : DevExpress.XtraEditors.XtraForm
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
			this.cancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.okSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.serverLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.refreshSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.GroupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.sqlAuthenticationPanelControl = new DevExpress.XtraEditors.PanelControl();
			this.passwordTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.userNameTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.logOnRadioGroup = new DevExpress.XtraEditors.RadioGroup();
			this.dataBaseLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.testConnectionSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.refreshDatabasesSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.serversBackgroundWorker = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)this.serverLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.GroupControl1).BeginInit();
			this.GroupControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.sqlAuthenticationPanelControl).BeginInit();
			this.sqlAuthenticationPanelControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.passwordTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.userNameTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.logOnRadioGroup.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dataBaseLookUpEdit.Properties).BeginInit();
			this.SuspendLayout();
			//
			//cancelSimpleButton
			//
			this.cancelSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.cancelSimpleButton.Location = new System.Drawing.Point(195, 409);
			this.cancelSimpleButton.Name = "cancelSimpleButton";
			this.cancelSimpleButton.Size = new System.Drawing.Size(75, 23);
			this.cancelSimpleButton.TabIndex = 9;
			this.cancelSimpleButton.Text = "&Cancel";
			//
			//okSimpleButton
			//
			this.okSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.okSimpleButton.Location = new System.Drawing.Point(277, 409);
			this.okSimpleButton.Name = "okSimpleButton";
			this.okSimpleButton.Size = new System.Drawing.Size(75, 23);
			this.okSimpleButton.TabIndex = 8;
			this.okSimpleButton.Text = "&OK";
			//
			//LabelControl1
			//
			this.LabelControl1.Location = new System.Drawing.Point(28, 42);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(149, 13);
			this.LabelControl1.TabIndex = 1;
			this.LabelControl1.Text = "Select or Enter a Server Name:";
			//
			//serverLookUpEdit
			//
			this.serverLookUpEdit.Location = new System.Drawing.Point(28, 62);
			this.serverLookUpEdit.Name = "serverLookUpEdit";
			this.serverLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.serverLookUpEdit.Properties.NullText = "[Select A Server]";
			this.serverLookUpEdit.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
			this.serverLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.serverLookUpEdit.Size = new System.Drawing.Size(223, 20);
			this.serverLookUpEdit.TabIndex = 2;
			//
			//refreshSimpleButton
			//
			this.refreshSimpleButton.Location = new System.Drawing.Point(257, 59);
			this.refreshSimpleButton.Name = "refreshSimpleButton";
			this.refreshSimpleButton.Size = new System.Drawing.Size(95, 23);
			this.refreshSimpleButton.TabIndex = 0;
			this.refreshSimpleButton.Text = "Refresh";
			//
			//GroupControl1
			//
			this.GroupControl1.Controls.Add(this.sqlAuthenticationPanelControl);
			this.GroupControl1.Controls.Add(this.logOnRadioGroup);
			this.GroupControl1.Location = new System.Drawing.Point(28, 103);
			this.GroupControl1.Name = "GroupControl1";
			this.GroupControl1.Size = new System.Drawing.Size(324, 188);
			this.GroupControl1.TabIndex = 3;
			this.GroupControl1.Text = "Log on to the server";
			//
			//sqlAuthenticationPanelControl
			//
			this.sqlAuthenticationPanelControl.Controls.Add(this.passwordTextEdit);
			this.sqlAuthenticationPanelControl.Controls.Add(this.userNameTextEdit);
			this.sqlAuthenticationPanelControl.Controls.Add(this.LabelControl3);
			this.sqlAuthenticationPanelControl.Controls.Add(this.LabelControl2);
			this.sqlAuthenticationPanelControl.Enabled = false;
			this.sqlAuthenticationPanelControl.Location = new System.Drawing.Point(23, 85);
			this.sqlAuthenticationPanelControl.Name = "sqlAuthenticationPanelControl";
			this.sqlAuthenticationPanelControl.Size = new System.Drawing.Size(276, 85);
			this.sqlAuthenticationPanelControl.TabIndex = 1;
			//
			//passwordTextEdit
			//
			this.passwordTextEdit.Location = new System.Drawing.Point(102, 46);
			this.passwordTextEdit.Name = "passwordTextEdit";
			this.passwordTextEdit.Properties.PasswordChar = (char)42;
			this.passwordTextEdit.Size = new System.Drawing.Size(146, 20);
			this.passwordTextEdit.TabIndex = 3;
			//
			//userNameTextEdit
			//
			this.userNameTextEdit.Location = new System.Drawing.Point(102, 19);
			this.userNameTextEdit.Name = "userNameTextEdit";
			this.userNameTextEdit.Size = new System.Drawing.Size(146, 20);
			this.userNameTextEdit.TabIndex = 1;
			//
			//LabelControl3
			//
			this.LabelControl3.Location = new System.Drawing.Point(29, 49);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(46, 13);
			this.LabelControl3.TabIndex = 2;
			this.LabelControl3.Text = "Password";
			//
			//LabelControl2
			//
			this.LabelControl2.Location = new System.Drawing.Point(29, 22);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(52, 13);
			this.LabelControl2.TabIndex = 0;
			this.LabelControl2.Text = "User Name";
			//
			//logOnRadioGroup
			//
			this.logOnRadioGroup.EditValue = true;
			this.logOnRadioGroup.Location = new System.Drawing.Point(21, 24);
			this.logOnRadioGroup.Name = "logOnRadioGroup";
			this.logOnRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[]
			{
				new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "Use Windows Authentication"),
				new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "Use SQL Server Authentication")
			});
			this.logOnRadioGroup.Size = new System.Drawing.Size(189, 55);
			this.logOnRadioGroup.TabIndex = 0;
			//
			//dataBaseLookUpEdit
			//
			this.dataBaseLookUpEdit.Enabled = false;
			this.dataBaseLookUpEdit.Location = new System.Drawing.Point(28, 339);
			this.dataBaseLookUpEdit.Name = "dataBaseLookUpEdit";
			this.dataBaseLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.dataBaseLookUpEdit.Properties.NullText = "[Select A Database]";
			this.dataBaseLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
			this.dataBaseLookUpEdit.Size = new System.Drawing.Size(223, 20);
			this.dataBaseLookUpEdit.TabIndex = 6;
			//
			//LabelControl4
			//
			this.LabelControl4.Location = new System.Drawing.Point(28, 319);
			this.LabelControl4.Name = "LabelControl4";
			this.LabelControl4.Size = new System.Drawing.Size(163, 13);
			this.LabelControl4.TabIndex = 5;
			this.LabelControl4.Text = "Select or Enter a Database Name:";
			//
			//testConnectionSimpleButton
			//
			this.testConnectionSimpleButton.Enabled = false;
			this.testConnectionSimpleButton.Location = new System.Drawing.Point(12, 409);
			this.testConnectionSimpleButton.Name = "testConnectionSimpleButton";
			this.testConnectionSimpleButton.Size = new System.Drawing.Size(95, 23);
			this.testConnectionSimpleButton.TabIndex = 7;
			this.testConnectionSimpleButton.Text = "Test Connection";
			//
			//refreshDatabasesSimpleButton
			//
			this.refreshDatabasesSimpleButton.Location = new System.Drawing.Point(257, 336);
			this.refreshDatabasesSimpleButton.Name = "refreshDatabasesSimpleButton";
			this.refreshDatabasesSimpleButton.Size = new System.Drawing.Size(95, 23);
			this.refreshDatabasesSimpleButton.TabIndex = 4;
			this.refreshDatabasesSimpleButton.Text = "Refresh";
			//
			//serversBackgroundWorker
			//
			//
			//DatabaseSelectionXtraForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(364, 444);
			this.ControlBox = false;
			this.Controls.Add(this.refreshDatabasesSimpleButton);
			this.Controls.Add(this.testConnectionSimpleButton);
			this.Controls.Add(this.LabelControl4);
			this.Controls.Add(this.dataBaseLookUpEdit);
			this.Controls.Add(this.GroupControl1);
			this.Controls.Add(this.refreshSimpleButton);
			this.Controls.Add(this.serverLookUpEdit);
			this.Controls.Add(this.LabelControl1);
			this.Controls.Add(this.okSimpleButton);
			this.Controls.Add(this.cancelSimpleButton);
			this.Name = "DatabaseSelectionXtraForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Select Database";
			((System.ComponentModel.ISupportInitialize)this.serverLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.GroupControl1).EndInit();
			this.GroupControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.sqlAuthenticationPanelControl).EndInit();
			this.sqlAuthenticationPanelControl.ResumeLayout(false);
			this.sqlAuthenticationPanelControl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.passwordTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.userNameTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.logOnRadioGroup.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dataBaseLookUpEdit.Properties).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			this.Load += new System.EventHandler(DatabaseSelectionXtraForm_Load);
			refreshSimpleButton.Click += new System.EventHandler(refreshSimpleButton_Click);
			logOnRadioGroup.SelectedIndexChanged += new System.EventHandler(logOnRadioGroup_SelectedIndexChanged);
			testConnectionSimpleButton.Click += new System.EventHandler(testConnectionSimpleButton_Click);
			cancelSimpleButton.Click += new System.EventHandler(cancelSimpleButton_Click);
			okSimpleButton.Click += new System.EventHandler(okSimpleButton_Click);
			serverLookUpEdit.ProcessNewValue += new DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(serverLookUpEdit_ProcessNewValue);
			serverLookUpEdit.Leave += new System.EventHandler(serverLookUpEdit_Leave);
			refreshDatabasesSimpleButton.Click += new System.EventHandler(refreshDatabasesSimpleButton_Click);
			serversBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(serversBackgroundWorker_DoWork);
			serversBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(serversBackgroundWorker_RunWorkerCompleted);
		}
		internal DevExpress.XtraEditors.SimpleButton cancelSimpleButton;
		internal DevExpress.XtraEditors.SimpleButton okSimpleButton;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.LookUpEdit serverLookUpEdit;
		internal DevExpress.XtraEditors.SimpleButton refreshSimpleButton;
		internal DevExpress.XtraEditors.GroupControl GroupControl1;
		internal DevExpress.XtraEditors.RadioGroup logOnRadioGroup;
		internal DevExpress.XtraEditors.PanelControl sqlAuthenticationPanelControl;
		internal DevExpress.XtraEditors.TextEdit passwordTextEdit;
		internal DevExpress.XtraEditors.TextEdit userNameTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.LookUpEdit dataBaseLookUpEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		internal DevExpress.XtraEditors.SimpleButton testConnectionSimpleButton;
		internal DevExpress.XtraEditors.SimpleButton refreshDatabasesSimpleButton;
		internal System.ComponentModel.BackgroundWorker serversBackgroundWorker;
	}

}