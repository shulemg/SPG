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
	public class ShippingReportBLL
	{

		public static XPView GetShippingReport(DateTime? fromDate, DateTime? toDate, int? shiftID, int? customerID, string lot, string po, string BOL, string deliveryNoteNumber, int? destinationID, int? carrierID, string items, bool? inactiveItems, bool? inactiveCustomers, bool onlyAssignedCustomers)
		{

			XPView ShippingReportXPView = new XPView(Session.DefaultSession, typeof(ShipDet));
			CriteriaOperatorCollection theCriteria = new CriteriaOperatorCollection();

			if (fromDate.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ShipDetMainID.ShipMainDate", fromDate.Value, BinaryOperatorType.GreaterOrEqual));
			}
			if (toDate.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ShipDetMainID.ShipMainDate", toDate.Value, BinaryOperatorType.LessOrEqual));
			}
			if (string.IsNullOrEmpty(BOL) == false)
			{
				theCriteria.Add(new BinaryOperator("ShipDetMainID.ShipMainBOL", BOL, BinaryOperatorType.Equal));
			}
			if (string.IsNullOrEmpty(po) == false)
			{
				theCriteria.Add(new BinaryOperator("ShipDetMainID.strPO", po, BinaryOperatorType.Equal));
			}
			if (string.IsNullOrEmpty(deliveryNoteNumber) == false)
			{
				theCriteria.Add(new BinaryOperator("ShipDetMainID.DeliveryNoteNumber", deliveryNoteNumber, BinaryOperatorType.Equal));
			}
			if (shiftID.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ShipDetMainID.Shift", shiftID.Value, BinaryOperatorType.Equal));
			}
			if (customerID.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ShipDetMainID.ShipMainCustID", customerID.Value, BinaryOperatorType.Equal));
			}
			if (carrierID.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ShipDetMainID.ShipMainCarrierID", carrierID.Value, BinaryOperatorType.Equal));
			}
			if (destinationID.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ShipDetMainID.intDestination", destinationID.Value, BinaryOperatorType.Equal));
			}
			if (string.IsNullOrEmpty(lot) == false)
			{
				theCriteria.Add(new BinaryOperator("ShipDetLot", lot, BinaryOperatorType.Equal));
			}
			if (inactiveCustomers.Value == false)
			{
				theCriteria.Add(new BinaryOperator("ShipDetMainID.ShipMainCustID.Inactive", false));
			}
			if (inactiveItems.Value == false)
			{
				theCriteria.Add(new BinaryOperator("ShipDetItemID.Inactive", false));
			}
			if (string.IsNullOrEmpty(items) == false)
			{
				theCriteria.Add(new InOperator("ShipDetItemID", items.Split('|')));
			}
			if (onlyAssignedCustomers == true)
			{
				theCriteria.Add(new InOperator("ShipDetMainID.ShipMainCustID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session)));
			}

			try
			{
				ShippingReportXPView.Criteria = CriteriaOperator.And(theCriteria);
				ShippingReportXPView.Properties.AddRange(new ViewProperty[]
				{
					new ViewProperty("ShipMainDate", SortDirection.Ascending, "[ShipDetMainID].[ShipMainDate]", false, true),
					new ViewProperty("ShiftName", SortDirection.None, "[ShipDetMainID].[Shift].[ShiftName]", false, true),
					new ViewProperty("CustomerName", SortDirection.Ascending, "[ShipDetMainID].[ShipMainCustID].[CustomerName]", false, true),
					new ViewProperty("ShipMainBOL", SortDirection.None, "[ShipDetMainID].[ShipMainBOL]", false, true),
					new ViewProperty("strPO", SortDirection.None, "[ShipDetMainID].[strPO]", false, true),
					new ViewProperty("DeliveryNoteNumber", SortDirection.None, "[ShipDetMainID].[DeliveryNoteNumber]", false, true),
					new ViewProperty("ShippingName", SortDirection.None, "[ShipDetMainID].[intDestination].[ShippingName]", false, true),
					new ViewProperty("ShipDetLot", SortDirection.None, "[ShipDetLot]", false, true),
					new ViewProperty("FullLPNNumber", SortDirection.None, "[FullLPNNumber]", false, true),
					new ViewProperty("ItemCode", SortDirection.Ascending, "[ShipDetItemID].[ItemCode]", false, true),
					new ViewProperty("ItemDescription", SortDirection.None, "[ShipDetItemID].[ItemDescription]", false, true),
					new ViewProperty("ShipDetDetQty", SortDirection.None, "[ShipDetDetQty]", false, true),
					new ViewProperty("CarrierName", SortDirection.None, "[ShipDetMainID].[ShipMainCarrierID].[CarrierName]", false, true),
					new ViewProperty("strTrailer", SortDirection.None, "[ShipDetMainID].[strTrailer]", false, true),
					new ViewProperty("strSeal", SortDirection.None, "[ShipDetMainID].[strSeal]", false, true),
					new ViewProperty("ExpirationDate", SortDirection.None, "[ExpirationDate]", false, true),
					new ViewProperty("ExpirationDateFormat", SortDirection.None, "[ShipDetMainID].[ShipMainCustID].[ExpirationDateFormat]", false, true)
				});
				return ShippingReportXPView;
			}
			catch (ArgumentException ex)
			{
				MessageBox.Show(string.Format("There was an error while trying to retrieve the data for the report.{0}{1}", Environment.NewLine, ex.Message));
			}

			return null;

		}

	}

}