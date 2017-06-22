Imports DevExpress.Xpo
Imports DXDAL.SPGData
Imports DevExpress.Data.Filtering
Imports DXDAL
Imports System.ComponentModel

Public Class ProjectDetailsBLL

    Public Shared Sub AssignToProjects(ByVal session As Session, ByVal productionRecord As Inventory, ByVal itemId As Integer?, ByVal quantity As Integer?)

        If itemId.HasValue = False OrElse quantity.HasValue = False Then
            Exit Sub
        End If

        Dim OverrunnableProject As ProjectDetails = Nothing
        Dim currentProject As ProjectDetails = Nothing
        Dim productionDeail As ProductionProjectDetails = Nothing
        Dim item As Items = session.GetObjectByKey(Of Items)(itemId)

        Dim unitsPerCase As Double
        Dim bagsPerCase As Integer?
        Dim casesPerPallet As Double
        Dim unassignedQuantity As Integer = quantity.Value
        Dim acceptableQuantity As Integer

        If item Is Nothing Then
            Exit Sub
        Else
            unitsPerCase = item.intUnitsPerCase
            casesPerPallet = item.intCasesPerPallet
            bagsPerCase = item.BagsPerCase
            If bagsPerCase.HasValue = False Then
                bagsPerCase = 0
            End If

            item = Nothing
        End If

        Dim theCriteria As New GroupOperator(GroupOperatorType.And, New BinaryOperator(ProjectDetails.Fields.ProjectItem.ItemID.PropertyName, itemId, BinaryOperatorType.Equal),
                                             New BinaryOperator(ProjectDetails.Fields.UnitsRequested, ProjectDetails.Fields.UnitsProduced, BinaryOperatorType.Greater),
                                             New BinaryOperator(ProjectDetails.Fields.Project.ProjectStatus.PropertyName, ProjectStatus.Completed, BinaryOperatorType.NotEqual))

        Using itemProject As XPCollection(Of ProjectDetails) = New XPCollection(Of ProjectDetails)(session, theCriteria, New SortProperty(ProjectDetails.Fields.Project.Oid.PropertyName, DB.SortingDirection.Ascending),
                                                                                                   New SortProperty(ProjectDetails.Fields.Oid.PropertyName, DB.SortingDirection.Ascending))
            If itemProject.Count = 0 Then
                Exit Sub
            End If

            For i As Integer = 0 To itemProject.Count - 1
                currentProject = itemProject(i)
                If currentProject.AllowOverrun = True Then
                    OverrunnableProject = currentProject
                End If

                acceptableQuantity = currentProject.UnitsRequested - currentProject.UnitsProduced

                productionDeail = New ProductionProjectDetails(session) With {.Production = productionRecord,
                                                                         .ProjectDetail = currentProject,
                                                                         .BagsProduced = 0,
                                                                         .PalletsProduced = 0,
                                                                         .IsOverrun = False}

                If acceptableQuantity > unassignedQuantity Then
                    productionDeail.UnitsProduced = unassignedQuantity

                    If unitsPerCase > 0 Then
                        productionDeail.BagsProduced = CInt((unassignedQuantity / unitsPerCase) * bagsPerCase)
                    End If
                    If unitsPerCase > 0 AndAlso casesPerPallet > 0 Then
                        productionDeail.PalletsProduced = CInt(unassignedQuantity / unitsPerCase / casesPerPallet)
                    End If

                    unassignedQuantity = 0
                Else
                    productionDeail.UnitsProduced = acceptableQuantity

                    If unitsPerCase > 0 Then
                        productionDeail.BagsProduced = CInt((acceptableQuantity / unitsPerCase) * bagsPerCase)
                    End If
                    If unitsPerCase > 0 AndAlso casesPerPallet > 0 Then
                        productionDeail.PalletsProduced = CInt(acceptableQuantity / unitsPerCase / casesPerPallet)
                    End If

                    unassignedQuantity -= acceptableQuantity
                End If

                productionDeail.Save()

                If unassignedQuantity = 0 Then
                    Exit For
                End If
            Next

            If unassignedQuantity > 0 AndAlso OverrunnableProject IsNot Nothing Then
                productionDeail = New ProductionProjectDetails(session) With {.Production = productionRecord,
                                                                     .ProjectDetail = OverrunnableProject,
                                                                     .UnitsProduced = unassignedQuantity,
                                                                     .BagsProduced = 0,
                                                                     .PalletsProduced = 0,
                                                                     .IsOverrun = True}
                If unitsPerCase > 0 Then
                    productionDeail.BagsProduced = CInt((unassignedQuantity / unitsPerCase) * bagsPerCase)
                End If
                If unitsPerCase > 0 AndAlso casesPerPallet > 0 Then
                    productionDeail.PalletsProduced = CInt(unassignedQuantity / unitsPerCase / casesPerPallet)
                End If

                productionDeail.Save()
            End If
        End Using

    End Sub

    Public Shared Function CanAssignToProjects(ByVal session As Session, ByVal itemId As Integer?, ByVal Quantity As Integer?) As Boolean

        Dim result As Boolean = False

        Dim theCriteria As New GroupOperator(GroupOperatorType.And, New BinaryOperator(ProjectDetails.Fields.ProjectItem.ItemID.PropertyName, itemId, BinaryOperatorType.Equal),
                                             New BinaryOperator(New OperandProperty(ProjectDetails.Fields.UnitsRequested.PropertyName), New OperandProperty(ProjectDetails.Fields.UnitsProduced.PropertyName), BinaryOperatorType.Greater),
                                             New BinaryOperator(ProjectDetails.Fields.Project.ProjectStatus.PropertyName, ProjectStatus.Completed, BinaryOperatorType.NotEqual))

        Using itemProject As XPCollection(Of ProjectDetails) = New XPCollection(Of ProjectDetails)(session, theCriteria)
            If itemProject.Count = 0 Then
                result = False
            Else
                If CInt(session.Evaluate(Of ProjectDetails)(CriteriaOperator.Parse("SUM(UnitsRequested - UnitsProduced)"), theCriteria)) >= Quantity.Value Then
                    result = True
                Else
                    theCriteria.Operands.Add(New BinaryOperator(ProjectDetails.Fields.AllowOverrun.PropertyName, True, BinaryOperatorType.Equal))
                    itemProject.Reload()
                    If itemProject.Count > 0 Then
                        result = True
                    End If
                End If
            End If
        End Using

        Return result

    End Function

    Public Shared Function GetProjectDetailChanges(ByVal session As Session, ByVal recordID As Integer, ByVal uniqueProperties As Boolean) As BindingList(Of ChangeObject)

        Dim result As BindingList(Of ChangeObject) = AuditTrailBLL.GetChanges(session, "ProjectDetails", recordID, uniqueProperties)

        'For Each update As ChangeObject In result
        '    If update.PropertyName = "ProjectItem" Then
        '        If update.PrevValue <> "NULL" Then
        '        update.PrevValue = update.
        '        End If
        '    End If
        'Next

        Return result

    End Function

    Public Shared Function IsItOnSchedule(ByVal session As Session, ByVal itemId As Integer?) As Boolean

        Dim theCriteria As New GroupOperator(GroupOperatorType.And, New BinaryOperator(ProjectDetails.Fields.ProjectItem.ItemID.PropertyName, itemId, BinaryOperatorType.Equal),
                                             New BinaryOperator(New OperandProperty(ProjectDetails.Fields.UnitsRequested.PropertyName), New OperandProperty(ProjectDetails.Fields.UnitsProduced.PropertyName), BinaryOperatorType.Greater),
                                             New BinaryOperator(ProjectDetails.Fields.Project.ProjectStatus.PropertyName, ProjectStatus.Completed, BinaryOperatorType.NotEqual))


        Using itemProject As XPCollection(Of ProjectDetails) = New XPCollection(Of ProjectDetails)(session, theCriteria)
            If itemProject.Count > 0 Then
                Return True
            Else
                Return False
            End If

        End Using

    End Function



End Class
