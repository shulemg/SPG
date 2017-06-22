Imports DevExpress.Services
Imports DevExpress.XtraScheduler

Public Class CustomMouseHandlerService
    Inherits MouseHandlerServiceWrapper

    Dim provider As IServiceProvider

    Public Sub New(provider As IServiceProvider, service As IMouseHandlerService)
        MyBase.New(service)

        Me.provider = provider
    End Sub

    Public Overrides Sub OnMouseWheel(e As MouseEventArgs)

        Dim scheduler As SchedulerControl = TryCast(provider, SchedulerControl)
        If scheduler IsNot Nothing AndAlso scheduler.ActiveViewType = SchedulerViewType.Timeline Then
            Return
        End If

        MyBase.OnMouseWheel(e)

    End Sub

End Class
