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
using System.Linq;

namespace SuperiorPackGroup
{
	[System.ComponentModel.DataObject()]
	public class ReturnDetailsBLL
	{

		private ReturnDetTableAdapter m_ReturnDetailsTableAdapter = null;
		public ReturnDetTableAdapter Adapter
		{

			get
			{
				if (m_ReturnDetailsTableAdapter == null)
				{
					m_ReturnDetailsTableAdapter = new ReturnDetTableAdapter();
					m_ReturnDetailsTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return m_ReturnDetailsTableAdapter;
			}

		}

		private void UpdateAuditTrail(SPG.ReturnDetRow ModifiedRecord, object[] originalRecord)
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
				AuditTrailBLL.AddTrailEntry(Properties.Settings.Default.UserName, Convert.ToInt32(ModifiedRecord[0]), "ReturnDetails", builder.ToString());
			}

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.ReturnDetDataTable GetDetailsByReceivingID(int receivingID)
		{

			return Adapter.GetReturnDetByReceivingID(receivingID);

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
		public bool UpdateReturnDetails(Session session, int? detailID, int receivingID, int? itemID, string lot, int? quantity, int? units, float? pallets, string reason, DateTime? expirationDate)
		{

			if (!itemID.HasValue)
			{
				throw new ApplicationException("You must provide return item.");
			}

			if (!quantity.HasValue)
			{
				throw new ApplicationException("You must provide the Quantity returned.");
			}

			SPG.ReturnDetDataTable details = Adapter.GetReturnDetByID(detailID.Value);

			if (details.Count() == 0)
			{
				//It is a new Detail
				return InsertDetails(session, receivingID, itemID, lot, quantity, units, pallets, reason, expirationDate);
			}

			SPG.ReturnDetRow returnDetail = details[0];
			int originalItem = 0;
			int originalQuantity = 0;
			int newQuantity = 0;
			bool itemChanged = false;

			object[] originalRecord = returnDetail.ItemArray;

			originalItem = returnDetail.ReturnDetItemID;
			if (itemID.HasValue && originalItem != itemID.Value)
			{
				itemChanged = true;
			}
			returnDetail.ReturnDetItemID = itemID.Value;
			if (string.IsNullOrEmpty(lot))
			{
				returnDetail.SetReturnDetLotNull();
			}
			else
			{
				returnDetail.ReturnDetLot = lot;
			}
			originalQuantity = returnDetail.ReturnDetQty;
			newQuantity = returnDetail.ReturnDetQty - quantity.Value;
			returnDetail.ReturnDetQty = quantity.Value;
			if (!units.HasValue)
			{
				returnDetail.SetintUnitsNull();
			}
			else
			{
				returnDetail.intUnits = units.Value;
			}
			if (!pallets.HasValue)
			{
				returnDetail.SetsngPalletsNull();
			}
			else
			{
				returnDetail.sngPallets = pallets.Value;
			}
			if (string.IsNullOrEmpty(reason))
			{
				returnDetail.SetReasonNull();
			}
			else
			{
				returnDetail.Reason = reason;
			}
			if (expirationDate.HasValue)
			{
				returnDetail.ExpirationDate = expirationDate.Value;
			}
			else
			{
				returnDetail.SetExpirationDateNull();
			}

			if (!(originalRecord == null))
			{
				UpdateAuditTrail(returnDetail, originalRecord);
			}

			int rowsAffected = Adapter.Update(returnDetail);

			if (rowsAffected == 1)
			{
				ItemsBLL items = new ItemsBLL();
				int locationID = session.GetObjectByKey<Receiving>(receivingID).ReceivingLocation.Oid;
				if (itemChanged == true)
				{
					items.UpdateStock(session, originalItem, originalQuantity * -1, false, locationID);
					items.UpdateStock(session, itemID.Value, quantity.Value, false, locationID);
				}
				else
				{
					if (newQuantity != 0)
					{
						items.UpdateStock(session, itemID.Value, newQuantity * -1, false, locationID);
					}
				}
			}

			return rowsAffected == 1;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
		public bool InsertDetails(Session session, int receivingID, int? itemID, string lot, int? quantity, int? units, float? pallets, string reason, DateTime? expirationDate)
		{

			SPG.ReturnDetDataTable details = new SPG.ReturnDetDataTable();
			SPG.ReturnDetRow returnDetail = details.NewReturnDetRow();

			returnDetail.ReceiveMainID = receivingID;
			returnDetail.ReturnDetItemID = itemID.Value;
			if (string.IsNullOrEmpty(lot))
			{
				returnDetail.SetReturnDetLotNull();
			}
			else
			{
				returnDetail.ReturnDetLot = lot;
			}
			returnDetail.ReturnDetQty = quantity.Value;
			if (!units.HasValue)
			{
				returnDetail.SetintUnitsNull();
			}
			else
			{
				returnDetail.intUnits = units.Value;
			}
			if (!pallets.HasValue)
			{
				returnDetail.SetsngPalletsNull();
			}
			else
			{
				returnDetail.sngPallets = pallets.Value;
			}
			if (string.IsNullOrEmpty(reason))
			{
				returnDetail.SetReasonNull();
			}
			else
			{
				returnDetail.Reason = reason;
			}
			if (expirationDate.HasValue)
			{
				returnDetail.ExpirationDate = expirationDate.Value;
			}
			else
			{
				returnDetail.SetExpirationDateNull();
			}

			details.AddReturnDetRow(returnDetail);
			int rowsAffected = Adapter.Update(details);

			if (rowsAffected == 1)
			{
				ItemsBLL items = new ItemsBLL();
				items.UpdateStock(session, itemID.Value, quantity.Value, false, session.GetObjectByKey<Receiving>(receivingID).ReceivingLocation.Oid);
			}

			return rowsAffected == 1;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
		public bool DeleteReturnDetail(Session session, int detailID)
		{

			SPG.ReturnDetDataTable details = Adapter.GetReturnDetByID(detailID);
			int rowsAffected = 0;
			int itemID = 0;
			int quantity = 0;
			int locationID = 0;

			if (details.Count() == 1)
			{
				SPG.ReturnDetRow returnDetail = (SPG.ReturnDetRow)details.Rows[0];
				itemID = returnDetail.ReturnDetItemID;
				quantity = returnDetail.ReturnDetQty;
				locationID = session.GetObjectByKey<Receiving>(returnDetail.ReceiveMainID).ReceivingLocation.Oid;
				rowsAffected = Adapter.Delete(detailID, returnDetail.ts);
			}

			if (rowsAffected == 1)
			{
				ItemsBLL items = new ItemsBLL();
				items.UpdateStock(session, itemID, quantity * -1, false, locationID);
			}

			//Return true if precisely one row was deleted, otherwise return false.
			return rowsAffected == 1;

		}

		public static XPView GetReceivingReturnDetailsByItemID(int itemID)
		{

			XPView ReceivingReturnXPView = new XPView(Session.DefaultSession, typeof(ReceivingDetail));

			ReceivingReturnXPView.Properties.AddRange(new ViewProperty[]
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

			ReceivingReturnXPView.Criteria = CriteriaOperator.And(new BinaryOperator(ReceivingDetail.Fields.ReceivDetItemID.ItemType.PropertyName, "FG", BinaryOperatorType.Equal), new BinaryOperator(ReceivingDetail.Fields.ReceivDetItemID.ItemID.PropertyName, itemID, BinaryOperatorType.Equal));

			return ReceivingReturnXPView;

		}

	}


}