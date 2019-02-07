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
	public class PackingListReportBLL
	{

		private PackingListReportTableAdapter m_PackingListReportTableAdapter = null;

		public PackingListReportTableAdapter Adapter
		{
			get
			{
				if (m_PackingListReportTableAdapter == null)
				{
					m_PackingListReportTableAdapter = new PackingListReportTableAdapter();
					m_PackingListReportTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return m_PackingListReportTableAdapter;
			}
		}

		public SPGReports.PackingListReportDataTable GetPackingListreport(int ShippingID)
		{

			try
			{
				return Adapter.GetPackingList(ShippingID);
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format("There was an error while retrieving the information to print{0}{1}", Environment.NewLine, ex.Message));
				return null;
			}

		}

	}

}