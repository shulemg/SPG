﻿Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo

Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As ApplicationServices.StartupEventArgs) Handles Me.Startup

            GetDataLayers()

        End Sub

        Private Sub GetDataLayers()

            SPGDataLayer = Nothing

            Dim connectionString As String = Settings.UserConnectionString
            If DBFunctions.VerifyConnections(connectionString) = False Then
                If DBFunctions.VerifyConnections(Settings.SPGServerName, "SPGData") = True Then
                    connectionString = MSSqlConnectionProvider.GetConnectionString(Settings.SPGServerName, "SPGData")
                    SPGDataLayer = XpoDefault.GetDataLayer(connectionString, AutoCreateOption.SchemaOnly)
                End If
            Else
                SPGDataLayer = XpoDefault.GetDataLayer(connectionString, AutoCreateOption.SchemaOnly)
            End If

            'XpoDefault.Session = Nothing
            'XpoDefault.DataLayer = Nothing

        End Sub

    End Class

End Namespace

