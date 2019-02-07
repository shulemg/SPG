//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using SuperiorPackGroup.SPGReportsTableAdapters;
using DevExpress.Xpo;
using DXDAL.SPGData;
using DevExpress.Data.Filtering;

namespace SuperiorPackGroup
{
	public class ProductionEntriesReportBLL
	{

		private ProductionEntriesReportTableAdapter m_ProductionEntriesReportTableAdapter = null;

		public ProductionEntriesReportTableAdapter Adapter
		{
			get
			{
				if (this.m_ProductionEntriesReportTableAdapter == null)
				{
					this.m_ProductionEntriesReportTableAdapter = new ProductionEntriesReportTableAdapter();
					this.m_ProductionEntriesReportTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return this.m_ProductionEntriesReportTableAdapter;
			}
		}

		public SPGReports.ProductionEntriesReportDataTable GetProductionEntriesReport(DateTime? fromDate, DateTime? toDate, int? customerID, string lot, string po, string items, bool? inactiveItems, bool? inactiveCustomers, int? shift)
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
				return Adapter.GetProductionEntriesReport(fromDate, toDate, customerID, lot, po, inactiveCustomers, inactiveItems, shift);
			}
			else
			{
				return Adapter.GetProductionEntriesReportByItem(fromDate, toDate, customerID, lot, po, inactiveCustomers, shift, items);
			}

		}

		public static XPView GetProductionEntriesReportView(bool onlyAssigned)
		{

			XPView productionEntriesReportXPView = new XPView(Session.DefaultSession, typeof(Inventory));
			//Dim theCriteria As New CriteriaOperatorCollection

			//If customerID.HasValue Then
			//    theCriteria.Add(New BinaryOperator("ItemCustomerID", customerID.Value, BinaryOperatorType.Equal))
			//End If
			//If String.IsNullOrEmpty(itemType) = False Then
			//    theCriteria.Add(New BinaryOperator("ItemType", itemType, BinaryOperatorType.Equal))
			//End If
			//If inactiveCustomers.Value = False Then
			//    theCriteria.Add(New BinaryOperator("ItemCustomerID.Inactive", False))
			//End If
			//If inactiveItems.Value = False Then
			//    theCriteria.Add(New BinaryOperator("Inactive", False))
			//End If
			//If String.IsNullOrEmpty(Items) = False Then
			//    theCriteria.Add(New InOperator("ItemID", Items.Split("|"c)))
			//End If
			//If outOfStockItems.HasValue = False OrElse outOfStockItems.Value = False Then
			//    theCriteria.Add(New BinaryOperator("sngQuantityOnHand", 1, BinaryOperatorType.GreaterOrEqual))
			//End If     
			//If onlyAssignedCustomers = True Then
			//    theCriteria.Add(New InOperator("ItemCustomerID", UsersCustomerBLL.GetAssignedCustomerIDs))
			//End If

			try
			{
				if (onlyAssigned)
				{
					productionEntriesReportXPView.Criteria = new InOperator(Inventory.Fields.InventoryItemID.ItemCustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session));
				}
				//productionEntriesReportXPView.Criteria = GroupOperator.And(theCriteria)
				productionEntriesReportXPView.Properties.AddRange(new ViewProperty[]
				{
					new ViewProperty("Production Date", SortDirection.Ascending, Inventory.Fields.InventoryDate, false, true),
					new ViewProperty("Customer Name", SortDirection.Ascending, Inventory.Fields.InventoryItemID.ItemCustomerID.CustomerName, false, true),
					new ViewProperty("Item #", SortDirection.Ascending, Inventory.Fields.InventoryItemID.ItemCode, false, true),
					new ViewProperty("Item Description", SortDirection.None, Inventory.Fields.InventoryItemID.ItemDescription, false, true),
					new ViewProperty("Item Type", SortDirection.None, CriteriaOperator.Parse(string.Format("IIF({0} = 'RM', 'Raw Material', IIF({0} = 'IG', 'Intermediate Goods', 'Finished Goods'))", Inventory.Fields.InventoryItemID.ItemType.PropertyName)), false, true),
					new ViewProperty("Shift", SortDirection.Ascending, Inventory.Fields.Shift.ShiftName, false, true),
					new ViewProperty("Quantity", SortDirection.None, Inventory.Fields.InventoryQuantity, false, true),
					new ViewProperty("PO #", SortDirection.Ascending, Inventory.Fields.PO, false, true),
					new ViewProperty("Lot #", SortDirection.Ascending, Inventory.Fields.Lot, false, true),
					new ViewProperty("Pallet #", SortDirection.None, Inventory.Fields.Pallet, false, true),
					new ViewProperty("LPN #", SortDirection.Ascending, Inventory.Fields.LPNNumber, false, true),
					new ViewProperty("Expiration Date", SortDirection.None, Inventory.Fields.ExpirationDate, false, true),
					new ViewProperty("ExpirationDateFormat", SortDirection.None, Inventory.Fields.InventoryItemID.ItemCustomerID.ExpirationDateFormat, false, true),
					new ViewProperty("Note", SortDirection.None, Inventory.Fields.Note, false, true)
				});
				return productionEntriesReportXPView;
			}
			catch (ArgumentException ex)
			{
				MessageBox.Show(string.Format("There was an error while trying to retrieve the data for the report.{0}{1}", Environment.NewLine, ex.Message));
			}

			return null;

		}

	}

}