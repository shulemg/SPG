Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo.DB.Exceptions
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class DBFunctions

    ''' <summary>
    ''' Initializes a new instance of the DBFunctions class.
    ''' </summary>
    Private Sub New()
    End Sub

    Public Shared Function VerifyConnections(ByVal ServerName As String, ByVal DBName As String) As Boolean

        Try
            DevExpress.Xpo.XpoDefault.GetDataLayer(MSSqlConnectionProvider.GetConnectionString(ServerName, DBName), AutoCreateOption.None)
        Catch ex As UnableToOpenDatabaseException
            Return False
        End Try

        Return True

    End Function

    Public Shared Function VerifyConnections(ByVal ConnectionString As String) As Boolean

        Try
            DevExpress.Xpo.XpoDefault.GetDataLayer(ConnectionString, AutoCreateOption.None)
        Catch ex As UnableToOpenDatabaseException
            Return False
        End Try

        Return True

    End Function

    Public Shared Sub CreateDatabase(ByVal ServerName As String, ByVal DBName As String)

        DevExpress.Xpo.XpoDefault.GetDataLayer(MSSqlConnectionProvider.GetConnectionString(ServerName, DBName), AutoCreateOption.DatabaseAndSchema)
        
    End Sub

    Public Shared Function GetSQLServers() As ArrayList

        Dim dataSources As DataTable = SqlDataSourceEnumerator.Instance.GetDataSources
        Dim serverNames As New ArrayList

        Try
            For Each server As DataRow In dataSources.Rows
                If (String.IsNullOrEmpty(server.Item("InstanceName").ToString) OrElse String.Compare(server.Item("InstanceName").ToString, "MSSQLSERVER", False) = 0) Then
                    serverNames.Add(server.Item("ServerName").ToString)
                Else
                    serverNames.Add((String.Format("{0}\{1}", server.Item("ServerName"), server.Item("InstanceName"))))
                End If
            Next
        Catch

        End Try

        Return serverNames

    End Function

    Public Shared Function GetDatabases(ByVal serverName As String) As ArrayList

        If String.IsNullOrEmpty(serverName) Then
            Return Nothing
        End If

        Using selectConnection As New SqlConnection(serverName)
            Using adapter As New SqlDataAdapter("sp_helpdb", selectConnection)
                Using dataSet As New DataSet()
                    Dim databases As New ArrayList()
                    Try
                        adapter.Fill(dataSet)
                        Try
                            For Each database As DataRow In dataSet.Tables.Item(0).Rows
                                databases.Add(database.Item("Name").ToString)
                            Next
                        Catch
                        End Try
                        databases = databases
                    Catch
                        databases = Nothing
                    End Try
                    Return databases
                End Using
            End Using
        End Using

    End Function

End Class

