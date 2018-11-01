Imports DevExpress.XtraEditors
Imports DevExpress.Data.Filtering
Imports DXDAL.SPGData
Imports DevExpress.Xpo

Public Class InventoryAdjustmentXtraForm

    Private m_AllowAdd As Boolean = False
    Private m_Items As ItemsBLL
    Private m_Customers As CustomersBLL
    Private m_Adjustment As InventoryAdjustmentBLL

    Private Sub itemLookUpEdit_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemLookUpEdit.Validated

        If itemLookUpEdit.EditValue Is Nothing Then
            Return
        End If

        Me.descriptionMemoEdit.Text = ItemsBLL.GetDescriptionByItemID(CType(Me.itemLookUpEdit.EditValue, Integer?))
        Me.customerLookUpEdit.EditValue = m_Items.GetCustomerIDByItemID(CType(Me.itemLookUpEdit.EditValue, Integer))

        If locationLookUpEdit.EditValue IsNot Nothing Then
            originalQtyTextEdit.EditValue = ItemsBLL.GetQtyOnHandByID(Session.DefaultSession, CType(itemLookUpEdit.EditValue, Integer), CType(locationLookUpEdit.EditValue, Integer))
        End If

        FilterLpns()

    End Sub

    Private Sub locationLookupEdit_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles locationLookUpEdit.Validated

        If itemLookUpEdit.EditValue IsNot Nothing Then
            originalQtyTextEdit.EditValue = ItemsBLL.GetQtyOnHandByID(Session.DefaultSession, CType(itemLookUpEdit.EditValue, Integer), CType(locationLookUpEdit.EditValue, Integer))
        End If

    End Sub

    Private Sub editSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editSimpleButton.Click

        With Me.adjustmentGridView
            'enters the rowhandle for the editing record in the editbutton tag property
            If .SelectedRowsCount = 1 Then
                Dim rowHandle As Integer = .GetSelectedRows()(0)
                Me.editSimpleButton.Tag = rowHandle

                'Dim inventoryRecord As SPG.InventoryRow = m_Inventory.GetInventoryByID(.GetRowCellValue(rowHandle, Me.idGridColumn)).Rows(0)
                Me.saveSimpleButton.Tag = .GetRowCellValue(rowHandle, Me.idGridColumn)
                Me.adjustmentDateEdit.DateTime = CType(.GetRowCellValue(rowHandle, Me.dateGridColumn), Date)
                Me.itemLookUpEdit.EditValue = .GetRowCellValue(rowHandle, Me.itemIDGridColumn)
                If IsDBNull(.GetRowCellValue(rowHandle, Me.descriptionGridColumn)) = False AndAlso .GetRowCellValue(rowHandle, Me.descriptionGridColumn) Is Nothing = False Then
                    Me.descriptionMemoEdit.Text = .GetRowCellValue(rowHandle, Me.descriptionGridColumn).ToString
                End If
                Me.originalQtyTextEdit.EditValue = .GetRowCellValue(rowHandle, Me.originalQuantityGridColumn)
                Me.newQtyTextEdit.EditValue = .GetRowCellValue(rowHandle, Me.newQtyGridColumn)
                Me.customerLookUpEdit.EditValue = .GetRowCellValue(rowHandle, Me.customerIDGridColumn)
                Me.reasonMemoExEdit.EditValue = .GetRowCellValue(rowHandle, Me.reasonGridColumn)
                locationLookUpEdit.EditValue = .GetRowCellValue(rowHandle, locationGridColumn)
                FilterLpns()
            End If
        End With

    End Sub

    Private Sub cancelSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelSimpleButton.Click

        PrepareNewRecord()

    End Sub

    Private Sub filterSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filterSimpleButton.Click

        FillAdjustmentView()

    End Sub

    Private Sub customerLookUpEdit_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles customerLookUpEdit.Validated

        If CType(Me.customerLookUpEdit.EditValue, String) = Me.customerLookUpEdit.Properties.NullText OrElse String.IsNullOrEmpty(CStr(Me.customerLookUpEdit.EditValue)) Then
            Me.itemsXPView.Filter = Nothing
        Else
            Me.itemsXPView.Filter = New BinaryOperator("CustomerID", CStr(customerLookUpEdit.EditValue), BinaryOperatorType.Equal)
        End If

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
        FillAdjustmentView()

    End Sub

    Private Sub saveSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveSimpleButton.Click

        If ValidateRecord() Then
            If SaveRecord(CType(Me.saveSimpleButton.Tag, Integer?)) Then
                PrepareNewRecord()
            End If
        End If

    End Sub

    Private Sub InventoryAdjustmentXtraForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Me.editSimpleButton.Tag IsNot Nothing Then
            MessageBox.Show("You must first save or cancel the changes")
            e.Cancel = True
        End If

    End Sub

    Private Sub InventoryAdjustmentXtraForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Cursor = Cursors.WaitCursor

        CheckPermissions()

        m_Items = New ItemsBLL
        m_Customers = New CustomersBLL
        m_Adjustment = New InventoryAdjustmentBLL

        PrepareNewRecord()

        SetDefaultViewFilter()
        FillAdjustmentView()

        FilterLpns()

        Me.Cursor = Cursors.Default

    End Sub

    Public Sub PrepareNewRecord()

        Me.saveSimpleButton.Tag = Nothing
        Me.editSimpleButton.Tag = Nothing
        Me.descriptionMemoEdit.Text = Nothing
        If Now.TimeOfDay < New TimeSpan(9, 0, 0) Then
            adjustmentDateEdit.DateTime = DateAdd(DateInterval.Day, -1, Today)
        Else
            adjustmentDateEdit.DateTime = Today
        End If
        Me.itemLookUpEdit.EditValue = Nothing
        Me.originalQtyTextEdit.Text = Nothing
        Me.newQtyTextEdit.Text = Nothing
        Me.customerLookUpEdit.EditValue = Nothing
        Me.reasonMemoExEdit.EditValue = Nothing
        locationLookUpEdit.EditValue = UsersBLL.GetUsersLocalLocation(Session.DefaultSession, My.Settings.UserName).Oid

    End Sub

    Public Sub SetDefaultViewFilter()

        'Set the from filter to the sunday of this week
        Me.fromFilterDateEdit.DateTime = DateAdd(DateInterval.Day, (Weekday(Today) - 1) * -1, Today)
        Me.toFilterDateEdit.DateTime = Today
        Me.customerFilterLookUpEdit.EditValue = Nothing
        Me.itemFilterLookUpEdit.EditValue = Nothing

    End Sub

    Public Sub FillAdjustmentView()


        Dim inventoryViewCriteria As New CriteriaOperatorCollection

        If CType(Me.fromFilterDateEdit.EditValue, Date?).HasValue Then
            inventoryViewCriteria.Add(New BinaryOperator(InventoryAdjustment.Fields.AdjustmentDate.PropertyName, CType(Me.fromFilterDateEdit.EditValue, Date), BinaryOperatorType.GreaterOrEqual))
        End If
        If CType(Me.toFilterDateEdit.EditValue, Date?).HasValue Then
            inventoryViewCriteria.Add(New BinaryOperator(InventoryAdjustment.Fields.AdjustmentDate.PropertyName, CType(Me.toFilterDateEdit.EditValue, Date), BinaryOperatorType.LessOrEqual))
        End If
        If CType(Me.customerFilterLookUpEdit.EditValue, Integer?).HasValue Then
            inventoryViewCriteria.Add(New BinaryOperator(InventoryAdjustment.Fields.AdjustmentItem.ItemCustomerID.CustomerID.PropertyName, CType(Me.customerFilterLookUpEdit.EditValue, Integer), BinaryOperatorType.Equal))
        End If
        If CType(Me.itemFilterLookUpEdit.EditValue, Integer?).HasValue Then
            inventoryViewCriteria.Add(New BinaryOperator(InventoryAdjustment.Fields.AdjustmentItem.ItemID.PropertyName, CType(Me.itemFilterLookUpEdit.EditValue, Integer), BinaryOperatorType.Equal))
        End If

        Me.inventoryXPView.Criteria = GroupOperator.And(inventoryViewCriteria)


        'Me.adjustmentGridControl.DataSource = m_Adjustment.GetAdjustmentView(CType(Me.fromFilterDateEdit.EditValue, Date?), CType(Me.toFilterDateEdit.EditValue, Date?), _
        '                                                                     CType(Me.customerFilterLookUpEdit.EditValue, Integer?), CType(Me.itemFilterLookUpEdit.EditValue, Integer?))

    End Sub

    Public Function ValidateRecord() As Boolean

        If Me.itemLookUpEdit.EditValue Is Nothing OrElse CType(Me.itemLookUpEdit.EditValue, String) = Me.itemLookUpEdit.Properties.NullText Then
            MessageBox.Show("You must select a Item Code.")
            Me.itemLookUpEdit.Focus()
            Return False
        End If

        If Me.newQtyTextEdit.Text = String.Empty Then
            MessageBox.Show("You must enter a new quantity.")
            Me.newQtyTextEdit.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(Convert.ToString(Me.reasonMemoExEdit.EditValue)) = True Then
            If MessageBox.Show(String.Format("The reason field is empty. {0} Do you want to save the record.", vbCrLf), "Save Adjustment", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) _
                    = Windows.Forms.DialogResult.No Then
                Return False
            Else
                Return True
            End If
        End If

        If locationLookUpEdit.EditValue Is Nothing OrElse CType(locationLookUpEdit.EditValue, String) = locationLookUpEdit.Properties.NullText Then
            MessageBox.Show("You must select a Location.")
            locationLookUpEdit.Focus()
            Return False
        End If

        If Me.saveSimpleButton.Tag Is Nothing Then
            If m_AllowAdd = True Then
                Me.saveSimpleButton.Tag = InventoryAdjustmentBLL.GetNewInventoryAdjustmentID()
            Else
                Return False
            End If
        End If

        Return True

    End Function

    Public Function SaveRecord(ByVal id As Nullable(Of Integer)) As Boolean

        If Me.saveSimpleButton.Tag Is Nothing Then
            If m_AllowAdd = True Then
                Me.saveSimpleButton.Tag = InventoryAdjustmentBLL.GetNewInventoryAdjustmentID
            Else
                Return False
            End If
        End If

        If m_Adjustment.UpdateInventoryAdjustment(CType(Me.saveSimpleButton.Tag, Integer), Me.adjustmentDateEdit.DateTime, CType(Me.customerLookUpEdit.EditValue, Integer),
                                                  CType(Me.itemLookUpEdit.EditValue, Integer), CType(Me.originalQtyTextEdit.EditValue, Single),
                                                  CType(Me.newQtyTextEdit.EditValue, Single), Convert.ToString(Me.reasonMemoExEdit.EditValue), CType(lpnLookUpEdit.EditValue, Integer),
                                                  originalLotTextEdit.Text, newLotTextEdit.Text, Utilities.ChangeType(Of Integer?)(lpnLookUpEdit.EditValue)) <> True Then
            MessageBox.Show("The adjustment record was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        inventoryXPView.Reload()

        Return True

    End Function

    Private Sub deleteRepositoryItemButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteRepositoryItemButtonEdit.Click

        If MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Return
        End If

        If InventoryAdjustmentBLL.DeleteInventoryAdjustment(CType(Me.adjustmentGridView.GetFocusedRowCellValue(Me.idGridColumn), Integer)) <> True Then
            MessageBox.Show("The adjustment record was not deleted succesfully.", "Error Encountered", MessageBoxButtons.OK, _
                    MessageBoxIcon.Error)
            Exit Sub
        End If

        inventoryXPView.Reload()

    End Sub

    Private Sub adjustmentGridView_CustomUnboundColumnData(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles adjustmentGridView.CustomUnboundColumnData

        If Not IsDBNull(adjustmentGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.itemGridColumn)) Then
            If e.Column.Name = adjustmentGridColumn.Name Then
                If IsDBNull(adjustmentGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.originalQuantityGridColumn)) OrElse IsDBNull(adjustmentGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.newQtyGridColumn)) Then
                    Exit Sub
                End If
                e.Value = CType(adjustmentGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.newQtyGridColumn), Integer) - CType(adjustmentGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.originalQuantityGridColumn), Integer)
            End If
        End If

    End Sub

    Private Sub adjustmentGridView_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles adjustmentGridView.RowCellStyle

        If e.Column.Name = adjustmentGridColumn.Name Then
            If IsDBNull(adjustmentGridView.GetRowCellValue(e.RowHandle, adjustmentGridColumn)) OrElse CType(adjustmentGridView.GetRowCellValue(e.RowHandle, adjustmentGridColumn), Integer) >= 0 Then
                e.Appearance.ForeColor = Color.Black
            Else
                e.Appearance.ForeColor = Color.Red
            End If
        End If

    End Sub

    Public Function CheckPermissions() As Boolean

        Try
            Dim permission As SPG.UserPermissionsRow = New UserPermissionsBLL().GetUserPermissionsByUserName(My.Settings.UserName, "Production Entries")(0)

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

        Me.inventoryXPView.Filter = New InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(XpoDefault.Session))
        Me.customersXPView.Criteria = GroupOperator.And(New BinaryOperator(Customers.Fields.Inactive.PropertyName, False),
                                                             New InOperator(Customers.Fields.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(XpoDefault.Session)))
        Me.customersFilterXPView.Criteria = GroupOperator.And(New BinaryOperator(Customers.Fields.Inactive.PropertyName, False),
                                                            New InOperator(Customers.Fields.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(XpoDefault.Session)))
        Me.itemsFilterXPView.Criteria = New InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(XpoDefault.Session))
        Me.itemsXPView.Criteria = GroupOperator.And(New BinaryOperator(Items.Fields.Inactive.PropertyName, False), New InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(XpoDefault.Session)))

    End Sub

    Private Sub FilterLpns()

        Dim lpnViewCriteria As New CriteriaOperatorCollection

        If CType(Me.locationLookUpEdit.EditValue, Date?).HasValue Then
            lpnViewCriteria.Add(New BinaryOperator(InventoryAdjustment.Fields.AdjustmentDate.PropertyName, CType(Me.fromFilterDateEdit.EditValue, Date), BinaryOperatorType.GreaterOrEqual))
        End If
        If CType(Me.customerFilterLookUpEdit.EditValue, Integer?).HasValue Then
            lpnViewCriteria.Add(New BinaryOperator(InventoryAdjustment.Fields.AdjustmentItem.ItemCustomerID.CustomerID.PropertyName, CType(Me.customerFilterLookUpEdit.EditValue, Integer), BinaryOperatorType.Equal))
        End If
        If CType(Me.itemFilterLookUpEdit.EditValue, Integer?).HasValue Then
            lpnViewCriteria.Add(New BinaryOperator(InventoryAdjustment.Fields.AdjustmentItem.ItemID.PropertyName, CType(Me.itemFilterLookUpEdit.EditValue, Integer), BinaryOperatorType.Equal))
        End If

        Me.lpnXpView.Criteria = GroupOperator.And(lpnViewCriteria)

    End Sub

    Private Sub recordGroupControl_Paint(sender As Object, e As PaintEventArgs) Handles recordGroupControl.Paint

    End Sub
End Class