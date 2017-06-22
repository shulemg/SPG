Imports DevExpress.Xpo
Imports DXDAL.SPGData
Imports System.ComponentModel
Imports System.Linq

Public Class ProjectsBLL

    Public Shared Function GetProjectDetailChanges(ByVal session As Session, ByVal recordID As Integer) As BindingList(Of ChangeObject)

        Dim result As New List(Of ChangeObject)

        For Each detail As ProjectDetails In session.GetObjectByKey(Of Project)(recordID).ProjectDetails
            result.AddRange(AuditTrailBLL.GetChanges(session, "ProjectDetails", detail.Oid, True).ToList())
        Next

        Return New BindingList(Of ChangeObject)(result)

    End Function

    Public Shared Function ValidateRecord(ByVal ProjectName As String, ByVal CustomerID As Integer?, ByVal ReqStartDate As Date?, ByVal ReqDeliveryDate As Date?, ByVal ReqShipDate As Date?) As Boolean

        If ReqDeliveryDate.HasValue AndAlso ReqDeliveryDate.Value = #12:00:00 AM# Then
            ReqDeliveryDate = Nothing
        End If

        If ReqShipDate.HasValue AndAlso ReqShipDate.Value = #12:00:00 AM# Then
            ReqShipDate = Nothing
        End If

        If String.IsNullOrEmpty(ProjectName) OrElse CustomerID.HasValue = False OrElse (ReqDeliveryDate.HasValue = False AndAlso ReqShipDate.HasValue = False) Then
            Return False
        End If

        If ReqStartDate.HasValue AndAlso ((ReqShipDate.HasValue AndAlso ReqStartDate.Value > ReqShipDate.Value) OrElse (ReqDeliveryDate.HasValue AndAlso ReqStartDate.Value.Date > ReqDeliveryDate.Value.Date)) Then
            Return False
        End If

        Return True

    End Function



End Class
