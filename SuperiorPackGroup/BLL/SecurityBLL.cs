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
using System.Linq;

namespace SuperiorPackGroup
{
	[System.ComponentModel.DataObject()]
	public class SecurityBLL
	{

		private SecurityTableAdapter m_SecurityTableAdapter = null;
		public SecurityTableAdapter Adapter
		{

			get
			{
				if (m_SecurityTableAdapter == null)
				{
					m_SecurityTableAdapter = new SecurityTableAdapter();
					m_SecurityTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return m_SecurityTableAdapter;
			}

		}

		private SecurityDAL m_SecurityDAL;
		public SecurityDAL SecurityDAL
		{

			get
			{
				//tempSecurityDAL tempSecurityDAL = null;
				if (m_SecurityDAL == null)
				{
					m_SecurityDAL = new SecurityDAL();
				}
				return m_SecurityDAL;
			}

		}

		private void UpdateAuditTrail(SPG.SecurityRow ModifiedRecord, object[] originalRecord)
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
				AuditTrailBLL.AddTrailEntry(Properties.Settings.Default.UserName, Convert.ToInt32(ModifiedRecord[0]), "Security", builder.ToString());
			}

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public SPG.SecurityDataTable GetSecuritySettingsByUserName(string userName)
		{

			return Adapter.GetSecuritySettingsByUserName(userName);

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public DataTableReader GetSecuritySettingsByUserNameReader(string userName)
		{

			return SecurityDAL.GetSecuritySettingsByUserName(userName);

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
		public bool UpdateUserPermissions(string name, bool receivingForm, bool shippingForm, bool customersForm, bool itmesForm, bool productionForm, bool costingReports, bool productionReports, bool advancedTabs, bool financialTabs)
		{

			SPG.SecurityDataTable permissions = Adapter.GetSecuritySettingsByUserName(name);

			if (permissions.Count() == 0)
			{
				//It is a new Product
				return InsertUserPermissions(name, receivingForm, shippingForm, customersForm, itmesForm, productionForm, costingReports, productionReports, advancedTabs, financialTabs);
			}

			SPG.SecurityRow userPermissions = permissions[0];

			object[] originalRecord = userPermissions.ItemArray;

			userPermissions.ReceivingForm = receivingForm;
			userPermissions.ShippingForm = shippingForm;
			userPermissions.CustomersForm = customersForm;
			userPermissions.ItemsForm = itmesForm;
			userPermissions.ProductionForm = productionForm;
			userPermissions.CostingReport = costingReports;
			userPermissions.ProductionReport = productionReports;
			userPermissions.AdvancedTabs = advancedTabs;
			userPermissions.FinancialTabs = financialTabs;

			if (!(originalRecord == null))
			{
				UpdateAuditTrail(userPermissions, originalRecord);
			}

			int rowsAffected = Adapter.Update(userPermissions);

			return rowsAffected == 1;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert, true)]
		public bool InsertUserPermissions(string name, bool receivingForm, bool shippingForm, bool customersForm, bool itmesForm, bool productionForm, bool costingReports, bool productionReports, bool advancedTabs, bool financialTabs)
		{

			SPG.SecurityDataTable permissions = new SPG.SecurityDataTable();
			SPG.SecurityRow userPermissions = permissions.NewSecurityRow();

			userPermissions.strUser = name;
			userPermissions.ReceivingForm = receivingForm;
			userPermissions.ShippingForm = shippingForm;
			userPermissions.CustomersForm = customersForm;
			userPermissions.ItemsForm = itmesForm;
			userPermissions.ProductionForm = productionForm;
			userPermissions.CostingReport = costingReports;
			userPermissions.ProductionReport = productionReports;
			userPermissions.AdvancedTabs = advancedTabs;
			userPermissions.FinancialTabs = financialTabs;

			permissions.AddSecurityRow(userPermissions);
			int rowsAffected = Adapter.Update(permissions);

			return rowsAffected == 1;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete, true)]
		public bool DeleteUserPermissions(string name)
		{

			SPG.SecurityDataTable permissions = Adapter.GetSecuritySettingsByUserName(name);
			int rowsAffected = 0;

			if (permissions.Count() == 1)
			{
				SPG.SecurityRow userPermissions = (SPG.SecurityRow)permissions.Rows[0];
				rowsAffected = Adapter.Delete(name, userPermissions.ts);
			}

			//Return true if precisely one row was deleted, otherwise return false.
			return rowsAffected == 1;

		}

	}

}