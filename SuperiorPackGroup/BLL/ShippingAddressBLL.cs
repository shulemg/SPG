//INSTANT C# NOTE: Formerly VB project-level imports:
using SuperiorPackGroup.SPGTableAdapters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SuperiorPackGroup
{
    [System.ComponentModel.DataObject()]
    public class ShippingAddressBLL
    {

        private ShippingAddressesTableAdapter m_ShippingAddressesTableAdapter = null;
        public ShippingAddressesTableAdapter Adapter
        {

            get
            {
                if (m_ShippingAddressesTableAdapter == null)
                {
                    m_ShippingAddressesTableAdapter = new ShippingAddressesTableAdapter();
                    m_ShippingAddressesTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
                }
                return m_ShippingAddressesTableAdapter;
            }

        }

        private void UpdateAuditTrail(SPG.ShippingAddressesRow ModifiedRecord, object[] originalRecord)
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
                AuditTrailBLL.AddTrailEntry(Properties.Settings.Default.UserName, Convert.ToInt32(ModifiedRecord[0]), "ShippingAddress", builder.ToString());
            }

        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
        public SPG.ShippingAddressesDataTable GetAddressNameAndIDS()
        {

            return Adapter.GetAddressNameAndIDs();

        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
        public SPG.ShippingAddressesDataTable GetAddressInfoByID(int addressID)
        {

            return Adapter.GetAddressInfoByID(addressID);

        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
        public SPG.ShippingAddressesDataTable GetAddressByID(int addressID)
        {

            return Adapter.GetAddressByID(addressID);

        }

        private static void SetAddressFields(string shippingName, string contactFirstName, string contactLastName, string shippingAddress, string shippingCity, string shippingState, string shippingPostal, string shippingPhone, string shippingEmail, string shippingFax, string shippingNote, SPG.ShippingAddressesRow address)
        {

            address.ShippingName = shippingName;
            if (string.IsNullOrEmpty(contactFirstName))
            {
                address.SetContactFirstNameNull();
            }
            else
            {
                address.ContactFirstName = contactFirstName;
            }
            if (string.IsNullOrEmpty(contactLastName))
            {
                address.SetContactLastNameNull();
            }
            else
            {
                address.ContactLastName = contactLastName;
            }
            address.ShippingAddress = shippingAddress;
            address.ShippingCity = shippingCity;
            address.ShippingState = shippingState;
            if (string.IsNullOrEmpty(shippingPostal))
            {
                address.SetShippingPostalNull();
            }
            else
            {
                address.ShippingPostal = shippingPostal;
            }
            if (string.IsNullOrEmpty(shippingPhone))
            {
                address.SetShippingPhoneNull();
            }
            else
            {
                address.ShippingPhone = shippingPhone;
            }
            if (string.IsNullOrEmpty(shippingEmail))
            {
                address.SetShippingEmailNull();
            }
            else
            {
                address.ShippingEmail = shippingEmail;
            }
            if (string.IsNullOrEmpty(shippingFax))
            {
                address.SetShippingFaxNull();
            }
            else
            {
                address.ShippingFax = shippingFax;
            }
            if (string.IsNullOrEmpty(shippingNote))
            {
                address.SetShippingNoteNull();
            }
            else
            {
                address.ShippingNote = shippingNote;
            }

        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public bool UpdateAddress(int addressID, string shippingName, string contactFirstName, string contactLastName, string shippingAddress, string shippingCity, string shippingState, string shippingPostal, string shippingPhone, string shippingEmail, string shippingFax, string shippingNote)
        {

            StringBuilder str = new StringBuilder(string.Empty);
            if (string.IsNullOrEmpty(shippingName))
            {
                str.Append("Shipping Name, ");
            }

            if (string.IsNullOrEmpty(shippingAddress))
            {
                str.Append("Shipping Address, ");
            }

            if (string.IsNullOrEmpty(shippingCity))
            {
                str.Append("Shipping City, ");
            }

            if (string.IsNullOrEmpty(shippingState))
            {
                str.Append("Shipping State, ");
            }

            if (str.Length > 0)
            {
                throw new ApplicationException(string.Format("You must provide a {0}.", str.ToString().Substring(0, (str.Length - 2))));
            }

            SPG.ShippingAddressesDataTable addresses = Adapter.GetAddressByID(addressID);

            if (addresses.Count() == 0)
            {

                //It is a new Shipping Address 
                return InsertAddress(addressID, shippingName, contactFirstName, contactLastName, shippingAddress, shippingCity, shippingState, shippingPostal, shippingPhone, shippingEmail, shippingFax, shippingNote);
            }

            SPG.ShippingAddressesRow address = addresses[0];

            object[] originalRecord = address.ItemArray;

            SetAddressFields(shippingName, contactFirstName, contactLastName, shippingAddress, shippingCity, shippingState, shippingPostal, shippingPhone, shippingEmail, shippingFax, shippingNote, address);

            if (!(originalRecord == null))
            {
                UpdateAuditTrail(address, originalRecord);
            }

            int rowsAffected = Adapter.Update(address);

            return rowsAffected == 1;

        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public bool InsertAddress(int addressID, string shippingName, string contactFirstName, string contactLastName, string shippingAddress, string shippingCity, string shippingState, string shippingPostal, string shippingPhone, string shippingEmail, string shippingFax, string shippingNote)
        {

            SPG.ShippingAddressesDataTable addresses = new SPG.ShippingAddressesDataTable();
            SPG.ShippingAddressesRow address = addresses.NewShippingAddressesRow();

            address.AddressID = addressID;
            SetAddressFields(shippingName, contactFirstName, contactLastName, shippingAddress, shippingCity, shippingState, shippingPostal, shippingPhone, shippingEmail, shippingFax, shippingNote, address);
            address.strEnteredBy = Properties.Settings.Default.UserName;
            address.dtmEnteredOn = DateTime.Now;

            addresses.AddShippingAddressesRow(address);
            int rowsAffected = Adapter.Update(addresses);

            return rowsAffected == 1;

        }

        public int GetNewAddressID()
        {

            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.UserConnectionString);
            System.Data.SqlClient.SqlCommand myCommand = new System.Data.SqlClient.SqlCommand("dbo.spNewIDSafe", conn);
            System.Data.SqlClient.SqlParameter myNewID = new System.Data.SqlClient.SqlParameter("@nRetVal", SqlDbType.Int);
            myCommand.CommandType = CommandType.StoredProcedure;
            myNewID.Direction = ParameterDirection.Output;
            myCommand.Parameters.AddWithValue("@cName", "tblShippingAddresses");
            myCommand.Parameters.AddWithValue("@cPkField", "AddressID");
            myCommand.Parameters.Add(myNewID);

            conn.Open();
            myCommand.ExecuteNonQuery();

            return Convert.ToInt32(myNewID.Value);

        }

    }

}