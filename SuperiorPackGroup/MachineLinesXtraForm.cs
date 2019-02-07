//INSTANT C# NOTE: Formerly VB project-level imports:
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System;

namespace SuperiorPackGroup
{
	public partial class MachineLinesXtraForm
	{

		public MachineLinesXtraForm()
		{
			InitializeComponent();
		}

		private MachinesLinesBLL m_MachineLines;

		private void BindGridControl()
		{

			this.machineLineGridControl.DataSource = m_MachineLines.GetMachineLines();

		}

		private void MachineLinesXtraForm_Load(object sender, EventArgs e)
		{

			m_MachineLines = new MachinesLinesBLL();

			CheckPermissions();
			this.nameGridColumn.FieldName = "MachineLineName";
			this.idGridColumn.FieldName = "MachineLineID";
			BindGridControl();

		}

		private void deleteSimpleButton_Click(System.Object sender, EventArgs e)
		{

			if (machineLineGridView.SelectedRowsCount > 0)
			{
				if (MessageBox.Show("Are you sure you want to delete this record/s?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					for (int i = 0; i < machineLineGridView.SelectedRowsCount; i++)
					{
						int row = machineLineGridView.GetSelectedRows()[i];
						if (row >= 0)
						{
							if (m_MachineLines.DeleteMachineLine(Convert.ToInt32(machineLineGridView.GetRowCellValue(row, idGridColumn))) != true)
							{
								MessageBox.Show("The Machine Line/s was not deleted successfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
								return;
							}
						}
					}
				}
			}

			BindGridControl();

		}

		private void saveSimpleButton_Click(System.Object sender, EventArgs e)
		{

			try
			{
				machineLineGridView.SelectAll();
				if (machineLineGridView.SelectedRowsCount > 0)
				{
					for (int i = 0; i < machineLineGridView.SelectedRowsCount; i++)
					{
						int row = machineLineGridView.GetSelectedRows()[i];
						if (row >= 0)
						{
							if (m_MachineLines.UpdateMachineLine((int?)machineLineGridView.GetRowCellValue(row, idGridColumn), machineLineGridView.GetRowCellValue(row, nameGridColumn).ToString()) != true)
							{
								MessageBox.Show("The Machine Lines was not updated successfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
								return;
							}
						}
					}
				}
			}
			catch (ApplicationException ex)
			{
				MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			BindGridControl();

		}

		public bool CheckPermissions()
		{

			try
			{
				SPG.UserPermissionsRow permission = (new UserPermissionsBLL()).GetUserPermissionsByUserName(Properties.Settings.Default.UserName, "General Lists")[0];

				switch (permission.PermissionLevel)
				{
					case "FULL":
					case "Full":
						this.machineLineGridView.OptionsBehavior.Editable = true;
						this.machineLineGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
						this.deleteSimpleButton.Visible = true;
						break;
					case "ADD":
					case "Add":
						this.machineLineGridView.OptionsBehavior.Editable = true;
						this.machineLineGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
						this.deleteSimpleButton.Visible = false;
						break;
					case "NONE":
					case "None":
					case "VIEW ASSIGNED":
					case "EDIT ASSIGNED":
						MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						this.Close();
						return false;
					case "VIEW":
					case "View":
						this.machineLineGridView.OptionsBehavior.Editable = false;
						this.machineLineGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
						this.deleteSimpleButton.Visible = false;
						break;
					case "EDIT":
					case "Edit":
						this.machineLineGridView.OptionsBehavior.Editable = true;
						this.machineLineGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
						this.deleteSimpleButton.Visible = false;
						break;
					default:
						MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						this.Close();
						return false;
				}
				return true;
			}
			catch (InvalidOperationException ex)
			{
				return false;
			}

		}

	}
}