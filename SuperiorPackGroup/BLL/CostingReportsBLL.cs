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
	public class CostingReportsBLL
	{

		private CostingReportsTableAdapter m_CostingReportsTableAdapter = null;

		public CostingReportsTableAdapter Adapter
		{
			get
			{
				if (this.m_CostingReportsTableAdapter == null)
				{
					this.m_CostingReportsTableAdapter = new CostingReportsTableAdapter();
					this.m_CostingReportsTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return this.m_CostingReportsTableAdapter;
			}
		}

		public SPGReports.CostingReportsDataTable GetCostingReport(DateTime? fromDate, DateTime? toDate, int? customer, int? shift, int? machine, string items, bool? inactiveItems, bool? inactiveCustomers)
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
				return Adapter.GetCostingReports(fromDate, toDate, shift, machine, customer, inactiveCustomers, inactiveItems);
			}

			return Adapter.GetCostingReportsByItems(fromDate, toDate, shift, machine, customer, inactiveCustomers, items);

		}

	}

}