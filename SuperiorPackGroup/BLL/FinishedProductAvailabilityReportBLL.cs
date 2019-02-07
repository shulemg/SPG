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
	public class FinishedProductAvailabilityReportBLL
	{

		private FinishedProductAvailabilityReportTableAdapter m_FinishedProductAvailabilityReportTableAdapter = null;

		public FinishedProductAvailabilityReportTableAdapter Adapter
		{
			get
			{
				if (this.m_FinishedProductAvailabilityReportTableAdapter == null)
				{
					this.m_FinishedProductAvailabilityReportTableAdapter = new FinishedProductAvailabilityReportTableAdapter();
					this.m_FinishedProductAvailabilityReportTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return this.m_FinishedProductAvailabilityReportTableAdapter;
			}
		}

		public SPGReports.FinishedProductAvailabilityReportDataTable GetFinishedProductAvailabilityReport(int? customerID, bool? inactiveItems, bool? inactiveCustomers, string items)
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
				return Adapter.GetFinishedProductAvailabilityReport(customerID, inactiveCustomers, inactiveItems);
			}
			else
			{
				return Adapter.GetFinishedProductAvailabilityByItem(customerID, inactiveCustomers, items);
			}

		}

	}

}