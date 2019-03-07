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
	public class BOMBLL
	{

		private BOMTableAdapter m_BOMTableAdapter = null;
		public BOMTableAdapter Adapter
		{

			get
			{
				if (m_BOMTableAdapter == null)
				{
					m_BOMTableAdapter = new BOMTableAdapter();
					m_BOMTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return m_BOMTableAdapter;
			}

		}

		private void UpdateAuditTrail(SPG.BOMRow ModifiedRecord, object[] originalRecord)
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
				AuditTrailBLL.AddTrailEntry(Properties.Settings.Default.UserName, Convert.ToInt32(ModifiedRecord[0]), "BOM", builder.ToString());
			}

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.BOMDataTable GetBOMBYFGItemID(int itemID)
		{

			return Adapter.GetBOMByFGItemID(itemID);

		}

		public static XPCollection<BOMs> GetBOMByFGItemID(Session session, int itemID)
		{

			return new XPCollection<BOMs>(session, new BinaryOperator(BOMs.Fields.BOMFiniGoodID.ItemID.PropertyName, itemID, BinaryOperatorType.Equal));

		}

		public string GetBOMBYFGItemIDString(int itemID)
		{

			StringBuilder itemBoms = new StringBuilder(string.Empty);

			foreach (SPG.BOMRow item in Adapter.GetBOMByFGItemID(itemID))
			{
				itemBoms.Append(string.Format("{0}; ", item.BOMRawMatCode));
			}
			if (itemBoms.Length > 2)
			{
				itemBoms.Length -= 2;
			}

			return itemBoms.ToString();

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.BOMDataTable GetBOMBYBomID(int bomID)
		{

			return Adapter.GetBomByBomID(bomID);

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
		public bool UpdateBOM(int? bomID, int? bomRawMatID, int? bomFiniGoodID, float? bomQuantity, double? scrapFactor)
		{

			SPG.BOMDataTable boms = Adapter.GetBomByBomID(bomID.Value);

			StringBuilder str = new StringBuilder(string.Empty);

			if (bomRawMatID.HasValue == false)
			{
				str.Append("a RM ID, ");
			}

			if (bomQuantity.HasValue == false || bomQuantity.Value == 0)
			{
				str.Append("the Quantity Needed, ");
			}

			if (str.Length > 0)
			{
				throw new ApplicationException(string.Format("You must provide {0}.", str.ToString().Substring(0, str.Length - 2)));
			}

			if (boms.Count() == 0)
			{
				//It is a new Product
				return InsertBOM(bomRawMatID, bomFiniGoodID, bomQuantity, scrapFactor);
			}

			SPG.BOMRow bom = boms[0];

			object[] originalRecord = bom.ItemArray;

			bom.BOMRawMatID = bomRawMatID.Value;
			bom.BOMFiniGoodID = bomFiniGoodID.Value;
			bom.BOMQuantity = bomQuantity.Value;
			if (scrapFactor.HasValue)
			{
				bom.ScrapFactor = scrapFactor.Value;
			}
			else
			{
				bom.SetScrapFactorNull();
			}

			if (!(originalRecord == null))
			{
				UpdateAuditTrail(bom, originalRecord);
			}

			int rowsAffected = Adapter.Update(bom);

			return rowsAffected == 1;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
		public bool InsertBOM(int? bomRawMatID, int? bomFiniGoodID, float? bomQuantity, double? scrapFactor)
		{

			SPG.BOMDataTable boms = new SPG.BOMDataTable();
			SPG.BOMRow bom = boms.NewBOMRow();

			bom.BOMRawMatID = bomRawMatID.Value;
			bom.BOMFiniGoodID = bomFiniGoodID.Value;
			bom.BOMQuantity = bomQuantity.Value;
			if (scrapFactor.HasValue)
			{
				bom.ScrapFactor = scrapFactor.Value;
			}
			else
			{
				bom.SetScrapFactorNull();
			}

			boms.AddBOMRow(bom);
			int rowsAffected = Adapter.Update(boms);

			return rowsAffected == 1;

		}

		public bool DeleteBOMByFGItemID(int FGItemID)
		{

			SPG.BOMDataTable boms = Adapter.GetBOMByFGItemID(FGItemID);
			int rowsAffected = 0;

			if (boms.Count() > 0)
			{
				rowsAffected = Adapter.DeleteBOMByFGItemID(FGItemID);
			}
			else
			{
				rowsAffected = 0;
			}

			return Convert.ToBoolean(rowsAffected);

		}

		public bool DeleteBOM(int BOMID)
		{

			SPG.BOMRow bom = Adapter.GetBomByBomID(BOMID)[0];
			if (bom != null)
			{
				return Adapter.Delete(BOMID, bom.ts) == 1;
			}

			return false;

		}

	}

}