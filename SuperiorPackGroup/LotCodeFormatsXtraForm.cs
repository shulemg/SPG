//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using System.Linq;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DXDAL;
using DXDAL.SPGData;

namespace SuperiorPackGroup
{
	public partial class LotCodeFormatsXtraForm
	{

		public LotCodeFormatsXtraForm()
		{
			InitializeComponent();
		}

		private LotCodeFormats m_CurrentLotCodeFormat;
		private LotCodeFormatSections m_CurrentLotCodeSection;
		private LotCodeSectionSettings m_CurrentLotCodeSectionSettings;
		private Session m_LotCodeSession;

		private void cancelFormatChangesSimpleButton_Click(object sender, EventArgs e)
		{

			if (cancelFormatChangesSimpleButton.Tag.ToString() == "New Format" && MessageBox.Show("Do you want to delete the new Lot Code Format?", "Cancel New Format", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				return;
			}

			CancelFormatChanges();
			CheckPermissions();

			lotCodeFormatSectionsXpCollection.Reload();
			lotCodeFormatSectionsGridControl.Refresh();
			lotCodeFormatSectionsGridControl.Enabled = true;

			cancelFormatChangesSimpleButton.Enabled = false;
			saveFormatSimpleButton.Enabled = false;

		}

		private void cancelSettingsChangesSimpleButton_Click(object sender, EventArgs e)
		{

			CancelSettingChanges();
			CheckPermissions();

			lotCodeFormatSectionsGridControl.Enabled = true;
			Utilities.MakeFormReadOnly(sectionSettingsPanelControl, true);
			sectionPositionSpinEdit.ReadOnly = false;

			cancelSettingsChangesSimpleButton.Enabled = false;
			saveSettingsSimpleButton.Enabled = false;

		}

		private void changePositionSimpleButton_Click(object sender, EventArgs e)
		{

			sectionPositionSpinEdit.Tag = "Changing Position";
			sectionPositionSpinEdit.ReadOnly = false;

		}

		private void deleteFormatSimpleButton_Click(object sender, EventArgs e)
		{

			DialogResult continueDelete = 0;
			if (m_CurrentLotCodeFormat == null)
			{
				return;
			}
			if ((
				from customersFormat in m_LotCodeSession.Query<Customers>()
				where customersFormat.DefaultLotCodeFormat.Oid == m_CurrentLotCodeFormat.Oid
				select customersFormat.CustomerID).Any() || (
				from itemsFormat in m_LotCodeSession.Query<Items>()
				where itemsFormat.DefaultLotCodeFormat.Oid == m_CurrentLotCodeFormat.Oid
				select itemsFormat.ItemID).Any())
			{
				continueDelete = MessageBox.Show("This Lot Code Format is used as a default format, are you sure you want to delete this Lot Code Format?", "Delete Lot Code Format", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
			}
			else
			{
				continueDelete = MessageBox.Show("Are you sure you want to delete this Lot Code Format?", "Delete Lot Code Format", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
			}

			if (continueDelete == DialogResult.No)
			{
				return;
			}

			m_CurrentLotCodeFormat.Delete();

			if (m_CurrentLotCodeFormat.IsDeleted)
			{
				m_CurrentLotCodeFormat = null;
				m_CurrentLotCodeSectionSettings = null;
				sectionSettingsPanelControl.Enabled = false;
				lotCodeFormatPreviewGroupControl.Enabled = false;
				formatNameTextEdit.EditValue = null;
				formatSectionsSpinEdit.EditValue = 1;
				formatWarningLabelControl.Visible = false;
				PrepareNewLotCodeSection(null);

				CheckPermissions();
				lotCodeFormatSectionsXpCollection.Reload();

				sectionSettingsPanelControl.Enabled = false;
				lotCodeFormatPreviewGroupControl.Enabled = false;
				cancelFormatChangesSimpleButton.Enabled = false;
				saveFormatSimpleButton.Enabled = false;
			}
			else
			{
				MessageBox.Show("The Lot Code Format was not deleted.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void deleteSettingsSimpleButton_Click(object sender, EventArgs e)
		{

			bool removeSection = false;
			IQueryable<LotCodeFormatSections> laterSections = from LaterSection in m_LotCodeSession.Query<LotCodeFormatSections>()
				where LaterSection.LotCodeFormat.Oid == m_CurrentLotCodeFormat.Oid && LaterSection.SectionPosition >= sectionPositionSpinEdit.Value
				select LaterSection;

			if (MessageBox.Show("Are you sure you want to delete the settings for this Section?", "Delete Section Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
			{
				return;
			}
			else
			{
				if (deleteSettingsSimpleButton.Tag.ToString() != "RemoveSection")
				{
					if (MessageBox.Show("Do you want to remove the section?", "Remove Section", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						removeSection = true;
					}
				}
				else
				{
					removeSection = true;
				}
			}


			if (removeSection)
			{
				m_CurrentLotCodeSection.Delete();
				if (m_CurrentLotCodeSection.IsDeleted)
				{
					foreach (LotCodeFormatSections CodeSection in laterSections)
					{
						CodeSection.SectionPosition -= 1;
						CodeSection.Save();
					}
					if (laterSections.Count() > 0)
					{
						PrepareNewLotCodeSection((int?)sectionPositionSpinEdit.Value);
					}
					else if (sectionPositionSpinEdit.Value > 1M)
					{
						PrepareNewLotCodeSection((int?)(sectionPositionSpinEdit.Value - 1));
					}
					else
					{
						PrepareNewLotCodeSection(1);
					}
					MessageBox.Show("The section was successfully removed.");
				}
				else
				{
					MessageBox.Show("The section was not deleted", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				PrepareNewLotCodeSection((int?)sectionPositionSpinEdit.Value);
			}

			lotCodeFormatSectionsGridControl.Enabled = true;
			Utilities.MakeFormReadOnly(sectionSettingsPanelControl, true);
			sectionPositionSpinEdit.ReadOnly = false;

			cancelSettingsChangesSimpleButton.Enabled = false;
			saveSettingsSimpleButton.Enabled = false;

		}

		private void editLotCodeFormatSimpleButton_Click(object sender, EventArgs e)
		{

			if (m_CurrentLotCodeFormat == null)
			{
				if (lotCodeFormatSectionsGridView.IsValidRowHandle(lotCodeFormatSectionsGridView.FocusedRowHandle))
				{
					BindLotCodeFormat(Convert.ToInt32(lotCodeFormatSectionsGridView.GetFocusedRowCellValue(lotCodeFormatIDGridColumn)));
				}
				else
				{
					MessageBox.Show("Please select a code format to edit.");
					return;
				}
			}

			cancelFormatChangesSimpleButton.Tag = "Editing Format";
			sectionSettingsPanelControl.Enabled = true;
			formatNameTextEdit.ReadOnly = false;
			formatSectionsSpinEdit.ReadOnly = false;
			Utilities.MakeFormReadOnly(sectionSettingsPanelControl, true);
			sectionPositionSpinEdit.ReadOnly = false;
			lotCodeFormatSectionsGridControl.Enabled = false;

			CheckPermissions();
			cancelFormatChangesSimpleButton.Enabled = true;
			saveFormatSimpleButton.Enabled = true;
			editLotCodeFormatSimpleButton.Enabled = false;
			newLotCodeFormatSimpleButton.Enabled = false;

		}

		private void editSettingsSimpleButton_Click(object sender, EventArgs e)
		{

			if (m_CurrentLotCodeSection == null)
			{
				if (sectionLengthSpinEdit.EditValue == null)
				{
					MessageBox.Show("Please select a format section to edit.");
					return;
				}
				else
				{
					PrepareNewLotCodeSection((int?)sectionPositionSpinEdit.Value);
				}
			}

			sectionPositionSpinEdit.Tag = "Editing Position";
			lotCodeFormatSectionsGridControl.Enabled = false;
			Utilities.MakeFormReadOnly(sectionSettingsPanelControl, false);
			sectionPositionSpinEdit.ReadOnly = true;

			CheckPermissions();
			cancelSettingsChangesSimpleButton.Enabled = true;
			saveSettingsSimpleButton.Enabled = true;
			editSettingsSimpleButton.Enabled = false;

		}

		private void LotCodeFormatsXtraForm_FormClosing(object sender, FormClosingEventArgs e)
		{

			if (lotCodeFormatSectionsGridControl.Enabled == false)
			{
				switch (MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
				{
					case DialogResult.Cancel:
						e.Cancel = true;
						break;
					case DialogResult.Yes:
						if (saveFormatSimpleButton.Enabled)
						{
							if (SaveLotCodeFormat() == false)
							{
								e.Cancel = true;
							}
						}
						else
						{
							if (SaveSectionSettings())
							{
								e.Cancel = true;
							}
						}
						break;
					case DialogResult.No:
						if (cancelFormatChangesSimpleButton.Enabled)
						{
							CancelFormatChanges();
						}
						else
						{
							CancelSettingChanges();
						}
						break;
				}
			}

			if (e.Cancel == false)
			{
				m_LotCodeSession.PurgeDeletedObjects();
			}

		}

		private void LotCodeFormatsXtraForm_Load(object sender, EventArgs e)
		{

			Cursor = Cursors.WaitCursor;

			CheckPermissions();
			m_LotCodeSession = new Session(MyDataLayers.SPGDataLayer);
			lotCodeFormatSectionsXpCollection.Session = m_LotCodeSession;
			lotCodeFormatSectionsXpCollection.Reload();

			sectionTypeImageComboBoxEdit.Properties.Items.AddEnum<LotCodeSectionType>();
			firstWeekOfYearImageComboBoxEdit.Properties.Items.AddEnum<Microsoft.VisualBasic.FirstWeekOfYear>();
			firstDayOfWeekImageComboBoxEdit.Properties.Items.AddEnum<Microsoft.VisualBasic.FirstDayOfWeek>();

			sectionSettingsPanelControl.Enabled = false;
			lotCodeFormatPreviewGroupControl.Enabled = false;
			formatNameTextEdit.ReadOnly = true;
			formatSectionsSpinEdit.ReadOnly = true;
			formatWarningLabelControl.Visible = false;
			PrepareNewLotCodeSection(null);

			CheckPermissions();
			cancelFormatChangesSimpleButton.Enabled = false;
			saveFormatSimpleButton.Enabled = false;
			editLotCodeFormatSimpleButton.Enabled = true;
			newLotCodeFormatSimpleButton.Enabled = true;
			lotCodeFormatSectionsGridControl.Enabled = true;

			Cursor = Cursors.Default;

		}

		private void newLotCodeFormatSimpleButton_Click(object sender, EventArgs e)
		{

			m_CurrentLotCodeFormat = new LotCodeFormats(m_LotCodeSession);
			cancelFormatChangesSimpleButton.Tag = "New Format";
			m_CurrentLotCodeSection = null;
			m_CurrentLotCodeSectionSettings = null;

			sectionSettingsPanelControl.Enabled = false;
			lotCodeFormatPreviewGroupControl.Enabled = false;
			formatNameTextEdit.EditValue = null;
			formatSectionsSpinEdit.EditValue = 1;
			formatWarningLabelControl.Visible = false;
			formatNameTextEdit.ReadOnly = false;

			formatSectionsSpinEdit.ReadOnly = false;
			PrepareNewLotCodeSection(null);

			CheckPermissions();
			cancelFormatChangesSimpleButton.Enabled = true;
			saveFormatSimpleButton.Enabled = true;
			editLotCodeFormatSimpleButton.Enabled = false;
			newLotCodeFormatSimpleButton.Enabled = false;
			lotCodeFormatSectionsGridControl.Enabled = false;

		}

		private void saveFormatSimpleButton_Click(object sender, EventArgs e)
		{

			if (ValidateCodeFormatRecord())
			{
				try
				{
					if (SaveLotCodeFormat())
					{
						sectionSettingsPanelControl.Enabled = true;
						lotCodeFormatPreviewGroupControl.Enabled = true;
						formatNameTextEdit.ReadOnly = true;
						formatSectionsSpinEdit.ReadOnly = true;

						CheckPermissions();
						cancelFormatChangesSimpleButton.Enabled = false;
						saveFormatSimpleButton.Enabled = false;

                        //Dim SavedSectionSettings = Aggregate SavedSettings In m_LotCodeSession.Query(Of LotCodeFormatSections)
                        //                           Where SavedSettings.LotCodeFormat.Oid = m_CurrentLotCodeFormat.Oid                                               
                        //                           Into SavedSettingsCount = Count(), MaxPosition = Max(SavedSettings.SectionPosition)




                        int SavedSettingsCount = m_LotCodeSession.Query<LotCodeFormatSections>().Where((S) => S.LotCodeFormat.Oid == m_CurrentLotCodeFormat.Oid).Count();
                        int MaxSavedPosition = (SavedSettingsCount > 0) ? m_LotCodeSession.Query<LotCodeFormatSections>().Where((S) => S.LotCodeFormat.Oid == m_CurrentLotCodeFormat.Oid).Max((S) => S.SectionPosition) : 0;

						if (SavedSettingsCount < formatSectionsSpinEdit.Value)
						{
							formatWarningLabelControl.Text = "Missing Section Settings";
							formatWarningLabelControl.Visible = true;
							PrepareNewLotCodeSection(1);
							deleteSettingsSimpleButton.Tag = string.Empty;
						}
						else if (SavedSettingsCount > formatSectionsSpinEdit.Value || MaxSavedPosition > SavedSettingsCount)
						{
							formatWarningLabelControl.Text = "Excess Section Settings";
							formatWarningLabelControl.Visible = true;
							PrepareNewLotCodeSection(MaxSavedPosition);
							deleteSettingsSimpleButton.Tag = "RemoveSection";
						}
						else
						{
							lotCodeFormatSectionsGridControl.Enabled = true;
							formatWarningLabelControl.Visible = false;
							deleteSettingsSimpleButton.Tag = string.Empty;
						}

						lotCodeFormatSectionsXpCollection.Reload();
						cancelFormatChangesSimpleButton.Tag = string.Empty;
					}
					else
					{
						MessageBox.Show("There was an error while trying to save the current record, no changes were saved.");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(string.Format("There was an error while trying to save the current record.{0}{1}", Environment.NewLine, ex.Message));
				}
			}

		}

		private void saveSettingsSimpleButton_Click(object sender, EventArgs e)
		{

			if (ValidateSectionSettingsRecord())
			{
				try
				{
					if (SaveSectionSettings())
					{
						Utilities.MakeFormReadOnly(sectionSettingsPanelControl, true);
						sectionPositionSpinEdit.ReadOnly = false;

						CheckPermissions();
						cancelSettingsChangesSimpleButton.Enabled = false;
						saveSettingsSimpleButton.Enabled = false;




                        //                 Dim SavedSectionSettings = Aggregate SavedSettings In m_LotCodeSession.Query(Of LotCodeFormatSections)
                        //                                        Where SavedSettings.LotCodeFormat.Oid = m_CurrentLotCodeFormat.Oid
                        //                                        Into SavedSettingsCount = Count(), MaxPosition = Max(SavedSettings.SectionPosition)


                        //                 var SavedSectionSettings = Let SavedSettingsCount = (
                        //from SavedSettings in m_LotCodeSession.Query<LotCodeFormatSections> ()
                        //where SavedSettings.LotCodeFormat.Oid == m_CurrentLotCodeFormat.Oid
                        //select SavedSettings).Count(), MaxPosition = Max(SavedSettings.SectionPosition);


                        int SavedSettingsCount = m_LotCodeSession.Query<LotCodeFormatSections>().Where((S) => S.LotCodeFormat.Oid == m_CurrentLotCodeFormat.Oid).Count();
                        int MaxSavedPosition = (SavedSettingsCount > 0) ? m_LotCodeSession.Query<LotCodeFormatSections>().Where((S) => S.LotCodeFormat.Oid == m_CurrentLotCodeFormat.Oid).Max((S) => S.SectionPosition) : 0;


                        if (SavedSettingsCount == formatSectionsSpinEdit.Value && MaxSavedPosition == SavedSettingsCount)
                        {
                            lotCodeFormatSectionsGridControl.Enabled = true;
                        }

                        lotCodeFormatSectionsXpCollection.Reload();
						sectionPositionSpinEdit.Tag = string.Empty;
					}
					else
					{
						MessageBox.Show("There was an error while trying to save the current record.");
					}
				}
				catch (Exception ex)
				{
					 MessageBox.Show(string.Format("There was an error while trying to save the current record.{0}{1}", Environment.NewLine, ex.Message));
				}
			}

		}

		private void sectionPositionSpinEdit_EditValueChanged(object sender, EventArgs e)
		{

			if (IsInitializing == false && (cancelFormatChangesSimpleButton.Tag == null || cancelFormatChangesSimpleButton.Tag.ToString() != "New Format") && (sectionPositionSpinEdit.Tag == null || sectionPositionSpinEdit.Tag.ToString() != "Changing Position"))
			{
				PrepareNewLotCodeSection((int?)sectionPositionSpinEdit.Value);
			}

		}

		private void sectionTypeImageComboBoxEdit_SelectedIndexChanged(object sender, EventArgs e)
		{

			switch ((LotCodeSectionType)sectionTypeImageComboBoxEdit.EditValue)
			{
				case LotCodeSectionType.YearText:
					lettersToSkipTextEdit.Enabled = true;
					lettersToReplaceTextEdit.Enabled = true;
					replacementLettersTextEdit.Enabled = true;
					firstMonthComboBoxEdit.Enabled = false;
					firstYearTextEdit.Enabled = true;
					firstWeekOfYearImageComboBoxEdit.Enabled = true;
					firstDayOfWeekImageComboBoxEdit.Enabled = true;
					restartsOnTextEdit.Enabled = true;
					fromSpinEdit.Enabled = false;
					toSpinEdit.Enabled = false;
					break;
				case LotCodeSectionType.MonthText:
					lettersToSkipTextEdit.Enabled = true;
					lettersToReplaceTextEdit.Enabled = true;
					replacementLettersTextEdit.Enabled = true;
					firstMonthComboBoxEdit.Enabled = false;
					firstYearTextEdit.Enabled = false;
					firstWeekOfYearImageComboBoxEdit.Enabled = false;
					firstDayOfWeekImageComboBoxEdit.Enabled = false;
					restartsOnTextEdit.Enabled = false;
					fromSpinEdit.Enabled = false;
					toSpinEdit.Enabled = false;
					break;
				case LotCodeSectionType.WeekOfYear:
					lettersToSkipTextEdit.Enabled = false;
					lettersToReplaceTextEdit.Enabled = false;
					replacementLettersTextEdit.Enabled = false;
					firstMonthComboBoxEdit.Enabled = false;
					firstYearTextEdit.Enabled = false;
					firstWeekOfYearImageComboBoxEdit.Enabled = true;
					firstDayOfWeekImageComboBoxEdit.Enabled = false;
					restartsOnTextEdit.Enabled = false;
					fromSpinEdit.Enabled = false;
					toSpinEdit.Enabled = false;
					break;
				case LotCodeSectionType.DayOfWeekText:
					lettersToSkipTextEdit.Enabled = false;
					lettersToReplaceTextEdit.Enabled = false;
					replacementLettersTextEdit.Enabled = false;
					firstMonthComboBoxEdit.Enabled = false;
					firstYearTextEdit.Enabled = false;
					firstWeekOfYearImageComboBoxEdit.Enabled = false;
					firstDayOfWeekImageComboBoxEdit.Enabled = true;
					restartsOnTextEdit.Enabled = false;
					fromSpinEdit.Enabled = false;
					toSpinEdit.Enabled = false;
					break;
				case LotCodeSectionType.DayOfWeekNumber:
					lettersToSkipTextEdit.Enabled = false;
					lettersToReplaceTextEdit.Enabled = false;
					replacementLettersTextEdit.Enabled = false;
					firstMonthComboBoxEdit.Enabled = false;
					firstYearTextEdit.Enabled = false;
					firstWeekOfYearImageComboBoxEdit.Enabled = false;
					firstDayOfWeekImageComboBoxEdit.Enabled = true;
					restartsOnTextEdit.Enabled = false;
					fromSpinEdit.Enabled = false;
					toSpinEdit.Enabled = false;
					break;
				case LotCodeSectionType.MonthCustom:
					lettersToSkipTextEdit.Enabled = false;
					lettersToReplaceTextEdit.Enabled = false;
					replacementLettersTextEdit.Enabled = false;
					firstMonthComboBoxEdit.Enabled = true;
					firstYearTextEdit.Enabled = true;
					firstWeekOfYearImageComboBoxEdit.Enabled = false;
					firstDayOfWeekImageComboBoxEdit.Enabled = false;
					restartsOnTextEdit.Enabled = false;
					fromSpinEdit.Enabled = true;
					toSpinEdit.Enabled = true;
					break;
				case LotCodeSectionType.DayOfMonthCustom:
					lettersToSkipTextEdit.Enabled = true;
					lettersToReplaceTextEdit.Enabled = true;
					replacementLettersTextEdit.Enabled = true;
					firstMonthComboBoxEdit.Enabled = false;
					firstYearTextEdit.Enabled = false;
					firstWeekOfYearImageComboBoxEdit.Enabled = false;
					firstDayOfWeekImageComboBoxEdit.Enabled = false;
					restartsOnTextEdit.Enabled = true;
					fromSpinEdit.Enabled = false;
					toSpinEdit.Enabled = false;
					break;
				default:
					lettersToSkipTextEdit.Enabled = false;
					lettersToReplaceTextEdit.Enabled = false;
					replacementLettersTextEdit.Enabled = false;
					firstMonthComboBoxEdit.Enabled = false;
					firstYearTextEdit.Enabled = false;
					firstWeekOfYearImageComboBoxEdit.Enabled = false;
					firstDayOfWeekImageComboBoxEdit.Enabled = false;
					restartsOnTextEdit.Enabled = false;
					fromSpinEdit.Enabled = false;
					toSpinEdit.Enabled = false;
					break;
			}

		}

		private void BindLotCodeFormat(int FormatID)
		{

			m_LotCodeSession.DropIdentityMap();

			m_CurrentLotCodeFormat = m_LotCodeSession.GetObjectByKey<LotCodeFormats>(FormatID, true);
			formatNameTextEdit.EditValue = m_CurrentLotCodeFormat.FormatName;
			formatSectionsSpinEdit.EditValue = m_CurrentLotCodeFormat.Sections;
			formatWarningLabelControl.Visible = m_CurrentLotCodeFormat.FormatSections.Count == m_CurrentLotCodeFormat.Sections;
			PrepareNewLotCodeSection(1);

		}

		private void BindLotCodeSectionFields(int SectionID)
		{

			m_CurrentLotCodeSection = m_LotCodeSession.GetObjectByKey<LotCodeFormatSections>(SectionID, true);
			sectionPositionSpinEdit.EditValue = m_CurrentLotCodeSection.SectionPosition;
			sectionPositionSpinEdit.ReadOnly = true;
			sectionNameTextEdit.EditValue = m_CurrentLotCodeSection.SectionName;
			sectionTypeImageComboBoxEdit.EditValue = m_CurrentLotCodeSection.SectionType;
			sectionLengthSpinEdit.EditValue = m_CurrentLotCodeSection.SectionLength;
			foreach (LotCodeSectionSettings sectionSetting in m_CurrentLotCodeSection.SectionSettings)
			{
				switch (sectionSetting.SettingName)
				{
					case "LettersToSkip":
						lettersToSkipTextEdit.EditValue = sectionSetting.SettingValue;
						break;
					case "LettersToReplace":
						lettersToReplaceTextEdit.EditValue = sectionSetting.SettingValue;
						break;
					case "ReplacementLetters":
						replacementLettersTextEdit.EditValue = sectionSetting.SettingValue;
						break;
					case "FirstMonth":
						firstMonthComboBoxEdit.EditValue = sectionSetting.SettingValue;
						break;
					case "FirstYear":
						firstYearTextEdit.EditValue = sectionSetting.SettingValue;
						break;
					case "FirstWeekOfYear":
						firstWeekOfYearImageComboBoxEdit.EditValue = sectionSetting.SettingValue;
						break;
					case "FirstDayOfWeek":
						firstDayOfWeekImageComboBoxEdit.EditValue = sectionSetting.SettingValue;
						break;
					case "RestartsOnThe":
						restartsOnTextEdit.EditValue = sectionSetting.SettingValue;
						break;
					case "NumberRangeFrom":
						fromSpinEdit.EditValue = sectionSetting.SettingValue;
						break;
					case "NumberRangeTo":
						toSpinEdit.EditValue = sectionSetting.SettingValue;
						break;
					default:
						//Unknown setting
						break;
				}
			}

		}

		private void CancelFormatChanges()
		{

			if (cancelFormatChangesSimpleButton.Tag.ToString() == "New Format")
			{
				if (m_CurrentLotCodeFormat.Oid > 0)
				{
					m_CurrentLotCodeFormat.Delete();
				}
				else
				{
					m_CurrentLotCodeFormat = null;
				}
				m_CurrentLotCodeSection = null;
				m_CurrentLotCodeSectionSettings = null;
				sectionSettingsPanelControl.Enabled = false;
				lotCodeFormatPreviewGroupControl.Enabled = false;
				formatNameTextEdit.EditValue = null;
				formatSectionsSpinEdit.EditValue = 1;
				formatWarningLabelControl.Visible = false;
				PrepareNewLotCodeSection(null);
			}
			else
			{
				BindLotCodeFormat(m_CurrentLotCodeFormat.Oid);
			}

		}

		private void CancelSettingChanges()
		{

			PrepareNewLotCodeSection(m_CurrentLotCodeSection.SectionPosition);

		}

		public bool CheckPermissions()
		{

			try
			{
				SPG.UserPermissionsRow permission = (new UserPermissionsBLL()).GetUserPermissionsByUserName(Properties.Settings.Default.UserName, "Lot Code Setup")[0];

				switch (permission.PermissionLevel)
				{
					case "FULL":
					case "Full":
						newLotCodeFormatSimpleButton.Enabled = true;
						editSettingsSimpleButton.Enabled = true;
						editLotCodeFormatSimpleButton.Enabled = true;
						deleteFormatSimpleButton.Enabled = true;
						deleteSettingsSimpleButton.Enabled = true;
						break;
					case "ADD":
					case "Add":
						newLotCodeFormatSimpleButton.Enabled = true;
						editSettingsSimpleButton.Enabled = true;
						editLotCodeFormatSimpleButton.Enabled = true;
						deleteFormatSimpleButton.Enabled = false;
						deleteSettingsSimpleButton.Enabled = false;
						break;
					case "NONE":
					case "None":
						MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						Close();
						return false;
					case "VIEW":
					case "View":
						newLotCodeFormatSimpleButton.Enabled = false;
						editSettingsSimpleButton.Enabled = false;
						editLotCodeFormatSimpleButton.Enabled = false;
						deleteFormatSimpleButton.Enabled = false;
						deleteSettingsSimpleButton.Enabled = false;
						break;
					case "EDIT":
					case "Edit":
						newLotCodeFormatSimpleButton.Enabled = false;
						editSettingsSimpleButton.Enabled = true;
						editLotCodeFormatSimpleButton.Enabled = true;
						deleteFormatSimpleButton.Enabled = false;
						deleteSettingsSimpleButton.Enabled = false;
						break;
					case "VIEW ASSIGNED":
						newLotCodeFormatSimpleButton.Enabled = false;
						editSettingsSimpleButton.Enabled = false;
						editLotCodeFormatSimpleButton.Enabled = false;
						deleteFormatSimpleButton.Enabled = false;
						deleteSettingsSimpleButton.Enabled = false;
						break;
					case "EDIT ASSIGNED":
						newLotCodeFormatSimpleButton.Enabled = false;
						editSettingsSimpleButton.Enabled = true;
						editLotCodeFormatSimpleButton.Enabled = true;
						deleteFormatSimpleButton.Enabled = false;
						deleteSettingsSimpleButton.Enabled = false;
						break;
					default:
						MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
						Close();
						return false;
				}
				return true;
			}
			catch (InvalidOperationException ex)
			{
				return false;
			}

		}

		private void PrepareNewLotCodeSection(int? SectionPosition)
		{

			if (SectionPosition.HasValue)
			{
				m_CurrentLotCodeSection = m_LotCodeSession.FindObject<LotCodeFormatSections>(new GroupOperator(GroupOperatorType.And, new BinaryOperator(LotCodeFormatSections.Fields.LotCodeFormat.Oid.PropertyName, m_CurrentLotCodeFormat.Oid, BinaryOperatorType.Equal), new BinaryOperator(LotCodeFormatSections.Fields.SectionPosition.PropertyName, SectionPosition.Value, BinaryOperatorType.Equal)));
				if (m_CurrentLotCodeSection == null)
				{
					m_CurrentLotCodeSection = new LotCodeFormatSections(m_LotCodeSession)
					{
						SectionPosition = SectionPosition.Value,
						LotCodeFormat = m_CurrentLotCodeFormat
					};
				}
				else
				{
					BindLotCodeSectionFields(m_CurrentLotCodeSection.Oid);
					return;
				}
				sectionPositionSpinEdit.EditValue = SectionPosition.Value;
			}
			else
			{
				sectionPositionSpinEdit.EditValue = 1;
			}

			sectionNameTextEdit.EditValue = null;
			sectionTypeImageComboBoxEdit.EditValue = null;
			sectionLengthSpinEdit.EditValue = 1;
			lettersToSkipTextEdit.EditValue = null;
			lettersToReplaceTextEdit.EditValue = null;
			replacementLettersTextEdit.EditValue = null;
			firstMonthComboBoxEdit.EditValue = null;
			firstYearTextEdit.EditValue = null;
			firstWeekOfYearImageComboBoxEdit.EditValue = null;
			firstDayOfWeekImageComboBoxEdit.EditValue = null;
			restartsOnTextEdit.EditValue = null;
			fromSpinEdit.EditValue = 11;
			toSpinEdit.EditValue = 99;

		}

		private bool RequiredInfoMissing()
		{

			if (string.IsNullOrEmpty(formatNameTextEdit.Text) || formatSectionsSpinEdit.Value < 1M)
			{
				MessageBox.Show("You must provide a name and the amount of sections it has before saving");
				return true;
			}

			return false;

		}

		private bool SaveLotCodeFormat()
		{

			m_CurrentLotCodeFormat.FormatName = formatNameTextEdit.Text;
			m_CurrentLotCodeFormat.Sections = Convert.ToInt32(formatSectionsSpinEdit.Value);

			try
			{
				m_CurrentLotCodeFormat.Save();
			}
			catch (ApplicationException ex)
			{
				MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;

		}

		private bool SaveSectionSettings()
		{

			if (sectionPositionSpinEdit.ReadOnly == false)
			{
				UpdateSectionPosition(m_CurrentLotCodeSection.SectionPosition, Convert.ToInt32(sectionPositionSpinEdit.Value));
				m_CurrentLotCodeSection.SectionPosition = Convert.ToInt32(sectionPositionSpinEdit.Value);
			}
			m_CurrentLotCodeSection.SectionName = sectionNameTextEdit.Text;
			m_CurrentLotCodeSection.SectionType = (LotCodeSectionType)sectionTypeImageComboBoxEdit.EditValue;
			m_CurrentLotCodeSection.SectionLength = Convert.ToInt32(sectionLengthSpinEdit.Value);
			m_CurrentLotCodeSection.Save();

			foreach (LotCodeSectionSettings setting in m_CurrentLotCodeSection.SectionSettings)
			{
				setting.Delete();
			}

			if (lettersToSkipTextEdit.ReadOnly == false && lettersToSkipTextEdit.Enabled == true)
			{
				m_CurrentLotCodeSectionSettings = new LotCodeSectionSettings(m_LotCodeSession)
				{
					LotCodeSection = m_CurrentLotCodeSection,
					SettingName = "LettersToSkip",
					SettingValue = (lettersToSkipTextEdit.EditValue == null ? null : Convert.ToString(lettersToSkipTextEdit.EditValue))
				};
				m_CurrentLotCodeSectionSettings.Save();
			}
			if (lettersToReplaceTextEdit.ReadOnly == false && lettersToReplaceTextEdit.Enabled == true)
			{
				m_CurrentLotCodeSectionSettings = new LotCodeSectionSettings(m_LotCodeSession)
				{
					LotCodeSection = m_CurrentLotCodeSection,
					SettingName = "LettersToReplace",
					SettingValue = (lettersToReplaceTextEdit.EditValue == null ? null : Convert.ToString(lettersToReplaceTextEdit.EditValue))
				};
				m_CurrentLotCodeSectionSettings.Save();
			}
			if (replacementLettersTextEdit.ReadOnly == false && replacementLettersTextEdit.Enabled == true)
			{
				m_CurrentLotCodeSectionSettings = new LotCodeSectionSettings(m_LotCodeSession)
				{
					LotCodeSection = m_CurrentLotCodeSection,
					SettingName = "ReplacementLetters",
					SettingValue = (replacementLettersTextEdit.EditValue == null ? null : Convert.ToString(replacementLettersTextEdit.EditValue))
				};
				m_CurrentLotCodeSectionSettings.Save();
			}
			if (firstMonthComboBoxEdit.ReadOnly == false && firstMonthComboBoxEdit.Enabled == true)
			{
				m_CurrentLotCodeSectionSettings = new LotCodeSectionSettings(m_LotCodeSession)
				{
					LotCodeSection = m_CurrentLotCodeSection,
					SettingName = "FirstMonth",
					SettingValue = (firstMonthComboBoxEdit.EditValue == null ? null : Convert.ToString(firstMonthComboBoxEdit.EditValue))
				};
				m_CurrentLotCodeSectionSettings.Save();
			}
			if (firstYearTextEdit.ReadOnly == false && firstYearTextEdit.Enabled == true)
			{
				m_CurrentLotCodeSectionSettings = new LotCodeSectionSettings(m_LotCodeSession)
				{
					LotCodeSection = m_CurrentLotCodeSection,
					SettingName = "FirstYear",
					SettingValue = (firstYearTextEdit.EditValue == null ? null : Convert.ToString(firstYearTextEdit.EditValue))
				};
				m_CurrentLotCodeSectionSettings.Save();
			}
			if (firstWeekOfYearImageComboBoxEdit.ReadOnly == false && firstWeekOfYearImageComboBoxEdit.Enabled == true)
			{
				m_CurrentLotCodeSectionSettings = new LotCodeSectionSettings(m_LotCodeSession)
				{
					LotCodeSection = m_CurrentLotCodeSection,
					SettingName = "FirstWeekOfYear",
					SettingValue = (firstWeekOfYearImageComboBoxEdit.EditValue == null ? null : Convert.ToString(firstWeekOfYearImageComboBoxEdit.EditValue))
				};
				m_CurrentLotCodeSectionSettings.Save();
			}
			if (firstDayOfWeekImageComboBoxEdit.ReadOnly == false && firstDayOfWeekImageComboBoxEdit.Enabled == true)
			{
				m_CurrentLotCodeSectionSettings = new LotCodeSectionSettings(m_LotCodeSession)
				{
					LotCodeSection = m_CurrentLotCodeSection,
					SettingName = "FirstDayOfWeek",
					SettingValue = (firstDayOfWeekImageComboBoxEdit.EditValue == null ? null : Convert.ToString(firstDayOfWeekImageComboBoxEdit.EditValue))
				};
				m_CurrentLotCodeSectionSettings.Save();
			}
			if (restartsOnTextEdit.ReadOnly == false && restartsOnTextEdit.Enabled == true)
			{
				m_CurrentLotCodeSectionSettings = new LotCodeSectionSettings(m_LotCodeSession)
				{
					LotCodeSection = m_CurrentLotCodeSection,
					SettingName = "RestartsOnThe",
					SettingValue = (restartsOnTextEdit.EditValue == null ? null : Convert.ToString(restartsOnTextEdit.EditValue))
				};
				m_CurrentLotCodeSectionSettings.Save();
			}
			if (fromSpinEdit.ReadOnly == false && fromSpinEdit.Enabled == true)
			{
				m_CurrentLotCodeSectionSettings = new LotCodeSectionSettings(m_LotCodeSession)
				{
					LotCodeSection = m_CurrentLotCodeSection,
					SettingName = "NumberRangeFrom",
					SettingValue = (fromSpinEdit.EditValue == null ? null : Convert.ToString(fromSpinEdit.EditValue))
				};
				m_CurrentLotCodeSectionSettings.Save();
			}
			if (toSpinEdit.ReadOnly == false && toSpinEdit.Enabled == true)
			{
				m_CurrentLotCodeSectionSettings = new LotCodeSectionSettings(m_LotCodeSession)
				{
					LotCodeSection = m_CurrentLotCodeSection,
					SettingName = "NumberRangeTo",
					SettingValue = (toSpinEdit.EditValue == null ? null : Convert.ToString(toSpinEdit.EditValue))
				};
				m_CurrentLotCodeSectionSettings.Save();
			}

			return true;

		}

		private void UpdateSectionPosition(int oldSectionPosition, int newSectionPosition)
		{

			if (oldSectionPosition < newSectionPosition)
			{
				foreach (LotCodeFormatSections codeSection in
					from LaterSection in m_LotCodeSession.Query<LotCodeFormatSections>()
					where LaterSection.LotCodeFormat.Oid == m_CurrentLotCodeFormat.Oid && LaterSection.SectionPosition > oldSectionPosition && LaterSection.SectionPosition <= newSectionPosition
					select LaterSection)
				{
					codeSection.SectionPosition -= 1;
					codeSection.Save();
				}
			}
			else
			{
				foreach (LotCodeFormatSections codeSection in
					from PreviousSection in m_LotCodeSession.Query<LotCodeFormatSections>()
					where PreviousSection.LotCodeFormat.Oid == m_CurrentLotCodeFormat.Oid && PreviousSection.SectionPosition < oldSectionPosition && PreviousSection.SectionPosition >= newSectionPosition
					select PreviousSection)
				{
					codeSection.SectionPosition += 1;
					codeSection.Save()
                        ;
				}
			}

		}

		private bool ValidateCodeFormatRecord()
		{

			if (RequiredInfoMissing())
			{
				return false;
			}

			return true;

		}

		private void ValidateFirstDayOfWeek()
		{

			if (firstDayOfWeekImageComboBoxEdit.EditValue == null)
			{
				firstDayOfWeekImageComboBoxEdit.EditValue = Microsoft.VisualBasic.FirstDayOfWeek.Monday;
			}

		}

		private void ValidateFirstWeekOfYear()
		{

			if (firstWeekOfYearImageComboBoxEdit.EditValue == null)
			{
				firstWeekOfYearImageComboBoxEdit.EditValue = Microsoft.VisualBasic.FirstWeekOfYear.FirstFourDays;
			}

		}

		private bool ValidateReplacementLetters()
		{

			if (string.IsNullOrEmpty(lettersToReplaceTextEdit.Text) != string.IsNullOrEmpty(replacementLettersTextEdit.Text) || lettersToReplaceTextEdit.Text.Length != replacementLettersTextEdit.Text.Length)
			{
				MessageBox.Show("The letters to replace and the replacement letters must match before saving");
				return false;
			}

			return true;

		}

		private bool ValidateSectionSettingsRecord()
		{

			if (string.IsNullOrEmpty(sectionTypeImageComboBoxEdit.Text) || sectionLengthSpinEdit.Value < 1M)
			{
				MessageBox.Show("You must provide a type and a length before saving");
				return false;
			}

			switch ((LotCodeSectionType)sectionTypeImageComboBoxEdit.EditValue)
			{
				case LotCodeSectionType.YearText:
					if (ValidateReplacementLetters() == false)
					{
						return false;
					}
					if (ValidateYear(true, firstYearTextEdit.Text, "You must enter a year for the first year") == false)
					{
						return false;
					}
					ValidateFirstWeekOfYear();
					ValidateFirstDayOfWeek();
					if (ValidateYear(false, restartsOnTextEdit.Text, "You must enter a valid number for the restarts on the (nth year) field") == false)
					{
						return false;
					}
					break;
				case LotCodeSectionType.MonthText:
					if (ValidateReplacementLetters() == false)
					{
						return false;
					}
					break;
				case LotCodeSectionType.WeekOfYear:
					ValidateFirstWeekOfYear();
					break;
				case LotCodeSectionType.DayOfWeekText:
				case LotCodeSectionType.DayOfWeekNumber:
					ValidateFirstDayOfWeek();
					break;
				case LotCodeSectionType.MonthCustom:
					if (ValidateYear(true, firstYearTextEdit.Text, "You must enter a year for the first year") == false)
					{
						return false;
					}
					if (firstMonthComboBoxEdit.EditValue == null)
					{
						firstMonthComboBoxEdit.SelectedItem = "January";
					}
					if (fromSpinEdit.Value > toSpinEdit.Value)
					{
						MessageBox.Show("The From has to be less than the To");
						return false;
					}
					break;
				case LotCodeSectionType.DayOfMonthCustom:
					if (ValidateReplacementLetters() == false)
					{
						return false;
					}
					if (ValidateYear(false, restartsOnTextEdit.Text, "You must enter a valid number for the restarts on the (nth day) field") == false)
					{
						return false;
					}
					break;
				default:
					return true;
					break;
			}

			return true;

		}

		private bool ValidateYear(bool isYear, string yearText, string msg)
		{

			int year = 0;
			if (string.IsNullOrEmpty(yearText) || int.TryParse(yearText, out year) == false || (isYear && (year < 1900 || year > 9999)))
			{
				MessageBox.Show(msg);
				return false;
			}

			return true;

		}

	}
}