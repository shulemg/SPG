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
	public class PhysicalInventoryWorksheetBLL
	{

		private PhysicalInventoryWorksheetTableAdapter m_PhysicalInventoryWorksheetTableAdapter = null;

		public PhysicalInventoryWorksheetTableAdapter Adapter
		{
			get
			{
				if (this.m_PhysicalInventoryWorksheetTableAdapter == null)
				{
					this.m_PhysicalInventoryWorksheetTableAdapter = new PhysicalInventoryWorksheetTableAdapter();
					this.m_PhysicalInventoryWorksheetTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return this.m_PhysicalInventoryWorksheetTableAdapter;
			}
		}

		public SPGReports.PhysicalInventoryWorksheetDataTable GetPhysicalInventoryWorksheet(int? customerID, string itemType, string items, bool? inactiveItems, bool? inactiveCustomers)
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
				return Adapter.GetPhysicalInventoryWorksheet(customerID, itemType, inactiveCustomers, inactiveItems);
			}
			else
			{
				return Adapter.GetPhysicalInventoryWorksheetByItemID(customerID, itemType, inactiveCustomers, items);
			}

		}

	}

}