using System.ComponentModel;
using System.Text;
using DevExpress.XtraScheduler;
using DXDAL.SPGData;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
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
	public partial class CustomAppointmentForm : DevExpress.XtraScheduler.UI.AppointmentForm
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
			this.peopleTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.operatorTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.itemLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.itemsXpView = new DevExpress.Xpo.XPView(this.components);
			this.mustRunCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.itemDescriptionMemoEdit = new DevExpress.XtraEditors.MemoEdit();
			this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.projectLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.projectsXpView = new DevExpress.Xpo.XPView(this.components);
			this.projectDetailLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.projectDetailXpView = new DevExpress.Xpo.XPView(this.components);
			this.projectItemsXpView = new DevExpress.Xpo.XPView(this.components);
			this.quantityTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.schedByQuantityCheckEdit = new DevExpress.XtraEditors.CheckEdit();
			this.priorityComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
			this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)this.chkAllDay.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.edtStartDate.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.edtStartDate.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.edtEndDate.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.edtEndDate.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.edtStartTime.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.edtEndTime.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.edtLabel.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.edtShowTimeAs.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.tbSubject.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.edtResource.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.edtResources.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.edtResources.ResourcesCheckedListBoxControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.chkReminder.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.tbDescription.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.cbReminder.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.tbLocation.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.panel1).BeginInit();
			this.panel1.SuspendLayout();
			this.progressPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.tbProgress).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.tbProgress.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.peopleTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.operatorTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemsXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.mustRunCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemDescriptionMemoEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.projectLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.projectsXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.projectDetailLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.projectDetailXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.projectItemsXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.quantityTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.schedByQuantityCheckEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.priorityComboBoxEdit.Properties).BeginInit();
			this.SuspendLayout();
			//
			//lblSubject
			//
			this.lblSubject.Location = new System.Drawing.Point(187, 270);
			this.lblSubject.Visible = false;
			//
			//lblLocation
			//
			this.lblLocation.Location = new System.Drawing.Point(187, 296);
			this.lblLocation.Visible = false;
			//
			//lblLabel
			//
			this.lblLabel.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.lblLabel.Location = new System.Drawing.Point(22, 101);
			this.lblLabel.Visible = false;
			//
			//lblStartTime
			//
			this.lblStartTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblStartTime.Location = new System.Drawing.Point(16, 125);
			//
			//lblEndTime
			//
			this.lblEndTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblEndTime.Location = new System.Drawing.Point(16, 150);
			//
			//lblShowTimeAs
			//
			this.lblShowTimeAs.Location = new System.Drawing.Point(187, 283);
			//
			//chkAllDay
			//
			this.chkAllDay.Location = new System.Drawing.Point(0, 103);
			this.chkAllDay.Visible = false;
			//
			//btnOk
			//
			this.btnOk.Location = new System.Drawing.Point(16, 383);
			//
			//btnCancel
			//
			this.btnCancel.Location = new System.Drawing.Point(104, 383);
			//
			//btnDelete
			//
			this.btnDelete.Location = new System.Drawing.Point(192, 383);
			//
			//btnRecurrence
			//
			this.btnRecurrence.Location = new System.Drawing.Point(280, 383);
			this.btnRecurrence.Visible = false;
			//
			//edtStartDate
			//
			this.edtStartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.edtStartDate.EditValue = new DateTime(2005, 3, 31, 0, 0, 0, 0);
			this.edtStartDate.Location = new System.Drawing.Point(96, 122);
			//
			//edtEndDate
			//
			this.edtEndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.edtEndDate.EditValue = new DateTime(2005, 3, 31, 0, 0, 0, 0);
			this.edtEndDate.Location = new System.Drawing.Point(96, 147);
			//
			//edtStartTime
			//
			this.edtStartTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.edtStartTime.EditValue = new DateTime(2005, 3, 31, 0, 0, 0, 0);
			this.edtStartTime.Location = new System.Drawing.Point(224, 123);
			this.edtStartTime.Properties.Mask.EditMask = "t";
			//
			//edtEndTime
			//
			this.edtEndTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.edtEndTime.EditValue = new DateTime(2005, 3, 31, 0, 0, 0, 0);
			this.edtEndTime.Location = new System.Drawing.Point(224, 147);
			this.edtEndTime.Properties.Mask.EditMask = "t";
			//
			//edtLabel
			//
			this.edtLabel.Location = new System.Drawing.Point(77, 98);
			this.edtLabel.Visible = false;
			//
			//edtShowTimeAs
			//
			this.edtShowTimeAs.Location = new System.Drawing.Point(267, 209);
			//
			//tbSubject
			//
			this.tbSubject.Location = new System.Drawing.Point(96, 319);
			this.tbSubject.Visible = false;
			//
			//edtResource
			//
			this.edtResource.Location = new System.Drawing.Point(79, 1);
			//
			//lblResource
			//
			this.lblResource.Location = new System.Drawing.Point(3, 7);
			this.lblResource.Size = new System.Drawing.Size(65, 13);
			this.lblResource.Text = "Machine Line:";
			//
			//edtResources
			//
			this.edtResources.Location = new System.Drawing.Point(74, 4);
			//
			//
			//
			this.edtResources.ResourcesCheckedListBoxControl.CheckOnClick = true;
			this.edtResources.ResourcesCheckedListBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.edtResources.ResourcesCheckedListBoxControl.Location = new System.Drawing.Point(0, 0);
			this.edtResources.ResourcesCheckedListBoxControl.Name = "";
			this.edtResources.ResourcesCheckedListBoxControl.Size = new System.Drawing.Size(200, 100);
			this.edtResources.ResourcesCheckedListBoxControl.TabIndex = 0;
			//
			//chkReminder
			//
			this.chkReminder.Visible = false;
			//
			//tbDescription
			//
			this.tbDescription.Location = new System.Drawing.Point(16, 234);
			//
			//cbReminder
			//
			this.cbReminder.Visible = false;
			//
			//tbLocation
			//
			this.tbLocation.Location = new System.Drawing.Point(267, 293);
			this.tbLocation.Visible = false;
			//
			//panel1
			//
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel1.Location = new System.Drawing.Point(320, 43);
			this.panel1.Size = new System.Drawing.Size(192, 24);
			//
			//progressPanel
			//
			this.progressPanel.Location = new System.Drawing.Point(16, 253);
			this.progressPanel.Visible = false;
			//
			//tbProgress
			//
			this.tbProgress.Properties.LabelAppearance.Options.UseTextOptions = true;
			this.tbProgress.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.tbProgress.Visible = false;
			//
			//lblPercentComplete
			//
			this.lblPercentComplete.Appearance.BackColor = System.Drawing.Color.Transparent;
			//
			//lblPercentCompleteValue
			//
			this.lblPercentCompleteValue.Appearance.BackColor = System.Drawing.Color.Transparent;
			//
			//peopleTextEdit
			//
			this.peopleTextEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.peopleTextEdit.Location = new System.Drawing.Point(399, 70);
			this.peopleTextEdit.Name = "peopleTextEdit";
			this.peopleTextEdit.Size = new System.Drawing.Size(112, 20);
			this.peopleTextEdit.TabIndex = 29;
			//
			//LabelControl1
			//
			this.LabelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LabelControl1.Location = new System.Drawing.Point(322, 73);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(36, 13);
			this.LabelControl1.TabIndex = 30;
			this.LabelControl1.Text = "People:";
			//
			//operatorTextEdit
			//
			this.operatorTextEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.operatorTextEdit.Location = new System.Drawing.Point(399, 96);
			this.operatorTextEdit.Name = "operatorTextEdit";
			this.operatorTextEdit.Size = new System.Drawing.Size(112, 20);
			this.operatorTextEdit.TabIndex = 31;
			//
			//LabelControl2
			//
			this.LabelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LabelControl2.Location = new System.Drawing.Point(324, 99);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(48, 13);
			this.LabelControl2.TabIndex = 32;
			this.LabelControl2.Text = "Operator:";
			//
			//LabelControl3
			//
			this.LabelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LabelControl3.Location = new System.Drawing.Point(16, 50);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(26, 13);
			this.LabelControl3.TabIndex = 33;
			this.LabelControl3.Text = "Item:";
			//
			//itemLookUpEdit
			//
			this.itemLookUpEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.itemLookUpEdit.Location = new System.Drawing.Point(96, 47);
			this.itemLookUpEdit.Name = "itemLookUpEdit";
			this.itemLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.itemLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 73, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemDescription", "Item Description", 88, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 46, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DefaultMachine", "Default Machine")
			});
			this.itemLookUpEdit.Properties.DataSource = this.itemsXpView;
			this.itemLookUpEdit.Properties.DisplayMember = "ItemCode";
			this.itemLookUpEdit.Properties.ValueMember = "ItemID";
			this.itemLookUpEdit.Size = new System.Drawing.Size(216, 20);
			this.itemLookUpEdit.TabIndex = 34;
			//
			//itemsXpView
			//
			this.itemsXpView.CriteriaString = "[ItemType] <> 'RM'";
			this.itemsXpView.ObjectType = typeof(DXDAL.SPGData.Items);
			this.itemsXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.Descending, "[ItemCode]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemDescription", DevExpress.Xpo.SortDirection.None, "[ItemDescription]", false, true),
				new DevExpress.Xpo.ViewProperty("DefaultMachine", DevExpress.Xpo.SortDirection.None, "[ItemDefaultMachine.MachineLineName]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[ItemID]", false, true)
			});
			//
			//mustRunCheckEdit
			//
			this.mustRunCheckEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.mustRunCheckEdit.Location = new System.Drawing.Point(415, 174);
			this.mustRunCheckEdit.Name = "mustRunCheckEdit";
			this.mustRunCheckEdit.Properties.Caption = "Must run:";
			this.mustRunCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.mustRunCheckEdit.Size = new System.Drawing.Size(96, 19);
			this.mustRunCheckEdit.TabIndex = 35;
			//
			//itemDescriptionMemoEdit
			//
			this.itemDescriptionMemoEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.itemDescriptionMemoEdit.Location = new System.Drawing.Point(96, 74);
			this.itemDescriptionMemoEdit.Name = "itemDescriptionMemoEdit";
			this.itemDescriptionMemoEdit.Size = new System.Drawing.Size(216, 42);
			this.itemDescriptionMemoEdit.TabIndex = 36;
			//
			//LabelControl4
			//
			this.LabelControl4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LabelControl4.Location = new System.Drawing.Point(16, 24);
			this.LabelControl4.Name = "LabelControl4";
			this.LabelControl4.Size = new System.Drawing.Size(38, 13);
			this.LabelControl4.TabIndex = 37;
			this.LabelControl4.Text = "Project:";
			//
			//LabelControl5
			//
			this.LabelControl5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LabelControl5.Location = new System.Drawing.Point(326, 24);
			this.LabelControl5.Name = "LabelControl5";
			this.LabelControl5.Size = new System.Drawing.Size(67, 13);
			this.LabelControl5.TabIndex = 38;
			this.LabelControl5.Text = "Customer PO:";
			//
			//projectLookUpEdit
			//
			this.projectLookUpEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.projectLookUpEdit.Location = new System.Drawing.Point(96, 21);
			this.projectLookUpEdit.Name = "projectLookUpEdit";
			this.projectLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.projectLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProjectID", "Project ID", 71, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Project", "Project", 44, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)
			});
			this.projectLookUpEdit.Properties.DataSource = this.projectsXpView;
			this.projectLookUpEdit.Properties.DisplayMember = "Project";
			this.projectLookUpEdit.Properties.ValueMember = "ProjectID";
			this.projectLookUpEdit.Size = new System.Drawing.Size(216, 20);
			this.projectLookUpEdit.TabIndex = 39;
			//
			//projectsXpView
			//
			this.projectsXpView.CriteriaString = "[ProjectStatus] <> 3L";
			this.projectsXpView.ObjectType = typeof(DXDAL.SPGData.Project);
			this.projectsXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("ProjectID", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true),
				new DevExpress.Xpo.ViewProperty("Project", DevExpress.Xpo.SortDirection.None, "[Project]", false, true)
			});
			//
			//projectDetailLookUpEdit
			//
			this.projectDetailLookUpEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.projectDetailLookUpEdit.Location = new System.Drawing.Point(399, 21);
			this.projectDetailLookUpEdit.Name = "projectDetailLookUpEdit";
			this.projectDetailLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.projectDetailLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Project", "Project", 57, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProjectDtail", "Project Dtail", 68, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerPO", "Customer PO", 73, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Item Code", "Item Code"),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BagsNeeded", "Bags Needed", 81, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProjectItemID", "ProjectItemID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)
			});
			this.projectDetailLookUpEdit.Properties.DataSource = this.projectDetailXpView;
			this.projectDetailLookUpEdit.Properties.DisplayMember = "CustomerPO";
			this.projectDetailLookUpEdit.Properties.ValueMember = "ProjectDtail";
			this.projectDetailLookUpEdit.Size = new System.Drawing.Size(112, 20);
			this.projectDetailLookUpEdit.TabIndex = 40;
			//
			//projectDetailXpView
			//
			this.projectDetailXpView.CriteriaString = "[Project] Is Null";
			this.projectDetailXpView.ObjectType = typeof(DXDAL.SPGData.ProjectDetails);
			this.projectDetailXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("Project", DevExpress.Xpo.SortDirection.None, "[Project]", false, true),
				new DevExpress.Xpo.ViewProperty("ProjectDtail", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true),
				new DevExpress.Xpo.ViewProperty("CustomerPO", DevExpress.Xpo.SortDirection.None, "[CustomerPO]", false, true),
				new DevExpress.Xpo.ViewProperty("BagsNeeded", DevExpress.Xpo.SortDirection.None, "[BagsRequested] - [ProjectProduction][].Sum([BagsProduced])", false, true),
				new DevExpress.Xpo.ViewProperty("Item Code", DevExpress.Xpo.SortDirection.None, "[ProjectItem.ItemCode]", false, true),
				new DevExpress.Xpo.ViewProperty("ProjectItemID", DevExpress.Xpo.SortDirection.None, "[ProjectItem.ItemID]", false, true)
			});
			//
			//projectItemsXpView
			//
			this.projectItemsXpView.CriteriaString = "[Project.ProjectStatus] <> 3L";
			this.projectItemsXpView.ObjectType = typeof(DXDAL.SPGData.ProjectDetails);
			this.projectItemsXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[ProjectItem.ItemCode]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemDescription", DevExpress.Xpo.SortDirection.None, "[ProjectItem.ItemDescription]", false, true),
				new DevExpress.Xpo.ViewProperty("DefaultMachine", DevExpress.Xpo.SortDirection.None, "[ProjectItem.ItemDefaultMachine.MachineLineName]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[ProjectItem.ItemID]", false, true),
				new DevExpress.Xpo.ViewProperty("Project", DevExpress.Xpo.SortDirection.None, "[Project.Oid]", false, true),
				new DevExpress.Xpo.ViewProperty("ProjectDetail", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true)
			});
			//
			//quantityTextEdit
			//
			this.quantityTextEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.quantityTextEdit.Location = new System.Drawing.Point(399, 122);
			this.quantityTextEdit.Name = "quantityTextEdit";
			this.quantityTextEdit.Size = new System.Drawing.Size(112, 20);
			this.quantityTextEdit.TabIndex = 41;
			//
			//schedByQuantityCheckEdit
			//
			this.schedByQuantityCheckEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.schedByQuantityCheckEdit.Location = new System.Drawing.Point(267, 174);
			this.schedByQuantityCheckEdit.Name = "schedByQuantityCheckEdit";
			this.schedByQuantityCheckEdit.Properties.Caption = "Schedule by Quantity";
			this.schedByQuantityCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.schedByQuantityCheckEdit.Size = new System.Drawing.Size(126, 19);
			this.schedByQuantityCheckEdit.TabIndex = 42;
			//
			//priorityComboBoxEdit
			//
			this.priorityComboBoxEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.priorityComboBoxEdit.Location = new System.Drawing.Point(399, 146);
			this.priorityComboBoxEdit.Name = "priorityComboBoxEdit";
			this.priorityComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.priorityComboBoxEdit.Properties.Items.AddRange(new object[] {"1", "2", "3"});
			this.priorityComboBoxEdit.Size = new System.Drawing.Size(113, 20);
			this.priorityComboBoxEdit.TabIndex = 43;
			//
			//LabelControl6
			//
			this.LabelControl6.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LabelControl6.Location = new System.Drawing.Point(324, 125);
			this.LabelControl6.Name = "LabelControl6";
			this.LabelControl6.Size = new System.Drawing.Size(46, 13);
			this.LabelControl6.TabIndex = 44;
			this.LabelControl6.Text = "Quantity:";
			//
			//LabelControl7
			//
			this.LabelControl7.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LabelControl7.Location = new System.Drawing.Point(323, 150);
			this.LabelControl7.Name = "LabelControl7";
			this.LabelControl7.Size = new System.Drawing.Size(38, 13);
			this.LabelControl7.TabIndex = 45;
			this.LabelControl7.Text = "Priority:";
			//
			//CustomAppointmentForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6.0F, 13.0F);
			this.ClientSize = new System.Drawing.Size(528, 417);
			this.Controls.Add(this.LabelControl7);
			this.Controls.Add(this.LabelControl6);
			this.Controls.Add(this.priorityComboBoxEdit);
			this.Controls.Add(this.schedByQuantityCheckEdit);
			this.Controls.Add(this.quantityTextEdit);
			this.Controls.Add(this.projectDetailLookUpEdit);
			this.Controls.Add(this.projectLookUpEdit);
			this.Controls.Add(this.LabelControl5);
			this.Controls.Add(this.LabelControl4);
			this.Controls.Add(this.itemDescriptionMemoEdit);
			this.Controls.Add(this.mustRunCheckEdit);
			this.Controls.Add(this.itemLookUpEdit);
			this.Controls.Add(this.LabelControl3);
			this.Controls.Add(this.LabelControl2);
			this.Controls.Add(this.operatorTextEdit);
			this.Controls.Add(this.LabelControl1);
			this.Controls.Add(this.peopleTextEdit);
			this.MinimumSize = new System.Drawing.Size(518, 307);
			this.Name = "CustomAppointmentForm";
			this.Controls.SetChildIndex(this.edtShowTimeAs, 0);
			this.Controls.SetChildIndex(this.edtEndTime, 0);
			this.Controls.SetChildIndex(this.edtEndDate, 0);
			this.Controls.SetChildIndex(this.btnRecurrence, 0);
			this.Controls.SetChildIndex(this.btnDelete, 0);
			this.Controls.SetChildIndex(this.btnCancel, 0);
			this.Controls.SetChildIndex(this.lblShowTimeAs, 0);
			this.Controls.SetChildIndex(this.lblEndTime, 0);
			this.Controls.SetChildIndex(this.tbLocation, 0);
			this.Controls.SetChildIndex(this.lblSubject, 0);
			this.Controls.SetChildIndex(this.lblLocation, 0);
			this.Controls.SetChildIndex(this.tbSubject, 0);
			this.Controls.SetChildIndex(this.lblStartTime, 0);
			this.Controls.SetChildIndex(this.btnOk, 0);
			this.Controls.SetChildIndex(this.edtStartDate, 0);
			this.Controls.SetChildIndex(this.edtStartTime, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.progressPanel, 0);
			this.Controls.SetChildIndex(this.tbDescription, 0);
			this.Controls.SetChildIndex(this.peopleTextEdit, 0);
			this.Controls.SetChildIndex(this.LabelControl1, 0);
			this.Controls.SetChildIndex(this.operatorTextEdit, 0);
			this.Controls.SetChildIndex(this.LabelControl2, 0);
			this.Controls.SetChildIndex(this.LabelControl3, 0);
			this.Controls.SetChildIndex(this.itemLookUpEdit, 0);
			this.Controls.SetChildIndex(this.mustRunCheckEdit, 0);
			this.Controls.SetChildIndex(this.itemDescriptionMemoEdit, 0);
			this.Controls.SetChildIndex(this.LabelControl4, 0);
			this.Controls.SetChildIndex(this.LabelControl5, 0);
			this.Controls.SetChildIndex(this.projectLookUpEdit, 0);
			this.Controls.SetChildIndex(this.projectDetailLookUpEdit, 0);
			this.Controls.SetChildIndex(this.quantityTextEdit, 0);
			this.Controls.SetChildIndex(this.schedByQuantityCheckEdit, 0);
			this.Controls.SetChildIndex(this.priorityComboBoxEdit, 0);
			this.Controls.SetChildIndex(this.LabelControl6, 0);
			this.Controls.SetChildIndex(this.LabelControl7, 0);
			((System.ComponentModel.ISupportInitialize)this.chkAllDay.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.edtStartDate.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.edtStartDate.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.edtEndDate.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.edtEndDate.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.edtStartTime.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.edtEndTime.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.edtLabel.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.edtShowTimeAs.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.tbSubject.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.edtResource.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.edtResources.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.edtResources.ResourcesCheckedListBoxControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.chkReminder.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.tbDescription.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.cbReminder.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.tbLocation.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.panel1).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.progressPanel.ResumeLayout(false);
			this.progressPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.tbProgress.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.tbProgress).EndInit();
			((System.ComponentModel.ISupportInitialize)this.peopleTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.operatorTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemsXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.mustRunCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemDescriptionMemoEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.projectLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.projectsXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.projectDetailLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.projectDetailXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.projectItemsXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.quantityTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.schedByQuantityCheckEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.priorityComboBoxEdit.Properties).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

//INSTANT C# NOTE: Converted design-time event handler wireups:
			this.Load += new System.EventHandler(CustomAppointmentForm_Load);
			projectLookUpEdit.EditValueChanged += new System.EventHandler(projectLookUpEdit_EditValueChanged);
			projectDetailLookUpEdit.EditValueChanged += new System.EventHandler(projectDetailLookUpEdit_EditValueChanged);
			itemLookUpEdit.EditValueChanged += new System.EventHandler(RecalculateSchedule);
			quantityTextEdit.EditValueChanged += new System.EventHandler(RecalculateSchedule);
			schedByQuantityCheckEdit.CheckedChanged += new System.EventHandler(schedByQuantityCheckEdit_CheckedChanged);
		}
		internal DevExpress.XtraEditors.TextEdit peopleTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.TextEdit operatorTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraEditors.LookUpEdit itemLookUpEdit;
		internal DevExpress.XtraEditors.CheckEdit mustRunCheckEdit;
		internal DevExpress.Xpo.XPView itemsXpView;
		internal DevExpress.XtraEditors.MemoEdit itemDescriptionMemoEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		internal DevExpress.XtraEditors.LabelControl LabelControl5;
		internal DevExpress.Xpo.XPView projectsXpView;
		internal DevExpress.Xpo.XPView projectDetailXpView;
		internal DevExpress.XtraEditors.LookUpEdit projectLookUpEdit;
		internal DevExpress.XtraEditors.LookUpEdit projectDetailLookUpEdit;
		internal DevExpress.Xpo.XPView projectItemsXpView;
		internal DevExpress.XtraEditors.TextEdit quantityTextEdit;
		internal DevExpress.XtraEditors.CheckEdit schedByQuantityCheckEdit;
		internal DevExpress.XtraEditors.ComboBoxEdit priorityComboBoxEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl6;
		internal DevExpress.XtraEditors.LabelControl LabelControl7;

	}

}