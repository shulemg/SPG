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
	public class LPNStatusReportBLL
	{

		public static XPView GetLpnStatusrReportView(bool onlyAssigned)
		{

			XPView lpnStatusReportView = new XPView(Session.DefaultSession, typeof(Inventory));

			try
			{
				if (onlyAssigned)
				{
					lpnStatusReportView.GroupCriteria = CriteriaOperator.And(new InOperator(Inventory.Fields.InventoryItemID.ItemCustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session)), new BinaryOperator(Inventory.Fields.InventoryDate.PropertyName, DateTime.Parse("Aug/4/2013"), BinaryOperatorType.GreaterOrEqual), CriteriaOperator.Parse("[FullLPNNumber] Is Not NULL"));
				}
				else
				{
					lpnStatusReportView.GroupCriteria = CriteriaOperator.And(new BinaryOperator(Inventory.Fields.InventoryDate.PropertyName, DateTime.Parse("Aug/4/2013"), BinaryOperatorType.GreaterOrEqual), CriteriaOperator.Parse("[FullLPNNumber] Is Not NULL"));
				}

				lpnStatusReportView.Properties.AddRange(new ViewProperty[]
				{
					new ViewProperty("Full LPN Number", SortDirection.Ascending, Inventory.Fields.FullLPNNumber, true, true),
					new ViewProperty("Item #", SortDirection.Ascending, Inventory.Fields.InventoryItemID.ItemCode, true, true),
					new ViewProperty("Quantity", SortDirection.None, "Sum([InventoryQuantity])", false, true),
					new ViewProperty("Production Date", SortDirection.Ascending, Inventory.Fields.InventoryDate, true, true),
					new ViewProperty("Shipping Date", SortDirection.Ascending, Inventory.Fields.Shipment.ShipMainDate, true, true),
					new ViewProperty("BOL #", SortDirection.Ascending, Inventory.Fields.Shipment.ShipMainBOL, true, true),
					new ViewProperty("Customer Name", SortDirection.None, Inventory.Fields.InventoryItemID.ItemCustomerID.CustomerName, true, true),
					new ViewProperty("ShippingID", SortDirection.None, Inventory.Fields.Shipment.ShipMainID, true, true)
				});
				return lpnStatusReportView;
			}
			catch (ArgumentException ex)
			{
				MessageBox.Show(string.Format("There was an error while trying to retrieve the data for the report.{0}{1}", Environment.NewLine, ex.Message));
			}

			return null;

		}

	}

}