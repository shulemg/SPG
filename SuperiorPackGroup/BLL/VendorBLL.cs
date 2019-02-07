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
	public class VendorBLL
	{

		public static bool VendorInUse(int vendorID)
		{

			try
			{
				Vendor cv = Session.DefaultSession.GetObjectByKey<Vendor>(vendorID);
				if (cv.Receivings.Count != 0)
				{
					return true;
				}
			}
			catch (Exception ex)
			{
				return false;
			}

			return false;

		}

	}

}