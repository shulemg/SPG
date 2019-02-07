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
	public class ShippingDetailsBLL
	{

		private ShippingDetailsTableAdapter m_ShippingDetailsTableAdapter = null;
		public ShippingDetailsTableAdapter Adapter
		{

			get
			{
				if (m_ShippingDetailsTableAdapter == null)
				{
					m_ShippingDetailsTableAdapter = new ShippingDetailsTableAdapter();
					m_ShippingDetailsTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return m_ShippingDetailsTableAdapter;
			}

		}

		private void UpdateAuditTrail(SPG.ShippingDetailsRow ModifiedRecord, object[] originalRecord)
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
				AuditTrailBLL.AddTrailEntry(Properties.Settings.Default.UserName, Convert.ToInt32(ModifiedRecord[0]), "ShippingDetails", builder.ToString());
			}

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.ShippingDetailsDataTable GetDetailsByShippingID(int shippingID)
		{

			return Adapter.GetDetailsByShippingID(shippingID);

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
		public bool UpdateShippingDetails(Session session, int? detailID, int shippingID, int? itemID, string lot, int? quantity, float? pallets, string note, DateTime? expirationDate, string fullLPNNumber)
		{

			if (!itemID.HasValue)
			{
				throw new ApplicationException("You must provide shipping item.");
			}

			if (!quantity.HasValue)
			{
				throw new ApplicationException("You must provide the Quantity shipped.");
			}

			SPG.ShippingDetailsDataTable details = Adapter.GetDetailsByDetailID(detailID.Value);

			if (details.Count() == 0)
			{
				//It is a new Detail
				return this.InsertDetails(session, shippingID, itemID, lot, quantity, pallets, note, expirationDate, fullLPNNumber);
			}

			SPG.ShippingDetailsRow shippingDetail = details[0];
			int originalItem = 0;
			int originalQuantity = 0;
			int newQuantity = 0;
			bool itemChanged = false;

			object[] originalRecord = shippingDetail.ItemArray;

			SPG.ShippingDetailsRow originalDetail = details.NewShippingDetailsRow();
			originalDetail.ItemArray = (object[])originalRecord.Clone();

			originalItem = shippingDetail.ShipDetItemID;
			if (itemID.HasValue && originalItem != itemID.Value)
			{
				itemChanged = true;
			}
			shippingDetail.ShipDetItemID = itemID.Value;
			if (string.IsNullOrEmpty(lot))
			{
				shippingDetail.SetShipDetLotNull();
			}
			else
			{
				shippingDetail.ShipDetLot = lot;
			}
			originalQuantity = shippingDetail.ShipDetDetQty;
			newQuantity = quantity.Value - shippingDetail.ShipDetDetQty;
			shippingDetail.ShipDetDetQty = quantity.Value;
			shippingDetail.SetsngPackagesNull();
			if (!pallets.HasValue)
			{
				shippingDetail.SetsngPalletsNull();
			}
			else
			{
				shippingDetail.sngPallets = pallets.Value;
			}
			if (string.IsNullOrEmpty(note))
			{
				shippingDetail.SetNoteNull();
			}
			else
			{
				shippingDetail.Note = note;
			}
			if (expirationDate.HasValue)
			{
				shippingDetail.ExpirationDate = expirationDate.Value;
			}
			else
			{
				shippingDetail.SetExpirationDateNull();
			}
			if (string.IsNullOrEmpty(fullLPNNumber))
			{
				shippingDetail.SetFullLPNNumberNull();
			}
			else
			{
				shippingDetail.FullLPNNumber = fullLPNNumber;
			}

			if (!(originalRecord == null))
			{
				this.UpdateAuditTrail(shippingDetail, originalRecord);
			}

			int rowsAffected = Adapter.Update(shippingDetail);

			if (rowsAffected == 1)
			{
				ItemsBLL items = new ItemsBLL();
				int locationID = session.GetObjectByKey<Shipping>(shippingID).ShippingLocation.Oid;
				//If itemChanged = True Then
				if (originalDetail.FullLPNNumber.StartsWith(CustomersBLL.GetLPNPrefix(7)))
				{
					items.UpdateStock(session, originalItem, originalQuantity, false, locationID, originalDetail.ShipDetLot, int.Parse(originalDetail.FullLPNNumber.Replace(CustomersBLL.GetLPNPrefix(7), "")));
				}
				else
				{
					items.UpdateStock(session, originalItem, originalQuantity, false, locationID);
				}
				if (fullLPNNumber.StartsWith(CustomersBLL.GetLPNPrefix(7)))
				{
					items.UpdateStock(session, itemID.Value, quantity.Value * -1, false, locationID, lot, int.Parse(fullLPNNumber.Replace(CustomersBLL.GetLPNPrefix(7), "")));
				}
				else
				{
					items.UpdateStock(session, itemID.Value, quantity.Value * -1, false, locationID);
				}
				//Else
				//    If newQuantity <> 0 Then
				//        items.UpdateStock(session, itemID.Value, newQuantity * -1, False, locationID)
				//    End If
				//End If
			}

			return rowsAffected == 1;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
		public bool InsertDetails(Session session, int shippingID, int? itemID, string lot, int? quantity, float? pallets, string note, DateTime? expirationDate, string fullLPNNumber)
		{

			SPG.ShippingDetailsDataTable details = new SPG.ShippingDetailsDataTable();
			SPG.ShippingDetailsRow shippingDetail = details.NewShippingDetailsRow();

			shippingDetail.ShipDetMainID = shippingID;
			shippingDetail.ShipDetItemID = itemID.Value;
			if (string.IsNullOrEmpty(lot))
			{
				shippingDetail.SetShipDetLotNull();
			}
			else
			{
				shippingDetail.ShipDetLot = lot;
			}
			shippingDetail.ShipDetDetQty = quantity.Value;
			shippingDetail.SetsngPackagesNull();
			if (!pallets.HasValue)
			{
				shippingDetail.SetsngPalletsNull();
			}
			else
			{
				shippingDetail.sngPallets = pallets.Value;
			}
			if (string.IsNullOrEmpty(note))
			{
				shippingDetail.SetNoteNull();
			}
			else
			{
				shippingDetail.Note = note;
			}
			if (expirationDate.HasValue)
			{
				shippingDetail.ExpirationDate = expirationDate.Value;
			}
			else
			{
				shippingDetail.SetExpirationDateNull();
			}
			if (string.IsNullOrEmpty(fullLPNNumber))
			{
				shippingDetail.SetFullLPNNumberNull();
			}
			else
			{
				shippingDetail.FullLPNNumber = fullLPNNumber;
			}

			details.AddShippingDetailsRow(shippingDetail);
			int rowsAffected = Adapter.Update(details);

			if (rowsAffected == 1)
			{
				ItemsBLL items = new ItemsBLL();
				if (fullLPNNumber.StartsWith(CustomersBLL.GetLPNPrefix(7)))
				{
					items.UpdateStock(session, itemID.Value, quantity.Value * -1, false, session.GetObjectByKey<Shipping>(shippingID).ShippingLocation.Oid, lot, int.Parse(fullLPNNumber.Replace(CustomersBLL.GetLPNPrefix(7), "")));
				}
				else
				{
					items.UpdateStock(session, itemID.Value, quantity.Value * -1, false, session.GetObjectByKey<Shipping>(shippingID).ShippingLocation.Oid);
				}
			}

			return rowsAffected == 1;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
		public bool DeleteShippingDetail(Session session, int detailID)
		{

			SPG.ShippingDetailsDataTable details = Adapter.GetDetailsByDetailID(detailID);
			int rowsAffected = 0;
			int itemID = 0;
			int quantity = 0;
			int locationID = 0;
			string lot = null;
			string fullLPNNumber = null;

			if (details.Count() == 1)
			{
				SPG.ShippingDetailsRow shippingDetail = (SPG.ShippingDetailsRow)details.Rows[0];
				itemID = shippingDetail.ShipDetItemID;
				quantity = shippingDetail.ShipDetDetQty;
				lot = shippingDetail.ShipDetLot;
				fullLPNNumber = shippingDetail.FullLPNNumber;
				locationID = session.GetObjectByKey<Shipping>(shippingDetail.ShipDetMainID).ShippingLocation.Oid;
				rowsAffected = Adapter.Delete(detailID, shippingDetail.ts);
			}

			if (rowsAffected == 1)
			{
				ItemsBLL items = new ItemsBLL();
				if (fullLPNNumber.StartsWith(CustomersBLL.GetLPNPrefix(7)))
				{
					items.UpdateStock(session, itemID, quantity, false, locationID, lot, int.Parse(fullLPNNumber.Replace(CustomersBLL.GetLPNPrefix(7), "")));
				}
				else
				{
					items.UpdateStock(session, itemID, quantity, false, locationID);
				}
			}

			//Return true if precisely one row was deleted, otherwise return false.
			return rowsAffected == 1;

		}
		public static XPView GetShippingDetailsByItemID(int itemID)
		{

			XPView ShippingXPView = new XPView(Session.DefaultSession, typeof(ShipDet));

			ShippingXPView.Properties.AddRange(new ViewProperty[]
			{
				new ViewProperty(ShipDet.Fields.ShipDetDetID.PropertyName, SortDirection.None, ShipDet.Fields.ShipDetDetID, false, true),
				new ViewProperty(ShipDet.Fields.ShipDetMainID.ShipMainID.PropertyName, SortDirection.Ascending, ShipDet.Fields.ShipDetMainID.ShipMainID, false, true),
				new ViewProperty(ShipDet.Fields.ShipDetLot.PropertyName, SortDirection.None, ShipDet.Fields.ShipDetLot, false, true),
				new ViewProperty(ShipDet.Fields.ExpirationDate.PropertyName, SortDirection.None, ShipDet.Fields.ExpirationDate, false, true),
				new ViewProperty(ShipDet.Fields.ShipDetDetQty.PropertyName, SortDirection.None, ShipDet.Fields.ShipDetDetQty, false, true),
				new ViewProperty("ShipMainBOL", SortDirection.None, ShipDet.Fields.ShipDetMainID.ShipMainBOL, false, true),
				new ViewProperty("ShipMainDate", SortDirection.None, ShipDet.Fields.ShipDetMainID.ShipMainDate, false, true)
			});

			ShippingXPView.Criteria = CriteriaOperator.And(new BinaryOperator(ShipDet.Fields.ShipDetItemID.ItemType.PropertyName, "FG", BinaryOperatorType.Equal), new BinaryOperator(ShipDet.Fields.ShipDetItemID.ItemID.PropertyName, itemID, BinaryOperatorType.Equal));
			return ShippingXPView;

		}
	}

}