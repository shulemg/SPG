Imports SuperiorPackGroup.SPGTableAdapters
Imports System.Text
Imports DXDAL.SPGData
Imports DevExpress.Xpo

<System.ComponentModel.DataObject()> _
Public Class UsersBLL

    Private m_UsersTableAdapter As UsersTableAdapter
    Private changes As New List(Of Change)()

    Public ReadOnly Property Adapter() As UsersTableAdapter

        Get
            If m_UsersTableAdapter IsNot Nothing Then
                Return m_UsersTableAdapter
            End If

            m_UsersTableAdapter = New UsersTableAdapter()
            m_UsersTableAdapter.Connection.ConnectionString = My.Settings.UserConnectionString
            Return m_UsersTableAdapter
        End Get

    End Property

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetUserSecurityLevel(ByVal userName As String, ByVal password As String) As String

        If String.Compare(password, GetUserPassword(userName), False) <> 0 Then
            Return Nothing
        End If

        Return Adapter.GetUserSecurityLevel(userName, password)

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function GetUsers() As SPG.UsersDataTable

        Return Adapter.GetUsers()

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function GetUserPassword(ByVal userName As String) As String

        Return Adapter.GetUserPassword(userName)

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Shared Function GetUserByName(ByVal session As Session, ByVal userName As String) As Users

        Return session.GetObjectByKey(Of Users)(userName)

    End Function

    Public Shared Function GetUsersLocalLocation(ByVal session As Session, ByVal UserName As String) As Locations

        Dim localLocation As Locations = GetUserByName(session, UserName).DefaultLocation

        If localLocation Is Nothing Then
            Return CompanySettingsBLL.GetDefaultLocation()
        Else
            Return localLocation
        End If

    End Function

    Private Sub SetField(propertyName As String, oldValue As Object, newValue As Object, ByVal user As Users)

        If (oldValue IsNot Nothing Or newValue IsNot Nothing) AndAlso
            ((oldValue IsNot Nothing And newValue Is Nothing) OrElse (newValue IsNot Nothing And oldValue Is Nothing) OrElse oldValue.ToString <> newValue.ToString) Then
            user.SetMemberValue(propertyName, newValue)
            Dim change As New Change() With {.PropertyName = propertyName, .PrevValue = If(oldValue Is Nothing, "<NULL>", oldValue.ToString()), .NewValue = If(newValue Is Nothing, "<NULL>", newValue.ToString())}
            changes.Add(change)
        End If

    End Sub

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateUser(ByVal name As String, ByVal password As String, ByVal confirm As String, ByVal defaultLocation As Locations) As Boolean

        If String.IsNullOrEmpty(name) Then
            Throw New ApplicationException("You must provide a User Name.")
        End If

        If String.IsNullOrEmpty(password) Then
            Throw New ApplicationException("You must provide a User Password.")
        End If

        If String.IsNullOrEmpty(confirm) Then
            Throw New ApplicationException("Please confirm the password.")
        End If

        If String.Compare(password, confirm, False) <> 0 Then
            Throw New ApplicationException("The passwords do not match.")
        End If

        Dim user As Users = Session.DefaultSession.GetObjectByKey(Of Users)(name)

        If user Is Nothing Then
            'It is a new user
            Return InsertUser(name, password, defaultLocation)
        End If

        'Dim originalRecord As Object() = user.ItemArray

        Dim change As Change = New Change() With {.PropertyName = Users.Fields.strUserName.PropertyName, .PrevValue = user.strUserName, .NewValue = user.strUserName}
        changes.Add(change)

        SetField(Users.Fields.strPassword.PropertyName, user.strPassword, password, user)
        SetField(Users.Fields.DefaultLocation.PropertyName, user.DefaultLocation, defaultLocation, user)

        'user.strPassword = password

        'If Not IsNothing(originalRecord) Then
        '    UpdateAuditTrail(user, originalRecord)
        'End If

        'Return Adapter.Update(user) = 1


        Try
            user.Save()
        Catch ex As Exception
            Return False
        End Try

        UpdateAuditTrail()

        Return True

    End Function

    Private Sub UpdateAuditTrail()
        'Private Sub UpdateAuditTrail(ByVal ModifiedRecord As SPG.UsersRow, ByVal originalRecord As Object())

        Dim builder As New StringBuilder(String.Empty)

        For Each update As Change In changes
            builder.Append(String.Format("{0}:{1}({2}); ", update.PropertyName, update.PrevValue, update.NewValue))
        Next

        If (builder.Length > 2) Then
            builder.Length = (builder.Length - 2)
            AuditTrailBLL.AddTrailEntry(My.Settings.UserName, 0, "Users", builder.ToString)
        End If

        changes.Clear()


        'Dim builder As New StringBuilder(String.Empty)
        'Dim i As Integer = 0
        'Do While (i <= (ModifiedRecord.Table.Columns.Count - 1))
        '    Try
        '        If IsDBNull(originalRecord(i)) Then
        '            If Not IsDBNull(ModifiedRecord.Item(i)) Then
        '                builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, "NULL", ModifiedRecord.Item(i)))
        '            End If
        '        ElseIf Information.IsDBNull(ModifiedRecord.Item(i)) Then
        '            If Not Information.IsDBNull(originalRecord(i)) Then
        '                builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, originalRecord(i), "NULL"))
        '            End If
        '        ElseIf CStr(ModifiedRecord.Item(i)) <> CStr(originalRecord(i)) Then
        '            builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, originalRecord(i), ModifiedRecord.Item(i)))
        '        End If
        '    Catch
        '        Continue Do
        '    Finally
        '        i += 1
        '    End Try
        'Loop
        'If builder.Length <= 2 Then
        '    Return
        'End If

        'builder.Length = (builder.Length - 2)
        'AuditTrailBLL.AddTrailEntry(My.Settings.UserName, 0, "Users", builder.ToString)

    End Sub

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, True)> _
    Public Function InsertUser(ByVal name As String, ByVal password As String, ByVal defaultLocation As Locations) As Boolean

        Dim change As Change = New Change() With {.PropertyName = Users.Fields.strUserName.PropertyName, .PrevValue = "<NULL>", .NewValue = name}
        changes.Add(change)

        Dim user As Users = New Users(Session.DefaultSession) With {.strUserName = name}
        SetField(Users.Fields.strPassword.PropertyName, user.strPassword, password, user)
        SetField(Users.Fields.DefaultLocation.PropertyName, user.DefaultLocation, defaultLocation, user)
        SetField(Users.Fields.strSecurityLevel.PropertyName, user.strSecurityLevel, "User", user)

        Try
            user.Save()
            If New UserPermissionsBLL().CreateNewUserPermissions(name) = False Then
                Throw New ApplicationException("The permissions were not created succesfuly.")
            End If
        Catch ex As Exception
            Return False
        End Try

        Return True

        'Using users As SPG.UsersDataTable = New SPG.UsersDataTable()
        '    Dim user As SPG.UsersRow = users.NewUsersRow
        '    user.strUserName = name
        '    user.strPassword = password
        '    user.strSecurityLevel = "User"
        '    users.AddUsersRow(user)
        '    Dim rowsAffected As Integer = Adapter.Update(users)
        '    If rowsAffected = 1 Then
        '        If New UserPermissionsBLL().CreateNewUserPermissions(name) = False Then
        '            Throw New ApplicationException("The permissions were not created succesfuly.")
        '        End If
        '    End If
        '    Return rowsAffected = 1
        'End Using

    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, True)> _
    Public Function DeleteUser(ByVal name As String) As Boolean

        Dim users As SPG.UsersDataTable = Adapter.GetUserByName(name)
        Dim rowsAffected As Integer = 0

        If users.Count = 1 Then
            Dim user As SPG.UsersRow = CType(users.Rows(0), SPG.UsersRow)
            rowsAffected = Adapter.Delete(name, user.ts)
        End If

        'Return true if precisely one row was deleted, otherwise return false.
        Return rowsAffected = 1

    End Function

End Class
