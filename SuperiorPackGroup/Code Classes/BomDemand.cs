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
	public class BomDemand
	{

		public Items ItemID {get; set;}
		public string ItemType {get; set;}
		public ItemPool PoolItemID {get; set;}
		public ProjectDetails ProjectDetailID {get; set;}
		public Project ProjectID {get; set;}
		public double QuantityOnHand {get; set;}
		public double QuantityOnScheduledProjects {get; set;}
		public double QuantityOnUnscheduledProjects {get; set;}
		public double QuantityRequiredForProject {get; set;}

		public double BomDemandShortage
		{
			get
			{
				return Math.Max(QuantityRequiredForProject - (QuantityOnHand - QuantityOnScheduledProjects), 0);
			}
		}

		public string CustomerPO
		{
			get
			{
				if (ProjectDetailID == null)
				{
					return string.Empty;
				}
				else
				{
					return ProjectDetailID.CustomerPO;
				}
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