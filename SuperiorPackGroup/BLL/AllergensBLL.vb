Imports SuperiorPackGroup.SPGTableAdapters
Imports System.Text
Imports DevExpress.Xpo
Imports DXDAL.SPGData
Imports DevExpress.Persistent.Base

<ComponentModel.DataObject()>
Public Class AllergensBLL
    Public Function GetAllergens(ByRef session As Session) As XPView

        Return New XPView(session, GetType(Allergen))

    End Function

    Private Sub UpdateAuditTrail(ByVal ModifiedRecord As Allergen, ByVal originalRecord As Allergen)

        'Dim builder As New StringBuilder(String.Empty)
        'Dim recordFields As Integer = (ModifiedRecord.ItemArray.Length - 1)
        'Dim i As Integer = 0
        'Do While (i <= recordFields)
        '    Try
        '        If IsDBNull(originalRecord(i)) Then
        '            If Not IsDBNull(ModifiedRecord.Item(i)) Then
        '                builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, "NULL", ModifiedRecord.Item(i)))
        '            End If
        '        ElseIf IsDBNull(ModifiedRecord.Item(i)) Then
        '            If Not IsDBNull(originalRecord(i)) Then
        '                builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, originalRecord(i), "NULL"))
        '            End If
        '        ElseIf ModifiedRecord.Item(i) IsNot originalRecord(i) Then
        '            builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, originalRecord(i), ModifiedRecord.Item(i)))
        '        End If
        '    Catch
        '    End Try
        '    i += 1
        'Loop
        'If (builder.Length > 2) Then
        '    builder.Length = (builder.Length - 2)
        '    AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(ModifiedRecord.Item(0), Integer), "MachineLines", builder.ToString)
        'End If

    End Sub

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Update, True)>
    Public Function UpdateAllergen(ByVal session As Session, ByVal id As Integer?, ByVal name As String) As Boolean

        Dim Allergen As Allergen = session.GetObjectByKey(Of Allergen)(id.Value)

        If Allergen IsNot Nothing Then
            'It is a new Product
            Return Me.InsertAllergen(session, name)
        End If

        If String.IsNullOrEmpty(name) Then
            Throw New ApplicationException("You must provide Allergen.")
        End If

        Dim originalRecord As Allergen = Nothing
        Dim cloner As New Cloner
        originalRecord = CType(cloner.CloneTo(Allergen, GetType(Allergen)), Allergen)

        Allergen.AllergenName = name

        If Not IsNothing(originalRecord) Then
            Me.UpdateAuditTrail(Allergen, originalRecord)
        End If

        Allergen.Save()

        Return True

    End Function

    Public Function InsertAllergen(ByVal session As Session, ByVal name As String) As Boolean

        Dim Allergen As Allergen = New Allergen(session)

        If String.IsNullOrEmpty(name) Then
            Throw New ApplicationException("You must provide Allergen.")
        End If

        Allergen.AllergenName = name

        Allergen.Save()

        Return True

    End Function

    Public Function DeleteAllergens(ByVal session As Session, ByVal id As Integer) As Boolean

        Dim Allergen As Allergen = session.GetObjectByKey(Of Allergen)(id)

        If Allergen IsNot Nothing Then
            'If New ProductionBLL().GetProductionByMachine(id).Count <> 0 Then
            'MessageBox.Show("You can't delete this Allergen there are other records associated to it")
            'Return False
            'End If
            session.Delete(Allergen)
        End If

        Return True

    End Function

End Class
