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
	public partial class ItemTransactionXtraReport
	{

		public ItemTransactionXtraReport()
		{
			InitializeComponent();
		}

		private void balacneDetailXrLabel_SummaryCalculated(System.Object sender, DevExpress.XtraReports.UI.TextFormatEventArgs e)
		{

			e.Text = (Convert.ToDouble(e.Value) + Convert.ToDouble(openingBalanceParameter.Value)).ToString("#,##0.00");

		}

		private void ItemTransactionXtraReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (DataSource != null)
			{
				openingBalanceParameter.Value = ((ItemTransactionsList)DataSource).OpeningBalance;
			}

		}

	}
}