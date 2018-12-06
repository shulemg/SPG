Imports System
Imports System.Data.Sql
Imports System.Collections
Imports DevExpress.XtraEditors

Public Class DatabaseSelectionXtraForm

    Dim m_Servers As ArrayList = New ArrayList()

    Private Sub DatabaseSelectionXtraForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        Me.serversBackgroundWorker.RunWorkerAsync()

    End Sub

    Private Sub refreshSimpleButton_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles refreshSimpleButton.Click

        If Me.serversBackgroundWorker.IsBusy = False Then
            Me.serversBackgroundWorker.RunWorkerAsync()
        End If

    End Sub
    Private Sub FillServerLookUpEdit()

        Me.serverLookUpEdit.Properties.DataSource = m_Servers
        Me.serverLookUpEdit.Properties.ShowHeader = False

    End Sub

    Private Sub logOnRadioGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles logOnRadioGroup.SelectedIndexChanged

        Me.sqlAuthenticationPanelControl.Enabled = (Me.logOnRadioGroup.SelectedIndex = 1)
        FillDatabaseLookupEdit()

    End Sub

    Public Sub FillDatabaseLookupEdit()

        If Me.serverLookUpEdit.EditValue IsNot Nothing Then
            Dim connectionString As String = CreateConnectionString()
            Dim dataBases As ArrayList = Nothing
            If String.IsNullOrEmpty(connectionString) Then
                Exit Sub
            Else
                dataBases = DALUtils.GetDatabases(connectionString)
            End If

            If dataBases Is Nothing Then
                Exit Sub
            End If
            Me.dataBaseLookUpEdit.Properties.DataSource = dataBases
            Me.dataBaseLookUpEdit.Properties.ShowHeader = False
            Me.dataBaseLookUpEdit.Enabled = (dataBases.Count > 0)
            Me.testConnectionSimpleButton.Enabled = (Me.dataBaseLookUpEdit.Enabled)
        End If

    End Sub

    Public Function CreateConnectionString() As String

        If Me.serverLookUpEdit.EditValue Is Nothing Then
            Return Nothing
        End If

        If Me.logOnRadioGroup.SelectedIndex = 0 Then
            Return String.Format("Data Source={0};Integrated Security=True", Me.serverLookUpEdit.EditValue)
        Else
            If String.IsNullOrEmpty(Me.userNameTextEdit.Text) Then
                Return Nothing
            Else
                Return String.Format("Data Source={0};User ID={1};Password={2}", Me.serverLookUpEdit.EditValue, Me.userNameTextEdit.Text, _
                        Me.passwordTextEdit.Text)
            End If
        End If

    End Function

    Private Function CreateFullConnectionString() As String

        If Me.dataBaseLookUpEdit.EditValue Is Nothing Then
            Return Nothing
        End If

        Return String.Format("{0};Initial Catalog={1}", CreateConnectionString(), Me.dataBaseLookUpEdit.EditValue)

    End Function

    Private Sub testConnectionSimpleButton_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles testConnectionSimpleButton.Click

        If Me.dataBaseLookUpEdit.EditValue Is Nothing Then
            MessageBox.Show("Select a database before testing the connection.", "Error Encountered", MessageBoxButtons.OK)
            Exit Sub
        End If

        Dim success As Boolean = DALUtils.TestConnection(CreateFullConnectionString())

        If (success) Then
            MessageBox.Show("Test Succeeded", "Test Connection", MessageBoxButtons.OK)
        Else
            MessageBox.Show("Test Failed", "Test Connection", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub cancelSimpleButton_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles cancelSimpleButton.Click

        Me.Close()

    End Sub

    Private Sub okSimpleButton_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles okSimpleButton.Click

        My.Settings.UserConnectionString = CreateFullConnectionString()
        Me.Close()

    End Sub

    Private Sub serverLookUpEdit_ProcessNewValue(ByVal sender As System.Object, ByVal e As Controls.ProcessNewValueEventArgs) Handles serverLookUpEdit.ProcessNewValue

        Dim edit As Repository.RepositoryItemLookUpEdit = CType(sender, LookUpEdit).Properties
        If e.DisplayValue.ToString = edit.NullText OrElse e.DisplayValue.ToString = String.Empty Then
            Exit Sub
        End If

        m_Servers.Add(e.DisplayValue)
        
        e.Handled = True

    End Sub

    Private Sub serverLookUpEdit_Leave(ByVal sender As System.Object, ByVal e As EventArgs) Handles serverLookUpEdit.Leave

        FillDatabaseLookupEdit()

    End Sub

    Private Sub refreshDatabasesSimpleButton_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles refreshDatabasesSimpleButton.Click

        Me.Cursor = Cursors.WaitCursor
        FillDatabaseLookupEdit()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub serversBackgroundWorker_DoWork(ByVal sender As System.Object, ByVal e As ComponentModel.DoWorkEventArgs) Handles serversBackgroundWorker.DoWork

        m_Servers = DALUtils.GetSQLServers()

    End Sub

    Private Sub serversBackgroundWorker_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As ComponentModel.RunWorkerCompletedEventArgs) Handles serversBackgroundWorker.RunWorkerCompleted

        FillServerLookUpEdit()

    End Sub

End Class