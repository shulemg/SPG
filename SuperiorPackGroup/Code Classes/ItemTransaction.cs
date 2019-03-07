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
	public class ItemTransaction
	{

		/// <summary>
		/// Initializes a new instance of the ItemTransaction class.
		/// </summary>
		/// <param name="transactionDate"></param>
		/// <param name="transactionItemCode"></param>
		/// <param name="transactionItemDescription"></param>
		/// <param name="transactionType"></param>
		/// <param name="quantity"></param>
		public ItemTransaction(DateTime transactionDate, string transactionItemCode, string transactionItemDescription, ItemTransactionType transactionType, double quantity)
		{

			_transactionDate = transactionDate;
			_transactionItemCode = transactionItemCode;
			_transactionItemDescription = transactionItemDescription;
			_transactionType = transactionType;
			_quantity = quantity;

		}

		public ItemTransaction()
		{

		}


		private DateTime _transactionDate;
		public DateTime TransactionDate
        {
            get => _transactionDate;
            set => _transactionDate = value;
        }

        private string _transactionItemCode;
		public string TransactionItemCode
        {
            get => _transactionItemCode;
            set => _transactionItemCode = value;
        }

        private string _transactionItemDescription;
		public string TransactionItemDescription
        {
            get => _transactionItemDescription;
            set => _transactionItemDescription = value;
        }

        private ItemTransactionType _transactionType;
		public ItemTransactionType TransactionType
        {
            get => _transactionType;
            set => _transactionType = value;
        }

        private double _quantity;
		public double Quantity
        {
            get => _quantity;
            set => _quantity = value;
        }

    }


}