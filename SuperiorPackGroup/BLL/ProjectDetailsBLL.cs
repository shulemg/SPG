//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using DevExpress.Xpo;
using DXDAL.SPGData;
using DevExpress.Data.Filtering;
using DXDAL;
using System.ComponentModel;

namespace SuperiorPackGroup
{
	public class ProjectDetailsBLL
	{

		public static void AssignToProjects(Session session, Inventory productionRecord, int? itemId, int? quantity)
		{

			if (itemId.HasValue == false || quantity.HasValue == false)
			{
				return;
			}

			ProjectDetails OverrunnableProject = null;
			ProjectDetails currentProject = null;
			ProductionProjectDetails productionDeail = null;
			Items item = session.GetObjectByKey<Items>(itemId);

			double unitsPerCase = 0;
			int? bagsPerCase = null;
			double casesPerPallet = 0;
			int unassignedQuantity = quantity.Value;
			int acceptableQuantity = 0;

			if (item == null)
			{
				return;
			}
			else
			{
				unitsPerCase = item.intUnitsPerCase;
				casesPerPallet = item.intCasesPerPallet;
				bagsPerCase = item.BagsPerCase;
				if (bagsPerCase.HasValue == false)
				{
					bagsPerCase = 0;
				}

				item = null;
			}

			GroupOperator theCriteria = new GroupOperator(GroupOperatorType.And, new BinaryOperator(ProjectDetails.Fields.ProjectItem.ItemID.PropertyName, (object)itemId, BinaryOperatorType.Equal), new BinaryOperator(ProjectDetails.Fields.UnitsRequested, ProjectDetails.Fields.UnitsProduced, BinaryOperatorType.Greater), new BinaryOperator(ProjectDetails.Fields.Project.ProjectStatus.PropertyName, ProjectStatus.Completed, BinaryOperatorType.NotEqual));

			using (XPCollection<ProjectDetails> itemProject = new XPCollection<ProjectDetails>(session, theCriteria, new SortProperty(ProjectDetails.Fields.Project.Oid.PropertyName, DevExpress.Xpo.DB.SortingDirection.Ascending), new SortProperty(ProjectDetails.Fields.Oid.PropertyName, DevExpress.Xpo.DB.SortingDirection.Ascending)))
			{
				if (itemProject.Count == 0)
				{
					return;
				}

				for (int i = 0; i < itemProject.Count; i++)
				{
					currentProject = itemProject[i];
					if (currentProject.AllowOverrun == true)
					{
						OverrunnableProject = currentProject;
					}

					acceptableQuantity = currentProject.UnitsRequested - currentProject.UnitsProduced;

					productionDeail = new ProductionProjectDetails(session)
					{
						Production = productionRecord,
						ProjectDetail = currentProject,
						BagsProduced = 0,
						PalletsProduced = 0,
						IsOverrun = false
					};

					if (acceptableQuantity > unassignedQuantity)
					{
						productionDeail.UnitsProduced = unassignedQuantity;

						if (unitsPerCase > 0)
						{
							productionDeail.BagsProduced = Convert.ToInt32((unassignedQuantity / unitsPerCase) * bagsPerCase);
						}
						if (unitsPerCase > 0 && casesPerPallet > 0)
						{
							productionDeail.PalletsProduced = Convert.ToInt32(unassignedQuantity / unitsPerCase / casesPerPallet);
						}

						unassignedQuantity = 0;
					}
					else
					{
						productionDeail.UnitsProduced = acceptableQuantity;

						if (unitsPerCase > 0)
						{
							productionDeail.BagsProduced = Convert.ToInt32((acceptableQuantity / unitsPerCase) * bagsPerCase);
						}
						if (unitsPerCase > 0 && casesPerPallet > 0)
						{
							productionDeail.PalletsProduced = Convert.ToInt32(acceptableQuantity / unitsPerCase / casesPerPallet);
						}

						unassignedQuantity -= acceptableQuantity;
					}

					productionDeail.Save();

					if (unassignedQuantity == 0)
					{
						break;
					}
				}

				if (unassignedQuantity > 0 && OverrunnableProject != null)
				{
					productionDeail = new ProductionProjectDetails(session)
					{
						Production = productionRecord,
						ProjectDetail = OverrunnableProject,
						UnitsProduced = unassignedQuantity,
						BagsProduced = 0,
						PalletsProduced = 0,
						IsOverrun = true
					};
					if (unitsPerCase > 0)
					{
						productionDeail.BagsProduced = Convert.ToInt32((unassignedQuantity / unitsPerCase) * bagsPerCase);
					}
					if (unitsPerCase > 0 && casesPerPallet > 0)
					{
						productionDeail.PalletsProduced = Convert.ToInt32(unassignedQuantity / unitsPerCase / casesPerPallet);
					}

					productionDeail.Save();
				}
			}

		}

		public static bool CanAssignToProjects(Session session, int? itemId, int? Quantity)
		{

			bool result = false;

			GroupOperator theCriteria = new GroupOperator(GroupOperatorType.And, new BinaryOperator(ProjectDetails.Fields.ProjectItem.ItemID.PropertyName, (object)itemId, BinaryOperatorType.Equal), new BinaryOperator(new OperandProperty(ProjectDetails.Fields.UnitsRequested.PropertyName), new OperandProperty(ProjectDetails.Fields.UnitsProduced.PropertyName), BinaryOperatorType.Greater), new BinaryOperator(ProjectDetails.Fields.Project.ProjectStatus.PropertyName, ProjectStatus.Completed, BinaryOperatorType.NotEqual));

			using (XPCollection<ProjectDetails> itemProject = new XPCollection<ProjectDetails>(session, theCriteria))
			{
				if (itemProject.Count == 0)
				{
					result = false;
				}
				else
				{
					if (Convert.ToInt32(session.Evaluate<ProjectDetails>(CriteriaOperator.Parse("SUM(UnitsRequested - UnitsProduced)"), theCriteria)) >= Quantity.Value)
					{
						result = true;
					}
					else
					{
						theCriteria.Operands.Add(new BinaryOperator(ProjectDetails.Fields.AllowOverrun.PropertyName, true, BinaryOperatorType.Equal));
						itemProject.Reload();
						if (itemProject.Count > 0)
						{
							result = true;
						}
					}
				}
			}

			return result;

		}

		public static BindingList<ChangeObject> GetProjectDetailChanges(Session session, int recordID, bool uniqueProperties)
		{

			BindingList<ChangeObject> result = AuditTrailBLL.GetChanges(session, "ProjectDetails", recordID, uniqueProperties);

			//For Each update As ChangeObject In result
			//    If update.PropertyName = "ProjectItem" Then
			//        If update.PrevValue <> "NULL" Then
			//        update.PrevValue = update.
			//        End If
			//    End If
			//Next

			return result;

		}

		public static bool IsItOnSchedule(Session session, int? itemId)
		{

			GroupOperator theCriteria = new GroupOperator(GroupOperatorType.And, new BinaryOperator(ProjectDetails.Fields.ProjectItem.ItemID.PropertyName, (object)itemId, BinaryOperatorType.Equal), new BinaryOperator(new OperandProperty(ProjectDetails.Fields.UnitsRequested.PropertyName), new OperandProperty(ProjectDetails.Fields.UnitsProduced.PropertyName), BinaryOperatorType.Greater), new BinaryOperator(ProjectDetails.Fields.Project.ProjectStatus.PropertyName, ProjectStatus.Completed, BinaryOperatorType.NotEqual));


			using (XPCollection<ProjectDetails> itemProject = new XPCollection<ProjectDetails>(session, theCriteria))
			{
				if (itemProject.Count > 0)
				{
					return true;
				}
				else
				{
					return false;
				}

			}

		}



	}

}