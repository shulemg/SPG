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
	public class WeeklyProduction
	{

		public WeeklyProduction()
		{

		}

		public WeeklyProduction(string customerName, int itemID, string itemCode, string itemDescription, int requiredCases, int requiredBags, int producedMonday, int producedTuesday, int producedWednesday, int producedThursday, int producedFriday, int producedSaturday, int producedSunday, int scheduledMonday, int scheduledTuesday, int scheduledWednesday, int scheduledThursday, int scheduledFriday, int scheduledSaturday, int scheduledSunday, string productionWeek)
		{

			CustomerName = customerName;
			ItemID = itemID;
			ItemCode = itemCode;
			ItemDescription = itemDescription;
			RequiredCases = requiredCases;
			RequiredBags = requiredBags;
			ProducedMonday = producedMonday;
			ProducedTuesday = producedTuesday;
			ProducedWednesday = producedWednesday;
			ProducedThursday = producedThursday;
			ProducedFriday = producedFriday;
			ProducedSaturday = producedSaturday;
			ProducedSunday = producedSunday;
			ScheduledMonday = scheduledMonday;
			ScheduledTuesday = scheduledTuesday;
			ScheduledWednesday = scheduledWednesday;
			ScheduledThursday = scheduledThursday;
			ScheduledFriday = scheduledFriday;
			ScheduledSaturday = scheduledSaturday;
			ScheduledSunday = scheduledSunday;
			ProductionWeek = productionWeek;

		}

		public WeeklyProduction(string customerName, int itemID, string itemCode, string itemDescription, int requiredCases, int requiredBags, int producedMonday, int producedTuesday, int producedWednesday, int producedThursday, int producedFriday, int producedSaturday, int producedSunday, string productionWeek)
		{

			CustomerName = customerName;
			ItemID = itemID;
			ItemCode = itemCode;
			ItemDescription = itemDescription;
			RequiredCases = requiredCases;
			RequiredBags = requiredBags;
			ProducedMonday = producedMonday;
			ProducedTuesday = producedTuesday;
			ProducedWednesday = producedWednesday;
			ProducedThursday = producedThursday;
			ProducedFriday = producedFriday;
			ProducedSaturday = producedSaturday;
			ProducedSunday = producedSunday;
			ProductionWeek = productionWeek;

		}

		public override bool Equals(object obj)
		{

			if (obj == null || GetType().Equals(obj.GetType()) == false)
			{
				return false;
			}
			else
			{
				WeeklyProduction WP = (WeeklyProduction)obj;
				return ItemID == WP.ItemID && ProductionWeek == WP.ProductionWeek;
			}

		}

		public int RequiredCases {get; set;}
		public string CustomerName {get; set;}
		public int ItemID {get; set;}
		public string ItemCode {get; set;}
			public string ItemDescription {get; set;}
			public int RequiredBags {get; set;}
			public int ProducedMonday {get; set;}
			public int ProducedTuesday {get; set;}
			public int ProducedWednesday {get; set;}
			public int ProducedThursday {get; set;}
			public int ProducedFriday {get; set;}
			public int ProducedSaturday {get; set;}
			public int ProducedSunday {get; set;}
			public int ScheduledMonday {get; set;}
			public int ScheduledTuesday {get; set;}
			public int ScheduledWednesday {get; set;}
			public int ScheduledThursday {get; set;}
			public int ScheduledFriday {get; set;}
			public int ScheduledSaturday {get; set;}
		public int ScheduledSunday {get; set;}
		public string ProductionWeek {get; set;}
		public int TotalProduced {get; set;}

        public double PercentageComplete => TotalProduced / (double)RequiredCases;

        public int TotalProducedWeek => ProducedMonday + ProducedTuesday + ProducedWednesday + ProducedThursday + ProducedFriday + ProducedSaturday + ProducedSunday;

    }

}