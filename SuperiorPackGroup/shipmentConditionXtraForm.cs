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
	public partial class shipmentConditionXtraForm
	{

		public shipmentConditionXtraForm()
		{
			InitializeComponent();
		}

		private void shipmentConditionXtraForm_Load(object sender, EventArgs e)
		{

			CheckPermissions();

		}

		private void deleteSimpleButton_Click(object sender, EventArgs e)
		{

			if (conditionsGridView.SelectedRowsCount > 0)
			{
				if (MessageBox.Show("Are you sure you want to delete this record/s?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					for (int i = 0; i < conditionsGridView.SelectedRowsCount; i++)
					{
						int row = conditionsGridView.GetSelectedRows()[i];
						if (row >= 0)
						{
							if (ShipmentConditionsBLL.DeleteCondition(Convert.ToInt32(conditionsGridView.GetRowCellValue(row, colOid))) != true)
							{
								MessageBox.Show("The Condition/s was not deleted succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
								return;
							}
						}
					}
				}
			}

			shipmentConditionsXpCollection.Reload();
			conditionsGridView.RefreshData();

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
						conditionsGridView.OptionsBehavior.Editable = true;
						conditionsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
						deleteSimpleButton.Visible = true;
						break;
					case "ADD":
					case "Add":
						conditionsGridView.OptionsBehavior.Editable = true;
						conditionsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
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
						conditionsGridView.OptionsBehavior.Editable = false;
						conditionsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
						deleteSimpleButton.Visible = false;
						break;
					case "EDIT":
					case "Edit":
						conditionsGridView.OptionsBehavior.Editable = true;
						conditionsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
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