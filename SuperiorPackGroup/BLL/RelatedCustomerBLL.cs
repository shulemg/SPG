//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using DXDAL.SPGData;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;

namespace SuperiorPackGroup
{
	public class RelatedCustomerBLL
	{

		public static bool AddRelatedCustomer(Customers maincustomer, Customers relatedCustomer, bool bidirectional)
		{

			try
			{
				RelatedCustomer newRelatedCustomer = new RelatedCustomer
				{
					MainCustomer = maincustomer,
					relatedCustomer = relatedCustomer,
					Bidirectional = bidirectional
				};
				newRelatedCustomer.Save();

				if (bidirectional)
				{
					newRelatedCustomer = new RelatedCustomer
					{
						MainCustomer = relatedCustomer,
						relatedCustomer = maincustomer,
						Bidirectional = bidirectional
					};
					newRelatedCustomer.Save();
				}

				return true;
			}
			catch (Exception ex)
			{
				return false;
			}

		}

		public static bool DeleteRelatedCustomers(Customers deletingCustomer)
		{

			RelatedCustomer lRelatedCustomer = null;

			GroupOperator theCriteria = new GroupOperator {OperatorType = GroupOperatorType.Or};
			theCriteria.Operands.Add(new BinaryOperator(RelatedCustomer.Fields.MainCustomer.PropertyName, deletingCustomer, BinaryOperatorType.Equal));
			theCriteria.Operands.Add(new BinaryOperator(RelatedCustomer.Fields.relatedCustomer.PropertyName, deletingCustomer, BinaryOperatorType.Equal));

			using (XPCollection<RelatedCustomer> myRelatedCustomers = new XPCollection<RelatedCustomer>(Session.DefaultSession, theCriteria))
			{
				try
				{
					for (int i = myRelatedCustomers.Count - 1; i >= 0; i--)
					{
						lRelatedCustomer = myRelatedCustomers[i];
						lRelatedCustomer.Delete();
					}
					return true;
				}
				catch (Exception ex)
				{
					return false;
				}
			}

		}

		public static bool DeleteRelatedCustomer(RelatedCustomer deletingCustomer)
		{

			try
			{
				deletingCustomer.Delete();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}

		}

	}

}