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

			if (this.carriersSearchGridControl.Enabled == false)
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

			this.Cursor = Cursors.WaitCursor;
			m_Carriers = new CarriersBLL();

			BindCarrierSearch();

			CheckPermissions();

			Utilities.MakeFormReadOnly(this.carriersXtraTabPage, true);
			this.carriersSearchGridControl.Enabled = true;

			cancelBarButtonItem.Enabled = false;
			saveBarButtonItem.Enabled = false;

			this.Cursor = Cursors.Default;

		}

		public void BindCarrierSearch()
		{

			//Me.carrierListBoxControl.DisplayMember = "CarrierName"
			//Me.carrierListBoxControl.ValueMember = "CarrierID"
			this.carriersSearchGridControl.DataSource = m_Carriers.GetCarrierIDAndNames();

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
				if (m_Carriers.UpdateCarrier(m_CurrentCarrierID.Value, this.nameTextEdit.Text, firstName, lastName, this.addressTextEdit.Text, this.cityTextEdit.Text, this.stateTextEdit.Text, this.postalTextEdit.Text, this.phoneTextEdit.Text, this.emailTextEdit.Text, this.faxTextEdit.Text, this.noteMemoEdit.Text) != true)
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
			this.carriersSearchGridView.FocusedRowHandle = selectedID;
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
			this.nameTextEdit.Text = carrier.CarrierName;
			this.firstNameTextEdit.Text = carrier.ContactFirstName;
			this.lastNameTextEdit.Text = carrier.ContactLastName;
			this.addressTextEdit.Text = carrier.Address;
			this.cityTextEdit.Text = carrier.City;
			this.stateTextEdit.Text = carrier.State;
			this.postalTextEdit.Text = carrier.Postal;
			this.phoneTextEdit.Text = carrier.Phone;
			this.emailTextEdit.Text = carrier.Email;
			this.faxTextEdit.Text = carrier.Fax;
			this.noteMemoEdit.Text = carrier.Note;

		}

		private void addSimpleButton_Click(System.Object sender, EventArgs e)
		{

			m_CurrentCarrierID = null;
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

			//If Me.carrierListBoxControl.SelectedIndex <> -1 Then
			//    BindCarrierControls(CType(Me.carrierListBoxControl.SelectedValue, Integer))
			//End If

		}

		private void carriersSearchGridView_Click(object sender, EventArgs e)
		{

			if (this.carriersSearchGridView.CalcHitInfo(this.carriersSearchGridControl.PointToClient(Control.MousePosition)).HitTest == GridHitTest.RowCell)
			{
				this.BindCarrierControls(Convert.ToInt32(this.carriersSearchGridView.GetFocusedRowCellValue(this.carrierIDGridColumn)));
			}

		}

		private void addBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			m_CurrentCarrierID = null;
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

			this.carriersSearchGridView.FocusedRowHandle = -1;
			Utilities.MakeFormReadOnly(this.carriersXtraTabPage, false);
			this.carriersSearchGridControl.Enabled = false;
			CheckPermissions();

			this.cancelBarButtonItem.Enabled = true;
			this.saveBarButtonItem.Enabled = true;
			this.editBarButtonItem.Enabled = false;
			this.addBarButtonItem.Enabled = false;

		}

		private void editBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (m_CurrentCarrierID == null)
			{
				MessageBox.Show("Please select a carrier to edit.");
				return;
			}

			Utilities.MakeFormReadOnly(this.carriersXtraTabPage, false);
			this.carriersSearchGridControl.Enabled = false;
			CheckPermissions();

			this.cancelBarButtonItem.Enabled = true;
			this.saveBarButtonItem.Enabled = true;
			this.editBarButtonItem.Enabled = false;
			this.addBarButtonItem.Enabled = false;

		}

		private void cancelBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			CancelChanges();

			CheckPermissions();

			Utilities.MakeFormReadOnly(this.carriersXtraTabPage, true);
			this.carriersSearchGridControl.Enabled = true;

			cancelBarButtonItem.Enabled = false;
			saveBarButtonItem.Enabled = false;

		}

		private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (SaveChanges())
			{

				CheckPermissions();

				Utilities.MakeFormReadOnly(this.carriersXtraTabPage, true);
				this.carriersSearchGridControl.Enabled = true;

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

			if (this.m_CurrentCarrierID != null)
			{
				BindCarrierControls(m_CurrentCarrierID.Value);
			}

		}

	}
}