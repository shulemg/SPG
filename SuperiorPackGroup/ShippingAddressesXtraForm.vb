Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class ShippingAddressesXtraForm

    Private m_Address As ShippingAddressBLL
    Private m_CurrentDestinationID As Integer?

    Private Sub ShippingAddressesXtraForm_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing

        If Me.destinationsSearchGridControl.Enabled = False Then
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

    Private Sub ShippingAddressesXtraForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        Me.Cursor = Cursors.WaitCursor
        m_Address = New ShippingAddressBLL

        BindDestinationsSearch()

        CheckPermissions()

        Utilities.MakeFormReadOnly(Me.destinationsPanelControl, True)
        Me.destinationsSearchGridControl.Enabled = True

        cancelBarButtonItem.Enabled = False
        saveBarButtonItem.Enabled = False

        Me.Cursor = Cursors.Default

    End Sub

    Public Sub BindDestinationsSearch()

        'Me.addressesListBoxControl.DisplayMember = "ShippingName"
        'Me.addressesListBoxControl.ValueMember = "AddressID"
        Me.destinationsSearchGridControl.DataSource = m_Address.GetAddressNameAndIDS()

    End Sub

    Private Sub addressesListBoxControl_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)

        'If Me.addressesListBoxControl.SelectedIndex <> -1 Then
        '    BindAddressControls(CType(Me.addressesListBoxControl.SelectedValue, Integer))
        'End If

    End Sub

    Public Sub BindAddressControls(ByVal addressID As Integer)

        Dim address As SPG.ShippingAddressesRow

        address = CType(m_Address.GetAddressByID(addressID).Rows(0), SPG.ShippingAddressesRow)
        m_CurrentDestinationID = address.AddressID
        Me.nameTextEdit.Text = address.ShippingName
        Me.firstNameTextEdit.Text = address.ContactFirstName
        Me.lastNameTextEdit.Text = address.ContactLastName
        Me.addressTextEdit.Text = address.ShippingAddress
        Me.cityTextEdit.Text = address.ShippingCity
        Me.stateTextEdit.Text = address.ShippingState
        Me.postalTextEdit.Text = address.ShippingPostal
        Me.phoneTextEdit.Text = address.ShippingPhone
        Me.emailTextEdit.Text = address.ShippingEmail
        Me.faxTextEdit.Text = address.ShippingFax
        Me.noteMemoEdit.Text = address.ShippingNote

    End Sub

    Private Sub addSimpleButton_Click(ByVal sender As System.Object, ByVal e As EventArgs)

        m_CurrentDestinationID = Nothing
        Me.nameTextEdit.Text = String.Empty
        Me.firstNameTextEdit.Text = Nothing
        Me.lastNameTextEdit.Text = Nothing
        Me.addressTextEdit.Text = String.Empty
        Me.cityTextEdit.Text = String.Empty
        Me.stateTextEdit.Text = String.Empty
        Me.postalTextEdit.Text = String.Empty
        Me.phoneTextEdit.Text = String.Empty
        Me.emailTextEdit.Text = String.Empty
        Me.faxTextEdit.Text = String.Empty
        Me.noteMemoEdit.Text = String.Empty

    End Sub

    Private Sub cancelSimpleButton_Click(ByVal sender As System.Object, ByVal e As EventArgs)

        'If Me.addressesListBoxControl.SelectedIndex <> -1 Then
        '    BindAddressControls(CType(Me.addressesListBoxControl.SelectedValue, Integer))
        'End If

    End Sub

    Private Function SaveChanges() As Boolean

        Dim selectedID As Integer = -1

        If m_CurrentDestinationID.HasValue = False Then
            m_CurrentDestinationID = m_Address.GetNewAddressID()
        Else
            selectedID = destinationsSearchGridView.FocusedRowHandle
        End If

        Try
            Dim firstName, lastName As String
            If Me.firstNameTextEdit.EditValue Is Nothing OrElse Convert.ToString(Me.firstNameTextEdit.EditValue) = Me.firstNameTextEdit.Properties.NullText Then
                firstName = String.Empty
            Else
                firstName = Convert.ToString(Me.firstNameTextEdit.EditValue)
            End If
            If Me.lastNameTextEdit.EditValue Is Nothing OrElse Convert.ToString(Me.lastNameTextEdit.EditValue) = Me.lastNameTextEdit.Properties.NullText Then
                lastName = String.Empty
            Else
                lastName = Convert.ToString(Me.lastNameTextEdit.EditValue)
            End If
            If m_Address.UpdateAddress(m_CurrentDestinationID.Value, Me.nameTextEdit.Text, firstName, lastName, Me.addressTextEdit.Text, Me.cityTextEdit.Text, Me.stateTextEdit.Text, _
                    Me.postalTextEdit.Text, Me.phoneTextEdit.Text, Me.emailTextEdit.Text, Me.faxTextEdit.Text, Me.noteMemoEdit.Text) <> True Then
                MessageBox.Show("The shipping address was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        BindDestinationsSearch()
        Me.destinationsSearchGridView.FocusedRowHandle = selectedID
        Return True

    End Function

    Private Sub saveSimpleButton_Click(ByVal sender As System.Object, ByVal e As EventArgs)

        'Required to get back to current customer when entering a new customer.
        SaveChanges()

    End Sub

    Private Sub destinationsSearchGridView_Click(ByVal sender As Object, ByVal e As EventArgs) Handles destinationsSearchGridView.Click

        If (Me.destinationsSearchGridView.CalcHitInfo(Me.destinationsSearchGridControl.PointToClient(Control.MousePosition)).HitTest = GridHitTest.RowCell) Then
            Me.BindAddressControls(CType(Me.destinationsSearchGridView.GetFocusedRowCellValue(Me.destinationIDGridColumn), Integer))
        End If

    End Sub

    Private Sub addBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles addBarButtonItem.ItemClick

        m_CurrentDestinationID = Nothing
        Me.nameTextEdit.Text = String.Empty
        Me.firstNameTextEdit.Text = Nothing
        Me.lastNameTextEdit.Text = Nothing
        Me.addressTextEdit.Text = String.Empty
        Me.cityTextEdit.Text = String.Empty
        Me.stateTextEdit.Text = String.Empty
        Me.postalTextEdit.Text = String.Empty
        Me.phoneTextEdit.Text = String.Empty
        Me.emailTextEdit.Text = String.Empty
        Me.faxTextEdit.Text = String.Empty
        Me.noteMemoEdit.Text = String.Empty

        Me.destinationsSearchGridView.FocusedRowHandle = -1
        Utilities.MakeFormReadOnly(Me.destinationsPanelControl, False)
        Me.destinationsSearchGridControl.Enabled = False
        CheckPermissions()

        Me.cancelBarButtonItem.Enabled = True
        Me.saveBarButtonItem.Enabled = True
        Me.editBarButtonItem.Enabled = False
        Me.addBarButtonItem.Enabled = False
        'Me.deleteBarButtonItem.Enabled = False

    End Sub

    Private Sub editBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles editBarButtonItem.ItemClick

        If m_CurrentDestinationID Is Nothing Then
            MessageBox.Show("Please select a shipping destination to edit.")
            Exit Sub
        End If

        Utilities.MakeFormReadOnly(Me.destinationsPanelControl, False)
        Me.destinationsSearchGridControl.Enabled = False
        CheckPermissions()

        Me.cancelBarButtonItem.Enabled = True
        Me.saveBarButtonItem.Enabled = True
        Me.editBarButtonItem.Enabled = False
        Me.addBarButtonItem.Enabled = False
        'Me.deleteBarButtonItem.Enabled = False

    End Sub

    Private Sub deleteBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles deleteBarButtonItem.ItemClick

        'If MessageBox.Show("Are you sure you want to delete this destination.", "Delete Destination", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.No Then
        '    Exit Sub
        'End If

        'Try
        '    If m_Address.DeleteDestination(m_CurrentDestinationID.Value) = True Then
        '        BindDestinationsSearch()
        '    Else
        '        MessageBox.Show("The destination was not deleted.")
        '    End If
        'Catch ex As ApplicationException
        '    MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

    End Sub

    Private Sub cancelBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cancelBarButtonItem.ItemClick

        CancelChanges()

        CheckPermissions()

        Utilities.MakeFormReadOnly(Me.destinationsPanelControl, True)
        Me.destinationsSearchGridControl.Enabled = True

        cancelBarButtonItem.Enabled = False
        saveBarButtonItem.Enabled = False

    End Sub

    Private Sub saveBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles saveBarButtonItem.ItemClick

        If SaveChanges() Then

            CheckPermissions()

            Utilities.MakeFormReadOnly(Me.destinationsPanelControl, True)
            Me.destinationsSearchGridControl.Enabled = True

            cancelBarButtonItem.Enabled = False
            saveBarButtonItem.Enabled = False
        End If

    End Sub

    Public Function CheckPermissions() As Boolean

        Try
            Dim permission As SPG.UserPermissionsRow = New UserPermissionsBLL().GetUserPermissionsByUserName(My.Settings.UserName, "Shipping Destinations Form")(0)

            Select Case permission.PermissionLevel
                Case "FULL", "Full"
                    Me.addBarButtonItem.Enabled = True
                    Me.editBarButtonItem.Enabled = True
                    'Me.deleteBarButtonItem.Enabled = True
                Case "ADD", "Add"
                    Me.addBarButtonItem.Enabled = True
                    Me.editBarButtonItem.Enabled = True
                Case "NONE", "None", "VIEW ASSIGNED", "EDIT ASSIGNED"
                    MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Me.Close()
                    Return False
                Case "VIEW", "View"
                    Me.addBarButtonItem.Enabled = False
                    Me.editBarButtonItem.Enabled = False
                    'Me.deleteBarButtonItem.Enabled = False
                Case "EDIT", "Edit"
                    Me.addBarButtonItem.Enabled = False
                    Me.editBarButtonItem.Enabled = True
                    'Me.deleteBarButtonItem.Enabled = False
                Case Else
                    MessageBox.Show("You don't have permission to view this form.", "User Permissions", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Me.Close()
                    Return False
            End Select
            Return True
        Catch ex As InvalidOperationException
            Return False
        End Try

    End Function

    Private Sub CancelChanges()

        If Me.m_CurrentDestinationID IsNot Nothing Then
            BindAddressControls(m_CurrentDestinationID.Value)
        End If

    End Sub

End Class