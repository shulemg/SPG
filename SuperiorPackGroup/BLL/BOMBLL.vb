Imports SuperiorPackGroup.SPGTableAdapters
Imports System.Text
Imports DevExpress.Xpo
Imports DXDAL.SPGData
Imports DevExpress.Data.Filtering

<System.ComponentModel.DataObject()> _
Public Class BOMBLL

    Private m_BOMTableAdapter As BOMTableAdapter = Nothing
    Public ReadOnly Property Adapter() As BOMTableAdapter

        Get
            If m_BOMTableAdapter Is Nothing Then
                m_BOMTableAdapter = New BOMTableAdapter()
                m_BOMTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return m_BOMTableAdapter
        End Get

    End Property

    Private Sub UpdateAuditTrail(ByVal ModifiedRecord As SPG.BOMRow, ByVal originalRecord As Object())

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
            AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(ModifiedRecord.Item(0), Integer), "BOM", builder.ToString)
        End If

    End Sub

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetBOMBYFGItemID(ByVal itemID As Integer) As SPG.BOMDataTable

        Return Adapter.GetBOMByFGItemID(itemID)

    End Function

    Public Shared Function GetBOMByFGItemID(ByVal session As Session, ByVal itemID As Integer) As XPCollection(Of BOMs)

        Return New XPCollection(Of BOMs)(session, New BinaryOperator(BOMs.Fields.BOMFiniGoodID.ItemID.PropertyName, itemID, BinaryOperatorType.Equal))

    End Function

    Public Function GetBOMBYFGItemIDString(ByVal itemID As Integer) As String

        Dim itemBoms As StringBuilder = New StringBuilder(String.Empty)

        For Each item As SPG.BOMRow In Adapter.GetBOMByFGItemID(itemID)
            itemBoms.Append(String.Format("{0}; ", item.BOMRawMatCode))
        Next
        If itemBoms.Length > 2 Then
            itemBoms.Length -= 2
        End If

        Return itemBoms.ToString

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetBOMBYBomID(ByVal bomID As Integer) As SPG.BOMDataTable

        Return Adapter.GetBomByBomID(bomID)

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateBOM(ByVal bomID As Nullable(Of Integer), ByVal bomRawMatID As Nullable(Of Integer), ByVal bomFiniGoodID As Nullable(Of Integer), _
            ByVal bomQuantity As Nullable(Of Single), ByVal scrapFactor As Nullable(Of Double)) As Boolean

        Dim boms As SPG.BOMDataTable = Adapter.GetBomByBomID(bomID.Value)

        Dim str As StringBuilder = New StringBuilder(String.Empty)

        If bomRawMatID.HasValue = False Then
            str.Append("a RM ID, ")
        End If

        If bomQuantity.HasValue = False OrElse bomQuantity.Value = 0 Then
            str.Append("the Quantity Needed, ")
        End If

        If str.Length > 0 Then
            Throw New ApplicationException(String.Format("You must provide {0}.", str.ToString.Substring(0, str.Length - 2)))
        End If

        If boms.Count = 0 Then
            'It is a new Product
            Return Me.InsertBOM(bomRawMatID, bomFiniGoodID, bomQuantity, scrapFactor)
        End If

        Dim bom As SPG.BOMRow = boms(0)

        Dim originalRecord As Object() = bom.ItemArray

        bom.BOMRawMatID = bomRawMatID.Value
        bom.BOMFiniGoodID = bomFiniGoodID.Value
        bom.BOMQuantity = bomQuantity.Value
        If scrapFactor.HasValue Then
            bom.ScrapFactor = scrapFactor.Value
        Else
            bom.SetScrapFactorNull()
        End If

        If Not IsNothing(originalRecord) Then
            Me.UpdateAuditTrail(bom, originalRecord)
        End If

        Dim rowsAffected As Integer = Adapter.Update(bom)

        Return rowsAffected = 1

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, True)> _
    Public Function InsertBOM(ByVal bomRawMatID As Nullable(Of Integer), ByVal bomFiniGoodID As Nullable(Of Integer), _
            ByVal bomQuantity As Nullable(Of Single), ByVal scrapFactor As Nullable(Of Double)) As Boolean

        Dim boms As SPG.BOMDataTable = New SPG.BOMDataTable
        Dim bom As SPG.BOMRow = boms.NewBOMRow()

        bom.BOMRawMatID = bomRawMatID.Value
        bom.BOMFiniGoodID = bomFiniGoodID.Value
        bom.BOMQuantity = bomQuantity.Value
        If scrapFactor.HasValue Then
            bom.ScrapFactor = scrapFactor.Value
        Else
            bom.SetScrapFactorNull()
        End If

        boms.AddBOMRow(bom)
        Dim rowsAffected As Integer = Adapter.Update(boms)

        Return rowsAffected = 1

    End Function

    Public Function DeleteBOMByFGItemID(ByVal FGItemID As Integer) As Boolean

        Dim boms As SPG.BOMDataTable = Adapter.GetBOMByFGItemID(FGItemID)
        Dim rowsAffected As Integer

        If boms.Count > 0 Then
            rowsAffected = Adapter.DeleteBOMByFGItemID(FGItemID)
        Else
            rowsAffected = 0
        End If

        Return Convert.ToBoolean(rowsAffected)

    End Function

    Public Function DeleteBOM(ByVal BOMID As Integer) As Boolean

        Dim bom As SPG.BOMRow = Adapter.GetBomByBomID(BOMID)(0)
        If Not bom Is Nothing Then
            Return Adapter.Delete(BOMID, bom.ts) = 1
        End If

        Return False

    End Function

End Class
