Imports DXDAL.SPGData
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Helpers
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraEditors.Controls

Public Class LocationTransfersXtraForm

    Private m_CanSaveDetails As Boolean = True
    Private m_CurrentTransfer As LocationTransfers
    Private m_LPNsInTransfer As List(Of String) = New List(Of String)
    Private m_TransfersSession As Session

    Private Sub addBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles addBarButtonItem.ItemClick

        m_CurrentTransfer = New LocationTransfers(m_TransfersSession)
        oidTextEdit.EditValue = m_CurrentTransfer.Oid
        transferNumberTextEdit.EditValue = Nothing
        fromLocationLookUpEdit.EditValue = Nothing
        toLocationLookUpEdit.EditValue = Nothing
        transferDateDateEdit.DateTime = Today
        carrierLookUpEdit.EditValue = Nothing
        trailerTextEdit.EditValue = Nothing
        transferNumberTextEdit.EditValue = Nothing
        loadedByLookUpEdit.EditValue = Nothing
        unloadedByLookUpEdit.EditValue = Nothing
        checkedByLookUpEdit.EditValue = Nothing

        transferDetailsXpCollection.Criteria = New BinaryOperator(LocationTransferDetails.Fields.Transfer.Oid.PropertyName, m_CurrentTransfer.Oid, BinaryOperatorType.Equal)
        transferDetailsXpCollection.Reload()

        fromLocationLookUpEdit.Enabled = True
        toLocationLookUpEdit.Enabled = True

        Utilities.MakeFormReadOnly(dataEntrySplitContainerControl.Panel1, False)
        transferDetailsGridView.OptionsBehavior.Editable = True
        transferSearchGridControl.Enabled = False
        CheckPermissions()

        EnableAvailableBarButtons(True)

    End Sub

    Private Sub cancelBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cancelBarButtonItem.ItemClick

        CancelChanges()
        CheckPermissions()

        Utilities.MakeFormReadOnly(dataEntrySplitContainerControl.Panel1, True)
        transferDetailsGridView.OptionsBehavior.Editable = False
        transferSearchGridControl.Enabled = True

        EnableAvailableBarButtons(False)

    End Sub

    Private Sub deleteBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles deleteBarButtonItem.ItemClick

        If transferDetailsXpCollection.Count > 0 Then
            MessageBox.Show("You must delete first the details.", "Detlete Transfer", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If

        If MessageBox.Show("Are you sure you want to delete this transfer.", "Delete Transfer", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Try
            m_CurrentTransfer.Delete()
            If m_CurrentTransfer.IsDeleted Then
                BindTransferSearch()
            Else
                MessageBox.Show("The Transfer was not deleted.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(String.Format("The Transfer was not deleted.{0}{1}", vbCrLf, ex.Message), "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub deleteRepositoryItemButtonEdit_Click(sender As Object, e As EventArgs) Handles deleteRepositoryItemButtonEdit.Click

        If MessageBox.Show("Are you sure you want to remove this transfer detail?", "Delete Transfer Detail", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Dim detail As LocationTransferDetails = m_TransfersSession.GetObjectByKey(Of LocationTransferDetails)(transferDetailsGridView.GetFocusedRowCellValue(colOid))
        If Not detail Is Nothing Then
            Dim quantity As Single = CSng(transferDetailsGridView.GetFocusedRowCellValue(colTransferQuantity))
            Dim item As Integer = CInt(transferDetailsGridView.GetFocusedRowCellValue(transferItemGridColumn))

            If quantity > ItemsBLL.GetQtyOnHandByID(m_TransfersSession, item, CInt(fromLocationLookUpEdit.EditValue)) Then
                MessageBox.Show("You can't delete this transfer detail, it will create a negative stock at the location", "Insufficient Inventory", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Sub
            End If

            detail.Delete()
            If detail.IsDeleted = False Then
                MessageBox.Show("The transfer detail was not removed.")
            Else
                'transferDetailsGridView.DeleteRow(transferDetailsGridView.FocusedRowHandle)
                LocationInventoryBLL.UpdateStock(m_TransfersSession, item, CInt(fromLocationLookUpEdit.EditValue), quantity)
                LocationInventoryBLL.UpdateStock(m_TransfersSession, item, CInt(toLocationLookUpEdit.EditValue), quantity * -1)
            End If
        Else
            transferDetailsGridView.DeleteRow(transferDetailsGridView.FocusedRowHandle)
        End If

    End Sub

    Private Sub editBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles editBarButtonItem.ItemClick

        If m_CurrentTransfer Is Nothing Then
            MessageBox.Show("Please select a location transfer to edit.")
            Exit Sub
        End If

        Utilities.MakeFormReadOnly(dataEntrySplitContainerControl.Panel1, False)
        transferDetailsGridView.OptionsBehavior.Editable = True
        transferSearchGridControl.Enabled = False
        CheckPermissions()

        EnableAvailableBarButtons(True)

    End Sub

    Private Sub fromLocationLookUpEdit_Validated(sender As Object, e As EventArgs) Handles fromLocationLookUpEdit.Validated

        BindItemLookupEdit()

    End Sub

    Private Sub LocationTransfersXtraForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If transferSearchGridControl.Enabled = False Then
            Select Case MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                Case DialogResult.Yes
                    If SaveChanges() = False Then
                        e.Cancel = True
                    End If
                Case DialogResult.Cancel
                    e.Cancel = False
                Case DialogResult.No
                    CancelChanges()
            End Select
        End If

        If e.Cancel = False Then
            XPBaseObject.AutoSaveOnEndEdit = True
            m_TransfersSession.PurgeDeletedObjects()
        End If

    End Sub

    Private Sub LocationTransfersXtraForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        Cursor = Cursors.WaitCursor

        CheckPermissions()

        m_TransfersSession = New Session(SPGDataLayer)
        m_TransfersSession.TrackPropertiesModifications = True
        m_TransfersSession.OptimisticLockingReadBehavior = OptimisticLockingReadBehavior.MergeCollisionThrowException

        For i As Integer = 0 To components.Components.Count - 1
            If TypeOf (components.Components(i)) Is XPView Then
                CType(components.Components(i), XPView).Session = m_TransfersSession
            ElseIf TypeOf (components.Components(i)) Is XPCollection Then
                CType(components.Components(i), XPCollection).Session = m_TransfersSession
            End If
        Next i

        transferDetailsXpCollection.Criteria = New BinaryOperator(LocationTransferDetails.Fields.Transfer.Oid.PropertyName, 0, BinaryOperatorType.Equal)
        transferSearchGridView.OptionsBehavior.Editable = False

        XPBaseObject.AutoSaveOnEndEdit = False

        Utilities.MakeFormReadOnly(dataEntrySplitContainerControl.Panel1, True)
        'lpnNumberTextEdit.Properties.ReadOnly = True

        Cursor = Cursors.Default

    End Sub

    Private Sub saveBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles saveBarButtonItem.ItemClick

        If SaveChanges() Then
            CheckPermissions()

            Utilities.MakeFormReadOnly(dataEntrySplitContainerControl.Panel1, True)
            transferDetailsGridView.OptionsBehavior.Editable = False
            transferSearchGridControl.Enabled = True

            EnableAvailableBarButtons(False)
        End If

    End Sub

    Private Sub transferDetailsGridView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles transferDetailsGridView.CellValueChanged

        If IsNothing(transferDetailsGridView.GetFocusedRowCellValue(transferItemGridColumn)) OrElse IsDBNull(transferDetailsGridView.GetFocusedRowCellValue(transferItemGridColumn)) Then
            Exit Sub
        End If

        If e.Column Is transferItemGridColumn OrElse e.Column Is colTransferQuantity OrElse e.Column Is colTransferUnits Then
            If CDbl(transferDetailsGridView.GetFocusedRowCellValue(colTransferQuantity)) > 0 OrElse CDbl(transferDetailsGridView.GetFocusedRowCellValue(colTransferUnits)) > 0 Then
                UpdatePallets()
            End If
        End If

    End Sub

    Private Sub transferDetailsGridView_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles transferDetailsGridView.InitNewRow

        transferDetailsGridView.SetRowCellValue(e.RowHandle, transferIDGridColumn, m_CurrentTransfer.Oid)

    End Sub

    Private Sub transferDetailsGridView_InvalidRowException(sender As Object, e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles transferDetailsGridView.InvalidRowException

        e.ExceptionMode = ExceptionMode.NoAction
        transferDetailsGridView.FocusedColumn = colTransferQuantity

    End Sub

    Private Sub transferDetailsGridView_ValidateRow(sender As Object, e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles transferDetailsGridView.ValidateRow
        Dim item As Items
        Dim lot As String
        Dim LPNNumber As Integer

        item = Session.DefaultSession.GetObjectByKey(Of Items)(CInt(transferDetailsGridView.GetFocusedRowCellValue(transferItemGridColumn)), True)
        lot = CStr(transferDetailsGridView.GetFocusedRowCellValue(colTransferLot))

        Try
            LPNNumber = CInt(transferDetailsGridView.GetFocusedRowCellValue(fullLpnNumberGridColumn))
        Catch
            If item.RequiresLotCodes Then
                MessageBox.Show("LPN Number is invalid", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                e.Valid = False
                m_CanSaveDetails = False
                Exit Sub
            End If
        End Try

        Try
            If Not LotCodeValidator.ValidateByItem(item, lot, False) Then
                Throw New ApplicationException("Item " & item.ItemCode & " & lot # " & lot & " is invalid" & vbNewLine & "You must provide a valid lot.")
            End If
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            e.Valid = False
            m_CanSaveDetails = False
            Exit Sub
        End Try

        Dim stock As Double = CDbl(CType(itemRepositoryItemLookUpEdit.GetDataSourceRowByKeyValue(transferDetailsGridView.GetFocusedRowCellValue(transferItemGridColumn)), ViewRecord)(2))   'QuantityOnHand
        Dim lotStock As Double = ItemsBLL.GetQtyOnHandByIDAndLot(m_TransfersSession, item.ItemID, CInt(fromLocationLookUpEdit.EditValue), lot, LPNNumber)

        Dim transferingQuantity As Double
        If CInt(transferDetailsGridView.GetRowCellValue(e.RowHandle, colOid)) < 1 Then
            transferingQuantity = CDbl(transferDetailsGridView.GetRowCellValue(e.RowHandle, colTransferQuantity))
        Else
            transferingQuantity = CDbl(transferDetailsGridView.GetRowCellValue(e.RowHandle, colTransferQuantity)) -
                                    Session.DefaultSession.GetObjectByKey(Of LocationTransferDetails)(transferDetailsGridView.GetRowCellValue(e.RowHandle, colOid), True).TransferQuantity
        End If

        If stock < transferingQuantity Then
            MessageBox.Show(String.Format("{0} does only have {1} in stock and your transfering {2}.", transferDetailsGridView.GetRowCellDisplayText(e.RowHandle, transferItemGridColumn).ToString,
                                          stock.ToString, transferingQuantity.ToString), "Stock Verification", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            e.Valid = False
            m_CanSaveDetails = False
        ElseIf lotStock < transferingQuantity AndAlso item.RequiresLotCodes Then
            MessageBox.Show($"{item.ItemCode} lot# {lot} LPN# {LPNNumber} does only have {lotStock} in stock and your transfering {transferingQuantity}.", "Stock Verification", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            e.Valid = False
            m_CanSaveDetails = False
        Else
            m_CanSaveDetails = True
        End If

    End Sub

    Private Sub transferSearchGridView_Click(sender As Object, e As EventArgs) Handles transferSearchGridView.Click

        If transferSearchGridView.FocusedRowHandle = -999997 Then
            Exit Sub
        End If

        If transferSearchGridView.CalcHitInfo(transferSearchGridControl.PointToClient(Control.MousePosition)).HitTest = DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.RowCell Then
            BindTransferControls(CType(transferSearchGridView.GetFocusedRowCellValue(colTransferID), Integer))
        End If

    End Sub

    Private Sub BindItemLookupEdit()

        itemXpView.Criteria = New BinaryOperator(LocationInventory.Fields.Location.Oid.PropertyName, CInt(fromLocationLookUpEdit.EditValue), BinaryOperatorType.Equal)
        itemXpView.Reload()

    End Sub

    Private Sub BindTransferControls(ByVal LocationTransferID As Integer)

        m_TransfersSession.DropIdentityMap()

        Dim transfer As LocationTransfers = m_TransfersSession.GetObjectByKey(Of LocationTransfers)(LocationTransferID, True)
        m_CurrentTransfer = transfer
        oidTextEdit.EditValue = m_CurrentTransfer.Oid
        fromLocationLookUpEdit.EditValue = If(m_CurrentTransfer.FromLocation Is Nothing, Nothing, m_CurrentTransfer.FromLocation.Oid)
        toLocationLookUpEdit.EditValue = If(m_CurrentTransfer.ToLocation Is Nothing, Nothing, m_CurrentTransfer.ToLocation.Oid)
        transferDateDateEdit.DateTime = m_CurrentTransfer.TransferDate
        carrierLookUpEdit.EditValue = If(m_CurrentTransfer.TransferCarrier Is Nothing, Nothing, m_CurrentTransfer.TransferCarrier.CarrierID)
        trailerTextEdit.EditValue = m_CurrentTransfer.Trailer
        transferNumberTextEdit.EditValue = m_CurrentTransfer.TransferNumber
        loadedByLookUpEdit.EditValue = If(m_CurrentTransfer.LoadedBy Is Nothing, Nothing, m_CurrentTransfer.LoadedBy.Oid)
        unloadedByLookUpEdit.EditValue = If(m_CurrentTransfer.UnloadedBy Is Nothing, Nothing, m_CurrentTransfer.UnloadedBy.Oid)
        checkedByLookUpEdit.EditValue = If(m_CurrentTransfer.CheckedBy Is Nothing, Nothing, m_CurrentTransfer.CheckedBy.Oid)

        transferDetailsXpCollection.Criteria = New BinaryOperator(LocationTransferDetails.Fields.Transfer.Oid.PropertyName, m_CurrentTransfer.Oid, BinaryOperatorType.Equal)
        transferDetailsXpCollection.Reload()

        BindItemLookupEdit()

    End Sub

    Private Sub BindTransferSearch()

        transferSearchXpView.Reload()

    End Sub

    Private Sub CancelChanges()

        If m_CurrentTransfer.Oid <> -1 Then
            BindTransferControls(m_CurrentTransfer.Oid)
        End If

    End Sub

    Public Function CheckPermissions() As Boolean

        Try
            Dim permission As SPG.UserPermissionsRow = New UserPermissionsBLL().GetUserPermissionsByUserName(My.Settings.UserName, "Shipping Form")(0)

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

    Private Sub EnableAvailableBarButtons(ByVal editingMode As Boolean)

        If editingMode Then
            cancelBarButtonItem.Enabled = True
            saveBarButtonItem.Enabled = True
            deleteRepositoryItemButtonEdit.Buttons(0).Enabled = True
            editBarButtonItem.Enabled = False
            addBarButtonItem.Enabled = False
            deleteBarButtonItem.Enabled = False
            refreshBarButtonItem.Enabled = False
        Else
            refreshBarButtonItem.Enabled = True
            cancelBarButtonItem.Enabled = False
            saveBarButtonItem.Enabled = False
            deleteRepositoryItemButtonEdit.Buttons(0).Enabled = False
            fromLocationLookUpEdit.Enabled = False
            toLocationLookUpEdit.Enabled = False
        End If

    End Sub

    Private Function SaveChanges() As Boolean

        Dim selectedID As Integer

        'make sure that the record gets validated before saving by moving off the record being edited
        transferDetailsGridView.CloseEditor()
        transferDetailsGridView.MoveNext()

        If m_CanSaveDetails = False OrElse ValidateAvailability() = False Then
            Return False
        End If

        If m_CurrentTransfer.Oid <> -1 Then
            selectedID = transferSearchGridView.FocusedRowHandle
        End If

        If LocationTransfersBLL.ValidateRecord(CType(transferNumberTextEdit.EditValue, Integer?), CType(fromLocationLookUpEdit.EditValue, Integer?), CType(toLocationLookUpEdit.EditValue, Integer?),
                                               CType(carrierLookUpEdit.EditValue, Integer?), m_CurrentTransfer, m_TransfersSession) Then
            m_CurrentTransfer.FromLocation = m_TransfersSession.GetObjectByKey(Of Locations)(CInt(fromLocationLookUpEdit.EditValue))
            m_CurrentTransfer.ToLocation = m_TransfersSession.GetObjectByKey(Of Locations)(CInt(toLocationLookUpEdit.EditValue))
            m_CurrentTransfer.TransferDate = CDate(transferDateDateEdit.DateTime)
            m_CurrentTransfer.TransferCarrier = m_TransfersSession.GetObjectByKey(Of Carriers)(CInt(carrierLookUpEdit.EditValue))
            m_CurrentTransfer.Trailer = If(trailerTextEdit.EditValue Is Nothing, Nothing, CStr(trailerTextEdit.EditValue))
            'm_CurrentTransfer.TransferNumber = CInt(transferNumberTextEdit.EditValue)
            m_CurrentTransfer.LoadedBy = If(loadedByLookUpEdit.EditValue Is Nothing, Nothing, m_TransfersSession.GetObjectByKey(Of Employees)(CInt(loadedByLookUpEdit.EditValue)))
            m_CurrentTransfer.UnloadedBy = If(unloadedByLookUpEdit.EditValue Is Nothing, Nothing, m_TransfersSession.GetObjectByKey(Of Employees)(CInt(unloadedByLookUpEdit.EditValue)))
            m_CurrentTransfer.CheckedBy = If(checkedByLookUpEdit.EditValue Is Nothing, Nothing, m_TransfersSession.GetObjectByKey(Of Employees)(CInt(checkedByLookUpEdit.EditValue)))
        Else
            MessageBox.Show("You must provide a From location; To location and Carrier before saving the record.")
            Return False
        End If

        Try
            Dim newQuantity As Integer
            Dim originalRecord As LocationTransferDetails

            For Each transferDetail As LocationTransferDetails In transferDetailsXpCollection
                If transferDetail.Transfer Is Nothing OrElse transferDetail.Transfer.Oid = -1 Then
                    transferDetail.Transfer = m_CurrentTransfer
                    LocationInventoryBLL.UpdateStock(m_TransfersSession, transferDetail.TransferItem.ItemID, CInt(fromLocationLookUpEdit.EditValue), transferDetail.TransferQuantity * -1, transferDetail.TransferLot, transferDetail.FullLpnNumber)
                    LocationInventoryBLL.UpdateStock(m_TransfersSession, transferDetail.TransferItem.ItemID, CInt(toLocationLookUpEdit.EditValue), transferDetail.TransferQuantity, transferDetail.TransferLot, transferDetail.FullLpnNumber)
                Else
                    originalRecord = Session.DefaultSession.GetObjectByKey(Of LocationTransferDetails)(transferDetail.Oid, True)

                    If originalRecord Is Nothing Then
                        newQuantity = transferDetail.TransferQuantity
                    Else
                        newQuantity = transferDetail.TransferQuantity - originalRecord.TransferQuantity
                    End If

                    LocationInventoryBLL.UpdateStock(m_TransfersSession, transferDetail.TransferItem.ItemID, CInt(fromLocationLookUpEdit.EditValue), newQuantity * -1, transferDetail.TransferLot, transferDetail.FullLpnNumber)
                    LocationInventoryBLL.UpdateStock(m_TransfersSession, transferDetail.TransferItem.ItemID, CInt(toLocationLookUpEdit.EditValue), newQuantity, transferDetail.TransferLot, transferDetail.FullLpnNumber)
                End If
                '   The details are saved together with the header
                'transferDetail.Save()
            Next
            m_CurrentTransfer.Save()

            'For Each lpnInventory As String In m_LPNsInTransfer
            '    For Each lpnRecord As Inventory In InventoryBLL.GetLPNInventoryRecords(lpnInventory, CInt(customerLookUpEdit.EditValue))
            '        lpnRecord.Shipment = XpoDefault.Session.GetObjectByKey(Of Shipping)(m_CurrentShippingID.Value)
            '        lpnRecord.Save()
            '    Next
            'Next
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        BindTransferSearch()
        BindTransferControls(m_CurrentTransfer.Oid)
        transferSearchGridView.FocusedRowHandle = selectedID
        Return True

    End Function

    Public Sub UpdatePallets()

        Dim units As Double = ItemsBLL.GetCaseQuantity(CType(transferDetailsGridView.GetFocusedRowCellValue(transferItemGridColumn), Integer))
        Dim pallets As Single = CSng(CType(itemRepositoryItemLookUpEdit.GetDataSourceRowByKeyValue(transferDetailsGridView.GetFocusedRowCellValue(transferItemGridColumn)), ViewRecord)(3))  'CasesPerPallet

        If Convert.ToDouble(transferDetailsGridView.GetFocusedRowCellValue(colTransferQuantity)) < 1 Then
            If units <> 0 Then
                transferDetailsGridView.SetFocusedRowCellValue(colTransferQuantity, Convert.ToDouble(transferDetailsGridView.GetFocusedRowCellValue(colTransferUnits)) * units)
            Else
                transferDetailsGridView.SetFocusedRowCellValue(colTransferQuantity, 0)
            End If
        End If

        'calculate the quantity
        If Convert.ToDouble(transferDetailsGridView.GetFocusedRowCellValue(colTransferUnits)) = 0 Then
            If units <> 0 Then
                transferDetailsGridView.SetFocusedRowCellValue(colTransferUnits, Math.Ceiling(Convert.ToDouble(transferDetailsGridView.GetFocusedRowCellValue(colTransferQuantity)) / units))
            End If
        End If

        If pallets <> 0 Then
            transferDetailsGridView.SetFocusedRowCellValue(colTransferPallets, CDbl(transferDetailsGridView.GetFocusedRowCellValue(colTransferUnits)) / pallets)
        Else
            transferDetailsGridView.SetFocusedRowCellValue(colTransferPallets, 0)
        End If

    End Sub

    Private Function ValidateAvailability() As Boolean

        Dim totalTransferQuantity As New Dictionary(Of Integer, Double)
        Dim stock As Double
        Dim lotStock As Double
        Dim transferQuantity As Integer
        Dim item As Items
        Dim lot As String
        Dim LPNNumber As Integer

        If transferDetailsGridView.GroupCount = 0 Then
            For i As Integer = 0 To transferDetailsGridView.RowCount - 1
                If transferDetailsGridView.IsValidRowHandle(i) Then

                    lot = CStr(transferDetailsGridView.GetRowCellValue(i, colTransferLot))
                    item = Session.DefaultSession.GetObjectByKey(Of Items)(CInt(transferDetailsGridView.GetRowCellValue(i, transferItemGridColumn)), True)
                    Try
                        LPNNumber = CInt(transferDetailsGridView.GetRowCellValue(i, fullLpnNumberGridColumn))
                    Catch
                        If item.RequiresLotCodes Then
                            MessageBox.Show("LPN Number is invalid", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                            Return False
                        End If
                    End Try

                    Try
                        If Not LotCodeValidator.ValidateByItem(item, lot, False) Then
                            Throw New ApplicationException("Item " & item.ItemCode & " & lot # " & lot & " is invalid" & vbNewLine & "You must provide a valid lot.")
                        End If
                    Catch ex As ApplicationException
                        MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        Return False
                    End Try

                    stock = ItemsBLL.GetQtyOnHandByID(m_TransfersSession, CInt(transferDetailsGridView.GetRowCellValue(i, transferItemGridColumn)), CInt(fromLocationLookUpEdit.EditValue))

                    lotStock = ItemsBLL.GetQtyOnHandByIDAndLot(m_TransfersSession, CInt(transferDetailsGridView.GetRowCellValue(i, transferItemGridColumn)), CInt(fromLocationLookUpEdit.EditValue), lot, LPNNumber)

                    If m_TransfersSession.IsNewObject(transferDetailsGridView.GetRow(i)) = False AndAlso CType(transferDetailsGridView.GetRow(i), LocationTransferDetails).HasChanges = False Then
                        Continue For
                    ElseIf m_TransfersSession.IsNewObject(transferDetailsGridView.GetRow(i)) = False Then
                        transferQuantity = CInt(transferDetailsGridView.GetRowCellValue(i, colTransferQuantity)) - Session.DefaultSession.GetObjectByKey(Of LocationTransferDetails)(transferDetailsGridView.GetRowCellValue(i, colOid), True).TransferQuantity
                    Else
                        transferQuantity = CInt(transferDetailsGridView.GetRowCellValue(i, colTransferQuantity))
                    End If

                    If stock < transferQuantity Then
                        MessageBox.Show($"{item.ItemCode} does only have {stock} in stock and your shipping {transferQuantity}.{vbNewLine}You must enter first the production.",
                                        "Stock Verification", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        Return False
                    End If

                    If lotStock < transferQuantity AndAlso item.RequiresLotCodes Then
                        MessageBox.Show($"{item.ItemCode} lot# {lot} LPN# {LPNNumber} does only have {lotStock} in stock and your shipping {transferQuantity}.{vbNewLine}You must enter first the production.",
                                           "Stock Verification", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        Return False
                    End If

                    If totalTransferQuantity.ContainsKey(CInt(transferDetailsGridView.GetRowCellValue(i, transferItemGridColumn))) Then
                        totalTransferQuantity(CInt(transferDetailsGridView.GetRowCellValue(i, transferItemGridColumn))) += transferQuantity
                    Else
                        totalTransferQuantity.Add(CInt(transferDetailsGridView.GetRowCellValue(i, transferItemGridColumn)), transferQuantity)
                    End If
                End If
            Next i
        Else
            Dim i As Integer = -1
            While transferDetailsGridView.IsValidRowHandle(i)
                If transferDetailsGridView.GetChildRowHandle(i, 0) > -1 Then
                    For ci As Integer = transferDetailsGridView.GetChildRowHandle(i, 0) To transferDetailsGridView.GetChildRowCount(i) + transferDetailsGridView.GetChildRowHandle(i, 0) - 1

                        lot = CStr(transferDetailsGridView.GetRowCellValue(ci, colTransferLot))
                        item = Session.DefaultSession.GetObjectByKey(Of Items)(CInt(transferDetailsGridView.GetRowCellValue(ci, transferItemGridColumn)), True)

                        Try
                            LPNNumber = CInt(transferDetailsGridView.GetRowCellValue(ci, fullLpnNumberGridColumn))
                        Catch
                            If item.RequiresLotCodes Then
                            MessageBox.Show("LPN Number is invalid", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                            Return False
                        End If
                        End Try

                        Try
                            If Not LotCodeValidator.ValidateByItem(item, lot, False) Then
                                Throw New ApplicationException("Item " & item.ItemCode & " & lot # " & lot & " is invalid" & vbNewLine & "You must provide a valid lot.")
                            End If
                        Catch ex As ApplicationException
                            MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                            Return False
                        End Try

                        stock = ItemsBLL.GetQtyOnHandByID(m_TransfersSession, CInt(transferDetailsGridView.GetRowCellValue(ci, transferItemGridColumn)), CInt(fromLocationLookUpEdit.EditValue))
                        lotStock = ItemsBLL.GetQtyOnHandByIDAndLot(m_TransfersSession, CInt(transferDetailsGridView.GetRowCellValue(ci, transferItemGridColumn)), CInt(fromLocationLookUpEdit.EditValue), lot, LPNNumber)

                        If m_TransfersSession.IsNewObject(transferDetailsGridView.GetRow(ci)) = False AndAlso CType(transferDetailsGridView.GetRow(ci), LocationTransferDetails).HasChanges = False Then
                            Continue For
                        ElseIf m_TransfersSession.IsNewObject(transferDetailsGridView.GetRow(ci)) = False Then
                            transferQuantity = CInt(transferDetailsGridView.GetRowCellValue(ci, colTransferQuantity)) -
                                                    Session.DefaultSession.GetObjectByKey(Of LocationTransferDetails)(transferDetailsGridView.GetRowCellValue(ci, colOid), True).TransferQuantity
                        Else
                            transferQuantity = CInt(transferDetailsGridView.GetRowCellValue(ci, colTransferQuantity))
                        End If

                        If stock < transferQuantity Then
                            MessageBox.Show(String.Format("{0} does only have {1} in stock and your shipping {2}.{3}You must enter first the production.",
                                            transferDetailsGridView.GetRowCellDisplayText(ci, transferItemGridColumn).ToString, stock.ToString, transferQuantity.ToString, vbCrLf), "Stock Verification",
                                        MessageBoxButtons.OK, MessageBoxIcon.Hand)
                            Return False
                        End If

                        If lotStock < transferQuantity AndAlso item.RequiresLotCodes Then
                            MessageBox.Show($"{item.ItemCode} lot# {lot} LPN# {LPNNumber} does only have {lotStock} in stock and your shipping {transferQuantity}.{vbNewLine}You must enter first the production.",
                                           "Stock Verification", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                            Return False
                        End If

                        If totalTransferQuantity.ContainsKey(CInt(transferDetailsGridView.GetRowCellValue(ci, transferItemGridColumn))) Then
                            totalTransferQuantity(CInt(transferDetailsGridView.GetRowCellValue(ci, transferItemGridColumn))) += transferQuantity
                        Else
                            totalTransferQuantity.Add(CInt(transferDetailsGridView.GetRowCellValue(ci, transferItemGridColumn)), transferQuantity)
                        End If
                    Next
                End If
                i -= 1
            End While
        End If

        For Each product As Integer In totalTransferQuantity.Keys
            stock = ItemsBLL.GetQtyOnHandByID(m_TransfersSession, product, CInt(fromLocationLookUpEdit.EditValue))
            If (stock < totalTransferQuantity(product)) Then
                MessageBox.Show(String.Format("{0} does only have {1} in stock and your shipping {2}.{3}You must enter first the production.", Session.DefaultSession.GetObjectByKey(Of Items)(product).ItemCode,
                                              stock.ToString, totalTransferQuantity(product).ToString, vbCrLf), "Stock Verification", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Return False
            End If
        Next

        Return True

    End Function

    Private Sub refreshBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles refreshBarButtonItem.ItemClick

        m_TransfersSession.DropIdentityMap()
        locationsXpView.Reload()
        employeesXpView.Reload()
        carrierXpView.Reload()
        transferDetailsXpCollection.Reload()
        transferSearchXpView.Reload()
        transferDetailsXpCollection.Reload()
        itemXpView.Reload()

    End Sub

    Private Sub lpnNumberTextEdit_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles lpnNumberTextEdit.Validating
        If fromLocationLookUpEdit.EditValue IsNot Nothing AndAlso Len(lpnNumberTextEdit.Text) > 0 Then
            Dim LocationID As Integer = CInt(fromLocationLookUpEdit.EditValue)

            Try
                Dim LPN As Integer = Integer.Parse(lpnNumberTextEdit.Text.Replace(CustomersBLL.GetLPNPrefix(7), ""))

                For i As Integer = 0 To transferDetailsGridView.RowCount - 1
                    If transferDetailsGridView.GetDataRow(i) IsNot Nothing AndAlso transferDetailsGridView.GetDataRow(i)("FullLpnNumber").Equals(LPN) Then
                        MessageBox.Show("This LPN is already entered.")
                        lpnNumberTextEdit.EditValue = Nothing
                        Exit Sub
                    End If
                Next

                For Each record As LocationInventoryByLot In New XPCollection(Of LocationInventoryByLot)(m_TransfersSession, New GroupOperator(New BinaryOperator(LocationInventoryByLot.Fields.LPNNumber, LPN, BinaryOperatorType.Equal) And
                                                                                                  New BinaryOperator(LocationInventoryByLot.Fields.Location.Oid.PropertyName, LocationID, BinaryOperatorType.Equal)))
                    transferDetailsGridView.AddNewRow()
                    transferDetailsGridView.SetRowCellValue(transferDetailsGridView.FocusedRowHandle, transferItemGridColumn, record.LocationInventoryItem.ItemID)
                    transferDetailsGridView.SetRowCellValue(transferDetailsGridView.FocusedRowHandle, colTransferUnits, record.QuantityOnHand)
                    transferDetailsGridView.SetRowCellValue(transferDetailsGridView.FocusedRowHandle, colTransferLot, record.LocationInventoryLot)
                    transferDetailsGridView.SetRowCellValue(transferDetailsGridView.FocusedRowHandle, colItemExpirationDate, record.ExpirationDate)
                    transferDetailsGridView.SetRowCellValue(transferDetailsGridView.FocusedRowHandle, fullLpnNumberGridColumn, LPN)
                    transferDetailsGridView.UpdateCurrentRow()
                Next
            Catch
            End Try
            lpnNumberTextEdit.EditValue = Nothing
        End If
    End Sub
End Class