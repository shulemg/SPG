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
using DevExpress.Data.Filtering;

namespace SuperiorPackGroup
{
	public class CurrentInventoryReportBLL
	{

		public static XPView GetCurrentInventoryReport(int? customerID, string itemType, string items, bool? inactiveItems, bool? inactiveCustomers, bool? outOfStockItems, bool onlyAssignedCustomers, int? locationID)
		{

			XPView CurrentInventoryReportXPView = new XPView(Session.DefaultSession, typeof(LocationInventory));
			CriteriaOperatorCollection theCriteria = new CriteriaOperatorCollection();

			if (customerID.HasValue)
			{
				theCriteria.Add(new BinaryOperator(LocationInventory.Fields.LocationInventoryItem.ItemCustomerID.CustomerID.PropertyName, customerID.Value, BinaryOperatorType.Equal));
			}
			if (string.IsNullOrEmpty(itemType) == false)
			{
				theCriteria.Add(new BinaryOperator(LocationInventory.Fields.LocationInventoryItem.ItemType.PropertyName, itemType, BinaryOperatorType.Equal));
			}
			if (inactiveCustomers.Value == false)
			{
				theCriteria.Add(new BinaryOperator(LocationInventory.Fields.LocationInventoryItem.ItemCustomerID.Inactive.PropertyName, false));
			}
			if (inactiveItems.Value == false)
			{
				theCriteria.Add(new BinaryOperator(LocationInventory.Fields.LocationInventoryItem.Inactive.PropertyName, false));
			}
			if (string.IsNullOrEmpty(items) == false)
			{
				theCriteria.Add(new InOperator(LocationInventory.Fields.LocationInventoryItem.ItemID.PropertyName, items.Split('|')));
			}
			if (outOfStockItems.HasValue == false || outOfStockItems == false)
			{
				theCriteria.Add(new BinaryOperator(LocationInventory.Fields.QuantityOnHand.PropertyName, 1, BinaryOperatorType.GreaterOrEqual));
			}
			if (onlyAssignedCustomers == true)
			{
				theCriteria.Add(new InOperator(LocationInventory.Fields.LocationInventoryItem.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session)));
			}
			if (locationID.HasValue)
			{
				theCriteria.Add(new BinaryOperator(LocationInventory.Fields.Location.Oid.PropertyName, locationID.Value, BinaryOperatorType.Equal));
			}

			try
			{
				CurrentInventoryReportXPView.Criteria = CriteriaOperator.And(theCriteria);
				CurrentInventoryReportXPView.Properties.AddRange(new ViewProperty[]
				{
					new ViewProperty("CustomerName", SortDirection.Ascending, LocationInventory.Fields.LocationInventoryItem.ItemCustomerID.CustomerName.PropertyName, false, true),
					new ViewProperty("ItemCode", SortDirection.Ascending, LocationInventory.Fields.LocationInventoryItem.ItemCode.PropertyName, false, true),
					new ViewProperty("ItemDescription", SortDirection.None, LocationInventory.Fields.LocationInventoryItem.ItemDescription.PropertyName, false, true),
					new ViewProperty("ItemType", SortDirection.None, CriteriaOperator.Parse(string.Format("IIF({0} = 'RM', 'Raw Material', IIF({0} = 'IG', 'Intermediate Goods', 'Finished Goods'))", LocationInventory.Fields.LocationInventoryItem.ItemType.PropertyName)), false, true),
					new ViewProperty("QuantityOnHand", SortDirection.None, LocationInventory.Fields.QuantityOnHand.PropertyName, false, true),
					new ViewProperty("InventoryByPallets", SortDirection.None, CriteriaOperator.Parse(string.Format("IIF({1} = 0, 0, {0} / {1})", LocationInventory.Fields.QuantityOnHand.PropertyName, LocationInventory.Fields.LocationInventoryItem.intUnitsPerPallet.PropertyName)), false, true),
					new ViewProperty("UOM", SortDirection.None, LocationInventory.Fields.LocationInventoryItem.strUnitOfMeasure.PropertyName, false, true),
					new ViewProperty("Location", SortDirection.None, LocationInventory.Fields.Location.LocationCode.PropertyName, false, true),
					new ViewProperty("InactiveCustomer", SortDirection.None, LocationInventory.Fields.LocationInventoryItem.ItemCustomerID.Inactive.PropertyName, false, true),
					new ViewProperty("InactiveItem", SortDirection.None, LocationInventory.Fields.LocationInventoryItem.Inactive.PropertyName, false, true)
				});
				return CurrentInventoryReportXPView;
			}
			catch (ArgumentException ex)
			{
				MessageBox.Show(string.Format("There was an error while trying to retrieve the data for the report.{0}{1}", Environment.NewLine, ex.Message));
			}

			return null;

		}

	}

}