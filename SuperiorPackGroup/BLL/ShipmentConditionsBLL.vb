Imports DXDAL.SPGData
Imports DevExpress.Xpo

Public Class ShipmentConditionsBLL

    Public Shared Function DeleteCondition(ByVal conditionID As Integer) As Boolean

        Dim condition As ShipmentConditions = Session.DefaultSession.GetObjectByKey(Of ShipmentConditions)(conditionID)

        If condition.ReceivingLoadCondition.Count + condition.ShipingLoadCondition.Count + condition.ReceivingPhysicalCondition.Count + condition.ShipingPhysicalCondition.Count > 0 Then
            MessageBox.Show("You can't delete this condition there are other records associated to it")
        Else
            condition.Delete()
        End If

        Return condition.IsDeleted

    End Function

End Class
