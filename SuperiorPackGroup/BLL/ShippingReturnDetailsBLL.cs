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
	public class ShippingReturnDetailsBLL
	{

		private ShippingReturnDetailsTableAdapter m_ShippingReturnDetailsTableAdapter = null;
		public ShippingReturnDetailsTableAdapter Adapter
		{

			get
			{
				if (m_ShippingReturnDetailsTableAdapter == null)
				{
					m_ShippingReturnDetailsTableAdapter = new ShippingReturnDetailsTableAdapter();
					m_ShippingReturnDetailsTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return m_ShippingReturnDetailsTableAdapter;
			}

		}

		private void UpdateAuditTrail(SPG.ShippingReturnDetailsRow ModifiedRecord, object[] originalRecord)
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
				AuditTrailBLL.AddTrailEntry(Properties.Settings.Default.UserName, Convert.ToInt32(ModifiedRecord[0]), "ShippingReturnDetails", builder.ToString());
			}

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.ShippingReturnDetailsDataTable GetShippingReturnDetailsByItemID(int itemID)
		{

			return Adapter.GetShippingReturnDetailsByItemID(itemID);

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.ShippingReturnDetailsDataTable GetShippingReturnDetailsByShippingID(int shippingID)
		{

			return Adapter.GetShippingReturnDetailsByShippingID(shippingID);

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
		public bool UpdateShippingReturnDetails(Session session, int? detailID, int receivingID, int? itemID, string lot, int? quantity, int? units, float? pallets, string reason, DateTime? expirationDate)
		{

			if (!itemID.HasValue)
			{
				throw new ApplicationException("You must provide return item.");
			}

			if (!quantity.HasValue || !units.HasValue)
			{
				throw new ApplicationException("You must provide the Quantity\\Units returned.");
			}

			SPG.ShippingReturnDetailsDataTable details = Adapter.GetShippingReturnDetailByID(detailID.Value);

			if (details.Count() == 0)
			{
				//It is a new Detail
				return InsertDetails(session, receivingID, itemID, lot, quantity, units, pallets, reason, expirationDate);
			}

			SPG.ShippingReturnDetailsRow returnDetail = details[0];
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
			returnDetail.ReturnDetQty = quantity.Value;
			originalQuantity = returnDetail.intUnits;
			newQuantity = returnDetail.intUnits - units.Value;
			returnDetail.intUnits = units.Value;
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
				int locationID = session.GetObjectByKey<Shipping>(receivingID).ShippingLocation.Oid;
				if (itemChanged == true)
				{
					items.UpdateStock(session, originalItem, originalQuantity, false, locationID);
					items.UpdateStock(session, itemID.Value, units.Value * -1, false, locationID);
				}
				else
				{
					if (newQuantity != 0)
					{
						items.UpdateStock(session, itemID.Value, newQuantity, false, locationID);
					}
				}
			}

			return rowsAffected == 1;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
		public bool InsertDetails(Session session, int shippingID, int? itemID, string lot, int? quantity, int? units, float? pallets, string reason, DateTime? expirationDate)
		{

			SPG.ShippingReturnDetailsDataTable details = new SPG.ShippingReturnDetailsDataTable();
			SPG.ShippingReturnDetailsRow returnDetail = details.NewShippingReturnDetailsRow();

			returnDetail.ShipMainID = shippingID;
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
			returnDetail.intUnits = units.Value;
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

			details.AddShippingReturnDetailsRow(returnDetail);
			int rowsAffected = Adapter.Update(details);

			if (rowsAffected == 1)
			{
				ItemsBLL items = new ItemsBLL();
				items.UpdateStock(session, itemID.Value, units.Value * -1, false, session.GetObjectByKey<Shipping>(shippingID).ShippingLocation.Oid);
			}

			return rowsAffected == 1;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
		public bool DeleteReturnDetail(Session session, int detailID)
		{

			SPG.ShippingReturnDetailsDataTable details = Adapter.GetShippingReturnDetailByID(detailID);
			int rowsAffected = 0;
			int itemID = 0;
			int quantity = 0;
			int locationID = 0;

			if (details.Count() == 1)
			{
				SPG.ShippingReturnDetailsRow returnDetail = (SPG.ShippingReturnDetailsRow)details.Rows[0];
				itemID = returnDetail.ReturnDetItemID;
				quantity = returnDetail.intUnits;
				locationID = session.GetObjectByKey<Shipping>(returnDetail.ShipMainID).ShippingLocation.Oid;
				rowsAffected = Adapter.Delete(detailID, returnDetail.ts);
			}

			if (rowsAffected == 1)
			{
				ItemsBLL items = new ItemsBLL();
				items.UpdateStock(session, itemID, quantity, false, locationID);
			}

			//Return true if precisely one row was deleted, otherwise return false.
			return rowsAffected == 1;

		}

		public static XPView GetShippingReturnDetailsViewByItemID(int itemID)
		{

			XPView ShippingReturnXPView = new XPView(Session.DefaultSession, typeof(ShipDet));

			ShippingReturnXPView.Properties.AddRange(new ViewProperty[]
			{
				new ViewProperty("ReturnDetID", SortDirection.None, ShipDet.Fields.ShipDetDetID, false, true),
				new ViewProperty("ShipMainID", SortDirection.Ascending, ShipDet.Fields.ShipDetMainID.ShipMainID, false, true),
				new ViewProperty("ReturnDetLot", SortDirection.None, ShipDet.Fields.ShipDetLot, false, true),
				new ViewProperty("ExpirationDate", SortDirection.None, ShipDet.Fields.ExpirationDate, false, true),
				new ViewProperty("intUnits", SortDirection.None, ShipDet.Fields.ShipDetDetQty, false, true),
				new ViewProperty("ShipMainBOL", SortDirection.None, ShipDet.Fields.ShipDetMainID.ShipMainBOL, false, true),
				new ViewProperty("ShipMainDate", SortDirection.None, ShipDet.Fields.ShipDetMainID.ShipMainDate, false, true)
			});

			ShippingReturnXPView.Criteria = CriteriaOperator.And(new BinaryOperator(ShipDet.Fields.ShipDetItemID.ItemType.PropertyName, "FG", BinaryOperatorType.NotEqual), new BinaryOperator(ShipDet.Fields.ShipDetItemID.ItemID.PropertyName, itemID, BinaryOperatorType.Equal));

			return ShippingReturnXPView;

		}

	}

}