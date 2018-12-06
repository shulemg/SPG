Imports SuperiorPackGroup.SPGTableAdapters
Imports System.Text
Imports DevExpress.Xpo
Imports DXDAL.SPGData
Imports DevExpress.Data.Filtering

<ComponentModel.DataObject()> _
Public Class InventoryBOMsBLL

    Private m_InventoryBOMsTableAdapter As InventoryBOMsTableAdapter = Nothing
    Public ReadOnly Property Adapter() As InventoryBOMsTableAdapter

        Get
            If m_InventoryBOMsTableAdapter Is Nothing Then
                m_InventoryBOMsTableAdapter = New InventoryBOMsTableAdapter()
                m_InventoryBOMsTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return m_InventoryBOMsTableAdapter
        End Get

    End Property

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetInventoryBOMsBYInventoryID(ByVal inventoryID As Integer) As SPG.InventoryBOMsDataTable

        Return Adapter.GetInventoryBOMByInventoryID(inventoryID)

    End Function

    Public Shared Function GetInventoryBOMsByInventoryID(ByVal session As Session, ByVal inventoryID As Integer) As XPCollection(Of InventoryBOMs)

        Return New XPCollection(Of InventoryBOMs)(session, New BinaryOperator(InventoryBOMs.Fields.InventoryBOMInventoryID.InventoryID.PropertyName, inventoryID, BinaryOperatorType.Equal))

    End Function

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetInventoryBOMsBYID(ByVal InventoryBOMsID As Integer) As SPG.InventoryBOMsDataTable

        Return Adapter.GetInventoryBOMByID(InventoryBOMsID)

    End Function

    Private Shared Sub SetInventoryBOMFields(ByVal InventoryBOMsRawMatID As Integer?, ByVal InventoryBOMsInventoryID As Integer?, ByVal InventoryBOMsQuantity As Single?, _
                                             ByVal scrapFactor As Double?, ByVal inventoryBOM As SPG.InventoryBOMsRow)

        inventoryBOM.InventoryBOMRawMatID = InventoryBOMsRawMatID.Value
        inventoryBOM.InventoryBOMInventoryID = InventoryBOMsInventoryID.Value
        inventoryBOM.InventoryBOMQuantity = InventoryBOMsQuantity.Value
        If scrapFactor.HasValue Then
            inventoryBOM.ScrapFactor = scrapFactor.Value
        Else
            inventoryBOM.SetScrapFactorNull()
        End If

    End Sub

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateInventoryBOM(ByVal InventoryBOMsID As Integer?, ByVal InventoryBOMsRawMatID As Integer?, ByVal InventoryBOMsInventoryID As Integer?, _
                                    ByVal InventoryBOMsQuantity As Single?, ByVal scrapFactor As Double?) As Boolean

        Dim inventoryBOMs As SPG.InventoryBOMsDataTable = Adapter.GetInventoryBOMByID(InventoryBOMsID.Value)

        If Not InventoryBOMsRawMatID.HasValue Then
            Throw New ApplicationException("You must provide a RM ID.")
        End If

        If Not InventoryBOMsQuantity.HasValue Or InventoryBOMsQuantity.Value = 0 Then
            Throw New ApplicationException("You must provide the Quantity Used.")
        End If

        If inventoryBOMs.Count = 0 Then
            'It is a new Product
            Return Me.InsertInventoryBOM(InventoryBOMsRawMatID, InventoryBOMsInventoryID, InventoryBOMsQuantity, scrapFactor)
        End If

        Dim inventoryBOM As SPG.InventoryBOMsRow = inventoryBOMs(0)

        Dim originalRecord As Object() = Nothing
        originalRecord = inventoryBOM.ItemArray

        SetInventoryBOMFields(InventoryBOMsRawMatID, InventoryBOMsInventoryID, InventoryBOMsQuantity, scrapFactor, inventoryBOM)

        If Not IsNothing(originalRecord) Then
            Me.UpdateAuditTrail(inventoryBOM, originalRecord)
        End If

        Dim rowsAffected As Integer = Adapter.Update(inventoryBOM)

        Return rowsAffected = 1

    End Function

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Insert, True)> _
    Public Function InsertInventoryBOM(ByVal InventoryBOMsRawMatID As Integer?, ByVal InventoryBOMsInventoryID As Integer?, ByVal InventoryBOMsQuantity As Single?, _
                                       ByVal scrapFactor As Double?) As Boolean

        Dim inventoryBOMs As SPG.InventoryBOMsDataTable = New SPG.InventoryBOMsDataTable
        Dim inventoryBOM As SPG.InventoryBOMsRow = inventoryBOMs.NewInventoryBOMsRow()

        SetInventoryBOMFields(InventoryBOMsRawMatID, InventoryBOMsInventoryID, InventoryBOMsQuantity, scrapFactor, inventoryBOM)

        inventoryBOMs.AddInventoryBOMsRow(inventoryBOM)
        Dim rowsAffected As Integer = Adapter.Update(inventoryBOMs)

        Return rowsAffected = 1

    End Function

    Private Sub UpdateAuditTrail(ByVal ModifiedRecord As SPG.InventoryBOMsRow, ByVal originalRecord As Object())

        Dim builder As New StringBuilder(String.Empty)
        Dim recordFields As Integer = (ModifiedRecord.ItemArray.Length - 1)
        Dim i As Integer = 0
        Do While (i <= recordFields)
            Try
                If IsDBNull(originalRecord(i)) Then
                    If Not IsDBNull(ModifiedRecord.Item(i)) Then
                        builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, "NULL", ModifiedRecord.Item(i)))
                    End If
                ElseIf IsDBNull(ModifiedRecord.Item(i)) Then
                    If Not IsDBNull(originalRecord(i)) Then
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
            AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(ModifiedRecord.Item(0), Integer), "InventoryBOM", builder.ToString)
        End If

    End Sub

    Public Function AddInventoryBOMByItemID(ByVal itemID As Integer, ByVal inventoryID As Integer) As Boolean

        Return Convert.ToBoolean(Adapter.AddInventoryBOMByItemID(itemID, inventoryID))

    End Function

    Public Shared Sub AddInventoryBOMByItemID(ByVal session As Session, ByVal itemID As Integer, ByVal inventoryID As Inventory)

        Dim inventoryBom As InventoryBOMs
        Using itemBom As New XPCollection(Of BOMs)(session, New BinaryOperator(BOMs.Fields.BOMFiniGoodID.ItemID.PropertyName, itemID, BinaryOperatorType.Equal))
            For Each bomItem As BOMs In itemBom
                inventoryBom = New InventoryBOMs(session) With {.InventoryBOMRawMatID = bomItem.BOMRawMatID, .InventoryBOMInventoryID = inventoryID, .InventoryBOMQuantity = bomItem.BOMQuantity,
                                                                .ScrapFactor = bomItem.ScrapFactor / 100}
                inventoryBom.Save()
            Next
        End Using

    End Sub

    Public Function DeleteInventoryBOMByInventoryID(ByVal inventoryID As Integer) As Boolean

        Return Convert.ToBoolean(Adapter.DeleteInventoryBOMByInventoryID(inventoryID))

    End Function

    Public Shared Sub DeleteInventoryBOMByInventoryID(ByVal session As Session, ByVal inventoryID As Integer)

        session.Delete(New XPCollection(Of InventoryBOMs)(session, New BinaryOperator(InventoryBOMs.Fields.InventoryBOMInventoryID.InventoryID.PropertyName, inventoryID, BinaryOperatorType.Equal)))

    End Sub

End Class
