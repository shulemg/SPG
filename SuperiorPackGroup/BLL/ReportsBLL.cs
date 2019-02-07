//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using SuperiorPackGroup.SPGTableAdapters;

namespace SuperiorPackGroup
{
	public class ReportsBLL
	{

		private ReportsTableAdapter m_ReportsTableAdapter = null;

		public ReportsTableAdapter Adapter
		{
			get
			{
				if (this.m_ReportsTableAdapter == null)
				{
					this.m_ReportsTableAdapter = new ReportsTableAdapter();
					this.m_ReportsTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return this.m_ReportsTableAdapter;
			}
		}

		public SPG.ReportsDataTable GetReports()
		{

			return Adapter.GetReports();

		}

		public SPG.ReportsDataTable GetReportsByModule(string ModuleName)
		{

			return Adapter.GetReportsByModule(ModuleName);

		}

	}

}