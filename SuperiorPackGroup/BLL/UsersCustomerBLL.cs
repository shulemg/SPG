//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using DXDAL.SPGData;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace SuperiorPackGroup
{
	public class UsersCustomerBLL
	{

		public static List<Customers> GetAssignedCustomers(Session session)
		{

			List<Customers> assignedCustomers = new List<Customers>();

			foreach (UsersCustomer assignedCustomer in new XPCollection<UsersCustomer>(session, CriteriaOperator.Parse(string.Format("User.strUserName = '{0}'", Properties.Settings.Default.UserName))))
			{
				assignedCustomers.Add(assignedCustomer.Customer);
			}

			return assignedCustomers;

		}

		public static List<int> GetAssignedCustomerIDs(Session session)
		{

			List<int> assignedCustomers = new List<int>();

			foreach (UsersCustomer assignedCustomer in new XPCollection<UsersCustomer>(session, CriteriaOperator.Parse(string.Format("User.strUserName = '{0}'", Properties.Settings.Default.UserName))))
			{
				assignedCustomers.Add(assignedCustomer.Customer.CustomerID);
			}

			return assignedCustomers;

		}

	}

}