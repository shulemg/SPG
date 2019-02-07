//INSTANT C# NOTE: Formerly VB project-level imports:
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

using System.Linq;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using DXDAL;
using DXDAL.SPGData;

namespace SuperiorPackGroup
{
	public class BomAvailabilityReportBLL
	{

		public static BomDemandList GetBomAvailabilityDetail(Project project)
		{

			BomDemandList AvailabilityDetailList = new BomDemandList();

			if (project != null)
			{
				BomDemand AvailabilityDetail = null;
				foreach (ProjectDetails FGDemand in project.ProjectDetails)
				{
					foreach (BOMs BomNeeded in FGDemand.ProjectItem.ItemBOM)
					{
						AvailabilityDetail = new BomDemand();
						AvailabilityDetail.ProjectID = project;
						AvailabilityDetail.ProjectDetailID = FGDemand;
						AvailabilityDetail.ItemID = BomNeeded.BOMRawMatID;
						AvailabilityDetail.ItemType = BomNeeded.BOMRawMatID.ItemType;
						AvailabilityDetail.QuantityOnHand = (new XPCollection<DXDAL.SPGData.LocationInventory>(new BinaryOperator(DXDAL.SPGData.LocationInventory.Fields.LocationInventoryItem.ItemID.PropertyName, BomNeeded.BOMRawMatID.ItemID, BinaryOperatorType.Equal) & new BinaryOperator(DXDAL.SPGData.LocationInventory.Fields.Location.PropertyName, 1, BinaryOperatorType.Equal))).Sum((i) => i.QuantityOnHand);
						AvailabilityDetail.QuantityRequiredForProject = FGDemand.UnitsNeeded * (BomNeeded.BOMQuantity + (BomNeeded.BOMQuantity * (BomNeeded.ScrapFactor / 100)));
						AvailabilityDetailList.Add(AvailabilityDetail);
					}
					foreach (PoolBom PoolBomNeeded in FGDemand.ProjectItem.ItemPoolBom)
					{
						AvailabilityDetail = new BomDemand();
						AvailabilityDetail.ProjectID = project;
						AvailabilityDetail.ProjectDetailID = FGDemand;
						AvailabilityDetail.PoolItemID = PoolBomNeeded.ItemPoolID;
						AvailabilityDetail.ItemType = "PI";
						AvailabilityDetail.QuantityOnHand = PoolBomNeeded.ItemPoolID.QuantityOnHand;
						AvailabilityDetail.QuantityRequiredForProject = FGDemand.UnitsNeeded * (PoolBomNeeded.PoolBomQuantity + (PoolBomNeeded.PoolBomQuantity * (PoolBomNeeded.ScrapFactor / 100)));

						AvailabilityDetailList.Add(AvailabilityDetail);
					}
				}
				AvailabilityDetailList = GetOtherDemands(project.Session, AvailabilityDetailList);
			}

			return AvailabilityDetailList;

		}
		public static List<BomDemandSummary> GetDemandSummary(Session session)
		{

			Dictionary<string, BomDemandSummary> DemandSummaryDictionary = new Dictionary<string, BomDemandSummary>();
			using (XPCollection<ProjectDetails> OpenProjects = new XPCollection<ProjectDetails>(session, new BinaryOperator(ProjectDetails.Fields.Project.ProjectStatus.PropertyName, ProjectStatus.Completed, BinaryOperatorType.NotEqual) & new BinaryOperator(ProjectDetails.Fields.UnitsNeeded.PropertyName, 0, BinaryOperatorType.Greater)))
			{
				try
				{
					foreach (ProjectDetails projectLine in OpenProjects)
					{
						BomDemandSummary BomDemand = null;
						foreach (BOMs BomNeeded in projectLine.ProjectItem.ItemBOM)
						{
							BomDemand = new BomDemandSummary();
							BomDemand.CustomerName = projectLine.Project.Customer.CustomerName;
							BomDemand.ItemID = BomNeeded.BOMRawMatID;
							BomDemand.ItemType = BomNeeded.BOMRawMatID.ItemType;
							if (DemandSummaryDictionary.ContainsKey(BomDemand.DemandKey))
							{
								BomDemand = DemandSummaryDictionary[BomDemand.DemandKey];
								BomDemand.QuantityOnScheduledProjects += (projectLine.UnitsNeeded - projectLine.UnitsNeededToSchedule) * (BomNeeded.BOMQuantity + (BomNeeded.BOMQuantity * (BomNeeded.ScrapFactor / 100)));
								BomDemand.QuantityOnUnscheduledProjects += projectLine.UnitsNeededToSchedule * (BomNeeded.BOMQuantity + (BomNeeded.BOMQuantity * (BomNeeded.ScrapFactor / 100)));
							}
							else
							{
								BomDemand.LocalQuantityOnHand = (new XPCollection<DXDAL.SPGData.LocationInventory>(session, new BinaryOperator(DXDAL.SPGData.LocationInventory.Fields.LocationInventoryItem.ItemID.PropertyName, BomNeeded.BOMRawMatID.ItemID, BinaryOperatorType.Equal) & new BinaryOperator(DXDAL.SPGData.LocationInventory.Fields.Location.PropertyName, 1, BinaryOperatorType.Equal))).Sum((i) => i.QuantityOnHand);
								BomDemand.NonLocalQuantityOnHand = (new XPCollection<DXDAL.SPGData.LocationInventory>(session, new BinaryOperator(DXDAL.SPGData.LocationInventory.Fields.LocationInventoryItem.ItemID.PropertyName, BomNeeded.BOMRawMatID.ItemID, BinaryOperatorType.Equal) & new BinaryOperator(DXDAL.SPGData.LocationInventory.Fields.Location.PropertyName, 1, BinaryOperatorType.NotEqual))).Sum((i) => i.QuantityOnHand);
								//Try
								//    BomDemand.NonLocalPalletsQuantityOnHand = BomDemand.NonLocalQuantityOnHand / BomNeeded.BOMRawMatID.intUnitsPerPallet
								//Catch
								//End Try
								//BomDemand.QuantityOnHand = BomNeeded.BOMRawMatID.TotalQuantityOnHand
								BomDemand.QuantityOnScheduledProjects = (projectLine.UnitsNeeded - projectLine.UnitsNeededToSchedule) * (BomNeeded.BOMQuantity + (BomNeeded.BOMQuantity * (BomNeeded.ScrapFactor / 100)));
								BomDemand.QuantityOnUnscheduledProjects = projectLine.UnitsNeededToSchedule * (BomNeeded.BOMQuantity + (BomNeeded.BOMQuantity * (BomNeeded.ScrapFactor / 100)));
								DemandSummaryDictionary.Add(BomDemand.DemandKey, BomDemand);
							}
						}
						foreach (PoolBom PoolBomNeeded in projectLine.ProjectItem.ItemPoolBom)
						{
							BomDemand = new BomDemandSummary();
							BomDemand.PoolItemID = PoolBomNeeded.ItemPoolID;
							BomDemand.ItemType = "PI";
							if (DemandSummaryDictionary.ContainsKey(BomDemand.DemandKey))
							{
								BomDemand = DemandSummaryDictionary[BomDemand.DemandKey];
								BomDemand.QuantityOnScheduledProjects += (projectLine.UnitsNeeded - projectLine.UnitsNeededToSchedule) * (PoolBomNeeded.PoolBomQuantity + (PoolBomNeeded.PoolBomQuantity * (PoolBomNeeded.ScrapFactor / 100)));
								BomDemand.QuantityOnUnscheduledProjects += projectLine.UnitsNeededToSchedule * (PoolBomNeeded.PoolBomQuantity + (PoolBomNeeded.PoolBomQuantity * (PoolBomNeeded.ScrapFactor / 100)));
							}
							else
							{
								//------------   not tested could be bugy
								BomDemand.LocalQuantityOnHand = (new XPCollection<DXDAL.SPGData.LocationInventory>(session, new BinaryOperator(DXDAL.SPGData.LocationInventory.Fields.LocationInventoryItem.ItemID.PropertyName, PoolBomNeeded.ItemPoolID, BinaryOperatorType.Equal) & new BinaryOperator(DXDAL.SPGData.LocationInventory.Fields.Location.PropertyName, 1, BinaryOperatorType.Equal))).Sum((i) => i.QuantityOnHand);
								BomDemand.NonLocalQuantityOnHand = (new XPCollection<DXDAL.SPGData.LocationInventory>(session, new BinaryOperator(DXDAL.SPGData.LocationInventory.Fields.LocationInventoryItem.ItemID.PropertyName, PoolBomNeeded.ItemPoolID, BinaryOperatorType.Equal) & new BinaryOperator(DXDAL.SPGData.LocationInventory.Fields.Location.PropertyName, 1, BinaryOperatorType.NotEqual))).Sum((i) => i.QuantityOnHand);
								//BomDemand.QuantityOnHand = PoolBomNeeded.ItemPoolID.QuantityOnHand
								BomDemand.QuantityOnScheduledProjects = (projectLine.UnitsNeeded - projectLine.UnitsNeededToSchedule) * (PoolBomNeeded.PoolBomQuantity + (PoolBomNeeded.PoolBomQuantity * (PoolBomNeeded.ScrapFactor / 100)));
								BomDemand.QuantityOnUnscheduledProjects = projectLine.UnitsNeededToSchedule * (PoolBomNeeded.PoolBomQuantity + (PoolBomNeeded.PoolBomQuantity * (PoolBomNeeded.ScrapFactor / 100)));
								DemandSummaryDictionary.Add(BomDemand.DemandKey, BomDemand);
							}
						}
					}
				}
				catch
				{
				}
			}

			return DemandSummaryDictionary.Values.ToList();
		}
		public static List<BomDemandSummary> GetDemandSummary(Session session, DateTime NeededBy)
		{

			Dictionary<string, BomDemandSummary> DemandSummaryDictionary = new Dictionary<string, BomDemandSummary>();
			using (XPCollection<ProjectDetails> OpenProjects = new XPCollection<ProjectDetails>(session, new BinaryOperator(ProjectDetails.Fields.Project.ProjectStatus.PropertyName, ProjectStatus.Completed, BinaryOperatorType.NotEqual) & new BinaryOperator(ProjectDetails.Fields.UnitsNeeded.PropertyName, 0, BinaryOperatorType.Greater) & new BinaryOperator(ProjectDetails.Fields.Project.RequestedStartDate.PropertyName, ((NeededBy == DateTime.MinValue) ? DateTime.MaxValue : NeededBy), BinaryOperatorType.LessOrEqual)))
			{
				try
				{
					foreach (ProjectDetails projectLine in OpenProjects)
					{
						BomDemandSummary BomDemand = null;
						foreach (BOMs BomNeeded in projectLine.ProjectItem.ItemBOM)
						{
							BomDemand = new BomDemandSummary();
							BomDemand.ItemID = BomNeeded.BOMRawMatID;
							BomDemand.ItemType = BomNeeded.BOMRawMatID.ItemType;
							if (DemandSummaryDictionary.ContainsKey(BomDemand.DemandKey))
							{
								BomDemand = DemandSummaryDictionary[BomDemand.DemandKey];
								BomDemand.QuantityOnScheduledProjects += (projectLine.UnitsNeeded - projectLine.UnitsNeededToSchedule) * (BomNeeded.BOMQuantity + (BomNeeded.BOMQuantity * (BomNeeded.ScrapFactor / 100)));
								BomDemand.QuantityOnUnscheduledProjects += projectLine.UnitsNeededToSchedule * (BomNeeded.BOMQuantity + (BomNeeded.BOMQuantity * (BomNeeded.ScrapFactor / 100)));
							}
							else
							{
								BomDemand.LocalQuantityOnHand = (new XPCollection<DXDAL.SPGData.LocationInventory>(session, new BinaryOperator(DXDAL.SPGData.LocationInventory.Fields.LocationInventoryItem.ItemID.PropertyName, BomNeeded.BOMRawMatID.ItemID, BinaryOperatorType.Equal) & new BinaryOperator(DXDAL.SPGData.LocationInventory.Fields.Location.PropertyName, 1, BinaryOperatorType.Equal))).Sum((i) => i.QuantityOnHand);
								BomDemand.NonLocalQuantityOnHand = (new XPCollection<DXDAL.SPGData.LocationInventory>(session, new BinaryOperator(DXDAL.SPGData.LocationInventory.Fields.LocationInventoryItem.ItemID.PropertyName, BomNeeded.BOMRawMatID.ItemID, BinaryOperatorType.Equal) & new BinaryOperator(DXDAL.SPGData.LocationInventory.Fields.Location.PropertyName, 1, BinaryOperatorType.NotEqual))).Sum((i) => i.QuantityOnHand);
								//Try
								//    BomDemand.NonLocalPalletsQuantityOnHand = BomDemand.NonLocalQuantityOnHand / BomNeeded.BOMRawMatID.intUnitsPerPallet
								//Catch
								//End Try
								//BomDemand.QuantityOnHand = BomNeeded.BOMRawMatID.TotalQuantityOnHand
								BomDemand.QuantityOnScheduledProjects = (projectLine.UnitsNeeded - projectLine.UnitsNeededToSchedule) * (BomNeeded.BOMQuantity + (BomNeeded.BOMQuantity * (BomNeeded.ScrapFactor / 100)));
								BomDemand.QuantityOnUnscheduledProjects = projectLine.UnitsNeededToSchedule * (BomNeeded.BOMQuantity + (BomNeeded.BOMQuantity * (BomNeeded.ScrapFactor / 100)));
								DemandSummaryDictionary.Add(BomDemand.DemandKey, BomDemand);
							}
						}
						foreach (PoolBom PoolBomNeeded in projectLine.ProjectItem.ItemPoolBom)
						{
							BomDemand = new BomDemandSummary();
							BomDemand.PoolItemID = PoolBomNeeded.ItemPoolID;
							BomDemand.ItemType = "PI";
							if (DemandSummaryDictionary.ContainsKey(BomDemand.DemandKey))
							{
								BomDemand = DemandSummaryDictionary[BomDemand.DemandKey];
								BomDemand.QuantityOnScheduledProjects += (projectLine.UnitsNeeded - projectLine.UnitsNeededToSchedule) * (PoolBomNeeded.PoolBomQuantity + (PoolBomNeeded.PoolBomQuantity * (PoolBomNeeded.ScrapFactor / 100)));
								BomDemand.QuantityOnUnscheduledProjects += projectLine.UnitsNeededToSchedule * (PoolBomNeeded.PoolBomQuantity + (PoolBomNeeded.PoolBomQuantity * (PoolBomNeeded.ScrapFactor / 100)));
							}
							else
							{
								//------------   not tested could be bugy
								BomDemand.LocalQuantityOnHand = (new XPCollection<DXDAL.SPGData.LocationInventory>(session, new BinaryOperator(DXDAL.SPGData.LocationInventory.Fields.LocationInventoryItem.ItemID.PropertyName, PoolBomNeeded.ItemPoolID, BinaryOperatorType.Equal) & new BinaryOperator(DXDAL.SPGData.LocationInventory.Fields.Location.PropertyName, 1, BinaryOperatorType.Equal))).Sum((i) => i.QuantityOnHand);
								BomDemand.NonLocalQuantityOnHand = (new XPCollection<DXDAL.SPGData.LocationInventory>(session, new BinaryOperator(DXDAL.SPGData.LocationInventory.Fields.LocationInventoryItem.ItemID.PropertyName, PoolBomNeeded.ItemPoolID, BinaryOperatorType.Equal) & new BinaryOperator(DXDAL.SPGData.LocationInventory.Fields.Location.PropertyName, 1, BinaryOperatorType.NotEqual))).Sum((i) => i.QuantityOnHand);
								//BomDemand.QuantityOnHand = PoolBomNeeded.ItemPoolID.QuantityOnHand
								BomDemand.QuantityOnScheduledProjects = (projectLine.UnitsNeeded - projectLine.UnitsNeededToSchedule) * (PoolBomNeeded.PoolBomQuantity + (PoolBomNeeded.PoolBomQuantity * (PoolBomNeeded.ScrapFactor / 100)));
								BomDemand.QuantityOnUnscheduledProjects = projectLine.UnitsNeededToSchedule * (PoolBomNeeded.PoolBomQuantity + (PoolBomNeeded.PoolBomQuantity * (PoolBomNeeded.ScrapFactor / 100)));
								DemandSummaryDictionary.Add(BomDemand.DemandKey, BomDemand);
							}
						}
					}
				}
				catch
				{
				}
			}

			return DemandSummaryDictionary.Values.ToList();

		}

		private static BomDemandList GetOtherDemands(Session session, BomDemandList demandList)
		{

			BomDemandList AvailabilityDetailList = demandList;
			XPCollection<ProjectDetails> OpenProjects = null;

			if (demandList != null && demandList.Count > 0)
			{
				OpenProjects = new XPCollection<ProjectDetails>(session, new BinaryOperator(ProjectDetails.Fields.Project.ProjectStatus.PropertyName, ProjectStatus.Completed, BinaryOperatorType.NotEqual) & new BinaryOperator(ProjectDetails.Fields.UnitsNeeded.PropertyName, 0, BinaryOperatorType.Greater));
				foreach (ProjectDetails projectLine in OpenProjects)
				{
					foreach (BomDemand ProjectBomDemand in demandList)
					{
						if (ProjectBomDemand.ProjectDetailID.Oid != projectLine.Oid)
						{
							if (ProjectBomDemand.ItemType != "PI")
							{
								foreach (BOMs BomNeeded in projectLine.ProjectItem.ItemBOM)
								{
									if (ProjectBomDemand.ItemID.ItemID == BomNeeded.BOMRawMatID.ItemID)
									{
										ProjectBomDemand.QuantityOnUnscheduledProjects += projectLine.UnitsNeededToSchedule * (BomNeeded.BOMQuantity + (BomNeeded.BOMQuantity * (BomNeeded.ScrapFactor / 100)));
										ProjectBomDemand.QuantityOnScheduledProjects += (projectLine.UnitsNeeded - projectLine.UnitsNeededToSchedule) * (BomNeeded.BOMQuantity + (BomNeeded.BOMQuantity * (BomNeeded.ScrapFactor / 100)));
									}
								}
							}
							else
							{
								foreach (PoolBom PoolBomNeeded in projectLine.ProjectItem.ItemPoolBom)
								{
									if (ProjectBomDemand.PoolItemID.Oid == PoolBomNeeded.ItemPoolID.Oid)
									{
										ProjectBomDemand.QuantityOnUnscheduledProjects += projectLine.UnitsNeededToSchedule * (PoolBomNeeded.PoolBomQuantity + (PoolBomNeeded.PoolBomQuantity * (PoolBomNeeded.ScrapFactor / 100)));
										ProjectBomDemand.QuantityOnScheduledProjects += (projectLine.UnitsNeeded - projectLine.UnitsNeededToSchedule) * (PoolBomNeeded.PoolBomQuantity + (PoolBomNeeded.PoolBomQuantity * (PoolBomNeeded.ScrapFactor / 100)));
									}
								}
							}
						}
					}
				}
			}

			return AvailabilityDetailList;

		}

	}

}