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
	public class ItemTransactionSummaryReportBLL
	{

		private ItemTransactionSummary transactionSummary;

		public ItemTransactionSummaryList GetItemTransactionSummaryReport(DateTime? fromDate, DateTime? toDate, int? itemCustomerID, string items, string itemType, bool onlyAssigned)
		{

			if (fromDate.HasValue == false && toDate.HasValue == false && itemCustomerID.HasValue == false && string.IsNullOrEmpty(items))
			{
				return null;
			}

			ItemTransactionSummaryList transactionsSummaryList = new ItemTransactionSummaryList();

			try
			{
				XPView itemsXPView = null;
				CriteriaOperatorCollection theCriteria = new CriteriaOperatorCollection();

				if (itemCustomerID.HasValue)
				{
					theCriteria.Add(new BinaryOperator("ItemCustomerID", itemCustomerID.Value, BinaryOperatorType.Equal));
				}
				if (onlyAssigned)
				{
					theCriteria.Add(new InOperator("ItemCustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session)));
				}
				if (string.IsNullOrEmpty(itemType) == false)
				{
					theCriteria.Add(new BinaryOperator("ItemType", itemType, BinaryOperatorType.Equal));
				}
				if (string.IsNullOrEmpty(items) == false)
				{
					theCriteria.Add(new InOperator("ItemID", items.Split('|')));
				}

				itemsXPView = new XPView(Session.DefaultSession, typeof(Items)) {Criteria = CriteriaOperator.And(theCriteria)};
				itemsXPView.Properties.Add(new ViewProperty("ItemID", SortDirection.None, "ItemID", false, true));

				foreach (ViewRecord item in itemsXPView)
				{
					transactionSummary = new ItemTransactionSummary();
					Items currentItem = Session.DefaultSession.GetObjectByKey<Items>(item["ItemID"]);
					transactionSummary.CustomerName = currentItem.ItemCustomerID.CustomerName;
					transactionSummary.ItemCode = currentItem.ItemCode;
					transactionSummary.ItemDescription = currentItem.ItemDescription;
					transactionSummary.ItemType = ((currentItem.ItemType == "RM") ? "Raw Material" : ((currentItem.ItemType == "IG") ? "Intermediate Goods" : "Finished Goods")).ToString();
					AddReceivingsToSumary(fromDate, toDate, currentItem.ItemID);
					AddShippingsToSummary(fromDate, toDate, currentItem.ItemID);
					AddAdjustmentsToSummary(fromDate, toDate, currentItem.ItemID);
					AddProductionToSummary(fromDate, toDate, currentItem.ItemID);
					AddUsedInProductiontoSummary(fromDate, toDate, currentItem.ItemID);
					if (transactionSummary.Received != 0 || transactionSummary.Produced != 0 || transactionSummary.Adjusted != 0 || transactionSummary.Shipped != 0 || transactionSummary.UsedInProduction != 0)
					{
						transactionsSummaryList.Add(transactionSummary);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format("There was an error while trying to retrieve the data for the report.{0}{1}", Environment.NewLine, ex.Message));
				return null;
			}

			return transactionsSummaryList;

		}

		private void AddReceivingsToSumary(DateTime? fromDate, DateTime? toDate, int currentItem)
		{

			double total = 0;
			CriteriaOperatorCollection theCriteria = new CriteriaOperatorCollection();

			if (fromDate.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ReceivMainID.ReceivDate", fromDate.Value, BinaryOperatorType.GreaterOrEqual));
			}
			if (toDate.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ReceivMainID.ReceivDate", toDate.Value, BinaryOperatorType.LessOrEqual));
			}

			theCriteria.Add(new BinaryOperator("ReceivDetItemID", currentItem, BinaryOperatorType.Equal));
			total = Convert.ToDouble(Session.DefaultSession.Evaluate(typeof(ReceivingDetail), CriteriaOperator.Parse("Sum(intUnits)"), CriteriaOperator.And(theCriteria)));

			theCriteria.Clear();

			if (fromDate.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ReceiveMainID.ReceivDate", fromDate.Value, BinaryOperatorType.GreaterOrEqual));
			}
			if (toDate.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ReceiveMainID.ReceivDate", toDate.Value, BinaryOperatorType.LessOrEqual));
			}
			theCriteria.Add(new BinaryOperator("ReturnDetItemID", currentItem, BinaryOperatorType.Equal));
			total += Convert.ToDouble(Session.DefaultSession.Evaluate(typeof(ReceivedReturns), CriteriaOperator.Parse("Sum(ReturnDetQty)"), CriteriaOperator.And(theCriteria)));

			transactionSummary.Received = total;

		}

		private void AddShippingsToSummary(DateTime? fromDate, DateTime? toDate, int currentItem)
		{

			double total = 0;
			CriteriaOperatorCollection theCriteria = new CriteriaOperatorCollection();

			if (fromDate.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ShipDetMainID.ShipMainDate", fromDate.Value, BinaryOperatorType.GreaterOrEqual));
			}
			if (toDate.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ShipDetMainID.ShipMainDate", toDate.Value, BinaryOperatorType.LessOrEqual));
			}
			theCriteria.Add(new BinaryOperator("ShipDetItemID", currentItem, BinaryOperatorType.Equal));
			total = Convert.ToDouble(Session.DefaultSession.Evaluate(typeof(ShipDet), CriteriaOperator.Parse("Sum(ShipDetDetQty)"), CriteriaOperator.And(theCriteria)));

			theCriteria.Clear();

			if (fromDate.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ShipMainID.ShipMainDate", fromDate.Value, BinaryOperatorType.GreaterOrEqual));
			}
			if (toDate.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ShipMainID.ShipMainDate", toDate.Value, BinaryOperatorType.LessOrEqual));
			}
			theCriteria.Add(new BinaryOperator("ReturnDetItemID", currentItem, BinaryOperatorType.Equal));
			total += Convert.ToDouble(Session.DefaultSession.Evaluate(typeof(ShippedReturns), CriteriaOperator.Parse("Sum(intUnits)"), CriteriaOperator.And(theCriteria)));

			transactionSummary.Shipped = total;

		}

		private void AddAdjustmentsToSummary(DateTime? fromDate, DateTime? toDate, int currentItem)
		{

			CriteriaOperatorCollection theCriteria = new CriteriaOperatorCollection();

			if (fromDate.HasValue)
			{
				theCriteria.Add(new BinaryOperator("AdjustmentDate", fromDate.Value, BinaryOperatorType.GreaterOrEqual));
			}
			if (toDate.HasValue)
			{
				theCriteria.Add(new BinaryOperator("AdjustmentDate", toDate.Value, BinaryOperatorType.LessOrEqual));
			}
			theCriteria.Add(new BinaryOperator("AdjustmentItem", currentItem, BinaryOperatorType.Equal));
			transactionSummary.Adjusted = Convert.ToDouble(Session.DefaultSession.Evaluate(typeof(InventoryAdjustment), CriteriaOperator.Parse("Sum(NewCount) - Sum(OriginalQuantity)"), CriteriaOperator.And(theCriteria)));

		}

		private void AddProductionToSummary(DateTime? fromDate, DateTime? toDate, int currentItem)
		{

			CriteriaOperatorCollection theCriteria = new CriteriaOperatorCollection();

			if (fromDate.HasValue)
			{
				theCriteria.Add(new BinaryOperator("InventoryDate", fromDate.Value, BinaryOperatorType.GreaterOrEqual));
			}
			if (toDate.HasValue)
			{
				theCriteria.Add(new BinaryOperator("InventoryDate", toDate.Value, BinaryOperatorType.LessOrEqual));
			}
			theCriteria.Add(new BinaryOperator("InventoryItemID", currentItem, BinaryOperatorType.Equal));
			transactionSummary.Produced = Convert.ToDouble(Session.DefaultSession.Evaluate(typeof(Inventory), CriteriaOperator.Parse("Sum(InventoryQuantity)"), CriteriaOperator.And(theCriteria)));

		}

		private void AddUsedInProductiontoSummary(DateTime? fromDate, DateTime? toDate, int currentItem)
		{

			CriteriaOperatorCollection theCriteria = new CriteriaOperatorCollection();

			if (fromDate.HasValue)
			{
				theCriteria.Add(new BinaryOperator("InventoryBOMInventoryID.InventoryDate", fromDate.Value, BinaryOperatorType.GreaterOrEqual));
			}
			if (toDate.HasValue)
			{
				theCriteria.Add(new BinaryOperator("InventoryBOMInventoryID.InventoryDate", toDate.Value, BinaryOperatorType.LessOrEqual));
			}
			theCriteria.Add(new BinaryOperator("InventoryBOMRawMatID", currentItem, BinaryOperatorType.Equal));
			transactionSummary.UsedInProduction = Convert.ToDouble(Session.DefaultSession.Evaluate(typeof(InventoryBOMs), CriteriaOperator.Parse("Sum((InventoryBOMQuantity + InventoryBOMQuantity * (ScrapFactor)) * InventoryBOMInventoryID.InventoryQuantity * -1)"), CriteriaOperator.And(theCriteria)));

		}

	}

}