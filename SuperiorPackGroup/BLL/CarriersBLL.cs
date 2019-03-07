//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using SuperiorPackGroup.SPGTableAdapters;
using System.Text;
using System.Linq;

namespace SuperiorPackGroup
{
	[System.ComponentModel.DataObject()]
	public class CarriersBLL
	{

		private CarriersTableAdapter m_CarriersTableAdapter = null;
		public CarriersTableAdapter Adapter
		{

			get
			{
				if (m_CarriersTableAdapter == null)
				{
					m_CarriersTableAdapter = new CarriersTableAdapter();
					m_CarriersTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return m_CarriersTableAdapter;
			}

		}


		private void UpdateAuditTrail(SPG.CarriersRow ModifiedRecord, object[] originalRecord)
		{

			StringBuilder builder = new StringBuilder(string.Empty);
			int recordFields = (ModifiedRecord.ItemArray.Length - 1);
			int i = 0;
			while (i <= recordFields)
			{
				try
				{
					if (Convert.IsDBNull(originalRecord[i]))
					{
						if (!Convert.IsDBNull(ModifiedRecord[i]))
						{
							builder.Append(string.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns[i].ColumnName, "NULL", ModifiedRecord[i]));
						}
					}
					else if (Convert.IsDBNull(ModifiedRecord[i]))
					{
						if (!Convert.IsDBNull(originalRecord[i]))
						{
							builder.Append(string.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns[i].ColumnName, originalRecord[i], "NULL"));
						}
					}
					else if (ModifiedRecord[i] != originalRecord[i])
					{
						builder.Append(string.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns[i].ColumnName, originalRecord[i], ModifiedRecord[i]));
					}
				}
				catch
				{
				}
				i += 1;
			}
			if (builder.Length > 2)
			{
				builder.Length = (builder.Length - 2);
				AuditTrailBLL.AddTrailEntry(Properties.Settings.Default.UserName, Convert.ToInt32(ModifiedRecord[0]), "Carriers", builder.ToString());
			}

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
		public SPG.CarriersDataTable GetCarriers()
		{

			return Adapter.GetCarriers();

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.CarriersDataTable GetCarrierIDAndNames()
		{

			return Adapter.GetCarrierIDAndNames();

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.CarriersDataTable GetCarrierByID(int carrierID)
		{

			return Adapter.GetCarrierByID(carrierID);

		}

		private static void SetCarrierFields(string name, string contactFirstName, string contactLastName, string address, string city, string state, string postal, string phone, string email, string fax, string note, SPG.CarriersRow carrier)
		{

			carrier.CarrierName = name;
			if (string.IsNullOrEmpty(contactFirstName))
			{
				carrier.SetContactFirstNameNull();
			}
			else
			{
				carrier.ContactFirstName = contactFirstName;
			}
			if (string.IsNullOrEmpty(contactLastName))
			{
				carrier.SetContactLastNameNull();
			}
			else
			{
				carrier.ContactLastName = contactLastName;
			}
			if (string.IsNullOrEmpty(address))
			{
				carrier.SetAddressNull();
			}
			else
			{
				carrier.Address = address;
			}
			if (string.IsNullOrEmpty(city))
			{
				carrier.SetCityNull();
			}
			else
			{
				carrier.City = city;
			}
			if (string.IsNullOrEmpty(state))
			{
				carrier.SetStateNull();
			}
			else
			{
				carrier.State = state;
			}
			if (string.IsNullOrEmpty(postal))
			{
				carrier.SetPostalNull();
			}
			else
			{
				carrier.Postal = postal;
			}
			if (string.IsNullOrEmpty(phone))
			{
				carrier.SetPhoneNull();
			}
			else
			{
				carrier.Phone = phone;
			}
			if (string.IsNullOrEmpty(email))
			{
				carrier.SetEmailNull();
			}
			else
			{
				carrier.Email = email;
			}
			if (string.IsNullOrEmpty(fax))
			{
				carrier.SetFaxNull();
			}
			else
			{
				carrier.Fax = fax;
			}
			if (string.IsNullOrEmpty(note))
			{
				carrier.SetNoteNull();
			}
			else
			{
				carrier.Note = note;
			}

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
		public bool UpdateCarrier(int id, string name, string contactFirstName, string contactLastName, string address, string city, string state, string postal, string phone, string email, string fax, string note)
		{

			if (string.IsNullOrEmpty(name))
			{
				throw new ApplicationException("You must provide a Carrier Name.");
			}

			SPG.CarriersDataTable carriers = Adapter.GetCarrierByID(id);

			if (carriers.Count() == 0)
			{
				//It is a new carriers
				return InsertCarrier(id, name, contactFirstName, contactLastName, address, city, state, postal, phone, email, fax, note);
			}

			SPG.CarriersRow carrier = carriers[0];

			object[] originalRecord = carrier.ItemArray;

			SetCarrierFields(name, contactFirstName, contactLastName, address, city, state, postal, phone, email, fax, note, carrier);

			if (!(originalRecord == null))
			{
				UpdateAuditTrail(carrier, originalRecord);
			}

			int rowsAffected = Adapter.Update(carrier);

			return rowsAffected == 1;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
		public bool InsertCarrier(int id, string name, string contactFirstName, string contactLastName, string address, string city, string state, string postal, string phone, string email, string fax, string note)
		{

			SPG.CarriersDataTable carriers = new SPG.CarriersDataTable();
			SPG.CarriersRow carrier = carriers.NewCarriersRow();

			carrier.CarrierID = id;
			SetCarrierFields(name, contactFirstName, contactLastName, address, city, state, postal, phone, email, fax, note, carrier);
			carrier.EnteredBy = Properties.Settings.Default.UserName;
			carrier.EnteredOn = DateTime.Now;

			carriers.AddCarriersRow(carrier);
			int rowsAffected = Adapter.Update(carriers);

			return rowsAffected == 1;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
		public bool DeleteCarrier(int id)
		{

			SPG.CarriersDataTable carriers = Adapter.GetCarrierByID(id);
			int rowsAffected = 0;

			if (carriers.Count() == 1)
			{
				SPG.CarriersRow carrier = (SPG.CarriersRow)carriers.Rows[0];
				rowsAffected = Adapter.Delete(id, carrier.ts);
			}

			//Return true if precisely one row was deleted, otherwise return false.
			return rowsAffected == 1;

		}

		public int GetNewCarrierID()
		{

			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.UserConnectionString);
			System.Data.SqlClient.SqlCommand myCommand = new System.Data.SqlClient.SqlCommand("dbo.spNewIDSafe", conn);
			System.Data.SqlClient.SqlParameter myNewID = new System.Data.SqlClient.SqlParameter("@nRetVal", SqlDbType.Int);
			myCommand.CommandType = CommandType.StoredProcedure;
			myNewID.Direction = ParameterDirection.Output;
			myCommand.Parameters.AddWithValue("@cName", "tblCarriers");
			myCommand.Parameters.AddWithValue("@cPkField", "CarrierID");
			myCommand.Parameters.Add(myNewID);

			conn.Open();
			myCommand.ExecuteNonQuery();

			return Convert.ToInt32(myNewID.Value);

		}

	}

}