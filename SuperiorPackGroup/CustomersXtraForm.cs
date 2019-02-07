//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Data.Filtering;
using DXDAL.SPGData;
using DevExpress.Xpo;

namespace SuperiorPackGroup
{
	public partial class CustomersXtraForm
	{

		public CustomersXtraForm()
		{
			InitializeComponent();
		}

		protected CustomersBLL m_Customer;
		protected ItemsBLL m_CustomersItems;
		protected ReceivingsBLL m_Receiving;
		protected ReceivingDetailsBLL m_ReceivingDetails;
		protected ProductionBLL m_Production;
		protected ShippingsBLL m_Shippings;
		protected UserPermissionsBLL m_UserPermissions;
		private int? m_CurrentCustomer;
		private Session m_CustomersSession;

		private void CustomersXtraForm_FormClosing(object sender, FormClosingEventArgs e)
		{

			if (this.customerSearchGridControl.Enabled == false)
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

		private void CustomersXtraForm_Load(object sender, EventArgs e)
		{

			this.Cursor = Cursors.WaitCursor;
			m_Customer = new CustomersBLL();
			m_CustomersItems = new ItemsBLL();
			m_Receiving = new ReceivingsBLL();
			m_ReceivingDetails = new ReceivingDetailsBLL();
			m_Production = new ProductionBLL();
			m_Shippings = new ShippingsBLL();
			m_UserPermissions = new UserPermissionsBLL();

			m_CustomersSession = new Session(MyDataLayers.SPGDataLayer);
			m_CustomersSession.TrackPropertiesModifications = true;
			m_CustomersSession.OptimisticLockingReadBehavior = OptimisticLockingReadBehavior.MergeCollisionThrowException;

			CheckPermissions();

			for (int i = 0; i < components.Components.Count; i++)
			{
				if ((components.Components[i]) is XPView)
				{
					((XPView)components.Components[i]).Session = m_CustomersSession;
				}
				else if ((components.Components[i]) is XPCollection)
				{
					((XPCollection)components.Components[i]).Session = m_CustomersSession;
				}
			}

			BindCustomerSearch();
			customerShiftsXpCollection.Criteria = new BinaryOperator(CustomerShifts.Fields.Customer, null, BinaryOperatorType.Equal);
			customerPlantsXpCollection.Criteria = new BinaryOperator(CustomerPlants.Fields.Customer, null, BinaryOperatorType.Equal);

			Utilities.MakeFormReadOnly(this.generalXtraTabPage, true);
			addRelatedCustomerGroupControl.Enabled = false;
			customerPlantsGridView.OptionsBehavior.Editable = false;
			customerShiftsGridView.OptionsBehavior.Editable = false;
			deleteGridColumn.Visible = false;
			deleteCustomerPlantGridColumn.Visible = false;
			deleteCustomerShiftGridColumn.Visible = false;
			this.customerSearchGridControl.Enabled = true;

			Cursor = Cursors.Default;

		}

		public void BindCustomerSearch()
		{

			if (inactiveSearchCheckEdit.Checked == false)
			{
				customerSearchXPView.Criteria = new BinaryOperator(Customers.Fields.Inactive.PropertyName, false, BinaryOperatorType.Equal);
			}
			else
			{
				customerSearchXPView.Criteria = null;
			}

			customerSearchXPView.Reload();
			customersXpView.Reload();

		}

		public void BindCustomersControls(int customerID)
		{

			m_CustomersSession.DropIdentityMap();

			Customers customer = CustomersBLL.GetCustomer(customerID, m_CustomersSession);
			m_CurrentCustomer = customer.CustomerID;
			nameTextEdit.Text = customer.CustomerName;
			contactTextEdit.Text = customer.CustomerContact;
			phoneTextEdit.Text = customer.CustomerPhone;
			emailTextEdit.Text = customer.CustomerEmail;
			faxTextEdit.Text = customer.CustomerFax;
			noteMemoEdit.Text = customer.CustomerNote;
			addressTextEdit.Text = customer.Address;
			cityTextEdit.Text = customer.City;
			stateTextEdit.Text = customer.State;
			postalTextEdit.Text = customer.ZipCode;
			inactiveCheckEdit.Checked = customer.Inactive;
			lpnPrefixTextEdit.Text = customer.LPNPrefix;
			firstLPNNumberTextEdit.EditValue = customer.FirstLPNNumber;
			lastLPNNumberTextEdit.EditValue = customer.LastLPNNumber;
			plantCodeTextEdit.EditValue = customer.PlantCode;
			lpnGroupControl.Text = string.Format("LPN Settings - Next LPN Number: {0}", customer.NextLPNNumber);
			expirationDateFormatComboBox.EditValue = customer.ExpirationDateFormat;
			if (customer.DefaultLotCodeFormat != null)
			{
				lotCodeFormatLookUpEdit.EditValue = customer.DefaultLotCodeFormat.Oid;
			}
			else
			{
				lotCodeFormatLookUpEdit.EditValue = null;
			}

			customerItemsXpCollection.Criteria = new GroupOperator(GroupOperatorType.And, new BinaryOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, m_CurrentCustomer.Value, BinaryOperatorType.Equal), new BinaryOperator(Items.Fields.ItemType.PropertyName, "FG", BinaryOperatorType.Equal), new BinaryOperator(Items.Fields.Inactive.PropertyName, false, BinaryOperatorType.Equal));
			relatedCustomerXpCollection.Criteria = new BinaryOperator(RelatedCustomer.Fields.MainCustomer.PropertyName, CustomersBLL.GetCustomer(m_CurrentCustomer.Value, m_CustomersSession), BinaryOperatorType.Equal);
			customerPlantsXpCollection.Criteria = new BinaryOperator(CustomerPlants.Fields.Customer.CustomerID.PropertyName, m_CurrentCustomer.Value, BinaryOperatorType.Equal);
			customerShiftsXpCollection.Criteria = new BinaryOperator(CustomerShifts.Fields.Customer.CustomerID.PropertyName, m_CurrentCustomer.Value, BinaryOperatorType.Equal);

			customerItemsXpCollection.Reload();
			relatedCustomerXpCollection.Reload();
			customerPlantsXpCollection.Reload();
			customerShiftsXpCollection.Reload();

		}

		private bool SaveChanges()
		{

			int selectedID = -1;
			//Required to get back to current customer when entering a new customer.
			if (m_CurrentCustomer.HasValue == false)
			{
				m_CurrentCustomer = m_Customer.GetNewCustomerID();
			}
			else
			{
				selectedID = customerSearchGridView.FocusedRowHandle;
			}

			try
			{
				if (m_Customer.UpdateCustomer(m_CurrentCustomer.Value, this.nameTextEdit.Text, this.contactTextEdit.Text, Convert.ToString(this.phoneTextEdit.EditValue), this.emailTextEdit.Text, Convert.ToString(this.faxTextEdit.EditValue), this.noteMemoEdit.Text, Convert.ToString(addressTextEdit.EditValue), Convert.ToString(cityTextEdit.EditValue), Convert.ToString(stateTextEdit.EditValue), Convert.ToString(postalTextEdit.EditValue), inactiveCheckEdit.Checked, Convert.ToString(lpnPrefixTextEdit.EditValue), Utilities.ChangeType<int?>(firstLPNNumberTextEdit.EditValue), Utilities.ChangeType<int?>(lastLPNNumberTextEdit.EditValue), Convert.ToString(plantCodeTextEdit.EditValue), Convert.ToString(expirationDateFormatComboBox.EditValue), Utilities.ChangeType<int?>(lotCodeFormatLookUpEdit.EditValue), m_CustomersSession) != true)
				{
					MessageBox.Show("The customer was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}

				foreach (CustomerShifts customerShift in customerShiftsXpCollection)
				{
					if (customerShift.Customer == null || customerShift.Customer.CustomerID == -1)
					{
					   customerShift.Customer = m_CustomersSession.GetObjectByKey<Customers>(m_CurrentCustomer.Value);
					}
					customerShift.Save();
				}

				foreach (CustomerPlants customerPlant in customerPlantsXpCollection)
				{
					if (customerPlant.Customer == null || customerPlant.Customer.CustomerID == -1)
					{
					   customerPlant.Customer = m_CustomersSession.GetObjectByKey<Customers>(m_CurrentCustomer.Value);
					}
					customerPlant.Save();
				}

				BindCustomerSearch();
				BindCustomersControls(m_CurrentCustomer.Value);
				if (selectedID != -1)
				{
					this.customerSearchGridView.FocusedRowHandle = selectedID;
				}
			}
			catch (ApplicationException ex)
			{
				MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;

		}

		public bool CheckPermissions()
		{

			try
			{
				SPG.UserPermissionsRow permission = (new UserPermissionsBLL()).GetUserPermissionsByUserName(Properties.Settings.Default.UserName, "Customers Form")[0];

				switch (permission.PermissionLevel)
				{
					case "FULL":
					case "Full":
						this.addBarButtonItem.Enabled = true;
						this.editBarButtonItem.Enabled = true;
						this.deleteBarButtonItem.Enabled = true;
						this.deleteGridColumn.Visible = true;
						deleteGridColumn.VisibleIndex = 0;
						deleteCustomerPlantGridColumn.Visible = true;
						deleteCustomerPlantGridColumn.VisibleIndex = 0;
						deleteCustomerShiftGridColumn.Visible = true;
						deleteCustomerShiftGridColumn.VisibleIndex = 0;
						break;
					case "ADD":
					case "Add":
						this.addBarButtonItem.Enabled = true;
						this.editBarButtonItem.Enabled = true;
						this.deleteBarButtonItem.Enabled = false;
						this.deleteGridColumn.Visible = false;
						deleteCustomerPlantGridColumn.Visible = false;
						deleteCustomerShiftGridColumn.Visible = false;
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
						this.deleteBarButtonItem.Enabled = false;
						this.deleteGridColumn.Visible = false;
						deleteCustomerPlantGridColumn.Visible = false;
						deleteCustomerShiftGridColumn.Visible = false;
						break;
					case "EDIT":
					case "Edit":
						this.addBarButtonItem.Enabled = false;
						this.editBarButtonItem.Enabled = true;
						this.deleteBarButtonItem.Enabled = false;
						this.deleteGridColumn.Visible = false;
						deleteCustomerPlantGridColumn.Visible = false;
						deleteCustomerShiftGridColumn.Visible = false;
						break;
					case "VIEW ASSIGNED":
						this.addBarButtonItem.Enabled = false;
						this.editBarButtonItem.Enabled = false;
						this.deleteBarButtonItem.Enabled = false;
						this.deleteGridColumn.Visible = false;
						deleteCustomerPlantGridColumn.Visible = false;
						deleteCustomerShiftGridColumn.Visible = false;
						FilterAssignedCustomers();
						break;
					case "EDIT ASSIGNED":
						this.addBarButtonItem.Enabled = false;
						this.editBarButtonItem.Enabled = true;
						this.deleteBarButtonItem.Enabled = false;
						this.deleteGridColumn.Visible = false;
						deleteCustomerPlantGridColumn.Visible = false;
						deleteCustomerShiftGridColumn.Visible = false;
						FilterAssignedCustomers();
						break;
					default:
						MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		private void FilterAssignedCustomers()
		{

			this.customerSearchXPView.Criteria = new InOperator(Customers.Fields.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_CustomersSession));
			this.customersXpView.Criteria = new InOperator(Customers.Fields.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_CustomersSession));

		}

		private void customerSearchGridView_Click(object sender, EventArgs e)
		{

			if (this.customerSearchGridView.CalcHitInfo(this.customerSearchGridControl.PointToClient(Control.MousePosition)).HitTest == GridHitTest.RowCell)
			{
				this.BindCustomersControls(Convert.ToInt32(this.customerSearchGridView.GetFocusedRowCellValue(this.customerIDGridColumn)));
			}

		}

		private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (SaveChanges())
			{
				Utilities.MakeFormReadOnly(this.generalXtraTabPage, true);
				customerPlantsGridView.OptionsBehavior.Editable = false;
				customerShiftsGridView.OptionsBehavior.Editable = false;
				this.customerSearchGridControl.Enabled = true;

				CheckPermissions();
				cancelBarButtonItem.Enabled = false;
				saveBarButtonItem.Enabled = false;
				deleteGridColumn.Visible = false;
				addRelatedCustomerGroupControl.Enabled = false;
			}

		}

		private void addBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			m_CurrentCustomer = null;
			nameTextEdit.Text = null;
			contactTextEdit.Text = null;
			phoneTextEdit.Text = null;
			emailTextEdit.Text = null;
			faxTextEdit.Text = null;
			noteMemoEdit.Text = null;
			addressTextEdit.Text = null;
			cityTextEdit.Text = null;
			stateTextEdit.Text = null;
			postalTextEdit.Text = null;
			inactiveCheckEdit.Checked = false;
			lpnPrefixTextEdit.EditValue = null;
			firstLPNNumberTextEdit.EditValue = null;
			lastLPNNumberTextEdit.EditValue = null;
			plantCodeTextEdit.EditValue = null;
			lpnGroupControl.Text = "LPN Settings";
			expirationDateFormatComboBox.EditValue = null;
			lotCodeFormatLookUpEdit.EditValue = null;

			customerShiftsXpCollection.Criteria = new BinaryOperator(CustomerShifts.Fields.Customer.CustomerID, -1, BinaryOperatorType.Equal);
			customerPlantsXpCollection.Criteria = new BinaryOperator(CustomerPlants.Fields.Customer.CustomerID, -1, BinaryOperatorType.Equal);
			customerShiftsXpCollection.Reload();
			customerPlantsXpCollection.Reload();

			Utilities.MakeFormReadOnly(this.generalXtraTabPage, false);
			customerShiftsGridView.OptionsBehavior.Editable = true;
			customerPlantsGridView.OptionsBehavior.Editable = true;
			this.customerSearchGridControl.Enabled = false;
			CheckPermissions();

			this.cancelBarButtonItem.Enabled = true;
			this.saveBarButtonItem.Enabled = true;
			this.editBarButtonItem.Enabled = false;
			this.addBarButtonItem.Enabled = false;
			this.deleteBarButtonItem.Enabled = false;
			this.deleteGridColumn.Visible = false;
			deleteCustomerPlantGridColumn.Visible = false;
			deleteCustomerShiftGridColumn.Visible = false;
			this.addRelatedCustomerGroupControl.Enabled = false;

		}

		private void CancelChanges()
		{

			if (this.m_CurrentCustomer.HasValue)
			{
				BindCustomersControls(m_CurrentCustomer.Value);
				m_Customer.EndedEdit(m_CurrentCustomer.Value);
			}

		}

		private void cancelBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			CancelChanges();

			Utilities.MakeFormReadOnly(this.generalXtraTabPage, true);
			customerShiftsGridView.OptionsBehavior.Editable = false;
			customerPlantsGridView.OptionsBehavior.Editable = false;
			this.customerSearchGridControl.Enabled = true;
			this.addRelatedCustomerGroupControl.Enabled = false;

			CheckPermissions();
			cancelBarButtonItem.Enabled = false;
			saveBarButtonItem.Enabled = false;
			deleteGridColumn.Visible = false;

		}

		private void deleteBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (MessageBox.Show("Are you sure you want to delete this customer.", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
			{
				return;
			}

			try
			{
				if (m_Customer.DeleteCustomer(m_CurrentCustomer.Value, m_CustomersSession) == true)
				{
					RelatedCustomerBLL.DeleteRelatedCustomers(CustomersBLL.GetCustomer(m_CurrentCustomer.Value, m_CustomersSession));
					BindCustomerSearch();
				}
				else
				{
					MessageBox.Show("The customer was not deleted.");
				}
			}
			catch (ApplicationException ex)
			{
				MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void deleteCustomerPlantRepositoryItemButtonEdit_Click(object sender, EventArgs e)
		{

			if (MessageBox.Show("Are you sure you want to delete this plant?", "Delete Customer Plant", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
			{
				return;
			}

			CustomerPlants plant = m_CustomersSession.GetObjectByKey<CustomerPlants>(customerPlantsGridView.GetFocusedRowCellValue(colOid));
			if (plant == null)
			{
				customerPlantsGridView.DeleteRow(customerPlantsGridView.FocusedRowHandle);
			}
			else
			{
				plant.Delete();
				if (plant.IsDeleted)
				{
					customerPlantsGridView.DeleteRow(customerPlantsGridView.FocusedRowHandle);
				}
				else
				{
					MessageBox.Show("The customer plant couldn't be deleted.");
				}
			}

		}

		private void deleteCustomerShiftRepositoryItemButtonEdit_Click(object sender, EventArgs e)
		{

			if (MessageBox.Show("Are you sure you want to delete this shift?", "Delete Customer Shift", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
			{
				return;
			}

			CustomerShifts shift = m_CustomersSession.GetObjectByKey<CustomerShifts>(customerShiftsGridView.GetFocusedRowCellValue(colOid));
			if (shift == null)
			{
				customerShiftsGridView.DeleteRow(customerShiftsGridView.FocusedRowHandle);
			}
			else
			{
				shift.Delete();
				if (shift.IsDeleted)
				{
					customerShiftsGridView.DeleteRow(customerShiftsGridView.FocusedRowHandle);
				}
				else
				{
					MessageBox.Show("The customer shift couldn't be deleted.");
				}
			}

		}

		private void editBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (m_CurrentCustomer == null)
			{
				MessageBox.Show("Please select a customer to edit.");
				return;
			}

			if (m_Customer.AllowEdit(m_CurrentCustomer.Value) == false)
			{
				MessageBox.Show("Someone else is editing now this customer.", "Customer in use", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				return;
			}

			Utilities.MakeFormReadOnly(this.generalXtraTabPage, false);
			customerPlantsGridView.OptionsBehavior.Editable = true;
			customerShiftsGridView.OptionsBehavior.Editable = true;
			this.customerSearchGridControl.Enabled = false;
			addRelatedCustomerGroupControl.Enabled = true;
			CheckPermissions();

			this.cancelBarButtonItem.Enabled = true;
			this.saveBarButtonItem.Enabled = true;
			this.editBarButtonItem.Enabled = false;
			this.addBarButtonItem.Enabled = false;
			deleteGridColumn.Visible = deleteBarButtonItem.Enabled;
			deleteGridColumn.VisibleIndex = 0;
			this.deleteBarButtonItem.Enabled = false;

		}

		private void inactiveSearchCheckEdit_CheckedChanged(object sender, EventArgs e)
		{

			BindCustomerSearch();

		}

		private void reportsBarButtonItem_ItemClick(System.Object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			QuickReportsXtraForm reportsForm = new QuickReportsXtraForm();

			reportsForm.Text = "Customer Reports";
			//reportsForm.Parent = Me.ParentForm
			reportsForm.Show();
			reportsForm.FillReports("Customers");

		}

		private void addOneWaySimpleButton_Click(System.Object sender, EventArgs e)
		{

			if (RelatedCustomerBLL.AddRelatedCustomer(CustomersBLL.GetCustomer(m_CurrentCustomer.Value, m_CustomersSession), CustomersBLL.GetCustomer(Convert.ToInt32(relatedCustomerLookUpEdit.EditValue), m_CustomersSession), false) == false)
			{
				MessageBox.Show("There was a problem while adding the related customer");
			}

			relatedCustomerXpCollection.Reload();

		}

		private void addBothWaysSimpleButton_Click(System.Object sender, EventArgs e)
		{

			if (RelatedCustomerBLL.AddRelatedCustomer(CustomersBLL.GetCustomer(m_CurrentCustomer.Value, m_CustomersSession), CustomersBLL.GetCustomer(Convert.ToInt32(relatedCustomerLookUpEdit.EditValue), m_CustomersSession), true) == false)
			{
				MessageBox.Show("There was a problem while adding the related customer");
			}

			relatedCustomerXpCollection.Reload();

		}

		private void deleteRepositoryItemButtonEdit_Click(object sender, EventArgs e)
		{

			if (MessageBox.Show("Are you sure you want to delete this relationshiP?", "Delete Related Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				return;
			}

			if (RelatedCustomerBLL.DeleteRelatedCustomer(m_CustomersSession.GetObjectByKey<RelatedCustomer>(relatedCustomersGridView.GetFocusedRowCellValue(this.idGridColumn))))
			{
				MessageBox.Show("The customer relationship was successfully deleted.");
			}
			else
			{
				MessageBox.Show("There was a problem while deleting the related customer");
			}

		}

		private void resetLPNSimpleButton_Click(object sender, EventArgs e)
		{

			try
			{
				Customers customer = CustomersBLL.GetCustomer(m_CurrentCustomer.Value, m_CustomersSession);
				customer.NextLPNNumber = Convert.ToInt32(firstLPNNumberTextEdit.EditValue);
				customer.Save();
			}
			catch
			{
				MessageBox.Show("The LPN labels were not reset.");
			}

		}

	}
}