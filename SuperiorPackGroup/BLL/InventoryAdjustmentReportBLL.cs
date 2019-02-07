//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using SuperiorPackGroup.SPGReportsTableAdapters;

namespace SuperiorPackGroup
{
	public class InventoryAdjustmentReportBLL
	{

		private InventoryAdjustmentReportTableAdapter m_InventoryAdjustmentReportTableAdapter = null;

		public InventoryAdjustmentReportTableAdapter Adapter
		{
			get
			{
				if (this.m_InventoryAdjustmentReportTableAdapter == null)
				{
					this.m_InventoryAdjustmentReportTableAdapter = new InventoryAdjustmentReportTableAdapter();
					this.m_InventoryAdjustmentReportTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return this.m_InventoryAdjustmentReportTableAdapter;
			}
		}

		public SPGReports.InventoryAdjustmentReportDataTable GetInventoryAdjustmentReport(DateTime? fromDate, DateTime? toDate, int? customerID, string items, bool? inactiveItems, bool? inactiveCustomers)
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
				return Adapter.GetInventoryAdjustmentReport(fromDate, toDate, customerID, inactiveCustomers, inactiveItems);
			}
			else
			{
				return Adapter.GetInventoryAdjustmentReportByItemID(fromDate, toDate, customerID, inactiveCustomers, items);
			}

		}

	}

}