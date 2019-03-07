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
	public partial class SPG
	{
		public partial class ShippingsDataTable
		{
			private void ShippingsDataTable_ColumnChanging(object sender, DataColumnChangeEventArgs e)
			{
				if (e.Column.ColumnName == strDeliveryNoteColumn.ColumnName)
				{
					//Add user code here
				}

			}

		}
	}

	namespace SPGTableAdapters
	{

		public partial class ShippingsTableAdapter
		{

		}

		public partial class ProductionTableAdapter
		{
		}
	}

	namespace SPGTableAdapters
	{

		public partial class ItemsTableAdapter
		{
		}
	}

	namespace SPGTableAdapters
	{

		public partial class ItemsTableAdapter
		{
		}
	}

}