Imports DXDAL.SPGData
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Public Class WeeklyProductionReportBLL

    Private ItemWeeklyProduction As WeeklyProduction

    'Public Function GetWeeklyProductionReport(ByVal weekDates As Period, ByVal customer As Customers, ByVal includeScheduled As Boolean) As WeeklyProductionList

    '    If weekDates Is Nothing Then
    '        Return Nothing
    '    End If

    '    Dim WeeklyProductionReport As New WeeklyProductionList

    '    Try

    '    Catch ex As Exception
    '        MessageBox.Show(String.Format("There was an error while trying to retrieve the data for the report.{0}{1}", vbCrLf, ex.Message))
    '        Return Nothing
    '    End Try

    '    Return WeeklyProductionReport

    'End Function

    Public Function GetWeeklyProductionReport(ByVal productionProject As Project) As WeeklyProductionList

        Dim WeeklyProductionReport As New WeeklyProductionList
        Dim currentProjectDetail As ProjectDetails
        Dim totalProduced, requiredBags, requiredCases As Integer

        Try
            Using projectDetailsXPView As XPView = New XPView(Session.DefaultSession, GetType(ProjectDetails)) With {
                                                    .Criteria = New BinaryOperator(ProjectDetails.Fields.Project.Oid.PropertyName, productionProject.Oid, BinaryOperatorType.Equal)}
                projectDetailsXPView.Properties.Add(New ViewProperty("ProjectDetailID", SortDirection.None, ProjectDetails.Fields.Oid, False, True))

                For Each projectDetail As ViewRecord In projectDetailsXPView
                    currentProjectDetail = Session.DefaultSession.GetObjectByKey(Of ProjectDetails)(projectDetail("ProjectDetailID"))
                    totalProduced = currentProjectDetail.UnitsProduced
                    requiredBags = currentProjectDetail.BagsRequested
                    requiredCases = currentProjectDetail.UnitsRequested
                    For Each production As ProductionProjectDetails In currentProjectDetail.ProjectProduction
                        ItemWeeklyProduction = New WeeklyProduction() With {.ItemID = currentProjectDetail.ProjectItem.ItemID, .ProductionWeek = GetProductionWeek(production.Production.InventoryDate)}
                        If WeeklyProductionReport.Contains(ItemWeeklyProduction) Then
                            ItemWeeklyProduction = WeeklyProductionReport(WeeklyProductionReport.IndexOf(ItemWeeklyProduction))
                            ItemWeeklyProduction.RequiredBags += requiredBags
                            ItemWeeklyProduction.RequiredCases += requiredCases
                            ItemWeeklyProduction.TotalProduced += totalProduced
                            totalProduced = 0
                            requiredBags = 0
                            requiredCases = 0
                        Else
                            WeeklyProductionReport.Add(ItemWeeklyProduction)
                            ItemWeeklyProduction.CustomerName = currentProjectDetail.ProjectItem.ItemCustomerID.CustomerName
                            ItemWeeklyProduction.ItemCode = currentProjectDetail.ProjectItem.ItemCode
                            ItemWeeklyProduction.ItemDescription = currentProjectDetail.ProjectItem.ItemDescription
                            ItemWeeklyProduction.RequiredBags = currentProjectDetail.BagsRequested
                            ItemWeeklyProduction.RequiredCases = currentProjectDetail.UnitsRequested
                            ItemWeeklyProduction.TotalProduced = currentProjectDetail.UnitsProduced
                            totalProduced = 0
                            requiredBags = 0
                            requiredCases = 0
                        End If
                        Select Case production.Production.InventoryDate.DayOfWeek
                            Case DayOfWeek.Sunday
                                ItemWeeklyProduction.ProducedSunday += production.UnitsProduced
                            Case DayOfWeek.Monday
                                ItemWeeklyProduction.ProducedMonday += production.UnitsProduced
                            Case DayOfWeek.Tuesday
                                ItemWeeklyProduction.ProducedTuesday += production.UnitsProduced
                            Case DayOfWeek.Wednesday
                                ItemWeeklyProduction.ProducedWednesday += production.UnitsProduced
                            Case DayOfWeek.Thursday
                                ItemWeeklyProduction.ProducedThursday += production.UnitsProduced
                            Case DayOfWeek.Friday
                                ItemWeeklyProduction.ProducedFriday += production.UnitsProduced
                            Case DayOfWeek.Saturday
                                ItemWeeklyProduction.ProducedSaturday += production.UnitsProduced
                        End Select
                    Next
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show(String.Format("There was an error while trying to retrieve the data for the report.{0}{1}", vbCrLf, ex.Message))
            Return Nothing
        End Try

        Return WeeklyProductionReport

    End Function

    Private Shared Function GetProductionWeek(ByVal inventoryDate As Date) As String

        Dim WeekStart, WeekEnd As String

        If inventoryDate.DayOfWeek = DayOfWeek.Sunday Then
            WeekStart = DateAdd(DateInterval.Day, -6, inventoryDate).ToShortDateString
            WeekEnd = inventoryDate.ToShortDateString
        Else
            WeekStart = DateAdd(DateInterval.Day, (inventoryDate.DayOfWeek - 1) * -1, inventoryDate).ToShortDateString
            WeekEnd = DateAdd(DateInterval.Day, 7 - inventoryDate.DayOfWeek, inventoryDate).ToShortDateString
        End If

        Return String.Format("{0} - {1}", WeekStart, WeekEnd)

    End Function

End Class