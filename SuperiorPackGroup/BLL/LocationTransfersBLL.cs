//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using DXDAL.SPGData;
using DevExpress.Data.Filtering;

namespace SuperiorPackGroup
{
	public class LocationTransfersBLL
	{

		public static bool ValidateRecord(int? transferNumber, int? fromLocationID, int? toLocationID, int? carrierID, LocationTransfers transferRecord, DevExpress.Xpo.Session session)
		{

			if (fromLocationID.HasValue == false || toLocationID.HasValue == false || carrierID.HasValue == false)
			{
				return false;
			}

			if (fromLocationID.Value == toLocationID.Value)
			{
				return false;
			}

			if (transferNumber.HasValue == false || transferNumber.Value == 0)
			{
				int? maxTransferNumber = (int?)session.Evaluate<LocationTransfers>(new AggregateOperand("", "TransferNumber", Aggregate.Max), null);
				if (maxTransferNumber.HasValue)
				{
					transferNumber = maxTransferNumber + 1;
				}
				else
				{
					transferNumber = 1;
				}

				transferRecord.TransferNumber = transferNumber.Value;
			}

			return true;

		}


	}

}