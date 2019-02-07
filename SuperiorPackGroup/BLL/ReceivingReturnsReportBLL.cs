﻿//INSTANT C# NOTE: Formerly VB project-level imports:
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
	public class ReceivingReturnsReportBLL
	{

		public static XPView GetReceivingReturnsReport(DateTime? fromDate, DateTime? toDate, int? shiftID, int? customerID, string lot, string BOL, int? vendor, int? carrierID, string items, bool? inactiveItems, bool? inactiveCustomers, bool onlyAssignedCustomers)
		{

			XPView ReceivingReturnsReportXPView = new XPView(Session.DefaultSession, typeof(ReceivedReturns));
			CriteriaOperatorCollection theCriteria = new CriteriaOperatorCollection();

			if (fromDate.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ReceiveMainID.ReceivDate", fromDate.Value, BinaryOperatorType.GreaterOrEqual));
			}
			if (toDate.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ReceiveMainID.ReceivDate", toDate.Value, BinaryOperatorType.LessOrEqual));
			}
			if (string.IsNullOrEmpty(BOL) == false)
			{
				theCriteria.Add(new BinaryOperator("ReceiveMainID.ReceivBOL", BOL, BinaryOperatorType.Equal));
			}
			if (shiftID.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ReceiveMainID.intShiftID", shiftID.Value, BinaryOperatorType.Equal));
			}
			if (customerID.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ReceiveMainID.ReceivCustID", customerID.Value, BinaryOperatorType.Equal));
			}
			if (carrierID.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ReceiveMainID.ReceivCarrierID", carrierID.Value, BinaryOperatorType.Equal));
			}
			if (vendor.HasValue)
			{
				theCriteria.Add(new BinaryOperator("ReceiveMainID.strVendor", vendor.Value, BinaryOperatorType.Equal));
			}
			if (string.IsNullOrEmpty(lot) == false)
			{
				theCriteria.Add(new BinaryOperator("ReturnDetLot", lot, BinaryOperatorType.Equal));
			}
			if (inactiveCustomers.Value == false)
			{
				theCriteria.Add(new BinaryOperator("ReceiveMainID.ReceivCustID.Inactive", false));
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
				theCriteria.Add(new InOperator("ReceiveMainID.ReceivCustID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session)));
			}

			try
			{
				ReceivingReturnsReportXPView.Criteria = CriteriaOperator.And(theCriteria);
				ReceivingReturnsReportXPView.Properties.AddRange(new ViewProperty[]
				{
					new ViewProperty("ReceivDate", SortDirection.Ascending, "[ReceiveMainID].[ReceivDate]", false, true),
					new ViewProperty("ShiftName", SortDirection.None, "[ReceiveMainID].[intShiftID].[ShiftName]", false, true),
					new ViewProperty("CustomerName", SortDirection.Ascending, "[ReceiveMainID].[ReceivCustID].[CustomerName]", false, true),
					new ViewProperty("ReceivBOL", SortDirection.None, "[ReceiveMainID].[ReceivBOL]", false, true),
					new ViewProperty("strPO", SortDirection.None, "[ReceiveMainID].[strPO]", false, true),
					new ViewProperty("VendorName", SortDirection.None, "[ReceiveMainID].[strVendor].[VendorName]", false, true),
					new ViewProperty("ReturnDetLot", SortDirection.None, "[ReturnDetLot]", false, true),
					new ViewProperty("ItemCode", SortDirection.Ascending, "[ReturnDetItemID].[ItemCode]", false, true),
					new ViewProperty("ItemDescription", SortDirection.None, "[ReturnDetItemID].[ItemDescription]", false, true),
					new ViewProperty("ReturnDetQty", SortDirection.None, "[ReturnDetQty]", false, true),
					new ViewProperty("CarrierName", SortDirection.None, "[ReceiveMainID].[ReceivCarrierID].[CarrierName]", false, true),
					new ViewProperty("strTrailer", SortDirection.None, "[ReceiveMainID].[strTrailer]", false, true),
					new ViewProperty("strSeal", SortDirection.None, "[ReceiveMainID].[strSeal]", false, true),
					new ViewProperty("ExpirationDate", SortDirection.None, "[ExpirationDate]", false, true),
					new ViewProperty("ExpirationDateFormat", SortDirection.None, "[ReceiveMainID].[ReceivCustID].[ExpirationDateFormat]", false, true)
				});
				return ReceivingReturnsReportXPView;
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format("There was an error while trying to retrieve the data for the report.{0}{1}", Environment.NewLine, ex.Message));
			}

			return null;

		}

	}

}