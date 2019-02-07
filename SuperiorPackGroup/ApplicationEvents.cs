//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using DevExpress.Xpo.DB;
using DevExpress.Xpo;
using SuperiorPackGroup.Properties;

namespace SuperiorPackGroup
{
	namespace My
	{

		// The following events are available for MyApplication:
		// 
		// Startup: Raised when the application starts, before the startup form is created.
		// Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
		// UnhandledException: Raised if the application encounters an unhandled exception.
		// StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
		// NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
		internal partial class MyApplication : Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
		{

			private void MyApplication_Startup(object sender, Microsoft.VisualBasic.ApplicationServices.StartupEventArgs e)
			{

				GetDataLayers();

			}

			private void GetDataLayers()
			{

				MyDataLayers.SPGDataLayer = null;

				string connectionString = Settings.Default.UserConnectionString;
				if (DBFunctions.VerifyConnections(connectionString) == false)
				{
					if (DBFunctions.VerifyConnections(Settings.Default.SPGServerName, "SPGData") == true)
					{
						connectionString = MSSqlConnectionProvider.GetConnectionString(Settings.Default.SPGServerName, "SPGData");
						MyDataLayers.SPGDataLayer = XpoDefault.GetDataLayer(connectionString, AutoCreateOption.SchemaOnly);
					}
				}
				else
				{
					MyDataLayers.SPGDataLayer = XpoDefault.GetDataLayer(connectionString, AutoCreateOption.SchemaOnly);
				}

				//XpoDefault.Session = Nothing
				//XpoDefault.DataLayer = Nothing

			}


			private static MyApplication MyApp;
			internal static MyApplication Application
			{
				get
				{
					return MyApp;
				}
			}

			[STAThread]
			static void Main(string[] args)
			{
				MyApp = new MyApplication();
				MyApp.Run(args);
			}


//INSTANT C# NOTE: Converted event handler wireups:
			private bool EventsSubscribed = false;
			private void SubscribeToEvents()
			{
				if (EventsSubscribed)
					return;
				else
					EventsSubscribed = true;

				this.Startup += MyApplication_Startup;
			}

            protected override void OnCreateMainForm()
            {
                this.MainForm = new MainXtraForm();
                //base.OnCreateMainForm();
            }

        }

	}


}