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
	public partial class CarriersXtraForm
	{

		public CarriersXtraForm()
		{
			InitializeComponent();
		}

		private CarriersBLL m_Carriers;
		private int? m_CurrentCarrierID;

		private void CarriersXtraForm_FormClosing(object sender, FormClosingEventArgs e)
		{

			if (carriersSearchGridControl.Enabled == false)
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

		private void CarriersXtraForm_Load(System.Object sender, EventArgs e)
		{

			Cursor = Cursors.WaitCursor;
			m_Carriers = new CarriersBLL();

			BindCarrierSearch();

			CheckPermissions();

			Utilities.MakeFormReadOnly(carriersXtraTabPage, true);
			carriersSearchGridControl.Enabled = true;

			cancelBarButtonItem.Enabled = false;
			saveBarButtonItem.Enabled = false;

			Cursor = Cursors.Default;

		}

		public void BindCarrierSearch()
		{

			//Me.carrierListBoxControl.DisplayMember = "CarrierName"
			//Me.carrierListBoxControl.ValueMember = "CarrierID"
			carriersSearchGridControl.DataSource = m_Carriers.GetCarrierIDAndNames();

		}

		private bool SaveChanges()
		{

			//Required to get back to current carrier when entering a new carrier.
			int selectedID = -1;

			if (m_CurrentCarrierID.HasValue == false)
			{
				m_CurrentCarrierID = m_Carriers.GetNewCarrierID();
			}
			else
			{
				selectedID = carriersSearchGridView.FocusedRowHandle;
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
				if (m_Carriers.UpdateCarrier(m_CurrentCarrierID.Value, nameTextEdit.Text, firstName, lastName, addressTextEdit.Text, cityTextEdit.Text, stateTextEdit.Text, postalTextEdit.Text, phoneTextEdit.Text, emailTextEdit.Text, faxTextEdit.Text, noteMemoEdit.Text) != true)
				{
					MessageBox.Show("The carrier was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}
			catch (ApplicationException ex)
			{
				MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			BindCarrierSearch();
			carriersSearchGridView.FocusedRowHandle = selectedID;
			return true;

		}

		private void saveSimpleButton_Click(System.Object sender, EventArgs e)
		{

			SaveChanges();

		}

		private void carrierListBoxControl_SelectedValueChanged(System.Object sender, EventArgs e)
		{

			//If Me.carrierListBoxControl.SelectedIndex <> -1 Then
			//    BindCarrierControls(CType(Me.carrierListBoxControl.SelectedValue, Integer))
			//End If

		}

		public void BindCarrierControls(int carrierID)
		{

			SPG.CarriersRow carrier = (SPG.CarriersRow)(m_Carriers.GetCarrierByID(carrierID).Rows[0]);

			m_CurrentCarrierID = carrier.CarrierID;
			nameTextEdit.Text = carrier.CarrierName;
			firstNameTextEdit.Text = carrier.ContactFirstName;
			lastNameTextEdit.Text = carrier.ContactLastName;
			addressTextEdit.Text = carrier.Address;
			cityTextEdit.Text = carrier.City;
			stateTextEdit.Text = carrier.State;
			postalTextEdit.Text = carrier.Postal;
			phoneTextEdit.Text = carrier.Phone;
			emailTextEdit.Text = carrier.Email;
			faxTextEdit.Text = carrier.Fax;
			noteMemoEdit.Text = carrier.Note;

		}

		private void addSimpleButton_Click(System.Object sender, EventArgs e)
		{

			m_CurrentCarrierID = null;
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

			//If Me.carrierListBoxControl.SelectedIndex <> -1 Then
			//    BindCarrierControls(CType(Me.carrierListBoxControl.SelectedValue, Integer))
			//End If

		}

		private void carriersSearchGridView_Click(object sender, EventArgs e)
		{

			if (carriersSearchGridView.CalcHitInfo(carriersSearchGridControl.PointToClient(Control.MousePosition)).HitTest == GridHitTest.RowCell)
			{
				BindCarrierControls(Convert.ToInt32(carriersSearchGridView.GetFocusedRowCellValue(carrierIDGridColumn)));
			}

		}

		private void addBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			m_CurrentCarrierID = null;
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

			carriersSearchGridView.FocusedRowHandle = -1;
			Utilities.MakeFormReadOnly(carriersXtraTabPage, false);
			carriersSearchGridControl.Enabled = false;
			CheckPermissions();

			cancelBarButtonItem.Enabled = true;
			saveBarButtonItem.Enabled = true;
			editBarButtonItem.Enabled = false;
			addBarButtonItem.Enabled = false;

		}

		private void editBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (m_CurrentCarrierID == null)
			{
				MessageBox.Show("Please select a carrier to edit.");
				return;
			}

			Utilities.MakeFormReadOnly(carriersXtraTabPage, false);
			carriersSearchGridControl.Enabled = false;
			CheckPermissions();

			cancelBarButtonItem.Enabled = true;
			saveBarButtonItem.Enabled = true;
			editBarButtonItem.Enabled = false;
			addBarButtonItem.Enabled = false;

		}

		private void cancelBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			CancelChanges();

			CheckPermissions();

			Utilities.MakeFormReadOnly(carriersXtraTabPage, true);
			carriersSearchGridControl.Enabled = true;

			cancelBarButtonItem.Enabled = false;
			saveBarButtonItem.Enabled = false;

		}

		private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (SaveChanges())
			{

				CheckPermissions();

				Utilities.MakeFormReadOnly(carriersXtraTabPage, true);
				carriersSearchGridControl.Enabled = true;

				cancelBarButtonItem.Enabled = false;
				saveBarButtonItem.Enabled = false;
			}

		}

		public bool CheckPermissions()
		{

			try
			{
				SPG.UserPermissionsRow permission = (new UserPermissionsBLL()).GetUserPermissionsByUserName(Properties.Settings.Default.UserName, "Carrierss Form")[0];

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

			if (m_CurrentCarrierID != null)
			{
				BindCarrierControls(m_CurrentCarrierID.Value);
			}

		}

	}
}