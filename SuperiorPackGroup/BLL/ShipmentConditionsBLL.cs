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
	public class ShipmentConditionsBLL
	{

		public static bool DeleteCondition(int conditionID)
		{

			ShipmentConditions condition = Session.DefaultSession.GetObjectByKey<ShipmentConditions>(conditionID);

			if (condition.ReceivingLoadCondition.Count + condition.ShipingLoadCondition.Count + condition.ReceivingPhysicalCondition.Count + condition.ShipingPhysicalCondition.Count > 0)
			{
				MessageBox.Show("You can't delete this condition there are other records associated to it");
			}
			else
			{
				condition.Delete();
			}

			return condition.IsDeleted;

		}

	}

}