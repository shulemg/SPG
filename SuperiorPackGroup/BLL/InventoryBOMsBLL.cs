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
	public class InventoryBOMsBLL
	{

		private InventoryBOMsTableAdapter m_InventoryBOMsTableAdapter = null;
		public InventoryBOMsTableAdapter Adapter
		{

			get
			{
				if (m_InventoryBOMsTableAdapter == null)
				{
					m_InventoryBOMsTableAdapter = new InventoryBOMsTableAdapter();
					m_InventoryBOMsTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return m_InventoryBOMsTableAdapter;
			}

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.InventoryBOMsDataTable GetInventoryBOMsBYInventoryID(int inventoryID)
		{

			return Adapter.GetInventoryBOMByInventoryID(inventoryID);

		}

		public static XPCollection<InventoryBOMs> GetInventoryBOMsByInventoryID(Session session, int inventoryID)
		{

			return new XPCollection<InventoryBOMs>(session, new BinaryOperator(InventoryBOMs.Fields.InventoryBOMInventoryID.InventoryID.PropertyName, inventoryID, BinaryOperatorType.Equal));

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.InventoryBOMsDataTable GetInventoryBOMsBYID(int InventoryBOMsID)
		{

			return Adapter.GetInventoryBOMByID(InventoryBOMsID);

		}

		private static void SetInventoryBOMFields(int? InventoryBOMsRawMatID, int? InventoryBOMsInventoryID, float? InventoryBOMsQuantity, double? scrapFactor, SPG.InventoryBOMsRow inventoryBOM)
		{

			inventoryBOM.InventoryBOMRawMatID = InventoryBOMsRawMatID.Value;
			inventoryBOM.InventoryBOMInventoryID = InventoryBOMsInventoryID.Value;
			inventoryBOM.InventoryBOMQuantity = InventoryBOMsQuantity.Value;
			if (scrapFactor.HasValue)
			{
				inventoryBOM.ScrapFactor = scrapFactor.Value;
			}
			else
			{
				inventoryBOM.SetScrapFactorNull();
			}

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
		public bool UpdateInventoryBOM(int? InventoryBOMsID, int? InventoryBOMsRawMatID, int? InventoryBOMsInventoryID, float? InventoryBOMsQuantity, double? scrapFactor)
		{

			SPG.InventoryBOMsDataTable inventoryBOMs = Adapter.GetInventoryBOMByID(InventoryBOMsID.Value);

			if (!InventoryBOMsRawMatID.HasValue)
			{
				throw new ApplicationException("You must provide a RM ID.");
			}

			if (!InventoryBOMsQuantity.HasValue || InventoryBOMsQuantity.Value == 0)
			{
				throw new ApplicationException("You must provide the Quantity Used.");
			}

			if (inventoryBOMs.Count() == 0)
			{
				//It is a new Product
				return InsertInventoryBOM(InventoryBOMsRawMatID, InventoryBOMsInventoryID, InventoryBOMsQuantity, scrapFactor);
			}

			SPG.InventoryBOMsRow inventoryBOM = inventoryBOMs[0];

			object[] originalRecord = inventoryBOM.ItemArray;

			SetInventoryBOMFields(InventoryBOMsRawMatID, InventoryBOMsInventoryID, InventoryBOMsQuantity, scrapFactor, inventoryBOM);

			if (!(originalRecord == null))
			{
				UpdateAuditTrail(inventoryBOM, originalRecord);
			}

			int rowsAffected = Adapter.Update(inventoryBOM);

			return rowsAffected == 1;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
		public bool InsertInventoryBOM(int? InventoryBOMsRawMatID, int? InventoryBOMsInventoryID, float? InventoryBOMsQuantity, double? scrapFactor)
		{

			SPG.InventoryBOMsDataTable inventoryBOMs = new SPG.InventoryBOMsDataTable();
			SPG.InventoryBOMsRow inventoryBOM = inventoryBOMs.NewInventoryBOMsRow();

			SetInventoryBOMFields(InventoryBOMsRawMatID, InventoryBOMsInventoryID, InventoryBOMsQuantity, scrapFactor, inventoryBOM);

			inventoryBOMs.AddInventoryBOMsRow(inventoryBOM);
			int rowsAffected = Adapter.Update(inventoryBOMs);

			return rowsAffected == 1;

		}

		private void UpdateAuditTrail(SPG.InventoryBOMsRow ModifiedRecord, object[] originalRecord)
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
				AuditTrailBLL.AddTrailEntry(Properties.Settings.Default.UserName, Convert.ToInt32(ModifiedRecord[0]), "InventoryBOM", builder.ToString());
			}

		}

		public bool AddInventoryBOMByItemID(int itemID, int inventoryID)
		{

			return Convert.ToBoolean(Adapter.AddInventoryBOMByItemID(itemID, inventoryID));

		}

		public static void AddInventoryBOMByItemID(Session session, int itemID, Inventory inventoryID)
		{

			InventoryBOMs inventoryBom = null;
			using (XPCollection<BOMs> itemBom = new XPCollection<BOMs>(session, new BinaryOperator(BOMs.Fields.BOMFiniGoodID.ItemID.PropertyName, itemID, BinaryOperatorType.Equal)))
			{
				foreach (BOMs bomItem in itemBom)
				{
					inventoryBom = new InventoryBOMs(session)
					{
						InventoryBOMRawMatID = bomItem.BOMRawMatID,
						InventoryBOMInventoryID = inventoryID,
						InventoryBOMQuantity = bomItem.BOMQuantity,
						ScrapFactor = bomItem.ScrapFactor / 100
					};
					inventoryBom.Save();
				}
			}

		}

		public bool DeleteInventoryBOMByInventoryID(int inventoryID)
		{

			return Convert.ToBoolean(Adapter.DeleteInventoryBOMByInventoryID(inventoryID));

		}

		public static void DeleteInventoryBOMByInventoryID(Session session, int inventoryID)
		{

			session.Delete(new XPCollection<InventoryBOMs>(session, new BinaryOperator(InventoryBOMs.Fields.InventoryBOMInventoryID.InventoryID.PropertyName, inventoryID, BinaryOperatorType.Equal)));

		}

	}

}