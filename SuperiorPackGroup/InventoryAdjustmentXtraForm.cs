//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using DevExpress.XtraEditors;
using DevExpress.Data.Filtering;
using DXDAL.SPGData;
using DevExpress.Xpo;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraReports.UI;

namespace SuperiorPackGroup
{
	public partial class InventoryAdjustmentXtraForm
	{

		public InventoryAdjustmentXtraForm()
		{
			InitializeComponent();
		}

		private bool m_AllowAdd = false;
		private bool m_newLpn = false;
		private ItemsBLL m_Items;
		private CustomersBLL m_Customers;
		private InventoryAdjustmentBLL m_Adjustment;

		private void itemLookUpEdit_Validated(object sender, EventArgs e)
		{

			if (itemLookUpEdit.EditValue == null)
			{
				return;
			}

			descriptionMemoEdit.Text = ItemsBLL.GetDescriptionByItemID((int?)itemLookUpEdit.EditValue);
			customerLookUpEdit.EditValue = m_Items.GetCustomerIDByItemID(Convert.ToInt32(itemLookUpEdit.EditValue));

			if (locationLookUpEdit.EditValue != null)
			{
				originalQtyTextEdit.EditValue = ItemsBLL.GetQtyOnHandByID(Session.DefaultSession, Convert.ToInt32(itemLookUpEdit.EditValue), Convert.ToInt32(locationLookUpEdit.EditValue));
			}

			FilterLpns();

			lpnLookUpEdit.EditValue = null;
			originalLotLookUpEdit.EditValue = null;

            UpdateQtyPerPallet();
		}

		private void locationLookupEdit_Validated(object sender, EventArgs e)
		{

			if (itemLookUpEdit.EditValue != null)
			{
				originalQtyTextEdit.EditValue = ItemsBLL.GetQtyOnHandByID(Session.DefaultSession, Convert.ToInt32(itemLookUpEdit.EditValue), Convert.ToInt32(locationLookUpEdit.EditValue));
			}

		}
		private void lpnLookUpEdit_Validated(object sender, EventArgs e)
		{
			originalQtyTextEdit.Text = "";
			originalLotLookUpEdit.EditValue = null;
			FilterLots();
			if (LotXpView.Count == 1)
			{
				originalLotLookUpEdit.EditValue = LotXpView[0]["Lot"];
				originalQtyTextEdit.Text = (originalLotLookUpEdit.GetColumnValue("Qty") ?? 0).ToString();
			}
		}
		private void originalLotLookUpEdit_Validated(object sender, EventArgs e)
		{

			originalQtyTextEdit.Text = (originalLotLookUpEdit.GetColumnValue("Qty") ?? 0).ToString();

		}
		private void originalLotLookUpEdit_GetNotInListValue(object sender, GetNotInListValueEventArgs e)
		{

			if (MessageBox.Show("") == DialogResult.Yes)
			{
				if (e.FieldName == "Qty")
				{
					e.Value = 0;
				}
			}
			else
			{
			}

		}
		private void editSimpleButton_Click(object sender, EventArgs e)
		{

			//enters the rowhandle for the editing record in the editbutton tag property
			if (adjustmentGridView.SelectedRowsCount == 1)
			{
				int rowHandle = adjustmentGridView.GetSelectedRows()[0];
				editSimpleButton.Tag = rowHandle;

				//Dim inventoryRecord As SPG.InventoryRow = m_Inventory.GetInventoryByID(.GetRowCellValue(rowHandle, Me.idGridColumn)).Rows(0)
				saveSimpleButton.Tag = adjustmentGridView.GetRowCellValue(rowHandle, idGridColumn);
				adjustmentDateEdit.DateTime = Convert.ToDateTime(adjustmentGridView.GetRowCellValue(rowHandle, dateGridColumn));
				itemLookUpEdit.EditValue = adjustmentGridView.GetRowCellValue(rowHandle, itemIDGridColumn);
				if (Convert.IsDBNull(adjustmentGridView.GetRowCellValue(rowHandle, descriptionGridColumn)) == false && adjustmentGridView.GetRowCellValue(rowHandle, descriptionGridColumn) == null == false)
				{
					descriptionMemoEdit.Text = adjustmentGridView.GetRowCellValue(rowHandle, descriptionGridColumn).ToString();
				}
				lpnLookUpEdit.EditValue = adjustmentGridView.GetRowCellValue(rowHandle, colLPN);
				newQtyTextEdit.EditValue = adjustmentGridView.GetRowCellValue(rowHandle, newQtyGridColumn);
				originalQtyTextEdit.EditValue = adjustmentGridView.GetRowCellValue(rowHandle, originalQuantityGridColumn);
				newQtyTextEdit.EditValue = adjustmentGridView.GetRowCellValue(rowHandle, newQtyGridColumn);
				originalLotLookUpEdit.EditValue = adjustmentGridView.GetRowCellValue(rowHandle, colOriginalLot);
				newLotTextEdit.EditValue = adjustmentGridView.GetRowCellValue(rowHandle, colNewLot);
				customerLookUpEdit.EditValue = adjustmentGridView.GetRowCellValue(rowHandle, customerIDGridColumn);
				reasonMemoExEdit.EditValue = adjustmentGridView.GetRowCellValue(rowHandle, reasonGridColumn);
				locationLookUpEdit.EditValue = adjustmentGridView.GetRowCellValue(rowHandle, locationGridColumn);
				FilterLpns();
				FilterLots();
			}

		}

		private void cancelSimpleButton_Click(object sender, EventArgs e)
		{

			if (m_newLpn)
			{
				LocationInventoryByLot Lpntodelete = Session.DefaultSession.FindObject<LocationInventoryByLot>(new GroupOperator(GroupOperatorType.And, new BinaryOperator("LPNNumber", (object)Utilities.ChangeType<int?>(lpnLookUpEdit.EditValue), BinaryOperatorType.Equal), new BinaryOperator(LocationInventoryByLot.Fields.QuantityOnHand.PropertyName, 0, BinaryOperatorType.Equal), new BinaryOperator("LocationInventoryLot", "", BinaryOperatorType.Equal)));
				if (Lpntodelete != null)
				{
					Lpntodelete.Delete();
					Session.DefaultSession.PurgeDeletedObjects();
				}
			}

			PrepareNewRecord();

		}

		private void filterSimpleButton_Click(object sender, EventArgs e)
		{

			FillAdjustmentView();

		}

		private void customerLookUpEdit_Validated(object sender, EventArgs e)
		{

			if ((customerLookUpEdit.EditValue == null ? null : Convert.ToString(customerLookUpEdit.EditValue)) == customerLookUpEdit.Properties.NullText || string.IsNullOrEmpty((customerLookUpEdit.EditValue == null ? null : Convert.ToString(customerLookUpEdit.EditValue))))
			{
				itemsXPView.Filter = null;
			}
			else
			{
				itemsXPView.Filter = new BinaryOperator("CustomerID", (customerLookUpEdit.EditValue == null ? null : Convert.ToString(customerLookUpEdit.EditValue)), BinaryOperatorType.Equal);
			}

		}

		private void customerFilterLookUpEdit_Validated(object sender, EventArgs e)
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

		private void clearSimpleButton_Click(object sender, EventArgs e)
		{

			SetDefaultViewFilter();
			fromFilterDateEdit.EditValue = null;
			toFilterDateEdit.EditValue = null;
			FillAdjustmentView();

		}

		private void saveSimpleButton_Click(object sender, EventArgs e)
		{

			if (ValidateRecord())
			{
				if (SaveRecord((int?)saveSimpleButton.Tag))
				{
					PrepareNewRecord();
				}
			}

		}

		private void InventoryAdjustmentXtraForm_FormClosing(object sender, FormClosingEventArgs e)
		{

			if (editSimpleButton.Tag != null)
			{
				MessageBox.Show("You must first save or cancel the changes");
				e.Cancel = true;
			}

		}

		private void InventoryAdjustmentXtraForm_Load(object sender, EventArgs e)
		{

			Cursor = Cursors.WaitCursor;

			CheckPermissions();

			//Dim fullLPN As String


			//fullLPN = CustomersBLL.GetLPNPrefix(7) & Strings.Right("0000000000" & "", Len(CustomersBLL.GetCustomer(7, Session.DefaultSession).LastLPNNumber.ToString))

			//lpnLookUpEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			//lpnLookUpEdit.Properties.DisplayFormat.FormatString = CustomersBLL.GetLPNPrefix(7) & "{0:D" & Len(CustomersBLL.GetCustomer(7, Session.DefaultSession).LastLPNNumber.ToString) & "}"
			//lpnXpView.Properties.Add(New ViewProperty("LPN", SortDirection.None, "'" & CustomersBLL.GetLPNPrefix(7) & "' + RIGHT(CONCAT('0000000000',LPNNumber)," & Len(CustomersBLL.GetCustomer(7, Session.DefaultSession).LastLPNNumber.ToString) & ")", True, True))
			m_Items = new ItemsBLL();
			m_Customers = new CustomersBLL();
			m_Adjustment = new InventoryAdjustmentBLL();

			PrepareNewRecord();

			SetDefaultViewFilter();
			FillAdjustmentView();

			FilterLpns();

			Cursor = Cursors.Default;

		}

		public void PrepareNewRecord()
		{

			saveSimpleButton.Tag = null;
			editSimpleButton.Tag = null;
			descriptionMemoEdit.Text = null;
			if (DateTime.Now.TimeOfDay < new TimeSpan(9, 0, 0))
			{
				adjustmentDateEdit.DateTime = DateTime.Today.AddDays(-1);
			}
			else
			{
				adjustmentDateEdit.DateTime = DateTime.Today;
			}
			itemLookUpEdit.EditValue = null;
			originalQtyTextEdit.Text = null;
			newQtyTextEdit.Text = null;
			customerLookUpEdit.EditValue = null;
			reasonMemoExEdit.EditValue = null;
			locationLookUpEdit.EditValue = UsersBLL.GetUsersLocalLocation(Session.DefaultSession, Properties.Settings.Default.UserName).Oid;
			lpnLookUpEdit.Text = "";
			originalLotLookUpEdit.Text = "";
			newLotTextEdit.Text = "";
			m_newLpn = false;

		}

		public void SetDefaultViewFilter()
		{

			//Set the from filter to the sunday of this week
			fromFilterDateEdit.DateTime = DateTime.Today.AddDays((Microsoft.VisualBasic.DateAndTime.Weekday(DateTime.Today) - 1) * -1);
			toFilterDateEdit.DateTime = DateTime.Today;
			customerFilterLookUpEdit.EditValue = null;
			itemFilterLookUpEdit.EditValue = null;

		}

		public void FillAdjustmentView()
		{


			CriteriaOperatorCollection inventoryViewCriteria = new CriteriaOperatorCollection();

			if (((DateTime?)fromFilterDateEdit.EditValue).HasValue)
			{
				inventoryViewCriteria.Add(new BinaryOperator(InventoryAdjustment.Fields.AdjustmentDate.PropertyName, Convert.ToDateTime(fromFilterDateEdit.EditValue), BinaryOperatorType.GreaterOrEqual));
			}
			if (((DateTime?)toFilterDateEdit.EditValue).HasValue)
			{
				inventoryViewCriteria.Add(new BinaryOperator(InventoryAdjustment.Fields.AdjustmentDate.PropertyName, Convert.ToDateTime(toFilterDateEdit.EditValue), BinaryOperatorType.LessOrEqual));
			}
			if (((int?)customerFilterLookUpEdit.EditValue).HasValue)
			{
				inventoryViewCriteria.Add(new BinaryOperator(InventoryAdjustment.Fields.AdjustmentItem.ItemCustomerID.CustomerID.PropertyName, Convert.ToInt32(customerFilterLookUpEdit.EditValue), BinaryOperatorType.Equal));
			}
			if (((int?)itemFilterLookUpEdit.EditValue).HasValue)
			{
				inventoryViewCriteria.Add(new BinaryOperator(InventoryAdjustment.Fields.AdjustmentItem.ItemID.PropertyName, Convert.ToInt32(itemFilterLookUpEdit.EditValue), BinaryOperatorType.Equal));
			}

			inventoryXPView.Criteria = CriteriaOperator.And(inventoryViewCriteria);


			//Me.adjustmentGridControl.DataSource = m_Adjustment.GetAdjustmentView(CType(Me.fromFilterDateEdit.EditValue, Date?), CType(Me.toFilterDateEdit.EditValue, Date?), _
			//                                                                     CType(Me.customerFilterLookUpEdit.EditValue, Integer?), CType(Me.itemFilterLookUpEdit.EditValue, Integer?))

		}

		public bool ValidateRecord()
		{

			if (itemLookUpEdit.EditValue == null || (itemLookUpEdit.EditValue == null ? null : Convert.ToString(itemLookUpEdit.EditValue)) == itemLookUpEdit.Properties.NullText)
			{
				MessageBox.Show("You must select a Item Code.");
				itemLookUpEdit.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(newQtyTextEdit.Text) && string.IsNullOrEmpty(newLotTextEdit.Text))
			{
				MessageBox.Show("You must enter a new quantity or lot.");
				newQtyTextEdit.Focus();
				return false;
			}
			else if (!string.IsNullOrEmpty(newQtyTextEdit.Text) && !string.IsNullOrEmpty(newLotTextEdit.Text))
			{
				if (saveSimpleButton.Tag != null && newQtyTextEdit.Text == "0")
				{
					newQtyTextEdit.Text = null;
				}
				else
				{
					MessageBox.Show("You cant update quantity and lot at once.");
					newQtyTextEdit.Focus();
					return false;
				}
			}

			if (originalLotLookUpEdit.EditValue == null && lpnLookUpEdit.EditValue != null)
			{
				MessageBox.Show("You must select a Lot.");
				originalLotLookUpEdit.Focus();
				return false;
			}

			if (!string.IsNullOrEmpty(newLotTextEdit.Text) && LotCodeValidator.ValidateByItemID(Convert.ToInt32(itemLookUpEdit.GetColumnValue("ItemID")), newLotTextEdit.Text, true) == false)
			{
				MessageBox.Show("Lot code invalid.");
				newLotTextEdit.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(Convert.ToString(reasonMemoExEdit.EditValue)) == true)
			{
				if (MessageBox.Show(string.Format("The reason field is empty. {0} Do you want to save the record.", Environment.NewLine), "Save Adjustment", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
				{
					return false;
				}
				else
				{
				}
			}

			if (locationLookUpEdit.EditValue == null || (locationLookUpEdit.EditValue == null ? null : Convert.ToString(locationLookUpEdit.EditValue)) == locationLookUpEdit.Properties.NullText)
			{
				MessageBox.Show("You must select a Location.");
				locationLookUpEdit.Focus();
				return false;
			}

			if (saveSimpleButton.Tag == null)
			{
				if (m_AllowAdd == true)
				{
					saveSimpleButton.Tag = InventoryAdjustmentBLL.GetNewInventoryAdjustmentID();
				}
				else
				{
					return false;
				}
			}

			return true;

		}

		public bool SaveRecord(int? id,bool IsnewInventory = true)
		{

			if (saveSimpleButton.Tag == null)
			{
				if (m_AllowAdd == true)
				{
					saveSimpleButton.Tag = InventoryAdjustmentBLL.GetNewInventoryAdjustmentID();
				}
				else
				{
					return false;
				}
			}

			if (m_Adjustment.UpdateInventoryAdjustment(Convert.ToInt32(saveSimpleButton.Tag), adjustmentDateEdit.DateTime, Convert.ToInt32(customerLookUpEdit.EditValue), Convert.ToInt32(itemLookUpEdit.EditValue), Convert.ToSingle(originalQtyTextEdit.EditValue), Convert.ToSingle(newQtyTextEdit.EditValue), Convert.ToString(reasonMemoExEdit.EditValue), Convert.ToInt32(locationLookUpEdit.EditValue), Convert.ToString(originalLotLookUpEdit.EditValue), newLotTextEdit.Text, Utilities.ChangeType<int?>(lpnLookUpEdit.EditValue), Utilities.ChangeType<DateTime?>(originalLotLookUpEdit.GetColumnValue("Expr")),IsnewInventory) != true)
			{
				MessageBox.Show("The adjustment record was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else if (m_newLpn && !string.IsNullOrEmpty(originalLotLookUpEdit.Text))
			{
				LocationInventoryByLot Lpntodelete = Session.DefaultSession.FindObject<LocationInventoryByLot>(new GroupOperator(GroupOperatorType.And, new BinaryOperator(LocationInventoryByLot.Fields.LPNNumber.PropertyName, (object)Utilities.ChangeType<int?>(lpnLookUpEdit.EditValue), BinaryOperatorType.Equal), new BinaryOperator(LocationInventoryByLot.Fields.QuantityOnHand.PropertyName, 0, BinaryOperatorType.Equal), new BinaryOperator("LocationInventoryLot", "", BinaryOperatorType.Equal)));
				if (Lpntodelete != null)
				{
					Lpntodelete.Delete();
					Session.DefaultSession.PurgeDeletedObjects();
				}
			}

			printLpn();

			inventoryXPView.Reload();

			return true;

		}

		private void deleteRepositoryItemButtonEdit_Click(object sender, EventArgs e)
		{

			if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				return;
			}

			if (InventoryAdjustmentBLL.DeleteInventoryAdjustment(Convert.ToInt32(adjustmentGridView.GetFocusedRowCellValue(idGridColumn))) != true)
			{
				MessageBox.Show("The adjustment record was not deleted succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			inventoryXPView.Reload();

		}

		private void adjustmentGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
		{

			if (!Convert.IsDBNull(adjustmentGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, itemGridColumn)))
			{
				if (e.Column.Name == adjustmentGridColumn.Name)
				{
					if ((adjustmentGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, originalQuantityGridColumn) == null) || (adjustmentGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, newQtyGridColumn) == null))
					{
						return;
					}
					e.Value = Convert.ToInt32(adjustmentGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, newQtyGridColumn)) - Convert.ToInt32(adjustmentGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, originalQuantityGridColumn));
				}
			}

		}

		private void adjustmentGridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
		{

			if (e.Column.Name == adjustmentGridColumn.Name)
			{
				if ((adjustmentGridView.GetRowCellValue(e.RowHandle, adjustmentGridColumn) == null) || Convert.ToInt32(adjustmentGridView.GetRowCellValue(e.RowHandle, adjustmentGridColumn)) >= 0)
				{
					e.Appearance.ForeColor = Color.Black;
				}
				else
				{
					e.Appearance.ForeColor = Color.Red;
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
						break;
					case "ADD":
					case "Add":
						m_AllowAdd = true;
						editSimpleButton.Enabled = true;
						deleteGridColumn.Visible = false;
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
						break;
					case "EDIT":
					case "Edit":
						editSimpleButton.Enabled = true;
						deleteGridColumn.Visible = false;
						break;
					case "VIEW ASSIGNED":
						editSimpleButton.Enabled = false;
						deleteGridColumn.Visible = false;
						FilterAssignedCustomers();
						break;
					case "EDIT ASSIGNED":
						editSimpleButton.Enabled = true;
						deleteGridColumn.Visible = false;
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

			inventoryXPView.Filter = new InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session));
			customersXPView.Criteria = CriteriaOperator.And(new BinaryOperator(Customers.Fields.Inactive.PropertyName, false), new InOperator(Customers.Fields.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(XpoDefault.Session)));
			customersFilterXPView.Criteria = CriteriaOperator.And(new BinaryOperator(Customers.Fields.Inactive.PropertyName, false), new InOperator(Customers.Fields.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(XpoDefault.Session)));
			itemsFilterXPView.Criteria = new InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(XpoDefault.Session));
			itemsXPView.Criteria = CriteriaOperator.And(new BinaryOperator(Items.Fields.Inactive.PropertyName, false), new InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(XpoDefault.Session)));

		}

		private void FilterLpns()
		{

			CriteriaOperatorCollection lpnViewCriteria = new CriteriaOperatorCollection();

			if (((int?)itemLookUpEdit.EditValue).HasValue && ((int?)locationLookUpEdit.EditValue).HasValue)
			{
				lpnViewCriteria.Add(new BinaryOperator(LocationInventoryByLot.Fields.LocationInventoryItem.ItemID.PropertyName, Convert.ToInt32(itemLookUpEdit.EditValue), BinaryOperatorType.Equal));
				lpnViewCriteria.Add(new BinaryOperator(LocationInventoryByLot.Fields.Location.Oid.PropertyName, Convert.ToInt32(locationLookUpEdit.EditValue), BinaryOperatorType.Equal));

				lpnXpView.Criteria = CriteriaOperator.And(lpnViewCriteria);
			}
		}
		private void FilterLots()
		{

			CriteriaOperatorCollection lotViewCriteria = new CriteriaOperatorCollection();

			if (((int?)lpnLookUpEdit.EditValue).HasValue)
			{
				lotViewCriteria.Add(new BinaryOperator(LocationInventoryByLot.Fields.LPNNumber.PropertyName, Convert.ToInt32(lpnLookUpEdit.EditValue), BinaryOperatorType.Equal));

				LotXpView.Criteria = CriteriaOperator.And(lotViewCriteria);
				LotXpView.Reload();
			}
		}

		private void AddLpnSimpleButton_Click(object sender, EventArgs e)
		{
			if (((int?)itemLookUpEdit.EditValue).HasValue && ((int?)locationLookUpEdit.EditValue).HasValue && !m_newLpn)
			{
				int lpn = LPNLabel.GetNextLPNNumber(7);
				ItemsBLL items = new ItemsBLL();
				items.UpdateStock(Session.DefaultSession, Convert.ToInt32(itemLookUpEdit.EditValue), 0, false, Convert.ToInt32(locationLookUpEdit.EditValue), "", lpn);
				lpnXpView.Reload();
				lpnLookUpEdit.EditValue = lpn;
				FilterLots();
				m_newLpn = true;
			}
		}
		private void printLpn()
		{
			int digits = CustomersBLL.GetCustomer(7, Session.DefaultSession).LastLPNNumber.ToString().Length;
			XPView lpnXPview = null;
			CriteriaOperatorCollection critaria = new CriteriaOperatorCollection();

			lpnXPview = new XPView(Session.DefaultSession, typeof(LocationInventoryByLot));
			lpnXPview.Criteria = CriteriaOperator.And(new BinaryOperator("LPNNumber", (object)Utilities.ChangeType<int?>(lpnLookUpEdit.EditValue), BinaryOperatorType.Equal), new BinaryOperator("QuantityOnHand", 0, BinaryOperatorType.Greater));

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
			labels.ReprintXrLabel.Visible = !m_newLpn;
			labels.CreateDocument();
			labels.ShowPreviewDialog();
		}

        public void UpdateQtyPerPallet()
        {
            double CasesPerPallet = 0;
            double QuantityPerUnit = 0;
            int itemId = Convert.ToInt32(itemLookUpEdit.EditValue);

            QuantityPerUnit = ItemsBLL.GetCaseQuantity(itemId);
            CasesPerPallet = m_Items.GetCasesPerPallet(itemId);

            UnitsPerPltTextEdit.EditValue = CasesPerPallet;
            QtyPerPltTextEdit.EditValue = (CasesPerPallet * QuantityPerUnit);

            if(!string.IsNullOrEmpty(QtyTextEdit.Text))
                UnitsTextEdit.EditValue = Math.Ceiling(Convert.ToDouble(QtyTextEdit.Text) / QuantityPerUnit);
        }
        private int m_lastItem;
        private int m_lastLPN;
        private double m_lastPalletQty;
        private void AddLpns(bool toLastLPN = false)
        {
            double addedQty = 0;
            double addedUnits = 0;
            double qty = 0;
            double units = 0;
            double qtyPerPlt = 0;
            double UnitPerPlt = 0;

            m_lastItem = Convert.ToInt32(itemLookUpEdit.EditValue);
            qty = Convert.ToDouble(QtyTextEdit.Text);
            units = Convert.ToDouble(UnitsTextEdit.Text);
            qtyPerPlt = Convert.ToDouble(QtyPerPltTextEdit.Text);
            UnitPerPlt = Convert.ToDouble(UnitsPerPltTextEdit.Text);

            while (!(addedQty >= qty))
            {
                if (qty <= qtyPerPlt)
                {
                    originalQtyTextEdit.EditValue = qty;
                    newQtyTextEdit.EditValue = qty;
                }
                else if ((qty - addedQty) > qtyPerPlt)
                {
                    originalQtyTextEdit.EditValue = qtyPerPlt;
                    newQtyTextEdit.EditValue = qtyPerPlt;
                }
                else
                {
                    originalQtyTextEdit.EditValue = qty - addedQty;
                    newQtyTextEdit.EditValue = qty - addedQty;
                }
                
                int lpn = LPNLabel.GetNextLPNNumber(7);
                lpnLookUpEdit.EditValue = lpn;
                m_lastLPN = lpn;
                if (SaveRecord(null, false))
                {
                    addedQty += double.Parse(newQtyTextEdit.EditValue.ToString());
                    saveSimpleButton.Tag = null;
                }
            }
            m_lastPalletQty = qtyPerPlt - double.Parse(newQtyTextEdit.EditValue.ToString());
            PrepareNewRecord();
            
            LotTextEdit.EditValue = null;
            ExprationDateEdit.EditValue = null;
            QtyTextEdit.EditValue = null;
            UnitsTextEdit.EditValue = null;
            QtyPerPltTextEdit.EditValue = null;
            UnitsPerPltTextEdit.EditValue = null;
            BulkEntryChanged();
        }

        private void BulkEntryChanged()
        {
            //INSTANT C# TODO TASK: The following 'On Error GoTo' statement cannot be converted by Instant C#:
            //On Error GoTo Err
            try
            {

                if (int.Parse(UnitsTextEdit.Text) > 0 && int.Parse(UnitsPerPltTextEdit.Text) > 0 && ((int.Parse(QtyTextEdit.Text) > 0 && int.Parse(QtyPerPltTextEdit.Text) > 0) || int.Parse(QtyTextEdit.Text) == 0) && LotCodeValidator.ValidateByItemID(Convert.ToInt32(itemLookUpEdit.EditValue), LotTextEdit.Text, true))
                {
                    AddPalletsSimpleButton.Enabled = true;
                    AddToPalletSimpleButton.Enabled = int.Parse(UnitsTextEdit.Text) <= int.Parse(UnitsPerPltTextEdit.Text) && int.Parse(QtyTextEdit.Text) <= int.Parse(QtyPerPltTextEdit.Text) && Convert.ToInt32(itemLookUpEdit.EditValue) == m_lastItem;
                }
                else
                {
                    //Err:
                    AddPalletsSimpleButton.Enabled = false;
                    AddToPalletSimpleButton.Enabled = false;
                }
            }
            catch
            {
                AddPalletsSimpleButton.Enabled = false;
                AddToPalletSimpleButton.Enabled = false;
            }


        }

        private void AddPalletsSimpleButton_Click(object sender, EventArgs e)
        {
            if (!ValidateAddLPN())
                return;
            originalQtyTextEdit.EditValue = QtyTextEdit.EditValue;
            newQtyTextEdit.EditValue = QtyTextEdit.EditValue;
            newLotTextEdit.EditValue = LotTextEdit.EditValue;

            //m_newLpn = false;
            if (((int?)itemLookUpEdit.EditValue).HasValue && ((int?)locationLookUpEdit.EditValue).HasValue && !m_newLpn)
            {
                
                ItemsBLL items = new ItemsBLL();
                items.UpdateStock(Session.DefaultSession, Convert.ToInt32(itemLookUpEdit.EditValue), 0, false, Convert.ToInt32(locationLookUpEdit.EditValue), LotTextEdit.Text, null,null,false);
                lpnXpView.Reload();
                
                FilterLots();
                m_newLpn = true;
            }
            saveSimpleButton.Tag = null;
            AddLpns();
            
        }

        private void AddToPalletSimpleButton_Click(object sender, EventArgs e)
        {
            if (!ValidateAddLPN())
                return;
            originalQtyTextEdit.EditValue = QtyTextEdit.EditValue;
            newQtyTextEdit.EditValue = QtyTextEdit.EditValue;
            newLotTextEdit.EditValue = LotTextEdit.EditValue;
            lpnLookUpEdit.EditValue = m_lastLPN;

            AddLpns();
        }

        bool ValidateAddLPN()
        {
            if (itemLookUpEdit.EditValue == null || (itemLookUpEdit.EditValue == null ? null : Convert.ToString(itemLookUpEdit.EditValue)) == itemLookUpEdit.Properties.NullText)
            {
                MessageBox.Show("You must select a Item Code.");
                itemLookUpEdit.Focus();
                return false; ;
            }

            if (string.IsNullOrWhiteSpace(QtyTextEdit.Text))
            {
                MessageBox.Show("You must enter quantity.");
                QtyTextEdit.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(LotTextEdit.Text) || LotTextEdit.Text == "Lot #")
            {
                MessageBox.Show("You must enter lot.");
                LotTextEdit.Focus();
                return false; ;
            }

            if (string.IsNullOrEmpty(Convert.ToString(reasonMemoExEdit.EditValue)) == true)
            {
                reasonMemoExEdit.EditValue = "Added LPN";
            }
            return true;

        }

        private void QtyTextEdit_Validated(object sender, EventArgs e)
        {
            UpdateQtyPerPallet();
            BulkEntryChanged();
            AddPalletsSimpleButton.Focus();
        }
    }
}