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
	public partial class TransportationXtraReport
	{

		public TransportationXtraReport()
		{
			InitializeComponent();
		}

		private void expirationDateDetailXrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (expirationDateDetailXrLabel.Tag == null)
			{
				expirationDateDetailXrLabel.Text = GetCurrentColumnValue("ExpirationDate").ToString();
			}
			else
			{
				expirationDateDetailXrLabel.Text = Microsoft.VisualBasic.Strings.Format(GetCurrentColumnValue("ExpirationDate"), expirationDateDetailXrLabel.Tag.ToString());
			}

		}

	}
}