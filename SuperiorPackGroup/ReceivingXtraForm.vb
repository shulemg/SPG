Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraReports.UI
Imports DevExpress.Xpo
Imports DXDAL.SPGData
Imports DevExpress.Xpo.DB

Public Class ReceivingXtraForm

    Private m_lastLPN As Integer = 0
    Private m_Receivings As ReceivingsBLL
    Private m_CustomerReceivings As CustomersBLL
    Private m_Shifts As ShiftsBLL
    Private m_Carriers As CarriersBLL
    Private m_ReceivingDetails As ReceivingDetailsBLL
    Private m_ReturnDetails As ReturnDetailsBLL
    Private m_Items As ItemsBLL
    Private m_UserPermissions As UserPermissionsBLL
    Private m_CurrentReceivingID As Nullable(Of Integer)
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
        Me.QtyPerPalletColumn.FieldName = "ReceivDetQtyPerPallet"
        Me.palletsGridColumn.FieldName = "sngPallets"
        Me.ReceivDetLPNFromColumn.FieldName = "ReceivDetLPNFrom"
        Me.ReceivDetLPNToColumn.FieldName = "ReceivDetLPNTo"
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
        Utilities.MakeGridReadOnly(Me.returnsGridView, True)
        Me.receivingSearchGridControl.Enabled = True

        cancelBarButtonItem.Enabled = False
        saveBarButtonItem.Enabled = False
        refreshBarButtonItem.Enabled = False

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
            Me.receivingItemXPView.Filter = GroupOperator.Or(New BinaryOperator("CustomerID", customer.Value, BinaryOperatorType.Equal),
                                                            New BinaryOperator("CustomerID", CompanySettingsBLL.GetUniversalCustomer, BinaryOperatorType.Equal),
                                                            New InOperator("CustomerID", CustomersBLL.GetRelatedCustomerIDs(CustomersBLL.GetCustomer(customer.Value, m_ReceivingSession))))
            Me.returnItemXPView.Filter = GroupOperator.Or(New BinaryOperator("CustomerID", customer.Value, BinaryOperatorType.Equal),
                                                          New InOperator("CustomerID", CustomersBLL.GetRelatedCustomerIDs(CustomersBLL.GetCustomer(customer.Value, m_ReceivingSession))))
        Else
            Me.receivingItemXPView.Filter = Nothing
            Me.returnItemXPView.Filter = Nothing
        End If

    End Sub

    Private Sub receivingGridView_CustomUnboundColumnData(ByVal sender As Object, ByVal e As Views.Base.CustomColumnDataEventArgs) Handles receivingGridView.CustomUnboundColumnData

        If Not IsDBNull(receivingGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.itemGridColumn)) Then
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
            .SetRowCellValue(e.RowHandle, Me.palletsGridColumn, 0)
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

        If m_CurrentReceivingID.HasValue = False OrElse m_CurrentReceivingID = -1 Then
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
                                Dim lot As String

                                If Not IsDBNull(receivingGridView.GetRowCellValue(ci, lotGridColumn)) Then
                                    lot = receivingGridView.GetRowCellValue(ci, lotGridColumn).ToString
                                Else
                                    lot = String.Empty
                                End If

                                Dim id As Integer? = CType(receivingGridView.GetRowCellValue(ci, idGridColumn), Integer?)
                                Dim item As Integer? = CType(receivingGridView.GetRowCellValue(ci, itemGridColumn), Integer?)
                                Dim qty As Integer? = CType(receivingGridView.GetRowCellValue(ci, quantityGridColumn), Integer?)
                                Dim pckg As Integer? = CType(receivingGridView.GetRowCellValue(ci, packagesGridColumn), Integer?)
                                Dim plts As Single? = CType(receivingGridView.GetRowCellValue(ci, palletsGridColumn), Single?)
                                Dim qtyperplt As Integer? = Utilities.ChangeType(Of Integer?)(receivingGridView.GetRowCellValue(ci, QtyPerPalletColumn))
                                Dim lpnfrm As Integer? = Utilities.ChangeType(Of Integer?)(receivingGridView.GetRowCellValue(ci, ReceivDetLPNFromColumn))
                                Dim lpnto As Integer? = Utilities.ChangeType(Of Integer?)(receivingGridView.GetRowCellValue(ci, ReceivDetLPNToColumn))
                                Dim expr As Date? = Utilities.ChangeType(Of Date?)(receivingGridView.GetRowCellValue(ci, expirationDateGridColumn))

                                If lpnfrm Is Nothing OrElse lpnto Is Nothing OrElse Convert.ToInt32(Math.Ceiling(plts.Value)) > ((lpnto.Value - lpnfrm.Value) + 1) Then
                                    lpnfrm = GetNextLPN(Convert.ToInt32(Math.Ceiling(plts.Value)))
                                    lpnto = (lpnfrm.Value - 1) + Convert.ToInt32(Math.Ceiling(plts.Value))
                                End If

                                If m_ReceivingDetails.UpdateReceivingDetails(m_ReceivingSession, id, m_CurrentReceivingID.Value, item, lot, qty, pckg, plts, qtyperplt, lpnfrm, lpnto, expr) <> True Then
                                    MessageBox.Show("The receiving details was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    shouldReturn = True : Return False
                                End If
                            Next
                        End If
                        i -= 1
                    End While
                Else
                    'receivingGridView.SelectAll()
                    For i As Integer = 0 To receivingGridView.RowCount - 1
                        If receivingGridView.IsValidRowHandle(i) Then
                            Dim lot As String

                            If Not IsDBNull(receivingGridView.GetRowCellValue(i, lotGridColumn)) Then
                                lot = receivingGridView.GetRowCellValue(i, lotGridColumn).ToString
                            Else
                                lot = String.Empty
                            End If


                            Dim id As Integer? = CType(receivingGridView.GetRowCellValue(i, idGridColumn), Integer?)
                                Dim item As Integer? = CType(receivingGridView.GetRowCellValue(i, itemGridColumn), Integer?)
                                Dim qty As Integer? = CType(receivingGridView.GetRowCellValue(i, quantityGridColumn), Integer?)
                                Dim pckg As Integer? = CType(receivingGridView.GetRowCellValue(i, packagesGridColumn), Integer?)
                                Dim plts As Single? = CType(receivingGridView.GetRowCellValue(i, palletsGridColumn), Single?)
                                Dim qtyperplt As Integer? = Utilities.ChangeType(Of Integer?)(receivingGridView.GetRowCellValue(i, QtyPerPalletColumn))
                                Dim lpnfrm As Integer? = Utilities.ChangeType(Of Integer?)(receivingGridView.GetRowCellValue(i, ReceivDetLPNFromColumn))
                                Dim lpnto As Integer? = Utilities.ChangeType(Of Integer?)(receivingGridView.GetRowCellValue(i, ReceivDetLPNToColumn))
                            Dim expr As Date? = Utilities.ChangeType(Of Date?)(receivingGridView.GetRowCellValue(i, expirationDateGridColumn))

                            If lpnfrm Is Nothing OrElse lpnto Is Nothing OrElse Convert.ToInt32(Math.Ceiling(plts.Value)) > ((lpnto.Value - lpnfrm.Value) + 1) Then
                                lpnfrm = GetNextLPN(Convert.ToInt32(Math.Ceiling(plts.Value)))
                                lpnto = (lpnfrm.Value - 1) + Convert.ToInt32(Math.Ceiling(plts.Value))
                            End If

                            If m_ReceivingDetails.UpdateReceivingDetails(m_ReceivingSession, id, m_CurrentReceivingID.Value, item, lot, qty, pckg, plts, qtyperplt, lpnfrm, lpnto, expr) <> True Then
                                MessageBox.Show("The receiving details was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Me.palletsTextEdit.Text = Format(Convert.ToDouble(palletsGridColumn.SummaryItem.SummaryValue) + Convert.ToDouble(returnPalletsGridColumn.SummaryItem.SummaryValue) +
                                         Math.Ceiling(Convert.ToDouble(Me.skitsTextEdit.EditValue)), "f2")

    End Sub

    Private Sub skitsTextEdit_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles skitsTextEdit.Validated

        UpdateTotalPallets()

    End Sub

    Private Sub receivingGridView_CellValueChanged(ByVal sender As Object, ByVal e As Views.Base.CellValueChangedEventArgs) Handles receivingGridView.CellValueChanged

        With Me.receivingGridView
            If IsNothing(.GetFocusedRowCellValue(Me.itemGridColumn)) OrElse IsDBNull(.GetFocusedRowCellValue(Me.itemGridColumn)) Then Exit Sub
            Select Case e.Column.Name
                Case "itemGridColumn"
                    If Convert.ToDouble(.GetFocusedRowCellValue(Me.quantityGridColumn)) > 0 Then
                        UpdatePallets()
                    End If
                Case "quantityGridColumn"
                    If Convert.ToDouble(.GetFocusedRowCellValue(Me.quantityGridColumn)) > 0 Then
                        UpdatePallets()
                    End If
                Case QtyPerPalletColumn.Name
                    If Not IsDBNull(.GetFocusedRowCellValue(Me.QtyPerPalletColumn)) AndAlso CType(.GetFocusedRowCellValue(Me.QtyPerPalletColumn), Integer) > 0 AndAlso Convert.ToDouble(.GetFocusedRowCellValue(Me.quantityGridColumn)) > 0 Then
                        UpdatePallets()
                    End If
                Case packagesGridColumn.Name
                    If Convert.ToDouble(.GetFocusedRowCellValue(Me.packagesGridColumn)) > 0 Then
                        UpdatePallets()
                    End If
                Case "palletsGridColumn"
                    UpdateTotalPallets()
            End Select
        End With

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

    Public Sub UpdatePallets()

        With Me.receivingGridView
            Dim units As Double
            Dim itemId As Integer

            itemId = CType(.GetRowCellValue(.FocusedRowHandle, Me.itemGridColumn), Integer)
            units = ItemsBLL.GetCaseQuantity(itemId)

            If Convert.ToDouble(.GetFocusedRowCellValue(packagesGridColumn)) < 1 Then
                If units <> 0 Then
                    .SetFocusedRowCellValue(Me.packagesGridColumn, Convert.ToDouble(.GetFocusedRowCellValue(Me.quantityGridColumn)) * units)
                Else
                    .SetFocusedRowCellValue(Me.packagesGridColumn, Convert.ToDouble(.GetFocusedRowCellValue(Me.quantityGridColumn)))
                End If
            End If

            'calculate the quantity
            If Convert.ToDouble(.GetFocusedRowCellValue(quantityGridColumn)) = 0 Then
                If units <> 0 Then
                    .SetFocusedRowCellValue(quantityGridColumn, Math.Ceiling(Convert.ToDouble(.GetFocusedRowCellValue(packagesGridColumn)) / units))
                Else
                    .SetFocusedRowCellValue(quantityGridColumn, Math.Ceiling(Convert.ToDouble(.GetFocusedRowCellValue(packagesGridColumn))))
                End If
            End If

            If IsDBNull(.GetFocusedRowCellValue(Me.QtyPerPalletColumn)) OrElse CType(.GetFocusedRowCellValue(Me.QtyPerPalletColumn), Integer) = 0 Then
                .SetFocusedRowCellValue(Me.QtyPerPalletColumn, Math.Max(m_Items.GetCasesPerPallet(itemId), 1))
            End If

            .SetFocusedRowCellValue(Me.palletsGridColumn, Convert.ToDouble(.GetFocusedRowCellValue(Me.quantityGridColumn)) / CType(.GetFocusedRowCellValue(Me.QtyPerPalletColumn), Integer))

        End With

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
        Me.receivingGridView.OptionsBehavior.Editable = True
        Utilities.MakeGridReadOnly(Me.returnsGridView, False)
        Me.receivingSearchGridControl.Enabled = False
        CheckPermissions()

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
        Me.receivingGridView.OptionsBehavior.Editable = True
        Utilities.MakeGridReadOnly(Me.returnsGridView, False)
        Me.receivingSearchGridControl.Enabled = False
        CheckPermissions()

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

        Utilities.MakeFormReadOnly(Me.generalXtraTabPage, True)
        Me.receivingGridView.OptionsBehavior.Editable = False
        Utilities.MakeGridReadOnly(Me.returnsGridView, True)
        Me.receivingSearchGridControl.Enabled = True

        cancelBarButtonItem.Enabled = False
        saveBarButtonItem.Enabled = False
        refreshBarButtonItem.Enabled = True

    End Sub

    Private Sub saveBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles saveBarButtonItem.ItemClick

        If SaveChanges() Then

            CheckPermissions()

            Utilities.MakeFormReadOnly(Me.generalXtraTabPage, True)
            Me.receivingGridView.OptionsBehavior.Editable = False
            Utilities.MakeGridReadOnly(Me.returnsGridView, True)
            Me.receivingSearchGridControl.Enabled = True

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
        Me.customersXPView.Criteria = GroupOperator.And(New BinaryOperator(Customers.Fields.Inactive.PropertyName, False),
                                                             New InOperator(Customers.Fields.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ReceivingSession)))
        Me.receivingItemXPView.Criteria = GroupOperator.And(New InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ReceivingSession)),
                                                           New InOperator(Items.Fields.ItemType.PropertyName, New String() {"RM", "IG"}))
        Me.returnItemXPView.Criteria = GroupOperator.And(GroupOperator.Or(New InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ReceivingSession)),
                                                                          New BinaryOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, CompanySettingsBLL.GetUniversalCustomer, BinaryOperatorType.Equal)),
                                                                  New BinaryOperator(Items.Fields.ItemType.PropertyName, "FG", BinaryOperatorType.Equal))

    End Sub

    Private Sub CancelChanges()

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

            Case DevExpress.Data.CustomSummaryProcess.Calculate
                m_TotalPallets += Math.Ceiling(Convert.ToDouble(receivingGridView.GetRowCellValue(e.RowHandle, palletsGridColumn)))

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

        If MessageBox.Show("Are you sure you want to delete this receiving detail.", "Delete Receiving Detail", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Try
            Dim lReceivingDetailID As Integer = CInt(Me.receivingGridView.GetRowCellValue(Me.receivingGridView.FocusedRowHandle, Me.idGridColumn))
            If lReceivingDetailID <= -1 Then
                Me.receivingGridView.DeleteRow(Me.receivingGridView.FocusedRowHandle)
            ElseIf m_ReceivingDetails.DeleteReceivingDetail(m_ReceivingSession, lReceivingDetailID) = True Then
                BindReceivingGridControl(m_CurrentReceivingID)
            Else
                MessageBox.Show("The receiving detail was not deleted.")
            End If
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

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

        receivingItemXPView.Filter = GroupOperator.And(receivingItemXPView.Filter, New BinaryOperator("Inactive", False))
        returnItemXPView.Filter = GroupOperator.And(returnItemXPView.Filter, New BinaryOperator("Inactive", False))

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

    Private Sub printLpn()

    End Sub

    Private Function GetNextLPN(LPNcount As Integer) As Integer
        Dim nextLPN As Integer = 0
        Dim customer As Customers = Session.DefaultSession.GetObjectByKey(Of Customers)(7)

        customer.Reload()
        If customer.NextLPNNumber > 0 Then
            nextLPN = customer.NextLPNNumber
            customer.NextLPNNumber += LPNcount
            customer.Save()
        Else
            If customer.FirstLPNNumber.HasValue Then
                nextLPN = customer.FirstLPNNumber.Value
                customer.NextLPNNumber = nextLPN + LPNcount
                customer.Save()
            End If
        End If

        If nextLPN > customer.LastLPNNumber Then
            MessageBox.Show("You ran out of LPN numbers, you must provide a different range of numbers before creating a new LPN number")
            nextLPN = 0
        End If

        If nextLPN = customer.LastLPNNumber Then
            MessageBox.Show("You used now your last LPN number, please provide a different range of numbers before creating a new LPN number")
        End If

        Return nextLPN

        'Dim sort As New SortProperty("ReceivDetLPNTo", SortingDirection.Descending)

        'Dim collection As New XPCollection(GetType(ReceivingDetail), Nothing, sort)

        'collection.TopReturnedObjects = 1

        'If collection.Count > 0 AndAlso CType(collection(0), ReceivingDetail).ReceivDetLPNTo > 1000 Then ' SQL Server is queried at this point

        '    Dim ReceivingDetail As ReceivingDetail = CType(collection(0), ReceivingDetail)
        '    Return Math.Max(m_lastLPN, ReceivingDetail.ReceivDetLPNTo.Value) + 1

        'Else

        '    Return 1001

        'End If

    End Function

End Class
