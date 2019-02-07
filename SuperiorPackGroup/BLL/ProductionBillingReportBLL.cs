//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DXDAL.SPGData;

namespace SuperiorPackGroup
{
	public class ProductionBillingReportBLL
	{

		public static XPView GetProductionBillingReportView(bool onlyAssigned)
		{

			XPView productionBillingReportXPView = new XPView(Session.DefaultSession, typeof(Inventory));

			try
			{
				if (onlyAssigned)
				{
					productionBillingReportXPView.Criteria = new InOperator(Inventory.Fields.InventoryItemID.ItemCustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session));
				}
				productionBillingReportXPView.Properties.AddRange(new ViewProperty[]
				{
					new ViewProperty("Production Date", SortDirection.Ascending, Inventory.Fields.InventoryDate, true, true),
					new ViewProperty("Customer Name", SortDirection.Ascending, Inventory.Fields.InventoryItemID.ItemCustomerID.CustomerName, true, true),
					new ViewProperty("Item #", SortDirection.Ascending, Inventory.Fields.InventoryItemID.ItemCode, true, true),
					new ViewProperty("Item Description", SortDirection.None, Inventory.Fields.InventoryItemID.ItemDescription, true, true),
					new ViewProperty("Item Type", SortDirection.None, CriteriaOperator.Parse(string.Format("IIF({0} = 'RM', 'Raw Material', IIF({0} = 'IG', 'Intermediate Goods', 'Finished Goods'))", Inventory.Fields.InventoryItemID.ItemType.PropertyName)), true, true),
					new ViewProperty("Shift", SortDirection.Ascending, Inventory.Fields.Shift.ShiftName, true, true),
					new ViewProperty("PO #", SortDirection.Ascending, Inventory.Fields.PO, true, true),
					new ViewProperty("UOM", SortDirection.Ascending, Inventory.Fields.InventoryItemID.strUnitOfMeasure, true, true),
					new ViewProperty("Quantity", SortDirection.None, CriteriaOperator.Parse(string.Format("Sum({0})", Inventory.Fields.InventoryQuantity.PropertyName)), false, true),
					new ViewProperty("Cases", SortDirection.Ascending, CriteriaOperator.Parse(string.Format("Sum({0}/{1})", Inventory.Fields.InventoryQuantity.PropertyName, Inventory.Fields.InventoryItemID.intUnitsPerCase.PropertyName)), false, true),
					new ViewProperty("Price", SortDirection.Ascending, CriteriaOperator.Parse(string.Format("Sum({0}*{1})", Inventory.Fields.InventoryQuantity.PropertyName, Inventory.Fields.InventoryItemID.dblPrice.PropertyName)), false, true)
				});
				return productionBillingReportXPView;
			}
			catch (ArgumentException ex)
			{
				MessageBox.Show(string.Format("There was an error while trying to retrieve the data for the report.{0}{1}", Environment.NewLine, ex.Message));
			}

			return null;

		}

	}

}