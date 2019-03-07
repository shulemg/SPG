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
using System.Linq;

namespace SuperiorPackGroup
{
	[System.ComponentModel.DataObject()]
	public class ProductionBLL
	{

		private ProductionTableAdapter m_ProductionTableAdapter = null;
		public ProductionTableAdapter Adapter
		{

			get
			{
				if (m_ProductionTableAdapter == null)
				{
					m_ProductionTableAdapter = new ProductionTableAdapter();
					m_ProductionTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return m_ProductionTableAdapter;
			}

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.ProductionDataTable GetProductionByCustomerID(int customerID)
		{

			return Adapter.GetProductionByCustomerID(customerID);

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.ProductionDataTable GetProductionByMachine(int machineID)
		{

			return Adapter.GetProductionByMachine(machineID);

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.ProductionDataTable GetProductionByItemID(int itemID)
		{

			return Adapter.GetProductionByItemID(itemID);

		}

		private void UpdateAuditTrail(SPG.ProductionRow ModifiedRecord, object[] originalRecord)
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
				AuditTrailBLL.AddTrailEntry(Properties.Settings.Default.UserName, Convert.ToInt32(ModifiedRecord[0]), "Production", builder.ToString());
			}

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
		public bool UpdateProduction(int productionID, DateTime? productionDate, int? shift, int? item, float? quantity, int? machine, DateTime? startTime, DateTime? stopTime, float? packers)
		{

			SPG.ProductionDataTable production = Adapter.GetProductionByID(productionID);

			if (production.Count() == 0)
			{
				//It is a new Production Record
				return this.InsertProduction(productionID, productionDate, shift, item, quantity, machine, startTime, stopTime, packers);
			}

			SPG.ProductionRow productionRecord = production[0];

			object[] originalRecord = productionRecord.ItemArray;

			productionRecord.ProdMainDate = Convert.ToDateTime(productionDate);
			productionRecord.ProdMainShift = shift.Value;
			productionRecord.ProdMainItemID = item.Value;
			productionRecord.ProdMainQuantity = quantity.Value;
			productionRecord.ProdMainMachineLine = machine.Value;
			productionRecord.ProdMainTimeStart = startTime.Value;
			productionRecord.ProdMainTimeStop = stopTime.Value;
			if (!packers.HasValue)
			{
				productionRecord.ProdMainPackers = 0;
			}
			else
			{
				productionRecord.ProdMainPackers = packers.Value;
			}

			if (!(originalRecord == null))
			{
				this.UpdateAuditTrail(productionRecord, originalRecord);
			}

			int rowsAffected = Adapter.Update(productionRecord);

			return rowsAffected == 1;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
		public bool InsertProduction(int productionID, DateTime? productiondate, int? shift, int? item, float? quantity, int? machine, DateTime? startTime, DateTime? stopTime, float? packers)
		{

			SPG.ProductionDataTable production = new SPG.ProductionDataTable();
			SPG.ProductionRow productionRecord = production.NewProductionRow();

			productionRecord.ProdMainID = productionID;
			productionRecord.ProdMainDate = Convert.ToDateTime(productiondate);
			productionRecord.ProdMainShift = shift.Value;
			productionRecord.ProdMainItemID = item.Value;
			productionRecord.ProdMainQuantity = quantity.Value;
			productionRecord.ProdMainMachineLine = machine.Value;
			productionRecord.ProdMainTimeStart = startTime.Value;
			productionRecord.ProdMainTimeStop = stopTime.Value;
			if (!packers.HasValue)
			{
				productionRecord.ProdMainPackers = 0;
			}
			else
			{
				productionRecord.ProdMainPackers = packers.Value;
			}
			productionRecord.strEnteredBy = Properties.Settings.Default.UserName;
			productionRecord.dtmEnteredOn = DateTime.Now;

			production.AddProductionRow(productionRecord);
			int rowsAffected = Adapter.Update(production);

			return rowsAffected == 1;

		}

		public int GetNewProductionID()
		{

			System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection(Properties.Settings.Default.UserConnectionString);
			System.Data.SqlClient.SqlCommand myCommand = new System.Data.SqlClient.SqlCommand("dbo.spNewIDSafe", conn);
			System.Data.SqlClient.SqlParameter myNewID = new System.Data.SqlClient.SqlParameter("@nRetVal", SqlDbType.Int);
			myCommand.CommandType = CommandType.StoredProcedure;
			myNewID.Direction = ParameterDirection.Output;
			myCommand.Parameters.AddWithValue("@cName", "tblProdMain");
			myCommand.Parameters.AddWithValue("@cPkField", "ProdMainID");
			myCommand.Parameters.Add(myNewID);

			conn.Open();
			myCommand.ExecuteNonQuery();

			return Convert.ToInt32(myNewID.Value);

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.ProductionDataTable GetProductionView(DateTime? fromDate, DateTime? toDate, int? customer, int? shift, int? machine, int? item)
		{

			return Adapter.GetProductionView(fromDate, toDate, customer, shift, machine, item);

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.ProductionDataTable GetProductionByShift(int? shift)
		{

			return Adapter.GetProductionView(null, null, null, shift, null, null);

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.ProductionDataTable GetProductionReport(DateTime? fromDate, DateTime? toDate, int? customer, int? shift, int? machine, string items, bool? inactiveItems, bool? inactiveCustomers)
		{

			if (inactiveCustomers.Value == true)
			{
				inactiveCustomers = null;
			}

			if (inactiveItems.Value == true)
			{
				inactiveItems = null;
			}

			if (string.IsNullOrEmpty(items))
			{
				return Adapter.GetProductionReport(fromDate, toDate, customer, shift, machine, inactiveItems, inactiveCustomers);
			}

			return Adapter.GetProductionReportByItems(fromDate, toDate, customer, shift, machine, inactiveCustomers, items);

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
		public bool DeleteProduction(int id, Session mySession)
		{

            Production production = mySession.GetObjectByKey<Production>(id);

			if (production != null)
			{
				production.Delete();
			}

			return true;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.ProductionDataTable GetProductionByID(int productionID)
		{

			return Adapter.GetProductionByID(productionID);

		}

	}

}