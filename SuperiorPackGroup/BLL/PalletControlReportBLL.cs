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
	public class PalletControlReportBLL
	{

		private PalletControlReportTableAdapter m_PalletControlReportTableAdapter = null;

		public PalletControlReportTableAdapter Adapter
		{
			get
			{
				if (this.m_PalletControlReportTableAdapter == null)
				{
					this.m_PalletControlReportTableAdapter = new PalletControlReportTableAdapter();
					this.m_PalletControlReportTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return this.m_PalletControlReportTableAdapter;
			}
		}

		public SPGReports.PalletControlReportDataTable GetPalletControlReport()
		{

			return Adapter.GetPalletControlReport();

		}

	}

}