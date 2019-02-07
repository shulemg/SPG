//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using System.Text;
using DXDAL.SPGData;
using DevExpress.Xpo;

namespace SuperiorPackGroup
{
	public class ItemPoolBLL
	{

		public static bool ValidateRecord(string poolCode, int? customerID)
		{

			if (string.IsNullOrEmpty(poolCode))
			{
				return false;
			}
			if (!customerID.HasValue)
			{
				return false;
			}

			return true;

		}

		public static bool DeleteItemPool(int poolID)
		{

			ItemPool pool = Session.DefaultSession.GetObjectByKey<ItemPool>(poolID);

			if (PoolBomBLL.PoolUsedAsBom(poolID))
			{
				MessageBox.Show("You can't delete this item pool there are BOM records associated to it");
			}
			else
			{
				pool.Delete();
			}

			return pool.IsDeleted;

		}

	}

}