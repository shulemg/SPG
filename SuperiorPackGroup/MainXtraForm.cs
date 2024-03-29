﻿//INSTANT C# NOTE: Formerly VB project-level imports:
using DevExpress.Xpo;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections;
using System.Collections.Generic;

using System.Data;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SuperiorPackGroup
{
    public partial class MainXtraForm
    {

        private bool InstanceFieldsInitialized = false;

        public MainXtraForm()
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
            [DebuggerNonUserCode]
            get => _m_timer;
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized), DebuggerNonUserCode]
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
        private static UserPermissionsBLL m_UserPermissions;
        protected static CompanySettingsBLL m_CompanySettings;
        private static int? m_MinPerHour = null;
        private static float? m_OperatorsPay = null;
        private static float? m_SupersPay = null;
        private static float? m_PackersPay = null;
        private static int? m_VersionNumber = null;

        private void fileExitBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {

            Application.Exit();

        }

        private void listsCustomerBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            CustomersXtraForm form = new CustomersXtraForm();
            {
                form.MdiParent = this;
                if (form.CheckPermissions() == false)
                {
                    return;
                }
                form.Show();
                form.Activate();
            }
        }

        private void listsItemBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            ItemsXtraForm form = new ItemsXtraForm();
            {
                form.MdiParent = this;
                if (form.CheckPermissions() == false)
                {
                    return;
                }
                form.Show();
                form.Activate();
            }
        }

        private void listsMachineBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            MachineLinesXtraForm form = new MachineLinesXtraForm();
            {
                form.MdiParent = this;
                if (form.CheckPermissions() == false)
                {
                    return;
                }
                form.Show();
                form.Activate();
            }
        }

        private void listsShiftsBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShiftsXtraForm form = new ShiftsXtraForm();
            {
                form.MdiParent = this;
                if (form.CheckPermissions() == false)
                {
                    return;
                }
                form.Show();
                form.Activate();
            }
        }

        private void listsCarriersBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            CarriersXtraForm form = new CarriersXtraForm();
            {
                form.MdiParent = this;
                if (form.CheckPermissions() == false)
                {
                    return;
                }
                form.Show();
                form.Activate();
            }
        }

        private void activitesRecieveBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReceivingXtraForm form = new ReceivingXtraForm();
            {
                form.MdiParent = this;
                if (form.CheckPermissions() == false)
                {
                    return;
                }
                form.Show();
                form.Activate();
            }
        }

        private void activitiesProductionBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            ProductionXtraForm form = new ProductionXtraForm();
            {
                form.MdiParent = this;
                if (form.CheckPermissions() == false)
                {
                    return;
                }
                form.Show();
                form.Activate();
            }
        }

        private void activitesShipBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShippingXtraForm form = new ShippingXtraForm();
            {
                form.MdiParent = this;
                if (form.CheckPermissions() == false)
                {
                    return;
                }
                form.Show();
                form.Activate();
            }
        }

        private void productionDetailBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {

            ReportsXtraForm reportForm = new ReportsXtraForm();

            reportForm.MdiParent = this;
            reportForm.Text = "Production Detail Report";
            reportForm.SelectedReport("ProductionDetailXtraReport");
            reportForm.Show();
            reportForm.Activate();

        }

        //    Private Sub productionSummaryBarButtonItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles productionSummaryBarButtonItem.ItemClick
        //
        //        Dim reportForm As ReportsXtraForm = New ReportsXtraForm
        //
        //        With reportForm
        //            .MdiParent = Me
        //            .Text = "Production Summary Report"
        //            .Show()
        //            .SelectedReport("ProductionSummaryXtraReport")
        //        End With
        //
        //    End Sub
        //
        //    Private Sub costingDetailBarButtonItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles costingDetailBarButtonItem.ItemClick
        //
        //        Dim reportForm As ReportsXtraForm = New ReportsXtraForm
        //
        //        With reportForm
        //            .MdiParent = Me
        //            .Text = "Costing Details Report"
        //            .Show()
        //            .SelectedReport("CostingDetailXtraReport")
        //        End With
        //
        //    End Sub
        //
        //    Private Sub costingDetailFullBarButtonItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles costingDetailFullBarButtonItem.ItemClick
        //
        //        Dim reportForm As ReportsXtraForm = New ReportsXtraForm
        //
        //        With reportForm
        //            .MdiParent = Me
        //            .Text = "Costing Details Full Report"
        //            .Show()
        //            .SelectedReport("CostingDetailFullXtraReport")
        //        End With
        //
        //    End Sub
        //
        //    Private Sub costingSummaryBarButtonItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles costingSummaryBarButtonItem.ItemClick
        //
        //        Dim reportForm As ReportsXtraForm = New ReportsXtraForm
        //
        //        With reportForm
        //            .MdiParent = Me
        //            .Text = "Costing Summary Report"
        //            .Show()
        //            .SelectedReport("CostingSummaryXtraReport")
        //        End With
        //
        //    End Sub
        //
        //    Private Sub costingFinancialBarButtonItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles costingFinancialBarButtonItem.ItemClick
        //
        //        Dim reportForm As ReportsXtraForm = New ReportsXtraForm
        //
        //        With reportForm
        //            .MdiParent = Me
        //            .Text = "Financial Costing Report"
        //            .Show()
        //            .SelectedReport("FinancialCostingXtraReport")
        //        End With
        //
        //    End Sub

        private void toolsOptionsBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            SettingsXtraForm form = new SettingsXtraForm();

            form.FinancialTabs = FinancialTabs;
            form.ShowDialog();

        }

        private void toolsSecurityBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            SecurityXtraForm form = new SecurityXtraForm();
            {
                form.MdiParent = this;
                if (form.CheckPermissions() == false)
                {
                    return;
                }
                form.Show();
                form.Activate();
            }

        }

        private void windowCascadeBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {

            LayoutMdi(MdiLayout.Cascade);

        }

        private void windowVerticalBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {

            LayoutMdi(MdiLayout.TileVertical);

        }

        private void windowHorizontalBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {

            LayoutMdi(MdiLayout.TileHorizontal);

        }

        private void windowCloseBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {

            foreach (XtraForm childForm in MdiChildren)
            {
                childForm.Close();
            }

        }

        private void windowArrangeBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {

            LayoutMdi(MdiLayout.ArrangeIcons);

        }

        private void MainXtraForm_Load(object sender, EventArgs e)
        {

            m_timer.Interval = Convert.ToInt32(TimeSpan.FromHours(1).TotalMilliseconds);
            m_timer.Start();

            TestConnection();

            try
            {
                m_VersionNumber = ApplicationDeployment.CurrentDeployment.CurrentVersion.Revision;

                Text = string.Format("Superior Pack Group - Test (Ver. {0})", ApplicationDeployment.CurrentDeployment.CurrentVersion);
            }
            catch
            {
            }

            if (new LoginXtraForm().ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
            DisplaySecuredMenuItems();

        }

        private void TimerEventProcessor(object myObject, EventArgs myEventArgs)
        {
            try
            {
                if (ApplicationDeployment.CurrentDeployment.CurrentVersion.Revision < Session.DefaultSession.GetObjectByKey<DXDAL.SPGData.LatestVersion>(1).LatestRevision)
                {
                    MessageBox.Show("A new version is available please update.", "Please restart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
            }
        }

        private void TestConnection()
        {

            if (Properties.Settings.Default.UserConnectionString == null)
            {
                Properties.Settings.Default.UserConnectionString = Properties.Settings.Default.SPGDataDefaultConnectionString;
            }

            if (!(DALUtils.TestConnection()))
            {
                MessageBox.Show("Please select your Database", "Database Connection", MessageBoxButtons.OK);
                new DatabaseSelectionXtraForm().ShowDialog();
            }

        }

        private void DisplaySecuredMenuItems()
        {

            if (Properties.Settings.Default.UserSecurityLevel == "Admin")
            {
                AdvancedTabs = "FULL";
                FinancialTabs = "FULL";
                GeneralReports = "FULL";
                FinancialReports = "FULL";
            }

            if (!(Properties.Settings.Default.UserSecurityLevel == "Admin"))
            {
                try
                {
                    m_UserPermissions = new UserPermissionsBLL();
                    if (m_UserPermissions.GetUserPermissionsByUserName(Properties.Settings.Default.UserName, "Security Settings")[0].PermissionLevel == "NONE")
                    {
                        toolsSecurityBarButtonItem.Visibility = BarItemVisibility.Never;
                    }
                    if (m_UserPermissions.GetUserPermissionsByUserName(Properties.Settings.Default.UserName, "Items Form")[0].PermissionLevel == "NONE")
                    {
                        listsItemBarButtonItem.Visibility = BarItemVisibility.Never;
                        mainToolbarItemBarLargeButtonItem.Visibility = BarItemVisibility.Never;
                    }
                    if (m_UserPermissions.GetUserPermissionsByUserName(Properties.Settings.Default.UserName, "Production Form")[0].PermissionLevel == "NONE")
                    {
                        activitiesProductionBarButtonItem.Visibility = BarItemVisibility.Never;
                        mainToolbarProductionBarLargeButtonItem.Visibility = BarItemVisibility.Never;
                    }
                    if (m_UserPermissions.GetUserPermissionsByUserName(Properties.Settings.Default.UserName, "Customers Form")[0].PermissionLevel == "NONE")
                    {
                        listsCustomerBarButtonItem.Visibility = BarItemVisibility.Never;
                        mainToolbarCustomersBarLargeButtonItem.Visibility = BarItemVisibility.Never;
                    }
                    if (m_UserPermissions.GetUserPermissionsByUserName(Properties.Settings.Default.UserName, "Shipping Form")[0].PermissionLevel == "NONE")
                    {
                        activitesShipBarButtonItem.Visibility = BarItemVisibility.Never;
                        mainToolbarShipBarLargeButtonItem.Visibility = BarItemVisibility.Never;
                    }
                    if (m_UserPermissions.GetUserPermissionsByUserName(Properties.Settings.Default.UserName, "Receiving Form")[0].PermissionLevel == "NONE")
                    {
                        activitesRecieveBarButtonItem.Visibility = BarItemVisibility.Never;
                        mainToolbarReceiveBarLargeButtonItem.Visibility = BarItemVisibility.Never;
                    }
                    AdvancedTabs = m_UserPermissions.GetUserPermissionsByUserName(Properties.Settings.Default.UserName, "Advanced Tabs")[0].PermissionLevel;
                    FinancialTabs = m_UserPermissions.GetUserPermissionsByUserName(Properties.Settings.Default.UserName, "Financial Tabs")[0].PermissionLevel;
                    GeneralReports = m_UserPermissions.GetUserPermissionsByUserName(Properties.Settings.Default.UserName, "General Reports")[0].PermissionLevel;
                    FinancialReports = m_UserPermissions.GetUserPermissionsByUserName(Properties.Settings.Default.UserName, "Financial Reports")[0].PermissionLevel;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        public static string AdvancedTabs { get; private set; } = "NONE";

        public static string FinancialTabs { get; private set; } = "NONE";

        public static string GeneralReports { get; private set; } = "NONE";

        public static string FinancialReports { get; private set; } = "NONE";

        private static void FillCompanySettings()
        {

            if (m_CompanySettings == null)
            {
                SPG.CompanySettingsRow settings = null;
                m_CompanySettings = new CompanySettingsBLL();
                settings = (SPG.CompanySettingsRow)(m_CompanySettings.GetCompanySettings().Rows[0]);
                m_MinPerHour = settings.intMinPerHour;
                m_OperatorsPay = settings.dblOperatorsPay;
                m_SupersPay = settings.dblSupersPay;
                m_PackersPay = settings.dblPackersPay;
            }

        }

        public static int MinPerHOur
        {

            get
            {
                FillCompanySettings();

                if (m_MinPerHour.HasValue == false)
                {
                    m_MinPerHour = 50;
                }

                return m_MinPerHour.Value;

            }

        }

        public static float OperatorsPay
        {

            get
            {
                FillCompanySettings();

                if (m_OperatorsPay.HasValue == false)
                {
                    m_OperatorsPay = 10;
                }

                return m_OperatorsPay.Value;
            }

        }

        public static float PackersPay
        {

            get
            {
                FillCompanySettings();

                if (m_PackersPay.HasValue == false)
                {
                    m_PackersPay = 10;
                }

                return m_PackersPay.Value;
            }

        }

        public static float SupersPay
        {

            get
            {
                FillCompanySettings();

                if (m_SupersPay.HasValue == false)
                {
                    m_SupersPay = 10;
                }

                return m_SupersPay.Value;
            }

        }

        private void databaseBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {

            new DatabaseSelectionXtraForm().ShowDialog();

        }

        private void listsAddressesBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {


            ShippingAddressesXtraForm form = new ShippingAddressesXtraForm();
            form.MdiParent = this;
            if (form.CheckPermissions() == false)
            {
                return;
            }
            form.Show();
            form.Activate();

        }

        private void listsInventoryBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {


            InventoryXtraForm form = new InventoryXtraForm();
            form.MdiParent = this;
            if (form.CheckPermissions() == false)
            {
                return;
            }
            form.Show();
            form.Activate(); ;

        }

        private void inventoryAdjustmentBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {


            InventoryAdjustmentXtraForm form = new InventoryAdjustmentXtraForm();
            form.MdiParent = this;
            if (form.CheckPermissions() == false)
            {
                return;
            }
            form.Show();
            form.Activate();
        }

        private void reportsBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {

            QuickReportsXtraForm form = new QuickReportsXtraForm();
            {
                form.MdiParent = this;

                form.Show();
                form.FillReports(null);
                form.Activate();
            }

        }

        private void listVendorsBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {


            VendorsXtraForm form = new VendorsXtraForm();
            {
                form.MdiParent = this;
                if (form.CheckPermissions() == false)
                {
                    return;
                }
                form.Show();
                form.Activate();
            }

        }

        private void listsEmployeesBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {


            employeesXtraForm form = new employeesXtraForm();
            {
                form.MdiParent = this;
                if (form.CheckPermissions() == false)
                {
                    return;
                }
                form.Show();
                form.Activate();
            }

        }

        private void listsShipmentConditionsBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {


            shipmentConditionXtraForm form = new shipmentConditionXtraForm();
            {
                form.MdiParent = this;
                if (form.CheckPermissions() == false)
                {
                    return;
                }
                form.Show();
                form.Activate();
            }

        }

        private void mainToolBarItemPoolBarLargeButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {


            ItemPoolXtraForm form = new ItemPoolXtraForm();
            {
                form.MdiParent = this;
                if (form.CheckPermissions() == false)
                {
                    return;
                }
                form.Show();
                form.Activate();
            }
        }

        private void MainXtraForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                Session.DefaultSession.PurgeDeletedObjects();
            }
            catch
            {

            }

        }

        private void LocationsBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {


            LocationXtraForm form = new LocationXtraForm();
            form.MdiParent = this;
            if (form.CheckPermissions() == false)
            {
                return;
            }
            form.Show();
            form.Activate();

        }

        private void activitiesLocationTransferBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {


            LocationTransfersXtraForm form = new LocationTransfersXtraForm();
            {
                form.MdiParent = this;
                if (form.CheckPermissions() == false)
                {
                    return;
                }
                form.Show();
                form.Activate();
            }

        }

        private void activitiesProjectsBarButtomItem_ItemClick(object sender, ItemClickEventArgs e)
        {

            ProjectsXtraForm form = new ProjectsXtraForm();
            {
                form.MdiParent = this;
                if (form.CheckPermissions() == false)
                {
                    return;
                }
                form.Show();
                form.Activate();
            }

        }

        private void mainToolbarScheduleBarLargeButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            ProjectSchedulingXtraForm form = new ProjectSchedulingXtraForm();
            {
                form.MdiParent = this;
                if (form.CheckPermissions() == false)
                {
                    return;
                }
                form.Show();
                form.Activate();
            }

        }

        private void lotCodeFormatsBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {

            LotCodeFormatsXtraForm form = new LotCodeFormatsXtraForm();
            {
                form.MdiParent = this;
                if (form.CheckPermissions() == false)
                {
                    return;
                }
                form.Show();
                form.Activate();
            }
        }

        private void reasonCodesBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {

            ReasonCodesXtraForm form = new ReasonCodesXtraForm();
            {
                form.MdiParent = this;
                if (form.CheckPermissions() == false)
                {
                    return;
                }
                form.Show();
                form.Activate();
            }
        }

        private void AllergensBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {

            AllergensXtraForm form = new AllergensXtraForm();
            {
                form.MdiParent = this;
                if (form.CheckPermissions() == false)
                {
                    return;
                }
                form.Show();
                form.Activate();
            }
        }
    }
}