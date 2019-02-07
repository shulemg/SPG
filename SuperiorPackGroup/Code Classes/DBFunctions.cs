//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using DevExpress.Xpo.DB;
using DevExpress.Xpo.DB.Exceptions;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SuperiorPackGroup
{
	public class DBFunctions
	{

		/// <summary>
		/// Initializes a new instance of the DBFunctions class.
		/// </summary>
		private DBFunctions()
		{
		}

		public static bool VerifyConnections(string ServerName, string DBName)
		{

			try
			{
				DevExpress.Xpo.XpoDefault.GetDataLayer(MSSqlConnectionProvider.GetConnectionString(ServerName, DBName), AutoCreateOption.None);
			}
			catch (UnableToOpenDatabaseException ex)
			{
				return false;
			}

			return true;

		}

		public static bool VerifyConnections(string ConnectionString)
		{

			try
			{
				DevExpress.Xpo.XpoDefault.GetDataLayer(ConnectionString, AutoCreateOption.None);
			}
			catch (UnableToOpenDatabaseException ex)
			{
				return false;
			}

			return true;

		}

		public static void CreateDatabase(string ServerName, string DBName)
		{

			DevExpress.Xpo.XpoDefault.GetDataLayer(MSSqlConnectionProvider.GetConnectionString(ServerName, DBName), AutoCreateOption.DatabaseAndSchema);

		}

		public static ArrayList GetSQLServers()
		{

			DataTable dataSources = SqlDataSourceEnumerator.Instance.GetDataSources();
			ArrayList serverNames = new ArrayList();

			try
			{
				foreach (DataRow server in dataSources.Rows)
				{
					if (string.IsNullOrEmpty(server["InstanceName"].ToString()) || string.Compare(server["InstanceName"].ToString(), "MSSQLSERVER", false) == 0)
					{
						serverNames.Add(server["ServerName"].ToString());
					}
					else
					{
						serverNames.Add((string.Format("{0}\\{1}", server["ServerName"], server["InstanceName"])));
					}
				}
			}
			catch
			{

			}

			return serverNames;

		}

		public static ArrayList GetDatabases(string serverName)
		{

			if (string.IsNullOrEmpty(serverName))
			{
				return null;
			}

			using (SqlConnection selectConnection = new SqlConnection(serverName))
			{
				using (SqlDataAdapter adapter = new SqlDataAdapter("sp_helpdb", selectConnection))
				{
					using (DataSet dataSet = new DataSet())
					{
						ArrayList databases = new ArrayList();
						try
						{
							adapter.Fill(dataSet);
							try
							{
								foreach (DataRow database in dataSet.Tables[0].Rows)
								{
									databases.Add(database["Name"].ToString());
								}
							}
							catch
							{
							}
							databases = databases;
						}
						catch
						{
							databases = null;
						}
						return databases;
					}
				}
			}

		}

	}


}