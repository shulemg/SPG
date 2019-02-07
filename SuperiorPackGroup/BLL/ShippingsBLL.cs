//INSTANT C# NOTE: Formerly VB project-level imports:
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

using System.Drawing;
using SuperiorPackGroup.SPGTableAdapters;
using System;
using System.Text;
using DevExpress.Data.Filtering;
using DXDAL.SPGData;
using DevExpress.Xpo;
using System.Linq;

namespace SuperiorPackGroup
{
    [System.ComponentModel.DataObject()]
    public class ShippingsBLL
    {

        private ShippingsTableAdapter m_ShippingsTableAdapter = null;
        private List<Change> changes = new List<Change>();

        public ShippingsTableAdapter Adapter
        {

            get
            {
                if (m_ShippingsTableAdapter == null)
                {
                    m_ShippingsTableAdapter = new ShippingsTableAdapter();
                    m_ShippingsTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
                }
                return m_ShippingsTableAdapter;
            }

        }

        private void UpdateAuditTrail()
        {

            StringBuilder builder = new StringBuilder(string.Empty);

            foreach (Change update in changes)
            {
                builder.Append(string.Format("{0}:{1}({2}); ", update.PropertyName, update.PrevValue, update.NewValue));
            }

            if (builder.Length > 2)
            {
                builder.Length = builder.Length - 2;
                AuditTrailBLL.AddTrailEntry(Properties.Settings.Default.UserName, int.Parse(changes[0].NewValue), "Shippings", builder.ToString());
            }

            changes.Clear();

        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
        public SPG.ShippingsDataTable GetShippingsByCustomerID(int customerID)
        {

            return Adapter.GetShippingsByCustomerID(customerID);

        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
        public SPG.ShippingsDataTable GetShippings()
        {

            return Adapter.GetShippings();

        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
        public SPG.ShippingsDataTable GetIDAndBOLByCustomerAndDate(int? customerID, DateTime? fromDate, DateTime? toDate)
        {

            return Adapter.GetIDAndBOLByCustomerAndDate(customerID, fromDate, toDate);

        }

        public int GetMaxBOL()
        {

            try
            {
                if (Convert.ToDouble(Adapter.GetMaxBOL()) >= 5000)
                {
                    return Convert.ToInt32(Adapter.GetMaxBOL());
                }
                else
                {
                    return 4999;
                }
            }
            catch
            {
                return 4999;
            }

        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
        public SPG.ShippingsDataTable GetShippingByID(int shippingID)
        {

            return Adapter.GetShippingByID(shippingID);

        }

        private void SetField(string propertyName, object oldValue, object newValue, Shipping shippingRecord)
        {

            if ((oldValue != null || newValue != null) && ((oldValue != null && newValue == null) || (newValue != null && oldValue == null) || oldValue.ToString() != newValue.ToString()))
            {
                shippingRecord.SetMemberValue(propertyName, newValue);
                Change change = new Change()
                {
                    PropertyName = propertyName,
                    PrevValue = (oldValue == null) ? "<NULL>" : oldValue.ToString(),
                    NewValue = (newValue == null) ? "<NULL>" : newValue.ToString()
                };
                changes.Add(change);
            }

        }

        private void SetShippingFields(DateTime? shippingDate, int? shippingCarrierID, int? shippingCustID, int shippingBol, int? intDestination, string strPO, string strTrailer, float? sngSkits, float? sngTotalPallets, string strSeal, string strDeliveryNote, string DeliveryNoteNumber, double? TotalGrossWeight, bool? Shipper, string Comments, int? Shift, bool Freight, int? loadedBy, int? checkedBy, int? wheelsChocked, DateTime? startTime, DateTime? finishTime, double? temparature, int? physicalCondition, int? loadCondition, int? foreignSubstance, int? insectActivity, int? correctPallets, int locationID, Shipping shippingRecord)
        {

            SetField(Shipping.Fields.ShipMainDate.PropertyName, shippingRecord.ShipMainDate, shippingDate ?? DateTime.Today, shippingRecord);
            SetField(Shipping.Fields.ShipMainCarrierID.PropertyName, shippingRecord.ShipMainCarrierID, Session.DefaultSession.GetObjectByKey<Carriers>(shippingCarrierID.Value), shippingRecord);
            SetField(Shipping.Fields.ShipMainCustID.PropertyName, shippingRecord.ShipMainCustID, Session.DefaultSession.GetObjectByKey<Customers>(shippingCustID.Value), shippingRecord);
            SetField(Shipping.Fields.ShipMainBOL.PropertyName, shippingRecord.ShipMainBOL, shippingBol, shippingRecord);
            SetField(Shipping.Fields.intDestination.PropertyName, shippingRecord.intDestination, Session.DefaultSession.GetObjectByKey<ShippingAddresses>(intDestination.Value), shippingRecord);
            SetField(Shipping.Fields.strPO.PropertyName, shippingRecord.strPO, string.IsNullOrEmpty(strPO) ? null : strPO, shippingRecord);
            SetField(Shipping.Fields.strTrailer.PropertyName, shippingRecord.strTrailer, string.IsNullOrEmpty(strTrailer) ? null : strTrailer, shippingRecord);
            SetField(Shipping.Fields.sngSkits.PropertyName, shippingRecord.sngSkits, sngSkits ?? null, shippingRecord);
            SetField(Shipping.Fields.sngTotalPallets.PropertyName, shippingRecord.sngTotalPallets, sngTotalPallets ?? null, shippingRecord);
            SetField(Shipping.Fields.strSeal.PropertyName, shippingRecord.strSeal, string.IsNullOrEmpty(strSeal) ? null : strSeal, shippingRecord);
            SetField(Shipping.Fields.strDeliveryNote.PropertyName, shippingRecord.strDeliveryNote, string.IsNullOrEmpty(strDeliveryNote) ? null : strDeliveryNote, shippingRecord);
            SetField(Shipping.Fields.DeliveryNoteNumber.PropertyName, shippingRecord.DeliveryNoteNumber, string.IsNullOrEmpty(DeliveryNoteNumber) ? null : DeliveryNoteNumber, shippingRecord);
            SetField(Shipping.Fields.TotalGrossWeight.PropertyName, shippingRecord.TotalGrossWeight, TotalGrossWeight ?? null, shippingRecord);
            SetField(Shipping.Fields.Shipper.PropertyName, shippingRecord.Shipper, Shipper ?? null, shippingRecord);
            SetField(Shipping.Fields.Comments.PropertyName, shippingRecord.Comments, string.IsNullOrEmpty(Comments) ? null : Comments, shippingRecord);
            SetField(Shipping.Fields.Shift.PropertyName, shippingRecord.Shift, Shift.HasValue ? ((Shift.Value == 0) ? null : Session.DefaultSession.GetObjectByKey<Shifts>(Shift.Value)) : null, shippingRecord);
            SetField(Shipping.Fields.Freight.PropertyName, shippingRecord.Freight, Freight, shippingRecord);
            SetField(Shipping.Fields.LoadedBy.PropertyName, shippingRecord.LoadedBy, loadedBy.HasValue ? ((loadedBy.Value == 0) ? null : Session.DefaultSession.GetObjectByKey<Employees>(loadedBy.Value)) : null, shippingRecord);
            SetField(Shipping.Fields.CheckedBy.PropertyName, shippingRecord.CheckedBy, checkedBy.HasValue ? ((checkedBy.Value == 0) ? null : Session.DefaultSession.GetObjectByKey<Employees>(checkedBy.Value)) : null, shippingRecord);
            SetField(Shipping.Fields.WheelsChocked.PropertyName, shippingRecord.WheelsChocked, (wheelsChocked ?? 0) == 0 ? null : wheelsChocked, shippingRecord);
            SetField(Shipping.Fields.StartTime.PropertyName, shippingRecord.StartTime, startTime ?? null, shippingRecord);
            SetField(Shipping.Fields.FinishTime.PropertyName, shippingRecord.FinishTime, finishTime ?? null, shippingRecord);
            SetField(Shipping.Fields.Temparature.PropertyName, shippingRecord.Temparature, (temparature ?? 0) == 0 ? null : temparature, shippingRecord);
            SetField(Shipping.Fields.PhysicalCondition.PropertyName, shippingRecord.PhysicalCondition, physicalCondition.HasValue ? ((physicalCondition.Value == 0) ? null : Session.DefaultSession.GetObjectByKey<ShipmentConditions>(physicalCondition.Value)) : null, shippingRecord);
            SetField(Shipping.Fields.LoadCondition.PropertyName, shippingRecord.LoadCondition, loadCondition.HasValue ? ((loadCondition.Value == 0) ? null : Session.DefaultSession.GetObjectByKey<ShipmentConditions>(loadCondition.Value)) : null, shippingRecord);
            SetField(Shipping.Fields.ForeignSubstance.PropertyName, shippingRecord.ForeignSubstance, (foreignSubstance ?? 0) == 0 ? null : foreignSubstance, shippingRecord);
            SetField(Shipping.Fields.InsectActivity.PropertyName, shippingRecord.InsectActivity, (insectActivity ?? 0) == 0 ? null : insectActivity, shippingRecord);
            SetField(Shipping.Fields.CorrectPallets.PropertyName, shippingRecord.CorrectPallets, (correctPallets ?? 0) == 0 ? null : correctPallets, shippingRecord);
            SetField(Shipping.Fields.ShippingLocation.PropertyName, shippingRecord.ShippingLocation, Session.DefaultSession.GetObjectByKey<Locations>(locationID), shippingRecord);

        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
        public bool UpdateShipping(int shippingID, DateTime? shippingDate, int? shippingCarrierID, int? shippingCustID, int? shippingBol, int? intDestination, string strPO, string strTrailer, float? sngSkits, float? sngTotalPallets, string strSeal, string strDeliveryNote, string DeliveryNoteNumber, double? TotalGrossWeight, bool? Shipper, string Comments, int? Shift, bool Freight, int? loadedBy, int? checkedBy, int? wheelsChocked, DateTime? startTime, DateTime? finishTime, double? temparature, int? physicalCondition, int? loadCondition, int? foreignSubstance, int? insectActivity, int? correctPallets, int locationID)
        {

            StringBuilder str = new StringBuilder(string.Empty);
            if (!shippingCustID.HasValue)
            {
                str.Append("Customer Name, ");
            }

            if (!shippingCarrierID.HasValue)
            {
                str.Append("Carrier Name, ");
            }

            if (!intDestination.HasValue)
            {
                str.Append("Destination, ");
            }

            if (str.Length > 0)
            {
                throw new ApplicationException(string.Format("You must provide a {0}.", str.ToString().Substring(0, str.Length - 2)));
            }

            Change change = new Change();
            Shipping shippingRecord = Session.DefaultSession.GetObjectByKey<Shipping>(shippingID);

            if (shippingRecord == null)
            {
                //It is a new shipping
                //It must have all the quantity fields filled in
                if (temparature.HasValue == false || physicalCondition.HasValue == false || loadCondition.HasValue == false || foreignSubstance.HasValue == false || insectActivity.HasValue == false || correctPallets.HasValue == false || wheelsChocked.HasValue == false || loadedBy.HasValue == false || checkedBy.HasValue == false || string.IsNullOrEmpty(strTrailer))
                {
                    throw new ApplicationException("You must fill in all the quality fields.");
                }
                change = new Change()
                {
                    PropertyName = Shipping.Fields.ShipMainID.PropertyName,
                    PrevValue = "<NULL>",
                    NewValue = shippingID.ToString()
                };
                changes.Add(change);
                return InsertShipping(shippingID, shippingDate, shippingCarrierID, shippingCustID, shippingBol, intDestination, strPO, strTrailer, sngSkits, sngTotalPallets, strSeal, strDeliveryNote, DeliveryNoteNumber, TotalGrossWeight, Shipper, Comments, Shift, Freight, loadedBy, checkedBy, wheelsChocked, startTime, finishTime, temparature, physicalCondition, loadCondition, foreignSubstance, insectActivity, correctPallets, locationID);
            }

            change = new Change()
            {
                PropertyName = Shipping.Fields.ShipMainID.PropertyName,
                PrevValue = shippingRecord.ShipMainID.ToString(),
                NewValue = shippingRecord.ShipMainID.ToString()
            };
            changes.Add(change);
            SetShippingFields(shippingDate, shippingCarrierID, shippingCustID, shippingBol.Value, intDestination, strPO, strTrailer, sngSkits, sngTotalPallets, strSeal, strDeliveryNote, DeliveryNoteNumber, TotalGrossWeight, Shipper, Comments, Shift, Freight, loadedBy, checkedBy, wheelsChocked, startTime, finishTime, temparature, physicalCondition, loadCondition, foreignSubstance, insectActivity, correctPallets, locationID, shippingRecord);

            try
            {
                shippingRecord.Save();
            }
            catch (Exception ex)
            {
                return false;
            }

            UpdateAuditTrail();

            return true;

        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
        public bool InsertShipping(int shippingID, DateTime? shippingDate, int? shippingCarrierID, int? shippingCustID, int? shippingBol, int? intDestination, string strPO, string strTrailer, float? sngSkits, float? sngTotalPallets, string strSeal, string strDeliveryNote, string DeliveryNoteNumber, double? TotalGrossWeight, bool? Shipper, string Comments, int? Shift, bool Freight, int? loadedBy, int? checkedBy, int? wheelsChocked, DateTime? startTime, DateTime? finishTime, double? temparature, int? physicalCondition, int? loadCondition, int? foreignSubstance, int? insectActivity, int? correctPallets, int locationID)
        {

            Shipping shippingRecord = new Shipping(Session.DefaultSession) { ShipMainID = shippingID };

            if (shippingBol.HasValue == false)
            {
                shippingBol = GetMaxBOL() + 1;
            }
            SetShippingFields(shippingDate, shippingCarrierID, shippingCustID, shippingBol.Value, intDestination, strPO, strTrailer, sngSkits, sngTotalPallets, strSeal, strDeliveryNote, DeliveryNoteNumber, TotalGrossWeight, Shipper, Comments, Shift, Freight, loadedBy, checkedBy, wheelsChocked, startTime, finishTime, temparature, physicalCondition, loadCondition, foreignSubstance, insectActivity, correctPallets, locationID, shippingRecord);
            shippingRecord.strEnteredBy = Properties.Settings.Default.UserName;
            shippingRecord.dtmEnteredOn = DateTime.Now;

            try
            {
                shippingRecord.Save();
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;

        }

        public static int GetNewItemID()
        {

            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.UserConnectionString);
            System.Data.SqlClient.SqlCommand myCommand = new System.Data.SqlClient.SqlCommand("dbo.spNewIDSafe", conn);
            System.Data.SqlClient.SqlParameter myNewID = new System.Data.SqlClient.SqlParameter("@nRetVal", SqlDbType.Int);
            myCommand.CommandType = CommandType.StoredProcedure;
            myNewID.Direction = ParameterDirection.Output;
            myCommand.Parameters.AddWithValue("@cName", "tblShipMain");
            myCommand.Parameters.AddWithValue("@cPkField", "ShipMainID");
            myCommand.Parameters.Add(myNewID);

            conn.Open();
            myCommand.ExecuteNonQuery();

            return Convert.ToInt32(myNewID.Value);

        }

        [System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
        public bool DeleteShipping(int shippingID)
        {

            SPG.ShippingsDataTable shippings = Adapter.GetShippingByID(shippingID);
            int rowsAffected = 0;

            if (shippings.Count() == 1)
            {
                SPG.ShippingsRow shipping = (SPG.ShippingsRow)shippings.Rows[0];
                rowsAffected = Adapter.Delete(shippingID, shipping.ts);
            }

            //Return true if precisely one row was deleted, otherwise return false.
            return rowsAffected == 1;

        }

        public float GetTotalPalletsByCustomerID(int customerID)
        {

            object total = Adapter.GetTotalPalletsByCustomerID(customerID);
            if (total == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToSingle(total);
            }

        }

        public static bool IsLPNShipped(string fullLPNNumber, int customerID, Session DXSession)
        {

            if (!fullLPNNumber.StartsWith(CustomersBLL.GetLPNPrefix(customerID)))
            {
                fullLPNNumber = CustomersBLL.GetLPNPrefix(customerID) + ("0000000000" + fullLPNNumber).Substring(("0000000000" + fullLPNNumber).Length - CustomersBLL.GetCustomer(customerID, DXSession).LastLPNNumber.ToString().Length);
            }

            CriteriaOperatorCollection filter = new CriteriaOperatorCollection();
            filter.Add(new BinaryOperator(ShipDet.Fields.ShipDetMainID.ShipMainCustID.CustomerID.PropertyName, customerID, BinaryOperatorType.Equal));
            filter.Add(new BinaryOperator(ShipDet.Fields.FullLPNNumber.PropertyName, fullLPNNumber, BinaryOperatorType.Equal));

            int? LPNCount = (int?)XpoDefault.Session.Evaluate<ShipDet>(new AggregateOperand("", "FullLPNNumber", Aggregate.Count), new GroupOperator(GroupOperatorType.And, filter));

            if (LPNCount.HasValue && LPNCount.Value >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }

}