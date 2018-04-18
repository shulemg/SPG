Imports System
Imports DevExpress.XtraEditors
Imports System.Text
Imports DevExpress.Data.Filtering
Imports DXDAL.SPGData
Imports DevExpress.Xpo
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo


Public Class InventoryXtraForm

    Private WithEvents m_timer As New Timer
    Private m_AllowAdd As Boolean = False
    Private m_Customers As CustomersBLL
    Private m_Inventory As InventoryBLL
    'Private m_InventorySession As Session
    Private m_InventoryUOW As UnitOfWork
    Private m_Items As ItemsBLL
    Private m_LPNBaseNumber As Integer?
    Private ReadOnly m_PoolItemQtyUsed As ArrayList = New ArrayList()
    Private m_PoolQuantityUsed As Double
    Private m_SavedRecord As Inventory = Nothing

    Private Sub addLotCodeSimpleButton_Click(sender As Object, e As EventArgs) Handles addLotCodeSimpleButton.Click

        If ValidateRecord() Then

            Try
                If palletNumberTextEdit.EditValue Is Nothing OrElse CInt(palletNumberTextEdit.EditValue) = 0 Then
                    palletNumberTextEdit.EditValue = InventoryBLL.GetNewPalletNumber(m_InventoryUOW, CDate(Format(inventoryDateEdit.DateTime, "D")), CType(itemLookUpEdit.EditValue, Integer),
                                                                                    Utilities.ChangeType(Of Integer?)(shiftLookUpEdit.EditValue))
                End If
                If SaveRecord() Then
                    'Dim inventoryRecord As Inventory = InventoryBLL.GetInventoryRecord(m_InventoryUOW, CType(saveSimpleButton.Tag, Integer), True)
                    If m_SavedRecord.LPNNumber Is Nothing Then
                        If m_LPNBaseNumber.HasValue = False Then
                            m_LPNBaseNumber = LPNLabel.GetNextLPNNumber(m_SavedRecord.InventoryItemID.ItemCustomerID)
                        End If
                        m_SavedRecord.LPNNumber = m_LPNBaseNumber
                        m_SavedRecord.Save()
                    End If
                    m_InventoryUOW.CommitChanges()
                End If
            Catch ex As Exception
                m_InventoryUOW.RollbackTransaction()
                MessageBox.Show(String.Format("There was an error while trying to save the current record, no changes were saved.{0}{1}", vbCrLf, ex.Message), "Saving Error")
            Finally
                saveSimpleButton.Tag = Nothing
                m_SavedRecord = Nothing
                itemLookUpEdit.Properties.Tag = Nothing
                itemLookUpEdit.Properties.ReadOnly = True
                lotTextEdit.EditValue = Nothing
                quantityTextEdit.EditValue = Nothing
                quantityTextEdit.Properties.Tag = Nothing
                noteMemoEdit.EditValue = Nothing
                productionProjectDetailXpCollection.Criteria = New BinaryOperator(ProductionProjectDetails.Fields.Production.InventoryID.PropertyName, 0, BinaryOperatorType.Equal)
                projectDetailsGridView.OptionsBehavior.Editable = False
                inventoryXPView.Reload()
            End Try
        End If

    End Sub

    Private Sub cancelSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelSimpleButton.Click

        PrepareNewRecord()

    End Sub

    Private Sub clearSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearSimpleButton.Click

        SetDefaultViewFilter()
        fromFilterDateEdit.EditValue = Nothing
        toFilterDateEdit.EditValue = Nothing
        FillInventoryView()

    End Sub

    Private Sub customerFilterLookUpEdit_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles customerFilterLookUpEdit.Validated

        If CType(customerFilterLookUpEdit.EditValue, String) = customerFilterLookUpEdit.Properties.NullText OrElse String.IsNullOrEmpty(CStr(customerFilterLookUpEdit.EditValue)) Then
            itemsFilterXPView.Filter = Nothing
        Else
            itemsFilterXPView.Filter = New BinaryOperator("CustomerID", CStr(customerFilterLookUpEdit.EditValue), BinaryOperatorType.Equal)
        End If

    End Sub

    Private Sub deleteRepositoryItemButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteRepositoryItemButtonEdit.Click

        If MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
                = Windows.Forms.DialogResult.Yes Then
            If InventoryBLL.DeleteInventory(m_InventoryUOW, CType(inventoryGridView.GetFocusedRowCellValue(idGridColumn), Integer)) <> True Then
                MessageBox.Show("The inventory record was not deleted succesfully.", "Error Encountered", MessageBoxButtons.OK,
                        MessageBoxIcon.Error)
                Exit Sub
            End If
            m_InventoryUOW.CommitChanges()
        End If

        inventoryXPView.Reload()

    End Sub

    Private Sub editSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editSimpleButton.Click

        With inventoryGridView
            'enters the rowhandle for the editing record in the edit button tag property
            If .SelectedRowsCount = 1 Then
                Dim rowHandle As Integer = .GetSelectedRows()(0)
                m_InventoryUOW.DropIdentityMap()

                Dim inventoryRecord As Inventory = InventoryBLL.GetInventoryRecord(m_InventoryUOW, CType(.GetRowCellValue(rowHandle, idGridColumn), Integer))
                If inventoryRecord.Shipment Is Nothing Then
                    editSimpleButton.Tag = rowHandle

                    saveSimpleButton.Tag = inventoryRecord.InventoryID
                    inventoryDateEdit.DateTime = inventoryRecord.InventoryDate
                    itemLookUpEdit.EditValue = inventoryRecord.InventoryItemID.ItemID
                    itemLookUpEdit.Properties.Tag = inventoryRecord.InventoryItemID.ItemID
                    descriptionMemoEdit.EditValue = .GetRowCellValue(rowHandle, descriptionGridColumn)
                    onHandTextEdit.EditValue = ItemsBLL.GetQtyOnHandByID(m_InventoryUOW, inventoryRecord.InventoryItemID.ItemID, UsersBLL.GetUsersLocalLocation(m_InventoryUOW, My.Settings.UserName).Oid)
                    quantityTextEdit.EditValue = inventoryRecord.InventoryQuantity
                    quantityTextEdit.Properties.Tag = inventoryRecord.InventoryQuantity
                    palletsTextEdit.EditValue = inventoryRecord.InventoryPallets
                    lotTextEdit.EditValue = inventoryRecord.Lot
                    poTextEdit.EditValue = inventoryRecord.PO
                    shiftLookUpEdit.EditValue = inventoryRecord.Shift.ShiftID
                    If inventoryRecord.Pallet > 0 Then
                        palletNumberTextEdit.EditValue = inventoryRecord.Pallet
                    Else
                        palletNumberTextEdit.EditValue = Nothing
                    End If
                    expirationDateEdit.EditValue = inventoryRecord.ExpirationDate
                    m_LPNBaseNumber = inventoryRecord.LPNNumber
                    noteMemoEdit.EditValue = inventoryRecord.Note
                    expirationDateEdit.Properties.EditFormat.FormatString = CustomersBLL.GetExpirationDateFormat(m_Items.GetCustomerIDByItemID(inventoryRecord.InventoryItemID.ItemID))
                    expirationDateEdit.Properties.DisplayFormat.FormatString = CustomersBLL.GetExpirationDateFormat(m_Items.GetCustomerIDByItemID(inventoryRecord.InventoryItemID.ItemID))
                    poolDetailsXpCollection.Criteria = New BinaryOperator(PoolBom.Fields.PoolBomFiniGoodID.ItemID.PropertyName, inventoryRecord.InventoryItemID.ItemID, BinaryOperatorType.Equal)
                    UpdatePoolDetailsXpViewCriteria()
                    UpdateBomPoolUsed()
                    productionProjectDetailXpCollection.Criteria = New BinaryOperator(ProductionProjectDetails.Fields.Production.InventoryID.PropertyName, inventoryRecord.InventoryID, BinaryOperatorType.Equal)
                    projectDetailsGridView.OptionsBehavior.Editable = True
                    colUnitsProduced.OptionsColumn.ReadOnly = False
                Else
                    MessageBox.Show("The selected record can't be edited, it was already shipped.")
                End If
            End If
        End With

    End Sub

    Private Sub filterByPalletSimpleButton_Click(sender As Object, e As EventArgs) Handles filterByPalletSimpleButton.Click

        Dim inventoryViewCriteria As New CriteriaOperatorCollection

        If CType(fromFilterDateEdit.EditValue, Date?).HasValue Then
            inventoryViewCriteria.Add(New BinaryOperator(Inventory.Fields.InventoryDate.PropertyName, CType(fromFilterDateEdit.EditValue, Date), BinaryOperatorType.GreaterOrEqual))
        End If
        If CType(toFilterDateEdit.EditValue, Date?).HasValue Then
            inventoryViewCriteria.Add(New BinaryOperator(Inventory.Fields.InventoryDate.PropertyName, CType(toFilterDateEdit.EditValue, Date), BinaryOperatorType.LessOrEqual))
        End If
        If CType(customerFilterLookUpEdit.EditValue, Integer?).HasValue Then
            inventoryViewCriteria.Add(New BinaryOperator(Inventory.Fields.InventoryItemID.ItemCustomerID.CustomerID.PropertyName,
                                                         CType(customerFilterLookUpEdit.EditValue, Integer), BinaryOperatorType.Equal))
        End If
        If String.IsNullOrEmpty(CStr(lotFilterTextEdit.EditValue)) = False Then
            inventoryViewCriteria.Add(New BinaryOperator(Inventory.Fields.Lot.PropertyName, CType(lotFilterTextEdit.EditValue, String), BinaryOperatorType.Equal))
        End If
        If CType(itemFilterLookUpEdit.EditValue, Integer?).HasValue Then
            inventoryViewCriteria.Add(New BinaryOperator(Inventory.Fields.InventoryItemID.ItemID.PropertyName, CType(itemFilterLookUpEdit.EditValue, Integer), BinaryOperatorType.Equal))
        End If
        If CType(shiftFilterLookUpEdit.EditValue, Integer?).HasValue Then
            inventoryViewCriteria.Add(New BinaryOperator(Inventory.Fields.Shift.PropertyName, CType(shiftFilterLookUpEdit.EditValue, Integer), BinaryOperatorType.Equal))
        End If
        If String.IsNullOrEmpty(CStr(LPNFilterTextEdit.EditValue)) = False Then
            inventoryViewCriteria.Add(New BinaryOperator(Inventory.Fields.LPNNumber.PropertyName, CType(LPNFilterTextEdit.EditValue, Integer), BinaryOperatorType.Equal))
        End If

        Dim inventoryRecord As Inventory = Nothing
        For Each item As Object In m_InventoryUOW.GetObjects(m_InventoryUOW.GetClassInfo(GetType(Inventory)), New GroupOperator(GroupOperatorType.And, inventoryViewCriteria), Nothing, 1, False, False)
            inventoryRecord = TryCast(item, Inventory)
            If inventoryRecord IsNot Nothing Then
                fromFilterDateEdit.EditValue = inventoryRecord.InventoryDate
                toFilterDateEdit.EditValue = inventoryRecord.InventoryDate
                customerFilterLookUpEdit.EditValue = inventoryRecord.InventoryItemID.ItemCustomerID.CustomerID
                lotFilterTextEdit.EditValue = Nothing
                itemFilterLookUpEdit.EditValue = inventoryRecord.InventoryItemID.ItemID
                shiftFilterLookUpEdit.EditValue = inventoryRecord.Shift.ShiftID
                Exit For
            End If
        Next

        If inventoryRecord IsNot Nothing Then
            FillInventoryView(inventoryRecord.Pallet)
        Else
            FillInventoryView()
        End If


    End Sub

    Private Sub filterSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filterSimpleButton.Click

        If toFilterDateEdit.DateTime.TimeOfDay.TotalMinutes = 0 Then
            toFilterDateEdit.DateTime = DateAdd(DateInterval.Minute, 1439, toFilterDateEdit.DateTime)
        End If
        FillInventoryView()

    End Sub

    Private Sub inventoryGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles inventoryGridView.CustomColumnDisplayText

        If e.Column Is expirationDateGridColumn AndAlso IsDate(e.Value) Then
            e.DisplayText = CDate(e.Value).ToString(inventoryGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, expirationDateFormatGridColumn).ToString)
        End If

    End Sub

    Private Sub InventoryXtraForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If editSimpleButton.Tag IsNot Nothing Then
            MessageBox.Show("You must first save or cancel the changes")
            e.Cancel = True
        End If

        If e.Cancel = False Then
            m_InventoryUOW.PurgeDeletedObjects()
        End If

    End Sub

    Private Sub TimerEventProcessor(myObject As Object,
                                           ByVal myEventArgs As EventArgs) _
                                       Handles m_timer.Tick
        If itemLookUpEdit.EditValue Is Nothing Then
            inventoryDateEdit.EditValue = Now
        End If
    End Sub

    Private Sub InventoryXtraForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        m_timer.Interval = CInt(TimeSpan.FromMinutes(1).TotalMilliseconds)
        m_timer.Start()

        Cursor = Cursors.WaitCursor

        CheckPermissions()

        m_InventoryUOW = New UnitOfWork(SPGDataLayer) With {.TrackPropertiesModifications = True, .OptimisticLockingReadBehavior = OptimisticLockingReadBehavior.MergeCollisionThrowException}
        'm_InventorySession = New Session(XpoDefault.Session.DataLayer.DataLayer)
        ProductionProjectDetails.AutoSaveOnEndEdit = True
        For i As Integer = 0 To components.Components.Count - 1
            If TypeOf (components.Components(i)) Is XPView Then
                CType(components.Components(i), XPView).Session = m_InventoryUOW
            ElseIf TypeOf (components.Components(i)) Is XPCollection Then
                CType(components.Components(i), XPCollection).Session = m_InventoryUOW
            End If
        Next

        poolDetailsXpCollection.Criteria = New BinaryOperator(PoolBom.Fields.PoolBomFiniGoodID.ItemID.PropertyName, 0, BinaryOperatorType.Equal)
        UpdatePoolDetailsXpViewCriteria()

        productionProjectDetailXpCollection.Criteria = New BinaryOperator(ProductionProjectDetails.Fields.Production.InventoryID.PropertyName, 0, BinaryOperatorType.Equal)

        m_Items = New ItemsBLL
        m_Customers = New CustomersBLL
        m_Inventory = New InventoryBLL

        PrepareNewRecord()
        'inventoryDateEdit.DateTime = Today

        SetDefaultViewFilter()
        FillInventoryView()

        Cursor = Cursors.Default

    End Sub

    Private Sub itemLookUpEdit_ProcessNewValue(sender As Object, e As DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs) Handles itemLookUpEdit.ProcessNewValue

        Dim itemProducing As Items = ItemsBLL.GetItemByUpc(e.DisplayValue.ToString)

        If itemProducing IsNot Nothing Then
            e.Handled = True
            e.DisplayValue = itemProducing.ItemCode
        Else
            e.Handled = False
        End If

    End Sub

    Private Sub itemLookUpEdit_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemLookUpEdit.Validated


        Dim itemId As Integer? = CType(itemLookUpEdit.EditValue, Integer?)

        If ProjectDetailsBLL.IsItOnSchedule(m_InventoryUOW, itemId) = False AndAlso itemId.HasValue Then
            MessageBox.Show("This item is not in an open project.")
        End If

        descriptionMemoEdit.Text = ItemsBLL.GetDescriptionByItemID(itemId)
        onHandTextEdit.EditValue = ItemsBLL.GetQtyOnHandByID(m_InventoryUOW, itemId, UsersBLL.GetUsersLocalLocation(m_InventoryUOW, My.Settings.UserName).Oid)
        If itemId.HasValue() Then
            expirationDateEdit.Properties.EditFormat.FormatString = CustomersBLL.GetExpirationDateFormat(m_Items.GetCustomerIDByItemID(itemId.Value))
            expirationDateEdit.Properties.DisplayFormat.FormatString = CustomersBLL.GetExpirationDateFormat(m_Items.GetCustomerIDByItemID(itemId.Value))
            poolDetailsXpCollection.Criteria = New BinaryOperator(PoolBom.Fields.PoolBomFiniGoodID.ItemID.PropertyName, itemId.Value, BinaryOperatorType.Equal)
            UpdatePoolDetailsXpViewCriteria()
        End If
        UpdatePallets()

    End Sub

    Private Sub largeLPNSimpleButton_Click(sender As Object, e As EventArgs) Handles largeLPNSimpleButton.Click

        Dim labelText As String = String.Empty

        If ValidateRecord() Then
            Try
                If SaveRecord() Then
                    'Dim inventoryRecord As Inventory = InventoryBLL.GetInventoryRecord(m_InventoryUOW, CType(saveSimpleButton.Tag, Integer), True)
                    If m_LPNBaseNumber.HasValue() Then
                        m_SavedRecord.LPNNumber = m_LPNBaseNumber
                        m_SavedRecord.FullLPNNumber = m_SavedRecord.InventoryItemID.ItemCustomerID.LPNPrefix &
                            Strings.Right("0000000000" & m_LPNBaseNumber.ToString, Len(m_SavedRecord.InventoryItemID.ItemCustomerID.LastLPNNumber.ToString))
                        m_SavedRecord.Save()
                    End If

                    labelText = LPNLabel.CreateLPNLabel(m_InventoryUOW, m_SavedRecord, False)
                    If labelText = String.Empty Then
                        MessageBox.Show("The record was saved without generating an LPN Label")
                    End If
                    m_InventoryUOW.CommitChanges()
                    If String.IsNullOrEmpty(labelText) = False Then
                        LPNLabel.SendLPNLabelToGenericPrinter(CompanySettingsBLL.GetSettings.LPNPrinterName, labelText)
                    End If
                End If
            Catch ex As Exception
                m_InventoryUOW.RollbackTransaction()
                MessageBox.Show(String.Format("There was an error while trying to save the current record, no changes were saved.{0}{1}", vbCrLf, ex.Message), "Saving Error")
            Finally
                PrepareNewRecord()
            End Try
        End If

    End Sub

    'Private Sub palletTicketSimpleButton_Click(sender As System.Object, e As System.EventArgs)

    '    If ValidateRecord() Then
    '        If SaveRecord() Then
    '            PrintPalletTicket(CType(saveSimpleButton.Tag, Integer))
    '            PrepareNewRecord()
    '        End If
    '    End If

    'End Sub

    Private Sub poolDetailsGridView_CustomDrawGroupRow(sender As Object, e As Views.Base.RowObjectCustomDrawEventArgs) Handles poolDetailsGridView.CustomDrawGroupRow

        Try
            Dim info As GridGroupRowInfo = CType(e.Info, GridGroupRowInfo)

            Dim currentPool As PoolBom
            For Each pool As PoolBom In poolDetailsXpCollection
                If pool.ItemPoolID.PoolCode = poolDetailsGridView.GetGroupRowValue(e.RowHandle).ToString Then
                    currentPool = pool
                    info.GroupText = String.Format("{0}:{2} - {1} needed {3}", info.Column.Caption, (currentPool.PoolBomQuantity) * Utilities.ChangeType(Of Integer)(quantityTextEdit.EditValue), info.GroupValueText,
                                           poolDetailsGridView.GetGroupSummaryText(e.RowHandle))
                    Exit For
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub poolDetailsGridView_CustomSummaryCalculate(sender As Object, e As DevExpress.Data.CustomSummaryEventArgs) Handles poolDetailsGridView.CustomSummaryCalculate

        Dim summaryID As Integer = Convert.ToInt32(CType(e.Item, GridSummaryItem).Tag)
        Dim View As GridView = CType(sender, GridView)

        If e.SummaryProcess = CustomSummaryProcess.Start Then
            m_PoolQuantityUsed = 0
        End If

        If e.SummaryProcess = CustomSummaryProcess.Calculate Then
            Select Case summaryID
                Case 1
                    m_PoolQuantityUsed += Convert.ToDouble(e.FieldValue) * Convert.ToDouble(View.GetRowCellValue(e.RowHandle, colItemPoolRatio))
            End Select
        End If

        If e.SummaryProcess = CustomSummaryProcess.Finalize Then
            Select Case summaryID
                Case 1
                    e.TotalValue = m_PoolQuantityUsed
            End Select
        End If

    End Sub

    Private Sub poolDetailsGridView_CustomUnboundColumnData(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles poolDetailsGridView.CustomUnboundColumnData

        Try
            If e.Column.FieldName = "itemQuantityUsedGridColumn" Then
                If e.IsGetData Then
                    While m_PoolItemQtyUsed.Count - 1 < e.ListSourceRowIndex
                        m_PoolItemQtyUsed.Add(0)
                    End While
                    e.Value = m_PoolItemQtyUsed(e.ListSourceRowIndex)
                Else
                    m_PoolItemQtyUsed(e.ListSourceRowIndex) = e.Value
                End If
            End If
            If e.Column.FieldName = "ItemQuantity" Then
                If e.IsGetData Then
                    e.Value = ItemsBLL.GetQtyOnHandByID(m_InventoryUOW, CInt(poolDetailsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, rmItemGridColumn)), UsersBLL.GetUsersLocalLocation(m_InventoryUOW, My.Settings.UserName).Oid)
                End If
            End If
        Catch

        End Try

    End Sub

    Private Sub poolDetailsGridView_ShownEditor(sender As Object, e As EventArgs) Handles poolDetailsGridView.ShownEditor

        poolDetailsGridView.ActiveEditor.Properties.ReadOnly = False

    End Sub

    Private Sub projectDetailsGridView_CellValueChanged(sender As Object, e As Views.Base.CellValueChangedEventArgs) Handles projectDetailsGridView.CellValueChanged

        If e.Column Is colUnitsProduced Then
            Dim item As Items = m_InventoryUOW.GetObjectByKey(Of Items)(itemLookUpEdit.EditValue)
            If item.intUnitsPerCase > 0 Then
                projectDetailsGridView.SetFocusedRowCellValue(colBagsProduced, (CInt(projectDetailsGridView.GetFocusedRowCellValue(colUnitsProduced)) / item.intUnitsPerCase) * item.BagsPerCase)
            End If
            If item.intUnitsPerCase > 0 AndAlso item.intCasesPerPallet > 0 Then
                projectDetailsGridView.SetFocusedRowCellValue(colPalletsProduced, CInt(projectDetailsGridView.GetFocusedRowCellValue(colUnitsProduced)) / item.intUnitsPerCase / item.intCasesPerPallet)
            End If
        End If

    End Sub

    Private Sub quantityTextEdit_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quantityTextEdit.Validated

        UpdatePallets()

    End Sub

    Private Sub saveSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveSimpleButton.Click

        If CType(itemLookUpEdit.Properties.Tag, Integer?) <> CType(itemLookUpEdit.EditValue, Integer?) Then
            m_InventoryUOW.Delete(productionProjectDetailXpCollection)
            m_InventoryUOW.Save(productionProjectDetailXpCollection)
            productionProjectDetailXpCollection.Reload()
        End If

        If ValidateRecord() Then
            Try
                If SaveRecord() Then
                    If m_LPNBaseNumber.HasValue() Then
                        'Dim inventoryRecord As Inventory = InventoryBLL.GetInventoryRecord(m_InventoryUOW, CType(saveSimpleButton.Tag, Integer), True)
                        m_SavedRecord.LPNNumber = m_LPNBaseNumber
                        m_SavedRecord.Save()
                    End If
                    m_InventoryUOW.CommitChanges()
                End If
            Catch ex As Exception
                m_InventoryUOW.RollbackTransaction()
                MessageBox.Show(String.Format("There was an error while trying to save the current record, no changes were saved.{0}{1}", vbCrLf, ex.Message), "Saving Error")
            Finally
                PrepareNewRecord()
            End Try
        End If

    End Sub

    Private Sub ShortLPNLabelSimpleButton_Click(sender As Object, e As EventArgs) Handles LPNLabelSimpleButton.Click

        Dim labelText As String = String.Empty

        If ValidateRecord() Then
            Try
                If SaveRecord() Then
                    'Dim inventoryRecord As Inventory = InventoryBLL.GetInventoryRecord(m_InventoryUOW, CType(saveSimpleButton.Tag, Integer), True)
                    If m_LPNBaseNumber.HasValue() Then
                        m_SavedRecord.LPNNumber = m_LPNBaseNumber
                        m_SavedRecord.Save()
                    End If

                    labelText = LPNLabel.CreateLPNLabel(m_InventoryUOW, m_SavedRecord, True)
                    If labelText = String.Empty Then
                        MessageBox.Show("The record was saved without generating an LPN Label")
                    End If
                    m_InventoryUOW.CommitChanges()
                    If String.IsNullOrEmpty(labelText) = False Then
                        LPNLabel.SendLPNLabelToGenericPrinter(CompanySettingsBLL.GetSettings.LPNPrinterName, labelText)
                    End If
                End If
            Catch ex As Exception
                m_InventoryUOW.RollbackTransaction()
                MessageBox.Show(String.Format("There was an error while trying to save the current record, no changes were saved.{0}{1}", vbCrLf, ex.Message), "Saving Error")
            Finally
                PrepareNewRecord()
            End Try
        End If

    End Sub

    Public Function CheckPermissions() As Boolean

        Try
            Dim permission As SPG.UserPermissionsRow = New UserPermissionsBLL().GetUserPermissionsByUserName(My.Settings.UserName, "Production Entries")(0)

            Select Case permission.PermissionLevel

                Case "FULL", "Full"
                    m_AllowAdd = True
                    editSimpleButton.Enabled = True
                    deleteGridColumn.Visible = True
                    inventoryDateEdit.Enabled = True
                Case "ADD", "Add"
                    m_AllowAdd = True
                    editSimpleButton.Enabled = True
                    deleteGridColumn.Visible = False
                    inventoryDateEdit.Enabled = False
                Case "NONE", "None"
                    MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Close()
                    Return False
                Case "VIEW", "View"
                    editSimpleButton.Enabled = False
                    deleteGridColumn.Visible = False
                    inventoryDateEdit.Enabled = False
                Case "EDIT", "Edit"
                    editSimpleButton.Enabled = True
                    deleteGridColumn.Visible = False
                    inventoryDateEdit.Enabled = False
                Case "VIEW ASSIGNED"
                    editSimpleButton.Enabled = False
                    deleteGridColumn.Visible = False
                    inventoryDateEdit.Enabled = False
                    FilterAssignedCustomers()
                Case "EDIT ASSIGNED"
                    editSimpleButton.Enabled = True
                    deleteGridColumn.Visible = False
                    inventoryDateEdit.Enabled = False
                    FilterAssignedCustomers()
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

    Public Sub FillInventoryView(Optional pallet As Integer? = Nothing)

        Dim inventoryViewCriteria As New CriteriaOperatorCollection

        If CType(fromFilterDateEdit.EditValue, Date?).HasValue Then
            inventoryViewCriteria.Add(New BinaryOperator(Inventory.Fields.InventoryDate.PropertyName, CType(fromFilterDateEdit.EditValue, Date), BinaryOperatorType.GreaterOrEqual))
        End If
        If CType(toFilterDateEdit.EditValue, Date?).HasValue Then
            inventoryViewCriteria.Add(New BinaryOperator(Inventory.Fields.InventoryDate.PropertyName, CType(toFilterDateEdit.EditValue, Date), BinaryOperatorType.LessOrEqual))
        End If
        If CType(customerFilterLookUpEdit.EditValue, Integer?).HasValue Then
            inventoryViewCriteria.Add(New BinaryOperator(Inventory.Fields.InventoryItemID.ItemCustomerID.CustomerID.PropertyName,
                                                         CType(customerFilterLookUpEdit.EditValue, Integer), BinaryOperatorType.Equal))
        End If
        If String.IsNullOrEmpty(CStr(lotFilterTextEdit.EditValue)) = False Then
            inventoryViewCriteria.Add(New BinaryOperator(Inventory.Fields.Lot.PropertyName, CType(lotFilterTextEdit.EditValue, String), BinaryOperatorType.Equal))
        End If
        If CType(itemFilterLookUpEdit.EditValue, Integer?).HasValue Then
            inventoryViewCriteria.Add(New BinaryOperator(Inventory.Fields.InventoryItemID.ItemID.PropertyName, CType(itemFilterLookUpEdit.EditValue, Integer), BinaryOperatorType.Equal))
        End If
        If CType(shiftFilterLookUpEdit.EditValue, Integer?).HasValue Then
            inventoryViewCriteria.Add(New BinaryOperator(Inventory.Fields.Shift.PropertyName, CType(shiftFilterLookUpEdit.EditValue, Integer), BinaryOperatorType.Equal))
        End If
        If String.IsNullOrEmpty(CStr(LPNFilterTextEdit.EditValue)) = False Then
            inventoryViewCriteria.Add(New BinaryOperator(Inventory.Fields.LPNNumber.PropertyName, CType(LPNFilterTextEdit.EditValue, Integer), BinaryOperatorType.Equal))
        End If

        If pallet.HasValue Then
            inventoryViewCriteria.Add(New BinaryOperator(Inventory.Fields.Pallet.PropertyName, pallet.Value, BinaryOperatorType.Equal))
        End If

        inventoryXPView.Criteria = GroupOperator.And(inventoryViewCriteria)

        'Me.inventoryGridControl.DataSource = m_Inventory.GetInventoryView(CType(Me.fromFilterDateEdit.EditValue, Date?), CType(Me.toFilterDateEdit.EditValue, Date?), _
        '                                                                  CType(Me.customerFilterLookUpEdit.EditValue, Integer?), CType(Me.itemFilterLookUpEdit.EditValue, Integer?), _
        '                                                                  CStr(Me.lotFilterTextEdit.EditValue))

    End Sub

    Private Sub FilterAssignedCustomers()

        inventoryXPView.Filter = New InOperator("CustomerID", UsersCustomerBLL.GetAssignedCustomerIDs(m_InventoryUOW))
        customersXPView.Criteria = GroupOperator.And(New BinaryOperator(Customers.Fields.Inactive.PropertyName, False),
                                                             New InOperator(Customers.Fields.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_InventoryUOW)))
        itemsFilterXPView.Criteria = GroupOperator.And(New InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_InventoryUOW)),
                                                           New InOperator(Items.Fields.ItemType.PropertyName, New String() {"FG", "IG"}))
        itemsXPView.Criteria = GroupOperator.And(New InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_InventoryUOW)),
                                                           New InOperator(Items.Fields.ItemType.PropertyName, New String() {"FG", "IG"}), New BinaryOperator(Items.Fields.Inactive.PropertyName, False))

    End Sub

    Private Function OptionalInfoMissing() As Boolean

        Dim msg As StringBuilder = New StringBuilder(String.Empty)

        If palletsTextEdit.Text = String.Empty Then
            msg.Append("Pallets quantity, ")
        End If

        If lotTextEdit.Text = String.Empty Then
            msg.Append("Lot #, ")
        End If

        If shiftLookUpEdit.EditValue Is Nothing OrElse CType(shiftLookUpEdit.EditValue, String) = shiftLookUpEdit.Properties.NullText Then
            msg.Append("Shift, ")
        End If

        If expirationDateEdit.EditValue Is Nothing Then
            msg.Append("Expiration date, ")
        End If

        If msg.Length > 0 Then
            If MessageBox.Show(String.Format("The {0} field/s are empty. {1} Do you want to save the record.", msg.ToString.Substring(0, msg.Length - 2), vbCrLf), "Save Inventory",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                Return True
            End If
        End If

    End Function

    Public Sub PrepareNewRecord()

        saveSimpleButton.Tag = Nothing
        editSimpleButton.Tag = Nothing
        m_SavedRecord = Nothing
        descriptionMemoEdit.Text = Nothing
        onHandTextEdit.Text = Nothing
        'If Now.TimeOfDay < New TimeSpan(9, 0, 0) Then
        'inventoryDateEdit.DateTime = DateAdd(DateInterval.Day, -1, Today)
        'Else
        inventoryDateEdit.DateTime = Now
        'End If
        itemLookUpEdit.EditValue = Nothing
        itemLookUpEdit.Properties.Tag = Nothing
        itemLookUpEdit.Properties.ReadOnly = False
        quantityTextEdit.Text = Nothing
        quantityTextEdit.Properties.Tag = Nothing
        palletsTextEdit.Text = Nothing
        lotTextEdit.EditValue = Nothing
        poTextEdit.EditValue = Nothing
        shiftLookUpEdit.EditValue = Nothing
        palletNumberTextEdit.EditValue = Nothing
        expirationDateEdit.EditValue = Nothing
        noteMemoEdit.EditValue = Nothing
        m_LPNBaseNumber = Nothing
        expirationDateEdit.Properties.DisplayFormat.FormatString = "d"
        expirationDateEdit.Properties.EditFormat.FormatString = "d"

        m_PoolItemQtyUsed.Clear()

        poolDetailsXpCollection.Criteria = New BinaryOperator(PoolBom.Fields.PoolBomFiniGoodID.ItemID.PropertyName, 0, BinaryOperatorType.Equal)
        UpdatePoolDetailsXpViewCriteria()

        productionProjectDetailXpCollection.Criteria = New BinaryOperator(ProductionProjectDetails.Fields.Production.InventoryID.PropertyName, 0, BinaryOperatorType.Equal)
        projectDetailsGridView.OptionsBehavior.Editable = False

        'will update the new LPN number in the  view
        inventoryXPView.Reload()

        inventoryDateEdit.Focus()

    End Sub

    'Private Shared Sub PrintPalletTicket(ByVal inventoryID As Integer)

    '    Dim inventoryRecord As Inventory = InventoryBLL.GetInventoryRecord(inventoryID, True)

    '    Dim ticket As New PalletTicketXtraReport()
    '    ticket.customerXrLabel.Text = inventoryRecord.InventoryItemID.ItemCustomerID.CustomerName
    '    ticket.itemXrLabel.Text = inventoryRecord.InventoryItemID.ItemCode
    '    ticket.itemDescriptionXrLabel.Text = inventoryRecord.InventoryItemID.ItemDescription
    '    Select Case inventoryRecord.InventoryItemID.ItemType
    '        Case "RM"
    '            ticket.itemTypeXrLabel.Text = "Raw Material"
    '        Case "IG"
    '            ticket.itemTypeXrLabel.Text = "Intermediate Goods"
    '        Case "FG"
    '            ticket.itemTypeXrLabel.Text = "Finished Goods"
    '        Case Else
    '            ticket.itemTypeXrLabel.Text = Nothing
    '    End Select
    '    ticket.casesPerPalletXrLabel.Text = inventoryRecord.InventoryQuantity.ToString
    '    ticket.lotCodeXrLabel.Text = inventoryRecord.Lot
    '    ticket.shiftXrLabel.Text = inventoryRecord.Shift.ShiftName
    '    ticket.shiftXrLabel.Visible = True
    '    ticket.palletXrLabel.Text = inventoryRecord.Pallet.ToString
    '    ticket.palletXrLabel.Visible = True
    '    ticket.dateXrLabel.Text = inventoryRecord.InventoryDate.ToShortDateString & vbCrLf & inventoryRecord.dtmEnteredOn.ToShortTimeString
    '    ticket.dateXrLabel.Visible = True
    '    ticket.ShowPreview()

    'End Sub

    Private Function RequiredInfoMissing() As Boolean

        Dim str As StringBuilder = New StringBuilder(String.Empty)

        If String.IsNullOrEmpty(quantityTextEdit.Text) Then
            str.Append("quantity, ")
            quantityTextEdit.Focus()
        End If

        If itemLookUpEdit.EditValue Is Nothing OrElse CType(itemLookUpEdit.EditValue, String) = itemLookUpEdit.Properties.NullText Then
            str.Append("Item Code, ")
            itemLookUpEdit.Focus()
        End If

        If saveSimpleButton.Tag Is Nothing Then
            If shiftLookUpEdit.EditValue Is Nothing OrElse CType(shiftLookUpEdit.EditValue, String) = shiftLookUpEdit.Properties.NullText Then
                str.Append("Shift, ")
                shiftLookUpEdit.Focus()
            End If
        End If

        If str.Length > 0 Then
            MessageBox.Show(String.Format("You must provide a {0}.", str.ToString.Substring(0, str.Length - 2)))
            Return True
        End If

        Return False

    End Function

    Public Sub SavePoolBom()

        Dim poolScrapFactor As Dictionary(Of Integer, Single) = New Dictionary(Of Integer, Single)()

        If poolDetailsXpCollection.Count > 0 Then
            Dim i As Integer = 0
            Dim quantityConsumed As Double = 0

            For Each pool As PoolBom In poolDetailsXpCollection
                poolScrapFactor.Add(pool.ItemPoolID.Oid, Convert.ToSingle(pool.ScrapFactor / 100))
            Next

            While poolDetailsGridView.IsValidRowHandle(i)
                quantityConsumed = BomConsumptionBLL.UpdateBomConsumption(m_InventoryUOW, m_InventoryUOW.GetObjectByKey(Of Items)(CType(poolDetailsGridView.GetRowCellValue(i, rmItemGridColumn), Integer)),
                                                       m_SavedRecord, CType(poolDetailsGridView.GetRowCellValue(i, itemQuantityUsedGridColumn), Single),
                                                       poolScrapFactor(CType(poolDetailsGridView.GetRowCellValue(i, itemPoolIDGridColumn), Integer)) * CType(poolDetailsGridView.GetRowCellValue(i, itemQuantityUsedGridColumn), Single))

                m_Items.UpdateStock(m_InventoryUOW, CType(poolDetailsGridView.GetRowCellValue(i, rmItemGridColumn), Integer), CSng(quantityConsumed * -1), False, UsersBLL.GetUsersLocalLocation(m_InventoryUOW, My.Settings.UserName).Oid)

                i += 1
            End While
        End If

    End Sub

    Private Sub SaveProjectDetails()

        Dim itemId As Integer? = CType(itemLookUpEdit.EditValue, Integer?)
        Dim oldQuantity As Integer? = CType(quantityTextEdit.Properties.Tag, Integer?)

        If oldQuantity.HasValue = False Then
            oldQuantity = 0
        End If

        Dim newQuantity As Integer = CInt(quantityTextEdit.EditValue) - oldQuantity.Value

        If newQuantity > 0 Then
            ProjectDetailsBLL.AssignToProjects(m_InventoryUOW, m_SavedRecord, itemId, newQuantity)
        End If

    End Sub

    Public Function SaveRecord() As Boolean

        If saveSimpleButton.Tag Is Nothing Then
            If m_AllowAdd = True Then
                saveSimpleButton.Tag = InventoryBLL.GetNewInventoryID
            Else
                Return False
            End If
        End If

        m_SavedRecord = m_Inventory.UpdateInventory(m_InventoryUOW, Convert.ToInt32(saveSimpleButton.Tag), inventoryDateEdit.DateTime, CType(itemLookUpEdit.EditValue, Integer), Utilities.ChangeType(Of Integer)(quantityTextEdit.EditValue),
                                       Utilities.ChangeType(Of Single?)(palletsTextEdit.EditValue), Convert.ToString(poTextEdit.EditValue), Convert.ToString(lotTextEdit.EditValue),
                                       Utilities.ChangeType(Of Integer?)(shiftLookUpEdit.EditValue), Utilities.ChangeType(Of Integer?)(palletNumberTextEdit.EditValue),
                                       Utilities.ChangeType(Of Date?)(expirationDateEdit.EditValue), UsersBLL.GetUsersLocalLocation(m_InventoryUOW, My.Settings.UserName).Oid, Convert.ToString(noteMemoEdit.EditValue))
        If m_SavedRecord Is Nothing Then
            MessageBox.Show("The inventory record was not updated successfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Else
            SavePoolBom()
            SaveProjectDetails()
        End If

        ' delete record from view if we are updating a record
        inventoryXPView.Reload()

        Return True

    End Function

    Public Sub SetDefaultViewFilter()

        'Set the from filter to the sunday of this week
        fromFilterDateEdit.DateTime = DateAdd(DateInterval.Day, (Weekday(Today) - 1) * -1, Today)
        toFilterDateEdit.DateTime = DateAdd(DateInterval.Minute, 1439, Today)
        customerFilterLookUpEdit.EditValue = Nothing
        itemFilterLookUpEdit.EditValue = Nothing
        lotFilterTextEdit.EditValue = Nothing
        shiftFilterLookUpEdit.EditValue = Nothing

    End Sub

    Private Sub UpdateBomPoolUsed()

        If poolDetailsXpCollection.Count > 0 Then
            Dim i As Integer = 0
            Dim consumptionCriteria As CriteriaOperatorCollection = New CriteriaOperatorCollection()

            While poolDetailsGridView.IsValidRowHandle(i)
                consumptionCriteria.Clear()

                consumptionCriteria.Add(New BinaryOperator(BomConsumption.Fields.RawMatID.ItemID.PropertyName, CType(poolDetailsGridView.GetRowCellValue(i, rmItemGridColumn), Integer), BinaryOperatorType.Equal))
                consumptionCriteria.Add(New BinaryOperator(BomConsumption.Fields.InventoryID.InventoryID.PropertyName, Convert.ToInt32(saveSimpleButton.Tag), BinaryOperatorType.Equal))

                m_InventoryUOW.Evaluate(Of BomConsumption)(BomConsumption.Fields.QuantityUsed, New GroupOperator(GroupOperatorType.And, consumptionCriteria))

                poolDetailsGridView.SetRowCellValue(i, itemQuantityUsedGridColumn, m_InventoryUOW.Evaluate(Of BomConsumption)(BomConsumption.Fields.QuantityUsed, New GroupOperator(GroupOperatorType.And, consumptionCriteria)))

                i += 1
            End While
        End If

    End Sub

    Private Sub UpdatePallets()

        If itemLookUpEdit.EditValue Is Nothing OrElse
                itemLookUpEdit.Text = itemLookUpEdit.Properties.NullText OrElse quantityTextEdit.Text = String.Empty Then
            Exit Sub
        End If

        Dim pallets As Single = m_Items.GetPallets(CType(itemLookUpEdit.EditValue, Integer))
        If pallets <> 0 Then
            palletsTextEdit.Text = Format(Convert.ToDouble(quantityTextEdit.EditValue) / pallets, "f2")
        Else
            palletsTextEdit.EditValue = 0
        End If

    End Sub

    Private Sub UpdatePoolDetailsXpViewCriteria()

        Dim poolCriteria As CriteriaOperatorCollection = New CriteriaOperatorCollection()

        For i As Integer = 0 To poolDetailsXpCollection.Count - 1
            poolCriteria.Add(New InOperator("Oid", CType(poolDetailsXpCollection(i), PoolBom).ItemPoolID.Details))
        Next i

        If poolCriteria.Count > 0 Then
            poolDetailsXpView.Criteria = New GroupOperator(GroupOperatorType.Or, poolCriteria)
        Else
            poolDetailsXpView.Criteria = New BinaryOperator("Oid", 0, BinaryOperatorType.Equal)
        End If

    End Sub

    Private Function ValidatePoolDetails() As String

        Dim poolQuantitiesNeeded As Dictionary(Of String, Double) = New Dictionary(Of String, Double)()

        If poolDetailsXpCollection.Count > 0 Then
            For Each pool As PoolBom In poolDetailsXpCollection
                poolQuantitiesNeeded.Add(pool.ItemPoolID.PoolCode, (pool.PoolBomQuantity) * Utilities.ChangeType(Of Integer)(quantityTextEdit.EditValue))
            Next

            Dim i As Integer = -1
            Dim amountNeeded, amountUsed As Double
            While poolDetailsGridView.IsValidRowHandle(i)
                amountNeeded = poolQuantitiesNeeded(Convert.ToString(poolDetailsGridView.GetGroupRowValue(i)))
                amountUsed = Convert.ToDouble(poolDetailsGridView.GetGroupSummaryValue(i, TryCast(poolDetailsGridView.GroupSummary(0), GridGroupSummaryItem)))
                If amountNeeded - 0.5 > amountUsed OrElse Math.Round(amountUsed, 2) > amountNeeded + 1 Then
                    Return String.Format("{0} Amount Needed = {1} Amount Used = {2}", Convert.ToString(poolDetailsGridView.GetGroupRowValue(i)), amountNeeded, amountUsed)
                End If
                i -= 1
            End While

            Return Nothing
        Else
            Return Nothing
        End If

    End Function

    Private Function ValidateProject() As Boolean

        projectDetailsGridView.CloseEditor()

        Dim itemId As Integer? = CType(itemLookUpEdit.EditValue, Integer?)

        If ProjectDetailsBLL.IsItOnSchedule(m_InventoryUOW, itemId) = False Then
            If saveSimpleButton.Tag Is Nothing OrElse m_InventoryUOW.GetObjectByKey(Of Inventory)(saveSimpleButton.Tag) Is Nothing Then
                If MessageBox.Show("This item is not on schedule", "Item not in schedule", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Cancel Then
                    Return False
                Else
                    Return True
                End If
            Else
                If m_InventoryUOW.GetObjectByKey(Of Inventory)(saveSimpleButton.Tag).ProductionProject.Count = 0 Then
                    Return True
                End If
            End If
        End If

        Dim oldQuantity As Integer? = CType(quantityTextEdit.Properties.Tag, Integer?)

        If oldQuantity.HasValue = False Then
            oldQuantity = 0
        End If

        Dim newQuantity As Integer = CInt(quantityTextEdit.EditValue) - oldQuantity.Value

        If newQuantity > 0 AndAlso ProjectDetailsBLL.CanAssignToProjects(m_InventoryUOW, itemId, newQuantity) = False Then
            If MessageBox.Show("You produced more than is scheduled." & vbCrLf & "Do you want to continue?", "Production Overrun", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then
                Return False
            End If
        ElseIf newQuantity < 0 Then
            Dim totalAssigned As Integer
            productionDetailsXtraTabControl.TabPages(1).Show()
            If colUnitsProduced.Summary(0).SummaryValue Is Nothing Then
                totalAssigned = 0
            Else
                totalAssigned = CInt(colUnitsProduced.Summary(0).SummaryValue)
            End If
            If totalAssigned > CInt(quantityTextEdit.EditValue) Then
                MessageBox.Show("The total quantity assigned to projects can't be bigger than the quantity produced." & vbCrLf & "Please update the project details before saving the record.")
                Return False
            End If
        End If

        Return True

    End Function

    Private Function ValidateQuantity() As Boolean

        Dim previousQuantity As Integer?

        If CType(itemLookUpEdit.Properties.Tag, Integer?).HasValue = False OrElse Utilities.ChangeType(Of Integer?)(itemLookUpEdit.EditValue) = Utilities.ChangeType(Of Integer?)(itemLookUpEdit.Properties.Tag) Then
            previousQuantity = CType(quantityTextEdit.Properties.Tag, Integer?)
        Else
            previousQuantity = 0
        End If

        Dim availability As String = ItemsBLL.GetAvailabilityByItemID(m_InventoryUOW, CType(itemLookUpEdit.EditValue, Integer), Utilities.ChangeType(Of Integer)(quantityTextEdit.EditValue), previousQuantity,
                                                                      UsersBLL.GetUsersLocalLocation(m_InventoryUOW, My.Settings.UserName).Oid)

        If String.IsNullOrEmpty(availability) = False Then
            If MessageBox.Show(availability & "Do you want to save the record?", "Save Inventory", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                Return False
            End If
        End If

        Return True

    End Function

    Public Function ValidateRecord() As Boolean

        If RequiredInfoMissing() Then
            Return False
        End If

        Dim ValidationMessage As String = ValidatePoolDetails()

        If String.IsNullOrEmpty(ValidationMessage) = False Then
            MessageBox.Show(String.Format("You must provide the details for the pool items used.{0}{1}", vbCrLf, ValidationMessage))
            Return False
        End If

        If OptionalInfoMissing() Then
            Return False
        End If

        If ValidateQuantity() = False Then
            Return False
        End If

        If ValidateProject() = False Then
            Return False
        End If

        If saveSimpleButton.Tag Is Nothing Then
            If m_AllowAdd = True Then
                saveSimpleButton.Tag = InventoryBLL.GetNewInventoryID()
            Else
                Return False
            End If
        End If

        Return True

    End Function

    Private Sub inventoryGridView_FilterEditorCreated(sender As Object, e As Views.Base.FilterControlEventArgs) Handles inventoryGridView.FilterEditorCreated
        AddHandler e.FilterControl.BeforeShowValueEditor, AddressOf FilterControl_BeforeShowValueEditor
    End Sub

    Private Sub FilterControl_BeforeShowValueEditor(sender As Object, e As DevExpress.XtraEditors.Filtering.ShowValueEditorEventArgs)
        If (e.CurrentNode.FirstOperand.PropertyName = "InventoryDate") Then
            Dim editor As DateEdit
            editor = CType(e.Editor, DateEdit)
            editor.Width = 200
            editor.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True
            editor.Properties.CalendarTimeProperties.Mask.EditMask = "g"
            editor.Properties.TimeEditWidth = 150
        End If
    End Sub
End Class