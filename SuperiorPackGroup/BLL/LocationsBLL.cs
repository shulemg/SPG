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
	public class LocationsBLL
	{

		public static bool DeleteLocation(int locationID, Session session)
		{

			Locations location = session.GetObjectByKey<Locations>(locationID);

			if (location.LocationTransfersFrom.Count > 0 || location.LocationTransfersTo.Count > 0 || location.LocationReceivings.Count > 0 || location.LocationsInventory.Count > 0 || location.LocationShippings.Count > 0 || location.LocationProduction.Count > 0 || IsDefaultLocation(location))
			{
				MessageBox.Show("You can't delete this location there are records associated to it");
			}
			else
			{
				location.Delete();
			}

			return location.IsDeleted;

		}

		public static bool IsDefaultLocation(Locations location)
		{

			if (CompanySettingsBLL.GetDefaultLocation() != null)
			{
				return location.Oid == CompanySettingsBLL.GetDefaultLocation().Oid;
			}

			return false;


		}

		public static bool ValidateRecord(string locationCode)
		{

			if (string.IsNullOrEmpty(locationCode))
			{
				return false;
			}

			return true;

		}

	}

}