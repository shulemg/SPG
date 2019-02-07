//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using DevExpress.Data.Filtering;
using DXDAL.SPGData;
using DevExpress.Xpo;
using System.Text;

namespace SuperiorPackGroup
{
	public class PoolBomBLL
	{

		public static bool PoolUsedAsBom(int poolID)
		{

			using (XPCollection<PoolBom> lXPCollection = new XPCollection<PoolBom>(Session.DefaultSession, new BinaryOperator(PoolBom.Fields.ItemPoolID.PropertyName, poolID, BinaryOperatorType.Equal)))
			{
				return lXPCollection.Count > 0;
			}

		}

	}

}