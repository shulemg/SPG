Imports System.Linq
Imports DevExpress
Imports DXDAL.SPGData

Public Class ProductionXtraReport

    Private m_Minutes As Long
    Private m_BreakMinutes As Long
    Private m_TotalMinutes As Long = 0
    Private m_Expected As Single
    Private m_TotalExpected As Single = 0
    Private m_TotalDifference As Single = 0
    Private m_TotalActualSpeed As Single = 0
    Private m_TotalPayroll As Double = 0
    Private m_CurrentProduction As Production
    Private m_MinPerHour As Integer
    Private m_MachineStandard As Double
    Private m_MachinePackers As Double

    Private Sub totalHoursDetailXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles totalHoursDetailXrLabel.BeforePrint

        If totalHoursDetailXrLabel.Visible Then
            totalHoursDetailXrLabel.Text = String.Format("{0}:{1}", Format((m_Minutes - m_BreakMinutes) \ 60, "0"), Format(((m_Minutes - m_BreakMinutes) Mod 60) \ 1, "00"))
        End If

    End Sub

    Private Sub totalMinutesDetailXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles totalMinutesDetailXrLabel.BeforePrint

        If totalMinutesDetailXrLabel.Visible Then
            totalMinutesDetailXrLabel.Text = Format(((m_Minutes - m_BreakMinutes) / 60) * m_MinPerHour, "#.##")
        End If

    End Sub

    Private Sub expectedDetailXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles expectedDetailXrLabel.BeforePrint

        If expectedDetailXrLabel.Visible Then
            '= Convert.ToSingle(((m_Minutes - m_BreakMinutes) / 60)  * Convert.ToSingle(Me.GetCurrentColumnValue("ItemProdStandard")))
            If m_MachineStandard = 0 Then
                m_Expected = Convert.ToSingle(GetCurrentColumnValue("ItemProdStandard")) * CInt((m_Minutes - m_BreakMinutes) / 60 * m_MinPerHour) / CInt(GetCurrentColumnValue("intQtyPerUnit"))
            Else
                m_Expected = CSng(m_MachineStandard * CInt((m_Minutes - m_BreakMinutes) / 60 * m_MinPerHour) / CInt(GetCurrentColumnValue("intQtyPerUnit")))
            End If 

                expectedDetailXrLabel.Text = Format(m_Expected, "#.##")
            m_TotalExpected += m_Expected
        End If

    End Sub

    Private Sub differenceDetailXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles differenceDetailXrLabel.BeforePrint

        If differenceDetailXrLabel.Visible Then
            Dim difference As Single = Convert.ToSingle(Convert.ToSingle(Me.GetCurrentColumnValue("ProdMainQuantity")) - m_Expected)

            differenceDetailXrLabel.Text = Format(difference, "#.##")
            m_TotalDifference += difference
        End If

    End Sub

    Private Sub actualSpeedDetailXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles actualSpeedDetailXrLabel.BeforePrint

        If actualSpeedDetailXrLabel.Visible Then
            Dim actualSpeed As Single

            actualSpeed = ((Convert.ToSingle(Me.GetCurrentColumnValue("ProdMainQuantity")) * Convert.ToSingle(Me.GetCurrentColumnValue("intQtyPerUnit"))) / _
                           CType(((m_Minutes - m_BreakMinutes) / 60) * m_MinPerHour, Integer))
            If Single.IsInfinity(actualSpeed) OrElse Single.IsNaN(actualSpeed) Then

            Else
                actualSpeedDetailXrLabel.Text = Format(actualSpeed, "#.##")
                m_TotalActualSpeed += actualSpeed
            End If
        End If

    End Sub

    Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint

        m_Minutes = DateDiff(DateInterval.Minute, CType(Me.GetCurrentColumnValue("ProdMainTimeStart"), DateTime), CType(Me.GetCurrentColumnValue("ProdMainTimeStop"), DateTime))
        m_BreakMinutes = BreakTimeBLL.GetBreakMinutes(Convert.ToDateTime(GetCurrentColumnValue("ProdMainDate")), Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStart")), _
                                                      Convert.ToDateTime(GetCurrentColumnValue("ProdMainTimeStop")))
        m_TotalMinutes += m_Minutes - m_BreakMinutes

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

    Private Sub totalPayrollDetailXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles totalPayrollDetailXrLabel.BeforePrint

        If totalPayrollDetailXrLabel.Visible Then
            Dim totalPayroll As Double = Convert.ToDouble(GetCurrentColumnValue("ProdMainPackers")) * (m_Minutes - m_BreakMinutes) / 60 * MainXtraForm.PackersPay
            Me.totalPayrollDetailXrLabel.Text = Format(totalPayroll, "$0.00")
            m_TotalPayroll += totalPayroll
        End If

    End Sub

    Private Sub totalHoursFooterXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles totalHoursFooterXrLabel.BeforePrint

        If totalHoursFooterXrLabel.Visible Then
            totalHoursFooterXrLabel.Text = String.Format("{0}:{1}", Format(m_TotalMinutes \ 60, "#0"), Format((m_TotalMinutes Mod 60) \ 1, "00"))
        End If

    End Sub

    Private Sub expectedFooterXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles expectedFooterXrLabel.BeforePrint

        If expectedFooterXrLabel.Visible Then
            expectedFooterXrLabel.Text = Format(m_TotalExpected, "#,#")
        End If

    End Sub

    Private Sub differenceFooterXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles differenceFooterXrLabel.BeforePrint

        If differenceFooterXrLabel.Visible Then
            differenceFooterXrLabel.Text = Format(m_TotalDifference, "#,#")
        End If

    End Sub

    Private Sub actualSpeedFooterXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles actualSpeedFooterXrLabel.BeforePrint

        If actualSpeedFooterXrLabel.Visible Then
            actualSpeedFooterXrLabel.Text = Format(m_TotalActualSpeed / m_TotalMinutes, "0.00")
        End If

    End Sub

    Private Sub totalPayrollFooterXrLabel_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles totalPayrollFooterXrLabel.BeforePrint

        If totalPayrollFooterXrLabel.Visible Then
            totalPayrollFooterXrLabel.Text = Format(m_TotalPayroll, "$#,##0.00")
        End If

    End Sub

    Private Sub ReportHeader_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles ReportHeader.BeforePrint

        m_Minutes = 0
        m_TotalMinutes = 0
        m_TotalExpected = 0
        m_TotalDifference = 0
        m_TotalActualSpeed = 0
        m_TotalPayroll = 0

    End Sub

    Private Sub uomDetailXrLabel_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles uomDetailXrLabel.BeforePrint

        If m_CurrentProduction IsNot Nothing Then
            uomDetailXrLabel.Text = m_CurrentProduction.ProdMainItemID.strUnitOfMeasure
        End If

    End Sub

    Private Sub machineSpeedDetailXrLabel_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles machineSpeedDetailXrLabel.BeforePrint

        If m_MachineStandard = 0 Then
            If m_CurrentProduction IsNot Nothing Then
                machineSpeedDetailXrLabel.Text = CType(m_CurrentProduction.ProdMainItemID.ItemProdStandard, String)
            End If
        Else
            machineSpeedDetailXrLabel.Text = m_MachineStandard.ToString()
        End If

    End Sub

    Private Sub projectedPackersDetailXrLabel_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles projectedPackersDetailXrLabel.BeforePrint

        If m_MachinePackers = 0 Then
            If m_CurrentProduction IsNot Nothing Then
                projectedPackersDetailXrLabel.Text = CType(m_CurrentProduction.ProdMainItemID.Packers, String)
            End If
        Else
            projectedPackersDetailXrLabel.Text = m_MachinePackers.ToString()
        End If

    End Sub

    Private Sub reasonCodeDetailXrLabel_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles reasonCodeDetailXrLabel.BeforePrint

        If m_CurrentProduction IsNot Nothing Then
            reasonCodeDetailXrLabel.Text = m_CurrentProduction.Reasons
        End If

    End Sub

End Class