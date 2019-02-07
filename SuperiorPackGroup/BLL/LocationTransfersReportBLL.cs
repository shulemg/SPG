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
	public class LocationTransfersReportBLL
	{

		public static XPView GetLocationTransfersReportView(bool onlyAssigned)
		{

			XPView locationTransfersReportView = new XPView(Session.DefaultSession, typeof(LocationTransferDetails));

			try
			{
				if (onlyAssigned)
				{
					locationTransfersReportView.Criteria = new InOperator(LocationTransferDetails.Fields.TransferItem.ItemCustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session));
				}

				locationTransfersReportView.Properties.AddRange(new ViewProperty[]
				{
					new ViewProperty("TransferDate", SortDirection.None, LocationTransferDetails.Fields.Transfer.TransferDate.PropertyName, false, true),
					new ViewProperty("FromLocation", SortDirection.None, LocationTransferDetails.Fields.Transfer.FromLocation.LocationCode.PropertyName, false, true),
					new ViewProperty("ToLocation", SortDirection.None, LocationTransferDetails.Fields.Transfer.ToLocation.LocationCode.PropertyName, false, true),
					new ViewProperty("ItemCode", SortDirection.None, LocationTransferDetails.Fields.TransferItem.ItemCode.PropertyName, false, true),
					new ViewProperty("ItemDescription", SortDirection.None, LocationTransferDetails.Fields.TransferItem.ItemDescription.PropertyName, false, true),
					new ViewProperty("TransferNumber", SortDirection.None, LocationTransferDetails.Fields.Transfer.TransferNumber.PropertyName, false, true),
					new ViewProperty("ItemLot", SortDirection.None, LocationTransferDetails.Fields.TransferLot.PropertyName, false, true),
					new ViewProperty("ExpirationDate", SortDirection.None, LocationTransferDetails.Fields.ItemExpirationDate.PropertyName, false, true),
					new ViewProperty("TransferQuantity", SortDirection.None, LocationTransferDetails.Fields.TransferQuantity.PropertyName, false, true),
					new ViewProperty("ExpirationDateFormat", SortDirection.None, LocationTransferDetails.Fields.TransferItem.ItemCustomerID.ExpirationDateFormat.PropertyName, false, true),
					new ViewProperty("TransferUnits", SortDirection.None, LocationTransferDetails.Fields.TransferUnits.PropertyName, false, true),
					new ViewProperty("TransferPallets", SortDirection.None, LocationTransferDetails.Fields.TransferPallets.PropertyName, false, true),
					new ViewProperty("Carrier", SortDirection.None, LocationTransferDetails.Fields.Transfer.TransferCarrier.CarrierName.PropertyName, false, true)
				});
				return locationTransfersReportView;
			}
			catch (ArgumentException ex)
			{
				MessageBox.Show(string.Format("There was an error while trying to retrieve the data for the report.{0}{1}", Environment.NewLine, ex.Message));
			}

			return null;

		}

	}

}