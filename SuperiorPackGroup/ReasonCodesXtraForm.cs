//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using System.Linq;
using DevExpress;
using DevExpress.Xpo;
using DXDAL.SPGData;

namespace SuperiorPackGroup
{
	public partial class ReasonCodesXtraForm
	{

		public ReasonCodesXtraForm()
		{
			InitializeComponent();
		}

		private void deleteSimpleButton_Click(object sender, EventArgs e)
		{

			if (reassonCodesGridView.SelectedRowsCount > 0)
			{
				if (MessageBox.Show("Are you sure you want to delete this record/s?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					for (int i = 0; i < reassonCodesGridView.SelectedRowsCount; i++)
					{
						int row = reassonCodesGridView.GetSelectedRows()[i];
						if (row >= 0)
						{
                            ReasonCodes currentReason = Session.DefaultSession.GetObjectByKey<ReasonCodes>(Convert.ToInt32(reassonCodesGridView.GetRowCellValue(row, colOid)));
							if (currentReason.Production.Any())
							{
								MessageBox.Show("This reason can't be deleted, it's used for a production reason code", "Reason In Use", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							}
							else
							{
								currentReason.Delete();

							}
						}
					}
					reasonCodesXpCollection.Reload();
				}
			}

		}

		private void ReasonCodesXtraForm_Load(object sender, EventArgs e)
		{

			CheckPermissions();

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
						reassonCodesGridView.OptionsBehavior.Editable = true;
						reassonCodesGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
						this.deleteSimpleButton.Visible = true;
						break;
					case "ADD":
					case "Add":
						reassonCodesGridView.OptionsBehavior.Editable = true;
						reassonCodesGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
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
						reassonCodesGridView.OptionsBehavior.Editable = false;
						reassonCodesGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
						this.deleteSimpleButton.Visible = false;
						break;
					case "EDIT":
					case "Edit":
						reassonCodesGridView.OptionsBehavior.Editable = true;
						reassonCodesGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
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