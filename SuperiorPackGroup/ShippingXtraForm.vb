Imports System.Text
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DXDAL.SPGData
Imports DevExpress.XtraReports.UI

Public Class ShippingXtraForm

    Private m_Shippings As ShippingsBLL
    Private m_CustomerShippings As CustomersBLL
    Private m_Carriers As CarriersBLL
    Private m_Items As ItemsBLL
    Private m_ShippingDetails As ShippingDetailsBLL
    Private m_Destinations As ShippingAddressBLL
    Private m_Shifts As ShiftsBLL
    Private m_ShippingReturnDetails As ShippingReturnDetailsBLL
    Private m_UserPermissions As UserPermissionsBLL
    Private m_CurrentShippingID As Integer?
    Private m_CanSaveDetails As Boolean = True
    Private m_CanSaveReturns As Boolean = True
    Private ReadOnly m_ShippingSession As Session = New Session(SPGDataLayer) With {.TrackPropertiesModifications = True, .OptimisticLockingReadBehavior = OptimisticLockingReadBehavior.MergeCollisionThrowException}

    Private Sub ShippingXtraForm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing

        If shippingSearchGridControl.Enabled = False Then
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

    Private Sub ShippingXtraForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        Me.Cursor = Cursors.WaitCursor
        m_Shippings = New ShippingsBLL
        m_CustomerShippings = New CustomersBLL
        m_Carriers = New CarriersBLL
        m_Items = New ItemsBLL
        m_ShippingDetails = New ShippingDetailsBLL
        m_Destinations = New ShippingAddressBLL
        m_UserPermissions = New UserPermissionsBLL
        m_Shifts = New ShiftsBLL
        m_ShippingReturnDetails = New ShippingReturnDetailsBLL

        LinkSession()

        CheckPermissions()

        BindShippingSearchGrid()

        shiftLookUpEdit.Properties.DataSource = m_Shifts.GetShifts
        Me.shiftLookUpEdit.Properties.Columns.Add(New LookUpColumnInfo)
        Me.shiftLookUpEdit.Properties.Columns(0).FieldName = "ShiftName"
        Me.shiftLookUpEdit.Properties.Columns(0).Caption = "Shift"
        Me.shiftLookUpEdit.Properties.DisplayMember = "ShiftName"
        Me.shiftLookUpEdit.Properties.ValueMember = "ShiftID"

        carrierLookUpEdit.Properties.DataSource = m_Carriers.GetCarrierIDAndNames
        Me.carrierLookUpEdit.Properties.Columns.Add(New LookUpColumnInfo)
        Me.carrierLookUpEdit.Properties.Columns(0).FieldName = "CarrierName"
        Me.carrierLookUpEdit.Properties.Columns(0).Caption = "Carrier Name"
        Me.carrierLookUpEdit.Properties.DisplayMember = "CarrierName"
        Me.carrierLookUpEdit.Properties.ValueMember = "CarrierID"

        destinationLookUpEdit.Properties.DataSource = m_Destinations.GetAddressNameAndIDS
        Me.destinationLookUpEdit.Properties.Columns.Add(New LookUpColumnInfo)
        Me.destinationLookUpEdit.Properties.Columns(0).FieldName = "ShippingName"
        Me.destinationLookUpEdit.Properties.Columns(0).Caption = "Destination"
        Me.destinationLookUpEdit.Properties.DisplayMember = "ShippingName"
        Me.destinationLookUpEdit.Properties.ValueMember = "AddressID"

        Me.idGridColumn.FieldName = "ShipDetDetID"
        Me.shippingIDGridColumn.FieldName = "ShipDetMainID"
        Me.itemGridColumn.FieldName = "ShipDetItemID"
        Me.quantityGridColumn.FieldName = "ShipDetDetQty"
        Me.palletsGridColumn.FieldName = "sngPallets"
        Me.lotGridColumn.FieldName = "ShipDetLot"
        Me.noteGridColumn.FieldName = "Note"
        expirationDateGridColumn.FieldName = "ExpirationDate"
        fullLPNNumberGridColumn.FieldName = "FullLPNNumber"

        Me.returnIDGridColumn.FieldName = "ReturnDetID"
        Me.ShippingMainIDGridColumn.FieldName = "ShipMainID"
        Me.returnItemGridColumn.FieldName = "ReturnDetItemID"
        Me.returnQuantityGridColumn.FieldName = "ReturnDetQty"
        returnUnitsGridColumn.FieldName = "intUnits"
        Me.returnPalletsGridColumn.FieldName = "sngPallets"
        Me.returnLotGridColumn.FieldName = "ReturnDetLot"
        Me.returnReasonGridColumn.FieldName = "Reason"
        returnExpirationDateGridColumn.FieldName = "ExpirationDate"

        Utilities.MakeFormReadOnly(Me.generalXtraTabPage, True)
        Utilities.MakeFormReadOnly(Me.shipmentInfoXtraTabPage, True)
        Me.shippingGridView.OptionsBehavior.Editable = False
        lpnNumberTextEdit.Properties.ReadOnly = True
        'Utilities.MakeGridReadOnly(Me.returnsGridView, True)
        Me.shippingSearchGridControl.Enabled = True

        cancelBarButtonItem.Enabled = False
        saveBarButtonItem.Enabled = False
        refreshBarButtonItem.Enabled = False

        Me.Cursor = Cursors.Default

    End Sub

    Private Function SaveChanges() As Boolean

        'make sure that the record gets validated before saving by moving off the record being edited
        shippingGridView.CloseEditor()
        shippingGridView.MoveNext()
        'returnsGridView.CloseEditor()
        'returnsGridView.MoveNext()

        If m_CanSaveDetails = False OrElse m_CanSaveReturns = False OrElse ValidateAvailability() = False Then
            Return False
        End If

        UpdateTotalPallets()

        'If ValidateAvailability() = False Then
        '    Return False
        'End If

        Dim selectedID As Integer = -1
        If m_CurrentShippingID.HasValue = False OrElse m_CurrentShippingID = -1 Then
            m_CurrentShippingID = ShippingsBLL.GetNewItemID()
        Else
            selectedID = shippingSearchGridView.FocusedRowHandle
        End If

        Dim lShouldReturn As Boolean
        Dim lResult As Boolean = SaveShippingMain(lShouldReturn)
        If lShouldReturn Then
            Return lResult
        End If

        Dim lShouldReturn1 As Boolean
        Dim lResult1 As Boolean = SaveShippingDetails(lShouldReturn1)
        If lShouldReturn1 Then
            Return lResult1
        End If

#Region "SaveReturnsDetails"
        'Try
        '    returnsGridView.CloseEditor()
        '    If returnsGridView.GroupCount > 0 Then
        '        Dim i As Integer = -1
        '        While returnsGridView.IsValidRowHandle(i)
        '            If returnsGridView.GetChildRowHandle(i, 0) > -1 Then
        '                For ci As Integer = returnsGridView.GetChildRowHandle(i, 0) To returnsGridView.GetChildRowCount(i) + returnsGridView.GetChildRowHandle(i, 0) - 1
        '                    Dim lot As String
        '                    Dim reason As String
        '                    If Not IsDBNull(returnsGridView.GetRowCellValue(ci, returnLotGridColumn)) Then
        '                        lot = returnsGridView.GetRowCellValue(ci, returnLotGridColumn).ToString
        '                    Else
        '                        lot = String.Empty
        '                    End If
        '                    If Not IsDBNull(returnsGridView.GetRowCellValue(ci, returnReasonGridColumn)) Then
        '                        reason = returnsGridView.GetRowCellValue(ci, returnReasonGridColumn).ToString
        '                    Else
        '                        reason = String.Empty
        '                    End If
        '                    If m_ShippingReturnDetails.UpdateShippingReturnDetails(m_ShippingSession, CType(returnsGridView.GetRowCellValue(ci, returnIDGridColumn), Integer?), m_CurrentShippingID.Value, _
        '                                                                           CType(returnsGridView.GetRowCellValue(ci, returnItemGridColumn), Integer?), lot, _
        '                                                                           CType(returnsGridView.GetRowCellValue(ci, returnQuantityGridColumn), Integer?), CType(returnsGridView.GetRowCellValue(ci, returnUnitsGridColumn), Integer?),
        '                                                                           CType(returnsGridView.GetRowCellValue(ci, returnPalletsGridColumn), Single?), reason,
        '                                                                           Utilities.ChangeType(Of Date?)(returnsGridView.GetRowCellValue(ci, returnExpirationDateGridColumn))) <> True Then
        '                        MessageBox.Show("The return details were not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '                        Return False
        '                    End If
        '                Next
        '            End If
        '            i -= 1
        '        End While
        '    Else
        '        For i As Integer = 0 To returnsGridView.RowCount - 1
        '            If returnsGridView.IsValidRowHandle(i) Then
        '                Dim lot As String
        '                Dim reason As String
        '                If Not IsDBNull(returnsGridView.GetRowCellValue(i, returnLotGridColumn)) Then
        '                    lot = returnsGridView.GetRowCellValue(i, returnLotGridColumn).ToString
        '                Else
        '                    lot = String.Empty
        '                End If
        '                If Not IsDBNull(returnsGridView.GetRowCellValue(i, returnReasonGridColumn)) Then
        '                    reason = returnsGridView.GetRowCellValue(i, returnReasonGridColumn).ToString
        '                Else
        '                    reason = String.Empty
        '                End If
        '                If m_ShippingReturnDetails.UpdateShippingReturnDetails(m_ShippingSession, CType(returnsGridView.GetRowCellValue(i, returnIDGridColumn), Integer?), m_CurrentShippingID.Value, _
        '                                                                       CType(returnsGridView.GetRowCellValue(i, returnItemGridColumn), Integer?), lot, _
        '                                                                       CType(returnsGridView.GetRowCellValue(i, returnQuantityGridColumn), Integer?), CType(returnsGridView.GetRowCellValue(i, returnUnitsGridColumn), Integer?),
        '                                                                       CType(returnsGridView.GetRowCellValue(i, returnPalletsGridColumn), Single?), reason,
        '                                                                       Utilities.ChangeType(Of Date?)(returnsGridView.GetRowCellValue(i, returnExpirationDateGridColumn))) <> True Then
        '                    MessageBox.Show("The return details were not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '                    Return False
        '                End If
        '            End If
        '        Next
        '    End If
        'Catch ex As ApplicationException
        '    MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return False
        'End Try
#End Region


        'm_ShippingSession.CommitTransaction()

        BindShippingSearchGrid()
        BindShippingsControls(m_CurrentShippingID.Value)
        If selectedID <> -1 Then
            Me.shippingSearchGridView.FocusedRowHandle = selectedID
        End If
        Return True

    End Function

    Private Function SaveShippingDetails(ByRef shouldReturn As Boolean) As Boolean

        shouldReturn = False
        Try
            shippingGridView.CloseEditor()
            If shippingGridView.GroupCount > 0 Then
                Dim i As Integer = -1
                While shippingGridView.IsValidRowHandle(i)
                    If shippingGridView.GetChildRowHandle(i, 0) > -1 Then
                        For ci As Integer = shippingGridView.GetChildRowHandle(i, 0) To shippingGridView.GetChildRowCount(i) + shippingGridView.GetChildRowHandle(i, 0) - 1
                            Dim lot As String
                            Dim note As String
                            If Not IsDBNull(shippingGridView.GetRowCellValue(ci, lotGridColumn)) Then
                                lot = shippingGridView.GetRowCellValue(ci, lotGridColumn).ToString
                            Else
                                lot = String.Empty
                            End If
                            If Not IsDBNull(shippingGridView.GetRowCellValue(ci, noteGridColumn)) Then
                                note = shippingGridView.GetRowCellValue(ci, noteGridColumn).ToString
                            Else
                                note = String.Empty
                            End If
                            If m_ShippingDetails.UpdateShippingDetails(m_ShippingSession, CType(shippingGridView.GetRowCellValue(ci, idGridColumn), Integer?), _
                                    m_CurrentShippingID.Value, CType(shippingGridView.GetRowCellValue(ci, itemGridColumn), Integer?), _
                                    lot, CType(shippingGridView.GetRowCellValue(ci, quantityGridColumn), Integer?), CType(shippingGridView.GetRowCellValue(ci, palletsGridColumn), Single?), _
                                    note, Utilities.ChangeType(Of Date?)(shippingGridView.GetRowCellValue(ci, expirationDateGridColumn)),
                                    Utilities.ChangeType(Of String)(shippingGridView.GetRowCellValue(ci, fullLPNNumberGridColumn))) <> True Then
                                MessageBox.Show("The shipping details was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                shouldReturn = True : Return False
                            End If
                        Next
                    End If
                    i -= 1
                End While
            Else
                For i As Integer = 0 To shippingGridView.RowCount - 1
                    If shippingGridView.IsValidRowHandle(i) Then
                        Dim lot As String
                        Dim note As String
                        If Not IsDBNull(shippingGridView.GetRowCellValue(i, lotGridColumn)) Then
                            lot = shippingGridView.GetRowCellValue(i, lotGridColumn).ToString
                        Else
                            lot = String.Empty
                        End If
                        If Not IsDBNull(shippingGridView.GetRowCellValue(i, noteGridColumn)) Then
                            note = shippingGridView.GetRowCellValue(i, noteGridColumn).ToString
                        Else
                            note = String.Empty
                        End If
                        If m_ShippingDetails.UpdateShippingDetails(m_ShippingSession, CType(shippingGridView.GetRowCellValue(i, idGridColumn), Integer?), _
                                m_CurrentShippingID.Value, CType(shippingGridView.GetRowCellValue(i, itemGridColumn), Integer?), _
                                lot, CType(shippingGridView.GetRowCellValue(i, quantityGridColumn), Integer?), CType(shippingGridView.GetRowCellValue(i, palletsGridColumn), Single?), _
                                note, Utilities.ChangeType(Of Date?)(shippingGridView.GetRowCellValue(i, expirationDateGridColumn)),
                                Utilities.ChangeType(Of String)(shippingGridView.GetRowCellValue(i, fullLPNNumberGridColumn))) <> True Then
                            MessageBox.Show("The shipping details was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            shouldReturn = True : Return False
                        End If
                    End If
                Next
            End If

            For Each lpnInventory As String In m_LPNsInShipment
                For Each lpnRecord As Inventory In InventoryBLL.GetLPNInventoryRecords(m_ShippingSession, lpnInventory, CInt(customerLookUpEdit.EditValue))
                    lpnRecord.Shipment = m_ShippingSession.GetObjectByKey(Of Shipping)(m_CurrentShippingID.Value)
                    lpnRecord.Save()
                Next
            Next
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
            shouldReturn = True : Return False
        End Try
        Return False

    End Function

    Private Function SaveShippingMain(ByRef shouldReturn As Boolean) As Boolean

        shouldReturn = False
        Try
            If m_Shippings.UpdateShipping(m_CurrentShippingID.Value, CType(shipDateEdit.EditValue, Date?), CType(carrierLookUpEdit.EditValue, Integer?), CType(customerLookUpEdit.EditValue, Integer?), _
                                          CType(bolTextEdit.EditValue, Integer?), CType(destinationLookUpEdit.EditValue, Integer?), poTextEdit.Text, trailerTextEdit.Text,
                                          Utilities.ChangeType(Of Single?)(skitsTextEdit.EditValue), Utilities.ChangeType(Of Single?)(palletsTextEdit.EditValue), sealTextEdit.Text, noteMemoEdit.Text,
                                          Convert.ToString(deliveryNoteNumberTextEdit.EditValue), Convert.ToDouble(totalGrossWeightTextEdit.EditValue), customerShipperCheckEdit.Checked,
                                          Convert.ToString(commentsMemoEdit.EditValue), CType(shiftLookUpEdit.EditValue, Integer?), freightCheckEdit.Checked, CType(loadedByLookUpEdit.EditValue, Integer?),
                                          CType(checkedByLookUpEdit.EditValue, Integer?), GetThreeWayYesNoValue(wheelsChockedComboBoxEdit.Text), CType(startTimeTimeEdit.EditValue, DateTime?), CType(finishTimeTimeEdit.EditValue, DateTime?),
                                          Utilities.ChangeType(Of Double?)(temparatureSpinEdit.EditValue), CType(physicalConditionLookUpEdit.EditValue, Integer?), CType(loadConditionLookUpEdit.EditValue, Integer?),
                                          GetThreeWayYesNoValue(foreignSubstanceComboBoxEdit.Text), GetThreeWayYesNoValue(insectActivityComboBoxEdit.Text), GetThreeWayYesNoValue(correctPalletsComboBoxEdit.Text),
                                          CType(locationLookUpEdit.EditValue, Integer)) <> True Then
                MessageBox.Show("The shipping was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
                shouldReturn = True : Return False
            End If
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
            shouldReturn = True : Return False
        End Try

        Return False

    End Function

    Private Sub skitsTextEdit_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles skitsTextEdit.Validated

        UpdateTotalPallets()

    End Sub

    Private Sub customerLookUpEdit_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles customerLookUpEdit.Validated

        BindItemLookupEdit()

    End Sub

    Public Sub BindShippingSearchGrid()

        Me.shippingSearchXPView.Reload()

    End Sub

    Public Sub BindShippingsControls(ByVal shippingID As Integer)

        If shippingID = -1 Then
            Exit Sub
        End If

        'Dim shipping As SPG.ShippingsRow = CType(m_Shippings.GetShippingByID(shippingID).Rows(0), SPG.ShippingsRow)
        Dim shipping As Shipping = m_ShippingSession.GetObjectByKey(Of Shipping)(shippingID)
        If shipping Is Nothing Then
            Exit Sub
        End If
        m_CurrentShippingID = shipping.ShipMainID
        Me.customerLookUpEdit.EditValue = shipping.ShipMainCustID.CustomerID
        Me.shipDateEdit.EditValue = shipping.ShipMainDate
        Me.bolTextEdit.EditValue = shipping.ShipMainBOL
        Me.poTextEdit.Text = shipping.strPO
        Me.carrierLookUpEdit.EditValue = shipping.ShipMainCarrierID.CarrierID
        Me.trailerTextEdit.Text = shipping.strTrailer
        Me.sealTextEdit.Text = shipping.strSeal
        Me.skitsTextEdit.EditValue = shipping.sngSkits
        Me.palletsTextEdit.EditValue = shipping.sngTotalPallets
        Me.destinationLookUpEdit.EditValue = shipping.intDestination.AddressID
        UpdateDestinationAddress(shipping.intDestination.AddressID)
        Me.noteMemoEdit.Text = shipping.strDeliveryNote
        Me.deliveryNoteNumberTextEdit.EditValue = shipping.DeliveryNoteNumber
        Me.totalGrossWeightTextEdit.EditValue = shipping.TotalGrossWeight
        Me.customerShipperCheckEdit.Checked = shipping.Shipper
        Me.commentsMemoEdit.EditValue = shipping.Comments
        If shipping.Shift Is Nothing Then
            shiftLookUpEdit.EditValue = Nothing
        Else
            shiftLookUpEdit.EditValue = shipping.Shift.ShiftID
        End If
        Me.freightCheckEdit.Checked = shipping.Freight
        If shipping.LoadedBy Is Nothing Then
            loadedByLookUpEdit.EditValue = Nothing
        Else
            loadedByLookUpEdit.EditValue = shipping.LoadedBy.Oid
        End If
        If shipping.CheckedBy Is Nothing Then
            checkedByLookUpEdit.EditValue = Nothing
        Else
            checkedByLookUpEdit.EditValue = shipping.CheckedBy.Oid
        End If

        If shipping.WheelsChocked = Nothing Then
            wheelsChockedComboBoxEdit.EditValue = Nothing
        Else
            wheelsChockedComboBoxEdit.EditValue = [Enum].GetName(GetType(DXDAL.ThreeWayYesNo), shipping.WheelsChocked)
        End If
        If shipping.StartTime = Nothing Then
            startTimeTimeEdit.EditValue = Nothing
        Else
            startTimeTimeEdit.EditValue = shipping.StartTime
        End If
        If shipping.FinishTime = Nothing Then
            finishTimeTimeEdit.EditValue = Nothing
        Else
            finishTimeTimeEdit.EditValue = shipping.FinishTime
        End If
        temparatureSpinEdit.EditValue = shipping.Temparature
        If shipping.PhysicalCondition Is Nothing Then
            physicalConditionLookUpEdit.EditValue = Nothing
        Else
            physicalConditionLookUpEdit.EditValue = shipping.PhysicalCondition.Oid
        End If
        If shipping.LoadCondition Is Nothing Then
            loadConditionLookUpEdit.EditValue = Nothing
        Else
            loadConditionLookUpEdit.EditValue = shipping.LoadCondition.Oid
        End If

        If shipping.ForeignSubstance = Nothing Then
            foreignSubstanceComboBoxEdit.EditValue = Nothing
        Else
            foreignSubstanceComboBoxEdit.EditValue = [Enum].GetName(GetType(DXDAL.ThreeWayYesNo), shipping.ForeignSubstance)
        End If
        If shipping.InsectActivity = Nothing Then
            insectActivityComboBoxEdit.EditValue = Nothing
        Else
            insectActivityComboBoxEdit.EditValue = [Enum].GetName(GetType(DXDAL.ThreeWayYesNo), shipping.InsectActivity)
        End If
        If shipping.CorrectPallets = Nothing Then
            correctPalletsComboBoxEdit.EditValue = Nothing
        Else
            correctPalletsComboBoxEdit.EditValue = [Enum].GetName(GetType(DXDAL.ThreeWayYesNo), shipping.CorrectPallets)
        End If
        locationLookUpEdit.EditValue = shipping.ShippingLocation.Oid

        'fill details tab
        BindItemLookupEdit()

        BindShippingGridControl(shippingID)

        'fill returns tab
        BindReturnsGridControl(shippingID)

        refreshBarButtonItem.Enabled = True

    End Sub

    Public Sub UpdateDestinationAddress(ByVal addressID As Integer)

        Dim destinations As SPG.ShippingAddressesDataTable = m_Destinations.GetAddressInfoByID(addressID)
        If destinations.Count = 0 Then
            Me.destinationMemoEdit.Text = ""
        Else
            Dim destination As SPG.ShippingAddressesRow = CType(destinations.Rows(0), SPG.ShippingAddressesRow)
            Dim destinationBuilder As StringBuilder = New StringBuilder(String.Format("{0}{1}", destination.ShippingName, vbCrLf))
            If Not String.IsNullOrEmpty(destination.ContactFirstName) OrElse Not String.IsNullOrEmpty(destination.ContactLastName) Then
                destinationBuilder.AppendFormat("{0} {1}{2}", destination.ContactFirstName, destination.ContactLastName, vbCrLf)
            End If
            destinationBuilder.Append(String.Format("{0}{1}", destination.ShippingAddress, vbCrLf))
            destinationBuilder.AppendFormat("{0}, {1} {2}{3}", destination.ShippingCity, destination.ShippingState, destination.ShippingPostal, vbCrLf)
            destinationBuilder.Append(destination.ShippingPhone)
            Me.destinationMemoEdit.Text = destinationBuilder.ToString()
        End If

    End Sub

    Public Sub BindItemLookupEdit()

        Dim customer As Integer? = CType(Me.customerLookUpEdit.EditValue, Integer?)
        If customer.HasValue Then
            Me.shippingItemXPView.Filter = CriteriaOperator.Or(New BinaryOperator("CustomerID", customer.Value, BinaryOperatorType.Equal), _
                                                            New BinaryOperator("CustomerID", CompanySettingsBLL.GetUniversalCustomer, BinaryOperatorType.Equal),
                                                            New InOperator("CustomerID", CustomersBLL.GetRelatedCustomerIDs(CustomersBLL.GetCustomer(customer.Value, m_ShippingSession))))
            Me.returnItemXPView.Filter = CriteriaOperator.Or(New BinaryOperator("CustomerID", customer.Value, BinaryOperatorType.Equal),
                                                          New InOperator("CustomerID", CustomersBLL.GetRelatedCustomerIDs(CustomersBLL.GetCustomer(customer.Value, m_ShippingSession))))
        Else
            Me.shippingItemXPView.Filter = Nothing
            Me.returnItemXPView.Filter = Nothing
        End If

    End Sub

    Public Sub BindShippingGridControl(ByVal shippingID As Integer?)

        If shippingID.HasValue = False Then
            shippingID = 0
        End If

        Dim customer As Integer? = CType(Me.customerLookUpEdit.EditValue, Integer?)
        If customer.HasValue Then
            expirationDateGridColumn.DisplayFormat.FormatString = CustomersBLL.GetExpirationDateFormat(customer.Value)
        End If

        shippingGridControl.DataSource = m_ShippingDetails.GetDetailsByShippingID(shippingID.Value)

    End Sub

    Private Sub BindReturnsGridControl(ByVal shippingID As Integer?)

        If shippingID.HasValue = False Then
            shippingID = 0
        End If

        Dim customer As Integer? = CType(Me.customerLookUpEdit.EditValue, Integer?)
        If customer.HasValue Then
            returnExpirationDateGridColumn.DisplayFormat.FormatString = CustomersBLL.GetExpirationDateFormat(customer.Value)
        End If

        Me.returnsGridControl.DataSource = m_ShippingReturnDetails.GetShippingReturnDetailsByShippingID(shippingID.Value)

    End Sub

    Private Sub shippingGridView_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles shippingGridView.CustomUnboundColumnData

        If Not IsDBNull(shippingGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.itemGridColumn)) Then
            Dim shippingItem As Integer = CType(shippingGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.itemGridColumn), Integer)
            If e.Column.Name = descriptionGridColumn.Name Then
                e.Value = ItemsBLL.GetDescriptionByItemID(shippingItem)
            ElseIf e.Column.Name = grossWeightGridColumn.Name Then
                If Not IsDBNull(shippingGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.quantityGridColumn)) Then
                    e.Value = Math.Ceiling(Convert.ToDouble(shippingGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.quantityGridColumn)) / m_Items.GetUnits(shippingItem)) _
                            * m_Items.GetCaseGrossWeight(shippingItem)
                Else
                    e.Value = m_Items.GetCaseGrossWeight(shippingItem)
                End If

            End If
        End If

    End Sub

    Private Sub returnsGridView_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles returnsGridView.CustomUnboundColumnData

        If Not IsDBNull(returnsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.returnItemGridColumn)) Then
            If e.Column.Name = returnItemDescGridColumn.Name Then
                e.Value = ItemsBLL.GetDescriptionByItemID(CType(returnsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.returnItemGridColumn), Integer))
            ElseIf e.Column.Name = returnGrossWeightGridColumn.Name Then
                Dim returnItem As Integer = CType(returnsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.returnItemGridColumn), Integer)
                If Not IsDBNull(returnsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.returnQuantityGridColumn)) Then
                    e.Value = Math.Ceiling(Convert.ToDouble(returnsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.returnQuantityGridColumn)) / m_Items.GetUnits(returnItem) _
                            * m_Items.GetCaseGrossWeight(returnItem))
                Else
                    e.Value = m_Items.GetCaseGrossWeight(returnItem)
                End If
            End If
        End If

    End Sub

    Private Sub shippingGridView_InitNewRow(ByVal sender As Object, ByVal e As InitNewRowEventArgs) Handles shippingGridView.InitNewRow

        With Me.shippingGridView
            .SetRowCellValue(e.RowHandle, Me.shippingIDGridColumn, m_CurrentShippingID)
            .SetRowCellValue(e.RowHandle, Me.quantityGridColumn, 0)
            .SetRowCellValue(e.RowHandle, Me.palletsGridColumn, 0)
        End With

    End Sub

    Private Sub returnsGridView_InitNewRow(ByVal sender As Object, ByVal e As InitNewRowEventArgs) Handles returnsGridView.InitNewRow

        With Me.returnsGridView
            .SetRowCellValue(e.RowHandle, Me.ShippingMainIDGridColumn, m_CurrentShippingID)
            .SetRowCellValue(e.RowHandle, Me.returnQuantityGridColumn, 0)
            .SetRowCellValue(e.RowHandle, returnUnitsGridColumn, 0)
            .SetRowCellValue(e.RowHandle, Me.returnPalletsGridColumn, 0)
        End With

    End Sub

    'Private Sub FilterLookUpEditValidated(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    'BindShippingsListBox()

    'End Sub

    Public Sub UpdateTotalPallets()

        'Makes sure the summary is updated before calculating the total pallets
        Me.shippingGridView.UpdateTotalSummary()
        Me.returnsGridView.UpdateTotalSummary()
        Dim pallets As Integer = Convert.ToInt32(Me.palletsGridColumn.SummaryItem.SummaryValue) + Convert.ToInt32(Me.returnPalletsGridColumn.SummaryItem.SummaryValue) + _
                Convert.ToInt32(Math.Ceiling(Convert.ToDouble(Me.skitsTextEdit.Text)))
        Me.palletsTextEdit.Text = Format(pallets, "f2")
        Me.totalGrossWeightTextEdit.EditValue = Convert.ToDouble(grossWeightGridColumn.SummaryItem.SummaryValue) + Convert.ToDouble(returnGrossWeightGridColumn.SummaryItem.SummaryValue) + (pallets * 40)

    End Sub

    Private Sub shippingGridView_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles shippingGridView.CellValueChanged

        With shippingGridView
            If IsDBNull(.GetFocusedRowCellValue(itemGridColumn)) Then Exit Sub
            Select Case e.Column.Name
                Case "itemGridColumn"
                    If Convert.ToDouble(.GetFocusedRowCellValue(Me.quantityGridColumn)) > 0 Then
                        UpdatePallets()
                    End If
                Case "quantityGridColumn"
                    UpdatePallets()
                Case "palletsGridColumn"
                    UpdateTotalPallets()
            End Select
        End With

    End Sub

    Private Sub returnsGridView_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles returnsGridView.CellValueChanged

        With returnsGridView
            If IsNothing(.GetFocusedRowCellValue(Me.returnItemGridColumn)) OrElse IsDBNull(.GetFocusedRowCellValue(Me.returnItemGridColumn)) Then Exit Sub
            Select Case e.Column.Name
                Case returnItemGridColumn.Name
                    If Convert.ToDouble(.GetFocusedRowCellValue(Me.returnQuantityGridColumn)) > 0 Then
                        UpdateReturnPallets()
                    End If
                Case returnQuantityGridColumn.Name
                    If Convert.ToDouble(.GetFocusedRowCellValue(Me.returnQuantityGridColumn)) > 0 Then
                        UpdateReturnPallets()
                    End If
                Case returnUnitsGridColumn.Name
                    If Convert.ToDouble(.GetFocusedRowCellValue(Me.returnUnitsGridColumn)) > 0 Then
                        UpdateReturnPallets()
                    End If
                Case returnPalletsGridColumn.Name
                    UpdateTotalPallets()
            End Select
        End With

    End Sub

    Private Sub destinationLookUpEdit_Validated(ByVal sender As Object, ByVal e As EventArgs) Handles destinationLookUpEdit.Validated

        UpdateDestinationAddress(CType(Me.destinationLookUpEdit.EditValue, Integer))

    End Sub

    Public Sub UpdatePallets()

        With Me.shippingGridView
            Dim pallets As Single = m_Items.GetCasesPerPallet(CType(.GetFocusedRowCellValue(Me.itemGridColumn), Integer))
            If pallets <> 0 Then
                If .GetFocusedRowCellValue(Me.fullLPNNumberGridColumn) Is Nothing Then
                    .SetFocusedRowCellValue(Me.palletsGridColumn, Math.Ceiling(Convert.ToDouble(.GetFocusedRowCellValue(Me.quantityGridColumn)) / pallets))
                Else
                    .SetFocusedRowCellValue(Me.palletsGridColumn, Convert.ToDouble(.GetFocusedRowCellValue(Me.quantityGridColumn)) / pallets)
                End If
            Else
                .SetFocusedRowCellValue(Me.palletsGridColumn, 0)
            End If
        End With

    End Sub

    Public Sub UpdateReturnPallets()

        With Me.returnsGridView
            Dim units As Double = ItemsBLL.GetCaseQuantity(CType(.GetRowCellValue(.FocusedRowHandle, Me.returnItemGridColumn), Integer))

            If Convert.ToDouble(.GetFocusedRowCellValue(returnUnitsGridColumn)) < 1 Then
                If units <> 0 Then
                    .SetFocusedRowCellValue(Me.returnUnitsGridColumn, Convert.ToDouble(.GetFocusedRowCellValue(Me.returnQuantityGridColumn)) * units)
                Else
                    .SetFocusedRowCellValue(Me.returnUnitsGridColumn, 0)
                End If
            End If

            'calculate the quantity
            If Convert.ToDouble(.GetFocusedRowCellValue(returnQuantityGridColumn)) = 0 Then
                If units <> 0 Then
                    .SetFocusedRowCellValue(returnQuantityGridColumn, Math.Ceiling(Convert.ToDouble(.GetFocusedRowCellValue(returnUnitsGridColumn)) / units))
                End If
            End If

            Dim pallets As Single = m_Items.GetCasesPerPallet(CType(.GetFocusedRowCellValue(Me.returnItemGridColumn), Integer))
            If pallets <> 0 Then
                .SetFocusedRowCellValue(Me.returnPalletsGridColumn, Math.Ceiling(Convert.ToDouble(.GetFocusedRowCellValue(Me.returnQuantityGridColumn)) / pallets))
            Else
                .SetFocusedRowCellValue(Me.returnPalletsGridColumn, 0)
            End If
        End With

    End Sub

    Private Sub shippingSearchGridView_Click(ByVal sender As Object, ByVal e As EventArgs) Handles shippingSearchGridView.Click

        If (Me.shippingSearchGridView.CalcHitInfo(Me.shippingSearchGridControl.PointToClient(Control.MousePosition)).HitTest = GridHitTest.RowCell) Then
            Me.BindShippingsControls(CType(Me.shippingSearchGridView.GetFocusedRowCellValue(Me.shippingSearchIDGridColumn), Integer))
        End If

    End Sub

    Private Sub addBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles addBarButtonItem.ItemClick

        m_CurrentShippingID = -1
        Me.shipDateEdit.EditValue = Nothing
        Me.customerLookUpEdit.EditValue = Nothing
        Me.carrierLookUpEdit.EditValue = Nothing
        bolTextEdit.EditValue = Nothing
        Me.skitsTextEdit.EditValue = 0
        Me.poTextEdit.Text = String.Empty
        Me.palletsTextEdit.EditValue = 0
        Me.trailerTextEdit.Text = String.Empty
        Me.sealTextEdit.Text = String.Empty
        Me.destinationLookUpEdit.EditValue = Nothing
        Me.destinationMemoEdit.Text = ""
        Me.noteMemoEdit.Text = $"{vbNewLine}{vbNewLine}IDEAL REFER TEMPERATURE IS{vbNewLine}65�F - 75�F CANDY{vbNewLine}55�F - 60�F CHOCOLATE"
        Me.deliveryNoteNumberTextEdit.EditValue = String.Empty
        Me.totalGrossWeightTextEdit.EditValue = 0
        Me.customerShipperCheckEdit.Checked = False
        Me.commentsMemoEdit.EditValue = String.Empty
        Me.shiftLookUpEdit.EditValue = Nothing
        Me.freightCheckEdit.Checked = True
        loadedByLookUpEdit.EditValue = Nothing
        checkedByLookUpEdit.EditValue = Nothing
        wheelsChockedComboBoxEdit.EditValue = Nothing
        startTimeTimeEdit.EditValue = Nothing
        finishTimeTimeEdit.EditValue = Nothing
        temparatureSpinEdit.EditValue = Nothing
        physicalConditionLookUpEdit.EditValue = Nothing
        loadConditionLookUpEdit.EditValue = Nothing
        foreignSubstanceComboBoxEdit.EditValue = Nothing
        insectActivityComboBoxEdit.EditValue = Nothing
        correctPalletsComboBoxEdit.EditValue = Nothing
        locationLookUpEdit.EditValue = UsersBLL.GetUsersLocalLocation(m_ShippingSession, My.Settings.UserName).Oid

        BindShippingGridControl(m_CurrentShippingID)
        BindReturnsGridControl(m_CurrentShippingID)

        Me.shippingXtraTabControl.SelectedTabPage = Me.generalXtraTabPage

        Utilities.MakeFormReadOnly(Me.generalXtraTabPage, False)
        Utilities.MakeFormReadOnly(shipmentInfoXtraTabPage, False)
        Me.bolTextEdit.Properties.ReadOnly = True
        Me.palletsTextEdit.Properties.ReadOnly = True
        Me.totalGrossWeightTextEdit.Properties.ReadOnly = True
        Me.destinationMemoEdit.Properties.ReadOnly = True
        Me.shippingGridView.OptionsBehavior.Editable = True
        lpnNumberTextEdit.Properties.ReadOnly = False
        ' Utilities.MakeGridReadOnly(Me.returnsGridView, False)
        Me.shippingSearchGridControl.Enabled = False
        CheckPermissions()

        Me.cancelBarButtonItem.Enabled = True
        Me.saveBarButtonItem.Enabled = True
        Me.editBarButtonItem.Enabled = False
        Me.addBarButtonItem.Enabled = False
        refreshBarButtonItem.Enabled = False

    End Sub

    Private Sub editBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles editBarButtonItem.ItemClick

        If m_CurrentShippingID Is Nothing Then
            MessageBox.Show("Please Select a shipping entry To edit.")
            Exit Sub
        End If

        Utilities.MakeFormReadOnly(Me.generalXtraTabPage, False)
        Utilities.MakeFormReadOnly(shipmentInfoXtraTabPage, False)
        bolTextEdit.Properties.ReadOnly = True
        Me.palletsTextEdit.Properties.ReadOnly = True
        Me.totalGrossWeightTextEdit.Properties.ReadOnly = True
        Me.destinationMemoEdit.Properties.ReadOnly = True
        Me.shippingGridView.OptionsBehavior.Editable = True
        locationLookUpEdit.Properties.ReadOnly = False
        lpnNumberTextEdit.Properties.ReadOnly = False
        'Utilities.MakeGridReadOnly(Me.returnsGridView, False)
        Me.shippingSearchGridControl.Enabled = False
        CheckPermissions()

        Me.cancelBarButtonItem.Enabled = True
        Me.saveBarButtonItem.Enabled = True
        Me.editBarButtonItem.Enabled = False
        Me.addBarButtonItem.Enabled = False
        refreshBarButtonItem.Enabled = False

    End Sub

    Private Sub cancelBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cancelBarButtonItem.ItemClick

        CancelChanges()

        CheckPermissions()

        Utilities.MakeFormReadOnly(Me.generalXtraTabPage, True)
        Utilities.MakeFormReadOnly(shipmentInfoXtraTabPage, True)
        Me.shippingGridView.OptionsBehavior.Editable = False
        lpnNumberTextEdit.Properties.ReadOnly = True
        'Utilities.MakeGridReadOnly(Me.returnsGridView, True)
        Me.shippingSearchGridControl.Enabled = True

        cancelBarButtonItem.Enabled = False
        saveBarButtonItem.Enabled = False
        refreshBarButtonItem.Enabled = True

    End Sub

    Private Sub saveBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles saveBarButtonItem.ItemClick

        If SaveChanges() Then
            CheckPermissions()

            Utilities.MakeFormReadOnly(Me.generalXtraTabPage, True)
            Utilities.MakeFormReadOnly(shipmentInfoXtraTabPage, True)
            Me.shippingGridView.OptionsBehavior.Editable = False
            lpnNumberTextEdit.Properties.ReadOnly = True
            ' Utilities.MakeGridReadOnly(Me.returnsGridView, True)
            Me.shippingSearchGridControl.Enabled = True

            cancelBarButtonItem.Enabled = False
            saveBarButtonItem.Enabled = False
            refreshBarButtonItem.Enabled = True
        End If

    End Sub

    Public Function CheckPermissions() As Boolean

        Try
            Dim permission As SPG.UserPermissionsRow = New UserPermissionsBLL().GetUserPermissionsByUserName(My.Settings.UserName, "Shipping Form")(0)

            Select Case permission.PermissionLevel
                Case "FULL", "Full"
                    Me.addBarButtonItem.Enabled = True
                    Me.editBarButtonItem.Enabled = True
                    Me.delGridColumn.Visible = True
                    Me.deleteReturnGridColumn.Visible = True
                Case "ADD", "Add"
                    Me.addBarButtonItem.Enabled = True
                    Me.editBarButtonItem.Enabled = True
                    Me.delGridColumn.Visible = False
                    Me.deleteReturnGridColumn.Visible = False
                Case "NONE", "None"
                    MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Me.Close()
                    Return False
                Case "VIEW", "View"
                    Me.addBarButtonItem.Enabled = False
                    Me.editBarButtonItem.Enabled = False
                    Me.delGridColumn.Visible = False
                    Me.deleteReturnGridColumn.Visible = False
                Case "EDIT", "Edit"
                    Me.addBarButtonItem.Enabled = False
                    Me.editBarButtonItem.Enabled = True
                    Me.delGridColumn.Visible = False
                    Me.deleteReturnGridColumn.Visible = False
                Case "VIEW ASSIGNED"
                    Me.addBarButtonItem.Enabled = False
                    Me.editBarButtonItem.Enabled = False
                    Me.delGridColumn.Visible = False
                    Me.deleteReturnGridColumn.Visible = False
                    FilterAssignedCustomers()
                Case "EDIT ASSIGNED"
                    Me.addBarButtonItem.Enabled = False
                    Me.editBarButtonItem.Enabled = True
                    Me.delGridColumn.Visible = False
                    Me.deleteReturnGridColumn.Visible = False
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

        Me.shippingSearchXPView.Criteria = New InOperator(Shipping.Fields.ShipMainCustID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ShippingSession))
        Me.customersXPView.Criteria = CriteriaOperator.And(New BinaryOperator(Customers.Fields.Inactive.PropertyName, False), _
                                                             New InOperator(Customers.Fields.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ShippingSession)))
        Me.shippingItemXPView.Criteria = CriteriaOperator.Or(New InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ShippingSession)),
                                                                            New BinaryOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, CompanySettingsBLL.GetUniversalCustomer, BinaryOperatorType.Equal))
        Me.returnItemXPView.Criteria = CriteriaOperator.And(New InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ShippingSession)), _
                                                                  New InOperator(Items.Fields.ItemType.PropertyName, New String() {"RM", "IG"}))

    End Sub

    Private Sub CancelChanges()

        If Me.m_CurrentShippingID IsNot Nothing Then
            BindShippingsControls(m_CurrentShippingID.Value)
        End If

    End Sub

    Private m_TotalPallets As Integer = 0
    Private m_LPNsInShipment As List(Of String) = New List(Of String)

    Private Sub shippingGridView_CustomSummaryCalculate(ByVal sender As Object, ByVal e As DevExpress.Data.CustomSummaryEventArgs) Handles shippingGridView.CustomSummaryCalculate

        Select Case e.SummaryProcess
            Case DevExpress.Data.CustomSummaryProcess.Finalize
                e.TotalValue = m_TotalPallets + m_LPNsInShipment.Count
            Case DevExpress.Data.CustomSummaryProcess.Start
                m_TotalPallets = 0
                m_LPNsInShipment.Clear()
            Case DevExpress.Data.CustomSummaryProcess.Calculate
                If shippingGridView.GetRowCellValue(e.RowHandle, fullLPNNumberGridColumn) Is Nothing OrElse IsDBNull(shippingGridView.GetRowCellValue(e.RowHandle, fullLPNNumberGridColumn)) Then
                    m_TotalPallets += Convert.ToInt32(Math.Ceiling(Convert.ToDouble(shippingGridView.GetRowCellValue(e.RowHandle, palletsGridColumn))))
                Else
                    If Not m_LPNsInShipment.Contains(shippingGridView.GetRowCellValue(e.RowHandle, fullLPNNumberGridColumn).ToString) Then
                        m_LPNsInShipment.Add(shippingGridView.GetRowCellValue(e.RowHandle, fullLPNNumberGridColumn).ToString)
                    End If
                End If

        End Select

    End Sub

    Private m_TotalReturnedPallets As Integer = 0

    Private Sub returnsGridView_CustomSummaryCalculate(ByVal sender As Object, ByVal e As DevExpress.Data.CustomSummaryEventArgs) Handles returnsGridView.CustomSummaryCalculate

        Select Case e.SummaryProcess
            Case DevExpress.Data.CustomSummaryProcess.Finalize
                e.TotalValue = m_TotalReturnedPallets
            Case DevExpress.Data.CustomSummaryProcess.Start
                m_TotalReturnedPallets = 0
            Case DevExpress.Data.CustomSummaryProcess.Calculate
                m_TotalReturnedPallets += Convert.ToInt32(Math.Ceiling(Convert.ToDouble(returnsGridView.GetRowCellValue(e.RowHandle, returnPalletsGridColumn))))

        End Select

    End Sub

    Private Sub printBOLBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles printBOLBarButtonItem.ItemClick

        If m_CurrentShippingID Is Nothing Then
            Exit Sub
        End If

        Dim cstmr As SPG.CustomersRow
        cstmr = m_CustomerShippings.GetCustomerByID(CInt(customerLookUpEdit.EditValue)).Item(0)
        Dim bol As New BillOfLadingXtraReport

        With bol
            .locationId.Text = locationLookUpEdit.Text
            .dateXrLabel.DataBindings.Add("Text", Nothing, "ShipMainDate", "{0:MM/dd/yyyy}")
            .bolXrLabel.DataBindings.Add("Text", Nothing, "ShipMainBOL")
            .poXrLabel.DataBindings.Add("Text", Nothing, "strPO")
            .deliveryNoteNumberXrLabel.DataBindings.Add("Text", Nothing, "DeliveryNoteNumber")
            .carrierXrLabel.DataBindings.Add("Text", Nothing, "CarrierName")
            .trailerXrLabel.DataBindings.Add("Text", Nothing, "strTrailer")
            .sealXrLabel.DataBindings.Add("Text", Nothing, "strSeal")
            .returnsGroupHeader.GroupFields.Add(New GroupField("ShippingType", XRColumnSortOrder.Ascending))
            .itemGroupHeader.GroupFields.Add(New GroupField("ItemCode", XRColumnSortOrder.Ascending))
            .qtyXrLabel.DataBindings.Add("Text", Nothing, "ShipDetDetQty")
            .itemCodeXrLabel.DataBindings.Add("Text", Nothing, "ItemCode")
            .itemDescriptionXrLabel.DataBindings.Add("Text", Nothing, "ItemDescription")
            .palletsXrLabel.DataBindings.Add("Text", Nothing, "sngPallets", "{0:N2}")
            '.additionalPalletsXrLabel.DataBindings.Add("Text", Nothing, "sngSkits")
            .totalPalletsXrLabel.DataBindings.Add("Text", Nothing, "sngTotalPallets", "{0:N2}")
            .palletsTotalXrLabel.DataBindings.Add("Text", Nothing, "sngTotalPallets", "{0:N2}")
            .weightXrLabel.DataBindings.Add("Text", Nothing, "Weight", "{0:N2}")
            .totalWeightXrLabel.DataBindings.Add("Text", Nothing, "TotalGrossWeight", "{0:N2}")
            .notesXrLabel.DataBindings.Add("Text", Nothing, "strDeliveryNote")
            .freightXrCheckBox.DataBindings.Add("Checked", Nothing, "Freight")
            .itemTotalQuantityXrLabel.DataBindings.Add("Text", Nothing, "ShipDetDetQty")
            .groupItemCodeXrLabel.DataBindings.Add("Text", Nothing, "ItemCode")
            .groupItemDescriptionXrLabel.DataBindings.Add("Text", Nothing, "ItemDescription")
            .itemTotalPalletsXrLabel.DataBindings.Add("Text", Nothing, "sngPallets", "{0:N2}")
            .itemTotalWeightXrLabel.DataBindings.Add("Text", Nothing, "Weight", "{0:N2}")
            .billTo.Text = $"{cstmr.CustomerName}{vbNewLine}{cstmr.Address}{vbNewLine}{cstmr.City}, {cstmr.State} {cstmr.ZipCode}"
            .DataSource = New BOLReportBLL().Getbolreport(m_CurrentShippingID.Value)
            .ShowPreview()
        End With

    End Sub

    Private Sub returnsGridView_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles returnsGridView.ValidateRow

        Dim stock As Double = ItemsBLL.GetQtyOnHandByID(m_ShippingSession, CInt(returnsGridView.GetRowCellValue(e.RowHandle, returnItemGridColumn)), CInt(locationLookUpEdit.EditValue))
        Dim returnQuantity As Double
        If CInt(returnsGridView.GetRowCellValue(e.RowHandle, returnIDGridColumn)) < 1 Then
            returnQuantity = CDbl(returnsGridView.GetRowCellValue(e.RowHandle, returnQuantityGridColumn))
        Else
            returnQuantity = CDbl(returnsGridView.GetRowCellValue(e.RowHandle, returnQuantityGridColumn)) - CInt(returnsGridView.GetDataRow(e.RowHandle)(4, DataRowVersion.Original))
        End If

        If stock < returnQuantity Then
            MessageBox.Show(String.Format("{0} does only have {1} in stock and your returning {2}.", returnsGridView.GetRowCellDisplayText(e.RowHandle, returnItemGridColumn).ToString,
                                          stock.ToString, returnQuantity.ToString), "Stock Verification", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            e.Valid = False
            m_CanSaveReturns = False
        Else
            m_CanSaveReturns = True
        End If

    End Sub

    Private Sub deleteReturnRepositoryItemButtonEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles deleteReturnRepositoryItemButtonEdit.Click

        If MessageBox.Show("Are you sure you want to delete this return.", "Delete Return", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Try
            Dim lShippingReturnDetailID As Integer = CInt(Me.returnsGridView.GetRowCellValue(Me.returnsGridView.FocusedRowHandle, Me.returnIDGridColumn))
            If lShippingReturnDetailID <= -1 Then
                Me.returnsGridView.DeleteRow(Me.returnsGridView.FocusedRowHandle)
            ElseIf m_ShippingReturnDetails.DeleteReturnDetail(m_ShippingSession, lShippingReturnDetailID) = True Then
                BindReturnsGridControl(m_CurrentShippingID)
            Else
                MessageBox.Show("The return was not deleted.")
            End If
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub delRepositoryItemButtonEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles delRepositoryItemButtonEdit.Click

        If shippingGridView.GetRowCellValue(shippingGridView.FocusedRowHandle, fullLPNNumberGridColumn) Is Nothing OrElse IsDBNull(shippingGridView.GetRowCellValue(shippingGridView.FocusedRowHandle, fullLPNNumberGridColumn)) Then
            If MessageBox.Show("Are you sure you want to delete this shipping detail.", "Delete shipping detail", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        Else
            If MessageBox.Show("Are you sure you want to delete this LPN from the shipping detail.", "Delete LPN shipping detail", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If
        
        Dim lShippingDetailID As Integer
        Try
            If shippingGridView.GetRowCellValue(shippingGridView.FocusedRowHandle, fullLPNNumberGridColumn) Is Nothing OrElse IsDBNull(shippingGridView.GetRowCellValue(shippingGridView.FocusedRowHandle, fullLPNNumberGridColumn)) Then
                lShippingDetailID = CInt(Me.shippingGridView.GetRowCellValue(Me.shippingGridView.FocusedRowHandle, Me.idGridColumn))
                If lShippingDetailID <= -1 Then
                    Me.shippingGridView.DeleteRow(Me.shippingGridView.FocusedRowHandle)
                ElseIf m_ShippingDetails.DeleteShippingDetail(m_ShippingSession, lShippingDetailID) = True Then
                    BindShippingGridControl(m_CurrentShippingID)
                Else
                    MessageBox.Show("The shipping detail was not deleted.")
                End If
            Else
                Dim rowHandle As Integer
                Dim lpnToDelete As String = shippingGridView.GetRowCellValue(shippingGridView.FocusedRowHandle, fullLPNNumberGridColumn).ToString
                For i As Integer = 0 To shippingGridView.RowCount - 1
                    rowHandle = shippingGridView.GetRowHandle(i)
                    If shippingGridView.GetRowCellValue(rowHandle, fullLPNNumberGridColumn) IsNot Nothing AndAlso shippingGridView.GetRowCellValue(rowHandle, fullLPNNumberGridColumn).ToString = lpnToDelete Then
                        lShippingDetailID = CInt(shippingGridView.GetRowCellValue(rowHandle, idGridColumn))
                        If lShippingDetailID <= -1 Then
                            shippingGridView.DeleteRow(rowHandle)
                        Else
                            m_ShippingDetails.DeleteShippingDetail(m_ShippingSession, lShippingDetailID)
                            shippingGridView.DeleteRow(rowHandle)
                        End If
                    End If
                Next i
                'BindShippingGridControl(m_CurrentShippingID) -- had to comment it out because it deletes all unsaved records --
                If Not lpnToDelete.StartsWith(CustomersBLL.GetLPNPrefix(7)) Then
                    For Each lpnRecord As Inventory In InventoryBLL.GetLPNInventoryRecords(m_ShippingSession, lpnToDelete, CInt(customerLookUpEdit.EditValue))
                        lpnRecord.Shipment = Nothing
                        lpnRecord.Save()
                    Next
                End If
            End If
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub itemRepositoryItemLookUpEdit_Closed(ByVal sender As Object, ByVal e As ClosedEventArgs) Handles itemRepositoryItemLookUpEdit.Closed, returnItemRepositoryItemLookUpEdit.Closed

        BindItemLookupEdit()

        If e.CloseMode = PopupCloseMode.Normal Then
            Dim view As GridView = CType(CType(CType(sender, LookUpEdit).Parent, DevExpress.XtraGrid.GridControl).FocusedView, GridView)
            If view.IsNewItemRow(view.FocusedRowHandle) Then
                view.CloseEditor()
                view.UpdateCurrentRow()
            End If
        End If

    End Sub

    Private Sub itemRepositoryItemLookUpEdit_Enter(sender As Object, e As EventArgs) Handles itemRepositoryItemLookUpEdit.Enter, returnItemRepositoryItemLookUpEdit.Enter

        shippingItemXPView.Filter = CriteriaOperator.And(shippingItemXPView.Filter, New BinaryOperator("Inactive", False))
        returnItemXPView.Filter = CriteriaOperator.And(returnItemXPView.Filter, New BinaryOperator("Inactive", False))

    End Sub

    Private Sub shippingGridView_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles shippingGridView.ValidateRow

        Dim stock As Double = ItemsBLL.GetQtyOnHandByID(m_ShippingSession, CInt(shippingGridView.GetRowCellValue(e.RowHandle, itemGridColumn)), CInt(locationLookUpEdit.EditValue)) ', "1111", 44)
        Dim shippingQuantity As Object
        If CInt(shippingGridView.GetRowCellValue(e.RowHandle, idGridColumn)) < 1 Then
            shippingQuantity = CInt(shippingGridView.GetRowCellValue(e.RowHandle, quantityGridColumn))
        Else
            shippingQuantity = CInt(shippingGridView.GetRowCellValue(e.RowHandle, quantityGridColumn)) - CInt(shippingGridView.GetDataRow(e.RowHandle)(4, DataRowVersion.Original))
        End If

        If stock < CDbl(shippingQuantity) Then
            MessageBox.Show(String.Format("{0} does only have {1} in stock and your shipping {2}.{3}You must enter first the production.",
                                             shippingGridView.GetRowCellDisplayText(e.RowHandle, itemGridColumn).ToString, stock.ToString, _
                                           shippingQuantity.ToString, vbCrLf), "Stock Verification", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            e.Valid = False
            m_CanSaveDetails = False
        Else
            m_CanSaveDetails = True
        End If

    End Sub

    Private Function ValidateAvailability(view As GridView, item As GridColumn, quantity As GridColumn) As Boolean
        'TODO:calculate availability by the summary of all the rows for that item.
        Dim totalShippingQuantity As New Dictionary(Of Integer, Double)

        Dim stock As Double
        Dim shippingQuantity As Integer
        If view.GroupCount = 0 Then
            For i As Integer = 0 To view.RowCount - 1
                If view.IsValidRowHandle(i) Then
                    view.GetRow(i)
                    stock = ItemsBLL.GetQtyOnHandByID(m_ShippingSession, CInt(view.GetRowCellValue(i, item)), CInt(locationLookUpEdit.EditValue))
                    If view.GetDataRow(i).RowState = DataRowState.Unchanged Then
                        Continue For
                    End If
                    If view.GetDataRow(i).RowState = DataRowState.Modified Then
                        shippingQuantity = CInt(view.GetRowCellValue(i, quantity)) - CInt(view.GetDataRow(i)(4, DataRowVersion.Original))
                    Else
                        shippingQuantity = CInt(view.GetRowCellValue(i, quantity))
                    End If
                    If stock < shippingQuantity Then
                        MessageBox.Show(String.Format("{0} does only have {1} in stock and your shipping {2}.{3}You must enter first the production.",
                                            view.GetRowCellDisplayText(i, item).ToString, stock.ToString, _
                                          shippingQuantity.ToString, vbCrLf), "Stock Verification", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        Return False
                    End If
                    If totalShippingQuantity.ContainsKey(CInt(view.GetRowCellValue(i, item))) Then
                        totalShippingQuantity(CInt(view.GetRowCellValue(i, item))) += shippingQuantity
                    Else
                        totalShippingQuantity.Add(CInt(view.GetRowCellValue(i, item)), shippingQuantity)
                    End If
                End If
            Next
        Else
            Dim i As Integer = -1
            While view.IsValidRowHandle(i)
                If view.GetChildRowHandle(i, 0) > -1 Then
                    For ci As Integer = view.GetChildRowHandle(i, 0) To view.GetChildRowCount(i) + view.GetChildRowHandle(i, 0) - 1
                        stock = ItemsBLL.GetQtyOnHandByID(m_ShippingSession, CInt(view.GetRowCellValue(ci, item)), CInt(locationLookUpEdit.EditValue))
                        If view.GetDataRow(ci).RowState = DataRowState.Unchanged Then
                            Continue For
                        End If
                        If view.GetDataRow(ci).RowState = DataRowState.Modified Then
                            shippingQuantity = CInt(view.GetRowCellValue(ci, quantity)) - CInt(view.GetDataRow(ci)(4, DataRowVersion.Original))
                        Else
                            shippingQuantity = CInt(view.GetRowCellValue(ci, quantity))
                        End If
                        If stock < shippingQuantity Then
                            MessageBox.Show(String.Format("{0} does only have {1} in stock and your shipping {2}.{3}You must enter first the production.",
                                            view.GetRowCellDisplayText(ci, itemGridColumn).ToString, stock.ToString, shippingQuantity.ToString, vbCrLf), "Stock Verification",
                                        MessageBoxButtons.OK, MessageBoxIcon.Hand)
                            Return False
                        End If
                        If totalShippingQuantity.ContainsKey(CInt(view.GetRowCellValue(ci, item))) Then
                            totalShippingQuantity(CInt(view.GetRowCellValue(ci, item))) += shippingQuantity
                        Else
                            totalShippingQuantity.Add(CInt(view.GetRowCellValue(ci, item)), shippingQuantity)
                        End If
                    Next
                End If
                i -= 1
            End While
        End If

        For Each product As Integer In totalShippingQuantity.Keys
            stock = ItemsBLL.GetQtyOnHandByID(m_ShippingSession, product, CInt(locationLookUpEdit.EditValue))
            If (stock < totalShippingQuantity(product)) Then
                MessageBox.Show(String.Format("{0} does only have {1} in stock and your shipping {2}.{3}You must enter first the production.", m_ShippingSession.GetObjectByKey(Of Items)(product).ItemCode,
                                              stock.ToString, totalShippingQuantity(product).ToString, vbCrLf), "Stock Verification", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Return False
            End If
        Next

        Return True

    End Function

    Private Function ValidateAvailability() As Boolean

        If ValidateAvailability(shippingGridView, itemGridColumn, quantityGridColumn) AndAlso ValidateAvailability(returnsGridView, returnItemGridColumn, returnQuantityGridColumn) Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub shippingGridView_InvalidRowException(sender As Object, e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles shippingGridView.InvalidRowException

        e.ExceptionMode = ExceptionMode.NoAction
        shippingGridView.FocusedColumn = quantityGridColumn

    End Sub

    Private Sub returnsGridView_InvalidRowException(sender As Object, e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles returnsGridView.InvalidRowException

        e.ExceptionMode = ExceptionMode.NoAction
        returnsGridView.FocusedColumn = returnQuantityGridColumn

    End Sub

    Private Sub LPNNumber_KeyDown(sender As Object, e As KeyEventArgs) Handles lpnNumberTextEdit.KeyDown
        Dim spgInventory As Boolean = False
        If e.KeyCode = Keys.Enter AndAlso customerLookUpEdit.EditValue IsNot Nothing Then
            Dim customerID As Integer = CInt(customerLookUpEdit.EditValue)
            If lpnNumberTextEdit.Text.StartsWith(CustomersBLL.GetLPNPrefix(7)) Then
                spgInventory = True
            End If

            If Not spgInventory AndAlso ShippingsBLL.IsLPNShipped(lpnNumberTextEdit.Text, customerID, m_ShippingSession) Then
                    MessageBox.Show("This LPN is already shipped.")
                Else
                    Dim fullLPN As String

                If lpnNumberTextEdit.Text.StartsWith(CustomersBLL.GetLPNPrefix(customerID)) Then
                    fullLPN = lpnNumberTextEdit.Text
                ElseIf spgInventory Then
                    fullLPN = lpnNumberTextEdit.Text
                Else
                    fullLPN = CustomersBLL.GetLPNPrefix(customerID) & Strings.Right("0000000000" & lpnNumberTextEdit.Text, Len(CustomersBLL.GetCustomer(customerID, m_ShippingSession).LastLPNNumber.ToString))
                End If

                For i As Integer = 0 To shippingGridView.RowCount - 1
                    If shippingGridView.GetDataRow(i) IsNot Nothing AndAlso shippingGridView.GetDataRow(i)("fullLPNNumber").Equals(fullLPN) Then
                        MessageBox.Show("This LPN is already entered.")
                        lpnNumberTextEdit.EditValue = Nothing
                        Exit Sub
                    End If
                Next

                If spgInventory Then
                    Dim LPN As Integer = Integer.Parse(lpnNumberTextEdit.Text.Replace(CustomersBLL.GetLPNPrefix(7), ""))

                    For Each record As LocationInventoryByLot In New XPCollection(Of LocationInventoryByLot)(m_ShippingSession, New GroupOperator(New BinaryOperator(LocationInventoryByLot.Fields.LPNNumber, LPN, BinaryOperatorType.Equal) And
                                                                                                  New BinaryOperator(LocationInventoryByLot.Fields.Location.Oid.PropertyName, locationLookUpEdit.EditValue, BinaryOperatorType.Equal) And
                                                                                                  New BinaryOperator(LocationInventoryByLot.Fields.QuantityOnHand.PropertyName, 0, BinaryOperatorType.Greater) And
                                                                                                  New BinaryOperator(LocationInventoryByLot.Fields.LocationInventoryItem.ItemCustomerID.CustomerID.PropertyName, customerID, BinaryOperatorType.Equal)))
                        shippingGridView.AddNewRow()
                        shippingGridView.SetRowCellValue(shippingGridView.FocusedRowHandle, itemGridColumn, record.LocationInventoryItem.ItemID)
                        shippingGridView.SetRowCellValue(shippingGridView.FocusedRowHandle, quantityGridColumn, record.QuantityOnHand)
                        shippingGridView.SetRowCellValue(shippingGridView.FocusedRowHandle, lotGridColumn, record.LocationInventoryLot)
                        shippingGridView.SetRowCellValue(shippingGridView.FocusedRowHandle, expirationDateGridColumn, record.ExpirationDate)
                        fullLPN = CustomersBLL.GetLPNPrefix(7) & Strings.Right("0000000000" & record.LPNNumber.ToString(), Len(CustomersBLL.GetCustomer(7, m_ShippingSession).LastLPNNumber.ToString))
                        shippingGridView.SetRowCellValue(shippingGridView.FocusedRowHandle, fullLPNNumberGridColumn, fullLPN)
                        shippingGridView.UpdateCurrentRow()
                    Next
                Else
                    For Each record As Inventory In InventoryBLL.GetLPNInventoryRecords(m_ShippingSession, fullLPN, customerID)
                        shippingGridView.AddNewRow()
                        shippingGridView.SetRowCellValue(shippingGridView.FocusedRowHandle, itemGridColumn, record.InventoryItemID.ItemID)
                        shippingGridView.SetRowCellValue(shippingGridView.FocusedRowHandle, quantityGridColumn, record.InventoryQuantity)
                        shippingGridView.SetRowCellValue(shippingGridView.FocusedRowHandle, lotGridColumn, record.Lot)
                        shippingGridView.SetRowCellValue(shippingGridView.FocusedRowHandle, expirationDateGridColumn, record.ExpirationDate)
                        shippingGridView.SetRowCellValue(shippingGridView.FocusedRowHandle, fullLPNNumberGridColumn, record.FullLPNNumber)
                        shippingGridView.UpdateCurrentRow()
                    Next
                End If
            End If
            lpnNumberTextEdit.EditValue = Nothing
        End If

    End Sub

    Private Sub printPackingListBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles printPackingListBarButtonItem.ItemClick

        If m_CurrentShippingID Is Nothing Then
            Exit Sub
        End If

        Dim packingList As New PackingListXtraReport

        With packingList
            .locationId.Text = locationLookUpEdit.Text
            .dateXrLabel.DataBindings.Add("Text", Nothing, "ShipMainDate", "{0:MM/dd/yyyy}")
            .bolXrLabel.DataBindings.Add("Text", Nothing, "ShipMainBOL")
            .poXrLabel.DataBindings.Add("Text", Nothing, "strPO")
            .deliveryNoteNumberXrLabel.DataBindings.Add("Text", Nothing, "DeliveryNoteNumber")
            .carrierXrLabel.DataBindings.Add("Text", Nothing, "CarrierName")
            .trailerXrLabel.DataBindings.Add("Text", Nothing, "strTrailer")
            .sealXrLabel.DataBindings.Add("Text", Nothing, "strSeal")
            .returnsGroupHeader.GroupFields.Add(New GroupField("ShippingType", XRColumnSortOrder.Ascending))
            .itemGroupHeader.GroupFields.Add(New GroupField("ItemCode", XRColumnSortOrder.Ascending))
            .qtyXrLabel.DataBindings.Add("Text", Nothing, "ShipDetDetQty")
            .itemCodeXrLabel.DataBindings.Add("Text", Nothing, "ItemCode")
            .itemDescriptionXrLabel.DataBindings.Add("Text", Nothing, "ItemDescription")
            .palletsXrLabel.DataBindings.Add("Text", Nothing, "sngPallets", "{0:N2}")
            '.additionalPalletsXrLabel.DataBindings.Add("Text", Nothing, "sngSkits")
            .totalPalletsXrLabel.DataBindings.Add("Text", Nothing, "sngTotalPallets", "{0:N2}")
            .palletsTotalXrLabel.DataBindings.Add("Text", Nothing, "sngTotalPallets", "{0:N2}")
            .weightXrLabel.DataBindings.Add("Text", Nothing, "Weight", "{0:N2}")
            .totalWeightXrLabel.DataBindings.Add("Text", Nothing, "TotalGrossWeight", "{0:N1}")
            .lpnXrLabel.DataBindings.Add("Text", Nothing, "FullLPNNumber")
            .lotXrLabel.DataBindings.Add("Text", Nothing, "ShipDetLot")
            .expirationDateXrLabel.DataBindings.Add("Text", Nothing, "ExpirationDate", String.Format("{{0:{0}}}", CustomersBLL.GetExpirationDateFormat(CType(customerLookUpEdit.EditValue, Integer))))
            .itemTotalQuantityXrLabel.DataBindings.Add("Text", Nothing, "ShipDetDetQty")
            .groupItemCodeXrLabel.DataBindings.Add("Text", Nothing, "ItemCode")
            .groupItemDescriptionXrLabel.DataBindings.Add("Text", Nothing, "ItemDescription")
            .itemTotalPalletsXrLabel.DataBindings.Add("Text", Nothing, "sngPallets", "{0:N2}")
            .itemTotalWeightXrLabel.DataBindings.Add("Text", Nothing, "Weight", "{0:N2}")
            .loadedByXrLabel.DataBindings.Add("Text", Nothing, "LoadedBy")
            .checkedByXrLabel.DataBindings.Add("Text", Nothing, "CheckedBy")
            .physicalConditionXrLabel.DataBindings.Add("Text", Nothing, "PhysicalCondition")
            .loadConditionXrLabel.DataBindings.Add("Text", Nothing, "LoadCondition")
            .startTimeXrLabel.DataBindings.Add("Text", Nothing, "StartTime", "{0:hh:mm:ss tt}")
            .finishTimeXrLabel.DataBindings.Add("Text", Nothing, "FinishTime", "{0:hh:mm:ss tt}")
            .temperatureXrLabel.DataBindings.Add("Text", Nothing, "Temparature", "{0:N1}")
            .DataSource = New PackingListReportBLL().GetPackingListreport(m_CurrentShippingID.Value)
            .ShowPreview()
        End With

    End Sub

    Private Sub temparatureSpinEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles temparatureSpinEdit.Validating

        If CDbl(temparatureSpinEdit.EditValue) < 55 OrElse CDbl(temparatureSpinEdit.EditValue) > 75 Then
            If MessageBox.Show("You entered an unusual tepmerature, do you want to change it?", "Unusual Temperature", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = vbYes Then
                e.Cancel = True
                temparatureSpinEdit.SelectAll()
            Else
                e.Cancel = False
            End If
        End If

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

    Private Sub refreshBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles refreshBarButtonItem.ItemClick

        m_ShippingSession.DropIdentityMap()

        shippingSearchXPView.Reload()
        shippingItemXPView.Reload()
        returnItemXPView.Reload()
        customersXPView.Reload()
        shipmentConditionXpView.Reload()
        employeeXpView.Reload()
        locationXpView.Reload()

        BindShippingSearchGrid()
        shiftLookUpEdit.Properties.DataSource = m_Shifts.GetShifts
        carrierLookUpEdit.Properties.DataSource = m_Carriers.GetCarrierIDAndNames
        destinationLookUpEdit.Properties.DataSource = m_Destinations.GetAddressNameAndIDS
        BindShippingsControls(m_CurrentShippingID.Value)

        CheckPermissions()

        MessageBox.Show("Done!")

    End Sub

    Private Sub LinkSession()

        shippingSearchXPView.Session = m_ShippingSession
        shippingItemXPView.Session = m_ShippingSession
        returnItemXPView.Session = m_ShippingSession
        customersXPView.Session = m_ShippingSession
        shipmentConditionXpView.Session = m_ShippingSession
        employeeXpView.Session = m_ShippingSession
        locationXpView.Session = m_ShippingSession

    End Sub

    Private Sub LabelControl14_Click(sender As Object, e As EventArgs) Handles LabelControl14.Click

    End Sub
End Class