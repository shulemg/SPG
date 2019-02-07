//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace SuperiorPackGroup
{
	public partial class ShippingAddressesXtraForm
	{

		public ShippingAddressesXtraForm()
		{
			InitializeComponent();
		}

		private ShippingAddressBLL m_Address;
		private int? m_CurrentDestinationID;

		private void ShippingAddressesXtraForm_FormClosing(object sender, FormClosingEventArgs e)
		{

			if (this.destinationsSearchGridControl.Enabled == false)
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

		private void ShippingAddressesXtraForm_Load(object sender, EventArgs e)
		{

			this.Cursor = Cursors.WaitCursor;
			m_Address = new ShippingAddressBLL();

			BindDestinationsSearch();

			CheckPermissions();

			Utilities.MakeFormReadOnly(this.destinationsPanelControl, true);
			this.destinationsSearchGridControl.Enabled = true;

			cancelBarButtonItem.Enabled = false;
			saveBarButtonItem.Enabled = false;

			this.Cursor = Cursors.Default;

		}

		public void BindDestinationsSearch()
		{

			//Me.addressesListBoxControl.DisplayMember = "ShippingName"
			//Me.addressesListBoxControl.ValueMember = "AddressID"
			this.destinationsSearchGridControl.DataSource = m_Address.GetAddressNameAndIDS();

		}

		private void addressesListBoxControl_SelectedValueChanged(object sender, EventArgs e)
		{

			//If Me.addressesListBoxControl.SelectedIndex <> -1 Then
			//    BindAddressControls(CType(Me.addressesListBoxControl.SelectedValue, Integer))
			//End If

		}

		public void BindAddressControls(int addressID)
		{

			SPG.ShippingAddressesRow address = (SPG.ShippingAddressesRow)(m_Address.GetAddressByID(addressID).Rows[0]);

			m_CurrentDestinationID = address.AddressID;
			this.nameTextEdit.Text = address.ShippingName;
			this.firstNameTextEdit.Text = address.ContactFirstName;
			this.lastNameTextEdit.Text = address.ContactLastName;
			this.addressTextEdit.Text = address.ShippingAddress;
			this.cityTextEdit.Text = address.ShippingCity;
			this.stateTextEdit.Text = address.ShippingState;
			this.postalTextEdit.Text = address.ShippingPostal;
			this.phoneTextEdit.Text = address.ShippingPhone;
			this.emailTextEdit.Text = address.ShippingEmail;
			this.faxTextEdit.Text = address.ShippingFax;
			this.noteMemoEdit.Text = address.ShippingNote;

		}

		private void addSimpleButton_Click(System.Object sender, EventArgs e)
		{

			m_CurrentDestinationID = null;
			this.nameTextEdit.Text = string.Empty;
			this.firstNameTextEdit.Text = null;
			this.lastNameTextEdit.Text = null;
			this.addressTextEdit.Text = string.Empty;
			this.cityTextEdit.Text = string.Empty;
			this.stateTextEdit.Text = string.Empty;
			this.postalTextEdit.Text = string.Empty;
			this.phoneTextEdit.Text = string.Empty;
			this.emailTextEdit.Text = string.Empty;
			this.faxTextEdit.Text = string.Empty;
			this.noteMemoEdit.Text = string.Empty;

		}

		private void cancelSimpleButton_Click(System.Object sender, EventArgs e)
		{

			//If Me.addressesListBoxControl.SelectedIndex <> -1 Then
			//    BindAddressControls(CType(Me.addressesListBoxControl.SelectedValue, Integer))
			//End If

		}

		private bool SaveChanges()
		{

			int selectedID = -1;

			if (m_CurrentDestinationID.HasValue == false)
			{
				m_CurrentDestinationID = m_Address.GetNewAddressID();
			}
			else
			{
				selectedID = destinationsSearchGridView.FocusedRowHandle;
			}

			try
			{
				string firstName = null;
				string lastName = null;
				if (this.firstNameTextEdit.EditValue == null || Convert.ToString(this.firstNameTextEdit.EditValue) == this.firstNameTextEdit.Properties.NullText)
				{
					firstName = string.Empty;
				}
				else
				{
					firstName = Convert.ToString(this.firstNameTextEdit.EditValue);
				}
				if (this.lastNameTextEdit.EditValue == null || Convert.ToString(this.lastNameTextEdit.EditValue) == this.lastNameTextEdit.Properties.NullText)
				{
					lastName = string.Empty;
				}
				else
				{
					lastName = Convert.ToString(this.lastNameTextEdit.EditValue);
				}
				if (m_Address.UpdateAddress(m_CurrentDestinationID.Value, this.nameTextEdit.Text, firstName, lastName, this.addressTextEdit.Text, this.cityTextEdit.Text, this.stateTextEdit.Text, this.postalTextEdit.Text, this.phoneTextEdit.Text, this.emailTextEdit.Text, this.faxTextEdit.Text, this.noteMemoEdit.Text) != true)
				{
					MessageBox.Show("The shipping address was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}
			catch (ApplicationException ex)
			{
				MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			BindDestinationsSearch();
			this.destinationsSearchGridView.FocusedRowHandle = selectedID;
			return true;

		}

		private void saveSimpleButton_Click(System.Object sender, EventArgs e)
		{

			//Required to get back to current customer when entering a new customer.
			SaveChanges();

		}

		private void destinationsSearchGridView_Click(object sender, EventArgs e)
		{

			if (this.destinationsSearchGridView.CalcHitInfo(this.destinationsSearchGridControl.PointToClient(Control.MousePosition)).HitTest == GridHitTest.RowCell)
			{
				this.BindAddressControls(Convert.ToInt32(this.destinationsSearchGridView.GetFocusedRowCellValue(this.destinationIDGridColumn)));
			}

		}

		private void addBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			m_CurrentDestinationID = null;
			this.nameTextEdit.Text = string.Empty;
			this.firstNameTextEdit.Text = null;
			this.lastNameTextEdit.Text = null;
			this.addressTextEdit.Text = string.Empty;
			this.cityTextEdit.Text = string.Empty;
			this.stateTextEdit.Text = string.Empty;
			this.postalTextEdit.Text = string.Empty;
			this.phoneTextEdit.Text = string.Empty;
			this.emailTextEdit.Text = string.Empty;
			this.faxTextEdit.Text = string.Empty;
			this.noteMemoEdit.Text = string.Empty;

			this.destinationsSearchGridView.FocusedRowHandle = -1;
			Utilities.MakeFormReadOnly(this.destinationsPanelControl, false);
			this.destinationsSearchGridControl.Enabled = false;
			CheckPermissions();

			this.cancelBarButtonItem.Enabled = true;
			this.saveBarButtonItem.Enabled = true;
			this.editBarButtonItem.Enabled = false;
			this.addBarButtonItem.Enabled = false;
			//Me.deleteBarButtonItem.Enabled = False

		}

		private void editBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (m_CurrentDestinationID == null)
			{
				MessageBox.Show("Please select a shipping destination to edit.");
				return;
			}

			Utilities.MakeFormReadOnly(this.destinationsPanelControl, false);
			this.destinationsSearchGridControl.Enabled = false;
			CheckPermissions();

			this.cancelBarButtonItem.Enabled = true;
			this.saveBarButtonItem.Enabled = true;
			this.editBarButtonItem.Enabled = false;
			this.addBarButtonItem.Enabled = false;
			//Me.deleteBarButtonItem.Enabled = False

		}

		private void deleteBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			//If MessageBox.Show("Are you sure you want to delete this destination.", "Delete Destination", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.No Then
			//    Exit Sub
			//End If

			//Try
			//    If m_Address.DeleteDestination(m_CurrentDestinationID.Value) = True Then
			//        BindDestinationsSearch()
			//    Else
			//        MessageBox.Show("The destination was not deleted.")
			//    End If
			//Catch ex As ApplicationException
			//    MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
			//End Try

		}

		private void cancelBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			CancelChanges();

			CheckPermissions();

			Utilities.MakeFormReadOnly(this.destinationsPanelControl, true);
			this.destinationsSearchGridControl.Enabled = true;

			cancelBarButtonItem.Enabled = false;
			saveBarButtonItem.Enabled = false;

		}

		private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (SaveChanges())
			{

				CheckPermissions();

				Utilities.MakeFormReadOnly(this.destinationsPanelControl, true);
				this.destinationsSearchGridControl.Enabled = true;

				cancelBarButtonItem.Enabled = false;
				saveBarButtonItem.Enabled = false;
			}

		}

		public bool CheckPermissions()
		{

			try
			{
				SPG.UserPermissionsRow permission = (new UserPermissionsBLL()).GetUserPermissionsByUserName(Properties.Settings.Default.UserName, "Shipping Destinations Form")[0];

				switch (permission.PermissionLevel)
				{
					case "FULL":
					case "Full":
						this.addBarButtonItem.Enabled = true;
						this.editBarButtonItem.Enabled = true;
						//Me.deleteBarButtonItem.Enabled = True
						break;
					case "ADD":
					case "Add":
						this.addBarButtonItem.Enabled = true;
						this.editBarButtonItem.Enabled = true;
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
						this.addBarButtonItem.Enabled = false;
						this.editBarButtonItem.Enabled = false;
						//Me.deleteBarButtonItem.Enabled = False
						break;
					case "EDIT":
					case "Edit":
						this.addBarButtonItem.Enabled = false;
						this.editBarButtonItem.Enabled = true;
						//Me.deleteBarButtonItem.Enabled = False
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

		private void CancelChanges()
		{

			if (this.m_CurrentDestinationID != null)
			{
				BindAddressControls(m_CurrentDestinationID.Value);
			}

		}

	}
}