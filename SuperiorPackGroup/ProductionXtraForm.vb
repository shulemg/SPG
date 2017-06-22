Imports DevExpress.XtraEditors
Imports DevExpress.Data.Filtering
Imports DXDAL.SPGData
Imports DevExpress.Xpo
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Linq

Public Class ProductionXtraForm

    Private m_AllowAdd As Boolean = False
    Private m_Items As ItemsBLL
    Private m_Production As ProductionBLL
    Private m_Shift As ShiftsBLL
    Private m_Machines As MachinesLinesBLL
    Private m_Customers As CustomersBLL
    Private m_ProductionSession As Session
    Private m_ReasonsCollection As BindingList(Of ReasonIDs) = New BindingList(Of ReasonIDs)

    Private Sub ProductionXtraForm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        FillDropDowns()

    End Sub

    Private Sub ProductionXtraForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Me.editSimpleButton.Tag IsNot Nothing Then
            MessageBox.Show("You must first save or cancel the changes")
            e.Cancel = True
        End If

    End Sub

    Private Sub FillDropDowns()

        Dim shifts As DataTable = m_Shift.GetShifts()
        'Dim machines As DataTable = m_Machines.GetMachineLines()

        'Me.machineLookUpEdit.Properties.DataSource = machines
        'Me.machineFilterLookUpEdit.Properties.DataSource = machines
        Me.shiftLookUpEdit.Properties.DataSource = shifts
        Me.shiftFilterLookUpEdit.Properties.DataSource = shifts
        itemsFilterXPView.Reload()
        itemsXPView.Reload()
        customersXPView.Reload()

    End Sub

    Private Sub ProductionXtraForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Cursor = Cursors.WaitCursor

        m_ProductionSession = New Session(SPGDataLayer) With {.TrackPropertiesModifications = True, .OptimisticLockingReadBehavior = OptimisticLockingReadBehavior.MergeCollisionThrowException}

        CheckPermissions()

        For i As Integer = 0 To components.Components.Count - 1
            If TypeOf (components.Components(i)) Is XPView Then
                CType(components.Components(i), XPView).Session = m_ProductionSession
            ElseIf TypeOf (components.Components(i)) Is XPCollection Then
                CType(components.Components(i), XPCollection).Session = m_ProductionSession
            End If
        Next i

        m_Items = New ItemsBLL
        m_Production = New ProductionBLL
        m_Shift = New ShiftsBLL
        m_Machines = New MachinesLinesBLL
        m_Customers = New CustomersBLL

        Dim shiftNameColumn As Controls.LookUpColumnInfo = New Controls.LookUpColumnInfo() With {.Caption = "Shift", .FieldName = "ShiftName"}
        Me.shiftLookUpEdit.Properties.Columns.Add(shiftNameColumn)
        Me.shiftLookUpEdit.Properties.DisplayMember = "ShiftName"
        Me.shiftLookUpEdit.Properties.ValueMember = "ShiftID"

        Me.shiftFilterLookUpEdit.Properties.Columns.Add(shiftNameColumn)
        Me.shiftFilterLookUpEdit.Properties.DisplayMember = "ShiftName"
        Me.shiftFilterLookUpEdit.Properties.ValueMember = "ShiftID"

        'Dim machineNameColumn As Controls.LookUpColumnInfo = New Controls.LookUpColumnInfo() With {.Caption = "Machine Line", .FieldName = "MachineLineName"}

        'Me.machineLookUpEdit.Properties.Columns.Add(machineNameColumn)
        'Me.machineLookUpEdit.Properties.DisplayMember = "MachineLineName"
        'Me.machineLookUpEdit.Properties.ValueMember = "MachineLineID"

        'Me.machineFilterLookUpEdit.Properties.Columns.Add(machineNameColumn)
        'Me.machineFilterLookUpEdit.Properties.DisplayMember = "MachineLineName"
        'Me.machineFilterLookUpEdit.Properties.ValueMember = "MachineLineID"

        FillDropDowns()

        PrepareNewRecord()
        If Now.TimeOfDay < New TimeSpan(9, 0, 0) Then
            productionDateEdit.DateTime = DateAdd(DateInterval.Day, -1, Today)
        Else
            productionDateEdit.DateTime = Today
        End If

        SetDefaultViewFilter()
        FillProductionView()

        Me.Cursor = Cursors.Default

    End Sub

    Public Sub SetDefaultViewFilter()

        'Set the from filter to the sunday of this week
        Me.fromFilterDateEdit.DateTime = DateAdd(DateInterval.Day, (Weekday(Today) - 1) * -1, Today)
        Me.toFilterDateEdit.DateTime = Today
        Me.machineFilterLookUpEdit.EditValue = Nothing
        Me.customerFilterLookUpEdit.EditValue = Nothing
        Me.shiftFilterLookUpEdit.EditValue = Nothing
        Me.itemFilterLookUpEdit.EditValue = Nothing

    End Sub

    Private Sub itemLookUpEdit_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemLookUpEdit.Validated

        Me.descriptionMemoEdit.Text = ItemsBLL.GetDescriptionByItemID(CType(Me.itemLookUpEdit.EditValue, Integer?))
        uomTextEdit.Text = ItemsBLL.GetUOMByItemID(CType(itemLookUpEdit.EditValue, Integer?))

    End Sub

    Private Sub productionGridView_CustomUnboundColumnData(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles productionGridView.CustomUnboundColumnData

        If IsDBNull(productionGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.startGridColumn)) Then
            Exit Sub
        End If

        If IsDBNull(productionGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.stopGridColumn)) Then
            Exit Sub
        End If

        If e.Column.Name = "timeGridColumn" Then
            Dim ProductionDay As Date = CType(productionGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.dateGridColumn), DateTime)
            Dim startTime As Date = CType(productionGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.startGridColumn), DateTime)
            Dim stopTime As Date = CType(productionGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.stopGridColumn), DateTime)
            'Make sure that the work dates are the same as the production date
            startTime = New Date(ProductionDay.Year, ProductionDay.Month, ProductionDay.Day, startTime.Hour, startTime.Minute, 0)
            stopTime = New Date(ProductionDay.Year, ProductionDay.Month, ProductionDay.Day, stopTime.Hour, stopTime.Minute, 0)
            If DateDiff(DateInterval.Minute, startTime, stopTime) < 1 Then
                stopTime = DateAdd(DateInterval.Day, 1, stopTime)
            End If
            Dim interval As Long = DateDiff(DateInterval.Minute, startTime, stopTime) - BreakTimeBLL.GetBreakMinutes(ProductionDay, startTime, stopTime)
            e.Value = String.Format("{0}:{1}", interval \ 60, (interval Mod 60) \ 1)
        ElseIf e.Column.Name = colReasons.Name Then
            e.Value = m_ProductionSession.GetObjectByKey(Of Production)(productionGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, idGridColumn)).Reasons
        End If

    End Sub

    Private Sub saveSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveSimpleButton.Click

        If ValidateRecord() Then
            If SaveRecord(CType(Me.saveSimpleButton.Tag, Integer?)) Then
                PrepareNewRecord()
            End If
        End If

    End Sub

    Public Function ValidateRecord() As Boolean

        If Me.itemLookUpEdit.EditValue Is Nothing OrElse _
                                CType(Me.itemLookUpEdit.EditValue, String) = Me.itemLookUpEdit.Properties.NullText Then
            MessageBox.Show("You must select a Item Code.")
            Me.itemLookUpEdit.Focus()
            Return False
        End If

        If Me.quantityTextEdit.Text = "" Then
            MessageBox.Show("You must enter a quantity.")
            Me.quantityTextEdit.Focus()
            Return False
        End If

        If startTimeEdit.Time.Date <> productionDateEdit.DateTime.Date OrElse stopTimeEdit.Time.Date <> productionDateEdit.DateTime.Date Then
            startTimeEdit.Time = New Date(productionDateEdit.DateTime.Date.Year, productionDateEdit.DateTime.Date.Month, productionDateEdit.DateTime.Date.Day, startTimeEdit.Time.Hour, startTimeEdit.Time.Minute, startTimeEdit.Time.Second)
            stopTimeEdit.Time = New Date(productionDateEdit.DateTime.Date.Year, productionDateEdit.DateTime.Date.Month, productionDateEdit.DateTime.Date.Day, stopTimeEdit.Time.Hour, stopTimeEdit.Time.Minute, stopTimeEdit.Time.Second)
        End If
        If DateDiff(DateInterval.Minute, Me.startTimeEdit.Time, Me.stopTimeEdit.Time) < 1 Then
            Me.stopTimeEdit.Time = DateAdd(DateInterval.Day, 1, stopTimeEdit.Time)
        End If
        If productionDateEdit.DateTime.DayOfWeek = DayOfWeek.Saturday AndAlso DateDiff(DateInterval.Hour, Me.startTimeEdit.Time, Me.stopTimeEdit.Time) > 12 OrElse 
                productionDateEdit.DateTime.DayOfWeek <> DayOfWeek.Saturday AndAlso DateDiff(DateInterval.Hour, Me.startTimeEdit.Time, Me.stopTimeEdit.Time) > 10 Then

            If MessageBox.Show(String.Format("The tims stop is more than {0} hours later than the time start.", DateDiff(DateInterval.Hour, Me.startTimeEdit.Time, Me.stopTimeEdit.Time)), "Time Stop", MessageBoxButtons.OKCancel) _
                    = Windows.Forms.DialogResult.Cancel Then
                Me.stopTimeEdit.Time = DateAdd(DateInterval.Day, -1, stopTimeEdit.Time)
                Me.stopTimeEdit.Focus()
                Return False
            End If
        End If

        If Me.shiftLookUpEdit.EditValue Is Nothing OrElse _
                                CType(Me.shiftLookUpEdit.EditValue, String) = Me.shiftLookUpEdit.Properties.NullText Then
            MessageBox.Show("You must select a Shift.")
            Me.shiftLookUpEdit.Focus()
            Return False
        End If

        If Me.machineLookUpEdit.EditValue Is Nothing OrElse _
                                CType(Me.machineLookUpEdit.EditValue, String) = Me.machineLookUpEdit.Properties.NullText Then
            MessageBox.Show("You must select a Machine line.")
            Me.machineLookUpEdit.Focus()
            Return False
        End If

        If Me.saveSimpleButton.Tag Is Nothing Then
            If m_AllowAdd = True Then
                Me.saveSimpleButton.Tag = m_Production.GetNewProductionID()
            Else
                Return False
            End If
        End If

        If String.IsNullOrEmpty(Me.packersTextEdit.Text) Then
            Me.packersTextEdit.EditValue = 0
        End If

        Return True

    End Function

    Public Function SaveRecord(ByVal id As Nullable(Of Integer)) As Boolean

        If m_Production.UpdateProduction(CType(Me.saveSimpleButton.Tag, Integer), Me.productionDateEdit.DateTime, CType(Me.shiftLookUpEdit.EditValue, Integer?), CType(Me.itemLookUpEdit.EditValue, Integer?), _
                                         Utilities.ChangeType(Of Single?)(Me.quantityTextEdit.EditValue), CType(Me.machineLookUpEdit.EditValue, Integer?), Me.startTimeEdit.Time, Me.stopTimeEdit.Time, _
                                         Utilities.ChangeType(Of Single?)(Me.packersTextEdit.EditValue)) <> True Then
            MessageBox.Show("The production record was not updated successfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            Dim productionRow = m_ProductionSession.GetObjectByKey(Of Production)(CType(saveSimpleButton.Tag, Integer), True)          
            For i = productionRow.ReasonCodes.Count - 1 To 0 Step -1
                productionRow.ReasonCodes.Remove(productionRow.ReasonCodes(i))
            Next
            reasonsGridView.SelectAll
            For Each reason In reasonsGridView.GetSelectedRows
                If productionRow.ReasonCodes.Contains(New ReasonCodes() With {.Oid = CInt(reasonsGridView.GetRowCellValue(reason, reasonDescriptionGridColumn))}) = False  then
                    productionRow.ReasonCodes.Add(m_ProductionSession.GetObjectByKey(Of ReasonCodes)(reasonsGridView.GetRowCellValue(reason, reasonDescriptionGridColumn)))
                End If
            Next
            productionRow.Save
        End If

            ' delete record from view if we are updating a record
            Me.productionXPView.Reload()

            Return True

    End Function

    Public Sub PrepareNewRecord()

        Me.saveSimpleButton.Tag = Nothing
        Me.editSimpleButton.Tag = Nothing
        Me.descriptionMemoEdit.Text = Nothing
        Me.shiftLookUpEdit.EditValue = Nothing
        Me.machineLookUpEdit.EditValue = Nothing
        'Date should be saved form last entry
        'Me.productionDateEdit.DateTime = Today
        Me.itemLookUpEdit.EditValue = Nothing
        Me.packersTextEdit.Text = Nothing
        Me.quantityTextEdit.Text = Nothing
        uomTextEdit.Text = Nothing
        m_ReasonsCollection.Clear
        reasonsGridControl.DataSource = m_ReasonsCollection

        Me.startTimeEdit.Time = Now
        Me.stopTimeEdit.Time = DateAdd(DateInterval.Minute, 5, Now)

        Me.productionDateEdit.Focus()

    End Sub

    Public Sub FillProductionView()

        Dim productionViewCriteria As New CriteriaOperatorCollection

        If CType(Me.fromFilterDateEdit.EditValue, Date?).HasValue Then
            productionViewCriteria.Add(New BinaryOperator(Production.Fields.ProdMainDate.PropertyName, CType(Me.fromFilterDateEdit.EditValue, Date), BinaryOperatorType.GreaterOrEqual))
        End If
        If CType(Me.toFilterDateEdit.EditValue, Date?).HasValue Then
            productionViewCriteria.Add(New BinaryOperator(Production.Fields.ProdMainDate.PropertyName, CType(Me.toFilterDateEdit.EditValue, Date), BinaryOperatorType.LessOrEqual))
        End If
        If CType(Me.customerFilterLookUpEdit.EditValue, Integer?).HasValue Then
            productionViewCriteria.Add(New BinaryOperator(Production.Fields.ProdMainItemID.ItemCustomerID.CustomerID.PropertyName, CType(Me.customerFilterLookUpEdit.EditValue, Integer), BinaryOperatorType.Equal))
        End If
        If CType(Me.shiftFilterLookUpEdit.EditValue, Integer?).HasValue Then
            productionViewCriteria.Add(New BinaryOperator(Production.Fields.ProdMainShift.ShiftID.PropertyName, CType(Me.shiftFilterLookUpEdit.EditValue, Integer), BinaryOperatorType.Equal))
        End If
        If CType(Me.machineFilterLookUpEdit.EditValue, Integer?).HasValue Then
            productionViewCriteria.Add(New BinaryOperator(Production.Fields.ProdMainMachineLine.MachineLineID.PropertyName, CType(Me.machineFilterLookUpEdit.EditValue, Integer), BinaryOperatorType.Equal))
        End If
        If CType(Me.itemFilterLookUpEdit.EditValue, Integer?).HasValue Then
            productionViewCriteria.Add(New BinaryOperator(Production.Fields.ProdMainItemID.ItemID.PropertyName, CType(Me.itemFilterLookUpEdit.EditValue, Integer), BinaryOperatorType.Equal))
        End If

        Me.productionXPView.Criteria = GroupOperator.And(productionViewCriteria)

    End Sub

    Private Sub editSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editSimpleButton.Click

        With Me.productionGridView
            'enters the row handle for the editing record in the edit button tag property
            If .SelectedRowsCount = 1 Then
                Dim rowHandle As Integer = .GetSelectedRows()(0)
                m_ProductionSession.DropIdentityMap
                Me.editSimpleButton.Tag = rowHandle

                Dim productionRecord As Production = m_ProductionSession.GetObjectByKey(Of Production)(CType(.GetRowCellValue(rowHandle, Me.idGridColumn), Integer))
                Me.saveSimpleButton.Tag = productionRecord.ProdMainID
                Me.productionDateEdit.DateTime = productionRecord.ProdMainDate
                Me.itemLookUpEdit.EditValue = productionRecord.ProdMainItemID.ItemID
                Me.shiftLookUpEdit.EditValue = productionRecord.ProdMainShift.ShiftID
                Me.startTimeEdit.Time = productionRecord.ProdMainTimeStart
                Me.stopTimeEdit.Time = productionRecord.ProdMainTimeStop
                Me.descriptionMemoEdit.EditValue = .GetRowCellValue(rowHandle, Me.descriptionGridColumn)
                Me.quantityTextEdit.EditValue = productionRecord.ProdMainQuantity
                uomTextEdit.Text = productionRecord.ProdMainItemID.strUnitOfMeasure
                Me.machineLookUpEdit.EditValue = productionRecord.ProdMainMachineLine.MachineLineID
                Me.packersTextEdit.EditValue = productionRecord.ProdMainPackers
                m_ReasonsCollection.Clear
                For Each reason In productionRecord.ReasonCodes
                    m_ReasonsCollection.Add(New ReasonIDs() With {.Oid = reason.Oid})
                Next
            End If
        End With

    End Sub

    Private Sub deleteRepositoryItemButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteRepositoryItemButtonEdit.Click

        If MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                = Windows.Forms.DialogResult.Yes Then
            If m_Production.DeleteProduction(CType(productionGridView.GetFocusedRowCellValue(Me.idGridColumn), Integer), m_ProductionSession) <> True Then
                MessageBox.Show("The production record was not deleted successfully.", "Error Encountered", MessageBoxButtons.OK, _
                        MessageBoxIcon.Error)
                Exit Sub
            End If
        End If

        Me.productionXPView.Reload()

    End Sub

    Private Sub customerFilterLookUpEdit_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles customerFilterLookUpEdit.Validated

        If CType(Me.customerFilterLookUpEdit.EditValue, String) = Me.customerFilterLookUpEdit.Properties.NullText OrElse String.IsNullOrEmpty(CStr(Me.customerFilterLookUpEdit.EditValue)) Then
            Me.itemsFilterXPView.Filter = Nothing
        Else
            Me.itemsFilterXPView.Filter = New BinaryOperator("CustomerID", CStr(customerFilterLookUpEdit.EditValue), BinaryOperatorType.Equal)
        End If

    End Sub

    Private Sub clearSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearSimpleButton.Click

        SetDefaultViewFilter()
        Me.fromFilterDateEdit.EditValue = Nothing
        Me.toFilterDateEdit.EditValue = Nothing
        FillProductionView()

    End Sub

    Private Sub filterSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filterSimpleButton.Click

        FillProductionView()

    End Sub

    Private Sub cancelSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelSimpleButton.Click

        PrepareNewRecord()

    End Sub

    Public Function CheckPermissions() As Boolean

        Try
            Dim permission As SPG.UserPermissionsRow = New UserPermissionsBLL().GetUserPermissionsByUserName(My.Settings.UserName, "Production Form")(0)

            Select Case permission.PermissionLevel

                Case "FULL", "Full"
                    m_AllowAdd = True
                    Me.editSimpleButton.Enabled = True
                    Me.deleteGridColumn.Visible = True
                Case "ADD", "Add"
                    m_AllowAdd = True
                    Me.editSimpleButton.Enabled = True
                    Me.deleteGridColumn.Visible = False
                Case "NONE", "None"
                    MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Me.Close()
                    Return False
                Case "VIEW", "View"
                    Me.editSimpleButton.Enabled = False
                    Me.deleteGridColumn.Visible = False
                Case "EDIT", "Edit"
                    Me.editSimpleButton.Enabled = True
                    Me.deleteGridColumn.Visible = False
                Case "VIEW ASSIGNED"
                    Me.editSimpleButton.Enabled = False
                    Me.deleteGridColumn.Visible = False
                    FilterAssignedCustomers()
                Case "EDIT ASSIGNED"
                    Me.editSimpleButton.Enabled = True
                    Me.deleteGridColumn.Visible = False
                    FilterAssignedCustomers()
                Case Else
                    MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    Return False
            End Select
            Return True
        Catch ex As InvalidOperationException
            Return False
        End Try

    End Function

    Private Sub FilterAssignedCustomers()

        Me.productionXPView.Filter = New InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(m_ProductionSession))
        Me.customersXPView.Criteria = GroupOperator.And(New BinaryOperator(Customers.Fields.Inactive.PropertyName, False), _
                                                             New InOperator(Customers.Fields.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ProductionSession)))
        Me.itemsFilterXPView.Criteria = GroupOperator.And(New InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ProductionSession)), _
                                                           New InOperator(Items.Fields.ItemType.PropertyName, New String() {"FG", "IG"}),
                                                           New BinaryOperator(Items.Fields.Inactive.PropertyName, False, BinaryOperatorType.Equal))
        Me.itemsXPView.Criteria = GroupOperator.And(New InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ProductionSession)), _
                                                           New InOperator(Items.Fields.ItemType.PropertyName, New String() {"FG", "IG"}),
                                                           New BinaryOperator(Items.Fields.Inactive.PropertyName, False, BinaryOperatorType.Equal))

    End Sub

    Private Sub shiftLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles shiftLookUpEdit.EditValueChanged

        Select Case shiftLookUpEdit.Text
            Case "1"
                startTimeEdit.Time = New Date(productionDateEdit.DateTime.Year, productionDateEdit.DateTime.Month, productionDateEdit.DateTime.Day, 9, 0, 0)
                stopTimeEdit.Time = DateAdd(DateInterval.Hour, 8, startTimeEdit.Time)
            Case "2"
                startTimeEdit.Time = New Date(productionDateEdit.DateTime.Year, productionDateEdit.DateTime.Month, productionDateEdit.DateTime.Day, 17, 0, 0)
                stopTimeEdit.Time = New Date(productionDateEdit.DateTime.Year, productionDateEdit.DateTime.Month, productionDateEdit.DateTime.Day, 1, 0, 0)
            Case "3"
                startTimeEdit.Time = New Date(productionDateEdit.DateTime.Year, productionDateEdit.DateTime.Month, productionDateEdit.DateTime.Day, 1, 0, 0)
                stopTimeEdit.Time = DateAdd(DateInterval.Hour, 8, startTimeEdit.Time)
        End Select        

    End Sub

    Public Class ReasonIDs

        Public Property Oid As Integer

    End Class

    Private Sub deleteReasonRepositoryItemButtonEdit_Click(sender As Object, e As EventArgs) Handles deleteReasonRepositoryItemButtonEdit.Click

        reasonsGridView.DeleteRow(reasonsGridView.FocusedRowHandle)

    End Sub

    Private Sub reasonsGridControl_ProcessGridKey(sender As Object, e As KeyEventArgs) Handles reasonsGridControl.ProcessGridKey

        If e.KeyCode = Keys.Tab  Then
            If e.Modifiers = Keys.None AndAlso reasonsGridView.IsNewItemRow(reasonsGridView.FocusedRowHandle) AndAlso reasonsGridView.FocusedColumn.VisibleIndex = reasonsGridView.VisibleColumns.Count - 1 Then
                If reasonsGridView.IsEditing Then
                    reasonsGridView.CloseEditor 
                End If

                If reasonsGridView.GetFocusedRow Is Nothing Then
                    SelectNextControl(reasonsGridControl, True, True, True, True)
                    reasonsGridView.FocusedRowHandle = 0
                    reasonsGridView.FocusedColumn = reasonsGridView.VisibleColumns(1)
                    e.Handled = True
                End If
            End If
        End If

    End Sub

End Class