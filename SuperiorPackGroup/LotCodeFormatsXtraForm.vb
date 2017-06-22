Imports System.Linq
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DXDAL
Imports DXDAL.SPGData

Public Class LotCodeFormatsXtraForm

    Private m_CurrentLotCodeFormat As LotCodeFormats
    Private m_CurrentLotCodeSection As LotCodeFormatSections
    Private m_CurrentLotCodeSectionSettings As LotCodeSectionSettings
    Private m_LotCodeSession As Session

    Private Sub cancelFormatChangesSimpleButton_Click(sender As Object, e As EventArgs) Handles cancelFormatChangesSimpleButton.Click

        If cancelFormatChangesSimpleButton.Tag.ToString() = "New Format" AndAlso MessageBox.Show("Do you want to delete the new Lot Code Format?", "Cancel New Format", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        CancelFormatChanges()
        CheckPermissions()

        lotCodeFormatSectionsXpCollection.Reload 
        lotCodeFormatSectionsGridControl.Refresh 
        lotCodeFormatSectionsGridControl.Enabled = True

        cancelFormatChangesSimpleButton.Enabled = False
        saveFormatSimpleButton.Enabled = False

    End Sub

    Private Sub cancelSettingsChangesSimpleButton_Click(sender As Object, e As EventArgs) Handles cancelSettingsChangesSimpleButton.Click

        CancelSettingChanges()
        CheckPermissions()

        lotCodeFormatSectionsGridControl.Enabled = True
        Utilities.MakeFormReadOnly(sectionSettingsPanelControl, True)
        sectionPositionSpinEdit.ReadOnly  = False

        cancelSettingsChangesSimpleButton.Enabled = False
        saveSettingsSimpleButton.Enabled = False

    End Sub

    Private Sub changePositionSimpleButton_Click(sender As Object, e As EventArgs) Handles changePositionSimpleButton.Click

        sectionPositionSpinEdit.Tag = "Changing Position"
        sectionPositionSpinEdit.ReadOnly = False

    End Sub

    Private Sub deleteFormatSimpleButton_Click(sender As Object, e As EventArgs) Handles deleteFormatSimpleButton.Click

        Dim continueDelete As DialogResult
        If m_CurrentLotCodeFormat Is Nothing Then
            Exit Sub
        End If
        If (From customersFormat In m_LotCodeSession.Query(Of Customers)()
            Where customersFormat.DefaultLotCodeFormat.Oid = m_CurrentLotCodeFormat.Oid
            Select customersFormat.CustomerID).Any() OrElse (From itemsFormat In m_LotCodeSession.Query(Of Items)()
                                                             Where itemsFormat.DefaultLotCodeFormat.Oid = m_CurrentLotCodeFormat.Oid
                                                             Select itemsFormat.ItemID).Any() Then
            continueDelete = MessageBox.Show("This Lot Code Format is used as a default format, are you sure you want to delete this Lot Code Format?", "Delete Lot Code Format", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)
        Else
            continueDelete = MessageBox.Show("Are you sure you want to delete this Lot Code Format?", "Delete Lot Code Format", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)
        End If

        If continueDelete = DialogResult.No Then
            Exit Sub
        End If

        m_CurrentLotCodeFormat.Delete

        If m_CurrentLotCodeFormat.IsDeleted Then
            m_CurrentLotCodeFormat = Nothing
            m_CurrentLotCodeSectionSettings = Nothing
            sectionSettingsPanelControl.Enabled = False
            lotCodeFormatPreviewGroupControl.Enabled = False
            formatNameTextEdit.EditValue = Nothing
            formatSectionsSpinEdit.EditValue = 1
            formatWarningLabelControl.Visible = False
            PrepareNewLotCodeSection(Nothing)

            CheckPermissions()
            lotCodeFormatSectionsXpCollection.Reload

            sectionSettingsPanelControl.Enabled = False
            lotCodeFormatPreviewGroupControl.Enabled = False
            cancelFormatChangesSimpleButton.Enabled = False
            saveFormatSimpleButton.Enabled = False
        Else
            MessageBox.Show("The Lot Code Format was not deleted.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub deleteSettingsSimpleButton_Click(sender As Object, e As EventArgs) Handles deleteSettingsSimpleButton.Click

        Dim removeSection As Boolean = False
        Dim laterSections As IQueryable(Of LotCodeFormatSections) = From LaterSection In m_LotCodeSession.Query(Of LotCodeFormatSections)()
                                                                    Where LaterSection.LotCodeFormat.Oid = m_CurrentLotCodeFormat.Oid AndAlso LaterSection.SectionPosition >= sectionPositionSpinEdit.Value
                                                                    Select LaterSection

        If MessageBox.Show("Are you sure you want to delete the settings for this Section?", "Delete Section Settings", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = DialogResult.No Then
            Exit Sub
        Else
            If deleteSettingsSimpleButton.Tag.ToString() <> "RemoveSection" Then
                If MessageBox.Show("Do you want to remove the section?", "Remove Section", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    removeSection = True
                End If
            Else
                removeSection = True
            End If
        End If


        If removeSection Then
            m_CurrentLotCodeSection.Delete
            If m_CurrentLotCodeSection.IsDeleted Then
                For Each CodeSection As LotCodeFormatSections In laterSections
                    CodeSection.SectionPosition -= 1
                    CodeSection.Save
                Next
                If laterSections.Count > 0 Then
                    PrepareNewLotCodeSection(CType(sectionPositionSpinEdit.Value, Integer?))
                ElseIf sectionPositionSpinEdit.Value > 1 Then
                    PrepareNewLotCodeSection(CType(sectionPositionSpinEdit.Value - 1, Integer?))
                Else
                    PrepareNewLotCodeSection(1)
                End If
                MessageBox.Show("The section was successfully removed.")
            Else
                MessageBox.Show("The section was not deleted", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            PrepareNewLotCodeSection(CType(sectionPositionSpinEdit.Value, Integer?))
        End If

        lotCodeFormatSectionsGridControl.Enabled = True
        Utilities.MakeFormReadOnly(sectionSettingsPanelControl, True)
        sectionPositionSpinEdit.ReadOnly  = False

        cancelSettingsChangesSimpleButton.Enabled = False
        saveSettingsSimpleButton.Enabled = False

    End Sub

    Private Sub editLotCodeFormatSimpleButton_Click(sender As Object, e As EventArgs) Handles editLotCodeFormatSimpleButton.Click

        If m_CurrentLotCodeFormat Is Nothing Then
            If lotCodeFormatSectionsGridView.IsValidRowHandle(lotCodeFormatSectionsGridView.FocusedRowHandle) Then
                BindLotCodeFormat(CType(lotCodeFormatSectionsGridView.GetFocusedRowCellValue(lotCodeFormatIDGridColumn), Integer))
            Else
                MessageBox.Show("Please select a code format to edit.")
                Exit Sub
            End If            
        End If

        cancelFormatChangesSimpleButton.Tag = "Editing Format"
        sectionSettingsPanelControl.Enabled = True
        formatNameTextEdit.ReadOnly  = False
        formatSectionsSpinEdit.ReadOnly = False
        Utilities.MakeFormReadOnly(sectionSettingsPanelControl, True)
        sectionPositionSpinEdit.ReadOnly = False
        lotCodeFormatSectionsGridControl.Enabled = False

        CheckPermissions()
        cancelFormatChangesSimpleButton.Enabled = True
        saveFormatSimpleButton.Enabled = True
        editLotCodeFormatSimpleButton.Enabled = False
        newLotCodeFormatSimpleButton.Enabled = False

    End Sub

    Private Sub editSettingsSimpleButton_Click(sender As Object, e As EventArgs) Handles editSettingsSimpleButton.Click

        If m_CurrentLotCodeSection Is Nothing Then
            If sectionLengthSpinEdit.EditValue Is Nothing Then
                MessageBox.Show("Please select a format section to edit.")
                Exit Sub
            Else
                PrepareNewLotCodeSection(CType(sectionPositionSpinEdit.Value, Integer?))
            End If
        End If

        sectionPositionSpinEdit.Tag = "Editing Position"
        lotCodeFormatSectionsGridControl.Enabled = False
        Utilities.MakeFormReadOnly(sectionSettingsPanelControl, False)
        sectionPositionSpinEdit.ReadOnly  = True

        CheckPermissions()
        cancelSettingsChangesSimpleButton.Enabled = True
        saveSettingsSimpleButton.Enabled = True
        editSettingsSimpleButton.Enabled = False

    End Sub

    Private Sub LotCodeFormatsXtraForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If lotCodeFormatSectionsGridControl.Enabled = False Then
            Select Case MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                Case System.Windows.Forms.DialogResult.Cancel
                    e.Cancel = True
                Case System.Windows.Forms.DialogResult.Yes
                    If saveFormatSimpleButton.Enabled Then
                        if SaveLotCodeFormat() = False Then 
                            e.Cancel =True
                        End If
                    Else
                        if SaveSectionSettings() Then
                            e.Cancel = True
                        End If
                    End If
                Case System.Windows.Forms.DialogResult.No
                    If cancelFormatChangesSimpleButton.Enabled Then
                        CancelFormatChanges()
                    Else
                        CancelSettingChanges()
                    End If
            End Select
        End If

        If e.Cancel = False Then
            m_LotCodeSession.PurgeDeletedObjects
        End If

    End Sub

    Private Sub LotCodeFormatsXtraForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cursor = Cursors.WaitCursor

        CheckPermissions
        m_LotCodeSession = New Session(SPGDataLayer)
        lotCodeFormatSectionsXpCollection.Session = m_LotCodeSession
        lotCodeFormatSectionsXpCollection.Reload()

        sectionTypeImageComboBoxEdit.Properties.Items.AddEnum(Of LotCodeSectionType)()
        firstWeekOfYearImageComboBoxEdit.Properties.Items.AddEnum(Of FirstWeekOfYear)()
        firstDayOfWeekImageComboBoxEdit.Properties.Items.AddEnum(Of FirstDayOfWeek)()

        sectionSettingsPanelControl.Enabled = False
        lotCodeFormatPreviewGroupControl.Enabled = False
        formatNameTextEdit.ReadOnly = True
        formatSectionsSpinEdit.ReadOnly = True
        formatWarningLabelControl.Visible = False
        PrepareNewLotCodeSection(Nothing)

        CheckPermissions()
        cancelFormatChangesSimpleButton.Enabled = False
        saveFormatSimpleButton.Enabled = False
        editLotCodeFormatSimpleButton.Enabled = True
        newLotCodeFormatSimpleButton.Enabled = True
        lotCodeFormatSectionsGridControl.Enabled = True

        Cursor = Cursors.Default

    End Sub

    Private Sub newLotCodeFormatSimpleButton_Click(sender As Object, e As EventArgs) Handles newLotCodeFormatSimpleButton.Click

        m_CurrentLotCodeFormat = New LotCodeFormats(m_LotCodeSession)
        cancelFormatChangesSimpleButton.Tag = "New Format"
        m_CurrentLotCodeSection = Nothing
        m_CurrentLotCodeSectionSettings = Nothing

        sectionSettingsPanelControl.Enabled = False
        lotCodeFormatPreviewGroupControl.Enabled = False
        formatNameTextEdit.EditValue = Nothing
        formatSectionsSpinEdit.EditValue = 1
        formatWarningLabelControl.Visible = False
        formatNameTextEdit.ReadOnly = False
        
        formatsectionsSpinEdit.ReadOnly = False
        PrepareNewLotCodeSection(Nothing)

        CheckPermissions()
        cancelFormatChangesSimpleButton.Enabled = True
        saveFormatSimpleButton.Enabled = True
        editLotCodeFormatSimpleButton.Enabled = False
        newLotCodeFormatSimpleButton.Enabled = False
        lotCodeFormatSectionsGridControl.Enabled = False

    End Sub

    Private Sub saveFormatSimpleButton_Click(sender As Object, e As EventArgs) Handles saveFormatSimpleButton.Click

        If ValidateCodeFormatRecord() Then
            Try
                If SaveLotCodeFormat() Then
                    sectionSettingsPanelControl.Enabled = True
                    lotCodeFormatPreviewGroupControl.Enabled = True
                    formatNameTextEdit.ReadOnly = True
                    formatSectionsSpinEdit.ReadOnly = True

                    CheckPermissions()
                    cancelFormatChangesSimpleButton.Enabled = False
                    saveFormatSimpleButton.Enabled = False

                    'Dim SavedSectionSettings = Aggregate SavedSettings In m_LotCodeSession.Query(Of LotCodeFormatSections)
                    '                           Where SavedSettings.LotCodeFormat.Oid = m_CurrentLotCodeFormat.Oid                                               
                    '                           Into SavedSettingsCount = Count(), MaxPosition = Max(SavedSettings.SectionPosition)




                    Dim SavedSettingsCount = m_LotCodeSession.Query(Of LotCodeFormatSections).Where(Function(S) S.LotCodeFormat.Oid = m_CurrentLotCodeFormat.Oid).Count()
                    Dim MaxSavedPosition = If(SavedSettingsCount > 0, m_LotCodeSession.Query(Of LotCodeFormatSections).Where(Function(S) S.LotCodeFormat.Oid = m_CurrentLotCodeFormat.Oid).Max(Function(S) S.SectionPosition), 0)

                    If SavedSettingsCount < formatSectionsSpinEdit.Value Then                        
                        formatWarningLabelControl.Text = "Missing Section Settings"
                        formatWarningLabelControl.Visible = True
                        PrepareNewLotCodeSection(1)
                        deleteSettingsSimpleButton.Tag = String.Empty 
                    Else If SavedSettingsCount > formatSectionsSpinEdit.Value OrElse MaxSavedPosition > SavedSettingsCount Then
                        formatWarningLabelControl.Text = "Excess Section Settings"
                        formatWarningLabelControl.Visible = True
                        PrepareNewLotCodeSection(MaxSavedPosition)
                        deleteSettingsSimpleButton.Tag = "RemoveSection"
                    Else
                        lotCodeFormatSectionsGridControl.Enabled = True
                        formatWarningLabelControl.Visible = False
                        deleteSettingsSimpleButton.Tag = String.Empty 
                    End If

                    lotCodeFormatSectionsXpCollection.Reload()
                    cancelFormatChangesSimpleButton.Tag = String.Empty 
                Else
                    MessageBox.Show("There was an error while trying to save the current record, no changes were saved.")
                End If
            Catch ex As Exception
                MessageBox.Show(String.Format("There was an error while trying to save the current record.{0}{1}", vbCrLf, ex.Message))
            End Try
        End If

    End Sub

    Private Sub saveSettingsSimpleButton_Click(sender As Object, e As EventArgs) Handles saveSettingsSimpleButton.Click

        If ValidateSectionSettingsRecord() Then
            Try
                If SaveSectionSettings() Then
                    Utilities.MakeFormReadOnly(sectionSettingsPanelControl, True)
                    sectionPositionSpinEdit.ReadOnly = False

                    CheckPermissions()
                    cancelSettingsChangesSimpleButton.Enabled = False
                    saveSettingsSimpleButton.Enabled = False

                    Dim SavedSectionSettings = Aggregate SavedSettings In m_LotCodeSession.Query(Of LotCodeFormatSections)
                                               Where SavedSettings.LotCodeFormat.Oid = m_CurrentLotCodeFormat.Oid
                                               Into SavedSettingsCount = Count(), MaxPosition = Max(SavedSettings.SectionPosition)
                    If SavedSectionSettings.SavedSettingsCount = formatSectionsSpinEdit.Value AndAlso SavedSectionSettings.MaxPosition = SavedSectionSettings.SavedSettingsCount Then
                        lotCodeFormatSectionsGridControl.Enabled = True
                    End If

                    lotCodeFormatSectionsXpCollection.Reload()
                    sectionPositionSpinEdit.Tag = String.Empty 
                Else
                    MessageBox.Show("There was an error while trying to save the current record.")
                End If
            Catch ex As Exception
                 MessageBox.Show(String.Format("There was an error while trying to save the current record.{0}{1}", vbCrLf, ex.Message))
            End Try
        End If

    End Sub

    Private Sub sectionPositionSpinEdit_EditValueChanged(sender As Object, e As EventArgs) Handles sectionPositionSpinEdit.EditValueChanged

        If IsInitializing = False AndAlso (cancelFormatChangesSimpleButton.Tag is Nothing OrElse cancelFormatChangesSimpleButton.Tag.ToString <> "New Format") AndAlso
            (sectionPositionSpinEdit.Tag Is Nothing OrElse sectionPositionSpinEdit.Tag.ToString <> "Changing Position") Then
            PrepareNewLotCodeSection(CType(sectionPositionSpinEdit.Value, Integer?))
        End If

    End Sub

    Private Sub sectionTypeImageComboBoxEdit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sectionTypeImageComboBoxEdit.SelectedIndexChanged

        Select Case CType(sectionTypeImageComboBoxEdit.EditValue, LotCodeSectionType)
            Case LotCodeSectionType.YearText
                lettersToSkipTextEdit.Enabled = True
                lettersToReplaceTextEdit.Enabled = True
                replacementLettersTextEdit.Enabled = True
                firstMonthComboBoxEdit.Enabled = False
                firstYearTextEdit.Enabled = True
                firstWeekOfYearImageComboBoxEdit.Enabled = True
                firstDayOfWeekImageComboBoxEdit.Enabled = True
                restartsOnTextEdit.Enabled = True
                fromSpinEdit.Enabled = False
                toSpinEdit.Enabled = False
                Exit Select
            Case LotCodeSectionType.MonthText
                lettersToSkipTextEdit.Enabled = True
                lettersToReplaceTextEdit.Enabled = True
                replacementLettersTextEdit.Enabled = True
                firstMonthComboBoxEdit.Enabled = False
                firstYearTextEdit.Enabled = False
                firstWeekOfYearImageComboBoxEdit.Enabled = False
                firstDayOfWeekImageComboBoxEdit.Enabled = False
                restartsOnTextEdit.Enabled = False
                fromSpinEdit.Enabled = False
                toSpinEdit.Enabled = False
                Exit Select
            Case LotCodeSectionType.WeekOfYear
                lettersToSkipTextEdit.Enabled = False
                lettersToReplaceTextEdit.Enabled = False
                replacementLettersTextEdit.Enabled = False
                firstMonthComboBoxEdit.Enabled = False
                firstYearTextEdit.Enabled = False
                firstWeekOfYearImageComboBoxEdit.Enabled = True
                firstDayOfWeekImageComboBoxEdit.Enabled = False
                restartsOnTextEdit.Enabled = False
                fromSpinEdit.Enabled = False
                toSpinEdit.Enabled = False
                Exit Select
            Case LotCodeSectionType.DayOfWeekText
                lettersToSkipTextEdit.Enabled = False
                lettersToReplaceTextEdit.Enabled = False
                replacementLettersTextEdit.Enabled = False
                firstMonthComboBoxEdit.Enabled = False
                firstYearTextEdit.Enabled = False
                firstWeekOfYearImageComboBoxEdit.Enabled = False
                firstDayOfWeekImageComboBoxEdit.Enabled = True
                restartsOnTextEdit.Enabled = False
                fromSpinEdit.Enabled = False
                toSpinEdit.Enabled = False
                Exit Select
            Case LotCodeSectionType.DayOfWeekNumber
                lettersToSkipTextEdit.Enabled = False
                lettersToReplaceTextEdit.Enabled = False
                replacementLettersTextEdit.Enabled = False
                firstMonthComboBoxEdit.Enabled = False
                firstYearTextEdit.Enabled = False
                firstWeekOfYearImageComboBoxEdit.Enabled = False
                firstDayOfWeekImageComboBoxEdit.Enabled = True
                restartsOnTextEdit.Enabled = False
                fromSpinEdit.Enabled = False
                toSpinEdit.Enabled = False
                Exit Select
            Case LotCodeSectionType.MonthCustom
                lettersToSkipTextEdit.Enabled = False
                lettersToReplaceTextEdit.Enabled = False
                replacementLettersTextEdit.Enabled = False
                firstMonthComboBoxEdit.Enabled = True
                firstYearTextEdit.Enabled = True
                firstWeekOfYearImageComboBoxEdit.Enabled = False
                firstDayOfWeekImageComboBoxEdit.Enabled = False
                restartsOnTextEdit.Enabled = False
                fromSpinEdit.Enabled = True
                toSpinEdit.Enabled = True
                Exit Select
            Case LotCodeSectionType.DayOfMonthCustom
                lettersToSkipTextEdit.Enabled = True
                lettersToReplaceTextEdit.Enabled = True
                replacementLettersTextEdit.Enabled = True
                firstMonthComboBoxEdit.Enabled = False
                firstYearTextEdit.Enabled = False
                firstWeekOfYearImageComboBoxEdit.Enabled = False
                firstDayOfWeekImageComboBoxEdit.Enabled = False
                restartsOnTextEdit.Enabled = True
                fromSpinEdit.Enabled = False
                toSpinEdit.Enabled = False
                Exit Select
            Case Else
                lettersToSkipTextEdit.Enabled = False
                lettersToReplaceTextEdit.Enabled = False
                replacementLettersTextEdit.Enabled = False
                firstMonthComboBoxEdit.Enabled = False
                firstYearTextEdit.Enabled = False
                firstWeekOfYearImageComboBoxEdit.Enabled = False
                firstDayOfWeekImageComboBoxEdit.Enabled = False
                restartsOnTextEdit.Enabled = False
                fromSpinEdit.Enabled = False
                toSpinEdit.Enabled = False
                Exit Select
        End Select

    End Sub

    Private Sub BindLotCodeFormat(ByVal FormatID As Integer)

        m_LotCodeSession.DropIdentityMap()

        m_CurrentLotCodeFormat = m_LotCodeSession.GetObjectByKey(of LotCodeFormats)(FormatID, True)
        formatNameTextEdit.EditValue = m_CurrentLotCodeFormat.FormatName
        formatSectionsSpinEdit.EditValue = m_CurrentLotCodeFormat.Sections 
        formatWarningLabelControl.Visible = m_CurrentLotCodeFormat.FormatSections.Count = m_CurrentLotCodeFormat.Sections
        PrepareNewLotCodeSection(1)

    End Sub

    Private Sub BindLotCodeSectionFields(ByVal SectionID As Integer)

        m_CurrentLotCodeSection = m_LotCodeSession.GetObjectByKey(Of LotCodeFormatSections)(SectionID, True)
        sectionPositionSpinEdit.EditValue = m_CurrentLotCodeSection.SectionPosition 
        sectionPositionSpinEdit.ReadOnly = True
        sectionNameTextEdit.EditValue = m_CurrentLotCodeSection.SectionName
        sectionTypeImageComboBoxEdit.EditValue = m_CurrentLotCodeSection.SectionType
        sectionLengthSpinEdit.EditValue = m_CurrentLotCodeSection.SectionLength
        For Each sectionSetting As LotCodeSectionSettings In m_CurrentLotCodeSection.SectionSettings
            Select Case sectionSetting.SettingName
                Case "LettersToSkip"
                    lettersToSkipTextEdit.EditValue = sectionSetting.SettingValue
                Case "LettersToReplace"
                    lettersToReplaceTextEdit.EditValue = sectionSetting.SettingValue
                Case "ReplacementLetters"
                    replacementLettersTextEdit.EditValue = sectionSetting.SettingValue
                Case "FirstMonth"
                    firstMonthComboBoxEdit.EditValue = sectionSetting.SettingValue
                Case "FirstYear"
                    firstYearTextEdit.EditValue = sectionSetting.SettingValue
                Case "FirstWeekOfYear"
                    firstWeekOfYearImageComboBoxEdit.EditValue = sectionSetting.SettingValue
                Case "FirstDayOfWeek"
                    firstDayOfWeekImageComboBoxEdit.EditValue = sectionSetting.SettingValue
                Case "RestartsOnThe"
                    restartsOnTextEdit.EditValue = sectionSetting.SettingValue
                Case "NumberRangeFrom"
                    fromSpinEdit.EditValue = sectionSetting.SettingValue
                Case "NumberRangeTo"
                    toSpinEdit.EditValue = sectionSetting.SettingValue
                Case Else
                    'Unknown setting
                    Exit Select 
            End Select
        Next

    End Sub

    Private Sub CancelFormatChanges()

        If cancelFormatChangesSimpleButton.Tag.ToString = "New Format" Then
            If m_CurrentLotCodeFormat.Oid > 0 Then
                m_CurrentLotCodeFormat.Delete
            Else
                m_CurrentLotCodeFormat = Nothing
            End If
            m_CurrentLotCodeSection = Nothing
            m_CurrentLotCodeSectionSettings = Nothing
            sectionSettingsPanelControl.Enabled = False
            lotCodeFormatPreviewGroupControl.Enabled = False
            formatNameTextEdit.EditValue = Nothing
            formatSectionsSpinEdit.EditValue = 1
            formatWarningLabelControl.Visible = False
            PrepareNewLotCodeSection(Nothing)
        Else
            BindLotCodeFormat(m_CurrentLotCodeFormat.Oid)
        End If

    End Sub

    Private Sub CancelSettingChanges()

        PrepareNewLotCodeSection(m_CurrentLotCodeSection.SectionPosition)

    End Sub

    Public Function CheckPermissions() As Boolean

        Try
            Dim permission As SPG.UserPermissionsRow = New UserPermissionsBLL().GetUserPermissionsByUserName(My.Settings.UserName, "Lot Code Setup")(0)

            Select Case permission.PermissionLevel
                Case "FULL", "Full"
                    newLotCodeFormatSimpleButton.Enabled = True
                    editSettingsSimpleButton.Enabled = True
                    editLotCodeFormatSimpleButton.Enabled = True
                    deleteFormatSimpleButton.Enabled = True
                    deleteSettingsSimpleButton.Enabled = True
                Case "ADD", "Add"
                    newLotCodeFormatSimpleButton.Enabled = True
                    editSettingsSimpleButton.Enabled = True
                    editLotCodeFormatSimpleButton.Enabled = True
                    deleteFormatSimpleButton.Enabled = False
                    deleteSettingsSimpleButton.Enabled = False
                Case "NONE", "None"
                    MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Close()
                    Return False
                Case "VIEW", "View"
                    newLotCodeFormatSimpleButton.Enabled = False
                    editSettingsSimpleButton.Enabled = False
                    editLotCodeFormatSimpleButton.Enabled = False
                    deleteFormatSimpleButton.Enabled = False
                    deleteSettingsSimpleButton.Enabled = False
                Case "EDIT", "Edit"
                    newLotCodeFormatSimpleButton.Enabled = False
                    editSettingsSimpleButton.Enabled = True
                    editLotCodeFormatSimpleButton.Enabled = True
                    deleteFormatSimpleButton.Enabled = False
                    deleteSettingsSimpleButton.Enabled = False
                Case "VIEW ASSIGNED"
                    newLotCodeFormatSimpleButton.Enabled = False
                    editSettingsSimpleButton.Enabled = False
                    editLotCodeFormatSimpleButton.Enabled = False
                    deleteFormatSimpleButton.Enabled = False
                    deleteSettingsSimpleButton.Enabled = False
                Case "EDIT ASSIGNED"
                    newLotCodeFormatSimpleButton.Enabled = False
                    editSettingsSimpleButton.Enabled = True
                    editLotCodeFormatSimpleButton.Enabled = True
                    deleteFormatSimpleButton.Enabled = False
                    deleteSettingsSimpleButton.Enabled = False
                Case Else
                    MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Close()
                    Return False
            End Select
            Return True
        Catch ex As InvalidOperationException
            Return False
        End Try

    End Function

    Private Sub PrepareNewLotCodeSection(ByVal SectionPosition As Integer?)

        If SectionPosition.HasValue Then
            m_CurrentLotCodeSection = m_LotCodeSession.FindObject(Of LotCodeFormatSections)(New GroupOperator(GroupOperatorType.And,
                                                                                                               New BinaryOperator(LotCodeFormatSections.Fields.LotCodeFormat.Oid.PropertyName, m_CurrentLotCodeFormat.Oid, BinaryOperatorType.Equal),
                                                                                                               New BinaryOperator(LotCodeFormatSections.Fields.SectionPosition.PropertyName, SectionPosition.Value, BinaryOperatorType.Equal)))
            If m_CurrentLotCodeSection Is Nothing Then
                m_CurrentLotCodeSection = New LotCodeFormatSections(m_LotCodeSession) With {.SectionPosition = SectionPosition.Value, .LotCodeFormat = m_CurrentLotCodeFormat}
            Else
                BindLotCodeSectionFields(m_CurrentLotCodeSection.Oid)
                Exit Sub
            End If
            sectionPositionSpinEdit.EditValue = SectionPosition.Value
        Else
            sectionPositionSpinEdit.EditValue = 1
        End If

        sectionNameTextEdit.EditValue = Nothing
        sectionTypeImageComboBoxEdit.EditValue = Nothing
        sectionLengthSpinEdit.EditValue = 1
        lettersToSkipTextEdit.EditValue = Nothing
        lettersToReplaceTextEdit.EditValue = Nothing
        replacementLettersTextEdit.EditValue = Nothing
        firstMonthComboBoxEdit.EditValue = Nothing
        firstYearTextEdit.EditValue = Nothing
        firstWeekOfYearImageComboBoxEdit.EditValue = Nothing
        firstDayOfWeekImageComboBoxEdit.EditValue = Nothing
        restartsOnTextEdit.EditValue = Nothing
        fromSpinEdit.EditValue = 11
        toSpinEdit.EditValue = 99

    End Sub

    Private Function RequiredInfoMissing() As Boolean

        If String.IsNullOrEmpty(formatNameTextEdit.Text) OrElse formatSectionsSpinEdit.Value < 1 Then
            MessageBox.Show("You must provide a name and the amount of sections it has before saving")
            Return True
        End If

        Return False

    End Function

    Private Function SaveLotCodeFormat() As Boolean 

        m_CurrentLotCodeFormat.FormatName = formatNameTextEdit.Text 
        m_CurrentLotCodeFormat.Sections = Convert.ToInt32(formatSectionsSpinEdit.Value)

        Try
            m_CurrentLotCodeFormat.Save 
        Catch ex As ApplicationException 
            MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        Return True

    End Function

    Private Function SaveSectionSettings() As Boolean

        If sectionPositionSpinEdit.ReadOnly = False Then
            UpdateSectionPosition(m_CurrentLotCodeSection.SectionPosition, Convert.ToInt32(sectionPositionSpinEdit.Value))
            m_CurrentLotCodeSection.SectionPosition = Convert.ToInt32(sectionPositionSpinEdit.Value)
        End If
        m_CurrentLotCodeSection.SectionName = sectionNameTextEdit.Text
        m_CurrentLotCodeSection.SectionType = CType(sectionTypeImageComboBoxEdit.EditValue, LotCodeSectionType)
        m_CurrentLotCodeSection.SectionLength = Convert.ToInt32(sectionLengthSpinEdit.Value)
        m_CurrentLotCodeSection.Save()

        For Each setting As LotCodeSectionSettings In m_CurrentLotCodeSection.SectionSettings
            setting.Delete 
        Next

        If lettersToSkipTextEdit.ReadOnly = False AndAlso lettersToSkipTextEdit.Enabled = True Then
            m_CurrentLotCodeSectionSettings = New LotCodeSectionSettings(m_LotCodeSession) With { .LotCodeSection = m_CurrentLotCodeSection, .SettingName = "LettersToSkip", .SettingValue = CType(lettersToSkipTextEdit.EditValue, String) }
            m_CurrentLotCodeSectionSettings.Save 
        End If
        If lettersToReplaceTextEdit.ReadOnly = False AndAlso lettersToReplaceTextEdit.Enabled = True Then
            m_CurrentLotCodeSectionSettings = New LotCodeSectionSettings(m_LotCodeSession) With { .LotCodeSection = m_CurrentLotCodeSection, .SettingName = "LettersToReplace", .SettingValue = CType(lettersToReplaceTextEdit.EditValue, String) }
            m_CurrentLotCodeSectionSettings.Save 
        End If
        If replacementLettersTextEdit.ReadOnly = False AndAlso replacementLettersTextEdit.Enabled = True Then
            m_CurrentLotCodeSectionSettings = New LotCodeSectionSettings(m_LotCodeSession) With { .LotCodeSection = m_CurrentLotCodeSection, .SettingName = "ReplacementLetters", .SettingValue = CType(replacementLettersTextEdit.EditValue, String) }
            m_CurrentLotCodeSectionSettings.Save 
        End If
        If firstMonthComboBoxEdit.ReadOnly = False AndAlso firstMonthComboBoxEdit.Enabled = True Then
            m_CurrentLotCodeSectionSettings = New LotCodeSectionSettings(m_LotCodeSession) With { .LotCodeSection = m_CurrentLotCodeSection, .SettingName = "FirstMonth", .SettingValue = CType(firstMonthComboBoxEdit.EditValue, String) }
            m_CurrentLotCodeSectionSettings.Save 
        End If
        If firstYearTextEdit.ReadOnly = False AndAlso firstYearTextEdit.Enabled = True Then
            m_CurrentLotCodeSectionSettings = New LotCodeSectionSettings(m_LotCodeSession) With { .LotCodeSection = m_CurrentLotCodeSection, .SettingName = "FirstYear", .SettingValue = CType(firstYearTextEdit.EditValue, String) }
            m_CurrentLotCodeSectionSettings.Save 
        End If
        If firstWeekOfYearImageComboBoxEdit.ReadOnly = False AndAlso firstWeekOfYearImageComboBoxEdit.Enabled = True Then
            m_CurrentLotCodeSectionSettings = New LotCodeSectionSettings(m_LotCodeSession) With { .LotCodeSection = m_CurrentLotCodeSection, .SettingName = "FirstWeekOfYear", .SettingValue = CType(firstWeekOfYearImageComboBoxEdit.EditValue, String) }
            m_CurrentLotCodeSectionSettings.Save 
        End If
        If firstDayOfWeekImageComboBoxEdit.ReadOnly = False AndAlso firstDayOfWeekImageComboBoxEdit.Enabled = True Then
            m_CurrentLotCodeSectionSettings = New LotCodeSectionSettings(m_LotCodeSession) With { .LotCodeSection = m_CurrentLotCodeSection, .SettingName = "FirstDayOfWeek", .SettingValue = CType(firstDayOfWeekImageComboBoxEdit.EditValue, String) }
            m_CurrentLotCodeSectionSettings.Save 
        End If
        If restartsOnTextEdit.ReadOnly = False AndAlso restartsOnTextEdit.Enabled = True Then
            m_CurrentLotCodeSectionSettings = New LotCodeSectionSettings(m_LotCodeSession) With { .LotCodeSection = m_CurrentLotCodeSection, .SettingName = "RestartsOnThe", .SettingValue = CType(restartsOnTextEdit.EditValue, String) }
            m_CurrentLotCodeSectionSettings.Save 
        End If
        If fromSpinEdit.ReadOnly = False AndAlso fromSpinEdit.Enabled = True Then
            m_CurrentLotCodeSectionSettings = New LotCodeSectionSettings(m_LotCodeSession) With { .LotCodeSection = m_CurrentLotCodeSection, .SettingName = "NumberRangeFrom", .SettingValue = CType(fromSpinEdit.EditValue, String) }
            m_CurrentLotCodeSectionSettings.Save 
        End If
        If toSpinEdit.ReadOnly = False AndAlso toSpinEdit.Enabled = True Then
            m_CurrentLotCodeSectionSettings = New LotCodeSectionSettings(m_LotCodeSession) With { .LotCodeSection = m_CurrentLotCodeSection, .SettingName = "NumberRangeTo", .SettingValue = CType(toSpinEdit.EditValue, String) }
            m_CurrentLotCodeSectionSettings.Save 
        End If

        Return True

    End Function

    Private Sub UpdateSectionPosition(ByVal oldSectionPosition As Integer, ByVal newSectionPosition As Integer)

        If oldSectionPosition < newSectionPosition Then
            For Each codeSection In From LaterSection In m_LotCodeSession.Query(Of LotCodeFormatSections)()
                                    Where LaterSection.LotCodeFormat.Oid = m_CurrentLotCodeFormat.Oid AndAlso LaterSection.SectionPosition > oldSectionPosition AndAlso LaterSection.SectionPosition <= newSectionPosition
                                    Select LaterSection
                codeSection.SectionPosition -= 1
                codeSection.Save
            Next
        Else
            For Each codeSection In From PreviousSection In m_LotCodeSession.Query(Of LotCodeFormatSections)()
                                    Where PreviousSection.LotCodeFormat.Oid = m_CurrentLotCodeFormat.Oid AndAlso PreviousSection.SectionPosition < oldSectionPosition AndAlso PreviousSection.SectionPosition >= newSectionPosition
                                    Select PreviousSection
                codeSection.SectionPosition += 1
                codeSection.Save 
            Next
        End If

    End Sub

    Private Function ValidateCodeFormatRecord() As Boolean

        If RequiredInfoMissing Then
            Return False
        End If

        Return True

    End Function

    Private Sub ValidateFirstDayOfWeek()

        If firstDayOfWeekImageComboBoxEdit.EditValue Is Nothing Then
            firstDayOfWeekImageComboBoxEdit.EditValue = FirstDayOfWeek.Monday
        End If

    End Sub

    Private Sub ValidateFirstWeekOfYear()

        If firstWeekOfYearImageComboBoxEdit.EditValue Is Nothing Then
            firstWeekOfYearImageComboBoxEdit.EditValue = FirstWeekOfYear.FirstFourDays
        End If

    End Sub

    Private Function ValidateReplacementLetters() As Boolean

        If String.IsNullOrEmpty(lettersToReplaceTextEdit.Text) <> String.IsNullOrEmpty(replacementLettersTextEdit.Text) OrElse lettersToReplaceTextEdit.Text.Length <> replacementLettersTextEdit.Text.Length Then
            MessageBox.Show("The letters to replace and the replacement letters must match before saving")
            Return False
        End If

        Return True

    End Function

    Private Function ValidateSectionSettingsRecord() As Boolean

        If String.IsNullOrEmpty(sectionTypeImageComboBoxEdit.Text) OrElse sectionLengthSpinEdit.Value < 1 Then
            MessageBox.Show("You must provide a type and a length before saving")
            Return False
        End If

        Select Case CType(sectionTypeImageComboBoxEdit.EditValue, LotCodeSectionType)
            Case LotCodeSectionType.YearText                
                If ValidateReplacementLetters() = False Then
                    Return False
                End If
                If ValidateYear(True, firstYearTextEdit.Text, "You must enter a year for the first year") = False Then
                    Return False
                End If
                ValidateFirstWeekOfYear()
                ValidateFirstDayOfWeek()
                If ValidateYear(False, restartsOnTextEdit.Text, "You must enter a valid number for the restarts on the (nth year) field") = False Then
                    Return False
                End If
                Exit Select
            Case LotCodeSectionType.MonthText
                If ValidateReplacementLetters() = False Then
                    Return False
                End If
                Exit Select
            Case LotCodeSectionType.WeekOfYear
                ValidateFirstWeekOfYear()
                Exit Select
            Case LotCodeSectionType.DayOfWeekText, LotCodeSectionType.DayOfWeekNumber
                ValidateFirstDayOfWeek()
                Exit Select
            Case LotCodeSectionType.MonthCustom
                If ValidateYear(True, firstYearTextEdit.Text, "You must enter a year for the first year") = False Then
                    Return False
                End If
                If firstMonthComboBoxEdit.EditValue Is Nothing Then
                    firstMonthComboBoxEdit.SelectedItem = "January" 
                End If
                If fromSpinEdit.Value > toSpinEdit.Value Then
                    MessageBox.Show("The From has to be less than the To")
                    Return False
                End If
                Exit Select
            Case LotCodeSectionType.DayOfMonthCustom
                If ValidateReplacementLetters() = False Then
                    Return False
                End If
                If ValidateYear(False, restartsOnTextEdit.Text, "You must enter a valid number for the restarts on the (nth day) field") = False Then
                    Return False
                End If
                Exit Select
            Case Else
                Return True
                Exit Select
        End Select

        Return True

    End Function

    Private Function ValidateYear(byval isYear As Boolean, ByVal yearText As String, ByVal msg As String) As Boolean

        Dim year As Integer
        If String.IsNullOrEmpty(yearText) OrElse Integer.TryParse(yearText, year) = False OrElse(isYear AndAlso (year < 1900 OrElse year > 9999)) Then
            MessageBox.Show(msg)
            Return False
        End If

        Return True

    End Function

End Class