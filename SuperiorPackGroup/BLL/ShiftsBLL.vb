Imports SuperiorPackGroup.SPGTableAdapters
Imports System.Text
Imports DXDAL.SPGData
Imports DevExpress.Xpo

<System.ComponentModel.DataObject()> _
Public Class ShiftsBLL

    Private m_ShiftsTableAdapter As ShiftsTableAdapter = Nothing
    Public ReadOnly Property Adapter() As ShiftsTableAdapter

        Get
            If m_ShiftsTableAdapter Is Nothing Then
                m_ShiftsTableAdapter = New ShiftsTableAdapter()
                m_ShiftsTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return m_ShiftsTableAdapter
        End Get

    End Property

    Private Sub UpdateAuditTrail(ByVal ModifiedRecord As SPG.ShiftsRow, ByVal originalRecord As Object())

        Dim builder As New StringBuilder(String.Empty)
        Dim recordFields As Integer = (ModifiedRecord.ItemArray.Length - 1)
        Dim i As Integer = 0
        Do While (i <= recordFields)
            Try
                If IsDBNull(originalRecord(i)) Then
                    If Not IsDBNull(ModifiedRecord.Item(i)) Then
                        builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, "NULL", ModifiedRecord.Item(i)))
                    End If
                ElseIf Information.IsDBNull(ModifiedRecord.Item(i)) Then
                    If Not Information.IsDBNull(originalRecord(i)) Then
                        builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, originalRecord(i), "NULL"))
                    End If
                ElseIf ModifiedRecord.Item(i) IsNot originalRecord(i) Then
                    builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, originalRecord(i), ModifiedRecord.Item(i)))
                End If
            Catch
            End Try
            i += 1
        Loop
        If (builder.Length > 2) Then
            builder.Length = (builder.Length - 2)
            AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(ModifiedRecord.Item(0), Integer), "Shifts", builder.ToString)
        End If

    End Sub

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function GetShifts() As SPG.ShiftsDataTable

        Return Adapter.GetShifts()

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateShift(ByVal id As Nullable(Of Integer), ByVal name As String) As Boolean

        Dim shifts As SPG.ShiftsDataTable = Adapter.GetShiftByID(id.Value)

        If shifts.Count = 0 Then
            'It is a new Product
            Return Me.InsertShift(name)
        End If

        Dim shift As SPG.ShiftsRow = shifts(0)

        If String.IsNullOrEmpty(name) Then
            Throw New ApplicationException("You must provide a Shift Name.")
        End If

        Dim originalRecord As Object() = Nothing
        originalRecord = shift.ItemArray

        shift.ShiftName = name

        If Not IsNothing(originalRecord) Then
            Me.UpdateAuditTrail(shift, originalRecord)
        End If

        Dim rowsAffected As Integer = Adapter.Update(shift)

        Return rowsAffected = 1

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, True)> _
    Public Function InsertShift(ByVal name As String) As Boolean

        Dim shifts As SPG.ShiftsDataTable = New SPG.ShiftsDataTable
        Dim shift As SPG.ShiftsRow = shifts.NewShiftsRow

        If String.IsNullOrEmpty(name) Then
            Throw New ApplicationException("You must provide a Shift Name.")
        End If

        shift.ShiftName = name

        shifts.AddShiftsRow(shift)
        Dim rowsAffected As Integer = Adapter.Update(shifts)

        Return rowsAffected = 1

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, True)> _
    Public Function DeleteShift(ByVal id As Integer) As Boolean

        Dim shifts As SPG.ShiftsDataTable = Adapter.GetShiftByID(id)
        Dim rowsAffected As Integer = 0

        If shifts.Count = 1 Then
            Dim shift As SPG.ShiftsRow = CType(shifts.Rows(0), SPG.ShiftsRow)
            If New ProductionBLL().GetProductionByShift(id).Count <> 0 Then
                MessageBox.Show("You can't delete this shift there are other records associated to it")
                Return True
            End If
            rowsAffected = Adapter.Delete(id, shift.ts)
        End If

        'Return true if precisely one row was deleted, otherwise return false.
        Return rowsAffected = 1

    End Function

    Public Shared Function GetShiftByID(ByVal shiftID As Integer) As Shifts

        Return XpoDefault.Session.GetObjectByKey(Of Shifts)(shiftID)

    End Function

End Class
