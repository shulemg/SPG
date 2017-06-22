Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class CarriersXtraForm

    Private m_Carriers As CarriersBLL
    Private m_CurrentCarrierID As Nullable(Of Integer)

    Private Sub CarriersXtraForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If Me.carriersSearchGridControl.Enabled = False Then
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

    Private Sub CarriersXtraForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Cursor = Cursors.WaitCursor
        m_Carriers = New CarriersBLL

        BindCarrierSearch()

        CheckPermissions()

        Utilities.MakeFormReadOnly(Me.carriersXtraTabPage, True)
        Me.carriersSearchGridControl.Enabled = True

        cancelBarButtonItem.Enabled = False
        saveBarButtonItem.Enabled = False

        Me.Cursor = Cursors.Default

    End Sub

    Public Sub BindCarrierSearch()

        'Me.carrierListBoxControl.DisplayMember = "CarrierName"
        'Me.carrierListBoxControl.ValueMember = "CarrierID"
        Me.carriersSearchGridControl.DataSource = m_Carriers.GetCarrierIDAndNames()

    End Sub

    Private Function SaveChanges() As Boolean

        'Required to get back to current carrier when entering a new carrier.
        Dim selectedID As Integer = -1

        If m_CurrentCarrierID.HasValue = False Then
            m_CurrentCarrierID = m_Carriers.GetNewCarrierID()
        Else
            selectedID = carriersSearchGridView.FocusedRowHandle
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
            If m_Carriers.UpdateCarrier(m_CurrentCarrierID.Value, Me.nameTextEdit.Text, firstName, lastName, Me.addressTextEdit.Text, Me.cityTextEdit.Text, Me.stateTextEdit.Text, _
                    Me.postalTextEdit.Text, Me.phoneTextEdit.Text, Me.emailTextEdit.Text, Me.faxTextEdit.Text, Me.noteMemoEdit.Text) <> True Then
                MessageBox.Show("The carrier was not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        BindCarrierSearch()
        Me.carriersSearchGridView.FocusedRowHandle = selectedID
        Return True

    End Function

    Private Sub saveSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        SaveChanges()

    End Sub

    Private Sub carrierListBoxControl_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'If Me.carrierListBoxControl.SelectedIndex <> -1 Then
        '    BindCarrierControls(CType(Me.carrierListBoxControl.SelectedValue, Integer))
        'End If

    End Sub

    Public Sub BindCarrierControls(ByVal carrierID As Integer)

        Dim carrier As SPG.CarriersRow

        carrier = CType(m_Carriers.GetCarrierByID(carrierID).Rows(0), SPG.CarriersRow)
        m_CurrentCarrierID = carrier.CarrierID
        Me.nameTextEdit.Text = carrier.CarrierName
        Me.firstNameTextEdit.Text = carrier.ContactFirstName
        Me.lastNameTextEdit.Text = carrier.ContactLastName
        Me.addressTextEdit.Text = carrier.Address
        Me.cityTextEdit.Text = carrier.City
        Me.stateTextEdit.Text = carrier.State
        Me.postalTextEdit.Text = carrier.Postal
        Me.phoneTextEdit.Text = carrier.Phone
        Me.emailTextEdit.Text = carrier.Email
        Me.faxTextEdit.Text = carrier.Fax
        Me.noteMemoEdit.Text = carrier.Note

    End Sub

    Private Sub addSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        m_CurrentCarrierID = Nothing
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

    Private Sub cancelSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'If Me.carrierListBoxControl.SelectedIndex <> -1 Then
        '    BindCarrierControls(CType(Me.carrierListBoxControl.SelectedValue, Integer))
        'End If

    End Sub

    Private Sub carriersSearchGridView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles carriersSearchGridView.Click

        If (Me.carriersSearchGridView.CalcHitInfo(Me.carriersSearchGridControl.PointToClient(Control.MousePosition)).HitTest = GridHitTest.RowCell) Then
            Me.BindCarrierControls(CType(Me.carriersSearchGridView.GetFocusedRowCellValue(Me.carrierIDGridColumn), Integer))
        End If

    End Sub

    Private Sub addBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles addBarButtonItem.ItemClick

        m_CurrentCarrierID = Nothing
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

        Me.carriersSearchGridView.FocusedRowHandle = -1
        Utilities.MakeFormReadOnly(Me.carriersXtraTabPage, False)
        Me.carriersSearchGridControl.Enabled = False
        CheckPermissions()

        Me.cancelBarButtonItem.Enabled = True
        Me.saveBarButtonItem.Enabled = True
        Me.editBarButtonItem.Enabled = False
        Me.addBarButtonItem.Enabled = False

    End Sub

    Private Sub editBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles editBarButtonItem.ItemClick

        If m_CurrentCarrierID Is Nothing Then
            MessageBox.Show("Please select a carrier to edit.")
            Exit Sub
        End If

        Utilities.MakeFormReadOnly(Me.carriersXtraTabPage, False)
        Me.carriersSearchGridControl.Enabled = False
        CheckPermissions()

        Me.cancelBarButtonItem.Enabled = True
        Me.saveBarButtonItem.Enabled = True
        Me.editBarButtonItem.Enabled = False
        Me.addBarButtonItem.Enabled = False

    End Sub

    Private Sub cancelBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cancelBarButtonItem.ItemClick

        CancelChanges()

        CheckPermissions()

        Utilities.MakeFormReadOnly(Me.carriersXtraTabPage, True)
        Me.carriersSearchGridControl.Enabled = True

        cancelBarButtonItem.Enabled = False
        saveBarButtonItem.Enabled = False

    End Sub

    Private Sub saveBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles saveBarButtonItem.ItemClick

        If SaveChanges() Then

            CheckPermissions()

            Utilities.MakeFormReadOnly(Me.carriersXtraTabPage, True)
            Me.carriersSearchGridControl.Enabled = True

            cancelBarButtonItem.Enabled = False
            saveBarButtonItem.Enabled = False
        End If

    End Sub

    Public Function CheckPermissions() As Boolean

        Try
            Dim permission As SPG.UserPermissionsRow = New UserPermissionsBLL().GetUserPermissionsByUserName(My.Settings.UserName, "Carrierss Form")(0)

            Select Case permission.PermissionLevel
                Case "FULL", "Full"
                    Me.addBarButtonItem.Enabled = True
                    Me.editBarButtonItem.Enabled = True
                    'Me.deleteBarButtonItem.Enabled = True
                Case "ADD", "Add"
                    Me.addBarButtonItem.Enabled = True
                    Me.editBarButtonItem.Enabled = True
                Case "NONE", "None"
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
            End Select

            Return True
        Catch ex As InvalidOperationException
            Return False
        End Try

    End Function

    Private Sub CancelChanges()

        If Me.m_CurrentCarrierID IsNot Nothing Then
            BindCarrierControls(m_CurrentCarrierID.Value)
        End If

    End Sub

End Class