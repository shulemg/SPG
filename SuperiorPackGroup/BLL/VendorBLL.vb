Imports DXDAL.SPGData
Imports DevExpress.Xpo

Public Class VendorBLL

    Public Shared Function VendorInUse(ByVal vendorID As Integer) As Boolean

        Try
            Dim cv As Vendor = Session.DefaultSession.GetObjectByKey(Of Vendor)(vendorID)
            If cv.Receivings.Count <> 0 Then
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try

        Return False

    End Function

End Class
