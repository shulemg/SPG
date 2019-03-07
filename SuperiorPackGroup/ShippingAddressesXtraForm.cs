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

			if (destinationsSearchGridControl.Enabled == false)
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

			Cursor = Cursors.WaitCursor;
			m_Address = new ShippingAddressBLL();

			BindDestinationsSearch();

			CheckPermissions();

			Utilities.MakeFormReadOnly(destinationsPanelControl, true);
			destinationsSearchGridControl.Enabled = true;

			cancelBarButtonItem.Enabled = false;
			saveBarButtonItem.Enabled = false;

			Cursor = Cursors.Default;

		}

		public void BindDestinationsSearch()
		{

			//Me.addressesListBoxControl.DisplayMember = "ShippingName"
			//Me.addressesListBoxControl.ValueMember = "AddressID"
			destinationsSearchGridControl.DataSource = m_Address.GetAddressNameAndIDS();

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
			nameTextEdit.Text = address.ShippingName;
			firstNameTextEdit.Text = address.ContactFirstName;
			lastNameTextEdit.Text = address.ContactLastName;
			addressTextEdit.Text = address.ShippingAddress;
			cityTextEdit.Text = address.ShippingCity;
			stateTextEdit.Text = address.ShippingState;
			postalTextEdit.Text = address.ShippingPostal;
			phoneTextEdit.Text = address.ShippingPhone;
			emailTextEdit.Text = address.ShippingEmail;
			faxTextEdit.Text = address.ShippingFax;
			noteMemoEdit.Text = address.ShippingNote;

		}

		private void addSimpleButton_Click(System.Object sender, EventArgs e)
		{

			m_CurrentDestinationID = null;
			nameTextEdit.Text = string.Empty;
			firstNameTextEdit.Text = null;
			lastNameTextEdit.Text = null;
			addressTextEdit.Text = string.Empty;
			cityTextEdit.Text = string.Empty;
			stateTextEdit.Text = string.Empty;
			postalTextEdit.Text = string.Empty;
			phoneTextEdit.Text = string.Empty;
			emailTextEdit.Text = string.Empty;
			faxTextEdit.Text = string.Empty;
			noteMemoEdit.Text = string.Empty;

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
				if (firstNameTextEdit.EditValue == null || Convert.ToString(firstNameTextEdit.EditValue) == firstNameTextEdit.Properties.NullText)
				{
					firstName = string.Empty;
				}
				else
				{
					firstName = Convert.ToString(firstNameTextEdit.EditValue);
				}
				if (lastNameTextEdit.EditValue == null || Convert.ToString(lastNameTextEdit.EditValue) == lastNameTextEdit.Properties.NullText)
				{
					lastName = string.Empty;
				}
				else
				{
					lastName = Convert.ToString(lastNameTextEdit.EditValue);
				}
				if (m_Address.UpdateAddress(m_CurrentDestinationID.Value, nameTextEdit.Text, firstName, lastName, addressTextEdit.Text, cityTextEdit.Text, stateTextEdit.Text, postalTextEdit.Text, phoneTextEdit.Text, emailTextEdit.Text, faxTextEdit.Text, noteMemoEdit.Text) != true)
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
			destinationsSearchGridView.FocusedRowHandle = selectedID;
			return true;

		}

		private void saveSimpleButton_Click(System.Object sender, EventArgs e)
		{

			//Required to get back to current customer when entering a new customer.
			SaveChanges();

		}

		private void destinationsSearchGridView_Click(object sender, EventArgs e)
		{

			if (destinationsSearchGridView.CalcHitInfo(destinationsSearchGridControl.PointToClient(Control.MousePosition)).HitTest == GridHitTest.RowCell)
			{
				BindAddressControls(Convert.ToInt32(destinationsSearchGridView.GetFocusedRowCellValue(destinationIDGridColumn)));
			}

		}

		private void addBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			m_CurrentDestinationID = null;
			nameTextEdit.Text = string.Empty;
			firstNameTextEdit.Text = null;
			lastNameTextEdit.Text = null;
			addressTextEdit.Text = string.Empty;
			cityTextEdit.Text = string.Empty;
			stateTextEdit.Text = string.Empty;
			postalTextEdit.Text = string.Empty;
			phoneTextEdit.Text = string.Empty;
			emailTextEdit.Text = string.Empty;
			faxTextEdit.Text = string.Empty;
			noteMemoEdit.Text = string.Empty;

			destinationsSearchGridView.FocusedRowHandle = -1;
			Utilities.MakeFormReadOnly(destinationsPanelControl, false);
			destinationsSearchGridControl.Enabled = false;
			CheckPermissions();

			cancelBarButtonItem.Enabled = true;
			saveBarButtonItem.Enabled = true;
			editBarButtonItem.Enabled = false;
			addBarButtonItem.Enabled = false;
			//Me.deleteBarButtonItem.Enabled = False

		}

		private void editBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (m_CurrentDestinationID == null)
			{
				MessageBox.Show("Please select a shipping destination to edit.");
				return;
			}

			Utilities.MakeFormReadOnly(destinationsPanelControl, false);
			destinationsSearchGridControl.Enabled = false;
			CheckPermissions();

			cancelBarButtonItem.Enabled = true;
			saveBarButtonItem.Enabled = true;
			editBarButtonItem.Enabled = false;
			addBarButtonItem.Enabled = false;
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

			Utilities.MakeFormReadOnly(destinationsPanelControl, true);
			destinationsSearchGridControl.Enabled = true;

			cancelBarButtonItem.Enabled = false;
			saveBarButtonItem.Enabled = false;

		}

		private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (SaveChanges())
			{

				CheckPermissions();

				Utilities.MakeFormReadOnly(destinationsPanelControl, true);
				destinationsSearchGridControl.Enabled = true;

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
						addBarButtonItem.Enabled = true;
						editBarButtonItem.Enabled = true;
						//Me.deleteBarButtonItem.Enabled = True
						break;
					case "ADD":
					case "Add":
						addBarButtonItem.Enabled = true;
						editBarButtonItem.Enabled = true;
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
						addBarButtonItem.Enabled = false;
						editBarButtonItem.Enabled = false;
						//Me.deleteBarButtonItem.Enabled = False
						break;
					case "EDIT":
					case "Edit":
						addBarButtonItem.Enabled = false;
						editBarButtonItem.Enabled = true;
						//Me.deleteBarButtonItem.Enabled = False
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

		private void CancelChanges()
		{

			if (m_CurrentDestinationID != null)
			{
				BindAddressControls(m_CurrentDestinationID.Value);
			}

		}

	}
}