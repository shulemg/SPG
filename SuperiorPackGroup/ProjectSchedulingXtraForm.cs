//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using DevExpress.Data.Filtering;
using DXDAL.SPGData;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;
using DevExpress.XtraScheduler.Native;
using DevExpress.XtraScheduler.Services;
using DevExpress.XtraScheduler.Reporting;
using DevExpress.XtraReports.UI;
using DevExpress.Xpo;
using System.ComponentModel;
using DevExpress.Services;

namespace SuperiorPackGroup
{
	public partial class ProjectSchedulingXtraForm
	{

		public ProjectSchedulingXtraForm()
		{
			InitializeComponent();
		}

		internal ContextMenu itemContextMenu;
		[System.Runtime.CompilerServices.AccessedThroughProperty(nameof(openInItemsManager))]
		private MenuItem _openInItemsManager;
		internal MenuItem openInItemsManager
        {
            [DebuggerNonUserCode]
            get => _openInItemsManager;
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized), DebuggerNonUserCode]
            set
            {
                if (_openInItemsManager != null)
                {
                    _openInItemsManager.Click -= openInItemsManager_Click;
                }

                _openInItemsManager = value;

                if (value != null)
                {
                    _openInItemsManager.Click += openInItemsManager_Click;
                }
            }
        }
        private ShiftsTimeScaleFixedIntervalCaptionService shiftTimeScaleCaption;
		private IHeaderCaptionService prevHeaderCaptionServeice;
		private IMouseHandlerService oldMouseHandler;
		private CustomMouseHandlerService newMouseHandler;
		private Session m_SchedulingSession;
		private bool allowAdd = false;
		private bool allowEdit = false;
		public bool CheckPermissions()
		{

			SPG.UserPermissionsRow permission = (new UserPermissionsBLL()).GetUserPermissionsByUserName(Properties.Settings.Default.UserName, "Projects And Scheduling")[0];
			try
			{
				switch (permission.PermissionLevel)
				{
					case "FULL":
					case "Full":
						NewAppointmentItem1.Enabled = true;
						allowAdd = true;
						allowEdit = true;
						break;
					case "ADD":
					case "Add":
						NewAppointmentItem1.Enabled = true;
						allowAdd = true;
						allowEdit = true;
						break;
					case "NONE":
					case "None":
						MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						Close();
						return false;
					case "VIEW":
					case "View":
						NewAppointmentItem1.Enabled = false;
						allowAdd = false;
						allowEdit = false;
						break;
					case "EDIT":
					case "Edit":
						NewAppointmentItem1.Enabled = false;
						allowAdd = false;
						allowEdit = true;
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

		private void ProjectSchedulingXtraForm_Load(object sender, EventArgs e)
		{

			productionSchedulerControl.GroupType = SchedulerGroupType.Date;
			productionSchedulerControl.ActiveViewType = SchedulerViewType.Timeline;
			productionSchedulerControl.Start = DateTime.Today;
			productionSchedulerControl.TimelineView.Scales.Add(new ShiftsTimeScaleFixedInterval());
			productionSchedulerControl.TimelineView.Scales.RemoveAt(6);
			productionSchedulerControl.TimelineView.Scales.RemoveAt(5);

			prevHeaderCaptionServeice = productionSchedulerControl.GetService<IHeaderCaptionService>();
			shiftTimeScaleCaption = new ShiftsTimeScaleFixedIntervalCaptionService(prevHeaderCaptionServeice, productionSchedulerControl);
			productionSchedulerControl.RemoveService(typeof(IHeaderCaptionService));
			productionSchedulerControl.AddService(typeof(IHeaderCaptionService), shiftTimeScaleCaption);

			oldMouseHandler = productionSchedulerControl.GetService<IMouseHandlerService>();
			if (oldMouseHandler != null)
			{
				newMouseHandler = new CustomMouseHandlerService(productionSchedulerControl, oldMouseHandler);
				productionSchedulerControl.RemoveService(typeof(IMouseHandlerService));
				productionSchedulerControl.AddService(typeof(IMouseHandlerService), newMouseHandler);
			}

			itemContextMenu = new ContextMenu();
				openInItemsManager = new MenuItem {Text = "Open In Items Manager"};
				itemContextMenu.MenuItems.Add(openInItemsManager);

				m_SchedulingSession = new Session(MyDataLayers.SPGDataLayer);
				lastSaved = Convert.ToInt32(m_SchedulingSession.Evaluate<ProductionSchedule>(CriteriaOperator.Parse("Max(Oid)"), null));
				projectDetailsXpCollection.Session = m_SchedulingSession;
				m_SchedulingSession.DropIdentityMap();

		}

		private void productionSchedulerControl_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
		{

			SchedulerControl scheduler = (SchedulerControl)sender;
			CustomAppointmentForm form = new CustomAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
			try
			{
				form.AllowEdit = allowEdit;
				form.EnableEditing();
				e.DialogResult = form.ShowDialog();
				e.Handled = true;
			}
			finally
			{
				form.Dispose();
			}

		}

		private void productionSchedulerControl_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
		{

			if (e.Menu.Id == SchedulerMenuItemId.DefaultMenu)
			{
				e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewRecurringAppointment);
				e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewAllDayEvent);
				e.Menu.GetMenuItemById(SchedulerMenuItemId.NewAppointment).Caption = "New Production Schedule";
				if (allowAdd == false)
				{
					e.Menu.GetMenuItemById(SchedulerMenuItemId.NewAppointment).Enabled = false;
				}
			}
			else if (e.Menu.Id == SchedulerMenuItemId.AppointmentMenu)
			{
				e.Menu.RemoveMenuItem(SchedulerMenuItemId.LabelSubMenu);
				e.Menu.RemoveMenuItem(SchedulerMenuItemId.StatusSubMenu);
			}

		}

		private void productionSchedulerControl_DateNavigatorQueryActiveViewType(object sender, DateNavigatorQueryActiveViewTypeEventArgs e)
		{

			if (e.OldViewType == SchedulerViewType.Timeline)
			{
				e.NewViewType = SchedulerViewType.Timeline;
			}

		}

		private void scheduleProjectsSplitContainerControl_Resize(object sender, EventArgs e)
		{

			scheduleProjectsSplitContainerControl.SplitterPosition = Math.Min(Convert.ToInt32(scheduleProjectsSplitContainerControl.Height - scheduleProjectsSplitContainerControl.Height / 4.0), 550);
			projectsItemReferenceSplitContainerControl.SplitterPosition = Convert.ToInt32(projectsItemReferenceSplitContainerControl.Width / 2.0);

		}

		private void projectDetailsGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
		{

			try
			{
				itemReferenceXpCollection.Criteria = new BinaryOperator(Items.Fields.ItemID.PropertyName, projectDetailsGridView.GetFocusedRowCellValue(colProjectItemID), BinaryOperatorType.Equal);

			}
			catch
			{
				itemReferenceXpCollection.Criteria = new BinaryOperator(Items.Fields.ItemID.PropertyName, 0, BinaryOperatorType.Equal);
			}

		}

		private void itemGridView_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
		{

			GridHitInfo hitInfo = itemGridView.CalcHitInfo(e.Point);
			if (hitInfo.InRow)
			{
				itemGridView.FocusedRowHandle = hitInfo.RowHandle;
				itemContextMenu.Show(itemGridView.GridControl, e.Point);
			}

		}

		private void openInItemsManager_Click(object sender, EventArgs e)
		{

            ItemsXtraForm form = new ItemsXtraForm();
                form.MdiParent = this;
                if (form.CheckPermissions() == false)
                {
                    return;
                }
                form.Show();
                form.CurrentItemID = (int?)projectDetailsGridView.GetFocusedRowCellValue(colProjectItemID);
                form.Activate();
		}

		private void productionSchedulerControl_CustomDrawResourceHeader(object sender, CustomDrawObjectEventArgs e)
		{

			ResourceHeader machineLineHeader = (ResourceHeader)e.ObjectInfo;
			StringFormat machineHeaderStringFormat = machineLineHeader.Appearance.HeaderCaption.TextOptions.GetStringFormat();
			string machineLineCaption = string.Format("{0}{1}Total:{1}{2}", machineLineHeader.Resource.Caption, Environment.NewLine, CalculateVisibleResourceTotals(machineLineHeader.Interval, machineLineHeader.Resource).ToString());

			if (productionSchedulerControl.ActiveViewType == SchedulerViewType.Timeline)
			{
				e.Cache.DrawString(machineLineCaption, machineLineHeader.Appearance.HeaderCaption.Font, Brushes.Black, e.Bounds, machineHeaderStringFormat);
			}
			else
			{
				e.Cache.DrawString(machineLineCaption, machineLineHeader.Appearance.HeaderCaption.Font, Brushes.Black, e.Bounds, machineHeaderStringFormat);
			}

			e.Handled = true;

		}

		private double CalculateVisibleResourceTotals(TimeInterval interval, Resource resource)
		{

			AppointmentBaseCollection scheduledProduction = SchedulerStorage1.GetAppointments(interval);
			double total = 0.0F;

			ResourceBaseCollection machines = new ResourceBaseCollection();

			machines.Add(resource);

			ResourcesAppointmentsFilter machinesFilter = new ResourcesAppointmentsFilter(machines);

			machinesFilter.Process(scheduledProduction);

//INSTANT C# NOTE: There is no C# equivalent to VB's implicit 'once only' variable initialization within loops, so the following variable declaration has been placed prior to the loop:
			double scheduledQuantity = 0;
			foreach (Appointment productionSchedule in (AppointmentBaseCollection)machinesFilter.DestinationCollection)
			{
				if (productionSchedule.CustomFields["Quantity"] != null)
				{
	//				Dim scheduledQuantity As Double
					double.TryParse(productionSchedule.CustomFields["Quantity"].ToString(), out scheduledQuantity);
					total += scheduledQuantity;
				}
			}

			return total;

		}

		private void PrintPreviewItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

			ProductionScheduleXtraSchedulerReport xr = new ProductionScheduleXtraSchedulerReport();
			SchedulerControlPrintAdapter scPrintAdapter = new SchedulerControlPrintAdapter(productionSchedulerControl);
			xr.SchedulerAdapter = scPrintAdapter;

			xr.CreateDocument(true);
			xr.ProductionScheduleReportTimelineView.Scales.Add(new ShiftsTimeScaleFixedInterval());

			using (ReportPrintTool printTool = new ReportPrintTool(xr))
			{
				printTool.ShowPreviewDialog();
			}

		}

		private void openReportBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

            QuickReportsXtraForm form = new QuickReportsXtraForm();
                form.MdiParent = MdiParent;
                form.Show();
                form.SelectReport(true, "ShiftScheduleXtraReport", false);
                form.Activate();

		}

		private void ProjectSchedulingXtraForm_Closing(object sender, CancelEventArgs e)
		{

			foreach (ProductionSchedule appointment in productionScheduleXpCollection)
			{
				if (appointment.Oid == -1)
				{
					appointment.Save();
				}
			}
		}

		private void productionSchedulerControl_GotFocus(object sender, EventArgs e)
		{
			foreach (ProductionSchedule appointment in productionScheduleXpCollection)
			{
				if (appointment.Oid == -1)
				{
					appointment.Save();
				}
			}
		}

		private int lastSaved;

	}
}