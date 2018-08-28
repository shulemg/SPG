Imports DXDAL.SPGData
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Windows.Forms

Public Class LocationXtraForm

    Private m_CurrentLocation As Locations
    Private m_GridReportTitle As String
    Private m_LocationSession As Session

    Private Sub addBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles addBarButtonItem.ItemClick

        m_CurrentLocation = New Locations(m_LocationSession)
        oidTextEdit.EditValue = Nothing
        codeTextEdit.EditValue = Nothing
        codeTextEdit.Enabled = True
        nameTextEdit.EditValue = Nothing
        addressTextEdit.EditValue = Nothing
        cityTextEdit.EditValue = Nothing
        stateTextEdit.EditValue = Nothing
        zipCodeTextEdit.EditValue = Nothing
        phoneTextEdit.EditValue = Nothing
        faxTextEdit.EditValue = Nothing
        receivingCheckEdit.Checked = False
        shippingCheckEdit.Checked = False
        productionCheckEdit.Checked = False
        warehousingCheckEdit.Checked = True
        inventoryAvailableCheckEdit.Checked = False
        defaultWarehouseCheckEdit.Checked = False

        BindLocationGridControls(m_CurrentLocation.Oid)

        Utilities.MakeFormReadOnly(generalXtraTabPage, False)
        locationSearchGridControl.Enabled = False
        CheckPermissions()

        EnableAvailableBarButtons(True)

    End Sub

    Private Sub cancelBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cancelBarButtonItem.ItemClick

        CancelChanges()
        CheckPermissions()

        Utilities.MakeFormReadOnly(generalXtraTabPage, True)
        locationSearchGridControl.Enabled = True

        EnableAvailableBarButtons(False)

    End Sub

    Private Sub deleteBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles deleteBarButtonItem.ItemClick

        If MessageBox.Show("Are you sure you want to delete this location.", "Delete Location", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        If LocationsBLL.DeleteLocation(m_CurrentLocation.Oid, m_LocationSession) <> True Then
            MessageBox.Show("The location was not deleted.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            BindLocationSearch()
        End If

    End Sub

    Private Sub editBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles editBarButtonItem.ItemClick

        If m_CurrentLocation Is Nothing Then
            MessageBox.Show("Please select a location to edit.")
            Exit Sub
        End If

        Utilities.MakeFormReadOnly(generalXtraTabPage, False)
        locationSearchGridControl.Enabled = False
        CheckPermissions()

        EnableAvailableBarButtons(True)

    End Sub

    Private Sub locationSearchGridView_Click(sender As Object, e As EventArgs) Handles locationSearchGridView.Click

        If locationSearchGridView.FocusedRowHandle = -999997 Then
            Exit Sub
        End If

        If (locationSearchGridView.CalcHitInfo(locationSearchGridControl.PointToClient(Control.MousePosition)).HitTest = GridHitTest.RowCell) Then
            BindLocationControls(CType(locationSearchGridView.GetFocusedRowCellValue(colLocationID), Integer))
        End If

    End Sub

    Private Sub LocationXtraForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If locationSearchGridControl.Enabled = False Then
            Select Case MessageBox.Show("Do you want to save changes?", "Save Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                Case DialogResult.Yes
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
            m_LocationSession.PurgeDeletedObjects()
        End If

    End Sub

    Private Sub LocationXtraForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        Cursor = Cursors.WaitCursor

        CheckPermissions()

        m_LocationSession = New Session(SPGDataLayer)
        m_LocationSession.TrackPropertiesModifications = True
        m_LocationSession.OptimisticLockingReadBehavior = OptimisticLockingReadBehavior.MergeCollisionThrowException

        For i As Integer = 0 To components.Components.Count - 1
            If TypeOf (components.Components(i)) Is XPView Then
                CType(components.Components(i), XPView).Session = m_LocationSession
            End If
        Next

        Utilities.MakeFormReadOnly(generalXtraTabPage, True)

        Cursor = Cursors.Default

    End Sub

    Private Sub PrintableComponentLink_CreateReportHeaderArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)

        Dim brick As TextBrick = e.Graph.DrawString(m_GridReportTitle, Color.Black, New RectangleF(0, 5, 600, 25), BorderSide.None)
        brick.Font = New Font("Arial", 14, FontStyle.Bold)
        brick.StringFormat = New BrickStringFormat(StringAlignment.Center)

    End Sub

    Private Sub printGridBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles printGridBarButtonItem.ItemClick

        Dim pcl As New PrintableComponentLink(New PrintingSystem())
        Dim pcl2 As PrintableComponentLink = Nothing

        AddHandler pcl.CreateReportHeaderArea, AddressOf PrintableComponentLink_CreateReportHeaderArea

        Select Case locationsXtraTabControl.SelectedTabPage.Name
            Case inventoryXtraTabPage.Name
                pcl.Component = inventoryGridControl
                m_GridReportTitle = "Inventory At " & m_CurrentLocation.LocationCode
            Case transfersXtraTabPage.Name
                pcl.Component = transfersFromGridControl
                m_GridReportTitle = "Transfers From/To " & m_CurrentLocation.LocationCode
                pcl2 = New PrintableComponentLink(New PrintingSystem())
                AddHandler pcl2.CreateReportHeaderArea, AddressOf PrintableComponentLink_CreateReportHeaderArea
                pcl2.Component = transfersToGridControl
            Case receivingReturnsXtraTabPage.Name
                pcl.Component = receivingReturnsGridControl
                m_GridReportTitle = "Receiving Returns At " & m_CurrentLocation.LocationCode
            Case receivingXtraTabPage.Name
                pcl.Component = receivingsGridControl
                m_GridReportTitle = "Receivings At " & m_CurrentLocation.LocationCode
            Case productionXtraTabPage.Name
                pcl.Component = productionGridControl
                m_GridReportTitle = "Production At " & m_CurrentLocation.LocationCode
            Case shippingsXtraTabPage.Name
                pcl.Component = shippingsGridControl
                m_GridReportTitle = "Shippings At " & m_CurrentLocation.LocationCode
            Case shippingReturnsXtraTabPage.Name
                pcl.Component = shippingReturnsGridControl
                m_GridReportTitle = "Shipping Returns At " & m_CurrentLocation.LocationCode
            Case Else
                Exit Select
        End Select

        pcl.CreateDocument()
        pcl.ShowPreviewDialog()

        If pcl2 IsNot Nothing Then
            pcl2.CreateDocument()
            pcl2.ShowPreviewDialog()
        End If

    End Sub

    Private Sub productionGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles productionGridView.CustomColumnDisplayText

        If e.Column Is colPrdouctionExpirationDate AndAlso IsDate(e.Value) Then
            e.DisplayText = CDate(e.Value).ToString(productionGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, colProductionExpirationDateFormat).ToString)
        End If

    End Sub

    Private Sub receivingsGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles receivingsGridView.CustomColumnDisplayText

        If e.Column Is colReceivingItemExpirationDate AndAlso IsDate(e.Value) Then
            e.DisplayText = CDate(e.Value).ToString(receivingsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, colReceivingExpirationDateFormat).ToString)
        End If

    End Sub

    Private Sub receivingReturnsGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles receivingReturnsGridView.CustomColumnDisplayText

        If e.Column Is colReceivingReturnItemExpirationDate AndAlso IsDate(e.Value) Then
            e.DisplayText = CDate(e.Value).ToString(receivingReturnsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, colReceivingReturnExpirationDateFormat).ToString)
        End If

    End Sub

    Private Sub saveBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles saveBarButtonItem.ItemClick

        If SaveChanges() Then
            CheckPermissions()

            Utilities.MakeFormReadOnly(generalXtraTabPage, True)
            locationSearchGridControl.Enabled = True

            EnableAvailableBarButtons(False)
        End If

    End Sub

    Private Sub shippingsGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles shippingsGridView.CustomColumnDisplayText

        If e.Column Is colShippingExpirationDate AndAlso IsDate(e.Value) Then
            e.DisplayText = CDate(e.Value).ToString(shippingsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, colShippingExpirationDateFormat).ToString)
        End If

    End Sub

    Private Sub shippingReturnsGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles shippingReturnsGridView.CustomColumnDisplayText

        If e.Column Is colShippingReturnExpirationDate AndAlso IsDate(e.Value) Then
            e.DisplayText = CDate(e.Value).ToString(shippingReturnsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, colShippingReturnExpirationDateFormat).ToString)
        End If

    End Sub

    Private Sub transfersFromGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles transfersFromGridView.CustomColumnDisplayText

        If e.Column Is colExpirationDate AndAlso IsDate(e.Value) Then
            e.DisplayText = CDate(e.Value).ToString(transfersFromGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, colTransferFromExpirationDateFormat).ToString)
        End If

    End Sub

    Private Sub transfersToGridView_CustomColumnDisplayText(sender As Object, e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles transfersToGridView.CustomColumnDisplayText

        If e.Column Is colTransferToExpirationDate AndAlso IsDate(e.Value) Then
            e.DisplayText = CDate(e.Value).ToString(transfersToGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, transferToExpirationDateFormatGridColumn).ToString)
        End If

    End Sub

    Private Sub BindLocationControls(ByVal locationID As Integer)

        m_LocationSession.DropIdentityMap()

        Dim location As Locations = m_LocationSession.GetObjectByKey(Of Locations)(locationID, True)
        m_CurrentLocation = location
        oidTextEdit.EditValue = m_CurrentLocation.Oid
        codeTextEdit.EditValue = m_CurrentLocation.LocationCode
        codeTextEdit.Enabled = False
        nameTextEdit.EditValue = m_CurrentLocation.LocationName
        addressTextEdit.EditValue = m_CurrentLocation.LocationAddress
        cityTextEdit.EditValue = m_CurrentLocation.LocationCity
        stateTextEdit.EditValue = m_CurrentLocation.LocationState
        zipCodeTextEdit.EditValue = m_CurrentLocation.LocationZipCode
        phoneTextEdit.EditValue = m_CurrentLocation.LocationPhone
        faxTextEdit.EditValue = m_CurrentLocation.LocationFax
        receivingCheckEdit.EditValue = m_CurrentLocation.CanReceive
        shippingCheckEdit.EditValue = m_CurrentLocation.CanShip
        productionCheckEdit.EditValue = m_CurrentLocation.CanProduce
        warehousingCheckEdit.EditValue = m_CurrentLocation.CanWarehouse
        inventoryAvailableCheckEdit.EditValue = m_CurrentLocation.InventoryAvailable
        defaultWarehouseCheckEdit.EditValue = LocationsBLL.IsDefaultLocation(m_CurrentLocation)

        BindLocationGridControls(locationID)

        transfersToGroupControl.Text = "Location Transfers To " & m_CurrentLocation.LocationCode
        transfersFromGroupControl.Text = "Location Transfers From " & m_CurrentLocation.LocationCode

    End Sub

    Private Sub BindLocationGridControls(ByVal locationID As Integer)

        If warehousingCheckEdit.Checked Then
            locationInventoryXpView.Criteria = New BinaryOperator(LocationInventory.Fields.Location.Oid, locationID, BinaryOperatorType.Equal)
            locationInventoryByLotXpView.Criteria = New BinaryOperator(LocationInventoryByLot.Fields.Location.Oid, locationID, BinaryOperatorType.Equal)
            transfersFromXpView.Criteria = New GroupOperator(GroupOperatorType.And, New BinaryOperator(LocationTransferDetails.Fields.Transfer.FromLocation.Oid.PropertyName, locationID, BinaryOperatorType.Equal),
                                                                                    New BinaryOperator(LocationTransferDetails.Fields.Transfer.TransferDate.PropertyName, DateAdd(DateInterval.Year, -1, Today), BinaryOperatorType.GreaterOrEqual))
            transfersToXpView.Criteria = New GroupOperator(GroupOperatorType.And, New BinaryOperator(LocationTransferDetails.Fields.Transfer.ToLocation.Oid.PropertyName, locationID, BinaryOperatorType.Equal),
                                                                                    New BinaryOperator(LocationTransferDetails.Fields.Transfer.TransferDate.PropertyName, DateAdd(DateInterval.Year, -1, Today), BinaryOperatorType.GreaterOrEqual))
            locationInventoryXpView.Reload()
            locationInventoryByLotXpView.Reload()
            transfersFromXpView.Reload()
            transfersToXpView.Reload()
            inventoryXtraTabPage.PageVisible = True
            inventoryXtraTabPage.PageEnabled = True
            transfersXtraTabPage.PageVisible = True
            transfersXtraTabPage.PageEnabled = True
        Else
            locationInventoryXpView.Criteria = New BinaryOperator(LocationInventory.Fields.Location.Oid.PropertyName, 0, BinaryOperatorType.Equal)
            locationInventoryByLotXpView.Criteria = New BinaryOperator(LocationInventoryByLot.Fields.Location.Oid.PropertyName, 0, BinaryOperatorType.Equal)
            transfersFromXpView.Criteria = New BinaryOperator(LocationTransferDetails.Fields.Transfer.FromLocation.Oid.PropertyName, 0, BinaryOperatorType.Equal)
            transfersToXpView.Criteria = New BinaryOperator(LocationTransferDetails.Fields.Transfer.ToLocation.Oid.PropertyName, 0, BinaryOperatorType.Equal)
            locationInventoryXpView.Reload()
            locationInventoryByLotXpView.Reload()
            transfersFromXpView.Reload()
            transfersToXpView.Reload()
            inventoryXtraTabPage.PageVisible = False
            inventoryXtraTabPage.PageEnabled = False
            transfersXtraTabPage.PageVisible = False
            transfersXtraTabPage.PageEnabled = False
        End If

        If receivingCheckEdit.Checked Then
            receivingsXpView.Criteria = New GroupOperator(GroupOperatorType.And, New BinaryOperator(ReceivingDetail.Fields.ReceivMainID.ReceivingLocation.Oid, locationID, BinaryOperatorType.Equal),
                                                                                    New BinaryOperator(ReceivingDetail.Fields.ReceivMainID.ReceivDate.PropertyName, DateAdd(DateInterval.Year, -1, Today), BinaryOperatorType.GreaterOrEqual))
            receivingReturnXpView.Criteria = New GroupOperator(GroupOperatorType.And, New BinaryOperator(ReceivedReturns.Fields.ReceiveMainID.ReceivingLocation.Oid, locationID, BinaryOperatorType.Equal),
                                                                                        New BinaryOperator(ReceivedReturns.Fields.ReceiveMainID.ReceivDate.PropertyName, DateAdd(DateInterval.Year, -1, Today), BinaryOperatorType.GreaterOrEqual))
            receivingsXpView.Reload()
            receivingReturnXpView.Reload()
            receivingXtraTabPage.PageEnabled = True
            receivingXtraTabPage.PageVisible = True
            receivingReturnsXtraTabPage.PageEnabled = True
            receivingReturnsXtraTabPage.PageVisible = True
        Else
            receivingsXpView.Criteria = New BinaryOperator(ReceivingDetail.Fields.ReceivMainID.ReceivingLocation.Oid.PropertyName, 0, BinaryOperatorType.Equal)
            receivingReturnXpView.Criteria = New BinaryOperator(ReceivedReturns.Fields.ReceiveMainID.ReceivingLocation.Oid.PropertyName, 0, BinaryOperatorType.Equal)
            receivingsXpView.Reload()
            receivingReturnXpView.Reload()
            receivingXtraTabPage.PageEnabled = False
            receivingXtraTabPage.PageVisible = False
            receivingReturnsXtraTabPage.PageEnabled = False
            receivingReturnsXtraTabPage.PageVisible = False
        End If

        If productionCheckEdit.Checked Then
            productionXpView.Criteria = New GroupOperator(GroupOperatorType.And, New BinaryOperator(Inventory.Fields.ProductionLocation.Oid, locationID, BinaryOperatorType.Equal),
                                                                                New BinaryOperator(Inventory.Fields.InventoryDate.PropertyName, DateAdd(DateInterval.Year, -1, Today), BinaryOperatorType.GreaterOrEqual))
            productionXpView.Reload()
            productionXtraTabPage.PageEnabled = True
            productionXtraTabPage.PageVisible = True
        Else
            productionXpView.Criteria = New BinaryOperator(Inventory.Fields.ProductionLocation.Oid.PropertyName, 0, BinaryOperatorType.Equal)
            productionXpView.Reload()
            productionXtraTabPage.PageEnabled = False
            productionXtraTabPage.PageVisible = False
        End If

        If shippingCheckEdit.Checked Then
            shippingsXpView.Criteria = New GroupOperator(GroupOperatorType.And, New BinaryOperator(ShipDet.Fields.ShipDetMainID.ShippingLocation.Oid, locationID, BinaryOperatorType.Equal),
                                                                                New BinaryOperator(ShipDet.Fields.ShipDetMainID.ShipMainDate.PropertyName, DateAdd(DateInterval.Year, -1, Today), BinaryOperatorType.GreaterOrEqual))
            shippingReturnsXpView.Criteria = New GroupOperator(GroupOperatorType.And, New BinaryOperator(ShippedReturns.Fields.ShipMainID.ShippingLocation.Oid, locationID, BinaryOperatorType.Equal),
                                                                                        New BinaryOperator(ShippedReturns.Fields.ShipMainID.ShipMainDate.PropertyName, DateAdd(DateInterval.Year, -1, Today), BinaryOperatorType.GreaterOrEqual))
            shippingsXpView.Reload()
            shippingReturnsXpView.Reload()
            shippingsXtraTabPage.PageEnabled = True
            shippingsXtraTabPage.PageVisible = True
            shippingReturnsXtraTabPage.PageEnabled = True
            shippingReturnsXtraTabPage.PageVisible = True
        Else
            shippingsXpView.Criteria = New BinaryOperator(ShipDet.Fields.ShipDetMainID.ShippingLocation.Oid.PropertyName, 0, BinaryOperatorType.Equal)
            shippingReturnsXpView.Criteria = New BinaryOperator(ShippedReturns.Fields.ShipMainID.ShippingLocation.Oid.PropertyName, 0, BinaryOperatorType.Equal)
            shippingsXpView.Reload()
            shippingReturnsXpView.Reload()
            shippingsXtraTabPage.PageEnabled = False
            shippingsXtraTabPage.PageVisible = False
            shippingReturnsXtraTabPage.PageEnabled = False
            shippingReturnsXtraTabPage.PageVisible = False
        End If

    End Sub

    Private Sub BindLocationSearch()

        locationSearchXpView.Reload()

    End Sub

    Private Sub CancelChanges()

        If m_CurrentLocation.Oid <> -1 Then
            BindLocationControls(m_CurrentLocation.Oid)
        End If

    End Sub

    Public Function CheckPermissions() As Boolean

        Try
            Dim permission As SPG.UserPermissionsRow = New UserPermissionsBLL().GetUserPermissionsByUserName(My.Settings.UserName, "Items Form")(0)

            Select Case permission.PermissionLevel
                Case "FULL", "Full"
                    addBarButtonItem.Enabled = True
                    editBarButtonItem.Enabled = True
                    deleteBarButtonItem.Enabled = True
                Case "ADD", "Add"
                    addBarButtonItem.Enabled = True
                    editBarButtonItem.Enabled = True
                    deleteBarButtonItem.Enabled = False
                Case "NONE", "None"
                    MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Close()
                    Return False
                Case "VIEW", "View"
                    addBarButtonItem.Enabled = False
                    editBarButtonItem.Enabled = False
                    deleteBarButtonItem.Enabled = False
                Case "EDIT", "Edit"
                    addBarButtonItem.Enabled = False
                    editBarButtonItem.Enabled = True
                    deleteBarButtonItem.Enabled = False
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
            editBarButtonItem.Enabled = False
            addBarButtonItem.Enabled = False
            deleteBarButtonItem.Enabled = False
        Else
            cancelBarButtonItem.Enabled = False
            saveBarButtonItem.Enabled = False
            codeTextEdit.Enabled = False
        End If

    End Sub

    Private Function SaveChanges() As Boolean

        Dim selectedId As Integer

        If m_CurrentLocation.Oid <> -1 Then
            selectedId = locationSearchGridView.FocusedRowHandle
        End If

        If LocationsBLL.ValidateRecord(codeTextEdit.Text) Then
            m_CurrentLocation.LocationCode = codeTextEdit.Text
            m_CurrentLocation.LocationName = nameTextEdit.Text
            m_CurrentLocation.LocationAddress = addressTextEdit.Text
            m_CurrentLocation.LocationCity = cityTextEdit.Text
            m_CurrentLocation.LocationState = stateTextEdit.Text
            m_CurrentLocation.LocationZipCode = zipCodeTextEdit.Text
            m_CurrentLocation.LocationPhone = phoneTextEdit.Text
            m_CurrentLocation.LocationFax = faxTextEdit.Text
            m_CurrentLocation.CanReceive = receivingCheckEdit.Checked
            m_CurrentLocation.CanShip = shippingCheckEdit.Checked
            m_CurrentLocation.CanProduce = productionCheckEdit.Checked
            m_CurrentLocation.CanWarehouse = warehousingCheckEdit.Checked
            m_CurrentLocation.InventoryAvailable = inventoryAvailableCheckEdit.Checked
        Else
            MessageBox.Show("You must provide a location code before saving the record.")
            Return False
        End If

        Try
            m_CurrentLocation.Save()
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        BindLocationSearch()
        BindLocationControls(m_CurrentLocation.Oid)
        locationSearchGridView.FocusedRowHandle = selectedId
        Return True

    End Function






End Class