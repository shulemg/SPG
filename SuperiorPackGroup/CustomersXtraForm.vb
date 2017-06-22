Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Data.Filtering
Imports DXDAL.SPGData
Imports DevExpress.Xpo

Public Class CustomersXtraForm

    Protected m_Customer As CustomersBLL
    Protected m_CustomersItems As ItemsBLL
    Protected m_Receiving As ReceivingsBLL
    Protected m_ReceivingDetails As ReceivingDetailsBLL
    Protected m_Production As ProductionBLL
    Protected m_Shippings As ShippingsBLL
    Protected m_UserPermissions As UserPermissionsBLL
    Private m_CurrentCustomer As Nullable(Of Integer)
    Private m_CustomersSession As Session

    Private Sub CustomersXtraForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Me.customerSearchGridControl.Enabled = False Then
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

    Private Sub CustomersXtraForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Cursor = Cursors.WaitCursor
        m_Customer = New CustomersBLL
        m_CustomersItems = New ItemsBLL
        m_Receiving = New ReceivingsBLL
        m_ReceivingDetails = New ReceivingDetailsBLL
        m_Production = New ProductionBLL
        m_Shippings = New ShippingsBLL
        m_UserPermissions = New UserPermissionsBLL

        m_CustomersSession = New Session(SPGDataLayer)
        m_CustomersSession.TrackPropertiesModifications = True
        m_CustomersSession.OptimisticLockingReadBehavior = OptimisticLockingReadBehavior.MergeCollisionThrowException

        CheckPermissions()

        For i As Integer = 0 To components.Components.Count - 1
            If TypeOf (components.Components(i)) Is XPView Then
                CType(components.Components(i), XPView).Session = m_CustomersSession
            ElseIf TypeOf (components.Components(i)) Is XPCollection Then
                CType(components.Components(i), XPCollection).Session = m_CustomersSession
            End If
        Next i

        BindCustomerSearch()
        customerShiftsXpCollection.Criteria = New BinaryOperator(CustomerShifts.Fields.Customer, Nothing, BinaryOperatorType.Equal)
        customerPlantsXpCollection.Criteria = New BinaryOperator(CustomerPlants.Fields.Customer, Nothing, BinaryOperatorType.Equal)

        Utilities.MakeFormReadOnly(Me.generalXtraTabPage, True)
        addRelatedCustomerGroupControl.Enabled = False
        customerPlantsGridView.OptionsBehavior.Editable = False
        customerShiftsGridView.OptionsBehavior.Editable = False
        deleteGridColumn.Visible = False
        deleteCustomerPlantGridColumn.Visible = False
        deleteCustomerShiftGridColumn.Visible = False
        Me.customerSearchGridControl.Enabled = True

        Cursor = Cursors.Default

    End Sub

    Public Sub BindCustomerSearch()

        If inactiveSearchCheckEdit.Checked = False Then
            customerSearchXPView.Criteria = New BinaryOperator(Customers.Fields.Inactive.PropertyName, False, BinaryOperatorType.Equal)
        Else
            customerSearchXPView.Criteria = Nothing
        End If

        customerSearchXPView.Reload()
        customersXpView.Reload()

    End Sub

    Public Sub BindCustomersControls(ByVal customerID As Integer)

        m_CustomersSession.DropIdentityMap()

        Dim customer As Customers = CustomersBLL.GetCustomer(customerID, m_CustomersSession)
        m_CurrentCustomer = customer.CustomerID
        nameTextEdit.Text = customer.CustomerName
        contactTextEdit.Text = customer.CustomerContact
        phoneTextEdit.Text = customer.CustomerPhone
        emailTextEdit.Text = customer.CustomerEmail
        faxTextEdit.Text = customer.CustomerFax
        noteMemoEdit.Text = customer.CustomerNote
        addressTextEdit.Text = customer.Address
        cityTextEdit.Text = customer.City
        stateTextEdit.Text = customer.State
        postalTextEdit.Text = customer.ZipCode
        inactiveCheckEdit.Checked = customer.Inactive
        lpnPrefixTextEdit.Text = customer.LPNPrefix
        firstLPNNumberTextEdit.EditValue = customer.FirstLPNNumber
        lastLPNNumberTextEdit.EditValue = customer.LastLPNNumber
        plantCodeTextEdit.EditValue = customer.PlantCode
        lpnGroupControl.Text = String.Format("LPN Settings - Next LPN Number: {0}", customer.NextLPNNumber)
        expirationDateFormatComboBox.EditValue = customer.ExpirationDateFormat
        If customer.DefaultLotCodeFormat IsNot Nothing Then
            lotCodeFormatLookUpEdit.EditValue = customer.DefaultLotCodeFormat.Oid
        Else
            lotCodeFormatLookUpEdit.EditValue = Nothing
        End If

        customerItemsXpCollection.Criteria = New GroupOperator(GroupOperatorType.And, New BinaryOperator(Items.Fields.ItemCustomerID.CustomerID.PropertyName, m_CurrentCustomer.Value, BinaryOperatorType.Equal),
                                                                                New BinaryOperator(Items.Fields.ItemType.PropertyName, "FG", BinaryOperatorType.Equal),
                                                                                New BinaryOperator(Items.Fields.Inactive.PropertyName, False, BinaryOperatorType.Equal))
        relatedCustomerXpCollection.Criteria = New BinaryOperator(RelatedCustomer.Fields.MainCustomer.PropertyName, CustomersBLL.GetCustomer(m_CurrentCustomer.Value, m_CustomersSession), BinaryOperatorType.Equal)
        customerPlantsXpCollection.Criteria = New BinaryOperator(CustomerPlants.Fields.Customer.CustomerID.PropertyName, m_CurrentCustomer.Value, BinaryOperatorType.Equal)
        customerShiftsXpCollection.Criteria = New BinaryOperator(CustomerShifts.Fields.Customer.CustomerID.PropertyName, m_CurrentCustomer.value, BinaryOperatorType.Equal)

        customerItemsXpCollection.Reload
        relatedCustomerXpCollection.Reload
        customerPlantsXpCollection.Reload
        customerShiftsXpCollection.Reload
        
    End Sub

    Private Function SaveChanges() As Boolean

        Dim selectedID As Integer = -1
        'Required to get back to current customer when entering a new customer.
        If m_CurrentCustomer.HasValue = False Then
            m_CurrentCustomer = m_Customer.GetNewCustomerID()
        Else
            selectedID = customerSearchGridView.FocusedRowHandle
        End If

        Try
            If m_Customer.UpdateCustomer(m_CurrentCustomer.Value, Me.nameTextEdit.Text, Me.contactTextEdit.Text, Convert.ToString(Me.phoneTextEdit.EditValue), Me.emailTextEdit.Text,
                                         Convert.ToString(Me.faxTextEdit.EditValue), Me.noteMemoEdit.Text, Convert.ToString(addressTextEdit.EditValue), Convert.ToString(cityTextEdit.EditValue),
                                         Convert.ToString(stateTextEdit.EditValue), Convert.ToString(postalTextEdit.EditValue), inactiveCheckEdit.Checked, Convert.ToString(lpnPrefixTextEdit.EditValue),
                                         Utilities.ChangeType(Of Integer?)(firstLPNNumberTextEdit.EditValue), Utilities.ChangeType(Of Integer?)(lastLPNNumberTextEdit.EditValue),
                                         Convert.ToString(plantCodeTextEdit.EditValue), Convert.ToString(expirationDateFormatComboBox.EditValue), Utilities.ChangeType(Of Integer?)(lotCodeFormatLookUpEdit.EditValue), m_CustomersSession) <> True Then
                MessageBox.Show("The customer was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If

            For Each customerShift As CustomerShifts In customerShiftsXpCollection
                If customerShift.Customer Is Nothing OrElse customerShift.Customer.CustomerID = -1 Then
                   customerShift.Customer = m_CustomersSession.GetObjectByKey(Of Customers)(m_CurrentCustomer.Value)
                End If
                customerShift.Save
            Next

            For Each customerPlant As CustomerPlants In customerPlantsXpCollection
                If customerPlant.Customer Is Nothing OrElse customerPlant.Customer.CustomerID = -1 Then
                   customerPlant.Customer = m_CustomersSession.GetObjectByKey(Of Customers)(m_CurrentCustomer.Value)
                End If
                customerPlant.Save
            Next

            BindCustomerSearch()
            BindCustomersControls(m_CurrentCustomer.Value)
            If selectedID <> -1 Then
                Me.customerSearchGridView.FocusedRowHandle = selectedID
            End If
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True

    End Function

    Public Function CheckPermissions() As Boolean

        Try
            Dim permission As SPG.UserPermissionsRow = New UserPermissionsBLL().GetUserPermissionsByUserName(My.Settings.UserName, "Customers Form")(0)

            Select Case permission.PermissionLevel
                Case "FULL", "Full"
                    Me.addBarButtonItem.Enabled = True
                    Me.editBarButtonItem.Enabled = True
                    Me.deleteBarButtonItem.Enabled = True
                    Me.deleteGridColumn.Visible = True
                    deleteGridColumn.VisibleIndex = 0
                    deleteCustomerPlantGridColumn.Visible = True
                    deleteCustomerPlantGridColumn.VisibleIndex = 0
                    deleteCustomerShiftGridColumn.Visible = True
                    deleteCustomerShiftGridColumn.VisibleIndex = 0
                Case "ADD", "Add"
                    Me.addBarButtonItem.Enabled = True
                    Me.editBarButtonItem.Enabled = True
                    Me.deleteBarButtonItem.Enabled = False
                    Me.deleteGridColumn.Visible = False
                    deleteCustomerPlantGridColumn.Visible = False
                    deleteCustomerShiftGridColumn.Visible = False
                Case "NONE", "None"
                    MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Me.Close()
                    Return False
                Case "VIEW", "View"
                    Me.addBarButtonItem.Enabled = False
                    Me.editBarButtonItem.Enabled = False
                    Me.deleteBarButtonItem.Enabled = False
                    Me.deleteGridColumn.Visible = False
                    deleteCustomerPlantGridColumn.Visible = False
                    deleteCustomerShiftGridColumn.Visible = False
                Case "EDIT", "Edit"
                    Me.addBarButtonItem.Enabled = False
                    Me.editBarButtonItem.Enabled = True
                    Me.deleteBarButtonItem.Enabled = False
                    Me.deleteGridColumn.Visible = False
                    deleteCustomerPlantGridColumn.Visible = False
                    deleteCustomerShiftGridColumn.Visible = False
                Case "VIEW ASSIGNED"
                    Me.addBarButtonItem.Enabled = False
                    Me.editBarButtonItem.Enabled = False
                    Me.deleteBarButtonItem.Enabled = False
                    Me.deleteGridColumn.Visible = False
                    deleteCustomerPlantGridColumn.Visible = False
                    deleteCustomerShiftGridColumn.Visible = False
                    FilterAssignedCustomers()
                Case "EDIT ASSIGNED"
                    Me.addBarButtonItem.Enabled = False
                    Me.editBarButtonItem.Enabled = True
                    Me.deleteBarButtonItem.Enabled = False
                    Me.deleteGridColumn.Visible = False
                    deleteCustomerPlantGridColumn.Visible = False
                    deleteCustomerShiftGridColumn.Visible = False
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

        Me.customerSearchXPView.Criteria = New InOperator(Customers.Fields.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_CustomersSession))
        Me.customersXpView.Criteria = New InOperator(Customers.Fields.CustomerID.PropertyName, UsersCustomerBLL.GetAssignedCustomers(m_CustomersSession))

    End Sub

    Private Sub customerSearchGridView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles customerSearchGridView.Click

        If (Me.customerSearchGridView.CalcHitInfo(Me.customerSearchGridControl.PointToClient(Control.MousePosition)).HitTest = GridHitTest.RowCell) Then
            Me.BindCustomersControls(CType(Me.customerSearchGridView.GetFocusedRowCellValue(Me.customerIDGridColumn), Integer))
        End If

    End Sub

    Private Sub saveBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles saveBarButtonItem.ItemClick

        If SaveChanges() Then
            Utilities.MakeFormReadOnly(Me.generalXtraTabPage, True)
            customerPlantsGridView.OptionsBehavior.Editable = False
            customerShiftsGridView.OptionsBehavior.Editable = False
            Me.customerSearchGridControl.Enabled = True

            CheckPermissions()
            cancelBarButtonItem.Enabled = False
            saveBarButtonItem.Enabled = False
            deleteGridColumn.Visible = False
            addRelatedCustomerGroupControl.Enabled = False
        End If

    End Sub

    Private Sub addBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles addBarButtonItem.ItemClick

        m_CurrentCustomer = Nothing
        nameTextEdit.Text = Nothing
        contactTextEdit.Text = Nothing
        phoneTextEdit.Text = Nothing
        emailTextEdit.Text = Nothing
        faxTextEdit.Text = Nothing
        noteMemoEdit.Text = Nothing
        addressTextEdit.Text = Nothing
        cityTextEdit.Text = Nothing
        stateTextEdit.Text = Nothing
        postalTextEdit.Text = Nothing
        inactiveCheckEdit.Checked = False
        lpnPrefixTextEdit.EditValue = Nothing
        firstLPNNumberTextEdit.EditValue = Nothing
        lastLPNNumberTextEdit.EditValue = Nothing
        plantCodeTextEdit.EditValue = Nothing
        lpnGroupControl.Text = "LPN Settings"
        expirationDateFormatComboBox.EditValue = Nothing
        lotCodeFormatLookUpEdit.EditValue = Nothing

        customerShiftsXpCollection.Criteria = New BinaryOperator(CustomerShifts.Fields.Customer.CustomerID, -1, BinaryOperatorType.Equal)
        customerPlantsXpCollection.Criteria = New BinaryOperator(CustomerPlants.Fields.Customer.CustomerID, -1, BinaryOperatorType.Equal)
        customerShiftsXpCollection.Reload
        customerPlantsXpCollection.Reload 

        Utilities.MakeFormReadOnly(Me.generalXtraTabPage, False)
        customerShiftsGridView.OptionsBehavior.Editable = True
        customerPlantsGridView.OptionsBehavior.Editable = True
        Me.customerSearchGridControl.Enabled = False
        CheckPermissions()

        Me.cancelBarButtonItem.Enabled = True
        Me.saveBarButtonItem.Enabled = True
        Me.editBarButtonItem.Enabled = False
        Me.addBarButtonItem.Enabled = False
        Me.deleteBarButtonItem.Enabled = False
        Me.deleteGridColumn.Visible = False
        deleteCustomerPlantGridColumn.Visible = False
        deleteCustomerShiftGridColumn.Visible = False
        Me.addRelatedCustomerGroupControl.Enabled = False

    End Sub

    Private Sub CancelChanges()

        If Me.m_CurrentCustomer.HasValue Then
            BindCustomersControls(m_CurrentCustomer.Value)
            m_Customer.EndedEdit(m_CurrentCustomer.Value)
        End If

    End Sub

    Private Sub cancelBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cancelBarButtonItem.ItemClick

        CancelChanges()

        Utilities.MakeFormReadOnly(Me.generalXtraTabPage, True)
        customerShiftsGridView.OptionsBehavior.Editable = False
        customerPlantsGridView.OptionsBehavior.Editable = False
        Me.customerSearchGridControl.Enabled = True
        Me.addRelatedCustomerGroupControl.Enabled = False

        CheckPermissions()
        cancelBarButtonItem.Enabled = False
        saveBarButtonItem.Enabled = False
        deleteGridColumn.Visible = False

    End Sub

    Private Sub deleteBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles deleteBarButtonItem.ItemClick

        If MessageBox.Show("Are you sure you want to delete this customer.", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        Try
            If m_Customer.DeleteCustomer(m_CurrentCustomer.Value, m_CustomersSession) = True Then
                RelatedCustomerBLL.DeleteRelatedCustomers(CustomersBLL.GetCustomer(m_CurrentCustomer.Value, m_CustomersSession))
                BindCustomerSearch()
            Else
                MessageBox.Show("The customer was not deleted.")
            End If
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub deleteCustomerPlantRepositoryItemButtonEdit_Click(sender As Object, e As EventArgs) Handles deleteCustomerPlantRepositoryItemButtonEdit.Click

        If MessageBox.Show("Are you sure you want to delete this plant?", "Delete Customer Plant", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = DialogResult.No Then
            Exit Sub
        End If

        Dim plant As CustomerPlants = m_CustomersSession.GetObjectByKey(Of CustomerPlants)(customerPlantsGridView.GetFocusedRowCellValue(colOid))
        If plant Is Nothing Then
            customerPlantsGridView.DeleteRow(customerPlantsGridView.FocusedRowHandle)
        Else
            plant.Delete
            If plant.IsDeleted Then
                customerPlantsGridView.DeleteRow(customerPlantsGridView.FocusedRowHandle)
            Else
                MessageBox.Show("The customer plant couldn't be deleted.")
            End If
        End If

    End Sub

    Private Sub deleteCustomerShiftRepositoryItemButtonEdit_Click(sender As Object, e As EventArgs) Handles deleteCustomerShiftRepositoryItemButtonEdit.Click

        If MessageBox.Show("Are you sure you want to delete this shift?", "Delete Customer Shift", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = DialogResult.No Then
            Exit Sub
        End If

        Dim shift As CustomerShifts = m_CustomersSession.GetObjectByKey(Of CustomerShifts)(customerShiftsGridView.GetFocusedRowCellValue(colOid))
        If shift Is Nothing Then
            customerShiftsGridView.DeleteRow(customerShiftsGridView.FocusedRowHandle)
        Else
            shift.Delete
            If shift.IsDeleted Then
                customerShiftsGridView.DeleteRow(customerShiftsGridView.FocusedRowHandle)
            Else
                MessageBox.Show("The customer shift couldn't be deleted.")
            End If
        End If

    End Sub

    Private Sub editBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles editBarButtonItem.ItemClick

        If m_CurrentCustomer Is Nothing Then
            MessageBox.Show("Please select a customer to edit.")
            Exit Sub
        End If

        If m_Customer.AllowEdit(m_CurrentCustomer.Value) = False Then
            MessageBox.Show("Someone else is editing now this customer.", "Customer in use", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If

        Utilities.MakeFormReadOnly(Me.generalXtraTabPage, False)
        customerPlantsGridView.OptionsBehavior.Editable = True
        customerShiftsGridView.OptionsBehavior.Editable = True
        Me.customerSearchGridControl.Enabled = False
        addRelatedCustomerGroupControl.Enabled = True
        CheckPermissions()

        Me.cancelBarButtonItem.Enabled = True
        Me.saveBarButtonItem.Enabled = True
        Me.editBarButtonItem.Enabled = False
        Me.addBarButtonItem.Enabled = False
        deleteGridColumn.Visible = deleteBarButtonItem.Enabled
        deleteGridColumn.VisibleIndex = 0
        Me.deleteBarButtonItem.Enabled = False

    End Sub

    Private Sub inactiveSearchCheckEdit_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles inactiveSearchCheckEdit.CheckedChanged

        BindCustomerSearch()

    End Sub

    Private Sub reportsBarButtonItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles reportsBarButtonItem.ItemClick

        Dim reportsForm As QuickReportsXtraForm = New QuickReportsXtraForm
        
        reportsForm.Text = "Customer Reports"
        'reportsForm.Parent = Me.ParentForm
        reportsForm.Show()
        reportsForm.FillReports("Customers")

    End Sub

    Private Sub addOneWaySimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addOneWaySimpleButton.Click

        If RelatedCustomerBLL.AddRelatedCustomer(CustomersBLL.GetCustomer(m_CurrentCustomer.Value, m_CustomersSession), CustomersBLL.GetCustomer(CInt(relatedCustomerLookUpEdit.EditValue), m_CustomersSession), False) = False Then
            MessageBox.Show("There was a problem while adding the related customer")
        End If

        relatedCustomerXpCollection.Reload()

    End Sub

    Private Sub addBothWaysSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addBothWaysSimpleButton.Click

        If RelatedCustomerBLL.AddRelatedCustomer(CustomersBLL.GetCustomer(m_CurrentCustomer.Value, m_CustomersSession), CustomersBLL.GetCustomer(CInt(relatedCustomerLookUpEdit.EditValue), m_CustomersSession), True) = False Then
            MessageBox.Show("There was a problem while adding the related customer")
        End If

        relatedCustomerXpCollection.Reload()

    End Sub

    Private Sub deleteRepositoryItemButtonEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles deleteRepositoryItemButtonEdit.Click

        If MessageBox.Show("Are you sure you want to delete this relationshiP?", "Delete Related Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            Exit Sub
        End If

        If RelatedCustomerBLL.DeleteRelatedCustomer(m_CustomersSession.GetObjectByKey(Of RelatedCustomer)(relatedCustomersGridView.GetFocusedRowCellValue(Me.idGridColumn))) Then
            MessageBox.Show("The customer relationship was successfully deleted.")
        Else
            MessageBox.Show("There was a problem while deleting the related customer")
        End If

    End Sub

    Private Sub resetLPNSimpleButton_Click(sender As Object, e As EventArgs) Handles resetLPNSimpleButton.Click

        Try
            Dim customer As Customers = CustomersBLL.GetCustomer(m_CurrentCustomer.Value, m_CustomersSession)
            customer.NextLPNNumber = CInt(firstLPNNumberTextEdit.EditValue)
            customer.Save()
        Catch
            MessageBox.Show("The LPN labels were not reset.")
        End Try

    End Sub

End Class