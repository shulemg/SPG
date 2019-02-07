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
	public partial class ShiftsXtraForm
	{

		public ShiftsXtraForm()
		{
			InitializeComponent();
		}

		private ShiftsBLL m_Shift;

		private void BindGridControl()
		{

			this.shiftsGridControl.DataSource = m_Shift.GetShifts();

		}

		private void deleteSimpleButton_Click(System.Object sender, EventArgs e)
		{

			if (shiftsGridView.SelectedRowsCount > 0)
			{
				if (MessageBox.Show("Are you sure you want to delete this record/s?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					for (int i = 0; i < shiftsGridView.SelectedRowsCount; i++)
					{
						int row = shiftsGridView.GetSelectedRows()[i];
						if (row >= 0)
						{
							if (m_Shift.DeleteShift(Convert.ToInt32(shiftsGridView.GetRowCellValue(row, idGridColumn))) != true)
							{
								MessageBox.Show("The Shift/s was not deleted succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				shiftsGridView.SelectAll();
				if (shiftsGridView.SelectedRowsCount > 0)
				{
					for (int i = 0; i < shiftsGridView.SelectedRowsCount; i++)
					{
						int row = shiftsGridView.GetSelectedRows()[i];
						if (row >= 0)
						{
							if (m_Shift.UpdateShift((int?)shiftsGridView.GetRowCellValue(row, idGridColumn), shiftsGridView.GetRowCellValue(row, shiftGridColumn).ToString()) != true)
							{
								MessageBox.Show("The Shift was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		private void ShiftsXtraForm_Load(object sender, EventArgs e)
		{

			m_Shift = new ShiftsBLL();

			CheckPermissions();
			this.shiftGridColumn.FieldName = "ShiftName";
			this.idGridColumn.FieldName = "ShiftID";
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
						this.shiftsGridView.OptionsBehavior.Editable = true;
						this.shiftsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
						this.deleteSimpleButton.Visible = true;
						break;
					case "ADD":
					case "Add":
						this.shiftsGridView.OptionsBehavior.Editable = true;
						this.shiftsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
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
						this.shiftsGridView.OptionsBehavior.Editable = false;
						this.shiftsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
						this.deleteSimpleButton.Visible = false;
						break;
					case "EDIT":
					case "Edit":
						this.shiftsGridView.OptionsBehavior.Editable = true;
						this.shiftsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
						this.deleteSimpleButton.Visible = false;
						break;
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