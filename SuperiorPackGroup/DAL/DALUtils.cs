//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections.Specialized;
using DevExpress.Xpo;
using DXDAL.SPGData;

namespace SuperiorPackGroup
{
	public class DALUtils
	{

		public static bool TestConnection()
		{

			return TestConnection(null);

		}

		public static bool TestConnection(string connectionString)
		{

			if (string.IsNullOrEmpty(connectionString))
			{
				if (string.IsNullOrEmpty(Properties.Settings.Default.UserConnectionString))
				{
					return false;
				}
				else
				{
					connectionString = Properties.Settings.Default.UserConnectionString;
				}
			}

			SqlConnection conn = new SqlConnection(connectionString);

			try
			{
				conn.Open();
				if (Session.DefaultSession.IsConnected)
				{
					Session.DefaultSession.Disconnect();
				}
				Session.DefaultSession.ConnectionString = connectionString;
				Session.DefaultSession.AutoCreateOption = DevExpress.Xpo.DB.AutoCreateOption.SchemaOnly;
				Session.DefaultSession.UpdateSchema(System.Reflection.Assembly.GetAssembly(typeof(LatestVersion)));
				MyDataLayers.SPGDataLayer = XpoDefault.GetDataLayer(connectionString, DevExpress.Xpo.DB.AutoCreateOption.SchemaOnly);
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
			finally
			{
				conn.Close();
			}

		}

		public static ArrayList GetSQLServers()
		{

			SqlDataSourceEnumerator sqlSource = SqlDataSourceEnumerator.Instance;
			DataTable dt = sqlSource.GetDataSources();
			ArrayList serverList = new ArrayList();

			foreach (DataRow dr in dt.Rows)
			{
				if (string.IsNullOrEmpty(dr["InstanceName"].ToString()) || string.Compare(dr["InstanceName"].ToString(), "MSSQLSERVER") == 0)
				{
					serverList.Add(dr["ServerName"].ToString());
				}
				else
				{
					serverList.Add(string.Format("{0}\\{1}", dr["ServerName"].ToString(), dr["InstanceName"].ToString()));
				}
			}

			return serverList;

		}

		public static ArrayList GetDatabases(string connectionString)
		{

			if (string.IsNullOrEmpty(connectionString))
			{
				if (string.IsNullOrEmpty(Properties.Settings.Default.UserConnectionString))
				{
					return null;
				}
				else
				{
					connectionString = Properties.Settings.Default.UserConnectionString;
				}
			}

			SqlConnection conn = new SqlConnection(connectionString);
			SqlDataAdapter da = new SqlDataAdapter("sp_helpdb", conn);
			DataSet ds = new DataSet();
			ArrayList dataBaseList = new ArrayList();
			try
			{
				da.Fill(ds);

				foreach (DataRow dr in ds.Tables[0].Rows)
				{
					dataBaseList.Add(dr["Name"].ToString());
				}

				return dataBaseList;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}

		}

	}

}