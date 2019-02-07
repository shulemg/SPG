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

			if (this.usersListBoxControl.Enabled == false)
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

			this.usersListBoxControl.ValueMember = "strUserName";
			usersListBoxControl.DisplayMember = "strUserName";
			BindUsersListBox();

			this.permissionIDGridColumn.FieldName = "UserPermissionID";
			this.permissionLevelGridColumn.FieldName = "PermissionLevel";
			this.permissionObjectGridColumn.FieldName = "PermissionObject";
			this.userNaemGridColumn.FieldName = "UserName";

			this.passwordTextEdit.Properties.ReadOnly = true;
			this.confirmTextEdit.Properties.ReadOnly = true;
			this.LPNPrinterTextEdit.Properties.ReadOnly = true;
			locationLookUpEdit.Properties.ReadOnly = true;
			resetSimpleButton.Enabled = false;
			this.usersListBoxControl.Enabled = true;
			this.userPermissionsGridView.OptionsBehavior.Editable = false;
			this.customersGridView.OptionsBehavior.Editable = false;

			m_CustomersUOW = new UnitOfWork(MyDataLayers.SPGDataLayer);

		}

		public void BindUsersListBox()
		{

			this.usersListBoxControl.DataSource = m_Users.GetUsers();

		}

		private void usersListBoxControl_SelectedValueChanged(object sender, EventArgs e)
		{

			if (this.usersListBoxControl.SelectedIndex != -1)
			{
				BindSecurityControls(this.usersListBoxControl.SelectedValue.ToString());
			}

		}

		public void BindSecurityControls(string username)
		{

			Users user = UsersBLL.GetUserByName(m_CustomersUOW, username);
			this.nameTextEdit.EditValue = user.strUserName;
			this.nameTextEdit.Enabled = false;
			this.passwordTextEdit.EditValue = user.strPassword;
			this.confirmTextEdit.EditValue = user.strPassword;
			this.LPNPrinterTextEdit.EditValue = user.LPNPrinterName;
			try
			{
				locationLookUpEdit.EditValue = UsersBLL.GetUserByName(m_CustomersUOW, user.strUserName).DefaultLocation.Oid;
			}
			catch
			{
				locationLookUpEdit.EditValue = null;
			}

			this.userPermissionsGridControl.DataSource = m_UserPermissions.GetUserPermissionsByUserName(user.strUserName, null);
			if (user.strUserName == "Admin")
			{
				this.customersXtraTabPage.PageVisible = false;
			}
			else
			{
				this.customersXtraTabPage.PageVisible = true;
				this.customersXPCollection.Criteria = CriteriaOperator.Parse(string.Format("User.strUserName = '{0}'", user));
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
						this.passwordTextEdit.Properties.PasswordChar = '\0';
						this.confirmTextEdit.Properties.PasswordChar = '\0';
						this.addBarButtonItem.Enabled = true;
						this.editBarButtonItem.Enabled = true;
						this.deleteBarButtonItem.Enabled = true;
						break;
					case "ADD":
					case "Add":
						this.passwordTextEdit.Properties.PasswordChar = '*';
						this.confirmTextEdit.Properties.PasswordChar = '*';
						this.addBarButtonItem.Enabled = true;
						this.editBarButtonItem.Enabled = true;
						this.deleteBarButtonItem.Enabled = false;
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
						this.passwordTextEdit.Properties.PasswordChar = '*';
						this.confirmTextEdit.Properties.PasswordChar = '*';
						this.addBarButtonItem.Enabled = false;
						this.editBarButtonItem.Enabled = false;
						this.deleteBarButtonItem.Enabled = false;
						break;
					case "EDIT":
					case "Edit":
						this.passwordTextEdit.Properties.PasswordChar = '*';
						this.confirmTextEdit.Properties.PasswordChar = '*';
						this.addBarButtonItem.Enabled = false;
						this.editBarButtonItem.Enabled = true;
						this.deleteBarButtonItem.Enabled = false;
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

		private bool SaveChanges()
		{

			string selectedUser = this.nameTextEdit.Text;

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
				if (m_Users.UpdateUser(selectedUser, this.passwordTextEdit.Text, this.confirmTextEdit.Text, location, this.LPNPrinterTextEdit.Text) != true)
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
				this.userPermissionsGridView.SelectAll();
				if (this.userPermissionsGridView.SelectedRowsCount > 0)
				{
					int permissions = this.userPermissionsGridView.SelectedRowsCount;
					int i = 0;
					while (i < permissions)
					{
						int permission = this.userPermissionsGridView.GetSelectedRows()[i];
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
			this.usersListBoxControl.SelectedValue = selectedUser;

			this.passwordTextEdit.Properties.ReadOnly = true;
			this.confirmTextEdit.Properties.ReadOnly = true;
			this.LPNPrinterTextEdit.Properties.ReadOnly = true;
			locationLookUpEdit.Properties.ReadOnly = true;
			resetSimpleButton.Enabled = false;
			this.usersListBoxControl.Enabled = true;
			this.userPermissionsGridView.OptionsBehavior.Editable = false;
			this.customersGridView.OptionsBehavior.Editable = false;
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

			this.nameTextEdit.Text = null;
			this.nameTextEdit.Enabled = true;
			this.passwordTextEdit.EditValue = null;
			this.confirmTextEdit.EditValue = null;
			this.LPNPrinterTextEdit.EditValue = null;
			locationLookUpEdit.EditValue = null;

			this.userPermissionsGridControl.DataSource = m_UserPermissions.GetUserPermissionsByUserName("", null);
			this.customersXPCollection.Criteria = CriteriaOperator.Parse("User.strUserName IS NULL");

			this.passwordTextEdit.Properties.ReadOnly = false;
			this.confirmTextEdit.Properties.ReadOnly = false;
			this.LPNPrinterTextEdit.Properties.ReadOnly = false;
			locationLookUpEdit.Properties.ReadOnly = false;
			resetSimpleButton.Enabled = true;
			this.usersListBoxControl.Enabled = false;
			this.userPermissionsGridView.OptionsBehavior.Editable = true;
			this.customersGridView.OptionsBehavior.Editable = true;

			this.cancelBarButtonItem.Enabled = true;
			this.saveBarButtonItem.Enabled = true;
			this.editBarButtonItem.Enabled = false;
			this.addBarButtonItem.Enabled = false;
			this.deleteBarButtonItem.Enabled = false;

		}

		private void CancelChanges()
		{

			if (this.usersListBoxControl.SelectedIndex != -1)
			{
				if (m_CustomersUOW.InTransaction == true)
				{
					m_CustomersUOW.RollbackTransaction();
				}
				BindSecurityControls(this.usersListBoxControl.SelectedValue.ToString());
			}

			this.passwordTextEdit.Properties.ReadOnly = true;
			this.confirmTextEdit.Properties.ReadOnly = true;
			locationLookUpEdit.Properties.ReadOnly = true;
			resetSimpleButton.Enabled = false;
			this.usersListBoxControl.Enabled = true;
			this.userPermissionsGridView.OptionsBehavior.Editable = false;
			this.customersGridView.OptionsBehavior.Editable = false;

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

			if (this.nameTextEdit.Text.ToLower() == "admin")
			{
				MessageBox.Show("You can't Delete the Admin User");
				return;
			}

			if (MessageBox.Show("Are you sure you want to delete this user?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (m_UserPermissions.DeleteUserPermissions(this.nameTextEdit.Text) != true)
				{
					MessageBox.Show("The user permissions was not deleted succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				//The assigned customers will be deleted by XPO it's aggregated to the user
				if (m_Users.DeleteUser(this.nameTextEdit.Text) != true)
				{
					MessageBox.Show("The user was not deleted succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			BindUsersListBox();

			this.passwordTextEdit.Properties.ReadOnly = true;
			this.confirmTextEdit.Properties.ReadOnly = true;
			locationLookUpEdit.Properties.ReadOnly = true;
			resetSimpleButton.Enabled = false;
			this.usersListBoxControl.Enabled = true;
			this.userPermissionsGridView.OptionsBehavior.Editable = false;
			this.customersGridView.OptionsBehavior.Editable = false;

		}

		private void PermissionsRepositoryItemComboBox_EditValueChanged(object sender, EventArgs e)
		{

			this.userPermissionsGridView.PostEditor();

		}

		private void editBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			this.passwordTextEdit.Properties.ReadOnly = false;
			this.confirmTextEdit.Properties.ReadOnly = false;
			this.LPNPrinterTextEdit.Properties.ReadOnly = false;
			locationLookUpEdit.Properties.ReadOnly = false;
			resetSimpleButton.Enabled = true;
			this.usersListBoxControl.Enabled = false;
			this.userPermissionsGridView.OptionsBehavior.Editable = true;
			this.customersGridView.OptionsBehavior.Editable = true;

			this.cancelBarButtonItem.Enabled = true;
			this.saveBarButtonItem.Enabled = true;
			this.editBarButtonItem.Enabled = false;
			this.addBarButtonItem.Enabled = false;
			this.deleteBarButtonItem.Enabled = false;

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

			this.customersGridView.SetFocusedRowCellValue("User!Key", usersListBoxControl.SelectedValue.ToString());

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

			m_UserPermissions.DeleteUserPermissions(this.nameTextEdit.Text);
			if (m_UserPermissions.CreateNewUserPermissions(nameTextEdit.Text) == false)
			{
				MessageBox.Show("The permissions were not created succesfuly.");
			}

		}

	}
}