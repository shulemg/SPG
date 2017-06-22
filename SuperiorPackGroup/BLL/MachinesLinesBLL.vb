Imports SuperiorPackGroup.SPGTableAdapters
Imports System.Text
Imports DevExpress.xpo 
Imports DXDAL.SPGData

<System.ComponentModel.DataObject()> _
Public Class MachinesLinesBLL

    Private m_MachineLinesTableAdapter As MachineLinesTableAdapter = Nothing
    Public ReadOnly Property Adapter() As MachineLinesTableAdapter

        Get
            If m_MachineLinesTableAdapter Is Nothing Then
                m_MachineLinesTableAdapter = New MachineLinesTableAdapter()
                m_MachineLinesTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return m_MachineLinesTableAdapter
        End Get

    End Property

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function GetMachineLines() As SPG.MachineLinesDataTable

        Return Adapter.GetMachineLines()

    End Function

    Private Sub UpdateAuditTrail(ByVal ModifiedRecord As SPG.MachineLinesRow, ByVal originalRecord As Object())

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
            AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(ModifiedRecord.Item(0), Integer), "MachineLines", builder.ToString)
        End If

    End Sub

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateMachineLine(ByVal id As Nullable(Of Integer), ByVal name As String) As Boolean

        Dim machineLines As SPG.MachineLinesDataTable = Adapter.GetMachineLineByID(id.Value)

        If machineLines.Count = 0 Then
            'It is a new Product
            Return Me.InsertMachineLine(name)
        End If

        Dim machineLine As SPG.MachineLinesRow = machineLines(0)

        If String.IsNullOrEmpty(name) Then
            Throw New ApplicationException("You must provide Machine Line Name.")
        End If

        Dim originalRecord As Object() = Nothing
        originalRecord = machineLine.ItemArray

        machineLine.MachineLineName = name

        If Not IsNothing(originalRecord) Then
            Me.UpdateAuditTrail(machineLine, originalRecord)
        End If

        Dim rowsAffected As Integer = Adapter.Update(machineLine)

        Return rowsAffected = 1

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, True)> _
    Public Function InsertMachineLine(ByVal name As String) As Boolean

        Dim machineLines As SPG.MachineLinesDataTable = New SPG.MachineLinesDataTable
        Dim machineLine As SPG.MachineLinesRow = machineLines.NewMachineLinesRow

        If String.IsNullOrEmpty(name) Then
            Throw New ApplicationException("You must provide Machine Line Name.")
        End If

        machineLine.MachineLineName = name

        machineLines.AddMachineLinesRow(machineLine)
        Dim rowsAffected As Integer = Adapter.Update(machineLines)

        Return rowsAffected = 1

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, True)> _
    Public Function DeleteMachineLine(ByVal id As Integer) As Boolean

        Dim machineLines As SPG.MachineLinesDataTable = Adapter.GetMachineLineByID(id)
        Dim rowsAffected As Integer = 0

        If machineLines.Count = 1 Then
            Dim machineLine As SPG.MachineLinesRow = CType(machineLines.Rows(0), SPG.MachineLinesRow)
            If New ProductionBLL().GetProductionByMachine(id).Count <> 0 Then
                MessageBox.Show("You can't delete this machineLine there are other records associated to it")
                Return True
            End If
            rowsAffected = Adapter.Delete(id, machineLine.ts)
        End If

        'Return true if precisely one row was deleted, otherwise return false.
        Return rowsAffected = 1

    End Function

End Class
