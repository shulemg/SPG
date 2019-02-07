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

			this.descriptionMemoEdit.Text = ItemsBLL.GetDescriptionByItemID((int?)this.itemLookUpEdit.EditValue);
			this.customerLookUpEdit.EditValue = m_Items.GetCustomerIDByItemID(Convert.ToInt32(this.itemLookUpEdit.EditValue));

			if (locationLookUpEdit.EditValue != null)
			{
				originalQtyTextEdit.EditValue = ItemsBLL.GetQtyOnHandByID(Session.DefaultSession, Convert.ToInt32(itemLookUpEdit.EditValue), Convert.ToInt32(locationLookUpEdit.EditValue));
			}

			FilterLpns();

			this.lpnLookUpEdit.EditValue = null;
			this.originalLotLookUpEdit.EditValue = null;
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
			this.originalQtyTextEdit.Text = "";
			this.originalLotLookUpEdit.EditValue = null;
			FilterLots();
			if (LotXpView.Count == 1)
			{
				originalLotLookUpEdit.EditValue = LotXpView[0]["Lot"];
				this.originalQtyTextEdit.Text = (originalLotLookUpEdit.GetColumnValue("Qty") ?? 0).ToString();
			}
		}
		private void originalLotLookUpEdit_Validated(object sender, EventArgs e)
		{

			this.originalQtyTextEdit.Text = (originalLotLookUpEdit.GetColumnValue("Qty") ?? 0).ToString();

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
			if (this.adjustmentGridView.SelectedRowsCount == 1)
			{
				int rowHandle = this.adjustmentGridView.GetSelectedRows()[0];
				this.editSimpleButton.Tag = rowHandle;

				//Dim inventoryRecord As SPG.InventoryRow = m_Inventory.GetInventoryByID(.GetRowCellValue(rowHandle, Me.idGridColumn)).Rows(0)
				this.saveSimpleButton.Tag = this.adjustmentGridView.GetRowCellValue(rowHandle, this.idGridColumn);
				this.adjustmentDateEdit.DateTime = Convert.ToDateTime(this.adjustmentGridView.GetRowCellValue(rowHandle, this.dateGridColumn));
				this.itemLookUpEdit.EditValue = this.adjustmentGridView.GetRowCellValue(rowHandle, this.itemIDGridColumn);
				if (Convert.IsDBNull(this.adjustmentGridView.GetRowCellValue(rowHandle, this.descriptionGridColumn)) == false && this.adjustmentGridView.GetRowCellValue(rowHandle, this.descriptionGridColumn) == null == false)
				{
					this.descriptionMemoEdit.Text = this.adjustmentGridView.GetRowCellValue(rowHandle, this.descriptionGridColumn).ToString();
				}
				this.lpnLookUpEdit.EditValue = this.adjustmentGridView.GetRowCellValue(rowHandle, this.colLPN);
				this.newQtyTextEdit.EditValue = this.adjustmentGridView.GetRowCellValue(rowHandle, this.newQtyGridColumn);
				this.originalQtyTextEdit.EditValue = this.adjustmentGridView.GetRowCellValue(rowHandle, this.originalQuantityGridColumn);
				this.newQtyTextEdit.EditValue = this.adjustmentGridView.GetRowCellValue(rowHandle, this.newQtyGridColumn);
				this.originalLotLookUpEdit.EditValue = this.adjustmentGridView.GetRowCellValue(rowHandle, this.colOriginalLot);
				this.newLotTextEdit.EditValue = this.adjustmentGridView.GetRowCellValue(rowHandle, this.colNewLot);
				this.customerLookUpEdit.EditValue = this.adjustmentGridView.GetRowCellValue(rowHandle, this.customerIDGridColumn);
				this.reasonMemoExEdit.EditValue = this.adjustmentGridView.GetRowCellValue(rowHandle, this.reasonGridColumn);
				locationLookUpEdit.EditValue = this.adjustmentGridView.GetRowCellValue(rowHandle, locationGridColumn);
				FilterLpns();
				FilterLots();
			}

		}

		private void cancelSimpleButton_Click(object sender, EventArgs e)
		{

			if (m_newLpn)
			{
				LocationInventoryByLot Lpntodelete = Session.DefaultSession.FindObject<LocationInventoryByLot>(new GroupOperator(GroupOperatorType.And, new BinaryOperator("LPNNumber", (object)Utilities.ChangeType<int?>(this.lpnLookUpEdit.EditValue), BinaryOperatorType.Equal), new BinaryOperator(LocationInventoryByLot.Fields.QuantityOnHand.PropertyName, 0, BinaryOperatorType.Equal), new BinaryOperator("LocationInventoryLot", "", BinaryOperatorType.Equal)));
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

			if ((this.customerLookUpEdit.EditValue == null ? null : Convert.ToString(this.customerLookUpEdit.EditValue)) == this.customerLookUpEdit.Properties.NullText || string.IsNullOrEmpty((this.customerLookUpEdit.EditValue == null ? null : Convert.ToString(this.customerLookUpEdit.EditValue))))
			{
				this.itemsXPView.Filter = null;
			}
			else
			{
				this.itemsXPView.Filter = new BinaryOperator("CustomerID", (customerLookUpEdit.EditValue == null ? null : Convert.ToString(customerLookUpEdit.EditValue)), BinaryOperatorType.Equal);
			}

		}

		private void customerFilterLookUpEdit_Validated(object sender, EventArgs e)
		{

			if ((this.customerFilterLookUpEdit.EditValue == null ? null : Convert.ToString(this.customerFilterLookUpEdit.EditValue)) == this.customerFilterLookUpEdit.Properties.NullText || string.IsNullOrEmpty((this.customerFilterLookUpEdit.EditValue == null ? null : Convert.ToString(this.customerFilterLookUpEdit.EditValue))))
			{
				this.itemsFilterXPView.Filter = null;
			}
			else
			{
				this.itemsFilterXPView.Filter = new BinaryOperator("CustomerID", (customerFilterLookUpEdit.EditValue == null ? null : Convert.ToString(customerFilterLookUpEdit.EditValue)), BinaryOperatorType.Equal);
			}

		}

		private void clearSimpleButton_Click(object sender, EventArgs e)
		{

			SetDefaultViewFilter();
			this.fromFilterDateEdit.EditValue = null;
			this.toFilterDateEdit.EditValue = null;
			FillAdjustmentView();

		}

		private void saveSimpleButton_Click(object sender, EventArgs e)
		{

			if (ValidateRecord())
			{
				if (SaveRecord((int?)this.saveSimpleButton.Tag))
				{
					PrepareNewRecord();
				}
			}

		}

		private void InventoryAdjustmentXtraForm_FormClosing(object sender, FormClosingEventArgs e)
		{

			if (this.editSimpleButton.Tag != null)
			{
				MessageBox.Show("You must first save or cancel the changes");
				e.Cancel = true;
			}

		}

		private void InventoryAdjustmentXtraForm_Load(object sender, EventArgs e)
		{

			this.Cursor = Cursors.WaitCursor;

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

			this.Cursor = Cursors.Default;

		}

		public void PrepareNewRecord()
		{

			this.saveSimpleButton.Tag = null;
			this.editSimpleButton.Tag = null;
			this.descriptionMemoEdit.Text = null;
			if (DateTime.Now.TimeOfDay < new TimeSpan(9, 0, 0))
			{
				adjustmentDateEdit.DateTime = DateTime.Today.AddDays(-1);
			}
			else
			{
				adjustmentDateEdit.DateTime = DateTime.Today;
			}
			this.itemLookUpEdit.EditValue = null;
			this.originalQtyTextEdit.Text = null;
			this.newQtyTextEdit.Text = null;
			this.customerLookUpEdit.EditValue = null;
			this.reasonMemoExEdit.EditValue = null;
			locationLookUpEdit.EditValue = UsersBLL.GetUsersLocalLocation(Session.DefaultSession, Properties.Settings.Default.UserName).Oid;
			this.lpnLookUpEdit.Text = "";
			this.originalLotLookUpEdit.Text = "";
			this.newLotTextEdit.Text = "";
			m_newLpn = false;

		}

		public void SetDefaultViewFilter()
		{

			//Set the from filter to the sunday of this week
			this.fromFilterDateEdit.DateTime = DateTime.Today.AddDays((Microsoft.VisualBasic.DateAndTime.Weekday(DateTime.Today) - 1) * -1);
			this.toFilterDateEdit.DateTime = DateTime.Today;
			this.customerFilterLookUpEdit.EditValue = null;
			this.itemFilterLookUpEdit.EditValue = null;

		}

		public void FillAdjustmentView()
		{


			CriteriaOperatorCollection inventoryViewCriteria = new CriteriaOperatorCollection();

			if (((DateTime?)this.fromFilterDateEdit.EditValue).HasValue)
			{
				inventoryViewCriteria.Add(new BinaryOperator(InventoryAdjustment.Fields.AdjustmentDate.PropertyName, Convert.ToDateTime(this.fromFilterDateEdit.EditValue), BinaryOperatorType.GreaterOrEqual));
			}
			if (((DateTime?)this.toFilterDateEdit.EditValue).HasValue)
			{
				inventoryViewCriteria.Add(new BinaryOperator(InventoryAdjustment.Fields.AdjustmentDate.PropertyName, Convert.ToDateTime(this.toFilterDateEdit.EditValue), BinaryOperatorType.LessOrEqual));
			}
			if (((int?)this.customerFilterLookUpEdit.EditValue).HasValue)
			{
				inventoryViewCriteria.Add(new BinaryOperator(InventoryAdjustment.Fields.AdjustmentItem.ItemCustomerID.CustomerID.PropertyName, Convert.ToInt32(this.customerFilterLookUpEdit.EditValue), BinaryOperatorType.Equal));
			}
			if (((int?)this.itemFilterLookUpEdit.EditValue).HasValue)
			{
				inventoryViewCriteria.Add(new BinaryOperator(InventoryAdjustment.Fields.AdjustmentItem.ItemID.PropertyName, Convert.ToInt32(this.itemFilterLookUpEdit.EditValue), BinaryOperatorType.Equal));
			}

			this.inventoryXPView.Criteria = CriteriaOperator.And(inventoryViewCriteria);


			//Me.adjustmentGridControl.DataSource = m_Adjustment.GetAdjustmentView(CType(Me.fromFilterDateEdit.EditValue, Date?), CType(Me.toFilterDateEdit.EditValue, Date?), _
			//                                                                     CType(Me.customerFilterLookUpEdit.EditValue, Integer?), CType(Me.itemFilterLookUpEdit.EditValue, Integer?))

		}

		public bool ValidateRecord()
		{

			if (this.itemLookUpEdit.EditValue == null || (this.itemLookUpEdit.EditValue == null ? null : Convert.ToString(this.itemLookUpEdit.EditValue)) == this.itemLookUpEdit.Properties.NullText)
			{
				MessageBox.Show("You must select a Item Code.");
				this.itemLookUpEdit.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(this.newQtyTextEdit.Text) && string.IsNullOrEmpty(this.newLotTextEdit.Text))
			{
				MessageBox.Show("You must enter a new quantity or lot.");
				this.newQtyTextEdit.Focus();
				return false;
			}
			else if (!string.IsNullOrEmpty(this.newQtyTextEdit.Text) && !string.IsNullOrEmpty(this.newLotTextEdit.Text))
			{
				if (this.saveSimpleButton.Tag != null && this.newQtyTextEdit.Text == "0")
				{
					this.newQtyTextEdit.Text = null;
				}
				else
				{
					MessageBox.Show("You cant update quantity and lot at once.");
					this.newQtyTextEdit.Focus();
					return false;
				}
			}

			if (this.originalLotLookUpEdit.EditValue == null && this.lpnLookUpEdit.EditValue != null)
			{
				MessageBox.Show("You must select a Lot.");
				this.originalLotLookUpEdit.Focus();
				return false;
			}

			if (!string.IsNullOrEmpty(this.newLotTextEdit.Text) && LotCodeValidator.ValidateByItemID(Convert.ToInt32(itemLookUpEdit.GetColumnValue("ItemID")), newLotTextEdit.Text, true) == false)
			{
				MessageBox.Show("Lot code invalid.");
				this.newLotTextEdit.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(Convert.ToString(this.reasonMemoExEdit.EditValue)) == true)
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

			if (this.saveSimpleButton.Tag == null)
			{
				if (m_AllowAdd == true)
				{
					this.saveSimpleButton.Tag = InventoryAdjustmentBLL.GetNewInventoryAdjustmentID();
				}
				else
				{
					return false;
				}
			}

			return true;

		}

		public bool SaveRecord(int? id)
		{

			if (this.saveSimpleButton.Tag == null)
			{
				if (m_AllowAdd == true)
				{
					this.saveSimpleButton.Tag = InventoryAdjustmentBLL.GetNewInventoryAdjustmentID();
				}
				else
				{
					return false;
				}
			}

			if (m_Adjustment.UpdateInventoryAdjustment(Convert.ToInt32(this.saveSimpleButton.Tag), this.adjustmentDateEdit.DateTime, Convert.ToInt32(this.customerLookUpEdit.EditValue), Convert.ToInt32(this.itemLookUpEdit.EditValue), Convert.ToSingle(this.originalQtyTextEdit.EditValue), Convert.ToSingle(this.newQtyTextEdit.EditValue), Convert.ToString(this.reasonMemoExEdit.EditValue), Convert.ToInt32(locationLookUpEdit.EditValue), Convert.ToString(originalLotLookUpEdit.EditValue), newLotTextEdit.Text, Utilities.ChangeType<int?>(lpnLookUpEdit.EditValue), Utilities.ChangeType<DateTime?>(originalLotLookUpEdit.GetColumnValue("Expr"))) != true)
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

			if (InventoryAdjustmentBLL.DeleteInventoryAdjustment(Convert.ToInt32(this.adjustmentGridView.GetFocusedRowCellValue(this.idGridColumn))) != true)
			{
				MessageBox.Show("The adjustment record was not deleted succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			inventoryXPView.Reload();

		}

		private void adjustmentGridView_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
		{

			if (!Convert.IsDBNull(adjustmentGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, this.itemGridColumn)))
			{
				if (e.Column.Name == adjustmentGridColumn.Name)
				{
					if ((adjustmentGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, this.originalQuantityGridColumn) == null) || (adjustmentGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, this.newQtyGridColumn) == null))
					{
						return;
					}
					e.Value = Convert.ToInt32(adjustmentGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, this.newQtyGridColumn)) - Convert.ToInt32(adjustmentGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, this.originalQuantityGridColumn));
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
						this.editSimpleButton.Enabled = true;
						this.deleteGridColumn.Visible = true;
						break;
					case "ADD":
					case "Add":
						m_AllowAdd = true;
						this.editSimpleButton.Enabled = true;
						this.deleteGridColumn.Visible = false;
						break;
					case "NONE":
					case "None":
						MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						this.Close();
						return false;
					case "VIEW":
					case "View":
						this.editSimpleButton.Enabled = false;
						this.deleteGridColumn.Visible = false;
						break;
					case "EDIT":
					case "Edit":
						this.editSimpleButton.Enabled = true;
						this.deleteGridColumn.Visible = false;
						break;
					case "VIEW ASSIGNED":
						this.editSimpleButton.Enabled = false;
						this.deleteGridColumn.Visible = false;
						FilterAssignedCustomers();
						break;
					case "EDIT ASSIGNED":
						this.editSimpleButton.Enabled = true;
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

			this.inventoryXPView.Filter = new InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session));
			this.customersXPView.Criteria = CriteriaOperator.And(new BinaryOperator(Customers.Fields.Inactive.PropertyName, false), new InOperator(Customers.Fields.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(XpoDefault.Session)));
			this.customersFilterXPView.Criteria = CriteriaOperator.And(new BinaryOperator(Customers.Fields.Inactive.PropertyName, false), new InOperator(Customers.Fields.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(XpoDefault.Session)));
			this.itemsFilterXPView.Criteria = new InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(XpoDefault.Session));
			this.itemsXPView.Criteria = CriteriaOperator.And(new BinaryOperator(Items.Fields.Inactive.PropertyName, false), new InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(XpoDefault.Session)));

		}

		private void FilterLpns()
		{

			CriteriaOperatorCollection lpnViewCriteria = new CriteriaOperatorCollection();

			if (((int?)this.itemLookUpEdit.EditValue).HasValue && ((int?)this.locationLookUpEdit.EditValue).HasValue)
			{
				lpnViewCriteria.Add(new BinaryOperator(LocationInventoryByLot.Fields.LocationInventoryItem.ItemID.PropertyName, Convert.ToInt32(this.itemLookUpEdit.EditValue), BinaryOperatorType.Equal));
				lpnViewCriteria.Add(new BinaryOperator(LocationInventoryByLot.Fields.Location.Oid.PropertyName, Convert.ToInt32(this.locationLookUpEdit.EditValue), BinaryOperatorType.Equal));

				this.lpnXpView.Criteria = CriteriaOperator.And(lpnViewCriteria);
			}
		}
		private void FilterLots()
		{

			CriteriaOperatorCollection lotViewCriteria = new CriteriaOperatorCollection();

			if (((int?)this.lpnLookUpEdit.EditValue).HasValue)
			{
				lotViewCriteria.Add(new BinaryOperator(LocationInventoryByLot.Fields.LPNNumber.PropertyName, Convert.ToInt32(this.lpnLookUpEdit.EditValue), BinaryOperatorType.Equal));

				this.LotXpView.Criteria = CriteriaOperator.And(lotViewCriteria);
				this.LotXpView.Reload();
			}
		}

		private void AddLpnSimpleButton_Click(object sender, EventArgs e)
		{
			if (((int?)this.itemLookUpEdit.EditValue).HasValue && ((int?)this.locationLookUpEdit.EditValue).HasValue && !m_newLpn)
			{
				int lpn = LPNLabel.GetNextLPNNumber(7);
				ItemsBLL items = new ItemsBLL();
				items.UpdateStock(Session.DefaultSession, Convert.ToInt32(this.itemLookUpEdit.EditValue), 0, false, Convert.ToInt32(this.locationLookUpEdit.EditValue), "", lpn);
				lpnXpView.Reload();
				this.lpnLookUpEdit.EditValue = lpn;
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
			lpnXPview.Criteria = CriteriaOperator.And(new BinaryOperator("LPNNumber", (object)Utilities.ChangeType<int?>(this.lpnLookUpEdit.EditValue), BinaryOperatorType.Equal), new BinaryOperator("QuantityOnHand", 0, BinaryOperatorType.Greater));

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


	}
}