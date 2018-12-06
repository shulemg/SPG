Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Collections.Specialized
Imports DevExpress.Xpo
Imports DXDAL.SPGData

Public Class DALUtils

    Public Shared Function TestConnection() As Boolean

        Return TestConnection(Nothing)

    End Function

    Public Shared Function TestConnection(ByVal connectionString As String) As Boolean

        If String.IsNullOrEmpty(connectionString) Then
            If String.IsNullOrEmpty(My.Settings.UserConnectionString) Then
                Return False
            Else
                connectionString = My.Settings.UserConnectionString
            End If
        End If

        Dim conn As SqlConnection = New SqlConnection(connectionString)

        Try
            conn.Open()
            If Session.DefaultSession.IsConnected Then
                Session.DefaultSession.Disconnect()
            End If
            Session.DefaultSession.ConnectionString = connectionString
            Session.DefaultSession.AutoCreateOption = DB.AutoCreateOption.SchemaOnly
            Session.DefaultSession.UpdateSchema(Reflection.Assembly.GetAssembly(GetType(LatestVersion)))
            SPGDataLayer = XpoDefault.GetDataLayer(connectionString, DB.AutoCreateOption.SchemaOnly)
            Return True
        Catch ex As Exception
            Return False
        Finally
            conn.Close()
        End Try

    End Function

    Public Shared Function GetSQLServers() As ArrayList

        Dim sqlSource As SqlDataSourceEnumerator = SqlDataSourceEnumerator.Instance
        Dim dt As DataTable = sqlSource.GetDataSources()
        Dim serverList As ArrayList = New ArrayList()

        For Each dr As DataRow In dt.Rows
            If String.IsNullOrEmpty(dr("InstanceName").ToString) OrElse String.Compare(dr("InstanceName").ToString, "MSSQLSERVER") = 0 Then
                serverList.Add(dr("ServerName").ToString())
            Else
                serverList.Add(String.Format("{0}\{1}", dr("ServerName").ToString(), dr("InstanceName").ToString()))
            End If
        Next

        Return serverList

    End Function

    Public Shared Function GetDatabases(ByVal connectionString As String) As ArrayList

        If String.IsNullOrEmpty(connectionString) Then
            If String.IsNullOrEmpty(My.Settings.UserConnectionString) Then
                Return Nothing
            Else
                connectionString = My.Settings.UserConnectionString
            End If
        End If

        Dim conn As SqlConnection = New SqlConnection(connectionString)
        Dim da As SqlDataAdapter = New SqlDataAdapter("sp_helpdb", conn)
        Dim ds As DataSet = New DataSet()
        Dim dataBaseList As ArrayList = New ArrayList()
        Try
            da.Fill(ds)

            For Each dr As DataRow In ds.Tables(0).Rows
                dataBaseList.Add(dr("Name").ToString())
            Next

            Return dataBaseList
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try

    End Function

End Class
