Imports DXDAL.SPGData
Imports DevExpress.Xpo

Public Class LocationsBLL

    Public Shared Function DeleteLocation(ByVal locationID As Integer, ByVal session As Session) As Boolean

        Dim location As Locations = session.GetObjectByKey(Of Locations)(locationID)

        If location.LocationTransfersFrom.Count > 0 OrElse location.LocationTransfersTo.Count > 0 OrElse location.LocationReceivings.Count > 0 OrElse location.LocationsInventory.Count > 0 OrElse location.LocationShippings.Count > 0 _
                    OrElse location.LocationProduction.Count > 0 OrElse IsDefaultLocation(location) Then
            MessageBox.Show("You can't delete this location there are records associated to it")
        Else
            location.Delete()
        End If

        Return location.IsDeleted

    End Function

    Public Shared Function IsDefaultLocation(ByVal location As Locations) As Boolean

        If CompanySettingsBLL.GetDefaultLocation() IsNot Nothing Then
            Return location.Oid = CompanySettingsBLL.GetDefaultLocation().Oid
        End If

        Return False


    End Function

    Public Shared Function ValidateRecord(ByVal locationCode As String) As Boolean

        If String.IsNullOrEmpty(locationCode) Then
            Return False
        End If

        Return True

    End Function

End Class
