//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using SuperiorPackGroup.SPGTableAdapters;
using System.Text;
using DXDAL.SPGData;
using DevExpress.Xpo;
using System.Linq;

namespace SuperiorPackGroup
{
	[System.ComponentModel.DataObject()]
	public class UsersBLL
	{

		private UsersTableAdapter m_UsersTableAdapter;
		private List<Change> changes = new List<Change>();

		public UsersTableAdapter Adapter
		{

			get
			{
				if (m_UsersTableAdapter != null)
				{
					return m_UsersTableAdapter;
				}

				m_UsersTableAdapter = new UsersTableAdapter();
				m_UsersTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				return m_UsersTableAdapter;
			}

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public string GetUserSecurityLevel(string userName, string password)
		{

			if (string.Compare(password, GetUserPassword(userName), false) != 0)
			{
				return null;
			}

			return Adapter.GetUserSecurityLevel(userName, password);

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
		public SPG.UsersDataTable GetUsers()
		{

			return Adapter.GetUsers();

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public string GetUserPassword(string userName)
		{

			return Adapter.GetUserPassword(userName);

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public static Users GetUserByName(Session session, string userName)
		{
			if (session == null)
			{
				return GetUserByName(userName);
			}

			return session.GetObjectByKey<Users>(userName);

		}
		public static Users GetUserByName(string userName)
		{

			return Session.DefaultSession.GetObjectByKey<Users>(userName);

		}

		public static Locations GetUsersLocalLocation(Session session, string UserName)
		{

			Locations localLocation = GetUserByName(session, UserName).DefaultLocation;

			if (localLocation == null)
			{
				return CompanySettingsBLL.GetDefaultLocation();
			}
			else
			{
				return localLocation;
			}

		}

		private void SetField(string propertyName, object oldValue, object newValue, Users user)
		{

			if ((oldValue != null || newValue != null) && ((oldValue != null && newValue == null) || (newValue != null && oldValue == null) || oldValue.ToString() != newValue.ToString()))
			{
				user.SetMemberValue(propertyName, newValue);
				Change change = new Change()
				{
					PropertyName = propertyName,
					PrevValue = ((oldValue == null) ? "<NULL>" : oldValue.ToString()),
					NewValue = ((newValue == null) ? "<NULL>" : newValue.ToString())
				};
				changes.Add(change);
			}

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
		public bool UpdateUser(string name, string password, string confirm, Locations defaultLocation, string LPNPrinter)
		{

			if (string.IsNullOrEmpty(name))
			{
				throw new ApplicationException("You must provide a User Name.");
			}

			if (string.IsNullOrEmpty(password))
			{
				throw new ApplicationException("You must provide a User Password.");
			}

			if (string.IsNullOrEmpty(confirm))
			{
				throw new ApplicationException("Please confirm the password.");
			}

			if (string.Compare(password, confirm, false) != 0)
			{
				throw new ApplicationException("The passwords do not match.");
			}

			Users user = Session.DefaultSession.GetObjectByKey<Users>(name);

			if (user == null)
			{
				//It is a new user
				return InsertUser(name, password, defaultLocation, LPNPrinter);
			}

			//Dim originalRecord As Object() = user.ItemArray

			Change change = new Change()
			{
				PropertyName = Users.Fields.strUserName.PropertyName,
				PrevValue = user.strUserName,
				NewValue = user.strUserName
			};
			changes.Add(change);

			SetField(Users.Fields.strPassword.PropertyName, user.strPassword, password, user);
			SetField(Users.Fields.DefaultLocation.PropertyName, user.DefaultLocation, defaultLocation, user);
			SetField(Users.Fields.LPNPrinterName.PropertyName, user.LPNPrinterName, LPNPrinter, user);

			//user.strPassword = password

			//If Not IsNothing(originalRecord) Then
			//    UpdateAuditTrail(user, originalRecord)
			//End If

			//Return Adapter.Update(user) = 1


			try
			{
				user.Save();
			}
			catch (Exception ex)
			{
				return false;
			}

			UpdateAuditTrail();

			return true;

		}

		private void UpdateAuditTrail()
		{
			//Private Sub UpdateAuditTrail(ByVal ModifiedRecord As SPG.UsersRow, ByVal originalRecord As Object())

			StringBuilder builder = new StringBuilder(string.Empty);

			foreach (Change update in changes)
			{
				builder.Append(string.Format("{0}:{1}({2}); ", update.PropertyName, update.PrevValue, update.NewValue));
			}

			if (builder.Length > 2)
			{
				builder.Length = (builder.Length - 2);
				AuditTrailBLL.AddTrailEntry(Properties.Settings.Default.UserName, 0, "Users", builder.ToString());
			}

			changes.Clear();


			//Dim builder As New StringBuilder(String.Empty)
			//Dim i As Integer = 0
			//Do While (i <= (ModifiedRecord.Table.Columns.Count - 1))
			//    Try
			//        If IsDBNull(originalRecord(i)) Then
			//            If Not IsDBNull(ModifiedRecord.Item(i)) Then
			//                builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, "NULL", ModifiedRecord.Item(i)))
			//            End If
			//        ElseIf Information.IsDBNull(ModifiedRecord.Item(i)) Then
			//            If Not Information.IsDBNull(originalRecord(i)) Then
			//                builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, originalRecord(i), "NULL"))
			//            End If
			//        ElseIf CStr(ModifiedRecord.Item(i)) <> CStr(originalRecord(i)) Then
			//            builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, originalRecord(i), ModifiedRecord.Item(i)))
			//        End If
			//    Catch
			//        Continue Do
			//    Finally
			//        i += 1
			//    End Try
			//Loop
			//If builder.Length <= 2 Then
			//    Return
			//End If

			//builder.Length = (builder.Length - 2)
			//AuditTrailBLL.AddTrailEntry(My.Settings.UserName, 0, "Users", builder.ToString)

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
		public bool InsertUser(string name, string password, Locations defaultLocation, string LPNPrinter)
		{

			Change change = new Change()
			{
				PropertyName = Users.Fields.strUserName.PropertyName,
				PrevValue = "<NULL>",
				NewValue = name
			};
			changes.Add(change);

			Users user = new Users(Session.DefaultSession) {strUserName = name};
			SetField(Users.Fields.strPassword.PropertyName, user.strPassword, password, user);
			SetField(Users.Fields.DefaultLocation.PropertyName, user.DefaultLocation, defaultLocation, user);
			SetField(Users.Fields.LPNPrinterName.PropertyName, user.LPNPrinterName, LPNPrinter, user);
			SetField(Users.Fields.strSecurityLevel.PropertyName, user.strSecurityLevel, "User", user);

			try
			{
				user.Save();
				if ((new UserPermissionsBLL()).CreateNewUserPermissions(name) == false)
				{
					throw new ApplicationException("The permissions were not created succesfuly.");
				}
			}
			catch (Exception ex)
			{
				return false;
			}

			return true;

			//Using users As SPG.UsersDataTable = New SPG.UsersDataTable()
			//    Dim user As SPG.UsersRow = users.NewUsersRow
			//    user.strUserName = name
			//    user.strPassword = password
			//    user.strSecurityLevel = "User"
			//    users.AddUsersRow(user)
			//    Dim rowsAffected As Integer = Adapter.Update(users)
			//    If rowsAffected = 1 Then
			//        If New UserPermissionsBLL().CreateNewUserPermissions(name) = False Then
			//            Throw New ApplicationException("The permissions were not created succesfuly.")
			//        End If
			//    End If
			//    Return rowsAffected = 1
			//End Using

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
		public bool DeleteUser(string name)
		{

			SPG.UsersDataTable users = Adapter.GetUserByName(name);
			int rowsAffected = 0;

			if (users.Count() == 1)
			{
				SPG.UsersRow user = (SPG.UsersRow)users.Rows[0];
				rowsAffected = Adapter.Delete(name, user.ts);
			}

			//Return true if precisely one row was deleted, otherwise return false.
			return rowsAffected == 1;

		}

	}

}