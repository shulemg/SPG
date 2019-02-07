using DevExpress.XtraEditors;
using DevExpress.Data.Filtering;
using DXDAL.SPGData;
using DevExpress.Xpo;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

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
	public partial class ProductionXtraForm : DevExpress.XtraEditors.XtraForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductionXtraForm));
			this.recordGroupControl = new DevExpress.XtraEditors.GroupControl();
			this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.reasonsGridControl = new DevExpress.XtraGrid.GridControl();
			this.reasonsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.deleteReasonGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.deleteReasonRepositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			this.reasonDescriptionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.reasonDescriptionRepositoryItemGridLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
			this.reasonCodesXpView = new DevExpress.Xpo.XPView(this.components);
			this.RepositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.uomTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.descriptionMemoEdit = new DevExpress.XtraEditors.MemoEdit();
			this.saveSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.editSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.cancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.LabelControl13 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl12 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl11 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.packersTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.quantityTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.stopTimeEdit = new DevExpress.XtraEditors.TimeEdit();
			this.startTimeEdit = new DevExpress.XtraEditors.TimeEdit();
			this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.productionDateEdit = new DevExpress.XtraEditors.DateEdit();
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.itemLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.itemsXPView = new DevExpress.Xpo.XPView(this.components);
			this.shiftLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.machineLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.machineLineXpView = new DevExpress.Xpo.XPView(this.components);
			this.filtersGroupControl = new DevExpress.XtraEditors.GroupControl();
			this.filterSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.clearSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.LabelControl19 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl18 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl17 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl16 = new DevExpress.XtraEditors.LabelControl();
			this.machineFilterLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.shiftFilterLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.itemFilterLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.itemsFilterXPView = new DevExpress.Xpo.XPView(this.components);
			this.customerFilterLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.customersXPView = new DevExpress.Xpo.XPView(this.components);
			this.LabelControl15 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl14 = new DevExpress.XtraEditors.LabelControl();
			this.fromFilterDateEdit = new DevExpress.XtraEditors.DateEdit();
			this.toFilterDateEdit = new DevExpress.XtraEditors.DateEdit();
			this.productionGridControl = new DevExpress.XtraGrid.GridControl();
			this.productionXPView = new DevExpress.Xpo.XPView(this.components);
			this.productionGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.deleteGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.deleteRepositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			this.idGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.customerGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.dateGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.machineGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.itemGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.descriptionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.quantityGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.startGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.stopGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.timeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPackers = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colShift = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReasons = new DevExpress.XtraGrid.Columns.GridColumn();
			this.RepositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
			this.GridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.reasonCodeGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.reasonCodeRepositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.colReasonType = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colReasonCode = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)this.recordGroupControl).BeginInit();
			this.recordGroupControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.reasonsGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.reasonsGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.deleteReasonRepositoryItemButtonEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.reasonDescriptionRepositoryItemGridLookUpEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.reasonCodesXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemGridLookUpEdit1View).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.uomTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.descriptionMemoEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.packersTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.quantityTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.stopTimeEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.startTimeEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionDateEdit.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionDateEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemsXPView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shiftLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.machineLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.machineLineXpView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.filtersGroupControl).BeginInit();
			this.filtersGroupControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.machineFilterLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.shiftFilterLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemFilterLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.itemsFilterXPView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customerFilterLookUpEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.customersXPView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.fromFilterDateEdit.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.fromFilterDateEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.toFilterDateEdit.Properties.CalendarTimeProperties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.toFilterDateEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionXPView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.productionGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.deleteRepositoryItemButtonEdit).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemMemoEdit1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.reasonCodeRepositoryItemLookUpEdit1).BeginInit();
			this.SuspendLayout();
			//
			//recordGroupControl
			//
			this.recordGroupControl.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.recordGroupControl.Controls.Add(this.LabelControl3);
			this.recordGroupControl.Controls.Add(this.reasonsGridControl);
			this.recordGroupControl.Controls.Add(this.LabelControl2);
			this.recordGroupControl.Controls.Add(this.uomTextEdit);
			this.recordGroupControl.Controls.Add(this.descriptionMemoEdit);
			this.recordGroupControl.Controls.Add(this.saveSimpleButton);
			this.recordGroupControl.Controls.Add(this.editSimpleButton);
			this.recordGroupControl.Controls.Add(this.cancelSimpleButton);
			this.recordGroupControl.Controls.Add(this.LabelControl13);
			this.recordGroupControl.Controls.Add(this.LabelControl12);
			this.recordGroupControl.Controls.Add(this.LabelControl11);
			this.recordGroupControl.Controls.Add(this.LabelControl10);
			this.recordGroupControl.Controls.Add(this.LabelControl8);
			this.recordGroupControl.Controls.Add(this.LabelControl7);
			this.recordGroupControl.Controls.Add(this.packersTextEdit);
			this.recordGroupControl.Controls.Add(this.quantityTextEdit);
			this.recordGroupControl.Controls.Add(this.LabelControl5);
			this.recordGroupControl.Controls.Add(this.stopTimeEdit);
			this.recordGroupControl.Controls.Add(this.startTimeEdit);
			this.recordGroupControl.Controls.Add(this.LabelControl4);
			this.recordGroupControl.Controls.Add(this.productionDateEdit);
			this.recordGroupControl.Controls.Add(this.LabelControl1);
			this.recordGroupControl.Controls.Add(this.itemLookUpEdit);
			this.recordGroupControl.Controls.Add(this.shiftLookUpEdit);
			this.recordGroupControl.Controls.Add(this.machineLookUpEdit);
			this.recordGroupControl.Location = new System.Drawing.Point(12, 12);
			this.recordGroupControl.Name = "recordGroupControl";
			this.recordGroupControl.Size = new System.Drawing.Size(927, 155);
			this.recordGroupControl.TabIndex = 0;
			this.recordGroupControl.Text = "Add\\Edit Production Record";
			//
			//LabelControl3
			//
			this.LabelControl3.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.LabelControl3.Location = new System.Drawing.Point(612, 23);
			this.LabelControl3.Name = "LabelControl3";
			this.LabelControl3.Size = new System.Drawing.Size(41, 13);
			this.LabelControl3.TabIndex = 24;
			this.LabelControl3.Text = "Reasons";
			//
			//reasonsGridControl
			//
			this.reasonsGridControl.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.reasonsGridControl.Location = new System.Drawing.Point(612, 41);
			this.reasonsGridControl.MainView = this.reasonsGridView;
			this.reasonsGridControl.Name = "reasonsGridControl";
			this.reasonsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {this.reasonDescriptionRepositoryItemGridLookUpEdit, this.deleteReasonRepositoryItemButtonEdit, this.reasonCodeRepositoryItemLookUpEdit1});
			this.reasonsGridControl.Size = new System.Drawing.Size(310, 78);
			this.reasonsGridControl.TabIndex = 17;
			this.reasonsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.reasonsGridView});
			//
			//reasonsGridView
			//
			this.reasonsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.deleteReasonGridColumn, this.reasonCodeGridColumn, this.reasonDescriptionGridColumn});
			this.reasonsGridView.GridControl = this.reasonsGridControl;
			this.reasonsGridView.Name = "reasonsGridView";
			this.reasonsGridView.OptionsBehavior.FocusLeaveOnTab = true;
			this.reasonsGridView.OptionsSelection.MultiSelect = true;
			this.reasonsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
			this.reasonsGridView.OptionsView.ShowColumnHeaders = false;
			this.reasonsGridView.OptionsView.ShowDetailButtons = false;
			this.reasonsGridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
			this.reasonsGridView.OptionsView.ShowGroupPanel = false;
			//
			//deleteReasonGridColumn
			//
			this.deleteReasonGridColumn.Caption = "GridColumn2";
			this.deleteReasonGridColumn.ColumnEdit = this.deleteReasonRepositoryItemButtonEdit;
			this.deleteReasonGridColumn.Name = "deleteReasonGridColumn";
			this.deleteReasonGridColumn.OptionsColumn.TabStop = false;
			this.deleteReasonGridColumn.Visible = true;
			this.deleteReasonGridColumn.VisibleIndex = 0;
			this.deleteReasonGridColumn.Width = 25;
			//
			//deleteReasonRepositoryItemButtonEdit
			//
			this.deleteReasonRepositoryItemButtonEdit.AutoHeight = false;
			this.deleteReasonRepositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
			this.deleteReasonRepositoryItemButtonEdit.Name = "deleteReasonRepositoryItemButtonEdit";
			this.deleteReasonRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			//
			//reasonDescriptionGridColumn
			//
			this.reasonDescriptionGridColumn.ColumnEdit = this.reasonDescriptionRepositoryItemGridLookUpEdit;
			this.reasonDescriptionGridColumn.FieldName = "Oid";
			this.reasonDescriptionGridColumn.Name = "reasonDescriptionGridColumn";
			this.reasonDescriptionGridColumn.Visible = true;
			this.reasonDescriptionGridColumn.VisibleIndex = 2;
			this.reasonDescriptionGridColumn.Width = 267;
			//
			//reasonDescriptionRepositoryItemGridLookUpEdit
			//
			this.reasonDescriptionRepositoryItemGridLookUpEdit.AutoHeight = false;
			this.reasonDescriptionRepositoryItemGridLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.reasonDescriptionRepositoryItemGridLookUpEdit.DataSource = this.reasonCodesXpView;
			this.reasonDescriptionRepositoryItemGridLookUpEdit.DisplayMember = "Description";
			this.reasonDescriptionRepositoryItemGridLookUpEdit.Name = "reasonDescriptionRepositoryItemGridLookUpEdit";
			this.reasonDescriptionRepositoryItemGridLookUpEdit.ValueMember = "Oid";
			this.reasonDescriptionRepositoryItemGridLookUpEdit.View = this.RepositoryItemGridLookUpEdit1View;
			//
			//reasonCodesXpView
			//
			this.reasonCodesXpView.ObjectType = typeof(DXDAL.SPGData.ReasonCodes);
			this.reasonCodesXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("Oid", DevExpress.Xpo.SortDirection.None, "[Oid]", false, true),
				new DevExpress.Xpo.ViewProperty("ReasonType", DevExpress.Xpo.SortDirection.Ascending, "[ReasonType]", false, true),
				new DevExpress.Xpo.ViewProperty("ReasonCode", DevExpress.Xpo.SortDirection.Ascending, "[ReasonCode]", false, true),
				new DevExpress.Xpo.ViewProperty("Description", DevExpress.Xpo.SortDirection.None, "[Description]", false, true)
			});
			//
			//RepositoryItemGridLookUpEdit1View
			//
			this.RepositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colReasonType, this.colReasonCode, this.colDescription});
			this.RepositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
			this.RepositoryItemGridLookUpEdit1View.Name = "RepositoryItemGridLookUpEdit1View";
			this.RepositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
			this.RepositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
			//
			//LabelControl2
			//
			this.LabelControl2.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.LabelControl2.Location = new System.Drawing.Point(507, 66);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(27, 13);
			this.LabelControl2.TabIndex = 22;
			this.LabelControl2.Text = "UOM:";
			//
			//uomTextEdit
			//
			this.uomTextEdit.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.uomTextEdit.Location = new System.Drawing.Point(506, 84);
			this.uomTextEdit.Name = "uomTextEdit";
			this.uomTextEdit.Properties.ReadOnly = true;
			this.uomTextEdit.Size = new System.Drawing.Size(100, 20);
			this.uomTextEdit.TabIndex = 21;
			//
			//descriptionMemoEdit
			//
			this.descriptionMemoEdit.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.descriptionMemoEdit.Location = new System.Drawing.Point(314, 42);
			this.descriptionMemoEdit.Name = "descriptionMemoEdit";
			this.descriptionMemoEdit.Properties.ReadOnly = true;
			this.descriptionMemoEdit.Size = new System.Drawing.Size(186, 106);
			this.descriptionMemoEdit.TabIndex = 11;
			this.descriptionMemoEdit.TabStop = false;
			//
			//saveSimpleButton
			//
			this.saveSimpleButton.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.saveSimpleButton.Location = new System.Drawing.Point(820, 125);
			this.saveSimpleButton.Name = "saveSimpleButton";
			this.saveSimpleButton.Size = new System.Drawing.Size(91, 23);
			this.saveSimpleButton.TabIndex = 18;
			this.saveSimpleButton.Text = "&Save Entry";
			//
			//editSimpleButton
			//
			this.editSimpleButton.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.editSimpleButton.Location = new System.Drawing.Point(723, 126);
			this.editSimpleButton.Name = "editSimpleButton";
			this.editSimpleButton.Size = new System.Drawing.Size(91, 23);
			this.editSimpleButton.TabIndex = 19;
			this.editSimpleButton.Text = "&Edit Entry";
			//
			//cancelSimpleButton
			//
			this.cancelSimpleButton.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.cancelSimpleButton.Location = new System.Drawing.Point(626, 125);
			this.cancelSimpleButton.Name = "cancelSimpleButton";
			this.cancelSimpleButton.Size = new System.Drawing.Size(91, 23);
			this.cancelSimpleButton.TabIndex = 20;
			this.cancelSimpleButton.Text = "Ca&ncel";
			//
			//LabelControl13
			//
			this.LabelControl13.Location = new System.Drawing.Point(160, 110);
			this.LabelControl13.Name = "LabelControl13";
			this.LabelControl13.Size = new System.Drawing.Size(51, 13);
			this.LabelControl13.TabIndex = 8;
			this.LabelControl13.Text = "Time Stop:";
			//
			//LabelControl12
			//
			this.LabelControl12.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.LabelControl12.Location = new System.Drawing.Point(506, 22);
			this.LabelControl12.Name = "LabelControl12";
			this.LabelControl12.Size = new System.Drawing.Size(46, 13);
			this.LabelControl12.TabIndex = 12;
			this.LabelControl12.Text = "Quantity:";
			//
			//LabelControl11
			//
			this.LabelControl11.Location = new System.Drawing.Point(5, 109);
			this.LabelControl11.Name = "LabelControl11";
			this.LabelControl11.Size = new System.Drawing.Size(53, 13);
			this.LabelControl11.TabIndex = 6;
			this.LabelControl11.Text = "Time Start:";
			//
			//LabelControl10
			//
			this.LabelControl10.Location = new System.Drawing.Point(6, 64);
			this.LabelControl10.Name = "LabelControl10";
			this.LabelControl10.Size = new System.Drawing.Size(65, 13);
			this.LabelControl10.TabIndex = 14;
			this.LabelControl10.Text = "Machine Line:";
			//
			//LabelControl8
			//
			this.LabelControl8.Location = new System.Drawing.Point(314, 23);
			this.LabelControl8.Name = "LabelControl8";
			this.LabelControl8.Size = new System.Drawing.Size(82, 13);
			this.LabelControl8.TabIndex = 10;
			this.LabelControl8.Text = "Item Description:";
			//
			//LabelControl7
			//
			this.LabelControl7.Location = new System.Drawing.Point(159, 23);
			this.LabelControl7.Name = "LabelControl7";
			this.LabelControl7.Size = new System.Drawing.Size(26, 13);
			this.LabelControl7.TabIndex = 4;
			this.LabelControl7.Text = "Shift:";
			//
			//packersTextEdit
			//
			this.packersTextEdit.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.packersTextEdit.Location = new System.Drawing.Point(506, 128);
			this.packersTextEdit.Name = "packersTextEdit";
			this.packersTextEdit.Size = new System.Drawing.Size(99, 20);
			this.packersTextEdit.TabIndex = 15;
			//
			//quantityTextEdit
			//
			this.quantityTextEdit.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.quantityTextEdit.Location = new System.Drawing.Point(506, 41);
			this.quantityTextEdit.Name = "quantityTextEdit";
			this.quantityTextEdit.Size = new System.Drawing.Size(100, 20);
			this.quantityTextEdit.TabIndex = 13;
			//
			//LabelControl5
			//
			this.LabelControl5.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right);
			this.LabelControl5.Location = new System.Drawing.Point(507, 110);
			this.LabelControl5.Name = "LabelControl5";
			this.LabelControl5.Size = new System.Drawing.Size(41, 13);
			this.LabelControl5.TabIndex = 16;
			this.LabelControl5.Text = "Packers:";
			//
			//stopTimeEdit
			//
			this.stopTimeEdit.EditValue = new DateTime(2007, 7, 30, 0, 0, 0, 0);
			this.stopTimeEdit.Location = new System.Drawing.Point(160, 129);
			this.stopTimeEdit.Name = "stopTimeEdit";
			this.stopTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton()});
			this.stopTimeEdit.Properties.DisplayFormat.FormatString = "t";
			this.stopTimeEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.stopTimeEdit.Properties.EditFormat.FormatString = "t";
			this.stopTimeEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.stopTimeEdit.Properties.Mask.EditMask = "t";
			this.stopTimeEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
			this.stopTimeEdit.Size = new System.Drawing.Size(148, 20);
			this.stopTimeEdit.TabIndex = 11;
			//
			//startTimeEdit
			//
			this.startTimeEdit.EditValue = new DateTime(2007, 7, 30, 0, 0, 0, 0);
			this.startTimeEdit.Location = new System.Drawing.Point(5, 128);
			this.startTimeEdit.Name = "startTimeEdit";
			this.startTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton()});
			this.startTimeEdit.Properties.DisplayFormat.FormatString = "t";
			this.startTimeEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.startTimeEdit.Properties.EditFormat.FormatString = "t";
			this.startTimeEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.startTimeEdit.Properties.Mask.EditMask = "t";
			this.startTimeEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
			this.startTimeEdit.Size = new System.Drawing.Size(149, 20);
			this.startTimeEdit.TabIndex = 9;
			//
			//LabelControl4
			//
			this.LabelControl4.Location = new System.Drawing.Point(160, 68);
			this.LabelControl4.Name = "LabelControl4";
			this.LabelControl4.Size = new System.Drawing.Size(37, 13);
			this.LabelControl4.TabIndex = 2;
			this.LabelControl4.Text = "Item #:";
			//
			//productionDateEdit
			//
			this.productionDateEdit.EditValue = null;
			this.productionDateEdit.Location = new System.Drawing.Point(5, 39);
			this.productionDateEdit.Name = "productionDateEdit";
			this.productionDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.productionDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton()});
			this.productionDateEdit.Properties.DisplayFormat.FormatString = "D";
			this.productionDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.productionDateEdit.Properties.EditFormat.FormatString = "D";
			this.productionDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.productionDateEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
			this.productionDateEdit.Size = new System.Drawing.Size(149, 20);
			this.productionDateEdit.TabIndex = 1;
			//
			//LabelControl1
			//
			this.LabelControl1.Location = new System.Drawing.Point(5, 23);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(27, 13);
			this.LabelControl1.TabIndex = 0;
			this.LabelControl1.Text = "Date:";
			//
			//itemLookUpEdit
			//
			this.itemLookUpEdit.Location = new System.Drawing.Point(160, 83);
			this.itemLookUpEdit.Name = "itemLookUpEdit";
			this.itemLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.itemLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 59, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCustomerID", "Item Customer ID", 95, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)
			});
			this.itemLookUpEdit.Properties.DataSource = this.itemsXPView;
			this.itemLookUpEdit.Properties.DisplayMember = "ItemCode";
			this.itemLookUpEdit.Properties.NullText = "[Select A Item]";
			this.itemLookUpEdit.Properties.ValueMember = "ItemID";
			this.itemLookUpEdit.Size = new System.Drawing.Size(148, 20);
			this.itemLookUpEdit.TabIndex = 7;
			//
			//itemsXPView
			//
			this.itemsXPView.CriteriaString = "([ItemType] = 'FG' Or [ItemType] = 'IG') And [Inactive] = False";
			this.itemsXPView.ObjectType = typeof(DXDAL.SPGData.Items);
			this.itemsXPView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[ItemID]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.Ascending, "[ItemCode]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemCustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID]", false, true)
			});
			//
			//shiftLookUpEdit
			//
			this.shiftLookUpEdit.Location = new System.Drawing.Point(159, 39);
			this.shiftLookUpEdit.Name = "shiftLookUpEdit";
			this.shiftLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.shiftLookUpEdit.Properties.NullText = "[Select A Shift]";
			this.shiftLookUpEdit.Size = new System.Drawing.Size(149, 20);
			this.shiftLookUpEdit.TabIndex = 3;
			//
			//machineLookUpEdit
			//
			this.machineLookUpEdit.Location = new System.Drawing.Point(6, 83);
			this.machineLookUpEdit.Name = "machineLookUpEdit";
			this.machineLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.machineLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Machine Name", "Machine Name", 79, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)
			});
			this.machineLookUpEdit.Properties.DataSource = this.machineLineXpView;
			this.machineLookUpEdit.Properties.DisplayMember = "Machine Name";
			this.machineLookUpEdit.Properties.NullText = "[Select A Machine]";
			this.machineLookUpEdit.Properties.ValueMember = "ID";
			this.machineLookUpEdit.Size = new System.Drawing.Size(148, 20);
			this.machineLookUpEdit.TabIndex = 5;
			//
			//machineLineXpView
			//
			this.machineLineXpView.ObjectType = typeof(DXDAL.SPGData.MachineLine);
			this.machineLineXpView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("ID", DevExpress.Xpo.SortDirection.None, "[MachineLineID]", false, true),
				new DevExpress.Xpo.ViewProperty("Machine Name", DevExpress.Xpo.SortDirection.Ascending, "[MachineLineName]", false, true)
			});
			//
			//filtersGroupControl
			//
			this.filtersGroupControl.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.filtersGroupControl.Controls.Add(this.filterSimpleButton);
			this.filtersGroupControl.Controls.Add(this.clearSimpleButton);
			this.filtersGroupControl.Controls.Add(this.LabelControl19);
			this.filtersGroupControl.Controls.Add(this.LabelControl18);
			this.filtersGroupControl.Controls.Add(this.LabelControl17);
			this.filtersGroupControl.Controls.Add(this.LabelControl16);
			this.filtersGroupControl.Controls.Add(this.machineFilterLookUpEdit);
			this.filtersGroupControl.Controls.Add(this.shiftFilterLookUpEdit);
			this.filtersGroupControl.Controls.Add(this.itemFilterLookUpEdit);
			this.filtersGroupControl.Controls.Add(this.customerFilterLookUpEdit);
			this.filtersGroupControl.Controls.Add(this.LabelControl15);
			this.filtersGroupControl.Controls.Add(this.LabelControl14);
			this.filtersGroupControl.Controls.Add(this.fromFilterDateEdit);
			this.filtersGroupControl.Controls.Add(this.toFilterDateEdit);
			this.filtersGroupControl.Location = new System.Drawing.Point(13, 173);
			this.filtersGroupControl.Name = "filtersGroupControl";
			this.filtersGroupControl.Size = new System.Drawing.Size(926, 96);
			this.filtersGroupControl.TabIndex = 1;
			this.filtersGroupControl.Text = "Filters and Display";
			//
			//filterSimpleButton
			//
			this.filterSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.filterSimpleButton.Location = new System.Drawing.Point(724, 58);
			this.filterSimpleButton.Name = "filterSimpleButton";
			this.filterSimpleButton.Size = new System.Drawing.Size(75, 23);
			this.filterSimpleButton.TabIndex = 12;
			this.filterSimpleButton.Text = "&Filter";
			//
			//clearSimpleButton
			//
			this.clearSimpleButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.clearSimpleButton.Location = new System.Drawing.Point(724, 29);
			this.clearSimpleButton.Name = "clearSimpleButton";
			this.clearSimpleButton.Size = new System.Drawing.Size(75, 23);
			this.clearSimpleButton.TabIndex = 13;
			this.clearSimpleButton.Text = "&Clear Filter";
			//
			//LabelControl19
			//
			this.LabelControl19.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LabelControl19.Location = new System.Drawing.Point(304, 35);
			this.LabelControl19.Name = "LabelControl19";
			this.LabelControl19.Size = new System.Drawing.Size(16, 13);
			this.LabelControl19.TabIndex = 2;
			this.LabelControl19.Text = "To:";
			//
			//LabelControl18
			//
			this.LabelControl18.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LabelControl18.Location = new System.Drawing.Point(508, 35);
			this.LabelControl18.Name = "LabelControl18";
			this.LabelControl18.Size = new System.Drawing.Size(43, 13);
			this.LabelControl18.TabIndex = 4;
			this.LabelControl18.Text = "Machine:";
			//
			//LabelControl17
			//
			this.LabelControl17.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LabelControl17.Location = new System.Drawing.Point(508, 64);
			this.LabelControl17.Name = "LabelControl17";
			this.LabelControl17.Size = new System.Drawing.Size(26, 13);
			this.LabelControl17.TabIndex = 10;
			this.LabelControl17.Text = "Shift:";
			//
			//LabelControl16
			//
			this.LabelControl16.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LabelControl16.Location = new System.Drawing.Point(304, 64);
			this.LabelControl16.Name = "LabelControl16";
			this.LabelControl16.Size = new System.Drawing.Size(26, 13);
			this.LabelControl16.TabIndex = 8;
			this.LabelControl16.Text = "Item:";
			//
			//machineFilterLookUpEdit
			//
			this.machineFilterLookUpEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.machineFilterLookUpEdit.Location = new System.Drawing.Point(557, 32);
			this.machineFilterLookUpEdit.Name = "machineFilterLookUpEdit";
			this.machineFilterLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.machineFilterLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.machineFilterLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 34, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Machine Name", "Machine Name", 79, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)
			});
			this.machineFilterLookUpEdit.Properties.DataSource = this.machineLineXpView;
			this.machineFilterLookUpEdit.Properties.DisplayMember = "Machine Name";
			this.machineFilterLookUpEdit.Properties.NullText = "[Select A Machine Line]";
			this.machineFilterLookUpEdit.Properties.ValueMember = "ID";
			this.machineFilterLookUpEdit.Size = new System.Drawing.Size(150, 20);
			this.machineFilterLookUpEdit.TabIndex = 5;
			this.machineFilterLookUpEdit.ToolTip = "Use Ctrl+Del to clear filter";
			//
			//shiftFilterLookUpEdit
			//
			this.shiftFilterLookUpEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.shiftFilterLookUpEdit.Location = new System.Drawing.Point(557, 58);
			this.shiftFilterLookUpEdit.Name = "shiftFilterLookUpEdit";
			this.shiftFilterLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.shiftFilterLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.shiftFilterLookUpEdit.Properties.NullText = "[Select A Shift]";
			this.shiftFilterLookUpEdit.Size = new System.Drawing.Size(150, 20);
			this.shiftFilterLookUpEdit.TabIndex = 11;
			this.shiftFilterLookUpEdit.ToolTip = "Use Ctrl+Del to clear filter";
			//
			//itemFilterLookUpEdit
			//
			this.itemFilterLookUpEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.itemFilterLookUpEdit.Location = new System.Drawing.Point(336, 61);
			this.itemFilterLookUpEdit.Name = "itemFilterLookUpEdit";
			this.itemFilterLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.itemFilterLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.itemFilterLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemID", "Item ID", 59, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCode", "Item Code", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemCustomerID", "Item Customer ID", 95, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far)
			});
			this.itemFilterLookUpEdit.Properties.DataSource = this.itemsFilterXPView;
			this.itemFilterLookUpEdit.Properties.DisplayMember = "ItemCode";
			this.itemFilterLookUpEdit.Properties.NullText = "[Select A Item]";
			this.itemFilterLookUpEdit.Properties.ValueMember = "ItemID";
			this.itemFilterLookUpEdit.Size = new System.Drawing.Size(150, 20);
			this.itemFilterLookUpEdit.TabIndex = 9;
			this.itemFilterLookUpEdit.ToolTip = "Use Ctrl+Del to clear filter";
			//
			//itemsFilterXPView
			//
			this.itemsFilterXPView.CriteriaString = "([ItemType] = 'FG' Or [ItemType] = 'IG') And [Inactive] = False";
			this.itemsFilterXPView.ObjectType = typeof(DXDAL.SPGData.Items);
			this.itemsFilterXPView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("ItemID", DevExpress.Xpo.SortDirection.None, "[ItemID]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.Ascending, "[ItemCode]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemCustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID]", false, true),
				new DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[ItemCustomerID.CustomerID]", false, true)
			});
			//
			//customerFilterLookUpEdit
			//
			this.customerFilterLookUpEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.customerFilterLookUpEdit.Location = new System.Drawing.Point(137, 61);
			this.customerFilterLookUpEdit.Name = "customerFilterLookUpEdit";
			this.customerFilterLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.customerFilterLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.customerFilterLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerID", "Customer ID", 83, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Customer Name", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Inactive", "Inactive", 49, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)
			});
			this.customerFilterLookUpEdit.Properties.DataSource = this.customersXPView;
			this.customerFilterLookUpEdit.Properties.DisplayMember = "CustomerName";
			this.customerFilterLookUpEdit.Properties.NullText = "[Select A Customer Name]";
			this.customerFilterLookUpEdit.Properties.ValueMember = "CustomerID";
			this.customerFilterLookUpEdit.Size = new System.Drawing.Size(150, 20);
			this.customerFilterLookUpEdit.TabIndex = 7;
			this.customerFilterLookUpEdit.ToolTip = "Use Ctrl+Del to clear filter";
			//
			//customersXPView
			//
			this.customersXPView.CriteriaString = "[Inactive] = False";
			this.customersXPView.ObjectType = typeof(DXDAL.SPGData.Customers);
			this.customersXPView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[CustomerID]", false, true),
				new DevExpress.Xpo.ViewProperty("CustomerName", DevExpress.Xpo.SortDirection.Ascending, "[CustomerName]", false, true),
				new DevExpress.Xpo.ViewProperty("Inactive", DevExpress.Xpo.SortDirection.None, "[Inactive]", false, true)
			});
			//
			//LabelControl15
			//
			this.LabelControl15.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LabelControl15.Location = new System.Drawing.Point(81, 64);
			this.LabelControl15.Name = "LabelControl15";
			this.LabelControl15.Size = new System.Drawing.Size(50, 13);
			this.LabelControl15.TabIndex = 6;
			this.LabelControl15.Text = "Customer:";
			//
			//LabelControl14
			//
			this.LabelControl14.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.LabelControl14.Location = new System.Drawing.Point(81, 35);
			this.LabelControl14.Name = "LabelControl14";
			this.LabelControl14.Size = new System.Drawing.Size(28, 13);
			this.LabelControl14.TabIndex = 0;
			this.LabelControl14.Text = "From:";
			//
			//fromFilterDateEdit
			//
			this.fromFilterDateEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.fromFilterDateEdit.EditValue = null;
			this.fromFilterDateEdit.Location = new System.Drawing.Point(137, 32);
			this.fromFilterDateEdit.Name = "fromFilterDateEdit";
			this.fromFilterDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.fromFilterDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.fromFilterDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton()});
			this.fromFilterDateEdit.Properties.DisplayFormat.FormatString = "D";
			this.fromFilterDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.fromFilterDateEdit.Properties.EditFormat.FormatString = "D";
			this.fromFilterDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.fromFilterDateEdit.Properties.NullText = "[Select A From Date]";
			this.fromFilterDateEdit.Size = new System.Drawing.Size(150, 20);
			this.fromFilterDateEdit.TabIndex = 1;
			//
			//toFilterDateEdit
			//
			this.toFilterDateEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.toFilterDateEdit.EditValue = null;
			this.toFilterDateEdit.Location = new System.Drawing.Point(336, 32);
			this.toFilterDateEdit.Name = "toFilterDateEdit";
			this.toFilterDateEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
			this.toFilterDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.toFilterDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton()});
			this.toFilterDateEdit.Properties.DisplayFormat.FormatString = "D";
			this.toFilterDateEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.toFilterDateEdit.Properties.EditFormat.FormatString = "D";
			this.toFilterDateEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.toFilterDateEdit.Properties.NullText = "[Select A To Date]";
			this.toFilterDateEdit.Size = new System.Drawing.Size(150, 20);
			this.toFilterDateEdit.TabIndex = 3;
			//
			//productionGridControl
			//
			this.productionGridControl.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.productionGridControl.DataSource = this.productionXPView;
			this.productionGridControl.Location = new System.Drawing.Point(13, 276);
			this.productionGridControl.MainView = this.productionGridView;
			this.productionGridControl.Name = "productionGridControl";
			this.productionGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {this.deleteRepositoryItemButtonEdit, this.RepositoryItemMemoEdit1});
			this.productionGridControl.Size = new System.Drawing.Size(926, 326);
			this.productionGridControl.TabIndex = 2;
			this.productionGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.productionGridView});
			//
			//productionXPView
			//
			this.productionXPView.ObjectType = typeof(DXDAL.SPGData.Production);
			this.productionXPView.Properties.AddRange(new DevExpress.Xpo.ViewProperty[]
			{
				new DevExpress.Xpo.ViewProperty("ProductionDate", DevExpress.Xpo.SortDirection.None, "[ProdMainDate]", false, true),
				new DevExpress.Xpo.ViewProperty("ProductionID", DevExpress.Xpo.SortDirection.None, "[ProdMainID]", false, true),
				new DevExpress.Xpo.ViewProperty("CustomerName", DevExpress.Xpo.SortDirection.None, "[ProdMainItemID.ItemCustomerID.CustomerName]", false, true),
				new DevExpress.Xpo.ViewProperty("ProductionMachineLine", DevExpress.Xpo.SortDirection.None, "[ProdMainMachineLine.MachineLineName]", false, true),
				new DevExpress.Xpo.ViewProperty("Quantity", DevExpress.Xpo.SortDirection.None, "[ProdMainQuantity]", false, true),
				new DevExpress.Xpo.ViewProperty("Shift", DevExpress.Xpo.SortDirection.None, "[ProdMainShift.ShiftName]", false, true),
				new DevExpress.Xpo.ViewProperty("TimeStart", DevExpress.Xpo.SortDirection.None, "[ProdMainTimeStart]", false, true),
				new DevExpress.Xpo.ViewProperty("TimeStop", DevExpress.Xpo.SortDirection.None, "[ProdMainTimeStop]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemCode", DevExpress.Xpo.SortDirection.None, "[ProdMainItemID.ItemCode]", false, true),
				new DevExpress.Xpo.ViewProperty("ItemDescription", DevExpress.Xpo.SortDirection.None, "[ProdMainItemID.ItemDescription]", false, true),
				new DevExpress.Xpo.ViewProperty("CustomerID", DevExpress.Xpo.SortDirection.None, "[ProdMainItemID.ItemCustomerID.CustomerID]", false, true),
				new DevExpress.Xpo.ViewProperty("Packers", DevExpress.Xpo.SortDirection.None, "[ProdMainPackers]", false, true)
			});
			//
			//productionGridView
			//
			this.productionGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.deleteGridColumn, this.idGridColumn, this.customerGridColumn, this.dateGridColumn, this.machineGridColumn, this.itemGridColumn, this.descriptionGridColumn, this.quantityGridColumn, this.startGridColumn, this.stopGridColumn, this.timeGridColumn, this.colPackers, this.colShift, this.colReasons});
			this.productionGridView.GridControl = this.productionGridControl;
			this.productionGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantity", this.quantityGridColumn, "{0:#,##0.######}")});
			this.productionGridView.Name = "productionGridView";
			this.productionGridView.OptionsFilter.UseNewCustomFilterDialog = true;
			//
			//deleteGridColumn
			//
			this.deleteGridColumn.ColumnEdit = this.deleteRepositoryItemButtonEdit;
			this.deleteGridColumn.Name = "deleteGridColumn";
			this.deleteGridColumn.OptionsColumn.AllowSize = false;
			this.deleteGridColumn.OptionsColumn.FixedWidth = true;
			this.deleteGridColumn.Visible = true;
			this.deleteGridColumn.VisibleIndex = 0;
			this.deleteGridColumn.Width = 22;
			//
			//deleteRepositoryItemButtonEdit
			//
			this.deleteRepositoryItemButtonEdit.AutoHeight = false;
			this.deleteRepositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
			this.deleteRepositoryItemButtonEdit.Name = "deleteRepositoryItemButtonEdit";
			this.deleteRepositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			//
			//idGridColumn
			//
			this.idGridColumn.Caption = "GridColumn1";
			this.idGridColumn.FieldName = "ProductionID";
			this.idGridColumn.Name = "idGridColumn";
			//
			//customerGridColumn
			//
			this.customerGridColumn.Caption = "Customer Name";
			this.customerGridColumn.FieldName = "CustomerName";
			this.customerGridColumn.Name = "customerGridColumn";
			this.customerGridColumn.OptionsColumn.AllowEdit = false;
			this.customerGridColumn.OptionsColumn.ReadOnly = true;
			this.customerGridColumn.Visible = true;
			this.customerGridColumn.VisibleIndex = 1;
			this.customerGridColumn.Width = 106;
			//
			//dateGridColumn
			//
			this.dateGridColumn.Caption = "Date";
			this.dateGridColumn.DisplayFormat.FormatString = "D";
			this.dateGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.dateGridColumn.FieldName = "ProductionDate";
			this.dateGridColumn.Name = "dateGridColumn";
			this.dateGridColumn.OptionsColumn.AllowEdit = false;
			this.dateGridColumn.OptionsColumn.ReadOnly = true;
			this.dateGridColumn.Visible = true;
			this.dateGridColumn.VisibleIndex = 2;
			this.dateGridColumn.Width = 91;
			//
			//machineGridColumn
			//
			this.machineGridColumn.Caption = "Machine";
			this.machineGridColumn.FieldName = "ProductionMachineLine";
			this.machineGridColumn.Name = "machineGridColumn";
			this.machineGridColumn.OptionsColumn.AllowEdit = false;
			this.machineGridColumn.OptionsColumn.ReadOnly = true;
			this.machineGridColumn.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.machineGridColumn.Visible = true;
			this.machineGridColumn.VisibleIndex = 4;
			this.machineGridColumn.Width = 88;
			//
			//itemGridColumn
			//
			this.itemGridColumn.Caption = "Item #";
			this.itemGridColumn.FieldName = "ItemCode";
			this.itemGridColumn.Name = "itemGridColumn";
			this.itemGridColumn.OptionsColumn.AllowEdit = false;
			this.itemGridColumn.OptionsColumn.ReadOnly = true;
			this.itemGridColumn.Visible = true;
			this.itemGridColumn.VisibleIndex = 5;
			this.itemGridColumn.Width = 80;
			//
			//descriptionGridColumn
			//
			this.descriptionGridColumn.Caption = "Item Description";
			this.descriptionGridColumn.FieldName = "ItemDescription";
			this.descriptionGridColumn.Name = "descriptionGridColumn";
			this.descriptionGridColumn.OptionsColumn.AllowEdit = false;
			this.descriptionGridColumn.OptionsColumn.ReadOnly = true;
			this.descriptionGridColumn.Visible = true;
			this.descriptionGridColumn.VisibleIndex = 6;
			this.descriptionGridColumn.Width = 96;
			//
			//quantityGridColumn
			//
			this.quantityGridColumn.Caption = "Quantity";
			this.quantityGridColumn.FieldName = "Quantity";
			this.quantityGridColumn.Name = "quantityGridColumn";
			this.quantityGridColumn.OptionsColumn.AllowEdit = false;
			this.quantityGridColumn.OptionsColumn.FixedWidth = true;
			this.quantityGridColumn.OptionsColumn.ReadOnly = true;
			this.quantityGridColumn.Visible = true;
			this.quantityGridColumn.VisibleIndex = 7;
			this.quantityGridColumn.Width = 60;
			//
			//startGridColumn
			//
			this.startGridColumn.Caption = "Start Time";
			this.startGridColumn.DisplayFormat.FormatString = "t";
			this.startGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.startGridColumn.FieldName = "TimeStart";
			this.startGridColumn.Name = "startGridColumn";
			this.startGridColumn.OptionsColumn.AllowEdit = false;
			this.startGridColumn.OptionsColumn.FixedWidth = true;
			this.startGridColumn.OptionsColumn.ReadOnly = true;
			this.startGridColumn.Visible = true;
			this.startGridColumn.VisibleIndex = 8;
			this.startGridColumn.Width = 59;
			//
			//stopGridColumn
			//
			this.stopGridColumn.Caption = "Stop Time";
			this.stopGridColumn.DisplayFormat.FormatString = "t";
			this.stopGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.stopGridColumn.FieldName = "TimeStop";
			this.stopGridColumn.Name = "stopGridColumn";
			this.stopGridColumn.OptionsColumn.AllowEdit = false;
			this.stopGridColumn.OptionsColumn.FixedWidth = true;
			this.stopGridColumn.OptionsColumn.ReadOnly = true;
			this.stopGridColumn.Visible = true;
			this.stopGridColumn.VisibleIndex = 9;
			this.stopGridColumn.Width = 57;
			//
			//timeGridColumn
			//
			this.timeGridColumn.Caption = "Total Time";
			this.timeGridColumn.FieldName = "timeGridColumn";
			this.timeGridColumn.Name = "timeGridColumn";
			this.timeGridColumn.OptionsColumn.AllowEdit = false;
			this.timeGridColumn.OptionsColumn.FixedWidth = true;
			this.timeGridColumn.OptionsColumn.ReadOnly = true;
			this.timeGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.String;
			this.timeGridColumn.Visible = true;
			this.timeGridColumn.VisibleIndex = 10;
			this.timeGridColumn.Width = 59;
			//
			//colPackers
			//
			this.colPackers.FieldName = "Packers";
			this.colPackers.Name = "colPackers";
			this.colPackers.Visible = true;
			this.colPackers.VisibleIndex = 11;
			//
			//colShift
			//
			this.colShift.FieldName = "Shift";
			this.colShift.Name = "colShift";
			this.colShift.OptionsColumn.AllowEdit = false;
			this.colShift.OptionsColumn.ReadOnly = true;
			this.colShift.Visible = true;
			this.colShift.VisibleIndex = 3;
			//
			//colReasons
			//
			this.colReasons.FieldName = "Reasons";
			this.colReasons.Name = "colReasons";
			this.colReasons.UnboundType = DevExpress.Data.UnboundColumnType.String;
			this.colReasons.Visible = true;
			this.colReasons.VisibleIndex = 12;
			//
			//RepositoryItemMemoEdit1
			//
			this.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1";
			//
			//GridColumn1
			//
			this.GridColumn1.Caption = "GridColumn1";
			this.GridColumn1.Name = "GridColumn1";
			//
			//reasonCodeGridColumn
			//
			this.reasonCodeGridColumn.Caption = "GridColumn2";
			this.reasonCodeGridColumn.ColumnEdit = this.reasonCodeRepositoryItemLookUpEdit1;
			this.reasonCodeGridColumn.FieldName = "Oid";
			this.reasonCodeGridColumn.Name = "reasonCodeGridColumn";
			this.reasonCodeGridColumn.Visible = true;
			this.reasonCodeGridColumn.VisibleIndex = 1;
			//
			//reasonCodeRepositoryItemLookUpEdit1
			//
			this.reasonCodeRepositoryItemLookUpEdit1.AutoHeight = false;
			this.reasonCodeRepositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.reasonCodeRepositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[]
			{
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Oid", "Oid", 39, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ReasonType", "Reason Type", 73, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ReasonCode", "Reason Code", 74, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
				new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)
			});
			this.reasonCodeRepositoryItemLookUpEdit1.DataSource = this.reasonCodesXpView;
			this.reasonCodeRepositoryItemLookUpEdit1.DisplayMember = "ReasonCode";
			this.reasonCodeRepositoryItemLookUpEdit1.Name = "reasonCodeRepositoryItemLookUpEdit1";
			this.reasonCodeRepositoryItemLookUpEdit1.ValueMember = "Oid";
			//
			//colReasonType
			//
			this.colReasonType.FieldName = "ReasonType";
			this.colReasonType.Name = "colReasonType";
			this.colReasonType.Visible = true;
			this.colReasonType.VisibleIndex = 0;
			//
			//colReasonCode
			//
			this.colReasonCode.FieldName = "ReasonCode";
			this.colReasonCode.Name = "colReasonCode";
			this.colReasonCode.Visible = true;
			this.colReasonCode.VisibleIndex = 1;
			//
			//colDescription
			//
			this.colDescription.FieldName = "Description";
			this.colDescription.Name = "colDescription";
			this.colDescription.Visible = true;
			this.colDescription.VisibleIndex = 2;
			//
			//ProductionXtraForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(951, 614);
			this.Controls.Add(this.productionGridControl);
			this.Controls.Add(this.filtersGroupControl);
			this.Controls.Add(this.recordGroupControl);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "ProductionXtraForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Production Cost";
			((System.ComponentModel.ISupportInitialize)this.recordGroupControl).EndInit();
			this.recordGroupControl.ResumeLayout(false);
			this.recordGroupControl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.reasonsGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.reasonsGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.deleteReasonRepositoryItemButtonEdit).EndInit();
			((System.ComponentModel.ISupportInitialize)this.reasonDescriptionRepositoryItemGridLookUpEdit).EndInit();
			((System.ComponentModel.ISupportInitialize)this.reasonCodesXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemGridLookUpEdit1View).EndInit();
			((System.ComponentModel.ISupportInitialize)this.uomTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.descriptionMemoEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.packersTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.quantityTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.stopTimeEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.startTimeEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionDateEdit.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionDateEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemsXPView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shiftLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.machineLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.machineLineXpView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.filtersGroupControl).EndInit();
			this.filtersGroupControl.ResumeLayout(false);
			this.filtersGroupControl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.machineFilterLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.shiftFilterLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemFilterLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.itemsFilterXPView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customerFilterLookUpEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.customersXPView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.fromFilterDateEdit.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.fromFilterDateEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.toFilterDateEdit.Properties.CalendarTimeProperties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.toFilterDateEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionXPView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.productionGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.deleteRepositoryItemButtonEdit).EndInit();
			((System.ComponentModel.ISupportInitialize)this.RepositoryItemMemoEdit1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.reasonCodeRepositoryItemLookUpEdit1).EndInit();
			this.ResumeLayout(false);

//INSTANT C# NOTE: Converted design-time event handler wireups:
		this.Activated += new System.EventHandler(ProductionXtraForm_Activated);
		this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(ProductionXtraForm_FormClosing);
		this.Load += new System.EventHandler(ProductionXtraForm_Load);
		itemLookUpEdit.Validated += new System.EventHandler(itemLookUpEdit_Validated);
		productionGridView.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(productionGridView_CustomUnboundColumnData);
		saveSimpleButton.Click += new System.EventHandler(saveSimpleButton_Click);
		editSimpleButton.Click += new System.EventHandler(editSimpleButton_Click);
		deleteRepositoryItemButtonEdit.Click += new System.EventHandler(deleteRepositoryItemButtonEdit_Click);
		customerFilterLookUpEdit.Validated += new System.EventHandler(customerFilterLookUpEdit_Validated);
		clearSimpleButton.Click += new System.EventHandler(clearSimpleButton_Click);
		filterSimpleButton.Click += new System.EventHandler(filterSimpleButton_Click);
		cancelSimpleButton.Click += new System.EventHandler(cancelSimpleButton_Click);
		shiftLookUpEdit.EditValueChanged += new System.EventHandler(shiftLookUpEdit_EditValueChanged);
		deleteReasonRepositoryItemButtonEdit.Click += new System.EventHandler(deleteReasonRepositoryItemButtonEdit_Click);
		reasonsGridControl.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(reasonsGridControl_ProcessGridKey);
	}
		internal DevExpress.XtraEditors.GroupControl recordGroupControl;
		internal DevExpress.XtraEditors.GroupControl filtersGroupControl;
		internal DevExpress.XtraGrid.GridControl productionGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView productionGridView;
		internal DevExpress.XtraEditors.LabelControl LabelControl13;
		internal DevExpress.XtraEditors.LabelControl LabelControl12;
		internal DevExpress.XtraEditors.LabelControl LabelControl11;
		internal DevExpress.XtraEditors.LabelControl LabelControl10;
		internal DevExpress.XtraEditors.LabelControl LabelControl8;
		internal DevExpress.XtraEditors.LabelControl LabelControl7;
		internal DevExpress.XtraEditors.TextEdit packersTextEdit;
		internal DevExpress.XtraEditors.TextEdit quantityTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl5;
		internal DevExpress.XtraEditors.TimeEdit stopTimeEdit;
		internal DevExpress.XtraEditors.TimeEdit startTimeEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		internal DevExpress.XtraEditors.DateEdit productionDateEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.LookUpEdit itemLookUpEdit;
		internal DevExpress.XtraEditors.LookUpEdit shiftLookUpEdit;
		internal DevExpress.XtraEditors.LookUpEdit machineLookUpEdit;
		internal DevExpress.XtraEditors.SimpleButton saveSimpleButton;
		internal DevExpress.XtraEditors.SimpleButton editSimpleButton;
		internal DevExpress.XtraEditors.SimpleButton cancelSimpleButton;
		internal DevExpress.XtraEditors.MemoEdit descriptionMemoEdit;
		internal DevExpress.XtraEditors.SimpleButton filterSimpleButton;
		internal DevExpress.XtraEditors.SimpleButton clearSimpleButton;
		internal DevExpress.XtraEditors.LabelControl LabelControl19;
		internal DevExpress.XtraEditors.LabelControl LabelControl18;
		internal DevExpress.XtraEditors.LabelControl LabelControl17;
		internal DevExpress.XtraEditors.LabelControl LabelControl16;
		internal DevExpress.XtraEditors.LookUpEdit machineFilterLookUpEdit;
		internal DevExpress.XtraEditors.LookUpEdit shiftFilterLookUpEdit;
		internal DevExpress.XtraEditors.LookUpEdit itemFilterLookUpEdit;
		internal DevExpress.XtraEditors.LookUpEdit customerFilterLookUpEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl15;
		internal DevExpress.XtraEditors.LabelControl LabelControl14;
		internal DevExpress.XtraEditors.DateEdit fromFilterDateEdit;
		internal DevExpress.XtraEditors.DateEdit toFilterDateEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn deleteGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit deleteRepositoryItemButtonEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn idGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn customerGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn dateGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn machineGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn itemGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn descriptionGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn quantityGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn startGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn stopGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn timeGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit RepositoryItemMemoEdit1;
		internal DevExpress.Xpo.XPView customersXPView;
		internal DevExpress.Xpo.XPView itemsFilterXPView;
		internal DevExpress.Xpo.XPView itemsXPView;
		internal DevExpress.Xpo.XPView productionXPView;
		internal DevExpress.XtraEditors.TextEdit uomTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraGrid.Columns.GridColumn colShift;
		internal DevExpress.Xpo.XPView machineLineXpView;
		internal DevExpress.XtraEditors.LabelControl LabelControl3;
		internal DevExpress.XtraGrid.GridControl reasonsGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView reasonsGridView;
		internal DevExpress.XtraGrid.Columns.GridColumn reasonDescriptionGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit reasonDescriptionRepositoryItemGridLookUpEdit;
		internal DevExpress.Xpo.XPView reasonCodesXpView;
		internal DevExpress.XtraGrid.Views.Grid.GridView RepositoryItemGridLookUpEdit1View;
		internal DevExpress.XtraGrid.Columns.GridColumn colReasons;
		internal DevExpress.XtraGrid.Columns.GridColumn GridColumn1;
		internal DevExpress.XtraGrid.Columns.GridColumn deleteReasonGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit deleteReasonRepositoryItemButtonEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn colPackers;
		internal DevExpress.XtraGrid.Columns.GridColumn reasonCodeGridColumn;
		internal DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit reasonCodeRepositoryItemLookUpEdit1;
		internal DevExpress.XtraGrid.Columns.GridColumn colReasonType;
		internal DevExpress.XtraGrid.Columns.GridColumn colReasonCode;
		internal DevExpress.XtraGrid.Columns.GridColumn colDescription;
	}

}