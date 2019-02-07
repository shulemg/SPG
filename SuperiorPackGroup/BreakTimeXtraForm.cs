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
	public partial class BreakTimeXtraForm
	{

		public BreakTimeXtraForm()
		{
			InitializeComponent();
		}

		private void deleteRepositoryItemButtonEdit_Click(System.Object sender, EventArgs e)
		{

			if (MessageBox.Show("Are you sure you want to delete this Break Time?", "Delete Break Time", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
			{
				breakTimeGridView.DeleteRow(breakTimeGridView.FocusedRowHandle);
			}

		}

		private void breakTimeGridView_ValidateRow(System.Object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
		{

			e.Valid = true;
			e.ErrorText = null;

			if (breakTimeGridView.GetFocusedRowCellValue(colWeekDay) == null || breakTimeGridView.GetFocusedRowCellValue(colStartTime) == null || breakTimeGridView.GetFocusedRowCellValue(colEndTime) == null || breakTimeGridView.GetFocusedRowCellValue(colStarting) == null || breakTimeGridView.GetFocusedRowCellValue(colEnding) == null)
			{
				e.ErrorText = "All fields must be filled in. ";
				e.Valid = false;
			}

			if (Convert.ToDateTime(breakTimeGridView.GetFocusedRowCellDisplayText(colStartTime)) > Convert.ToDateTime(breakTimeGridView.GetFocusedRowCellDisplayText(colEndTime)))
			{
				if (MessageBox.Show("Is the break going from one day to the other?.", "Break Time", MessageBoxButtons.YesNo) == DialogResult.No)
				{
					e.ErrorText += "Start Time must be before End Time. ";
					e.Valid = false;
				}
			}

			if (Convert.ToDateTime(breakTimeGridView.GetFocusedRowCellValue(colStarting)) > Convert.ToDateTime(breakTimeGridView.GetFocusedRowCellValue(colEnding)))
			{
				e.ErrorText = "Starting Date must be before Ending Date.";
				e.Valid = false;
			}

		}

	}
}