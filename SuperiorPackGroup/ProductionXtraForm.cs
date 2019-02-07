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
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraEditors.Controls;

namespace SuperiorPackGroup
{
	public partial class ProductionXtraForm
	{

		public ProductionXtraForm()
		{
			InitializeComponent();
		}

		private bool m_AllowAdd = false;
		private ItemsBLL m_Items;
		private ProductionBLL m_Production;
		private ShiftsBLL m_Shift;
		private MachinesLinesBLL m_Machines;
		private CustomersBLL m_Customers;
		private Session m_ProductionSession;
		private BindingList<ReasonIDs> m_ReasonsCollection = new BindingList<ReasonIDs>();

		private void ProductionXtraForm_Activated(object sender, EventArgs e)
		{

			FillDropDowns();

		}

		private void ProductionXtraForm_FormClosing(object sender, FormClosingEventArgs e)
		{

			if (this.editSimpleButton.Tag != null)
			{
				MessageBox.Show("You must first save or cancel the changes");
				e.Cancel = true;
			}

		}

		private void FillDropDowns()
		{

			DataTable shifts = m_Shift.GetShifts();
			//Dim machines As DataTable = m_Machines.GetMachineLines()

			//Me.machineLookUpEdit.Properties.DataSource = machines
			//Me.machineFilterLookUpEdit.Properties.DataSource = machines
			this.shiftLookUpEdit.Properties.DataSource = shifts;
			this.shiftFilterLookUpEdit.Properties.DataSource = shifts;
			itemsFilterXPView.Reload();
			itemsXPView.Reload();
			customersXPView.Reload();

		}

		private void ProductionXtraForm_Load(object sender, EventArgs e)
		{

			this.Cursor = Cursors.WaitCursor;

			m_ProductionSession = new Session(MyDataLayers.SPGDataLayer)
			{
				TrackPropertiesModifications = true,
				OptimisticLockingReadBehavior = OptimisticLockingReadBehavior.MergeCollisionThrowException
			};

			CheckPermissions();

			for (int i = 0; i < components.Components.Count; i++)
			{
				if ((components.Components[i]) is XPView)
				{
					((XPView)components.Components[i]).Session = m_ProductionSession;
				}
				else if ((components.Components[i]) is XPCollection)
				{
					((XPCollection)components.Components[i]).Session = m_ProductionSession;
				}
			}

			m_Items = new ItemsBLL();
			m_Production = new ProductionBLL();
			m_Shift = new ShiftsBLL();
			m_Machines = new MachinesLinesBLL();
			m_Customers = new CustomersBLL();

			LookUpColumnInfo shiftNameColumn = new LookUpColumnInfo()
			{
				Caption = "Shift",
				FieldName = "ShiftName"
			};
			this.shiftLookUpEdit.Properties.Columns.Add(shiftNameColumn);
			this.shiftLookUpEdit.Properties.DisplayMember = "ShiftName";
			this.shiftLookUpEdit.Properties.ValueMember = "ShiftID";

			this.shiftFilterLookUpEdit.Properties.Columns.Add(shiftNameColumn);
			this.shiftFilterLookUpEdit.Properties.DisplayMember = "ShiftName";
			this.shiftFilterLookUpEdit.Properties.ValueMember = "ShiftID";

			//Dim machineNameColumn As Controls.LookUpColumnInfo = New Controls.LookUpColumnInfo() With {.Caption = "Machine Line", .FieldName = "MachineLineName"}

			//Me.machineLookUpEdit.Properties.Columns.Add(machineNameColumn)
			//Me.machineLookUpEdit.Properties.DisplayMember = "MachineLineName"
			//Me.machineLookUpEdit.Properties.ValueMember = "MachineLineID"

			//Me.machineFilterLookUpEdit.Properties.Columns.Add(machineNameColumn)
			//Me.machineFilterLookUpEdit.Properties.DisplayMember = "MachineLineName"
			//Me.machineFilterLookUpEdit.Properties.ValueMember = "MachineLineID"

			FillDropDowns();

			PrepareNewRecord();
			if (DateTime.Now.TimeOfDay < new TimeSpan(9, 0, 0))
			{
				productionDateEdit.DateTime = DateTime.Today.AddDays(-1);
			}
			else
			{
				productionDateEdit.DateTime = DateTime.Today;
			}

			SetDefaultViewFilter();
			FillProductionView();

			this.Cursor = Cursors.Default;

		}

		public void SetDefaultViewFilter()
		{

			//Set the from filter to the sunday of this week
			this.fromFilterDateEdit.DateTime = DateTime.Today.AddDays((Microsoft.VisualBasic.DateAndTime.Weekday(DateTime.Today) - 1) * -1);
			this.toFilterDateEdit.DateTime = DateTime.Today;
			this.machineFilterLookUpEdit.EditValue = null;
			this.customerFilterLookUpEdit.EditValue = null;
			this.shiftFilterLookUpEdit.EditValue = null;
			this.itemFilterLookUpEdit.EditValue = null;

		}

		private void itemLookUpEdit_Validated(System.Object sender, EventArgs e)
		{

			this.descriptionMemoEdit.Text = ItemsBLL.GetDescriptionByItemID((int?)this.itemLookUpEdit.EditValue);
			uomTextEdit.Text = ItemsBLL.GetUOMByItemID((int?)itemLookUpEdit.EditValue);

		}

		private void productionGridView_CustomUnboundColumnData(System.Object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
		{

			if (Convert.IsDBNull(productionGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, this.startGridColumn)))
			{
				return;
			}

			if (Convert.IsDBNull(productionGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, this.stopGridColumn)))
			{
				return;
			}

			if (e.Column.Name == "timeGridColumn")
			{
				DateTime ProductionDay = Convert.ToDateTime(productionGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, this.dateGridColumn));
				DateTime startTime = Convert.ToDateTime(productionGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, this.startGridColumn));
				DateTime stopTime = Convert.ToDateTime(productionGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, this.stopGridColumn));
				//Make sure that the work dates are the same as the production date
				startTime = new DateTime(ProductionDay.Year, ProductionDay.Month, ProductionDay.Day, startTime.Hour, startTime.Minute, 0);
				stopTime = new DateTime(ProductionDay.Year, ProductionDay.Month, ProductionDay.Day, stopTime.Hour, stopTime.Minute, 0);
				if (DateHelper.DateDiff(DateHelper.DateInterval.Minute, startTime, stopTime) < 1)
				{
					stopTime = stopTime.AddDays(1);
				}
				long interval = DateHelper.DateDiff(DateHelper.DateInterval.Minute, startTime, stopTime) - BreakTimeBLL.GetBreakMinutes(ProductionDay, startTime, stopTime);
				e.Value = string.Format("{0}:{1}", interval / 60, (interval % 60) / 1);
			}
			else if (e.Column.Name == colReasons.Name)
			{
				e.Value = m_ProductionSession.GetObjectByKey<Production>(productionGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, idGridColumn)).Reasons;
			}

		}

		private void saveSimpleButton_Click(System.Object sender, EventArgs e)
		{

			if (ValidateRecord())
			{
				if (SaveRecord((int?)this.saveSimpleButton.Tag))
				{
					PrepareNewRecord();
				}
			}

		}

		public bool ValidateRecord()
		{

			if (this.itemLookUpEdit.EditValue == null || (this.itemLookUpEdit.EditValue == null ? null : Convert.ToString(this.itemLookUpEdit.EditValue)) == this.itemLookUpEdit.Properties.NullText)
			{
				MessageBox.Show("You must select a Item Code.");
				this.itemLookUpEdit.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(this.quantityTextEdit.Text))
			{
				MessageBox.Show("You must enter a quantity.");
				this.quantityTextEdit.Focus();
				return false;
			}

			if (startTimeEdit.Time.Date != productionDateEdit.DateTime.Date || stopTimeEdit.Time.Date != productionDateEdit.DateTime.Date)
			{
				startTimeEdit.Time = new DateTime(productionDateEdit.DateTime.Date.Year, productionDateEdit.DateTime.Date.Month, productionDateEdit.DateTime.Date.Day, startTimeEdit.Time.Hour, startTimeEdit.Time.Minute, startTimeEdit.Time.Second);
				stopTimeEdit.Time = new DateTime(productionDateEdit.DateTime.Date.Year, productionDateEdit.DateTime.Date.Month, productionDateEdit.DateTime.Date.Day, stopTimeEdit.Time.Hour, stopTimeEdit.Time.Minute, stopTimeEdit.Time.Second);
			}
			if (DateHelper.DateDiff(DateHelper.DateInterval.Minute, this.startTimeEdit.Time, this.stopTimeEdit.Time) < 1)
			{
				this.stopTimeEdit.Time = stopTimeEdit.Time.AddDays(1);
			}
			if (productionDateEdit.DateTime.DayOfWeek == DayOfWeek.Saturday && DateHelper.DateDiff(DateHelper.DateInterval.Hour, this.startTimeEdit.Time, this.stopTimeEdit.Time) > 12 || productionDateEdit.DateTime.DayOfWeek != DayOfWeek.Saturday && DateHelper.DateDiff(DateHelper.DateInterval.Hour, this.startTimeEdit.Time, this.stopTimeEdit.Time) > 10)
			{

				if (MessageBox.Show(string.Format("The tims stop is more than {0} hours later than the time start.", DateHelper.DateDiff(DateHelper.DateInterval.Hour, this.startTimeEdit.Time, this.stopTimeEdit.Time)), "Time Stop", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
				{
					this.stopTimeEdit.Time = stopTimeEdit.Time.AddDays(-1);
					this.stopTimeEdit.Focus();
					return false;
				}
			}

			if (this.shiftLookUpEdit.EditValue == null || (this.shiftLookUpEdit.EditValue == null ? null : Convert.ToString(this.shiftLookUpEdit.EditValue)) == this.shiftLookUpEdit.Properties.NullText)
			{
				MessageBox.Show("You must select a Shift.");
				this.shiftLookUpEdit.Focus();
				return false;
			}

			if (this.machineLookUpEdit.EditValue == null || (this.machineLookUpEdit.EditValue == null ? null : Convert.ToString(this.machineLookUpEdit.EditValue)) == this.machineLookUpEdit.Properties.NullText)
			{
				MessageBox.Show("You must select a Machine line.");
				this.machineLookUpEdit.Focus();
				return false;
			}

			if (this.saveSimpleButton.Tag == null)
			{
				if (m_AllowAdd == true)
				{
					this.saveSimpleButton.Tag = m_Production.GetNewProductionID();
				}
				else
				{
					return false;
				}
			}

			if (string.IsNullOrEmpty(this.packersTextEdit.Text))
			{
				this.packersTextEdit.EditValue = 0;
			}

			return true;

		}

		public bool SaveRecord(int? id)
		{

			if (m_Production.UpdateProduction(Convert.ToInt32(this.saveSimpleButton.Tag), this.productionDateEdit.DateTime, (int?)this.shiftLookUpEdit.EditValue, (int?)this.itemLookUpEdit.EditValue, Utilities.ChangeType<float?>(this.quantityTextEdit.EditValue), (int?)this.machineLookUpEdit.EditValue, this.startTimeEdit.Time, this.stopTimeEdit.Time, Utilities.ChangeType<float?>(this.packersTextEdit.EditValue)) != true)
			{
				MessageBox.Show("The production record was not updated successfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else
			{
				var productionRow = m_ProductionSession.GetObjectByKey<Production>(Convert.ToInt32(saveSimpleButton.Tag), true);
				for (var i = productionRow.ReasonCodes.Count - 1; i >= 0; i--)
				{
					productionRow.ReasonCodes.Remove(productionRow.ReasonCodes[i]);
				}
				reasonsGridView.SelectAll();
				foreach (var reason in reasonsGridView.GetSelectedRows())
				{
					if (productionRow.ReasonCodes.Contains(new ReasonCodes() {Oid = Convert.ToInt32(reasonsGridView.GetRowCellValue(reason, reasonDescriptionGridColumn))}) == false)
					{
						productionRow.ReasonCodes.Add(m_ProductionSession.GetObjectByKey<ReasonCodes>(reasonsGridView.GetRowCellValue(reason, reasonDescriptionGridColumn)));
					}
				}
				productionRow.Save();
			}

				// delete record from view if we are updating a record
				this.productionXPView.Reload();

				return true;

		}

		public void PrepareNewRecord()
		{

			this.saveSimpleButton.Tag = null;
			this.editSimpleButton.Tag = null;
			this.descriptionMemoEdit.Text = null;
			this.shiftLookUpEdit.EditValue = null;
			this.machineLookUpEdit.EditValue = null;
			//Date should be saved form last entry
			//Me.productionDateEdit.DateTime = Today
			this.itemLookUpEdit.EditValue = null;
			this.packersTextEdit.Text = null;
			this.quantityTextEdit.Text = null;
			uomTextEdit.Text = null;
			m_ReasonsCollection.Clear();
			reasonsGridControl.DataSource = m_ReasonsCollection;

			this.startTimeEdit.Time = DateTime.Now;
			this.stopTimeEdit.Time = DateTime.Now.AddMinutes(5);

			this.productionDateEdit.Focus();

		}

		public void FillProductionView()
		{

			CriteriaOperatorCollection productionViewCriteria = new CriteriaOperatorCollection();

			if (((DateTime?)this.fromFilterDateEdit.EditValue).HasValue)
			{
				productionViewCriteria.Add(new BinaryOperator(Production.Fields.ProdMainDate.PropertyName, Convert.ToDateTime(this.fromFilterDateEdit.EditValue), BinaryOperatorType.GreaterOrEqual));
			}
			if (((DateTime?)this.toFilterDateEdit.EditValue).HasValue)
			{
				productionViewCriteria.Add(new BinaryOperator(Production.Fields.ProdMainDate.PropertyName, Convert.ToDateTime(this.toFilterDateEdit.EditValue), BinaryOperatorType.LessOrEqual));
			}
			if (((int?)this.customerFilterLookUpEdit.EditValue).HasValue)
			{
				productionViewCriteria.Add(new BinaryOperator(Production.Fields.ProdMainItemID.ItemCustomerID.CustomerID.PropertyName, Convert.ToInt32(this.customerFilterLookUpEdit.EditValue), BinaryOperatorType.Equal));
			}
			if (((int?)this.shiftFilterLookUpEdit.EditValue).HasValue)
			{
				productionViewCriteria.Add(new BinaryOperator(Production.Fields.ProdMainShift.ShiftID.PropertyName, Convert.ToInt32(this.shiftFilterLookUpEdit.EditValue), BinaryOperatorType.Equal));
			}
			if (((int?)this.machineFilterLookUpEdit.EditValue).HasValue)
			{
				productionViewCriteria.Add(new BinaryOperator(Production.Fields.ProdMainMachineLine.MachineLineID.PropertyName, Convert.ToInt32(this.machineFilterLookUpEdit.EditValue), BinaryOperatorType.Equal));
			}
			if (((int?)this.itemFilterLookUpEdit.EditValue).HasValue)
			{
				productionViewCriteria.Add(new BinaryOperator(Production.Fields.ProdMainItemID.ItemID.PropertyName, Convert.ToInt32(this.itemFilterLookUpEdit.EditValue), BinaryOperatorType.Equal));
			}

			this.productionXPView.Criteria = CriteriaOperator.And(productionViewCriteria);

		}

		private void editSimpleButton_Click(System.Object sender, EventArgs e)
		{

			//enters the row handle for the editing record in the edit button tag property
			if (this.productionGridView.SelectedRowsCount == 1)
			{
				int rowHandle = this.productionGridView.GetSelectedRows()[0];
				m_ProductionSession.DropIdentityMap();
				this.editSimpleButton.Tag = rowHandle;

				Production productionRecord = m_ProductionSession.GetObjectByKey<Production>(Convert.ToInt32(this.productionGridView.GetRowCellValue(rowHandle, this.idGridColumn)));
				this.saveSimpleButton.Tag = productionRecord.ProdMainID;
				this.productionDateEdit.DateTime = productionRecord.ProdMainDate;
				this.itemLookUpEdit.EditValue = productionRecord.ProdMainItemID.ItemID;
				this.shiftLookUpEdit.EditValue = productionRecord.ProdMainShift.ShiftID;
				this.startTimeEdit.Time = productionRecord.ProdMainTimeStart;
				this.stopTimeEdit.Time = productionRecord.ProdMainTimeStop;
				this.descriptionMemoEdit.EditValue = this.productionGridView.GetRowCellValue(rowHandle, this.descriptionGridColumn);
				this.quantityTextEdit.EditValue = productionRecord.ProdMainQuantity;
				uomTextEdit.Text = productionRecord.ProdMainItemID.strUnitOfMeasure;
				this.machineLookUpEdit.EditValue = productionRecord.ProdMainMachineLine.MachineLineID;
				this.packersTextEdit.EditValue = productionRecord.ProdMainPackers;
				m_ReasonsCollection.Clear();
				foreach (var reason in productionRecord.ReasonCodes)
				{
					m_ReasonsCollection.Add(new ReasonIDs() {Oid = reason.Oid});
				}
			}

		}

		private void deleteRepositoryItemButtonEdit_Click(System.Object sender, EventArgs e)
		{

			if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (m_Production.DeleteProduction(Convert.ToInt32(productionGridView.GetFocusedRowCellValue(this.idGridColumn)), m_ProductionSession) != true)
				{
					MessageBox.Show("The production record was not deleted successfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			this.productionXPView.Reload();

		}

		private void customerFilterLookUpEdit_Validated(System.Object sender, EventArgs e)
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

		private void clearSimpleButton_Click(System.Object sender, EventArgs e)
		{

			SetDefaultViewFilter();
			this.fromFilterDateEdit.EditValue = null;
			this.toFilterDateEdit.EditValue = null;
			FillProductionView();

		}

		private void filterSimpleButton_Click(System.Object sender, EventArgs e)
		{

			FillProductionView();

		}

		private void cancelSimpleButton_Click(System.Object sender, EventArgs e)
		{

			PrepareNewRecord();

		}

		public bool CheckPermissions()
		{

			try
			{
				SPG.UserPermissionsRow permission = (new UserPermissionsBLL()).GetUserPermissionsByUserName(Properties.Settings.Default.UserName, "Production Form")[0];

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

			this.productionXPView.Filter = new InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(m_ProductionSession));
			this.customersXPView.Criteria = CriteriaOperator.And(new BinaryOperator(Customers.Fields.Inactive.PropertyName, false), new InOperator(Customers.Fields.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ProductionSession)));
			this.itemsFilterXPView.Criteria = CriteriaOperator.And(new InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ProductionSession)), new InOperator(Items.Fields.ItemType.PropertyName, new string[] {"FG", "IG"}), new BinaryOperator(Items.Fields.Inactive.PropertyName, false, BinaryOperatorType.Equal));
			this.itemsXPView.Criteria = CriteriaOperator.And(new InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ProductionSession)), new InOperator(Items.Fields.ItemType.PropertyName, new string[] {"FG", "IG"}), new BinaryOperator(Items.Fields.Inactive.PropertyName, false, BinaryOperatorType.Equal));

		}

		private void shiftLookUpEdit_EditValueChanged(object sender, EventArgs e)
		{

			switch (shiftLookUpEdit.Text)
			{
				case "1":
					startTimeEdit.Time = new DateTime(productionDateEdit.DateTime.Year, productionDateEdit.DateTime.Month, productionDateEdit.DateTime.Day, 9, 0, 0);
					stopTimeEdit.Time = startTimeEdit.Time.AddHours(8);
					break;
				case "2":
					startTimeEdit.Time = new DateTime(productionDateEdit.DateTime.Year, productionDateEdit.DateTime.Month, productionDateEdit.DateTime.Day, 17, 0, 0);
					stopTimeEdit.Time = new DateTime(productionDateEdit.DateTime.Year, productionDateEdit.DateTime.Month, productionDateEdit.DateTime.Day, 1, 0, 0);
					break;
				case "3":
					startTimeEdit.Time = new DateTime(productionDateEdit.DateTime.Year, productionDateEdit.DateTime.Month, productionDateEdit.DateTime.Day, 1, 0, 0);
					stopTimeEdit.Time = startTimeEdit.Time.AddHours(8);
					break;
			}

		}

		public class ReasonIDs
		{

			public int Oid {get; set;}

		}

		private void deleteReasonRepositoryItemButtonEdit_Click(object sender, EventArgs e)
		{

			reasonsGridView.DeleteRow(reasonsGridView.FocusedRowHandle);

		}

		private void reasonsGridControl_ProcessGridKey(object sender, KeyEventArgs e)
		{

			if (e.KeyCode == Keys.Tab)
			{
				if (e.Modifiers == Keys.None && reasonsGridView.IsNewItemRow(reasonsGridView.FocusedRowHandle) && reasonsGridView.FocusedColumn.VisibleIndex == reasonsGridView.VisibleColumns.Count - 1)
				{
					if (reasonsGridView.IsEditing)
					{
						reasonsGridView.CloseEditor();
					}

					if (reasonsGridView.GetFocusedRow() == null)
					{
						SelectNextControl(reasonsGridControl, true, true, true, true);
						reasonsGridView.FocusedRowHandle = 0;
						reasonsGridView.FocusedColumn = reasonsGridView.VisibleColumns[1];
						e.Handled = true;
					}
				}
			}

		}

	}
}