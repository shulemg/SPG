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
	public class PalletTicketBLL
	{

		private PalletTicketTableAdapter m_PalletTicketTableAdapter = null;

		public PalletTicketTableAdapter Adapter
		{
			get
			{
				if (this.m_PalletTicketTableAdapter == null)
				{
					this.m_PalletTicketTableAdapter = new PalletTicketTableAdapter();
					this.m_PalletTicketTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return this.m_PalletTicketTableAdapter;
			}
		}

		public SPGReports.PalletTicketDataTable GetPalletTicket(int ItemID)
		{

			return Adapter.GetPalletTicket(ItemID);

		}

	}

}