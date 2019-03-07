//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

using System.Drawing;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DXDAL.SPGData;

namespace SuperiorPackGroup
{
	public partial class SecurityXtraForm
	{

		public SecurityXtraForm()
		{
			InitializeComponent();
		}

		private UsersBLL m_Users;
		private UserPermissionsBLL m_UserPermissions;
		private UnitOfWork m_CustomersUOW;

		private void SecurityXtraForm_FormClosing(object sender, FormClosingEventArgs e)
		{

			if (usersListBoxControl.Enabled == false)
			{
				switch (MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
				{
					case DialogResult.Yes:
						if (SaveChanges() == false)
						{
							e.Cancel = true;
						}
						break;
					case DialogResult.No:
						CancelChanges();
						break;
					case DialogResult.Cancel:
						e.Cancel = true;
						break;
				}
			}

		}

		private void SecurityXtraForm_Load(object sender, EventArgs e)
		{

			m_Users = new UsersBLL();
			m_UserPermissions = new UserPermissionsBLL();

			CheckPermissions();

			usersListBoxControl.ValueMember = "strUserName";
			usersListBoxControl.DisplayMember = "strUserName";
			BindUsersListBox();

			permissionIDGridColumn.FieldName = "UserPermissionID";
			permissionLevelGridColumn.FieldName = "PermissionLevel";
			permissionObjectGridColumn.FieldName = "PermissionObject";
			userNaemGridColumn.FieldName = "UserName";

			passwordTextEdit.Properties.ReadOnly = true;
			confirmTextEdit.Properties.ReadOnly = true;
			LPNPrinterTextEdit.Properties.ReadOnly = true;
			locationLookUpEdit.Properties.ReadOnly = true;
			resetSimpleButton.Enabled = false;
			usersListBoxControl.Enabled = true;
			userPermissionsGridView.OptionsBehavior.Editable = false;
			customersGridView.OptionsBehavior.Editable = false;

			m_CustomersUOW = new UnitOfWork(MyDataLayers.SPGDataLayer);

		}

		public void BindUsersListBox()
		{

			usersListBoxControl.DataSource = m_Users.GetUsers();

		}

		private void usersListBoxControl_SelectedValueChanged(object sender, EventArgs e)
		{

			if (usersListBoxControl.SelectedIndex != -1)
			{
				BindSecurityControls(usersListBoxControl.SelectedValue.ToString());
			}

		}

		public void BindSecurityControls(string username)
		{

			Users user = UsersBLL.GetUserByName(m_CustomersUOW, username);
			nameTextEdit.EditValue = user.strUserName;
			nameTextEdit.Enabled = false;
			passwordTextEdit.EditValue = user.strPassword;
			confirmTextEdit.EditValue = user.strPassword;
			LPNPrinterTextEdit.EditValue = user.LPNPrinterName;
			try
			{
				locationLookUpEdit.EditValue = UsersBLL.GetUserByName(m_CustomersUOW, user.strUserName).DefaultLocation.Oid;
			}
			catch
			{
				locationLookUpEdit.EditValue = null;
			}

			userPermissionsGridControl.DataSource = m_UserPermissions.GetUserPermissionsByUserName(user.strUserName, null);
			if (user.strUserName == "Admin")
			{
				customersXtraTabPage.PageVisible = false;
			}
			else
			{
				customersXtraTabPage.PageVisible = true;
				customersXPCollection.Criteria = CriteriaOperator.Parse(string.Format("User.strUserName = '{0}'", user));
			}

		}

		public bool CheckPermissions()
		{

			try
			{
				SPG.UserPermissionsRow permission = (new UserPermissionsBLL()).GetUserPermissionsByUserName(Properties.Settings.Default.UserName, "Security Settings")[0];

				switch (permission.PermissionLevel)
				{
					case "FULL":
					case "Full":
						passwordTextEdit.Properties.PasswordChar = '\0';
						confirmTextEdit.Properties.PasswordChar = '\0';
						addBarButtonItem.Enabled = true;
						editBarButtonItem.Enabled = true;
						deleteBarButtonItem.Enabled = true;
						break;
					case "ADD":
					case "Add":
						passwordTextEdit.Properties.PasswordChar = '*';
						confirmTextEdit.Properties.PasswordChar = '*';
						addBarButtonItem.Enabled = true;
						editBarButtonItem.Enabled = true;
						deleteBarButtonItem.Enabled = false;
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
						passwordTextEdit.Properties.PasswordChar = '*';
						confirmTextEdit.Properties.PasswordChar = '*';
						addBarButtonItem.Enabled = false;
						editBarButtonItem.Enabled = false;
						deleteBarButtonItem.Enabled = false;
						break;
					case "EDIT":
					case "Edit":
						passwordTextEdit.Properties.PasswordChar = '*';
						confirmTextEdit.Properties.PasswordChar = '*';
						addBarButtonItem.Enabled = false;
						editBarButtonItem.Enabled = true;
						deleteBarButtonItem.Enabled = false;
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

		private bool SaveChanges()
		{

			string selectedUser = nameTextEdit.Text;

			Locations location = null;
			if (locationLookUpEdit.EditValue != null)
			{
				location = Session.DefaultSession.GetObjectByKey<Locations>(locationLookUpEdit.EditValue);
			}
			else
			{
				location = null;
			}

			try
			{
				if (m_Users.UpdateUser(selectedUser, passwordTextEdit.Text, confirmTextEdit.Text, location, LPNPrinterTextEdit.Text) != true)
				{
					MessageBox.Show("The user was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}
			catch (ApplicationException ex)
			{
				MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			try
			{
				userPermissionsGridView.SelectAll();
				if (userPermissionsGridView.SelectedRowsCount > 0)
				{
					int permissions = userPermissionsGridView.SelectedRowsCount;
					int i = 0;
					while (i < permissions)
					{
						int permission = userPermissionsGridView.GetSelectedRows()[i];
						if (permission >= 0)
						{
							if (m_UserPermissions.UpdateUserPermissions((int?)userPermissionsGridView.GetRowCellValue(permission, permissionIDGridColumn), userPermissionsGridView.GetRowCellValue(permission, permissionObjectGridColumn).ToString(), userPermissionsGridView.GetRowCellValue(permission, permissionLevelGridColumn).ToString(), selectedUser) != true)
							{
								MessageBox.Show("The user permissions was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
								return false;
							}
						}
						i += 1;
					}
				}
				m_CustomersUOW.CommitChanges();
			}
			catch (ApplicationException ex)
			{
				MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			BindUsersListBox();
			usersListBoxControl.SelectedValue = selectedUser;

			passwordTextEdit.Properties.ReadOnly = true;
			confirmTextEdit.Properties.ReadOnly = true;
			LPNPrinterTextEdit.Properties.ReadOnly = true;
			locationLookUpEdit.Properties.ReadOnly = true;
			resetSimpleButton.Enabled = false;
			usersListBoxControl.Enabled = true;
			userPermissionsGridView.OptionsBehavior.Editable = false;
			customersGridView.OptionsBehavior.Editable = false;
			return true;

		}

		private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (SaveChanges())
			{
				CheckPermissions();
				cancelBarButtonItem.Enabled = false;
				saveBarButtonItem.Enabled = false;
			}

		}

		private void addBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			nameTextEdit.Text = null;
			nameTextEdit.Enabled = true;
			passwordTextEdit.EditValue = null;
			confirmTextEdit.EditValue = null;
			LPNPrinterTextEdit.EditValue = null;
			locationLookUpEdit.EditValue = null;

			userPermissionsGridControl.DataSource = m_UserPermissions.GetUserPermissionsByUserName("", null);
			customersXPCollection.Criteria = CriteriaOperator.Parse("User.strUserName IS NULL");

			passwordTextEdit.Properties.ReadOnly = false;
			confirmTextEdit.Properties.ReadOnly = false;
			LPNPrinterTextEdit.Properties.ReadOnly = false;
			locationLookUpEdit.Properties.ReadOnly = false;
			resetSimpleButton.Enabled = true;
			usersListBoxControl.Enabled = false;
			userPermissionsGridView.OptionsBehavior.Editable = true;
			customersGridView.OptionsBehavior.Editable = true;

			cancelBarButtonItem.Enabled = true;
			saveBarButtonItem.Enabled = true;
			editBarButtonItem.Enabled = false;
			addBarButtonItem.Enabled = false;
			deleteBarButtonItem.Enabled = false;

		}

		private void CancelChanges()
		{

			if (usersListBoxControl.SelectedIndex != -1)
			{
				if (m_CustomersUOW.InTransaction == true)
				{
					m_CustomersUOW.RollbackTransaction();
				}
				BindSecurityControls(usersListBoxControl.SelectedValue.ToString());
			}

			passwordTextEdit.Properties.ReadOnly = true;
			confirmTextEdit.Properties.ReadOnly = true;
			locationLookUpEdit.Properties.ReadOnly = true;
			resetSimpleButton.Enabled = false;
			usersListBoxControl.Enabled = true;
			userPermissionsGridView.OptionsBehavior.Editable = false;
			customersGridView.OptionsBehavior.Editable = false;

		}

		private void cancelBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			CancelChanges();
			CheckPermissions();
			cancelBarButtonItem.Enabled = false;
			saveBarButtonItem.Enabled = false;

		}

		private void deleteBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (nameTextEdit.Text.ToLower() == "admin")
			{
				MessageBox.Show("You can't Delete the Admin User");
				return;
			}

			if (MessageBox.Show("Are you sure you want to delete this user?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (m_UserPermissions.DeleteUserPermissions(nameTextEdit.Text) != true)
				{
					MessageBox.Show("The user permissions was not deleted succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				//The assigned customers will be deleted by XPO it's aggregated to the user
				if (m_Users.DeleteUser(nameTextEdit.Text) != true)
				{
					MessageBox.Show("The user was not deleted succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			BindUsersListBox();

			passwordTextEdit.Properties.ReadOnly = true;
			confirmTextEdit.Properties.ReadOnly = true;
			locationLookUpEdit.Properties.ReadOnly = true;
			resetSimpleButton.Enabled = false;
			usersListBoxControl.Enabled = true;
			userPermissionsGridView.OptionsBehavior.Editable = false;
			customersGridView.OptionsBehavior.Editable = false;

		}

		private void PermissionsRepositoryItemComboBox_EditValueChanged(object sender, EventArgs e)
		{

			userPermissionsGridView.PostEditor();

		}

		private void editBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			passwordTextEdit.Properties.ReadOnly = false;
			confirmTextEdit.Properties.ReadOnly = false;
			LPNPrinterTextEdit.Properties.ReadOnly = false;
			locationLookUpEdit.Properties.ReadOnly = false;
			resetSimpleButton.Enabled = true;
			usersListBoxControl.Enabled = false;
			userPermissionsGridView.OptionsBehavior.Editable = true;
			customersGridView.OptionsBehavior.Editable = true;

			cancelBarButtonItem.Enabled = true;
			saveBarButtonItem.Enabled = true;
			editBarButtonItem.Enabled = false;
			addBarButtonItem.Enabled = false;
			deleteBarButtonItem.Enabled = false;

		}

		private void userPermissionsGridView_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
		{

			if (userPermissionsGridView.GetFocusedRowCellValue(permissionObjectGridColumn).ToString() == "Financial Tabs" || userPermissionsGridView.GetFocusedRowCellValue(permissionObjectGridColumn).ToString() == "Advanced Tabs" || userPermissionsGridView.GetFocusedRowCellValue(permissionObjectGridColumn).ToString() == "Security Settings")
			{
				if (Properties.Settings.Default.UserSecurityLevel != "Admin")
				{
					e.Cancel = true;
				}
			}

		}

		private void customersGridView_InitNewRow(object sender, InitNewRowEventArgs e)
		{

			customersGridView.SetFocusedRowCellValue("User!Key", usersListBoxControl.SelectedValue.ToString());

		}

		private void customersXPCollection_ResolveSession(object sender, ResolveSessionEventArgs e)
		{

			e.Session = m_CustomersUOW;

		}

		private void customerRepositoryItemLookUpEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
		{

			if (e.CloseMode != PopupCloseMode.Cancel)
			{
				GridView view = (GridView)(((GridControl)(((LookUpEdit)sender).Parent)).FocusedView);
				if (view.IsNewItemRow(view.FocusedRowHandle))
				{
					view.CloseEditor();
					view.UpdateCurrentRow();
				}
			}

		}

		private void resetSimpleButton_Click(object sender, EventArgs e)
		{

			m_UserPermissions.DeleteUserPermissions(nameTextEdit.Text);
			if (m_UserPermissions.CreateNewUserPermissions(nameTextEdit.Text) == false)
			{
				MessageBox.Show("The permissions were not created succesfuly.");
			}

		}

	}
}