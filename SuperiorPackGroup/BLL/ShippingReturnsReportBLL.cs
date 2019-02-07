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
	public class ShippingReturnsReportBLL
	{

		public static XPView GetShippingReturnsReport(DateTime? fromDate, DateTime? toDate, int? shiftID, int? customerID, string lot, string BOL, int? destinationID, int? carrierID, string items, bool? inactiveItems, bool? inactiveCustomers, bool onlyAssignedCustomers)
		{

			XPView ShippingReturnsReportXPView = new XPView(Session.DefaultSession, typeof(ShippedReturns));
			CriteriaOperatorCollection theCriteria = new CriteriaOperatorCollection();

			if (fromDate.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ShipMainID.ShipMainDate", fromDate.Value, BinaryOperatorType.GreaterOrEqual));
			}
			if (toDate.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ShipMainID.ShipMainDate", toDate.Value, BinaryOperatorType.LessOrEqual));
			}
			if (string.IsNullOrEmpty(BOL) == false)
			{
				theCriteria.Add(new BinaryOperator("ShipMainID.ShipMainBOL", BOL, BinaryOperatorType.Equal));
			}
			//If String.IsNullOrEmpty(po) = False Then
			//    theCriteria.Add(New BinaryOperator("ShipMainID.strPO", po, BinaryOperatorType.Equal))
			//End If
			//If String.IsNullOrEmpty(deliveryNoteNumber) = False Then
			//    theCriteria.Add(New BinaryOperator("ShipMainID.DeliveryNoteNumber", deliveryNoteNumber, BinaryOperatorType.Equal))
			//End If
			if (shiftID.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ShipMainID.Shift", shiftID.Value, BinaryOperatorType.Equal));
			}
			if (customerID.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ShipMainID.ShipMainCustID", customerID.Value, BinaryOperatorType.Equal));
			}
			if (carrierID.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ShipMainID.ShipMainCarrierID", carrierID.Value, BinaryOperatorType.Equal));
			}
			if (destinationID.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ShipMainID.intDestination", destinationID.Value, BinaryOperatorType.Equal));
			}
			if (string.IsNullOrEmpty(lot) == false)
			{
				theCriteria.Add(new BinaryOperator("ReturnDetLot", lot, BinaryOperatorType.Equal));
			}
			if (inactiveCustomers.Value == false)
			{
				theCriteria.Add(new BinaryOperator("ShipMainID.ShipMainCustID.Inactive", false));
			}
			if (inactiveItems.Value == false)
			{
				theCriteria.Add(new BinaryOperator("ReturnDetItemID.Inactive", false));
			}
			if (string.IsNullOrEmpty(items) == false)
			{
				theCriteria.Add(new InOperator("ReturnDetItemID", items.Split('|')));
			}
			if (onlyAssignedCustomers == true)
			{
				theCriteria.Add(new InOperator("ShipMainID.ShipMainCustID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session)));
			}

			try
			{
				ShippingReturnsReportXPView.Criteria = CriteriaOperator.And(theCriteria);
				ShippingReturnsReportXPView.Properties.AddRange(new ViewProperty[]
				{
					new ViewProperty("ShipMainDate", SortDirection.Ascending, "[ShipMainID].[ShipMainDate]", false, true),
					new ViewProperty("ShiftName", SortDirection.None, "[ShipMainID].[Shift].[ShiftName]", false, true),
					new ViewProperty("CustomerName", SortDirection.Ascending, "[ShipMainID].[ShipMainCustID].[CustomerName]", false, true),
					new ViewProperty("ShipMainBOL", SortDirection.None, "[ShipMainID].[ShipMainBOL]", false, true),
					new ViewProperty("strPO", SortDirection.None, "[ShipMainID].[strPO]", false, true),
					new ViewProperty("DeliveryNoteNumber", SortDirection.None, "[ShipMainID].[DeliveryNoteNumber]", false, true),
					new ViewProperty("ShippingName", SortDirection.None, "[ShipMainID].[intDestination].[ShippingName]", false, true),
					new ViewProperty("ReturnDetLot", SortDirection.None, "[ReturnDetLot]", false, true),
					new ViewProperty("ItemCode", SortDirection.Ascending, "[ReturnDetItemID].[ItemCode]", false, true),
					new ViewProperty("ItemDescription", SortDirection.None, "[ReturnDetItemID].[ItemDescription]", false, true),
					new ViewProperty("intUnits", SortDirection.None, "[intUnits]", false, true),
					new ViewProperty("CarrierName", SortDirection.None, "[ShipMainID].[ShipMainCarrierID].[CarrierName]", false, true),
					new ViewProperty("strTrailer", SortDirection.None, "[ShipMainID].[strTrailer]", false, true),
					new ViewProperty("strSeal", SortDirection.None, "[ShipMainID].[strSeal]", false, true),
					new ViewProperty("ExpirationDate", SortDirection.None, "[ExpirationDate]", false, true),
					new ViewProperty("ExpirationDateFormat", SortDirection.None, "[ShipMainID].[ShipMainCustID].[ExpirationDateFormat]", false, true)
				});
				return ShippingReturnsReportXPView;
			}
			catch (ArgumentException ex)
			{
				MessageBox.Show(string.Format("There was an error while trying to retrieve the data for the report.{0}{1}", Environment.NewLine, ex.Message));
			}

			return null;


		}

	}

}