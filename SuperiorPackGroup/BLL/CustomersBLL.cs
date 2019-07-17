//INSTANT C# NOTE: Formerly VB project-level imports:
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using System;
using SuperiorPackGroup.SPGTableAdapters;
using System.Text;
using DXDAL.SPGData;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using System.Collections.ObjectModel;
using System.Linq;

namespace SuperiorPackGroup
{
	[System.ComponentModel.DataObject()]
	public class CustomersBLL
	{

		private CustomersTableAdapter m_CustomersTableAdapter = null;
		public CustomersTableAdapter Adapter
		{

			get
			{
				if (m_CustomersTableAdapter != null)
				{
					return m_CustomersTableAdapter;
				}

				m_CustomersTableAdapter = new CustomersTableAdapter();
				m_CustomersTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				return m_CustomersTableAdapter;
			}

		}

		private List<Change> changes = new List<Change>();

		private void UpdateAuditTrail()
		{

			StringBuilder builder = new StringBuilder(string.Empty);

			foreach (Change update in changes)
			{
				builder.Append(string.Format("{0}:{1}({2}); ", update.PropertyName, update.PrevValue, update.NewValue));
			}

			if (builder.Length > 2)
			{
				builder.Length = (builder.Length - 2);
				AuditTrailBLL.AddTrailEntry(Properties.Settings.Default.UserName, int.Parse(changes[0].NewValue), "Customers", builder.ToString());
			}

			changes.Clear();

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.CustomersDataTable GetCustomerNameAndIDS(bool inactive)
		{

			if (inactive)
			{
				return Adapter.GetCustomerNameAndIDS(null);
			}
			//will return only those that are active
			return Adapter.GetCustomerNameAndIDS(inactive);

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.CustomersDataTable GetCustomerByID(int customerID)
		{

			return Adapter.GetCustomerByID(customerID);

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
		public SPG.CustomersDataTable GetCustomers()
		{

			return Adapter.GetCustomers();

		}

		public static Collection<int> GetRelatedCustomerIDs(Customers mainCustomer)
		{

			Collection<int> customerIDS = new Collection<int>();

			foreach (RelatedCustomer relatedCustomer in mainCustomer.RelatedCustomers)
			{
				customerIDS.Add(relatedCustomer.relatedCustomer.CustomerID);
			}

			return customerIDS;

		}

		public static Customers GetCustomer(int customerID, Session DXSession)
		{

			try
			{
				if (DXSession == null)
				{
					DXSession = Session.DefaultSession;
				}
				return DXSession.GetObjectByKey<Customers>(customerID);
			}
			catch (Exception ex)
			{
				return null;
			}

		}

		private void SetField(string propertyName, object oldValue, object newValue, Customers customer)
		{

			if ((oldValue != null || newValue != null) && ((oldValue != null && newValue == null) || (newValue != null && oldValue == null) || oldValue.ToString() != newValue.ToString()))
			{
				customer.SetMemberValue(propertyName, newValue);
				Change change = new Change()
				{
					PropertyName = propertyName,
					PrevValue = ((oldValue == null) ? "<NULL>" : oldValue.ToString()),
					NewValue = ((newValue == null) ? "<NULL>" : newValue.ToString())
				};
				changes.Add(change);
			}

		}

		private void SetCustomerFields(string customerName, string customerContact, string customerPhone, string customerEmail, string customerFax, string customerNote, string address, string city, string state, string postal, bool? inactive, string lpnPrefix, int? firstLPNNumber, int? lastLPNNumber,string beforeItemCode,string beforeLotCode,string beforeQtyCode,string endCode, string plantCode, string expirationDateFormat, int? lotCodeFormat, Customers customer, Session dxSession)
		{

			SetField(Customers.Fields.CustomerName.PropertyName, customer.CustomerName, customerName, customer);
			SetField(Customers.Fields.CustomerContact.PropertyName, customer.CustomerContact, (string.IsNullOrEmpty(customerContact) ? null : customerContact), customer);
			SetField(Customers.Fields.CustomerPhone.PropertyName, customer.CustomerPhone, (string.IsNullOrEmpty(customerPhone) ? null : customerPhone), customer);
			SetField(Customers.Fields.CustomerEmail.PropertyName, customer.CustomerEmail, (string.IsNullOrEmpty(customerEmail) ? null : customerEmail), customer);
			SetField(Customers.Fields.CustomerFax.PropertyName, customer.CustomerFax, (string.IsNullOrEmpty(customerFax) ? null : customerFax), customer);
			SetField(Customers.Fields.CustomerNote.PropertyName, customer.CustomerNote, (string.IsNullOrEmpty(customerNote) ? null : customerNote), customer);
			SetField(Customers.Fields.Address.PropertyName, customer.Address, (string.IsNullOrEmpty(address) ? null : address), customer);
			SetField(Customers.Fields.City.PropertyName, customer.City, (string.IsNullOrEmpty(city) ? null : city), customer);
			SetField(Customers.Fields.State.PropertyName, customer.State, (string.IsNullOrEmpty(state) ? null : state), customer);
			SetField(Customers.Fields.ZipCode.PropertyName, customer.ZipCode, (string.IsNullOrEmpty(postal) ? null : postal), customer);
			SetField(Customers.Fields.Inactive.PropertyName, customer.Inactive, (inactive ?? false), customer);
			SetField(Customers.Fields.LPNPrefix.PropertyName, customer.LPNPrefix, (string.IsNullOrEmpty(lpnPrefix) ? null : lpnPrefix), customer);
			SetField(Customers.Fields.FirstLPNNumber.PropertyName, customer.FirstLPNNumber, (firstLPNNumber ?? null), customer);
            SetField(Customers.Fields.LastLPNNumber.PropertyName, customer.LastLPNNumber, (lastLPNNumber ?? null), customer);
            SetField(Customers.Fields.BeforeItemCode.PropertyName, customer.BeforeItemCode, (beforeItemCode ?? null), customer);
            SetField(Customers.Fields.BeforeLotCode.PropertyName, customer.BeforeLotCode, (beforeLotCode ?? null), customer);
            SetField(Customers.Fields.BeforeQtyCode.PropertyName, customer.BeforeQtyCode, (beforeQtyCode ?? null), customer);
            SetField(Customers.Fields.EndCode.PropertyName, customer.EndCode, (endCode ?? null), customer);
            SetField(Customers.Fields.PlantCode.PropertyName, customer.PlantCode, (string.IsNullOrEmpty(plantCode) ? null : plantCode), customer);
			SetField(Customers.Fields.ExpirationDateFormat.PropertyName, customer.ExpirationDateFormat, (string.IsNullOrEmpty(expirationDateFormat) ? null : expirationDateFormat), customer);
			SetField(Customers.Fields.DefaultLotCodeFormat.PropertyName, customer.DefaultLotCodeFormat, (lotCodeFormat.HasValue ? dxSession.GetObjectByKey<LotCodeFormats>(lotCodeFormat.Value) : null), customer);

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
		public bool UpdateCustomer(int customerID, string customerName, string customerContact, string customerPhone, string customerEmail, string customerFax, string customerNote, string address, string city, string state, string postal, bool? inactive, string lpnPrefix, int? firstLPNNumber, int? lastLPNNumber, string beforeItemCode, string beforeLotCode, string beforeQtyCode,string endCode, string plantCode, string expirationDateFormat, int? lotCodeFormat, Session DXSsession)
		{

			if (string.IsNullOrEmpty(customerName))
			{
				throw new ApplicationException("You must provide a Customer Name.");
			}

			if (firstLPNNumber.HasValue)
			{
				if (lastLPNNumber.HasValue == false)
				{
					throw new ApplicationException("You must provide a last LPN number.");
				}
				else if (lastLPNNumber.Value <= firstLPNNumber.Value)
				{
					throw new ApplicationException("The last LPN number must be higher than the first LPN number.");
				}
			}

			if (string.IsNullOrEmpty(plantCode) == false && plantCode.Length > 4)
			{
				throw new ApplicationException("Plant code should be 4 characters long.");
			}

			Change change = new Change();
			Customers customer = GetCustomer(customerID, DXSsession);

			if (customer == null)
			{
				//It is a new Customer
				change = new Change()
				{
					PropertyName = Customers.Fields.CustomerID.PropertyName,
					PrevValue = "<NULL>",
					NewValue = customerID.ToString()
				};
				changes.Add(change);
				return InsertCustomer(customerID, customerName, customerContact, customerPhone, customerEmail, customerFax, customerNote, address, city, state, postal, inactive, lpnPrefix, firstLPNNumber, lastLPNNumber, beforeItemCode, beforeLotCode, beforeQtyCode,endCode, plantCode, expirationDateFormat, lotCodeFormat, DXSsession);
			}

			change = new Change()
			{
				PropertyName = Customers.Fields.CustomerID.PropertyName,
				PrevValue = customer.CustomerID.ToString(),
				NewValue = customer.CustomerID.ToString()
			};
			changes.Add(change);
			SetCustomerFields(customerName, customerContact, customerPhone, customerEmail, customerFax, customerNote, address, city, state, postal, inactive, lpnPrefix, firstLPNNumber, lastLPNNumber, beforeItemCode, beforeLotCode, beforeQtyCode,endCode, plantCode, expirationDateFormat, lotCodeFormat, customer, DXSsession);

			try
			{
				customer.Save();
			}
			catch (Exception ex)
			{
				return false;
			}

			UpdateAuditTrail();
			EndedEdit(customer.CustomerID);

			return true;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
		public bool InsertCustomer(int customerID, string customerName, string customerContact, string customerPhone, string customerEmail, string customerFax, string customerNote, string address, string city, string state, string postal, bool? inactive, string lpnPrefix, int? firstLPNNumber, int? lastLPNNumber, string beforeItemCode, string beforeLotCode, string beforeQtyCode,string endCode, string plantCode, string expirationDateFormat, int? lotCodeFormat, Session dxSession)
		{

			Customers customer = new Customers(dxSession) {CustomerID = customerID};
			SetCustomerFields(customerName, customerContact, customerPhone, customerEmail, customerFax, customerNote, address, city, state, postal, inactive, lpnPrefix, firstLPNNumber, lastLPNNumber, beforeItemCode, beforeLotCode, beforeQtyCode,endCode, plantCode, expirationDateFormat, lotCodeFormat, customer, dxSession);
			customer.strEnteredBy = Properties.Settings.Default.UserName;
			customer.dtmEnteredOn = DateTime.Now;

			try
			{
				customer.Save();
			}
			catch (Exception ex)
			{
				return false;
			}

			return true;

		}

		public int GetNewCustomerID()
		{

			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.UserConnectionString);
			System.Data.SqlClient.SqlCommand myCommand = new System.Data.SqlClient.SqlCommand("dbo.spNewIDSafe", conn);
			System.Data.SqlClient.SqlParameter myNewID = new System.Data.SqlClient.SqlParameter("@nRetVal", SqlDbType.Int);
			myCommand.CommandType = CommandType.StoredProcedure;
			myNewID.Direction = ParameterDirection.Output;
			myCommand.Parameters.AddWithValue("@cName", "tblCustomers");
			myCommand.Parameters.AddWithValue("@cPkField", "CustomerID");
			myCommand.Parameters.Add(myNewID);

			conn.Open();
			myCommand.ExecuteNonQuery();

			return Convert.ToInt32(myNewID.Value);

		}

		public bool DeleteCustomer(int customerid, Session DXSession)
		{

			SPG.CustomersDataTable customers = Adapter.GetCustomerByID(customerid);
			int rowsAffected = 0;

			if (customers.Count() == 1)
			{

				if ((new ItemsBLL()).GetItemsByCustomerID(customerid).Count != 0 || (new ProductionBLL()).GetProductionByCustomerID(customerid).Count != 0 || (new InventoryBLL()).GetInventoryView(null, null, customerid, null, null).Count != 0)
				{
					if (MessageBox.Show("You can't delete this customer because there are items or production/inventory assigned to him. Do you want ot mark him as inactive?", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
					{
						Adapter.InactivateCustomer(customerid);
						return true;
					}
					else
					{
						return true;
					}
				}
				RelatedCustomerBLL.DeleteRelatedCustomers(GetCustomer(customerid, DXSession));
				rowsAffected = Adapter.Delete(customerid, customers[0].ts);
			}

			return Convert.ToBoolean(rowsAffected);

		}

		public void EndedEdit(int customerID)
		{

			Customers customer = Session.DefaultSession.GetObjectByKey<Customers>(customerID, true);
			customer.Editing = false;
			customer.Save();

		}

		public bool AllowEdit(int customerID)
		{

			Customers customer = Session.DefaultSession.GetObjectByKey<Customers>(customerID, true);
			if (customer.Editing)
			{
				return false;
			}
			else
			{
				customer.Editing = true;
				customer.Save();
				return true;
			}
		}

		public static string GetExpirationDateFormat(int customerID)
		{

			Customers customer = Session.DefaultSession.GetObjectByKey<Customers>(customerID);
			return customer.ExpirationDateFormat;

		}

		public static string GetLPNPrefix(int customerID)
		{

			Customers customer = Session.DefaultSession.GetObjectByKey<Customers>(customerID);
			return customer.LPNPrefix;

		}

	}

}