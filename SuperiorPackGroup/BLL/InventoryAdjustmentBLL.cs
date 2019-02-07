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
using DevExpress.Xpo;
using DXDAL.SPGData;
using DevExpress.Data.Filtering;

namespace SuperiorPackGroup
{
	[System.ComponentModel.DataObject()]
	public class InventoryAdjustmentBLL
	{

		private InventoryAdjustmentTableAdapter m_InventoryAdjustmentTableAdapter;
		private readonly List<Change> changes = new List<Change>();

		public InventoryAdjustmentTableAdapter Adapter
		{

			get
			{
				if (m_InventoryAdjustmentTableAdapter == null)
				{
					m_InventoryAdjustmentTableAdapter = new InventoryAdjustmentTableAdapter();
					m_InventoryAdjustmentTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return m_InventoryAdjustmentTableAdapter;
			}

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.InventoryAdjustmentDataTable GetAdjustmentView(DateTime? fromDate, DateTime? toDate, int? customer, int? item)
		{

			return Adapter.GetAdjustmentView(fromDate, toDate, customer, item);

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
				AuditTrailBLL.AddTrailEntry(Properties.Settings.Default.UserName, int.Parse(changes[0].NewValue), "InventoryAdjustment", builder.ToString());
			}

			changes.Clear();

		}

		//Private Sub UpdateAuditTrail(ByVal ModifiedRecord As SPG.InventoryAdjustmentRow, ByVal originalRecord As Object())

		//    Dim builder As New StringBuilder(String.Empty)
		//    Dim recordFields As Integer = (ModifiedRecord.ItemArray.Length - 1)
		//    Dim i As Integer = 0
		//    Do While (i <= recordFields)
		//        Try
		//            If IsDBNull(originalRecord(i)) Then
		//                If Not IsDBNull(ModifiedRecord.Item(i)) Then
		//                    builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, "NULL", ModifiedRecord.Item(i)))
		//                End If
		//            ElseIf Information.IsDBNull(ModifiedRecord.Item(i)) Then
		//                If Not Information.IsDBNull(originalRecord(i)) Then
		//                    builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, originalRecord(i), "NULL"))
		//                End If
		//            ElseIf ModifiedRecord.Item(i) IsNot originalRecord(i) Then
		//                builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, originalRecord(i), ModifiedRecord.Item(i)))
		//            End If
		//        Catch
		//        End Try
		//        i += 1
		//    Loop
		//    If (builder.Length > 2) Then
		//        builder.Length = (builder.Length - 2)
		//        AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(ModifiedRecord.Item(0), Integer), "InventoryAdjustment", builder.ToString)
		//    End If

		//End Sub

		public static int GetNewInventoryAdjustmentID()
		{

			using (System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.UserConnectionString))
			{
				System.Data.SqlClient.SqlCommand myCommand = new System.Data.SqlClient.SqlCommand("dbo.spNewIDSafe", conn);
				System.Data.SqlClient.SqlParameter myNewID = new System.Data.SqlClient.SqlParameter("@nRetVal", SqlDbType.Int);
				myCommand.CommandType = CommandType.StoredProcedure;
				myNewID.Direction = ParameterDirection.Output;
				myCommand.Parameters.AddWithValue("@cName", "tblInventoryAdjustment");
				myCommand.Parameters.AddWithValue("@cPkField", "AdjustmentID");
				myCommand.Parameters.Add(myNewID);
				conn.Open();
				myCommand.ExecuteNonQuery();
				return Convert.ToInt32(myNewID.Value);
			}

		}

		private void SetField(string propertyName, object oldValue, object newValue, InventoryAdjustment adjustment)
		{

			if ((oldValue != null || newValue != null) && ((oldValue != null && newValue == null) || (newValue != null && oldValue == null) || oldValue.ToString() != newValue.ToString()))
			{
				adjustment.SetMemberValue(propertyName, newValue);
				Change change = new Change()
				{
					PropertyName = propertyName,
					PrevValue = ((oldValue == null) ? "<NULL>" : oldValue.ToString()),
					NewValue = ((newValue == null) ? "<NULL>" : newValue.ToString())
				};
				changes.Add(change);
			}

		}

		private void SetInventoryAdjustmentFields(DateTime adjustmentDate, int customer, int item, float originalQuantity, float? newQuantity, string reason, int locationID, string OriginalLot, string NewLot, int? LPN, InventoryAdjustment adjustment)
		{

			SetField(InventoryAdjustment.Fields.AdjustmentDate.PropertyName, adjustment.AdjustmentDate, Convert.ToDateTime(adjustmentDate.ToString("D")), adjustment);
			SetField(InventoryAdjustment.Fields.Customer.PropertyName, adjustment.Customer, Session.DefaultSession.GetObjectByKey<Customers>(customer), adjustment);
			SetField(InventoryAdjustment.Fields.AdjustmentItem.PropertyName, adjustment.AdjustmentItem, Session.DefaultSession.GetObjectByKey<Items>(item), adjustment);
			SetField(InventoryAdjustment.Fields.OriginalQuantity.PropertyName, adjustment.OriginalQuantity, originalQuantity, adjustment);
			SetField(InventoryAdjustment.Fields.NewCount.PropertyName, adjustment.NewCount, newQuantity, adjustment);
			SetField(InventoryAdjustment.Fields.Reason.PropertyName, adjustment.Reason, reason, adjustment);
			SetField(InventoryAdjustment.Fields.OriginalLot.PropertyName, adjustment.OriginalLot, OriginalLot, adjustment);
			SetField(InventoryAdjustment.Fields.NewLot.PropertyName, adjustment.NewLot, NewLot, adjustment);
			SetField(InventoryAdjustment.Fields.LPN.PropertyName, adjustment.LPN, LPN, adjustment);
			SetField(InventoryAdjustment.Fields.InventoryLocation.PropertyName, adjustment.InventoryLocation, Session.DefaultSession.GetObjectByKey<Locations>(locationID), adjustment);

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
		public bool UpdateInventoryAdjustment(int adjustmentID, DateTime adjustmentDate, int customer, int item, float originalQuantity, float? newQuantity, string reason, int locationID, string OriginalLot, string NewLot, int? LPN, DateTime? Expr)
		{

			//Dim adjustments As SPG.InventoryAdjustmentDataTable = Adapter.GetInventoryAdjustmentByID(adjustmentID)

			//If adjustments.Count = 0 Then
			Change change = new Change();
			InventoryAdjustment adjustment = Session.DefaultSession.GetObjectByKey<InventoryAdjustment>(adjustmentID);

			if (adjustment == null)
			{
				//It is a new Production Record
				change = new Change()
				{
					PropertyName = InventoryAdjustment.Fields.AdjustmentID.PropertyName,
					PrevValue = "<NULL>",
					NewValue = adjustmentID.ToString()
				};
				changes.Add(change);
				return InsertInventoryAdjustment(adjustmentID, adjustmentDate, customer, item, originalQuantity, newQuantity, reason, locationID, OriginalLot, NewLot, LPN, Expr);
			}

			//Dim adjustment As SPG.InventoryAdjustmentRow = adjustments(0)
			int originalItem = adjustment.AdjustmentItem.ItemID;
			float? originalNewQuantity = null;
			float? newNewQuantity = null;
			string originalNewLot = null;
			string newNewLot = null;
			string originalOldLot = null;
			string newOldLot = null;
			bool itemChanged = false;
			int? originalLPN = null;
			int originalLocation = 0;

			//Dim originalRecord As Object() = adjustment.ItemArray

			//adjustment.AdjustmentDate = CDate(Format(adjustmentDate, "D"))
			//adjustment.Customer = customer
			if (originalItem != item)
			{
				itemChanged = true;
			}
			else
			{
				itemChanged = false;
			}
			//adjustment.ItemID = item
			float originalOriginalQuantity = adjustment.OriginalQuantity;
			originalNewQuantity = adjustment.NewCount;
			originalNewLot = adjustment.NewLot;
			originalOldLot = adjustment.OriginalLot;
			originalLPN = adjustment.LPN;
			originalLocation = adjustment.InventoryLocation.Oid;
			newNewQuantity = (newQuantity ?? 0) - originalNewQuantity;
			//adjustment.OriginalQuantity = originalQuantity
			//adjustment.NewCount = newQuantity
			//adjustment.Reason = reason

			change = new Change()
			{
				PropertyName = InventoryAdjustment.Fields.AdjustmentID.PropertyName,
				PrevValue = adjustment.AdjustmentID.ToString(),
				NewValue = adjustment.AdjustmentID.ToString()
			};
			changes.Add(change);
			SetInventoryAdjustmentFields(adjustmentDate, customer, item, originalQuantity, newQuantity, reason, locationID, OriginalLot, NewLot, LPN, adjustment);

			try
			{
				adjustment.Save();
			}
			catch (Exception ex)
			{
				return false;
			}

			UpdateAuditTrail();

			//If Not IsNothing(originalRecord) Then
			//    UpdateAuditTrail(adjustment, originalRecord)
			//End If

			//Dim rowsAffected As Integer = Adapter.Update(adjustment)

			//If rowsAffected = 1 Then
			ItemsBLL items = new ItemsBLL();
			if (!string.IsNullOrEmpty(originalNewLot))
			{
				items.UpdateStock(Session.DefaultSession, originalItem, originalOriginalQuantity, false, originalLocation, originalOldLot, originalLocation);
				items.UpdateStock(Session.DefaultSession, originalItem, originalOriginalQuantity * -1, false, originalLocation, originalNewLot, originalLPN);
			}
			else
			{
				items.UpdateStock(Session.DefaultSession, originalItem, ((originalNewQuantity ?? 0) - originalOriginalQuantity) * -1, false, originalLocation, OriginalLot, originalLPN);
			}
			if (!string.IsNullOrEmpty(NewLot))
			{
				items.UpdateStock(Session.DefaultSession, item, originalQuantity * -1, false, locationID, OriginalLot, LPN, Expr);
				items.UpdateStock(Session.DefaultSession, item, originalQuantity, false, locationID, NewLot, LPN, Expr);
			}
			else
			{
				items.UpdateStock(Session.DefaultSession, item, (newQuantity ?? 0) - originalQuantity, false, locationID, OriginalLot, LPN, Expr);
			}
			//If itemChanged = True Then
			//    items.UpdateStock(Session.DefaultSession, originalItem, (If(originalNewQuantity, 0) - originalOriginalQuantity) * -1, False, locationID)
			//    items.UpdateStock(Session.DefaultSession, item, If(newQuantity, 0) - originalQuantity, False, locationID)
			//Else
			//    If newNewQuantity <> 0 Then    'there was a change in the quantity
			//        items.UpdateStock(Session.DefaultSession, item, If(newNewQuantity, 0), False, locationID)
			//    End If
			//End If
			//End If

			//Return rowsAffected = 1
			return true;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
		public bool InsertInventoryAdjustment(int adjustmentID, DateTime adjustmentDate, int customer, int item, float originalQuantity, float? newQuantity, string reason, int locationID, string OriginalLot, string NewLot, int? LPN, DateTime? Expr)
		{

			//Dim adjustments As SPG.InventoryAdjustmentDataTable = New SPG.InventoryAdjustmentDataTable
			//Dim adjustment As SPG.InventoryAdjustmentRow = adjustments.NewInventoryAdjustmentRow()

			//adjustment.AdjustmentID = adjustmentID

			InventoryAdjustment adjustment = new InventoryAdjustment(Session.DefaultSession) {AdjustmentID = adjustmentID};

			//adjustment.AdjustmentDate = CDate(Format(adjustmentDate, "D"))
			//adjustment.Customer = customer
			//adjustment.ItemID = item
			//adjustment.OriginalQuantity = originalQuantity
			//adjustment.NewCount = newQuantity
			//adjustment.Reason = reason

			SetInventoryAdjustmentFields(adjustmentDate, customer, item, originalQuantity, newQuantity, reason, locationID, OriginalLot, NewLot, LPN, adjustment);
			adjustment.strEnteredBy = Properties.Settings.Default.UserName;
			adjustment.dtmEnteredOn = DateTime.Now;

			try
			{
				adjustment.Save();
			}
			catch (Exception ex)
			{
				return false;
			}

			//adjustments.AddInventoryAdjustmentRow(adjustment)
			//Dim rowsAffected As Integer = Adapter.Update(adjustments)

			//If rowsAffected = 1 Then
			ItemsBLL items = new ItemsBLL();
			if (!string.IsNullOrEmpty(NewLot))
			{
				items.UpdateStock(Session.DefaultSession, item, originalQuantity * -1, false, locationID, OriginalLot, LPN, Expr);
				items.UpdateStock(Session.DefaultSession, item, originalQuantity, false, locationID, NewLot, LPN, Expr);
			}
			else
			{
				items.UpdateStock(Session.DefaultSession, item, (newQuantity ?? 0) - originalQuantity, false, locationID, OriginalLot, LPN, Expr);
			}
			//End If

			//Return rowsAffected = 1
			return true;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.InventoryAdjustmentDataTable GetAdjustmentByID(int adjustmentID)
		{

			return Adapter.GetInventoryAdjustmentByID(adjustmentID);

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
		public static bool DeleteInventoryAdjustment(int id)
		{

			//Dim adjustments As SPG.InventoryAdjustmentDataTable = Adapter.GetInventoryAdjustmentByID(id)
			//Dim rowsAffected As Integer = 0
			int item = 0;
			int locationID = 0;
			int? LPN = null;
			float quantity = 0;
			string oldlot = null;
			string newlot = null;

			//If adjustments.Count = 1 Then
			//    Dim adjustment As SPG.InventoryAdjustmentRow = CType(adjustments.Rows(0), SPG.InventoryAdjustmentRow)

			InventoryAdjustment adjustment = Session.DefaultSession.GetObjectByKey<InventoryAdjustment>(id);

			if (adjustment == null)
			{
				return false;
			}
			item = adjustment.AdjustmentItem.ItemID;
			quantity = adjustment.OriginalQuantity - (adjustment.NewCount ?? 0);
			locationID = adjustment.InventoryLocation.Oid;
			LPN = adjustment.LPN;
			newlot = adjustment.NewLot;
			oldlot = adjustment.OriginalLot;
			//rowsAffected = Adapter.Delete(id, adjustment.rv)
			//End If

			try
			{
				adjustment.Delete();
				ItemsBLL items = new ItemsBLL();
				if (!string.IsNullOrEmpty(newlot))
				{
					items.UpdateStock(Session.DefaultSession, item, quantity * -1, false, locationID, newlot, LPN);
					items.UpdateStock(Session.DefaultSession, item, quantity, false, locationID, oldlot, LPN);
				}
				else
				{
					items.UpdateStock(Session.DefaultSession, item, quantity, false, locationID, oldlot, LPN);
				}
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}

		}

		public static XPView GetAdjustmentsByItemID(int itemID)
		{

			XPView AdjustmentXPView = new XPView(Session.DefaultSession, typeof(InventoryAdjustment));

			AdjustmentXPView.Properties.AddRange(new ViewProperty[]
			{
				new ViewProperty("AdjustmentID", SortDirection.None, InventoryAdjustment.Fields.AdjustmentID, false, true),
				new ViewProperty("AdjustmentDate", SortDirection.Ascending, InventoryAdjustment.Fields.AdjustmentDate, false, true),
				new ViewProperty("OriginalQuantity", SortDirection.None, InventoryAdjustment.Fields.OriginalQuantity, false, true),
				new ViewProperty("NewCount", SortDirection.None, InventoryAdjustment.Fields.NewCount, false, true),
				new ViewProperty("OriginalLot", SortDirection.None, InventoryAdjustment.Fields.OriginalLot, false, true),
				new ViewProperty("NewLot", SortDirection.None, InventoryAdjustment.Fields.NewLot, false, true),
				new ViewProperty("LPN", SortDirection.None, InventoryAdjustment.Fields.LPN, false, true),
				new ViewProperty("AdjustmentQuantity", SortDirection.None, InventoryAdjustment.Fields.NewCount - InventoryAdjustment.Fields.OriginalQuantity, false, true),
				new ViewProperty("Reason", SortDirection.None, InventoryAdjustment.Fields.Reason, false, true)
			});

			AdjustmentXPView.Criteria = new BinaryOperator(InventoryAdjustment.Fields.AdjustmentItem.ItemID.PropertyName, itemID, BinaryOperatorType.Equal);

			return AdjustmentXPView;

		}

	}

}