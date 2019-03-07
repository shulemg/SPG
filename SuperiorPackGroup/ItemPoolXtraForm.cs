//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using DXDAL.SPGData;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace SuperiorPackGroup
{
	public partial class ItemPoolXtraForm
	{

		public ItemPoolXtraForm()
		{
			InitializeComponent();
		}

		private ItemPool m_CurrentPoolID;
		private Session m_ItemPoolSession;

		private void addBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			m_CurrentPoolID = new ItemPool(m_ItemPoolSession);
			codeTextEdit.Text = null;
			customerLookUpEdit.EditValue = null;
			customerLookUpEdit.Enabled = true;
			descriptionMemoEdit.Text = null;

			poolDetailsXpCollection.Criteria = new BinaryOperator(ItemPoolDetails.Fields.ItemPoolID, m_CurrentPoolID.Oid, BinaryOperatorType.Equal);
			poolDetailsXpCollection.Reload();

			if ((customerLookUpEdit.EditValue == null ? null : Convert.ToString(customerLookUpEdit.EditValue)) == customerLookUpEdit.Properties.NullText)
			{
				itemRepositoryItemLookUpEdit.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(null, "RM", true, m_ItemPoolSession);
			}
			else
			{
				itemRepositoryItemLookUpEdit.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID((int?)customerLookUpEdit.EditValue, "RM", true, m_ItemPoolSession);
			}

			Utilities.MakeFormReadOnly(poolXtraTabPage, false);
			poolDetailsGridView.OptionsBehavior.Editable = true;
			poolSearchGridControl.Enabled = false;
			CheckPermissions();

			cancelBarButtonItem.Enabled = true;
			saveBarButtonItem.Enabled = true;
			editBarButtonItem.Enabled = false;
			addBarButtonItem.Enabled = false;
			deleteBarButtonItem.Enabled = false;
			deleteGridColumn.Visible = false;

		}

		private void cancelBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			CancelChanges();

			CheckPermissions();

			Utilities.MakeFormReadOnly(poolXtraTabPage, true);
			poolDetailsGridView.OptionsBehavior.Editable = false;
			poolSearchGridControl.Enabled = true;

			cancelBarButtonItem.Enabled = false;
			saveBarButtonItem.Enabled = false;

		}

		private void customerLookUpEdit_EditValueChanged(object sender, EventArgs e)
		{

			if ((customerLookUpEdit.EditValue == null ? null : Convert.ToString(customerLookUpEdit.EditValue)) == customerLookUpEdit.Properties.NullText)
			{
				itemRepositoryItemLookUpEdit.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(null, "RM", true, m_ItemPoolSession);
			}
			else
			{
				itemRepositoryItemLookUpEdit.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID((int?)customerLookUpEdit.EditValue, "RM", true, m_ItemPoolSession);
			}

		}

		private void deleteBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (MessageBox.Show("Are you sure you want to delete this item pool.", "Delete Item Pool", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
			{
				return;
			}

			if (ItemPoolBLL.DeleteItemPool(m_CurrentPoolID.Oid) != true)
			{
				MessageBox.Show("The item pool was not deleted.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				BindPoolSearch();
			}

		}

		private void deleteRepositoryItemButtonEdit_Click(object sender, EventArgs e)
		{

			if (MessageBox.Show("Are you sure you want to remove this item.", "Delete Pool Detail", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
			{
				return;
			}

			ItemPoolDetails detail = m_ItemPoolSession.GetObjectByKey<ItemPoolDetails>(poolDetailsGridView.GetFocusedRowCellValue(colOid));
			if (detail != null)
			{
				detail.Delete();
				if (detail.IsDeleted == false)
				{
					MessageBox.Show("The item was not removed.");
				}
				else
				{
					poolDetailsGridView.DeleteRow(poolDetailsGridView.FocusedRowHandle);
				}
			}
			else
			{
				poolDetailsGridView.DeleteRow(poolDetailsGridView.FocusedRowHandle);
			}

		}

		private void editBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (m_CurrentPoolID == null)
			{
				MessageBox.Show("Please select a item pool to edit.");
				return;
			}

			Utilities.MakeFormReadOnly(poolXtraTabPage, false);
			poolDetailsGridView.OptionsBehavior.Editable = true;
			poolSearchGridControl.Enabled = false;
			CheckPermissions();

			cancelBarButtonItem.Enabled = true;
			saveBarButtonItem.Enabled = true;
			editBarButtonItem.Enabled = false;
			addBarButtonItem.Enabled = false;
			deleteBarButtonItem.Enabled = false;

		}

		private void ItemPoolXtraForm_Activated(object sender, EventArgs e)
		{

			XPBaseObject.AutoSaveOnEndEdit = false;

		}

		private void ItemPoolXtraForm_FormClosing(object sender, FormClosingEventArgs e)
		{

			if (poolSearchGridControl.Enabled == false)
			{
				switch (MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
				{
					case DialogResult.Yes:
						if (SaveChanges() == false)
						{
							e.Cancel = true;
						}
						break;
					case DialogResult.No:
						CancelChanges();
						break;
					case DialogResult.Cancel:
						e.Cancel = true;
						break;
				}
			}

			if (e.Cancel == false)
			{
				XPBaseObject.AutoSaveOnEndEdit = true;
				m_ItemPoolSession.PurgeDeletedObjects();
			}

		}

		private void ItemPoolXtraForm_Load(object sender, EventArgs e)
		{

			Cursor = Cursors.WaitCursor;

			CheckPermissions();
			m_ItemPoolSession = new Session(MyDataLayers.SPGDataLayer);
			m_ItemPoolSession.TrackPropertiesModifications = true;
			m_ItemPoolSession.OptimisticLockingReadBehavior = OptimisticLockingReadBehavior.MergeCollisionThrowException;
			poolDetailsXpCollection.Session = m_ItemPoolSession;
			poolSearchXpView.Session = m_ItemPoolSession;
			itemXpView.Session = m_ItemPoolSession;
			customerXpView.Session = m_ItemPoolSession;

			BindPoolSearch();

			poolDetailsXpCollection.Criteria = new BinaryOperator(ItemPoolDetails.Fields.ItemPoolID, 0, BinaryOperatorType.Equal);

			Utilities.MakeFormReadOnly(poolXtraTabPage, true);
			poolDetailsGridView.OptionsBehavior.Editable = false;
			poolSearchGridControl.Enabled = true;

			cancelBarButtonItem.Enabled = false;
			saveBarButtonItem.Enabled = false;

			Cursor = Cursors.Default;

		}

		private void itemRepositoryItemLookUpEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
		{

			if (e.CloseMode != PopupCloseMode.Cancel)
			{
				GridView view = (GridView)(((GridControl)(((LookUpEdit)sender).Parent)).FocusedView);
				if (view.IsNewItemRow(view.FocusedRowHandle))
				{
					view.CloseEditor();
					view.UpdateCurrentRow();
				}
			}

		}

		private void poolDetailsGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
		{

			if (!Convert.IsDBNull(poolDetailsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, itemGridColumn)) && poolDetailsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, itemGridColumn) != null && !Convert.IsDBNull(poolDetailsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, itemQtyOnHandGridColumn)))
			{
				if (e.Column.Name == poolQuantityOnHandGridColumn.Name && e.IsGetData)
				{
					e.Value = Convert.ToDouble(poolDetailsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, itemQtyOnHandGridColumn)) * (Convert.ToDouble(poolDetailsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, colItemPoolRatio)));
				}
			}

		}

		private void poolDetailsGridView_InitNewRow(object sender, InitNewRowEventArgs e)
		{

			poolDetailsGridView.SetRowCellValue(e.RowHandle, colPoolID, m_CurrentPoolID.Oid);
			poolDetailsGridView.SetRowCellValue(e.RowHandle, colItemPoolRatio, 1);

		}

		private void poolSearchGridView_Click(object sender, EventArgs e)
		{

			if (poolSearchGridView.FocusedRowHandle == -999997)
			{
				return;
			}

			if (poolSearchGridView.CalcHitInfo(poolSearchGridControl.PointToClient(Control.MousePosition)).HitTest == GridHitTest.RowCell)
			{
				BindPoolControls(Convert.ToInt32(poolSearchGridView.GetFocusedRowCellValue(colPoolID)));
			}

		}

		private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (SaveChanges())
			{
				CheckPermissions();

				Utilities.MakeFormReadOnly(poolXtraTabPage, true);
				poolDetailsGridView.OptionsBehavior.Editable = false;
				poolSearchGridControl.Enabled = true;

				cancelBarButtonItem.Enabled = false;
				saveBarButtonItem.Enabled = false;
			}

		}

		public void BindPoolControls(int poolID)
		{

			m_ItemPoolSession.DropIdentityMap();

			ItemPool pool = m_ItemPoolSession.GetObjectByKey<ItemPool>(poolID, true);
			m_CurrentPoolID = pool;
			codeTextEdit.Text = pool.PoolCode;
			customerLookUpEdit.EditValue = pool.PoolCustomerID.CustomerID;
			customerLookUpEdit.Enabled = false;
			descriptionMemoEdit.Text = pool.PoolDescription;

			poolDetailsXpCollection.Criteria = new BinaryOperator(ItemPoolDetails.Fields.ItemPoolID, m_CurrentPoolID.Oid, BinaryOperatorType.Equal);

			poolDetailsXpCollection.Reload();

			if ((customerLookUpEdit.EditValue == null ? null : Convert.ToString(customerLookUpEdit.EditValue)) == customerLookUpEdit.Properties.NullText)
			{
				itemRepositoryItemLookUpEdit.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(null, "RM", true, m_ItemPoolSession);
			}
			else
			{
				itemRepositoryItemLookUpEdit.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID((int?)customerLookUpEdit.EditValue, "RM", true, m_ItemPoolSession);
			}

		}

		public void BindPoolSearch()
		{

			poolSearchXpView.Reload();

		}

		private void CancelChanges()
		{

			if (m_CurrentPoolID.Oid != -1)
			{
				BindPoolControls(m_CurrentPoolID.Oid);
			}

		}

		public bool CheckPermissions()
		{

			try
			{
				SPG.UserPermissionsRow permission = (new UserPermissionsBLL()).GetUserPermissionsByUserName(Properties.Settings.Default.UserName, "Items Form")[0];

				switch (permission.PermissionLevel)
				{
					case "FULL":
					case "Full":
						addBarButtonItem.Enabled = true;
						editBarButtonItem.Enabled = true;
						deleteBarButtonItem.Enabled = true;
						deleteGridColumn.Visible = true;
						deleteGridColumn.VisibleIndex = 0;
						break;
					case "ADD":
					case "Add":
						addBarButtonItem.Enabled = true;
						editBarButtonItem.Enabled = true;
						deleteBarButtonItem.Enabled = false;
						deleteGridColumn.Visible = false;
						break;
					case "NONE":
					case "None":
						MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						Close();
						return false;
					case "VIEW":
					case "View":
						addBarButtonItem.Enabled = false;
						editBarButtonItem.Enabled = false;
						deleteBarButtonItem.Enabled = false;
						deleteGridColumn.Visible = false;
						break;
					case "EDIT":
					case "Edit":
						addBarButtonItem.Enabled = false;
						editBarButtonItem.Enabled = true;
						deleteBarButtonItem.Enabled = false;
						deleteGridColumn.Visible = false;
						break;
					case "VIEW ASSIGNED":
						addBarButtonItem.Enabled = false;
						editBarButtonItem.Enabled = false;
						deleteGridColumn.Visible = false;
						deleteBarButtonItem.Enabled = false;
						FilterAssignedCustomers();
						break;
					case "EDIT ASSIGNED":
						addBarButtonItem.Enabled = false;
						editBarButtonItem.Enabled = true;
						deleteGridColumn.Visible = false;
						deleteBarButtonItem.Enabled = false;
						FilterAssignedCustomers();
						break;
					default:
						MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
						Close();
						return false;
				}
				return true;
			}
			catch (InvalidOperationException ex)
			{
				return false;
			}

		}

		private void FilterAssignedCustomers()
		{

			poolSearchXpView.Criteria = new InOperator(ItemPool.Fields.PoolCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ItemPoolSession));

		}

		private bool SaveChanges()
		{

			int selectedID = -1;
			if (m_CurrentPoolID.Oid == -1)
			{

			}
			else
			{
				selectedID = poolSearchGridView.FocusedRowHandle;
			}

			if (ItemPoolBLL.ValidateRecord(codeTextEdit.Text, (int?)customerLookUpEdit.EditValue))
			{
				m_CurrentPoolID.PoolCode = codeTextEdit.Text;
				m_CurrentPoolID.PoolDescription = descriptionMemoEdit.Text;
				m_CurrentPoolID.PoolCustomerID = CustomersBLL.GetCustomer(Convert.ToInt32(customerLookUpEdit.EditValue), m_ItemPoolSession);
				m_CurrentPoolID.PoolType = "BP";
			}
			else
			{
				MessageBox.Show("You must provide a Pool Code, and Customer name before saving the record.");
				return false;
			}

			try
			{
				m_CurrentPoolID.Save();
			}
			catch (ApplicationException ex)
			{
				MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			//Save the details here
			foreach (ItemPoolDetails poolDetail in poolDetailsXpCollection)
			{
				if (poolDetail.ItemPoolID == null || poolDetail.ItemPoolID.Oid == -1)
				{
					poolDetail.ItemPoolID = m_CurrentPoolID;
				}
				poolDetail.Save();
			}

			BindPoolSearch();
			BindPoolControls(m_CurrentPoolID.Oid);
			poolSearchGridView.FocusedRowHandle = selectedID;
			return true;

		}

	}
}