Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars
Imports System
Imports DevExpress.Xpo
Imports System.Deployment.Application

Public Class MainXtraForm

    Private WithEvents m_timer As New Timer
    Private m_UserPermissions As UserPermissionsBLL
    Protected m_CompanySettings As CompanySettingsBLL
    Private m_AdvancedTabs As String = "NONE"
    Private m_FinancialTabs As String = "NONE"
    Private m_GeneralReports As String = "NONE"
    Private m_FinancialReports As String = "NONE"
    Private m_MinPerHour As Integer? = Nothing
    Private m_OperatorsPay As Single? = Nothing
    Private m_SupersPay As Single? = Nothing
    Private m_PackersPay As Single? = Nothing
    Private m_VersionNumber As Integer? = Nothing

    Private Sub fileExitBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles fileExitBarButtonItem.ItemClick

        Application.Exit()

    End Sub

    Private Sub listsCustomerBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles listsCustomerBarButtonItem.ItemClick, mainToolbarCustomersBarLargeButtonItem.ItemClick

        With CustomersXtraForm
            .MdiParent = Me
            If .CheckPermissions = False Then
                Exit Sub
            End If
            .Show()
            .Activate()
        End With

    End Sub

    Private Sub listsItemBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles listsItemBarButtonItem.ItemClick, mainToolbarItemBarLargeButtonItem.ItemClick

        With ItemsXtraForm
            .MdiParent = Me
            .AdvancedTabs = Me.AdvancedTabs
            If .CheckPermissions = False Then
                Exit Sub
            End If
            .Show()
            .Activate()
        End With

    End Sub

    Private Sub listsMachineBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles listsMachineBarButtonItem.ItemClick

        With MachineLinesXtraForm
            .MdiParent = Me
            If .CheckPermissions = False Then
                Exit Sub
            End If
            .Show()
            .Activate()
        End With

    End Sub

    Private Sub listsShiftsBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles listsShiftsBarButtonItem.ItemClick

        With ShiftsXtraForm
            .MdiParent = Me
            If .CheckPermissions = False Then
                Exit Sub
            End If
            .Show()
            .Activate()
        End With

    End Sub

    Private Sub listsCarriersBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles listsCarriersBarButtonItem.ItemClick

        With CarriersXtraForm
            .MdiParent = Me
            If .CheckPermissions = False Then
                Exit Sub
            End If
            .Show()
            .Activate()
        End With

    End Sub

    Private Sub activitesRecieveBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles activitesRecieveBarButtonItem.ItemClick, mainToolbarReceiveBarLargeButtonItem.ItemClick

        With ReceivingXtraForm
            .MdiParent = Me
            If .CheckPermissions = False Then
                Exit Sub
            End If
            .Show()
            .Activate()
            '.WindowState = FormWindowState.Maximized
        End With

    End Sub

    Private Sub activitiesProductionBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles activitiesProductionBarButtonItem.ItemClick, mainToolbarProductionBarLargeButtonItem.ItemClick

        With ProductionXtraForm
            .MdiParent = Me
            If .CheckPermissions = False Then
                Exit Sub
            End If
            .Show()
            .Activate()
        End With

    End Sub

    Private Sub activitesShipBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles activitesShipBarButtonItem.ItemClick, mainToolbarShipBarLargeButtonItem.ItemClick

        With ShippingXtraForm
            .MdiParent = Me
            If .CheckPermissions = False Then
                Exit Sub
            End If
            .Show()
            .Activate()
        End With

    End Sub

    Private Sub productionDetailBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles productionDetailBarButtonItem.ItemClick

        Dim reportForm As ReportsXtraForm = New ReportsXtraForm()

        With reportForm
            .MdiParent = Me
            .Text = "Production Detail Report"
            .SelectedReport("ProductionDetailXtraReport")
            .Show()
            .Activate()
        End With

    End Sub

    '    Private Sub productionSummaryBarButtonItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles productionSummaryBarButtonItem.ItemClick
    '
    '        Dim reportForm As ReportsXtraForm = New ReportsXtraForm
    '
    '        With reportForm
    '            .MdiParent = Me
    '            .Text = "Production Summary Report"
    '            .Show()
    '            .SelectedReport("ProductionSummaryXtraReport")
    '        End With
    '
    '    End Sub
    '
    '    Private Sub costingDetailBarButtonItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles costingDetailBarButtonItem.ItemClick
    '
    '        Dim reportForm As ReportsXtraForm = New ReportsXtraForm
    '
    '        With reportForm
    '            .MdiParent = Me
    '            .Text = "Costing Details Report"
    '            .Show()
    '            .SelectedReport("CostingDetailXtraReport")
    '        End With
    '
    '    End Sub
    '
    '    Private Sub costingDetailFullBarButtonItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles costingDetailFullBarButtonItem.ItemClick
    '
    '        Dim reportForm As ReportsXtraForm = New ReportsXtraForm
    '
    '        With reportForm
    '            .MdiParent = Me
    '            .Text = "Costing Details Full Report"
    '            .Show()
    '            .SelectedReport("CostingDetailFullXtraReport")
    '        End With
    '
    '    End Sub
    '
    '    Private Sub costingSummaryBarButtonItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles costingSummaryBarButtonItem.ItemClick
    '
    '        Dim reportForm As ReportsXtraForm = New ReportsXtraForm
    '
    '        With reportForm
    '            .MdiParent = Me
    '            .Text = "Costing Summary Report"
    '            .Show()
    '            .SelectedReport("CostingSummaryXtraReport")
    '        End With
    '
    '    End Sub
    '
    '    Private Sub costingFinancialBarButtonItem_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles costingFinancialBarButtonItem.ItemClick
    '
    '        Dim reportForm As ReportsXtraForm = New ReportsXtraForm
    '
    '        With reportForm
    '            .MdiParent = Me
    '            .Text = "Financial Costing Report"
    '            .Show()
    '            .SelectedReport("FinancialCostingXtraReport")
    '        End With
    '
    '    End Sub

    Private Sub toolsOptionsBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles toolsOptionsBarButtonItem.ItemClick

        With SettingsXtraForm
            .FinancialTabs = Me.FinancialTabs
            .ShowDialog()
        End With

    End Sub

    Private Sub toolsSecurityBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles toolsSecurityBarButtonItem.ItemClick

        With SecurityXtraForm
            .MdiParent = Me
            If .CheckPermissions = False Then
                Exit Sub
            End If
            .Show()
            .Activate()
        End With

    End Sub

    Private Sub windowCascadeBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles windowCascadeBarButtonItem.ItemClick

        Me.LayoutMdi(MdiLayout.Cascade)

    End Sub

    Private Sub windowVerticalBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles windowVerticalBarButtonItem.ItemClick

        Me.LayoutMdi(MdiLayout.TileVertical)

    End Sub

    Private Sub windowHorizontalBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles windowHorizontalBarButtonItem.ItemClick

        Me.LayoutMdi(MdiLayout.TileHorizontal)

    End Sub

    Private Sub windowCloseBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles windowCloseBarButtonItem.ItemClick

        For Each childForm As XtraForm In Me.MdiChildren
            childForm.Close()
        Next

    End Sub

    Private Sub windowArrangeBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles windowArrangeBarButtonItem.ItemClick

        Me.LayoutMdi(MdiLayout.ArrangeIcons)

    End Sub

    Private Sub MainXtraForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        m_timer.Interval = CInt(TimeSpan.FromHours(1).TotalMilliseconds)
        m_timer.Start()

        TestConnection()

        Try
            m_VersionNumber = ApplicationDeployment.CurrentDeployment.CurrentVersion.Revision

            Text = String.Format("Superior Pack Group - Test (Ver. {0})", ApplicationDeployment.CurrentDeployment.CurrentVersion)
        Catch
        End Try

        If LoginXtraForm.ShowDialog() <> Windows.Forms.DialogResult.OK Then Application.Exit()
        DisplaySecuredMenuItems()

    End Sub

    Private Sub TimerEventProcessor(myObject As Object,
                                           ByVal myEventArgs As EventArgs) _
                                       Handles m_timer.Tick
        Try
            If ApplicationDeployment.CurrentDeployment.CurrentVersion.Revision < Session.DefaultSession.GetObjectByKey(Of DXDAL.SPGData.LatestVersion)(1).LatestRevision Then
                MessageBox.Show("A new version is available please update.", "Please restart", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch
        End Try
    End Sub

    Private Sub TestConnection()

        If My.Settings.UserConnectionString Is Nothing Then
            My.Settings.UserConnectionString = My.Settings.SPGDataDefaultConnectionString
        End If

        If Not (DALUtils.TestConnection) Then
            MessageBox.Show("Please select your Database", "Database Connection", MessageBoxButtons.OK)
            DatabaseSelectionXtraForm.ShowDialog()
        End If

    End Sub

    Private Sub DisplaySecuredMenuItems()

        If My.Settings.UserSecurityLevel = "Admin" Then
            m_AdvancedTabs = "FULL"
            m_FinancialTabs = "FULL"
            m_GeneralReports = "FULL"
            m_FinancialReports = "FULL"
        End If

        If Not My.Settings.UserSecurityLevel = "Admin" Then
            Try
                m_UserPermissions = New UserPermissionsBLL
                If m_UserPermissions.GetUserPermissionsByUserName(My.Settings.UserName, "Security Settings")(0).PermissionLevel = "NONE" Then _
                        Me.toolsSecurityBarButtonItem.Visibility = BarItemVisibility.Never
                If m_UserPermissions.GetUserPermissionsByUserName(My.Settings.UserName, "Items Form")(0).PermissionLevel = "NONE" Then
                    Me.listsItemBarButtonItem.Visibility = BarItemVisibility.Never
                    Me.mainToolbarItemBarLargeButtonItem.Visibility = BarItemVisibility.Never
                End If
                If m_UserPermissions.GetUserPermissionsByUserName(My.Settings.UserName, "Production Form")(0).PermissionLevel = "NONE" Then
                    Me.activitiesProductionBarButtonItem.Visibility = BarItemVisibility.Never
                    Me.mainToolbarProductionBarLargeButtonItem.Visibility = BarItemVisibility.Never
                End If
                If m_UserPermissions.GetUserPermissionsByUserName(My.Settings.UserName, "Customers Form")(0).PermissionLevel = "NONE" Then
                    Me.listsCustomerBarButtonItem.Visibility = BarItemVisibility.Never
                    Me.mainToolbarCustomersBarLargeButtonItem.Visibility = BarItemVisibility.Never
                End If
                If m_UserPermissions.GetUserPermissionsByUserName(My.Settings.UserName, "Shipping Form")(0).PermissionLevel = "NONE" Then
                    Me.activitesShipBarButtonItem.Visibility = BarItemVisibility.Never
                    Me.mainToolbarShipBarLargeButtonItem.Visibility = BarItemVisibility.Never
                End If
                If m_UserPermissions.GetUserPermissionsByUserName(My.Settings.UserName, "Receiving Form")(0).PermissionLevel = "NONE" Then
                    Me.activitesRecieveBarButtonItem.Visibility = BarItemVisibility.Never
                    Me.mainToolbarReceiveBarLargeButtonItem.Visibility = BarItemVisibility.Never
                End If
                m_AdvancedTabs = m_UserPermissions.GetUserPermissionsByUserName(My.Settings.UserName, "Advanced Tabs")(0).PermissionLevel
                m_FinancialTabs = m_UserPermissions.GetUserPermissionsByUserName(My.Settings.UserName, "Financial Tabs")(0).PermissionLevel
                m_GeneralReports = m_UserPermissions.GetUserPermissionsByUserName(My.Settings.UserName, "General Reports")(0).PermissionLevel
                m_FinancialReports = m_UserPermissions.GetUserPermissionsByUserName(My.Settings.UserName, "Financial Reports")(0).PermissionLevel
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error Encountered", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If

    End Sub

    Public ReadOnly Property AdvancedTabs() As String

        Get
            Return m_AdvancedTabs
        End Get

    End Property

    Public ReadOnly Property FinancialTabs() As String

        Get
            Return m_FinancialTabs
        End Get

    End Property

    Public ReadOnly Property GeneralReports() As String

        Get
            Return m_GeneralReports
        End Get

    End Property

    Public ReadOnly Property FinancialReports() As String

        Get
            Return m_FinancialReports
        End Get

    End Property

    Private Sub FillCompanySettings()

        If m_CompanySettings Is Nothing Then
            Dim settings As SPG.CompanySettingsRow
            m_CompanySettings = New CompanySettingsBLL
            settings = CType(m_CompanySettings.GetCompanySettings.Rows(0), SPG.CompanySettingsRow)
            m_MinPerHour = settings.intMinPerHour
            m_OperatorsPay = settings.dblOperatorsPay
            m_SupersPay = settings.dblSupersPay
            m_PackersPay = settings.dblPackersPay
        End If

    End Sub

    Public ReadOnly Property MinPerHOur() As Integer

        Get
            FillCompanySettings()

            If m_MinPerHour.HasValue = False Then
                m_MinPerHour = 50
            End If

            Return m_MinPerHour.Value

        End Get

    End Property

    Public ReadOnly Property OperatorsPay() As Single

        Get
            FillCompanySettings()

            If m_OperatorsPay.HasValue = False Then
                m_OperatorsPay = 10
            End If

            Return m_OperatorsPay.Value
        End Get

    End Property

    Public ReadOnly Property PackersPay() As Single

        Get
            FillCompanySettings()

            If m_PackersPay.HasValue = False Then
                m_PackersPay = 10
            End If

            Return m_PackersPay.Value
        End Get

    End Property

    Public ReadOnly Property SupersPay() As Single

        Get
            FillCompanySettings()

            If m_SupersPay.HasValue = False Then
                m_SupersPay = 10
            End If

            Return m_SupersPay.Value
        End Get

    End Property

    Private Sub databaseBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles databaseBarButtonItem.ItemClick

        With DatabaseSelectionXtraForm
            .ShowDialog()
        End With

    End Sub

    Private Sub listsAddressesBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles listsAddressesBarButtonItem.ItemClick, mainToolbarAddressesBarLargeButtonItem.ItemClick

        With ShippingAddressesXtraForm
            .MdiParent = Me
            If .CheckPermissions = False Then
                Exit Sub
            End If
            .Show()
            .Activate()
        End With

    End Sub

    Private Sub listsInventoryBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles listsInventoryBarButtonItem.ItemClick, mainToolbarInventoryBarLargeButtonItem.ItemClick

        With InventoryXtraForm
            .MdiParent = Me
            If .CheckPermissions = False Then
                Exit Sub
            End If
            .Show()
            .Activate()
        End With

    End Sub

    Private Sub inventoryAdjustmentBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles inventoryAdjustmentBarButtonItem.ItemClick,
                                                                                                                                            mainToolbarInventoryAdjustmentBarLargeButtonItem.ItemClick

        With InventoryAdjustmentXtraForm
            .MdiParent = Me
            If .CheckPermissions = False Then
                Exit Sub
            End If
            .Show()
            .Activate()
        End With

    End Sub

    Private Sub reportsBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles reportsBarButtonItem.ItemClick

        With QuickReportsXtraForm
            .MdiParent = Me
            .Show()
            .FillReports(Nothing)
            .Activate()
        End With

    End Sub

    Private Sub listVendorsBarButtonItem_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles listVendorsBarButtonItem.ItemClick

        With VendorsXtraForm
            .MdiParent = Me
            If .CheckPermissions = False Then
                Exit Sub
            End If
            .Show()
            .Activate()
        End With

    End Sub

    Private Sub listsEmployeesBarButtonItem_ItemClick(sender As Object, e As ItemClickEventArgs) Handles listsEmployeesBarButtonItem.ItemClick

        With employeesXtraForm
            .MdiParent = Me
            If .CheckPermissions = False Then
                Exit Sub
            End If
            .Show()
            .Activate()
        End With

    End Sub

    Private Sub listsShipmentConditionsBarButtonItem_ItemClick(sender As Object, e As ItemClickEventArgs) Handles listsShipmentConditionsBarButtonItem.ItemClick

        With shipmentConditionXtraForm
            .MdiParent = Me
            If .CheckPermissions = False Then
                Exit Sub
            End If
            .Show()
            .Activate()
        End With

    End Sub

    Private Sub mainToolBarItemPoolBarLargeButtonItem_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mainToolBarItemPoolBarLargeButtonItem.ItemClick, listsItemPoolBarButtonItem.ItemClick

        With ItemPoolXtraForm
            .MdiParent = Me
            If .CheckPermissions = False Then
                Exit Sub
            End If
            .Show()
            .Activate()
        End With

    End Sub

    Private Sub MainXtraForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Try
            Session.DefaultSession.PurgeDeletedObjects()
        Catch

        End Try

    End Sub

    Private Sub LocationsBarButtonItem_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mainToolbarLocationsBarLargeButtonItem.ItemClick, listLocationsBarButtonItem.ItemClick

        With LocationXtraForm
            .MdiParent = Me
            If .CheckPermissions = False Then
                Exit Sub
            End If
            .Show()
            .Activate()
        End With

    End Sub

    Private Sub activitiesLocationTransferBarButtonItem_ItemClick(sender As Object, e As ItemClickEventArgs) Handles activitiesLocationTransferBarButtonItem.ItemClick, mainToolbarLocationTransferBarLargeButtonItem.ItemClick

        With LocationTransfersXtraForm
            .MdiParent = Me
            If .CheckPermissions = False Then
                Exit Sub
            End If
            .Show()
            .Activate()
        End With

    End Sub

    Private Sub activitiesProjectsBarButtomItem_ItemClick(sender As Object, e As ItemClickEventArgs) Handles activitiesProjectsBarButtonItem.ItemClick, mainToolbarProjectsBarLargeButtonItem.ItemClick

        With ProjectsXtraForm
            .MdiParent = Me
            If .CheckPermissions = False Then
                Exit Sub
            End If
            .Show()
            .Activate()
        End With

    End Sub

    Private Sub mainToolbarScheduleBarLargeButtonItem_ItemClick(sender As Object, e As ItemClickEventArgs) Handles mainToolbarScheduleBarLargeButtonItem.ItemClick, activitiesScheduleBarButtonItem.ItemClick

        With ProjectSchedulingXtraForm
            .MdiParent = Me
            If .CheckPermissions = False Then
                Exit Sub
            End If
            .Show()
            .Activate()
        End With

    End Sub

    Private Sub lotCodeFormatsBarButtonItem_ItemClick(sender As Object, e As ItemClickEventArgs) Handles lotCodeFormatsBarButtonItem.ItemClick

        With LotCodeFormatsXtraForm
            .MdiParent = Me
            If .CheckPermissions = False Then
                Exit Sub
            End If
            .Show()
            .Activate()
        End With

    End Sub

    Private Sub reasonCodesBarButtonItem_ItemClick(sender As Object, e As ItemClickEventArgs) Handles reasonCodesBarButtonItem.ItemClick

        With ReasonCodesXtraForm
            .MdiParent = Me
            If .CheckPermissions = False Then
                Exit Sub 
            End If
            .Show
            .Activate
        End With

    End Sub

End Class