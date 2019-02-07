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

namespace SuperiorPackGroup
{
	public class EmployeesBLL
	{

		public static bool DeleteEmployee(int employeeID)
		{

			Employees employee = Session.DefaultSession.GetObjectByKey<Employees>(employeeID);

			if (employee.CheckedReceiving.Count > 0 || employee.CheckedShipping.Count > 0 || employee.Loaded.Count > 0 || employee.Unloaded.Count > 0 || employee.CheckedTransfer.Count > 0 || employee.LoadedTransfer.Count > 0 || employee.UnloadedTransfer.Count > 0)
			{
				MessageBox.Show("You can't delete this employee there are other records associated to it");
			}
			else
			{
				employee.Delete();
			}

			return employee.IsDeleted;

		}

	}

}