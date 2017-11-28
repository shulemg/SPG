Imports System.Linq
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DXDAL
Imports DXDAL.SPGData

Public Class BomAvailabilityReportBLL

    Public Shared Function GetBomAvailabilityDetail(ByVal project As Project) As BomDemandList

        Dim AvailabilityDetailList As New BomDemandList

        If project IsNot Nothing Then
            Dim AvailabilityDetail As BomDemand
            For Each FGDemand As ProjectDetails In project.ProjectDetails
                For Each BomNeeded As BOMs In FGDemand.ProjectItem.ItemBOM
                    AvailabilityDetail = New BomDemand
                    AvailabilityDetail.ProjectID = project
                    AvailabilityDetail.ProjectDetailID = FGDemand
                    AvailabilityDetail.ItemID = BomNeeded.BOMRawMatID
                    AvailabilityDetail.ItemType = BomNeeded.BOMRawMatID.ItemType
                    AvailabilityDetail.QuantityOnHand = New XPCollection(Of SPGData.LocationInventory)(New BinaryOperator(SPGData.LocationInventory.Fields.LocationInventoryItem.ItemID.PropertyName, BomNeeded.BOMRawMatID.ItemID, BinaryOperatorType.Equal) And New BinaryOperator(SPGData.LocationInventory.Fields.Location.PropertyName, 1, BinaryOperatorType.Equal)).Sum(Function(i) i.QuantityOnHand)
                    AvailabilityDetail.QuantityRequiredForProject = FGDemand.UnitsNeeded * (BomNeeded.BOMQuantity + (BomNeeded.BOMQuantity * (BomNeeded.ScrapFactor / 100)))
                    AvailabilityDetailList.Add(AvailabilityDetail)
                Next
                For Each PoolBomNeeded As PoolBom In FGDemand.ProjectItem.ItemPoolBom
                    AvailabilityDetail = New BomDemand
                    AvailabilityDetail.ProjectID = project
                    AvailabilityDetail.ProjectDetailID = FGDemand
                    AvailabilityDetail.PoolItemID = PoolBomNeeded.ItemPoolID
                    AvailabilityDetail.ItemType = "PI"
                    AvailabilityDetail.QuantityOnHand = PoolBomNeeded.ItemPoolID.QuantityOnHand
                    AvailabilityDetail.QuantityRequiredForProject = FGDemand.UnitsNeeded * (PoolBomNeeded.PoolBomQuantity + (PoolBomNeeded.PoolBomQuantity * (PoolBomNeeded.ScrapFactor / 100)))

                    AvailabilityDetailList.Add(AvailabilityDetail)
                Next
            Next
            AvailabilityDetailList = GetOtherDemands(project.Session, AvailabilityDetailList)
        End If

        Return AvailabilityDetailList

    End Function
    Public Shared Function GetDemandSummary(ByVal session As Session) As List(Of BomDemandSummary)

        Dim DemandSummaryDictionary As New Dictionary(Of String, BomDemandSummary)
        Using OpenProjects As XPCollection(Of ProjectDetails) = New XPCollection(Of ProjectDetails)(session,
                                                                    New BinaryOperator(ProjectDetails.Fields.Project.ProjectStatus.PropertyName, ProjectStatus.Completed, BinaryOperatorType.NotEqual) And
                                                                    New BinaryOperator(ProjectDetails.Fields.UnitsNeeded.PropertyName, 0, BinaryOperatorType.Greater))
            Try
                For Each projectLine As ProjectDetails In OpenProjects
                    Dim BomDemand As BomDemandSummary
                    For Each BomNeeded As BOMs In projectLine.ProjectItem.ItemBOM
                        BomDemand = New BomDemandSummary
                        BomDemand.CustomerName = projectLine.Project.Customer.CustomerName
                        BomDemand.ItemID = BomNeeded.BOMRawMatID
                        BomDemand.ItemType = BomNeeded.BOMRawMatID.ItemType
                        If DemandSummaryDictionary.ContainsKey(BomDemand.DemandKey) Then
                            BomDemand = DemandSummaryDictionary(BomDemand.DemandKey)
                            BomDemand.QuantityOnScheduledProjects += (projectLine.UnitsNeeded - projectLine.UnitsNeededToSchedule) *
                                (BomNeeded.BOMQuantity + (BomNeeded.BOMQuantity * (BomNeeded.ScrapFactor / 100)))
                            BomDemand.QuantityOnUnscheduledProjects += projectLine.UnitsNeededToSchedule * (BomNeeded.BOMQuantity + (BomNeeded.BOMQuantity * (BomNeeded.ScrapFactor / 100)))
                        Else
                            BomDemand.LocalQuantityOnHand = New XPCollection(Of SPGData.LocationInventory)(session, New BinaryOperator(SPGData.LocationInventory.Fields.LocationInventoryItem.ItemID.PropertyName, BomNeeded.BOMRawMatID.ItemID, BinaryOperatorType.Equal) And New BinaryOperator(SPGData.LocationInventory.Fields.Location.PropertyName, 1, BinaryOperatorType.Equal)).Sum(Function(i) i.QuantityOnHand)
                            BomDemand.NonLocalQuantityOnHand = New XPCollection(Of SPGData.LocationInventory)(session, New BinaryOperator(SPGData.LocationInventory.Fields.LocationInventoryItem.ItemID.PropertyName, BomNeeded.BOMRawMatID.ItemID, BinaryOperatorType.Equal) And New BinaryOperator(SPGData.LocationInventory.Fields.Location.PropertyName, 1, BinaryOperatorType.NotEqual)).Sum(Function(i) i.QuantityOnHand)
                            'Try
                            '    BomDemand.NonLocalPalletsQuantityOnHand = BomDemand.NonLocalQuantityOnHand / BomNeeded.BOMRawMatID.intUnitsPerPallet
                            'Catch
                            'End Try
                            'BomDemand.QuantityOnHand = BomNeeded.BOMRawMatID.TotalQuantityOnHand
                            BomDemand.QuantityOnScheduledProjects = (projectLine.UnitsNeeded - projectLine.UnitsNeededToSchedule) *
                                (BomNeeded.BOMQuantity + (BomNeeded.BOMQuantity * (BomNeeded.ScrapFactor / 100)))
                            BomDemand.QuantityOnUnscheduledProjects = projectLine.UnitsNeededToSchedule * (BomNeeded.BOMQuantity + (BomNeeded.BOMQuantity * (BomNeeded.ScrapFactor / 100)))
                            DemandSummaryDictionary.Add(BomDemand.DemandKey, BomDemand)
                        End If
                    Next
                    For Each PoolBomNeeded As PoolBom In projectLine.ProjectItem.ItemPoolBom
                        BomDemand = New BomDemandSummary
                        BomDemand.PoolItemID = PoolBomNeeded.ItemPoolID
                        BomDemand.ItemType = "PI"
                        If DemandSummaryDictionary.ContainsKey(BomDemand.DemandKey) Then
                            BomDemand = DemandSummaryDictionary(BomDemand.DemandKey)
                            BomDemand.QuantityOnScheduledProjects += (projectLine.UnitsNeeded - projectLine.UnitsNeededToSchedule) *
                                (PoolBomNeeded.PoolBomQuantity + (PoolBomNeeded.PoolBomQuantity * (PoolBomNeeded.ScrapFactor / 100)))
                            BomDemand.QuantityOnUnscheduledProjects += projectLine.UnitsNeededToSchedule * (PoolBomNeeded.PoolBomQuantity + (PoolBomNeeded.PoolBomQuantity * (PoolBomNeeded.ScrapFactor / 100)))
                        Else
                            '------------   not tested could be bugy
                            BomDemand.LocalQuantityOnHand = New XPCollection(Of SPGData.LocationInventory)(session, New BinaryOperator(SPGData.LocationInventory.Fields.LocationInventoryItem.ItemID.PropertyName, PoolBomNeeded.ItemPoolID, BinaryOperatorType.Equal) And New BinaryOperator(SPGData.LocationInventory.Fields.Location.PropertyName, 1, BinaryOperatorType.Equal)).Sum(Function(i) i.QuantityOnHand)
                            BomDemand.NonLocalQuantityOnHand = New XPCollection(Of SPGData.LocationInventory)(session, New BinaryOperator(SPGData.LocationInventory.Fields.LocationInventoryItem.ItemID.PropertyName, PoolBomNeeded.ItemPoolID, BinaryOperatorType.Equal) And New BinaryOperator(SPGData.LocationInventory.Fields.Location.PropertyName, 1, BinaryOperatorType.NotEqual)).Sum(Function(i) i.QuantityOnHand)
                            'BomDemand.QuantityOnHand = PoolBomNeeded.ItemPoolID.QuantityOnHand
                            BomDemand.QuantityOnScheduledProjects = (projectLine.UnitsNeeded - projectLine.UnitsNeededToSchedule) *
                                (PoolBomNeeded.PoolBomQuantity + (PoolBomNeeded.PoolBomQuantity * (PoolBomNeeded.ScrapFactor / 100)))
                            BomDemand.QuantityOnUnscheduledProjects = projectLine.UnitsNeededToSchedule * (PoolBomNeeded.PoolBomQuantity + (PoolBomNeeded.PoolBomQuantity * (PoolBomNeeded.ScrapFactor / 100)))
                            DemandSummaryDictionary.Add(BomDemand.DemandKey, BomDemand)
                        End If
                    Next
                Next
            Catch
            End Try
        End Using

        Return DemandSummaryDictionary.Values.ToList
    End Function
    Public Shared Function GetDemandSummary(ByVal session As Session, NeededBy As Date) As List(Of BomDemandSummary)

        Dim DemandSummaryDictionary As New Dictionary(Of String, BomDemandSummary)
        Using OpenProjects As XPCollection(Of ProjectDetails) = New XPCollection(Of ProjectDetails)(session,
                                                                    New BinaryOperator(ProjectDetails.Fields.Project.ProjectStatus.PropertyName, ProjectStatus.Completed, BinaryOperatorType.NotEqual) And
                                                                    New BinaryOperator(ProjectDetails.Fields.UnitsNeeded.PropertyName, 0, BinaryOperatorType.Greater) And
                                                                    New BinaryOperator(ProjectDetails.Fields.Project.RequestedStartDate.PropertyName, IIf(NeededBy = DateTime.MinValue, DateTime.MaxValue, NeededBy), BinaryOperatorType.LessOrEqual))
            Try
                For Each projectLine As ProjectDetails In OpenProjects
                    Dim BomDemand As BomDemandSummary
                    For Each BomNeeded As BOMs In projectLine.ProjectItem.ItemBOM
                        BomDemand = New BomDemandSummary
                        BomDemand.ItemID = BomNeeded.BOMRawMatID
                        BomDemand.ItemType = BomNeeded.BOMRawMatID.ItemType
                        If DemandSummaryDictionary.ContainsKey(BomDemand.DemandKey) Then
                            BomDemand = DemandSummaryDictionary(BomDemand.DemandKey)
                            BomDemand.QuantityOnScheduledProjects += (projectLine.UnitsNeeded - projectLine.UnitsNeededToSchedule) *
                                (BomNeeded.BOMQuantity + (BomNeeded.BOMQuantity * (BomNeeded.ScrapFactor / 100)))
                            BomDemand.QuantityOnUnscheduledProjects += projectLine.UnitsNeededToSchedule * (BomNeeded.BOMQuantity + (BomNeeded.BOMQuantity * (BomNeeded.ScrapFactor / 100)))
                        Else
                            BomDemand.LocalQuantityOnHand = New XPCollection(Of SPGData.LocationInventory)(session, New BinaryOperator(SPGData.LocationInventory.Fields.LocationInventoryItem.ItemID.PropertyName, BomNeeded.BOMRawMatID.ItemID, BinaryOperatorType.Equal) And New BinaryOperator(SPGData.LocationInventory.Fields.Location.PropertyName, 1, BinaryOperatorType.Equal)).Sum(Function(i) i.QuantityOnHand)
                            BomDemand.NonLocalQuantityOnHand = New XPCollection(Of SPGData.LocationInventory)(session, New BinaryOperator(SPGData.LocationInventory.Fields.LocationInventoryItem.ItemID.PropertyName, BomNeeded.BOMRawMatID.ItemID, BinaryOperatorType.Equal) And New BinaryOperator(SPGData.LocationInventory.Fields.Location.PropertyName, 1, BinaryOperatorType.NotEqual)).Sum(Function(i) i.QuantityOnHand)
                            'Try
                            '    BomDemand.NonLocalPalletsQuantityOnHand = BomDemand.NonLocalQuantityOnHand / BomNeeded.BOMRawMatID.intUnitsPerPallet
                            'Catch
                            'End Try
                            'BomDemand.QuantityOnHand = BomNeeded.BOMRawMatID.TotalQuantityOnHand
                            BomDemand.QuantityOnScheduledProjects = (projectLine.UnitsNeeded - projectLine.UnitsNeededToSchedule) *
                                (BomNeeded.BOMQuantity + (BomNeeded.BOMQuantity * (BomNeeded.ScrapFactor / 100)))
                            BomDemand.QuantityOnUnscheduledProjects = projectLine.UnitsNeededToSchedule * (BomNeeded.BOMQuantity + (BomNeeded.BOMQuantity * (BomNeeded.ScrapFactor / 100)))
                            DemandSummaryDictionary.Add(BomDemand.DemandKey, BomDemand)
                        End If
                    Next
                    For Each PoolBomNeeded As PoolBom In projectLine.ProjectItem.ItemPoolBom
                        BomDemand = New BomDemandSummary
                        BomDemand.PoolItemID = PoolBomNeeded.ItemPoolID
                        BomDemand.ItemType = "PI"
                        If DemandSummaryDictionary.ContainsKey(BomDemand.DemandKey) Then
                            BomDemand = DemandSummaryDictionary(BomDemand.DemandKey)
                            BomDemand.QuantityOnScheduledProjects += (projectLine.UnitsNeeded - projectLine.UnitsNeededToSchedule) *
                                (PoolBomNeeded.PoolBomQuantity + (PoolBomNeeded.PoolBomQuantity * (PoolBomNeeded.ScrapFactor / 100)))
                            BomDemand.QuantityOnUnscheduledProjects += projectLine.UnitsNeededToSchedule * (PoolBomNeeded.PoolBomQuantity + (PoolBomNeeded.PoolBomQuantity * (PoolBomNeeded.ScrapFactor / 100)))
                        Else
                            '------------   not tested could be bugy
                            BomDemand.LocalQuantityOnHand = New XPCollection(Of SPGData.LocationInventory)(session, New BinaryOperator(SPGData.LocationInventory.Fields.LocationInventoryItem.ItemID.PropertyName, PoolBomNeeded.ItemPoolID, BinaryOperatorType.Equal) And New BinaryOperator(SPGData.LocationInventory.Fields.Location.PropertyName, 1, BinaryOperatorType.Equal)).Sum(Function(i) i.QuantityOnHand)
                            BomDemand.NonLocalQuantityOnHand = New XPCollection(Of SPGData.LocationInventory)(session, New BinaryOperator(SPGData.LocationInventory.Fields.LocationInventoryItem.ItemID.PropertyName, PoolBomNeeded.ItemPoolID, BinaryOperatorType.Equal) And New BinaryOperator(SPGData.LocationInventory.Fields.Location.PropertyName, 1, BinaryOperatorType.NotEqual)).Sum(Function(i) i.QuantityOnHand)
                            'BomDemand.QuantityOnHand = PoolBomNeeded.ItemPoolID.QuantityOnHand
                            BomDemand.QuantityOnScheduledProjects = (projectLine.UnitsNeeded - projectLine.UnitsNeededToSchedule) *
                                (PoolBomNeeded.PoolBomQuantity + (PoolBomNeeded.PoolBomQuantity * (PoolBomNeeded.ScrapFactor / 100)))
                            BomDemand.QuantityOnUnscheduledProjects = projectLine.UnitsNeededToSchedule * (PoolBomNeeded.PoolBomQuantity + (PoolBomNeeded.PoolBomQuantity * (PoolBomNeeded.ScrapFactor / 100)))
                            DemandSummaryDictionary.Add(BomDemand.DemandKey, BomDemand)
                        End If
                    Next
                Next
            Catch
            End Try
        End Using

        Return DemandSummaryDictionary.Values.ToList

    End Function

    Private Shared Function GetOtherDemands(ByVal session As Session, ByVal demandList As BomDemandList) As BomDemandList

        Dim AvailabilityDetailList As BomDemandList = demandList
        Dim OpenProjects As XPCollection(Of ProjectDetails)

        If demandList IsNot Nothing AndAlso demandList.Count > 0 Then
            OpenProjects = New XPCollection(Of ProjectDetails)(session, New BinaryOperator(ProjectDetails.Fields.Project.ProjectStatus.PropertyName, ProjectStatus.Completed, BinaryOperatorType.NotEqual) And
                                                               New BinaryOperator(ProjectDetails.Fields.UnitsNeeded.PropertyName, 0, BinaryOperatorType.Greater))
            For Each projectLine As ProjectDetails In OpenProjects
                For Each ProjectBomDemand As BomDemand In demandList
                    If ProjectBomDemand.ProjectDetailID.Oid <> projectLine.Oid Then
                        If ProjectBomDemand.ItemType <> "PI" Then
                            For Each BomNeeded As BOMs In projectLine.ProjectItem.ItemBOM
                                If ProjectBomDemand.ItemID.ItemID = BomNeeded.BOMRawMatID.ItemID Then
                                    ProjectBomDemand.QuantityOnUnscheduledProjects += projectLine.UnitsNeededToSchedule * (BomNeeded.BOMQuantity + (BomNeeded.BOMQuantity * (BomNeeded.ScrapFactor / 100)))
                                    ProjectBomDemand.QuantityOnScheduledProjects += (projectLine.UnitsNeeded - projectLine.UnitsNeededToSchedule) *
                                        (BomNeeded.BOMQuantity + (BomNeeded.BOMQuantity * (BomNeeded.ScrapFactor / 100)))
                                End If
                            Next
                        Else
                            For Each PoolBomNeeded As PoolBom In projectLine.ProjectItem.ItemPoolBom
                                If ProjectBomDemand.PoolItemID.Oid = PoolBomNeeded.ItemPoolID.Oid Then
                                    ProjectBomDemand.QuantityOnUnscheduledProjects += projectLine.UnitsNeededToSchedule *
                                        (PoolBomNeeded.PoolBomQuantity + (PoolBomNeeded.PoolBomQuantity * (PoolBomNeeded.ScrapFactor / 100)))
                                    ProjectBomDemand.QuantityOnScheduledProjects += (projectLine.UnitsNeeded - projectLine.UnitsNeededToSchedule) *
                                        (PoolBomNeeded.PoolBomQuantity + (PoolBomNeeded.PoolBomQuantity * (PoolBomNeeded.ScrapFactor / 100)))
                                End If
                            Next
                        End If
                    End If
                Next
            Next
        End If

        Return AvailabilityDetailList

    End Function

End Class
