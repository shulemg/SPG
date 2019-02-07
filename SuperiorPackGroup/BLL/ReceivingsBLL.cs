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
using DXDAL.SPGData;
using DevExpress.Xpo;
using System.Linq;

namespace SuperiorPackGroup
{
	[System.ComponentModel.DataObject()]
	public class ReceivingsBLL
	{

		private ReceivingsTableAdapter m_ReceivingsTableAdapter = null;
		private List<Change> changes = new List<Change>();

		public ReceivingsTableAdapter Adapter
		{

			get
			{
				if (m_ReceivingsTableAdapter == null)
				{
					m_ReceivingsTableAdapter = new ReceivingsTableAdapter();
					m_ReceivingsTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return m_ReceivingsTableAdapter;
			}

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.ReceivingsDataTable GetReceivingsByCustomerID(int customerID)
		{

			return Adapter.GetReceivingsByCustomerID(customerID);

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
				builder.Length = (builder.Length - 2);
				AuditTrailBLL.AddTrailEntry(Properties.Settings.Default.UserName, int.Parse(changes[0].NewValue), "Receivings", builder.ToString());
			}

			changes.Clear();

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.ReceivingsDataTable GetIDAndBOLByCustomerAndDate(int? customerID, DateTime? fromDate, DateTime? toDate)
		{

			return Adapter.GetIDAndBOLByCustomerAndDate(customerID, fromDate, toDate);

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
		public SPG.ReceivingsDataTable GetReceivings()
		{

			return Adapter.GetReceivings();

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.ReceivingsDataTable GetReceivingsByID(int receiveID)
		{

			return Adapter.GetReceivingsByID(receiveID);

		}

		private void SetField(string propertyName, object oldValue, object newValue, Receiving receivingRecord)
		{

			if ((oldValue != null || newValue != null) && ((oldValue != null && newValue == null) || (newValue != null && oldValue == null) || oldValue.ToString() != newValue.ToString()))
			{
				receivingRecord.SetMemberValue(propertyName, newValue);
				Change change = new Change()
				{
					PropertyName = propertyName,
					PrevValue = ((oldValue == null) ? "<NULL>" : oldValue.ToString()),
					NewValue = ((newValue == null) ? "<NULL>" : newValue.ToString())
				};
				changes.Add(change);
			}

		}

		private void SetReceivingFields(DateTime? receivDate, int? receivCarrierID, int? receivCustID, string receivBol, int? strVendor, float? sngSkits, float? sngTotalPallets, string strPO, int? intShiftID, string strTrailer, string strSeal, string notes, int? unloadedBy, int? checkedBy, int? wheelsChocked, DateTime? startTime, DateTime? finishTime, double? temparature, int? physicalCondition, int? loadCondition, int? foreignSubstance, int? insectActivity, int? correctPallets, int locationID, Receiving receivingRecord)
		{

			SetField(Receiving.Fields.ReceivDate.PropertyName, receivingRecord.ReceivDate, (receivDate.HasValue ? receivDate.Value : DateTime.Today), receivingRecord);
			SetField(Receiving.Fields.ReceivCarrierID.PropertyName, receivingRecord.ReceivCarrierID, Session.DefaultSession.GetObjectByKey<Carriers>(receivCarrierID.Value), receivingRecord);
			SetField(Receiving.Fields.ReceivCustID.PropertyName, receivingRecord.ReceivCustID, Session.DefaultSession.GetObjectByKey<Customers>(receivCustID.Value), receivingRecord);
			SetField(Receiving.Fields.ReceivBOL.PropertyName, receivingRecord.ReceivBOL, receivBol, receivingRecord);
			SetField(Receiving.Fields.strVendor.PropertyName, receivingRecord.strVendor, (strVendor.HasValue ? Session.DefaultSession.GetObjectByKey<Vendor>(strVendor.Value) : null), receivingRecord);
			SetField(Receiving.Fields.sngSkits.PropertyName, receivingRecord.sngSkits, (sngSkits.HasValue ? sngSkits : null), receivingRecord);
			SetField(Receiving.Fields.sngTotalPallets.PropertyName, receivingRecord.sngTotalPallets, (sngTotalPallets.HasValue ? sngTotalPallets : null), receivingRecord);
			SetField(Receiving.Fields.strPO.PropertyName, receivingRecord.strPO, (string.IsNullOrEmpty(strPO) ? null : strPO), receivingRecord);
			SetField(Receiving.Fields.intShiftID.PropertyName, receivingRecord.intShiftID, Session.DefaultSession.GetObjectByKey<Shifts>(intShiftID.Value), receivingRecord);
			SetField(Receiving.Fields.strTrailer.PropertyName, receivingRecord.strTrailer, (string.IsNullOrEmpty(strTrailer) ? null : strTrailer), receivingRecord);
			SetField(Receiving.Fields.strSeal.PropertyName, receivingRecord.strSeal, (string.IsNullOrEmpty(strSeal) ? null : strSeal), receivingRecord);
			SetField(Receiving.Fields.Notes.PropertyName, receivingRecord.Notes, (string.IsNullOrEmpty(notes) ? null : notes), receivingRecord);
			SetField(Receiving.Fields.UnloadedBy.PropertyName, receivingRecord.UnloadedBy, (unloadedBy.HasValue ? ((unloadedBy.Value == 0) ? null : Session.DefaultSession.GetObjectByKey<Employees>(unloadedBy.Value)) : null), receivingRecord);
			SetField(Receiving.Fields.CheckedBy.PropertyName, receivingRecord.CheckedBy, (checkedBy.HasValue ? ((checkedBy.Value == 0) ? null : Session.DefaultSession.GetObjectByKey<Employees>(checkedBy.Value)) : null), receivingRecord);
			SetField(Receiving.Fields.WheelsChocked.PropertyName, receivingRecord.WheelsChocked, (wheelsChocked.HasValue ? ((wheelsChocked == 0) ? null : wheelsChocked) : null), receivingRecord);
			SetField(Receiving.Fields.StartTime.PropertyName, receivingRecord.StartTime, (startTime.HasValue ? startTime : null), receivingRecord);
			SetField(Receiving.Fields.FinishTime.PropertyName, receivingRecord.FinishTime, (finishTime.HasValue ? finishTime : null), receivingRecord);
			SetField(Receiving.Fields.Temparature.PropertyName, receivingRecord.Temparature, (temparature.HasValue ? ((temparature.Value == 0) ? null : temparature) : null), receivingRecord);
			SetField(Receiving.Fields.PhysicalCondition.PropertyName, receivingRecord.PhysicalCondition, (physicalCondition.HasValue ? ((physicalCondition.Value == 0) ? null : Session.DefaultSession.GetObjectByKey<ShipmentConditions>(physicalCondition.Value)) : null), receivingRecord);
			SetField(Receiving.Fields.LoadCondition.PropertyName, receivingRecord.LoadCondition, (loadCondition.HasValue ? ((loadCondition.Value == 0) ? null : Session.DefaultSession.GetObjectByKey<ShipmentConditions>(loadCondition.Value)) : null), receivingRecord);
			SetField(Receiving.Fields.ForeignSubstance.PropertyName, receivingRecord.ForeignSubstance, (foreignSubstance.HasValue ? ((foreignSubstance.Value == 0) ? null : foreignSubstance) : null), receivingRecord);
			SetField(Receiving.Fields.InsectActivity.PropertyName, receivingRecord.InsectActivity, (insectActivity.HasValue ? ((insectActivity.Value == 0) ? null : insectActivity) : null), receivingRecord);
			SetField(Receiving.Fields.CorrectPallets.PropertyName, receivingRecord.CorrectPallets, (correctPallets.HasValue ? ((correctPallets.Value == 0) ? null : correctPallets) : null), receivingRecord);
			SetField(Receiving.Fields.ReceivingLocation.PropertyName, receivingRecord.ReceivingLocation, Session.DefaultSession.GetObjectByKey<Locations>(locationID), receivingRecord);

		}
		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
		public bool UpdateReceiving(int receivID, DateTime? receivDate, int? receivCarrierID, int? receivCustID, string receivBol, int? strVendor, float? sngSkits, float? sngTotalPallets, string strPO, int? intShiftID, string strTrailer, string strSeal, string notes, int? unloadedBy, int? checkedBy, int? wheelsChocked, DateTime? startTime, DateTime? finishTime, double? temparature, int? physicalCondition, int? loadCondition, int? foreignSubstance, int? insectActivity, int? correctPallets, int locationID)
		{

			StringBuilder str = new StringBuilder(string.Empty);
			if (!receivCustID.HasValue)
			{
				str.Append("Customer Name, ");
			}

			if (!receivCarrierID.HasValue)
			{
				str.Append("Carrier Name, ");
			}

			if (!intShiftID.HasValue)
			{
				str.Append("Receiving Shift, ");
			}

			if (string.IsNullOrEmpty(receivBol))
			{
				str.Append("Receiving BOL, ");
			}

			if (str.Length > 0)
			{
				throw new ApplicationException(string.Format("You must provide a {0}.", str.ToString().Substring(0, (str.Length - 2))));
			}

			Change change = new Change();
			Receiving receivingRecord = Session.DefaultSession.GetObjectByKey<Receiving>(receivID);

			if (receivingRecord == null)
			{
				//It is a new Receiving
				//It must have all the quality fields filled in
				if (temparature.HasValue == false || physicalCondition.HasValue == false || loadCondition.HasValue == false || foreignSubstance.HasValue == false || insectActivity.HasValue == false || correctPallets.HasValue == false || wheelsChocked.HasValue == false || unloadedBy.HasValue == false || checkedBy.HasValue == false || string.IsNullOrEmpty(strTrailer))
				{
					throw new ApplicationException("You must fill in all the quality fields.");
				}
				change = new Change()
				{
					PropertyName = Receiving.Fields.ReceivID.PropertyName,
					PrevValue = "<NULL>",
					NewValue = receivID.ToString()
				};
				changes.Add(change);
				return InsertReceiving(receivID, receivDate, receivCarrierID, receivCustID, receivBol, strVendor, sngSkits, sngTotalPallets, strPO, intShiftID, strTrailer, strSeal, notes, unloadedBy, checkedBy, wheelsChocked, startTime, finishTime, temparature, physicalCondition, loadCondition, foreignSubstance, insectActivity, correctPallets, locationID);
			}

			//Dim receiving As SPG.ReceivingsRow = receivings(0)

			//Dim originalRecord As Object() = Nothing
			//originalRecord = receiving.ItemArray

			change = new Change()
			{
				PropertyName = Receiving.Fields.ReceivID.PropertyName,
				PrevValue = receivingRecord.ReceivID.ToString(),
				NewValue = receivingRecord.ReceivID.ToString()
			};
			changes.Add(change);
			SetReceivingFields(receivDate, receivCarrierID, receivCustID, receivBol, strVendor, sngSkits, sngTotalPallets, strPO, intShiftID, strTrailer, strSeal, notes, unloadedBy, checkedBy, wheelsChocked, startTime, finishTime, temparature, physicalCondition, loadCondition, foreignSubstance, insectActivity, correctPallets, locationID, receivingRecord);

			//If Not IsNothing(originalRecord) Then
			//    Me.UpdateAuditTrail(receiving, originalRecord)
			//End If

			//Dim rowsAffected As Integer = Adapter.Update(receiving)

			//Return rowsAffected = 1

			try
			{
				receivingRecord.Save();
			}
			catch (Exception ex)
			{
				return false;
			}

			UpdateAuditTrail();

			return true;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
		public bool InsertReceiving(int receivID, DateTime? receivDate, int? receivCarrierID, int? receivCustID, string receivBol, int? strVendor, float? sngSkits, float? sngTotalPallets, string strPO, int? intShiftID, string strTrailer, string strSeal, string notes, int? unloadedBy, int? checkedBy, int? wheelsChocked, DateTime? startTime, DateTime? finishTime, double? temparature, int? physicalCondition, int? loadCondition, int? foreignSubstance, int? insectActivity, int? correctPallets, int locationID)
		{

			//Dim receivings As SPG.ReceivingsDataTable = New SPG.ReceivingsDataTable
			//Dim receiving As SPG.ReceivingsRow = receivings.NewReceivingsRow()

			//receiving.ReceivID = receivID

			Receiving receivingRecord = new Receiving(Session.DefaultSession) {ReceivID = receivID};

			SetReceivingFields(receivDate, receivCarrierID, receivCustID, receivBol, strVendor, sngSkits, sngTotalPallets, strPO, intShiftID, strTrailer, strSeal, notes, unloadedBy, checkedBy, wheelsChocked, startTime, finishTime, temparature, physicalCondition, loadCondition, foreignSubstance, insectActivity, correctPallets, locationID, receivingRecord);
			receivingRecord.strEnteredBy = Properties.Settings.Default.UserName;
			receivingRecord.dtmEnteredOn = DateTime.Now;

			//receivings.AddReceivingsRow(receiving)
			//Dim rowsAffected As Integer = Adapter.Update(receivings)

			//Return rowsAffected = 1

			try
			{
				receivingRecord.Save();
			}
			catch (Exception ex)
			{
				return false;
			}

			UpdateAuditTrail();

			return true;

		}

		public static int GetNewReceivingID()
		{

			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.UserConnectionString);
			System.Data.SqlClient.SqlCommand myCommand = new System.Data.SqlClient.SqlCommand("dbo.spNewIDSafe", conn);
			System.Data.SqlClient.SqlParameter myNewID = new System.Data.SqlClient.SqlParameter("@nRetVal", SqlDbType.Int);
			myCommand.CommandType = CommandType.StoredProcedure;
			myNewID.Direction = ParameterDirection.Output;
			myCommand.Parameters.AddWithValue("@cName", "tblReceivMain");
			myCommand.Parameters.AddWithValue("@cPkField", "ReceivID");
			myCommand.Parameters.Add(myNewID);

			conn.Open();
			myCommand.ExecuteNonQuery();

			return Convert.ToInt32(myNewID.Value);

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
		public bool DeleteReceiving(int receivingID)
		{

			SPG.ReceivingsDataTable receivings = Adapter.GetReceivingsByID(receivingID);
			int rowsAffected = 0;

			if (receivings.Count() == 1)
			{
				SPG.ReceivingsRow receiving = (SPG.ReceivingsRow)receivings.Rows[0];
				rowsAffected = Adapter.Delete(receivingID, receiving.ts);
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

	}

}