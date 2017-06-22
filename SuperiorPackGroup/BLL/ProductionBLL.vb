Imports SuperiorPackGroup.SPGTableAdapters
Imports System.Text
Imports DevExpress.Xpo
Imports DXDAL.SPGData

<System.ComponentModel.DataObject()> _
Public Class ProductionBLL

    Private m_ProductionTableAdapter As ProductionTableAdapter = Nothing
    Public ReadOnly Property Adapter() As ProductionTableAdapter

        Get
            If m_ProductionTableAdapter Is Nothing Then
                m_ProductionTableAdapter = New ProductionTableAdapter()
                m_ProductionTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return m_ProductionTableAdapter
        End Get

    End Property

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetProductionByCustomerID(ByVal customerID As Integer) As SPG.ProductionDataTable

        Return Adapter.GetProductionByCustomerID(customerID)

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetProductionByMachine(ByVal machineID As Integer) As SPG.ProductionDataTable

        Return Adapter.GetProductionByMachine(machineID)

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetProductionByItemID(ByVal itemID As Integer) As SPG.ProductionDataTable

        Return Adapter.GetProductionByItemID(itemID)

    End Function

    Private Sub UpdateAuditTrail(ByVal ModifiedRecord As SPG.ProductionRow, ByVal originalRecord As Object())

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
            AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(ModifiedRecord.Item(0), Integer), "Production", builder.ToString)
        End If

    End Sub

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateProduction(ByVal productionID As Integer, ByVal productionDate As Nullable(Of Date), ByVal shift As Nullable(Of Integer), ByVal item As Nullable(Of Integer), ByVal quantity As Nullable(Of Single), _
                                     ByVal machine As Nullable(Of Integer), ByVal startTime As Nullable(Of Date), ByVal stopTime As Nullable(Of Date), ByVal packers As Nullable(Of Single)) As Boolean

        Dim production As SPG.ProductionDataTable = Adapter.GetProductionByID(productionID)

        If production.Count = 0 Then
            'It is a new Production Record
            Return Me.InsertProduction(productionID, productionDate, shift, item, quantity, machine, startTime, stopTime, packers)
        End If

        Dim productionRecord As SPG.ProductionRow = production(0)

        Dim originalRecord As Object() = Nothing
        originalRecord = productionRecord.ItemArray

        productionRecord.ProdMainDate = CDate(Format(productionDate, "D"))
        productionRecord.ProdMainShift = shift.Value
        productionRecord.ProdMainItemID = item.Value
        productionRecord.ProdMainQuantity = quantity.Value
        productionRecord.ProdMainMachineLine = machine.Value
        productionRecord.ProdMainTimeStart = startTime.Value
        productionRecord.ProdMainTimeStop = stopTime.Value
        If Not packers.HasValue Then
            productionRecord.ProdMainPackers = 0
        Else
            productionRecord.ProdMainPackers = packers.Value
        End If

        If Not IsNothing(originalRecord) Then
            Me.UpdateAuditTrail(productionRecord, originalRecord)
        End If

        Dim rowsAffected As Integer = Adapter.Update(productionRecord)

        Return rowsAffected = 1

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, True)> _
    Public Function InsertProduction(ByVal productionID As Integer, ByVal productiondate As Nullable(Of Date), ByVal shift As Nullable(Of Integer), ByVal item As Nullable(Of Integer), ByVal quantity As Nullable(Of Single), _
                                     ByVal machine As Nullable(Of Integer), ByVal startTime As Nullable(Of Date), ByVal stopTime As Nullable(Of Date), ByVal packers As Nullable(Of Single)) As Boolean

        Dim production As SPG.ProductionDataTable = New SPG.ProductionDataTable
        Dim productionRecord As SPG.ProductionRow = production.NewProductionRow()

        productionRecord.ProdMainID = productionID
        productionRecord.ProdMainDate = CDate(Format(productiondate, "D"))
        productionRecord.ProdMainShift = shift.Value
        productionRecord.ProdMainItemID = item.Value
        productionRecord.ProdMainQuantity = quantity.Value
        productionRecord.ProdMainMachineLine = machine.Value
        productionRecord.ProdMainTimeStart = startTime.Value
        productionRecord.ProdMainTimeStop = stopTime.Value
        If Not packers.HasValue Then
            productionRecord.ProdMainPackers = 0
        Else
            productionRecord.ProdMainPackers = packers.Value
        End If
        productionRecord.strEnteredBy = My.Settings.UserName
        productionRecord.dtmEnteredOn = Now

        production.AddProductionRow(productionRecord)
        Dim rowsAffected As Integer = Adapter.Update(production)

        Return rowsAffected = 1

    End Function

    Public Function GetNewProductionID() As Integer

        Dim conn As SqlClient.SqlConnection = New SqlClient.SqlConnection(My.Settings.UserConnectionString)
        Dim myCommand As New SqlClient.SqlCommand("dbo.spNewIDSafe", conn)
        Dim myNewID As New SqlClient.SqlParameter("@nRetVal", SqlDbType.Int)
        myCommand.CommandType = CommandType.StoredProcedure
        myNewID.Direction = ParameterDirection.Output
        myCommand.Parameters.AddWithValue("@cName", "tblProdMain")
        myCommand.Parameters.AddWithValue("@cPkField", "ProdMainID")
        myCommand.Parameters.Add(myNewID)

        conn.Open()
        myCommand.ExecuteNonQuery()

        Return CType(myNewID.Value, Integer)

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetProductionView(ByVal fromDate As Nullable(Of Date), ByVal toDate As Nullable(Of Date), ByVal customer As Nullable(Of Integer), _
            ByVal shift As Nullable(Of Integer), ByVal machine As Nullable(Of Integer), ByVal item As Nullable(Of Integer)) As SPG.ProductionDataTable

        Return Adapter.GetProductionView(fromDate, toDate, customer, shift, machine, item)

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetProductionByShift(ByVal shift As Nullable(Of Integer)) As SPG.ProductionDataTable

        Return Adapter.GetProductionView(Nothing, Nothing, Nothing, shift, Nothing, Nothing)

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetProductionReport(ByVal fromDate As Nullable(Of Date), ByVal toDate As Nullable(Of Date), ByVal customer As Nullable(Of Integer), _
            ByVal shift As Nullable(Of Integer), ByVal machine As Nullable(Of Integer), ByVal items As String, ByVal inactiveItems As Boolean?, ByVal inactiveCustomers As Boolean?) As SPG.ProductionDataTable

        If inactiveCustomers.Value = True Then
            inactiveCustomers = Nothing
        End If

        If inactiveItems.Value = True Then
            inactiveItems = Nothing
        End If

        If String.IsNullOrEmpty(items) Then
            Return Adapter.GetProductionReport(fromDate, toDate, customer, shift, machine, inactiveItems, inactiveCustomers)
        End If

        Return Adapter.GetProductionReportByItems(fromDate, toDate, customer, shift, machine, inactiveCustomers, items)

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, True)> _
    Public Function DeleteProduction(ByVal id As Integer, ByVal mySession As Session) As Boolean

        Dim production = mySession.GetObjectByKey(Of Production)(id)

        If production IsNot Nothing Then
            production.Delete
        End If

        Return True
         
    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetProductionByID(ByVal productionID As Integer) As SPG.ProductionDataTable

        Return Adapter.GetProductionByID(productionID)

    End Function

End Class
