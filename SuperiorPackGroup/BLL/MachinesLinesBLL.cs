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
	public class MachinesLinesBLL
	{

		private MachineLinesTableAdapter m_MachineLinesTableAdapter = null;
		public MachineLinesTableAdapter Adapter
		{

			get
			{
				if (m_MachineLinesTableAdapter == null)
				{
					m_MachineLinesTableAdapter = new MachineLinesTableAdapter();
					m_MachineLinesTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return m_MachineLinesTableAdapter;
			}

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
		public SPG.MachineLinesDataTable GetMachineLines()
		{

			return Adapter.GetMachineLines();

		}

		private void UpdateAuditTrail(SPG.MachineLinesRow ModifiedRecord, object[] originalRecord)
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
				AuditTrailBLL.AddTrailEntry(Properties.Settings.Default.UserName, Convert.ToInt32(ModifiedRecord[0]), "MachineLines", builder.ToString());
			}

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
		public bool UpdateMachineLine(int? id, string name)
		{

			SPG.MachineLinesDataTable machineLines = Adapter.GetMachineLineByID(id.Value);

			if (machineLines.Count() == 0)
			{
				//It is a new Product
				return InsertMachineLine(name);
			}

			SPG.MachineLinesRow machineLine = machineLines[0];

			if (string.IsNullOrEmpty(name))
			{
				throw new ApplicationException("You must provide Machine Line Name.");
			}

			object[] originalRecord = machineLine.ItemArray;

			machineLine.MachineLineName = name;

			if (!(originalRecord == null))
			{
				UpdateAuditTrail(machineLine, originalRecord);
			}

			int rowsAffected = Adapter.Update(machineLine);

			return rowsAffected == 1;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
		public bool InsertMachineLine(string name)
		{

			SPG.MachineLinesDataTable machineLines = new SPG.MachineLinesDataTable();
			SPG.MachineLinesRow machineLine = machineLines.NewMachineLinesRow();

			if (string.IsNullOrEmpty(name))
			{
				throw new ApplicationException("You must provide Machine Line Name.");
			}

			machineLine.MachineLineName = name;

			machineLines.AddMachineLinesRow(machineLine);
			int rowsAffected = Adapter.Update(machineLines);

			return rowsAffected == 1;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
		public bool DeleteMachineLine(int id)
		{

			SPG.MachineLinesDataTable machineLines = Adapter.GetMachineLineByID(id);
			int rowsAffected = 0;

			if (machineLines.Count() == 1)
			{
				SPG.MachineLinesRow machineLine = (SPG.MachineLinesRow)machineLines.Rows[0];
				if ((new ProductionBLL()).GetProductionByMachine(id).Count != 0)
				{
					MessageBox.Show("You can't delete this machineLine there are other records associated to it");
					return true;
				}
				rowsAffected = Adapter.Delete(id, machineLine.ts);
			}

			//Return true if precisely one row was deleted, otherwise return false.
			return rowsAffected == 1;

		}

	}

}