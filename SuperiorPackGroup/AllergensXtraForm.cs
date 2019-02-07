//INSTANT C# NOTE: Formerly VB project-level imports:
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using System;
using DevExpress.Xpo;

namespace SuperiorPackGroup
{
	public partial class AllergensXtraForm
	{

		public AllergensXtraForm()
		{
			InitializeComponent();
		}

		private AllergensBLL m_Allergen;
		private Session m_AllergenSession;

		private void BindGridControl()
		{

			//Me.machineLineGridControl.DataSource = m_Allergen.GetAllergens(m_AllergenSession)

		}

		private void AllergensXtraForm_Load(object sender, EventArgs e)
		{

			m_AllergenSession = new Session(MyDataLayers.SPGDataLayer)
			{
				TrackPropertiesModifications = true,
				OptimisticLockingReadBehavior = OptimisticLockingReadBehavior.MergeCollisionThrowException
			};
			m_Allergen = new AllergensBLL();

			CheckPermissions();
			// Me.nameGridColumn.FieldName = "AllergenName"
			//Me.idGridColumn.FieldName = "AllergenName"
			//AllergenXpView.Reload()

		}

		private void deleteSimpleButton_Click(System.Object sender, EventArgs e)
		{

			if (allergenGridView.SelectedRowsCount > 0)
			{
				if (MessageBox.Show("Are you sure you want to delete this record/s?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					for (int i = 0; i < allergenGridView.SelectedRowsCount; i++)
					{
						int row = allergenGridView.GetSelectedRows()[i];
						if (row >= 0)
						{
							if (m_Allergen.DeleteAllergens(m_AllergenSession, Convert.ToInt32(allergenGridView.GetRowCellValue(row, idGridColumn))) != true)
							{
								MessageBox.Show("The Allergen was not deleted successfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
								return;
							}
						}
					}
				}
			}

			AllergenXpCollection.Reload();
			allergenGridView.RefreshData();

		}

		private void saveSimpleButton_Click(System.Object sender, EventArgs e)
		{

			this.allergenGridView.CloseEditor();
			this.Close();
			//Try
			//    allergenGridView.SelectAll()
			//    If allergenGridView.SelectedRowsCount > 0 Then
			//        For i As Integer = 0 To allergenGridView.SelectedRowsCount - 1
			//            Dim row As Integer = allergenGridView.GetSelectedRows()(i)
			//            If row >= 0 Then
			//                If m_Allergen.UpdateAllergen(m_AllergenSession, CType(allergenGridView.GetRowCellValue(row, idGridColumn), Integer?), allergenGridView.GetRowCellValue(row, nameGridColumn).ToString) <> True Then
			//                    MessageBox.Show("The Allergen was not updated successfully.", "Error Encountered", MessageBoxButtons.OK,
			//                            MessageBoxIcon.Error)
			//                    Exit Sub
			//                End If
			//            End If
			//        Next
			//    End If
			//Catch ex As ApplicationException
			//    MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
			//    Exit Sub
			//End Try

			//AllergenXpView.Reload()

		}

		public bool CheckPermissions()
		{

			try
			{
				SPG.UserPermissionsRow permission = (new UserPermissionsBLL()).GetUserPermissionsByUserName(Properties.Settings.Default.UserName, "General Lists")[0];

				switch (permission.PermissionLevel)
				{
					case "FULL":
					case "Full":
						this.allergenGridView.OptionsBehavior.Editable = true;
						this.allergenGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
						this.deleteSimpleButton.Visible = true;
						break;
					case "ADD":
					case "Add":
						this.allergenGridView.OptionsBehavior.Editable = true;
						this.allergenGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
						this.deleteSimpleButton.Visible = false;
						break;
					case "NONE":
					case "None":
					case "VIEW ASSIGNED":
					case "EDIT ASSIGNED":
						MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						this.Close();
						return false;
					case "VIEW":
					case "View":
						this.allergenGridView.OptionsBehavior.Editable = false;
						this.allergenGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
						this.deleteSimpleButton.Visible = false;
						break;
					case "EDIT":
					case "Edit":
						this.allergenGridView.OptionsBehavior.Editable = true;
						this.allergenGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None;
						this.deleteSimpleButton.Visible = false;
						break;
					default:
						MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						this.Close();
						return false;
				}
				return true;
			}
			catch (InvalidOperationException ex)
			{
				return false;
			}

		}

	}
}