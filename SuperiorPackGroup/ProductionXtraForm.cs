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

			if (editSimpleButton.Tag != null)
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
			shiftLookUpEdit.Properties.DataSource = shifts;
			shiftFilterLookUpEdit.Properties.DataSource = shifts;
			itemsFilterXPView.Reload();
			itemsXPView.Reload();
			customersXPView.Reload();

		}

		private void ProductionXtraForm_Load(object sender, EventArgs e)
		{

			Cursor = Cursors.WaitCursor;

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
			shiftLookUpEdit.Properties.Columns.Add(shiftNameColumn);
			shiftLookUpEdit.Properties.DisplayMember = "ShiftName";
			shiftLookUpEdit.Properties.ValueMember = "ShiftID";

			shiftFilterLookUpEdit.Properties.Columns.Add(shiftNameColumn);
			shiftFilterLookUpEdit.Properties.DisplayMember = "ShiftName";
			shiftFilterLookUpEdit.Properties.ValueMember = "ShiftID";

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

			Cursor = Cursors.Default;

		}

		public void SetDefaultViewFilter()
		{

			//Set the from filter to the sunday of this week
			fromFilterDateEdit.DateTime = DateTime.Today.AddDays((Microsoft.VisualBasic.DateAndTime.Weekday(DateTime.Today) - 1) * -1);
			toFilterDateEdit.DateTime = DateTime.Today;
			machineFilterLookUpEdit.EditValue = null;
			customerFilterLookUpEdit.EditValue = null;
			shiftFilterLookUpEdit.EditValue = null;
			itemFilterLookUpEdit.EditValue = null;

		}

		private void itemLookUpEdit_Validated(System.Object sender, EventArgs e)
		{

			descriptionMemoEdit.Text = ItemsBLL.GetDescriptionByItemID((int?)itemLookUpEdit.EditValue);
			uomTextEdit.Text = ItemsBLL.GetUOMByItemID((int?)itemLookUpEdit.EditValue);

		}

		private void productionGridView_CustomUnboundColumnData(System.Object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
		{

			if (Convert.IsDBNull(productionGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, startGridColumn)))
			{
				return;
			}

			if (Convert.IsDBNull(productionGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, stopGridColumn)))
			{
				return;
			}

			if (e.Column.Name == "timeGridColumn")
			{
				DateTime ProductionDay = Convert.ToDateTime(productionGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, dateGridColumn));
				DateTime startTime = Convert.ToDateTime(productionGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, startGridColumn));
				DateTime stopTime = Convert.ToDateTime(productionGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, stopGridColumn));
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
				if (SaveRecord((int?)saveSimpleButton.Tag))
				{
					PrepareNewRecord();
				}
			}

		}

		public bool ValidateRecord()
		{

			if (itemLookUpEdit.EditValue == null || (itemLookUpEdit.EditValue == null ? null : Convert.ToString(itemLookUpEdit.EditValue)) == itemLookUpEdit.Properties.NullText)
			{
				MessageBox.Show("You must select a Item Code.");
				itemLookUpEdit.Focus();
				return false;
			}

			if (string.IsNullOrEmpty(quantityTextEdit.Text))
			{
				MessageBox.Show("You must enter a quantity.");
				quantityTextEdit.Focus();
				return false;
			}

			if (startTimeEdit.Time.Date != productionDateEdit.DateTime.Date || stopTimeEdit.Time.Date != productionDateEdit.DateTime.Date)
			{
				startTimeEdit.Time = new DateTime(productionDateEdit.DateTime.Date.Year, productionDateEdit.DateTime.Date.Month, productionDateEdit.DateTime.Date.Day, startTimeEdit.Time.Hour, startTimeEdit.Time.Minute, startTimeEdit.Time.Second);
				stopTimeEdit.Time = new DateTime(productionDateEdit.DateTime.Date.Year, productionDateEdit.DateTime.Date.Month, productionDateEdit.DateTime.Date.Day, stopTimeEdit.Time.Hour, stopTimeEdit.Time.Minute, stopTimeEdit.Time.Second);
			}
			if (DateHelper.DateDiff(DateHelper.DateInterval.Minute, startTimeEdit.Time, stopTimeEdit.Time) < 1)
			{
				stopTimeEdit.Time = stopTimeEdit.Time.AddDays(1);
			}
			if (productionDateEdit.DateTime.DayOfWeek == DayOfWeek.Saturday && DateHelper.DateDiff(DateHelper.DateInterval.Hour, startTimeEdit.Time, stopTimeEdit.Time) > 12 || productionDateEdit.DateTime.DayOfWeek != DayOfWeek.Saturday && DateHelper.DateDiff(DateHelper.DateInterval.Hour, startTimeEdit.Time, stopTimeEdit.Time) > 10)
			{

				if (MessageBox.Show(string.Format("The tims stop is more than {0} hours later than the time start.", DateHelper.DateDiff(DateHelper.DateInterval.Hour, startTimeEdit.Time, stopTimeEdit.Time)), "Time Stop", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
				{
					stopTimeEdit.Time = stopTimeEdit.Time.AddDays(-1);
					stopTimeEdit.Focus();
					return false;
				}
			}

			if (shiftLookUpEdit.EditValue == null || (shiftLookUpEdit.EditValue == null ? null : Convert.ToString(shiftLookUpEdit.EditValue)) == shiftLookUpEdit.Properties.NullText)
			{
				MessageBox.Show("You must select a Shift.");
				shiftLookUpEdit.Focus();
				return false;
			}

			if (machineLookUpEdit.EditValue == null || (machineLookUpEdit.EditValue == null ? null : Convert.ToString(machineLookUpEdit.EditValue)) == machineLookUpEdit.Properties.NullText)
			{
				MessageBox.Show("You must select a Machine line.");
				machineLookUpEdit.Focus();
				return false;
			}

			if (saveSimpleButton.Tag == null)
			{
				if (m_AllowAdd == true)
				{
					saveSimpleButton.Tag = m_Production.GetNewProductionID();
				}
				else
				{
					return false;
				}
			}

			if (string.IsNullOrEmpty(packersTextEdit.Text))
			{
				packersTextEdit.EditValue = 0;
			}

			return true;

		}

		public bool SaveRecord(int? id)
		{

			if (m_Production.UpdateProduction(Convert.ToInt32(saveSimpleButton.Tag), productionDateEdit.DateTime, (int?)shiftLookUpEdit.EditValue, (int?)itemLookUpEdit.EditValue, Utilities.ChangeType<float?>(quantityTextEdit.EditValue), (int?)machineLookUpEdit.EditValue, startTimeEdit.Time, stopTimeEdit.Time, Utilities.ChangeType<float?>(packersTextEdit.EditValue)) != true)
			{
				MessageBox.Show("The production record was not updated successfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else
			{
                Production productionRow = m_ProductionSession.GetObjectByKey<Production>(Convert.ToInt32(saveSimpleButton.Tag), true);
				for (int i = productionRow.ReasonCodes.Count - 1; i >= 0; i--)
				{
					productionRow.ReasonCodes.Remove(productionRow.ReasonCodes[i]);
				}
				reasonsGridView.SelectAll();
				foreach (int reason in reasonsGridView.GetSelectedRows())
				{
					if (productionRow.ReasonCodes.Contains(new ReasonCodes() {Oid = Convert.ToInt32(reasonsGridView.GetRowCellValue(reason, reasonDescriptionGridColumn))}) == false)
					{
						productionRow.ReasonCodes.Add(m_ProductionSession.GetObjectByKey<ReasonCodes>(reasonsGridView.GetRowCellValue(reason, reasonDescriptionGridColumn)));
					}
				}
				productionRow.Save();
			}

				// delete record from view if we are updating a record
				productionXPView.Reload();

				return true;

		}

		public void PrepareNewRecord()
		{

			saveSimpleButton.Tag = null;
			editSimpleButton.Tag = null;
			descriptionMemoEdit.Text = null;
			shiftLookUpEdit.EditValue = null;
			machineLookUpEdit.EditValue = null;
			//Date should be saved form last entry
			//Me.productionDateEdit.DateTime = Today
			itemLookUpEdit.EditValue = null;
			packersTextEdit.Text = null;
			quantityTextEdit.Text = null;
			uomTextEdit.Text = null;
			m_ReasonsCollection.Clear();
			reasonsGridControl.DataSource = m_ReasonsCollection;

			startTimeEdit.Time = DateTime.Now;
			stopTimeEdit.Time = DateTime.Now.AddMinutes(5);

			productionDateEdit.Focus();

		}

		public void FillProductionView()
		{

			CriteriaOperatorCollection productionViewCriteria = new CriteriaOperatorCollection();

			if (((DateTime?)fromFilterDateEdit.EditValue).HasValue)
			{
				productionViewCriteria.Add(new BinaryOperator(Production.Fields.ProdMainDate.PropertyName, Convert.ToDateTime(fromFilterDateEdit.EditValue), BinaryOperatorType.GreaterOrEqual));
			}
			if (((DateTime?)toFilterDateEdit.EditValue).HasValue)
			{
				productionViewCriteria.Add(new BinaryOperator(Production.Fields.ProdMainDate.PropertyName, Convert.ToDateTime(toFilterDateEdit.EditValue), BinaryOperatorType.LessOrEqual));
			}
			if (((int?)customerFilterLookUpEdit.EditValue).HasValue)
			{
				productionViewCriteria.Add(new BinaryOperator(Production.Fields.ProdMainItemID.ItemCustomerID.CustomerID.PropertyName, Convert.ToInt32(customerFilterLookUpEdit.EditValue), BinaryOperatorType.Equal));
			}
			if (((int?)shiftFilterLookUpEdit.EditValue).HasValue)
			{
				productionViewCriteria.Add(new BinaryOperator(Production.Fields.ProdMainShift.ShiftID.PropertyName, Convert.ToInt32(shiftFilterLookUpEdit.EditValue), BinaryOperatorType.Equal));
			}
			if (((int?)machineFilterLookUpEdit.EditValue).HasValue)
			{
				productionViewCriteria.Add(new BinaryOperator(Production.Fields.ProdMainMachineLine.MachineLineID.PropertyName, Convert.ToInt32(machineFilterLookUpEdit.EditValue), BinaryOperatorType.Equal));
			}
			if (((int?)itemFilterLookUpEdit.EditValue).HasValue)
			{
				productionViewCriteria.Add(new BinaryOperator(Production.Fields.ProdMainItemID.ItemID.PropertyName, Convert.ToInt32(itemFilterLookUpEdit.EditValue), BinaryOperatorType.Equal));
			}

			productionXPView.Criteria = CriteriaOperator.And(productionViewCriteria);

		}

		private void editSimpleButton_Click(System.Object sender, EventArgs e)
		{

			//enters the row handle for the editing record in the edit button tag property
			if (productionGridView.SelectedRowsCount == 1)
			{
				int rowHandle = productionGridView.GetSelectedRows()[0];
				m_ProductionSession.DropIdentityMap();
				editSimpleButton.Tag = rowHandle;

				Production productionRecord = m_ProductionSession.GetObjectByKey<Production>(Convert.ToInt32(productionGridView.GetRowCellValue(rowHandle, idGridColumn)));
				saveSimpleButton.Tag = productionRecord.ProdMainID;
				productionDateEdit.DateTime = productionRecord.ProdMainDate;
				itemLookUpEdit.EditValue = productionRecord.ProdMainItemID.ItemID;
				shiftLookUpEdit.EditValue = productionRecord.ProdMainShift.ShiftID;
				startTimeEdit.Time = productionRecord.ProdMainTimeStart;
				stopTimeEdit.Time = productionRecord.ProdMainTimeStop;
				descriptionMemoEdit.EditValue = productionGridView.GetRowCellValue(rowHandle, descriptionGridColumn);
				quantityTextEdit.EditValue = productionRecord.ProdMainQuantity;
				uomTextEdit.Text = productionRecord.ProdMainItemID.strUnitOfMeasure;
				machineLookUpEdit.EditValue = productionRecord.ProdMainMachineLine.MachineLineID;
				packersTextEdit.EditValue = productionRecord.ProdMainPackers;
				m_ReasonsCollection.Clear();
				foreach (ReasonCodes reason in productionRecord.ReasonCodes)
				{
					m_ReasonsCollection.Add(new ReasonIDs() {Oid = reason.Oid});
				}
			}

		}

		private void deleteRepositoryItemButtonEdit_Click(System.Object sender, EventArgs e)
		{

			if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (m_Production.DeleteProduction(Convert.ToInt32(productionGridView.GetFocusedRowCellValue(idGridColumn)), m_ProductionSession) != true)
				{
					MessageBox.Show("The production record was not deleted successfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			productionXPView.Reload();

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

		private void clearSimpleButton_Click(System.Object sender, EventArgs e)
		{

			SetDefaultViewFilter();
			fromFilterDateEdit.EditValue = null;
			toFilterDateEdit.EditValue = null;
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

			productionXPView.Filter = new InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(m_ProductionSession));
			customersXPView.Criteria = CriteriaOperator.And(new BinaryOperator(Customers.Fields.Inactive.PropertyName, false), new InOperator(Customers.Fields.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ProductionSession)));
			itemsFilterXPView.Criteria = CriteriaOperator.And(new InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ProductionSession)), new InOperator(Items.Fields.ItemType.PropertyName, new string[] {"FG", "IG"}), new BinaryOperator(Items.Fields.Inactive.PropertyName, false, BinaryOperatorType.Equal));
			itemsXPView.Criteria = CriteriaOperator.And(new InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ProductionSession)), new InOperator(Items.Fields.ItemType.PropertyName, new string[] {"FG", "IG"}), new BinaryOperator(Items.Fields.Inactive.PropertyName, false, BinaryOperatorType.Equal));

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