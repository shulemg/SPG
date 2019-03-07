//INSTANT C# NOTE: Formerly VB project-level imports:
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using DevExpress.XtraEditors;
using System;
using System.Text;
using DevExpress.XtraEditors.Controls;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace SuperiorPackGroup
{
	public partial class ReportsXtraForm
	{

		public ReportsXtraForm()
		{
			InitializeComponent();
		}

		private ProductionBLL m_ProductionBLL = null;
		private CustomersBLL m_CustomersBLL = null;
		private ShiftsBLL m_ShiftsBLL = null;
		private ItemsBLL m_ItemsBLL = null;
		private MachinesLinesBLL m_MachinesBLL = null;
		private XtraReport m_Report = null;
		private SPG.ProductionDataTable m_Production = null;
		private ShippingAddressBLL m_Destinations = null;
		private CarriersBLL m_Carriers = null;
		private string m_SelectedReport;

		public void SelectedReport(string reportName)
		{

			this.Cursor = Cursors.WaitCursor;

			m_SelectedReport = reportName;

			if (m_ProductionBLL == null)
			{
				m_ProductionBLL = new ProductionBLL();
			}

			InitiateLookupEditControls();

			this.fromDateEdit.EditValue = DateTime.Today.AddDays((Microsoft.VisualBasic.DateAndTime.Weekday(DateTime.Today) - 1) * -1);
			this.toDateEdit.EditValue = DateTime.Today;

			switch (reportName)
			{
				case "ProductionDetailXtraReport":
					columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
					this.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(null, "FG|IG", false, XpoDefault.Session);
					if (m_Report == null)
					{
						m_Report = new ProductionXtraReport();
					}
					m_Report.Landscape = true;
					BindReportColumns(reportName);
					SetReportColumns(reportName, 0);

					break;
				case "ProductionMachineXtraReport":
					columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
					this.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(null, "FG|IG", false, XpoDefault.Session);
					if (m_Report == null)
					{
						m_Report = new ProductionMachineXtraReport();
					}
					m_Report.Landscape = true;
					BindReportColumns(reportName);
					SetReportColumns(reportName, 0);

					break;
				case "ProductionShiftXtraReport":
					columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
					this.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(null, "FG|IG", false, XpoDefault.Session);
					if (m_Report == null)
					{
						m_Report = new ProductionShiftXtraReport();
					}
					m_Report.Landscape = true;
					BindReportColumns(reportName);
					SetReportColumns(reportName, 0);

					break;
				case "ProductionSummaryXtraReport":
					columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
					this.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(null, "FG|IG", false, XpoDefault.Session);
					if (m_Report == null)
					{
						m_Report = new ProductionSummaryXtraReport();
					}

					break;
				case "ProductionEntriesXtraReport":
					columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
					this.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(null, "FG|IG", false, XpoDefault.Session);
					if (m_Report == null)
					{
						m_Report = new ProductionXtraReport();
					}
					m_Report.Landscape = false;
					BindReportColumns(reportName);
					SetReportColumns(reportName, 38);

					break;
				case "CostingXtraReport":
				case "CostingSmallXtraReport":
				case "FinancialCostingXtraReport":
					columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
					this.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(null, "FG|IG|RM", false, XpoDefault.Session);
					if (m_Report == null)
					{
						m_Report = new CostingXtraReport();
					}
					m_Report.Landscape = true;
					BindReportColumns(reportName);
					SetReportColumns(reportName, 0);

					break;
				case "ShippingXtraReport":
					columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
					this.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(null, "FG|IG", false, XpoDefault.Session);
					if (m_Report == null)
					{
						m_Report = new TransportationXtraReport();
					}
					BindReportColumns(reportName);
					SetReportColumns(reportName, 4);

					break;
				case "ShippingReturnsXtraReport":
					columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
					this.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(null, "RM|IG", false, XpoDefault.Session);
					if (m_Report == null)
					{
						m_Report = new TransportationXtraReport();
					}
					BindReportColumns(reportName);
					SetReportColumns(reportName, 4);

					break;
				case "ReceivingXtraReport":
					columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
					this.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(null, "RM|IG", false, XpoDefault.Session);
					if (m_Report == null)
					{
						m_Report = new TransportationXtraReport();
					}
					BindReportColumns(reportName);
					SetReportColumns(reportName, 10);

					break;
				case "ReceivingReturnsXtraReport":
					columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
					this.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(null, "FG|IG", false, XpoDefault.Session);
					if (m_Report == null)
					{
						m_Report = new TransportationXtraReport();
					}
					BindReportColumns(reportName);
					SetReportColumns(reportName, 10);

					break;
				case "InventoryAdjustmentXtraReport":
					columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
					this.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(null, "FG|IG|RM", false, XpoDefault.Session);
					if (m_Report == null)
					{
						m_Report = new InventoryXtraReport();
					}
					BindReportColumns(reportName);
					SetReportColumns(reportName, 20);

					break;
				case "PhysicalInventoryXtraReport":
					columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
					this.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(null, "FG|IG|RM", false, XpoDefault.Session);
					if (m_Report == null)
					{
						m_Report = new InventoryXtraReport();
					}
					BindReportColumns(reportName);
					SetReportColumns(reportName, 43);

					break;
				case "CurrentInventoryXtraReport":
					columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
					this.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(null, "FG|IG|RM", false, XpoDefault.Session);
					if (m_Report == null)
					{
						m_Report = new InventoryXtraReport();
					}
					BindReportColumns(reportName);
					SetReportColumns(reportName, 12);

					break;
				case "FinishedProductAvailabilityXtraReport":
					columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
					this.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(null, "FG|IG", false, XpoDefault.Session);
					if (m_Report == null)
					{
						m_Report = new InventoryXtraReport();
					}
					BindReportColumns(reportName);
					SetReportColumns(reportName, 35);

					break;
				case "ItemsListXtraReport":
					columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
					this.itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(null, "FG|IG|RM", false, XpoDefault.Session);
					if (m_Report == null)
					{
						m_Report = new ItemsXtraReport();
					}
					BindReportColumns(reportName);
					SetReportColumns(reportName, 80);

					break;
				case "ItemsTransactionsXtraReport":
					MessageBox.Show("This report has been replaced with the Item Transaction Summary report.");
					return;
					//columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
					//Me.itemCheckedListBoxControl.DataSource = m_ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(Nothing, "FG|IG|RM", False)
					//If m_Report Is Nothing Then
					//    m_Report = New ItemTransactionXtraReport
					//End If
					//BindReportColumns(reportName)
					//SetReportColumns(reportName, 80)

				case "ItemTransactionSummaryXtraReport":
					columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
					itemCheckedListBoxControl.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(null, "FG|IG|RM", false, XpoDefault.Session);
					if (m_Report == null)
					{
						m_Report = new ItemsXtraReport();
					}
					BindReportColumns(reportName);
					SetReportColumns(reportName, 62);

					break;
				case "PalletTransactionXtraReport":
					columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
					if (m_Report == null)
					{
						m_Report = new PalletTransactionXtraReport();
					}
					BindReportColumns(reportName);
					SetReportColumns(reportName, 0);

					break;
				case "PalletControlXtraReport":
					columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
					if (m_Report == null)
					{
						m_Report = new PalletsXtraReport();
					}
					BindReportColumns(reportName);

					break;
				case "AuditTrailXtraReport":
					columnsDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
					if (m_Report == null)
					{
						m_Report = new AuditTrailXtraReport();
					}
					BindReportColumns(reportName);

					break;
			}

			reportsPrintControl.PrintingSystem = m_Report.PrintingSystem;
			BindReport();
			//m_Report.CreateDocument()
			if (m_SelectedReport != "PalletControlXtraReport" && m_SelectedReport != "ItemsTransactionsXtraReport" && m_SelectedReport != "PalletTransactionXtraReport")
			{
				m_Report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
			}

			this.Cursor = Cursors.Default;

		}

		private void InitiateLookupEditControls()
		{

			if (m_CustomersBLL == null && customerLookUpEdit.Enabled == true)
			{
				m_CustomersBLL = new CustomersBLL();
				this.customerLookUpEdit.Properties.DataSource = m_CustomersBLL.GetCustomerNameAndIDS(false);
				this.customerLookUpEdit.Properties.Columns.Add(new LookUpColumnInfo());
				this.customerLookUpEdit.Properties.Columns[0].Caption = "Customer Name";
				this.customerLookUpEdit.Properties.Columns[0].FieldName = "CustomerName";
				this.customerLookUpEdit.Properties.DisplayMember = "CustomerName";
				this.customerLookUpEdit.Properties.ValueMember = "CustomerID";
			}

			if (m_ShiftsBLL == null && shiftLookUpEdit.Enabled == true)
			{
				m_ShiftsBLL = new ShiftsBLL();
				this.shiftLookUpEdit.Properties.DataSource = m_ShiftsBLL.GetShifts();
				this.shiftLookUpEdit.Properties.Columns.Add(new LookUpColumnInfo());
				this.shiftLookUpEdit.Properties.Columns[0].Caption = "Shift";
				this.shiftLookUpEdit.Properties.Columns[0].FieldName = "ShiftName";
				this.shiftLookUpEdit.Properties.DisplayMember = "ShiftName";
				this.shiftLookUpEdit.Properties.ValueMember = "ShiftID";
			}

			if (m_ItemsBLL == null && (itemCheckedListBoxControl.Enabled == true || itemTypeLookUpEdit.Enabled == true))
			{
				m_ItemsBLL = new ItemsBLL();
				this.itemCheckedListBoxControl.DisplayMember = "ItemCode";
				this.itemCheckedListBoxControl.ValueMember = "ItemID";

				this.itemTypeLookUpEdit.Properties.DataSource = ItemsBLL.GetItemTypes();
				this.itemTypeLookUpEdit.Properties.DisplayMember = "Description";
				this.itemTypeLookUpEdit.Properties.ValueMember = "Type";
			}

			if (m_MachinesBLL == null && machineLookUpEdit.Enabled == true)
			{
				m_MachinesBLL = new MachinesLinesBLL();
				this.machineLookUpEdit.Properties.DataSource = m_MachinesBLL.GetMachineLines();
				this.machineLookUpEdit.Properties.Columns.Add(new LookUpColumnInfo());
				this.machineLookUpEdit.Properties.Columns[0].Caption = "Machine Line";
				this.machineLookUpEdit.Properties.Columns[0].FieldName = "MachineLineName";
				this.machineLookUpEdit.Properties.DisplayMember = "MachineLineName";
				this.machineLookUpEdit.Properties.ValueMember = "MachineLineID";
			}

			if (m_Destinations == null && destinationLookUpEdit.Enabled == true)
			{
				m_Destinations = new ShippingAddressBLL();
				this.destinationLookUpEdit.Properties.DataSource = m_Destinations.GetAddressNameAndIDS();
				this.destinationLookUpEdit.Properties.Columns.Add(new LookUpColumnInfo());
				this.destinationLookUpEdit.Properties.Columns[0].FieldName = "ShippingName";
				this.destinationLookUpEdit.Properties.Columns[0].Caption = "Destination";
				this.destinationLookUpEdit.Properties.DisplayMember = "ShippingName";
				this.destinationLookUpEdit.Properties.ValueMember = "AddressID";
			}

			if (m_Carriers == null && carrierLookUpEdit.Enabled == true)
			{
				m_Carriers = new CarriersBLL();
				this.carrierLookUpEdit.Properties.DataSource = m_Carriers.GetCarrierIDAndNames();
				this.carrierLookUpEdit.Properties.Columns.Add(new LookUpColumnInfo());
				this.carrierLookUpEdit.Properties.Columns[0].FieldName = "CarrierName";
				this.carrierLookUpEdit.Properties.Columns[0].Caption = "Carrier Name";
				this.carrierLookUpEdit.Properties.DisplayMember = "CarrierName";
				this.carrierLookUpEdit.Properties.ValueMember = "CarrierID";
			}

		}

		private void SetReportColumns(string reportCodeName, int additionalWidth)
		{

			int left = 0;

			switch (reportCodeName)
			{
				case "ProductionDetailXtraReport":
				{
					ProductionXtraReport report = (ProductionXtraReport)m_Report;
					if (this.productionDateCheckEdit.Checked == true)
					{
						report.dateDetailXrLabel.Visible = true;
						report.dateHeaderXrLabel.Visible = true;
						report.dateHeaderXrLabel.Left = left;
						report.dateDetailXrLabel.Left = left;
						left += report.dateDetailXrLabel.Width;
					}
					else
					{
						report.dateHeaderXrLabel.Visible = false;
						report.dateDetailXrLabel.Visible = false;
					}
					if (this.productionShiftCheckEdit.Checked == true)
					{
						report.shiftHeaderXrLabel.Visible = true;
						report.shiftDetailXrLabel.Visible = true;
						report.shiftHeaderXrLabel.Left = left;
						report.shiftDetailXrLabel.Left = left;
						left += report.shiftDetailXrLabel.Width;
					}
					else
					{
						report.shiftHeaderXrLabel.Visible = false;
						report.shiftDetailXrLabel.Visible = false;
					}
					if (this.productionCustomerNameCheckEdit.Checked == true)
					{
						report.customerNameHeaderXrLabel.Visible = true;
						report.customerNameDetailXrLabel.Visible = true;
						report.customerNameHeaderXrLabel.Left = left;
						report.customerNameDetailXrLabel.Left = left;
						left += report.customerNameDetailXrLabel.Width;
					}
					else
					{
						report.customerNameHeaderXrLabel.Visible = false;
						report.customerNameDetailXrLabel.Visible = false;
					}
					if (this.productionLotCheckEdit.Checked == true)
					{
						report.lotHeadeerXrLabel.Visible = true;
						report.lotDetailXrLabel.Visible = true;
						report.lotHeadeerXrLabel.Left = left;
						report.lotDetailXrLabel.Left = left;
						left += report.lotDetailXrLabel.Width;
					}
					else
					{
						report.lotHeadeerXrLabel.Visible = false;
						report.lotDetailXrLabel.Visible = false;
					}
					if (this.productionItemCodeCheckEdit.Checked == true)
					{
						report.itemCodeHeaderXrLabel.Visible = true;
						report.itemCodeDetailXrLabel.Visible = true;
						report.itemCodeHeaderXrLabel.Left = left;
						report.itemCodeDetailXrLabel.Left = left;
						left += report.itemCodeDetailXrLabel.Width;
					}
					else
					{
						report.itemCodeHeaderXrLabel.Visible = false;
						report.itemCodeDetailXrLabel.Visible = false;
					}
					if (this.productionItemDescriptionCheckEdit.Checked == true)
					{
						report.itemDescriptionHeaderXrLabel.Visible = true;
						report.itemDescriptionDetailXrLabel.Visible = true;
						report.itemDescriptionHeaderXrLabel.Left = left;
						report.itemDescriptionDetailXrLabel.Left = left;
						left += report.itemDescriptionDetailXrLabel.Width;
					}
					else
					{
						report.itemDescriptionHeaderXrLabel.Visible = false;
						report.itemDescriptionDetailXrLabel.Visible = false;
					}
					if (this.productionStartTimeCheckEdit.Checked == true)
					{
						report.startTimeHeaderXrLabel.Visible = true;
						report.startTimeDetailXrLabel.Visible = true;
						report.startTimeHeaderXrLabel.Left = left;
						report.startTimeDetailXrLabel.Left = left;
						left += report.startTimeDetailXrLabel.Width;
					}
					else
					{
						report.startTimeHeaderXrLabel.Visible = false;
						report.stopTimeDetailXrLabel.Visible = false;
					}
					if (this.productionStopTimeCheckEdit.Checked == true)
					{
						report.stopTimeHeaderXrLabel.Visible = true;
						report.stopTimeDetailXrLabel.Visible = true;
						report.stopTimeHeaderXrLabel.Left = left;
						report.stopTimeDetailXrLabel.Left = left;
						left += report.stopTimeDetailXrLabel.Width;
					}
					else
					{
						report.stopTimeHeaderXrLabel.Visible = false;
						report.stopTimeDetailXrLabel.Visible = false;
					}
					if (this.productionTotalHoursCheckEdit.Checked == true)
					{
						report.totalHoursHeaderXrLabel.Visible = true;
						report.totalHoursDetailXrLabel.Visible = true;
						report.totalHoursFooterXrLabel.Visible = true;
						report.totalHoursHeaderXrLabel.Left = left;
						report.totalHoursDetailXrLabel.Left = left;
						report.totalHoursFooterXrLabel.Left = left - 5;
						left += report.totalHoursDetailXrLabel.Width;
					}
					else
					{
						report.totalHoursHeaderXrLabel.Visible = false;
						report.totalHoursDetailXrLabel.Visible = false;
						report.totalHoursFooterXrLabel.Visible = false;
					}
					if (this.productionTotalMinutesCheckEdit.Checked == true)
					{
						report.totalMinutesHeaderXrLabel.Visible = true;
						report.totalMinutesDetailXrLabel.Visible = true;
						report.totalMinutesHeaderXrLabel.Left = left;
						report.totalMinutesDetailXrLabel.Left = left;
						left += report.totalMinutesDetailXrLabel.Width;
					}
					else
					{
						report.totalMinutesHeaderXrLabel.Visible = false;
						report.totalMinutesDetailXrLabel.Visible = false;
					}
					if (this.productionQuantityCheckEdit.Checked == true)
					{
						report.quantityHeaderXrLabel.Visible = true;
						report.quantityDetailXrLabel.Visible = true;
						report.quantityFooterXrLabel.Visible = true;
						report.quantityHeaderXrLabel.Left = left;
						report.quantityDetailXrLabel.Left = left;
						report.quantityFooterXrLabel.Left = left - 10;
						left += report.quantityDetailXrLabel.Width;
					}
					else
					{
						report.quantityHeaderXrLabel.Visible = false;
						report.quantityDetailXrLabel.Visible = false;
						report.quantityFooterXrLabel.Visible = false;
					}
					if (productionUOMCheckEdit.Checked == true)
					{
						report.uomHeaderXrLabel.Visible = true;
						report.uomDetailXrLabel.Visible = true;
						report.uomHeaderXrLabel.Left = left;
						report.uomDetailXrLabel.Left = left;
						left += report.uomDetailXrLabel.Width;
					}
					else
					{
						report.uomHeaderXrLabel.Visible = false;
						report.uomDetailXrLabel.Visible = false;
					}
					if (this.productionExpectedCheckEdit.Checked == true)
					{
						report.expectedHeaderXrLabel.Visible = true;
						report.expectedDetailXrLabel.Visible = true;
						report.expectedFooterXrLabel.Visible = true;
						report.expectedHeaderXrLabel.Left = left;
						report.expectedDetailXrLabel.Left = left;
						report.expectedFooterXrLabel.Left = left;
						left += report.expectedDetailXrLabel.Width;
					}
					else
					{
						report.expectedHeaderXrLabel.Visible = false;
						report.expectedDetailXrLabel.Visible = false;
						report.expectedFooterXrLabel.Visible = false;
					}
					if (this.productionDifferenceCheckEdit.Checked == true)
					{
						report.differenceHeaderXrLabel.Visible = true;
						report.differenceDetailXrLabel.Visible = true;
						report.differenceFooterXrLabel.Visible = true;
						report.differenceHeaderXrLabel.Left = left;
						report.differenceDetailXrLabel.Left = left;
						report.differenceFooterXrLabel.Left = left;
						left += report.differenceDetailXrLabel.Width;
					}
					else
					{
						report.differenceHeaderXrLabel.Visible = false;
						report.differenceDetailXrLabel.Visible = false;
						report.differenceFooterXrLabel.Visible = false;
					}
					if (this.productionMachineLineCheckEdit.Checked == true)
					{
						report.machineLineHeaderXrLabel.Visible = true;
						report.machineLineDetailXrLabel.Visible = true;
						report.machineLineHeaderXrLabel.Left = left;
						report.machineLineDetailXrLabel.Left = left;
						left += report.machineLineDetailXrLabel.Width;
					}
					else
					{
						report.machineLineHeaderXrLabel.Visible = false;
						report.machineLineDetailXrLabel.Visible = false;
					}
					if (this.productionProjectedSpeedCheckEdit.Checked == true)
					{
						report.machineSpeedHeaderXrLabel.Visible = true;
						report.machineSpeedDetailXrLabel.Visible = true;
						report.machineSpeedHeaderXrLabel.Left = left;
						report.machineSpeedDetailXrLabel.Left = left;
						left += report.machineSpeedDetailXrLabel.Width;
					}
					else
					{
						report.machineSpeedHeaderXrLabel.Visible = false;
						report.machineSpeedDetailXrLabel.Visible = false;
					}
					if (this.productionActualSpeedCheckEdit.Checked == true)
					{
						report.actualSpeedHeaderXrLabel.Visible = true;
						report.actualSpeedDetailXrLabel.Visible = true;
						report.actualSpeedFooterXrLabel.Visible = true;
						report.actualSpeedHeaderXrLabel.Left = left;
						report.actualSpeedDetailXrLabel.Left = left;
						report.actualSpeedFooterXrLabel.Left = left - 5;
						left += report.actualSpeedDetailXrLabel.Width;
					}
					else
					{
						report.actualSpeedHeaderXrLabel.Visible = false;
						report.actualSpeedDetailXrLabel.Visible = false;
						report.actualSpeedFooterXrLabel.Visible = false;
					}
					if (this.productionPOCheckEdit.Checked == true)
					{
						report.poHeaderXrLabel.Visible = true;
						report.poDetailXrLabel.Visible = true;
						report.poHeaderXrLabel.Left = left;
						report.actualSpeedDetailXrLabel.Left = left;
						left += report.poDetailXrLabel.Width;
					}
					else
					{
						report.poHeaderXrLabel.Visible = false;
						report.poDetailXrLabel.Visible = false;
					}
					if (this.productionPackersCheckEdit.Checked == true)
					{
						report.packersHeaderXrLabel.Visible = true;
						report.packersDetailXrLabel.Visible = true;
						report.packersHeaderXrLabel.Left = left;
						report.packersDetailXrLabel.Left = left;
						left += report.packersDetailXrLabel.Width;
					}
					else
					{
						report.packersHeaderXrLabel.Visible = false;
						report.packersDetailXrLabel.Visible = false;
					}
					if (productionProjectedPackersCheckEdit.Checked == true)
					{
						report.projectedPackersHeaderXrLabel.Visible = true;
						report.projectedPackersDetailXrLabel.Visible = true;
						report.projectedPackersHeaderXrLabel.Left = left;
						report.projectedPackersDetailXrLabel.Left = left;
						left += report.projectedPackersDetailXrLabel.Width;
					}
					else
					{
						report.projectedPackersHeaderXrLabel.Visible = false;
						report.projectedPackersDetailXrLabel.Visible = false;
					}
					if (productionReasonCodeCheckEdit.Checked == true)
					{
						report.reasonCodeHeaderXrLabel.Visible = true;
						report.reasonCodeDetailXrLabel.Visible = true;
						report.reasonCodeHeaderXrLabel.Left = left;
						report.reasonCodeDetailXrLabel.Left = left;
						left += report.reasonCodeDetailXrLabel.Width;
					}
					else
					{
						report.reasonCodeHeaderXrLabel.Visible = false;
						report.reasonCodeDetailXrLabel.Visible = false;
					}
					if (this.productionTotalPayrollCheckEdit.Checked == true)
					{
						report.totalPayrollHeaderXrLabel.Visible = true;
						report.totalPayrollDetailXrLabel.Visible = true;
						report.totalPayrollFooterXrLabel.Visible = true;
						report.totalPayrollHeaderXrLabel.Left = left;
						report.totalPayrollDetailXrLabel.Left = left;
						report.totalPayrollFooterXrLabel.Left = left;
						left += report.totalPayrollDetailXrLabel.Width;
					}
					else
					{
						report.totalPayrollHeaderXrLabel.Visible = false;
						report.totalPayrollDetailXrLabel.Visible = false;
						report.totalPayrollFooterXrLabel.Visible = false;
					}
					report.printDateXrPageInfo.Left = left - 185;
					report.reportCriteriaXrLabel.Width = left - 190;
					report.reportTitleXrLabel.Width = left;
					report.headerXrPanel.Width = left;
					report.footerXrPanel.Width = left;
					report.pageNumberXrPageInfo.Left = left - 100;
					break;
				}
				case "ProductionMachineXtraReport":
				{
					ProductionMachineXtraReport report = (ProductionMachineXtraReport)m_Report;
					left = 67;
					if (this.pmsTotalMinutesCheckEdit.Checked == true)
					{
						report.minutesHeaderXrLabel.Visible = true;
						report.machineTotalMinutesXRLabel.Visible = true;
						report.itemMinutesXrLabel.Visible = true;
						report.minutesHeaderXrLabel.Left = left;
						report.machineTotalMinutesXRLabel.Left = left;
						report.itemMinutesXrLabel.Left = left;
						left += report.machineTotalMinutesXRLabel.Width;
					}
					else
					{
						report.minutesHeaderXrLabel.Visible = false;
						report.machineTotalMinutesXRLabel.Visible = false;
						report.itemMinutesXrLabel.Visible = false;
					}
					if (this.pmsQuantityCheckEdit.Checked == true)
					{
						report.quantityHeaderXrLabel.Visible = true;
						report.machineQuantityXrLabel.Visible = true;
						report.itemQuantityXrLabel.Visible = true;
						report.quantityHeaderXrLabel.Left = left;
						report.machineQuantityXrLabel.Left = left;
						report.itemQuantityXrLabel.Left = left;
						left += report.machineQuantityXrLabel.Width;
					}
					else
					{
						report.quantityHeaderXrLabel.Visible = false;
						report.machineQuantityXrLabel.Visible = false;
						report.itemQuantityXrLabel.Visible = false;
					}
					if (this.pmsProjectedSpeedCheckEdit.Checked == true)
					{
						report.machineSpeedHeaderXrLabel.Visible = true;
						report.machineProjectedSpeedXrLabel.Visible = true;
						report.itemProjectedSpeedXrLabel.Visible = true;
						report.machineSpeedHeaderXrLabel.Left = left;
						report.machineProjectedSpeedXrLabel.Left = left;
						report.itemProjectedSpeedXrLabel.Left = left;
						left += report.machineProjectedSpeedXrLabel.Width;
					}
					else
					{
						report.machineSpeedHeaderXrLabel.Visible = false;
						report.machineProjectedSpeedXrLabel.Visible = false;
						report.itemProjectedSpeedXrLabel.Left = left;
					}
					if (this.pmsAverageSpeedCheckEdit.Checked == true)
					{
						report.averageSpeedHeadeerXrLabel.Visible = true;
						report.machineAverageSpeedXRLabel.Visible = true;
						report.itemAverageSpeedXrLabel.Visible = true;
						report.averageSpeedHeadeerXrLabel.Left = left;
						report.machineAverageSpeedXRLabel.Left = left;
						report.itemAverageSpeedXrLabel.Left = left;
						left += report.machineAverageSpeedXRLabel.Width;
					}
					else
					{
						report.averageSpeedHeadeerXrLabel.Visible = false;
						report.machineAverageSpeedXRLabel.Visible = false;
						report.itemAverageSpeedXrLabel.Left = left;
					}
					if (this.pmsSpeedVariationVolCheckEdit.Checked == true)
					{
						report.speedVariationVolumeHeaderXrLabel.Visible = true;
						report.machineSpeedVariationVolumeXrLabel.Visible = true;
						report.itemSpeedVariationXrLabel.Visible = true;
						report.speedVariationVolumeHeaderXrLabel.Left = left;
						report.machineSpeedVariationVolumeXrLabel.Left = left;
						report.itemSpeedVariationXrLabel.Left = left;
						left += report.machineSpeedVariationVolumeXrLabel.Width;
					}
					else
					{
						report.speedVariationVolumeHeaderXrLabel.Visible = false;
						report.machineSpeedVariationVolumeXrLabel.Visible = false;
						report.itemSpeedVariationXrLabel.Visible = false;
					}
					if (this.pmsSpeedVariationPerCheckEdit.Checked == true)
					{
						report.speedVariationPercentageHeaderXrLabel.Visible = true;
						report.machineSpeedVariationPercentageXrLabel.Visible = true;
						report.itemSpeedVariationPercentageXrLabel.Visible = true;
						report.speedVariationPercentageHeaderXrLabel.Left = left;
						report.machineSpeedVariationPercentageXrLabel.Left = left;
						report.itemSpeedVariationPercentageXrLabel.Left = left;
						left += report.machineSpeedVariationPercentageXrLabel.Width;
					}
					else
					{
						report.speedVariationPercentageHeaderXrLabel.Visible = false;
						report.machineSpeedVariationPercentageXrLabel.Visible = false;
						report.itemSpeedVariationPercentageXrLabel.Visible = false;
					}
					if (this.pmsProjectedPackersCheckEdit.Checked == true)
					{
						report.projectedPackersHeaderXrLabel.Visible = true;
						report.machineProjectedPackersXrLabel.Visible = true;
						report.itemProjectedPackersXrLabel.Visible = true;
						report.projectedPackersHeaderXrLabel.Left = left;
						report.machineProjectedPackersXrLabel.Left = left;
						report.itemProjectedPackersXrLabel.Left = left;
						left += report.machineProjectedPackersXrLabel.Width;
					}
					else
					{
						report.projectedPackersHeaderXrLabel.Visible = false;
						report.machineProjectedPackersXrLabel.Visible = false;
						report.itemProjectedPackersXrLabel.Visible = false;
					}
					if (this.pmsPackersCheckEdit.Checked == true)
					{
						report.packersHeaderXrLabel.Visible = true;
						report.machineAverageActualPackersXrLabel.Visible = true;
						report.itemAverageActualPackersXrLabel.Visible = true;
						report.packersHeaderXrLabel.Left = left;
						report.machineAverageActualPackersXrLabel.Left = left;
						report.itemAverageActualPackersXrLabel.Left = left;
						left += report.machineAverageActualPackersXrLabel.Width;
					}
					else
					{
						report.packersHeaderXrLabel.Visible = false;
						report.machineAverageActualPackersXrLabel.Visible = false;
						report.itemAverageActualPackersXrLabel.Visible = false;
					}
					if (this.pmsPackersVariationVolCheckEdit.Checked == true)
					{
						report.packersVariationVolumeHeaderXrLabel.Visible = true;
						report.machinePackersVariationVolumeXrLabel.Visible = true;
						report.itemPackersVariationVolumeXrLabel.Visible = true;
						report.packersVariationVolumeHeaderXrLabel.Left = left;
						report.machinePackersVariationVolumeXrLabel.Left = left;
						report.itemPackersVariationVolumeXrLabel.Left = left;
						left += report.machinePackersVariationVolumeXrLabel.Width;
					}
					else
					{
						report.packersVariationVolumeHeaderXrLabel.Visible = false;
						report.machinePackersVariationVolumeXrLabel.Visible = false;
						report.itemPackersVariationVolumeXrLabel.Visible = false;
					}
					if (this.pmsPackersVariationPerCheckEdit.Checked == true)
					{
						report.packersVariationPercentageHeaderXrLabel.Visible = true;
						report.machinePackersVariationPercentageXrLabel.Visible = true;
						report.itemPackersVariationPercentageXrLabel.Visible = true;
						report.packersVariationPercentageHeaderXrLabel.Left = left;
						report.machinePackersVariationPercentageXrLabel.Left = left;
						report.itemPackersVariationPercentageXrLabel.Left = left;
						left += report.machinePackersVariationPercentageXrLabel.Width;
					}
					else
					{
						report.packersVariationPercentageHeaderXrLabel.Visible = false;
						report.machinePackersVariationPercentageXrLabel.Visible = false;
						report.itemPackersVariationPercentageXrLabel.Visible = false;
					}
					if (this.pmsProjectedCostCheckEdit.Checked == true)
					{
						report.projectedCostHeaderXrLabel.Visible = true;
						report.machineProjectedCostXrLabel.Visible = true;
						report.itemProjectedCostXrLabel.Visible = true;
						report.projectedCostHeaderXrLabel.Left = left;
						report.machineProjectedCostXrLabel.Left = left;
						report.itemProjectedCostXrLabel.Left = left;
						left += report.machineProjectedCostXrLabel.Width;
					}
					else
					{
						report.projectedCostHeaderXrLabel.Visible = false;
						report.machineProjectedCostXrLabel.Visible = false;
						report.itemProjectedCostXrLabel.Visible = false;
					}
					if (this.pmsCostCheckEdit.Checked == true)
					{
						report.averageActualCostHeaderXrLabel.Visible = true;
						report.machineAverageCostXrLabel.Visible = true;
						report.itemAverageCostXrLabel.Visible = true;
						report.averageActualCostHeaderXrLabel.Left = left;
						report.machineAverageCostXrLabel.Left = left;
						report.itemAverageCostXrLabel.Left = left;
						left += report.machineAverageCostXrLabel.Width;
					}
					else
					{
						report.averageActualCostHeaderXrLabel.Visible = false;
						report.machineAverageCostXrLabel.Visible = false;
						report.itemAverageCostXrLabel.Visible = false;
					}
					if (this.pmsCostVariationCheckEdit.Checked == true)
					{
						report.costVariationHeaderXrLabel.Visible = true;
						report.machineCostVariationXrLabel.Visible = true;
						report.itemCostVariationXrLabel.Visible = true;
						report.costVariationHeaderXrLabel.Left = left;
						report.machineCostVariationXrLabel.Left = left;
						report.itemCostVariationXrLabel.Left = left;
						left += report.machineCostVariationXrLabel.Width;
					}
					else
					{
						report.costVariationHeaderXrLabel.Visible = false;
						report.machineCostVariationXrLabel.Visible = false;
						report.itemCostVariationXrLabel.Visible = false;
					}
					if (this.pmsCostVariationPerCheckEdit.Checked == true)
					{
						report.costVariationPercentageHeaderXrLabel.Visible = true;
						report.machineCostVariationPercentageXrLabel.Visible = true;
						report.itemCostVariationPercentageXrLabel.Visible = true;
						report.costVariationPercentageHeaderXrLabel.Left = left;
						report.machineCostVariationPercentageXrLabel.Left = left;
						report.itemCostVariationPercentageXrLabel.Left = left;
						left += report.machineCostVariationPercentageXrLabel.Width;
					}
					else
					{
						report.costVariationPercentageHeaderXrLabel.Visible = false;
						report.machineCostVariationPercentageXrLabel.Visible = false;
						report.itemCostVariationPercentageXrLabel.Visible = false;
					}
					if (this.pmsPricePerPieceCheckEdit.Checked == true)
					{
						report.pricePerPieceHeaderXrLabel.Visible = true;
						report.machinePricePerPieceXrLabel.Visible = true;
						report.itemPricePerPieceXrLabel.Visible = true;
						report.pricePerPieceHeaderXrLabel.Left = left;
						report.machinePricePerPieceXrLabel.Left = left;
						report.itemPricePerPieceXrLabel.Left = left;
						left += report.machinePricePerPieceXrLabel.Width;
					}
					else
					{
						report.pricePerPieceHeaderXrLabel.Visible = false;
						report.machinePricePerPieceXrLabel.Visible = false;
						report.itemPricePerPieceXrLabel.Visible = false;
					}
					if (this.pmsSalesVsPayrollCheckEdit.Checked == true)
					{
						report.salesVsPayrollHeaderXrLabel.Visible = true;
						report.machineSalesVsPayrollXrLabel.Visible = true;
						report.itemSalesVsPayrollXrLabel.Visible = true;
						report.salesVsPayrollHeaderXrLabel.Left = left;
						report.machineSalesVsPayrollXrLabel.Left = left;
						report.itemSalesVsPayrollXrLabel.Left = left;
						left += report.machineSalesVsPayrollXrLabel.Width;
					}
					else
					{
						report.salesVsPayrollHeaderXrLabel.Visible = false;
						report.machineSalesVsPayrollXrLabel.Visible = false;
						report.itemSalesVsPayrollXrLabel.Visible = false;
					}
					if (this.pmsPriceCheckEdit.Checked == true)
					{
						report.priceHeaderXrLabel.Visible = true;
						report.machinePriceXrLabel.Visible = true;
						report.itemPriceXrLabel.Visible = true;
						report.priceHeaderXrLabel.Left = left;
						report.machinePriceXrLabel.Left = left;
						report.itemPriceXrLabel.Left = left;
						left += report.machinePriceXrLabel.Width;
					}
					else
					{
						report.priceHeaderXrLabel.Visible = false;
						report.machinePriceXrLabel.Visible = false;
						report.itemPriceXrLabel.Visible = false;
					}
					if (this.pmsTotalSalesCheckEdit.Checked == true)
					{
						report.totalSalesHeaderXrLabel.Visible = true;
						report.machineTotalSalesXrLabel.Visible = true;
						report.itemTotalSalesXrLabel.Visible = true;
						report.totalSalesHeaderXrLabel.Left = left;
						report.machineTotalSalesXrLabel.Left = left;
						report.itemTotalSalesXrLabel.Left = left;
						left += report.machineTotalSalesXrLabel.Width;
					}
					else
					{
						report.totalSalesHeaderXrLabel.Visible = false;
						report.machineTotalSalesXrLabel.Visible = false;
						report.itemTotalSalesXrLabel.Visible = false;
					}
					report.printDateXrPageInfo.Left = left - 185;
					report.reportCriteriaXrLabel.Width = left - 190;
					report.reportTitleXrLabel.Width = left;
					report.headerXrPanel.Width = left;
					report.footerXrPanel.Width = left;
					report.itemHeaderXRLine.Width = left - 8;
					report.itemDescriptionXrLabel.Width = left - 418;
					report.pageNumberXrPageInfo.Left = left - 100;
					break;
				}
				case "ProductionShiftXtraReport":
				{
					ProductionShiftXtraReport report = (ProductionShiftXtraReport)m_Report;
					left = 67;
					if (this.pmsTotalMinutesCheckEdit.Checked == true)
					{
						report.minutesHeaderXrLabel.Visible = true;
						report.shiftTotalMinutesXRLabel.Visible = true;
						report.itemMinutesXrLabel.Visible = true;
						report.minutesHeaderXrLabel.Left = left;
						report.shiftTotalMinutesXRLabel.Left = left;
						report.itemMinutesXrLabel.Left = left;
						left += report.shiftTotalMinutesXRLabel.Width;
					}
					else
					{
						report.minutesHeaderXrLabel.Visible = false;
						report.shiftTotalMinutesXRLabel.Visible = false;
						report.itemMinutesXrLabel.Visible = false;
					}
					if (this.pmsQuantityCheckEdit.Checked == true)
					{
						report.quantityHeaderXrLabel.Visible = true;
						report.shiftQuantityXrLabel.Visible = true;
						report.itemQuantityXrLabel.Visible = true;
						report.quantityHeaderXrLabel.Left = left;
						report.shiftQuantityXrLabel.Left = left;
						report.itemQuantityXrLabel.Left = left;
						left += report.shiftQuantityXrLabel.Width;
					}
					else
					{
						report.quantityHeaderXrLabel.Visible = false;
						report.shiftQuantityXrLabel.Visible = false;
						report.itemQuantityXrLabel.Visible = false;
					}
					if (this.pmsProjectedSpeedCheckEdit.Checked == true)
					{
						report.machineSpeedHeaderXrLabel.Visible = true;
						report.shiftProjectedSpeedXrLabel.Visible = true;
						report.itemProjectedSpeedXrLabel.Visible = true;
						report.machineSpeedHeaderXrLabel.Left = left;
						report.shiftProjectedSpeedXrLabel.Left = left;
						report.itemProjectedSpeedXrLabel.Left = left;
						left += report.shiftProjectedSpeedXrLabel.Width;
					}
					else
					{
						report.machineSpeedHeaderXrLabel.Visible = false;
						report.shiftProjectedSpeedXrLabel.Visible = false;
						report.itemProjectedSpeedXrLabel.Left = left;
					}
					if (this.pmsAverageSpeedCheckEdit.Checked == true)
					{
						report.averageSpeedHeadeerXrLabel.Visible = true;
						report.shiftAverageSpeedXRLabel.Visible = true;
						report.itemAverageSpeedXrLabel.Visible = true;
						report.averageSpeedHeadeerXrLabel.Left = left;
						report.shiftAverageSpeedXRLabel.Left = left;
						report.itemAverageSpeedXrLabel.Left = left;
						left += report.shiftAverageSpeedXRLabel.Width;
					}
					else
					{
						report.averageSpeedHeadeerXrLabel.Visible = false;
						report.shiftAverageSpeedXRLabel.Visible = false;
						report.itemAverageSpeedXrLabel.Left = left;
					}
					if (this.pmsSpeedVariationVolCheckEdit.Checked == true)
					{
						report.speedVariationVolumeHeaderXrLabel.Visible = true;
						report.shiftSpeedVariationVolumeXrLabel.Visible = true;
						report.itemSpeedVariationXrLabel.Visible = true;
						report.speedVariationVolumeHeaderXrLabel.Left = left;
						report.shiftSpeedVariationVolumeXrLabel.Left = left;
						report.itemSpeedVariationXrLabel.Left = left;
						left += report.shiftSpeedVariationVolumeXrLabel.Width;
					}
					else
					{
						report.speedVariationVolumeHeaderXrLabel.Visible = false;
						report.shiftSpeedVariationVolumeXrLabel.Visible = false;
						report.itemSpeedVariationXrLabel.Visible = false;
					}
					if (this.pmsSpeedVariationPerCheckEdit.Checked == true)
					{
						report.speedVariationPercentageHeaderXrLabel.Visible = true;
						report.shiftSpeedVariationPercentageXrLabel.Visible = true;
						report.itemSpeedVariationPercentageXrLabel.Visible = true;
						report.speedVariationPercentageHeaderXrLabel.Left = left;
						report.shiftSpeedVariationPercentageXrLabel.Left = left;
						report.itemSpeedVariationPercentageXrLabel.Left = left;
						left += report.shiftSpeedVariationPercentageXrLabel.Width;
					}
					else
					{
						report.speedVariationPercentageHeaderXrLabel.Visible = false;
						report.shiftSpeedVariationPercentageXrLabel.Visible = false;
						report.itemSpeedVariationPercentageXrLabel.Visible = false;
					}
					if (this.pmsProjectedPackersCheckEdit.Checked == true)
					{
						report.projectedPackersHeaderXrLabel.Visible = true;
						report.shiftProjectedPackersXrLabel.Visible = true;
						report.itemProjectedPackersXrLabel.Visible = true;
						report.projectedPackersHeaderXrLabel.Left = left;
						report.shiftProjectedPackersXrLabel.Left = left;
						report.itemProjectedPackersXrLabel.Left = left;
						left += report.shiftProjectedPackersXrLabel.Width;
					}
					else
					{
						report.projectedPackersHeaderXrLabel.Visible = false;
						report.shiftProjectedPackersXrLabel.Visible = false;
						report.itemProjectedPackersXrLabel.Visible = false;
					}
					if (this.pmsPackersCheckEdit.Checked == true)
					{
						report.packersHeaderXrLabel.Visible = true;
						report.shiftAverageActualPackersXrLabel.Visible = true;
						report.itemAverageActualPackersXrLabel.Visible = true;
						report.packersHeaderXrLabel.Left = left;
						report.shiftAverageActualPackersXrLabel.Left = left;
						report.itemAverageActualPackersXrLabel.Left = left;
						left += report.shiftAverageActualPackersXrLabel.Width;
					}
					else
					{
						report.packersHeaderXrLabel.Visible = false;
						report.shiftAverageActualPackersXrLabel.Visible = false;
						report.itemAverageActualPackersXrLabel.Visible = false;
					}
					if (this.pmsPackersVariationVolCheckEdit.Checked == true)
					{
						report.packersVariationVolumeHeaderXrLabel.Visible = true;
						report.shiftPackersVariationVolumeXrLabel.Visible = true;
						report.itemPackersVariationVolumeXrLabel.Visible = true;
						report.packersVariationVolumeHeaderXrLabel.Left = left;
						report.shiftPackersVariationVolumeXrLabel.Left = left;
						report.itemPackersVariationVolumeXrLabel.Left = left;
						left += report.shiftPackersVariationVolumeXrLabel.Width;
					}
					else
					{
						report.packersVariationVolumeHeaderXrLabel.Visible = false;
						report.shiftPackersVariationVolumeXrLabel.Visible = false;
						report.itemPackersVariationVolumeXrLabel.Visible = false;
					}
					if (this.pmsPackersVariationPerCheckEdit.Checked == true)
					{
						report.packersVariationPercentageHeaderXrLabel.Visible = true;
						report.shiftPackersVariationPercentageXrLabel.Visible = true;
						report.itemPackersVariationPercentageXrLabel.Visible = true;
						report.packersVariationPercentageHeaderXrLabel.Left = left;
						report.shiftPackersVariationPercentageXrLabel.Left = left;
						report.itemPackersVariationPercentageXrLabel.Left = left;
						left += report.shiftPackersVariationPercentageXrLabel.Width;
					}
					else
					{
						report.packersVariationPercentageHeaderXrLabel.Visible = false;
						report.shiftPackersVariationPercentageXrLabel.Visible = false;
						report.itemPackersVariationPercentageXrLabel.Visible = false;
					}
					if (this.pmsProjectedCostCheckEdit.Checked == true)
					{
						report.projectedCostHeaderXrLabel.Visible = true;
						report.shiftProjectedCostXrLabel.Visible = true;
						report.itemProjectedCostXrLabel.Visible = true;
						report.projectedCostHeaderXrLabel.Left = left;
						report.shiftProjectedCostXrLabel.Left = left;
						report.itemProjectedCostXrLabel.Left = left;
						left += report.shiftProjectedCostXrLabel.Width;
					}
					else
					{
						report.projectedCostHeaderXrLabel.Visible = false;
						report.shiftProjectedCostXrLabel.Visible = false;
						report.itemProjectedCostXrLabel.Visible = false;
					}
					if (this.pmsCostCheckEdit.Checked == true)
					{
						report.averageActualCostHeaderXrLabel.Visible = true;
						report.shiftAverageCostXrLabel.Visible = true;
						report.itemAverageCostXrLabel.Visible = true;
						report.averageActualCostHeaderXrLabel.Left = left;
						report.shiftAverageCostXrLabel.Left = left;
						report.itemAverageCostXrLabel.Left = left;
						left += report.shiftAverageCostXrLabel.Width;
					}
					else
					{
						report.averageActualCostHeaderXrLabel.Visible = false;
						report.shiftAverageCostXrLabel.Visible = false;
						report.itemAverageCostXrLabel.Visible = false;
					}
					if (this.pmsCostVariationCheckEdit.Checked == true)
					{
						report.costVariationHeaderXrLabel.Visible = true;
						report.shiftCostVariationXrLabel.Visible = true;
						report.itemCostVariationXrLabel.Visible = true;
						report.costVariationHeaderXrLabel.Left = left;
						report.shiftCostVariationXrLabel.Left = left;
						report.itemCostVariationXrLabel.Left = left;
						left += report.shiftCostVariationXrLabel.Width;
					}
					else
					{
						report.costVariationHeaderXrLabel.Visible = false;
						report.shiftCostVariationXrLabel.Visible = false;
						report.itemCostVariationXrLabel.Visible = false;
					}
					if (this.pmsCostVariationPerCheckEdit.Checked == true)
					{
						report.costVariationPercentageHeaderXrLabel.Visible = true;
						report.shiftCostVariationPercentageXrLabel.Visible = true;
						report.itemCostVariationPercentageXrLabel.Visible = true;
						report.costVariationPercentageHeaderXrLabel.Left = left;
						report.shiftCostVariationPercentageXrLabel.Left = left;
						report.itemCostVariationPercentageXrLabel.Left = left;
						left += report.shiftCostVariationPercentageXrLabel.Width;
					}
					else
					{
						report.costVariationPercentageHeaderXrLabel.Visible = false;
						report.shiftCostVariationPercentageXrLabel.Visible = false;
						report.itemCostVariationPercentageXrLabel.Visible = false;
					}
					if (this.pmsPricePerPieceCheckEdit.Checked == true)
					{
						report.pricePerPieceHeaderXrLabel.Visible = true;
						report.shiftPricePerPieceXrLabel.Visible = true;
						report.itemPricePerPieceXrLabel.Visible = true;
						report.pricePerPieceHeaderXrLabel.Left = left;
						report.shiftPricePerPieceXrLabel.Left = left;
						report.itemPricePerPieceXrLabel.Left = left;
						left += report.shiftPricePerPieceXrLabel.Width;
					}
					else
					{
						report.pricePerPieceHeaderXrLabel.Visible = false;
						report.shiftPricePerPieceXrLabel.Visible = false;
						report.itemPricePerPieceXrLabel.Visible = false;
					}
					if (this.pmsSalesVsPayrollCheckEdit.Checked == true)
					{
						report.salesVsPayrollHeaderXrLabel.Visible = true;
						report.shiftSalesVsPayrollXrLabel.Visible = true;
						report.itemSalesVsPayrollXrLabel.Visible = true;
						report.salesVsPayrollHeaderXrLabel.Left = left;
						report.shiftSalesVsPayrollXrLabel.Left = left;
						report.itemSalesVsPayrollXrLabel.Left = left;
						left += report.shiftSalesVsPayrollXrLabel.Width;
					}
					else
					{
						report.salesVsPayrollHeaderXrLabel.Visible = false;
						report.shiftSalesVsPayrollXrLabel.Visible = false;
						report.itemSalesVsPayrollXrLabel.Visible = false;
					}
					if (this.pmsPriceCheckEdit.Checked == true)
					{
						report.priceHeaderXrLabel.Visible = true;
						report.shiftPriceXrLabel.Visible = true;
						report.itemPriceXrLabel.Visible = true;
						report.priceHeaderXrLabel.Left = left;
						report.shiftPriceXrLabel.Left = left;
						report.itemPriceXrLabel.Left = left;
						left += report.shiftPriceXrLabel.Width;
					}
					else
					{
						report.priceHeaderXrLabel.Visible = false;
						report.shiftPriceXrLabel.Visible = false;
						report.itemPriceXrLabel.Visible = false;
					}
					if (this.pmsTotalSalesCheckEdit.Checked == true)
					{
						report.totalSalesHeaderXrLabel.Visible = true;
						report.shiftTotalSalesXrLabel.Visible = true;
						report.itemTotalSalesXrLabel.Visible = true;
						report.totalSalesHeaderXrLabel.Left = left;
						report.shiftTotalSalesXrLabel.Left = left;
						report.itemTotalSalesXrLabel.Left = left;
						left += report.shiftTotalSalesXrLabel.Width;
					}
					else
					{
						report.totalSalesHeaderXrLabel.Visible = false;
						report.shiftTotalSalesXrLabel.Visible = false;
						report.itemTotalSalesXrLabel.Visible = false;
					}
					report.printDateXrPageInfo.Left = left - 185;
					report.reportCriteriaXrLabel.Width = left - 190;
					report.reportTitleXrLabel.Width = left;
					report.headerXrPanel.Width = left;
					report.footerXrPanel.Width = left;
					report.itemHeaderXRLine.Width = left - 8;
					report.itemDescriptionXrLabel.Width = left - 418;
					report.pageNumberXrPageInfo.Left = left - 100;
					break;
				}
				case "ProductionEntriesXtraReport":
				{
					ProductionXtraReport report = (ProductionXtraReport)m_Report;
					if (this.productionDateCheckEdit.Checked == true)
					{
						report.dateDetailXrLabel.Visible = true;
						report.dateHeaderXrLabel.Visible = true;
						report.dateHeaderXrLabel.Left = left;
						report.dateDetailXrLabel.Left = left;
						report.dateHeaderXrLabel.Width += additionalWidth;
						report.dateDetailXrLabel.Width += additionalWidth;
						left += report.dateDetailXrLabel.Width;
					}
					else
					{
						report.dateHeaderXrLabel.Visible = false;
						report.dateDetailXrLabel.Visible = false;
					}
					if (this.productionShiftCheckEdit.Checked == true)
					{
						report.shiftHeaderXrLabel.Visible = true;
						report.shiftDetailXrLabel.Visible = true;
						report.shiftHeaderXrLabel.Left = left;
						report.shiftDetailXrLabel.Left = left;
						left += report.shiftDetailXrLabel.Width;
					}
					else
					{
						report.shiftHeaderXrLabel.Visible = false;
						report.shiftDetailXrLabel.Visible = false;
					}
					if (this.productionCustomerNameCheckEdit.Checked == true)
					{
						report.customerNameHeaderXrLabel.Visible = true;
						report.customerNameDetailXrLabel.Visible = true;
						report.customerNameHeaderXrLabel.Left = left;
						report.customerNameDetailXrLabel.Left = left;
						report.customerNameDetailXrLabel.Width += additionalWidth;
						report.customerNameHeaderXrLabel.Width += additionalWidth;
						left += report.customerNameDetailXrLabel.Width;
					}
					else
					{
						report.customerNameHeaderXrLabel.Visible = false;
						report.customerNameDetailXrLabel.Visible = false;
					}
					if (this.productionItemCodeCheckEdit.Checked == true)
					{
						report.itemCodeHeaderXrLabel.Visible = true;
						report.itemCodeDetailXrLabel.Visible = true;
						report.itemCodeHeaderXrLabel.Left = left;
						report.itemCodeDetailXrLabel.Left = left;
						report.itemCodeDetailXrLabel.Width += additionalWidth;
						report.itemCodeHeaderXrLabel.Width += additionalWidth;
						left += report.itemCodeDetailXrLabel.Width;
					}
					else
					{
						report.itemCodeHeaderXrLabel.Visible = false;
						report.itemCodeDetailXrLabel.Visible = false;
					}
					if (this.productionItemDescriptionCheckEdit.Checked == true)
					{
						report.itemDescriptionHeaderXrLabel.Visible = true;
						report.itemDescriptionDetailXrLabel.Visible = true;
						report.itemDescriptionHeaderXrLabel.Left = left;
						report.itemDescriptionDetailXrLabel.Left = left;
						report.itemDescriptionDetailXrLabel.Width += additionalWidth;
						report.itemDescriptionHeaderXrLabel.Width += additionalWidth;
						left += report.itemDescriptionDetailXrLabel.Width;
					}
					else
					{
						report.itemDescriptionHeaderXrLabel.Visible = false;
						report.itemDescriptionDetailXrLabel.Visible = false;
					}
					if (this.productionLotCheckEdit.Checked == true)
					{
						report.lotHeadeerXrLabel.Visible = true;
						report.lotDetailXrLabel.Visible = true;
						report.lotHeadeerXrLabel.Left = left;
						report.lotDetailXrLabel.Left = left;
						report.lotDetailXrLabel.Width += additionalWidth;
						report.lotHeadeerXrLabel.Width += additionalWidth;
						left += report.lotDetailXrLabel.Width;
					}
					else
					{
						report.lotHeadeerXrLabel.Visible = false;
						report.lotDetailXrLabel.Visible = false;
					}
					if (this.productionStartTimeCheckEdit.Checked == true)
					{
						report.startTimeHeaderXrLabel.Visible = true;
						report.startTimeDetailXrLabel.Visible = true;
						report.startTimeHeaderXrLabel.Left = left;
						report.startTimeDetailXrLabel.Left = left;
						left += report.startTimeDetailXrLabel.Width;
					}
					else
					{
						report.startTimeHeaderXrLabel.Visible = false;
						report.startTimeDetailXrLabel.Visible = false;
					}
					if (this.productionStopTimeCheckEdit.Checked == true)
					{
						report.stopTimeHeaderXrLabel.Visible = true;
						report.stopTimeDetailXrLabel.Visible = true;
						report.stopTimeHeaderXrLabel.Left = left;
						report.stopTimeDetailXrLabel.Left = left;
						left += report.stopTimeDetailXrLabel.Width;
					}
					else
					{
						report.stopTimeHeaderXrLabel.Visible = false;
						report.stopTimeDetailXrLabel.Visible = false;
					}
					if (this.productionTotalHoursCheckEdit.Checked == true)
					{
						report.totalHoursHeaderXrLabel.Visible = true;
						report.totalHoursDetailXrLabel.Visible = true;
						report.totalHoursFooterXrLabel.Visible = true;
						report.totalHoursHeaderXrLabel.Left = left;
						report.totalHoursDetailXrLabel.Left = left;
						report.totalHoursFooterXrLabel.Left = left - 5;
						left += report.totalHoursDetailXrLabel.Width;
					}
					else
					{
						report.totalHoursHeaderXrLabel.Visible = false;
						report.totalHoursDetailXrLabel.Visible = false;
						report.totalHoursFooterXrLabel.Visible = false;
					}
					if (this.productionTotalMinutesCheckEdit.Checked == true)
					{
						report.totalMinutesHeaderXrLabel.Visible = true;
						report.totalMinutesDetailXrLabel.Visible = true;
						report.totalMinutesHeaderXrLabel.Left = left;
						report.totalMinutesDetailXrLabel.Left = left;
						left += report.totalMinutesDetailXrLabel.Width;
					}
					else
					{
						report.totalMinutesHeaderXrLabel.Visible = false;
						report.totalMinutesDetailXrLabel.Visible = false;
					}
					if (this.productionPOCheckEdit.Checked == true)
					{
						report.poHeaderXrLabel.Visible = true;
						report.poDetailXrLabel.Visible = true;
						report.poHeaderXrLabel.Left = left;
						report.poDetailXrLabel.Left = left;
						report.poDetailXrLabel.Width += additionalWidth;
						report.poHeaderXrLabel.Width += additionalWidth;
						left += report.poDetailXrLabel.Width;
					}
					else
					{
						report.poHeaderXrLabel.Visible = false;
						report.poDetailXrLabel.Visible = false;
					}
					if (this.productionQuantityCheckEdit.Checked == true)
					{
						report.quantityHeaderXrLabel.Visible = true;
						report.quantityDetailXrLabel.Visible = true;
						report.quantityFooterXrLabel.Visible = true;
						report.quantityHeaderXrLabel.Left = left;
						report.quantityDetailXrLabel.Left = left;
						report.quantityFooterXrLabel.Left = left;
						report.quantityDetailXrLabel.Width += additionalWidth;
						report.quantityFooterXrLabel.Width = report.quantityDetailXrLabel.Width;
						report.quantityHeaderXrLabel.Width += additionalWidth;
						left += report.quantityDetailXrLabel.Width;
					}
					else
					{
						report.quantityHeaderXrLabel.Visible = false;
						report.quantityDetailXrLabel.Visible = false;
						report.quantityFooterXrLabel.Visible = false;
					}
					if (this.productionExpectedCheckEdit.Checked == true)
					{
						report.expectedHeaderXrLabel.Visible = true;
						report.expectedDetailXrLabel.Visible = true;
						report.expectedFooterXrLabel.Visible = true;
						report.expectedHeaderXrLabel.Left = left;
						report.expectedDetailXrLabel.Left = left;
						report.expectedFooterXrLabel.Left = left;
						left += report.expectedDetailXrLabel.Width;
					}
					else
					{
						report.expectedHeaderXrLabel.Visible = false;
						report.expectedDetailXrLabel.Visible = false;
						report.expectedFooterXrLabel.Visible = false;
					}
					report.uomHeaderXrLabel.Visible = false;
					report.uomDetailXrLabel.Visible = false;
					if (this.productionDifferenceCheckEdit.Checked == true)
					{
						report.differenceHeaderXrLabel.Visible = true;
						report.differenceDetailXrLabel.Visible = true;
						report.differenceFooterXrLabel.Visible = true;
						report.differenceHeaderXrLabel.Left = left;
						report.differenceDetailXrLabel.Left = left;
						report.differenceFooterXrLabel.Left = left;
						left += report.differenceDetailXrLabel.Width;
					}
					else
					{
						report.differenceHeaderXrLabel.Visible = false;
						report.differenceDetailXrLabel.Visible = false;
						report.differenceFooterXrLabel.Visible = false;
					}
					if (this.productionMachineLineCheckEdit.Checked == true)
					{
						report.machineLineHeaderXrLabel.Visible = true;
						report.machineLineDetailXrLabel.Visible = true;
						report.machineLineHeaderXrLabel.Left = left;
						report.machineLineDetailXrLabel.Left = left;
						left += report.machineLineDetailXrLabel.Width;
					}
					else
					{
						report.machineLineHeaderXrLabel.Visible = false;
						report.machineLineDetailXrLabel.Visible = false;
					}
					report.machineSpeedHeaderXrLabel.Visible = false;
					report.machineSpeedDetailXrLabel.Visible = false;
					if (this.productionActualSpeedCheckEdit.Checked == true)
					{
						report.actualSpeedHeaderXrLabel.Visible = true;
						report.actualSpeedDetailXrLabel.Visible = true;
						report.actualSpeedFooterXrLabel.Visible = true;
						report.actualSpeedHeaderXrLabel.Left = left;
						report.actualSpeedDetailXrLabel.Left = left;
						report.actualSpeedFooterXrLabel.Left = left - 5;
						left += report.actualSpeedDetailXrLabel.Width;
					}
					else
					{
						report.actualSpeedHeaderXrLabel.Visible = false;
						report.actualSpeedDetailXrLabel.Visible = false;
						report.actualSpeedFooterXrLabel.Visible = false;
					}
					if (this.productionPackersCheckEdit.Checked == true)
					{
						report.packersHeaderXrLabel.Visible = true;
						report.packersDetailXrLabel.Visible = true;
						report.packersHeaderXrLabel.Left = left;
						report.packersDetailXrLabel.Left = left;
						left += report.packersDetailXrLabel.Width;
					}
					else
					{
						report.packersHeaderXrLabel.Visible = false;
						report.packersDetailXrLabel.Visible = false;
					}
					report.projectedPackersHeaderXrLabel.Visible = false;
					report.projectedPackersDetailXrLabel.Visible = false;
					report.reasonCodeHeaderXrLabel.Visible = false;
					report.reasonCodeDetailXrLabel.Visible = false;
					if (this.productionTotalPayrollCheckEdit.Checked == true)
					{
						report.totalPayrollHeaderXrLabel.Visible = true;
						report.totalPayrollDetailXrLabel.Visible = true;
						report.totalPayrollFooterXrLabel.Visible = true;
						report.totalPayrollHeaderXrLabel.Left = left;
						report.totalPayrollDetailXrLabel.Left = left;
						report.totalPayrollFooterXrLabel.Left = left;
						left += report.totalPayrollDetailXrLabel.Width;
					}
					else
					{
						report.totalPayrollHeaderXrLabel.Visible = false;
						report.totalPayrollDetailXrLabel.Visible = false;
						report.totalPayrollFooterXrLabel.Visible = false;
					}
					report.printDateXrPageInfo.Left = left - 185;
					report.reportCriteriaXrLabel.Width = left - 190;
					report.reportTitleXrLabel.Width = left;
					report.headerXrPanel.Width = left;
					report.footerXrPanel.Width = left;
					report.pageNumberXrPageInfo.Left = left - 100;
					break;
				}
				case "CostingXtraReport":
				case "CostingSmallXtraReport":
				case "FinancialCostingXtraReport":
				{
					CostingXtraReport report = (CostingXtraReport)m_Report;
					if (this.costingProductionDateCheckEdit.Checked == true)
					{
						report.dateHeaderXRLabel.Visible = true;
						report.dateDetailXrLabel.Visible = true;
						report.dateHeaderXRLabel.Left = left;
						report.dateDetailXrLabel.Left = left;
						left += report.dateDetailXrLabel.Width;
					}
					else
					{
						report.dateHeaderXRLabel.Visible = false;
						report.dateDetailXrLabel.Visible = false;
					}
					if (this.costingShiftCheckEdit.Checked == true)
					{
						report.shiftHeaderXRLabel.Visible = true;
						report.shiftDetailXrLabel.Visible = true;
						report.shiftHeaderXRLabel.Left = left;
						report.shiftDetailXrLabel.Left = left;
						left += report.shiftDetailXrLabel.Width;
					}
					else
					{
						report.shiftHeaderXRLabel.Visible = false;
						report.shiftDetailXrLabel.Visible = false;
					}
					if (this.costingCustomerCheckEdit.Checked)
					{
						report.customerNameHeaderXRLabel.Visible = true;
						report.customerNameDetailXrLabel.Visible = true;
						report.customerNameHeaderXRLabel.Left = left;
						report.customerNameDetailXrLabel.Left = left;
						left += report.customerNameDetailXrLabel.Width;
					}
					else
					{
						report.customerNameHeaderXRLabel.Visible = false;
						report.customerNameDetailXrLabel.Visible = false;
					}
					if (this.costingLotCheckEdit.Checked)
					{
						report.lotHeaderXRLabel.Visible = true;
						report.lotDetailXrLabel.Visible = true;
						report.lotHeaderXRLabel.Left = left;
						report.lotDetailXrLabel.Left = left;
						left += report.lotDetailXrLabel.Width;
					}
					else
					{
						report.lotHeaderXRLabel.Visible = false;
						report.lotDetailXrLabel.Visible = false;
					}
					if (costingItemCodeCheckEdit.Checked)
					{
						report.itemCodeHeaderXRLabel.Visible = true;
						report.itemCodeDetailXrLabel.Visible = true;
						report.itemCodeHeaderXRLabel.Left = left;
						report.itemCodeDetailXrLabel.Left = left;
						left += report.itemCodeDetailXrLabel.Width;
					}
					else
					{
						report.itemCodeHeaderXRLabel.Visible = false;
						report.itemCodeDetailXrLabel.Visible = false;
					}
					if (costingItemDescriptionCheckEdit.Checked)
					{
						report.itemDescriptionHeaderXRLabel.Visible = true;
						report.itemDescriptionDetailXrLabel.Visible = true;
						report.itemDescriptionHeaderXRLabel.Left = left;
						report.itemDescriptionDetailXrLabel.Left = left;
						left += report.itemDescriptionDetailXrLabel.Width;
					}
					else
					{
						report.itemDescriptionHeaderXRLabel.Visible = false;
						report.itemDescriptionDetailXrLabel.Visible = false;
					}
					if (this.costingStartTimeCheckEdit.Checked == true)
					{
						report.startTimeHeaderXRLabel.Visible = true;
						report.startTimeDetailXrLabel.Visible = true;
						report.startTimeHeaderXRLabel.Left = left;
						report.startTimeDetailXrLabel.Left = left;
						left += report.startTimeDetailXrLabel.Width;
					}
					else
					{
						report.startTimeHeaderXRLabel.Visible = false;
						report.startTimeDetailXrLabel.Visible = false;
					}
					if (this.costingStopTimeCheckEdit.Checked == true)
					{
						report.stopTimeHeaderXRLabel.Visible = true;
						report.stopTimeDetailXrLabel.Visible = true;
						report.stopTimeHeaderXRLabel.Left = left;
						report.stopTimeDetailXrLabel.Left = left;
						left += report.stopTimeDetailXrLabel.Width;
					}
					else
					{
						report.stopTimeHeaderXRLabel.Visible = false;
						report.stopTimeDetailXrLabel.Visible = false;
					}
					if (this.costingTotalHoursCheckEdit.Checked)
					{
						report.totalHoursHeaderXRLabel.Visible = true;
						report.totalHoursDetailXrLabel.Visible = true;
						report.totalHoursFooterXRLabel.Visible = true;
						report.totalHoursHeaderXRLabel.Left = left;
						report.totalHoursDetailXrLabel.Left = left;
						report.totalHoursFooterXRLabel.Left = left;
						left += report.totalHoursDetailXrLabel.Width;
					}
					else
					{
						report.totalHoursHeaderXRLabel.Visible = false;
						report.totalHoursDetailXrLabel.Visible = false;
						report.totalHoursFooterXRLabel.Visible = false;
					}
					if (this.costingTotalMinutesCheckEdit.Checked)
					{
						report.totalMinutesHeaderXRLabel.Visible = true;
						report.totalMinutesDetailXrLabel.Visible = true;
						report.totalMinutesFooterXRLabel.Visible = true;
						report.totalMinutesHeaderXRLabel.Left = left;
						report.totalMinutesDetailXrLabel.Left = left;
						report.totalMinutesFooterXRLabel.Left = left;
						left += report.totalMinutesDetailXrLabel.Width;
					}
					else
					{
						report.totalMinutesHeaderXRLabel.Visible = false;
						report.totalMinutesDetailXrLabel.Visible = false;
						report.totalMinutesFooterXRLabel.Visible = false;
					}
					if (costingQuantityCheckEdit.Checked)
					{
						report.quantityHeaderXRLabel.Visible = true;
						report.quantityDetailXrLabel.Visible = true;
						report.quantityFooterXRLabel.Visible = true;
						report.quantityHeaderXRLabel.Left = left;
						report.quantityDetailXrLabel.Left = left;
						report.quantityFooterXRLabel.Left = left;
						left += report.quantityDetailXrLabel.Width;
					}
					else
					{
						report.quantityHeaderXRLabel.Visible = false;
						report.quantityDetailXrLabel.Visible = false;
						report.quantityFooterXRLabel.Visible = false;
					}
					if (costingExpectedCheckEdit.Checked)
					{
						report.expectedHeaderXRLabel.Visible = true;
						report.expectedDetailXrLabel.Visible = true;
						report.expectedFooterXRLabel.Visible = true;
						report.expectedHeaderXRLabel.Left = left;
						report.expectedDetailXrLabel.Left = left;
						report.expectedFooterXRLabel.Left = left;
						left += report.expectedDetailXrLabel.Width;
					}
					else
					{
						report.expectedHeaderXRLabel.Visible = false;
						report.expectedDetailXrLabel.Visible = false;
						report.expectedFooterXRLabel.Visible = false;
					}
					if (this.costingDifferenceCheckEdit.Checked == true)
					{
						report.differenceHeaderXRLabel.Visible = true;
						report.differenceDetailXrLabel.Visible = true;
						report.differenceFooterXRLabel.Visible = true;
						report.differenceHeaderXRLabel.Left = left;
						report.differenceDetailXrLabel.Left = left;
						report.differenceFooterXRLabel.Left = left;
						left += report.differenceDetailXrLabel.Width;
					}
					else
					{
						report.differenceHeaderXRLabel.Visible = false;
						report.differenceDetailXrLabel.Visible = false;
						report.differenceFooterXRLabel.Visible = false;
					}
					if (this.costingMachineLineCheckEdit.Checked == true)
					{
						report.machineLineHeaderXRLabel.Visible = true;
						report.machineLineDetailXrLabel.Visible = true;
						report.machineLineHeaderXRLabel.Left = left;
						report.machineLineDetailXrLabel.Left = left;
						left += report.machineLineDetailXrLabel.Width;
					}
					else
					{
						report.machineLineHeaderXRLabel.Visible = false;
						report.machineLineDetailXrLabel.Visible = false;
					}
					if (this.costingMachineSpeedCheckEdit.Checked)
					{
						report.speedHeaderXRLabel.Visible = true;
						report.speedDetailXrLabel.Visible = true;
						report.speedHeaderXRLabel.Left = left;
						report.speedDetailXrLabel.Left = left;
						left += report.speedDetailXrLabel.Width;
					}
					else
					{
						report.speedHeaderXRLabel.Visible = false;
						report.speedDetailXrLabel.Visible = false;
					}
					if (this.costingActualSpeedCheckEdit.Checked)
					{
						report.actualSpeedHeaderXRLabel.Visible = true;
						report.actualSpeedDetailXrLabel.Visible = true;
						report.actualSpeedFooterXRLabel.Visible = true;
						report.actualSpeedHeaderXRLabel.Left = left;
						report.actualSpeedDetailXrLabel.Left = left;
						report.actualSpeedFooterXRLabel.Left = left;
						left += report.actualSpeedDetailXrLabel.Width;
					}
					else
					{
						report.actualSpeedHeaderXRLabel.Visible = false;
						report.actualSpeedDetailXrLabel.Visible = false;
						report.actualSpeedFooterXRLabel.Visible = false;
					}
					if (costingOperatorsCheckEdit.Checked)
					{
						report.operatorHeaderXRLabel.Visible = true;
						report.operatorDetailXrLabel.Visible = true;
						report.operatorHeaderXRLabel.Left = left;
						report.operatorDetailXrLabel.Left = left;
						left += report.operatorDetailXrLabel.Width;
					}
					else
					{
						report.operatorHeaderXRLabel.Visible = false;
						report.operatorDetailXrLabel.Visible = false;
					}
					if (costingPackersCheckEdit.Checked)
					{
						report.packerHeaderXRLabel.Visible = true;
						report.packerDetailXrLabel.Visible = true;
						report.packerHeaderXRLabel.Left = left;
						report.packerDetailXrLabel.Left = left;
						left += report.packerDetailXrLabel.Width;
					}
					else
					{
						report.packerHeaderXRLabel.Visible = false;
						report.packerDetailXrLabel.Visible = false;
					}
					if (this.costingSupersCheckEdit.Checked == true)
					{
						report.superHeaderXRLabel.Visible = true;
						report.superDetailXrLabel.Visible = true;
						report.superHeaderXRLabel.Left = left;
						report.superDetailXrLabel.Left = left;
						left += report.superDetailXrLabel.Width;
					}
					else
					{
						report.superHeaderXRLabel.Visible = false;
						report.superDetailXrLabel.Visible = false;
					}
					if (this.costingPriceCheckEdit.Checked == true)
					{
						report.priceHeaderXRLabel.Visible = true;
						report.priceDetailXrLabel.Visible = true;
						report.priceFooterXrLabel.Visible = true;
						report.priceHeaderXRLabel.Left = left;
						report.priceDetailXrLabel.Left = left;
						report.priceFooterXrLabel.Left = left;
						left += report.priceDetailXrLabel.Width;
					}
					else
					{
						report.priceHeaderXRLabel.Visible = false;
						report.priceDetailXrLabel.Visible = false;
						report.priceFooterXrLabel.Visible = false;
					}
					if (this.costingPayrollCheckEdit.Checked)
					{
						report.payrollHeaderXRLabel.Visible = true;
						report.payrollDetailXrLabel.Visible = true;
						report.payrollFooterXrLabel.Visible = true;
						report.payrollHeaderXRLabel.Left = left;
						report.payrollDetailXrLabel.Left = left;
						report.payrollFooterXrLabel.Left = left;
						left += report.payrollDetailXrLabel.Width;
					}
					else
					{
						report.payrollHeaderXRLabel.Visible = false;
						report.payrollDetailXrLabel.Visible = false;
						report.payrollFooterXrLabel.Visible = false;
					}
					if (this.costingRebateCheckEdit.Checked)
					{
						report.rebateHeaderXRLabel.Visible = true;
						report.rebateDetailXrLabel.Visible = true;
						report.rebateFooterXrLabel.Visible = true;
						report.rebateHeaderXRLabel.Left = left;
						report.rebateDetailXrLabel.Left = left;
						report.rebateFooterXrLabel.Left = left;
						left += report.rebateDetailXrLabel.Width;
					}
					else
					{
						report.rebateHeaderXRLabel.Visible = false;
						report.rebateDetailXrLabel.Visible = false;
						report.rebateFooterXrLabel.Visible = false;
					}
					if (costingFreightCheckEdit.Checked)
					{
						report.freightHeaderXRLabel.Visible = true;
						report.freightDetailXrLabel.Visible = true;
						report.freightFooterXrLabel.Visible = true;
						report.freightHeaderXRLabel.Left = left;
						report.freightDetailXrLabel.Left = left;
						report.freightFooterXrLabel.Left = left;
						left += report.freightDetailXrLabel.Width;
					}
					else
					{
						report.freightHeaderXRLabel.Visible = false;
						report.freightDetailXrLabel.Visible = false;
						report.freightFooterXrLabel.Visible = false;
					}
					if (costingFilmCheckEdit.Checked)
					{
						report.filmHeaderXRLabel.Visible = true;
						report.filmDetailXrLabel.Visible = true;
						report.filmFooterXrLabel.Visible = true;
						report.filmHeaderXRLabel.Left = left;
						report.filmDetailXrLabel.Left = left;
						report.filmFooterXrLabel.Left = left;
						left += report.filmDetailXrLabel.Width;
					}
					else
					{
						report.filmHeaderXRLabel.Visible = false;
						report.filmDetailXrLabel.Visible = false;
						report.filmFooterXrLabel.Visible = false;
					}
					if (this.costingBoxesCheckEdit.Checked == true)
					{
						report.boxesHeaderXRLabel.Visible = true;
						report.boxesDetailXrLabel.Visible = true;
						report.boxesFooterXrLabel.Visible = true;
						report.boxesHeaderXRLabel.Left = left;
						report.boxesDetailXrLabel.Left = left;
						report.boxesFooterXrLabel.Left = left;
						left += report.boxesDetailXrLabel.Width;
					}
					else
					{
						report.boxesHeaderXRLabel.Visible = false;
						report.boxesDetailXrLabel.Visible = false;
						report.boxesFooterXrLabel.Visible = false;
					}
					if (this.costingStretchWrapCheckEdit.Checked == true)
					{
						report.stretchWrapHeaderXRLabel.Visible = true;
						report.stretchWrapDetailXrLabel.Visible = true;
						report.stretchWrapFooterXrLabel.Visible = true;
						report.stretchWrapHeaderXRLabel.Left = left;
						report.stretchWrapDetailXrLabel.Left = left;
						report.stretchWrapFooterXrLabel.Left = left;
						left += report.stretchWrapDetailXrLabel.Width;
					}
					else
					{
						report.stretchWrapHeaderXRLabel.Visible = false;
						report.stretchWrapDetailXrLabel.Visible = false;
						report.stretchWrapFooterXrLabel.Visible = false;
					}
					if (this.costingPalletsCheckEdit.Checked)
					{
						report.palletsHeaderXRLabel.Visible = true;
						report.palletsDetailXrLabel.Visible = true;
						report.palletsFooterXrLabel.Visible = true;
						report.palletsHeaderXRLabel.Left = left;
						report.palletsDetailXrLabel.Left = left;
						report.palletsFooterXrLabel.Left = left;
						left += report.palletsDetailXrLabel.Width;
					}
					else
					{
						report.palletsHeaderXRLabel.Visible = false;
						report.palletsDetailXrLabel.Visible = false;
						report.palletsFooterXrLabel.Visible = false;
					}
					if (this.costingTotalOtherCheckEdit.Checked)
					{
						report.totalOtherHeaderXRLabel.Visible = true;
						report.totalOtherDetailXrLabel.Visible = true;
						report.totalOtherFooterXrLabel.Visible = true;
						report.totalOtherHeaderXRLabel.Left = left;
						report.totalOtherDetailXrLabel.Left = left;
						report.totalOtherFooterXrLabel.Left = left;
						left += report.totalOtherDetailXrLabel.Width;
					}
					else
					{
						report.totalOtherHeaderXRLabel.Visible = false;
						report.totalOtherDetailXrLabel.Visible = false;
						report.totalOtherFooterXrLabel.Visible = false;
					}
					if (costingCostCheckBox.Checked)
					{
						report.costHeaderXRLabel.Visible = true;
						report.costDetailXrLabel.Visible = true;
						report.costFooterXrLabel.Visible = true;
						report.costHeaderXRLabel.Left = left;
						report.costDetailXrLabel.Left = left;
						report.costFooterXrLabel.Left = left;
						left += report.costDetailXrLabel.Width;
					}
					else
					{
						report.costHeaderXRLabel.Visible = false;
						report.costDetailXrLabel.Visible = false;
						report.costFooterXrLabel.Visible = false;
					}
					if (costingProfitCheckEdit.Checked)
					{
						report.profitHeaderXRLabel.Visible = true;
						report.profitDetailXrLabel.Visible = true;
						report.profitFooterXrLabel.Visible = true;
						report.profitHeaderXRLabel.Left = left;
						report.profitDetailXrLabel.Left = left;
						report.profitFooterXrLabel.Left = left;
						left += report.profitDetailXrLabel.Width;
					}
					else
					{
						report.profitHeaderXRLabel.Visible = false;
						report.profitDetailXrLabel.Visible = false;
						report.profitFooterXrLabel.Visible = false;
					}
					if (this.costingCostPerPieceCheckEdit.Checked == true)
					{
						report.costPerPieceHeaderXRLabel.Visible = true;
						report.costPerPieceDetailXrLabel.Visible = true;
						report.costPerPieceFooterXrLabel.Visible = true;
						report.costPerPieceHeaderXRLabel.Left = left;
						report.costPerPieceDetailXrLabel.Left = left;
						report.costPerPieceFooterXrLabel.Left = left;
						left += report.costPerPieceDetailXrLabel.Width;
					}
					else
					{
						report.costPerPieceHeaderXRLabel.Visible = false;
						report.costPerPieceDetailXrLabel.Visible = false;
						report.costPerPieceFooterXrLabel.Visible = false;
					}
					if (this.costingPacksPerMinuteCheckEdit.Checked == true)
					{
						report.packsPerMinuteHeaderXRLabel.Visible = true;
						report.packsPerMinuteDetailXrLabel.Visible = true;
						report.packsPerMinuteFooterXrLabel.Visible = true;
						report.packsPerMinuteHeaderXRLabel.Left = left;
						report.packsPerMinuteDetailXrLabel.Left = left;
						report.packsPerMinuteFooterXrLabel.Left = left;
						left += report.packsPerMinuteDetailXrLabel.Width;
					}
					else
					{
						report.packsPerMinuteHeaderXRLabel.Visible = false;
						report.packsPerMinuteDetailXrLabel.Visible = false;
						report.packsPerMinuteFooterXrLabel.Visible = false;
					}
					if (this.costingSalesVsPayrollCheckEdit.Checked)
					{
						report.salesVsPayrollHeaderXRLabel.Visible = true;
						report.salesVsPayrollDetailXrLabel.Visible = true;
						report.salesVsPayrollFooterXrLabel.Visible = true;
						report.salesVsPayrollHeaderXRLabel.Left = left;
						report.salesVsPayrollDetailXrLabel.Left = left;
						report.salesVsPayrollFooterXrLabel.Left = left;
						left += report.salesVsPayrollDetailXrLabel.Width;
					}
					else
					{
						report.salesVsPayrollHeaderXRLabel.Visible = false;
						report.salesVsPayrollDetailXrLabel.Visible = false;
						report.salesVsPayrollFooterXrLabel.Visible = false;
					}
					if (this.CostingSalesVsCostCheckEdit.Checked)
					{
						report.salesVsCostHeaderXRLabel.Visible = true;
						report.salesVsCostDetailXrLabel.Visible = true;
						report.salesVsCostFooterXrLabel.Visible = true;
						report.salesVsCostHeaderXRLabel.Left = left;
						report.salesVsCostDetailXrLabel.Left = left;
						report.salesVsCostFooterXrLabel.Left = left;
						left += report.salesVsCostDetailXrLabel.Width;
					}
					else
					{
						report.salesVsCostHeaderXRLabel.Visible = false;
						report.salesVsCostDetailXrLabel.Visible = false;
						report.salesVsCostFooterXrLabel.Visible = false;
					}
					if (costingProfitVsSalesCheckEdit.Checked)
					{
						report.profitVsSalesHeaderXRLabel.Visible = true;
						report.profitVsSalesDetailXrLabel.Visible = true;
						report.profitVsSalesDetailXrLabel.Visible = true;
						report.profitVsSalesHeaderXRLabel.Left = left;
						report.profitVsSalesDetailXrLabel.Left = left;
						report.profitVsSalesFooterXrLabel.Left = left;
						left += report.profitVsSalesDetailXrLabel.Width;
					}
					else
					{
						report.profitVsSalesHeaderXRLabel.Visible = false;
						report.profitVsSalesDetailXrLabel.Visible = false;
						report.profitVsSalesFooterXrLabel.Visible = false;
					}
					if (costingSalesVsProfitCheckEdit.Checked)
					{
						report.salesVsProfitHeaderXRLabel.Visible = true;
						report.salesVsProfitDetailXrLabel.Visible = true;
						report.salesVsProfitFooterXrLabel.Visible = true;
						report.salesVsProfitHeaderXRLabel.Left = left;
						report.salesVsProfitDetailXrLabel.Left = left;
						report.salesVsProfitFooterXrLabel.Left = left;
						left += report.salesVsProfitDetailXrLabel.Width;
					}
					else
					{
						report.salesVsProfitHeaderXRLabel.Visible = false;
						report.salesVsProfitDetailXrLabel.Visible = false;
						report.salesVsProfitFooterXrLabel.Visible = false;
					}
					report.printDateXRPageInfo.Left = left - 185;
					report.reportCriteriaXrLabel.Width = left - 190;
					report.reportTitleXRLabel.Width = left;
					report.headerXrPanel.Width = left;
					report.footerXrPanel.Width = left;
					report.pageNumberXrPageInfo.Left = left - 100;
					if (left > 1100 && reportCodeName == "CostingXtraReport")
					{
						report.PaperKind = System.Drawing.Printing.PaperKind.Custom;
						report.PageWidth = left;
						report.PageHeight = 850;
					}
					else
					{
						report.PaperKind = System.Drawing.Printing.PaperKind.Letter;
					}
					break;
				}
				case "ShippingXtraReport":
				{
					TransportationXtraReport report = (TransportationXtraReport)m_Report;
					if (this.transportationDateCheckEdit.Checked == true)
					{
						report.dateDetailXrLabel.Visible = true;
						report.dateHeaderXrLabel.Visible = true;
						report.dateHeaderXrLabel.Left = left;
						report.dateDetailXrLabel.Left = left;
						report.dateHeaderXrLabel.Width += additionalWidth;
						report.dateDetailXrLabel.Width += additionalWidth;
						left += report.dateDetailXrLabel.Width;
					}
					else
					{
						report.dateHeaderXrLabel.Visible = false;
						report.dateDetailXrLabel.Visible = false;
					}
					if (this.transportationShiftCheckEdit.Checked == true)
					{
						report.shiftHeaderXrLabel.Visible = true;
						report.shiftDetailXrLabel.Visible = true;
						report.shiftHeaderXrLabel.Left = left;
						report.shiftDetailXrLabel.Left = left;
						report.shiftDetailXrLabel.Width += additionalWidth;
						report.shiftHeaderXrLabel.Width += additionalWidth;
						left += report.shiftDetailXrLabel.Width;
					}
					else
					{
						report.shiftHeaderXrLabel.Visible = false;
						report.shiftDetailXrLabel.Visible = false;
					}
					if (this.transportationCustomerCheckEdit.Checked == true)
					{
						report.customerNameHeaderXrLabel.Visible = true;
						report.customerNameDetailXrLabel.Visible = true;
						report.customerNameHeaderXrLabel.Left = left;
						report.customerNameDetailXrLabel.Left = left;
						report.customerNameDetailXrLabel.Width += additionalWidth;
						report.customerNameHeaderXrLabel.Width += additionalWidth;
						left += report.customerNameDetailXrLabel.Width;
					}
					else
					{
						report.customerNameHeaderXrLabel.Visible = false;
						report.customerNameDetailXrLabel.Visible = false;
					}
					if (this.transportationBolCheckEdit.Checked == true)
					{
						report.bolHeaderXrLabel.Visible = true;
						report.bolDetailXrLabel.Visible = true;
						report.bolDetailXrLabel.Left = left;
						report.bolHeaderXrLabel.Left = left;
						report.bolDetailXrLabel.Width += additionalWidth;
						report.bolHeaderXrLabel.Width += additionalWidth;
						left += report.bolDetailXrLabel.Width;
					}
					else
					{
						report.bolHeaderXrLabel.Visible = false;
						report.bolDetailXrLabel.Visible = false;
					}
					if (this.transportationPOCheckEdit.Checked == true)
					{
						report.poHeaderXrLabel.Visible = true;
						report.poDetailXrLabel.Visible = true;
						report.poHeaderXrLabel.Left = left;
						report.poDetailXrLabel.Left = left;
						report.poDetailXrLabel.Width += additionalWidth;
						report.poHeaderXrLabel.Width += additionalWidth;
						left += report.poDetailXrLabel.Width;
					}
					else
					{
						report.poHeaderXrLabel.Visible = false;
						report.poDetailXrLabel.Visible = false;
					}
					if (this.transportationDeliveryNoteCheckEdit.Checked == true)
					{
						report.deliveryNoteNumberHeaderXrLabel.Visible = true;
						report.deliveryNoteNumberDetailXrLabel.Visible = true;
						report.deliveryNoteNumberHeaderXrLabel.Left = left;
						report.deliveryNoteNumberDetailXrLabel.Left = left;
						report.deliveryNoteNumberDetailXrLabel.Width += additionalWidth;
						report.deliveryNoteNumberHeaderXrLabel.Width += additionalWidth;
						left += report.deliveryNoteNumberDetailXrLabel.Width;
					}
					else
					{
						report.deliveryNoteNumberHeaderXrLabel.Visible = false;
						report.deliveryNoteNumberDetailXrLabel.Visible = false;
					}
					if (this.transportationDestinationCheckEdit.Checked == true)
					{
						report.destinationHeaderXrLabel.Visible = true;
						report.destinationDetailXrLabel.Visible = true;
						report.destinationHeaderXrLabel.Left = left;
						report.destinationDetailXrLabel.Left = left;
						report.destinationDetailXrLabel.Width += additionalWidth;
						report.destinationHeaderXrLabel.Width += additionalWidth;
						left += report.destinationDetailXrLabel.Width;
					}
					else
					{
						report.destinationHeaderXrLabel.Visible = false;
						report.destinationDetailXrLabel.Visible = false;
					}
					if (this.transportationItemCheckEdit.Checked == true)
					{
						report.itemCodeHeaderXrLabel.Visible = true;
						report.itemCodeDetailXrLabel.Visible = true;
						report.itemCodeHeaderXrLabel.Left = left;
						report.itemCodeDetailXrLabel.Left = left;
						report.itemCodeDetailXrLabel.Width += additionalWidth;
						report.itemCodeHeaderXrLabel.Width += additionalWidth;
						left += report.itemCodeDetailXrLabel.Width;
					}
					else
					{
						report.itemCodeHeaderXrLabel.Visible = false;
						report.itemCodeDetailXrLabel.Visible = false;
					}
					if (this.transportationItemDescriptionCheckEdit.Checked == true)
					{
						report.itemDescriptionHeaderXrLabel.Visible = true;
						report.itemDescriptionDetailXrLabel.Visible = true;
						report.itemDescriptionHeaderXrLabel.Left = left;
						report.itemDescriptionDetailXrLabel.Left = left;
						report.itemDescriptionDetailXrLabel.Width += additionalWidth;
						report.itemDescriptionHeaderXrLabel.Width += additionalWidth;
						left += report.itemDescriptionDetailXrLabel.Width;
					}
					else
					{
						report.itemDescriptionHeaderXrLabel.Visible = false;
						report.itemDescriptionDetailXrLabel.Visible = false;
					}
					if (this.transportationLpnCheckEdit.Checked == true)
					{
						report.lpnHeadeerXrLabel.Visible = true;
						report.lpnDetailXrLabel.Visible = true;
						report.lpnHeadeerXrLabel.Left = left;
						report.lpnDetailXrLabel.Left = left;
						report.lpnDetailXrLabel.Width += additionalWidth;
						report.lpnHeadeerXrLabel.Width += additionalWidth;
						left += report.lpnDetailXrLabel.Width;
					}
					else
					{
						report.lpnHeadeerXrLabel.Visible = false;
						report.lpnDetailXrLabel.Visible = false;
					}
					if (this.transportationLotCheckEdit.Checked == true)
					{
						report.lotHeadeerXrLabel.Visible = true;
						report.lotDetailXrLabel.Visible = true;
						report.lotHeadeerXrLabel.Left = left;
						report.lotDetailXrLabel.Left = left;
						report.lotDetailXrLabel.Width += additionalWidth;
						report.lotHeadeerXrLabel.Width += additionalWidth;
						left += report.lotDetailXrLabel.Width;
					}
					else
					{
						report.lotHeadeerXrLabel.Visible = false;
					report.lotDetailXrLabel.Visible = false;
					}
					if (transportationExpirationDateCheckEdit.Checked == true)
					{
						report.expirationDateHeaderXrLabel.Visible = true;
						report.expirationDateDetailXrLabel.Visible = true;
						report.expirationDateHeaderXrLabel.Left = left;
						report.expirationDateDetailXrLabel.Left = left;
						report.expirationDateHeaderXrLabel.Width += additionalWidth;
						report.expirationDateDetailXrLabel.Width += additionalWidth;
						left += report.expirationDateDetailXrLabel.Width;
					}
					else
					{
						report.expirationDateHeaderXrLabel.Visible = false;
						report.expirationDateDetailXrLabel.Visible = false;
					}
					if (this.transportationQuantityCheckEdit.Checked == true)
					{
						report.quantityHeaderXrLabel.Visible = true;
						report.quantityDetailXrLabel.Visible = true;
						report.quantityFooterXrLabel.Visible = true;
						report.quantityHeaderXrLabel.Left = left;
						report.quantityDetailXrLabel.Left = left;
						report.quantityFooterXrLabel.Left = left;
						report.quantityDetailXrLabel.Width += additionalWidth;
						report.quantityFooterXrLabel.Width += additionalWidth;
						report.quantityHeaderXrLabel.Width += additionalWidth;
						left += report.quantityDetailXrLabel.Width;
					}
					else
					{
						report.quantityHeaderXrLabel.Visible = false;
						report.quantityDetailXrLabel.Visible = false;
						report.quantityFooterXrLabel.Visible = false;
					}
					if (this.transportationVendorCheckEdit.Checked == true)
					{
						report.vendorDetailXrLabel.Visible = true;
						report.vendorHeaderXrLabel.Visible = true;
						report.vendorHeaderXrLabel.Left = left;
						report.vendorDetailXrLabel.Left = left;
						report.vendorHeaderXrLabel.Width += additionalWidth;
						report.vendorDetailXrLabel.Width += additionalWidth;
						left += report.vendorDetailXrLabel.Width;
					}
					else
					{
						report.vendorHeaderXrLabel.Visible = false;
						report.vendorDetailXrLabel.Visible = false;
					}
					if (this.transportationCarrierCheckEdit.Checked == true)
					{
						report.carrierHeaderXrLabel.Visible = true;
						report.carrierDetailXrLabel.Visible = true;
						report.carrierHeaderXrLabel.Left = left;
						report.carrierDetailXrLabel.Left = left;
						report.carrierDetailXrLabel.Width += additionalWidth;
						report.carrierHeaderXrLabel.Width += additionalWidth;
						left += report.carrierDetailXrLabel.Width;
					}
					else
					{
						report.carrierHeaderXrLabel.Visible = false;
						report.carrierDetailXrLabel.Visible = false;
					}
					if (this.transportationTrailerCheckEdit.Checked == true)
					{
						report.trailerHeaderXrLabel.Visible = true;
						report.trailerDetailXrLabel.Visible = true;
						report.trailerHeaderXrLabel.Left = left;
						report.trailerDetailXrLabel.Left = left;
						report.trailerDetailXrLabel.Width += additionalWidth;
						report.trailerHeaderXrLabel.Width += additionalWidth;
						left += report.trailerDetailXrLabel.Width;
					}
					else
					{
						report.trailerHeaderXrLabel.Visible = false;
						report.trailerDetailXrLabel.Visible = false;
					}
					if (this.transportationSealCheckEdit.Checked == true)
					{
						report.sealHeaderXrLabel.Visible = true;
						report.sealDetailXrLabel.Visible = true;
						report.sealDetailXrLabel.Left = left;
						report.sealHeaderXrLabel.Left = left;
						report.sealDetailXrLabel.Width += additionalWidth;
						report.sealHeaderXrLabel.Width += additionalWidth;
						left += report.sealDetailXrLabel.Width;
					}
					else
					{
						report.sealHeaderXrLabel.Visible = false;
						report.sealDetailXrLabel.Visible = false;
					}
					report.printDateXrPageInfo.Left = left - 185;
					report.reportCriteriaXrLabel.Width = left - 190;
					report.reportTitleXrLabel.Width = left;
					report.headerXrPanel.Width = left;
					report.footerXrPanel.Width = left;
					report.pageNumberXrPageInfo.Left = left - 100;
					break;
				}
				case "ShippingReturnsXtraReport":
				{
					TransportationXtraReport report = (TransportationXtraReport)m_Report;
					if (this.transportationDateCheckEdit.Checked == true)
					{
						report.dateDetailXrLabel.Visible = true;
						report.dateHeaderXrLabel.Visible = true;
						report.dateHeaderXrLabel.Left = left;
						report.dateDetailXrLabel.Left = left;
						report.dateHeaderXrLabel.Width += additionalWidth;
						report.dateDetailXrLabel.Width += additionalWidth;
						left += report.dateDetailXrLabel.Width;
					}
					else
					{
						report.dateHeaderXrLabel.Visible = false;
						report.dateDetailXrLabel.Visible = false;
					}
					if (this.transportationShiftCheckEdit.Checked == true)
					{
						report.shiftHeaderXrLabel.Visible = true;
						report.shiftDetailXrLabel.Visible = true;
						report.shiftHeaderXrLabel.Left = left;
						report.shiftDetailXrLabel.Left = left;
						report.shiftDetailXrLabel.Width += additionalWidth;
						report.shiftHeaderXrLabel.Width += additionalWidth;
						left += report.shiftDetailXrLabel.Width;
					}
					else
					{
						report.shiftHeaderXrLabel.Visible = false;
						report.shiftDetailXrLabel.Visible = false;
					}
					if (this.transportationCustomerCheckEdit.Checked == true)
					{
						report.customerNameHeaderXrLabel.Visible = true;
						report.customerNameDetailXrLabel.Visible = true;
						report.customerNameHeaderXrLabel.Left = left;
						report.customerNameDetailXrLabel.Left = left;
						report.customerNameDetailXrLabel.Width += additionalWidth;
						report.customerNameHeaderXrLabel.Width += additionalWidth;
						left += report.customerNameDetailXrLabel.Width;
					}
					else
					{
						report.customerNameHeaderXrLabel.Visible = false;
						report.customerNameDetailXrLabel.Visible = false;
					}
					if (this.transportationBolCheckEdit.Checked == true)
					{
						report.bolHeaderXrLabel.Visible = true;
						report.bolDetailXrLabel.Visible = true;
						report.bolDetailXrLabel.Left = left;
						report.bolHeaderXrLabel.Left = left;
						report.bolDetailXrLabel.Width += additionalWidth;
						report.bolHeaderXrLabel.Width += additionalWidth;
						left += report.bolDetailXrLabel.Width;
					}
					else
					{
						report.bolHeaderXrLabel.Visible = false;
						report.bolDetailXrLabel.Visible = false;
					}
					if (this.transportationPOCheckEdit.Checked == true)
					{
						report.poHeaderXrLabel.Visible = true;
						report.poDetailXrLabel.Visible = true;
						report.poHeaderXrLabel.Left = left;
						report.poDetailXrLabel.Left = left;
						report.poDetailXrLabel.Width += additionalWidth;
						report.poHeaderXrLabel.Width += additionalWidth;
						left += report.poDetailXrLabel.Width;
					}
					else
					{
						report.poHeaderXrLabel.Visible = false;
						report.poDetailXrLabel.Visible = false;
					}
					if (this.transportationDeliveryNoteCheckEdit.Checked == true)
					{
						report.deliveryNoteNumberHeaderXrLabel.Visible = true;
						report.deliveryNoteNumberDetailXrLabel.Visible = true;
						report.deliveryNoteNumberHeaderXrLabel.Left = left;
						report.deliveryNoteNumberDetailXrLabel.Left = left;
						report.deliveryNoteNumberDetailXrLabel.Width += additionalWidth;
						report.deliveryNoteNumberHeaderXrLabel.Width += additionalWidth;
						left += report.deliveryNoteNumberDetailXrLabel.Width;
					}
					else
					{
						report.deliveryNoteNumberHeaderXrLabel.Visible = false;
						report.deliveryNoteNumberDetailXrLabel.Visible = false;
					}
					if (this.transportationDestinationCheckEdit.Checked == true)
					{
						report.destinationHeaderXrLabel.Visible = true;
						report.destinationDetailXrLabel.Visible = true;
						report.destinationHeaderXrLabel.Left = left;
						report.destinationDetailXrLabel.Left = left;
						report.destinationDetailXrLabel.Width += additionalWidth;
						report.destinationHeaderXrLabel.Width += additionalWidth;
						left += report.destinationDetailXrLabel.Width;
					}
					else
					{
						report.destinationHeaderXrLabel.Visible = false;
						report.destinationDetailXrLabel.Visible = false;
					}
					if (this.transportationItemCheckEdit.Checked == true)
					{
						report.itemCodeHeaderXrLabel.Visible = true;
						report.itemCodeDetailXrLabel.Visible = true;
						report.itemCodeHeaderXrLabel.Left = left;
						report.itemCodeDetailXrLabel.Left = left;
						report.itemCodeDetailXrLabel.Width += additionalWidth;
						report.itemCodeHeaderXrLabel.Width += additionalWidth;
						left += report.itemCodeDetailXrLabel.Width;
					}
					else
					{
						report.itemCodeHeaderXrLabel.Visible = false;
						report.itemCodeDetailXrLabel.Visible = false;
					}
					if (this.transportationItemDescriptionCheckEdit.Checked == true)
					{
						report.itemDescriptionHeaderXrLabel.Visible = true;
						report.itemDescriptionDetailXrLabel.Visible = true;
						report.itemDescriptionHeaderXrLabel.Left = left;
						report.itemDescriptionDetailXrLabel.Left = left;
						report.itemDescriptionDetailXrLabel.Width += additionalWidth;
						report.itemDescriptionHeaderXrLabel.Width += additionalWidth;
						left += report.itemDescriptionDetailXrLabel.Width;
					}
					else
					{
						report.itemDescriptionHeaderXrLabel.Visible = false;
						report.itemDescriptionDetailXrLabel.Visible = false;
					}
					if (this.transportationLotCheckEdit.Checked == true)
					{
						report.lotHeadeerXrLabel.Visible = true;
						report.lotDetailXrLabel.Visible = true;
						report.lotHeadeerXrLabel.Left = left;
						report.lotDetailXrLabel.Left = left;
						report.lotDetailXrLabel.Width += additionalWidth;
						report.lotHeadeerXrLabel.Width += additionalWidth;
						left += report.lotDetailXrLabel.Width;
					}
					else
					{
						report.lotHeadeerXrLabel.Visible = false;
						report.lotDetailXrLabel.Visible = false;
					}
					if (transportationExpirationDateCheckEdit.Checked == true)
					{
						report.expirationDateHeaderXrLabel.Visible = true;
						report.expirationDateDetailXrLabel.Visible = true;
						report.expirationDateHeaderXrLabel.Left = left;
						report.expirationDateDetailXrLabel.Left = left;
						report.expirationDateHeaderXrLabel.Width += additionalWidth;
						report.expirationDateDetailXrLabel.Width += additionalWidth;
						left += report.expirationDateDetailXrLabel.Width;
					}
					else
					{
						report.expirationDateHeaderXrLabel.Visible = false;
						report.expirationDateDetailXrLabel.Visible = false;
					}
					if (this.transportationQuantityCheckEdit.Checked == true)
					{
						report.quantityHeaderXrLabel.Visible = true;
						report.quantityDetailXrLabel.Visible = true;
						report.quantityFooterXrLabel.Visible = true;
						report.quantityHeaderXrLabel.Left = left;
						report.quantityDetailXrLabel.Left = left;
						report.quantityFooterXrLabel.Left = left;
						report.quantityDetailXrLabel.Width += additionalWidth;
						report.quantityFooterXrLabel.Width += additionalWidth;
						report.quantityHeaderXrLabel.Width += additionalWidth;
						left += report.quantityDetailXrLabel.Width;
					}
					else
					{
						report.quantityHeaderXrLabel.Visible = false;
						report.quantityDetailXrLabel.Visible = false;
						report.quantityFooterXrLabel.Visible = false;
					}
					if (this.transportationVendorCheckEdit.Checked == true)
					{
						report.vendorDetailXrLabel.Visible = true;
						report.vendorHeaderXrLabel.Visible = true;
						report.vendorHeaderXrLabel.Left = left;
						report.vendorDetailXrLabel.Left = left;
						report.vendorHeaderXrLabel.Width += additionalWidth;
						report.vendorDetailXrLabel.Width += additionalWidth;
						left += report.vendorDetailXrLabel.Width;
					}
					else
					{
						report.vendorHeaderXrLabel.Visible = false;
						report.vendorDetailXrLabel.Visible = false;
					}
					if (this.transportationCarrierCheckEdit.Checked == true)
					{
						report.carrierHeaderXrLabel.Visible = true;
						report.carrierDetailXrLabel.Visible = true;
						report.carrierHeaderXrLabel.Left = left;
						report.carrierDetailXrLabel.Left = left;
						report.carrierDetailXrLabel.Width += additionalWidth;
						report.carrierHeaderXrLabel.Width += additionalWidth;
						left += report.carrierDetailXrLabel.Width;
					}
					else
					{
						report.carrierHeaderXrLabel.Visible = false;
						report.carrierDetailXrLabel.Visible = false;
					}
					if (this.transportationTrailerCheckEdit.Checked == true)
					{
						report.trailerHeaderXrLabel.Visible = true;
						report.trailerDetailXrLabel.Visible = true;
						report.trailerHeaderXrLabel.Left = left;
						report.trailerDetailXrLabel.Left = left;
						report.trailerDetailXrLabel.Width += additionalWidth;
						report.trailerHeaderXrLabel.Width += additionalWidth;
						left += report.trailerDetailXrLabel.Width;
					}
					else
					{
						report.trailerHeaderXrLabel.Visible = false;
						report.trailerDetailXrLabel.Visible = false;
					}
					if (this.transportationSealCheckEdit.Checked == true)
					{
						report.sealHeaderXrLabel.Visible = true;
						report.sealDetailXrLabel.Visible = true;
						report.sealDetailXrLabel.Left = left;
						report.sealHeaderXrLabel.Left = left;
						report.sealDetailXrLabel.Width += additionalWidth;
						report.sealHeaderXrLabel.Width += additionalWidth;
						left += report.sealDetailXrLabel.Width;
					}
					else
					{
						report.sealHeaderXrLabel.Visible = false;
						report.sealDetailXrLabel.Visible = false;
					}
					report.printDateXrPageInfo.Left = left - 185;
					report.reportCriteriaXrLabel.Width = left - 190;
					report.reportTitleXrLabel.Width = left;
					report.headerXrPanel.Width = left;
					report.footerXrPanel.Width = left;
					report.pageNumberXrPageInfo.Left = left - 100;
					break;
				}
				case "ReceivingXtraReport":
				{
					TransportationXtraReport report = (TransportationXtraReport)m_Report;
					if (this.transportationDateCheckEdit.Checked == true)
					{
						report.dateDetailXrLabel.Visible = true;
						report.dateHeaderXrLabel.Visible = true;
						report.dateHeaderXrLabel.Left = left;
						report.dateDetailXrLabel.Left = left;
						report.dateHeaderXrLabel.Width += additionalWidth;
						report.dateDetailXrLabel.Width += additionalWidth;
						left += report.dateDetailXrLabel.Width;
					}
					else
					{
						report.dateHeaderXrLabel.Visible = false;
						report.dateDetailXrLabel.Visible = false;
					}
					if (this.transportationShiftCheckEdit.Checked == true)
					{
						report.shiftHeaderXrLabel.Visible = true;
						report.shiftDetailXrLabel.Visible = true;
						report.shiftHeaderXrLabel.Left = left;
						report.shiftDetailXrLabel.Left = left;
						report.shiftDetailXrLabel.Width += additionalWidth;
						report.shiftHeaderXrLabel.Width += additionalWidth;
						left += report.shiftDetailXrLabel.Width;
					}
					else
					{
						report.shiftHeaderXrLabel.Visible = false;
						report.shiftDetailXrLabel.Visible = false;
					}
					if (transportationCustomerCheckEdit.Checked == true)
					{
						report.customerNameHeaderXrLabel.Visible = true;
						report.customerNameDetailXrLabel.Visible = true;
						report.customerNameHeaderXrLabel.Left = left;
						report.customerNameDetailXrLabel.Left = left;
						report.customerNameDetailXrLabel.Width += additionalWidth;
						report.customerNameHeaderXrLabel.Width += additionalWidth;
						left += report.customerNameDetailXrLabel.Width;
					}
					else
					{
						report.customerNameHeaderXrLabel.Visible = false;
						report.customerNameDetailXrLabel.Visible = false;
					}
					if (this.transportationBolCheckEdit.Checked == true)
					{
						report.bolHeaderXrLabel.Visible = true;
						report.bolDetailXrLabel.Visible = true;
						report.bolDetailXrLabel.Left = left;
						report.bolHeaderXrLabel.Left = left;
						report.bolDetailXrLabel.Width += additionalWidth;
						report.bolHeaderXrLabel.Width += additionalWidth;
						left += report.bolDetailXrLabel.Width;
					}
					else
					{
						report.bolHeaderXrLabel.Visible = false;
						report.bolDetailXrLabel.Visible = false;
					}
					if (this.transportationPOCheckEdit.Checked == true)
					{
						report.poHeaderXrLabel.Visible = true;
						report.poDetailXrLabel.Visible = true;
						report.poHeaderXrLabel.Left = left;
						report.poDetailXrLabel.Left = left;
						report.poDetailXrLabel.Width += additionalWidth;
						report.poHeaderXrLabel.Width += additionalWidth;
						left += report.poDetailXrLabel.Width;
					}
					else
					{
						report.poHeaderXrLabel.Visible = false;
						report.poDetailXrLabel.Visible = false;
					}
					if (this.transportationDeliveryNoteCheckEdit.Checked == true)
					{
						report.deliveryNoteNumberHeaderXrLabel.Visible = true;
						report.deliveryNoteNumberDetailXrLabel.Visible = true;
						report.deliveryNoteNumberHeaderXrLabel.Left = left;
						report.deliveryNoteNumberDetailXrLabel.Left = left;
						report.deliveryNoteNumberDetailXrLabel.Width += additionalWidth;
						report.deliveryNoteNumberHeaderXrLabel.Width += additionalWidth;
						left += report.deliveryNoteNumberDetailXrLabel.Width;
					}
					else
					{
						report.deliveryNoteNumberHeaderXrLabel.Visible = false;
						report.deliveryNoteNumberDetailXrLabel.Visible = false;
					}
					if (this.transportationDestinationCheckEdit.Checked == true)
					{
						report.destinationHeaderXrLabel.Visible = true;
						report.destinationDetailXrLabel.Visible = true;
						report.destinationHeaderXrLabel.Left = left;
						report.destinationDetailXrLabel.Left = left;
						report.destinationDetailXrLabel.Width += additionalWidth;
						report.destinationHeaderXrLabel.Width += additionalWidth;
						left += report.destinationDetailXrLabel.Width;
					}
					else
					{
						report.destinationHeaderXrLabel.Visible = false;
						report.destinationDetailXrLabel.Visible = false;
					}
					if (this.transportationItemCheckEdit.Checked == true)
					{
						report.itemCodeHeaderXrLabel.Visible = true;
						report.itemCodeDetailXrLabel.Visible = true;
						report.itemCodeHeaderXrLabel.Left = left;
						report.itemCodeDetailXrLabel.Left = left;
						report.itemCodeDetailXrLabel.Width += additionalWidth;
						report.itemCodeHeaderXrLabel.Width += additionalWidth;
						left += report.itemCodeDetailXrLabel.Width;
					}
					else
					{
						report.itemCodeHeaderXrLabel.Visible = false;
						report.itemCodeDetailXrLabel.Visible = false;
					}
					if (this.transportationItemDescriptionCheckEdit.Checked == true)
					{
						report.itemDescriptionHeaderXrLabel.Visible = true;
						report.itemDescriptionDetailXrLabel.Visible = true;
						report.itemDescriptionHeaderXrLabel.Left = left;
						report.itemDescriptionDetailXrLabel.Left = left;
						report.itemDescriptionDetailXrLabel.Width += additionalWidth;
						report.itemDescriptionHeaderXrLabel.Width += additionalWidth;
						left += report.itemDescriptionDetailXrLabel.Width;
					}
					else
					{
						report.itemDescriptionHeaderXrLabel.Visible = false;
						report.itemDescriptionDetailXrLabel.Visible = false;
					}
					if (this.transportationLotCheckEdit.Checked == true)
					{
						report.lotHeadeerXrLabel.Visible = true;
						report.lotDetailXrLabel.Visible = true;
						report.lotHeadeerXrLabel.Left = left;
						report.lotDetailXrLabel.Left = left;
						report.lotDetailXrLabel.Width += additionalWidth;
						report.lotHeadeerXrLabel.Width += additionalWidth;
						left += report.lotDetailXrLabel.Width;
					}
					else
					{
						report.lotHeadeerXrLabel.Visible = false;
						report.lotDetailXrLabel.Visible = false;
					}
					if (transportationExpirationDateCheckEdit.Checked == true)
					{
						report.expirationDateHeaderXrLabel.Visible = true;
						report.expirationDateDetailXrLabel.Visible = true;
						report.expirationDateHeaderXrLabel.Left = left;
						report.expirationDateDetailXrLabel.Left = left;
						report.expirationDateHeaderXrLabel.Width += additionalWidth;
						report.expirationDateDetailXrLabel.Width += additionalWidth;
						left += report.expirationDateDetailXrLabel.Width;
					}
					else
					{
						report.expirationDateHeaderXrLabel.Visible = false;
						report.expirationDateDetailXrLabel.Visible = false;
					}
					if (this.transportationQuantityCheckEdit.Checked == true)
					{
						report.quantityHeaderXrLabel.Visible = true;
						report.quantityDetailXrLabel.Visible = true;
						report.quantityFooterXrLabel.Visible = true;
						report.quantityHeaderXrLabel.Left = left;
						report.quantityDetailXrLabel.Left = left;
						report.quantityFooterXrLabel.Left = left;
						report.quantityDetailXrLabel.Width += additionalWidth;
						report.quantityFooterXrLabel.Width += additionalWidth;
						report.quantityHeaderXrLabel.Width += additionalWidth;
						left += report.quantityDetailXrLabel.Width;
					}
					else
					{
						report.quantityHeaderXrLabel.Visible = false;
						report.quantityDetailXrLabel.Visible = false;
						report.quantityFooterXrLabel.Visible = false;
					}
					if (this.transportationVendorCheckEdit.Checked == true)
					{
						report.vendorDetailXrLabel.Visible = true;
						report.vendorHeaderXrLabel.Visible = true;
						report.vendorHeaderXrLabel.Left = left;
						report.vendorDetailXrLabel.Left = left;
						report.vendorHeaderXrLabel.Width += additionalWidth;
						report.vendorDetailXrLabel.Width += additionalWidth;
						left += report.vendorDetailXrLabel.Width;
					}
					else
					{
						report.vendorHeaderXrLabel.Visible = false;
						report.vendorDetailXrLabel.Visible = false;
					}
					if (this.transportationCarrierCheckEdit.Checked == true)
					{
						report.carrierHeaderXrLabel.Visible = true;
						report.carrierDetailXrLabel.Visible = true;
						report.carrierHeaderXrLabel.Left = left;
						report.carrierDetailXrLabel.Left = left;
						report.carrierDetailXrLabel.Width += additionalWidth;
						report.carrierHeaderXrLabel.Width += additionalWidth;
						left += report.carrierDetailXrLabel.Width;
					}
					else
					{
						report.carrierHeaderXrLabel.Visible = false;
						report.carrierDetailXrLabel.Visible = false;
					}
					if (this.transportationTrailerCheckEdit.Checked == true)
					{
						report.trailerHeaderXrLabel.Visible = true;
						report.trailerDetailXrLabel.Visible = true;
						report.trailerHeaderXrLabel.Left = left;
						report.trailerDetailXrLabel.Left = left;
						report.trailerDetailXrLabel.Width += additionalWidth;
						report.trailerHeaderXrLabel.Width += additionalWidth;
						left += report.trailerDetailXrLabel.Width;
					}
					else
					{
						report.trailerHeaderXrLabel.Visible = false;
						report.trailerDetailXrLabel.Visible = false;
					}
					if (this.transportationSealCheckEdit.Checked == true)
					{
						report.sealHeaderXrLabel.Visible = true;
						report.sealDetailXrLabel.Visible = true;
						report.sealDetailXrLabel.Left = left;
						report.sealHeaderXrLabel.Left = left;
						report.sealDetailXrLabel.Width += additionalWidth;
						report.sealHeaderXrLabel.Width += additionalWidth;
						left += report.sealDetailXrLabel.Width;
					}
					else
					{
						report.sealHeaderXrLabel.Visible = false;
						report.sealDetailXrLabel.Visible = false;
					}
					report.printDateXrPageInfo.Left = left - 185;
					report.reportCriteriaXrLabel.Width = left - 190;
					report.reportTitleXrLabel.Width = left;
					report.headerXrPanel.Width = left;
					report.footerXrPanel.Width = left;
					report.pageNumberXrPageInfo.Left = left - 100;
					break;
				}
				case "ReceivingReturnsXtraReport":
				{
					TransportationXtraReport report = (TransportationXtraReport)m_Report;
					if (this.transportationDateCheckEdit.Checked == true)
					{
						report.dateDetailXrLabel.Visible = true;
						report.dateHeaderXrLabel.Visible = true;
						report.dateHeaderXrLabel.Left = left;
						report.dateDetailXrLabel.Left = left;
						report.dateHeaderXrLabel.Width += additionalWidth;
						report.dateDetailXrLabel.Width += additionalWidth;
						left += report.dateDetailXrLabel.Width;
					}
					else
					{
						report.dateHeaderXrLabel.Visible = false;
						report.dateDetailXrLabel.Visible = false;
					}
					if (this.transportationShiftCheckEdit.Checked == true)
					{
						report.shiftHeaderXrLabel.Visible = true;
						report.shiftDetailXrLabel.Visible = true;
						report.shiftHeaderXrLabel.Left = left;
						report.shiftDetailXrLabel.Left = left;
						report.shiftDetailXrLabel.Width += additionalWidth;
						report.shiftHeaderXrLabel.Width += additionalWidth;
						left += report.shiftDetailXrLabel.Width;
					}
					else
					{
						report.shiftHeaderXrLabel.Visible = false;
						report.shiftDetailXrLabel.Visible = false;
					}
					if (this.transportationCustomerCheckEdit.Checked == true)
					{
						report.customerNameHeaderXrLabel.Visible = true;
						report.customerNameDetailXrLabel.Visible = true;
						report.customerNameHeaderXrLabel.Left = left;
						report.customerNameDetailXrLabel.Left = left;
						report.customerNameDetailXrLabel.Width += additionalWidth;
						report.customerNameHeaderXrLabel.Width += additionalWidth;
						left += report.customerNameDetailXrLabel.Width;
					}
					else
					{
						report.customerNameHeaderXrLabel.Visible = false;
						report.customerNameDetailXrLabel.Visible = false;
					}
					if (this.transportationBolCheckEdit.Checked == true)
					{
						report.bolHeaderXrLabel.Visible = true;
						report.bolDetailXrLabel.Visible = true;
						report.bolDetailXrLabel.Left = left;
						report.bolHeaderXrLabel.Left = left;
						report.bolDetailXrLabel.Width += additionalWidth;
						report.bolHeaderXrLabel.Width += additionalWidth;
						left += report.bolDetailXrLabel.Width;
					}
					else
					{
						report.bolHeaderXrLabel.Visible = false;
						report.bolDetailXrLabel.Visible = false;
					}
					if (this.transportationPOCheckEdit.Checked == true)
					{
						report.poHeaderXrLabel.Visible = true;
						report.poDetailXrLabel.Visible = true;
						report.poHeaderXrLabel.Left = left;
						report.poDetailXrLabel.Left = left;
						report.poDetailXrLabel.Width += additionalWidth;
						report.poHeaderXrLabel.Width += additionalWidth;
						left += report.poDetailXrLabel.Width;
					}
					else
					{
						report.poHeaderXrLabel.Visible = false;
						report.poDetailXrLabel.Visible = false;
					}
					if (this.transportationDeliveryNoteCheckEdit.Checked == true)
					{
						report.deliveryNoteNumberHeaderXrLabel.Visible = true;
						report.deliveryNoteNumberDetailXrLabel.Visible = true;
						report.deliveryNoteNumberHeaderXrLabel.Left = left;
						report.deliveryNoteNumberDetailXrLabel.Left = left;
						report.deliveryNoteNumberDetailXrLabel.Width += additionalWidth;
						report.deliveryNoteNumberHeaderXrLabel.Width += additionalWidth;
						left += report.deliveryNoteNumberDetailXrLabel.Width;
					}
					else
					{
						report.deliveryNoteNumberHeaderXrLabel.Visible = false;
						report.deliveryNoteNumberDetailXrLabel.Visible = false;
					}
					if (this.transportationDestinationCheckEdit.Checked == true)
					{
						report.destinationHeaderXrLabel.Visible = true;
						report.destinationDetailXrLabel.Visible = true;
						report.destinationHeaderXrLabel.Left = left;
						report.destinationDetailXrLabel.Left = left;
						report.destinationDetailXrLabel.Width += additionalWidth;
						report.destinationHeaderXrLabel.Width += additionalWidth;
						left += report.destinationDetailXrLabel.Width;
					}
					else
					{
						report.destinationHeaderXrLabel.Visible = false;
						report.destinationDetailXrLabel.Visible = false;
					}
					if (this.transportationItemCheckEdit.Checked == true)
					{
						report.itemCodeHeaderXrLabel.Visible = true;
						report.itemCodeDetailXrLabel.Visible = true;
						report.itemCodeHeaderXrLabel.Left = left;
						report.itemCodeDetailXrLabel.Left = left;
						report.itemCodeDetailXrLabel.Width += additionalWidth;
						report.itemCodeHeaderXrLabel.Width += additionalWidth;
						left += report.itemCodeDetailXrLabel.Width;
					}
					else
					{
						report.itemCodeHeaderXrLabel.Visible = false;
						report.itemCodeDetailXrLabel.Visible = false;
					}
					if (this.transportationItemDescriptionCheckEdit.Checked == true)
					{
						report.itemDescriptionHeaderXrLabel.Visible = true;
						report.itemDescriptionDetailXrLabel.Visible = true;
						report.itemDescriptionHeaderXrLabel.Left = left;
						report.itemDescriptionDetailXrLabel.Left = left;
						report.itemDescriptionDetailXrLabel.Width += additionalWidth;
						report.itemDescriptionHeaderXrLabel.Width += additionalWidth;
						left += report.itemDescriptionDetailXrLabel.Width;
					}
					else
					{
						report.itemDescriptionHeaderXrLabel.Visible = false;
						report.itemDescriptionDetailXrLabel.Visible = false;
					}
					if (this.transportationLotCheckEdit.Checked == true)
					{
						report.lotHeadeerXrLabel.Visible = true;
						report.lotDetailXrLabel.Visible = true;
						report.lotHeadeerXrLabel.Left = left;
						report.lotDetailXrLabel.Left = left;
						report.lotDetailXrLabel.Width += additionalWidth;
						report.lotHeadeerXrLabel.Width += additionalWidth;
						left += report.lotDetailXrLabel.Width;
					}
					else
					{
						report.lotHeadeerXrLabel.Visible = false;
						report.lotDetailXrLabel.Visible = false;
					}
					if (transportationExpirationDateCheckEdit.Checked == true)
					{
						report.expirationDateHeaderXrLabel.Visible = true;
						report.expirationDateDetailXrLabel.Visible = true;
						report.expirationDateHeaderXrLabel.Left = left;
						report.expirationDateDetailXrLabel.Left = left;
						report.expirationDateHeaderXrLabel.Width += additionalWidth;
						report.expirationDateDetailXrLabel.Width += additionalWidth;
						left += report.expirationDateDetailXrLabel.Width;
					}
					else
					{
						report.expirationDateHeaderXrLabel.Visible = false;
						report.expirationDateDetailXrLabel.Visible = false;
					}
					if (this.transportationQuantityCheckEdit.Checked == true)
					{
						report.quantityHeaderXrLabel.Visible = true;
						report.quantityDetailXrLabel.Visible = true;
						report.quantityFooterXrLabel.Visible = true;
						report.quantityHeaderXrLabel.Left = left;
						report.quantityDetailXrLabel.Left = left;
						report.quantityFooterXrLabel.Left = left;
						report.quantityDetailXrLabel.Width += additionalWidth;
						report.quantityFooterXrLabel.Width += additionalWidth;
						report.quantityHeaderXrLabel.Width += additionalWidth;
						left += report.quantityDetailXrLabel.Width;
					}
					else
					{
						report.quantityHeaderXrLabel.Visible = false;
						report.quantityDetailXrLabel.Visible = false;
						report.quantityFooterXrLabel.Visible = false;
					}
					if (this.transportationVendorCheckEdit.Checked == true)
					{
						report.vendorDetailXrLabel.Visible = true;
						report.vendorHeaderXrLabel.Visible = true;
						report.vendorHeaderXrLabel.Left = left;
						report.vendorDetailXrLabel.Left = left;
						report.vendorHeaderXrLabel.Width += additionalWidth;
						report.vendorDetailXrLabel.Width += additionalWidth;
						left += report.vendorDetailXrLabel.Width;
					}
					else
					{
						report.vendorHeaderXrLabel.Visible = false;
						report.vendorDetailXrLabel.Visible = false;
					}
					if (this.transportationCarrierCheckEdit.Checked == true)
					{
						report.carrierHeaderXrLabel.Visible = true;
						report.carrierDetailXrLabel.Visible = true;
						report.carrierHeaderXrLabel.Left = left;
						report.carrierDetailXrLabel.Left = left;
						report.carrierDetailXrLabel.Width += additionalWidth;
						report.carrierHeaderXrLabel.Width += additionalWidth;
						left += report.carrierDetailXrLabel.Width;
					}
					else
					{
						report.carrierHeaderXrLabel.Visible = false;
						report.carrierDetailXrLabel.Visible = false;
					}
					if (this.transportationTrailerCheckEdit.Checked == true)
					{
						report.trailerHeaderXrLabel.Visible = true;
						report.trailerDetailXrLabel.Visible = true;
						report.trailerHeaderXrLabel.Left = left;
						report.trailerDetailXrLabel.Left = left;
						report.trailerDetailXrLabel.Width += additionalWidth;
						report.trailerHeaderXrLabel.Width += additionalWidth;
						left += report.trailerDetailXrLabel.Width;
					}
					else
					{
						report.trailerHeaderXrLabel.Visible = false;
						report.trailerDetailXrLabel.Visible = false;
					}
					if (this.transportationSealCheckEdit.Checked == true)
					{
						report.sealHeaderXrLabel.Visible = true;
						report.sealDetailXrLabel.Visible = true;
						report.sealDetailXrLabel.Left = left;
						report.sealHeaderXrLabel.Left = left;
						report.sealDetailXrLabel.Width += additionalWidth;
						report.sealHeaderXrLabel.Width += additionalWidth;
						left += report.sealDetailXrLabel.Width;
					}
					else
					{
						report.sealHeaderXrLabel.Visible = false;
						report.sealDetailXrLabel.Visible = false;
					}
					report.printDateXrPageInfo.Left = left - 185;
					report.reportCriteriaXrLabel.Width = left - 190;
					report.reportTitleXrLabel.Width = left;
					report.headerXrPanel.Width = left;
					report.footerXrPanel.Width = left;
					report.pageNumberXrPageInfo.Left = left - 100;
					break;
				}
				case "InventoryAdjustmentXtraReport":
				{
					InventoryXtraReport report = (InventoryXtraReport)m_Report;
					if (this.inventoryDateCheckEdit.Checked == true)
					{
						report.dateDetailXrLabel.Visible = true;
						report.dateHeaderXrLabel.Visible = true;
						report.dateDetailXrLabel.Left = left;
						report.dateHeaderXrLabel.Left = left;
						report.dateDetailXrLabel.Width += additionalWidth;
						report.dateHeaderXrLabel.Width += additionalWidth;
						left += report.dateDetailXrLabel.Width;
					}
					else
					{
						report.dateHeaderXrLabel.Visible = false;
						report.dateDetailXrLabel.Visible = false;
					}
					if (this.inventoryCustomerCheckEdit.Checked == true)
					{
						report.customerNameHeaderXrLabel.Visible = true;
						report.customerNameDetailXrLabel.Visible = true;
						report.customerNameHeaderXrLabel.Left = left;
						report.customerNameDetailXrLabel.Left = left;
						report.customerNameDetailXrLabel.Width += additionalWidth;
						report.customerNameHeaderXrLabel.Width += additionalWidth;
						left += report.customerNameDetailXrLabel.Width;
					}
					else
					{
						report.customerNameHeaderXrLabel.Visible = false;
						report.customerNameDetailXrLabel.Visible = false;
					}
					if (this.inventoryItemCheckEdit.Checked == true)
					{
						report.itemCodeDetailXrLabel.Visible = true;
						report.itemCodeHeaderXrLabel.Visible = true;
						report.itemCodeHeaderXrLabel.Left = left;
						report.itemCodeDetailXrLabel.Left = left;
						report.itemCodeDetailXrLabel.Width += additionalWidth;
						report.itemCodeHeaderXrLabel.Width += additionalWidth;
						left += report.itemCodeDetailXrLabel.Width;
					}
					else
					{
						report.itemCodeHeaderXrLabel.Visible = false;
						report.itemCodeDetailXrLabel.Visible = false;
					}
					if (this.inventoryAdjustmentCheckEdit.Checked == true)
					{
						report.quantityDetailXrLabel.Visible = true;
						report.quantityHeaderXrLabel.Visible = true;
						report.quantityHeaderXrLabel.Left = left;
						report.quantityDetailXrLabel.Left = left;
						report.quantityHeaderXrLabel.Width += additionalWidth;
						report.quantityDetailXrLabel.Width += additionalWidth;
						left += report.quantityDetailXrLabel.Width;
					}
					else
					{
						report.quantityHeaderXrLabel.Visible = false;
						report.quantityDetailXrLabel.Visible = false;
					}
					if (this.inventoryAdjustmentReasonCheckEdit.Checked == true)
					{
						report.reasonHeaderXrLabel.Visible = true;
						report.reasonDetailXrLabel.Visible = true;
						report.reasonHeaderXrLabel.Left = left;
						report.reasonDetailXrLabel.Left = left;
						report.reasonDetailXrLabel.Width += additionalWidth;
						report.reasonHeaderXrLabel.Width += additionalWidth;
						left += report.reasonDetailXrLabel.Width;
					}
					else
					{
						report.reasonHeaderXrLabel.Visible = false;
						report.reasonDetailXrLabel.Visible = false;
					}
					if (this.inventoryInventoryByPalletCheckEdit.Checked == true)
					{
						report.byPalletDetailXrLabel.Visible = true;
						report.byPalletHeaderXrLabel.Visible = true;
						report.byPalletHeaderXrLabel.Left = left;
						report.byPalletDetailXrLabel.Left = left;
						report.byPalletDetailXrLabel.Width += additionalWidth;
						report.byPalletHeaderXrLabel.Width += additionalWidth;
						left += report.byPalletDetailXrLabel.Width;
					}
					else
					{
						report.byPalletHeaderXrLabel.Visible = false;
						report.byPalletDetailXrLabel.Visible = false;
					}
					if (this.inventoryItemDescriptionCheckEdit.Checked == true)
					{
						report.itemDescriptionHeaderXrLabel.Visible = true;
						report.itemDescriptionDetailXrLabel.Visible = true;
						report.itemDescriptionHeaderXrLabel.Left = left;
						report.itemDescriptionDetailXrLabel.Left = left;
						report.itemDescriptionDetailXrLabel.Width += additionalWidth;
						report.itemDescriptionHeaderXrLabel.Width += additionalWidth;
						left += report.itemDescriptionDetailXrLabel.Width;
					}
					else
					{
						report.itemDescriptionHeaderXrLabel.Visible = false;
						report.itemDescriptionDetailXrLabel.Visible = false;
					}
					if (this.inventoryItemTypeCheckEdit.Checked == true)
					{
						report.itemTypeHeaderXrLabel.Visible = true;
						report.itemTypeDetailXrLabel.Visible = true;
						report.itemTypeHeaderXrLabel.Left = left;
						report.itemTypeDetailXrLabel.Left = left;
						report.itemTypeDetailXrLabel.Width += additionalWidth;
						report.itemTypeHeaderXrLabel.Width += additionalWidth;
						left += report.itemTypeDetailXrLabel.Width;
					}
					else
					{
						report.itemTypeHeaderXrLabel.Visible = false;
						report.itemTypeDetailXrLabel.Visible = false;
					}
					if (this.RMItemCodeCheckEdit.Checked == true)
					{
						report.lowestRMItemCodeXrLabel.Visible = true;
						report.RMitemCodeDetailXrLabel.Visible = true;
						report.lowestRMItemCodeXrLabel.Left = left;
						report.RMitemCodeDetailXrLabel.Left = left;
						report.RMitemCodeDetailXrLabel.Width += additionalWidth;
						report.lowestRMItemCodeXrLabel.Width += additionalWidth;
						left += report.RMitemCodeDetailXrLabel.Width;
					}
					else
					{
						report.lowestRMItemCodeXrLabel.Visible = false;
						report.RMitemCodeDetailXrLabel.Visible = false;
					}
					if (this.RMItemDescriptionCheckEdit.Checked == true)
					{
						report.lowestRMDescriptionXrLabel.Visible = true;
						report.RMitemDescriptionDetailXrLabel.Visible = true;
						report.lowestRMDescriptionXrLabel.Left = left;
						report.RMitemDescriptionDetailXrLabel.Left = left;
						report.RMitemDescriptionDetailXrLabel.Width += additionalWidth;
						report.lowestRMDescriptionXrLabel.Width += additionalWidth;
						left += report.RMitemDescriptionDetailXrLabel.Width;
					}
					else
					{
						report.lowestRMDescriptionXrLabel.Visible = false;
						report.RMitemDescriptionDetailXrLabel.Visible = false;
					}
					if (this.UOMCheckEdit.Checked)
					{
						report.UOMHeaderXrLabel.Visible = true;
						report.UOMDetailXrLabel.Visible = true;
						report.UOMHeaderXrLabel.LeftF = left;
						report.UOMDetailXrLabel.LeftF = left;
						report.UOMHeaderXrLabel.WidthF += additionalWidth;
						report.UOMDetailXrLabel.WidthF += additionalWidth;
						left += report.UOMDetailXrLabel.Width;
					}
					else
					{
						report.UOMHeaderXrLabel.Visible = false;
						report.UOMDetailXrLabel.Visible = false;
					}
					report.printDateXrPageInfo.Left = left - 185;
					report.reportCriteriaXrLabel.Width = left - 190;
					report.reportTitleXrLabel.Width = left;
					report.headerXrPanel.Width = left;
					report.pageNumberXrPageInfo.Left = left - 100;
					break;
				}
				case "PhysicalInventoryXtraReport":
				{
					InventoryXtraReport report = (InventoryXtraReport)m_Report;
					if (this.inventoryDateCheckEdit.Checked == true)
					{
						report.dateDetailXrLabel.Visible = true;
						report.dateHeaderXrLabel.Visible = true;
						report.dateDetailXrLabel.Left = left;
						report.dateHeaderXrLabel.Left = left;
						report.dateDetailXrLabel.Width += additionalWidth;
						report.dateHeaderXrLabel.Width += additionalWidth;
						left += report.dateDetailXrLabel.Width;
					}
					else
					{
						report.dateHeaderXrLabel.Visible = false;
						report.dateDetailXrLabel.Visible = false;
					}
					if (this.inventoryCustomerCheckEdit.Checked == true)
					{
						report.customerNameHeaderXrLabel.Visible = true;
						report.customerNameDetailXrLabel.Visible = true;
						report.customerNameHeaderXrLabel.Left = left;
						report.customerNameDetailXrLabel.Left = left;
						report.customerNameDetailXrLabel.Width += additionalWidth;
						report.customerNameHeaderXrLabel.Width += additionalWidth;
						left += report.customerNameDetailXrLabel.Width;
					}
					else
					{
						report.customerNameHeaderXrLabel.Visible = false;
						report.customerNameDetailXrLabel.Visible = false;
					}
					if (this.inventoryItemCheckEdit.Checked == true)
					{
						report.itemCodeDetailXrLabel.Visible = true;
						report.itemCodeHeaderXrLabel.Visible = true;
						report.itemCodeHeaderXrLabel.Left = left;
						report.itemCodeDetailXrLabel.Left = left;
						report.itemCodeDetailXrLabel.Width += additionalWidth;
						report.itemCodeHeaderXrLabel.Width += additionalWidth;
						left += report.itemCodeDetailXrLabel.Width;
					}
					else
					{
						report.itemCodeHeaderXrLabel.Visible = false;
						report.itemCodeDetailXrLabel.Visible = false;
					}
					if (this.inventoryItemDescriptionCheckEdit.Checked == true)
					{
						report.itemDescriptionHeaderXrLabel.Visible = true;
						report.itemDescriptionDetailXrLabel.Visible = true;
						report.itemDescriptionHeaderXrLabel.Left = left;
						report.itemDescriptionDetailXrLabel.Left = left;
						report.itemDescriptionDetailXrLabel.Width += additionalWidth;
						report.itemDescriptionHeaderXrLabel.Width += additionalWidth;
						left += report.itemDescriptionDetailXrLabel.Width;
					}
					else
					{
						report.itemDescriptionHeaderXrLabel.Visible = false;
						report.itemDescriptionDetailXrLabel.Visible = false;
					}
					if (this.inventoryItemTypeCheckEdit.Checked == true)
					{
						report.itemTypeHeaderXrLabel.Visible = true;
						report.itemTypeDetailXrLabel.Visible = true;
						report.itemTypeHeaderXrLabel.Left = left;
						report.itemTypeDetailXrLabel.Left = left;
						report.itemTypeDetailXrLabel.Width += additionalWidth;
						report.itemTypeHeaderXrLabel.Width += additionalWidth;
						left += report.itemTypeDetailXrLabel.Width;
					}
					else
					{
						report.itemTypeHeaderXrLabel.Visible = false;
						report.itemTypeDetailXrLabel.Visible = false;
					}
					if (this.inventoryCurrentInventoryCheckEdit.Checked == true)
					{
						report.quantityDetailXrLabel.Visible = true;
						report.quantityHeaderXrLabel.Visible = true;
						report.quantityHeaderXrLabel.Left = left;
						report.quantityDetailXrLabel.Left = left;
						report.quantityHeaderXrLabel.Width += additionalWidth;
						report.quantityDetailXrLabel.Width += additionalWidth;
						left += report.quantityDetailXrLabel.Width;
					}
					else
					{
						report.quantityHeaderXrLabel.Visible = false;
						report.quantityDetailXrLabel.Visible = false;
					}
					if (this.inventoryAdjustmentReasonCheckEdit.Checked == true)
					{
						report.reasonHeaderXrLabel.Visible = true;
						report.reasonDetailXrLabel.Visible = true;
						report.reasonHeaderXrLabel.Left = left;
						report.reasonDetailXrLabel.Left = left;
						report.reasonDetailXrLabel.Width += additionalWidth;
						report.reasonHeaderXrLabel.Width += additionalWidth;
						left += report.reasonDetailXrLabel.Width;
					}
					else
					{
						report.reasonHeaderXrLabel.Visible = false;
						report.reasonDetailXrLabel.Visible = false;
					}
					if (this.inventoryInventoryByPalletCheckEdit.Checked == true)
					{
						report.byPalletDetailXrLabel.Visible = true;
						report.byPalletHeaderXrLabel.Visible = true;
						report.byPalletHeaderXrLabel.Left = left;
						report.byPalletDetailXrLabel.Left = left;
						report.byPalletDetailXrLabel.Width += additionalWidth;
						report.byPalletHeaderXrLabel.Width += additionalWidth;
						left += report.byPalletDetailXrLabel.Width;
					}
					else
					{
						report.byPalletHeaderXrLabel.Visible = false;
						report.byPalletDetailXrLabel.Visible = false;
					}
					if (this.RMItemCodeCheckEdit.Checked == true)
					{
						report.lowestRMItemCodeXrLabel.Visible = true;
						report.RMitemCodeDetailXrLabel.Visible = true;
						report.lowestRMItemCodeXrLabel.Left = left;
						report.RMitemCodeDetailXrLabel.Left = left;
						report.RMitemCodeDetailXrLabel.Width += additionalWidth;
						report.lowestRMItemCodeXrLabel.Width += additionalWidth;
						left += report.RMitemCodeDetailXrLabel.Width;
					}
					else
					{
						report.lowestRMItemCodeXrLabel.Visible = false;
						report.RMitemCodeDetailXrLabel.Visible = false;
					}
					if (this.RMItemDescriptionCheckEdit.Checked == true)
					{
						report.lowestRMDescriptionXrLabel.Visible = true;
						report.RMitemDescriptionDetailXrLabel.Visible = true;
						report.lowestRMDescriptionXrLabel.Left = left;
						report.RMitemDescriptionDetailXrLabel.Left = left;
						report.RMitemDescriptionDetailXrLabel.Width += additionalWidth;
						report.lowestRMDescriptionXrLabel.Width += additionalWidth;
						left += report.RMitemDescriptionDetailXrLabel.Width;
					}
					else
					{
						report.lowestRMDescriptionXrLabel.Visible = false;
						report.RMitemDescriptionDetailXrLabel.Visible = false;
					}
					if (this.UOMCheckEdit.Checked)
					{
						report.UOMHeaderXrLabel.Visible = true;
						report.UOMDetailXrLabel.Visible = true;
						report.UOMHeaderXrLabel.LeftF = left;
						report.UOMDetailXrLabel.LeftF = left;
						report.UOMHeaderXrLabel.WidthF += additionalWidth;
						report.UOMDetailXrLabel.WidthF += additionalWidth;
						left += report.UOMDetailXrLabel.Width;
					}
					else
					{
						report.UOMHeaderXrLabel.Visible = false;
						report.UOMDetailXrLabel.Visible = false;
					}
					report.printDateXrPageInfo.Left = left - 185;
					report.reportCriteriaXrLabel.Width = left - 190;
					report.reportTitleXrLabel.Width = left;
					report.headerXrPanel.Width = left;
					report.pageNumberXrPageInfo.Left = left - 100;
					break;
				}
				case "CurrentInventoryXtraReport":
				{
					InventoryXtraReport report = (InventoryXtraReport)m_Report;
					if (this.inventoryDateCheckEdit.Checked == true)
					{
						report.dateDetailXrLabel.Visible = true;
						report.dateHeaderXrLabel.Visible = true;
						report.dateDetailXrLabel.Left = left;
						report.dateHeaderXrLabel.Left = left;
						report.dateDetailXrLabel.Width += additionalWidth;
						report.dateHeaderXrLabel.Width += additionalWidth;
						left += report.dateDetailXrLabel.Width;
					}
					else
					{
						report.dateHeaderXrLabel.Visible = false;
						report.dateDetailXrLabel.Visible = false;
					}
					if (this.inventoryCustomerCheckEdit.Checked == true)
					{
						report.customerNameHeaderXrLabel.Visible = true;
						report.customerNameDetailXrLabel.Visible = true;
						report.customerNameHeaderXrLabel.Left = left;
						report.customerNameDetailXrLabel.Left = left;
						report.customerNameDetailXrLabel.Width += additionalWidth;
						report.customerNameHeaderXrLabel.Width += additionalWidth;
						left += report.customerNameDetailXrLabel.Width;
					}
					else
					{
						report.customerNameHeaderXrLabel.Visible = false;
						report.customerNameDetailXrLabel.Visible = false;
					}
					if (this.inventoryItemCheckEdit.Checked == true)
					{
						report.itemCodeDetailXrLabel.Visible = true;
						report.itemCodeHeaderXrLabel.Visible = true;
						report.itemCodeHeaderXrLabel.Left = left;
						report.itemCodeDetailXrLabel.Left = left;
						report.itemCodeDetailXrLabel.Width += additionalWidth;
						report.itemCodeHeaderXrLabel.Width += additionalWidth;
						left += report.itemCodeDetailXrLabel.Width;
					}
					else
					{
						report.itemCodeHeaderXrLabel.Visible = false;
						report.itemCodeDetailXrLabel.Visible = false;
					}
					if (this.inventoryItemDescriptionCheckEdit.Checked == true)
					{
						report.itemDescriptionHeaderXrLabel.Visible = true;
						report.itemDescriptionDetailXrLabel.Visible = true;
						report.itemDescriptionHeaderXrLabel.Left = left;
						report.itemDescriptionDetailXrLabel.Left = left;
						report.itemDescriptionDetailXrLabel.Width += additionalWidth;
						report.itemDescriptionHeaderXrLabel.Width += additionalWidth;
						left += report.itemDescriptionDetailXrLabel.Width;
					}
					else
					{
						report.itemDescriptionHeaderXrLabel.Visible = false;
						report.itemDescriptionDetailXrLabel.Visible = false;
					}
					if (this.inventoryItemTypeCheckEdit.Checked == true)
					{
						report.itemTypeHeaderXrLabel.Visible = true;
						report.itemTypeDetailXrLabel.Visible = true;
						report.itemTypeHeaderXrLabel.Left = left;
						report.itemTypeDetailXrLabel.Left = left;
						report.itemTypeDetailXrLabel.Width += additionalWidth;
						report.itemTypeHeaderXrLabel.Width += additionalWidth;
						left += report.itemTypeDetailXrLabel.Width;
					}
					else
					{
						report.itemTypeHeaderXrLabel.Visible = false;
						report.itemTypeDetailXrLabel.Visible = false;
					}
					if (this.inventoryCurrentInventoryCheckEdit.Checked == true)
					{
						report.quantityDetailXrLabel.Visible = true;
						report.quantityHeaderXrLabel.Visible = true;
						report.quantityHeaderXrLabel.Left = left;
						report.quantityDetailXrLabel.Left = left;
						left += report.quantityDetailXrLabel.Width;
					}
					else
					{
						report.quantityHeaderXrLabel.Visible = false;
						report.quantityDetailXrLabel.Visible = false;
					}
					if (this.UOMCheckEdit.Checked)
					{
						report.UOMHeaderXrLabel.Visible = true;
						report.UOMDetailXrLabel.Visible = true;
						report.UOMHeaderXrLabel.LeftF = left;
						report.UOMDetailXrLabel.LeftF = left;
						left += report.UOMDetailXrLabel.Width;
					}
					else
					{
						report.UOMHeaderXrLabel.Visible = false;
						report.UOMDetailXrLabel.Visible = false;
					}
					if (this.inventoryAdjustmentReasonCheckEdit.Checked == true)
					{
						report.reasonHeaderXrLabel.Visible = true;
						report.reasonDetailXrLabel.Visible = true;
						report.reasonHeaderXrLabel.Left = left;
						report.reasonDetailXrLabel.Left = left;
						report.reasonDetailXrLabel.Width += additionalWidth;
						report.reasonHeaderXrLabel.Width += additionalWidth;
						left += report.reasonDetailXrLabel.Width;
					}
					else
					{
						report.reasonHeaderXrLabel.Visible = false;
						report.reasonDetailXrLabel.Visible = false;
					}
					if (this.inventoryInventoryByPalletCheckEdit.Checked == true)
					{
						report.byPalletDetailXrLabel.Visible = true;
						report.byPalletHeaderXrLabel.Visible = true;
						report.byPalletHeaderXrLabel.Left = left;
						report.byPalletDetailXrLabel.Left = left;
						left += report.byPalletDetailXrLabel.Width;
					}
					else
					{
						report.byPalletHeaderXrLabel.Visible = false;
						report.byPalletDetailXrLabel.Visible = false;
					}
					if (this.RMItemCodeCheckEdit.Checked == true)
					{
						report.lowestRMItemCodeXrLabel.Visible = true;
						report.RMitemCodeDetailXrLabel.Visible = true;
						report.lowestRMItemCodeXrLabel.Left = left;
						report.RMitemCodeDetailXrLabel.Left = left;
						report.RMitemCodeDetailXrLabel.Width += additionalWidth;
						report.lowestRMItemCodeXrLabel.Width += additionalWidth;
						left += report.RMitemCodeDetailXrLabel.Width;
					}
					else
					{
						report.lowestRMItemCodeXrLabel.Visible = false;
						report.RMitemCodeDetailXrLabel.Visible = false;
					}
					if (this.RMItemDescriptionCheckEdit.Checked == true)
					{
						report.lowestRMDescriptionXrLabel.Visible = true;
						report.RMitemDescriptionDetailXrLabel.Visible = true;
						report.lowestRMDescriptionXrLabel.Left = left;
						report.RMitemDescriptionDetailXrLabel.Left = left;
						report.RMitemDescriptionDetailXrLabel.Width += additionalWidth;
						report.lowestRMDescriptionXrLabel.Width += additionalWidth;
						left += report.RMitemDescriptionDetailXrLabel.Width;
					}
					else
					{
						report.lowestRMDescriptionXrLabel.Visible = false;
						report.RMitemDescriptionDetailXrLabel.Visible = false;
					}
					report.printDateXrPageInfo.Left = left - 185;
					report.reportCriteriaXrLabel.Width = left - 190;
					report.reportTitleXrLabel.Width = left;
					report.headerXrPanel.Width = left;
					report.pageNumberXrPageInfo.Left = left - 100;
					break;
				}
				case "FinishedProductAvailabilityXtraReport":
				{
					InventoryXtraReport report = (InventoryXtraReport)m_Report;
					if (this.inventoryDateCheckEdit.Checked == true)
					{
						report.dateDetailXrLabel.Visible = true;
						report.dateHeaderXrLabel.Visible = true;
						report.dateDetailXrLabel.Left = left;
						report.dateHeaderXrLabel.Left = left;
						report.dateDetailXrLabel.Width += additionalWidth;
						report.dateHeaderXrLabel.Width += additionalWidth;
						left += report.dateDetailXrLabel.Width;
					}
					else
					{
						report.dateHeaderXrLabel.Visible = false;
						report.dateDetailXrLabel.Visible = false;
					}
					if (this.inventoryCustomerCheckEdit.Checked == true)
					{
						report.customerNameHeaderXrLabel.Visible = true;
						report.customerNameDetailXrLabel.Visible = true;
						report.customerNameHeaderXrLabel.Left = left;
						report.customerNameDetailXrLabel.Left = left;
						report.customerNameDetailXrLabel.Width += additionalWidth;
						report.customerNameHeaderXrLabel.Width += additionalWidth;
						left += report.customerNameDetailXrLabel.Width;
					}
					else
					{
						report.customerNameHeaderXrLabel.Visible = false;
						report.customerNameDetailXrLabel.Visible = false;
					}
					if (this.inventoryItemCheckEdit.Checked == true)
					{
						report.itemCodeDetailXrLabel.Visible = true;
						report.itemCodeHeaderXrLabel.Visible = true;
						report.itemCodeHeaderXrLabel.Left = left;
						report.itemCodeDetailXrLabel.Left = left;
						report.itemCodeDetailXrLabel.Width += additionalWidth;
						report.itemCodeHeaderXrLabel.Width += additionalWidth;
						left += report.itemCodeDetailXrLabel.Width;
					}
					else
					{
						report.itemCodeHeaderXrLabel.Visible = false;
						report.itemCodeDetailXrLabel.Visible = false;
					}
					if (this.inventoryItemDescriptionCheckEdit.Checked == true)
					{
						report.itemDescriptionHeaderXrLabel.Visible = true;
						report.itemDescriptionDetailXrLabel.Visible = true;
						report.itemDescriptionHeaderXrLabel.Left = left;
						report.itemDescriptionDetailXrLabel.Left = left;
						report.itemDescriptionDetailXrLabel.Width += additionalWidth;
						report.itemDescriptionHeaderXrLabel.Width += additionalWidth;
						left += report.itemDescriptionDetailXrLabel.Width;
					}
					else
					{
						report.itemDescriptionHeaderXrLabel.Visible = false;
						report.itemDescriptionDetailXrLabel.Visible = false;
					}
					if (this.inventoryItemTypeCheckEdit.Checked == true)
					{
						report.itemTypeHeaderXrLabel.Visible = true;
						report.itemTypeDetailXrLabel.Visible = true;
						report.itemTypeHeaderXrLabel.Left = left;
						report.itemTypeDetailXrLabel.Left = left;
						report.itemTypeDetailXrLabel.Width += additionalWidth;
						report.itemTypeHeaderXrLabel.Width += additionalWidth;
						left += report.itemTypeDetailXrLabel.Width;
					}
					else
					{
						report.itemTypeHeaderXrLabel.Visible = false;
						report.itemTypeDetailXrLabel.Visible = false;
					}
					if (this.inventoryAvailabilityCheckEdit.Checked == true)
					{
						report.quantityDetailXrLabel.Visible = true;
						report.quantityHeaderXrLabel.Visible = true;
						report.quantityHeaderXrLabel.Left = left;
						report.quantityDetailXrLabel.Left = left;
						report.quantityHeaderXrLabel.Width += additionalWidth;
						report.quantityDetailXrLabel.Width += additionalWidth;
						left += report.quantityDetailXrLabel.Width;
					}
					else
					{
						report.quantityHeaderXrLabel.Visible = false;
						report.quantityDetailXrLabel.Visible = false;
					}
					if (this.inventoryAdjustmentReasonCheckEdit.Checked == true)
					{
						report.reasonHeaderXrLabel.Visible = true;
						report.reasonDetailXrLabel.Visible = true;
						report.reasonHeaderXrLabel.Left = left;
						report.reasonDetailXrLabel.Left = left;
						report.reasonDetailXrLabel.Width += additionalWidth;
						report.reasonHeaderXrLabel.Width += additionalWidth;
						left += report.reasonDetailXrLabel.Width;
					}
					else
					{
						report.reasonHeaderXrLabel.Visible = false;
						report.reasonDetailXrLabel.Visible = false;
					}
					if (this.inventoryPalletAvailabilityCheckEdit.Checked == true)
					{
						report.byPalletDetailXrLabel.Visible = true;
						report.byPalletHeaderXrLabel.Visible = true;
						report.byPalletHeaderXrLabel.Left = left;
						report.byPalletDetailXrLabel.Left = left;
						report.byPalletDetailXrLabel.Width += additionalWidth;
						report.byPalletHeaderXrLabel.Width += additionalWidth;
						left += report.byPalletDetailXrLabel.Width;
					}
					else
					{
						report.byPalletHeaderXrLabel.Visible = false;
						report.byPalletDetailXrLabel.Visible = false;
					}
					if (this.RMItemCodeCheckEdit.Checked == true)
					{
						report.lowestRMItemCodeXrLabel.Visible = true;
						report.RMitemCodeDetailXrLabel.Visible = true;
						report.lowestRMItemCodeXrLabel.Left = left;
						report.RMitemCodeDetailXrLabel.Left = left;
						report.RMitemCodeDetailXrLabel.Width += additionalWidth;
						report.lowestRMItemCodeXrLabel.Width += additionalWidth;
						left += report.RMitemCodeDetailXrLabel.Width;
					}
					else
					{
						report.lowestRMItemCodeXrLabel.Visible = false;
						report.RMitemCodeDetailXrLabel.Visible = false;
					}
					if (this.RMItemDescriptionCheckEdit.Checked == true)
					{
						report.lowestRMDescriptionXrLabel.Visible = true;
						report.RMitemDescriptionDetailXrLabel.Visible = true;
						report.lowestRMDescriptionXrLabel.Left = left;
						report.RMitemDescriptionDetailXrLabel.Left = left;
						report.RMitemDescriptionDetailXrLabel.Width += additionalWidth;
						report.lowestRMDescriptionXrLabel.Width += additionalWidth;
						left += report.RMitemDescriptionDetailXrLabel.Width;
					}
					else
					{
						report.lowestRMDescriptionXrLabel.Visible = false;
						report.RMitemDescriptionDetailXrLabel.Visible = false;
					}
					if (this.UOMCheckEdit.Checked)
					{
						report.UOMHeaderXrLabel.Visible = true;
						report.UOMDetailXrLabel.Visible = true;
						report.UOMHeaderXrLabel.LeftF = left;
						report.UOMDetailXrLabel.LeftF = left;
						report.UOMHeaderXrLabel.WidthF += additionalWidth;
						report.UOMDetailXrLabel.WidthF += additionalWidth;
						left += report.UOMDetailXrLabel.Width;
					}
					else
					{
						report.UOMHeaderXrLabel.Visible = false;
						report.UOMDetailXrLabel.Visible = false;
					}
					report.printDateXrPageInfo.Left = left - 185;
					report.reportCriteriaXrLabel.Width = left - 190;
					report.reportTitleXrLabel.Width = left;
					report.headerXrPanel.Width = left;
					report.pageNumberXrPageInfo.Left = left - 100;
					break;
				}
				case "ItemsListXtraReport":
				{
					ItemsXtraReport report = (ItemsXtraReport)m_Report;
					if (this.itemsCustomerCheckEdit.Checked == true)
					{
						report.customerNameHeaderXrLabel.Visible = true;
						report.customerNameDetailXrLabel.Visible = true;
						report.customerNameHeaderXrLabel.Left = left;
						report.customerNameDetailXrLabel.Left = left;
						report.customerNameDetailXrLabel.Width += additionalWidth;
						report.customerNameHeaderXrLabel.Width += additionalWidth;
						left += report.customerNameDetailXrLabel.Width;
					}
					else
					{
						report.customerNameHeaderXrLabel.Visible = false;
						report.customerNameDetailXrLabel.Visible = false;
					}
					if (this.itemsItemCheckEdit.Checked == true)
					{
						report.itemCodeHeaderXrLabel.Visible = true;
						report.itemCodeDetailXrLabel.Visible = true;
						report.itemCodeHeaderXrLabel.Left = left;
						report.itemCodeDetailXrLabel.Left = left;
						report.itemCodeDetailXrLabel.Width += additionalWidth;
						report.itemCodeHeaderXrLabel.Width += additionalWidth;
						left += report.itemCodeDetailXrLabel.Width;
					}
					else
					{
						report.itemCodeHeaderXrLabel.Visible = false;
						report.itemCodeDetailXrLabel.Visible = false;
					}
					if (this.itemsItemDescriptionCheckEdit.Checked == true)
					{
						report.itemDescriptionHeaderXrLabel.Visible = true;
						report.itemDescriptionDetailXrLabel.Visible = true;
						report.itemDescriptionHeaderXrLabel.Left = left;
						report.itemDescriptionDetailXrLabel.Left = left;
						report.itemDescriptionDetailXrLabel.Width += additionalWidth;
						report.itemDescriptionHeaderXrLabel.Width += additionalWidth;
						left += report.itemDescriptionDetailXrLabel.Width;
					}
					else
					{
						report.itemDescriptionHeaderXrLabel.Visible = false;
						report.itemDescriptionDetailXrLabel.Visible = false;
					}
					if (this.itemsItemTypeCheckEdit.Checked == true)
					{
						report.itemTypeDetailXrLabel.Visible = true;
						report.itemTypeHeaderXrLabel.Visible = true;
						report.itemTypeHeaderXrLabel.Left = left;
						report.itemTypeDetailXrLabel.Left = left;
						report.itemTypeDetailXrLabel.Width += additionalWidth;
						report.itemTypeHeaderXrLabel.Width += additionalWidth;
						left += report.itemTypeDetailXrLabel.Width;
					}
					else
					{
						report.itemTypeHeaderXrLabel.Visible = false;
						report.itemTypeDetailXrLabel.Visible = false;
					}
					if (this.itemsUnitsOfMeasureCheckEdit.Checked == true)
					{
						report.uomHeaderXrLabel.Visible = true;
						report.uomDetailXrLabel.Visible = true;
						report.uomHeaderXrLabel.Left = left;
						report.uomDetailXrLabel.Left = left;
						left += report.uomDetailXrLabel.Width;
					}
					else
					{
						report.uomHeaderXrLabel.Visible = false;
						report.uomDetailXrLabel.Visible = false;
					}
					if (this.itemsQtyPerUnitCheckEdit.Checked == true)
					{
						report.quantityHeaderXrLabel.Visible = true;
						report.quantityDetailXrLabel.Visible = true;
						report.quantityHeaderXrLabel.Left = left;
						report.quantityDetailXrLabel.Left = left;
						left += report.quantityDetailXrLabel.Width;
					}
					else
					{
						report.quantityHeaderXrLabel.Visible = false;
						report.quantityDetailXrLabel.Visible = false;
					}
					if (this.itemsUnitsPerCaseCheckEdit.Checked == true)
					{
						report.unitsPerCaseHeaderXrLabel.Visible = true;
						report.unitsPerCaseDetailXrLabel.Visible = true;
						report.unitsPerCaseHeaderXrLabel.Left = left;
						report.unitsPerCaseDetailXrLabel.Left = left;
						left += report.unitsPerCaseDetailXrLabel.Width;
					}
					else
					{
						report.unitsPerCaseHeaderXrLabel.Visible = false;
						report.unitsPerCaseDetailXrLabel.Visible = false;
					}
					if (this.itemsProducedCheckEdit.Checked == true)
					{
						report.producedHeaderXrLabel.Visible = true;
						report.producedDetailXrLabel.Visible = true;
						report.producedFooterXrLabel.Visible = true;
						report.producedHeaderXrLabel.Left = left;
						report.producedDetailXrLabel.Left = left;
						report.producedFooterXrLabel.Left = left;
						left += report.producedDetailXrLabel.Width;
					}
					else
					{
						report.producedHeaderXrLabel.Visible = false;
						report.producedDetailXrLabel.Visible = false;
						report.producedFooterXrLabel.Visible = false;
					}
					if (this.itemsShippedCheckEdit.Checked == true)
					{
						report.shippedHeaderXrLabel.Visible = true;
						report.shippedDetailXrLabel.Visible = true;
						report.shippedDetailXrLabel.Left = left;
						report.shippedHeaderXrLabel.Left = left;
						report.shippedFooterXrLabel.Visible = true;
						report.shippedFooterXrLabel.Left = left;
						left += report.shippedDetailXrLabel.Width;
					}
					else
					{
						report.shippedHeaderXrLabel.Visible = false;
						report.shippedDetailXrLabel.Visible = false;
						report.shippedFooterXrLabel.Visible = false;
					}
					if (this.itemsReceivedCheckEdit.Checked == true)
					{
						report.receivedHeaderXrLabel.Visible = true;
						report.receivedDetailXrLabel.Visible = true;
						report.receivedHeaderXrLabel.Left = left;
						report.receivedDetailXrLabel.Left = left;
						report.receivedFooterXrLabel.Visible = true;
						report.receivedFooterXrLabel.Left = left;
						left += report.receivedDetailXrLabel.Width;
					}
					else
					{
						report.receivedHeaderXrLabel.Visible = false;
						report.receivedDetailXrLabel.Visible = false;
						report.receivedFooterXrLabel.Visible = false;
					}
					if (this.itemsCasesPerPalletCheckEdit.Checked == true)
					{
						report.casesPerPalletHeadeerXrLabel.Visible = true;
						report.casesPerPalletDetailXrLabel.Visible = true;
						report.casesPerPalletHeadeerXrLabel.Left = left;
						report.casesPerPalletDetailXrLabel.Left = left;
						left += report.casesPerPalletDetailXrLabel.Width;
					}
					else
					{
						report.casesPerPalletHeadeerXrLabel.Visible = false;
						report.casesPerPalletDetailXrLabel.Visible = false;
					}
					if (this.itemsAdjustedCheckEdit.Checked == true)
					{
						report.adjustedDetailXrLabel.Visible = true;
						report.AdjustedHeaderXrLabel.Visible = true;
						report.AdjustedHeaderXrLabel.Left = left;
						report.adjustedDetailXrLabel.Left = left;
						report.adjustedFooterXrLabel.Visible = true;
						report.adjustedFooterXrLabel.Left = left;
						left += report.adjustedDetailXrLabel.Width;
					}
					else
					{
						report.AdjustedHeaderXrLabel.Visible = false;
						report.adjustedDetailXrLabel.Visible = false;
						report.adjustedFooterXrLabel.Visible = false;
					}
					if (this.itemUsedInProductionCheckEdit.Checked == true)
					{
						report.usedInProductionDetailXrLabel.Visible = true;
						report.usedInProductionHeaderXrLabel.Visible = true;
						report.usedInProductionFooterXrLabel.Visible = true;
						report.usedInProductionHeaderXrLabel.LeftF = left;
						report.usedInProductionDetailXrLabel.LeftF = left;
						report.usedInProductionFooterXrLabel.LeftF = left;
						left += report.usedInProductionDetailXrLabel.Width;
					}
					else
					{
						report.usedInProductionDetailXrLabel.Visible = false;
						report.usedInProductionHeaderXrLabel.Visible = false;
						report.usedInProductionFooterXrLabel.Visible = false;
					}
					report.printDateXrPageInfo.Left = left - 185;
					report.reportCriteriaXrLabel.Width = left - 190;
					report.reportTitleXrLabel.Width = left;
					report.headerXrPanel.Width = left;
					report.footerXrPanel.Width = left;
					report.pageNumberXrPageInfo.Left = left - 100;
					break;
				}
				case "ItemTransactionSummaryXtraReport":
				{
					ItemsXtraReport report = (ItemsXtraReport)m_Report;
					if (this.itemsCustomerCheckEdit.Checked == true)
					{
						report.customerNameHeaderXrLabel.Visible = true;
						report.customerNameDetailXrLabel.Visible = true;
						report.customerNameHeaderXrLabel.Left = left;
						report.customerNameDetailXrLabel.Left = left;
						report.customerNameDetailXrLabel.Width += additionalWidth;
						report.customerNameHeaderXrLabel.Width += additionalWidth;
						left += report.customerNameDetailXrLabel.Width;
					}
					else
					{
						report.customerNameHeaderXrLabel.Visible = false;
						report.customerNameDetailXrLabel.Visible = false;
					}
					if (this.itemsItemCheckEdit.Checked == true)
					{
						report.itemCodeHeaderXrLabel.Visible = true;
						report.itemCodeDetailXrLabel.Visible = true;
						report.itemCodeHeaderXrLabel.Left = left;
						report.itemCodeDetailXrLabel.Left = left;
						report.itemCodeDetailXrLabel.Width += additionalWidth;
						report.itemCodeHeaderXrLabel.Width += additionalWidth;
						left += report.itemCodeDetailXrLabel.Width;
					}
					else
					{
						report.itemCodeHeaderXrLabel.Visible = false;
						report.itemCodeDetailXrLabel.Visible = false;
					}
					if (this.itemsItemDescriptionCheckEdit.Checked == true)
					{
						report.itemDescriptionHeaderXrLabel.Visible = true;
						report.itemDescriptionDetailXrLabel.Visible = true;
						report.itemDescriptionHeaderXrLabel.Left = left;
						report.itemDescriptionDetailXrLabel.Left = left;
						report.itemDescriptionDetailXrLabel.Width += additionalWidth;
						report.itemDescriptionHeaderXrLabel.Width += additionalWidth;
						left += report.itemDescriptionDetailXrLabel.Width;
					}
					else
					{
						report.itemDescriptionHeaderXrLabel.Visible = false;
						report.itemDescriptionDetailXrLabel.Visible = false;
					}
					if (this.itemsItemTypeCheckEdit.Checked == true)
					{
						report.itemTypeDetailXrLabel.Visible = true;
						report.itemTypeHeaderXrLabel.Visible = true;
						report.itemTypeHeaderXrLabel.Left = left;
						report.itemTypeDetailXrLabel.Left = left;
						report.itemTypeDetailXrLabel.Width += additionalWidth;
						report.itemTypeHeaderXrLabel.Width += additionalWidth;
						left += report.itemTypeDetailXrLabel.Width;
					}
					else
					{
						report.itemTypeHeaderXrLabel.Visible = false;
						report.itemTypeDetailXrLabel.Visible = false;
					}
					if (this.itemsUnitsOfMeasureCheckEdit.Checked == true)
					{
						report.uomHeaderXrLabel.Visible = true;
						report.uomDetailXrLabel.Visible = true;
						report.uomHeaderXrLabel.Left = left;
						report.uomDetailXrLabel.Left = left;
						left += report.uomDetailXrLabel.Width;
					}
					else
					{
						report.uomHeaderXrLabel.Visible = false;
						report.uomDetailXrLabel.Visible = false;
					}
					if (this.itemsQtyPerUnitCheckEdit.Checked == true)
					{
						report.quantityHeaderXrLabel.Visible = true;
						report.quantityDetailXrLabel.Visible = true;
						report.quantityHeaderXrLabel.Left = left;
						report.quantityDetailXrLabel.Left = left;
						left += report.quantityDetailXrLabel.Width;
					}
					else
					{
						report.quantityHeaderXrLabel.Visible = false;
						report.quantityDetailXrLabel.Visible = false;
					}
					if (this.itemsUnitsPerCaseCheckEdit.Checked == true)
					{
						report.unitsPerCaseHeaderXrLabel.Visible = true;
						report.unitsPerCaseDetailXrLabel.Visible = true;
						report.unitsPerCaseHeaderXrLabel.Left = left;
						report.unitsPerCaseDetailXrLabel.Left = left;
						left += report.unitsPerCaseDetailXrLabel.Width;
					}
					else
					{
						report.unitsPerCaseHeaderXrLabel.Visible = false;
						report.unitsPerCaseDetailXrLabel.Visible = false;
					}
					if (this.itemsProducedCheckEdit.Checked == true)
					{
						report.producedHeaderXrLabel.Visible = true;
						report.producedDetailXrLabel.Visible = true;
						report.producedFooterXrLabel.Visible = true;
						report.producedHeaderXrLabel.Left = left;
						report.producedDetailXrLabel.Left = left;
						report.producedFooterXrLabel.Left = left;
						left += report.producedDetailXrLabel.Width;
					}
					else
					{
						report.producedHeaderXrLabel.Visible = false;
						report.producedDetailXrLabel.Visible = false;
						report.producedFooterXrLabel.Visible = false;
					}
					if (this.itemUsedInProductionCheckEdit.Checked == true)
					{
						report.usedInProductionDetailXrLabel.Visible = true;
						report.usedInProductionHeaderXrLabel.Visible = true;
						report.usedInProductionFooterXrLabel.Visible = true;
						report.usedInProductionHeaderXrLabel.LeftF = left;
						report.usedInProductionDetailXrLabel.LeftF = left;
						report.usedInProductionFooterXrLabel.LeftF = left;
						left += report.usedInProductionDetailXrLabel.Width;
					}
					else
					{
						report.usedInProductionDetailXrLabel.Visible = false;
						report.usedInProductionHeaderXrLabel.Visible = false;
						report.usedInProductionFooterXrLabel.Visible = false;
					}
					if (this.itemsShippedCheckEdit.Checked == true)
					{
						report.shippedHeaderXrLabel.Visible = true;
						report.shippedDetailXrLabel.Visible = true;
						report.shippedDetailXrLabel.Left = left;
						report.shippedHeaderXrLabel.Left = left;
						report.shippedFooterXrLabel.Visible = true;
						report.shippedFooterXrLabel.Left = left;
						left += report.shippedDetailXrLabel.Width;
					}
					else
					{
						report.shippedHeaderXrLabel.Visible = false;
						report.shippedDetailXrLabel.Visible = false;
						report.shippedFooterXrLabel.Visible = false;
					}
					if (this.itemsReceivedCheckEdit.Checked == true)
					{
						report.receivedHeaderXrLabel.Visible = true;
						report.receivedDetailXrLabel.Visible = true;
						report.receivedHeaderXrLabel.Left = left;
						report.receivedDetailXrLabel.Left = left;
						report.receivedFooterXrLabel.Visible = true;
						report.receivedFooterXrLabel.Left = left;
						left += report.receivedDetailXrLabel.Width;
					}
					else
					{
						report.receivedHeaderXrLabel.Visible = false;
						report.receivedDetailXrLabel.Visible = false;
						report.receivedFooterXrLabel.Visible = false;
					}
					if (this.itemsCasesPerPalletCheckEdit.Checked == true)
					{
						report.casesPerPalletHeadeerXrLabel.Visible = true;
						report.casesPerPalletDetailXrLabel.Visible = true;
						report.casesPerPalletHeadeerXrLabel.Left = left;
						report.casesPerPalletDetailXrLabel.Left = left;
						left += report.casesPerPalletDetailXrLabel.Width;
					}
					else
					{
						report.casesPerPalletHeadeerXrLabel.Visible = false;
						report.casesPerPalletDetailXrLabel.Visible = false;
					}
					if (this.itemsAdjustedCheckEdit.Checked == true)
					{
						report.adjustedDetailXrLabel.Visible = true;
						report.AdjustedHeaderXrLabel.Visible = true;
						report.AdjustedHeaderXrLabel.Left = left;
						report.adjustedDetailXrLabel.Left = left;
						report.adjustedFooterXrLabel.Visible = true;
						report.adjustedFooterXrLabel.Left = left;
						left += report.adjustedDetailXrLabel.Width;
					}
					else
					{
						report.AdjustedHeaderXrLabel.Visible = false;
						report.adjustedDetailXrLabel.Visible = false;
						report.adjustedFooterXrLabel.Visible = false;
					}
					report.printDateXrPageInfo.Left = left - 185;
					report.reportCriteriaXrLabel.Width = left - 190;
					report.reportTitleXrLabel.Width = left;
					report.headerXrPanel.Width = left;
					report.footerXrPanel.Width = left;
					report.pageNumberXrPageInfo.Left = left - 100;
					break;
				}
				case "PalletTransactionXtraReport":
				{
					PalletTransactionXtraReport report = (PalletTransactionXtraReport)m_Report;
					left = 240;
					report.totalsXRLabel.Width = 600;
					report.totalOverShippedXRLabel.Width = 600;
					if (this.ptVendorCheckEdit.Checked == true)
					{
						report.vendorHeaderXrLabel.Visible = true;
						report.vendorDetailXrLabel.Visible = true;
						report.vendorHeaderXrLabel.Left = left;
						report.vendorDetailXrLabel.Left = left;
						left += report.vendorDetailXrLabel.Width;
					}
					else
					{
						report.vendorHeaderXrLabel.Visible = false;
						report.vendorDetailXrLabel.Visible = false;
						report.totalsXRLabel.Width -= report.vendorDetailXrLabel.Width;
						report.totalOverShippedXRLabel.Width -= report.vendorDetailXrLabel.Width;
					}
					if (this.ptDestinationCheckEdit.Checked == true)
					{
						report.destinationHeaderXrLabel.Visible = true;
						report.destinationDetailXrLabel.Visible = true;
						report.destinationHeaderXrLabel.Left = left;
						report.destinationDetailXrLabel.Left = left;
						left += report.destinationDetailXrLabel.Width;
					}
					else
					{
						report.destinationHeaderXrLabel.Visible = false;
						report.destinationDetailXrLabel.Visible = false;
						report.totalsXRLabel.Width -= report.destinationDetailXrLabel.Width;
						report.totalOverShippedXRLabel.Width -= report.destinationDetailXrLabel.Width;
					}
					report.bolXrLabel.Left = left;
					report.bolDetailXrLabel.Left = left;
					left += report.bolDetailXrLabel.Width;
					report.xRLOverShippedTotal.Left = left;
					report.xRLOverShippedTotal.Width = 200;
					if (this.ptReceivedCheckEdit.Checked == true)
					{
						report.recieveHeaderXrLabel.Visible = true;
						report.receivedDetailXrLabel.Visible = true;
						report.receivedTotalXRLabel.Visible = true;
						report.recieveHeaderXrLabel.Left = left;
						report.receivedDetailXrLabel.Left = left;
						report.receivedTotalXRLabel.Left = left;
						left += report.receivedDetailXrLabel.Width;
					}
					else
					{
						report.recieveHeaderXrLabel.Visible = false;
						report.receivedDetailXrLabel.Visible = false;
						report.receivedTotalXRLabel.Visible = false;
						report.xRLOverShippedTotal.Width -= report.receivedDetailXrLabel.Width;
					}
					if (this.ptShippedCheckEdit.Checked == true)
					{
						report.shippedHeadeerXrLabel.Visible = true;
						report.shippedDetailXrLabel.Visible = true;
						report.shippedTotalXrLabel.Visible = true;
						report.shippedHeadeerXrLabel.Left = left;
						report.shippedDetailXrLabel.Left = left;
						report.shippedTotalXrLabel.Left = left;
						left += report.shippedDetailXrLabel.Width;
					}
					else
					{
						report.shippedHeadeerXrLabel.Visible = false;
						report.shippedDetailXrLabel.Visible = false;
						report.shippedTotalXrLabel.Visible = false;
						report.xRLOverShippedTotal.Width -= report.shippedDetailXrLabel.Width;
					}
					report.printDateXrPageInfo.Left = left - 185;
					report.reportCriteriaXrLabel.Width = left - 190;
					report.headerXrPanel.Width = left;
					report.reportTitleXrLabel.Width = left;
					report.pageNumberXrPageInfo.Left = left - 100;
					break;
				}
			}

		}

		public void BindReportColumns(string reportCodeName)
		{

			switch (reportCodeName)
			{
				case "ProductionDetailXtraReport":
				{
					ProductionXtraReport report = (ProductionXtraReport)m_Report;
					report.dateDetailXrLabel.DataBindings.Add("Text", m_Production, "ProdMainDate", "{0:dddd, MM/dd/yyyy}");
					report.shiftDetailXrLabel.DataBindings.Add("Text", m_Production, "Shift");
					report.customerNameDetailXrLabel.DataBindings.Add("Text", m_Production, "CustomerName");
					report.lotDetailXrLabel.DataBindings.Add("Text", m_Production, "ProdMainLot");
					report.itemCodeDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemCode");
					report.itemDescriptionDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemDescription");
					report.startTimeDetailXrLabel.DataBindings.Add("Text", m_Production, "ProdMainTimeStart", "{0:h:mm tt}");
					report.stopTimeDetailXrLabel.DataBindings.Add("Text", m_Production, "ProdMainTimeStop", "{0:h:mm tt}");
					report.quantityDetailXrLabel.DataBindings.Add("Text", m_Production, "ProdMainQuantity");
					report.quantityFooterXrLabel.DataBindings.Add("Text", m_Production, "ProdMainQuantity");
					report.machineLineDetailXrLabel.DataBindings.Add("Text", m_Production, "MachineLine");
					report.packersDetailXrLabel.DataBindings.Add("Text", m_Production, "ProdMainPackers");
					report.reportTitleXrLabel.Text = ReportTitle;
					this.Text = ReportTitle;
					break;
				}
				case "ProductionSummaryXtraReport":
				{
					ProductionSummaryXtraReport report = (ProductionSummaryXtraReport)m_Report;
					this.Text = ReportTitle;
					break;
				}
				case "ProductionMachineXtraReport":
				{
					ProductionMachineXtraReport report = (ProductionMachineXtraReport)m_Report;
					this.Text = ReportTitle;
					break;
				}
				case "ProductionShiftXtraReport":
				{
					ProductionShiftXtraReport report = (ProductionShiftXtraReport)m_Report;
					this.Text = ReportTitle;
					break;
				}
				case "ProductionEntriesXtraReport":
				{
					ProductionXtraReport report = (ProductionXtraReport)m_Report;
					report.dateDetailXrLabel.DataBindings.Add("Text", m_Production, "InventoryDate", "{0:dddd, MM/dd/yyyy}");
					report.customerNameDetailXrLabel.DataBindings.Add("Text", m_Production, "CustomerName");
					report.lotDetailXrLabel.DataBindings.Add("Text", m_Production, "Lot");
					report.itemCodeDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemCode");
					report.itemDescriptionDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemDescription");
					report.quantityDetailXrLabel.DataBindings.Add("Text", m_Production, "InventoryQuantity");
					report.quantityFooterXrLabel.DataBindings.Add("Text", m_Production, "InventoryQuantity");
					report.poDetailXrLabel.DataBindings.Add("Text", m_Production, "PO");
					report.reportTitleXrLabel.Text = ReportTitle;
					this.Text = ReportTitle;
					break;
				}
				case "CostingXtraReport":
				case "CostingSmallXtraReport":
				case "FinancialCostingXtraReport":
				{
					CostingXtraReport report = (CostingXtraReport)m_Report;
					report.dateDetailXrLabel.DataBindings.Add("Text", m_Production, "ProdMainDate", "{0:dddd, MMMM dd, yyyy}");
					report.shiftDetailXrLabel.DataBindings.Add("Text", m_Production, "ShiftName", "");
					report.customerNameDetailXrLabel.DataBindings.Add("Text", m_Production, "CustomerName", "");
					report.lotDetailXrLabel.DataBindings.Add("Text", m_Production, "ProdMainLot", "");
					report.itemCodeDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemCode", "");
					report.itemDescriptionDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemDescription", "");
					report.startTimeDetailXrLabel.DataBindings.Add("Text", m_Production, "ProdMainTimeStart", "{0:h:mm tt}");
					report.stopTimeDetailXrLabel.DataBindings.Add("Text", m_Production, "ProdMainTimeStop", "{0:h:mm tt}");
					report.quantityDetailXrLabel.DataBindings.Add("Text", m_Production, "ProdMainQuantity", "");
					report.expectedDetailXrLabel.DataBindings.Add("Text", m_Production, "ExpectedProduction", "{0:#.##}");
					report.differenceDetailXrLabel.DataBindings.Add("Text", m_Production, "ProductionDifference", "{0:#.##}");
					report.machineLineDetailXrLabel.DataBindings.Add("Text", m_Production, "MachineLineName", "");
					report.speedDetailXrLabel.DataBindings.Add("Text", m_Production, "intMachineSpeed", "");
					report.operatorDetailXrLabel.DataBindings.Add("Text", m_Production, "ProdMainOperators", "");
					report.packerDetailXrLabel.DataBindings.Add("Text", m_Production, "ProdMainPackers", "");
					report.superDetailXrLabel.DataBindings.Add("Text", m_Production, "ProdMainSupers", "");
					report.priceDetailXrLabel.DataBindings.Add("Text", m_Production, "TotalPrice", "{0:$0.00}");
					report.rebateDetailXrLabel.DataBindings.Add("Text", m_Production, "Rebate", "{0:$0.00}");
					report.freightDetailXrLabel.DataBindings.Add("Text", m_Production, "Freight", "{0:$0.00}");
					report.filmDetailXrLabel.DataBindings.Add("Text", m_Production, "Film", "{0:$0.00}");
					report.boxesDetailXrLabel.DataBindings.Add("Text", m_Production, "Boxes", "{0:$0.00}");
					report.stretchWrapDetailXrLabel.DataBindings.Add("Text", m_Production, "StretchWrap", "{0:$0.00}");
					report.palletsDetailXrLabel.DataBindings.Add("Text", m_Production, "Pallets", "{0:$0.00}");
					report.totalHoursFooterXRLabel.DataBindings.Add("Text", m_Production, "TotalHours", "");
					report.quantityFooterXRLabel.DataBindings.Add("Text", m_Production, "ProdMainQuantity", "{0:#,#}");
					report.expectedFooterXRLabel.DataBindings.Add("Text", m_Production, "ExpectedProduction", "{0:#.##}");
					report.priceFooterXrLabel.DataBindings.Add("Text", m_Production, "TotalPrice", "");
					report.rebateFooterXrLabel.DataBindings.Add("Text", m_Production, "Rebate", "{0:$0.00}");
					report.freightFooterXrLabel.DataBindings.Add("Text", m_Production, "Freight", "");
					report.filmFooterXrLabel.DataBindings.Add("Text", m_Production, "Film", "{0:$0.00}");
					report.boxesFooterXrLabel.DataBindings.Add("Text", m_Production, "Boxes", "{0:$0.00}");
					report.stretchWrapFooterXrLabel.DataBindings.Add("Text", m_Production, "StretchWrap", "{0:$0.00}");
					report.palletsFooterXrLabel.DataBindings.Add("Text", m_Production, "Pallets", "{0:$0.00}");
					this.Text = ReportTitle;
					break;
				}
				case "ShippingXtraReport":
				{
					TransportationXtraReport report = (TransportationXtraReport)m_Report;
					report.dateDetailXrLabel.DataBindings.Add("Text", null, "ShipMainDate", "{0:dddd, MM/dd/yyyy}");
					report.shiftDetailXrLabel.DataBindings.Add("Text", null, "ShiftName");
					report.customerNameDetailXrLabel.DataBindings.Add("Text", null, "CustomerName");
					report.bolDetailXrLabel.DataBindings.Add("Text", null, "ShipMainBOL");
					report.poDetailXrLabel.DataBindings.Add("Text", null, "strPO");
					report.deliveryNoteNumberDetailXrLabel.DataBindings.Add("Text", null, "DeliveryNoteNumber");
					report.destinationDetailXrLabel.DataBindings.Add("Text", null, "ShippingName");
					report.lotDetailXrLabel.DataBindings.Add("Text", null, "ShipDetLot");
					report.lpnDetailXrLabel.DataBindings.Add("Text", null, "FullLPNNumber");
					report.expirationDateDetailXrLabel.DataBindings.Add("Text", null, "ExpirationDate");
					report.expirationDateDetailXrLabel.DataBindings.Add("Tag", null, "ExpirationDateFormat");
					report.itemCodeDetailXrLabel.DataBindings.Add("Text", null, "ItemCode");
					report.itemDescriptionDetailXrLabel.DataBindings.Add("Text", null, "ItemDescription");
					report.quantityDetailXrLabel.DataBindings.Add("Text", null, "ShipDetDetQty");
					report.quantityFooterXrLabel.DataBindings.Add("Text", null, "ShipDetDetQty");
					report.carrierDetailXrLabel.DataBindings.Add("Text", null, "CarrierName");
					report.trailerDetailXrLabel.DataBindings.Add("Text", null, "strTrailer");
					report.sealDetailXrLabel.DataBindings.Add("Text", null, "strSeal");
					report.reportTitleXrLabel.Text = ReportTitle;
					this.Text = ReportTitle;
					break;
				}
				case "ShippingReturnsXtraReport":
				{
					TransportationXtraReport report = (TransportationXtraReport)m_Report;
					report.dateDetailXrLabel.DataBindings.Add("Text", null, "ShipMainDate", "{0:dddd, MM/dd/yyyy}");
					report.shiftDetailXrLabel.DataBindings.Add("Text", null, "ShiftName");
					report.customerNameDetailXrLabel.DataBindings.Add("Text", null, "CustomerName");
					report.bolDetailXrLabel.DataBindings.Add("Text", null, "ShipMainBOL");
					report.poDetailXrLabel.DataBindings.Add("Text", null, "strPO");
					report.deliveryNoteNumberDetailXrLabel.DataBindings.Add("Text", null, "DeliveryNoteNumber");
					report.destinationDetailXrLabel.DataBindings.Add("Text", null, "ShippingName");
					report.lotDetailXrLabel.DataBindings.Add("Text", null, "ReturnDetLot");
					report.expirationDateDetailXrLabel.DataBindings.Add("Text", null, "ExpirationDate");
					report.expirationDateDetailXrLabel.DataBindings.Add("Tag", null, "ExpirationDateFormat");
					report.itemCodeDetailXrLabel.DataBindings.Add("Text", null, "ItemCode");
					report.itemDescriptionDetailXrLabel.DataBindings.Add("Text", null, "ItemDescription");
					report.quantityDetailXrLabel.DataBindings.Add("Text", null, "intUnits");
					report.quantityFooterXrLabel.DataBindings.Add("Text", null, "intUits");
					report.carrierDetailXrLabel.DataBindings.Add("Text", null, "CarrierName");
					report.trailerDetailXrLabel.DataBindings.Add("Text", null, "strTrailer");
					report.sealDetailXrLabel.DataBindings.Add("Text", null, "strSeal");
					report.reportTitleXrLabel.Text = ReportTitle;
					this.Text = ReportTitle;
					break;
				}
				case "ReceivingXtraReport":
				{
					TransportationXtraReport report = (TransportationXtraReport)m_Report;
					report.dateDetailXrLabel.DataBindings.Add("Text", null, "ReceivDate", "{0:dddd, MM/dd/yyyy}");
					report.shiftDetailXrLabel.DataBindings.Add("Text", null, "ShiftName");
					report.customerNameDetailXrLabel.DataBindings.Add("Text", null, "CustomerName");
					report.bolDetailXrLabel.DataBindings.Add("Text", null, "ReceivBOL");
					report.poDetailXrLabel.DataBindings.Add("Text", null, "strPO");
					report.vendorDetailXrLabel.DataBindings.Add("Text", null, "VendorName");
					report.lotDetailXrLabel.DataBindings.Add("Text", null, "ReceivDetLot");
					report.expirationDateDetailXrLabel.DataBindings.Add("Text", null, "ExpirationDate");
					report.expirationDateDetailXrLabel.DataBindings.Add("Tag", null, "ExpirationDateFormat");
					report.itemCodeDetailXrLabel.DataBindings.Add("Text", null, "ItemCode");
					report.itemDescriptionDetailXrLabel.DataBindings.Add("Text", null, "ItemDescription");
					report.quantityDetailXrLabel.DataBindings.Add("Text", null, "intUnits");
					report.quantityFooterXrLabel.DataBindings.Add("Text", null, "intUnits");
					report.carrierDetailXrLabel.DataBindings.Add("Text", null, "CarrierName");
					report.trailerDetailXrLabel.DataBindings.Add("Text", null, "strTrailer");
					report.sealDetailXrLabel.DataBindings.Add("Text", null, "strSeal");
					report.reportTitleXrLabel.Text = ReportTitle;
					this.Text = ReportTitle;
					break;
				}
				case "ReceivingReturnsXtraReport":
				{
					TransportationXtraReport report = (TransportationXtraReport)m_Report;
					report.dateDetailXrLabel.DataBindings.Add("Text", null, "ReceivDate", "{0:dddd, MM/dd/yyyy}");
					report.shiftDetailXrLabel.DataBindings.Add("Text", null, "ShiftName");
					report.customerNameDetailXrLabel.DataBindings.Add("Text", null, "CustomerName");
					report.bolDetailXrLabel.DataBindings.Add("Text", null, "ReceivBOL");
					report.poDetailXrLabel.DataBindings.Add("Text", null, "strPO");
					report.vendorDetailXrLabel.DataBindings.Add("Text", null, "VendorName");
					report.lotDetailXrLabel.DataBindings.Add("Text", null, "ReturnDetLot");
					report.expirationDateDetailXrLabel.DataBindings.Add("Text", null, "ExpirationDate");
					report.expirationDateDetailXrLabel.DataBindings.Add("Tag", null, "ExpirationDateFormat");
					report.itemCodeDetailXrLabel.DataBindings.Add("Text", null, "ItemCode");
					report.itemDescriptionDetailXrLabel.DataBindings.Add("Text", null, "ItemDescription");
					report.quantityDetailXrLabel.DataBindings.Add("Text", null, "ReturnDetQty");
					report.quantityFooterXrLabel.DataBindings.Add("Text", null, "ReturnDetQty");
					report.carrierDetailXrLabel.DataBindings.Add("Text", null, "CarrierName");
					report.trailerDetailXrLabel.DataBindings.Add("Text", null, "strTrailer");
					report.sealDetailXrLabel.DataBindings.Add("Text", null, "strSeal");
					report.reportTitleXrLabel.Text = ReportTitle;
					this.Text = ReportTitle;
					break;
				}
				case "InventoryAdjustmentXtraReport":
				{
					InventoryXtraReport report = (InventoryXtraReport)m_Report;
					report.dateDetailXrLabel.DataBindings.Add("Text", m_Production, "AdjustmentDate", "{0:dddd, MM/dd/yyyy}");
					report.customerNameDetailXrLabel.DataBindings.Add("Text", m_Production, "CustomerName");
					report.itemCodeDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemCode");
					report.quantityDetailXrLabel.DataBindings.Add("Text", m_Production, "AdjustmentQTY", "{0:#,##0.######}");
					report.reasonDetailXrLabel.DataBindings.Add("Text", m_Production, "Reason");
					report.reportTitleXrLabel.Text = ReportTitle;
					report.quantityHeaderXrLabel.Text = "Adjustment Qty";
					this.Text = ReportTitle;
					break;
				}
				case "PhysicalInventoryXtraReport":
				{
					InventoryXtraReport report = (InventoryXtraReport)m_Report;
					report.customerNameDetailXrLabel.DataBindings.Add("Text", m_Production, "CustomerName");
					report.itemCodeDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemCode");
					report.itemDescriptionDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemDescription");
					report.itemTypeDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemType");
					report.quantityDetailXrLabel.DataBindings.Add("Text", m_Production, "QuantityOnHand", "{0:#,##0.######}");
					report.byPalletDetailXrLabel.DataBindings.Add("Text", m_Production, "InventoryByPallets");
					report.reportTitleXrLabel.Text = ReportTitle;
					report.quantityHeaderXrLabel.Text = "Current Inventory";
					break;
				}
				case "OldCurrentInventoryXtraReport":
				{
					InventoryXtraReport report = (InventoryXtraReport)m_Report;
					report.customerNameDetailXrLabel.DataBindings.Add("Text", null, "CustomerName");
					report.itemCodeDetailXrLabel.DataBindings.Add("Text", null, "ItemCode");
					report.itemDescriptionDetailXrLabel.DataBindings.Add("Text", null, "ItemDescription");
					report.itemTypeDetailXrLabel.DataBindings.Add("Text", null, "ItemType");
					report.quantityDetailXrLabel.DataBindings.Add("Text", null, "QuantityOnHand", "{0:#,##0.######}");
					report.byPalletDetailXrLabel.DataBindings.Add("Text", null, "InventoryByPallets");
					report.UOMDetailXrLabel.DataBindings.Add("Text", null, "UOM");
					report.reportTitleXrLabel.Text = ReportTitle;
					report.quantityHeaderXrLabel.Text = "Current Inventory";
					report.byPalletHeaderXrLabel.Text = "Inventory by Pallet";
					this.Text = ReportTitle;
					break;
				}
				case "FinishedProductAvailabilityXtraReport":
				{
					InventoryXtraReport report = (InventoryXtraReport)m_Report;
					report.customerNameDetailXrLabel.DataBindings.Add("Text", m_Production, "CustomerName");
					report.itemCodeDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemCode");
					report.itemDescriptionDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemDescription");
					report.quantityDetailXrLabel.DataBindings.Add("Text", m_Production, "Availability", "{0:#,##0.######}");
					report.byPalletDetailXrLabel.DataBindings.Add("Text", m_Production, "AvailabilityByPallet");
					report.RMitemCodeDetailXrLabel.DataBindings.Add("Text", m_Production, "RMItemCode");
					report.RMitemDescriptionDetailXrLabel.DataBindings.Add("Text", m_Production, "RMItemDescription");
					report.reportTitleXrLabel.Text = ReportTitle;
					report.quantityHeaderXrLabel.Text = "Availability";
					report.byPalletHeaderXrLabel.Text = "Availability by Pallet";
					this.Text = ReportTitle;
					break;
				}
				case "ItemsListXtraReport":
				{
					ItemsXtraReport report = (ItemsXtraReport)m_Report;
					report.customerNameDetailXrLabel.DataBindings.Add("Text", m_Production, "CustomerName");
					report.itemCodeDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemCode");
					report.itemDescriptionDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemDescription");
					report.itemTypeDetailXrLabel.DataBindings.Add("Text", m_Production, "ItemType");
					report.uomDetailXrLabel.DataBindings.Add("Text", m_Production, "strUnitOfMeasure");
					report.quantityDetailXrLabel.DataBindings.Add("Text", m_Production, "intQtyPerUnit");
					report.unitsPerCaseDetailXrLabel.DataBindings.Add("Text", m_Production, "intUnitsPerCase", "{0:N2}");
					report.casesPerPalletDetailXrLabel.DataBindings.Add("Text", m_Production, "intCasesPerPallet");
					report.reportTitleXrLabel.Text = ReportTitle;
					this.Text = ReportTitle;
					break;
				}
				case "ItemsTransactionsXtraReport":
				{
					MessageBox.Show("This report has been replaced with the Item Transaction Summary report.");
					return;
					//Dim report As ItemTransactionXtraReport = CType(m_Report, ItemTransactionXtraReport)
					//With report
					//    .reportTitleXrLabel.Text = ReportTitle
					//    Me.Text = ReportTitle
					//End With
				}
				case "ItemTransactionSummaryXtraReport":
				{
					ItemsXtraReport report = (ItemsXtraReport)m_Report;
					report.customerNameDetailXrLabel.DataBindings.Add("Text", null, "CustomerName");
					report.itemCodeDetailXrLabel.DataBindings.Add("Text", null, "ItemCode");
					report.itemDescriptionDetailXrLabel.DataBindings.Add("Text", null, "ItemDescription");
					report.itemTypeDetailXrLabel.DataBindings.Add("Text", null, "ItemType");
					report.producedDetailXrLabel.DataBindings.Add("Text", null, "Produced");
					report.shippedDetailXrLabel.DataBindings.Add("Text", null, "Shipped");
					report.receivedDetailXrLabel.DataBindings.Add("Text", null, "Received");
					report.adjustedDetailXrLabel.DataBindings.Add("Text", null, "Adjusted");
					report.producedFooterXrLabel.DataBindings.Add("Text", null, "Produced");
					report.shippedFooterXrLabel.DataBindings.Add("Text", null, "Shipped");
					report.receivedFooterXrLabel.DataBindings.Add("Text", null, "Received");
					report.adjustedFooterXrLabel.DataBindings.Add("Text", null, "Adjusted");
					report.usedInProductionDetailXrLabel.DataBindings.Add("Text", null, "UsedInProduction");
					report.usedInProductionFooterXrLabel.DataBindings.Add("Text", null, "UsedInProduction");
					report.reportTitleXrLabel.Text = ReportTitle;
					this.Text = ReportTitle;
					break;
				}
				case "PalletTransactionXtraReport":
				{
					PalletTransactionXtraReport report = (PalletTransactionXtraReport)m_Report;
					report.reportTitleXrLabel.Text = ReportTitle;
					this.Text = ReportTitle;
					break;
				}
				case "PalletControlXtraReport":
				{
					PalletsXtraReport report = (PalletsXtraReport)m_Report;
					report.customerNameDetailXrLabel.DataBindings.Add("Text", m_Production, "CustomerName");
					report.byPalletDetailXrLabel.DataBindings.Add("Text", m_Production, "PalletQTY");
					report.reportTitleXrLabel.Text = ReportTitle;
					this.Text = ReportTitle;
					break;
				}
				case "AuditTrailXtraReport":
				{
					AuditTrailXtraReport report = (AuditTrailXtraReport)m_Report;
					report.userNameDetailXrLabel.DataBindings.Add("Text", m_Production, "strUserName");
					report.dateDetailXrLabel.DataBindings.Add("Text", m_Production, "ChangeDate");
					report.recordTypeDetailXrLabel.DataBindings.Add("Text", m_Production, "RecordType");
					report.recordChangesDetailXrLabel.DataBindings.Add("Text", m_Production, "RecordChanges");
					report.reportTitleXrLabel.Text = ReportTitle;
					this.Text = ReportTitle;
					break;
				}
			}

		}

		private bool m_OnlyAssigned;
		public bool OnlyAssigned
        {
            get => m_OnlyAssigned;
            set => m_OnlyAssigned = value;
        }

        private void BindReport()
		{

			switch (m_SelectedReport)
			{
				case "ProductionDetailXtraReport":
					m_Production = m_ProductionBLL.GetProductionReport((DateTime?)fromDateEdit.EditValue, (DateTime?)toDateEdit.EditValue, (int?)customerLookUpEdit.EditValue, (int?)shiftLookUpEdit.EditValue, (int?)machineLookUpEdit.EditValue, GetItemsSelected('|'), InactiveItemsCheckEdit.Checked, InactiveCustomersCheckEdit.Checked);
					m_Report.DataSource = m_Production;
					if (OnlyAssigned)
					{
						m_Report.FilterString = (new InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session))).ToString();
					}
					((ProductionXtraReport)m_Report).Detail.SortFields.AddRange(new GroupField[]
					{
						new GroupField("ProdMainDate"),
						new GroupField("ItemCode")
					});
					((ProductionXtraReport)m_Report).reportCriteriaXrLabel.Text = GetFilterUsed(true);

					break;
				case "ProductionSummaryXtraReport":
					m_Production = m_ProductionBLL.GetProductionReport((DateTime?)fromDateEdit.EditValue, (DateTime?)toDateEdit.EditValue, (int?)customerLookUpEdit.EditValue, (int?)shiftLookUpEdit.EditValue, (int?)machineLookUpEdit.EditValue, GetItemsSelected('|'), InactiveItemsCheckEdit.Checked, InactiveCustomersCheckEdit.Checked);
					m_Report.DataSource = m_Production;
					if (OnlyAssigned)
					{
						m_Report.FilterString = (new InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session))).ToString();
					}
					((ProductionSummaryXtraReport)m_Report).CriteriaLabel.Text = GetFilterUsed(true);

					break;
				case "ProductionEntriesXtraReport":
					m_Report.DataSource = (new ProductionEntriesReportBLL()).GetProductionEntriesReport((DateTime?)fromDateEdit.EditValue, (DateTime?)toDateEdit.EditValue, (int?)customerLookUpEdit.EditValue, (lotTextEdit.EditValue == null ? null : Convert.ToString(lotTextEdit.EditValue)), (poTextEdit.EditValue == null ? null : Convert.ToString(poTextEdit.EditValue)), GetItemsSelected('|'), InactiveItemsCheckEdit.Checked, InactiveCustomersCheckEdit.Checked, (int?)shiftLookUpEdit.EditValue);
					if (OnlyAssigned)
					{
						m_Report.FilterString = (new InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session))).ToString();
					}
					((ProductionXtraReport)m_Report).Detail.SortFields.AddRange(new GroupField[]
					{
						new GroupField("InventoryDate"),
						new GroupField("ItemCode")
					});
					((ProductionXtraReport)m_Report).reportCriteriaXrLabel.Text = GetFilterUsed(true);

					break;
				case "CostingXtraReport":
				case "CostingSmallXtraReport":
				case "FinancialCostingXtraReport":
					m_Report.DataSource = (new CostingReportsBLL()).GetCostingReport((DateTime?)fromDateEdit.EditValue, (DateTime?)toDateEdit.EditValue, (int?)customerLookUpEdit.EditValue, (int?)shiftLookUpEdit.EditValue, (int?)machineLookUpEdit.EditValue, GetItemsSelected('|'), InactiveItemsCheckEdit.Checked, InactiveCustomersCheckEdit.Checked);
					if (OnlyAssigned)
					{
						m_Report.FilterString = (new InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session))).ToString();
					}
					((CostingXtraReport)m_Report).Detail.SortFields.AddRange(new GroupField[]
					{
						new GroupField("ProdMainDate"),
						new GroupField("ItemCode")
					});
					((CostingXtraReport)m_Report).reportCriteriaXrLabel.Text = GetFilterUsed(true);

					break;
				case "ShippingXtraReport":
					m_Report.DataSource = ShippingReportBLL.GetShippingReport((DateTime?)fromDateEdit.EditValue, (DateTime?)toDateEdit.EditValue, (int?)shiftLookUpEdit.EditValue, (int?)customerLookUpEdit.EditValue, (lotTextEdit.EditValue == null ? null : Convert.ToString(lotTextEdit.EditValue)), (poTextEdit.EditValue == null ? null : Convert.ToString(poTextEdit.EditValue)), (bolTextEdit.EditValue == null ? null : Convert.ToString(bolTextEdit.EditValue)), (deliveryNoteNumberTextEdit.EditValue == null ? null : Convert.ToString(deliveryNoteNumberTextEdit.EditValue)), (int?)destinationLookUpEdit.EditValue, (int?)carrierLookUpEdit.EditValue, GetItemsSelected('|'), InactiveItemsCheckEdit.Checked, InactiveCustomersCheckEdit.Checked, OnlyAssigned);
					((TransportationXtraReport)m_Report).Detail.SortFields.AddRange(new GroupField[]
					{
						new GroupField("ShipMainDate"),
						new GroupField("ItemCode")
					});
					((TransportationXtraReport)m_Report).reportCriteriaXrLabel.Text = GetFilterUsed(true);

					break;
				case "ShippingReturnsXtraReport":
					m_Report.DataSource = ShippingReturnsReportBLL.GetShippingReturnsReport((DateTime?)fromDateEdit.EditValue, (DateTime?)toDateEdit.EditValue, (int?)shiftLookUpEdit.EditValue, (int?)customerLookUpEdit.EditValue, (lotTextEdit.EditValue == null ? null : Convert.ToString(lotTextEdit.EditValue)), (bolTextEdit.EditValue == null ? null : Convert.ToString(bolTextEdit.EditValue)), (int?)destinationLookUpEdit.EditValue, (int?)carrierLookUpEdit.EditValue, GetItemsSelected('|'), InactiveItemsCheckEdit.Checked, InactiveCustomersCheckEdit.Checked, OnlyAssigned);
					((TransportationXtraReport)m_Report).Detail.SortFields.AddRange(new GroupField[]
					{
						new GroupField("ShipMainDate"),
						new GroupField("ItemCode")
					});
					((TransportationXtraReport)m_Report).reportCriteriaXrLabel.Text = GetFilterUsed(true);

					break;
				case "ReceivingXtraReport":
					m_Report.DataSource = ReceivingReportBLL.GetReceivingReport((DateTime?)fromDateEdit.EditValue, (DateTime?)toDateEdit.EditValue, (int?)shiftLookUpEdit.EditValue, (int?)customerLookUpEdit.EditValue, (lotTextEdit.EditValue == null ? null : Convert.ToString(lotTextEdit.EditValue)), (poTextEdit.EditValue == null ? null : Convert.ToString(poTextEdit.EditValue)), (bolTextEdit.EditValue == null ? null : Convert.ToString(bolTextEdit.EditValue)), (int?)vendorLookUpEdit.EditValue, (int?)carrierLookUpEdit.EditValue, GetItemsSelected('|'), InactiveItemsCheckEdit.Checked, OnlyAssigned, InactiveCustomersCheckEdit.Checked);
					((TransportationXtraReport)m_Report).Detail.SortFields.AddRange(new GroupField[]
					{
						new GroupField("ReceivDate"),
						new GroupField("ItemCode")
					});
					((TransportationXtraReport)m_Report).reportCriteriaXrLabel.Text = GetFilterUsed(true);

					break;
				case "ReceivingReturnsXtraReport":
					m_Report.DataSource = ReceivingReturnsReportBLL.GetReceivingReturnsReport((DateTime?)fromDateEdit.EditValue, (DateTime?)toDateEdit.EditValue, (int?)shiftLookUpEdit.EditValue, (int?)customerLookUpEdit.EditValue, (lotTextEdit.EditValue == null ? null : Convert.ToString(lotTextEdit.EditValue)), (bolTextEdit.EditValue == null ? null : Convert.ToString(bolTextEdit.EditValue)), (int?)vendorLookUpEdit.EditValue, (int?)carrierLookUpEdit.EditValue, GetItemsSelected('|'), InactiveItemsCheckEdit.Checked, InactiveCustomersCheckEdit.Checked, OnlyAssigned);
					((TransportationXtraReport)m_Report).Detail.SortFields.AddRange(new GroupField[]
					{
						new GroupField("ReceivDate"),
						new GroupField("ItemCode")
					});
					((TransportationXtraReport)m_Report).reportCriteriaXrLabel.Text = GetFilterUsed(true);

					break;
				case "InventoryAdjustmentXtraReport":
					m_Report.DataSource = (new InventoryAdjustmentReportBLL()).GetInventoryAdjustmentReport((DateTime?)fromDateEdit.EditValue, (DateTime?)toDateEdit.EditValue, (int?)customerLookUpEdit.EditValue, GetItemsSelected('|'), InactiveItemsCheckEdit.Checked, InactiveCustomersCheckEdit.Checked);
					if (OnlyAssigned)
					{
						m_Report.FilterString = (new InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session))).ToString();
					}
					((InventoryXtraReport)m_Report).Detail.SortFields.AddRange(new GroupField[]
					{
						new GroupField("AdjustmentDate"),
						new GroupField("ItemCode")
					});
					((InventoryXtraReport)m_Report).reportCriteriaXrLabel.Text = GetFilterUsed(true);

					break;
				case "PhysicalInventoryXtraReport":
					m_Report.DataSource = (new PhysicalInventoryWorksheetBLL()).GetPhysicalInventoryWorksheet((int?)customerLookUpEdit.EditValue, (itemTypeLookUpEdit.EditValue == null ? null : Convert.ToString(itemTypeLookUpEdit.EditValue)), GetItemsSelected('|'), InactiveItemsCheckEdit.Checked, InactiveCustomersCheckEdit.Checked);
					if (OnlyAssigned)
					{
						m_Report.FilterString = (new InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session))).ToString();
					}
					((InventoryXtraReport)m_Report).Detail.SortFields.Add(new GroupField("ItemCode"));
					((InventoryXtraReport)m_Report).reportCriteriaXrLabel.Text = GetFilterUsed(true);

					break;
				case "CurrentInventoryXtraReport":
					m_Report.DataSource = CurrentInventoryReportBLL.GetCurrentInventoryReport((int?)customerLookUpEdit.EditValue, (itemTypeLookUpEdit.EditValue == null ? null : Convert.ToString(itemTypeLookUpEdit.EditValue)), GetItemsSelected('|'), InactiveItemsCheckEdit.Checked, InactiveCustomersCheckEdit.Checked, outOfStockCheckEdit.Checked, OnlyAssigned, null);
					((InventoryXtraReport)m_Report).Detail.SortFields.Add(new GroupField("ItemCode"));
					((InventoryXtraReport)m_Report).reportCriteriaXrLabel.Text = GetFilterUsed(true);

					break;
				case "FinishedProductAvailabilityXtraReport":
					m_Report.DataSource = (new FinishedProductAvailabilityReportBLL()).GetFinishedProductAvailabilityReport((int?)customerLookUpEdit.EditValue, InactiveItemsCheckEdit.Checked, InactiveCustomersCheckEdit.Checked, GetItemsSelected('|'));
					if (OnlyAssigned)
					{
						m_Report.FilterString = (new InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session))).ToString();
					}
					((InventoryXtraReport)m_Report).Detail.SortFields.Add(new GroupField("ItemCode"));
					((InventoryXtraReport)m_Report).reportCriteriaXrLabel.Text = GetFilterUsed(true);

					break;
				case "ItemsListXtraReport":
					m_Report.DataSource = (new ItemsListBLL()).GetItemsList((int?)customerLookUpEdit.EditValue, (itemTypeLookUpEdit.EditValue == null ? null : Convert.ToString(itemTypeLookUpEdit.EditValue)), GetItemsSelected('|'), InactiveItemsCheckEdit.Checked, InactiveCustomersCheckEdit.Checked);
					if (OnlyAssigned)
					{
						m_Report.FilterString = (new InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session))).ToString();
					}
					((ItemsXtraReport)m_Report).Detail.SortFields.Add(new GroupField("ItemCode"));
					((ItemsXtraReport)m_Report).reportCriteriaXrLabel.Text = GetFilterUsed(true);

					break;
				case "ItemsTransactionsXtraReport":
					m_Report.DataSource = (new ItemsTransactionsReportBLL()).GetItemsTransactionsReport((DateTime?)fromDateEdit.EditValue, (DateTime?)toDateEdit.EditValue, (int?)itemCheckedListBoxControl.SelectedValue);
					if (OnlyAssigned)
					{
						m_Report.FilterString = (new InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session))).ToString();
					}
					((ItemTransactionXtraReport)m_Report).reportCriteriaXrLabel.Text = GetFilterUsed(true);

					break;
				case "ItemTransactionSummaryXtraReport":
					m_Report.DataSource = (new ItemTransactionSummaryReportBLL()).GetItemTransactionSummaryReport((DateTime?)fromDateEdit.EditValue, (DateTime?)toDateEdit.EditValue, (int?)customerLookUpEdit.EditValue, GetItemsSelected('|'), (itemTypeLookUpEdit.EditValue == null ? null : Convert.ToString(itemTypeLookUpEdit.EditValue)), OnlyAssigned);
					((ItemsXtraReport)m_Report).Detail.SortFields.Add(new GroupField("ItemCode"));
					((ItemsXtraReport)m_Report).reportCriteriaXrLabel.Text = GetFilterUsed(true);

					break;
				case "PalletTransactionXtraReport":
					m_Report.DataSource = (new PalletsTransactionReportBLL()).GetPalletTransactionReport((DateTime?)fromDateEdit.EditValue, (DateTime?)toDateEdit.EditValue, (int?)customerLookUpEdit.EditValue);
					if (OnlyAssigned)
					{
						m_Report.FilterString = (new InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session))).ToString();
					}
					((PalletTransactionXtraReport)m_Report).reportCriteriaXrLabel.Text = GetFilterUsed(true);

					break;
				case "PalletControlXtraReport":
					if (OnlyAssigned)
					{
						m_Report.FilterString = (new InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session))).ToString();
					}
					m_Report.DataSource = (new PalletControlReportBLL()).GetPalletControlReport();

					break;
				case "AuditTrailXtraReport":
					m_Report.DataSource = (new AuditTrailReportBLL()).GetAuditTrailReport((DateTime?)fromDateEdit.EditValue, (DateTime?)toDateEdit.EditValue);
					((AuditTrailXtraReport)m_Report).reportCriteriaXrLabel.Text = GetFilterUsed(true);

					break;
				case "ProductionMachineXtraReport":
					((ProductionMachineXtraReport)m_Report).productionXPView.CriteriaString = GetXPOCriteriaString();
					if (OnlyAssigned)
					{
						m_Report.FilterString = (new InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session))).ToString();
					}
					((ProductionMachineXtraReport)m_Report).reportCriteriaXrLabel.Text = GetFilterUsed(true);
					break;
				case "ProductionShiftXtraReport":
					((ProductionShiftXtraReport)m_Report).productionXPView.CriteriaString = GetXPOCriteriaString();
					if (OnlyAssigned)
					{
						m_Report.FilterString = (new InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session))).ToString();
					}
					((ProductionShiftXtraReport)m_Report).reportCriteriaXrLabel.Text = GetFilterUsed(true);
					break;
			}

			try
			{
				m_Report.CreateDocument();


				if (m_Report.DataSource as XPView != null)
				{
					if (((XPView)m_Report.DataSource).Count <= 0)
					{
						MessageBox.Show("There's no data to display. Try changing your filter.");
					}
				}
				else if (m_Report.DataSource as ItemTransactionsList != null)
				{
					if (((ItemTransactionsList)m_Report.DataSource).Count <= 0)
					{
						MessageBox.Show("There's no data to display. Try changing your filter.");
					}
				}
				else if (m_Report.DataSource as ItemTransactionSummaryList != null)
				{
					if (((ItemTransactionSummaryList)m_Report.DataSource).Count <= 0)
					{
						MessageBox.Show("There's no data to display. Try changing your filter.");
					}
				}
				else if (m_Report.DataSource as PalletTransactionList != null)
				{
					if (((PalletTransactionList)m_Report.DataSource).Count <= 0)
					{
						MessageBox.Show("There's no data to display. Try changing your filter.");
					}
				}
				else
				{
					if (((DataTable)m_Report.DataSource).Rows.Count <= 0)
					{
						MessageBox.Show("There's no data to display. Try changing your filter.");
					}
				}
			}
			catch (NullReferenceException ex)
			{
				MessageBox.Show(string.Format("There was an error while trying to generate your report.{0}{1}", Environment.NewLine, ex.Message));
			}

		}

		private void filterRefreshSimpleButton_Click(System.Object sender, EventArgs e)
		{

			if (fromDateEdit.DateTime > toDateEdit.DateTime)
			{
				MessageBox.Show("The from date must be an earlier date than the to date.");
				return;
			}

			Cursor = Cursors.WaitCursor;
			if (m_SelectedReport != "PalletControlXtraReport" && m_SelectedReport != "ItemsTransactionsXtraReport" && m_SelectedReport != "PalletTransactionXtraReport")
			{
				m_Report.PrintingSystem.Document.AutoFitToPagesWidth = 0;
				m_Report.PrintingSystem.Document.ScaleFactor = 1;
			}
			BindReport();
			if (m_SelectedReport != "PalletControlXtraReport" && m_SelectedReport != "ItemsTransactionsXtraReport" && m_SelectedReport != "PalletTransactionXtraReport")
			{
				m_Report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
			}
			Cursor = Cursors.Default;

		}

		public string GetFilterUsed(bool display)
		{

			StringBuilder strSQL = new StringBuilder();

			if (fromDateEdit.EditValue != null && fromDateEdit.Enabled == true)
			{
				strSQL.AppendFormat("Date >= {0:d} AND ", fromDateEdit.EditValue.ToString());
			}

			if (toDateEdit.EditValue != null && toDateEdit.Enabled == true)
			{
				strSQL.AppendFormat("Date <= {0:d} AND ", toDateEdit.EditValue.ToString());
			}

			if (customerLookUpEdit.EditValue != null)
			{
				strSQL.AppendFormat("Customer Name = {0} AND ", customerLookUpEdit.Text);
			}

			if (itemCheckedListBoxControl.CheckedItems.Count >= 1)
			{
				strSQL.AppendFormat("Item Code IN {0} AND ", GetItemsSelected(',', true));
			}

			if (machineLookUpEdit.EditValue != null)
			{
				strSQL.AppendFormat("Machine Line = {0} AND ", machineLookUpEdit.Text);
			}

			if (shiftLookUpEdit.EditValue != null)
			{
				strSQL.AppendFormat("Shift = '{0}' AND ", shiftLookUpEdit.Text);
			}

			if (lotTextEdit.EditValue != null)
			{
				strSQL.AppendFormat("Lot # = {0} AND ", lotTextEdit.Text);
			}

			if (poTextEdit.EditValue != null)
			{
				strSQL.AppendFormat("PO # = {0} AND ", poTextEdit.Text);
			}

			if (bolTextEdit.EditValue != null)
			{
				strSQL.AppendFormat("BOL # = {0} AND ", bolTextEdit.Text);
			}

			if (deliveryNoteNumberTextEdit.EditValue != null)
			{
				strSQL.AppendFormat("DN # = {0} AND ", deliveryNoteNumberTextEdit.Text);
			}

			if (destinationLookUpEdit.EditValue != null)
			{
				strSQL.AppendFormat("Destination = {0} AND ", destinationLookUpEdit.Text);
			}

			if (carrierLookUpEdit.EditValue != null)
			{
				strSQL.AppendFormat("Carrier = {0} AND ", carrierLookUpEdit.Text);
			}

			if (vendorLookUpEdit.EditValue != null)
			{
				strSQL.AppendFormat("Vendor = {0} AND ", vendorLookUpEdit.Text);
			}

			if (itemTypeLookUpEdit.EditValue != null)
			{
				strSQL.AppendFormat("Item Type = {0} AND ", itemTypeLookUpEdit.Text);
			}

			if (InactiveCustomersCheckEdit.Checked)
			{
				strSQL.Append("Included inactive customers AND ");
			}

			if (InactiveItemsCheckEdit.Checked)
			{
				strSQL.Append("Included inactive items AND ");
			}

			if (outOfStockCheckEdit.Checked)
			{
				strSQL.Append("Included out of stock items AND ");
			}

			if (strSQL.Length > 5)
			{
				strSQL.Length -= 5;
			}

			return strSQL.ToString();

		}

		public string GetXPOCriteriaString()
		{

			StringBuilder strSQL = new StringBuilder();

			if (fromDateEdit.EditValue != null && fromDateEdit.Enabled == true)
			{
				strSQL.AppendFormat("[ProdMainDate] >= # {0:d}# AND ", fromDateEdit.EditValue.ToString());
			}

			if (toDateEdit.EditValue != null && toDateEdit.Enabled == true)
			{
				strSQL.AppendFormat("[ProdMainDate] <= # {0:d}# AND ", toDateEdit.EditValue.ToString());
			}

			if (customerLookUpEdit.EditValue != null)
			{
				strSQL.AppendFormat("[ProdMainItemID.ItemCustomerID] = '{0}' AND ", customerLookUpEdit.EditValue);
			}

			if (machineLookUpEdit.EditValue != null)
			{
				strSQL.AppendFormat("[ProdMainMachineLine] = {0} AND ", machineLookUpEdit.EditValue);
			}

			if (shiftLookUpEdit.EditValue != null)
			{
				strSQL.AppendFormat("[ProdMainShift] = '{0}' AND ", shiftLookUpEdit.EditValue);
			}

			if (InactiveCustomersCheckEdit.Checked == false)
			{
				strSQL.Append("[ProdMainItemID.ItemCustomerID.Inactive] = False AND ");
			}

			if (InactiveItemsCheckEdit.Checked == false)
			{
				strSQL.Append("[ProdMainItemID.Inactive] = False AND ");
			}

			if (itemCheckedListBoxControl.CheckedItems.Count >= 1)
			{
				strSQL.Append("(");
				for (int i = 0; i < itemCheckedListBoxControl.CheckedItems.Count; i++)
				{
					if (i > 0)
					{
						strSQL.Append(" OR ");
					}
					strSQL.Append(string.Format("[ProdMainItemID] = {0}", itemCheckedListBoxControl.CheckedItems[i].ToString()));
				}
				strSQL.Append(") AND ");
			}

			if (strSQL.Length > 5)
			{
				strSQL.Length -= 5;
			}

			return strSQL.ToString();

		}

		private string GetItemsSelected(char delimiter)
		{

			StringBuilder itemsSelected = new StringBuilder(string.Empty);
			for (int i = 0; i < itemCheckedListBoxControl.CheckedItems.Count; i++)
			{
				itemsSelected.Append(string.Format("{0}{1}", itemCheckedListBoxControl.CheckedItems[i].ToString(), delimiter));
			}

			return itemsSelected.ToString().TrimEnd(delimiter);

		}

		private string GetItemsSelected(char delimiter, bool display)
		{

			StringBuilder itemsSelected = new StringBuilder(string.Empty);
			for (int i = 0; i < itemCheckedListBoxControl.CheckedItems.Count; i++)
			{
				if (display == false)
				{
					itemsSelected.Append(string.Format("{0}{1}", itemCheckedListBoxControl.CheckedItems[i].ToString(), delimiter));
				}
				else
				{
					itemsSelected.Append(string.Format("{0}{1}", itemCheckedListBoxControl.GetItemText(itemCheckedListBoxControl.CheckedIndices[i]), delimiter));
				}
			}

			return itemsSelected.ToString().TrimEnd(delimiter);

		}

		private void columnsRefreshSimpleButton_Click(System.Object sender, EventArgs e)
		{

			this.Cursor = Cursors.WaitCursor;
			if (m_SelectedReport != "PalletControlXtraReport" && m_SelectedReport != "ItemsTransactionsXtraReport" && m_SelectedReport != "PalletTransactionXtraReport")
			{
				m_Report.PrintingSystem.Document.AutoFitToPagesWidth = 0;
				m_Report.PrintingSystem.Document.ScaleFactor = 1;
			}
			SetReportColumns(m_SelectedReport, 0);
			m_Report.CreateDocument();
			if (m_SelectedReport != "PalletControlXtraReport" && m_SelectedReport != "ItemsTransactionsXtraReport" && m_SelectedReport != "PalletTransactionXtraReport")
			{
				m_Report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
			}
			this.Cursor = Cursors.Default;

		}

		private string m_ReportTitle;
		public string ReportTitle
        {
            get
            {
                if (m_ReportTitle == "Physical Inventory Worksheet" || m_ReportTitle == "Items List")
                {
                    return m_ReportTitle;
                }
                else
                {
                    return string.Format("{0} Report", m_ReportTitle);
                }
            }
            set => m_ReportTitle = value;
        }

        private void ReportsXtraForm_Load(object sender, EventArgs e)
		{

			this.reportColumnsXtraTabControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;

		}

		private void itemCheckedListBoxControl_ItemCheck(System.Object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e)
		{

			if (m_Report.Name == "ItemsTransactionsXtraReport")
			{
				if (e.State == CheckState.Checked)
				{
					foreach (CheckedListBoxItem item in itemCheckedListBoxControl.Items)
					{
						if (item.Value != itemCheckedListBoxControl.Items[e.Index].Value && item.CheckState == CheckState.Checked)
						{
							item.CheckState = CheckState.Unchecked;
						}
					}
				}
			}

		}

	}
}