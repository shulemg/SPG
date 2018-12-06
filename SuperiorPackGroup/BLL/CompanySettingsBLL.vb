Imports SuperiorPackGroup.SPGTableAdapters
Imports System.Text
Imports DXDAL.SPGData
Imports DevExpress.Xpo

Public Class CompanySettingsBLL

    Private Shared m_CompanySettingsTableAdapter As CompanySettingsTableAdapter = Nothing
    Public Shared ReadOnly Property Adapter() As CompanySettingsTableAdapter

        Get
            If m_CompanySettingsTableAdapter Is Nothing Then
                m_CompanySettingsTableAdapter = New CompanySettingsTableAdapter()
                m_CompanySettingsTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return m_CompanySettingsTableAdapter
        End Get

    End Property

    Private changes As New List(Of Change)()

    Private Sub UpdateAuditTrail()

        Dim builder As New StringBuilder(String.Empty)

        For Each update As Change In changes
            builder.Append(String.Format("{0}:{1}({2}); ", update.PropertyName, update.PrevValue, update.NewValue))
        Next

        If (builder.Length > 2) Then
            builder.Length = (builder.Length - 2)
            AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(changes(0).NewValue, Integer), "CompanySettings", builder.ToString)
        End If

        changes.Clear()

    End Sub

    Public Shared Function GetSettings() As CompanySettings

        Try
            Return Session.DefaultSession.GetObjectByKey(Of CompanySettings)(1)
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Shared Function GetDefaultLocation() As Locations

        Try
            Return Session.DefaultSession.GetObjectByKey(Of CompanySettings)(1).DefaultLocation
        Catch
            Return Nothing
        End Try

    End Function

    Public Shared Function GetLPNPrinter() As String

        Try
            Return Session.DefaultSession.GetObjectByKey(Of CompanySettings)(1).LPNPrinterName
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function GetCompanySettings() As SPG.CompanySettingsDataTable

        Return Adapter.GetCompanySettings()

    End Function

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Select, False)> _
    Public Shared Function GetUniversalCustomer() As Integer

        Return Adapter.GetUniversalCustomer().Value

    End Function

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Select, False)> _
    Public Shared Function GetDBVersion() As String

        Return Adapter.GetDBVersion()

    End Function

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Select, False)> _
    Public Shared Function SetDBVersion(ByVal value As String) As Boolean

        Return CBool(Adapter.SetDBVersion(value))

    End Function

    Private Sub SetField(propertyName As String, oldValue As Object, newValue As Object, ByVal settings As CompanySettings)

        If (oldValue IsNot Nothing Or newValue IsNot Nothing) AndAlso
            ((oldValue IsNot Nothing And newValue Is Nothing) OrElse (newValue IsNot Nothing And oldValue Is Nothing) OrElse oldValue.ToString <> newValue.ToString) Then
            settings.SetMemberValue(propertyName, newValue)
            Dim change As New Change() With {.PropertyName = propertyName, .PrevValue = If(oldValue Is Nothing, "<NULL>", oldValue.ToString()), .NewValue = If(newValue Is Nothing, "<NULL>", newValue.ToString())}
            changes.Add(change)
        End If

    End Sub

    <ComponentModel.DataObjectMethod(ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateCompanySettings(ByVal packers As Single?, ByVal operators As Single?, ByVal supers As Single?, ByVal minPerHour As Short?, _
                                          ByVal universalCustomer As Integer?, ByVal lpnPrinter As String, ByVal LPNMoveRight As Byte, ByVal LPNMoveDown As Byte, ByVal LPNCopies As Byte, ByVal Location As Integer?) As Boolean

        Dim settings As CompanySettings = GetSettings()

        If settings Is Nothing Then
            'It is a new Product
            Return False
        End If

        Dim change As Change = New Change() With {.PropertyName = CompanySettings.Fields.PK_ID.PropertyName, .PrevValue = settings.PK_ID.ToString, .NewValue = settings.PK_ID.ToString}
        changes.Add(change)

        SetField(CompanySettings.Fields.dblPackersPay.PropertyName, settings.dblPackersPay, If(packers, 0), settings)
        SetField(CompanySettings.Fields.dblOperatorsPay.PropertyName, settings.dblOperatorsPay, If(operators, 0), settings)
        SetField(CompanySettings.Fields.dblSupersPay.PropertyName, settings.dblSupersPay, If(supers, 0), settings)
        SetField(CompanySettings.Fields.intMinPerHour.PropertyName, settings.intMinPerHour, If(minPerHour, 45), settings)
        SetField(CompanySettings.Fields.UniversalCustomer.PropertyName, settings.UniversalCustomer, If(universalCustomer, 0), settings)
        SetField(CompanySettings.Fields.LPNPrinterName.PropertyName, settings.LPNPrinterName, If(String.IsNullOrEmpty(lpnPrinter), Nothing, lpnPrinter), settings)
        SetField(CompanySettings.Fields.LPNHorizontalAdjustment.PropertyName, settings.LPNHorizontalAdjustment, LPNMoveRight, settings)
        SetField(CompanySettings.Fields.LPNVerticalAdjustment.PropertyName, settings.LPNVerticalAdjustment, LPNMoveDown, settings)
        SetField(CompanySettings.Fields.LPNPrintCopies.PropertyName, settings.LPNPrintCopies, LPNCopies, settings)
        SetField(CompanySettings.Fields.DefaultLocation.PropertyName, settings.DefaultLocation, Session.DefaultSession.GetObjectByKey(Of Locations)(Location), settings)

        Try
            settings.Save()
        Catch ex As Exception
            Return False
        End Try

        UpdateAuditTrail()

        Return True

    End Function

End Class
