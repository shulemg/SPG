//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using SuperiorPackGroup.SPGTableAdapters;
using DevExpress.Xpo;
using DXDAL.SPGData;
using DevExpress.Data.Filtering;
using System.ComponentModel;
using System.Linq;

namespace SuperiorPackGroup
{
	public class AuditTrailBLL
	{

		private static AuditTrailTableAdapter m_TrailTableAdapter = null;
		public static AuditTrailTableAdapter Adapter
		{
			get
			{
				if (m_TrailTableAdapter == null)
				{
					m_TrailTableAdapter = new AuditTrailTableAdapter();
					m_TrailTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return m_TrailTableAdapter;
			}
		}

		public static void AddTrailEntry(string userID, int recordID, string recordType, string recordChanges)
		{

			SPG.AuditTrailDataTable dataTable = new SPG.AuditTrailDataTable();
			SPG.AuditTrailRow row = dataTable.NewAuditTrailRow();
			row.UserID = userID;
			row.RecordID = recordID;
			row.RecordType = recordType;
			row.RecordChanges = recordChanges;
			row.ChangeDate = DateTime.Now;
			dataTable.AddAuditTrailRow(row);
			Adapter.Update(dataTable);

		}

		public static BindingList<ChangeObject> GetChanges(Session session, string recordType, int recordID, bool UniqueProperties, params string[] PropertyNames)
		{

			List<ChangeObject> result = new List<ChangeObject>();

			AuditTrail.FieldsClass auditFields = new AuditTrail.FieldsClass();
			using (XPCollection<AuditTrail> auditRecords = new XPCollection<AuditTrail>(session, new GroupOperator(GroupOperatorType.And, new BinaryOperator(auditFields.RecordID.PropertyName, recordID, BinaryOperatorType.Equal), new BinaryOperator(auditFields.RecordType.PropertyName, recordType, BinaryOperatorType.Equal))))
			{
				foreach (AuditTrail auditRecord in auditRecords)
				{
					if (UniqueProperties == true)
					{
						result.AddRange(GetUniqueChanges(auditRecord.PK_ID, recordID, auditRecord.ChangeDate, auditRecord.RecordChanges).Values.ToList());
					}

				}
			}

			return new BindingList<ChangeObject>(result);

		}

		private static Dictionary<ChangeObjectLookUpKey, ChangeObject> GetUniqueChanges(int ChangeID, int recordID, DateTime DateChanged, string recordChanges, params string[] PropertyNames)
		{

			ChangeObject currentChange = null;
			ChangeObjectLookUpKey currentKey = new ChangeObjectLookUpKey();
			Dictionary<ChangeObjectLookUpKey, ChangeObject> result = new Dictionary<ChangeObjectLookUpKey, ChangeObject>();
			string[] changes = recordChanges.Split(';');

			for (int i = 0; i <= changes.Length - 2; i++)
			{
				currentChange = new ChangeObject();
				currentKey = new ChangeObjectLookUpKey();

				currentChange.ChangeID = ChangeID;
				currentChange.DateChanged = DateChanged;
				currentChange.RecordID = recordID;
				currentChange.PropertyName = changes[i].Split(':')[0];
				currentChange.PrevValue = (changes[i].Split(':')[1]).Split('(')[0];
				currentChange.NewValue = (changes[i].Split(':')[1]).Split('(')[1].Replace(")", "");

				currentKey.ChangeID = currentChange.ChangeID;
				currentKey.ProperyName = currentChange.PropertyName;

				if (result.ContainsKey(currentKey))
				{
					currentChange.PrevValue = result[currentKey].PrevValue;
					result[currentKey] = currentChange;
				}
				else
				{
					result.Add(currentKey, currentChange);
				}
			}

			return result;

		}

	}

}