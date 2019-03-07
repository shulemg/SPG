//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using DXDAL;
using DXDAL.SPGData;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace SuperiorPackGroup
{
    public partial class ProjectsXtraForm
    {

        public ProjectsXtraForm()
        {
            InitializeComponent();
        }

        private string m_lastColumnChanged;
        private bool m_changedByUser = true;
        private Project m_CurrentProject;
        private MO m_CurrentMo;
        private Session m_ProjectSession;

        private enum FormMode
        {
            Read,Add, Edit, EditMo
        }

        private void addBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_CurrentMo = null;
            m_CurrentProject = new Project(m_ProjectSession);
            oidTextEdit.EditValue = m_CurrentProject.Oid;
            projectTextEdit.EditValue = null;
            customerLookUpEdit.EditValue = null;
            reqStartDateEdit.EditValue = null;
            reqShipDateEdit.EditValue = null;
            reqDeliveryDateEdit.EditValue = null;
            projectStatusComboBoxEdit.EditValue = null;
            //scheduledWeekDatePeriodEdit.EditValue = Nothing
            notesMemoExEdit.EditValue = null;
            moProjectDetailLookupEdit.EditValue = null;
            moScheduledStartDateEdit.EditValue = null;
            moStatusComboBoxEdit.EditValue = null;

            projectDetailsXpCollection.Criteria = new BinaryOperator(ProjectDetails.Fields.Project.Oid.PropertyName, m_CurrentProject.Oid, BinaryOperatorType.Equal);
            projectDetailsXpCollection.Reload();

            moSearchXpView.Criteria = new BinaryOperator(MO.Fields.ProjectDetail.Project.Oid, 0, BinaryOperatorType.Equal);

            moMachineLineXpCollection.Criteria = new BinaryOperator(MoMachineLine.Fields.Mo.Oid, 0, BinaryOperatorType.Equal);
            moMachineLineXpCollection.Reload();

            ManageFormMode(FormMode.Add);
        }

        private void cancelBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            CancelChanges();

            ManageFormMode(FormMode.Read);

        }

        private void customerLookUpEdit_Validated(object sender, EventArgs e)
        {

            BindItemLookupEdit();
            Utilities.MakeFormReadOnly(dataEntrySplitContainerControl.Panel1, false);
            projectDetailsGridView.OptionsBehavior.Editable = true;

        }

        private void deleteBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (projectDetailsXpCollection.Count > 0)
            {
                MessageBox.Show("You must first delete the details.", "Delete Project", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this project?", "Delete Project", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
            {
                return;
            }

            try
            {
                m_CurrentProject.Delete();
                if (m_CurrentProject.IsDeleted)
                {
                    BindProjectSearch();
                }
                else
                {
                    MessageBox.Show("The project was not deleted.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("The project was not deleted.{0}{1}", Environment.NewLine, ex.Message), "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void deleteRepositoryItemButtonEdit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to delete this project line?", "Delete Project Line", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.No)
            {
                return;
            }

            ProjectDetails detail = m_ProjectSession.GetObjectByKey<ProjectDetails>(projectDetailsGridView.GetFocusedRowCellValue(colOid));
            if (detail != null)
            {
                if (detail.UnitsProduced + detail.BagsProduced + detail.PalletsProduced > 0)
                {
                    MessageBox.Show("You can't delete this line, you already have production against it.", "Delete Project Line", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                detail.Delete();
                if (detail.IsDeleted == false)
                {
                    MessageBox.Show("The project line was not removed.");
                }
            }
            else
            {
                projectDetailsGridView.DeleteRow(projectDetailsGridView.FocusedRowHandle);
            }

        }

        private void detailHistorySimpleButton_Click(object sender, EventArgs e)
        {

            detailHistoryGridControl.DataSource = ProjectsBLL.GetProjectDetailChanges(m_ProjectSession, m_CurrentProject.Oid);
            detailHistoryGridControl.Visible = true;

        }

        private void editBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (m_CurrentProject == null)
            {
                MessageBox.Show("Please select a project to edit.");
                return;
            }

            ManageFormMode(FormMode.Edit);
        }

        private void itemRepositoryItemLookUpEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (Convert.ToInt32(projectDetailsGridView.GetFocusedRowCellValue(colUnitsProduced)) >= 1 || Convert.ToInt32(projectDetailsGridView.GetFocusedRowCellValue(colBagsProduced)) >= 1 || Convert.ToInt32(projectDetailsGridView.GetFocusedRowCellValue(colPalletsProduced)) >= 1)
            {
                MessageBox.Show("You can't change the item once there's already production against it.");
                e.Cancel = true;
            }

        }

        private void projectDetailsGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            if (!m_changedByUser)
            {
                return;
            }

            if ((projectDetailsGridView.GetFocusedRowCellValue(colItemNumber) == null) || Convert.IsDBNull(projectDetailsGridView.GetFocusedRowCellValue(colItemNumber)))
            {
                return;
            }

            if (e.Column == colItemNumber || e.Column == colBagsRequested || e.Column == colPalletsRequested || e.Column == colUnitsRequested)
            {
                if (Convert.ToDouble(projectDetailsGridView.GetFocusedRowCellValue(colBagsRequested)) > 0 || Convert.ToDouble(projectDetailsGridView.GetFocusedRowCellValue(colPalletsRequested)) > 0 || Convert.ToDouble(projectDetailsGridView.GetFocusedRowCellValue(colUnitsRequested)) > 0)
                {
                    m_changedByUser = false;
                    UpdateRequestedQuantities(e.Column.Name);
                }
                //ElseIf e.Column Is colBagsRequested OrElse e.Column Is colPalletsRequested OrElse e.Column Is colUnitsRequested Then
                //    If CDbl(projectDetailsGridView.GetFocusedRowCellValue(colBagsRequested)) > 0 OrElse CDbl(projectDetailsGridView.GetFocusedRowCellValue(colPalletsRequested)) > 0 OrElse
                //            CDbl(projectDetailsGridView.GetFocusedRowCellValue(colUnitsRequested)) > 0 Then
                //        UpdateRequestedQuantities(e.Column.Name)
                //    End If
            }

            m_changedByUser = true;

        }

        private void projectDetailsGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {

            projectDetailsGridView.SetRowCellValue(e.RowHandle, colProjectID, m_CurrentProject.Oid);

        }

        private void projectSearchGridView_Click(object sender, EventArgs e)
        {

            if (projectSearchGridView.FocusedRowHandle == -999997)
            {
                return;
            }

            if (projectSearchGridView.CalcHitInfo(projectSearchGridControl.PointToClient(Control.MousePosition)).HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.RowCell)
            {
                BindProjectControls(Convert.ToInt32(projectSearchGridView.GetFocusedRowCellValue(colProjectID)));
            }

        }

        private void projectStatusComboBoxEdit_FormatEditValue(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
        {

            if (e.Value != null)
            {
                e.Value = typeof(ProjectStatus).GetEnumName(e.Value);
                e.Handled = true;
            }

        }

        private void ProjectsXtraForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (projectSearchGridControl.Enabled == false)
            {
                switch (MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        if (moSearchGridControl.Enabled == false && SaveMo() == false)
                        {
                            e.Cancel = true;
                        }
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
                XPBaseObject.AutoSaveOnEndEdit = true;
                m_ProjectSession.PurgeDeletedObjects();
            }

        }

        private void ProjectsXtraForm_Load(object sender, EventArgs e)
        {

            Cursor = Cursors.WaitCursor;

            m_ProjectSession = new Session(MyDataLayers.SPGDataLayer);
            m_ProjectSession.TrackPropertiesModifications = true;
            m_ProjectSession.OptimisticLockingReadBehavior = OptimisticLockingReadBehavior.MergeCollisionThrowException;

            for (int i = 0; i < (components?.Components.Count ?? 0); i++)
            {
                if ((components.Components[i]) is XPView)
                {
                    ((XPView)components.Components[i]).Session = m_ProjectSession;
                }
                else if ((components.Components[i]) is XPCollection)
                {
                    ((XPCollection)components.Components[i]).Session = m_ProjectSession;
                }
            }

            projectStatusComboBoxEdit.Properties.Items.AddRange(Enum.GetValues(typeof(ProjectStatus)));
            moStatusComboBoxEdit.Properties.Items.AddRange(Enum.GetValues(typeof(MOStatus)));

            XPBaseObject.AutoSaveOnEndEdit = false;


            projectDetailsXpCollection.Criteria = new BinaryOperator(ProjectDetails.Fields.Project.Oid.PropertyName, 0, BinaryOperatorType.Equal);

            moSearchXpView.Criteria = new BinaryOperator(MO.Fields.ProjectDetail.Project.Oid, 0, BinaryOperatorType.Equal);

            moMachineLineXpCollection.Criteria = new BinaryOperator(MoMachineLine.Fields.Mo.Oid, 0, BinaryOperatorType.Equal);
            moMachineLineXpCollection.Reload();

            ShowEnded();

            ManageFormMode(FormMode.Read);

            Cursor = Cursors.Default;

        }

        private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (SaveChanges())
            {
                ManageFormMode(FormMode.Read);
            }

        }

        private void BindItemLookupEdit()
        {

            itemXpView.Criteria = new GroupOperator(GroupOperatorType.And, new BinaryOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, Convert.ToInt32(customerLookUpEdit.EditValue), BinaryOperatorType.Equal), new BinaryOperator(Items.Fields.Inactive.PropertyName, true, BinaryOperatorType.NotEqual), new BinaryOperator(Items.Fields.ItemType.PropertyName, "RM", BinaryOperatorType.NotEqual));
            itemXpView.Reload();

        }

        private void BindProjectControls(int ProjectID)
        {

            m_ProjectSession.DropIdentityMap();

            Project project = m_ProjectSession.GetObjectByKey<Project>(ProjectID, true);
            m_CurrentProject = project;
            oidTextEdit.EditValue = m_CurrentProject.Oid;
            projectTextEdit.EditValue = m_CurrentProject.project;
            customerLookUpEdit.EditValue = m_CurrentProject.Customer?.CustomerID;
            reqStartDateEdit.EditValue = m_CurrentProject.RequestedStartDate;
            reqShipDateEdit.EditValue = m_CurrentProject.RequestedShippingDate;
            reqDeliveryDateEdit.EditValue = m_CurrentProject.RequestedDeliveryDate;
            projectStatusComboBoxEdit.EditValue = m_CurrentProject.ProjectStatus;
            //scheduledWeekDatePeriodEdit.EditValue = m_CurrentProject.ScheduledWeek
            notesMemoExEdit.EditValue = m_CurrentProject.Notes;

            projectDetailsXpCollection.Criteria = new BinaryOperator(ProjectDetails.Fields.Project.Oid.PropertyName, m_CurrentProject.Oid, BinaryOperatorType.Equal);
            projectDetailsXpCollection.Reload();

            moProjectTextEdit.EditValue = null;

            moSearchXpView.Criteria = new BinaryOperator(MO.Fields.ProjectDetail.Project.Oid, m_CurrentProject.Oid, BinaryOperatorType.Equal);
            moSearchXpView.Reload();

            moMachineLineXpCollection.Criteria = new BinaryOperator(MoMachineLine.Fields.Mo.Oid, 0, BinaryOperatorType.Equal);
            moMachineLineXpCollection.Reload();
            moProjectDetailLookupEdit.EditValue = null;
            moScheduledStartDateEdit.EditValue = null;
            moStatusComboBoxEdit.EditValue = null;
            m_CurrentMo = null;

            detailHistoryGridControl.DataSource = null;
            detailHistoryGridControl.Visible = false;

            BindItemLookupEdit();

        }

        private void BindProjectSearch()
        {

            projectSearchXpView.Reload();

        }

        private void CancelChanges()
        {

            if (m_CurrentProject.Oid != -1)
            {
                BindProjectControls(m_CurrentProject.Oid);
            }
        }

        public bool CheckPermissions()
        {

            try
            {
                SPG.UserPermissionsRow permission = (new UserPermissionsBLL()).GetUserPermissionsByUserName(Properties.Settings.Default.UserName, "Projects And Scheduling")[0];

                switch (permission.PermissionLevel)
                {
                    case "FULL":
                    case "Full":
                        delGridColumn.Visible = true;
                        delGridColumn.VisibleIndex = 0;
                        break;
                    case "ADD":
                    case "Add":
                        deleteBarButtonItem.Enabled = false;
                        delGridColumn.Visible = false;
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
                        delGridColumn.Visible = false;
                        break;
                    case "EDIT":
                    case "Edit":
                        addBarButtonItem.Enabled = false;
                        deleteBarButtonItem.Enabled = false;
                        delGridColumn.Visible = false;
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

        private bool SaveChanges()
        {

            int selectedID = 0;

            projectDetailsGridView.CloseEditor();
            projectDetailsGridView.MoveNext();

            if (m_CurrentProject.Oid != -1)
            {
                selectedID = projectSearchGridView.FocusedRowHandle;
            }

            try
            {
                if (ProjectsBLL.ValidateRecord(Convert.ToString(projectTextEdit.EditValue), (int?)customerLookUpEdit.EditValue, (DateTime?)reqStartDateEdit.EditValue, (DateTime?)reqDeliveryDateEdit.EditValue, (DateTime?)reqShipDateEdit.EditValue))
                {
                    m_CurrentProject.project = projectTextEdit.EditValue.ToString();
                    m_CurrentProject.Customer = (customerLookUpEdit.EditValue == null) ? null : m_ProjectSession.GetObjectByKey<Customers>(Convert.ToInt32(customerLookUpEdit.EditValue));
                    m_CurrentProject.RequestedDeliveryDate = (DateTime?)reqDeliveryDateEdit.EditValue;
                    m_CurrentProject.RequestedShippingDate = (DateTime?)reqShipDateEdit.EditValue;
                    m_CurrentProject.RequestedStartDate = (DateTime?)reqStartDateEdit.EditValue;
                    m_CurrentProject.ProjectStatus = (ProjectStatus)projectStatusComboBoxEdit.EditValue;
                    //m_CurrentProject.ScheduledWeek = scheduledWeekDatePeriodEdit.EditValue.ToString
                    m_CurrentProject.Notes = (notesMemoExEdit.EditValue == null ? null : Convert.ToString(notesMemoExEdit.EditValue));

                    foreach (ProjectDetails detail in projectDetailsXpCollection)
                    {
                        if (detail.Project == null || detail.Project.Oid == -1)
                        {
                            detail.Project = m_CurrentProject;
                        }
                    }

                    m_CurrentProject.Save();
                }
                else
                {
                    MessageBox.Show("The record is not valid. You must provide a project name, and valid dates for start and ship or delivery date.");
                    return false;
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            BindProjectSearch();
            BindProjectControls(m_CurrentProject.Oid);
            projectSearchGridView.FocusedRowHandle = selectedID;

            BindMoControls(Convert.ToInt32(moSearchGridView.GetFocusedRowCellValue(colMoId)));

            return true;

        }

        private void UpdateRequestedQuantities(string ChangedColumn)
        {

            double unitsPerCase = Convert.ToDouble(((ViewRecord)itemRepositoryItemLookUpEdit.GetDataSourceRowByKeyValue(projectDetailsGridView.GetFocusedRowCellValue(colItemNumber)))[2]);
            double bagsPerCase = Convert.ToDouble(((ViewRecord)itemRepositoryItemLookUpEdit.GetDataSourceRowByKeyValue(projectDetailsGridView.GetFocusedRowCellValue(colItemNumber)))[3]);
            double casesPerPallet = Convert.ToDouble(((ViewRecord)itemRepositoryItemLookUpEdit.GetDataSourceRowByKeyValue(projectDetailsGridView.GetFocusedRowCellValue(colItemNumber)))[4]);

            //INSTANT C# NOTE: The following VB 'Select Case' included either a non-ordinal switch expression or non-ordinal, range-type, or non-constant 'Case' expressions and was converted to C# 'if-else' logic:
            //			Select Case ChangedColumn
            //ORIGINAL LINE: Case colItemNumber.Name
            if (ChangedColumn == colItemNumber.Name)
            {
                if (Convert.ToInt32(projectDetailsGridView.GetFocusedRowCellValue(colUnitsRequested)) < 1 || projectDetailsGridView.GetFocusedRowCellValue(colUnitsRequested) == null || Convert.IsDBNull(projectDetailsGridView.GetFocusedRowCellValue(colUnitsRequested)))
                {
                    projectDetailsGridView.SetFocusedRowCellValue(colBagsRequested, 0);
                    projectDetailsGridView.SetFocusedRowCellValue(colPalletsRequested, 0);
                }
                else
                {
                    if (unitsPerCase > 0)
                    {
                        projectDetailsGridView.SetFocusedRowCellValue(colBagsRequested, (Convert.ToInt32(projectDetailsGridView.GetFocusedRowCellValue(colUnitsRequested)) / unitsPerCase) * bagsPerCase);
                    }
                    if (unitsPerCase > 0 && casesPerPallet > 0)
                    {
                        projectDetailsGridView.SetFocusedRowCellValue(colPalletsRequested, (Convert.ToInt32(projectDetailsGridView.GetFocusedRowCellValue(colUnitsRequested)) / unitsPerCase) / casesPerPallet);
                    }
                }
            }
            //ORIGINAL LINE: Case colUnitsRequested.Name
            else if (ChangedColumn == colUnitsRequested.Name)
            {
                if (Convert.ToInt32(projectDetailsGridView.GetFocusedRowCellValue(colUnitsRequested)) >= 1)
                {
                    if (unitsPerCase > 0)
                    {
                        projectDetailsGridView.SetFocusedRowCellValue(colBagsRequested, (Convert.ToInt32(projectDetailsGridView.GetFocusedRowCellValue(colUnitsRequested)) / unitsPerCase) * bagsPerCase);
                    }
                    if (unitsPerCase > 0 && casesPerPallet > 0)
                    {
                        projectDetailsGridView.SetFocusedRowCellValue(colPalletsRequested, (Convert.ToInt32(projectDetailsGridView.GetFocusedRowCellValue(colUnitsRequested)) / unitsPerCase) / casesPerPallet);
                    }
                }
            }
            //ORIGINAL LINE: Case colBagsRequested.Name
            else if (ChangedColumn == colBagsRequested.Name)
            {
                if (Convert.ToInt32(projectDetailsGridView.GetFocusedRowCellValue(colBagsRequested)) >= 1)
                {
                    if (bagsPerCase > 0)
                    {
                        projectDetailsGridView.SetFocusedRowCellValue(colUnitsRequested, (Convert.ToInt32(projectDetailsGridView.GetFocusedRowCellValue(colBagsRequested)) / bagsPerCase) * unitsPerCase);
                    }
                    if (bagsPerCase > 0 && casesPerPallet > 0)
                    {
                        projectDetailsGridView.SetFocusedRowCellValue(colPalletsRequested, (Convert.ToInt32(projectDetailsGridView.GetFocusedRowCellValue(colBagsRequested)) / bagsPerCase) / casesPerPallet);
                    }
                }
            }
            //ORIGINAL LINE: Case colPalletsRequested.Name
            else if (ChangedColumn == colPalletsRequested.Name)
            {
                if (Convert.ToInt32(projectDetailsGridView.GetFocusedRowCellValue(colPalletsRequested)) >= 1)
                {
                    projectDetailsGridView.SetFocusedRowCellValue(colUnitsRequested, (Convert.ToInt32(projectDetailsGridView.GetFocusedRowCellValue(colPalletsRequested)) * casesPerPallet) * unitsPerCase);
                    projectDetailsGridView.SetFocusedRowCellValue(colBagsRequested, (Convert.ToInt32(projectDetailsGridView.GetFocusedRowCellValue(colPalletsRequested)) * casesPerPallet) * bagsPerCase);
                }
            }

        }

        private void printProductionReportBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (m_CurrentProject != null)
            {
                QuickReportsXtraForm form = new QuickReportsXtraForm();
                form.MdiParent = MdiParent;
                form.Show();
                form.SelectWeeklyScheduleReport(m_CurrentProject, "");
                form.Activate();
            }
            else
            {
                MessageBox.Show("There's no project selected.");
            }

        }

        private void printBomAvailabilityBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (m_CurrentProject != null)
            {

                QuickReportsXtraForm form = new QuickReportsXtraForm();
                form.MdiParent = MdiParent;
                form.Show();
                form.SelectProjectBomAvailabilityReport(m_CurrentProject);
                form.Activate();
            }
            else
            {
                MessageBox.Show("There's no project selected.");
            }

        }

        private void refreshBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BindProjectControls(m_CurrentProject.Oid);
            projectSearchXpView.Reload();
        }

        private void moMachineLineGridView_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {

        }

        private void moSearchGridView_Click(object sender, EventArgs e)
        {
            if (moSearchGridView.FocusedRowHandle == -999997)
            {
                return;
            }

            //if (moSearchGridView.CalcHitInfo(moSearchGridControl.PointToClient(MousePosition)).HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.RowCell)
            //{
            BindMoControls(Convert.ToInt32(moSearchGridView.GetFocusedRowCellValue(colMoId)));
            //}
        }

        private void BindMoControls(int moId)
        {
            if (moId < 1) return;

            m_CurrentMo = m_ProjectSession.GetObjectByKey<MO>(moId, true);

            moProjectTextEdit.EditValue = m_CurrentMo.ProjectDetail.Project.project;
            moProjectDetailLookupEdit.EditValue = m_CurrentMo.ProjectDetail.Oid;
            moScheduledStartDateEdit.EditValue = m_CurrentMo.ScheduledStartDateTime;
            moStatusComboBoxEdit.EditValue = m_CurrentMo.Status;

            moMachineLineXpCollection.Criteria = new BinaryOperator(MoMachineLine.Fields.Mo.Oid, moId, BinaryOperatorType.Equal);
            moMachineLineXpCollection.Reload();

        }

        private void addMoSimpleButton_Click(object sender, EventArgs e)
        {
            if(addMoSimpleButton.Text == "Save && Add MO")
            {
                if (!SaveChanges())
                {
                    return;
                }
            }

            m_CurrentMo = new MO(m_ProjectSession);

            ManageFormMode(FormMode.EditMo);

            moProjectTextEdit.EditValue = m_CurrentProject.project;
            moProjectTextEdit.ReadOnly = true;


            moProjectDetailLookupEdit.EditValue = null;
            moScheduledStartDateEdit.EditValue = null;
            moStatusComboBoxEdit.EditValue = MOStatus.Scheduled;

            projectDetailsXpCollection.Criteria = new BinaryOperator(ProjectDetails.Fields.Project.Oid.PropertyName, m_CurrentProject.Oid, BinaryOperatorType.Equal);
            projectDetailsXpCollection.Reload();

            moMachineLineXpCollection.Criteria = new BinaryOperator(MoMachineLine.Fields.Mo.Oid, m_CurrentMo.Oid, BinaryOperatorType.Equal);
            moMachineLineXpCollection.Reload();

        }

        private void delMoMlRepositoryItemButtonEdit_Click(object sender, EventArgs e)
        {
            if ((MOStatus)moStatusComboBoxEdit.EditValue == MOStatus.Scheduled)
            {
                MoMachineLine detail = m_ProjectSession.GetObjectByKey<MoMachineLine>(moMachineLineGridView.GetFocusedRowCellValue(moMlIdGridColumn));
                if (detail != null)
                {
                    detail.Delete();
                }
            }
            else if (moMachineLineGridView.GetFocusedRowCellValue(endTimeGridColumn) == null)
                moMachineLineGridView.SetFocusedRowCellValue(endTimeGridColumn, DateTime.Now);
        }

        private void ManageFormMode(FormMode mode)
        {

            projectDetailsGridView.OptionsBehavior.Editable = (mode == FormMode.Edit ||  mode == FormMode.Add);
            projectSearchGridControl.Enabled = mode == FormMode.Read;
            moMachineLineGridView.OptionsBehavior.Editable = mode == FormMode.EditMo;
            moSearchGridControl.Enabled = mode != FormMode.EditMo;

            Utilities.MakeFormReadOnly(dataEntrySplitContainerControl.Panel1, mode != FormMode.Edit && mode != FormMode.Add);
            Utilities.MakeFormReadOnly(moDataEntrySplitContainerControl.Panel1, mode != FormMode.EditMo);

            cancelBarButtonItem.Enabled = (mode == FormMode.Edit ||  mode == FormMode.Add);
            saveBarButtonItem.Enabled = (mode == FormMode.Edit ||  mode == FormMode.Add);
            editMoSimpleButton.Enabled = (mode == FormMode.Edit ||  mode == FormMode.Add);
            delMoSimpleButton.Enabled = (mode == FormMode.Edit ||  mode == FormMode.Add);
            deleteRepositoryItemButtonEdit.Buttons[0].Enabled = (mode == FormMode.Edit ||  mode == FormMode.Add);
            editBarButtonItem.Enabled = mode == FormMode.Read;
            addBarButtonItem.Enabled = mode == FormMode.Read;
            deleteBarButtonItem.Enabled = mode == FormMode.Read;
            saveMoSimpleButton.Enabled = mode == FormMode.EditMo;
            cancalMoSimpleButton.Enabled = mode == FormMode.EditMo;
            addMoSimpleButton.Enabled = (mode == FormMode.Edit || mode == FormMode.Add);
            addMoSimpleButton.Text = mode == FormMode.Add ? "Save && Add MO" : "Add MO";

            dataEntryXtraTabPage.Enabled = mode != FormMode.EditMo;
            auditXtraTabPage.Enabled = mode != FormMode.EditMo;


            moProjectTextEdit.ReadOnly = true;
            moStatusComboBoxEdit.ReadOnly = true;
            showEndedCheckEdit.ReadOnly = false;

            if (mode == FormMode.Read)
                CheckPermissions();

        }

        private void editMoSimpleButton_Click(object sender, EventArgs e)
        {
            if(m_CurrentMo == null)
            {
                MessageBox.Show("Please select a MO to edit.");
                return;
            }

            moMachineLineXpCollection.Criteria = new BinaryOperator(MoMachineLine.Fields.Mo.Oid, m_CurrentMo.Oid, BinaryOperatorType.Equal);
            moMachineLineXpCollection.Reload();

            ManageFormMode(FormMode.EditMo);
        }

        private void delMoSimpleButton_Click(object sender, EventArgs e)
        {
            if (m_CurrentMo == null)
            {
                MessageBox.Show("Please select a MO to delete.");
                return;
            }

            m_CurrentMo.Delete();
            ManageFormMode(FormMode.Edit);
            BindMoSearch();

        }

        private void cancalMoSimpleButton_Click(object sender, EventArgs e)
        {

            if (m_CurrentMo.Oid != -1)
            {
                BindMoControls(m_CurrentMo.Oid);
            }

            ManageFormMode(FormMode.Edit);
        }

        private void saveMoSimpleButton_Click(object sender, EventArgs e)
        {
            if (SaveMo())
                ManageFormMode(FormMode.Edit);
        }

        private bool SaveMo()
        {
            try
            {

                int selectedID = 0;

                moMachineLineGridView.CloseEditor();
                moMachineLineGridView.MoveNext();

                if (m_CurrentMo.Oid != -1)
                {
                    selectedID = moSearchGridView.FocusedRowHandle;
                }


                //m_ProjectSession.Save(moMachineLineXpCollection);
                m_CurrentMo.Status = (MOStatus)(moStatusComboBoxEdit.EditValue ?? MOStatus.Active);
                m_CurrentMo.ProjectDetail = m_ProjectSession.GetObjectByKey<ProjectDetails>(moProjectDetailLookupEdit.EditValue);
                m_CurrentMo.ScheduledStartDateTime = moScheduledStartDateEdit.DateTime;
                foreach (MoMachineLine ml in moMachineLineXpCollection)
                {
                    ml.Mo = m_CurrentMo;
                    ml.Save();
                }
                m_CurrentMo.Save();

                BindMoSearch();
                BindMoControls(m_CurrentMo.Oid);
                moSearchGridView.FocusedRowHandle = selectedID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void BindMoSearch()
        {
            moSearchXpView.Reload();
        }

        private void moMachineLineGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            moMachineLineGridView.SetRowCellValue(e.RowHandle, colMoId, m_CurrentMo.Oid);

            if ((MOStatus)moStatusComboBoxEdit.EditValue == MOStatus.Active)
                moMachineLineGridView.SetFocusedRowCellValue(startTimeGridColumn, DateTime.Now);
        }

        private void repositoryItemLookUpEdit2_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue != e.OldValue)
            {
                foreach(MoMachineLine moMl in moMachineLineXpCollection)
                {
                    if(moMl.EndTime == null && moMl.MachineLine.MachineLineID == (int)e.NewValue)
                    {
                        MessageBox.Show("MachineLine is already on this MO.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        e.Cancel = true;
                    }
                }
            }
        }

        private void showEndedCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            ShowEnded();
        }

        private void ShowEnded()
        {
            endTimeGridColumn.Visible = showEndedCheckEdit.Checked;

            if (!showEndedCheckEdit.Checked)
            {
                moMachineLineGridView.ActiveFilterCriteria = new NullOperator(MoMachineLine.Fields.EndTime.PropertyName);
            }
            else
            {
                moMachineLineGridView.ActiveFilterCriteria = null;
            }
        }
    }
}