//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using System.Text;

namespace SuperiorPackGroup
{
	public partial class BillOfLadingXtraReport
	{

		public BillOfLadingXtraReport()
		{
			InitializeComponent();
		}

		private void fromXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			StringBuilder str = new StringBuilder(string.Empty);
			if (Convert.ToBoolean(GetCurrentColumnValue("Shipper")))
			{
				str.Append(string.Format("{0}{1}C/O Superior Pack Group", GetCurrentColumnValue("CustomerName").ToString(), Environment.NewLine));
			}
			else
			{
				str.Append("Superior Pack Group");
			}

			if (locationId.Text == "001")
			{
				str.Append(string.Format($"{Environment.NewLine}2 Bailey Farm Road{Environment.NewLine}Harriman, N.Y. 10926"));
			}
			else if (locationId.Text == "002")
			{
				str.Append(string.Format($"{Environment.NewLine}19 Industry Drive suite #104{Environment.NewLine}Mountainville, NY 10953"));
			}

			fromXrLabel.Text = str.ToString();

		}

		private void toXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			try
			{
				toXrLabel.Text = string.Format("{0}{1}{2}{1}{3}", GetCurrentColumnValue("ShippingName").ToString(), Environment.NewLine, GetCurrentColumnValue("ShippingAddress").ToString(), GetCurrentColumnValue("ShippingAddress2").ToString());
			}
			catch (Exception ex)
			{
				toXrLabel.Text = "";
			}

		}

		private void returnsGroupHeader_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			try
			{
				if (GetCurrentColumnValue("ShippingType").ToString() == "General")
				{
					e.Cancel = true;
				}
				else
				{
					e.Cancel = false;
				}
			}
			catch (Exception ex)
			{
				e.Cancel = true;
			}

		}

		private void totalPalletWeightXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			totalPalletWeightXrLabel.Text = (Convert.ToDouble(GetCurrentColumnValue("sngTotalPallets")) * 65).ToString();

		}

		private void itemDescriptionXrLabel_BeforePrint(System.Object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			try
			{
				itemDescriptionXrLabel.Text = (GetCurrentColumnValue("ItemDescription") == null ? null : Convert.ToString(GetCurrentColumnValue("ItemDescription"))) + Environment.NewLine + (GetCurrentColumnValue("Note") == null ? null : Convert.ToString(GetCurrentColumnValue("Note")));
			}
			catch
			{
			}

		}

	}
}