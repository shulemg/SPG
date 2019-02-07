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
	public class WeeklyProductionList : List<WeeklyProduction>
	{
		public WeeklyProductionList()
		{

		}
		public WeeklyProductionList(int capacity) : base(capacity)
		{

		}
		public WeeklyProductionList(IEnumerable<WeeklyProduction> collection) : base(collection)
		{

		}

	}

}