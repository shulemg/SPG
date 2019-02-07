//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using DXDAL.SPGData;

namespace SuperiorPackGroup
{
	public class BomDemandSummary
	{

		public Items ItemID {get; set;}
		public string ItemType {get; set;}
		public ItemPool PoolItemID {get; set;}
		public double LocalQuantityOnHand {get; set;}
		public double NonLocalQuantityOnHand {get; set;}
		//Public Property NonLocalPalletsQuantityOnHand As Double
		public double QuantityOnScheduledProjects {get; set;}
		public double QuantityOnUnscheduledProjects {get; set;}
		public string CustomerName {get; set;}
		public double QuantityOnHand
		{
			get
			{
				return LocalQuantityOnHand + NonLocalQuantityOnHand;
			}
		}
		public double BomDemandShortage
		{
			get
			{
				return Math.Max(QuantityOnScheduledProjects - QuantityOnHand, 0);
			}
		}

		public double TotalBomDemand
		{
			get
			{
				return QuantityOnScheduledProjects + QuantityOnUnscheduledProjects;
			}
		}
		public double BomDemandLocalShortage
		{
			get
			{
				return Math.Max(TotalBomDemand - LocalQuantityOnHand, 0);
			}
		}
		public double TotalBomDemandShortage
		{
			get
			{
				return Math.Max(TotalBomDemand - QuantityOnHand, 0);
			}
		}
		public double NonLocalPalletsQuantityOnHand
		{
			get
			{
				try
				{
					if (ItemID.intUnitsPerPallet == 0)
					{
						return 0;
					}
					return BomDemandLocalShortage / ItemID.intUnitsPerPallet;
				}
				catch
				{
				}
//INSTANT C# NOTE: Inserted the following 'return' since all code paths must return a value in C#:
				return 0;
			}
		}


		//used for summary report to find the bom demand in the collection
		public string DemandKey
		{
			get
			{
				if (ItemID != null)
				{
					if (string.IsNullOrEmpty(ItemType))
					{
						return string.Format("{0}{1}", ItemID.ItemType, ItemID.ItemID);
					}
					else
					{
						return string.Format("{0}{1}", ItemType, ItemID.ItemID);
					}
				}
				if (PoolItemID != null)
				{
					return string.Format("PI{0}", PoolItemID.Oid);
				}
				return string.Empty;
			}
		}

		public string ItemCode
		{
			get
			{
				if (ItemID != null)
				{
					return ItemID.ItemCode;
				}
				if (PoolItemID != null)
				{
					return PoolItemID.PoolCode;
				}
				return string.Empty;
			}
		}

		public string ItemDescription
		{
			get
			{
				if (ItemID != null)
				{
					return ItemID.ItemDescription;
				}
				if (PoolItemID != null)
				{
					return PoolItemID.PoolDescription;
				}
				return string.Empty;
			}
		}

	}

}