//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;

using DXDAL.SPGData;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraGrid.Views.Grid;

namespace SuperiorPackGroup
{
	public partial class LocationXtraForm
	{

		public LocationXtraForm()
		{
			InitializeComponent();
		}

		private Locations m_CurrentLocation;
		private string m_GridReportTitle;
		private Session m_LocationSession;

		private void addBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			m_CurrentLocation = new Locations(m_LocationSession);
			oidTextEdit.EditValue = null;
			codeTextEdit.EditValue = null;
			codeTextEdit.Enabled = true;
			nameTextEdit.EditValue = null;
			addressTextEdit.EditValue = null;
			cityTextEdit.EditValue = null;
			stateTextEdit.EditValue = null;
			zipCodeTextEdit.EditValue = null;
			phoneTextEdit.EditValue = null;
			faxTextEdit.EditValue = null;
			receivingCheckEdit.Checked = false;
			shippingCheckEdit.Checked = false;
			productionCheckEdit.Checked = false;
			warehousingCheckEdit.Checked = true;
			inventoryAvailableCheckEdit.Checked = false;
			defaultWarehouseCheckEdit.Checked = false;

			BindLocationGridControls(m_CurrentLocation.Oid);

			Utilities.MakeFormReadOnly(generalXtraTabPage, false);
			locationSearchGridControl.Enabled = false;
			CheckPermissions();

			EnableAvailableBarButtons(true);

		}

		private void cancelBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			CancelChanges();
			CheckPermissions();

			Utilities.MakeFormReadOnly(generalXtraTabPage, true);
			locationSearchGridControl.Enabled = true;

			EnableAvailableBarButtons(false);

		}

		private void deleteBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (MessageBox.Show("Are you sure you want to delete this location.", "Delete Location", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
			{
				return;
			}

			if (LocationsBLL.DeleteLocation(m_CurrentLocation.Oid, m_LocationSession) != true)
			{
				MessageBox.Show("The location was not deleted.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			else
			{
				BindLocationSearch();
			}

		}

		private void editBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (m_CurrentLocation == null)
			{
				MessageBox.Show("Please select a location to edit.");
				return;
			}

			Utilities.MakeFormReadOnly(generalXtraTabPage, false);
			locationSearchGridControl.Enabled = false;
			CheckPermissions();

			EnableAvailableBarButtons(true);

		}

		private void locationSearchGridView_Click(object sender, EventArgs e)
		{

			if (locationSearchGridView.FocusedRowHandle == -999997)
			{
				return;
			}

			if (locationSearchGridView.CalcHitInfo(locationSearchGridControl.PointToClient(Control.MousePosition)).HitTest == GridHitTest.RowCell)
			{
				BindLocationControls(Convert.ToInt32(locationSearchGridView.GetFocusedRowCellValue(colLocationID)));
			}

		}

		private void LocationXtraForm_FormClosing(object sender, FormClosingEventArgs e)
		{

			if (locationSearchGridControl.Enabled == false)
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
				m_LocationSession.PurgeDeletedObjects();
			}

		}

		private void LocationXtraForm_Load(object sender, EventArgs e)
		{

			Cursor = Cursors.WaitCursor;

			CheckPermissions();

			m_LocationSession = new Session(MyDataLayers.SPGDataLayer);
			m_LocationSession.TrackPropertiesModifications = true;
			m_LocationSession.OptimisticLockingReadBehavior = OptimisticLockingReadBehavior.MergeCollisionThrowException;

			for (int i = 0; i < components.Components.Count; i++)
			{
				if ((components.Components[i]) is XPView)
				{
					((XPView)components.Components[i]).Session = m_LocationSession;
				}
			}

			Utilities.MakeFormReadOnly(generalXtraTabPage, true);

			Cursor = Cursors.Default;

		}

		private void PrintableComponentLink_CreateReportHeaderArea(object sender, CreateAreaEventArgs e)
		{

			TextBrick brick = e.Graph.DrawString(m_GridReportTitle, Color.Black, new RectangleF(0, 5, 600, 25), BorderSide.None);
			brick.Font = new Font("Arial", 14, FontStyle.Bold);
			brick.StringFormat = new BrickStringFormat(StringAlignment.Center);

		}

		private void printGridBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			PrintableComponentLink pcl = new PrintableComponentLink(new PrintingSystem());
			PrintableComponentLink pcl2 = null;

			pcl.CreateReportHeaderArea += PrintableComponentLink_CreateReportHeaderArea;

//INSTANT C# NOTE: The following VB 'Select Case' included either a non-ordinal switch expression or non-ordinal, range-type, or non-constant 'Case' expressions and was converted to C# 'if-else' logic:
//			Select Case locationsXtraTabControl.SelectedTabPage.Name
//ORIGINAL LINE: Case inventoryXtraTabPage.Name
			if (locationsXtraTabControl.SelectedTabPage.Name == inventoryXtraTabPage.Name)
			{
					pcl.Component = inventoryGridControl;
					m_GridReportTitle = "Inventory At " + m_CurrentLocation.LocationCode;
			}
//ORIGINAL LINE: Case inventoryByLotXtraTabPage.Name
			else if (locationsXtraTabControl.SelectedTabPage.Name == inventoryByLotXtraTabPage.Name)
			{
					pcl.Component = inventoryByLotGridControl;
					m_GridReportTitle = "Inventory By LPN - Lot At " + m_CurrentLocation.LocationCode;
			}
//ORIGINAL LINE: Case transfersXtraTabPage.Name
			else if (locationsXtraTabControl.SelectedTabPage.Name == transfersXtraTabPage.Name)
			{
					pcl.Component = transfersFromGridControl;
					m_GridReportTitle = "Transfers From/To " + m_CurrentLocation.LocationCode;
					pcl2 = new PrintableComponentLink(new PrintingSystem());
					pcl2.CreateReportHeaderArea += PrintableComponentLink_CreateReportHeaderArea;
					pcl2.Component = transfersToGridControl;
			}
//ORIGINAL LINE: Case receivingReturnsXtraTabPage.Name
			else if (locationsXtraTabControl.SelectedTabPage.Name == receivingReturnsXtraTabPage.Name)
			{
					pcl.Component = receivingReturnsGridControl;
					m_GridReportTitle = "Receiving Returns At " + m_CurrentLocation.LocationCode;
			}
//ORIGINAL LINE: Case receivingXtraTabPage.Name
			else if (locationsXtraTabControl.SelectedTabPage.Name == receivingXtraTabPage.Name)
			{
					pcl.Component = receivingsGridControl;
					m_GridReportTitle = "Receivings At " + m_CurrentLocation.LocationCode;
			}
//ORIGINAL LINE: Case productionXtraTabPage.Name
			else if (locationsXtraTabControl.SelectedTabPage.Name == productionXtraTabPage.Name)
			{
					pcl.Component = productionGridControl;
					m_GridReportTitle = "Production At " + m_CurrentLocation.LocationCode;
			}
//ORIGINAL LINE: Case shippingsXtraTabPage.Name
			else if (locationsXtraTabControl.SelectedTabPage.Name == shippingsXtraTabPage.Name)
			{
					pcl.Component = shippingsGridControl;
					m_GridReportTitle = "Shippings At " + m_CurrentLocation.LocationCode;
			}
//ORIGINAL LINE: Case shippingReturnsXtraTabPage.Name
			else if (locationsXtraTabControl.SelectedTabPage.Name == shippingReturnsXtraTabPage.Name)
			{
					pcl.Component = shippingReturnsGridControl;
					m_GridReportTitle = "Shipping Returns At " + m_CurrentLocation.LocationCode;
			}
//ORIGINAL LINE: Case Else
			else
			{
			}

			pcl.CreateDocument();
			pcl.ShowPreviewDialog();

			if (pcl2 != null)
			{
				pcl2.CreateDocument();
				pcl2.ShowPreviewDialog();
			}

		}

		private void productionGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
		{

			if (e.Column == colPrdouctionExpirationDate && DateHelper.IsDate(e.Value))
			{
				e.DisplayText = Convert.ToDateTime(e.Value).ToString(productionGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, colProductionExpirationDateFormat).ToString());
			}

		}

		private void receivingsGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
		{

			if (e.Column == colReceivingItemExpirationDate && DateHelper.IsDate(e.Value))
			{
				e.DisplayText = Convert.ToDateTime(e.Value).ToString(receivingsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, colReceivingExpirationDateFormat).ToString());
			}

		}

		private void receivingReturnsGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
		{

			if (e.Column == colReceivingReturnItemExpirationDate && DateHelper.IsDate(e.Value))
			{
				e.DisplayText = Convert.ToDateTime(e.Value).ToString(receivingReturnsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, colReceivingReturnExpirationDateFormat).ToString());
			}

		}

		private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			if (SaveChanges())
			{
				CheckPermissions();

				Utilities.MakeFormReadOnly(generalXtraTabPage, true);
				locationSearchGridControl.Enabled = true;

				EnableAvailableBarButtons(false);
			}

		}

		private void shippingsGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
		{

			if (e.Column == colShippingExpirationDate && DateHelper.IsDate(e.Value))
			{
				e.DisplayText = Convert.ToDateTime(e.Value).ToString(shippingsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, colShippingExpirationDateFormat).ToString());
			}

		}

		private void shippingReturnsGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
		{

			if (e.Column == colShippingReturnExpirationDate && DateHelper.IsDate(e.Value))
			{
				e.DisplayText = Convert.ToDateTime(e.Value).ToString(shippingReturnsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, colShippingReturnExpirationDateFormat).ToString());
			}

		}

		private void transfersFromGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
		{

			if (e.Column == colExpirationDate && DateHelper.IsDate(e.Value))
			{
				e.DisplayText = Convert.ToDateTime(e.Value).ToString(transfersFromGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, colTransferFromExpirationDateFormat).ToString());
			}

		}

		private void transfersToGridView_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
		{

			if (e.Column == colTransferToExpirationDate && DateHelper.IsDate(e.Value))
			{
				e.DisplayText = Convert.ToDateTime(e.Value).ToString(transfersToGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, transferToExpirationDateFormatGridColumn).ToString());
			}

		}

		private void BindLocationControls(int locationID)
		{

			m_LocationSession.DropIdentityMap();

			Locations location = (Locations)m_LocationSession.GetObjectByKey<Locations>(locationID, true);
			m_CurrentLocation = location;
			oidTextEdit.EditValue = m_CurrentLocation.Oid;
			codeTextEdit.EditValue = m_CurrentLocation.LocationCode;
			codeTextEdit.Enabled = false;
			nameTextEdit.EditValue = m_CurrentLocation.LocationName;
			addressTextEdit.EditValue = m_CurrentLocation.LocationAddress;
			cityTextEdit.EditValue = m_CurrentLocation.LocationCity;
			stateTextEdit.EditValue = m_CurrentLocation.LocationState;
			zipCodeTextEdit.EditValue = m_CurrentLocation.LocationZipCode;
			phoneTextEdit.EditValue = m_CurrentLocation.LocationPhone;
			faxTextEdit.EditValue = m_CurrentLocation.LocationFax;
			receivingCheckEdit.EditValue = m_CurrentLocation.CanReceive;
			shippingCheckEdit.EditValue = m_CurrentLocation.CanShip;
			productionCheckEdit.EditValue = m_CurrentLocation.CanProduce;
			warehousingCheckEdit.EditValue = m_CurrentLocation.CanWarehouse;
			inventoryAvailableCheckEdit.EditValue = m_CurrentLocation.InventoryAvailable;
			defaultWarehouseCheckEdit.EditValue = LocationsBLL.IsDefaultLocation(m_CurrentLocation);

			BindLocationGridControls(locationID);

			transfersToGroupControl.Text = "Location Transfers To " + m_CurrentLocation.LocationCode;
			transfersFromGroupControl.Text = "Location Transfers From " + m_CurrentLocation.LocationCode;

		}

		private void BindLocationGridControls(int locationID)
		{

			if (warehousingCheckEdit.Checked)
			{
				locationInventoryXpView.Criteria = new BinaryOperator(LocationInventory.Fields.Location.Oid, locationID, BinaryOperatorType.Equal);
				locationInventoryByLotXpView.Criteria = new GroupOperator(GroupOperatorType.And, new BinaryOperator(LocationInventoryByLot.Fields.Location.Oid, locationID, BinaryOperatorType.Equal), new BinaryOperator(LocationInventoryByLot.Fields.QuantityOnHand, 0, BinaryOperatorType.NotEqual));
				transfersFromXpView.Criteria = new GroupOperator(GroupOperatorType.And, new BinaryOperator(LocationTransferDetails.Fields.Transfer.FromLocation.Oid.PropertyName, locationID, BinaryOperatorType.Equal), new BinaryOperator(LocationTransferDetails.Fields.Transfer.TransferDate.PropertyName, DateTime.Today.AddYears(-1), BinaryOperatorType.GreaterOrEqual));
				transfersToXpView.Criteria = new GroupOperator(GroupOperatorType.And, new BinaryOperator(LocationTransferDetails.Fields.Transfer.ToLocation.Oid.PropertyName, locationID, BinaryOperatorType.Equal), new BinaryOperator(LocationTransferDetails.Fields.Transfer.TransferDate.PropertyName, DateTime.Today.AddYears(-1), BinaryOperatorType.GreaterOrEqual));
				locationInventoryXpView.Reload();
				locationInventoryByLotXpView.Reload();
				transfersFromXpView.Reload();
				transfersToXpView.Reload();
				inventoryXtraTabPage.PageVisible = true;
				inventoryXtraTabPage.PageEnabled = true;
				transfersXtraTabPage.PageVisible = true;
				transfersXtraTabPage.PageEnabled = true;
			}
			else
			{
				locationInventoryXpView.Criteria = new BinaryOperator(LocationInventory.Fields.Location.Oid.PropertyName, 0, BinaryOperatorType.Equal);
				locationInventoryByLotXpView.Criteria = new BinaryOperator(LocationInventoryByLot.Fields.Location.Oid.PropertyName, 0, BinaryOperatorType.Equal);
				transfersFromXpView.Criteria = new BinaryOperator(LocationTransferDetails.Fields.Transfer.FromLocation.Oid.PropertyName, 0, BinaryOperatorType.Equal);
				transfersToXpView.Criteria = new BinaryOperator(LocationTransferDetails.Fields.Transfer.ToLocation.Oid.PropertyName, 0, BinaryOperatorType.Equal);
				locationInventoryXpView.Reload();
				locationInventoryByLotXpView.Reload();
				transfersFromXpView.Reload();
				transfersToXpView.Reload();
				inventoryXtraTabPage.PageVisible = false;
				inventoryXtraTabPage.PageEnabled = false;
				transfersXtraTabPage.PageVisible = false;
				transfersXtraTabPage.PageEnabled = false;
			}

			if (receivingCheckEdit.Checked)
			{
				receivingsXpView.Criteria = new GroupOperator(GroupOperatorType.And, new BinaryOperator(ReceivingDetail.Fields.ReceivMainID.ReceivingLocation.Oid, locationID, BinaryOperatorType.Equal), new BinaryOperator(ReceivingDetail.Fields.ReceivMainID.ReceivDate.PropertyName, DateTime.Today.AddYears(-1), BinaryOperatorType.GreaterOrEqual));
				receivingReturnXpView.Criteria = new GroupOperator(GroupOperatorType.And, new BinaryOperator(ReceivedReturns.Fields.ReceiveMainID.ReceivingLocation.Oid, locationID, BinaryOperatorType.Equal), new BinaryOperator(ReceivedReturns.Fields.ReceiveMainID.ReceivDate.PropertyName, DateTime.Today.AddYears(-1), BinaryOperatorType.GreaterOrEqual));
				receivingsXpView.Reload();
				//receivingReturnXpView.Reload()
				receivingXtraTabPage.PageEnabled = true;
				receivingXtraTabPage.PageVisible = true;
				//receivingReturnsXtraTabPage.PageEnabled = True
				//receivingReturnsXtraTabPage.PageVisible = True
			}
			else
			{
				receivingsXpView.Criteria = new BinaryOperator(ReceivingDetail.Fields.ReceivMainID.ReceivingLocation.Oid.PropertyName, 0, BinaryOperatorType.Equal);
				receivingReturnXpView.Criteria = new BinaryOperator(ReceivedReturns.Fields.ReceiveMainID.ReceivingLocation.Oid.PropertyName, 0, BinaryOperatorType.Equal);
				receivingsXpView.Reload();
				//receivingReturnXpView.Reload()
				receivingXtraTabPage.PageEnabled = false;
				receivingXtraTabPage.PageVisible = false;
				//receivingReturnsXtraTabPage.PageEnabled = False
				//receivingReturnsXtraTabPage.PageVisible = False
			}

			if (productionCheckEdit.Checked)
			{
				productionXpView.Criteria = new GroupOperator(GroupOperatorType.And, new BinaryOperator(Inventory.Fields.ProductionLocation.Oid, locationID, BinaryOperatorType.Equal), new BinaryOperator(Inventory.Fields.InventoryDate.PropertyName, DateTime.Today.AddYears(-1), BinaryOperatorType.GreaterOrEqual));
				productionXpView.Reload();
				productionXtraTabPage.PageEnabled = true;
				productionXtraTabPage.PageVisible = true;
			}
			else
			{
				productionXpView.Criteria = new BinaryOperator(Inventory.Fields.ProductionLocation.Oid.PropertyName, 0, BinaryOperatorType.Equal);
				productionXpView.Reload();
				productionXtraTabPage.PageEnabled = false;
				productionXtraTabPage.PageVisible = false;
			}

			if (shippingCheckEdit.Checked)
			{
				shippingsXpView.Criteria = new GroupOperator(GroupOperatorType.And, new BinaryOperator(ShipDet.Fields.ShipDetMainID.ShippingLocation.Oid, locationID, BinaryOperatorType.Equal), new BinaryOperator(ShipDet.Fields.ShipDetMainID.ShipMainDate.PropertyName, DateTime.Today.AddYears(-1), BinaryOperatorType.GreaterOrEqual));
				shippingReturnsXpView.Criteria = new GroupOperator(GroupOperatorType.And, new BinaryOperator(ShippedReturns.Fields.ShipMainID.ShippingLocation.Oid, locationID, BinaryOperatorType.Equal), new BinaryOperator(ShippedReturns.Fields.ShipMainID.ShipMainDate.PropertyName, DateTime.Today.AddYears(-1), BinaryOperatorType.GreaterOrEqual));
				shippingsXpView.Reload();
				//shippingReturnsXpView.Reload()
				shippingsXtraTabPage.PageEnabled = true;
				shippingsXtraTabPage.PageVisible = true;
				//shippingReturnsXtraTabPage.PageEnabled = True
				//shippingReturnsXtraTabPage.PageVisible = True
			}
			else
			{
				shippingsXpView.Criteria = new BinaryOperator(ShipDet.Fields.ShipDetMainID.ShippingLocation.Oid.PropertyName, 0, BinaryOperatorType.Equal);
				shippingReturnsXpView.Criteria = new BinaryOperator(ShippedReturns.Fields.ShipMainID.ShippingLocation.Oid.PropertyName, 0, BinaryOperatorType.Equal);
				shippingsXpView.Reload();
				shippingReturnsXpView.Reload();
				shippingsXtraTabPage.PageEnabled = false;
				shippingsXtraTabPage.PageVisible = false;
				shippingReturnsXtraTabPage.PageEnabled = false;
				shippingReturnsXtraTabPage.PageVisible = false;
			}

		}

		private void BindLocationSearch()
		{

			locationSearchXpView.Reload();

		}

		private void CancelChanges()
		{

			if (m_CurrentLocation.Oid != -1)
			{
				BindLocationControls(m_CurrentLocation.Oid);
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
						break;
					case "ADD":
					case "Add":
						addBarButtonItem.Enabled = true;
						editBarButtonItem.Enabled = true;
						deleteBarButtonItem.Enabled = false;
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
						break;
					case "EDIT":
					case "Edit":
						addBarButtonItem.Enabled = false;
						editBarButtonItem.Enabled = true;
						deleteBarButtonItem.Enabled = false;
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

		private void EnableAvailableBarButtons(bool editingMode)
		{

			if (editingMode)
			{
				cancelBarButtonItem.Enabled = true;
				saveBarButtonItem.Enabled = true;
				editBarButtonItem.Enabled = false;
				addBarButtonItem.Enabled = false;
				deleteBarButtonItem.Enabled = false;
			}
			else
			{
				cancelBarButtonItem.Enabled = false;
				saveBarButtonItem.Enabled = false;
				codeTextEdit.Enabled = false;
			}

		}

		private bool SaveChanges()
		{

			int selectedId = 0;

			if (m_CurrentLocation.Oid != -1)
			{
				selectedId = locationSearchGridView.FocusedRowHandle;
			}

			if (LocationsBLL.ValidateRecord(codeTextEdit.Text))
			{
				m_CurrentLocation.LocationCode = codeTextEdit.Text;
				m_CurrentLocation.LocationName = nameTextEdit.Text;
				m_CurrentLocation.LocationAddress = addressTextEdit.Text;
				m_CurrentLocation.LocationCity = cityTextEdit.Text;
				m_CurrentLocation.LocationState = stateTextEdit.Text;
				m_CurrentLocation.LocationZipCode = zipCodeTextEdit.Text;
				m_CurrentLocation.LocationPhone = phoneTextEdit.Text;
				m_CurrentLocation.LocationFax = faxTextEdit.Text;
				m_CurrentLocation.CanReceive = receivingCheckEdit.Checked;
				m_CurrentLocation.CanShip = shippingCheckEdit.Checked;
				m_CurrentLocation.CanProduce = productionCheckEdit.Checked;
				m_CurrentLocation.CanWarehouse = warehousingCheckEdit.Checked;
				m_CurrentLocation.InventoryAvailable = inventoryAvailableCheckEdit.Checked;
			}
			else
			{
				MessageBox.Show("You must provide a location code before saving the record.");
				return false;
			}

			try
			{
				m_CurrentLocation.Save();
			}
			catch (ApplicationException ex)
			{
				MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			BindLocationSearch();
			BindLocationControls(m_CurrentLocation.Oid);
			locationSearchGridView.FocusedRowHandle = selectedId;
			return true;

		}

		private void PrintLpnSimpleButton_Click(object sender, EventArgs e)
		{
			int digits = CustomersBLL.GetCustomer(7, m_LocationSession).LastLPNNumber.ToString().Length;
			XPView lpnXPview = null;
			CriteriaOperatorCollection critaria = new CriteriaOperatorCollection();
			lpnXPview = new XPView(m_LocationSession, typeof(LocationInventoryByLot));


			if (inventoryByLotGridView.GroupCount > 0)
			{
				int i = -1;
				while (inventoryByLotGridView.IsValidRowHandle(i))
				{
					if (inventoryByLotGridView.GetChildRowHandle(i, 0) > -1)
					{
//INSTANT C# NOTE: The ending condition of VB 'For' loops is tested only on entry to the loop. Instant C# has created a temporary variable in order to use the initial value of inventoryByLotGridView.GetChildRowCount(i) + inventoryByLotGridView.GetChildRowHandle(i, 0) for every iteration:
						int tempVar = inventoryByLotGridView.GetChildRowCount(i) + inventoryByLotGridView.GetChildRowHandle(i, 0);
						for (int ci = inventoryByLotGridView.GetChildRowHandle(i, 0); ci < tempVar; ci++)
						{
							if (inventoryByLotGridView.IsRowVisible(ci) == RowVisibleState.Visible)
							{
								int? lpn = Utilities.ChangeType<int?>(inventoryByLotGridView.GetRowCellValue(ci, colLPNNumber));
							string lot = inventoryByLotGridView.GetRowCellValue(ci, colLot).ToString();
								if (lpn.HasValue && lot.Length > 0)
								{
									critaria.Add(new GroupOperator(GroupOperatorType.And, new BinaryOperator("LPNNumber", lpn.Value, BinaryOperatorType.Equal), new BinaryOperator("LocationInventoryLot", lot, BinaryOperatorType.Equal)));
								}
							}
						}
					}
					i -= 1;
				}
			}
			else
			{
				for (int ci = 0; ci < inventoryByLotGridView.RowCount; ci++)
				{
					if (inventoryByLotGridView.IsRowVisible(ci) == RowVisibleState.Visible)
					{
						int? lpn = Utilities.ChangeType<int?>(inventoryByLotGridView.GetRowCellValue(ci, colLPNNumber));
						string lot = inventoryByLotGridView.GetRowCellValue(ci, colLot).ToString();
						if (lpn.HasValue && lot.Length > 0)
						{
							critaria.Add(new GroupOperator(GroupOperatorType.And, new BinaryOperator("LPNNumber", lpn.Value, BinaryOperatorType.Equal), new BinaryOperator("LocationInventoryLot", lot, BinaryOperatorType.Equal)));
						}
					}
				}
			}

			lpnXPview.Criteria = CriteriaOperator.Or(critaria);

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
			labels.itemCodeXrLabel.DataBindings.Add("Text", lpnXPview, "Item");
			labels.itemDescXrLabel.DataBindings.Add("Text", lpnXPview, "ItemDesc");
			labels.AllergensXrLabel.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "Iif(Len(Trim([Allergens]))>0,'Allergens: ' + [Allergens],'Allergens: None')"));
			labels.exprXrLabel.DataBindings.Add("Text", lpnXPview, "Expr", "{0:MM/dd/yyyy}");
			labels.qtyXrLabel.DataBindings.Add("Text", lpnXPview, "Qty");
			labels.lotXrLabel.DataBindings.Add("Text", lpnXPview, "Lot");
			labels.LPNXrBarCode.DataBindings.Add("Text", lpnXPview, "LPN", "SPG{0:D" + digits + "}");
			labels.SumQtyXrLabel.ExpressionBindings.Add(new ExpressionBinding("BeforePrint", "Text", "sumSum([Qty])"));
			labels.ReprintXrLabel.Visible = true;
			labels.CreateDocument();
			labels.ShowPreviewDialog();
		}
	}
}