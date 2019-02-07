//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;

namespace SuperiorPackGroup
{
	public class ItemTransactionsList : List<ItemTransaction>
	{
		public double OpeningBalance {get; set;} = 0;

	}

}