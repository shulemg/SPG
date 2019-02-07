//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using DevExpress.XtraEditors;
using DXDAL.SPGData;
using DevExpress.XtraEditors.Controls;

namespace SuperiorPackGroup
{
	public partial class SettingsXtraForm
	{

		public SettingsXtraForm()
		{
			InitializeComponent();
		}

		private CompanySettingsBLL m_Settings;

		private void SettingsXtraForm_Load(System.Object sender, EventArgs e)
		{

			if (this.FinancialTabs == "NONE" || this.FinancialTabs == "EDIT ASSIGNED" || this.FinancialTabs == "VIEW ASSIGNED")
			{
				MessageBox.Show("You don't have permission to view this form.", "Access Denied", MessageBoxButtons.OK);
				this.Close();
				return;
			}

			m_Settings = new CompanySettingsBLL();
			BindSettingControls();

			this.customerLookUpEdit.Properties.DataSource = (new CustomersBLL()).GetCustomerNameAndIDS(false);
			this.customerLookUpEdit.Properties.Columns.Add(new LookUpColumnInfo());
			this.customerLookUpEdit.Properties.Columns[0].Caption = "Customer Name";
			this.customerLookUpEdit.Properties.Columns[0].FieldName = "CustomerName";
			this.customerLookUpEdit.Properties.DisplayMember = "CustomerName";
			this.customerLookUpEdit.Properties.ValueMember = "CustomerID";

		}

		private string m_FinancialTabs;
		public string FinancialTabs
		{

			get
			{
				return m_FinancialTabs;
			}

			set
			{
				m_FinancialTabs = value;
			}

		}

		public void BindSettingControls()
		{

			CompanySettings companySettings = CompanySettingsBLL.GetSettings();
			packersTextEdit.EditValue = companySettings.dblPackersPay;
			operatorsTextEdit.EditValue = companySettings.dblOperatorsPay;
			supersTextEdit.EditValue = companySettings.dblSupersPay;
			minutesTextEdit.EditValue = companySettings.intMinPerHour;
			customerLookUpEdit.EditValue = companySettings.UniversalCustomer;
			LPNPrinterTextEdit.EditValue = companySettings.LPNPrinterName;
			LPNMoveRightTextEdit.EditValue = companySettings.LPNHorizontalAdjustment;
			LPNMoveDownTextEdit.EditValue = companySettings.LPNVerticalAdjustment;
			LPNCopiesTextEdit.EditValue = companySettings.LPNPrintCopies;
			locationLookUpEdit.EditValue = companySettings.DefaultLocation.Oid;

		}

		private void payTextEditParseEditValue(System.Object sender, ConvertEditValueEventArgs e)
		{

			if (e.Value == null)
			{
				e.Value = double.Parse(e.Value.ToString());
			}

		}

		private void saveSimpleButton_Click(System.Object sender, EventArgs e)
		{

			try
			{
				if (m_Settings.UpdateCompanySettings(Utilities.ChangeType<float?>(this.packersTextEdit.EditValue), Utilities.ChangeType<float?>(this.operatorsTextEdit.EditValue), Utilities.ChangeType<float?>(this.supersTextEdit.EditValue), Utilities.ChangeType<short?>(this.minutesTextEdit.EditValue), Utilities.ChangeType<int?>(this.customerLookUpEdit.EditValue), (LPNPrinterTextEdit.EditValue == null ? null : Convert.ToString(LPNPrinterTextEdit.EditValue)), Convert.ToByte(LPNMoveRightTextEdit.EditValue), Convert.ToByte(LPNMoveDownTextEdit.EditValue), Convert.ToByte(LPNCopiesTextEdit.EditValue), Utilities.ChangeType<int?>(locationLookUpEdit.EditValue)) != true)
				{
					MessageBox.Show("The settings were not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			catch (ApplicationException ex)
			{
				MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

		}

		private void cancelSimpleButton_Click(System.Object sender, EventArgs e)
		{

			BindSettingControls();

		}

		private void SetUpBreakTimesSimpleButton_Click(System.Object sender, EventArgs e)
		{

			new BreakTimeXtraForm().ShowDialog();

		}

	}
}