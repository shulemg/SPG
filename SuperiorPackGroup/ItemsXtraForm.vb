Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraPrinting
Imports System.Windows.Forms
Imports DevExpress.Data.Filtering
Imports DXDAL.SPGData
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraReports.UI
Imports DevExpress.Xpo
Imports DevExpress.XtraGrid.Columns

Public Class ItemsXtraForm

    Protected m_Items As ItemsBLL
    Protected m_CustomerItems As CustomersBLL
    Protected m_MachineLines As MachinesLinesBLL
    Protected m_ShippingDetail As ShippingDetailsBLL
    Protected m_Inventory As InventoryBLL
    Protected m_ReceivingDetails As ReceivingDetailsBLL
    Protected m_BOM As BOMBLL
    Private m_UserPermissions As UserPermissionsBLL
    Protected m_UOMs As ArrayList
    Private m_GridReportTitle As String
    Private m_CurrentItemID As Nullable(Of Integer)
    Private m_ItemsSession As Session

    Private Sub ItemsXtraForm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing

        If itemsSearchGridControl.Enabled = False Then
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

    End Sub

    Private Sub ItemsXtraForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        Cursor = Cursors.WaitCursor
        m_Items = New ItemsBLL
        m_CustomerItems = New CustomersBLL
        m_MachineLines = New MachinesLinesBLL
        m_ShippingDetail = New ShippingDetailsBLL
        m_Inventory = New InventoryBLL
        m_ReceivingDetails = New ReceivingDetailsBLL
        m_UserPermissions = New UserPermissionsBLL

        m_ItemsSession = New Session(SPGDataLayer) With {.TrackPropertiesModifications = True, .OptimisticLockingReadBehavior = OptimisticLockingReadBehavior.MergeCollisionThrowException}

        CheckPermissions()

        For i As Integer = 0 To components.Components.Count - 1
            If TypeOf (components.Components(i)) Is XPView Then
                CType(components.Components(i), XPView).Session = m_ItemsSession
            ElseIf TypeOf (components.Components(i)) Is XPCollection Then
                CType(components.Components(i), XPCollection).Session = m_ItemsSession
            End If
        Next i

        BindItemsSearch()
        PoolBom.AutoSaveOnEndEdit = False

        Dim customerNameColumn As DevExpress.XtraEditors.Controls.LookUpColumnInfo = New DevExpress.XtraEditors.Controls.LookUpColumnInfo() With {.Caption = "Customer Name", .FieldName = "CustomerName"}
        Dim customerNameAndIDs As DataTable = m_CustomerItems.GetCustomerNameAndIDS(False)

        customerFilterLookUpEdit.Properties.DataSource = customerNameAndIDs
        customerFilterLookUpEdit.Properties.Columns.Add(customerNameColumn)
        customerFilterLookUpEdit.Properties.DisplayMember = "CustomerName"
        customerFilterLookUpEdit.Properties.ValueMember = "CustomerID"

        customerLookUpEdit.Properties.DataSource = customerNameAndIDs
        customerLookUpEdit.Properties.Columns.Add(customerNameColumn)
        customerLookUpEdit.Properties.DisplayMember = "CustomerName"
        customerLookUpEdit.Properties.ValueMember = "CustomerID"

        Dim itemTypes As DataTable = ItemsBLL.GetItemTypes

        typeLookUpEdit.Properties.DataSource = itemTypes
        Me.typeLookUpEdit.Properties.DisplayMember = "Description"
        Me.typeLookUpEdit.Properties.ValueMember = "Type"

        Me.typeFilterLookUpEdit.Properties.DataSource = itemTypes
        Me.typeFilterLookUpEdit.Properties.DisplayMember = "Description"
        Me.typeFilterLookUpEdit.Properties.ValueMember = "Type"

        Me.uomLookUpEdit.Properties.DataSource = m_Items.GetItemUOMs
        Me.uomLookUpEdit.Properties.ShowHeader = False

        'Me.defaultMachineLookUpEdit.Properties.DataSource = m_MachineLines.GetMachineLines
        'Me.defaultMachineLookUpEdit.Properties.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo)
        'Me.defaultMachineLookUpEdit.Properties.Columns(0).FieldName = "MachineLineName"
        'Me.defaultMachineLookUpEdit.Properties.Columns(0).Caption = "Machine Line"
        'Me.defaultMachineLookUpEdit.Properties.DisplayMember = "MachineLineName"
        'Me.defaultMachineLookUpEdit.Properties.ValueMember = "MachineLineID"

        Me.RMRepositoryItemLookUpEdit.Columns.Add(New DevExpress.XtraEditors.Controls.LookUpColumnInfo)
        Me.RMRepositoryItemLookUpEdit.Columns(0).FieldName = "ItemCode"
        Me.RMRepositoryItemLookUpEdit.Columns(0).Caption = "Raw Material"
        Me.RMRepositoryItemLookUpEdit.DisplayMember = "ItemCode"
        Me.RMRepositoryItemLookUpEdit.ValueMember = "ItemID"

        Me.shippingDetailIDGridColumn.FieldName = "ShipDetDetID"
        Me.shippingIDGridColumn.FieldName = "ShipDetMainID"
        Me.shippingLotGridColumn.FieldName = "ShipDetLot"
        shippingExpirationDateGridColumn.FieldName = "ExpirationDate"
        Me.shippingQuantityGridColumn.FieldName = "ShipDetDetQty"
        Me.shippingBOLGridColumn.FieldName = "ShipMainBOL"
        Me.shippingDateGridColumn.FieldName = "ShipMainDate"

        shippingReturnIDGridColumn.FieldName = "ReturnDetID"
        returnShippingIDGridColumn.FieldName = "ShipMainID"
        shippingReturnLotGridColumn.FieldName = "ReturnDetLot"
        shippingReturnExpirationDateGridColumn.FieldName = "ExpirationDate"
        shippingReturnQuantityGridColumn.FieldName = "intUnits"
        shippingReturnBOLGridColumn.FieldName = "ShipMainBOL"
        shippingReturnDateGridColumn.FieldName = "ShipMainDate"

        Me.productionDateGridColumn.FieldName = "InventoryDate"
        Me.productionQuantityGridColumn.FieldName = "InventoryQuantity"
        Me.productionLotGridColumn.FieldName = "Lot"
        productionExpirationDateGridColumn.FieldName = "ExpirationDate"
        Me.productionPOGridColumn.FieldName = "PO"

        Me.receivingDetailIDGridColumn.FieldName = "ReceivDetID"
        Me.receivingIDGridColumn.FieldName = "ReceivMainID"
        Me.receivingLotGridColumn.FieldName = "ReceivDetLot"
        receivingExpirationDateGridColumn.FieldName = "ExpirationDate"
        Me.receivingQuantityGridColumn.FieldName = "intUnits"
        Me.receivingBOLGridColumn.FieldName = "ReceivBOL"
        Me.receivingDateGridColumn.FieldName = "ReceivDate"

        receivingReturnIDGridColumn.FieldName = "ReturnDetID"
        returnReceivingIDGridColumn.FieldName = "ReceiveMainID"
        receivingReturnLotGridColumn.FieldName = "ReturnDetLot"
        receivingReturnExpirationDateGridColumn.FieldName = "ExpirationDate"
        receivingReturnQuantityGridColumn.FieldName = "ReturnDetQty"
        receivingReturnBolGridColumn.FieldName = "ReceiveBOL"
        receivingReturnDateGridColumn.FieldName = "ReceiveDate"

        Me.bomIDGridColumn.FieldName = "BOMID"
        Me.FGItemCodeGridColumn.FieldName = "BOMFiniGoodID"
        Me.RMItemCodeGridColumn.FieldName = "BOMRawMatID"
        Me.RMQuantityGridColumn.FieldName = "BOMQuantity"
        Me.scrapFactorGridColumn.FieldName = "ScrapFactor"

        Me.availabilityItemIDGridColumn.FieldName = "BOMRawMatID"
        Me.bomItemCodeGridColumn.FieldName = "ItemCode"
        Me.bomItemDescriptionGridColumn.FieldName = "ItemDescription"
        Me.quantityOnHandGridColumn.FieldName = "TotalQuantityOnHand"
        localQuantityOnHandGridColumn.FieldName = "LocalQuantityOnHand"
        Me.quantityRequiredGridColumn.FieldName = "BOMQuantity"
        Me.scrapPercentageGridColumn.FieldName = "ScrapFactor"
        'isPoolGridColumn.FieldName = "IsPool"

        adjustmentIDGridColumn.FieldName = "AdjustmentID"
        adjustmentDateGridColumn.FieldName = "AdjustmentDate"
        adjustmentOriginalQuantityGridColumn.FieldName = "OriginalQuantity"
        adjustmentNewQtyGridColumn.FieldName = "NewCount"
        adjustmentQuantityGridColumn.FieldName = "AdjustmentQuantity"
        adjustmentReasonGridColumn.FieldName = "Reason"

        poolBomXpCollection.Criteria = New BinaryOperator(PoolBom.Fields.PoolBomFiniGoodID.ItemID.PropertyName, 0, BinaryOperatorType.Equal)
        poolBomXpCollection.Reload()

        productionStandardsXpCollection.Criteria = New BinaryOperator(ItemMachineStandards.Fields.ProductionItem.ItemID.PropertyName, 0, BinaryOperatorType.Equal)
        productionStandardsXpCollection.Reload()

        inventoryXpView.Criteria = New BinaryOperator(LocationInventory.Fields.LocationInventoryItem.ItemID, 0, BinaryOperatorType.Equal)
        transfersXpView.Criteria = New BinaryOperator(LocationTransferDetails.Fields.TransferItem.ItemID.PropertyName, 0, BinaryOperatorType.Equal)

        Utilities.MakeFormReadOnly(Me.generalXtraTabPage, True)
        Utilities.MakeFormReadOnly(Me.advancedXtraTabPage, True)
        Utilities.MakeFormReadOnly(Me.specificationXtraTabPage, True)
        Me.BOMGridView.OptionsBehavior.Editable = False
        poolBomGridView.OptionsBehavior.Editable = False
        productionStandardsGridView.OptionsBehavior.Editable = False
        Me.itemsSearchGridControl.Enabled = True

        Me.printGridBarButtonItem.Enabled = False
        cancelBarButtonItem.Enabled = False
        saveBarButtonItem.Enabled = False

        Me.Cursor = Cursors.Default


    End Sub

    Public Sub BindItemsSearch()

        If inactiveSearchCheckEdit.Checked = False Then
            itemSearchXPView.Filter = New BinaryOperator(Items.Fields.Inactive.PropertyName, False, BinaryOperatorType.Equal)
        Else
            itemSearchXPView.Filter = Nothing
        End If

        itemSearchXPView.Reload()
        'Me.itemsSearchGridControl.DataSource = m_Items.GetItemsSearch(inactiveSearchCheckEdit.Checked)

    End Sub

    Private ReadOnly Property BOM() As BOMBLL
        Get
            If m_BOM Is Nothing Then
                m_BOM = New BOMBLL
            End If
            Return m_BOM
        End Get
    End Property

    Public Sub BindItemControls(ByVal itemID As Integer)

        m_ItemsSession.DropIdentityMap()

        'Dim item As SPG.ItemsRow = CType(m_Items.GetItemBYId(itemID).Rows(0), SPG.ItemsRow)
        Dim item As Items = m_ItemsSession.GetObjectByKey(Of Items)(itemID)
        m_CurrentItemID = item.ItemID
        Me.codeTextEdit.Text = item.ItemCode
        Me.customerLookUpEdit.EditValue = item.ItemCustomerID.CustomerID
        Me.customerLookUpEdit.Enabled = False
        Me.descriptionMemoEdit.Text = item.ItemDescription
        Me.typeLookUpEdit.EditValue = item.ItemType
        Me.typeLookUpEdit.Enabled = False
        UpdateTypeSensitiveControls()
        Me.standardProductionTextEdit.EditValue = item.ItemProdStandard
        If item.ItemDefaultMachine IsNot Nothing Then
            Me.defaultMachineLookUpEdit.EditValue = item.ItemDefaultMachine.MachineLineID
        Else
            Me.defaultMachineLookUpEdit.EditValue = Nothing
        End If

        Me.uomLookUpEdit.EditValue = item.strUnitOfMeasure
        Me.qtyOnHandTextEdit.EditValue = ItemsBLL.GetQtyOnHandByID(m_ItemsSession, m_CurrentItemID, 0)
        Me.qtyPerUnitTextEdit.EditValue = item.intQtyPerUnit
        If Me.unitsPerCaseTextEdit.Enabled = True Then
            Me.unitsPerCaseTextEdit.EditValue = item.intUnitsPerCase
        End If
        If Me.unitsPerPalletTextEdit.Enabled = True Then
            Me.unitsPerPalletTextEdit.EditValue = item.intUnitsPerPallet
        End If
        If Me.casesPerPalletTextEdit.Enabled = True Then
            Me.casesPerPalletTextEdit.EditValue = item.intCasesPerPallet
        End If
        Me.caseGrossWeightTextEdit.EditValue = item.CaseGrossWeight
        Me.inactiveCheckEdit.Checked = item.Inactive
        Me.packersTextEdit.EditValue = If(item.Packers.HasValue, item.Packers, Nothing)
        If String.IsNullOrEmpty(item.UPC) Then
            upcTextEdit.EditValue = Nothing
        Else
            upcTextEdit.EditValue = item.UPC
        End If
        bagsPerCaseTextEdit.EditValue = If(item.BagsPerCase.HasValue, item.BagsPerCase, Nothing)
        lotCodeFormatLookUpEdit.EditValue = item.DefaultLotCodeFormat
        requiresExpirationDateCheckEdit.Checked = If(item.RequiresExpirationDates.HasValue, item.RequiresExpirationDates.Value, Nothing)
        requiresLotCodeCheckEdit.Checked = If(item.RequiresLotCodes.HasValue, item.RequiresLotCodes.Value, Nothing)
        generateLotCodesCheckEdit.Checked = If(item.GenerateLotCodes.HasValue, item.GenerateLotCodes.Value, Nothing)
        minutesPerShiftTextEdit.EditValue = item.MinutesPerShift

        shippingExpirationDateGridColumn.DisplayFormat.FormatString = CustomersBLL.GetExpirationDateFormat(item.ItemCustomerID.CustomerID)
        shippingReturnExpirationDateGridColumn.DisplayFormat.FormatString = CustomersBLL.GetExpirationDateFormat(item.ItemCustomerID.CustomerID)
        receivingExpirationDateGridColumn.DisplayFormat.FormatString = CustomersBLL.GetExpirationDateFormat(item.ItemCustomerID.CustomerID)
        receivingReturnExpirationDateGridColumn.DisplayFormat.FormatString = CustomersBLL.GetExpirationDateFormat(item.ItemCustomerID.CustomerID)
        productionExpirationDateGridColumn.DisplayFormat.FormatString = CustomersBLL.GetExpirationDateFormat(item.ItemCustomerID.CustomerID)
        colItemExpirationDate.DisplayFormat.FormatString = CustomersBLL.GetExpirationDateFormat(item.ItemCustomerID.CustomerID)

        Me.shippingGridControl.DataSource = m_ShippingDetail.GetShippingDetailsByItemID(itemID)
        shippingReturnGridControl.DataSource = ShippingReturnDetailsBLL.GetShippingReturnDetailsViewByItemID(itemID)

        Me.productionGridControl.DataSource = m_Inventory.GetInventoryByItemID(itemID)

        Me.receivingsGridControl.DataSource = m_ReceivingDetails.GetReceivingDetailsByItemID(itemID)
        receivingReturnGridControl.DataSource = ReturnDetailsBLL.GetREceivingReturnDetailsByItemID(itemID)

        adjustmentGridControl.DataSource = InventoryAdjustmentBLL.GetAdjustmentsByItemID(itemID)

        'bind the BOM tab
        If CType(Me.customerLookUpEdit.EditValue, String) = Me.customerLookUpEdit.Properties.NullText Then
            Me.RMRepositoryItemLookUpEdit.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(Nothing, "RM|IG", True, m_ItemsSession)
            itemPoolsXpView.Criteria = Nothing
        Else
            Me.RMRepositoryItemLookUpEdit.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(CType(Me.customerLookUpEdit.EditValue, Integer?), "RM|IG", True, m_ItemsSession)
            itemPoolsXpView.Criteria = New BinaryOperator(ItemPool.Fields.PoolCustomerID.CustomerID.PropertyName, CType(customerLookUpEdit.EditValue, Integer), BinaryOperatorType.Equal)
        End If

        BindBomGridControls(itemID)

        productionStandardsXpCollection.Criteria = New BinaryOperator(ItemMachineStandards.Fields.ProductionItem.ItemID.PropertyName, itemID, BinaryOperatorType.Equal)
        productionStandardsXpCollection.Reload()

        Me.priceTextEdit.EditValue = item.dblPrice
        Me.rebateTextEdit.EditValue = item.sngRebate
        Me.freightTextEdit.EditValue = item.dblFreight
        Me.filmTextEdit.EditValue = item.dblFilm
        Me.boxesTextEdit.EditValue = item.dblBoxes
        Me.stretchWrapTextEdit.EditValue = item.dblStretchWrap
        Me.palletsTextEdit.EditValue = item.dblPallets
        Me.other1TextEdit.EditValue = item.dblOther1
        Me.other2TextEdit.EditValue = item.dblOther2
        Me.other3TextEdit.EditValue = item.dblOther3
        Me.other4TextEdit.EditValue = item.dblOther4
        Me.other5TextEdit.EditValue = item.dblOther5

        Me.packageCodeMemoEdit.EditValue = item.PackageCode
        Me.caseCodeMemoEdit.EditValue = item.CaseCode
        Me.requiredWeightTextEdit.EditValue = item.RequiredWeight
        Me.mavTextEdit.EditValue = item.MAV
        Me.cassesPerLayerTextEdit.EditValue = item.CasesPerLayer
        Me.layersPerPalletTextEdit.EditValue = item.LayersPerPallet
        Me.shelfLifeTextEdit.EditValue = item.ShelfLife
        Me.instructionsMemoEdit.EditValue = item.Instructions
        Me.palletPatternButtonEdit.EditValue = item.PalletPattern

        If m_CurrentItemID.HasValue Then
            inventoryXpView.Criteria = New BinaryOperator(LocationInventory.Fields.LocationInventoryItem.ItemID.PropertyName, m_CurrentItemID.Value, BinaryOperatorType.Equal)
            transfersXpView.Criteria = New BinaryOperator(LocationTransferDetails.Fields.TransferItem.ItemID.PropertyName, m_CurrentItemID.Value, BinaryOperatorType.Equal)
        Else
            inventoryXpView.Criteria = New BinaryOperator(LocationInventory.Fields.LocationInventoryItem.ItemID.PropertyName, 0, BinaryOperatorType.Equal)
            transfersXpView.Criteria = New BinaryOperator(LocationTransferDetails.Fields.TransferItem.ItemID.PropertyName, 0, BinaryOperatorType.Equal)
        End If


    End Sub

    Private Sub BindBomGridControls(ByVal itemID As Nullable(Of Integer))

        If itemID.HasValue = False Then
            itemID = 0
        End If

        If Me.bomXtraTabPage.PageVisible = True Then
            Dim bomdatasource As SPG.BOMDataTable = BOM.GetBOMBYFGItemID(itemID.Value)
            Me.bomGridControl.DataSource = bomdatasource
            Me.availabilityGridControl.DataSource = m_Items.GetAvailabilityByItemID(itemID.Value, UsersBLL.GetUsersLocalLocation(m_ItemsSession, My.Settings.UserName).Oid)
            poolBomXpCollection.Criteria = New BinaryOperator(PoolBom.Fields.PoolBomFiniGoodID.ItemID.PropertyName, itemID.Value, BinaryOperatorType.Equal)
            poolBomXpCollection.Reload()
        End If

    End Sub

    Private Sub BOMGridView_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles BOMGridView.InitNewRow

        Me.BOMGridView.SetRowCellValue(e.RowHandle, Me.FGItemCodeGridColumn, m_CurrentItemID)
        Me.BOMGridView.SetRowCellValue(e.RowHandle, Me.RMQuantityGridColumn, 0)
        Me.BOMGridView.SetRowCellValue(e.RowHandle, Me.scrapFactorGridColumn, 0)

    End Sub

    Private Sub BOMGridView_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles BOMGridView.CustomUnboundColumnData

        If Not IsDBNull(BOMGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.RMItemCodeGridColumn)) Then
            e.Value = ItemsBLL.GetDescriptionByItemID(CType(BOMGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.RMItemCodeGridColumn), Integer?))
        End If

    End Sub

    Private Sub AdvancedTextEditParseEditValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs) Handles priceTextEdit.ParseEditValue, stretchWrapTextEdit.ParseEditValue,
                palletsTextEdit.ParseEditValue, other5TextEdit.ParseEditValue, other4TextEdit.ParseEditValue, other3TextEdit.ParseEditValue, other2TextEdit.ParseEditValue, other1TextEdit.ParseEditValue,
                freightTextEdit.ParseEditValue, filmTextEdit.ParseEditValue, boxesTextEdit.ParseEditValue

        If e.Value IsNot Nothing AndAlso CStr(e.Value) <> String.Empty Then
            e.Value = Double.Parse(e.Value.ToString)
        End If

    End Sub

    Private Sub rebateTextEdit_ParseEditValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs) Handles rebateTextEdit.ParseEditValue

        If e.Value IsNot Nothing Then
            e.Value = Single.Parse(e.Value.ToString)
        End If


    End Sub

    Public Property CurrentItemID As Integer?
        Get
            Return m_CurrentItemID
        End Get
        Set(value As Integer?)
            m_CurrentItemID = value
            If value.HasValue Then
                BindItemControls(value.Value)
            End If
        End Set
    End Property

    Private Function SaveChanges() As Boolean

        'Required to get back to current customer when entering a new customer.
        Dim selectedID As Integer = -1
        If m_CurrentItemID.HasValue = False OrElse m_CurrentItemID.Value = -1 Then
            m_CurrentItemID = ItemsBLL.GetNewItemID()
        Else
            selectedID = itemSearchGridView.FocusedRowHandle
        End If

        Try
            If m_Items.UpdateProduct(m_CurrentItemID.Value, codeTextEdit.Text, descriptionMemoEdit.Text, Convert.ToString(typeLookUpEdit.EditValue), CType(customerLookUpEdit.EditValue, Integer?), CType(defaultMachineLookUpEdit.EditValue, Integer?),
                                     Utilities.ChangeType(Of Double?)(standardProductionTextEdit.EditValue), Utilities.ChangeType(Of Double?)(priceTextEdit.EditValue), Utilities.ChangeType(Of Single?)(rebateTextEdit.EditValue),
                                     Convert.ToString(uomLookUpEdit.EditValue), Utilities.ChangeType(Of Double?)(qtyPerUnitTextEdit.EditValue), Utilities.ChangeType(Of Double?)(freightTextEdit.EditValue),
                                     Utilities.ChangeType(Of Double?)(filmTextEdit.EditValue), Utilities.ChangeType(Of Double?)(boxesTextEdit.EditValue), Utilities.ChangeType(Of Double?)(stretchWrapTextEdit.EditValue),
                                     Utilities.ChangeType(Of Double?)(palletsTextEdit.EditValue), Utilities.ChangeType(Of Double?)(other1TextEdit.EditValue), Utilities.ChangeType(Of Double?)(other2TextEdit.EditValue),
                                     Utilities.ChangeType(Of Double?)(other3TextEdit.EditValue), Utilities.ChangeType(Of Double?)(other4TextEdit.EditValue), Utilities.ChangeType(Of Double?)(other5TextEdit.EditValue),
                                     Utilities.ChangeType(Of Double?)(unitsPerCaseTextEdit.EditValue), Utilities.ChangeType(Of Integer?)(unitsPerPalletTextEdit.EditValue), Utilities.ChangeType(Of Integer?)(casesPerPalletTextEdit.EditValue),
                                     Utilities.ChangeType(Of Single?)(qtyOnHandTextEdit.EditValue), Utilities.ChangeType(Of Double?)(caseGrossWeightTextEdit.EditValue), Convert.ToString(packageCodeMemoEdit.EditValue),
                                     Convert.ToString(caseCodeMemoEdit.EditValue), Convert.ToString(requiredWeightTextEdit.EditValue), Convert.ToString(mavTextEdit.EditValue), Convert.ToString(cassesPerLayerTextEdit.EditValue),
                                     Convert.ToString(layersPerPalletTextEdit.EditValue), Convert.ToString(shelfLifeTextEdit.EditValue), Convert.ToString(instructionsMemoEdit.EditValue), Convert.ToString(palletPatternButtonEdit.EditValue),
                                     inactiveCheckEdit.Checked, CDbl(packersTextEdit.EditValue), Convert.ToString(upcTextEdit.EditValue), Utilities.ChangeType(Of Integer?)(bagsPerCaseTextEdit.EditValue),
                                     Utilities.ChangeType(Of Boolean?)(requiresLotCodeCheckEdit.Checked), Utilities.ChangeType(Of Boolean?)(requiresExpirationDateCheckEdit.Checked), Utilities.ChangeType(Of Boolean?)(generateLotCodesCheckEdit.Checked),
                                     Utilities.ChangeType(Of Integer?)(lotCodeFormatLookUpEdit.EditValue), Utilities.ChangeType(Of Double?)(minutesPerShiftTextEdit.EditValue), m_ItemsSession) <> True Then
                MessageBox.Show("The item was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        If Me.bomXtraTabPage.PageVisible = True Then
            BOMGridView.CloseEditor()
            poolBomGridView.CloseEditor()

            Try
                BOMGridView.SelectAll()
                If BOMGridView.SelectedRowsCount > 0 Then
                    For i As Integer = 0 To BOMGridView.SelectedRowsCount - 1
                        Dim row As Integer = BOMGridView.GetSelectedRows()(i)
                        If row >= 0 Then
                            If BOM.UpdateBOM(CType(BOMGridView.GetRowCellValue(row, bomIDGridColumn), Integer?), CType(BOMGridView.GetRowCellValue(row, RMItemCodeGridColumn), Integer?),
                                    m_CurrentItemID.Value, CType(BOMGridView.GetRowCellValue(row, RMQuantityGridColumn), Single?),
                                    CType(BOMGridView.GetRowCellValue(row, scrapFactorGridColumn), Double?)) <> True Then
                                MessageBox.Show("The item bom was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return False
                            End If
                        End If
                    Next
                End If

                For Each poolItem As PoolBom In poolBomXpCollection
                    If poolItem.PoolBomFiniGoodID Is Nothing OrElse poolItem.PoolBomFiniGoodID.ItemID = -1 Then
                        poolItem.PoolBomFiniGoodID = m_ItemsSession.GetObjectByKey(Of Items)(m_CurrentItemID.Value)
                    End If
                    poolItem.Save()
                Next

            Catch ex As ApplicationException
                MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try
        End If

        If productionStandardsXtraTabPage.PageVisible = True Then
            productionStandardsGridView.CloseEditor()

            For Each itemMachineStandard As ItemMachineStandards In productionStandardsXpCollection
                If itemMachineStandard.ProductionItem Is Nothing OrElse itemMachineStandard.ProductionItem.ItemID = -1 Then
                    itemMachineStandard.ProductionItem = m_ItemsSession.GetObjectByKey(Of Items)(m_CurrentItemID.Value)
                End If
                itemMachineStandard.Save()
            Next
        End If

        BindItemsSearch()
        BindItemControls(m_CurrentItemID.Value)
        Me.itemSearchGridView.FocusedRowHandle = selectedID
        Return True

    End Function

    Private Sub customerFilterLookUpEdit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles customerFilterLookUpEdit.EditValueChanged

        If Me.customerFilterLookUpEdit.EditValue Is Nothing OrElse
                                CType(Me.customerFilterLookUpEdit.EditValue, String) = Me.customerFilterLookUpEdit.Properties.NullText Then
            BindItemsSearch()
        End If

    End Sub

    Public Property AdvancedTabs() As String

    Private Sub typeLookUpEdit_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles typeLookUpEdit.Leave

        UpdateTypeSensitiveControls()

    End Sub

    Private Sub UpdateTypeSensitiveControls()

        Select Case Convert.ToString(Me.typeLookUpEdit.EditValue)
            Case "RM"
                Me.bomXtraTabPage.PageVisible = False
                Me.availabilityXtraTabPage.PageVisible = False
                Me.shippingXtraTabPage.PageVisible = False
                Me.productionXtraTabPage.PageVisible = False
                Me.receivingXtraTabPage.PageVisible = True
                shippingReturnXtraTabPage.PageVisible = True
                receivingReturnXtraTabPage.PageVisible = False
                adjustmentXtraTabPage.PageVisible = True
                productionStandardsXtraTabPage.PageVisible = False
            Case "IG"
                Me.bomXtraTabPage.PageVisible = True
                Me.availabilityXtraTabPage.PageVisible = True
                Me.shippingXtraTabPage.PageVisible = False
                Me.receivingXtraTabPage.PageVisible = True
                Me.productionXtraTabPage.PageVisible = True
                shippingReturnXtraTabPage.PageVisible = True
                receivingReturnXtraTabPage.PageVisible = False
                adjustmentXtraTabPage.PageVisible = True
                productionStandardsXtraTabPage.PageVisible = True
                BindBomGridControls(m_CurrentItemID)
            Case "FG"
                Me.bomXtraTabPage.PageVisible = True
                Me.availabilityXtraTabPage.PageVisible = True
                Me.receivingXtraTabPage.PageVisible = False
                Me.shippingXtraTabPage.PageVisible = True
                Me.productionXtraTabPage.PageVisible = True
                shippingReturnXtraTabPage.PageVisible = False
                receivingReturnXtraTabPage.PageVisible = True
                adjustmentXtraTabPage.PageVisible = True
                productionStandardsXtraTabPage.PageVisible = True
                BindBomGridControls(m_CurrentItemID)
        End Select

    End Sub

    Private Sub printSimpleButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles printSimpleButton.Click

        BestFitColumns()
        Me.availabilityGridControl.Print()

    End Sub

    Private Sub availabilityGridView_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles availabilityGridView.CustomUnboundColumnData

        If Not IsDBNull(availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.availabilityItemIDGridColumn)) AndAlso availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.availabilityItemIDGridColumn) IsNot Nothing _
                AndAlso Not IsDBNull(availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.quantityOnHandGridColumn)) Then
            If e.Column.Name = "quantityYieldsGridColumn" And e.IsGetData Then
                e.Value = Int(Convert.ToDouble(availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.quantityOnHandGridColumn)) /
                        (Convert.ToDouble(availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.quantityRequiredGridColumn)) +
                         (Convert.ToDouble(availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.scrapPercentageGridColumn)) / 100 *
                          Convert.ToDouble(availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, Me.quantityRequiredGridColumn)))))
                'e.value = availabilityGridView.GetRowCellValue(e.RowHandle, Me.quantityOnHandGridColumn)
            ElseIf e.Column.Name = localQuantityYieldsGridColumn.Name And e.IsGetData Then
                e.Value = Int(Convert.ToDouble(availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, localQuantityOnHandGridColumn)) /
                              (Convert.ToDouble(availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, quantityRequiredGridColumn)) +
                               (Convert.ToDouble(availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, scrapPercentageGridColumn)) / 100 *
                                Convert.ToDouble(availabilityGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, quantityRequiredGridColumn)))))
            End If
        End If

    End Sub

    Private Sub itemsXtraTabControl_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles itemsXtraTabControl.SelectedPageChanged

        Select Case e.Page.Name
            Case "availabilityXtraTabPage"
                Me.availabilityGridView.UpdateTotalSummary()
                Me.printGridBarButtonItem.Enabled = True
                BestFitColumns()
            Case Me.generalXtraTabPage.Name
                Me.printGridBarButtonItem.Enabled = False
            Case Me.shippingXtraTabPage.Name
                Me.printGridBarButtonItem.Enabled = True
                Me.shippingGridView.BestFitColumns()
            Case shippingReturnXtraTabPage.Name
                printGridBarButtonItem.Enabled = True
                shippingReturnGridView.BestFitColumns()
            Case Me.receivingXtraTabPage.Name
                Me.printGridBarButtonItem.Enabled = True
                Me.receivingsGridView.BestFitColumns()
            Case receivingReturnXtraTabPage.Name
                printGridBarButtonItem.Enabled = True
                receivingReturnGridView.BestFitColumns()
            Case Me.productionXtraTabPage.Name
                Me.printGridBarButtonItem.Enabled = True
                Me.productionGridView.BestFitColumns()
            Case adjustmentXtraTabPage.Name
                printGridBarButtonItem.Enabled = True
                adjustmentGridView.BestFitColumns()
            Case Me.transfersXtraTabPage.Name
                printGridBarButtonItem.Enabled = True
                transfersGridView.BestFitColumns()
            Case Me.bomXtraTabPage.Name
                Me.printGridBarButtonItem.Enabled = True
                Me.BOMGridView.BestFitColumns()
                If Me.customerLookUpEdit.EditValue IsNot Nothing AndAlso CType(Me.customerLookUpEdit.EditValue, String) <> Me.customerLookUpEdit.Properties.NullText Then
                    Me.RMRepositoryItemLookUpEdit.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(CType(Me.customerLookUpEdit.EditValue, Integer?), "RM|IG", True, m_ItemsSession)
                    itemPoolsXpView.Criteria = New BinaryOperator(ItemPool.Fields.PoolCustomerID.CustomerID.PropertyName, CType(customerLookUpEdit.EditValue, Integer), BinaryOperatorType.Equal)
                Else
                    MessageBox.Show("You must select first a customer.")
                    itemsXtraTabControl.SelectedTabPage = e.PrevPage
                End If
            Case Me.specificationXtraTabPage.Name
                Me.printGridBarButtonItem.Enabled = False
            Case Me.advancedXtraTabPage.Name
                Me.printGridBarButtonItem.Enabled = False
            Case productionStandardsXtraTabPage.Name
                printGridBarButtonItem.Enabled = True
                productionStandardsGridView.BestFitColumns()
        End Select

    End Sub

    Private Sub previewSimpleButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles previewSimpleButton.Click

        BestFitColumns()
        Me.availabilityGridControl.ShowPrintPreview()

    End Sub

    Private Sub BestFitColumns()

        Me.bomItemCodeGridColumn.BestFit()
        Me.quantityOnHandGridColumn.BestFit()
        Me.quantityYieldsGridColumn.BestFit()
        localQuantityOnHandGridColumn.BestFit()
        localQuantityYieldsGridColumn.BestFit()

    End Sub

    Private Sub typeFilterLookUpEdit_Closed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles typeFilterLookUpEdit.Closed

        BindItemsSearch()

    End Sub

    Private Sub typeFilterLookUpEdit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles typeFilterLookUpEdit.EditValueChanged

        If Me.typeFilterLookUpEdit.EditValue Is Nothing OrElse
                CType(Me.typeFilterLookUpEdit.EditValue, String) = Me.typeFilterLookUpEdit.Properties.NullText Then
            BindItemsSearch()
        End If

    End Sub

    Private Sub UnitsPerPalletCalculation(ByVal sender As Object, ByVal e As EventArgs) Handles unitsPerCaseTextEdit.Validated,
            casesPerPalletTextEdit.Validated

        Me.unitsPerPalletTextEdit.Text = (Convert.ToDouble(unitsPerCaseTextEdit.EditValue) * Convert.ToDouble(casesPerPalletTextEdit.EditValue)).ToString

    End Sub

    Private Sub clearFilterSimpleButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles clearFilterSimpleButton.Click

        Me.customerFilterLookUpEdit.EditValue = Nothing
        Me.typeFilterLookUpEdit.EditValue = Nothing

    End Sub

    Private Sub uomLookUpEdit_ProcessNewValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ProcessNewValueEventArgs) Handles uomLookUpEdit.ProcessNewValue

        Dim edit As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit = CType(sender, LookUpEdit).Properties
        If e.DisplayValue.ToString = edit.NullText OrElse e.DisplayValue.ToString = String.Empty Then
            Exit Sub
        End If

        CType(uomLookUpEdit.Properties.DataSource, ArrayList).Add(e.DisplayValue.ToString)

        e.Handled = True

    End Sub

    Private Sub palletPatternButtonEdit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles palletPatternButtonEdit.ButtonClick

        If patternOpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            palletPatternButtonEdit.EditValue = patternOpenFileDialog.FileName
        End If

    End Sub

    Private Sub printGridBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles printGridBarButtonItem.ItemClick

        Dim pcl As New PrintableComponentLink(New PrintingSystem())
        Dim pcl2 As PrintableComponentLink = Nothing
        AddHandler pcl.CreateReportHeaderArea, AddressOf PrintableComponentLink_CreateReportHeaderArea

        Select Case Me.itemsXtraTabControl.SelectedTabPage.Name
            Case Me.shippingXtraTabPage.Name
                pcl.Component = shippingGridControl
                m_GridReportTitle = "Shipping"
            Case shippingReturnXtraTabPage.Name
                pcl.Component = shippingReturnGridControl
                m_GridReportTitle = "Shipping Returns"
            Case Me.productionXtraTabPage.Name
                pcl.Component = productionGridControl
                m_GridReportTitle = "Inventory"
            Case Me.receivingXtraTabPage.Name
                pcl.Component = receivingsGridControl
                m_GridReportTitle = "Receivings"
            Case receivingReturnXtraTabPage.Name
                pcl.Component = receivingReturnGridControl
                m_GridReportTitle = "Receiving Returns"
            Case transfersXtraTabPage.Name
                pcl.Component = transfersGridControl
                m_GridReportTitle = "Item Transfers"
            Case Me.bomXtraTabPage.Name
                pcl.Component = bomGridControl
                m_GridReportTitle = "BOM"
                pcl2 = New PrintableComponentLink(New PrintingSystem())
                AddHandler pcl2.CreateReportHeaderArea, AddressOf PrintableComponentLink_CreateReportHeaderArea
                pcl2.Component = poolBomGridControl
            Case Me.availabilityXtraTabPage.Name
                pcl.Component = availabilityGridControl
                m_GridReportTitle = "Availability"
            Case adjustmentXtraTabPage.Name
                pcl.Component = adjustmentGridControl
                m_GridReportTitle = "Inventory Adjustments"
            Case productionStandardsXtraTabPage.Name
                pcl.Component = productionStandardsGridControl
                m_GridReportTitle = "Item Machine Standards"
        End Select

        pcl.CreateDocument()
        pcl.ShowPreviewDialog()

        If pcl2 IsNot Nothing Then
            pcl2.CreateDocument()
            pcl2.ShowPreviewDialog()
        End If

    End Sub

    Private Sub PrintableComponentLink_CreateReportHeaderArea(ByVal sender As Object, ByVal e As CreateAreaEventArgs)

        Dim brick As TextBrick = e.Graph.DrawString(String.Format("{0} {1} Item # {2}", m_GridReportTitle, vbCrLf, m_CurrentItemID), Color.Black, New RectangleF(0, 5, 600, 25), BorderSide.None)
        brick.Font = New Font("Arial", 14, FontStyle.Bold)
        brick.StringFormat = New BrickStringFormat(StringAlignment.Center)

    End Sub

    Private Sub itemSearchGridView_Click(ByVal sender As Object, ByVal e As EventArgs) Handles itemSearchGridView.Click

        If itemSearchGridView.FocusedRowHandle = -999997 Then
            Exit Sub
        End If

        If (Me.itemSearchGridView.CalcHitInfo(Me.itemsSearchGridControl.PointToClient(Control.MousePosition)).HitTest = GridHitTest.RowCell) Then
            Me.BindItemControls(CType(Me.itemSearchGridView.GetFocusedRowCellValue(Me.itemIDGridColumn), Integer))
        End If

    End Sub

    Private Sub addBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles addBarButtonItem.ItemClick

        m_CurrentItemID = -1
        Me.codeTextEdit.Text = Nothing
        Me.customerLookUpEdit.EditValue = Nothing
        Me.customerLookUpEdit.Enabled = True
        Me.descriptionMemoEdit.Text = Nothing
        Me.typeLookUpEdit.EditValue = Nothing
        Me.typeLookUpEdit.Enabled = True
        Me.standardProductionTextEdit.EditValue = 0
        Me.defaultMachineLookUpEdit.EditValue = Nothing
        Me.uomLookUpEdit.EditValue = Nothing
        Me.qtyPerUnitTextEdit.EditValue = 1
        Me.unitsPerCaseTextEdit.EditValue = 1
        Me.unitsPerPalletTextEdit.EditValue = 0
        Me.casesPerPalletTextEdit.EditValue = 0
        Me.qtyOnHandTextEdit.EditValue = 0
        Me.caseGrossWeightTextEdit.EditValue = 0
        Me.packersTextEdit.EditValue = 0
        Me.inactiveCheckEdit.Checked = False
        upcTextEdit.EditValue = Nothing
        requiresExpirationDateCheckEdit.Checked = False
        requiresLotCodeCheckEdit.Checked = False
        generateLotCodesCheckEdit.Checked = False
        lotCodeFormatLookUpEdit.EditValue = Nothing
        minutesPerShiftTextEdit.EditValue = 0

        BindBomGridControls(m_CurrentItemID)

        Me.priceTextEdit.EditValue = 0
        Me.rebateTextEdit.EditValue = 0
        Me.freightTextEdit.EditValue = 0
        Me.filmTextEdit.EditValue = 0
        Me.boxesTextEdit.EditValue = 0
        Me.stretchWrapTextEdit.EditValue = 0
        Me.palletsTextEdit.EditValue = 0
        Me.other1TextEdit.EditValue = 0
        Me.other2TextEdit.EditValue = 0
        Me.other3TextEdit.EditValue = 0
        Me.other4TextEdit.EditValue = 0
        Me.other5TextEdit.EditValue = 0

        Me.packageCodeMemoEdit.EditValue = Nothing
        Me.caseCodeMemoEdit.EditValue = Nothing
        Me.requiredWeightTextEdit.EditValue = Nothing
        Me.mavTextEdit.EditValue = Nothing
        Me.cassesPerLayerTextEdit.EditValue = Nothing
        Me.layersPerPalletTextEdit.EditValue = Nothing
        Me.shelfLifeTextEdit.EditValue = Nothing
        Me.instructionsMemoEdit.EditValue = Nothing
        Me.palletPatternButtonEdit.EditValue = Nothing

        Me.shippingGridControl.DataSource = m_ShippingDetail.GetShippingDetailsByItemID(m_CurrentItemID.Value)
        shippingReturnGridControl.DataSource = ShippingReturnDetailsBLL.GetShippingReturnDetailsViewByItemID(m_CurrentItemID.Value)

        Me.productionGridControl.DataSource = m_Inventory.GetInventoryByItemID(m_CurrentItemID.Value)

        Me.receivingsGridControl.DataSource = m_ReceivingDetails.GetReceivingDetailsByItemID(m_CurrentItemID.Value)
        receivingReturnGridControl.DataSource = ReturnDetailsBLL.GetREceivingReturnDetailsByItemID(m_CurrentItemID.Value)

        adjustmentGridControl.DataSource = InventoryAdjustmentBLL.GetAdjustmentsByItemID(m_CurrentItemID.Value)

        inventoryXpView.Criteria = New BinaryOperator(LocationInventory.Fields.LocationInventoryItem.ItemID, m_CurrentItemID.Value, BinaryOperatorType.Equal)
        transfersXpView.Criteria = New BinaryOperator(LocationTransferDetails.Fields.TransferItem.ItemID.PropertyName, m_CurrentItemID.Value, BinaryOperatorType.Equal)

        productionStandardsXpCollection.Criteria = New BinaryOperator(ItemMachineStandards.Fields.ProductionItem.ItemID.PropertyName, -1, BinaryOperatorType.Equal)
        productionStandardsXpCollection.Reload()

        Me.itemsXtraTabControl.SelectedTabPage = Me.generalXtraTabPage

        Me.itemSearchGridView.FocusedRowHandle = -1
        Utilities.MakeFormReadOnly(Me.generalXtraTabPage, False)
        qtyOnHandTextEdit.Properties.ReadOnly = True
        unitsPerPalletTextEdit.Properties.ReadOnly = True
        Utilities.MakeFormReadOnly(Me.advancedXtraTabPage, False)
        Utilities.MakeFormReadOnly(Me.specificationXtraTabPage, False)
        Me.BOMGridView.OptionsBehavior.Editable = True
        poolBomGridView.OptionsBehavior.Editable = True
        productionStandardsGridView.OptionsBehavior.Editable = True
        Me.itemsSearchGridControl.Enabled = False
        CheckPermissions()

        Me.cancelBarButtonItem.Enabled = True
        Me.saveBarButtonItem.Enabled = True
        Me.editBarButtonItem.Enabled = False
        Me.addBarButtonItem.Enabled = False
        Me.deleteBarButtonItem.Enabled = False
        Me.deleteGridColumn.Visible = False
        poolBomDeleteGridColumn.Visible = False

    End Sub

    Private Sub editBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles editBarButtonItem.ItemClick

        If m_CurrentItemID Is Nothing Then
            MessageBox.Show("Please select a item to edit.")
            Exit Sub
        End If

        If ItemsBLL.AllowEdit(m_ItemsSession, m_CurrentItemID.Value) = False Then
            If MessageBox.Show("Someone else is editing now this item." + vbCrLf + "Do you want to edit anyway?", "Item in use", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If
        End If

        Utilities.MakeFormReadOnly(Me.generalXtraTabPage, False)
        qtyOnHandTextEdit.Properties.ReadOnly = True
        unitsPerPalletTextEdit.Properties.ReadOnly = True
        Utilities.MakeFormReadOnly(Me.advancedXtraTabPage, False)
        Utilities.MakeFormReadOnly(Me.specificationXtraTabPage, False)
        Me.BOMGridView.OptionsBehavior.Editable = True
        poolBomGridView.OptionsBehavior.Editable = True
        productionStandardsGridView.OptionsBehavior.Editable = True
        Me.itemsSearchGridControl.Enabled = False
        CheckPermissions()

        Me.cancelBarButtonItem.Enabled = True
        Me.saveBarButtonItem.Enabled = True
        Me.editBarButtonItem.Enabled = False
        Me.addBarButtonItem.Enabled = False
        Me.deleteBarButtonItem.Enabled = False

    End Sub

    Private Sub deleteBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles deleteBarButtonItem.ItemClick

        If MessageBox.Show("Are you sure you want to delete this item.", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Try
            If m_Items.DeleteIem(m_CurrentItemID.Value) = True Then
                BindItemsSearch()
            Else
                MessageBox.Show("The item was not deleted.")
            End If
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cancelBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cancelBarButtonItem.ItemClick

        CancelChanges()

        CheckPermissions()

        Utilities.MakeFormReadOnly(Me.generalXtraTabPage, True)
        Utilities.MakeFormReadOnly(Me.advancedXtraTabPage, True)
        Utilities.MakeFormReadOnly(Me.specificationXtraTabPage, True)
        Me.BOMGridView.OptionsBehavior.Editable = False
        poolBomGridView.OptionsBehavior.Editable = False
        productionStandardsGridView.OptionsBehavior.Editable = False
        Me.itemsSearchGridControl.Enabled = True

        cancelBarButtonItem.Enabled = False
        saveBarButtonItem.Enabled = False

    End Sub

    Private Sub saveBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles saveBarButtonItem.ItemClick

        If SaveChanges() Then

            CheckPermissions()

            Utilities.MakeFormReadOnly(Me.generalXtraTabPage, True)
            Utilities.MakeFormReadOnly(Me.advancedXtraTabPage, True)
            Utilities.MakeFormReadOnly(Me.specificationXtraTabPage, True)
            Me.BOMGridView.OptionsBehavior.Editable = False
            poolBomGridView.OptionsBehavior.Editable = False
            productionStandardsGridView.OptionsBehavior.Editable = False
            Me.itemsSearchGridControl.Enabled = True

            cancelBarButtonItem.Enabled = False
            saveBarButtonItem.Enabled = False
        End If

    End Sub

    Private Sub specificationsBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles specificationsBarButtonItem.ItemClick

        If m_CurrentItemID Is Nothing Then
            MessageBox.Show("Select an item first.")
            Exit Sub
        End If

        Dim specifications As New ProductSpecificationsXtraReport

        With specifications
            .itemCodeXrLabel.DataBindings.Add("Text", Nothing, "ItemCode")
            .itemDescriptionXrLabel.DataBindings.Add("Text", Nothing, "ItemDescription")
            .itemBomsXrLabel.Text = New BOMBLL().GetBOMBYFGItemIDString(m_CurrentItemID.Value)
            .requiredWeightXrLabel.DataBindings.Add("Text", Nothing, "RequiredWeight")
            .mavXrLabel.DataBindings.Add("Text", Nothing, "MAV")
            .unitsPerCaseXrLabel.DataBindings.Add("Text", Nothing, "intUnitsPerCase", "{0:N2}")
            .casesPerPalletXrLabel.DataBindings.Add("Text", Nothing, "intCasesPerPallet")
            .casesPerLayerXrLabel.DataBindings.Add("Text", Nothing, "CasesPerLayer")
            .layersPerPalletXrLabel.DataBindings.Add("Text", Nothing, "LayersPerPallet")
            .packageCodeXrLabel.DataBindings.Add("Text", Nothing, "PackageCode")
            .caseCodeXrLabel.DataBindings.Add("Text", Nothing, "CaseCode")
            .shelfLifeXrLabel.DataBindings.Add("Text", Nothing, "ShelfLife")
            .specialInstructionsXrLabel.DataBindings.Add("Text", Nothing, "Instructions")
            .palletPaternXrPictureBox.DataBindings.Add("ImageUrl", Nothing, "PalletPattern")
            .DataSource = m_Items.GetItemBYId(m_CurrentItemID.Value)
            .ShowPreview()
        End With

    End Sub

    Private Sub palletTicketBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles palletTicketBarButtonItem.ItemClick

        If m_CurrentItemID Is Nothing Then
            MessageBox.Show("Select an item first")
            Exit Sub
        End If

        Dim ticket As New PalletTicketXtraReport() With {.DataSource = New PalletTicketBLL().GetPalletTicket(m_CurrentItemID.Value)}
        ticket.customerXrLabel.DataBindings.Add("Text", Nothing, "CustomerName")
        ticket.itemXrLabel.DataBindings.Add("Text", Nothing, "ItemCode")
        ticket.itemDescriptionXrLabel.DataBindings.Add("Text", Nothing, "ItemDescription")
        ticket.itemTypeXrLabel.DataBindings.Add("Text", Nothing, "ItemType")
        ticket.casesPerPalletXrLabel.DataBindings.Add("Text", Nothing, "intCasesPerPallet")
        ticket.ShowPreview()

    End Sub

    Public Function CheckPermissions() As Boolean

        Try
            Dim permission As SPG.UserPermissionsRow = New UserPermissionsBLL().GetUserPermissionsByUserName(My.Settings.UserName, "Items Form")(0)

            Select Case permission.PermissionLevel
                Case "FULL", "Full"
                    Me.addBarButtonItem.Enabled = True
                    Me.editBarButtonItem.Enabled = True
                    Me.deleteBarButtonItem.Enabled = True
                    Me.deleteGridColumn.Visible = True
                    Me.deleteGridColumn.VisibleIndex = 0
                    poolBomDeleteGridColumn.Visible = True
                    poolBomDeleteGridColumn.VisibleIndex = 0
                    delProdStdGridColumn.Visible = True
                    delProdStdGridColumn.VisibleIndex = 0
                Case "ADD", "Add"
                    Me.addBarButtonItem.Enabled = True
                    Me.editBarButtonItem.Enabled = True
                    Me.deleteBarButtonItem.Enabled = False
                    Me.deleteGridColumn.Visible = False
                    poolBomDeleteGridColumn.Visible = False
                    delProdStdGridColumn.Visible = False
                Case "NONE", "None"
                    MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Me.Close()
                    Return False
                Case "VIEW", "View"
                    Me.addBarButtonItem.Enabled = False
                    Me.editBarButtonItem.Enabled = False
                    Me.deleteBarButtonItem.Enabled = False
                    Me.deleteGridColumn.Visible = False
                    poolBomDeleteGridColumn.Visible = False
                    delProdStdGridColumn.Visible = False
                Case "EDIT", "Edit"
                    Me.addBarButtonItem.Enabled = False
                    Me.editBarButtonItem.Enabled = True
                    Me.deleteBarButtonItem.Enabled = False
                    Me.deleteGridColumn.Visible = False
                    poolBomDeleteGridColumn.Visible = False
                    delProdStdGridColumn.Visible = False
                Case "VIEW ASSIGNED"
                    Me.addBarButtonItem.Enabled = False
                    Me.editBarButtonItem.Enabled = False
                    Me.deleteGridColumn.Visible = False
                    poolBomDeleteGridColumn.Visible = False
                    Me.deleteBarButtonItem.Enabled = False
                    delProdStdGridColumn.Visible = False
                    FilterAssignedCustomers()
                Case "EDIT ASSIGNED"
                    Me.addBarButtonItem.Enabled = False
                    Me.editBarButtonItem.Enabled = True
                    Me.deleteGridColumn.Visible = False
                    poolBomDeleteGridColumn.Visible = False
                    Me.deleteBarButtonItem.Enabled = False
                    delProdStdGridColumn.Visible = False
                    FilterAssignedCustomers()
                Case Else
                    MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                    Return False
            End Select

            Select Case Me.AdvancedTabs
                Case "FULL", "Full"
                    Utilities.MakeFormReadOnly(Me.advancedXtraTabPage, False)
                Case "ADD", "Add"
                    Utilities.MakeFormReadOnly(Me.advancedXtraTabPage, False)
                Case "NONE", "None"
                    Me.advancedXtraTabPage.PageVisible = False
                Case "VIEW", "View", "VIEW ASSIGNED"
                    Utilities.MakeFormReadOnly(Me.advancedXtraTabPage, True)
                Case "EDIT", "Edit", "EDIT ASSIGNED"
                    Utilities.MakeFormReadOnly(Me.advancedXtraTabPage, False)
            End Select
            Return True
        Catch ex As InvalidOperationException
            Return False
        End Try

    End Function

    Private Sub FilterAssignedCustomers()

        Me.itemSearchXPView.Criteria = New InOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ItemsSession))

    End Sub


    Private Sub CancelChanges()

        If Me.m_CurrentItemID.HasValue AndAlso Me.m_CurrentItemID.Value <> -1 Then
            BindItemControls(m_CurrentItemID.Value)
            m_Items.EndedEdit(m_ItemsSession, m_CurrentItemID.Value)
        End If

    End Sub

    Private Sub inactiveSearchCheckEdit_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles inactiveSearchCheckEdit.CheckedChanged

        BindItemsSearch()

    End Sub

    Private Sub RMRepositoryItemLookUpEdit_Closed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles RMRepositoryItemLookUpEdit.Closed

        If e.CloseMode <> PopupCloseMode.Cancel Then
            Dim view As GridView = CType(CType(CType(sender, LookUpEdit).Parent, GridControl).FocusedView, GridView)
            If view.IsNewItemRow(view.FocusedRowHandle) Then
                view.CloseEditor()
                view.UpdateCurrentRow()
            End If
        End If

    End Sub

    Private Sub deleteRepositoryItemButtonEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles deleteRepositoryItemButtonEdit.Click

        If MessageBox.Show("Are you sure you want to delete this BOM item.", "Delete BOM Item", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Try
            Dim BOMID As Integer = CInt(Me.BOMGridView.GetRowCellValue(Me.BOMGridView.FocusedRowHandle, Me.bomIDGridColumn))
            If BOMID < 1 OrElse m_BOM.DeleteBOM(BOMID) = True Then
                BindBomGridControls(m_CurrentItemID)
            Else
                MessageBox.Show("The BOM item was not deleted.")
            End If
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'Private Sub adjustmentGridView_CustomUnboundColumnData(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles adjustmentGridView.CustomUnboundColumnData

    '    If e.Column.Name = adjustmentQuantityGridColumn.Name Then
    '        If IsDBNull(adjustmentGridView.GetRowCellValue(e.RowHandle, adjustmentOriginalQuantityGridColumn)) OrElse IsDBNull(adjustmentGridView.GetRowCellValue(e.RowHandle, adjustmentNewQtyGridColumn)) Then
    '            Exit Sub
    '        End If
    '        e.Value = CType(adjustmentGridView.GetRowCellValue(e.RowHandle, adjustmentNewQtyGridColumn), Integer) - CType(adjustmentGridView.GetRowCellValue(e.RowHandle, adjustmentOriginalQuantityGridColumn), Integer)
    '    End If

    'End Sub

    Private Sub adjustmentGridView_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs) Handles adjustmentGridView.RowCellStyle

        If e.Column.Name = adjustmentQuantityGridColumn.Name Then
            If IsDBNull(adjustmentGridView.GetRowCellValue(e.RowHandle, adjustmentQuantityGridColumn)) OrElse CType(adjustmentGridView.GetRowCellValue(e.RowHandle, adjustmentQuantityGridColumn), Integer) >= 0 Then
                e.Appearance.ForeColor = Color.Black
            Else
                e.Appearance.ForeColor = Color.Red
            End If
        End If

    End Sub

    Private Sub poolBomDeleteRepositoryItemButtonEdit_Click(sender As Object, e As EventArgs) Handles poolBomDeleteRepositoryItemButtonEdit.Click

        If MessageBox.Show("Are you sure you want to remove this pool item.", "Delete Pool Detail", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Dim poolItem As PoolBom = m_ItemsSession.GetObjectByKey(Of PoolBom)(poolBomGridView.GetFocusedRowCellValue(colOid))
        If Not poolItem Is Nothing Then
            poolItem.Delete()

            If poolItem.IsDeleted = False Then
                MessageBox.Show("The pool item was not removed.")
            End If
        Else
            poolBomGridView.DeleteRow(poolBomGridView.FocusedRowHandle)
        End If

    End Sub

    Private Sub delProdStdRepositoryItemButtonEdit_Click(sender As Object, e As EventArgs) Handles delProdStdRepositoryItemButtonEdit.Click

        If MessageBox.Show("Are you sure you want to remove this production standard?", "Delete Item-Machine Standard", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = DialogResult.No Then
            Exit Sub
        End If

        Dim productionStandard As ItemMachineStandards = m_ItemsSession.GetObjectByKey(Of ItemMachineStandards)(productionStandardsGridView.GetFocusedRowCellValue(colOid1))
        If Not productionStandard Is Nothing Then
            productionStandard.Delete()

            If productionStandard.IsDeleted = False Then
                MessageBox.Show("The production standard was not removed.")
            End If
        Else
            productionStandardsGridView.DeleteRow(productionStandardsGridView.FocusedRowHandle)
        End If

    End Sub

    Private Sub productionGridView_FilterEditorCreated(sender As Object, e As Views.Base.FilterControlEventArgs) Handles productionGridView.FilterEditorCreated
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
