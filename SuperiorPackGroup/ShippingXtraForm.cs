//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DXDAL.SPGData;
using DevExpress.XtraReports.UI;
using System.Linq;

namespace SuperiorPackGroup
{
	public partial class ShippingXtraForm
	{

		public ShippingXtraForm()
		{
			InitializeComponent();
		}

		private ShippingsBLL m_Shippings;
		private CustomersBLL m_CustomerShippings;
		private CarriersBLL m_Carriers;
		private ItemsBLL m_Items;
		private ShippingDetailsBLL m_ShippingDetails;
		private ShippingAddressBLL m_Destinations;
		private ShiftsBLL m_Shifts;
		private ShippingReturnDetailsBLL m_ShippingReturnDetails;
		private UserPermissionsBLL m_UserPermissions;
		private int? m_CurrentShippingID;
		private bool m_CanSaveDetails = true;
		private bool m_CanSaveReturns = true;
		private readonly Session m_ShippingSession = new Session(MyDataLayers.SPGDataLayer)
		{
			TrackPropertiesModifications = true,
			OptimisticLockingReadBehavior = OptimisticLockingReadBehavior.MergeCollisionThrowException
		};

		private void ShippingXtraForm_FormClosing(object sender, FormClosingEventArgs e)
		{

			if (shippingSearchGridControl.Enabled == false)
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

		private void ShippingXtraForm_Load(object sender, EventArgs e)
		{

			Cursor = Cursors.WaitCursor;
			m_Shippings = new ShippingsBLL();
			m_CustomerShippings = new CustomersBLL();
			m_Carriers = new CarriersBLL();
			m_Items = new ItemsBLL();
			m_ShippingDetails = new ShippingDetailsBLL();
			m_Destinations = new ShippingAddressBLL();
			m_UserPermissions = new UserPermissionsBLL();
			m_Shifts = new ShiftsBLL();
			m_ShippingReturnDetails = new ShippingReturnDetailsBLL();

			LinkSession();

			CheckPermissions();

			BindShippingSearchGrid();

			shiftLookUpEdit.Properties.DataSource = m_Shifts.GetShifts();
			shiftLookUpEdit.Properties.Columns.Add(new LookUpColumnInfo());
			shiftLookUpEdit.Properties.Columns[0].FieldName = "ShiftName";
			shiftLookUpEdit.Properties.Columns[0].Caption = "Shift";
			shiftLookUpEdit.Properties.DisplayMember = "ShiftName";
			shiftLookUpEdit.Properties.ValueMember = "ShiftID";

			carrierLookUpEdit.Properties.DataSource = m_Carriers.GetCarrierIDAndNames();
			carrierLookUpEdit.Properties.Columns.Add(new LookUpColumnInfo());
			carrierLookUpEdit.Properties.Columns[0].FieldName = "CarrierName";
			carrierLookUpEdit.Properties.Columns[0].Caption = "Carrier Name";
			carrierLookUpEdit.Properties.DisplayMember = "CarrierName";
			carrierLookUpEdit.Properties.ValueMember = "CarrierID";

			destinationLookUpEdit.Properties.DataSource = m_Destinations.GetAddressNameAndIDS();
			destinationLookUpEdit.Properties.Columns.Add(new LookUpColumnInfo());
			destinationLookUpEdit.Properties.Columns[0].FieldName = "ShippingName";
			destinationLookUpEdit.Properties.Columns[0].Caption = "Destination";
			destinationLookUpEdit.Properties.DisplayMember = "ShippingName";
			destinationLookUpEdit.Properties.ValueMember = "AddressID";

			idGridColumn.FieldName = "ShipDetDetID";
			shippingIDGridColumn.FieldName = "ShipDetMainID";
			itemGridColumn.FieldName = "ShipDetItemID";
			quantityGridColumn.FieldName = "ShipDetDetQty";
			palletsGridColumn.FieldName = "sngPallets";
			lotGridColumn.FieldName = "ShipDetLot";
			noteGridColumn.FieldName = "Note";
			expirationDateGridColumn.FieldName = "ExpirationDate";
			fullLPNNumberGridColumn.FieldName = "FullLPNNumber";

			returnIDGridColumn.FieldName = "ReturnDetID";
			ShippingMainIDGridColumn.FieldName = "ShipMainID";
			returnItemGridColumn.FieldName = "ReturnDetItemID";
			returnQuantityGridColumn.FieldName = "ReturnDetQty";
			returnUnitsGridColumn.FieldName = "intUnits";
			returnPalletsGridColumn.FieldName = "sngPallets";
			returnLotGridColumn.FieldName = "ReturnDetLot";
			returnReasonGridColumn.FieldName = "Reason";
			returnExpirationDateGridColumn.FieldName = "ExpirationDate";

			Utilities.MakeFormReadOnly(generalXtraTabPage, true);
			Utilities.MakeFormReadOnly(shipmentInfoXtraTabPage, true);
			shippingGridView.OptionsBehavior.Editable = false;
			lpnNumberTextEdit.Properties.ReadOnly = true;
			//Utilities.MakeGridReadOnly(Me.returnsGridView, True)
			shippingSearchGridControl.Enabled = true;

			cancelBarButtonItem.Enabled = false;
			saveBarButtonItem.Enabled = false;
			refreshBarButtonItem.Enabled = false;

			Cursor = Cursors.Default;

		}

		private bool SaveChanges()
		{

			//make sure that the record gets validated before saving by moving off the record being edited
			shippingGridView.CloseEditor();
			shippingGridView.MoveNext();
			//returnsGridView.CloseEditor()
			//returnsGridView.MoveNext()

			if (m_CanSaveDetails == false || m_CanSaveReturns == false || ValidateAvailability() == false)
			{
				return false;
			}

			UpdateTotalPallets();

			//If ValidateAvailability() = False Then
			//    Return False
			//End If

			int selectedID = -1;
			if (m_CurrentShippingID.HasValue == false || m_CurrentShippingID == -1)
			{
				m_CurrentShippingID = ShippingsBLL.GetNewItemID();
			}
			else
			{
				selectedID = shippingSearchGridView.FocusedRowHandle;
			}

			bool lShouldReturn = false;
			bool lResult = SaveShippingMain(ref lShouldReturn);
			if (lShouldReturn)
			{
				return lResult;
			}

			bool lShouldReturn1 = false;
			bool lResult1 = SaveShippingDetails(ref lShouldReturn1);
			if (lShouldReturn1)
			{
				return lResult1;
			}

#region SaveReturnsDetails
			//Try
			//    returnsGridView.CloseEditor()
			//    If returnsGridView.GroupCount > 0 Then
			//        Dim i As Integer = -1
			//        While returnsGridView.IsValidRowHandle(i)
			//            If returnsGridView.GetChildRowHandle(i, 0) > -1 Then
			//                For ci As Integer = returnsGridView.GetChildRowHandle(i, 0) To returnsGridView.GetChildRowCount(i) + returnsGridView.GetChildRowHandle(i, 0) - 1
			//                    Dim lot As String
			//                    Dim reason As String
			//                    If Not IsDBNull(returnsGridView.GetRowCellValue(ci, returnLotGridColumn)) Then
			//                        lot = returnsGridView.GetRowCellValue(ci, returnLotGridColumn).ToString
			//                    Else
			//                        lot = String.Empty
			//                    End If
			//                    If Not IsDBNull(returnsGridView.GetRowCellValue(ci, returnReasonGridColumn)) Then
			//                        reason = returnsGridView.GetRowCellValue(ci, returnReasonGridColumn).ToString
			//                    Else
			//                        reason = String.Empty
			//                    End If
			//                    If m_ShippingReturnDetails.UpdateShippingReturnDetails(m_ShippingSession, CType(returnsGridView.GetRowCellValue(ci, returnIDGridColumn), Integer?), m_CurrentShippingID.Value, _
			//                                                                           CType(returnsGridView.GetRowCellValue(ci, returnItemGridColumn), Integer?), lot, _
			//                                                                           CType(returnsGridView.GetRowCellValue(ci, returnQuantityGridColumn), Integer?), CType(returnsGridView.GetRowCellValue(ci, returnUnitsGridColumn), Integer?),
			//                                                                           CType(returnsGridView.GetRowCellValue(ci, returnPalletsGridColumn), Single?), reason,
			//                                                                           Utilities.ChangeType(Of Date?)(returnsGridView.GetRowCellValue(ci, returnExpirationDateGridColumn))) <> True Then
			//                        MessageBox.Show("The return details were not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
			//                        Return False
			//                    End If
			//                Next
			//            End If
			//            i -= 1
			//        End While
			//    Else
			//        For i As Integer = 0 To returnsGridView.RowCount - 1
			//            If returnsGridView.IsValidRowHandle(i) Then
			//                Dim lot As String
			//                Dim reason As String
			//                If Not IsDBNull(returnsGridView.GetRowCellValue(i, returnLotGridColumn)) Then
			//                    lot = returnsGridView.GetRowCellValue(i, returnLotGridColumn).ToString
			//                Else
			//                    lot = String.Empty
			//                End If
			//                If Not IsDBNull(returnsGridView.GetRowCellValue(i, returnReasonGridColumn)) Then
			//                    reason = returnsGridView.GetRowCellValue(i, returnReasonGridColumn).ToString
			//                Else
			//                    reason = String.Empty
			//                End If
			//                If m_ShippingReturnDetails.UpdateShippingReturnDetails(m_ShippingSession, CType(returnsGridView.GetRowCellValue(i, returnIDGridColumn), Integer?), m_CurrentShippingID.Value, _
			//                                                                       CType(returnsGridView.GetRowCellValue(i, returnItemGridColumn), Integer?), lot, _
			//                                                                       CType(returnsGridView.GetRowCellValue(i, returnQuantityGridColumn), Integer?), CType(returnsGridView.GetRowCellValue(i, returnUnitsGridColumn), Integer?),
			//                                                                       CType(returnsGridView.GetRowCellValue(i, returnPalletsGridColumn), Single?), reason,
			//                                                                       Utilities.ChangeType(Of Date?)(returnsGridView.GetRowCellValue(i, returnExpirationDateGridColumn))) <> True Then
			//                    MessageBox.Show("The return details were not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
			//                    Return False
			//                End If
			//            End If
			//        Next
			//    End If
			//Catch ex As ApplicationException
			//    MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
			//    Return False
			//End Try
#endregion


			//m_ShippingSession.CommitTransaction()

			BindShippingSearchGrid();
			BindShippingsControls(m_CurrentShippingID.Value);
			if (selectedID != -1)
			{
				shippingSearchGridView.FocusedRowHandle = selectedID;
			}
			return true;

		}

		private bool SaveShippingDetails(ref bool shouldReturn)
		{

			shouldReturn = false;
			try
			{
				shippingGridView.CloseEditor();
				if (shippingGridView.GroupCount > 0)
				{
					int i = -1;
					while (shippingGridView.IsValidRowHandle(i))
					{
						if (shippingGridView.GetChildRowHandle(i, 0) > -1)
						{
//INSTANT C# NOTE: The ending condition of VB 'For' loops is tested only on entry to the loop. Instant C# has created a temporary variable in order to use the initial value of shippingGridView.GetChildRowCount(i) + shippingGridView.GetChildRowHandle(i, 0) for every iteration:
							int tempVar = shippingGridView.GetChildRowCount(i) + shippingGridView.GetChildRowHandle(i, 0);
							for (int ci = shippingGridView.GetChildRowHandle(i, 0); ci < tempVar; ci++)
							{
								string lot = null;
								string note = null;
								if (!Convert.IsDBNull(shippingGridView.GetRowCellValue(ci, lotGridColumn)))
								{
									lot = shippingGridView.GetRowCellValue(ci, lotGridColumn).ToString();
								}
								else
								{
									lot = string.Empty;
								}
								if (!Convert.IsDBNull(shippingGridView.GetRowCellValue(ci, noteGridColumn)))
								{
									note = shippingGridView.GetRowCellValue(ci, noteGridColumn).ToString();
								}
								else
								{
									note = string.Empty;
								}
								if (m_ShippingDetails.UpdateShippingDetails(m_ShippingSession, (int?)shippingGridView.GetRowCellValue(ci, idGridColumn), m_CurrentShippingID.Value, (int?)shippingGridView.GetRowCellValue(ci, itemGridColumn), lot, (int?)shippingGridView.GetRowCellValue(ci, quantityGridColumn), (float?)shippingGridView.GetRowCellValue(ci, palletsGridColumn), note, Utilities.ChangeType<DateTime?>(shippingGridView.GetRowCellValue(ci, expirationDateGridColumn)), Utilities.ChangeType<string>(shippingGridView.GetRowCellValue(ci, fullLPNNumberGridColumn))) != true)
								{
									MessageBox.Show("The shipping details was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
					for (int i = 0; i < shippingGridView.RowCount; i++)
					{
						if (shippingGridView.IsValidRowHandle(i))
						{
							string lot = null;
							string note = null;
							if (!Convert.IsDBNull(shippingGridView.GetRowCellValue(i, lotGridColumn)))
							{
								lot = shippingGridView.GetRowCellValue(i, lotGridColumn).ToString();
							}
							else
							{
								lot = string.Empty;
							}
							if (!Convert.IsDBNull(shippingGridView.GetRowCellValue(i, noteGridColumn)))
							{
								note = shippingGridView.GetRowCellValue(i, noteGridColumn).ToString();
							}
							else
							{
								note = string.Empty;
							}
							if (m_ShippingDetails.UpdateShippingDetails(m_ShippingSession, (int?)shippingGridView.GetRowCellValue(i, idGridColumn), m_CurrentShippingID.Value, (int?)shippingGridView.GetRowCellValue(i, itemGridColumn), lot, (int?)shippingGridView.GetRowCellValue(i, quantityGridColumn), (float?)shippingGridView.GetRowCellValue(i, palletsGridColumn), note, Utilities.ChangeType<DateTime?>(shippingGridView.GetRowCellValue(i, expirationDateGridColumn)), Utilities.ChangeType<string>(shippingGridView.GetRowCellValue(i, fullLPNNumberGridColumn))) != true)
							{
								MessageBox.Show("The shipping details was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
								shouldReturn = true;
								return false;
							}
						}
					}
				}

				foreach (string lpnInventory in m_LPNsInShipment)
				{
					foreach (Inventory lpnRecord in InventoryBLL.GetLPNInventoryRecords(m_ShippingSession, lpnInventory, Convert.ToInt32(customerLookUpEdit.EditValue)))
					{
						lpnRecord.Shipment = m_ShippingSession.GetObjectByKey<Shipping>(m_CurrentShippingID.Value);
						lpnRecord.Save();
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

		private bool SaveShippingMain(ref bool shouldReturn)
		{

			shouldReturn = false;
			try
			{
				if (m_Shippings.UpdateShipping(m_CurrentShippingID.Value, (DateTime?)shipDateEdit.EditValue, (int?)carrierLookUpEdit.EditValue, (int?)customerLookUpEdit.EditValue, (int?)bolTextEdit.EditValue, (int?)destinationLookUpEdit.EditValue, poTextEdit.Text, trailerTextEdit.Text, Utilities.ChangeType<float?>(skitsTextEdit.EditValue), Utilities.ChangeType<float?>(palletsTextEdit.EditValue), sealTextEdit.Text, noteMemoEdit.Text, Convert.ToString(deliveryNoteNumberTextEdit.EditValue), Convert.ToDouble(totalGrossWeightTextEdit.EditValue), customerShipperCheckEdit.Checked, Convert.ToString(commentsMemoEdit.EditValue), (int?)shiftLookUpEdit.EditValue, freightCheckEdit.Checked, (int?)loadedByLookUpEdit.EditValue, (int?)checkedByLookUpEdit.EditValue, GetThreeWayYesNoValue(wheelsChockedComboBoxEdit.Text), (DateTime?)startTimeTimeEdit.EditValue, (DateTime?)finishTimeTimeEdit.EditValue, Utilities.ChangeType<double?>(temparatureSpinEdit.EditValue), (int?)physicalConditionLookUpEdit.EditValue, (int?)loadConditionLookUpEdit.EditValue, GetThreeWayYesNoValue(foreignSubstanceComboBoxEdit.Text), GetThreeWayYesNoValue(insectActivityComboBoxEdit.Text), GetThreeWayYesNoValue(correctPalletsComboBoxEdit.Text), Convert.ToInt32(locationLookUpEdit.EditValue)) != true)
				{
					MessageBox.Show("The shipping was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
					shouldReturn = true;
					return false;
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

		private void skitsTextEdit_Validated(object sender, EventArgs e)
		{

			UpdateTotalPallets();

		}

		private void customerLookUpEdit_Validated(object sender, EventArgs e)
		{

			BindItemLookupEdit();

		}

		public void BindShippingSearchGrid()
		{

			shippingSearchXPView.Reload();

		}

		public void BindShippingsControls(int shippingID)
		{

			if (shippingID == -1)
			{
				return;
			}

			//Dim shipping As SPG.ShippingsRow = CType(m_Shippings.GetShippingByID(shippingID).Rows(0), SPG.ShippingsRow)
			Shipping shipping = m_ShippingSession.GetObjectByKey<Shipping>(shippingID);
			if (shipping == null)
			{
				return;
			}
			m_CurrentShippingID = shipping.ShipMainID;
			customerLookUpEdit.EditValue = shipping.ShipMainCustID.CustomerID;
			shipDateEdit.EditValue = shipping.ShipMainDate;
			bolTextEdit.EditValue = shipping.ShipMainBOL;
			poTextEdit.Text = shipping.strPO;
			carrierLookUpEdit.EditValue = shipping.ShipMainCarrierID.CarrierID;
			trailerTextEdit.Text = shipping.strTrailer;
			sealTextEdit.Text = shipping.strSeal;
			skitsTextEdit.EditValue = shipping.sngSkits;
			palletsTextEdit.EditValue = shipping.sngTotalPallets;
			destinationLookUpEdit.EditValue = shipping.intDestination.AddressID;
			UpdateDestinationAddress(shipping.intDestination.AddressID);
			noteMemoEdit.Text = shipping.strDeliveryNote;
			deliveryNoteNumberTextEdit.EditValue = shipping.DeliveryNoteNumber;
			totalGrossWeightTextEdit.EditValue = shipping.TotalGrossWeight;
			customerShipperCheckEdit.Checked = shipping.Shipper;
			commentsMemoEdit.EditValue = shipping.Comments;
			if (shipping.Shift == null)
			{
				shiftLookUpEdit.EditValue = null;
			}
			else
			{
				shiftLookUpEdit.EditValue = shipping.Shift.ShiftID;
			}
			freightCheckEdit.Checked = shipping.Freight;
			if (shipping.LoadedBy == null)
			{
				loadedByLookUpEdit.EditValue = null;
			}
			else
			{
				loadedByLookUpEdit.EditValue = shipping.LoadedBy.Oid;
			}
			if (shipping.CheckedBy == null)
			{
				checkedByLookUpEdit.EditValue = null;
			}
			else
			{
				checkedByLookUpEdit.EditValue = shipping.CheckedBy.Oid;
			}

			if (shipping.WheelsChocked == 0)
			{
				wheelsChockedComboBoxEdit.EditValue = null;
			}
			else
			{
				wheelsChockedComboBoxEdit.EditValue = Enum.GetName(typeof(DXDAL.ThreeWayYesNo), shipping.WheelsChocked);
			}
			if (shipping.StartTime.Equals(default(DateTime)))
			{
				startTimeTimeEdit.EditValue = null;
			}
			else
			{
				startTimeTimeEdit.EditValue = shipping.StartTime;
			}
			if (shipping.FinishTime.Equals(default(DateTime)))
			{
				finishTimeTimeEdit.EditValue = null;
			}
			else
			{
				finishTimeTimeEdit.EditValue = shipping.FinishTime;
			}
			temparatureSpinEdit.EditValue = shipping.Temparature;
			if (shipping.PhysicalCondition == null)
			{
				physicalConditionLookUpEdit.EditValue = null;
			}
			else
			{
				physicalConditionLookUpEdit.EditValue = shipping.PhysicalCondition.Oid;
			}
			if (shipping.LoadCondition == null)
			{
				loadConditionLookUpEdit.EditValue = null;
			}
			else
			{
				loadConditionLookUpEdit.EditValue = shipping.LoadCondition.Oid;
			}

			if (shipping.ForeignSubstance == 0)
			{
				foreignSubstanceComboBoxEdit.EditValue = null;
			}
			else
			{
				foreignSubstanceComboBoxEdit.EditValue = Enum.GetName(typeof(DXDAL.ThreeWayYesNo), shipping.ForeignSubstance);
			}
			if (shipping.InsectActivity == 0)
			{
				insectActivityComboBoxEdit.EditValue = null;
			}
			else
			{
				insectActivityComboBoxEdit.EditValue = Enum.GetName(typeof(DXDAL.ThreeWayYesNo), shipping.InsectActivity);
			}
			if (shipping.CorrectPallets == 0)
			{
				correctPalletsComboBoxEdit.EditValue = null;
			}
			else
			{
				correctPalletsComboBoxEdit.EditValue = Enum.GetName(typeof(DXDAL.ThreeWayYesNo), shipping.CorrectPallets);
			}
			locationLookUpEdit.EditValue = shipping.ShippingLocation.Oid;

			//fill details tab
			BindItemLookupEdit();

			BindShippingGridControl(shippingID);

			//fill returns tab
			BindReturnsGridControl(shippingID);

			refreshBarButtonItem.Enabled = true;

		}

		public void UpdateDestinationAddress(int addressID)
		{

			SPG.ShippingAddressesDataTable destinations = m_Destinations.GetAddressInfoByID(addressID);
			if (destinations.Count() == 0)
			{
				destinationMemoEdit.Text = "";
			}
			else
			{
				SPG.ShippingAddressesRow destination = (SPG.ShippingAddressesRow)destinations.Rows[0];
				StringBuilder destinationBuilder = new StringBuilder(string.Format("{0}{1}", destination.ShippingName, Environment.NewLine));
				if (!string.IsNullOrEmpty(destination.ContactFirstName) || !string.IsNullOrEmpty(destination.ContactLastName))
				{
					destinationBuilder.AppendFormat("{0} {1}{2}", destination.ContactFirstName, destination.ContactLastName, Environment.NewLine);
				}
				destinationBuilder.Append(string.Format("{0}{1}", destination.ShippingAddress, Environment.NewLine));
				destinationBuilder.AppendFormat("{0}, {1} {2}{3}", destination.ShippingCity, destination.ShippingState, destination.ShippingPostal, Environment.NewLine);
				destinationBuilder.Append(destination.ShippingPhone);
				destinationMemoEdit.Text = destinationBuilder.ToString();
			}

		}

		public void BindItemLookupEdit()
		{

			int? customer = (int?)customerLookUpEdit.EditValue;
			if (customer.HasValue)
			{
				shippingItemXPView.Filter = CriteriaOperator.Or(new BinaryOperator("CustomerID", customer.Value, BinaryOperatorType.Equal), new BinaryOperator("CustomerID", CompanySettingsBLL.GetUniversalCustomer(), BinaryOperatorType.Equal), new InOperator("CustomerID", CustomersBLL.GetRelatedCustomerIDs(CustomersBLL.GetCustomer(customer.Value, m_ShippingSession))));
				returnItemXPView.Filter = CriteriaOperator.Or(new BinaryOperator("CustomerID", customer.Value, BinaryOperatorType.Equal), new InOperator("CustomerID", CustomersBLL.GetRelatedCustomerIDs(CustomersBLL.GetCustomer(customer.Value, m_ShippingSession))));
			}
			else
			{
				shippingItemXPView.Filter = null;
				returnItemXPView.Filter = null;
			}

		}

		public void BindShippingGridControl(int? shippingID)
		{

			if (shippingID.HasValue == false)
			{
				shippingID = 0;
			}

			int? customer = (int?)customerLookUpEdit.EditValue;
			if (customer.HasValue)
			{
				expirationDateGridColumn.DisplayFormat.FormatString = CustomersBLL.GetExpirationDateFormat(customer.Value);
			}

			shippingGridControl.DataSource = m_ShippingDetails.GetDetailsByShippingID(shippingID.Value);

		}

		private void BindReturnsGridControl(int? shippingID)
		{

			if (shippingID.HasValue == false)
			{
				shippingID = 0;
			}

			int? customer = (int?)customerLookUpEdit.EditValue;
			if (customer.HasValue)
			{
				returnExpirationDateGridColumn.DisplayFormat.FormatString = CustomersBLL.GetExpirationDateFormat(customer.Value);
			}

			returnsGridControl.DataSource = m_ShippingReturnDetails.GetShippingReturnDetailsByShippingID(shippingID.Value);

		}

		private void shippingGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
		{

			if (!Convert.IsDBNull(shippingGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, itemGridColumn)))
			{
				int shippingItem = Convert.ToInt32(shippingGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, itemGridColumn));
				if (e.Column.Name == descriptionGridColumn.Name)
				{
					e.Value = ItemsBLL.GetDescriptionByItemID(shippingItem);
				}
				else if (e.Column.Name == grossWeightGridColumn.Name)
				{
					if (!Convert.IsDBNull(shippingGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, quantityGridColumn)))
					{
						e.Value = Math.Ceiling(Convert.ToDouble(shippingGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, quantityGridColumn)) / m_Items.GetUnits(shippingItem)) * m_Items.GetCaseGrossWeight(shippingItem);
					}
					else
					{
						e.Value = m_Items.GetCaseGrossWeight(shippingItem);
					}

				}
			}

		}

		private void returnsGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
		{

			if (!Convert.IsDBNull(returnsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, returnItemGridColumn)))
			{
				if (e.Column.Name == returnItemDescGridColumn.Name)
				{
					e.Value = ItemsBLL.GetDescriptionByItemID(Convert.ToInt32(returnsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, returnItemGridColumn)));
				}
				else if (e.Column.Name == returnGrossWeightGridColumn.Name)
				{
					int returnItem = Convert.ToInt32(returnsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, returnItemGridColumn));
					if (!Convert.IsDBNull(returnsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, returnQuantityGridColumn)))
					{
						e.Value = Math.Ceiling(Convert.ToDouble(returnsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, returnQuantityGridColumn)) / m_Items.GetUnits(returnItem) * m_Items.GetCaseGrossWeight(returnItem));
					}
					else
					{
						e.Value = m_Items.GetCaseGrossWeight(returnItem);
					}
				}
			}

		}

		private void shippingGridView_InitNewRow(object sender, InitNewRowEventArgs e)
		{

			shippingGridView.SetRowCellValue(e.RowHandle, shippingIDGridColumn, m_CurrentShippingID);
			shippingGridView.SetRowCellValue(e.RowHandle, quantityGridColumn, 0);
			shippingGridView.SetRowCellValue(e.RowHandle, palletsGridColumn, 0);

		}

		private void returnsGridView_InitNewRow(object sender, InitNewRowEventArgs e)
		{

			returnsGridView.SetRowCellValue(e.RowHandle, ShippingMainIDGridColumn, m_CurrentShippingID);
			returnsGridView.SetRowCellValue(e.RowHandle, returnQuantityGridColumn, 0);
			returnsGridView.SetRowCellValue(e.RowHandle, returnUnitsGridColumn, 0);
			returnsGridView.SetRowCellValue(e.RowHandle, returnPalletsGridColumn, 0);

		}

		//Private Sub FilterLookUpEditValidated(ByVal sender As System.Object, ByVal e As System.EventArgs)

		//    'BindShippingsListBox()

		//End Sub

		public void UpdateTotalPallets()
		{

			//Makes sure the summary is updated before calculating the total pallets
			shippingGridView.UpdateTotalSummary();
			returnsGridView.UpdateTotalSummary();
			int pallets = Convert.ToInt32(palletsGridColumn.SummaryItem.SummaryValue) + Convert.ToInt32(returnPalletsGridColumn.SummaryItem.SummaryValue) + Convert.ToInt32(Math.Ceiling(Convert.ToDouble(skitsTextEdit.Text)));
			palletsTextEdit.Text = pallets.ToString("f2");
			totalGrossWeightTextEdit.EditValue = Convert.ToDouble(grossWeightGridColumn.SummaryItem.SummaryValue) + Convert.ToDouble(returnGrossWeightGridColumn.SummaryItem.SummaryValue) + (pallets * 40);

		}

		private void shippingGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
		{

			if (Convert.IsDBNull(shippingGridView.GetFocusedRowCellValue(itemGridColumn)))
			{
				return;
			}
			switch (e.Column.Name)
			{
				case "itemGridColumn":
					if (Convert.ToDouble(shippingGridView.GetFocusedRowCellValue(quantityGridColumn)) > 0)
					{
						UpdatePallets();
					}
					break;
				case "quantityGridColumn":
					UpdatePallets();
					break;
				case "palletsGridColumn":
					UpdateTotalPallets();
					break;
			}

		}

		private void returnsGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
		{

			if ((returnsGridView.GetFocusedRowCellValue(returnItemGridColumn) == null) || Convert.IsDBNull(returnsGridView.GetFocusedRowCellValue(returnItemGridColumn)))
			{
				return;
			}
//INSTANT C# NOTE: The following VB 'Select Case' included either a non-ordinal switch expression or non-ordinal, range-type, or non-constant 'Case' expressions and was converted to C# 'if-else' logic:
//				Select Case e.Column.Name
//ORIGINAL LINE: Case returnItemGridColumn.Name
			if (e.Column.Name == returnItemGridColumn.Name)
			{
				if (Convert.ToDouble(returnsGridView.GetFocusedRowCellValue(returnQuantityGridColumn)) > 0)
				{
					UpdateReturnPallets();
				}
			}
//ORIGINAL LINE: Case returnQuantityGridColumn.Name
			else if (e.Column.Name == returnQuantityGridColumn.Name)
			{
				if (Convert.ToDouble(returnsGridView.GetFocusedRowCellValue(returnQuantityGridColumn)) > 0)
				{
					UpdateReturnPallets();
				}
			}
//ORIGINAL LINE: Case returnUnitsGridColumn.Name
			else if (e.Column.Name == returnUnitsGridColumn.Name)
			{
				if (Convert.ToDouble(returnsGridView.GetFocusedRowCellValue(returnUnitsGridColumn)) > 0)
				{
					UpdateReturnPallets();
				}
			}
//ORIGINAL LINE: Case returnPalletsGridColumn.Name
			else if (e.Column.Name == returnPalletsGridColumn.Name)
			{
				UpdateTotalPallets();
			}

		}

		private void destinationLookUpEdit_Validated(object sender, EventArgs e)
		{

			UpdateDestinationAddress(Convert.ToInt32(destinationLookUpEdit.EditValue));

		}

		public void UpdatePallets()
		{

			float pallets = m_Items.GetCasesPerPallet(Convert.ToInt32(shippingGridView.GetFocusedRowCellValue(itemGridColumn)));
			if (pallets != 0)
			{
				if (shippingGridView.GetFocusedRowCellValue(fullLPNNumberGridColumn) == null)
				{
					shippingGridView.SetFocusedRowCellValue(palletsGridColumn, Math.Ceiling(Convert.ToDouble(shippingGridView.GetFocusedRowCellValue(quantityGridColumn)) / pallets));
				}
				else
				{
					shippingGridView.SetFocusedRowCellValue(palletsGridColumn, Convert.ToDouble(shippingGridView.GetFocusedRowCellValue(quantityGridColumn)) / pallets);
				}
			}
			else
			{
				shippingGridView.SetFocusedRowCellValue(palletsGridColumn, 0);
			}

		}

		public void UpdateReturnPallets()
		{

			double units = ItemsBLL.GetCaseQuantity(Convert.ToInt32(returnsGridView.GetRowCellValue(returnsGridView.FocusedRowHandle, returnItemGridColumn)));

			if (Convert.ToDouble(returnsGridView.GetFocusedRowCellValue(returnUnitsGridColumn)) < 1)
			{
				if (units != 0)
				{
					returnsGridView.SetFocusedRowCellValue(returnUnitsGridColumn, Convert.ToDouble(returnsGridView.GetFocusedRowCellValue(returnQuantityGridColumn)) * units);
				}
				else
				{
					returnsGridView.SetFocusedRowCellValue(returnUnitsGridColumn, 0);
				}
			}

			//calculate the quantity
			if (Convert.ToDouble(returnsGridView.GetFocusedRowCellValue(returnQuantityGridColumn)) == 0)
			{
				if (units != 0)
				{
					returnsGridView.SetFocusedRowCellValue(returnQuantityGridColumn, Math.Ceiling(Convert.ToDouble(returnsGridView.GetFocusedRowCellValue(returnUnitsGridColumn)) / units));
				}
			}

			float pallets = m_Items.GetCasesPerPallet(Convert.ToInt32(returnsGridView.GetFocusedRowCellValue(returnItemGridColumn)));
			if (pallets != 0)
			{
				returnsGridView.SetFocusedRowCellValue(returnPalletsGridColumn, Math.Ceiling(Convert.ToDouble(returnsGridView.GetFocusedRowCellValue(returnQuantityGridColumn)) / pallets));
			}
			else
			{
				returnsGridView.SetFocusedRowCellValue(returnPalletsGridColumn, 0);
			}

		}

		private void shippingSearchGridView_Click(object sender, EventArgs e)
		{

			if (shippingSearchGridView.CalcHitInfo(shippingSearchGridControl.PointToClient(Control.MousePosition)).HitTest == GridHitTest.RowCell)
			{
				BindShippingsControls(Convert.ToInt32(shippingSearchGridView.GetFocusedRowCellValue(shippingSearchIDGridColumn)));
			}

		}

		private void addBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			m_CurrentShippingID = -1;
			shipDateEdit.EditValue = null;
			customerLookUpEdit.EditValue = null;
			carrierLookUpEdit.EditValue = null;
			bolTextEdit.EditValue = null;
			skitsTextEdit.EditValue = 0;
			poTextEdit.Text = string.Empty;
			palletsTextEdit.EditValue = 0;
			trailerTextEdit.Text = string.Empty;
			sealTextEdit.Text = string.Empty;
			destinationLookUpEdit.EditValue = null;
			destinationMemoEdit.Text = "";
			noteMemoEdit.Text = $"{Environment.NewLine}{Environment.NewLine}IDEAL REFER TEMPERATURE IS{Environment.NewLine}65�F - 75�F CANDY{Environment.NewLine}55�F - 60�F CHOCOLATE";
			deliveryNoteNumberTextEdit.EditValue = string.Empty;
			totalGrossWeightTextEdit.EditValue = 0;
			customerShipperCheckEdit.Checked = false;
			commentsMemoEdit.EditValue = string.Empty;
			shiftLookUpEdit.EditValue = null;
			freightCheckEdit.Checked = true;
			loadedByLookUpEdit.EditValue = null;
			checkedByLookUpEdit.EditValue = null;
			wheelsChockedComboBoxEdit.EditValue = null;
			startTimeTimeEdit.EditValue = null;
			finishTimeTimeEdit.EditValue = null;
			temparatureSpinEdit.EditValue = null;
			physicalConditionLookUpEdit.EditValue = null;
			loadConditionLookUpEdit.EditValue = null;
			foreignSubstanceComboBoxEdit.EditValue = null;
			insectActivityComboBoxEdit.EditValue = null;
			correctPalletsComboBoxEdit.EditValue = null;
			locationLookUpEdit.EditValue = UsersBLL.GetUsersLocalLocation(m_ShippingSession, Properties.Settings.Default.UserName).Oid;

			BindShippingGridControl(m_CurrentShippingID);
			BindReturnsGridControl(m_CurrentShippingID);

			shippingXtraTabControl.SelectedTabPage = generalXtraTabPage;

			Utilities.MakeFormReadOnly(generalXtraTabPage, false);
			Utilities.MakeFormReadOnly(shipmentInfoXtraTabPage, false);
			bolTextEdit.Properties.ReadOnly = true;
			palletsTextEdit.Properties.ReadOnly = true;
			totalGrossWeightTextEdit.Properties.ReadOnly = true;
			destinationMemoEdit.Properties.ReadOnly = true;
			shippingGridView.OptionsBehavior.Editable = true;
			lpnNumberTextEdit.Properties.ReadOnly = false;
			// Utilities.MakeGridReadOnly(Me.returnsGridView, False)
			shippingSearchGridControl.Enabled = false;
			CheckPermissions();

			cancelBarButtonItem.Enabled = true;
			saveBarButtonItem.Enabled = true;
			editBarButtonItem.Enabled = false;
			addBarButtonItem.Enabled = false;
			refreshBarButtonItem.Enabled = false;

		}

		private void editBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (m_CurrentShippingID == null)
			{
				MessageBox.Show("Please Select a shipping entry To edit.");
				return;
			}

			Utilities.MakeFormReadOnly(generalXtraTabPage, false);
			Utilities.MakeFormReadOnly(shipmentInfoXtraTabPage, false);
			bolTextEdit.Properties.ReadOnly = true;
			palletsTextEdit.Properties.ReadOnly = true;
			totalGrossWeightTextEdit.Properties.ReadOnly = true;
			destinationMemoEdit.Properties.ReadOnly = true;
			shippingGridView.OptionsBehavior.Editable = true;
			locationLookUpEdit.Properties.ReadOnly = false;
			lpnNumberTextEdit.Properties.ReadOnly = false;
			//Utilities.MakeGridReadOnly(Me.returnsGridView, False)
			shippingSearchGridControl.Enabled = false;
			CheckPermissions();

			cancelBarButtonItem.Enabled = true;
			saveBarButtonItem.Enabled = true;
			editBarButtonItem.Enabled = false;
			addBarButtonItem.Enabled = false;
			refreshBarButtonItem.Enabled = false;

		}

		private void cancelBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			CancelChanges();

			CheckPermissions();

			Utilities.MakeFormReadOnly(generalXtraTabPage, true);
			Utilities.MakeFormReadOnly(shipmentInfoXtraTabPage, true);
			shippingGridView.OptionsBehavior.Editable = false;
			lpnNumberTextEdit.Properties.ReadOnly = true;
			//Utilities.MakeGridReadOnly(Me.returnsGridView, True)
			shippingSearchGridControl.Enabled = true;

			cancelBarButtonItem.Enabled = false;
			saveBarButtonItem.Enabled = false;
			refreshBarButtonItem.Enabled = true;

		}

		private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (SaveChanges())
			{
				CheckPermissions();

				Utilities.MakeFormReadOnly(generalXtraTabPage, true);
				Utilities.MakeFormReadOnly(shipmentInfoXtraTabPage, true);
				shippingGridView.OptionsBehavior.Editable = false;
				lpnNumberTextEdit.Properties.ReadOnly = true;
				// Utilities.MakeGridReadOnly(Me.returnsGridView, True)
				shippingSearchGridControl.Enabled = true;

				cancelBarButtonItem.Enabled = false;
				saveBarButtonItem.Enabled = false;
				refreshBarButtonItem.Enabled = true;
			}

		}

		public bool CheckPermissions()
		{

			try
			{
				SPG.UserPermissionsRow permission = (new UserPermissionsBLL()).GetUserPermissionsByUserName(Properties.Settings.Default.UserName, "Shipping Form")[0];

				switch (permission.PermissionLevel)
				{
					case "FULL":
					case "Full":
						addBarButtonItem.Enabled = true;
						editBarButtonItem.Enabled = true;
						delGridColumn.Visible = true;
						deleteReturnGridColumn.Visible = true;
						break;
					case "ADD":
					case "Add":
						addBarButtonItem.Enabled = true;
						editBarButtonItem.Enabled = true;
						delGridColumn.Visible = false;
						deleteReturnGridColumn.Visible = false;
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
						delGridColumn.Visible = false;
						deleteReturnGridColumn.Visible = false;
						break;
					case "EDIT":
					case "Edit":
						addBarButtonItem.Enabled = false;
						editBarButtonItem.Enabled = true;
						delGridColumn.Visible = false;
						deleteReturnGridColumn.Visible = false;
						break;
					case "VIEW ASSIGNED":
						addBarButtonItem.Enabled = false;
						editBarButtonItem.Enabled = false;
						delGridColumn.Visible = false;
						deleteReturnGridColumn.Visible = false;
						FilterAssignedCustomers();
						break;
					case "EDIT ASSIGNED":
						addBarButtonItem.Enabled = false;
						editBarButtonItem.Enabled = true;
						delGridColumn.Visible = false;
						deleteReturnGridColumn.Visible = false;
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

			shippingSearchXPView.Criteria = new InOperator(Shipping.Fields.ShipMainCustID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ShippingSession));
			customersXPView.Criteria = CriteriaOperator.And(new BinaryOperator(Customers.Fields.Inactive.PropertyName, false), new InOperator(Customers.Fields.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ShippingSession)));
			shippingItemXPView.Criteria = CriteriaOperator.Or(new InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ShippingSession)), new BinaryOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, CompanySettingsBLL.GetUniversalCustomer(), BinaryOperatorType.Equal));
			returnItemXPView.Criteria = CriteriaOperator.And(new InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ShippingSession)), new InOperator(Items.Fields.ItemType.PropertyName, new string[] {"RM", "IG"}));

		}

		private void CancelChanges()
		{

			if (m_CurrentShippingID != null)
			{
				BindShippingsControls(m_CurrentShippingID.Value);
			}

		}

		private int m_TotalPallets = 0;
		private List<string> m_LPNsInShipment = new List<string>();

		private void shippingGridView_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
		{

			switch (e.SummaryProcess)
			{
				case DevExpress.Data.CustomSummaryProcess.Finalize:
					e.TotalValue = m_TotalPallets + m_LPNsInShipment.Count;
					break;
				case DevExpress.Data.CustomSummaryProcess.Start:
					m_TotalPallets = 0;
					m_LPNsInShipment.Clear();
					break;
				case DevExpress.Data.CustomSummaryProcess.Calculate:
					if (shippingGridView.GetRowCellValue(e.RowHandle, fullLPNNumberGridColumn) == null || Convert.IsDBNull(shippingGridView.GetRowCellValue(e.RowHandle, fullLPNNumberGridColumn)))
					{
						m_TotalPallets += Convert.ToInt32(Math.Ceiling(Convert.ToDouble(shippingGridView.GetRowCellValue(e.RowHandle, palletsGridColumn))));
					}
					else
					{
						if (!m_LPNsInShipment.Contains(shippingGridView.GetRowCellValue(e.RowHandle, fullLPNNumberGridColumn).ToString()))
						{
							m_LPNsInShipment.Add(shippingGridView.GetRowCellValue(e.RowHandle, fullLPNNumberGridColumn).ToString());
						}
					}

					break;
			}

		}

		private int m_TotalReturnedPallets = 0;

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
					m_TotalReturnedPallets += Convert.ToInt32(Math.Ceiling(Convert.ToDouble(returnsGridView.GetRowCellValue(e.RowHandle, returnPalletsGridColumn))));

					break;
			}

		}

		private void printBOLBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (m_CurrentShippingID == null)
			{
				return;
			}

			SPG.CustomersRow cstmr = m_CustomerShippings.GetCustomerByID(Convert.ToInt32(customerLookUpEdit.EditValue))[0];
			BillOfLadingXtraReport bol = new BillOfLadingXtraReport();

			bol.locationId.Text = locationLookUpEdit.Text;
			bol.dateXrLabel.DataBindings.Add("Text", null, "ShipMainDate", "{0:MM/dd/yyyy}");
			bol.bolXrLabel.DataBindings.Add("Text", null, "ShipMainBOL");
			bol.poXrLabel.DataBindings.Add("Text", null, "strPO");
			bol.deliveryNoteNumberXrLabel.DataBindings.Add("Text", null, "DeliveryNoteNumber");
			bol.carrierXrLabel.DataBindings.Add("Text", null, "CarrierName");
			bol.trailerXrLabel.DataBindings.Add("Text", null, "strTrailer");
			bol.sealXrLabel.DataBindings.Add("Text", null, "strSeal");
			bol.returnsGroupHeader.GroupFields.Add(new GroupField("ShippingType", XRColumnSortOrder.Ascending));
			bol.itemGroupHeader.GroupFields.Add(new GroupField("ItemCode", XRColumnSortOrder.Ascending));
			bol.qtyXrLabel.DataBindings.Add("Text", null, "ShipDetDetQty");
			bol.itemCodeXrLabel.DataBindings.Add("Text", null, "ItemCode");
			bol.itemDescriptionXrLabel.DataBindings.Add("Text", null, "ItemDescription");
			bol.palletsXrLabel.DataBindings.Add("Text", null, "sngPallets", "{0:N2}");
			//.additionalPalletsXrLabel.DataBindings.Add("Text", Nothing, "sngSkits")
			bol.totalPalletsXrLabel.DataBindings.Add("Text", null, "sngTotalPallets", "{0:N2}");
			bol.palletsTotalXrLabel.DataBindings.Add("Text", null, "sngTotalPallets", "{0:N2}");
			bol.weightXrLabel.DataBindings.Add("Text", null, "Weight", "{0:N2}");
			bol.totalWeightXrLabel.DataBindings.Add("Text", null, "TotalGrossWeight", "{0:N2}");
			bol.notesXrLabel.DataBindings.Add("Text", null, "strDeliveryNote");
			bol.freightXrCheckBox.DataBindings.Add("Checked", null, "Freight");
			bol.itemTotalQuantityXrLabel.DataBindings.Add("Text", null, "ShipDetDetQty");
			bol.groupItemCodeXrLabel.DataBindings.Add("Text", null, "ItemCode");
			bol.groupItemDescriptionXrLabel.DataBindings.Add("Text", null, "ItemDescription");
			bol.itemTotalPalletsXrLabel.DataBindings.Add("Text", null, "sngPallets", "{0:N2}");
			bol.itemTotalWeightXrLabel.DataBindings.Add("Text", null, "Weight", "{0:N2}");
			bol.billTo.Text = $"{cstmr.CustomerName}{Environment.NewLine}{cstmr.Address}{Environment.NewLine}{cstmr.City}, {cstmr.State} {cstmr.ZipCode}";
			bol.DataSource = (new BOLReportBLL()).Getbolreport(m_CurrentShippingID.Value);
			bol.ShowPreview();

		}

		private void returnsGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
		{

			double stock = ItemsBLL.GetQtyOnHandByID(m_ShippingSession, Convert.ToInt32(returnsGridView.GetRowCellValue(e.RowHandle, returnItemGridColumn)), Convert.ToInt32(locationLookUpEdit.EditValue));
			double returnQuantity = 0;
			if (Convert.ToInt32(returnsGridView.GetRowCellValue(e.RowHandle, returnIDGridColumn)) < 1)
			{
				returnQuantity = Convert.ToDouble(returnsGridView.GetRowCellValue(e.RowHandle, returnQuantityGridColumn));
			}
			else
			{
				returnQuantity = Convert.ToDouble(returnsGridView.GetRowCellValue(e.RowHandle, returnQuantityGridColumn)) - Convert.ToInt32(returnsGridView.GetDataRow(e.RowHandle)[4, DataRowVersion.Original]);
			}

			if (stock < returnQuantity)
			{
				MessageBox.Show(string.Format("{0} does only have {1} in stock and your returning {2}.", returnsGridView.GetRowCellDisplayText(e.RowHandle, returnItemGridColumn).ToString(), stock.ToString(), returnQuantity.ToString()), "Stock Verification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				e.Valid = false;
				m_CanSaveReturns = false;
			}
			else
			{
				m_CanSaveReturns = true;
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
				int lShippingReturnDetailID = Convert.ToInt32(returnsGridView.GetRowCellValue(returnsGridView.FocusedRowHandle, returnIDGridColumn));
				if (lShippingReturnDetailID <= -1)
				{
					returnsGridView.DeleteRow(returnsGridView.FocusedRowHandle);
				}
				else if (m_ShippingReturnDetails.DeleteReturnDetail(m_ShippingSession, lShippingReturnDetailID) == true)
				{
					BindReturnsGridControl(m_CurrentShippingID);
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

			if (shippingGridView.GetRowCellValue(shippingGridView.FocusedRowHandle, fullLPNNumberGridColumn) == null || Convert.IsDBNull(shippingGridView.GetRowCellValue(shippingGridView.FocusedRowHandle, fullLPNNumberGridColumn)))
			{
				if (MessageBox.Show("Are you sure you want to delete this shipping detail.", "Delete shipping detail", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
				{
					return;
				}
			}
			else
			{
				if (MessageBox.Show("Are you sure you want to delete this LPN from the shipping detail.", "Delete LPN shipping detail", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
				{
					return;
				}
			}

			int lShippingDetailID = 0;
			try
			{
				if (shippingGridView.GetRowCellValue(shippingGridView.FocusedRowHandle, fullLPNNumberGridColumn) == null || Convert.IsDBNull(shippingGridView.GetRowCellValue(shippingGridView.FocusedRowHandle, fullLPNNumberGridColumn)))
				{
					lShippingDetailID = Convert.ToInt32(shippingGridView.GetRowCellValue(shippingGridView.FocusedRowHandle, idGridColumn));
					if (lShippingDetailID <= -1)
					{
						shippingGridView.DeleteRow(shippingGridView.FocusedRowHandle);
					}
					else if (m_ShippingDetails.DeleteShippingDetail(m_ShippingSession, lShippingDetailID) == true)
					{
						BindShippingGridControl(m_CurrentShippingID);
					}
					else
					{
						MessageBox.Show("The shipping detail was not deleted.");
					}
				}
				else
				{
					int rowHandle = 0;
					string lpnToDelete = shippingGridView.GetRowCellValue(shippingGridView.FocusedRowHandle, fullLPNNumberGridColumn).ToString();
					for (int i = 0; i < shippingGridView.RowCount; i++)
					{
						rowHandle = shippingGridView.GetRowHandle(i);
						if (shippingGridView.GetRowCellValue(rowHandle, fullLPNNumberGridColumn) != null && shippingGridView.GetRowCellValue(rowHandle, fullLPNNumberGridColumn).ToString() == lpnToDelete)
						{
							lShippingDetailID = Convert.ToInt32(shippingGridView.GetRowCellValue(rowHandle, idGridColumn));
							if (lShippingDetailID <= -1)
							{
								shippingGridView.DeleteRow(rowHandle);
							}
							else
							{
								m_ShippingDetails.DeleteShippingDetail(m_ShippingSession, lShippingDetailID);
								shippingGridView.DeleteRow(rowHandle);
							}
						}
					}
					//BindShippingGridControl(m_CurrentShippingID) -- had to comment it out because it deletes all unsaved records --
					if (!lpnToDelete.StartsWith(CustomersBLL.GetLPNPrefix(7)))
					{
						foreach (Inventory lpnRecord in InventoryBLL.GetLPNInventoryRecords(m_ShippingSession, lpnToDelete, Convert.ToInt32(customerLookUpEdit.EditValue)))
						{
							lpnRecord.Shipment = null;
							lpnRecord.Save();
						}
					}
				}
			}
			catch (ApplicationException ex)
			{
				MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void itemRepositoryItemLookUpEdit_Closed(object sender, ClosedEventArgs e)
		{

			BindItemLookupEdit();

			if (e.CloseMode == PopupCloseMode.Normal)
			{
				GridView view = (GridView)(((DevExpress.XtraGrid.GridControl)(((LookUpEdit)sender).Parent)).FocusedView);
				if (view.IsNewItemRow(view.FocusedRowHandle))
				{
					view.CloseEditor();
					view.UpdateCurrentRow();
				}
			}

		}

		private void itemRepositoryItemLookUpEdit_Enter(object sender, EventArgs e)
		{

			shippingItemXPView.Filter = CriteriaOperator.And(shippingItemXPView.Filter, new BinaryOperator("Inactive", false));
			returnItemXPView.Filter = CriteriaOperator.And(returnItemXPView.Filter, new BinaryOperator("Inactive", false));

		}

		private void shippingGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
		{

			double stock = ItemsBLL.GetQtyOnHandByID(m_ShippingSession, Convert.ToInt32(shippingGridView.GetRowCellValue(e.RowHandle, itemGridColumn)), Convert.ToInt32(locationLookUpEdit.EditValue)); //, "1111", 44)
			object shippingQuantity = null;
			if (Convert.ToInt32(shippingGridView.GetRowCellValue(e.RowHandle, idGridColumn)) < 1)
			{
				shippingQuantity = Convert.ToInt32(shippingGridView.GetRowCellValue(e.RowHandle, quantityGridColumn));
			}
			else
			{
				shippingQuantity = Convert.ToInt32(shippingGridView.GetRowCellValue(e.RowHandle, quantityGridColumn)) - Convert.ToInt32(shippingGridView.GetDataRow(e.RowHandle)[4, DataRowVersion.Original]);
			}

			if (stock < Convert.ToDouble(shippingQuantity))
			{
				MessageBox.Show(string.Format("{0} does only have {1} in stock and your shipping {2}.{3}You must enter first the production.", shippingGridView.GetRowCellDisplayText(e.RowHandle, itemGridColumn).ToString(), stock.ToString(), shippingQuantity.ToString(), Environment.NewLine), "Stock Verification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				e.Valid = false;
				m_CanSaveDetails = false;
			}
			else
			{
				m_CanSaveDetails = true;
			}

		}

		private bool ValidateAvailability(GridView view, GridColumn item, GridColumn quantity)
		{
			//TODO:calculate availability by the summary of all the rows for that item.
			Dictionary<int, double> totalShippingQuantity = new Dictionary<int, double>();

			double stock = 0;
			int shippingQuantity = 0;
			if (view.GroupCount == 0)
			{
				for (int i = 0; i < view.RowCount; i++)
				{
					if (view.IsValidRowHandle(i))
					{
						view.GetRow(i);
						stock = ItemsBLL.GetQtyOnHandByID(m_ShippingSession, Convert.ToInt32(view.GetRowCellValue(i, item)), Convert.ToInt32(locationLookUpEdit.EditValue));
						if (view.GetDataRow(i).RowState == DataRowState.Unchanged)
						{
							continue;
						}
						if (view.GetDataRow(i).RowState == DataRowState.Modified)
						{
							shippingQuantity = Convert.ToInt32(view.GetRowCellValue(i, quantity)) - Convert.ToInt32(view.GetDataRow(i)[4, DataRowVersion.Original]);
						}
						else
						{
							shippingQuantity = Convert.ToInt32(view.GetRowCellValue(i, quantity));
						}
						if (stock < shippingQuantity)
						{
							MessageBox.Show(string.Format("{0} does only have {1} in stock and your shipping {2}.{3}You must enter first the production.", view.GetRowCellDisplayText(i, item).ToString(), stock.ToString(), shippingQuantity.ToString(), Environment.NewLine), "Stock Verification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							return false;
						}
						if (totalShippingQuantity.ContainsKey(Convert.ToInt32(view.GetRowCellValue(i, item))))
						{
							totalShippingQuantity[Convert.ToInt32(view.GetRowCellValue(i, item))] += shippingQuantity;
						}
						else
						{
							totalShippingQuantity.Add(Convert.ToInt32(view.GetRowCellValue(i, item)), shippingQuantity);
						}
					}
				}
			}
			else
			{
				int i = -1;
				while (view.IsValidRowHandle(i))
				{
					if (view.GetChildRowHandle(i, 0) > -1)
					{
//INSTANT C# NOTE: The ending condition of VB 'For' loops is tested only on entry to the loop. Instant C# has created a temporary variable in order to use the initial value of view.GetChildRowCount(i) + view.GetChildRowHandle(i, 0) for every iteration:
						int tempVar = view.GetChildRowCount(i) + view.GetChildRowHandle(i, 0);
						for (int ci = view.GetChildRowHandle(i, 0); ci < tempVar; ci++)
						{
							stock = ItemsBLL.GetQtyOnHandByID(m_ShippingSession, Convert.ToInt32(view.GetRowCellValue(ci, item)), Convert.ToInt32(locationLookUpEdit.EditValue));
							if (view.GetDataRow(ci).RowState == DataRowState.Unchanged)
							{
								continue;
							}
							if (view.GetDataRow(ci).RowState == DataRowState.Modified)
							{
								shippingQuantity = Convert.ToInt32(view.GetRowCellValue(ci, quantity)) - Convert.ToInt32(view.GetDataRow(ci)[4, DataRowVersion.Original]);
							}
							else
							{
								shippingQuantity = Convert.ToInt32(view.GetRowCellValue(ci, quantity));
							}
							if (stock < shippingQuantity)
							{
								MessageBox.Show(string.Format("{0} does only have {1} in stock and your shipping {2}.{3}You must enter first the production.", view.GetRowCellDisplayText(ci, itemGridColumn).ToString(), stock.ToString(), shippingQuantity.ToString(), Environment.NewLine), "Stock Verification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								return false;
							}
							if (totalShippingQuantity.ContainsKey(Convert.ToInt32(view.GetRowCellValue(ci, item))))
							{
								totalShippingQuantity[Convert.ToInt32(view.GetRowCellValue(ci, item))] += shippingQuantity;
							}
							else
							{
								totalShippingQuantity.Add(Convert.ToInt32(view.GetRowCellValue(ci, item)), shippingQuantity);
							}
						}
					}
					i -= 1;
				}
			}

			foreach (int product in totalShippingQuantity.Keys)
			{
				stock = ItemsBLL.GetQtyOnHandByID(m_ShippingSession, product, Convert.ToInt32(locationLookUpEdit.EditValue));
				if (stock < totalShippingQuantity[product])
				{
					MessageBox.Show(string.Format("{0} does only have {1} in stock and your shipping {2}.{3}You must enter first the production.", m_ShippingSession.GetObjectByKey<Items>(product).ItemCode, stock.ToString(), totalShippingQuantity[product].ToString(), Environment.NewLine), "Stock Verification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					return false;
				}
			}

			return true;

		}

		private bool ValidateAvailability()
		{

			if (ValidateAvailability(shippingGridView, itemGridColumn, quantityGridColumn) && ValidateAvailability(returnsGridView, returnItemGridColumn, returnQuantityGridColumn))
			{
				return true;
			}
			else
			{
				return false;
			}

		}

		private void shippingGridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
		{

			e.ExceptionMode = ExceptionMode.NoAction;
			shippingGridView.FocusedColumn = quantityGridColumn;

		}

		private void returnsGridView_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
		{

			e.ExceptionMode = ExceptionMode.NoAction;
			returnsGridView.FocusedColumn = returnQuantityGridColumn;

		}

		private void LPNNumber_KeyDown(object sender, KeyEventArgs e)
		{
			bool spgInventory = false;
			if (e.KeyCode == Keys.Enter && customerLookUpEdit.EditValue != null)
			{
				int customerID = Convert.ToInt32(customerLookUpEdit.EditValue);
				if (lpnNumberTextEdit.Text.StartsWith(CustomersBLL.GetLPNPrefix(7)))
				{
					spgInventory = true;
				}

				if (!spgInventory && ShippingsBLL.IsLPNShipped(lpnNumberTextEdit.Text, customerID, m_ShippingSession))
				{
						MessageBox.Show("This LPN is already shipped.");
					}
					else
					{
						string fullLPN = null;

					if (lpnNumberTextEdit.Text.StartsWith(CustomersBLL.GetLPNPrefix(customerID)))
					{
						fullLPN = lpnNumberTextEdit.Text;
					}
					else if (spgInventory)
					{
						fullLPN = lpnNumberTextEdit.Text;
					}
					else
					{
						fullLPN = CustomersBLL.GetLPNPrefix(customerID) + ("0000000000" + lpnNumberTextEdit.Text).Substring(("0000000000" + lpnNumberTextEdit.Text).Length - (CustomersBLL.GetCustomer(customerID, m_ShippingSession).LastLPNNumber.ToString().Length));
					}

					for (int i = 0; i < shippingGridView.RowCount; i++)
					{
						if (shippingGridView.GetDataRow(i) != null && shippingGridView.GetDataRow(i)["fullLPNNumber"].Equals(fullLPN))
						{
							MessageBox.Show("This LPN is already entered.");
							lpnNumberTextEdit.EditValue = null;
							return;
						}
					}

					if (spgInventory)
					{
						int LPN = int.Parse(lpnNumberTextEdit.Text.Replace(CustomersBLL.GetLPNPrefix(7), ""));

						foreach (LocationInventoryByLot record in new XPCollection<LocationInventoryByLot>(m_ShippingSession, new GroupOperator(new BinaryOperator(LocationInventoryByLot.Fields.LPNNumber, LPN, BinaryOperatorType.Equal) & new BinaryOperator(LocationInventoryByLot.Fields.Location.Oid.PropertyName, locationLookUpEdit.EditValue, BinaryOperatorType.Equal) & new BinaryOperator(LocationInventoryByLot.Fields.QuantityOnHand.PropertyName, 0, BinaryOperatorType.Greater) & new BinaryOperator(LocationInventoryByLot.Fields.LocationInventoryItem.ItemCustomerID.CustomerID.PropertyName, customerID, BinaryOperatorType.Equal))))
						{
							shippingGridView.AddNewRow();
							shippingGridView.SetRowCellValue(shippingGridView.FocusedRowHandle, itemGridColumn, record.LocationInventoryItem.ItemID);
							shippingGridView.SetRowCellValue(shippingGridView.FocusedRowHandle, quantityGridColumn, record.QuantityOnHand);
							shippingGridView.SetRowCellValue(shippingGridView.FocusedRowHandle, lotGridColumn, record.LocationInventoryLot);
							shippingGridView.SetRowCellValue(shippingGridView.FocusedRowHandle, expirationDateGridColumn, record.ExpirationDate);
							fullLPN = CustomersBLL.GetLPNPrefix(7) + ("0000000000" + record.LPNNumber.ToString()).Substring(("0000000000" + record.LPNNumber.ToString()).Length - (CustomersBLL.GetCustomer(7, m_ShippingSession).LastLPNNumber.ToString().Length));
							shippingGridView.SetRowCellValue(shippingGridView.FocusedRowHandle, fullLPNNumberGridColumn, fullLPN);
							shippingGridView.UpdateCurrentRow();
						}
					}
					else
					{
						foreach (Inventory record in InventoryBLL.GetLPNInventoryRecords(m_ShippingSession, fullLPN, customerID))
						{
							shippingGridView.AddNewRow();
							shippingGridView.SetRowCellValue(shippingGridView.FocusedRowHandle, itemGridColumn, record.InventoryItemID.ItemID);
							shippingGridView.SetRowCellValue(shippingGridView.FocusedRowHandle, quantityGridColumn, record.InventoryQuantity);
							shippingGridView.SetRowCellValue(shippingGridView.FocusedRowHandle, lotGridColumn, record.Lot);
							shippingGridView.SetRowCellValue(shippingGridView.FocusedRowHandle, expirationDateGridColumn, record.ExpirationDate);
							shippingGridView.SetRowCellValue(shippingGridView.FocusedRowHandle, fullLPNNumberGridColumn, record.FullLPNNumber);
							shippingGridView.UpdateCurrentRow();
						}
					}
				}
				lpnNumberTextEdit.EditValue = null;
			}

		}

		private void printPackingListBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (m_CurrentShippingID == null)
			{
				return;
			}

			PackingListXtraReport packingList = new PackingListXtraReport();

			packingList.locationId.Text = locationLookUpEdit.Text;
			packingList.dateXrLabel.DataBindings.Add("Text", null, "ShipMainDate", "{0:MM/dd/yyyy}");
			packingList.bolXrLabel.DataBindings.Add("Text", null, "ShipMainBOL");
			packingList.poXrLabel.DataBindings.Add("Text", null, "strPO");
			packingList.deliveryNoteNumberXrLabel.DataBindings.Add("Text", null, "DeliveryNoteNumber");
			packingList.carrierXrLabel.DataBindings.Add("Text", null, "CarrierName");
			packingList.trailerXrLabel.DataBindings.Add("Text", null, "strTrailer");
			packingList.sealXrLabel.DataBindings.Add("Text", null, "strSeal");
			packingList.returnsGroupHeader.GroupFields.Add(new GroupField("ShippingType", XRColumnSortOrder.Ascending));
			packingList.itemGroupHeader.GroupFields.Add(new GroupField("ItemCode", XRColumnSortOrder.Ascending));
			packingList.qtyXrLabel.DataBindings.Add("Text", null, "ShipDetDetQty");
			packingList.itemCodeXrLabel.DataBindings.Add("Text", null, "ItemCode");
			packingList.itemDescriptionXrLabel.DataBindings.Add("Text", null, "ItemDescription");
			packingList.palletsXrLabel.DataBindings.Add("Text", null, "sngPallets", "{0:N2}");
			//.additionalPalletsXrLabel.DataBindings.Add("Text", Nothing, "sngSkits")
			packingList.totalPalletsXrLabel.DataBindings.Add("Text", null, "sngTotalPallets", "{0:N2}");
			packingList.palletsTotalXrLabel.DataBindings.Add("Text", null, "sngTotalPallets", "{0:N2}");
			packingList.weightXrLabel.DataBindings.Add("Text", null, "Weight", "{0:N2}");
			packingList.totalWeightXrLabel.DataBindings.Add("Text", null, "TotalGrossWeight", "{0:N1}");
			packingList.lpnXrLabel.DataBindings.Add("Text", null, "FullLPNNumber");
			packingList.lotXrLabel.DataBindings.Add("Text", null, "ShipDetLot");
			packingList.expirationDateXrLabel.DataBindings.Add("Text", null, "ExpirationDate", string.Format("{{0:{0}}}", CustomersBLL.GetExpirationDateFormat(Convert.ToInt32(customerLookUpEdit.EditValue))));
			packingList.itemTotalQuantityXrLabel.DataBindings.Add("Text", null, "ShipDetDetQty");
			packingList.groupItemCodeXrLabel.DataBindings.Add("Text", null, "ItemCode");
			packingList.groupItemDescriptionXrLabel.DataBindings.Add("Text", null, "ItemDescription");
			packingList.itemTotalPalletsXrLabel.DataBindings.Add("Text", null, "sngPallets", "{0:N2}");
			packingList.itemTotalWeightXrLabel.DataBindings.Add("Text", null, "Weight", "{0:N2}");
			packingList.loadedByXrLabel.DataBindings.Add("Text", null, "LoadedBy");
			packingList.checkedByXrLabel.DataBindings.Add("Text", null, "CheckedBy");
			packingList.physicalConditionXrLabel.DataBindings.Add("Text", null, "PhysicalCondition");
			packingList.loadConditionXrLabel.DataBindings.Add("Text", null, "LoadCondition");
			packingList.startTimeXrLabel.DataBindings.Add("Text", null, "StartTime", "{0:hh:mm:ss tt}");
			packingList.finishTimeXrLabel.DataBindings.Add("Text", null, "FinishTime", "{0:hh:mm:ss tt}");
			packingList.temperatureXrLabel.DataBindings.Add("Text", null, "Temparature", "{0:N1}");
			packingList.DataSource = (new PackingListReportBLL()).GetPackingListreport(m_CurrentShippingID.Value);
			packingList.ShowPreview();

		}

		private void temparatureSpinEdit_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{

			if (Convert.ToDouble(temparatureSpinEdit.EditValue) < 55 || Convert.ToDouble(temparatureSpinEdit.EditValue) > 75)
			{
				if (MessageBox.Show("You entered an unusual tepmerature, do you want to change it?", "Unusual Temperature", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
				{
					e.Cancel = true;
					temparatureSpinEdit.SelectAll();
				}
				else
				{
					e.Cancel = false;
				}
			}

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

		private void refreshBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			m_ShippingSession.DropIdentityMap();

			shippingSearchXPView.Reload();
			shippingItemXPView.Reload();
			returnItemXPView.Reload();
			customersXPView.Reload();
			shipmentConditionXpView.Reload();
			employeeXpView.Reload();
			locationXpView.Reload();

			BindShippingSearchGrid();
			shiftLookUpEdit.Properties.DataSource = m_Shifts.GetShifts();
			carrierLookUpEdit.Properties.DataSource = m_Carriers.GetCarrierIDAndNames();
			destinationLookUpEdit.Properties.DataSource = m_Destinations.GetAddressNameAndIDS();
			BindShippingsControls(m_CurrentShippingID.Value);

			CheckPermissions();

			MessageBox.Show("Done!");

		}

		private void LinkSession()
		{

			shippingSearchXPView.Session = m_ShippingSession;
			shippingItemXPView.Session = m_ShippingSession;
			returnItemXPView.Session = m_ShippingSession;
			customersXPView.Session = m_ShippingSession;
			shipmentConditionXpView.Session = m_ShippingSession;
			employeeXpView.Session = m_ShippingSession;
			locationXpView.Session = m_ShippingSession;

		}

		private void LabelControl14_Click(object sender, EventArgs e)
		{

		}
	}
}