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
				if (m_ReportsTableAdapter == null)
				{
					m_ReportsTableAdapter = new ReportsTableAdapter();
					m_ReportsTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return m_ReportsTableAdapter;
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