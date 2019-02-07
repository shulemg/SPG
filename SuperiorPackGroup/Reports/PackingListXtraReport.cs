//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using System.Text;
using DXDAL;

namespace SuperiorPackGroup
{
	public partial class PackingListXtraReport
	{

		public PackingListXtraReport()
		{
			InitializeComponent();
		}

		private void fromXrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (reportTitleXrLabel.Text == "Receiving List")
			{
				fromXrLabel.Text = string.Format("{0}{1}{2}{1}{3}", GetCurrentColumnValue("CustomerName").ToString(), Environment.NewLine, GetCurrentColumnValue("Address").ToString(), GetCurrentColumnValue("Address2").ToString());
			}
			else
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
		}

		private void toXrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			try
			{
				if (reportTitleXrLabel.Text == "Receiving List")
				{
					if (locationId.Text == "001")
					{
						toXrLabel.Text = $"Superior Pack Group{Environment.NewLine}2 Bailey Farm Road{Environment.NewLine}Harriman, N.Y. 10926";
					}
					else if (locationId.Text == "002")
					{
						toXrLabel.Text = $"Superior Pack Group{Environment.NewLine}19 Industry Drive suite #104{Environment.NewLine}Mountainville, NY 10953";
					}
				}
				else
				{
						toXrLabel.Text = string.Format("{0}{1}{2}{1}{3}", GetCurrentColumnValue("ShippingName").ToString(), Environment.NewLine, GetCurrentColumnValue("ShippingAddress").ToString(), GetCurrentColumnValue("ShippingAddress2").ToString());
				}
			}
			catch
			{
				toXrLabel.Text = "";
			}

		}

		private void returnsGroupHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
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
			catch
			{
				e.Cancel = true;
			}

		}

		private void totalPalletWeightXrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			totalPalletWeightXrLabel.Text = (Convert.ToDouble(GetCurrentColumnValue("sngTotalPallets")) * 40).ToString();

		}

		private void itemDescriptionXrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			try
			{
				itemDescriptionXrLabel.Text = (GetCurrentColumnValue("ItemDescription") == null ? null : Convert.ToString(GetCurrentColumnValue("ItemDescription"))) + Environment.NewLine + (GetCurrentColumnValue("Note") == null ? null : Convert.ToString(GetCurrentColumnValue("Note")));
			}
			catch
			{

			}

		}

		private void totalWeightXrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (reportTitleXrLabel.Text == "Receiving List")
			{
				totalWeightXrLabel.Text = (Convert.ToDouble(itemTotalWeightXrLabel.Summary.GetResult()) + Convert.ToDouble(GetCurrentColumnValue("sngTotalPallets")) * 40).ToString("n1");
			}

		}

		private void wheelsChockedXrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (!Convert.IsDBNull(GetCurrentColumnValue("WheelsChocked")))
			{
				wheelsChockedXrLabel.Text = Enum.GetName(typeof(ThreeWayYesNo), GetCurrentColumnValue("WheelsChocked"));
			}
		}

		private void foreignSubstanceXrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (!Convert.IsDBNull(GetCurrentColumnValue("ForeignSubstance")))
			{
				foreignSubstanceXrLabel.Text = Enum.GetName(typeof(ThreeWayYesNo), GetCurrentColumnValue("ForeignSubstance"));
			}

		}

		private void insectActivityXrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (!Convert.IsDBNull(GetCurrentColumnValue("InsectActivity")))
			{
				insectActivityXrLabel.Text = Enum.GetName(typeof(ThreeWayYesNo), GetCurrentColumnValue("InsectActivity"));
			}

		}

		private void correctPalletsXrLabel_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
		{

			if (!Convert.IsDBNull(GetCurrentColumnValue("CorrectPallets")))
			{
				correctPalletsXrLabel.Text = Enum.GetName(typeof(ThreeWayYesNo), GetCurrentColumnValue("CorrectPallets"));
			}

		}

	}
}