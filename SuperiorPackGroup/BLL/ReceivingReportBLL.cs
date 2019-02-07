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
	public class ReceivingReportBLL
	{

		public static XPView GetReceivingReport(DateTime? fromDate, DateTime? toDate, int? shiftID, int? customerID, string lot, string po, string BOL, int? vendor, int? carrierID, string items, bool? inactiveItems, bool onlyAssignedCustomers, bool? inactiveCustomers)
		{

			XPView ReceivingReportXPView = new XPView(Session.DefaultSession, typeof(ReceivingDetail));
			CriteriaOperatorCollection theCriteria = new CriteriaOperatorCollection();

			if (fromDate.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ReceivMainID.ReceivDate", fromDate.Value, BinaryOperatorType.GreaterOrEqual));
			}
			if (toDate.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ReceivMainID.ReceivDate", toDate.Value, BinaryOperatorType.LessOrEqual));
			}
			if (string.IsNullOrEmpty(BOL) == false)
			{
				theCriteria.Add(new BinaryOperator("ReceivMainID.ReceivBOL", BOL, BinaryOperatorType.Equal));
			}
			if (string.IsNullOrEmpty(po) == false)
			{
				theCriteria.Add(new BinaryOperator("ReceivMainID.strPO", po, BinaryOperatorType.Equal));
			}
			if (shiftID.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ReceivMainID.intShiftID", shiftID.Value, BinaryOperatorType.Equal));
			}
			if (customerID.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ReceivMainID.ReceivCustID", customerID.Value, BinaryOperatorType.Equal));
			}
			if (carrierID.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ReceivMainID.ReceivCarrierID", carrierID.Value, BinaryOperatorType.Equal));
			}
			if (vendor.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ReceivMainID.strVendor", vendor.Value, BinaryOperatorType.Equal));
			}
			if (string.IsNullOrEmpty(lot) == false)
			{
				theCriteria.Add(new BinaryOperator("ReceivDetLot", lot, BinaryOperatorType.Equal));
			}
			if (inactiveCustomers.Value == false)
			{
				theCriteria.Add(new BinaryOperator("ReceivMainID.ReceivCustID.Inactive", false));
			}
			if (inactiveItems.Value == false)
			{
				theCriteria.Add(new BinaryOperator("ReceivDetItemID.Inactive", false));
			}
			if (string.IsNullOrEmpty(items) == false)
			{
				theCriteria.Add(new InOperator("ReceivDetItemID", items.Split('|')));
			}
			if (onlyAssignedCustomers == true)
			{
				theCriteria.Add(new InOperator("ReceivMainID.ReceivCustID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session)));
			}

			try
			{
				ReceivingReportXPView.Criteria = CriteriaOperator.And(theCriteria);
				ReceivingReportXPView.Properties.AddRange(new ViewProperty[]
				{
					new ViewProperty("ReceivDate", SortDirection.Ascending, "[ReceivMainID].[ReceivDate]", false, true),
					new ViewProperty("ShiftName", SortDirection.None, "[ReceivMainID].[intShiftID].[ShiftName]", false, true),
					new ViewProperty("CustomerName", SortDirection.Ascending, "[ReceivMainID].[ReceivCustID].[CustomerName]", false, true),
					new ViewProperty("ReceivBOL", SortDirection.None, "[ReceivMainID].[ReceivBOL]", false, true),
					new ViewProperty("strPO", SortDirection.None, "[ReceivMainID].[strPO]", false, true),
					new ViewProperty("VendorName", SortDirection.None, "[ReceivMainID].[strVendor].[VendorName]", false, true),
					new ViewProperty("ReceivDetLot", SortDirection.None, "[ReceivDetLot]", false, true),
					new ViewProperty("ItemCode", SortDirection.Ascending, "[ReceivDetItemID].[ItemCode]", false, true),
					new ViewProperty("ItemDescription", SortDirection.None, "[ReceivDetItemID].[ItemDescription]", false, true),
					new ViewProperty("intUnits", SortDirection.None, "[intUnits]", false, true),
					new ViewProperty("CarrierName", SortDirection.None, "[ReceivMainID].[ReceivCarrierID].[CarrierName]", false, true),
					new ViewProperty("strTrailer", SortDirection.None, "[ReceivMainID].[strTrailer]", false, true),
					new ViewProperty("strSeal", SortDirection.None, "[ReceivMainID].[strSeal]", false, true),
					new ViewProperty("ExpirationDate", SortDirection.None, "[ExpirationDate]", false, true),
					new ViewProperty("ExpirationDateFormat", SortDirection.None, "[ReceivMainID].[ReceivCustID].[ExpirationDateFormat]", false, true)
				});
				return ReceivingReportXPView;
			}
			catch (ArgumentException ex)
			{
				MessageBox.Show(string.Format("There was an error while trying to retrieve the data for the report.{0}{1}", Environment.NewLine, ex.Message));
			}

			return null;

		}

	}

}