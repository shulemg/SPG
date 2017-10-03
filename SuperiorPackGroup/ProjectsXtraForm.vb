Imports DXDAL
Imports DXDAL.SPGData
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Public Class ProjectsXtraForm

    Private m_CurrentProject As Project
    Private m_ProjectSession As Session

    Private Sub addBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles addBarButtonItem.ItemClick

        m_CurrentProject = New Project(m_ProjectSession)
        oidTextEdit.EditValue = m_CurrentProject.Oid
        projectTextEdit.EditValue = Nothing
        customerLookUpEdit.EditValue = Nothing
        reqStartDateEdit.EditValue = Nothing
        reqShipDateEdit.EditValue = Nothing
        reqDeliveryDateEdit.EditValue = Nothing
        projectStatusComboBoxEdit.EditValue = Nothing
        'scheduledWeekDatePeriodEdit.EditValue = Nothing
        notesMemoExEdit.EditValue = Nothing

        projectDetailsXpCollection.Criteria = New BinaryOperator(ProjectDetails.Fields.Project.Oid.PropertyName, m_CurrentProject.Oid, BinaryOperatorType.Equal)
        projectDetailsXpCollection.Reload()

        Utilities.MakeFormReadOnly(dataEntrySplitContainerControl.Panel1, False)
        projectDetailsGridView.OptionsBehavior.Editable = True
        projectSearchGridControl.Enabled = False
        CheckPermissions()

        EnableAvailableBarButtons(True)

    End Sub

    Private Sub cancelBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cancelBarButtonItem.ItemClick

        CancelChanges()
        CheckPermissions()

        Utilities.MakeFormReadOnly(dataEntrySplitContainerControl.Panel1, True)
        projectDetailsGridView.OptionsBehavior.Editable = False
        projectSearchGridControl.Enabled = True

        EnableAvailableBarButtons(False)

    End Sub

    Private Sub customerLookUpEdit_Validated(sender As Object, e As EventArgs) Handles customerLookUpEdit.Validated

        BindItemLookupEdit()

    End Sub

    Private Sub deleteBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles deleteBarButtonItem.ItemClick

        If projectDetailsXpCollection.Count > 0 Then
            MessageBox.Show("You must first delete the details.", "Delete Project", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to delete this project?", "Delete Project", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Try
            m_CurrentProject.Delete()
            If m_CurrentProject.IsDeleted Then
                BindProjectSearch()
            Else
                MessageBox.Show("The project was not deleted.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(String.Format("The project was not deleted.{0}{1}", vbCrLf, ex.Message), "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub deleteRepositoryItemButtonEdit_Click(sender As Object, e As EventArgs) Handles deleteRepositoryItemButtonEdit.Click

        If MessageBox.Show("Are you sure you want to delete this project line?", "Delete Project Line", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Dim detail As ProjectDetails = m_ProjectSession.GetObjectByKey(Of ProjectDetails)(projectDetailsGridView.GetFocusedRowCellValue(colOid))
        If Not detail Is Nothing Then
            If detail.UnitsProduced + detail.BagsProduced + detail.PalletsProduced > 0 Then
                MessageBox.Show("You can't delete this line, you already have production against it.", "Delete Project Line", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Sub
            End If

            detail.Delete()
            If detail.IsDeleted = False Then
                MessageBox.Show("The project line was not removed.")
            End If
        Else
            projectDetailsGridView.DeleteRow(projectDetailsGridView.FocusedRowHandle)
        End If

    End Sub

    Private Sub detailHistorySimpleButton_Click(sender As Object, e As EventArgs) Handles detailHistorySimpleButton.Click

        detailHistoryGridControl.DataSource = ProjectsBLL.GetProjectDetailChanges(m_ProjectSession, m_CurrentProject.Oid)
        detailHistoryGridControl.Visible = True

    End Sub

    Private Sub editBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles editBarButtonItem.ItemClick

        If m_CurrentProject Is Nothing Then
            MessageBox.Show("Please select a project to edit.")
            Exit Sub 
        End If

        Utilities.MakeFormReadOnly(dataEntrySplitContainerControl.Panel1, False)
        projectDetailsGridView.OptionsBehavior.Editable = True
        projectSearchGridControl.Enabled = False
        CheckPermissions()

        EnableAvailableBarButtons(True)

    End Sub

    Private Sub itemRepositoryItemLookUpEdit_QueryPopUp(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles RepositoryItemLookUpEdit1.QueryPopUp

        If CInt(projectDetailsGridView.GetFocusedRowCellValue(colUnitsProduced)) >= 1 OrElse CInt(projectDetailsGridView.GetFocusedRowCellValue(colBagsProduced)) >= 1 _
            OrElse CInt(projectDetailsGridView.GetFocusedRowCellValue(colPalletsProduced)) >= 1 Then
            MessageBox.Show("You can't change the item once there's already production against it.")
            e.Cancel = True
        End If

    End Sub

    Private Sub projectDetailsGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles projectDetailsGridView.CellValueChanged

        If IsNothing(projectDetailsGridView.GetFocusedRowCellValue(colItemNumber)) OrElse IsDBNull(projectDetailsGridView.GetFocusedRowCellValue(colItemNumber)) Then
            Exit Sub
        End If

        If e.Column Is colItemNumber OrElse e.Column Is colBagsRequested OrElse e.Column Is colPalletsRequested OrElse e.Column Is colUnitsRequested Then
            If CDbl(projectDetailsGridView.GetFocusedRowCellValue(colBagsRequested)) > 0 OrElse CDbl(projectDetailsGridView.GetFocusedRowCellValue(colPalletsRequested)) > 0 OrElse
                    CDbl(projectDetailsGridView.GetFocusedRowCellValue(colUnitsRequested)) > 0 Then
                UpdateRequestedQuantities(e.Column.Name)
            End If
            'ElseIf e.Column Is colBagsRequested OrElse e.Column Is colPalletsRequested OrElse e.Column Is colUnitsRequested Then
            '    If CDbl(projectDetailsGridView.GetFocusedRowCellValue(colBagsRequested)) > 0 OrElse CDbl(projectDetailsGridView.GetFocusedRowCellValue(colPalletsRequested)) > 0 OrElse
            '            CDbl(projectDetailsGridView.GetFocusedRowCellValue(colUnitsRequested)) > 0 Then
            '        UpdateRequestedQuantities(e.Column.Name)
            '    End If
        End If

    End Sub

    Private Sub projectDetailsGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles projectDetailsGridView.InitNewRow

        projectDetailsGridView.SetRowCellValue(e.RowHandle, colProjectID, m_CurrentProject.Oid)

    End Sub

    Private Sub projectSearchGridView_Click(sender As Object, e As EventArgs) Handles projectSearchGridView.Click

        If projectSearchGridView.FocusedRowHandle = -999997 Then
            Exit Sub
        End If

        If projectSearchGridView.CalcHitInfo(projectSearchGridControl.PointToClient(Control.MousePosition)).HitTest = DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.RowCell Then
            BindProjectControls(CType(projectSearchGridView.GetFocusedRowCellValue(colProjectID), Integer))
        End If

    End Sub

    Private Sub projectStatusComboBoxEdit_FormatEditValue(sender As Object, e As DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs) Handles projectStatusComboBoxEdit.FormatEditValue

        If e.Value IsNot Nothing Then
            e.Value = GetType(ProjectStatus).GetEnumName(e.Value)
            e.Handled = True
        End If

    End Sub

    Private Sub ProjectsXtraForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If projectSearchGridControl.Enabled = False Then
            Select Case MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                Case Windows.Forms.DialogResult.Yes
                    If SaveChanges() = False Then
                        e.Cancel = True
                    End If
                Case Windows.Forms.DialogResult.No
                    CancelChanges()
                Case Windows.Forms.DialogResult.Cancel
                    e.Cancel = True
            End Select
        End If

        If e.Cancel = False Then
            ProjectDetails.AutoSaveOnEndEdit = True
            m_ProjectSession.PurgeDeletedObjects()
        End If

    End Sub

    Private Sub ProjectsXtraForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        Cursor = Cursors.WaitCursor

        CheckPermissions()

        m_ProjectSession = New Session(SPGDataLayer)
        m_ProjectSession.TrackPropertiesModifications = True
        m_ProjectSession.OptimisticLockingReadBehavior = OptimisticLockingReadBehavior.MergeCollisionThrowException

        For i As Integer = 0 To components.Components.Count - 1
            If TypeOf (components.Components(i)) Is XPView Then
                CType(components.Components(i), XPView).Session = m_ProjectSession
            ElseIf TypeOf (components.Components(i)) Is XPCollection Then
                CType(components.Components(i), XPCollection).Session = m_ProjectSession
            End If
        Next

        projectStatusComboBoxEdit.Properties.Items.AddRange([Enum].GetValues(GetType(ProjectStatus)))

        projectDetailsXpCollection.Criteria = New BinaryOperator(ProjectDetails.Fields.Project.Oid.PropertyName, 0, BinaryOperatorType.Equal)
        projectSearchGridView.OptionsBehavior.Editable = False

        'scheduledWeekDatePeriodEdit.Properties.

        ProjectDetails.AutoSaveOnEndEdit = False

        Utilities.MakeFormReadOnly(dataEntrySplitContainerControl.Panel1, True)

        EnableAvailableBarButtons(False)

        Cursor = Cursors.Default

    End Sub

    Private Sub saveBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles saveBarButtonItem.ItemClick

        If SaveChanges() Then
            CheckPermissions()

            Utilities.MakeFormReadOnly(dataEntrySplitContainerControl.Panel1, True)
            projectDetailsGridView.OptionsBehavior.Editable = False
            projectSearchGridControl.Enabled = True

            EnableAvailableBarButtons(False)
        End If

    End Sub

    Private Sub BindItemLookupEdit()

        itemXpView.Criteria = New GroupOperator(GroupOperatorType.And, New BinaryOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, CInt(customerLookUpEdit.EditValue), BinaryOperatorType.Equal),
                                                New BinaryOperator(Items.Fields.Inactive.PropertyName, True, BinaryOperatorType.NotEqual))
        itemXpView.Reload()

    End Sub

    Private Sub BindProjectControls(ByVal ProjectID As Integer)

        m_ProjectSession.DropIdentityMap()

        Dim project As Project = m_ProjectSession.GetObjectByKey(Of Project)(ProjectID, True)
        m_CurrentProject = project
        oidTextEdit.EditValue = m_CurrentProject.Oid
        projectTextEdit.EditValue = m_CurrentProject.Project
        customerLookUpEdit.EditValue = If(m_CurrentProject.Customer Is Nothing, Nothing, m_CurrentProject.Customer.CustomerID)
        reqStartDateEdit.EditValue = m_CurrentProject.RequestedStartDate
        reqShipDateEdit.EditValue = m_CurrentProject.RequestedShippingDate
        reqDeliveryDateEdit.EditValue = m_CurrentProject.RequestedDeliveryDate
        projectStatusComboBoxEdit.EditValue = m_CurrentProject.ProjectStatus
        'scheduledWeekDatePeriodEdit.EditValue = m_CurrentProject.ScheduledWeek
        notesMemoExEdit.EditValue = m_CurrentProject.Notes

        projectDetailsXpCollection.Criteria = New BinaryOperator(ProjectDetails.Fields.Project.Oid.PropertyName, m_CurrentProject.Oid, BinaryOperatorType.Equal)
        projectDetailsXpCollection.Reload()

        detailHistoryGridControl.DataSource = Nothing
        detailHistoryGridControl.Visible = False

        BindItemLookupEdit()

    End Sub

    Private Sub BindProjectSearch()

        projectSearchXpView.Reload()

    End Sub

    Private Sub CancelChanges()

        If m_CurrentProject.Oid <> -1 Then
            BindProjectControls(m_CurrentProject.Oid)
        End If

    End Sub

    Public Function CheckPermissions() As Boolean

        Try
            Dim permission As SPG.UserPermissionsRow = New UserPermissionsBLL().GetUserPermissionsByUserName(My.Settings.UserName, "Projects And Scheduling")(0)

            Select Case permission.PermissionLevel
                Case "FULL", "Full"
                    addBarButtonItem.Enabled = True
                    editBarButtonItem.Enabled = True
                    deleteBarButtonItem.Enabled = True
                    delGridColumn.Visible = True
                    delGridColumn.VisibleIndex = 0
                Case "ADD", "Add"
                    addBarButtonItem.Enabled = True
                    editBarButtonItem.Enabled = True
                    deleteBarButtonItem.Enabled = False
                    delGridColumn.Visible = False
                Case "NONE", "None"
                    MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Close()
                    Return False
                Case "VIEW", "View"
                    addBarButtonItem.Enabled = False
                    editBarButtonItem.Enabled = False
                    deleteBarButtonItem.Enabled = False
                    delGridColumn.Visible = False
                Case "EDIT", "Edit"
                    addBarButtonItem.Enabled = False
                    editBarButtonItem.Enabled = True
                    deleteBarButtonItem.Enabled = False
                    delGridColumn.Visible = False
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

    Private Sub EnableAvailableBarButtons(ByVal EditingMode As Boolean)

        If EditingMode Then
            cancelBarButtonItem.Enabled = True
            saveBarButtonItem.Enabled = True
            deleteRepositoryItemButtonEdit.Buttons(0).Enabled = True
            editBarButtonItem.Enabled = False
            addBarButtonItem.Enabled = False
            deleteBarButtonItem.Enabled = False
        Else
            cancelBarButtonItem.Enabled = False
            saveBarButtonItem.Enabled = False
            deleteRepositoryItemButtonEdit.Buttons(0).Enabled = False
            editBarButtonItem.Enabled = True
            addBarButtonItem.Enabled = True
            deleteBarButtonItem.Enabled = True
        End If

    End Sub

    Private Function SaveChanges() As Boolean

        Dim selectedID As Integer

        projectDetailsGridView.CloseEditor()
        projectDetailsGridView.MoveNext()

        If m_CurrentProject.Oid <> -1 Then
            selectedID = projectSearchGridView.FocusedRowHandle
        End If


        Try
            If ProjectsBLL.ValidateRecord(Convert.ToString(projectTextEdit.EditValue), CType(customerLookUpEdit.EditValue, Integer?), CType(reqStartDateEdit.EditValue, Date?), CType(reqDeliveryDateEdit.EditValue, Date?),
                                          CType(reqShipDateEdit.EditValue, Date?)) Then
                m_CurrentProject.Project = projectTextEdit.EditValue.ToString
                m_CurrentProject.Customer = If(customerLookUpEdit.EditValue Is Nothing, Nothing, m_ProjectSession.GetObjectByKey(Of Customers)(CInt(customerLookUpEdit.EditValue)))
                m_CurrentProject.RequestedDeliveryDate = CType(reqDeliveryDateEdit.EditValue, Date?)
                m_CurrentProject.RequestedShippingDate = CType(reqShipDateEdit.EditValue, Date?)
                m_CurrentProject.RequestedStartDate = CType(reqStartDateEdit.EditValue, Date?)
                m_CurrentProject.ProjectStatus = CType(projectStatusComboBoxEdit.EditValue, ProjectStatus)
                'm_CurrentProject.ScheduledWeek = scheduledWeekDatePeriodEdit.EditValue.ToString
                m_CurrentProject.Notes = CStr(notesMemoExEdit.EditValue)

                For Each detail As ProjectDetails In projectDetailsXpCollection
                    If detail.Project Is Nothing OrElse detail.Project.Oid = -1 Then
                        detail.Project = m_CurrentProject
                    End If
                Next

                m_CurrentProject.Save()
            Else
                MessageBox.Show("The record is not valid. You must provide a project name, and valid dates for start and ship or delivery date.")
                Return False
            End If
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        BindProjectSearch()
        BindProjectControls(m_CurrentProject.Oid)
        projectSearchGridView.FocusedRowHandle = selectedID
        Return True

    End Function

    Private Sub UpdateRequestedQuantities(ByVal ChangedColumn As String)

        Dim unitsPerCase As Double = CDbl(CType(itemRepositoryItemLookUpEdit.GetDataSourceRowByKeyValue(projectDetailsGridView.GetFocusedRowCellValue(colItemNumber)), ViewRecord)(2))
        Dim bagsPerCase As Double = CDbl(CType(itemRepositoryItemLookUpEdit.GetDataSourceRowByKeyValue(projectDetailsGridView.GetFocusedRowCellValue(colItemNumber)), ViewRecord)(3))
        Dim casesPerPallet As Double = CDbl(CType(itemRepositoryItemLookUpEdit.GetDataSourceRowByKeyValue(projectDetailsGridView.GetFocusedRowCellValue(colItemNumber)), ViewRecord)(4))

        Select Case ChangedColumn
            Case colItemNumber.Name
                If CInt(projectDetailsGridView.GetFocusedRowCellValue(colUnitsRequested)) < 1 OrElse projectDetailsGridView.GetFocusedRowCellValue(colUnitsRequested) Is Nothing _
                        OrElse IsDBNull(projectDetailsGridView.GetFocusedRowCellValue(colUnitsRequested)) Then
                    projectDetailsGridView.SetFocusedRowCellValue(colBagsRequested, 0)
                    projectDetailsGridView.SetFocusedRowCellValue(colPalletsRequested, 0)
                Else
                    If unitsPerCase > 0 Then
                        projectDetailsGridView.SetFocusedRowCellValue(colBagsRequested, (CInt(projectDetailsGridView.GetFocusedRowCellValue(colUnitsRequested)) / unitsPerCase) * bagsPerCase)
                    End If
                    If unitsPerCase > 0 andalso casesPerPallet > 0 then
                        projectDetailsGridView.SetFocusedRowCellValue(colPalletsRequested, (CInt(projectDetailsGridView.GetFocusedRowCellValue(colUnitsRequested)) / unitsPerCase) / casesPerPallet)
                    End If
                End If
            Case colUnitsRequested.Name
                If CInt(projectDetailsGridView.GetFocusedRowCellValue(colUnitsRequested)) >= 1 Then
                    If CInt(projectDetailsGridView.GetFocusedRowCellValue(colBagsRequested)) = 0 AndAlso unitsPerCase > 0 Then
                        projectDetailsGridView.SetFocusedRowCellValue(colBagsRequested, (CInt(projectDetailsGridView.GetFocusedRowCellValue(colUnitsRequested)) / unitsPerCase) * bagsPerCase)
                    End If
                    If CInt(projectDetailsGridView.GetFocusedRowCellValue(colPalletsRequested)) = 0 AndAlso unitsPerCase > 0 AndAlso casesPerPallet > 0 Then
                        projectDetailsGridView.SetFocusedRowCellValue(colPalletsRequested, (CInt(projectDetailsGridView.GetFocusedRowCellValue(colUnitsRequested)) / unitsPerCase) / casesPerPallet)
                    End If
                End If
            Case colBagsRequested.Name
                If CInt(projectDetailsGridView.GetFocusedRowCellValue(colBagsRequested)) >= 1 Then
                    If CInt(projectDetailsGridView.GetFocusedRowCellValue(colUnitsRequested)) = 0 AndAlso bagsPerCase > 0 Then
                        projectDetailsGridView.SetFocusedRowCellValue(colUnitsRequested, (CInt(projectDetailsGridView.GetFocusedRowCellValue(colBagsRequested)) / bagsPerCase) * unitsPerCase)
                    End If
                    If CInt(projectDetailsGridView.GetFocusedRowCellValue(colPalletsRequested)) = 0 AndAlso bagsPerCase  > 0 AndAlso casesPerPallet > 0 Then
                        projectDetailsGridView.SetFocusedRowCellValue(colPalletsRequested, (CInt(projectDetailsGridView.GetFocusedRowCellValue(colBagsRequested)) / bagsPerCase) / casesPerPallet)
                    End If
                End If
            Case colPalletsRequested.Name
                If CInt(projectDetailsGridView.GetFocusedRowCellValue(colPalletsRequested)) >= 1 Then
                    If CInt(projectDetailsGridView.GetFocusedRowCellValue(colUnitsRequested)) = 0 Then
                        projectDetailsGridView.SetFocusedRowCellValue(colUnitsRequested, (CInt(projectDetailsGridView.GetFocusedRowCellValue(colPalletsRequested)) * casesPerPallet) * unitsPerCase)
                    End If
                    If CInt(projectDetailsGridView.GetFocusedRowCellValue(colBagsRequested)) = 0 Then
                        projectDetailsGridView.SetFocusedRowCellValue(colBagsRequested, (CInt(projectDetailsGridView.GetFocusedRowCellValue(colPalletsRequested)) * casesPerPallet) * bagsPerCase)
                    End If
                End If
        End Select

    End Sub

    Private Sub printProductionReportBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles printProductionReportBarButtonItem.ItemClick

        If m_CurrentProject IsNot Nothing Then
            With QuickReportsXtraForm
                .MdiParent = MdiParent
                .Show()
                '.SelectWeeklyScheduleReport(m_CurrentProject, scheduledWeekDatePeriodEdit.Text)
                '.FillReports(Nothing)
                .Activate()
            End With
        Else
            MessageBox.Show("There's no project selected.")
        End If

    End Sub

    Private Sub printBomAvailabilityBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles printBomAvailabilityBarButtonItem.ItemClick

        If m_CurrentProject IsNot Nothing Then
            With QuickReportsXtraForm
                .MdiParent = MdiParent
                .Show()
                .SelectProjectBomAvailabilityReport(m_CurrentProject)
                .Activate()
            End With
        Else
            MessageBox.Show("There's no project selected.")
        End If

    End Sub

    Private Sub refreshBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles refreshBarButtonItem.ItemClick
        BindProjectControls(m_CurrentProject.Oid)
        projectSearchXpView.Reload()
    End Sub
End Class