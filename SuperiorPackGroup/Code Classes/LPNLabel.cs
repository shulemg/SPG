//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using DXDAL.SPGData;
using System.Text;
using System.Threading;
using System.Drawing.Printing;
using DevExpress.Xpo;

namespace SuperiorPackGroup
{
	public class LPNLabel
	{

		private static string lpnTextLabel;

		public static int GetNextLPNNumber(Customers customer)
		{

			int nextLPN = 0;
			//Dim i As Integer = 0

			//While i < 50
			//Try
			customer.Reload();
			if (customer.NextLPNNumber > 0)
			{
				nextLPN = customer.NextLPNNumber;
				customer.NextLPNNumber += 1;
				customer.Save();
			}
			else
			{
				if (customer.FirstLPNNumber.HasValue)
				{
					nextLPN = customer.FirstLPNNumber.Value;
					customer.NextLPNNumber = nextLPN + 1;
					customer.Save();
				}
			}
			//i = 50
			//Catch
			//    Thread.Sleep(100)
			//    i += 1
			//End Try
			//End While

			if (nextLPN > customer.LastLPNNumber)
			{
				MessageBox.Show("You ran out of LPN numbers, you must provide a different range of numbers before creating a new LPN number");
				nextLPN = 0;
			}

			if (nextLPN == customer.LastLPNNumber)
			{
				MessageBox.Show("You used now your last LPN number, please provide a different range of numbers before creating a new LPN number");
			}

			return nextLPN;

		}
		public static int GetNextLPNNumber(int customerId)
		{
			Customers customer = Session.DefaultSession.GetObjectByKey<Customers>(customerId);
			return GetNextLPNNumber(customer);
		}



		private static void CreateLargeLPNLabel(Session session, byte horizontalAdjustment, byte verticalAdjustment, Inventory inventoryRecord, int lpnBaseNumber, byte printCopies, string largeCode, string lpnNumber)
		{

			int Description1End = 0;

			StringBuilder LPNPrintOutput = new StringBuilder();
			string inventoryItemDescription = inventoryRecord.InventoryItemID.ItemDescription;

			LPNPrintOutput.Append(string.Format("^XA{0}^SZ2^JMA{0}^MCY^PMN{0}^PW802{0}~JSN{0}^JZY{0}^LH{1},{2}^LRN{0}^XZ{0}", Environment.NewLine, horizontalAdjustment, verticalAdjustment));
			LPNPrintOutput.Append(string.Format("^XA{0}^CI0{0}", Environment.NewLine));
			LPNPrintOutput.Append(string.Format("^FT38,367{1}^A0B,23,20^FDPlant # - ^FS{1}^FT38,286{1}^A0B,23,20^FD{0}^FS{1}", inventoryRecord.InventoryItemID.ItemCustomerID.PlantCode, Environment.NewLine));
			LPNPrintOutput.Append(string.Format("^FT35,1270{1}^A0B,23,24^FDLICENSE PLATE NUMBER^FS{1}^FT83,1270{1}^A0B,60,86^FD{0}^FS{1}", lpnNumber, Environment.NewLine));
			LPNPrintOutput.Append(string.Format("^FO88,100{1}^BY7^BCB,160,N,N^FD>:{0}^FS{1}", lpnNumber, Environment.NewLine));
			LPNPrintOutput.Append(string.Format("^FO251,78{0}^GB0,1397,4^FS{0}^FO253,776{0}^GB68,0,2^FS{0}", Environment.NewLine));
			if (string.IsNullOrEmpty(inventoryItemDescription) == false)
			{
				if (inventoryItemDescription.Length > 36)
				{
					Description1End = inventoryItemDescription.LastIndexOf(" ", 36);
					LPNPrintOutput.Append(string.Format("^FT283,774{1}^A0B,31,43^FD{0}^FS{1}", inventoryItemDescription.Substring(0, Description1End), Environment.NewLine));
				}
				else
				{
					LPNPrintOutput.Append(string.Format("^FT283,774{1}^A0B,31,43^FD{0}^FS{1}", inventoryItemDescription, Environment.NewLine));
				}
			}
			if (string.IsNullOrEmpty(inventoryItemDescription) == false)
			{
				if (inventoryItemDescription.Length >= Description1End + 35)
				{
					LPNPrintOutput.Append(string.Format("^FT313,770{1}^A0B,31,43^FD{0}^FS{1}", inventoryItemDescription.Substring(Description1End + 1, inventoryItemDescription.LastIndexOf(" ", 35)), Environment.NewLine));
				}
				else if (inventoryItemDescription.Length > 36)
				{
					LPNPrintOutput.Append(string.Format("^FT313,770{1}^A0B,31,43^FD{0}^FS{1}", inventoryItemDescription.Substring(Description1End + 1), Environment.NewLine));
				}
			}
			LPNPrintOutput.Append(string.Format("^FT275,1462{1}^A0B,23,32^FDMATERIAL NUMBER - DESCRIPTION^FS{1}^FT318,1462{1}^A0B,56,77^FD{0}^FS{1}", inventoryRecord.InventoryItemID.ItemCode, Environment.NewLine));
			LPNPrintOutput.Append(string.Format("^FO321,487{0}^GB0,988,2^FS{0}^FO321,1131{0}^GB220,0,2^FS{0}^FO321,80{0}^GB0,406,2^FS{0}", Environment.NewLine));
			LPNPrintOutput.Append(GetLPNINventoryRecords(session, lpnBaseNumber, inventoryRecord.InventoryItemID.ItemCustomerID.CustomerID, inventoryRecord.InventoryDate, inventoryRecord));
			LPNPrintOutput.Append(string.Format("^FO539,77{0}^GB0,1397,2^FS{0}^FO542,771{0}^GB76,0,2^FS{0}^FO542,1131{0}^GB76,0,2^FS{0}^FO322,486{0}^GB296,0,2^FS{0}", Environment.NewLine));
			LPNPrintOutput.Append(string.Format("^FT561,476{1}^A0B,23,32^FDCREATED TIMESTAMP^FS{1}^FT604,472{1}^A0B,28,39^FD{0}^FS{1}", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"), Environment.NewLine));
			LPNPrintOutput.Append(string.Format("^FT561,759{1}^A0B,23,32^FDUOM^FS{1}^FT611,759{1}^A0B,56,77^FD{0}^FS{1}", inventoryRecord.InventoryItemID.strUnitOfMeasure, Environment.NewLine));
			LPNPrintOutput.Append(string.Format("^FT561,1120{1}^A0B,23,32^FDPRODUCTION DATE^FS{1}^FT611,1120{1}^A0B,51,70^FD{0}^FS{1}", inventoryRecord.InventoryDate.ToString("M/d/yyyy"), Environment.NewLine));
			LPNPrintOutput.Append(string.Format("^FT561,1462{1}^A0B,23,32^FDTOTAL QUANTITY^FS{1}^FT611,1462{1}^A0B,51,70^FD{0}^FS{1}", InventoryBLL.GetLPNQuantity(session, lpnBaseNumber, inventoryRecord.InventoryItemID.ItemCustomerID.CustomerID, inventoryRecord.InventoryDate, inventoryRecord).ToString(), Environment.NewLine));
			LPNPrintOutput.Append(string.Format("^FO617,78{0}^GB0,1397,2^FS{0}", Environment.NewLine));
			LPNPrintOutput.Append(string.Format("^FO623,80{1}^BY3^BCB,127,N,N^FD>;{0}^FS{1}", largeCode, Environment.NewLine));
			LPNPrintOutput.Append(string.Format("^PQ{0},0,1,Y{1}^XZ", printCopies, Environment.NewLine));

			lpnTextLabel = LPNPrintOutput.ToString();

		}

		public static string CreateLPNLabel(Session session, Inventory inventoryRecord, bool shortLPN)
		{

			bool addMForMultiple = false;

			if (VerifyLPNSettings(inventoryRecord.InventoryItemID.ItemCustomerID))
			{
				int LPNBaseNumber = 0;
				CompanySettings LPNSettings = CompanySettingsBLL.GetSettings();

				if (inventoryRecord.LPNNumber.HasValue && inventoryRecord.LPNNumber.Value > 0)
				{
					LPNBaseNumber = inventoryRecord.LPNNumber.Value;
				}
				else
				{
					LPNBaseNumber = GetNextLPNNumber(inventoryRecord.InventoryItemID.ItemCustomerID);
					inventoryRecord.LPNNumber = LPNBaseNumber;
					inventoryRecord.FullLPNNumber = inventoryRecord.InventoryItemID.ItemCustomerID.LPNPrefix + ("0000000000" + LPNBaseNumber.ToString()).Substring(("0000000000" + LPNBaseNumber.ToString()).Length - inventoryRecord.InventoryItemID.ItemCustomerID.LastLPNNumber.ToString().Length);
					inventoryRecord.Save();
				}

				if (shortLPN == false && InventoryBLL.IsMultiLPN(session, LPNBaseNumber, inventoryRecord.InventoryItemID.ItemCustomerID.CustomerID, inventoryRecord.InventoryDate))
				{
					addMForMultiple = true;
				}

				string largeCode = GetLPNLargeCode(session, inventoryRecord, addMForMultiple);
				string LPNSuffix = ("0000000000" + LPNBaseNumber.ToString()).Substring(("0000000000" + LPNBaseNumber.ToString()).Length - inventoryRecord.InventoryItemID.ItemCustomerID.LastLPNNumber.ToString().Length);
				string LPNNumber = inventoryRecord.InventoryItemID.ItemCustomerID.LPNPrefix + LPNSuffix;

				if (LPNBaseNumber == 0)
				{
					return string.Empty;
				}

				if (shortLPN)
				{
					CreateShortLPNLabel(session, LPNSettings.LPNHorizontalAdjustment, LPNSettings.LPNVerticalAdjustment, inventoryRecord, LPNBaseNumber, LPNSettings.LPNPrintCopies, largeCode, LPNNumber);
				}
				else
				{
					CreateLargeLPNLabel(session, LPNSettings.LPNHorizontalAdjustment, LPNSettings.LPNVerticalAdjustment, inventoryRecord, LPNBaseNumber, LPNSettings.LPNPrintCopies, largeCode, LPNNumber);
				}

				return lpnTextLabel;
			}

			return string.Empty;

		}

		private static void CreateShortLPNLabel(Session session, byte horizontalAdjustment, byte verticalAdjustment, Inventory inventoryRecord, int lpnBaseNumber, byte printCopies, string largeCode, string lpnNumber)
		{

			int Description1End = 0;

			StringBuilder LPNPrintOutput = new StringBuilder();
			string inventoryItemDescription = inventoryRecord.InventoryItemID.ItemDescription;

			LPNPrintOutput.Append(string.Format("^XA{0}^SZ2^JMA{0}^MCY^PMN{0}^PW802{0}~JSN{0}^JZY{0}^LH{1},{2}^LRN{0}^XZ{0}", Environment.NewLine, horizontalAdjustment, verticalAdjustment));
			LPNPrintOutput.Append(string.Format("^XA{0}^FT452,1172{0}^CI0{0}", Environment.NewLine));
			LPNPrintOutput.Append(string.Format("        ^A0B,62,85^FD{0}^FS{1}", inventoryRecord.InventoryItemID.ItemCode, Environment.NewLine));
			LPNPrintOutput.Append("        ^FT537,829" + Environment.NewLine);
			LPNPrintOutput.Append(string.Format("        ^A0B,56,77^FD{0}^FS{1}", inventoryRecord.InventoryItemID.strUnitOfMeasure, Environment.NewLine));
			LPNPrintOutput.Append("        ^FT482,829" + Environment.NewLine);
			LPNPrintOutput.Append("        ^A0B,23,32^FDUOM^FS" + Environment.NewLine);
			LPNPrintOutput.Append("        ^FT482,1172" + Environment.NewLine);
			LPNPrintOutput.Append("        ^A0B,23,32^FDQUANTITY^FS" + Environment.NewLine);
			LPNPrintOutput.Append("        ^FT537,1171" + Environment.NewLine);
			LPNPrintOutput.Append(string.Format("        ^A0B,56,77^FD{0}^FS{1}", InventoryBLL.GetLPNQuantity(session, lpnBaseNumber, inventoryRecord.InventoryItemID.ItemCustomerID.CustomerID, inventoryRecord.InventoryDate, inventoryRecord).ToString(), Environment.NewLine));
			LPNPrintOutput.Append("        ^FO372,78" + Environment.NewLine);
			LPNPrintOutput.Append("        ^GB0,1097,4^FS" + Environment.NewLine);
			LPNPrintOutput.Append("        ^FO462,487" + Environment.NewLine);
			LPNPrintOutput.Append("        ^GB0,688,2^FS" + Environment.NewLine);
			LPNPrintOutput.Append("        ^FO539,841" + Environment.NewLine);
			LPNPrintOutput.Append("        ^GB76,0,2^FS" + Environment.NewLine);
			LPNPrintOutput.Append("        ^FO539,460" + Environment.NewLine);
			LPNPrintOutput.Append("        ^GB76,0,2^FS" + Environment.NewLine);
			LPNPrintOutput.Append("        ^FO614,78" + Environment.NewLine);
			LPNPrintOutput.Append("        ^GB0,1097,2^FS" + Environment.NewLine);
			LPNPrintOutput.Append("        ^FO538,77" + Environment.NewLine);
			LPNPrintOutput.Append("        ^GB0,1097,2^FS" + Environment.NewLine);
			LPNPrintOutput.Append("        ^FT426,474" + Environment.NewLine);
			if (string.IsNullOrEmpty(inventoryItemDescription) == false)
			{
				if (inventoryItemDescription.Length > 20)
				{
					Description1End = inventoryRecord.InventoryItemID.ItemDescription.LastIndexOf(" ", 20);
					LPNPrintOutput.Append(string.Format("        ^A0B,31,43^FD{0}^FS{1}", inventoryItemDescription.Substring(0, Description1End), Environment.NewLine));
				}
				else
				{
					LPNPrintOutput.Append(string.Format("        ^A0B,31,43^FD{0}^FS{1}", inventoryItemDescription, Environment.NewLine));
				}
			}
			else
			{
				LPNPrintOutput.Append(string.Format("        ^A0B,31,43^FD{0}^FS{1}", string.Empty, Environment.NewLine));
			}
			LPNPrintOutput.Append("        ^FT393,1172" + Environment.NewLine);
			LPNPrintOutput.Append("        ^A0B,23,32^FDMATERIAL NUMBER^FS" + Environment.NewLine);
			LPNPrintOutput.Append("        ^FT495,474" + Environment.NewLine);
			LPNPrintOutput.Append("        ^A0B,23,32^FDGENERAL STOCKING LOCATION^FS" + Environment.NewLine);
			LPNPrintOutput.Append("        ^FT558,1172" + Environment.NewLine);
			LPNPrintOutput.Append("        ^A0B,23,32^FDPRODUCTION DATE^FS" + Environment.NewLine);
			LPNPrintOutput.Append("        ^FT558,829" + Environment.NewLine);
			LPNPrintOutput.Append("        ^A0B,23,32^FDDATE CODE^FS" + Environment.NewLine);
			LPNPrintOutput.Append("        ^FT608,829" + Environment.NewLine);
			//LPNPrintOutput.Append(String.Format("        ^A0B,51,70^FD{0}^FS{1}", GetDateCode(inventoryRecord), vbCrLf))
			//If isMulti Then
			//    LPNPrintOutput.Append(String.Format("        ^A0B,51,70^FD{0}M^FS{1}", inventoryRecord.Lot, vbCrLf))
			//Else
			LPNPrintOutput.Append(string.Format("        ^A0B,51,70^FD{0}^FS{1}", inventoryRecord.Lot, Environment.NewLine));
			//End If
			LPNPrintOutput.Append("        ^FT534,474" + Environment.NewLine);
			LPNPrintOutput.Append(string.Format("        ^A0B,39,54^FD{0}^FS{1}", string.Empty, Environment.NewLine));
			LPNPrintOutput.Append("        ^FO121,88" + Environment.NewLine);
			LPNPrintOutput.Append(string.Format("        ^BY8^BCB,241,N,Y^FD>:{0}^FS{1}", lpnNumber, Environment.NewLine));
			LPNPrintOutput.Append("        ^FT113,1189" + Environment.NewLine);
			LPNPrintOutput.Append(string.Format("        ^A0B,68,94^FD{0}^FS{1}", lpnNumber, Environment.NewLine));
			LPNPrintOutput.Append("        ^FT38,347" + Environment.NewLine);
			LPNPrintOutput.Append("        ^A0B,23,20^FDPlant # - ^FS" + Environment.NewLine);
			LPNPrintOutput.Append("        ^FO615,80" + Environment.NewLine);
			LPNPrintOutput.Append(string.Format("        ^BY4^BCB,127,N,N^FD>;{0}^FS{1}", largeCode, Environment.NewLine));
			LPNPrintOutput.Append("        ^FT601,448" + Environment.NewLine);
			LPNPrintOutput.Append(string.Format("        ^A0B,28,39^FD{0}^FS{1}", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"), Environment.NewLine));
			LPNPrintOutput.Append("        ^FO463,841" + Environment.NewLine);
			LPNPrintOutput.Append("        ^GB76,0,2^FS" + Environment.NewLine);
			LPNPrintOutput.Append("        ^FO374,486" + Environment.NewLine);
			LPNPrintOutput.Append("        ^GB165,0,2^FS" + Environment.NewLine);
			LPNPrintOutput.Append("        ^FT393,474" + Environment.NewLine);
			LPNPrintOutput.Append("        ^A0B,23,32^FDDESCRIPTION^FS" + Environment.NewLine);
			LPNPrintOutput.Append("        ^FT464,461" + Environment.NewLine);
			if (string.IsNullOrEmpty(inventoryItemDescription) == false)
			{
				if (inventoryItemDescription.Length >= 40)
				{
					LPNPrintOutput.Append(string.Format("        ^A0B,31,43^FD{0}^FS{1}", inventoryItemDescription.Substring(Description1End + 1, inventoryItemDescription.LastIndexOf(" ", 20)), Environment.NewLine));
				}
				else if (inventoryItemDescription.Length > 20)
				{
					LPNPrintOutput.Append(string.Format("        ^A0B,31,43^FD{0}^FS{1}", inventoryItemDescription.Substring(Description1End + 1), Environment.NewLine));
				}
				else
				{
					LPNPrintOutput.Append(string.Format("        ^A0B,31,43^FD{0}^FS{1}", string.Empty, Environment.NewLine));
				}
			}
			else
			{
				LPNPrintOutput.Append(string.Format("        ^A0B,31,43^FD{0}^FS{1}", string.Empty, Environment.NewLine));
			}
			LPNPrintOutput.Append("        ^FT38,1184" + Environment.NewLine);
			LPNPrintOutput.Append("        ^A0B,23,24^FDLICENSE PLATE NUMBER^FS" + Environment.NewLine);
			LPNPrintOutput.Append("        ^FT558,461" + Environment.NewLine);
			LPNPrintOutput.Append("        ^A0B,23,32^FDCREATED TIMESTAMP^FS" + Environment.NewLine);
			LPNPrintOutput.Append("        ^FT608,1172" + Environment.NewLine);
			LPNPrintOutput.Append(string.Format("        ^A0B,51,70^FD{0}^FS{1}", inventoryRecord.InventoryDate.ToString("M/d/yyyy"), Environment.NewLine));
			LPNPrintOutput.Append("        ^FO475,80" + Environment.NewLine);
			LPNPrintOutput.Append("        ^GB0,406,2^FS" + Environment.NewLine);
			LPNPrintOutput.Append("        ^FT38,131" + Environment.NewLine);
			LPNPrintOutput.Append(string.Format("        ^A0B,23,20^FD{0}^FS{1}", inventoryRecord.InventoryItemID.ItemCustomerID.PlantCode, Environment.NewLine));
			LPNPrintOutput.Append(string.Format("        ^PQ{0},0,1,Y{1}", printCopies, Environment.NewLine));
			LPNPrintOutput.Append("        ^XZ" + Environment.NewLine + Environment.NewLine + Environment.NewLine);

			lpnTextLabel = LPNPrintOutput.ToString();

		}

		private static string GetLPNINventoryRecords(Session session, int lpnBaseNumber, int customerID, DateTime inventoryDate, Inventory currentRecord)
		{

			const int position = 343;

			int i = 1;
			StringBuilder LPNPrintOutput = new StringBuilder();

			LPNPrintOutput.Append(string.Format("^FT{0},1462{1}^A0B,23,32^FDQUANTITY^FS{1}", position, Environment.NewLine));
			LPNPrintOutput.Append(string.Format("^FT{0},1119{1}^A0B,23,32^FDDATE CODE^FS{1}", position, Environment.NewLine));
			LPNPrintOutput.Append(string.Format("^FT{0},474{1}^A0B,23,32^FDEXPIRATION DATE^FS{1}", position, Environment.NewLine));

			foreach (Inventory record in InventoryBLL.GetLPNInventoryRecords(session, lpnBaseNumber, customerID, inventoryDate))
			{
				if (record != currentRecord && record.IsDeleted == false)
				{
					LPNPrintOutput.Append(string.Format("^FT{0},1462{2}^A0B,56,77^FD{1}^FS{2}", position + (i * 44), record.InventoryQuantity, Environment.NewLine));
					LPNPrintOutput.Append(string.Format("^FT{0},1119{2}^A0B,51,70^FD{1}^FS{2}", position + (i * 44), record.Lot, Environment.NewLine));
					if (record.ExpirationDate.HasValue)
					{
						LPNPrintOutput.Append(string.Format("^FT{0},474{2}^A0B,51,70^FD{1}^FS{2}", position + (i * 44), record.ExpirationDate.Value.ToString(record.InventoryItemID.ItemCustomerID.ExpirationDateFormat), Environment.NewLine));
					}
					i += 1;
					if (i == 4)
					{
						break;
					}
				}
			}

			LPNPrintOutput.Append(string.Format("^FT{0},1462{2}^A0B,56,77^FD{1}^FS{2}", position + (i * 44), currentRecord.InventoryQuantity, Environment.NewLine));
			LPNPrintOutput.Append(string.Format("^FT{0},1119{2}^A0B,51,70^FD{1}^FS{2}", position + (i * 44), currentRecord.Lot, Environment.NewLine));
			if (currentRecord.ExpirationDate.HasValue)
			{
				LPNPrintOutput.Append(string.Format("^FT{0},474{2}^A0B,51,70^FD{1}^FS{2}", position + (i * 44), currentRecord.ExpirationDate.Value.ToString(currentRecord.InventoryItemID.ItemCustomerID.ExpirationDateFormat), Environment.NewLine));
			}

			return LPNPrintOutput.ToString();

		}

		private static bool VerifyLPNSettings(Customers customer)
		{

			if (string.IsNullOrEmpty(customer.LPNPrefix))
			{
				MessageBox.Show(string.Format("There's no LPN Prefix set up for {0}.{1}You must set up all the LPN settings for {0} before generating an LPN Label.", customer.CustomerName, Environment.NewLine));
				return false;
			}

			if (customer.FirstLPNNumber.HasValue == false || customer.LastLPNNumber.HasValue == false || customer.FirstLPNNumber.Value < 1)
			{
				MessageBox.Show(string.Format("The number range for LPN numbers is not set up for {0}.{1}You must set up all the LPN settings for {0} before generating an LPN Label.", customer.CustomerName, Environment.NewLine));
				return false;
			}

			if (string.IsNullOrEmpty(customer.PlantCode))
			{
				MessageBox.Show(string.Format("There's no Plant Code set up for {0}.{1}You must set up all the LPN settings for {0} before generating an LPN Label.", customer.CustomerName, Environment.NewLine));
				return false;
			}

			if (string.IsNullOrEmpty(CompanySettingsBLL.GetLPNPrinter()))
			{
				MessageBox.Show(string.Format("There's no LPN Printer set up.{0}You must set up all the LPN settings before generating an LPN Label.", Environment.NewLine));
				return false;
			}

			return true;

		}

		private static string GetLPNLargeCode(Session session, Inventory inventoryRecord, bool isMulti)
		{

			string itemNumber = ("0000000000000" + inventoryRecord.InventoryItemID.ItemCode.Replace("-", "")).Substring(("0000000000000" + inventoryRecord.InventoryItemID.ItemCode.Replace("-", "")).Length - 13);
			string quantity = ("00000" + InventoryBLL.GetLPNQuantity(session, inventoryRecord.LPNNumber.Value, inventoryRecord.InventoryItemID.ItemCustomerID.CustomerID, inventoryRecord.InventoryDate, inventoryRecord).ToString()).Substring(("00000" + InventoryBLL.GetLPNQuantity(session, inventoryRecord.LPNNumber.Value, inventoryRecord.InventoryItemID.ItemCustomerID.CustomerID, inventoryRecord.InventoryDate, inventoryRecord).ToString()).Length - 5);
			string prodDate = inventoryRecord.InventoryDate.ToString("yyyyMMdd");

			// ">6" switches to code C for the alpha part of the barcode
			if (isMulti)
			{
				return string.Format("{0}{1}{2}>6{3}M", itemNumber, quantity, prodDate, inventoryRecord.Lot);
			}
			else
			{
				return string.Format("{0}{1}{2}>6{3}", itemNumber, quantity, prodDate, inventoryRecord.Lot);
			}


		}

		private static string GetDateCode(Inventory inventoryRecord)
		{

			bool overflow = inventoryRecord.InventoryDate.Day > 15;

			int seq1 = ((((inventoryRecord.InventoryDate.Year - 4) % 11) * 12 + inventoryRecord.InventoryDate.Month - 1) % 44) * 2 + 11;
			int seq2 = overflow ? seq1 + 1 : seq1;
			int pos2 = overflow ? inventoryRecord.InventoryDate.Day - 15 : inventoryRecord.InventoryDate.Day;

			return seq2.ToString() + "ABCDEFGHJKLMNPRS".Substring(pos2 - 1, 1) + inventoryRecord.InventoryItemID.ItemCustomerID.PlantCode.ToString() + inventoryRecord.Shift.ShiftName;

		}

		public static void SendLPNLabelToGenericPrinter(string printer, string textLabel)
		{
			//Dim s As String
			//Dim pd As New PrintDialog()

			//' You need a string to send.
			//s = "Hello, this is a test"
			//' Open the printer dialog box, and then allow the user to select a printer.
			//pd.PrinterSettings = New PrinterSettings()
			//If (pd.ShowDialog() = DialogResult.OK) Then
			RawPrinterHelper.SendStringToPrinter(printer, textLabel);
			//End If

		}

		private static void SendLPNLabelToPrinter(string printer)
		{

			PrintDocument document = new PrintDocument();
			document.PrinterSettings.PrinterName = printer;
			document.PrintPage += PrintingLPNLabel;
			document.Print();

		}

		private static void PrintingLPNLabel(object sender, PrintPageEventArgs e)
		{

			e.Graphics.DrawString(lpnTextLabel, new Font("Arial", 10), Brushes.Black, new Point(0, 0));

		}

	}

}