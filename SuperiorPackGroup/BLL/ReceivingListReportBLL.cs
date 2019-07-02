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
	public class ReceivingListReportBLL
	{

		private ReceivingListReportTableAdapter m_ReceivingListReportTableAdapter = null;

		public ReceivingListReportTableAdapter Adapter
		{
			get
			{
				if (m_ReceivingListReportTableAdapter == null)
				{
					m_ReceivingListReportTableAdapter = new ReceivingListReportTableAdapter();
					m_ReceivingListReportTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return m_ReceivingListReportTableAdapter;
			}
		}

		public SPGReports.ReceivingListReportDataTable GetReceivingListreport(int ReceivingID)
		{

			try
			{
                return Adapter.GetReceivingList(ReceivingID);
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format("There was an error while retrieving the information to print{0}{1}", Environment.NewLine, ex.Message));
				return null;
			}

		}

	}

}