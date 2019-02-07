//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using DevExpress.Xpo;
using DXDAL.SPGData;
using System.ComponentModel;
using System.Linq;

namespace SuperiorPackGroup
{
	public class ProjectsBLL
	{

		public static BindingList<ChangeObject> GetProjectDetailChanges(Session session, int recordID)
		{

			List<ChangeObject> result = new List<ChangeObject>();

			foreach (ProjectDetails detail in session.GetObjectByKey<Project>(recordID).ProjectDetails)
			{
				result.AddRange(AuditTrailBLL.GetChanges(session, "ProjectDetails", detail.Oid, true).ToList());
			}

			return new BindingList<ChangeObject>(result);

		}

		public static bool ValidateRecord(string ProjectName, int? CustomerID, DateTime? ReqStartDate, DateTime? ReqDeliveryDate, DateTime? ReqShipDate)
		{

			if (ReqDeliveryDate.HasValue && ReqDeliveryDate.Value == Convert.ToDateTime("12:00:00 AM"))
			{
				ReqDeliveryDate = null;
			}

			if (ReqShipDate.HasValue && ReqShipDate.Value == Convert.ToDateTime("12:00:00 AM"))
			{
				ReqShipDate = null;
			}

			if (string.IsNullOrEmpty(ProjectName) || CustomerID.HasValue == false || (ReqDeliveryDate.HasValue == false && ReqShipDate.HasValue == false))
			{
				return false;
			}

			if (ReqStartDate.HasValue && ((ReqShipDate.HasValue && ReqStartDate.Value > ReqShipDate.Value) || (ReqDeliveryDate.HasValue && ReqStartDate.Value.Date > ReqDeliveryDate.Value.Date)))
			{
				return false;
			}

			return true;

		}



	}

}