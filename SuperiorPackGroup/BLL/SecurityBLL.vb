Imports System
Imports SuperiorPackGroup.SPGTableAdapters
Imports System.Text

<System.ComponentModel.DataObject()> _
Public Class SecurityBLL

    Private m_SecurityTableAdapter As SecurityTableAdapter = Nothing
    Public ReadOnly Property Adapter() As SecurityTableAdapter

        Get
            If m_SecurityTableAdapter Is Nothing Then
                m_SecurityTableAdapter = New SecurityTableAdapter()
                m_SecurityTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return m_SecurityTableAdapter
        End Get

    End Property

    Private m_SecurityDAL As SecurityDAL
    Public ReadOnly Property SecurityDAL() As SecurityDAL

        Get
            If m_SecurityDAL Is Nothing Then
                m_SecurityDAL = New SecurityDAL
            End If
            Return m_SecurityDAL
        End Get

    End Property

    Private Sub UpdateAuditTrail(ByVal ModifiedRecord As SPG.SecurityRow, ByVal originalRecord As Object())

        Dim builder As New StringBuilder(String.Empty)
        Dim recordFields As Integer = (ModifiedRecord.ItemArray.Length - 1)
        Dim i As Integer = 0
        Do While (i <= recordFields)
            Try
                If IsDBNull(originalRecord(i)) Then
                    If Not IsDBNull(ModifiedRecord.Item(i)) Then
                        builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, "NULL", ModifiedRecord.Item(i)))
                    End If
                ElseIf Information.IsDBNull(ModifiedRecord.Item(i)) Then
                    If Not Information.IsDBNull(originalRecord(i)) Then
                        builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, originalRecord(i), "NULL"))
                    End If
                ElseIf ModifiedRecord.Item(i) IsNot originalRecord(i) Then
                    builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, originalRecord(i), ModifiedRecord.Item(i)))
                End If
            Catch
            End Try
            i += 1
        Loop
        If (builder.Length > 2) Then
            builder.Length = (builder.Length - 2)
            AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(ModifiedRecord.Item(0), Integer), "Security", builder.ToString)
        End If

    End Sub

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetSecuritySettingsByUserName(ByVal userName As String) As SPG.SecurityDataTable

        Return Adapter.GetSecuritySettingsByUserName(userName)

    End Function

    <System.ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetSecuritySettingsByUserNameReader(ByVal userName As String) As Data.DataTableReader

        Return SecurityDAL.GetSecuritySettingsByUserName(userName)

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, True)> _
        Public Function UpdateUserPermissions(ByVal name As String, ByVal receivingForm As Boolean, ByVal shippingForm As Boolean, ByVal customersForm As Boolean, _
                ByVal itmesForm As Boolean, ByVal productionForm As Boolean, ByVal costingReports As Boolean, ByVal productionReports As Boolean, _
                ByVal advancedTabs As Boolean, ByVal financialTabs As Boolean) As Boolean

        Dim permissions As SPG.SecurityDataTable = Adapter.GetSecuritySettingsByUserName(name)

        If permissions.Count = 0 Then
            'It is a new Product
            Return Me.InsertUserPermissions(name, receivingForm, shippingForm, customersForm, itmesForm, productionForm, costingReports, productionReports, _
                advancedTabs, financialTabs)
        End If

        Dim userPermissions As SPG.SecurityRow = permissions(0)

        Dim originalRecord As Object() = Nothing
        originalRecord = userPermissions.ItemArray

        userPermissions.ReceivingForm = receivingForm
        userPermissions.ShippingForm = shippingForm
        userPermissions.CustomersForm = customersForm
        userPermissions.ItemsForm = itmesForm
        userPermissions.ProductionForm = productionForm
        userPermissions.CostingReport = costingReports
        userPermissions.ProductionReport = productionReports
        userPermissions.AdvancedTabs = advancedTabs
        userPermissions.FinancialTabs = financialTabs

        If Not IsNothing(originalRecord) Then
            Me.UpdateAuditTrail(userPermissions, originalRecord)
        End If

        Dim rowsAffected As Integer = Adapter.Update(userPermissions)

        Return rowsAffected = 1

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, True)> _
    Public Function InsertUserPermissions(ByVal name As String, ByVal receivingForm As Boolean, ByVal shippingForm As Boolean, ByVal customersForm As Boolean, _
                ByVal itmesForm As Boolean, ByVal productionForm As Boolean, ByVal costingReports As Boolean, ByVal productionReports As Boolean, _
                ByVal advancedTabs As Boolean, ByVal financialTabs As Boolean) As Boolean

        Dim permissions As SPG.SecurityDataTable = New SPG.SecurityDataTable
        Dim userPermissions As SPG.SecurityRow = permissions.NewSecurityRow

        userPermissions.strUser = name
        userPermissions.ReceivingForm = receivingForm
        userPermissions.ShippingForm = shippingForm
        userPermissions.CustomersForm = customersForm
        userPermissions.ItemsForm = itmesForm
        userPermissions.ProductionForm = productionForm
        userPermissions.CostingReport = costingReports
        userPermissions.ProductionReport = productionReports
        userPermissions.AdvancedTabs = advancedTabs
        userPermissions.FinancialTabs = financialTabs

        permissions.AddSecurityRow(userPermissions)
        Dim rowsAffected As Integer = Adapter.Update(permissions)

        Return rowsAffected = 1

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, True)> _
    Public Function DeleteUserPermissions(ByVal name As String) As Boolean

        Dim permissions As SPG.SecurityDataTable = Adapter.GetSecuritySettingsByUserName(name)
        Dim rowsAffected As Integer = 0

        If permissions.Count = 1 Then
            Dim userPermissions As SPG.SecurityRow = CType(permissions.Rows(0), SPG.SecurityRow)
            rowsAffected = Adapter.Delete(name, userPermissions.ts)
        End If

        'Return true if precisely one row was deleted, otherwise return false.
        Return rowsAffected = 1

    End Function

End Class
