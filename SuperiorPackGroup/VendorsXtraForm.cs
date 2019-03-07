//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using DXDAL.SPGData;

namespace SuperiorPackGroup
{
	public partial class VendorsXtraForm
	{

		public VendorsXtraForm()
		{
			InitializeComponent();
		}

		private void deleteRepositoryItemButtonEdit_ButtonClick(System.Object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{

			if (MessageBox.Show("Are you sure you want to delete this Vendor?", "Delete Vendor", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
			{
				if (VendorBLL.VendorInUse(Convert.ToInt32(vendorsGridView.GetFocusedRowCellValue(colOid))) == false)
				{
					vendorsGridView.DeleteRow(vendorsGridView.FocusedRowHandle);
				}
				else
				{
					MessageBox.Show(string.Format("This vendor is referenced in some records.{0}You can't delete it at this time.", Environment.NewLine), "Vendor In Use", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}

		}

		private void vendorsGridView_ValidateRow(System.Object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
		{

			if (vendorsGridView.GetFocusedRowCellValue(colVendorName) == null || string.IsNullOrEmpty(vendorsGridView.GetFocusedRowCellValue(colVendorName).ToString()))
			{
				e.ErrorText = "You must provide a Vendor name.";
				e.Valid = false;
			}
			else
			{
				e.ErrorText = null;
				e.Valid = true;
			}

		}

		private void VendorsXtraForm_Load(System.Object sender, EventArgs e)
		{

			DevExpress.Xpo.XPBaseObject.AutoSaveOnEndEdit = true;
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
						vendorsGridView.OptionsBehavior.Editable = true;
						vendorsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
						deleteGridColumn.Visible = true;
						break;
					case "ADD":
					case "Add":
						vendorsGridView.OptionsBehavior.Editable = true;
						vendorsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
						deleteGridColumn.Visible = false;
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
						vendorsGridView.OptionsBehavior.Editable = false;
						vendorsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
						deleteGridColumn.Visible = false;
						break;
					case "EDIT":
					case "Edit":
						vendorsGridView.OptionsBehavior.Editable = true;
						vendorsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
						deleteGridColumn.Visible = false;
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