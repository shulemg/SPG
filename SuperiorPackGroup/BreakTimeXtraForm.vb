Public Class BreakTimeXtraForm 

    Private Sub deleteRepositoryItemButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteRepositoryItemButtonEdit.Click

        If MessageBox.Show("Are you sure you want to delete this Break Time?", "Delete Break Time", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.Yes Then
            breakTimeGridView.DeleteRow(breakTimeGridView.FocusedRowHandle)
        End If

    End Sub

    Private Sub breakTimeGridView_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles breakTimeGridView.ValidateRow

        e.Valid = True
        e.ErrorText = Nothing

        If breakTimeGridView.GetFocusedRowCellValue(colWeekDay) Is Nothing OrElse breakTimeGridView.GetFocusedRowCellValue(colStartTime) Is Nothing OrElse breakTimeGridView.GetFocusedRowCellValue(colEndTime) Is Nothing _
                OrElse breakTimeGridView.GetFocusedRowCellValue(colStarting) Is Nothing OrElse breakTimeGridView.GetFocusedRowCellValue(colEnding) Is Nothing Then
            e.ErrorText = "All fields must be filled in. "
            e.Valid = False
        End If

        If Convert.ToDateTime(breakTimeGridView.GetFocusedRowCellDisplayText(colStartTime)) > Convert.ToDateTime(breakTimeGridView.GetFocusedRowCellDisplayText(colEndTime)) Then
            If MessageBox.Show("Is the break going from one day to the other?.", "Break Time", MessageBoxButtons.YesNo) = DialogResult.No Then
                e.ErrorText &= "Start Time must be before End Time. "
                e.Valid = False
            End If
        End If

        If Convert.ToDateTime(breakTimeGridView.GetFocusedRowCellValue(colStarting)) > Convert.ToDateTime(breakTimeGridView.GetFocusedRowCellValue(colEnding)) Then
            e.ErrorText = "Starting Date must be before Ending Date."
            e.Valid = False
        End If

    End Sub

End Class