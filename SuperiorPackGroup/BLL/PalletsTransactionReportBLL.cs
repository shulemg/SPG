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
	public class PalletsTransactionReportBLL
	{

		private PalletTransactionList m_PalletTransactionList;

		public PalletTransactionList GetPalletTransactionReport(DateTime? fromDate, DateTime? toDate, int? customer)
		{

			m_PalletTransactionList = new PalletTransactionList();

			AddReceivingToList(fromDate, toDate, customer);
			AddShippingToList(fromDate, toDate, customer);

			return m_PalletTransactionList;

		}

		private void AddReceivingToList(DateTime? fromDate, DateTime? toDate, int? customer)
		{

			GroupOperator theCriteria = new GroupOperator() {OperatorType = GroupOperatorType.And};
			if (fromDate.HasValue)
			{
				theCriteria.Operands.Add(new BinaryOperator(Receiving.Fields.ReceivDate.PropertyName, fromDate.Value, BinaryOperatorType.GreaterOrEqual));
			}
			if (toDate.HasValue)
			{
				theCriteria.Operands.Add(new BinaryOperator(Receiving.Fields.ReceivDate.PropertyName, toDate.Value, BinaryOperatorType.LessOrEqual));
			}
			if (customer.HasValue)
			{
				theCriteria.Operands.Add(new BinaryOperator(Receiving.Fields.ReceivCustID.CustomerID.PropertyName, customer.Value, BinaryOperatorType.Equal));
			}

			string vendorName = string.Empty;

			using (XPCollection<Receiving> receivedList = new XPCollection<Receiving>(Session.DefaultSession, theCriteria))
			{
				foreach (Receiving record in receivedList)
				{
					if (record.strVendor != null)
					{
						vendorName = record.strVendor.VendorName;
					}
					m_PalletTransactionList.Add(new PalletTransaction(record.ReceivDate, record.ReceivCustID.CustomerID, record.ReceivCustID.CustomerName, vendorName, null, record.ReceivBOL, record.sngTotalPallets, 0));
				}
			}

		}

		private void AddShippingToList(DateTime? fromDate, DateTime? toDate, int? customer)
		{

			GroupOperator theCriteria = new GroupOperator() {OperatorType = GroupOperatorType.And};
			if (fromDate.HasValue)
			{
				theCriteria.Operands.Add(new BinaryOperator(Shipping.Fields.ShipMainDate.PropertyName, fromDate.Value, BinaryOperatorType.GreaterOrEqual));
			}
			if (toDate.HasValue)
			{
				theCriteria.Operands.Add(new BinaryOperator(Shipping.Fields.ShipMainDate.PropertyName, toDate.Value, BinaryOperatorType.LessOrEqual));
			}
			if (customer.HasValue)
			{
				theCriteria.Operands.Add(new BinaryOperator(Shipping.Fields.ShipMainCustID.CustomerID.PropertyName, customer.Value, BinaryOperatorType.Equal));
			}

			using (XPCollection<Shipping> receivedList = new XPCollection<Shipping>(Session.DefaultSession, theCriteria))
			{
				foreach (Shipping record in receivedList)
				{
					m_PalletTransactionList.Add(new PalletTransaction(record.ShipMainDate, record.ShipMainCustID.CustomerID, record.ShipMainCustID.CustomerName, null, record.intDestination.ShippingName, record.ShipMainBOL.ToString(), 0, record.sngTotalPallets));
				}
			}

		}


	}

}