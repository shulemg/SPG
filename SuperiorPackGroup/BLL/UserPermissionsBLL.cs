//INSTANT C# NOTE: Formerly VB project-level imports:
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using System;
using SuperiorPackGroup.SPGTableAdapters;
using System.Text;
using DXDAL.SPGData;
using System.Linq;

namespace SuperiorPackGroup
{
	[System.ComponentModel.DataObject()]
	public class UserPermissionsBLL
	{

		private UserPermissionsTableAdapter m_UserPermissionsTableAdapter = null;
		public UserPermissionsTableAdapter Adapter
		{

			get
			{
				if (m_UserPermissionsTableAdapter == null)
				{
					m_UserPermissionsTableAdapter = new UserPermissionsTableAdapter();
					m_UserPermissionsTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return m_UserPermissionsTableAdapter;
			}

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.UserPermissionsDataTable GetUserPermissionsByUserName(string userName, string permissionObject)
		{

			return Adapter.GetUserPermissionsByUserName(userName, permissionObject);

		}

		private void UpdateAuditTrail(SPG.UserPermissionsRow ModifiedRecord, object[] originalRecord)
		{

			StringBuilder builder = new StringBuilder(string.Empty);
			int recordFields = (ModifiedRecord.ItemArray.Length - 1);
			int i = 0;
			while (i <= recordFields)
			{
				try
				{
					if (Convert.IsDBNull(originalRecord[i]))
					{
						if (!Convert.IsDBNull(ModifiedRecord[i]))
						{
							builder.Append(string.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns[i].ColumnName, "NULL", ModifiedRecord[i]));
						}
					}
					else if (Convert.IsDBNull(ModifiedRecord[i]))
					{
						if (!Convert.IsDBNull(originalRecord[i]))
						{
							builder.Append(string.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns[i].ColumnName, originalRecord[i], "NULL"));
						}
					}
					else if (ModifiedRecord[i] != originalRecord[i])
					{
						builder.Append(string.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns[i].ColumnName, originalRecord[i], ModifiedRecord[i]));
					}
				}
				catch
				{
				}
				i += 1;
			}
			if (builder.Length > 2)
			{
				builder.Length = (builder.Length - 2);
				AuditTrailBLL.AddTrailEntry(Properties.Settings.Default.UserName, Convert.ToInt32(ModifiedRecord[0]), "UserPermissions", builder.ToString());
			}
		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
		public bool UpdateUserPermissions(int? UserPermissionID, string PermissionObject, string PermissionLevel, string UserName)
		{

			SPG.UserPermissionsDataTable permissions = Adapter.GetUserPermissionByID(UserPermissionID.Value);

			if (permissions.Count() == 0)
			{
				//It is a new record
				return InsertUserPermissions(PermissionObject, PermissionLevel, UserName);
			}

			SPG.UserPermissionsRow userPermissions = permissions[0];

			object[] originalRecord = userPermissions.ItemArray;

			userPermissions.PermissionObject = PermissionObject;
			userPermissions.PermissionLevel = PermissionLevel;
			userPermissions.UserName = UserName;

			int rowsAffected = Adapter.Update(userPermissions);

			if (!(originalRecord == null))
			{
				UpdateAuditTrail(userPermissions, originalRecord);
			}

			return rowsAffected == 1;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
		public bool InsertUserPermissions(string PermissionObject, string PermissionLevel, string UserName)
		{

			SPG.UserPermissionsDataTable permissions = new SPG.UserPermissionsDataTable();
			SPG.UserPermissionsRow userPermissions = permissions.NewUserPermissionsRow();

			userPermissions.UserName = UserName;
			userPermissions.PermissionObject = PermissionObject;
			userPermissions.PermissionLevel = PermissionLevel;

			permissions.AddUserPermissionsRow(userPermissions);
			int rowsAffected = Adapter.Update(permissions);

			return rowsAffected == 1;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
		public bool DeleteUserPermissions(int userPermissionID)
		{

			SPG.UserPermissionsDataTable permissions = Adapter.GetUserPermissionByID(userPermissionID);
			int rowsAffected = 0;

			if (permissions.Count() == 1)
			{
				SPG.UserPermissionsRow userPermissions = (SPG.UserPermissionsRow)permissions.Rows[0];
				rowsAffected = Adapter.Delete(userPermissionID, userPermissions.ts);
			}

			//Return true if precisely one row was deleted, otherwise return false.
			return rowsAffected == 1;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
		public bool DeleteUserPermissions(string username)
		{


			int rowsAffected = Adapter.DeletePermissionByUser(username);

			return rowsAffected != 0;

		}

		public ArrayList GetPermissionObjects()
		{

			ArrayList permissionObjects = new ArrayList();
			try
			{
//INSTANT C# NOTE: Commented this declaration since looping variables in 'foreach' loops are declared in the 'foreach' header in C#:
//				Dim row As SPG.UserPermissionsRow
				foreach (SPG.UserPermissionsRow row in Adapter.GetUserPermissions())
				{
					string permissionObject = row.PermissionObject;
					if (!permissionObjects.Contains(permissionObject))
					{
						permissionObjects.Add(permissionObject);
					}
				}
			}
			finally
			{

			}
			return permissionObjects;

		}

		public bool CreateNewUserPermissions(string UserName)
		{

			return Convert.ToBoolean(Adapter.CreateNewUserPermissions(UserName));

		}



	}

}