//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.Data.Filtering;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using DXDAL.SPGData;

namespace SuperiorPackGroup
{
	public partial class ReceivingXtraForm
	{

		public ReceivingXtraForm()
		{
			InitializeComponent();
		}

		private string m_upc;
		private Dictionary<int?, int?> m_lpnItems = new Dictionary<int?, int?>();
		private Dictionary<int, int> m_TempId = new Dictionary<int, int>();
		private int m_lastLPN;
		private int m_lastItem;
		private ReceivingsBLL m_Receivings;
		private CustomersBLL m_CustomerReceivings;
		private ShiftsBLL m_Shifts;
		private CarriersBLL m_Carriers;
		private ReceivingDetailsBLL m_ReceivingDetails;
		private ReturnDetailsBLL m_ReturnDetails;
		private ItemsBLL m_Items;
		private UserPermissionsBLL m_UserPermissions;
		private int? m_CurrentReceivingID;
		private readonly Session m_ReceivingSession = new Session(MyDataLayers.SPGDataLayer)
		{
			TrackPropertiesModifications = true,
			OptimisticLockingReadBehavior = OptimisticLockingReadBehavior.MergeCollisionThrowException
		};

		private void ReceivingXtraForm_FormClosing(object sender, FormClosingEventArgs e)
		{

			if (this.receivingSearchGridControl.Enabled == false)
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

		}

		private void ReceivingXtraForm_Load(object sender, EventArgs e)
		{

			this.Cursor = Cursors.WaitCursor;
			m_Receivings = new ReceivingsBLL();
			m_CustomerReceivings = new CustomersBLL();
			m_Shifts = new ShiftsBLL();
			m_Carriers = new CarriersBLL();
			m_ReceivingDetails = new ReceivingDetailsBLL();
			m_ReturnDetails = new ReturnDetailsBLL();
			m_Items = new ItemsBLL();
			m_UserPermissions = new UserPermissionsBLL();

			CheckPermissions();

			LinkSession();

			BindReceivingsSearchGrid();

			shiftLookUpEdit.Properties.DataSource = m_Shifts.GetShifts();
			this.shiftLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo());
			this.shiftLookUpEdit.Properties.Columns[0].FieldName = "ShiftName";
			this.shiftLookUpEdit.Properties.Columns[0].Caption = "Shift";
			this.shiftLookUpEdit.Properties.DisplayMember = "ShiftName";
			this.shiftLookUpEdit.Properties.ValueMember = "ShiftID";

			carrierLookUpEdit.Properties.DataSource = m_Carriers.GetCarrierIDAndNames();
			this.carrierLookUpEdit.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo());
			this.carrierLookUpEdit.Properties.Columns[0].FieldName = "CarrierName";
			this.carrierLookUpEdit.Properties.Columns[0].Caption = "Carrier Name";
			this.carrierLookUpEdit.Properties.DisplayMember = "CarrierName";
			this.carrierLookUpEdit.Properties.ValueMember = "CarrierID";

			this.idGridColumn.FieldName = "ReceivDetID";
			this.receivingIDGridColumn.FieldName = "ReceivMainID";
			this.itemGridColumn.FieldName = "ReceivDetItemID";
			this.quantityGridColumn.FieldName = "ReceivDetQty";
			this.packagesGridColumn.FieldName = "intUnits";
			this.ReceivDetLPNColumn.FieldName = "ReceivDetLPN";
			this.lotGridColumn.FieldName = "ReceivDetLot";
			expirationDateGridColumn.FieldName = "ExpirationDate";

			this.returnIDGridColumn.FieldName = "ReturnDetID";
			this.ReceiveMainIDGridColumn.FieldName = "ReceiveMainID";
			this.returnItemGridColumn.FieldName = "ReturnDetItemID";
			this.returnQuantityGridColumn.FieldName = "ReturnDetQty";
			this.returnUnitsGridColumn.FieldName = "intUnits";
			this.returnPalletsGridColumn.FieldName = "sngPallets";
			this.returnLotGridColumn.FieldName = "ReturnDetLot";
			this.returnReasonGridColumn.FieldName = "Reason";
			returnExpirationDateGridColumn.FieldName = "ExpirationDate";

			Utilities.MakeFormReadOnly(generalXtraTabPage, true);
			this.receivingGridView.OptionsBehavior.Editable = false;
			this.BulkEntryGroupControl.Enabled = false;
			Utilities.MakeGridReadOnly(this.returnsGridView, true);
			this.receivingSearchGridControl.Enabled = true;

			cancelBarButtonItem.Enabled = false;
			saveBarButtonItem.Enabled = false;
			refreshBarButtonItem.Enabled = false;
			this.SaveContinueSimpleButton.Enabled = false;

			this.Cursor = Cursors.Default;

		}

		public void BindReceivingsSearchGrid()
		{

			receivingSearchXPView.Reload();

		}

		public void BindReceivingsControls(int receivingID)
		{

			if (receivingID == -1)
			{
				return;
			}

			//Dim receiving As SPG.ReceivingsRow = CType(m_Receivings.GetReceivingsByID(receivingID).Rows(0), SPG.ReceivingsRow)
			Receiving receiving = m_ReceivingSession.GetObjectByKey<Receiving>(receivingID);
			if (receiving == null)
			{
				return;
			}
			m_CurrentReceivingID = receiving.ReceivID;
			this.customerLookUpEdit.EditValue = receiving.ReceivCustID.CustomerID;
			this.receiveDateEdit.EditValue = receiving.ReceivDate;
			this.shiftLookUpEdit.EditValue = receiving.intShiftID.ShiftID;
			this.bolTextEdit.Text = receiving.ReceivBOL;
			this.poTextEdit.Text = receiving.strPO;
			this.carrierLookUpEdit.EditValue = receiving.ReceivCarrierID.CarrierID;
			if (receiving.strVendor != null)
			{
				this.vendorLookUpEdit.EditValue = receiving.strVendor.Oid;
			}
			else
			{
				this.vendorLookUpEdit.EditValue = null;
			}
			this.trailerTextEdit.Text = receiving.strTrailer;
			this.sealTextEdit.Text = receiving.strSeal;
			this.skitsTextEdit.EditValue = receiving.sngSkits;
			this.palletsTextEdit.EditValue = receiving.sngTotalPallets;
			this.notesMemoEdit.EditValue = receiving.Notes;
			if (receiving.UnloadedBy == null)
			{
				unloadedByLookUpEdit.EditValue = null;
			}
			else
			{
				unloadedByLookUpEdit.EditValue = receiving.UnloadedBy.Oid;
			}
			if (receiving.CheckedBy == null)
			{
				checkedByLookUpEdit.EditValue = null;
			}
			else
			{
				checkedByLookUpEdit.EditValue = receiving.CheckedBy.Oid;
			}
			if ((int)receiving.WheelsChocked == 0)
			{
				wheelsChockedComboBoxEdit.EditValue = null;
			}
			else
			{
				wheelsChockedComboBoxEdit.EditValue = Enum.GetName(typeof(DXDAL.ThreeWayYesNo), receiving.WheelsChocked);
			}
			if (receiving.StartTime.Equals(default(DateTime)))
			{
				startTimeEdit.EditValue = null;
			}
			else
			{
				startTimeEdit.EditValue = receiving.StartTime;
			}
			if (receiving.FinishTime.Equals(default(DateTime)))
			{
				finishTimeEdit.EditValue = null;
			}
			else
			{
				finishTimeEdit.EditValue = receiving.FinishTime;
			}
			if (receiving.Temparature == 0)
			{
				temperatureSpinEdit.EditValue = null;
			}
			else
			{
				temperatureSpinEdit.EditValue = receiving.Temparature;
			}
			if (receiving.PhysicalCondition == null)
			{
				physicalConditionLookUpEdit.EditValue = null;
			}
			else
			{
				physicalConditionLookUpEdit.EditValue = receiving.PhysicalCondition.Oid;
			}
			if (receiving.LoadCondition == null)
			{
				loadConditionLookUpEdit.EditValue = null;
			}
			else
			{
				loadConditionLookUpEdit.EditValue = receiving.LoadCondition.Oid;
			}
			if ((int)receiving.ForeignSubstance == 0)
			{
				foreignSubstanceComboBoxEdit.EditValue = null;
			}
			else
			{
				foreignSubstanceComboBoxEdit.EditValue = Enum.GetName(typeof(DXDAL.ThreeWayYesNo), receiving.ForeignSubstance);
			}
			if ((int)receiving.InsectActivity == 0)
			{
				insectActivityComboBoxEdit.EditValue = null;
			}
			else
			{
				insectActivityComboBoxEdit.EditValue = Enum.GetName(typeof(DXDAL.ThreeWayYesNo), receiving.InsectActivity);
			}
			if ((int)receiving.CorrectPallets == 0)
			{
				correctPalletsComboBoxEdit.EditValue = null;
			}
			else
			{
				correctPalletsComboBoxEdit.EditValue = Enum.GetName(typeof(DXDAL.ThreeWayYesNo), receiving.CorrectPallets);
			}
			locationLookUpEdit.EditValue = receiving.ReceivingLocation.Oid;

			//fill details tab
			BindItemLookupEdit();

			BindReceivingGridControl(receivingID);

			//fill returns tab
			BindReturnsGridControl(receivingID);

			refreshBarButtonItem.Enabled = true;

		}

		private void BindReceivingGridControl(int? receivingID)
		{

			if (receivingID.HasValue == false)
			{
				receivingID = 0;
			}

			int? customer = (int?)this.customerLookUpEdit.EditValue;
			if (customer.HasValue)
			{
				expirationDateGridColumn.DisplayFormat.FormatString = CustomersBLL.GetExpirationDateFormat(customer.Value);
				ExpirationDateEdit.Properties.DisplayFormat.FormatString = CustomersBLL.GetExpirationDateFormat(customer.Value);
			}

			this.receivingGridControl.DataSource = m_ReceivingDetails.GetDetailsByReceivingID(receivingID.Value);

		}

		private void BindReturnsGridControl(int? receivingID)
		{

			if (receivingID.HasValue == false)
			{
				receivingID = 0;
			}

			int? customer = (int?)this.customerLookUpEdit.EditValue;
			if (customer.HasValue)
			{
				returnExpirationDateGridColumn.DisplayFormat.FormatString = CustomersBLL.GetExpirationDateFormat(customer.Value);
			}

			this.returnsGridControl.DataSource = m_ReturnDetails.GetDetailsByReceivingID(receivingID.Value);

		}

		private void BindItemLookupEdit()
		{

			int? customer = (int?)this.customerLookUpEdit.EditValue;
			if (customer.HasValue)
			{
				this.receivingItemXPView.Filter = CriteriaOperator.Or(new BinaryOperator("CustomerID", customer.Value, BinaryOperatorType.Equal), new BinaryOperator("CustomerID", CompanySettingsBLL.GetUniversalCustomer(), BinaryOperatorType.Equal), new InOperator("CustomerID", CustomersBLL.GetRelatedCustomerIDs(CustomersBLL.GetCustomer(customer.Value, m_ReceivingSession))));
				this.returnItemXPView.Filter = CriteriaOperator.Or(new BinaryOperator("CustomerID", customer.Value, BinaryOperatorType.Equal), new InOperator("CustomerID", CustomersBLL.GetRelatedCustomerIDs(CustomersBLL.GetCustomer(customer.Value, m_ReceivingSession))));
			}
			else
			{
				this.receivingItemXPView.Filter = null;
				this.returnItemXPView.Filter = null;
			}

		}

		private void receivingGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
		{

			if (!Convert.IsDBNull(receivingGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, this.itemGridColumn)) && e.Column.Name == descriptionGridColumn.Name)
			{
				e.Value = ItemsBLL.GetDescriptionByItemID((int?)receivingGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, this.itemGridColumn));
			}

		}

		private void returnsGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
		{

			if (!Convert.IsDBNull(returnsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, this.returnItemGridColumn)))
			{
				e.Value = ItemsBLL.GetDescriptionByItemID((int?)returnsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, this.returnItemGridColumn));
			}

		}

		private void receivingGridView_InitNewRow(object sender, InitNewRowEventArgs e)
		{

			this.receivingGridView.SetRowCellValue(e.RowHandle, this.receivingIDGridColumn, m_CurrentReceivingID);
			this.receivingGridView.SetRowCellValue(e.RowHandle, this.quantityGridColumn, 0);
			this.receivingGridView.SetRowCellValue(e.RowHandle, this.packagesGridColumn, 0);
			//.SetRowCellValue(e.RowHandle, Me.palletsGridColumn, 0)
			//.SetRowCellValue(e.RowHandle, Me.ReceivDetLPNFromColumn, GetNextLPN())

		}

		private void returnsGridView_InitNewRow(object sender, InitNewRowEventArgs e)
		{

			this.returnsGridView.SetRowCellValue(e.RowHandle, this.ReceiveMainIDGridColumn, m_CurrentReceivingID);
			this.returnsGridView.SetRowCellValue(e.RowHandle, this.returnQuantityGridColumn, 0);
			this.returnsGridView.SetRowCellValue(e.RowHandle, this.returnUnitsGridColumn, 0);
			this.returnsGridView.SetRowCellValue(e.RowHandle, this.returnPalletsGridColumn, 0);

		}

		private bool SaveChanges()
		{

			UpdateTotalPallets();

			//Required to get back to current receiving when entering a new receiving.
			int selectedID = -1;
			bool newReceiving = false;

			if (m_CurrentReceivingID.HasValue == false || m_CurrentReceivingID == -1)
			{
				newReceiving = true;
				m_CurrentReceivingID = ReceivingsBLL.GetNewReceivingID();
			}
			else
			{
				selectedID = receivingSearchGridView.FocusedRowHandle;
			}

			try
			{
				if (m_Receivings.UpdateReceiving(m_CurrentReceivingID.Value, (DateTime?)this.receiveDateEdit.EditValue, (int?)this.carrierLookUpEdit.EditValue, (int?)this.customerLookUpEdit.EditValue, this.bolTextEdit.Text, (int?)this.vendorLookUpEdit.EditValue, Utilities.ChangeType<float?>(this.skitsTextEdit.EditValue), Utilities.ChangeType<float?>(this.palletsTextEdit.EditValue), this.poTextEdit.Text, (int?)this.shiftLookUpEdit.EditValue, trailerTextEdit.Text, sealTextEdit.Text, Convert.ToString(notesMemoEdit.EditValue), (int?)unloadedByLookUpEdit.EditValue, (int?)checkedByLookUpEdit.EditValue, GetThreeWayYesNoValue(wheelsChockedComboBoxEdit.Text), (DateTime?)startTimeEdit.EditValue, (DateTime?)finishTimeEdit.EditValue, Utilities.ChangeType<double?>(temperatureSpinEdit.EditValue), (int?)physicalConditionLookUpEdit.EditValue, (int?)loadConditionLookUpEdit.EditValue, GetThreeWayYesNoValue(foreignSubstanceComboBoxEdit.Text), GetThreeWayYesNoValue(insectActivityComboBoxEdit.Text), GetThreeWayYesNoValue(correctPalletsComboBoxEdit.Text), Convert.ToInt32(locationLookUpEdit.EditValue)) != true)
				{
					MessageBox.Show("The receiving was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return false;
				}
			}
			catch (ApplicationException ex)
			{
				MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			bool lShouldReturn = false;
			bool lResult = SaveShippingDetails(ref lShouldReturn);
			if (lShouldReturn)
			{
				return lResult;
			}

			bool lShouldReturn1 = false;
			bool lResult1 = SaveShippingReturns(ref lShouldReturn1);
			if (lShouldReturn1)
			{
				return lResult1;
			}

			//If newReceiving Then
			//    printLpn(True)
			//End If

			BindReceivingsSearchGrid();
			BindReceivingsControls(m_CurrentReceivingID.Value);
			if (selectedID != -1)
			{
				this.receivingSearchGridView.FocusedRowHandle = selectedID;
			}
			return true;

		}

		private bool SaveShippingDetails(ref bool shouldReturn)
		{

			m_lpnItems.Clear();

			shouldReturn = false;

			try
			{
				receivingGridView.CloseEditor();
				if (receivingGridView.GroupCount > 0)
				{
					int i = -1;
					while (receivingGridView.IsValidRowHandle(i))
					{
						if (receivingGridView.GetChildRowHandle(i, 0) > -1)
						{
//INSTANT C# NOTE: The ending condition of VB 'For' loops is tested only on entry to the loop. Instant C# has created a temporary variable in order to use the initial value of receivingGridView.GetChildRowCount(i) + receivingGridView.GetChildRowHandle(i, 0) for every iteration:
							int tempVar = receivingGridView.GetChildRowCount(i) + receivingGridView.GetChildRowHandle(i, 0);
							for (int ci = receivingGridView.GetChildRowHandle(i, 0); ci < tempVar; ci++)
							{
								if (SaveShippingDetail(ref ci) != true)
								{
									MessageBox.Show("The receiving details was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
									shouldReturn = true;
									return false;
								}
							}
						}
						i -= 1;
					}
				}
				else
				{
					//receivingGridView.SelectAll()
					for (int ci = 0; ci < receivingGridView.RowCount; ci++)
					{
						if (SaveShippingDetail(ref ci) != true)
						{
							MessageBox.Show("The receiving details was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
							shouldReturn = true;
							return false;
						}
					}
				}
			}
			catch (ApplicationException ex)
			{
				MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
				shouldReturn = true;
				return false;
			}

			return false;

		}
		private bool SaveShippingDetail(ref int ci)
		{
			if (receivingGridView.IsValidRowHandle(ci))
			{
				string lot = null;

				if (!Convert.IsDBNull(receivingGridView.GetRowCellValue(ci, lotGridColumn)))
				{
					lot = receivingGridView.GetRowCellValue(ci, lotGridColumn).ToString();
				}
				else
				{
					lot = string.Empty;
				}


				int id = Convert.ToInt32(receivingGridView.GetRowCellValue(ci, idGridColumn));
				int? item = (int?)receivingGridView.GetRowCellValue(ci, itemGridColumn);
				int? qty = (int?)receivingGridView.GetRowCellValue(ci, quantityGridColumn);
				int? pckg = (int?)receivingGridView.GetRowCellValue(ci, packagesGridColumn);
				int? lpn = Utilities.ChangeType<int?>(receivingGridView.GetRowCellValue(ci, ReceivDetLPNColumn));
				DateTime? expr = Utilities.ChangeType<DateTime?>(receivingGridView.GetRowCellValue(ci, expirationDateGridColumn));

				if (m_lpnItems.ContainsKey(lpn) && m_lpnItems[lpn].HasValue && item.HasValue && m_lpnItems[lpn] != item)
				{
					MessageBox.Show($"LPN # {lpn} has multiple items");
					return false;
				}
				else if (!m_lpnItems.ContainsKey(lpn))
				{
					m_lpnItems.Add(lpn, item);
				}

				int tempId = m_ReceivingDetails.UpdateReceivingDetails(m_ReceivingSession, ((id < 0 && m_TempId.ContainsKey(id)) ? m_TempId[id] : id), m_CurrentReceivingID.Value, item, lot, qty, pckg, lpn, expr);

				if (tempId > 0)
				{
					if (!m_TempId.ContainsKey(id) && id < 0)
					{
						m_TempId.Add(id, tempId);
					}
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				return true;
			}

		}
		private bool SaveShippingReturns(ref bool shouldReturn)
		{

			shouldReturn = false;

			try
			{
				returnsGridView.CloseEditor();
				if (returnsGridView.GroupCount > 0)
				{
					int i = -1;
					while (returnsGridView.IsValidRowHandle(i))
					{
						if (returnsGridView.GetChildRowHandle(i, 0) > -1)
						{
//INSTANT C# NOTE: The ending condition of VB 'For' loops is tested only on entry to the loop. Instant C# has created a temporary variable in order to use the initial value of returnsGridView.GetChildRowCount(i) + returnsGridView.GetChildRowHandle(i, 0) for every iteration:
							int tempVar = returnsGridView.GetChildRowCount(i) + returnsGridView.GetChildRowHandle(i, 0);
							for (int ci = returnsGridView.GetChildRowHandle(i, 0); ci < tempVar; ci++)
							{
								if (returnsGridView.GetRowCellValue(ci, returnItemGridColumn) != null)
								{
									string lot = null;
									string reason = null;

									if (!Convert.IsDBNull(returnsGridView.GetRowCellValue(ci, returnLotGridColumn)) && returnsGridView.GetRowCellValue(ci, returnLotGridColumn) != null)
									{
										lot = returnsGridView.GetRowCellValue(ci, returnLotGridColumn).ToString();
									}
									else
									{
										lot = string.Empty;
									}

									if (!Convert.IsDBNull(returnsGridView.GetRowCellValue(ci, returnReasonGridColumn)) && returnsGridView.GetRowCellValue(i, returnReasonGridColumn) != null)
									{
										reason = returnsGridView.GetRowCellValue(ci, returnReasonGridColumn).ToString();
									}
									else
									{
										reason = string.Empty;
									}

									if (m_ReturnDetails.UpdateReturnDetails(m_ReceivingSession, (int?)returnsGridView.GetRowCellValue(ci, returnIDGridColumn), m_CurrentReceivingID.Value, (int?)returnsGridView.GetRowCellValue(ci, returnItemGridColumn), lot, (int?)returnsGridView.GetRowCellValue(ci, returnQuantityGridColumn), (int?)returnsGridView.GetRowCellValue(ci, returnUnitsGridColumn), (float?)returnsGridView.GetRowCellValue(ci, returnPalletsGridColumn), reason, Utilities.ChangeType<DateTime?>(returnsGridView.GetRowCellValue(ci, returnExpirationDateGridColumn))) != true)
									{
										MessageBox.Show("The return details were not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
										shouldReturn = true;
										return false;
									}
								}
							}
						}
						i -= 1;
					}
				}
				else
				{
					for (int i = 0; i < returnsGridView.RowCount; i++)
					{
						if (returnsGridView.IsValidRowHandle(i) && returnsGridView.GetRowCellValue(i, returnItemGridColumn) != null)
						{
							string lot = null;
							string reason = null;

							if (!Convert.IsDBNull(returnsGridView.GetRowCellValue(i, returnLotGridColumn)) && returnsGridView.GetRowCellValue(i, returnLotGridColumn) != null)
							{
								lot = returnsGridView.GetRowCellValue(i, returnLotGridColumn).ToString();
							}
							else
							{
								lot = string.Empty;
							}

							if (!Convert.IsDBNull(returnsGridView.GetRowCellValue(i, returnReasonGridColumn)) && returnsGridView.GetRowCellValue(i, returnReasonGridColumn) != null)
							{
								reason = returnsGridView.GetRowCellValue(i, returnReasonGridColumn).ToString();
							}
							else
							{
								reason = string.Empty;
							}

							if (m_ReturnDetails.UpdateReturnDetails(m_ReceivingSession, (int?)returnsGridView.GetRowCellValue(i, returnIDGridColumn), m_CurrentReceivingID.Value, (int?)returnsGridView.GetRowCellValue(i, returnItemGridColumn), lot, (int?)returnsGridView.GetRowCellValue(i, returnQuantityGridColumn), (int?)returnsGridView.GetRowCellValue(i, returnUnitsGridColumn), (float?)returnsGridView.GetRowCellValue(i, returnPalletsGridColumn), reason, Utilities.ChangeType<DateTime?>(returnsGridView.GetRowCellValue(i, returnExpirationDateGridColumn))) != true)
							{
								MessageBox.Show("The return details were not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
								shouldReturn = true;
								return false;
							}
						}
					}
				}
			}
			catch (ApplicationException ex)
			{
				MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
				shouldReturn = true;
				return false;
			}

			return false;

		}

		private void saveSimpleButton_Click(object sender, EventArgs e)
		{

			SaveChanges();

		}

		public void UpdateTotalPallets()
		{

			//Make sure the summary is updated before calculating the total pallets
			this.receivingGridView.UpdateTotalSummary();
			this.returnsGridView.UpdateTotalSummary();
			this.palletsTextEdit.Text = (Convert.ToInt32(ReceivDetLPNColumn.SummaryItem.SummaryValue) + Convert.ToDouble(returnPalletsGridColumn.SummaryItem.SummaryValue) + Math.Ceiling(Convert.ToDouble(this.skitsTextEdit.EditValue))).ToString("f2");

		}

		private void skitsTextEdit_Validated(object sender, EventArgs e)
		{

			UpdateTotalPallets();

		}

		private void returnsGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
		{

			if ((this.returnsGridView.GetFocusedRowCellValue(this.returnItemGridColumn) == null) || Convert.IsDBNull(this.returnsGridView.GetFocusedRowCellValue(this.returnItemGridColumn)))
			{
				return;
			}
//INSTANT C# NOTE: The following VB 'Select Case' included either a non-ordinal switch expression or non-ordinal, range-type, or non-constant 'Case' expressions and was converted to C# 'if-else' logic:
//				Select Case e.Column.Name
//ORIGINAL LINE: Case returnItemGridColumn.Name
			if (e.Column.Name == returnItemGridColumn.Name)
			{
				if (Convert.ToDouble(this.returnsGridView.GetFocusedRowCellValue(this.returnQuantityGridColumn)) > 0)
				{
					UpdateReturnPallets();
				}
			}
//ORIGINAL LINE: Case returnQuantityGridColumn.Name
			else if (e.Column.Name == returnQuantityGridColumn.Name)
			{
				UpdateReturnPallets();
			}
//ORIGINAL LINE: Case returnPalletsGridColumn.Name
			else if (e.Column.Name == returnPalletsGridColumn.Name)
			{
				UpdateTotalPallets();
			}

		}

		private void customerLookUpEdit_Validated(object sender, EventArgs e)
		{

			BindItemLookupEdit();

		}

		private void FilterLookUpEditValidated(object sender, EventArgs e)
		{

			BindReceivingsSearchGrid();

		}

		public void UpdateReturnPallets()
		{


			int units = 0;
			float pallets = 0;
			units = m_Items.GetUnits(Convert.ToInt32(this.returnsGridView.GetRowCellValue(this.returnsGridView.FocusedRowHandle, this.returnItemGridColumn)));

			if (units != 0)
			{
				this.returnsGridView.SetFocusedRowCellValue(this.returnUnitsGridColumn, Convert.ToDouble(this.returnsGridView.GetFocusedRowCellValue(this.returnQuantityGridColumn)) * units);
			}
			else
			{
				this.returnsGridView.SetFocusedRowCellValue(this.returnUnitsGridColumn, 0);
			}

			pallets = m_Items.GetCasesPerPallet(Convert.ToInt32(this.returnsGridView.GetFocusedRowCellValue(this.returnItemGridColumn)));

			if (pallets != 0)
			{
				this.returnsGridView.SetFocusedRowCellValue(this.returnPalletsGridColumn, Convert.ToDouble(this.returnsGridView.GetFocusedRowCellValue(this.returnQuantityGridColumn)) / pallets);
			}
			else
			{
				this.returnsGridView.SetFocusedRowCellValue(this.returnPalletsGridColumn, 0);
			}


		}

		private void receivingSearchGridView_Click(object sender, EventArgs e)
		{

			if (this.receivingSearchGridView.CalcHitInfo(this.receivingSearchGridControl.PointToClient(Control.MousePosition)).HitTest == GridHitTest.RowCell)
			{
				this.BindReceivingsControls(Convert.ToInt32(this.receivingSearchGridView.GetFocusedRowCellValue(this.receivingIDSearchGridColumn)));
			}

		}

		private void addBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			m_CurrentReceivingID = -1;
			this.receiveDateEdit.EditValue = null;
			this.customerLookUpEdit.EditValue = null;
			this.carrierLookUpEdit.EditValue = null;
			this.bolTextEdit.Text = string.Empty;
			this.vendorLookUpEdit.EditValue = null;
			this.skitsTextEdit.EditValue = 0;
			this.shiftLookUpEdit.EditValue = null;
			this.poTextEdit.Text = string.Empty;
			this.palletsTextEdit.EditValue = 0;
			this.trailerTextEdit.Text = string.Empty;
			this.sealTextEdit.Text = string.Empty;
			this.notesMemoEdit.EditValue = null;
			unloadedByLookUpEdit.EditValue = null;
			checkedByLookUpEdit.EditValue = null;
			wheelsChockedComboBoxEdit.EditValue = null;
			startTimeEdit.EditValue = null;
			finishTimeEdit.EditValue = null;
			temperatureSpinEdit.EditValue = null;
			physicalConditionLookUpEdit.EditValue = null;
			loadConditionLookUpEdit.EditValue = null;
			foreignSubstanceComboBoxEdit.EditValue = null;
			insectActivityComboBoxEdit.EditValue = null;
			correctPalletsComboBoxEdit.EditValue = null;
			locationLookUpEdit.EditValue = UsersBLL.GetUsersLocalLocation(m_ReceivingSession, Properties.Settings.Default.UserName).Oid;

			BindReceivingGridControl(m_CurrentReceivingID);
			BindReturnsGridControl(m_CurrentReceivingID);

			this.receivingsXtraTabControl.SelectedTabPage = this.generalXtraTabPage;

			Utilities.MakeFormReadOnly(this.generalXtraTabPage, false);
			this.palletsTextEdit.Properties.ReadOnly = true;
			this.BulkEntryGroupControl.Enabled = false;
			this.receivingGridView.OptionsBehavior.Editable = true;
			Utilities.MakeGridReadOnly(this.returnsGridView, false);
			this.receivingSearchGridControl.Enabled = false;
			CheckPermissions();

			this.UnitQtyLockCheckEdit.Checked = true;
			this.SaveContinueSimpleButton.Enabled = true;
			this.cancelBarButtonItem.Enabled = true;
			this.saveBarButtonItem.Enabled = true;
			this.editBarButtonItem.Enabled = false;
			this.addBarButtonItem.Enabled = false;
			refreshBarButtonItem.Enabled = false;

		}

		private void editBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (m_CurrentReceivingID == null)
			{
				MessageBox.Show("Please select a receiving entry to edit.");
				return;
			}

			Utilities.MakeFormReadOnly(this.generalXtraTabPage, false);
			this.palletsTextEdit.Properties.ReadOnly = true;
			//locationLookUpEdit.Properties.ReadOnly = True
			this.BulkEntryGroupControl.Enabled = true;
			this.receivingGridView.OptionsBehavior.Editable = true;
			Utilities.MakeGridReadOnly(this.returnsGridView, false);
			this.receivingSearchGridControl.Enabled = false;
			CheckPermissions();

			this.UnitQtyLockCheckEdit.Checked = true;
			this.cancelBarButtonItem.Enabled = true;
			this.saveBarButtonItem.Enabled = true;
			this.editBarButtonItem.Enabled = false;
			this.addBarButtonItem.Enabled = false;
			refreshBarButtonItem.Enabled = false;

		}

		private void cancelBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			CancelChanges();

			CheckPermissions();

			this.BulkEntryGroupControl.Enabled = false;
			Utilities.MakeFormReadOnly(this.generalXtraTabPage, true);
			this.receivingGridView.OptionsBehavior.Editable = false;
			Utilities.MakeGridReadOnly(this.returnsGridView, true);
			this.receivingSearchGridControl.Enabled = true;

			m_TempId.Clear();

			this.SaveContinueSimpleButton.Enabled = false;
			cancelBarButtonItem.Enabled = false;
			saveBarButtonItem.Enabled = false;
			refreshBarButtonItem.Enabled = true;

		}

		private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (SaveChanges())
			{

				CheckPermissions();

				this.BulkEntryGroupControl.Enabled = false;
				Utilities.MakeFormReadOnly(this.generalXtraTabPage, true);
				this.receivingGridView.OptionsBehavior.Editable = false;
				Utilities.MakeGridReadOnly(this.returnsGridView, true);
				this.receivingSearchGridControl.Enabled = true;

				m_TempId.Clear();

				cancelBarButtonItem.Enabled = false;
				saveBarButtonItem.Enabled = false;
				refreshBarButtonItem.Enabled = true;
			}

		}

		public bool CheckPermissions()
		{

			try
			{
				SPG.UserPermissionsRow permission = (new UserPermissionsBLL()).GetUserPermissionsByUserName(Properties.Settings.Default.UserName, "Receiving Form")[0];

				switch (permission.PermissionLevel)
				{

					case "FULL":
					case "Full":
						this.addBarButtonItem.Enabled = true;
						this.editBarButtonItem.Enabled = true;
						this.delGridColumn.Visible = true;
						this.deleteGridColumn.Visible = true;
						break;
					case "ADD":
					case "Add":
						this.addBarButtonItem.Enabled = true;
						this.editBarButtonItem.Enabled = true;
						this.delGridColumn.Visible = false;
						this.deleteGridColumn.Visible = false;
						break;
					case "NONE":
					case "None":
						MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						this.Close();
						return false;
					case "VIEW":
					case "View":
						this.addBarButtonItem.Enabled = false;
						this.editBarButtonItem.Enabled = false;
						this.delGridColumn.Visible = false;
						this.deleteGridColumn.Visible = false;
						break;
					case "EDIT":
					case "Edit":
						this.addBarButtonItem.Enabled = false;
						this.editBarButtonItem.Enabled = true;
						this.delGridColumn.Visible = false;
						this.deleteGridColumn.Visible = false;
						break;
					case "VIEW ASSIGNED":
						this.addBarButtonItem.Enabled = false;
						this.editBarButtonItem.Enabled = false;
						this.delGridColumn.Visible = false;
						this.deleteGridColumn.Visible = false;
						FilterAssignedCustomers();
						break;
					case "EDIT ASSIGNED":
						this.addBarButtonItem.Enabled = false;
						this.editBarButtonItem.Enabled = true;
						this.delGridColumn.Visible = false;
						this.deleteGridColumn.Visible = false;
						FilterAssignedCustomers();
						break;
					default:
						MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

		private void FilterAssignedCustomers()
		{

			this.receivingSearchXPView.Criteria = new InOperator(Receiving.Fields.ReceivCustID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ReceivingSession));
			this.customersXPView.Criteria = CriteriaOperator.And(new BinaryOperator(Customers.Fields.Inactive.PropertyName, false), new InOperator(Customers.Fields.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ReceivingSession)));
			this.receivingItemXPView.Criteria = new InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ReceivingSession));
			this.returnItemXPView.Criteria = CriteriaOperator.And(CriteriaOperator.Or(new InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ReceivingSession)), new BinaryOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, CompanySettingsBLL.GetUniversalCustomer(), BinaryOperatorType.Equal)), new BinaryOperator(Items.Fields.ItemType.PropertyName, "FG", BinaryOperatorType.Equal));

		}

		private void CancelChanges()
		{


			if (m_TempId.Count > 0)
			{
				MessageBox.Show($"{m_TempId.Count} Added Pallets was already received, If you want to remove it go back and edit.");
			}

			foreach (Control control in BulkEntryGroupControl.Controls)
			{
				if (control is TextEdit)
				{
					(control as TextEdit).Text = control.Tag?.ToString();
					if (control.Name == "ItemLookUpEdit")
					{
						(control as TextEdit).EditValue = null;
					}
				}
			}

			if (this.m_CurrentReceivingID != null)
			{
				BindReceivingsControls(m_CurrentReceivingID.Value);
			}

		}

		private double m_TotalPallets = 0;

		private void receivingGridView_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
		{

			switch (e.SummaryProcess)
			{

				case DevExpress.Data.CustomSummaryProcess.Finalize:
					e.TotalValue = m_TotalPallets;

					break;
				case DevExpress.Data.CustomSummaryProcess.Start:
					m_TotalPallets = 0;

					try
					{
						int dataRowCount = receivingGridView.RowCount;
						List<string> vecchioval = new List<string>();

						for (int i = 0; i < dataRowCount; i++)
						{
							object cellValue = receivingGridView.GetRowCellValue(i, ReceivDetLPNColumn);
							string newValue = Convert.ToString(cellValue);

							if (!vecchioval.Contains(newValue))
							{
								m_TotalPallets += 1;
								vecchioval.Add(newValue);
							}
						}

					}
					finally
					{
					}
					//Case DevExpress.Data.CustomSummaryProcess.Calculate
					//    m_TotalPallets += Math.Ceiling(Convert.ToDouble(receivingGridView.GetRowCellValue(e.RowHandle, palletsGridColumn)))

					break;
			}

		}

		private double m_TotalReturnedPallets = 0;

		private void returnsGridView_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
		{

			switch (e.SummaryProcess)
			{

				case DevExpress.Data.CustomSummaryProcess.Finalize:
					e.TotalValue = m_TotalReturnedPallets;

					break;
				case DevExpress.Data.CustomSummaryProcess.Start:
					m_TotalReturnedPallets = 0;

					break;
				case DevExpress.Data.CustomSummaryProcess.Calculate:
					m_TotalReturnedPallets += Math.Ceiling(Convert.ToDouble(returnsGridView.GetRowCellValue(e.RowHandle, returnPalletsGridColumn)));

					break;
			}

		}

		private void deleteReturnRepositoryItemButtonEdit_Click(object sender, EventArgs e)
		{

			if (MessageBox.Show("Are you sure you want to delete this return.", "Delete Return", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
			{
				return;
			}

			try
			{
				int lReceivingReturnDetailID = Convert.ToInt32(this.returnsGridView.GetRowCellValue(this.returnsGridView.FocusedRowHandle, this.returnIDGridColumn));
				if (lReceivingReturnDetailID <= -1)
				{
					this.returnsGridView.DeleteRow(this.returnsGridView.FocusedRowHandle);
				}
				else if (m_ReturnDetails.DeleteReturnDetail(m_ReceivingSession, lReceivingReturnDetailID) == true)
				{
					BindReturnsGridControl(m_CurrentReceivingID);
				}
				else
				{
					MessageBox.Show("The return was not deleted.");
				}
			}
			catch (ApplicationException ex)
			{
				MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void delRepositoryItemButtonEdit_Click(object sender, EventArgs e)
		{

			if (MessageBox.Show("Are you sure you want to delete this LPN, this can`t be undone.", "Delete Receiving Detail", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
			{
				return;
			}

			try
			{
				int lReceivingDetailID = Convert.ToInt32(this.receivingGridView.GetRowCellValue(this.receivingGridView.FocusedRowHandle, this.idGridColumn));

				if (m_TempId.ContainsKey(lReceivingDetailID))
				{
					lReceivingDetailID = m_TempId[lReceivingDetailID];
				}

				if (lReceivingDetailID <= -1)
				{
					this.receivingGridView.DeleteRow(this.receivingGridView.FocusedRowHandle);
				}
				else if (m_ReceivingDetails.DeleteReceivingDetail(m_ReceivingSession, lReceivingDetailID) == true)
				{
					if (m_TempId.ContainsKey(lReceivingDetailID))
					{
						m_TempId.Remove(lReceivingDetailID);
					}

					BindReceivingGridControl(m_CurrentReceivingID);
				}
				else
				{
					MessageBox.Show("The receiving detail was not deleted.");
				}
			}
			catch (ApplicationException ex)
			{
				MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
		private void AddLotRepositoryItemButtonEdit_Click(object sender, EventArgs e)
		{

		}

		private void itemRepositoryItemLookUpEdit_Closed(object sender, DevExpress.XtraEditors.Controls.ClosedEventArgs e)
		{

			BindItemLookupEdit();

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

		private void itemRepositoryItemLookUpEdit_Enter(object sender, EventArgs e)
		{

			receivingItemXPView.Filter = CriteriaOperator.And(receivingItemXPView.Filter, new BinaryOperator("Inactive", false));
			returnItemXPView.Filter = CriteriaOperator.And(returnItemXPView.Filter, new BinaryOperator("Inactive", false));

		}

		private void temperatureSpinEdit_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{

			if (Convert.ToDouble(temperatureSpinEdit.EditValue) < 55 || Convert.ToDouble(temperatureSpinEdit.EditValue) > 75)
			{
				if (MessageBox.Show("You entered an unusual tepmerature, do you want to change it?", "Unusual Temperature", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
				{
					e.Cancel = true;
					temperatureSpinEdit.SelectAll();
				}
				else
				{
					e.Cancel = false;
				}
			}

		}

		private void receivingListBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (m_CurrentReceivingID == null)
			{
				return;
			}

			PackingListXtraReport packingList = new PackingListXtraReport();

			packingList.locationId.Text = locationLookUpEdit.Text;
			packingList.reportTitleXrLabel.Text = "Receiving List";
			packingList.dateXrLabel.DataBindings.Add("Text", null, "ReceivDate", "{0:MM/dd/yyyy}");
			packingList.bolXrLabel.DataBindings.Add("Text", null, "ReceivBOL");
			packingList.poXrLabel.DataBindings.Add("Text", null, "strPO");
			packingList.deliveryNoteLabelXrLabel.Text = "Vendor";
			packingList.deliveryNoteNumberXrLabel.DataBindings.Add("Text", null, "VendorName");
			packingList.carrierXrLabel.DataBindings.Add("Text", null, "CarrierName");
			packingList.trailerXrLabel.DataBindings.Add("Text", null, "strTrailer");
			packingList.sealXrLabel.DataBindings.Add("Text", null, "strSeal");
			packingList.returnsGroupHeader.GroupFields.Add(new GroupField("ShippingType", XRColumnSortOrder.Ascending));
			packingList.itemGroupHeader.GroupFields.Add(new GroupField("ItemCode", XRColumnSortOrder.Ascending));
			packingList.lotGroupHeader.GroupFields.Add(new GroupField("ReceivDetLot", XRColumnSortOrder.Ascending));
			packingList.qtyLabelXrLabel.Text = "UNITS";
			packingList.qtyXrLabel.DataBindings.Add("Text", null, "intUnits");
			packingList.itemCodeXrLabel.DataBindings.Add("Text", null, "ItemCode");
			packingList.itemDescriptionXrLabel.DataBindings.Add("Text", null, "ItemDescription");
			packingList.palletsXrLabel.DataBindings.Add("Text", null, "sngPallets", "{0:N2}");
			//.additionalPalletsXrLabel.DataBindings.Add("Text", Nothing, "sngSkits")
			packingList.totalPalletsXrLabel.DataBindings.Add("Text", null, "sngTotalPallets", "{0:N2}");
			packingList.palletsTotalXrLabel.DataBindings.Add("Text", null, "sngTotalPallets", "{0:N2}");
			packingList.weightXrLabel.DataBindings.Add("Text", null, "Weight", "{0:N2}");
			//.totalWeightXrLabel.DataBindings.Add("Text", Nothing, "TotalGrossWeight", "{0:N2}")
			packingList.lpnLabelXrLabel.Text = "QUANTITY";
			packingList.lpnXrLabel.DataBindings.Add("Text", null, "ReceivDetQty");
			packingList.lotXrLabel.DataBindings.Add("Text", null, "ReceivDetLot");
			packingList.expirationDateXrLabel.DataBindings.Add("Text", null, "ExpirationDate", string.Format("{{0:{0}}}", CustomersBLL.GetExpirationDateFormat(Convert.ToInt32(customerLookUpEdit.EditValue))));
			packingList.itemTotalQuantityXrLabel.DataBindings.Add("Text", null, "intUnits");
			packingList.groupItemCodeXrLabel.DataBindings.Add("Text", null, "ItemCode");
			packingList.groupItemDescriptionXrLabel.DataBindings.Add("Text", null, "ItemDescription");
			packingList.itemTotalPalletsXrLabel.DataBindings.Add("Text", null, "sngPallets", "{0:N2}");
			packingList.itemTotalWeightXrLabel.DataBindings.Add("Text", null, "Weight", "{0:N2}");
			packingList.loadedByLabelXrLabel.Text = "Unloaded By";
			packingList.loadedByXrLabel.DataBindings.Add("Text", null, "UnloadedBy");
			packingList.checkedByXrLabel.DataBindings.Add("Text", null, "CheckedBy");
			packingList.physicalConditionXrLabel.DataBindings.Add("Text", null, "PhysicalCondition");
			packingList.loadConditionXrLabel.DataBindings.Add("Text", null, "LoadCondition");
			packingList.startTimeXrLabel.DataBindings.Add("Text", null, "StartTime", "{0:hh:mm:ss tt}");
			packingList.finishTimeXrLabel.DataBindings.Add("Text", null, "FinishTime", "{0:hh:mm:ss tt}");
			packingList.temperatureXrLabel.DataBindings.Add("Text", null, "Temparature", "{0:N1}");
			packingList.DataSource = (new ReceivingListReportBLL()).GetReceivingListreport(m_CurrentReceivingID.Value);
			packingList.ShowPreview();

		}

		private static int? GetThreeWayYesNoValue(string threeWayYesNo)
		{

			if (string.IsNullOrEmpty(threeWayYesNo))
			{
				return null;
			}
			else
			{
				switch (threeWayYesNo)
				{
					case "Yes":
						return 1;
					case "No":
						return 2;
					case "NA":
						return 3;
					default:
						return null;
				}
			}

		}

		private void itemRepositoryItemLookUpEdit_ProcessNewValue(object sender, DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs e)
		{

			Items itemReceived = ItemsBLL.GetItemByUpc(e.DisplayValue.ToString());

			if (itemReceived != null && itemReceived.ItemCustomerID.CustomerID == Convert.ToInt32(customerLookUpEdit.EditValue))
			{
				e.Handled = true;
				e.DisplayValue = itemReceived.ItemCode;
			}
			else
			{
				e.Handled = false;
			}

		}

		private void refreshBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			m_ReceivingSession.DropIdentityMap();
			receivingSearchXPView.Reload();
			receivingItemXPView.Reload();
			returnItemXPView.Reload();
			customersXPView.Reload();
			vendorLookupXPCollection.Reload();
			shipmentConditionXpView.Reload();
			employeeXpView.Reload();
			locationXpView.Reload();

			BindReceivingsSearchGrid();
			shiftLookUpEdit.Properties.DataSource = m_Shifts.GetShifts();
			carrierLookUpEdit.Properties.DataSource = m_Carriers.GetCarrierIDAndNames();
			BindReceivingsControls(m_CurrentReceivingID.Value);

			CheckPermissions();

			MessageBox.Show("Done!");

		}

		private void LinkSession()
		{

			receivingSearchXPView.Session = m_ReceivingSession;
			receivingItemXPView.Session = m_ReceivingSession;
			returnItemXPView.Session = m_ReceivingSession;
			customersXPView.Session = m_ReceivingSession;
			vendorLookupXPCollection.Session = m_ReceivingSession;
			shipmentConditionXpView.Session = m_ReceivingSession;
			employeeXpView.Session = m_ReceivingSession;
			locationXpView.Session = m_ReceivingSession;

		}

		private void printLpn(bool reprint)
		{
			int digits = CustomersBLL.GetCustomer(7, m_ReceivingSession).LastLPNNumber.ToString().Length;
			XPView lpnXPview = null;
			CriteriaOperatorCollection critaria = new CriteriaOperatorCollection();
			lpnXPview = new XPView(m_ReceivingSession, typeof(LocationInventoryByLot));

			//If all Then
			//    If receivingGridView.GroupCount > 0 Then
			//        Dim i As Integer = -1
			//        While receivingGridView.IsValidRowHandle(i)
			//            If receivingGridView.GetChildRowHandle(i, 0) > -1 Then
			//                For ci As Integer = receivingGridView.GetChildRowHandle(i, 0) To receivingGridView.GetChildRowCount(i) + receivingGridView.GetChildRowHandle(i, 0) - 1
			//                    addToCritaria(critaria, ci)
			//                Next
			//            End If
			//            i -= 1
			//        End While
			//    Else
			//        For ci As Integer = 0 To receivingGridView.RowCount - 1
			//            addToCritaria(critaria, ci)
			//        Next
			//    End If
			//Else
			int[] selectedRowHandles = receivingGridView.GetSelectedRows();
			if (selectedRowHandles.Length == 0)
			{
				MessageBox.Show("Nothing is selected");
				return;
			}
			for (int i = 0; i < selectedRowHandles.Length; i++)
			{
				int ci = selectedRowHandles[i];
				if (ci >= 0)
				{
					addToCritaria(critaria, ci);
				}
			}
			//End If

			lpnXPview.Criteria = CriteriaOperator.And(CriteriaOperator.Or(critaria), new BinaryOperator("QuantityOnHand", 0, BinaryOperatorType.Greater));

			lpnXPview.Properties.AddRange(new ViewProperty[]
			{
				new ViewProperty("Item", SortDirection.None, "[LocationInventoryItem.ItemCode]", false, true),
				new ViewProperty("ItemDesc", SortDirection.None, "[LocationInventoryItem.ItemDescription]", false, true),
				new ViewProperty("Allergens", SortDirection.None, "[LocationInventoryItem.Allergens]", false, true),
				new ViewProperty("Qty", SortDirection.None, "[QuantityOnHand]", false, true),
				new ViewProperty("Expr", SortDirection.None, "[ExpirationDate]", false, true),
				new ViewProperty("Lot", SortDirection.None, "[LocationInventoryLot]", false, true),
				new ViewProperty("LPN", SortDirection.Ascending, "[LPNNumber]", false, true)
			});

			LPNLabelsXtraReport labels = new LPNLabelsXtraReport();
			labels.DataSource = lpnXPview;
			labels.lpnGroupHeader.GroupFields.Add(new GroupField("LPN", XRColumnSortOrder.Ascending));
			labels.lpnGroupHeader.GroupFields.Add(new GroupField("Item", XRColumnSortOrder.Ascending));
			labels.itemCodeXrLabel.DataBindings.Add("Text", lpnXPview, "Item");
			labels.itemDescXrLabel.DataBindings.Add("Text", lpnXPview, "ItemDesc");
			labels.AllergensXrLabel.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "Iif(Len(Trim([Allergens]))>0,'Allergens: ' + [Allergens],'Allergens: None')"));
			labels.exprXrLabel.DataBindings.Add("Text", lpnXPview, "Expr", "{0:MM/dd/yyyy}");
			labels.qtyXrLabel.DataBindings.Add("Text", lpnXPview, "Qty");
			labels.lotXrLabel.DataBindings.Add("Text", lpnXPview, "Lot");
			labels.LPNXrBarCode.DataBindings.Add("Text", lpnXPview, "LPN", "SPG{0:D" + digits + "}");
			labels.SumQtyXrLabel.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "sumSum([Qty])"));
			labels.ReprintXrLabel.Visible = reprint;
			labels.CreateDocument();
			if (reprint)
			{
				labels.ShowPreviewDialog();
			}
			else
			{
				labels.Print(UsersBLL.GetUserByName(m_ReceivingSession, Properties.Settings.Default.UserName).LPNPrinterName);
			}
		}

		private void addToCritaria(CriteriaOperatorCollection critaria, int ci)
		{
			int? lpn = Utilities.ChangeType<int?>(receivingGridView.GetRowCellValue(ci, ReceivDetLPNColumn));
			//Dim lot As String = receivingGridView.GetRowCellValue(ci, lotGridColumn).ToString()
			//If lpn.HasValue AndAlso lot.Length > 0 Then
			//    critaria.Add(New GroupOperator(GroupOperatorType.And,
			//        New BinaryOperator("LPNNumber", lpn.Value, BinaryOperatorType.Equal),
			//        New BinaryOperator("LocationInventoryLot", lot, BinaryOperatorType.Equal)))
			//Else
			if (lpn.HasValue)
			{
				critaria.Add(new BinaryOperator("LPNNumber", lpn.Value, BinaryOperatorType.Equal));
			}
		}

		private void LpnLabelsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			printLpn(true);
		}

		private void AddToPalletButton_Click(object sender, EventArgs e)
		{
			AddLpns(true);
		}

		private void AddEntryButton_Click(object sender, EventArgs e)
		{
			AddLpns();
		}

		private void ItemLookUpEdit_Validated(object sender, EventArgs e)
		{
			UpdateQtyPerPallets("Item");
			if (!Convert.IsDBNull(ItemLookUpEdit.EditValue))
			{
				ItemDescTextEdit.Text = ItemsBLL.GetDescriptionByItemID((int?)ItemLookUpEdit.EditValue);
			}
			BulkEntryChanged();
		}

		private void UnitsTextEdit_Validated(object sender, EventArgs e)
		{
			UpdateQtyPerPallets("Units");
			BulkEntryChanged();
		}
		private void LotTextEdit_Validated(object sender, EventArgs e)
		{
			BulkEntryChanged();
		}
		private void QtyTextEdit_Validated(object sender, EventArgs e)
		{
			UpdateQtyPerPallets("Qty");
			BulkEntryChanged();
		}

		private void UnitsPerPltTextEdit_Validated(object sender, EventArgs e)
		{
			UpdateQtyPerPallets("UnitsPerPlt");
			BulkEntryChanged();
		}

		private void QtyPerPltTextEdit_Validated(object sender, EventArgs e)
		{
			UpdateQtyPerPallets("QtyPerPlt");
			BulkEntryChanged();
		}
        private void BulkEntryChanged()
        {
            //INSTANT C# TODO TASK: The following 'On Error GoTo' statement cannot be converted by Instant C#:
            //On Error GoTo Err
                try { 

            if (int.Parse(UnitsTextEdit.Text) > 0 && int.Parse(UnitsPerPltTextEdit.Text) > 0 && ((int.Parse(QtyTextEdit.Text) > 0 && int.Parse(QtyPerPltTextEdit.Text) > 0) || int.Parse(QtyTextEdit.Text) == 0) && LotCodeValidator.ValidateByItemID(Convert.ToInt32(ItemLookUpEdit.EditValue), LotTextEdit.Text, true))
            {
                AddEntryButton.Enabled = true;
                AddToPalletButton.Enabled = int.Parse(UnitsTextEdit.Text) <= int.Parse(UnitsPerPltTextEdit.Text) && int.Parse(QtyTextEdit.Text) <= int.Parse(QtyPerPltTextEdit.Text) && Convert.ToInt32(ItemLookUpEdit.EditValue) == m_lastItem;
            }
            else
            {
            //Err:
                AddEntryButton.Enabled = false;
                AddToPalletButton.Enabled = false;
            }
        }     catch
            {
                AddEntryButton.Enabled = false;
                AddToPalletButton.Enabled = false;
            }
       

		}
		public void UpdateQtyPerPallets(string Changed)
		{

			double CasesPerPallet = 0;
			double QuantityPerUnit = 0;
			int itemId = Convert.ToInt32(ItemLookUpEdit.EditValue);

			QuantityPerUnit = ItemsBLL.GetCaseQuantity(itemId);
			CasesPerPallet = m_Items.GetCasesPerPallet(itemId);

			if (Changed != "Item" && !UnitQtyLockCheckEdit.Checked && Convert.ToInt32(QtyPerPltTextEdit.Text) > 0 && Convert.ToInt32(UnitsPerPltTextEdit.Text) > 0)
			{
				QuantityPerUnit = Convert.ToInt32(QtyPerPltTextEdit.Text) / (double)Convert.ToInt32(UnitsPerPltTextEdit.Text);
			}


			//calculate the quantity
			if (Changed == "Qty" && QuantityPerUnit > 0)
			{
				UnitsTextEdit.EditValue = Math.Ceiling(Convert.ToDouble(QtyTextEdit.Text) / QuantityPerUnit);
			}
			if (Changed == "Units" && QuantityPerUnit > 0)
			{
				QtyTextEdit.EditValue = Convert.ToDouble(UnitsTextEdit.Text) * QuantityPerUnit;
			}
			if (Changed == "UnitsPerPlt" && QuantityPerUnit > 0 && UnitQtyLockCheckEdit.Checked)
			{
				QtyPerPltTextEdit.EditValue = Convert.ToDouble(UnitsPerPltTextEdit.Text) * QuantityPerUnit;
			}
			if (Changed == "QtyPerPlt" && QuantityPerUnit > 0 && UnitQtyLockCheckEdit.Checked)
			{
				UnitsPerPltTextEdit.EditValue = Convert.ToDouble(QtyPerPltTextEdit.Text) / QuantityPerUnit;
			}

			if (Changed == "Item")
			{
				UnitsPerPltTextEdit.EditValue = CasesPerPallet;
				QtyPerPltTextEdit.EditValue = (CasesPerPallet * QuantityPerUnit);
			}

		}
		private void AddLpns(bool toLastLPN = false)
		{
			double addedQty = 0;
			double addedUnits = 0;
			double qty = 0;
			double units = 0;
			double qtyPerPlt = 0;
			double UnitPerPlt = 0;
			int? beginRow = null; // = receivingGridView.GetRowHandle(receivingGridView.DataRowCount)

			m_lastItem = Convert.ToInt32(ItemLookUpEdit.EditValue);
			qty = Convert.ToDouble(QtyTextEdit.Text);
			units = Convert.ToDouble(UnitsTextEdit.Text);
			qtyPerPlt = Convert.ToDouble(QtyPerPltTextEdit.Text);
			UnitPerPlt = Convert.ToDouble(UnitsPerPltTextEdit.Text);

			while (!(addedQty >= qty))
			{
				if (!toLastLPN)
				{
					m_lastLPN = LPNLabel.GetNextLPNNumber(7);
				}

				receivingGridView.AddNewRow();
				int rowHandle = receivingGridView.GetRowHandle(receivingGridView.DataRowCount);
				if (receivingGridView.IsNewItemRow(rowHandle))
				{
					receivingGridView.SetRowCellValue(rowHandle, itemGridColumn, ItemLookUpEdit.EditValue);
					receivingGridView.SetRowCellValue(rowHandle, descriptionGridColumn, ItemDescTextEdit.Text);
					receivingGridView.SetRowCellValue(rowHandle, lotGridColumn, LotTextEdit.Text);
					if (!string.IsNullOrEmpty((ExpirationDateEdit.EditValue ?? "").ToString()))
					{
						receivingGridView.SetRowCellValue(rowHandle, expirationDateGridColumn, ExpirationDateEdit.EditValue);
					}
					receivingGridView.SetRowCellValue(rowHandle, packagesGridColumn, Math.Min(UnitPerPlt, units - addedUnits));
					receivingGridView.SetRowCellValue(rowHandle, quantityGridColumn, Math.Max(Math.Min(qtyPerPlt, qty - addedQty), 0));
					receivingGridView.SetRowCellValue(rowHandle, ReceivDetLPNColumn, m_lastLPN);
				}
				receivingGridView.UpdateCurrentRow();

				int tempVar = receivingGridView.FocusedRowHandle;
				if (SaveShippingDetail(ref tempVar) != true)
				{
					receivingGridView.FocusedRowHandle = tempVar;
					MessageBox.Show("The receiving details was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					receivingGridView.FocusedRowHandle = tempVar;
				}

				if (beginRow == null)
				{
					beginRow = receivingGridView.FocusedRowHandle;
				}
				//.SelectRow(.FocusedRowHandle)

				addedQty += qtyPerPlt;
				addedUnits += UnitPerPlt;
			}
			if (addedUnits < units)
			{
				MessageBox.Show($"{units - addedUnits} units was not added.", "Units/Qty mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			if (beginRow.HasValue)
			{
				receivingGridView.SelectRows(beginRow.Value, receivingGridView.FocusedRowHandle);
				printLpn(false);
			}

			foreach (Control control in BulkEntryGroupControl.Controls)
			{
				if (control is TextEdit)
				{
					(control as TextEdit).Text = control.Tag?.ToString();
					if (control.Name == "ItemLookUpEdit")
					{
						(control as TextEdit).EditValue = null;
					}
				}
			}

			this.UnitQtyLockCheckEdit.Checked = true;

			BulkEntryChanged();

		}

		private void SaveContinueSimpleButton_Click(object sender, EventArgs e)
		{
			if (SaveChanges())
			{
				this.SaveContinueSimpleButton.Enabled = false;
				this.BulkEntryGroupControl.Enabled = true;
				this.receivingsXtraTabControl.SelectedTabPage = this.detailsXtraTabPage;
			}
		}

		private void ItemLookUpEdit_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (ItemLookUpEdit.Text.Length > 0)
			{
				Items item = ItemsBLL.GetItemByUpc((!string.IsNullOrEmpty(m_upc)) ? m_upc : ItemLookUpEdit.Text);
				if (item != null && item.Inactive == false && item.ItemCustomerID.CustomerID == ((int?)this.customerLookUpEdit.EditValue).Value)
				{
					ItemLookUpEdit.EditValue = item.ItemID;
				}
			}
		}

		private void ItemLookUpEdit_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter)
			{
				SendKeys.Send("{TAB}");
				e.Handled = true;
			}
			else if (e.KeyData == Keys.Tab)
			{
				m_upc = this.ItemLookUpEdit.Text;
			}
			else
			{
				m_upc = "";
			}
		}
	}

}