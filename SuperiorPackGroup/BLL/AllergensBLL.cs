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
using DevExpress.Xpo;
using DXDAL.SPGData;
using DevExpress.Persistent.Base;

namespace SuperiorPackGroup
{
	[System.ComponentModel.DataObject()]
	public class AllergensBLL
	{
		public static XPCollection<Allergen> GetAllergens(ref Session session)
		{
			XPCollection<Allergen> AllergeXPCollection = new XPCollection<Allergen>(session);

			return AllergeXPCollection;

		}

		private void UpdateAuditTrail(Allergen ModifiedRecord, Allergen originalRecord)
		{

			//Dim builder As New StringBuilder(String.Empty)
			//Dim recordFields As Integer = (ModifiedRecord.ItemArray.Length - 1)
			//Dim i As Integer = 0
			//Do While (i <= recordFields)
			//    Try
			//        If IsDBNull(originalRecord(i)) Then
			//            If Not IsDBNull(ModifiedRecord.Item(i)) Then
			//                builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, "NULL", ModifiedRecord.Item(i)))
			//            End If
			//        ElseIf IsDBNull(ModifiedRecord.Item(i)) Then
			//            If Not IsDBNull(originalRecord(i)) Then
			//                builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, originalRecord(i), "NULL"))
			//            End If
			//        ElseIf ModifiedRecord.Item(i) IsNot originalRecord(i) Then
			//            builder.Append(String.Format("{0}:{1}({2}); ", ModifiedRecord.Table.Columns.Item(i).ColumnName, originalRecord(i), ModifiedRecord.Item(i)))
			//        End If
			//    Catch
			//    End Try
			//    i += 1
			//Loop
			//If (builder.Length > 2) Then
			//    builder.Length = (builder.Length - 2)
			//    AuditTrailBLL.AddTrailEntry(My.Settings.UserName, CType(ModifiedRecord.Item(0), Integer), "MachineLines", builder.ToString)
			//End If

		}

		[System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update, true)]
		public bool UpdateAllergen(Session session, int? id, string name)
		{

			Allergen Allergen = session.GetObjectByKey<Allergen>(id.Value);

			if (Allergen != null)
			{
				//It is a new Product
				return this.InsertAllergen(session, name);
			}

			if (string.IsNullOrEmpty(name))
			{
				throw new ApplicationException("You must provide Allergen.");
			}

			Allergen originalRecord = null;
			Cloner cloner = new Cloner();
			originalRecord = (Allergen)cloner.CloneTo(Allergen, typeof(Allergen));

			Allergen.AllergenName = name;

			if (!(originalRecord == null))
			{
				this.UpdateAuditTrail(Allergen, originalRecord);
			}

			Allergen.Save();

			return true;

		}

		public bool InsertAllergen(Session session, string name)
		{

			Allergen Allergen = new Allergen(session);

			if (string.IsNullOrEmpty(name))
			{
				throw new ApplicationException("You must provide Allergen.");
			}

			Allergen.AllergenName = name;

			Allergen.Save();

			return true;

		}

		public bool DeleteAllergens(Session session, int id)
		{

			Allergen Allergen = session.GetObjectByKey<Allergen>(id);

			if (Allergen != null)
			{
				//If New ProductionBLL().GetProductionByMachine(id).Count <> 0 Then
				//MessageBox.Show("You can't delete this Allergen there are other records associated to it")
				//Return False
				//End If
				session.Delete(Allergen);
			}

			return true;

		}

	}

}