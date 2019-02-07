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
	public class WeeklyProductionReportBLL
	{

		private WeeklyProduction ItemWeeklyProduction;

		//Public Function GetWeeklyProductionReport(ByVal weekDates As Period, ByVal customer As Customers, ByVal includeScheduled As Boolean) As WeeklyProductionList

		//    If weekDates Is Nothing Then
		//        Return Nothing
		//    End If

		//    Dim WeeklyProductionReport As New WeeklyProductionList

		//    Try

		//    Catch ex As Exception
		//        MessageBox.Show(String.Format("There was an error while trying to retrieve the data for the report.{0}{1}", vbCrLf, ex.Message))
		//        Return Nothing
		//    End Try

		//    Return WeeklyProductionReport

		//End Function

		public WeeklyProductionList GetWeeklyProductionReport(Project productionProject)
		{

			WeeklyProductionList WeeklyProductionReport = new WeeklyProductionList();
			ProjectDetails currentProjectDetail = null;
			int totalProduced = 0;
			int requiredBags = 0;
			int requiredCases = 0;

			try
			{
				using (XPView projectDetailsXPView = new XPView(Session.DefaultSession, typeof(ProjectDetails)) {Criteria = new BinaryOperator(ProjectDetails.Fields.Project.Oid.PropertyName, productionProject.Oid, BinaryOperatorType.Equal)})
				{
					projectDetailsXPView.Properties.Add(new ViewProperty("ProjectDetailID", SortDirection.None, ProjectDetails.Fields.Oid, false, true));

					foreach (ViewRecord projectDetail in projectDetailsXPView)
					{
						currentProjectDetail = Session.DefaultSession.GetObjectByKey<ProjectDetails>(projectDetail["ProjectDetailID"]);
						totalProduced = currentProjectDetail.UnitsProduced;
						requiredBags = currentProjectDetail.BagsRequested;
						requiredCases = currentProjectDetail.UnitsRequested;
						foreach (ProductionProjectDetails production in currentProjectDetail.ProjectProduction)
						{
							ItemWeeklyProduction = new WeeklyProduction()
							{
								ItemID = currentProjectDetail.ProjectItem.ItemID,
								ProductionWeek = GetProductionWeek(production.Production.InventoryDate)
							};
							if (WeeklyProductionReport.Contains(ItemWeeklyProduction))
							{
								ItemWeeklyProduction = WeeklyProductionReport[WeeklyProductionReport.IndexOf(ItemWeeklyProduction)];
								ItemWeeklyProduction.RequiredBags += requiredBags;
								ItemWeeklyProduction.RequiredCases += requiredCases;
								ItemWeeklyProduction.TotalProduced += totalProduced;
								totalProduced = 0;
								requiredBags = 0;
								requiredCases = 0;
							}
							else
							{
								WeeklyProductionReport.Add(ItemWeeklyProduction);
								ItemWeeklyProduction.CustomerName = currentProjectDetail.ProjectItem.ItemCustomerID.CustomerName;
								ItemWeeklyProduction.ItemCode = currentProjectDetail.ProjectItem.ItemCode;
								ItemWeeklyProduction.ItemDescription = currentProjectDetail.ProjectItem.ItemDescription;
								ItemWeeklyProduction.RequiredBags = currentProjectDetail.BagsRequested;
								ItemWeeklyProduction.RequiredCases = currentProjectDetail.UnitsRequested;
								ItemWeeklyProduction.TotalProduced = currentProjectDetail.UnitsProduced;
								totalProduced = 0;
								requiredBags = 0;
								requiredCases = 0;
							}
							switch (production.Production.InventoryDate.DayOfWeek)
							{
								case DayOfWeek.Sunday:
									ItemWeeklyProduction.ProducedSunday += production.UnitsProduced;
									break;
								case DayOfWeek.Monday:
									ItemWeeklyProduction.ProducedMonday += production.UnitsProduced;
									break;
								case DayOfWeek.Tuesday:
									ItemWeeklyProduction.ProducedTuesday += production.UnitsProduced;
									break;
								case DayOfWeek.Wednesday:
									ItemWeeklyProduction.ProducedWednesday += production.UnitsProduced;
									break;
								case DayOfWeek.Thursday:
									ItemWeeklyProduction.ProducedThursday += production.UnitsProduced;
									break;
								case DayOfWeek.Friday:
									ItemWeeklyProduction.ProducedFriday += production.UnitsProduced;
									break;
								case DayOfWeek.Saturday:
									ItemWeeklyProduction.ProducedSaturday += production.UnitsProduced;
									break;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(string.Format("There was an error while trying to retrieve the data for the report.{0}{1}", Environment.NewLine, ex.Message));
				return null;
			}

			return WeeklyProductionReport;

		}

		private static string GetProductionWeek(DateTime inventoryDate)
		{

			string WeekStart = null;
			string WeekEnd = null;

			if (inventoryDate.DayOfWeek == DayOfWeek.Sunday)
			{
				WeekStart = inventoryDate.AddDays(-6).ToShortDateString();
				WeekEnd = inventoryDate.ToShortDateString();
			}
			else
			{
				WeekStart = inventoryDate.AddDays(((int)inventoryDate.DayOfWeek - 1) * -1).ToShortDateString();
				WeekEnd = inventoryDate.AddDays(7 - (int)inventoryDate.DayOfWeek).ToShortDateString();
			}

			return string.Format("{0} - {1}", WeekStart, WeekEnd);

		}

	}
}