Imports DXDAL.SPGData
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid

Public Class ItemPoolXtraForm

    Private m_CurrentPoolID As ItemPool
    Private m_ItemPoolSession As Session

    Private Sub addBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles addBarButtonItem.ItemClick

        m_CurrentPoolID = New ItemPool(m_ItemPoolSession)
        codeTextEdit.Text = Nothing
        customerLookUpEdit.EditValue = Nothing
        customerLookUpEdit.Enabled = True
        descriptionMemoEdit.Text = Nothing

        poolDetailsXpCollection.Criteria = New BinaryOperator(ItemPoolDetails.Fields.ItemPoolID, m_CurrentPoolID.Oid, BinaryOperatorType.Equal)
        poolDetailsXpCollection.Reload()

        If CType(Me.customerLookUpEdit.EditValue, String) = Me.customerLookUpEdit.Properties.NullText Then
            itemRepositoryItemLookUpEdit.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(Nothing, "RM", True, m_ItemPoolSession)
        Else
            itemRepositoryItemLookUpEdit.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(CType(Me.customerLookUpEdit.EditValue, Integer?), "RM", True, m_ItemPoolSession)
        End If

        Utilities.MakeFormReadOnly(poolXtraTabPage, False)
        poolDetailsGridView.OptionsBehavior.Editable = True
        poolSearchGridControl.Enabled = False
        CheckPermissions()

        cancelBarButtonItem.Enabled = True
        saveBarButtonItem.Enabled = True
        editBarButtonItem.Enabled = False
        addBarButtonItem.Enabled = False
        deleteBarButtonItem.Enabled = False
        deleteGridColumn.Visible = False

    End Sub

    Private Sub cancelBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cancelBarButtonItem.ItemClick

        CancelChanges()

        CheckPermissions()

        Utilities.MakeFormReadOnly(poolXtraTabPage, True)
        poolDetailsGridView.OptionsBehavior.Editable = False
        poolSearchGridControl.Enabled = True

        cancelBarButtonItem.Enabled = False
        saveBarButtonItem.Enabled = False

    End Sub

    Private Sub customerLookUpEdit_EditValueChanged(sender As Object, e As EventArgs) Handles customerLookUpEdit.EditValueChanged

        If CType(Me.customerLookUpEdit.EditValue, String) = Me.customerLookUpEdit.Properties.NullText Then
            itemRepositoryItemLookUpEdit.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(Nothing, "RM", True, m_ItemPoolSession)
        Else
            itemRepositoryItemLookUpEdit.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(CType(Me.customerLookUpEdit.EditValue, Integer?), "RM", True, m_ItemPoolSession)
        End If

    End Sub

    Private Sub deleteBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles deleteBarButtonItem.ItemClick

        If MessageBox.Show("Are you sure you want to delete this item pool.", "Delete Item Pool", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        If ItemPoolBLL.DeleteItemPool(m_CurrentPoolID.Oid) <> True Then
            MessageBox.Show("The item pool was not deleted.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Else
            BindPoolSearch()
        End If

    End Sub

    Private Sub deleteRepositoryItemButtonEdit_Click(sender As Object, e As EventArgs) Handles deleteRepositoryItemButtonEdit.Click

        If MessageBox.Show("Are you sure you want to remove this item.", "Delete Pool Detail", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Dim detail As ItemPoolDetails = m_ItemPoolSession.GetObjectByKey(Of ItemPoolDetails)(poolDetailsGridView.GetFocusedRowCellValue(colOid))
        If Not detail Is Nothing Then
            detail.Delete()
            If detail.IsDeleted = False Then
                MessageBox.Show("The item was not removed.")
            Else
                poolDetailsGridView.DeleteRow(poolDetailsGridView.FocusedRowHandle)
            End If
        Else
            poolDetailsGridView.DeleteRow(poolDetailsGridView.FocusedRowHandle)
        End If

    End Sub

    Private Sub editBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles editBarButtonItem.ItemClick

        If m_CurrentPoolID Is Nothing Then
            MessageBox.Show("Please select a item pool to edit.")
            Exit Sub
        End If

        Utilities.MakeFormReadOnly(poolXtraTabPage, False)
        poolDetailsGridView.OptionsBehavior.Editable = True
        poolSearchGridControl.Enabled = False
        CheckPermissions()

        cancelBarButtonItem.Enabled = True
        saveBarButtonItem.Enabled = True
        editBarButtonItem.Enabled = False
        addBarButtonItem.Enabled = False
        deleteBarButtonItem.Enabled = False

    End Sub

    Private Sub ItemPoolXtraForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        XPBaseObject.AutoSaveOnEndEdit = False

    End Sub

    Private Sub ItemPoolXtraForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If poolSearchGridControl.Enabled = False Then
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

        If e.Cancel = False Then
            XPBaseObject.AutoSaveOnEndEdit = True
            m_ItemPoolSession.PurgeDeletedObjects()
        End If

    End Sub

    Private Sub ItemPoolXtraForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        Cursor = Cursors.WaitCursor

        CheckPermissions()
        m_ItemPoolSession = New Session(SPGDataLayer)
        m_ItemPoolSession.TrackPropertiesModifications = True
        m_ItemPoolSession.OptimisticLockingReadBehavior = OptimisticLockingReadBehavior.MergeCollisionThrowException
        poolDetailsXpCollection.Session = m_ItemPoolSession
        poolSearchXpView.Session = m_ItemPoolSession
        itemXpView.Session = m_ItemPoolSession
        customerXpView.Session = m_ItemPoolSession

        BindPoolSearch()

        poolDetailsXpCollection.Criteria = New BinaryOperator(ItemPoolDetails.Fields.ItemPoolID, 0, BinaryOperatorType.Equal)

        Utilities.MakeFormReadOnly(poolXtraTabPage, True)
        poolDetailsGridView.OptionsBehavior.Editable = False
        poolSearchGridControl.Enabled = True

        cancelBarButtonItem.Enabled = False
        saveBarButtonItem.Enabled = False

        Cursor = Cursors.Default

    End Sub

    Private Sub itemRepositoryItemLookUpEdit_Closed(sender As Object, e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles itemRepositoryItemLookUpEdit.Closed

        If e.CloseMode <> PopupCloseMode.Cancel Then
            Dim view As GridView = CType(CType(CType(sender, LookUpEdit).Parent, GridControl).FocusedView, GridView)
            If view.IsNewItemRow(view.FocusedRowHandle) Then
                view.CloseEditor()
                view.UpdateCurrentRow()
            End If
        End If

    End Sub

    Private Sub poolDetailsGridView_CustomUnboundColumnData(sender As Object, e As Views.Base.CustomColumnDataEventArgs) Handles poolDetailsGridView.CustomUnboundColumnData

        If Not IsDBNull(poolDetailsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, itemGridColumn)) AndAlso poolDetailsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, itemGridColumn) IsNot Nothing _
               AndAlso Not IsDBNull(poolDetailsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, itemQtyOnHandGridColumn)) Then
            If e.Column.Name = poolQuantityOnHandGridColumn.Name And e.IsGetData Then
                e.Value = Convert.ToDouble(poolDetailsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, itemQtyOnHandGridColumn)) * (Convert.ToDouble(poolDetailsGridView.GetListSourceRowCellValue(e.ListSourceRowIndex, colItemPoolRatio)))
            End If
        End If

    End Sub

    Private Sub poolDetailsGridView_InitNewRow(sender As Object, e As InitNewRowEventArgs) Handles poolDetailsGridView.InitNewRow

        poolDetailsGridView.SetRowCellValue(e.RowHandle, colPoolID, m_CurrentPoolID.Oid)
        poolDetailsGridView.SetRowCellValue(e.RowHandle, colItemPoolRatio, 1)

    End Sub

    Private Sub poolSearchGridView_Click(sender As Object, e As EventArgs) Handles poolSearchGridView.Click

        If poolSearchGridView.FocusedRowHandle = -999997 Then
            Exit Sub
        End If

        If (poolSearchGridView.CalcHitInfo(poolSearchGridControl.PointToClient(Control.MousePosition)).HitTest = GridHitTest.RowCell) Then
            BindPoolControls(CType(poolSearchGridView.GetFocusedRowCellValue(colPoolID), Integer))
        End If

    End Sub

    Private Sub saveBarButtonItem_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles saveBarButtonItem.ItemClick

        If SaveChanges() Then
            CheckPermissions()

            Utilities.MakeFormReadOnly(poolXtraTabPage, True)
            poolDetailsGridView.OptionsBehavior.Editable = False
            poolSearchGridControl.Enabled = True

            cancelBarButtonItem.Enabled = False
            saveBarButtonItem.Enabled = False
        End If

    End Sub

    Public Sub BindPoolControls(ByVal poolID As Integer)

        m_ItemPoolSession.DropIdentityMap()

        Dim pool As ItemPool = m_ItemPoolSession.GetObjectByKey(Of ItemPool)(poolID, True)
        m_CurrentPoolID = pool
        codeTextEdit.Text = pool.PoolCode
        customerLookUpEdit.EditValue = pool.PoolCustomerID.CustomerID
        customerLookUpEdit.Enabled = False
        descriptionMemoEdit.Text = pool.PoolDescription

        poolDetailsXpCollection.Criteria = New BinaryOperator(ItemPoolDetails.Fields.ItemPoolID, m_CurrentPoolID.Oid, BinaryOperatorType.Equal)

        poolDetailsXpCollection.Reload()

        If CType(Me.customerLookUpEdit.EditValue, String) = Me.customerLookUpEdit.Properties.NullText Then
            itemRepositoryItemLookUpEdit.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(Nothing, "RM", True, m_ItemPoolSession)
        Else
            itemRepositoryItemLookUpEdit.DataSource = ItemsBLL.GetItemCodeAndIDsByTypesAndCustomerID(CType(customerLookUpEdit.EditValue, Integer?), "RM", True, m_ItemPoolSession)
        End If

    End Sub

    Public Sub BindPoolSearch()

        poolSearchXpView.Reload()

    End Sub

    Private Sub CancelChanges()

        If m_CurrentPoolID.Oid <> -1 Then
            BindPoolControls(m_CurrentPoolID.Oid)
        End If

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
                Case "ADD", "Add"
                    Me.addBarButtonItem.Enabled = True
                    Me.editBarButtonItem.Enabled = True
                    Me.deleteBarButtonItem.Enabled = False
                    Me.deleteGridColumn.Visible = False
                Case "NONE", "None"
                    MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Me.Close()
                    Return False
                Case "VIEW", "View"
                    Me.addBarButtonItem.Enabled = False
                    Me.editBarButtonItem.Enabled = False
                    Me.deleteBarButtonItem.Enabled = False
                    Me.deleteGridColumn.Visible = False
                Case "EDIT", "Edit"
                    Me.addBarButtonItem.Enabled = False
                    Me.editBarButtonItem.Enabled = True
                    Me.deleteBarButtonItem.Enabled = False
                    Me.deleteGridColumn.Visible = False
                Case "VIEW ASSIGNED"
                    Me.addBarButtonItem.Enabled = False
                    Me.editBarButtonItem.Enabled = False
                    Me.deleteGridColumn.Visible = False
                    Me.deleteBarButtonItem.Enabled = False
                    FilterAssignedCustomers()
                Case "EDIT ASSIGNED"
                    Me.addBarButtonItem.Enabled = False
                    Me.editBarButtonItem.Enabled = True
                    Me.deleteGridColumn.Visible = False
                    Me.deleteBarButtonItem.Enabled = False
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

        Me.poolSearchXpView.Criteria = New InOperator(ItemPool.Fields.PoolCustomerID.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_ItemPoolSession))

    End Sub

    Private Function SaveChanges() As Boolean

        Dim selectedID As Integer = -1
        If m_CurrentPoolID.Oid = -1 Then

        Else
            selectedID = poolSearchGridView.FocusedRowHandle
        End If

        If ItemPoolBLL.ValidateRecord(Me.codeTextEdit.Text, CType(Me.customerLookUpEdit.EditValue, Integer?)) Then
            m_CurrentPoolID.PoolCode = codeTextEdit.Text
            m_CurrentPoolID.PoolDescription = descriptionMemoEdit.Text
            m_CurrentPoolID.PoolCustomerID = CustomersBLL.GetCustomer(CType(customerLookUpEdit.EditValue, Integer), m_ItemPoolSession)
            m_CurrentPoolID.PoolType = "BP"
        Else
            MessageBox.Show("You must provide a Pool Code, and Customer name before saving the record.")
            Return False
        End If

        Try
            m_CurrentPoolID.Save()
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        'Save the details here
        For Each poolDetail As ItemPoolDetails In poolDetailsXpCollection
            If poolDetail.ItemPoolID Is Nothing OrElse poolDetail.ItemPoolID.Oid = -1 Then
                poolDetail.ItemPoolID = m_CurrentPoolID
            End If
            poolDetail.Save()
        Next

        BindPoolSearch()
        BindPoolControls(m_CurrentPoolID.Oid)
        poolSearchGridView.FocusedRowHandle = selectedID
        Return True

    End Function

End Class