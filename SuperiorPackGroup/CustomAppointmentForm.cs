#region Note
//
//{**************************************************************************************************************}
//{  This file is automatically created when you open the Scheduler Control smart tag                            }
//{  *and click Create Customizable Appointment Dialog.                                                          }
//{  It contains a a descendant of the default appointment editing form created by visual inheritance.           }
//{  In Visual Studio Designer add an editor that is required to edit your appointment custom field.             }
//{  Modify the LoadFormData method to get data from a custom field and fill your editor with data.              }
//{  Modify the SaveFormData method to retrieve data from the editor and set the appointment custom field value. }
//{  The code that displays this form is automatically inserted                                                  }
//{  *in the EditAppointmentFormShowing event handler of the SchedulerControl.                                   }
//{                                                                                                              }
//{**************************************************************************************************************}
//
#endregion // Note

//INSTANT C# NOTE: Formerly VB project-level imports:
using System.Collections;
using System.Diagnostics;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraScheduler;
using DXDAL.SPGData;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.XtraEditors;

namespace SuperiorPackGroup
{
	public partial class CustomAppointmentForm : DevExpress.XtraScheduler.UI.AppointmentForm
	{
		private double? _people;
		private double? _machineOperator;
		private Items _productionItem;
		private bool? _mustRun;
		private int? _priorityLevel;
		private Project _project;
		private ProjectDetails _projectDetail;
		private double? _quantity;
		private bool? _scheduleByQuantity;

		private Session m_ScheduleSession;

		public CustomAppointmentForm()
		{
			InitializeComponent();
		}
		public CustomAppointmentForm(SchedulerControl control, Appointment apt) : base(control, apt)
		{
			InitializeComponent();
		}
		public CustomAppointmentForm(SchedulerControl control, Appointment apt, bool openRecurrenceForm) : base(control, apt, openRecurrenceForm)
		{
			InitializeComponent();
		}
		/// <summary>
		/// Add your code to obtain a custom field value and fill the editor with data.
		/// </summary>
		public override void LoadFormData(Appointment appointment)
		{

			_people = Utilities.ChangeType<double?>(appointment.CustomFields[ProductionSchedule.Fields.People.PropertyName]);
			_machineOperator = Utilities.ChangeType<double?>(appointment.CustomFields[ProductionSchedule.Fields.MachineOperator.PropertyName]);
			_productionItem = Utilities.ChangeType<Items>(appointment.CustomFields[ProductionSchedule.Fields.ProductionItem.PropertyName]);
			_mustRun = Utilities.ChangeType<bool?>(appointment.CustomFields[ProductionSchedule.Fields.MustRun.PropertyName]);
			_priorityLevel = Utilities.ChangeType<int?>(appointment.CustomFields[ProductionSchedule.Fields.PriorityLevel.PropertyName]);
			_project = Utilities.ChangeType<Project>(appointment.CustomFields[ProductionSchedule.Fields.Project.PropertyName]);
			_projectDetail = Utilities.ChangeType<ProjectDetails>(appointment.CustomFields[ProductionSchedule.Fields.ProjectDetail.PropertyName]);
			_quantity = Utilities.ChangeType<double?>(appointment.CustomFields[ProductionSchedule.Fields.Quantity.PropertyName]);
			_scheduleByQuantity = Utilities.ChangeType<bool?>(appointment.CustomFields[ProductionSchedule.Fields.ScheduleByQuantity.PropertyName]);

			peopleTextEdit.EditValue = _people;
			operatorTextEdit.EditValue = _machineOperator;
			schedByQuantityCheckEdit.EditValue = _scheduleByQuantity;
			if (_productionItem == null)
			{
				itemLookUpEdit.EditValue = null;
			}
			else
			{
				itemLookUpEdit.EditValue = _productionItem.ItemID;
			}
			mustRunCheckEdit.EditValue = _mustRun;
			if (_project == null)
			{
				projectLookUpEdit.EditValue = null;
			}
			else
			{
				projectLookUpEdit.EditValue = _project.Oid;
			}
			if (_projectDetail == null)
			{
				projectDetailLookUpEdit.EditValue = null;
			}
			else
			{
				projectDetailLookUpEdit.EditValue = _projectDetail.Oid;
			}
			priorityComboBoxEdit.EditValue = _priorityLevel;
			quantityTextEdit.EditValue = _quantity;

			if (string.IsNullOrEmpty(appointment.Subject))
			{
				if (_project != null && _productionItem != null)
				{
					Text = string.Format("{0} - {1}", _project.project, _productionItem.ItemCode);
				}
				else if (_productionItem != null)
				{
					Text = _productionItem.ItemCode;
				}
				else if (_project != null)
				{
					Text = _project.project;
				}
				else
				{
					Text = "New Production Schedule";
				}
			}

			if (schedByQuantityCheckEdit.Checked == true)
			{
				quantityTextEdit.ReadOnly = false;
			}
			else
			{
				quantityTextEdit.ReadOnly = true;
			}

			base.LoadFormData(appointment);
		}
		/// <summary>
		/// Add your code to retrieve a value from the editor and set the custom appointment field.
		/// </summary>
		public override bool SaveFormData(Appointment appointment)
		{

			appointment.CustomFields[ProductionSchedule.Fields.People.PropertyName] = peopleTextEdit.EditValue;
			appointment.CustomFields[ProductionSchedule.Fields.MachineOperator.PropertyName] = operatorTextEdit.EditValue;
			appointment.CustomFields[ProductionSchedule.Fields.ProductionItem.PropertyName] = XpoDefault.Session.GetObjectByKey<Items>(itemLookUpEdit.EditValue, true);
			appointment.CustomFields[ProductionSchedule.Fields.MustRun.PropertyName] = mustRunCheckEdit.EditValue;
			appointment.CustomFields[ProductionSchedule.Fields.Project.PropertyName] = XpoDefault.Session.GetObjectByKey<Project>(projectLookUpEdit.EditValue, true);
			appointment.CustomFields[ProductionSchedule.Fields.ProjectDetail.PropertyName] = XpoDefault.Session.GetObjectByKey<ProjectDetails>(projectDetailLookUpEdit.EditValue, true);
			appointment.CustomFields[ProductionSchedule.Fields.PriorityLevel.PropertyName] = priorityComboBoxEdit.EditValue;
			appointment.CustomFields[ProductionSchedule.Fields.Quantity.PropertyName] = quantityTextEdit.EditValue;
			appointment.CustomFields[ProductionSchedule.Fields.ScheduleByQuantity.PropertyName] = schedByQuantityCheckEdit.EditValue;

			_project = (Project)appointment.CustomFields[ProductionSchedule.Fields.Project.PropertyName];
			_productionItem = (Items)appointment.CustomFields[ProductionSchedule.Fields.ProductionItem.PropertyName];

			//If String.IsNullOrEmpty(appointment.Subject) Then
			if (appointment.CustomFields[ProductionSchedule.Fields.Project.PropertyName] != null && _productionItem != null)
			{
				appointment.Subject = string.Format("{0} - {1}", _project.project, _productionItem.ItemCode);
			}
			else if (_productionItem != null)
			{
				appointment.Subject = _productionItem.ItemCode;
			}
			else if (appointment.CustomFields[ProductionSchedule.Fields.Project.PropertyName] != null)
			{
				appointment.Subject = _project.project;
			}

			return base.SaveFormData(appointment);
		}
		//' <summary>
		/// Add your code to notify that any custom field is changed. Return true if a custom field is changed, otherwise false.
		/// </summary>
		public override bool IsAppointmentChanged(Appointment appointment)
		{

			if (Utilities.ChangeType<double?>(appointment.CustomFields[ProductionSchedule.Fields.People.PropertyName]).HasValue && _people.HasValue && _people != Utilities.ChangeType<double?>(appointment.CustomFields[ProductionSchedule.Fields.People.PropertyName]) || Utilities.ChangeType<double?>(appointment.CustomFields[ProductionSchedule.Fields.MachineOperator.PropertyName]).HasValue && _machineOperator.HasValue && _machineOperator != Utilities.ChangeType<double?>(appointment.CustomFields[ProductionSchedule.Fields.MachineOperator.PropertyName]) || _productionItem == Utilities.ChangeType<Items>(appointment.CustomFields[ProductionSchedule.Fields.ProductionItem.PropertyName]) || Utilities.ChangeType<bool?>(appointment.CustomFields[ProductionSchedule.Fields.MustRun.PropertyName]).HasValue && _mustRun.HasValue && _mustRun != Utilities.ChangeType<bool?>(appointment.CustomFields[ProductionSchedule.Fields.MustRun.PropertyName]) || Utilities.ChangeType<int?>(appointment.CustomFields[ProductionSchedule.Fields.PriorityLevel.PropertyName]).HasValue && _priorityLevel.HasValue && _priorityLevel != Utilities.ChangeType<int?>(appointment.CustomFields[ProductionSchedule.Fields.PriorityLevel.PropertyName]) || _project == Utilities.ChangeType<Project>(appointment.CustomFields[ProductionSchedule.Fields.Project.PropertyName]) || _projectDetail == Utilities.ChangeType<ProjectDetails>(appointment.CustomFields[ProductionSchedule.Fields.ProjectDetail.PropertyName]) || Utilities.ChangeType<double?>(appointment.CustomFields[ProductionSchedule.Fields.Quantity.PropertyName]).HasValue && _quantity.HasValue && _quantity != Utilities.ChangeType<double?>(appointment.CustomFields[ProductionSchedule.Fields.Quantity.PropertyName]) || Utilities.ChangeType<bool?>(appointment.CustomFields[ProductionSchedule.Fields.ScheduleByQuantity.PropertyName]).HasValue && _scheduleByQuantity.HasValue && _scheduleByQuantity != Utilities.ChangeType<bool?>(appointment.CustomFields[ProductionSchedule.Fields.ScheduleByQuantity.PropertyName]))
			{

				return true;

			}

			return false;
		}

		private void CustomAppointmentForm_Load(object sender, EventArgs e)
		{

			m_ScheduleSession = new Session(MyDataLayers.SPGDataLayer);
			//m_ScheduleSession = XpoDefault.Session

			for (int i = 0; i < components.Components.Count; i++)
			{
				if ((components.Components[i]) is XPView)
				{
					((XPView)components.Components[i]).Session = m_ScheduleSession;
				}
				else if ((components.Components[i]) is XPCollection)
				{
					((XPCollection)components.Components[i]).Session = m_ScheduleSession;
				}
			}

			edtStartDate.EditValueChanged += RecalculateSchedule;
			edtStartTime.EditValueChanged += RecalculateSchedule;
			edtEndDate.EditValueChanged += RecalculateSchedule;
			edtEndTime.EditValueChanged += RecalculateSchedule;

		}

		private void projectLookUpEdit_EditValueChanged(object sender, EventArgs e)
		{

			if (projectLookUpEdit.EditValue != null)
			{
				projectDetailXpView.Criteria = new BinaryOperator(ProjectDetails.Fields.Project.Oid.PropertyName, Convert.ToInt32(projectLookUpEdit.EditValue), BinaryOperatorType.Equal);
				UpdateItemDropDown();
			}

		}

		private void projectDetailLookUpEdit_EditValueChanged(object sender, EventArgs e)
		{

			UpdateItemDropDown();

		}

		private void RecalculateSchedule(object sender, EventArgs e)
		{

			if (schedByQuantityCheckEdit.Checked)
			{
				RecalculateEndTime();
			}
			else
			{
				RecalculateQuantity();
			}

		}

		private void RecalculateEndTime()
		{

			if (itemLookUpEdit.EditValue == null || quantityTextEdit.EditValue == null)
			{
				return;
			}

			double requiredMinutes = Convert.ToDouble(Convert.ToInt32(quantityTextEdit.EditValue) / m_ScheduleSession.GetObjectByKey<Items>(itemLookUpEdit.EditValue).ItemProdStandard / 0.7465);

			edtEndDate.EditValue = DateTime.Parse(string.Format("{0} {1}", edtStartDate.DateTime.ToString("MM/dd/yyyy"), edtStartTime.Time.ToString("HH:mm"))).AddMinutes(requiredMinutes);
			edtEndTime.EditValue = edtStartTime.Time.AddMinutes(requiredMinutes);

		}

		private void RecalculateQuantity()
		{

			if (itemLookUpEdit.EditValue == null)
			{
				return;
			}

			double workMinutes = DateHelper.DateDiff(DateHelper.DateInterval.Minute, DateTime.Parse(string.Format("{0} {1}", edtStartDate.DateTime.ToString("MM/dd/yyyy"), edtStartTime.Time.ToString("HH:mm"))), DateTime.Parse(string.Format("{0} {1}", edtEndDate.DateTime.ToString("MM/dd/yyyy"), edtEndTime.Time.ToString("HH:mm")))) * 0.7465;

			int EstimatedAmount = Convert.ToInt32(workMinutes * m_ScheduleSession.GetObjectByKey<Items>(itemLookUpEdit.EditValue).ItemProdStandard);

			quantityTextEdit.EditValue = EstimatedAmount;

		}

		private void UpdateItemDropDown()
		{

			if (projectLookUpEdit.EditValue != null && projectDetailLookUpEdit.EditValue != null)
			{
				projectItemsXpView.Criteria = new GroupOperator(GroupOperatorType.And, new BinaryOperator(ProjectDetails.Fields.Project.Oid.PropertyName, Convert.ToInt32(projectLookUpEdit.EditValue), BinaryOperatorType.Equal), new BinaryOperator(ProjectDetails.Fields.Oid.PropertyName, Convert.ToInt32(projectDetailLookUpEdit.EditValue), BinaryOperatorType.Equal), new InOperator(ProjectDetails.Fields.ProjectItem.ItemType.PropertyName, "IG", "FG"));
				itemLookUpEdit.Properties.DataSource = projectItemsXpView;
				itemLookUpEdit.EditValue = projectDetailLookUpEdit.GetColumnValue("ProjectItemID");
			}
			else if (projectLookUpEdit.EditValue != null)
			{
				projectItemsXpView.Criteria = new GroupOperator(GroupOperatorType.And, new BinaryOperator(ProjectDetails.Fields.Project.Oid.PropertyName, Convert.ToInt32(projectLookUpEdit.EditValue), BinaryOperatorType.Equal), new InOperator(ProjectDetails.Fields.ProjectItem.ItemType.PropertyName, "IG", "FG"));
				itemLookUpEdit.Properties.DataSource = projectItemsXpView;
			}
			else
			{
				itemLookUpEdit.Properties.DataSource = itemsXpView;
			}

		}

		private void schedByQuantityCheckEdit_CheckedChanged(object sender, EventArgs e)
		{

			quantityTextEdit.ReadOnly = schedByQuantityCheckEdit.Checked == false;

		}

		public void EnableEditing()
		{

			if (AllowEdit)
			{
				peopleTextEdit.Enabled = true;
				operatorTextEdit.Enabled = true;
				itemLookUpEdit.Enabled = true;
				mustRunCheckEdit.Enabled = true;
				projectLookUpEdit.Enabled = true;
				projectDetailLookUpEdit.Enabled = true;
				priorityComboBoxEdit.Enabled = true;
				quantityTextEdit.Enabled = true;
				schedByQuantityCheckEdit.Enabled = true;
			}
			else
			{
				peopleTextEdit.Enabled = false;
				operatorTextEdit.Enabled = false;
				itemLookUpEdit.Enabled = false;
				mustRunCheckEdit.Enabled = false;
				projectLookUpEdit.Enabled = false;
				projectDetailLookUpEdit.Enabled = false;
				priorityComboBoxEdit.Enabled = false;
				quantityTextEdit.Enabled = false;
				schedByQuantityCheckEdit.Enabled = false;
			}
		}

		public bool AllowEdit {get; set;}


	}

}