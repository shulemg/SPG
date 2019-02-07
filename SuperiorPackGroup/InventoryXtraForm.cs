//INSTANT C# NOTE: Formerly VB project-level imports:
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using System;
using DevExpress.XtraEditors;
using System.Text;
using DevExpress.Data.Filtering;
using DXDAL.SPGData;
using DevExpress.Xpo;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;


namespace SuperiorPackGroup
{
	public partial class InventoryXtraForm
	{

		private bool InstanceFieldsInitialized = false;

		public InventoryXtraForm()
		{
			if (!InstanceFieldsInitialized)
			{
				InitializeInstanceFields();
				InstanceFieldsInitialized = true;
			}

			InitializeComponent();
		}

			private void InitializeInstanceFields()
			{
				m_timer = new Timer();
			}

		[System.Runtime.CompilerServices.AccessedThroughProperty(nameof(m_timer))]
		private Timer _m_timer;
		private Timer m_timer
		{
			[System.Diagnostics.DebuggerNonUserCode]
			get
			{
				return _m_timer;
			}
			[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized), System.Diagnostics.DebuggerNonUserCode]
			set
			{
				if (_m_timer != null)
				{
					_m_timer.Tick -= TimerEventProcessor;
				}

				_m_timer = value;

				if (value != null)
				{
					_m_timer.Tick += TimerEventProcessor;
				}
			}
		}
		private bool m_AllowAdd = false;
		private CustomersBLL m_Customers;
		private InventoryBLL m_Inventory;
		//Private m_InventorySession As Session
		private UnitOfWork m_InventoryUOW;
		private ItemsBLL m_Items;
		private int? m_LPNBaseNumber;
		private readonly ArrayList m_PoolItemQtyUsed = new ArrayList();
		private double m_PoolQuantityUsed;
		private Inventory m_SavedRecord = null;

		private void addLotCodeSimpleButton_Click(object sender, EventArgs e)
		{

			if (ValidateRecord())
			{

				try
				{
					if (palletNumberTextEdit.EditValue == null || Convert.ToInt32(palletNumberTextEdit.EditValue) == 0)
					{
						palletNumberTextEdit.EditValue = InventoryBLL.GetNewPalletNumber(m_InventoryUOW, Convert.ToDateTime(inventoryDateEdit.DateTime.ToString("D")), Convert.ToInt32(itemLookUpEdit.EditValue), Utilities.ChangeType<int?>(shiftLookUpEdit.EditValue));
					}
					if (SaveRecord())
					{
						//Dim inventoryRecord As Inventory = InventoryBLL.GetInventoryRecord(m_InventoryUOW, CType(saveSimpleButton.Tag, Integer), True)
						if (m_SavedRecord.LPNNumber == null)
						{
							if (m_LPNBaseNumber.HasValue == false)
							{
								m_LPNBaseNumber = LPNLabel.GetNextLPNNumber(m_SavedRecord.InventoryItemID.ItemCustomerID);
							}
							m_SavedRecord.LPNNumber = m_LPNBaseNumber;
							m_SavedRecord.Save();
						}
						m_InventoryUOW.CommitChanges();
					}
				}
				catch (Exception ex)
				{
					m_InventoryUOW.RollbackTransaction();
					MessageBox.Show(string.Format("There was an error while trying to save the current record, no changes were saved.{0}{1}", Environment.NewLine, ex.Message), "Saving Error");
				}
				finally
				{
					saveSimpleButton.Tag = null;
					m_SavedRecord = null;
					itemLookUpEdit.Properties.Tag = null;
					itemLookUpEdit.Properties.ReadOnly = true;
					lotTextEdit.EditValue = null;
					quantityTextEdit.EditValue = null;
					quantityTextEdit.Properties.Tag = null;
					noteMemoEdit.EditValue = null;
					productionProjectDetailXpCollection.Criteria = new BinaryOperator(ProductionProjectDetails.Fields.Production.InventoryID.PropertyName, 0, BinaryOperatorType.Equal);
					projectDetailsGridView.OptionsBehavior.Editable = false;
					inventoryXPView.Reload();
				}
			}

		}

		private void cancelSimpleButton_Click(System.Object sender, EventArgs e)
		{

			PrepareNewRecord();

		}

		private void clearSimpleButton_Click(System.Object sender, EventArgs e)
		{

			SetDefaultViewFilter();
			fromFilterDateEdit.EditValue = null;
			toFilterDateEdit.EditValue = null;
			FillInventoryView();

		}

		private void customerFilterLookUpEdit_Validated(System.Object sender, EventArgs e)
		{

			if ((customerFilterLookUpEdit.EditValue == null ? null : Convert.ToString(customerFilterLookUpEdit.EditValue)) == customerFilterLookUpEdit.Properties.NullText || string.IsNullOrEmpty((customerFilterLookUpEdit.EditValue == null ? null : Convert.ToString(customerFilterLookUpEdit.EditValue))))
			{
				itemsFilterXPView.Filter = null;
			}
			else
			{
				itemsFilterXPView.Filter = new BinaryOperator("CustomerID", (customerFilterLookUpEdit.EditValue == null ? null : Convert.ToString(customerFilterLookUpEdit.EditValue)), BinaryOperatorType.Equal);
			}

		}

		private void deleteRepositoryItemButtonEdit_Click(System.Object sender, EventArgs e)
		{

			if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (InventoryBLL.DeleteInventory(m_InventoryUOW, Convert.ToInt32(inventoryGridView.GetFocusedRowCellValue(idGridColumn))) != true)
				{
					MessageBox.Show("The inventory record was not deleted succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				m_InventoryUOW.CommitChanges();
			}

			inventoryXPView.Reload();

		}

		private void editSimpleButton_Click(System.Object sender, EventArgs e)
		{

			//enters the rowhandle for the editing record in the edit button tag property
			if (inventoryGridView.SelectedRowsCount == 1)
			{
				int rowHandle = inventoryGridView.GetSelectedRows()[0];
				m_InventoryUOW.DropIdentityMap();

				Inventory inventoryRecord = InventoryBLL.GetInventoryRecord(m_InventoryUOW, Convert.ToInt32(inventoryGridView.GetRowCellValue(rowHandle, idGridColumn)));
				if (inventoryRecord.Shipment == null)
				{
					editSimpleButton.Tag = rowHandle;

					saveSimpleButton.Tag = inventoryRecord.InventoryID;
					inventoryDateEdit.DateTime = inventoryRecord.InventoryDate;
					itemLookUpEdit.EditValue = inventoryRecord.InventoryItemID.ItemID;
					itemLookUpEdit.Properties.Tag = inventoryRecord.InventoryItemID.ItemID;
					descriptionMemoEdit.EditValue = inventoryGridView.GetRowCellValue(rowHandle, descriptionGridColumn);
					onHandTextEdit.EditValue = ItemsBLL.GetQtyOnHandByID(m_InventoryUOW, inventoryRecord.InventoryItemID.ItemID, UsersBLL.GetUsersLocalLocation(m_InventoryUOW, Properties.Settings.Default.UserName).Oid);
					quantityTextEdit.EditValue = inventoryRecord.InventoryQuantity;
					quantityTextEdit.Properties.Tag = inventoryRecord.InventoryQuantity;
					palletsTextEdit.EditValue = inventoryRecord.InventoryPallets;
					lotTextEdit.EditValue = inventoryRecord.Lot;
					poTextEdit.EditValue = inventoryRecord.PO;
					shiftLookUpEdit.EditValue = inventoryRecord.Shift?.ShiftID;
					if (inventoryRecord.Pallet > 0)
					{
						palletNumberTextEdit.EditValue = inventoryRecord.Pallet;
					}
					else
					{
						palletNumberTextEdit.EditValue = null;
					}
					expirationDateEdit.EditValue = inventoryRecord.ExpirationDate;
					m_LPNBaseNumber = inventoryRecord.LPNNumber;
					noteMemoEdit.EditValue = inventoryRecord.Note;
					expirationDateEdit.Properties.EditFormat.FormatString = CustomersBLL.GetExpirationDateFormat(m_Items.GetCustomerIDByItemID(inventoryRecord.InventoryItemID.ItemID));
					expirationDateEdit.Properties.DisplayFormat.FormatString = CustomersBLL.GetExpirationDateFormat(m_Items.GetCustomerIDByItemID(inventoryRecord.InventoryItemID.ItemID));
					poolDetailsXpCollection.Criteria = new BinaryOperator(PoolBom.Fields.PoolBomFiniGoodID.ItemID.PropertyName, inventoryRecord.InventoryItemID.ItemID, BinaryOperatorType.Equal);
					UpdatePoolDetailsXpViewCriteria();
					UpdateBomPoolUsed();
					productionProjectDetailXpCollection.Criteria = new BinaryOperator(ProductionProjectDetails.Fields.Production.InventoryID.PropertyName, inventoryRecord.InventoryID, BinaryOperatorType.Equal);
					projectDetailsGridView.OptionsBehavior.Editable = true;
					colUnitsProduced.OptionsColumn.ReadOnly = false;
				}
				else
				{
					MessageBox.Show("The selected record can't be edited, it was already shipped.");
				}
			}

		}

		private void filterByPalletSimpleButton_Click(object sender, EventArgs e)
		{

			CriteriaOperatorCollection inventoryViewCriteria = new CriteriaOperatorCollection();

			if (((DateTime?)fromFilterDateEdit.EditValue).HasValue)
			{
				inventoryViewCriteria.Add(new BinaryOperator(Inventory.Fields.InventoryDate.PropertyName, Convert.ToDateTime(fromFilterDateEdit.EditValue), BinaryOperatorType.GreaterOrEqual));
			}
			if (((DateTime?)toFilterDateEdit.EditValue).HasValue)
			{
				inventoryViewCriteria.Add(new BinaryOperator(Inventory.Fields.InventoryDate.PropertyName, Convert.ToDateTime(toFilterDateEdit.EditValue), BinaryOperatorType.LessOrEqual));
			}
			if (((int?)customerFilterLookUpEdit.EditValue).HasValue)
			{
				inventoryViewCriteria.Add(new BinaryOperator(Inventory.Fields.InventoryItemID.ItemCustomerID.CustomerID.PropertyName, Convert.ToInt32(customerFilterLookUpEdit.EditValue), BinaryOperatorType.Equal));
			}
			if (string.IsNullOrEmpty((lotFilterTextEdit.EditValue == null ? null : Convert.ToString(lotFilterTextEdit.EditValue))) == false)
			{
				inventoryViewCriteria.Add(new BinaryOperator(Inventory.Fields.Lot.PropertyName, (lotFilterTextEdit.EditValue == null ? null : Convert.ToString(lotFilterTextEdit.EditValue)), BinaryOperatorType.Equal));
			}
			if (((int?)itemFilterLookUpEdit.EditValue).HasValue)
			{
				inventoryViewCriteria.Add(new BinaryOperator(Inventory.Fields.InventoryItemID.ItemID.PropertyName, Convert.ToInt32(itemFilterLookUpEdit.EditValue), BinaryOperatorType.Equal));
			}
			if (((int?)shiftFilterLookUpEdit.EditValue).HasValue)
			{
				inventoryViewCriteria.Add(new BinaryOperator(Inventory.Fields.Shift.PropertyName, Convert.ToInt32(shiftFilterLookUpEdit.EditValue), BinaryOperatorType.Equal));
			}
			if (string.IsNullOrEmpty((LPNFilterTextEdit.EditValue == null ? null : Convert.ToString(LPNFilterTextEdit.EditValue))) == false)
			{
				inventoryViewCriteria.Add(new BinaryOperator(Inventory.Fields.LPNNumber.PropertyName, Convert.ToInt32(LPNFilterTextEdit.EditValue), BinaryOperatorType.Equal));
			}

			Inventory inventoryRecord = null;
			foreach (object item in m_InventoryUOW.GetObjects(m_InventoryUOW.GetClassInfo(typeof(Inventory)), new GroupOperator(GroupOperatorType.And, inventoryViewCriteria), null, 1, false, false))
			{
				inventoryRecord = item as Inventory;
				if (inventoryRecord != null)
				{
					fromFilterDateEdit.EditValue = inventoryRecord.InventoryDate;
					toFilterDateEdit.EditValue = inventoryRecord.InventoryDate;
					customerFilterLookUpEdit.EditValue = inventoryRecord.InventoryItemID.ItemCustomerID.CustomerID;
					lotFilterTextEdit.EditValue = null;
					itemFilterLookUpEdit.EditValue = inventoryRecord.InventoryItemID.ItemID;
					shiftFilterLookUpEdit.EditValue = inventoryRecord.Shift.ShiftID;
					break;
				}
			}

			if (inventoryRecord != null)
			{
				FillInventoryView(inventoryRecord.Pallet);
			}
			else
			{
				FillInventoryView();
			}


		}

		private void filterSimpleButton_Click(System.Object sender, EventArgs e)
		{

			if (toFilterDateEdit.DateTime.TimeOfDay.TotalMinutes == 0)
			{
				toFilterDateEdit.DateTime = toFilterDateEdit.DateTime.AddMinutes(1439);
			}
			FillInventoryView();

		}

		private void inventoryGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
		{

			if (e.Column == expirationDateGridColumn && DateHelper.IsDate(e.Value))
			{
				e.DisplayText = Convert.ToDateTime(e.Value).ToString(inventoryGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, expirationDateFormatGridColumn).ToString());
			}

		}

		private void InventoryXtraForm_FormClosing(object sender, FormClosingEventArgs e)
		{

			if (editSimpleButton.Tag != null)
			{
				MessageBox.Show("You must first save or cancel the changes");
				e.Cancel = true;
			}

			if (e.Cancel == false)
			{
				m_InventoryUOW.PurgeDeletedObjects();
			}

		}

		private void TimerEventProcessor(object myObject, EventArgs myEventArgs)
		{
			if (itemLookUpEdit.EditValue == null)
			{
				inventoryDateEdit.EditValue = DateTime.Now;
			}
		}

		private void InventoryXtraForm_Load(System.Object sender, EventArgs e)
		{

			m_timer.Interval = Convert.ToInt32(TimeSpan.FromMinutes(1).TotalMilliseconds);
			m_timer.Start();

			Cursor = Cursors.WaitCursor;

			CheckPermissions();

			m_InventoryUOW = new UnitOfWork(MyDataLayers.SPGDataLayer)
			{
				TrackPropertiesModifications = true,
				OptimisticLockingReadBehavior = OptimisticLockingReadBehavior.MergeCollisionThrowException
			};
			//m_InventorySession = New Session(XpoDefault.Session.DataLayer.DataLayer)
			XPBaseObject.AutoSaveOnEndEdit = true;
			for (int i = 0; i < components.Components.Count; i++)
			{
				if ((components.Components[i]) is XPView)
				{
					((XPView)components.Components[i]).Session = m_InventoryUOW;
				}
				else if ((components.Components[i]) is XPCollection)
				{
					((XPCollection)components.Components[i]).Session = m_InventoryUOW;
				}
			}

			poolDetailsXpCollection.Criteria = new BinaryOperator(PoolBom.Fields.PoolBomFiniGoodID.ItemID.PropertyName, 0, BinaryOperatorType.Equal);
			UpdatePoolDetailsXpViewCriteria();

			productionProjectDetailXpCollection.Criteria = new BinaryOperator(ProductionProjectDetails.Fields.Production.InventoryID.PropertyName, 0, BinaryOperatorType.Equal);

			m_Items = new ItemsBLL();
			m_Customers = new CustomersBLL();
			m_Inventory = new InventoryBLL();

			PrepareNewRecord();
			//inventoryDateEdit.DateTime = Today

			SetDefaultViewFilter();
			FillInventoryView();

			Cursor = Cursors.Default;

		}

		private void itemLookUpEdit_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
		{

			Items itemProducing = ItemsBLL.GetItemByUpc(e.DisplayValue.ToString());

			if (itemProducing != null)
			{
				e.Handled = true;
				e.DisplayValue = itemProducing.ItemCode;
			}
			else
			{
				e.Handled = false;
			}

		}

		private void itemLookUpEdit_Validated(System.Object sender, EventArgs e)
		{


			int? itemId = (int?)itemLookUpEdit.EditValue;

			if (ProjectDetailsBLL.IsItOnSchedule(m_InventoryUOW, itemId) == false && itemId.HasValue)
			{
				MessageBox.Show("This item is not in an open project.");
			}

			descriptionMemoEdit.Text = ItemsBLL.GetDescriptionByItemID(itemId);
			onHandTextEdit.EditValue = ItemsBLL.GetQtyOnHandByID(m_InventoryUOW, itemId, UsersBLL.GetUsersLocalLocation(m_InventoryUOW, Properties.Settings.Default.UserName).Oid);
			if (itemId.HasValue)
			{
				expirationDateEdit.Properties.EditFormat.FormatString = CustomersBLL.GetExpirationDateFormat(m_Items.GetCustomerIDByItemID(itemId.Value));
				expirationDateEdit.Properties.DisplayFormat.FormatString = CustomersBLL.GetExpirationDateFormat(m_Items.GetCustomerIDByItemID(itemId.Value));
				poolDetailsXpCollection.Criteria = new BinaryOperator(PoolBom.Fields.PoolBomFiniGoodID.ItemID.PropertyName, itemId.Value, BinaryOperatorType.Equal);
				UpdatePoolDetailsXpViewCriteria();
			}
			UpdatePallets();

		}

		private void largeLPNSimpleButton_Click(object sender, EventArgs e)
		{

			string labelText = string.Empty;

			if (((int?)itemLookUpEdit.Properties.Tag).HasValue && ((int?)itemLookUpEdit.EditValue).HasValue && (int?)itemLookUpEdit.Properties.Tag != (int?)itemLookUpEdit.EditValue)
			{
				m_InventoryUOW.Delete(productionProjectDetailXpCollection);
				m_InventoryUOW.Save(productionProjectDetailXpCollection);
				productionProjectDetailXpCollection.Reload();
			}

			if (ValidateRecord())
			{
				try
				{
					if (SaveRecord())
					{
						//Dim inventoryRecord As Inventory = InventoryBLL.GetInventoryRecord(m_InventoryUOW, CType(saveSimpleButton.Tag, Integer), True)
						if (m_LPNBaseNumber.HasValue)
						{
							m_SavedRecord.LPNNumber = m_LPNBaseNumber;
							m_SavedRecord.FullLPNNumber = m_SavedRecord.InventoryItemID.ItemCustomerID.LPNPrefix + ("0000000000" + m_LPNBaseNumber.ToString()).Substring(("0000000000" + m_LPNBaseNumber.ToString()).Length - m_SavedRecord.InventoryItemID.ItemCustomerID.LastLPNNumber.ToString().Length);
							m_SavedRecord.Save();
						}

						labelText = LPNLabel.CreateLPNLabel(m_InventoryUOW, m_SavedRecord, false);
						if (string.IsNullOrEmpty(labelText))
						{
							MessageBox.Show("The record was saved without generating an LPN Label");
						}
						m_InventoryUOW.CommitChanges();
						if (string.IsNullOrEmpty(labelText) == false)
						{
							LPNLabel.SendLPNLabelToGenericPrinter(CompanySettingsBLL.GetSettings().LPNPrinterName, labelText);
						}
					}
				}
				catch (Exception ex)
				{
					m_InventoryUOW.RollbackTransaction();
					MessageBox.Show(string.Format("There was an error while trying to save the current record, no changes were saved.{0}{1}", Environment.NewLine, ex.Message), "Saving Error");
				}
				finally
				{
					PrepareNewRecord();
				}
			}

		}

		//Private Sub palletTicketSimpleButton_Click(sender As System.Object, e As System.EventArgs)

		//    If ValidateRecord() Then
		//        If SaveRecord() Then
		//            PrintPalletTicket(CType(saveSimpleButton.Tag, Integer))
		//            PrepareNewRecord()
		//        End If
		//    End If

		//End Sub

		private void poolDetailsGridView_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e)
		{

			try
			{
				GridGroupRowInfo info = (GridGroupRowInfo)e.Info;

				PoolBom currentPool = null;
				foreach (PoolBom pool in poolDetailsXpCollection)
				{
					if (pool.ItemPoolID.PoolCode == poolDetailsGridView.GetGroupRowValue(e.RowHandle).ToString())
					{
						currentPool = pool;
						info.GroupText = string.Format("{0}:{2} - {1} needed {3}", info.Column.Caption, (currentPool.PoolBomQuantity) * Utilities.ChangeType<int>(quantityTextEdit.EditValue), info.GroupValueText, poolDetailsGridView.GetGroupSummaryText(e.RowHandle));
						break;
					}
				}
			}
			catch (Exception ex)
			{

			}

		}

		private void poolDetailsGridView_CustomSummaryCalculate(object sender, CustomSummaryEventArgs e)
		{

			int summaryID = Convert.ToInt32(((GridSummaryItem)e.Item).Tag);
			GridView View = (GridView)sender;

			if (e.SummaryProcess == CustomSummaryProcess.Start)
			{
				m_PoolQuantityUsed = 0;
			}

			if (e.SummaryProcess == CustomSummaryProcess.Calculate)
			{
				switch (summaryID)
				{
					case 1:
						m_PoolQuantityUsed += Convert.ToDouble(e.FieldValue) * Convert.ToDouble(View.GetRowCellValue(e.RowHandle, colItemPoolRatio));
						break;
				}
			}

			if (e.SummaryProcess == CustomSummaryProcess.Finalize)
			{
				switch (summaryID)
				{
					case 1:
						e.TotalValue = m_PoolQuantityUsed;
						break;
				}
			}

		}

		private void poolDetailsGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
		{

			try
			{
				if (e.Column.FieldName == "itemQuantityUsedGridColumn")
				{
					if (e.IsGetData)
					{
						while (m_PoolItemQtyUsed.Count - 1 < e.ListSourceRowIndex)
						{
							m_PoolItemQtyUsed.Add(0);
						}
						e.Value = m_PoolItemQtyUsed[e.ListSourceRowIndex];
					}
					else
					{
						m_PoolItemQtyUsed[e.ListSourceRowIndex] = e.Value;
					}
				}
				if (e.Column.FieldName == "ItemQuantity")
				{
					if (e.IsGetData)
					{
						e.Value = ItemsBLL.GetQtyOnHandByID(m_InventoryUOW, Convert.ToInt32(poolDetailsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, rmItemGridColumn)), UsersBLL.GetUsersLocalLocation(m_InventoryUOW, Properties.Settings.Default.UserName).Oid);
					}
				}
			}
			catch
			{

			}

		}

		private void poolDetailsGridView_ShownEditor(object sender, EventArgs e)
		{

			poolDetailsGridView.ActiveEditor.Properties.ReadOnly = false;

		}

		private void projectDetailsGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
		{

			if (e.Column == colUnitsProduced)
			{
				Items item = m_InventoryUOW.GetObjectByKey<Items>(itemLookUpEdit.EditValue);
				if (item.intUnitsPerCase > 0)
				{
					projectDetailsGridView.SetFocusedRowCellValue(colBagsProduced, (Convert.ToInt32(projectDetailsGridView.GetFocusedRowCellValue(colUnitsProduced)) / item.intUnitsPerCase) * item.BagsPerCase);
				}
				if (item.intUnitsPerCase > 0 && item.intCasesPerPallet > 0)
				{
					projectDetailsGridView.SetFocusedRowCellValue(colPalletsProduced, Convert.ToInt32(projectDetailsGridView.GetFocusedRowCellValue(colUnitsProduced)) / item.intUnitsPerCase / item.intCasesPerPallet);
				}
			}

		}

		private void quantityTextEdit_Validated(System.Object sender, EventArgs e)
		{

			UpdatePallets();

		}

		private void saveSimpleButton_Click(System.Object sender, EventArgs e)
		{

			if (((int?)itemLookUpEdit.Properties.Tag).HasValue && ((int?)itemLookUpEdit.EditValue).HasValue && (int?)itemLookUpEdit.Properties.Tag != (int?)itemLookUpEdit.EditValue)
			{
				m_InventoryUOW.Delete(productionProjectDetailXpCollection);
				m_InventoryUOW.Save(productionProjectDetailXpCollection);
				productionProjectDetailXpCollection.Reload();
			}

			if (ValidateRecord())
			{
				try
				{
					if (SaveRecord())
					{
						if (m_LPNBaseNumber.HasValue)
						{
							//Dim inventoryRecord As Inventory = InventoryBLL.GetInventoryRecord(m_InventoryUOW, CType(saveSimpleButton.Tag, Integer), True)
							m_SavedRecord.LPNNumber = m_LPNBaseNumber;
							m_SavedRecord.Save();
						}
						m_InventoryUOW.CommitChanges();
					}
				}
				catch (Exception ex)
				{
					m_InventoryUOW.RollbackTransaction();
					MessageBox.Show(string.Format("There was an error while trying to save the current record, no changes were saved.{0}{1}", Environment.NewLine, ex.Message), "Saving Error");
				}
				finally
				{
					PrepareNewRecord();
				}
			}

		}

		private void ShortLPNLabelSimpleButton_Click(object sender, EventArgs e)
		{

			string labelText = string.Empty;

			if (((int?)itemLookUpEdit.Properties.Tag).HasValue && ((int?)itemLookUpEdit.EditValue).HasValue && (int?)itemLookUpEdit.Properties.Tag != (int?)itemLookUpEdit.EditValue)
			{
				m_InventoryUOW.Delete(productionProjectDetailXpCollection);
				m_InventoryUOW.Save(productionProjectDetailXpCollection);
				productionProjectDetailXpCollection.Reload();
			}

			if (ValidateRecord())
			{
				try
				{
					if (SaveRecord())
					{
						//Dim inventoryRecord As Inventory = InventoryBLL.GetInventoryRecord(m_InventoryUOW, CType(saveSimpleButton.Tag, Integer), True)
						if (m_LPNBaseNumber.HasValue)
						{
							m_SavedRecord.LPNNumber = m_LPNBaseNumber;
							m_SavedRecord.Save();
						}

						labelText = LPNLabel.CreateLPNLabel(m_InventoryUOW, m_SavedRecord, true);
						if (string.IsNullOrEmpty(labelText))
						{
							MessageBox.Show("The record was saved without generating an LPN Label");
						}
						m_InventoryUOW.CommitChanges();
						if (string.IsNullOrEmpty(labelText) == false)
						{
							LPNLabel.SendLPNLabelToGenericPrinter(CompanySettingsBLL.GetSettings().LPNPrinterName, labelText);
						}
					}
				}
				catch (Exception ex)
				{
					m_InventoryUOW.RollbackTransaction();
					MessageBox.Show(string.Format("There was an error while trying to save the current record, no changes were saved.{0}{1}", Environment.NewLine, ex.Message), "Saving Error");
				}
				finally
				{
					PrepareNewRecord();
				}
			}

		}

		public bool CheckPermissions()
		{

			try
			{
				SPG.UserPermissionsRow permission = (new UserPermissionsBLL()).GetUserPermissionsByUserName(Properties.Settings.Default.UserName, "Production Entries")[0];

				switch (permission.PermissionLevel)
				{

					case "FULL":
					case "Full":
						m_AllowAdd = true;
						editSimpleButton.Enabled = true;
						deleteGridColumn.Visible = true;
						inventoryDateEdit.Enabled = true;
						break;
					case "ADD":
					case "Add":
						m_AllowAdd = true;
						editSimpleButton.Enabled = true;
						deleteGridColumn.Visible = false;
						inventoryDateEdit.Enabled = false;
						break;
					case "NONE":
					case "None":
						MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						Close();
						return false;
					case "VIEW":
					case "View":
						editSimpleButton.Enabled = false;
						deleteGridColumn.Visible = false;
						inventoryDateEdit.Enabled = false;
						break;
					case "EDIT":
					case "Edit":
						editSimpleButton.Enabled = true;
						deleteGridColumn.Visible = false;
						inventoryDateEdit.Enabled = false;
						break;
					case "VIEW ASSIGNED":
						editSimpleButton.Enabled = false;
						deleteGridColumn.Visible = false;
						inventoryDateEdit.Enabled = false;
						FilterAssignedCustomers();
						break;
					case "EDIT ASSIGNED":
						editSimpleButton.Enabled = true;
						deleteGridColumn.Visible = false;
						inventoryDateEdit.Enabled = false;
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

		public void FillInventoryView(int? pallet = null)
		{

			CriteriaOperatorCollection inventoryViewCriteria = new CriteriaOperatorCollection();

			if (((DateTime?)fromFilterDateEdit.EditValue).HasValue)
			{
				inventoryViewCriteria.Add(new BinaryOperator(Inventory.Fields.InventoryDate.PropertyName, Convert.ToDateTime(fromFilterDateEdit.EditValue), BinaryOperatorType.GreaterOrEqual));
			}
			if (((DateTime?)toFilterDateEdit.EditValue).HasValue)
			{
				inventoryViewCriteria.Add(new BinaryOperator(Inventory.Fields.InventoryDate.PropertyName, Convert.ToDateTime(toFilterDateEdit.EditValue), BinaryOperatorType.LessOrEqual));
			}
			if (((int?)customerFilterLookUpEdit.EditValue).HasValue)
			{
				inventoryViewCriteria.Add(new BinaryOperator(Inventory.Fields.InventoryItemID.ItemCustomerID.CustomerID.PropertyName, Convert.ToInt32(customerFilterLookUpEdit.EditValue), BinaryOperatorType.Equal));
			}
			if (string.IsNullOrEmpty((lotFilterTextEdit.EditValue == null ? null : Convert.ToString(lotFilterTextEdit.EditValue))) == false)
			{
				inventoryViewCriteria.Add(new BinaryOperator(Inventory.Fields.Lot.PropertyName, (lotFilterTextEdit.EditValue == null ? null : Convert.ToString(lotFilterTextEdit.EditValue)), BinaryOperatorType.Equal));
			}
			if (((int?)itemFilterLookUpEdit.EditValue).HasValue)
			{
				inventoryViewCriteria.Add(new BinaryOperator(Inventory.Fields.InventoryItemID.ItemID.PropertyName, Convert.ToInt32(itemFilterLookUpEdit.EditValue), BinaryOperatorType.Equal));
			}
			if (((int?)shiftFilterLookUpEdit.EditValue).HasValue)
			{
				inventoryViewCriteria.Add(new BinaryOperator(Inventory.Fields.Shift.PropertyName, Convert.ToInt32(shiftFilterLookUpEdit.EditValue), BinaryOperatorType.Equal));
			}
			if (string.IsNullOrEmpty((LPNFilterTextEdit.EditValue == null ? null : Convert.ToString(LPNFilterTextEdit.EditValue))) == false)
			{
				inventoryViewCriteria.Add(new BinaryOperator(Inventory.Fields.LPNNumber.PropertyName, Convert.ToInt32(LPNFilterTextEdit.EditValue), BinaryOperatorType.Equal));
			}

			if (pallet.HasValue)
			{
				inventoryViewCriteria.Add(new BinaryOperator(Inventory.Fields.Pallet.PropertyName, pallet.Value, BinaryOperatorType.Equal));
			}

			inventoryXPView.Criteria = CriteriaOperator.And(inventoryViewCriteria);

			//Me.inventoryGridControl.DataSource = m_Inventory.GetInventoryView(CType(Me.fromFilterDateEdit.EditValue, Date?), CType(Me.toFilterDateEdit.EditValue, Date?), _
			//                                                                  CType(Me.customerFilterLookUpEdit.EditValue, Integer?), CType(Me.itemFilterLookUpEdit.EditValue, Integer?), _
			//                                                                  CStr(Me.lotFilterTextEdit.EditValue))

		}

		private void FilterAssignedCustomers()
		{

			inventoryXPView.Filter = new InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(m_InventoryUOW));
			customersXPView.Criteria = CriteriaOperator.And(new BinaryOperator(Customers.Fields.Inactive.PropertyName, false), new InOperator(Customers.Fields.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_InventoryUOW)));
			itemsFilterXPView.Criteria = CriteriaOperator.And(new InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_InventoryUOW)), new InOperator(Items.Fields.ItemType.PropertyName, new string[] {"FG", "IG"}));
			itemsXPView.Criteria = CriteriaOperator.And(new InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_InventoryUOW)), new InOperator(Items.Fields.ItemType.PropertyName, new string[] {"FG", "IG"}), new BinaryOperator(Items.Fields.Inactive.PropertyName, false));

		}

		private bool OptionalInfoMissing()
		{

			StringBuilder msg = new StringBuilder(string.Empty);

			if (string.IsNullOrEmpty(palletsTextEdit.Text))
			{
				msg.Append("Pallets quantity, ");
			}

			if (string.IsNullOrEmpty(lotTextEdit.Text))
			{
				msg.Append("Lot #, ");
			}

			if (shiftLookUpEdit.EditValue == null || (shiftLookUpEdit.EditValue == null ? null : Convert.ToString(shiftLookUpEdit.EditValue)) == shiftLookUpEdit.Properties.NullText)
			{
				msg.Append("Shift, ");
			}

			if (expirationDateEdit.EditValue == null)
			{
				msg.Append("Expiration date, ");
			}

			if (msg.Length > 0)
			{
				if (MessageBox.Show(string.Format("The {0} field/s are empty. {1} Do you want to save the record.", msg.ToString().Substring(0, msg.Length - 2), Environment.NewLine), "Save Inventory", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
				{
					return true;
				}
			}

//INSTANT C# NOTE: Inserted the following 'return' since all code paths must return a value in C#:
			return false;
		}

		public void PrepareNewRecord()
		{

			saveSimpleButton.Tag = null;
			editSimpleButton.Tag = null;
			m_SavedRecord = null;
			descriptionMemoEdit.Text = null;
			onHandTextEdit.Text = null;
			//If Now.TimeOfDay < New TimeSpan(9, 0, 0) Then
			//inventoryDateEdit.DateTime = DateAdd(DateInterval.Day, -1, Today)
			//Else
			inventoryDateEdit.DateTime = DateTime.Now;
			//End If
			itemLookUpEdit.EditValue = null;
			itemLookUpEdit.Properties.Tag = null;
			itemLookUpEdit.Properties.ReadOnly = false;
			quantityTextEdit.Text = null;
			quantityTextEdit.Properties.Tag = null;
			palletsTextEdit.Text = null;
			lotTextEdit.EditValue = null;
			poTextEdit.EditValue = null;
			shiftLookUpEdit.EditValue = null;
			palletNumberTextEdit.EditValue = null;
			expirationDateEdit.EditValue = null;
			noteMemoEdit.EditValue = null;
			m_LPNBaseNumber = null;
			expirationDateEdit.Properties.DisplayFormat.FormatString = "d";
			expirationDateEdit.Properties.EditFormat.FormatString = "d";

			m_PoolItemQtyUsed.Clear();

			poolDetailsXpCollection.Criteria = new BinaryOperator(PoolBom.Fields.PoolBomFiniGoodID.ItemID.PropertyName, 0, BinaryOperatorType.Equal);
			UpdatePoolDetailsXpViewCriteria();

			productionProjectDetailXpCollection.Criteria = new BinaryOperator(ProductionProjectDetails.Fields.Production.InventoryID.PropertyName, 0, BinaryOperatorType.Equal);
			projectDetailsGridView.OptionsBehavior.Editable = false;

			//will update the new LPN number in the  view
			inventoryXPView.Reload();

			inventoryDateEdit.Focus();

		}

		//Private Shared Sub PrintPalletTicket(ByVal inventoryID As Integer)

		//    Dim inventoryRecord As Inventory = InventoryBLL.GetInventoryRecord(inventoryID, True)

		//    Dim ticket As New PalletTicketXtraReport()
		//    ticket.customerXrLabel.Text = inventoryRecord.InventoryItemID.ItemCustomerID.CustomerName
		//    ticket.itemXrLabel.Text = inventoryRecord.InventoryItemID.ItemCode
		//    ticket.itemDescriptionXrLabel.Text = inventoryRecord.InventoryItemID.ItemDescription
		//    Select Case inventoryRecord.InventoryItemID.ItemType
		//        Case "RM"
		//            ticket.itemTypeXrLabel.Text = "Raw Material"
		//        Case "IG"
		//            ticket.itemTypeXrLabel.Text = "Intermediate Goods"
		//        Case "FG"
		//            ticket.itemTypeXrLabel.Text = "Finished Goods"
		//        Case Else
		//            ticket.itemTypeXrLabel.Text = Nothing
		//    End Select
		//    ticket.casesPerPalletXrLabel.Text = inventoryRecord.InventoryQuantity.ToString
		//    ticket.lotCodeXrLabel.Text = inventoryRecord.Lot
		//    ticket.shiftXrLabel.Text = inventoryRecord.Shift.ShiftName
		//    ticket.shiftXrLabel.Visible = True
		//    ticket.palletXrLabel.Text = inventoryRecord.Pallet.ToString
		//    ticket.palletXrLabel.Visible = True
		//    ticket.dateXrLabel.Text = inventoryRecord.InventoryDate.ToShortDateString & vbCrLf & inventoryRecord.dtmEnteredOn.ToShortTimeString
		//    ticket.dateXrLabel.Visible = True
		//    ticket.ShowPreview()

		//End Sub

		private bool RequiredInfoMissing()
		{

			StringBuilder str = new StringBuilder(string.Empty);

			if (string.IsNullOrEmpty(quantityTextEdit.Text))
			{
				str.Append("quantity, ");
				quantityTextEdit.Focus();
			}

			if (itemLookUpEdit.EditValue == null || (itemLookUpEdit.EditValue == null ? null : Convert.ToString(itemLookUpEdit.EditValue)) == itemLookUpEdit.Properties.NullText)
			{
				str.Append("Item Code, ");
				itemLookUpEdit.Focus();
			}

			if (saveSimpleButton.Tag == null)
			{
				if (shiftLookUpEdit.EditValue == null || (shiftLookUpEdit.EditValue == null ? null : Convert.ToString(shiftLookUpEdit.EditValue)) == shiftLookUpEdit.Properties.NullText)
				{
					str.Append("Shift, ");
					shiftLookUpEdit.Focus();
				}
			}

			if (str.Length > 0)
			{
				MessageBox.Show(string.Format("You must provide a {0}.", str.ToString().Substring(0, str.Length - 2)));
				return true;
			}

			return false;

		}

		public void SavePoolBom()
		{

			Dictionary<int, float> poolScrapFactor = new Dictionary<int, float>();

			if (poolDetailsXpCollection.Count > 0)
			{
				int i = 0;
				double quantityConsumed = 0;

				foreach (PoolBom pool in poolDetailsXpCollection)
				{
					poolScrapFactor.Add(pool.ItemPoolID.Oid, Convert.ToSingle(pool.ScrapFactor / 100));
				}

				while (poolDetailsGridView.IsValidRowHandle(i))
				{
					quantityConsumed = BomConsumptionBLL.UpdateBomConsumption(m_InventoryUOW, m_InventoryUOW.GetObjectByKey<Items>(Convert.ToInt32(poolDetailsGridView.GetRowCellValue(i, rmItemGridColumn))), m_SavedRecord, Convert.ToSingle(poolDetailsGridView.GetRowCellValue(i, itemQuantityUsedGridColumn)), poolScrapFactor[Convert.ToInt32(poolDetailsGridView.GetRowCellValue(i, itemPoolIDGridColumn))] * Convert.ToSingle(poolDetailsGridView.GetRowCellValue(i, itemQuantityUsedGridColumn)));

					m_Items.UpdateStock(m_InventoryUOW, Convert.ToInt32(poolDetailsGridView.GetRowCellValue(i, rmItemGridColumn)), (float)(quantityConsumed * -1), false, UsersBLL.GetUsersLocalLocation(m_InventoryUOW, Properties.Settings.Default.UserName).Oid);

					i += 1;
				}
			}

		}

		private void SaveProjectDetails()
		{

			int? itemId = (int?)itemLookUpEdit.EditValue;
			int? oldQuantity = (int?)quantityTextEdit.Properties.Tag;

			if (oldQuantity.HasValue == false)
			{
				oldQuantity = 0;
			}

			int newQuantity = Convert.ToInt32(quantityTextEdit.EditValue) - oldQuantity.Value;

			if (newQuantity > 0)
			{
				ProjectDetailsBLL.AssignToProjects(m_InventoryUOW, m_SavedRecord, itemId, newQuantity);
			}

		}

		public bool SaveRecord()
		{

			if (saveSimpleButton.Tag == null)
			{
				if (m_AllowAdd == true)
				{
					saveSimpleButton.Tag = InventoryBLL.GetNewInventoryID();
				}
				else
				{
					return false;
				}
			}

			m_SavedRecord = m_Inventory.UpdateInventory(m_InventoryUOW, Convert.ToInt32(saveSimpleButton.Tag), inventoryDateEdit.DateTime, Convert.ToInt32(itemLookUpEdit.EditValue), Utilities.ChangeType<int>(quantityTextEdit.EditValue), Utilities.ChangeType<float?>(palletsTextEdit.EditValue), Convert.ToString(poTextEdit.EditValue), Convert.ToString(lotTextEdit.EditValue), Utilities.ChangeType<int?>(shiftLookUpEdit.EditValue), Utilities.ChangeType<int?>(palletNumberTextEdit.EditValue), Utilities.ChangeType<DateTime?>(expirationDateEdit.EditValue), UsersBLL.GetUsersLocalLocation(m_InventoryUOW, Properties.Settings.Default.UserName).Oid, Convert.ToString(noteMemoEdit.EditValue));
			if (m_SavedRecord == null)
			{
				MessageBox.Show("The inventory record was not updated successfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else
			{
				SavePoolBom();
				SaveProjectDetails();
			}

			// delete record from view if we are updating a record
			inventoryXPView.Reload();

			return true;

		}

		public void SetDefaultViewFilter()
		{

			//Set the from filter to the sunday of this week
			fromFilterDateEdit.DateTime = DateTime.Today.AddDays((Microsoft.VisualBasic.DateAndTime.Weekday(DateTime.Today) - 1) * -1);
			toFilterDateEdit.DateTime = DateTime.Today.AddMinutes(1439);
			customerFilterLookUpEdit.EditValue = null;
			itemFilterLookUpEdit.EditValue = null;
			lotFilterTextEdit.EditValue = null;
			shiftFilterLookUpEdit.EditValue = null;

		}

		private void UpdateBomPoolUsed()
		{

			if (poolDetailsXpCollection.Count > 0)
			{
				int i = 0;
				CriteriaOperatorCollection consumptionCriteria = new CriteriaOperatorCollection();

				while (poolDetailsGridView.IsValidRowHandle(i))
				{
					consumptionCriteria.Clear();

					consumptionCriteria.Add(new BinaryOperator(BomConsumption.Fields.RawMatID.ItemID.PropertyName, Convert.ToInt32(poolDetailsGridView.GetRowCellValue(i, rmItemGridColumn)), BinaryOperatorType.Equal));
					consumptionCriteria.Add(new BinaryOperator(BomConsumption.Fields.InventoryID.InventoryID.PropertyName, Convert.ToInt32(saveSimpleButton.Tag), BinaryOperatorType.Equal));

					m_InventoryUOW.Evaluate<BomConsumption>(BomConsumption.Fields.QuantityUsed, new GroupOperator(GroupOperatorType.And, consumptionCriteria));

					poolDetailsGridView.SetRowCellValue(i, itemQuantityUsedGridColumn, m_InventoryUOW.Evaluate<BomConsumption>(BomConsumption.Fields.QuantityUsed, new GroupOperator(GroupOperatorType.And, consumptionCriteria)));

					i += 1;
				}
			}

		}

		private void UpdatePallets()
		{

			if (itemLookUpEdit.EditValue == null || itemLookUpEdit.Text == itemLookUpEdit.Properties.NullText || string.IsNullOrEmpty(quantityTextEdit.Text))
			{
				return;
			}

			float pallets = m_Items.GetPallets(Convert.ToInt32(itemLookUpEdit.EditValue));
			if (pallets != 0)
			{
				palletsTextEdit.Text = (Convert.ToDouble(quantityTextEdit.EditValue) / pallets).ToString("f2");
			}
			else
			{
				palletsTextEdit.EditValue = 0;
			}

		}

		private void UpdatePoolDetailsXpViewCriteria()
		{

			CriteriaOperatorCollection poolCriteria = new CriteriaOperatorCollection();

			for (int i = 0; i < poolDetailsXpCollection.Count; i++)
			{
				poolCriteria.Add(new InOperator("Oid", ((PoolBom)poolDetailsXpCollection[i]).ItemPoolID.Details));
			}

			if (poolCriteria.Count > 0)
			{
				poolDetailsXpView.Criteria = new GroupOperator(GroupOperatorType.Or, poolCriteria);
			}
			else
			{
				poolDetailsXpView.Criteria = new BinaryOperator("Oid", 0, BinaryOperatorType.Equal);
			}

		}

		private string ValidatePoolDetails()
		{

			Dictionary<string, double> poolQuantitiesNeeded = new Dictionary<string, double>();

			if (poolDetailsXpCollection.Count > 0)
			{
				foreach (PoolBom pool in poolDetailsXpCollection)
				{
					poolQuantitiesNeeded.Add(pool.ItemPoolID.PoolCode, (pool.PoolBomQuantity) * Utilities.ChangeType<int>(quantityTextEdit.EditValue));
				}

				int i = -1;
				double amountNeeded = 0;
				double amountUsed = 0;
				while (poolDetailsGridView.IsValidRowHandle(i))
				{
					amountNeeded = poolQuantitiesNeeded[Convert.ToString(poolDetailsGridView.GetGroupRowValue(i))];
					amountUsed = Convert.ToDouble(poolDetailsGridView.GetGroupSummaryValue(i, poolDetailsGridView.GroupSummary[0] as GridGroupSummaryItem));
					if (amountNeeded - 0.5 > amountUsed || Math.Round(amountUsed, 2) > amountNeeded + 1)
					{
						return string.Format("{0} Amount Needed = {1} Amount Used = {2}", Convert.ToString(poolDetailsGridView.GetGroupRowValue(i)), amountNeeded, amountUsed);
					}
					i -= 1;
				}

				return null;
			}
			else
			{
				return null;
			}

		}

		private bool ValidateProject()
		{

			projectDetailsGridView.CloseEditor();

			int? itemId = (int?)itemLookUpEdit.EditValue;

			if (ProjectDetailsBLL.IsItOnSchedule(m_InventoryUOW, itemId) == false)
			{
				if (saveSimpleButton.Tag == null || m_InventoryUOW.GetObjectByKey<Inventory>(saveSimpleButton.Tag) == null)
				{
					if (MessageBox.Show("This item is not on schedule", "Item not in schedule", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
					{
						return false;
					}
					else
					{
						return true;
					}
				}
				else
				{
					if (m_InventoryUOW.GetObjectByKey<Inventory>(saveSimpleButton.Tag).ProductionProject.Count == 0)
					{
						return true;
					}
				}
			}

			int? oldQuantity = (int?)quantityTextEdit.Properties.Tag;

			if (oldQuantity.HasValue == false)
			{
				oldQuantity = 0;
			}

			int newQuantity = Convert.ToInt32(quantityTextEdit.EditValue) - oldQuantity.Value;

			if (newQuantity > 0 && ProjectDetailsBLL.CanAssignToProjects(m_InventoryUOW, itemId, newQuantity) == false)
			{
				if (MessageBox.Show("You produced more than is scheduled." + Environment.NewLine + "Do you want to continue?", "Production Overrun", MessageBoxButtons.YesNo) == DialogResult.No)
				{
					return false;
				}
			}
			else if (newQuantity < 0)
			{
				int totalAssigned = 0;
				productionDetailsXtraTabControl.TabPages[1].Show();
				if (colUnitsProduced.Summary[0].SummaryValue == null)
				{
					totalAssigned = 0;
				}
				else
				{
					totalAssigned = Convert.ToInt32(colUnitsProduced.Summary[0].SummaryValue);
				}
				if (totalAssigned > Convert.ToInt32(quantityTextEdit.EditValue))
				{
					MessageBox.Show("The total quantity assigned to projects can't be bigger than the quantity produced." + Environment.NewLine + "Please update the project details before saving the record.");
					return false;
				}
			}

			return true;

		}

		private bool ValidateQuantity()
		{

			int? previousQuantity = null;

			if (((int?)itemLookUpEdit.Properties.Tag).HasValue == false || Utilities.ChangeType<int?>(itemLookUpEdit.EditValue) == Utilities.ChangeType<int?>(itemLookUpEdit.Properties.Tag))
			{
				previousQuantity = (int?)quantityTextEdit.Properties.Tag;
			}
			else
			{
				previousQuantity = 0;
			}

			string availability = ItemsBLL.GetAvailabilityByItemID(m_InventoryUOW, Convert.ToInt32(itemLookUpEdit.EditValue), Utilities.ChangeType<int>(quantityTextEdit.EditValue), previousQuantity, UsersBLL.GetUsersLocalLocation(m_InventoryUOW, Properties.Settings.Default.UserName).Oid);

			if (string.IsNullOrEmpty(availability) == false)
			{
				if (MessageBox.Show(availability + "Do you want to save the record?", "Save Inventory", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
				{
					return false;
				}
			}

			return true;

		}

		public bool ValidateRecord()
		{

			if (RequiredInfoMissing())
			{
				return false;
			}

			string ValidationMessage = ValidatePoolDetails();

			if (string.IsNullOrEmpty(ValidationMessage) == false)
			{
				MessageBox.Show(string.Format("You must provide the details for the pool items used.{0}{1}", Environment.NewLine, ValidationMessage));
				return false;
			}

			if (OptionalInfoMissing())
			{
				return false;
			}

			if (ValidateQuantity() == false)
			{
				return false;
			}

			if (ValidateProject() == false)
			{
				return false;
			}

			if (saveSimpleButton.Tag == null)
			{
				if (m_AllowAdd == true)
				{
					saveSimpleButton.Tag = InventoryBLL.GetNewInventoryID();
				}
				else
				{
					return false;
				}
			}

			return true;

		}

		private void inventoryGridView_FilterEditorCreated(object sender, DevExpress.XtraGrid.Views.Base.FilterControlEventArgs e)
		{
			e.FilterControl.BeforeShowValueEditor += FilterControl_BeforeShowValueEditor;
		}

		private void FilterControl_BeforeShowValueEditor(object sender, DevExpress.XtraEditors.Filtering.ShowValueEditorEventArgs e)
		{
			if (e.CurrentNode.FirstOperand.PropertyName == "InventoryDate")
			{
				DateEdit editor = (DateEdit)e.Editor;
				editor.Width = 200;
				editor.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
				editor.Properties.CalendarTimeProperties.Mask.EditMask = "g";
				editor.Properties.TimeEditWidth = 150;
			}
		}
	}
}