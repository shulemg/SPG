Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraReports.UI
Imports DevExpress.Xpo
Imports DXDAL.SPGData

Public Class ReceivingXtraForm

    Private m_TempId As New Dictionary(Of Integer, Integer)
    Private m_lastLPN As Integer
    Private m_Receivings As ReceivingsBLL
    Private m_CustomerReceivings As CustomersBLL
    Private m_Shifts As ShiftsBLL
    Private m_Carriers As CarriersBLL
    Private m_ReceivingDetails As ReceivingDetailsBLL
    Private m_ReturnDetails As ReturnDetailsBLL
    Private m_Items As ItemsBLL
    Private m_UserPermissions As UserPermissionsBLL
    Private m_CurrentReceivingID As Integer?
    Private ReadOnly m_ReceivingSession As Session = New Session(SPGDataLayer) With {.TrackPropertiesModifications = True, .OptimisticLockingReadBehavior = OptimisticLockingReadBehavior.MergeCollisionThrowException}

    Private Sub ReceivingXtraForm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing

        If Me.receivingSearchGridControl.Enabled = False Then
            Select Case MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                Case DialogResult.Yes
                    If SaveChanges() = False Then
                        e.Cancel = True
                    End If
                Case DialogResult.No
                    CancelChanges()
                Case DialogResult.Cancel
                    e.Cancel = True
            End Select
        End If

    End Sub

    Private Sub ReceivingXtraForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        Me.Cursor = Cursors.WaitCursor
        m_Receivings = New ReceivingsBLL
        m_CustomerReceivings = New CustomersBLL
        m_Shifts = New ShiftsBLL
        m_Carriers = New CarriersBLL
        m_ReceivingDetails = New ReceivingDetailsBLL
        m_ReturnDetails = New ReturnDetailsBLL
        m_Items = New ItemsBLL
        m_UserPermissions = New UserPermissionsBLL

        CheckPermissions()

        LinkSession()

        BindReceivingsSearchGrid()

        shiftLookUpEdit.Properties.DataSource = m_Shifts.GetShifts
        Me.shiftLookUpEdit.Properties.Columns.Add(New Controls.LookUpColumnInfo)
        Me.shiftLookUpEdit.Properties.Columns(0).FieldName = "ShiftName"
        Me.shiftLookUpEdit.Properties.Columns(0).Caption = "Shift"
        Me.shiftLookUpEdit.Properties.DisplayMember = "ShiftName"
        Me.shiftLookUpEdit.Properties.ValueMember = "ShiftID"

        carrierLookUpEdit.Properties.DataSource = m_Carriers.GetCarrierIDAndNames
        Me.carrierLookUpEdit.Properties.Columns.Add(New Controls.LookUpColumnInfo)
        Me.carrierLookUpEdit.Properties.Columns(0).FieldName = "CarrierName"
        Me.carrierLookUpEdit.Properties.Columns(0).Caption = "Carrier Name"
        Me.carrierLookUpEdit.Properties.DisplayMember = "CarrierName"
        Me.carrierLookUpEdit.Properties.ValueMember = "CarrierID"

        Me.idGridColumn.FieldName = "ReceivDetID"
        Me.receivingIDGridColumn.FieldName = "ReceivMainID"
        Me.itemGridColumn.FieldName = "ReceivDetItemID"
        Me.quantityGridColumn.FieldName = "ReceivDetQty"
        Me.packagesGridColumn.FieldName = "intUnits"
        Me.ReceivDetLPNColumn.FieldName = "ReceivDetLPN"
        Me.lotGridColumn.FieldName = "ReceivDetLot"
        expirationDateGridColumn.FieldName = "ExpirationDate"

        Me.returnIDGridColumn.FieldName = "ReturnDetID"
        Me.ReceiveMainIDGridColumn.FieldName = "ReceiveMainID"
        Me.returnItemGridColumn.FieldName = "ReturnDetItemID"
        Me.returnQuantityGridColumn.FieldName = "ReturnDetQty"
        Me.returnUnitsGridColumn.FieldName = "intUnits"
        Me.returnPalletsGridColumn.FieldName = "sngPallets"
        Me.returnLotGridColumn.FieldName = "ReturnDetLot"
        Me.returnReasonGridColumn.FieldName = "Reason"
        returnExpirationDateGridColumn.FieldName = "ExpirationDate"

        Utilities.MakeFormReadOnly(generalXtraTabPage, True)
        Me.receivingGridView.OptionsBehavior.Editable = False
        Me.BulkEntryGroupControl.Enabled = False
        Utilities.MakeGridReadOnly(Me.returnsGridView, True)
        Me.receivingSearchGridControl.Enabled = True

        cancelBarButtonItem.Enabled = False
        saveBarButtonItem.Enabled = False
        refreshBarButtonItem.Enabled = False
        Me.SaveContinueSimpleButton.Enabled = False

        Me.Cursor = Cursors.Default

    End Sub

    Public Sub BindReceivingsSearchGrid()

        receivingSearchXPView.Reload()

    End Sub

    Public Sub BindReceivingsControls(ByVal receivingID As Integer)

        If receivingID = -1 Then
            Exit Sub
        End If

        'Dim receiving As SPG.ReceivingsRow = CType(m_Receivings.GetReceivingsByID(receivingID).Rows(0), SPG.ReceivingsRow)
        Dim receiving As Receiving = m_ReceivingSession.GetObjectByKey(Of Receiving)(receivingID)
        If receiving Is Nothing Then
            Exit Sub
        End If
        m_CurrentReceivingID = receiving.ReceivID
        Me.customerLookUpEdit.EditValue = receiving.ReceivCustID.CustomerID
        Me.receiveDateEdit.EditValue = receiving.ReceivDate
        Me.shiftLookUpEdit.EditValue = receiving.intShiftID.ShiftID
        Me.bolTextEdit.Text = receiving.ReceivBOL
        Me.poTextEdit.Text = receiving.strPO
        Me.carrierLookUpEdit.EditValue = receiving.ReceivCarrierID.CarrierID
        If receiving.strVendor IsNot Nothing Then
            Me.vendorLookUpEdit.EditValue = receiving.strVendor.Oid
        Else
            Me.vendorLookUpEdit.EditValue = Nothing
        End If
        Me.trailerTextEdit.Text = receiving.strTrailer
        Me.sealTextEdit.Text = receiving.strSeal
        Me.skitsTextEdit.EditValue = receiving.sngSkits
        Me.palletsTextEdit.EditValue = receiving.sngTotalPallets
        Me.notesMemoEdit.EditValue = receiving.Notes
        If receiving.UnloadedBy Is Nothing Then
            unloadedByLookUpEdit.EditValue = Nothing
        Else
            unloadedByLookUpEdit.EditValue = receiving.UnloadedBy.Oid
        End If
        If receiving.CheckedBy Is Nothing Then
            checkedByLookUpEdit.EditValue = Nothing
        Else
            checkedByLookUpEdit.EditValue = receiving.CheckedBy.Oid
        End If
        If receiving.WheelsChocked = Nothing Then
            wheelsChockedComboBoxEdit.EditValue = Nothing
        Else
            wheelsChockedComboBoxEdit.EditValue = [Enum].GetName(GetType(DXDAL.ThreeWayYesNo), receiving.WheelsChocked)
        End If
        If receiving.StartTime = Nothing Then
            startTimeEdit.EditValue = Nothing
        Else
            startTimeEdit.EditValue = receiving.StartTime
        End If
        If receiving.FinishTime = Nothing Then
            finishTimeEdit.EditValue = Nothing
        Else
            finishTimeEdit.EditValue = receiving.FinishTime
        End If
        If receiving.Temparature = Nothing Then
            temperatureSpinEdit.EditValue = Nothing
        Else
            temperatureSpinEdit.EditValue = receiving.Temparature
        End If
        If receiving.PhysicalCondition Is Nothing Then
            physicalConditionLookUpEdit.EditValue = Nothing
        Else
            physicalConditionLookUpEdit.EditValue = receiving.PhysicalCondition.Oid
        End If
        If receiving.LoadCondition Is Nothing Then
            loadConditionLookUpEdit.EditValue = Nothing
        Else
            loadConditionLookUpEdit.EditValue = receiving.LoadCondition.Oid
        End If
        If receiving.ForeignSubstance = Nothing Then
            foreignSubstanceComboBoxEdit.EditValue = Nothing
        Else
            foreignSubstanceComboBoxEdit.EditValue = [Enum].GetName(GetType(DXDAL.ThreeWayYesNo), receiving.ForeignSubstance)
        End If
        If receiving.InsectActivity = Nothing Then
            insectActivityComboBoxEdit.EditValue = Nothing
        Else
            insectActivityComboBoxEdit.EditValue = [Enum].GetName(GetType(DXDAL.ThreeWayYesNo), receiving.InsectActivity)
        End If
        If receiving.CorrectPallets = Nothing Then
            correctPalletsComboBoxEdit.EditValue = Nothing
        Else
            correctPalletsComboBoxEdit.EditValue = [Enum].GetName(GetType(DXDAL.ThreeWayYesNo), receiving.CorrectPallets)
        End If
        locationLookUpEdit.EditValue = receiving.ReceivingLocation.Oid

        'fill details tab
        BindItemLookupEdit()

        BindReceivingGridControl(receivingID)

        'fill returns tab
        BindReturnsGridControl(receivingID)

        refreshBarButtonItem.Enabled = True

    End Sub

    Private Sub BindReceivingGridControl(ByVal receivingID As Integer?)

        If receivingID.HasValue = False Then
            receivingID = 0
        End If

        Dim customer As Integer? = CType(Me.customerLookUpEdit.EditValue, Integer?)
        If customer.HasValue Then
            expirationDateGridColumn.DisplayFormat.FormatString = CustomersBLL.GetExpirationDateFormat(customer.Value)
            ExpirationDateEdit.Properties.DisplayFormat.FormatString = CustomersBLL.GetExpirationDateFormat(customer.Value)
        End If

        Me.receivingGridControl.DataSource = m_ReceivingDetails.GetDetailsByReceivingID(receivingID.Value)

    End Sub

    Private Sub BindReturnsGridControl(ByVal receivingID As Integer?)

        If receivingID.HasValue = False Then
            receivingID = 0
        End If

        Dim customer As Integer? = CType(Me.customerLookUpEdit.EditValue, Integer?)
        If customer.HasValue Then
            returnExpirationDateGridColumn.DisplayFormat.FormatString = CustomersBLL.GetExpirationDateFormat(customer.Value)
        End If

        Me.returnsGridControl.DataSource = m_ReturnDetails.GetDetailsByReceivingID(receivingID.Value)

    End Sub

    Private Sub BindItemLookupEdit()

        Dim customer As Integer? = CType(Me.customerLookUpEdit.EditValue, Integer?)
        If customer.HasValue Then
            Me.receivingItemXPView.Filter = CriteriaOperator.Or(New BinaryOperator("CustomerID", customer.Value, BinaryOperatorType.Equal),
                                                            New BinaryOperator("CustomerID", CompanySettingsBLL.GetUniversalCustomer, BinaryOperatorType.Equal),
                                                            New InOperator("CustomerID", CustomersBLL.GetRelatedCustomerIDs(CustomersBLL.GetCustomer(customer.Value, m_ReceivingSession))))
            Me.returnItemXPView.Filter = CriteriaOperator.Or(New BinaryOperator("CustomerID", customer.Value, BinaryOperatorType.Equal),
                                                          New InOperator("CustomerID", CustomersBLL.GetRelatedCustomerIDs(CustomersBLL.GetCustomer(customer.Value, m_ReceivingSession))))
        Else
            Me.receivingItemXPView.Filter = Nothing
            Me.returnItemXPView.Filter = Nothing
        End If

    End Sub

    Private Sub receivingGridView_CustomUnboundColumnData(ByVal sender As Object, ByVal e As Views.Base.CustomColumnDataEventArgs) Handles receivingGridView.CustomUnboundColumnData

        If Not IsDBNull(receivingGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.itemGridColumn)) AndAlso e.Column.Name = descriptionGridColumn.Name Then
            e.Value = ItemsBLL.GetDescriptionByItemID(CType(receivingGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.itemGridColumn), Integer?))
        End If

    End Sub

    Private Sub returnsGridView_CustomUnboundColumnData(ByVal sender As Object, ByVal e As Views.Base.CustomColumnDataEventArgs) Handles returnsGridView.CustomUnboundColumnData

        If Not IsDBNull(returnsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.returnItemGridColumn)) Then
            e.Value = ItemsBLL.GetDescriptionByItemID(CType(returnsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.returnItemGridColumn), Integer?))
        End If

    End Sub

    Private Sub receivingGridView_InitNewRow(ByVal sender As Object, ByVal e As InitNewRowEventArgs) Handles receivingGridView.InitNewRow

        With Me.receivingGridView
            .SetRowCellValue(e.RowHandle, Me.receivingIDGridColumn, m_CurrentReceivingID)
            .SetRowCellValue(e.RowHandle, Me.quantityGridColumn, 0)
            .SetRowCellValue(e.RowHandle, Me.packagesGridColumn, 0)
            '.SetRowCellValue(e.RowHandle, Me.palletsGridColumn, 0)
            '.SetRowCellValue(e.RowHandle, Me.ReceivDetLPNFromColumn, GetNextLPN())
        End With

    End Sub

    Private Sub returnsGridView_InitNewRow(ByVal sender As Object, ByVal e As InitNewRowEventArgs) Handles returnsGridView.InitNewRow

        With Me.returnsGridView
            .SetRowCellValue(e.RowHandle, Me.ReceiveMainIDGridColumn, m_CurrentReceivingID)
            .SetRowCellValue(e.RowHandle, Me.returnQuantityGridColumn, 0)
            .SetRowCellValue(e.RowHandle, Me.returnUnitsGridColumn, 0)
            .SetRowCellValue(e.RowHandle, Me.returnPalletsGridColumn, 0)
        End With

    End Sub

    Private Function SaveChanges() As Boolean

        UpdateTotalPallets()

        'Required to get back to current receiving when entering a new receiving.
        Dim selectedID As Integer = -1
        Dim newReceiving As Boolean = False

        If m_CurrentReceivingID.HasValue = False OrElse m_CurrentReceivingID = -1 Then
            newReceiving = True
            m_CurrentReceivingID = ReceivingsBLL.GetNewReceivingID()
        Else
            selectedID = receivingSearchGridView.FocusedRowHandle
        End If

        Try
            If m_Receivings.UpdateReceiving(m_CurrentReceivingID.Value, CType(Me.receiveDateEdit.EditValue, Date?), CType(Me.carrierLookUpEdit.EditValue, Integer?),
                                            CType(Me.customerLookUpEdit.EditValue, Integer?), Me.bolTextEdit.Text, CType(Me.vendorLookUpEdit.EditValue, Integer?),
                                            Utilities.ChangeType(Of Single?)(Me.skitsTextEdit.EditValue), Utilities.ChangeType(Of Single?)(Me.palletsTextEdit.EditValue), Me.poTextEdit.Text,
                                            CType(Me.shiftLookUpEdit.EditValue, Integer?), trailerTextEdit.Text, sealTextEdit.Text, Convert.ToString(notesMemoEdit.EditValue), CType(unloadedByLookUpEdit.EditValue, Integer?),
                                            CType(checkedByLookUpEdit.EditValue, Integer?), GetThreeWayYesNoValue(wheelsChockedComboBoxEdit.Text), CType(startTimeEdit.EditValue, Date?), CType(finishTimeEdit.EditValue, Date?),
                                            Utilities.ChangeType(Of Double?)(temperatureSpinEdit.EditValue), CType(physicalConditionLookUpEdit.EditValue, Integer?), CType(loadConditionLookUpEdit.EditValue, Integer?),
                                            GetThreeWayYesNoValue(foreignSubstanceComboBoxEdit.Text), GetThreeWayYesNoValue(insectActivityComboBoxEdit.Text), GetThreeWayYesNoValue(correctPalletsComboBoxEdit.Text),
                                            CType(locationLookUpEdit.EditValue, Integer)) <> True Then
                MessageBox.Show("The receiving was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        Dim lShouldReturn As Boolean
        Dim lResult As Boolean = SaveShippingDetails(lShouldReturn)
        If lShouldReturn Then
            Return lResult
        End If

        Dim lShouldReturn1 As Boolean
        Dim lResult1 As Boolean = SaveShippingReturns(lShouldReturn1)
        If lShouldReturn1 Then
            Return lResult1
        End If

        'If newReceiving Then
        '    printLpn(True)
        'End If

        BindReceivingsSearchGrid()
        BindReceivingsControls(m_CurrentReceivingID.Value)
        If selectedID <> -1 Then
            Me.receivingSearchGridView.FocusedRowHandle = selectedID
        End If
        Return True

    End Function

    Private Function SaveShippingDetails(ByRef shouldReturn As Boolean) As Boolean

        shouldReturn = False

        With Me.receivingGridView
            Try
                receivingGridView.CloseEditor()
                If receivingGridView.GroupCount > 0 Then
                    Dim i As Integer = -1
                    While receivingGridView.IsValidRowHandle(i)
                        If receivingGridView.GetChildRowHandle(i, 0) > -1 Then
                            For ci As Integer = receivingGridView.GetChildRowHandle(i, 0) To receivingGridView.GetChildRowCount(i) + receivingGridView.GetChildRowHandle(i, 0) - 1
                                If SaveShippingDetail(ci) <> True Then
                                    MessageBox.Show("The receiving details was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    shouldReturn = True : Return False
                                End If
                            Next
                        End If
                        i -= 1
                    End While
                Else
                    'receivingGridView.SelectAll()
                    For ci As Integer = 0 To receivingGridView.RowCount - 1
                        If SaveShippingDetail(ci) <> True Then
                            MessageBox.Show("The receiving details was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            shouldReturn = True : Return False
                        End If
                    Next
                End If
            Catch ex As ApplicationException
                MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
                shouldReturn = True : Return False
            End Try
        End With

        Return False

    End Function
    Private Function SaveShippingDetail(ByRef ci As Integer) As Boolean
        If receivingGridView.IsValidRowHandle(ci) Then
            Dim lot As String

            If Not IsDBNull(receivingGridView.GetRowCellValue(ci, lotGridColumn)) Then
                lot = receivingGridView.GetRowCellValue(ci, lotGridColumn).ToString
            Else
                lot = String.Empty
            End If


            Dim id As Integer = CType(receivingGridView.GetRowCellValue(ci, idGridColumn), Integer)
            Dim item As Integer? = CType(receivingGridView.GetRowCellValue(ci, itemGridColumn), Integer?)
            Dim qty As Integer? = CType(receivingGridView.GetRowCellValue(ci, quantityGridColumn), Integer?)
            Dim pckg As Integer? = CType(receivingGridView.GetRowCellValue(ci, packagesGridColumn), Integer?)
            Dim lpn As Integer? = Utilities.ChangeType(Of Integer?)(receivingGridView.GetRowCellValue(ci, ReceivDetLPNColumn))
            Dim expr As Date? = Utilities.ChangeType(Of Date?)(receivingGridView.GetRowCellValue(ci, expirationDateGridColumn))

            Dim tempId As Integer = m_ReceivingDetails.UpdateReceivingDetails(m_ReceivingSession, If(id < 0 AndAlso m_TempId.ContainsKey(id), m_TempId.Item(id), id), m_CurrentReceivingID.Value, item, lot, qty, pckg, lpn, expr)

            If tempId > 0 Then
                If Not m_TempId.ContainsKey(id) AndAlso id < 0 Then m_TempId.Add(id, tempId)
                Return True
            Else
                Return False
            End If
        Else
            Return True
        End If

    End Function
    Private Function SaveShippingReturns(ByRef shouldReturn As Boolean) As Boolean

        shouldReturn = False

        With returnsGridView
            Try
                .CloseEditor()
                If .GroupCount > 0 Then
                    Dim i As Integer = -1
                    While .IsValidRowHandle(i)
                        If .GetChildRowHandle(i, 0) > -1 Then
                            For ci As Integer = .GetChildRowHandle(i, 0) To .GetChildRowCount(i) + .GetChildRowHandle(i, 0) - 1
                                If .GetRowCellValue(ci, returnItemGridColumn) IsNot Nothing Then
                                    Dim lot As String
                                    Dim reason As String

                                    If Not IsDBNull(.GetRowCellValue(ci, returnLotGridColumn)) AndAlso .GetRowCellValue(ci, returnLotGridColumn) IsNot Nothing Then
                                        lot = .GetRowCellValue(ci, returnLotGridColumn).ToString
                                    Else
                                        lot = String.Empty
                                    End If

                                    If Not IsDBNull(.GetRowCellValue(ci, returnReasonGridColumn)) AndAlso .GetRowCellValue(i, returnReasonGridColumn) IsNot Nothing Then
                                        reason = .GetRowCellValue(ci, returnReasonGridColumn).ToString
                                    Else
                                        reason = String.Empty
                                    End If

                                    If m_ReturnDetails.UpdateReturnDetails(m_ReceivingSession, CType(.GetRowCellValue(ci, returnIDGridColumn), Integer?), m_CurrentReceivingID.Value, CType(.GetRowCellValue(ci, returnItemGridColumn), Integer?), lot,
                                                                           CType(.GetRowCellValue(ci, returnQuantityGridColumn), Integer?), CType(.GetRowCellValue(ci, returnUnitsGridColumn), Integer?),
                                                                           CType(.GetRowCellValue(ci, returnPalletsGridColumn), Single?), reason,
                                                                           Utilities.ChangeType(Of Date?)(.GetRowCellValue(ci, returnExpirationDateGridColumn))) <> True Then
                                        MessageBox.Show("The return details were not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        shouldReturn = True : Return False
                                    End If
                                End If
                            Next
                        End If
                        i -= 1
                    End While
                Else
                    For i As Integer = 0 To .RowCount - 1
                        If .IsValidRowHandle(i) AndAlso .GetRowCellValue(i, returnItemGridColumn) IsNot Nothing Then
                            Dim lot As String
                            Dim reason As String

                            If Not IsDBNull(.GetRowCellValue(i, returnLotGridColumn)) AndAlso .GetRowCellValue(i, returnLotGridColumn) IsNot Nothing Then
                                lot = .GetRowCellValue(i, returnLotGridColumn).ToString
                            Else
                                lot = String.Empty
                            End If

                            If Not IsDBNull(.GetRowCellValue(i, returnReasonGridColumn)) AndAlso .GetRowCellValue(i, returnReasonGridColumn) IsNot Nothing Then
                                reason = .GetRowCellValue(i, returnReasonGridColumn).ToString
                            Else
                                reason = String.Empty
                            End If

                            If m_ReturnDetails.UpdateReturnDetails(m_ReceivingSession, CType(.GetRowCellValue(i, returnIDGridColumn), Integer?), m_CurrentReceivingID.Value, CType(.GetRowCellValue(i, returnItemGridColumn), Integer?), lot,
                                                                   CType(.GetRowCellValue(i, returnQuantityGridColumn), Integer?), CType(.GetRowCellValue(i, returnUnitsGridColumn), Integer?),
                                                                   CType(.GetRowCellValue(i, returnPalletsGridColumn), Single?), reason,
                                                                   Utilities.ChangeType(Of Date?)(.GetRowCellValue(i, returnExpirationDateGridColumn))) <> True Then
                                MessageBox.Show("The return details were not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                shouldReturn = True : Return False
                            End If
                        End If
                    Next
                End If
            Catch ex As ApplicationException
                MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
                shouldReturn = True : Return False
            End Try
        End With

        Return False

    End Function

    Private Sub saveSimpleButton_Click(ByVal sender As Object,
                                ByVal e As EventArgs)

        SaveChanges()

    End Sub

    Public Sub UpdateTotalPallets()

        'Make sure the summary is updated before calculating the total pallets
        Me.receivingGridView.UpdateTotalSummary()
        Me.returnsGridView.UpdateTotalSummary()
        Me.palletsTextEdit.Text = Format(Convert.ToInt32(ReceivDetLPNColumn.SummaryItem.SummaryValue) + Convert.ToDouble(returnPalletsGridColumn.SummaryItem.SummaryValue) +
                                         Math.Ceiling(Convert.ToDouble(Me.skitsTextEdit.EditValue)), "f2")

    End Sub

    Private Sub skitsTextEdit_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles skitsTextEdit.Validated

        UpdateTotalPallets()

    End Sub

    Private Sub returnsGridView_CellValueChanged(ByVal sender As Object, ByVal e As Views.Base.CellValueChangedEventArgs) Handles returnsGridView.CellValueChanged

        With Me.returnsGridView
            If IsNothing(.GetFocusedRowCellValue(Me.returnItemGridColumn)) OrElse IsDBNull(.GetFocusedRowCellValue(Me.returnItemGridColumn)) Then Exit Sub
            Select Case e.Column.Name
                Case returnItemGridColumn.Name
                    If Convert.ToDouble(.GetFocusedRowCellValue(Me.returnQuantityGridColumn)) > 0 Then
                        UpdateReturnPallets()
                    End If
                Case returnQuantityGridColumn.Name
                    UpdateReturnPallets()
                Case returnPalletsGridColumn.Name
                    UpdateTotalPallets()
            End Select
        End With

    End Sub

    Private Sub customerLookUpEdit_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles customerLookUpEdit.Validated

        BindItemLookupEdit()

    End Sub

    Private Sub FilterLookUpEditValidated(ByVal sender As Object,
                                          ByVal e As EventArgs)

        BindReceivingsSearchGrid()

    End Sub

    Public Sub UpdateReturnPallets()

        With Me.returnsGridView

            Dim units As Integer
            Dim pallets As Single
            units = m_Items.GetUnits(CType(.GetRowCellValue(.FocusedRowHandle, Me.returnItemGridColumn), Integer))

            If units <> 0 Then
                .SetFocusedRowCellValue(Me.returnUnitsGridColumn, Convert.ToDouble(.GetFocusedRowCellValue(Me.returnQuantityGridColumn)) * units)
            Else
                .SetFocusedRowCellValue(Me.returnUnitsGridColumn, 0)
            End If

            pallets = m_Items.GetCasesPerPallet(CType(.GetFocusedRowCellValue(Me.returnItemGridColumn), Integer))

            If pallets <> 0 Then
                .SetFocusedRowCellValue(Me.returnPalletsGridColumn, Convert.ToDouble(.GetFocusedRowCellValue(Me.returnQuantityGridColumn)) / pallets)
            Else
                .SetFocusedRowCellValue(Me.returnPalletsGridColumn, 0)
            End If

        End With

    End Sub

    Private Sub receivingSearchGridView_Click(ByVal sender As Object, ByVal e As EventArgs) Handles receivingSearchGridView.Click

        If (Me.receivingSearchGridView.CalcHitInfo(Me.receivingSearchGridControl.PointToClient(Control.MousePosition)).HitTest = GridHitTest.RowCell) Then
            Me.BindReceivingsControls(CType(Me.receivingSearchGridView.GetFocusedRowCellValue(Me.receivingIDSearchGridColumn), Integer))
        End If

    End Sub

    Private Sub addBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles addBarButtonItem.ItemClick

        m_CurrentReceivingID = -1
        Me.receiveDateEdit.EditValue = Nothing
        Me.customerLookUpEdit.EditValue = Nothing
        Me.carrierLookUpEdit.EditValue = Nothing
        Me.bolTextEdit.Text = String.Empty
        Me.vendorLookUpEdit.EditValue = Nothing
        Me.skitsTextEdit.EditValue = 0
        Me.shiftLookUpEdit.EditValue = Nothing
        Me.poTextEdit.Text = String.Empty
        Me.palletsTextEdit.EditValue = 0
        Me.trailerTextEdit.Text = String.Empty
        Me.sealTextEdit.Text = String.Empty
        Me.notesMemoEdit.EditValue = Nothing
        unloadedByLookUpEdit.EditValue = Nothing
        checkedByLookUpEdit.EditValue = Nothing
        wheelsChockedComboBoxEdit.EditValue = Nothing
        startTimeEdit.EditValue = Nothing
        finishTimeEdit.EditValue = Nothing
        temperatureSpinEdit.EditValue = Nothing
        physicalConditionLookUpEdit.EditValue = Nothing
        loadConditionLookUpEdit.EditValue = Nothing
        foreignSubstanceComboBoxEdit.EditValue = Nothing
        insectActivityComboBoxEdit.EditValue = Nothing
        correctPalletsComboBoxEdit.EditValue = Nothing
        locationLookUpEdit.EditValue = UsersBLL.GetUsersLocalLocation(m_ReceivingSession, My.Settings.UserName).Oid

        BindReceivingGridControl(m_CurrentReceivingID)
        BindReturnsGridControl(m_CurrentReceivingID)

        Me.receivingsXtraTabControl.SelectedTabPage = Me.generalXtraTabPage

        Utilities.MakeFormReadOnly(Me.generalXtraTabPage, False)
        Me.palletsTextEdit.Properties.ReadOnly = True
        Me.BulkEntryGroupControl.Enabled = False
        Me.receivingGridView.OptionsBehavior.Editable = True
        Utilities.MakeGridReadOnly(Me.returnsGridView, False)
        Me.receivingSearchGridControl.Enabled = False
        CheckPermissions()

        Me.UnitQtyLockCheckEdit.Checked = True
        Me.SaveContinueSimpleButton.Enabled = True
        Me.cancelBarButtonItem.Enabled = True
        Me.saveBarButtonItem.Enabled = True
        Me.editBarButtonItem.Enabled = False
        Me.addBarButtonItem.Enabled = False
        refreshBarButtonItem.Enabled = False

    End Sub

    Private Sub editBarButtonItem_ItemClick(ByVal sender As Object,
                                            ByVal e As DevExpress.XtraBars.ItemClickEventArgs) _
            Handles editBarButtonItem.ItemClick

        If m_CurrentReceivingID Is Nothing Then
            MessageBox.Show("Please select a receiving entry to edit.")
            Exit Sub
        End If

        Utilities.MakeFormReadOnly(Me.generalXtraTabPage, False)
        Me.palletsTextEdit.Properties.ReadOnly = True
        'locationLookUpEdit.Properties.ReadOnly = True
        Me.BulkEntryGroupControl.Enabled = True
        Me.receivingGridView.OptionsBehavior.Editable = True
        Utilities.MakeGridReadOnly(Me.returnsGridView, False)
        Me.receivingSearchGridControl.Enabled = False
        CheckPermissions()

        Me.UnitQtyLockCheckEdit.Checked = True
        Me.cancelBarButtonItem.Enabled = True
        Me.saveBarButtonItem.Enabled = True
        Me.editBarButtonItem.Enabled = False
        Me.addBarButtonItem.Enabled = False
        refreshBarButtonItem.Enabled = False

    End Sub

    Private Sub cancelBarButtonItem_ItemClick(ByVal sender As Object,
                                              ByVal e As DevExpress.XtraBars.ItemClickEventArgs) _
            Handles cancelBarButtonItem.ItemClick

        CancelChanges()

        CheckPermissions()

        Me.BulkEntryGroupControl.Enabled = False
        Utilities.MakeFormReadOnly(Me.generalXtraTabPage, True)
        Me.receivingGridView.OptionsBehavior.Editable = False
        Utilities.MakeGridReadOnly(Me.returnsGridView, True)
        Me.receivingSearchGridControl.Enabled = True

        m_TempId.Clear()

        Me.SaveContinueSimpleButton.Enabled = False
        cancelBarButtonItem.Enabled = False
        saveBarButtonItem.Enabled = False
        refreshBarButtonItem.Enabled = True

    End Sub

    Private Sub saveBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles saveBarButtonItem.ItemClick

        If SaveChanges() Then

            CheckPermissions()

            Me.BulkEntryGroupControl.Enabled = False
            Utilities.MakeFormReadOnly(Me.generalXtraTabPage, True)
            Me.receivingGridView.OptionsBehavior.Editable = False
            Utilities.MakeGridReadOnly(Me.returnsGridView, True)
            Me.receivingSearchGridControl.Enabled = True

            m_TempId.Clear()

            cancelBarButtonItem.Enabled = False
            saveBarButtonItem.Enabled = False
            refreshBarButtonItem.Enabled = True
        End If

    End Sub

    Public Function CheckPermissions() As Boolean

        Try
            Dim permission As SPG.UserPermissionsRow = New UserPermissionsBLL().GetUserPermissionsByUserName(My.Settings.UserName, "Receiving Form")(0)

            Select Case permission.PermissionLevel

                Case "FULL", "Full"
                    Me.addBarButtonItem.Enabled = True
                    Me.editBarButtonItem.Enabled = True
                    Me.delGridColumn.Visible = True
                    Me.deleteGridColumn.Visible = True
                Case "ADD", "Add"
                    Me.addBarButtonItem.Enabled = True
                    Me.editBarButtonItem.Enabled = True
                    Me.delGridColumn.Visible = False
                    Me.deleteGridColumn.Visible = False
                Case "NONE", "None"
                    MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Me.Close()
                    Return False
                Case "VIEW", "View"
                    Me.addBarButtonItem.Enabled = False
                    Me.editBarButtonItem.Enabled = False
                    Me.delGridColumn.Visible = False
                    Me.deleteGridColumn.Visible = False
                Case "EDIT", "Edit"
                    Me.addBarButtonItem.Enabled = False
                    Me.editBarButtonItem.Enabled = True
                    Me.delGridColumn.Visible = False
                    Me.deleteGridColumn.Visible = False
                Case "VIEW ASSIGNED"
                    Me.addBarButtonItem.Enabled = False
                    Me.editBarButtonItem.Enabled = False
                    Me.delGridColumn.Visible = False
                    Me.deleteGridColumn.Visible = False
                    FilterAssignedCustomers()
                Case "EDIT ASSIGNED"
                    Me.addBarButtonItem.Enabled = False
                    Me.editBarButtonItem.Enabled = True
                    Me.delGridColumn.Visible = False
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

        Me.receivingSearchXPView.Criteria = New InOperator(Receiving.Fields.ReceivCustID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ReceivingSession))
        Me.customersXPView.Criteria = CriteriaOperator.And(New BinaryOperator(Customers.Fields.Inactive.PropertyName, False),
                                                             New InOperator(Customers.Fields.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ReceivingSession)))
        Me.receivingItemXPView.Criteria = CriteriaOperator.And(New InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ReceivingSession)),
                                                           New InOperator(Items.Fields.ItemType.PropertyName, New String() {"RM", "IG"}))
        Me.returnItemXPView.Criteria = CriteriaOperator.And(CriteriaOperator.Or(New InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ReceivingSession)),
                                                                          New BinaryOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, CompanySettingsBLL.GetUniversalCustomer, BinaryOperatorType.Equal)),
                                                                  New BinaryOperator(Items.Fields.ItemType.PropertyName, "FG", BinaryOperatorType.Equal))

    End Sub

    Private Sub CancelChanges()


        If m_TempId.Count > 0 Then
            MsgBox($"{m_TempId.Count} Added Pallets was already received, If you want to remove it go back and edit.")
        End If

        For Each control As Control In BulkEntryGroupControl.Controls
            If TypeOf control Is TextEdit Then
                TryCast(control, TextEdit).Text = If(control.Tag Is Nothing, Nothing, control.Tag.ToString())
                If control.Name = "ItemLookUpEdit" Then TryCast(control, TextEdit).EditValue = Nothing
            End If
        Next

        If Me.m_CurrentReceivingID IsNot Nothing Then
            BindReceivingsControls(m_CurrentReceivingID.Value)
        End If

    End Sub

    Private m_TotalPallets As Double = 0

    Private Sub receivingGridView_CustomSummaryCalculate(ByVal sender As Object, ByVal e As DevExpress.Data.CustomSummaryEventArgs) Handles receivingGridView.CustomSummaryCalculate

        Select Case e.SummaryProcess

            Case DevExpress.Data.CustomSummaryProcess.Finalize
                e.TotalValue = m_TotalPallets

            Case DevExpress.Data.CustomSummaryProcess.Start
                m_TotalPallets = 0

                Try
                    Dim dataRowCount As Integer = receivingGridView.RowCount
                    Dim vecchioval As List(Of String) = New List(Of String)

                    For i As Integer = 0 To dataRowCount - 1
                        Dim cellValue As Object = receivingGridView.GetRowCellValue(i, ReceivDetLPNColumn)
                        Dim newValue As String = Convert.ToString(cellValue)

                        If Not vecchioval.Contains(newValue) Then
                            m_TotalPallets += 1
                            vecchioval.Add(newValue)
                        End If
                    Next

                Finally
                End Try
                'Case DevExpress.Data.CustomSummaryProcess.Calculate
                '    m_TotalPallets += Math.Ceiling(Convert.ToDouble(receivingGridView.GetRowCellValue(e.RowHandle, palletsGridColumn)))

        End Select

    End Sub

    Private m_TotalReturnedPallets As Double = 0

    Private Sub returnsGridView_CustomSummaryCalculate(ByVal sender As Object, ByVal e As DevExpress.Data.CustomSummaryEventArgs) Handles returnsGridView.CustomSummaryCalculate

        Select Case e.SummaryProcess

            Case DevExpress.Data.CustomSummaryProcess.Finalize
                e.TotalValue = m_TotalReturnedPallets

            Case DevExpress.Data.CustomSummaryProcess.Start
                m_TotalReturnedPallets = 0

            Case DevExpress.Data.CustomSummaryProcess.Calculate
                m_TotalReturnedPallets += Math.Ceiling(Convert.ToDouble(returnsGridView.GetRowCellValue(e.RowHandle, returnPalletsGridColumn)))

        End Select

    End Sub

    Private Sub deleteReturnRepositoryItemButtonEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles deleteReturnRepositoryItemButtonEdit.Click

        If MessageBox.Show("Are you sure you want to delete this return.", "Delete Return", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Try
            Dim lReceivingReturnDetailID As Integer = CInt(Me.returnsGridView.GetRowCellValue(Me.returnsGridView.FocusedRowHandle, Me.returnIDGridColumn))
            If lReceivingReturnDetailID <= -1 Then
                Me.returnsGridView.DeleteRow(Me.returnsGridView.FocusedRowHandle)
            ElseIf m_ReturnDetails.DeleteReturnDetail(m_ReceivingSession, lReceivingReturnDetailID) = True Then
                BindReturnsGridControl(m_CurrentReceivingID)
            Else
                MessageBox.Show("The return was not deleted.")
            End If
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub delRepositoryItemButtonEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles delRepositoryItemButtonEdit.Click

        If MessageBox.Show("Are you sure you want to delete this LPN, this can`t be undone.", "Delete Receiving Detail", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Try
            Dim lReceivingDetailID As Integer = CInt(Me.receivingGridView.GetRowCellValue(Me.receivingGridView.FocusedRowHandle, Me.idGridColumn))

            If m_TempId.ContainsKey(lReceivingDetailID) Then lReceivingDetailID = m_TempId.Item(lReceivingDetailID)

            If lReceivingDetailID <= -1 Then
                Me.receivingGridView.DeleteRow(Me.receivingGridView.FocusedRowHandle)
            ElseIf m_ReceivingDetails.DeleteReceivingDetail(m_ReceivingSession, lReceivingDetailID) = True Then
                If m_TempId.ContainsKey(lReceivingDetailID) Then m_TempId.Remove(lReceivingDetailID)

                BindReceivingGridControl(m_CurrentReceivingID)
            Else
                MessageBox.Show("The receiving detail was not deleted.")
            End If
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub AddLotRepositoryItemButtonEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddLotRepositoryItemButtonEdit.Click

    End Sub

    Private Sub itemRepositoryItemLookUpEdit_Closed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles itemRepositoryItemLookUpEdit.Closed, returnItemRepositoryItemLookUpEdit.Closed

        BindItemLookupEdit()

        If e.CloseMode <> PopupCloseMode.Cancel Then
            Dim view As GridView = CType(CType(CType(sender, LookUpEdit).Parent, GridControl).FocusedView, GridView)
            If view.IsNewItemRow(view.FocusedRowHandle) Then
                view.CloseEditor()
                view.UpdateCurrentRow()
            End If
        End If

    End Sub

    Private Sub itemRepositoryItemLookUpEdit_Enter(sender As Object, e As EventArgs) Handles itemRepositoryItemLookUpEdit.Enter, returnItemRepositoryItemLookUpEdit.Enter

        receivingItemXPView.Filter = CriteriaOperator.And(receivingItemXPView.Filter, New BinaryOperator("Inactive", False))
        returnItemXPView.Filter = CriteriaOperator.And(returnItemXPView.Filter, New BinaryOperator("Inactive", False))

    End Sub

    Private Sub temperatureSpinEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles temperatureSpinEdit.Validating

        If CDbl(temperatureSpinEdit.EditValue) < 55 OrElse CDbl(temperatureSpinEdit.EditValue) > 75 Then
            If MessageBox.Show("You entered an unusual tepmerature, do you want to change it?", "Unusual Temperature", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = vbYes Then
                e.Cancel = True
                temperatureSpinEdit.SelectAll()
            Else
                e.Cancel = False
            End If
        End If

    End Sub

    Private Sub receivingListBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles receivingListBarButtonItem.ItemClick

        If m_CurrentReceivingID Is Nothing Then
            Exit Sub
        End If

        Dim packingList As New PackingListXtraReport

        With packingList
            .locationId.Text = locationLookUpEdit.Text
            .reportTitleXrLabel.Text = "Receiving List"
            .dateXrLabel.DataBindings.Add("Text", Nothing, "ReceivDate", "{0:MM/dd/yyyy}")
            .bolXrLabel.DataBindings.Add("Text", Nothing, "ReceivBOL")
            .poXrLabel.DataBindings.Add("Text", Nothing, "strPO")
            .deliveryNoteLabelXrLabel.Text = "Vendor"
            .deliveryNoteNumberXrLabel.DataBindings.Add("Text", Nothing, "VendorName")
            .carrierXrLabel.DataBindings.Add("Text", Nothing, "CarrierName")
            .trailerXrLabel.DataBindings.Add("Text", Nothing, "strTrailer")
            .sealXrLabel.DataBindings.Add("Text", Nothing, "strSeal")
            .returnsGroupHeader.GroupFields.Add(New GroupField("ShippingType", XRColumnSortOrder.Ascending))
            .itemGroupHeader.GroupFields.Add(New GroupField("ItemCode", XRColumnSortOrder.Ascending))
            .lotGroupHeader.GroupFields.Add(New GroupField("ReceivDetLot", XRColumnSortOrder.Ascending))
            .qtyLabelXrLabel.Text = "UNITS"
            .qtyXrLabel.DataBindings.Add("Text", Nothing, "ReceivDetQty")
            .itemCodeXrLabel.DataBindings.Add("Text", Nothing, "ItemCode")
            .itemDescriptionXrLabel.DataBindings.Add("Text", Nothing, "ItemDescription")
            .palletsXrLabel.DataBindings.Add("Text", Nothing, "sngPallets", "{0:N2}")
            '.additionalPalletsXrLabel.DataBindings.Add("Text", Nothing, "sngSkits")
            .totalPalletsXrLabel.DataBindings.Add("Text", Nothing, "sngTotalPallets", "{0:N2}")
            .palletsTotalXrLabel.DataBindings.Add("Text", Nothing, "sngTotalPallets", "{0:N2}")
            .weightXrLabel.DataBindings.Add("Text", Nothing, "Weight", "{0:N2}")
            '.totalWeightXrLabel.DataBindings.Add("Text", Nothing, "TotalGrossWeight", "{0:N2}")
            .lpnLabelXrLabel.Text = "QUANTITY"
            .lpnXrLabel.DataBindings.Add("Text", Nothing, "intUnits")
            .lotXrLabel.DataBindings.Add("Text", Nothing, "ReceivDetLot")
            .expirationDateXrLabel.DataBindings.Add("Text", Nothing, "ExpirationDate", String.Format("{{0:{0}}}", CustomersBLL.GetExpirationDateFormat(CType(customerLookUpEdit.EditValue, Integer))))
            .itemTotalQuantityXrLabel.DataBindings.Add("Text", Nothing, "intUnits")
            .groupItemCodeXrLabel.DataBindings.Add("Text", Nothing, "ItemCode")
            .groupItemDescriptionXrLabel.DataBindings.Add("Text", Nothing, "ItemDescription")
            .itemTotalPalletsXrLabel.DataBindings.Add("Text", Nothing, "sngPallets", "{0:N2}")
            .itemTotalWeightXrLabel.DataBindings.Add("Text", Nothing, "Weight", "{0:N2}")
            .loadedByLabelXrLabel.Text = "Unloaded By"
            .loadedByXrLabel.DataBindings.Add("Text", Nothing, "UnloadedBy")
            .checkedByXrLabel.DataBindings.Add("Text", Nothing, "CheckedBy")
            .physicalConditionXrLabel.DataBindings.Add("Text", Nothing, "PhysicalCondition")
            .loadConditionXrLabel.DataBindings.Add("Text", Nothing, "LoadCondition")
            .startTimeXrLabel.DataBindings.Add("Text", Nothing, "StartTime", "{0:hh:mm:ss tt}")
            .finishTimeXrLabel.DataBindings.Add("Text", Nothing, "FinishTime", "{0:hh:mm:ss tt}")
            .temperatureXrLabel.DataBindings.Add("Text", Nothing, "Temparature", "{0:N1}")
            .DataSource = New ReceivingListReportBLL().GetReceivingListreport(m_CurrentReceivingID.Value)
            .ShowPreview()
        End With

    End Sub

    Private Shared Function GetThreeWayYesNoValue(ByVal threeWayYesNo As String) As Integer?

        If String.IsNullOrEmpty(threeWayYesNo) Then
            Return Nothing
        Else
            Select Case threeWayYesNo
                Case "Yes"
                    Return 1
                Case "No"
                    Return 2
                Case "NA"
                    Return 3
                Case Else
                    Return Nothing
            End Select
        End If

    End Function

    Private Sub itemRepositoryItemLookUpEdit_ProcessNewValue(sender As Object, e As DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs) Handles itemRepositoryItemLookUpEdit.ProcessNewValue

        Dim itemReceived As Items = ItemsBLL.GetItemByUpc(e.DisplayValue.ToString)

        If itemReceived IsNot Nothing AndAlso itemReceived.ItemCustomerID.CustomerID = CInt(customerLookUpEdit.EditValue) Then
            e.Handled = True
            e.DisplayValue = itemReceived.ItemCode
        Else
            e.Handled = False
        End If

    End Sub

    Private Sub refreshBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles refreshBarButtonItem.ItemClick

        m_ReceivingSession.DropIdentityMap()
        receivingSearchXPView.Reload()
        receivingItemXPView.Reload()
        returnItemXPView.Reload()
        customersXPView.Reload()
        vendorLookupXPCollection.Reload()
        shipmentConditionXpView.Reload()
        employeeXpView.Reload()
        locationXpView.Reload()

        BindReceivingsSearchGrid()
        shiftLookUpEdit.Properties.DataSource = m_Shifts.GetShifts
        carrierLookUpEdit.Properties.DataSource = m_Carriers.GetCarrierIDAndNames
        BindReceivingsControls(m_CurrentReceivingID.Value)

        CheckPermissions()

        MessageBox.Show("Done!")

    End Sub

    Private Sub LinkSession()

        receivingSearchXPView.Session = m_ReceivingSession
        receivingItemXPView.Session = m_ReceivingSession
        returnItemXPView.Session = m_ReceivingSession
        customersXPView.Session = m_ReceivingSession
        vendorLookupXPCollection.Session = m_ReceivingSession
        shipmentConditionXpView.Session = m_ReceivingSession
        employeeXpView.Session = m_ReceivingSession
        locationXpView.Session = m_ReceivingSession

    End Sub

    Private Sub printLpn(reprint As Boolean)
        Dim digits As Integer = Len(CustomersBLL.GetCustomer(7, m_ReceivingSession).LastLPNNumber.ToString)
        Dim lpnXPview As XPView
        Dim critaria As New CriteriaOperatorCollection
        lpnXPview = New XPView(m_ReceivingSession, GetType(LocationInventoryByLot))

        'If all Then
        '    If receivingGridView.GroupCount > 0 Then
        '        Dim i As Integer = -1
        '        While receivingGridView.IsValidRowHandle(i)
        '            If receivingGridView.GetChildRowHandle(i, 0) > -1 Then
        '                For ci As Integer = receivingGridView.GetChildRowHandle(i, 0) To receivingGridView.GetChildRowCount(i) + receivingGridView.GetChildRowHandle(i, 0) - 1
        '                    addToCritaria(critaria, ci)
        '                Next
        '            End If
        '            i -= 1
        '        End While
        '    Else
        '        For ci As Integer = 0 To receivingGridView.RowCount - 1
        '            addToCritaria(critaria, ci)
        '        Next
        '    End If
        'Else
        Dim selectedRowHandles As Integer() = receivingGridView.GetSelectedRows()
            If selectedRowHandles.Length = 0 Then
                MsgBox("Nothing is selected")
                Exit Sub
            End If
            For i As Integer = 0 To selectedRowHandles.Length - 1
                Dim ci As Integer = selectedRowHandles(i)
                If (ci >= 0) Then
                    addToCritaria(critaria, ci)
                End If
            Next
        'End If

        lpnXPview.Criteria = CriteriaOperator.And(CriteriaOperator.Or(critaria), New BinaryOperator("QuantityOnHand", 0, BinaryOperatorType.Greater))

        lpnXPview.Properties.AddRange(New ViewProperty() {New ViewProperty("Item", SortDirection.None, "[LocationInventoryItem.ItemCode]", False, True),
                                      New ViewProperty("ItemDesc", SortDirection.None, "[LocationInventoryItem.ItemDescription]", False, True),
                                      New ViewProperty("Qty", SortDirection.None, "[QuantityOnHand]", False, True),
                                      New ViewProperty("Expr", SortDirection.None, "[ExpirationDate]", False, True),
                                      New ViewProperty("Lot", SortDirection.None, "[LocationInventoryLot]", False, True),
                                                                New ViewProperty("LPN", SortDirection.Ascending, "[LPNNumber]", False, True)})

        Dim labels As LPNLabelsXtraReport = New LPNLabelsXtraReport
        With labels
            .DataSource = lpnXPview
            .lpnGroupHeader.GroupFields.Add(New GroupField("LPN", XRColumnSortOrder.Ascending))
            .lpnGroupHeader.GroupFields.Add(New GroupField("Item", XRColumnSortOrder.Ascending))
            .itemCodeXrLabel.DataBindings.Add("Text", lpnXPview, "Item")
            .itemDescXrLabel.DataBindings.Add("Text", lpnXPview, "ItemDesc")
            .exprXrLabel.DataBindings.Add("Text", lpnXPview, "Expr", "{0:MM/dd/yyyy}")
            .qtyXrLabel.DataBindings.Add("Text", lpnXPview, "Qty")
            .lotXrLabel.DataBindings.Add("Text", lpnXPview, "Lot")
            .LPNXrBarCode.DataBindings.Add("Text", lpnXPview, "LPN", "SPG{0:D" & digits & "}")
            .SumQtyXrLabel.ExpressionBindings.Add(New ExpressionBinding("BeforePrint", "Text", "sumSum([Qty])"))
            .ReprintXrLabel.Visible = reprint
            .CreateDocument()
            .ShowPreviewDialog()
        End With
    End Sub

    Private Sub addToCritaria(critaria As CriteriaOperatorCollection, ci As Integer)
        Dim lpn As Integer? = Utilities.ChangeType(Of Integer?)(receivingGridView.GetRowCellValue(ci, ReceivDetLPNColumn))
        'Dim lot As String = receivingGridView.GetRowCellValue(ci, lotGridColumn).ToString()
        'If lpn.HasValue AndAlso lot.Length > 0 Then
        '    critaria.Add(New GroupOperator(GroupOperatorType.And,
        '        New BinaryOperator("LPNNumber", lpn.Value, BinaryOperatorType.Equal),
        '        New BinaryOperator("LocationInventoryLot", lot, BinaryOperatorType.Equal)))
        'Else
        If lpn.HasValue Then
                critaria.Add(New BinaryOperator("LPNNumber", lpn.Value, BinaryOperatorType.Equal))
            End If
    End Sub

    Private Sub LpnLabelsBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles LpnLabelsBarButtonItem.ItemClick
        printLpn(True)
    End Sub

    Private Sub AddToPalletButton_Click(sender As Object, e As EventArgs) Handles AddToPalletButton.Click
        AddLpns(True)
    End Sub

    Private Sub AddEntryButton_Click(sender As Object, e As EventArgs) Handles AddEntryButton.Click
        AddLpns()
    End Sub

    Private Sub ItemLookUpEdit_Validated(sender As Object, e As EventArgs) Handles ItemLookUpEdit.Validated
        UpdateQtyPerPallets("Item")
        If Not IsDBNull(ItemLookUpEdit.EditValue) Then
            ItemDescTextEdit.Text = ItemsBLL.GetDescriptionByItemID(CType(ItemLookUpEdit.EditValue, Integer?))
        End If
        BulkEntryChanged()
    End Sub

    Private Sub UnitsTextEdit_Validated(sender As Object, e As EventArgs) Handles UnitsTextEdit.Validated
        UpdateQtyPerPallets("Units")
        BulkEntryChanged()
    End Sub
    Private Sub LotTextEdit_Validated(sender As Object, e As EventArgs) Handles LotTextEdit.Validated
        BulkEntryChanged()
    End Sub
    Private Sub QtyTextEdit_Validated(sender As Object, e As EventArgs) Handles QtyTextEdit.Validated
        UpdateQtyPerPallets("Qty")
        BulkEntryChanged()
    End Sub

    Private Sub UnitsPerPltTextEdit_Validated(sender As Object, e As EventArgs) Handles UnitsPerPltTextEdit.Validated
        UpdateQtyPerPallets("UnitsPerPlt")
        BulkEntryChanged()
    End Sub

    Private Sub QtyPerPltTextEdit_Validated(sender As Object, e As EventArgs) Handles QtyPerPltTextEdit.Validated
        UpdateQtyPerPallets("QtyPerPlt")
        BulkEntryChanged()
    End Sub
    Private Sub BulkEntryChanged()
        On Error GoTo Err
        If CInt(UnitsTextEdit.Text) > 0 AndAlso CInt(UnitsPerPltTextEdit.Text) > 0 AndAlso ((CInt(QtyTextEdit.Text) > 0 AndAlso CInt(QtyPerPltTextEdit.Text) > 0) OrElse CInt(QtyTextEdit.Text) = 0) AndAlso
            LotCodeValidator.ValidateByItemID(CInt(ItemLookUpEdit.EditValue), LotTextEdit.Text, True) Then
            AddEntryButton.Enabled = True
            AddToPalletButton.Enabled = CInt(UnitsTextEdit.Text) <= CInt(UnitsPerPltTextEdit.Text) AndAlso CInt(QtyTextEdit.Text) <= CInt(QtyPerPltTextEdit.Text)
        Else
Err:
            AddEntryButton.Enabled = False
            AddToPalletButton.Enabled = False
        End If

    End Sub
    Public Sub UpdateQtyPerPallets(Changed As String)

        Dim CasesPerPallet As Double
        Dim QuantityPerUnit As Double
        Dim itemId As Integer

        itemId = CType(ItemLookUpEdit.EditValue, Integer)
        QuantityPerUnit = ItemsBLL.GetCaseQuantity(itemId)
        CasesPerPallet = m_Items.GetCasesPerPallet(itemId)

        If Changed <> "Item" AndAlso Not UnitQtyLockCheckEdit.Checked AndAlso Convert.ToInt32(QtyPerPltTextEdit.Text) > 0 AndAlso Convert.ToInt32(UnitsPerPltTextEdit.Text) > 0 Then
            QuantityPerUnit = Convert.ToInt32(QtyPerPltTextEdit.Text) / Convert.ToInt32(UnitsPerPltTextEdit.Text)
        End If


        'calculate the quantity
        If Changed = "Qty" AndAlso QuantityPerUnit > 0 Then
            UnitsTextEdit.EditValue = Math.Ceiling(Convert.ToDouble(QtyTextEdit.Text) / QuantityPerUnit)
        End If
        If Changed = "Units" AndAlso QuantityPerUnit > 0 Then
            QtyTextEdit.EditValue = Convert.ToDouble(UnitsTextEdit.Text) * QuantityPerUnit
        End If
        If Changed = "UnitsPerPlt" AndAlso QuantityPerUnit > 0 AndAlso UnitQtyLockCheckEdit.Checked Then
            QtyPerPltTextEdit.EditValue = Convert.ToDouble(UnitsPerPltTextEdit.Text) * QuantityPerUnit
        End If
        If Changed = "QtyPerPlt" AndAlso QuantityPerUnit > 0 AndAlso UnitQtyLockCheckEdit.Checked Then
            UnitsPerPltTextEdit.EditValue = Convert.ToDouble(QtyPerPltTextEdit.Text) / QuantityPerUnit
        End If

        If Changed = "Item" Then
            UnitsPerPltTextEdit.EditValue = CasesPerPallet
            QtyPerPltTextEdit.EditValue = (CasesPerPallet * QuantityPerUnit)
        End If

    End Sub
    Private Sub AddLpns(Optional toLastLPN As Boolean = False)
        Dim addedQty, addedUnits, qty, units, qtyPerPlt, UnitPerPlt As Double
        Dim beginRow As Integer? = Nothing ' = receivingGridView.GetRowHandle(receivingGridView.DataRowCount)

        qty = Convert.ToDouble(QtyTextEdit.Text)
        units = Convert.ToDouble(UnitsTextEdit.Text)
        qtyPerPlt = Convert.ToDouble(QtyPerPltTextEdit.Text)
        UnitPerPlt = Convert.ToDouble(UnitsPerPltTextEdit.Text)

        With receivingGridView
            Do Until addedQty >= qty
                If Not toLastLPN Then
                    m_lastLPN = LPNLabel.GetNextLPNNumber(7)
                End If

                .AddNewRow()
                Dim rowHandle As Integer = .GetRowHandle(.DataRowCount)
                If .IsNewItemRow(rowHandle) Then
                    .SetRowCellValue(rowHandle, itemGridColumn, ItemLookUpEdit.EditValue)
                    .SetRowCellValue(rowHandle, descriptionGridColumn, ItemDescTextEdit.Text)
                    .SetRowCellValue(rowHandle, lotGridColumn, LotTextEdit.Text)
                    If If(ExpirationDateEdit.EditValue, "").ToString() <> "" Then .SetRowCellValue(rowHandle, expirationDateGridColumn, ExpirationDateEdit.EditValue)
                    .SetRowCellValue(rowHandle, packagesGridColumn, Math.Min(UnitPerPlt, units - addedUnits))
                    .SetRowCellValue(rowHandle, quantityGridColumn, Math.Max(Math.Min(qtyPerPlt, qty - addedQty), 0))
                    .SetRowCellValue(rowHandle, ReceivDetLPNColumn, m_lastLPN)
                End If
                .UpdateCurrentRow()

                If SaveShippingDetail(.FocusedRowHandle) <> True Then
                    MessageBox.Show("The receiving details was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                If beginRow Is Nothing Then
                    beginRow = .FocusedRowHandle
                End If
                '.SelectRow(.FocusedRowHandle)

                addedQty += qtyPerPlt
                addedUnits += UnitPerPlt
            Loop
            If addedUnits < units Then
                MessageBox.Show($"{units - addedUnits} units was not added.", "Units/Qty mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End With

        If beginRow.HasValue Then
            receivingGridView.SelectRows(beginRow.Value, receivingGridView.FocusedRowHandle)
            printLpn(False)
        End If

        For Each control As Control In BulkEntryGroupControl.Controls
            If TypeOf control Is TextEdit Then
                TryCast(control, TextEdit).Text = If(control.Tag Is Nothing, Nothing, control.Tag.ToString())
                If control.Name = "ItemLookUpEdit" Then TryCast(control, TextEdit).EditValue = Nothing
            End If
        Next

        Me.UnitQtyLockCheckEdit.Checked = True

        BulkEntryChanged()

    End Sub

    Private Sub SaveContinueSimpleButton_Click(sender As Object, e As EventArgs) Handles SaveContinueSimpleButton.Click
        If SaveChanges() Then
            Me.SaveContinueSimpleButton.Enabled = False
            Me.BulkEntryGroupControl.Enabled = True
            Me.receivingsXtraTabControl.SelectedTabPage = Me.detailsXtraTabPage
        End If
    End Sub
End Class
