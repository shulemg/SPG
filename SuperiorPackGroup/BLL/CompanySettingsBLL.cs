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

namespace SuperiorPackGroup
{
	public class CompanySettingsBLL
	{

		private static CompanySettingsTableAdapter m_CompanySettingsTableAdapter = null;
		public static CompanySettingsTableAdapter Adapter
		{

			get
			{
				if (m_CompanySettingsTableAdapter == null)
				{
					m_CompanySettingsTableAdapter = new CompanySettingsTableAdapter();
					m_CompanySettingsTableAdapter.Connection.ConnectionString = Properties.Settings.Default.UserConnectionString;
				}
				return m_CompanySettingsTableAdapter;
			}

		}

		private List<Change> changes = new List<Change>();

		private void UpdateAuditTrail()
		{

			StringBuilder builder = new StringBuilder(string.Empty);

			foreach (Change update in changes)
			{
				builder.Append(string.Format("{0}:{1}({2}); ", update.PropertyName, update.PrevValue, update.NewValue));
			}

			if (builder.Length > 2)
			{
				builder.Length = (builder.Length - 2);
				AuditTrailBLL.AddTrailEntry(Properties.Settings.Default.UserName, int.Parse(changes[0].NewValue), "CompanySettings", builder.ToString());
			}

			changes.Clear();

		}

		public static CompanySettings GetSettings()
		{

			try
			{
				return Session.DefaultSession.GetObjectByKey<CompanySettings>(1);
			}
			catch (Exception ex)
			{
				return null;
			}

		}

		public static Locations GetDefaultLocation()
		{

			try
			{
				return Session.DefaultSession.GetObjectByKey<CompanySettings>(1).DefaultLocation;
			}
			catch
			{
				return null;
			}

		}

		public static string GetLPNPrinter()
		{

			try
			{
				return Session.DefaultSession.GetObjectByKey<CompanySettings>(1).LPNPrinterName;
			}
			catch (Exception ex)
			{
				return null;
			}

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, true)]
		public SPG.CompanySettingsDataTable GetCompanySettings()
		{

			return Adapter.GetCompanySettings();

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public static int GetUniversalCustomer()
		{

			return Adapter.GetUniversalCustomer().Value;

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public static string GetDBVersion()
		{

			return Adapter.GetDBVersion();

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Select, false)]
		public static bool SetDBVersion(string value)
		{

			return Convert.ToBoolean(Adapter.SetDBVersion(value));

		}

		private void SetField(string propertyName, object oldValue, object newValue, CompanySettings settings)
		{

			if ((oldValue != null || newValue != null) && ((oldValue != null && newValue == null) || (newValue != null && oldValue == null) || oldValue.ToString() != newValue.ToString()))
			{
				settings.SetMemberValue(propertyName, newValue);
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
		public bool UpdateCompanySettings(float? packers, float? operators, float? supers, short? minPerHour, int? universalCustomer, string lpnPrinter, byte LPNMoveRight, byte LPNMoveDown, byte LPNCopies, int? Location)
		{

			CompanySettings settings = GetSettings();

			if (settings == null)
			{
				//It is a new Product
				return false;
			}

			Change change = new Change()
			{
				PropertyName = CompanySettings.Fields.PK_ID.PropertyName,
				PrevValue = settings.PK_ID.ToString(),
				NewValue = settings.PK_ID.ToString()
			};
			changes.Add(change);

			SetField(CompanySettings.Fields.dblPackersPay.PropertyName, settings.dblPackersPay, (packers ?? 0), settings);
			SetField(CompanySettings.Fields.dblOperatorsPay.PropertyName, settings.dblOperatorsPay, (operators ?? 0), settings);
			SetField(CompanySettings.Fields.dblSupersPay.PropertyName, settings.dblSupersPay, (supers ?? 0), settings);
			SetField(CompanySettings.Fields.intMinPerHour.PropertyName, settings.intMinPerHour, (minPerHour ?? 45), settings);
			SetField(CompanySettings.Fields.UniversalCustomer.PropertyName, settings.UniversalCustomer, (universalCustomer ?? 0), settings);
			SetField(CompanySettings.Fields.LPNPrinterName.PropertyName, settings.LPNPrinterName, (string.IsNullOrEmpty(lpnPrinter) ? null : lpnPrinter), settings);
			SetField(CompanySettings.Fields.LPNHorizontalAdjustment.PropertyName, settings.LPNHorizontalAdjustment, LPNMoveRight, settings);
			SetField(CompanySettings.Fields.LPNVerticalAdjustment.PropertyName, settings.LPNVerticalAdjustment, LPNMoveDown, settings);
			SetField(CompanySettings.Fields.LPNPrintCopies.PropertyName, settings.LPNPrintCopies, LPNCopies, settings);
			SetField(CompanySettings.Fields.DefaultLocation.PropertyName, settings.DefaultLocation, Session.DefaultSession.GetObjectByKey<Locations>(Location), settings);

			try
			{
				settings.Save();
			}
			catch (Exception ex)
			{
				return false;
			}

			UpdateAuditTrail();

			return true;

		}

	}

}