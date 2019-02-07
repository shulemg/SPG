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
	public partial class PalletTransactionXtraReport
	{

		public PalletTransactionXtraReport()
		{
			InitializeComponent();
		}

		private void xRLOverShippedTotal_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			xRLOverShippedTotal.Text = (Convert.ToDouble(shippedTotalXrLabel.Summary.GetResult()) - Convert.ToDouble(receivedTotalXRLabel.Summary.GetResult())).ToString();

		}

	}
}