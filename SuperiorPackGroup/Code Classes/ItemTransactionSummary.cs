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
	public class ItemTransactionSummary
	{

		/// <summary>
		/// Initializes a new instance of the ItemTransactionSummary class.
		/// </summary>
		public ItemTransactionSummary(string customerName, string itemCode, string itemDescription, string itemType, double produced, double usedInProduction, double shipped, double received, double adjusted)
		{

			CustomerName = customerName;
			ItemCode = itemCode;
			ItemDescription = itemDescription;
			ItemType = itemType;
			Produced = produced;
			UsedInProduction = usedInProduction;
			Shipped = shipped;
			Received = received;
			Adjusted = adjusted;

		}

		public ItemTransactionSummary()
		{

		}

		public string CustomerName {get; set;}
		public string ItemCode {get; set;}
		public string ItemDescription {get; set;}
		public string ItemType {get; set;}
		public double Produced {get; set;}
		public double UsedInProduction {get; set;}
		public double Shipped {get; set;}
		public double Received {get; set;}
		public double Adjusted {get; set;}

	}

}