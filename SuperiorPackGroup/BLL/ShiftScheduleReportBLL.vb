Imports DXDAL.SPGData
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Public Class ShiftScheduleReportBLL

    Public Shared Function GetShiftScheduleReport(ByVal scheduleDate As Date?, ByVal scheduleShift As String) As XPView

        If scheduleDate.HasValue = False Then
            scheduleDate = Today
        End If

        'If String.IsNullOrEmpty(scheduleShift) Then
        '    scheduleShift = "Shift 1"
        'End If

        Dim shiftScheduleReportXPview As New XPView(Session.DefaultSession, GetType(ProductionSchedule))

        Try
            shiftScheduleReportXPview.Criteria = GetShiftScheduleReportCriteria(scheduleDate, scheduleShift)

            shiftScheduleReportXPview.Properties.AddRange(New ViewProperty() {New ViewProperty("MachineLineName", SortDirection.None, ProductionSchedule.Fields.MachineLine.MachineLineName.PropertyName, False, True),
                                                          New ViewProperty("People", SortDirection.None, ProductionSchedule.Fields.People.PropertyName, False, True),
                                                          New ViewProperty("Operator", SortDirection.None, ProductionSchedule.Fields.MachineOperator.PropertyName, False, True),
                                                          New ViewProperty("ItemCode", SortDirection.None, ProductionSchedule.Fields.ProductionItem.ItemCode.PropertyName, False, True),
                                                          New ViewProperty("ItemDescription", SortDirection.None, ProductionSchedule.Fields.ProductionItem.ItemDescription.PropertyName, False, True),
                                                          New ViewProperty("Quantity", SortDirection.None, ProductionSchedule.Fields.Quantity.PropertyName, False, True),
                                                          New ViewProperty("ShedByQty", SortDirection.None, ProductionSchedule.Fields.ScheduleByQuantity.PropertyName, False, True),
                                                          New ViewProperty("ShceduleNote", SortDirection.None, ProductionSchedule.Fields.ScheduleNote.PropertyName, False, True),
                                                          New ViewProperty("MustRun", SortDirection.None, ProductionSchedule.Fields.MustRun.PropertyName, False, True),
                                                          New ViewProperty("PriorityLevel", SortDirection.None, ProductionSchedule.Fields.PriorityLevel.PropertyName, False, True),
                                                          New ViewProperty("Start", SortDirection.None, ProductionSchedule.Fields.Start.PropertyName, False, True),
                                                          New ViewProperty("Finish", SortDirection.None, ProductionSchedule.Fields.Finish.PropertyName, False, True)
                                                          })
            Return shiftScheduleReportXPview
        Catch ex As ArgumentException
            MessageBox.Show(String.Format("There was an error while trying to retrieve the data for the report.{{1}", vbCrLf, ex.Message))
        End Try

        Return Nothing

    End Function

    Private Shared Function GetShiftScheduleReportCriteria(ByVal scheduleDate As Date?, ByVal scheduleShift As String) As CriteriaOperator

        Select Case scheduleShift
            Case "Shift 1"
                Return New GroupOperator(GroupOperatorType.Or, New GroupOperator(GroupOperatorType.And,
                                        New BinaryOperator(ProductionSchedule.Fields.Start.PropertyName, Date.Parse(String.Format("{0} 9:00", scheduleDate.Value.ToShortDateString())), BinaryOperatorType.GreaterOrEqual),
                                        New BinaryOperator(ProductionSchedule.Fields.Finish.PropertyName, Date.Parse(String.Format("{0} 5:00 PM", scheduleDate.Value.ToShortDateString())), BinaryOperatorType.LessOrEqual)),
                                                New GroupOperator(GroupOperatorType.And,
                                        New BinaryOperator(ProductionSchedule.Fields.Start.PropertyName, Date.Parse(String.Format("{0} 9:00", scheduleDate.Value.ToShortDateString())), BinaryOperatorType.Less),
                                        New BinaryOperator(ProductionSchedule.Fields.Finish.PropertyName, Date.Parse(String.Format("{0} 9:00", scheduleDate.Value.ToShortDateString())), BinaryOperatorType.Greater)),
                                                New GroupOperator(GroupOperatorType.And,
                                        New BinaryOperator(ProductionSchedule.Fields.Start.PropertyName, Date.Parse(String.Format("{0} 5:00 PM", scheduleDate.Value.ToShortDateString())), BinaryOperatorType.Less),
                                        New BinaryOperator(ProductionSchedule.Fields.Finish.PropertyName, Date.Parse(String.Format("{0} 5:00 PM", scheduleDate.Value.ToShortDateString())), BinaryOperatorType.Greater)))
            Case "Shift 2"
                Return New GroupOperator(GroupOperatorType.Or, New GroupOperator(GroupOperatorType.And,
                                   New BinaryOperator(ProductionSchedule.Fields.Start.PropertyName, Date.Parse(String.Format("{0} 5:00 PM", scheduleDate.Value.ToShortDateString())), BinaryOperatorType.GreaterOrEqual),
                                   New BinaryOperator(ProductionSchedule.Fields.Finish.PropertyName, Date.Parse(String.Format("{0} 1:00", DateAdd(DateInterval.Day, 1, scheduleDate.Value).ToShortDateString())), BinaryOperatorType.LessOrEqual)),
                                                                       New GroupOperator(GroupOperatorType.And,
                                   New BinaryOperator(ProductionSchedule.Fields.Start.PropertyName, Date.Parse(String.Format("{0} 5:00 PM", scheduleDate.Value.ToShortDateString())), BinaryOperatorType.Less),
                                   New BinaryOperator(ProductionSchedule.Fields.Finish.PropertyName, Date.Parse(String.Format("{0} 5:00 PM", scheduleDate.Value.ToShortDateString())), BinaryOperatorType.Greater)),
                                                                       New GroupOperator(GroupOperatorType.And,
                                   New BinaryOperator(ProductionSchedule.Fields.Start.PropertyName, Date.Parse(String.Format("{0} 1:00", DateAdd(DateInterval.Day, 1, scheduleDate.Value).ToShortDateString())), BinaryOperatorType.Less),
                                   New BinaryOperator(ProductionSchedule.Fields.Finish.PropertyName, Date.Parse(String.Format("{0} 1:00", DateAdd(DateInterval.Day, 1, scheduleDate.Value).ToShortDateString())), BinaryOperatorType.Greater)))
            Case "Shift 3"
                Return New GroupOperator(GroupOperatorType.Or, New GroupOperator(GroupOperatorType.And,
                                   New BinaryOperator(ProductionSchedule.Fields.Start.PropertyName, Date.Parse(String.Format("{0} 1:00", DateAdd(DateInterval.Day, 1, scheduleDate.Value).ToShortDateString())), BinaryOperatorType.GreaterOrEqual),
                                   New BinaryOperator(ProductionSchedule.Fields.Finish.PropertyName, Date.Parse(String.Format("{0} 9:00", DateAdd(DateInterval.Day, 1, scheduleDate.Value).ToShortDateString())), BinaryOperatorType.LessOrEqual)),
                                                                      New GroupOperator(GroupOperatorType.And,
                                   New BinaryOperator(ProductionSchedule.Fields.Start.PropertyName, Date.Parse(String.Format("{0} 1:00", DateAdd(DateInterval.Day, 1, scheduleDate.Value).ToShortDateString())), BinaryOperatorType.Less),
                                   New BinaryOperator(ProductionSchedule.Fields.Finish.PropertyName, Date.Parse(String.Format("{0} 1:00", DateAdd(DateInterval.Day, 1, scheduleDate.Value).ToShortDateString())), BinaryOperatorType.Greater)),
                                                                      New GroupOperator(GroupOperatorType.And,
                                   New BinaryOperator(ProductionSchedule.Fields.Start.PropertyName, Date.Parse(String.Format("{0} 9:00", DateAdd(DateInterval.Day, 1, scheduleDate.Value).ToShortDateString())), BinaryOperatorType.Less),
                                   New BinaryOperator(ProductionSchedule.Fields.Finish.PropertyName, Date.Parse(String.Format("{0} 9:00", DateAdd(DateInterval.Day, 1, scheduleDate.Value).ToShortDateString())), BinaryOperatorType.Greater)))
            Case Else
                Return New GroupOperator(GroupOperatorType.Or, New GroupOperator(GroupOperatorType.And,
                                   New BinaryOperator(ProductionSchedule.Fields.Start.PropertyName, Date.Parse(String.Format("{0} 9:00", scheduleDate.Value.ToShortDateString())), BinaryOperatorType.GreaterOrEqual),
                                   New BinaryOperator(ProductionSchedule.Fields.Finish.PropertyName, Date.Parse(String.Format("{0} 9:00", DateAdd(DateInterval.Day, 1, scheduleDate.Value).ToShortDateString())), BinaryOperatorType.LessOrEqual)),
                                                                       New GroupOperator(GroupOperatorType.And,
                                   New BinaryOperator(ProductionSchedule.Fields.Start.PropertyName, Date.Parse(String.Format("{0} 9:00", scheduleDate.Value.ToShortDateString())), BinaryOperatorType.Less),
                                   New BinaryOperator(ProductionSchedule.Fields.Finish.PropertyName, Date.Parse(String.Format("{0} 9:00", scheduleDate.Value.ToShortDateString())), BinaryOperatorType.Greater)),
                                                                       New GroupOperator(GroupOperatorType.And,
                                   New BinaryOperator(ProductionSchedule.Fields.Start.PropertyName, Date.Parse(String.Format("{0} 9:00", DateAdd(DateInterval.Day, 1, scheduleDate.Value).ToShortDateString())), BinaryOperatorType.Less),
                                   New BinaryOperator(ProductionSchedule.Fields.Finish.PropertyName, Date.Parse(String.Format("{0} 9:00", DateAdd(DateInterval.Day, 1, scheduleDate.Value).ToShortDateString())), BinaryOperatorType.Greater)))
        End Select

    End Function

End Class
