//INSTANT C# NOTE: Formerly VB project-level imports:
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using System;
using System.Data.Sql;
using System.Collections;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace SuperiorPackGroup
{
	public partial class DatabaseSelectionXtraForm
	{

		public DatabaseSelectionXtraForm()
		{
			InitializeComponent();
		}

		private ArrayList m_Servers = new ArrayList();

		private void DatabaseSelectionXtraForm_Load(object sender, EventArgs e)
		{

			this.serversBackgroundWorker.RunWorkerAsync();

		}

		private void refreshSimpleButton_Click(System.Object sender, EventArgs e)
		{

			if (this.serversBackgroundWorker.IsBusy == false)
			{
				this.serversBackgroundWorker.RunWorkerAsync();
			}

		}
		private void FillServerLookUpEdit()
		{

			this.serverLookUpEdit.Properties.DataSource = m_Servers;
			this.serverLookUpEdit.Properties.ShowHeader = false;

		}

		private void logOnRadioGroup_SelectedIndexChanged(System.Object sender, EventArgs e)
		{

			this.sqlAuthenticationPanelControl.Enabled = (this.logOnRadioGroup.SelectedIndex == 1);
			FillDatabaseLookupEdit();

		}

		public void FillDatabaseLookupEdit()
		{

			if (this.serverLookUpEdit.EditValue != null)
			{
				string connectionString = CreateConnectionString();
				ArrayList dataBases = null;
				if (string.IsNullOrEmpty(connectionString))
				{
					return;
				}
				else
				{
					dataBases = DALUtils.GetDatabases(connectionString);
				}

				if (dataBases == null)
				{
					return;
				}
				this.dataBaseLookUpEdit.Properties.DataSource = dataBases;
				this.dataBaseLookUpEdit.Properties.ShowHeader = false;
				this.dataBaseLookUpEdit.Enabled = (dataBases.Count > 0);
				this.testConnectionSimpleButton.Enabled = (this.dataBaseLookUpEdit.Enabled);
			}

		}

		public string CreateConnectionString()
		{

			if (this.serverLookUpEdit.EditValue == null)
			{
				return null;
			}

			if (this.logOnRadioGroup.SelectedIndex == 0)
			{
				return string.Format("Data Source={0};Integrated Security=True", this.serverLookUpEdit.EditValue);
			}
			else
			{
				if (string.IsNullOrEmpty(this.userNameTextEdit.Text))
				{
					return null;
				}
				else
				{
					return string.Format("Data Source={0};User ID={1};Password={2}", this.serverLookUpEdit.EditValue, this.userNameTextEdit.Text, this.passwordTextEdit.Text);
				}
			}

		}

		private string CreateFullConnectionString()
		{

			if (this.dataBaseLookUpEdit.EditValue == null)
			{
				return null;
			}

			return string.Format("{0};Initial Catalog={1}", CreateConnectionString(), this.dataBaseLookUpEdit.EditValue);

		}

		private void testConnectionSimpleButton_Click(System.Object sender, EventArgs e)
		{

			if (this.dataBaseLookUpEdit.EditValue == null)
			{
				MessageBox.Show("Select a database before testing the connection.", "Error Encountered", MessageBoxButtons.OK);
				return;
			}

			bool success = DALUtils.TestConnection(CreateFullConnectionString());

			if (success)
			{
				MessageBox.Show("Test Succeeded", "Test Connection", MessageBoxButtons.OK);
			}
			else
			{
				MessageBox.Show("Test Failed", "Test Connection", MessageBoxButtons.OK);
			}

		}

		private void cancelSimpleButton_Click(System.Object sender, EventArgs e)
		{

			this.Close();

		}

		private void okSimpleButton_Click(System.Object sender, EventArgs e)
		{

			Properties.Settings.Default.UserConnectionString = CreateFullConnectionString();
			this.Close();

		}

		private void serverLookUpEdit_ProcessNewValue(System.Object sender, ProcessNewValueEventArgs e)
		{

			DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit edit = ((LookUpEdit)sender).Properties;
			if (e.DisplayValue.ToString() == edit.NullText || string.IsNullOrEmpty(e.DisplayValue.ToString()))
			{
				return;
			}

			m_Servers.Add(e.DisplayValue);

			e.Handled = true;

		}

		private void serverLookUpEdit_Leave(System.Object sender, EventArgs e)
		{

			FillDatabaseLookupEdit();

		}

		private void refreshDatabasesSimpleButton_Click(System.Object sender, EventArgs e)
		{

			this.Cursor = Cursors.WaitCursor;
			FillDatabaseLookupEdit();
			this.Cursor = Cursors.Default;

		}

		private void serversBackgroundWorker_DoWork(System.Object sender, System.ComponentModel.DoWorkEventArgs e)
		{

			m_Servers = DALUtils.GetSQLServers();

		}

		private void serversBackgroundWorker_RunWorkerCompleted(System.Object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{

			FillServerLookUpEdit();

		}

	}
}