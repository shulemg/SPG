Imports SuperiorPackGroup.SPGTableAdapters
Imports DevExpress.Xpo
Imports DXDAL.SPGData
Imports DevExpress.Data.Filtering
Imports System.ComponentModel
Imports System.Linq

Public Class AuditTrailBLL

    Private Shared m_TrailTableAdapter As AuditTrailTableAdapter = Nothing
    Public Shared ReadOnly Property Adapter() As AuditTrailTableAdapter
        Get
            If (AuditTrailBLL.m_TrailTableAdapter Is Nothing) Then
                AuditTrailBLL.m_TrailTableAdapter = New AuditTrailTableAdapter
                AuditTrailBLL.m_TrailTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return AuditTrailBLL.m_TrailTableAdapter
        End Get
    End Property

    Public Shared Sub AddTrailEntry(ByVal userID As String, ByVal recordID As Integer, ByVal recordType As String, ByVal recordChanges As String)

        Dim dataTable As New SPG.AuditTrailDataTable
        Dim row As SPG.AuditTrailRow = dataTable.NewAuditTrailRow
        row.UserID = userID
        row.RecordID = recordID
        row.RecordType = recordType
        row.RecordChanges = recordChanges
        row.ChangeDate = DateAndTime.Now
        dataTable.AddAuditTrailRow(row)
        AuditTrailBLL.Adapter.Update(dataTable)

    End Sub

    Public Shared Function GetChanges(ByVal session As Session, ByVal recordType As String, ByVal recordID As Integer, ByVal UniqueProperties As Boolean, ByVal ParamArray PropertyNames As String()) As BindingList(Of ChangeObject)

        Dim result As New List(Of ChangeObject)

        Dim auditFields As New AuditTrail.FieldsClass
        Using auditRecords As New XPCollection(Of AuditTrail)(session, New GroupOperator(GroupOperatorType.And, New BinaryOperator(auditFields.RecordID.PropertyName, recordID, BinaryOperatorType.Equal),
                                                                                         New BinaryOperator(auditFields.RecordType.PropertyName, recordType, BinaryOperatorType.Equal)))
            For Each auditRecord As AuditTrail In auditRecords
                If UniqueProperties = True Then
                    result.AddRange(GetUniqueChanges(auditRecord.PK_ID, recordID, auditRecord.ChangeDate, auditRecord.RecordChanges).Values.ToList())
                End If

            Next
        End Using

        Return New BindingList(Of ChangeObject)(result)

    End Function

    Private Shared Function GetUniqueChanges(ByVal ChangeID As Integer, ByVal recordID As Integer, ByVal DateChanged As Date, ByVal recordChanges As String,
                                             ByVal ParamArray PropertyNames As String()) As Dictionary(Of ChangeObjectLookUpKey, ChangeObject)

        Dim currentChange As ChangeObject
        Dim currentKey As ChangeObjectLookUpKey
        Dim result As Dictionary(Of ChangeObjectLookUpKey, ChangeObject) = New Dictionary(Of ChangeObjectLookUpKey, ChangeObject)
        Dim changes As String() = Split(recordChanges, ";")

        For i As Integer = 0 To changes.Length - 2
            currentChange = New ChangeObject
            currentKey = New ChangeObjectLookUpKey

            currentChange.ChangeID = ChangeID
            currentChange.DateChanged = DateChanged
            currentChange.RecordID = recordID
            currentChange.PropertyName = Split(changes(i), ":")(0)
            currentChange.PrevValue = Split(Split(changes(i), ":")(1), "(")(0)
            currentChange.NewValue = Split(Split(changes(i), ":")(1), "(")(1).Replace(")", "")

            currentKey.ChangeID = currentChange.ChangeID
            currentKey.ProperyName = currentChange.PropertyName

            If result.ContainsKey(currentKey) Then
                currentChange.PrevValue = result(currentKey).PrevValue
                result(currentKey) = currentChange
            Else
                result.Add(currentKey, currentChange)
            End If
        Next i

        Return result

    End Function

End Class
