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

namespace SuperiorPackGroup
{
	public class LotCodeValidator
	{

		public static bool ValidateByItem(Items item, string lot, bool ValidateFormat)
		{
			SortingCollection sortCollection = new SortingCollection();
			LotCodeFormatSections codeSection = null;
//INSTANT C# NOTE: Commented this declaration since looping variables in 'foreach' loops are declared in the 'foreach' header in C#:
//			Dim sectionSettings As LotCodeSectionSettings
			string sectionValue = null;
			int sectionValueNum = 0;
			int valuePosition = 0;

			if (!(item.RequiresLotCodes ?? false))
			{
				return true;
			}

			if ((lot == null) || string.IsNullOrEmpty(lot))
			{
				return false;
			}

			if (!ValidateFormat)
			{
				return true;
			}

			if (item.DefaultLotCodeFormat == null)
			{
				return true;
			}

			sortCollection.Add(new SortProperty("SectionPosition", DevExpress.Xpo.DB.SortingDirection.Ascending));
			item.DefaultLotCodeFormat.FormatSections.Sorting = sortCollection;

			foreach (LotCodeFormatSections codeSectionWithinLoop in item.DefaultLotCodeFormat.FormatSections)
			{
			codeSection = codeSectionWithinLoop;

				if (lot.Length < valuePosition + codeSectionWithinLoop.SectionLength)
				{
					return false;
				}

				sectionValue = lot.Substring(valuePosition, codeSectionWithinLoop.SectionLength);

				foreach (LotCodeSectionSettings sectionSettings in codeSectionWithinLoop.SectionSettings)
				{
					if (sectionSettings.SettingName == "NumberRangeFrom")
					{
						if (!int.TryParse(sectionValue, out sectionValueNum) || sectionValueNum < int.Parse(sectionSettings.SettingValue))
						{
							return false;
						}
					}
					if (sectionSettings.SettingName == "NumberRangeTo")
					{
						if (!int.TryParse(sectionValue, out sectionValueNum) || sectionValueNum > int.Parse(sectionSettings.SettingValue))
						{
							return false;
						}
					}
				}

				valuePosition += codeSectionWithinLoop.SectionLength;

			}

			return true;
		}
		public static bool ValidateByItemID(int itemId, string lot, bool ValidateFormat)
		{
			Items item = Session.DefaultSession.GetObjectByKey<Items>(itemId);

			if (item == null)
			{
				return false;
			}

			return ValidateByItem(item, lot, ValidateFormat);

		}



	}

}