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
	public class ShiftsBLL
	{

		private ShiftsTableAdapter m_ShiftsTableAdapter = null;
		public ShiftsTableAdapter Adapter
		{

			get
			{
				if (m_ShiftsTableAdapter == null)
				{
					m_ShiftsTableAdapter = new ShiftsTableAdapter();
					m_ShiftsTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return m_ShiftsTableAdapter;
			}

		}

		private void UpdateAuditTrail(SPG.ShiftsRow ModifiedRecord, object[] originalRecord)
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
				AuditTrailBLL.AddTrailEntry(Properties.Settings.Default.UserName, Convert.ToInt32(ModifiedRecord[0]), "Shifts", builder.ToString());
			}

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
		public SPG.ShiftsDataTable GetShifts()
		{

			return Adapter.GetShifts();

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
		public bool UpdateShift(int? id, string name)
		{

			SPG.ShiftsDataTable shifts = Adapter.GetShiftByID(id.Value);

			if (shifts.Count() == 0)
			{
				//It is a new Product
				return this.InsertShift(name);
			}

			SPG.ShiftsRow shift = shifts[0];

			if (string.IsNullOrEmpty(name))
			{
				throw new ApplicationException("You must provide a Shift Name.");
			}

			object[] originalRecord = shift.ItemArray;

			shift.ShiftName = name;

			if (!(originalRecord == null))
			{
				this.UpdateAuditTrail(shift, originalRecord);
			}

			int rowsAffected = Adapter.Update(shift);

			return rowsAffected == 1;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
		public bool InsertShift(string name)
		{

			SPG.ShiftsDataTable shifts = new SPG.ShiftsDataTable();
			SPG.ShiftsRow shift = shifts.NewShiftsRow();

			if (string.IsNullOrEmpty(name))
			{
				throw new ApplicationException("You must provide a Shift Name.");
			}

			shift.ShiftName = name;

			shifts.AddShiftsRow(shift);
			int rowsAffected = Adapter.Update(shifts);

			return rowsAffected == 1;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
		public bool DeleteShift(int id)
		{

			SPG.ShiftsDataTable shifts = Adapter.GetShiftByID(id);
			int rowsAffected = 0;

			if (shifts.Count() == 1)
			{
				SPG.ShiftsRow shift = (SPG.ShiftsRow)shifts.Rows[0];
				if ((new ProductionBLL()).GetProductionByShift(id).Count != 0)
				{
					MessageBox.Show("You can't delete this shift there are other records associated to it");
					return true;
				}
				rowsAffected = Adapter.Delete(id, shift.ts);
			}

			//Return true if precisely one row was deleted, otherwise return false.
			return rowsAffected == 1;

		}

		public static Shifts GetShiftByID(int shiftID)
		{

			return XpoDefault.Session.GetObjectByKey<Shifts>(shiftID);

		}

	}

}