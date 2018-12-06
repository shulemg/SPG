Imports System.Linq
Imports DevExpress
Imports DXDAL.SPGData

Public Class CostingXtraReport

    Private m_CurrentCost As Double
    Private m_CurrentPayrollTotal As Double
    Private m_CurrentQuantity As Double
    Private m_CurrentTotalPrice As Double
    Private m_IntervalHours As Double
    Private m_IntervalHoursMinusBreak As Double
    Private m_TimeDiffStartToStop As Long
    Private m_BreakMinutes As Long
    Private m_MinPerHour As Integer = 50
    Private m_OperatorsPay As Single = 1
    Private m_SupersPay As Single = 1
    Private m_PackersPay As Single = 1
    Private m_Minutes As Integer
    Private m_Totalminutestotal As Integer
    Private m_TotalPayrolltotal As Double = -0.0
    Private m_TotalCosttotal As Double = -0.0
    Private m_TotalProfitTotal As Double = 0.0
    Private m_TotalCostPerPiecetotal As Double = -0.0
    Private m_TotalPriceTotal As Double = 0.0
    Private m_TotalQtyProducedTotal As Integer = 0
    Private m_TotalOtherAmountTotal As Double = 0
    Private m_Expected As Double
    Private m_TotalExpected As Double
    Private m_MachineStandard As Double = 0
    Private m_MachinePackers As Double = 0
    Private m_CurrentProduction As Production

    Private Sub totalMinutesDetailXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles totalMinutesDetailXrLabel.BeforePrint

        Dim minOnJob As Integer = 0
        Try
            minOnJob = CInt(m_IntervalHoursMinusBreak * m_MinPerHour)
        Catch ex As Exception

        Finally
            totalMinutesDetailXrLabel.Text = Format(minOnJob, "#.##")
            m_Totalminutestotal += minOnJob
        End Try

    End Sub

    Private Sub actualSpeedDetailXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles actualSpeedDetailXrLabel.BeforePrint

        Try
            actualSpeedDetailXrLabel.Text = Format(CDbl(GetCurrentColumnValue("ActualSpeed")) / CType((m_IntervalHoursMinusBreak * m_MinPerHour), Integer), "0.00")
        Catch ex As Exception
            actualSpeedDetailXrLabel.Text = Nothing
        End Try

    End Sub

    Private Sub CostingXtraReport_BeforePrint(ByVal sender As Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles Me.BeforePrint

        m_MinPerHour = MainXtraForm.MinPerHOur
        m_PackersPay = MainXtraForm.PackersPay
        m_OperatorsPay = MainXtraForm.OperatorsPay
        m_SupersPay = MainXtraForm.SupersPay

    End Sub

    Private Sub payrollDetailXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles payrollDetailXrLabel.BeforePrint

        Try
            m_TotalPayrolltotal += m_CurrentPayrollTotal * -1
            payrollDetailXrLabel.Text = Format(m_CurrentPayrollTotal * -1, "$#,##0.00")
        Catch ex As Exception
            payrollDetailXrLabel.Text = "$0.00"
        End Try

    End Sub

    Private Sub costDetailXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles costDetailXrLabel.BeforePrint

        Try
            costDetailXrLabel.Text = Format(m_CurrentCost, "$#,##0.00")
            m_TotalCosttotal += m_CurrentCost
        Catch ex As Exception

        End Try

    End Sub

    Private Sub profitDetailXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles profitDetailXrLabel.BeforePrint

        Try
            Dim currentAbsoluteCost As Double = Math.Abs(m_CurrentCost)

            profitDetailXrLabel.Text = Format(m_CurrentTotalPrice - currentAbsoluteCost, "$#,##0.00")
            m_TotalProfitTotal += m_CurrentTotalPrice - currentAbsoluteCost
        Catch ex As Exception

        End Try

    End Sub

    Private Sub costPerPieceDetailXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles costPerPieceDetailXrLabel.BeforePrint

        Try
            costPerPieceDetailXrLabel.Text = Format(Math.Abs(m_CurrentCost / m_CurrentQuantity * -1), "$#,##0.00")
            m_TotalCostPerPiecetotal += Math.Abs(m_CurrentCost / m_CurrentQuantity * -1)
            m_TotalQtyProducedTotal += CInt(m_CurrentQuantity)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub packsPerMinuteDetailXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles packsPerMinuteDetailXrLabel.BeforePrint

        Dim interval As Integer = CInt(m_IntervalHoursMinusBreak * m_MinPerHour)
        packsPerMinuteDetailXrLabel.Text = Format(m_CurrentQuantity / interval, "0.00")

    End Sub

    Private Sub salesVsPayrollDetailXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles salesVsPayrollDetailXrLabel.BeforePrint

        Try
            salesVsPayrollDetailXrLabel.Text = Format(m_CurrentPayrollTotal / m_CurrentTotalPrice, "$#,##0.00")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub salesVsCostDetailXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles salesVsCostDetailXrLabel.BeforePrint

        Try
            salesVsCostDetailXrLabel.Text = Format(Math.Abs(m_CurrentCost) / m_CurrentTotalPrice, "$#,##0.00")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub profitVsSalesDetailXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles profitVsSalesDetailXrLabel.BeforePrint

        Try
            profitVsSalesDetailXrLabel.Text = Format(m_CurrentTotalPrice / (m_CurrentTotalPrice - Math.Abs(m_CurrentCost)), "$#,##0.00")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub totalMinutesFooterXRLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles totalMinutesFooterXRLabel.BeforePrint

        Me.totalMinutesFooterXRLabel.Text = CStr(m_Totalminutestotal)

    End Sub

    Private Sub payrollFooterXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles payrollFooterXrLabel.BeforePrint

        payrollFooterXrLabel.Text = Format(m_TotalPayrolltotal, "$#,##0.00")

    End Sub

    Private Sub costFooterXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles costFooterXrLabel.BeforePrint

        costFooterXrLabel.Text = Format(m_TotalCosttotal, "$#,##0.00")

    End Sub

    Private Sub profitFooterXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles profitFooterXrLabel.BeforePrint

        profitFooterXrLabel.Text = Format(m_TotalProfitTotal, "$#,##0.00")

    End Sub

    Private Sub costPerPieceFooterXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles costPerPieceFooterXrLabel.BeforePrint

        Try
            costPerPieceFooterXrLabel.Text = Format((Math.Abs(m_TotalCosttotal) / m_TotalQtyProducedTotal) * -1, "$#,##0.00")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub packsPerMinuteFooterXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles packsPerMinuteFooterXrLabel.BeforePrint

        Try
            packsPerMinuteFooterXrLabel.Text = Format(m_TotalQtyProducedTotal / m_Totalminutestotal, "0.00")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub salesVsPayrollFooterXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles salesVsPayrollFooterXrLabel.BeforePrint

        Try
            salesVsPayrollFooterXrLabel.Text = Format(m_TotalPayrolltotal / m_TotalPriceTotal, "$#,##0.00")
        Catch ex As Exception

        End Try

    End Sub


    Private Sub salesVsCostFooterXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles salesVsCostFooterXrLabel.BeforePrint

        Try
            salesVsCostFooterXrLabel.Text = Format(m_TotalCosttotal / m_TotalPriceTotal, "$#,##0.00")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub profitVsSalesFooterXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles profitVsSalesFooterXrLabel.BeforePrint

        Try
            profitVsSalesFooterXrLabel.Text = Format(m_TotalPriceTotal / m_TotalProfitTotal, "$#,##0.00")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub totalOtherDetailXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles totalOtherDetailXrLabel.BeforePrint

        Dim totalOtherAmount As Double = 0

        If Not IsDBNull(GetCurrentColumnValue("Other1")) Then totalOtherAmount += CDbl(GetCurrentColumnValue("Other1"))
        If Not IsDBNull(GetCurrentColumnValue("Other2")) Then totalOtherAmount += CDbl(GetCurrentColumnValue("Other2"))
        If Not IsDBNull(GetCurrentColumnValue("Other3")) Then totalOtherAmount += CDbl(GetCurrentColumnValue("Other3"))
        If Not IsDBNull(GetCurrentColumnValue("Other4")) Then totalOtherAmount += CDbl(GetCurrentColumnValue("Other4"))
        If Not IsDBNull(GetCurrentColumnValue("Other5")) Then totalOtherAmount += CDbl(GetCurrentColumnValue("Other5"))

        totalOtherDetailXrLabel.Text = Format(totalOtherAmount, "$#,##0.00")
        m_TotalOtherAmountTotal += totalOtherAmount

    End Sub

    Private Sub totalOtherFooterXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles totalOtherFooterXrLabel.BeforePrint

        totalOtherFooterXrLabel.Text = Format(m_TotalOtherAmountTotal, "$#,##0.00")

    End Sub

    Private Sub salesVsProfitDetailXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles salesVsProfitDetailXrLabel.BeforePrint

        Try
            salesVsProfitDetailXrLabel.Text = Format((m_CurrentTotalPrice - Math.Abs(m_CurrentCost)) / m_CurrentTotalPrice, "$#,##0.00")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub salesVsProfitFooterXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles salesVsProfitFooterXrLabel.BeforePrint

        Try
            salesVsProfitFooterXrLabel.Text = Format(m_TotalProfitTotal / m_TotalPriceTotal, "$#,##0.00")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub differenceFooterXRLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles differenceFooterXRLabel.BeforePrint

        Try
            differenceFooterXRLabel.Text = Format(m_TotalExpected - CDbl(Me.quantityFooterXRLabel.Summary.GetResult), "#,#")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub actualSpeedFooterXRLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles actualSpeedFooterXRLabel.BeforePrint

        Try
            actualSpeedFooterXRLabel.Text = Format(CDbl(Me.actualSpeedSummary.Summary.GetResult) / m_Totalminutestotal, "0.00")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint

        m_TimeDiffStartToStop = DateDiff(DateInterval.Minute, Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStart")), Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStop")))
        m_BreakMinutes = BreakTimeBLL.GetBreakMinutes(Convert.ToDateTime(GetCurrentColumnValue("ProdMainDate")), Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStart")), _
                                                      Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStop")))
        m_IntervalHours = m_TimeDiffStartToStop / 60
        m_IntervalHoursMinusBreak = (m_TimeDiffStartToStop - m_BreakMinutes) / 60
        m_CurrentPayrollTotal = CDbl(IIf(IsDBNull(GetCurrentColumnValue("ProdMainOperators")), 0, GetCurrentColumnValue("ProdMainOperators"))) * m_IntervalHoursMinusBreak * m_OperatorsPay + _
                                CDbl(IIf(IsDBNull(GetCurrentColumnValue("ProdMainPackers")), 0, GetCurrentColumnValue("ProdMainPackers"))) * m_IntervalHoursMinusBreak * m_PackersPay + _
                                CDbl(IIf(IsDBNull(GetCurrentColumnValue("ProdMainSupers")), 0, GetCurrentColumnValue("ProdMainSupers"))) * m_IntervalHoursMinusBreak * m_SupersPay
        m_CurrentCost = (m_CurrentPayrollTotal + CDbl(GetCurrentColumnValue("Freight")) + CDbl(GetCurrentColumnValue("Film")) + CDbl(GetCurrentColumnValue("Boxes")) + CDbl(GetCurrentColumnValue("StretchWrap")) + _
                         CDbl(GetCurrentColumnValue("Pallets")) + CDbl(GetCurrentColumnValue("Other1")) + CDbl(GetCurrentColumnValue("Other2")) + CDbl(GetCurrentColumnValue("Other3")) + _
                         CDbl(GetCurrentColumnValue("Other4")) + CDbl(GetCurrentColumnValue("Other5"))) * -1 + CDbl(GetCurrentColumnValue("Rebate"))
        m_CurrentQuantity = CDbl(GetCurrentColumnValue("ProdMainQuantity"))
        m_CurrentTotalPrice = CDbl(GetCurrentColumnValue("TotalPrice"))

        m_TotalPriceTotal += m_CurrentTotalPrice

        m_CurrentProduction = Xpo.XpoDefault.Session.GetObjectByKey(Of Production)(CInt(GetCurrentColumnValue("ProdMainID")))

        Dim MachineStandard As ItemMachineStandards
        If m_CurrentProduction IsNot Nothing Then
            MachineStandard = m_CurrentProduction.ProdMainItemID.MachineStandards.Where(Function(IMS) IMS.Machine.MachineLineID = m_CurrentProduction.ProdMainMachineLine.MachineLineID).FirstOrDefault()
            If MachineStandard IsNot Nothing Then
                If MachineStandard.MinutesPerShift > 0 Then
                    m_MinPerHour = CInt(MachineStandard.MinutesPerShift / 7.16667)
                Else If m_CurrentProduction.ProdMainItemID.MinutesPerShift > 0
                    m_MinPerHour = CInt(m_CurrentProduction.ProdMainItemID.MinutesPerShift / 7.1667)
                Else
                    m_MinPerHour = MainXtraForm.MinPerHOur
                End If
                If MachineStandard.ProductionPerMinute > 0 Then
                    m_MachineStandard = MachineStandard.ProductionPerMinute
                Else
                    m_MachineStandard = 0
                End If
                If MachineStandard.ProjectedPackers > 0 Then
                    m_MachinePackers = MachineStandard.ProjectedPackers
                Else
                    m_MachinePackers = 0
                End If
            Else
                If m_CurrentProduction.ProdMainItemID.MinutesPerShift > 0
                    m_MinPerHour = CInt(m_CurrentProduction.ProdMainItemID.MinutesPerShift / 7.1667)
                Else
                    m_MinPerHour = MainXtraForm.MinPerHOur
                End If
                m_MachineStandard = 0
                m_MachinePackers = 0
            End If
        Else
            m_MinPerHour = MainXtraForm.MinPerHOur
            m_MachineStandard = 0
            m_MachinePackers = 0
        End If

    End Sub

    Private Sub totalHoursDetailXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles totalHoursDetailXrLabel.BeforePrint

        totalHoursDetailXrLabel.Text = String.Format("{0}:{1}", Format((m_TimeDiffStartToStop - m_BreakMinutes) \ 60, "0"), Format(((m_TimeDiffStartToStop - m_BreakMinutes) Mod 60) \ 1, "00"))

    End Sub

    Private Sub totalMinutesHeaderXRLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles totalMinutesHeaderXRLabel.BeforePrint

       ' totalMinutesHeaderXRLabel.Text = String.Format("Total Minutes ({0}/Hour)", m_MinPerHour)

    End Sub

    Private Sub totalHoursFooterXRLabel_SummaryReset(ByVal sender As System.Object, ByVal e As EventArgs) Handles totalHoursFooterXRLabel.SummaryReset

        m_Minutes = 0

    End Sub

    Private Sub totalHoursFooterXRLabel_SummaryRowChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles totalHoursFooterXRLabel.SummaryRowChanged

        'This runs before Detail_BeforePrint
        m_Minutes += CInt(DateDiff(DateInterval.Minute, Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStart")), Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStop"))) - _
                        (BreakTimeBLL.GetBreakMinutes(Convert.ToDateTime(GetCurrentColumnValue("ProdMainDate")), Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStart")), _
                                                      Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStop")))))

    End Sub

    Private Sub totalHoursFooterXRLabel_SummaryGetResult(ByVal sender As System.Object, ByVal e As XtraReports.UI.SummaryGetResultEventArgs) Handles totalHoursFooterXRLabel.SummaryGetResult

        e.Result = String.Format("{0}:{1}", Format(m_Minutes \ 60, "##############0"), Format((m_Minutes Mod 60) \ 1, "00"))
        e.Handled = True

    End Sub

    Private Sub expectedDetailXrLabel_BeforePrint(ByVal sender As Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles expectedDetailXrLabel.BeforePrint

        '= m_IntervalHoursMinusBreak * Convert.ToDouble(GetCurrentColumnValue("ExpectedProduction"))
        If m_MachineStandard = 0 Then
            m_Expected = Convert.ToDouble(GetCurrentColumnValue("ExpectedProduction")) * CInt(m_IntervalHoursMinusBreak * m_MinPerHour) / ItemsBLL.GetQuantityPerUnit(CInt(GetCurrentColumnValue("ProdMainItemID")))
        Else
            m_Expected = m_MachineStandard * CInt(m_IntervalHoursMinusBreak * m_MinPerHour) / ItemsBLL.GetQuantityPerUnit(CInt(GetCurrentColumnValue("ProdMainItemID")))
        End If

        expectedDetailXrLabel.Text = Format(m_Expected, "#,#")
        m_TotalExpected += m_Expected

    End Sub

    Private Sub differenceDetailXrLabel_BeforePrint(ByVal sender As Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles differenceDetailXrLabel.BeforePrint

        differenceDetailXrLabel.Text = Format(m_CurrentQuantity - m_Expected, "#,#")

    End Sub

    Private Sub ReportHeader_BeforePrint(ByVal sender As Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles ReportHeader.BeforePrint

        m_Totalminutestotal = 0
        m_TotalPayrolltotal = -0.0
        m_TotalCosttotal = -0.0
        m_TotalProfitTotal = 0.0
        m_TotalCostPerPiecetotal = -0.0
        m_TotalPriceTotal = 0.0
        m_TotalQtyProducedTotal = 0
        m_TotalOtherAmountTotal = 0
        m_TotalExpected = 0

    End Sub

    Private Sub expectedFooterXRLabel_BeforePrint(ByVal sender As System.Object, ByVal e As Drawing.Printing.PrintEventArgs) Handles expectedFooterXRLabel.BeforePrint

        expectedFooterXRLabel.Text = Format(m_TotalExpected, "#,#")

    End Sub

End Class