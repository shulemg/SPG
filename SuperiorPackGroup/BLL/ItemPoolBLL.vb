Imports System.Text
Imports DXDAL.SPGData
Imports DevExpress.Xpo

Public Class ItemPoolBLL

    Public Shared Function ValidateRecord(ByVal poolCode As String, ByVal customerID As Integer?) As Boolean

        If String.IsNullOrEmpty(poolCode) Then
            Return False
        End If
        If Not customerID.HasValue Then
            Return False
        End If

        Return True

    End Function

    Public Shared Function DeleteItemPool(ByVal poolID As Integer) As Boolean

        Dim pool As ItemPool = Session.DefaultSession.GetObjectByKey(Of ItemPool)(poolID)

        If PoolBomBLL.PoolUsedAsBom(poolID) Then
            MessageBox.Show("You can't delete this item pool there are BOM records associated to it")
        Else
            pool.Delete()
        End If

        Return pool.IsDeleted

    End Function

End Class
