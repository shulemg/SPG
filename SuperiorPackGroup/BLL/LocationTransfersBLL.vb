Imports DXDAL.SPGData
Imports DevExpress.Data.Filtering

Public Class LocationTransfersBLL

    Shared Function ValidateRecord(transferNumber As Integer?, fromLocationID As Integer?, toLocationID As Integer?, carrierID As Integer?, transferRecord As LocationTransfers, session As DevExpress.Xpo.Session) As Boolean

        If fromLocationID.HasValue = False OrElse toLocationID.HasValue = False OrElse carrierID.HasValue = False Then
            Return False
        End If

        If fromLocationID.Value = toLocationID.Value Then
            Return False
        End If

        If transferNumber.HasValue = False OrElse transferNumber.Value = 0 Then
            Dim maxTransferNumber As Integer? = CType(session.Evaluate(Of LocationTransfers)(New AggregateOperand("", "TransferNumber", Aggregate.Max), Nothing), Integer?)
            If maxTransferNumber.HasValue Then
                transferNumber = maxTransferNumber + 1
            Else
                transferNumber = 1
            End If

            transferRecord.TransferNumber = transferNumber.Value
        End If

        Return True

    End Function


End Class
