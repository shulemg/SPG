Imports DevExpress.XtraEditors
Imports DXDAL.SPGData

Public Class SettingsXtraForm

    Private m_Settings As CompanySettingsBLL

    Private Sub SettingsXtraForm_Load(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

        If Me.FinancialTabs = "NONE" OrElse Me.FinancialTabs = "EDIT ASSIGNED" OrElse Me.FinancialTabs = "VIEW ASSIGNED" Then
            MessageBox.Show("You don't have permission to view this form.", "Access Denied", MessageBoxButtons.OK)
            Me.Close()
            Exit Sub
        End If

        m_Settings = New CompanySettingsBLL
        BindSettingControls()

        Me.customerLookUpEdit.Properties.DataSource = New CustomersBLL().GetCustomerNameAndIDS(False)
        Me.customerLookUpEdit.Properties.Columns.Add(New Controls.LookUpColumnInfo)
        Me.customerLookUpEdit.Properties.Columns(0).Caption = "Customer Name"
        Me.customerLookUpEdit.Properties.Columns(0).FieldName = "CustomerName"
        Me.customerLookUpEdit.Properties.DisplayMember = "CustomerName"
        Me.customerLookUpEdit.Properties.ValueMember = "CustomerID"

    End Sub

    Private m_FinancialTabs As String
    Public Property FinancialTabs() As String

        Get
            Return m_FinancialTabs
        End Get

        Set(ByVal Value As String)
            m_FinancialTabs = Value
        End Set

    End Property

    Public Sub BindSettingControls()

        Dim companySettings As CompanySettings = CompanySettingsBLL.GetSettings
        packersTextEdit.EditValue = companySettings.dblPackersPay
        operatorsTextEdit.EditValue = companySettings.dblOperatorsPay
        supersTextEdit.EditValue = companySettings.dblSupersPay
        minutesTextEdit.EditValue = companySettings.intMinPerHour
        customerLookUpEdit.EditValue = companySettings.UniversalCustomer
        LPNPrinterTextEdit.EditValue = companySettings.LPNPrinterName
        LPNMoveRightTextEdit.EditValue = companySettings.LPNHorizontalAdjustment
        LPNMoveDownTextEdit.EditValue = companySettings.LPNVerticalAdjustment
        LPNCopiesTextEdit.EditValue = companySettings.LPNPrintCopies
        locationLookUpEdit.EditValue = companySettings.DefaultLocation.Oid

    End Sub

    Private Sub payTextEditParseEditValue(ByVal sender As System.Object, ByVal e As Controls.ConvertEditValueEventArgs) Handles packersTextEdit.ParseEditValue, operatorsTextEdit.ParseEditValue, supersTextEdit.ParseEditValue

        If e.Value Is Nothing Then
            e.Value = Double.Parse(e.Value.ToString)
        End If

    End Sub

    Private Sub saveSimpleButton_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles saveSimpleButton.Click

        Try
            If m_Settings.UpdateCompanySettings(Utilities.ChangeType(Of Single?)(Me.packersTextEdit.EditValue), Utilities.ChangeType(Of Single?)(Me.operatorsTextEdit.EditValue), _
                                                Utilities.ChangeType(Of Single?)(Me.supersTextEdit.EditValue), Utilities.ChangeType(Of Short?)(Me.minutesTextEdit.EditValue), _
                                                Utilities.ChangeType(Of Integer?)(Me.customerLookUpEdit.EditValue), CType(LPNPrinterTextEdit.EditValue, String), CType(LPNMoveRightTextEdit.EditValue, Byte),
                                                CType(LPNMoveDownTextEdit.EditValue, Byte), CType(LPNCopiesTextEdit.EditValue, Byte), Utilities.ChangeType(Of Integer?)(locationLookUpEdit.EditValue)) <> True Then
                MessageBox.Show("The settings were not updated succesfully.", "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As ApplicationException
            MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

    End Sub

    Private Sub cancelSimpleButton_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles cancelSimpleButton.Click

        BindSettingControls()

    End Sub

    Private Sub SetUpBreakTimesSimpleButton_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles SetUpBreakTimesSimpleButton.Click

        With BreakTimeXtraForm
            .ShowDialog()
        End With

    End Sub

End Class