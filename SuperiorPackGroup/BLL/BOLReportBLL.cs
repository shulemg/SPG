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
	public class BOLReportBLL
	{

		private BOLReportTableAdapter m_BOLReportTableAdapter = null;

		public BOLReportTableAdapter Adapter
		{
			get
			{
				if (this.m_BOLReportTableAdapter == null)
				{
					this.m_BOLReportTableAdapter = new BOLReportTableAdapter();
					this.m_BOLReportTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return this.m_BOLReportTableAdapter;
			}
		}

		public SPGReports.BOLReportDataTable Getbolreport(int ShippingID)
		{

			try
			{
				return Adapter.GetBOL(ShippingID);
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format("There was an error while retrieving the information to print{0}{1}", Environment.NewLine, ex.Message));
				return null;
			}

		}

	}

}