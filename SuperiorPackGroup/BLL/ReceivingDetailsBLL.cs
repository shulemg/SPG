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
using DevExpress.Persistent.Base;
using DevExpress.Data.Filtering;

namespace SuperiorPackGroup
{
	[System.ComponentModel.DataObject()]
	public class ReceivingDetailsBLL
	{

		private ReceivingDetailsTableAdapter m_ReceivingDetailsTableAdapter = null;
		public ReceivingDetailsTableAdapter Adapter
		{

			get
			{
				if (m_ReceivingDetailsTableAdapter == null)
				{
					m_ReceivingDetailsTableAdapter = new ReceivingDetailsTableAdapter();
					m_ReceivingDetailsTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return m_ReceivingDetailsTableAdapter;
			}

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.ReceivingDetailsDataTable GetReceivingDetailsByItemIDold(int itemID)
		{

			return Adapter.GetReceivingDetailsByItemID(itemID);

		}
		public static XPView GetReceivingDetailsByItemID(int itemID)
		{


			XPView ReceivingXPView = new XPView(Session.DefaultSession, typeof(ReceivingDetail));

			ReceivingXPView.Properties.AddRange(new ViewProperty[]
			{
				new ViewProperty("ReceiveDetID", SortDirection.None, ReceivingDetail.Fields.ReceivDetID, false, true),
				new ViewProperty("ReceiveMainID", SortDirection.Ascending, ReceivingDetail.Fields.ReceivMainID.ReceivID, false, true),
				new ViewProperty("ReceiveDetLot", SortDirection.None, ReceivingDetail.Fields.ReceivDetLot, false, true),
				new ViewProperty("ReceiveDetLPN", SortDirection.None, ReceivingDetail.Fields.ReceivDetLPN, false, true),
				new ViewProperty("ExpirationDate", SortDirection.None, ReceivingDetail.Fields.ExpirationDate, false, true),
				new ViewProperty("ReceiveDetQty", SortDirection.None, ReceivingDetail.Fields.ReceivDetQty, false, true),
				new ViewProperty("ReceiveBOL", SortDirection.None, ReceivingDetail.Fields.ReceivMainID.ReceivBOL, false, true),
				new ViewProperty("ReceiveDate", SortDirection.None, ReceivingDetail.Fields.ReceivMainID.ReceivDate, false, true)
			});

			ReceivingXPView.Criteria = CriteriaOperator.And(new BinaryOperator(ReceivingDetail.Fields.ReceivDetItemID.ItemType.PropertyName, "FG", BinaryOperatorType.NotEqual), new BinaryOperator(ReceivingDetail.Fields.ReceivDetItemID.ItemID.PropertyName, itemID, BinaryOperatorType.Equal));

			return ReceivingXPView;
		}

		private void UpdateAuditTrail(ReceivingDetail ModifiedRecord, ReceivingDetail originalRecord)
		{

			//Dim builder As New StringBuilder(String.Empty)
			//Dim recordFields As Integer = (ModifiedRecord.ItemArray.Length - 1)
			//Dim i As Integer = 0
			//Do While (i <= recordFields)
			//    Try
			//        If IsDBNull(originalRecord(i)) Then
			//            If Not IsDBNull(ModifiedRecord.Item(i)) Then
			//                builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, "NULL", ModifiedRecord.Item(i)))
			//            End If
			//        ElseIf IsDBNull(ModifiedRecord.Item(i)) Then
			//            If Not IsDBNull(originalRecord(i)) Then
			//                builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, originalRecord(i), "NULL"))
			//            End If
			//        ElseIf CStr(ModifiedRecord.Item(i)) <> CStr(originalRecord(i)) Then
			//            builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, originalRecord(i), ModifiedRecord.Item(i)))
			//        End If
			//    Catch
			//    End Try
			//    i += 1
			//Loop
			//If (builder.Length > 2) Then
			//    builder.Length = (builder.Length - 2)
			//    AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(ModifiedRecord.Item(0), Integer), "ReceivingDetails", builder.ToString)
			//End If

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.ReceivingDetailsDataTable GetDetailsByReceivingID(int receivingID)
		{

			return Adapter.GetDetailsByReceivingID(receivingID);

		}

		public int UpdateReceivingDetails(Session session, int? detailID, int receivingID, int? itemID, string lot, int? quantity, int? units, int? LPN, DateTime? expirationDate)
		{

			if (!itemID.HasValue)
			{
				throw new ApplicationException("You must provide receiving item.");
			}

			if (!quantity.HasValue || !units.HasValue)
			{
				throw new ApplicationException("You must provide the amount of quamtity\\units received.");
			}

			if (LPN == null)
			{
				throw new ApplicationException("LPN is blank.");
			}

			Items item = session.GetObjectByKey<Items>(itemID.Value, true);

			if (!LotCodeValidator.ValidateByItem(item, lot, true))
			{
				throw new ApplicationException("Item " + item.ItemCode + " & lot # " + lot + " is invalid" + Environment.NewLine + "You must provide a valid lot.");
			}


			ReceivingDetail detail = session.GetObjectByKey<ReceivingDetail>(detailID);

			if (detail == null)
			{
				//It is a new Detail
				return InsertDetails(session, receivingID, item, lot, quantity, units, LPN, expirationDate);
			}

			bool itemChanged = false;

			ReceivingDetail originalDetail = null;
			Cloner cloner = new Cloner();
			originalDetail = (ReceivingDetail)cloner.CloneTo(detail, typeof(ReceivingDetail));

			if (itemID.HasValue && originalDetail.ReceivDetItemID.ItemID != itemID)
			{
				itemChanged = true;
			}

			detail.ReceivDetItemID = item;
			detail.intUnits = units.Value;
			detail.ReceivDetQty = quantity.Value;
			detail.ExpirationDate = expirationDate;
			detail.ReceivDetLPN = LPN;
			detail.ReceivDetLot = lot;


			if (!(originalDetail == null))
			{
				UpdateAuditTrail(detail, originalDetail);
			}

			session.Save(detail);

			if (!detail.Equals(originalDetail))
			{
				ItemsBLL items = new ItemsBLL();
				int locationID = session.GetObjectByKey<Receiving>(receivingID).ReceivingLocation.Oid;
				items.UpdateStock(session, originalDetail.ReceivDetItemID.ItemID, null, originalDetail.ReceivDetQty * -1, false, locationID, originalDetail.ReceivDetLot, LPN);

				items.UpdateStock(session, itemID.Value, quantity.Value, false, locationID, lot, LPN, expirationDate);
			}

			return detail.ReceivDetID;

		}

		public int InsertDetails(Session session, int receivingID, Items item, string lot, int? quantity, int? units, int? LPN, DateTime? expirationDate)
		{

			ReceivingDetail detail = new ReceivingDetail(session);

			detail.ReceivMainID = session.GetObjectByKey<Receiving>(receivingID);
			detail.ReceivDetItemID = item;
			detail.intUnits = units.Value;
			detail.ReceivDetQty = quantity.Value;
			detail.ExpirationDate = expirationDate;
			detail.ReceivDetLPN = LPN;
			detail.ReceivDetLot = lot;

			detail.Save();


			ItemsBLL items = new ItemsBLL();
			int locationID = session.GetObjectByKey<Receiving>(receivingID).ReceivingLocation.Oid;

			items.UpdateStock(session, item.ItemID, quantity.Value, false, locationID, lot, LPN, expirationDate);

			return detail.ReceivDetID;

		}

		public bool DeleteReceivingDetail(Session session, int detailID)
		{

			ReceivingDetail detail = session.GetObjectByKey<ReceivingDetail>(detailID);
			int rowsAffected = 0;
			int itemID = 0;
			int quantity = 0;
			int locationID = 0;
			int units = 0;
			int? lpn = null;
			string lot = null;

			if (detail != null)
			{
				itemID = detail.ReceivDetItemID.ItemID;
				units = detail.intUnits;
				quantity = detail.ReceivDetQty;
				locationID = session.GetObjectByKey<Receiving>(detail.ReceivMainID.ReceivID).ReceivingLocation.Oid;
				lpn = detail.ReceivDetLPN;
				lot = detail.ReceivDetLot;
				session.Delete(detail);
			}

			ItemsBLL items = new ItemsBLL();
			items.UpdateStock(session, itemID, quantity * -1, false, locationID, lot, lpn);

			return true;

		}

		private int GetNextLPN(int LPNcount)
		{
			int nextLPN = 0;
			Customers customer = Session.DefaultSession.GetObjectByKey<Customers>(7);

			customer.Reload();
			if (customer.NextLPNNumber > 0)
			{
				nextLPN = customer.NextLPNNumber;
				customer.NextLPNNumber += LPNcount;
				customer.Save();
			}
			else
			{
				if (customer.FirstLPNNumber.HasValue)
				{
					nextLPN = customer.FirstLPNNumber.Value;
					customer.NextLPNNumber = nextLPN + LPNcount;
					customer.Save();
				}
			}

			if (nextLPN > customer.LastLPNNumber)
			{
				MessageBox.Show("You ran out of LPN numbers, you must provide a different range of numbers before creating a new LPN number");
				nextLPN = 0;
			}

			if (nextLPN == customer.LastLPNNumber)
			{
				MessageBox.Show("You used now your last LPN number, please provide a different range of numbers before creating a new LPN number");
			}

			return nextLPN;

		}

	}

}