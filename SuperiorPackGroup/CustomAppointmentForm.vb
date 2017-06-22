#Region "Note"
'
'{**************************************************************************************************************}
'{  This file is automatically created when you open the Scheduler Control smart tag                            }
'{  *and click Create Customizable Appointment Dialog.                                                          }
'{  It contains a a descendant of the default appointment editing form created by visual inheritance.           }
'{  In Visual Studio Designer add an editor that is required to edit your appointment custom field.             }
'{  Modify the LoadFormData method to get data from a custom field and fill your editor with data.              }
'{  Modify the SaveFormData method to retrieve data from the editor and set the appointment custom field value. }
'{  The code that displays this form is automatically inserted                                                  }
'{  *in the EditAppointmentFormShowing event handler of the SchedulerControl.                                   }
'{                                                                                                              }
'{**************************************************************************************************************}
'
#End Region ' Note

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler
Imports DXDAL.SPGData
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraEditors

Partial Public Class CustomAppointmentForm
    Inherits DevExpress.XtraScheduler.UI.AppointmentForm

    Private _people As Double?
    Private _machineOperator As Double?
    Private _productionItem As Items
    Private _mustRun As Boolean?
    Private _priorityLevel As Integer?
    Private _project As Project
    Private _projectDetail As ProjectDetails
    Private _quantity As Double?
    Private _scheduleByQuantity As Boolean?

    Private m_ScheduleSession As Session

    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment)
        MyBase.New(control, apt)
        InitializeComponent()
    End Sub
    Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment, ByVal openRecurrenceForm As Boolean)
        MyBase.New(control, apt, openRecurrenceForm)
        InitializeComponent()
    End Sub
    ''' <summary>
    ''' Add your code to obtain a custom field value and fill the editor with data.
    ''' </summary>
    Public Overrides Sub LoadFormData(ByVal appointment As Appointment)

        _people = Utilities.ChangeType(Of Double?)(appointment.CustomFields(ProductionSchedule.Fields.People.PropertyName))
        _machineOperator = Utilities.ChangeType(Of Double?)(appointment.CustomFields(ProductionSchedule.Fields.MachineOperator.PropertyName))
        _productionItem = Utilities.ChangeType(Of Items)(appointment.CustomFields(ProductionSchedule.Fields.ProductionItem.PropertyName))
        _mustRun = Utilities.ChangeType(Of Boolean?)(appointment.CustomFields(ProductionSchedule.Fields.MustRun.PropertyName))
        _priorityLevel = Utilities.ChangeType(Of Integer?)(appointment.CustomFields(ProductionSchedule.Fields.PriorityLevel.PropertyName))
        _project = Utilities.ChangeType(Of Project)(appointment.CustomFields(ProductionSchedule.Fields.Project.PropertyName))
        _projectDetail = Utilities.ChangeType(Of ProjectDetails)(appointment.CustomFields(ProductionSchedule.Fields.ProjectDetail.PropertyName))
        _quantity = Utilities.ChangeType(Of Double?)(appointment.CustomFields(ProductionSchedule.Fields.Quantity.PropertyName))
        _scheduleByQuantity = Utilities.ChangeType(Of Boolean?)(appointment.CustomFields(ProductionSchedule.Fields.ScheduleByQuantity.PropertyName))

        peopleTextEdit.EditValue = _people
        operatorTextEdit.EditValue = _machineOperator
        schedByQuantityCheckEdit.EditValue = _scheduleByQuantity
        If _productionItem Is Nothing Then
            itemLookUpEdit.EditValue = Nothing
        Else
            itemLookUpEdit.EditValue = _productionItem.ItemID
        End If
        mustRunCheckEdit.EditValue = _mustRun
        If _project Is Nothing Then
            projectLookUpEdit.EditValue = Nothing
        Else
            projectLookUpEdit.EditValue = _project.Oid
        End If
        If _projectDetail Is Nothing Then
            projectDetailLookUpEdit.EditValue = Nothing
        Else
            projectDetailLookUpEdit.EditValue = _projectDetail.Oid
        End If
        priorityComboBoxEdit.EditValue = _priorityLevel
        quantityTextEdit.EditValue = _quantity

        If String.IsNullOrEmpty(appointment.Subject) Then
            If _project IsNot Nothing AndAlso _productionItem IsNot Nothing Then
                Text = String.Format("{0} - {1}", _project.Project, _productionItem.ItemCode)
            ElseIf _productionItem IsNot Nothing Then
                Text = _productionItem.ItemCode
            ElseIf _project IsNot Nothing Then
                Text = _project.Project
            Else
                Text = "New Production Schedule"
            End If
        End If

        If schedByQuantityCheckEdit.Checked = True Then
            quantityTextEdit.ReadOnly = False
        Else
            quantityTextEdit.ReadOnly = True
        End If

        MyBase.LoadFormData(appointment)
    End Sub
    ''' <summary>
    ''' Add your code to retrieve a value from the editor and set the custom appointment field.
    ''' </summary>
    Public Overrides Function SaveFormData(ByVal appointment As Appointment) As Boolean

        appointment.CustomFields(ProductionSchedule.Fields.People.PropertyName) = peopleTextEdit.EditValue
        appointment.CustomFields(ProductionSchedule.Fields.MachineOperator.PropertyName) = operatorTextEdit.EditValue
        appointment.CustomFields(ProductionSchedule.Fields.ProductionItem.PropertyName) = XpoDefault.Session.GetObjectByKey(Of Items)(itemLookUpEdit.EditValue, True)
        appointment.CustomFields(ProductionSchedule.Fields.MustRun.PropertyName) = mustRunCheckEdit.EditValue
        appointment.CustomFields(ProductionSchedule.Fields.Project.PropertyName) = XpoDefault.Session.GetObjectByKey(Of Project)(projectLookUpEdit.EditValue, True)
        appointment.CustomFields(ProductionSchedule.Fields.ProjectDetail.PropertyName) = XpoDefault.Session.GetObjectByKey(Of ProjectDetails)(projectDetailLookUpEdit.EditValue, True)
        appointment.CustomFields(ProductionSchedule.Fields.PriorityLevel.PropertyName) = priorityComboBoxEdit.EditValue
        appointment.CustomFields(ProductionSchedule.Fields.Quantity.PropertyName) = quantityTextEdit.EditValue
        appointment.CustomFields(ProductionSchedule.Fields.ScheduleByQuantity.PropertyName) = schedByQuantityCheckEdit.EditValue

        _project = CType(appointment.CustomFields(ProductionSchedule.Fields.Project.PropertyName), Project)
        _productionItem = CType(appointment.CustomFields(ProductionSchedule.Fields.ProductionItem.PropertyName), Items)

        'If String.IsNullOrEmpty(appointment.Subject) Then
        If appointment.CustomFields(ProductionSchedule.Fields.Project.PropertyName) IsNot Nothing AndAlso _productionItem IsNot Nothing Then
            appointment.Subject = String.Format("{0} - {1}", _project.Project, _productionItem.ItemCode)
        ElseIf _productionItem IsNot Nothing Then
            appointment.Subject = _productionItem.ItemCode
        ElseIf appointment.CustomFields(ProductionSchedule.Fields.Project.PropertyName) IsNot Nothing Then
            appointment.Subject = _project.Project
        End If

        Return MyBase.SaveFormData(appointment)
    End Function
    '' <summary>
    ''' Add your code to notify that any custom field is changed. Return true if a custom field is changed, otherwise false.
    ''' </summary>
    Public Overrides Function IsAppointmentChanged(ByVal appointment As Appointment) As Boolean

        If _people <> Utilities.ChangeType(Of Double?)(appointment.CustomFields(ProductionSchedule.Fields.People.PropertyName)) OrElse
            _machineOperator <> Utilities.ChangeType(Of Double?)(appointment.CustomFields(ProductionSchedule.Fields.MachineOperator.PropertyName)) OrElse
            _productionItem Is Utilities.ChangeType(Of Items)(appointment.CustomFields(ProductionSchedule.Fields.ProductionItem.PropertyName)) OrElse
            _mustRun <> Utilities.ChangeType(Of Boolean?)(appointment.CustomFields(ProductionSchedule.Fields.MustRun.PropertyName)) OrElse
            _priorityLevel <> Utilities.ChangeType(Of Integer?)(appointment.CustomFields(ProductionSchedule.Fields.PriorityLevel.PropertyName)) OrElse
            _project Is Utilities.ChangeType(Of Project)(appointment.CustomFields(ProductionSchedule.Fields.Project.PropertyName)) OrElse
            _projectDetail Is Utilities.ChangeType(Of ProjectDetails)(appointment.CustomFields(ProductionSchedule.Fields.ProjectDetail.PropertyName)) OrElse
            _quantity <> Utilities.ChangeType(Of Double?)(appointment.CustomFields(ProductionSchedule.Fields.Quantity.PropertyName)) OrElse
            _scheduleByQuantity <> Utilities.ChangeType(Of Boolean?)(appointment.CustomFields(ProductionSchedule.Fields.ScheduleByQuantity.PropertyName)) Then

            Return True

        End If

        Return False
    End Function

    Private Sub CustomAppointmentForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        m_ScheduleSession = New Session(SPGDataLayer)
        'm_ScheduleSession = XpoDefault.Session

        For i As Integer = 0 To components.Components.Count - 1
            If TypeOf (components.Components(i)) Is XPView Then
                CType(components.Components(i), XPView).Session = m_ScheduleSession
            ElseIf TypeOf (components.Components(i)) Is XPCollection Then
                CType(components.Components(i), XPCollection).Session = m_ScheduleSession
            End If
        Next i

        AddHandler edtStartDate.EditValueChanged, AddressOf RecalculateSchedule
        AddHandler edtStartTime.EditValueChanged, AddressOf RecalculateSchedule
        AddHandler edtEndDate.EditValueChanged, AddressOf RecalculateSchedule
        AddHandler edtEndTime.EditValueChanged, AddressOf RecalculateSchedule

    End Sub

    Private Sub projectLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles projectLookUpEdit.EditValueChanged

        If projectLookUpEdit.EditValue IsNot Nothing Then
            projectDetailXpView.Criteria = New BinaryOperator(ProjectDetails.Fields.Project.Oid.PropertyName, CInt(projectLookUpEdit.EditValue), BinaryOperatorType.Equal)
            UpdateItemDropDown()
        End If

    End Sub

    Private Sub projectDetailLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles projectDetailLookUpEdit.EditValueChanged

        UpdateItemDropDown()

    End Sub

    Private Sub RecalculateSchedule(sender As Object, e As EventArgs) Handles itemLookUpEdit.EditValueChanged, quantityTextEdit.EditValueChanged

        If schedByQuantityCheckEdit.Checked Then
            RecalculateEndTime()
        Else
            RecalculateQuantity()
        End If

    End Sub

    Private Sub RecalculateEndTime()

        If itemLookUpEdit.EditValue Is Nothing OrElse quantityTextEdit.EditValue Is Nothing Then
            Return
        End If

        Dim requiredMinutes As Double = CDbl(CInt(quantityTextEdit.EditValue) / m_ScheduleSession.GetObjectByKey(Of Items)(itemLookUpEdit.EditValue).ItemProdStandard / 0.7465)

        edtEndDate.EditValue = DateAdd(DateInterval.Minute, requiredMinutes, Date.Parse(String.Format("{0} {1}", edtStartDate.DateTime.ToString("MM/dd/yyyy"), edtStartTime.Time.ToString("HH:mm"))))
        edtEndTime.EditValue = DateAdd(DateInterval.Minute, requiredMinutes, edtStartTime.Time)

    End Sub

    Private Sub RecalculateQuantity()

        If itemLookUpEdit.EditValue Is Nothing Then
            Return
        End If

        Dim workMinutes As Double = DateDiff(DateInterval.Minute, Date.Parse(String.Format("{0} {1}", edtStartDate.DateTime.ToString("MM/dd/yyyy"), edtStartTime.Time.ToString("HH:mm"))),
                                             Date.Parse(String.Format("{0} {1}", edtEndDate.DateTime.ToString("MM/dd/yyyy"), edtEndTime.Time.ToString("HH:mm")))) * 0.7465

        Dim EstimatedAmount As Integer = CInt(workMinutes * m_ScheduleSession.GetObjectByKey(Of Items)(itemLookUpEdit.EditValue).ItemProdStandard)

        quantityTextEdit.EditValue = EstimatedAmount

    End Sub

    Private Sub UpdateItemDropDown()

        If projectLookUpEdit.EditValue IsNot Nothing AndAlso projectDetailLookUpEdit.EditValue IsNot Nothing Then
            projectItemsXpView.Criteria = New GroupOperator(GroupOperatorType.And, New BinaryOperator(ProjectDetails.Fields.Project.Oid.PropertyName, CInt(projectLookUpEdit.EditValue), BinaryOperatorType.Equal),
                                                            New BinaryOperator(ProjectDetails.Fields.Oid.PropertyName, CInt(projectDetailLookUpEdit.EditValue), BinaryOperatorType.Equal),
                                                            New InOperator(ProjectDetails.Fields.ProjectItem.ItemType.PropertyName, "IG", "FG"))
            itemLookUpEdit.Properties.DataSource = projectItemsXpView
            itemLookUpEdit.EditValue = projectDetailLookUpEdit.GetColumnValue("ProjectItemID")
        ElseIf projectLookUpEdit.EditValue IsNot Nothing Then
            projectItemsXpView.Criteria = New GroupOperator(GroupOperatorType.And, New BinaryOperator(ProjectDetails.Fields.Project.Oid.PropertyName, CInt(projectLookUpEdit.EditValue), BinaryOperatorType.Equal),
                                                            New InOperator(ProjectDetails.Fields.ProjectItem.ItemType.PropertyName, "IG", "FG"))
            itemLookUpEdit.Properties.DataSource = projectItemsXpView
        Else
            itemLookUpEdit.Properties.DataSource = itemsXpView
        End If

    End Sub

    Private Sub schedByQuantityCheckEdit_CheckedChanged(sender As Object, e As EventArgs) Handles schedByQuantityCheckEdit.CheckedChanged

        quantityTextEdit.ReadOnly = schedByQuantityCheckEdit.Checked = False

    End Sub

    Public Sub EnableEditing()

        If AllowEdit Then
            peopleTextEdit.Enabled = True
            operatorTextEdit.Enabled = True
            itemLookUpEdit.Enabled = True
            mustRunCheckEdit.Enabled = True
            projectLookUpEdit.Enabled = True
            projectDetailLookUpEdit.Enabled = True
            priorityComboBoxEdit.Enabled = True
            quantityTextEdit.Enabled = True
            schedByQuantityCheckEdit.Enabled = True
        Else
            peopleTextEdit.Enabled = False
            operatorTextEdit.Enabled = False
            itemLookUpEdit.Enabled = False
            mustRunCheckEdit.Enabled = False
            projectLookUpEdit.Enabled = False
            projectDetailLookUpEdit.Enabled = False
            priorityComboBoxEdit.Enabled = False
            quantityTextEdit.Enabled = False
            schedByQuantityCheckEdit.Enabled = False
        End If
    End Sub

    Public Property AllowEdit As Boolean


End Class
