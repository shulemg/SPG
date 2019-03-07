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
	public class ItemsListBLL
	{

		private ItemsListTableAdapter m_ItemsListTableAdapter = null;

		public ItemsListTableAdapter Adapter
		{
			get
			{
				if (m_ItemsListTableAdapter == null)
				{
					m_ItemsListTableAdapter = new ItemsListTableAdapter();
					m_ItemsListTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return m_ItemsListTableAdapter;
			}
		}

		public SPGReports.ItemsListDataTable GetItemsList(int? customerID, string itemType, string items, bool? inactiveItems, bool? inactiveCustomers)
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
				return Adapter.GetItemsList(customerID, itemType, inactiveCustomers, inactiveItems);
			}
			else
			{
				return Adapter.GetItemsListByItemID(customerID, itemType, inactiveCustomers, items);
			}

		}

	}

}