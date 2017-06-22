Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.XtraScheduler.Services

Public Class ShiftsTimeScaleFixedIntervalCaptionService : Inherits HeaderCaptionServiceWrapper

    Public Sub New(ByVal service As IHeaderCaptionService, ByVal provider As SchedulerControl)
        MyBase.New(service)

        Me.Provider = provider

    End Sub

    Public Overrides Function GetTimeScaleHeaderCaption(header As TimeScaleHeader) As String

        'Return MyBase.GetTimeScaleHeaderCaption(header)
        If TypeOf header.Scale Is ShiftsTimeScaleFixedInterval Then
            Dim assignedPeople As Double = 0
            Dim scheduledProduction As AppointmentBaseCollection = Provider.Storage.GetAppointments(header.Interval)

            For Each productionSchedule As Appointment In scheduledProduction
                If productionSchedule.CustomFields("People") IsNot Nothing Then
                    Dim assignedQuantity As Double
                    Double.TryParse(productionSchedule.CustomFields("People").ToString, assignedQuantity)
                    assignedPeople += assignedQuantity
                End If
                If productionSchedule.CustomFields("MachineOperator") IsNot Nothing Then
                    Dim assignedQuantity As Double
                    Double.TryParse(productionSchedule.CustomFields("MachineOperator").ToString, assignedQuantity)
                    assignedPeople += assignedQuantity
                End If
            Next

            Dim caption As String = MyBase.GetTimeScaleHeaderCaption(header)

            Dim today As Date = header.Interval.Start
            Dim tomorrow As Date = header.Interval.Start.Date.AddDays(1)
            Dim productionDay As String = String.Empty

            If today <> DateTime.MinValue Then
                If header.Interval.[End] <= New Date(today.Year, today.Month, today.Day, 9, 0, 0) Then
                    productionDay = String.Format("{0}. ", today.AddDays(-1).ToString("ddd"))
                Else
                    productionDay = String.Format("{0}. ", today.ToString("ddd"))
                End If
            End If

            If today >= New Date(today.Year, today.Month, today.Day, 1, 0, 0) And header.Interval.[End] <= New Date(today.Year, today.Month, today.Day, 9, 0, 0) Then
                caption = String.Format("{0}Shift 3", productionDay)
            ElseIf today >= New Date(today.Year, today.Month, today.Day, 9, 0, 0) And header.Interval.[End] <= New Date(today.Year, today.Month, today.Day, 17, 0, 0) Then
                caption = String.Format("{0}Shift 1", productionDay)
            ElseIf today >= New Date(today.Year, today.Month, today.Day, 17, 0, 0) And header.Interval.[End] <= New Date(tomorrow.Year, tomorrow.Month, tomorrow.Day, 1, 0, 0) Then
                caption = String.Format("{0}Shift 2", productionDay)
            End If

            caption = String.Format("{0} - People\Operators Assigned {1}", caption, assignedPeople)

            Return caption
        Else
            Return MyBase.GetTimeScaleHeaderCaption(header)
        End If

    End Function

    Public Property Provider As SchedulerControl

End Class
