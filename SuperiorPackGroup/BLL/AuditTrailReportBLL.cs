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
	public class AuditTrailReportBLL
	{

		private AuditTrailReportTableAdapter m_AuditTrailReportTableAdapter = null;

		public AuditTrailReportTableAdapter Adapter
		{
			get
			{
				if (this.m_AuditTrailReportTableAdapter == null)
				{
					this.m_AuditTrailReportTableAdapter = new AuditTrailReportTableAdapter();
					this.m_AuditTrailReportTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return this.m_AuditTrailReportTableAdapter;
			}
		}

		public SPGReports.AuditTrailReportDataTable GetAuditTrailReport(DateTime? fromDate, DateTime? toDate)
		{

			return Adapter.GetAuditTrailReport(fromDate, toDate);

		}

	}

}