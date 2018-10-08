Imports DevExpress.Xpo
Imports DXDAL.SPGData

Public Class LotCodeValidator

    Public Shared Function ValidateByItem(ByVal item As Items, ByVal lot As String, ByVal ValidateFormat As Boolean) As Boolean
        Dim sortCollection As SortingCollection = New SortingCollection()
        Dim codeSection As LotCodeFormatSections
        Dim sectionSettings As LotCodeSectionSettings
        Dim sectionValue As String, sectionValueNum As Integer, valuePosition As Integer = 0

        If Not item.RequiresLotCodes Then Return True

        If IsNothing(lot) OrElse lot = "" Then Return False

        If Not ValidateFormat Then Return True

        If item.DefaultLotCodeFormat Is Nothing Then Return True

        sortCollection.Add(New SortProperty("SectionPosition", DB.SortingDirection.Ascending))
        item.DefaultLotCodeFormat.FormatSections.Sorting = sortCollection

        For Each codeSection In item.DefaultLotCodeFormat.FormatSections

            If lot.Length < valuePosition + codeSection.SectionLength Then
                Return False
            End If

            sectionValue = Mid(lot, valuePosition + 1, codeSection.SectionLength)

            For Each sectionSettings In codeSection.SectionSettings
                If sectionSettings.SettingName = "NumberRangeFrom" Then
                    If Not Integer.TryParse(sectionValue, sectionValueNum) OrElse sectionValueNum < CInt(sectionSettings.SettingValue) Then Return False
                End If
                If sectionSettings.SettingName = "NumberRangeTo" Then
                    If Not Integer.TryParse(sectionValue, sectionValueNum) OrElse sectionValueNum > CInt(sectionSettings.SettingValue) Then Return False
                End If
            Next

            valuePosition += codeSection.SectionLength

        Next

        Return True
    End Function

End Class
