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
	public partial class employeesXtraForm
	{

		public employeesXtraForm()
		{
			InitializeComponent();
		}

		private void EmployeesXtraForm_Load(object sender, EventArgs e)
		{

			CheckPermissions();

		}

		private void deleteSimpleButton_Click(object sender, EventArgs e)
		{

			if (employeeGridView.SelectedRowsCount > 0)
			{
				if (MessageBox.Show("Are you sure you want to delete this record/s?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					for (int i = 0; i < employeeGridView.SelectedRowsCount; i++)
					{
						int row = employeeGridView.GetSelectedRows()[i];
						if (row >= 0)
						{
							if (EmployeesBLL.DeleteEmployee(Convert.ToInt32(employeeGridView.GetRowCellValue(row, colOid))) != true)
							{
								MessageBox.Show("The Employee/s was not deleted succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
								return;
							}
						}
					}
				}
			}

			employeesXpCollection.Reload();
			employeeGridView.RefreshData();

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
						employeeGridView.OptionsBehavior.Editable = true;
						employeeGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
						deleteSimpleButton.Visible = true;
						break;
					case "ADD":
					case "Add":
						employeeGridView.OptionsBehavior.Editable = true;
						employeeGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
						deleteSimpleButton.Visible = false;
						break;
					case "NONE":
					case "None":
					case "VIEW ASSIGNED":
					case "EDIT ASSIGNED":
						MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						Close();
						return false;
					case "VIEW":
					case "View":
						employeeGridView.OptionsBehavior.Editable = false;
						employeeGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
						deleteSimpleButton.Visible = false;
						break;
					case "EDIT":
					case "Edit":
						employeeGridView.OptionsBehavior.Editable = true;
						employeeGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
						deleteSimpleButton.Visible = false;
						break;
					default:
						MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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

	}
}