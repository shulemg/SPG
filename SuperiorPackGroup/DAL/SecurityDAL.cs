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
	public partial class SecurityDAL
	{

		private SecurityTableAdapter m_SecurityTableAdapter;
		public SecurityTableAdapter Adapter
		{

			get
			{
				if (m_SecurityTableAdapter == null)
				{
					m_SecurityTableAdapter = new SecurityTableAdapter();
					m_SecurityTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return m_SecurityTableAdapter;
			}

		}

		public DataTableReader GetSecuritySettingsByUserName(string userName)
		{

			return Adapter.GetSecuritySettingsByUserName(userName).CreateDataReader();

		}

	}

}