Imports DevExpress.Data.Filtering
Imports DXDAL.SPGData
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.XtraScheduler.Native
Imports DevExpress.XtraScheduler.Services
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.XtraReports.UI
Imports DevExpress.Xpo
Imports System.ComponentModel
Imports DevExpress.Services

Public Class ProjectSchedulingXtraForm

    Friend itemContextMenu As ContextMenu
    Friend WithEvents openInItemsManager As MenuItem
    Dim shiftTimeScaleCaption As ShiftsTimeScaleFixedIntervalCaptionService
    Dim prevHeaderCaptionServeice As IHeaderCaptionService
    Dim oldMouseHandler As IMouseHandlerService
    Dim newMouseHandler As CustomMouseHandlerService
    Dim m_SchedulingSession As Session
    Dim allowAdd As Boolean = False
    Dim allowEdit As Boolean = False
    Public Function CheckPermissions() As Boolean

        Dim permission As SPG.UserPermissionsRow = New UserPermissionsBLL().GetUserPermissionsByUserName(My.Settings.UserName, "Projects And Scheduling")(0)
        Try
            Select Case permission.PermissionLevel
                Case "FULL", "Full"
                    NewAppointmentItem1.Enabled = True
                    allowAdd = True
                    allowEdit = True
                Case "ADD", "Add"
                    NewAppointmentItem1.Enabled = True
                    allowAdd = True
                    allowEdit = True
                Case "NONE", "None"
                    MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Close()
                    Return False
                Case "VIEW", "View"
                    NewAppointmentItem1.Enabled = False
                    allowAdd = False
                    allowEdit = False
                Case "EDIT", "Edit"
                    NewAppointmentItem1.Enabled = False
                    allowAdd = False
                    allowEdit = True
                Case Else
                    MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Close()
                    Return False
            End Select
            Return True
        Catch ex As InvalidOperationException
            Return False
        End Try

    End Function

    Private Sub ProjectSchedulingXtraForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        productionSchedulerControl.GroupType = SchedulerGroupType.Date
        productionSchedulerControl.ActiveViewType = SchedulerViewType.Timeline
        productionSchedulerControl.Start = Today
        productionSchedulerControl.TimelineView.Scales.Add(New ShiftsTimeScaleFixedInterval())
        productionSchedulerControl.TimelineView.Scales.RemoveAt(6)
        productionSchedulerControl.TimelineView.Scales.RemoveAt(5)

        prevHeaderCaptionServeice = productionSchedulerControl.GetService(Of IHeaderCaptionService)
        shiftTimeScaleCaption = New ShiftsTimeScaleFixedIntervalCaptionService(prevHeaderCaptionServeice, productionSchedulerControl)
        productionSchedulerControl.RemoveService(GetType(IHeaderCaptionService))
        productionSchedulerControl.AddService(GetType(IHeaderCaptionService), shiftTimeScaleCaption)

        oldMouseHandler = productionSchedulerControl.GetService(Of IMouseHandlerService)
        If oldMouseHandler IsNot Nothing Then
            newMouseHandler = New CustomMouseHandlerService(productionSchedulerControl, oldMouseHandler)
            productionSchedulerControl.RemoveService(GetType(IMouseHandlerService))
            productionSchedulerControl.AddService(GetType(IMouseHandlerService), newMouseHandler)
        End If

        itemContextMenu = New ContextMenu
            openInItemsManager = New MenuItem With {.Text = "Open In Items Manager"}
            itemContextMenu.MenuItems.Add(openInItemsManager)

            m_SchedulingSession = New Session(SPGDataLayer)
            lastSaved = CInt(m_SchedulingSession.Evaluate(Of ProductionSchedule)(CriteriaOperator.Parse("Max(Oid)"), Nothing))
            projectDetailsXpCollection.Session = m_SchedulingSession
            m_SchedulingSession.DropIdentityMap()

    End Sub

    Private Sub productionSchedulerControl_EditAppointmentFormShowing(sender As Object, e As AppointmentFormEventArgs) Handles productionSchedulerControl.EditAppointmentFormShowing

        Dim scheduler As SchedulerControl = CType(sender, SchedulerControl)
        Dim form As CustomAppointmentForm = New CustomAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm)
        Try
            form.AllowEdit = allowEdit
            form.EnableEditing()
            e.DialogResult = form.ShowDialog
            e.Handled = True
        Finally
            form.Dispose()
        End Try

    End Sub

    Private Sub productionSchedulerControl_PopupMenuShowing(sender As Object, e As PopupMenuShowingEventArgs) Handles productionSchedulerControl.PopupMenuShowing

        If e.Menu.Id = SchedulerMenuItemId.DefaultMenu Then
            e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewRecurringAppointment)
            e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewAllDayEvent)
            e.Menu.GetMenuItemById(SchedulerMenuItemId.NewAppointment).Caption = "New Production Schedule"
            If allowAdd = False Then
                e.Menu.GetMenuItemById(SchedulerMenuItemId.NewAppointment).Enabled = False
            End If
        ElseIf e.Menu.Id = SchedulerMenuItemId.AppointmentMenu Then
            e.Menu.RemoveMenuItem(SchedulerMenuItemId.LabelSubMenu)
            e.Menu.RemoveMenuItem(SchedulerMenuItemId.StatusSubMenu)
        End If

    End Sub

    Private Sub productionSchedulerControl_DateNavigatorQueryActiveViewType(sender As Object, e As DateNavigatorQueryActiveViewTypeEventArgs) Handles productionSchedulerControl.DateNavigatorQueryActiveViewType

        If e.OldViewType = SchedulerViewType.Timeline Then
            e.NewViewType = SchedulerViewType.Timeline
        End If

    End Sub

    Private Sub scheduleProjectsSplitContainerControl_Resize(sender As Object, e As EventArgs) Handles scheduleProjectsSplitContainerControl.Resize

        scheduleProjectsSplitContainerControl.SplitterPosition = Math.Min(CInt(scheduleProjectsSplitContainerControl.Height - scheduleProjectsSplitContainerControl.Height / 4), 550)
        projectsItemReferenceSplitContainerControl.SplitterPosition = CInt(projectsItemReferenceSplitContainerControl.Width / 2)

    End Sub

    Private Sub projectDetailsGridView_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles projectDetailsGridView.FocusedRowChanged

        Try
            itemReferenceXpCollection.Criteria = New BinaryOperator(Items.Fields.ItemID.PropertyName, projectDetailsGridView.GetFocusedRowCellValue(colProjectItemID), BinaryOperatorType.Equal)

        Catch
            itemReferenceXpCollection.Criteria = New BinaryOperator(Items.Fields.ItemID.PropertyName, 0, BinaryOperatorType.Equal)
        End Try

    End Sub

    Private Sub itemGridView_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles itemGridView.PopupMenuShowing

        Dim hitInfo As GridHitInfo = itemGridView.CalcHitInfo(e.Point)
        If hitInfo.InRow Then
            itemGridView.FocusedRowHandle = hitInfo.RowHandle
            itemContextMenu.Show(itemGridView.GridControl, e.Point)
        End If

    End Sub

    Private Sub openInItemsManager_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles openInItemsManager.Click

        With ItemsXtraForm
            .MdiParent = Me.MdiParent
            .AdvancedTabs = MainXtraForm.AdvancedTabs
            If .CheckPermissions = False Then
                Exit Sub
            End If
            .Show()
            .CurrentItemID = CType(projectDetailsGridView.GetFocusedRowCellValue(colProjectItemID), Integer?)
            .Activate()
        End With

    End Sub

    Private Sub productionSchedulerControl_CustomDrawResourceHeader(sender As Object, e As CustomDrawObjectEventArgs) Handles productionSchedulerControl.CustomDrawResourceHeader

        Dim machineLineHeader As ResourceHeader = CType(e.ObjectInfo, ResourceHeader)
        Dim machineHeaderStringFormat As StringFormat = machineLineHeader.Appearance.HeaderCaption.TextOptions.GetStringFormat
        Dim machineLineCaption As String = String.Format("{0}{1}Total:{1}{2}", machineLineHeader.Resource.Caption, vbCrLf, CalculateVisibleResourceTotals(machineLineHeader.Interval, machineLineHeader.Resource).ToString)

        If productionSchedulerControl.ActiveViewType = SchedulerViewType.Timeline Then
            e.Cache.DrawString(machineLineCaption, machineLineHeader.Appearance.HeaderCaption.Font, Brushes.Black, e.Bounds, machineHeaderStringFormat)
        Else
            e.Cache.DrawString(machineLineCaption, machineLineHeader.Appearance.HeaderCaption.Font, Brushes.Black, e.Bounds, machineHeaderStringFormat)
        End If

        e.Handled = True

    End Sub

    Private Function CalculateVisibleResourceTotals(ByVal interval As TimeInterval, ByVal resource As Resource) As Double

        Dim scheduledProduction As AppointmentBaseCollection = Me.SchedulerStorage1.GetAppointments(interval)
        Dim total As Double = 0.0F

        Dim machines As New ResourceBaseCollection

        machines.Add(resource)

        Dim machinesFilter As New ResourcesAppointmentsFilter(machines)

        machinesFilter.Process(scheduledProduction)

        For Each productionSchedule As Appointment In CType(machinesFilter.DestinationCollection, AppointmentBaseCollection)
            If productionSchedule.CustomFields("Quantity") IsNot Nothing Then
                Dim scheduledQuantity As Double
                Double.TryParse(productionSchedule.CustomFields("Quantity").ToString, scheduledQuantity)
                total += scheduledQuantity
            End If
        Next

        Return total

    End Function

    Private Sub PrintPreviewItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)

        Dim xr As New ProductionScheduleXtraSchedulerReport
        Dim scPrintAdapter As New SchedulerControlPrintAdapter(productionSchedulerControl)
        xr.SchedulerAdapter = scPrintAdapter

        xr.CreateDocument(True)
        xr.ProductionScheduleReportTimelineView.Scales.Add(New ShiftsTimeScaleFixedInterval())

        Using printTool As New ReportPrintTool(xr)
            printTool.ShowPreviewDialog()
        End Using

    End Sub

    Private Sub openReportBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles openReportBarButtonItem.ItemClick

        With QuickReportsXtraForm
            .MdiParent = Me.MdiParent
            .Show()
            .SelectReport(True, "ShiftScheduleXtraReport", False)
            '.FillReports(Nothing)
            .Activate()
        End With

    End Sub

    Private Sub ProjectSchedulingXtraForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        For Each appointment As ProductionSchedule In productionScheduleXpCollection
            If appointment.Oid = -1 Then
                appointment.Save()
            End If
        Next
    End Sub

    Private Sub productionSchedulerControl_GotFocus(sender As Object, e As EventArgs) Handles productionSchedulerControl.GotFocus
        For Each appointment As ProductionSchedule In productionScheduleXpCollection
            If appointment.Oid = -1 Then
                appointment.Save()
            End If
        Next
    End Sub

    Dim lastSaved As Integer

End Class