Imports System
Imports SuperiorPackGroup.SPGTableAdapters
Imports System.Text
Imports DXDAL.SPGData

<System.ComponentModel.DataObject()> _
Public Class UserPermissionsBLL

    Private m_UserPermissionsTableAdapter As UserPermissionsTableAdapter = Nothing
    Public ReadOnly Property Adapter() As UserPermissionsTableAdapter

        Get
            If m_UserPermissionsTableAdapter Is Nothing Then
                m_UserPermissionsTableAdapter = New UserPermissionsTableAdapter()
                m_UserPermissionsTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            End If
            Return m_UserPermissionsTableAdapter
        End Get

    End Property

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetUserPermissionsByUserName(ByVal userName As String, ByVal permissionObject As String) As SPG.UserPermissionsDataTable

        Return Adapter.GetUserPermissionsByUserName(userName, permissionObject)

    End Function

    Private Sub UpdateAuditTrail(ByVal ModifiedRecord As SPG.UserPermissionsRow, ByVal originalRecord As Object())

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
            AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(ModifiedRecord.Item(0), Integer), "UserPermissions", builder.ToString)
        End If
    End Sub

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateUserPermissions(ByVal UserPermissionID As Nullable(Of Integer), ByVal PermissionObject As String, ByVal PermissionLevel As String, ByVal UserName As String) As Boolean

        Dim permissions As SPG.UserPermissionsDataTable = Adapter.GetUserPermissionByID(UserPermissionID.Value)

        If permissions.Count = 0 Then
            'It is a new record
            Return Me.InsertUserPermissions(PermissionObject, PermissionLevel, UserName)
        End If

        Dim userPermissions As SPG.UserPermissionsRow = permissions(0)

        Dim originalRecord As Object() = Nothing
        originalRecord = userPermissions.ItemArray

        userPermissions.PermissionObject = PermissionObject
        userPermissions.PermissionLevel = PermissionLevel
        userPermissions.UserName = UserName

        Dim rowsAffected As Integer = Adapter.Update(userPermissions)

        If Not IsNothing(originalRecord) Then
            Me.UpdateAuditTrail(userPermissions, originalRecord)
        End If

        Return rowsAffected = 1

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, True)> _
    Public Function InsertUserPermissions(ByVal PermissionObject As String, ByVal PermissionLevel As String, ByVal UserName As String) As Boolean

        Dim permissions As SPG.UserPermissionsDataTable = New SPG.UserPermissionsDataTable
        Dim userPermissions As SPG.UserPermissionsRow = permissions.NewUserPermissionsRow

        userPermissions.UserName = UserName
        userPermissions.PermissionObject = PermissionObject
        userPermissions.PermissionLevel = PermissionLevel

        permissions.AddUserPermissionsRow(userPermissions)
        Dim rowsAffected As Integer = Adapter.Update(permissions)

        Return rowsAffected = 1

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, True)> _
    Public Function DeleteUserPermissions(ByVal userPermissionID As Integer) As Boolean

        Dim permissions As SPG.UserPermissionsDataTable = Adapter.GetUserPermissionByID(userPermissionID)
        Dim rowsAffected As Integer = 0

        If permissions.Count = 1 Then
            Dim userPermissions As SPG.UserPermissionsRow = CType(permissions.Rows(0), SPG.UserPermissionsRow)
            rowsAffected = Adapter.Delete(userPermissionID, userPermissions.ts)
        End If

        'Return true if precisely one row was deleted, otherwise return false.
        Return rowsAffected = 1

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, True)> _
    Public Function DeleteUserPermissions(ByVal username As String) As Boolean


        Dim rowsAffected As Integer = Adapter.DeletePermissionByUser(username)

        Return rowsAffected <> 0

    End Function

    Public Function GetPermissionObjects() As ArrayList

        Dim permissionObjects As New ArrayList
        Try
            Dim row As SPG.UserPermissionsRow
            For Each row In Me.Adapter.GetUserPermissions
                Dim permissionObject As String = row.PermissionObject
                If Not permissionObjects.Contains(permissionObject) Then
                    permissionObjects.Add(permissionObject)
                End If
            Next
        Finally

        End Try
        Return permissionObjects

    End Function

    Public Function CreateNewUserPermissions(ByVal UserName As String) As Boolean

        Return Convert.ToBoolean(Adapter.CreateNewUserPermissions(UserName))

    End Function

    

End Class
