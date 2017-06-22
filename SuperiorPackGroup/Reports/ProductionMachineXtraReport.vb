Imports System.Linq
Imports DevExpress
Imports DXDAL.SPGData

Public Class ProductionMachineXtraReport

    Private m_IntervalHours As Double
    Private m_MachineMinutes As Integer
    Private m_MachineHours As Double
    Private m_ItemHours As Double
    Private m_ItemMinutes As Integer
    Private m_IntervalHoursMinusBreak As Double
    Private m_MinPerHour As Integer
    Private m_TimeDiffStartToStop As Long
    Private m_BreakMinutes As Long
    Private m_MachineAverageSpeed As Double
    Private m_ItemAverageSpeed As Double
    Private m_PackersPay As Double
    Private m_CurrentPayrollTotal As Double
    Private m_MachineAveragePackers As Double
    Private m_ItemAveragePackers As Double
    Private m_MachinePayroll As Double
    Private m_ItemPayroll As Double
    Private m_MachineProjectedCost As Double
    Private m_ItemProjectedCost As Double
    Private m_MachineAverageCost As Double
    Private m_ItemAverageCost As Double
    Private m_CustomerQuantity As Double
    Private m_CustomerProjectedQuantity As Double
    Private m_CompanyQuantity As Double = 0
    Private m_CompanyProjectedQuantity As Double = 0
    Private m_CustomerPackersCost As Double
    Private m_CustomerProjectedPackersCost As Double
    Private m_CompanyPackersCost As Double = 0
    Private m_CompanyProjectedPackersCost As Double = 0
    Private m_CustomerCost As Double
    Private m_CustomerProjectedCost As Double
    Private m_CompanyCost As Double = 0
    Private m_CompanyProjectedCost As Double = 0
    Private m_MachineStandard As Double = 0
    Private m_MachinePackers As Double = 0
    Private m_CurrentProduction As Production

    Private Sub machineGroupHeader_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles machineGroupHeader.BeforePrint

        m_MachineMinutes = 0
        m_MachineHours = 0
        m_MachineAverageSpeed = 0
        m_MachineAveragePackers = 0
        m_MachinePayroll = 0
        m_MachineProjectedCost = 0
        m_MachineAverageCost = 0

    End Sub

    Private Sub itemGroupHeader_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles itemGroupHeader.BeforePrint

        m_ItemMinutes = 0
        m_ItemHours = 0
        m_ItemAverageSpeed = 0
        m_ItemAveragePackers = 0
        m_ItemPayroll = 0
        m_ItemProjectedCost = 0
        m_ItemAverageCost = 0

    End Sub

    Private Sub customerGroupHeader_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles customerGroupHeader.BeforePrint

        m_CustomerQuantity = 0
        m_CustomerProjectedQuantity = 0
        m_CustomerPackersCost = 0
        m_CustomerProjectedPackersCost = 0
        m_CustomerCost = 0
        m_CustomerProjectedCost = 0

    End Sub

    Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint

        m_CurrentProduction = Xpo.XpoDefault.Session.GetObjectByKey(Of Production)(CInt(GetCurrentColumnValue("ProductionID")))

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

        m_TimeDiffStartToStop = DateDiff(DateInterval.Minute, Convert.ToDateTime(GetCurrentColumnValue("TimeStart")), Convert.ToDateTime(GetCurrentColumnValue("TimeStop")))
        m_BreakMinutes = BreakTimeBLL.GetBreakMinutes(Convert.ToDateTime(GetCurrentColumnValue("ProductionDate")), Convert.ToDateTime(GetCurrentColumnValue("TimeStart")), _
                                                      Convert.ToDateTime(GetCurrentColumnValue("TimeStop")))
        m_IntervalHoursMinusBreak = (m_TimeDiffStartToStop - m_BreakMinutes) / 60
        m_IntervalHours = m_TimeDiffStartToStop / 60
        m_CurrentPayrollTotal = CDbl(IIf(IsDBNull(GetCurrentColumnValue("ProductionPackers")), 0, GetCurrentColumnValue("ProductionPackers"))) * m_IntervalHoursMinusBreak * m_PackersPay

        m_MachineMinutes += CInt(m_IntervalHoursMinusBreak * m_MinPerHour)
        m_MachineHours += m_IntervalHours
        m_MachinePayroll += m_CurrentPayrollTotal

        If CDbl(GetCurrentColumnValue("ProjectedPackers")) > 0 OrElse m_MachinePackers > 0 Then
            m_CustomerPackersCost += CDbl(IIf(IsDBNull(GetCurrentColumnValue("ProductionPackers")), 0, GetCurrentColumnValue("ProductionPackers"))) * m_IntervalHoursMinusBreak * m_PackersPay
            m_CompanyPackersCost += CDbl(IIf(IsDBNull(GetCurrentColumnValue("ProductionPackers")), 0, GetCurrentColumnValue("ProductionPackers"))) * m_IntervalHoursMinusBreak * m_PackersPay
        End If

        If CDbl(GetCurrentColumnValue("ProjectedPackers")) > 0 OrElse m_MachinePackers > 0 Then
            If m_MachineStandard > 0 Then
                m_CustomerCost += (CDbl(IIf(IsDBNull(GetCurrentColumnValue("ProductionPackers")), 0, GetCurrentColumnValue("ProductionPackers"))) * m_IntervalHoursMinusBreak * m_PackersPay) /
                                CDbl(IIf(IsDBNull(GetCurrentColumnValue("Quantity")), 0, GetCurrentColumnValue("Quantity")))
                m_CompanyCost += (CDbl(IIf(IsDBNull(GetCurrentColumnValue("ProductionPackers")), 0, GetCurrentColumnValue("ProductionPackers"))) * m_IntervalHoursMinusBreak * m_PackersPay) /
                                    CDbl(IIf(IsDBNull(GetCurrentColumnValue("Quantity")), 0, GetCurrentColumnValue("Quantity")))
                If m_MachinePackers = 0 Then
                    m_CustomerProjectedCost += (CDbl(GetCurrentColumnValue("ProjectedPackers")) * m_IntervalHoursMinusBreak * m_PackersPay) /
                                                ((m_MachineStandard / CDbl(GetCurrentColumnValue("QtyPerUnit"))) * CInt(m_IntervalHoursMinusBreak * m_MinPerHour))
                    m_CompanyProjectedCost += (CDbl(GetCurrentColumnValue("ProjectedPackers")) * m_IntervalHoursMinusBreak * m_PackersPay) /
                                                ((m_MachineStandard / CDbl(GetCurrentColumnValue("QtyPerUnit"))) * CInt(m_IntervalHoursMinusBreak * m_MinPerHour))
                Else
                    m_CustomerProjectedCost += (m_MachinePackers * m_IntervalHoursMinusBreak * m_PackersPay) /
                                                ((m_MachineStandard / CDbl(GetCurrentColumnValue("QtyPerUnit"))) * CInt(m_IntervalHoursMinusBreak * m_MinPerHour))
                    m_CompanyProjectedCost += (m_MachinePackers * m_IntervalHoursMinusBreak * m_PackersPay) /
                                                ((m_MachineStandard / CDbl(GetCurrentColumnValue("QtyPerUnit"))) * CInt(m_IntervalHoursMinusBreak * m_MinPerHour))
                End If
            Else If CDbl(GetCurrentColumnValue("ProjectedSpeed")) > 0 Then  
                m_CustomerCost += (CDbl(IIf(IsDBNull(GetCurrentColumnValue("ProductionPackers")), 0, GetCurrentColumnValue("ProductionPackers"))) * m_IntervalHoursMinusBreak * m_PackersPay) /
                                CDbl(IIf(IsDBNull(GetCurrentColumnValue("Quantity")), 0, GetCurrentColumnValue("Quantity")))
                m_CompanyCost += (CDbl(IIf(IsDBNull(GetCurrentColumnValue("ProductionPackers")), 0, GetCurrentColumnValue("ProductionPackers"))) * m_IntervalHoursMinusBreak * m_PackersPay) /
                                    CDbl(IIf(IsDBNull(GetCurrentColumnValue("Quantity")), 0, GetCurrentColumnValue("Quantity")))
                If m_MachinePackers = 0 Then
                    m_CustomerProjectedCost += (CDbl(GetCurrentColumnValue("ProjectedPackers")) * m_IntervalHoursMinusBreak * m_PackersPay) /
                                                ((CDbl(GetCurrentColumnValue("ProjectedSpeed")) / CDbl(GetCurrentColumnValue("QtyPerUnit"))) * CInt(m_IntervalHoursMinusBreak * m_MinPerHour))
                    m_CompanyProjectedCost += (CDbl(GetCurrentColumnValue("ProjectedPackers")) * m_IntervalHoursMinusBreak * m_PackersPay) /
                                                ((CDbl(GetCurrentColumnValue("ProjectedSpeed")) / CDbl(GetCurrentColumnValue("QtyPerUnit"))) * CInt(m_IntervalHoursMinusBreak * m_MinPerHour))
                Else
                    m_CustomerProjectedCost += (m_MachinePackers * m_IntervalHoursMinusBreak * m_PackersPay) /
                                                ((CDbl(GetCurrentColumnValue("ProjectedSpeed")) / CDbl(GetCurrentColumnValue("QtyPerUnit"))) * CInt(m_IntervalHoursMinusBreak * m_MinPerHour))
                    m_CompanyProjectedCost += (m_MachinePackers * m_IntervalHoursMinusBreak * m_PackersPay) /
                                                ((CDbl(GetCurrentColumnValue("ProjectedSpeed")) / CDbl(GetCurrentColumnValue("QtyPerUnit"))) * CInt(m_IntervalHoursMinusBreak * m_MinPerHour))
                End If
            End If
        End If

    End Sub

    Private Sub ProductionMachineXtraReport_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint

       ' m_MinPerHour = If(MainXtraForm.MinPerHOur <> 0, MainXtraForm.MinPerHOur, 50)
        'Customer enters packers pay based on all breaks included
        m_PackersPay = If(MainXtraForm.PackersPay <> 0, MainXtraForm.PackersPay, 1)

    End Sub

    Private Sub machineTotalMinutesXRLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles machineTotalMinutesXRLabel.BeforePrint

        machineTotalMinutesXRLabel.Text = Format(m_MachineMinutes, "#.##")
        m_ItemMinutes += m_MachineMinutes
        m_ItemHours += m_MachineHours

    End Sub

    Private Sub itemMinutesXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles itemMinutesXrLabel.BeforePrint

        itemMinutesXrLabel.Text = Format(m_ItemMinutes, "#.##")

    End Sub

    Private Sub machineAverageSpeedXRLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles machineAverageSpeedXRLabel.BeforePrint

        m_MachineAverageSpeed = CDbl(machineQuantityXrLabel.Summary.GetResult()) * CDbl(GetCurrentColumnValue("QtyPerUnit")) / m_MachineMinutes
        machineAverageSpeedXRLabel.Text = Format(m_MachineAverageSpeed, "#,##0.00")

    End Sub

    Private Sub itemAverageSpeedXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles itemAverageSpeedXrLabel.BeforePrint

        m_ItemAverageSpeed = CDbl(itemQuantityXrLabel.Summary.GetResult()) * CDbl(GetCurrentColumnValue("QtyPerUnit")) / m_ItemMinutes
        itemAverageSpeedXrLabel.Text = Format(m_ItemAverageSpeed, "#,##0.00")

    End Sub

    Private Sub machineSpeedVariationVolumeXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles machineSpeedVariationVolumeXrLabel.BeforePrint

        If m_MachineStandard > 0 Then
            machineSpeedVariationVolumeXrLabel.Text = Format(m_MachineAverageSpeed - m_MachineStandard, "#,##0.00")
        Else
            machineSpeedVariationVolumeXrLabel.Text = Format(m_MachineAverageSpeed - CDbl(GetCurrentColumnValue("ProjectedSpeed")), "#,##0.00")
        End If            

    End Sub

    Private Sub itemSpeedVariationXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles itemSpeedVariationXrLabel.BeforePrint

        If m_MachineStandard > 0 Then
             itemSpeedVariationXrLabel.Text = Format(m_ItemAverageSpeed - m_MachineStandard, "#,##0.00")
        Else
             itemSpeedVariationXrLabel.Text = Format(m_ItemAverageSpeed - CDbl(GetCurrentColumnValue("ProjectedSpeed")), "#,##0.00")
        End If           

    End Sub

    Private Sub itemSpeedVariationPercentageXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles itemSpeedVariationPercentageXrLabel.BeforePrint

        m_ItemAverageSpeed = CDbl(itemQuantityXrLabel.Summary.GetResult()) * CDbl(GetCurrentColumnValue("QtyPerUnit")) / m_ItemMinutes
        Dim speedVariation As Double
        If m_MachineStandard > 0 Then
            speedVariation = (m_ItemAverageSpeed - m_MachineStandard) / m_MachineStandard
        Else
            speedVariation = (m_ItemAverageSpeed - CDbl(GetCurrentColumnValue("ProjectedSpeed"))) / CDbl(GetCurrentColumnValue("ProjectedSpeed"))
        End If
            
        If Double.IsNaN(speedVariation) Or Double.IsInfinity(speedVariation) Then
            'The projected speed is unknown.
            speedVariation = 0
        Else
            If m_MachineStandard > 0 Then
                m_CustomerProjectedQuantity += (m_MachineStandard / CDbl(GetCurrentColumnValue("QtyPerUnit"))) * m_ItemMinutes
                m_CompanyProjectedQuantity += (m_MachineStandard / CDbl(GetCurrentColumnValue("QtyPerUnit"))) * m_ItemMinutes
            Else
                m_CustomerProjectedQuantity += (CDbl(GetCurrentColumnValue("ProjectedSpeed")) / CDbl(GetCurrentColumnValue("QtyPerUnit"))) * m_ItemMinutes
                m_CompanyProjectedQuantity += (CDbl(GetCurrentColumnValue("ProjectedSpeed")) / CDbl(GetCurrentColumnValue("QtyPerUnit"))) * m_ItemMinutes
            End If
                
            m_CustomerQuantity += CDbl(itemQuantityXrLabel.Summary.GetResult())
            m_CompanyQuantity += CDbl(itemQuantityXrLabel.Summary.GetResult())
        End If
        itemSpeedVariationPercentageXrLabel.Text = Format(speedVariation, "%0.00")

    End Sub

    Private Sub machineSpeedVariationPercentageXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles machineSpeedVariationPercentageXrLabel.BeforePrint

        Dim speedVariation As Double
        If m_MachineStandard > 0 Then
            speedVariation = (m_MachineAverageSpeed - m_MachineStandard) / m_MachineStandard
        Else
            speedVariation = (m_MachineAverageSpeed - CDbl(GetCurrentColumnValue("ProjectedSpeed"))) / CDbl(GetCurrentColumnValue("ProjectedSpeed"))
        End If
            
        If Double.IsNaN(speedVariation) Or Double.IsInfinity(speedVariation) Then
            speedVariation = 0
        End If
        machineSpeedVariationPercentageXrLabel.Text = Format(speedVariation, "%0.00")

    End Sub

    Private Sub customerSpeedVariationPercentageXrLabel_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles customerSpeedVariationPercentageXrLabel.BeforePrint

        customerSpeedVariationPercentageXrLabel.Text = Format((m_CustomerQuantity - m_CustomerProjectedQuantity) / m_CustomerProjectedQuantity, "%0.00")

    End Sub


    Private Sub companySpeedVariationPercentageXrLabel_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles reportSpeedVariationPercentageXrLabel.BeforePrint

        reportSpeedVariationPercentageXrLabel.Text = Format((m_CompanyQuantity - m_CompanyProjectedQuantity) / m_CompanyProjectedQuantity, "%0.00")

    End Sub

    Private Sub machineAverageActualPackersXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles machineAverageActualPackersXrLabel.BeforePrint

        m_ItemPayroll += m_MachinePayroll
        m_MachineAveragePackers = (m_MachinePayroll / m_PackersPay) / m_MachineHours
        machineAverageActualPackersXrLabel.Text = Format(m_MachineAveragePackers, "#,##0.00")

    End Sub

    Private Sub machinePackersVariationVolumeXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles machinePackersVariationVolumeXrLabel.BeforePrint

        If m_MachinePackers = 0 Then
            machinePackersVariationVolumeXrLabel.Text = Format(m_MachineAveragePackers - CDbl(GetCurrentColumnValue("ProjectedPackers")), "#,##0.00")
        Else
            machinePackersVariationVolumeXrLabel.Text = Format(m_MachineAveragePackers - m_MachinePackers, "#,##0.00")
        End If

    End Sub

    Private Sub machinePackersVariationPercentageXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles machinePackersVariationPercentageXrLabel.BeforePrint

        Dim packersVariation As Double
        If m_MachinePackers = 0 Then
            packersVariation = (m_MachineAveragePackers - CDbl(GetCurrentColumnValue("ProjectedPackers"))) / CDbl(GetCurrentColumnValue("ProjectedPackers"))
        Else
            packersVariation = (m_MachineAveragePackers - m_MachinePackers) / m_MachinePackers
        End if
        If Double.IsNaN(packersVariation) Or Double.IsInfinity(packersVariation) Then
            packersVariation = 0
        End If
        machinePackersVariationPercentageXrLabel.Text = Format(packersVariation, "%0.00")

    End Sub

    Private Sub itemAverageActualPackersXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles itemAverageActualPackersXrLabel.BeforePrint

        m_ItemAveragePackers = (m_ItemPayroll / m_PackersPay) / m_ItemHours
        itemAverageActualPackersXrLabel.Text = Format(m_ItemAveragePackers, "#,##0.00")

    End Sub

    Private Sub itemPackersVariationVolumeXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles itemPackersVariationVolumeXrLabel.BeforePrint

        If m_MachinePackers = 0 Then
            itemPackersVariationVolumeXrLabel.Text = Format(m_ItemAveragePackers - CDbl(GetCurrentColumnValue("ProjectedPackers")), "#,##0.00")
        Else
            itemPackersVariationVolumeXrLabel.Text = Format(m_ItemAveragePackers - m_MachinePackers, "#,##0.00")
        End If

    End Sub

    Private Sub itemPackersVariationPercentageXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles itemPackersVariationPercentageXrLabel.BeforePrint

        m_ItemAveragePackers = (m_ItemPayroll / m_PackersPay) / m_ItemHours
        Dim packersVariation As Double
        If m_MachinePackers = 0 Then
            packersVariation = (m_ItemAveragePackers - CDbl(GetCurrentColumnValue("ProjectedPackers"))) / CDbl(GetCurrentColumnValue("ProjectedPackers"))
        Else
            packersVariation = (m_ItemAveragePackers - m_MachinePackers) / m_MachinePackers
        End If
        If Double.IsNaN(packersVariation) Or Double.IsInfinity(packersVariation) Then
            packersVariation = 0
        Else
            If m_MachinePackers = 0 Then
                m_CustomerProjectedPackersCost += CDbl(GetCurrentColumnValue("ProjectedPackers")) * m_ItemHours * m_PackersPay
                m_CompanyProjectedPackersCost += CDbl(GetCurrentColumnValue("ProjectedPackers")) * m_ItemHours * m_PackersPay
            Else
                m_CustomerProjectedPackersCost += m_MachinePackers * m_ItemHours * m_PackersPay
                m_CompanyProjectedPackersCost += m_MachinePackers * m_ItemHours * m_PackersPay
            End If
        End If
        itemPackersVariationPercentageXrLabel.Text = Format(packersVariation, "%0.00")

    End Sub

    Private Sub customerPackersVariationPercentageXrLabel_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles customerPackersVariationPercentageXrLabel.BeforePrint

        customerPackersVariationPercentageXrLabel.Text = Format((m_CustomerPackersCost - m_CustomerProjectedPackersCost) / m_CustomerProjectedPackersCost, "%0.00")

    End Sub

    Private Sub reportPackersVariationPercentageXrLabel_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles reportPackersVariationPercentageXrLabel.BeforePrint

        reportPackersVariationPercentageXrLabel.Text = Format((m_CompanyPackersCost - m_CompanyProjectedPackersCost) / m_CompanyProjectedPackersCost, "%0.00")

    End Sub

    Private Sub machineProjectedCostXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles machineProjectedCostXrLabel.BeforePrint

        'm_MachineProjectedCost = CDbl(IIf(IsDBNull(GetCurrentColumnValue("ProjectedPackers")), 0, GetCurrentColumnValue("ProjectedPackers"))) * m_IntervalHours * m_PackersPay / _
        '                            (CDbl(machineQuantityXrLabel.Summary.GetResult()) * CDbl(GetCurrentColumnValue("QtyPerUnit")))
        '8 = Hours we pay; 7 = Hours we produce
        If m_MachineStandard > 0 Then
            If m_MachinePackers = 0 Then
                m_MachineProjectedCost = 8 * m_PackersPay * CDbl(IIf(IsDBNull(GetCurrentColumnValue("ProjectedPackers")), 0, GetCurrentColumnValue("ProjectedPackers"))) / (m_MachineStandard * m_MinPerHour * 7)
            Else
                m_MachineProjectedCost = 8 * m_PackersPay * m_MachinePackers / (m_MachineStandard * m_MinPerHour * 7)
            End If
        Else
            If m_MachinePackers = 0 Then
                m_MachineProjectedCost = 8 * m_PackersPay * CDbl(IIf(IsDBNull(GetCurrentColumnValue("ProjectedPackers")), 0, GetCurrentColumnValue("ProjectedPackers"))) / _
                                    (CDbl(GetCurrentColumnValue("ProjectedSpeed")) * m_MinPerHour * 7)
            Else
                m_MachineProjectedCost = 8 * m_PackersPay * m_MachinePackers / (CDbl(GetCurrentColumnValue("ProjectedSpeed")) * m_MinPerHour * 7)
            End If
        End If
        

        If Double.IsNaN(m_MachineProjectedCost) Or Double.IsInfinity(m_MachineProjectedCost) Then
            m_MachineProjectedCost = 0
        End If
        machineProjectedCostXrLabel.Text = Format(m_MachineProjectedCost * -1, "$#,##0.0000")

    End Sub

    Private Sub machineAverageCostXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles machineAverageCostXrLabel.BeforePrint

        m_MachineAverageCost = m_MachinePayroll / (CDbl(machineQuantityXrLabel.Summary.GetResult()) * CDbl(GetCurrentColumnValue("QtyPerUnit")))
        machineAverageCostXrLabel.Text = Format(m_MachineAverageCost * -1, "$#,##0.0000")

    End Sub

    Private Sub machineCostVariationXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles machineCostVariationXrLabel.BeforePrint

        machineCostVariationXrLabel.Text = Format(m_MachineAverageCost - m_MachineProjectedCost, "$#,##0.0000")

    End Sub

    Private Sub machineCostVariationPercentageXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles machineCostVariationPercentageXrLabel.BeforePrint

        Dim costVariation As Double = (m_MachineAverageCost - m_MachineProjectedCost) / m_MachineProjectedCost
        If Double.IsNaN(costVariation) Or Double.IsInfinity(costVariation) Then
            costVariation = 0
        End If
        machineCostVariationPercentageXrLabel.Text = Format(costVariation, "%0.00")

    End Sub

    Private Sub itemProjectedCostXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles itemProjectedCostXrLabel.BeforePrint

        'm_ItemProjectedCost = CDbl(IIf(IsDBNull(GetCurrentColumnValue("ProjectedPackers")), 0, GetCurrentColumnValue("ProjectedPackers"))) * m_IntervalHours * m_PackersPay / _
        '                            (CDbl(itemQuantityXrLabel.Summary.GetResult()) * CDbl(GetCurrentColumnValue("QtyPerUnit")))
        If m_MachineStandard > 0 Then
            If m_MachinePackers = 0 Then
                m_ItemProjectedCost = 8 * m_PackersPay * CDbl(IIf(IsDBNull(GetCurrentColumnValue("ProjectedPackers")), 0, GetCurrentColumnValue("ProjectedPackers"))) / _
                                            (m_MachineStandard * m_MinPerHour * 7)
            Else
                m_ItemProjectedCost = 8 * m_PackersPay * m_MachinePackers / (m_MachineStandard * m_MinPerHour * 7)
            End If
        Else
            If m_MachinePackers = 0 Then
                m_ItemProjectedCost = 8 * m_PackersPay * CDbl(IIf(IsDBNull(GetCurrentColumnValue("ProjectedPackers")), 0, GetCurrentColumnValue("ProjectedPackers"))) / _
                                            (CDbl(GetCurrentColumnValue("ProjectedSpeed")) * m_MinPerHour * 7)
            Else
                m_ItemProjectedCost = 8 * m_PackersPay * m_MachinePackers / (CDbl(GetCurrentColumnValue("ProjectedSpeed")) * m_MinPerHour * 7)
            End If
        End If
        
        If Double.IsNaN(m_ItemProjectedCost) Or Double.IsInfinity(m_ItemProjectedCost) Then
            m_ItemProjectedCost = 0
        End If
        itemProjectedCostXrLabel.Text = Format(m_ItemProjectedCost * -1, "$#,##0.0000")

    End Sub

    Private Sub itemAverageCostXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles itemAverageCostXrLabel.BeforePrint

        m_ItemAverageCost = m_ItemPayroll / (CDbl(itemQuantityXrLabel.Summary.GetResult()) * CDbl(GetCurrentColumnValue("QtyPerUnit")))
        itemAverageCostXrLabel.Text = Format(m_ItemAverageCost * -1, "$#,##0.0000")

    End Sub

    Private Sub itemCostVariationXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles itemCostVariationXrLabel.BeforePrint

        If Double.IsNaN(m_ItemProjectedCost) Or Double.IsInfinity(m_ItemProjectedCost) Then
            m_ItemProjectedCost = 0
        End If
        itemCostVariationXrLabel.Text = Format(m_ItemAverageCost - m_ItemProjectedCost, "$#,##0.0000")

    End Sub

    Private Sub itemCostVariationPercentageXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles itemCostVariationPercentageXrLabel.BeforePrint

        m_ItemAverageCost = m_ItemPayroll / (CDbl(itemQuantityXrLabel.Summary.GetResult()) * CDbl(GetCurrentColumnValue("QtyPerUnit")))
        If m_MachineStandard > 0 Then
            If m_MachinePackers = 0 Then
                m_ItemProjectedCost = 8 * m_PackersPay * CDbl(IIf(IsDBNull(GetCurrentColumnValue("ProjectedPackers")), 0, GetCurrentColumnValue("ProjectedPackers"))) / _
                                            (m_MachineStandard * m_MinPerHour * 7)
            Else
                m_ItemProjectedCost = 8 * m_PackersPay * m_MachinePackers / (m_MachineStandard * m_MinPerHour * 7)
            End If
        Else
            If m_MachinePackers = 0 Then
                m_ItemProjectedCost = 8 * m_PackersPay * CDbl(IIf(IsDBNull(GetCurrentColumnValue("ProjectedPackers")), 0, GetCurrentColumnValue("ProjectedPackers"))) / _
                                            (CDbl(GetCurrentColumnValue("ProjectedSpeed")) * m_MinPerHour * 7)
            Else
                m_ItemProjectedCost = 8 * m_PackersPay * m_MachinePackers / (CDbl(GetCurrentColumnValue("ProjectedSpeed")) * m_MinPerHour * 7)
            End If
        End If
        
        Dim costVariation As Double = (m_ItemAverageCost - m_ItemProjectedCost) / m_ItemProjectedCost
        If Double.IsNaN(costVariation) Or Double.IsInfinity(costVariation) Then
            costVariation = 0
        End If
        itemCostVariationPercentageXrLabel.Text = Format(costVariation, "%0.00")

    End Sub

    Private Sub customerCostVariationPercentageXrLabel_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles customerCostVariationPercentageXrLabel.BeforePrint

        customerCostVariationPercentageXrLabel.Text = Format((m_CustomerCost - m_CustomerProjectedCost) / m_CustomerProjectedCost, "%0.00")

    End Sub

    Private Sub reportCostVariationPercentageXrLabel_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles reportCostVariationPercentageXrLabel.BeforePrint

        reportCostVariationPercentageXrLabel.Text = Format((m_CompanyCost - m_CompanyProjectedCost) / m_CompanyProjectedCost, "%0.00")

    End Sub

    Private Sub machineSalesVsPayrollXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles machineSalesVsPayrollXrLabel.BeforePrint

        machineSalesVsPayrollXrLabel.Text = Format(CDbl(GetCurrentColumnValue("pricePerPieceCalculatedField")) / m_MachineAverageCost, "#,##0.00")

    End Sub

    Private Sub itemSalesVsPayrollXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles itemSalesVsPayrollXrLabel.BeforePrint

        m_ItemAverageCost = m_ItemPayroll / (CDbl(itemQuantityXrLabel.Summary.GetResult()) * CDbl(GetCurrentColumnValue("QtyPerUnit")))
        Dim salesVsPayroll As Double = CDbl(GetCurrentColumnValue("pricePerPieceCalculatedField")) / m_ItemAverageCost
        If Double.IsNaN(salesVsPayroll) Or Double.IsInfinity(salesVsPayroll) Then
            salesVsPayroll = 0
        End If
        itemSalesVsPayrollXrLabel.Text = Format(salesVsPayroll, "#,##0.00")

    End Sub

    Private Sub ReportHeader_BeforePrint(sender As System.Object, e As System.Drawing.Printing.PrintEventArgs) Handles ReportHeader.BeforePrint

        m_CompanyQuantity = 0
        m_CompanyProjectedQuantity = 0
        m_CompanyPackersCost = 0
        m_CompanyProjectedPackersCost = 0
        m_CompanyCost = 0
        m_CompanyProjectedCost = 0

    End Sub

    Private Sub itemProjectedSpeedXrLabel_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles itemProjectedSpeedXrLabel.BeforePrint

        If m_MachineStandard > 0 Then
            itemProjectedSpeedXrLabel.Text = Format(m_MachineStandard, "#,##0.00")
        Else
            itemProjectedSpeedXrLabel.Text = Format(CDbl(GetCurrentColumnValue("ProjectedSpeed")), "#,##0.00")
        End If
         
    End Sub

    Private Sub machineProjectedSpeedXrLabel_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles machineProjectedSpeedXrLabel.BeforePrint
        
        If m_MachineStandard > 0 Then
            machineProjectedSpeedXrLabel.Text = Format(m_MachineStandard, "#,##0.00")
        Else
            machineProjectedSpeedXrLabel.Text = Format(CDbl(GetCurrentColumnValue("ProjectedSpeed")), "#,##0.00")
        End If
         
    End Sub

    Private Sub itemProjectedPackersXrLabel_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles itemProjectedPackersXrLabel.BeforePrint

        If m_MachinePackers > 0 Then
            itemProjectedPackersXrLabel.Text = Format(m_MachinePackers, "#,##0.00")
        Else
            itemProjectedPackersXrLabel.Text = Format(CDbl(GetCurrentColumnValue("ProjectedPackers")), "#,##0.00")
        End If

    End Sub

    Private Sub machineProjectedPackersXrLabel_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles machineProjectedPackersXrLabel.BeforePrint

        If m_MachinePackers > 0 Then
            machineProjectedPackersXrLabel.Text = Format(m_MachinePackers, "#,##0.00")
        Else
            machineProjectedPackersXrLabel.Text = Format(CDbl(GetCurrentColumnValue("ProjectedPackers")), "#,##0.00")
        End If

    End Sub

End Class