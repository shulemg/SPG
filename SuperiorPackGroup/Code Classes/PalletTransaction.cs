//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace SuperiorPackGroup
{
	public class PalletTransaction
	{

		/// <summary>
		/// Initializes a new instance of the PalletTransaction class.
		/// </summary>
		/// <param name="transactionDate"></param>
		/// <param name="customerID"></param>
		/// <param name="customerName"></param>
		/// <param name="vendorName"></param>
		/// <param name="shippingDestinationName"></param>
		/// <param name="transactionBOL"></param>
		/// <param name="received"></param>
		/// <param name="shipped"></param>
		public PalletTransaction(DateTime transactionDate, int customerID, string customerName, string vendorName, string shippingDestinationName, string transactionBOL, double received, double shipped)
		{

			m_TransactionDate = transactionDate;
			m_CustomerID = customerID;
			m_CustomerName = customerName;
			m_VendorName = vendorName;
			m_ShippingDestinationName = shippingDestinationName;
			m_TransactionBOL = transactionBOL;
			m_Received = received;
			m_Shipped = shipped;

		}

		public PalletTransaction()
		{

		}

		private DateTime m_TransactionDate;
		public DateTime TransactionDate
        {
            get => m_TransactionDate;
            set => m_TransactionDate = value;
        }

        private int m_CustomerID;
		public int CustomerID
        {
            get => m_CustomerID;
            set => m_CustomerID = value;
        }

        private string m_CustomerName;
		public string CustomerName
        {
            get => m_CustomerName;
            set => m_CustomerName = value;
        }

        private string m_VendorName;
		public string VendorName
        {
            get => m_VendorName;
            set => m_VendorName = value;
        }

        private string m_ShippingDestinationName;
		public string ShippingDestinationName
        {
            get => m_ShippingDestinationName;
            set => m_ShippingDestinationName = value;
        }

        private string m_TransactionBOL;
		public string TransactionBOL
        {
            get => m_TransactionBOL;
            set => m_TransactionBOL = value;
        }

        private double? m_Received;
		public double? Received
        {
            get => m_Received;
            set => m_Received = value;
        }

        private double? m_Shipped;
		public double? Shipped
        {
            get => m_Shipped;
            set => m_Shipped = value;
        }

    }

}