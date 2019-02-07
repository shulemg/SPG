//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using DXDAL.SPGData;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;

namespace SuperiorPackGroup
{
	public class BomConsumptionBLL
	{

		public static float UpdateBomConsumption(Session mySession, Items rawMatID, Inventory inventoryID, float quantityUsed, float scrapFactorUsed)
		{

			BomConsumption bom = null;
			float originalQuantity = 0;
			float originalScrap = 0;
			CriteriaOperatorCollection consumptionCriteria = new CriteriaOperatorCollection();

			consumptionCriteria.Add(new BinaryOperator(BomConsumption.Fields.RawMatID.ItemID.PropertyName, rawMatID.ItemID, BinaryOperatorType.Equal));
			consumptionCriteria.Add(new BinaryOperator(BomConsumption.Fields.InventoryID.InventoryID.PropertyName, inventoryID.InventoryID, BinaryOperatorType.Equal));

			bom = mySession.GetObjectByKey<BomConsumption>(mySession.Evaluate<BomConsumption>(CriteriaOperator.Parse("Oid"), new GroupOperator(GroupOperatorType.And, consumptionCriteria)));

			if (bom == null)
			{
				bom = new BomConsumption(mySession);
				bom.RawMatID = rawMatID;
				bom.InventoryID = inventoryID;
			}
			else
			{
				originalQuantity = bom.QuantityUsed;
				originalScrap = (float)bom.ScrapFactorUsed;
			}

			bom.QuantityUsed = quantityUsed;
			bom.ScrapFactorUsed = scrapFactorUsed;

			bom.Save();

			return (float)(bom.QuantityUsed - originalQuantity + bom.ScrapFactorUsed - originalScrap);

		}

	}

}