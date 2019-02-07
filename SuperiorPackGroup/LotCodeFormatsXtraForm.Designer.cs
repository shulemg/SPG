using System.Linq;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DXDAL;
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
	public partial class LotCodeFormatsXtraForm : DevExpress.XtraEditors.XtraForm
	{
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
				if (m_LotCodeSession != null)
				{
					m_LotCodeSession.Dispose();
					m_LotCodeSession = null;
				}
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
			DevExpress.XtraGrid.GridLevelNode GridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LotCodeFormatsXtraForm));
			this.lotCodeSectionSettingsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colSettingName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSettingValue = new DevExpress.XtraGrid.Columns.GridColumn();
			this.lotCodeSectionGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.lotCodeFormatSectionsGridControl = new DevExpress.XtraGrid.GridControl();
			this.lotCodeFormatSectionsXpCollection = new DevExpress.Xpo.XPCollection(this.components);
			this.lotCodeFormatSectionsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
			this.lotCodeFormatGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSectionName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSectionType = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSectionLength = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colSectionPosition = new DevExpress.XtraGrid.Columns.GridColumn();
			this.lotCodeFormatIDGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
			this.lotCodeSettingsGroupControl = new DevExpress.XtraEditors.GroupControl();
			this.lotCodeFormatPreviewGroupControl = new DevExpress.XtraEditors.GroupControl();
			this.sectionSettingsPanelControl = new DevExpress.XtraEditors.PanelControl();
			this.changePositionSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.deleteSettingsSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.cancelSettingsChangesSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.LabelControl18 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl17 = new DevExpress.XtraEditors.LabelControl();
			this.toSpinEdit = new DevExpress.XtraEditors.SpinEdit();
			this.fromSpinEdit = new DevExpress.XtraEditors.SpinEdit();
			this.LabelControl16 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl15 = new DevExpress.XtraEditors.LabelControl();
			this.restartsOnTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl14 = new DevExpress.XtraEditors.LabelControl();
			this.firstDayOfWeekImageComboBoxEdit = new DevExpress.XtraEditors.ImageComboBoxEdit();
			this.LabelControl13 = new DevExpress.XtraEditors.LabelControl();
			this.firstWeekOfYearImageComboBoxEdit = new DevExpress.XtraEditors.ImageComboBoxEdit();
			this.firstYearTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl12 = new DevExpress.XtraEditors.LabelControl();
			this.replacementLettersTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl11 = new DevExpress.XtraEditors.LabelControl();
			this.lettersToReplaceTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.LabelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.lettersToSkipTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.saveSettingsSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.editSettingsSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.LabelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.sectionPositionSpinEdit = new DevExpress.XtraEditors.SpinEdit();
			this.sectionLengthSpinEdit = new DevExpress.XtraEditors.SpinEdit();
			this.LabelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.sectionTypeImageComboBoxEdit = new DevExpress.XtraEditors.ImageComboBoxEdit();
			this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.sectionNameTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.firstMonthComboBoxEdit = new DevExpress.XtraEditors.ComboBoxEdit();
			this.PanelControl1 = new DevExpress.XtraEditors.PanelControl();
			this.cancelFormatChangesSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.editLotCodeFormatSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.newLotCodeFormatSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.deleteFormatSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.saveFormatSimpleButton = new DevExpress.XtraEditors.SimpleButton();
			this.formatWarningLabelControl = new DevExpress.XtraEditors.LabelControl();
			this.formatSectionsSpinEdit = new DevExpress.XtraEditors.SpinEdit();
			this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.formatNameTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)this.lotCodeSectionSettingsGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.lotCodeFormatSectionsGridControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.lotCodeFormatSectionsXpCollection).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.lotCodeFormatSectionsGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.lotCodeSettingsGroupControl).BeginInit();
			this.lotCodeSettingsGroupControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.lotCodeFormatPreviewGroupControl).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.sectionSettingsPanelControl).BeginInit();
			this.sectionSettingsPanelControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.toSpinEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.fromSpinEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.restartsOnTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.firstDayOfWeekImageComboBoxEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.firstWeekOfYearImageComboBoxEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.firstYearTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.replacementLettersTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.lettersToReplaceTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.lettersToSkipTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.sectionPositionSpinEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.sectionLengthSpinEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.sectionTypeImageComboBoxEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.sectionNameTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.firstMonthComboBoxEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.PanelControl1).BeginInit();
			this.PanelControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.formatSectionsSpinEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.formatNameTextEdit.Properties).BeginInit();
			this.SuspendLayout();
			//
			//lotCodeSectionSettingsGridView
			//
			this.lotCodeSectionSettingsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colSettingName, this.colSettingValue, this.lotCodeSectionGridColumn});
			this.lotCodeSectionSettingsGridView.GridControl = this.lotCodeFormatSectionsGridControl;
			this.lotCodeSectionSettingsGridView.Name = "lotCodeSectionSettingsGridView";
			//
			//colSettingName
			//
			this.colSettingName.FieldName = "SettingName";
			this.colSettingName.Name = "colSettingName";
			this.colSettingName.Visible = true;
			this.colSettingName.VisibleIndex = 0;
			//
			//colSettingValue
			//
			this.colSettingValue.FieldName = "SettingValue";
			this.colSettingValue.Name = "colSettingValue";
			this.colSettingValue.Visible = true;
			this.colSettingValue.VisibleIndex = 1;
			//
			//lotCodeSectionGridColumn
			//
			this.lotCodeSectionGridColumn.FieldName = "LotCodeSection!";
			this.lotCodeSectionGridColumn.Name = "lotCodeSectionGridColumn";
			//
			//lotCodeFormatSectionsGridControl
			//
			this.lotCodeFormatSectionsGridControl.DataSource = this.lotCodeFormatSectionsXpCollection;
			GridLevelNode1.LevelTemplate = this.lotCodeSectionSettingsGridView;
			GridLevelNode1.RelationName = "SectionSettings";
			this.lotCodeFormatSectionsGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {GridLevelNode1});
			this.lotCodeFormatSectionsGridControl.Location = new System.Drawing.Point(13, 339);
			this.lotCodeFormatSectionsGridControl.MainView = this.lotCodeFormatSectionsGridView;
			this.lotCodeFormatSectionsGridControl.Name = "lotCodeFormatSectionsGridControl";
			this.lotCodeFormatSectionsGridControl.ShowOnlyPredefinedDetails = true;
			this.lotCodeFormatSectionsGridControl.Size = new System.Drawing.Size(1109, 290);
			this.lotCodeFormatSectionsGridControl.TabIndex = 2;
			this.lotCodeFormatSectionsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {this.lotCodeFormatSectionsGridView, this.lotCodeSectionSettingsGridView});
			//
			//lotCodeFormatSectionsXpCollection
			//
			this.lotCodeFormatSectionsXpCollection.ObjectType = typeof(DXDAL.SPGData.LotCodeFormatSections);
			//
			//lotCodeFormatSectionsGridView
			//
			this.lotCodeFormatSectionsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {this.colOid, this.lotCodeFormatGridColumn, this.colSectionName, this.colSectionType, this.colSectionLength, this.colSectionPosition, this.lotCodeFormatIDGridColumn});
			this.lotCodeFormatSectionsGridView.GridControl = this.lotCodeFormatSectionsGridControl;
			this.lotCodeFormatSectionsGridView.GroupCount = 1;
			this.lotCodeFormatSectionsGridView.Name = "lotCodeFormatSectionsGridView";
			this.lotCodeFormatSectionsGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.lotCodeFormatGridColumn, DevExpress.Data.ColumnSortOrder.Ascending)});
			//
			//colOid
			//
			this.colOid.FieldName = "Oid";
			this.colOid.Name = "colOid";
			//
			//lotCodeFormatGridColumn
			//
			this.lotCodeFormatGridColumn.Caption = "Lot Code Format";
			this.lotCodeFormatGridColumn.FieldName = "LotCodeFormat.FormatName";
			this.lotCodeFormatGridColumn.Name = "lotCodeFormatGridColumn";
			this.lotCodeFormatGridColumn.Visible = true;
			this.lotCodeFormatGridColumn.VisibleIndex = 0;
			//
			//colSectionName
			//
			this.colSectionName.FieldName = "SectionName";
			this.colSectionName.Name = "colSectionName";
			this.colSectionName.Visible = true;
			this.colSectionName.VisibleIndex = 0;
			//
			//colSectionType
			//
			this.colSectionType.FieldName = "SectionType";
			this.colSectionType.Name = "colSectionType";
			this.colSectionType.Visible = true;
			this.colSectionType.VisibleIndex = 1;
			//
			//colSectionLength
			//
			this.colSectionLength.FieldName = "SectionLength";
			this.colSectionLength.Name = "colSectionLength";
			this.colSectionLength.Visible = true;
			this.colSectionLength.VisibleIndex = 2;
			//
			//colSectionPosition
			//
			this.colSectionPosition.FieldName = "SectionPosition";
			this.colSectionPosition.Name = "colSectionPosition";
			this.colSectionPosition.Visible = true;
			this.colSectionPosition.VisibleIndex = 3;
			//
			//lotCodeFormatIDGridColumn
			//
			this.lotCodeFormatIDGridColumn.FieldName = "LotCodeFormat!Key";
			this.lotCodeFormatIDGridColumn.Name = "lotCodeFormatIDGridColumn";
			this.lotCodeFormatIDGridColumn.Visible = true;
			this.lotCodeFormatIDGridColumn.VisibleIndex = 4;
			//
			//lotCodeSettingsGroupControl
			//
			this.lotCodeSettingsGroupControl.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.lotCodeSettingsGroupControl.Controls.Add(this.lotCodeFormatPreviewGroupControl);
			this.lotCodeSettingsGroupControl.Controls.Add(this.sectionSettingsPanelControl);
			this.lotCodeSettingsGroupControl.Controls.Add(this.PanelControl1);
			this.lotCodeSettingsGroupControl.Location = new System.Drawing.Point(12, 12);
			this.lotCodeSettingsGroupControl.Name = "lotCodeSettingsGroupControl";
			this.lotCodeSettingsGroupControl.Size = new System.Drawing.Size(1110, 321);
			this.lotCodeSettingsGroupControl.TabIndex = 0;
			this.lotCodeSettingsGroupControl.Text = "Lot Code Format Settings";
			//
			//lotCodeFormatPreviewGroupControl
			//
			this.lotCodeFormatPreviewGroupControl.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.lotCodeFormatPreviewGroupControl.Location = new System.Drawing.Point(212, 215);
			this.lotCodeFormatPreviewGroupControl.Name = "lotCodeFormatPreviewGroupControl";
			this.lotCodeFormatPreviewGroupControl.Size = new System.Drawing.Size(893, 100);
			this.lotCodeFormatPreviewGroupControl.TabIndex = 2;
			this.lotCodeFormatPreviewGroupControl.Text = "Lot Code Format Preview";
			//
			//sectionSettingsPanelControl
			//
			this.sectionSettingsPanelControl.Controls.Add(this.changePositionSimpleButton);
			this.sectionSettingsPanelControl.Controls.Add(this.deleteSettingsSimpleButton);
			this.sectionSettingsPanelControl.Controls.Add(this.cancelSettingsChangesSimpleButton);
			this.sectionSettingsPanelControl.Controls.Add(this.LabelControl18);
			this.sectionSettingsPanelControl.Controls.Add(this.LabelControl17);
			this.sectionSettingsPanelControl.Controls.Add(this.toSpinEdit);
			this.sectionSettingsPanelControl.Controls.Add(this.fromSpinEdit);
			this.sectionSettingsPanelControl.Controls.Add(this.LabelControl16);
			this.sectionSettingsPanelControl.Controls.Add(this.LabelControl15);
			this.sectionSettingsPanelControl.Controls.Add(this.restartsOnTextEdit);
			this.sectionSettingsPanelControl.Controls.Add(this.LabelControl14);
			this.sectionSettingsPanelControl.Controls.Add(this.firstDayOfWeekImageComboBoxEdit);
			this.sectionSettingsPanelControl.Controls.Add(this.LabelControl13);
			this.sectionSettingsPanelControl.Controls.Add(this.firstWeekOfYearImageComboBoxEdit);
			this.sectionSettingsPanelControl.Controls.Add(this.firstYearTextEdit);
			this.sectionSettingsPanelControl.Controls.Add(this.LabelControl12);
			this.sectionSettingsPanelControl.Controls.Add(this.replacementLettersTextEdit);
			this.sectionSettingsPanelControl.Controls.Add(this.LabelControl11);
			this.sectionSettingsPanelControl.Controls.Add(this.lettersToReplaceTextEdit);
			this.sectionSettingsPanelControl.Controls.Add(this.LabelControl10);
			this.sectionSettingsPanelControl.Controls.Add(this.LabelControl9);
			this.sectionSettingsPanelControl.Controls.Add(this.lettersToSkipTextEdit);
			this.sectionSettingsPanelControl.Controls.Add(this.LabelControl8);
			this.sectionSettingsPanelControl.Controls.Add(this.saveSettingsSimpleButton);
			this.sectionSettingsPanelControl.Controls.Add(this.editSettingsSimpleButton);
			this.sectionSettingsPanelControl.Controls.Add(this.LabelControl7);
			this.sectionSettingsPanelControl.Controls.Add(this.sectionPositionSpinEdit);
			this.sectionSettingsPanelControl.Controls.Add(this.sectionLengthSpinEdit);
			this.sectionSettingsPanelControl.Controls.Add(this.LabelControl6);
			this.sectionSettingsPanelControl.Controls.Add(this.sectionTypeImageComboBoxEdit);
			this.sectionSettingsPanelControl.Controls.Add(this.LabelControl5);
			this.sectionSettingsPanelControl.Controls.Add(this.sectionNameTextEdit);
			this.sectionSettingsPanelControl.Controls.Add(this.LabelControl4);
			this.sectionSettingsPanelControl.Controls.Add(this.firstMonthComboBoxEdit);
			this.sectionSettingsPanelControl.Location = new System.Drawing.Point(212, 24);
			this.sectionSettingsPanelControl.Name = "sectionSettingsPanelControl";
			this.sectionSettingsPanelControl.Size = new System.Drawing.Size(893, 185);
			this.sectionSettingsPanelControl.TabIndex = 1;
			//
			//changePositionSimpleButton
			//
			this.changePositionSimpleButton.Appearance.Options.UseTextOptions = true;
			this.changePositionSimpleButton.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.changePositionSimpleButton.Location = new System.Drawing.Point(54, 130);
			this.changePositionSimpleButton.Name = "changePositionSimpleButton";
			this.changePositionSimpleButton.Size = new System.Drawing.Size(85, 50);
			this.changePositionSimpleButton.TabIndex = 34;
			this.changePositionSimpleButton.Text = "Change Position";
			//
			//deleteSettingsSimpleButton
			//
			this.deleteSettingsSimpleButton.Appearance.Options.UseTextOptions = true;
			this.deleteSettingsSimpleButton.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.deleteSettingsSimpleButton.Location = new System.Drawing.Point(418, 130);
			this.deleteSettingsSimpleButton.Name = "deleteSettingsSimpleButton";
			this.deleteSettingsSimpleButton.Size = new System.Drawing.Size(85, 50);
			this.deleteSettingsSimpleButton.TabIndex = 33;
			this.deleteSettingsSimpleButton.Text = "Delete Section Settings";
			//
			//cancelSettingsChangesSimpleButton
			//
			this.cancelSettingsChangesSimpleButton.Appearance.Options.UseTextOptions = true;
			this.cancelSettingsChangesSimpleButton.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.cancelSettingsChangesSimpleButton.Location = new System.Drawing.Point(327, 130);
			this.cancelSettingsChangesSimpleButton.Name = "cancelSettingsChangesSimpleButton";
			this.cancelSettingsChangesSimpleButton.Size = new System.Drawing.Size(85, 50);
			this.cancelSettingsChangesSimpleButton.TabIndex = 32;
			this.cancelSettingsChangesSimpleButton.Text = "Cancel Changes";
			//
			//LabelControl18
			//
			this.LabelControl18.Location = new System.Drawing.Point(562, 16);
			this.LabelControl18.Name = "LabelControl18";
			this.LabelControl18.Size = new System.Drawing.Size(54, 13);
			this.LabelControl18.TabIndex = 30;
			this.LabelControl18.Text = "First Month";
			//
			//LabelControl17
			//
			this.LabelControl17.Location = new System.Drawing.Point(734, 145);
			this.LabelControl17.Name = "LabelControl17";
			this.LabelControl17.Size = new System.Drawing.Size(10, 13);
			this.LabelControl17.TabIndex = 29;
			this.LabelControl17.Text = "to";
			//
			//toSpinEdit
			//
			this.toSpinEdit.EditValue = new decimal(new int[] {99, 0, 0, 0});
			this.toSpinEdit.Location = new System.Drawing.Point(750, 142);
			this.toSpinEdit.Name = "toSpinEdit";
			this.toSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.toSpinEdit.Size = new System.Drawing.Size(72, 20);
			this.toSpinEdit.TabIndex = 28;
			//
			//fromSpinEdit
			//
			this.fromSpinEdit.EditValue = new decimal(new int[] {11, 0, 0, 0});
			this.fromSpinEdit.Location = new System.Drawing.Point(657, 142);
			this.fromSpinEdit.Name = "fromSpinEdit";
			this.fromSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.fromSpinEdit.Size = new System.Drawing.Size(71, 20);
			this.fromSpinEdit.TabIndex = 27;
			//
			//LabelControl16
			//
			this.LabelControl16.Location = new System.Drawing.Point(562, 145);
			this.LabelControl16.Name = "LabelControl16";
			this.LabelControl16.Size = new System.Drawing.Size(71, 13);
			this.LabelControl16.TabIndex = 26;
			this.LabelControl16.Text = "Number Range";
			//
			//LabelControl15
			//
			this.LabelControl15.Location = new System.Drawing.Point(562, 118);
			this.LabelControl15.Name = "LabelControl15";
			this.LabelControl15.Size = new System.Drawing.Size(77, 13);
			this.LabelControl15.TabIndex = 25;
			this.LabelControl15.Text = "Restarts On the";
			//
			//restartsOnTextEdit
			//
			this.restartsOnTextEdit.Location = new System.Drawing.Point(657, 115);
			this.restartsOnTextEdit.Name = "restartsOnTextEdit";
			this.restartsOnTextEdit.Size = new System.Drawing.Size(165, 20);
			this.restartsOnTextEdit.TabIndex = 24;
			//
			//LabelControl14
			//
			this.LabelControl14.Location = new System.Drawing.Point(562, 92);
			this.LabelControl14.Name = "LabelControl14";
			this.LabelControl14.Size = new System.Drawing.Size(86, 13);
			this.LabelControl14.TabIndex = 23;
			this.LabelControl14.Text = "First Day of Week";
			//
			//firstDayOfWeekImageComboBoxEdit
			//
			this.firstDayOfWeekImageComboBoxEdit.Location = new System.Drawing.Point(657, 89);
			this.firstDayOfWeekImageComboBoxEdit.Name = "firstDayOfWeekImageComboBoxEdit";
			this.firstDayOfWeekImageComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.firstDayOfWeekImageComboBoxEdit.Size = new System.Drawing.Size(165, 20);
			this.firstDayOfWeekImageComboBoxEdit.TabIndex = 22;
			//
			//LabelControl13
			//
			this.LabelControl13.Location = new System.Drawing.Point(562, 68);
			this.LabelControl13.Name = "LabelControl13";
			this.LabelControl13.Size = new System.Drawing.Size(89, 13);
			this.LabelControl13.TabIndex = 21;
			this.LabelControl13.Text = "First Week of Year";
			//
			//firstWeekOfYearImageComboBoxEdit
			//
			this.firstWeekOfYearImageComboBoxEdit.Location = new System.Drawing.Point(657, 65);
			this.firstWeekOfYearImageComboBoxEdit.Name = "firstWeekOfYearImageComboBoxEdit";
			this.firstWeekOfYearImageComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.firstWeekOfYearImageComboBoxEdit.Size = new System.Drawing.Size(165, 20);
			this.firstWeekOfYearImageComboBoxEdit.TabIndex = 20;
			//
			//firstYearTextEdit
			//
			this.firstYearTextEdit.Location = new System.Drawing.Point(657, 39);
			this.firstYearTextEdit.Name = "firstYearTextEdit";
			this.firstYearTextEdit.Size = new System.Drawing.Size(165, 20);
			this.firstYearTextEdit.TabIndex = 19;
			//
			//LabelControl12
			//
			this.LabelControl12.Location = new System.Drawing.Point(562, 40);
			this.LabelControl12.Name = "LabelControl12";
			this.LabelControl12.Size = new System.Drawing.Size(46, 13);
			this.LabelControl12.TabIndex = 18;
			this.LabelControl12.Text = "First Year";
			//
			//replacementLettersTextEdit
			//
			this.replacementLettersTextEdit.Location = new System.Drawing.Point(363, 96);
			this.replacementLettersTextEdit.Name = "replacementLettersTextEdit";
			this.replacementLettersTextEdit.Size = new System.Drawing.Size(183, 20);
			this.replacementLettersTextEdit.TabIndex = 17;
			//
			//LabelControl11
			//
			this.LabelControl11.Location = new System.Drawing.Point(258, 99);
			this.LabelControl11.Name = "LabelControl11";
			this.LabelControl11.Size = new System.Drawing.Size(99, 13);
			this.LabelControl11.TabIndex = 16;
			this.LabelControl11.Text = "Replacement Letters";
			//
			//lettersToReplaceTextEdit
			//
			this.lettersToReplaceTextEdit.Location = new System.Drawing.Point(363, 70);
			this.lettersToReplaceTextEdit.Name = "lettersToReplaceTextEdit";
			this.lettersToReplaceTextEdit.Size = new System.Drawing.Size(183, 20);
			this.lettersToReplaceTextEdit.TabIndex = 15;
			//
			//LabelControl10
			//
			this.LabelControl10.Location = new System.Drawing.Point(258, 73);
			this.LabelControl10.Name = "LabelControl10";
			this.LabelControl10.Size = new System.Drawing.Size(88, 13);
			this.LabelControl10.TabIndex = 14;
			this.LabelControl10.Text = "Letters to Replace";
			//
			//LabelControl9
			//
			this.LabelControl9.Location = new System.Drawing.Point(258, 12);
			this.LabelControl9.Name = "LabelControl9";
			this.LabelControl9.Size = new System.Drawing.Size(288, 26);
			this.LabelControl9.TabIndex = 13;
			this.LabelControl9.Text = "Enter a list of letters separated with a comma, the letters to " + "\r" + "\n" + "replace and repl"+
		"acement letters should be in the same order";
			//
			//lettersToSkipTextEdit
			//
			this.lettersToSkipTextEdit.Location = new System.Drawing.Point(363, 44);
			this.lettersToSkipTextEdit.Name = "lettersToSkipTextEdit";
			this.lettersToSkipTextEdit.Size = new System.Drawing.Size(183, 20);
			this.lettersToSkipTextEdit.TabIndex = 12;
			this.lettersToSkipTextEdit.ToolTip = "Enter the letters separated with a comma";
			//
			//LabelControl8
			//
			this.LabelControl8.Location = new System.Drawing.Point(258, 49);
			this.LabelControl8.Name = "LabelControl8";
			this.LabelControl8.Size = new System.Drawing.Size(69, 13);
			this.LabelControl8.TabIndex = 11;
			this.LabelControl8.Text = "Letters to Skip";
			//
			//saveSettingsSimpleButton
			//
			this.saveSettingsSimpleButton.Appearance.Options.UseTextOptions = true;
			this.saveSettingsSimpleButton.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.saveSettingsSimpleButton.Location = new System.Drawing.Point(236, 130);
			this.saveSettingsSimpleButton.Name = "saveSettingsSimpleButton";
			this.saveSettingsSimpleButton.Size = new System.Drawing.Size(85, 50);
			this.saveSettingsSimpleButton.TabIndex = 9;
			this.saveSettingsSimpleButton.Text = "Save Section Settings";
			//
			//editSettingsSimpleButton
			//
			this.editSettingsSimpleButton.Appearance.Options.UseTextOptions = true;
			this.editSettingsSimpleButton.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
			this.editSettingsSimpleButton.Location = new System.Drawing.Point(145, 130);
			this.editSettingsSimpleButton.Name = "editSettingsSimpleButton";
			this.editSettingsSimpleButton.Size = new System.Drawing.Size(85, 50);
			this.editSettingsSimpleButton.TabIndex = 8;
			this.editSettingsSimpleButton.Text = "Edit Section Settings";
			//
			//LabelControl7
			//
			this.LabelControl7.Location = new System.Drawing.Point(21, 21);
			this.LabelControl7.Name = "LabelControl7";
			this.LabelControl7.Size = new System.Drawing.Size(75, 13);
			this.LabelControl7.TabIndex = 7;
			this.LabelControl7.Text = "Section Position";
			//
			//sectionPositionSpinEdit
			//
			this.sectionPositionSpinEdit.EditValue = new decimal(new int[] {1, 0, 0, 0});
			this.sectionPositionSpinEdit.Location = new System.Drawing.Point(102, 18);
			this.sectionPositionSpinEdit.Name = "sectionPositionSpinEdit";
			this.sectionPositionSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.sectionPositionSpinEdit.Properties.MaxValue = new decimal(new int[] {50, 0, 0, 0});
			this.sectionPositionSpinEdit.Properties.MinValue = new decimal(new int[] {1, 0, 0, 0});
			this.sectionPositionSpinEdit.Size = new System.Drawing.Size(149, 20);
			this.sectionPositionSpinEdit.TabIndex = 6;
			//
			//sectionLengthSpinEdit
			//
			this.sectionLengthSpinEdit.EditValue = new decimal(new int[] {1, 0, 0, 0});
			this.sectionLengthSpinEdit.Location = new System.Drawing.Point(102, 96);
			this.sectionLengthSpinEdit.Name = "sectionLengthSpinEdit";
			this.sectionLengthSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.sectionLengthSpinEdit.Properties.MaxValue = new decimal(new int[] {15, 0, 0, 0});
			this.sectionLengthSpinEdit.Properties.MinValue = new decimal(new int[] {1, 0, 0, 0});
			this.sectionLengthSpinEdit.Size = new System.Drawing.Size(149, 20);
			this.sectionLengthSpinEdit.TabIndex = 5;
			//
			//LabelControl6
			//
			this.LabelControl6.Location = new System.Drawing.Point(21, 99);
			this.LabelControl6.Name = "LabelControl6";
			this.LabelControl6.Size = new System.Drawing.Size(71, 13);
			this.LabelControl6.TabIndex = 4;
			this.LabelControl6.Text = "Section Length";
			//
			//sectionTypeImageComboBoxEdit
			//
			this.sectionTypeImageComboBoxEdit.Location = new System.Drawing.Point(102, 70);
			this.sectionTypeImageComboBoxEdit.Name = "sectionTypeImageComboBoxEdit";
			this.sectionTypeImageComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.sectionTypeImageComboBoxEdit.Size = new System.Drawing.Size(149, 20);
			this.sectionTypeImageComboBoxEdit.TabIndex = 3;
			//
			//LabelControl5
			//
			this.LabelControl5.Location = new System.Drawing.Point(21, 73);
			this.LabelControl5.Name = "LabelControl5";
			this.LabelControl5.Size = new System.Drawing.Size(62, 13);
			this.LabelControl5.TabIndex = 2;
			this.LabelControl5.Text = "Section Type";
			//
			//sectionNameTextEdit
			//
			this.sectionNameTextEdit.Location = new System.Drawing.Point(102, 44);
			this.sectionNameTextEdit.Name = "sectionNameTextEdit";
			this.sectionNameTextEdit.Size = new System.Drawing.Size(149, 20);
			this.sectionNameTextEdit.TabIndex = 1;
			//
			//LabelControl4
			//
			this.LabelControl4.Location = new System.Drawing.Point(21, 47);
			this.LabelControl4.Name = "LabelControl4";
			this.LabelControl4.Size = new System.Drawing.Size(65, 13);
			this.LabelControl4.TabIndex = 0;
			this.LabelControl4.Text = "Section Name";
			//
			//firstMonthComboBoxEdit
			//
			this.firstMonthComboBoxEdit.Location = new System.Drawing.Point(657, 13);
			this.firstMonthComboBoxEdit.Name = "firstMonthComboBoxEdit";
			this.firstMonthComboBoxEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.firstMonthComboBoxEdit.Properties.Items.AddRange(new object[] {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"});
			this.firstMonthComboBoxEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.firstMonthComboBoxEdit.Size = new System.Drawing.Size(165, 20);
			this.firstMonthComboBoxEdit.TabIndex = 31;
			//
			//PanelControl1
			//
			this.PanelControl1.Controls.Add(this.cancelFormatChangesSimpleButton);
			this.PanelControl1.Controls.Add(this.editLotCodeFormatSimpleButton);
			this.PanelControl1.Controls.Add(this.newLotCodeFormatSimpleButton);
			this.PanelControl1.Controls.Add(this.deleteFormatSimpleButton);
			this.PanelControl1.Controls.Add(this.saveFormatSimpleButton);
			this.PanelControl1.Controls.Add(this.formatWarningLabelControl);
			this.PanelControl1.Controls.Add(this.formatSectionsSpinEdit);
			this.PanelControl1.Controls.Add(this.LabelControl2);
			this.PanelControl1.Controls.Add(this.formatNameTextEdit);
			this.PanelControl1.Controls.Add(this.LabelControl1);
			this.PanelControl1.Location = new System.Drawing.Point(5, 23);
			this.PanelControl1.Name = "PanelControl1";
			this.PanelControl1.Size = new System.Drawing.Size(200, 292);
			this.PanelControl1.TabIndex = 0;
			//
			//cancelFormatChangesSimpleButton
			//
			this.cancelFormatChangesSimpleButton.Location = new System.Drawing.Point(32, 235);
			this.cancelFormatChangesSimpleButton.Name = "cancelFormatChangesSimpleButton";
			this.cancelFormatChangesSimpleButton.Size = new System.Drawing.Size(130, 23);
			this.cancelFormatChangesSimpleButton.TabIndex = 9;
			this.cancelFormatChangesSimpleButton.Text = "Cancel Changes";
			//
			//editLotCodeFormatSimpleButton
			//
			this.editLotCodeFormatSimpleButton.Location = new System.Drawing.Point(32, 176);
			this.editLotCodeFormatSimpleButton.Name = "editLotCodeFormatSimpleButton";
			this.editLotCodeFormatSimpleButton.Size = new System.Drawing.Size(130, 23);
			this.editLotCodeFormatSimpleButton.TabIndex = 8;
			this.editLotCodeFormatSimpleButton.Text = "Edit Lot Code Format";
			//
			//newLotCodeFormatSimpleButton
			//
			this.newLotCodeFormatSimpleButton.Location = new System.Drawing.Point(32, 147);
			this.newLotCodeFormatSimpleButton.Name = "newLotCodeFormatSimpleButton";
			this.newLotCodeFormatSimpleButton.Size = new System.Drawing.Size(130, 23);
			this.newLotCodeFormatSimpleButton.TabIndex = 7;
			this.newLotCodeFormatSimpleButton.Text = "New Lot Code Format";
			//
			//deleteFormatSimpleButton
			//
			this.deleteFormatSimpleButton.Location = new System.Drawing.Point(32, 264);
			this.deleteFormatSimpleButton.Name = "deleteFormatSimpleButton";
			this.deleteFormatSimpleButton.Size = new System.Drawing.Size(130, 23);
			this.deleteFormatSimpleButton.TabIndex = 6;
			this.deleteFormatSimpleButton.Text = "Delete Lot Code Format";
			//
			//saveFormatSimpleButton
			//
			this.saveFormatSimpleButton.Location = new System.Drawing.Point(32, 205);
			this.saveFormatSimpleButton.Name = "saveFormatSimpleButton";
			this.saveFormatSimpleButton.Size = new System.Drawing.Size(130, 23);
			this.saveFormatSimpleButton.TabIndex = 5;
			this.saveFormatSimpleButton.Text = "Save Lot Code Format";
			//
			//formatWarningLabelControl
			//
			this.formatWarningLabelControl.Appearance.BackColor = System.Drawing.Color.Red;
			this.formatWarningLabelControl.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.formatWarningLabelControl.Appearance.ForeColor = System.Drawing.Color.White;
			this.formatWarningLabelControl.Location = new System.Drawing.Point(32, 128);
			this.formatWarningLabelControl.Name = "formatWarningLabelControl";
			this.formatWarningLabelControl.Size = new System.Drawing.Size(137, 13);
			this.formatWarningLabelControl.TabIndex = 4;
			this.formatWarningLabelControl.Text = "Missing Section Settings";
			//
			//formatSectionsSpinEdit
			//
			this.formatSectionsSpinEdit.EditValue = new decimal(new int[] {1, 0, 0, 0});
			this.formatSectionsSpinEdit.Location = new System.Drawing.Point(50, 101);
			this.formatSectionsSpinEdit.Name = "formatSectionsSpinEdit";
			this.formatSectionsSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.formatSectionsSpinEdit.Properties.MaxValue = new decimal(new int[] {15, 0, 0, 0});
			this.formatSectionsSpinEdit.Properties.MinValue = new decimal(new int[] {1, 0, 0, 0});
			this.formatSectionsSpinEdit.Size = new System.Drawing.Size(100, 20);
			this.formatSectionsSpinEdit.TabIndex = 3;
			//
			//LabelControl2
			//
			this.LabelControl2.Location = new System.Drawing.Point(39, 81);
			this.LabelControl2.Name = "LabelControl2";
			this.LabelControl2.Size = new System.Drawing.Size(123, 13);
			this.LabelControl2.TabIndex = 2;
			this.LabelControl2.Text = "Lot Code Format Sections";
			//
			//formatNameTextEdit
			//
			this.formatNameTextEdit.Location = new System.Drawing.Point(5, 54);
			this.formatNameTextEdit.Name = "formatNameTextEdit";
			this.formatNameTextEdit.Size = new System.Drawing.Size(190, 20);
			this.formatNameTextEdit.TabIndex = 1;
			//
			//LabelControl1
			//
			this.LabelControl1.Location = new System.Drawing.Point(45, 34);
			this.LabelControl1.Name = "LabelControl1";
			this.LabelControl1.Size = new System.Drawing.Size(110, 13);
			this.LabelControl1.TabIndex = 0;
			this.LabelControl1.Text = "Lot Code Format Name";
			//
			//LotCodeFormatsXtraForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1134, 641);
			this.Controls.Add(this.lotCodeFormatSectionsGridControl);
			this.Controls.Add(this.lotCodeSettingsGroupControl);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.Name = "LotCodeFormatsXtraForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lot Code Formats";
			((System.ComponentModel.ISupportInitialize)this.lotCodeSectionSettingsGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.lotCodeFormatSectionsGridControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.lotCodeFormatSectionsXpCollection).EndInit();
			((System.ComponentModel.ISupportInitialize)this.lotCodeFormatSectionsGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)this.lotCodeSettingsGroupControl).EndInit();
			this.lotCodeSettingsGroupControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.lotCodeFormatPreviewGroupControl).EndInit();
			((System.ComponentModel.ISupportInitialize)this.sectionSettingsPanelControl).EndInit();
			this.sectionSettingsPanelControl.ResumeLayout(false);
			this.sectionSettingsPanelControl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.toSpinEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.fromSpinEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.restartsOnTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.firstDayOfWeekImageComboBoxEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.firstWeekOfYearImageComboBoxEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.firstYearTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.replacementLettersTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.lettersToReplaceTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.lettersToSkipTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.sectionPositionSpinEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.sectionLengthSpinEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.sectionTypeImageComboBoxEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.sectionNameTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.firstMonthComboBoxEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.PanelControl1).EndInit();
			this.PanelControl1.ResumeLayout(false);
			this.PanelControl1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.formatSectionsSpinEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)this.formatNameTextEdit.Properties).EndInit();
			this.ResumeLayout(false);

//INSTANT C# NOTE: Converted design-time event handler wireups:
		cancelFormatChangesSimpleButton.Click += new System.EventHandler(cancelFormatChangesSimpleButton_Click);
		cancelSettingsChangesSimpleButton.Click += new System.EventHandler(cancelSettingsChangesSimpleButton_Click);
		changePositionSimpleButton.Click += new System.EventHandler(changePositionSimpleButton_Click);
		deleteFormatSimpleButton.Click += new System.EventHandler(deleteFormatSimpleButton_Click);
		deleteSettingsSimpleButton.Click += new System.EventHandler(deleteSettingsSimpleButton_Click);
		editLotCodeFormatSimpleButton.Click += new System.EventHandler(editLotCodeFormatSimpleButton_Click);
		editSettingsSimpleButton.Click += new System.EventHandler(editSettingsSimpleButton_Click);
		this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(LotCodeFormatsXtraForm_FormClosing);
		base.Load += new System.EventHandler(LotCodeFormatsXtraForm_Load);
		newLotCodeFormatSimpleButton.Click += new System.EventHandler(newLotCodeFormatSimpleButton_Click);
		saveFormatSimpleButton.Click += new System.EventHandler(saveFormatSimpleButton_Click);
		saveSettingsSimpleButton.Click += new System.EventHandler(saveSettingsSimpleButton_Click);
		sectionPositionSpinEdit.EditValueChanged += new System.EventHandler(sectionPositionSpinEdit_EditValueChanged);
		sectionTypeImageComboBoxEdit.SelectedIndexChanged += new System.EventHandler(sectionTypeImageComboBoxEdit_SelectedIndexChanged);
	}

		internal DevExpress.XtraEditors.GroupControl lotCodeSettingsGroupControl;
		internal DevExpress.XtraGrid.GridControl lotCodeFormatSectionsGridControl;
		internal DevExpress.XtraGrid.Views.Grid.GridView lotCodeSectionSettingsGridView;
		internal DevExpress.XtraGrid.Views.Grid.GridView lotCodeFormatSectionsGridView;
		internal DevExpress.XtraEditors.PanelControl PanelControl1;
		internal DevExpress.XtraEditors.TextEdit formatNameTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl1;
		internal DevExpress.XtraEditors.SpinEdit formatSectionsSpinEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl2;
		internal DevExpress.XtraEditors.LabelControl formatWarningLabelControl;
		internal DevExpress.XtraEditors.PanelControl sectionSettingsPanelControl;
		internal DevExpress.XtraEditors.SimpleButton saveFormatSimpleButton;
		internal DevExpress.XtraEditors.LabelControl LabelControl4;
		internal DevExpress.XtraEditors.TextEdit sectionNameTextEdit;
		internal DevExpress.XtraEditors.ImageComboBoxEdit sectionTypeImageComboBoxEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl5;
		internal DevExpress.XtraEditors.SpinEdit sectionLengthSpinEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl6;
		internal DevExpress.XtraEditors.LabelControl LabelControl7;
		internal DevExpress.XtraEditors.SpinEdit sectionPositionSpinEdit;
		internal DevExpress.XtraEditors.SimpleButton saveSettingsSimpleButton;
		internal DevExpress.XtraEditors.SimpleButton editSettingsSimpleButton;
		internal DevExpress.XtraEditors.LabelControl LabelControl8;
		internal DevExpress.XtraEditors.TextEdit lettersToSkipTextEdit;
		internal DevExpress.XtraEditors.TextEdit replacementLettersTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl11;
		internal DevExpress.XtraEditors.TextEdit lettersToReplaceTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl10;
		internal DevExpress.XtraEditors.LabelControl LabelControl9;
		internal DevExpress.XtraEditors.TextEdit firstYearTextEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl12;
		internal DevExpress.XtraEditors.ImageComboBoxEdit firstWeekOfYearImageComboBoxEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl14;
		internal DevExpress.XtraEditors.ImageComboBoxEdit firstDayOfWeekImageComboBoxEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl13;
		internal DevExpress.XtraEditors.LabelControl LabelControl18;
		internal DevExpress.XtraEditors.LabelControl LabelControl17;
		internal DevExpress.XtraEditors.SpinEdit toSpinEdit;
		internal DevExpress.XtraEditors.SpinEdit fromSpinEdit;
		internal DevExpress.XtraEditors.LabelControl LabelControl16;
		internal DevExpress.XtraEditors.LabelControl LabelControl15;
		internal DevExpress.XtraEditors.TextEdit restartsOnTextEdit;
		internal DevExpress.XtraGrid.Columns.GridColumn colSettingName;
		internal DevExpress.XtraGrid.Columns.GridColumn colSettingValue;
		internal DevExpress.Xpo.XPCollection lotCodeFormatSectionsXpCollection;
		internal DevExpress.XtraGrid.Columns.GridColumn colOid;
		internal DevExpress.XtraGrid.Columns.GridColumn lotCodeFormatGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn colSectionName;
		internal DevExpress.XtraGrid.Columns.GridColumn colSectionType;
		internal DevExpress.XtraGrid.Columns.GridColumn colSectionLength;
		internal DevExpress.XtraGrid.Columns.GridColumn colSectionPosition;
		internal DevExpress.XtraEditors.SimpleButton cancelSettingsChangesSimpleButton;
		internal DevExpress.XtraEditors.SimpleButton deleteSettingsSimpleButton;
		internal DevExpress.XtraEditors.SimpleButton deleteFormatSimpleButton;
		internal DevExpress.XtraEditors.GroupControl lotCodeFormatPreviewGroupControl;
		internal DevExpress.XtraEditors.SimpleButton newLotCodeFormatSimpleButton;
		internal DevExpress.XtraEditors.SimpleButton editLotCodeFormatSimpleButton;
		internal DevExpress.XtraEditors.SimpleButton cancelFormatChangesSimpleButton;
		internal DevExpress.XtraGrid.Columns.GridColumn lotCodeFormatIDGridColumn;
		internal DevExpress.XtraGrid.Columns.GridColumn lotCodeSectionGridColumn;
		internal DevExpress.XtraEditors.ComboBoxEdit firstMonthComboBoxEdit;
		internal DevExpress.XtraEditors.SimpleButton changePositionSimpleButton;
	}

}