//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using SuperiorPackGroup.SPGReportsTableAdapters;

using DXDAL.SPGData;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Text;
using System.Linq;

namespace SuperiorPackGroup
{
	public class ItemsTransactionsReportBLL
	{

		private ItemsTransactionsReportTableAdapter m_ItemsTransactionsReportTableAdapter = null;
		private ItemTransactionsList m_ItemsTransactionList;

		public ItemsTransactionsReportTableAdapter Adapter
		{
			get
			{
				if (this.m_ItemsTransactionsReportTableAdapter == null)
				{
					this.m_ItemsTransactionsReportTableAdapter = new ItemsTransactionsReportTableAdapter();
					this.m_ItemsTransactionsReportTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return this.m_ItemsTransactionsReportTableAdapter;
			}
		}

		public SPGReports.ItemsTransactionsReportDataTable GetItemsTransactionsReport(DateTime? fromDate, DateTime? toDate, int? customerID, string itemType, string items, bool? inactiveItems, bool? inactiveCustomers)
		{

			if (inactiveCustomers.Value == true)
			{
				inactiveCustomers = null;
			}

			if (inactiveItems.Value == true)
			{
				inactiveItems = null;
			}

			if (string.IsNullOrEmpty(items))
			{
				return Adapter.GetItemsTransactionsReport(customerID, itemType, inactiveCustomers, inactiveItems, fromDate, toDate);
			}
			else
			{
				return Adapter.GetItemsTransactionsReportByItemID(customerID, itemType, inactiveCustomers, fromDate, toDate, items);
			}

		}

		public ItemTransactionsList GetItemsTransactionsReport(DateTime? fromDate, DateTime? toDate, int? item)
		{

			if (item.HasValue == false || toDate.HasValue == false || fromDate.HasValue == false)
			{
				return null;
			}

			m_ItemsTransactionList = new ItemTransactionsList();

			AddReceivingsToList(fromDate.Value, toDate.Value, item.Value);
			AddShippingsToList(fromDate.Value, toDate.Value, item.Value);
			AddReceivedReturnsToList(fromDate.Value, toDate.Value, item.Value);
			AddShippedReturnsToList(fromDate.Value, toDate.Value, item.Value);
			AddAdjustedToList(fromDate.Value, toDate.Value, item.Value);
			AddProducedToList(fromDate.Value, toDate.Value, item.Value);
			AddUsedInProductionToList(fromDate.Value, toDate.Value, item.Value);

			return m_ItemsTransactionList;

		}

		private void AddReceivingsToList(DateTime fromDate, DateTime toDate, int item)
		{

			double openingBalance = Convert.ToDouble(Session.DefaultSession.Evaluate(typeof(ReceivingDetail), CriteriaOperator.Parse("Sum(intUnits)"), new BinaryOperator(ReceivingDetail.Fields.ReceivMainID.ReceivDate, fromDate, BinaryOperatorType.Less) & new BinaryOperator(ReceivingDetail.Fields.ReceivDetItemID, item, BinaryOperatorType.Equal)));
			m_ItemsTransactionList.OpeningBalance += openingBalance;

			using (XPCollection<ReceivingDetail> ReceivedList = new XPCollection<ReceivingDetail>(Session.DefaultSession, new BinaryOperator(ReceivingDetail.Fields.ReceivMainID.ReceivDate, fromDate, BinaryOperatorType.GreaterOrEqual) & new BinaryOperator(ReceivingDetail.Fields.ReceivMainID.ReceivDate, toDate, BinaryOperatorType.LessOrEqual) & new BinaryOperator(ReceivingDetail.Fields.ReceivDetItemID, item, BinaryOperatorType.Equal)))
			{
				foreach (ReceivingDetail receiving in ReceivedList)
				{
					m_ItemsTransactionList.Add(new ItemTransaction(receiving.ReceivMainID.ReceivDate, receiving.ReceivDetItemID.ItemCode, receiving.ReceivDetItemID.ItemDescription, ItemTransactionType.Received, receiving.intUnits));
				}
			}

		}

		private void AddShippingsToList(DateTime fromDate, DateTime toDate, int item)
		{

			double openingBalance = Convert.ToDouble(Session.DefaultSession.Evaluate(typeof(ShipDet), CriteriaOperator.Parse("Sum(ShipDetDetQty)"), new BinaryOperator(ShipDet.Fields.ShipDetMainID.ShipMainDate, fromDate, BinaryOperatorType.Less) & new BinaryOperator(ShipDet.Fields.ShipDetItemID, item, BinaryOperatorType.Equal))) * -1;
			m_ItemsTransactionList.OpeningBalance += openingBalance;

			using (XPCollection<ShipDet> shippingList = new XPCollection<ShipDet>(Session.DefaultSession, new BinaryOperator(ShipDet.Fields.ShipDetMainID.ShipMainDate, fromDate, BinaryOperatorType.GreaterOrEqual) & new BinaryOperator(ShipDet.Fields.ShipDetMainID.ShipMainDate, toDate, BinaryOperatorType.LessOrEqual) & new BinaryOperator(ShipDet.Fields.ShipDetItemID, item, BinaryOperatorType.Equal)))
			{
				foreach (ShipDet shipping in shippingList)
				{
					m_ItemsTransactionList.Add(new ItemTransaction(shipping.ShipDetMainID.ShipMainDate, shipping.ShipDetItemID.ItemCode, shipping.ShipDetItemID.ItemDescription, ItemTransactionType.Shipped, shipping.ShipDetDetQty * -1));
				}
			}

		}

		private void AddReceivedReturnsToList(DateTime fromDate, DateTime toDate, int item)
		{

			double openingBalance = Convert.ToDouble(Session.DefaultSession.Evaluate(typeof(ReceivedReturns), CriteriaOperator.Parse("Sum(ReturnDetQty)"), new BinaryOperator(ReceivedReturns.Fields.ReceiveMainID.ReceivDate, fromDate, BinaryOperatorType.Less) & new BinaryOperator(ReceivedReturns.Fields.ReturnDetItemID, item, BinaryOperatorType.Equal)));
			m_ItemsTransactionList.OpeningBalance += openingBalance;

			using (XPCollection<ReceivedReturns> receivedReturnsList = new XPCollection<ReceivedReturns>(Session.DefaultSession, new BinaryOperator(ReceivedReturns.Fields.ReceiveMainID.ReceivDate, fromDate, BinaryOperatorType.GreaterOrEqual) & new BinaryOperator(ReceivedReturns.Fields.ReceiveMainID.ReceivDate, toDate, BinaryOperatorType.LessOrEqual) & new BinaryOperator(ReceivedReturns.Fields.ReturnDetItemID, item, BinaryOperatorType.Equal)))
			{
				foreach (ReceivedReturns receivingReturn in receivedReturnsList)
				{
					m_ItemsTransactionList.Add(new ItemTransaction(receivingReturn.ReceiveMainID.ReceivDate, receivingReturn.ReturnDetItemID.ItemCode, receivingReturn.ReturnDetItemID.ItemDescription, ItemTransactionType.ReceivedReturn, receivingReturn.ReturnDetQty));
				}
			}

		}

		private void AddShippedReturnsToList(DateTime fromDate, DateTime toDate, int item)
		{

			double openingBalance = Convert.ToDouble(Session.DefaultSession.Evaluate(typeof(ShippedReturns), CriteriaOperator.Parse("Sum(intUnits)"), new BinaryOperator(ShippedReturns.Fields.ShipMainID.ShipMainDate, fromDate, BinaryOperatorType.Less) & new BinaryOperator(ShippedReturns.Fields.ReturnDetItemID, item, BinaryOperatorType.Equal))) * -1;
			m_ItemsTransactionList.OpeningBalance += openingBalance;

			using (XPCollection<ShippedReturns> ShippedReturnsList = new XPCollection<ShippedReturns>(Session.DefaultSession, new BinaryOperator(ShippedReturns.Fields.ShipMainID.ShipMainDate, fromDate, BinaryOperatorType.GreaterOrEqual) & new BinaryOperator(ShippedReturns.Fields.ShipMainID.ShipMainDate, toDate, BinaryOperatorType.LessOrEqual) & new BinaryOperator(ShippedReturns.Fields.ReturnDetItemID, item, BinaryOperatorType.Equal)))
			{
				foreach (ShippedReturns shippingReturn in ShippedReturnsList)
				{
					m_ItemsTransactionList.Add(new ItemTransaction(shippingReturn.ShipMainID.ShipMainDate, shippingReturn.ReturnDetItemID.ItemCode, shippingReturn.ReturnDetItemID.ItemDescription, ItemTransactionType.ShippedReturn, shippingReturn.intUnits * -1));
				}
			}

		}

		private void AddAdjustedToList(DateTime fromDate, DateTime toDate, int item)
		{

			double openingBalance = Convert.ToDouble(Session.DefaultSession.Evaluate(typeof(InventoryAdjustment), CriteriaOperator.Parse("Sum(NewCount) - Sum(OriginalQuantity)"), new BinaryOperator(InventoryAdjustment.Fields.AdjustmentDate, fromDate, BinaryOperatorType.Less) & new BinaryOperator(InventoryAdjustment.Fields.AdjustmentItem, item, BinaryOperatorType.Equal)));
			m_ItemsTransactionList.OpeningBalance += openingBalance;

			using (XPCollection<InventoryAdjustment> AdjustedList = new XPCollection<InventoryAdjustment>(Session.DefaultSession, new BinaryOperator(InventoryAdjustment.Fields.AdjustmentDate, fromDate, BinaryOperatorType.GreaterOrEqual) & new BinaryOperator(InventoryAdjustment.Fields.AdjustmentDate, toDate, BinaryOperatorType.LessOrEqual) & new BinaryOperator(InventoryAdjustment.Fields.AdjustmentItem, item, BinaryOperatorType.Equal)))
			{
				foreach (InventoryAdjustment adjustment in AdjustedList)
				{
					m_ItemsTransactionList.Add(new ItemTransaction(adjustment.AdjustmentDate, adjustment.AdjustmentItem.ItemCode, adjustment.AdjustmentItem.ItemDescription, ItemTransactionType.Adjusted, (adjustment.NewCount ?? 0) - adjustment.OriginalQuantity));
				}
			}

		}

		private void AddProducedToList(DateTime fromDate, DateTime toDate, int item)
		{

			double openingBalance = Convert.ToDouble(Session.DefaultSession.Evaluate(typeof(Inventory), CriteriaOperator.Parse("Sum(InventoryQuantity)"), new BinaryOperator(Inventory.Fields.InventoryDate, fromDate, BinaryOperatorType.Less) & new BinaryOperator(Inventory.Fields.InventoryItemID, item, BinaryOperatorType.Equal)));
			m_ItemsTransactionList.OpeningBalance += openingBalance;

			using (XPCollection<Inventory> producedList = new XPCollection<Inventory>(Session.DefaultSession, new BinaryOperator(Inventory.Fields.InventoryDate, fromDate, BinaryOperatorType.GreaterOrEqual) & new BinaryOperator(Inventory.Fields.InventoryDate, toDate, BinaryOperatorType.LessOrEqual) & new BinaryOperator(Inventory.Fields.InventoryItemID, item, BinaryOperatorType.Equal)))
			{
				foreach (Inventory production in producedList)
				{
					m_ItemsTransactionList.Add(new ItemTransaction(production.InventoryDate, production.InventoryItemID.ItemCode, production.InventoryItemID.ItemDescription, ItemTransactionType.Produced, production.InventoryQuantity));
				}
			}

		}

		private void AddUsedInProductionToList(DateTime fromDate, DateTime toDate, int item)
		{

			double openingBalance = Convert.ToDouble(Session.DefaultSession.Evaluate(typeof(InventoryBOMs), CriteriaOperator.Parse("Sum((InventoryBOMQuantity + InventoryBOMQuantity * (ScrapFactor)) * InventoryBOMInventoryID.InventoryQuantity * -1)"), new BinaryOperator(InventoryBOMs.Fields.InventoryBOMInventoryID.InventoryDate, fromDate, BinaryOperatorType.Less) & new BinaryOperator(InventoryBOMs.Fields.InventoryBOMRawMatID, item, BinaryOperatorType.Equal)));
			m_ItemsTransactionList.OpeningBalance += openingBalance;

			using (XPCollection<InventoryBOMs> usedInProductionList = new XPCollection<InventoryBOMs>(Session.DefaultSession, new BinaryOperator(InventoryBOMs.Fields.InventoryBOMInventoryID.InventoryDate, fromDate, BinaryOperatorType.GreaterOrEqual) & new BinaryOperator(InventoryBOMs.Fields.InventoryBOMInventoryID.InventoryDate, toDate, BinaryOperatorType.LessOrEqual) & new BinaryOperator(InventoryBOMs.Fields.InventoryBOMRawMatID, item, BinaryOperatorType.Equal)))
			{
				foreach (InventoryBOMs productionRM in usedInProductionList)
				{
					double qty = (productionRM.InventoryBOMQuantity + productionRM.InventoryBOMQuantity * (productionRM.ScrapFactor)) * productionRM.InventoryBOMInventoryID.InventoryQuantity * -1;
					m_ItemsTransactionList.Add(new ItemTransaction(productionRM.InventoryBOMInventoryID.InventoryDate, string.Format("{0} (In {1})", productionRM.InventoryBOMRawMatID.ItemCode, productionRM.InventoryBOMInventoryID.InventoryItemID.ItemCode), productionRM.InventoryBOMRawMatID.ItemDescription, ItemTransactionType.UsedInProduction, qty));
				}
			}

		}

	}

}